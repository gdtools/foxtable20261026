Imports System
Imports System.Windows.Forms
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000153 RID: 339
	Public Class GanttTaskEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FAC RID: 4012 RVA: 0x00068FC7 File Offset: 0x000671C7
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As CancelTaskArgs)
			MyBase.New(A_0, A_1)
			Me.OooOOO0O_0.0. = A_2
		End Sub

		' Token: 0x170002E5 RID: 741
		' (get) Token: 0x06000FAD RID: 4013 RVA: 0x00068FD8 File Offset: 0x000671D8
		Public ReadOnly Property Task As Task
			Get
				Return CType(Me.OooOOO0O_0.0..Task, Task)
			End Get
		End Property

		' Token: 0x170002E6 RID: 742
		' (get) Token: 0x06000FAE RID: 4014 RVA: 0x00068FEA File Offset: 0x000671EA
		' (set) Token: 0x06000FAF RID: 4015 RVA: 0x00068FF7 File Offset: 0x000671F7
		Public Overridable Property Cancel As Boolean
			Get
				Return Me.OooOOO0O_0.0..Cancel
			End Get
			Set(value As Boolean)
				Me.OooOOO0O_0.0..Cancel = True
			End Set
		End Property

		' Token: 0x04000602 RID: 1538
		Private <<EMPTY_NAME>> As CancelTaskArgs
	End Class
End Namespace
