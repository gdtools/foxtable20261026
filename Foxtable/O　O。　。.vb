Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000061 RID: 97
	<DesignerGenerated()>
	Friend Partial Class O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06000328 RID: 808 RVA: 0x000094BC File Offset: 0x000076BC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0_00O_o.__o. IsNot Nothing Then
					Me.O0_00O_o.__o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000329 RID: 809 RVA: 0x000094FC File Offset: 0x000076FC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O00OOo_o.O.(New C1TextBox())
			Me.O00OOo_o.O.(New CheckedListBox())
			Me.O00OOo_o.O.(New C1Button())
			Me.oo_O0000o.00.(New C1Button())
			Me.O00OOo_o.O.().BeginInit()
			Me.OO_0._Oo.().BeginInit()
			Me.o._Oo0o_Oo_O_o.().BeginInit()
			MyBase.SuspendLayout()
			Me.O00OOo_o.O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O00OOo_o.O.().Location = New Point(12, 16)
			Me.O00OOo_o.O.().Name = "TextBox1"
			Me.O00OOo_o.O.().Size = New Size(415, 19)
			Me.O00OOo_o.O.().TabIndex = 0
			Me.O00OOo_o.O.().Tag = Nothing
			Me.o._Oo0o_Oo_O_o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o._Oo0o_Oo_O_o.().CheckOnClick = True
			Me.o._Oo0o_Oo_O_o.().FormattingEnabled = True
			Me.o._Oo0o_Oo_O_o.().IntegralHeight = False
			Me.o._Oo0o_Oo_O_o.().Location = New Point(12, 43)
			Me.o._Oo0o_Oo_O_o.().Name = "CheckedListBox1"
			Me.o._Oo0o_Oo_O_o.().Size = New Size(415, 268)
			Me.o._Oo0o_Oo_O_o.().TabIndex = 1
			Me.OO_0._Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO_0._Oo.().Location = New Point(271, 324)
			Me.OO_0._Oo.().Name = "Button1"
			Me.OO_0._Oo.().Size = New Size(75, 23)
			Me.OO_0._Oo.().TabIndex = 2
			Me.OO_0._Oo.().Text = "确定"
			Me.OO_0._Oo.().UseVisualStyleBackColor = True
			Me.o._Oo0o_Oo_O_o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o._Oo0o_Oo_O_o.().Location = New Point(352, 324)
			Me.o._Oo0o_Oo_O_o.().Name = "Button2"
			Me.o._Oo0o_Oo_O_o.().Size = New Size(75, 23)
			Me.o._Oo0o_Oo_O_o.().TabIndex = 3
			Me.o._Oo0o_Oo_O_o.().Text = "取消"
			Me.o._Oo0o_Oo_O_o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(439, 355)
			MyBase.Controls.Add(Me.o._Oo0o_Oo_O_o.())
			MyBase.Controls.Add(Me.OO_0._Oo.())
			MyBase.Controls.Add(Me.o._Oo0o_Oo_O_o.())
			MyBase.Controls.Add(Me.O00OOo_o.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "frmColumnsSelector"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "选择列"
			Me.O00OOo_o.O.().EndInit()
			Me.OO_0._Oo.().EndInit()
			Me.o._Oo0o_Oo_O_o.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600032A RID: 810 RVA: 0x000097F3 File Offset: 0x000079F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O00OOo_o.O.
		End Function

		' Token: 0x0600032B RID: 811 RVA: 0x000097FB File Offset: 0x000079FB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O00OOo_o.O. = A_0
		End Sub

		' Token: 0x0600032C RID: 812 RVA: 0x00009804 File Offset: 0x00007A04
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.O00OOo_o.O.
		End Function

		' Token: 0x0600032D RID: 813 RVA: 0x0000980C File Offset: 0x00007A0C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.o._Oo0o_Oo_O_o.
			Dim o00OOo_o.O. As CheckedListBox = Me.O00OOo_o.O.
			If o00OOo_o.O. IsNot Nothing Then
				RemoveHandler o00OOo_o.O..ItemCheck, value
			End If
			Me.O00OOo_o.O. = A_0
			o00OOo_o.O. = Me.O00OOo_o.O.
			If o00OOo_o.O. IsNot Nothing Then
				AddHandler o00OOo_o.O..ItemCheck, value
			End If
		End Sub

		' Token: 0x0600032E RID: 814 RVA: 0x0000984F File Offset: 0x00007A4F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00OOo_o.O.
		End Function

		' Token: 0x0600032F RID: 815 RVA: 0x00009858 File Offset: 0x00007A58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o._Oo0o_Oo_O_o.
			Dim o00OOo_o.O. As C1Button = Me.O00OOo_o.O.
			If o00OOo_o.O. IsNot Nothing Then
				RemoveHandler o00OOo_o.O..Click, value
			End If
			Me.O00OOo_o.O. = A_0
			o00OOo_o.O. = Me.O00OOo_o.O.
			If o00OOo_o.O. IsNot Nothing Then
				AddHandler o00OOo_o.O..Click, value
			End If
		End Sub

		' Token: 0x06000330 RID: 816 RVA: 0x0000989B File Offset: 0x00007A9B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_O0000o.00.
		End Function

		' Token: 0x06000331 RID: 817 RVA: 0x000098A4 File Offset: 0x00007AA4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO_0._Oo.
			Dim c1Button As C1Button = Me.oo_O0000o.00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_O0000o.00. = A_0
			c1Button = Me.oo_O0000o.00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000332 RID: 818 RVA: 0x000098E8 File Offset: 0x00007AE8
		Public Sub New(A_0 As Table, A_1 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.o._Oo0o_Oo_O_o.
			Me.O00OOo_o.O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim list As List(Of String) = New List(Of String)()
			Me.O0_00O_o.__o. = A_0
			If Operators.CompareString(A_1, "", True) > 0 Then
				list.AddRange(A_1.Split(New Char() { "|"c }))
			End If
			Try
				For Each col As Col In A_0.Cols
					Me.o._Oo0o_Oo_O_o.().Items.Add(col.Name)
					If list.Contains(col.Name) Then
						Me.o._Oo0o_Oo_O_o.().SetItemChecked(Me.o._Oo0o_Oo_O_o.().Items.Count - 1, True)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Col)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			For i As Integer = list.Count - 1 To 0 Step -1
				If Not A_0.Cols.Contains(list(i)) Then
					list.RemoveAt(i)
				End If
			Next
			If list.Count > 0 Then
				Dim text As String = String.Join("|", list.ToArray())
				Me.O0_00O_o.__o. = text.Trim(New Char() { "|"c })
				Me.O00OOo_o.O.().Value = Me.O0_00O_o.__o.
			End If
		End Sub

		' Token: 0x06000333 RID: 819 RVA: 0x00009A54 File Offset: 0x00007C54
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06000334 RID: 820 RVA: 0x00009A5D File Offset: 0x00007C5D
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0_00O_o.__o. = Me.O00OOo_o.O.().Text
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06000335 RID: 821 RVA: 0x00009A78 File Offset: 0x00007C78
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim list As List(Of String) = New List(Of String)()
			If Operators.CompareString(Me.O00OOo_o.O.().Text, "", True) > 0 Then
				list.AddRange(Me.O00OOo_o.O.().Text.Split(New Char() { "|"c }))
			End If
			Dim item As String = Me.o._Oo0o_Oo_O_o.().Items(A_1.Index).ToString()
			If A_1.NewValue = CheckState.Checked Then
				If Not list.Contains(item) Then
					list.Add(item)
				End If
			ElseIf list.Contains(item) Then
				list.Remove(item)
			End If
			Me.O00OOo_o.O.().Value = String.Join("|", list.ToArray())
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x00009B28 File Offset: 0x00007D28
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400008A RID: 138
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400008B RID: 139
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400008C RID: 140
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x0400008D RID: 141
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400008E RID: 142
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400008F RID: 143
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000090 RID: 144
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
