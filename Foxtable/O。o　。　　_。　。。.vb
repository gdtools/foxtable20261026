Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000334 RID: 820
	<DesignerGenerated()>
	Friend Partial Class O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002
		Inherits Form

		' Token: 0x060030FD RID: 12541 RVA: 0x0013DE6C File Offset: 0x0013C06C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OoO_.O. IsNot Nothing Then
					Me.OoO_.O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060030FE RID: 12542 RVA: 0x0013DEAC File Offset: 0x0013C0AC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Oo_0.oooo__.(New C1Button())
			Me.Oo0.o0.(New C1Button())
			Me.OO.o0o0.(New C1FlexGrid())
			Me.OO.o0o0.(New C1TextBox())
			Me.OO__.o___oO.(New RadioButton())
			Me.Oo_0.oooo__.(New RadioButton())
			Me.o_0O.0.(New RadioButton())
			Me.OO.o0o0.(New OpenFileDialog())
			Me.O.0Ooo_.(New RadioButton())
			Me.OO.o0o0.(New RadioButton())
			Me.Oo_OO_o0oO.oo.(New RadioButton())
			Me.OoOO.000_o_O.().BeginInit()
			MyBase.SuspendLayout()
			Me.OoOO.000_o_O.().DialogResult = DialogResult.OK
			Me.OoOO.000_o_O.().Location = New Point(327, 395)
			Me.OoOO.000_o_O.().Name = "Button2"
			Me.OoOO.000_o_O.().Size = New Size(75, 23)
			Me.OoOO.000_o_O.().TabIndex = 9
			Me.OoOO.000_o_O.().Text = "取消"
			Me.OoOO.000_o_O.().UseVisualStyleBackColor = True
			Me.O.__0OO0O0.().Location = New Point(236, 395)
			Me.O.__0OO0O0.().Name = "Button1"
			Me.O.__0OO0O0.().Size = New Size(75, 23)
			Me.O.__0OO0O0.().TabIndex = 8
			Me.O.__0OO0O0.().Text = "确定"
			Me.O.__0OO0O0.().UseVisualStyleBackColor = True
			Me.OoOO.000_o_O.().AllowEditing = False
			Me.OoOO.000_o_O.().ColumnInfo = "10,1,0,25,0,0,Columns:"
			Me.OoOO.000_o_O.().Location = New Point(12, 12)
			Me.OoOO.000_o_O.().Name = "Grid"
			Me.OoOO.000_o_O.().Rows.DefaultSize = 20
			Me.OoOO.000_o_O.().SelectionMode = 5
			Me.OoOO.000_o_O.().Size = New Size(597, 287)
			Me.OoOO.000_o_O.().TabIndex = 0
			Me.Oo0.o0.().AcceptsReturn = True
			Me.Oo0.o0.().Location = New Point(125, 344)
			Me.Oo0.o0.().Name = "txtSeparator"
			Me.Oo0.o0.().[ReadOnly] = True
			Me.Oo0.o0.().Size = New Size(100, 21)
			Me.Oo0.o0.().TabIndex = 4
			Me.Oo0.o0.().Value = ","
			Me.O_.00_.().AutoSize = True
			Me.O_.00_.().Location = New Point(12, 346)
			Me.O_.00_.().Name = "Custom"
			Me.O_.00_.().Size = New Size(107, 16)
			Me.O_.00_.().TabIndex = 3
			Me.O_.00_.().TabStop = True
			Me.O_.00_.().Text = "自定义列分隔符"
			Me.O_.00_.().UseVisualStyleBackColor = True
			Me.OoOO.000_o_O.().AutoSize = True
			Me.OoOO.000_o_O.().Location = New Point(131, 314)
			Me.OoOO.000_o_O.().Name = "Comma"
			Me.OoOO.000_o_O.().Size = New Size(95, 16)
			Me.OoOO.000_o_O.().TabIndex = 2
			Me.OoOO.000_o_O.().Text = "用逗号分割列"
			Me.OoOO.000_o_O.().UseVisualStyleBackColor = True
			Me.O_.O0o_O.().AutoSize = True
			Me.O_.O0o_O.().Checked = True
			Me.O_.O0o_O.().Location = New Point(12, 315)
			Me.O_.O0o_O.().Name = "Tab"
			Me.O_.O0o_O.().Size = New Size(101, 16)
			Me.O_.O0o_O.().TabIndex = 1
			Me.O_.O0o_O.().TabStop = True
			Me.O_.O0o_O.().Text = "用Tab符分隔列"
			Me.O_.O0o_O.().UseVisualStyleBackColor = True
			Me.OoOO.000_o_O.().Filter = "Text文件(*.txt)|*.txt"
			Me.O0O00._OOoO.().AutoSize = True
			Me.O0O00._OOoO.().Location = New Point(406, 358)
			Me.O0O00._OOoO.().Name = "IgnorePrimaryKey"
			Me.O0O00._OOoO.().Size = New Size(203, 16)
			Me.O0O00._OOoO.().TabIndex = 7
			Me.O0O00._OOoO.().Text = "合并过程不比较主键(无条件合并)"
			Me.O0O00._OOoO.().UseVisualStyleBackColor = True
			Me.Oo_0.oooo__.().AutoSize = True
			Me.Oo_0.oooo__.().Checked = True
			Me.Oo_0.oooo__.().Location = New Point(406, 336)
			Me.Oo_0.oooo__.().Name = "SkipExistRow"
			Me.Oo_0.oooo__.().Size = New Size(107, 16)
			Me.Oo_0.oooo__.().TabIndex = 6
			Me.Oo_0.oooo__.().TabStop = True
			Me.Oo_0.oooo__.().Text = "跳过同主键记录"
			Me.Oo_0.oooo__.().UseVisualStyleBackColor = True
			Me.Oo0O.__0Oo_.().AutoSize = True
			Me.Oo0O.__0Oo_.().Location = New Point(406, 314)
			Me.Oo0O.__0Oo_.().Name = "UpdateExistRow"
			Me.Oo0O.__0Oo_.().Size = New Size(107, 16)
			Me.Oo0O.__0Oo_.().TabIndex = 5
			Me.Oo0O.__0Oo_.().Text = "更新同主键记录"
			Me.Oo0O.__0Oo_.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(628, 430)
			MyBase.Controls.Add(Me.O0O00._OOoO.())
			MyBase.Controls.Add(Me.Oo_0.oooo__.())
			MyBase.Controls.Add(Me.Oo0O.__0Oo_.())
			MyBase.Controls.Add(Me.OoOO.000_o_O.())
			MyBase.Controls.Add(Me.O.__0OO0O0.())
			MyBase.Controls.Add(Me.OoOO.000_o_O.())
			MyBase.Controls.Add(Me.Oo0.o0.())
			MyBase.Controls.Add(Me.O_.00_.())
			MyBase.Controls.Add(Me.OoOO.000_o_O.())
			MyBase.Controls.Add(Me.O_.O0o_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO..o..O"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "合并"
			Me.OoOO.000_o_O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060030FF RID: 12543 RVA: 0x0013E530 File Offset: 0x0013C730
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0oOOoo_0OOo.0.
		End Function

		' Token: 0x06003100 RID: 12544 RVA: 0x0013E538 File Offset: 0x0013C738
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0oOOoo_0OOo.0. = A_0
		End Sub

		' Token: 0x06003101 RID: 12545 RVA: 0x0013E541 File Offset: 0x0013C741
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O._o_oOo.
		End Function

		' Token: 0x06003102 RID: 12546 RVA: 0x0013E54C File Offset: 0x0013C74C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOO.000_o_O.
			Dim c1Button As C1Button = Me.o0O._o_oOo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O._o_oOo. = A_0
			c1Button = Me.o0O._o_oOo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003103 RID: 12547 RVA: 0x0013E58F File Offset: 0x0013C78F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o0oOOoo_0OOo.0.
		End Function

		' Token: 0x06003104 RID: 12548 RVA: 0x0013E597 File Offset: 0x0013C797
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.o0oOOoo_0OOo.0. = A_0
		End Sub

		' Token: 0x06003105 RID: 12549 RVA: 0x0013E5A0 File Offset: 0x0013C7A0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0oOOoo_0OOo.0.
		End Function

		' Token: 0x06003106 RID: 12550 RVA: 0x0013E5A8 File Offset: 0x0013C7A8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As EventHandler = AddressOf Me.O0oooO00Oo.00.
			Dim c1TextBox As C1TextBox = Me.o0oOOoo_0OOo.0.
			If c1TextBox IsNot Nothing Then
				RemoveHandler c1TextBox.TextChanged, value
			End If
			Me.o0oOOoo_0OOo.0. = A_0
			c1TextBox = Me.o0oOOoo_0OOo.0.
			If c1TextBox IsNot Nothing Then
				AddHandler c1TextBox.TextChanged, value
			End If
		End Sub

		' Token: 0x06003107 RID: 12551 RVA: 0x0013E5EB File Offset: 0x0013C7EB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0oOOoo_0OOo.0.
		End Function

		' Token: 0x06003108 RID: 12552 RVA: 0x0013E5F4 File Offset: 0x0013C7F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O.0Ooo_.
			Dim radioButton As RadioButton = Me.o0oOOoo_0OOo.0.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o0oOOoo_0OOo.0. = A_0
			radioButton = Me.o0oOOoo_0OOo.0.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06003109 RID: 12553 RVA: 0x0013E637 File Offset: 0x0013C837
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0O._o_oOo.
		End Function

		' Token: 0x0600310A RID: 12554 RVA: 0x0013E640 File Offset: 0x0013C840
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O.0Ooo_.
			Dim radioButton As RadioButton = Me.o0O._o_oOo.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o0O._o_oOo. = A_0
			radioButton = Me.o0O._o_oOo.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600310B RID: 12555 RVA: 0x0013E683 File Offset: 0x0013C883
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_o._Oo0oo_0.
		End Function

		' Token: 0x0600310C RID: 12556 RVA: 0x0013E68C File Offset: 0x0013C88C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O.0Ooo_.
			Dim o_o._Oo0oo_0. As RadioButton = Me.O_o._Oo0oo_0.
			If o_o._Oo0oo_0. IsNot Nothing Then
				RemoveHandler o_o._Oo0oo_0..CheckedChanged, value
			End If
			Me.O_o._Oo0oo_0. = A_0
			o_o._Oo0oo_0. = Me.O_o._Oo0oo_0.
			If o_o._Oo0oo_0. IsNot Nothing Then
				AddHandler o_o._Oo0oo_0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600310D RID: 12557 RVA: 0x0013E6CF File Offset: 0x0013C8CF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As OpenFileDialog
			Return Me.o0oOOoo_0OOo.0.
		End Function

		' Token: 0x0600310E RID: 12558 RVA: 0x0013E6D7 File Offset: 0x0013C8D7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OpenFileDialog)
			Me.o0oOOoo_0OOo.0. = A_0
		End Sub

		' Token: 0x0600310F RID: 12559 RVA: 0x0013E6E0 File Offset: 0x0013C8E0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.oo.o_Oo_OO.
		End Function

		' Token: 0x06003110 RID: 12560 RVA: 0x0013E6E8 File Offset: 0x0013C8E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.oo.o_Oo_OO. = A_0
		End Sub

		' Token: 0x06003111 RID: 12561 RVA: 0x0013E6F1 File Offset: 0x0013C8F1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.oOO.00O.
		End Function

		' Token: 0x06003112 RID: 12562 RVA: 0x0013E6F9 File Offset: 0x0013C8F9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.oOO.00O. = A_0
		End Sub

		' Token: 0x06003113 RID: 12563 RVA: 0x0013E702 File Offset: 0x0013C902
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.oOo_o_OO.O.
		End Function

		' Token: 0x06003114 RID: 12564 RVA: 0x0013E70A File Offset: 0x0013C90A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.oOo_o_OO.O. = A_0
		End Sub

		' Token: 0x06003115 RID: 12565 RVA: 0x0013E713 File Offset: 0x0013C913
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OoOO.000_o_O.
			Me.Oo0.o0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003116 RID: 12566 RVA: 0x0013E748 File Offset: 0x0013C948
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.OoO_.O., "", True) <> 0 Then
				Me.OoOO.000_o_O.().AutoResize = True
				Me.OoOO.000_o_O.().Rows.Count = 1
				Me.OoOO.000_o_O.().Cols.Count = 1
				Me.OoOO.000_o_O.().Clear(65535)
				If Me.O_.O0o_O.().Checked Then
					Extensions.LoadGrid(Me.OoOO.000_o_O.(), Me.OoO_.O., 1, 1, Encoding.[Default])
					Me.OoOO.000_o_O.().Cols.Insert(0)
				ElseIf Me.OoOO.000_o_O.().Checked Then
					Extensions.LoadGrid(Me.OoOO.000_o_O.(), Me.OoO_.O., 0, 1, Encoding.[Default])
					Me.OoOO.000_o_O.().Cols.Insert(0)
				ElseIf Operators.CompareString(Me.Oo0.o0.().Text, "", True) > 0 Then
					Me.OoOO.000_o_O.().ClipSeparators = Conversions.ToString(Me.Oo0.o0.().Text.ToCharArray()(0)) + vbCr
					Extensions.LoadGrid(Me.OoOO.000_o_O.(), Me.OoO_.O., 2, 1, Encoding.[Default])
					Me.OoOO.000_o_O.().Cols.Insert(0)
				End If
				For i As Integer = Me.OoOO.000_o_O.().Cols.Count - 1 To 1 Step -1
					Dim text As String = ""
					If Me.OoOO.000_o_O.()(0, i) IsNot Nothing Then
						text = Me.OoOO.000_o_O.()(0, i).ToString()
					End If
					If o_O_o_oOoo__.oO.O_..Contains(text) Then
						Me.OoOO.000_o_O.().Cols.Remove(i)
					Else
						If Operators.CompareString(text, "", True) = 0 OrElse Not o_O_o_oOoo__.O_o_._o0.(text, True) Then
							Dim num As Integer = 1
							While Me.OoOO.000_o_O.("第" + Conversions.ToString(num) + "列", i)
								num += 1
							End While
							Me.OoOO.000_o_O.()(0, i) = "第" + Conversions.ToString(num) + "列"
							text = "第" + Conversions.ToString(num) + "列"
						End If
						Me.OoOO.000_o_O.().Cols(i).Name = text
					End If
				Next
				Me.OoOO.000_o_O.().AutoSizeCols()
				Me.OoOO.000_o_O.().Cols(0).Width = 23
			End If
		End Sub

		' Token: 0x06003117 RID: 12567 RVA: 0x0013E9AC File Offset: 0x0013CBAC
		Private Overloads Function <<EMPTY_NAME>>(A_0 As String, A_1 As Integer) As Boolean
			Dim num As Integer = Me.OoOO.000_o_O.().Cols.Count - 1
			For i As Integer = 1 To num
				If i <> A_1 AndAlso Me.OoOO.000_o_O.()(0, i) IsNot Nothing AndAlso Operators.CompareString(Me.OoOO.000_o_O.()(0, i).ToString(), A_0, True) = 0 Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x06003118 RID: 12568 RVA: 0x0013EA0D File Offset: 0x0013CC0D
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Oo_0.oooo__.()
			Me.Oo0.o0.().[ReadOnly] = Not Me.O_.00_.().Checked
		End Sub

		' Token: 0x06003119 RID: 12569 RVA: 0x0013EA2E File Offset: 0x0013CC2E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Oo0.o0.().Text.Length > 0 Then
				Me.Oo_0.oooo__.()
			End If
		End Sub

		' Token: 0x0600311A RID: 12570 RVA: 0x0013EA4C File Offset: 0x0013CC4C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Dim a_ As TableMergeTypeEnum
				If Me.Oo0O.__0Oo_.().Checked Then
					a_ = 0
				ElseIf Me.O0O00._OOoO.().Checked Then
					a_ = 2
				Else
					a_ = 0
				End If
				Me.Cursor = Cursors.WaitCursor
				If Oo00.o00O0O_.O.(Me.OoOO.000_o_O.(), Path.GetFileNameWithoutExtension(Me.OoO_.O.), a_) Then
					MyBase.DialogResult = DialogResult.OK
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			Finally
				Me.Cursor = Cursors.[Default]
			End Try
		End Sub

		' Token: 0x0600311B RID: 12571 RVA: 0x0013EAEC File Offset: 0x0013CCEC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013A7 RID: 5031
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013A8 RID: 5032
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013A9 RID: 5033
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013AA RID: 5034
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040013AB RID: 5035
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040013AC RID: 5036
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013AD RID: 5037
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013AE RID: 5038
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013AF RID: 5039
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x040013B0 RID: 5040
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013B1 RID: 5041
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013B2 RID: 5042
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013B3 RID: 5043
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
