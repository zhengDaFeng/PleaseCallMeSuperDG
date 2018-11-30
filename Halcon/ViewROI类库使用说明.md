# ViewROIʹ���ֲ�

## ����

ViewROI���Ĺ��ܣ�
1.View���ṩͼ����ʾ���ƶ������š��ֲ��Ŵ�ȹ��ܡ�
2.ROI���ṩ����Rectangle1��Rectangle2��Circle��CircularArc��Line��ROI�Ĺ��ܡ�

��Ҫ����Ͷ���
HWndCtrl.cs - View����
ROIController.cs - ROI����
HObjectEntry.cs - ������󣬰�����ʾ�������ʾ����

## ʹ��

������
```csharp
HWndCtrl _viewCtrl = null;
ROIController _roiCtrl = null;
```
��ʼ����
```csharp
_viewCtrl = new HWndCtrl(hWindowControl);
_roiCtrl = new ROIController();
_viewCtrl.userROIController(_roiCtrl);
_roiCtrl.setViewController(_viewCtrl);
```
��ʾ��
```csharp
_viewCtrl.addIconicVar(ho_image); // ����������ʾͼƬ������Ķ���Ӧ��ΪHImage���͵ģ��÷����Ż�Ϊ������ImagePart
_viewCtrl.repain();
```
ͼ��鿴��
```csharp
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_NONE); // ��ʼ״̬
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_MOVE); // �ƶ�
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOM); // ���ţ�ԭ�������ǵ�����������ţ���Ϊ�鷳����Ϊ��������
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMWINDOW); // �ֲ��Ŵ�
_viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMANDMOVE); // ���ӵ�һ�ֲ鿴ģʽ���ȿ����ƶ�ͼ��Ҳ��������ͼ��
```
����ROI��
```csharp
_roiCtrl.setROIShape(new ROIRectangle1()); // ���������ĳ�����
_roiCtrl.setROIShape(new ROIRectangle2()); // ��������ת�ĳ�����
_roiCtrl.setROIShape(new ROICircle()); // ����Բ��
_roiCtrl.setROIShape(new ROICircularArc()); // �����������Բ��
_roiCtrl.setROIShape(new ROILine()); // ������������߶�
```
����View��ROI����ʼ״̬
```csharp
_viewCtrl.resetAll();
_viewCtrl.repaint();
```