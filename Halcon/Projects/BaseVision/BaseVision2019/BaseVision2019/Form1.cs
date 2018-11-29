using System;
using System.Windows.Forms;
using ViewROI;

namespace BaseVision2019
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        HWndCtrl _HWndCtrl = null;
        ROIController _ROIController = null;

        HalconDotNet.HImage _Image = null;

        private enum ROIType
        {
            Rectangle1, Rectangle2, Circle, CircularArc, Line
        }

        private enum ViewMode
        {
            None, Move, Zoom, Magnification, ZoomAndMove
        }

        private void Init()
        {
            // Initialize ViewROI
            _HWndCtrl = new HWndCtrl(hWindowControl_Main);
            _ROIController = new ROIController();
            _HWndCtrl.useROIController(_ROIController);
            _ROIController.setViewController(_HWndCtrl);

            // Read a Image
            _Image = new HalconDotNet.HImage("patras");
            _HWndCtrl.addIconicVar(_Image);
            _HWndCtrl.repaint();

            changeViewMode(ViewMode.None);
        }

        private void createROI(ROIType type)
        {
            switch (type)
            {
                case ROIType.Rectangle1:
                    _ROIController.setROIShape(new ROIRectangle1());
                    break;
                case ROIType.Rectangle2:
                    _ROIController.setROIShape(new ROIRectangle2());
                    break;
                case ROIType.Circle:
                    _ROIController.setROIShape(new ROICircle());
                    break;
                case ROIType.CircularArc:
                    _ROIController.setROIShape(new ROICircularArc());
                    break;
                case ROIType.Line:
                    _ROIController.setROIShape(new ROILine());
                    break;
                default:
                    // Write Log
                    break;
            }
        }

        private void changeViewMode(ViewMode mode)
        {
            string vm = "查看图像 - ";
            ClearAllViewBtnChk();
            switch (mode)
            {
                case ViewMode.None:
                    _HWndCtrl.setViewState(HWndCtrl.MODE_VIEW_NONE);
                    ToolStripMenuItem_None.Checked = true;
                    ToolStripButton_ViewMode.Text = vm + "None";
                    break;
                case ViewMode.Move:
                    _HWndCtrl.setViewState(HWndCtrl.MODE_VIEW_MOVE);
                    ToolStripMenuItem_Move.Checked = true;
                    ToolStripButton_ViewMode.Text = vm + "Move";
                    break;
                case ViewMode.Zoom:
                    _HWndCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOM);
                    ToolStripMenuItem_Zoom.Checked = true;
                    ToolStripButton_ViewMode.Text = vm + "Zoom";
                    break;
                case ViewMode.Magnification:
                    _HWndCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMWINDOW);
                    ToolStripMenuItem_Mag.Checked = true;
                    ToolStripButton_ViewMode.Text = vm + "Magnification";
                    break;
                case ViewMode.ZoomAndMove:
                    _HWndCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOMANDMOVE);
                    ToolStripMenuItem_ZoomAndMove.Checked = true;
                    ToolStripButton_ViewMode.Text = vm + "ZoomAndMove";
                    break;
                default:
                    // Write Log Here.
                    break;
            }
        }

        private void ClearAllViewBtnChk()
        {
            ToolStripMenuItem_None.Checked = false;
            ToolStripMenuItem_Move.Checked = false;
            ToolStripMenuItem_Zoom.Checked = false;
            ToolStripMenuItem_Mag.Checked = false;
            ToolStripMenuItem_ZoomAndMove.Checked = false;
        }
        
        private void Form_Main_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void toolStripButton_ROI_Click(object sender, EventArgs e)
        {
            createROI(ROIType.Rectangle1);
        }

        private void toolStripButton_Rectangle2_Click(object sender, EventArgs e)
        {
            createROI(ROIType.Rectangle2);
        }

        private void toolStripButton_Circle_Click(object sender, EventArgs e)
        {
            createROI(ROIType.Circle);
        }

        private void toolStripButton_CircularArc_Click(object sender, EventArgs e)
        {
            createROI(ROIType.CircularArc);
        }

        private void toolStripButton_Line_Click(object sender, EventArgs e)
        {
            createROI(ROIType.Line);
        }

        private void toolStripButton_RemoveActive_Click(object sender, EventArgs e)
        {
            _ROIController.removeActive();
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            if (_HWndCtrl == null) return;
            _HWndCtrl.resetAll();
            _HWndCtrl.repaint();
        }

        private void ToolStripMenuItem_None_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.None);
        }

        private void ToolStripMenuItem_Move_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.Move);
        }

        private void ToolStripMenuItem_Zoom_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.Zoom);
        }

        private void ToolStripMenuItem_Mag_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.Magnification);
        }

        private void toolStripButton_ResetAll_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.None);
            _HWndCtrl.resetAll();
            _HWndCtrl.repaint();
        }

        private void ToolStripMenuItem_ZoomAndMove_Click(object sender, EventArgs e)
        {
            changeViewMode(ViewMode.ZoomAndMove);
        }
    }
}
