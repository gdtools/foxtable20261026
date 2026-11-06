Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Gauge
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200014D RID: 333
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class GaugeItemMouseEventArgs
		Inherits GaugeItemEventArgs

		' Token: 0x06000F88 RID: 3976 RVA: 0x00068DB3 File Offset: 0x00066FB3
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ItemMouseEventArgs)
			MyBase.New(A_0, A_1, A_2)
			Me.O0_O0_.O. = A_2
		End Sub

		' Token: 0x170002CE RID: 718
		' (get) Token: 0x06000F89 RID: 3977 RVA: 0x00068DC5 File Offset: 0x00066FC5
		Public ReadOnly Property Button As MouseButtons
			Get
				Return Me.O0_O0_.O..Button
			End Get
		End Property

		' Token: 0x170002CF RID: 719
		' (get) Token: 0x06000F8A RID: 3978 RVA: 0x00068DD2 File Offset: 0x00066FD2
		Public ReadOnly Property Clicks As Integer
			Get
				Return Me.O0_O0_.O..Clicks
			End Get
		End Property

		' Token: 0x170002D0 RID: 720
		' (get) Token: 0x06000F8B RID: 3979 RVA: 0x00068DDF File Offset: 0x00066FDF
		Public ReadOnly Property Location As Point
			Get
				Return Me.O0_O0_.O..Location
			End Get
		End Property

		' Token: 0x170002D1 RID: 721
		' (get) Token: 0x06000F8C RID: 3980 RVA: 0x00068DEC File Offset: 0x00066FEC
		Public ReadOnly Property X As Integer
			Get
				Return Me.O0_O0_.O..X
			End Get
		End Property

		' Token: 0x170002D2 RID: 722
		' (get) Token: 0x06000F8D RID: 3981 RVA: 0x00068DF9 File Offset: 0x00066FF9
		Public ReadOnly Property Y As Integer
			Get
				Return Me.O0_O0_.O..Y
			End Get
		End Property

		' Token: 0x040005F5 RID: 1525
		Private <<EMPTY_NAME>> As ItemMouseEventArgs
	End Class
End Namespace
