Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200035F RID: 863
	<DesignerGenerated()>
	Friend Partial Class O\u3000_\u3000
		Inherits Form

		' Token: 0x060035E1 RID: 13793 RVA: 0x0016BD08 File Offset: 0x00169F08
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_0.ooO0O. IsNot Nothing Then
					Me.O_0.ooO0O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060035E2 RID: 13794 RVA: 0x0016BD48 File Offset: 0x00169F48
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Ooo0.O.(New CheckedListBox())
			Me.o_00oo00.O00.(New Label())
			Me.Ooo0.O.(New C1CheckBox())
			Me.Ooo0.O.(New C1Button())
			Me.Oo0o0OO.00OO0.(New C1Button())
			Me.o._0o.(New Label())
			Me.o_00oo00.O00.(New RadioButton())
			Me.Ooo0.O.(New RadioButton())
			Me.o._0o.(New C1TextBox())
			Me.O0oO._Ooo_.().BeginInit()
			Me.O0oO._Ooo_.().BeginInit()
			Me.o0.0_O.().BeginInit()
			Me.Ooo0.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0oO._Ooo_.().CheckOnClick = True
			Me.O0oO._Ooo_.().FormattingEnabled = True
			Me.O0oO._Ooo_.().Location = New Point(16, 102)
			Me.O0oO._Ooo_.().Margin = New Padding(4, 4, 4, 4)
			Me.O0oO._Ooo_.().Name = "CheckedListBox1"
			Me.O0oO._Ooo_.().Size = New Size(416, 224)
			Me.O0oO._Ooo_.().TabIndex = 4
			Me.Ooo0.O.().AutoSize = True
			Me.Ooo0.O.().Location = New Point(16, 75)
			Me.Ooo0.O.().Margin = New Padding(4, 0, 4, 0)
			Me.Ooo0.O.().Name = "Label1"
			Me.Ooo0.O.().Size = New Size(180, 15)
			Me.Ooo0.O.().TabIndex = 3
			Me.Ooo0.O.().Text = "根据以下列内容调整高度:"
			Me.O0oO._Ooo_.().AutoSize = True
			Me.O0oO._Ooo_.().BorderStyle = BorderStyle.None
			Me.O0oO._Ooo_.().Checked = True
			Me.O0oO._Ooo_.().CheckState = CheckState.Checked
			Me.O0oO._Ooo_.().Location = New Point(16, 335)
			Me.O0oO._Ooo_.().Margin = New Padding(4, 4, 4, 4)
			Me.O0oO._Ooo_.().Name = "chkSameHeight"
			Me.O0oO._Ooo_.().Size = New Size(89, 19)
			Me.O0oO._Ooo_.().TabIndex = 5
			Me.O0oO._Ooo_.().Text = "相等行高"
			Me.O0oO._Ooo_.().UseVisualStyleBackColor = True
			Me.O0oO._Ooo_.().Value = True
			Me.O0oO._Ooo_.().DialogResult = DialogResult.OK
			Me.O0oO._Ooo_.().Location = New Point(121, 400)
			Me.O0oO._Ooo_.().Margin = New Padding(4, 4, 4, 4)
			Me.O0oO._Ooo_.().Name = "btnOK"
			Me.O0oO._Ooo_.().Size = New Size(100, 29)
			Me.O0oO._Ooo_.().TabIndex = 7
			Me.O0oO._Ooo_.().Text = "确定"
			Me.O0oO._Ooo_.().UseVisualStyleBackColor = True
			Me.o0.0_O.().DialogResult = DialogResult.Cancel
			Me.o0.0_O.().Location = New Point(229, 400)
			Me.o0.0_O.().Margin = New Padding(4, 4, 4, 4)
			Me.o0.0_O.().Name = "Button2"
			Me.o0.0_O.().Size = New Size(100, 29)
			Me.o0.0_O.().TabIndex = 8
			Me.o0.0_O.().Text = "取消"
			Me.o0.0_O.().UseVisualStyleBackColor = True
			Me.Oo0o0OO.00OO0.().AutoSize = True
			Me.Oo0o0OO.00OO0.().Location = New Point(16, 359)
			Me.Oo0o0OO.00OO0.().Margin = New Padding(4, 0, 4, 0)
			Me.Oo0o0OO.00OO0.().Name = "Label2"
			Me.Oo0o0OO.00OO0.().Size = New Size(397, 15)
			Me.Oo0o0OO.00OO0.().TabIndex = 6
			Me.Oo0o0OO.00OO0.().Text = "提示：如果未选择特定列，将根据所有列的内容调整行高。"
			Me.Ooo0.O.().AutoSize = True
			Me.Ooo0.O.().Checked = True
			Me.Ooo0.O.().Location = New Point(16, 18)
			Me.Ooo0.O.().Margin = New Padding(4, 4, 4, 4)
			Me.Ooo0.O.().Name = "EnterRowHeight"
			Me.Ooo0.O.().Size = New Size(88, 19)
			Me.Ooo0.O.().TabIndex = 0
			Me.Ooo0.O.().TabStop = True
			Me.Ooo0.O.().Text = "指定行高"
			Me.Ooo0.O.().UseVisualStyleBackColor = True
			Me.o0.0_O.().AutoSize = True
			Me.o0.0_O.().Location = New Point(16, 49)
			Me.o0.0_O.().Margin = New Padding(4, 4, 4, 4)
			Me.o0.0_O.().Name = "AutoRowHeight"
			Me.o0.0_O.().Size = New Size(118, 19)
			Me.o0.0_O.().TabIndex = 2
			Me.o0.0_O.().Text = "自动调整行高"
			Me.o0.0_O.().UseVisualStyleBackColor = True
			Me.Ooo0.O.().DataType = GetType(Integer)
			Me.Ooo0.O.().Location = New Point(121, 15)
			Me.Ooo0.O.().Margin = New Padding(4, 4, 4, 4)
			Me.Ooo0.O.().Name = "txtRowHeight"
			Me.Ooo0.O.().Size = New Size(133, 23)
			Me.Ooo0.O.().TabIndex = 1
			Me.Ooo0.O.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(8F, 15F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(451, 445)
			MyBase.Controls.Add(Me.Ooo0.O.())
			MyBase.Controls.Add(Me.o0.0_O.())
			MyBase.Controls.Add(Me.Ooo0.O.())
			MyBase.Controls.Add(Me.Oo0o0OO.00OO0.())
			MyBase.Controls.Add(Me.o0.0_O.())
			MyBase.Controls.Add(Me.O0oO._Ooo_.())
			MyBase.Controls.Add(Me.O0oO._Ooo_.())
			MyBase.Controls.Add(Me.Ooo0.O.())
			MyBase.Controls.Add(Me.O0oO._Ooo_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Oll.lo.1."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "行高"
			Me.O0oO._Ooo_.().EndInit()
			Me.O0oO._Ooo_.().EndInit()
			Me.o0.0_O.().EndInit()
			Me.Ooo0.O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060035E3 RID: 13795 RVA: 0x0016C3F1 File Offset: 0x0016A5F1
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.o._0o.
		End Function

		' Token: 0x060035E4 RID: 13796 RVA: 0x0016C3FC File Offset: 0x0016A5FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.O0oO._Ooo_.
			Dim checkedListBox As CheckedListBox = Me.o._0o.
			If checkedListBox IsNot Nothing Then
				RemoveHandler checkedListBox.ItemCheck, value
			End If
			Me.o._0o. = A_0
			checkedListBox = Me.o._0o.
			If checkedListBox IsNot Nothing Then
				AddHandler checkedListBox.ItemCheck, value
			End If
		End Sub

		' Token: 0x060035E5 RID: 13797 RVA: 0x0016C43F File Offset: 0x0016A63F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_0.ooO0O.
		End Function

		' Token: 0x060035E6 RID: 13798 RVA: 0x0016C447 File Offset: 0x0016A647
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_0.ooO0O. = A_0
		End Sub

		' Token: 0x060035E7 RID: 13799 RVA: 0x0016C450 File Offset: 0x0016A650
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o._0o.
		End Function

		' Token: 0x060035E8 RID: 13800 RVA: 0x0016C458 File Offset: 0x0016A658
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o._0o. = A_0
		End Sub

		' Token: 0x060035E9 RID: 13801 RVA: 0x0016C461 File Offset: 0x0016A661
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._0o.
		End Function

		' Token: 0x060035EA RID: 13802 RVA: 0x0016C46C File Offset: 0x0016A66C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0oO._Ooo_.
			Dim c1Button As C1Button = Me.o._0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o._0o. = A_0
			c1Button = Me.o._0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060035EB RID: 13803 RVA: 0x0016C4AF File Offset: 0x0016A6AF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_00oo00.O00.
		End Function

		' Token: 0x060035EC RID: 13804 RVA: 0x0016C4B7 File Offset: 0x0016A6B7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_00oo00.O00. = A_0
		End Sub

		' Token: 0x060035ED RID: 13805 RVA: 0x0016C4C0 File Offset: 0x0016A6C0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_o00.o0O0o.
		End Function

		' Token: 0x060035EE RID: 13806 RVA: 0x0016C4C8 File Offset: 0x0016A6C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_o00.o0O0o. = A_0
		End Sub

		' Token: 0x060035EF RID: 13807 RVA: 0x0016C4D1 File Offset: 0x0016A6D1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o._0o.
		End Function

		' Token: 0x060035F0 RID: 13808 RVA: 0x0016C4D9 File Offset: 0x0016A6D9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o._0o. = A_0
		End Sub

		' Token: 0x060035F1 RID: 13809 RVA: 0x0016C4E2 File Offset: 0x0016A6E2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o_00oo00.O00.
		End Function

		' Token: 0x060035F2 RID: 13810 RVA: 0x0016C4EA File Offset: 0x0016A6EA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o_00oo00.O00. = A_0
		End Sub

		' Token: 0x060035F3 RID: 13811 RVA: 0x0016C4F3 File Offset: 0x0016A6F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_0.ooO0O.
		End Function

		' Token: 0x060035F4 RID: 13812 RVA: 0x0016C4FB File Offset: 0x0016A6FB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_0.ooO0O. = A_0
		End Sub

		' Token: 0x060035F5 RID: 13813 RVA: 0x0016C504 File Offset: 0x0016A704
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim fixed As Integer = Me.O_0.ooO0O..Cols.Fixed
			Dim num As Integer = Me.O_0.ooO0O..Cols.Count - 1
			For i As Integer = fixed To num
				Me.O0oO._Ooo_.().Items.Add(Me.O_0.ooO0O..Cols(i).Name)
			Next
			Me.Ooo0.O.().Value = Me.O_0.ooO0O..Rows.DefaultSize.ToString()
		End Sub

		' Token: 0x060035F6 RID: 13814 RVA: 0x0016C58C File Offset: 0x0016A78C
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.o0.0_O.
			AddHandler MyBase.FormClosed, AddressOf Me.O0oO._Ooo_.
			Me.Ooo0.O.()
			Me.O_0.ooO0O. = A_0
			Me.O_0.ooO0O. = A_0.foxGrid
			Me.O0oO._Ooo_.().Checked = Not A_0.AllowResizeSingleRow
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060035F7 RID: 13815 RVA: 0x0016C608 File Offset: 0x0016A808
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			If A_1.NewValue = CheckState.Checked Then
				Dim num As Integer = Me.O0oO._Ooo_.().Items.Count - 1
				For i As Integer = 0 To num
					If i <> A_1.Index Then
						Me.O0oO._Ooo_.().SetItemChecked(i, False)
					End If
				Next
			End If
		End Sub

		' Token: 0x060035F8 RID: 13816 RVA: 0x0016C654 File Offset: 0x0016A854
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.o0.0_O.().Checked Then
					GoTo IL_1D7
				End If
				IL_19:
				num2 = 3
				Dim num3 As Integer = Me.O0oO._Ooo_.().Items.Count - 1
				Dim index As Integer
				For i As Integer = 0 To num3
					IL_34:
					num2 = 4
					If Me.O0oO._Ooo_.().GetItemChecked(i) Then
						IL_45:
						num2 = 5
						index = Me.O_0.ooO0O..Cols(Me.O0oO._Ooo_.().Items(i).ToString()).Index
					End If
					IL_74:
					num2 = 6
				Next
				IL_82:
				num2 = 7
				Dim c1FlexGrid As C1FlexGrid = Me.O_0.ooO0O.
				IL_8C:
				num2 = 8
				c1FlexGrid.BeginUpdate()
				IL_95:
				num2 = 9
				c1FlexGrid.Rows.DefaultSize = c1FlexGrid.Font.Height + 4
				IL_B2:
				num2 = 10
				If index <= 0 Then
					GoTo IL_12B
				End If
				IL_B9:
				num2 = 11
				If Not Me.O0oO._Ooo_.().Checked Then
					GoTo IL_FA
				End If
				IL_C9:
				num2 = 12
				Me.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, index, c1FlexGrid.Rows.Count - 1, index, 2, 7)
				GoTo IL_1C5
				IL_FA:
				num2 = 14
				Me.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, index, c1FlexGrid.Rows.Count - 1, index, 2, 6)
				GoTo IL_1C5
				IL_12B:
				num2 = 16
				If Not Me.O0oO._Ooo_.().Checked Then
					GoTo IL_181
				End If
				IL_13B:
				num2 = 17
				Me.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, c1FlexGrid.Cols.Fixed, c1FlexGrid.Rows.Count - 1, c1FlexGrid.Cols.Count - 1, 2, 7)
				GoTo IL_1C5
				IL_181:
				num2 = 19
				Me.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, c1FlexGrid.Cols.Fixed, c1FlexGrid.Rows.Count - 1, c1FlexGrid.Cols.Count - 1, 2, 6)
				IL_1C5:
				num2 = 20
				c1FlexGrid.EndUpdate()
				IL_1CF:
				c1FlexGrid = Nothing
				GoTo IL_34E
				IL_1D7:
				num2 = 23
				If CInt(Math.Round(Conversion.Val(Me.Ooo0.O.().Text))) <= 0 Then
					GoTo IL_34E
				End If
				IL_1F6:
				num2 = 24
				If Me.O_0.ooO0O..Rows.Fixed >= Me.O_0.ooO0O..Rows.Count Then
					GoTo IL_26E
				End If
				IL_21B:
				num2 = 25
				Me.O_0.ooO0O..O_o0OOo_.o0..O__00.__0_O.(New o_o0_(Me.O_0.ooO0O., Me.O_0.ooO0O..Rows.Fixed, Me.O_0.ooO0O..Rows(Me.O_0.ooO0O..Rows.Fixed).Height))
				IL_26E:
				num2 = 26
				Dim c1FlexGrid2 As C1FlexGrid = Me.O_0.ooO0O.
				IL_279:
				num2 = 27
				c1FlexGrid2.BeginUpdate()
				IL_283:
				num2 = 28
				Dim num4 As Integer = c1FlexGrid2.Rows.Fixed - 1
				For j As Integer = 0 To num4
					IL_29B:
					num2 = 29
					c1FlexGrid2.Rows(j).Height = c1FlexGrid2.Rows(j).HeightDisplay
					IL_2C4:
					num2 = 30
				Next
				IL_2D3:
				num2 = 31
				c1FlexGrid2.Rows.DefaultSize = CInt(Math.Round(Conversion.Val(Me.Ooo0.O.().Text)))
				IL_2F8:
				num2 = 32
				Dim fixed As Integer = c1FlexGrid2.Rows.Fixed
				Dim num5 As Integer = c1FlexGrid2.Rows.Count - 1
				For k As Integer = fixed To num5
					IL_31B:
					num2 = 33
					c1FlexGrid2.Rows(k).Height = -1
					IL_332:
					num2 = 34
				Next
				IL_341:
				num2 = 35
				c1FlexGrid2.EndUpdate()
				IL_34B:
				c1FlexGrid2 = Nothing
				IL_34E:
				GoTo IL_434
				IL_353:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_3F5:
				GoTo IL_429
				IL_3F7:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_407:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3F7
			End Try
			IL_429:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_434:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060035F9 RID: 13817 RVA: 0x0016CABC File Offset: 0x0016ACBC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001625 RID: 5669
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001626 RID: 5670
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001627 RID: 5671
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001628 RID: 5672
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001629 RID: 5673
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400162A RID: 5674
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400162B RID: 5675
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400162C RID: 5676
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400162D RID: 5677
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400162E RID: 5678
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400162F RID: 5679
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001630 RID: 5680
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
