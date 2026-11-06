Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000338 RID: 824
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3000\u3002\u3002\u3000\u3000_
		Inherits Form

		' Token: 0x0600315F RID: 12639 RVA: 0x001409B8 File Offset: 0x0013EBB8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O__.__O_. IsNot Nothing Then
					Me.O__.__O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003160 RID: 12640 RVA: 0x001409F8 File Offset: 0x0013EBF8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_OoOo00o0.ooO.(New C1CheckBox())
			Me.oO_O._.(New C1CheckBox())
			Me.oO_O0.0o.(New C1CheckBox())
			Me.oO_O0.0o.(New GroupBox())
			Me.O._oO__OOOO.(New C1CheckBox())
			Me.oO_O0.0o.(New C1Button())
			Me.O._oO__OOOO.(New C1Button())
			Me.o_O0Ooo0O_.O.(New Label())
			Me.o_O0Ooo0O_.O.(New C1TextBox())
			Me.o__o.OOo0oO.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.o__o.OOo0oO.().AutoSize = True
			Me.o__o.OOo0oO.().Checked = True
			Me.o__o.OOo0oO.().CheckState = CheckState.Checked
			Me.o__o.OOo0oO.().Location = New Point(13, 42)
			Me.o__o.OOo0oO.().Name = "chkVisibleOnly"
			Me.o__o.OOo0oO.().Size = New Size(72, 16)
			Me.o__o.OOo0oO.().TabIndex = 1
			Me.o__o.OOo0oO.().Text = "仅可见列"
			Me.o__o.OOo0oO.().UseVisualStyleBackColor = True
			Me.Oo_O.oO_0.().AutoSize = True
			Me.Oo_O.oO_0.().Location = New Point(13, 65)
			Me.Oo_O.oO_0.().Name = "chkSaveMergedRanges"
			Me.Oo_O.oO_0.().Size = New Size(96, 16)
			Me.Oo_O.oO_0.().TabIndex = 3
			Me.Oo_O.oO_0.().Text = "保存合并设置"
			Me.Oo_O.oO_0.().UseVisualStyleBackColor = True
			Me.OOO.oO.().AutoSize = True
			Me.OOO.oO.().Location = New Point(13, 88)
			Me.OOO.oO.().Name = "chkAsDisplayed"
			Me.OOO.oO.().Size = New Size(96, 16)
			Me.OOO.oO.().TabIndex = 4
			Me.OOO.oO.().Text = "保存格式设置"
			Me.OOO.oO.().UseVisualStyleBackColor = True
			Me.o__o.OOo0oO.().Controls.Add(Me.O0O0OOo_o0.o00.())
			Me.o__o.OOo0oO.().Controls.Add(Me.OOO.oO.())
			Me.o__o.OOo0oO.().Controls.Add(Me.o__o.OOo0oO.())
			Me.o__o.OOo0oO.().Controls.Add(Me.Oo_O.oO_0.())
			Me.o__o.OOo0oO.().Location = New Point(10, 12)
			Me.o__o.OOo0oO.().Name = "GroupBox1"
			Me.o__o.OOo0oO.().Size = New Size(186, 123)
			Me.o__o.OOo0oO.().TabIndex = 5
			Me.o__o.OOo0oO.().TabStop = False
			Me.o__o.OOo0oO.().Text = "选项"
			Me.O0O0OOo_o0.o00.().AutoSize = True
			Me.O0O0OOo_o0.o00.().Location = New Point(13, 19)
			Me.O0O0OOo_o0.o00.().Name = "chkIncludeRowNumber"
			Me.O0O0OOo_o0.o00.().Size = New Size(84, 16)
			Me.O0O0OOo_o0.o00.().TabIndex = 5
			Me.O0O0OOo_o0.o00.().Text = "包括行号列"
			Me.O0O0OOo_o0.o00.().UseVisualStyleBackColor = True
			Me.OOO.oO.().Location = New Point(23, 212)
			Me.OOO.oO.().Name = "Button1"
			Me.OOO.oO.().Size = New Size(75, 23)
			Me.OOO.oO.().TabIndex = 6
			Me.OOO.oO.().Text = "确定"
			Me.OOO.oO.().UseVisualStyleBackColor = True
			Me.o__o.OOo0oO.().DialogResult = DialogResult.Cancel
			Me.o__o.OOo0oO.().Location = New Point(104, 212)
			Me.o__o.OOo0oO.().Name = "Button2"
			Me.o__o.OOo0oO.().Size = New Size(75, 23)
			Me.o__o.OOo0oO.().TabIndex = 7
			Me.o__o.OOo0oO.().Text = "取消"
			Me.o__o.OOo0oO.().UseVisualStyleBackColor = True
			Me.oO_O0.0o.().AutoSize = True
			Me.oO_O0.0o.().Location = New Point(8, 152)
			Me.oO_O0.0o.().Name = "Label1"
			Me.oO_O0.0o.().Size = New Size(59, 12)
			Me.oO_O0.0o.().TabIndex = 8
			Me.oO_O0.0o.().Text = "目标表名:"
			Me.oO_O0.0o.().Location = New Point(11, 171)
			Me.oO_O0.0o.().Name = "txtName"
			Me.oO_O0.0o.().Size = New Size(181, 21)
			Me.oO_O0.0o.().TabIndex = 9
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(212, 255)
			MyBase.Controls.Add(Me.oO_O0.0o.())
			MyBase.Controls.Add(Me.oO_O0.0o.())
			MyBase.Controls.Add(Me.o__o.OOo0oO.())
			MyBase.Controls.Add(Me.OOO.oO.())
			MyBase.Controls.Add(Me.o__o.OOo0oO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o....o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "导出Excel"
			Me.o__o.OOo0oO.().ResumeLayout(False)
			Me.o__o.OOo0oO.().PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003161 RID: 12641 RVA: 0x00140F65 File Offset: 0x0013F165
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_O0Ooo0O_.O.
		End Function

		' Token: 0x06003162 RID: 12642 RVA: 0x00140F6D File Offset: 0x0013F16D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o_O0Ooo0O_.O. = A_0
		End Sub

		' Token: 0x06003163 RID: 12643 RVA: 0x00140F76 File Offset: 0x0013F176
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.OO.0o0.
		End Function

		' Token: 0x06003164 RID: 12644 RVA: 0x00140F7E File Offset: 0x0013F17E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.OO.0o0. = A_0
		End Sub

		' Token: 0x06003165 RID: 12645 RVA: 0x00140F87 File Offset: 0x0013F187
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oO00o._.
		End Function

		' Token: 0x06003166 RID: 12646 RVA: 0x00140F8F File Offset: 0x0013F18F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oO00o._. = A_0
		End Sub

		' Token: 0x06003167 RID: 12647 RVA: 0x00140F98 File Offset: 0x0013F198
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As GroupBox
			Return Me.o_O0Ooo0O_.O.
		End Function

		' Token: 0x06003168 RID: 12648 RVA: 0x00140FA0 File Offset: 0x0013F1A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.o_O0Ooo0O_.O. = A_0
		End Sub

		' Token: 0x06003169 RID: 12649 RVA: 0x00140FA9 File Offset: 0x0013F1A9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_O0Ooo0O_.O.
		End Function

		' Token: 0x0600316A RID: 12650 RVA: 0x00140FB4 File Offset: 0x0013F1B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__o.OOo0oO.
			Dim c1Button As C1Button = Me.o_O0Ooo0O_.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_O0Ooo0O_.O. = A_0
			c1Button = Me.o_O0Ooo0O_.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600316B RID: 12651 RVA: 0x00140FF7 File Offset: 0x0013F1F7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO.0o0.
		End Function

		' Token: 0x0600316C RID: 12652 RVA: 0x00140FFF File Offset: 0x0013F1FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OO.0o0. = A_0
		End Sub

		' Token: 0x0600316D RID: 12653 RVA: 0x00141008 File Offset: 0x0013F208
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_O0Ooo0O_.O.
		End Function

		' Token: 0x0600316E RID: 12654 RVA: 0x00141010 File Offset: 0x0013F210
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_O0Ooo0O_.O. = A_0
		End Sub

		' Token: 0x0600316F RID: 12655 RVA: 0x00141019 File Offset: 0x0013F219
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O__.__O_.
		End Function

		' Token: 0x06003170 RID: 12656 RVA: 0x00141021 File Offset: 0x0013F221
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O__.__O_. = A_0
		End Sub

		' Token: 0x06003171 RID: 12657 RVA: 0x0014102A File Offset: 0x0013F22A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.ooO.oOo.
		End Function

		' Token: 0x06003172 RID: 12658 RVA: 0x00141032 File Offset: 0x0013F232
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.ooO.oOo. = A_0
		End Sub

		' Token: 0x06003173 RID: 12659 RVA: 0x0014103C File Offset: 0x0013F23C
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.o__o.OOo0oO.
			Me.oO_O0.0o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.O__.__O_. = A_0
			Me.oO_O0.0o.().Value = OO_00oOO.CurrentTable.DataTable.BaseTable.TableName
		End Sub

		' Token: 0x06003174 RID: 12660 RVA: 0x001410A4 File Offset: 0x0013F2A4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim saveExcelFlags As SaveExcelFlags = New SaveExcelFlags()
			saveExcelFlags.CellStyle = Me.OOO.oO.().Checked
			saveExcelFlags.MergedRanges = Me.Oo_O.oO_0.().Checked
			saveExcelFlags.VisibleOnly = Me.o__o.OOo0oO.().Checked
			saveExcelFlags.RowNumber = Me.O0O0OOo_o0.o00.().Checked
			OO_00oOO.CurrentTable.SaveExcel(Me.O__.__O_., Me.oO_O0.0o.().Text, saveExcelFlags)
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06003175 RID: 12661 RVA: 0x0014111E File Offset: 0x0013F31E
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013D3 RID: 5075
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013D4 RID: 5076
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040013D5 RID: 5077
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040013D6 RID: 5078
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040013D7 RID: 5079
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x040013D8 RID: 5080
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013D9 RID: 5081
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013DA RID: 5082
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013DB RID: 5083
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040013DC RID: 5084
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040013DD RID: 5085
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
