from bs4 import BeautifulSoup
import requests

url = "https://coreyms.com/"

source = requests.get(url).text

soup = BeautifulSoup(source, 'lxml')

for article in soup.find_all('article'):

    headline = article.h2.a.text
    print(headline)

    summary = article.find('div', class_='entry-content').p.text
    print(summary)

    try:
        vid_src = article.find('iframe', class_='youtube-player')['src']
        vid_id = vid_src.split('/')[4]
        vid_id = vid_id.split('?')[0]
        video_link = "https://www.youtube.com/watch?v="+vid_id
    except Exception as e:
        video_link = None

    print(video_link)

    print()