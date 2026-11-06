Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports C1.Win.C1Chart
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003A6 RID: 934
	<ComVisible(True)>
	Public Class ChartBuilder
		Inherits Chart

		' Token: 0x06003B38 RID: 15160 RVA: 0x00199018 File Offset: 0x00197218
		Public Sub New()
			MyBase.New(New C1Chart())
			Me.C1Chart.BackColor = Color.White
		End Sub
	End Class
End Namespace
