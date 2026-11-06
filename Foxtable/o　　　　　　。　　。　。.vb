Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200017B RID: 379
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06001170 RID: 4464 RVA: 0x0006C494 File Offset: 0x0006A694
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0OO0OoOO0._. IsNot Nothing Then
					Me.O0OO0OoOO0._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001171 RID: 4465 RVA: 0x0006C4D4 File Offset: 0x0006A6D4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O0OO0OoOO0._. = New Container()
			Me.o_O_00.0O0.(New TreeView())
			Me.O__o__.O_.(New C1Button())
			Me.o_.00ooo_O0.(New C1Button())
			Me.oO0Oo0.0_oO0oO.(New C1Button())
			Me.OOo0oOo._.(New C1Button())
			Me.oOoo0.O_0__.(New C1Button())
			Me.o.oOO0O0o.(New C1Button())
			Me.oOo_.o_O0__0.(New C1Button())
			Me.o00ooo_0.ooOO.(New C1Button())
			Me.o_O_00.0O0.(New PropertyGrid())
			Me.o0.0o_0o0o__.(New C1Button())
			Me.oo0_oO_O_o.0o.(New C1Button())
			Me.O_.O_OoOOo__.(New ContextMenuStrip(Me.O0OO0OoOO0._.))
			Me.oO0o._O_0000oo.(New ToolStripMenuItem())
			Me.o0.0o_0o0o__.(New ToolStripMenuItem())
			Me.O_.O_OoOOo__.(New ToolStripMenuItem())
			Me.OooOO.0__.(New ToolStripMenuItem())
			Me.O_.O_OoOOo__.(New C1Button())
			Me.oooO0o_Oo00.0_.(New C1Button())
			Me.o.0__0O.(New C1Button())
			Me.ooOO0_OO.o000.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.O.o_0O0.().HideSelection = False
			Me.O.o_0O0.().Location = New Point(12, 15)
			Me.O.o_0O0.().Name = "TreeView1"
			Me.O.o_0O0.().Size = New Size(204, 472)
			Me.O.o_0O0.().TabIndex = 0
			Me.Oo_0_.o.().Location = New Point(223, 16)
			Me.Oo_0_.o.().Name = "btnAddMenu"
			Me.Oo_0_.o.().Size = New Size(84, 23)
			Me.Oo_0_.o.().TabIndex = 1
			Me.Oo_0_.o.().Text = "增加菜单"
			Me.Oo_0_.o.().UseVisualStyleBackColor = True
			Me.oO0_O._o_O.().Location = New Point(223, 46)
			Me.oO0_O._o_O.().Name = "btnAddCommand"
			Me.oO0_O._o_O.().Size = New Size(84, 23)
			Me.oO0_O._o_O.().TabIndex = 2
			Me.oO0_O._o_O.().Text = "增加项"
			Me.oO0_O._o_O.().UseVisualStyleBackColor = True
			Me.O00_o0.o_00_.().Location = New Point(223, 76)
			Me.O00_o0.o_00_.().Name = "btnAddChild"
			Me.O00_o0.o_00_.().Size = New Size(84, 23)
			Me.O00_o0.o_00_.().TabIndex = 3
			Me.O00_o0.o_00_.().Text = "增加子项"
			Me.O00_o0.o_00_.().UseVisualStyleBackColor = True
			Me.o__O.o00O0Oo.().Location = New Point(223, 106)
			Me.o__O.o00O0Oo.().Name = "btnDelete"
			Me.o__O.o00O0Oo.().Size = New Size(84, 23)
			Me.o__O.o00O0Oo.().TabIndex = 4
			Me.o__O.o00O0Oo.().Text = "删除"
			Me.o__O.o00O0Oo.().UseVisualStyleBackColor = True
			Me.O_oO0O.o_oo.().Location = New Point(223, 154)
			Me.O_oO0O.o_oo.().Name = "btnMoveUP"
			Me.O_oO0O.o_oo.().Size = New Size(84, 23)
			Me.O_oO0O.o_oo.().TabIndex = 5
			Me.O_oO0O.o_oo.().Text = "上移"
			Me.O_oO0O.o_oo.().UseVisualStyleBackColor = True
			Me.Oo_0O_0_.oO_.().Location = New Point(223, 184)
			Me.Oo_0O_0_.oO_.().Name = "btnModeDown"
			Me.Oo_0O_0_.oO_.().Size = New Size(84, 23)
			Me.Oo_0O_0_.oO_.().TabIndex = 6
			Me.Oo_0O_0_.oO_.().Text = "下移"
			Me.Oo_0O_0_.oO_.().UseVisualStyleBackColor = True
			Me.Oo._OO_.().Location = New Point(223, 213)
			Me.Oo._OO_.().Name = "btnMoveLeft"
			Me.Oo._OO_.().Size = New Size(84, 23)
			Me.Oo._OO_.().TabIndex = 7
			Me.Oo._OO_.().Text = "左移"
			Me.Oo._OO_.().UseVisualStyleBackColor = True
			Me.O.__O.().Location = New Point(223, 242)
			Me.O.__O.().Name = "btnModeRight"
			Me.O.__O.().Size = New Size(84, 23)
			Me.O.__O.().TabIndex = 8
			Me.O.__O.().Text = "右移"
			Me.O.__O.().UseVisualStyleBackColor = True
			Me.O.o_0O0.().Location = New Point(313, 16)
			Me.O.o_0O0.().Name = "PropertyGrid1"
			Me.O.o_0O0.().PropertySort = PropertySort.NoSort
			Me.O.o_0O0.().Size = New Size(392, 472)
			Me.O.o_0O0.().TabIndex = 9
			Me.O.o_0O0.().ToolbarVisible = False
			Me.o_O___o_0.ooo_.().DialogResult = DialogResult.OK
			Me.o_O___o_0.ooo_.().Location = New Point(549, 501)
			Me.o_O___o_0.ooo_.().Name = "btnOK"
			Me.o_O___o_0.ooo_.().Size = New Size(75, 23)
			Me.o_O___o_0.ooo_.().TabIndex = 10
			Me.o_O___o_0.ooo_.().Text = "确定"
			Me.o_O___o_0.ooo_.().UseVisualStyleBackColor = True
			Me.O.OOoOO.().Location = New Point(630, 501)
			Me.O.OOoOO.().Name = "btnCancel"
			Me.O.OOoOO.().Size = New Size(75, 23)
			Me.O.OOoOO.().TabIndex = 11
			Me.O.OOoOO.().Text = "取消"
			Me.O.OOoOO.().UseVisualStyleBackColor = True
			Me.ooOO0_OO.o000.().Items.AddRange(New ToolStripItem() { Me.OO0.0ooO.(), Me.o_O___o_0.ooo_.(), Me.o.o_o0o_0o.(), Me.ooOO0_OO.o000.() })
			Me.ooOO0_OO.o000.().Name = "mnuAddMenu"
			Me.ooOO0_OO.o000.().Size = New Size(149, 92)
			Me.OO0.0ooO.().Name = "mnuAddMainMenu"
			Me.OO0.0ooO.().Size = New Size(148, 22)
			Me.OO0.0ooO.().Text = "增加主菜单"
			Me.o_O___o_0.ooo_.().Name = "mnuAddToolBar"
			Me.o_O___o_0.ooo_.().Size = New Size(148, 22)
			Me.o_O___o_0.ooo_.().Text = "增加工具栏"
			Me.o.o_o0o_0o.().Name = "mnuAddStatusBar"
			Me.o.o_o0o_0o.().Size = New Size(148, 22)
			Me.o.o_o0o_0o.().Text = "增加状态栏"
			Me.ooOO0_OO.o000.().Name = "mnuAddContextMenu"
			Me.ooOO0_OO.o000.().Size = New Size(148, 22)
			Me.ooOO0_OO.o000.().Text = "增加快捷菜单"
			Me.o.o_o0o_0o.().Location = New Point(12, 501)
			Me.o.o_o0o_0o.().Name = "Button1"
			Me.o.o_o0o_0o.().Size = New Size(75, 23)
			Me.o.o_o0o_0o.().TabIndex = 12
			Me.o.o_o0o_0o.().Text = "存为模版"
			Me.o.o_o0o_0o.().UseVisualStyleBackColor = True
			Me.oo0.0_oo0O00O0.().Location = New Point(93, 501)
			Me.oo0.0_oo0O00O0.().Name = "Button2"
			Me.oo0.0_oo0O00O0.().Size = New Size(75, 23)
			Me.oo0.0_oo0O00O0.().TabIndex = 13
			Me.oo0.0_oo0O00O0.().Text = "调用模版"
			Me.oo0.0_oo0O00O0.().UseVisualStyleBackColor = True
			Me.oOo.Oo00O.().Location = New Point(175, 501)
			Me.oOo.Oo00O.().Name = "btnPreview"
			Me.oOo.Oo00O.().Size = New Size(75, 23)
			Me.oOo.Oo00O.().TabIndex = 14
			Me.oOo.Oo00O.().Text = "预览"
			Me.oOo.Oo00O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(717, 534)
			MyBase.Controls.Add(Me.oOo.Oo00O.())
			MyBase.Controls.Add(Me.oo0.0_oo0O00O0.())
			MyBase.Controls.Add(Me.o.o_o0o_0o.())
			MyBase.Controls.Add(Me.O.OOoOO.())
			MyBase.Controls.Add(Me.o_O___o_0.ooo_.())
			MyBase.Controls.Add(Me.O.o_0O0.())
			MyBase.Controls.Add(Me.O.__O.())
			MyBase.Controls.Add(Me.Oo._OO_.())
			MyBase.Controls.Add(Me.Oo_0O_0_.oO_.())
			MyBase.Controls.Add(Me.O_oO0O.o_oo.())
			MyBase.Controls.Add(Me.o__O.o00O0Oo.())
			MyBase.Controls.Add(Me.O00_o0.o_00_.())
			MyBase.Controls.Add(Me.oO0_O._o_O.())
			MyBase.Controls.Add(Me.Oo_0_.o.())
			MyBase.Controls.Add(Me.O.o_0O0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "DataTables"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "菜单编辑器"
			Me.ooOO0_OO.o000.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001172 RID: 4466 RVA: 0x0006CE81 File Offset: 0x0006B081
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.O0OO0OoOO0._.
		End Function

		' Token: 0x06001173 RID: 4467 RVA: 0x0006CE8C File Offset: 0x0006B08C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.o_O_00.0O0.
			Dim o0OO0OoOO0._. As TreeView = Me.O0OO0OoOO0._.
			If o0OO0OoOO0._. IsNot Nothing Then
				RemoveHandler o0OO0OoOO0._..AfterSelect, value
			End If
			Me.O0OO0OoOO0._. = A_0
			o0OO0OoOO0._. = Me.O0OO0OoOO0._.
			If o0OO0OoOO0._. IsNot Nothing Then
				AddHandler o0OO0OoOO0._..AfterSelect, value
			End If
		End Sub

		' Token: 0x06001174 RID: 4468 RVA: 0x0006CECF File Offset: 0x0006B0CF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_O_00.0O0.
		End Function

		' Token: 0x06001175 RID: 4469 RVA: 0x0006CED8 File Offset: 0x0006B0D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As MouseEventHandler = AddressOf Me.o0__O.Oo0__.
			Dim c1Button As C1Button = Me.o_O_00.0O0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.MouseDown, value
			End If
			Me.o_O_00.0O0. = A_0
			c1Button = Me.o_O_00.0O0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.MouseDown, value
			End If
		End Sub

		' Token: 0x06001176 RID: 4470 RVA: 0x0006CF1B File Offset: 0x0006B11B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.OoO0_.
		End Function

		' Token: 0x06001177 RID: 4471 RVA: 0x0006CF24 File Offset: 0x0006B124
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0Oo.0o_0O__.
			Dim o_.OoO0_. As C1Button = Me.O_.OoO0_.
			If o_.OoO0_. IsNot Nothing Then
				RemoveHandler o_.OoO0_..Click, value
			End If
			Me.O_.OoO0_. = A_0
			o_.OoO0_. = Me.O_.OoO0_.
			If o_.OoO0_. IsNot Nothing Then
				AddHandler o_.OoO0_..Click, value
			End If
		End Sub

		' Token: 0x06001178 RID: 4472 RVA: 0x0006CF67 File Offset: 0x0006B167
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_0.0.
		End Function

		' Token: 0x06001179 RID: 4473 RVA: 0x0006CF70 File Offset: 0x0006B170
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0ooOo_o.0o.
			Dim c1Button As C1Button = Me.o0_0.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_0.0. = A_0
			c1Button = Me.o0_0.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600117A RID: 4474 RVA: 0x0006CFB3 File Offset: 0x0006B1B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0oO0_O_o0.0.
		End Function

		' Token: 0x0600117B RID: 4475 RVA: 0x0006CFBC File Offset: 0x0006B1BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0_.Oo.
			Dim oo0oO0_O_o0.0. As C1Button = Me.Oo0oO0_O_o0.0.
			If oo0oO0_O_o0.0. IsNot Nothing Then
				RemoveHandler oo0oO0_O_o0.0..Click, value
			End If
			Me.Oo0oO0_O_o0.0. = A_0
			oo0oO0_O_o0.0. = Me.Oo0oO0_O_o0.0.
			If oo0oO0_O_o0.0. IsNot Nothing Then
				AddHandler oo0oO0_O_o0.0..Click, value
			End If
		End Sub

		' Token: 0x0600117C RID: 4476 RVA: 0x0006CFFF File Offset: 0x0006B1FF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oooO.o.
		End Function

		' Token: 0x0600117D RID: 4477 RVA: 0x0006D008 File Offset: 0x0006B208
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.o0_.
			Dim c1Button As C1Button = Me.oooO.o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oooO.o. = A_0
			c1Button = Me.oooO.o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600117E RID: 4478 RVA: 0x0006D04B File Offset: 0x0006B24B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00_oo0ooo._.
		End Function

		' Token: 0x0600117F RID: 4479 RVA: 0x0006D054 File Offset: 0x0006B254
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.__O0O_.
			Dim o00_oo0ooo._. As C1Button = Me.O00_oo0ooo._.
			If o00_oo0ooo._. IsNot Nothing Then
				RemoveHandler o00_oo0ooo._..Click, value
			End If
			Me.O00_oo0ooo._. = A_0
			o00_oo0ooo._. = Me.O00_oo0ooo._.
			If o00_oo0ooo._. IsNot Nothing Then
				AddHandler o00_oo0ooo._..Click, value
			End If
		End Sub

		' Token: 0x06001180 RID: 4480 RVA: 0x0006D097 File Offset: 0x0006B297
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.O.
		End Function

		' Token: 0x06001181 RID: 4481 RVA: 0x0006D0A0 File Offset: 0x0006B2A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo00.OO_oO_o_.
			Dim oo_.O. As C1Button = Me.Oo_.O.
			If oo_.O. IsNot Nothing Then
				RemoveHandler oo_.O..Click, value
			End If
			Me.Oo_.O. = A_0
			oo_.O. = Me.Oo_.O.
			If oo_.O. IsNot Nothing Then
				AddHandler oo_.O..Click, value
			End If
		End Sub

		' Token: 0x06001182 RID: 4482 RVA: 0x0006D0E3 File Offset: 0x0006B2E3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0._0O.
		End Function

		' Token: 0x06001183 RID: 4483 RVA: 0x0006D0EC File Offset: 0x0006B2EC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO_0O.__Oo0.
			Dim c1Button As C1Button = Me.o0._0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0._0O. = A_0
			c1Button = Me.o0._0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001184 RID: 4484 RVA: 0x0006D12F File Offset: 0x0006B32F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.O0OO0OoOO0._.
		End Function

		' Token: 0x06001185 RID: 4485 RVA: 0x0006D138 File Offset: 0x0006B338
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Dim value As PropertyValueChangedEventHandler = AddressOf Me.O0oOOo_00O.oO_.
			Dim o0OO0OoOO0._. As PropertyGrid = Me.O0OO0OoOO0._.
			If o0OO0OoOO0._. IsNot Nothing Then
				RemoveHandler o0OO0OoOO0._..PropertyValueChanged, value
			End If
			Me.O0OO0OoOO0._. = A_0
			o0OO0OoOO0._. = Me.O0OO0OoOO0._.
			If o0OO0OoOO0._. IsNot Nothing Then
				AddHandler o0OO0OoOO0._..PropertyValueChanged, value
			End If
		End Sub

		' Token: 0x06001186 RID: 4486 RVA: 0x0006D17B File Offset: 0x0006B37B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooOo_0.o.
		End Function

		' Token: 0x06001187 RID: 4487 RVA: 0x0006D184 File Offset: 0x0006B384
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_._OOo_oo_.
			Dim c1Button As C1Button = Me.ooOo_0.o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooOo_0.o. = A_0
			c1Button = Me.ooOo_0.o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001188 RID: 4488 RVA: 0x0006D1C7 File Offset: 0x0006B3C7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_._oO0___o.
		End Function

		' Token: 0x06001189 RID: 4489 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.O0__0.
			Dim o_._oO0___o. As C1Button = Me.O_._oO0___o.
			If o_._oO0___o. IsNot Nothing Then
				RemoveHandler o_._oO0___o..Click, value
			End If
			Me.O_._oO0___o. = A_0
			o_._oO0___o. = Me.O_._oO0___o.
			If o_._oO0___o. IsNot Nothing Then
				AddHandler o_._oO0___o..Click, value
			End If
		End Sub

		' Token: 0x0600118A RID: 4490 RVA: 0x0006D213 File Offset: 0x0006B413
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.O0OO0OoOO0._.
		End Function

		' Token: 0x0600118B RID: 4491 RVA: 0x0006D21B File Offset: 0x0006B41B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.O0OO0OoOO0._. = A_0
		End Sub

		' Token: 0x0600118C RID: 4492 RVA: 0x0006D224 File Offset: 0x0006B424
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O00_.oOo.
		End Function

		' Token: 0x0600118D RID: 4493 RVA: 0x0006D238 File Offset: 0x0006B438
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o0Oo._o.
				Dim o00_.oOo. As ToolStripMenuItem = Me.O00_.oOo.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							If o00_.oOo. IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 1
							If True Then
							End If
							If o00_.oOo. IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_62
						Case 2
							AddHandler o00_.oOo..Click, value
							num = 3
							Continue For
						Case 3
							Return
						Case 4
							RemoveHandler o00_.oOo..Click, value
							num = 5
							Continue For
						Case 5
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.O00_.oOo. = A_0
					o00_.oOo. = Me.O00_.oOo.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x0600118E RID: 4494 RVA: 0x0006D2E4 File Offset: 0x0006B4E4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o__0o._O.
		End Function

		' Token: 0x0600118F RID: 4495 RVA: 0x0006D2F8 File Offset: 0x0006B4F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oOOOO00.O.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o__0o._O.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							AddHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 1
							RemoveHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								If True Then
								End If
								num = 1
								Continue For
							End If
							GoTo IL_62
						Case 3
							Return
						Case 4
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 5
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.o__0o._O. = A_0
					toolStripMenuItem = Me.o__0o._O.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x06001190 RID: 4496 RVA: 0x0006D3A4 File Offset: 0x0006B5A4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o0o.O.
		End Function

		' Token: 0x06001191 RID: 4497 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o0_oo.O00oO.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o0o.O.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
						Case 1
							If toolStripMenuItem IsNot Nothing Then
								num = 5
								Continue For
							End If
							GoTo IL_5A
						Case 2
							Return
						Case 3
							AddHandler toolStripMenuItem.Click, value
							num = 2
							Continue For
						Case 4
							GoTo IL_5A
						Case 5
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 4
							Continue For
					End Select
					Exit For
					IL_5A:
					Me.o0o.O. = A_0
					toolStripMenuItem = Me.o0o.O.
					num = 0
				End While
			End While
		End Sub

		' Token: 0x06001192 RID: 4498 RVA: 0x0006D460 File Offset: 0x0006B660
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o0_0.00.
		End Function

		' Token: 0x06001193 RID: 4499 RVA: 0x0006D474 File Offset: 0x0006B674
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oO.oOOO_o_0.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o0_0.00.
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
					Me.o0_0.00. = A_0
					toolStripMenuItem = Me.o0_0.00.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x06001194 RID: 4500 RVA: 0x0006D51A File Offset: 0x0006B71A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.O000o_0.
		End Function

		' Token: 0x06001195 RID: 4501 RVA: 0x0006D524 File Offset: 0x0006B724
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo__.0O__.
			Dim c1Button As C1Button = Me.o_.O000o_0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_.O000o_0. = A_0
			c1Button = Me.o_.O000o_0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001196 RID: 4502 RVA: 0x0006D567 File Offset: 0x0006B767
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_0___.ooOoo.
		End Function

		' Token: 0x06001197 RID: 4503 RVA: 0x0006D570 File Offset: 0x0006B770
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.oOOoo0oooo.
			Dim c1Button As C1Button = Me.o0_0___.ooOoo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_0___.ooOoo. = A_0
			c1Button = Me.o0_0___.ooOoo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001198 RID: 4504 RVA: 0x0006D5B3 File Offset: 0x0006B7B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0OO_._.
		End Function

		' Token: 0x06001199 RID: 4505 RVA: 0x0006D5BC File Offset: 0x0006B7BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOOoOo._.
			Dim o0OO_._. As C1Button = Me.O0OO_._.
			If o0OO_._. IsNot Nothing Then
				RemoveHandler o0OO_._..Click, value
			End If
			Me.O0OO_._. = A_0
			o0OO_._. = Me.O0OO_._.
			If o0OO_._. IsNot Nothing Then
				AddHandler o0OO_._..Click, value
			End If
		End Sub

		' Token: 0x0600119A RID: 4506 RVA: 0x0006D600 File Offset: 0x0006B800
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PropertyValueChangedEventArgs)
			If Operators.CompareString(A_1.ChangedItem.Label, "名称", True) = 0 Then
				Me.O.o_0O0.().SelectedNode.Text = A_1.ChangedItem.Value.ToString()
				Me.O.o_0O0.().SelectedNode.Name = A_1.ChangedItem.Value.ToString()
			End If
			If Operators.CompareString(A_1.ChangedItem.Label, "类型", True) = 0 AndAlso TypeOf Me.O.o_0O0.().SelectedNode.Tag Is FormMenuItemProperty Then
				Dim formMenuItemProperty As FormMenuItemProperty = CType(Me.O.o_0O0.().SelectedNode.Tag, FormMenuItemProperty)
				If formMenuItemProperty.Type <> StripItemTypeEnum.Button AndAlso formMenuItemProperty.Type <> StripItemTypeEnum.SplitButton Then
					formMenuItemProperty.DisplayText = True
				End If
				Me.O.o_0O0.().SelectedObject = New o_0oooo_OO(RuntimeHelpers.GetObjectValue(Me.O.o_0O0.().SelectedNode.Tag), New String(-1) {}, False, False)
				Me.o_O_00.0O0.(Me.O.o_0O0.().SelectedNode, CType(Me.O.o_0O0.().SelectedNode.Tag, FormMenuItemProperty).Type)
			End If
			Me.O0OO0OoOO0._. = True
		End Sub

		' Token: 0x0600119B RID: 4507 RVA: 0x0006D72C File Offset: 0x0006B92C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.o_0O0.().SelectedNode IsNot Nothing Then
				Dim nodes As TreeNodeCollection
				If Me.O.o_0O0.().SelectedNode.Level = 0 Then
					nodes = Me.O.o_0O0.().SelectedNode.Nodes
				Else
					nodes = Me.O.o_0O0.().SelectedNode.Parent.Nodes
				End If
				Dim num As Integer = 1
				Dim text As String
				While True
					text = "项目" + num.ToString()
					If Not nodes.ContainsKey(text) Then
						Exit For
					End If
					num += 1
				End While
				Dim treeNode As TreeNode = New TreeNode()
				Dim formMenuItemProperty As FormMenuItemProperty = New FormMenuItemProperty()
				treeNode.Name = text
				treeNode.Text = text
				formMenuItemProperty.Text = text
				formMenuItemProperty.Name = text
				Dim stripTypeEnum As StripTypeEnum2 = StripTypeEnum2.主菜单
				If Me.O.o_0O0.().SelectedNode.Level = 0 Then
					stripTypeEnum = CType(Me.O.o_0O0.().SelectedNode.Tag, FormMenuProperty).Type
				ElseIf Me.O.o_0O0.().SelectedNode.Level = 1 Then
					stripTypeEnum = CType(Me.O.o_0O0.().SelectedNode.Parent.Tag, FormMenuProperty).Type
				End If
				Select Case stripTypeEnum
					Case StripTypeEnum2.主菜单, StripTypeEnum2.快捷菜单
						formMenuItemProperty.Type = StripItemTypeEnum.MenuItem
					Case StripTypeEnum2.工具栏
						If Me.O.o_0O0.().SelectedNode.Level <= 1 Then
							formMenuItemProperty.Type = StripItemTypeEnum.Button
						Else
							formMenuItemProperty.Type = StripItemTypeEnum.MenuItem
						End If
					Case StripTypeEnum2.状态栏
						If Me.O.o_0O0.().SelectedNode.Level <= 1 Then
							formMenuItemProperty.Type = StripItemTypeEnum.Label
						Else
							formMenuItemProperty.Type = StripItemTypeEnum.MenuItem
						End If
				End Select
				If Me.O.o_0O0.() = StripTypeEnum2.工具栏 Then
					If Me.O.o_0O0.().SelectedNode.Level <= 1 Then
						formMenuItemProperty.DisplayText = False
					Else
						formMenuItemProperty.DisplayText = True
					End If
				Else
					formMenuItemProperty.DisplayText = True
				End If
				treeNode.Tag = formMenuItemProperty
				nodes.Add(treeNode)
				treeNode.EnsureVisible()
				Me.O.o_0O0.().SelectedNode = treeNode
				Me.o_O_00.0O0.(treeNode, formMenuItemProperty.Type)
				Me.O0OO0OoOO0._. = True
			End If
		End Sub

		' Token: 0x0600119C RID: 4508 RVA: 0x0006D920 File Offset: 0x0006BB20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.o_0O0.().SelectedNode IsNot Nothing Then
				If TypeOf Me.O.o_0O0.().SelectedNode.Tag Is FormMenuItemProperty Then
					Dim formMenuItemProperty As FormMenuItemProperty = CType(Me.O.o_0O0.().SelectedNode.Tag, FormMenuItemProperty)
					If formMenuItemProperty.Type <> StripItemTypeEnum.MenuItem AndAlso formMenuItemProperty.Type <> StripItemTypeEnum.SplitButton Then
						Return
					End If
				End If
				Dim nodes As TreeNodeCollection = Me.O.o_0O0.().SelectedNode.Nodes
				Dim num As Integer = 1
				Dim text As String
				While True
					text = "项目" + num.ToString()
					If Not nodes.ContainsKey(text) Then
						Exit For
					End If
					num += 1
				End While
				Dim treeNode As TreeNode = New TreeNode()
				Dim formMenuItemProperty2 As FormMenuItemProperty = New FormMenuItemProperty()
				treeNode.Name = text
				treeNode.Text = text
				formMenuItemProperty2.Text = text
				formMenuItemProperty2.Name = text
				formMenuItemProperty2.Type = StripItemTypeEnum.MenuItem
				If Me.O.o_0O0.() = StripTypeEnum2.工具栏 Then
					If Me.O.o_0O0.().SelectedNode.Level = 0 Then
						formMenuItemProperty2.Type = StripItemTypeEnum.Button
						formMenuItemProperty2.DisplayText = False
					Else
						formMenuItemProperty2.DisplayText = True
					End If
				Else
					formMenuItemProperty2.DisplayText = True
				End If
				treeNode.Tag = formMenuItemProperty2
				nodes.Add(treeNode)
				treeNode.EnsureVisible()
				Me.O.o_0O0.().SelectedNode = treeNode
				Me.o_O_00.0O0.(treeNode, formMenuItemProperty2.Type)
				Me.O0OO0OoOO0._. = True
			End If
		End Sub

		' Token: 0x0600119D RID: 4509 RVA: 0x0006DA64 File Offset: 0x0006BC64
		Private Function <<EMPTY_NAME>>() As StripTypeEnum2
			Dim treeNode As TreeNode = Me.O.o_0O0.().SelectedNode
			While treeNode.Level <> 0
				treeNode = treeNode.Parent
			End While
			Return CType(treeNode.Tag, FormMenuProperty).Type
		End Function

		' Token: 0x0600119E RID: 4510 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.o_0O0.().SelectedNode IsNot Nothing Then
				Dim treeView As TreeView = Me.O.o_0O0.()
				If treeView.SelectedNode.Level = 0 Then
					treeView.Nodes.Remove(treeView.SelectedNode)
				Else
					treeView.SelectedNode.Parent.Nodes.Remove(treeView.SelectedNode)
				End If
				Me.O0OO0OoOO0._. = True
			End If
		End Sub

		' Token: 0x0600119F RID: 4511 RVA: 0x0006DB08 File Offset: 0x0006BD08
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.O.o_0O0.()
			If treeView.SelectedNode IsNot Nothing Then
				Dim selectedNode As TreeNode = treeView.SelectedNode
				Dim index As Integer = selectedNode.Index
				If index <> 0 Then
					Dim nodes As TreeNodeCollection
					If selectedNode.Parent Is Nothing Then
						nodes = treeView.Nodes
					Else
						nodes = selectedNode.Parent.Nodes
					End If
					nodes.Remove(selectedNode)
					nodes.Insert(index - 1, selectedNode)
					treeView.SelectedNode = selectedNode
					selectedNode.EnsureVisible()
					Me.O0OO0OoOO0._. = True
				End If
			End If
		End Sub

		' Token: 0x060011A0 RID: 4512 RVA: 0x0006DB7C File Offset: 0x0006BD7C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim treeView As TreeView = Me.O.o_0O0.()
			If treeView.SelectedNode IsNot Nothing Then
				Dim selectedNode As TreeNode = treeView.SelectedNode
				Dim index As Integer = selectedNode.Index
				Dim nodes As TreeNodeCollection
				If selectedNode.Parent Is Nothing Then
					nodes = treeView.Nodes
				Else
					nodes = selectedNode.Parent.Nodes
				End If
				If index <> nodes.Count - 1 Then
					nodes.Remove(selectedNode)
					nodes.Insert(index + 1, selectedNode)
					treeView.SelectedNode = selectedNode
					selectedNode.EnsureVisible()
					Me.O0OO0OoOO0._. = True
				End If
			End If
		End Sub

		' Token: 0x060011A1 RID: 4513 RVA: 0x0006DBF8 File Offset: 0x0006BDF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.o_0O0.().SelectedNode IsNot Nothing Then
				Dim selectedNode As TreeNode = Me.O.o_0O0.().SelectedNode
				If selectedNode.Level <> 0 AndAlso selectedNode.Level <> 1 Then
					Dim index As Integer = selectedNode.Parent.Index + 1
					Dim nodes As TreeNodeCollection = selectedNode.Parent.Parent.Nodes
					selectedNode.Parent.Nodes.Remove(selectedNode)
					nodes.Insert(index, selectedNode)
					selectedNode.TreeView.SelectedNode = selectedNode
					selectedNode.EnsureVisible()
					Me.O0OO0OoOO0._. = True
				End If
			End If
		End Sub

		' Token: 0x060011A2 RID: 4514 RVA: 0x0006DC80 File Offset: 0x0006BE80
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim selectedNode As TreeNode = Me.O.o_0O0.().SelectedNode
			If selectedNode IsNot Nothing AndAlso selectedNode.Level <> 0 AndAlso selectedNode.Index <> 0 Then
				If TypeOf selectedNode.PrevNode.Tag Is FormMenuItemProperty Then
					Dim formMenuItemProperty As FormMenuItemProperty = CType(selectedNode.PrevNode.Tag, FormMenuItemProperty)
					If formMenuItemProperty.Type <> StripItemTypeEnum.MenuItem AndAlso formMenuItemProperty.Type <> StripItemTypeEnum.SplitButton Then
						Return
					End If
				End If
				Dim nodes As TreeNodeCollection = selectedNode.PrevNode.Nodes
				If selectedNode.Parent IsNot Nothing Then
					selectedNode.Parent.Nodes.Remove(selectedNode)
				Else
					selectedNode.TreeView.Nodes.Remove(selectedNode)
				End If
				nodes.Add(selectedNode)
				selectedNode.TreeView.SelectedNode = selectedNode
				selectedNode.EnsureVisible()
				Me.O0OO0OoOO0._. = True
			End If
		End Sub

		' Token: 0x060011A3 RID: 4515 RVA: 0x0006DD44 File Offset: 0x0006BF44
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If Me.O.o_0O0.().SelectedNode Is Nothing Then
				Me.O.o_0O0.().SelectedObject = Nothing
				Return
			End If
			Me.O.o_0O0.().SelectedObject = New o_0oooo_OO(RuntimeHelpers.GetObjectValue(Me.O.o_0O0.().SelectedNode.Tag), New String(-1) {}, False, False)
		End Sub

		' Token: 0x060011A4 RID: 4516 RVA: 0x0006DD98 File Offset: 0x0006BF98
		Private Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, ByRef A_1 As String)
			Try
				For Each obj As Object In A_0
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(treeNode.Tag)
					If Operators.CompareString(A_1, "", True) <> 0 Then
						A_1 += vbFormFeed
					End If
					If treeNode.Level = 0 Then
						A_1 += vbTab
					End If
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(objectValue), False, vbTab, False).Replace(vbFormFeed, "")
					If treeNode.Nodes.Count > 0 Then
						A_1 += vbFormFeed & "Inner"
						Me.O.o_0O0.(treeNode.Nodes, A_1)
						A_1 += vbFormFeed & "Outer"
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060011A5 RID: 4517 RVA: 0x0006DE8C File Offset: 0x0006C08C
		Friend Function <<EMPTY_NAME>>() As String
			Dim result As String = ""
			Me.O.o_0O0.(Me.O.o_0O0.().Nodes, result)
			Return result
		End Function

		' Token: 0x060011A6 RID: 4518 RVA: 0x0006DEB4 File Offset: 0x0006C0B4
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim array As String() = A_0.Split(New Char() { vbFormFeed })
			Dim nodes As TreeNodeCollection = Me.O.o_0O0.().Nodes
			Dim treeNode As TreeNode = Nothing
			Me.O.o_0O0.().BeginUpdate()
			For Each text As String In array
				If Operators.CompareString(text, "Inner", True) = 0 Then
					nodes = treeNode.Nodes
				ElseIf Operators.CompareString(text, "Outer", True) = 0 Then
					If nodes(0).Parent.Parent Is Nothing Then
						nodes = Me.O.o_0O0.().Nodes
					Else
						nodes = nodes(0).Parent.Parent.Nodes
					End If
				Else
					text = text.Trim(New Char() { vbTab })
					treeNode = New TreeNode()
					nodes.Add(treeNode)
					If treeNode.Level = 0 Then
						Dim formMenuProperty As FormMenuProperty = New FormMenuProperty()
						o_O_o_oOoo__.OOOO_OO._oo.(formMenuProperty, text, vbTab)
						treeNode.Text = formMenuProperty.Name
						treeNode.Name = formMenuProperty.Name
						treeNode.Tag = formMenuProperty
						Me.o_O_00.0O0.(treeNode, formMenuProperty.Type)
					Else
						Dim formMenuItemProperty As FormMenuItemProperty = New FormMenuItemProperty()
						o_O_o_oOoo__.OOOO_OO._oo.(formMenuItemProperty, text, vbTab)
						treeNode.Text = formMenuItemProperty.Name
						treeNode.Name = formMenuItemProperty.Name
						treeNode.Tag = formMenuItemProperty
						Me.o_O_00.0O0.(treeNode, formMenuItemProperty.Type)
					End If
				End If
			Next
			Me.O.o_0O0.().EndUpdate()
		End Sub

		' Token: 0x060011A7 RID: 4519 RVA: 0x0006E028 File Offset: 0x0006C228
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0OO0OoOO0._. Then
				If MessageBox.Show("确定要放弃修改吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					Me.O0OO0OoOO0._. = False
					MyBase.DialogResult = DialogResult.Cancel
					Return
				End If
			Else
				MyBase.DialogResult = DialogResult.Cancel
			End If
		End Sub

		' Token: 0x060011A8 RID: 4520 RVA: 0x0006E05D File Offset: 0x0006C25D
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.ooOO0_OO.o000.().Show(Me.Oo_0_.o.(), 0, Me.Oo_0_.o.().Height)
		End Sub

		' Token: 0x060011A9 RID: 4521 RVA: 0x0006E07C File Offset: 0x0006C27C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0__O.Oo0__.(StripTypeEnum2.快捷菜单)
		End Sub

		' Token: 0x060011AA RID: 4522 RVA: 0x0006E088 File Offset: 0x0006C288
		Private Sub <<EMPTY_NAME>>(A_0 As StripTypeEnum2)
			Dim name As String = [Enum].GetName(GetType(StripTypeEnum2), A_0)
			Dim text As String = ""
			If A_0 = StripTypeEnum2.主菜单 OrElse A_0 = StripTypeEnum2.状态栏 Then
				text = name
				Try
					Dim enumerator As IEnumerator = Me.O.o_0O0.().Nodes.GetEnumerator()
					While enumerator.MoveNext()
						If CType(CType(enumerator.Current, TreeNode).Tag, FormMenuProperty).Type = A_0 Then
							MessageBox.Show("一个窗口只能有一个" + name + "!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Return
						End If
					End While
					GoTo IL_C7
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Dim num As Integer = 1
			While True
				text = name + num.ToString()
				If Not Me.O.o_0O0.().Nodes.ContainsKey(text) Then
					Exit For
				End If
				num += 1
			End While
			IL_C7:
			Dim treeNode As TreeNode = New TreeNode()
			Dim formMenuProperty As FormMenuProperty = New FormMenuProperty()
			formMenuProperty.Name = text
			formMenuProperty.Type = A_0
			treeNode.Name = text
			treeNode.Text = text
			treeNode.Tag = formMenuProperty
			Me.O.o_0O0.().Nodes.Add(treeNode)
			treeNode.EnsureVisible()
			Me.O.o_0O0.().SelectedNode = treeNode
			Me.o_O_00.0O0.(treeNode, A_0)
			Me.O0OO0OoOO0._. = True
		End Sub

		' Token: 0x060011AB RID: 4523 RVA: 0x0006E1D0 File Offset: 0x0006C3D0
		Private Sub <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As StripTypeEnum2)
			Select Case A_1
				Case StripTypeEnum2.主菜单
					A_0.ImageKey = "MainMenu"
				Case StripTypeEnum2.工具栏
					A_0.ImageKey = "ToolBar"
				Case StripTypeEnum2.状态栏
					A_0.ImageKey = "StatusBar"
				Case StripTypeEnum2.快捷菜单
					A_0.ImageKey = "ContentMenu"
			End Select
			A_0.SelectedImageKey = A_0.ImageKey
		End Sub

		' Token: 0x060011AC RID: 4524 RVA: 0x0006E235 File Offset: 0x0006C435
		Private Sub <<EMPTY_NAME>>(A_0 As TreeNode, A_1 As StripItemTypeEnum)
			A_0.ImageKey = [Enum].GetName(GetType(StripItemTypeEnum), A_1)
			A_0.SelectedImageKey = A_0.ImageKey
		End Sub

		' Token: 0x060011AD RID: 4525 RVA: 0x0006E25E File Offset: 0x0006C45E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0__O.Oo0__.(StripTypeEnum2.主菜单)
		End Sub

		' Token: 0x060011AE RID: 4526 RVA: 0x0006E267 File Offset: 0x0006C467
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0__O.Oo0__.(StripTypeEnum2.工具栏)
		End Sub

		' Token: 0x060011AF RID: 4527 RVA: 0x0006E270 File Offset: 0x0006C470
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0__O.Oo0__.(StripTypeEnum2.状态栏)
		End Sub

		' Token: 0x060011B0 RID: 4528 RVA: 0x0006E279 File Offset: 0x0006C479
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0OO0OoOO0._. = False
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x060011B1 RID: 4529 RVA: 0x0006E28C File Offset: 0x0006C48C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If Me.O0OO0OoOO0._. Then
				Dim dialogResult As DialogResult = MessageBox.Show("是否保存修改?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If dialogResult = DialogResult.Yes Then
					MyBase.DialogResult = DialogResult.OK
					Return
				End If
				If dialogResult = DialogResult.No Then
					MyBase.DialogResult = DialogResult.Cancel
					Return
				End If
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060011B2 RID: 4530 RVA: 0x0006E2D8 File Offset: 0x0006C4D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.o_0O0.().Nodes.Count > 0 Then
				Dim text As String = Me.O0oOOo_00O.oO_.()
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
				saveFileDialog.Filter = "窗口菜单文件(*.Strip)|*.Strip"
				If saveFileDialog.ShowDialog() = DialogResult.OK Then
					OO_00oOO.FileSys.WriteAllText(saveFileDialog.FileName, text, False, Encoding.[Default])
				End If
			End If
		End Sub

		' Token: 0x060011B3 RID: 4531 RVA: 0x0006E330 File Offset: 0x0006C530
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			openFileDialog.Filter = "窗口菜单文件(*.Strip)|*.Strip"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.O0OO0OoOO0._. = True
				Me.O.o_0O0.().Nodes.Clear()
				Dim a_ As String = OO_00oOO.FileSys.ReadAllText(openFileDialog.FileName, Encoding.[Default])
				Me.O.o_0O0.(a_)
			End If
		End Sub

		' Token: 0x060011B4 RID: 4532 RVA: 0x0006E38C File Offset: 0x0006C58C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Oo_0O_0_.oO_.
			AddHandler MyBase.FormClosed, AddressOf Me.Oo_0O_0_.oO_.
			Me.O0OO0OoOO0._. = "(default)"
			Me.O.o_0O0.()
			Me.O.o_0O0.().ImageList = O_O0OO.OoO.0OO__0ooo.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060011B5 RID: 4533 RVA: 0x0006E3F9 File Offset: 0x0006C5F9
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u As o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 = New o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000()
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.o_Ooo._. = Me.O0OO0OoOO0._.
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.o_Ooo._.(Me.O0oOOo_00O.oO_.())
			o_u3002_u3002_u3000_u3000_u3000_u3002_u3000_u3000_u.ShowDialog()
		End Sub

		' Token: 0x060011B6 RID: 4534 RVA: 0x0006E41E File Offset: 0x0006C61E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040006B2 RID: 1714
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040006B3 RID: 1715
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x040006B4 RID: 1716
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006B5 RID: 1717
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006B6 RID: 1718
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006B7 RID: 1719
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006B8 RID: 1720
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006B9 RID: 1721
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006BA RID: 1722
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006BB RID: 1723
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006BC RID: 1724
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x040006BD RID: 1725
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006BE RID: 1726
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006BF RID: 1727
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x040006C0 RID: 1728
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040006C1 RID: 1729
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040006C2 RID: 1730
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040006C3 RID: 1731
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x040006C4 RID: 1732
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006C5 RID: 1733
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006C6 RID: 1734
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040006C7 RID: 1735
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040006C8 RID: 1736
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
