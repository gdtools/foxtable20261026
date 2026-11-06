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
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000365 RID: 869
	<DesignerGenerated()>
	Friend Partial Class du
		Inherits Form

		' Token: 0x0600367A RID: 13946 RVA: 0x00170C24 File Offset: 0x0016EE24
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_Oo_._0O_O. IsNot Nothing Then
					Me.O_Oo_._0O_O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600367B RID: 13947 RVA: 0x00170C64 File Offset: 0x0016EE64
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(du))
			Me.oOO_oo.O_O.(New C1FlexGrid())
			Me.OO.O00O_.(New C1Button())
			Me.O._O0O.(New C1Button())
			Me.O0o.Ooo_oOO.(New C1CheckBox())
			Me.o_O.oOO.(New C1CheckBox())
			Me.O_.oooo_.(New C1Button())
			Me.o0_Oooo.o_o.(New C1Button())
			Me.OoO_o.o.(New C1Button())
			Me.OO_O0.oO00.(New C1Button())
			Me.ooOo0O0o.O0_OO.(New C1Button())
			Me.O0o.Ooo_oOO.(New C1Button())
			Me.ooo0.oO_o0___.(New C1Button())
			Me.OOo0O00._o.(New C1Button())
			Me.ooo_.O.(New C1Button())
			Me.oOO_oo.O_O.(New C1CheckBox())
			Me.Ooo_o_._o0_O.().BeginInit()
			MyBase.SuspendLayout()
			Me.Ooo_o_._o0_O.().AllowDragging = 0
			Me.Ooo_o_._o0_O.().BorderStyle = 1
			Me.Ooo_o_._o0_O.().ColumnInfo = componentResourceManager.GetString("SubtotalGrid.ColumnInfo")
			Me.Ooo_o_._o0_O.().ExtendLastCol = True
			Me.Ooo_o_._o0_O.().Location = New Point(12, 12)
			Me.Ooo_o_._o0_O.().Name = "SubtotalGrid"
			Me.Ooo_o_._o0_O.().Rows.Count = 1
			Me.Ooo_o_._o0_O.().Rows.DefaultSize = 21
			Me.Ooo_o_._o0_O.().SelectionMode = 1
			Me.Ooo_o_._o0_O.().Size = New Size(712, 286)
			Me.Ooo_o_._o0_O.().StyleInfo = componentResourceManager.GetString("SubtotalGrid.StyleInfo")
			Me.Ooo_o_._o0_O.().TabIndex = 0
			Me.O_O.O0_O_.().Location = New Point(568, 388)
			Me.O_O.O0_O_.().Name = "btnOk"
			Me.O_O.O0_O_.().Size = New Size(75, 23)
			Me.O_O.O0_O_.().TabIndex = 10
			Me.O_O.O0_O_.().Text = "确定"
			Me.O_O.O0_O_.().UseVisualStyleBackColor = True
			Me.O_O._0.().Location = New Point(649, 388)
			Me.O_O._0.().Name = "btnCancel"
			Me.O_O._0.().Size = New Size(75, 23)
			Me.O_O._0.().TabIndex = 11
			Me.O_O._0.().Text = "取消"
			Me.O_O._0.().UseVisualStyleBackColor = True
			Me.O0_oo0OoO_o.o.().AutoSize = True
			Me.O0_oo0OoO_o.o.().CheckAlign = ContentAlignment.MiddleRight
			Me.O0_oo0OoO_o.o.().Location = New Point(639, 333)
			Me.O0_oo0OoO_o.o.().Name = "TreeVisible"
			Me.O0_oo0OoO_o.o.().Size = New Size(84, 16)
			Me.O0_oo0OoO_o.o.().TabIndex = 7
			Me.O0_oo0OoO_o.o.().Text = "显示目录树"
			Me.O0_oo0OoO_o.o.().UseVisualStyleBackColor = True
			Me.o__.O0.().AutoSize = True
			Me.o__.O0.().CheckAlign = ContentAlignment.MiddleRight
			Me.o__.O0.().Location = New Point(579, 311)
			Me.o__.O0.().Name = "GroupAbove"
			Me.o__.O0.().Size = New Size(144, 16)
			Me.o__.O0.().TabIndex = 6
			Me.o__.O0.().Text = "分组行位于数据行之上"
			Me.o__.O0.().UseVisualStyleBackColor = True
			Me.o_0O.o_000_0.().Location = New Point(174, 388)
			Me.o_0O.o_000_0.().Name = "btnViewCode"
			Me.o_0O.o_000_0.().Size = New Size(75, 23)
			Me.o_0O.o_000_0.().TabIndex = 8
			Me.o_0O.o_000_0.().Text = "查看代码"
			Me.o_0O.o_000_0.().UseVisualStyleBackColor = True
			Me.o0o__.0_O___.().Location = New Point(174, 311)
			Me.o0o__.0_O___.().Name = "Button4"
			Me.o0o__.0_O___.().Size = New Size(75, 23)
			Me.o0o__.0_O___.().TabIndex = 3
			Me.o0o__.0_O___.().Text = "删除分组"
			Me.o0o__.0_O___.().UseVisualStyleBackColor = True
			Me.oo0______0_.o.().Location = New Point(12, 311)
			Me.oo0______0_.o.().Name = "Button5"
			Me.oo0______0_.o.().Size = New Size(75, 23)
			Me.oo0______0_.o.().TabIndex = 1
			Me.oo0______0_.o.().Text = "增加分组"
			Me.oo0______0_.o.().UseVisualStyleBackColor = True
			Me.oo__o0.0.().Location = New Point(93, 311)
			Me.oo__o0.0.().Name = "Button6"
			Me.oo__o0.0.().Size = New Size(75, 23)
			Me.oo__o0.0.().TabIndex = 2
			Me.oo__o0.0.().Text = "插入分组"
			Me.oo__o0.0.().UseVisualStyleBackColor = True
			Me.o_oo_0OOO0.O0_.().Location = New Point(256, 311)
			Me.o_oo_0OOO0.O0_.().Name = "Button7"
			Me.o_oo_0OOO0.O0_.().Size = New Size(75, 23)
			Me.o_oo_0OOO0.O0_.().TabIndex = 4
			Me.o_oo_0OOO0.O0_.().Text = "上移"
			Me.o_oo_0OOO0.O0_.().UseVisualStyleBackColor = True
			Me.oO0Oo.oO.().Location = New Point(337, 311)
			Me.oO0Oo.oO.().Name = "Button8"
			Me.oO0Oo.oO.().Size = New Size(75, 23)
			Me.oO0Oo.oO.().TabIndex = 5
			Me.oO0Oo.oO.().Text = "下移"
			Me.oO0Oo.oO.().UseVisualStyleBackColor = True
			Me.OO00____o.0.().Location = New Point(487, 388)
			Me.OO00____o.0.().Name = "btnApply"
			Me.OO00____o.0.().Size = New Size(75, 23)
			Me.OO00____o.0.().TabIndex = 9
			Me.OO00____o.0.().Text = "应用"
			Me.OO00____o.0.().UseVisualStyleBackColor = True
			Me.o__.o0_oo0.().Location = New Point(12, 388)
			Me.o__.o0_oo0.().Name = "btnSave"
			Me.o__.o0_oo0.().Size = New Size(75, 23)
			Me.o__.o0_oo0.().TabIndex = 12
			Me.o__.o0_oo0.().Text = "保存设置"
			Me.o__.o0_oo0.().UseVisualStyleBackColor = True
			Me.o0.0o00_oO_O__.().Location = New Point(93, 388)
			Me.o0.0o00_oO_O__.().Name = "btnList"
			Me.o0.0o00_oO_O__.().Size = New Size(75, 23)
			Me.o0.0o00_oO_O__.().TabIndex = 13
			Me.o0.0o00_oO_O__.().Text = "设置管理"
			Me.o0.0o00_oO_O__.().UseVisualStyleBackColor = True
			Me.Ooo_o_._o0_O.().AutoSize = True
			Me.Ooo_o_._o0_O.().CheckAlign = ContentAlignment.MiddleRight
			Me.Ooo_o_._o0_O.().Location = New Point(639, 356)
			Me.Ooo_o_._o0_O.().Name = "chkSpill"
			Me.Ooo_o_._o0_O.().Size = New Size(84, 16)
			Me.Ooo_o_._o0_O.().TabIndex = 14
			Me.Ooo_o_._o0_O.().Text = "合并单元格"
			Me.Ooo_o_._o0_O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(735, 423)
			MyBase.Controls.Add(Me.Ooo_o_._o0_O.())
			MyBase.Controls.Add(Me.o__.o0_oo0.())
			MyBase.Controls.Add(Me.o0.0o00_oO_O__.())
			MyBase.Controls.Add(Me.OO00____o.0.())
			MyBase.Controls.Add(Me.oO0Oo.oO.())
			MyBase.Controls.Add(Me.o_oo_0OOO0.O0_.())
			MyBase.Controls.Add(Me.oo__o0.0.())
			MyBase.Controls.Add(Me.oo0______0_.o.())
			MyBase.Controls.Add(Me.o0o__.0_O___.())
			MyBase.Controls.Add(Me.o_0O.o_000_0.())
			MyBase.Controls.Add(Me.Ooo_o_._o0_O.())
			MyBase.Controls.Add(Me.o__.O0.())
			MyBase.Controls.Add(Me.O0_oo0OoO_o.o.())
			MyBase.Controls.Add(Me.O_O._0.())
			MyBase.Controls.Add(Me.O_O.O0_O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.00.O.."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置汇总模式"
			Me.Ooo_o_._o0_O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600367C RID: 13948 RVA: 0x0017155D File Offset: 0x0016F75D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_Oo_._0O_O.
		End Function

		' Token: 0x0600367D RID: 13949 RVA: 0x00171568 File Offset: 0x0016F768
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.O0o.Ooo_oOO.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.o_O.oOO.
			Dim rowColEventHandler3 As RowColEventHandler = AddressOf Me.oOO_oo.O_O.
			Dim o_Oo_._0O_O. As C1FlexGrid = Me.O_Oo_._0O_O.
			If o_Oo_._0O_O. IsNot Nothing Then
				o_Oo_._0O_O..AfterEdit -= rowColEventHandler
				o_Oo_._0O_O..BeforeEdit -= rowColEventHandler2
				o_Oo_._0O_O..CellButtonClick -= rowColEventHandler3
			End If
			Me.O_Oo_._0O_O. = A_0
			o_Oo_._0O_O. = Me.O_Oo_._0O_O.
			If o_Oo_._0O_O. IsNot Nothing Then
				o_Oo_._0O_O..AfterEdit += rowColEventHandler
				o_Oo_._0O_O..BeforeEdit += rowColEventHandler2
				o_Oo_._0O_O..CellButtonClick += rowColEventHandler3
			End If
		End Sub

		' Token: 0x0600367E RID: 13950 RVA: 0x001715E1 File Offset: 0x0016F7E1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO___O.0.
		End Function

		' Token: 0x0600367F RID: 13951 RVA: 0x001715EC File Offset: 0x0016F7EC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOOO.o.
			Dim oo___O.0. As C1Button = Me.OO___O.0.
			If oo___O.0. IsNot Nothing Then
				RemoveHandler oo___O.0..Click, value
			End If
			Me.OO___O.0. = A_0
			oo___O.0. = Me.OO___O.0.
			If oo___O.0. IsNot Nothing Then
				AddHandler oo___O.0..Click, value
			End If
		End Sub

		' Token: 0x06003680 RID: 13952 RVA: 0x0017162F File Offset: 0x0016F82F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO0O0.___oo.
		End Function

		' Token: 0x06003681 RID: 13953 RVA: 0x00171638 File Offset: 0x0016F838
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0___0.
			Dim oo0O0.___oo. As C1Button = Me.OO0O0.___oo.
			If oo0O0.___oo. IsNot Nothing Then
				RemoveHandler oo0O0.___oo..Click, value
			End If
			Me.OO0O0.___oo. = A_0
			oo0O0.___oo. = Me.OO0O0.___oo.
			If oo0O0.___oo. IsNot Nothing Then
				AddHandler oo0O0.___oo..Click, value
			End If
		End Sub

		' Token: 0x06003682 RID: 13954 RVA: 0x0017167B File Offset: 0x0016F87B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_Oo_._0O_O.
		End Function

		' Token: 0x06003683 RID: 13955 RVA: 0x00171683 File Offset: 0x0016F883
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O_Oo_._0O_O. = A_0
		End Sub

		' Token: 0x06003684 RID: 13956 RVA: 0x0017168C File Offset: 0x0016F88C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oo0_.O0oO_.
		End Function

		' Token: 0x06003685 RID: 13957 RVA: 0x00171694 File Offset: 0x0016F894
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oo0_.O0oO_. = A_0
		End Sub

		' Token: 0x06003686 RID: 13958 RVA: 0x0017169D File Offset: 0x0016F89D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.oO_OOO00.
		End Function

		' Token: 0x06003687 RID: 13959 RVA: 0x001716A8 File Offset: 0x0016F8A8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0_.OO.
			Dim c1Button As C1Button = Me.o.oO_OOO00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.oO_OOO00. = A_0
			c1Button = Me.o.oO_OOO00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003688 RID: 13960 RVA: 0x001716EB File Offset: 0x0016F8EB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.0_oOO.
		End Function

		' Token: 0x06003689 RID: 13961 RVA: 0x001716F4 File Offset: 0x0016F8F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo0_0o._O.
			Dim o.0_oOO. As C1Button = Me.O.0_oOO.
			If o.0_oOO. IsNot Nothing Then
				RemoveHandler o.0_oOO..Click, value
			End If
			Me.O.0_oOO. = A_0
			o.0_oOO. = Me.O.0_oOO.
			If o.0_oOO. IsNot Nothing Then
				AddHandler o.0_oOO..Click, value
			End If
		End Sub

		' Token: 0x0600368A RID: 13962 RVA: 0x00171737 File Offset: 0x0016F937
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOo_OO.O_00.
		End Function

		' Token: 0x0600368B RID: 13963 RVA: 0x00171740 File Offset: 0x0016F940
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO_Oo0.OO_OOo0.
			Dim ooo_OO.O_00. As C1Button = Me.OOo_OO.O_00.
			If ooo_OO.O_00. IsNot Nothing Then
				RemoveHandler ooo_OO.O_00..Click, value
			End If
			Me.OOo_OO.O_00. = A_0
			ooo_OO.O_00. = Me.OOo_OO.O_00.
			If ooo_OO.O_00. IsNot Nothing Then
				AddHandler ooo_OO.O_00..Click, value
			End If
		End Sub

		' Token: 0x0600368C RID: 13964 RVA: 0x00171783 File Offset: 0x0016F983
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.O00OOO.
		End Function

		' Token: 0x0600368D RID: 13965 RVA: 0x0017178C File Offset: 0x0016F98C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO0OO_.o00_0_.
			Dim o0.O00OOO. As C1Button = Me.O0.O00OOO.
			If o0.O00OOO. IsNot Nothing Then
				RemoveHandler o0.O00OOO..Click, value
			End If
			Me.O0.O00OOO. = A_0
			o0.O00OOO. = Me.O0.O00OOO.
			If o0.O00OOO. IsNot Nothing Then
				AddHandler o0.O00OOO..Click, value
			End If
		End Sub

		' Token: 0x0600368E RID: 13966 RVA: 0x001717CF File Offset: 0x0016F9CF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_.oo_oO.
		End Function

		' Token: 0x0600368F RID: 13967 RVA: 0x001717D8 File Offset: 0x0016F9D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o__.O0oOOo00O.
			Dim c1Button As C1Button = Me.oo_.oo_oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_.oo_oO. = A_0
			c1Button = Me.oo_.oo_oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003690 RID: 13968 RVA: 0x0017181B File Offset: 0x0016FA1B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoO.0.
		End Function

		' Token: 0x06003691 RID: 13969 RVA: 0x00171824 File Offset: 0x0016FA24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.0O_o0o_OOOo.
			Dim oooO.0. As C1Button = Me.OOoO.0.
			If oooO.0. IsNot Nothing Then
				RemoveHandler oooO.0..Click, value
			End If
			Me.OOoO.0. = A_0
			oooO.0. = Me.OOoO.0.
			If oooO.0. IsNot Nothing Then
				AddHandler oooO.0..Click, value
			End If
		End Sub

		' Token: 0x06003692 RID: 13970 RVA: 0x00171867 File Offset: 0x0016FA67
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O.O0O_0O_.
		End Function

		' Token: 0x06003693 RID: 13971 RVA: 0x00171870 File Offset: 0x0016FA70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo.O_O__o0o.
			Dim c1Button As C1Button = Me.o0O.O0O_0O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O.O0O_0O_. = A_0
			c1Button = Me.o0O.O0O_0O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003694 RID: 13972 RVA: 0x001718B3 File Offset: 0x0016FAB3
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__O0000_O._.
		End Function

		' Token: 0x06003695 RID: 13973 RVA: 0x001718BC File Offset: 0x0016FABC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO.o___O.
			Dim o__O0000_O._. As C1Button = Me.O__O0000_O._.
			If o__O0000_O._. IsNot Nothing Then
				RemoveHandler o__O0000_O._..Click, value
			End If
			Me.O__O0000_O._. = A_0
			o__O0000_O._. = Me.O__O0000_O._.
			If o__O0000_O._. IsNot Nothing Then
				AddHandler o__O0000_O._..Click, value
			End If
		End Sub

		' Token: 0x06003696 RID: 13974 RVA: 0x001718FF File Offset: 0x0016FAFF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.o0o_o.
		End Function

		' Token: 0x06003697 RID: 13975 RVA: 0x00171908 File Offset: 0x0016FB08
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00O0O._.
			Dim c1Button As C1Button = Me.o0.o0o_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0.o0o_o. = A_0
			c1Button = Me.o0.o0o_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003698 RID: 13976 RVA: 0x0017194B File Offset: 0x0016FB4B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O.000O.
		End Function

		' Token: 0x06003699 RID: 13977 RVA: 0x00171953 File Offset: 0x0016FB53
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O.000O. = A_0
		End Sub

		' Token: 0x0600369A RID: 13978 RVA: 0x0017195C File Offset: 0x0016FB5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600369B RID: 13979 RVA: 0x00171964 File Offset: 0x0016FB64
		Public Sub New(A_0 As Table, A_1 As Boolean)
			AddHandler MyBase.FormClosed, AddressOf Me.o__.o0_oo0.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.o__.O0.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				num = 3
				Me.Ooo_o_._o0_O.().Styles.SelectedColumnHeader.Clear()
				IL_4E:
				num = 4
				Me.Ooo_o_._o0_O.().SelectionMode = 3
				IL_5C:
				num = 5
				Me.Ooo_o_._o0_O.().Styles.Focus.Clear()
				IL_73:
				num = 6
				Me.Ooo_o_._o0_O.().Styles.Focus.MergeWith(Me.Ooo_o_._o0_O.().Styles.Normal)
				IL_9A:
				num = 7
				Me.Ooo_o_._o0_O.().FocusRect = 3
				IL_A8:
				num = 8
				Me.Ooo_o_._o0_O.().AllowDelete = True
				IL_B6:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_BD:
				num = 10
				Me.O_Oo_._0O_O. = A_0
				IL_C7:
				num = 11
				Dim listDictionary As ListDictionary = New ListDictionary()
				IL_D0:
				num = 12
				Dim listDictionary2 As ListDictionary = New ListDictionary()
				IL_DA:
				num = 13
				Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_E4:
				num = 14
				listDictionary.Add(2, "累计值")
				IL_F8:
				num = 15
				listDictionary.Add(6, "平均值")
				IL_10C:
				num = 16
				listDictionary.Add(4, "记录数")
				IL_120:
				num = 17
				listDictionary.Add(7, "最大值")
				IL_134:
				num = 18
				listDictionary.Add(8, "最小值")
				IL_148:
				num = 19
				listDictionary.Add(3, "百分比")
				IL_15C:
				num = 20
				listDictionary.Add(9, "标准偏差")
				IL_171:
				num = 21
				listDictionary.Add(11, "总体标准差")
				IL_186:
				num = 22
				listDictionary.Add(10, "采样方差")
				IL_19B:
				num = 23
				listDictionary.Add(12, "总体方差")
				IL_1B0:
				num = 24
				listDictionary2.Add(3, "月")
				IL_1C5:
				num = 25
				listDictionary2.Add(2, "季")
				IL_1DA:
				num = 26
				listDictionary2.Add(1, "年")
				IL_1EF:
				num = 27
				listDictionary2.Add(4, "周")
				IL_204:
				num = 28
				listDictionary2.Add(5, "日")
				IL_219:
				num = 29
				listDictionary2.Add(6, "时")
				IL_22E:
				num = 30
				listDictionary2.Add(7, "分")
				IL_243:
				num = 31
				listDictionary2.Add(8, "秒")
				IL_258:
				num = 32
				listDictionary2.Add(0, "无")
				IL_26D:
				num = 33
				Dim enumerator As IEnumerator(Of Col) = A_0.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_288:
					num = 34
					dictionary.Add(col.Name, col.Caption)
					IL_2A0:
					num = 35
				End While
				IL_2AC:
				num = 36
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_2BA:
				num = 37
				dictionary.Add("*", "-总计-")
				IL_2CE:
				num = 38
				Me.Ooo_o_._o0_O.().Cols("Aggregate").DataMap = listDictionary
				IL_2EC:
				num = 39
				Me.Ooo_o_._o0_O.().Cols("DateGroup").DataMap = listDictionary2
				IL_30B:
				num = 40
				Me.Ooo_o_._o0_O.().Cols("GroupOn").DataMap = dictionary
				IL_32A:
				num = 41
				Me.Ooo_o_._o0_O.().Cols("TotalOn").ComboList = "..."
				IL_34C:
				num = 42
				Me.Ooo_o_._o0_O.().CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap()
				IL_364:
				num = 43
				If A_0.SubtotalGroups.Count <> 0 AndAlso Not A_1 Then
					GoTo IL_385
				End If
				IL_377:
				num = 44
				Me.oOO.o.()
				GoTo IL_5A6
				IL_385:
				num = 46
				Dim num3 As Integer = A_0.SubtotalGroups.Count - 1
				For i As Integer = 0 To num3
					IL_39F:
					num = 47
					Me.Ooo_o_._o0_O.().AddItem("")
					IL_3B3:
					num = 48
					Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "GroupOn") = A_0.SubtotalGroups(i).GroupOn
					IL_3EB:
					num = 49
					Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "TotalOn") = A_0.SubtotalGroups(i).TotalOn
					IL_423:
					num = 50
					Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "Aggregate") = A_0.SubtotalGroups(i).Aggregate
					IL_460:
					num = 51
					Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "Caption") = A_0.SubtotalGroups(i).Caption
					IL_498:
					num = 52
					Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "upto") = A_0.SubtotalGroups(i).upto
					IL_4D5:
					num = 53
					If Operators.CompareString(A_0.SubtotalGroups(i).GroupOn, "", True) > 0 AndAlso A_0.foxGrid.Cols.Contains(A_0.SubtotalGroups(i).GroupOn) AndAlso A_0.View.o_o.O0ooOo.().Columns(A_0.SubtotalGroups(i).GroupOn).DataType Is GetType(DateTime) Then
						IL_557:
						num = 54
						Me.Ooo_o_._o0_O.()(Me.Ooo_o_._o0_O.().Rows.Fixed + i, "DateGroup") = A_0.SubtotalGroups(i).DateGroup
					End If
					IL_594:
					num = 55
				Next
				IL_5A6:
				num = 56
				Me.Ooo_o_._o0_O.().Col = 0
				IL_5B5:
				num = 57
				Me.O0_oo0OoO_o.o.().Checked = A_0.TreeVisible
				IL_5C9:
				num = 58
				Me.o__.O0.().Checked = A_0.GroupAboveData
				IL_5DD:
				num = 59
				Me.Ooo_o_._o0_O.().Checked = A_0.SpillNode
				IL_5F1:
				num = 60
				Me.o_0O.o_000_0.().Visible = (OO_00oOO.User.Type = 0)
				IL_60C:
				num = 61
				Me.o_0O.o_000_0.().Visible = False
				IL_61B:
				GoTo IL_765
				IL_620:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_726:
				GoTo IL_75A
				IL_728:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_738:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_728
			End Try
			IL_75A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_765:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600369C RID: 13980 RVA: 0x001720FC File Offset: 0x001702FC
		Private Sub <<EMPTY_NAME>>()
			Me.O_Oo_._0O_O..ClearEditInfos()
			Me.O_Oo_._0O_O..SubtotalGroups.Clear()
			Me.O_Oo_._0O_O..SubtotalGroups.AddRange(Me.o__.o0_oo0.())
			Me.O_Oo_._0O_O..GroupAboveData = Me.o__.O0.().Checked
			If Me.O_Oo_._0O_O..o.Oo_o_o_0oo. <> Me.O0_oo0OoO_o.o.().Checked Then
				Me.O_Oo_._0O_O..o.Oo_o_o_0oo. = Me.O0_oo0OoO_o.o.().Checked
			End If
			Me.O_Oo_._0O_O..SpillNode = Me.Ooo_o_._o0_O.().Checked
			Me.O_Oo_._0O_O..Subtotal(False)
			Me.O_Oo_._0O_O..NeedSaveSetting = True
			Me.O_Oo_._0O_O..oo0OO0Ooo._.(True)
		End Sub

		' Token: 0x0600369D RID: 13981 RVA: 0x001721B8 File Offset: 0x001703B8
		Private Overloads Function <<EMPTY_NAME>>() As SubtotalGroupCollection
			Dim num As Integer
			Dim result As SubtotalGroupCollection
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim subtotalGroupCollection As SubtotalGroupCollection = New SubtotalGroupCollection()
				IL_10:
				num2 = 3
				Dim index As Integer = Me.Ooo_o_._o0_O.().Cols("upto").Index
				IL_2E:
				num2 = 4
				Dim num3 As Integer = Me.Ooo_o_._o0_O.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_4C:
					num2 = 5
					Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
					IL_55:
					num2 = 6
					subtotalGroup.Aggregate = Conversions.ToInteger(Me.Ooo_o_._o0_O.()(i, "Aggregate"))
					IL_75:
					num2 = 7
					subtotalGroup.GroupOn = Me.Ooo_o_._o0_O.()(i, "GroupOn").ToString()
					IL_95:
					num2 = 8
					If Me.Ooo_o_._o0_O.()(i, "TotalOn") IsNot Nothing Then
						IL_AB:
						num2 = 9
						subtotalGroup.TotalOn = Me.Ooo_o_._o0_O.()(i, "TotalOn").ToString()
					End If
					IL_CC:
					num2 = 10
					If Me.Ooo_o_._o0_O.()(i, "Caption") IsNot Nothing Then
						IL_E3:
						num2 = 11
						subtotalGroup.Caption = Me.Ooo_o_._o0_O.()(i, "Caption").ToString()
					End If
					IL_104:
					num2 = 12
					If Me.Ooo_o_._o0_O.()(i, "DateGroup") IsNot Nothing Then
						IL_11B:
						num2 = 13
						subtotalGroup.DateGroup = Conversions.ToInteger(Me.Ooo_o_._o0_O.()(i, "DateGroup"))
					End If
					IL_13C:
					num2 = 14
					subtotalGroup.upto = (Me.Ooo_o_._o0_O.().GetCellCheck(i, index) = 1)
					IL_158:
					num2 = 15
					subtotalGroupCollection.Add(subtotalGroup)
					IL_164:
					num2 = 16
				Next
				IL_176:
				num2 = 17
				result = subtotalGroupCollection
				IL_17C:
				GoTo IL_216
				IL_181:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1D7:
				GoTo IL_20B
				IL_1D9:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1E9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1D9
			End Try
			IL_20B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_216:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0600369E RID: 13982 RVA: 0x00172400 File Offset: 0x00170600
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0OoO_.oo0Ooo.()
			MyBase.Close()
		End Sub

		' Token: 0x0600369F RID: 13983 RVA: 0x00172410 File Offset: 0x00170610
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "GroupOn", True) = 0 Then
				If Me.ooo0.oO_o0___.(A_1.Row) Then
					Me.Ooo_o_._o0_O.()(A_1.Row, "DateGroup") = 3
				Else
					Me.Ooo_o_._o0_O.()(A_1.Row, "DateGroup") = Nothing
				End If
			End If
			If Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "Aggregate", True) = 0 OrElse Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "GroupOn", True) = 0 OrElse Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "DateGroup", True) = 0 OrElse Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "upto", True) = 0 Then
				Me.Ooo_o_._o0_O.(A_1.Row)
			End If
			Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "TotalOn", True)
		End Sub

		' Token: 0x060036A0 RID: 13984 RVA: 0x0017255C File Offset: 0x0017075C
		Private Function <<EMPTY_NAME>>(A_0 As Integer) As Boolean
			Dim text As String = Conversions.ToString(Me.Ooo_o_._o0_O.()(A_0, "GroupOn"))
			Return Operators.CompareString(text, "*", True) <> 0 AndAlso Me.O_Oo_._0O_O..foxGrid.Cols(text).DataType Is GetType(DateTime)
		End Function

		' Token: 0x060036A1 RID: 13985 RVA: 0x001725BC File Offset: 0x001707BC
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = ""
				IL_0F:
				num2 = 3
				Dim text2 As String = ""
				IL_18:
				num2 = 4
				Dim aggregateEnum As AggregateEnum = Conversions.ToInteger(Me.Ooo_o_._o0_O.()(A_0, "Aggregate"))
				IL_32:
				num2 = 5
				Dim index As Integer = Me.Ooo_o_._o0_O.().Cols("upto").Index
				IL_50:
				num2 = 6
				If Me.Ooo_o_._o0_O.().GetCellCheck(A_0, index) <> 1 Then
					GoTo IL_68
				End If
				IL_63:
				num2 = 7
				Dim flag As Boolean = True
				IL_68:
				num2 = 8
				Select Case aggregateEnum
					Case 2, 3, 4
						IL_A4:
						num2 = 10
						If Not flag Then
							GoTo IL_B6
						End If
						IL_AB:
						num2 = 11
						text = "累计"
						GoTo IL_BF
						IL_B6:
						num2 = 13
						text = "小计"
						IL_BF:
						num2 = 14
						text2 = "总计"
					Case 6
						IL_122:
						num2 = 28
						text = "平均"
						IL_12B:
						num2 = 29
						text2 = "平均"
					Case 7
						IL_137:
						num2 = 31
						text = "最大"
						IL_140:
						num2 = 32
						text2 = "最大"
					Case 8
						IL_14C:
						num2 = 34
						text = "最小"
						IL_155:
						num2 = 35
						text2 = "最小"
					Case 9
						IL_CE:
						num2 = 16
						text = "标准偏差"
						IL_D7:
						num2 = 17
						text2 = "标准偏差"
					Case 10
						IL_E3:
						num2 = 19
						text = "采样方差"
						IL_EC:
						num2 = 20
						text2 = "采样方差"
					Case 11
						IL_F8:
						num2 = 22
						text = "总体标准差"
						IL_101:
						num2 = 23
						text2 = "总体标准差"
					Case 12
						IL_10D:
						num2 = 25
						text = "总体方差"
						IL_116:
						num2 = 26
						text2 = "总体方差"
				End Select
				IL_15F:
				num2 = 37
				If Me.Ooo_o_._o0_O.()(A_0, "DateGroup") Is Nothing OrElse Conversions.ToInteger(Me.Ooo_o_._o0_O.()(A_0, "DateGroup")) = 0 Then
					GoTo IL_1B4
				End If
				IL_18D:
				num2 = 38
				text = "{0}" + Me.Ooo_o_._o0_O.().GetDataDisplay(A_0, "DateGroup") + " " + text
				GoTo IL_1C3
				IL_1B4:
				num2 = 40
				text = "{0} " + text
				IL_1C3:
				num2 = 41
				If Operators.CompareString(Me.Ooo_o_._o0_O.()(A_0, "GroupOn").ToString(), "*", True) <> 0 Then
					GoTo IL_201
				End If
				IL_1E9:
				num2 = 42
				Me.Ooo_o_._o0_O.()(A_0, "Caption") = text2
				GoTo IL_216
				IL_201:
				num2 = 44
				Me.Ooo_o_._o0_O.()(A_0, "Caption") = text
				IL_216:
				GoTo IL_31C
				IL_21B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2DD:
				GoTo IL_311
				IL_2DF:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2EF:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2DF
			End Try
			IL_311:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_31C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060036A2 RID: 13986 RVA: 0x0017290C File Offset: 0x00170B0C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso Operators.CompareString(Me.Ooo_o_._o0_O.().Cols(A_1.Col).Name, "DateGroup", True) = 0 AndAlso Not Me.ooo0.oO_o0___.(A_1.Row) Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x060036A3 RID: 13987 RVA: 0x00172960 File Offset: 0x00170B60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim a_ As String = Conversions.ToString(Me.Ooo_o_._o0_O.()(A_1.Row, "TotalOn"))
			Dim a_2 As AggregateEnum = Conversions.ToInteger(Me.Ooo_o_._o0_O.()(A_1.Row, "Aggregate"))
			Dim o_u3002_u3000_u3002_u As O\u3002\u3000\u3002\u3000 = New O\u3002\u3000\u3002\u3000(Me.O_Oo_._0O_O., a_, a_2)
			If o_u3002_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
				Me.Ooo_o_._o0_O.()(A_1.Row, "TotalOn") = o_u3002_u3000_u3002_u.oO.0_0.
				If Me.Ooo_o_._o0_O.()(A_1.Row, A_1.Col) IsNot Nothing Then
					Dim text As String = Me.Ooo_o_._o0_O.()(A_1.Row, A_1.Col).ToString()
					Dim fixed As Integer = Me.Ooo_o_._o0_O.().Rows.Fixed
					Dim num As Integer = Me.Ooo_o_._o0_O.().Rows.Count - 1
					For i As Integer = fixed To num
						If Me.Ooo_o_._o0_O.()(i, "TotalOn") Is Nothing Then
							Me.Ooo_o_._o0_O.()(i, "TotalOn") = text
						End If
					Next
				End If
			End If
		End Sub

		' Token: 0x060036A4 RID: 13988 RVA: 0x00172A6C File Offset: 0x00170C6C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOO.o.()
			Me.Ooo_o_._o0_O.().Row = Me.Ooo_o_._o0_O.().Rows.Count - 1
		End Sub

		' Token: 0x060036A5 RID: 13989 RVA: 0x00172A94 File Offset: 0x00170C94
		Private Sub <<EMPTY_NAME>>()
			Me.Ooo_o_._o0_O.()
			Me.Ooo_o_._o0_O.().Rows.Count = Me.Ooo_o_._o0_O.().Rows.Count + 1
			Dim num As Integer = Me.Ooo_o_._o0_O.().Rows.Count - 1
			Me.Ooo_o_._o0_O.()(num, "GroupOn") = "*"
			If num = 1 Then
				Me.Ooo_o_._o0_O.()(num, "Aggregate") = 2
			Else
				Me.Ooo_o_._o0_O.()(num, "Aggregate") = RuntimeHelpers.GetObjectValue(Me.Ooo_o_._o0_O.()(num - 1, "Aggregate"))
				Me.Ooo_o_._o0_O.()(num, "TotalOn") = RuntimeHelpers.GetObjectValue(Me.Ooo_o_._o0_O.()(num - 1, "TotalOn"))
			End If
			Me.Ooo_o_._o0_O.(num)
		End Sub

		' Token: 0x060036A6 RID: 13990 RVA: 0x00172B6B File Offset: 0x00170D6B
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Ooo_o_._o0_O.().Row > 0 Then
				Me.Ooo_o_._o0_O.().RemoveItem(Me.Ooo_o_._o0_O.().Row)
			End If
		End Sub

		' Token: 0x060036A7 RID: 13991 RVA: 0x00172B94 File Offset: 0x00170D94
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOO.o.()
			Me.Ooo_o_._o0_O.().Rows(Me.Ooo_o_._o0_O.().Rows.Count - 1).Move(Me.Ooo_o_._o0_O.().Row)
			Me.Ooo_o_._o0_O.().Row = Me.Ooo_o_._o0_O.().Row - 1
		End Sub

		' Token: 0x060036A8 RID: 13992 RVA: 0x00172BF1 File Offset: 0x00170DF1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Ooo_o_._o0_O.().Row > 1 Then
				Me.Ooo_o_._o0_O.().Rows(Me.Ooo_o_._o0_O.().Row).Move(Me.Ooo_o_._o0_O.().Row - 1)
			End If
		End Sub

		' Token: 0x060036A9 RID: 13993 RVA: 0x00172C30 File Offset: 0x00170E30
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Ooo_o_._o0_O.().Row < Me.Ooo_o_._o0_O.().Rows.Count - 1 AndAlso Me.Ooo_o_._o0_O.().Row > 0 Then
				Me.Ooo_o_._o0_O.().Rows(Me.Ooo_o_._o0_O.().Row).Move(Me.Ooo_o_._o0_O.().Row + 1)
			End If
		End Sub

		' Token: 0x060036AA RID: 13994 RVA: 0x00172C98 File Offset: 0x00170E98
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim index As Integer = Me.Ooo_o_._o0_O.().Cols("upto").Index
				IL_24:
				num2 = 3
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_2D:
				num2 = 4
				Dim str As String = "Tables(""" + Me.O_Oo_._0O_O..Name + """)"
				IL_4B:
				num2 = 5
				stringBuilder.Append("Dim t As Table = " + str)
				IL_61:
				num2 = 6
				stringBuilder.Append(vbCrLf)
				IL_70:
				num2 = 7
				stringBuilder.Append("Dim g As SubtotalGroup")
				IL_7F:
				num2 = 8
				stringBuilder.Append(vbCrLf)
				IL_8E:
				num2 = 9
				stringBuilder.Append("t.SubtotalGroups.Clear()")
				IL_9E:
				num2 = 10
				stringBuilder.Append(vbCrLf)
				IL_AE:
				num2 = 11
				stringBuilder.Append("t.GroupAboveData = " + Me.o__.O0.().Checked.ToString())
				IL_D7:
				num2 = 12
				stringBuilder.Append(vbCrLf)
				IL_E7:
				num2 = 13
				stringBuilder.Append("t.TreeVisible = " + Me.O0_oo0OoO_o.o.().Checked.ToString())
				IL_110:
				num2 = 14
				stringBuilder.Append(vbCrLf)
				IL_120:
				num2 = 15
				stringBuilder.Append("t.SpillNode = " + Me.Ooo_o_._o0_O.().Checked.ToString())
				IL_149:
				num2 = 16
				stringBuilder.Append(vbCrLf)
				IL_159:
				num2 = 17
				stringBuilder.Append(vbCrLf)
				IL_169:
				num2 = 18
				Dim num3 As Integer = Me.Ooo_o_._o0_O.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_188:
					num2 = 19
					stringBuilder.Append("g = New SubtotalGroup")
					IL_198:
					num2 = 20
					stringBuilder.Append(vbCrLf)
					IL_1A8:
					num2 = 21
					stringBuilder.Append("g.Aggregate = AggregateEnum." + [Enum].GetName(GetType(AggregateEnum), Conversions.ToInteger(Me.Ooo_o_._o0_O.()(i, "Aggregate"))))
					IL_1E8:
					num2 = 22
					stringBuilder.Append(vbCrLf)
					IL_1F8:
					num2 = 23
					stringBuilder.Append("g.GroupOn = """ + Me.Ooo_o_._o0_O.()(i, "GroupOn").ToString() + """")
					IL_229:
					num2 = 24
					stringBuilder.Append(vbCrLf)
					IL_239:
					num2 = 25
					If Me.Ooo_o_._o0_O.()(i, "TotalOn") IsNot Nothing Then
						IL_250:
						num2 = 26
						stringBuilder.Append("g.TotalOn = """ + Me.Ooo_o_._o0_O.()(i, "TotalOn").ToString() + """")
						IL_281:
						num2 = 27
						stringBuilder.Append(vbCrLf)
					End If
					IL_291:
					num2 = 28
					If Me.Ooo_o_._o0_O.()(i, "Caption") IsNot Nothing Then
						IL_2A8:
						num2 = 29
						stringBuilder.Append("g.Caption = """ + Me.Ooo_o_._o0_O.()(i, "Caption").ToString() + """")
						IL_2D9:
						num2 = 30
						stringBuilder.Append(vbCrLf)
					End If
					IL_2E9:
					num2 = 31
					If Me.Ooo_o_._o0_O.()(i, "DateGroup") IsNot Nothing Then
						IL_300:
						num2 = 32
						stringBuilder.Append("g.DateGroup = DateGroupEnum." + [Enum].GetName(GetType(DateGroupEnum), Conversions.ToInteger(Me.Ooo_o_._o0_O.()(i, "DateGroup"))))
						IL_340:
						num2 = 33
						stringBuilder.Append(vbCrLf)
					End If
					IL_350:
					num2 = 34
					If Me.Ooo_o_._o0_O.().GetCellCheck(i, index) = 1 Then
						IL_364:
						num2 = 35
						stringBuilder.Append("g.upto = True")
						IL_374:
						num2 = 36
						stringBuilder.Append(vbCrLf)
					End If
					IL_384:
					num2 = 37
					stringBuilder.Append("t.SubtotalGroups.Add(g)")
					IL_394:
					num2 = 38
					stringBuilder.Append(vbCrLf)
					IL_3A4:
					num2 = 39
					stringBuilder.Append(vbCrLf)
					IL_3B4:
					num2 = 40
				Next
				IL_3C6:
				num2 = 41
				stringBuilder.Append("t.Subtotal()")
				IL_3D6:
				num2 = 42
				Dim o_u3000_u3000_u3002_u3002O As o\u3000\u3000\u3002\u3002O = New o\u3000\u3000\u3002\u3002O()
				IL_3E0:
				num2 = 43
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString()
				IL_3F6:
				num2 = 44
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0
				IL_406:
				num2 = 45
				o_u3000_u3000_u3002_u3002O.ShowDialog()
				IL_411:
				GoTo IL_51B
				IL_416:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_4DC:
				GoTo IL_510
				IL_4DE:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4EE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4DE
			End Try
			IL_510:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_51B:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060036AB RID: 13995 RVA: 0x001731E4 File Offset: 0x001713E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o0OoO_.oo0Ooo.()
		End Sub

		' Token: 0x060036AC RID: 13996 RVA: 0x001731EC File Offset: 0x001713EC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As SubtotalModeProperty = New SubtotalModeProperty(Me.o__.o0_oo0.(), Me.o__.O0.().Checked, Me.O0_oo0OoO_o.o.().Checked, Me.Ooo_o_._o0_O.().Checked)
			New O\u3002_\u3002\u3000\u3002(Me.O_Oo_._0O_O., o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False), 3).ShowDialog()
		End Sub

		' Token: 0x060036AD RID: 13997 RVA: 0x00173242 File Offset: 0x00171442
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3000\u3000\u3002\u3002\u3002\u3002o(Me.O_Oo_._0O_O., 3).ShowDialog()
		End Sub

		' Token: 0x060036AE RID: 13998 RVA: 0x00173256 File Offset: 0x00171456
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400166F RID: 5743
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001670 RID: 5744
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001671 RID: 5745
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001672 RID: 5746
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001673 RID: 5747
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001674 RID: 5748
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001675 RID: 5749
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001676 RID: 5750
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001677 RID: 5751
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001678 RID: 5752
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001679 RID: 5753
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400167A RID: 5754
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400167B RID: 5755
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400167C RID: 5756
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400167D RID: 5757
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400167E RID: 5758
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400167F RID: 5759
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001680 RID: 5760
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
