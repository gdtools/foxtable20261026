Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A9 RID: 681
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class UpDownButtonClickEventArgs
		Inherits ControlEventArgs

		' Token: 0x060023EB RID: 9195 RVA: 0x000F9C3D File Offset: 0x000F7E3D
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As Integer)
			MyBase.New(A_0, A_1)
			Me.O__00.__0_O. = A_2
		End Sub

		' Token: 0x1700083C RID: 2108
		' (get) Token: 0x060023EC RID: 9196 RVA: 0x000F9C4E File Offset: 0x000F7E4E
		Public ReadOnly Property Direction As Integer
			Get
				Return Me.O__00.__0_O.
			End Get
		End Property

		' Token: 0x04000EDD RID: 3805
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
