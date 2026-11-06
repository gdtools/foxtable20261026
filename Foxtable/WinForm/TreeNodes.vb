Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable.WinForm
	' Token: 0x02000526 RID: 1318
	<ComVisible(True)>
	Public Class TreeNodes
		Implements IEnumerable(Of TreeNode)

		' Token: 0x060056DD RID: 22237 RVA: 0x002234D8 File Offset: 0x002216D8
		Public Sub New(A_0 As TreeNodeCollection)
			Me.oO_0o_.0__O. = A_0
		End Sub

		' Token: 0x17001526 RID: 5414
		Public ReadOnly Default Property Item(Index As Integer) As TreeNode
			Get
				Return New TreeNode(CType(Me.oO_0o_.0__O.(Index), O_o__00Ooo))
			End Get
		End Property

		' Token: 0x17001527 RID: 5415
		Public ReadOnly Default Property Item(Name As String) As TreeNode
			Get
				Dim treeNode As TreeNode = Me.oO_0o_.0__O.(Name)
				Dim result As TreeNode
				If treeNode Is Nothing Then
					result = Nothing
				Else
					result = New TreeNode(CType(treeNode, O_o__00Ooo))
				End If
				Return result
			End Get
		End Property

		' Token: 0x17001528 RID: 5416
		' (get) Token: 0x060056E0 RID: 22240 RVA: 0x0022352E File Offset: 0x0022172E
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oO_0o_.0__O..Count
			End Get
		End Property

		' Token: 0x060056E1 RID: 22241 RVA: 0x0022353B File Offset: 0x0022173B
		Public Sub Clear()
			Me.oO_0o_.0__O..Clear()
		End Sub

		' Token: 0x060056E2 RID: 22242 RVA: 0x00223548 File Offset: 0x00221748
		Public Function Add(Name As String) As TreeNode
			Return Me.Add(Name, Name)
		End Function

		' Token: 0x060056E3 RID: 22243 RVA: 0x00223554 File Offset: 0x00221754
		Public Function Add(Name As String, Text As String) As TreeNode
			Dim o_o__00Ooo As O_o__00Ooo = New O_o__00Ooo()
			o_o__00Ooo.Name = Name
			o_o__00Ooo.Text = Text
			Me.oO_0o_.0__O..Add(o_o__00Ooo)
			Return New TreeNode(o_o__00Ooo)
		End Function

		' Token: 0x060056E4 RID: 22244 RVA: 0x00223588 File Offset: 0x00221788
		Public Function Add(Name As String, Text As String, ImageFile As String) As TreeNode
			Dim o_o__00Ooo As O_o__00Ooo = New O_o__00Ooo()
			Me.oO_0o_.0__O..Add(o_o__00Ooo)
			o_o__00Ooo.Name = Name
			o_o__00Ooo.Text = Text
			o_o__00Ooo.ImageFile = ImageFile
			Return New TreeNode(o_o__00Ooo)
		End Function

		' Token: 0x060056E5 RID: 22245 RVA: 0x002235C3 File Offset: 0x002217C3
		Public Function Insert(Name As String, Index As Integer) As TreeNode
			Return Me.Insert(Name, Name, Index)
		End Function

		' Token: 0x060056E6 RID: 22246 RVA: 0x002235D0 File Offset: 0x002217D0
		Public Function Insert(Name As String, Text As String, Index As Integer) As TreeNode
			Dim o_o__00Ooo As O_o__00Ooo = New O_o__00Ooo()
			o_o__00Ooo.Name = Name
			o_o__00Ooo.Text = Text
			Me.oO_0o_.0__O..Insert(Index, o_o__00Ooo)
			Return New TreeNode(o_o__00Ooo)
		End Function

		' Token: 0x060056E7 RID: 22247 RVA: 0x00223604 File Offset: 0x00221804
		Public Function Insert(Name As String, Text As String, ImageFile As String, Index As Integer) As TreeNode
			Dim o_o__00Ooo As O_o__00Ooo = New O_o__00Ooo()
			Me.oO_0o_.0__O..Insert(Index, o_o__00Ooo)
			o_o__00Ooo.Name = Name
			o_o__00Ooo.Text = Text
			o_o__00Ooo.ImageFile = ImageFile
			Return New TreeNode(o_o__00Ooo)
		End Function

		' Token: 0x060056E8 RID: 22248 RVA: 0x00223640 File Offset: 0x00221840
		Public Function Contains(Name As String) As Boolean
			Return Me.oO_0o_.0__O..ContainsKey(Name)
		End Function

		' Token: 0x060056E9 RID: 22249 RVA: 0x0022364E File Offset: 0x0022184E
		Public Sub Remove(Node As TreeNode)
			Me.oO_0o_.0__O..Remove(Node.BaseNode)
		End Sub

		' Token: 0x060056EA RID: 22250 RVA: 0x00223661 File Offset: 0x00221861
		Public Sub RemoveAt(Index As Integer)
			Me.oO_0o_.0__O..RemoveAt(Index)
		End Sub

		' Token: 0x060056EB RID: 22251 RVA: 0x0022366F File Offset: 0x0022186F
		Public Function GetEnumerator() As IEnumerator(Of TreeNode) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.TreeNode).GetEnumerator
			Return New O_oO__o0(Me.oO_0o_.0__O.)
		End Function

		' Token: 0x060056EC RID: 22252 RVA: 0x0022367C File Offset: 0x0022187C
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O_oO__o0(Me.oO_0o_.0__O.)
		End Function

		' Token: 0x04002232 RID: 8754
		Private <<EMPTY_NAME>> As TreeNodeCollection
	End Class
End Namespace
