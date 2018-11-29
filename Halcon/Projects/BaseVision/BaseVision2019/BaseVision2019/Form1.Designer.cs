namespace BaseVision2019
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.hWindowControl_Main = new HalconDotNet.HWindowControl();
            this.toolStrip_ROI = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_ViewMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_None = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Move = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Mag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_ResetAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Rectangle1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Rectangle2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Circle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CircularArc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Line = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RemoveActive = new System.Windows.Forms.ToolStripButton();
            this.ToolStripMenuItem_ZoomAndMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ROI.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hWindowControl_Main
            // 
            this.hWindowControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hWindowControl_Main.BackColor = System.Drawing.Color.Black;
            this.hWindowControl_Main.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl_Main.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl_Main.Location = new System.Drawing.Point(12, 66);
            this.hWindowControl_Main.Name = "hWindowControl_Main";
            this.hWindowControl_Main.Size = new System.Drawing.Size(655, 475);
            this.hWindowControl_Main.TabIndex = 0;
            this.hWindowControl_Main.WindowSize = new System.Drawing.Size(655, 475);
            // 
            // toolStrip_ROI
            // 
            this.toolStrip_ROI.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_ROI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_ROI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Rectangle1,
            this.toolStripButton_Rectangle2,
            this.toolStripButton_Circle,
            this.toolStripButton_CircularArc,
            this.toolStripButton_Line,
            this.toolStripButton_RemoveActive});
            this.toolStrip_ROI.Location = new System.Drawing.Point(9, 36);
            this.toolStrip_ROI.Name = "toolStrip_ROI";
            this.toolStrip_ROI.Size = new System.Drawing.Size(631, 27);
            this.toolStrip_ROI.TabIndex = 1;
            this.toolStrip_ROI.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(9, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(71, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_ViewMode,
            this.toolStripButton_ResetAll});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(262, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton_ViewMode
            // 
            this.ToolStripButton_ViewMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_None,
            this.ToolStripMenuItem_Move,
            this.ToolStripMenuItem_Zoom,
            this.ToolStripMenuItem_Mag,
            this.ToolStripMenuItem_ZoomAndMove});
            this.ToolStripButton_ViewMode.Image = global::BaseVision2019.Properties.Resources.查看;
            this.ToolStripButton_ViewMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_ViewMode.Margin = new System.Windows.Forms.Padding(0);
            this.ToolStripButton_ViewMode.Name = "ToolStripButton_ViewMode";
            this.ToolStripButton_ViewMode.Size = new System.Drawing.Size(157, 27);
            this.ToolStripButton_ViewMode.Text = "查看图像 - None";
            // 
            // ToolStripMenuItem_None
            // 
            this.ToolStripMenuItem_None.Image = global::BaseVision2019.Properties.Resources.pointer;
            this.ToolStripMenuItem_None.Name = "ToolStripMenuItem_None";
            this.ToolStripMenuItem_None.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem_None.Text = "None";
            this.ToolStripMenuItem_None.Click += new System.EventHandler(this.ToolStripMenuItem_None_Click);
            // 
            // ToolStripMenuItem_Move
            // 
            this.ToolStripMenuItem_Move.Image = global::BaseVision2019.Properties.Resources.move;
            this.ToolStripMenuItem_Move.Name = "ToolStripMenuItem_Move";
            this.ToolStripMenuItem_Move.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem_Move.Text = "Move";
            this.ToolStripMenuItem_Move.Click += new System.EventHandler(this.ToolStripMenuItem_Move_Click);
            // 
            // ToolStripMenuItem_Zoom
            // 
            this.ToolStripMenuItem_Zoom.Image = global::BaseVision2019.Properties.Resources.zoom;
            this.ToolStripMenuItem_Zoom.Name = "ToolStripMenuItem_Zoom";
            this.ToolStripMenuItem_Zoom.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem_Zoom.Text = "Zoom";
            this.ToolStripMenuItem_Zoom.Click += new System.EventHandler(this.ToolStripMenuItem_Zoom_Click);
            // 
            // ToolStripMenuItem_Mag
            // 
            this.ToolStripMenuItem_Mag.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Mag.Image")));
            this.ToolStripMenuItem_Mag.Name = "ToolStripMenuItem_Mag";
            this.ToolStripMenuItem_Mag.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem_Mag.Text = "Magnification";
            this.ToolStripMenuItem_Mag.Click += new System.EventHandler(this.ToolStripMenuItem_Mag_Click);
            // 
            // toolStripButton_ResetAll
            // 
            this.toolStripButton_ResetAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ResetAll.Image")));
            this.toolStripButton_ResetAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ResetAll.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton_ResetAll.Name = "toolStripButton_ResetAll";
            this.toolStripButton_ResetAll.Size = new System.Drawing.Size(93, 25);
            this.toolStripButton_ResetAll.Text = "ResetAll";
            this.toolStripButton_ResetAll.Click += new System.EventHandler(this.toolStripButton_ResetAll_Click);
            // 
            // toolStripButton_Rectangle1
            // 
            this.toolStripButton_Rectangle1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rectangle1.Image")));
            this.toolStripButton_Rectangle1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rectangle1.Name = "toolStripButton_Rectangle1";
            this.toolStripButton_Rectangle1.Size = new System.Drawing.Size(115, 24);
            this.toolStripButton_Rectangle1.Text = "Rectangle1";
            this.toolStripButton_Rectangle1.Click += new System.EventHandler(this.toolStripButton_ROI_Click);
            // 
            // toolStripButton_Rectangle2
            // 
            this.toolStripButton_Rectangle2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rectangle2.Image")));
            this.toolStripButton_Rectangle2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rectangle2.Name = "toolStripButton_Rectangle2";
            this.toolStripButton_Rectangle2.Size = new System.Drawing.Size(115, 24);
            this.toolStripButton_Rectangle2.Text = "Rectangle2";
            this.toolStripButton_Rectangle2.Click += new System.EventHandler(this.toolStripButton_Rectangle2_Click);
            // 
            // toolStripButton_Circle
            // 
            this.toolStripButton_Circle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Circle.Image")));
            this.toolStripButton_Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Circle.Name = "toolStripButton_Circle";
            this.toolStripButton_Circle.Size = new System.Drawing.Size(74, 24);
            this.toolStripButton_Circle.Text = "Circle";
            this.toolStripButton_Circle.Click += new System.EventHandler(this.toolStripButton_Circle_Click);
            // 
            // toolStripButton_CircularArc
            // 
            this.toolStripButton_CircularArc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CircularArc.Image")));
            this.toolStripButton_CircularArc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CircularArc.Name = "toolStripButton_CircularArc";
            this.toolStripButton_CircularArc.Size = new System.Drawing.Size(113, 24);
            this.toolStripButton_CircularArc.Text = "CircularArc";
            this.toolStripButton_CircularArc.Click += new System.EventHandler(this.toolStripButton_CircularArc_Click);
            // 
            // toolStripButton_Line
            // 
            this.toolStripButton_Line.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Line.Image")));
            this.toolStripButton_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Line.Name = "toolStripButton_Line";
            this.toolStripButton_Line.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton_Line.Text = "Line";
            this.toolStripButton_Line.Click += new System.EventHandler(this.toolStripButton_Line_Click);
            // 
            // toolStripButton_RemoveActive
            // 
            this.toolStripButton_RemoveActive.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RemoveActive.Image")));
            this.toolStripButton_RemoveActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RemoveActive.Name = "toolStripButton_RemoveActive";
            this.toolStripButton_RemoveActive.Size = new System.Drawing.Size(139, 24);
            this.toolStripButton_RemoveActive.Text = "RemoveActive";
            this.toolStripButton_RemoveActive.Click += new System.EventHandler(this.toolStripButton_RemoveActive_Click);
            // 
            // ToolStripMenuItem_ZoomAndMove
            // 
            this.ToolStripMenuItem_ZoomAndMove.Image = global::BaseVision2019.Properties.Resources.hand;
            this.ToolStripMenuItem_ZoomAndMove.Name = "ToolStripMenuItem_ZoomAndMove";
            this.ToolStripMenuItem_ZoomAndMove.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItem_ZoomAndMove.Text = "Zoom && Move";
            this.ToolStripMenuItem_ZoomAndMove.Click += new System.EventHandler(this.ToolStripMenuItem_ZoomAndMove_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(679, 578);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip_ROI);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hWindowControl_Main);
            this.Name = "Form_Main";
            this.Text = "ViewDemo";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.toolStrip_ROI.ResumeLayout(false);
            this.toolStrip_ROI.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl_Main;
        private System.Windows.Forms.ToolStrip toolStrip_ROI;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rectangle1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rectangle2;
        private System.Windows.Forms.ToolStripButton toolStripButton_Circle;
        private System.Windows.Forms.ToolStripButton toolStripButton_CircularArc;
        private System.Windows.Forms.ToolStripButton toolStripButton_Line;
        private System.Windows.Forms.ToolStripButton toolStripButton_RemoveActive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripButton_ViewMode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_None;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Move;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Zoom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Mag;
        private System.Windows.Forms.ToolStripButton toolStripButton_ResetAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ZoomAndMove;
    }
}

