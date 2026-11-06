Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000190 RID: 400
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000
		Inherits Form

		' Token: 0x06001264 RID: 4708 RVA: 0x00070160 File Offset: 0x0006E360
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0o.o0oO_. IsNot Nothing Then
					Me.o0o.o0oO_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001265 RID: 4709 RVA: 0x000701A0 File Offset: 0x0006E3A0
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.OO_0.(New TreeView())
			Me.O__.oO_0.(New Label())
			Me.ooO0o0O.0.(New C1TextBox())
			Me.o.OO_0.(New Label())
			Me.o.00oOo_.(New C1Button())
			Me.oo00O._.(New C1Button())
			Me.o.OO_0.(New C1TextBox())
			Me.ooO0o0O.0.(New Label())
			MyBase.SuspendLayout()
			Me.o.00oOo_.().CheckBoxes = True
			Me.o.00oOo_.().Location = New Point(14, 138)
			Me.o.00oOo_.().Name = "trvUsers"
			Me.o.00oOo_.().Size = New Size(449, 388)
			Me.o.00oOo_.().TabIndex = 2
			Me.o.00oOo_.().AutoSize = True
			Me.o.00oOo_.().Location = New Point(14, 15)
			Me.o.00oOo_.().Name = "Label1"
			Me.o.00oOo_.().Size = New Size(59, 12)
			Me.o.00oOo_.().TabIndex = 1
			Me.o.00oOo_.().Text = "会议名称:"
			Me.o.00oOo_.().Location = New Point(14, 36)
			Me.o.00oOo_.().Name = "txtMeetingName"
			Me.o.00oOo_.().Size = New Size(449, 21)
			Me.o.00oOo_.().TabIndex = 0
			Me.oo00O._.().AutoSize = True
			Me.oo00O._.().Location = New Point(14, 117)
			Me.oo00O._.().Name = "Label2"
			Me.oo00O._.().Size = New Size(95, 12)
			Me.oo00O._.().TabIndex = 3
			Me.oo00O._.().Text = "选择会议参与者:"
			Me.o.00oOo_.().Location = New Point(159, 540)
			Me.o.00oOo_.().Name = "btnOK"
			Me.o.00oOo_.().Size = New Size(75, 23)
			Me.o.00oOo_.().TabIndex = 3
			Me.o.00oOo_.().Text = "确定"
			Me.o.00oOo_.().UseVisualStyleBackColor = True
			Me.o__00oOo.OOo__.().Location = New Point(240, 540)
			Me.o__00oOo.OOo__.().Name = "btnCancel"
			Me.o__00oOo.OOo__.().Size = New Size(75, 23)
			Me.o__00oOo.OOo__.().TabIndex = 4
			Me.o__00oOo.OOo__.().Text = "取消"
			Me.o__00oOo.OOo__.().UseVisualStyleBackColor = True
			Me.oo00O._.().Location = New Point(14, 87)
			Me.oo00O._.().Name = "txtDescription"
			Me.oo00O._.().Size = New Size(449, 21)
			Me.oo00O._.().TabIndex = 1
			Me.o0.0O0o.().AutoSize = True
			Me.o0.0O0o.().Location = New Point(14, 66)
			Me.o0.0O0o.().Name = "Label3"
			Me.o0.0O0o.().Size = New Size(59, 12)
			Me.o0.0O0o.().TabIndex = 5
			Me.o0.0O0o.().Text = "会议主题:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(475, 575)
			MyBase.Controls.Add(Me.oo00O._.())
			MyBase.Controls.Add(Me.o0.0O0o.())
			MyBase.Controls.Add(Me.o__00oOo.OOo__.())
			MyBase.Controls.Add(Me.o.00oOo_.())
			MyBase.Controls.Add(Me.oo00O._.())
			MyBase.Controls.Add(Me.o.00oOo_.())
			MyBase.Controls.Add(Me.o.00oOo_.())
			MyBase.Controls.Add(Me.o.00oOo_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Oo00..o."
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "新建会议"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06001266 RID: 4710 RVA: 0x000705DD File Offset: 0x0006E7DD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.o0o.o0oO_.
		End Function

		' Token: 0x06001267 RID: 4711 RVA: 0x000705E8 File Offset: 0x0006E7E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.o.OO_0.
			Dim treeView As TreeView = Me.o0o.o0oO_.
			If treeView IsNot Nothing Then
				RemoveHandler treeView.AfterCheck, value
			End If
			Me.o0o.o0oO_. = A_0
			treeView = Me.o0o.o0oO_.
			If treeView IsNot Nothing Then
				AddHandler treeView.AfterCheck, value
			End If
		End Sub

		' Token: 0x06001268 RID: 4712 RVA: 0x0007062B File Offset: 0x0006E82B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.OO_0.
		End Function

		' Token: 0x06001269 RID: 4713 RVA: 0x00070633 File Offset: 0x0006E833
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.OO_0. = A_0
		End Sub

		' Token: 0x0600126A RID: 4714 RVA: 0x0007063C File Offset: 0x0006E83C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0o.o0oO_.
		End Function

		' Token: 0x0600126B RID: 4715 RVA: 0x00070644 File Offset: 0x0006E844
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o0o.o0oO_. = A_0
		End Sub

		' Token: 0x0600126C RID: 4716 RVA: 0x0007064D File Offset: 0x0006E84D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooOo_O0O._o.
		End Function

		' Token: 0x0600126D RID: 4717 RVA: 0x00070655 File Offset: 0x0006E855
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooOo_O0O._o. = A_0
		End Sub

		' Token: 0x0600126E RID: 4718 RVA: 0x0007065E File Offset: 0x0006E85E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.OO_0.
		End Function

		' Token: 0x0600126F RID: 4719 RVA: 0x00070668 File Offset: 0x0006E868
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__00oOo.OOo__.
			Dim c1Button As C1Button = Me.o.OO_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.OO_0. = A_0
			c1Button = Me.o.OO_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001270 RID: 4720 RVA: 0x000706AB File Offset: 0x0006E8AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO0o0O.0.
		End Function

		' Token: 0x06001271 RID: 4721 RVA: 0x000706B4 File Offset: 0x0006E8B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o._0ooO.
			Dim c1Button As C1Button = Me.ooO0o0O.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO0o0O.0. = A_0
			c1Button = Me.ooO0o0O.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001272 RID: 4722 RVA: 0x000706F7 File Offset: 0x0006E8F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.ooOo_O0O._o.
		End Function

		' Token: 0x06001273 RID: 4723 RVA: 0x000706FF File Offset: 0x0006E8FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.ooOo_O0O._o. = A_0
		End Sub

		' Token: 0x06001274 RID: 4724 RVA: 0x00070708 File Offset: 0x0006E908
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOoo__O0_.oO_.
		End Function

		' Token: 0x06001275 RID: 4725 RVA: 0x00070710 File Offset: 0x0006E910
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOoo__O0_.oO_. = A_0
		End Sub

		' Token: 0x06001276 RID: 4726 RVA: 0x0007071C File Offset: 0x0006E91C
		Friend Sub New(A_0 As IMClient, A_1 As ImageList)
			AddHandler MyBase.Closed, AddressOf Me.Oo00oO0_O0.O0.
			Me.o.00oOo_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o0o.o0oO_. = A_0
			Dim treeView As TreeView = Me.o.00oOo_.()
			treeView.ImageList = A_1
			Try
				For Each imbuddy As IMBuddy In Me.o0o.o0oO_..Buddies
					If Not imbuddy.FromWeChat Then
						Dim text As String = imbuddy.UserGroup
						Dim text2 As String = imbuddy.SimpleName
						If Not treeView.Nodes.ContainsKey(text) Then
							Dim treeNode As TreeNode = treeView.Nodes.Add(text, text)
							treeNode.ImageKey = "group"
							treeNode.SelectedImageKey = "group"
						End If
						Dim treeNode2 As TreeNode = treeView.Nodes(text).Nodes.Add(text2, text2)
						treeNode2.Tag = imbuddy
						If imbuddy.OnLine Then
							treeNode2.ImageKey = "online2"
							treeNode2.SelectedImageKey = "online2"
						Else
							treeNode2.ImageKey = "offline2"
							treeNode2.SelectedImageKey = "offline2"
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of IMBuddy)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001277 RID: 4727 RVA: 0x00070864 File Offset: 0x0006EA64
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06001278 RID: 4728 RVA: 0x00070870 File Offset: 0x0006EA70
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.o.00oOo_.().Text.Trim(), "", True) = 0 OrElse Operators.CompareString(Me.oo00O._.().Text.Trim(), "", True) = 0 Then
				MessageBox.Show("请输入会议名称和描述！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Dim list As List(Of IMBuddy) = New List(Of IMBuddy)()
			Try
				For Each obj As Object In Me.o.00oOo_.().Nodes
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					Try
						For Each obj2 As Object In treeNode.Nodes
							Dim treeNode2 As TreeNode = CType(obj2, TreeNode)
							If treeNode2.Checked Then
								list.Add(CType(treeNode2.Tag, IMBuddy))
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If list.Count < 2 Then
				MessageBox.Show("请至少选择两个以上的好友参与会议!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If list.Count > 50 Then
				MessageBox.Show("参与会议的好友不能超过50!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Me.o0o.o0oO_. = list
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06001279 RID: 4729 RVA: 0x000709C8 File Offset: 0x0006EBC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If A_1.Action = TreeViewAction.ByKeyboard OrElse A_1.Action = TreeViewAction.ByMouse Then
				If A_1.Node.Level = 0 Then
					Try
						For Each obj As Object In A_1.Node.Nodes
							CType(obj, TreeNode).Checked = A_1.Node.Checked
						Next
						Return
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				If Not A_1.Node.Checked AndAlso A_1.Node.Parent.Checked Then
					A_1.Node.Parent.Checked = False
				End If
			End If
		End Sub

		' Token: 0x0600127A RID: 4730 RVA: 0x00070A84 File Offset: 0x0006EC84
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000749 RID: 1865
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400074A RID: 1866
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x0400074B RID: 1867
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400074C RID: 1868
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400074D RID: 1869
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400074E RID: 1870
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400074F RID: 1871
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000750 RID: 1872
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000751 RID: 1873
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000752 RID: 1874
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x04000753 RID: 1875
		Friend <<EMPTY_NAME>> As List(Of IMBuddy)
	End Class
End Namespace
