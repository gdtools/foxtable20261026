Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003F2 RID: 1010
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3000
		Inherits Form

		' Token: 0x0600408A RID: 16522 RVA: 0x001BE348 File Offset: 0x001BC548
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0Oo.____oOo. IsNot Nothing Then
					Me.o0Oo.____oOo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600408B RID: 16523 RVA: 0x001BE388 File Offset: 0x001BC588
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0.0oO_0__OO.(New C1Button())
			Me.OoO_0_0._00_0.(New C1Button())
			Me.OO.o_O00.(New C1Button())
			Me.oO0O.Ooo.(New C1Button())
			Me.O_ooo0.o.(New C1Button())
			Me.OoO_0_0._00_0.(New TreeView())
			Me.OoO_0_0._00_0.(New PropertyGrid())
			Me.ooOo0o0O.oo__0.(New C1Button())
			Me.O0_oo_o._0.(New C1Button())
			MyBase.SuspendLayout()
			Me.O00.oo.().Location = New Point(163, 12)
			Me.O00.oo.().Name = "btnAddGroup"
			Me.O00.oo.().Size = New Size(75, 23)
			Me.O00.oo.().TabIndex = 1
			Me.O00.oo.().Text = "增加页面"
			Me.O00.oo.().UseVisualStyleBackColor = True
			Me.O_._oo.().Location = New Point(163, 41)
			Me.O_._oo.().Name = "btnAddTask"
			Me.O_._oo.().Size = New Size(75, 23)
			Me.O_._oo.().TabIndex = 3
			Me.O_._oo.().Text = "增加任务"
			Me.O_._oo.().UseVisualStyleBackColor = True
			Me.OO0_o.o00.().Location = New Point(163, 128)
			Me.OO0_o.o00.().Name = "btnDelete"
			Me.OO0_o.o00.().Size = New Size(75, 23)
			Me.OO0_o.o00.().TabIndex = 4
			Me.OO0_o.o00.().Text = "删除"
			Me.OO0_o.o00.().UseVisualStyleBackColor = True
			Me.o0.0oO_0__OO.().Location = New Point(163, 70)
			Me.o0.0oO_0__OO.().Name = "BtnMoveUp"
			Me.o0.0oO_0__OO.().Size = New Size(75, 23)
			Me.o0.0oO_0__OO.().TabIndex = 5
			Me.o0.0oO_0__OO.().Text = "上移"
			Me.o0.0oO_0__OO.().UseVisualStyleBackColor = True
			Me.o_._00oO0.().Location = New Point(163, 99)
			Me.o_._00oO0.().Name = "btnNoveDown"
			Me.o_._00oO0.().Size = New Size(75, 23)
			Me.o_._00oO0.().TabIndex = 6
			Me.o_._00oO0.().Text = "下移"
			Me.o_._00oO0.().UseVisualStyleBackColor = True
			Me.OO_o.O_0.().HideSelection = False
			Me.OO_o.O_0.().Location = New Point(12, 12)
			Me.OO_o.O_0.().Name = "TreeView1"
			Me.OO_o.O_0.().Size = New Size(145, 275)
			Me.OO_o.O_0.().TabIndex = 7
			Me.OO_o.O_0.().Location = New Point(244, 12)
			Me.OO_o.O_0.().Name = "PropertyGrid1"
			Me.OO_o.O_0.().Size = New Size(275, 275)
			Me.OO_o.O_0.().TabIndex = 8
			Me.OO_o.O_0.().ToolbarVisible = False
			Me.o0O__.Oo_O__.().Location = New Point(364, 302)
			Me.o0O__.Oo_O__.().Name = "btnOk"
			Me.o0O__.Oo_O__.().Size = New Size(75, 23)
			Me.o0O__.Oo_O__.().TabIndex = 9
			Me.o0O__.Oo_O__.().Text = "确定"
			Me.o0O__.Oo_O__.().UseVisualStyleBackColor = True
			Me.o0o.o__OOOo_.().Location = New Point(445, 302)
			Me.o0o.o__OOOo_.().Name = "btnCancel"
			Me.o0o.o__OOOo_.().Size = New Size(75, 23)
			Me.o0o.o__OOOo_.().TabIndex = 10
			Me.o0o.o__OOOo_.().Text = "取消"
			Me.o0o.o__OOOo_.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(531, 336)
			MyBase.Controls.Add(Me.o0o.o__OOOo_.())
			MyBase.Controls.Add(Me.o0O__.Oo_O__.())
			MyBase.Controls.Add(Me.OO_o.O_0.())
			MyBase.Controls.Add(Me.OO_o.O_0.())
			MyBase.Controls.Add(Me.o_._00oO0.())
			MyBase.Controls.Add(Me.o0.0oO_0__OO.())
			MyBase.Controls.Add(Me.OO0_o.o00.())
			MyBase.Controls.Add(Me.O_._oo.())
			MyBase.Controls.Add(Me.O00.oo.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.00.O0o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "任务栏编辑器"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600408C RID: 16524 RVA: 0x001BE877 File Offset: 0x001BCA77
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0Oo.____oOo.
		End Function

		' Token: 0x0600408D RID: 16525 RVA: 0x001BE880 File Offset: 0x001BCA80
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00o.o.
			Dim c1Button As C1Button = Me.o0Oo.____oOo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0Oo.____oOo. = A_0
			c1Button = Me.o0Oo.____oOo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600408E RID: 16526 RVA: 0x001BE8C3 File Offset: 0x001BCAC3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_ooO_0O_O.o_.
		End Function

		' Token: 0x0600408F RID: 16527 RVA: 0x001BE8CC File Offset: 0x001BCACC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__._00o_O0.
			Dim o_ooO_0O_O.o_. As C1Button = Me.O_ooO_0O_O.o_.
			If o_ooO_0O_O.o_. IsNot Nothing Then
				RemoveHandler o_ooO_0O_O.o_..Click, value
			End If
			Me.O_ooO_0O_O.o_. = A_0
			o_ooO_0O_O.o_. = Me.O_ooO_0O_O.o_.
			If o_ooO_0O_O.o_. IsNot Nothing Then
				AddHandler o_ooO_0O_O.o_..Click, value
			End If
		End Sub

		' Token: 0x06004090 RID: 16528 RVA: 0x001BE90F File Offset: 0x001BCB0F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_._oOoO.
		End Function

		' Token: 0x06004091 RID: 16529 RVA: 0x001BE918 File Offset: 0x001BCB18
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_._oo.
			Dim c1Button As C1Button = Me.o_._oOoO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_._oOoO. = A_0
			c1Button = Me.o_._oOoO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004092 RID: 16530 RVA: 0x001BE95B File Offset: 0x001BCB5B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo.0Oo0oO000o.
		End Function

		' Token: 0x06004093 RID: 16531 RVA: 0x001BE964 File Offset: 0x001BCB64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O00.oo.
			Dim c1Button As C1Button = Me.oo.0Oo0oO000o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo.0Oo0oO000o. = A_0
			c1Button = Me.oo.0Oo0oO000o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004094 RID: 16532 RVA: 0x001BE9A7 File Offset: 0x001BCBA7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOoOo0oO__.0O.
		End Function

		' Token: 0x06004095 RID: 16533 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_OoO._0o_OOo0.
			Dim c1Button As C1Button = Me.oOoOo0oO__.0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOoOo0oO__.0O. = A_0
			c1Button = Me.oOoOo0oO__.0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004096 RID: 16534 RVA: 0x001BE9F3 File Offset: 0x001BCBF3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.o0Oo.____oOo.
		End Function

		' Token: 0x06004097 RID: 16535 RVA: 0x001BE9FC File Offset: 0x001BCBFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.OoO_0_0._00_0.
			Dim treeView As TreeView = Me.o0Oo.____oOo.
			If treeView IsNot Nothing Then
				RemoveHandler treeView.AfterSelect, value
			End If
			Me.o0Oo.____oOo. = A_0
			treeView = Me.o0Oo.____oOo.
			If treeView IsNot Nothing Then
				AddHandler treeView.AfterSelect, value
			End If
		End Sub

		' Token: 0x06004098 RID: 16536 RVA: 0x001BEA3F File Offset: 0x001BCC3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.o0Oo.____oOo.
		End Function

		' Token: 0x06004099 RID: 16537 RVA: 0x001BEA48 File Offset: 0x001BCC48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Dim value As PropertyTabChangedEventHandler = AddressOf Me.OO_o.O_0.
			Dim value2 As PropertyValueChangedEventHandler = AddressOf Me.OO_o.O_0.
			Dim propertyGrid As PropertyGrid = Me.o0Oo.____oOo.
			If propertyGrid IsNot Nothing Then
				RemoveHandler propertyGrid.PropertyTabChanged, value
				RemoveHandler propertyGrid.PropertyValueChanged, value2
			End If
			Me.o0Oo.____oOo. = A_0
			propertyGrid = Me.o0Oo.____oOo.
			If propertyGrid IsNot Nothing Then
				AddHandler propertyGrid.PropertyTabChanged, value
				AddHandler propertyGrid.PropertyValueChanged, value2
			End If
		End Sub

		' Token: 0x0600409A RID: 16538 RVA: 0x001BEAA6 File Offset: 0x001BCCA6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo.OO0o_0ooo.
		End Function

		' Token: 0x0600409B RID: 16539 RVA: 0x001BEAB0 File Offset: 0x001BCCB0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0_o.o00.
			Dim c1Button As C1Button = Me.oo.OO0o_0ooo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo.OO0o_0ooo. = A_0
			c1Button = Me.oo.OO0o_0ooo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600409C RID: 16540 RVA: 0x001BEAF3 File Offset: 0x001BCCF3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOO_oo.O_0o.
		End Function

		' Token: 0x0600409D RID: 16541 RVA: 0x001BEAFC File Offset: 0x001BCCFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0_O0o.o_.
			Dim c1Button As C1Button = Me.oOO_oo.O_0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOO_oo.O_0o. = A_0
			c1Button = Me.oOO_oo.O_0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600409E RID: 16542 RVA: 0x001BEB3F File Offset: 0x001BCD3F
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OO0_o.o00.
			Me.OO_o.O_0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600409F RID: 16543 RVA: 0x001BEB74 File Offset: 0x001BCD74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.OO_o.O_0.()
			Dim treeNode As TreeNode = New TreeNode()
			treeView.Nodes.Add(treeNode)
			treeNode.Text = "页面" + Conversions.ToString(treeView.Nodes.Count)
			treeNode.Name = treeNode.Text
			treeNode.EnsureVisible()
			treeNode.Tag = New TopicPageProperty() With { .Name = treeNode.Name, .Text = treeNode.Text }
			treeView.SelectedNode = treeNode
		End Sub

		' Token: 0x060040A0 RID: 16544 RVA: 0x001BEBFC File Offset: 0x001BCDFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.OO_o.O_0.()
			If treeView.SelectedNode IsNot Nothing Then
				Dim treeNode As TreeNode = New TreeNode()
				If treeView.SelectedNode.Level = 0 Then
					treeView.SelectedNode.Nodes.Add(treeNode)
					treeNode.Text = "任务" + Conversions.ToString(treeView.SelectedNode.GetNodeCount(False))
				Else
					treeView.SelectedNode.Parent.Nodes.Add(treeNode)
					treeNode.Text = "任务" + Conversions.ToString(treeView.SelectedNode.Parent.GetNodeCount(False))
				End If
				treeNode.Name = treeNode.Text
				treeNode.EnsureVisible()
				treeNode.Tag = New TopicLinkProperty() With { .Name = treeNode.Name, .Text = treeNode.Text }
				treeView.SelectedNode = treeNode
			End If
		End Sub

		' Token: 0x060040A1 RID: 16545 RVA: 0x001BECE0 File Offset: 0x001BCEE0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.OO_o.O_0.()
			If treeView.SelectedNode IsNot Nothing Then
				Dim selectedNode As TreeNode = treeView.SelectedNode
				Dim index As Integer = selectedNode.Index
				If index <> 0 Then
					Dim nodes As TreeNodeCollection
					If selectedNode.Parent Is Nothing Then
						nodes = treeView.Nodes
					Else
						nodes = selectedNode.Parent.Nodes
					End If
					nodes.Remove(selectedNode)
					nodes.Insert(index - 1, selectedNode)
					treeView.SelectedNode = selectedNode
					selectedNode.EnsureVisible()
				End If
			End If
		End Sub

		' Token: 0x060040A2 RID: 16546 RVA: 0x001BED4C File Offset: 0x001BCF4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.OO_o.O_0.()
			If treeView.SelectedNode IsNot Nothing Then
				Dim selectedNode As TreeNode = treeView.SelectedNode
				Dim index As Integer = selectedNode.Index
				Dim nodes As TreeNodeCollection
				If selectedNode.Parent Is Nothing Then
					nodes = treeView.Nodes
				Else
					nodes = selectedNode.Parent.Nodes
				End If
				If index <> nodes.Count - 1 Then
					nodes.Remove(selectedNode)
					nodes.Insert(index + 1, selectedNode)
					treeView.SelectedNode = selectedNode
					selectedNode.EnsureVisible()
				End If
			End If
		End Sub

		' Token: 0x060040A3 RID: 16547 RVA: 0x001BEDC0 File Offset: 0x001BCFC0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.OO_o.O_0.()
			If treeView.SelectedNode IsNot Nothing Then
				If treeView.SelectedNode.Parent Is Nothing Then
					treeView.Nodes.Remove(treeView.SelectedNode)
				Else
					treeView.SelectedNode.Parent.Nodes.Remove(treeView.SelectedNode)
				End If
			End If
		End Sub

		' Token: 0x060040A4 RID: 16548 RVA: 0x001BEE19 File Offset: 0x001BD019
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060040A5 RID: 16549 RVA: 0x001BEE22 File Offset: 0x001BD022
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060040A6 RID: 16550 RVA: 0x001BEE2C File Offset: 0x001BD02C
		Friend Function <<EMPTY_NAME>>() As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Try
				For Each obj As Object In Me.OO_o.O_0.().Nodes
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					If stringBuilder.Length > 0 Then
						stringBuilder.Append(vbFormFeed)
					End If
					stringBuilder.Append("Page")
					stringBuilder.Append(vbFormFeed)
					stringBuilder.Append(o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(treeNode.Tag), False, vbTab, False).Replace(vbFormFeed, ""))
					If treeNode.Nodes.Count > 0 Then
						Try
							For Each obj2 As Object In treeNode.Nodes
								Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
								stringBuilder.Append(vbFormFeed)
								stringBuilder.Append(o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(treeNode2.Tag), False, vbTab, False).Replace(vbFormFeed, ""))
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060040A7 RID: 16551 RVA: 0x001BEF70 File Offset: 0x001BD170
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO_o.O_0.().Nodes.Clear()
			If Operators.CompareString(A_0, "", True) <> 0 Then
				For Each text As String In A_0.Split(New Char() { vbFormFeed })
					If Operators.CompareString(text, "Page", True) = 0 Then
						Dim flag As Boolean = True
					Else
						Dim treeNode As TreeNode = New TreeNode()
						Dim flag As Boolean
						Dim obj As Object
						If flag Then
							obj = New TopicPageProperty()
						Else
							obj = New TopicLinkProperty()
						End If
						o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(obj), text, vbTab)
						treeNode.Tag = RuntimeHelpers.GetObjectValue(obj)
						If flag Then
							Me.OO_o.O_0.().Nodes.Add(treeNode)
							treeNode.Text = CType(obj, TopicPageProperty).Text
						Else
							Me.OO_o.O_0.().Nodes(Me.OO_o.O_0.().Nodes.Count - 1).Nodes.Add(treeNode)
							treeNode.Text = CType(obj, TopicLinkProperty).Text
						End If
						flag = False
					End If
				Next
			End If
		End Sub

		' Token: 0x060040A8 RID: 16552 RVA: 0x001BF083 File Offset: 0x001BD283
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If Me.OO_o.O_0.().SelectedNode Is Nothing Then
				Me.OO_o.O_0.().SelectedObject = Nothing
				Return
			End If
			Me.OO_o.O_0.().SelectedObject = RuntimeHelpers.GetObjectValue(Me.OO_o.O_0.().SelectedNode.Tag)
		End Sub

		' Token: 0x060040A9 RID: 16553 RVA: 0x001BF0BF File Offset: 0x001BD2BF
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PropertyTabChangedEventArgs)
		End Sub

		' Token: 0x060040AA RID: 16554 RVA: 0x001BF0C1 File Offset: 0x001BD2C1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PropertyValueChangedEventArgs)
			If Operators.CompareString(A_1.ChangedItem.Label, "标题", True) = 0 Then
				Me.OO_o.O_0.().SelectedNode.Text = A_1.ChangedItem.Value.ToString()
			End If
		End Sub

		' Token: 0x060040AB RID: 16555 RVA: 0x001BF0FB File Offset: 0x001BD2FB
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001ACF RID: 6863
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001AD0 RID: 6864
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD1 RID: 6865
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD2 RID: 6866
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD3 RID: 6867
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD4 RID: 6868
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD5 RID: 6869
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04001AD6 RID: 6870
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x04001AD7 RID: 6871
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001AD8 RID: 6872
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
