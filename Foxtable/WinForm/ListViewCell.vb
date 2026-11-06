Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x020004F8 RID: 1272
	<ComVisible(True)>
	Public Class ListViewCell
		' Token: 0x06005192 RID: 20882 RVA: 0x0021ADCB File Offset: 0x00218FCB
		Public Sub New(A_0 As ListViewItem.ListViewSubItem)
			Me.O.oo_oO. = A_0
		End Sub

		' Token: 0x170012B1 RID: 4785
		' (get) Token: 0x06005193 RID: 20883 RVA: 0x0021ADDA File Offset: 0x00218FDA
		Public ReadOnly Property Name As String
			Get
				Return Me.O.oo_oO..Name
			End Get
		End Property

		' Token: 0x170012B2 RID: 4786
		' (get) Token: 0x06005194 RID: 20884 RVA: 0x0021ADE7 File Offset: 0x00218FE7
		' (set) Token: 0x06005195 RID: 20885 RVA: 0x0021ADF4 File Offset: 0x00218FF4
		Public Property Text As String
			Get
				Return Me.O.oo_oO..Text
			End Get
			Set(value As String)
				Me.O.oo_oO..Text = value
			End Set
		End Property

		' Token: 0x170012B3 RID: 4787
		' (get) Token: 0x06005196 RID: 20886 RVA: 0x0021AE02 File Offset: 0x00219002
		' (set) Token: 0x06005197 RID: 20887 RVA: 0x0021AE0F File Offset: 0x0021900F
		Public Property BackColor As Color
			Get
				Return Me.O.oo_oO..BackColor
			End Get
			Set(value As Color)
				Me.O.oo_oO..BackColor = value
			End Set
		End Property

		' Token: 0x170012B4 RID: 4788
		' (get) Token: 0x06005198 RID: 20888 RVA: 0x0021AE1D File Offset: 0x0021901D
		' (set) Token: 0x06005199 RID: 20889 RVA: 0x0021AE2A File Offset: 0x0021902A
		Public Property ForeColor As Color
			Get
				Return Me.O.oo_oO..ForeColor
			End Get
			Set(value As Color)
				Me.O.oo_oO..ForeColor = value
			End Set
		End Property

		' Token: 0x170012B5 RID: 4789
		' (get) Token: 0x0600519A RID: 20890 RVA: 0x0021AE38 File Offset: 0x00219038
		' (set) Token: 0x0600519B RID: 20891 RVA: 0x0021AE45 File Offset: 0x00219045
		Public Property Font As Font
			Get
				Return Me.O.oo_oO..Font
			End Get
			Set(value As Font)
				Me.O.oo_oO..Font = value
			End Set
		End Property

		' Token: 0x170012B6 RID: 4790
		' (get) Token: 0x0600519C RID: 20892 RVA: 0x0021AE53 File Offset: 0x00219053
		' (set) Token: 0x0600519D RID: 20893 RVA: 0x0021AE60 File Offset: 0x00219060
		Public Property Tag As Object
			Get
				Return Me.O.oo_oO..Tag
			End Get
			Set(value As Object)
				Me.O.oo_oO..Tag = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x0600519E RID: 20894 RVA: 0x0021AE73 File Offset: 0x00219073
		Public Sub ResetStyle()
			Me.O.oo_oO..ResetStyle()
		End Sub

		' Token: 0x170012B7 RID: 4791
		' (get) Token: 0x0600519F RID: 20895 RVA: 0x0021AE80 File Offset: 0x00219080
		Public ReadOnly Property Bounds As Rectangle
			Get
				Return Me.O.oo_oO..Bounds
			End Get
		End Property

		' Token: 0x040021B5 RID: 8629
		Private <<EMPTY_NAME>> As ListViewItem.ListViewSubItem
	End Class
End Namespace
