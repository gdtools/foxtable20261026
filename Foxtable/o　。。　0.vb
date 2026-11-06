Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace Foxtable
	' Token: 0x02000359 RID: 857
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u30000\u3000
		Inherits Form

		' Token: 0x06003522 RID: 13602 RVA: 0x00167040 File Offset: 0x00165240
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.Oo00oO0_O0.O0. IsNot Nothing Then
				Me.Oo00oO0_O0.O0..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003523 RID: 13603 RVA: 0x00167060 File Offset: 0x00165260
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo0ooOo.Oo.(New Label())
			Me.OOO_.OOooO.(New C1TextBox())
			Me.OoOo0.o.(New Label())
			Me.O0_.O.(New C1TextBox())
			Me.OOo00_o__oO.0.(New C1Button())
			Me.O._oO000o.(New Label())
			Me.ooooO.oo_Oo.(New C1Button())
			Me.O_O0._0.(New C1Button())
			Me.OoOo0.o.(New FolderBrowserDialog())
			Me.OoOo0.o.(New C1CheckBox())
			Me.O_o.oo.(New C1DockingTab())
			Me.O.00_00O.(New C1DockingTabPage())
			Me.O_o.oo.(New C1DockingTabPage())
			Me.O00_.o_.(New C1Button())
			Me.oo_OO.o0ooOO0_.(New C1Button())
			Me.O0Oo_O00.OOO.(New C1Button())
			Me.O_0_0_Oo0.__O_.(New C1Button())
			Me.O.00_00O.(New C1Button())
			Me.oO0OO__.o_.(New C1Button())
			Me.OOO_.OOooO.(New C1DockingTab())
			Me.OoOo0.o.(New C1DockingTabPage())
			Me.O._oO000o.(New oo0_o0o_0o__())
			Me.oo_0OOOo.O.(New C1DockingTabPage())
			Me.OoOo0.o.(New oo0_o0o_0o__())
			Me.O._oO000o.(New C1DockingTabPage())
			Me.O0_.O.(New oo0_o0o_0o__())
			Me.Oo_0oO_.oO.().BeginInit()
			Me.Oo_0oO_.oO.().SuspendLayout()
			Me.OO_0.O.().SuspendLayout()
			Me.Oo_0oO_.oO.().SuspendLayout()
			Me.O_O0._0.().BeginInit()
			Me.O_O0._0.().SuspendLayout()
			Me.OoO._O0o0__.().SuspendLayout()
			Me.O_0.OOO0OoO_0.().SuspendLayout()
			Me.o._00.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.OOo__0.oOOoo.().AutoSize = True
			Me.OOo__0.oOOoo.().Location = New Point(23, 22)
			Me.OOo__0.oOOoo.().Name = "Label1"
			Me.OOo__0.oOOoo.().Size = New Size(59, 12)
			Me.OOo__0.oOOoo.().TabIndex = 0
			Me.OOo__0.oOOoo.().Text = "项目名称:"
			Me.O_O0._0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_O0._0.().Location = New Point(23, 37)
			Me.O_O0._0.().Name = "txtName"
			Me.O_O0._0.().Size = New Size(487, 21)
			Me.O_O0._0.().TabIndex = 1
			Me.o._00.().AutoSize = True
			Me.o._00.().Location = New Point(23, 71)
			Me.o._00.().Name = "Label2"
			Me.o._00.().Size = New Size(59, 12)
			Me.o._00.().TabIndex = 2
			Me.o._00.().Text = "项目位置:"
			Me.oO0OO__.o_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO0OO__.o_.().Location = New Point(23, 86)
			Me.oO0OO__.o_.().Name = "txtFolder"
			Me.oO0OO__.o_.().[ReadOnly] = True
			Me.oO0OO__.o_.().Size = New Size(487, 21)
			Me.oO0OO__.o_.().TabIndex = 3
			Me.O.O00_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O.O00_.().Location = New Point(516, 84)
			Me.O.O00_.().Name = "btnFolderBrowser"
			Me.O.O00_.().Size = New Size(65, 23)
			Me.O.O00_.().TabIndex = 4
			Me.O.O00_.().Text = "浏览(B)"
			Me.O.O00_.().UseVisualStyleBackColor = True
			Me.O_0.OOO0OoO_0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_0.OOO0OoO_0.().Location = New Point(23, 168)
			Me.O_0.OOO0OoO_0.().Name = "lblDescription"
			Me.O_0.OOO0OoO_0.().Size = New Size(558, 193)
			Me.O_0.OOO0OoO_0.().TabIndex = 5
			Me.O_0.OOO0OoO_0.().Text = "提示:"
			Me.o_O0__oOo.OoO.().Anchor = AnchorStyles.Bottom
			Me.o_O0__oOo.OoO.().Location = New Point(238, 442)
			Me.o_O0__oOo.OoO.().Name = "btnOK"
			Me.o_O0__oOo.OoO.().Size = New Size(75, 23)
			Me.o_O0__oOo.OoO.().TabIndex = 1
			Me.o_O0__oOo.OoO.().Text = "确定(&O)"
			Me.o_O0__oOo.OoO.().UseVisualStyleBackColor = True
			Me.o__.ooooo__0o.().Anchor = AnchorStyles.Bottom
			Me.o__.ooooo__0o.().DialogResult = DialogResult.Cancel
			Me.o__.ooooo__0o.().Location = New Point(319, 442)
			Me.o__.ooooo__0o.().Name = "btnCancel"
			Me.o__.ooooo__0o.().Size = New Size(75, 23)
			Me.o__.ooooo__0o.().TabIndex = 2
			Me.o__.ooooo__0o.().Text = "取消(&X)"
			Me.o__.ooooo__0o.().UseVisualStyleBackColor = True
			Me.OOo__0.oOOoo.().Description = "系统位置"
			Me.OOo__0.oOOoo.().AutoCheck = False
			Me.OOo__0.oOOoo.().AutoSize = True
			Me.OOo__0.oOOoo.().Checked = True
			Me.OOo__0.oOOoo.().CheckState = CheckState.Checked
			Me.OOo__0.oOOoo.().Location = New Point(23, 124)
			Me.OOo__0.oOOoo.().Name = "chkCreateFolder"
			Me.OOo__0.oOOoo.().Size = New Size(108, 16)
			Me.OOo__0.oOOoo.().TabIndex = 8
			Me.OOo__0.oOOoo.().Text = "创建专用文件夹"
			Me.OOo__0.oOOoo.().UseVisualStyleBackColor = True
			Me.Oo_0oO_.oO.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.Oo_0oO_.oO.().Controls.Add(Me.OO_0.O.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.Oo_0oO_.oO.())
			Me.Oo_0oO_.oO.().Location = New Point(12, 12)
			Me.Oo_0oO_.oO.().Name = "C1DockingTab1"
			Me.Oo_0oO_.oO.().Size = New Size(609, 413)
			Me.Oo_0oO_.oO.().TabIndex = 0
			Me.Oo_0oO_.oO.().TabsCanFocus = False
			Me.Oo_0oO_.oO.().TabsSpacing = 0
			Me.Oo_0oO_.oO.().TabStyle = 1
			Me.Oo_0oO_.oO.().VisualStyle = 13
			Me.Oo_0oO_.oO.().VisualStyleBase = 13
			Me.OO_0.O.().Controls.Add(Me.oO0OO__.o_.())
			Me.OO_0.O.().Controls.Add(Me.O_O0._0.())
			Me.OO_0.O.().Controls.Add(Me.OOo__0.oOOoo.())
			Me.OO_0.O.().Controls.Add(Me.OOo__0.oOOoo.())
			Me.OO_0.O.().Controls.Add(Me.O.O00_.())
			Me.OO_0.O.().Controls.Add(Me.o._00.())
			Me.OO_0.O.().Controls.Add(Me.O_0.OOO0OoO_0.())
			Me.OO_0.O.().Location = New Point(2, 26)
			Me.OO_0.O.().Name = "C1DockingTabPage1"
			Me.OO_0.O.().Size = New Size(603, 383)
			Me.OO_0.O.().TabIndex = 0
			Me.OO_0.O.().Text = "创建项目"
			Me.Oo_0oO_.oO.().Controls.Add(Me.oo0oOo0o.O.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.OO_0.O.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.o_oO.__O0oOO.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.O_._o0O0_00o.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.Ooo.Oo0O___O_O.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.Oo___.oo.())
			Me.Oo_0oO_.oO.().Controls.Add(Me.O_O0._0.())
			Me.Oo_0oO_.oO.().Location = New Point(2, 26)
			Me.Oo_0oO_.oO.().Name = "C1DockingTabPage2"
			Me.Oo_0oO_.oO.().Size = New Size(603, 383)
			Me.Oo_0oO_.oO.().TabIndex = 1
			Me.Oo_0oO_.oO.().Text = "创建表"
			Me.oo0oOo0o.O.().Location = New Point(515, 267)
			Me.oo0oOo0o.O.().Name = "btnDelete"
			Me.oo0oOo0o.O.().Size = New Size(75, 23)
			Me.oo0oOo0o.O.().TabIndex = 6
			Me.oo0oOo0o.O.().Text = "删除行"
			Me.oo0oOo0o.O.().UseVisualStyleBackColor = True
			Me.OO_0.O.().Location = New Point(515, 237)
			Me.OO_0.O.().Name = "btnMoveDown"
			Me.OO_0.O.().Size = New Size(75, 23)
			Me.OO_0.O.().TabIndex = 5
			Me.OO_0.O.().Text = "下移行"
			Me.OO_0.O.().UseVisualStyleBackColor = True
			Me.o_oO.__O0oOO.().Location = New Point(515, 207)
			Me.o_oO.__O0oOO.().Name = "btnMoveUp"
			Me.o_oO.__O0oOO.().Size = New Size(75, 23)
			Me.o_oO.__O0oOO.().TabIndex = 4
			Me.o_oO.__O0oOO.().Text = "上移行"
			Me.o_oO.__O0oOO.().UseVisualStyleBackColor = True
			Me.O_._o0O0_00o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O_._o0O0_00o.().Location = New Point(515, 97)
			Me.O_._o0O0_00o.().Name = "btnRename"
			Me.O_._o0O0_00o.().Size = New Size(75, 23)
			Me.O_._o0O0_00o.().TabIndex = 3
			Me.O_._o0O0_00o.().Tag = ""
			Me.O_._o0O0_00o.().Text = "重命名"
			Me.O_._o0O0_00o.().UseVisualStyleBackColor = True
			Me.Ooo.Oo0O___O_O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Ooo.Oo0O___O_O.().Location = New Point(515, 67)
			Me.Ooo.Oo0O___O_O.().Name = "btnDel"
			Me.Ooo.Oo0O___O_O.().Size = New Size(75, 23)
			Me.Ooo.Oo0O___O_O.().TabIndex = 2
			Me.Ooo.Oo0O___O_O.().Text = "删除表"
			Me.Ooo.Oo0O___O_O.().UseVisualStyleBackColor = True
			Me.Oo___.oo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Oo___.oo.().Location = New Point(515, 37)
			Me.Oo___.oo.().Name = "btnAdd"
			Me.Oo___.oo.().Size = New Size(75, 23)
			Me.Oo___.oo.().TabIndex = 1
			Me.Oo___.oo.().Text = "增加表"
			Me.Oo___.oo.().UseVisualStyleBackColor = True
			Me.O_O0._0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_O0._0.().BorderStyle = BorderStyle.None
			Me.O_O0._0.().Controls.Add(Me.OoO._O0o0__.())
			Me.O_O0._0.().Controls.Add(Me.O_0.OOO0OoO_0.())
			Me.O_O0._0.().Controls.Add(Me.o._00.())
			Me.O_O0._0.().Location = New Point(13, 12)
			Me.O_O0._0.().Name = "TablePages"
			Me.O_O0._0.().Size = New Size(487, 356)
			Me.O_O0._0.().TabIndex = 0
			Me.O_O0._0.().TabsCanFocus = False
			Me.O_O0._0.().TabsSpacing = 0
			Me.O_O0._0.().TabStyle = 1
			Me.O_O0._0.().VisualStyle = 13
			Me.O_O0._0.().VisualStyleBase = 13
			Me.OoO._O0o0__.().Controls.Add(Me.OOo__0.oOOoo.())
			Me.OoO._O0o0__.().Location = New Point(0, 25)
			Me.OoO._O0o0__.().Name = "C1DockingTabPage3"
			Me.OoO._O0o0__.().Size = New Size(487, 331)
			Me.OoO._O0o0__.().TabIndex = 0
			Me.OoO._O0o0__.().Text = "表A"
			Me.OOo__0.oOOoo.().Dock = DockStyle.Fill
			Me.OOo__0.oOOoo.().Location = New Point(0, 0)
			Me.OOo__0.oOOoo.().Name = "StructureEditor1"
			Me.OOo__0.oOOoo.().Size = New Size(487, 331)
			Me.OOo__0.oOOoo.().TabIndex = 0
			Me.O_0.OOO0OoO_0.().Controls.Add(Me.O_O0._0.())
			Me.O_0.OOO0OoO_0.().Location = New Point(0, 25)
			Me.O_0.OOO0OoO_0.().Name = "C1DockingTabPage4"
			Me.O_0.OOO0OoO_0.().Size = New Size(487, 331)
			Me.O_0.OOO0OoO_0.().TabIndex = 1
			Me.O_0.OOO0OoO_0.().Text = "表B"
			Me.O_O0._0.().Dock = DockStyle.Fill
			Me.O_O0._0.().Location = New Point(0, 0)
			Me.O_O0._0.().Name = "StructureEditor2"
			Me.O_O0._0.().Size = New Size(487, 331)
			Me.O_O0._0.().TabIndex = 1
			Me.o._00.().Controls.Add(Me.ooOOO0OO0o.O.())
			Me.o._00.().Location = New Point(0, 25)
			Me.o._00.().Name = "C1DockingTabPage5"
			Me.o._00.().Size = New Size(487, 331)
			Me.o._00.().TabIndex = 2
			Me.o._00.().Text = "表C"
			Me.ooOOO0OO0o.O.().Dock = DockStyle.Fill
			Me.ooOOO0OO0o.O.().Location = New Point(0, 0)
			Me.ooOOO0OO0o.O.().Name = "StructureEditor3"
			Me.ooOOO0OO0o.O.().Size = New Size(487, 331)
			Me.ooOOO0OO0o.O.().TabIndex = 1
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(633, 477)
			MyBase.Controls.Add(Me.Oo_0oO_.oO.())
			MyBase.Controls.Add(Me.o__.ooooo__0o.())
			MyBase.Controls.Add(Me.o_O0__oOo.OoO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "OO....o."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "创建项目"
			Me.Oo_0oO_.oO.().EndInit()
			Me.Oo_0oO_.oO.().ResumeLayout(False)
			Me.OO_0.O.().ResumeLayout(False)
			Me.OO_0.O.().PerformLayout()
			Me.Oo_0oO_.oO.().ResumeLayout(False)
			Me.O_O0._0.().EndInit()
			Me.O_O0._0.().ResumeLayout(False)
			Me.OoO._O0o0__.().ResumeLayout(False)
			Me.O_0.OOO0OoO_0.().ResumeLayout(False)
			Me.o._00.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003524 RID: 13604 RVA: 0x00167F57 File Offset: 0x00166157
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0.0O__o.
		End Function

		' Token: 0x06003525 RID: 13605 RVA: 0x00167F5F File Offset: 0x0016615F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0.0O__o. = A_0
		End Sub

		' Token: 0x06003526 RID: 13606 RVA: 0x00167F68 File Offset: 0x00166168
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.OOO0_o0OO0_o.
		End Function

		' Token: 0x06003527 RID: 13607 RVA: 0x00167F70 File Offset: 0x00166170
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.OOO0_o0OO0_o. = A_0
		End Sub

		' Token: 0x06003528 RID: 13608 RVA: 0x00167F79 File Offset: 0x00166179
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO0O._O.
		End Function

		' Token: 0x06003529 RID: 13609 RVA: 0x00167F84 File Offset: 0x00166184
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.O_0O.
			Dim oo0O._O. As C1Button = Me.OO0O._O.
			If oo0O._O. IsNot Nothing Then
				RemoveHandler oo0O._O..Click, value
			End If
			Me.OO0O._O. = A_0
			oo0O._O. = Me.OO0O._O.
			If oo0O._O. IsNot Nothing Then
				AddHandler oo0O._O..Click, value
			End If
		End Sub

		' Token: 0x0600352A RID: 13610 RVA: 0x00167FC7 File Offset: 0x001661C7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oOo.OOo.
		End Function

		' Token: 0x0600352B RID: 13611 RVA: 0x00167FCF File Offset: 0x001661CF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oOo.OOo. = A_0
		End Sub

		' Token: 0x0600352C RID: 13612 RVA: 0x00167FD8 File Offset: 0x001661D8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_oO0.o00.
		End Function

		' Token: 0x0600352D RID: 13613 RVA: 0x00167FE0 File Offset: 0x001661E0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O00O__Oo.0O.
			Dim c1Button As C1Button = Me.o_oO0.o00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_oO0.o00. = A_0
			c1Button = Me.o_oO0.o00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600352E RID: 13614 RVA: 0x00168023 File Offset: 0x00166223
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoOooOo.OOOO.
		End Function

		' Token: 0x0600352F RID: 13615 RVA: 0x0016802B File Offset: 0x0016622B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OOoOooOo.OOOO. = A_0
		End Sub

		' Token: 0x06003530 RID: 13616 RVA: 0x00168034 File Offset: 0x00166234
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As FolderBrowserDialog
			Return Me.o0.0O__o.
		End Function

		' Token: 0x06003531 RID: 13617 RVA: 0x0016803C File Offset: 0x0016623C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As FolderBrowserDialog)
			Me.o0.0O__o. = A_0
		End Sub

		' Token: 0x06003532 RID: 13618 RVA: 0x00168045 File Offset: 0x00166245
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo00oO0_O0.O0.
		End Function

		' Token: 0x06003533 RID: 13619 RVA: 0x00168050 File Offset: 0x00166250
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As KeyPressEventHandler = AddressOf Me.OOO_.OOooO.
			Dim value2 As EventHandler = AddressOf Me.oO_O00._o.
			Dim oo00oO0_O0.O0. As C1TextBox = Me.Oo00oO0_O0.O0.
			If oo00oO0_O0.O0. IsNot Nothing Then
				RemoveHandler oo00oO0_O0.O0..KeyPress, value
				RemoveHandler oo00oO0_O0.O0..TextChanged, value2
			End If
			Me.Oo00oO0_O0.O0. = A_0
			oo00oO0_O0.O0. = Me.Oo00oO0_O0.O0.
			If oo00oO0_O0.O0. IsNot Nothing Then
				AddHandler oo00oO0_O0.O0..KeyPress, value
				AddHandler oo00oO0_O0.O0..TextChanged, value2
			End If
		End Sub

		' Token: 0x06003534 RID: 13620 RVA: 0x001680AE File Offset: 0x001662AE
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o__00oOo.OOo__.
		End Function

		' Token: 0x06003535 RID: 13621 RVA: 0x001680B6 File Offset: 0x001662B6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o__00oOo.OOo__. = A_0
		End Sub

		' Token: 0x06003536 RID: 13622 RVA: 0x001680BF File Offset: 0x001662BF
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0.0O__o.
		End Function

		' Token: 0x06003537 RID: 13623 RVA: 0x001680C7 File Offset: 0x001662C7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0.0O__o. = A_0
		End Sub

		' Token: 0x06003538 RID: 13624 RVA: 0x001680D0 File Offset: 0x001662D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.OO0O._O.
		End Function

		' Token: 0x06003539 RID: 13625 RVA: 0x001680D8 File Offset: 0x001662D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.OO0O._O. = A_0
		End Sub

		' Token: 0x0600353A RID: 13626 RVA: 0x001680E1 File Offset: 0x001662E1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.OO0O._O.
		End Function

		' Token: 0x0600353B RID: 13627 RVA: 0x001680E9 File Offset: 0x001662E9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.OO0O._O. = A_0
		End Sub

		' Token: 0x0600353C RID: 13628 RVA: 0x001680F2 File Offset: 0x001662F2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o_oO0.o00.
		End Function

		' Token: 0x0600353D RID: 13629 RVA: 0x001680FA File Offset: 0x001662FA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o_oO0.o00. = A_0
		End Sub

		' Token: 0x0600353E RID: 13630 RVA: 0x00168103 File Offset: 0x00166303
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.___oO00oO.
		End Function

		' Token: 0x0600353F RID: 13631 RVA: 0x0016810C File Offset: 0x0016630C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0O_OO_.0_.
			Dim o_.___oO00oO. As C1Button = Me.O_.___oO00oO.
			If o_.___oO00oO. IsNot Nothing Then
				RemoveHandler o_.___oO00oO..Click, value
			End If
			Me.O_.___oO00oO. = A_0
			o_.___oO00oO. = Me.O_.___oO00oO.
			If o_.___oO00oO. IsNot Nothing Then
				AddHandler o_.___oO00oO..Click, value
			End If
		End Sub

		' Token: 0x06003540 RID: 13632 RVA: 0x0016814F File Offset: 0x0016634F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0o0o.o.
		End Function

		' Token: 0x06003541 RID: 13633 RVA: 0x00168158 File Offset: 0x00166358
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0ooO0._o.
			Dim c1Button As C1Button = Me.o0o0o.o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0o0o.o. = A_0
			c1Button = Me.o0o0o.o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003542 RID: 13634 RVA: 0x0016819B File Offset: 0x0016639B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_0_._o__0.
		End Function

		' Token: 0x06003543 RID: 13635 RVA: 0x001681A4 File Offset: 0x001663A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooo0oO0___.Oo.
			Dim c1Button As C1Button = Me.oo_0_._o__0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_0_._o__0. = A_0
			c1Button = Me.oo_0_._o__0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003544 RID: 13636 RVA: 0x001681E7 File Offset: 0x001663E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.O.OOO0_o0OO0_o.
		End Function

		' Token: 0x06003545 RID: 13637 RVA: 0x001681EF File Offset: 0x001663EF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.O.OOO0_o0OO0_o. = A_0
		End Sub

		' Token: 0x06003546 RID: 13638 RVA: 0x001681F8 File Offset: 0x001663F8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_oo.o0OoO__Oo.
		End Function

		' Token: 0x06003547 RID: 13639 RVA: 0x00168200 File Offset: 0x00166400
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_oo.o0OoO__Oo. = A_0
		End Sub

		' Token: 0x06003548 RID: 13640 RVA: 0x00168209 File Offset: 0x00166409
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oo0_o0o_0o__
			Return Me.o0.0O__o.
		End Function

		' Token: 0x06003549 RID: 13641 RVA: 0x00168211 File Offset: 0x00166411
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oo0_o0o_0o__)
			Me.o0.0O__o. = A_0
		End Sub

		' Token: 0x0600354A RID: 13642 RVA: 0x0016821A File Offset: 0x0016641A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_.___oO00oO.
		End Function

		' Token: 0x0600354B RID: 13643 RVA: 0x00168222 File Offset: 0x00166422
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_.___oO00oO. = A_0
		End Sub

		' Token: 0x0600354C RID: 13644 RVA: 0x0016822B File Offset: 0x0016642B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.Oo.0o_0.
		End Function

		' Token: 0x0600354D RID: 13645 RVA: 0x00168233 File Offset: 0x00166433
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.Oo.0o_0. = A_0
		End Sub

		' Token: 0x0600354E RID: 13646 RVA: 0x0016823C File Offset: 0x0016643C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oo0_o0o_0o__
			Return Me.O.OOO0_o0OO0_o.
		End Function

		' Token: 0x0600354F RID: 13647 RVA: 0x00168244 File Offset: 0x00166444
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oo0_o0o_0o__)
			Me.O.OOO0_o0OO0_o. = A_0
		End Sub

		' Token: 0x06003550 RID: 13648 RVA: 0x0016824D File Offset: 0x0016644D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oo0_o0o_0o__
			Return Me.oOo.OOo.
		End Function

		' Token: 0x06003551 RID: 13649 RVA: 0x00168255 File Offset: 0x00166455
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oo0_o0o_0o__)
			Me.oOo.OOo. = A_0
		End Sub

		' Token: 0x06003552 RID: 13650 RVA: 0x0016825E File Offset: 0x0016645E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_O00._o.
		End Function

		' Token: 0x06003553 RID: 13651 RVA: 0x00168268 File Offset: 0x00166468
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O__o0Oo_o.0.
			Dim c1Button As C1Button = Me.oO_O00._o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_O00._o. = A_0
			c1Button = Me.oO_O00._o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003554 RID: 13652 RVA: 0x001682AB File Offset: 0x001664AB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_0o._O_O.
		End Function

		' Token: 0x06003555 RID: 13653 RVA: 0x001682B4 File Offset: 0x001664B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O0o_Oo_.o_.
			Dim c1Button As C1Button = Me.o_0o._O_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_0o._O_O. = A_0
			c1Button = Me.o_0o._O_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003556 RID: 13654 RVA: 0x001682F7 File Offset: 0x001664F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOO0_.o0o_OO0.
		End Function

		' Token: 0x06003557 RID: 13655 RVA: 0x00168300 File Offset: 0x00166500
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0_0._O.
			Dim c1Button As C1Button = Me.oOO0_.o0o_OO0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOO0_.o0o_OO0. = A_0
			c1Button = Me.oOO0_.o0o_OO0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003558 RID: 13656 RVA: 0x00168344 File Offset: 0x00166544
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O._OO_O0o0_.
			AddHandler MyBase.FormClosed, AddressOf Me.o__.ooooo__0o.
			Me.O_O0._0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.Oo_0oO_.oO.() })
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.O_O0._0.() })
		End Sub

		' Token: 0x06003559 RID: 13657 RVA: 0x001683D2 File Offset: 0x001665D2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOo__0.oOOoo.().ShowDialog() = DialogResult.OK Then
				Me.oO0OO__.o_.().Value = Me.OOo__0.oOOoo.().SelectedPath
				Me.oO0OO__.o_.()
				Me.ooOOO0OO0o.O.()
			End If
		End Sub

		' Token: 0x0600355A RID: 13658 RVA: 0x00168404 File Offset: 0x00166604
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOo__0.oOOoo.().RootFolder = Environment.SpecialFolder.MyComputer
			Me.oO0OO__.o_.().Value = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\Foxtable项目"
			Me.oO0OO__.o_.()
			Me.ooOOO0OO0o.O.()
			Me.OOo__0.oOOoo.().O_oo.0oOO. = True
			Me.OOo__0.oOOoo.().o00_0O0.0O_.()
			Oo00.o_o_oo.0o.(Me.OOo__0.oOOoo.().O_oo.0oOO.)
			Me.O_O0._0.().O_oo.0oOO. = True
			Me.O_O0._0.().o00_0O0.0O_.()
			Oo00.o_o_oo.0o.(Me.O_O0._0.().O_oo.0oOO.)
			Me.ooOOO0OO0o.O.().O_oo.0oOO. = True
			Me.ooOOO0OO0o.O.().o00_0O0.0O_.()
			Oo00.o_o_oo.0o.(Me.ooOOO0OO0o.O.().O_oo.0oOO.)
		End Sub

		' Token: 0x0600355B RID: 13659 RVA: 0x001684BC File Offset: 0x001666BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.oO0OO__.o_.().Text, "", True) = 0 Or Operators.CompareString(Me.O_O0._0.().Text, "", True) = 0 Then
				MessageBox.Show("请输入新的项目名称和位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If c.OOOOO.o.().FileSystem.DirectoryExists(Me.oO0OO__.o_.().Text + Me.O_O0._0.().Text) Then
				If MessageBox.Show("文件夹 " + Me.oO0OO__.o_.().Text + Me.O_O0._0.().Text + " 已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					MyBase.DialogResult = DialogResult.OK
					Return
				End If
			Else
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x0600355C RID: 13660 RVA: 0x00168584 File Offset: 0x00166784
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer = 0
			Try
				For Each text As String In c.OOOOO.o.().FileSystem.GetDirectories(Me.oO0OO__.o_.().Text, SearchOption.SearchTopLevelOnly, New String() { "管理项目*" })
					If Versioned.IsNumeric(text.Substring(text.LastIndexOf("\") + "管理项目".Length + 1)) Then
						num = Convert.ToInt32(Math.Max(CDbl(num), Conversion.Val(text.Substring(text.LastIndexOf("\") + "管理项目".Length + 1))))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.Oo00oO0_O0.O0. = "管理项目" + Conversions.ToString(num + 1)
			Me.O_O0._0.().Text = Me.Oo00oO0_O0.O0.
		End Sub

		' Token: 0x0600355D RID: 13661 RVA: 0x00168670 File Offset: 0x00166870
		Public Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.oO0OO__.o_.().Text, "", True) = 0 Or Operators.CompareString(Me.O_O0._0.().Text, "", True) = 0 Then
				Me.O_0.OOO0OoO_0.().Text = ""
				Return
			End If
			If Not Me.oO0OO__.o_.().Text.EndsWith("\") Then
				Me.oO0OO__.o_.().Value = Me.oO0OO__.o_.().Text + "\"
			End If
			Me.O_0.OOO0OoO_0.().Text = String.Concat(New String() { "将创建: ", Me.oO0OO__.o_.().Text, Me.O_O0._0.().Text, "\", Me.O_O0._0.().Text, ooO0__OO.oo.Ooo_00.() })
		End Sub

		' Token: 0x0600355E RID: 13662 RVA: 0x00168752 File Offset: 0x00166952
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If A_1.KeyChar = "."c Then
				A_1.Handled = True
			End If
		End Sub

		' Token: 0x0600355F RID: 13663 RVA: 0x00168765 File Offset: 0x00166965
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooOOO0OO0o.O.()
		End Sub

		' Token: 0x06003560 RID: 13664 RVA: 0x00168770 File Offset: 0x00166970
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "")
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.o000_oO000o.O. = Me.OOo__0.oOOoo.()
			If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
				Dim text As String = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
				Dim c1DockingTabPage As C1DockingTabPage = New C1DockingTabPage()
				Dim oo0_o0o_0o__ As oo0_o0o_0o__ = New oo0_o0o_0o__()
				oo0_o0o_0o__.O_oo.0oOO. = True
				oo0_o0o_0o__.O_oo.0oOO. = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
				c1DockingTabPage.Controls.Add(oo0_o0o_0o__)
				c1DockingTabPage.Controls(0).Dock = DockStyle.Fill
				c1DockingTabPage.Text = text
				Main.OO_O.o..OOoo___.0.(oo0_o0o_0o__.Controls, "(default)")
				Me.O_O0._0.().TabPages.Add(c1DockingTabPage)
				oo0_o0o_0o__.o00_0O0.0O_.()
				Oo00.o_o_oo.0o.(oo0_o0o_0o__.O_oo.0oOO.)
				Me.O_O0._0.().SelectedIndex = Me.O_O0._0.().TabPages.Count - 1
			End If
		End Sub

		' Token: 0x06003561 RID: 13665 RVA: 0x0016884C File Offset: 0x00166A4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_O0._0.().TabPages.Count = 1 Then
				MessageBox.Show("至少要保留一个表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			Me.O_O0._0.().TabPages.Remove(Me.O_O0._0.().SelectedTab)
		End Sub

		' Token: 0x06003562 RID: 13666 RVA: 0x0016889C File Offset: 0x00166A9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u As o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 = New o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(Me.O_O0._0.().SelectedTab.Text, CType(Me.O_O0._0.().SelectedTab.Controls(0), oo0_o0o_0o__).O_oo.0oOO.)
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.o000_oO000o.O. = Me.OOo__0.oOOoo.()
			If o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
				Me.O_O0._0.().SelectedTab.Text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.()
				CType(Me.O_O0._0.().SelectedTab.Controls(0), oo0_o0o_0o__).O_oo.0oOO. = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.()
			End If
		End Sub

		' Token: 0x06003563 RID: 13667 RVA: 0x00168930 File Offset: 0x00166B30
		Friend Function <<EMPTY_NAME>>() As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim num As Integer = Me.O_O0._0.().TabCount - 1
			For i As Integer = 0 To num
				list.Add(Me.O_O0._0.().TabPages(i).Text)
			Next
			Return list
		End Function

		' Token: 0x06003564 RID: 13668 RVA: 0x0016897A File Offset: 0x00166B7A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			CType(Me.O_O0._0.().SelectedTab.Controls(0), oo0_o0o_0o__).OoO_Oo._o.()
		End Sub

		' Token: 0x06003565 RID: 13669 RVA: 0x0016899C File Offset: 0x00166B9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			CType(Me.O_O0._0.().SelectedTab.Controls(0), oo0_o0o_0o__).O_._O0Oo_o.()
		End Sub

		' Token: 0x06003566 RID: 13670 RVA: 0x001689BE File Offset: 0x00166BBE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			CType(Me.O_O0._0.().SelectedTab.Controls(0), oo0_o0o_0o__).O0o.OOoo.()
		End Sub

		' Token: 0x06003567 RID: 13671 RVA: 0x001689E0 File Offset: 0x00166BE0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040015C8 RID: 5576
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040015C9 RID: 5577
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040015CA RID: 5578
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040015CB RID: 5579
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015CC RID: 5580
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040015CD RID: 5581
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015CE RID: 5582
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015CF RID: 5583
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FolderBrowserDialog

		' Token: 0x040015D0 RID: 5584
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040015D1 RID: 5585
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040015D2 RID: 5586
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x040015D3 RID: 5587
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040015D4 RID: 5588
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040015D5 RID: 5589
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040015D6 RID: 5590
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015D7 RID: 5591
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015D8 RID: 5592
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015D9 RID: 5593
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040015DA RID: 5594
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040015DB RID: 5595
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oo0_o0o_0o__

		' Token: 0x040015DC RID: 5596
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040015DD RID: 5597
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x040015DE RID: 5598
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oo0_o0o_0o__

		' Token: 0x040015DF RID: 5599
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oo0_o0o_0o__

		' Token: 0x040015E0 RID: 5600
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015E1 RID: 5601
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015E2 RID: 5602
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040015E3 RID: 5603
		Private <<EMPTY_NAME>> As String

		' Token: 0x040015E4 RID: 5604
		Private Const <<EMPTY_NAME>> As String = "管理项目"
	End Class
End Namespace
