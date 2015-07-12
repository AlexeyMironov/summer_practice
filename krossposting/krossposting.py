# -*- coding: cp1251 -*-

import feedparser, requests, vk_api, time, os 

MAX_COUNT_NEWS = 3  #in fact (MAX_COUNT_NEWS + 1)
SLEEP_TIME = 20 #time in seconds
NEWS_FEED = "http://news.sportbox.ru/taxonomy/term/118/0/feed"
LOGIN = 'YOUR_LOGIN'
PASSWORD = 'YOUR_PASSWORD'

def captcha_handler(captcha):
    key = raw_input("Enter Captcha {0}: ".format(captcha.get_url())).strip()
    return captcha.try_again(key)

def posting(a, vk, feeds):
    while a >= 0:
        print feeds.entries[a].link
        vk.method("wall.post", {"owner_id":"YOUR_ID", "attachments": feeds.entries[a].link})
        time.sleep(SLEEP_TIME)
        a -= 1
    inpFile = open("link.db", "w")
    inpFile.write(feeds.entries[0].link);

def parser(vk):
    inpFile = open("link.db", "r")
    feeds = feedparser.parse(NEWS_FEED)
    if os.stat("link.db").st_size == 0:
        posting(MAX_COUNT_NEWS, vk, feeds)
    else:
        lastLink = inpFile.readline()
        a = -1
        for i in range(len(feeds.entries)):
            if feeds.entries[i].link == lastLink:
                a = i - 1
                break
        if a >= 0:
            if a > MAX_COUNT_NEWS:
                posting(MAX_COUNT_NEWS - 1, vk, feeds)
            else:
                posting(a, vk, feeds)
        else:
            print "No new news"
    
def main():
    vk = vk_api.VkApi(
            LOGIN, PASSWORD, scope = 'wall',
            captcha_handler = captcha_handler  #function to enter CAPTCHA
        )
    try:
        vk.authorization()
    except vk_api.AuthorizationError as error_msg:
        print(error_msg)
        return
    tools = vk_api.VkTools(vk)
    parser(vk)

main()

