# ViewROI使用手册

## 概述

ViewROI类库的功能：
1.View，提供图像显示、移动、缩放、局部放大等功能。
2.ROI，提供创建Rectangle1、Rectangle2、Circle、CircularArc、Line等ROI的功能。

主要的类和对象：
HWndCtrl.cs - View主类
ROIController.cs - ROI主类
HObjectEntry.cs - 构造对象，包含显示对象和显示设置

## 使用

声明：
```csharp
HWndCtrl _viewCtrl = null;
ROIController _roiCtrl = null;
```
初始化：
```csharp
_viewCtrl = new HWndCtrl(hWindowControl);
_roiCtrl = new ROIController();
_viewCtrl.userROIController(_roiCtrl);
_roiCtrl.setViewController(_viewCtrl);
```
显示：
```csharp
_viewCtrl.addIconicVar(ho_image); // 假如你想显示图片，传入的对象应该为HImage类型的，该方法才会为你设置ImagePart
_viewCtrl.repain();
```
图像查看：
```csharp
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_NONE); // 初始状态
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_MOVE); // 移动
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOM); // 缩放，原程序中是点击鼠标进行缩放，较为麻烦，改为滚轮缩放
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMWINDOW); // 局部放大
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMANDMOVE); // 增加的一种查看模式，既可以移动图像，也可以缩放图像
```
创建ROI：
```csharp
_roiCtrl.setROIShape(new ROIRectangle1()); // 创建正交的长方形
_roiCtrl.setROIShape(new ROIRectangle2()); // 创建可旋转的长方形
_roiCtrl.setROIShape(new ROICircle()); // 创建圆形
_roiCtrl.setROIShape(new ROICircularArc()); // 创建带方向的圆弧
_roiCtrl.setROIShape(new ROILine()); // 创建带方向的线段
```
重置View和ROI至初始状态
```csharp
_viewCtrl.resetAll();
_viewCtrl.repaint();
```