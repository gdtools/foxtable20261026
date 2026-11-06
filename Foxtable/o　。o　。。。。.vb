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
	' Token: 0x02000191 RID: 401
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Partial Class o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000
		Inherits Form

		' Token: 0x0600127B RID: 4731 RVA: 0x00070A98 File Offset: 0x0006EC98
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo.ooOOoo. IsNot Nothing Then
					Me.oo.ooOOoo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600127C RID: 4732 RVA: 0x00070AD8 File Offset: 0x0006ECD8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_OOo.O_O.(New C1Button())
			Me.o0.o_0Oo_OO0o.(New C1Button())
			Me.o0.o_0Oo_OO0o.(New Label())
			Me.o0.o_0Oo_OO0o.(New TreeView())
			MyBase.SuspendLayout()
			Me.O0_00._O.().Location = New Point(242, 473)
			Me.O0_00._O.().Name = "btnCancel"
			Me.O0_00._O.().Size = New Size(75, 23)
			Me.O0_00._O.().TabIndex = 8
			Me.O0_00._O.().Text = "取消"
			Me.O0_00._O.().UseVisualStyleBackColor = True
			Me.oO_o_0_o.0_.().Location = New Point(161, 473)
			Me.oO_o_0_o.0_.().Name = "btnOK"
			Me.oO_o_0_o.0_.().Size = New Size(75, 23)
			Me.oO_o_0_o.0_.().TabIndex = 7
			Me.oO_o_0_o.0_.().Text = "确定"
			Me.oO_o_0_o.0_.().UseVisualStyleBackColor = True
			Me.oO_o_0_o.0_.().AutoSize = True
			Me.oO_o_0_o.0_.().Location = New Point(14, 12)
			Me.oO_o_0_o.0_.().Name = "Label2"
			Me.oO_o_0_o.0_.().Size = New Size(95, 12)
			Me.oO_o_0_o.0_.().TabIndex = 6
			Me.oO_o_0_o.0_.().Text = "选择会议参与者:"
			Me.o0.o_0Oo_OO0o.().CheckBoxes = True
			Me.o0.o_0Oo_OO0o.().Location = New Point(16, 35)
			Me.o0.o_0Oo_OO0o.().Name = "trvUsers"
			Me.o0.o_0Oo_OO0o.().Size = New Size(449, 419)
			Me.o0.o_0Oo_OO0o.().TabIndex = 5
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(479, 508)
			MyBase.Controls.Add(Me.O0_00._O.())
			MyBase.Controls.Add(Me.oO_o_0_o.0_.())
			MyBase.Controls.Add(Me.oO_o_0_o.0_.())
			MyBase.Controls.Add(Me.o0.o_0Oo_OO0o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.....0."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择会议参与者"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600127D RID: 4733 RVA: 0x00070D54 File Offset: 0x0006EF54
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.o_0Oo_OO0o.
		End Function

		' Token: 0x0600127E RID: 4734 RVA: 0x00070D5C File Offset: 0x0006EF5C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_00._O.
			Dim c1Button As C1Button = Me.o0.o_0Oo_OO0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0.o_0Oo_OO0o. = A_0
			c1Button = Me.o0.o_0Oo_OO0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600127F RID: 4735 RVA: 0x00070D9F File Offset: 0x0006EF9F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_OOo.O_O.
		End Function

		' Token: 0x06001280 RID: 4736 RVA: 0x00070DA8 File Offset: 0x0006EFA8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO_o_0_o.0_.
			Dim c1Button As C1Button = Me.o_OOo.O_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_OOo.O_O. = A_0
			c1Button = Me.o_OOo.O_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001281 RID: 4737 RVA: 0x00070DEB File Offset: 0x0006EFEB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o0.o_0Oo_OO0o.
		End Function

		' Token: 0x06001282 RID: 4738 RVA: 0x00070DF3 File Offset: 0x0006EFF3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0.o_0Oo_OO0o. = A_0
		End Sub

		' Token: 0x06001283 RID: 4739 RVA: 0x00070DFC File Offset: 0x0006EFFC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.oo.ooOOoo.
		End Function

		' Token: 0x06001284 RID: 4740 RVA: 0x00070E04 File Offset: 0x0006F004
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.o0.o_0Oo_OO0o.
			Dim treeView As TreeView = Me.oo.ooOOoo.
			If treeView IsNot Nothing Then
				RemoveHandler treeView.AfterCheck, value
			End If
			Me.oo.ooOOoo. = A_0
			treeView = Me.oo.ooOOoo.
			If treeView IsNot Nothing Then
				AddHandler treeView.AfterCheck, value
			End If
		End Sub

		' Token: 0x06001285 RID: 4741 RVA: 0x00070E48 File Offset: 0x0006F048
		Public Sub New(A_0 As IMClient, A_1 As ImageList, A_2 As List(Of IMBuddy))
			AddHandler MyBase.FormClosed, AddressOf Me.oO_o_0_o.0_.
			Me.o0.o_0Oo_OO0o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oo.ooOOoo. = A_0
			Dim treeView As TreeView = Me.o0.o_0Oo_OO0o.()
			treeView.ImageList = A_1
			Try
				For Each imbuddy As IMBuddy In Me.oo.ooOOoo..Buddies
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
						If A_2.Contains(imbuddy) Then
							treeNode2.Checked = True
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of IMBuddy)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				For Each obj As Object In Me.o0.o_0Oo_OO0o.().Nodes
					Dim treeNode3 As TreeNode = CType(obj, TreeNode)
					Dim num As Integer = 0
					Try
						Dim enumerator3 As IEnumerator = treeNode3.Nodes.GetEnumerator()
						While enumerator3.MoveNext()
							If CType(enumerator3.Current, TreeNode).Checked Then
								num += 1
							End If
						End While
					Finally
						Dim enumerator3 As IEnumerator
						If TypeOf enumerator3 Is IDisposable Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
					If num = treeNode3.Nodes.Count Then
						treeNode3.Checked = True
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001286 RID: 4742 RVA: 0x00071060 File Offset: 0x0006F260
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06001287 RID: 4743 RVA: 0x0007106C File Offset: 0x0006F26C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim list As List(Of IMBuddy) = New List(Of IMBuddy)()
			Try
				For Each obj As Object In Me.o0.o_0Oo_OO0o.().Nodes
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
			Me.oo.ooOOoo. = list
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06001288 RID: 4744 RVA: 0x00071178 File Offset: 0x0006F378
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If A_1.Node.Level = 0 AndAlso (A_1.Action = TreeViewAction.ByMouse OrElse A_1.Action = TreeViewAction.ByKeyboard) Then
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
			If A_1.Node.Level = 1 AndAlso Not A_1.Node.Checked Then
				A_1.Node.Parent.Checked = False
			End If
		End Sub

		' Token: 0x06001289 RID: 4745 RVA: 0x00071230 File Offset: 0x0006F430
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000754 RID: 1876
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000755 RID: 1877
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000756 RID: 1878
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000757 RID: 1879
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000758 RID: 1880
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04000759 RID: 1881
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x0400075A RID: 1882
		Friend <<EMPTY_NAME>> As List(Of IMBuddy)
	End Class
End Namespace
