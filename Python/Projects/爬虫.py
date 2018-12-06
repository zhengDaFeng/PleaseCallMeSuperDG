from urllib import request
from bs4 import BeautifulSoup as bs
import requests

# 主页
resp = request.urlopen('http://www.zxcs.me/')
html_data = resp.read().decode('utf-8')
# print(html_data)

soup = bs(html_data, 'html.parser')    
box = soup.find_all('div', class_='box')
box_list = box[0].find_all('a')
# print(box_list)

# 书本页
index = 0;
for item in box_list:
    index += 1;
    u = item['href']
    # print(u)
    book_page = request.urlopen(u)
    book_page_html_data = book_page.read().decode('utf-8')
    # print(book_page_html_data)
    book_page_soup = bs(book_page_html_data, 'html.parser')
    book_page_content = book_page_soup.find_all('div', class_='filecont')
    book_download_page = book_page_content[0].find_all('a')
    
    # 下载页
    for item in book_download_page:
        book_download_page_url = item['href']
        # print(book_download_page_url)
        download_page = request.urlopen(book_download_page_url)
        download_page_html_data = download_page.read().decode('utf-8')
        download_page_soup = bs(download_page_html_data, 'html.parser')

        download_page_content = download_page_soup.find_all('div', class_='content')
        file_name = download_page_content[0].find_all('h2')[0].text
        
        print(file_name)
        
        download_page_download = download_page_soup.find_all('span', class_='downfile')
        downlowd_url = download_page_download[0].find_all('a')
        for item in downlowd_url:
            down_url = item['href'] # 下载链接
            # print(down_url)
            path = file_name + ".rar" 
            r = requests.get(down_url)
            with open(path,"wb") as f:
                f.write(r.content)
            f.close()
    
