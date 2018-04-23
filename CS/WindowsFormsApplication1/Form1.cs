using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.PreviewForm.PrintControl.PaintBookmarkArea += new EventHandler<DevExpress.XtraPrinting.Control.AreaPaintEventArgs>(PrintControl_PaintBookmarkArea);
            tool.ShowPreviewDialog();
        }

        void PrintControl_PaintBookmarkArea(object sender, DevExpress.XtraPrinting.Control.AreaPaintEventArgs e) {
            e.Graphics.DrawRectangle(new Pen(Color.Red, 2), Rectangle.Ceiling(e.Area));
        }
    }
}
