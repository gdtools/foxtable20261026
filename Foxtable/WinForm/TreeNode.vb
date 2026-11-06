Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020003C1 RID: 961
	<ComVisible(True)>
	Public Class TreeNode
		Inherits CustomTreeNodeProperty

		' Token: 0x06003D68 RID: 15720 RVA: 0x001AB98C File Offset: 0x001A9B8C
		Friend Sub New(A_0 As O_o__00Ooo)
			MyBase.New(A_0)
			Me.oO_0o_.0__O. = A_0
		End Sub

		' Token: 0x17000D73 RID: 3443
		' (get) Token: 0x06003D69 RID: 15721 RVA: 0x001AB99C File Offset: 0x001A9B9C
		Public ReadOnly Property Nodes As TreeNodes
			Get
				If Me.a Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.a, New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(Me.a, flag)
					If Me.a.State = 0S Then
						Me.a.State = 2S
						Me.a = Nothing
					ElseIf Me.a.State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.a.State = 1S
					If flag Then
						Monitor.[Exit](Me.a)
					End If
				End Try
				If Me.a Is Nothing Then
					Me.a = New TreeNodes(Me.o0Ooo_O0oo.O__..Nodes)
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17000D74 RID: 3444
		' (get) Token: 0x06003D6A RID: 15722 RVA: 0x001ABA5C File Offset: 0x001A9C5C
		Public ReadOnly Property ParentNode As TreeNode
			Get
				Dim result As TreeNode
				If Me.oO_0o_.0__O..Parent IsNot Nothing Then
					result = New TreeNode(CType(Me.oO_0o_.0__O..Parent, O_o__00Ooo))
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000D75 RID: 3445
		' (get) Token: 0x06003D6B RID: 15723 RVA: 0x001ABA91 File Offset: 0x001A9C91
		Public ReadOnly Property HasChdren As Boolean
			Get
				Return Me.o0Ooo_O0oo.O__..GetNodeCount(False) > 0
			End Get
		End Property

		' Token: 0x17000D76 RID: 3446
		' (get) Token: 0x06003D6C RID: 15724 RVA: 0x001ABAA2 File Offset: 0x001A9CA2
		Public ReadOnly Property FullPath As String
			Get
				Return Me.o0Ooo_O0oo.O__..FullPath
			End Get
		End Property

		' Token: 0x17000D77 RID: 3447
		' (get) Token: 0x06003D6D RID: 15725 RVA: 0x001ABAB0 File Offset: 0x001A9CB0
		Public ReadOnly Property FullName As String
			Get
				Dim text As String = Me.oO_0o_.0__O..Name
				Dim parent As TreeNode = Me.oO_0o_.0__O..Parent
				While parent IsNot Nothing
					text = parent.Name + Me.o0Ooo_O0oo.O__..TreeView.PathSeparator + text
					parent = parent.Parent
				End While
				Return text
			End Get
		End Property

		' Token: 0x17000D78 RID: 3448
		' (get) Token: 0x06003D6E RID: 15726 RVA: 0x001ABAFF File Offset: 0x001A9CFF
		Public ReadOnly Property IsExpanded As Boolean
			Get
				Return Me.o0Ooo_O0oo.O__..IsExpanded
			End Get
		End Property

		' Token: 0x17000D79 RID: 3449
		' (get) Token: 0x06003D6F RID: 15727 RVA: 0x001ABB0C File Offset: 0x001A9D0C
		Public ReadOnly Property IsSelected As Boolean
			Get
				Return Me.o0Ooo_O0oo.O__..IsSelected
			End Get
		End Property

		' Token: 0x17000D7A RID: 3450
		' (get) Token: 0x06003D70 RID: 15728 RVA: 0x001ABB19 File Offset: 0x001A9D19
		' (set) Token: 0x06003D71 RID: 15729 RVA: 0x001ABB26 File Offset: 0x001A9D26
		Public Property IconFile As String
			Get
				Return Me.o0Ooo_O0oo.O__..ImageFile
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..ImageFile = value
			End Set
		End Property

		' Token: 0x17000D7B RID: 3451
		' (get) Token: 0x06003D72 RID: 15730 RVA: 0x001ABB34 File Offset: 0x001A9D34
		' (set) Token: 0x06003D73 RID: 15731 RVA: 0x001ABB41 File Offset: 0x001A9D41
		Public Property SelectedIconFile As String
			Get
				Return Me.o0Ooo_O0oo.O__..o0Ooo_O0oo.O__.()
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..O.OOO_.(value)
			End Set
		End Property

		' Token: 0x17000D7C RID: 3452
		' (get) Token: 0x06003D74 RID: 15732 RVA: 0x001ABB4F File Offset: 0x001A9D4F
		Public ReadOnly Property Level As Integer
			Get
				Return Me.o0Ooo_O0oo.O__..Level
			End Get
		End Property

		' Token: 0x17000D7D RID: 3453
		' (get) Token: 0x06003D75 RID: 15733 RVA: 0x001ABB5C File Offset: 0x001A9D5C
		Public ReadOnly Property BaseNode As TreeNode
			Get
				Return Me.oO_0o_.0__O.
			End Get
		End Property

		' Token: 0x06003D76 RID: 15734 RVA: 0x001ABB64 File Offset: 0x001A9D64
		Public Sub Expand()
			Me.o0Ooo_O0oo.O__..Expand()
		End Sub

		' Token: 0x06003D77 RID: 15735 RVA: 0x001ABB71 File Offset: 0x001A9D71
		Public Sub ExpandAll()
			Me.o0Ooo_O0oo.O__..ExpandAll()
		End Sub

		' Token: 0x06003D78 RID: 15736 RVA: 0x001ABB7E File Offset: 0x001A9D7E
		Public Sub Collapse()
			Me.o0Ooo_O0oo.O__..Collapse(True)
		End Sub

		' Token: 0x06003D79 RID: 15737 RVA: 0x001ABB8C File Offset: 0x001A9D8C
		Public Sub CollapseAll()
			Me.o0Ooo_O0oo.O__..Collapse(False)
		End Sub

		' Token: 0x06003D7A RID: 15738 RVA: 0x001ABB9A File Offset: 0x001A9D9A
		Public Sub Toggle()
			Me.o0Ooo_O0oo.O__..Toggle()
		End Sub

		' Token: 0x06003D7B RID: 15739 RVA: 0x001ABBA7 File Offset: 0x001A9DA7
		Public Sub Remove()
			Me.o0Ooo_O0oo.O__..Remove()
		End Sub

		' Token: 0x06003D7C RID: 15740 RVA: 0x001ABBB4 File Offset: 0x001A9DB4
		Public Sub EnsureVisible()
			Me.o0Ooo_O0oo.O__..EnsureVisible()
		End Sub

		' Token: 0x17000D7E RID: 3454
		' (get) Token: 0x06003D7D RID: 15741 RVA: 0x001ABBC1 File Offset: 0x001A9DC1
		Public ReadOnly Property Index As Integer
			Get
				Return Me.oO_0o_.0__O..Index
			End Get
		End Property

		' Token: 0x06003D7E RID: 15742 RVA: 0x001ABBD0 File Offset: 0x001A9DD0
		Public Sub MoveUp()
			If Me.o0Ooo_O0oo.O__..Index <> 0 Then
				Dim index As Integer = Me.o0Ooo_O0oo.O__..Index
				Dim nodes As TreeNodeCollection
				If Me.o0Ooo_O0oo.O__..Parent Is Nothing Then
					nodes = Me.o0Ooo_O0oo.O__..TreeView.Nodes
				Else
					nodes = Me.o0Ooo_O0oo.O__..Parent.Nodes
				End If
				nodes.Remove(Me.o0Ooo_O0oo.O__.)
				nodes.Insert(index - 1, Me.o0Ooo_O0oo.O__.)
				Me.o0Ooo_O0oo.O__..TreeView.SelectedNode = Me.o0Ooo_O0oo.O__.
			End If
		End Sub

		' Token: 0x06003D7F RID: 15743 RVA: 0x001ABC58 File Offset: 0x001A9E58
		Public Sub MoveDown()
			Dim index As Integer = Me.o0Ooo_O0oo.O__..Index
			Dim nodes As TreeNodeCollection
			If Me.o0Ooo_O0oo.O__..Parent Is Nothing Then
				nodes = Me.o0Ooo_O0oo.O__..TreeView.Nodes
			Else
				nodes = Me.o0Ooo_O0oo.O__..Parent.Nodes
			End If
			If index <> nodes.Count - 1 Then
				nodes.Remove(Me.o0Ooo_O0oo.O__.)
				nodes.Insert(index + 1, Me.o0Ooo_O0oo.O__.)
				Me.o0Ooo_O0oo.O__..TreeView.SelectedNode = Me.o0Ooo_O0oo.O__.
			End If
		End Sub

		' Token: 0x06003D80 RID: 15744 RVA: 0x001ABCE0 File Offset: 0x001A9EE0
		Public Sub MoveLeft()
			Dim o0Ooo_O0oo.O__. As TreeNode = Me.o0Ooo_O0oo.O__.
			If o0Ooo_O0oo.O__..Level <> 0 Then
				Dim index As Integer = o0Ooo_O0oo.O__..Parent.Index + 1
				Dim nodes As TreeNodeCollection
				If o0Ooo_O0oo.O__..Parent.Level = 0 Then
					nodes = o0Ooo_O0oo.O__..TreeView.Nodes
				Else
					nodes = o0Ooo_O0oo.O__..Parent.Parent.Nodes
				End If
				o0Ooo_O0oo.O__..Parent.Nodes.Remove(o0Ooo_O0oo.O__.)
				nodes.Insert(index, o0Ooo_O0oo.O__.)
				o0Ooo_O0oo.O__..TreeView.SelectedNode = o0Ooo_O0oo.O__.
			End If
		End Sub

		' Token: 0x06003D81 RID: 15745 RVA: 0x001ABD5C File Offset: 0x001A9F5C
		Public Sub MoveRight()
			Dim o0Ooo_O0oo.O__. As TreeNode = Me.o0Ooo_O0oo.O__.
			If o0Ooo_O0oo.O__..Index <> 0 Then
				Dim nodes As TreeNodeCollection = o0Ooo_O0oo.O__..PrevNode.Nodes
				If o0Ooo_O0oo.O__..Parent IsNot Nothing Then
					o0Ooo_O0oo.O__..Parent.Nodes.Remove(o0Ooo_O0oo.O__.)
				Else
					o0Ooo_O0oo.O__..TreeView.Nodes.Remove(o0Ooo_O0oo.O__.)
				End If
				nodes.Add(o0Ooo_O0oo.O__.)
				o0Ooo_O0oo.O__..TreeView.SelectedNode = o0Ooo_O0oo.O__.
			End If
		End Sub

		' Token: 0x06003D82 RID: 15746 RVA: 0x001ABDC4 File Offset: 0x001A9FC4
		Public Sub Delete()
			Dim nodes As TreeNodeCollection
			If Me.o0Ooo_O0oo.O__..Parent Is Nothing Then
				nodes = Me.o0Ooo_O0oo.O__..TreeView.Nodes
			Else
				nodes = Me.o0Ooo_O0oo.O__..Parent.Nodes
			End If
			nodes.Remove(Me.o0Ooo_O0oo.O__.)
		End Sub

		' Token: 0x06003D83 RID: 15747 RVA: 0x001ABE10 File Offset: 0x001AA010
		Public Sub SetChildrenChecked(Checked As Boolean, Optional TopLevel As Boolean = False)
			Try
				For Each treeNode As TreeNode In Me.Nodes
					If treeNode.Checked <> Checked Then
						treeNode.Checked = Checked
					End If
					If Not TopLevel Then
						treeNode.SetChildrenChecked(Checked, TopLevel)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of TreeNode)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x17000D7F RID: 3455
		' (get) Token: 0x06003D84 RID: 15748 RVA: 0x001ABE74 File Offset: 0x001AA074
		Public ReadOnly Property AllNodes As List(Of TreeNode)
			Get
				Dim list As List(Of TreeNode) = New List(Of TreeNode)()
				ooO_0O.o_O0.O_.(Me.oO_0o_.0__O..Nodes, list)
				Return list
			End Get
		End Property

		' Token: 0x17000D80 RID: 3456
		' (get) Token: 0x06003D85 RID: 15749 RVA: 0x001ABE9C File Offset: 0x001AA09C
		Public ReadOnly Property DataRow As DataRow
			Get
				Dim result As DataRow
				If Me.o0Ooo_O0oo.O__..Tag IsNot Nothing AndAlso TypeOf Me.o0Ooo_O0oo.O__..Tag Is DataRow Then
					result = New DataRow(CType(Me.o0Ooo_O0oo.O__..Tag, DataRow))
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x04001916 RID: 6422
		Private <<EMPTY_NAME>> As TreeNode

		' Token: 0x04001917 RID: 6423
		Private a As TreeNodes

		' Token: 0x04001918 RID: 6424
		Private a As StaticLocalInitFlag
	End Class
End Namespace
