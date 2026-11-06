Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000D0 RID: 208
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class ev
		Inherits Form

		' Token: 0x060009A1 RID: 2465 RVA: 0x0004310F File Offset: 0x0004130F
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Oo__o__oo_O.OO.
			AddHandler MyBase.FormClosed, AddressOf Me.OOooO.__0Ooooo.
			Me.oooo00o.o0__. = OO_00oOO.MainTable
			Me.O___oooo_0.oO.()
		End Sub

		' Token: 0x060009A2 RID: 2466 RVA: 0x0004314C File Offset: 0x0004134C
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oooo00o.o0__. IsNot Nothing Then
					Me.oooo00o.o0__..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060009A3 RID: 2467 RVA: 0x0004318C File Offset: 0x0004138C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oooo00o.o0__. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(ev))
			Me.OO_o._.(New C1CheckBox())
			Me.OO_O0oO0.O.(New C1Button())
			Me.o_oO_.0o_00.(New C1Button())
			Me.o0o___oo.o.(New C1CheckBox())
			Me.o0oOO0.o00_.(New C1CheckBox())
			Me.Oo_o0OoO.OoO.(New C1TextBox())
			Me.Oo.0o.(New Label())
			Me.Oooo.oOO0oO.(New ContextMenuStrip(Me.oooo00o.o0__.))
			Me.o.O0Oo.(New ToolStripMenuItem())
			Me.Oo.0o.(New ToolStripMenuItem())
			Me.o_.OO0oO0__0o.(New ToolStripMenuItem())
			Me.OO_O.oO_O.(New ToolStripMenuItem())
			Me.O.OO_O0.(New Label())
			Me.o_.OO0oO0__0o.(New C1TextBox())
			Me.OO_O0oO0.O.(New C1CheckBox())
			Me.OO_O.oO_O.(New C1FlexGrid())
			Me.O.OO_O0.(New C1TextBox())
			Me.OO_O.oO_O.(New RadioButton())
			Me.o_.o__.(New RadioButton())
			Me.O_o_O.O.(New C1TextBox())
			Me.Oooo.oOO0oO.(New C1ComboBox())
			Me.o_.o__.(New Label())
			Me.o.O0Oo.(New C1ComboBox())
			Me.Oooo.oOO0oO.(New Label())
			Me.o0OO0O.0OoooOo.(New C1TextBox())
			Me.o.0OOOo_o.(New Label())
			Me.o.O0Oo.(New C1CheckBox())
			Me.OO_O0oO0.O.(New C1DockingTab())
			Me.o_oO_.0o_00.(New C1DockingTabPage())
			Me.OO_O0oO0.O.(New C1DockingTabPage())
			Me.o.O0Oo.(New C1FlexGrid())
			Me.O0_0O_0.Oo00O0.().BeginInit()
			Me.OOooO.__0Ooooo.().BeginInit()
			Me.O0o00o._0o0.().BeginInit()
			Me.O_0.oO__.().BeginInit()
			Me.O0o00o._0o0.().BeginInit()
			Me.O___oooo_0.oO.().BeginInit()
			Me.O0_0O_0.Oo00O0.().SuspendLayout()
			Me.OOO___.OoO.().BeginInit()
			Me.o0_0_oo0.0O_.().BeginInit()
			Me.O0000.O.().BeginInit()
			Me.O_0._.().BeginInit()
			Me.o0.O00.().BeginInit()
			Me.O00.OO.().BeginInit()
			Me.O0_0O_0.Oo00O0.().BeginInit()
			Me.Oo0._o_ooo_0o.().BeginInit()
			Me.o_.Ooo0o_.().BeginInit()
			Me.OOooO.__0Ooooo.().BeginInit()
			Me.OOooO.__0Ooooo.().SuspendLayout()
			Me.O0o00o._0o0.().SuspendLayout()
			Me.OOooO.__0Ooooo.().SuspendLayout()
			Me.O00.OO.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0_0O_0.Oo00O0.().AutoSize = True
			Me.O0_0O_0.Oo00O0.().BorderStyle = BorderStyle.None
			Me.O0_0O_0.Oo00O0.().Checked = True
			Me.O0_0O_0.Oo00O0.().CheckState = CheckState.Checked
			Me.O0_0O_0.Oo00O0.().Location = New Point(17, 15)
			Me.O0_0O_0.Oo00O0.().Margin = New Padding(3, 1, 3, 1)
			Me.O0_0O_0.Oo00O0.().Name = "chkShowTree"
			Me.O0_0O_0.Oo00O0.().Size = New Size(84, 16)
			Me.O0_0O_0.Oo00O0.().TabIndex = 8
			Me.O0_0O_0.Oo00O0.().Text = "显示折叠树"
			Me.O0_0O_0.Oo00O0.().UseVisualStyleBackColor = True
			Me.O0_0O_0.Oo00O0.().Value = True
			Me.OOooO.__0Ooooo.().DialogResult = DialogResult.Cancel
			Me.OOooO.__0Ooooo.().Location = New Point(328, 464)
			Me.OOooO.__0Ooooo.().Margin = New Padding(3, 1, 3, 1)
			Me.OOooO.__0Ooooo.().Name = "btnCancel"
			Me.OOooO.__0Ooooo.().Size = New Size(75, 23)
			Me.OOooO.__0Ooooo.().TabIndex = 13
			Me.OOooO.__0Ooooo.().Text = "取消"
			Me.OOooO.__0Ooooo.().UseVisualStyleBackColor = True
			Me.O0o00o._0o0.().Location = New Point(232, 464)
			Me.O0o00o._0o0.().Margin = New Padding(3, 1, 3, 1)
			Me.O0o00o._0o0.().Name = "Button1"
			Me.O0o00o._0o0.().Size = New Size(75, 23)
			Me.O0o00o._0o0.().TabIndex = 12
			Me.O0o00o._0o0.().Text = "统计"
			Me.O0o00o._0o0.().UseVisualStyleBackColor = True
			Me.O_0.oO__.().AutoSize = True
			Me.O_0.oO__.().BorderStyle = BorderStyle.None
			Me.O_0.oO__.().Location = New Point(212, 15)
			Me.O_0.oO__.().Margin = New Padding(3, 1, 3, 1)
			Me.O_0.oO__.().Name = "chkOnlyGroups"
			Me.O_0.oO__.().Size = New Size(96, 16)
			Me.O_0.oO__.().TabIndex = 6
			Me.O_0.oO__.().Text = "仅保留分组行"
			Me.O_0.oO__.().UseVisualStyleBackColor = True
			Me.O_0.oO__.().Value = False
			Me.O0o00o._0o0.().AutoSize = True
			Me.O0o00o._0o0.().BorderStyle = BorderStyle.None
			Me.O0o00o._0o0.().Location = New Point(212, 41)
			Me.O0o00o._0o0.().Margin = New Padding(3, 1, 3, 1)
			Me.O0o00o._0o0.().Name = "chkPreserveTolevel"
			Me.O0o00o._0o0.().Size = New Size(60, 16)
			Me.O0o00o._0o0.().TabIndex = 39
			Me.O0o00o._0o0.().Text = "保留前"
			Me.O0o00o._0o0.().UseVisualStyleBackColor = True
			Me.O0o00o._0o0.().Value = False
			Me.O___oooo_0.oO.().DataType = GetType(Integer)
			Me.O___oooo_0.oO.().Enabled = False
			Me.O___oooo_0.oO.().Location = New Point(276, 40)
			Me.O___oooo_0.oO.().Margin = New Padding(3, 1, 3, 1)
			Me.O___oooo_0.oO.().Name = "txtPreserveTolevel"
			Me.O___oooo_0.oO.().Size = New Size(29, 19)
			Me.O___oooo_0.oO.().TabIndex = 7
			Me.O___oooo_0.oO.().Tag = Nothing
			Me.O___oooo_0.oO.().TextAlign = HorizontalAlignment.Center
			Me.O___oooo_0.oO.().Value = 0
			Me.O0_0O_0.Oo00O0.().AutoSize = True
			Me.O0_0O_0.Oo00O0.().Location = New Point(312, 43)
			Me.O0_0O_0.Oo00O0.().Name = "Label1"
			Me.O0_0O_0.Oo00O0.().Size = New Size(41, 12)
			Me.O0_0O_0.Oo00O0.().TabIndex = 41
			Me.O0_0O_0.Oo00O0.().Text = "级的行"
			Me.O0_0O_0.Oo00O0.().Items.AddRange(New ToolStripItem() { Me.OOo_0_0O.00.(), Me.O_._o_.(), Me.O0_0oo0O._O_.(), Me.O0000.O.() })
			Me.O0_0O_0.Oo00O0.().Name = "ContextMenuStrip1"
			Me.O0_0O_0.Oo00O0.().Size = New Size(101, 92)
			Me.OOo_0_0O.00.().Name = "InsertMenuItem"
			Me.OOo_0_0O.00.().Size = New Size(100, 22)
			Me.OOo_0_0O.00.().Text = "插入"
			Me.O_._o_.().Name = "DeleteMenuItem"
			Me.O_._o_.().Size = New Size(100, 22)
			Me.O_._o_.().Text = "删除"
			Me.O0_0oo0O._O_.().Name = "MoveUpMenuItem"
			Me.O0_0oo0O._O_.().Size = New Size(100, 22)
			Me.O0_0oo0O._O_.().Text = "上移"
			Me.O0000.O.().Name = "MoveDownMenuItem"
			Me.O0000.O.().Size = New Size(100, 22)
			Me.O0000.O.().Text = "下移"
			Me.O0_0oo0O._O_.().AutoSize = True
			Me.O0_0oo0O._O_.().Location = New Point(134, 43)
			Me.O0_0oo0O._O_.().Margin = New Padding(2, 0, 2, 0)
			Me.O0_0oo0O._O_.().Name = "Label5"
			Me.O0_0oo0O._O_.().Size = New Size(17, 12)
			Me.O0_0oo0O._O_.().TabIndex = 45
			Me.O0_0oo0O._O_.().Text = "级"
			Me.OOO___.OoO.().DataType = GetType(Integer)
			Me.OOO___.OoO.().Location = New Point(101, 40)
			Me.OOO___.OoO.().Name = "txtExpandLevel"
			Me.OOO___.OoO.().Size = New Size(29, 19)
			Me.OOO___.OoO.().TabIndex = 10
			Me.OOO___.OoO.().Tag = Nothing
			Me.OOO___.OoO.().Value = 0
			Me.o0_0_oo0.0O_.().AutoSize = True
			Me.o0_0_oo0.0O_.().BorderStyle = BorderStyle.None
			Me.o0_0_oo0.0O_.().Checked = True
			Me.o0_0_oo0.0O_.().CheckState = CheckState.Checked
			Me.o0_0_oo0.0O_.().Location = New Point(17, 41)
			Me.o0_0_oo0.0O_.().Margin = New Padding(2, 1, 2, 1)
			Me.o0_0_oo0.0O_.().Name = "chkAutoExpand"
			Me.o0_0_oo0.0O_.().Size = New Size(84, 16)
			Me.o0_0_oo0.0O_.().TabIndex = 9
			Me.o0_0_oo0.0O_.().Text = "默认展开到"
			Me.o0_0_oo0.0O_.().UseVisualStyleBackColor = True
			Me.o0_0_oo0.0O_.().Value = True
			Me.O0000.O.().AllowDelete = True
			Me.O0000.O.().AllowDragging = 0
			Me.O0000.O.().AllowMergingFixed = 0
			Me.O0000.O.().AllowSorting = 0
			Me.O0000.O.().BorderStyle = 4
			Me.O0000.O.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo")
			Me.O0000.O.().ExtendLastCol = True
			Me.O0000.O.().HighLight = 2
			Me.O0000.O.().Location = New Point(21, 88)
			Me.O0000.O.().Margin = New Padding(3, 2, 3, 2)
			Me.O0000.O.().Name = "TotalGrid"
			Me.O0000.O.().Rows.Count = 1
			Me.O0000.O.().Rows.DefaultSize = 19
			Me.O0000.O.().SelectionMode = 3
			Me.O0000.O.().ShowThemedHeaders = 1
			Me.O0000.O.().Size = New Size(594, 199)
			Me.O0000.O.().TabIndex = 5
			Me.O_0._.().Enabled = False
			Me.O_0._.().Location = New Point(295, 54)
			Me.O_0._.().Margin = New Padding(2, 1, 2, 1)
			Me.O_0._.().Name = "txtLengths"
			Me.O_0._.().Size = New Size(180, 19)
			Me.O_0._.().TabIndex = 4
			Me.O_0._.().Tag = Nothing
			Me.O_0._.().Value = ""
			Me.O0000.O.().AutoSize = True
			Me.O0000.O.().Location = New Point(216, 55)
			Me.O0000.O.().Margin = New Padding(2, 1, 2, 1)
			Me.O0000.O.().Name = "rdoLens"
			Me.O0000.O.().Size = New Size(77, 16)
			Me.O0000.O.().TabIndex = 55
			Me.O0000.O.().TabStop = True
			Me.O0000.O.().Text = "长度分割:"
			Me.O0000.O.().UseVisualStyleBackColor = True
			Me.O0_0oo0O._O_.().AutoSize = True
			Me.O0_0oo0O._O_.().Checked = True
			Me.O0_0oo0O._O_.().Location = New Point(21, 55)
			Me.O0_0oo0O._O_.().Margin = New Padding(2, 1, 2, 1)
			Me.O0_0oo0O._O_.().Name = "raoSep"
			Me.O0_0oo0O._O_.().Size = New Size(77, 16)
			Me.O0_0oo0O._O_.().TabIndex = 54
			Me.O0_0oo0O._O_.().TabStop = True
			Me.O0_0oo0O._O_.().Text = "符号分割:"
			Me.O0_0oo0O._O_.().UseVisualStyleBackColor = True
			Me.o0.O00.().Location = New Point(100, 54)
			Me.o0.O00.().Margin = New Padding(2, 1, 2, 1)
			Me.o0.O00.().Name = "txtSeparator"
			Me.o0.O00.().Size = New Size(96, 19)
			Me.o0.O00.().TabIndex = 3
			Me.o0.O00.().Tag = Nothing
			Me.o0.O00.().Value = "\"
			Me.O00.OO.().AllowSpinLoop = False
			Me.O00.OO.().Cursor = Cursors.Arrow
			Me.O00.OO.().DropDownStyle = 1
			Me.O00.OO.().GapHeight = 0
			Me.O00.OO.().ImagePadding = New Padding(0)
			Me.O00.OO.().ItemsDisplayMember = ""
			Me.O00.OO.().ItemsValueMember = ""
			Me.O00.OO.().Location = New Point(270, 19)
			Me.O00.OO.().Margin = New Padding(3, 1, 3, 1)
			Me.O00.OO.().Name = "cmbPathCol"
			Me.O00.OO.().Size = New Size(130, 19)
			Me.O00.OO.().TabIndex = 1
			Me.O00.OO.().Tag = "1"
			Me.O_0._.().AutoSize = True
			Me.O_0._.().Location = New Point(214, 22)
			Me.O_0._.().Name = "Label3"
			Me.O_0._.().Size = New Size(47, 12)
			Me.O_0._.().TabIndex = 60
			Me.O_0._.().Text = "层级列:"
			Me.O0_0O_0.Oo00O0.().AllowSpinLoop = False
			Me.O0_0O_0.Oo00O0.().Cursor = Cursors.Arrow
			Me.O0_0O_0.Oo00O0.().DropDownStyle = 1
			Me.O0_0O_0.Oo00O0.().GapHeight = 0
			Me.O0_0O_0.Oo00O0.().ImagePadding = New Padding(0)
			Me.O0_0O_0.Oo00O0.().ItemsDisplayMember = ""
			Me.O0_0O_0.Oo00O0.().ItemsValueMember = ""
			Me.O0_0O_0.Oo00O0.().Location = New Point(475, 19)
			Me.O0_0O_0.Oo00O0.().Margin = New Padding(3, 1, 3, 1)
			Me.O0_0O_0.Oo00O0.().Name = "cmbKeyCol"
			Me.O0_0O_0.Oo00O0.().Size = New Size(140, 19)
			Me.O0_0O_0.Oo00O0.().TabIndex = 2
			Me.O0_0O_0.Oo00O0.().Tag = Nothing
			Me.OOO___.OoO.().AutoSize = True
			Me.OOO___.OoO.().Location = New Point(419, 22)
			Me.OOO___.OoO.().Name = "Label2"
			Me.OOO___.OoO.().Size = New Size(47, 12)
			Me.OOO___.OoO.().TabIndex = 58
			Me.OOO___.OoO.().Text = "名称列:"
			Me.Oo0._o_ooo_0o.().Location = New Point(63, 19)
			Me.Oo0._o_ooo_0o.().Margin = New Padding(3, 1, 3, 1)
			Me.Oo0._o_ooo_0o.().Name = "txtName"
			Me.Oo0._o_ooo_0o.().Size = New Size(133, 19)
			Me.Oo0._o_ooo_0o.().TabIndex = 0
			Me.Oo0._o_ooo_0o.().Tag = Nothing
			Me.OOo_0_0O.00.().AutoSize = True
			Me.OOo_0_0O.00.().Location = New Point(19, 22)
			Me.OOo_0_0O.00.().Name = "Label16"
			Me.OOo_0_0O.00.().Size = New Size(35, 12)
			Me.OOo_0_0O.00.().TabIndex = 61
			Me.OOo_0_0O.00.().Text = "表名:"
			Me.o_.Ooo0o_.().AutoSize = True
			Me.o_.Ooo0o_.().BorderStyle = BorderStyle.None
			Me.o_.Ooo0o_.().Location = New Point(17, 67)
			Me.o_.Ooo0o_.().Margin = New Padding(3, 1, 3, 1)
			Me.o_.Ooo0o_.().Name = "chkShowTreeInPathCol"
			Me.o_.Ooo0o_.().Size = New Size(132, 16)
			Me.o_.Ooo0o_.().TabIndex = 62
			Me.o_.Ooo0o_.().Text = "在层级列显示折叠树"
			Me.o_.Ooo0o_.().UseVisualStyleBackColor = True
			Me.o_.Ooo0o_.().Value = False
			Me.OOooO.__0Ooooo.().Controls.Add(Me.O0o00o._0o0.())
			Me.OOooO.__0Ooooo.().Controls.Add(Me.OOooO.__0Ooooo.())
			Me.OOooO.__0Ooooo.().Location = New Point(21, 305)
			Me.OOooO.__0Ooooo.().Name = "C1DockingTab1"
			Me.OOooO.__0Ooooo.().Size = New Size(594, 134)
			Me.OOooO.__0Ooooo.().TabIndex = 63
			Me.OOooO.__0Ooooo.().TabsSpacing = 5
			Me.O0o00o._0o0.().Controls.Add(Me.O0_0O_0.Oo00O0.())
			Me.O0o00o._0o0.().Controls.Add(Me.O_0.oO__.())
			Me.O0o00o._0o0.().Controls.Add(Me.o_.Ooo0o_.())
			Me.O0o00o._0o0.().Controls.Add(Me.O0o00o._0o0.())
			Me.O0o00o._0o0.().Controls.Add(Me.O___oooo_0.oO.())
			Me.O0o00o._0o0.().Controls.Add(Me.O0_0O_0.Oo00O0.())
			Me.O0o00o._0o0.().Controls.Add(Me.o0_0_oo0.0O_.())
			Me.O0o00o._0o0.().Controls.Add(Me.OOO___.OoO.())
			Me.O0o00o._0o0.().Controls.Add(Me.O0_0oo0O._O_.())
			Me.O0o00o._0o0.().Location = New Point(1, 25)
			Me.O0o00o._0o0.().Name = "C1DockingTabPage1"
			Me.O0o00o._0o0.().Size = New Size(592, 108)
			Me.O0o00o._0o0.().TabIndex = 0
			Me.O0o00o._0o0.().Text = "选项"
			Me.OOooO.__0Ooooo.().Controls.Add(Me.O00.OO.())
			Me.OOooO.__0Ooooo.().Location = New Point(1, 25)
			Me.OOooO.__0Ooooo.().Name = "C1DockingTabPage2"
			Me.OOooO.__0Ooooo.().Size = New Size(592, 108)
			Me.OOooO.__0Ooooo.().TabIndex = 1
			Me.OOooO.__0Ooooo.().Text = "附加列"
			Me.O00.OO.().AllowDelete = True
			Me.O00.OO.().AllowDragging = 0
			Me.O00.OO.().AllowSorting = 0
			Me.O00.OO.().BorderStyle = 4
			Me.O00.OO.().ColumnInfo = componentResourceManager.GetString("grdAdditions.ColumnInfo")
			Me.O00.OO.().Dock = DockStyle.Fill
			Me.O00.OO.().ExtendLastCol = True
			Me.O00.OO.().HighLight = 2
			Me.O00.OO.().Location = New Point(0, 0)
			Me.O00.OO.().Name = "grdAdditions"
			Me.O00.OO.().Rows.Count = 1
			Me.O00.OO.().Rows.DefaultSize = 21
			Me.O00.OO.().SelectionMode = 3
			Me.O00.OO.().ShowThemedHeaders = 1
			Me.O00.OO.().Size = New Size(592, 108)
			Me.O00.OO.().TabIndex = 17
			Me.O00.OO.().VisualStyle = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(634, 503)
			MyBase.Controls.Add(Me.OOooO.__0Ooooo.())
			MyBase.Controls.Add(Me.O00.OO.())
			MyBase.Controls.Add(Me.O_0._.())
			MyBase.Controls.Add(Me.O0_0O_0.Oo00O0.())
			MyBase.Controls.Add(Me.OOO___.OoO.())
			MyBase.Controls.Add(Me.Oo0._o_ooo_0o.())
			MyBase.Controls.Add(Me.OOo_0_0O.00.())
			MyBase.Controls.Add(Me.O_0._.())
			MyBase.Controls.Add(Me.O0000.O.())
			MyBase.Controls.Add(Me.O0_0oo0O._O_.())
			MyBase.Controls.Add(Me.o0.O00.())
			MyBase.Controls.Add(Me.O0000.O.())
			MyBase.Controls.Add(Me.OOooO.__0Ooooo.())
			MyBase.Controls.Add(Me.O0o00o._0o0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(3, 1, 3, 1)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.new"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "层级数据分组统计"
			Me.O0_0O_0.Oo00O0.().EndInit()
			Me.OOooO.__0Ooooo.().EndInit()
			Me.O0o00o._0o0.().EndInit()
			Me.O_0.oO__.().EndInit()
			Me.O0o00o._0o0.().EndInit()
			Me.O___oooo_0.oO.().EndInit()
			Me.O0_0O_0.Oo00O0.().ResumeLayout(False)
			Me.OOO___.OoO.().EndInit()
			Me.o0_0_oo0.0O_.().EndInit()
			Me.O0000.O.().EndInit()
			Me.O_0._.().EndInit()
			Me.o0.O00.().EndInit()
			Me.O00.OO.().EndInit()
			Me.O0_0O_0.Oo00O0.().EndInit()
			Me.Oo0._o_ooo_0o.().EndInit()
			Me.o_.Ooo0o_.().EndInit()
			Me.OOooO.__0Ooooo.().EndInit()
			Me.OOooO.__0Ooooo.().ResumeLayout(False)
			Me.O0o00o._0o0.().ResumeLayout(False)
			Me.O0o00o._0o0.().PerformLayout()
			Me.OOooO.__0Ooooo.().ResumeLayout(False)
			Me.O00.OO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060009A4 RID: 2468 RVA: 0x00044738 File Offset: 0x00042938
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_oo0.O.
		End Function

		' Token: 0x060009A5 RID: 2469 RVA: 0x00044740 File Offset: 0x00042940
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.OO._0_.
			Dim c1CheckBox As C1CheckBox = Me.o_oo0.O.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.o_oo0.O. = A_0
			c1CheckBox = Me.o_oo0.O.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x060009A6 RID: 2470 RVA: 0x00044783 File Offset: 0x00042983
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_o0OoO.OoO.
		End Function

		' Token: 0x060009A7 RID: 2471 RVA: 0x0004478B File Offset: 0x0004298B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo_o0OoO.OoO. = A_0
		End Sub

		' Token: 0x060009A8 RID: 2472 RVA: 0x00044794 File Offset: 0x00042994
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_o_O.O.
		End Function

		' Token: 0x060009A9 RID: 2473 RVA: 0x0004479C File Offset: 0x0004299C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.o0O_.
			Dim o_o_O.O. As C1Button = Me.O_o_O.O.
			If o_o_O.O. IsNot Nothing Then
				RemoveHandler o_o_O.O..Click, value
			End If
			Me.O_o_O.O. = A_0
			o_o_O.O. = Me.O_o_O.O.
			If o_o_O.O. IsNot Nothing Then
				AddHandler o_o_O.O..Click, value
			End If
		End Sub

		' Token: 0x060009AA RID: 2474 RVA: 0x000447DF File Offset: 0x000429DF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_O.OO.
		End Function

		' Token: 0x060009AB RID: 2475 RVA: 0x000447E7 File Offset: 0x000429E7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o_O.OO. = A_0
		End Sub

		' Token: 0x060009AC RID: 2476 RVA: 0x000447F0 File Offset: 0x000429F0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0o__000o_o.OO.
		End Function

		' Token: 0x060009AD RID: 2477 RVA: 0x000447F8 File Offset: 0x000429F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.O00oO0_o.00.
			Dim c1CheckBox As C1CheckBox = Me.o0o__000o_o.OO.
			If c1CheckBox IsNot Nothing Then
				RemoveHandler c1CheckBox.CheckedChanged, value
			End If
			Me.o0o__000o_o.OO. = A_0
			c1CheckBox = Me.o0o__000o_o.OO.
			If c1CheckBox IsNot Nothing Then
				AddHandler c1CheckBox.CheckedChanged, value
			End If
		End Sub

		' Token: 0x060009AE RID: 2478 RVA: 0x0004483B File Offset: 0x00042A3B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oooo00o.o0__.
		End Function

		' Token: 0x060009AF RID: 2479 RVA: 0x00044843 File Offset: 0x00042A43
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oooo00o.o0__. = A_0
		End Sub

		' Token: 0x060009B0 RID: 2480 RVA: 0x0004484C File Offset: 0x00042A4C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_0.0O__OO0.
		End Function

		' Token: 0x060009B1 RID: 2481 RVA: 0x00044854 File Offset: 0x00042A54
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_0.0O__OO0. = A_0
		End Sub

		' Token: 0x060009B2 RID: 2482 RVA: 0x0004485D File Offset: 0x00042A5D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.o_oo0.O.
		End Function

		' Token: 0x060009B3 RID: 2483 RVA: 0x00044865 File Offset: 0x00042A65
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.o_oo0.O. = A_0
		End Sub

		' Token: 0x060009B4 RID: 2484 RVA: 0x00044870 File Offset: 0x00042A70
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o_0.0O__OO0.
		End Function

		' Token: 0x060009B5 RID: 2485 RVA: 0x00044884 File Offset: 0x00042A84
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.Oo0._o_ooo_0o.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o_0.0O__OO0.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 1
							If True Then
							End If
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							GoTo IL_62
						Case 2
							GoTo IL_62
						Case 3
							RemoveHandler toolStripMenuItem.Click, value
							num = 2
							Continue For
						Case 4
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.o_0.0O__OO0. = A_0
					toolStripMenuItem = Me.o_0.0O__OO0.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x060009B6 RID: 2486 RVA: 0x00044930 File Offset: 0x00042B30
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o_O.OO.
		End Function

		' Token: 0x060009B7 RID: 2487 RVA: 0x00044944 File Offset: 0x00042B44
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O0o.000o0oo_0_.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o_O.OO.
				Dim num As Integer = 3
				While True
					Select Case num
						Case 0
							GoTo IL_62
						Case 1
							RemoveHandler toolStripMenuItem.Click, value
							num = 0
							Continue For
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 3
							If toolStripMenuItem IsNot Nothing Then
								If True Then
								End If
								num = 1
								Continue For
							End If
							GoTo IL_62
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.o_O.OO. = A_0
					toolStripMenuItem = Me.o_O.OO.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060009B8 RID: 2488 RVA: 0x000449F0 File Offset: 0x00042BF0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.OOO.___oO_o_O0.
		End Function

		' Token: 0x060009B9 RID: 2489 RVA: 0x00044A04 File Offset: 0x00042C04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oO_o_._.
				Dim ooo.___oO_o_O0. As ToolStripMenuItem = Me.OOO.___oO_o_O0.
				Dim num As Integer = 0
				While True
					Select Case num
						Case 0
							If ooo.___oO_o_O0. IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_5A
						Case 1
							GoTo IL_5A
						Case 2
							If ooo.___oO_o_O0. IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
						Case 3
							AddHandler ooo.___oO_o_O0..Click, value
							num = 5
							Continue For
						Case 4
							If True Then
							End If
							RemoveHandler ooo.___oO_o_O0..Click, value
							num = 1
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_5A:
					Me.OOO.___oO_o_O0. = A_0
					ooo.___oO_o_O0. = Me.OOO.___oO_o_O0.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060009BA RID: 2490 RVA: 0x00044AAC File Offset: 0x00042CAC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o.00_o_o_0O.
		End Function

		' Token: 0x060009BB RID: 2491 RVA: 0x00044AC0 File Offset: 0x00042CC0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o.o__Oo0_O0.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o.00_o_o_0O.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 1
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_5A
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 3
							GoTo IL_5A
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_5A:
					Me.o.00_o_o_0O. = A_0
					toolStripMenuItem = Me.o.00_o_o_0O.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060009BC RID: 2492 RVA: 0x00044B66 File Offset: 0x00042D66
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O00o__._o_o00_.
		End Function

		' Token: 0x060009BD RID: 2493 RVA: 0x00044B6E File Offset: 0x00042D6E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O00o__._o_o00_. = A_0
		End Sub

		' Token: 0x060009BE RID: 2494 RVA: 0x00044B77 File Offset: 0x00042D77
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o.00OO_0o.
		End Function

		' Token: 0x060009BF RID: 2495 RVA: 0x00044B7F File Offset: 0x00042D7F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o.00OO_0o. = A_0
		End Sub

		' Token: 0x060009C0 RID: 2496 RVA: 0x00044B88 File Offset: 0x00042D88
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_O.o__oOo.
		End Function

		' Token: 0x060009C1 RID: 2497 RVA: 0x00044B90 File Offset: 0x00042D90
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.O00oO0_o.00.
			Dim o_O.o__oOo. As C1CheckBox = Me.O_O.o__oOo.
			If o_O.o__oOo. IsNot Nothing Then
				RemoveHandler o_O.o__oOo..CheckedChanged, value
			End If
			Me.O_O.o__oOo. = A_0
			o_O.o__oOo. = Me.O_O.o__oOo.
			If o_O.o__oOo. IsNot Nothing Then
				AddHandler o_O.o__oOo..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060009C2 RID: 2498 RVA: 0x00044BD3 File Offset: 0x00042DD3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.oooo00o.o0__.
		End Function

		' Token: 0x060009C3 RID: 2499 RVA: 0x00044BDC File Offset: 0x00042DDC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.Ooo00.__.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.oO.O0oo0_.
			Dim validateEditEventHandler As ValidateEditEventHandler = AddressOf Me.Oo_o0OoO.OoO.
			Dim c1FlexGrid As C1FlexGrid = Me.oooo00o.o0__.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.BeforeEdit -= rowColEventHandler
				c1FlexGrid.AfterEdit -= rowColEventHandler2
				c1FlexGrid.ValidateEdit -= validateEditEventHandler
			End If
			Me.oooo00o.o0__. = A_0
			c1FlexGrid = Me.oooo00o.o0__.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.BeforeEdit += rowColEventHandler
				c1FlexGrid.AfterEdit += rowColEventHandler2
				c1FlexGrid.ValidateEdit += validateEditEventHandler
			End If
		End Sub

		' Token: 0x060009C4 RID: 2500 RVA: 0x00044C55 File Offset: 0x00042E55
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO.0oo__.
		End Function

		' Token: 0x060009C5 RID: 2501 RVA: 0x00044C5D File Offset: 0x00042E5D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OO.0oo__. = A_0
		End Sub

		' Token: 0x060009C6 RID: 2502 RVA: 0x00044C66 File Offset: 0x00042E66
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o_0.0O__OO0.
		End Function

		' Token: 0x060009C7 RID: 2503 RVA: 0x00044C70 File Offset: 0x00042E70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.OO_O0oO0.O.
			Dim radioButton As RadioButton = Me.o_0.0O__OO0.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.o_0.0O__OO0. = A_0
			radioButton = Me.o_0.0O__OO0.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x060009C8 RID: 2504 RVA: 0x00044CB3 File Offset: 0x00042EB3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O00o__._o_o00_.
		End Function

		' Token: 0x060009C9 RID: 2505 RVA: 0x00044CBC File Offset: 0x00042EBC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.OO_O0oO0.O.
			Dim o00o__._o_o00_. As RadioButton = Me.O00o__._o_o00_.
			If o00o__._o_o00_. IsNot Nothing Then
				RemoveHandler o00o__._o_o00_..CheckedChanged, value
			End If
			Me.O00o__._o_o00_. = A_0
			o00o__._o_o00_. = Me.O00o__._o_o00_.
			If o00o__._o_o00_. IsNot Nothing Then
				AddHandler o00o__._o_o00_..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060009CA RID: 2506 RVA: 0x00044CFF File Offset: 0x00042EFF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o.o_0O_0o0____.
		End Function

		' Token: 0x060009CB RID: 2507 RVA: 0x00044D07 File Offset: 0x00042F07
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o.o_0O_0o0____. = A_0
		End Sub

		' Token: 0x060009CC RID: 2508 RVA: 0x00044D10 File Offset: 0x00042F10
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_oo0.O.
		End Function

		' Token: 0x060009CD RID: 2509 RVA: 0x00044D18 File Offset: 0x00042F18
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_oo0.O. = A_0
		End Sub

		' Token: 0x060009CE RID: 2510 RVA: 0x00044D21 File Offset: 0x00042F21
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOO.___oO_o_O0.
		End Function

		' Token: 0x060009CF RID: 2511 RVA: 0x00044D29 File Offset: 0x00042F29
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOO.___oO_o_O0. = A_0
		End Sub

		' Token: 0x060009D0 RID: 2512 RVA: 0x00044D32 File Offset: 0x00042F32
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_O.OO.
		End Function

		' Token: 0x060009D1 RID: 2513 RVA: 0x00044D3A File Offset: 0x00042F3A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_O.OO. = A_0
		End Sub

		' Token: 0x060009D2 RID: 2514 RVA: 0x00044D43 File Offset: 0x00042F43
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.00_o_o_0O.
		End Function

		' Token: 0x060009D3 RID: 2515 RVA: 0x00044D4B File Offset: 0x00042F4B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.00_o_o_0O. = A_0
		End Sub

		' Token: 0x060009D4 RID: 2516 RVA: 0x00044D54 File Offset: 0x00042F54
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oOoo_0o.__o0_o.
		End Function

		' Token: 0x060009D5 RID: 2517 RVA: 0x00044D5C File Offset: 0x00042F5C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oOoo_0o.__o0_o. = A_0
		End Sub

		' Token: 0x060009D6 RID: 2518 RVA: 0x00044D65 File Offset: 0x00042F65
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_0_O.oo0.
		End Function

		' Token: 0x060009D7 RID: 2519 RVA: 0x00044D6D File Offset: 0x00042F6D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_0_O.oo0. = A_0
		End Sub

		' Token: 0x060009D8 RID: 2520 RVA: 0x00044D76 File Offset: 0x00042F76
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_._OO_O0Oo.
		End Function

		' Token: 0x060009D9 RID: 2521 RVA: 0x00044D7E File Offset: 0x00042F7E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o_._OO_O0Oo. = A_0
		End Sub

		' Token: 0x060009DA RID: 2522 RVA: 0x00044D87 File Offset: 0x00042F87
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.Oo_o0OoO.OoO.
		End Function

		' Token: 0x060009DB RID: 2523 RVA: 0x00044D8F File Offset: 0x00042F8F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.Oo_o0OoO.OoO. = A_0
		End Sub

		' Token: 0x060009DC RID: 2524 RVA: 0x00044D98 File Offset: 0x00042F98
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.Oo_o0OoO.OoO.
		End Function

		' Token: 0x060009DD RID: 2525 RVA: 0x00044DA0 File Offset: 0x00042FA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.Oo_o0OoO.OoO. = A_0
		End Sub

		' Token: 0x060009DE RID: 2526 RVA: 0x00044DA9 File Offset: 0x00042FA9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_o_O.O.
		End Function

		' Token: 0x060009DF RID: 2527 RVA: 0x00044DB1 File Offset: 0x00042FB1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_o_O.O. = A_0
		End Sub

		' Token: 0x060009E0 RID: 2528 RVA: 0x00044DBA File Offset: 0x00042FBA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o_O.OO.
		End Function

		' Token: 0x060009E1 RID: 2529 RVA: 0x00044DC4 File Offset: 0x00042FC4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o0.O00.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.O___oooo_0.oO.
			Dim c1FlexGrid As C1FlexGrid = Me.o_O.OO.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit -= rowColEventHandler
				c1FlexGrid.BeforeEdit -= rowColEventHandler2
			End If
			Me.o_O.OO. = A_0
			c1FlexGrid = Me.o_O.OO.
			If c1FlexGrid IsNot Nothing Then
				c1FlexGrid.AfterEdit += rowColEventHandler
				c1FlexGrid.BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x060009E2 RID: 2530 RVA: 0x00044E24 File Offset: 0x00043024
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oooo00o.o0__. = OO_00oOO.MainTable
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.OOooO.__0Ooooo.() })
			If Operators.CompareString(Me.oooo00o.o0__..O_O0._..TableName, "", True) > 0 Then
				Me.Oo0._o_ooo_0o.().Value = Me.oooo00o.o0__..O_O0._..TableName
			Else
				Me.Oo0._o_ooo_0o.().Value = Oo00.oo0o.O0O_0__.("统计表")
			End If
			Me.O0_0O_0.Oo00O0.().Checked = Me.oooo00o.o0__..O_O0._..GridTree
			Me.O_0.oO__.().Checked = Me.oooo00o.o0__..O_O0._..OnlyGroupRows
			If Me.O0_0O_0.Oo00O0.().Checked Then
				Me.o_.Ooo0o_.().Checked = Me.oooo00o.o0__..O_O0._..ShowTreeInPathCol
			End If
			If Me.oooo00o.o0__..O_O0._..ExpandTo > -1 AndAlso Me.O0_0O_0.Oo00O0.().Checked Then
				Me.OOO___.OoO.().Value = Me.oooo00o.o0__..O_O0._..ExpandTo
				Me.o0_0_oo0.0O_.().Checked = True
			End If
			If Me.oooo00o.o0__..O_O0._..PreserveTo > -1 Then
				Me.O___oooo_0.oO.().Value = Me.oooo00o.o0__..O_O0._..PreserveTo
				Me.O0o00o._0o0.().Checked = True
			End If
			If Me.oooo00o.o0__..O_O0._..Totals.Count > 0 Then
				Try
					For Each o0o_ As o0o_ In Me.oooo00o.o0__..O_O0._..Totals
						If o0o_.o0oO._o_.() = AggregateType.Count Then
							Me.O0000.O.().AddItem(New Object() { "记录数" & vbTab, CInt(o0o_.o0oO._o_.()), CInt(o0o_.O0OO_0.O.()), o0o_.Oo0oO0oOO_.0_o.() })
						ElseIf Me.oooo00o.o0__..DataTable.BaseTable.Columns.Contains(o0o_.o0oO._o_.()) Then
							Me.O0000.O.().AddItem(New Object() { o0o_.o0oO._o_.(), CInt(o0o_.o0oO._o_.()), CInt(o0o_.O0OO_0.O.()), o0o_.Oo0oO0oOO_.0_o.() })
						End If
					Next
				Finally
					Dim enumerator As List(Of o0o_).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			If Operators.CompareString(Conversions.ToString(Me.oooo00o.o0__..o00oOO00_.ooOo.), "", True) > 0 Then
				Me.o0.O00.().Value = Me.oooo00o.o0__..o00oOO00_.ooOo.
			End If
			If Operators.CompareString(Me.oooo00o.o0__..oo.o0o0O_o_., "", True) > 0 Then
				Me.O_0._.().Value = Me.oooo00o.o0__..oo.o0o0O_o_.
				Me.O0000.O.().Checked = True
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
			Me.O00.OO.().Cols(0).ComboList = text.Trim(New Char() { "|"c })
			Try
				For Each o00_0__O As o00_0__O In Me.oooo00o.o0__..O_O0._..Additions
					Me.O00.OO.().AddItem(New Object() { o00_0__O.oo__.0O00.().Name, o00_0__O.oooO00__.o0.(), o00_0__O.oooO00.o00O.(), o00_0__O.o.oOo_Oo0O.() })
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of o00_0__O)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			Me.O00.OO.().AllowAddNew = True
			Dim text2 As String = ""
			Me.O0_0O_0.Oo00O0.().Items.Add("")
			Try
				For Each dataCol As DataCol In Me.oooo00o.o0__..DataTable.DataCols
					If dataCol.IsString Then
						Me.O00.OO.().Items.Add(dataCol.Name)
						Me.O0_0O_0.Oo00O0.().Items.Add(dataCol.Name)
						If Operators.CompareString(Me.oooo00o.o0__..o_O_0._O_., dataCol.Name, True) = 0 Then
							Me.O00.OO.().SelectedIndex = Me.O00.OO.().Items.Count - 1
						End If
						If Operators.CompareString(Me.oooo00o.o0__..ooO0o.o_O., dataCol.Name, True) = 0 Then
							Me.O0_0O_0.Oo00O0.().SelectedIndex = Me.O0_0O_0.Oo00O0.().Items.Count - 1
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
			Me.O0000.O.().Cols(0).ComboList = text2
			Dim dictionary As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()
			dictionary.Add(0, "累计值")
			dictionary.Add(1, "最大值")
			dictionary.Add(2, "最小值")
			dictionary.Add(3, "平均值")
			dictionary.Add(4, "记录数")
			Me.O0000.O.().Cols(1).DataMap = dictionary
			dictionary = New Dictionary(Of Integer, String)()
			dictionary.Add(0, "本级")
			dictionary.Add(1, "下级")
			dictionary.Add(2, "全部")
			Me.O0000.O.().Cols(2).DataMap = dictionary
			Me.O0000.O.().Col = 0
			Me.O0000.O.().ContextMenuStrip = Me.O0_0O_0.Oo00O0.()
			Me.O0000.O.().AllowAddNew = True
		End Sub

		' Token: 0x060009E3 RID: 2531 RVA: 0x0004545C File Offset: 0x0004365C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x060009E4 RID: 2532 RVA: 0x0004546E File Offset: 0x0004366E
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Return A_0
		End Function

		' Token: 0x060009E5 RID: 2533 RVA: 0x00045474 File Offset: 0x00043674
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim layersGroupTableBuilder As LayersGroupTableBuilder = New LayersGroupTableBuilder(Me.Oo0._o_ooo_0o.().Text.Trim(), OO_00oOO.MainTable.DataTable)
			layersGroupTableBuilder.Filter = OO_00oOO.MainTable.Filter
			If Me.O00.OO.().SelectedItem IsNot Nothing Then
				layersGroupTableBuilder.PathCol = Me.O00.OO.().SelectedItem.ToString()
				If Me.O0_0O_0.Oo00O0.().SelectedItem IsNot Nothing Then
					layersGroupTableBuilder.NameCol = Me.O0_0O_0.Oo00O0.().SelectedItem.ToString()
				End If
				layersGroupTableBuilder.Filter = Me.oooo00o.o0__..Filter
				layersGroupTableBuilder.GridTree = Me.O0_0O_0.Oo00O0.().Checked
				layersGroupTableBuilder.OnlyGroupRows = Me.O_0.oO__.().Checked
				If layersGroupTableBuilder.GridTree Then
					layersGroupTableBuilder.ShowTreeInPathCol = Me.o_.Ooo0o_.().Checked
					If Me.o0_0_oo0.0O_.().Checked Then
						layersGroupTableBuilder.ExpandTo = Conversions.ToInteger(Me.OOO___.OoO.().Value)
					End If
				End If
				If Me.O0o00o._0o0.().Checked Then
					layersGroupTableBuilder.PreserveTo = Conversions.ToInteger(Me.O___oooo_0.oO.().Value)
				End If
				If Me.O0_0oo0O._O_.().Checked AndAlso Operators.CompareString(Me.o0.O00.().Text, "", True) > 0 Then
					layersGroupTableBuilder.Separator = Conversions.ToString(Me.o0.O00.().Text(0))
				Else
					If Not Me.O0000.O.().Checked OrElse Operators.CompareString(Me.O_0._.().Text, "", True) <= 0 Then
						Return
					End If
					Dim array As String() = Regex.Split(Me.O_0._.().Text, "[^\d]+")
					Dim list As List(Of Object) = New List(Of Object)()
					If array.Length > 0 Then
						Dim num As Integer = array.Length - 1
						For i As Integer = 0 To num
							Dim num2 As Integer
							If Integer.TryParse(array(i), num2) Then
								list.Add(num2)
							End If
						Next
						If list.Count = array.Length Then
							layersGroupTableBuilder.lengths = list.ToArray()
						Else
							MessageBox.Show("请正确输入用逗号分割的长度，例如:1,3,2")
						End If
					End If
				End If
				Dim num3 As Integer = Me.O0000.O.().Rows.Count - 2
				For j As Integer = 1 To num3
					If Me.O0000.O.().GetData(j, 0) Is Nothing OrElse Me.O0000.O.().GetData(j, 1) Is Nothing OrElse Me.O0000.O.().GetData(j, 2) Is Nothing OrElse Me.O0000.O.().GetData(j, 3) Is Nothing Then
						Return
					End If
					Dim column As String = Me.O___oooo_0.oO.(Me.O0000.O.().GetData(j, 0).ToString())
					Dim aggregateType As AggregateType = CType(Conversions.ToInteger(Me.O0000.O.().GetData(j, 1)), AggregateType)
					Dim aggregateRange As AggregateRange = CType(Conversions.ToInteger(Me.O0000.O.().GetData(j, 2)), AggregateRange)
					Dim newName As String = Me.O0000.O.().GetData(j, 3).ToString()
					If aggregateType = AggregateType.Count Then
						layersGroupTableBuilder.AddTotal(True, newName, aggregateRange)
					Else
						layersGroupTableBuilder.AddTotal(column, newName, aggregateRange, aggregateType)
					End If
				Next
				Dim array2 As String() = New String(3) {}
				Dim num4 As Integer = Me.O00.OO.().Rows.Count - 1
				For k As Integer = 1 To num4
					array2(0) = Me.O00.OO.().GetDataDisplay(k, 0)
					array2(1) = Me.O00.OO.().GetDataDisplay(k, 1)
					array2(2) = Me.O00.OO.().GetDataDisplay(k, 2)
					array2(3) = Me.O00.OO.().GetDataDisplay(k, 3)
					If Operators.CompareString(array2(0), "", True) > 0 AndAlso Operators.CompareString(array2(1), "", True) > 0 AndAlso Operators.CompareString(array2(2), "", True) > 0 AndAlso Operators.CompareString(array2(3), "", True) > 0 AndAlso OO_00oOO.DataTables.Contains(array2(0)) AndAlso OO_00oOO.DataTables(array2(0)).BaseTable.Columns.Contains(array2(1)) AndAlso OO_00oOO.DataTables(array2(0)).BaseTable.Columns.Contains(array2(2)) Then
						layersGroupTableBuilder.Additions.Add(OO_00oOO.DataTables(array2(0)), array2(1), array2(2), array2(3))
					End If
				Next
				If layersGroupTableBuilder.Totals.Count > 0 AndAlso layersGroupTableBuilder.Build() IsNot Nothing Then
					Me.oooo00o.o0__..O_O0._. = New InlineGroupTableBuilder()
					Me.oooo00o.o0__..O_O0._. = layersGroupTableBuilder
					Me.oooo00o.o0__..o_O_0._O_. = layersGroupTableBuilder.PathCol
					Me.oooo00o.o0__..ooO0o.o_O. = layersGroupTableBuilder.NameCol
					Me.oooo00o.o0__..o00oOO00_.ooOo. = layersGroupTableBuilder.Separator2
					Me.oooo00o.o0__..oo.o0o0O_o_. = Me.O_0._.().Text
					Me.oooo00o.o0__..NeedSaveSetting = True
					Me.oooo00o.o0__..oo0OO0Ooo._.(True)
					MyBase.DialogResult = DialogResult.OK
					OO_00oOO.MainTable = OO_00oOO.Tables(layersGroupTableBuilder.TableName)
				End If
			End If
		End Sub

		' Token: 0x060009E6 RID: 2534 RVA: 0x00045954 File Offset: 0x00043B54
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso A_1.Col > 0 Then
				If Me.O0000.O.().GetData(A_1.Row, 0) Is Nothing Then
					A_1.Cancel = True
					Return
				End If
				Dim left As String = Me.O0000.O.().GetData(A_1.Row, 0).ToString()
				If A_1.Col = 1 AndAlso Operators.CompareString(left, "记录数" & vbTab, True) = 0 Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x060009E7 RID: 2535 RVA: 0x000459C8 File Offset: 0x00043BC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.O0000.O.().Col = 0 AndAlso Me.O0000.O.().GetData(A_1.Row, 0) IsNot Nothing Then
				Dim text As String = Me.O0000.O.().GetData(A_1.Row, 0).ToString()
				If Operators.CompareString(text, "记录数" & vbTab, True) = 0 Then
					Me.O0000.O.()(A_1.Row, 1) = 4
				Else
					Me.O0000.O.()(A_1.Row, 1) = 0
				End If
				text = text.Trim()
				Dim text2 As String = text
				Dim num As Integer = 1
				While True
					Dim flag As Boolean = False
					Dim num2 As Integer = Me.O0000.O.().Rows.Count - 2
					For i As Integer = 1 To num2
						If Me.O0000.O.().GetData(i, 3) IsNot Nothing AndAlso Operators.CompareString(Me.O0000.O.().GetData(i, 3).ToString(), text2, True) = 0 Then
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
				Me.O0000.O.()(A_1.Row, 3) = text2
				IL_113:
				Me.O0000.O.()(A_1.Row, 2) = 2
			End If
		End Sub

		' Token: 0x060009E8 RID: 2536 RVA: 0x00045B00 File Offset: 0x00043D00
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

		' Token: 0x060009E9 RID: 2537 RVA: 0x00045B6C File Offset: 0x00043D6C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row > c1FlexGrid.Rows.Fixed Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row - 1)
				End If
			End If
		End Sub

		' Token: 0x060009EA RID: 2538 RVA: 0x00045BC4 File Offset: 0x00043DC4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2 Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row + 1)
				End If
			End If
		End Sub

		' Token: 0x060009EB RID: 2539 RVA: 0x00045C20 File Offset: 0x00043E20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim num As Integer = Math.Max(c1FlexGrid.Row, c1FlexGrid.Rows.Fixed)
				c1FlexGrid.Rows.Insert(num)
				c1FlexGrid.Row = num
			End If
		End Sub

		' Token: 0x060009EC RID: 2540 RVA: 0x00045C71 File Offset: 0x00043E71
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			If A_1.Col = 3 AndAlso Operators.CompareString(Me.O0000.O.().Editor.Text, "", True) = 0 Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060009ED RID: 2541 RVA: 0x00045CA0 File Offset: 0x00043EA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOO___.OoO.().Enabled = Me.o0_0_oo0.0O_.().Checked
			Me.O___oooo_0.oO.().Enabled = Me.O0o00o._0o0.().Checked
		End Sub

		' Token: 0x060009EE RID: 2542 RVA: 0x00045CD0 File Offset: 0x00043ED0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0_0_oo0.0O_.().Enabled = Me.O0_0O_0.Oo00O0.().Checked
			Me.o_.Ooo0o_.().Enabled = Me.O0_0O_0.Oo00O0.().Checked
			If Not Me.O0_0O_0.Oo00O0.().Checked Then
				Me.o0_0_oo0.0O_.().Checked = False
			End If
		End Sub

		' Token: 0x060009EF RID: 2543 RVA: 0x00045D22 File Offset: 0x00043F22
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_0._.().Enabled = Me.O0000.O.().Checked
			Me.o0.O00.().Enabled = Me.O0_0oo0O._O_.().Checked
		End Sub

		' Token: 0x060009F0 RID: 2544 RVA: 0x00045D50 File Offset: 0x00043F50
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col = 0 Then
				Dim num As Integer = Me.O00.OO.().Cols.Count - 1
				For i As Integer = 1 To num
					Me.O00.OO.().SetData(A_1.Row, i, Nothing)
				Next
				Return
			End If
			If A_1.Col = 2 Then
				Dim dataDisplay As String = Me.O00.OO.().GetDataDisplay(A_1.Row, 2)
				Me.O00.OO.().SetData(A_1.Row, 3, dataDisplay)
			End If
		End Sub

		' Token: 0x060009F1 RID: 2545 RVA: 0x00045DCC File Offset: 0x00043FCC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso (A_1.Col = 1 OrElse A_1.Col = 2) Then
				Dim dataDisplay As String = Me.O00.OO.().GetDataDisplay(A_1.Row, 0)
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
				Me.O00.OO.().Cols(1).ComboList = text.Trim(New Char() { "|"c })
				Me.O00.OO.().Cols(2).ComboList = text.Trim(New Char() { "|"c })
			End If
		End Sub

		' Token: 0x04000378 RID: 888
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000379 RID: 889
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400037A RID: 890
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400037B RID: 891
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400037C RID: 892
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400037D RID: 893
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400037E RID: 894
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400037F RID: 895
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000380 RID: 896
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000381 RID: 897
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000382 RID: 898
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000383 RID: 899
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000384 RID: 900
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000385 RID: 901
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000386 RID: 902
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000387 RID: 903
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000388 RID: 904
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000389 RID: 905
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400038A RID: 906
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400038B RID: 907
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400038C RID: 908
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400038D RID: 909
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400038E RID: 910
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400038F RID: 911
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000390 RID: 912
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000391 RID: 913
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000392 RID: 914
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000393 RID: 915
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000394 RID: 916
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x04000395 RID: 917
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000396 RID: 918
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000397 RID: 919
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000398 RID: 920
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
