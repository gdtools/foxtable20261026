Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000341 RID: 833
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class mf
		Inherits Form

		' Token: 0x06003215 RID: 12821 RVA: 0x0014576C File Offset: 0x0014396C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0_0O_O0.O_O0. IsNot Nothing Then
					Me.o0_0O_O0.O_O0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003216 RID: 12822 RVA: 0x001457AC File Offset: 0x001439AC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0_0O_O0.O_O0. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(mf))
			Me.O000__0.0.(New C1Button())
			Me.o0O00O0_O.O0_.(New C1FlexGrid())
			Me.Oo0Oo__o0_.o0O.(New ContextMenuStrip(Me.o0_0O_O0.O_O0.))
			Me.o0.O_oO0oOO0.(New ToolStripMenuItem())
			Me.OOO_O0__0o0.0.(New ToolStripMenuItem())
			Me.O_O_o.o_O_O.(New ToolStripMenuItem())
			Me.o0O00O0_O.O0_.(New ToolStripMenuItem())
			Me.O0_O__0.00o0oo.(New C1Button())
			Me.O.O00O_Ooo0O_.(New C1Button())
			Me.OO0.0.(New C1Button())
			Me.O.ooooO.(New C1Button())
			Me.OO.O0Oo.(New C1TextBox())
			Me.Oo.00o.(New Label())
			Me.O_O_o.o_O_O.(New C1TextBox())
			Me.o.0_OO0Oo.(New Label())
			Me.o.o_00o0_O_O.(New C1Button())
			Me.o0O00O0_O.O0_.(New C1TextBox())
			Me.o0O_.__O_.(New Label())
			Me.o0.O_oO0oOO0.(New Label())
			Me.O__O_o0.oo.(New Label())
			Me.o.0_OO0Oo.(New C1FlexGrid())
			Me.O_.oOO0.(New Label())
			Me.oO_OO.00_o.(New C1FlexGrid())
			Me.OO.oOo___OOOo.(New C1CheckBox())
			Me.O0._oo__.(New C1CheckBox())
			Me.oO.000_Oo.(New C1CheckBox())
			Me.Oo0Oo__o0_.o0O.(New GroupBox())
			Me.O.ooooO.(New C1CheckBox())
			Me.Oo0Oo__o0_.o0O.(New C1CheckBox())
			Me.OOO_O0__0o0.0.(New C1CheckBox())
			Me.OO0.0.(New C1CheckBox())
			Me.O0oOo_.oOoOOO.(New Label())
			Me.O0oOo_.oOoOOO.(New C1TextBox())
			Me.Oo0Oo__o0_.o0O.(New C1NumericEdit())
			Me.oO_OO.00_o.(New C1TextBox())
			Me.O_oOo_0OO.ooO.(New Label())
			Me.O0.0OO_.(New Label())
			Me.O_0oo00_.o_0O.(New C1CheckBox())
			Me.O.o_O0_00.(New C1CheckBox())
			Me.o_0o00_.o0O_o.().BeginInit()
			Me.oOo_ooo_0O._o.().BeginInit()
			Me.O0_.o0oo0_0_O0.().SuspendLayout()
			Me.Ooo0OOoo._____.().BeginInit()
			Me.OoOoo.Oooo00.().BeginInit()
			Me.O_oo.0OO.().BeginInit()
			Me.O.0O_Oo.().BeginInit()
			Me.OO00.OO_0o_0o.().BeginInit()
			Me.oo0OOO.Oo__00.().BeginInit()
			Me.O_.O0oOOo.().BeginInit()
			Me.o_0Oo.O00OOoO.().BeginInit()
			Me.oO._0O.().BeginInit()
			Me.o_0Oo.O00OOoO.().BeginInit()
			Me.O.0O_Oo.().BeginInit()
			Me.o.oO_.().BeginInit()
			Me.o.00o0oO_oo_.().BeginInit()
			Me.O0_.o0oo0_0_O0.().SuspendLayout()
			Me.O0_00.oo0.().BeginInit()
			Me.ooo0._0o00oO_.().BeginInit()
			Me.OO0OO0O0.o0_.().BeginInit()
			Me.oo.o0_0o.().BeginInit()
			Me.o.__oOoo0O.().BeginInit()
			Me.O0_.o0oo0_0_O0.().BeginInit()
			Me.o00_.O0.().BeginInit()
			Me.o_0o00_.o0O_o.().BeginInit()
			Me.oO.00OOOO__o0.().BeginInit()
			MyBase.SuspendLayout()
			Me.o_0o00_.o0O_o.().Location = New Point(19, 607)
			Me.o_0o00_.o0O_o.().Margin = New Padding(4, 3, 4, 3)
			Me.o_0o00_.o0O_o.().Name = "btnSave"
			Me.o_0o00_.o0O_o.().Size = New Size(100, 28)
			Me.o_0o00_.o0O_o.().TabIndex = 9
			Me.o_0o00_.o0O_o.().Text = "保存设置"
			Me.o_0o00_.o0O_o.().UseVisualStyleBackColor = True
			Me.oOo_ooo_0O._o.().AllowDelete = True
			Me.oOo_ooo_0O._o.().AllowDragging = 0
			Me.oOo_ooo_0O._o.().BorderStyle = 4
			Me.oOo_ooo_0O._o.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo")
			Me.oOo_ooo_0O._o.().ContextMenuStrip = Me.O0_.o0oo0_0_O0.()
			Me.oOo_ooo_0O._o.().ExtendLastCol = True
			Me.oOo_ooo_0O._o.().HighLight = 2
			Me.oOo_ooo_0O._o.().Location = New Point(21, 345)
			Me.oOo_ooo_0O._o.().Margin = New Padding(4, 3, 4, 3)
			Me.oOo_ooo_0O._o.().Name = "TotalGrid"
			Me.oOo_ooo_0O._o.().Rows.Count = 1
			Me.oOo_ooo_0O._o.().Rows.DefaultSize = 19
			Me.oOo_ooo_0O._o.().SelectionMode = 3
			Me.oOo_ooo_0O._o.().ShowThemedHeaders = 1
			Me.oOo_ooo_0O._o.().Size = New Size(743, 97)
			Me.oOo_ooo_0O._o.().TabIndex = 4
			Me.O0_.o0oo0_0_O0.().ImageScalingSize = New Size(20, 20)
			Me.O0_.o0oo0_0_O0.().Items.AddRange(New ToolStripItem() { Me.Oo0.o_O.(), Me.oO._0O.(), Me.oOo_ooo_0O._o.(), Me.O0OO.oOOo.() })
			Me.O0_.o0oo0_0_O0.().Name = "ContextMenuStrip1"
			Me.O0_.o0oo0_0_O0.().Size = New Size(109, 100)
			Me.Oo0.o_O.().Name = "InsertMenuItem"
			Me.Oo0.o_O.().Size = New Size(108, 24)
			Me.Oo0.o_O.().Text = "插入"
			Me.oO._0O.().Name = "DeleteMenuItem"
			Me.oO._0O.().Size = New Size(108, 24)
			Me.oO._0O.().Text = "删除"
			Me.oOo_ooo_0O._o.().Name = "MoveUpMenuItem"
			Me.oOo_ooo_0O._o.().Size = New Size(108, 24)
			Me.oOo_ooo_0O._o.().Text = "上移"
			Me.O0OO.oOOo.().Name = "MoveDownMenuItem"
			Me.O0OO.oOOo.().Size = New Size(108, 24)
			Me.O0OO.oOOo.().Text = "下移"
			Me.Ooo0OOoo._____.().CausesValidation = False
			Me.Ooo0OOoo._____.().DialogResult = DialogResult.Cancel
			Me.Ooo0OOoo._____.().Location = New Point(663, 607)
			Me.Ooo0OOoo._____.().Margin = New Padding(4, 3, 4, 3)
			Me.Ooo0OOoo._____.().Name = "btnCancel"
			Me.Ooo0OOoo._____.().Size = New Size(100, 28)
			Me.Ooo0OOoo._____.().TabIndex = 12
			Me.Ooo0OOoo._____.().Text = "取消"
			Me.Ooo0OOoo._____.().UseVisualStyleBackColor = True
			Me.OoOoo.Oooo00.().Location = New Point(126, 607)
			Me.OoOoo.Oooo00.().Margin = New Padding(4, 3, 4, 3)
			Me.OoOoo.Oooo00.().Name = "btnList"
			Me.OoOoo.Oooo00.().Size = New Size(100, 28)
			Me.OoOoo.Oooo00.().TabIndex = 10
			Me.OoOoo.Oooo00.().Text = "设置管理"
			Me.OoOoo.Oooo00.().UseVisualStyleBackColor = True
			Me.O_oo.0OO.().Location = New Point(555, 607)
			Me.O_oo.0OO.().Margin = New Padding(4, 3, 4, 3)
			Me.O_oo.0OO.().Name = "btnOk"
			Me.O_oo.0OO.().Size = New Size(100, 28)
			Me.O_oo.0OO.().TabIndex = 11
			Me.O_oo.0OO.().Text = "确定"
			Me.O_oo.0OO.().UseVisualStyleBackColor = True
			Me.O.0O_Oo.().Location = New Point(235, 607)
			Me.O.0O_Oo.().Margin = New Padding(4, 3, 4, 3)
			Me.O.0O_Oo.().Name = "btnViewCode"
			Me.O.0O_Oo.().Size = New Size(100, 28)
			Me.O.0O_Oo.().TabIndex = 8
			Me.O.0O_Oo.().Text = "查看代码"
			Me.O.0O_Oo.().UseVisualStyleBackColor = True
			Me.OO00.OO_0o_0o.().Location = New Point(301, 15)
			Me.OO00.OO_0o_0o.().Margin = New Padding(4, 3, 4, 3)
			Me.OO00.OO_0o_0o.().Name = "txtCaption"
			Me.OO00.OO_0o_0o.().Size = New Size(461, 23)
			Me.OO00.OO_0o_0o.().TabIndex = 1
			Me.OO00.OO_0o_0o.().Tag = Nothing
			Me.oOo_ooo_0O._o.().AutoSize = True
			Me.oOo_ooo_0O._o.().Location = New Point(247, 20)
			Me.oOo_ooo_0O._o.().Margin = New Padding(4, 0, 4, 0)
			Me.oOo_ooo_0O._o.().Name = "Label5"
			Me.oOo_ooo_0O._o.().Size = New Size(45, 15)
			Me.oOo_ooo_0O._o.().TabIndex = 25
			Me.oOo_ooo_0O._o.().Text = "标题:"
			Me.oo0OOO.Oo__00.().Location = New Point(75, 15)
			Me.oo0OOO.Oo__00.().Margin = New Padding(4, 3, 4, 3)
			Me.oo0OOO.Oo__00.().Name = "txtName"
			Me.oo0OOO.Oo__00.().Size = New Size(133, 23)
			Me.oo0OOO.Oo__00.().TabIndex = 0
			Me.oo0OOO.Oo__00.().Tag = Nothing
			Me.O0OO.oOOo.().AutoSize = True
			Me.O0OO.oOOo.().Location = New Point(19, 20)
			Me.O0OO.oOOo.().Margin = New Padding(4, 0, 4, 0)
			Me.O0OO.oOOo.().Name = "Label4"
			Me.O0OO.oOOo.().Size = New Size(45, 15)
			Me.O0OO.oOOo.().TabIndex = 23
			Me.O0OO.oOOo.().Text = "表名:"
			Me.O_.O0oOOo.().Location = New Point(715, 569)
			Me.O_.O0oOOo.().Margin = New Padding(4, 3, 4, 3)
			Me.O_.O0oOOo.().Name = "btnEditExpression"
			Me.O_.O0oOOo.().Size = New Size(48, 28)
			Me.O_.O0oOOo.().TabIndex = 7
			Me.O_.O0oOOo.().Text = "..."
			Me.O_.O0oOOo.().UseVisualStyleBackColor = True
			Me.o_0Oo.O00OOoO.().Location = New Point(73, 572)
			Me.o_0Oo.O00OOoO.().Margin = New Padding(4, 3, 4, 3)
			Me.o_0Oo.O00OOoO.().Name = "txtFilter"
			Me.o_0Oo.O00OOoO.().Size = New Size(638, 23)
			Me.o_0Oo.O00OOoO.().TabIndex = 6
			Me.o_0Oo.O00OOoO.().Tag = Nothing
			Me.O.0o_0O.().AutoSize = True
			Me.O.0o_0O.().Location = New Point(19, 576)
			Me.O.0o_0O.().Margin = New Padding(4, 0, 4, 0)
			Me.O.0o_0O.().Name = "Label3"
			Me.O.0o_0O.().Size = New Size(45, 15)
			Me.O.0o_0O.().TabIndex = 20
			Me.O.0o_0O.().Text = "条件:"
			Me.OOO.__oO0O_0.().AutoSize = True
			Me.OOO.__oO0O_0.().Location = New Point(19, 321)
			Me.OOO.__oO0O_0.().Margin = New Padding(4, 0, 4, 0)
			Me.OOO.__oO0O_0.().Name = "Label2"
			Me.OOO.__oO0O_0.().Size = New Size(90, 15)
			Me.OOO.__oO0O_0.().TabIndex = 19
			Me.OOO.__oO0O_0.().Text = "选择统计列:"
			Me.oO._0O.().AutoSize = True
			Me.oO._0O.().Location = New Point(19, 60)
			Me.oO._0O.().Margin = New Padding(4, 0, 4, 0)
			Me.oO._0O.().Name = "Label1"
			Me.oO._0O.().Size = New Size(120, 15)
			Me.oO._0O.().TabIndex = 18
			Me.oO._0O.().Text = "选择水平分组列:"
			Me.oO._0O.().AllowDelete = True
			Me.oO._0O.().AllowDragging = 0
			Me.oO._0O.().BorderStyle = 4
			Me.oO._0O.().ColumnInfo = componentResourceManager.GetString("HGroupGrid.ColumnInfo")
			Me.oO._0O.().ContextMenuStrip = Me.O0_.o0oo0_0_O0.()
			Me.oO._0O.().ExtendLastCol = True
			Me.oO._0O.().HighLight = 2
			Me.oO._0O.().Location = New Point(19, 85)
			Me.oO._0O.().Margin = New Padding(4, 3, 4, 3)
			Me.oO._0O.().Name = "HGroupGrid"
			Me.oO._0O.().Rows.Count = 1
			Me.oO._0O.().Rows.DefaultSize = 19
			Me.oO._0O.().SelectionMode = 3
			Me.oO._0O.().ShowThemedHeaders = 1
			Me.oO._0O.().Size = New Size(743, 97)
			Me.oO._0O.().TabIndex = 2
			Me.oo.O0ooO_.().AutoSize = True
			Me.oo.O0ooO_.().Location = New Point(19, 191)
			Me.oo.O0ooO_.().Margin = New Padding(4, 0, 4, 0)
			Me.oo.O0ooO_.().Name = "Label10"
			Me.oo.O0ooO_.().Size = New Size(120, 15)
			Me.oo.O0ooO_.().TabIndex = 34
			Me.oo.O0ooO_.().Text = "选择垂直分组列:"
			Me.o_0Oo.O00OOoO.().AllowDelete = True
			Me.o_0Oo.O00OOoO.().AllowDragging = 0
			Me.o_0Oo.O00OOoO.().BorderStyle = 4
			Me.o_0Oo.O00OOoO.().ColumnInfo = componentResourceManager.GetString("VGroupGrid.ColumnInfo")
			Me.o_0Oo.O00OOoO.().ContextMenuStrip = Me.O0_.o0oo0_0_O0.()
			Me.o_0Oo.O00OOoO.().ExtendLastCol = True
			Me.o_0Oo.O00OOoO.().HighLight = 2
			Me.o_0Oo.O00OOoO.().Location = New Point(19, 215)
			Me.o_0Oo.O00OOoO.().Margin = New Padding(4, 3, 4, 3)
			Me.o_0Oo.O00OOoO.().Name = "VGroupGrid"
			Me.o_0Oo.O00OOoO.().Rows.Count = 1
			Me.o_0Oo.O00OOoO.().Rows.DefaultSize = 19
			Me.o_0Oo.O00OOoO.().SelectionMode = 3
			Me.o_0Oo.O00OOoO.().ShowThemedHeaders = 1
			Me.o_0Oo.O00OOoO.().Size = New Size(743, 97)
			Me.o_0Oo.O00OOoO.().TabIndex = 3
			Me.O.0O_Oo.().AutoSize = True
			Me.O.0O_Oo.().BorderStyle = BorderStyle.None
			Me.O.0O_Oo.().Location = New Point(27, 25)
			Me.O.0O_Oo.().Margin = New Padding(4, 3, 4, 3)
			Me.O.0O_Oo.().Name = "chkOrderByTotal"
			Me.O.0O_Oo.().Size = New Size(224, 19)
			Me.O.0O_Oo.().TabIndex = 0
			Me.O.0O_Oo.().Text = "同一统计列的数据排列在一起"
			Me.O.0O_Oo.().UseVisualStyleBackColor = True
			Me.O.0O_Oo.().Value = Nothing
			Me.o.oO_.().AutoSize = True
			Me.o.oO_.().BorderStyle = BorderStyle.None
			Me.o.oO_.().Location = New Point(27, 52)
			Me.o.oO_.().Margin = New Padding(4, 3, 4, 3)
			Me.o.oO_.().Name = "chkHorizontalTotal"
			Me.o.oO_.().Size = New Size(149, 19)
			Me.o.oO_.().TabIndex = 1
			Me.o.oO_.().Text = "水平方向自动汇总"
			Me.o.oO_.().UseVisualStyleBackColor = True
			Me.o.oO_.().Value = Nothing
			Me.o.00o0oO_oo_.().AutoSize = True
			Me.o.00o0oO_oo_.().BorderStyle = BorderStyle.None
			Me.o.00o0oO_oo_.().Location = New Point(27, 80)
			Me.o.00o0oO_oo_.().Margin = New Padding(4, 3, 4, 3)
			Me.o.00o0oO_oo_.().Name = "chkVerticalTotal"
			Me.o.00o0oO_oo_.().Size = New Size(149, 19)
			Me.o.00o0oO_oo_.().TabIndex = 2
			Me.o.00o0oO_oo_.().Text = "垂直方向自动汇总"
			Me.o.00o0oO_oo_.().UseVisualStyleBackColor = True
			Me.o.00o0oO_oo_.().Value = Nothing
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.O0_00.oo0.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.ooo0._0o00oO_.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.OO0OO0O0.o0_.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.oo.o0_0o.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.oo0o_._00O0O_.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o.__oOoo0O.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.O0_.o0oo0_0_O0.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o00_.O0.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.ooo.O0OO_.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o__.oOOoO.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o_0o00_.o0O_o.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.oO.00OOOO__o0.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o.oO_.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.O.0O_Oo.())
			Me.O0_.o0oo0_0_O0.().Controls.Add(Me.o.00o0oO_oo_.())
			Me.O0_.o0oo0_0_O0.().Location = New Point(19, 451)
			Me.O0_.o0oo0_0_O0.().Margin = New Padding(4, 3, 4, 3)
			Me.O0_.o0oo0_0_O0.().Name = "GroupBox1"
			Me.O0_.o0oo0_0_O0.().Padding = New Padding(4, 3, 4, 3)
			Me.O0_.o0oo0_0_O0.().Size = New Size(741, 112)
			Me.O0_.o0oo0_0_O0.().TabIndex = 5
			Me.O0_.o0oo0_0_O0.().TabStop = False
			Me.O0_.o0oo0_0_O0.().Text = "选项"
			Me.O0_00.oo0.().AutoSize = True
			Me.O0_00.oo0.().BorderStyle = BorderStyle.None
			Me.O0_00.oo0.().Location = New Point(381, 82)
			Me.O0_00.oo0.().Margin = New Padding(4, 3, 4, 3)
			Me.O0_00.oo0.().Name = "ChkCircleGrowth"
			Me.O0_00.oo0.().Size = New Size(89, 19)
			Me.O0_00.oo0.().TabIndex = 47
			Me.O0_00.oo0.().Text = "生成环比"
			Me.O0_00.oo0.().UseVisualStyleBackColor = True
			Me.O0_00.oo0.().Value = Nothing
			Me.ooo0._0o00oO_.().AutoSize = True
			Me.ooo0._0o00oO_.().BorderStyle = BorderStyle.None
			Me.ooo0._0o00oO_.().Location = New Point(275, 82)
			Me.ooo0._0o00oO_.().Margin = New Padding(4, 3, 4, 3)
			Me.ooo0._0o00oO_.().Name = "chkSameGrowth"
			Me.ooo0._0o00oO_.().Size = New Size(89, 19)
			Me.ooo0._0o00oO_.().TabIndex = 46
			Me.ooo0._0o00oO_.().Text = "生成同比"
			Me.ooo0._0o00oO_.().UseVisualStyleBackColor = True
			Me.ooo0._0o00oO_.().Value = Nothing
			Me.OO0OO0O0.o0_.().AutoSize = True
			Me.OO0OO0O0.o0_.().BorderStyle = BorderStyle.None
			Me.OO0OO0O0.o0_.().Location = New Point(573, 52)
			Me.OO0OO0O0.o0_.().Margin = New Padding(4, 3, 4, 3)
			Me.OO0OO0O0.o0_.().Name = "chkSubtotal"
			Me.OO0OO0O0.o0_.().Size = New Size(149, 19)
			Me.OO0OO0O0.o0_.().TabIndex = 45
			Me.OO0OO0O0.o0_.().Text = "自动生成汇总模式"
			Me.OO0OO0O0.o0_.().UseVisualStyleBackColor = True
			Me.OO0OO0O0.o0_.().Value = Nothing
			Me.oo.o0_0o.().AutoSize = True
			Me.oo.o0_0o.().BorderStyle = BorderStyle.None
			Me.oo.o0_0o.().Location = New Point(573, 82)
			Me.oo.o0_0o.().Margin = New Padding(4, 3, 4, 3)
			Me.oo.o0_0o.().Name = "chkFromServer"
			Me.oo.o0_0o.().Size = New Size(149, 19)
			Me.oo.o0_0o.().TabIndex = 44
			Me.oo.o0_0o.().Text = "直接统计后台数据"
			Me.oo.o0_0o.().UseVisualStyleBackColor = True
			Me.oo.o0_0o.().Value = Nothing
			Me.oo0o_._00O0O_.().AutoSize = True
			Me.oo0o_._00O0O_.().Location = New Point(573, 27)
			Me.oo0o_._00O0O_.().Margin = New Padding(4, 0, 4, 0)
			Me.oo0o_._00O0O_.().Name = "Label8"
			Me.oo0o_._00O0O_.().Size = New Size(75, 15)
			Me.oo0o_._00O0O_.().TabIndex = 43
			Me.oo0o_._00O0O_.().Text = "小数位数:"
			Me.o.__oOoo0O.().Location = New Point(432, 50)
			Me.o.__oOoo0O.().Margin = New Padding(4, 3, 4, 3)
			Me.o.__oOoo0O.().Name = "txtHorizontalProportionCaption"
			Me.o.__oOoo0O.().Size = New Size(92, 23)
			Me.o.__oOoo0O.().TabIndex = 6
			Me.o.__oOoo0O.().Tag = Nothing
			Me.O0_.o0oo0_0_O0.().DataType = GetType(Integer)
			Me.O0_.o0oo0_0_O0.().ImagePadding = New Padding(0)
			Me.O0_.o0oo0_0_O0.().Location = New Point(660, 22)
			Me.O0_.o0oo0_0_O0.().Margin = New Padding(4, 3, 4, 3)
			Me.O0_.o0oo0_0_O0.().Name = "Decimals"
			Me.O0_.o0oo0_0_O0.().Size = New Size(68, 23)
			Me.O0_.o0oo0_0_O0.().TabIndex = 42
			Me.O0_.o0oo0_0_O0.().Tag = Nothing
			Me.O0_.o0oo0_0_O0.().Value = 4
			Me.O0_.o0oo0_0_O0.().VisibleButtons = 1
			Me.o00_.O0.().Location = New Point(432, 22)
			Me.o00_.O0.().Margin = New Padding(4, 3, 4, 3)
			Me.o00_.O0.().Name = "txtVerticalProportionCaption"
			Me.o00_.O0.().Size = New Size(92, 23)
			Me.o00_.O0.().TabIndex = 4
			Me.o00_.O0.().Tag = Nothing
			Me.ooo.O0OO_.().AutoSize = True
			Me.ooo.O0OO_.().Location = New Point(379, 55)
			Me.ooo.O0OO_.().Margin = New Padding(4, 0, 4, 0)
			Me.ooo.O0OO_.().Name = "Label7"
			Me.ooo.O0OO_.().Size = New Size(45, 15)
			Me.ooo.O0OO_.().TabIndex = 41
			Me.ooo.O0OO_.().Text = "标题:"
			Me.o__.oOOoO.().AutoSize = True
			Me.o__.oOOoO.().Location = New Point(379, 27)
			Me.o__.oOOoO.().Margin = New Padding(4, 0, 4, 0)
			Me.o__.oOOoO.().Name = "Label6"
			Me.o__.oOOoO.().Size = New Size(45, 15)
			Me.o__.oOOoO.().TabIndex = 40
			Me.o__.oOOoO.().Text = "标题:"
			Me.o_0o00_.o0O_o.().AutoSize = True
			Me.o_0o00_.o0O_o.().BorderStyle = BorderStyle.None
			Me.o_0o00_.o0O_o.().Location = New Point(275, 52)
			Me.o_0o00_.o0O_o.().Margin = New Padding(4, 3, 4, 3)
			Me.o_0o00_.o0O_o.().Name = "chkHorizontalProportion"
			Me.o_0o00_.o0O_o.().Size = New Size(89, 19)
			Me.o_0o00_.o0O_o.().TabIndex = 5
			Me.o_0o00_.o0O_o.().Text = "水平份额"
			Me.o_0o00_.o0O_o.().UseVisualStyleBackColor = True
			Me.o_0o00_.o0O_o.().Value = Nothing
			Me.oO.00OOOO__o0.().AutoSize = True
			Me.oO.00OOOO__o0.().BorderStyle = BorderStyle.None
			Me.oO.00OOOO__o0.().Location = New Point(275, 23)
			Me.oO.00OOOO__o0.().Margin = New Padding(4, 3, 4, 3)
			Me.oO.00OOOO__o0.().Name = "chkVerticalProportion"
			Me.oO.00OOOO__o0.().Size = New Size(89, 19)
			Me.oO.00OOOO__o0.().TabIndex = 3
			Me.oO.00OOOO__o0.().Text = "垂直占比"
			Me.oO.00OOOO__o0.().UseVisualStyleBackColor = True
			Me.oO.00OOOO__o0.().Value = Nothing
			MyBase.AutoScaleDimensions = New SizeF(8F, 15F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(786, 647)
			MyBase.Controls.Add(Me.O0_.o0oo0_0_O0.())
			MyBase.Controls.Add(Me.oo.O0ooO_.())
			MyBase.Controls.Add(Me.o_0Oo.O00OOoO.())
			MyBase.Controls.Add(Me.oOo_ooo_0O._o.())
			MyBase.Controls.Add(Me.OO00.OO_0o_0o.())
			MyBase.Controls.Add(Me.o_0o00_.o0O_o.())
			MyBase.Controls.Add(Me.Ooo0OOoo._____.())
			MyBase.Controls.Add(Me.O_oo.0OO.())
			MyBase.Controls.Add(Me.OoOoo.Oooo00.())
			MyBase.Controls.Add(Me.oOo_ooo_0O._o.())
			MyBase.Controls.Add(Me.oo0OOO.Oo__00.())
			MyBase.Controls.Add(Me.O.0O_Oo.())
			MyBase.Controls.Add(Me.O0OO.oOOo.())
			MyBase.Controls.Add(Me.oO._0O.())
			MyBase.Controls.Add(Me.O_.O0oOOo.())
			MyBase.Controls.Add(Me.OOO.__oO0O_0.())
			MyBase.Controls.Add(Me.oO._0O.())
			MyBase.Controls.Add(Me.o_0Oo.O00OOoO.())
			MyBase.Controls.Add(Me.O.0o_0O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 3, 4, 3)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O1.o.I11."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "交叉统计"
			Me.o_0o00_.o0O_o.().EndInit()
			Me.oOo_ooo_0O._o.().EndInit()
			Me.O0_.o0oo0_0_O0.().ResumeLayout(False)
			Me.Ooo0OOoo._____.().EndInit()
			Me.OoOoo.Oooo00.().EndInit()
			Me.O_oo.0OO.().EndInit()
			Me.O.0O_Oo.().EndInit()
			Me.OO00.OO_0o_0o.().EndInit()
			Me.oo0OOO.Oo__00.().EndInit()
			Me.O_.O0oOOo.().EndInit()
			Me.o_0Oo.O00OOoO.().EndInit()
			Me.oO._0O.().EndInit()
			Me.o_0Oo.O00OOoO.().EndInit()
			Me.O.0O_Oo.().EndInit()
			Me.o.oO_.().EndInit()
			Me.o.00o0oO_oo_.().EndInit()
			Me.O0_.o0oo0_0_O0.().ResumeLayout(False)
			Me.O0_.o0oo0_0_O0.().PerformLayout()
			Me.O0_00.oo0.().EndInit()
			Me.ooo0._0o00oO_.().EndInit()
			Me.OO0OO0O0.o0_.().EndInit()
			Me.oo.o0_0o.().EndInit()
			Me.o.__oOoo0O.().EndInit()
			Me.O0_.o0oo0_0_O0.().EndInit()
			Me.o00_.O0.().EndInit()
			Me.o_0o00_.o0O_o.().EndInit()
			Me.oO.00OOOO__o0.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003217 RID: 12823 RVA: 0x00147306 File Offset: 0x00145506
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.___0_00_oo.
		End Function

		' Token: 0x06003218 RID: 12824 RVA: 0x00147310 File Offset: 0x00145510
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O.OOoo.
			Dim c1Button As C1Button = Me.o.___0_00_oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.___0_00_oo. = A_0
			c1Button = Me.o.___0_00_oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003219 RID: 12825 RVA: 0x00147353 File Offset: 0x00145553
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_0O_o_0oO0._O.
		End Function

		' Token: 0x0600321A RID: 12826 RVA: 0x0014735C File Offset: 0x0014555C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o.o00_O00.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.o.___0_00_oo.
			Dim o_0O_o_0oO0._O. As C1FlexGrid = Me.O_0O_o_0oO0._O.
			If o_0O_o_0oO0._O. IsNot Nothing Then
				o_0O_o_0oO0._O..AfterEdit -= rowColEventHandler
				o_0O_o_0oO0._O..BeforeEdit -= rowColEventHandler2
			End If
			Me.O_0O_o_0oO0._O. = A_0
			o_0O_o_0oO0._O. = Me.O_0O_o_0oO0._O.
			If o_0O_o_0oO0._O. IsNot Nothing Then
				o_0O_o_0oO0._O..AfterEdit += rowColEventHandler
				o_0O_o_0oO0._O..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x0600321B RID: 12827 RVA: 0x001473BA File Offset: 0x001455BA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o00_O00.
		End Function

		' Token: 0x0600321C RID: 12828 RVA: 0x001473C2 File Offset: 0x001455C2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o.o00_O00. = A_0
		End Sub

		' Token: 0x0600321D RID: 12829 RVA: 0x001473CB File Offset: 0x001455CB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_0Oo.o.
		End Function

		' Token: 0x0600321E RID: 12830 RVA: 0x001473D4 File Offset: 0x001455D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__.O_Oo0o.
			Dim o_0Oo.o. As C1Button = Me.O_0Oo.o.
			If o_0Oo.o. IsNot Nothing Then
				RemoveHandler o_0Oo.o..Click, value
			End If
			Me.O_0Oo.o. = A_0
			o_0Oo.o. = Me.O_0Oo.o.
			If o_0Oo.o. IsNot Nothing Then
				AddHandler o_0Oo.o..Click, value
			End If
		End Sub

		' Token: 0x0600321F RID: 12831 RVA: 0x00147417 File Offset: 0x00145617
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OoO_Oo0oooO.oO.
		End Function

		' Token: 0x06003220 RID: 12832 RVA: 0x00147420 File Offset: 0x00145620
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.o00_0.
			Dim ooO_Oo0oooO.oO. As C1Button = Me.OoO_Oo0oooO.oO.
			If ooO_Oo0oooO.oO. IsNot Nothing Then
				RemoveHandler ooO_Oo0oooO.oO..Click, value
			End If
			Me.OoO_Oo0oooO.oO. = A_0
			ooO_Oo0oooO.oO. = Me.OoO_Oo0oooO.oO.
			If ooO_Oo0oooO.oO. IsNot Nothing Then
				AddHandler ooO_Oo0oooO.oO..Click, value
			End If
		End Sub

		' Token: 0x06003221 RID: 12833 RVA: 0x00147463 File Offset: 0x00145663
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_o__0.oo.
		End Function

		' Token: 0x06003222 RID: 12834 RVA: 0x0014746C File Offset: 0x0014566C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0oOO.0.
			Dim c1Button As C1Button = Me.oO_o__0.oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_o__0.oo. = A_0
			c1Button = Me.oO_o__0.oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003223 RID: 12835 RVA: 0x001474AF File Offset: 0x001456AF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O_0O_o_0oO0._O.
		End Function

		' Token: 0x06003224 RID: 12836 RVA: 0x001474B7 File Offset: 0x001456B7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O_0O_o_0oO0._O. = A_0
		End Sub

		' Token: 0x06003225 RID: 12837 RVA: 0x001474C0 File Offset: 0x001456C0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_0O_o_0oO0._O.
		End Function

		' Token: 0x06003226 RID: 12838 RVA: 0x001474C8 File Offset: 0x001456C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_0O_o_0oO0._O. = A_0
		End Sub

		' Token: 0x06003227 RID: 12839 RVA: 0x001474D1 File Offset: 0x001456D1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oOO00.O__0o.
		End Function

		' Token: 0x06003228 RID: 12840 RVA: 0x001474DC File Offset: 0x001456DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As CancelEventHandler = AddressOf Me.o.___0_00_oo.
			Dim c1TextBox As C1TextBox = Me.oOO00.O__0o.
			If c1TextBox IsNot Nothing Then
				RemoveHandler c1TextBox.Validating, value
			End If
			Me.oOO00.O__0o. = A_0
			c1TextBox = Me.oOO00.O__0o.
			If c1TextBox IsNot Nothing Then
				AddHandler c1TextBox.Validating, value
			End If
		End Sub

		' Token: 0x06003229 RID: 12841 RVA: 0x0014751F File Offset: 0x0014571F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.O_O0.
		End Function

		' Token: 0x0600322A RID: 12842 RVA: 0x00147527 File Offset: 0x00145727
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.O_O0. = A_0
		End Sub

		' Token: 0x0600322B RID: 12843 RVA: 0x00147530 File Offset: 0x00145730
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OoO.OoOo__O_O.
		End Function

		' Token: 0x0600322C RID: 12844 RVA: 0x00147538 File Offset: 0x00145738
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__0oo._0_.
			Dim ooO.OoOo__O_O. As C1Button = Me.OoO.OoOo__O_O.
			If ooO.OoOo__O_O. IsNot Nothing Then
				RemoveHandler ooO.OoOo__O_O..Click, value
			End If
			Me.OoO.OoOo__O_O. = A_0
			ooO.OoOo__O_O. = Me.OoO.OoOo__O_O.
			If ooO.OoOo__O_O. IsNot Nothing Then
				AddHandler ooO.OoOo__O_O..Click, value
			End If
		End Sub

		' Token: 0x0600322D RID: 12845 RVA: 0x0014757B File Offset: 0x0014577B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oOO.oOOoo_o_Oo.
		End Function

		' Token: 0x0600322E RID: 12846 RVA: 0x00147583 File Offset: 0x00145783
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oOO.oOOoo_o_Oo. = A_0
		End Sub

		' Token: 0x0600322F RID: 12847 RVA: 0x0014758C File Offset: 0x0014578C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0o0._.
		End Function

		' Token: 0x06003230 RID: 12848 RVA: 0x00147594 File Offset: 0x00145794
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0o0._. = A_0
		End Sub

		' Token: 0x06003231 RID: 12849 RVA: 0x0014759D File Offset: 0x0014579D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_Ooo0.oo.
		End Function

		' Token: 0x06003232 RID: 12850 RVA: 0x001475A5 File Offset: 0x001457A5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_Ooo0.oo. = A_0
		End Sub

		' Token: 0x06003233 RID: 12851 RVA: 0x001475AE File Offset: 0x001457AE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Ooo_O_0.ooO.
		End Function

		' Token: 0x06003234 RID: 12852 RVA: 0x001475B6 File Offset: 0x001457B6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Ooo_O_0.ooO. = A_0
		End Sub

		' Token: 0x06003235 RID: 12853 RVA: 0x001475BF File Offset: 0x001457BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O.O_O0.
		End Function

		' Token: 0x06003236 RID: 12854 RVA: 0x001475C8 File Offset: 0x001457C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o.__oOoo0O.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.O_.ooo.
			Dim o.O_O0. As C1FlexGrid = Me.O.O_O0.
			If o.O_O0. IsNot Nothing Then
				o.O_O0..AfterEdit -= rowColEventHandler
				o.O_O0..BeforeEdit -= rowColEventHandler2
			End If
			Me.O.O_O0. = A_0
			o.O_O0. = Me.O.O_O0.
			If o.O_O0. IsNot Nothing Then
				o.O_O0..AfterEdit += rowColEventHandler
				o.O_O0..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x06003237 RID: 12855 RVA: 0x00147626 File Offset: 0x00145826
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO0oo0o0ooO._O.
		End Function

		' Token: 0x06003238 RID: 12856 RVA: 0x0014762E File Offset: 0x0014582E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO0oo0o0ooO._O. = A_0
		End Sub

		' Token: 0x06003239 RID: 12857 RVA: 0x00147637 File Offset: 0x00145837
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O__o._O0o0o.
		End Function

		' Token: 0x0600323A RID: 12858 RVA: 0x00147640 File Offset: 0x00145840
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o.__oOoo0O.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.O_.ooo.
			Dim o__o._O0o0o. As C1FlexGrid = Me.O__o._O0o0o.
			If o__o._O0o0o. IsNot Nothing Then
				o__o._O0o0o..AfterEdit -= rowColEventHandler
				o__o._O0o0o..BeforeEdit -= rowColEventHandler2
			End If
			Me.O__o._O0o0o. = A_0
			o__o._O0o0o. = Me.O__o._O0o0o.
			If o__o._O0o0o. IsNot Nothing Then
				o__o._O0o0o..AfterEdit += rowColEventHandler
				o__o._O0o0o..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x0600323B RID: 12859 RVA: 0x0014769E File Offset: 0x0014589E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.O00_0oo._.
		End Function

		' Token: 0x0600323C RID: 12860 RVA: 0x001476A6 File Offset: 0x001458A6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.O00_0oo._. = A_0
		End Sub

		' Token: 0x0600323D RID: 12861 RVA: 0x001476B0 File Offset: 0x001458B0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oOo0o._0_O.
		End Function

		' Token: 0x0600323E RID: 12862 RVA: 0x001476C4 File Offset: 0x001458C4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O00._.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oOo0o._0_O.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							Return
						Case 1
							GoTo IL_62
						Case 2
							If True Then
							End If
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							GoTo IL_62
						Case 3
							RemoveHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
						Case 4
							AddHandler toolStripMenuItem.Click, value
							num = 0
							Continue For
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
					End Select
					Exit For
					IL_62:
					Me.oOo0o._0_O. = A_0
					toolStripMenuItem = Me.oOo0o._0_O.
					num = 5
				End While
			End While
		End Sub

		' Token: 0x0600323F RID: 12863 RVA: 0x00147770 File Offset: 0x00145970
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.Ooo.0.
		End Function

		' Token: 0x06003240 RID: 12864 RVA: 0x00147784 File Offset: 0x00145984
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oo_._.
				Dim ooo.0. As ToolStripMenuItem = Me.Ooo.0.
				Dim num As Integer = 0
				While True
					Select Case num
						Case 0
							If ooo.0. IsNot Nothing Then
								If True Then
								End If
								num = 2
								Continue For
							End If
							GoTo IL_62
						Case 1
							GoTo IL_62
						Case 2
							RemoveHandler ooo.0..Click, value
							num = 1
							Continue For
						Case 3
							If ooo.0. IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 4
							AddHandler ooo.0..Click, value
							num = 5
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.Ooo.0. = A_0
					ooo.0. = Me.Ooo.0.
					num = 3
				End While
			End While
		End Sub

		' Token: 0x06003241 RID: 12865 RVA: 0x00147830 File Offset: 0x00145A30
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oOO.oOOoo_o_Oo.
		End Function

		' Token: 0x06003242 RID: 12866 RVA: 0x00147844 File Offset: 0x00145A44
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.OoO__00._OoO0_.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oOO.oOOoo_o_Oo.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							If toolStripMenuItem IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 1
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 2
							AddHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 3
							Return
						Case 4
							If toolStripMenuItem IsNot Nothing Then
								num = 1
								Continue For
							End If
							GoTo IL_5A
						Case 5
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.oOO.oOOoo_o_Oo. = A_0
					toolStripMenuItem = Me.oOO.oOOoo_o_Oo.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x06003243 RID: 12867 RVA: 0x001478EC File Offset: 0x00145AEC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_Ooo0.oo.
		End Function

		' Token: 0x06003244 RID: 12868 RVA: 0x00147900 File Offset: 0x00145B00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o.__oOoo0O.
				Dim o_Ooo0.oo. As ToolStripMenuItem = Me.O_Ooo0.oo.
				Dim num As Integer = 0
				While True
					Select Case num
						Case 0
							If o_Ooo0.oo. IsNot Nothing Then
								num = 5
								Continue For
							End If
							GoTo IL_5A
						Case 1
							Return
						Case 2
							AddHandler o_Ooo0.oo..Click, value
							num = 1
							Continue For
						Case 3
							GoTo IL_5A
						Case 4
							If o_Ooo0.oo. IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 5
							If True Then
							End If
							RemoveHandler o_Ooo0.oo..Click, value
							num = 3
							Continue For
					End Select
					Exit For
					IL_5A:
					Me.O_Ooo0.oo. = A_0
					o_Ooo0.oo. = Me.O_Ooo0.oo.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x06003245 RID: 12869 RVA: 0x001479A6 File Offset: 0x00145BA6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O00_0oo._.
		End Function

		' Token: 0x06003246 RID: 12870 RVA: 0x001479AE File Offset: 0x00145BAE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O00_0oo._. = A_0
		End Sub

		' Token: 0x06003247 RID: 12871 RVA: 0x001479B7 File Offset: 0x00145BB7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oo.O___.
		End Function

		' Token: 0x06003248 RID: 12872 RVA: 0x001479BF File Offset: 0x00145BBF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Oo.O___. = A_0
		End Sub

		' Token: 0x06003249 RID: 12873 RVA: 0x001479C8 File Offset: 0x00145BC8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0oO_o_.o.
		End Function

		' Token: 0x0600324A RID: 12874 RVA: 0x001479D0 File Offset: 0x00145BD0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0oO_o_.o. = A_0
		End Sub

		' Token: 0x0600324B RID: 12875 RVA: 0x001479D9 File Offset: 0x00145BD9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.oOo0o._0_O.
		End Function

		' Token: 0x0600324C RID: 12876 RVA: 0x001479E1 File Offset: 0x00145BE1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.oOo0o._0_O. = A_0
		End Sub

		' Token: 0x0600324D RID: 12877 RVA: 0x001479EA File Offset: 0x00145BEA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oO0__OOO_.0Oo.
		End Function

		' Token: 0x0600324E RID: 12878 RVA: 0x001479F2 File Offset: 0x00145BF2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oO0__OOO_.0Oo. = A_0
		End Sub

		' Token: 0x0600324F RID: 12879 RVA: 0x001479FB File Offset: 0x00145BFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0_0OO._O.
		End Function

		' Token: 0x06003250 RID: 12880 RVA: 0x00147A03 File Offset: 0x00145C03
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O0_0OO._O. = A_0
		End Sub

		' Token: 0x06003251 RID: 12881 RVA: 0x00147A0C File Offset: 0x00145C0C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo.0_O.
		End Function

		' Token: 0x06003252 RID: 12882 RVA: 0x00147A14 File Offset: 0x00145C14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo.0_O. = A_0
		End Sub

		' Token: 0x06003253 RID: 12883 RVA: 0x00147A1D File Offset: 0x00145C1D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo0_oo0_oo_._.
		End Function

		' Token: 0x06003254 RID: 12884 RVA: 0x00147A25 File Offset: 0x00145C25
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo0_oo0_oo_._. = A_0
		End Sub

		' Token: 0x06003255 RID: 12885 RVA: 0x00147A2E File Offset: 0x00145C2E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.oO0.0oo_o0_O_.
		End Function

		' Token: 0x06003256 RID: 12886 RVA: 0x00147A36 File Offset: 0x00145C36
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.oO0.0oo_o0_O_. = A_0
		End Sub

		' Token: 0x06003257 RID: 12887 RVA: 0x00147A3F File Offset: 0x00145C3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Ooo__o._o_o0_.
		End Function

		' Token: 0x06003258 RID: 12888 RVA: 0x00147A47 File Offset: 0x00145C47
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Ooo__o._o_o0_. = A_0
		End Sub

		' Token: 0x06003259 RID: 12889 RVA: 0x00147A50 File Offset: 0x00145C50
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo0.o0.
		End Function

		' Token: 0x0600325A RID: 12890 RVA: 0x00147A58 File Offset: 0x00145C58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo0.o0. = A_0
		End Sub

		' Token: 0x0600325B RID: 12891 RVA: 0x00147A61 File Offset: 0x00145C61
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.oOo0o._0_O.
		End Function

		' Token: 0x0600325C RID: 12892 RVA: 0x00147A69 File Offset: 0x00145C69
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.oOo0o._0_O. = A_0
		End Sub

		' Token: 0x0600325D RID: 12893 RVA: 0x00147A72 File Offset: 0x00145C72
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O.Oo0o0O0OO.
		End Function

		' Token: 0x0600325E RID: 12894 RVA: 0x00147A7C File Offset: 0x00145C7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.O_.0oOoOO0_ooo.
			Dim o.Oo0o0O0OO. As C1CheckBox = Me.O.Oo0o0O0OO.
			If o.Oo0o0O0OO. IsNot Nothing Then
				RemoveHandler o.Oo0o0O0OO..CheckedChanged, value
			End If
			Me.O.Oo0o0O0OO. = A_0
			o.Oo0o0O0OO. = Me.O.Oo0o0O0OO.
			If o.Oo0o0O0OO. IsNot Nothing Then
				AddHandler o.Oo0o0O0OO..CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600325F RID: 12895 RVA: 0x00147ABF File Offset: 0x00145CBF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o00.00.
		End Function

		' Token: 0x06003260 RID: 12896 RVA: 0x00147AC7 File Offset: 0x00145CC7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o00.00. = A_0
		End Sub

		' Token: 0x06003261 RID: 12897 RVA: 0x00147AD0 File Offset: 0x00145CD0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0_o_0._0__.
		End Function

		' Token: 0x06003262 RID: 12898 RVA: 0x00147AD8 File Offset: 0x00145CD8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O0_o_0._0__. = A_0
		End Sub

		' Token: 0x06003263 RID: 12899 RVA: 0x00147AE1 File Offset: 0x00145CE1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0_OO___._o.
		End Function

		' Token: 0x06003264 RID: 12900 RVA: 0x00147AE9 File Offset: 0x00145CE9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O0_OO___._o. = A_0
		End Sub

		' Token: 0x06003265 RID: 12901 RVA: 0x00147AF4 File Offset: 0x00145CF4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
				IL_10:
				num2 = 3
				If Operators.CompareString(c1FlexGrid.Cols(A_1.Col).Name, "Name", True) <> 0 Then
					GoTo IL_186
				End If
				IL_38:
				num2 = 4
				If c1FlexGrid.GetData(A_1.Row, "Name") Is Nothing Then
					GoTo IL_266
				End If
				IL_50:
				num2 = 6
				Dim text As String = c1FlexGrid.GetData(A_1.Row, "Name").ToString()
				IL_6A:
				num2 = 7
				If Operators.CompareString(text, "", True) = 0 Then
					GoTo IL_266
				End If
				IL_7E:
				num2 = 9
				If Me.o0_0O_O0.O_O0..DataTable.DataCols(text).IsDate Then
					GoTo IL_F4
				End If
				IL_9F:
				num2 = 10
				c1FlexGrid(A_1.Row, "DateGroup") = Nothing
				IL_B4:
				num2 = 11
				If c1FlexGrid <> Me.o_0Oo.O00OOoO.() Then
					GoTo IL_DA
				End If
				IL_C0:
				num2 = 12
				c1FlexGrid(A_1.Row, "Pattern") = Nothing
				GoTo IL_186
				IL_DA:
				num2 = 14
				c1FlexGrid(A_1.Row, "NewName") = Nothing
				GoTo IL_186
				IL_F4:
				num2 = 16
				If c1FlexGrid(A_1.Row, "DateGroup") IsNot Nothing Then
					GoTo IL_186
				End If
				IL_10A:
				num2 = 17
				c1FlexGrid(A_1.Row, "DateGroup") = 3
				IL_124:
				num2 = 18
				If c1FlexGrid <> Me.oO._0O.() Then
					GoTo IL_157
				End If
				IL_130:
				num2 = 19
				c1FlexGrid(A_1.Row, "NewName") = c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup")
				GoTo IL_186
				IL_157:
				num2 = 21
				c1FlexGrid(A_1.Row, "Pattern") = "{0}" + c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup")
				IL_186:
				num2 = 22
				If Operators.CompareString(c1FlexGrid.Cols(A_1.Col).Name, "DateGroup", True) <> 0 Then
					GoTo IL_266
				End If
				IL_1AF:
				num2 = 23
				If Conversions.ToInteger(c1FlexGrid(A_1.Row, "DateGroup")) = 0 Then
					GoTo IL_22E
				End If
				IL_1CA:
				num2 = 24
				If c1FlexGrid <> Me.oO._0O.() Then
					GoTo IL_1FD
				End If
				IL_1D6:
				num2 = 25
				c1FlexGrid(A_1.Row, "NewName") = c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup")
				GoTo IL_266
				IL_1FD:
				num2 = 27
				c1FlexGrid(A_1.Row, "Pattern") = "{0}" + c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup")
				GoTo IL_266
				IL_22E:
				num2 = 29
				If c1FlexGrid <> Me.oO._0O.() Then
					GoTo IL_251
				End If
				IL_23A:
				num2 = 30
				c1FlexGrid(A_1.Row, "NewName") = Nothing
				GoTo IL_266
				IL_251:
				num2 = 32
				c1FlexGrid(A_1.Row, "Pattern") = Nothing
				IL_266:
				GoTo IL_33C
				IL_26B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2FD:
				GoTo IL_331
				IL_2FF:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_30F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2FF
			End Try
			IL_331:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_33C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003266 RID: 12902 RVA: 0x00147E64 File Offset: 0x00146064
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 Then
				Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
				If Operators.CompareString(c1FlexGrid.Cols(A_1.Col).Name, "DateGroup", True) = 0 Then
					If c1FlexGrid.GetData(A_1.Row, "Name") Is Nothing Then
						A_1.Cancel = True
						Return
					End If
					Dim text As String = c1FlexGrid.GetData(A_1.Row, "Name").ToString()
					If Operators.CompareString(text, "", True) = 0 OrElse Not Me.o0_0O_O0.O_O0..DataTable.DataCols(text).IsDate Then
						A_1.Cancel = True
					End If
				End If
			End If
		End Sub

		' Token: 0x06003267 RID: 12903 RVA: 0x00147F0C File Offset: 0x0014610C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Operators.CompareString(Me.oOo_ooo_0O._o.().Cols(A_1.Col).Name, "Name", True) = 0 AndAlso Me.oOo_ooo_0O._o.().GetData(A_1.Row, "Name") IsNot Nothing Then
				Dim text As String = Me.oOo_ooo_0O._o.().GetData(A_1.Row, "Name").ToString()
				If Operators.CompareString(text, "", True) <> 0 Then
					If Not Me.o0_0O_O0.O_O0..DataTable.DataCols(text).IsNumeric Then
						Me.oOo_ooo_0O._o.()(A_1.Row, "Aggregate") = 4
						Return
					End If
					If Me.oOo_ooo_0O._o.()(A_1.Row, "Aggregate") Is Nothing Then
						Me.oOo_ooo_0O._o.()(A_1.Row, "Aggregate") = 2
					End If
				End If
			End If
		End Sub

		' Token: 0x06003268 RID: 12904 RVA: 0x00147FF8 File Offset: 0x001461F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso Operators.CompareString(Me.oOo_ooo_0O._o.().Cols(A_1.Col).Name, "Aggregate", True) = 0 Then
				If Me.oOo_ooo_0O._o.().GetData(A_1.Row, "Name") Is Nothing Then
					A_1.Cancel = True
					Return
				End If
				Dim text As String = Me.oOo_ooo_0O._o.().GetData(A_1.Row, "Name").ToString()
				If Operators.CompareString(text, "", True) = 0 OrElse Not Me.o0_0O_O0.O_O0..DataTable.DataCols(text).IsNumeric Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x06003269 RID: 12905 RVA: 0x001480A8 File Offset: 0x001462A8
		Private Function <<EMPTY_NAME>>() As CrossTableBuilder
			Dim num As Integer
			Dim result As CrossTableBuilder
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = Oo00.OoO_.__o.(Me.o0_0O_O0.O_O0., Me.oo.o0_0o.().Checked)
				IL_21:
				num2 = 3
				If Operators.CompareString(Me.oo0OOO.Oo__00.().Text.Trim(), "", True) <> 0 Then
					GoTo IL_5E
				End If
				IL_40:
				num2 = 4
				MessageBox.Show("请输入表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_55:
				num2 = 5
				result = Nothing
				GoTo IL_6C2
				IL_5E:
				num2 = 6
				If Operators.CompareString(Me.o_0Oo.O00OOoO.().Text.Trim(), "", True) <= 0 Then
					GoTo IL_C6
				End If
				IL_7E:
				num2 = 7
				If Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_A5
				End If
				IL_8F:
				num2 = 8
				text = Me.o_0Oo.O00OOoO.().Text.Trim()
				GoTo IL_C6
				IL_A5:
				num2 = 10
				text = text + " And " + Me.o_0Oo.O00OOoO.().Text.Trim()
				IL_C6:
				num2 = 11
				Dim crossTableBuilder As CrossTableBuilder = New CrossTableBuilder(Me.oo0OOO.Oo__00.().Text, Me.o0_0O_O0.O_O0..DataTable, text)
				IL_E8:
				num2 = 12
				crossTableBuilder.Caption = Me.OO00.OO_0o_0o.().Text
				IL_FD:
				num2 = 13
				Dim fixed As Integer = Me.oO._0O.().Rows.Fixed
				Dim num3 As Integer = Me.oO._0O.().Rows.Count - 2
				For i As Integer = fixed To num3
					IL_12B:
					num2 = 14
					If Me.oO._0O.().GetData(i, "Name") IsNot Nothing Then
						IL_145:
						num2 = 15
						Dim groupOn As GroupOn = New GroupOn()
						IL_14F:
						num2 = 16
						groupOn.Name = Me.oO._0O.()(i, "Name").ToString()
						IL_170:
						num2 = 17
						If Me.oO._0O.()(i, "DateGroup") IsNot Nothing Then
							IL_187:
							num2 = 18
							groupOn.DateGroup = Conversions.ToInteger(Me.oO._0O.()(i, "DateGroup"))
						End If
						IL_1A8:
						num2 = 19
						If Me.oO._0O.()(i, "NewName") IsNot Nothing Then
							IL_1BF:
							num2 = 20
							groupOn.NewName = Me.oO._0O.()(i, "NewName").ToString()
						End If
						IL_1E0:
						num2 = 21
						If Me.oO._0O.()(i, "NewCaption") IsNot Nothing Then
							IL_1F7:
							num2 = 22
							groupOn.NewCaption = Me.oO._0O.()(i, "NewCaption").ToString()
						End If
						IL_218:
						num2 = 23
						crossTableBuilder.HGroups.Add(groupOn)
					End If
					IL_229:
					num2 = 24
				Next
				IL_23B:
				num2 = 25
				Dim fixed2 As Integer = Me.o_0Oo.O00OOoO.().Rows.Fixed
				Dim num4 As Integer = Me.o_0Oo.O00OOoO.().Rows.Count - 2
				For j As Integer = fixed2 To num4
					IL_269:
					num2 = 26
					If Me.o_0Oo.O00OOoO.().GetData(j, "Name") IsNot Nothing Then
						IL_283:
						num2 = 27
						Dim crossGroupOn As CrossGroupOn = New CrossGroupOn()
						IL_28D:
						num2 = 28
						crossGroupOn.Name = Me.o_0Oo.O00OOoO.()(j, "Name").ToString()
						IL_2AE:
						num2 = 29
						If Me.o_0Oo.O00OOoO.()(j, "DateGroup") IsNot Nothing Then
							IL_2C5:
							num2 = 30
							crossGroupOn.DateGroup = Conversions.ToInteger(Me.o_0Oo.O00OOoO.()(j, "DateGroup"))
						End If
						IL_2E6:
						num2 = 31
						If Me.o_0Oo.O00OOoO.()(j, "Pattern") IsNot Nothing Then
							IL_2FD:
							num2 = 32
							crossGroupOn.Pattern = Me.o_0Oo.O00OOoO.()(j, "Pattern").ToString()
						End If
						IL_31E:
						num2 = 33
						crossTableBuilder.VGroups.Add(crossGroupOn)
					End If
					IL_32F:
					num2 = 34
				Next
				IL_341:
				num2 = 35
				Dim fixed3 As Integer = Me.oOo_ooo_0O._o.().Rows.Fixed
				Dim num5 As Integer = Me.oOo_ooo_0O._o.().Rows.Count - 2
				For k As Integer = fixed3 To num5
					IL_36F:
					num2 = 36
					If Me.oOo_ooo_0O._o.().GetData(k, "Name") IsNot Nothing Then
						IL_389:
						num2 = 37
						Dim crossTotalOn As CrossTotalOn = New CrossTotalOn(False)
						IL_394:
						num2 = 38
						crossTotalOn.Name = Me.oOo_ooo_0O._o.()(k, "Name").ToString()
						IL_3B5:
						num2 = 39
						If Me.oOo_ooo_0O._o.()(k, "Aggregate") IsNot Nothing Then
							IL_3CC:
							num2 = 40
							crossTotalOn.Aggregate = Conversions.ToInteger(Me.oOo_ooo_0O._o.()(k, "Aggregate"))
						End If
						IL_3ED:
						num2 = 41
						If Me.oOo_ooo_0O._o.()(k, "NewCaption") IsNot Nothing Then
							IL_404:
							num2 = 42
							crossTotalOn.Caption = Me.oOo_ooo_0O._o.()(k, "NewCaption").ToString()
						End If
						IL_425:
						num2 = 43
						crossTotalOn.upto = (Me.oOo_ooo_0O._o.().GetCellCheck(k, Me.oOo_ooo_0O._o.().Cols("upto").Index) = 1)
						IL_459:
						num2 = 44
						crossTableBuilder.Totals.Add(crossTotalOn)
					End If
					IL_46A:
					num2 = 45
				Next
				IL_47C:
				num2 = 46
				crossTableBuilder.OrderByTotal = Me.O.0O_Oo.().Checked
				IL_491:
				num2 = 47
				crossTableBuilder.HorizontalTotal = Me.o.oO_.().Checked
				IL_4A6:
				num2 = 48
				crossTableBuilder.VerticalTotal = Me.o.00o0oO_oo_.().Checked
				IL_4BB:
				num2 = 49
				crossTableBuilder.HorizontalProportionCaption = Me.o.__oOoo0O.().Text
				IL_4D0:
				num2 = 50
				crossTableBuilder.HorizontalProportion = Me.o_0o00_.o0O_o.().Checked
				IL_4E5:
				num2 = 51
				crossTableBuilder.VerticalProportionCaption = Me.o00_.O0.().Text
				IL_4FA:
				num2 = 52
				crossTableBuilder.VerticalProportion = Me.oO.00OOOO__o0.().Checked
				IL_50F:
				num2 = 53
				crossTableBuilder.SamePeriodGrowth = Me.ooo0._0o00oO_.().Checked
				IL_524:
				num2 = 54
				crossTableBuilder.CircleGrowth = Me.O0_00.oo0.().Checked
				IL_539:
				num2 = 55
				crossTableBuilder.Decimals = Conversions.ToInteger(Me.O0_.o0oo0_0_O0.().Value)
				IL_553:
				num2 = 56
				crossTableBuilder.FromServer = Me.oo.o0_0o.().Checked
				IL_568:
				num2 = 57
				If Me.o0_0O_O0.O_O0..O.OoOo_. Is Nothing OrElse Me.o0_0O_O0.O_O0..O.OoOo_..FindForm() IsNot Main.OO_O.o. OrElse Operators.CompareString(Me.o0_0O_O0.O_O0..DataTable.LoadTop, "", True) <= 0 OrElse Not Me.o0_0O_O0.O_O0..AllowBackEndFilter Then
					GoTo IL_68D
				End If
				IL_5C6:
				num2 = 58
				crossTableBuilder.FromServer = True
				IL_5D1:
				num2 = 59
				If Not Me.oo.o0_0o.().Checked Then
					GoTo IL_5EE
				End If
				IL_5E1:
				num2 = 60
				crossTableBuilder.FromAll = True
				GoTo IL_608
				IL_5EE:
				num2 = 62
				crossTableBuilder.Filter = Me.o0_0O_O0.O_O0..DataTable.LoadFilter
				IL_608:
				num2 = 63
				If Operators.CompareString(Me.o_0Oo.O00OOoO.().Text.Trim(), "", True) <= 0 Then
					GoTo IL_68D
				End If
				IL_629:
				num2 = 64
				If Operators.CompareString(crossTableBuilder.Filter, "", True) <= 0 Then
					GoTo IL_673
				End If
				IL_641:
				num2 = 65
				crossTableBuilder.Filter = crossTableBuilder.Filter + " And (" + Me.o_0Oo.O00OOoO.().Text.Trim() + ")"
				GoTo IL_68D
				IL_673:
				num2 = 67
				crossTableBuilder.Filter = Me.o_0Oo.O00OOoO.().Text.Trim()
				IL_68D:
				num2 = 68
				crossTableBuilder.Subtotal = Me.OO0OO0O0.o0_.().Checked
				IL_6A2:
				num2 = 69
				crossTableBuilder.ExtendFilter = Me.o_0Oo.O00OOoO.().Text.Trim()
				IL_6BC:
				num2 = 70
				result = crossTableBuilder
				IL_6C2:
				GoTo IL_830
				IL_6C7:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_7F1:
				GoTo IL_825
				IL_7F3:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_803:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7F3
			End Try
			IL_825:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_830:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600326A RID: 12906 RVA: 0x0014890C File Offset: 0x00146B0C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim crossTableBuilder As CrossTableBuilder = Me.oOo__.oO0.()
			If crossTableBuilder IsNot Nothing AndAlso crossTableBuilder.HGroups.Count > 0 AndAlso crossTableBuilder.VGroups.Count > 0 AndAlso crossTableBuilder.Totals.Count > 0 Then
				crossTableBuilder.Build()
				crossTableBuilder.FromServer = Me.oo.o0_0o.().Checked
				Me.o0_0O_O0.O_O0..O_0._O_0OO000O. = crossTableBuilder
				If OO_00oOO.Tables.get_Contains(crossTableBuilder.TableName) Then
					OO_00oOO.MainTable = OO_00oOO.Tables(crossTableBuilder.TableName)
				End If
				MyBase.DialogResult = DialogResult.OK
				Me.o0_0O_O0.O_O0..NeedSaveSetting = True
				Me.o0_0O_O0.O_O0..oo0OO0Ooo._.(True)
			End If
		End Sub

		' Token: 0x0600326B RID: 12907 RVA: 0x001489C0 File Offset: 0x00146BC0
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

		' Token: 0x0600326C RID: 12908 RVA: 0x00148A2C File Offset: 0x00146C2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row > c1FlexGrid.Rows.Fixed Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row - 1)
				End If
			End If
		End Sub

		' Token: 0x0600326D RID: 12909 RVA: 0x00148A84 File Offset: 0x00146C84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2 Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row + 1)
				End If
			End If
		End Sub

		' Token: 0x0600326E RID: 12910 RVA: 0x00148ADD File Offset: 0x00146CDD
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			If Operators.CompareString(Me.oo0OOO.Oo__00.().Text, "", True) > 0 AndAlso Not o_O_o_oOoo__.O_o_._o0.(Me.oo0OOO.Oo__00.().Text) Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x0600326F RID: 12911 RVA: 0x00148B14 File Offset: 0x00146D14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim crossTableBuilder As CrossTableBuilder = Me.oOo__.oO0.()
			If crossTableBuilder IsNot Nothing AndAlso crossTableBuilder.HGroups.Count > 0 AndAlso crossTableBuilder.VGroups.Count > 0 AndAlso crossTableBuilder.Totals.Count > 0 Then
				Dim a_ As CrossTableProperty = New CrossTableProperty(crossTableBuilder)
				New O\u3002_\u3002\u3000\u3002(Me.o0_0O_O0.O_O0., o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False), 2).ShowDialog()
			End If
		End Sub

		' Token: 0x06003270 RID: 12912 RVA: 0x00148B78 File Offset: 0x00146D78
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3000\u3000\u3002\u3002\u3002\u3002o(Me.o0_0O_O0.O_O0., 2).ShowDialog()
		End Sub

		' Token: 0x06003271 RID: 12913 RVA: 0x00148B8C File Offset: 0x00146D8C
		Public Sub New(A_0 As Boolean)
			Me.New(A_0, OO_00oOO.CurrentTable)
		End Sub

		' Token: 0x06003272 RID: 12914 RVA: 0x00148B9C File Offset: 0x00146D9C
		Public Sub New(A_0 As Boolean, A_1 As Table)
			AddHandler MyBase.Activated, AddressOf Me.O_oo.0OO.
			AddHandler MyBase.Load, AddressOf Me.OoOoo.Oooo00.
			AddHandler MyBase.FormClosed, AddressOf Me.OoOoo.Oooo00.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_3C:
				Dim num As Integer = 1
				Me.o_0Oo.O00OOoO.()
				IL_44:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_5B:
				num = 3
				Dim array As C1FlexGrid() = New C1FlexGrid() { Me.oOo_ooo_0O._o.(), Me.oO._0O.(), Me.o_0Oo.O00OOoO.() }
				IL_7F:
				num = 4
				For Each c1FlexGrid As C1FlexGrid In array
					IL_90:
					num = 5
					c1FlexGrid.Styles.SelectedColumnHeader.Clear()
					IL_A3:
					num = 6
					c1FlexGrid.Styles.Alternate.Clear()
					IL_B6:
					num = 7
					c1FlexGrid.Styles.Focus.Clear()
					IL_C9:
					num = 8
					c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
					IL_E8:
					num = 9
					c1FlexGrid.FocusRect = 3
					IL_F3:
					num = 10
					c1FlexGrid.AllowSorting = 0
					IL_FE:
					num = 11
				Next
				IL_112:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_119:
				num = 13
				Me.o0_0O_O0.O_O0. = A_1
				IL_123:
				num = 14
				Dim listDictionary As ListDictionary = New ListDictionary()
				IL_12D:
				num = 15
				Dim listDictionary2 As ListDictionary = New ListDictionary()
				IL_137:
				num = 16
				Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_141:
				num = 17
				Dim enumerator As IEnumerator(Of Col) = A_1.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_15C:
					num = 18
					dictionary.Add(col.Name, col.Caption)
					IL_174:
					num = 19
				End While
				IL_180:
				num = 20
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_18E:
				num = 21
				Me.oO._0O.().Cols("Name").DataMap = dictionary
				IL_1AD:
				num = 22
				Me.o_0Oo.O00OOoO.().Cols("Name").DataMap = dictionary
				IL_1CC:
				num = 23
				Me.oOo_ooo_0O._o.().Cols("Name").DataMap = dictionary
				IL_1EB:
				num = 24
				listDictionary.Add(2, "累计值")
				IL_200:
				num = 25
				listDictionary.Add(6, "平均值")
				IL_215:
				num = 26
				listDictionary.Add(4, "记录数")
				IL_22A:
				num = 27
				listDictionary.Add(7, "最大值")
				IL_23F:
				num = 28
				listDictionary.Add(8, "最小值")
				IL_254:
				num = 29
				Me.oOo_ooo_0O._o.().Cols("Aggregate").DataMap = listDictionary
				IL_273:
				num = 30
				listDictionary2.Add(3, "月")
				IL_288:
				num = 31
				listDictionary2.Add(2, "季")
				IL_29D:
				num = 32
				listDictionary2.Add(1, "年")
				IL_2B2:
				num = 33
				listDictionary2.Add(4, "周")
				IL_2C7:
				num = 34
				listDictionary2.Add(5, "日")
				IL_2DC:
				num = 35
				listDictionary2.Add(6, "时")
				IL_2F1:
				num = 36
				listDictionary2.Add(7, "分")
				IL_306:
				num = 37
				listDictionary2.Add(8, "秒")
				IL_31B:
				num = 38
				listDictionary2.Add(10, "周日")
				IL_331:
				num = 39
				listDictionary2.Add(9, "年日")
				IL_347:
				num = 40
				listDictionary2.Add(0, "无")
				IL_35C:
				num = 41
				Me.oO._0O.().Cols("DateGroup").DataMap = listDictionary2
				IL_37B:
				num = 42
				Me.o_0Oo.O00OOoO.().Cols("DateGroup").DataMap = listDictionary2
				Dim flag As Boolean
				Dim num3 As Integer
				Do
					IL_39A:
					num = 44
					flag = False
					IL_3A0:
					num = 45
					num3 += 1
					IL_3A9:
					num = 46
					Dim right As String = "统计表" + Conversions.ToString(num3)
					IL_3BF:
					num = 47
					Dim enumerator2 As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
					While enumerator2.MoveNext()
						Dim dataTable As DataTable = enumerator2.Current
						IL_3D9:
						num = 48
						If Operators.CompareString(dataTable.Name, right, True) = 0 Then
							IL_3ED:
							num = 49
							flag = True
							Exit While
						End If
						IL_3F5:
						num = 51
					End While
					IL_401:
					num = 52
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
					IL_40F:
					num = 53
				Loop While flag
				IL_416:
				num = 54
				Me.oo0OOO.Oo__00.().Value = "统计表" + Conversions.ToString(num3)
				IL_435:
				num = 55
				If A_0 OrElse A_1.O_0._O_0OO000O. Is Nothing Then
					GoTo IL_9F7
				End If
				IL_449:
				num = 56
				Dim crossTableBuilder As CrossTableBuilder = A_1.O_0._O_0OO000O.
				IL_454:
				num = 57
				Me.oo0OOO.Oo__00.().Value = crossTableBuilder.TableName
				IL_469:
				num = 58
				Me.OO00.OO_0o_0o.().Value = crossTableBuilder.Caption
				IL_47E:
				num = 59
				Me.o_0Oo.O00OOoO.().Value = crossTableBuilder.ExtendFilter
				IL_493:
				num = 60
				Me.O.0O_Oo.().Checked = A_1.O_0._O_0OO000O..OrderByTotal
				IL_4AC:
				num = 61
				Me.o.oO_.().Checked = A_1.O_0._O_0OO000O..HorizontalTotal
				IL_4C5:
				num = 62
				Me.o.00o0oO_oo_.().Checked = A_1.O_0._O_0OO000O..VerticalTotal
				IL_4DE:
				num = 63
				Me.o_0o00_.o0O_o.().Checked = A_1.O_0._O_0OO000O..HorizontalProportion
				IL_4F7:
				num = 64
				Me.oO.00OOOO__o0.().Checked = A_1.O_0._O_0OO000O..VerticalProportion
				IL_510:
				num = 65
				Me.o.__oOoo0O.().Value = A_1.O_0._O_0OO000O..HorizontalProportionCaption
				IL_529:
				num = 66
				Me.o00_.O0.().Value = A_1.O_0._O_0OO000O..VerticalProportionCaption
				IL_542:
				num = 67
				Me.oo.o0_0o.().Checked = A_1.O_0._O_0OO000O..FromServer
				IL_55B:
				num = 68
				Me.OO0OO0O0.o0_.().Checked = A_1.O_0._O_0OO000O..Subtotal
				IL_574:
				num = 69
				Me.ooo0._0o00oO_.().Checked = A_1.O_0._O_0OO000O..SamePeriodGrowth
				IL_58D:
				num = 70
				Me.O0_00.oo0.().Checked = A_1.O_0._O_0OO000O..CircleGrowth
				IL_5A6:
				num = 71
				Me.O0_.o0oo0_0_O0.().Value = A_1.O_0._O_0OO000O..Decimals
				IL_5C4:
				num = 72
				Dim enumerator3 As IEnumerator(Of GroupOn) = crossTableBuilder.HGroups.GetEnumerator()
				While enumerator3.MoveNext()
					Dim groupOn As GroupOn = enumerator3.Current
					IL_5E3:
					num = 73
					If A_1.DataTable.DataCols.Contains(groupOn.Name) Then
						IL_602:
						num = 75
						Me.oO._0O.().AddItem(String.Concat(New String() { groupOn.Name + vbTab, vbTab, groupOn.NewName, vbTab, groupOn.NewCaption }))
						IL_654:
						num = 76
						If A_1.DataTable.DataCols(groupOn.Name).IsDate Then
							IL_675:
							num = 77
							Me.oO._0O.()(Me.oO._0O.().Rows.Count - 1, "DateGroup") = groupOn.DateGroup
						Else
							IL_6A8:
							num = 79
							Me.oO._0O.()(Me.oO._0O.().Rows.Count - 1, "DateGroup") = Nothing
						End If
						IL_6CE:
						num = 80
						If Operators.CompareString(groupOn.Name, groupOn.NewName, True) <> 0 Then
							IL_6E7:
							num = 81
							Me.oO._0O.()(Me.oO._0O.().Rows.Count - 1, "NewName") = groupOn.NewName
						Else
							IL_715:
							num = 83
							Me.oO._0O.()(Me.oO._0O.().Rows.Count - 1, "NewName") = Nothing
						End If
					End If
					IL_73B:
					num = 84
				End While
				IL_74A:
				num = 85
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_758:
				num = 86
				Dim enumerator4 As IEnumerator(Of CrossGroupOn) = crossTableBuilder.VGroups.GetEnumerator()
				While enumerator4.MoveNext()
					Dim crossGroupOn As CrossGroupOn = enumerator4.Current
					IL_777:
					num = 87
					If A_1.DataTable.DataCols.Contains(crossGroupOn.Name) Then
						IL_796:
						num = 89
						Me.o_0Oo.O00OOoO.().AddItem(crossGroupOn.Name + vbTab + vbTab + crossGroupOn.Pattern)
						IL_7C7:
						num = 90
						If A_1.DataTable.DataCols(crossGroupOn.Name).IsDate Then
							IL_7E8:
							num = 91
							Me.o_0Oo.O00OOoO.()(Me.o_0Oo.O00OOoO.().Rows.Count - 1, "DateGroup") = crossGroupOn.DateGroup
						Else
							IL_81B:
							num = 93
							Me.o_0Oo.O00OOoO.()(Me.o_0Oo.O00OOoO.().Rows.Count - 1, "DateGroup") = Nothing
						End If
					End If
					IL_841:
					num = 94
				End While
				IL_850:
				num = 95
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_85E:
				num = 96
				Dim enumerator5 As IEnumerator(Of CrossTotalOn) = crossTableBuilder.Totals.GetEnumerator()
				While enumerator5.MoveNext()
					Dim crossTotalOn As CrossTotalOn = enumerator5.Current
					IL_87D:
					num = 97
					If A_1.DataTable.DataCols.Contains(crossTotalOn.Name) Then
						IL_89C:
						num = 98
						Dim expression As Boolean = False
						IL_8A2:
						num = 99
						If Operators.CompareString(crossTotalOn.Caption, Oo00.OoO_.__o.(crossTotalOn.Aggregate), True) = 0 OrElse Operators.CompareString(crossTotalOn.Caption, crossTotalOn.Name, True) = 0 Then
							IL_8D6:
							num = 100
							expression = True
						Else
							IL_8DE:
							num = 102
							If Operators.CompareString(crossTotalOn.Caption, crossTotalOn.Name + "_" + Oo00.OoO_.__o.(crossTotalOn.Aggregate), True) = 0 Then
								IL_90D:
								num = 103
								expression = True
							End If
						End If
						IL_913:
						num = 104
						Me.oOo_ooo_0O._o.().AddItem(crossTotalOn.Name + vbTab + vbTab + vbTab + Interaction.IIf(expression, "", crossTotalOn.Caption).ToString())
						IL_95F:
						num = 105
						Me.oOo_ooo_0O._o.()(Me.oOo_ooo_0O._o.().Rows.Count - 1, "Aggregate") = crossTotalOn.Aggregate
						IL_990:
						num = 106
						If crossTotalOn.upto Then
							IL_99C:
							num = 107
							Me.oOo_ooo_0O._o.().SetCellCheck(Me.oOo_ooo_0O._o.().Rows.Count - 1, Me.oOo_ooo_0O._o.().Cols("upto").Index, 1)
						End If
					End If
					IL_9D7:
					num = 108
				End While
				IL_9E6:
				num = 109
				If enumerator5 IsNot Nothing Then
					enumerator5.Dispose()
				End If
				IL_9F4:
				crossTableBuilder = Nothing
				IL_9F7:
				num = 111
				Me.oO._0O.().AllowAddNew = True
				IL_A06:
				num = 112
				Me.o_0Oo.O00OOoO.().AllowAddNew = True
				IL_A15:
				num = 113
				Me.oOo_ooo_0O._o.().AllowAddNew = True
				IL_A24:
				num = 114
				Me.oo.o0_0o.().Enabled = A_1.AllowBackgroundStatistics
				IL_A38:
				num = 115
				Me.O.0O_Oo.().Visible = (OO_00oOO.User.Type = 0)
				IL_A53:
				num = 116
				Me.O.0O_Oo.().Visible = False
				IL_A62:
				GoTo IL_C88
				IL_A67:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_C49:
				GoTo IL_C7D
				IL_C4B:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_C5B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_C4B
			End Try
			IL_C7D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C88:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003273 RID: 12915 RVA: 0x00149858 File Offset: 0x00147A58
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0Oo.O00OOoO.().Value = Me.o0_0O_O0.O_O0..DataTable.OOoo__00O_.o_O.(Me.o_0Oo.O00OOoO.().Text, True)
		End Sub

		' Token: 0x06003274 RID: 12916 RVA: 0x00149884 File Offset: 0x00147A84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim crossTableBuilder As CrossTableBuilder = Me.oOo__.oO0.()
				IL_10:
				num2 = 3
				If crossTableBuilder Is Nothing Then
					GoTo IL_B33
				End If
				IL_18:
				num2 = 5
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_21:
				num2 = 6
				If Operators.CompareString(Me.o_0Oo.O00OOoO.().Text, "", True) <> 0 Then
					GoTo IL_81
				End If
				IL_3B:
				num2 = 7
				stringBuilder.Append(String.Concat(New String() { "Dim g As New CrossTableBuilder(""", crossTableBuilder.TableName, """, DataTables(""", crossTableBuilder.SourceDataTable.Name, """))" }))
				GoTo IL_DC
				IL_81:
				num2 = 9
				stringBuilder.Append(String.Concat(New String() { "Dim g As New CrossTableBuilder(""", crossTableBuilder.TableName, """, DataTables(""", crossTableBuilder.SourceDataTable.Name, """), """, Me.o_0Oo.O00OOoO.().Text, """)" }))
				IL_DC:
				num2 = 10
				stringBuilder.Append(vbCrLf)
				IL_EC:
				num2 = 11
				If Operators.CompareString(crossTableBuilder.Caption, "", True) <= 0 Then
					GoTo IL_133
				End If
				IL_103:
				num2 = 12
				stringBuilder.Append("g.Caption = """ + crossTableBuilder.Caption + """")
				IL_123:
				num2 = 13
				stringBuilder.Append(vbCrLf)
				IL_133:
				num2 = 14
				Dim enumerator As IEnumerator(Of GroupOn) = crossTableBuilder.HGroups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_151:
					num2 = 15
					Dim text As String = ""
					IL_15B:
					num2 = 16
					If Operators.CompareString(groupOn.NewName, groupOn.Name, True) <> 0 Then
						IL_174:
						num2 = 17
						text = groupOn.NewName
					End If
					IL_180:
					num2 = 18
					If Me.o0_0O_O0.O_O0..DataTable.DataCols(groupOn.Name).IsDate AndAlso groupOn.DateGroup <> 3 Then
						IL_1B6:
						num2 = 19
						Dim text2 As String = "DateGroupEnum." + [Enum].GetName(GetType(DateGroupEnum), groupOn.DateGroup)
						IL_1E0:
						num2 = 20
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_1F8:
							num2 = 21
							stringBuilder.Append(String.Concat(New String() { "g.HGroups.AddDef(""", groupOn.Name, """, ", text2, ", """, text, """, """, groupOn.NewCaption, """)" }))
						Else
							IL_25A:
							num2 = 23
							If Operators.CompareString(text, "", True) > 0 Then
								IL_26D:
								num2 = 24
								stringBuilder.Append(String.Concat(New String() { "g.HGroups.AddDef(""", groupOn.Name, """, ", text2, ", """, text, """)" }))
							Else
								IL_2BC:
								num2 = 26
								stringBuilder.Append(String.Concat(New String() { "g.HGroups.AddDef(""", groupOn.Name, """, ", text2, ")" }))
							End If
						End If
					Else
						IL_2FE:
						num2 = 28
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_316:
							num2 = 29
							stringBuilder.Append(String.Concat(New String() { "g.HGroups.AddDef(""", groupOn.Name, """, """, text, """, """, groupOn.NewCaption, """)" }))
						Else
							IL_367:
							num2 = 31
							If Operators.CompareString(text, "", True) > 0 Then
								IL_37A:
								num2 = 32
								stringBuilder.Append(String.Concat(New String() { "g.HGroups.AddDef(""", groupOn.Name, """, """, text, """)" }))
							Else
								IL_3B9:
								num2 = 34
								stringBuilder.Append("g.HGroups.AddDef(""" + groupOn.Name + """)")
							End If
						End If
					End If
					IL_3DA:
					num2 = 35
					stringBuilder.Append(vbCrLf)
					IL_3EA:
					num2 = 36
				End While
				IL_3F9:
				num2 = 37
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_407:
				num2 = 38
				Dim enumerator2 As IEnumerator(Of CrossGroupOn) = crossTableBuilder.VGroups.GetEnumerator()
				While enumerator2.MoveNext()
					Dim crossGroupOn As CrossGroupOn = enumerator2.Current
					IL_425:
					num2 = 39
					If Me.o0_0O_O0.O_O0..DataTable.DataCols(crossGroupOn.Name).IsDate AndAlso crossGroupOn.DateGroup <> 3 Then
						IL_45B:
						num2 = 40
						Dim text3 As String = "DateGroupEnum." + [Enum].GetName(GetType(DateGroupEnum), crossGroupOn.DateGroup)
						IL_485:
						num2 = 41
						If Operators.CompareString(crossGroupOn.Pattern, "", True) > 0 Then
							IL_49D:
							num2 = 42
							stringBuilder.Append(String.Concat(New String() { "g.VGroups.AddDef(""", crossGroupOn.Name, """, ", text3, ", """, crossGroupOn.Pattern, """)" }))
						Else
							IL_4F1:
							num2 = 44
							stringBuilder.Append(String.Concat(New String() { "g.VGroups.AddDef(""", crossGroupOn.Name, """, ", text3, ")" }))
						End If
					Else
						IL_530:
						num2 = 46
						If Operators.CompareString(crossGroupOn.Pattern, "", True) > 0 Then
							IL_548:
							num2 = 47
							stringBuilder.Append(String.Concat(New String() { "g.VGroups.AddDef(""", crossGroupOn.Name, """, """, crossGroupOn.Pattern, """)" }))
						Else
							IL_58C:
							num2 = 49
							stringBuilder.Append("g.VGroups.AddDef(""" + crossGroupOn.Name + """)")
						End If
					End If
					IL_5AD:
					num2 = 50
					stringBuilder.Append(vbCrLf)
					IL_5BD:
					num2 = 51
				End While
				IL_5CC:
				num2 = 52
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_5DA:
				num2 = 53
				Dim enumerator3 As IEnumerator(Of CrossTotalOn) = crossTableBuilder.Totals.GetEnumerator()
				While enumerator3.MoveNext()
					Dim crossTotalOn As CrossTotalOn = enumerator3.Current
					IL_5F8:
					num2 = 54
					If crossTotalOn.Aggregate = 2 Then
						IL_608:
						num2 = 55
						If Operators.CompareString(crossTotalOn.Caption, "", True) > 0 Then
							IL_620:
							num2 = 56
							stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", crossTotalOn.Name, """, """, crossTotalOn.Caption, """" }))
						Else
							IL_667:
							num2 = 58
							stringBuilder.Append("g.Totals.AddDef(""" + crossTotalOn.Name + """")
						End If
					Else
						IL_68D:
						num2 = 60
						Dim text4 As String = "AggregateEnum." + [Enum].GetName(GetType(AggregateEnum), crossTotalOn.Aggregate)
						IL_6B7:
						num2 = 61
						If Operators.CompareString(crossTotalOn.Caption, "", True) > 0 Then
							IL_6CF:
							num2 = 62
							stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", crossTotalOn.Name, """, ", text4, ", """, crossTotalOn.Caption, """" }))
						Else
							IL_720:
							num2 = 64
							stringBuilder.Append(If(("g.Totals.AddDef(""" + crossTotalOn.Name + """, " + text4), ""))
						End If
					End If
					IL_74C:
					num2 = 65
					If crossTotalOn.upto Then
						IL_758:
						num2 = 66
						stringBuilder.Append(", True")
					End If
					IL_768:
					num2 = 67
					stringBuilder.Append(")" & vbCrLf)
					IL_778:
					num2 = 68
				End While
				IL_787:
				num2 = 69
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_795:
				num2 = 70
				If Not Me.O.0O_Oo.().Checked Then
					GoTo IL_7C5
				End If
				IL_7A5:
				num2 = 71
				stringBuilder.Append("g.OrderByTotal = True")
				IL_7B5:
				num2 = 72
				stringBuilder.Append(vbCrLf)
				IL_7C5:
				num2 = 73
				If Not Me.o.oO_.().Checked Then
					GoTo IL_7F5
				End If
				IL_7D5:
				num2 = 74
				stringBuilder.Append("g.HorizontalTotal = True")
				IL_7E5:
				num2 = 75
				stringBuilder.Append(vbCrLf)
				IL_7F5:
				num2 = 76
				If Not Me.o.00o0oO_oo_.().Checked Then
					GoTo IL_825
				End If
				IL_805:
				num2 = 77
				stringBuilder.Append("g.VerticalTotal = True")
				IL_815:
				num2 = 78
				stringBuilder.Append(vbCrLf)
				IL_825:
				num2 = 79
				If Not Me.o_0o00_.o0O_o.().Checked Then
					GoTo IL_855
				End If
				IL_835:
				num2 = 80
				stringBuilder.Append("g.HorizontalProportion = True")
				IL_845:
				num2 = 81
				stringBuilder.Append(vbCrLf)
				IL_855:
				num2 = 82
				If Not Me.oO.00OOOO__o0.().Checked Then
					GoTo IL_885
				End If
				IL_865:
				num2 = 83
				stringBuilder.Append("g.VerticalProportion = True")
				IL_875:
				num2 = 84
				stringBuilder.Append(vbCrLf)
				IL_885:
				num2 = 85
				If Not Me.ooo0._0o00oO_.().Checked Then
					GoTo IL_8B5
				End If
				IL_895:
				num2 = 86
				stringBuilder.Append("g.SamePeriodGrowth = True")
				IL_8A5:
				num2 = 87
				stringBuilder.Append(vbCrLf)
				IL_8B5:
				num2 = 88
				If Not Me.O0_00.oo0.().Checked Then
					GoTo IL_8E5
				End If
				IL_8C5:
				num2 = 89
				stringBuilder.Append("g.CircleGrowth = True")
				IL_8D5:
				num2 = 90
				stringBuilder.Append(vbCrLf)
				IL_8E5:
				num2 = 91
				If Operators.CompareString(Me.o.__oOoo0O.().Text, "", True) <= 0 OrElse Operators.CompareString(Me.o.__oOoo0O.().Text, "份额", True) = 0 Then
					GoTo IL_94E
				End If
				IL_919:
				num2 = 92
				stringBuilder.Append("g.HorizontalProportionCaption = """ + Me.o.__oOoo0O.().Text + """")
				IL_93E:
				num2 = 93
				stringBuilder.Append(vbCrLf)
				IL_94E:
				num2 = 94
				If Operators.CompareString(Me.o00_.O0.().Text, "", True) <= 0 OrElse Operators.CompareString(Me.o00_.O0.().Text, "占比", True) = 0 Then
					GoTo IL_9B7
				End If
				IL_982:
				num2 = 95
				stringBuilder.Append("g.VerticalProportionCaption = """ + Me.o00_.O0.().Text + """")
				IL_9A7:
				num2 = 96
				stringBuilder.Append(vbCrLf)
				IL_9B7:
				num2 = 97
				If Conversions.ToInteger(Me.O0_.o0oo0_0_O0.().Value) = 4 Then
					GoTo IL_A07
				End If
				IL_9CD:
				num2 = 98
				stringBuilder.Append("g.Decimals = " + Conversions.ToString(Conversions.ToInteger(Me.O0_.o0oo0_0_O0.().Value)))
				IL_9F7:
				num2 = 99
				stringBuilder.Append(vbCrLf)
				IL_A07:
				num2 = 100
				If Operators.CompareString(Me.o_0Oo.O00OOoO.().Text, "", True) <= 0 Then
					GoTo IL_A58
				End If
				IL_A23:
				num2 = 101
				stringBuilder.Append("g.Filter = """ + Me.o_0Oo.O00OOoO.().Text + """")
				IL_A48:
				num2 = 102
				stringBuilder.Append(vbCrLf)
				IL_A58:
				num2 = 103
				If Not Me.OO0OO0O0.o0_.().Checked Then
					GoTo IL_A88
				End If
				IL_A68:
				num2 = 104
				stringBuilder.Append("g.Subtotal = True")
				IL_A78:
				num2 = 105
				stringBuilder.Append(vbCrLf)
				IL_A88:
				num2 = 106
				If Not Me.oo.o0_0o.().Checked Then
					GoTo IL_AB8
				End If
				IL_A98:
				num2 = 107
				stringBuilder.Append("g.FromServer = True")
				IL_AA8:
				num2 = 108
				stringBuilder.Append(vbCrLf)
				IL_AB8:
				num2 = 109
				stringBuilder.Append("g.Build()")
				IL_AC8:
				num2 = 110
				stringBuilder.Append(vbCrLf)
				IL_AD8:
				num2 = 111
				stringBuilder.Append("MainTable = Tables(""" + crossTableBuilder.TableName + """)")
				IL_AF8:
				num2 = 112
				Dim o_u3000_u3000_u3002_u3002O As o\u3000\u3000\u3002\u3002O = New o\u3000\u3000\u3002\u3002O()
				IL_B02:
				num2 = 113
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString()
				IL_B18:
				num2 = 114
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0
				IL_B28:
				num2 = 115
				o_u3000_u3000_u3002_u3002O.ShowDialog()
				IL_B33:
				GoTo IL_D55
				IL_B38:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_D16:
				GoTo IL_D4A
				IL_D18:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_D28:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_D18
			End Try
			IL_D4A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_D55:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003275 RID: 12917 RVA: 0x0014A60C File Offset: 0x0014880C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim num As Integer = Math.Max(c1FlexGrid.Row, c1FlexGrid.Rows.Fixed)
				c1FlexGrid.Rows.Insert(num)
				c1FlexGrid.Row = num
			End If
		End Sub

		' Token: 0x06003276 RID: 12918 RVA: 0x0014A660 File Offset: 0x00148860
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oo.o0_0o.().Checked Then
				Me.O_.O0oOOo.().Enabled = False
				If Not Me.o0_0O_O0.O_O0..DataTable.frd_IsInnerTable AndAlso Not Me.o0_0O_O0.O_O0..DataTable.frd_IsOuterTable AndAlso Operators.CompareString(Me.o0_0O_O0.O_O0..DataTable.DataServer, "", True) <= 0 Then
					Me.oo.o0_0o.().Checked = False
					Return
				End If
			Else
				If Me.o0_0O_O0.O_O0..O.OoOo_. IsNot Nothing AndAlso Me.o0_0O_O0.O_O0..O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(Me.o0_0O_O0.O_O0..DataTable.LoadTop, "", True) > 0 AndAlso Me.o0_0O_O0.O_O0..AllowBackEndFilter Then
					Me.O_.O0oOOo.().Enabled = False
					Return
				End If
				Me.O_.O0oOOo.().Enabled = True
			End If
		End Sub

		' Token: 0x06003277 RID: 12919 RVA: 0x0014A743 File Offset: 0x00148943
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Me.o0_0O_O0.O_O0..Oo0Oo___.o0o.()
			End If
		End Sub

		' Token: 0x06003278 RID: 12920 RVA: 0x0014A760 File Offset: 0x00148960
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0_0O_O0.O_O0..Rows.Count < 2 Then
				Me.oo.o0_0o.().Checked = True
			End If
			If Me.o0_0O_O0.O_O0..O.OoOo_. IsNot Nothing AndAlso Me.o0_0O_O0.O_O0..O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(Me.o0_0O_O0.O_O0..DataTable.LoadTop, "", True) > 0 AndAlso Me.o0_0O_O0.O_O0..AllowBackEndFilter Then
				Me.O_.O0oOOo.().Enabled = False
			End If
		End Sub

		' Token: 0x06003279 RID: 12921 RVA: 0x0014A7E7 File Offset: 0x001489E7
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001424 RID: 5156
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001425 RID: 5157
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001426 RID: 5158
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001427 RID: 5159
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001428 RID: 5160
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001429 RID: 5161
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400142A RID: 5162
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400142B RID: 5163
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400142C RID: 5164
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400142D RID: 5165
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400142E RID: 5166
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400142F RID: 5167
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001430 RID: 5168
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001431 RID: 5169
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001432 RID: 5170
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001433 RID: 5171
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001434 RID: 5172
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001435 RID: 5173
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001436 RID: 5174
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001437 RID: 5175
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04001438 RID: 5176
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04001439 RID: 5177
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400143A RID: 5178
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400143B RID: 5179
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400143C RID: 5180
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400143D RID: 5181
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400143E RID: 5182
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400143F RID: 5183
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001440 RID: 5184
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001441 RID: 5185
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001442 RID: 5186
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001443 RID: 5187
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001444 RID: 5188
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001445 RID: 5189
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001446 RID: 5190
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001447 RID: 5191
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04001448 RID: 5192
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001449 RID: 5193
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400144A RID: 5194
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400144B RID: 5195
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400144C RID: 5196
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400144D RID: 5197
		Private a As Integer
	End Class
End Namespace
