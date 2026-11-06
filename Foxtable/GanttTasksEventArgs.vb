Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000154 RID: 340
	Public Class GanttTasksEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FB0 RID: 4016 RVA: 0x00069005 File Offset: 0x00067205
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As CancelTasksArgs)
			MyBase.New(A_0, A_1)
			Me.OooOOO0O_0.0. = A_2
		End Sub

		' Token: 0x170002E7 RID: 743
		' (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00069018 File Offset: 0x00067218
		Public ReadOnly Property Tasks As List(Of Task)
			Get
				Dim list As List(Of Task) = New List(Of Task)()
				For Each baseTask As BaseTask In Me.OooOOO0O_0.0..Tasks
					If TypeOf baseTask Is Task Then
						list.Add(CType(baseTask, Task))
					End If
				Next
				Return list
			End Get
		End Property

		' Token: 0x170002E8 RID: 744
		' (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0006905E File Offset: 0x0006725E
		' (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0006906B File Offset: 0x0006726B
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.OooOOO0O_0.0..Cancel
			End Get
			Set(value As Boolean)
				Me.OooOOO0O_0.0..Cancel = True
			End Set
		End Property

		' Token: 0x04000603 RID: 1539
		Private <<EMPTY_NAME>> As CancelTasksArgs
	End Class
End Namespace
