Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020003DE RID: 990
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ItemCheckEventArgs
		Inherits ControlEventArgs

		' Token: 0x06003EF3 RID: 16115 RVA: 0x001B2A1F File Offset: 0x001B0C1F
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ItemCheckEventArgs)
			MyBase.New(A_0, A_1)
			Me.O_OO0.O. = A_2
		End Sub

		' Token: 0x17000DB1 RID: 3505
		' (get) Token: 0x06003EF4 RID: 16116 RVA: 0x001B2A30 File Offset: 0x001B0C30
		Public ReadOnly Property Index As Integer
			Get
				Return Me.O_OO0.O..Index
			End Get
		End Property

		' Token: 0x17000DB2 RID: 3506
		' (get) Token: 0x06003EF5 RID: 16117 RVA: 0x001B2A3D File Offset: 0x001B0C3D
		' (set) Token: 0x06003EF6 RID: 16118 RVA: 0x001B2A4D File Offset: 0x001B0C4D
		Public Property Checked As Boolean
			Get
				Return Me.O_OO0.O..NewValue = CheckState.Checked
			End Get
			Set(value As Boolean)
				If value Then
					Me.O_OO0.O..NewValue = CheckState.Checked
					Return
				End If
				Me.O_OO0.O..NewValue = CheckState.Unchecked
			End Set
		End Property

		' Token: 0x04001988 RID: 6536
		Private <<EMPTY_NAME>> As ItemCheckEventArgs
	End Class
End Namespace
