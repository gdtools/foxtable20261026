Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Foxtable.RibbonMenu
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200032E RID: 814
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06003063 RID: 12387 RVA: 0x00138D78 File Offset: 0x00136F78
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0_0.0OOO_0Oo. IsNot Nothing Then
					Me.o0_0.0OOO_0Oo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003064 RID: 12388 RVA: 0x00138DB8 File Offset: 0x00136FB8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo_.oO.(New RadioButton())
			Me.O00_O.O0.(New RadioButton())
			Me.O00_O.O0.(New CheckedListBox())
			Me.O00_O.O0.(New System.Windows.Forms.Label())
			Me.o_o_O0_.O.(New C1Button())
			Me.O0o.o.(New C1Button())
			Me.O00_O.O0.(New SaveFileDialog())
			Me.oo_.oO.(New C1CheckBox())
			Me.O00_O.O0.(New C1CheckBox())
			Me.o0__oo._o.(New RadioButton())
			Me.O00_O.O0.(New C1TextBox())
			MyBase.SuspendLayout()
			Me.oo_0O.O0oo_o.().AutoSize = True
			Me.oo_0O.O0oo_o.().Checked = True
			Me.oo_0O.O0oo_o.().Location = New Point(14, 320)
			Me.oo_0O.O0oo_o.().Name = "Tab"
			Me.oo_0O.O0oo_o.().Size = New Size(101, 16)
			Me.oo_0O.O0oo_o.().TabIndex = 1
			Me.oo_0O.O0oo_o.().TabStop = True
			Me.oo_0O.O0oo_o.().Text = "用Tab符分隔列"
			Me.oo_0O.O0oo_o.().UseVisualStyleBackColor = True
			Me.O00_0.0o00_.().AutoSize = True
			Me.O00_0.0o00_.().Location = New Point(14, 342)
			Me.O00_0.0o00_.().Name = "Comma"
			Me.O00_0.0o00_.().Size = New Size(95, 16)
			Me.O00_0.0o00_.().TabIndex = 2
			Me.O00_0.0o00_.().Text = "用逗号分割列"
			Me.O00_0.0o00_.().UseVisualStyleBackColor = True
			Me.O0o.o.().FormattingEnabled = True
			Me.O0o.o.().Location = New Point(12, 28)
			Me.O0o.o.().Name = "lstColumns"
			Me.O0o.o.().Size = New Size(471, 276)
			Me.O0o.o.().TabIndex = 0
			Me.O0o.o.().AutoSize = True
			Me.O0o.o.().Location = New Point(12, 9)
			Me.O0o.o.().Name = "Label1"
			Me.O0o.o.().Size = New Size(47, 12)
			Me.O0o.o.().TabIndex = 33
			Me.O0o.o.().Text = "选择列:"
			Me.O00_0.0o00_.().DialogResult = DialogResult.OK
			Me.O00_0.0o00_.().Location = New Point(164, 408)
			Me.O00_0.0o00_.().Name = "Button2"
			Me.O00_0.0o00_.().Size = New Size(75, 23)
			Me.O00_0.0o00_.().TabIndex = 7
			Me.O00_0.0o00_.().Text = "确定"
			Me.O00_0.0o00_.().UseVisualStyleBackColor = True
			Me.Oo_.Oo0.().DialogResult = DialogResult.Cancel
			Me.Oo_.Oo0.().Location = New Point(255, 408)
			Me.Oo_.Oo0.().Name = "Button3"
			Me.Oo_.Oo0.().Size = New Size(75, 23)
			Me.Oo_.Oo0.().TabIndex = 8
			Me.Oo_.Oo0.().Text = "取消"
			Me.Oo_.Oo0.().UseVisualStyleBackColor = True
			Me.O00_0.0o00_.().Filter = "文本文件(*.txt)|*.txt"
			Me.O0o.o.().AutoSize = True
			Me.O0o.o.().Location = New Point(388, 342)
			Me.O0o.o.().Name = "OnlySelected"
			Me.O0o.o.().Size = New Size(72, 16)
			Me.O0o.o.().TabIndex = 6
			Me.O0o.o.().Text = "仅选定行"
			Me.O0o.o.().UseVisualStyleBackColor = True
			Me.o_o_O0_.O.().AutoSize = True
			Me.o_o_O0_.O.().Checked = True
			Me.o_o_O0_.O.().CheckState = CheckState.Checked
			Me.o_o_O0_.O.().Location = New Point(388, 321)
			Me.o_o_O0_.O.().Name = "IncludeFixed"
			Me.o_o_O0_.O.().Size = New Size(72, 16)
			Me.o_o_O0_.O.().TabIndex = 5
			Me.o_o_O0_.O.().Text = "含标题行"
			Me.o_o_O0_.O.().UseVisualStyleBackColor = True
			Me.Oo_.Oo0.().AutoSize = True
			Me.Oo_.Oo0.().Location = New Point(14, 364)
			Me.Oo_.Oo0.().Name = "Custom"
			Me.Oo_.Oo0.().Size = New Size(107, 16)
			Me.Oo_.Oo0.().TabIndex = 3
			Me.Oo_.Oo0.().TabStop = True
			Me.Oo_.Oo0.().Text = "自定义列分隔符"
			Me.Oo_.Oo0.().UseVisualStyleBackColor = True
			Me.O0o.o.().AcceptsReturn = True
			Me.O0o.o.().Location = New Point(127, 359)
			Me.O0o.o.().Name = "txtSeparator"
			Me.O0o.o.().[ReadOnly] = True
			Me.O0o.o.().Size = New Size(100, 21)
			Me.O0o.o.().TabIndex = 4
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(495, 443)
			MyBase.Controls.Add(Me.O0o.o.())
			MyBase.Controls.Add(Me.Oo_.Oo0.())
			MyBase.Controls.Add(Me.o_o_O0_.O.())
			MyBase.Controls.Add(Me.O0o.o.())
			MyBase.Controls.Add(Me.Oo_.Oo0.())
			MyBase.Controls.Add(Me.O00_0.0o00_.())
			MyBase.Controls.Add(Me.O0o.o.())
			MyBase.Controls.Add(Me.O0o.o.())
			MyBase.Controls.Add(Me.O00_0.0o00_.())
			MyBase.Controls.Add(Me.oo_0O.O0oo_o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.O....O"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "导出"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003065 RID: 12389 RVA: 0x001393E3 File Offset: 0x001375E3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x06003066 RID: 12390 RVA: 0x001393EB File Offset: 0x001375EB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o0oO.o0_0. = A_0
		End Sub

		' Token: 0x06003067 RID: 12391 RVA: 0x001393F4 File Offset: 0x001375F4
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_0O.oO_0O_oOO.
		End Function

		' Token: 0x06003068 RID: 12392 RVA: 0x001393FC File Offset: 0x001375FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O_0O.oO_0O_oOO. = A_0
		End Sub

		' Token: 0x06003069 RID: 12393 RVA: 0x00139405 File Offset: 0x00137605
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x0600306A RID: 12394 RVA: 0x00139410 File Offset: 0x00137610
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.O0o.o.
			Dim checkedListBox As CheckedListBox = Me.o0oO.o0_0.
			If checkedListBox IsNot Nothing Then
				RemoveHandler checkedListBox.ItemCheck, value
			End If
			Me.o0oO.o0_0. = A_0
			checkedListBox = Me.o0oO.o0_0.
			If checkedListBox IsNot Nothing Then
				AddHandler checkedListBox.ItemCheck, value
			End If
		End Sub

		' Token: 0x0600306B RID: 12395 RVA: 0x00139453 File Offset: 0x00137653
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Label
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x0600306C RID: 12396 RVA: 0x0013945B File Offset: 0x0013765B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Label)
			Me.o0oO.o0_0. = A_0
		End Sub

		' Token: 0x0600306D RID: 12397 RVA: 0x00139464 File Offset: 0x00137664
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00_O.O0.
		End Function

		' Token: 0x0600306E RID: 12398 RVA: 0x0013946C File Offset: 0x0013766C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo_.Oo0.
			Dim o00_O.O0. As C1Button = Me.O00_O.O0.
			If o00_O.O0. IsNot Nothing Then
				RemoveHandler o00_O.O0..Click, value
			End If
			Me.O00_O.O0. = A_0
			o00_O.O0. = Me.O00_O.O0.
			If o00_O.O0. IsNot Nothing Then
				AddHandler o00_O.O0..Click, value
			End If
		End Sub

		' Token: 0x0600306F RID: 12399 RVA: 0x001394AF File Offset: 0x001376AF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_0O.oO_0O_oOO.
		End Function

		' Token: 0x06003070 RID: 12400 RVA: 0x001394B7 File Offset: 0x001376B7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O_0O.oO_0O_oOO. = A_0
		End Sub

		' Token: 0x06003071 RID: 12401 RVA: 0x001394C0 File Offset: 0x001376C0
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As SaveFileDialog
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x06003072 RID: 12402 RVA: 0x001394C8 File Offset: 0x001376C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SaveFileDialog)
			Me.o0oO.o0_0. = A_0
		End Sub

		' Token: 0x06003073 RID: 12403 RVA: 0x001394D1 File Offset: 0x001376D1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x06003074 RID: 12404 RVA: 0x001394D9 File Offset: 0x001376D9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0oO.o0_0. = A_0
		End Sub

		' Token: 0x06003075 RID: 12405 RVA: 0x001394E2 File Offset: 0x001376E2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_0O.oO_0O_oOO.
		End Function

		' Token: 0x06003076 RID: 12406 RVA: 0x001394EA File Offset: 0x001376EA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O_0O.oO_0O_oOO. = A_0
		End Sub

		' Token: 0x06003077 RID: 12407 RVA: 0x001394F3 File Offset: 0x001376F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O.0___o0oO0.
		End Function

		' Token: 0x06003078 RID: 12408 RVA: 0x001394FC File Offset: 0x001376FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.O00_0.0o00_.
			Dim o.0___o0oO0. As RadioButton = Me.O.0___o0oO0.
			If o.0___o0oO0. IsNot Nothing Then
				RemoveHandler o.0___o0oO0..CheckedChanged, value
			End If
			Me.O.0___o0oO0. = A_0
			o.0___o0oO0. = Me.O.0___o0oO0.
			If o.0___o0oO0. IsNot Nothing Then
				AddHandler o.0___o0oO0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06003079 RID: 12409 RVA: 0x0013953F File Offset: 0x0013773F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0oO.o0_0.
		End Function

		' Token: 0x0600307A RID: 12410 RVA: 0x00139547 File Offset: 0x00137747
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o0oO.o0_0. = A_0
		End Sub

		' Token: 0x0600307B RID: 12411 RVA: 0x00139550 File Offset: 0x00137750
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oo.00O_O0.
			AddHandler MyBase.FormClosed, AddressOf Me.O00_0.0o00_.
			Me.O0o.o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600307C RID: 12412 RVA: 0x001395A4 File Offset: 0x001377A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim table As Table = OO_00oOO.CurrentTable
			Me.O0o.o.().Items.Add("全选", True)
			Dim fixed As Integer = table.foxGrid.Cols.Fixed
			Dim num As Integer = table.foxGrid.Cols.Count - 1
			For i As Integer = fixed To num
				Me.O0o.o.().Items.Add(table.foxGrid.Cols(i).Name, True)
			Next
		End Sub

		' Token: 0x0600307D RID: 12413 RVA: 0x00139624 File Offset: 0x00137824
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			If Me.O0o.o.().GetItemRectangle(A_1.Index).Contains(Me.O0o.o.().PointToClient(Control.MousePosition)) AndAlso A_1.Index = 0 Then
				Dim value As Boolean = A_1.NewValue = CheckState.Checked
				Dim num As Integer = Me.O0o.o.().Items.Count - 1
				For i As Integer = 1 To num
					Me.O0o.o.().SetItemChecked(i, value)
				Next
			End If
		End Sub

		' Token: 0x0600307E RID: 12414 RVA: 0x0013969C File Offset: 0x0013789C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim list As List(Of String) = New List(Of String)()
			OO_00oOO.CurrentTable.DataTable.BaseTable
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim value As Char
			If Me.oo_0O.O0oo_o.().Checked Then
				value = vbTab
			ElseIf Me.O00_0.0o00_.().Checked Then
				value = ","c
			Else
				If Operators.CompareString(Me.O0o.o.().Text, "", True) = 0 Then
					MessageBox.Show("请输入列分隔符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				value = Me.O0o.o.().Text.ToCharArray()(0)
			End If
			Me.Cursor = Cursors.WaitCursor
			Foxtable.RibbonMenu.StatusBar.Message1 = "正在导出..."
			Application.DoEvents()
			Dim num As Integer = Me.O0o.o.().Items.Count - 1
			For i As Integer = 1 To num
				If Me.O0o.o.().GetItemChecked(i) Then
					list.Add(Me.O0o.o.().Items(i).ToString())
				End If
			Next
			If Me.o_o_O0_.O.().Checked Then
				Dim num2 As Integer = list.Count - 1
				For j As Integer = 0 To num2
					stringBuilder.Append(list(j))
					If j < list.Count - 1 Then
						stringBuilder.Append(value)
					End If
				Next
			End If
			Dim num3 As Integer = OO_00oOO.CurrentTable.foxGrid.Rows.Fixed
			Dim num4 As Integer = OO_00oOO.CurrentTable.foxGrid.Rows.Count - 1
			If Me.O0o.o.().Checked Then
				num3 = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow
				num4 = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow
			End If
			Dim num5 As Integer = num3
			Dim num6 As Integer = num4
			For k As Integer = num5 To num6
				If OO_00oOO.CurrentTable.foxGrid.Rows(k).DataIndex >= 0 Then
					Dim dataRowView As DataRowView = OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(OO_00oOO.CurrentTable.foxGrid.Rows(k).DataIndex)
					If stringBuilder.Length > 0 Then
						stringBuilder.Append(vbCrLf)
					End If
					Dim num7 As Integer = list.Count - 1
					For l As Integer = 0 To num7
						If Not dataRowView.Row.IsNull(list(l)) Then
							Dim text As String = ""
							If OO_00oOO.CurrentTable.Cols.Contains(list(l)) Then
								text = OO_00oOO.CurrentTable.foxGrid.Cols(list(l)).Format
							End If
							If Operators.CompareString(text, "", True) > 0 Then
								stringBuilder.Append(Strings.Format(RuntimeHelpers.GetObjectValue(dataRowView(list(l))), text))
							Else
								stringBuilder.Append(dataRowView(list(l)).ToString())
							End If
						End If
						If l < list.Count - 1 Then
							stringBuilder.Append(value)
						End If
					Next
				End If
			Next
			c.OOOOO.o.().FileSystem.WriteAllText(Me.o0_0.0OOO_0Oo., stringBuilder.ToString(), False)
			Me.Cursor = Cursors.[Default]
			Foxtable.RibbonMenu.StatusBar.Message1 = ""
		End Sub

		' Token: 0x0600307F RID: 12415 RVA: 0x001399D9 File Offset: 0x00137BD9
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0o.o.().[ReadOnly] = Not Me.Oo_.Oo0.().Checked
		End Sub

		' Token: 0x06003080 RID: 12416 RVA: 0x001399F4 File Offset: 0x00137BF4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400136A RID: 4970
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400136B RID: 4971
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400136C RID: 4972
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400136D RID: 4973
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x0400136E RID: 4974
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Label

		' Token: 0x0400136F RID: 4975
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001370 RID: 4976
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001371 RID: 4977
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SaveFileDialog

		' Token: 0x04001372 RID: 4978
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001373 RID: 4979
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001374 RID: 4980
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001375 RID: 4981
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001376 RID: 4982
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
