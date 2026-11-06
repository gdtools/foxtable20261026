Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000CD RID: 205
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class h0
		Inherits Form

		' Token: 0x06000938 RID: 2360 RVA: 0x0003FDEF File Offset: 0x0003DFEF
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.oOo_o__o_.0__o.
			AddHandler MyBase.FormClosed, AddressOf Me.oo_o.Oo.
			Me.o0_O.00____. = OO_00oOO.MainTable
			Me.OOoOO_O_.0.()
		End Sub

		' Token: 0x06000939 RID: 2361 RVA: 0x0003FE2C File Offset: 0x0003E02C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0_O.00____. IsNot Nothing Then
					Me.o0_O.00____..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600093A RID: 2362 RVA: 0x0003FE6C File Offset: 0x0003E06C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0_O.00____. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(h0))
			Me.OO0._o.(New C1TextBox())
			Me.o_oOOO.o0oO0.(New Label())
			Me.OO0.O.(New C1ComboBox())
			Me.OO0._o.(New Label())
			Me.O.00__o.(New Label())
			Me.OO___.0.(New C1ComboBox())
			Me.o.O0oO0.(New C1CheckBox())
			Me.o.0__.(New C1Button())
			Me.O00o0._oO.(New C1Button())
			Me.oO_._oO.(New C1CheckBox())
			Me.oO_0Oo.o_.(New C1CheckBox())
			Me.o_oOOO.o0oO0.(New C1TextBox())
			Me.OOO__.0o_o_.(New Label())
			Me.OO0._o.(New C1FlexGrid())
			Me.OO___.0.(New ContextMenuStrip(Me.o0_O.00____.))
			Me.OO0.O.(New ToolStripMenuItem())
			Me.OOO__.0o_o_.(New ToolStripMenuItem())
			Me.o_oOOO.o0oO0.(New ToolStripMenuItem())
			Me.OO0._o.(New ToolStripMenuItem())
			Me.Oo0.0o0_.(New Label())
			Me.O.00__o.(New C1TextBox())
			Me.o.0__.(New C1CheckBox())
			Me.o.o_O_000O.(New C1CheckBox())
			Me.OO0.O.(New C1CheckBox())
			Me.o.0__.(New C1DockingTab())
			Me.O00o0._oO.(New C1DockingTabPage())
			Me.o.0__.(New C1DockingTabPage())
			Me.OO0.O.(New C1FlexGrid())
			Me.oo_.oo00o0.().BeginInit()
			Me.o.0_0__.().BeginInit()
			Me.o00oo_0oo.o.().BeginInit()
			Me.o.0_0__.().BeginInit()
			Me.oo_o.Oo.().BeginInit()
			Me.oO.0_o_o_0_.().BeginInit()
			Me.O_o__0oooO.OOO.().BeginInit()
			Me.O.OO00oO.().BeginInit()
			Me.OOoOO_O_.0.().BeginInit()
			Me.OOoOO_O_.0.().BeginInit()
			Me.O_O.Oo_oO.().SuspendLayout()
			Me.o_.0OO.().BeginInit()
			Me.oO0_00O_oo.0.().BeginInit()
			Me.o00oo_0oo.o.().BeginInit()
			Me.OO0oo0_.0.().BeginInit()
			Me.oo_o.Oo.().BeginInit()
			Me.oo_o.Oo.().SuspendLayout()
			Me.o00oo_0oo.o.().SuspendLayout()
			Me.o.0_0__.().SuspendLayout()
			Me.ooo___o_O_0_.o.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo_.oo00o0.().Location = New Point(65, 24)
			Me.oo_.oo00o0.().Margin = New Padding(3, 1, 3, 1)
			Me.oo_.oo00o0.().Name = "txtName"
			Me.oo_.oo00o0.().Size = New Size(138, 19)
			Me.oo_.oo00o0.().TabIndex = 0
			Me.oo_.oo00o0.().Tag = Nothing
			Me.O_O.Oo_oO.().AutoSize = True
			Me.O_O.Oo_oO.().Location = New Point(21, 27)
			Me.O_O.Oo_oO.().Name = "Label16"
			Me.O_O.Oo_oO.().Size = New Size(35, 12)
			Me.O_O.Oo_oO.().TabIndex = 15
			Me.O_O.Oo_oO.().Text = "表名:"
			Me.o.0_0__.().AllowSpinLoop = False
			Me.o.0_0__.().Cursor = Cursors.Arrow
			Me.o.0_0__.().DropDownStyle = 1
			Me.o.0_0__.().GapHeight = 0
			Me.o.0_0__.().ImagePadding = New Padding(0)
			Me.o.0_0__.().ItemsDisplayMember = ""
			Me.o.0_0__.().ItemsValueMember = ""
			Me.o.0_0__.().Location = New Point(462, 24)
			Me.o.0_0__.().Margin = New Padding(3, 1, 3, 1)
			Me.o.0_0__.().Name = "cmbKeyCol"
			Me.o.0_0__.().Size = New Size(155, 19)
			Me.o.0_0__.().TabIndex = 2
			Me.o.0_0__.().Tag = Nothing
			Me.OO_00_o.__O.().AutoSize = True
			Me.OO_00_o.__O.().Location = New Point(421, 27)
			Me.OO_00_o.__O.().Name = "Label2"
			Me.OO_00_o.__O.().Size = New Size(35, 12)
			Me.OO_00_o.__O.().TabIndex = 2
			Me.OO_00_o.__O.().Text = "子列:"
			Me.o_O.o__O_.().AutoSize = True
			Me.o_O.o__O_.().Location = New Point(216, 27)
			Me.o_O.o__O_.().Name = "Label3"
			Me.o_O.o__O_.().Size = New Size(35, 12)
			Me.o_O.o__O_.().TabIndex = 4
			Me.o_O.o__O_.().Text = "父列:"
			Me.o00oo_0oo.o.().AllowSpinLoop = False
			Me.o00oo_0oo.o.().Cursor = Cursors.Arrow
			Me.o00oo_0oo.o.().DropDownStyle = 1
			Me.o00oo_0oo.o.().GapHeight = 0
			Me.o00oo_0oo.o.().ImagePadding = New Padding(0)
			Me.o00oo_0oo.o.().ItemsDisplayMember = ""
			Me.o00oo_0oo.o.().ItemsValueMember = ""
			Me.o00oo_0oo.o.().Location = New Point(257, 24)
			Me.o00oo_0oo.o.().Margin = New Padding(3, 1, 3, 1)
			Me.o00oo_0oo.o.().Name = "cmbParentCol"
			Me.o00oo_0oo.o.().Size = New Size(155, 19)
			Me.o00oo_0oo.o.().TabIndex = 1
			Me.o00oo_0oo.o.().Tag = "1"
			Me.o.0_0__.().AutoSize = True
			Me.o.0_0__.().BorderStyle = BorderStyle.None
			Me.o.0_0__.().Checked = True
			Me.o.0_0__.().CheckState = CheckState.Checked
			Me.o.0_0__.().Location = New Point(26, 19)
			Me.o.0_0__.().Margin = New Padding(3, 1, 3, 1)
			Me.o.0_0__.().Name = "chkShowTree"
			Me.o.0_0__.().Size = New Size(84, 16)
			Me.o.0_0__.().TabIndex = 4
			Me.o.0_0__.().Text = "显示折叠树"
			Me.o.0_0__.().UseVisualStyleBackColor = True
			Me.o.0_0__.().Value = True
			Me.oo_o.Oo.().DialogResult = DialogResult.Cancel
			Me.oo_o.Oo.().Location = New Point(330, 425)
			Me.oo_o.Oo.().Margin = New Padding(3, 1, 3, 1)
			Me.oo_o.Oo.().Name = "btnCancel"
			Me.oo_o.Oo.().Size = New Size(75, 23)
			Me.oo_o.Oo.().TabIndex = 13
			Me.oo_o.Oo.().Text = "取消"
			Me.oo_o.Oo.().UseVisualStyleBackColor = True
			Me.oO.0_o_o_0_.().Location = New Point(234, 425)
			Me.oO.0_o_o_0_.().Margin = New Padding(3, 1, 3, 1)
			Me.oO.0_o_o_0_.().Name = "Button1"
			Me.oO.0_o_o_0_.().Size = New Size(75, 23)
			Me.oO.0_o_o_0_.().TabIndex = 12
			Me.oO.0_o_o_0_.().Text = "统计"
			Me.oO.0_o_o_0_.().UseVisualStyleBackColor = True
			Me.O_o__0oooO.OOO.().AutoSize = True
			Me.O_o__0oooO.OOO.().BorderStyle = BorderStyle.None
			Me.O_o__0oooO.OOO.().Location = New Point(231, 46)
			Me.O_o__0oooO.OOO.().Margin = New Padding(3, 1, 3, 1)
			Me.O_o__0oooO.OOO.().Name = "chkOnlyGroups"
			Me.O_o__0oooO.OOO.().Size = New Size(96, 16)
			Me.O_o__0oooO.OOO.().TabIndex = 9
			Me.O_o__0oooO.OOO.().Text = "仅保留分组行"
			Me.O_o__0oooO.OOO.().UseVisualStyleBackColor = True
			Me.O_o__0oooO.OOO.().Value = False
			Me.O.OO00oO.().AutoSize = True
			Me.O.OO00oO.().BorderStyle = BorderStyle.None
			Me.O.OO00oO.().Location = New Point(231, 73)
			Me.O.OO00oO.().Margin = New Padding(3, 1, 3, 1)
			Me.O.OO00oO.().Name = "chkPreserveTolevel"
			Me.O.OO00oO.().Size = New Size(60, 16)
			Me.O.OO00oO.().TabIndex = 10
			Me.O.OO00oO.().Text = "保留前"
			Me.O.OO00oO.().UseVisualStyleBackColor = True
			Me.O.OO00oO.().Value = False
			Me.OOoOO_O_.0.().DataType = GetType(Integer)
			Me.OOoOO_O_.0.().Enabled = False
			Me.OOoOO_O_.0.().Location = New Point(295, 72)
			Me.OOoOO_O_.0.().Margin = New Padding(3, 1, 3, 1)
			Me.OOoOO_O_.0.().Name = "txtPreserveTolevel"
			Me.OOoOO_O_.0.().Size = New Size(29, 19)
			Me.OOoOO_O_.0.().TabIndex = 11
			Me.OOoOO_O_.0.().Tag = Nothing
			Me.OOoOO_O_.0.().TextAlign = HorizontalAlignment.Center
			Me.OOoOO_O_.0.().Value = 0
			Me.OOo.o.().AutoSize = True
			Me.OOo.o.().Location = New Point(331, 73)
			Me.OOo.o.().Name = "Label1"
			Me.OOo.o.().Size = New Size(41, 12)
			Me.OOo.o.().TabIndex = 41
			Me.OOo.o.().Text = "级的行"
			Me.OOoOO_O_.0.().AllowDelete = True
			Me.OOoOO_O_.0.().AllowDragging = 0
			Me.OOoOO_O_.0.().AllowMergingFixed = 0
			Me.OOoOO_O_.0.().AllowSorting = 0
			Me.OOoOO_O_.0.().BorderStyle = 4
			Me.OOoOO_O_.0.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo")
			Me.OOoOO_O_.0.().ExtendLastCol = True
			Me.OOoOO_O_.0.().HighLight = 2
			Me.OOoOO_O_.0.().Location = New Point(23, 61)
			Me.OOoOO_O_.0.().Margin = New Padding(3, 2, 3, 2)
			Me.OOoOO_O_.0.().Name = "TotalGrid"
			Me.OOoOO_O_.0.().Rows.Count = 1
			Me.OOoOO_O_.0.().Rows.DefaultSize = 19
			Me.OOoOO_O_.0.().SelectionMode = 3
			Me.OOoOO_O_.0.().ShowThemedHeaders = 1
			Me.OOoOO_O_.0.().Size = New Size(594, 194)
			Me.OOoOO_O_.0.().TabIndex = 3
			Me.O_O.Oo_oO.().Items.AddRange(New ToolStripItem() { Me.o_O.o__O_.(), Me.OO_00_o.__O.(), Me.o_.0OO.(), Me.O_O.Oo_oO.() })
			Me.O_O.Oo_oO.().Name = "ContextMenuStrip1"
			Me.O_O.Oo_oO.().Size = New Size(101, 92)
			Me.o_O.o__O_.().Name = "InsertMenuItem"
			Me.o_O.o__O_.().Size = New Size(100, 22)
			Me.o_O.o__O_.().Text = "插入"
			Me.OO_00_o.__O.().Name = "DeleteMenuItem"
			Me.OO_00_o.__O.().Size = New Size(100, 22)
			Me.OO_00_o.__O.().Text = "删除"
			Me.o_.0OO.().Name = "MoveUpMenuItem"
			Me.o_.0OO.().Size = New Size(100, 22)
			Me.o_.0OO.().Text = "上移"
			Me.O_O.Oo_oO.().Name = "MoveDownMenuItem"
			Me.O_O.Oo_oO.().Size = New Size(100, 22)
			Me.O_O.Oo_oO.().Text = "下移"
			Me.ooo___o_O_0_.o.().AutoSize = True
			Me.ooo___o_O_0_.o.().Location = New Point(143, 46)
			Me.ooo___o_O_0_.o.().Margin = New Padding(2, 0, 2, 0)
			Me.ooo___o_O_0_.o.().Name = "Label5"
			Me.ooo___o_O_0_.o.().Size = New Size(17, 12)
			Me.ooo___o_O_0_.o.().TabIndex = 45
			Me.ooo___o_O_0_.o.().Text = "级"
			Me.o_.0OO.().DataType = GetType(Integer)
			Me.o_.0OO.().Location = New Point(110, 45)
			Me.o_.0OO.().Name = "txtExpandLevel"
			Me.o_.0OO.().Size = New Size(29, 19)
			Me.o_.0OO.().TabIndex = 6
			Me.o_.0OO.().Tag = Nothing
			Me.o_.0OO.().Value = 0
			Me.oO0_00O_oo.0.().AutoSize = True
			Me.oO0_00O_oo.0.().BorderStyle = BorderStyle.None
			Me.oO0_00O_oo.0.().Checked = True
			Me.oO0_00O_oo.0.().CheckState = CheckState.Checked
			Me.oO0_00O_oo.0.().Location = New Point(26, 46)
			Me.oO0_00O_oo.0.().Margin = New Padding(2, 1, 2, 1)
			Me.oO0_00O_oo.0.().Name = "chkAutoExpand"
			Me.oO0_00O_oo.0.().Size = New Size(84, 16)
			Me.oO0_00O_oo.0.().TabIndex = 5
			Me.oO0_00O_oo.0.().Text = "默认展开到"
			Me.oO0_00O_oo.0.().UseVisualStyleBackColor = True
			Me.oO0_00O_oo.0.().Value = True
			Me.o00oo_0oo.o.().AutoSize = True
			Me.o00oo_0oo.o.().BorderStyle = BorderStyle.None
			Me.o00oo_0oo.o.().Location = New Point(231, 19)
			Me.o00oo_0oo.o.().Margin = New Padding(3, 1, 3, 1)
			Me.o00oo_0oo.o.().Name = "chkIncludeParentCol"
			Me.o00oo_0oo.o.().Size = New Size(84, 16)
			Me.o00oo_0oo.o.().TabIndex = 8
			Me.o00oo_0oo.o.().Text = "包括父健列"
			Me.o00oo_0oo.o.().UseVisualStyleBackColor = True
			Me.o00oo_0oo.o.().Value = False
			Me.OO0oo0_.0.().AutoSize = True
			Me.OO0oo0_.0.().BorderStyle = BorderStyle.None
			Me.OO0oo0_.0.().Location = New Point(26, 73)
			Me.OO0oo0_.0.().Margin = New Padding(3, 1, 3, 1)
			Me.OO0oo0_.0.().Name = "chkShowTreeInParentCol"
			Me.OO0oo0_.0.().Size = New Size(132, 16)
			Me.OO0oo0_.0.().TabIndex = 7
			Me.OO0oo0_.0.().Text = "在父健列显示折叠树"
			Me.OO0oo0_.0.().UseVisualStyleBackColor = True
			Me.OO0oo0_.0.().Value = False
			Me.oo_o.Oo.().Controls.Add(Me.o00oo_0oo.o.())
			Me.oo_o.Oo.().Controls.Add(Me.o.0_0__.())
			Me.oo_o.Oo.().Location = New Point(23, 270)
			Me.oo_o.Oo.().Name = "C1DockingTab1"
			Me.oo_o.Oo.().Size = New Size(594, 134)
			Me.oo_o.Oo.().TabIndex = 46
			Me.oo_o.Oo.().TabsSpacing = 5
			Me.o00oo_0oo.o.().Controls.Add(Me.o.0_0__.())
			Me.o00oo_0oo.o.().Controls.Add(Me.O_o__0oooO.OOO.())
			Me.o00oo_0oo.o.().Controls.Add(Me.OO0oo0_.0.())
			Me.o00oo_0oo.o.().Controls.Add(Me.O.OO00oO.())
			Me.o00oo_0oo.o.().Controls.Add(Me.o00oo_0oo.o.())
			Me.o00oo_0oo.o.().Controls.Add(Me.OOoOO_O_.0.())
			Me.o00oo_0oo.o.().Controls.Add(Me.ooo___o_O_0_.o.())
			Me.o00oo_0oo.o.().Controls.Add(Me.OOo.o.())
			Me.o00oo_0oo.o.().Controls.Add(Me.o_.0OO.())
			Me.o00oo_0oo.o.().Controls.Add(Me.oO0_00O_oo.0.())
			Me.o00oo_0oo.o.().Location = New Point(1, 25)
			Me.o00oo_0oo.o.().Name = "C1DockingTabPage1"
			Me.o00oo_0oo.o.().Size = New Size(592, 108)
			Me.o00oo_0oo.o.().TabIndex = 0
			Me.o00oo_0oo.o.().Text = "选项"
			Me.o.0_0__.().Controls.Add(Me.ooo___o_O_0_.o.())
			Me.o.0_0__.().Location = New Point(1, 25)
			Me.o.0_0__.().Name = "C1DockingTabPage2"
			Me.o.0_0__.().Size = New Size(592, 108)
			Me.o.0_0__.().TabIndex = 1
			Me.o.0_0__.().Text = "附加列"
			Me.ooo___o_O_0_.o.().AllowDelete = True
			Me.ooo___o_O_0_.o.().AllowDragging = 0
			Me.ooo___o_O_0_.o.().AllowSorting = 0
			Me.ooo___o_O_0_.o.().BorderStyle = 4
			Me.ooo___o_O_0_.o.().ColumnInfo = componentResourceManager.GetString("grdAdditions.ColumnInfo")
			Me.ooo___o_O_0_.o.().Dock = DockStyle.Fill
			Me.ooo___o_O_0_.o.().ExtendLastCol = True
			Me.ooo___o_O_0_.o.().HighLight = 2
			Me.ooo___o_O_0_.o.().Location = New Point(0, 0)
			Me.ooo___o_O_0_.o.().Name = "grdAdditions"
			Me.ooo___o_O_0_.o.().Rows.Count = 1
			Me.ooo___o_O_0_.o.().Rows.DefaultSize = 21
			Me.ooo___o_O_0_.o.().SelectionMode = 3
			Me.ooo___o_O_0_.o.().ShowThemedHeaders = 1
			Me.ooo___o_O_0_.o.().Size = New Size(592, 108)
			Me.ooo___o_O_0_.o.().TabIndex = 17
			Me.ooo___o_O_0_.o.().VisualStyle = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(638, 460)
			MyBase.Controls.Add(Me.oo_o.Oo.())
			MyBase.Controls.Add(Me.OOoOO_O_.0.())
			MyBase.Controls.Add(Me.oo_o.Oo.())
			MyBase.Controls.Add(Me.oO.0_o_o_0_.())
			MyBase.Controls.Add(Me.o00oo_0oo.o.())
			MyBase.Controls.Add(Me.o_O.o__O_.())
			MyBase.Controls.Add(Me.o.0_0__.())
			MyBase.Controls.Add(Me.OO_00_o.__O.())
			MyBase.Controls.Add(Me.oo_.oo00o0.())
			MyBase.Controls.Add(Me.O_O.Oo_oO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(3, 1, 3, 1)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.o.o0..0."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "内联分组统计"
			Me.oo_.oo00o0.().EndInit()
			Me.o.0_0__.().EndInit()
			Me.o00oo_0oo.o.().EndInit()
			Me.o.0_0__.().EndInit()
			Me.oo_o.Oo.().EndInit()
			Me.oO.0_o_o_0_.().EndInit()
			Me.O_o__0oooO.OOO.().EndInit()
			Me.O.OO00oO.().EndInit()
			Me.OOoOO_O_.0.().EndInit()
			Me.OOoOO_O_.0.().EndInit()
			Me.O_O.Oo_oO.().ResumeLayout(False)
			Me.o_.0OO.().EndInit()
			Me.oO0_00O_oo.0.().EndInit()
			Me.o00oo_0oo.o.().EndInit()
			Me.OO0oo0_.0.().EndInit()
			Me.oo_o.Oo.().EndInit()
			Me.oo_o.Oo.().ResumeLayout(False)
			Me.o00oo_0oo.o.().ResumeLayout(False)
			Me.o00oo_0oo.o.().PerformLayout()
			Me.o.0_0__.().ResumeLayout(False)
			Me.ooo___o_O_0_.o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600093B RID: 2363 RVA: 0x0004122D File Offset: 0x0003F42D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O0_00Oo0_._.
		End Function

		' Token: 0x0600093C RID: 2364 RVA: 0x00041235 File Offset: 0x0003F435
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O0_00Oo0_._. = A_0
		End Sub

		' Token: 0x0600093D RID: 2365 RVA: 0x0004123E File Offset: 0x0003F43E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0_00Oo0_._.
		End Function

		' Token: 0x0600093E RID: 2366 RVA: 0x00041246 File Offset: 0x0003F446
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0_00Oo0_._. = A_0
		End Sub

		' Token: 0x0600093F RID: 2367 RVA: 0x0004124F File Offset: 0x0003F44F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_o_ooo.o.
		End Function

		' Token: 0x06000940 RID: 2368 RVA: 0x00041257 File Offset: 0x0003F457
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_o_ooo.o. = A_0
		End Sub

		' Token: 0x06000941 RID: 2369 RVA: 0x00041260 File Offset: 0x0003F460
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO__0O.O.
		End Function

		' Token: 0x06000942 RID: 2370 RVA: 0x00041268 File Offset: 0x0003F468
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO__0O.O. = A_0
		End Sub

		' Token: 0x06000943 RID: 2371 RVA: 0x00041271 File Offset: 0x0003F471
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO_0ooO.O.
		End Function

		' Token: 0x06000944 RID: 2372 RVA: 0x00041279 File Offset: 0x0003F479
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO_0ooO.O. = A_0
		End Sub

		' Token: 0x06000945 RID: 2373 RVA: 0x00041282 File Offset: 0x0003F482
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0.O__o_.
		End Function

		' Token: 0x06000946 RID: 2374 RVA: 0x0004128A File Offset: 0x0003F48A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o0.O__o_. = A_0
		End Sub

		' Token: 0x06000947 RID: 2375 RVA: 0x00041293 File Offset: 0x0003F493
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_o_ooo.o.
		End Function

		' Token: 0x06000948 RID: 2376 RVA: 0x0004129C File Offset: 0x0003F49C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.oo_o.Oo.
			Dim c1CheckBox As C1CheckBox = Me.o_o_ooo.o.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.o_o_ooo.o. = A_0
			c1CheckBox = Me.o_o_ooo.o.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000949 RID: 2377 RVA: 0x000412DF File Offset: 0x0003F4DF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.oo0ooo_0.
		End Function

		' Token: 0x0600094A RID: 2378 RVA: 0x000412E7 File Offset: 0x0003F4E7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_.oo0ooo_0. = A_0
		End Sub

		' Token: 0x0600094B RID: 2379 RVA: 0x000412F0 File Offset: 0x0003F4F0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_oO0ooO.o_oO.
		End Function

		' Token: 0x0600094C RID: 2380 RVA: 0x000412F8 File Offset: 0x0003F4F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.0_Oo.
			Dim o_oO0ooO.o_oO. As C1Button = Me.O_oO0ooO.o_oO.
			If o_oO0ooO.o_oO. IsNot Nothing Then
				RemoveHandler o_oO0ooO.o_oO..Click, value
			End If
			Me.O_oO0ooO.o_oO. = A_0
			o_oO0ooO.o_oO. = Me.O_oO0ooO.o_oO.
			If o_oO0ooO.o_oO. IsNot Nothing Then
				AddHandler o_oO0ooO.o_oO..Click, value
			End If
		End Sub

		' Token: 0x0600094D RID: 2381 RVA: 0x0004133B File Offset: 0x0003F53B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0.O__o_.
		End Function

		' Token: 0x0600094E RID: 2382 RVA: 0x00041343 File Offset: 0x0003F543
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0.O__o_. = A_0
		End Sub

		' Token: 0x0600094F RID: 2383 RVA: 0x0004134C File Offset: 0x0003F54C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0O0O.0O.
		End Function

		' Token: 0x06000950 RID: 2384 RVA: 0x00041354 File Offset: 0x0003F554
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.oO.0_o_o_0_.
			Dim o0O0O.0O. As C1CheckBox = Me.O0O0O.0O.
			If o0O0O.0O. IsNot Nothing Then
				RemoveHandler o0O0O.0O..CheckedChanged, value
			End If
			Me.O0O0O.0O. = A_0
			o0O0O.0O. = Me.O0O0O.0O.
			If o0O0O.0O. IsNot Nothing Then
				AddHandler o0O0O.0O..CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000951 RID: 2385 RVA: 0x00041397 File Offset: 0x0003F597
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO0._OO0_0_o.
		End Function

		' Token: 0x06000952 RID: 2386 RVA: 0x0004139F File Offset: 0x0003F59F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OO0._OO0_0_o. = A_0
		End Sub

		' Token: 0x06000953 RID: 2387 RVA: 0x000413A8 File Offset: 0x0003F5A8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_OOOo._.
		End Function

		' Token: 0x06000954 RID: 2388 RVA: 0x000413B0 File Offset: 0x0003F5B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_OOOo._. = A_0
		End Sub

		' Token: 0x06000955 RID: 2389 RVA: 0x000413B9 File Offset: 0x0003F5B9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O0_00Oo0_._.
		End Function

		' Token: 0x06000956 RID: 2390 RVA: 0x000413C4 File Offset: 0x0003F5C4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o0__O0._0O0_O0.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.O.0OOo_o00.
			Dim validateEditEventHandler As ValidateEditEventHandler = AddressOf Me.o_.oo0ooo_0.
			Dim o0_00Oo0_._. As C1FlexGrid = Me.O0_00Oo0_._.
			If o0_00Oo0_._. IsNot Nothing Then
				o0_00Oo0_._..BeforeEdit -= rowColEventHandler
				o0_00Oo0_._..AfterEdit -= rowColEventHandler2
				o0_00Oo0_._..ValidateEdit -= validateEditEventHandler
			End If
			Me.O0_00Oo0_._. = A_0
			o0_00Oo0_._. = Me.O0_00Oo0_._.
			If o0_00Oo0_._. IsNot Nothing Then
				o0_00Oo0_._..BeforeEdit += rowColEventHandler
				o0_00Oo0_._..AfterEdit += rowColEventHandler2
				o0_00Oo0_._..ValidateEdit += validateEditEventHandler
			End If
		End Sub

		' Token: 0x06000957 RID: 2391 RVA: 0x0004143D File Offset: 0x0003F63D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.o_o_ooo.o.
		End Function

		' Token: 0x06000958 RID: 2392 RVA: 0x00041445 File Offset: 0x0003F645
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.o_o_ooo.o. = A_0
		End Sub

		' Token: 0x06000959 RID: 2393 RVA: 0x00041450 File Offset: 0x0003F650
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o_o_ooo.o.
		End Function

		' Token: 0x0600095A RID: 2394 RVA: 0x00041464 File Offset: 0x0003F664
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oo_.oo00o0.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o_o_ooo.o.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
						Case 1
							GoTo IL_62
						Case 2
							Return
						Case 3
							AddHandler toolStripMenuItem.Click, value
							num = 2
							Continue For
						Case 4
							If True Then
							End If
							If toolStripMenuItem IsNot Nothing Then
								num = 5
								Continue For
							End If
							GoTo IL_62
						Case 5
							RemoveHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
					End Select
					Exit For
					IL_62:
					Me.o_o_ooo.o. = A_0
					toolStripMenuItem = Me.o_o_ooo.o.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x0600095B RID: 2395 RVA: 0x00041510 File Offset: 0x0003F710
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o0.O__o_.
		End Function

		' Token: 0x0600095C RID: 2396 RVA: 0x00041524 File Offset: 0x0003F724
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o0._0ooO_0o.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o0.O__o_.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							RemoveHandler toolStripMenuItem.Click, value
							num = 2
							Continue For
						Case 1
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 2
							GoTo IL_62
						Case 3
							Return
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								If True Then
								End If
								num = 0
								Continue For
							End If
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.o0.O__o_. = A_0
					toolStripMenuItem = Me.o0.O__o_.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x0600095D RID: 2397 RVA: 0x000415D0 File Offset: 0x0003F7D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oO_0ooO.O.
		End Function

		' Token: 0x0600095E RID: 2398 RVA: 0x000415E4 File Offset: 0x0003F7E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O0._O_O.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oO_0ooO.O.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 1
							GoTo IL_5A
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 3
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
						Case 4
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							GoTo IL_5A
						Case 5
							Return
					End Select
					Exit For
					IL_5A:
					Me.oO_0ooO.O. = A_0
					toolStripMenuItem = Me.oO_0ooO.O.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x0600095F RID: 2399 RVA: 0x0004168C File Offset: 0x0003F88C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_OOOo._.
		End Function

		' Token: 0x06000960 RID: 2400 RVA: 0x000416A0 File Offset: 0x0003F8A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oO_._oO.
				Dim o_OOOo._. As ToolStripMenuItem = Me.O_OOOo._.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							AddHandler o_OOOo._..Click, value
							num = 1
							Continue For
						Case 1
							Return
						Case 2
							If o_OOOo._. IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 3
							GoTo IL_5A
						Case 4
							If o_OOOo._. IsNot Nothing Then
								num = 5
								Continue For
							End If
							GoTo IL_5A
						Case 5
							If True Then
							End If
							RemoveHandler o_OOOo._..Click, value
							num = 3
							Continue For
					End Select
					Exit For
					IL_5A:
					Me.O_OOOo._. = A_0
					o_OOOo._. = Me.O_OOOo._.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x06000961 RID: 2401 RVA: 0x00041746 File Offset: 0x0003F946
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOo._o0_____o.
		End Function

		' Token: 0x06000962 RID: 2402 RVA: 0x0004174E File Offset: 0x0003F94E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOo._o0_____o. = A_0
		End Sub

		' Token: 0x06000963 RID: 2403 RVA: 0x00041757 File Offset: 0x0003F957
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oO_0ooO.O.
		End Function

		' Token: 0x06000964 RID: 2404 RVA: 0x0004175F File Offset: 0x0003F95F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oO_0ooO.O. = A_0
		End Sub

		' Token: 0x06000965 RID: 2405 RVA: 0x00041768 File Offset: 0x0003F968
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0__O0._0O0_O0.
		End Function

		' Token: 0x06000966 RID: 2406 RVA: 0x00041770 File Offset: 0x0003F970
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.oO.0_o_o_0_.
			Dim c1CheckBox As C1CheckBox = Me.o0__O0._0O0_O0.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.o0__O0._0O0_O0. = A_0
			c1CheckBox = Me.o0__O0._0O0_O0.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x06000967 RID: 2407 RVA: 0x000417B3 File Offset: 0x0003F9B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0_o0_0O.O_O_.
		End Function

		' Token: 0x06000968 RID: 2408 RVA: 0x000417BB File Offset: 0x0003F9BB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0_o0_0O.O_O_. = A_0
		End Sub

		' Token: 0x06000969 RID: 2409 RVA: 0x000417C4 File Offset: 0x0003F9C4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O__.0OOOO__.
		End Function

		' Token: 0x0600096A RID: 2410 RVA: 0x000417CC File Offset: 0x0003F9CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O__.0OOOO__. = A_0
		End Sub

		' Token: 0x0600096B RID: 2411 RVA: 0x000417D5 File Offset: 0x0003F9D5
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.o_.oo0ooo_0.
		End Function

		' Token: 0x0600096C RID: 2412 RVA: 0x000417DD File Offset: 0x0003F9DD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.o_.oo0ooo_0. = A_0
		End Sub

		' Token: 0x0600096D RID: 2413 RVA: 0x000417E6 File Offset: 0x0003F9E6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o_.oo0ooo_0.
		End Function

		' Token: 0x0600096E RID: 2414 RVA: 0x000417EE File Offset: 0x0003F9EE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o_.oo0ooo_0. = A_0
		End Sub

		' Token: 0x0600096F RID: 2415 RVA: 0x000417F7 File Offset: 0x0003F9F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_oO0ooO.o_oO.
		End Function

		' Token: 0x06000970 RID: 2416 RVA: 0x000417FF File Offset: 0x0003F9FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_oO0ooO.o_oO. = A_0
		End Sub

		' Token: 0x06000971 RID: 2417 RVA: 0x00041808 File Offset: 0x0003FA08
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o0.O__o_.
		End Function

		' Token: 0x06000972 RID: 2418 RVA: 0x00041810 File Offset: 0x0003FA10
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o_.0OO.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.OOoOO_O_.0.
			Dim c1FlexGrid As C1FlexGrid = Me.o0.O__o_.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit -= rowColEventHandler
				c1FlexGrid.BeforeEdit -= rowColEventHandler2
			End If
			Me.o0.O__o_. = A_0
			c1FlexGrid = Me.o0.O__o_.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit += rowColEventHandler
				c1FlexGrid.BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x06000973 RID: 2419 RVA: 0x00041870 File Offset: 0x0003FA70
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_O.00____. = OO_00oOO.MainTable
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.oo_o.Oo.() })
			If Operators.CompareString(Me.o0_O.00____..O_O0._..TableName, "", True) > 0 Then
				Me.oo_.oo00o0.().Value = Me.o0_O.00____..O_O0._..TableName
			Else
				Me.oo_.oo00o0.().Value = Oo00.oo0o.O0O_0__.("统计表")
			End If
			Me.o.0_0__.().Checked = Me.o0_O.00____..O_O0._..GridTree
			Me.O_o__0oooO.OOO.().Checked = Me.o0_O.00____..O_O0._..OnlyGroupRows
			Me.o00oo_0oo.o.().Checked = Me.o0_O.00____..O_O0._..IncludeParentCol
			If Me.o.0_0__.().Checked Then
				Me.OO0oo0_.0.().Checked = Me.o0_O.00____..O_O0._..ShowTreeInParentCol
			End If
			If Me.o0_O.00____..O_O0._..ExpandTo > -1 AndAlso Me.o.0_0__.().Checked Then
				Me.o_.0OO.().Value = Me.o0_O.00____..O_O0._..ExpandTo
				Me.oO0_00O_oo.0.().Checked = True
			End If
			If Me.o0_O.00____..O_O0._..PreserveTo > -1 Then
				Me.OOoOO_O_.0.().Value = Me.o0_O.00____..O_O0._..PreserveTo
				Me.O.OO00oO.().Checked = True
			End If
			If Me.o0_O.00____..O_O0._..Totals.Count > 0 Then
				Try
					For Each o0o_ As o0o_ In Me.o0_O.00____..O_O0._..Totals
						If o0o_.o0oO._o_.() = AggregateType.Count Then
							Me.OOoOO_O_.0.().AddItem(New Object() { "记录数" & vbTab, CInt(o0o_.o0oO._o_.()), CInt(o0o_.O0OO_0.O.()), o0o_.Oo0oO0oOO_.0_o.() })
						ElseIf Me.o0_O.00____..DataTable.BaseTable.Columns.Contains(o0o_.o0oO._o_.()) Then
							Me.OOoOO_O_.0.().AddItem(New Object() { o0o_.o0oO._o_.(), CInt(o0o_.o0oO._o_.()), CInt(o0o_.O0OO_0.O.()), o0o_.Oo0oO0oOO_.0_o.() })
						End If
					Next
				Finally
					Dim enumerator As List(Of o0o_).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			Dim text As String = ""
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					text = text + "|" + dataTable.Name
				Next
			Finally
				Dim enumerator2 As IEnumerator(Of DataTable)
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
			End Try
			Me.ooo___o_O_0_.o.().Cols(0).ComboList = text.Trim(New Char() { "|"c })
			Try
				For Each o00_0__O As o00_0__O In Me.o0_O.00____..O_O0._..Additions
					Me.ooo___o_O_0_.o.().AddItem(New Object() { o00_0__O.oo__.0O00.().Name, o00_0__O.oooO00__.o0.(), o00_0__O.oooO00.o00O.(), o00_0__O.o.oOo_Oo0O.() })
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of o00_0__O)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			Me.ooo___o_O_0_.o.().AllowAddNew = True
			Dim text2 As String = ""
			Try
				For Each dataCol As DataCol In Me.o0_O.00____..DataTable.DataCols
					If dataCol.IsString Then
						Me.o00oo_0oo.o.().Items.Add(dataCol.Name)
						Me.o.0_0__.().Items.Add(dataCol.Name)
						If Operators.CompareString(Me.o0_O.00____..oo.0___0O00., dataCol.Name, True) = 0 Then
							Me.o00oo_0oo.o.().SelectedIndex = Me.o00oo_0oo.o.().Items.Count - 1
						End If
						If Operators.CompareString(Me.o0_O.00____..oOo0.____., dataCol.Name, True) = 0 Then
							Me.o.0_0__.().SelectedIndex = Me.o.0_0__.().Items.Count - 1
						End If
					ElseIf dataCol.IsNumeric Then
						text2 = text2 + dataCol.Name + "|"
					End If
				Next
			Finally
				Dim enumerator4 As IEnumerator(Of DataCol)
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
			End Try
			text2 += "记录数" & vbTab
			Me.OOoOO_O_.0.().Cols(0).ComboList = text2
			Dim dictionary As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()
			dictionary.Add(0, "累计值")
			dictionary.Add(1, "最大值")
			dictionary.Add(2, "最小值")
			dictionary.Add(3, "平均值")
			dictionary.Add(4, "记录数")
			Me.OOoOO_O_.0.().Cols(1).DataMap = dictionary
			dictionary = New Dictionary(Of Integer, String)()
			dictionary.Add(0, "本级")
			dictionary.Add(1, "下级")
			dictionary.Add(2, "全部")
			Me.OOoOO_O_.0.().Cols(2).DataMap = dictionary
			Me.OOoOO_O_.0.().Col = 0
			Me.OOoOO_O_.0.().ContextMenuStrip = Me.O_O.Oo_oO.()
			Me.OOoOO_O_.0.().AllowAddNew = True
		End Sub

		' Token: 0x06000974 RID: 2420 RVA: 0x00041E38 File Offset: 0x00040038
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06000975 RID: 2421 RVA: 0x00041E4A File Offset: 0x0004004A
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Return A_0
		End Function

		' Token: 0x06000976 RID: 2422 RVA: 0x00041E50 File Offset: 0x00040050
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim inlineGroupTableBuilder As InlineGroupTableBuilder = New InlineGroupTableBuilder(Me.oo_.oo00o0.().Text.Trim(), OO_00oOO.MainTable.DataTable)
			inlineGroupTableBuilder.Filter = OO_00oOO.MainTable.Filter
			If Me.o00oo_0oo.o.().SelectedItem IsNot Nothing AndAlso Me.o.0_0__.().SelectedItem IsNot Nothing Then
				inlineGroupTableBuilder.ParentCol = Me.o00oo_0oo.o.().SelectedItem.ToString()
				inlineGroupTableBuilder.ChildCol = Me.o.0_0__.().SelectedItem.ToString()
				inlineGroupTableBuilder.Filter = Me.o0_O.00____..Filter
				inlineGroupTableBuilder.GridTree = Me.o.0_0__.().Checked
				inlineGroupTableBuilder.OnlyGroupRows = Me.O_o__0oooO.OOO.().Checked
				inlineGroupTableBuilder.IncludeParentCol = Me.o00oo_0oo.o.().Checked
				If inlineGroupTableBuilder.GridTree Then
					inlineGroupTableBuilder.ShowTreeInParentCol = Me.OO0oo0_.0.().Checked
					If Me.oO0_00O_oo.0.().Checked Then
						inlineGroupTableBuilder.ExpandTo = Conversions.ToInteger(Me.o_.0OO.().Value)
					End If
				End If
				If Me.O.OO00oO.().Checked Then
					inlineGroupTableBuilder.PreserveTo = Conversions.ToInteger(Me.OOoOO_O_.0.().Value)
				End If
				Dim num As Integer = Me.OOoOO_O_.0.().Rows.Count - 2
				For i As Integer = 1 To num
					If Me.OOoOO_O_.0.().GetData(i, 0) Is Nothing OrElse Me.OOoOO_O_.0.().GetData(i, 1) Is Nothing OrElse Me.OOoOO_O_.0.().GetData(i, 2) Is Nothing OrElse Me.OOoOO_O_.0.().GetData(i, 3) Is Nothing Then
						Return
					End If
					Dim column As String = Me.OOoOO_O_.0.(Me.OOoOO_O_.0.().GetData(i, 0).ToString())
					Dim aggregateType As AggregateType = CType(Conversions.ToInteger(Me.OOoOO_O_.0.().GetData(i, 1)), AggregateType)
					Dim aggregateRange As AggregateRange = CType(Conversions.ToInteger(Me.OOoOO_O_.0.().GetData(i, 2)), AggregateRange)
					Dim newName As String = Me.OOoOO_O_.0.().GetData(i, 3).ToString()
					If aggregateType = AggregateType.Count Then
						inlineGroupTableBuilder.AddTotal(True, newName, aggregateRange)
					Else
						inlineGroupTableBuilder.AddTotal(column, newName, aggregateRange, aggregateType)
					End If
				Next
				Dim array As String() = New String(3) {}
				Dim num2 As Integer = Me.ooo___o_O_0_.o.().Rows.Count - 1
				For j As Integer = 1 To num2
					array(0) = Me.ooo___o_O_0_.o.().GetDataDisplay(j, 0)
					array(1) = Me.ooo___o_O_0_.o.().GetDataDisplay(j, 1)
					array(2) = Me.ooo___o_O_0_.o.().GetDataDisplay(j, 2)
					array(3) = Me.ooo___o_O_0_.o.().GetDataDisplay(j, 3)
					If Operators.CompareString(array(0), "", True) > 0 AndAlso Operators.CompareString(array(1), "", True) > 0 AndAlso Operators.CompareString(array(2), "", True) > 0 AndAlso Operators.CompareString(array(3), "", True) > 0 AndAlso OO_00oOO.DataTables.Contains(array(0)) AndAlso OO_00oOO.DataTables(array(0)).BaseTable.Columns.Contains(array(1)) AndAlso OO_00oOO.DataTables(array(0)).BaseTable.Columns.Contains(array(2)) Then
						inlineGroupTableBuilder.Additions.Add(OO_00oOO.DataTables(array(0)), array(1), array(2), array(3))
					End If
				Next
				If inlineGroupTableBuilder.Totals.Count > 0 AndAlso inlineGroupTableBuilder.Build() IsNot Nothing Then
					Me.o0_O.00____..O_O0._. = New LayersGroupTableBuilder()
					Me.o0_O.00____..O_O0._. = inlineGroupTableBuilder
					Me.o0_O.00____..oo.0___0O00. = inlineGroupTableBuilder.ParentCol
					Me.o0_O.00____..oOo0.____. = inlineGroupTableBuilder.ChildCol
					Me.o0_O.00____..NeedSaveSetting = True
					Me.o0_O.00____..oo0OO0Ooo._.(True)
					MyBase.DialogResult = DialogResult.OK
					OO_00oOO.MainTable = OO_00oOO.Tables(inlineGroupTableBuilder.TableName)
				End If
			End If
		End Sub

		' Token: 0x06000977 RID: 2423 RVA: 0x0004221C File Offset: 0x0004041C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso A_1.Col > 0 Then
				If Me.OOoOO_O_.0.().GetData(A_1.Row, 0) Is Nothing Then
					A_1.Cancel = True
					Return
				End If
				Dim left As String = Me.OOoOO_O_.0.().GetData(A_1.Row, 0).ToString()
				If A_1.Col = 1 AndAlso Operators.CompareString(left, "记录数" & vbTab, True) = 0 Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x06000978 RID: 2424 RVA: 0x00042290 File Offset: 0x00040490
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.OOoOO_O_.0.().Col = 0 AndAlso Me.OOoOO_O_.0.().GetData(A_1.Row, 0) IsNot Nothing Then
				Dim text As String = Me.OOoOO_O_.0.().GetData(A_1.Row, 0).ToString()
				If Operators.CompareString(text, "记录数" & vbTab, True) = 0 Then
					Me.OOoOO_O_.0.()(A_1.Row, 1) = 4
				Else
					Me.OOoOO_O_.0.()(A_1.Row, 1) = 0
				End If
				text = text.Trim()
				Dim text2 As String = text
				Dim num As Integer = 1
				While True
					Dim flag As Boolean = False
					Dim num2 As Integer = Me.OOoOO_O_.0.().Rows.Count - 2
					For i As Integer = 1 To num2
						If Me.OOoOO_O_.0.().GetData(i, 3) IsNot Nothing AndAlso Operators.CompareString(Me.OOoOO_O_.0.().GetData(i, 3).ToString(), text2, True) = 0 Then
							flag = True
						End If
					Next
					If Not flag Then
						Exit For
					End If
					text2 = text + Conversions.ToString(num)
					num += 1
					If num > 1000 Then
						GoTo IL_113
					End If
				End While
				Me.OOoOO_O_.0.()(A_1.Row, 3) = text2
				IL_113:
				Me.OOoOO_O_.0.()(A_1.Row, 2) = 2
			End If
		End Sub

		' Token: 0x06000979 RID: 2425 RVA: 0x000423C8 File Offset: 0x000405C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim topRow As Integer = c1FlexGrid.Selection.TopRow
				Dim bottomRow As Integer = c1FlexGrid.Selection.BottomRow
				Dim num As Integer = topRow
				While num <= bottomRow AndAlso num <> c1FlexGrid.Rows.Count - 1
					c1FlexGrid.Rows.Remove(num)
					num += 1
				End While
			End If
		End Sub

		' Token: 0x0600097A RID: 2426 RVA: 0x00042434 File Offset: 0x00040634
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row > c1FlexGrid.Rows.Fixed Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row - 1)
				End If
			End If
		End Sub

		' Token: 0x0600097B RID: 2427 RVA: 0x0004248C File Offset: 0x0004068C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2 Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row + 1)
				End If
			End If
		End Sub

		' Token: 0x0600097C RID: 2428 RVA: 0x000424E8 File Offset: 0x000406E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim num As Integer = Math.Max(c1FlexGrid.Row, c1FlexGrid.Rows.Fixed)
				c1FlexGrid.Rows.Insert(num)
				c1FlexGrid.Row = num
			End If
		End Sub

		' Token: 0x0600097D RID: 2429 RVA: 0x00042539 File Offset: 0x00040739
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			If A_1.Col = 3 AndAlso Operators.CompareString(Me.OOoOO_O_.0.().Editor.Text, "", True) = 0 Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x0600097E RID: 2430 RVA: 0x00042568 File Offset: 0x00040768
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_.0OO.().Enabled = Me.oO0_00O_oo.0.().Checked
			Me.OOoOO_O_.0.().Enabled = Me.O.OO00oO.().Checked
		End Sub

		' Token: 0x0600097F RID: 2431 RVA: 0x00042598 File Offset: 0x00040798
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO0_00O_oo.0.().Enabled = Me.o.0_0__.().Checked
			Me.OO0oo0_.0.().Enabled = Me.o.0_0__.().Checked
			If Not Me.o.0_0__.().Checked Then
				Me.oO0_00O_oo.0.().Checked = False
			End If
		End Sub

		' Token: 0x06000980 RID: 2432 RVA: 0x000425EC File Offset: 0x000407EC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col = 0 Then
				Dim num As Integer = Me.ooo___o_O_0_.o.().Cols.Count - 1
				For i As Integer = 1 To num
					Me.ooo___o_O_0_.o.().SetData(A_1.Row, i, Nothing)
				Next
				Return
			End If
			If A_1.Col = 2 Then
				Dim dataDisplay As String = Me.ooo___o_O_0_.o.().GetDataDisplay(A_1.Row, 2)
				Me.ooo___o_O_0_.o.().SetData(A_1.Row, 3, dataDisplay)
			End If
		End Sub

		' Token: 0x06000981 RID: 2433 RVA: 0x00042668 File Offset: 0x00040868
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso (A_1.Col = 1 OrElse A_1.Col = 2) Then
				Dim dataDisplay As String = Me.ooo___o_O_0_.o.().GetDataDisplay(A_1.Row, 0)
				Dim text As String = ""
				If OO_00oOO.DataTables.Contains(dataDisplay) Then
					Try
						For Each dataCol As DataCol In OO_00oOO.DataTables(dataDisplay).DataCols
							text = text + "|" + dataCol.Name
						Next
					Finally
						Dim enumerator As IEnumerator(Of DataCol)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				Me.ooo___o_O_0_.o.().Cols(1).ComboList = text.Trim(New Char() { "|"c })
				Me.ooo___o_O_0_.o.().Cols(2).ComboList = text.Trim(New Char() { "|"c })
			End If
		End Sub

		' Token: 0x04000347 RID: 839
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000348 RID: 840
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000349 RID: 841
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400034A RID: 842
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400034B RID: 843
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400034C RID: 844
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400034D RID: 845
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400034E RID: 846
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400034F RID: 847
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000350 RID: 848
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000351 RID: 849
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000352 RID: 850
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000353 RID: 851
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000354 RID: 852
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000355 RID: 853
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000356 RID: 854
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000357 RID: 855
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000358 RID: 856
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000359 RID: 857
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400035A RID: 858
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400035B RID: 859
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400035C RID: 860
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400035D RID: 861
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400035E RID: 862
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400035F RID: 863
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000360 RID: 864
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x04000361 RID: 865
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000362 RID: 866
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000363 RID: 867
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000364 RID: 868
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
