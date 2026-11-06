Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D9 RID: 217
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06000C04 RID: 3076 RVA: 0x000571A8 File Offset: 0x000553A8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_OO.0O0o0ooO_. IsNot Nothing Then
					Me.o_OO.0O0o0ooO_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000C05 RID: 3077 RVA: 0x000571E8 File Offset: 0x000553E8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o__0O_O0._0o.(New C1Button())
			Me.o0oo_._0_.(New C1Button())
			Me.O_0_.0.(New Label())
			Me.o00__oOO_0.0o.(New Label())
			Me.O_0_.0.(New C1ComboBox())
			Me.OO0o__O.O0o0_O.(New C1ComboBox())
			Me.o0O_00.oo_O_O_.(New C1TextBox())
			Me.o_.OO0_o.(New RadioButton())
			Me.o0O_00.oo_O_O_.(New RadioButton())
			Me.OOO0O.__OOo_0.(New Label())
			Me.o0O_00.oo_O_O_.(New C1ComboBox())
			Me.o.oo____0.(New C1TextBox())
			Me.OOOoO._0_o.(New Label())
			Me.o_.OO0_o.(New C1TextBox())
			Me.o00__oOO_0.0o.(New C1CheckBox())
			Me.o00O.oo_o0.(New C1CheckBox())
			Me.o__0O_O0._0o.(New C1CheckBox())
			Me.O0._O0O.(New C1CheckBox())
			Me.OOOOO.oOOo_000.(New Label())
			Me.OoOOO0o.__.(New Label())
			Me.o_.OO0_o.(New C1ComboBox())
			Me.o0oo_._0_.(New C1CheckBox())
			Me.OO___o.0_0.(New Label())
			Me.o00_0o__._oo_.(New C1ComboBox())
			Me.OOOOO.oOOo_000.(New C1CheckBox())
			Me.O._oOOo00__O.().BeginInit()
			Me.o__O0O00.o.().BeginInit()
			Me.oo._0_oOo0oo_.().BeginInit()
			Me.O0oooo00.00O0.().BeginInit()
			Me.O00Oo._00_.().BeginInit()
			Me.oOOO.oOOooo___.().BeginInit()
			Me.O_0.00O.().BeginInit()
			Me.Ooo_o0.__.().BeginInit()
			Me.O0oooo00.00O0.().BeginInit()
			Me.oO.o0o_.().BeginInit()
			Me.OO0O___O_.0o0.().BeginInit()
			Me.O._oOOo00__O.().BeginInit()
			Me.O00Oo._00_.().BeginInit()
			Me.o__O0O00.o.().BeginInit()
			Me.Ooo_o0.__.().BeginInit()
			Me.OO.oOO.().BeginInit()
			MyBase.SuspendLayout()
			Me.O._oOOo00__O.().DialogResult = DialogResult.Cancel
			Me.O._oOOo00__O.().ImageAlign = ContentAlignment.MiddleLeft
			Me.O._oOOo00__O.().Location = New Point(187, 358)
			Me.O._oOOo00__O.().Name = "btnCancel"
			Me.O._oOOo00__O.().Size = New Size(75, 23)
			Me.O._oOOo00__O.().TabIndex = 15
			Me.O._oOOo00__O.().Text = "取消"
			Me.O._oOOo00__O.().UseVisualStyleBackColor = True
			Me.o__O0O00.o.().ImageAlign = ContentAlignment.MiddleLeft
			Me.o__O0O00.o.().Location = New Point(96, 358)
			Me.o__O0O00.o.().Name = "btnOK"
			Me.o__O0O00.o.().Size = New Size(75, 23)
			Me.o__O0O00.o.().TabIndex = 14
			Me.o__O0O00.o.().Text = "确定"
			Me.o__O0O00.o.().UseVisualStyleBackColor = True
			Me.o.__OOO.().AutoSize = True
			Me.o.__OOO.().Location = New Point(25, 126)
			Me.o.__OOO.().Margin = New Padding(2, 0, 2, 0)
			Me.o.__OOO.().Name = "Label3"
			Me.o.__OOO.().Size = New Size(47, 12)
			Me.o.__OOO.().TabIndex = 14
			Me.o.__OOO.().Text = "名称列:"
			Me.o.0o_o0.().AutoSize = True
			Me.o.0o_o0.().Location = New Point(25, 23)
			Me.o.0o_o0.().Margin = New Padding(2, 0, 2, 0)
			Me.o.0o_o0.().Name = "Label1"
			Me.o.0o_o0.().Size = New Size(47, 12)
			Me.o.0o_o0.().TabIndex = 12
			Me.o.0o_o0.().Text = "层级列:"
			Me.oo._0_oOo0oo_.().AllowSpinLoop = False
			Me.oo._0_oOo0oo_.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.oo._0_oOo0oo_.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.oo._0_oOo0oo_.().Cursor = Cursors.Arrow
			Me.oo._0_oOo0oo_.().DropDownStyle = 1
			Me.oo._0_oOo0oo_.().GapHeight = 0
			Me.oo._0_oOo0oo_.().ImagePadding = New Padding(0)
			Me.oo._0_oOo0oo_.().ItemsDisplayMember = ""
			Me.oo._0_oOo0oo_.().ItemsValueMember = ""
			Me.oo._0_oOo0oo_.().Location = New Point(87, 123)
			Me.oo._0_oOo0oo_.().Name = "lstCaptionCols"
			Me.oo._0_oOo0oo_.().Size = New Size(239, 19)
			Me.oo._0_oOo0oo_.().TabIndex = 3
			Me.oo._0_oOo0oo_.().Tag = Nothing
			Me.O0oooo00.00O0.().AllowSpinLoop = False
			Me.O0oooo00.00O0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O0oooo00.00O0.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O0oooo00.00O0.().Cursor = Cursors.Arrow
			Me.O0oooo00.00O0.().DropDownStyle = 1
			Me.O0oooo00.00O0.().GapHeight = 0
			Me.O0oooo00.00O0.().ImagePadding = New Padding(0)
			Me.O0oooo00.00O0.().ItemsDisplayMember = ""
			Me.O0oooo00.00O0.().ItemsValueMember = ""
			Me.O0oooo00.00O0.().Location = New Point(87, 21)
			Me.O0oooo00.00O0.().Name = "lstPathCols"
			Me.O0oooo00.00O0.().Size = New Size(239, 19)
			Me.O0oooo00.00O0.().TabIndex = 0
			Me.O0oooo00.00O0.().Tag = Nothing
			Me.O00Oo._00_.().Location = New Point(111, 53)
			Me.O00Oo._00_.().Margin = New Padding(2, 1, 2, 1)
			Me.O00Oo._00_.().Name = "txtSeparator"
			Me.O00Oo._00_.().Size = New Size(117, 19)
			Me.O00Oo._00_.().TabIndex = 1
			Me.O00Oo._00_.().Tag = Nothing
			Me.O00Oo._00_.().Value = "\"
			Me.Ooo_o0.__.().AutoSize = True
			Me.Ooo_o0.__.().Checked = True
			Me.Ooo_o0.__.().Location = New Point(25, 53)
			Me.Ooo_o0.__.().Margin = New Padding(2, 1, 2, 1)
			Me.Ooo_o0.__.().Name = "raoSep"
			Me.Ooo_o0.__.().Size = New Size(77, 16)
			Me.Ooo_o0.__.().TabIndex = 19
			Me.Ooo_o0.__.().TabStop = True
			Me.Ooo_o0.__.().Text = "符号分割:"
			Me.Ooo_o0.__.().UseVisualStyleBackColor = True
			Me.O_0.00O.().AutoSize = True
			Me.O_0.00O.().Location = New Point(25, 85)
			Me.O_0.00O.().Margin = New Padding(2, 1, 2, 1)
			Me.O_0.00O.().Name = "rdoLens"
			Me.O_0.00O.().Size = New Size(77, 16)
			Me.O_0.00O.().TabIndex = 20
			Me.O_0.00O.().TabStop = True
			Me.O_0.00O.().Text = "长度分割:"
			Me.O_0.00O.().UseVisualStyleBackColor = True
			Me.oo.0___oo__oO_.().AutoSize = True
			Me.oo.0___oo__oO_.().Location = New Point(25, 157)
			Me.oo.0___oo__oO_.().Margin = New Padding(2, 0, 2, 0)
			Me.oo.0___oo__oO_.().Name = "Label2"
			Me.oo.0___oo__oO_.().Size = New Size(47, 12)
			Me.oo.0___oo__oO_.().TabIndex = 22
			Me.oo.0___oo__oO_.().Text = "数值列:"
			Me.oOOO.oOOooo___.().AllowSpinLoop = False
			Me.oOOO.oOOooo___.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.oOOO.oOOooo___.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.oOOO.oOOooo___.().Cursor = Cursors.Arrow
			Me.oOOO.oOOooo___.().DropDownStyle = 1
			Me.oOOO.oOOooo___.().GapHeight = 0
			Me.oOOO.oOOooo___.().ImagePadding = New Padding(0)
			Me.oOOO.oOOooo___.().ItemsDisplayMember = ""
			Me.oOOO.oOOooo___.().ItemsValueMember = ""
			Me.oOOO.oOOooo___.().Location = New Point(87, 155)
			Me.oOOO.oOOooo___.().Name = "lstValueCols"
			Me.oOOO.oOOooo___.().Size = New Size(239, 19)
			Me.oOOO.oOOooo___.().TabIndex = 4
			Me.oOOO.oOOooo___.().Tag = Nothing
			Me.O_0.00O.().Enabled = False
			Me.O_0.00O.().Location = New Point(111, 84)
			Me.O_0.00O.().Margin = New Padding(2, 1, 2, 1)
			Me.O_0.00O.().Name = "txtLengths"
			Me.O_0.00O.().Size = New Size(117, 19)
			Me.O_0.00O.().TabIndex = 2
			Me.O_0.00O.().Tag = Nothing
			Me.O_0.00O.().Value = ""
			Me.O00_oO_00oo.O.().AutoSize = True
			Me.O00_oO_00oo.O.().Location = New Point(205, 313)
			Me.O00_oO_00oo.O.().Margin = New Padding(2, 0, 2, 0)
			Me.O00_oO_00oo.O.().Name = "Label5"
			Me.O00_oO_00oo.O.().Size = New Size(17, 12)
			Me.O00_oO_00oo.O.().TabIndex = 29
			Me.O00_oO_00oo.O.().Text = "级"
			Me.Ooo_o0.__.().DataType = GetType(Integer)
			Me.Ooo_o0.__.().Enabled = False
			Me.Ooo_o0.__.().Location = New Point(172, 310)
			Me.Ooo_o0.__.().Name = "txtLevel"
			Me.Ooo_o0.__.().Size = New Size(29, 19)
			Me.Ooo_o0.__.().TabIndex = 12
			Me.Ooo_o0.__.().Tag = Nothing
			Me.Ooo_o0.__.().Value = 0
			Me.O0oooo00.00O0.().AutoSize = True
			Me.O0oooo00.00O0.().BorderStyle = BorderStyle.None
			Me.O0oooo00.00O0.().Location = New Point(87, 285)
			Me.O0oooo00.00O0.().Margin = New Padding(2, 1, 2, 1)
			Me.O0oooo00.00O0.().Name = "chkShowGridTree"
			Me.O0oooo00.00O0.().Size = New Size(84, 16)
			Me.O0oooo00.00O0.().TabIndex = 9
			Me.O0oooo00.00O0.().Text = "显示折叠树"
			Me.O0oooo00.00O0.().UseVisualStyleBackColor = True
			Me.O0oooo00.00O0.().Value = Nothing
			Me.oO.o0o_.().AutoSize = True
			Me.oO.o0o_.().BorderStyle = BorderStyle.None
			Me.oO.o0o_.().Enabled = False
			Me.oO.o0o_.().Location = New Point(87, 311)
			Me.oO.o0o_.().Margin = New Padding(2, 1, 2, 1)
			Me.oO.o0o_.().Name = "chkAutoFold"
			Me.oO.o0o_.().Size = New Size(90, 16)
			Me.oO.o0o_.().TabIndex = 11
			Me.oO.o0o_.().Text = "默认展开到:"
			Me.oO.o0o_.().UseVisualStyleBackColor = True
			Me.oO.o0o_.().Value = Nothing
			Me.OO0O___O_.0o0.().AutoSize = True
			Me.OO0O___O_.0o0.().BorderStyle = BorderStyle.None
			Me.OO0O___O_.0o0.().Location = New Point(218, 257)
			Me.OO0O___O_.0o0.().Margin = New Padding(2, 1, 2, 1)
			Me.OO0O___O_.0o0.().Name = "chkAutoSum"
			Me.OO0O___O_.0o0.().Size = New Size(108, 16)
			Me.OO0O___O_.0o0.().TabIndex = 8
			Me.OO0O___O_.0o0.().Text = "汇总子目录数据"
			Me.OO0O___O_.0o0.().UseVisualStyleBackColor = True
			Me.OO0O___O_.0o0.().Value = Nothing
			Me.O._oOOo00__O.().AutoSize = True
			Me.O._oOOo00__O.().BorderStyle = BorderStyle.None
			Me.O._oOOo00__O.().Checked = True
			Me.O._oOOo00__O.().CheckState = CheckState.Checked
			Me.O._oOOo00__O.().Location = New Point(87, 257)
			Me.O._oOOo00__O.().Margin = New Padding(2, 1, 2, 1)
			Me.O._oOOo00__O.().Name = "chkIncludeSub"
			Me.O._oOOo00__O.().Size = New Size(108, 16)
			Me.O._oOOo00__O.().TabIndex = 7
			Me.O._oOOo00__O.().Text = "显示子目录内容"
			Me.O._oOOo00__O.().UseVisualStyleBackColor = True
			Me.O._oOOo00__O.().Value = True
			Me.oo._0_oOo0oo_.().AutoSize = True
			Me.oo._0_oOo0oo_.().Location = New Point(37, 259)
			Me.oo._0_oOo0oo_.().Margin = New Padding(2, 0, 2, 0)
			Me.oo._0_oOo0oo_.().Name = "Label4"
			Me.oo._0_oOo0oo_.().Size = New Size(35, 12)
			Me.oo._0_oOo0oo_.().TabIndex = 30
			Me.oo._0_oOo0oo_.().Text = "选项:"
			Me.O0oooo00.00O0.().AutoSize = True
			Me.O0oooo00.00O0.().Location = New Point(25, 190)
			Me.O0oooo00.00O0.().Margin = New Padding(2, 0, 2, 0)
			Me.O0oooo00.00O0.().Name = "Label6"
			Me.O0oooo00.00O0.().Size = New Size(47, 12)
			Me.O0oooo00.00O0.().TabIndex = 32
			Me.O0oooo00.00O0.().Text = "排序列:"
			Me.O00Oo._00_.().AllowSpinLoop = False
			Me.O00Oo._00_.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O00Oo._00_.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O00Oo._00_.().Cursor = Cursors.Arrow
			Me.O00Oo._00_.().DropDownStyle = 1
			Me.O00Oo._00_.().GapHeight = 0
			Me.O00Oo._00_.().ImagePadding = New Padding(0)
			Me.O00Oo._00_.().ItemsDisplayMember = ""
			Me.O00Oo._00_.().ItemsValueMember = ""
			Me.O00Oo._00_.().Location = New Point(87, 187)
			Me.O00Oo._00_.().Name = "lstSortCols"
			Me.O00Oo._00_.().Size = New Size(239, 19)
			Me.O00Oo._00_.().TabIndex = 5
			Me.O00Oo._00_.().Tag = Nothing
			Me.o__O0O00.o.().AutoSize = True
			Me.o__O0O00.o.().BorderStyle = BorderStyle.None
			Me.o__O0O00.o.().Enabled = False
			Me.o__O0O00.o.().Location = New Point(278, 311)
			Me.o__O0O00.o.().Margin = New Padding(2, 1, 2, 1)
			Me.o__O0O00.o.().Name = "chkdesc"
			Me.o__O0O00.o.().Size = New Size(48, 16)
			Me.o__O0O00.o.().TabIndex = 13
			Me.o__O0O00.o.().Text = "降序"
			Me.o__O0O00.o.().UseVisualStyleBackColor = True
			Me.o__O0O00.o.().Value = Nothing
			Me.O_00oO_.0oO0o_.().AutoSize = True
			Me.O_00oO_.0oO0o_.().Location = New Point(25, 222)
			Me.O_00oO_.0oO0o_.().Margin = New Padding(2, 0, 2, 0)
			Me.O_00oO_.0oO0o_.().Name = "Label8"
			Me.O_00oO_.0oO0o_.().Size = New Size(47, 12)
			Me.O_00oO_.0oO0o_.().TabIndex = 38
			Me.O_00oO_.0oO0o_.().Text = "树类型:"
			Me.Ooo_o0.__.().AllowSpinLoop = False
			Me.Ooo_o0.__.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.Ooo_o0.__.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.Ooo_o0.__.().Cursor = Cursors.Arrow
			Me.Ooo_o0.__.().DropDownStyle = 1
			Me.Ooo_o0.__.().GapHeight = 0
			Me.Ooo_o0.__.().ImagePadding = New Padding(0)
			Me.Ooo_o0.__.().ItemsDisplayMember = ""
			Me.Ooo_o0.__.().ItemsValueMember = ""
			Me.Ooo_o0.__.().Location = New Point(87, 219)
			Me.Ooo_o0.__.().Name = "lstTreeType"
			Me.Ooo_o0.__.().Size = New Size(239, 19)
			Me.Ooo_o0.__.().TabIndex = 6
			Me.Ooo_o0.__.().Tag = Nothing
			Me.OO.oOO.().AutoSize = True
			Me.OO.oOO.().BorderStyle = BorderStyle.None
			Me.OO.oOO.().Enabled = False
			Me.OO.oOO.().Location = New Point(254, 285)
			Me.OO.oOO.().Margin = New Padding(2, 1, 2, 1)
			Me.OO.oOO.().Name = "chkMergeTotal"
			Me.OO.oOO.().Size = New Size(72, 16)
			Me.OO.oOO.().TabIndex = 10
			Me.OO.oOO.().Text = "合并汇总"
			Me.OO.oOO.().UseVisualStyleBackColor = True
			Me.OO.oOO.().Value = Nothing
			MyBase.AcceptButton = Me.o__O0O00.o.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.O._oOOo00__O.()
			MyBase.ClientSize = New Size(351, 396)
			MyBase.Controls.Add(Me.OO.oOO.())
			MyBase.Controls.Add(Me.O_00oO_.0oO0o_.())
			MyBase.Controls.Add(Me.Ooo_o0.__.())
			MyBase.Controls.Add(Me.o__O0O00.o.())
			MyBase.Controls.Add(Me.O0oooo00.00O0.())
			MyBase.Controls.Add(Me.O00Oo._00_.())
			MyBase.Controls.Add(Me.Ooo_o0.__.())
			MyBase.Controls.Add(Me.oo._0_oOo0oo_.())
			MyBase.Controls.Add(Me.O00_oO_00oo.O.())
			MyBase.Controls.Add(Me.O0oooo00.00O0.())
			MyBase.Controls.Add(Me.oO.o0o_.())
			MyBase.Controls.Add(Me.OO0O___O_.0o0.())
			MyBase.Controls.Add(Me.O._oOOo00__O.())
			MyBase.Controls.Add(Me.O_0.00O.())
			MyBase.Controls.Add(Me.oo.0___oo__oO_.())
			MyBase.Controls.Add(Me.oOOO.oOOooo___.())
			MyBase.Controls.Add(Me.O_0.00O.())
			MyBase.Controls.Add(Me.Ooo_o0.__.())
			MyBase.Controls.Add(Me.O00Oo._00_.())
			MyBase.Controls.Add(Me.O._oOOo00__O.())
			MyBase.Controls.Add(Me.o__O0O00.o.())
			MyBase.Controls.Add(Me.o.__OOO.())
			MyBase.Controls.Add(Me.o.0o_o0.())
			MyBase.Controls.Add(Me.oo._0_oOo0oo_.())
			MyBase.Controls.Add(Me.O0oooo00.00O0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(2, 1, 2, 1)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO.....OO"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置层级筛选树"
			Me.O._oOOo00__O.().EndInit()
			Me.o__O0O00.o.().EndInit()
			Me.oo._0_oOo0oo_.().EndInit()
			Me.O0oooo00.00O0.().EndInit()
			Me.O00Oo._00_.().EndInit()
			Me.oOOO.oOOooo___.().EndInit()
			Me.O_0.00O.().EndInit()
			Me.Ooo_o0.__.().EndInit()
			Me.O0oooo00.00O0.().EndInit()
			Me.oO.o0o_.().EndInit()
			Me.OO0O___O_.0o0.().EndInit()
			Me.O._oOOo00__O.().EndInit()
			Me.O00Oo._00_.().EndInit()
			Me.o__O0O00.o.().EndInit()
			Me.Ooo_o0.__.().EndInit()
			Me.OO.oOO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000C06 RID: 3078 RVA: 0x000585A4 File Offset: 0x000567A4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O_00.oo_O_O_.
		End Function

		' Token: 0x06000C07 RID: 3079 RVA: 0x000585AC File Offset: 0x000567AC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0O_00.oo_O_O_. = A_0
		End Sub

		' Token: 0x06000C08 RID: 3080 RVA: 0x000585B5 File Offset: 0x000567B5
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.00_.
		End Function

		' Token: 0x06000C09 RID: 3081 RVA: 0x000585C0 File Offset: 0x000567C0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_00_oO.oO.
			Dim c1Button As C1Button = Me.o.00_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.00_. = A_0
			c1Button = Me.o.00_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06000C0A RID: 3082 RVA: 0x00058603 File Offset: 0x00056803
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_00o_.o.
		End Function

		' Token: 0x06000C0B RID: 3083 RVA: 0x0005860B File Offset: 0x0005680B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_00o_.o. = A_0
		End Sub

		' Token: 0x06000C0C RID: 3084 RVA: 0x00058614 File Offset: 0x00056814
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.00_.
		End Function

		' Token: 0x06000C0D RID: 3085 RVA: 0x0005861C File Offset: 0x0005681C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.00_. = A_0
		End Sub

		' Token: 0x06000C0E RID: 3086 RVA: 0x00058625 File Offset: 0x00056825
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_000O._.
		End Function

		' Token: 0x06000C0F RID: 3087 RVA: 0x0005862D File Offset: 0x0005682D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_000O._. = A_0
		End Sub

		' Token: 0x06000C10 RID: 3088 RVA: 0x00058636 File Offset: 0x00056836
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O.0_oOoo.
		End Function

		' Token: 0x06000C11 RID: 3089 RVA: 0x0005863E File Offset: 0x0005683E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O.0_oOoo. = A_0
		End Sub

		' Token: 0x06000C12 RID: 3090 RVA: 0x00058647 File Offset: 0x00056847
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_OO.0O0o0ooO_.
		End Function

		' Token: 0x06000C13 RID: 3091 RVA: 0x0005864F File Offset: 0x0005684F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_OO.0O0o0ooO_. = A_0
		End Sub

		' Token: 0x06000C14 RID: 3092 RVA: 0x00058658 File Offset: 0x00056858
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o_000O._.
		End Function

		' Token: 0x06000C15 RID: 3093 RVA: 0x00058660 File Offset: 0x00056860
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o00O.oo_o0.
			Dim radioButton As RadioButton = Me.o_000O._.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o_000O._. = A_0
			radioButton = Me.o_000O._.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C16 RID: 3094 RVA: 0x000586A3 File Offset: 0x000568A3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Oo0.OO.
		End Function

		' Token: 0x06000C17 RID: 3095 RVA: 0x000586AC File Offset: 0x000568AC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o00O.oo_o0.
			Dim oo0.OO. As RadioButton = Me.Oo0.OO.
			If oo0.OO. IsNot Nothing Then
				RemoveHandler oo0.OO..CheckedChanged, value
			End If
			Me.Oo0.OO. = A_0
			oo0.OO. = Me.Oo0.OO.
			If oo0.OO. IsNot Nothing Then
				AddHandler oo0.OO..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C18 RID: 3096 RVA: 0x000586EF File Offset: 0x000568EF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0._0_o.
		End Function

		' Token: 0x06000C19 RID: 3097 RVA: 0x000586F7 File Offset: 0x000568F7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0._0_o. = A_0
		End Sub

		' Token: 0x06000C1A RID: 3098 RVA: 0x00058700 File Offset: 0x00056900
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O__o.0.
		End Function

		' Token: 0x06000C1B RID: 3099 RVA: 0x00058708 File Offset: 0x00056908
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O__o.0. = A_0
		End Sub

		' Token: 0x06000C1C RID: 3100 RVA: 0x00058711 File Offset: 0x00056911
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo0.OO.
		End Function

		' Token: 0x06000C1D RID: 3101 RVA: 0x00058719 File Offset: 0x00056919
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Oo0.OO. = A_0
		End Sub

		' Token: 0x06000C1E RID: 3102 RVA: 0x00058722 File Offset: 0x00056922
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0OOo0_0._O.
		End Function

		' Token: 0x06000C1F RID: 3103 RVA: 0x0005872A File Offset: 0x0005692A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0OOo0_0._O. = A_0
		End Sub

		' Token: 0x06000C20 RID: 3104 RVA: 0x00058733 File Offset: 0x00056933
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OOO000o._00.
		End Function

		' Token: 0x06000C21 RID: 3105 RVA: 0x0005873B File Offset: 0x0005693B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OOO000o._00. = A_0
		End Sub

		' Token: 0x06000C22 RID: 3106 RVA: 0x00058744 File Offset: 0x00056944
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_00o_.o.
		End Function

		' Token: 0x06000C23 RID: 3107 RVA: 0x0005874C File Offset: 0x0005694C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.OO.o_oOO_.
			Dim o_00o_.o. As C1CheckBox = Me.O_00o_.o.
			If o_00o_.o. IsNot Nothing Then
				RemoveHandler o_00o_.o..CheckedChanged, value
			End If
			Me.O_00o_.o. = A_0
			o_00o_.o. = Me.O_00o_.o.
			If o_00o_.o. IsNot Nothing Then
				AddHandler o_00o_.o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C24 RID: 3108 RVA: 0x0005878F File Offset: 0x0005698F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o.00_.
		End Function

		' Token: 0x06000C25 RID: 3109 RVA: 0x00058798 File Offset: 0x00056998
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.OO.o_oOO_.
			Dim c1CheckBox As C1CheckBox = Me.o.00_.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.o.00_. = A_0
			c1CheckBox = Me.o.00_.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C26 RID: 3110 RVA: 0x000587DB File Offset: 0x000569DB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0._0_o.
		End Function

		' Token: 0x06000C27 RID: 3111 RVA: 0x000587E4 File Offset: 0x000569E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.Oo_o_0.__O0.
			Dim o0._0_o. As C1CheckBox = Me.O0._0_o.
			If o0._0_o. IsNot Nothing Then
				RemoveHandler o0._0_o..CheckedChanged, value
			End If
			Me.O0._0_o. = A_0
			o0._0_o. = Me.O0._0_o.
			If o0._0_o. IsNot Nothing Then
				AddHandler o0._0_o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000C28 RID: 3112 RVA: 0x00058827 File Offset: 0x00056A27
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.ooo_.__.
		End Function

		' Token: 0x06000C29 RID: 3113 RVA: 0x0005882F File Offset: 0x00056A2F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.ooo_.__. = A_0
		End Sub

		' Token: 0x06000C2A RID: 3114 RVA: 0x00058838 File Offset: 0x00056A38
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_O0O._O__oO_.
		End Function

		' Token: 0x06000C2B RID: 3115 RVA: 0x00058840 File Offset: 0x00056A40
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_O0O._O__oO_. = A_0
		End Sub

		' Token: 0x06000C2C RID: 3116 RVA: 0x00058849 File Offset: 0x00056A49
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOo_0_00o.OOOO.
		End Function

		' Token: 0x06000C2D RID: 3117 RVA: 0x00058851 File Offset: 0x00056A51
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOo_0_00o.OOOO. = A_0
		End Sub

		' Token: 0x06000C2E RID: 3118 RVA: 0x0005885A File Offset: 0x00056A5A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O0OOo0_0._O.
		End Function

		' Token: 0x06000C2F RID: 3119 RVA: 0x00058864 File Offset: 0x00056A64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o0oo_._0_.
			Dim o0OOo0_0._O. As C1ComboBox = Me.O0OOo0_0._O.
			If o0OOo0_0._O. IsNot Nothing Then
				o0OOo0_0._O..SelectedIndexChanged -= eventHandler
			End If
			Me.O0OOo0_0._O. = A_0
			o0OOo0_0._O. = Me.O0OOo0_0._O.
			If o0OOo0_0._O. IsNot Nothing Then
				o0OOo0_0._O..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06000C30 RID: 3120 RVA: 0x000588A7 File Offset: 0x00056AA7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.OOO_._0_0_.
		End Function

		' Token: 0x06000C31 RID: 3121 RVA: 0x000588AF File Offset: 0x00056AAF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.OOO_._0_0_. = A_0
		End Sub

		' Token: 0x06000C32 RID: 3122 RVA: 0x000588B8 File Offset: 0x00056AB8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_O._o_0.
		End Function

		' Token: 0x06000C33 RID: 3123 RVA: 0x000588C0 File Offset: 0x00056AC0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_O._o_0. = A_0
		End Sub

		' Token: 0x06000C34 RID: 3124 RVA: 0x000588C9 File Offset: 0x00056AC9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O_O0O._O__oO_.
		End Function

		' Token: 0x06000C35 RID: 3125 RVA: 0x000588D4 File Offset: 0x00056AD4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0._O0O.
			Dim o_O0O._O__oO_. As C1ComboBox = Me.O_O0O._O__oO_.
			If o_O0O._O__oO_. IsNot Nothing Then
				o_O0O._O__oO_..SelectedIndexChanged -= eventHandler
			End If
			Me.O_O0O._O__oO_. = A_0
			o_O0O._O__oO_. = Me.O_O0O._O__oO_.
			If o_O0O._O__oO_. IsNot Nothing Then
				o_O0O._O__oO_..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06000C36 RID: 3126 RVA: 0x00058917 File Offset: 0x00056B17
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O000._oo0O_.
		End Function

		' Token: 0x06000C37 RID: 3127 RVA: 0x0005891F File Offset: 0x00056B1F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O000._oo0O_. = A_0
		End Sub

		' Token: 0x06000C38 RID: 3128 RVA: 0x00058928 File Offset: 0x00056B28
		Public Sub New(A_0 As Table, A_1 As O0_0_0O0___O)
			AddHandler MyBase.Load, AddressOf Me.Oooo_0.oO0o__.
			AddHandler MyBase.FormClosed, AddressOf Me.o__O0O00.o.
			Me.o_OO.0O0o0ooO_. = New Dictionary(Of String, String)()
			Me.O0._O0O.()
			Me.o_OO.0O0o0ooO_. = A_0
			Me.o_OO.0O0o0ooO_. = A_1
			Me.Ooo_o0.__.().DataType = GetType(TreeTypeEnum)
			Me.Ooo_o0.__.().ItemsDataSource = [Enum].GetValues(GetType(TreeTypeEnum))
		End Sub

		' Token: 0x06000C39 RID: 3129 RVA: 0x000589B0 File Offset: 0x00056BB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oo._0_oOo0oo_.().Items.Add("")
			Me.oOOO.oOOooo___.().Items.Add("")
			Me.O00Oo._00_.().Items.Add("")
			Try
				For Each dataCol As DataCol In Me.o_OO.0O0o0ooO_..DataTable.DataCols
					Dim left As String = ""
					If Operators.CompareString(dataCol.Caption, "", True) > 0 AndAlso Not Me.o_OO.0O0o0ooO_..ContainsKey(dataCol.Caption) Then
						left = dataCol.Caption
						Me.o_OO.0O0o0ooO_..Add(dataCol.Caption, dataCol.Name)
						Me.O00Oo._00_.().Items.Add(dataCol.Caption)
					Else
						Me.O00Oo._00_.().Items.Add(dataCol.Name)
					End If
					If Operators.CompareString(Me.o_OO.0O0o0ooO_..ooo._Ooo., dataCol.Name, True) = 0 Then
						Me.O00Oo._00_.().SelectedIndex = Me.O00Oo._00_.().Items.Count - 1
						Me.o__O0O00.o.().Checked = Me.o_OO.0O0o0ooO_..O0_.__o00_.
					End If
					If dataCol.IsString Then
						If Operators.CompareString(left, "", True) > 0 Then
							Me.O0oooo00.00O0.().Items.Add(dataCol.Caption)
							Me.oo._0_oOo0oo_.().Items.Add(dataCol.Caption)
						Else
							Me.O0oooo00.00O0.().Items.Add(dataCol.Name)
							Me.oo._0_oOo0oo_.().Items.Add(dataCol.Name)
						End If
						If Operators.CompareString(Me.o_OO.0O0o0ooO_..o_O_0._O_., dataCol.Name, True) = 0 Then
							Me.O0oooo00.00O0.().SelectedIndex = Me.O0oooo00.00O0.().Items.Count - 1
						End If
						If Operators.CompareString(Me.o_OO.0O0o0ooO_..ooO0o.o_O., dataCol.Name, True) = 0 Then
							Me.oo._0_oOo0oo_.().SelectedIndex = Me.oo._0_oOo0oo_.().Items.Count - 1
						End If
					ElseIf dataCol.IsNumeric Then
						If Operators.CompareString(left, "", True) > 0 Then
							Me.oOOO.oOOooo___.().Items.Add(dataCol.Caption)
						Else
							Me.oOOO.oOOooo___.().Items.Add(dataCol.Name)
						End If
						If Operators.CompareString(Me.o_OO.0O0o0ooO_..Oo_0o_O0._., dataCol.Name, True) = 0 Then
							Me.oOOO.oOOooo___.().SelectedIndex = Me.oOOO.oOOooo___.().Items.Count - 1
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			If Operators.CompareString(Conversions.ToString(Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo.), "", True) > 0 Then
				Me.O00Oo._00_.().Value = Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo.
			End If
			If Operators.CompareString(Me.o_OO.0O0o0ooO_..oo.o0o0O_o_., "", True) > 0 Then
				Me.O_0.00O.().Value = Me.o_OO.0O0o0ooO_..oo.o0o0O_o_.
				Me.O_0.00O.().Checked = True
			End If
			Me.O._oOOo00__O.().Checked = Me.o_OO.0O0o0ooO_..oo_o_.oOO.
			Me.OO0O___O_.0o0.().Checked = Me.o_OO.0O0o0ooO_..O.O000.
			Me.OO.oOO.().Checked = Me.o_OO.0O0o0ooO_..ooo_Ooo0.__.
			Me.O0oooo00.00O0.().Checked = Me.o_OO.0O0o0ooO_..O0oO0_._0.
			Me.Ooo_o0.__.().Value = Me.o_OO.0O0o0ooO_..o.0o00ooo_.
			Me.oO.o0o_.().Checked = (Me.O0oooo00.00O0.().Checked AndAlso Me.o_OO.0O0o0ooO_..o.0o00ooo_. >= 0)
			If Me.o_OO.0O0o0ooO_. = O0_0_0O0___O.OOO.__O_oO_. Then
				Me.Ooo_o0.__.().SelectedItem = TreeTypeEnum.BOM
				Return
			End If
			If Me.o_OO.0O0o0ooO_..OOoOO.OO0. Then
				Me.Ooo_o0.__.().SelectedItem = TreeTypeEnum.项目
				Return
			End If
			Me.Ooo_o0.__.().SelectedItem = TreeTypeEnum.普通
		End Sub

		' Token: 0x06000C3A RID: 3130 RVA: 0x00058DF4 File Offset: 0x00056FF4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06000C3B RID: 3131 RVA: 0x00058E08 File Offset: 0x00057008
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim left As String = Nothing
			If Me.O0oooo00.00O0.().SelectedIndex >= 0 Then
				left = Me.O_0.00O.(Me.O0oooo00.00O0.().SelectedItem.ToString())
			End If
			Dim flag As Boolean
			If Me.Ooo_o0.__.().Checked Then
				If Operators.CompareString(Me.O00Oo._00_.().Text, "", True) > 0 AndAlso Operators.CompareString(left, "", True) > 0 Then
					flag = True
				End If
			ElseIf Operators.CompareString(Me.O_0.00O.().Text, "", True) > 0 Then
				Dim array As String() = Regex.Split(Me.O_0.00O.().Text, "[^\d]+")
				Dim list As List(Of Integer) = New List(Of Integer)()
				If array.Length > 0 Then
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Dim item As Integer
						If Integer.TryParse(array(i), item) Then
							list.Add(item)
						End If
					Next
					If list.Count = array.Length Then
						flag = True
					Else
						MessageBox.Show("请正确输入用逗号分割的长度，例如:1,3,2")
					End If
				End If
			End If
			If flag Then
				OO_00oOO.LockBaseMainForm()
				Me.Oo_o_0.__O0.()
				Me.O_0.00O.()
				Me.o_OO.0O0o0ooO_..OpenLayersTree()
				MyBase.DialogResult = DialogResult.OK
				Me.o_OO.0O0o0ooO_..NeedSaveSetting = True
				Me.o_OO.0O0o0ooO_..oo0OO0Ooo._.(True)
				OO_00oOO.UnlockBaseMainForm()
			End If
		End Sub

		' Token: 0x06000C3C RID: 3132 RVA: 0x00058F44 File Offset: 0x00057144
		Private Sub <<EMPTY_NAME>>()
			Me.o_OO.0O0o0ooO_..o_O_0._O_. = ""
			Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = vbNullChar
			Me.o_OO.0O0o0ooO_..oo.o0o0O_o_. = ""
			Me.o_OO.0O0o0ooO_..ooO0o.o_O. = ""
			Me.o_OO.0O0o0ooO_..Oo_0o_O0._. = ""
			Me.o_OO.0O0o0ooO_..oo_o_.oOO. = False
			Me.o_OO.0O0o0ooO_..ooo_Ooo0.__. = True
			Me.o_OO.0O0o0ooO_..O.O000. = False
			Me.o_OO.0O0o0ooO_..O0oO0_._0. = False
			Me.o_OO.0O0o0ooO_..o.0o00ooo_. = -1
			Me.o_OO.0O0o0ooO_..ooo._Ooo. = ""
			Me.o_OO.0O0o0ooO_..O0_.__o00_. = False
			Me.o_OO.0O0o0ooO_..OOoOO.OO0. = True
		End Sub

		' Token: 0x06000C3D RID: 3133 RVA: 0x00059004 File Offset: 0x00057204
		Private Sub <<EMPTY_NAME>>()
			Me.o_OO.0O0o0ooO_..o_O_0._O_. = Me.O_0.00O.(Me.O0oooo00.00O0.().SelectedItem.ToString())
			If Me.Ooo_o0.__.().Checked Then
				Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = Me.O00Oo._00_.().Text(0)
			Else
				Me.o_OO.0O0o0ooO_..oo.o0o0O_o_. = Me.O_0.00O.().Text
			End If
			If Me.oo._0_oOo0oo_.().SelectedIndex > 0 Then
				Me.o_OO.0O0o0ooO_..ooO0o.o_O. = Me.O_0.00O.(Me.oo._0_oOo0oo_.().SelectedItem.ToString())
			End If
			If Me.oOOO.oOOooo___.().SelectedIndex > 0 Then
				Me.o_OO.0O0o0ooO_..Oo_0o_O0._. = Me.O_0.00O.(Me.oOOO.oOOooo___.().SelectedItem.ToString())
			End If
			If Me.O00Oo._00_.().SelectedIndex > 0 Then
				Me.o_OO.0O0o0ooO_..ooo._Ooo. = Me.O_0.00O.(Me.O00Oo._00_.().SelectedItem.ToString())
				Me.o_OO.0O0o0ooO_..O0_.__o00_. = Me.o__O0O00.o.().Checked
			Else
				Me.o_OO.0O0o0ooO_..O0_.__o00_. = False
			End If
			Me.o_OO.0O0o0ooO_..oo_o_.oOO. = Me.O._oOOo00__O.().Checked
			Me.o_OO.0O0o0ooO_..ooo_Ooo0.__. = Me.OO.oOO.().Checked
			Me.o_OO.0O0o0ooO_..O.O000. = (Me.OO0O___O_.0o0.().Checked AndAlso Me.o_OO.0O0o0ooO_. = O0_0_0O0___O.oOO___o.0oO.)
			Me.o_OO.0O0o0ooO_..O0oO0_._0. = Me.O0oooo00.00O0.().Checked
			If Conversions.ToInteger(Me.Ooo_o0.__.().Value) = 0 Then
				Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.
				Me.o_OO.0O0o0ooO_..OOoOO.OO0. = True
			Else
				Me.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.
				Me.o_OO.0O0o0ooO_..OOoOO.OO0. = (Conversions.ToInteger(Me.Ooo_o0.__.().Value) = 1)
			End If
			If Me.oO.o0o_.().Checked AndAlso Me.Ooo_o0.__.().Value IsNot Nothing Then
				Me.o_OO.0O0o0ooO_..o.0o00ooo_. = Conversions.ToInteger(Me.Ooo_o0.__.().Value)
				Return
			End If
			Me.o_OO.0O0o0ooO_..o.0o00ooo_. = -1
		End Sub

		' Token: 0x06000C3E RID: 3134 RVA: 0x00059224 File Offset: 0x00057424
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If Me.o_OO.0O0o0ooO_..ContainsKey(A_0) Then
				result = Me.o_OO.0O0o0ooO_.(A_0)
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06000C3F RID: 3135 RVA: 0x00059251 File Offset: 0x00057451
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO.o0o_.().Enabled = Me.O0oooo00.00O0.().Checked
			Me.Ooo_o0.__.().Enabled = Me.oO.o0o_.().Checked
		End Sub

		' Token: 0x06000C40 RID: 3136 RVA: 0x0005927F File Offset: 0x0005747F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_0.00O.().Enabled = Me.O_0.00O.().Checked
			Me.O00Oo._00_.().Enabled = Me.Ooo_o0.__.().Checked
		End Sub

		' Token: 0x06000C41 RID: 3137 RVA: 0x000592B0 File Offset: 0x000574B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Conversions.ToInteger(Me.Ooo_o0.__.().Value) = 0 Then
				Me.OO0O___O_.0o0.().Enabled = False
				Me.OO0O___O_.0o0.().Checked = False
				Me.OO.oOO.().Enabled = False
				Me.OO.oOO.().Checked = False
				Return
			End If
			Me.OO0O___O_.0o0.().Enabled = True
			Me.OO.oOO.().Enabled = True
		End Sub

		' Token: 0x06000C42 RID: 3138 RVA: 0x00059318 File Offset: 0x00057518
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO.oOO.().Enabled = Me.OO0O___O_.0o0.().Checked
		End Sub

		' Token: 0x06000C43 RID: 3139 RVA: 0x00059330 File Offset: 0x00057530
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o__O0O00.o.().Enabled = (Me.O00Oo._00_.().SelectedIndex > 0)
		End Sub

		' Token: 0x04000498 RID: 1176
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000499 RID: 1177
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400049A RID: 1178
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400049B RID: 1179
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400049C RID: 1180
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400049D RID: 1181
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400049E RID: 1182
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400049F RID: 1183
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004A0 RID: 1184
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004A1 RID: 1185
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040004A2 RID: 1186
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004A3 RID: 1187
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040004A4 RID: 1188
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004A5 RID: 1189
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004A6 RID: 1190
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040004A7 RID: 1191
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004A8 RID: 1192
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004A9 RID: 1193
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004AA RID: 1194
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004AB RID: 1195
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004AC RID: 1196
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004AD RID: 1197
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040004AE RID: 1198
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004AF RID: 1199
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040004B0 RID: 1200
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040004B1 RID: 1201
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040004B2 RID: 1202
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040004B3 RID: 1203
		Private <<EMPTY_NAME>> As O0_0_0O0___O

		' Token: 0x040004B4 RID: 1204
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
