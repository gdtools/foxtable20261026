Imports System
Imports System.Windows.Forms
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000157 RID: 343
	Public Class GanttTaskBarClickEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FBD RID: 4029 RVA: 0x00069102 File Offset: 0x00067302
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As TaskBarClickEventArgs)
			MyBase.New(A_0, A_1)
			Me.O0_.0O0o. = A_2
		End Sub

		' Token: 0x170002EF RID: 751
		' (get) Token: 0x06000FBE RID: 4030 RVA: 0x00069113 File Offset: 0x00067313
		Public ReadOnly Property Task As Task
			Get
				Return CType(Me.O0_.0O0o..Task, Task)
			End Get
		End Property

		' Token: 0x170002F0 RID: 752
		' (get) Token: 0x06000FBF RID: 4031 RVA: 0x00069125 File Offset: 0x00067325
		Public ReadOnly Property Button As MouseButtons
			Get
				Return Me.O0_.0O0o..Button
			End Get
		End Property

		' Token: 0x04000606 RID: 1542
		Private <<EMPTY_NAME>> As TaskBarClickEventArgs
	End Class
End Namespace
