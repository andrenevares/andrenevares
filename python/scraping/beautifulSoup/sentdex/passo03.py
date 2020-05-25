from bs4 import BeautifulSoup
import sys
import urllib.request
from PyQt5.QtWebEngineWidgets import QWebEnginePage
from PyQt5.QtWidgets import QApplication
from PyQt5.QtCore import QUrl


class Page(QWebEnginePage):
    def __init__(self, url):
        self.app = QApplication(sys.argv)
        QWebEnginePage.__init__(self)
        self.html = ''
        self.loadFinished.connect(self._on_load_finished)
        self.load(QUrl(url))
        self.app.exec_()

    def _on_load_finished(self):
        self.html = self.toHtml(self.Callable)
        print('Load finished')

    def Callable(self, html_str):
        self.html = html_str
        self.app.quit()


def main():
    page = Page(
        'https://www.youtube.com/channel/UCY50YjnaeI7ezvRagFWeWmw/videos')
    soup = BeautifulSoup(page.html, 'html.parser')
    what_i_search = soup.find('div', class_='style-scope ytd-grid-renderer')
    youtube_titles = what_i_search.find_all('h3')
    line = 0
    for youtube_title in youtube_titles:
        line = line + 1
        print(str(line) + ". " + youtube_title.text)


if __name__ == '__main__':
    main()
