﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark
{
    public partial class Form1 : Form
    {
        private string m_pathNameImage = null;
        private string m_pathNameWatermark = null;
        public Form1()
        {
            InitializeComponent();
            cmbxTypeOverlay.SelectedIndex = 0;
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*"; 
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    txbPathImage.Text = openFileDialog1.FileName;
                    m_pathNameImage = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void btnOpenWatermark_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog2.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.Multiselect = false;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                try
                {
                    txbPathWatermark.Text = openFileDialog2.FileName;
                    m_pathNameWatermark = openFileDialog2.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void btnAddWatermark_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(m_pathNameImage))
            {
                MessageBox.Show("Сначала выберите изображения для наложения!", "Ошибка");
            }
            else if (String.IsNullOrEmpty(m_pathNameWatermark))
            {
                MessageBox.Show("Сначала выберите водяной знак!", "Ошибка");
            }
            else
            {
                Bitmap Img = (Bitmap)Bitmap.FromFile(m_pathNameImage);
                Bitmap Watermark = (Bitmap)Bitmap.FromFile(m_pathNameWatermark);
                Bitmap NewWatermark = new Bitmap(Img.Width, Img.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                int x, y;

                using (Graphics g = Graphics.FromImage(NewWatermark))
                {
                    //int Angle = Int32.Parse(cmbxAngleRotation.Text);
                    int Angle = (int)numericUpDownAngle.Value;

                    float reduction;
                    int flagAngle = 0;
                    if (((Angle > 50) && (Angle < 130)) || ((Angle > 230) && (Angle < 310)))
                    {
                        reduction = (float)Img.Width / (float)Img.Height;
                        flagAngle = 1;
                    }
                    else
                    {
                        reduction = 1;
                    }
                    //
                   // float modRed = Math.Abs(((float)Img.Width % (float)Img.Height) / (float)Img.Height + 1);
                    //int vb = (int)Math.Round(Watermark.Height * modRed);
                    Watermark = RotateImage(Watermark, Angle);

                    switch (cmbxTypeOverlay.SelectedIndex) //в NewWatermark скопировать Watermark необходимым способом  Draw Image Angle\
                    {
                        case 0:
                            //сделать прозр черный цвет
                            //for (x = 0; x < Img.Width; x+= Wat.Wi* cor 2)
                            //    for (y = 0; y < Img.Width; y+= Wat.Wi* cor 2)
                            //             g.DrawImage(Watermark, x, y);

                            for (x = 0; x < Watermark.Width; x++)
                            {
                                for (y = 0; y < Watermark.Height; y++)
                                {
                                    Color c = Watermark.GetPixel(x, y);
                                    Watermark.SetPixel(x, y, Color.FromArgb((c.R + c.G + c.B) / 3, c.R, c.G, c.B));
                                }
                            }

                            //int reduction1 = 3;
                            //Watermark.Width / reduction1
                            float newWatWidth = Img.Width / 3;
                            float newWatHeight = Img.Height / 3;

                            for (float xx = 0; xx < Img.Width; xx += newWatWidth + 0.01f * Img.Width)//Watermark.Width * (float)Math.Sqrt(2.0) / 2 / 5)  or Math.Abs(Watermark.Width * (float)Math.Sin(Angle)) / reduction1 + 15)
                            {
                                for (float yy = 15; yy < Img.Height; yy += newWatHeight + 0.01f * Img.Width)//Math.Abs(Watermark.Height * (float)Math.Cos(Angle)) / reduction1 + 15)
                                {
                                    g.DrawImage(Watermark, xx, yy, newWatWidth / reduction, newWatHeight / reduction);
                                }
                            }
                            break;

                        case 1:
                            float newWatWidth1 = Img.Width / 2;
                            float newWatHeight1 = Img.Height / 2;
                             g.DrawImage(Watermark, Img.Width / 2 - newWatWidth1 / 2, Img.Height / 2 - newWatHeight1 / 2, newWatWidth1, newWatHeight1);
                            //g.DrawImage(Watermark, (Img.Width - newWatWidth1 - newWatWidth1 / reduction * flagAngle / 4) / 2, (Img.Height - newWatHeight1 / reduction) / 2, newWatWidth1, newWatHeight1);
                            break;

                        case 2:
                           // g.DrawImage(Watermark, 0 + flagAngle *((modRed - 1)* Img.Width / 2) , 0 + flagAngle *((modRed - 1)* Img.Height), Img.Width / modRed, vb / modRed); //Img.Width / 2 - sizeRect / 2, Img.Height / 2 - sizeRect / 2,
                            g.DrawImage(Watermark, 0 + flagAngle * Watermark.Width * (reduction - 1) / 2, 0 + flagAngle * Watermark.Height * (reduction - 1) / 2, Img.Width / (1 + flagAngle * (reduction - 1)), Img.Height / (1 + flagAngle * (reduction - 1)));
                            break; // 

                        default:
                            break;
                    }
                }

                for (x = 0; x < Img.Width; x++)
                {
                    for (y = 0; y < Img.Height; y++)
                    {
                        Color W = NewWatermark.GetPixel(x, y);
                        Color I = Img.GetPixel(x, y);
                        Img.SetPixel(x, y, Color.FromArgb(0, SoftLight(I.R, W.R), SoftLight(I.G, W.G), SoftLight(I.B, W.B)));
                    }
                }
                Img.Save("NewImage.bmp");
                MessageBox.Show("Изображение сохранено в файл \"NewImage.bmp\" ", "Успех");
            }
            this.Close();
        }
        private int SoftLight(int src_a, int src_b)
        {
            float a = src_a / 255.0f, b = src_b / 255.0f;
            float result;

            if (b < 0.5f)
            {
                result = 2 * a * b + a * a * (1 - 2 * b);
            }
            else
            {
                result = 2 * a * (1 - b) + (float)Math.Sqrt(a) * (2 * b - 1);
            }

            if (result < 0)
            {
                result = 0;
            }
            else if (result > 1)
            {
                result = 1;
            }

            return (int)(result * 255);
        }

        public static Bitmap RotateImage(Bitmap b, float angle)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }

    }
}
