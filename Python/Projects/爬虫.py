from urllib import request
from urllib import error
from bs4 import BeautifulSoup as bs
import requests

def read_html(url):
    headers = {'User-Agent':'Mozilla/5.0  (Windows NT 10.0; WOW64) \
AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.67 Safari/537.36'}
    response = request.Request(url, headers=headers)
    html = request.urlopen(response)
    return html.read().decode('utf-8')

# 主页
main_page_html = read_html('http://www.zxcs.me/')
#print(main_page_html)

main_page_soup = bs(main_page_html, 'html.parser')    
main_page_box = main_page_soup.find_all('div', class_='box')
for item in main_page_box:
    box_list = item.find_all('a')
    for item in box_list:
        book_name = item.text
        book_page_url = item['href']
        print("书名：" + item.text)
        #print(book_page_url)
        book_page_html = read_html(book_page_url)
        book_page_soup = bs(book_page_html, 'html.parser')
        book_page_file_cont = book_page_soup.find('div', class_='filecont')
        down_page_url = book_page_file_cont.find('a')['href']
        #print(down_page_url)
        down_page_html = read_html(down_page_url)
        down_page_soup = bs(down_page_html, 'html.parser')
        down_page_file = down_page_soup.find('span', class_='downfile')
        file_url = down_page_file.find('a')['href']
        print("地址：" + file_url)
        print("下载中...")
        path = book_name + ".rar"
        r = requests.get(file_url)
        with open(path,"wb") as f:
            f.write(r.content)
            f.close()
        print("下载完成")
