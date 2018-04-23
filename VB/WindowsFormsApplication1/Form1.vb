Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim report As New XtraReport1()
			Dim tool As New ReportPrintTool(report)
			AddHandler tool.PreviewForm.PrintControl.PaintBookmarkArea, AddressOf PrintControl_PaintBookmarkArea
			tool.ShowPreviewDialog()
		End Sub

		Private Sub PrintControl_PaintBookmarkArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.Control.AreaPaintEventArgs)
			e.Graphics.DrawRectangle(New Pen(Color.Red, 2), Rectangle.Ceiling(e.Area))
		End Sub
	End Class
End Namespace
