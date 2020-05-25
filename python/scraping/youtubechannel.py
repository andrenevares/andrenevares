from bs4 import BeautifulSoup
import sys
import urllib.request
from PyQt5.QtWebEngineWidgets import QWebEnginePage
from PyQt5.QtWidgets import QApplication
from PyQt5.QtCore import QUrl
from PyQt5 import QtCore, QtWidgets, QtWebEngineWidgets, QtWebChannel

SCRIPT = """
var timeout = 1 * 1000;

var backend = null;

new QWebChannel(qt.webChannelTransport, function (channel) {
    backend = channel.objects.backend;
});

function try_send_data(){
    if(document.getElementById("spinner")){
        document.documentElement.scrollTo(0, document.body.scrollHeight || document.documentElement.scrollHeight);
        setTimeout(try_send_data, timeout)
        return
    }
    else{
        var titles = []
        for (let item of document.getElementsByClassName("yt-simple-endpoint style-scope ytd-grid-video-renderer")) {
            titles.push(item.innerText);
        }
        backend.set_titles(titles);
    }
}
setTimeout(try_send_data, timeout);
"""


class YTScrapper(QtCore.QObject):
    def __init__(self, url, parent=None):
        super().__init__(parent)

        self._titles = []

        app = QtWidgets.QApplication(sys.argv)
        self._page = QtWebEngineWidgets.QWebEnginePage(self)

        channel = QtWebChannel.QWebChannel(self)
        self.page.setWebChannel(channel)

        self._view = QtWebEngineWidgets.QWebEngineView()
        self._view.setAttribute(QtCore.Qt.WA_DontShowOnScreen, True)
        self._view.setPage(self.page)
        self._view.resize(1920, 1080)
        self._view.show()

        self.page.loadFinished.connect(self.on_load_finished)

        self.page.load(QtCore.QUrl(url))
        app.exec_()

    @property
    def titles(self):
        return self._titles

    @property
    def page(self):
        return self._page

    @QtCore.pyqtSlot(bool)
    def on_load_finished(self, ok):
        if ok:
            file = QtCore.QFile(":/qtwebchannel/qwebchannel.js")
            if file.open(QtCore.QIODevice.ReadOnly):
                content = file.readAll()
                file.close()
                self.page.runJavaScript(content.data().decode())
            self.page.webChannel().registerObject("backend", self)

            self.page.runJavaScript(SCRIPT)
        else:
            QtCore.QCoreApplication.quit()

    @QtCore.pyqtSlot(list)
    def set_titles(self, titles):
        self._titles = titles
        QtCore.QCoreApplication.quit()


def main():
    yt_scrapper = YTScrapper(
        "https://www.youtube.com/user/schafer5/videos"
    )
    for i, title in enumerate(yt_scrapper.titles, start=1):
        print(f"{i}. {title.encode('utf-8')}")


if __name__ == "__main__":
    main()
