namespace Watermark
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddWatermark = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.txbPathImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenWatermark = new System.Windows.Forms.Button();
            this.txbPathWatermark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxTypeOverlay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWatermark
            // 
            this.btnAddWatermark.Location = new System.Drawing.Point(186, 269);
            this.btnAddWatermark.Name = "btnAddWatermark";
            this.btnAddWatermark.Size = new System.Drawing.Size(146, 31);
            this.btnAddWatermark.TabIndex = 0;
            this.btnAddWatermark.Text = "Добавить водяной знак";
            this.btnAddWatermark.UseVisualStyleBackColor = true;
            this.btnAddWatermark.Click += new System.EventHandler(this.btnAddWatermark_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(410, 49);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 15;
            this.btnOpenImage.Text = "Открыть файл";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txbPathImage
            // 
            this.txbPathImage.Location = new System.Drawing.Point(26, 51);
            this.txbPathImage.Margin = new System.Windows.Forms.Padding(2);
            this.txbPathImage.Name = "txbPathImage";
            this.txbPathImage.Size = new System.Drawing.Size(327, 20);
            this.txbPathImage.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите изображение:";
            // 
            // btnOpenWatermark
            // 
            this.btnOpenWatermark.Location = new System.Drawing.Point(410, 109);
            this.btnOpenWatermark.Name = "btnOpenWatermark";
            this.btnOpenWatermark.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWatermark.TabIndex = 18;
            this.btnOpenWatermark.Text = "Открыть файл";
            this.btnOpenWatermark.UseVisualStyleBackColor = true;
            this.btnOpenWatermark.Click += new System.EventHandler(this.btnOpenWatermark_Click);
            // 
            // txbPathWatermark
            // 
            this.txbPathWatermark.Location = new System.Drawing.Point(26, 111);
            this.txbPathWatermark.Margin = new System.Windows.Forms.Padding(2);
            this.txbPathWatermark.Name = "txbPathWatermark";
            this.txbPathWatermark.Size = new System.Drawing.Size(327, 20);
            this.txbPathWatermark.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Выберите водяной знак:";
            // 
            // cmbxTypeOverlay
            // 
            this.cmbxTypeOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTypeOverlay.FormattingEnabled = true;
            this.cmbxTypeOverlay.Items.AddRange(new object[] {
            "Замостить",
            "По центру",
            "Растянуть"});
            this.cmbxTypeOverlay.Location = new System.Drawing.Point(99, 233);
            this.cmbxTypeOverlay.Name = "cmbxTypeOverlay";
            this.cmbxTypeOverlay.Size = new System.Drawing.Size(327, 21);
            this.cmbxTypeOverlay.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Выберите тип наложения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Выберите угол поворота:";
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(99, 184);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(327, 20);
            this.numericUpDownAngle.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 319);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxTypeOverlay);
            this.Controls.Add(this.btnOpenWatermark);
            this.Controls.Add(this.txbPathWatermark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.txbPathImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddWatermark);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWatermark;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TextBox txbPathImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenWatermark;
        private System.Windows.Forms.TextBox txbPathWatermark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxTypeOverlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
    }
}

