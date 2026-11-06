Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1GanttView
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000156 RID: 342
	Public Class GanttPaintDayEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000FB8 RID: 4024 RVA: 0x000690B7 File Offset: 0x000672B7
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As PaintDayEventArgs)
			MyBase.New(A_0, A_1)
			Me.O0_.0O0o. = A_2
		End Sub

		' Token: 0x170002EB RID: 747
		' (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000690C8 File Offset: 0x000672C8
		Public ReadOnly Property Task As Task
			Get
				Return CType(Me.O0_.0O0o..Task, Task)
			End Get
		End Property

		' Token: 0x170002EC RID: 748
		' (get) Token: 0x06000FBA RID: 4026 RVA: 0x000690DA File Offset: 0x000672DA
		Public ReadOnly Property [Date] As DateTime
			Get
				Return Me.O0_.0O0o..[Date]
			End Get
		End Property

		' Token: 0x170002ED RID: 749
		' (get) Token: 0x06000FBB RID: 4027 RVA: 0x000690E7 File Offset: 0x000672E7
		Public ReadOnly Property DateTime As DateTime
			Get
				Return Me.O0_.0O0o..DateTime
			End Get
		End Property

		' Token: 0x170002EE RID: 750
		' (set) Token: 0x06000FBC RID: 4028 RVA: 0x000690F4 File Offset: 0x000672F4
		Public WriteOnly Property BackColor As Color
			Set(value As Color)
				Me.O0_.0O0o..BackColor = value
			End Set
		End Property

		' Token: 0x04000605 RID: 1541
		Private <<EMPTY_NAME>> As PaintDayEventArgs
	End Class
End Namespace
