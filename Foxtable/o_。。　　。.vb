Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B6 RID: 1206
	<DesignerGenerated()>
	Friend Partial Class o_\u3002\u3002\u3000\u3000\u3002
		Inherits Form

		' Token: 0x06004E01 RID: 19969 RVA: 0x00203B5C File Offset: 0x00201D5C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOoo_0O.oo00oO. IsNot Nothing Then
					Me.oOoo_0O.oo00oO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004E02 RID: 19970 RVA: 0x00203B9C File Offset: 0x00201D9C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oOoo_0O.oo00oO. = New Container()
			Dim treeNode As TreeNode = New TreeNode("功能区")
			Dim treeNode2 As TreeNode = New TreeNode("程序菜单")
			Dim treeNode3 As TreeNode = New TreeNode("快速访问栏")
			Dim treeNode4 As TreeNode = New TreeNode("配置栏")
			Dim treeNode5 As TreeNode = New TreeNode("上工具栏")
			Dim treeNode6 As TreeNode = New TreeNode("下工具栏")
			Dim treeNode7 As TreeNode = New TreeNode("功能区组")
			Dim treeNode8 As TreeNode = New TreeNode("主菜单", New TreeNode() { treeNode, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 })
			Dim treeNode9 As TreeNode = New TreeNode("快捷菜单")
			Me.OoOoo__0.o.(New C1Button())
			Me.o_0o0.oOo0.(New C1Button())
			Me.O0_OO_00O_o.O0.(New SplitContainer())
			Me.O_0OO00.Oo00.(New TreeView())
			Me.O___.0_.(New C1DockingTab())
			Me.o_0o0.oOo0.(New C1DockingTabPage())
			Me.O_0OO00.Oo00.(New PropertyGrid())
			Me.O___.0_.(New C1DockingTabPage())
			Me.O_0OO00.Oo00.(New SplitContainer())
			Me.O0_OO_00O_o.O0.(New PropertyGrid())
			Me.O_0OO00.Oo00.(New RichTextBox())
			Me.O___.0_.(New C1Button())
			Me.O__.oOo.(New C1Button())
			Me.O_0OO00.Oo00.(New ContextMenuStrip(Me.oOoo_0O.oo00oO.))
			Me.O0_OO_00O_o.O0.(New ToolStripMenuItem())
			Me.O_0OO00.Oo00.(New ToolStripMenuItem())
			Me.oO0o0o0._o.(New C1Button())
			Me.Ooo_o._.(New C1Button())
			Me.O_o0._00oOO.().Panel1.SuspendLayout()
			Me.O_o0._00oOO.().Panel2.SuspendLayout()
			Me.O_o0._00oOO.().SuspendLayout()
			Me.O_o0._00oOO.().BeginInit()
			Me.O_o0._00oOO.().SuspendLayout()
			Me.OO_.00oOO.().SuspendLayout()
			Me.O_o0._00oOO.().SuspendLayout()
			Me.OO_.00oOO.().Panel1.SuspendLayout()
			Me.OO_.00oOO.().Panel2.SuspendLayout()
			Me.OO_.00oOO.().SuspendLayout()
			Me.O_o0._00oOO.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.OO0OO0O.0O0_oO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO0OO0O.0O0_oO.().Location = New Point(616, 359)
			Me.OO0OO0O.0O0_oO.().Name = "cmdCancel"
			Me.OO0OO0O.0O0_oO.().Size = New Size(75, 23)
			Me.OO0OO0O.0O0_oO.().TabIndex = 7
			Me.OO0OO0O.0O0_oO.().Text = "关闭"
			Me.OO0OO0O.0O0_oO.().UseVisualStyleBackColor = True
			Me.OOOO_Oo._O0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OOOO_Oo._O0_.().Location = New Point(12, 401)
			Me.OOOO_Oo._O0_.().Name = "btnTemplate"
			Me.OOOO_Oo._O0_.().Size = New Size(75, 23)
			Me.OOOO_Oo._O0_.().TabIndex = 10
			Me.OOOO_Oo._O0_.().Text = "模板"
			Me.OOOO_Oo._O0_.().UseVisualStyleBackColor = True
			Me.O_o0._00oOO.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_o0._00oOO.().Location = New Point(12, 12)
			Me.O_o0._00oOO.().Name = "SplitContainer1"
			Me.O_o0._00oOO.().Panel1.Controls.Add(Me.O0.o_0.())
			Me.O_o0._00oOO.().Panel2.Controls.Add(Me.O_o0._00oOO.())
			Me.O_o0._00oOO.().Size = New Size(579, 380)
			Me.O_o0._00oOO.().SplitterDistance = 193
			Me.O_o0._00oOO.().TabIndex = 13
			Me.O0.o_0.().Dock = DockStyle.Fill
			Me.O0.o_0.().HideSelection = False
			Me.O0.o_0.().Location = New Point(0, 0)
			Me.O0.o_0.().Name = "TreeView1"
			treeNode.Name = "节点0"
			treeNode.Tag = "Tab"
			treeNode.Text = "功能区"
			treeNode2.Name = "节点4"
			treeNode2.Tag = "ApplicationMenu"
			treeNode2.Text = "程序菜单"
			treeNode3.Name = "节点2"
			treeNode3.Tag = "QAT"
			treeNode3.Text = "快速访问栏"
			treeNode4.Name = "节点3"
			treeNode4.Tag = "ConfigToolBar"
			treeNode4.Text = "配置栏"
			treeNode5.Name = "TopToolBar"
			treeNode5.Tag = "TopToolBar"
			treeNode5.Text = "上工具栏"
			treeNode6.Name = "BottomToolBar"
			treeNode6.Tag = "BottomToolBar"
			treeNode6.Text = "下工具栏"
			treeNode7.Name = "TabGroups"
			treeNode7.Tag = "TabGroups"
			treeNode7.Text = "功能区组"
			treeNode8.Name = "节点0"
			treeNode8.Tag = "Ribbon"
			treeNode8.Text = "主菜单"
			treeNode9.Name = "节点1"
			treeNode9.Tag = "ContextMenu"
			treeNode9.Text = "快捷菜单"
			Me.O0.o_0.().Nodes.AddRange(New TreeNode() { treeNode8, treeNode9 })
			Me.O0.o_0.().Size = New Size(193, 380)
			Me.O0.o_0.().TabIndex = 0
			Me.O_o0._00oOO.().BorderStyle = BorderStyle.None
			Me.O_o0._00oOO.().Controls.Add(Me.OO_.00oOO.())
			Me.O_o0._00oOO.().Controls.Add(Me.O_o0._00oOO.())
			Me.O_o0._00oOO.().Dock = DockStyle.Fill
			Me.O_o0._00oOO.().Location = New Point(0, 0)
			Me.O_o0._00oOO.().Name = "C1DockingTab1"
			Me.O_o0._00oOO.().Size = New Size(382, 380)
			Me.O_o0._00oOO.().TabIndex = 0
			Me.O_o0._00oOO.().TabsSpacing = 0
			Me.O_o0._00oOO.().TabStyle = 1
			Me.O_o0._00oOO.().VisualStyle = 13
			Me.O_o0._00oOO.().VisualStyleBase = 13
			Me.OO_.00oOO.().Controls.Add(Me.O_o0._00oOO.())
			Me.OO_.00oOO.().Location = New Point(0, 25)
			Me.OO_.00oOO.().Name = "C1DockingTabPage1"
			Me.OO_.00oOO.().Size = New Size(382, 355)
			Me.OO_.00oOO.().TabIndex = 0
			Me.OO_.00oOO.().Text = "属性"
			Me.O_o0._00oOO.().Dock = DockStyle.Fill
			Me.O_o0._00oOO.().Location = New Point(0, 0)
			Me.O_o0._00oOO.().Name = "PropertyGrid1"
			Me.O_o0._00oOO.().Size = New Size(382, 355)
			Me.O_o0._00oOO.().TabIndex = 3
			Me.O_o0._00oOO.().ToolbarVisible = False
			Me.O_o0._00oOO.().Controls.Add(Me.OO_.00oOO.())
			Me.O_o0._00oOO.().Location = New Point(0, 25)
			Me.O_o0._00oOO.().Name = "C1DockingTabPage2"
			Me.O_o0._00oOO.().Size = New Size(382, 355)
			Me.O_o0._00oOO.().TabIndex = 1
			Me.O_o0._00oOO.().Text = "事件"
			Me.OO_.00oOO.().Dock = DockStyle.Fill
			Me.OO_.00oOO.().Location = New Point(0, 0)
			Me.OO_.00oOO.().Name = "SplitContainer2"
			Me.OO_.00oOO.().Orientation = Orientation.Horizontal
			Me.OO_.00oOO.().Panel1.Controls.Add(Me.OO_.00oOO.())
			Me.OO_.00oOO.().Panel1.RightToLeft = RightToLeft.No
			Me.OO_.00oOO.().Panel2.Controls.Add(Me.O0.o_0.())
			Me.OO_.00oOO.().Panel2.RightToLeft = RightToLeft.No
			Me.OO_.00oOO.().Size = New Size(382, 355)
			Me.OO_.00oOO.().SplitterDistance = 227
			Me.OO_.00oOO.().TabIndex = 0
			Me.OO_.00oOO.().Dock = DockStyle.Fill
			Me.OO_.00oOO.().Location = New Point(0, 0)
			Me.OO_.00oOO.().Name = "PropertyGrid2"
			Me.OO_.00oOO.().Size = New Size(382, 227)
			Me.OO_.00oOO.().TabIndex = 1
			Me.OO_.00oOO.().ToolbarVisible = False
			Me.O0.o_0.().BorderStyle = BorderStyle.FixedSingle
			Me.O0.o_0.().Dock = DockStyle.Fill
			Me.O0.o_0.().Location = New Point(0, 0)
			Me.O0.o_0.().Name = "txtCode"
			Me.O0.o_0.().[ReadOnly] = True
			Me.O0.o_0.().Size = New Size(382, 124)
			Me.O0.o_0.().TabIndex = 0
			Me.O0.o_0.().Text = ""
			Me.O0.o_0.().WordWrap = False
			Me.oO.oO0oO__o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oO.oO0oO__o.().Location = New Point(435, 401)
			Me.oO.oO0oO__o.().Name = "btnOK"
			Me.oO.oO0oO__o.().Size = New Size(75, 23)
			Me.oO.oO0oO__o.().TabIndex = 14
			Me.oO.oO0oO__o.().Text = "确定"
			Me.oO.oO0oO__o.().UseVisualStyleBackColor = True
			Me.O0O.O_____O__o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O0O.O_____O__o.().Location = New Point(516, 401)
			Me.O0O.O_____O__o.().Name = "btnClose"
			Me.O0O.O_____O__o.().Size = New Size(75, 23)
			Me.O0O.O_____O__o.().TabIndex = 15
			Me.O0O.O_____O__o.().Text = "取消"
			Me.O0O.O_____O__o.().UseVisualStyleBackColor = True
			Me.O_o0._00oOO.().Items.AddRange(New ToolStripItem() { Me.oO0.00O__.(), Me.O0.o_0.() })
			Me.O_o0._00oOO.().Name = "ContextMenuStrip1"
			Me.O_o0._00oOO.().Size = New Size(146, 48)
			Me.oO0.00O__.().Name = "ToolStripMenuItemSave"
			Me.oO0.00O__.().Size = New Size(145, 22)
			Me.oO0.00O__.().Text = "保存为模板..."
			Me.O0.o_0.().Name = "ToolStripMenuItemOpen"
			Me.O0.o_0.().Size = New Size(145, 22)
			Me.O0.o_0.().Text = "从模板生成..."
			Me.OO0._O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OO0._O.().Location = New Point(94, 401)
			Me.OO0._O.().Name = "Button1"
			Me.OO0._O.().Size = New Size(75, 23)
			Me.OO0._O.().TabIndex = 16
			Me.OO0._O.().Text = "输出代码"
			Me.OO0._O.().UseVisualStyleBackColor = True
			Me.oO0_o.O0oO000.().Location = New Point(176, 401)
			Me.oO0_o.O0oO000.().Name = "btnPreview"
			Me.oO0_o.O0oO000.().Size = New Size(75, 23)
			Me.oO0_o.O0oO000.().TabIndex = 17
			Me.oO0_o.O0oO000.().Text = "预览"
			Me.oO0_o.O0oO000.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(605, 436)
			MyBase.Controls.Add(Me.oO0_o.O0oO000.())
			MyBase.Controls.Add(Me.O_o0._00oOO.())
			MyBase.Controls.Add(Me.O0O.O_____O__o.())
			MyBase.Controls.Add(Me.OO0._O.())
			MyBase.Controls.Add(Me.oO.oO0oO__o.())
			MyBase.Controls.Add(Me.OO0OO0O.0O0_oO.())
			MyBase.Controls.Add(Me.OOOO_Oo._O0_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.0.o..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "RibbonMenu 设计器"
			Me.O_o0._00oOO.().Panel1.ResumeLayout(False)
			Me.O_o0._00oOO.().Panel2.ResumeLayout(False)
			Me.O_o0._00oOO.().ResumeLayout(False)
			Me.O_o0._00oOO.().EndInit()
			Me.O_o0._00oOO.().ResumeLayout(False)
			Me.OO_.00oOO.().ResumeLayout(False)
			Me.O_o0._00oOO.().ResumeLayout(False)
			Me.OO_.00oOO.().Panel1.ResumeLayout(False)
			Me.OO_.00oOO.().Panel2.ResumeLayout(False)
			Me.OO_.00oOO.().ResumeLayout(False)
			Me.O_o0._00oOO.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06004E03 RID: 19971 RVA: 0x00204884 File Offset: 0x00202A84
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E04 RID: 19972 RVA: 0x0020488C File Offset: 0x00202A8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E05 RID: 19973 RVA: 0x00204895 File Offset: 0x00202A95
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.00__0o_.
		End Function

		' Token: 0x06004E06 RID: 19974 RVA: 0x0020489D File Offset: 0x00202A9D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o.00__0o_. = A_0
		End Sub

		' Token: 0x06004E07 RID: 19975 RVA: 0x002048A6 File Offset: 0x00202AA6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E08 RID: 19976 RVA: 0x002048AE File Offset: 0x00202AAE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E09 RID: 19977 RVA: 0x002048B7 File Offset: 0x00202AB7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.oOoo_0O.oo00oO.
		End Function

		' Token: 0x06004E0A RID: 19978 RVA: 0x002048BF File Offset: 0x00202ABF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Me.oOoo_0O.oo00oO. = A_0
		End Sub

		' Token: 0x06004E0B RID: 19979 RVA: 0x002048C8 File Offset: 0x00202AC8
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_00O.0O.
		End Function

		' Token: 0x06004E0C RID: 19980 RVA: 0x002048D0 File Offset: 0x00202AD0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0_00O.0O. = A_0
		End Sub

		' Token: 0x06004E0D RID: 19981 RVA: 0x002048D9 File Offset: 0x00202AD9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO_0_O_O0.0__O.
		End Function

		' Token: 0x06004E0E RID: 19982 RVA: 0x002048E1 File Offset: 0x00202AE1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OO_0_O_O0.0__O. = A_0
		End Sub

		' Token: 0x06004E0F RID: 19983 RVA: 0x002048EA File Offset: 0x00202AEA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O.ooo_O0OOO0Oo.
		End Function

		' Token: 0x06004E10 RID: 19984 RVA: 0x002048F2 File Offset: 0x00202AF2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O.ooo_O0OOO0Oo. = A_0
		End Sub

		' Token: 0x06004E11 RID: 19985 RVA: 0x002048FB File Offset: 0x00202AFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E12 RID: 19986 RVA: 0x00204903 File Offset: 0x00202B03
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E13 RID: 19987 RVA: 0x0020490C File Offset: 0x00202B0C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E14 RID: 19988 RVA: 0x00204914 File Offset: 0x00202B14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E15 RID: 19989 RVA: 0x0020491D File Offset: 0x00202B1D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.OOO0O_.o00.
		End Function

		' Token: 0x06004E16 RID: 19990 RVA: 0x00204925 File Offset: 0x00202B25
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.OOO0O_.o00. = A_0
		End Sub

		' Token: 0x06004E17 RID: 19991 RVA: 0x0020492E File Offset: 0x00202B2E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.OOO0O_.o00.
		End Function

		' Token: 0x06004E18 RID: 19992 RVA: 0x00204936 File Offset: 0x00202B36
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.OOO0O_.o00. = A_0
		End Sub

		' Token: 0x06004E19 RID: 19993 RVA: 0x0020493F File Offset: 0x00202B3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.OOO0O_.o00.
		End Function

		' Token: 0x06004E1A RID: 19994 RVA: 0x00204947 File Offset: 0x00202B47
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.OOO0O_.o00. = A_0
		End Sub

		' Token: 0x06004E1B RID: 19995 RVA: 0x00204950 File Offset: 0x00202B50
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E1C RID: 19996 RVA: 0x00204958 File Offset: 0x00202B58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E1D RID: 19997 RVA: 0x00204964 File Offset: 0x00202B64
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.ooO_00oo._0o_.
		End Function

		' Token: 0x06004E1E RID: 19998 RVA: 0x00204978 File Offset: 0x00202B78
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			Me.ooO_00oo._0o_. = A_0
		End Sub

		' Token: 0x06004E1F RID: 19999 RVA: 0x0020498C File Offset: 0x00202B8C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.OOO0O_.o00.
		End Function

		' Token: 0x06004E20 RID: 20000 RVA: 0x002049A0 File Offset: 0x00202BA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			Me.OOO0O_.o00. = A_0
		End Sub

		' Token: 0x06004E21 RID: 20001 RVA: 0x002049B4 File Offset: 0x00202BB4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RichTextBox
			Return Me.oOoo_0O.oo00oO.
		End Function

		' Token: 0x06004E22 RID: 20002 RVA: 0x002049BC File Offset: 0x00202BBC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RichTextBox)
			Me.oOoo_0O.oo00oO. = A_0
		End Sub

		' Token: 0x06004E23 RID: 20003 RVA: 0x002049C5 File Offset: 0x00202BC5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.o0O___0.
		End Function

		' Token: 0x06004E24 RID: 20004 RVA: 0x002049CD File Offset: 0x00202BCD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_.o0O___0. = A_0
		End Sub

		' Token: 0x06004E25 RID: 20005 RVA: 0x002049D6 File Offset: 0x00202BD6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_o0Oo.oO0O.
		End Function

		' Token: 0x06004E26 RID: 20006 RVA: 0x002049DE File Offset: 0x00202BDE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oo_o0Oo.oO0O. = A_0
		End Sub

		' Token: 0x06004E27 RID: 20007 RVA: 0x002049E8 File Offset: 0x00202BE8
		Friend Sub New()
			Me.oOoo_0O.oo00oO. = False
			Me.OoOOO00Oo_.0_O.()
			o_\u3002\u3002\u3000\u3000\u3002.oOoo_0O.oo00oO. = Me
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.O_o0._00oOO.() })
		End Sub

		' Token: 0x06004E28 RID: 20008 RVA: 0x00204A41 File Offset: 0x00202C41
		Friend Sub <<EMPTY_NAME>>(A_0 As Ribbon)
			Me.oOoo_0O.oo00oO. = A_0
			Me.O0.o_0.().Nodes(0).Expand()
			Me.O0.o_0.().SelectedNode = Me.O0.o_0.().Nodes(0)
		End Sub

		' Token: 0x04002052 RID: 8274
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04002053 RID: 8275
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002054 RID: 8276
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002055 RID: 8277
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04002056 RID: 8278
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04002057 RID: 8279
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002058 RID: 8280
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002059 RID: 8281
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x0400205A RID: 8282
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400205B RID: 8283
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x0400205C RID: 8284
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400205D RID: 8285
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x0400205E RID: 8286
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x0400205F RID: 8287
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04002060 RID: 8288
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04002061 RID: 8289
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04002062 RID: 8290
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RichTextBox

		' Token: 0x04002063 RID: 8291
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002064 RID: 8292
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002065 RID: 8293
		Friend <<EMPTY_NAME>> As Ribbon

		' Token: 0x04002066 RID: 8294
		Friend Shared <<EMPTY_NAME>> As o_\u3002\u3002\u3000\u3000\u3002

		' Token: 0x04002067 RID: 8295
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04002068 RID: 8296
		Friend <<EMPTY_NAME>> As Form

		' Token: 0x04002069 RID: 8297
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400206A RID: 8298
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400206B RID: 8299
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
