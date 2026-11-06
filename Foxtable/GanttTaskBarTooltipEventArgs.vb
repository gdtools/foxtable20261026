Imports System
Imports System.Windows.Forms
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000155 RID: 341
	Public Class GanttTaskBarTooltipEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FB4 RID: 4020 RVA: 0x00069079 File Offset: 0x00067279
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As TaskBarTooltipEventArgs)
			MyBase.New(A_0, A_1)
			Me.O0_.0O0o. = A_2
		End Sub

		' Token: 0x170002E9 RID: 745
		' (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0006908A File Offset: 0x0006728A
		Public ReadOnly Property Task As Task
			Get
				Return CType(Me.O0_.0O0o..Task, Task)
			End Get
		End Property

		' Token: 0x170002EA RID: 746
		' (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0006909C File Offset: 0x0006729C
		' (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000690A9 File Offset: 0x000672A9
		Public Property Tooltip As String
			Get
				Return Me.O0_.0O0o..Tooltip
			End Get
			Set(value As String)
				Me.O0_.0O0o..Tooltip = value
			End Set
		End Property

		' Token: 0x04000604 RID: 1540
		Private <<EMPTY_NAME>> As TaskBarTooltipEventArgs
	End Class
End Namespace
