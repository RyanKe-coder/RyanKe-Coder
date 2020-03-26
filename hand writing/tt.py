
import sys
from PyQt5.QtWidgets import (QApplication, QWidget)
from PyQt5.QtGui import (QPainter, QPen)
from PyQt5.QtCore import Qt

class Example(QWidget):
    def __init__(self):
        super(Example, self).__init__()
        self.resize(400, 300)
        self.move(100, 100)
        self.setWindowTitle("觸控螢幕畫圖程式")
        self.setMouseTracking(False)
        self.pos_xy = []

    def paintEvent(self, event):
        painter = QPainter()
        painter.begin(self)
        pen = QPen(Qt.black, 2, Qt.SolidLine)
        painter.setPen(pen)

        if len(self.pos_xy) > 1:
            point_start = self.pos_xy[0]
            for pos_tmp in self.pos_xy:
                point_end = pos_tmp
                if point_end == (-1, -1):
                    point_start = (-1, -1)
                    continue
                if point_start == (-1, -1):
                    point_start = point_end
                    continue

                painter.drawLine(point_start[0], point_start[1], point_end[0], point_end[1])
                point_start = point_end
            painter.end()

    def mouseMoveEvent(self, event):
        #中間變數pos_tmp提取當前點
        pos_tmp = (event.pos().x(), event.pos().y())
        #pos_tmp新增到self.pos_xy中
        self.pos_xy.append(pos_tmp)
        self.update()
    def mouseReleaseEvent(self, event):
        pos_test = (-1, -1)
        self.pos_xy.append(pos_test)
        self.update()

if __name__ == "__main__":
    app = QApplication(sys.argv)
    pyqt_learn = Example()
    pyqt_learn.show()
    app.exec_()