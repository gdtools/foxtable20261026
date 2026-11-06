Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000443 RID: 1091
	<DesignerGenerated()>
	Friend Partial Class k2
		Inherits Form

		' Token: 0x060047F4 RID: 18420 RVA: 0x001E3D5C File Offset: 0x001E1F5C
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo.oo__o_. IsNot Nothing Then
					Me.oo.oo__o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060047F5 RID: 18421 RVA: 0x001E3D9C File Offset: 0x001E1F9C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo.oo__o_. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(k2))
			Me.o0O0o_O.0O0O.(New C1FlexGrid())
			Me.o00.____O_ooo_.(New C1Button())
			Me.o._0oO.(New C1Button())
			Me.O_000.o0O___o.(New C1Button())
			Me.O_.o_oO.(New C1Button())
			Me.o_.OOo0.(New C1Button())
			Me.o_0OO.o_.(New C1TextBox())
			Me.oo00Oo_.o.(New C1Button())
			Me.o_0OO.o_.(New C1FlexGrid())
			Me.o_0OO.o_.(New Timer(Me.oo.oo__o_.))
			Me.o0O0o_O.0O0O.(New C1TextBox())
			Me.o0O0o_O.0O0O.(New Label())
			Me.o.oO0000.(New C1Button())
			Me.O0Oo0_O__OoO.o.(New C1Button())
			Me.o_0OO.o_.(New Label())
			Me.o_0OO.o_.(New C1ComboBox())
			Me.OO_._.().BeginInit()
			Me.o_O0.O__.().BeginInit()
			MyBase.SuspendLayout()
			Me.OO_._.().AllowDragging = 0
			Me.OO_._.().AllowEditing = False
			Me.OO_._.().BorderStyle = 4
			Me.OO_._.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.OO_._.().ExtendLastCol = True
			Me.OO_._.().FocusRect = 0
			Me.OO_._.().Location = New Point(13, 41)
			Me.OO_._.().Name = "C1FlexGrid1"
			Me.OO_._.().Rows.Count = 2
			Me.OO_._.().Rows.DefaultSize = 19
			Me.OO_._.().SelectionMode = 7
			Me.OO_._.().Size = New Size(661, 280)
			Me.OO_._.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.OO_._.().TabIndex = 0
			Me.OO_._.().VisualStyle = 1
			Me.OOOO0.oOo_O_.().Image = CType(componentResourceManager.GetObject("btnUpload.Image"), Image)
			Me.OOOO0.oOo_O_.().ImageAlign = ContentAlignment.MiddleLeft
			Me.OOOO0.oOo_O_.().Location = New Point(12, 327)
			Me.OOOO0.oOo_O_.().Name = "btnUpload"
			Me.OOOO0.oOo_O_.().Size = New Size(75, 23)
			Me.OOOO0.oOo_O_.().TabIndex = 1
			Me.OOOO0.oOo_O_.().Text = "上传"
			Me.OOOO0.oOo_O_.().UseVisualStyleBackColor = True
			Me.o_O0.O__.().Image = CType(componentResourceManager.GetObject("btnDownload.Image"), Image)
			Me.o_O0.O__.().ImageAlign = ContentAlignment.MiddleLeft
			Me.o_O0.O__.().Location = New Point(93, 327)
			Me.o_O0.O__.().Name = "btnDownload"
			Me.o_O0.O__.().Size = New Size(75, 23)
			Me.o_O0.O__.().TabIndex = 2
			Me.o_O0.O__.().Text = "下载"
			Me.o_O0.O__.().UseVisualStyleBackColor = True
			Me.o_._O_.().Location = New Point(336, 327)
			Me.o_._O_.().Name = "btnRename"
			Me.o_._O_.().Size = New Size(75, 23)
			Me.o_._O_.().TabIndex = 3
			Me.o_._O_.().Text = "重命名"
			Me.o_._O_.().UseVisualStyleBackColor = True
			Me.O._o__.().Location = New Point(255, 327)
			Me.O._o__.().Name = "btnDelete"
			Me.O._o__.().Size = New Size(75, 23)
			Me.O._o__.().TabIndex = 4
			Me.O._o__.().Text = "删除"
			Me.O._o__.().UseVisualStyleBackColor = True
			Me.o.00O.().Location = New Point(417, 327)
			Me.o.00O.().Name = "btnMakeDir"
			Me.o.00O.().Size = New Size(75, 23)
			Me.o.00O.().TabIndex = 6
			Me.o.00O.().Text = "新建目录"
			Me.o.00O.().UseVisualStyleBackColor = True
			Me.ooooOoo.0OOo0.().BackColor = SystemColors.Window
			Me.ooooOoo.0OOo0.().ForeColor = Color.Blue
			Me.ooooOoo.0OOo0.().Location = New Point(13, 356)
			Me.ooooOoo.0OOo0.().Multiline = True
			Me.ooooOoo.0OOo0.().Name = "TextBox1"
			Me.ooooOoo.0OOo0.().[ReadOnly] = True
			Me.ooooOoo.0OOo0.().ScrollBars = ScrollBars.Vertical
			Me.ooooOoo.0OOo0.().Size = New Size(661, 84)
			Me.ooooOoo.0OOo0.().TabIndex = 7
			Me.OO_._.().Image = CType(componentResourceManager.GetObject("btnRefresh.Image"), Image)
			Me.OO_._.().ImageAlign = ContentAlignment.MiddleLeft
			Me.OO_._.().Location = New Point(599, 327)
			Me.OO_._.().Name = "btnRefresh"
			Me.OO_._.().Size = New Size(75, 23)
			Me.OO_._.().TabIndex = 10
			Me.OO_._.().Text = "刷新"
			Me.OO_._.().UseVisualStyleBackColor = True
			Me.o_O0.O__.().AllowDragging = 0
			Me.o_O0.O__.().AllowEditing = False
			Me.o_O0.O__.().AllowResizing = 0
			Me.o_O0.O__.().BorderStyle = 4
			Me.o_O0.O__.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid2.ColumnInfo")
			Me.o_O0.O__.().ExtendLastCol = True
			Me.o_O0.O__.().HighLight = 2
			Me.o_O0.O__.().Location = New Point(13, 446)
			Me.o_O0.O__.().Name = "C1FlexGrid2"
			Me.o_O0.O__.().Rows.Count = 1
			Me.o_O0.O__.().Rows.DefaultSize = 19
			Me.o_O0.O__.().SelectionMode = 1
			Me.o_O0.O__.().Size = New Size(662, 105)
			Me.o_O0.O__.().StyleInfo = componentResourceManager.GetString("C1FlexGrid2.StyleInfo")
			Me.o_O0.O__.().TabIndex = 11
			Me.o_O0.O__.().VisualStyle = 1
			Me.oo.O_0_O00_O0_.().Enabled = True
			Me.oo.O_0_O00_O0_.().Interval = 300
			Me.oo.O_0_O00_O0_.().Location = New Point(77, 559)
			Me.oo.O_0_O00_O0_.().Name = "txtLocFolder"
			Me.oo.O_0_O00_O0_.().[ReadOnly] = True
			Me.oo.O_0_O00_O0_.().Size = New Size(555, 21)
			Me.oo.O_0_O00_O0_.().TabIndex = 13
			Me.oo.O_0_O00_O0_.().AutoSize = True
			Me.oo.O_0_O00_O0_.().Location = New Point(12, 562)
			Me.oo.O_0_O00_O0_.().Name = "Label1"
			Me.oo.O_0_O00_O0_.().Size = New Size(59, 12)
			Me.oo.O_0_O00_O0_.().TabIndex = 15
			Me.oo.O_0_O00_O0_.().Text = "本地路径:"
			Me.O0oO.00OO0O000.().Location = New Point(638, 557)
			Me.O0oO.00OO0O000.().Name = "btnOpenLocFolder"
			Me.O0oO.00OO0O000.().Size = New Size(37, 23)
			Me.O0oO.00OO0O000.().TabIndex = 16
			Me.O0oO.00OO0O000.().UseVisualStyleBackColor = True
			Me.OOo_.0o0.().ImageAlign = ContentAlignment.MiddleLeft
			Me.OOo_.0o0.().Location = New Point(174, 327)
			Me.OOo_.0o0.().Name = "btnOpen"
			Me.OOo_.0o0.().Size = New Size(75, 23)
			Me.OOo_.0o0.().TabIndex = 17
			Me.OOo_.0o0.().Text = "打开"
			Me.OOo_.0o0.().UseVisualStyleBackColor = True
			Me.ooooOoo.0OOo0.().AutoSize = True
			Me.ooooOoo.0OOo0.().Location = New Point(11, 15)
			Me.ooooOoo.0OOo0.().Name = "Label2"
			Me.ooooOoo.0OOo0.().Size = New Size(53, 12)
			Me.ooooOoo.0OOo0.().TabIndex = 18
			Me.ooooOoo.0OOo0.().Text = "FTP路径:"
			Me.oo.O_0_O00_O0_.().Location = New Point(70, 12)
			Me.oo.O_0_O00_O0_.().Name = "cmbFTPPath"
			Me.oo.O_0_O00_O0_.().Size = New Size(604, 20)
			Me.oo.O_0_O00_O0_.().TabIndex = 19
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(687, 590)
			MyBase.Controls.Add(Me.oo.O_0_O00_O0_.())
			MyBase.Controls.Add(Me.ooooOoo.0OOo0.())
			MyBase.Controls.Add(Me.OOo_.0o0.())
			MyBase.Controls.Add(Me.O0oO.00OO0O000.())
			MyBase.Controls.Add(Me.oo.O_0_O00_O0_.())
			MyBase.Controls.Add(Me.oo.O_0_O00_O0_.())
			MyBase.Controls.Add(Me.o_O0.O__.())
			MyBase.Controls.Add(Me.OO_._.())
			MyBase.Controls.Add(Me.ooooOoo.0OOo0.())
			MyBase.Controls.Add(Me.OOOO0.oOo_O_.())
			MyBase.Controls.Add(Me.o.00O.())
			MyBase.Controls.Add(Me.o_O0.O__.())
			MyBase.Controls.Add(Me.OO_._.())
			MyBase.Controls.Add(Me.o_._O_.())
			MyBase.Controls.Add(Me.O._o__.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.O....."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "远程文件管理器"
			Me.OO_._.().EndInit()
			Me.o_O0.O__.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060047F6 RID: 18422 RVA: 0x001E47C0 File Offset: 0x001E29C0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x060047F7 RID: 18423 RVA: 0x001E47C8 File Offset: 0x001E29C8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim sortColEventHandler As SortColEventHandler = AddressOf Me.oO_Oo.00o.
			Dim value As EventHandler = AddressOf Me.OO.o_O_0o0OO.
			Dim value2 As KeyEventHandler = AddressOf Me.o_000._.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.O0.o0O0_.
			Dim o__O0.o_o. As C1FlexGrid = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				o__O0.o_o..AfterSort -= sortColEventHandler
				RemoveHandler o__O0.o_o..DoubleClick, value
				RemoveHandler o__O0.o_o..KeyDown, value2
				o__O0.o_o..OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.O__O0.o_o. = A_0
			o__O0.o_o. = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				o__O0.o_o..AfterSort += sortColEventHandler
				AddHandler o__O0.o_o..DoubleClick, value
				AddHandler o__O0.o_o..KeyDown, value2
				o__O0.o_o..OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x060047F8 RID: 18424 RVA: 0x001E4868 File Offset: 0x001E2A68
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x060047F9 RID: 18425 RVA: 0x001E4870 File Offset: 0x001E2A70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo000.0.
			Dim o__O0.o_o. As C1Button = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				RemoveHandler o__O0.o_o..Click, value
			End If
			Me.O__O0.o_o. = A_0
			o__O0.o_o. = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				AddHandler o__O0.o_o..Click, value
			End If
		End Sub

		' Token: 0x060047FA RID: 18426 RVA: 0x001E48B3 File Offset: 0x001E2AB3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_.Oo.
		End Function

		' Token: 0x060047FB RID: 18427 RVA: 0x001E48BC File Offset: 0x001E2ABC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_0_o0.o.
			Dim c1Button As C1Button = Me.o_.Oo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_.Oo. = A_0
			c1Button = Me.o_.Oo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060047FC RID: 18428 RVA: 0x001E48FF File Offset: 0x001E2AFF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._o0o__o0O_0O.
		End Function

		' Token: 0x060047FD RID: 18429 RVA: 0x001E4908 File Offset: 0x001E2B08
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO_O.0_oOoO.
			Dim o._o0o__o0O_0O. As C1Button = Me.O._o0o__o0O_0O.
			If o._o0o__o0O_0O. IsNot Nothing Then
				RemoveHandler o._o0o__o0O_0O..Click, value
			End If
			Me.O._o0o__o0O_0O. = A_0
			o._o0o__o0O_0O. = Me.O._o0o__o0O_0O.
			If o._o0o__o0O_0O. IsNot Nothing Then
				AddHandler o._o0o__o0O_0O..Click, value
			End If
		End Sub

		' Token: 0x060047FE RID: 18430 RVA: 0x001E494B File Offset: 0x001E2B4B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO__o._o__oO00.
		End Function

		' Token: 0x060047FF RID: 18431 RVA: 0x001E4954 File Offset: 0x001E2B54
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo0o._O.
			Dim c1Button As C1Button = Me.oO__o._o__oO00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO__o._o__oO00. = A_0
			c1Button = Me.oO__o._o__oO00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004800 RID: 18432 RVA: 0x001E4997 File Offset: 0x001E2B97
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0.O__0_o.
		End Function

		' Token: 0x06004801 RID: 18433 RVA: 0x001E49A0 File Offset: 0x001E2BA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0Oo_0_O_o.O.
			Dim c1Button As C1Button = Me.oO0.O__0_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0.O__0_o. = A_0
			c1Button = Me.oO0.O__0_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004802 RID: 18434 RVA: 0x001E49E3 File Offset: 0x001E2BE3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x06004803 RID: 18435 RVA: 0x001E49EB File Offset: 0x001E2BEB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O__O0.o_o. = A_0
		End Sub

		' Token: 0x06004804 RID: 18436 RVA: 0x001E49F4 File Offset: 0x001E2BF4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00.___.
		End Function

		' Token: 0x06004805 RID: 18437 RVA: 0x001E49FC File Offset: 0x001E2BFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOo._O0o0O0_0.
			Dim o00.___. As C1Button = Me.O00.___.
			If o00.___. IsNot Nothing Then
				RemoveHandler o00.___..Click, value
			End If
			Me.O00.___. = A_0
			o00.___. = Me.O00.___.
			If o00.___. IsNot Nothing Then
				AddHandler o00.___..Click, value
			End If
		End Sub

		' Token: 0x06004806 RID: 18438 RVA: 0x001E4A3F File Offset: 0x001E2C3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo.____o0_.
		End Function

		' Token: 0x06004807 RID: 18439 RVA: 0x001E4A48 File Offset: 0x001E2C48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim value As KeyEventHandler = AddressOf Me.o00_.___.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.o__o0O0_._0.
			Dim oo.____o0_. As C1FlexGrid = Me.Oo.____o0_.
			If oo.____o0_. IsNot Nothing Then
				RemoveHandler oo.____o0_..KeyDown, value
				oo.____o0_..OwnerDrawCell -= ownerDrawCellEventHandler
			End If
			Me.Oo.____o0_. = A_0
			oo.____o0_. = Me.Oo.____o0_.
			If oo.____o0_. IsNot Nothing Then
				AddHandler oo.____o0_..KeyDown, value
				oo.____o0_..OwnerDrawCell += ownerDrawCellEventHandler
			End If
		End Sub

		' Token: 0x06004808 RID: 18440 RVA: 0x001E4AA6 File Offset: 0x001E2CA6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x06004809 RID: 18441 RVA: 0x001E4AB0 File Offset: 0x001E2CB0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.O00.___.
			Dim o__O0.o_o. As Timer = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				RemoveHandler o__O0.o_o..Tick, value
			End If
			Me.O__O0.o_o. = A_0
			o__O0.o_o. = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				AddHandler o__O0.o_o..Tick, value
			End If
		End Sub

		' Token: 0x0600480A RID: 18442 RVA: 0x001E4AF3 File Offset: 0x001E2CF3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O0O0OO0_oO0.o0.
		End Function

		' Token: 0x0600480B RID: 18443 RVA: 0x001E4AFB File Offset: 0x001E2CFB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O0O0OO0_oO0.o0. = A_0
		End Sub

		' Token: 0x0600480C RID: 18444 RVA: 0x001E4B04 File Offset: 0x001E2D04
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x0600480D RID: 18445 RVA: 0x001E4B0C File Offset: 0x001E2D0C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O__O0.o_o. = A_0
		End Sub

		' Token: 0x0600480E RID: 18446 RVA: 0x001E4B15 File Offset: 0x001E2D15
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOO__OOoo0.O.
		End Function

		' Token: 0x0600480F RID: 18447 RVA: 0x001E4B20 File Offset: 0x001E2D20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOo__._00O00OO.
			Dim c1Button As C1Button = Me.oOO__OOoo0.O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOO__OOoo0.O. = A_0
			c1Button = Me.oOO__OOoo0.O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004810 RID: 18448 RVA: 0x001E4B63 File Offset: 0x001E2D63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_.oo_O_0_.
		End Function

		' Token: 0x06004811 RID: 18449 RVA: 0x001E4B6C File Offset: 0x001E2D6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_000._.
			Dim c1Button As C1Button = Me.oO_.oo_O_0_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO_.oo_O_0_. = A_0
			c1Button = Me.oO_.oo_O_0_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004812 RID: 18450 RVA: 0x001E4BAF File Offset: 0x001E2DAF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo.____o0_.
		End Function

		' Token: 0x06004813 RID: 18451 RVA: 0x001E4BB7 File Offset: 0x001E2DB7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo.____o0_. = A_0
		End Sub

		' Token: 0x06004814 RID: 18452 RVA: 0x001E4BC0 File Offset: 0x001E2DC0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x06004815 RID: 18453 RVA: 0x001E4BC8 File Offset: 0x001E2DC8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim value As EventHandler = AddressOf Me.o00_.___.
			Dim value2 As KeyEventHandler = AddressOf Me.o__o0O0_._0.
			Dim value3 As KeyPressEventHandler = AddressOf Me.o__o0O0_._0.
			Dim eventHandler As EventHandler = AddressOf Me.o__o0O0_._0.
			Dim o__O0.o_o. As C1ComboBox = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				RemoveHandler o__O0.o_o..Enter, value
				RemoveHandler o__O0.o_o..KeyDown, value2
				RemoveHandler o__O0.o_o..KeyPress, value3
				o__O0.o_o..SelectedIndexChanged -= eventHandler
			End If
			Me.O__O0.o_o. = A_0
			o__O0.o_o. = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				AddHandler o__O0.o_o..Enter, value
				AddHandler o__O0.o_o..KeyDown, value2
				AddHandler o__O0.o_o..KeyPress, value3
				o__O0.o_o..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06004816 RID: 18454 RVA: 0x001E4C68 File Offset: 0x001E2E68
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.O__O0.o_o.
		End Function

		' Token: 0x06004817 RID: 18455 RVA: 0x001E4C70 File Offset: 0x001E2E70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.OooO_O0O_0_O = AddressOf Me.Oo_o_o0.O__oOo.
			Dim a_2 As FTPClient.OoO_00_o = AddressOf Me.O00_0.o00OO.
			Dim a_3 As FTPClient.OOOOO00OoOOo = AddressOf Me.O00_0.o00OO.
			Dim o__O0.o_o. As FTPClient = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				RemoveHandler o__O0.o_o..ServerConnected, a_
				RemoveHandler o__O0.o_o..ShowError, a_2
				RemoveHandler o__O0.o_o..ShowMessage, a_3
			End If
			Me.O__O0.o_o. = A_0
			o__O0.o_o. = Me.O__O0.o_o.
			If o__O0.o_o. IsNot Nothing Then
				AddHandler o__O0.o_o..ServerConnected, a_
				AddHandler o__O0.o_o..ShowError, a_2
				AddHandler o__O0.o_o..ShowMessage, a_3
			End If
		End Sub

		' Token: 0x06004818 RID: 18456 RVA: 0x001E4CE9 File Offset: 0x001E2EE9
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As FTPClient
			Return Me.Oo.____o0_.
		End Function

		' Token: 0x06004819 RID: 18457 RVA: 0x001E4CF4 File Offset: 0x001E2EF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As FTPClient)
			Dim a_ As FTPClient.O__0O000__Oo = AddressOf Me.Oo_o_o0.O__oOo.
			Dim a_2 As FTPClient.oO_o_0OOo__0 = AddressOf Me.O00oO_o.OO.
			Dim a_3 As FTPClient.o0O_O00o_0_o = AddressOf Me.Oo_o_o0.O__oOo.
			Dim a_4 As FTPClient.o0_O_0_0 = AddressOf Me.Oo_o_o0.O__oOo.
			Dim a_5 As FTPClient.OoO_00_o = AddressOf Me.O00_0.o00OO.
			Dim a_6 As FTPClient.OOOOO00OoOOo = AddressOf Me.O00_0.o00OO.
			Dim a_7 As FTPClient.ooo__O = AddressOf Me.Oo_o_o0.O__oOo.
			Dim a_8 As FTPClient.oO___ = AddressOf Me.Oo_o_o0.O__oOo.
			Dim oo.____o0_. As FTPClient = Me.Oo.____o0_.
			If oo.____o0_. IsNot Nothing Then
				RemoveHandler oo.____o0_..DownloadError, a_
				RemoveHandler oo.____o0_..DownloadCompleted, a_2
				RemoveHandler oo.____o0_..DownloadProgressChanged, a_3
				RemoveHandler oo.____o0_..UploadProgressChanged, a_4
				RemoveHandler oo.____o0_..ShowError, a_5
				RemoveHandler oo.____o0_..ShowMessage, a_6
				RemoveHandler oo.____o0_..UploadError, a_7
				RemoveHandler oo.____o0_..UploadCompleted, a_8
			End If
			Me.Oo.____o0_. = A_0
			oo.____o0_. = Me.Oo.____o0_.
			If oo.____o0_. IsNot Nothing Then
				AddHandler oo.____o0_..DownloadError, a_
				AddHandler oo.____o0_..DownloadCompleted, a_2
				AddHandler oo.____o0_..DownloadProgressChanged, a_3
				AddHandler oo.____o0_..UploadProgressChanged, a_4
				AddHandler oo.____o0_..ShowError, a_5
				AddHandler oo.____o0_..ShowMessage, a_6
				AddHandler oo.____o0_..UploadError, a_7
				AddHandler oo.____o0_..UploadCompleted, a_8
			End If
		End Sub

		' Token: 0x0600481A RID: 18458 RVA: 0x001E4E14 File Offset: 0x001E3014
		Public Sub New(A_0 As FTPClient, A_1 As String)
			AddHandler MyBase.Activated, AddressOf Me.oOoOo___oO.o_.
			AddHandler MyBase.FormClosed, AddressOf Me.Oo_o_o0.O__oOo.
			AddHandler MyBase.FormClosing, AddressOf Me.Oo_o_o0.O__oOo.
			Me.ooooOoo.0OOo0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.ooooOoo.0OOo0.().BackColor = Color.White
			Me.ooooOoo.0OOo0.().ForeColor = SystemColors.WindowText
			Me.OO_._.().Styles.SelectedColumnHeader.Clear()
			Me.o_0OO.o_.(A_0)
			Me.oo.oo__o_. = A_1
			Me.OO_._.().Styles.Focus.MergeWith(Me.OO_._.().Styles.Highlight)
			Me.OO_._.().DrawMode = 1
			Me.o_O0.O__.().DrawMode = 1
			Me.OO_._.().Cols(1).Format = "yyyy-MM-dd HH:mm"
			Me.OOOO0.oOo_O_.().Enabled = A_0.UploadEnabled
			Me.o_O0.O__.().Enabled = A_0.DownloadEnabled
			Me.o_._O_.().Enabled = A_0.RenameEnabled
			Me.O._o__.().Enabled = A_0.DeleteEnabled
			Me.o.00O.().Enabled = A_0.MakerDirEnabled
			Me.OOo_.0o0.().Enabled = A_0.OpenFileEnabled
			Me.o0O0o_O.0O0O.(New FTPClient())
			Me.oo.O_0_O00_O0_.().Host = Me.ooooOoo.0OOo0.().Host
			Me.oo.O_0_O00_O0_.().Account = Me.ooooOoo.0OOo0.().Account
			Me.oo.O_0_O00_O0_.().Password = Me.ooooOoo.0OOo0.().Password
			Me.oo.O_0_O00_O0_.().Port = Me.ooooOoo.0OOo0.().Port
			Me.oo.O_0_O00_O0_.().UTF8 = Me.ooooOoo.0OOo0.().UTF8
			Me.oo.O_0_O00_O0_.().FTPName = Me.ooooOoo.0OOo0.().FTPName
			Me.oo.O_0_O00_O0_.().O_OO.OOO_OOO. = False
			Me.o_O0.O__.().Styles.Add("error", Me.o_O0.O__.().Styles.Normal).ForeColor = Color.Red
			AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.o.oO0000.
			AddHandler NetworkChange.NetworkAddressChanged, AddressOf Me.o._0oO.
			Me.O0oO.00OO0O000.().Image = Foxtable.My.Resources.a.O00o_Ooo.0.()
			Me.oo.O_0_O00_O0_.().Value = OO_00oOO.ProjectPath + "RemoteFiles"
			If Not OO_00oOO.FileSys.DirectoryExists(Me.oo.O_0_O00_O0_.().Text) Then
				OO_00oOO.FileSys.CreateDirectory(Me.oo.O_0_O00_O0_.().Text)
			End If
		End Sub

		' Token: 0x0600481B RID: 18459 RVA: 0x001E50BC File Offset: 0x001E32BC
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If Me.ooooOoo.0OOo0.().FindForm() IsNot Nothing AndAlso Not Me.ooooOoo.0OOo0.().FindForm().IsDisposed Then
				If Operators.CompareString(Me.ooooOoo.0OOo0.().Text, "", True) > 0 Then
					Me.ooooOoo.0OOo0.().AppendText(vbCrLf)
					Me.ooooOoo.0OOo0.().AppendText(A_0.Trim())
					Return
				End If
				Me.ooooOoo.0OOo0.().AppendText(A_0.Trim())
			End If
		End Sub

		' Token: 0x0600481C RID: 18460 RVA: 0x001E5134 File Offset: 0x001E3334
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim num As Integer = Me.o_O0.O__.().FindRow(A_0, 1, 0, False, True, False)
			If num > 0 Then
				Dim left As String = ""
				If Me.o_O0.O__.().GetData(num, 5) IsNot Nothing Then
					left = Me.o_O0.O__.().GetData(num, 5).ToString()
				End If
				A_0 = Me.o_O0.O__.().GetData(num, 4).ToString()
				Me.o_O0.O__.().RemoveItem(num)
				If Operators.CompareString(left, "1", True) = 0 Then
					Process.Start(A_0)
				End If
			End If
		End Sub

		' Token: 0x0600481D RID: 18461 RVA: 0x001E51B4 File Offset: 0x001E33B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Application.DoEvents()
			If Me.a = 0 AndAlso Me.ooooOoo.0OOo0.().Connect() Then
				Me.a = 1
				If Operators.CompareString(Me.oo.oo__o_., "", True) > 0 Then
					Me.ooooOoo.0OOo0.().ChangeDir(Me.oo.oo__o_.)
					Me.oo.oo__o_. = ""
				End If
				Me.ooooOoo.0OOo0.(False)
				Me.oo.O_0_O00_O0_.().Value = Me.ooooOoo.0OOo0.().CurrentDir
			End If
		End Sub

		' Token: 0x0600481E RID: 18462 RVA: 0x001E5230 File Offset: 0x001E3430
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(Me.ooooOoo.0OOo0.().CurrentDir) OrElse A_0 Then
					GoTo IL_49
				End If
				IL_29:
				num2 = 3
				Dim a_ As List(Of String) = Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O.(Me.ooooOoo.0OOo0.().CurrentDir)
				GoTo IL_5C
				IL_49:
				num2 = 5
				a_ = Me.ooooOoo.0OOo0.().GetDetailList("")
				IL_5C:
				num2 = 6
				Dim ftpbeforeListDetailsEventArgs As FTPBeforeListDetailsEventArgs = New FTPBeforeListDetailsEventArgs(Me.ooooOoo.0OOo0.().CurrentDir, a_, Me.ooooOoo.0OOo0.().FTPName)
				IL_7C:
				num2 = 7
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", New Object() { ftpbeforeListDetailsEventArgs }, True, "FTP", False)
				IL_A0:
				num2 = 8
				Dim array As String() = ftpbeforeListDetailsEventArgs.RemovedItems
				IL_AB:
				num2 = 9
				Me.OO_._.().Rows.Count = 1
				IL_BF:
				num2 = 10
				Me.OO_._.().BeginUpdate()
				IL_CD:
				num2 = 11
				Dim enumerator As List(Of String()).Enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator()
				While enumerator.MoveNext()
					Dim array2 As String() = enumerator.Current
					IL_EC:
					num2 = 12
					If Operators.CompareString(array2(2), "D", True) = 0 Then
						IL_100:
						num2 = 14
						If Array.BinarySearch(Of String)(array, array2(0)) < 0 Then
							IL_111:
							num2 = 16
							Me.OO_._.().AddItem(String.Concat(New String() { array2(0), vbTab, array2(1), vbTab & " " & vbTab, Conversions.ToString(1) }))
							IL_152:
							num2 = 17
							Me.OO_._.().SetCellImage(Me.OO_._.().Rows.Count - 1, 0, Foxtable.My.Resources.a.oO0O_O.__oo.().ToBitmap())
						End If
					End If
					IL_17D:
					num2 = 18
				End While
				IL_18C:
				num2 = 19
				CType(enumerator, IDisposable).Dispose()
				IL_19C:
				num2 = 20
				Dim enumerator2 As List(Of String()).Enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator()
				While enumerator2.MoveNext()
					Dim array3 As String() = enumerator2.Current
					IL_1BB:
					num2 = 21
					If Operators.CompareString(array3(2), "D", True) <> 0 Then
						IL_1D2:
						num2 = 23
						If Array.BinarySearch(Of String)(array, array3(0)) < 0 Then
							IL_1E6:
							num2 = 25
							Me.OO_._.().AddItem(String.Concat(New String() { array3(0), vbTab, array3(1), vbTab, array3(2), vbTab, Conversions.ToString(2) }))
							IL_236:
							num2 = 26
							Dim text As String = array3(0)
							IL_23F:
							num2 = 27
							Dim bitmap As Bitmap = O_O0OO.O0_00o.o0__o.
							IL_249:
							num2 = 28
							If text.LastIndexOf(".") > 0 Then
								IL_25B:
								num2 = 29
								text = text.Substring(text.LastIndexOf(".")).ToLower()
								IL_278:
								num2 = 30
								If O_O0OO.O0_00o.o0__o..ContainsKey(text) Then
									IL_289:
									num2 = 31
									bitmap = O_O0OO.O0_00o.o0__o.(text)
								Else
									IL_29C:
									num2 = 33
									bitmap = ooO.OoO_0._oO00_o.(text)
									IL_2A8:
									num2 = 34
									If bitmap Is Nothing Then
										IL_2AF:
										num2 = 35
										bitmap = O_O0OO.O0_00o.o0__o.
									End If
									IL_2B9:
									num2 = 36
									O_O0OO.O0_00o.o0__o..Add(text, bitmap)
								End If
							End If
							IL_2CA:
							num2 = 37
							Me.OO_._.().SetCellImage(Me.OO_._.().Rows.Count - 1, 0, bitmap)
						End If
					End If
					IL_2ED:
					num2 = 38
				End While
				IL_2FC:
				num2 = 39
				CType(enumerator2, IDisposable).Dispose()
				IL_30C:
				num2 = 40
				If Operators.CompareString(Me.ooooOoo.0OOo0.().CurrentDir, "/", True) = 0 Then
					GoTo IL_39F
				End If
				IL_327:
				num2 = 41
				Me.OO_._.().AddItem("..", 1)
				IL_33C:
				num2 = 42
				Me.OO_._.().SetData(1, 3, 0)
				IL_353:
				num2 = 43
				Me.OO_._.().SetCellImage(1, 0, Foxtable.My.Resources.a.o___o.00Oo__.().ToBitmap())
				IL_36D:
				num2 = 44
				If Me.OO_._.().Rows.Count <= 2 Then
					GoTo IL_3CF
				End If
				IL_383:
				num2 = 45
				Me.OO_._.().Rows(2).Selected = True
				GoTo IL_3CF
				IL_39F:
				num2 = 47
				If Me.OO_._.().Rows.Count <= 1 Then
					GoTo IL_3CF
				End If
				IL_3B5:
				num2 = 48
				Me.OO_._.().Rows(1).Selected = True
				IL_3CF:
				num2 = 49
				Me.OO_._.().EndUpdate()
				IL_3DD:
				GoTo IL_4F7
				IL_3E2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_4B8:
				GoTo IL_4EC
				IL_4BA:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4CA:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4BA
			End Try
			IL_4EC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4F7:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600481F RID: 18463 RVA: 0x001E5758 File Offset: 0x001E3958
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SortColEventArgs)
			If Me.OO_._.().Row > 0 Then
				Me.OO_._.().Sort(1, 3)
				Me.OO_._.().ShowCell(Me.OO_._.().Row, Me.OO_._.().Col)
			End If
		End Sub

		' Token: 0x06004820 RID: 18464 RVA: 0x001E5798 File Offset: 0x001E3998
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
				If Not Me.ooooOoo.0OOo0.().Connect() Then
					GoTo IL_43C
				End If
				IL_19:
				num2 = 4
				If Me.OO_._.().Row <= 0 Then
					GoTo IL_43C
				End If
				IL_2C:
				num2 = 5
				If Operators.CompareString(Me.OO_._.()(Me.OO_._.().Row, 3).ToString(), "1", True) <> 0 Then
					GoTo IL_E3
				End If
				IL_5A:
				num2 = 6
				Dim text As String = Me.OO_._.()(Me.OO_._.().Row, 0).ToString()
				IL_79:
				num2 = 7
				If Not Me.o._O0o_.(Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + text) Then
					GoTo IL_43C
				End If
				IL_AC:
				num2 = 9
				Me.ooooOoo.0OOo0.().ChangeDir(text)
				IL_BB:
				num2 = 10
				Me.ooooOoo.0OOo0.(False)
				IL_C5:
				num2 = 11
				Me.oo.O_0_O00_O0_.().Value = Me.ooooOoo.0OOo0.().CurrentDir
				GoTo IL_43C
				IL_E3:
				num2 = 13
				If Operators.CompareString(Me.OO_._.()(Me.OO_._.().Row, 3).ToString(), "0", True) <> 0 Then
					GoTo IL_21D
				End If
				IL_112:
				num2 = 14
				Dim text2 As String = Me.ooooOoo.0OOo0.().CurrentDir
				IL_122:
				num2 = 15
				Dim array As String() = text2.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_13A:
				num2 = 16
				If array.Length <= 0 Then
					GoTo IL_1F5
				End If
				IL_147:
				num2 = 17
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1)
				IL_162:
				num2 = 18
				If Operators.CompareString(Me.ooooOoo.0OOo0.().RootDir, "", True) <= 0 Then
					GoTo IL_1C9
				End If
				IL_17E:
				num2 = 19
				If text2.Length >= Me.ooooOoo.0OOo0.().RootDir.Length OrElse Not Me.ooooOoo.0OOo0.().RootDir.StartsWith(text2) Then
					GoTo IL_1C9
				End If
				IL_1AE:
				num2 = 20
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_43C
				IL_1C9:
				num2 = 22
				If Not Me.o._O0o_.(text2) Then
					GoTo IL_43C
				End If
				IL_1D9:
				num2 = 24
				Me.ooooOoo.0OOo0.().ChangeDir(text2)
				IL_1E9:
				num2 = 25
				Me.ooooOoo.0OOo0.(False)
				GoTo IL_1FF
				IL_1F5:
				num2 = 27
				Me.ooooOoo.0OOo0.(False)
				IL_1FF:
				num2 = 28
				Me.oo.O_0_O00_O0_.().Value = Me.ooooOoo.0OOo0.().CurrentDir
				GoTo IL_43C
				IL_21D:
				num2 = 30
				If Operators.CompareString(Me.OO_._.()(Me.OO_._.().Row, 3).ToString(), "2", True) <> 0 Then
					GoTo IL_43C
				End If
				IL_24C:
				num2 = 31
				If Not Me.o_O0.O__.().Enabled Then
					GoTo IL_43C
				End If
				IL_25F:
				num2 = 32
				Dim c1FlexGrid As C1FlexGrid = Me.OO_._.()
				IL_26A:
				num2 = 33
				Dim text3 As String = Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + c1FlexGrid(c1FlexGrid.Row, 0).ToString()
				IL_2A8:
				num2 = 34
				Dim ftpdownloadEventArgs As FTPDownloadEventArgs = New FTPDownloadEventArgs(text3, Conversions.ToDate(c1FlexGrid(c1FlexGrid.Row, 1).ToString()), Me.ooooOoo.0OOo0.().FTPName)
				IL_2D8:
				num2 = 35
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", New Object() { ftpdownloadEventArgs }, True, "FTP", False)
				IL_2FD:
				num2 = 36
				If ftpdownloadEventArgs.Cancel Then
					GoTo IL_43C
				End If
				IL_30C:
				num2 = 38
				If Me.o_O0.O__.().FindRow(text3, 1, 0, False, True, False) <= 0 Then
					GoTo IL_33F
				End If
				IL_324:
				num2 = 39
				MessageBox.Show("此文件已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_43C
				IL_33F:
				num2 = 41
				Dim text4 As String = Me.oo.O_0_O00_O0_.().Text.Trim(New Char() { "\"c }) + "\" + text3.Replace("/", "\").Trim(New Char() { "\"c })
				IL_38A:
				num2 = 42
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text4)
				IL_39B:
				num2 = 43
				If OO_00oOO.FileSys.FileExists(parentPath) Then
					GoTo IL_3BB
				End If
				IL_3AC:
				num2 = 44
				OO_00oOO.FileSys.CreateDirectory(parentPath)
				IL_3BB:
				num2 = 45
				If Me.o_O0.O__.().FindRow(text4, 1, 4, False, True, False) >= 0 Then
					GoTo IL_423
				End If
				IL_3D3:
				num2 = 46
				Me.o_O0.O__.().AddItem(text3 + vbTab + c1FlexGrid(c1FlexGrid.Row, 2).ToString() + vbTab & "等待中" & vbTab + vbTab + text4 + vbTab & "0").UserData = "down"
				GoTo IL_439
				IL_423:
				num2 = 48
				MessageBox.Show("此文件已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_439:
				c1FlexGrid = Nothing
				IL_43C:
				GoTo IL_556
				IL_441:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_517:
				GoTo IL_54B
				IL_519:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_529:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_519
			End Try
			IL_54B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_556:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004821 RID: 18465 RVA: 0x001E5D20 File Offset: 0x001E3F20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o__o0O0_._0.(False)
		End Sub

		' Token: 0x06004822 RID: 18466 RVA: 0x001E5D2C File Offset: 0x001E3F2C
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If Me.ooooOoo.0OOo0.().Connect() Then
				Dim text As String = Me.oo.O_0_O00_O0_.().Text
				Dim c1FlexGrid As C1FlexGrid = Me.OO_._.()
				Dim num As Integer = c1FlexGrid.Rows.Count - 1
				For i As Integer = 1 To num
					If c1FlexGrid.Rows(i).Selected AndAlso Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", True) = 0 Then
						Dim text2 As String = Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + c1FlexGrid.GetData(i, 0).ToString()
						Dim ftpdownloadEventArgs As FTPDownloadEventArgs = New FTPDownloadEventArgs(text2, Conversions.ToDate(c1FlexGrid.GetData(i, 1).ToString()), Me.ooooOoo.0OOo0.().FTPName)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", New Object() { ftpdownloadEventArgs }, True, "FTP", False)
						If ftpdownloadEventArgs.CancelAll Then
							Exit For
						End If
						If Not ftpdownloadEventArgs.Cancel Then
							Dim text3 As String = c1FlexGrid.GetData(i, 0).ToString()
							If Me.o_O0.O__.().FindRow(text2, 1, 0, False, True, False) > 0 Then
								MessageBox.Show("文件[" + text3 + "]已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Else
								text3 = text.Trim(New Char() { "\"c }) + "\" + text2.Replace("/", "\").Trim(New Char() { "\"c })
								Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text3)
								If Not OO_00oOO.FileSys.FileExists(parentPath) Then
									OO_00oOO.FileSys.CreateDirectory(parentPath)
								End If
								If Me.o_O0.O__.().FindRow(text3, 1, 4, False, True, False) < 0 Then
									Me.o_O0.O__.().AddItem(String.Concat(New String() { text2 + vbTab + c1FlexGrid(i, 2).ToString() + vbTab & "等待中" & vbTab, vbTab, text3, vbTab, Interaction.IIf(A_0, 1, 0).ToString() })).UserData = "down"
								Else
									MessageBox.Show("文件[" + OO_00oOO.FileSys.GetName(text3) + "]已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End If
							End If
						End If
					End If
				Next
			End If
		End Sub

		' Token: 0x06004823 RID: 18467 RVA: 0x001E5FA4 File Offset: 0x001E41A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ooooOoo.0OOo0.().Connect() Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
				openFileDialog.Multiselect = True
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					For Each text As String In openFileDialog.FileNames
						Dim ftpuploadEventArgs As FTPUploadEventArgs = New FTPUploadEventArgs(text, Me.ooooOoo.0OOo0.().CurrentDir, Me.ooooOoo.0OOo0.().FTPName)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeUpload", New Object() { ftpuploadEventArgs }, True, "FTP", False)
						If ftpuploadEventArgs.CancelAll Then
							Exit For
						End If
						If Not ftpuploadEventArgs.Cancel Then
							Dim text2 As String = "/" + Me.ooooOoo.0OOo0.().CurrentDir.Trim(New Char() { "/"c }) + "/" + OO_00oOO.FileSys.GetName(text)
							Dim fileInfo As FileInfo = New FileInfo(text)
							If text2.StartsWith("//") Then
								text2 = text2.Substring(1)
							End If
							If Me.o_O0.O__.().FindRow(text, 1, 0, False, True, False) < 0 AndAlso Me.o_O0.O__.().FindRow(text2, 1, 4, False, True, False) < 0 Then
								Me.o_O0.O__.().AddItem(text + vbTab + Conversions.ToString(fileInfo.Length) + vbTab & "等待中" & vbTab + vbTab + text2).UserData = "up"
							Else
								MessageBox.Show("此文件已经在上传队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							End If
						End If
					Next
				End If
			End If
		End Sub

		' Token: 0x06004824 RID: 18468 RVA: 0x001E6124 File Offset: 0x001E4324
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ooooOoo.0OOo0.().Connect() Then
				Dim c1FlexGrid As C1FlexGrid = Me.OO_._.()
				If Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "0", True) <> 0 AndAlso MessageBox.Show("确定要删除选定项目吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
					Dim num As Integer = c1FlexGrid.Rows.Count - 1
					Dim num2 As Integer
					For i As Integer = 1 To num
						If c1FlexGrid.Rows(i).Selected AndAlso (Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "1", True) = 0 OrElse Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", True) = 0) Then
							Dim str As String = c1FlexGrid.GetData(i, 0).ToString()
							Dim a_ As Boolean = Operators.CompareString(Me.OO_._.()(i, 3).ToString(), "1", True) = 0
							Dim ftpdeleteEventargs As FTPDeleteEventargs = New FTPDeleteEventargs(Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + str, a_, Conversions.ToDate(c1FlexGrid.GetData(i, 1).ToString()), Me.ooooOoo.0OOo0.().FTPName)
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDelete", New Object() { ftpdeleteEventargs }, True, "FTP", False)
							If ftpdeleteEventargs.CancelAll Then
								Exit For
							End If
							If Not ftpdeleteEventargs.Cancel Then
								If Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "1", True) = 0 Then
									Dim dirName As String = c1FlexGrid.GetData(i, 0).ToString()
									Me.ooooOoo.0OOo0.().DeleteDir(dirName, True)
								ElseIf Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", True) = 0 Then
									Dim fileName As String = c1FlexGrid.GetData(i, 0).ToString()
									Me.ooooOoo.0OOo0.().DeleteFile(fileName)
								End If
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDelete", New Object() { ftpdeleteEventargs }, True, "FTP", False)
								num2 += 1
							End If
						End If
					Next
					If num2 > 0 Then
						Me.ooooOoo.0OOo0.(True)
					End If
				End If
			End If
		End Sub

		' Token: 0x06004825 RID: 18469 RVA: 0x001E634C File Offset: 0x001E454C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ooooOoo.0OOo0.().Connect() Then
				Dim c1FlexGrid As C1FlexGrid = Me.OO_._.()
				If c1FlexGrid.Row > 0 AndAlso (Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "1", True) = 0 OrElse Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "2", True) = 0) Then
					Dim text As String = Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + c1FlexGrid.GetData(c1FlexGrid.Row, 0).ToString()
					Dim a_ As DateTime = Conversions.ToDate(c1FlexGrid.GetData(c1FlexGrid.Row, 1).ToString())
					Dim a_2 As Boolean = Operators.CompareString(Me.OO_._.()(Me.OO_._.().Row, 3).ToString(), "1", True) = 0
					Dim ftprenameEventArgs As FTPRenameEventArgs = New FTPRenameEventArgs(text, "", a_2, a_, Me.ooooOoo.0OOo0.().FTPName)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeRename", New Object() { ftprenameEventArgs }, True, "FTP", False)
					If Not ftprenameEventArgs.Cancel Then
						Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("重命名", "输入新名称:", c1FlexGrid.GetData(c1FlexGrid.Row, 0).ToString())
						If o_u3000_u.ShowDialog() = DialogResult.OK AndAlso Operators.CompareString(text, o_u3000_u.Value, True) <> 0 AndAlso Operators.CompareString(o_u3000_u.Value, "", True) > 0 Then
							Dim text2 As String = o_u3000_u.Value
							If Me.ooooOoo.0OOo0.().Rename(text, text2) Then
								Dim currentDir As String = Me.ooooOoo.0OOo0.().CurrentDir
								If Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(currentDir) Then
									Me.ooooOoo.0OOo0.(True)
								End If
								Dim fixed As Integer = c1FlexGrid.Rows.Fixed
								Dim num As Integer = c1FlexGrid.Rows.Count - 1
								For i As Integer = fixed To num
									If Operators.CompareString(c1FlexGrid.GetData(i, 0).ToString(), text2, True) = 0 Then
										c1FlexGrid.Row = i
										Exit For
									End If
								Next
							End If
							ftprenameEventArgs = New FTPRenameEventArgs(text, text2, a_2, a_, Me.ooooOoo.0OOo0.().FTPName)
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterRename", New Object() { ftprenameEventArgs }, True, "FTP", False)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06004826 RID: 18470 RVA: 0x001E65A3 File Offset: 0x001E47A3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06004827 RID: 18471 RVA: 0x001E65AC File Offset: 0x001E47AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ooooOoo.0OOo0.().Connect() Then
				Me.OO_._.()
				Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("新建目录", "输入目录名称:", "")
				If o_u3000_u.ShowDialog() = DialogResult.OK AndAlso Operators.CompareString(o_u3000_u.Value, "", True) > 0 Then
					Dim a_ As String = Me.ooooOoo.0OOo0.().CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + o_u3000_u.Value
					Dim ftpfolderEventArgs As FTPFolderEventArgs = New FTPFolderEventArgs(a_, Me.ooooOoo.0OOo0.().FTPName)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCreateFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
					If Not ftpfolderEventArgs.Cancel Then
						If Me.ooooOoo.0OOo0.().MakeDir(o_u3000_u.Value) Then
							Me.ooooOoo.0OOo0.(True)
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterCreateFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06004828 RID: 18472 RVA: 0x001E66AC File Offset: 0x001E48AC
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean)
			Dim num As Integer = Me.o_O0.O__.().Rows.Count - 1
			For i As Integer = 1 To num
				If Operators.CompareString(Me.o_O0.O__.().GetData(i, 0).ToString(), A_0, True) = 0 Then
					If A_1 Then
						Me.o_O0.O__.()(i, 2) = "下载中断"
					Else
						Me.o_O0.O__.()(i, 2) = "下载失败"
					End If
					Me.o_O0.O__.()(i, 3) = ""
					Me.o_O0.O__.().Rows(i).UserData = "down"
				End If
			Next
		End Sub

		' Token: 0x06004829 RID: 18473 RVA: 0x001E674C File Offset: 0x001E494C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oo_.OOO_., New Object() { A_0 })
			End If
			Dim ftpdownloadEventArgs As FTPDownloadEventArgs = New FTPDownloadEventArgs(A_0, DateTime.MinValue, Me.ooooOoo.0OOo0.().FTPName)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDownload", New Object() { ftpdownloadEventArgs }, True, "FTP", False)
		End Sub

		' Token: 0x0600482A RID: 18474 RVA: 0x001E67C8 File Offset: 0x001E49C8
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Long, A_2 As Long, A_3 As Long, A_4 As TimeSpan)
			Dim c1FlexGrid As C1FlexGrid = Me.o_O0.O__.()
			Dim num As Integer = c1FlexGrid.FindRow(A_0, 1, 0, False, True, False)
			If num > 0 Then
				c1FlexGrid(num, 2) = Math.Round(CDbl((A_2 + A_3)) / CDbl(A_1), 4)
				c1FlexGrid(num, 3) = CInt(Math.Round(CDbl(A_3) / A_4.TotalSeconds / 1024.0))
			End If
		End Sub

		' Token: 0x0600482B RID: 18475 RVA: 0x001E6830 File Offset: 0x001E4A30
		Private Sub <<EMPTY_NAME>>()
			Me.ooooOoo.0OOo0.(False)
		End Sub

		' Token: 0x0600482C RID: 18476 RVA: 0x001E683C File Offset: 0x001E4A3C
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oO0.O__0_o., New Object() { String.Concat(New String() { "[", Strings.Format(DateTime.Now, "HH:mm:ss"), "] ", A_0, ",", A_1, vbCrLf }) })
			End If
		End Sub

		' Token: 0x0600482D RID: 18477 RVA: 0x001E68C8 File Offset: 0x001E4AC8
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oO0.O__0_o., New Object() { String.Concat(New String() { "[", Strings.Format(DateTime.Now, "HH:mm:ss"), "] ", A_0, vbCrLf }) })
			End If
		End Sub

		' Token: 0x0600482E RID: 18478 RVA: 0x001E6946 File Offset: 0x001E4B46
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooooOoo.0OOo0.(True)
		End Sub

		' Token: 0x0600482F RID: 18479 RVA: 0x001E694F File Offset: 0x001E4B4F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Delete Then
				Me.O._o__.().PerformClick()
			End If
		End Sub

		' Token: 0x06004830 RID: 18480 RVA: 0x001E6968 File Offset: 0x001E4B68
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If A_1.Row > 0 AndAlso A_1.Col = 2 Then
				Dim text As String = A_1.Text
				If Operators.CompareString(text, "", True) > 0 AndAlso Versioned.IsNumeric(text) Then
					Dim num As Long = Conversions.ToLong(text)
					If num = 0L Then
						A_1.Text = "0 KB"
						Return
					End If
					If num <= 1024L Then
						A_1.Text = "1 KB"
						Return
					End If
					A_1.Text = Strings.Format(CInt(Math.Round(CDbl(num) / 1024.0)), "#,##0") + " KB"
				End If
			End If
		End Sub

		' Token: 0x06004831 RID: 18481 RVA: 0x001E6A04 File Offset: 0x001E4C04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.o_O0.O__.()
			If c1FlexGrid.Row > 0 Then
				If Operators.CompareString(c1FlexGrid.Rows(c1FlexGrid.Row).UserData.ToString(), "{down}", True) = 0 Then
					If MessageBox.Show("文件正在下载中，确定要终止下载并从队列中移除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
						Me.oo.O_0_O00_O0_.().o_0_.__0OO.()
						c1FlexGrid.Rows.Remove(c1FlexGrid.Row)
					End If
				ElseIf Operators.CompareString(c1FlexGrid.Rows(c1FlexGrid.Row).UserData.ToString(), "{up}", True) = 0 Then
					If MessageBox.Show("文件正在上传中，确定要终止上传并从队列中移除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
						Me.oo.O_0_O00_O0_.().o_0_.__0OO.()
						c1FlexGrid.Rows.Remove(c1FlexGrid.Row)
					End If
				Else
					c1FlexGrid.Rows.Remove(c1FlexGrid.Row)
				End If
			End If
		End Sub

		' Token: 0x06004832 RID: 18482 RVA: 0x001E6AF4 File Offset: 0x001E4CF4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If A_1.Row > 0 AndAlso A_1.Col = 1 Then
				Dim text As String = A_1.Text
				If Operators.CompareString(text, "", True) > 0 AndAlso Versioned.IsNumeric(text) Then
					Dim num As Long = Conversions.ToLong(text)
					If num = 0L Then
						A_1.Text = "0 KB"
						Return
					End If
					If num <= 1024L Then
						A_1.Text = "1 KB"
						Return
					End If
					A_1.Text = Strings.Format(CInt(Math.Round(CDbl(num) / 1024.0)), "#,##0") + " KB"
					Return
				End If
			ElseIf A_1.Row > 0 AndAlso A_1.Col = 0 Then
				If Operators.CompareString(A_1.Text, "", True) > 0 Then
					A_1.Text = OO_00oOO.FileSys.GetName(A_1.Text)
				End If
				If Me.o_O0.O__.().Rows(A_1.Row).UserData.ToString().IndexOf("down") >= 0 Then
					A_1.Image = Foxtable.My.Resources.a.OoOoOOOOOO.0_.()
					Return
				End If
				If Me.o_O0.O__.().Rows(A_1.Row).UserData.ToString().IndexOf("up") >= 0 Then
					A_1.Image = Foxtable.My.Resources.a.OO.oO__O00.()
					Return
				End If
			ElseIf A_1.Row > 0 AndAlso A_1.Col = 3 Then
				If Operators.CompareString(A_1.Text, "", True) > 0 Then
					A_1.Text += " KB/S"
					Return
				End If
			ElseIf A_1.Row > 0 AndAlso A_1.Col = 2 Then
				If Versioned.IsNumeric(A_1.Text) Then
					Dim num2 As Double = Conversions.ToDouble(A_1.Text)
					A_1.Text = Conversions.ToString(Math.Round(num2 * 100.0, 2)) + "%"
					A_1.DrawCell(3)
					Dim width As Integer = CInt(Math.Round(CDbl((A_1.Bounds.Width - 2)) * num2))
					A_1.Graphics.FillRectangle(Brushes.Lavender, A_1.Bounds.X + 1, A_1.Bounds.Y + 1, width, A_1.Bounds.Height - 2)
					A_1.DrawCell(4)
					A_1.Handled = True
					Return
				End If
				If A_1.Text.EndsWith("失败") OrElse A_1.Text.EndsWith("中断") Then
					A_1.Style = Me.o_O0.O__.().Styles("error")
				End If
			End If
		End Sub

		' Token: 0x06004833 RID: 18483 RVA: 0x001E6DA0 File Offset: 0x001E4FA0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
			Me.oo.O_0_O00_O0_.().Enabled = False
			RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.o.oO0000.
			RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Me.o._0oO.
			If Me.oo.O_0_O00_O0_.().Connected Then
				Me.oo.O_0_O00_O0_.().Connected = False
				Me.oo.O_0_O00_O0_.().Close()
			End If
		End Sub

		' Token: 0x06004834 RID: 18484 RVA: 0x001E6E10 File Offset: 0x001E5010
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If Me.oo.O_0_O00_O0_.().AsyncState <> Oo_0.OOoo0_OO__._o. Then
				If MessageBox.Show("有文件未下载完成，是否退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					Me.oo.O_0_O00_O0_.().Enabled = False
					Me.oo.O_0_O00_O0_.().o_0_.__0OO.()
					Return
				End If
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06004835 RID: 18485 RVA: 0x001E6E60 File Offset: 0x001E5060
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.ooooOoo.0OOo0.().Connected OrElse Not Me.oo.oo__o_. OrElse (DateTime.Now - Me.oo.oo__o_.).TotalSeconds <= 3.0 Then
					GoTo IL_8E
				End If
				IL_41:
				num2 = 3
				If Not NetworkInterface.GetIsNetworkAvailable() Then
					GoTo IL_534
				End If
				IL_4D:
				num2 = 4
				If Not Me.ooooOoo.0OOo0.().Connect() Then
					GoTo IL_6A
				End If
				IL_5C:
				num2 = 5
				Me.oo.oo__o_. = False
				GoTo IL_534
				IL_6A:
				num2 = 7
				Me.oo.oo__o_. = DateTime.Now.AddSeconds(8.0)
				GoTo IL_534
				IL_8E:
				num2 = 9
				If Not Me.ooooOoo.0OOo0.().Connected Then
					GoTo IL_534
				End If
				IL_A1:
				num2 = 11
				If Me.oo.O_0_O00_O0_.().AsyncState <> Oo_0.OOoo0_OO__._o. Then
					GoTo IL_534
				End If
				IL_B4:
				num2 = 12
				Dim num3 As Integer = -1
				IL_BA:
				num2 = 13
				Dim num4 As Integer = Me.o_O0.O__.().Rows.Count - 1
				For i As Integer = 1 To num4
					IL_D6:
					num2 = 14
					If Not Me.o_O0.O__.().GetData(i, 2).ToString().EndsWith("中断") AndAlso Not Me.o_O0.O__.().GetData(i, 2).ToString().EndsWith("失败") Then
						IL_117:
						num2 = 15
						num3 = i
						Exit For
					End If
					IL_120:
					num2 = 17
				Next
				IL_12F:
				num2 = 18
				If num3 <> -1 Then
					GoTo IL_18D
				End If
				IL_137:
				num2 = 19
				Dim num5 As Integer = Me.o_O0.O__.().Rows.Count - 1
				For j As Integer = 1 To num5
					IL_153:
					num2 = 20
					If Me.o_O0.O__.().GetData(j, 2).ToString().EndsWith("中断") Then
						IL_175:
						num2 = 21
						num3 = j
						Exit For
					End If
					IL_17E:
					num2 = 23
				Next
				IL_18D:
				num2 = 24
				If num3 <= 0 Then
					GoTo IL_500
				End If
				IL_198:
				num2 = 25
				If Me.oo.O_0_O00_O0_.().Connected Then
					GoTo IL_1BC
				End If
				IL_1A8:
				num2 = 26
				Me.oo.O_0_O00_O0_.().Connect()
				GoTo IL_534
				IL_1BC:
				num2 = 28
				Dim a_ As String = Me.o_O0.O__.().GetData(num3, 0).ToString()
				IL_1D4:
				num2 = 29
				Dim text As String = Me.o_O0.O__.().GetData(num3, 4).ToString()
				IL_1EC:
				num2 = 30
				If Operators.CompareString(Me.o_O0.O__.().Rows(num3).UserData.ToString(), "down", True) <> 0 Then
					GoTo IL_24F
				End If
				IL_218:
				num2 = 31
				Me.o_O0.O__.().Rows(num3).UserData = "{down}"
				IL_237:
				num2 = 32
				Me.oo.O_0_O00_O0_.().O_O0Ooo_00.o.(a_, text, False)
				GoTo IL_534
				IL_24F:
				num2 = 34
				If Operators.CompareString(Me.o_O0.O__.().Rows(num3).UserData.ToString(), "up", True) <> 0 Then
					GoTo IL_45C
				End If
				IL_27E:
				num2 = 35
				Me.o_O0.O__.().Rows(num3).UserData = "{up}"
				IL_29D:
				num2 = 36
				If Me.oo.oo__o_. = k2.o_0O.O_oO_00_OO_.0. OrElse Not Me.oo.O_0_O00_O0_.().FileExists(text) Then
					GoTo IL_3E3
				End If
				IL_2BE:
				num2 = 37
				If Me.oo.oo__o_. <> k2.o_0O.o_oO_0oO_0.0. Then
					GoTo IL_2E5
				End If
				IL_2CA:
				num2 = 38
				Me.o_O0.O__.().Rows.Remove(num3)
				GoTo IL_534
				IL_2E5:
				num2 = 40
				If Me.o_O0.O__.().Rows.Count <> 2 Then
					GoTo IL_347
				End If
				IL_2FB:
				num2 = 41
				If MessageBox.Show("文件""" + OO_00oOO.FileSys.GetName(text) + """已经存在，是否覆盖?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
					GoTo IL_3E3
				End If
				IL_32C:
				num2 = 42
				Me.o_O0.O__.().Rows.Remove(num3)
				GoTo IL_534
				IL_347:
				num2 = 45
				Dim o_u3000_u3002_u As O\u3000\u3002\u3002 = New O\u3000\u3002\u3002(Me)
				IL_352:
				num2 = 46
				o_u3000_u3002_u.OO__O_0O0.0oO_.().Text = "文件" + OO_00oOO.FileSys.GetName(text) + o_u3000_u3002_u.OO__O_0O0.0oO_.().Text
				IL_383:
				num2 = 47
				o_u3000_u3002_u.ShowDialog()
				IL_38E:
				num2 = 48
				If Me.oo.oo__o_. <> k2.o_0O.Oo000._0OO_O_. AndAlso Me.oo.oo__o_. <> k2.o_0O.o_oO_0oO_0.0. Then
					GoTo IL_3BE
				End If
				IL_3A3:
				num2 = 49
				Me.o_O0.O__.().Rows.Remove(num3)
				GoTo IL_534
				IL_3BE:
				num2 = 51
				If Me.oo.oo__o_. <> k2.o_0O.o.oO_000. Then
					GoTo IL_3E3
				End If
				IL_3CA:
				num2 = 52
				Me.o_O0.O__.().Rows.Count = 1
				GoTo IL_534
				IL_3E3:
				num2 = 54
				Me.oo.O_0_O00_O0_.().o0O_0_.00_oooo.(a_, text, False)
				IL_3F6:
				num2 = 55
				If Operators.CompareString(Me.ooooOoo.0OOo0.().CurrentDir, OO_00oOO.FileSys.GetParentPath(text).Replace("\", "/"), True) = 0 Then
					GoTo IL_534
				End If
				IL_42A:
				num2 = 56
				If Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(Me.ooooOoo.0OOo0.().CurrentDir) Then
					GoTo IL_534
				End If
				IL_44D:
				num2 = 57
				Me.ooooOoo.0OOo0.(True)
				GoTo IL_534
				IL_45C:
				num2 = 59
				If Not Me.o_O0.O__.().Rows(num3).UserData.ToString().StartsWith("up ") Then
					GoTo IL_534
				End If
				IL_48A:
				num2 = 60
				Dim value As String = Me.o_O0.O__.().Rows(num3).UserData.ToString().Substring(3)
				IL_4B1:
				num2 = 61
				Dim d As DateTime = Conversions.ToDate(value)
				IL_4BD:
				num2 = 62
				If(DateTime.Now - d).TotalSeconds <= 30.0 Then
					GoTo IL_534
				End If
				IL_4DF:
				num2 = 63
				Me.o_O0.O__.().Rows(num3).UserData = "up"
				GoTo IL_534
				IL_500:
				num2 = 65
				If Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(Me.ooooOoo.0OOo0.().CurrentDir) Then
					GoTo IL_52A
				End If
				IL_520:
				num2 = 66
				Me.ooooOoo.0OOo0.(True)
				IL_52A:
				num2 = 67
				Me.oo.oo__o_. = k2.o_0O.oo.oo__o_.
				IL_534:
				GoTo IL_696
				IL_539:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_657:
				GoTo IL_68B
				IL_659:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_669:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_659
			End Try
			IL_68B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_696:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004836 RID: 18486 RVA: 0x001E7528 File Offset: 0x001E5728
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NetworkAvailabilityEventArgs)
			Me.oo.oo__o_. = True
			Me.ooooOoo.0OOo0.().Connected = False
			Me.oo.O_0_O00_O0_.().Connected = False
			Me.oo.oo__o_. = DateTime.Now
		End Sub

		' Token: 0x06004837 RID: 18487 RVA: 0x001E7554 File Offset: 0x001E5754
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oo.oo__o_. = True
			Me.ooooOoo.0OOo0.().Connected = False
			Me.oo.O_0_O00_O0_.().Connected = False
			Me.oo.oo__o_. = DateTime.Now
		End Sub

		' Token: 0x06004838 RID: 18488 RVA: 0x001E7580 File Offset: 0x001E5780
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim num As Integer = Me.o_O0.O__.().Rows.Count - 1
			For i As Integer = 1 To num
				If Operators.CompareString(Me.o_O0.O__.().GetData(i, 0).ToString(), A_0, True) = 0 Then
					Me.o_O0.O__.()(i, 2) = "上传中断"
					Me.o_O0.O__.()(i, 3) = ""
					Me.o_O0.O__.().Rows(i).UserData = "up " + Conversions.ToString(DateTime.Now)
				End If
			Next
		End Sub

		' Token: 0x06004839 RID: 18489 RVA: 0x001E7618 File Offset: 0x001E5818
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oo_.OOO_., New Object() { A_0 })
			End If
			Dim key As String = OO_00oOO.FileSys.GetParentPath(A_1).Replace("\", "/")
			If Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(key) Then
				Me.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..Remove(key)
			End If
			Dim ftpuploadEventArgs As FTPUploadEventArgs = New FTPUploadEventArgs(A_0, OO_00oOO.FileSys.GetParentPath(A_1), Me.ooooOoo.0OOo0.().FTPName)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterUpload", New Object() { ftpuploadEventArgs }, True, "FTP", False)
		End Sub

		' Token: 0x0600483A RID: 18490 RVA: 0x001E76D7 File Offset: 0x001E58D7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Process.Start(Me.oo.O_0_O00_O0_.().Text + "\")
		End Sub

		' Token: 0x0600483B RID: 18491 RVA: 0x001E76F4 File Offset: 0x001E58F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o__o0O0_._0.(True)
		End Sub

		' Token: 0x0600483C RID: 18492 RVA: 0x001E7700 File Offset: 0x001E5900
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim array As String() = Me.oo.O_0_O00_O0_.().Text.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries)
			Me.oo.O_0_O00_O0_.().Items.Clear()
			Me.oo.O_0_O00_O0_.().Items.Add("/")
			Dim text As String = "/"
			For Each str As String In array
				text = text + str + "/"
				Me.oo.O_0_O00_O0_.().Items.Add(text)
			Next
		End Sub

		' Token: 0x0600483D RID: 18493 RVA: 0x001E7787 File Offset: 0x001E5987
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x0600483E RID: 18494 RVA: 0x001E7790 File Offset: 0x001E5990
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			A_1.Handled = True
		End Sub

		' Token: 0x0600483F RID: 18495 RVA: 0x001E779C File Offset: 0x001E599C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO_._.().Focus()
			Dim text As String = Me.oo.O_0_O00_O0_.().SelectedItem.ToString()
			If Operators.CompareString(Me.ooooOoo.0OOo0.().CurrentDir.Trim(New Char() { "/"c }), text.Trim(New Char() { "/"c }), True) <> 0 Then
				If Operators.CompareString(Me.ooooOoo.0OOo0.().RootDir, "", True) > 0 AndAlso text.Length < Me.ooooOoo.0OOo0.().RootDir.Length AndAlso Me.ooooOoo.0OOo0.().RootDir.StartsWith(text) Then
					Me.oo.O_0_O00_O0_.().SelectedItem = Me.ooooOoo.0OOo0.().CurrentDir + "/"
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Me.o._O0o_.(text) Then
					Me.ooooOoo.0OOo0.().ChangeDir(text)
					Me.ooooOoo.0OOo0.(False)
				End If
			End If
		End Sub

		' Token: 0x06004840 RID: 18496 RVA: 0x001E7894 File Offset: 0x001E5A94
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim ftpfolderEventArgs As FTPFolderEventArgs = New FTPFolderEventArgs(A_0, Me.ooooOoo.0OOo0.().FTPName)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", New Object() { ftpfolderEventArgs }, True, "FTP", False)
			Return Not ftpfolderEventArgs.Cancel
		End Function

		' Token: 0x04001D62 RID: 7522
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001D63 RID: 7523
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001D64 RID: 7524
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D65 RID: 7525
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D66 RID: 7526
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D67 RID: 7527
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D68 RID: 7528
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D69 RID: 7529
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001D6A RID: 7530
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D6B RID: 7531
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001D6C RID: 7532
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04001D6D RID: 7533
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001D6E RID: 7534
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001D6F RID: 7535
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D70 RID: 7536
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D71 RID: 7537
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001D72 RID: 7538
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001D73 RID: 7539
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04001D74 RID: 7540
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04001D75 RID: 7541
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D76 RID: 7542
		Friend <<EMPTY_NAME>> As k2.o_0O

		' Token: 0x04001D77 RID: 7543
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D78 RID: 7544
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04001D79 RID: 7545
		Private a As Integer

		' Token: 0x02000444 RID: 1092
		' (Invoke) Token: 0x06004844 RID: 18500
		Public Delegate Sub O_Oo(A_0 As String)

		' Token: 0x02000445 RID: 1093
		' (Invoke) Token: 0x06004848 RID: 18504
		Public Delegate Sub OooOO_o(A_0 As String)

		' Token: 0x02000446 RID: 1094
		Public Enum o_0O
			' Token: 0x04001D7B RID: 7547
			<<EMPTY_NAME>>
			' Token: 0x04001D7C RID: 7548
			<<EMPTY_NAME>>
			' Token: 0x04001D7D RID: 7549
			<<EMPTY_NAME>>
			' Token: 0x04001D7E RID: 7550
			<<EMPTY_NAME>>
			' Token: 0x04001D7F RID: 7551
			<<EMPTY_NAME>>
			' Token: 0x04001D80 RID: 7552
			<<EMPTY_NAME>>
		End Enum
	End Class
End Namespace
