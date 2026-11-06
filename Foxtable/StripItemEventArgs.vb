Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x02000175 RID: 373
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class StripItemEventArgs
		' Token: 0x0600115F RID: 4447 RVA: 0x0006BFF0 File Offset: 0x0006A1F0
		Public Sub New(A_0 As ToolStrip, A_1 As ToolStripItem, A_2 As ToolStripItem, A_3 As Foxtable.WinForm.Form)
			Me.Ooo0.o. = A_0
			Me.Ooo0.o. = A_1
			Me.o_O__.0O. = A_2
			Me.Ooo0.o. = A_3
		End Sub

		' Token: 0x170003A9 RID: 937
		' (get) Token: 0x06001160 RID: 4448 RVA: 0x0006C015 File Offset: 0x0006A215
		Public ReadOnly Property Strip As Strip
			Get
				Return New Strip(Me.Ooo0.o., Me.Ooo0.o.)
			End Get
		End Property

		' Token: 0x170003AA RID: 938
		' (get) Token: 0x06001161 RID: 4449 RVA: 0x0006C028 File Offset: 0x0006A228
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property ParentItem As StripItem
			Get
				Dim result As StripItem
				If Me.o_O__.0O. Is Nothing Then
					result = Nothing
				Else
					result = New StripItem(Me.o_O__.0O., Me.Ooo0.o.)
				End If
				Return result
			End Get
		End Property

		' Token: 0x170003AB RID: 939
		' (get) Token: 0x06001162 RID: 4450 RVA: 0x0006C054 File Offset: 0x0006A254
		Public ReadOnly Property StripItem As StripItem
			Get
				Return New StripItem(Me.Ooo0.o., Me.Ooo0.o.)
			End Get
		End Property

		' Token: 0x170003AC RID: 940
		' (get) Token: 0x06001163 RID: 4451 RVA: 0x0006C067 File Offset: 0x0006A267
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.Ooo0.o.
			End Get
		End Property

		' Token: 0x04000690 RID: 1680
		Private <<EMPTY_NAME>> As ToolStrip

		' Token: 0x04000691 RID: 1681
		Private <<EMPTY_NAME>> As ToolStripItem

		' Token: 0x04000692 RID: 1682
		Private <<EMPTY_NAME>> As ToolStripItem

		' Token: 0x04000693 RID: 1683
		Private <<EMPTY_NAME>> As Foxtable.WinForm.Form
	End Class
End Namespace
