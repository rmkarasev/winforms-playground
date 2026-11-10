namespace winforms_playground;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        gridControl1 = new DevExpress.XtraGrid.GridControl();
        gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
        gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
        simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
        popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
        barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
        barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
        barManager1 = new DevExpress.XtraBars.BarManager(components);
        barDockControlTop = new DevExpress.XtraBars.BarDockControl();
        barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
        barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
        barDockControlRight = new DevExpress.XtraBars.BarDockControl();
        contextMenuStrip1 = new ContextMenuStrip(components);
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripMenuItem3 = new ToolStripMenuItem();
        simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
        barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
        ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // gridControl1
        // 
        gridControl1.Location = new Point(12, 12);
        gridControl1.MainView = gridView1;
        gridControl1.Name = "gridControl1";
        gridControl1.Size = new Size(422, 210);
        gridControl1.TabIndex = 0;
        gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
        // 
        // gridView1
        // 
        gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
        gridView1.GridControl = gridControl1;
        gridView1.Name = "gridView1";
        // 
        // gridColumn1
        // 
        gridColumn1.Caption = "gridColumn1";
        gridColumn1.Name = "gridColumn1";
        gridColumn1.Visible = true;
        gridColumn1.VisibleIndex = 0;
        // 
        // gridColumn2
        // 
        gridColumn2.Caption = "gridColumn2";
        gridColumn2.Name = "gridColumn2";
        gridColumn2.Visible = true;
        gridColumn2.VisibleIndex = 1;
        // 
        // simpleButton1
        // 
        simpleButton1.Location = new Point(471, 42);
        simpleButton1.Name = "simpleButton1";
        simpleButton1.Size = new Size(120, 23);
        simpleButton1.TabIndex = 1;
        simpleButton1.Text = "Show menu Win";
        simpleButton1.Click += simpleButton1_Click;
        // 
        // popupMenu1
        // 
        popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2, true), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem4), new DevExpress.XtraBars.LinkPersistInfo(barButtonItem3, true) });
        popupMenu1.Manager = barManager1;
        popupMenu1.Name = "popupMenu1";
        // 
        // barButtonItem1
        // 
        barButtonItem1.Caption = "Copy";
        barButtonItem1.Id = 0;
        barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
        barButtonItem1.Name = "barButtonItem1";
        // 
        // barButtonItem2
        // 
        barButtonItem2.Caption = "Export...";
        barButtonItem2.Id = 1;
        barButtonItem2.Name = "barButtonItem2";
        // 
        // barButtonItem3
        // 
        barButtonItem3.Caption = "Go to Check";
        barButtonItem3.Id = 2;
        barButtonItem3.Name = "barButtonItem3";
        // 
        // barManager1
        // 
        barManager1.DockControls.Add(barDockControlTop);
        barManager1.DockControls.Add(barDockControlBottom);
        barManager1.DockControls.Add(barDockControlLeft);
        barManager1.DockControls.Add(barDockControlRight);
        barManager1.Form = this;
        barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4 });
        barManager1.MaxItemId = 4;
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = DockStyle.Top;
        barDockControlTop.Location = new Point(0, 0);
        barDockControlTop.Manager = barManager1;
        barDockControlTop.Size = new Size(800, 0);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 450);
        barDockControlBottom.Manager = barManager1;
        barDockControlBottom.Size = new Size(800, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 0);
        barDockControlLeft.Manager = barManager1;
        barDockControlLeft.Size = new Size(0, 450);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(800, 0);
        barDockControlRight.Manager = barManager1;
        barDockControlRight.Size = new Size(0, 450);
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator1, toolStripMenuItem3 });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(181, 76);
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(180, 22);
        toolStripMenuItem1.Text = "toolStripMenuItem1";
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(180, 22);
        toolStripMenuItem2.Text = "toolStripMenuItem2";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(177, 6);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new Size(180, 22);
        toolStripMenuItem3.Text = "toolStripMenuItem3";
        // 
        // simpleButton2
        // 
        simpleButton2.Location = new Point(597, 42);
        simpleButton2.Name = "simpleButton2";
        simpleButton2.Size = new Size(120, 23);
        simpleButton2.TabIndex = 1;
        simpleButton2.Text = "Show menu Dx";
        simpleButton2.Click += simpleButton2_Click;
        // 
        // barButtonItem4
        // 
        barButtonItem4.Caption = "Print...";
        barButtonItem4.Id = 3;
        barButtonItem4.Name = "barButtonItem4";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(simpleButton2);
        Controls.Add(simpleButton1);
        Controls.Add(gridControl1);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
        ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraEditors.SimpleButton simpleButton1;
    private DevExpress.XtraBars.PopupMenu popupMenu1;
    private ContextMenuStrip contextMenuStrip1;
    private DevExpress.XtraEditors.SimpleButton simpleButton2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem toolStripMenuItem3;
    private DevExpress.XtraBars.BarButtonItem barButtonItem4;
}
