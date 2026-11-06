Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000148 RID: 328
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ControlMouseEventArgs
		Inherits MouseEventArgs

		' Token: 0x06000F6B RID: 3947 RVA: 0x00068B54 File Offset: 0x00066D54
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As MouseButtons, A_2 As Integer, A_3 As Integer, A_4 As Integer, A_5 As Integer, A_6 As Foxtable.WinForm.Form)
			MyBase.New(A_1, A_2, A_3, A_4, A_5)
			If TypeOf A_0 Is System.Windows.Forms.PictureBox AndAlso TypeOf A_0.Parent Is CustomPictureBox Then
				A_0 = A_0.Parent
			End If
			Me.oO_oOo_.O_Oo0. = A_0
			Me.oO_oOo_.O_Oo0. = A_6
		End Sub

		' Token: 0x170002BA RID: 698
		' (get) Token: 0x06000F6C RID: 3948 RVA: 0x00068B90 File Offset: 0x00066D90
		Public ReadOnly Property Sender As Object
			Get
				If Me.OO00_O0_._OO0. Is Nothing Then
					Me.OO00_O0_._OO0. = ooO_0O.o_O0.O_.(Me.oO_oOo_.O_Oo0.)
					Me.OO00_O0_._OO0..o.__O0O. = Me.Form
				End If
				Return Me.OO00_O0_._OO0.
			End Get
		End Property

		' Token: 0x170002BB RID: 699
		' (get) Token: 0x06000F6D RID: 3949 RVA: 0x00068BC2 File Offset: 0x00066DC2
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.oO_oOo_.O_Oo0.
			End Get
		End Property

		' Token: 0x170002BC RID: 700
		' (get) Token: 0x06000F6E RID: 3950 RVA: 0x00068BCA File Offset: 0x00066DCA
		Public ReadOnly Property X As Integer
			Get
				Return MyBase.X
			End Get
		End Property

		' Token: 0x170002BD RID: 701
		' (get) Token: 0x06000F6F RID: 3951 RVA: 0x00068BD2 File Offset: 0x00066DD2
		Public ReadOnly Property Y As Integer
			Get
				Return MyBase.Y
			End Get
		End Property

		' Token: 0x170002BE RID: 702
		' (get) Token: 0x06000F70 RID: 3952 RVA: 0x00068BDA File Offset: 0x00066DDA
		Public ReadOnly Property Button As MouseButtons
			Get
				Return MyBase.Button
			End Get
		End Property

		' Token: 0x170002BF RID: 703
		' (get) Token: 0x06000F71 RID: 3953 RVA: 0x00068BE2 File Offset: 0x00066DE2
		' (set) Token: 0x06000F72 RID: 3954 RVA: 0x00068BEA File Offset: 0x00066DEA
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.OO00_O0_._OO0.
			End Get
			Set(value As Boolean)
				Me.OO00_O0_._OO0. = value
			End Set
		End Property

		' Token: 0x040005EC RID: 1516
		Private <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x040005ED RID: 1517
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x040005EE RID: 1518
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040005EF RID: 1519
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Control
	End Class
End Namespace
