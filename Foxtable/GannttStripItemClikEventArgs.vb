Imports System
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200014B RID: 331
	Public Class GannttStripItemClikEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F7E RID: 3966 RVA: 0x00068D17 File Offset: 0x00066F17
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As ToolStripItemClickedEventArgs)
			MyBase.New(A_0, A_1)
			Me.Oo.0_O00_. = A_2
			Me.Oo.0_O00_. = CType(A_0, GanttView)
		End Sub

		' Token: 0x170002C6 RID: 710
		' (get) Token: 0x06000F7F RID: 3967 RVA: 0x00068D34 File Offset: 0x00066F34
		Public ReadOnly Property GanttView As GanttView
			Get
				Return Me.Oo.0_O00_.
			End Get
		End Property

		' Token: 0x170002C7 RID: 711
		' (get) Token: 0x06000F80 RID: 3968 RVA: 0x00068D3C File Offset: 0x00066F3C
		Public ReadOnly Property StripItem As StripItem
			Get
				Return New StripItem(Me.Oo.0_O00_..ClickedItem, MyBase.Form)
			End Get
		End Property

		' Token: 0x040005F2 RID: 1522
		Private <<EMPTY_NAME>> As ToolStripItemClickedEventArgs

		' Token: 0x040005F3 RID: 1523
		Private <<EMPTY_NAME>> As GanttView
	End Class
End Namespace
