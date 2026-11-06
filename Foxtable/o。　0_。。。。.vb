Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200037E RID: 894
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u30000_\u3002\u3002\u3002\u3002
		Inherits Form

		' Token: 0x0600390F RID: 14607 RVA: 0x0018A2DE File Offset: 0x001884DE
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.o_oOoOo_.O_o_O. IsNot Nothing Then
				Me.o_oOoOo_.O_o_O..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003910 RID: 14608 RVA: 0x0018A300 File Offset: 0x00188500
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(o\u3002\u30000_\u3002\u3002\u3002\u3002))
			Me.oO__.O.(New C1ComboBox())
			Me.OO._O_.(New C1Button())
			Me.o_Oo.O0o.(New C1Button())
			Me.oO__.O.(New C1Button())
			Me.O_o0OO_o_O.o.(New Label())
			Me.oOOo._O_o000oO.(New C1TextBox())
			Me.oO__.O.(New C1DockingTab())
			Me.oO_O0__0_00.00.(New C1DockingTabPage())
			Me.oO__.O.(New GroupBox())
			Me.OOoOOO.OOo.(New C1TextBox())
			Me.o_o._0_o0o_0__.(New Label())
			Me.o._o0_o_0O0_0O.(New Panel())
			Me.o._o0_o_0O0_0O.(New RadioButton())
			Me.o0OOo.0O0Oo.(New RadioButton())
			Me.OOoo_O_00oO0._.(New RadioButton())
			Me.OOoOOO.OOo.(New C1NumericEdit())
			Me.oO_O0__0_00.00.(New RadioButton())
			Me.oo_o_ooO0O.00.(New C1Button())
			Me.O_0o0._0oO_O0.(New RadioButton())
			Me.OOoo_O_00oO0._.(New C1TextBox())
			Me.oO_O0__0_00.00.(New Label())
			Me.o0oO.o0o.(New C1ComboBox())
			Me.oO__.O.(New Label())
			Me.o._o0_o_0O0_0O.(New C1DockingTabPage())
			Me.o0o.o_o.(New Label())
			Me.o0OOo.0O0Oo.(New C1TextBox())
			Me.o_0oO__0o0o.__.(New Label())
			Me.oo.OO.(New Label())
			Me.O0000_O.O.().BeginInit()
			Me.O0000_O.O.().SuspendLayout()
			Me.o00OO.0_00__0.().SuspendLayout()
			Me.o000O0o._O.().SuspendLayout()
			Me.O0OOOO.O0o0_.().SuspendLayout()
			Me.OOo.00_.().BeginInit()
			Me.O0OOOO.O0o0_.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.O_00__.oo.().DropDownStyle = 1
			Me.O_00__.oo.().Location = New Point(76, 56)
			Me.O_00__.oo.().Name = "cmbSourceTable"
			Me.O_00__.oo.().Size = New Size(356, 20)
			Me.O_00__.oo.().TabIndex = 1
			Me.oO.O00_O_0o_O.().Location = New Point(412, 482)
			Me.oO.O00_O_0o_O.().Name = "btnAccept"
			Me.oO.O00_O_0o_O.().Size = New Size(75, 23)
			Me.oO.O00_O_0o_O.().TabIndex = 2
			Me.oO.O00_O_0o_O.().Text = "确定"
			Me.oO.O00_O_0o_O.().UseVisualStyleBackColor = True
			Me.Oo.__0__0.().DialogResult = DialogResult.Cancel
			Me.Oo.__0__0.().Location = New Point(493, 482)
			Me.Oo.__0__0.().Name = "btnCancel"
			Me.Oo.__0__0.().Size = New Size(75, 23)
			Me.Oo.__0__0.().TabIndex = 3
			Me.Oo.__0__0.().Text = "取消"
			Me.Oo.__0__0.().UseVisualStyleBackColor = True
			Me.o.o0_0.().Location = New Point(22, 482)
			Me.o.o0_0.().Name = "btnPreview"
			Me.o.o0_0.().Size = New Size(75, 23)
			Me.o.o0_0.().TabIndex = 1
			Me.o.o0_0.().Text = "预览"
			Me.o.o0_0.().UseVisualStyleBackColor = True
			Me.O0_.0o0O.().AutoSize = True
			Me.O0_.0o0O.().Location = New Point(23, 30)
			Me.O0_.0o0O.().Name = "Label3"
			Me.O0_.0o0O.().Size = New Size(59, 12)
			Me.O0_.0o0O.().TabIndex = 0
			Me.O0_.0o0O.().Text = "过滤条件:"
			Me.OOo.00_.().Location = New Point(25, 51)
			Me.OOo.00_.().Multiline = True
			Me.OOo.00_.().Name = "txtFilter"
			Me.OOo.00_.().ScrollBars = ScrollBars.Vertical
			Me.OOo.00_.().Size = New Size(490, 168)
			Me.OOo.00_.().TabIndex = 1
			Me.O0000_O.O.().Controls.Add(Me.o00OO.0_00__0.())
			Me.O0000_O.O.().Controls.Add(Me.O0OOOO.O0o0_.())
			Me.O0000_O.O.().Location = New Point(22, 12)
			Me.O0000_O.O.().Name = "C1DockingTab1"
			Me.O0000_O.O.().Size = New Size(546, 455)
			Me.O0000_O.O.().TabIndex = 0
			Me.O0000_O.O.().TabsSpacing = 0
			Me.O0000_O.O.().TabStyle = 1
			Me.O0000_O.O.().VisualStyle = 13
			Me.O0000_O.O.().VisualStyleBase = 13
			Me.o00OO.0_00__0.().Controls.Add(Me.o000O0o._O.())
			Me.o00OO.0_00__0.().Controls.Add(Me.O_0oO.0.())
			Me.o00OO.0_00__0.().Controls.Add(Me.o000O0o._O.())
			Me.o00OO.0_00__0.().Controls.Add(Me.O00_OO_.00.())
			Me.o00OO.0_00__0.().Controls.Add(Me.O_00__.oo.())
			Me.o00OO.0_00__0.().Location = New Point(2, 26)
			Me.o00OO.0_00__0.().Name = "pageDataSource"
			Me.o00OO.0_00__0.().Size = New Size(540, 425)
			Me.o00OO.0_00__0.().TabIndex = 1
			Me.o00OO.0_00__0.().Text = "数据源"
			Me.o000O0o._O.().Controls.Add(Me.OO._O_.())
			Me.o000O0o._O.().Controls.Add(Me.o000O0o._O.())
			Me.o000O0o._O.().Controls.Add(Me.O0OOOO.O0o0_.())
			Me.o000O0o._O.().Controls.Add(Me.O0O0O.0_.())
			Me.o000O0o._O.().Controls.Add(Me.O0000_O.O.())
			Me.o000O0o._O.().Controls.Add(Me.o00OO.0_00__0.())
			Me.o000O0o._O.().Controls.Add(Me.o0_o_0O_0O_.o.())
			Me.o000O0o._O.().Location = New Point(25, 92)
			Me.o000O0o._O.().Name = "GroupBox1"
			Me.o000O0o._O.().Size = New Size(490, 317)
			Me.o000O0o._O.().TabIndex = 26
			Me.o000O0o._O.().TabStop = False
			Me.o000O0o._O.().Text = "选项"
			Me.OO._O_.().Location = New Point(324, 45)
			Me.OO._O_.().Name = "txtSEQUENCE"
			Me.OO._O_.().Size = New Size(137, 21)
			Me.OO._O_.().TabIndex = 39
			Me.o000O0o._O.().AutoSize = True
			Me.o000O0o._O.().Location = New Point(324, 24)
			Me.o000O0o._O.().Name = "Label1"
			Me.o000O0o._O.().Size = New Size(83, 12)
			Me.o000O0o._O.().TabIndex = 38
			Me.o000O0o._O.().Text = "主键序列名称:"
			Me.O0OOOO.O0o0_.().Controls.Add(Me.OO0.oO_o.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.O0OOOO.O0o0_.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.o0_o_0O_0O_.o.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.OOo.00_.())
			Me.O0OOOO.O0o0_.().Location = New Point(9, 24)
			Me.O0OOOO.O0o0_.().Name = "Panel1"
			Me.O0OOOO.O0o0_.().Size = New Size(290, 80)
			Me.O0OOOO.O0o0_.().TabIndex = 37
			Me.OO0.oO_o.().AutoSize = True
			Me.OO0.oO_o.().Location = New Point(17, 56)
			Me.OO0.oO_o.().Name = "rdoAllRows"
			Me.OO0.oO_o.().Size = New Size(83, 16)
			Me.OO0.oO_o.().TabIndex = 0
			Me.OO0.oO_o.().Text = "加载所有行"
			Me.OO0.oO_o.().UseVisualStyleBackColor = True
			Me.O0OOOO.O0o0_.().AutoSize = True
			Me.O0OOOO.O0o0_.().Location = New Point(17, 31)
			Me.O0OOOO.O0o0_.().Name = "rdoRowsPercent"
			Me.O0OOOO.O0o0_.().Size = New Size(113, 16)
			Me.O0OOOO.O0o0_.().TabIndex = 2
			Me.O0OOOO.O0o0_.().Text = "默认加载百分比:"
			Me.O0OOOO.O0o0_.().UseVisualStyleBackColor = True
			Me.o0_o_0O_0O_.o.().AutoSize = True
			Me.o0_o_0O_0O_.o.().Checked = True
			Me.o0_o_0O_0O_.o.().Location = New Point(17, 6)
			Me.o0_o_0O_0O_.o.().Name = "rdoRows"
			Me.o0_o_0O_0O_.o.().Size = New Size(101, 16)
			Me.o0_o_0O_0O_.o.().TabIndex = 1
			Me.o0_o_0O_0O_.o.().TabStop = True
			Me.o0_o_0O_0O_.o.().Text = "默认加载行数:"
			Me.o0_o_0O_0O_.o.().UseVisualStyleBackColor = True
			Me.OOo.00_.().DataType = GetType(Integer)
			Me.OOo.00_.().ErrorInfo.ShowErrorMessage = False
			Me.OOo.00_.().Location = New Point(158, 29)
			Me.OOo.00_.().Name = "txtTop"
			Me.OOo.00_.().PostValidation.Intervals.AddRange(New ValueInterval() { New ValueInterval(1L, RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("txtTop.PostValidation.Intervals")), True, True) })
			Me.OOo.00_.().Size = New Size(114, 21)
			Me.OOo.00_.().TabIndex = 0
			Me.OOo.00_.().Tag = Nothing
			Me.OOo.00_.().Value = 10
			Me.O0O0O.0_.().AutoSize = True
			Me.O0O0O.0_.().Checked = True
			Me.O0O0O.0_.().Location = New Point(28, 114)
			Me.O0O0O.0_.().Name = "rdoAllFields"
			Me.O0O0O.0_.().Size = New Size(83, 16)
			Me.O0O0O.0_.().TabIndex = 1
			Me.O0O0O.0_.().TabStop = True
			Me.O0O0O.0_.().Text = "包括所有列"
			Me.O0O0O.0_.().UseVisualStyleBackColor = True
			Me.O0000_O.O.().Enabled = False
			Me.O0000_O.O.().Location = New Point(386, 107)
			Me.O0000_O.O.().Name = "btnSelectColumns"
			Me.O0000_O.O.().Size = New Size(75, 23)
			Me.O0000_O.O.().TabIndex = 4
			Me.O0000_O.O.().Text = "选择列"
			Me.O0000_O.O.().UseVisualStyleBackColor = True
			Me.o00OO.0_00__0.().AutoSize = True
			Me.o00OO.0_00__0.().Location = New Point(122, 114)
			Me.o00OO.0_00__0.().Name = "rdoInclude"
			Me.o00OO.0_00__0.().Size = New Size(83, 16)
			Me.o00OO.0_00__0.().TabIndex = 2
			Me.o00OO.0_00__0.().Text = "包括以下列"
			Me.o00OO.0_00__0.().UseVisualStyleBackColor = True
			Me.o0_o_0O_0O_.o.().Location = New Point(26, 144)
			Me.o0_o_0O_0O_.o.().Multiline = True
			Me.o0_o_0O_0O_.o.().Name = "txtFields"
			Me.o0_o_0O_0O_.o.().[ReadOnly] = True
			Me.o0_o_0O_0O_.o.().ScrollBars = ScrollBars.Vertical
			Me.o0_o_0O_0O_.o.().Size = New Size(435, 149)
			Me.o0_o_0O_0O_.o.().TabIndex = 5
			Me.O_0oO.0.().AutoSize = True
			Me.O_0oO.0.().Location = New Point(23, 30)
			Me.O_0oO.0.().Name = "Label2"
			Me.O_0oO.0.().Size = New Size(47, 12)
			Me.O_0oO.0.().TabIndex = 2
			Me.O_0oO.0.().Text = "数据源:"
			Me.o000O0o._O.().DropDownStyle = 1
			Me.o000O0o._O.().Location = New Point(76, 27)
			Me.o000O0o._O.().Name = "cmbDataSource"
			Me.o000O0o._O.().Size = New Size(356, 20)
			Me.o000O0o._O.().TabIndex = 0
			Me.O00_OO_.00.().AutoSize = True
			Me.O00_OO_.00.().Location = New Point(23, 58)
			Me.O00_OO_.00.().Name = "Label10"
			Me.O00_OO_.00.().Size = New Size(47, 12)
			Me.O00_OO_.00.().TabIndex = 20
			Me.O00_OO_.00.().Text = "数据表:"
			Me.O0OOOO.O0o0_.().Controls.Add(Me.O__O.o.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.o_Oo.O0o.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.OO____O0.00.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.OOo.00_.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.O0_.0o0O.())
			Me.O0OOOO.O0o0_.().Controls.Add(Me.o00OO.0_00__0.())
			Me.O0OOOO.O0o0_.().Location = New Point(2, 26)
			Me.O0OOOO.O0o0_.().Name = "PageFilter"
			Me.O0OOOO.O0o0_.().Size = New Size(540, 425)
			Me.O0OOOO.O0o0_.().TabIndex = 0
			Me.O0OOOO.O0o0_.().Text = "过滤/排序"
			Me.O__O.o.().Location = New Point(22, 316)
			Me.O__O.o.().Name = "Label11"
			Me.O__O.o.().Size = New Size(493, 50)
			Me.O__O.o.().TabIndex = 4
			Me.O__O.o.().Text = "提示:直接输入排序的列名称，各列用逗号分割，如果降序排列，列名称后加上DESC，例如： OrderId DESC，表示根据OrderID降序排序"
			Me.o_Oo.O0o.().Location = New Point(25, 286)
			Me.o_Oo.O0o.().Name = "txtOrder"
			Me.o_Oo.O0o.().Size = New Size(490, 21)
			Me.o_Oo.O0o.().TabIndex = 3
			Me.OO____O0.00.().AutoSize = True
			Me.OO____O0.00.().Location = New Point(25, 229)
			Me.OO____O0.00.().Name = "Label12"
			Me.OO____O0.00.().Size = New Size(473, 12)
			Me.OO____O0.00.().TabIndex = 10
			Me.OO____O0.00.().Text = "提示：过滤条件的语法基本相同，但是函数和数据源的类型有关，具体请参考相关文档。"
			Me.o00OO.0_00__0.().AutoSize = True
			Me.o00OO.0_00__0.().Location = New Point(23, 268)
			Me.o00OO.0_00__0.().Name = "Label5"
			Me.o00OO.0_00__0.().Size = New Size(59, 12)
			Me.o00OO.0_00__0.().TabIndex = 2
			Me.o00OO.0_00__0.().Text = "排序规则:"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(590, 515)
			MyBase.Controls.Add(Me.O0000_O.O.())
			MyBase.Controls.Add(Me.o.o0_0.())
			MyBase.Controls.Add(Me.Oo.__0__0.())
			MyBase.Controls.Add(Me.oO.O00_O_0o_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O..Oo..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置外部表"
			Me.O0000_O.O.().EndInit()
			Me.O0000_O.O.().ResumeLayout(False)
			Me.o00OO.0_00__0.().ResumeLayout(False)
			Me.o00OO.0_00__0.().PerformLayout()
			Me.o000O0o._O.().ResumeLayout(False)
			Me.o000O0o._O.().PerformLayout()
			Me.O0OOOO.O0o0_.().ResumeLayout(False)
			Me.O0OOOO.O0o0_.().PerformLayout()
			Me.OOo.00_.().EndInit()
			Me.O0OOOO.O0o0_.().ResumeLayout(False)
			Me.O0OOOO.O0o0_.().PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003911 RID: 14609 RVA: 0x0018B33E File Offset: 0x0018953E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O.o_oO.
		End Function

		' Token: 0x06003912 RID: 14610 RVA: 0x0018B346 File Offset: 0x00189546
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O.o_oO. = A_0
		End Sub

		' Token: 0x06003913 RID: 14611 RVA: 0x0018B34F File Offset: 0x0018954F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOOo._O_o000oO.
		End Function

		' Token: 0x06003914 RID: 14612 RVA: 0x0018B358 File Offset: 0x00189558
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_o_.____O.
			Dim c1Button As C1Button = Me.oOOo._O_o000oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOOo._O_o000oO. = A_0
			c1Button = Me.oOOo._O_o000oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003915 RID: 14613 RVA: 0x0018B39B File Offset: 0x0018959B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoOOO.OOo.
		End Function

		' Token: 0x06003916 RID: 14614 RVA: 0x0018B3A3 File Offset: 0x001895A3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OOoOOO.OOo. = A_0
		End Sub

		' Token: 0x06003917 RID: 14615 RVA: 0x0018B3AC File Offset: 0x001895AC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.0000o.
		End Function

		' Token: 0x06003918 RID: 14616 RVA: 0x0018B3B4 File Offset: 0x001895B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOO._.
			Dim o.0000o. As C1Button = Me.O.0000o.
			If o.0000o. IsNot Nothing Then
				RemoveHandler o.0000o..Click, value
			End If
			Me.O.0000o. = A_0
			o.0000o. = Me.O.0000o.
			If o.0000o. IsNot Nothing Then
				AddHandler o.0000o..Click, value
			End If
		End Sub

		' Token: 0x06003919 RID: 14617 RVA: 0x0018B3F7 File Offset: 0x001895F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_OOo._O_O_0.
		End Function

		' Token: 0x0600391A RID: 14618 RVA: 0x0018B3FF File Offset: 0x001895FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_OOo._O_O_0. = A_0
		End Sub

		' Token: 0x0600391B RID: 14619 RVA: 0x0018B408 File Offset: 0x00189608
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_oOoOo_.O_o_O.
		End Function

		' Token: 0x0600391C RID: 14620 RVA: 0x0018B410 File Offset: 0x00189610
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_oOoOo_.O_o_O. = A_0
		End Sub

		' Token: 0x0600391D RID: 14621 RVA: 0x0018B419 File Offset: 0x00189619
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.O.o_oO.
		End Function

		' Token: 0x0600391E RID: 14622 RVA: 0x0018B421 File Offset: 0x00189621
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.O.o_oO. = A_0
		End Sub

		' Token: 0x0600391F RID: 14623 RVA: 0x0018B42A File Offset: 0x0018962A
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O.o_oO.
		End Function

		' Token: 0x06003920 RID: 14624 RVA: 0x0018B432 File Offset: 0x00189632
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O.o_oO. = A_0
		End Sub

		' Token: 0x06003921 RID: 14625 RVA: 0x0018B43B File Offset: 0x0018963B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_OOo._O_O_0.
		End Function

		' Token: 0x06003922 RID: 14626 RVA: 0x0018B443 File Offset: 0x00189643
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_OOo._O_O_0. = A_0
		End Sub

		' Token: 0x06003923 RID: 14627 RVA: 0x0018B44C File Offset: 0x0018964C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooo_o_O00.oO.
		End Function

		' Token: 0x06003924 RID: 14628 RVA: 0x0018B454 File Offset: 0x00189654
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooo_o_O00.oO. = A_0
		End Sub

		' Token: 0x06003925 RID: 14629 RVA: 0x0018B45D File Offset: 0x0018965D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.OoOO.oOo_o_O.
		End Function

		' Token: 0x06003926 RID: 14630 RVA: 0x0018B465 File Offset: 0x00189665
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.OoOO.oOo_o_O. = A_0
		End Sub

		' Token: 0x06003927 RID: 14631 RVA: 0x0018B46E File Offset: 0x0018966E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O._OOo_O.
		End Function

		' Token: 0x06003928 RID: 14632 RVA: 0x0018B476 File Offset: 0x00189676
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O._OOo_O. = A_0
		End Sub

		' Token: 0x06003929 RID: 14633 RVA: 0x0018B47F File Offset: 0x0018967F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.ooo_o_O00.oO.
		End Function

		' Token: 0x0600392A RID: 14634 RVA: 0x0018B488 File Offset: 0x00189688
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o_o_O.ooo0o_o.
			Dim c1ComboBox As C1ComboBox = Me.ooo_o_O00.oO.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.ooo_o_O00.oO. = A_0
			c1ComboBox = Me.ooo_o_O00.oO.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600392B RID: 14635 RVA: 0x0018B4CB File Offset: 0x001896CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.O.o_oO.
		End Function

		' Token: 0x0600392C RID: 14636 RVA: 0x0018B4D3 File Offset: 0x001896D3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.O.o_oO. = A_0
		End Sub

		' Token: 0x0600392D RID: 14637 RVA: 0x0018B4DC File Offset: 0x001896DC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_OOo._O_O_0.
		End Function

		' Token: 0x0600392E RID: 14638 RVA: 0x0018B4E4 File Offset: 0x001896E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o_Oo.O0o.
			Dim o_OOo._O_O_0. As RadioButton = Me.O_OOo._O_O_0.
			If o_OOo._O_O_0. IsNot Nothing Then
				RemoveHandler o_OOo._O_O_0..CheckedChanged, value
			End If
			Me.O_OOo._O_O_0. = A_0
			o_OOo._O_O_0. = Me.O_OOo._O_O_0.
			If o_OOo._O_O_0. IsNot Nothing Then
				AddHandler o_OOo._O_O_0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600392F RID: 14639 RVA: 0x0018B527 File Offset: 0x00189727
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooOOO0o0.O_.
		End Function

		' Token: 0x06003930 RID: 14640 RVA: 0x0018B530 File Offset: 0x00189730
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.O00_O_0o_O.
			Dim c1Button As C1Button = Me.ooOOO0o0.O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooOOO0o0.O_. = A_0
			c1Button = Me.ooOOO0o0.O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003931 RID: 14641 RVA: 0x0018B573 File Offset: 0x00189773
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.OoOO.oOo_o_O.
		End Function

		' Token: 0x06003932 RID: 14642 RVA: 0x0018B57C File Offset: 0x0018977C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.OOo.00_.
			Dim ooOO.oOo_o_O. As RadioButton = Me.OoOO.oOo_o_O.
			If ooOO.oOo_o_O. IsNot Nothing Then
				RemoveHandler ooOO.oOo_o_O..CheckedChanged, value
			End If
			Me.OoOO.oOo_o_O. = A_0
			ooOO.oOo_o_O. = Me.OoOO.oOo_o_O.
			If ooOO.oOo_o_O. IsNot Nothing Then
				AddHandler ooOO.oOo_o_O..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06003933 RID: 14643 RVA: 0x0018B5BF File Offset: 0x001897BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_.oO00O.
		End Function

		' Token: 0x06003934 RID: 14644 RVA: 0x0018B5C7 File Offset: 0x001897C7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_.oO00O. = A_0
		End Sub

		' Token: 0x06003935 RID: 14645 RVA: 0x0018B5D0 File Offset: 0x001897D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.O_.oO00O.
		End Function

		' Token: 0x06003936 RID: 14646 RVA: 0x0018B5D8 File Offset: 0x001897D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.O_.oO00O. = A_0
		End Sub

		' Token: 0x06003937 RID: 14647 RVA: 0x0018B5E1 File Offset: 0x001897E1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0_ooo.0o.
		End Function

		' Token: 0x06003938 RID: 14648 RVA: 0x0018B5E9 File Offset: 0x001897E9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0_ooo.0o. = A_0
		End Sub

		' Token: 0x06003939 RID: 14649 RVA: 0x0018B5F2 File Offset: 0x001897F2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.O_OOo._O_O_0.
		End Function

		' Token: 0x0600393A RID: 14650 RVA: 0x0018B5FA File Offset: 0x001897FA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.O_OOo._O_O_0. = A_0
		End Sub

		' Token: 0x0600393B RID: 14651 RVA: 0x0018B603 File Offset: 0x00189803
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0.O_.
		End Function

		' Token: 0x0600393C RID: 14652 RVA: 0x0018B60B File Offset: 0x0018980B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o0.O_. = A_0
		End Sub

		' Token: 0x0600393D RID: 14653 RVA: 0x0018B614 File Offset: 0x00189814
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.oo_O.__oO_.
		End Function

		' Token: 0x0600393E RID: 14654 RVA: 0x0018B61C File Offset: 0x0018981C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.oo_O.__oO_. = A_0
		End Sub

		' Token: 0x0600393F RID: 14655 RVA: 0x0018B625 File Offset: 0x00189825
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0o_O.00o.
		End Function

		' Token: 0x06003940 RID: 14656 RVA: 0x0018B62D File Offset: 0x0018982D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0o_O.00o. = A_0
		End Sub

		' Token: 0x06003941 RID: 14657 RVA: 0x0018B636 File Offset: 0x00189836
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo.0O0oOOO0.
		End Function

		' Token: 0x06003942 RID: 14658 RVA: 0x0018B63E File Offset: 0x0018983E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo.0O0oOOO0. = A_0
		End Sub

		' Token: 0x06003943 RID: 14659 RVA: 0x0018B647 File Offset: 0x00189847
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0.O_.
		End Function

		' Token: 0x06003944 RID: 14660 RVA: 0x0018B64F File Offset: 0x0018984F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o0.O_. = A_0
		End Sub

		' Token: 0x06003945 RID: 14661 RVA: 0x0018B658 File Offset: 0x00189858
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O00_00_.oO0O00.
		End Function

		' Token: 0x06003946 RID: 14662 RVA: 0x0018B660 File Offset: 0x00189860
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O00_00_.oO0O00. = A_0
		End Sub

		' Token: 0x06003947 RID: 14663 RVA: 0x0018B669 File Offset: 0x00189869
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oo_O.__oO_.
		End Function

		' Token: 0x06003948 RID: 14664 RVA: 0x0018B671 File Offset: 0x00189871
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oo_O.__oO_. = A_0
		End Sub

		' Token: 0x06003949 RID: 14665 RVA: 0x0018B67A File Offset: 0x0018987A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO_.00oo00.
		End Function

		' Token: 0x0600394A RID: 14666 RVA: 0x0018B682 File Offset: 0x00189882
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO_.00oo00. = A_0
		End Sub

		' Token: 0x0600394B RID: 14667 RVA: 0x0018B68C File Offset: 0x0018988C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o000O0o._O.().ItemsDataSource = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.())
				IL_28:
				num2 = 3
				Me.o000O0o._O.().ItemsDisplayMember = "Name"
				IL_3A:
				num2 = 4
				Me.o000O0o._O.().ItemsValueMember = "Name"
				IL_4C:
				num2 = 5
				If Me.o_oOoOo_.O_o_O..RowState = DataRowState.Detached Then
					GoTo IL_346
				End If
				IL_5F:
				num2 = 6
				If Me.o_oOoOo_.O_o_O..IsNull("DataSource") OrElse Operators.CompareString(Conversions.ToString(Me.o_oOoOo_.O_o_O.("DataSource")), "", True) <= 0 Then
					GoTo IL_141
				End If
				IL_9C:
				num2 = 7
				Dim enumerator As IEnumerator = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).DefaultView.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRowView As DataRowView = CType(obj, DataRowView)
					IL_CE:
					num2 = 8
					If Operators.CompareString(Conversions.ToString(dataRowView("Name")), Conversions.ToString(Me.o_oOoOo_.O_o_O.("DataSource")), True) = 0 Then
						IL_FE:
						num2 = 9
						Me.o000O0o._O.().SelectedItem = RuntimeHelpers.GetObjectValue(dataRowView("Name"))
					End If
					IL_11D:
					num2 = 10
				End While
				IL_129:
				num2 = 11
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_141:
				num2 = 12
				If Me.o_oOoOo_.O_o_O..IsNull("Property") OrElse Operators.CompareString(Conversions.ToString(Me.o_oOoOo_.O_o_O.("Property")), "", True) <= 0 Then
					GoTo IL_291
				End If
				IL_17F:
				num2 = 13
				Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
				IL_189:
				num2 = 14
				o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, Conversions.ToString(Me.o_oOoOo_.O_o_O.("Property")), vbVerticalTab)
				IL_1AA:
				num2 = 15
				Me.O_00__.oo.().SelectedItem = outerTableSetting.SourceTable
				IL_1BF:
				num2 = 16
				Me.OOo.00_.().Value = outerTableSetting.Top
				IL_1D9:
				num2 = 17
				Me.o_Oo.O0o.().Value = outerTableSetting.Order
				IL_1EE:
				num2 = 18
				Me.OOo.00_.().Value = outerTableSetting.Filter
				IL_203:
				num2 = 19
				Me.o0_o_0O_0O_.o.().Value = outerTableSetting.Fields
				IL_218:
				num2 = 20
				Me.o00OO.0_00__0.().Checked = outerTableSetting.Include
				IL_22D:
				num2 = 21
				If Not outerTableSetting.Include Then
					GoTo IL_248
				End If
				IL_239:
				num2 = 22
				Me.O0000_O.O.().Enabled = True
				IL_248:
				num2 = 23
				If Not outerTableSetting.AllRows Then
					GoTo IL_265
				End If
				IL_254:
				num2 = 24
				Me.OO0.oO_o.().Checked = True
				GoTo IL_291
				IL_265:
				num2 = 26
				If Not outerTableSetting.Percent Then
					GoTo IL_282
				End If
				IL_271:
				num2 = 27
				Me.O0OOOO.O0o0_.().Checked = True
				GoTo IL_291
				IL_282:
				num2 = 29
				Me.o0_o_0O_0O_.o.().Checked = True
				IL_291:
				num2 = 30
				Me.Text = Me.Text + " - " + Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name"))
				IL_2BF:
				num2 = 31
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name")), "SEQUENCE", 8 })
				IL_310:
				num2 = 32
				If dataRow Is Nothing Then
					GoTo IL_35F
				End If
				IL_316:
				num2 = 33
				If dataRow.IsNull("Property") Then
					GoTo IL_35F
				End If
				IL_326:
				num2 = 34
				Me.OO._O_.().Value = dataRow("Property").ToString()
				GoTo IL_35F
				IL_346:
				num2 = 36
				Me.Text += " - 新建"
				IL_35F:
				num2 = 37
				If Me.o000O0o._O.().SelectedIndex >= 0 Then
					GoTo IL_395
				End If
				IL_370:
				num2 = 38
				If Me.o000O0o._O.().Items.Count <= 0 Then
					GoTo IL_395
				End If
				IL_386:
				num2 = 39
				Me.o000O0o._O.().SelectedIndex = 0
				IL_395:
				GoTo IL_487
				IL_39A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_448:
				GoTo IL_47C
				IL_44A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_45A:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_44A
			End Try
			IL_47C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_487:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600394C RID: 14668 RVA: 0x0018BB44 File Offset: 0x00189D44
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o000O0o._O.().SelectedItem Is Nothing Then
				Me.O_00__.oo.().Items.Clear()
				Return
			End If
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0O._ooo_O_.()).Rows.Find(RuntimeHelpers.GetObjectValue(Me.o000O0o._O.().SelectedItem))
			Me.O_00__.oo.().Items.Clear()
			If Not dataRow.IsNull("ConnectionString") Then
				Try
					Dim text As String = O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow("ConnectionString")), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.())
					If text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						Dim list As List(Of String) = New O0O(text).OO._o_OO.()
						Try
							For Each text2 As String In list
								If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2) AndAlso Not text2.StartsWith("~") Then
									Me.O_00__.oo.().Items.Add(text2)
								End If
							Next
							GoTo IL_2FE
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
					End If
					Me.o_oOoOo_.O_o_O. = New OleDbConnection(O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow("ConnectionString")), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.()))
					Me.o_oOoOo_.O_o_O..Open()
					Dim dataTable As DataTable
					If o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.o_oOoOo_.O_o_O.) Then
						Dim dbDataAdapter As DbDataAdapter = New OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", Me.o_oOoOo_.O_o_O.)
						dataTable = New DataTable()
						dbDataAdapter.Fill(dataTable)
						Try
							For Each obj As Object In dataTable.Rows
								Dim dataRow2 As DataRow = CType(obj, DataRow)
								Me.O_00__.oo.().Items.Add(String.Concat(New String() { """", dataRow2("OWNER").ToString(), """.""", dataRow2("TABLE_NAME").ToString(), """" }))
							Next
							GoTo IL_2F3
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
					dataTable = Me.o_oOoOo_.O_o_O..GetSchema("Tables")
					Dim filterExpression As String = "[TABLE_TYPE]='TABLE'"
					For Each dataRow3 As DataRow In dataTable.[Select](filterExpression)
						Dim text3 As String = Conversions.ToString(dataRow3("TABLE_NAME"))
						If Not dataRow3.IsNull("TABLE_SCHEMA") AndAlso Operators.CompareString(dataRow3("TABLE_SCHEMA").ToString(), "dbo", True) <> 0 Then
							text3 = String.Concat(New String() { "[", dataRow3("TABLE_SCHEMA").ToString(), "].[", text3, "]" })
						End If
						If Not text3.StartsWith("~") Then
							Me.O_00__.oo.().Items.Add(text3)
						End If
					Next
					IL_2F3:
					Me.o_oOoOo_.O_o_O..Close()
					IL_2FE:
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				End Try
			End If
		End Sub

		' Token: 0x0600394D RID: 14669 RVA: 0x0018BEB8 File Offset: 0x0018A0B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim outerTableSetting As OuterTableSetting = Me.OOo.00_.()
			Dim oleDbConnection As OleDbConnection = Nothing
			If Not String.IsNullOrEmpty(outerTableSetting.SourceTable) Then
				Dim text As String = Me.o000O0o._O.().Text
				If O_O0OO.O._o_.().ContainsKey(text) Then
					oleDbConnection = O_O0OO.O._o_.()(text)
					New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(oleDbConnection, o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, oleDbConnection), Nothing).ShowDialog()
					Return
				End If
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
					New O_\u30000_\u3002O\u3002\u3002\u3000\u3000(oleDbConnection, o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, O_O0OO.OoO__.0oO0oo.()(text).OO.OoO0.), O_O0OO.OoO__.0oO0oo.()(text)).ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x0600394E RID: 14670 RVA: 0x0018BF50 File Offset: 0x0018A150
		Private Function <<EMPTY_NAME>>() As OuterTableSetting
			Return New OuterTableSetting() With { .SourceTable = Conversions.ToString(Me.O_00__.oo.().SelectedItem), .Filter = Me.OOo.00_.().Text.Trim(), .Top = Conversions.ToInteger(Me.OOo.00_.().Value), .Percent = Me.O0OOOO.O0o0_.().Checked, .Fields = Me.o0_o_0O_0O_.o.().Text.Trim(), .Include = Me.o00OO.0_00__0.().Checked, .Order = Me.o_Oo.O0o.().Text.Trim(), .AllFields = Me.O0O0O.0_.().Checked, .AllRows = Me.OO0.oO_o.().Checked }
		End Function

		' Token: 0x0600394F RID: 14671 RVA: 0x0018C014 File Offset: 0x0018A214
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim outerTableSetting As OuterTableSetting = Me.OOo.00_.()
			If Not String.IsNullOrEmpty(outerTableSetting.SourceTable) Then
				Dim dataTable As DataTable = New DataTable()
				Dim httpClient As HttpClient = Nothing
				Dim oleDbConnection As OleDbConnection = Nothing
				Dim text As String = Me.o000O0o._O.().Text
				Dim text2 As String = ""
				If O_O0OO.O._o_.().ContainsKey(text) Then
					oleDbConnection = O_O0OO.O._o_.()(text)
					text2 = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, oleDbConnection)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text2, oleDbConnection)
					Try
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
						GoTo IL_100
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
						Return
					End Try
				End If
				If O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
					text2 = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, O_O0OO.OoO__.0oO0oo.()(text).OO.OoO0.)
					dataTable = O_O0OO.OoO__.0oO0oo.()(text).O_0_O_0_o_.0.(text2, True)
					httpClient = O_O0OO.OoO__.0oO0oo.()(text).oO0_0.o.()
					httpClient.[Select] = text2
					httpClient.FormData("Action") = 1.ToString()
				End If
				IL_100:
				If dataTable.PrimaryKey.Length = 0 Then
					MessageBox.Show("要加载的外部数据表没有设置主键，请使用添加外部查询表的命令加载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Return
				End If
				If Me.o_oOoOo_.O_o_O..RowState = DataRowState.Detached Then
					Dim text3 As String = Me.O_00__.oo.().Text.Trim()
					text3 = text3.Replace("""", "")
					If text3.IndexOf("."c) > 0 Then
						text3 = text3.Substring(text3.IndexOf("."c) + 1)
					End If
					text3 = text3.Trim(New Char() { "["c }).Trim(New Char() { "]"c })
					Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(text3, "")
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(True)
					If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() <> DialogResult.OK Then
						Return
					End If
					Dim text4 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
					Dim text5 As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
					Me.o_oOoOo_.O_o_O.("Name") = text4
					Me.o_oOoOo_.O_o_O.("DataSource") = Me.o000O0o._O.().Text
					Me.o_oOoOo_.O_o_O.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
					O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()).Rows.Add(Me.o_oOoOo_.O_o_O.)
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, outerTableSetting.SourceTable, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, text, httpClient)
					OO_00oOO.DataTables(text4).o.0O000_.()
					OO_00oOO.DataTables(text4).Caption = text5
					OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text4))
					Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name")), True, False)
					Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
					If Operators.CompareString(text5, "", True) > 0 OrElse O_O0OO.O0_00o.o0__o..DevelopByCreater Then
						OO_00oOO.DataTables(text4).Developer = OO_00oOO.User.Name
						OO_00oOO.DataTables(text4).OO00_o.ooOO.(False)
					End If
					O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
				Else
					Dim text6 As String = Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name"))
					If OO_00oOO.DataTables.Contains(text6) Then
						If Not OO_00oOO.DataTables(text6).OOoo__00O_.o_O.(dataTable).o_O__.0O. Then
							Return
						End If
						Me.o_oOoOo_.O_o_O.("DataSource") = Me.o000O0o._O.().Text
						Me.o_oOoOo_.O_o_O.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						Oo00.o00O0O_.O.(Me.o_oOoOo_.O_o_O., OO_00oOO.Tables(text6))
					Else
						Me.o_oOoOo_.O_o_O.("DataSource") = text
						Me.o_oOoOo_.O_o_O.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, False, vbVerticalTab, False)
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0_.OOo0OO.()), True)
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text6, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, outerTableSetting.SourceTable, True, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, Nothing, text, httpClient)
						OO_00oOO.DataTables(text6).o.0O000_.()
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()(text6))
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name")), True, True)
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1
						O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
					End If
				End If
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name")), "SEQUENCE", 8 })
				If Operators.CompareString(Me.OO._O_.().Text.Trim(), "", True) = 0 Then
					If dataRow IsNot Nothing Then
						dataRow("Property") = ""
					End If
				Else
					If dataRow Is Nothing Then
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).NewRow()
						dataRow("Table") = Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name"))
						dataRow("Name") = "SEQUENCE"
						dataRow("Type") = 8
						O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Add(dataRow)
					End If
					dataRow("Property") = Me.OO._O_.().Text.Trim()
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()), True)
				End If
				OO_00oOO.DataTables(Conversions.ToString(Me.o_oOoOo_.O_o_O.("Name"))).SEQUENCE = Me.OO._O_.().Text.Trim()
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06003950 RID: 14672 RVA: 0x0018C6A8 File Offset: 0x0018A8A8
		Private Sub <<EMPTY_NAME>>(A_0 As o\u3000\u3000, A_1 As ValidateInputTextEventArgs)
			If Operators.CompareString(A_1.Value, A_1.OriginalValue, True) <> 0 AndAlso Not Oo00.o.O0_O0.(A_1.Value) Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06003951 RID: 14673 RVA: 0x0018C6D4 File Offset: 0x0018A8D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.O_00__.oo.().Text, "", True) = 0 Then
				MessageBox.Show("请先选择数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Dim a_ As O0O = Nothing
			Dim text As String = Me.o000O0o._O.().Text
			If O_O0OO.O._o_.().ContainsKey(text) Then
				Dim oleDbConnection As OleDbConnection = O_O0OO.O._o_.()(text)
			ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
				a_ = O_O0OO.OoO__.0oO0oo.()(text)
			End If
			Dim o_u3000_u3000_u3002_u3000_u3002_u3002_u As O\u3000\u3000\u3002\u3000\u3002\u3002\u30020 = New O\u3000\u3000\u3002\u3000\u3002\u3002\u30020(Me.o_oOoOo_.O_o_O., a_, Me.O_00__.oo.().Text, Me.o0_o_0O_0O_.o.().Text)
			If o_u3000_u3000_u3002_u3000_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
				Me.o0_o_0O_0O_.o.().Value = o_u3000_u3000_u3002_u3000_u3002_u3002_u.O0Oo.O.()
			End If
		End Sub

		' Token: 0x06003952 RID: 14674 RVA: 0x0018C78C File Offset: 0x0018A98C
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.Load, AddressOf Me.o.OO0O.
			AddHandler MyBase.FormClosed, AddressOf Me.O0000_O.O.
			Me.OOo.00_.()
			Me.o_oOoOo_.O_o_O. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.O0000_O.O.() })
		End Sub

		' Token: 0x06003953 RID: 14675 RVA: 0x0018C804 File Offset: 0x0018AA04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0O0O.0_.().Checked Then
				If Operators.CompareString(Me.o0_o_0O_0O_.o.().Text, "", True) > 0 Then
					Me.o0_o_0O_0O_.o.().Value = ""
				End If
				Me.O0000_O.O.().Enabled = False
			End If
		End Sub

		' Token: 0x06003954 RID: 14676 RVA: 0x0018C853 File Offset: 0x0018AA53
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o00OO.0_00__0.().Checked Then
				Me.O0000_O.O.().Enabled = True
			End If
		End Sub

		' Token: 0x06003955 RID: 14677 RVA: 0x0018C86E File Offset: 0x0018AA6E
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400179C RID: 6044
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400179D RID: 6045
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400179E RID: 6046
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400179F RID: 6047
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017A0 RID: 6048
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017A1 RID: 6049
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017A2 RID: 6050
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040017A3 RID: 6051
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x040017A4 RID: 6052
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040017A5 RID: 6053
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040017A6 RID: 6054
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017A7 RID: 6055
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040017A8 RID: 6056
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017A9 RID: 6057
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040017AA RID: 6058
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x040017AB RID: 6059
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040017AC RID: 6060
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017AD RID: 6061
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040017AE RID: 6062
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040017AF RID: 6063
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x040017B0 RID: 6064
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017B1 RID: 6065
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x040017B2 RID: 6066
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040017B3 RID: 6067
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040017B4 RID: 6068
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017B5 RID: 6069
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017B6 RID: 6070
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040017B7 RID: 6071
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040017B8 RID: 6072
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040017B9 RID: 6073
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040017BA RID: 6074
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040017BB RID: 6075
		Private <<EMPTY_NAME>> As O0O

		' Token: 0x040017BC RID: 6076
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
