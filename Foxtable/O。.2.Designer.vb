Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003DA RID: 986
	<DesignerGenerated()>
	Friend Class O\u3002\u3000
		Inherits DropDownForm

		' Token: 0x06003ED3 RID: 16083 RVA: 0x001B2394 File Offset: 0x001B0594
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O__o0Oo_o.0. IsNot Nothing Then
					Me.O__o0Oo_o.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003ED4 RID: 16084 RVA: 0x001B23D4 File Offset: 0x001B05D4
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O__0o.o0_.(New C1Button())
			Me.oo00Oo.O0OO0_.(New C1Button())
			Me.O__o0Oo_o.0.(New CustomCheckedListBox())
			Me.Oooo_._O0.(New C1Button())
			Me.O__0o.o0_.().BeginInit()
			Me.O0.O0_.().BeginInit()
			Me.oo00Oo.O0OO0_.().BeginInit()
			MyBase.SuspendLayout()
			Me.O__0o.o0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O__0o.o0_.().Location = New Point(90, 202)
			Me.O__0o.o0_.().Name = "btnOK"
			Me.O__0o.o0_.().Size = New Size(46, 21)
			Me.O__0o.o0_.().TabIndex = 1
			Me.O__0o.o0_.().Text = "确定"
			Me.O__0o.o0_.().UseVisualStyleBackColor = True
			Me.O0.O0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O0.O0_.().DialogResult = DialogResult.Cancel
			Me.O0.O0_.().Location = New Point(140, 202)
			Me.O0.O0_.().Name = "btnCancel"
			Me.O0.O0_.().Size = New Size(46, 21)
			Me.O0.O0_.().TabIndex = 2
			Me.O0.O0_.().Text = "取消"
			Me.O0.O0_.().UseVisualStyleBackColor = True
			Me.O__0o.o0_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O__0o.o0_.().CheckOnClick = True
			Me.O__0o.o0_.().FormattingEnabled = True
			Me.O__0o.o0_.().Location = New Point(2, 3)
			Me.O__0o.o0_.().Name = "CheckedListBox"
			Me.O__0o.o0_.().SelectedValue2 = Nothing
			Me.O__0o.o0_.().Separator = ","
			Me.O__0o.o0_.().Size = New Size(185, 164)
			Me.O__0o.o0_.().TabIndex = 0
			Me.O__0o.o0_.().Value = ""
			Me.oo00Oo.O0OO0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oo00Oo.O0OO0_.().Location = New Point(2, 202)
			Me.oo00Oo.O0OO0_.().Name = "btnSelectAll"
			Me.oo00Oo.O0OO0_.().Size = New Size(46, 21)
			Me.oo00Oo.O0OO0_.().TabIndex = 3
			Me.oo00Oo.O0OO0_.().Text = "全选"
			Me.oo00Oo.O0OO0_.().UseVisualStyleBackColor = True
			MyBase.AcceptButton = Me.O__0o.o0_.()
			MyBase.AutoScaleMode = AutoScaleMode.None
			MyBase.CancelButton = Me.O0.O0_.()
			MyBase.ClientSize = New Size(187, 224)
			MyBase.Controls.Add(Me.oo00Oo.O0OO0_.())
			MyBase.Controls.Add(Me.O__0o.o0_.())
			MyBase.Controls.Add(Me.O0.O0_.())
			MyBase.Controls.Add(Me.O__0o.o0_.())
			MyBase.Name = "frmMultiValueEditor"
			Me.Text = "frmMultiValue"
			Me.O__0o.o0_.().EndInit()
			Me.O0.O0_.().EndInit()
			Me.oo00Oo.O0OO0_.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003ED5 RID: 16085 RVA: 0x001B26E0 File Offset: 0x001B08E0
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__o0Oo_o.0.
		End Function

		' Token: 0x06003ED6 RID: 16086 RVA: 0x001B26E8 File Offset: 0x001B08E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O00o.0o_Oo0.
			Dim o__o0Oo_o.0. As C1Button = Me.O__o0Oo_o.0.
			If o__o0Oo_o.0. IsNot Nothing Then
				RemoveHandler o__o0Oo_o.0..Click, value
			End If
			Me.O__o0Oo_o.0. = A_0
			o__o0Oo_o.0. = Me.O__o0Oo_o.0.
			If o__o0Oo_o.0. IsNot Nothing Then
				AddHandler o__o0Oo_o.0..Click, value
			End If
		End Sub

		' Token: 0x06003ED7 RID: 16087 RVA: 0x001B272B File Offset: 0x001B092B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo_O0.0o_O.
		End Function

		' Token: 0x06003ED8 RID: 16088 RVA: 0x001B2734 File Offset: 0x001B0934
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO__.00000_o.
			Dim ooo_O0.0o_O. As C1Button = Me.Ooo_O0.0o_O.
			If ooo_O0.0o_O. IsNot Nothing Then
				RemoveHandler ooo_O0.0o_O..Click, value
			End If
			Me.Ooo_O0.0o_O. = A_0
			ooo_O0.0o_O. = Me.Ooo_O0.0o_O.
			If ooo_O0.0o_O. IsNot Nothing Then
				AddHandler ooo_O0.0o_O..Click, value
			End If
		End Sub

		' Token: 0x06003ED9 RID: 16089 RVA: 0x001B2777 File Offset: 0x001B0977
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CustomCheckedListBox
			Return Me.O__o0Oo_o.0.
		End Function

		' Token: 0x06003EDA RID: 16090 RVA: 0x001B277F File Offset: 0x001B097F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CustomCheckedListBox)
			Me.O__o0Oo_o.0. = A_0
		End Sub

		' Token: 0x06003EDB RID: 16091 RVA: 0x001B2788 File Offset: 0x001B0988
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oooo_._O0.
		End Function

		' Token: 0x06003EDC RID: 16092 RVA: 0x001B2790 File Offset: 0x001B0990
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__0o.o0_.
			Dim oooo_._O0. As C1Button = Me.Oooo_._O0.
			If oooo_._O0. IsNot Nothing Then
				RemoveHandler oooo_._O0..Click, value
			End If
			Me.Oooo_._O0. = A_0
			oooo_._O0. = Me.Oooo_._O0.
			If oooo_._O0. IsNot Nothing Then
				AddHandler oooo_._O0..Click, value
			End If
		End Sub

		' Token: 0x06003EDD RID: 16093 RVA: 0x001B27D3 File Offset: 0x001B09D3
		Public Sub New()
			MyBase.PostChanges += AddressOf Me.Oo_0_._O0_0_o.
			Me.O__0o.o0_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003EDE RID: 16094 RVA: 0x001B2808 File Offset: 0x001B0A08
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DialogResult = DialogResult.OK Then
				MyBase.OwnerControl.Value = Me.O__0o.o0_.().Value
				If MyBase.OwnerControl.DataBindings.Count > 0 Then
					MyBase.OwnerControl.DataBindings(0).WriteValue()
				End If
			End If
		End Sub

		' Token: 0x06003EDF RID: 16095 RVA: 0x001B285D File Offset: 0x001B0A5D
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.OK
			MyBase.OwnerControl.CloseDropDown()
		End Sub

		' Token: 0x06003EE0 RID: 16096 RVA: 0x001B2871 File Offset: 0x001B0A71
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.OwnerControl.CloseDropDown()
		End Sub

		' Token: 0x06003EE1 RID: 16097 RVA: 0x001B2888 File Offset: 0x001B0A88
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.OwnerControl.[Select]()
			Dim num As Integer = 0
			Dim num2 As Integer = Me.O__0o.o0_.().Items.Count - 1
			For i As Integer = 0 To num2
				If Me.O__0o.o0_.().GetItemChecked(i) Then
					num += 1
				End If
			Next
			Dim value As Boolean = num <> Me.O__0o.o0_.().Items.Count
			Dim num3 As Integer = Me.O__0o.o0_.().Items.Count - 1
			For j As Integer = 0 To num3
				Me.O__0o.o0_.().SetItemChecked(j, value)
			Next
		End Sub

		' Token: 0x0400197D RID: 6525
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400197E RID: 6526
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400197F RID: 6527
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001980 RID: 6528
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CustomCheckedListBox

		' Token: 0x04001981 RID: 6529
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
