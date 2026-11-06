Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports C1.Win.Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D6 RID: 214
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class O\u30020\u3000\u3002
		Inherits Form

		' Token: 0x06000B6B RID: 2923 RVA: 0x00052278 File Offset: 0x00050478
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_.0O_O_. IsNot Nothing Then
					Me.O_.0O_O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000B6C RID: 2924 RVA: 0x000522B8 File Offset: 0x000504B8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_O_.__o.(New C1Button())
			Me.o.o0OO.(New C1Button())
			Me.O__0_0_o_.ooO.(New Label())
			Me.OO00O0_.o0OooO.(New Label())
			Me.o_._o0ooOO_o.(New C1ComboBox())
			Me.O.000_O.(New C1ComboBox())
			Me.Oo0o0.O0.(New RadioButton())
			Me.O0._0oo0O__.(New RadioButton())
			Me.Ooo0_Oo.0_.(New Label())
			Me.Ooo0_Oo.0_.(New Panel())
			Me.OOOo.O0o_.(New Panel())
			Me.Oo0_OO_O.o.(New C1TextBox())
			Me.o_OoooO.O0_0O_.(New RadioButton())
			Me.Oo0_OO_O.o.(New RadioButton())
			Me.OOo.O___.(New C1TextBox())
			Me.o__00.oO_.(New Label())
			Me.OoO_o0OOO_.Oo.(New C1ComboBox())
			Me.OOOo.O0o_.(New Label())
			Me.O0._0oo0O__.(New C1TextBox())
			Me.O__OOo_.OoOO00.(New Label())
			Me.o___O0O___.O.(New C1ComboBox())
			Me.O__.O000_0_0_O.(New Label())
			Me.OOo.O___.(New RadioButton())
			Me.o___O0O___.O.(New C1MultiSelect())
			Me.oo0O_oO.o0oOOo.(New Label())
			Me.O____o.0O__o.(New C1ComboBox())
			Me.oo___O0o0.00o0.(New Label())
			Me.o_O_.__o.(New C1CheckBox())
			Me.O__o_.o0___0OO.(New Label())
			Me.OoO_o0OOO_.Oo.(New C1MultiSelect())
			Me.OoO_o0OOO_.Oo.(New C1CheckBox())
			Me.oO.O__0.().BeginInit()
			Me.o_0O0.O0.().BeginInit()
			Me.o_0O0.O0.().BeginInit()
			Me.o_o00oO_O.0.().BeginInit()
			Me.o_oO_0o.00_O_0.().SuspendLayout()
			Me.OO_0o0O.O_O00.().SuspendLayout()
			Me.oO.00_.().BeginInit()
			Me.o.o0OO.().BeginInit()
			Me.o_o_000o_.Oo.().BeginInit()
			Me.o_O_.__o.().BeginInit()
			Me.O_00OOO.o0O.().BeginInit()
			Me.O_.000__O_0o.().BeginInit()
			Me.oO.O__0.().BeginInit()
			Me.o_0O0.O0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oO.O__0.().DialogResult = DialogResult.Cancel
			Me.oO.O__0.().ImageAlign = ContentAlignment.MiddleLeft
			Me.oO.O__0.().Location = New Point(252, 389)
			Me.oO.O__0.().Margin = New Padding(4, 4, 4, 4)
			Me.oO.O__0.().Name = "btnCancel"
			Me.oO.O__0.().Size = New Size(100, 29)
			Me.oO.O__0.().TabIndex = 9
			Me.oO.O__0.().Text = "取消"
			Me.oO.O__0.().UseVisualStyleBackColor = True
			Me.o_0O0.O0.().ImageAlign = ContentAlignment.MiddleLeft
			Me.o_0O0.O0.().Location = New Point(129, 389)
			Me.o_0O0.O0.().Margin = New Padding(4, 4, 4, 4)
			Me.o_0O0.O0.().Name = "btnOK"
			Me.o_0O0.O0.().Size = New Size(100, 29)
			Me.o_0O0.O0.().TabIndex = 8
			Me.o_0O0.O0.().Text = "确定"
			Me.o_0O0.O0.().UseVisualStyleBackColor = True
			Me.O._0oo.().AutoSize = True
			Me.O._0oo.().Location = New Point(33, 48)
			Me.O._0oo.().Name = "Label2"
			Me.O._0oo.().Size = New Size(45, 15)
			Me.O._0oo.().TabIndex = 19
			Me.O._0oo.().Text = "子列:"
			Me.OO_.oOoO0.().AutoSize = True
			Me.OO_.oOoO0.().Location = New Point(33, 5)
			Me.OO_.oOoO0.().Name = "Label1"
			Me.OO_.oOoO0.().Size = New Size(45, 15)
			Me.OO_.oOoO0.().TabIndex = 17
			Me.OO_.oOoO0.().Text = "父列:"
			Me.o_0O0.O0.().AllowSpinLoop = False
			Me.o_0O0.O0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.o_0O0.O0.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.o_0O0.O0.().Cursor = Cursors.Arrow
			Me.o_0O0.O0.().DropDownStyle = 1
			Me.o_0O0.O0.().GapHeight = 0
			Me.o_0O0.O0.().ImagePadding = New Padding(0)
			Me.o_0O0.O0.().ItemsDisplayMember = ""
			Me.o_0O0.O0.().ItemsValueMember = ""
			Me.o_0O0.O0.().Location = New Point(108, 44)
			Me.o_0O0.O0.().Margin = New Padding(4, 4, 4, 4)
			Me.o_0O0.O0.().Name = "cmbChildCol"
			Me.o_0O0.O0.().Size = New Size(321, 23)
			Me.o_0O0.O0.().TabIndex = 1
			Me.o_0O0.O0.().Tag = Nothing
			Me.o_o00oO_O.0.().AllowSpinLoop = False
			Me.o_o00oO_O.0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.o_o00oO_O.0.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.o_o00oO_O.0.().Cursor = Cursors.Arrow
			Me.o_o00oO_O.0.().DropDownStyle = 1
			Me.o_o00oO_O.0.().GapHeight = 0
			Me.o_o00oO_O.0.().ImagePadding = New Padding(0)
			Me.o_o00oO_O.0.().ItemsDisplayMember = ""
			Me.o_o00oO_O.0.().ItemsValueMember = ""
			Me.o_o00oO_O.0.().Location = New Point(108, 1)
			Me.o_o00oO_O.0.().Margin = New Padding(4, 4, 4, 4)
			Me.o_o00oO_O.0.().Name = "cmbParentCol"
			Me.o_o00oO_O.0.().Size = New Size(321, 23)
			Me.o_o00oO_O.0.().TabIndex = 0
			Me.o_o00oO_O.0.().Tag = Nothing
			Me.OO_0o0O.O_O00.().AutoSize = True
			Me.OO_0o0O.O_O00.().Checked = True
			Me.OO_0o0O.O_O00.().Location = New Point(151, 30)
			Me.OO_0o0O.O_O00.().Margin = New Padding(3, 1, 3, 1)
			Me.OO_0o0O.O_O00.().Name = "rdoInline"
			Me.OO_0o0O.O_O00.().Size = New Size(73, 19)
			Me.OO_0o0O.O_O00.().TabIndex = 0
			Me.OO_0o0O.O_O00.().TabStop = True
			Me.OO_0o0O.O_O00.().Text = "内联型"
			Me.OO_0o0O.O_O00.().UseVisualStyleBackColor = True
			Me.o_oO_0o.00_O_0.().AutoSize = True
			Me.o_oO_0o.00_O_0.().Location = New Point(251, 30)
			Me.o_oO_0o.00_O_0.().Margin = New Padding(3, 1, 3, 1)
			Me.o_oO_0o.00_O_0.().Name = "rdoLayers"
			Me.o_oO_0o.00_O_0.().Size = New Size(73, 19)
			Me.o_oO_0o.00_O_0.().TabIndex = 1
			Me.o_oO_0o.00_O_0.().Text = "层级型"
			Me.o_oO_0o.00_O_0.().UseVisualStyleBackColor = True
			Me.O.o_0o_.().AutoSize = True
			Me.O.o_0o_.().Location = New Point(33, 31)
			Me.O.o_0o_.().Name = "Label3"
			Me.O.o_0o_.().Size = New Size(90, 15)
			Me.O.o_0o_.().TabIndex = 24
			Me.O.o_0o_.().Text = "折叠表类型:"
			Me.o_oO_0o.00_O_0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_oO_0o.00_O_0.().Controls.Add(Me.OO_.oOoO0.())
			Me.o_oO_0o.00_O_0.().Controls.Add(Me.o_o00oO_O.0.())
			Me.o_oO_0o.00_O_0.().Controls.Add(Me.o_0O0.O0.())
			Me.o_oO_0o.00_O_0.().Controls.Add(Me.O._0oo.())
			Me.o_oO_0o.00_O_0.().Location = New Point(0, 104)
			Me.o_oO_0o.00_O_0.().Margin = New Padding(3, 1, 3, 1)
			Me.o_oO_0o.00_O_0.().Name = "Panel1"
			Me.o_oO_0o.00_O_0.().Size = New Size(465, 71)
			Me.o_oO_0o.00_O_0.().TabIndex = 3
			Me.OO_0o0O.O_O00.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OO_0o0O.O_O00.().Controls.Add(Me.oO.00_.())
			Me.OO_0o0O.O_O00.().Controls.Add(Me.OO.0Ooo0OO0O.())
			Me.OO_0o0O.O_O00.().Controls.Add(Me.o.__o_0___.())
			Me.OO_0o0O.O_O00.().Controls.Add(Me.o.o0OO.())
			Me.OO_0o0O.O_O00.().Controls.Add(Me.O_00OOO.o0O.())
			Me.OO_0o0O.O_O00.().Controls.Add(Me.o_o_000o_.Oo.())
			Me.OO_0o0O.O_O00.().Location = New Point(12, 104)
			Me.OO_0o0O.O_O00.().Margin = New Padding(3, 1, 3, 1)
			Me.OO_0o0O.O_O00.().Name = "Panel2"
			Me.OO_0o0O.O_O00.().Size = New Size(465, 104)
			Me.OO_0o0O.O_O00.().TabIndex = 4
			Me.OO_0o0O.O_O00.().Visible = False
			Me.oO.00_.().Location = New Point(135, 76)
			Me.oO.00_.().Margin = New Padding(3, 1, 3, 1)
			Me.oO.00_.().Name = "txtLengths"
			Me.oO.00_.().Size = New Size(160, 23)
			Me.oO.00_.().TabIndex = 2
			Me.oO.00_.().Tag = Nothing
			Me.oO.00_.().Value = ""
			Me.OO.0Ooo0OO0O.().AutoSize = True
			Me.OO.0Ooo0OO0O.().Location = New Point(28, 78)
			Me.OO.0Ooo0OO0O.().Margin = New Padding(3, 1, 3, 1)
			Me.OO.0Ooo0OO0O.().Name = "rdoLens"
			Me.OO.0Ooo0OO0O.().Size = New Size(96, 19)
			Me.OO.0Ooo0OO0O.().TabIndex = 25
			Me.OO.0Ooo0OO0O.().TabStop = True
			Me.OO.0Ooo0OO0O.().Text = "长度分割:"
			Me.OO.0Ooo0OO0O.().UseVisualStyleBackColor = True
			Me.o.__o_0___.().AutoSize = True
			Me.o.__o_0___.().Checked = True
			Me.o.__o_0___.().Location = New Point(28, 40)
			Me.o.__o_0___.().Margin = New Padding(3, 1, 3, 1)
			Me.o.__o_0___.().Name = "raoSep"
			Me.o.__o_0___.().Size = New Size(96, 19)
			Me.o.__o_0___.().TabIndex = 0
			Me.o.__o_0___.().TabStop = True
			Me.o.__o_0___.().Text = "符号分割:"
			Me.o.__o_0___.().UseVisualStyleBackColor = True
			Me.o.o0OO.().Font = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.o.o0OO.().Location = New Point(135, 39)
			Me.o.o0OO.().Margin = New Padding(3, 1, 3, 1)
			Me.o.o0OO.().Name = "txtSeparator"
			Me.o.o0OO.().Size = New Size(160, 25)
			Me.o.o0OO.().TabIndex = 1
			Me.o.o0OO.().Tag = Nothing
			Me.o.o0OO.().Value = "\"
			Me.O_00OOO.o0O.().AutoSize = True
			Me.O_00OOO.o0O.().Location = New Point(21, 5)
			Me.O_00OOO.o0O.().Name = "Label4"
			Me.O_00OOO.o0O.().Size = New Size(60, 15)
			Me.O_00OOO.o0O.().TabIndex = 22
			Me.O_00OOO.o0O.().Text = "层级列:"
			Me.o_o_000o_.Oo.().AllowSpinLoop = False
			Me.o_o_000o_.Oo.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.o_o_000o_.Oo.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.o_o_000o_.Oo.().Cursor = Cursors.Arrow
			Me.o_o_000o_.Oo.().DropDownStyle = 1
			Me.o_o_000o_.Oo.().GapHeight = 0
			Me.o_o_000o_.Oo.().ImagePadding = New Padding(0)
			Me.o_o_000o_.Oo.().ItemsDisplayMember = ""
			Me.o_o_000o_.Oo.().ItemsValueMember = ""
			Me.o_o_000o_.Oo.().Location = New Point(96, 0)
			Me.o_o_000o_.Oo.().Margin = New Padding(4, 4, 4, 4)
			Me.o_o_000o_.Oo.().Name = "cmbPathCol"
			Me.o_o_000o_.Oo.().Size = New Size(321, 23)
			Me.o_o_000o_.Oo.().TabIndex = 0
			Me.o_o_000o_.Oo.().Tag = Nothing
			Me.oO00_o_.Oo_.().AutoSize = True
			Me.oO00_o_.Oo_.().Location = New Point(215, 69)
			Me.oO00_o_.Oo_.().Name = "Label5"
			Me.oO00_o_.Oo_.().Size = New Size(22, 15)
			Me.oO00_o_.Oo_.().TabIndex = 29
			Me.oO00_o_.Oo_.().Text = "级"
			Me.o_O_.__o.().DataType = GetType(Integer)
			Me.o_O_.__o.().Location = New Point(151, 66)
			Me.o_O_.__o.().Margin = New Padding(4, 4, 4, 4)
			Me.o_O_.__o.().Name = "txtLevel"
			Me.o_O_.__o.().Size = New Size(57, 23)
			Me.o_O_.__o.().TabIndex = 3
			Me.o_O_.__o.().Tag = Nothing
			Me.o_O_.__o.().TextAlign = HorizontalAlignment.Center
			Me.o_O_.__o.().Value = 0
			Me.ooO._oO_.().AutoSize = True
			Me.ooO._oO_.().Location = New Point(33, 70)
			Me.ooO._oO_.().Name = "Label6"
			Me.ooO._oO_.().Size = New Size(90, 15)
			Me.ooO._oO_.().TabIndex = 30
			Me.ooO._oO_.().Text = "默认展开到:"
			Me.O_00OOO.o0O.().AllowSpinLoop = False
			Me.O_00OOO.o0O.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O_00OOO.o0O.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O_00OOO.o0O.().Cursor = Cursors.Arrow
			Me.O_00OOO.o0O.().DropDownStyle = 1
			Me.O_00OOO.o0O.().GapHeight = 0
			Me.O_00OOO.o0O.().ImagePadding = New Padding(0)
			Me.O_00OOO.o0O.().ItemsDisplayMember = ""
			Me.O_00OOO.o0O.().ItemsValueMember = ""
			Me.O_00OOO.o0O.().Location = New Point(108, 190)
			Me.O_00OOO.o0O.().Margin = New Padding(4, 4, 4, 4)
			Me.O_00OOO.o0O.().Name = "cmbTreeCol"
			Me.O_00OOO.o0O.().Size = New Size(321, 23)
			Me.O_00OOO.o0O.().TabIndex = 7
			Me.O_00OOO.o0O.().Tag = Nothing
			Me.O0_0000.o.().AutoSize = True
			Me.O0_0000.o.().Location = New Point(33, 194)
			Me.O0_0000.o.().Name = "lblTree"
			Me.O0_0000.o.().Size = New Size(60, 15)
			Me.O0_0000.o.().TabIndex = 21
			Me.O0_0000.o.().Text = "树位置:"
			Me.o00oo.o_.().AutoSize = True
			Me.o00oo.o_.().Location = New Point(351, 30)
			Me.o00oo.o_.().Margin = New Padding(3, 1, 3, 1)
			Me.o00oo.o_.().Name = "rdoGroup"
			Me.o00oo.o_.().Size = New Size(73, 19)
			Me.o00oo.o_.().TabIndex = 2
			Me.o00oo.o_.().Text = "分组型"
			Me.o00oo.o_.().UseVisualStyleBackColor = True
			Me.oO.O__0.().Font = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oO.O__0.().Location = New Point(108, 112)
			Me.oO.O__0.().Margin = New Padding(4, 4, 4, 4)
			Me.oO.O__0.().Name = "cmbGroups"
			Me.oO.O__0.().Size = New Size(321, 35)
			Me.oO.O__0.().Styles.CheckList.Font = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oO.O__0.().TabIndex = 32
			Me.oO.O__0.().Visible = False
			Me.oO__.oo000O0o0.().AutoSize = True
			Me.oO__.oo000O0o0.().Location = New Point(33, 122)
			Me.oO__.oo000O0o0.().Margin = New Padding(4, 0, 4, 0)
			Me.oO__.oo000O0o0.().Name = "lblGroup"
			Me.oO__.oo000O0o0.().Size = New Size(60, 15)
			Me.oO__.oo000O0o0.().TabIndex = 33
			Me.oO__.oo000O0o0.().Text = "分组列:"
			Me.oO__.oo000O0o0.().Visible = False
			Me.O_.000__O_0o.().AllowSpinLoop = False
			Me.O_.000__O_0o.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O_.000__O_0o.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O_.000__O_0o.().Cursor = Cursors.Arrow
			Me.O_.000__O_0o.().DropDownStyle = 1
			Me.O_.000__O_0o.().GapHeight = 0
			Me.O_.000__O_0o.().ImagePadding = New Padding(0)
			Me.O_.000__O_0o.().ItemsDisplayMember = ""
			Me.O_.000__O_0o.().ItemsValueMember = ""
			Me.O_.000__O_0o.().Location = New Point(108, 231)
			Me.O_.000__O_0o.().Margin = New Padding(4, 4, 4, 4)
			Me.O_.000__O_0o.().Name = "cmbSortCols"
			Me.O_.000__O_0o.().Size = New Size(321, 23)
			Me.O_.000__O_0o.().TabIndex = 34
			Me.O_.000__O_0o.().Tag = Nothing
			Me.o.__o_0___.().AutoSize = True
			Me.o.__o_0___.().Location = New Point(33, 236)
			Me.o.__o_0___.().Name = "lblSort"
			Me.o.__o_0___.().Size = New Size(60, 15)
			Me.o.__o_0___.().TabIndex = 35
			Me.o.__o_0___.().Text = "排序列:"
			Me.oO.O__0.().BorderStyle = BorderStyle.None
			Me.oO.O__0.().Location = New Point(365, 62)
			Me.oO.O__0.().Margin = New Padding(4, 4, 4, 4)
			Me.oO.O__0.().Name = "chkSortDesc"
			Me.oO.O__0.().Size = New Size(73, 30)
			Me.oO.O__0.().TabIndex = 5
			Me.oO.O__0.().Text = "降序"
			Me.oO.O__0.().UseVisualStyleBackColor = True
			Me.oO.O__0.().Value = Nothing
			Me.O0_.o_o_.().AutoSize = True
			Me.O0_.o_o_.().Location = New Point(33, 285)
			Me.O0_.o_o_.().Margin = New Padding(4, 0, 4, 0)
			Me.O0_.o_o_.().Name = "lblValueCols"
			Me.O0_.o_o_.().Size = New Size(60, 15)
			Me.O0_.o_o_.().TabIndex = 38
			Me.O0_.o_o_.().Text = "统计列:"
			Me.oO__.oo000O0o0.().Font = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oO__.oo000O0o0.().Location = New Point(108, 275)
			Me.oO__.oo000O0o0.().Margin = New Padding(4, 4, 4, 4)
			Me.oO__.oo000O0o0.().Name = "cmbValueCols"
			Me.oO__.oo000O0o0.().Size = New Size(321, 35)
			Me.oO__.oo000O0o0.().Styles.CheckList.Font = New Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oO__.oo000O0o0.().TabIndex = 37
			Me.o_0O0.O0.().BorderStyle = BorderStyle.None
			Me.o_0O0.O0.().Location = New Point(282, 62)
			Me.o_0O0.O0.().Margin = New Padding(4)
			Me.o_0O0.O0.().Name = "chkStyle"
			Me.o_0O0.O0.().Size = New Size(73, 30)
			Me.o_0O0.O0.().TabIndex = 4
			Me.o_0O0.O0.().Text = "样式"
			Me.o_0O0.O0.().UseVisualStyleBackColor = True
			Me.o_0O0.O0.().Value = Nothing
			MyBase.AutoScaleDimensions = New SizeF(8F, 15F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(471, 436)
			MyBase.Controls.Add(Me.o_0O0.O0.())
			MyBase.Controls.Add(Me.O0_.o_o_.())
			MyBase.Controls.Add(Me.oO__.oo000O0o0.())
			MyBase.Controls.Add(Me.oO.O__0.())
			MyBase.Controls.Add(Me.O_.000__O_0o.())
			MyBase.Controls.Add(Me.o.__o_0___.())
			MyBase.Controls.Add(Me.oO__.oo000O0o0.())
			MyBase.Controls.Add(Me.oO.O__0.())
			MyBase.Controls.Add(Me.o00oo.o_.())
			MyBase.Controls.Add(Me.O_00OOO.o0O.())
			MyBase.Controls.Add(Me.O0_0000.o.())
			MyBase.Controls.Add(Me.ooO._oO_.())
			MyBase.Controls.Add(Me.oO00_o_.Oo_.())
			MyBase.Controls.Add(Me.o_O_.__o.())
			MyBase.Controls.Add(Me.O.o_0o_.())
			MyBase.Controls.Add(Me.o_oO_0o.00_O_0.())
			MyBase.Controls.Add(Me.OO_0o0O.O_O00.())
			MyBase.Controls.Add(Me.oO.O__0.())
			MyBase.Controls.Add(Me.o_0O0.O0.())
			MyBase.Controls.Add(Me.o_oO_0o.00_O_0.())
			MyBase.Controls.Add(Me.OO_0o0O.O_O00.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO...0.."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置折叠模式"
			Me.oO.O__0.().EndInit()
			Me.o_0O0.O0.().EndInit()
			Me.o_0O0.O0.().EndInit()
			Me.o_o00oO_O.0.().EndInit()
			Me.o_oO_0o.00_O_0.().ResumeLayout(False)
			Me.o_oO_0o.00_O_0.().PerformLayout()
			Me.OO_0o0O.O_O00.().ResumeLayout(False)
			Me.OO_0o0O.O_O00.().PerformLayout()
			Me.oO.00_.().EndInit()
			Me.o.o0OO.().EndInit()
			Me.o_o_000o_.Oo.().EndInit()
			Me.o_O_.__o.().EndInit()
			Me.O_00OOO.o0O.().EndInit()
			Me.O_.000__O_0o.().EndInit()
			Me.oO.O__0.().EndInit()
			Me.o_0O0.O0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06000B6D RID: 2925 RVA: 0x000539AC File Offset: 0x00051BAC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOo.O___.
		End Function

		' Token: 0x06000B6E RID: 2926 RVA: 0x000539B4 File Offset: 0x00051BB4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OOo.O___. = A_0
		End Sub

		' Token: 0x06000B6F RID: 2927 RVA: 0x000539BD File Offset: 0x00051BBD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0._0oo0O__.
		End Function

		' Token: 0x06000B70 RID: 2928 RVA: 0x000539C8 File Offset: 0x00051BC8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOO_.o_0O.
			Dim o0._0oo0O__. As C1Button = Me.O0._0oo0O__.
			If o0._0oo0O__. IsNot Nothing Then
				RemoveHandler o0._0oo0O__..Click, value
			End If
			Me.O0._0oo0O__. = A_0
			o0._0oo0O__. = Me.O0._0oo0O__.
			If o0._0oo0O__. IsNot Nothing Then
				AddHandler o0._0oo0O__..Click, value
			End If
		End Sub

		' Token: 0x06000B71 RID: 2929 RVA: 0x00053A0B File Offset: 0x00051C0B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O___._0O.
		End Function

		' Token: 0x06000B72 RID: 2930 RVA: 0x00053A13 File Offset: 0x00051C13
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O___._0O. = A_0
		End Sub

		' Token: 0x06000B73 RID: 2931 RVA: 0x00053A1C File Offset: 0x00051C1C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OoOoO0.o00.
		End Function

		' Token: 0x06000B74 RID: 2932 RVA: 0x00053A24 File Offset: 0x00051C24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OoOoO0.o00. = A_0
		End Sub

		' Token: 0x06000B75 RID: 2933 RVA: 0x00053A2D File Offset: 0x00051C2D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0oo0o._0.
		End Function

		' Token: 0x06000B76 RID: 2934 RVA: 0x00053A35 File Offset: 0x00051C35
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o0oo0o._0. = A_0
		End Sub

		' Token: 0x06000B77 RID: 2935 RVA: 0x00053A3E File Offset: 0x00051C3E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.OoOoO0.o00.
		End Function

		' Token: 0x06000B78 RID: 2936 RVA: 0x00053A46 File Offset: 0x00051C46
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.OoOoO0.o00. = A_0
		End Sub

		' Token: 0x06000B79 RID: 2937 RVA: 0x00053A4F File Offset: 0x00051C4F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Oo._0o0o0o_.
		End Function

		' Token: 0x06000B7A RID: 2938 RVA: 0x00053A58 File Offset: 0x00051C58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o._oo0O0O.
			Dim oo._0o0o0o_. As RadioButton = Me.Oo._0o0o0o_.
			If oo._0o0o0o_. IsNot Nothing Then
				RemoveHandler oo._0o0o0o_..CheckedChanged, value
			End If
			Me.Oo._0o0o0o_. = A_0
			oo._0o0o0o_. = Me.Oo._0o0o0o_.
			If oo._0o0o0o_. IsNot Nothing Then
				AddHandler oo._0o0o0o_..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000B7B RID: 2939 RVA: 0x00053A9B File Offset: 0x00051C9B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o._oo_O00__.
		End Function

		' Token: 0x06000B7C RID: 2940 RVA: 0x00053AA4 File Offset: 0x00051CA4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.o._oo0O0O.
			Dim radioButton As RadioButton = Me.o._oo_O00__.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o._oo_O00__. = A_0
			radioButton = Me.o._oo_O00__.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000B7D RID: 2941 RVA: 0x00053AE7 File Offset: 0x00051CE7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.ooOOOO_.
		End Function

		' Token: 0x06000B7E RID: 2942 RVA: 0x00053AEF File Offset: 0x00051CEF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.ooOOOO_. = A_0
		End Sub

		' Token: 0x06000B7F RID: 2943 RVA: 0x00053AF8 File Offset: 0x00051CF8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.O___._0O.
		End Function

		' Token: 0x06000B80 RID: 2944 RVA: 0x00053B00 File Offset: 0x00051D00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.O___._0O. = A_0
		End Sub

		' Token: 0x06000B81 RID: 2945 RVA: 0x00053B09 File Offset: 0x00051D09
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.o._oo_O00__.
		End Function

		' Token: 0x06000B82 RID: 2946 RVA: 0x00053B11 File Offset: 0x00051D11
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.o._oo_O00__. = A_0
		End Sub

		' Token: 0x06000B83 RID: 2947 RVA: 0x00053B1A File Offset: 0x00051D1A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo._0o0o0o_.
		End Function

		' Token: 0x06000B84 RID: 2948 RVA: 0x00053B22 File Offset: 0x00051D22
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Oo._0o0o0o_. = A_0
		End Sub

		' Token: 0x06000B85 RID: 2949 RVA: 0x00053B2B File Offset: 0x00051D2B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_ooo0o_0.o.
		End Function

		' Token: 0x06000B86 RID: 2950 RVA: 0x00053B34 File Offset: 0x00051D34
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oO.00_.
			Dim o_ooo0o_0.o. As RadioButton = Me.O_ooo0o_0.o.
			If o_ooo0o_0.o. IsNot Nothing Then
				RemoveHandler o_ooo0o_0.o..CheckedChanged, value
			End If
			Me.O_ooo0o_0.o. = A_0
			o_ooo0o_0.o. = Me.O_ooo0o_0.o.
			If o_ooo0o_0.o. IsNot Nothing Then
				AddHandler o_ooo0o_0.o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000B87 RID: 2951 RVA: 0x00053B77 File Offset: 0x00051D77
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_O._0_O0.
		End Function

		' Token: 0x06000B88 RID: 2952 RVA: 0x00053B80 File Offset: 0x00051D80
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oO.00_.
			Dim o_O._0_O0. As RadioButton = Me.O_O._0_O0.
			If o_O._0_O0. IsNot Nothing Then
				RemoveHandler o_O._0_O0..CheckedChanged, value
			End If
			Me.O_O._0_O0. = A_0
			o_O._0_O0. = Me.O_O._0_O0.
			If o_O._0_O0. IsNot Nothing Then
				AddHandler o_O._0_O0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000B89 RID: 2953 RVA: 0x00053BC3 File Offset: 0x00051DC3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o._oo_O00__.
		End Function

		' Token: 0x06000B8A RID: 2954 RVA: 0x00053BCB File Offset: 0x00051DCB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o._oo_O00__. = A_0
		End Sub

		' Token: 0x06000B8B RID: 2955 RVA: 0x00053BD4 File Offset: 0x00051DD4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO__O00.0O_0_.
		End Function

		' Token: 0x06000B8C RID: 2956 RVA: 0x00053BDC File Offset: 0x00051DDC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO__O00.0O_0_. = A_0
		End Sub

		' Token: 0x06000B8D RID: 2957 RVA: 0x00053BE5 File Offset: 0x00051DE5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.OOo0o0o0O.o0oo.
		End Function

		' Token: 0x06000B8E RID: 2958 RVA: 0x00053BED File Offset: 0x00051DED
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.OOo0o0o0O.o0oo. = A_0
		End Sub

		' Token: 0x06000B8F RID: 2959 RVA: 0x00053BF6 File Offset: 0x00051DF6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0O_.000_0.
		End Function

		' Token: 0x06000B90 RID: 2960 RVA: 0x00053BFE File Offset: 0x00051DFE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0O_.000_0. = A_0
		End Sub

		' Token: 0x06000B91 RID: 2961 RVA: 0x00053C07 File Offset: 0x00051E07
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_ooo0o_0.o.
		End Function

		' Token: 0x06000B92 RID: 2962 RVA: 0x00053C0F File Offset: 0x00051E0F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_ooo0o_0.o. = A_0
		End Sub

		' Token: 0x06000B93 RID: 2963 RVA: 0x00053C18 File Offset: 0x00051E18
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0OO_.o_0o_.
		End Function

		' Token: 0x06000B94 RID: 2964 RVA: 0x00053C20 File Offset: 0x00051E20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0OO_.o_0o_. = A_0
		End Sub

		' Token: 0x06000B95 RID: 2965 RVA: 0x00053C29 File Offset: 0x00051E29
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O0__oo_.o.
		End Function

		' Token: 0x06000B96 RID: 2966 RVA: 0x00053C31 File Offset: 0x00051E31
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O0__oo_.o. = A_0
		End Sub

		' Token: 0x06000B97 RID: 2967 RVA: 0x00053C3A File Offset: 0x00051E3A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.Oooo.
		End Function

		' Token: 0x06000B98 RID: 2968 RVA: 0x00053C42 File Offset: 0x00051E42
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.Oooo. = A_0
		End Sub

		' Token: 0x06000B99 RID: 2969 RVA: 0x00053C4B File Offset: 0x00051E4B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0oO0_oO_.0_.
		End Function

		' Token: 0x06000B9A RID: 2970 RVA: 0x00053C53 File Offset: 0x00051E53
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0oO0_oO_.0_. = A_0
		End Sub

		' Token: 0x06000B9B RID: 2971 RVA: 0x00053C5C File Offset: 0x00051E5C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1MultiSelect
			Return Me.o0oo0o._0.
		End Function

		' Token: 0x06000B9C RID: 2972 RVA: 0x00053C64 File Offset: 0x00051E64
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1MultiSelect)
			Me.o0oo0o._0. = A_0
		End Sub

		' Token: 0x06000B9D RID: 2973 RVA: 0x00053C6D File Offset: 0x00051E6D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.oO0_ooo_.
		End Function

		' Token: 0x06000B9E RID: 2974 RVA: 0x00053C75 File Offset: 0x00051E75
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.oO0_ooo_. = A_0
		End Sub

		' Token: 0x06000B9F RID: 2975 RVA: 0x00053C7E File Offset: 0x00051E7E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O.0OO0O__OoO.
		End Function

		' Token: 0x06000BA0 RID: 2976 RVA: 0x00053C86 File Offset: 0x00051E86
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.O.0OO0O__OoO. = A_0
		End Sub

		' Token: 0x06000BA1 RID: 2977 RVA: 0x00053C8F File Offset: 0x00051E8F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0_oOooOoo._.
		End Function

		' Token: 0x06000BA2 RID: 2978 RVA: 0x00053C97 File Offset: 0x00051E97
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0_oOooOoo._. = A_0
		End Sub

		' Token: 0x06000BA3 RID: 2979 RVA: 0x00053CA0 File Offset: 0x00051EA0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0oo0o._0.
		End Function

		' Token: 0x06000BA4 RID: 2980 RVA: 0x00053CA8 File Offset: 0x00051EA8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0oo0o._0. = A_0
		End Sub

		' Token: 0x06000BA5 RID: 2981 RVA: 0x00053CB1 File Offset: 0x00051EB1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0Oo__._.
		End Function

		' Token: 0x06000BA6 RID: 2982 RVA: 0x00053CB9 File Offset: 0x00051EB9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0Oo__._. = A_0
		End Sub

		' Token: 0x06000BA7 RID: 2983 RVA: 0x00053CC2 File Offset: 0x00051EC2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1MultiSelect
			Return Me.OoOoO0.o00.
		End Function

		' Token: 0x06000BA8 RID: 2984 RVA: 0x00053CCA File Offset: 0x00051ECA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1MultiSelect)
			Me.OoOoO0.o00. = A_0
		End Sub

		' Token: 0x06000BA9 RID: 2985 RVA: 0x00053CD3 File Offset: 0x00051ED3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.OoOoO0.o00.
		End Function

		' Token: 0x06000BAA RID: 2986 RVA: 0x00053CDB File Offset: 0x00051EDB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.OoOoO0.o00. = A_0
		End Sub

		' Token: 0x06000BAB RID: 2987 RVA: 0x00053CE4 File Offset: 0x00051EE4
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.oO.O__0.
			AddHandler MyBase.FormClosed, AddressOf Me.o_0O0.O0.
			Me.Oo._0o0o0o_. = New Dictionary(Of String, String)()
			Me.O_.0O_O_. = OO_00oOO.MainTable
			Me.o.o0OO.()
			Me.O_.0O_O_. = A_0
		End Sub

		' Token: 0x06000BAC RID: 2988 RVA: 0x00053D40 File Offset: 0x00051F40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_oO_0o.00_O_0.().Visible = Me.OO_0o0O.O_O00.().Checked
			Me.OO_0o0O.O_O00.().Visible = Me.o_oO_0o.00_O_0.().Checked
			Me.O0_0000.o.().Visible = Not Me.o00oo.o_.().Checked
			Me.O_00OOO.o0O.().Visible = Not Me.o00oo.o_.().Checked
			Me.oO__.oo000O0o0.().Visible = Me.o00oo.o_.().Checked
			Me.oO.O__0.().Visible = Me.o00oo.o_.().Checked
			Me.o_0O0.O0.().Visible = Not Me.o00oo.o_.().Checked
			If Me.o00oo.o_.().Checked Then
				Me.O0_.o_o_.().Top = 140
				Me.oO__.oo000O0o0.().Top = 132
				Me.o.__o_0___.().Top = 178
				Me.O_.000__O_0o.().Top = 174
				Return
			End If
			If Me.OO_0o0O.O_O00.().Checked Then
				Me.O0_0000.o.().Top = 155
				Me.O_00OOO.o0O.().Top = 152
				Me.o.__o_0___.().Top = 189
				Me.O_.000__O_0o.().Top = 185
				Me.O0_.o_o_.().Top = 226
				Me.oO__.oo000O0o0.().Top = 218
				Return
			End If
			If Me.o_oO_0o.00_O_0.().Checked Then
				Me.O0_0000.o.().Top = 179
				Me.O_00OOO.o0O.().Top = 176
				Me.o.__o_0___.().Top = 213
				Me.O_.000__O_0o.().Top = 209
				Me.O0_.o_o_.().Top = 250
				Me.oO__.oo000O0o0.().Top = 242
			End If
		End Sub

		' Token: 0x06000BAD RID: 2989 RVA: 0x00053F19 File Offset: 0x00052119
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.o0OO.().Enabled = Me.o.__o_0___.().Checked
			Me.oO.00_.().Enabled = Not Me.o.__o_0___.().Checked
		End Sub

		' Token: 0x06000BAE RID: 2990 RVA: 0x00053F4C File Offset: 0x0005214C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_.0O_O_. = OO_00oOO.MainTable
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o_O_.__o.().Value = Me.O_.0O_O_..o__.O0o.
			Me.oO.00_.().Value = Me.O_.0O_O_..O_OO.oO0_.
			Me.o.o0OO.().Value = Me.O_.0O_O_..oO0.00.
			Me.oO.O__0.().Checked = Me.O_.0O_O_..oO_.ooo0o.
			Me.o_0O0.O0.().Checked = Me.O_.0O_O_..oO._o.
			Me.O_00OOO.o0O.().Items.Add("")
			Me.O_.000__O_0o.().Items.Add("")
			Try
				For Each dataCol As DataCol In Me.O_.0O_O_..DataTable.DataCols
					Dim left As String = ""
					If Operators.CompareString(dataCol.Caption, "", True) > 0 AndAlso Not Me.Oo._0o0o0o_..ContainsKey(dataCol.Caption) Then
						left = dataCol.Caption
						Me.Oo._0o0o0o_..Add(dataCol.Caption, dataCol.Name)
					End If
					Dim array As C1ComboBox() = New C1ComboBox() { Me.o_o00oO_O.0.(), Me.o_0O0.O0.(), Me.o_o_000o_.Oo.(), Me.O_00OOO.o0O.(), Me.O_.000__O_0o.() }
					Dim array2 As String() = New String() { Me.O_.0O_O_..oooo00O.o__0O., Me.O_.0O_O_..O___o0.Oo., Me.O_.0O_O_..O_.oOoOO0o., Me.O_.0O_O_..O000__.o_ooo_O., Me.O_.0O_O_..O0_O.0oOO0Oo0. }
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						If(array(i) <> Me.O_.0O_O_..O_.oOoOO0o. OrElse dataCol.DataType Is GetType(String)) AndAlso (array(i) = Me.O_.000__O_0o.() OrElse array(i) = Me.O_00OOO.o0O.() OrElse o_O_o_oOoo__.OOOO_OO._oo.(dataCol.BaseColumn.DataType)) Then
							Dim c1ComboBox As C1ComboBox = array(i)
							If Operators.CompareString(left, "", True) > 0 Then
								c1ComboBox.Items.Add(dataCol.Caption)
							Else
								c1ComboBox.Items.Add(dataCol.Name)
							End If
							If Operators.CompareString(array2(i), dataCol.Name, True) = 0 Then
								c1ComboBox.SelectedIndex = c1ComboBox.Items.Count - 1
							End If
						End If
					Next
					If dataCol.IsString OrElse dataCol.IsNumeric Then
						Dim c1CheckListItem As C1CheckListItem = New C1CheckListItem()
						If Operators.CompareString(left, "", True) > 0 Then
							c1CheckListItem.Value = dataCol.Caption
						Else
							c1CheckListItem.Value = dataCol.Name
						End If
						If o_O_o_oOoo__.OOOO_OO._oo.(dataCol.DataType) Then
							Me.oO.O__0.().Items.Add(c1CheckListItem)
						End If
						If dataCol.IsNumeric Then
							Dim c1CheckListItem2 As C1CheckListItem = New C1CheckListItem(RuntimeHelpers.GetObjectValue(c1CheckListItem.Value))
							Me.oO__.oo000O0o0.().Items.Add(c1CheckListItem2)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			If Operators.CompareString(Me.O_.0O_O_..O_.oOoOO0o., "", True) > 0 Then
				Me.o_oO_0o.00_O_0.().Checked = True
				If Operators.CompareString(Me.O_.0O_O_..oO0.00., "", True) = 0 AndAlso Operators.CompareString(Me.O_.0O_O_..O_OO.oO0_., "", True) > 0 Then
					Me.OO.0Ooo0OO0O.().Checked = True
				End If
			End If
			If Operators.CompareString(Me.O_.0O_O_..o_oO__O.0_., "", True) > 0 Then
				Me.o00oo.o_.().Checked = True
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Me.O_.0O_O_..o_oO__O.0_..Split(New Char() { ","c }))
				Try
					For Each c1CheckListItem3 As C1CheckListItem In Me.oO.O__0.().Items
						If list.Contains(Me.o.o0OO.(c1CheckListItem3.Value.ToString())) Then
							c1CheckListItem3.Selected = True
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of C1CheckListItem)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
			End If
			If Operators.CompareString(Me.O_.0O_O_..oOoo____oo.O0., "", True) > 0 Then
				Dim list2 As List(Of String) = New List(Of String)()
				list2.AddRange(Me.O_.0O_O_..oOoo____oo.O0..Split(New Char() { ","c }))
				Try
					For Each c1CheckListItem4 As C1CheckListItem In Me.oO__.oo000O0o0.().Items
						If list2.Contains(Me.o.o0OO.(c1CheckListItem4.Value.ToString())) Then
							c1CheckListItem4.Selected = True
						End If
					Next
				Finally
					Dim enumerator3 As IEnumerator(Of C1CheckListItem)
					If enumerator3 IsNot Nothing Then
						enumerator3.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000BAF RID: 2991 RVA: 0x00054478 File Offset: 0x00052678
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06000BB0 RID: 2992 RVA: 0x0005448C File Offset: 0x0005268C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = -1
			Dim text As String = ""
			Dim o0_O.0oOO0Oo0. As String = ""
			If Me.O_00OOO.o0O.().SelectedIndex > 0 Then
				text = Me.o.o0OO.(Me.O_00OOO.o0O.().SelectedItem.ToString())
			End If
			If Me.O_.000__O_0o.().SelectedIndex > 0 Then
				o0_O.0oOO0Oo0. = Me.o.o0OO.(Me.O_.000__O_0o.().SelectedItem.ToString())
			End If
			If Me.o_O_.__o.().Value IsNot Nothing Then
				num = Conversions.ToInteger(Me.o_O_.__o.().Value)
			End If
			Me.O_.0O_O_..oooo00O.o__0O. = Nothing
			Me.O_.0O_O_..O___o0.Oo. = Nothing
			Me.O_.0O_O_..O_.oOoOO0o. = Nothing
			Me.O_.0O_O_..O000__.o_ooo_O. = text
			Me.O_.0O_O_..O0_O.0oOO0Oo0. = o0_O.0oOO0Oo0.
			Me.O_.0O_O_..oO0.00. = Nothing
			Me.O_.0O_O_..O_OO.oO0_. = Nothing
			Me.O_.0O_O_..o__.O0o. = num
			Me.O_.0O_O_..o_oO__O.0_. = Nothing
			Me.O_.0O_O_..oOoo____oo.O0. = Nothing
			Me.O_.0O_O_..oO_.ooo0o. = Me.oO.O__0.().Checked
			Me.O_.0O_O_..oO._o. = Me.o_0O0.O0.().Checked
			Dim list As List(Of String) = New List(Of String)()
			Try
				For Each c1CheckListItem As C1CheckListItem In Me.oO__.oo000O0o0.().SelectedItems
					list.Add(Me.o.o0OO.(c1CheckListItem.Value.ToString()))
				Next
			Finally
				Dim enumerator As IEnumerator(Of C1CheckListItem)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim text2 As String = String.Join(",", list)
			If Me.OO_0o0O.O_O00.().Checked Then
				If Me.o_o00oO_O.0.().SelectedIndex > -1 AndAlso Me.o_0O0.O0.().SelectedIndex > -1 Then
					Dim text3 As String = Me.o.o0OO.(Me.o_o00oO_O.0.().SelectedItem.ToString())
					Dim text4 As String = Me.o.o0OO.(Me.o_0O0.O0.().SelectedItem.ToString())
					Me.O_.0O_O_..oooo00O.o__0O. = text3
					Me.O_.0O_O_..O___o0.Oo. = text4
					Me.O_.0O_O_..oOoo____oo.O0. = text2
					Me.O_.0O_O_..OOo0_Oo._OOo.(text3, text4, text, text2, num)
					Me.O_.0O_O_..O_O0.0_o.(num)
					MyBase.DialogResult = DialogResult.OK
					Return
				End If
			ElseIf Me.o_oO_0o.00_O_0.().Checked AndAlso Me.o_o_000o_.Oo.().SelectedIndex > -1 Then
				Dim text5 As String = Me.o.o0OO.(Me.o_o_000o_.Oo.().SelectedItem.ToString())
				Me.O_.0O_O_..O_.oOoOO0o. = text5
				If Me.o.__o_0___.().Checked Then
					If Operators.CompareString(Me.o.o0OO.().Text, "", True) > 0 Then
						Dim c As Char = Me.o.o0OO.().Text(0)
						Me.O_.0O_O_..oO0.00. = Conversions.ToString(c)
						Me.O_.0O_O_..oOoo____oo.O0. = text2
						Me.O_.0O_O_..O_.o__ooo.(text5, text, c, text2, num)
						Me.O_.0O_O_..O_O0.0_o.(num)
						MyBase.DialogResult = DialogResult.OK
						Return
					End If
				ElseIf Me.o_oO_0o.00_O_0.().Checked AndAlso Operators.CompareString(Me.oO.00_.().Text, "", True) > 0 Then
					Dim array As String() = Regex.Split(Me.oO.00_.().Text, "[^\d]+")
					Dim array2 As Integer() = New Integer(array.Length - 1 + 1 - 1) {}
					If array.Length > 0 Then
						Dim num2 As Integer = array.Length - 1
						For i As Integer = 0 To num2
							Dim num3 As Integer
							If Not Integer.TryParse(array(i), num3) Then
								Return
							End If
							array2(i) = num3
						Next
					End If
					If array2.Length > 0 AndAlso array2.Length = array.Length Then
						Me.O_.0O_O_..O_OO.oO0_. = String.Join(Of Integer)(",", array2)
						Me.O_.0O_O_..oOoo____oo.O0. = text2
						Me.O_.0O_O_..OOo0_Oo._OOo.(text5, text, array2, text2, num)
						Me.O_.0O_O_..O_O0.0_o.(num)
						MyBase.DialogResult = DialogResult.OK
						Return
					End If
				End If
			ElseIf Me.o00oo.o_.().Checked And Me.oO.O__0.().SelectedItems.Count > 0 Then
				Dim list2 As List(Of String) = New List(Of String)()
				Try
					For Each c1CheckListItem2 As C1CheckListItem In Me.oO.O__0.().SelectedItems
						list2.Add(c1CheckListItem2.Value.ToString())
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of C1CheckListItem)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
				MyBase.DialogResult = DialogResult.OK
				Application.DoEvents()
				Me.O_.0O_O_..OOo0_Oo._OOo.(list2.ToArray(), text2, Me.O_.0O_O_..O0_O.0oOO0Oo0., Me.O_.0O_O_..oO_.ooo0o., num)
				Me.O_.0O_O_..o_oO__O.0_. = String.Join(",", list2)
				Me.O_.0O_O_..oOoo____oo.O0. = text2
				Me.O_.0O_O_..NeedSaveSetting = True
				Me.O_.0O_O_..oo0OO0Ooo._.(True)
			End If
		End Sub

		' Token: 0x06000BB1 RID: 2993 RVA: 0x00054978 File Offset: 0x00052B78
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If Me.Oo._0o0o0o_..ContainsKey(A_0) Then
				result = Me.Oo._0o0o0o_.(A_0)
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x04000451 RID: 1105
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000452 RID: 1106
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000453 RID: 1107
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000454 RID: 1108
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000455 RID: 1109
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000456 RID: 1110
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000457 RID: 1111
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000458 RID: 1112
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000459 RID: 1113
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400045A RID: 1114
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400045B RID: 1115
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x0400045C RID: 1116
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x0400045D RID: 1117
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400045E RID: 1118
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400045F RID: 1119
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000460 RID: 1120
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000461 RID: 1121
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000462 RID: 1122
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000463 RID: 1123
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000464 RID: 1124
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000465 RID: 1125
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000466 RID: 1126
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000467 RID: 1127
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000468 RID: 1128
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000469 RID: 1129
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1MultiSelect

		' Token: 0x0400046A RID: 1130
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400046B RID: 1131
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400046C RID: 1132
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400046D RID: 1133
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400046E RID: 1134
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400046F RID: 1135
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1MultiSelect

		' Token: 0x04000470 RID: 1136
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000471 RID: 1137
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04000472 RID: 1138
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
