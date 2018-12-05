from urllib import request
from bs4 import BeautifulSoup as bs

resp = request.urlopen('http://www.zxcs.me/')
html_data = resp.read().decode('utf-8')
# print(html_data)

soup = bs(html_data, 'html.parser')    
box = soup.find_all('div', class_='box')
box_list = box[0].find_all('a')
# print(box_list)
for item in box_list:
    u = item['href']
    # print(u)
