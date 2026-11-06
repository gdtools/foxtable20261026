Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000192 RID: 402
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class f4
		Inherits Form

		' Token: 0x0600128A RID: 4746 RVA: 0x00071244 File Offset: 0x0006F444
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0o._O. IsNot Nothing Then
					Me.o0o._O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600128B RID: 4747 RVA: 0x00071284 File Offset: 0x0006F484
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0o._O. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(f4))
			Me.o0.00.(New SplitContainer())
			Me.O0O.00_O.(New OO___OO0O_0())
			Me.O0O.00_O.(New C1DockingTabPage())
			Me.Oo.OO__.(New o0ooo_0_00oO())
			Me.oOO0o.OO0.(New ImageList(Me.o0o._O.))
			Me.O0O.0o.(New C1DockingTabPage())
			Me.O0O.00_O.(New o0ooo_0_00oO())
			Me.o_0_.o00_.(New Label())
			Me.Oo.OO__.(New OO___OO0O_0())
			Me.Oo.OO__.(New C1DockingTabPage())
			Me.O.Oo_O0.(New SplitContainer())
			Me.oOO0o.OO0.(New Oo0O())
			Me.o0.oo_o__00O.(New C1Button())
			Me.o0OoO0.o0__.(New C1Button())
			Me.O___.__OOOOOO0.(New Panel())
			Me.oOO0o.OO0.(New Label())
			Me.oOOO.o0_Oo00O.(New Panel())
			Me.O0O._O_oO0.(New Label())
			Me.O_o0_o__.000.(New Panel())
			Me.o0o_O00_.o.(New Label())
			Me.OO0Oo_.0oO_.(New Label())
			Me.oOO_._0_0o_0.(New C1Button())
			Me.O0.OoooO.(New C1Button())
			Me.OO0oOOO._O_.(New C1Button())
			Me.OO0o.O.(New C1Button())
			Me.o0_O.O.(New C1Button())
			Me.oOO0o_.o_.(New C1Button())
			Me.O00Oo_o.00_oO.(New C1Button())
			Me.O_0.oOo_o0OO0.(New C1Button())
			Me.O.Oo_O0.(New C1TextBox())
			Me.O_0O.Oo.(New C1DockingTabPage())
			Me.O___.__OOOOOO0.(New RadioButton())
			Me.oOOO.o0_Oo00O.(New RadioButton())
			Me.O_o0_o__.000.(New RadioButton())
			Me.o0.00.(New C1TextBox())
			Me.O0O0_0o0_O_.00.(New C1Button())
			Me.OOoO0o0oo.o_.(New C1Button())
			Me.OOo.__o_o.(New C1Button())
			Me.oo0O__.o_OOo.(New C1Button())
			Me.O0O._O_oO0.(New Oo0O())
			Me.O.Oo_O0.(New ToolTip(Me.o0o._O.))
			Me.oO.__0.(New ContextMenuStrip(Me.o0o._O.))
			Me.O0_o0._oO.(New ToolStripMenuItem())
			Me.OO0Oo_.0oO_.(New ToolStripMenuItem())
			Me.OO_0O_0o_._o0.(New ContextMenuStrip(Me.o0o._O.))
			Me.OO0O0.O__0oo.(New ToolStripMenuItem())
			Me.o_0_.o00_.(New ToolStripMenuItem())
			Me.OoOo0_O0oO.000.(New ContextMenuStrip(Me.o0o._O.))
			Me.oO.__0.(New ToolStripMenuItem())
			Me.o.oo00oO0O0oO.(New ToolStripMenuItem())
			Me.ooo0.o.(New ToolStripSeparator())
			Me.ooo0.o.(New ToolStripMenuItem())
			Me.O.Oo_O0.(New System.Windows.Forms.Timer(Me.o0o._O.))
			Me.O0_o0._oO.(New ContextMenuStrip(Me.o0o._O.))
			Me.o0o_.0oOo.(New ToolStripMenuItem())
			Me.o_o0_.0o0ooO.(New ToolStripMenuItem())
			Me.O_o0_o__.000.(New ContextMenuStrip(Me.o0o._O.))
			Me.OoOo_._0o.(New ToolStripMenuItem())
			Me.O._OoO.(New ToolStripMenuItem())
			Me.OO.O00o0oo_O.(New ToolStripMenuItem())
			Me.O._o_O0O.().Panel1.SuspendLayout()
			Me.O._o_O0O.().Panel2.SuspendLayout()
			Me.O._o_O0O.().SuspendLayout()
			CType(Me.oOOoo._.(), ISupportInitialize).BeginInit()
			Me.oOOoo._.().SuspendLayout()
			Me.ooO.0o00__0.().SuspendLayout()
			CType(Me.Oo.Oo00__oooo.(), ISupportInitialize).BeginInit()
			Me.OO0_O0.o.().SuspendLayout()
			CType(Me.O_0oOOO_.OO.(), ISupportInitialize).BeginInit()
			CType(Me.ooO.0o00__0.(), ISupportInitialize).BeginInit()
			Me.ooO.0o00__0.().SuspendLayout()
			Me.O_o._o0___.().SuspendLayout()
			Me.o.o00_0O0o.().Panel1.SuspendLayout()
			Me.o.o00_0O0o.().Panel2.SuspendLayout()
			Me.o.o00_0O0o.().SuspendLayout()
			CType(Me.O_0oOOO_.OO.(), ISupportInitialize).BeginInit()
			Me.oO____oooO.0_O.().BeginInit()
			Me.oOOoo._.().BeginInit()
			Me.o.o00_0O0o.().SuspendLayout()
			Me.o_oO__.0.().SuspendLayout()
			Me.o.0_o0_00.().SuspendLayout()
			Me.o_O.O000o__.().BeginInit()
			Me.oOO____o.0o.().BeginInit()
			Me.Oo_._O0.().BeginInit()
			Me.oOo00_.0Oo.().BeginInit()
			Me.Oo_oo._O_.().BeginInit()
			Me.oOO._O.().BeginInit()
			Me.O_OO0.oo.().BeginInit()
			Me.OO0_O0.o.().BeginInit()
			Me.Oo.Oo00__oooo.().SuspendLayout()
			CType(Me.Oo.Oo00__oooo.(), ISupportInitialize).BeginInit()
			Me.O.ooO_0_.().SuspendLayout()
			Me.ooOoo___0.oO0.().SuspendLayout()
			Me.O0oO_Oo0oO_.o.().SuspendLayout()
			Me.o_oO__.0.().SuspendLayout()
			Me.o.0_o0_00.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.O._o_O0O.().Dock = DockStyle.Fill
			Me.O._o_O0O.().Location = New Point(0, 0)
			Me.O._o_O0O.().Name = "SplitContainer1"
			Me.O._o_O0O.().Panel1.Controls.Add(Me.oOOoo._.())
			Me.O._o_O0O.().Panel2.Controls.Add(Me.O.O_O0__0_0.())
			Me.O._o_O0O.().Panel2.Controls.Add(Me.ooO.0o00__0.())
			Me.O._o_O0O.().Size = New Size(825, 555)
			Me.O._o_O0O.().SplitterDistance = 193
			Me.O._o_O0O.().TabIndex = 0
			Me.oOOoo._.().Controls.Add(Me.ooO.0o00__0.())
			Me.oOOoo._.().Controls.Add(Me.OO0_O0.o.())
			Me.oOOoo._.().Dock = DockStyle.Fill
			Me.oOOoo._.().Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oOOoo._.().ImageList = Me.O_0oOOO_.OO.()
			Me.oOOoo._.().Location = New Point(0, 0)
			Me.oOOoo._.().Name = "C1DockingTab1"
			Me.oOOoo._.().Size = New Size(193, 555)
			Me.oOOoo._.().TabIndex = 0
			Me.oOOoo._.().TabsCanFocus = False
			Me.oOOoo._.().TabsSpacing = 5
			Me.oOOoo._.().TabStyle = 6
			Me.oOOoo._.().VisualStyle = 5
			Me.oOOoo._.().VisualStyleBase = 5
			Me.ooO.0o00__0.().Controls.Add(Me.Oo.Oo00__oooo.())
			Me.ooO.0o00__0.().ImageIndex = 3
			Me.ooO.0o00__0.().Location = New Point(1, 25)
			Me.ooO.0o00__0.().Name = "C1DockingTabPage2"
			Me.ooO.0o00__0.().Size = New Size(191, 529)
			Me.ooO.0o00__0.().TabIndex = 0
			Me.ooO.0o00__0.().Text = "好友"
			Me.Oo.Oo00__oooo.().AutoScrollMinSize = New Size(0, 20)
			Me.Oo.Oo00__oooo.().BackColor = Color.FromArgb(239, 246, 253)
			Me.Oo.Oo00__oooo.().Dock = DockStyle.Fill
			Me.Oo.Oo00__oooo.().ImageList = Me.O_0oOOO_.OO.()
			Me.Oo.Oo00__oooo.().Location = New Point(0, 0)
			Me.Oo.Oo00__oooo.().Name = "c1UserGroups"
			Me.Oo.Oo00__oooo.().Padding = New Padding(5, 15, 5, 5)
			Me.Oo.Oo00__oooo.().PageOffset = 5
			Me.Oo.Oo00__oooo.().PagePadding = New Padding(10)
			Me.Oo.Oo00__oooo.().Size = New Size(191, 529)
			Me.Oo.Oo00__oooo.().TabIndex = 0
			Me.Oo.Oo00__oooo.().VisualStyle = 0
			Me.Oo.Oo00__oooo.().VisualStyleBase = 2
			Me.O_0oOOO_.OO.().ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), ImageListStreamer)
			Me.O_0oOOO_.OO.().TransparentColor = Color.Transparent
			Me.O_0oOOO_.OO.().Images.SetKeyName(0, "online")
			Me.O_0oOOO_.OO.().Images.SetKeyName(1, "offline")
			Me.O_0oOOO_.OO.().Images.SetKeyName(2, "talk.png")
			Me.O_0oOOO_.OO.().Images.SetKeyName(3, "Users")
			Me.O_0oOOO_.OO.().Images.SetKeyName(4, "history")
			Me.O_0oOOO_.OO.().Images.SetKeyName(5, "font")
			Me.O_0oOOO_.OO.().Images.SetKeyName(6, "face")
			Me.O_0oOOO_.OO.().Images.SetKeyName(7, "file")
			Me.O_0oOOO_.OO.().Images.SetKeyName(8, "color")
			Me.O_0oOOO_.OO.().Images.SetKeyName(9, "Meeting")
			Me.O_0oOOO_.OO.().Images.SetKeyName(10, "group")
			Me.O_0oOOO_.OO.().Images.SetKeyName(11, "online2")
			Me.O_0oOOO_.OO.().Images.SetKeyName(12, "offline2")
			Me.O_0oOOO_.OO.().Images.SetKeyName(13, "meeting2")
			Me.O_0oOOO_.OO.().Images.SetKeyName(14, "capture")
			Me.O_0oOOO_.OO.().Images.SetKeyName(15, "Setting")
			Me.O_0oOOO_.OO.().Images.SetKeyName(16, "upload")
			Me.O_0oOOO_.OO.().Images.SetKeyName(17, "Cancel")
			Me.O_0oOOO_.OO.().Images.SetKeyName(18, "info")
			Me.O_0oOOO_.OO.().Images.SetKeyName(19, "ok")
			Me.O_0oOOO_.OO.().Images.SetKeyName(20, "WeChat")
			Me.OO0_O0.o.().Controls.Add(Me.O_0oOOO_.OO.())
			Me.OO0_O0.o.().ImageIndex = 9
			Me.OO0_O0.o.().Location = New Point(1, 25)
			Me.OO0_O0.o.().Name = "C1DockingTabPage1"
			Me.OO0_O0.o.().Size = New Size(191, 529)
			Me.OO0_O0.o.().TabIndex = 2
			Me.OO0_O0.o.().TabVisible = False
			Me.OO0_O0.o.().Text = "会议"
			Me.O_0oOOO_.OO.().AutoScrollMinSize = New Size(0, 20)
			Me.O_0oOOO_.OO.().Dock = DockStyle.Fill
			Me.O_0oOOO_.OO.().ImageList = Me.O_0oOOO_.OO.()
			Me.O_0oOOO_.OO.().Location = New Point(0, 0)
			Me.O_0oOOO_.OO.().Name = "c1Meetings"
			Me.O_0oOOO_.OO.().Padding = New Padding(5, 15, 5, 5)
			Me.O_0oOOO_.OO.().PageOffset = 5
			Me.O_0oOOO_.OO.().PagePadding = New Padding(10)
			Me.O_0oOOO_.OO.().Size = New Size(191, 529)
			Me.O_0oOOO_.OO.().TabIndex = 0
			Me.O_0oOOO_.OO.().VisualStyle = 2
			Me.O_0oOOO_.OO.().VisualStyleBase = 2
			Me.O.O_O0__0_0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O.O_O0__0_0.().BackColor = Color.FromArgb(187, 206, 230)
			Me.O.O_O0__0_0.().ImageKey = "Setting"
			Me.O.O_O0__0_0.().ImageList = Me.O_0oOOO_.OO.()
			Me.O.O_O0__0_0.().Location = New Point(600, 2)
			Me.O.O_O0__0_0.().Name = "lblSetting"
			Me.O.O_O0__0_0.().Size = New Size(18, 18)
			Me.O.O_O0__0_0.().TabIndex = 1
			Me.ooO.0o00__0.().Controls.Add(Me.O_o._o0___.())
			Me.ooO.0o00__0.().Controls.Add(Me.Oo.Oo00__oooo.())
			Me.ooO.0o00__0.().Dock = DockStyle.Fill
			Me.ooO.0o00__0.().Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.ooO.0o00__0.().ImageList = Me.O_0oOOO_.OO.()
			Me.ooO.0o00__0.().Location = New Point(0, 0)
			Me.ooO.0o00__0.().Name = "C1DockingTab2"
			Me.ooO.0o00__0.().Size = New Size(628, 555)
			Me.ooO.0o00__0.().TabIndex = 0
			Me.ooO.0o00__0.().TabsCanFocus = False
			Me.ooO.0o00__0.().TabsSpacing = 5
			Me.ooO.0o00__0.().TabStyle = 7
			Me.ooO.0o00__0.().VisualStyle = 2
			Me.ooO.0o00__0.().VisualStyleBase = 2
			Me.O_o._o0___.().Controls.Add(Me.o.o00_0O0o.())
			Me.O_o._o0___.().ImageIndex = 2
			Me.O_o._o0___.().Location = New Point(1, 25)
			Me.O_o._o0___.().Name = "C1DockingTabPage3"
			Me.O_o._o0___.().Size = New Size(626, 529)
			Me.O_o._o0___.().TabIndex = 0
			Me.O_o._o0___.().Text = "会话"
			Me.o.o00_0O0o.().BackColor = Color.FromArgb(239, 246, 253)
			Me.o.o00_0O0o.().Dock = DockStyle.Fill
			Me.o.o00_0O0o.().Location = New Point(0, 0)
			Me.o.o00_0O0o.().Name = "SplitContainer2"
			Me.o.o00_0O0o.().Orientation = Orientation.Horizontal
			Me.o.o00_0O0o.().Panel1.Controls.Add(Me.O_0oOOO_.OO.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.oO____oooO.0_O.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.oOOoo._.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.o.o00_0O0o.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.o_oO__.0.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.o.0_o0_00.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.o_O.O000o__.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.oOO____o.0o.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.Oo_._O0.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.oOo00_.0Oo.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.Oo_oo._O_.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.oOO._O.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.O_OO0.oo.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.OO0_O0.o.())
			Me.o.o00_0O0o.().Panel2.Controls.Add(Me.O._o_O0O.())
			Me.o.o00_0O0o.().Size = New Size(626, 529)
			Me.o.o00_0O0o.().SplitterDistance = 386
			Me.o.o00_0O0o.().TabIndex = 5
			Me.O_0oOOO_.OO.().AllowEditing = False
			Me.O_0oOOO_.OO.().AutoClipboard = True
			Me.O_0oOOO_.OO.().BorderStyle = 0
			Me.O_0oOOO_.OO.().ColumnInfo = "2,0,0,0,0,90,Columns:"
			Me.O_0oOOO_.OO.().Dock = DockStyle.Fill
			Me.O_0oOOO_.OO.().ExtendLastCol = True
			Me.O_0oOOO_.OO.().FocusRect = 0
			Me.O_0oOOO_.OO.().Font = New Font("宋体", 9F)
			Me.O_0oOOO_.OO.().HighLight = 2
			Me.O_0oOOO_.OO.().Location = New Point(0, 0)
			Me.O_0oOOO_.OO.().Margin = New Padding(8, 3, 3, 3)
			Me.O_0oOOO_.OO.().Name = "gridChat"
			Me.O_0oOOO_.OO.().Rows.Count = 0
			Me.O_0oOOO_.OO.().Rows.DefaultSize = 18
			Me.O_0oOOO_.OO.().Rows.Fixed = 0
			Me.O_0oOOO_.OO.().Size = New Size(626, 386)
			Me.O_0oOOO_.OO.().StyleInfo = componentResourceManager.GetString("gridChat.StyleInfo")
			Me.O_0oOOO_.OO.().TabIndex = 0
			Me.O_0oOOO_.OO.().VisualStyle = 2
			Me.oO____oooO.0_O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oO____oooO.0_O.().Location = New Point(243, 112)
			Me.oO____oooO.0_O.().Name = "btnCapture2"
			Me.oO____oooO.0_O.().Size = New Size(18, 23)
			Me.oO____oooO.0_O.().TabIndex = 12
			Me.oO____oooO.0_O.().Text = "∨"
			Me.oO____oooO.0_O.().TextAlign = ContentAlignment.BottomCenter
			Me.oO____oooO.0_O.().UseVisualStyleBackColor = True
			Me.oO____oooO.0_O.().VisualStyleBaseStyle = 5
			Me.oOOoo._.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oOOoo._.().Enabled = False
			Me.oOOoo._.().Location = New Point(604, 112)
			Me.oOOoo._.().Name = "btnSend2"
			Me.oOOoo._.().Size = New Size(18, 23)
			Me.oOOoo._.().TabIndex = 11
			Me.oOOoo._.().Text = "∨"
			Me.oOOoo._.().TextAlign = ContentAlignment.BottomCenter
			Me.oOOoo._.().UseVisualStyleBackColor = True
			Me.oOOoo._.().VisualStyleBaseStyle = 5
			Me.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o.o00_0O0o.().BackColor = Color.Transparent
			Me.o.o00_0O0o.().Controls.Add(Me.o_o0oO.oo_0_O.())
			Me.o.o00_0O0o.().Location = New Point(350, 57)
			Me.o.o00_0O0o.().Name = "panelResend"
			Me.o.o00_0O0o.().Size = New Size(35, 22)
			Me.o.o00_0O0o.().TabIndex = 10
			Me.o.o00_0O0o.().Visible = False
			Me.o_o0oO.oo_0_O.().AutoSize = True
			Me.o_o0oO.oo_0_O.().Cursor = Cursors.Hand
			Me.o_o0oO.oo_0_O.().ForeColor = Color.CornflowerBlue
			Me.o_o0oO.oo_0_O.().Location = New Point(0, 9)
			Me.o_o0oO.oo_0_O.().Name = "lblResend"
			Me.o_o0oO.oo_0_O.().Size = New Size(29, 12)
			Me.o_o0oO.oo_0_O.().TabIndex = 0
			Me.o_o0oO.oo_0_O.().Text = "重发"
			Me.o_oO__.0.().BackColor = Color.Transparent
			Me.o_oO__.0.().Controls.Add(Me.O_o._o0___.())
			Me.o_oO__.0.().Location = New Point(255, 58)
			Me.o_oO__.0.().Name = "panelOfflineFiles"
			Me.o_oO__.0.().Size = New Size(45, 22)
			Me.o_oO__.0.().TabIndex = 9
			Me.o_oO__.0.().Visible = False
			Me.O_o._o0___.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_o._o0___.().AutoSize = True
			Me.O_o._o0___.().Cursor = Cursors.Hand
			Me.O_o._o0___.().ForeColor = Color.CornflowerBlue
			Me.O_o._o0___.().Location = New Point(0, 9)
			Me.O_o._o0___.().Name = "lblRemoteFile"
			Me.O_o._o0___.().Size = New Size(29, 12)
			Me.O_o._o0___.().TabIndex = 0
			Me.O_o._o0___.().Text = "下载"
			Me.o.0_o0_00.().BackColor = Color.Transparent
			Me.o.0_o0_00.().Controls.Add(Me.o.o__0o.())
			Me.o.0_o0_00.().Controls.Add(Me.Oo.Oo00__oooo.())
			Me.o.0_o0_00.().Location = New Point(100, 36)
			Me.o.0_o0_00.().Name = "panelLocalFile"
			Me.o.0_o0_00.().Size = New Size(116, 22)
			Me.o.0_o0_00.().TabIndex = 1
			Me.o.0_o0_00.().Visible = False
			Me.o.o__0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o.o__0o.().AutoSize = True
			Me.o.o__0o.().Cursor = Cursors.Hand
			Me.o.o__0o.().ForeColor = Color.CornflowerBlue
			Me.o.o__0o.().Location = New Point(40, 9)
			Me.o.o__0o.().Name = "lblOpenFolder"
			Me.o.o__0o.().Size = New Size(65, 12)
			Me.o.o__0o.().TabIndex = 1
			Me.o.o__0o.().Text = "打开文件夹"
			Me.Oo.Oo00__oooo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo.Oo00__oooo.().AutoSize = True
			Me.Oo.Oo00__oooo.().Cursor = Cursors.Hand
			Me.Oo.Oo00__oooo.().ForeColor = Color.CornflowerBlue
			Me.Oo.Oo00__oooo.().Location = New Point(0, 9)
			Me.Oo.Oo00__oooo.().Name = "lblOpenFile"
			Me.Oo.Oo00__oooo.().Size = New Size(29, 12)
			Me.Oo.Oo00__oooo.().TabIndex = 0
			Me.Oo.Oo00__oooo.().Text = "打开"
			Me.o_O.O000o__.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o_O.O000o__.().Enabled = False
			Me.o_O.O000o__.().ImageKey = "capture"
			Me.o_O.O000o__.().ImageList = Me.O_0oOOO_.OO.()
			Me.o_O.O000o__.().Location = New Point(209, 112)
			Me.o_O.O000o__.().Name = "btnCapture"
			Me.o_O.O000o__.().Size = New Size(35, 23)
			Me.o_O.O000o__.().TabIndex = 6
			Me.O._o_O0O.().SetToolTip(Me.o_O.O000o__.(), "截图(Ctrl+Shift+O)")
			Me.o_O.O000o__.().UseVisualStyleBackColor = True
			Me.o_O.O000o__.().VisualStyleBaseStyle = 5
			Me.oOO____o.0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oOO____o.0o.().ImageIndex = 9
			Me.oOO____o.0o.().ImageList = Me.O_0oOOO_.OO.()
			Me.oOO____o.0o.().Location = New Point(86, 112)
			Me.oOO____o.0o.().Name = "btnMeeting"
			Me.oOO____o.0o.().Size = New Size(35, 23)
			Me.oOO____o.0o.().TabIndex = 2
			Me.O._o_O0O.().SetToolTip(Me.oOO____o.0o.(), "召开会议")
			Me.oOO____o.0o.().UseVisualStyleBackColor = True
			Me.oOO____o.0o.().VisualStyleBaseStyle = 5
			Me.Oo_._O0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo_._O0.().ImageKey = "color"
			Me.Oo_._O0.().ImageList = Me.O_0oOOO_.OO.()
			Me.Oo_._O0.().Location = New Point(45, 112)
			Me.Oo_._O0.().Name = "btnColor"
			Me.Oo_._O0.().Size = New Size(35, 23)
			Me.Oo_._O0.().TabIndex = 1
			Me.O._o_O0O.().SetToolTip(Me.Oo_._O0.(), "选择颜色")
			Me.Oo_._O0.().UseVisualStyleBackColor = True
			Me.Oo_._O0.().VisualStyleBaseStyle = 5
			Me.oOo00_.0Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oOo00_.0Oo.().Enabled = False
			Me.oOo00_.0Oo.().ImageKey = "upload"
			Me.oOo00_.0Oo.().ImageList = Me.O_0oOOO_.OO.()
			Me.oOo00_.0Oo.().Location = New Point(168, 112)
			Me.oOo00_.0Oo.().Name = "btnFile"
			Me.oOo00_.0Oo.().Size = New Size(35, 23)
			Me.oOo00_.0Oo.().TabIndex = 5
			Me.O._o_O0O.().SetToolTip(Me.oOo00_.0Oo.(), "发送文件")
			Me.oOo00_.0Oo.().UseVisualStyleBackColor = True
			Me.oOo00_.0Oo.().VisualStyleBaseStyle = 5
			Me.Oo_oo._O_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Oo_oo._O_.().Enabled = False
			Me.Oo_oo._O_.().Location = New Point(447, 112)
			Me.Oo_oo._O_.().Name = "btnCloseChat"
			Me.Oo_oo._O_.().Size = New Size(76, 23)
			Me.Oo_oo._O_.().TabIndex = 7
			Me.Oo_oo._O_.().Text = "关闭会话"
			Me.Oo_oo._O_.().UseVisualStyleBackColor = True
			Me.Oo_oo._O_.().VisualStyleBaseStyle = 5
			Me.oOO._O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oOO._O.().Enabled = False
			Me.oOO._O.().ImageKey = "face"
			Me.oOO._O.().ImageList = Me.O_0oOOO_.OO.()
			Me.oOO._O.().Location = New Point(127, 112)
			Me.oOO._O.().Name = "btnFace"
			Me.oOO._O.().Size = New Size(35, 23)
			Me.oOO._O.().TabIndex = 6
			Me.O._o_O0O.().SetToolTip(Me.oOO._O.(), "发送表情")
			Me.oOO._O.().UseVisualStyleBackColor = True
			Me.oOO._O.().VisualStyleBaseStyle = 5
			Me.O_OO0.oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_OO0.oo.().ImageKey = "font"
			Me.O_OO0.oo.().ImageList = Me.O_0oOOO_.OO.()
			Me.O_OO0.oo.().Location = New Point(4, 112)
			Me.O_OO0.oo.().Name = "btnFont"
			Me.O_OO0.oo.().Size = New Size(35, 23)
			Me.O_OO0.oo.().TabIndex = 0
			Me.O._o_O0O.().SetToolTip(Me.O_OO0.oo.(), "选择字体")
			Me.O_OO0.oo.().UseVisualStyleBackColor = True
			Me.O_OO0.oo.().VisualStyleBaseStyle = 5
			Me.OO0_O0.o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.OO0_O0.o.().Enabled = False
			Me.OO0_O0.o.().Location = New Point(529, 112)
			Me.OO0_O0.o.().Name = "btnSend"
			Me.OO0_O0.o.().Size = New Size(76, 23)
			Me.OO0_O0.o.().TabIndex = 8
			Me.OO0_O0.o.().Text = "发送(&S)"
			Me.OO0_O0.o.().UseVisualStyleBackColor = True
			Me.OO0_O0.o.().VisualStyleBaseStyle = 5
			Me.O._o_O0O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O._o_O0O.().Enabled = False
			Me.O._o_O0O.().Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.O._o_O0O.().Location = New Point(0, 3)
			Me.O._o_O0O.().Multiline = True
			Me.O._o_O0O.().Name = "txtSender"
			Me.O._o_O0O.().Size = New Size(625, 103)
			Me.O._o_O0O.().TabIndex = 0
			Me.Oo.Oo00__oooo.().Controls.Add(Me.O._o_O0O.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.o.o00_0O0o.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.O0O_o.O_O.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.o.o00_0O0o.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.O0Oo0O_.O_oooO.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.ooO.0o00__0.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.oOo_O_._.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.Ooo.O_OOOo00.())
			Me.Oo.Oo00__oooo.().Controls.Add(Me.Oo.Oo00__oooo.())
			Me.Oo.Oo00__oooo.().ImageIndex = 4
			Me.Oo.Oo00__oooo.().Location = New Point(1, 25)
			Me.Oo.Oo00__oooo.().Name = "C1DockingTabPage4"
			Me.Oo.Oo00__oooo.().Size = New Size(626, 529)
			Me.Oo.Oo00__oooo.().TabIndex = 1
			Me.Oo.Oo00__oooo.().Text = "记录"
			Me.O._o_O0O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O._o_O0O.().AutoSize = True
			Me.O._o_O0O.().BackColor = Color.Transparent
			Me.O._o_O0O.().Location = New Point(109, 506)
			Me.O._o_O0O.().Name = "rdoFiles"
			Me.O._o_O0O.().Size = New Size(47, 16)
			Me.O._o_O0O.().TabIndex = 14
			Me.O._o_O0O.().Text = "文件"
			Me.O._o_O0O.().UseVisualStyleBackColor = False
			Me.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o.o00_0O0o.().AutoSize = True
			Me.o.o00_0O0o.().BackColor = Color.Transparent
			Me.o.o00_0O0o.().Location = New Point(56, 506)
			Me.o.o00_0O0o.().Name = "rdoPicture"
			Me.o.o00_0O0o.().Size = New Size(47, 16)
			Me.o.o00_0O0o.().TabIndex = 13
			Me.o.o00_0O0o.().Text = "图片"
			Me.o.o00_0O0o.().UseVisualStyleBackColor = False
			Me.O0O_o.O_O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O0O_o.O_O.().AutoSize = True
			Me.O0O_o.O_O.().BackColor = Color.Transparent
			Me.O0O_o.O_O.().Checked = True
			Me.O0O_o.O_O.().Location = New Point(3, 506)
			Me.O0O_o.O_O.().Name = "rdoAll"
			Me.O0O_o.O_O.().Size = New Size(47, 16)
			Me.O0O_o.O_O.().TabIndex = 12
			Me.O0O_o.O_O.().TabStop = True
			Me.O0O_o.O_O.().Text = "全部"
			Me.O0O_o.O_O.().UseVisualStyleBackColor = False
			Me.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o.o00_0O0o.().Location = New Point(520, 502)
			Me.o.o00_0O0o.().Name = "txtPages"
			Me.o.o00_0O0o.().Size = New Size(65, 21)
			Me.o.o00_0O0o.().TabIndex = 11
			Me.o.o00_0O0o.().TextAlign = HorizontalAlignment.Center
			Me.O0Oo0O_.O_oooO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O0Oo0O_.O_oooO.().FlatAppearance.BorderSize = 0
			Me.O0Oo0O_.O_oooO.().FlatStyle = FlatStyle.Flat
			Me.O0Oo0O_.O_oooO.().Location = New Point(491, 506)
			Me.O0Oo0O_.O_oooO.().Name = "btnFirst"
			Me.O0Oo0O_.O_oooO.().Size = New Size(11, 12)
			Me.O0Oo0O_.O_oooO.().TabIndex = 7
			Me.O0Oo0O_.O_oooO.().UseVisualStyleBackColor = False
			Me.ooO.0o00__0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.ooO.0o00__0.().FlatAppearance.BorderSize = 0
			Me.ooO.0o00__0.().FlatStyle = FlatStyle.Flat
			Me.ooO.0o00__0.().Location = New Point(590, 506)
			Me.ooO.0o00__0.().Name = "btnNext"
			Me.ooO.0o00__0.().Size = New Size(8, 12)
			Me.ooO.0o00__0.().TabIndex = 10
			Me.ooO.0o00__0.().UseVisualStyleBackColor = False
			Me.oOo_O_._.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oOo_O_._.().FlatAppearance.BorderSize = 0
			Me.oOo_O_._.().FlatStyle = FlatStyle.Flat
			Me.oOo_O_._.().Location = New Point(507, 506)
			Me.oOo_O_._.().Name = "btnPrev"
			Me.oOo_O_._.().Size = New Size(8, 12)
			Me.oOo_O_._.().TabIndex = 9
			Me.oOo_O_._.().UseVisualStyleBackColor = False
			Me.Ooo.O_OOOo00.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Ooo.O_OOOo00.().FlatAppearance.BorderSize = 0
			Me.Ooo.O_OOOo00.().FlatStyle = FlatStyle.Flat
			Me.Ooo.O_OOOo00.().Location = New Point(603, 506)
			Me.Ooo.O_OOOo00.().Name = "btnLast"
			Me.Ooo.O_OOOo00.().Size = New Size(11, 12)
			Me.Ooo.O_OOOo00.().TabIndex = 8
			Me.Ooo.O_OOOo00.().UseVisualStyleBackColor = False
			Me.Oo.Oo00__oooo.().AllowEditing = False
			Me.Oo.Oo00__oooo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.Oo.Oo00__oooo.().AutoClipboard = True
			Me.Oo.Oo00__oooo.().BorderStyle = 0
			Me.Oo.Oo00__oooo.().ColumnInfo = "2,0,0,0,0,90,Columns:"
			Me.Oo.Oo00__oooo.().ExtendLastCol = True
			Me.Oo.Oo00__oooo.().FocusRect = 0
			Me.Oo.Oo00__oooo.().Font = New Font("宋体", 9F)
			Me.Oo.Oo00__oooo.().HighLight = 2
			Me.Oo.Oo00__oooo.().Location = New Point(0, 0)
			Me.Oo.Oo00__oooo.().Name = "gridHistory"
			Me.Oo.Oo00__oooo.().Rows.Count = 0
			Me.Oo.Oo00__oooo.().Rows.DefaultSize = 18
			Me.Oo.Oo00__oooo.().Rows.Fixed = 0
			Me.Oo.Oo00__oooo.().Size = New Size(624, 496)
			Me.Oo.Oo00__oooo.().StyleInfo = componentResourceManager.GetString("gridHistory.StyleInfo")
			Me.Oo.Oo00__oooo.().TabIndex = 0
			Me.Oo.Oo00__oooo.().VisualStyle = 2
			Me.O.ooO_0_.().Items.AddRange(New ToolStripItem() { Me.O_o_0.oo0.(), Me.o0oo0.O0O0.() })
			Me.O.ooO_0_.().Name = "ContextMenuStrip1"
			Me.O.ooO_0_.().Size = New Size(134, 48)
			Me.O_o_0.oo0.().Name = "menuMyFont"
			Me.O_o_0.oo0.().Size = New Size(133, 22)
			Me.O_o_0.oo0.().Text = "我方字体..."
			Me.o0oo0.O0O0.().Name = "menuBudyFont"
			Me.o0oo0.O0O0.().Size = New Size(133, 22)
			Me.o0oo0.O0O0.().Text = "对方字体..."
			Me.ooOoo___0.oO0.().Items.AddRange(New ToolStripItem() { Me.oo_o00O._.(), Me.o0O_o_0Oo.OO_.() })
			Me.ooOoo___0.oO0.().Name = "ContextMenuStrip1"
			Me.ooOoo___0.oO0.().Size = New Size(134, 48)
			Me.oo_o00O._.().Name = "menuMyColor"
			Me.oo_o00O._.().Size = New Size(133, 22)
			Me.oo_o00O._.().Text = "我方颜色..."
			Me.o0O_o_0Oo.OO_.().Name = "MenuBudyColor"
			Me.o0O_o_0Oo.OO_.().Size = New Size(133, 22)
			Me.o0O_o_0Oo.OO_.().Text = "对方颜色..."
			Me.O0oO_Oo0oO_.o.().Items.AddRange(New ToolStripItem() { Me.ooOoo___0.oO0.(), Me.o_oO__.0.(), Me.o.0_o0_00.(), Me.O0_O_0__o._.() })
			Me.O0oO_Oo0oO_.o.().Name = "ContextMenuStrip1"
			Me.O0oO_Oo0oO_.o.().Size = New Size(146, 76)
			Me.ooOoo___0.oO0.().Name = "MenuFinishMeeting"
			Me.ooOoo___0.oO0.().Size = New Size(145, 22)
			Me.ooOoo___0.oO0.().Text = "结束此会议..."
			Me.o_oO__.0.().Name = "MenuSelectMeetingUser"
			Me.o_oO__.0.().Size = New Size(145, 22)
			Me.o_oO__.0.().Text = "重选与会者..."
			Me.o.0_o0_00.().Name = "menuSeparator"
			Me.o.0_o0_00.().Size = New Size(142, 6)
			Me.O0_O_0__o._.().Name = "menuChangePassword"
			Me.O0_O_0__o._.().Size = New Size(145, 22)
			Me.O0_O_0__o._.().Text = "修改密码..."
			Me.O._o_O0O.().Enabled = True
			Me.O._o_O0O.().Interval = 1000
			Me.o_oO__.0.().Items.AddRange(New ToolStripItem() { Me.oOoo0__oO0.Oo.(), Me.oO_.oO000.() })
			Me.o_oO__.0.().Name = "MenuSend"
			Me.o_oO__.0.().Size = New Size(125, 48)
			Me.oOoo0__oO0.Oo.().Name = "常规发送ToolStripMenuItem"
			Me.oOoo0__oO0.Oo.().Size = New Size(124, 22)
			Me.oOoo0__oO0.Oo.().Text = "常规发送"
			Me.oO_.oO000.().Name = "弹窗发送ToolStripMenuItem"
			Me.oO_.oO000.().Size = New Size(124, 22)
			Me.oO_.oO000.().Text = "弹窗发送"
			Me.o.0_o0_00.().Items.AddRange(New ToolStripItem() { Me.OooO0.0OOoO_.(), Me.O_.O0ooO.(), Me.o.0_o0_00.() })
			Me.o.0_o0_00.().Name = "mnuCapture"
			Me.o.0_o0_00.().Size = New Size(197, 70)
			Me.OooO0.0OOoO_.().Name = "mnuItemCapture"
			Me.OooO0.0OOoO_.().ShortcutKeys = CType(393295, Keys)
			Me.OooO0.0OOoO_.().ShowShortcutKeys = False
			Me.OooO0.0OOoO_.().Size = New Size(196, 22)
			Me.OooO0.0OOoO_.().Text = "屏幕截图 Ctrl+Alt+O"
			Me.O_.O0ooO.().Name = "mnuHideWindow"
			Me.O_.O0ooO.().Size = New Size(196, 22)
			Me.O_.O0ooO.().Text = "截图时隐藏会话窗口"
			Me.o.0_o0_00.().Name = "mnuHideMainWindow"
			Me.o.0_o0_00.().Size = New Size(196, 22)
			Me.o.0_o0_00.().Text = "截图时隐藏主界面窗口"
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(825, 555)
			MyBase.Controls.Add(Me.O._o_O0O.())
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
			MyBase.Name = "o0OO...o"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "OpenQQ 2019"
			Me.O._o_O0O.().Panel1.ResumeLayout(False)
			Me.O._o_O0O.().Panel2.ResumeLayout(False)
			Me.O._o_O0O.().ResumeLayout(False)
			CType(Me.oOOoo._.(), ISupportInitialize).EndInit()
			Me.oOOoo._.().ResumeLayout(False)
			Me.ooO.0o00__0.().ResumeLayout(False)
			CType(Me.Oo.Oo00__oooo.(), ISupportInitialize).EndInit()
			Me.OO0_O0.o.().ResumeLayout(False)
			CType(Me.O_0oOOO_.OO.(), ISupportInitialize).EndInit()
			CType(Me.ooO.0o00__0.(), ISupportInitialize).EndInit()
			Me.ooO.0o00__0.().ResumeLayout(False)
			Me.O_o._o0___.().ResumeLayout(False)
			Me.o.o00_0O0o.().Panel1.ResumeLayout(False)
			Me.o.o00_0O0o.().Panel2.ResumeLayout(False)
			Me.o.o00_0O0o.().Panel2.PerformLayout()
			Me.o.o00_0O0o.().ResumeLayout(False)
			CType(Me.O_0oOOO_.OO.(), ISupportInitialize).EndInit()
			Me.oO____oooO.0_O.().EndInit()
			Me.oOOoo._.().EndInit()
			Me.o.o00_0O0o.().ResumeLayout(False)
			Me.o.o00_0O0o.().PerformLayout()
			Me.o_oO__.0.().ResumeLayout(False)
			Me.o_oO__.0.().PerformLayout()
			Me.o.0_o0_00.().ResumeLayout(False)
			Me.o.0_o0_00.().PerformLayout()
			Me.o_O.O000o__.().EndInit()
			Me.oOO____o.0o.().EndInit()
			Me.Oo_._O0.().EndInit()
			Me.oOo00_.0Oo.().EndInit()
			Me.Oo_oo._O_.().EndInit()
			Me.oOO._O.().EndInit()
			Me.O_OO0.oo.().EndInit()
			Me.OO0_O0.o.().EndInit()
			Me.Oo.Oo00__oooo.().ResumeLayout(False)
			Me.Oo.Oo00__oooo.().PerformLayout()
			CType(Me.Oo.Oo00__oooo.(), ISupportInitialize).EndInit()
			Me.O.ooO_0_.().ResumeLayout(False)
			Me.ooOoo___0.oO0.().ResumeLayout(False)
			Me.O0oO_Oo0oO_.o.().ResumeLayout(False)
			Me.o_oO__.0.().ResumeLayout(False)
			Me.o.0_o0_00.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600128C RID: 4748 RVA: 0x00073A65 File Offset: 0x00071C65
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.o0o._O.
		End Function

		' Token: 0x0600128D RID: 4749 RVA: 0x00073A6D File Offset: 0x00071C6D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.o0o._O. = A_0
		End Sub

		' Token: 0x0600128E RID: 4750 RVA: 0x00073A76 File Offset: 0x00071C76
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Oo0O
			Return Me.O_0O00.___.
		End Function

		' Token: 0x0600128F RID: 4751 RVA: 0x00073A80 File Offset: 0x00071C80
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Oo0O)
			Dim rangeEventHandler As RangeEventHandler = AddressOf Me.oO_.oO000.
			Dim rangeEventHandler2 As RangeEventHandler = AddressOf Me.oo_.oOOoO.
			Dim beforeMouseDownEventHandler As BeforeMouseDownEventHandler = AddressOf Me.o0__.O_Ooo_.
			Dim value As EventHandler = AddressOf Me.o000O.Oo_Oooo.
			Dim value2 As EventHandler = AddressOf Me.Ooo.0oOOoO.
			Dim value3 As EventHandler = AddressOf Me.oo_.oOOoO.
			Dim o_0O00.___. As Oo0O = Me.O_0O00.___.
			If o_0O00.___. IsNot Nothing Then
				o_0O00.___..AfterScroll -= rangeEventHandler
				o_0O00.___..AfterSelChange -= rangeEventHandler2
				o_0O00.___..BeforeMouseDown -= beforeMouseDownEventHandler
				RemoveHandler o_0O00.___..DoubleClick, value
				RemoveHandler o_0O00.___..GotFocus, value2
				RemoveHandler o_0O00.___..LostFocus, value3
			End If
			Me.O_0O00.___. = A_0
			o_0O00.___. = Me.O_0O00.___.
			If o_0O00.___. IsNot Nothing Then
				o_0O00.___..AfterScroll += rangeEventHandler
				o_0O00.___..AfterSelChange += rangeEventHandler2
				o_0O00.___..BeforeMouseDown += beforeMouseDownEventHandler
				AddHandler o_0O00.___..DoubleClick, value
				AddHandler o_0O00.___..GotFocus, value2
				AddHandler o_0O00.___..LostFocus, value3
			End If
		End Sub

		' Token: 0x06001290 RID: 4752 RVA: 0x00073B60 File Offset: 0x00071D60
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ImageList
			Return Me.O_0O00.___.
		End Function

		' Token: 0x06001291 RID: 4753 RVA: 0x00073B68 File Offset: 0x00071D68
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ImageList)
			Me.O_0O00.___. = A_0
		End Sub

		' Token: 0x06001292 RID: 4754 RVA: 0x00073B71 File Offset: 0x00071D71
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As OO___OO0O_0
			Return Me.oooO.O000_O_.
		End Function

		' Token: 0x06001293 RID: 4755 RVA: 0x00073B7C File Offset: 0x00071D7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OO___OO0O_0)
			Dim eventHandler As EventHandler = AddressOf Me.O_O0O0OoOO_.o.
			Dim oo___OO0O_ As OO___OO0O_0 = Me.oooO.O000_O_.
			If oo___OO0O_ IsNot Nothing Then
				oo___OO0O_.SelectedIndexChanged -= eventHandler
			End If
			Me.oooO.O000_O_. = A_0
			oo___OO0O_ = Me.oooO.O000_O_.
			If oo___OO0O_ IsNot Nothing Then
				oo___OO0O_.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06001294 RID: 4756 RVA: 0x00073BBF File Offset: 0x00071DBF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.oooO.O000_O_.
		End Function

		' Token: 0x06001295 RID: 4757 RVA: 0x00073BC7 File Offset: 0x00071DC7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.oooO.O000_O_. = A_0
		End Sub

		' Token: 0x06001296 RID: 4758 RVA: 0x00073BD0 File Offset: 0x00071DD0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O.oO0O.
		End Function

		' Token: 0x06001297 RID: 4759 RVA: 0x00073BD8 File Offset: 0x00071DD8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O.oO0O. = A_0
		End Sub

		' Token: 0x06001298 RID: 4760 RVA: 0x00073BE1 File Offset: 0x00071DE1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Oo0O
			Return Me.OOoOOO_o_.o0_.
		End Function

		' Token: 0x06001299 RID: 4761 RVA: 0x00073BEC File Offset: 0x00071DEC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Oo0O)
			Dim rangeEventHandler As RangeEventHandler = AddressOf Me.oO_.oO000.
			Dim rangeEventHandler2 As RangeEventHandler = AddressOf Me.oo_.oOOoO.
			Dim beforeMouseDownEventHandler As BeforeMouseDownEventHandler = AddressOf Me.o0__.O_Ooo_.
			Dim value As EventHandler = AddressOf Me.o000O.Oo_Oooo.
			Dim value2 As EventHandler = AddressOf Me.Ooo.0oOOoO.
			Dim value3 As EventHandler = AddressOf Me.OooOoo.O_.
			Dim value4 As EventHandler = AddressOf Me.OooOoo.O_.
			Dim value5 As EventHandler = AddressOf Me.oo_.oOOoO.
			Dim oooOOO_o_.o0_. As Oo0O = Me.OOoOOO_o_.o0_.
			If oooOOO_o_.o0_. IsNot Nothing Then
				oooOOO_o_.o0_..AfterScroll -= rangeEventHandler
				oooOOO_o_.o0_..AfterSelChange -= rangeEventHandler2
				oooOOO_o_.o0_..BeforeMouseDown -= beforeMouseDownEventHandler
				RemoveHandler oooOOO_o_.o0_..DoubleClick, value
				RemoveHandler oooOOO_o_.o0_..GotFocus, value2
				RemoveHandler oooOOO_o_.o0_..SizeChanged, value3
				RemoveHandler oooOOO_o_.o0_..SizeChanged, value4
				RemoveHandler oooOOO_o_.o0_..LostFocus, value5
			End If
			Me.OOoOOO_o_.o0_. = A_0
			oooOOO_o_.o0_. = Me.OOoOOO_o_.o0_.
			If oooOOO_o_.o0_. IsNot Nothing Then
				oooOOO_o_.o0_..AfterScroll += rangeEventHandler
				oooOOO_o_.o0_..AfterSelChange += rangeEventHandler2
				oooOOO_o_.o0_..BeforeMouseDown += beforeMouseDownEventHandler
				AddHandler oooOOO_o_.o0_..DoubleClick, value
				AddHandler oooOOO_o_.o0_..GotFocus, value2
				AddHandler oooOOO_o_.o0_..SizeChanged, value3
				AddHandler oooOOO_o_.o0_..SizeChanged, value4
				AddHandler oooOOO_o_.o0_..LostFocus, value5
			End If
		End Sub

		' Token: 0x0600129A RID: 4762 RVA: 0x00073D0C File Offset: 0x00071F0C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o0o._O.
		End Function

		' Token: 0x0600129B RID: 4763 RVA: 0x00073D14 File Offset: 0x00071F14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As KeyEventHandler = AddressOf Me.o000_._o.
			Dim c1TextBox As C1TextBox = Me.o0o._O.
			If c1TextBox IsNot Nothing Then
				RemoveHandler c1TextBox.KeyDown, value
			End If
			Me.o0o._O. = A_0
			c1TextBox = Me.o0o._O.
			If c1TextBox IsNot Nothing Then
				AddHandler c1TextBox.KeyDown, value
			End If
		End Sub

		' Token: 0x0600129C RID: 4764 RVA: 0x00073D57 File Offset: 0x00071F57
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oooO.O000_O_.
		End Function

		' Token: 0x0600129D RID: 4765 RVA: 0x00073D60 File Offset: 0x00071F60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo0_O_00oo.O.
			Dim c1Button As C1Button = Me.oooO.O000_O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oooO.O000_O_. = A_0
			c1Button = Me.oooO.O000_O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600129E RID: 4766 RVA: 0x00073DA3 File Offset: 0x00071FA3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Ooo.o_0oOo0_0.
		End Function

		' Token: 0x0600129F RID: 4767 RVA: 0x00073DAC File Offset: 0x00071FAC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As KeyEventHandler = AddressOf Me.ooOo00_o0o.Ooo.
			Dim ooo.o_0oOo0_0. As C1TextBox = Me.Ooo.o_0oOo0_0.
			If ooo.o_0oOo0_0. IsNot Nothing Then
				RemoveHandler ooo.o_0oOo0_0..KeyDown, value
			End If
			Me.Ooo.o_0oOo0_0. = A_0
			ooo.o_0oOo0_0. = Me.Ooo.o_0oOo0_0.
			If ooo.o_0oOo0_0. IsNot Nothing Then
				AddHandler ooo.o_0oOo0_0..KeyDown, value
			End If
		End Sub

		' Token: 0x060012A0 RID: 4768 RVA: 0x00073DEF File Offset: 0x00071FEF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO.O_OOo0o.
		End Function

		' Token: 0x060012A1 RID: 4769 RVA: 0x00073DF8 File Offset: 0x00071FF8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0O0OO.o__O.
			Dim c1Button As C1Button = Me.ooO.O_OOo0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO.O_OOo0o. = A_0
			c1Button = Me.ooO.O_OOo0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060012A2 RID: 4770 RVA: 0x00073E3B File Offset: 0x0007203B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo000._o0O0O.
		End Function

		' Token: 0x060012A3 RID: 4771 RVA: 0x00073E44 File Offset: 0x00072044
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo0O_.__.
			Dim oo000._o0O0O. As C1Button = Me.Oo000._o0O0O.
			If oo000._o0O0O. IsNot Nothing Then
				RemoveHandler oo000._o0O0O..Click, value
			End If
			Me.Oo000._o0O0O. = A_0
			oo000._o0O0O. = Me.Oo000._o0O0O.
			If oo000._o0O0O. IsNot Nothing Then
				AddHandler oo000._o0O0O..Click, value
			End If
		End Sub

		' Token: 0x060012A4 RID: 4772 RVA: 0x00073E87 File Offset: 0x00072087
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoo0_0O_._Oo0.
		End Function

		' Token: 0x060012A5 RID: 4773 RVA: 0x00073E90 File Offset: 0x00072090
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0o0.Oo_.
			Dim oooo0_0O_._Oo0. As C1Button = Me.OOoo0_0O_._Oo0.
			If oooo0_0O_._Oo0. IsNot Nothing Then
				RemoveHandler oooo0_0O_._Oo0..Click, value
			End If
			Me.OOoo0_0O_._Oo0. = A_0
			oooo0_0O_._Oo0. = Me.OOoo0_0O_._Oo0.
			If oooo0_0O_._Oo0. IsNot Nothing Then
				AddHandler oooo0_0O_._Oo0..Click, value
			End If
		End Sub

		' Token: 0x060012A6 RID: 4774 RVA: 0x00073ED3 File Offset: 0x000720D3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.__0o_Ooo.
		End Function

		' Token: 0x060012A7 RID: 4775 RVA: 0x00073EDC File Offset: 0x000720DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0.OO_.
			Dim oo_.__0o_Ooo. As C1Button = Me.Oo_.__0o_Ooo.
			If oo_.__0o_Ooo. IsNot Nothing Then
				RemoveHandler oo_.__0o_Ooo..Click, value
			End If
			Me.Oo_.__0o_Ooo. = A_0
			oo_.__0o_Ooo. = Me.Oo_.__0o_Ooo.
			If oo_.__0o_Ooo. IsNot Nothing Then
				AddHandler oo_.__0o_Ooo..Click, value
			End If
		End Sub

		' Token: 0x060012A8 RID: 4776 RVA: 0x00073F1F File Offset: 0x0007211F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As OO___OO0O_0
			Return Me.O.oO0O.
		End Function

		' Token: 0x060012A9 RID: 4777 RVA: 0x00073F27 File Offset: 0x00072127
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OO___OO0O_0)
			Me.O.oO0O. = A_0
		End Sub

		' Token: 0x060012AA RID: 4778 RVA: 0x00073F30 File Offset: 0x00072130
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.O_0.ooo0_Oo0.
		End Function

		' Token: 0x060012AB RID: 4779 RVA: 0x00073F38 File Offset: 0x00072138
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.O_0.ooo0_Oo0. = A_0
		End Sub

		' Token: 0x060012AC RID: 4780 RVA: 0x00073F41 File Offset: 0x00072141
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As o0ooo_0_00oO
			Return Me.oooO.O000_O_.
		End Function

		' Token: 0x060012AD RID: 4781 RVA: 0x00073F4C File Offset: 0x0007214C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As o0ooo_0_00oO)
			Dim c1TopicBarClickEventHandler As C1TopicBarClickEventHandler = AddressOf Me.o0_o0o.0o0O0_o.
			Dim o0ooo_0_00oO As o0ooo_0_00oO = Me.oooO.O000_O_.
			If o0ooo_0_00oO IsNot Nothing Then
				o0ooo_0_00oO.LinkClick -= c1TopicBarClickEventHandler
			End If
			Me.oooO.O000_O_. = A_0
			o0ooo_0_00oO = Me.oooO.O000_O_.
			If o0ooo_0_00oO IsNot Nothing Then
				o0ooo_0_00oO.LinkClick += c1TopicBarClickEventHandler
			End If
		End Sub

		' Token: 0x060012AE RID: 4782 RVA: 0x00073F8F File Offset: 0x0007218F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.Ooo.o_0oOo0_0.
		End Function

		' Token: 0x060012AF RID: 4783 RVA: 0x00073F97 File Offset: 0x00072197
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.Ooo.o_0oOo0_0. = A_0
		End Sub

		' Token: 0x060012B0 RID: 4784 RVA: 0x00073FA0 File Offset: 0x000721A0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_000OO0O.OO__.
		End Function

		' Token: 0x060012B1 RID: 4785 RVA: 0x00073FA8 File Offset: 0x000721A8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0OO.O_.
			Dim c1Button As C1Button = Me.o_000OO0O.OO__.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_000OO0O.OO__. = A_0
			c1Button = Me.o_000OO0O.OO__.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060012B2 RID: 4786 RVA: 0x00073FEB File Offset: 0x000721EB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O0_0OO0.0.
		End Function

		' Token: 0x060012B3 RID: 4787 RVA: 0x00073FF4 File Offset: 0x000721F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0OOooO._.
			Dim c1Button As C1Button = Me.o0O0_0OO0.0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O0_0OO0.0. = A_0
			c1Button = Me.o0O0_0OO0.0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060012B4 RID: 4788 RVA: 0x00074037 File Offset: 0x00072237
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoO00O00.00__.
		End Function

		' Token: 0x060012B5 RID: 4789 RVA: 0x00074040 File Offset: 0x00072240
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_O._OO0__O.
			Dim oooO00O00.00__. As C1Button = Me.OOoO00O00.00__.
			If oooO00O00.00__. IsNot Nothing Then
				RemoveHandler oooO00O00.00__..Click, value
			End If
			Me.OOoO00O00.00__. = A_0
			oooO00O00.00__. = Me.OOoO00O00.00__.
			If oooO00O00.00__. IsNot Nothing Then
				AddHandler oooO00O00.00__..Click, value
			End If
		End Sub

		' Token: 0x060012B6 RID: 4790 RVA: 0x00074083 File Offset: 0x00072283
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_o0._OO0O.
		End Function

		' Token: 0x060012B7 RID: 4791 RVA: 0x0007408C File Offset: 0x0007228C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_00_oOOoOOo.0.
			Dim c1Button As C1Button = Me.o_o0._OO0O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_o0._OO0O. = A_0
			c1Button = Me.o_o0._OO0O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060012B8 RID: 4792 RVA: 0x000740CF File Offset: 0x000722CF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_o.____O_o.
		End Function

		' Token: 0x060012B9 RID: 4793 RVA: 0x000740D8 File Offset: 0x000722D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0o_.O0O_.
			Dim o_o.____O_o. As C1Button = Me.O_o.____O_o.
			If o_o.____O_o. IsNot Nothing Then
				RemoveHandler o_o.____O_o..Click, value
			End If
			Me.O_o.____O_o. = A_0
			o_o.____O_o. = Me.O_o.____O_o.
			If o_o.____O_o. IsNot Nothing Then
				AddHandler o_o.____O_o..Click, value
			End If
		End Sub

		' Token: 0x060012BA RID: 4794 RVA: 0x0007411B File Offset: 0x0007231B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolTip
			Return Me.o0o._O.
		End Function

		' Token: 0x060012BB RID: 4795 RVA: 0x00074123 File Offset: 0x00072323
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolTip)
			Me.o0o._O. = A_0
		End Sub

		' Token: 0x060012BC RID: 4796 RVA: 0x0007412C File Offset: 0x0007232C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.O_OO0o__o_.00O.
		End Function

		' Token: 0x060012BD RID: 4797 RVA: 0x00074134 File Offset: 0x00072334
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.O_OO0o__o_.00O. = A_0
		End Sub

		' Token: 0x060012BE RID: 4798 RVA: 0x00074140 File Offset: 0x00072340
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_OO0o__o_.00O.
		End Function

		' Token: 0x060012BF RID: 4799 RVA: 0x00074154 File Offset: 0x00072354
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.ooO_.__O_0O0o.
				Dim o_OO0o__o_.00O. As ToolStripMenuItem = Me.O_OO0o__o_.00O.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							RemoveHandler o_OO0o__o_.00O..Click, value
							num = 4
							Continue For
						Case 1
							If o_OO0o__o_.00O. IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 2
							AddHandler o_OO0o__o_.00O..Click, value
							num = 3
							Continue For
						Case 3
							Return
						Case 4
							GoTo IL_62
						Case 5
							If True Then
							End If
							If o_OO0o__o_.00O. IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.O_OO0o__o_.00O. = A_0
					o_OO0o__o_.00O. = Me.O_OO0o__o_.00O.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x060012C0 RID: 4800 RVA: 0x00074200 File Offset: 0x00072400
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O0o0_0_oO._.
		End Function

		' Token: 0x060012C1 RID: 4801 RVA: 0x00074214 File Offset: 0x00072414
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.Oo._O0OoO_.
				Dim o0o0_0_oO._. As ToolStripMenuItem = Me.O0o0_0_oO._.
				Dim num As Integer = 0
				While True
					Select Case num
						Case 0
							If o0o0_0_oO._. IsNot Nothing Then
								If True Then
								End If
								num = 4
								Continue For
							End If
							GoTo IL_62
						Case 1
							If o0o0_0_oO._. IsNot Nothing Then
								num = 5
								Continue For
							End If
							Return
						Case 2
							GoTo IL_62
						Case 3
							Return
						Case 4
							RemoveHandler o0o0_0_oO._..Click, value
							num = 2
							Continue For
						Case 5
							AddHandler o0o0_0_oO._..Click, value
							num = 3
							Continue For
					End Select
					Exit For
					IL_62:
					Me.O0o0_0_oO._. = A_0
					o0o0_0_oO._. = Me.O0o0_0_oO._.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x060012C2 RID: 4802 RVA: 0x000742BD File Offset: 0x000724BD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.O0o0_0_oO._.
		End Function

		' Token: 0x060012C3 RID: 4803 RVA: 0x000742C5 File Offset: 0x000724C5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.O0o0_0_oO._. = A_0
		End Sub

		' Token: 0x060012C4 RID: 4804 RVA: 0x000742D0 File Offset: 0x000724D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o_oO00._Oo00__.
		End Function

		' Token: 0x060012C5 RID: 4805 RVA: 0x000742E4 File Offset: 0x000724E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.OoO0_oOO_.ooO.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o_oO00._Oo00__.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 1
							Return
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
							num = 1
							Continue For
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.o_oO00._Oo00__. = A_0
					toolStripMenuItem = Me.o_oO00._Oo00__.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060012C6 RID: 4806 RVA: 0x0007438C File Offset: 0x0007258C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O0O0._o.
		End Function

		' Token: 0x060012C7 RID: 4807 RVA: 0x000743A0 File Offset: 0x000725A0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O00.00__o.
				Dim o0O0._o. As ToolStripMenuItem = Me.O0O0._o.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							GoTo IL_5A
						Case 1
							Return
						Case 2
							If True Then
							End If
							RemoveHandler o0O0._o..Click, value
							num = 0
							Continue For
						Case 3
							If o0O0._o. IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 4
							AddHandler o0O0._o..Click, value
							num = 1
							Continue For
						Case 5
							If o0O0._o. IsNot Nothing Then
								num = 2
								Continue For
							End If
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.O0O0._o. = A_0
					o0O0._o. = Me.O0O0._o.
					num = 3
				End While
			End While
		End Sub

		' Token: 0x060012C8 RID: 4808 RVA: 0x00074446 File Offset: 0x00072646
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0o_.0OOo.
		End Function

		' Token: 0x060012C9 RID: 4809 RVA: 0x00074450 File Offset: 0x00072650
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOOo0_.0OO0__.
			Dim o0o_.0OOo. As C1Button = Me.O0o_.0OOo.
			If o0o_.0OOo. IsNot Nothing Then
				RemoveHandler o0o_.0OOo..Click, value
			End If
			Me.O0o_.0OOo. = A_0
			o0o_.0OOo. = Me.O0o_.0OOo.
			If o0o_.0OOo. IsNot Nothing Then
				AddHandler o0o_.0OOo..Click, value
			End If
		End Sub

		' Token: 0x060012CA RID: 4810 RVA: 0x00074493 File Offset: 0x00072693
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.oOoO._OOo_O0.
		End Function

		' Token: 0x060012CB RID: 4811 RVA: 0x0007449B File Offset: 0x0007269B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.oOoO._OOo_O0. = A_0
		End Sub

		' Token: 0x060012CC RID: 4812 RVA: 0x000744A4 File Offset: 0x000726A4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_OoO.OO_0_.
		End Function

		' Token: 0x060012CD RID: 4813 RVA: 0x000744B8 File Offset: 0x000726B8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O__oOoOO.OO0.
				Dim o_OoO.OO_0_. As ToolStripMenuItem = Me.O_OoO.OO_0_.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							AddHandler o_OoO.OO_0_..Click, value
							num = 4
							Continue For
						Case 1
							If True Then
							End If
							If o_OoO.OO_0_. IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 2
							If o_OoO.OO_0_. IsNot Nothing Then
								num = 3
								Continue For
							End If
							GoTo IL_5A
						Case 3
							RemoveHandler o_OoO.OO_0_..Click, value
							num = 5
							Continue For
						Case 4
							Return
						Case 5
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.O_OoO.OO_0_. = A_0
					o_OoO.OO_0_. = Me.O_OoO.OO_0_.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x060012CE RID: 4814 RVA: 0x00074564 File Offset: 0x00072764
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_o.O.
		End Function

		' Token: 0x060012CF RID: 4815 RVA: 0x00074578 File Offset: 0x00072778
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O0oO_0o0__.o_.
				Dim o_o.O. As ToolStripMenuItem = Me.O_o.O.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							RemoveHandler o_o.O..Click, value
							num = 3
							Continue For
						Case 1
							If o_o.O. IsNot Nothing Then
								If True Then
								End If
								num = 0
								Continue For
							End If
							GoTo IL_62
						Case 2
							If o_o.O. IsNot Nothing Then
								num = 4
								Continue For
							End If
							Return
						Case 3
							GoTo IL_62
						Case 4
							AddHandler o_o.O..Click, value
							num = 5
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.O_o.O. = A_0
					o_o.O. = Me.O_o.O.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060012D0 RID: 4816 RVA: 0x00074621 File Offset: 0x00072821
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.OO00O_0._00O_.
		End Function

		' Token: 0x060012D1 RID: 4817 RVA: 0x00074629 File Offset: 0x00072829
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.OO00O_0._00O_. = A_0
		End Sub

		' Token: 0x060012D2 RID: 4818 RVA: 0x00074632 File Offset: 0x00072832
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As o0ooo_0_00oO
			Return Me.O.oO0O.
		End Function

		' Token: 0x060012D3 RID: 4819 RVA: 0x0007463C File Offset: 0x0007283C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As o0ooo_0_00oO)
			Dim c1TopicBarClickEventHandler As C1TopicBarClickEventHandler = AddressOf Me.O_.__OO0o.
			Dim o.oO0O. As o0ooo_0_00oO = Me.O.oO0O.
			If o.oO0O. IsNot Nothing Then
				o.oO0O..LinkClick -= c1TopicBarClickEventHandler
			End If
			Me.O.oO0O. = A_0
			o.oO0O. = Me.O.oO0O.
			If o.oO0O. IsNot Nothing Then
				o.oO0O..LinkClick += c1TopicBarClickEventHandler
			End If
		End Sub

		' Token: 0x060012D4 RID: 4820 RVA: 0x0007467F File Offset: 0x0007287F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O___o0_o_OO._.
		End Function

		' Token: 0x060012D5 RID: 4821 RVA: 0x00074688 File Offset: 0x00072888
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.__O0.
			Dim o___o0_o_OO._. As C1Button = Me.O___o0_o_OO._.
			If o___o0_o_OO._. IsNot Nothing Then
				RemoveHandler o___o0_o_OO._..Click, value
			End If
			Me.O___o0_o_OO._. = A_0
			o___o0_o_OO._. = Me.O___o0_o_OO._.
			If o___o0_o_OO._. IsNot Nothing Then
				AddHandler o___o0_o_OO._..Click, value
			End If
		End Sub

		' Token: 0x060012D6 RID: 4822 RVA: 0x000746CB File Offset: 0x000728CB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Timer
			Return Me.o0o._O.
		End Function

		' Token: 0x060012D7 RID: 4823 RVA: 0x000746D4 File Offset: 0x000728D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Timer)
			Dim value As EventHandler = AddressOf Me.oO_.0o_.
			Dim timer As System.Windows.Forms.Timer = Me.o0o._O.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.o0o._O. = A_0
			timer = Me.o0o._O.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x060012D8 RID: 4824 RVA: 0x00074717 File Offset: 0x00072917
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_0O00.___.
		End Function

		' Token: 0x060012D9 RID: 4825 RVA: 0x00074720 File Offset: 0x00072920
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.OOoo0_O.o_O.
			Dim value2 As EventHandler = AddressOf Me.oo.0_0_.
			Dim value3 As MouseEventHandler = AddressOf Me.o_0_.Ooo__OOoo.
			Dim o_0O00.___. As Label = Me.O_0O00.___.
			If o_0O00.___. IsNot Nothing Then
				RemoveHandler o_0O00.___..MouseEnter, value
				RemoveHandler o_0O00.___..MouseLeave, value2
				RemoveHandler o_0O00.___..MouseDown, value3
			End If
			Me.O_0O00.___. = A_0
			o_0O00.___. = Me.O_0O00.___.
			If o_0O00.___. IsNot Nothing Then
				AddHandler o_0O00.___..MouseEnter, value
				AddHandler o_0O00.___..MouseLeave, value2
				AddHandler o_0O00.___..MouseDown, value3
			End If
		End Sub

		' Token: 0x060012DA RID: 4826 RVA: 0x00074799 File Offset: 0x00072999
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.O0_Oo_O__._o.
		End Function

		' Token: 0x060012DB RID: 4827 RVA: 0x000747A1 File Offset: 0x000729A1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.O0_Oo_O__._o. = A_0
		End Sub

		' Token: 0x060012DC RID: 4828 RVA: 0x000747AA File Offset: 0x000729AA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOoOOO_o_.o0_.
		End Function

		' Token: 0x060012DD RID: 4829 RVA: 0x000747B4 File Offset: 0x000729B4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.oO_._O0OOOoO0.
			Dim oooOOO_o_.o0_. As Label = Me.OOoOOO_o_.o0_.
			If oooOOO_o_.o0_. IsNot Nothing Then
				RemoveHandler oooOOO_o_.o0_..Click, value
			End If
			Me.OOoOOO_o_.o0_. = A_0
			oooOOO_o_.o0_. = Me.OOoOOO_o_.o0_.
			If oooOOO_o_.o0_. IsNot Nothing Then
				AddHandler oooOOO_o_.o0_..Click, value
			End If
		End Sub

		' Token: 0x060012DE RID: 4830 RVA: 0x000747F7 File Offset: 0x000729F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_Oo0.oO_00_.
		End Function

		' Token: 0x060012DF RID: 4831 RVA: 0x00074800 File Offset: 0x00072A00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.O_.OOO000o.
			Dim label As Label = Me.o_Oo0.oO_00_.
			If label IsNot Nothing Then
				RemoveHandler label.Click, value
			End If
			Me.o_Oo0.oO_00_. = A_0
			label = Me.o_Oo0.oO_00_.
			If label IsNot Nothing Then
				AddHandler label.Click, value
			End If
		End Sub

		' Token: 0x060012E0 RID: 4832 RVA: 0x00074843 File Offset: 0x00072A43
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.oO_O0o0.o.
		End Function

		' Token: 0x060012E1 RID: 4833 RVA: 0x0007484B File Offset: 0x00072A4B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.oO_O0o0.o. = A_0
		End Sub

		' Token: 0x060012E2 RID: 4834 RVA: 0x00074854 File Offset: 0x00072A54
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0O0._o.
		End Function

		' Token: 0x060012E3 RID: 4835 RVA: 0x0007485C File Offset: 0x00072A5C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.Oo.Oo.
			Dim o0O0._o. As Label = Me.O0O0._o.
			If o0O0._o. IsNot Nothing Then
				RemoveHandler o0O0._o..Click, value
			End If
			Me.O0O0._o. = A_0
			o0O0._o. = Me.O0O0._o.
			If o0O0._o. IsNot Nothing Then
				AddHandler o0O0._o..Click, value
			End If
		End Sub

		' Token: 0x060012E4 RID: 4836 RVA: 0x0007489F File Offset: 0x00072A9F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0_Oo_O__._o.
		End Function

		' Token: 0x060012E5 RID: 4837 RVA: 0x000748A8 File Offset: 0x00072AA8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oO.O00.
			Dim o0_Oo_O__._o. As RadioButton = Me.O0_Oo_O__._o.
			If o0_Oo_O__._o. IsNot Nothing Then
				RemoveHandler o0_Oo_O__._o..CheckedChanged, value
			End If
			Me.O0_Oo_O__._o. = A_0
			o0_Oo_O__._o. = Me.O0_Oo_O__._o.
			If o0_Oo_O__._o. IsNot Nothing Then
				AddHandler o0_Oo_O__._o..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060012E6 RID: 4838 RVA: 0x000748EB File Offset: 0x00072AEB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Ooo.o_0oOo0_0.
		End Function

		' Token: 0x060012E7 RID: 4839 RVA: 0x000748F4 File Offset: 0x00072AF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oOO00.O.
			Dim ooo.o_0oOo0_0. As RadioButton = Me.Ooo.o_0oOo0_0.
			If ooo.o_0oOo0_0. IsNot Nothing Then
				RemoveHandler ooo.o_0oOo0_0..CheckedChanged, value
			End If
			Me.Ooo.o_0oOo0_0. = A_0
			ooo.o_0oOo0_0. = Me.Ooo.o_0oOo0_0.
			If ooo.o_0oOo0_0. IsNot Nothing Then
				AddHandler ooo.o_0oOo0_0..CheckedChanged, value
			End If
		End Sub

		' Token: 0x060012E8 RID: 4840 RVA: 0x00074937 File Offset: 0x00072B37
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.oOoO._OOo_O0.
		End Function

		' Token: 0x060012E9 RID: 4841 RVA: 0x00074940 File Offset: 0x00072B40
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Dim value As EventHandler = AddressOf Me.oOOOOoOo.00_0o.
			Dim radioButton As RadioButton = Me.oOoO._OOo_O0.
			If radioButton IsNot Nothing Then
				RemoveHandler radioButton.CheckedChanged, value
			End If
			Me.oOoO._OOo_O0. = A_0
			radioButton = Me.oOoO._OOo_O0.
			If radioButton IsNot Nothing Then
				AddHandler radioButton.CheckedChanged, value
			End If
		End Sub

		' Token: 0x060012EA RID: 4842 RVA: 0x00074983 File Offset: 0x00072B83
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Panel
			Return Me.oOoO._OOo_O0.
		End Function

		' Token: 0x060012EB RID: 4843 RVA: 0x0007498B File Offset: 0x00072B8B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Panel)
			Me.oOoO._OOo_O0. = A_0
		End Sub

		' Token: 0x060012EC RID: 4844 RVA: 0x00074994 File Offset: 0x00072B94
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_o0_OOO0_0_.O.
		End Function

		' Token: 0x060012ED RID: 4845 RVA: 0x0007499C File Offset: 0x00072B9C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Dim value As EventHandler = AddressOf Me.oO0.O0_00oO00_.
			Dim o_o0_OOO0_0_.O. As Label = Me.O_o0_OOO0_0_.O.
			If o_o0_OOO0_0_.O. IsNot Nothing Then
				RemoveHandler o_o0_OOO0_0_.O..Click, value
			End If
			Me.O_o0_OOO0_0_.O. = A_0
			o_o0_OOO0_0_.O. = Me.O_o0_OOO0_0_.O.
			If o_o0_OOO0_0_.O. IsNot Nothing Then
				AddHandler o_o0_OOO0_0_.O..Click, value
			End If
		End Sub

		' Token: 0x060012EE RID: 4846 RVA: 0x000749DF File Offset: 0x00072BDF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripSeparator
			Return Me.O_OO0o__o_.00O.
		End Function

		' Token: 0x060012EF RID: 4847 RVA: 0x000749E7 File Offset: 0x00072BE7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripSeparator)
			Me.O_OO0o__o_.00O. = A_0
		End Sub

		' Token: 0x060012F0 RID: 4848 RVA: 0x000749F0 File Offset: 0x00072BF0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.OO0__0.O.
		End Function

		' Token: 0x060012F1 RID: 4849 RVA: 0x00074A04 File Offset: 0x00072C04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o_0O___o.0.
				Dim oo0__0.O. As ToolStripMenuItem = Me.OO0__0.O.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							RemoveHandler oo0__0.O..Click, value
							num = 4
							Continue For
						Case 1
							If True Then
							End If
							If oo0__0.O. IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_62
						Case 2
							If oo0__0.O. IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
						Case 3
							AddHandler oo0__0.O..Click, value
							num = 5
							Continue For
						Case 4
							GoTo IL_62
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.OO0__0.O. = A_0
					oo0__0.O. = Me.OO0__0.O.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060012F2 RID: 4850 RVA: 0x00074AAD File Offset: 0x00072CAD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.oOo_O.
		End Function

		' Token: 0x060012F3 RID: 4851 RVA: 0x00074AB8 File Offset: 0x00072CB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As MouseEventHandler = AddressOf Me.O_.__OO0o.
			Dim o.oOo_O. As C1Button = Me.O.oOo_O.
			If o.oOo_O. IsNot Nothing Then
				RemoveHandler o.oOo_O..MouseDown, value
			End If
			Me.O.oOo_O. = A_0
			o.oOo_O. = Me.O.oOo_O.
			If o.oOo_O. IsNot Nothing Then
				AddHandler o.oOo_O..MouseDown, value
			End If
		End Sub

		' Token: 0x060012F4 RID: 4852 RVA: 0x00074AFB File Offset: 0x00072CFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.OO.OO0_o_000.
		End Function

		' Token: 0x060012F5 RID: 4853 RVA: 0x00074B03 File Offset: 0x00072D03
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.OO.OO0_o_000. = A_0
		End Sub

		' Token: 0x060012F6 RID: 4854 RVA: 0x00074B0C File Offset: 0x00072D0C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O_.0____.
		End Function

		' Token: 0x060012F7 RID: 4855 RVA: 0x00074B20 File Offset: 0x00072D20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.OooO_o.___o.
				Dim o_.0____. As ToolStripMenuItem = Me.O_.0____.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							Return
						Case 1
							GoTo IL_5A
						Case 2
							RemoveHandler o_.0____..Click, value
							num = 1
							Continue For
						Case 3
							If o_.0____. IsNot Nothing Then
								num = 5
								Continue For
							End If
							Return
						Case 4
							If o_.0____. IsNot Nothing Then
								num = 2
								Continue For
							End If
							GoTo IL_5A
						Case 5
							AddHandler o_.0____..Click, value
							num = 0
							Continue For
					End Select
					Exit For
					IL_5A:
					Me.O_.0____. = A_0
					o_.0____. = Me.O_.0____.
					If True Then
					End If
					num = 3
				End While
			End While
		End Sub

		' Token: 0x060012F8 RID: 4856 RVA: 0x00074BCC File Offset: 0x00072DCC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.OoOo._OOO0_o0.
		End Function

		' Token: 0x060012F9 RID: 4857 RVA: 0x00074BE0 File Offset: 0x00072DE0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O0_Ooo.ooo.
				Dim ooOo._OOO0_o0. As ToolStripMenuItem = Me.OoOo._OOO0_o0.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							Return
						Case 1
							If True Then
							End If
							If ooOo._OOO0_o0. IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_62
						Case 2
							If ooOo._OOO0_o0. IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
						Case 3
							AddHandler ooOo._OOO0_o0..Click, value
							num = 0
							Continue For
						Case 4
							RemoveHandler ooOo._OOO0_o0..Click, value
							num = 5
							Continue For
						Case 5
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.OoOo._OOO0_o0. = A_0
					ooOo._OOO0_o0. = Me.OoOo._OOO0_o0.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x060012FA RID: 4858 RVA: 0x00074C89 File Offset: 0x00072E89
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.O_oO0OOo00o_.O.
		End Function

		' Token: 0x060012FB RID: 4859 RVA: 0x00074C91 File Offset: 0x00072E91
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.O_oO0OOo00o_.O. = A_0
		End Sub

		' Token: 0x060012FC RID: 4860 RVA: 0x00074C9C File Offset: 0x00072E9C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oO_0.o0OO__o.
		End Function

		' Token: 0x060012FD RID: 4861 RVA: 0x00074CB0 File Offset: 0x00072EB0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oO_o_.___ooOO.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oO_0.o0OO__o.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							GoTo IL_5A
						Case 1
							Return
						Case 2
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 0
							Continue For
						Case 3
							AddHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
						Case 4
							If toolStripMenuItem IsNot Nothing Then
								num = 2
								Continue For
							End If
							GoTo IL_5A
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
					End Select
					Exit For
					IL_5A:
					Me.oO_0.o0OO__o. = A_0
					toolStripMenuItem = Me.oO_0.o0OO__o.
					num = 5
				End While
			End While
		End Sub

		' Token: 0x060012FE RID: 4862 RVA: 0x00074D58 File Offset: 0x00072F58
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oO_00.0O.
		End Function

		' Token: 0x060012FF RID: 4863 RVA: 0x00074D6C File Offset: 0x00072F6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.OoO_oOoo.o0.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oO_00.0O.
				Dim num As Integer = 3
				While True
					If True Then
					End If
					Select Case num
						Case 0
							GoTo IL_62
						Case 1
							If toolStripMenuItem IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 2
							AddHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 3
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_62
						Case 4
							RemoveHandler toolStripMenuItem.Click, value
							num = 0
							Continue For
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.oO_00.0O. = A_0
					toolStripMenuItem = Me.oO_00.0O.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x06001300 RID: 4864 RVA: 0x00074E15 File Offset: 0x00073015
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.o_OO0oo_.
		End Function

		' Token: 0x06001301 RID: 4865 RVA: 0x00074E20 File Offset: 0x00073020
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Ooo._o_00.
			Dim o.o_OO0oo_. As C1Button = Me.O.o_OO0oo_.
			If o.o_OO0oo_. IsNot Nothing Then
				RemoveHandler o.o_OO0oo_..Click, value
			End If
			Me.O.o_OO0oo_. = A_0
			o.o_OO0oo_. = Me.O.o_OO0oo_.
			If o.o_OO0oo_. IsNot Nothing Then
				AddHandler o.o_OO0oo_..Click, value
			End If
		End Sub

		' Token: 0x06001302 RID: 4866 RVA: 0x00074E64 File Offset: 0x00073064
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.O0.__o__00O0.
		End Function

		' Token: 0x06001303 RID: 4867 RVA: 0x00074E78 File Offset: 0x00073078
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o_o0o_o.O.
				Dim o0.__o__00O0. As ToolStripMenuItem = Me.O0.__o__00O0.
				Dim num As Integer = 4
				While True
					Select Case num
						Case 0
							GoTo IL_62
						Case 1
							AddHandler o0.__o__00O0..Click, value
							num = 5
							Continue For
						Case 2
							RemoveHandler o0.__o__00O0..Click, value
							num = 0
							Continue For
						Case 3
							If o0.__o__00O0. IsNot Nothing Then
								num = 1
								Continue For
							End If
							Return
						Case 4
							If o0.__o__00O0. IsNot Nothing Then
								If True Then
								End If
								num = 2
								Continue For
							End If
							GoTo IL_62
						Case 5
							Return
					End Select
					Exit For
					IL_62:
					Me.O0.__o__00O0. = A_0
					o0.__o__00O0. = Me.O0.__o__00O0.
					num = 3
				End While
			End While
		End Sub

		' Token: 0x06001304 RID: 4868 RVA: 0x00074F24 File Offset: 0x00073124
		Public Sub New(A_0 As IMClient)
			AddHandler MyBase.Activated, AddressOf Me.o.0OOo.
			AddHandler MyBase.FormClosed, AddressOf Me.o0__.O_Ooo_.
			AddHandler MyBase.FormClosing, AddressOf Me.o0__.O_Ooo_.
			AddHandler MyBase.KeyDown, AddressOf Me.o_O__o_o_0.O.
			AddHandler MyBase.Load, AddressOf Me.O._O00O.
			Me.O_0O00.___. = New DataTable()
			Me.O.Oo_0O0_0OO_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.O_0oOOO_.OO.(), Me.Oo.Oo00__oooo.() }
				c1FlexGrid.Styles.Normal.Border.Style = 0
				c1FlexGrid.Styles.EmptyArea.BackColor = Me.O_0oOOO_.OO.().Styles.Normal.BackColor
				c1FlexGrid.Styles.EmptyArea.Border.Style = 0
			Next
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.oOOoo._.() })
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.ooO.0o00__0.() })
			Me.o.0_0_Ooo. = A_0
			Dim c1TopicPage As C1TopicPage = New C1TopicPage()
			c1TopicPage.Text = "正在会话"
			c1TopicPage.ImageList = Me.O_0oOOO_.OO.()
			Me.Oo.Oo00__oooo.().Pages.Add(c1TopicPage)
			Try
				For Each ooo As ooo0 In A_0.oo.___oo__0_O..Values
					Dim c1TopicLink As C1TopicLink = New C1TopicLink()
					c1TopicLink = New C1TopicLink()
					If ooo.oo.0o_0O0_0. > 0 Then
						c1TopicLink.Text = ooo.oo.o0.() + "(" + Conversions.ToString(ooo.oo.0o_0O0_0.) + ")"
					Else
						c1TopicLink.Text = ooo.oo.o0.()
					End If
					c1TopicLink.Tag = ooo
					c1TopicLink.ImageIndex = 9
					c1TopicPage.Links.Add(c1TopicLink)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, ooo0).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each o_0OOOoO As O_0OOOoO In A_0.oo.___oo__0_O..Values
					Dim c1TopicLink2 As C1TopicLink = New C1TopicLink()
					c1TopicLink2 = New C1TopicLink()
					If o_0OOOoO.oo.0o_0O0_0. > 0 Then
						c1TopicLink2.Text = o_0OOOoO.oo_.__OoOO0OO0.() + "(" + Conversions.ToString(o_0OOOoO.oo.0o_0O0_0.) + ")"
					Else
						c1TopicLink2.Text = o_0OOOoO.oo_.__OoOO0OO0.()
					End If
					c1TopicLink2.Tag = o_0OOOoO
					c1TopicLink2.ImageIndex = 9
					c1TopicPage.Links.Add(c1TopicLink2)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, O_0OOOoO).ValueCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Try
				For Each imbuddy As IMBuddy In A_0.Buddies
					Dim c1TopicPage2 As C1TopicPage = Me.Oo.Oo00__oooo.().FindPage(imbuddy.UserGroup)
					If c1TopicPage2 Is Nothing AndAlso Operators.CompareString(imbuddy.Name, "[System]", True) <> 0 Then
						c1TopicPage2 = New C1TopicPage()
						c1TopicPage2.Text = imbuddy.UserGroup
						c1TopicPage2.Collapsed = True
						c1TopicPage2.ImageList = Me.O_0oOOO_.OO.()
						Me.Oo.Oo00__oooo.().Pages.Add(c1TopicPage2)
					End If
					Dim c1TopicLink3 As C1TopicLink = New C1TopicLink()
					c1TopicLink3.Text = imbuddy.SimpleName
					c1TopicLink3.Tag = imbuddy
					If Operators.CompareString(imbuddy.Name, "[System]", True) = 0 Then
						If imbuddy.oo.0o_0O0_0. > 0 Then
							c1TopicLink3.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")"
						Else
							c1TopicLink3.Text = imbuddy.SimpleName
						End If
						c1TopicLink3.ImageIndex = 18
						c1TopicPage.Links.Add(c1TopicLink3)
					Else
						If imbuddy.FromWeChat Then
							c1TopicLink3.ImageIndex = 20
						ElseIf imbuddy.OnLine Then
							c1TopicLink3.ImageIndex = 11
						Else
							c1TopicLink3.ImageIndex = 12
						End If
						c1TopicPage2.Links.Add(c1TopicLink3)
						If A_0.oOOOo0.oo0OoO0..[Select]("Name = '" + imbuddy.Name + "'", "").Length > 0 Then
							c1TopicLink3 = New C1TopicLink()
							If imbuddy.oo.0o_0O0_0. > 0 Then
								c1TopicLink3.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")"
							Else
								c1TopicLink3.Text = imbuddy.SimpleName
							End If
							c1TopicLink3.Tag = imbuddy
							If imbuddy.FromWeChat Then
								c1TopicLink3.ImageIndex = 20
							ElseIf imbuddy.OnLine Then
								c1TopicLink3.ImageIndex = 0
							Else
								c1TopicLink3.ImageIndex = 1
							End If
							c1TopicPage.Links.Add(c1TopicLink3)
						End If
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of IMBuddy)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			Try
				For Each obj As Object In Me.Oo.Oo00__oooo.().Pages
					Dim c1TopicPage3 As C1TopicPage = CType(obj, C1TopicPage)
					Dim list As List(Of C1TopicLink) = New List(Of C1TopicLink)()
					Try
						For Each obj2 As Object In c1TopicPage3.Links
							Dim c1TopicLink4 As C1TopicLink = CType(obj2, C1TopicLink)
							If CType(c1TopicLink4.Tag, IMBuddy).OnLine OrElse TypeOf c1TopicLink4.Tag Is ooo0 OrElse TypeOf c1TopicLink4.Tag Is O_0OOOoO Then
								list.Add(c1TopicLink4)
							End If
						Next
					Finally
						Dim enumerator5 As IEnumerator
						If TypeOf enumerator5 Is IDisposable Then
							TryCast(enumerator5, IDisposable).Dispose()
						End If
					End Try
					If list.Count > 0 Then
						Dim num As Integer = list.Count - 1
						For j As Integer = 0 To num
							c1TopicPage3.Links.Remove(list(j))
							c1TopicPage3.Links.Insert(j, list(j))
						Next
					End If
					list.Clear()
				Next
			Finally
				Dim enumerator4 As IEnumerator
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
			End Try
			If c1TopicPage.Links.Count = 0 Then
				c1TopicPage.PageVisible = False
			End If
			Me.O0Oo0O_.O_oooO.().Image = OO_00oOO.GetImage("first.ico")
			Me.oOo_O_._.().Image = OO_00oOO.GetImage("prev.ico")
			Me.ooO.0o00__0.().Image = OO_00oOO.GetImage("next.ico")
			Me.Ooo.O_OOOo00.().Image = OO_00oOO.GetImage("last.ico")
			Me.Text = Me.Text + "(" + A_0.UserName + ")"
			Me.O_0oOOO_.OO.().Styles.Add("Sender", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Green
			Me.O_0oOOO_.OO.().Styles.Add("Receiver", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Blue
			Dim cellStyle As CellStyle = Me.O_0oOOO_.OO.().Styles.Add("Date", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle.TextAlign = 4
			cellStyle.ForeColor = Color.DarkOrange
			Dim cellStyle2 As CellStyle = Me.O_0oOOO_.OO.().Styles.Add("SendContent", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle2.TextAlign = 1
			cellStyle2.ImageAlign = 1
			Dim cellStyle3 As CellStyle = Me.O_0oOOO_.OO.().Styles.Add("ReceiveContent", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle3.TextAlign = 1
			cellStyle3.ImageAlign = 1
			Dim cellStyle4 As CellStyle = Me.O_0oOOO_.OO.().Styles.Add("MeetingTitle", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle4.TextAlign = 1
			cellStyle4.ForeColor = Color.Salmon
			Dim cellStyle5 As CellStyle = Me.O_0oOOO_.OO.().Styles.Add("Loading", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle5.ForeColor = Color.LightSalmon
			cellStyle5.Font = New Font("Arial", 12F, FontStyle.Bold)
			Me.O_0oOOO_.OO.().Styles.Add("System", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.DarkGray
			Me.Oo.Oo00__oooo.().Styles.Add("Sender", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Green
			Me.Oo.Oo00__oooo.().Styles.Add("Receiver", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Blue
			Dim cellStyle6 As CellStyle = Me.Oo.Oo00__oooo.().Styles.Add("Date", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle6.TextAlign = 4
			cellStyle6.ForeColor = Color.DarkOrange
			Dim cellStyle7 As CellStyle = Me.Oo.Oo00__oooo.().Styles.Add("SendContent", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle7.TextAlign = 1
			cellStyle7.ImageAlign = 1
			Dim cellStyle8 As CellStyle = Me.Oo.Oo00__oooo.().Styles.Add("ReceiveContent", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle8.TextAlign = 1
			cellStyle8.ImageAlign = 1
			Dim cellStyle9 As CellStyle = Me.Oo.Oo00__oooo.().Styles.Add("MeetingTitle", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle9.TextAlign = 1
			cellStyle9.ForeColor = Color.Salmon
			Dim cellStyle10 As CellStyle = Me.Oo.Oo00__oooo.().Styles.Add("Loading", Me.O_0oOOO_.OO.().Styles.Normal)
			cellStyle10.ForeColor = Color.LightSalmon
			cellStyle10.Font = New Font("Arial", 12F, FontStyle.Bold)
			Me.Oo.Oo00__oooo.().Styles.Add("System", Me.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.DarkGray
			Me.O_0oOOO_.OO.().Styles.Normal.WordWrap = True
			Me.Oo.Oo00__oooo.().Styles.Normal.WordWrap = True
			Me.O_0oOOO_.OO.().Cols(0).Width = 8
			Me.Oo.Oo00__oooo.().Cols(0).Width = 8
			Dim imfontProperty As IMFontProperty = New IMFontProperty(Me.O_0oOOO_.OO.().Styles("SendContent"), Me.O_0oOOO_.OO.().Styles("ReceiveContent"))
			Dim imfontProperty2 As IMFontProperty = New IMFontProperty(Me.Oo.Oo00__oooo.().Styles("SendContent"), Me.Oo.Oo00__oooo.().Styles("ReceiveContent"))
			Dim file As String = OO_00oOO.ProjectPath + "QQClient\" + Me.o.0_0_Ooo..UserName + ".cfg"
			If OO_00oOO.FileSys.FileExists(file) Then
				Dim a_ As String = OO_00oOO.FileSys.ReadAllText(file)
				o_O_o_oOoo__.OOOO_OO._oo.(imfontProperty, a_, vbVerticalTab)
				o_O_o_oOoo__.OOOO_OO._oo.(imfontProperty2, a_, vbVerticalTab)
				imfontProperty.O00.O0.()
				imfontProperty2.O00.O0.()
			End If
			Me.O._o_O0O.().Font = Me.O_0oOOO_.OO.().Styles("SendContent").Font
			Me.O._o_O0O.().ForeColor = Me.O_0oOOO_.OO.().Styles("SendContent").ForeColor
			Me.o.0_0_Ooo. = New OleDbDataAdapter("Select * From Messages Where [_Identify] is null", A_0.oOO0O.O0O0.)
			Me.o.0_0_Ooo..FillSchema(Me.O_0O00.___., SchemaType.Source)
			Me.o.0_0_Ooo. = New DataTable(Me.O_0O00.___., Me.o.0_0_Ooo., A_0.oOO0O.O0O0., "Messages", Nothing)
			For Each dataRow As DataRow In Me.o.0_0_Ooo..oo00000_0o0.oO..[Select]("", "[DateTime] Desc")
				Me.o0__.O_Ooo_.(dataRow("MeetingName").ToString(), dataRow("MeetingKey").ToString(), dataRow("Hostess").ToString(), dataRow("Description").ToString(), dataRow("Members").ToString(), Conversions.ToDate(dataRow("DateTime")), -1)
			Next
			Me.o.0_o0_00.().Parent.Controls.Remove(Me.o.0_o0_00.())
			MyBase.KeyPreview = True
			Me.o_0_o000O_0.O0.()
		End Sub

		' Token: 0x06001305 RID: 4869 RVA: 0x00075C10 File Offset: 0x00073E10
		Friend Sub <<EMPTY_NAME>>(A_0 As C1TopicLink)
			Dim a_ As C1TopicBarClickEventArgs = New C1TopicBarClickEventArgs(A_0.TopicPage, A_0)
			Me.o0_o0o.0o0O0_o.(Me.Oo.Oo00__oooo.(), a_)
		End Sub

		' Token: 0x06001306 RID: 4870 RVA: 0x00075C38 File Offset: 0x00073E38
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarClickEventArgs)
			If Me.o.0_0_Ooo. <> A_1.Link Then
				If Me.o.0_0_Ooo. IsNot Nothing Then
					If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
						Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
						Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).oOO_00_0.o.()
					End If
				End If
				A_1.Link.Text = CType(A_1.Link.Tag, IMBuddy).SimpleName + "←"
				Dim flag As Boolean
				If Me.o.0_0_Ooo. Is Nothing Then
					flag = True
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					If(Not(TypeOf A_1.Link.Tag Is ooo0) OrElse Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.(), CType(A_1.Link.Tag, ooo0).Oo_0__o.o.(), True) <> 0) AndAlso (Not(TypeOf A_1.Link.Tag Is O_0OOOoO) OrElse Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.(), CType(A_1.Link.Tag, O_0OOOoO).O_O0_o._O0o0O.(), True) <> 0) Then
						flag = True
					End If
				ElseIf Me.o.0_0_Ooo..Tag IsNot A_1.Link.Tag Then
					flag = True
				End If
				Me.o.0_0_Ooo. = A_1.Link
				If flag Then
					Me.O_0oOOO_.OO.().Rows.Count = 0
					Me.Oo.Oo00__oooo.().Rows.Count = 0
					Me.O_0oOOO_.OO.().O_O0_.__O.(Nothing)
					Me.Oo.Oo00__oooo.().O_O0_.__O.(Nothing)
					If TypeOf A_1.Link.Tag Is ooo0 Then
						Dim ooo As ooo0 = CType(A_1.Link.Tag, ooo0)
						Me.O_0.00o.(Me.O_0oOOO_.OO.(), ooo.oo.o0.(), Me.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.())
					End If
					If TypeOf A_1.Link.Tag Is O_0OOOoO Then
						Dim o_0OOOoO As O_0OOOoO = CType(A_1.Link.Tag, O_0OOOoO)
						Me.O_0.00o.(Me.O_0oOOO_.OO.(), o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.o0O0OOo._ooO_O.().Name, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.())
					End If
					Me.o_0_.Ooo__OOoo.()
					If Me.ooO.0o00__0.().SelectedIndex = 0 Then
						Me.o.0_0_Ooo. = True
					Else
						Me.o.0_0_Ooo. = False
						Me.oo_0.OOoo__.(-1, False, False)
					End If
				End If
				Me.O._o_O0O.().Value = ""
				If Not Me.OO0_O0.o.().Enabled Then
					Me.oOOoo._.().Enabled = True
					Me.oOO._O.().Enabled = True
					Me.oOo00_.0Oo.().Enabled = True
					Me.Oo_oo._O_.().Enabled = True
					Me.OO0_O0.o.().Enabled = True
					Me.O._o_O0O.().Enabled = True
					Me.o_O.O000o__.().Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06001307 RID: 4871 RVA: 0x00075F55 File Offset: 0x00074155
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_OO0.oo.().Focus()
		End Sub

		' Token: 0x06001308 RID: 4872 RVA: 0x00075F63 File Offset: 0x00074163
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.o.0_0_Ooo..ooOooo.oO. = Nothing
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x06001309 RID: 4873 RVA: 0x00075F81 File Offset: 0x00074181
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.[Return] AndAlso A_1.Control Then
				Me.OO0_O0.o.().PerformClick()
			End If
		End Sub

		' Token: 0x0600130A RID: 4874 RVA: 0x00075FA0 File Offset: 0x000741A0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. IsNot Nothing AndAlso Operators.CompareString(Me.O._o_O0O.().Text, "", True) <> 0 Then
				If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
						Return
					End If
					Me.oooo_0ooOo0.0O.()
				Else
					Me.OooOO_o0O0_._.()
				End If
				Dim text As String = o0___oO.o0__.0.(Me.O._o_O0O.().Text).Replace(ChrW(2), "")
				If Operators.CompareString(text, "", True) <> 0 Then
					If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
						Me.o.0_0_Ooo..o00O0._0O.(CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.(), text, True)
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
						Me.o.0_0_Ooo..o00O0._0O.(CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.(), text, True)
					Else
						If Not(TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy) Then
							Return
						End If
						Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
						If Operators.CompareString(imbuddy.Name, "[System]", True) = 0 Then
							Return
						End If
						If imbuddy.OnLine Then
							Me.o.0_0_Ooo..O_._00O0_. = Me.o.0_0_Ooo..O_._00O0_. + 1
							Me.o.0_0_Ooo..ooOo.oO0..Add(Me.o.0_0_Ooo..O_._00O0_., New O0o000(imbuddy, text))
							If Control.ModifierKeys = Keys.Control Then
								Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, True)
							Else
								Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, False)
							End If
						Else
							Me.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", True, False)
						End If
						If text.StartsWith("{!}") Then
							text = text.Substring(3)
						End If
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, Nothing)
					End If
					Me.O._o_O0O.().Value = ""
				End If
			End If
		End Sub

		' Token: 0x0600130B RID: 4875 RVA: 0x0007623C File Offset: 0x0007443C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			If Me.o.0_0_Ooo. IsNot Nothing Then
				If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
						Return
					End If
					Me.oooo_0ooOo0.0O.()
				Else
					Me.OooOO_o0O0_._.()
				End If
				If Operators.CompareString(A_0, "", True) <> 0 Then
					Dim text As String = ChrW(2) & "=[" + A_0 + "]="
					If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
						Me.o.0_0_Ooo..o00O0._0O.(CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.(), text, True)
						Return
					End If
					If TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
						Me.o.0_0_Ooo..o00O0._0O.(CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.(), text, True)
						Return
					End If
					If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
						Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
						If Operators.CompareString(imbuddy.Name, "[System]", True) <> 0 Then
							If imbuddy.OnLine Then
								Me.o.0_0_Ooo..O_._00O0_. = Me.o.0_0_Ooo..O_._00O0_. + 1
								Me.o.0_0_Ooo..ooOo.oO0..Add(Me.o.0_0_Ooo..O_._00O0_., New O0o000(imbuddy, text))
								If Control.ModifierKeys = Keys.Control Then
									Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, True)
								Else
									Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, False)
								End If
							Else
								Me.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", True, False)
							End If
							Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, Nothing)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600130C RID: 4876 RVA: 0x00076484 File Offset: 0x00074684
		Private Sub <<EMPTY_NAME>>()
			Dim text As String = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.Oo.Oo00__oooo.().Pages(0).Links
					Dim c1TopicLink As C1TopicLink = CType(obj, C1TopicLink)
					If(TypeOf c1TopicLink.Tag Is ooo0 AndAlso Operators.CompareString(CType(c1TopicLink.Tag, ooo0).Oo_0__o.o.(), text, True) = 0) OrElse (TypeOf c1TopicLink.Tag Is O_0OOOoO AndAlso Operators.CompareString(CType(c1TopicLink.Tag, O_0OOOoO).O_O0_o._O0o0O.(), text, True) = 0) Then
						If Me.o.0_0_Ooo. IsNot Nothing Then
							If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
								Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName
							ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
								Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).oOO_00_0.o.()
							End If
						End If
						Me.o.0_0_Ooo. = c1TopicLink
						Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName + "←"
						Me.oOOoo._.().SelectedIndex = 0
						flag = True
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Not flag Then
				Dim imbuddy As IMBuddy
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
					imbuddy = Me.o.0_0_Ooo..oo.___oo__0_O.(text)
				Else
					If Not Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
						Return
					End If
					imbuddy = Me.o.0_0_Ooo..oo.___oo__0_O.(text)
				End If
				Dim c1TopicLink2 As C1TopicLink = New C1TopicLink()
				c1TopicLink2.ImageIndex = 9
				c1TopicLink2.Tag = imbuddy
				c1TopicLink2.Text = imbuddy.SimpleName + "←"
				Me.Oo.Oo00__oooo.().Pages(0).Links.Add(c1TopicLink2)
				Me.oOOoo._.().SelectedIndex = 0
				Me.o.0_0_Ooo..Text = imbuddy.SimpleName
				Me.o.0_0_Ooo. = c1TopicLink2
				If Not Me.Oo.Oo00__oooo.().Pages(0).PageVisible Then
					Me.Oo.Oo00__oooo.().Pages(0).PageVisible = True
				End If
			End If
		End Sub

		' Token: 0x0600130D RID: 4877 RVA: 0x00076710 File Offset: 0x00074910
		Friend Sub <<EMPTY_NAME>>(A_0 As Oo0O, A_1 As DataRow)
			If A_0.Tag Is Nothing Then
				A_0.Tag = New Dictionary(Of Integer, Integer)()
			End If
			A_0.Rows.Count = A_0.Rows.Count + 1
			Dim dateTime As DateTime = Conversions.ToDate(A_1("Time"))
			If DateTime.Compare(dateTime.[Date].[Date], A_0.O_O0_.__O.().[Date]) <> 0 OrElse A_0.Rows.Count = 1 Then
				A_0(A_0.Rows.Count - 1, 1) = Strings.Format(dateTime, "yyyy年M月d日")
				A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("Date")
				A_0.O_O0_.__O.(dateTime)
			ElseIf A_0.Rows.Count = 1 Then
				A_0.Rows(A_0.Rows.Count - 1).Height = 8
			Else
				A_0.Rows(A_0.Rows.Count - 1).Height = 3
			End If
			A_0.Rows(A_0.Rows.Count - 1).UserData = "0"
			Dim text As String = A_1("Content").ToString()
			If text.StartsWith(ChrW(2) & "(") AndAlso text.EndsWith(")" & ChrW(2)) Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("info"))
			ElseIf text.StartsWith(ChrW(2) & "{") AndAlso text.EndsWith("}" & ChrW(2)) Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("Cancel"))
			ElseIf text.StartsWith(ChrW(2) & "[") AndAlso text.EndsWith("]" & ChrW(2)) Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("ok"))
			ElseIf text.StartsWith(ChrW(2) & "/") AndAlso text.EndsWith("\" & ChrW(2)) Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("Cancel"))
			ElseIf Operators.CompareString(text, "", True) > 0 AndAlso text.StartsWith(ChrW(2) & "<?") AndAlso text.EndsWith("?>") Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("ok"))
			ElseIf text.StartsWith(ChrW(2) & "|") AndAlso text.EndsWith("|" & ChrW(2)) Then
				A_0.AddItem(vbTab + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("ok"))
			ElseIf Not text.StartsWith(ChrW(2) & "<") OrElse Not text.EndsWith(">" & ChrW(2)) Then
				If Operators.CompareString(A_1("Type").ToString(), "1", True) = 0 Then
					If A_1.IsNull("MeetingSender") Then
						Dim text2 As String = A_1("Name").ToString()
						If Operators.CompareString(text2, "[System]", True) = 0 Then
							text2 = "系统"
						End If
						If Me.o.0_0_Ooo..Buddies.Contains(text2) AndAlso Me.o.0_0_Ooo..Buddies(text2).FromWeChat Then
							text2 = Me.o.0_0_Ooo..Buddies(text2).SimpleName
						End If
						A_0.AddItem(vbTab + text2 + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
					Else
						A_0.AddItem(vbTab + A_1("MeetingSender").ToString() + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
					End If
				ElseIf A_1.IsNull("MeetingSender") Then
					A_0.AddItem(vbTab + Me.o.0_0_Ooo..UserName + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				Else
					A_0.AddItem(vbTab + A_1("MeetingSender").ToString() + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1("Time")), "HH:mm:ss"))
				End If
			End If
			A_0.Rows(A_0.Rows.Count - 1).UserData = "1"
			If Not A_0.O__OO.o..ContainsKey(A_0.Rows.Count - 1) Then
				A_0.O__OO.o..Add(A_0.Rows.Count - 1, A_1)
			End If
			A_0.Rows.Count = A_0.Rows.Count + 1
			Dim flag As Boolean
			Dim flag3 As Boolean
			If Operators.CompareString(text, "", True) > 0 AndAlso text.StartsWith(ChrW(2) & "=[") AndAlso text.EndsWith("]=") Then
				text = O_O0OO.o.00O_O.() + "faces\" + text.Substring(3, text.Length - 5)
				If OO_00oOO.FileSys.FileExists(text) Then
					A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text))
				Else
					A_0(A_0.Rows.Count - 1, 1) = A_1("Content").ToString()
				End If
			ElseIf Operators.CompareString(text, "", True) > 0 AndAlso text.StartsWith(ChrW(2) & "=(") AndAlso text.EndsWith(")=") Then
				text = text.Substring(3, text.Length - 5)
				If Operators.CompareString(text, "fail.png", True) <> 0 Then
					If Operators.CompareString(A_1("Type").ToString(), "1", True) = 0 Then
						text = OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\" + text
					Else
						text = OO_00oOO.ProjectPath + "QQClient\CaptureFiles\" + text
					End If
					If Not OO_00oOO.FileSys.FileExists(text) Then
						text = "fail.png"
					End If
				End If
				While A_0.O000.o..ContainsKey(A_0.Rows.Count - 1)
					A_0.Rows.Count = A_0.Rows.Count + 1
					A_0.Rows(A_0.Rows.Count - 1).Visible = False
				End While
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text))
				A_0.O000.o..Add(A_0.Rows.Count - 1, text)
			Else
				If Operators.CompareString(text, "", True) > 0 AndAlso text.StartsWith(ChrW(2) & "=?") AndAlso text.EndsWith("?=") Then
					flag = True
					Dim text3 As String = text.Substring(3, text.Length - 5)
					A_0(A_0.Rows.Count - 1, 1) = "正在加载."
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("Loading")
					CType(A_0.Tag, Dictionary(Of Integer, Integer)).Add(Conversions.ToInteger(A_1("_Identify")), A_0.Rows.Count - 1)
					If Operators.CompareString(A_1.RowError, "1", True) = 0 Then
						GoTo IL_1337
					End If
					A_1.RowError = "1"
					Dim array As Object() = New Object(3) {}
					array(0) = text3
					If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
						array(1) = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
						Dim key As String = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
						If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key) Then
							array(1) = Me.o.0_0_Ooo..oo.___oo__0_O.(key)
						ElseIf Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key) Then
							array(1) = Me.o.0_0_Ooo..oo.___oo__0_O.(key)
						Else
							array(1) = Nothing
						End If
					Else
						array(1) = Nothing
					End If
					array(2) = A_1
					array(3) = SendTypeEnum.Capture
					Dim item As Integer = Conversions.ToInteger(A_1("_Identify"))
					Dim ooOooo.oO. As Object = Me.o.0_0_Ooo..ooOooo.oO.
					SyncLock ooOooo.oO.
						If Not Me.o.0_0_Ooo..ooOooo.oO..Contains(item) Then
							Me.o.0_0_Ooo..O00.O0..Add(array)
							Me.o.0_0_Ooo..ooOooo.oO..Add(item)
						End If
						GoTo IL_1337
					End SyncLock
				End If
				If text.StartsWith(ChrW(2) & "(") AndAlso text.EndsWith(")" & ChrW(2)) Then
					A_0(A_0.Rows.Count - 1, 1) = text.Substring(2, text.Length - 4)
					flag3 = True
				ElseIf text.StartsWith(ChrW(2) & "{") AndAlso text.EndsWith("}" & ChrW(2)) Then
					A_0(A_0.Rows.Count - 1, 1) = text.Substring(2, text.Length - 4)
					flag3 = True
				ElseIf text.StartsWith(ChrW(2) & "[") AndAlso text.EndsWith("]" & ChrW(2)) Then
					A_0(A_0.Rows.Count - 1, 1) = text.Substring(2, text.Length - 4)
					flag3 = True
				ElseIf text.StartsWith(ChrW(2) & "<") AndAlso text.EndsWith(">" & ChrW(2)) Then
					text = text.Substring(2, text.Length - 4)
					Dim array2 As String() = text.Split(New Char() { vbTab })
					If array2.Length = 2 Then
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array2(0))))
						text = OO_00oOO.FileSys.GetName(array2(0)) + vbCrLf + array2(1)
						A_0(A_0.Rows.Count - 1, 1) = text
					End If
					A_0.O000.o..Add(A_0.Rows.Count - 1, A_1)
					flag3 = True
				ElseIf text.StartsWith(ChrW(2) & "/") AndAlso text.EndsWith("\" & ChrW(2)) Then
					A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("System")
					Dim num As Integer = A_0.Rows.Count - 1
					A_0.Rows(A_0.Rows.Count - 1).UserData = "2"
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("System")
					A_0.Rows.Count = A_0.Rows.Count + 1
					A_0.Rows(A_0.Rows.Count - 1).UserData = "1"
					A_0.Rows(A_0.Rows.Count - 1).Height = 3
					A_0.Rows.Count = A_0.Rows.Count + 1
					text = text.Substring(2, text.Length - 4)
					If text.StartsWith(ChrW(2) & "=[") AndAlso text.EndsWith("]=") Then
						A_0(num, 1) = "以下表情可能发送失败"
						text = O_O0OO.o.00O_O.() + "faces\" + text.Substring(3, text.Length - 5)
						If OO_00oOO.FileSys.FileExists(text) Then
							A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text))
						End If
					ElseIf text.StartsWith(ChrW(2) & "=(") AndAlso text.EndsWith(")=") Then
						A_0(num, 1) = "以下图片可能发送失败"
						text = text.Substring(3, text.Length - 5)
						text = OO_00oOO.ProjectPath + "QQClient\CaptureFiles\" + text
						If OO_00oOO.FileSys.FileExists(text) Then
							A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text))
							A_0.O000.o..Add(A_0.Rows.Count - 1, text)
						End If
					Else
						A_0(num, 1) = "以下信息可能发送失败"
						A_0(A_0.Rows.Count - 1, 1) = text
					End If
					A_0.oO0Oo00o.00..Add(A_0.Rows.Count - 1, A_1)
				ElseIf text.StartsWith(ChrW(2) & "|") AndAlso text.EndsWith("|" & ChrW(2)) Then
					A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("System")
					If A_1.IsNull("MeetingSender") Then
						A_0(A_0.Rows.Count - 1, 1) = "对方发来离线文件"
					Else
						A_0(A_0.Rows.Count - 1, 1) = A_1("MeetingSender").ToString() + "分享了文件"
					End If
					A_0.Rows(A_0.Rows.Count - 1).UserData = "2"
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("System")
					A_0.Rows.Count = A_0.Rows.Count + 1
					A_0.Rows(A_0.Rows.Count - 1).UserData = "1"
					A_0.Rows(A_0.Rows.Count - 1).Height = 1
					A_0.Rows.Count = A_0.Rows.Count + 1
					text = text.Substring(2, text.Length - 4)
					Dim array3 As String() = text.Split(New Char() { vbTab })
					If array3.Length >= 2 Then
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array3(0))))
						text = OO_00oOO.FileSys.GetName(array3(0)) + vbCrLf + array3(1)
						If array3.Length = 3 Then
							text = text + vbCrLf + Strings.Format(Conversions.ToDate(array3(2)), "yyyy年MM月dd日 HH:mm:ss") + "下载成功!"
						End If
						A_0(A_0.Rows.Count - 1, 1) = text
					End If
					A_0.O000.o..Add(A_0.Rows.Count - 1, A_1)
					flag3 = True
				ElseIf Operators.CompareString(text, "", True) > 0 AndAlso text.StartsWith(ChrW(2) & "<?") AndAlso text.EndsWith("?>") Then
					A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("System")
					If A_1.IsNull("MeetingSender") Then
						A_0(A_0.Rows.Count - 1, 1) = "对方发来离线文件"
					Else
						A_0(A_0.Rows.Count - 1, 1) = A_1("MeetingSender").ToString() + "分享了文件"
					End If
					A_0.Rows(A_0.Rows.Count - 1).UserData = "2"
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("System")
					A_0.Rows.Count = A_0.Rows.Count + 1
					A_0.Rows(A_0.Rows.Count - 1).UserData = "1"
					A_0.Rows(A_0.Rows.Count - 1).Height = 1
					A_0.Rows.Count = A_0.Rows.Count + 1
					text = text.Substring(3, text.Length - 5)
					Dim array4 As String() = text.Split(New Char() { vbTab })
					Dim flag4 As Boolean
					If array4.Length >= 2 Then
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array4(0))))
						text = OO_00oOO.FileSys.GetName(array4(0)) + vbCrLf + array4(1)
						If array4.Length = 3 Then
							If Operators.CompareString(array4(2), "Deleted", True) = 0 Then
								text += vbCrLf & "服务器已删除此离线文件,无法下载!"
								flag4 = True
							Else
								text = text + vbCrLf + Strings.Format(Conversions.ToDate(array4(2)), "yyyy年MM月dd日 HH:mm:ss") + "下载失败!"
							End If
						End If
						A_0(A_0.Rows.Count - 1, 1) = text
					End If
					If Not flag4 Then
						A_0.oOO00oo.O..Add(A_0.Rows.Count - 1, A_1)
					End If
					flag3 = True
				Else
					A_0(A_0.Rows.Count - 1, 1) = text
					If text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) OrElse text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) OrElse (text.StartsWith("www", StringComparison.CurrentCultureIgnoreCase) AndAlso text.Length - text.Replace(".", "").Length >= 2) Then
						A_0.oOO00oo.O..Add(A_0.Rows.Count - 1, A_1)
					End If
				End If
			End If
			IL_1337:
			A_0.Rows(A_0.Rows.Count - 1).UserData = "2"
			If Not A_0.O__OO.o..ContainsKey(A_0.Rows.Count - 1) Then
				A_0.O__OO.o..Add(A_0.Rows.Count - 1, A_1)
			End If
			If flag3 Then
				A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("System")
				A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("System")
			ElseIf Not flag Then
				If Operators.CompareString(A_1("Type").ToString(), "1", True) = 0 Then
					A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("Receiver")
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("ReceiveContent")
				Else
					A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("Sender")
					A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("SendContent")
				End If
			End If
			A_0.AutoSizeRow(A_0.Rows.Count - 2)
			A_0.AutoSizeRow(A_0.Rows.Count - 1)
		End Sub

		' Token: 0x0600130E RID: 4878 RVA: 0x00077C1C File Offset: 0x00075E1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo..o_oo0.O0Oo__oO. < 3 Then
				Dim obj As Object = Nothing
				Dim ooOooo.oO. As Object = Me.o.0_0_Ooo..ooOooo.oO.
				SyncLock ooOooo.oO.
					If Me.o.0_0_Ooo..O00.O0..Count > 0 Then
						obj = RuntimeHelpers.GetObjectValue(Me.o.0_0_Ooo..O00.O0.(0))
						Me.o.0_0_Ooo..O00.O0..RemoveAt(0)
					End If
				End SyncLock
				If obj IsNot Nothing Then
					Dim oo.___oo__0_O. As Object = Me.o.0_0_Ooo..oo.___oo__0_O.
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.)
					SyncLock oo.___oo__0_O.
						Me.o.0_0_Ooo..o_oo0.O0Oo__oO. = Me.o.0_0_Ooo..o_oo0.O0Oo__oO. + 1
					End SyncLock
					AddressOf Me.o0__.O_Ooo_..Start(RuntimeHelpers.GetObjectValue(obj))
				End If
			End If
		End Sub

		' Token: 0x0600130F RID: 4879 RVA: 0x00077D18 File Offset: 0x00075F18
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim array As Object() = CType(A_0, Object())
			Dim text As String = array(0).ToString()
			Dim imbuddy As IMBuddy = Nothing
			If array(1) IsNot Nothing Then
				imbuddy = CType(array(1), IMBuddy)
			End If
			Dim dataRow As DataRow = CType(array(2), DataRow)
			Dim sendTypeEnum As SendTypeEnum = CType(Conversions.ToInteger(array(3)), SendTypeEnum)
			If Me.o.0_0_Ooo..O0_OOo.O. OrElse dataRow.RowState = DataRowState.Detached Then
				If sendTypeEnum <> SendTypeEnum.Capture Then
					Return
				End If
				Dim oo.___oo__0_O. As Object = Me.o.0_0_Ooo..oo.___oo__0_O.
				ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.)
				SyncLock oo.___oo__0_O.
					Me.o.0_0_Ooo..o_oo0.O0Oo__oO. = Me.o.0_0_Ooo..o_oo0.O0Oo__oO. - 1
					Return
				End SyncLock
			End If
			Dim text2 As String = vbVerticalTab
			Dim udpClient As UdpClient = New UdpClient(0)
			o0___oO.O.oOo0O0O.(udpClient)
			udpClient.Client.ReceiveBufferSize = 81920
			Dim s As String = String.Concat(New String() { "%4", text2, Me.o.0_0_Ooo..UserName, text2, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text2, text })
			Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
			udpClient.Send(bytes, bytes.Length, Me.o.0_0_Ooo..ooOo.oO0.)
			Dim now As DateTime = DateTime.Now
			Try
				While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
					If udpClient.Available > 0 Then
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes2 As Byte() = udpClient.Receive(ipendPoint)
						Dim num As Integer
						If Integer.TryParse(Encoding.Unicode.GetString(bytes2), num) Then
							If num = -1 Then
								If sendTypeEnum = SendTypeEnum.Capture Then
									dataRow("Content") = ChrW(2) & "=(fail.png)="
									Me.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(New DataRow() { dataRow })
									MyBase.Invoke(AddressOf Me.o0.00., New Object() { dataRow })
								Else
									Dim text3 As String = dataRow("Content").ToString()
									text3 = text3.Substring(3, text3.Length - 5)
									Dim array2 As String() = text3.Split(New Char() { vbTab })
									text3 = String.Concat(New String() { ChrW(2) & "<?", array2(0), vbTab, array2(1), vbTab & "Deleted?>" })
									dataRow("Content") = text3
									Me.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(New DataRow() { dataRow })
									MyBase.Invoke(AddressOf Me.ooOo00_o0o.Ooo., New Object() { dataRow })
								End If
								udpClient.Close()
								Exit While
							End If
							Dim ipendPoint2 As IPEndPoint = New IPEndPoint(Me.o.0_0_Ooo..ooOo.oO0..Address, num)
							bytes = Encoding.Unicode.GetBytes("Ping")
							udpClient.Send(bytes, bytes.Length, ipendPoint2)
							Dim ooOoO As ooOoO = New ooOoO(Me.o.0_0_Ooo., udpClient, ipendPoint2, OO_00oOO.FileSys.GetName(text), Nothing, dataRow("_Identify").ToString(), sendTypeEnum)
							ooOoO.o0_.OO0O_o.(dataRow)
							If sendTypeEnum <> SendTypeEnum.Capture AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
								OO_00oOO.BaseMainForm.Invoke(AddressOf Me.ooOo00_o0o.Ooo., New Object() { imbuddy, text, ooOoO })
							End If
							Dim ooOooo.oO. As Object = Me.o.0_0_Ooo..ooOooo.oO.
							SyncLock ooOooo.oO.
								Me.o.0_0_Ooo..ooOooo.oO..Add(ooOoO.o0OO._0.(), ooOoO)
							End SyncLock
							Dim flag3 As Boolean = True
							ooOoO.O_OOOooo_0.O.()
							Exit While
						End If
					End If
				End While
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			Finally
				Dim flag3 As Boolean
				If Not flag3 AndAlso sendTypeEnum = SendTypeEnum.Capture Then
					Dim oo.___oo__0_O.2 As Object = Me.o.0_0_Ooo..oo.___oo__0_O.
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.2)
					SyncLock oo.___oo__0_O.2
						Me.o.0_0_Ooo..o_oo0.O0Oo__oO. = Me.o.0_0_Ooo..o_oo0.O0Oo__oO. - 1
					End SyncLock
				End If
				If dataRow IsNot Nothing Then
					Dim item As Integer = Conversions.ToInteger(dataRow("_Identify"))
					Dim oOO0_O.O__0_0. As Object = Me.o.0_0_Ooo..oOO0_O.O__0_0.
					SyncLock oOO0_O.O__0_0.
						If Me.o.0_0_Ooo..oOO0_O.O__0_0..Contains(item) Then
							Me.o.0_0_Ooo..oOO0_O.O__0_0..Remove(item)
						End If
					End SyncLock
				End If
			End Try
		End Sub

		' Token: 0x06001310 RID: 4880 RVA: 0x00078238 File Offset: 0x00076438
		Private Sub <<EMPTY_NAME>>(A_0 As IMBuddy, A_1 As String, A_2 As ooOoO)
			Dim oo0O__ As Oo0O__ = New Oo0O__(Me.o.0_0_Ooo., A_0, A_1, A_2.o0OO._0.())
			oo0O__.o_0.Oo_0O0_. = True
			oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(A_1)
			oo0O__.OOOO_.0O0o0.().Visible = False
			If Me.o.0_0_Ooo..ooOooo.oO. Is Nothing Then
				Me.o.0_0_Ooo..ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me.o.0_0_Ooo.)
				Me.o.0_0_Ooo..ooOooo.oO..Owner = OO_00oOO.BaseMainForm
			End If
			Me.o.0_0_Ooo..ooOooo.oO..O_0O_o.0.(oo0O__)
			Me.o.0_0_Ooo..ooOooo.oO..Show()
			A_2.O0__00OoOo_O.o. = oo0O__
		End Sub

		' Token: 0x06001311 RID: 4881 RVA: 0x000782E4 File Offset: 0x000764E4
		Private Sub <<EMPTY_NAME>>(A_0 As DataRow)
			For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.o.0_0_Ooo..ooOooo.oO..O_0oOOO_.OO.(), Me.o.0_0_Ooo..ooOooo.oO..Oo.Oo00__oooo.() }
				If c1FlexGrid.Tag IsNot Nothing Then
					Dim dictionary As Dictionary(Of Integer, Integer) = CType(c1FlexGrid.Tag, Dictionary(Of Integer, Integer))
					Dim key As Integer = Conversions.ToInteger(A_0("_Identify"))
					If dictionary.ContainsKey(key) Then
						Dim num As Integer = dictionary(key)
						dictionary.Remove(key)
						c1FlexGrid(num, 1) = Nothing
						c1FlexGrid.SetCellImage(num, 1, OO_00oOO.GetImage("fail.png"))
						c1FlexGrid.AutoSizeRow(num)
					End If
				End If
			Next
		End Sub

		' Token: 0x06001312 RID: 4882 RVA: 0x00078398 File Offset: 0x00076598
		Private Sub <<EMPTY_NAME>>(A_0 As DataRow)
			For Each oo0O As Oo0O In New Oo0O() { Me.o.0_0_Ooo..ooOooo.oO..O_0oOOO_.OO.(), Me.o.0_0_Ooo..ooOooo.oO..Oo.Oo00__oooo.() }
				Try
					For Each num As Integer In oo0O.oOO00oo.O..Keys
						If oo0O.oOO00oo.O.(num) Is A_0 Then
							Dim text As String = A_0("Content").ToString()
							text = text.Substring(3, text.Length - 5)
							Dim array2 As String() = text.Split(New Char() { vbTab })
							text = array2(0) + vbCrLf + array2(1) + vbCrLf & "服务器已删除此离线文件，无法下载！"
							oo0O(num, 1) = text
							oo0O.AutoSizeRow(num)
							If Me.o_oO__.0.().Visible AndAlso Me.o_oO__.0.().Parent Is oo0O AndAlso Conversions.ToInteger(Me.o_oO__.0.().Tag) = num Then
								Me.o_oO__.0.().Visible = False
							End If
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of Integer, DataRow).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			Next
		End Sub

		' Token: 0x06001313 RID: 4883 RVA: 0x000784E8 File Offset: 0x000766E8
		Friend Sub <<EMPTY_NAME>>()
			If Me.o.0_0_Ooo..TopicBar Is Me.Oo.Oo00__oooo.() AndAlso Me.o.0_0_Ooo..TopicPage.Index <> 0 Then
				Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
				Dim c1TopicLink As C1TopicLink = Me.Oo.Oo00__oooo.().Pages(0).FindLinkByTag(RuntimeHelpers.GetObjectValue(Me.o.0_0_Ooo..Tag))
				If c1TopicLink Is Nothing Then
					c1TopicLink = New C1TopicLink()
					c1TopicLink.Tag = RuntimeHelpers.GetObjectValue(Me.o.0_0_Ooo..Tag)
					c1TopicLink.Text = imbuddy.SimpleName + "←"
					If imbuddy.FromWeChat Then
						c1TopicLink.ImageIndex = 20
					ElseIf imbuddy.OnLine Then
						c1TopicLink.ImageIndex = 0
					Else
						c1TopicLink.ImageIndex = 1
					End If
					Me.Oo.Oo00__oooo.().Pages(0).Links.Add(c1TopicLink)
					If Not Me.Oo.Oo00__oooo.().Pages(0).PageVisible Then
						Me.Oo.Oo00__oooo.().Pages(0).PageVisible = True
					End If
				Else
					c1TopicLink.Text = CType(c1TopicLink.Tag, IMBuddy).SimpleName + "←"
				End If
				Me.o.0_0_Ooo..Text = imbuddy.SimpleName
				Me.o.0_0_Ooo. = c1TopicLink
			End If
		End Sub

		' Token: 0x06001314 RID: 4884 RVA: 0x00078640 File Offset: 0x00076840
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			Try
				If Me.o.0_o0_00.().Visible AndAlso Me.o.0_o0_00.().Parent Is A_0 Then
					Dim oo0O As Oo0O = CType(A_0, Oo0O)
					Dim num As Integer = Conversions.ToInteger(Me.o.0_o0_00.().Tag)
					Dim x As Integer = oo0O.Width - Me.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y As Integer = oo0O.Rows(num).Bottom - Me.o.0_o0_00.().Height + oo0O.ScrollPosition.Y
					Me.o.0_o0_00.().Location = New Point(x, y)
				End If
				If Me.o.o00_0O0o.().Visible AndAlso Me.o.o00_0O0o.().Parent Is A_0 Then
					Dim oo0O2 As Oo0O = CType(A_0, Oo0O)
					Dim num2 As Integer = Conversions.ToInteger(Me.o.o00_0O0o.().Tag)
					Dim x2 As Integer = oo0O2.Width - Me.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y2 As Integer = oo0O2.Rows(num2).Top - Me.o.o00_0O0o.().Height + oo0O2.ScrollPosition.Y - 5
					Me.o.o00_0O0o.().Location = New Point(x2, y2)
				End If
				If Me.o_oO__.0.().Visible AndAlso Me.o_oO__.0.().Parent Is A_0 Then
					Dim oo0O3 As Oo0O = CType(A_0, Oo0O)
					Dim num3 As Integer = Conversions.ToInteger(Me.o_oO__.0.().Tag)
					Dim x3 As Integer = oo0O3.Width - Me.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O3.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y3 As Integer = oo0O3.Rows(num3).Bottom - Me.o_oO__.0.().Height + oo0O3.ScrollPosition.Y
					Me.o_oO__.0.().Location = New Point(x3, y3)
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06001315 RID: 4885 RVA: 0x000788B0 File Offset: 0x00076AB0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			Try
				Me.o.0_o0_00.().Visible = False
				Me.o_oO__.0.().Visible = False
				Me.o.o00_0O0o.().Visible = False
				Dim oo0O As Oo0O = CType(A_0, Oo0O)
				Dim num As Integer = oo0O.Selection.TopRow
				Dim num2 As Integer = oo0O.Selection.BottomRow
				If num >= 0 AndAlso num2 >= 0 AndAlso oo0O.Rows(num).UserData IsNot Nothing AndAlso oo0O.Rows(num2).UserData IsNot Nothing Then
					If Operators.CompareString(oo0O.Rows(num).UserData.ToString(), "2", True) = 0 Then
						num -= 1
					End If
					If Operators.CompareString(oo0O.Rows(num2).UserData.ToString(), "1", True) = 0 Then
						num2 += 1
					End If
					If num <> oo0O.Selection.TopRow OrElse num2 <> oo0O.Selection.BottomRow Then
						oo0O.[Select](num, 1, num2, 1)
						Return
					End If
				End If
				If oo0O.O000.o..ContainsKey(num2) Then
					oo0O.BeginUpdate()
					Dim x As Integer = oo0O.Width - Me.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y As Integer = oo0O.Rows(num2).Bottom - Me.o.0_o0_00.().Height + oo0O.ScrollPosition.Y
					Me.o.0_o0_00.().Location = New Point(x, y)
					Me.o.0_o0_00.().Tag = num2
					Me.o.0_o0_00.().Anchor = AnchorStyles.Right
					oo0O.Controls.Add(Me.o.0_o0_00.())
					Me.o.0_o0_00.().Visible = True
					oo0O.EndUpdate()
				End If
				If oo0O.oO0Oo00o.00..ContainsKey(num2) Then
					oo0O.BeginUpdate()
					Dim x2 As Integer = oo0O.Width - Me.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y2 As Integer = oo0O.Rows(num2).Top - Me.o.o00_0O0o.().Height + oo0O.ScrollPosition.Y - 5
					Me.o.o00_0O0o.().Location = New Point(x2, y2)
					Me.o.o00_0O0o.().Tag = num2
					Me.o.o00_0O0o.().Anchor = AnchorStyles.Right
					oo0O.Controls.Add(Me.o.o00_0O0o.())
					Me.o.o00_0O0o.().Visible = True
					oo0O.EndUpdate()
				End If
				If oo0O.oOO00oo.O..ContainsKey(num2) Then
					oo0O.BeginUpdate()
					Dim x3 As Integer = oo0O.Width - Me.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
					Dim y3 As Integer = oo0O.Rows(num2).Bottom - Me.o_oO__.0.().Height + oo0O.ScrollPosition.Y
					Me.o_oO__.0.().Location = New Point(x3, y3)
					Me.o_oO__.0.().Tag = num2
					Me.o_oO__.0.().Anchor = AnchorStyles.Right
					Dim text As String = oo0O.oOO00oo.O.(num2)("Content").ToString()
					Dim flag As Boolean
					If text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) OrElse text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".com", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".cn", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".net", StringComparison.CurrentCultureIgnoreCase) Then
						flag = True
					End If
					If Me.o.0_0_Ooo..oOO0_O.O__0_0..Contains(Conversions.ToInteger(oo0O.oOO00oo.O.(num2)("_Identify"))) Then
						Me.O_o._o0___.().Text = "下载中..."
						Me.O_o._o0___.().Cursor = Cursors.[Default]
					ElseIf flag Then
						Me.O_o._o0___.().Text = "打开"
						Me.O_o._o0___.().Cursor = Cursors.Hand
					Else
						Me.O_o._o0___.().Text = "下载"
						Me.O_o._o0___.().Cursor = Cursors.Hand
					End If
					oo0O.Controls.Add(Me.o_oO__.0.())
					Me.o_oO__.0.().Visible = True
					oo0O.EndUpdate()
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06001316 RID: 4886 RVA: 0x00078D70 File Offset: 0x00076F70
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As BeforeMouseDownEventArgs)
			Try
				Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
				Dim mouseRow As Integer = c1FlexGrid.MouseRow
				If mouseRow >= 0 AndAlso (c1FlexGrid.Rows(mouseRow).UserData Is Nothing OrElse Operators.CompareString(c1FlexGrid.Rows(mouseRow).UserData.ToString(), "0", True) = 0) Then
					A_1.Cancel = True
					c1FlexGrid.Focus()
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06001317 RID: 4887 RVA: 0x00078E00 File Offset: 0x00077000
		Private Sub <<EMPTY_NAME>>()
			If Me.o.0_o0_00.().Parent Is Me.O_0oOOO_.OO.() Then
				Me.o.0_o0_00.().Visible = False
				Me.o.0_o0_00.().Parent.Controls.Remove(Me.o.0_o0_00.())
			End If
			If Me.o_oO__.0.().Parent Is Me.O_0oOOO_.OO.() Then
				Me.o_oO__.0.().Visible = False
				Me.o_oO__.0.().Parent.Controls.Remove(Me.o_oO__.0.())
			End If
			Dim text As String
			If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
				text = CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.()
			ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
				text = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.()
			ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
				text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
			Else
				text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name
			End If
			Dim oOOOo0.oo0OoO0. As DataTable = Me.o.0_0_Ooo..oOOOo0.oo0OoO0.
			Dim oo0O As Oo0O = Me.O_0oOOO_.OO.()
			If oo0O.Tag Is Nothing Then
				oo0O.Tag = New Dictionary(Of Integer, Integer)()
			End If
			CType(oo0O.Tag, Dictionary(Of Integer, Integer)).Clear()
			oo0O.O000.o..Clear()
			oo0O.oOO00oo.O..Clear()
			oo0O.O000.o..Clear()
			oo0O.oO0Oo00o.00..Clear()
			oo0O.O__OO.o..Clear()
			Dim array As DataRow() = Me.o.0_0_Ooo..oOOOo0.oo0OoO0..[Select]("[Name] = '" + text + "'", "Time")
			If array.Length <> 0 Then
				oo0O.BeginUpdate()
				For Each dataRow As DataRow In array
					Me.O_0.00o.(oo0O, dataRow)
					If Operators.CompareString(dataRow("Read").ToString(), "0", True) = 0 Then
						dataRow("Read") = 1
					End If
				Next
				oo0O.EndUpdate()
				Me.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(array)
				oo0O.ShowCell(oo0O.Rows.Count - 1, 0)
				oo0O.Row = -1
				If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
					CType(Me.o.0_0_Ooo..Tag, IMBuddy).oo.0o_0O0_0. = 0
					Return
				End If
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
					Me.o.0_0_Ooo..oo.___oo__0_O.(text).oo.0o_0O0_0. = 0
				End If
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
					Me.o.0_0_Ooo..oo.___oo__0_O.(text).oo.0o_0O0_0. = 0
				End If
			End If
		End Sub

		' Token: 0x06001318 RID: 4888 RVA: 0x000790BC File Offset: 0x000772BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. Is Nothing Then
				Me.o.0_0_Ooo. = New O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000(Me)
				Me.o.0_0_Ooo..Owner = OO_00oOO.BaseMainForm
			End If
			Dim y As Integer = Me.oOO._O.().Top - Me.o.0_0_Ooo..Height
			Dim left As Integer = Me.oOO._O.().Left
			Dim point As Point = New Point(left, y)
			point = Me.o.o00_0O0o.().Panel2.PointToScreen(point)
			Me.o.0_0_Ooo..Location = point
			Me.o.0_0_Ooo..Show()
		End Sub

		' Token: 0x06001319 RID: 4889 RVA: 0x00079143 File Offset: 0x00077343
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.ooO_0_.().Show(Me.O_OO0.oo.(), New Point(0, Me.O_OO0.oo.().Height))
		End Sub

		' Token: 0x0600131A RID: 4890 RVA: 0x00079167 File Offset: 0x00077367
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.ooOoo___0.oO0.().Show(Me.Oo_._O0.(), New Point(0, Me.Oo_._O0.().Height))
		End Sub

		' Token: 0x0600131B RID: 4891 RVA: 0x0007918C File Offset: 0x0007738C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.O_0oOOO_.OO.().Styles("SendContent").Font
			If fontDialog.ShowDialog() = DialogResult.OK Then
				Me.O_0oOOO_.OO.().Styles("SendContent").Font = fontDialog.Font
				Me.Oo.Oo00__oooo.().Styles("SendContent").Font = fontDialog.Font
				Me.O_0oOOO_.OO.().AutoSizeRows()
				Me.Oo.Oo00__oooo.().AutoSizeRows()
				Me.O._o_O0O.().Font = Me.O_0oOOO_.OO.().Styles("SendContent").Font
			End If
		End Sub

		' Token: 0x0600131C RID: 4892 RVA: 0x00079244 File Offset: 0x00077444
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim fontDialog As FontDialog = New FontDialog()
			fontDialog.Font = Me.O_0oOOO_.OO.().Styles("ReceiveContent").Font
			If fontDialog.ShowDialog() = DialogResult.OK Then
				Me.O_0oOOO_.OO.().Styles("ReceiveContent").Font = fontDialog.Font
				Me.Oo.Oo00__oooo.().Styles("ReceiveContent").Font = fontDialog.Font
				Me.O_0oOOO_.OO.().AutoSizeRows()
				Me.Oo.Oo00__oooo.().AutoSizeRows()
			End If
		End Sub

		' Token: 0x0600131D RID: 4893 RVA: 0x000792D8 File Offset: 0x000774D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.Color = Me.O_0oOOO_.OO.().Styles("SendContent").ForeColor
			If colorDialog.ShowDialog() = DialogResult.OK Then
				Me.O_0oOOO_.OO.().Styles("SendContent").ForeColor = colorDialog.Color
				Me.Oo.Oo00__oooo.().Styles("SendContent").ForeColor = colorDialog.Color
				Me.O._o_O0O.().ForeColor = Me.O_0oOOO_.OO.().Styles("SendContent").ForeColor
			End If
		End Sub

		' Token: 0x0600131E RID: 4894 RVA: 0x0007937C File Offset: 0x0007757C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim colorDialog As ColorDialog = New ColorDialog()
			colorDialog.Color = Me.O_0oOOO_.OO.().Styles("ReceiveContent").ForeColor
			If colorDialog.ShowDialog() = DialogResult.OK Then
				Me.O_0oOOO_.OO.().Styles("ReceiveContent").ForeColor = colorDialog.Color
				Me.Oo.Oo00__oooo.().Styles("ReceiveContent").ForeColor = colorDialog.Color
			End If
		End Sub

		' Token: 0x0600131F RID: 4895 RVA: 0x000793F8 File Offset: 0x000775F8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Me.Oo0_O0o.o_. = False
			RemoveHandler Application.Idle, AddressOf Me.o_o0_0_.O.
			Dim text As String = o_O_o_oOoo__.OOOO_OO._oo.(New IMFontProperty(Me.O_0oOOO_.OO.().Styles("SendContent"), Me.O_0oOOO_.OO.().Styles("ReceiveContent")), False, vbVerticalTab, False)
			OO_00oOO.FileSys.WriteAllText(OO_00oOO.ProjectPath + "QQClient\" + Me.o.0_0_Ooo..UserName + ".cfg", text, False)
		End Sub

		' Token: 0x06001320 RID: 4896 RVA: 0x00079484 File Offset: 0x00077684
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. IsNot Nothing Then
				If Me.o.0_0_Ooo..TopicBar Is Me.Oo.Oo00__oooo.() AndAlso Me.o.0_0_Ooo..TopicPage <> Me.Oo.Oo00__oooo.().Pages(0) Then
					Dim c1TopicLink As C1TopicLink = Me.Oo.Oo00__oooo.().Pages(0).FindLinkByTag(RuntimeHelpers.GetObjectValue(Me.o.0_0_Ooo..Tag))
					If c1TopicLink Is Nothing Then
						Return
					End If
					Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName
					Me.o.0_0_Ooo. = c1TopicLink
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					Dim key As String = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
					Dim imbuddy As IMBuddy = Nothing
					If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key) Then
						imbuddy = Me.o.0_0_Ooo..oo.___oo__0_O.(key)
					End If
					If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key) Then
						imbuddy = Me.o.0_0_Ooo..oo.___oo__0_O.(key)
					End If
					If imbuddy Is Nothing Then
						Return
					End If
					Dim c1TopicLink2 As C1TopicLink = Me.Oo.Oo00__oooo.().Pages(0).FindLinkByTag(imbuddy)
					If c1TopicLink2 Is Nothing Then
						Return
					End If
					Me.o.0_0_Ooo..Text = imbuddy.SimpleName
					Me.o.0_0_Ooo. = c1TopicLink2
				End If
				Dim num As Integer = Me.o.0_0_Ooo..Index
				If Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name, "[System]", True) <> 0 Then
					Dim oOOOo0.oo0OoO0. As DataTable = Me.o.0_0_Ooo..oOOOo0.oo0OoO0.
					Dim str As String
					If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
						str = CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.()
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
						str = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.()
					Else
						str = CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name
					End If
					For Each row As DataRow In Me.o.0_0_Ooo..oOOOo0.oo0OoO0..[Select]("[Name] = '" + str + "'", "Time")
						oOOOo0.oo0OoO0..Rows.Remove(row)
					Next
					Me.Oo.Oo00__oooo.().Pages(0).Links.Remove(Me.o.0_0_Ooo.)
					Me.o.0_0_Ooo. = Nothing
					Me.O_0oOOO_.OO.().Rows.Count = 0
					Me.Oo.Oo00__oooo.().Rows.Count = 0
					If Me.Oo.Oo00__oooo.().Pages(0).Links.Count = 0 Then
						Me.Oo.Oo00__oooo.().Pages(0).PageVisible = False
						Me.oOO._O.().Enabled = False
						Me.oOo00_.0Oo.().Enabled = False
						Me.Oo_oo._O_.().Enabled = False
						Me.OO0_O0.o.().Enabled = False
						Me.oOOoo._.().Enabled = False
						Me.O._o_O0O.().Enabled = False
						Me.o_O.O000o__.().Enabled = False
						Me.O._o_O0O.().Value = ""
						Return
					End If
					num = Math.Min(num, Me.Oo.Oo00__oooo.().Pages(0).Links.Count - 1)
					Me.o.0_0_Ooo. = Me.Oo.Oo00__oooo.().Pages(0).Links(num)
					Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName + "←"
					Me.O_0oOOO_.OO.().O_O0_.__O.(Nothing)
					Me.Oo.Oo00__oooo.().O_O0_.__O.(Nothing)
					Me.o_0_.Ooo__OOoo.()
					Me.o.0_0_Ooo. = True
				End If
			End If
		End Sub

		' Token: 0x06001321 RID: 4897 RVA: 0x00079868 File Offset: 0x00077A68
		Private Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Boolean, Optional A_2 As Boolean = False)
			Try
				If Me.o.0_o0_00.().Parent Is Me.Oo.Oo00__oooo.() Then
					Me.o.0_o0_00.().Visible = False
					Me.o.0_o0_00.().Parent.Controls.Remove(Me.o.0_o0_00.())
				End If
				If Me.o_oO__.0.().Parent Is Me.Oo.Oo00__oooo.() Then
					Me.o_oO__.0.().Visible = False
					Me.o_oO__.0.().Parent.Controls.Remove(Me.o_oO__.0.())
				End If
				If Me.o.0_0_Ooo. IsNot Nothing Then
					Me.Oo.Oo00__oooo.().O000.o..Clear()
					Me.Oo.Oo00__oooo.().oOO00oo.O..Clear()
					Me.Oo.Oo00__oooo.().O000.o..Clear()
					Me.Oo.Oo00__oooo.().oO0Oo00o.00..Clear()
					Me.Oo.Oo00__oooo.().O__OO.o..Clear()
					Dim text As String
					If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
						text = CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.()
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
						text = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.()
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
						text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
					Else
						text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name
					End If
					If Me.Oo.Oo00__oooo.().Tag Is Nothing Then
						Me.Oo.Oo00__oooo.().Tag = New Dictionary(Of Integer, Integer)()
					End If
					CType(Me.Oo.Oo00__oooo.().Tag, Dictionary(Of Integer, Integer)).Clear()
					Dim text2 As String = ""
					If Me.O0O_o.O_O.().Checked Then
						text2 = ""
					ElseIf Me.o.o00_0O0o.().Checked Then
						text2 = "[Content] Like '" & ChrW(2) & "=(%)=' Or [Content] Like '" & ChrW(2) & "=?%?='"
					ElseIf Me.O._o_O0O.().Checked Then
						text2 = "[Content] Like '" & ChrW(2) & "|%|" & ChrW(2) & "' Or [Content] Like '" & ChrW(2) & "<?%?>'"
					End If
					If Operators.CompareString(text2, "", True) = 0 Then
						Me.o.0_0_Ooo..LoadFilter = "[Name] = '" + text + "'"
					Else
						Me.o.0_0_Ooo..LoadFilter = String.Concat(New String() { "[Name] = '", text, "' And (", text2, ")" })
					End If
					Me.o.0_0_Ooo..LoadTop = "30"
					Dim num As Integer = CInt(Math.Round(Me.o.0_0_Ooo..TotalPages))
					If A_0 = -1 Then
						A_0 = num - 1
					End If
					ShareLibriay.LockWindowUpdate(MyBase.Handle)
					If(A_0 >= 0 AndAlso A_0 < num) OrElse A_2 Then
						Me.Oo.Oo00__oooo.().Rows.Count = 0
						If A_0 = 0 Then
							If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
								Dim ooo As ooo0 = CType(Me.o.0_0_Ooo..Tag, ooo0)
								Me.O_0.00o.(Me.Oo.Oo00__oooo.(), ooo.oo.o0.(), Me.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.())
							ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
								Dim o_0OOOoO As O_0OOOoO = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO)
								Me.O_0.00o.(Me.Oo.Oo00__oooo.(), o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.o0O0OOo._ooO_O.().Name, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.())
							ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
								Dim o0o0_oo00Oo As o0o0_oo00Oo = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo)
								Me.O_0.00o.(Me.Oo.Oo00__oooo.(), o0o0_oo00Oo.oOO_00_0.o.(), o0o0_oo00Oo.O_oO._O.(), o0o0_oo00Oo.OO0_o.Oo0O.(), o0o0_oo00Oo.o_0o.oo_o_.(), o0o0_oo00Oo.o.oo_o0O.())
							End If
						End If
						Me.o.0_0_Ooo..LoadPage = A_0
						Me.o.0_0_Ooo..o0.o.(True, Nothing)
						Me.o.o00_0O0o.().Value = Conversions.ToString(A_0 + 1) + "/" + Conversions.ToString(num)
						If Me.o.0_0_Ooo..DataRows.Count > 0 Then
							Dim oo0O As Oo0O = Me.Oo.Oo00__oooo.()
							oo0O.BeginUpdate()
							For Each dataRow As DataRow In Me.O_0O00.___..[Select]("", "Time")
								Me.O_0.00o.(oo0O, dataRow)
								If Operators.CompareString(dataRow("Read").ToString(), "0", True) = 0 Then
									dataRow("Read") = 1
								End If
							Next
							oo0O.EndUpdate()
							If oo0O.Rows.Count > 0 Then
								If Not A_1 Then
									oo0O.ShowCell(oo0O.Rows.Count - 1, 0)
								Else
									oo0O.ShowCell(0, 0)
								End If
							End If
							oo0O.Row = -1
							If Me.O_0O00.___..GetChanges() IsNot Nothing Then
								Me.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(Me.O_0O00.___.)
							End If
						End If
					End If
					ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06001322 RID: 4898 RVA: 0x00079D88 File Offset: 0x00077F88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. Then
				Me.o.0_0_Ooo. = False
				Me.oo_0.OOoo__.(-1, False, False)
			End If
		End Sub

		' Token: 0x06001323 RID: 4899 RVA: 0x00079DA2 File Offset: 0x00077FA2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo..DataRows.Count > 0 AndAlso Me.o.0_0_Ooo..LoadPage > 0 Then
				Me.oo_0.OOoo__.(0, False, False)
			End If
		End Sub

		' Token: 0x06001324 RID: 4900 RVA: 0x00079DCE File Offset: 0x00077FCE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo..DataRows.Count > 0 AndAlso Me.o.0_0_Ooo..LoadPage > 0 Then
				Me.oo_0.OOoo__.(Me.o.0_0_Ooo..LoadPage - 1, False, False)
			End If
		End Sub

		' Token: 0x06001325 RID: 4901 RVA: 0x00079E08 File Offset: 0x00078008
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo..DataRows.Count > 0 AndAlso CDbl(Me.o.0_0_Ooo..LoadPage) < Me.o.0_0_Ooo..TotalPages - 1.0 Then
				Me.oo_0.OOoo__.(Me.o.0_0_Ooo..LoadPage + 1, True, False)
			End If
		End Sub

		' Token: 0x06001326 RID: 4902 RVA: 0x00079E60 File Offset: 0x00078060
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = CInt(Math.Round(Me.o.0_0_Ooo..TotalPages))
			If Me.o.0_0_Ooo..DataRows.Count > 0 AndAlso Me.o.0_0_Ooo..LoadPage < num - 1 Then
				Me.oo_0.OOoo__.(num - 1, True, False)
			End If
		End Sub

		' Token: 0x06001327 RID: 4903 RVA: 0x00079EB0 File Offset: 0x000780B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u As o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000 = New o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000(Me.o.0_0_Ooo., Me.O_0oOOO_.OO.())
			If o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.ShowDialog() = DialogResult.OK Then
				Application.DoEvents()
				Dim text As String = OoOo0O.OO_o.0o_O.(10)
				Dim ooo As ooo0 = New ooo0(o0___oO.o0__.0.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o.00oOo_.().Text).Replace(vbFormFeed, ""), Me.o.0_0_Ooo..ooOo.oO0., text, o0___oO.o0__.0.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.oo00O._.().Text))
				ooo.O0_.OO.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o0o.o0oO_.)
				Dim text2 As String = Me.o.0_0_Ooo..UserName
				Try
					For Each imbuddy As IMBuddy In o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o0o.o0oO_.
						text2 = text2 + "," + imbuddy.Name
					Next
				Finally
					Dim enumerator As List(Of IMBuddy).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				text2 = text2.Trim(New Char() { ","c })
				ooo.O0_.OO.(text2)
				Dim text3 As String = vbVerticalTab
				Dim s As String = String.Concat(New String() { "*", text3, Me.o.0_0_Ooo..UserName, text3, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text3, ooo.oo.o0.(), text3, o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.oo00O._.().Text.Trim(), text3, ooo.Oo_0__o.o.(), text3, text2 })
				Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
				Me.o.0_0_Ooo..O00._Oo..Send(bytes, bytes.Length, Me.o.0_0_Ooo..ooOo.oO0.)
				Dim now As DateTime = DateTime.Now
				Dim flag As Boolean
				While DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0
					If Me.o.0_0_Ooo..O00._Oo..Available > 0 Then
						Dim totalSeconds As Double = (DateTime.Now - now).TotalSeconds
						Dim ipendPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
						Dim bytes2 As Byte() = Me.o.0_0_Ooo..O00._Oo..Receive(ipendPoint)
						If Operators.CompareString(Encoding.Unicode.GetString(bytes2), "{OK}", True) = 0 Then
							flag = True
							Exit While
						End If
					End If
				End While
				If flag Then
					Dim dataRow As DataRow = Me.o.0_0_Ooo..oo00000_0o0.oO..NewRow()
					dataRow("MeetingKey") = ooo.Oo_0__o.o.()
					dataRow("Hostess") = Me.o.0_0_Ooo..UserName
					dataRow("MeetingName") = ooo.oo.o0.()
					dataRow("DateTime") = ooo.O0_.OO.()
					dataRow("Description") = ooo.O0_.OO.()
					dataRow("Members") = ooo.o0oO0O._0_.()
					dataRow("Finish") = False
					Me.o.0_0_Ooo..oo00000_0o0.oO..Rows.Add(dataRow)
					Me.o.0_0_Ooo..oo00000_0o0.oO..Update(New DataRow() { dataRow })
					Dim c1TopicLink As C1TopicLink = New C1TopicLink()
					c1TopicLink.Tag = ooo
					c1TopicLink.Text = ooo.oo.o0.()
					c1TopicLink.ImageIndex = 9
					Me.Oo.Oo00__oooo.().Pages(0).Links.Add(c1TopicLink)
					If Me.o.0_0_Ooo. IsNot Nothing Then
						If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
							Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName
						ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
							Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).oOO_00_0.o.()
						End If
					End If
					Me.O_0oOOO_.OO.().Rows.Count = 0
					Me.Oo.Oo00__oooo.().Rows.Count = 0
					Me.O_0oOOO_.OO.().O_O0_.__O.(Nothing)
					Me.Oo.Oo00__oooo.().O_O0_.__O.(Nothing)
					Me.o.0_0_Ooo. = c1TopicLink
					c1TopicLink.Text += "←"
					If Not Me.Oo.Oo00__oooo.().Pages(0).PageVisible Then
						Me.Oo.Oo00__oooo.().Pages(0).PageVisible = True
					End If
					Me.o.0_0_Ooo..oo.___oo__0_O..Add(text, ooo)
					Me.O_0.00o.(Me.O_0oOOO_.OO.(), ooo.oo.o0.(), Me.o.0_0_Ooo..UserName, ooo.O0_.OO.(), text2, DateTime.Now)
					If Not Me.OO0_O0.o.().Enabled Then
						Me.oOO._O.().Enabled = True
						Me.oOo00_.0Oo.().Enabled = True
						Me.Oo_oo._O_.().Enabled = True
						Me.OO0_O0.o.().Enabled = True
						Me.oOOoo._.().Enabled = True
						Me.O._o_O0O.().Enabled = True
						Me.o_O.O000o__.().Enabled = True
					End If
					Me.o0__.O_Ooo_.(ooo.oo.o0.(), ooo.Oo_0__o.o.(), Me.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.(), 0)
					Me.o_0_.Ooo__OOoo.()
				End If
			End If
		End Sub

		' Token: 0x06001328 RID: 4904 RVA: 0x0007A3E8 File Offset: 0x000785E8
		Private Sub <<EMPTY_NAME>>(A_0 As Oo0O, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As DateTime)
			A_0.BeginUpdate()
			A_0.Rows.Count = A_0.Rows.Count + 1
			A_0(A_0.Rows.Count - 1, 1) = Strings.Format(A_5, "yyyy年M月d日")
			A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("Date")
			A_0.Rows(A_0.Rows.Count - 1).UserData = "0"
			A_0.Rows.Count = A_0.Rows.Count + 1
			A_0(A_0.Rows.Count - 1, 1) = "会议开始:"
			A_0.Rows(A_0.Rows.Count - 1).UserData = "1"
			A_0.Rows.Count = A_0.Rows.Count + 1
			A_0(A_0.Rows.Count - 1, 1) = String.Concat(New String() { "名称:", A_1, vbCrLf & "主题:", A_3, vbCrLf & "时间:", Strings.Format(A_5, "yyyy-MM-dd HH:mm"), vbCrLf & "召集人:", A_2, vbCrLf & "参与者:", A_4 })
			A_0.Rows(A_0.Rows.Count - 1).UserData = "2"
			A_0.O_O0_.__O.(A_5.[Date])
			A_0.Rows(A_0.Rows.Count - 2).Style = A_0.Styles("ReceiveContent")
			A_0.Rows(A_0.Rows.Count - 1).Style = A_0.Styles("ReceiveContent")
			A_0.AutoSizeRow(A_0.Rows.Count - 2)
			A_0.AutoSizeRow(A_0.Rows.Count - 1)
			A_0.EndUpdate()
		End Sub

		' Token: 0x06001329 RID: 4905 RVA: 0x0007A618 File Offset: 0x00078818
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Dim ooo As ooo0 = Nothing
				If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
					ooo = CType(Me.o.0_0_Ooo..Tag, ooo0)
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					Dim o0o0_oo00Oo As o0o0_oo00Oo = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo)
					If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()) Then
						ooo = Me.o.0_0_Ooo..oo.___oo__0_O.(o0o0_oo00Oo.OO.O_o__.())
					End If
				End If
				If ooo IsNot Nothing Then
					If MessageBox.Show("确定要结束会议""" + ooo.oo.o0.() + """吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
						Dim value As Char = vbVerticalTab
						Dim a_ As String = String.Concat(New String() { "*2", Conversions.ToString(value), Me.o.0_0_Ooo..UserName, Conversions.ToString(value), Me.o.0_0_Ooo..o_oo0Oooo.OOO_., Conversions.ToString(value), ooo.Oo_0__o.o.() })
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(a_)
						Dim array As DataRow() = Me.o.0_0_Ooo..oo00000_0o0.oO..[Select]("[MeetingKey] = '" + ooo.Oo_0__o.o.() + "'", "")
						For i As Integer = 0 To array.Length - 1
							array(i)("Finish") = True
						Next
						New OleDbCommand("Update Meetings Set [Finish] = True Where [MeetingKey] = '" + ooo.Oo_0__o.o.() + "'", Me.o.0_0_Ooo..oOO0O.O0O0.).ExecuteNonQuery()
						If Me.o.0_0_Ooo. IsNot Nothing AndAlso TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
							Me.Oo_oo._O_.().PerformClick()
							Me.o.0_0_Ooo..oo.___oo__0_O..Remove(ooo.Oo_0__o.o.())
							If Me.O_0oOOO_.OO.().Pages.Count > 0 Then
								Dim num As Integer = Me.O_0oOOO_.OO.().Pages.Count - 1
								For j As Integer = 0 To num
									Dim c1TopicPage As C1TopicPage = Me.O_0oOOO_.OO.().Pages(j)
									Try
										For Each obj As Object In c1TopicPage.Links
											Dim c1TopicLink As C1TopicLink = CType(obj, C1TopicLink)
											If Operators.CompareString(CType(c1TopicLink.Tag, o0o0_oo00Oo).OO.O_o__.(), ooo.Oo_0__o.o.(), True) = 0 Then
												c1TopicLink.ImageIndex = 13
												CType(c1TopicLink.Tag, o0o0_oo00Oo).o.oo_o0O.(True)
												If Me.o.0_0_Ooo. Is Nothing OrElse Me.o.0_0_Ooo. = c1TopicLink Then
													Me.oOO._O.().Enabled = False
													Me.oOo00_.0Oo.().Enabled = False
													Me.Oo_oo._O_.().Enabled = False
													Me.OO0_O0.o.().Enabled = False
													Me.oOOoo._.().Enabled = False
													Me.O._o_O0O.().Enabled = False
													Me.o_O.O000o__.().Enabled = False
												End If
											End If
										Next
									Finally
										Dim enumerator As IEnumerator
										If TypeOf enumerator Is IDisposable Then
											TryCast(enumerator, IDisposable).Dispose()
										End If
									End Try
								Next
							End If
						End If
					End If
				End If
			Catch a_2 As Exception
				ooO.oOo0Oo.o.(a_2, "")
			End Try
		End Sub

		' Token: 0x0600132A RID: 4906 RVA: 0x0007A984 File Offset: 0x00078B84
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As DateTime, Optional A_6 As Integer = -1)
			Dim flag As Boolean = True
			Dim text As String = Strings.Format(A_5, "yyyy年MM月")
			If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(A_1) OrElse Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(A_1) Then
				flag = False
			End If
			If Me.O_0oOOO_.OO.().FindPage(text) Is Nothing Then
				Dim c1TopicPage As C1TopicPage = New C1TopicPage()
				c1TopicPage.Text = text
				Me.O_0oOOO_.OO.().Pages.Add(c1TopicPage)
				c1TopicPage.ImageList = Me.O_0oOOO_.OO.()
			End If
			Dim tag As o0o0_oo00Oo = New o0o0_oo00Oo(A_0, A_1, A_2, A_3, A_4, flag)
			Dim c1TopicLink As C1TopicLink = New C1TopicLink()
			c1TopicLink.Tag = tag
			c1TopicLink.Text = A_0
			If flag Then
				c1TopicLink.ImageIndex = 13
			Else
				c1TopicLink.ImageIndex = 9
			End If
			Dim c1TopicPage2 As C1TopicPage = Me.O_0oOOO_.OO.().FindPage(text)
			If A_6 = -1 Then
				c1TopicPage2.Links.Add(c1TopicLink)
			Else
				c1TopicPage2.Links.Insert(0, c1TopicLink)
			End If
			If Not Me.oOOoo._.().TabPages(1).TabVisible Then
				Me.oOOoo._.().TabPages(1).TabVisible = True
			End If
		End Sub

		' Token: 0x0600132B RID: 4907 RVA: 0x0007AAA4 File Offset: 0x00078CA4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarClickEventArgs)
			If Me.o.0_0_Ooo. <> A_1.Link Then
				If Me.o.0_0_Ooo. IsNot Nothing Then
					If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
						Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).SimpleName
					ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
						Me.o.0_0_Ooo..Text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).oOO_00_0.o.()
					End If
				End If
				A_1.Link.Text = CType(A_1.Link.Tag, o0o0_oo00Oo).oOO_00_0.o.() + "←"
				Dim text As String = CType(A_1.Link.Tag, o0o0_oo00Oo).OO.O_o__.()
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
					Dim c1TopicLink As C1TopicLink = Me.Oo.Oo00__oooo.().Pages(0).FindLinkByTag(Me.o.0_0_Ooo..oo.___oo__0_O.(text))
					If c1TopicLink IsNot Nothing Then
						c1TopicLink.Text = Me.o.0_0_Ooo..oo.___oo__0_O.(text).oo.o0.()
					End If
				End If
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text) Then
					Dim c1TopicLink2 As C1TopicLink = Me.Oo.Oo00__oooo.().Pages(0).FindLinkByTag(Me.o.0_0_Ooo..oo.___oo__0_O.(text))
					If c1TopicLink2 IsNot Nothing Then
						c1TopicLink2.Text = Me.o.0_0_Ooo..oo.___oo__0_O.(text).oo_.__OoOO0OO0.()
					End If
				End If
				If Me.o.0_0_Ooo. IsNot Nothing AndAlso TypeOf Me.o.0_0_Ooo..Tag Is ooo0 AndAlso Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.(), text, True) = 0 Then
					Me.o.0_0_Ooo. = A_1.Link
					Return
				End If
				If Me.o.0_0_Ooo. IsNot Nothing AndAlso TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO AndAlso Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.(), text, True) = 0 Then
					Me.o.0_0_Ooo. = A_1.Link
					Return
				End If
				Dim flag As Boolean
				If Me.o.0_0_Ooo. Is Nothing Then
					flag = True
				ElseIf Me.o.0_0_Ooo..Tag IsNot A_1.Link.Tag Then
					flag = True
				End If
				Me.o.0_0_Ooo. = A_1.Link
				If flag Then
					Me.O_0oOOO_.OO.().Rows.Count = 0
					Me.Oo.Oo00__oooo.().Rows.Count = 0
					Me.O_0oOOO_.OO.().O_O0_.__O.(Nothing)
					Me.Oo.Oo00__oooo.().O_O0_.__O.(Nothing)
					Me.o.0_0_Ooo. = False
					Me.o_0_.Ooo__OOoo.()
					Me.oo_0.OOoo__.(-1, False, False)
				End If
				Dim flag2 As Boolean = Not CType(A_1.Link.Tag, o0o0_oo00Oo).O_oO._O.()
				Me.oOO._O.().Enabled = flag2
				Me.oOo00_.0Oo.().Enabled = flag2
				Me.Oo_oo._O_.().Enabled = flag2
				Me.OO0_O0.o.().Enabled = flag2
				Me.oOOoo._.().Enabled = True
				Me.O._o_O0O.().Enabled = flag2
				Me.o_O.O000o__.().Enabled = flag2
				If Not flag2 Then
					Me.ooO.0o00__0.().SelectedIndex = 1
				End If
			End If
		End Sub

		' Token: 0x0600132C RID: 4908 RVA: 0x0007ADC4 File Offset: 0x00078FC4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. IsNot Nothing Then
				Dim windowState As FormWindowState = OO_00oOO.BaseMainForm.WindowState
				Dim flag As Boolean
				If Control.ModifierKeys = Keys.Control Then
					flag = True
				End If
				If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
						Return
					End If
					Me.oooo_0ooOo0.0O.()
				Else
					Me.OooOO_o0O0_._.()
				End If
				If Operators.CompareString(CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name, "[System]", True) <> 0 Then
					If CType(Me.o.0_0_Ooo..Tag, IMBuddy).oOo.o0__0Oo0oO. = 0 OrElse CType(Me.o.0_0_Ooo..Tag, IMBuddy).O00OO.o_. = 0 OrElse Me.o.0_0_Ooo..ThroughServer Then
						flag = True
					End If
					If Me.O_.O0ooO.().Checked Then
						MyBase.WindowState = FormWindowState.Minimized
						MyBase.Hide()
						Application.DoEvents()
					ElseIf Me.o.0_o0_00.().Checked Then
						MyBase.WindowState = FormWindowState.Minimized
						OO_00oOO.BaseMainForm.WindowState = FormWindowState.Minimized
						OO_00oOO.BaseMainForm.Hide()
						Application.DoEvents()
					End If
					Try
						Dim text As String = O_O0OO.o.00O_O.() + "capture.exe"
						If OO_00oOO.FileSys.FileExists(text) Then
							Dim image As Image = Clipboard.GetImage()
							If image IsNot Nothing Then
								Clipboard.Clear()
							End If
							Dim process As Process = New Process()
							process.File = text
							process.Start()
							process.WaitForExit()
							Dim image2 As Image = Clipboard.GetImage()
							If image2 Is Nothing Then
								If image IsNot Nothing Then
									Clipboard.SetImage(image)
								End If
							Else
								Dim tempFileName As String = Path.GetTempFileName()
								Dim tempFileName2 As String = Path.GetTempFileName()
								image2.Save(tempFileName, ImageFormat.Png)
								image2.Save(tempFileName2, ImageFormat.Jpeg)
								Dim fileInfo As FileInfo = New FileInfo(tempFileName)
								Dim fileInfo2 As FileInfo = New FileInfo(tempFileName2)
								Dim text2 As String
								If fileInfo.Length < fileInfo2.Length Then
									text2 = ".png"
									OO_00oOO.FileSys.DeleteFile(tempFileName2)
								Else
									text2 = ".jpg"
									OO_00oOO.FileSys.DeleteFile(tempFileName)
								End If
								Dim text3 As String = String.Concat(New String() { OO_00oOO.ProjectPath, "QQClient\CaptureFiles\", Strings.Format(DateTime.Today, "yyyyMM"), "\", OoOo0O.OO_o.0o_O.(10), text2 })
								Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text3)
								If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
									OO_00oOO.FileSys.CreateDirectory(parentPath)
								End If
								If Operators.CompareString(text2, ".png", True) = 0 Then
									OO_00oOO.FileSys.MoveFile(tempFileName, text3)
								Else
									OO_00oOO.FileSys.MoveFile(tempFileName2, text3)
								End If
								Me.oO_o_.___ooOO.(text3.Substring((OO_00oOO.ProjectPath + "QQClient\CaptureFiles\").Length))
								If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
									Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
									Dim parameter As Object() = New Object() { imbuddy, text3, SendTypeEnum.Capture, Nothing, flag }
									AddressOf Me.o.0_0_Ooo..O00__O._O_00o..Start(parameter)
								End If
							End If
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					Finally
						If Not OO_00oOO.BaseMainForm.Visible Then
							OO_00oOO.BaseMainForm.Show()
						End If
						If Not MyBase.Visible Then
							MyBase.Show(OO_00oOO.BaseMainForm)
						End If
						If OO_00oOO.BaseMainForm.WindowState = FormWindowState.Minimized Then
							OO_00oOO.BaseMainForm.WindowState = windowState
						End If
						If MyBase.WindowState = FormWindowState.Minimized Then
							MyBase.WindowState = FormWindowState.Normal
						End If
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600132D RID: 4909 RVA: 0x0007B184 File Offset: 0x00079384
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Try
				If Me.o.0_0_Ooo. IsNot Nothing Then
					If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
						If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
							Return
						End If
						Me.oooo_0ooOo0.0O.()
					Else
						Me.OooOO_o0O0_._.()
					End If
					If Operators.CompareString(A_0, "", True) <> 0 Then
						Dim a_ As String = ChrW(2) & "=(" + A_0 + ")="
						Dim a_2 As String = Nothing
						Dim a_3 As String
						If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
							a_3 = CType(Me.o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.()
							a_2 = Me.o.0_0_Ooo..UserName
						ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
							a_3 = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.()
							a_2 = Me.o.0_0_Ooo..UserName
						Else
							If Not(TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy) Then
								Return
							End If
							a_3 = CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name
						End If
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(a_3, a_, 2, 1, a_2)
					End If
				End If
			Catch a_4 As Exception
				ooO.oOo0Oo.o.(a_4, "")
			End Try
		End Sub

		' Token: 0x0600132E RID: 4910 RVA: 0x0007B2E4 File Offset: 0x000794E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.O_0oOOO_.OO.(), Me.Oo.Oo00__oooo.() }
				If c1FlexGrid.Tag Is Nothing Then
					Exit For
				End If
				Dim dictionary As Dictionary(Of Integer, Integer) = CType(c1FlexGrid.Tag, Dictionary(Of Integer, Integer))
				Try
					For Each num As Integer In dictionary.Values
						Dim text As String = c1FlexGrid(num, 1).ToString()
						Dim num2 As Integer
						If text.IndexOf(".") < 0 Then
							num2 = 1
						Else
							num2 = text.Length - text.IndexOf(".")
							If num2 = 6 Then
								num2 = 1
							Else
								num2 += 1
							End If
						End If
						c1FlexGrid(num, 1) = "正在加载 " + ".".PadRight(num2, "."c)
					Next
				Finally
					Dim enumerator As Dictionary(Of Integer, Integer).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			Next
		End Sub

		' Token: 0x0600132F RID: 4911 RVA: 0x0007B3E8 File Offset: 0x000795E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.O AndAlso (Control.ModifierKeys And Keys.Control) = Keys.Control AndAlso (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
				Me.o_O.O000o__.().PerformClick()
			End If
		End Sub

		' Token: 0x06001330 RID: 4912 RVA: 0x0007B423 File Offset: 0x00079623
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Oo0_O0o.o_. = True
			AddHandler Application.Idle, AddressOf Me.o_o0_0_.O.
		End Sub

		' Token: 0x06001331 RID: 4913 RVA: 0x0007B440 File Offset: 0x00079640
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo..AllowSendFile Then
				Try
					If Me.o.0_0_Ooo. IsNot Nothing Then
						If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
							If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
								Return
							End If
							Me.oooo_0ooOo0.0O.()
						Else
							Me.OooOO_o0O0_._.()
						End If
						Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
						If Operators.CompareString(imbuddy.Name, "[System]", True) <> 0 Then
							Dim flag As Boolean
							If Control.ModifierKeys = Keys.Control Then
								flag = True
							End If
							Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
							openFileDialog.Multiselect = True
							If openFileDialog.ShowDialog() = DialogResult.OK Then
								If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
									If CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).O_oO._O.() Then
										Return
									End If
									Me.oooo_0ooOo0.0O.()
								Else
									Me.OooOO_o0O0_._.()
								End If
								Dim text As String = vbVerticalTab
								For Each text2 As String In openFileDialog.FileNames
									Dim oO As oO0 = New oO0(Me.o.0_0_Ooo., imbuddy, text2, SendTypeEnum.ManualFile)
									oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(text2)
									Dim fileInfo As FileInfo = New FileInfo(text2)
									Dim text3 As String
									If fileInfo.Length / 1024L < 1000L Then
										text3 = (fileInfo.Length / 1024L).ToString() + "K"
									Else
										text3 = Strings.Format(CDbl(fileInfo.Length) / 1024.0 / 1024.0, "0.00") + "M"
									End If
									oO.o_0O.00.().Text = text3
									If Me.o.0_0_Ooo..ooOooo.oO. Is Nothing Then
										Me.o.0_0_Ooo..ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(Me.o.0_0_Ooo.)
										Me.o.0_0_Ooo..ooOooo.oO..Owner = OO_00oOO.BaseMainForm
									End If
									Me.o.0_0_Ooo..ooOooo.oO..O_0O_o.0.(oO)
									Me.o.0_0_Ooo..ooOooo.oO..Show()
									If CType(Me.o.0_0_Ooo..Tag, IMBuddy).oOo.o0__0Oo0oO. = 0 OrElse CType(Me.o.0_0_Ooo..Tag, IMBuddy).O00OO.o_. = 0 OrElse flag Then
										Dim parameter As Object() = New Object() { imbuddy, text2, SendTypeEnum.ManualFile, oO, flag }
										oO.o.oo00_.().Visible = False
										AddressOf Me.o.0_0_Ooo..O00__O._O_00o..Start(parameter)
										If TypeOf imbuddy Is ooo0 OrElse TypeOf imbuddy Is O_0OOOoO Then
											Dim a_ As String = String.Concat(New String() { ChrW(2) & "(我方开始上传文件""", OO_00oOO.FileSys.GetName(text2), """(", text3, "))" & ChrW(2) })
											Me.o.0_0_Ooo..O.00O0_O_o_oO.(o0___oO.o0__.0.(imbuddy), a_, 2, 1, Me.o.0_0_Ooo..UserName)
										Else
											Dim a_ As String = String.Concat(New String() { ChrW(2) & "(我方开始离线发送文件""", OO_00oOO.FileSys.GetName(text2), """(", text3, "))" & ChrW(2) })
											Me.o.0_0_Ooo..O.00O0_O_o_oO.(o0___oO.o0__.0.(imbuddy), a_, 2, 1, Nothing)
										End If
									Else
										Dim a_2 As String = String.Concat(New String() { "%5", text, Me.o.0_0_Ooo..UserName, text, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text, oO.o0O.Oo., text, OO_00oOO.FileSys.GetName(text2), text, text3 })
										Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, a_2)
										a_2 = String.Concat(New String() { ChrW(2) & "(我方请求发送文件""", OO_00oOO.FileSys.GetName(text2), """(", text3, "))" & ChrW(2) })
										Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, a_2, 2, 1, Nothing)
									End If
								Next
							End If
						End If
					End If
				Catch a_3 As Exception
					ooO.oOo0Oo.o.(a_3, "")
				End Try
			End If
		End Sub

		' Token: 0x06001332 RID: 4914 RVA: 0x0007B8C0 File Offset: 0x00079AC0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ooo As ooo0 = Nothing
			If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
				ooo = CType(Me.o.0_0_Ooo..Tag, ooo0)
			ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
				Dim o0o0_oo00Oo As o0o0_oo00Oo = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo)
				If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()) Then
					ooo = Me.o.0_0_Ooo..oo.___oo__0_O.(o0o0_oo00Oo.OO.O_o__.())
				End If
			End If
			If ooo IsNot Nothing Then
				Dim o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u As o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000 = New o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000(Me.o.0_0_Ooo., Me.O_0oOOO_.OO.(), ooo.O0_.OO.())
				If o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
					Dim text As String = vbVerticalTab
					Dim text2 As String = ""
					Dim text3 As String = ""
					Dim text4 As String = String.Concat(New String() { "*2", text, Me.o.0_0_Ooo..UserName, text, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text, ooo.Oo_0__o.o.() })
					Try
						For Each imbuddy As IMBuddy In ooo.O0_.OO.()
							If Not o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo..Contains(imbuddy) Then
								text3 = text3 + "," + imbuddy.Name
								If imbuddy.OnLine Then
									Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text4)
								End If
							End If
						Next
					Finally
						Dim enumerator As List(Of IMBuddy).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Dim text5 As String = Me.o.0_0_Ooo..UserName
					Try
						For Each imbuddy2 As IMBuddy In o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.
							text5 = text5 + "," + imbuddy2.Name
						Next
					Finally
						Dim enumerator2 As List(Of IMBuddy).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					text5 = text5.Trim(New Char() { ","c })
					text4 = String.Concat(New String() { "*", text, Me.o.0_0_Ooo..UserName, text, ooo.oo.o0.(), text, ooo.O0_.OO.(), text, ooo.Oo_0__o.o.(), text, text5, text, Strings.Format(ooo.O0_.OO.(), "MM/dd/yyyy HH:ss") })
					Try
						For Each imbuddy3 As IMBuddy In o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.
							If Not ooo.O0_.OO.().Contains(imbuddy3) Then
								text2 = text2 + "," + imbuddy3.Name
								If imbuddy3.OnLine Then
									Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy3.Name, text4)
								End If
							Else
								Me.o.0_0_Ooo..Send(imbuddy3.Name, String.Concat(New String() { text, Me.o.0_0_Ooo..UserName, text, ooo.oo.o0.(), text, text5 }), False, False)
							End If
						Next
					Finally
						Dim enumerator3 As List(Of IMBuddy).Enumerator
						CType(enumerator3, IDisposable).Dispose()
					End Try
					ooo.O0_.OO.(o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.)
					ooo.O0_.OO.(text5)
					text4 = String.Concat(New String() { "*3", text, Me.o.0_0_Ooo..UserName, text, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text, ooo.Oo_0__o.o.(), text, text5 })
					Me.o.0_0_Ooo..O.00O0_O_o_oO.(text4)
					text4 = String.Concat(New String() { "*3", text, Me.o.0_0_Ooo..UserName, text, Me.o.0_0_Ooo..o_oo0Oooo.OOO_., text, ooo.Oo_0__o.o.(), text, text2.Trim(New Char() { ","c }), text, text3.Trim(New Char() { ","c }) })
					Try
						For Each imbuddy4 As IMBuddy In ooo.O0_.OO.()
							If imbuddy4.OnLine Then
								Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy4.Name, text4)
							End If
						Next
					Finally
						Dim enumerator4 As List(Of IMBuddy).Enumerator
						CType(enumerator4, IDisposable).Dispose()
					End Try
					If Operators.CompareString(text2.Trim(New Char() { ","c }), "", True) > 0 Then
						text4 = ChrW(2) & "(有新用户加入会议:" & vbCrLf + text2.Trim(New Char() { ","c }) + ")" & ChrW(2)
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(ooo.Oo_0__o.o.(), text4, 2, 1, Me.o.0_0_Ooo..UserName)
					End If
					If Operators.CompareString(text3.Trim(New Char() { ","c }), "", True) > 0 Then
						text4 = ChrW(2) & "(有用户被请出会议:" & vbCrLf + text3.Trim(New Char() { ","c }) + ")" & ChrW(2)
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(ooo.Oo_0__o.o.(), text4, 2, 1, Me.o.0_0_Ooo..UserName)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001333 RID: 4915 RVA: 0x0007BE14 File Offset: 0x0007A014
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.O_O0__0_0.().BackColor = Color.FromArgb(241, 248, 254)
		End Sub

		' Token: 0x06001334 RID: 4916 RVA: 0x0007BE35 File Offset: 0x0007A035
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.O_O0__0_0.().BackColor = Color.FromArgb(187, 206, 230)
		End Sub

		' Token: 0x06001335 RID: 4917 RVA: 0x0007BE58 File Offset: 0x0007A058
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.O00oO0_.O.()
			Dim visible As Boolean
			If Me.o.0_0_Ooo. IsNot Nothing Then
				If TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
					visible = True
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					Dim o0o0_oo00Oo As o0o0_oo00Oo = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo)
					If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()) Then
						visible = True
					End If
				End If
			End If
			Me.ooOoo___0.oO0.().Visible = visible
			Me.o_oO__.0.().Visible = visible
			Me.o.0_o0_00.().Visible = visible
			Me.O0oO_Oo0oO_.o.().Show(Me.O.O_O0__0_0.(), 0, Me.O.O_O0__0_0.().Height)
		End Sub

		' Token: 0x06001336 RID: 4918 RVA: 0x0007BF08 File Offset: 0x0007A108
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo0O As Oo0O = CType(A_0, Oo0O)
			If oo0O.O000.o..ContainsKey(oo0O.RowSel) AndAlso OO_00oOO.FileSys.FileExists(oo0O.O000.o.(oo0O.RowSel)) Then
				Process.Start(oo0O.O000.o.(oo0O.RowSel))
			End If
		End Sub

		' Token: 0x06001337 RID: 4919 RVA: 0x0007BF64 File Offset: 0x0007A164
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_o._o0___.().ForeColor = Me.O_0oOOO_.OO.().Styles.Highlight.ForeColor
			Me.Oo.Oo00__oooo.().ForeColor = Me.O_0oOOO_.OO.().Styles.Highlight.ForeColor
			Me.o.o__0o.().ForeColor = Me.O_0oOOO_.OO.().Styles.Highlight.ForeColor
			Try
				Dim oo0O As Oo0O = CType(A_0, Oo0O)
				If oo0O.Rows.Count <> 0 Then
					Dim bottomRow As Integer = oo0O.Selection.BottomRow
					If(Not Me.o.0_o0_00.().Visible OrElse Me.o.0_o0_00.().Parent IsNot A_0) AndAlso oo0O.O000.o..ContainsKey(bottomRow) Then
						oo0O.BeginUpdate()
						Me.o.0_o0_00.().Visible = False
						Dim x As Integer = oo0O.Width - Me.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
						Dim y As Integer = oo0O.Rows(bottomRow).Bottom - Me.o.0_o0_00.().Height + oo0O.ScrollPosition.Y
						Me.o.0_o0_00.().Location = New Point(x, y)
						Me.o.0_o0_00.().Tag = bottomRow
						Me.o.0_o0_00.().Anchor = AnchorStyles.Right
						oo0O.Controls.Add(Me.o.0_o0_00.())
						Me.o.0_o0_00.().Visible = True
						oo0O.EndUpdate()
					End If
					If(Not Me.o.o00_0O0o.().Visible OrElse Me.o.o00_0O0o.().Parent IsNot A_0) AndAlso oo0O.oO0Oo00o.00..ContainsKey(bottomRow) Then
						oo0O.BeginUpdate()
						Me.o.o00_0O0o.().Visible = False
						Dim x2 As Integer = oo0O.Width - Me.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
						Dim y2 As Integer = oo0O.Rows(bottomRow).Top - Me.o.o00_0O0o.().Height + oo0O.ScrollPosition.Y - 5
						Me.o.o00_0O0o.().Location = New Point(x2, y2)
						Me.o.o00_0O0o.().Tag = bottomRow
						Me.o.o00_0O0o.().Anchor = AnchorStyles.Right
						oo0O.Controls.Add(Me.o.o00_0O0o.())
						Me.o.o00_0O0o.().Visible = True
						oo0O.EndUpdate()
					End If
					If(Not Me.o_oO__.0.().Visible OrElse Me.o_oO__.0.().Parent IsNot A_0) AndAlso oo0O.oOO00oo.O..ContainsKey(bottomRow) Then
						oo0O.BeginUpdate()
						Me.o_oO__.0.().Visible = False
						Dim x3 As Integer = oo0O.Width - Me.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
						Dim y3 As Integer = oo0O.Rows(bottomRow).Bottom - Me.o_oO__.0.().Height + oo0O.ScrollPosition.Y
						Me.o_oO__.0.().Location = New Point(x3, y3)
						Me.o_oO__.0.().Tag = bottomRow
						Me.o_oO__.0.().Anchor = AnchorStyles.Right
						oo0O.Controls.Add(Me.o_oO__.0.())
						Me.o_oO__.0.().Visible = True
						oo0O.EndUpdate()
					End If
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06001338 RID: 4920 RVA: 0x0007C328 File Offset: 0x0007A528
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo0O As Oo0O = CType(Me.o.0_o0_00.().Parent, Oo0O)
			Dim key As Integer = Conversions.ToInteger(Me.o.0_o0_00.().Tag)
			If oo0O.O000.o..ContainsKey(key) Then
				Dim text As String = oo0O.O000.o.(key)("Content").ToString()
				text = text.Substring(2, text.Length - 4)
				Dim array As String() = text.Split(New Char() { vbTab })
				text = OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\" + array(0)
				If OO_00oOO.FileSys.FileExists(text) Then
					New Process() With { .StartInfo = { .FileName = text } }.Start()
				End If
			End If
		End Sub

		' Token: 0x06001339 RID: 4921 RVA: 0x0007C3DC File Offset: 0x0007A5DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo0O As Oo0O = CType(Me.o.0_o0_00.().Parent, Oo0O)
			Dim key As Integer = Conversions.ToInteger(Me.o.0_o0_00.().Tag)
			If oo0O.O000.o..ContainsKey(key) Then
				Dim text As String = oo0O.O000.o.(key)("Content").ToString()
				text = text.Substring(2, text.Length - 4)
				Dim array As String() = text.Split(New Char() { vbTab })
				text = OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\" + array(0)
				If OO_00oOO.FileSys.FileExists(text) Then
					Process.Start("explorer.exe", "/select," + text)
				End If
			End If
		End Sub

		' Token: 0x0600133A RID: 4922 RVA: 0x0007C490 File Offset: 0x0007A690
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo0O As Oo0O = CType(Me.o_oO__.0.().Parent, Oo0O)
			Dim key As Integer = Conversions.ToInteger(Me.o_oO__.0.().Tag)
			Try
				If oo0O.oOO00oo.O..ContainsKey(key) Then
					Dim dataRow As DataRow = oo0O.oOO00oo.O.(key)
					Dim item As Integer = Conversions.ToInteger(dataRow("_Identify"))
					Dim oOO0_O.O__0_0. As Object = Me.o.0_0_Ooo..oOO0_O.O__0_0.
					SyncLock oOO0_O.O__0_0.
						If Not Me.o.0_0_Ooo..oOO0_O.O__0_0..Contains(item) Then
							Dim text As String = dataRow("Content").ToString()
							If text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) OrElse text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".com", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".cn", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(".net", StringComparison.CurrentCultureIgnoreCase) Then
								Process.Start(text)
							Else
								text = text.Substring(3, text.Length - 5)
								Dim array As String() = text.Split(New Char() { vbTab })
								If array.Length >= 2 Then
									Dim array2 As Object() = New Object(4) {}
									array2(0) = array(0)
									If TypeOf Me.o.0_0_Ooo..Tag Is IMBuddy Then
										array2(1) = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
									ElseIf TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
										Dim key2 As String = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).OO.O_o__.()
										If Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key2) Then
											array2(1) = Me.o.0_0_Ooo..oo.___oo__0_O.(key2)
										ElseIf Me.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key2) Then
											array2(1) = Me.o.0_0_Ooo..oo.___oo__0_O.(key2)
										Else
											array2(1) = Nothing
										End If
									Else
										array2(1) = Nothing
									End If
									array2(2) = dataRow
									array2(3) = SendTypeEnum.ManualFile
									array2(4) = array(1)
									Me.O_o._o0___.().Text = "下载中..."
									Me.O_o._o0___.().Cursor = Cursors.[Default]
									Me.o.0_0_Ooo..oOO0_O.O__0_0..Add(Conversions.ToInteger(dataRow("_Identify")))
									AddressOf Me.o0__.O_Ooo_..Start(array2)
								End If
							End If
						End If
					End SyncLock
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x0600133B RID: 4923 RVA: 0x0007C750 File Offset: 0x0007A950
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0_o0_00.().Visible = False
			Me.o_oO__.0.().Visible = False
		End Sub

		' Token: 0x0600133C RID: 4924 RVA: 0x0007C76A File Offset: 0x0007A96A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0O_o.O_O.().Checked Then
				Me.oo_0.OOoo__.(0, False, True)
			End If
		End Sub

		' Token: 0x0600133D RID: 4925 RVA: 0x0007C782 File Offset: 0x0007A982
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.o00_0O0o.().Checked Then
				Me.oo_0.OOoo__.(0, False, True)
			End If
		End Sub

		' Token: 0x0600133E RID: 4926 RVA: 0x0007C79A File Offset: 0x0007A99A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O._o_O0O.().Checked Then
				Me.oo_0.OOoo__.(0, False, True)
			End If
		End Sub

		' Token: 0x0600133F RID: 4927 RVA: 0x0007C7B4 File Offset: 0x0007A9B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0_Ooo. IsNot Nothing Then
				Dim flag As Boolean
				If Control.ModifierKeys = Keys.Control Then
					flag = True
				End If
				If Not(TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo) AndAlso Not(TypeOf Me.o.0_0_Ooo..Tag Is ooo0) AndAlso Not(TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO) Then
					Me.OooOO_o0O0_._.()
					Dim imbuddy As IMBuddy = CType(Me.o.0_0_Ooo..Tag, IMBuddy)
					Dim oo0O As Oo0O = CType(Me.o.o00_0O0o.().Parent, Oo0O)
					Dim key As Integer = Conversions.ToInteger(Me.o.o00_0O0o.().Tag)
					Dim text As String = oo0O.oO0Oo00o.00.(key)("Content").ToString()
					text = text.Substring(2, text.Length - 4)
					If text.StartsWith(ChrW(2) & "=(") AndAlso text.EndsWith(")=") Then
						Dim text2 As String = OO_00oOO.ProjectPath + "QQClient\CaptureFiles\" + text.Substring(3, text.Length - 5)
						If OO_00oOO.FileSys.FileExists(text2) Then
							Me.oO_o_.___ooOO.(text.Substring(3, text.Length - 5))
							Dim parameter As Object() = New Object() { imbuddy, text2, SendTypeEnum.Capture, Nothing, flag }
							AddressOf Me.o.0_0_Ooo..O00__O._O_00o..Start(parameter)
							Return
						End If
					Else
						If imbuddy.OnLine Then
							Me.o.0_0_Ooo..O_._00O0_. = Me.o.0_0_Ooo..O_._00O0_. + 1
							Me.o.0_0_Ooo..ooOo.oO0..Add(Me.o.0_0_Ooo..O_._00O0_., New O0o000(imbuddy, text))
							If Control.ModifierKeys = Keys.Control Then
								Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, True)
							Else
								Me.o.0_0_Ooo..Send(imbuddy.Name, String.Concat(New String() { "={", text, ChrW(4), Me.o.0_0_Ooo..O_._00O0_..ToString(), "}=" }), True, False)
							End If
						Else
							Me.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", True, False)
						End If
						Me.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, Nothing)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001340 RID: 4928 RVA: 0x0007CA58 File Offset: 0x0007AC58
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim num As Integer
			If A_1.KeyCode = Keys.[Return] AndAlso Operators.CompareString(Me.o.o00_0O0o.().Text, "", True) > 0 AndAlso Integer.TryParse(Me.o.o00_0O0o.().Text.Trim(), num) Then
				num -= 1
				If Me.o.0_0_Ooo..LoadPage <> num AndAlso num >= 0 AndAlso CDbl(num) < Me.o.0_0_Ooo..TotalPages Then
					Me.oo_0.OOoo__.(num, True, True)
				End If
			End If
		End Sub

		' Token: 0x06001341 RID: 4929 RVA: 0x0007CAD0 File Offset: 0x0007ACD0
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim oo0O As Oo0O = Me.O_0oOOO_.OO.()
			oo0O.AddItem(vbTab + Strings.Format(DateTime.Now, "HH:mm:ss"))
			oo0O.SetCellImage(oo0O.Rows.Count - 1, 1, Me.O_0oOOO_.OO.().Images("info"))
			oo0O.Rows(oo0O.Rows.Count - 1).UserData = "1"
			oo0O.Rows.Count = oo0O.Rows.Count + 1
			Me.O_0oOOO_.OO.()(oo0O.Rows.Count - 1, 1) = A_0
			oo0O.Rows(oo0O.Rows.Count - 1).UserData = "2"
			oo0O.Rows(oo0O.Rows.Count - 2).Style = oo0O.Styles("System")
			oo0O.Rows(oo0O.Rows.Count - 1).Style = oo0O.Styles("System")
			oo0O.ShowCell(oo0O.Rows.Count - 1, 1)
		End Sub

		' Token: 0x06001342 RID: 4930 RVA: 0x0007CC18 File Offset: 0x0007AE18
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim client_ChangeUserPasswordEventArgs As Client_ChangeUserPasswordEventArgs = New Client_ChangeUserPasswordEventArgs(Me.o.0_0_Ooo.)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_UserChangePassword", New Object() { client_ChangeUserPasswordEventArgs }, True, "项目", False)
		End Sub

		' Token: 0x06001343 RID: 4931 RVA: 0x0007CC52 File Offset: 0x0007AE52
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.o_oO__.0.().Show(Me.oOOoo._.(), 0, Me.oOOoo._.().Height)
		End Sub

		' Token: 0x06001344 RID: 4932 RVA: 0x0007CC71 File Offset: 0x0007AE71
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO0_O0.o.().PerformClick()
		End Sub

		' Token: 0x06001345 RID: 4933 RVA: 0x0007CC80 File Offset: 0x0007AE80
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.O._o_O0O.().Text, "", True) > 0 Then
				MyBase.SuspendLayout()
				Dim text As String = Me.O._o_O0O.().Text
				Me.O._o_O0O.().Value = "{!}" + text
				Me.OO0_O0.o.().PerformClick()
				If Operators.CompareString(Me.O._o_O0O.().Text, "", True) > 0 Then
					Me.O._o_O0O.().Value = text
				End If
				MyBase.ResumeLayout()
			End If
		End Sub

		' Token: 0x06001346 RID: 4934 RVA: 0x0007CD04 File Offset: 0x0007AF04
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.o.0_0_Ooo..MenuItems, "", True) > 0 Then
				Me.O0oO_Oo0oO_.o.().Items.Clear()
				If Me.o.0_0_Ooo..MenuItems.StartsWith("|") Then
					Me.O0oO_Oo0oO_.o.().Items.Add(Me.ooOoo___0.oO0.())
					Me.O0oO_Oo0oO_.o.().Items.Add(Me.o_oO__.0.())
					Me.O0oO_Oo0oO_.o.().Items.Add(Me.o.0_o0_00.())
					Me.O0oO_Oo0oO_.o.().Items.Add(Me.O0_O_0__o._.())
				End If
				For Each text As String In Me.o.0_0_Ooo..MenuItems.Split(New Char() { "|"c })
					If Operators.CompareString(text.Trim(), "", True) > 0 Then
						AddHandler Me.O0oO_Oo0oO_.o.().Items.Add(text).Click, AddressOf Me.o0_oo.o_0o_O0_.
					End If
				Next
			End If
		End Sub

		' Token: 0x06001347 RID: 4935 RVA: 0x0007CE14 File Offset: 0x0007B014
		Private Sub <<EMPTY_NAME>>()
			Me.oo_.oOOoO.(0, "")
		End Sub

		' Token: 0x06001348 RID: 4936 RVA: 0x0007CE22 File Offset: 0x0007B022
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oo_.oOOoO.(1, CType(A_0, ToolStripItem).Text)
		End Sub

		' Token: 0x06001349 RID: 4937 RVA: 0x0007CE38 File Offset: 0x0007B038
		Private Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As String)
			Dim text As String = ""
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim oo0O As Oo0O
			If Me.ooO.0o00__0.().SelectedIndex = 0 Then
				oo0O = Me.O_0oOOO_.OO.()
			Else
				oo0O = Me.Oo.Oo00__oooo.()
			End If
			If Me.o.0_0_Ooo. IsNot Nothing AndAlso Me.o.0_0_Ooo. IsNot Nothing Then
				If TypeOf Me.o.0_0_Ooo..Tag Is o0o0_oo00Oo Then
					text = CType(Me.o.0_0_Ooo..Tag, o0o0_oo00Oo).oOO_00_0.o.()
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is ooo0 Then
					text = CType(Me.o.0_0_Ooo..Tag, ooo0).oo.o0.()
				ElseIf TypeOf Me.o.0_0_Ooo..Tag Is O_0OOOoO Then
					text = CType(Me.o.0_0_Ooo..Tag, O_0OOOoO).oo_.__OoOO0OO0.()
				Else
					text = CType(Me.o.0_0_Ooo..Tag, IMBuddy).Name
				End If
			End If
			Dim dateTime As DateTime
			Dim num As Integer
			If oo0O.Row >= 0 AndAlso oo0O.O__OO.o..ContainsKey(oo0O.Row) Then
				Dim dataRow As DataRow = oo0O.O__OO.o.(oo0O.Row)
				If Conversions.ToInteger(dataRow("Type")) = 1 Then
					text3 = dataRow("Name").ToString()
				Else
					text3 = Me.o.0_0_Ooo..Name
				End If
				dateTime = Conversions.ToDate(dataRow("Time"))
				text2 = dataRow("Content").ToString()
				If Operators.CompareString(text2, "", True) > 0 AndAlso text2.StartsWith(ChrW(2) & "=[") AndAlso text2.EndsWith("]=") Then
					text2 = text2.Substring(3, text2.Length - 5)
					num = 1
				ElseIf Operators.CompareString(text2, "", True) > 0 AndAlso text2.StartsWith(ChrW(2) & "=(") AndAlso text2.EndsWith(")=") Then
					text2 = text2.Substring(3, text2.Length - 5)
					num = 2
				ElseIf text2.StartsWith(ChrW(2) & "<") AndAlso text2.EndsWith(">" & ChrW(2)) Then
					num = 3
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf text2.StartsWith(ChrW(2) & "|") AndAlso text2.EndsWith("|" & ChrW(2)) Then
					num = 4
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf Operators.CompareString(text2, "", True) > 0 AndAlso text2.StartsWith(ChrW(2) & "=?") AndAlso text2.EndsWith("?=") Then
					num = 5
					text2 = text2.Substring(3, text2.Length - 5)
				ElseIf Operators.CompareString(text2, "", True) > 0 AndAlso text2.StartsWith(ChrW(2) & "<?") AndAlso text2.EndsWith("?>") Then
					num = 6
					text2 = text2.Substring(3, text2.Length - 5)
				ElseIf text2.StartsWith(ChrW(2) & "(") AndAlso text2.EndsWith(")" & ChrW(2)) Then
					num = 7
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf text2.StartsWith(ChrW(2) & "{") AndAlso text2.EndsWith("}" & ChrW(2)) Then
					num = 8
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf text2.StartsWith(ChrW(2) & "[") AndAlso text2.EndsWith("]" & ChrW(2)) Then
					num = 9
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf text2.StartsWith(ChrW(2) & "/") AndAlso text2.EndsWith("\" & ChrW(2)) Then
					num = 10
					text2 = text2.Substring(2, text2.Length - 4)
				ElseIf text2.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) OrElse text2.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) OrElse (text2.StartsWith("www", StringComparison.CurrentCultureIgnoreCase) AndAlso text2.Length - text2.Replace(".", "").Length >= 2) Then
					num = 11
				End If
			End If
			If A_0 = 1 Then
				Dim customMenuClickEventArgs As CustomMenuClickEventArgs = New CustomMenuClickEventArgs(A_1, text, text2, num, text3, dateTime)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "CustomMenuClick", New Object() { customMenuClickEventArgs }, True, "项目", False)
			End If
			If A_0 = 0 Then
				Dim openQQMenuEventArgs As OpenQQMenuEventArgs = New OpenQQMenuEventArgs(text, text2, num, text3, dateTime)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowMenu", New Object() { openQQMenuEventArgs }, True, "项目", False)
			End If
		End Sub

		' Token: 0x0600134A RID: 4938 RVA: 0x0007D287 File Offset: 0x0007B487
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0_o0_00.().Show(Me.oO____oooO.0_O.(), 0, Me.oO____oooO.0_O.().Height)
		End Sub

		' Token: 0x0600134B RID: 4939 RVA: 0x0007D2A6 File Offset: 0x0007B4A6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_.O0ooO.().Checked = Not Me.O_.O0ooO.().Checked
			If Me.O_.O0ooO.().Checked Then
				Me.o.0_o0_00.().Checked = False
			End If
		End Sub

		' Token: 0x0600134C RID: 4940 RVA: 0x0007D2DA File Offset: 0x0007B4DA
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_O.O000o__.().PerformClick()
		End Sub

		' Token: 0x0600134D RID: 4941 RVA: 0x0007D2E7 File Offset: 0x0007B4E7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.0_o0_00.().Checked = Not Me.o.0_o0_00.().Checked
			If Me.o.0_o0_00.().Checked Then
				Me.O_.O0ooO.().Checked = False
			End If
		End Sub

		' Token: 0x0600134E RID: 4942 RVA: 0x0007D31B File Offset: 0x0007B51B
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_o._o0___.().ForeColor = Color.CornflowerBlue
			Me.Oo.Oo00__oooo.().ForeColor = Color.CornflowerBlue
			Me.o.o__0o.().ForeColor = Color.CornflowerBlue
		End Sub

		' Token: 0x0400075B RID: 1883
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400075C RID: 1884
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x0400075D RID: 1885
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Oo0O

		' Token: 0x0400075E RID: 1886
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x0400075F RID: 1887
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO___OO0O_0

		' Token: 0x04000760 RID: 1888
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000761 RID: 1889
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04000762 RID: 1890
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Oo0O

		' Token: 0x04000763 RID: 1891
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000764 RID: 1892
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000765 RID: 1893
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000766 RID: 1894
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000767 RID: 1895
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000768 RID: 1896
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000769 RID: 1897
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400076A RID: 1898
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO___OO0O_0

		' Token: 0x0400076B RID: 1899
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400076C RID: 1900
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o0ooo_0_00oO

		' Token: 0x0400076D RID: 1901
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x0400076E RID: 1902
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400076F RID: 1903
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000770 RID: 1904
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000771 RID: 1905
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000772 RID: 1906
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000773 RID: 1907
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolTip

		' Token: 0x04000774 RID: 1908
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000775 RID: 1909
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000776 RID: 1910
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000777 RID: 1911
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000778 RID: 1912
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000779 RID: 1913
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400077A RID: 1914
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400077B RID: 1915
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x0400077C RID: 1916
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400077D RID: 1917
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400077E RID: 1918
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x0400077F RID: 1919
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o0ooo_0_00oO

		' Token: 0x04000780 RID: 1920
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000781 RID: 1921
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x04000782 RID: 1922
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000783 RID: 1923
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x04000784 RID: 1924
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000785 RID: 1925
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000786 RID: 1926
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x04000787 RID: 1927
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000788 RID: 1928
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000789 RID: 1929
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400078A RID: 1930
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x0400078B RID: 1931
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x0400078C RID: 1932
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400078D RID: 1933
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripSeparator

		' Token: 0x0400078E RID: 1934
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400078F RID: 1935
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000790 RID: 1936
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000791 RID: 1937
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000792 RID: 1938
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000793 RID: 1939
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000794 RID: 1940
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000795 RID: 1941
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000796 RID: 1942
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000797 RID: 1943
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000798 RID: 1944
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x04000799 RID: 1945
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400079A RID: 1946
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x0400079B RID: 1947
		Private <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x0400079C RID: 1948
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400079D RID: 1949
		Friend <<EMPTY_NAME>> As C1TopicLink

		' Token: 0x0400079E RID: 1950
		Friend <<EMPTY_NAME>> As O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000

		' Token: 0x0400079F RID: 1951
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x02000193 RID: 403
		' (Invoke) Token: 0x06001352 RID: 4946
		Private Delegate Sub Oo000(A_0 As IMBuddy, A_1 As String, A_2 As ooOoO)

		' Token: 0x02000194 RID: 404
		' (Invoke) Token: 0x06001356 RID: 4950
		Public Delegate Sub OO00OoOo_(A_0 As DataRow)
	End Class
End Namespace
