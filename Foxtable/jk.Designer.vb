Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Themes
Imports Foxtable.My
Imports Foxtable.RibbonMenu
Imports Foxtable.Syscmd
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace Foxtable
	' Token: 0x02000358 RID: 856
	<DesignerGenerated()>
	Friend Class jk
		Inherits C1RibbonForm

		' Token: 0x060034BE RID: 13502 RVA: 0x0015F510 File Offset: 0x0015D710
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not A_0 OrElse Me.oOO0.OOoo0oO. Is Nothing Then
					GoTo IL_21
				End If
				IL_14:
				num2 = 3
				Me.oOO0.OOoo0oO..Dispose()
				IL_21:
				num2 = 4
				MyBase.Dispose(A_0)
				IL_2A:
				GoTo IL_8D
				IL_2C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_4E:
				GoTo IL_82
				IL_50:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_60:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_50
			End Try
			IL_82:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060034BF RID: 13503 RVA: 0x0015F5C4 File Offset: 0x0015D7C4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oOO0.OOoo0oO. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(jk))
			Dim c1TopicPage As C1TopicPage = New C1TopicPage()
			Dim c1TopicLink As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink2 As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink3 As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink4 As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink5 As C1TopicLink = New C1TopicLink()
			Dim c1TopicPage2 As C1TopicPage = New C1TopicPage()
			Dim c1TopicLink6 As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink7 As C1TopicLink = New C1TopicLink()
			Dim c1TopicPage3 As C1TopicPage = New C1TopicPage()
			Dim c1TopicLink8 As C1TopicLink = New C1TopicLink()
			Dim c1TopicLink9 As C1TopicLink = New C1TopicLink()
			Me.OOoo___.0.(New ImageList(Me.oOO0.OOoo0oO.))
			Me.Oo__.ooOo00_Oo.(New C1Ribbon())
			Me.O0.0000oO.(New RibbonApplicationMenu())
			Me.O_o.00.(New RibbonBottomToolBar())
			Me.O_o.00.(New RibbonConfigToolBar())
			Me.O_o.00.(New RibbonQat())
			Me.O_o.00.(New RibbonTab())
			Me.O_o.00.(New RibbonGroup())
			Me.O_o.00.(New RibbonTopToolBar())
			Me.Oo__.ooOo00_Oo.(New C1StatusBar())
			Me.Oo_.o__.(New RibbonLabel())
			Me.O0.0000oO.(New RibbonProgressBar())
			Me.o_o0Oo.00.(New RibbonLabel())
			Me.O0.0000oO.(New RibbonLabel())
			Me.O_o.00.(New C1CommandDock())
			Me.O_o.00.(New oo00o_())
			Me.Oo__.ooOo00_Oo.(New C1DockingTabPage())
			Me.O0.0000oO.(New o0ooo_0_00oO())
			Me.Oo__.ooOo00_Oo.(New C1CommandHolder())
			Me.OOoo___.0.(New ToolTip(Me.oOO0.OOoo0oO.))
			Me.O_o.00.(New System.Windows.Forms.Timer(Me.oOO0.OOoo0oO.))
			Me.o.O000oo.(New System.Windows.Forms.Timer(Me.oOO0.OOoo0oO.))
			Me.O0.0000oO.(New OO___OO0O_0())
			Me.O0.0000oO.(New C1ThemeController())
			Me.O.OOO0_OOo.().BeginInit()
			Me.O.OOO0_OOo.().BeginInit()
			Me.O0o__0_OO.o.().BeginInit()
			Me.O0o__0_OO.o.().SuspendLayout()
			CType(Me.O0o__0_OO.o.(), ISupportInitialize).BeginInit()
			Me.O0o__0_OO.o.().SuspendLayout()
			Me.O.OOO0_OOo.().SuspendLayout()
			CType(Me.O.OOO0_OOo.(), ISupportInitialize).BeginInit()
			Me.O.OOO0_OOo.().BeginInit()
			CType(Me.OO_O_0Oo.___o.(), ISupportInitialize).BeginInit()
			Me.O.OOO0_OOo.().BeginInit()
			MyBase.SuspendLayout()
			Me.o0_o_o_0.0O.().ImageStream = CType(componentResourceManager.GetObject("TopicImageList.ImageStream"), ImageListStreamer)
			Me.o0_o_o_0.0O.().TransparentColor = Color.Transparent
			Me.o0_o_o_0.0O.().Images.SetKeyName(0, "")
			Me.o0_o_o_0.0O.().Images.SetKeyName(1, "")
			Me.o0_o_o_0.0O.().Images.SetKeyName(2, "")
			Me.o0_o_o_0.0O.().Images.SetKeyName(3, "")
			Me.o0_o_o_0.0O.().Images.SetKeyName(4, "")
			Me.o0_o_o_0.0O.().Images.SetKeyName(5, "Manul.ico")
			Me.o0_o_o_0.0O.().Images.SetKeyName(6, "EmailSupport.ico")
			Me.o0_o_o_0.0O.().Images.SetKeyName(7, "Telephone.ico")
			Me.o0_o_o_0.0O.().Images.SetKeyName(8, "Accept32.ico")
			Me.o0_o_o_0.0O.().Images.SetKeyName(9, "Demo.ico")
			Me.O.OOO0_OOo.().ApplicationMenuHolder = Me.OO_O_0Oo.___o.()
			Me.O.OOO0_OOo.().AutoSizeElement = 1
			Me.O.OOO0_OOo.().BottomToolBarHolder = Me.OO_O_0Oo.___o.()
			Me.O.OOO0_OOo.().ConfigToolBarHolder = Me.OO_O_0Oo.___o.()
			Me.O.OOO0_OOo.().Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.O.OOO0_OOo.().Location = New Point(0, 0)
			Me.O.OOO0_OOo.().Margin = New Padding(3, 2, 3, 2)
			Me.O.OOO0_OOo.().Name = "C1Ribbon1"
			Me.O.OOO0_OOo.().QatHolder = Me.O0o__0_OO.o.()
			Me.O.OOO0_OOo.().Size = New Size(932, 154)
			Me.O.OOO0_OOo.().Tabs.Add(Me.O0o__0_OO.o.())
			Me.O.OOO0_OOo.().TopToolBarHolder = Me.O0o__0_OO.o.()
			Me.OO_O_0Oo.___o.().Name = "RibbonApplicationMenu1"
			Me.OO_O_0Oo.___o.().Name = "RibbonBottomToolBar1"
			Me.OO_O_0Oo.___o.().Name = "RibbonConfigToolBar1"
			Me.O0o__0_OO.o.().MenuVisible = False
			Me.O0o__0_OO.o.().Name = "RibbonQat1"
			Me.O0o__0_OO.o.().Groups.Add(Me.OO_O_0Oo.___o.())
			Me.O0o__0_OO.o.().Name = "RibbonTab1"
			Me.O0o__0_OO.o.().Text = "Tab"
			Me.OO_O_0Oo.___o.().Name = "RibbonGroup1"
			Me.OO_O_0Oo.___o.().Text = "Group"
			Me.O0o__0_OO.o.().Name = "RibbonTopToolBar1"
			Me.O.OOO0_OOo.().AutoSizeElement = 1
			Me.O.OOO0_OOo.().LeftPaneItems.Add(Me.OO_O_0Oo.___o.())
			Me.O.OOO0_OOo.().LeftPaneItems.Add(Me.OO_O_0Oo.___o.())
			Me.O.OOO0_OOo.().LeftPaneItems.Add(Me.o__0_._oOooO_o.())
			Me.O.OOO0_OOo.().Location = New Point(0, 613)
			Me.O.OOO0_OOo.().Margin = New Padding(3, 2, 3, 2)
			Me.O.OOO0_OOo.().Name = "C1StatusBar1"
			Me.O.OOO0_OOo.().RightPaneItems.Add(Me.oO0_oO.0o.())
			Me.O.OOO0_OOo.().RightPaneWidth = 450
			Me.O.OOO0_OOo.().RightToLeft = RightToLeft.Yes
			Me.O.OOO0_OOo.().Size = New Size(932, 23)
			Me.OO_O_0Oo.___o.().Name = "Message1"
			Me.OO_O_0Oo.___o.().Text = "就绪"
			Me.OO_O_0Oo.___o.().Name = "ProgressBar"
			Me.OO_O_0Oo.___o.().Visible = False
			Me.o__0_._oOooO_o.().Name = "Message2"
			Me.oO0_oO.0o.().Name = "Message3"
			Me.O0o__0_OO.o.().AllowFloat = False
			Me.O0o__0_OO.o.().AutoDockBottom = False
			Me.O0o__0_OO.o.().AutoDockLeft = False
			Me.O0o__0_OO.o.().AutoDockRight = False
			Me.O0o__0_OO.o.().AutoDockTop = False
			Me.O0o__0_OO.o.().BackColor = Color.FromArgb(207, 221, 208)
			Me.O0o__0_OO.o.().Controls.Add(Me.O0o__0_OO.o.())
			Me.O0o__0_OO.o.().Dock = DockStyle.Right
			Me.O0o__0_OO.o.().ForeColor = Color.Black
			Me.O0o__0_OO.o.().Id = 2
			Me.O0o__0_OO.o.().Location = New Point(620, 154)
			Me.O0o__0_OO.o.().Margin = New Padding(0)
			Me.O0o__0_OO.o.().Name = "RightDcokArea"
			Me.O0o__0_OO.o.().Size = New Size(312, 459)
			Me.O.OOO0_OOo.().SetTheme(Me.O0o__0_OO.o.(), "(default)")
			Me.O0o__0_OO.o.().Alignment = TabAlignment.Bottom
			Me.O0o__0_OO.o.().BorderStyle = BorderStyle.FixedSingle
			Me.O0o__0_OO.o.().CanAutoHide = True
			Me.O0o__0_OO.o.().CanCloseTabs = True
			Me.O0o__0_OO.o.().Controls.Add(Me.O.OOO0_OOo.())
			Me.O0o__0_OO.o.().HotTrack = True
			Me.O0o__0_OO.o.().Location = New Point(0, 0)
			Me.O0o__0_OO.o.().Margin = New Padding(0)
			Me.O0o__0_OO.o.().Name = "RightDockTab"
			Me.O0o__0_OO.o.().ShowCaption = True
			Me.O0o__0_OO.o.().ShowSingleTab = False
			Me.O0o__0_OO.o.().Size = New Size(312, 459)
			Me.O0o__0_OO.o.().SplitterWidth = 1
			Me.O0o__0_OO.o.().TabIndex = 0
			Me.O0o__0_OO.o.().TabsCanFocus = False
			Me.O0o__0_OO.o.().TabSizeMode = 2
			Me.O0o__0_OO.o.().TabsSpacing = 2
			Me.O.OOO0_OOo.().SetTheme(Me.O0o__0_OO.o.(), "(default)")
			Me.O0o__0_OO.o.().VisualStyle = 2
			Me.O0o__0_OO.o.().VisualStyleBase = 2
			Me.O.OOO0_OOo.().CaptionVisible = True
			Me.O.OOO0_OOo.().Controls.Add(Me.O.OOO0_OOo.())
			Me.O.OOO0_OOo.().Location = New Point(2, 1)
			Me.O.OOO0_OOo.().Name = "C1DockingTabPage1"
			Me.O.OOO0_OOo.().Size = New Size(309, 457)
			Me.O.OOO0_OOo.().TabIndex = 0
			Me.O.OOO0_OOo.().Text = "开始工作"
			Me.O.OOO0_OOo.().AutoScrollMinSize = New Size(0, 334)
			Me.O.OOO0_OOo.().Dock = DockStyle.Fill
			Me.O.OOO0_OOo.().ImageList = Me.o0_o_o_0.0O.()
			Me.O.OOO0_OOo.().Location = New Point(0, 23)
			Me.O.OOO0_OOo.().Name = "C1TopicBar1"
			Me.O.OOO0_OOo.().Padding = New Padding(13, 11, 13, 11)
			Me.O.OOO0_OOo.().PagePadding = New Padding(10)
			c1TopicPage.ImageList = Me.o0_o_o_0.0O.()
			c1TopicLink.ImageIndex = 5
			c1TopicLink.Tag = "Help"
			c1TopicLink.Text = "使用指南"
			c1TopicLink2.ImageIndex = 3
			c1TopicLink2.Tag = "Home"
			c1TopicLink2.Text = "访问主页"
			c1TopicLink3.ImageIndex = 4
			c1TopicLink3.Tag = "BBS"
			c1TopicLink3.Text = "用户交流"
			c1TopicLink4.ImageIndex = 6
			c1TopicLink4.Tag = "Feedback"
			c1TopicLink4.Text = "意见反馈"
			c1TopicLink5.ImageIndex = 7
			c1TopicLink5.Tag = "Order"
			c1TopicLink5.Text = "联系我们"
			c1TopicPage.Links.Add(c1TopicLink)
			c1TopicPage.Links.Add(c1TopicLink2)
			c1TopicPage.Links.Add(c1TopicLink3)
			c1TopicPage.Links.Add(c1TopicLink4)
			c1TopicPage.Links.Add(c1TopicLink5)
			c1TopicPage.Text = "支持"
			c1TopicPage2.ImageList = Me.o0_o_o_0.0O.()
			c1TopicLink6.ImageIndex = 0
			c1TopicLink6.Tag = "Demo"
			c1TopicLink6.Text = "基本功能演示"
			c1TopicLink7.ImageIndex = 9
			c1TopicLink7.Tag = "presentation"
			c1TopicLink7.Text = "基本功能介绍"
			c1TopicPage2.Links.Add(c1TopicLink6)
			c1TopicPage2.Links.Add(c1TopicLink7)
			c1TopicPage2.Text = "演示"
			c1TopicPage3.ImageList = Me.o0_o_o_0.0O.()
			c1TopicLink8.ImageIndex = 1
			c1TopicLink8.Tag = "New"
			c1TopicLink8.Text = "新建..."
			c1TopicLink9.ImageIndex = 2
			c1TopicLink9.Tag = "Open"
			c1TopicLink9.Text = "更多..."
			c1TopicPage3.Links.Add(c1TopicLink8)
			c1TopicPage3.Links.Add(c1TopicLink9)
			c1TopicPage3.Text = "项目"
			Me.O.OOO0_OOo.().Pages.Add(c1TopicPage)
			Me.O.OOO0_OOo.().Pages.Add(c1TopicPage2)
			Me.O.OOO0_OOo.().Pages.Add(c1TopicPage3)
			Me.O.OOO0_OOo.().Size = New Size(309, 434)
			Me.O.OOO0_OOo.().TabIndex = 0
			Me.O.OOO0_OOo.().SetTheme(Me.O.OOO0_OOo.(), "(default)")
			Me.O.OOO0_OOo.().VisualStyle = 2
			Me.O.OOO0_OOo.().VisualStyleBase = 2
			Me.O.OOO0_OOo.().Owner = Me
			Me.O0o__0_OO.o.().Enabled = True
			Me.O0o__0_OO.o.().Interval = 60000
			Me.o00o_OO_o_._o.().Enabled = True
			Me.o00o_OO_o_._o.().Interval = 200
			Me.OO_O_0Oo.___o.().BackColor = Color.FromArgb(240, 240, 240)
			Me.OO_O_0Oo.___o.().BorderStyle = BorderStyle.FixedSingle
			Me.OO_O_0Oo.___o.().CanMoveTabs = True
			Me.OO_O_0Oo.___o.().Dock = DockStyle.Fill
			Me.OO_O_0Oo.___o.().Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.OO_O_0Oo.___o.().HotTrack = True
			Me.OO_O_0Oo.___o.().Location = New Point(0, 154)
			Me.OO_O_0Oo.___o.().Margin = New Padding(3, 2, 3, 2)
			Me.OO_O_0Oo.___o.().Name = "MainPages"
			Me.OO_O_0Oo.___o.().SelectedTabBold = True
			Me.OO_O_0Oo.___o.().ShowTabList = True
			Me.OO_O_0Oo.___o.().ShowToolTips = True
			Me.OO_O_0Oo.___o.().Size = New Size(620, 459)
			Me.OO_O_0Oo.___o.().TabIndex = 0
			Me.OO_O_0Oo.___o.().TabsCanFocus = False
			Me.OO_O_0Oo.___o.().TabSizeMode = 2
			Me.OO_O_0Oo.___o.().TabsShowFocusCues = False
			Me.OO_O_0Oo.___o.().TabsSpacing = 2
			Me.OO_O_0Oo.___o.().TabStyle = 6
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height)
			MyBase.Controls.Add(Me.OO_O_0Oo.___o.())
			MyBase.Controls.Add(Me.O0o__0_OO.o.())
			MyBase.Controls.Add(Me.O.OOO0_OOo.())
			MyBase.Controls.Add(Me.O.OOO0_OOo.())
			Me.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
			MyBase.KeyPreview = True
			MyBase.Margin = New Padding(3, 2, 3, 2)
			MyBase.Name = "frmMain"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "frmMain"
			MyBase.VisualStyleHolder = 5
			MyBase.WindowState = FormWindowState.Maximized
			Me.O.OOO0_OOo.().EndInit()
			Me.O.OOO0_OOo.().EndInit()
			Me.O0o__0_OO.o.().EndInit()
			Me.O0o__0_OO.o.().ResumeLayout(False)
			CType(Me.O0o__0_OO.o.(), ISupportInitialize).EndInit()
			Me.O0o__0_OO.o.().ResumeLayout(False)
			Me.O.OOO0_OOo.().ResumeLayout(False)
			CType(Me.O.OOO0_OOo.(), ISupportInitialize).EndInit()
			Me.O.OOO0_OOo.().EndInit()
			CType(Me.OO_O_0Oo.___o.(), ISupportInitialize).EndInit()
			Me.O.OOO0_OOo.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060034C0 RID: 13504 RVA: 0x00160438 File Offset: 0x0015E638
		Private Sub <<EMPTY_NAME>>(A_0 As C1ThemeController, A_1 As ObjectThemeEventArgs)
			If TypeOf A_1.[Object] Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(A_1.[Object], C1FlexGrid)
				If Operators.CompareString(A_1.ThemeName, "", True) > 0 AndAlso A_1.ThemeName.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase) Then
					c1FlexGrid.Styles.Highlight.BackColor = Color.FromArgb(0, 120, 215)
					c1FlexGrid.Styles.Highlight.ForeColor = Color.White
				ElseIf Operators.CompareString(A_1.ThemeName, "", True) > 0 AndAlso A_1.ThemeName.StartsWith("Office2013", StringComparison.OrdinalIgnoreCase) Then
					c1FlexGrid.Styles.Focus.Clear(2)
					c1FlexGrid.Styles.Focus.Clear(4)
				ElseIf Operators.CompareString(A_1.ThemeName, "", True) > 0 AndAlso A_1.ThemeName.StartsWith("Office2016", StringComparison.OrdinalIgnoreCase) Then
					c1FlexGrid.Styles.Alternate.Clear(1)
				End If
				If Not(TypeOf A_1.[Object] Is O_oOooO_O) Then
					c1FlexGrid.Styles.Alternate.Clear()
				End If
			End If
			If TypeOf A_1.[Object] Is C1DockingTab AndAlso Operators.CompareString(A_1.ThemeName, "System", True) = 0 Then
				CType(A_1.[Object], C1DockingTab).BorderStyle = BorderStyle.Fixed3D
			End If
		End Sub

		' Token: 0x060034C1 RID: 13505 RVA: 0x00160592 File Offset: 0x0015E792
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As C1ThemeController, A_1 As ObjectThemeEventArgs)
			If TypeOf A_1.[Object] Is C1Button AndAlso Operators.CompareString(A_1.ThemeName, "Foxtable经典蓝", True) = 0 Then
				CType(A_1.[Object], C1Button).VisualStyle = 1
			End If
		End Sub

		' Token: 0x060034C2 RID: 13506 RVA: 0x001605C5 File Offset: 0x0015E7C5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Ribbon
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034C3 RID: 13507 RVA: 0x001605D0 File Offset: 0x0015E7D0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Ribbon)
			Dim ribbonEventHandler As RibbonEventHandler = AddressOf Me.Oo._oO0Oo_0.
			Dim c1Ribbon As C1Ribbon = Me.o_o0o0OO.O.
			If c1Ribbon IsNot Nothing Then
				c1Ribbon.RibbonEvent -= ribbonEventHandler
			End If
			Me.o_o0o0OO.O. = A_0
			c1Ribbon = Me.o_o0o0OO.O.
			If c1Ribbon IsNot Nothing Then
				c1Ribbon.RibbonEvent += ribbonEventHandler
			End If
		End Sub

		' Token: 0x060034C4 RID: 13508 RVA: 0x00160613 File Offset: 0x0015E813
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonApplicationMenu
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034C5 RID: 13509 RVA: 0x0016061B File Offset: 0x0015E81B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonApplicationMenu)
			Me.OOo0o_oOOo_0._. = A_0
		End Sub

		' Token: 0x060034C6 RID: 13510 RVA: 0x00160624 File Offset: 0x0015E824
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonConfigToolBar
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034C7 RID: 13511 RVA: 0x0016062C File Offset: 0x0015E82C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonConfigToolBar)
			Me.OOo0o_oOOo_0._. = A_0
		End Sub

		' Token: 0x060034C8 RID: 13512 RVA: 0x00160635 File Offset: 0x0015E835
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonGroup
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034C9 RID: 13513 RVA: 0x0016063D File Offset: 0x0015E83D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonGroup)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034CA RID: 13514 RVA: 0x00160646 File Offset: 0x0015E846
		<CompilerGenerated()>
		Public Overridable Function <<EMPTY_NAME>>() As C1StatusBar
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034CB RID: 13515 RVA: 0x0016064E File Offset: 0x0015E84E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Overridable Sub <<EMPTY_NAME>>(A_0 As C1StatusBar)
			Me.o_o0o0OO.O. = A_0
		End Sub

		' Token: 0x060034CC RID: 13516 RVA: 0x00160657 File Offset: 0x0015E857
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As OO___OO0O_0
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034CD RID: 13517 RVA: 0x00160660 File Offset: 0x0015E860
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OO___OO0O_0)
			Dim value As ControlEventHandler = AddressOf Me.o0_o_o_0.0O.
			Dim eventHandler As EventHandler = AddressOf Me.o.OoO.
			Dim selectedIndexChangingEventHandler As SelectedIndexChangingEventHandler = AddressOf Me.Oo__.ooOo00_Oo.
			Dim tabPageCancelEventHandler As TabPageCancelEventHandler = AddressOf Me.Oo__.ooOo00_Oo.
			Dim ooo0o_oOOo_0._. As OO___OO0O_0 = Me.OOo0o_oOOo_0._.
			If ooo0o_oOOo_0._. IsNot Nothing Then
				RemoveHandler ooo0o_oOOo_0._..ControlRemoved, value
				ooo0o_oOOo_0._..SelectedIndexChanged -= eventHandler
				ooo0o_oOOo_0._..SelectedIndexChanging -= selectedIndexChangingEventHandler
				ooo0o_oOOo_0._..TabPageClosing -= tabPageCancelEventHandler
			End If
			Me.OOo0o_oOOo_0._. = A_0
			ooo0o_oOOo_0._. = Me.OOo0o_oOOo_0._.
			If ooo0o_oOOo_0._. IsNot Nothing Then
				AddHandler ooo0o_oOOo_0._..ControlRemoved, value
				ooo0o_oOOo_0._..SelectedIndexChanged += eventHandler
				ooo0o_oOOo_0._..SelectedIndexChanging += selectedIndexChangingEventHandler
				ooo0o_oOOo_0._..TabPageClosing += tabPageCancelEventHandler
			End If
		End Sub

		' Token: 0x060034CE RID: 13518 RVA: 0x00160700 File Offset: 0x0015E900
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CommandDock
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034CF RID: 13519 RVA: 0x00160708 File Offset: 0x0015E908
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CommandDock)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034D0 RID: 13520 RVA: 0x00160711 File Offset: 0x0015E911
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As oo00o_
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034D1 RID: 13521 RVA: 0x0016071C File Offset: 0x0015E91C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oo00o_)
			Dim tabPageEventHandler As TabPageEventHandler = AddressOf Me.Oo._oO0Oo_0.
			Dim tabPageCancelEventHandler As TabPageCancelEventHandler = AddressOf Me.O.O00OOOo0_.
			Dim oo00o_ As oo00o_ = Me.oOO.O_oo.
			If oo00o_ IsNot Nothing Then
				oo00o_.TabPageClosed -= tabPageEventHandler
				oo00o_.TabPageClosing -= tabPageCancelEventHandler
			End If
			Me.oOO.O_oo. = A_0
			oo00o_ = Me.oOO.O_oo.
			If oo00o_ IsNot Nothing Then
				oo00o_.TabPageClosed += tabPageEventHandler
				oo00o_.TabPageClosing += tabPageCancelEventHandler
			End If
		End Sub

		' Token: 0x060034D2 RID: 13522 RVA: 0x0016077A File Offset: 0x0015E97A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034D3 RID: 13523 RVA: 0x00160782 File Offset: 0x0015E982
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o_o0o0OO.O. = A_0
		End Sub

		' Token: 0x060034D4 RID: 13524 RVA: 0x0016078B File Offset: 0x0015E98B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As o0ooo_0_00oO
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034D5 RID: 13525 RVA: 0x00160794 File Offset: 0x0015E994
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As o0ooo_0_00oO)
			Dim c1TopicBarClickEventHandler As C1TopicBarClickEventHandler = AddressOf Me.o0oO_O.0Oo_00.
			Dim o0ooo_0_00oO As o0ooo_0_00oO = Me.o_o0o0OO.O.
			If o0ooo_0_00oO IsNot Nothing Then
				o0ooo_0_00oO.LinkClick -= c1TopicBarClickEventHandler
			End If
			Me.o_o0o0OO.O. = A_0
			o0ooo_0_00oO = Me.o_o0o0OO.O.
			If o0ooo_0_00oO IsNot Nothing Then
				o0ooo_0_00oO.LinkClick += c1TopicBarClickEventHandler
			End If
		End Sub

		' Token: 0x060034D6 RID: 13526 RVA: 0x001607D7 File Offset: 0x0015E9D7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CommandHolder
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034D7 RID: 13527 RVA: 0x001607DF File Offset: 0x0015E9DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CommandHolder)
			Me.o_o0o0OO.O. = A_0
		End Sub

		' Token: 0x060034D8 RID: 13528 RVA: 0x001607E8 File Offset: 0x0015E9E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolTip
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034D9 RID: 13529 RVA: 0x001607F0 File Offset: 0x0015E9F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolTip)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034DA RID: 13530 RVA: 0x001607F9 File Offset: 0x0015E9F9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Timer
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034DB RID: 13531 RVA: 0x00160804 File Offset: 0x0015EA04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Timer)
			Dim value As EventHandler = AddressOf Me.O_.oOO_O0_0.
			Dim timer As System.Windows.Forms.Timer = Me.oOO.O_oo.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.oOO.O_oo. = A_0
			timer = Me.oOO.O_oo.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x060034DC RID: 13532 RVA: 0x00160847 File Offset: 0x0015EA47
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonBottomToolBar
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034DD RID: 13533 RVA: 0x0016084F File Offset: 0x0015EA4F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonBottomToolBar)
			Me.OOo0o_oOOo_0._. = A_0
		End Sub

		' Token: 0x060034DE RID: 13534 RVA: 0x00160858 File Offset: 0x0015EA58
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonTopToolBar
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034DF RID: 13535 RVA: 0x00160860 File Offset: 0x0015EA60
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonTopToolBar)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034E0 RID: 13536 RVA: 0x00160869 File Offset: 0x0015EA69
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Timer
			Return Me.ooO0_O0.O00.
		End Function

		' Token: 0x060034E1 RID: 13537 RVA: 0x00160874 File Offset: 0x0015EA74
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Timer)
			Dim value As EventHandler = AddressOf Me.Oo.oOo_o0Oo0.
			Dim timer As System.Windows.Forms.Timer = Me.ooO0_O0.O00.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.ooO0_O0.O00. = A_0
			timer = Me.ooO0_O0.O00.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x060034E2 RID: 13538 RVA: 0x001608B7 File Offset: 0x0015EAB7
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As RibbonQat
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034E3 RID: 13539 RVA: 0x001608BF File Offset: 0x0015EABF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonQat)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034E4 RID: 13540 RVA: 0x001608C8 File Offset: 0x0015EAC8
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As RibbonTab
			Return Me.oOO.O_oo.
		End Function

		' Token: 0x060034E5 RID: 13541 RVA: 0x001608D0 File Offset: 0x0015EAD0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonTab)
			Me.oOO.O_oo. = A_0
		End Sub

		' Token: 0x060034E6 RID: 13542 RVA: 0x001608D9 File Offset: 0x0015EAD9
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As ImageList
			Return Me.oOO0.OOoo0oO.
		End Function

		' Token: 0x060034E7 RID: 13543 RVA: 0x001608E1 File Offset: 0x0015EAE1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As ImageList)
			Me.oOO0.OOoo0oO. = A_0
		End Sub

		' Token: 0x060034E8 RID: 13544 RVA: 0x001608EA File Offset: 0x0015EAEA
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As C1ThemeController
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034E9 RID: 13545 RVA: 0x001608F4 File Offset: 0x0015EAF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As C1ThemeController)
			Dim objectThemeEventHandler As ObjectThemeEventHandler = AddressOf Me.O.O00OOOo0_.
			Dim objectThemeEventHandler2 As ObjectThemeEventHandler = AddressOf Me.o0oO_O.0Oo_00.
			Dim c1ThemeController As C1ThemeController = Me.o_o0o0OO.O.
			If c1ThemeController IsNot Nothing Then
				c1ThemeController.ObjectThemeApplied -= objectThemeEventHandler
				c1ThemeController.ObjectThemeApplying -= objectThemeEventHandler2
			End If
			Me.o_o0o0OO.O. = A_0
			c1ThemeController = Me.o_o0o0OO.O.
			If c1ThemeController IsNot Nothing Then
				c1ThemeController.ObjectThemeApplied += objectThemeEventHandler
				c1ThemeController.ObjectThemeApplying += objectThemeEventHandler2
			End If
		End Sub

		' Token: 0x060034EA RID: 13546 RVA: 0x00160952 File Offset: 0x0015EB52
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonLabel
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034EB RID: 13547 RVA: 0x0016095A File Offset: 0x0015EB5A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonLabel)
			Me.OOo0o_oOOo_0._. = A_0
		End Sub

		' Token: 0x060034EC RID: 13548 RVA: 0x00160963 File Offset: 0x0015EB63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonProgressBar
			Return Me.OOo0o_oOOo_0._.
		End Function

		' Token: 0x060034ED RID: 13549 RVA: 0x0016096B File Offset: 0x0015EB6B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonProgressBar)
			Me.OOo0o_oOOo_0._. = A_0
		End Sub

		' Token: 0x060034EE RID: 13550 RVA: 0x00160974 File Offset: 0x0015EB74
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonLabel
			Return Me.o_O_0Oo0.0O0O.
		End Function

		' Token: 0x060034EF RID: 13551 RVA: 0x0016097C File Offset: 0x0015EB7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonLabel)
			Me.o_O_0Oo0.0O0O. = A_0
		End Sub

		' Token: 0x060034F0 RID: 13552 RVA: 0x00160985 File Offset: 0x0015EB85
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RibbonLabel
			Return Me.O0o_0o0oo.O_.
		End Function

		' Token: 0x060034F1 RID: 13553 RVA: 0x0016098D File Offset: 0x0015EB8D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RibbonLabel)
			Me.O0o_0o0oo.O_. = A_0
		End Sub

		' Token: 0x060034F2 RID: 13554 RVA: 0x00160996 File Offset: 0x0015EB96
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034F3 RID: 13555 RVA: 0x001609A0 File Offset: 0x0015EBA0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Dim tabPageEventHandler As TabPageEventHandler = AddressOf Me.Oo._oO0Oo_0.
			Dim tabPageCancelEventHandler As TabPageCancelEventHandler = AddressOf Me.O.O00OOOo0_.
			Dim c1DockingTab As C1DockingTab = Me.o_o0o0OO.O.
			If c1DockingTab IsNot Nothing Then
				c1DockingTab.TabPageClosed -= tabPageEventHandler
				c1DockingTab.TabPageClosing -= tabPageCancelEventHandler
			End If
			Me.o_o0o0OO.O. = A_0
			c1DockingTab = Me.o_o0o0OO.O.
			If c1DockingTab IsNot Nothing Then
				c1DockingTab.TabPageClosed += tabPageEventHandler
				c1DockingTab.TabPageClosing += tabPageCancelEventHandler
			End If
		End Sub

		' Token: 0x060034F4 RID: 13556 RVA: 0x001609FE File Offset: 0x0015EBFE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.o_O_0Oo0.0O0O.
		End Function

		' Token: 0x060034F5 RID: 13557 RVA: 0x00160A08 File Offset: 0x0015EC08
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Dim tabPageEventHandler As TabPageEventHandler = AddressOf Me.Oo._oO0Oo_0.
			Dim tabPageCancelEventHandler As TabPageCancelEventHandler = AddressOf Me.O.O00OOOo0_.
			Dim c1DockingTab As C1DockingTab = Me.o_O_0Oo0.0O0O.
			If c1DockingTab IsNot Nothing Then
				c1DockingTab.TabPageClosed -= tabPageEventHandler
				c1DockingTab.TabPageClosing -= tabPageCancelEventHandler
			End If
			Me.o_O_0Oo0.0O0O. = A_0
			c1DockingTab = Me.o_O_0Oo0.0O0O.
			If c1DockingTab IsNot Nothing Then
				c1DockingTab.TabPageClosed += tabPageEventHandler
				c1DockingTab.TabPageClosing += tabPageCancelEventHandler
			End If
		End Sub

		' Token: 0x060034F6 RID: 13558 RVA: 0x00160A66 File Offset: 0x0015EC66
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.OO0Ooo.ooo_.
		End Function

		' Token: 0x060034F7 RID: 13559 RVA: 0x00160A70 File Offset: 0x0015EC70
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Dim tabPageEventHandler As TabPageEventHandler = AddressOf Me.Oo._oO0Oo_0.
			Dim tabPageCancelEventHandler As TabPageCancelEventHandler = AddressOf Me.O.O00OOOo0_.
			Dim oo0Ooo.ooo_. As C1DockingTab = Me.OO0Ooo.ooo_.
			If oo0Ooo.ooo_. IsNot Nothing Then
				oo0Ooo.ooo_..TabPageClosed -= tabPageEventHandler
				oo0Ooo.ooo_..TabPageClosing -= tabPageCancelEventHandler
			End If
			Me.OO0Ooo.ooo_. = A_0
			oo0Ooo.ooo_. = Me.OO0Ooo.ooo_.
			If oo0Ooo.ooo_. IsNot Nothing Then
				oo0Ooo.ooo_..TabPageClosed += tabPageEventHandler
				oo0Ooo.ooo_..TabPageClosing += tabPageCancelEventHandler
			End If
		End Sub

		' Token: 0x060034F8 RID: 13560 RVA: 0x00160ACE File Offset: 0x0015ECCE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As FileSystemWatcher
			Return Me.o_o0o0OO.O.
		End Function

		' Token: 0x060034F9 RID: 13561 RVA: 0x00160AD6 File Offset: 0x0015ECD6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As FileSystemWatcher)
			Me.o_o0o0OO.O. = A_0
		End Sub

		' Token: 0x060034FA RID: 13562 RVA: 0x00160AE0 File Offset: 0x0015ECE0
		Friend Sub <<EMPTY_NAME>>()
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Me.O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme)
				IL_12:
				num = 2
				Me.OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme)
				IL_24:
				num = 3
				If Operators.CompareString(Me.O.OOO0_OOo.().Font.Name, O_O0OO.O0_00o.o0__o..GetRibbonFontName, True) = 0 AndAlso Me.O.OOO0_OOo.().Font.Size = CSng(O_O0OO.O0_00o.o0__o..GetRibbonFontSize) Then
					GoTo IL_9C
				End If
				IL_65:
				num = 4
				Me.O.OOO0_OOo.().Font = New Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, CSng(O_O0OO.O0_00o.o0__o..GetRibbonFontSize), Me.O.OOO0_OOo.().Font.Style)
				IL_9C:
				num = 5
				Me.oOO0.OOoo0oO. = Nothing
				IL_A5:
				num = 6
				If Not MyBase.Visible Then
					GoTo IL_BD
				End If
				IL_AF:
				num = 7
				ShareLibriay.LockWindowUpdate(MyBase.Handle)
				IL_BD:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_C4:
				num = 9
				Me.OO_O_0Oo.___o.().Visible = False
				IL_D3:
				num = 10
				If Me.o._oOO0..O0oo_0_.__0__.() Is Nothing Then
					GoTo IL_127
				End If
				IL_E3:
				num = 11
				Dim enumerator As IEnumerator(Of Foxtable.Table) = Me.o._oOO0..O0oo_0_.__0__.().GetEnumerator()
				While enumerator.MoveNext()
					Dim a_ As Foxtable.Table = enumerator.Current
					IL_103:
					num = 12
					o_O_o_oOoo__.oo.O0o0o.(a_)
					IL_10D:
					num = 13
				End While
				IL_119:
				num = 14
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_127:
				num = 15
				Me.o__OO_.Ooo0_. = True
				IL_131:
				num = 16
				If Me.OO_O_0Oo.___o.().TabPages.Count <= 0 Then
					GoTo IL_480
				End If
				IL_14A:
				num = 17
				For i As Integer = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1 To 0 Step -1
					IL_16A:
					num = 18
					Dim c1DockingTabPage As C1DockingTabPage = Main.OO_O.o..OO_O_0Oo.___o.().TabPages(i)
					IL_185:
					num = 19
					Dim oo0__Oo As Oo0__Oo = CType(c1DockingTabPage, Oo0__Oo)
					IL_191:
					num = 20
					Dim table As Foxtable.Table = oo0__Oo.O_000__.o.()
					IL_19D:
					num = 21
					oo0__Oo.O_000__.o.(Nothing)
					IL_1A8:
					num = 22
					oo0__Oo.O_000__.o.(Nothing)
					IL_1B3:
					num = 23
					Dim oo___OO0O_ As OO___OO0O_0 = CType(oo0__Oo.Controls(0), OO___OO0O_0)
					IL_1CA:
					num = 24
					Dim enumerator2 As IEnumerator = oo___OO0O_.TabPages(0).Controls.GetEnumerator()
					While enumerator2.MoveNext()
						Dim obj As Object = enumerator2.Current
						Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
						IL_1F9:
						num = 25
						If TypeOf control Is o_O0_0O0 Then
							IL_208:
							num = 26
							For j As Integer = control.Controls.Count - 1 To 0 Step -1
								IL_220:
								num = 27
								Dim control2 As System.Windows.Forms.Control = control.Controls(j)
								IL_233:
								num = 28
								If TypeOf control2 Is OO___OO0O_0 Then
									IL_242:
									num = 29
									Dim oo___OO0O_2 As OO___OO0O_0 = CType(control2, OO___OO0O_0)
									IL_24E:
									num = 30
									For k As Integer = oo___OO0O_2.TabPages.Count - 1 To 0 Step -1
										IL_266:
										num = 31
										Dim c1DockingTabPage2 As C1DockingTabPage = oo___OO0O_2.TabPages(k)
										IL_279:
										num = 32
										If c1DockingTabPage2.Controls.Count > 0 AndAlso TypeOf c1DockingTabPage2.Controls(0)Is O_oOooO_O Then
											IL_2A2:
											num = 33
											Dim o_oOooO_O As O_oOooO_O = CType(c1DockingTabPage2.Controls(0), O_oOooO_O)
											IL_2B9:
											num = 34
											Dim o_ As O_0 = o_oOooO_O.o.0O_O0o_..View
											IL_2CA:
											num = 35
											o_oOooO_O.o.0O_O0o_..foxGrid = Nothing
											IL_2DA:
											num = 36
											o_oOooO_O.o.0O_O0o_. = Nothing
											IL_2E5:
											num = 37
											o_oOooO_O.SetDataBinding(Nothing, Nothing)
											IL_2F1:
											num = 38
											o_.Dispose()
											IL_2FB:
											num = 39
											o_oOooO_O.o.o0OO00oO_0.()
											IL_305:
											num = 40
											o_oOooO_O.Controls.Clear()
											IL_314:
											num = 41
											o_oOooO_O.Dispose()
										End If
										IL_31E:
										num = 42
										c1DockingTabPage2.Controls.Clear()
										IL_32D:
										num = 43
										CType(control2, OO___OO0O_0).TabPages.RemoveAt(k)
										IL_343:
										num = 44
										c1DockingTabPage2.Dispose()
										IL_34D:
										num = 45
									Next
									IL_35E:
									num = 46
									oo___OO0O_2.TabPages.Clear()
									IL_36D:
									num = 47
									oo___OO0O_2.Dispose()
									IL_377:
									oo___OO0O_2 = Nothing
								End If
								IL_37A:
								num = 49
							Next
							IL_38B:
							num = 50
							Dim o_O0_0O As o_O0_0O0 = CType(control, o_O0_0O0)
							IL_397:
							num = 51
							o_O0_0O.OoOoo_O0o0.0O_.(Nothing)
							IL_3A2:
							o_O0_0O = Nothing
						End If
						IL_3A5:
						num = 53
					End While
					IL_3B4:
					num = 54
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
					IL_3CC:
					num = 55
					oo0__Oo.Controls.Clear()
					IL_3DB:
					num = 56
					If table IsNot Nothing Then
						IL_3E2:
						num = 57
						Dim o_oOooO_O2 As O_oOooO_O = table.foxGrid
						IL_3EE:
						num = 58
						Dim o_2 As O_0 = table.View
						IL_3FA:
						num = 59
						table.foxGrid = Nothing
						IL_405:
						num = 60
						o_oOooO_O2.o.0O_O0o_. = Nothing
						IL_410:
						num = 61
						o_oOooO_O2.SetDataBinding(Nothing, Nothing)
						IL_41C:
						num = 62
						o_2.Dispose()
						IL_426:
						num = 63
						o_oOooO_O2.o.o0OO00oO_0.()
						IL_430:
						num = 64
						o_oOooO_O2.Controls.Clear()
						IL_43F:
						num = 65
						o_oOooO_O2.Dispose()
					End If
					IL_449:
					oo0__Oo = Nothing
					IL_44C:
					num = 67
					Main.OO_O.o..OO_O_0Oo.___o.().TabPages.RemoveAt(i)
					IL_465:
					num = 68
					c1DockingTabPage.Dispose()
					IL_46F:
					num = 69
				Next
				IL_480:
				num = 70
				Me.o__OO_.Ooo0_. = False
				IL_48A:
				num = 71
				Me.o._oOO0..o.o_0O00o0_.()
				IL_498:
				num = 72
				Me.OO_O_0Oo.___o.().TabPages.Clear()
				IL_4AB:
				num = 73
				OO_00oOO.O_0.oooO__O. = Nothing
				IL_4B4:
				num = 74
				OO_00oOO.oOO.0_. = Nothing
				IL_4BD:
				num = 75
				O_O0OO.O00O0o_O_._O. = True
				IL_4C6:
				num = 76
				Dim text As String = OO_00oOO.ProjectPath + "Bin\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Form.dll"
				IL_4E8:
				num = 77
				If Not OO_00oOO.FileSys.FileExists(text) Then
					GoTo IL_514
				End If
				IL_4F8:
				num = 78
				Dim rawAssembly As Byte() = File.ReadAllBytes(text)
				IL_503:
				num = 79
				O_O0OO.o0o.oO0. = Assembly.Load(rawAssembly)
				GoTo IL_51D
				IL_514:
				num = 81
				O_O0OO.o0o.oO0. = Nothing
				IL_51D:
				num = 82
				Dim enumerator3 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator3.MoveNext()
					Dim table2 As Foxtable.Table = enumerator3.Current
					IL_53A:
					num = 83
					If Not table2.IsRelation Then
						IL_549:
						num = 85
						If Not table2.Name.StartsWith("_") AndAlso Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", True) > 0 Then
							IL_572:
							num = 86
							Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace("{0}", table2.Name))
						End If
						IL_595:
						num = 87
						Application.DoEvents()
						IL_59D:
						num = 88
						Dim enumerator4 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
						While enumerator4.MoveNext()
							Dim table3 As Foxtable.Table = enumerator4.Current
							IL_5BA:
							num = 89
							If table3.IsRelation Then
								IL_5C9:
								num = 91
								If table3.Name.StartsWith(table2.Name + ".") Then
									IL_5EB:
									num = 92
									table3.foxGrid.Visible = False
									IL_5FB:
									num = 93
									MyBase.Controls.Add(table3.foxGrid)
									IL_610:
									num = 94
									table3.O.__O0o0.(True)
									IL_61C:
									num = 95
									MyBase.Controls.Remove(table3.foxGrid)
									IL_631:
									num = 96
									table3.foxGrid.Visible = True
									IL_641:
									num = 97
									table3.foxGrid.Cols.DefaultSize = 98
								End If
							End If
							IL_657:
							num = 98
						End While
						IL_666:
						num = 99
						If enumerator4 IsNot Nothing Then
							enumerator4.Dispose()
						End If
						IL_674:
						num = 100
						Dim oo0__Oo2 As Oo0__Oo = New Oo0__Oo(table2)
						IL_680:
						num = 101
						Me.OO_O_0Oo.___o.().TabPages.Add(oo0__Oo2)
						IL_696:
						num = 102
						table2.oO_o_0o._0oooo.(True)
						IL_6A1:
						num = 103
						table2.O.__O0o0.(True)
						IL_6AD:
						num = 104
						table2.foxGrid.o_.o. = table2.foxGrid.BottomRow
						IL_6C8:
						num = 105
						table2.foxGrid.Cols.DefaultSize = 98
					End If
					IL_6DE:
					num = 106
				End While
				IL_6ED:
				num = 107
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_6FB:
				num = 108
				Dim enumerator5 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator5.MoveNext()
					Dim table4 As Foxtable.Table = enumerator5.Current
					IL_718:
					num = 109
					If table4.IsRelation Then
						IL_724:
						num = 110
						If table4.foxGrid.FindForm() Is Nothing Then
							IL_738:
							num = 112
							If table4._frdAutoOpen Then
								IL_744:
								num = 113
								table4.Visible = True
							End If
							IL_74F:
							num = 114
							table4.foxGrid.o_.o. = table4.foxGrid.BottomRow
						End If
					Else
						IL_76F:
						num = 116
						If table4.TableType Is Nothing AndAlso Not table4.View.O0O.o__0.() Then
							IL_78F:
							num = 117
							Dim enumerator6 As IEnumerator(Of Col) = table4.Cols.GetEnumerator()
							While enumerator6.MoveNext()
								Dim col As Col = enumerator6.Current
								IL_7AB:
								num = 118
								If col.DataCol.ExtendType = 4 OrElse col.DataCol.ExtendType = 6 OrElse (col.DataCol.IsString AndAlso (col.DataCol.MaxLength = -1 OrElse col.DataCol.MaxLength > 2048)) Then
									IL_7FC:
									num = 119
									If col.DataCol.AutoOpen Then
										IL_80D:
										num = 120
										col.OpenWindow(0)
									End If
								End If
								IL_818:
								num = 121
							End While
							IL_827:
							num = 122
							If enumerator6 IsNot Nothing Then
								enumerator6.Dispose()
							End If
						End If
					End If
					IL_835:
					num = 123
				End While
				IL_844:
				num = 124
				If enumerator5 IsNot Nothing Then
					enumerator5.Dispose()
				End If
				IL_852:
				num = 125
				O_O0OO.O0_00o.o0__o..O_.Oo_o_.()
				IL_85F:
				num = 126
				Me.oO_0_.oO. = Me.o0_o_o_0.0O.(False)
				IL_86F:
				num = 127
				If Me.oO_0_.oO. = 2 Then
					GoTo IL_887
				End If
				IL_87B:
				num = 128
				Me.OOoO0O_o_o.0_0.()
				IL_887:
				num = 129
				Dim enumerator7 As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator7.MoveNext()
					Dim dataTable As DataTable = enumerator7.Current
					IL_8A4:
					num = 130
					dataTable.o._o_O_.()
					IL_8B1:
					num = 131
				End While
				IL_8C0:
				num = 132
				If enumerator7 IsNot Nothing Then
					enumerator7.Dispose()
				End If
				IL_8D1:
				num = 133
				If Me.OO_O_0Oo.___o.().TabPages.Count <> 0 Then
					GoTo IL_9A9
				End If
				IL_8EC:
				num = 134
				Dim text2 As String = "一二三四五六七八九十"
				IL_8F9:
				num = 135
				Dim dataTableBuilder As DataTableBuilder = New DataTableBuilder("表1")
				IL_90B:
				num = 136
				Dim num3 As Integer = 1
				Do
					IL_914:
					num = 137
					dataTableBuilder.AddDef("第" + Conversions.ToString(text2(num3 - 1)) + "列", GetType(String), 32)
					IL_94C:
					num = 138
					num3 += 1
				Loop While num3 <= 10
				IL_95E:
				num = 139
				dataTableBuilder.Build(False)
				IL_96D:
				num = 140
				OO_00oOO.Tables("表1").AddNew(10)
				IL_98A:
				num = 141
				OO_00oOO.DataTables("表1").BaseTable.AcceptChanges()
				IL_9A9:
				num = 142
				Me.OO_O_0Oo.___o.().Visible = True
				IL_9BB:
				num = 143
				Dim a_2 As String = "LoadUserSetting_" + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_9DD:
				num = 144
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, Nothing, True, Me.o._oOO0., False)
				IL_9F9:
				num = 145
				Me.OO_O_0Oo.___o.().ShowTabs = O_O0OO.O0_00o.o0__o..ShowTableCaption
				IL_A14:
				num = 146
				Me.OO_O_0Oo.___o.().CanMoveTabs = O_O0OO.O0_00o.o0__o..AllowMoveTable
				IL_A2F:
				num = 147
				Me.OO_O_0Oo.___o.().ShowTabList = O_O0OO.O0_00o.o0__o..ShowTableList
				IL_A4A:
				num = 148
				Me.OO_O_0Oo.___o.().CanCloseTabs = O_O0OO.O0_00o.o0__o..ShowCloseButton
				IL_A65:
				num = 149
				Me.OO_O_0Oo.___o.().CloseBox = O_O0OO.O0_00o.o0__o..CloseButton
				IL_A80:
				num = 150
				Dim enumerator8 As Dictionary(Of String, O_0).ValueCollection.Enumerator = O_O0OO.o__.O.().Values.GetEnumerator()
				While enumerator8.MoveNext()
					Dim o_3 As O_0 = enumerator8.Current
					IL_AA2:
					num = 151
					If o_3.O0OOO_0.o.() AndAlso Not o_3.O0O_0_0__.0O.().o_oo._0Oo.() Then
						IL_ABF:
						num = 152
						o_3.set_Filter(o_3.get_Filter())
					End If
					IL_AD3:
					num = 153
				End While
				IL_AE2:
				num = 154
				CType(enumerator8, IDisposable).Dispose()
				IL_AF5:
				num = 155
				If Not OO_00oOO.FileSys.FileExists(OO_00oOO.ApplicationPath + "Foxtable.ico") Then
					GoTo IL_B36
				End If
				IL_B16:
				num = 156
				MyBase.Icon = New Icon(OO_00oOO.ApplicationPath + "Foxtable.ico")
				IL_B36:
				num = 157
				Dim enumerator9 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator9.MoveNext()
					Dim table5 As Foxtable.Table = enumerator9.Current
					IL_B53:
					num = 158
					If table5.Grid.FindForm() IsNot Nothing Then
						IL_B67:
						num = 159
						If table5.Grid.RowSel = table5.Grid.Rows.Fixed Then
							IL_B8C:
							num = 160
							table5.Grid.ScrollPosition = New Point(0, 0)
						End If
					End If
					IL_BA5:
					num = 161
				End While
				IL_BB4:
				num = 162
				If enumerator9 IsNot Nothing Then
					enumerator9.Dispose()
				End If
				IL_BC5:
				num = 163
				O_O0OO.O0_00o.o0__o..o_0.O0o_o00o_. = O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..OO.0O.(), "ribbon", "code")
				IL_BEE:
				num = 164
				O_O0OO.O0_00o.o0__o..O_.0__O_000. = O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..OooO.O0.(), "ribbon", "code")
				IL_C17:
				num = 165
				If Not MyBase.Visible Then
					GoTo IL_C36
				End If
				IL_C25:
				num = 166
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				IL_C36:
				num = 167
				If Me.OO_O_0Oo.___o.().SelectedTab Is Nothing Then
					GoTo IL_C7E
				End If
				IL_C49:
				num = 168
				If Me.OO_O_0Oo.___o.().SelectedTab.Controls.Count <= 0 Then
					GoTo IL_C7E
				End If
				IL_C67:
				num = 169
				Me.OO_O_0Oo.___o.().SelectedTab.Focus()
				IL_C7E:
				num = 170
				OO_00oOO.Vars("SysUpdatePrintInfo") = True
				IL_C99:
				num = 171
				Main.O0O_.00_O0Oo_.()
				IL_CA4:
				num = 172
				If Me.O0o__0_OO.o.().TabPages.Count <> 0 Then
					GoTo IL_CCE
				End If
				IL_CBC:
				num = 173
				Me.O0o__0_OO.o.().Visible = False
				IL_CCE:
				num = 174
				Me.oOo_000oo_.0.()
				IL_CDA:
				num = 175
				If O_O0OO.O0_00o.o0__o..MaxForm Then
					GoTo IL_DBC
				End If
				IL_CEF:
				num = 176
				ooO.SetForegroundWindow(MyBase.Handle)
				IL_D01:
				num = 177
				If Not O_O0OO.O0_00o.o0__o..AllowResize Then
					GoTo IL_D22
				End If
				IL_D13:
				num = 178
				MyBase.FormBorderStyle = FormBorderStyle.Sizable
				GoTo IL_D2F
				IL_D22:
				num = 180
				MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
				IL_D2F:
				num = 181
				MyBase.WindowState = FormWindowState.Normal
				IL_D3C:
				num = 182
				MyBase.Size = New Size(Math.Max(400, O_O0OO.O0_00o.o0__o..FormWidth), Math.Max(400, O_O0OO.O0_00o.o0__o..FormHeight))
				IL_D75:
				num = 183
				MyBase.WindowState = FormWindowState.Normal
				IL_D82:
				num = 184
				MyBase.MaximizeBox = O_O0OO.O0_00o.o0__o..MaximizeBox
				IL_D98:
				num = 185
				MyBase.MinimizeBox = O_O0OO.O0_00o.o0__o..MinimizeBox
				IL_DAE:
				num = 186
				MyBase.CenterToScreen()
				GoTo IL_DDB
				IL_DBC:
				num = 188
				ooO.SetForegroundWindow(MyBase.Handle)
				IL_DCE:
				num = 189
				MyBase.WindowState = FormWindowState.Maximized
				IL_DDB:
				num = 190
				If OO_00oOO.User.Type IsNot Nothing OrElse Not O_O0OO.o00.0.(O_O0OO.O0_00o.o0__o.) Then
					GoTo IL_E06
				End If
				IL_DF9:
				num = 191
				MyBase.WindowState = FormWindowState.Maximized
				IL_E06:
				num = 192
				Me.oOO0.OOoo0oO. = DateTime.Now
				IL_E17:
				num = 193
				Me.Oo__.ooOo00_Oo.(New FileSystemWatcher())
				IL_E28:
				num = 194
				Me.O.OOO0_OOo.().Path = OO_00oOO.ProjectPath + "Bin"
				IL_E48:
				num = 195
				Me.O.OOO0_OOo.().EnableRaisingEvents = True
				IL_E5A:
				GoTo IL_11BC
				IL_E5F:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_117D:
				GoTo IL_11B1
				IL_117F:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_118F:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_117F
			End Try
			IL_11B1:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_11BC:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060034FB RID: 13563 RVA: 0x00161CD0 File Offset: 0x0015FED0
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRelation, A_1 As Boolean)
			Dim value As String = String.Concat(New String() { ".", A_0.ParentTable.TableName, ".", A_0.ChildTable.TableName, "." })
			Dim value2 As String = String.Concat(New String() { ".", A_0.ChildTable.TableName, ".", A_0.ParentTable.TableName, "." })
			Try
				For Each obj As Object In Me.OO_O_0Oo.___o.().TabPages
					Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
					Try
						For Each table As Foxtable.Table In OO_00oOO.Tables
							If table.View.O0O_0_0__.0O.() IsNot Nothing Then
								Dim text As String = "." + table.View.Oo._Oo0OO.() + "."
								If(text.IndexOf(value) >= 0 OrElse (text.IndexOf(value2) >= 0 AndAlso table.foxGrid.FindForm() Is Nothing)) AndAlso table.View.Oo._Oo0OO.().StartsWith(oo0__Oo.Name + ".") AndAlso table.foxGrid.FindForm() Is Nothing Then
									If A_1 Then
										oo0__Oo.O._o_00__.().OO_o0_oO.0.(table, False)
									End If
									table.O.__O0o0.(True)
									table.foxGrid.Cols.DefaultSize = 98
								End If
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of Foxtable.Table)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060034FC RID: 13564 RVA: 0x00161EB8 File Offset: 0x001600B8
		Friend Sub <<EMPTY_NAME>>()
			If Me.O.OOO0_OOo.().SelectedTab Is Nothing AndAlso Me.O.OOO0_OOo.().Tabs.Count > 0 Then
				Dim num As Integer = Me.O.OOO0_OOo.().Tabs.Count - 1
				For i As Integer = 0 To num
					If Me.O.OOO0_OOo.().Tabs(i).Visible AndAlso Me.O.OOO0_OOo.().Tabs(i).Enabled Then
						Me.O.OOO0_OOo.().SelectedTabIndex = i
						Return
					End If
				Next
			End If
		End Sub

		' Token: 0x060034FD RID: 13565 RVA: 0x00161F44 File Offset: 0x00160144
		Friend Sub <<EMPTY_NAME>>()
			Dim oo___OO0O_ As OO___OO0O_0 = Me.OO_O_0Oo.___o.()
			oo___OO0O_.SuspendLayout()
			oo___OO0O_.Alignment = O_O0OO.O0_00o.o0__o..TabPosition
			oo___OO0O_.AlignTabs = O_O0OO.O0_00o.o0__o..TabAlign
			oo___OO0O_.MultiLine = O_O0OO.O0_00o.o0__o..MultiLine
			oo___OO0O_.TextDirection = O_O0OO.O0_00o.o0__o..TextDirection
			oo___OO0O_.TabLayout = O_O0OO.O0_00o.o0__o..TabLayout
			oo___OO0O_.TabsSpacing = O_O0OO.O0_00o.o0__o..TabsSpacing
			oo___OO0O_.ResumeLayout()
		End Sub

		' Token: 0x060034FE RID: 13566 RVA: 0x00161FC4 File Offset: 0x001601C4
		Friend Function <<EMPTY_NAME>>(Optional A_0 As Boolean = False) As Integer
			Dim a_ As Boolean = OO_00oOO.SystemReady
			Dim result As Integer
			Try
				OO_00oOO.SystemReady = False
				If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._o.()).Rows.Count <= 6 OrElse A_0 OrElse (OO_00oOO.User.Type Is Nothing AndAlso OO_00oOO.ModifierKey = Keys.Control) Then
					If Me.OOO_O_OOO.oooo. Then
						If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) = 0 Then
							Me.Text = "Foxtable - 新项目"
						Else
							Me.Text = "Foxtable - " + Foxtable.My.c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile)
						End If
						Return 0
					End If
					OO_00oOO.SystemMenu = True
					Me.OOO_O_OOO.oooo. = True
					O_O0OO.o0OoO00OO.00O. = Nothing
					If Not Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(O_O0OO.O0OO_oOo_._o0_.()) Then
						Return 0
					End If
					O_O0OO.OOo_o.0o. = Foxtable.My.c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\Images\"
					Dim selectConnection As OleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(O_O0OO.O0OO_oOo_._o0_.()))
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter("Select * From [" + ooO0__OO.OO0o.OO_OoOO0.() + "]", selectConnection)
					Me.oO_0_.oO. = New DataTable()
					oleDbDataAdapter.FillSchema(Me.oO_0_.oO., SchemaType.Source)
					oleDbDataAdapter.Fill(Me.oO_0_.oO.)
					Dim text As String = O_O0OO.o.00O_O.() + "Bin\Foxtable.Ribbon.dll"
					If OO_00oOO.FileSys.FileExists(text) Then
						O_O0OO.o0OoO00OO.00O. = Assembly.Load(File.ReadAllBytes(text))
					Else
						O_O0OO.o0OoO00OO.00O. = Nothing
					End If
				Else
					Me.OOO_O_OOO.oooo. = False
					OO_00oOO.SystemMenu = False
					Dim text2 As String = OO_00oOO.ProjectPath + "Bin\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Ribbon.dll"
					Me.oO_0_.oO. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._o.())
					If OO_00oOO.FileSys.FileExists(text2) Then
						O_O0OO.o0OoO00OO.00O. = Assembly.Load(File.ReadAllBytes(text2))
					Else
						O_O0OO.o0OoO00OO.00O. = Nothing
					End If
				End If
				Dim o_Oo_o0O As o_Oo_o0O = New o_Oo_o0O()
				Dim ribbon As Ribbon = New Ribbon(Me.oO_0_.oO.)
				o_Oo_o0O.o._o0ooOOO.(Me.O.OOO0_OOo.(), O_O0OO.o.00O_O.(), Me.O.OOO0_OOo.(), ribbon)
				Me.O.OOO0_OOo.().HideTabHeaderRow = Not Me.O.OOO0_OOo.().HideTabHeaderRow
				Me.O.OOO0_OOo.().HideTabHeaderRow = Not Me.O.OOO0_OOo.().HideTabHeaderRow
				O_O0OO.OOo_o.0o. = True
				Dim a_2 As String = "Load_" + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, New Object(-1) {}, True, Me.o._oOO0., False)
				result = Conversions.ToInteger(Interaction.IIf(ribbon.Minimized, 2, 1))
			Catch a_3 As Exception
				ooO.oOo0Oo.o.(a_3, "")
			Finally
				OO_00oOO.SystemReady = a_
				O_O0OO.OOo_o.0o. = Foxtable.My.c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile) + "\Images\"
			End Try
			Return result
		End Function

		' Token: 0x060034FF RID: 13567 RVA: 0x001622F0 File Offset: 0x001604F0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Oo0__Oo
			Try
				For Each obj As Object In Me.OO_O_0Oo.___o.().TabPages
					Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
					If Operators.CompareString(oo0__Oo.Name, A_0, True) = 0 Then
						Return oo0__Oo
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x06003500 RID: 13568 RVA: 0x00162360 File Offset: 0x00160560
		Friend Sub <<EMPTY_NAME>>(A_0 As String, Optional A_1 As Boolean = True, Optional A_2 As Boolean = False)
			OO_00oOO.Tables(A_0).StopRedraw()
			Dim oo0__Oo As Oo0__Oo = New Oo0__Oo(OO_00oOO.Tables(A_0))
			oo0__Oo.TabVisible = A_1
			Me.OO_O_0Oo.___o.().TabPages.Add(oo0__Oo)
			OO_00oOO.Tables(A_0).oO_o_0o._0oooo.(True)
			OO_00oOO.Tables(A_0).O.__O0o0.(A_2)
			OO_00oOO.Tables(A_0).foxGrid.Cols.DefaultSize = 98
			OO_00oOO.Tables(A_0).ResumeRedraw()
			If Not A_2 Then
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.Tables(A_0).foxGrid
				Dim fixed As Integer = o_oOooO_O.Cols.Fixed
				Dim num As Integer = o_oOooO_O.Cols.Count - 1
				For i As Integer = fixed To num
					If o_oOooO_O.Cols(i).DataType Is GetType(Double) OrElse o_oOooO_O.Cols(i).DataType Is GetType(Decimal) OrElse o_oOooO_O.Cols(i).DataType Is GetType(Single) Then
						o_oOooO_O.Cols(i).Format = "#0.####"
					End If
				Next
			End If
		End Sub

		' Token: 0x06003501 RID: 13569 RVA: 0x001624A0 File Offset: 0x001606A0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ControlEventArgs)
			If OO_00oOO.SystemReady Then
				Me.o_0.O.()
			End If
		End Sub

		' Token: 0x06003502 RID: 13570 RVA: 0x001624B0 File Offset: 0x001606B0
		Friend Sub <<EMPTY_NAME>>()
			Dim table As Foxtable.Table = OO_00oOO.MainTable
			If Me.OO_O_0Oo.___o.().SelectedTab IsNot Nothing Then
				If Me.OO_O_0Oo.___o.().ShowTabs Then
					Me.oo.0o0. = True
				End If
				If Me.OO_O_0Oo.___o.().SelectedIndex >= 0 AndAlso Not Me.OO_O_0Oo.___o.().SelectedTab.TabVisible Then
					Dim num As Integer = Me.OO_O_0Oo.___o.().TabPages.Count - 1
					For i As Integer = 0 To num
						If Me.OO_O_0Oo.___o.().TabPages(i).TabVisible Then
							Me.OO_O_0Oo.___o.().SelectedIndex = i
							Return
						End If
					Next
				End If
				Dim selectedIndex As Integer = Me.OO_O_0Oo.___o.().SelectedIndex
				Dim c1DockingTabPage As C1DockingTabPage = Nothing
				If selectedIndex >= 0 AndAlso Me.OO_O_0Oo.___o.().TabPages(selectedIndex).TabVisible Then
					c1DockingTabPage = Me.OO_O_0Oo.___o.().TabPages(selectedIndex)
				End If
				If c1DockingTabPage IsNot Nothing AndAlso OO_00oOO.Tables IsNot Nothing AndAlso OO_00oOO.Tables.get_Contains(c1DockingTabPage.Name) Then
					Dim o_oOooO_O As O_oOooO_O = OO_00oOO.Tables(c1DockingTabPage.Name).foxGrid
					If o_oOooO_O.FindForm() IsNot Nothing Then
						If TypeOf o_oOooO_O.FindForm()Is DropDownForm Then
							o_oOooO_O.FindForm().Controls.Clear()
						ElseIf o_oOooO_O.FindForm() IsNot Me Then
							o_oOooO_O.FindForm().Close()
							oOO0oo_o0.o.O0o000_.(o_oOooO_O)
						End If
					End If
					Dim table2 As Foxtable.Table = OO_00oOO.Tables(c1DockingTabPage.Name)
					If OO_00oOO.MainTable IsNot table2 Then
						OO_00oOO.MainTable = table2
						OO_00oOO.MainTable = OO_00oOO.Tables(c1DockingTabPage.Name)
					End If
				Else
					OO_00oOO.O_0.oooO__O. = Nothing
					OO_00oOO.CurrentTable = Nothing
				End If
				If table IsNot OO_00oOO.MainTable Then
					Dim table3 As Foxtable.Table = OO_00oOO.MainTable
					Dim array As SystemEventTypeEnum() = New SystemEventTypeEnum(3) {}
					RuntimeHelpers.InitializeArray(array, fieldof(Global.b.o00_.oO_.).FieldHandle)
					OO_00oOO.RaiseSystemEvent(table3, array)
					If OO_00oOO.SystemReady AndAlso OO_00oOO.MainTable IsNot Nothing Then
						OO_00oOO.MainTable.View.o_._0O0o_OoO.()
						OO_00oOO.MainTable.View.Oo._Oo0OO.()
					End If
				End If
			End If
		End Sub

		' Token: 0x06003503 RID: 13571 RVA: 0x001626A4 File Offset: 0x001608A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.SystemReady Then
				If Me.OO_O_0Oo.___o.().ShowTabs Then
					Me.oo.0o0. = True
				End If
				Me.o_0.O.()
			End If
		End Sub

		' Token: 0x06003504 RID: 13572 RVA: 0x001626C8 File Offset: 0x001608C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SelectedIndexChangingEventArgs)
			If OO_00oOO.SystemReady AndAlso OO_00oOO.MainTable IsNot Nothing AndAlso A_1.NewIndex <> -1 Then
				Dim name As String = Me.OO_O_0Oo.___o.().TabPages(A_1.NewIndex).Name
				Dim a_ As String = OO_00oOO.MainTable.Name
				Dim maintableChangingEventArgs As MaintableChangingEventArgs = New MaintableChangingEventArgs(a_, name)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "MainTableChanging", New Object() { maintableChangingEventArgs }, False, "项目", False)
				A_1.Cancel = maintableChangingEventArgs.Cancel
				If Not A_1.Cancel Then
					Dim flag As Boolean
					Do
						flag = False
						Try
							For Each obj As Object In Application.OpenForms
								Dim form As System.Windows.Forms.Form = CType(obj, System.Windows.Forms.Form)
								If TypeOf form Is ef OrElse TypeOf form Is O\u3002\u3000\u3002\u3002 Then
									flag = True
									form.Close()
									Exit For
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Loop While flag
				End If
			End If
		End Sub

		' Token: 0x06003505 RID: 13573 RVA: 0x001627C8 File Offset: 0x001609C8
		Public Sub New()
			Dim a_ As Integer = 16
			MyBase..ctor()
			AddHandler MyBase.FormClosed, AddressOf Me.o0oO_O.0Oo_00.
			AddHandler MyBase.FormClosing, AddressOf Me.o0oO_O.0Oo_00.
			AddHandler MyBase.KeyDown, AddressOf Me.o0oO_O.0Oo_00.
			AddHandler MyBase.Load, AddressOf Me.oO_oOo_0_.o.
			AddHandler MyBase.SizeChanged, AddressOf Me.Oo.O000_oO__o.
			Me.oO_0_.oO. = Nothing
			Me.o0O.OO. = False
			Me.o._oOO0. = New oooO0o000O()
			Me.o_O_0Oo0.0O0O. = DateTime.Now
			Me.o._oOO0. = O00OOOo_O0_O.b("䈞", a_)
			Me.O.0_0O___Oo. = O00OOOo_O0_O.b("䈞躡", a_)
			Try
				For Each text As String In OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("좟잡즣쎥�", a_), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, New String() { O00OOOo_O0_O.b("뒝躟송閣튥삧쾩솫쮭쪯", a_) })
					If text.IndexOf(O00OOOo_O0_O.b("凣�", a_)) <= 0 Then
						If Operators.CompareString(OO_00oOO.FileSys.GetName(text), O00OOOo_O0_O.b("톝욟쒡춣얥춧颩鲫龭莯욳펵�풹銻�뛁곃ꏅꗇ꿉뛋", a_), True) = 0 Then
							C1ThemeController.UnregisterTheme(O00OOOo_O0_O.b("톝욟쒡춣얥춧颩鲫龭莯욳펵�풹", a_))
						End If
						C1ThemeController.RegisterTheme(text)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.oO_0_.oO. = C1ThemeController.GetThemeByName(O00OOOo_O0_O.b("톝욟쒡춣얥춧颩鲫龭莯욳펵�풹", a_), False).Children(O00OOOo_O0_O.b("�醟춣쒥쪧얩슫", a_)).Children(O00OOOo_O0_O.b("�튟춡톣횥�", a_)).Children(O00OOOo_O0_O.b("�쾟첡킣", a_))
			Me.OOO.O_Oo0.()
			C1ThemeController.ApplicationTheme = O00OOOo_O0_O.b("좝邡钣鞥鮧�쮭햯�", a_)
			If Operators.CompareString(Me.O.OOO0_OOo.().Font.Name, O_O0OO.oo_oo_o._., True) <> 0 OrElse Me.O.OOO0_OOo.().Font.Size <> CSng(O_O0OO.oO_00Ooo___0._.) Then
				Me.O.OOO0_OOo.().Font = New Font(O_O0OO.oo_oo_o._., CSng(O_O0OO.oO_00Ooo___0._.), Me.O.OOO0_OOo.().Font.Style)
			End If
			Me.OO_O_0Oo.___o.().TabSizeMode = 1
			AddHandler Application.Idle, AddressOf Me.O0oo.o_o__oO0.
			AddHandler OO_00oOO.MainTableChanged, AddressOf Me.o_o.0.
			AddHandler OO_00oOO.CurrentTableChanged, AddressOf Me.o0._Oo.
			MyBase.Activate()
		End Sub

		' Token: 0x06003506 RID: 13574 RVA: 0x00162A6C File Offset: 0x00160C6C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				RemoveHandler Application.Idle, AddressOf Me.O0oo.o_o__oO0.
				IL_13:
				num = 2
				RemoveHandler OO_00oOO.MainTableChanged, AddressOf Me.o_o.0.
				IL_26:
				num = 3
				RemoveHandler OO_00oOO.CurrentTableChanged, AddressOf Me.o0._Oo.
				IL_39:
				num = 4
				If DateTime.Compare(Foxtable.My.b.O0o0oO00_.O.().LastDate, DateTime.Today) = 0 Then
					GoTo IL_86
				End If
				IL_51:
				num = 5
				Foxtable.My.b.O0o0oO00_.O.().LastDate = DateTime.Today
				IL_62:
				num = 6
				Foxtable.My.b.O0o0oO00_.O.().Count = Foxtable.My.b.O0o0oO00_.O.().Count + 1
				IL_7A:
				num = 7
				Foxtable.My.b.O0o0oO00_.O.().Save()
				IL_86:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_8D:
				num = 9
				MyBase.Controls.Clear()
				IL_9B:
				num = 10
				MyBase.Dispose()
				IL_A4:
				GoTo IL_11F
				IL_A6:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E0:
				GoTo IL_114
				IL_E2:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_F2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E2
			End Try
			IL_114:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_11F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003507 RID: 13575 RVA: 0x00162BB0 File Offset: 0x00160DB0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			A_1.Cancel = False
			If Not Oo00.OO_O_0O0OO0_.o.() Then
				A_1.Cancel = True
				Return
			End If
			Me.o_O.o__. = True
			Try
				For Each obj As Object In Application.OpenForms
					Dim form As System.Windows.Forms.Form = CType(obj, System.Windows.Forms.Form)
					If TypeOf form Is O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002 OrElse TypeOf form Is o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000 Then
						form.Close()
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim keyName As String = "HKEY_CURRENT_USER\Software\" + O00.ooo000o_0.00o0.(o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4), "Tick", "Tick")
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Foxtable.My.c.OOOOO.o.().Registry.GetValue(keyName, "LastDate", DateTime.Today))
			Dim t As DateTime
			If objectValue IsNot Nothing Then
				DateTime.TryParse(objectValue.ToString(), t)
			End If
			If DateTime.Compare(t, DateTime.Today) <> 0 Then
				Foxtable.My.c.OOOOO.o.().Registry.SetValue(keyName, "LastDate", DateTime.Today)
				objectValue = RuntimeHelpers.GetObjectValue(Foxtable.My.c.OOOOO.o.().Registry.GetValue(keyName, "Count", 0))
				Dim num As Integer
				If objectValue IsNot Nothing Then
					Integer.TryParse(objectValue.ToString(), num)
				End If
				num += 1
				Foxtable.My.c.OOOOO.o.().Registry.SetValue(keyName, "Count", num)
			End If
		End Sub

		' Token: 0x06003508 RID: 13576 RVA: 0x00162D1C File Offset: 0x00160F1C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.Control AndAlso A_1.Shift AndAlso A_1.KeyCode = Keys.F12 AndAlso OO_00oOO.User.Type Is Nothing Then
				If MessageBox.Show("需要回到系统菜单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					Project.OpenSystemMenu()
					Return
				End If
			ElseIf A_1.Control AndAlso A_1.Shift AndAlso A_1.KeyCode = Keys.F11 AndAlso OO_00oOO.User.Type Is Nothing Then
				If MessageBox.Show("需要回到用户菜单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
					Project.OpenUserMenu()
					Return
				End If
			ElseIf Not A_1.Shift And Not A_1.Control And Not A_1.Alt And A_1.KeyCode = Keys.F1 Then
				OO_00oOO.ShowHelpWindow()
			End If
		End Sub

		' Token: 0x06003509 RID: 13577 RVA: 0x00162DDC File Offset: 0x00160FDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.OOO0_OOo.().Selectable = False
			Me.O.OOO0_OOo.().HideAppMenuWithTHR = True
			If Me.O.OOO0_OOo.() Is Nothing AndAlso Me.O0o__0_OO.o.().TabPages.Count = 0 Then
				Me.O0o__0_OO.o.().Width = 0
			End If
			If MyBase.WindowState = FormWindowState.Normal Then
				MyBase.Size = New Size(Math.Max(400, O_O0OO.O0_00o.o0__o..FormWidth), Math.Max(400, O_O0OO.O0_00o.o0__o..FormHeight))
			End If
			MyBase.Activate()
			If Me.O.OOO0_OOo.() IsNot Nothing Then
				Dim c1TopicPage As C1TopicPage = Me.O.OOO0_OOo.().Pages(2)
				Dim num As Integer = O_O0OO.o0OoO00OO.00O..Count - 1
				Dim num2 As Integer = 0
				While num2 <= num AndAlso num2 <> O_O0OO.o0OoO00OO.00O.
					Dim c1TopicLink As C1TopicLink = New C1TopicLink()
					c1TopicLink.Text = Conversions.ToString(num2 + 1) + "." + Foxtable.My.c.OOOOO.o.().FileSystem.GetName(O_O0OO.o0OoO00OO.00O.(num2))
					c1TopicLink.ToolTipText = O_O0OO.o0OoO00OO.00O.(num2)
					c1TopicLink.Tag = "RecenFile"
					c1TopicPage.Links.Add(c1TopicLink)
					num2 += 1
				End While
			End If
			If Me.oO_0_.oO. = 1 Then
				Me.O.OOO0_OOo.().Minimized = False
			ElseIf Me.oO_0_.oO. = 2 Then
				Me.O.OOO0_OOo.().Minimized = True
			End If
			Me.o0o_.o. = New ToolTip(Me.oOO0.OOoo0oO.)
		End Sub

		' Token: 0x0600350A RID: 13578 RVA: 0x00162F48 File Offset: 0x00161148
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RibbonEventArgs)
			Dim a_ As Integer = 11
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				Dim num2 As Integer = 2
				Dim component As Component = A_1.Item
				IL_1A:
				num2 = 3
				If Main.OO_O.o. Is Nothing Then
					GoTo IL_1829
				End If
				IL_26:
				num2 = 5
				Dim text As String = A_1.EventType.ToString() + O00OOOo_O0_O.b("욘", a_)
				IL_51:
				num2 = 6
				If OO_00oOO.Forms.ActiveForm Is Nothing Then
					GoTo IL_87
				End If
				IL_5F:
				num2 = 7
				Dim control As Foxtable.WinForm.Control = CType(OO_00oOO.Forms.ActiveForm.ActiveControl, Foxtable.WinForm.Control)
				IL_77:
				num2 = 8
				If control Is Nothing Then
					GoTo IL_87
				End If
				IL_7D:
				num2 = 9
				control.WriteValue()
				IL_87:
				num2 = 10
				If Not(TypeOf A_1.Item Is RibbonListItem) OrElse A_1.EventType <> 1 Then
					GoTo IL_ED
				End If
				IL_A0:
				num2 = 11
				Dim ribbonListItem As RibbonListItem = CType(A_1.Item, RibbonListItem)
				IL_B0:
				num2 = 12
				If ribbonListItem.Tag IsNot Nothing AndAlso Operators.CompareString(ribbonListItem.Tag.ToString(), "", True) <> 0 Then
					GoTo IL_1829
				End If
				IL_D8:
				num2 = 13
				component = ribbonListItem.Items(0)
				IL_EA:
				ribbonListItem = Nothing
				IL_ED:
				num2 = 17
				If A_1.EventType <> 1 Then
					GoTo IL_111
				End If
				IL_F9:
				num2 = 18
				If Me.oO__._ooo__. Then
					GoTo IL_1829
				End If
				IL_107:
				num2 = 21
				Me.oO__._ooo__. = True
				IL_111:
				num2 = 22
				If component IsNot Me.O.OOO0_OOo.().Qat Then
					GoTo IL_1C4
				End If
				IL_126:
				num2 = 23
				Dim a_2 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Qat.Tag)
				IL_146:
				num2 = 24
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, Nothing, False, Me.O.0_0O___Oo. + O00OOOo_O0_O.b("狇萊∗焋껈", a_), False)
				IL_172:
				num2 = 25
				Dim a_3 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_18D:
				num2 = 26
				Dim ribbonEventArgs As RibbonEventArgs = New RibbonEventArgs(OO_00oOO.QAT)
				IL_19C:
				num2 = 27
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_3, New Object() { ribbonEventArgs }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_1C4:
				num2 = 29
				If component IsNot Me.O.OOO0_OOo.().ApplicationMenu Then
					GoTo IL_277
				End If
				IL_1D9:
				num2 = 30
				Dim a_4 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().ApplicationMenu.Tag)
				IL_1F9:
				num2 = 31
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_4, Nothing, False, Me.O.0_0O___Oo. + O00OOOo_O0_O.b("鋢ᓄ䄟쫍", a_), False)
				IL_225:
				num2 = 32
				Dim a_5 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_240:
				num2 = 33
				Dim ribbonEventArgs2 As RibbonEventArgs = New RibbonEventArgs(OO_00oOO.ApplicationMenu)
				IL_24F:
				num2 = 34
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_5, New Object() { ribbonEventArgs2 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_277:
				num2 = 36
				If component IsNot Me.O.OOO0_OOo.().ConfigToolBar Then
					GoTo IL_32A
				End If
				IL_28C:
				num2 = 37
				Dim a_6 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().ConfigToolBar.Tag)
				IL_2AC:
				num2 = 38
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_6, Nothing, False, Me.O.0_0O___Oo. + O00OOOo_O0_O.b("퐉鋴", a_), False)
				IL_2D8:
				num2 = 39
				Dim a_7 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_2F3:
				num2 = 40
				Dim ribbonEventArgs3 As RibbonEventArgs = New RibbonEventArgs(OO_00oOO.ConfigBar)
				IL_302:
				num2 = 41
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_7, New Object() { ribbonEventArgs3 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_32A:
				num2 = 43
				If component IsNot Me.O.OOO0_OOo.().TopToolBar Then
					GoTo IL_3DD
				End If
				IL_33F:
				num2 = 44
				Dim a_8 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().TopToolBar.Tag)
				IL_35F:
				num2 = 45
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_8, Nothing, False, Me.O.0_0O___Oo. + O00OOOo_O0_O.b("鏖织郶", a_), False)
				IL_38B:
				num2 = 46
				Dim a_9 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_3A6:
				num2 = 47
				Dim ribbonEventArgs4 As RibbonEventArgs = New RibbonEventArgs(OO_00oOO.TopToolBar)
				IL_3B5:
				num2 = 48
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_9, New Object() { ribbonEventArgs4 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_3DD:
				num2 = 50
				If component IsNot Me.O.OOO0_OOo.().BottomToolBar Then
					GoTo IL_490
				End If
				IL_3F2:
				num2 = 51
				Dim a_10 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().BottomToolBar.Tag)
				IL_412:
				num2 = 52
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_10, Nothing, False, Me.O.0_0O___Oo. + O00OOOo_O0_O.b("鋖织郶", a_), False)
				IL_43E:
				num2 = 53
				Dim a_11 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_459:
				num2 = 54
				Dim ribbonEventArgs5 As RibbonEventArgs = New RibbonEventArgs(OO_00oOO.BottomToolBar)
				IL_468:
				num2 = 55
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_11, New Object() { ribbonEventArgs5 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_490:
				num2 = 57
				If Not(TypeOf component Is RibbonToggleButton) Then
					GoTo IL_556
				End If
				IL_49F:
				num2 = 58
				Dim toggleButton As ToggleButton = New ToggleButton(CType(component, RibbonToggleButton))
				IL_4B0:
				num2 = 59
				Dim ribbonToggleButtonEventArgs As RibbonToggleButtonEventArgs = New RibbonToggleButtonEventArgs(toggleButton)
				IL_4BC:
				num2 = 60
				Dim a_12 As String = text + Conversions.ToString(toggleButton.o__Oo__.O__..Tag)
				IL_4D8:
				num2 = 61
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_12, New Object() { ribbonToggleButtonEventArgs }, False, Me.O.0_0O___Oo. + toggleButton.Name, False)
				IL_507:
				num2 = 62
				Dim ribbonEventArgs6 As RibbonEventArgs = New RibbonEventArgs(toggleButton)
				IL_513:
				num2 = 63
				Dim a_13 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_52E:
				num2 = 64
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_13, New Object() { ribbonEventArgs6 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_556:
				num2 = 66
				If Not(TypeOf component Is RibbonCheckBox) Then
					GoTo IL_61C
				End If
				IL_565:
				num2 = 67
				Dim checkBox As Foxtable.RibbonMenu.CheckBox = New Foxtable.RibbonMenu.CheckBox(CType(component, RibbonCheckBox))
				IL_576:
				num2 = 68
				Dim ribbonCheckBoxEventArgs As RibbonCheckBoxEventArgs = New RibbonCheckBoxEventArgs(checkBox)
				IL_582:
				num2 = 69
				Dim a_14 As String = text + Conversions.ToString(checkBox.oOoOoOoO._o0..Tag)
				IL_59E:
				num2 = 70
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_14, New Object() { ribbonCheckBoxEventArgs }, False, Me.O.0_0O___Oo. + checkBox.Name, False)
				IL_5CD:
				num2 = 71
				Dim ribbonEventArgs7 As RibbonEventArgs = New RibbonEventArgs(checkBox)
				IL_5D9:
				num2 = 72
				Dim a_15 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_5F4:
				num2 = 73
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_15, New Object() { ribbonEventArgs7 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_61C:
				num2 = 75
				If Not(TypeOf component Is o_o_Oo0__o_0) Then
					GoTo IL_802
				End If
				IL_62B:
				num2 = 76
				Dim gallery As Gallery = New Gallery(CType(component, o_o_Oo0__o_0))
				IL_63C:
				num2 = 77
				Dim ribbonGalleryEventArgs As RibbonGalleryEventArgs = New RibbonGalleryEventArgs(gallery, New GalleryItem(CType(component, o_o_Oo0__o_0).SelectedItem))
				IL_659:
				num2 = 78
				If Operators.CompareString(text, O00OOOo_O0_O.b("쪘ﺚ爵슠힢삤쎦얪즬쪮즰�횶ힸ���黀", a_), True) <> 0 Then
					GoTo IL_768
				End If
				IL_676:
				num2 = 79
				If Not CType(component, o_o_Oo0__o_0).o.o_.() Then
					GoTo IL_70B
				End If
				IL_68A:
				num2 = 80
				If CType(component, o_o_Oo0__o_0).SelectedItem Is Nothing Then
					GoTo IL_9F7
				End If
				IL_69E:
				num2 = 81
				CType(component, o_o_Oo0__o_0).SelectedIndex = -1
				IL_6AE:
				num2 = 82
				Dim a_16 As String = O00OOOo_O0_O.b("킘쾢첤쒦슨", a_) + Conversions.ToString(gallery.o_.o0_o..Tag)
				IL_6D7:
				num2 = 83
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_16, New Object() { ribbonGalleryEventArgs }, False, Me.O.0_0O___Oo. + gallery.Name, False)
				GoTo IL_9F7
				IL_70B:
				num2 = 85
				a_16 = O00OOOo_O0_O.b("킘욢즤슦쪨�좬쮮", a_) + Conversions.ToString(gallery.o_.o0_o..Tag)
				IL_734:
				num2 = 86
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_16, New Object() { ribbonGalleryEventArgs }, False, Me.O.0_0O___Oo. + gallery.Name, False)
				GoTo IL_9F7
				IL_768:
				num2 = 88
				Dim a_17 As String = text + Conversions.ToString(gallery.o_.o0_o..Tag)
				IL_784:
				num2 = 89
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_17, New Object() { ribbonGalleryEventArgs }, False, Me.O.0_0O___Oo. + gallery.Name, False)
				IL_7B3:
				num2 = 90
				Dim ribbonEventArgs8 As RibbonEventArgs = New RibbonEventArgs(gallery)
				IL_7BF:
				num2 = 91
				Dim a_18 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_7DA:
				num2 = 92
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_18, New Object() { ribbonEventArgs8 }, False, Me.o._oOO0., False)
				GoTo IL_9F7
				IL_802:
				num2 = 94
				If Not(TypeOf component Is RibbonButton) Then
					GoTo IL_9F7
				End If
				IL_811:
				num2 = 95
				If OO_00oOO.CurrentTable Is Nothing OrElse Operators.CompareString(A_1.EventType.ToString(), O00OOOo_O0_O.b("�ﲞ쪠", a_), True) <> 0 Then
					GoTo IL_873
				End If
				IL_846:
				num2 = 96
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				IL_855:
				num2 = 97
				If o_oOooO_O.Editor Is Nothing Then
					GoTo IL_870
				End If
				IL_861:
				num2 = 98
				If Not o_oOooO_O.FinishEditing() Then
					GoTo IL_1829
				End If
				IL_870:
				o_oOooO_O = Nothing
				IL_873:
				num2 = 101
				If MyBase.ActiveControl Is Nothing OrElse Not(TypeOf MyBase.ActiveControl.Parent Is OooOo0___oO) Then
					GoTo IL_8C3
				End If
				IL_890:
				num2 = 102
				Dim oooOo0___oO As OooOo0___oO = CType(MyBase.ActiveControl.Parent, OooOo0___oO)
				IL_8A5:
				num2 = 103
				If oooOo0___oO.Editor Is Nothing Then
					GoTo IL_8C0
				End If
				IL_8B1:
				num2 = 104
				If Not oooOo0___oO.FinishEditing() Then
					GoTo IL_1829
				End If
				IL_8C0:
				oooOo0___oO = Nothing
				IL_8C3:
				num2 = 107
				Dim button As Foxtable.RibbonMenu.Button = New Foxtable.RibbonMenu.Button(CType(component, RibbonButton))
				IL_8D4:
				num2 = 108
				If Operators.CompareString(button.Name, O00OOOo_O0_O.b("�힞캠캢삤���삮�", a_), True) = 0 Then
					GoTo IL_1829
				End If
				IL_8F7:
				num2 = 110
				If Not(TypeOf button.oOoOoOoO._o0..Tag Is String) Then
					GoTo IL_964
				End If
				IL_90D:
				num2 = 111
				Dim ribbonButtonEventArgs As RibbonButtonEventArgs = New RibbonButtonEventArgs(button)
				IL_919:
				num2 = 112
				Dim a_19 As String = text + Conversions.ToString(button.oOoOoOoO._o0..Tag)
				IL_935:
				num2 = 113
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_19, New Object() { ribbonButtonEventArgs }, False, Me.O.0_0O___Oo. + button.Name, False)
				IL_964:
				num2 = 114
				Dim ribbonEventArgs9 As RibbonEventArgs = New RibbonEventArgs(button)
				IL_970:
				num2 = 115
				Dim a_20 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_98B:
				num2 = 116
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_20, New Object() { ribbonEventArgs9 }, False, Me.o._oOO0., False)
				IL_9AE:
				num2 = 117
				If(DateTime.Now - Me.oOO0.OOoo0oO.).TotalMinutes <= CDbl((4 + DateTime.Today.DayOfWeek)) Then
					GoTo IL_9F7
				End If
				IL_9DD:
				num2 = 118
				If Me.o0O.OO. Then
					GoTo IL_9F7
				End If
				IL_9E8:
				num2 = 119
				Me.O.OOO0_OOo.().Enabled = False
				IL_9F7:
				num2 = 120
				If Not(TypeOf component Is RibbonColorPicker) Then
					GoTo IL_ABD
				End If
				IL_A06:
				num2 = 121
				Dim colorPicker As Foxtable.RibbonMenu.ColorPicker = New Foxtable.RibbonMenu.ColorPicker(CType(component, RibbonColorPicker))
				IL_A17:
				num2 = 122
				Dim ribbonColorPickerEventArgs As RibbonColorPickerEventArgs = New RibbonColorPickerEventArgs(colorPicker)
				IL_A23:
				num2 = 123
				Dim a_21 As String = text + Conversions.ToString(colorPicker.oOoOoOoO._o0..Tag)
				IL_A3F:
				num2 = 124
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_21, New Object() { ribbonColorPickerEventArgs }, False, Me.O.0_0O___Oo. + colorPicker.Name, False)
				IL_A6E:
				num2 = 125
				Dim ribbonEventArgs10 As RibbonEventArgs = New RibbonEventArgs(colorPicker)
				IL_A7A:
				num2 = 126
				Dim a_22 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_A95:
				num2 = 127
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_22, New Object() { ribbonEventArgs10 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_ABD:
				num2 = 129
				If Not(TypeOf component Is RibbonSplitButton) Then
					GoTo IL_B9B
				End If
				IL_ACF:
				num2 = 130
				Dim splitButton As SplitButton = New SplitButton(CType(component, RibbonSplitButton))
				IL_AE3:
				num2 = 131
				Dim ribbonSplitButtonEventArgs As RibbonSplitButtonEventArgs = New RibbonSplitButtonEventArgs(splitButton)
				IL_AF2:
				num2 = 132
				Dim a_23 As String = text + Conversions.ToString(splitButton.OO0.0OOo__..Tag)
				IL_B11:
				num2 = 133
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_23, New Object() { ribbonSplitButtonEventArgs }, False, Me.O.0_0O___Oo. + splitButton.Name, False)
				IL_B43:
				num2 = 134
				Dim ribbonEventArgs11 As RibbonEventArgs = New RibbonEventArgs(splitButton)
				IL_B52:
				num2 = 135
				Dim a_24 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_B70:
				num2 = 136
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_24, New Object() { ribbonEventArgs11 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_B9B:
				num2 = 138
				If Not(TypeOf component Is RibbonLabel) Then
					GoTo IL_C79
				End If
				IL_BAD:
				num2 = 139
				Dim label As Foxtable.RibbonMenu.Label = New Foxtable.RibbonMenu.Label(CType(component, RibbonLabel))
				IL_BC1:
				num2 = 140
				Dim ribbonLabelEventArgs As RibbonLabelEventArgs = New RibbonLabelEventArgs(label)
				IL_BD0:
				num2 = 141
				Dim a_25 As String = text + Conversions.ToString(label.OOo.O_o..Tag)
				IL_BEF:
				num2 = 142
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_25, New Object() { ribbonLabelEventArgs }, False, Me.O.0_0O___Oo. + label.Name, False)
				IL_C21:
				num2 = 143
				Dim ribbonEventArgs12 As RibbonEventArgs = New RibbonEventArgs(label)
				IL_C30:
				num2 = 144
				Dim a_26 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_C4E:
				num2 = 145
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_26, New Object() { ribbonEventArgs12 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_C79:
				num2 = 147
				If Not(TypeOf component Is RibbonTextBox) Then
					GoTo IL_D57
				End If
				IL_C8B:
				num2 = 148
				Dim textBox As Foxtable.RibbonMenu.TextBox = New Foxtable.RibbonMenu.TextBox(CType(component, RibbonTextBox))
				IL_C9F:
				num2 = 149
				Dim ribbonTextBoxEventArgs As RibbonTextBoxEventArgs = New RibbonTextBoxEventArgs(textBox)
				IL_CAE:
				num2 = 150
				Dim a_27 As String = text + Conversions.ToString(textBox.o__Oo__.O__..Tag)
				IL_CCD:
				num2 = 151
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_27, New Object() { ribbonTextBoxEventArgs }, False, Me.O.0_0O___Oo. + textBox.Name, False)
				IL_CFF:
				num2 = 152
				Dim ribbonEventArgs13 As RibbonEventArgs = New RibbonEventArgs(textBox)
				IL_D0E:
				num2 = 153
				Dim a_28 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_D2C:
				num2 = 154
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_28, New Object() { ribbonEventArgs13 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_D57:
				num2 = 156
				If Not(TypeOf component Is RibbonDatePicker) Then
					GoTo IL_E35
				End If
				IL_D69:
				num2 = 157
				Dim datePicker As DatePicker = New DatePicker(CType(component, RibbonDatePicker))
				IL_D7D:
				num2 = 158
				Dim ribbonDatePickerEventArgs As RibbonDatePickerEventArgs = New RibbonDatePickerEventArgs(datePicker)
				IL_D8C:
				num2 = 159
				Dim a_29 As String = text + Conversions.ToString(datePicker.o_.o0_o..Tag)
				IL_DAB:
				num2 = 160
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_29, New Object() { ribbonDatePickerEventArgs }, False, Me.O.0_0O___Oo. + datePicker.Name, False)
				IL_DDD:
				num2 = 161
				Dim ribbonEventArgs14 As RibbonEventArgs = New RibbonEventArgs(datePicker)
				IL_DEC:
				num2 = 162
				Dim a_30 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_E0A:
				num2 = 163
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_30, New Object() { ribbonEventArgs14 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_E35:
				num2 = 165
				If Not(TypeOf component Is RibbonTimePicker) Then
					GoTo IL_F13
				End If
				IL_E47:
				num2 = 166
				Dim timePicker As TimePicker = New TimePicker(CType(component, RibbonTimePicker))
				IL_E5B:
				num2 = 167
				Dim ribbonTimePickerEventArgs As RibbonTimePickerEventArgs = New RibbonTimePickerEventArgs(timePicker)
				IL_E6A:
				num2 = 168
				Dim a_31 As String = text + Conversions.ToString(timePicker.o__Oo__.O__..Tag)
				IL_E89:
				num2 = 169
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_31, New Object() { ribbonTimePickerEventArgs }, False, Me.O.0_0O___Oo. + timePicker.Name, False)
				IL_EBB:
				num2 = 170
				Dim ribbonEventArgs15 As RibbonEventArgs = New RibbonEventArgs(timePicker)
				IL_ECA:
				num2 = 171
				Dim a_32 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_EE8:
				num2 = 172
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_32, New Object() { ribbonEventArgs15 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_F13:
				num2 = 174
				If Not(TypeOf component Is RibbonTrackBar) Then
					GoTo IL_FF1
				End If
				IL_F25:
				num2 = 175
				Dim trackBar As Foxtable.RibbonMenu.TrackBar = New Foxtable.RibbonMenu.TrackBar(CType(component, RibbonTrackBar))
				IL_F39:
				num2 = 176
				Dim ribbonTrackBarEventArgs As RibbonTrackBarEventArgs = New RibbonTrackBarEventArgs(trackBar)
				IL_F48:
				num2 = 177
				Dim a_33 As String = text + Conversions.ToString(trackBar.O.oOOO..Tag)
				IL_F67:
				num2 = 178
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_33, New Object() { ribbonTrackBarEventArgs }, False, Me.O.0_0O___Oo. + trackBar.Name, False)
				IL_F99:
				num2 = 179
				Dim ribbonEventArgs16 As RibbonEventArgs = New RibbonEventArgs(trackBar)
				IL_FA8:
				num2 = 180
				Dim a_34 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_FC6:
				num2 = 181
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_34, New Object() { ribbonEventArgs16 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_FF1:
				num2 = 183
				If Not(TypeOf component Is RibbonNumericBox) Then
					GoTo IL_10CF
				End If
				IL_1003:
				num2 = 184
				Dim numericBox As NumericBox = New NumericBox(CType(component, RibbonNumericBox))
				IL_1017:
				num2 = 185
				Dim ribbonNumericBoxEventArgs As RibbonNumericBoxEventArgs = New RibbonNumericBoxEventArgs(numericBox)
				IL_1026:
				num2 = 186
				Dim a_35 As String = text + Conversions.ToString(numericBox.OOo.O_o..Tag)
				IL_1045:
				num2 = 187
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_35, New Object() { ribbonNumericBoxEventArgs }, False, Me.O.0_0O___Oo. + numericBox.Name, False)
				IL_1077:
				num2 = 188
				Dim ribbonEventArgs17 As RibbonEventArgs = New RibbonEventArgs(numericBox)
				IL_1086:
				num2 = 189
				Dim a_36 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_10A4:
				num2 = 190
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_36, New Object() { ribbonEventArgs17 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_10CF:
				num2 = 192
				If Not(TypeOf component Is RibbonProgressBar) Then
					GoTo IL_11AD
				End If
				IL_10E1:
				num2 = 193
				Dim progressBar As Foxtable.RibbonMenu.ProgressBar = New Foxtable.RibbonMenu.ProgressBar(CType(component, RibbonProgressBar))
				IL_10F5:
				num2 = 194
				Dim ribbonProgressBarEventArgs As RibbonProgressBarEventArgs = New RibbonProgressBarEventArgs(progressBar)
				IL_1104:
				num2 = 195
				Dim a_37 As String = text + Conversions.ToString(progressBar.OOo.O_o..Tag)
				IL_1123:
				num2 = 196
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_37, New Object() { ribbonProgressBarEventArgs }, False, Me.O.0_0O___Oo. + progressBar.Name, False)
				IL_1155:
				num2 = 197
				Dim ribbonEventArgs18 As RibbonEventArgs = New RibbonEventArgs(progressBar)
				IL_1164:
				num2 = 198
				Dim a_38 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_1182:
				num2 = 199
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_38, New Object() { ribbonEventArgs18 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_11AD:
				num2 = 201
				If Not(TypeOf component Is RibbonFontComboBox) Then
					GoTo IL_128B
				End If
				IL_11BF:
				num2 = 202
				Dim fontComboBox As FontComboBox = New FontComboBox(CType(component, RibbonFontComboBox))
				IL_11D3:
				num2 = 203
				Dim ribbonFontComboBoxEventArgs As RibbonFontComboBoxEventArgs = New RibbonFontComboBoxEventArgs(fontComboBox)
				IL_11E2:
				num2 = 204
				Dim a_39 As String = text + Conversions.ToString(fontComboBox.o_.o0_o..Tag)
				IL_1201:
				num2 = 205
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_39, New Object() { ribbonFontComboBoxEventArgs }, False, Me.O.0_0O___Oo. + fontComboBox.Name, False)
				IL_1233:
				num2 = 206
				Dim ribbonEventArgs19 As RibbonEventArgs = New RibbonEventArgs(fontComboBox)
				IL_1242:
				num2 = 207
				Dim a_40 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_1260:
				num2 = 208
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_40, New Object() { ribbonEventArgs19 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_128B:
				num2 = 210
				If Not(TypeOf component Is RibbonComboBox) Then
					GoTo IL_1369
				End If
				IL_129D:
				num2 = 211
				Dim comboBox As Foxtable.RibbonMenu.ComboBox = New Foxtable.RibbonMenu.ComboBox(CType(component, RibbonComboBox))
				IL_12B1:
				num2 = 212
				Dim ribbonComboBoxEventArgs As RibbonComboBoxEventArgs = New RibbonComboBoxEventArgs(comboBox)
				IL_12C0:
				num2 = 213
				Dim a_41 As String = text + Conversions.ToString(comboBox.oo0OOOO_._..Tag)
				IL_12DF:
				num2 = 214
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_41, New Object() { ribbonComboBoxEventArgs }, False, Me.O.0_0O___Oo. + comboBox.Name, False)
				IL_1311:
				num2 = 215
				Dim ribbonEventArgs20 As RibbonEventArgs = New RibbonEventArgs(comboBox)
				IL_1320:
				num2 = 216
				Dim a_42 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_133E:
				num2 = 217
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_42, New Object() { ribbonEventArgs20 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_1369:
				num2 = 219
				If Not(TypeOf component Is RibbonMenu) Then
					GoTo IL_1447
				End If
				IL_137B:
				num2 = 220
				Dim menuButton As MenuButton = New MenuButton(CType(component, RibbonMenu))
				IL_138F:
				num2 = 221
				Dim ribbonMenuButtonEventArgs As RibbonMenuButtonEventArgs = New RibbonMenuButtonEventArgs(menuButton)
				IL_139E:
				num2 = 222
				Dim a_43 As String = text + Conversions.ToString(menuButton.OOo.O_o..Tag)
				IL_13BD:
				num2 = 223
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_43, New Object() { ribbonMenuButtonEventArgs }, False, Me.O.0_0O___Oo. + menuButton.Name, False)
				IL_13EF:
				num2 = 224
				Dim ribbonEventArgs21 As RibbonEventArgs = New RibbonEventArgs(menuButton)
				IL_13FE:
				num2 = 225
				Dim a_44 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_141C:
				num2 = 226
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_44, New Object() { ribbonEventArgs21 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_1447:
				num2 = 228
				If Not(TypeOf component Is RibbonToolBar) Then
					GoTo IL_1525
				End If
				IL_1459:
				num2 = 229
				Dim toolBar As Foxtable.RibbonMenu.ToolBar = New Foxtable.RibbonMenu.ToolBar(CType(component, RibbonToolBar))
				IL_146D:
				num2 = 230
				Dim ribbonToolBarEventArgs As RibbonToolBarEventArgs = New RibbonToolBarEventArgs(toolBar)
				IL_147C:
				num2 = 231
				Dim a_45 As String = text + Conversions.ToString(toolBar.o__Oo__.O__..Tag)
				IL_149B:
				num2 = 232
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_45, New Object() { ribbonToolBarEventArgs }, False, Me.O.0_0O___Oo. + toolBar.Name, False)
				IL_14CD:
				num2 = 233
				Dim ribbonEventArgs22 As RibbonEventArgs = New RibbonEventArgs(toolBar)
				IL_14DC:
				num2 = 234
				Dim a_46 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_14FA:
				num2 = 235
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_46, New Object() { ribbonEventArgs22 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_1525:
				num2 = 237
				If Not(TypeOf component Is RibbonToggleGroup) Then
					GoTo IL_1603
				End If
				IL_1537:
				num2 = 238
				Dim toggleGroup As ToggleGroup = New ToggleGroup(CType(component, RibbonToggleGroup))
				IL_154B:
				num2 = 239
				Dim ribbonToggleGroupEventArgs As RibbonToggleGroupEventArgs = New RibbonToggleGroupEventArgs(toggleGroup)
				IL_155A:
				num2 = 240
				Dim a_47 As String = text + Conversions.ToString(toggleGroup.o__Oo__.O__..Tag)
				IL_1579:
				num2 = 241
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_47, New Object() { ribbonToggleGroupEventArgs }, False, Me.O.0_0O___Oo. + toggleGroup.Name, False)
				IL_15AB:
				num2 = 242
				Dim ribbonEventArgs23 As RibbonEventArgs = New RibbonEventArgs(toggleGroup)
				IL_15BA:
				num2 = 243
				Dim a_48 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_15D8:
				num2 = 244
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_48, New Object() { ribbonEventArgs23 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_1603:
				num2 = 246
				If Not(TypeOf component Is RibbonGroup) Then
					GoTo IL_16E1
				End If
				IL_1615:
				num2 = 247
				Dim group As Group = New Group(CType(component, RibbonGroup))
				IL_1629:
				num2 = 248
				Dim ribbonGroupEventArgs As RibbonGroupEventArgs = New RibbonGroupEventArgs(group)
				IL_1638:
				num2 = 249
				Dim a_49 As String = text + Conversions.ToString(group.OO0oOo.O_o0..Tag)
				IL_1657:
				num2 = 250
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_49, New Object() { ribbonGroupEventArgs }, False, Me.O.0_0O___Oo. + group.Name, False)
				IL_1689:
				num2 = 251
				Dim ribbonEventArgs24 As RibbonEventArgs = New RibbonEventArgs(group)
				IL_1698:
				num2 = 252
				Dim a_50 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_16B6:
				num2 = 253
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_50, New Object() { ribbonEventArgs24 }, False, Me.o._oOO0., False)
				GoTo IL_17BA
				IL_16E1:
				num2 = 255
				If Not(TypeOf component Is RibbonTab) Then
					GoTo IL_17BA
				End If
				IL_16F3:
				num2 = 256
				Dim tab As Tab = New Tab(CType(component, RibbonTab))
				IL_1707:
				num2 = 257
				Dim ribbonTabEventArgs As RibbonTabEventArgs = New RibbonTabEventArgs(tab)
				IL_1716:
				num2 = 258
				Dim a_51 As String = text + Conversions.ToString(tab.OO0.0OOo__..Tag)
				IL_1735:
				num2 = 259
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_51, New Object() { ribbonTabEventArgs }, False, Me.O.0_0O___Oo. + tab.Name, False)
				IL_1767:
				num2 = 260
				Dim ribbonEventArgs25 As RibbonEventArgs = New RibbonEventArgs(tab)
				IL_1776:
				num2 = 261
				Dim a_52 As String = text + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_1794:
				num2 = 262
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_52, New Object() { ribbonEventArgs25 }, False, Me.o._oOO0., False)
				IL_17BA:
				num2 = 263
				Dim eventType As RibbonEventType = A_1.EventType
				If eventType <= 10 Then
					If eventType > 1 AndAlso eventType <> 10 Then
						GoTo IL_180D
					End If
				ElseIf eventType <> 17 AndAlso eventType - 20 > 1 Then
					GoTo IL_180D
				End If
				IL_17E9:
				num2 = 265
				If Not(TypeOf component Is RibbonCheckBox) AndAlso A_1.EventType <> 1 Then
					GoTo IL_180D
				End If
				IL_1801:
				num2 = 266
				Me.O0__O.OOOO.()
				IL_180D:
				num2 = 268
				If A_1.EventType <> 1 Then
					GoTo IL_1829
				End If
				IL_181C:
				num2 = 269
				Me.oO__._ooo__. = False
				IL_1829:
				GoTo IL_1CB3
				IL_182E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1C74:
				GoTo IL_1CA8
				IL_1C76:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1C86:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1C76
			End Try
			IL_1CA8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1CB3:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600350B RID: 13579 RVA: 0x00164C2C File Offset: 0x00162E2C
		Friend Sub <<EMPTY_NAME>>()
			If Me.oOO0.OOoo0oO. IsNot Nothing AndAlso Me.oOO0.OOoo0oO..FindForm() IsNot Nothing AndAlso TypeOf Me.oOO0.OOoo0oO. Is O000O Then
				If Me.oOO0.OOoo0oO..DataBindings.Count > 0 Then
					If TypeOf Me.oOO0.OOoo0oO. Is C1TextBox Then
						CType(Me.oOO0.OOoo0oO., C1TextBox).UpdateValueWithCurrentText()
					End If
					Me.oOO0.OOoo0oO..DataBindings(0).WriteValue()
					Me.oOO0.OOoo0oO..DataBindings(0).BindingManagerBase.EndCurrentEdit()
				End If
				CType(Me.oOO0.OOoo0oO., O000O).SetReadOnlyProperty()
			End If
		End Sub

		' Token: 0x0600350C RID: 13580 RVA: 0x00164CD0 File Offset: 0x00162ED0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.o._0_o. OrElse Not OO_00oOO.SystemReady Then
					GoTo IL_39
				End If
				IL_18:
				num2 = 3
				Me.o._0_o. = True
				IL_21:
				num2 = 4
				Me.Oo__.ooOo00_Oo.()
				IL_29:
				num2 = 5
				o0___oO.o0O0o0_o0._0_o.()
				IL_30:
				num2 = 6
				Me.o._0_o. = False
				IL_39:
				num2 = 7
				If Me.a Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.a, New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(Me.a, flag)
					If Me.a.State = 0S Then
						Me.a.State = 2S
						Me.c = 0
					ElseIf Me.a.State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.a.State = 1S
					If flag Then
						Monitor.[Exit](Me.a)
					End If
				End Try
				IL_B7:
				num2 = 8
				If Me.oo_o0_._o. <> 0 OrElse (DateTime.Now - Me.oOO0.OOoo0oO.).TotalSeconds <= 1.0 OrElse Not OO_00oOO.SystemReady Then
					GoTo IL_15E
				End If
				IL_EF:
				num2 = 9
				Me.oo_o0_._o. = Conversions.ToInteger(OO_00oOO.Registry.GetValue("HKEY_CURRENT_USER\Software\Foxtable", "FirstTime", 0))
				IL_117:
				num2 = 10
				If Me.oo_o0_._o. <> 0 Then
					GoTo IL_15E
				End If
				IL_122:
				num2 = 11
				Me.oo_o0_._o. = 1
				IL_12C:
				num2 = 12
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) <> 0 Then
					GoTo IL_15E
				End If
				IL_141:
				num2 = 13
				OO_00oOO.Registry.SetValue("HKEY_CURRENT_USER\Software\Foxtable", "FirstTime", 1)
				IL_15E:
				num2 = 14
				If Not Me.oo.0o0. OrElse Not OO_00oOO.SystemReady Then
					GoTo IL_192
				End If
				IL_170:
				num2 = 15
				Me.oo.0o0. = False
				IL_17A:
				num2 = 16
				If Not OO_00oOO.TableCaptionVisible Then
					GoTo IL_192
				End If
				IL_184:
				num2 = 17
				Me.OO_O_0Oo.___o.().ScrollToSelectedTab()
				IL_192:
				num2 = 18
				If MyBase.ActiveControl Is Me.O.OOO0_OOo.() OrElse MyBase.ActiveControl Is Nothing Then
					GoTo IL_288
				End If
				IL_1B1:
				num2 = 19
				If MyBase.ActiveControl.CanFocus Then
					GoTo IL_264
				End If
				IL_1C4:
				num2 = 20
				If OO_00oOO.CurrentTable Is Nothing OrElse Not OO_00oOO.CurrentTable.foxGrid.CanFocus OrElse Not Main.OO_O.o..Visible Then
					GoTo IL_215
				End If
				IL_1EB:
				num2 = 21
				If OO_00oOO.CurrentTable.foxGrid.FindForm() IsNot Me Then
					GoTo IL_264
				End If
				IL_200:
				num2 = 22
				OO_00oOO.CurrentTable.foxGrid.Focus()
				GoTo IL_264
				IL_215:
				num2 = 24
				If OO_00oOO.MainTable Is Nothing OrElse Not OO_00oOO.MainTable.foxGrid.CanFocus OrElse Not Main.OO_O.o..Visible Then
					GoTo IL_264
				End If
				IL_23C:
				num2 = 25
				If OO_00oOO.CurrentTable.foxGrid.FindForm() IsNot Me Then
					GoTo IL_264
				End If
				IL_251:
				num2 = 26
				OO_00oOO.MainTable.foxGrid.Focus()
				IL_264:
				num2 = 27
				If Not MyBase.ActiveControl.CanFocus Then
					GoTo IL_288
				End If
				IL_274:
				num2 = 28
				Me.oOO0.OOoo0oO. = ooO.o.O_0000_O.(MyBase.Controls)
				IL_288:
				num2 = 29
				If OO_00oOO.DataTables Is Nothing Then
					GoTo IL_32D
				End If
				IL_295:
				num2 = 30
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_2AF:
					num2 = 31
					If dataTable.O.0_0O. Then
						IL_2BB:
						num2 = 32
						If OO_00oOO.SystemReady AndAlso Not O_O0OO.O_O00OOooo.O_. Then
							IL_2CC:
							num2 = 33
							dataTable.O.0_0O. = False
							IL_2D7:
							num2 = 34
							dataTable.OO_.0_O0o.()
						End If
					End If
					IL_2E1:
					num2 = 35
					If dataTable.o0_OO.o00OO. Then
						IL_2ED:
						num2 = 36
						If OO_00oOO.SystemReady AndAlso Not O_O0OO.O_O00OOooo.O_. Then
							IL_2FE:
							num2 = 37
							dataTable.o0_OO.o00OO. = False
							IL_309:
							num2 = 38
							dataTable.O0.OoO0o_o0o_O.()
						End If
					End If
					IL_313:
					num2 = 39
				End While
				IL_31F:
				num2 = 40
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_32D:
				num2 = 41
				If OO_00oOO.MainTable Is Nothing OrElse OO_00oOO.CurrentTable Is Nothing Then
					GoTo IL_9C0
				End If
				IL_344:
				num2 = 42
				If Not Me.O.ooO0. OrElse Me.a Mod 3 <> 0 Then
					GoTo IL_3E9
				End If
				IL_35F:
				num2 = 43
				Me.O.ooO0. = False
				IL_369:
				num2 = 44
				Dim enumerator2 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator2.MoveNext()
					Dim form As Foxtable.WinForm.Form = enumerator2.Current
					IL_383:
					num2 = 45
					If form.Opened Then
						IL_38F:
						num2 = 46
						Dim enumerator3 As IEnumerator(Of Foxtable.WinForm.Control) = form.Controls.GetEnumerator()
						While enumerator3.MoveNext()
							Dim control As Foxtable.WinForm.Control = enumerator3.Current
							IL_3AB:
							num2 = 47
							control.RefrshReadonly()
							IL_3B5:
							num2 = 48
						End While
						IL_3C1:
						num2 = 49
						If enumerator3 IsNot Nothing Then
							enumerator3.Dispose()
						End If
					End If
					IL_3CF:
					num2 = 50
				End While
				IL_3DB:
				num2 = 51
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_3E9:
				num2 = 52
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.MainTable.foxGrid
				IL_3F8:
				num2 = 53
				If o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed OrElse o_oOooO_O.Rows.Count <= o_oOooO_O.Rows.Fixed Then
					GoTo IL_440
				End If
				IL_42A:
				num2 = 54
				o_oOooO_O.Row = o_oOooO_O.Rows.Fixed
				IL_440:
				o_oOooO_O = Nothing
				IL_443:
				num2 = 56
				If OO_00oOO.MainTable Is OO_00oOO.CurrentTable Then
					GoTo IL_4AF
				End If
				IL_452:
				num2 = 57
				Dim o_oOooO_O2 As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				IL_461:
				num2 = 58
				If Not(o_oOooO_O2.Row < o_oOooO_O2.Rows.Fixed And o_oOooO_O2.Rows.Count > o_oOooO_O2.Rows.Fixed) Then
					GoTo IL_4AC
				End If
				IL_496:
				num2 = 59
				o_oOooO_O2.Row = o_oOooO_O2.Rows.Fixed
				IL_4AC:
				o_oOooO_O2 = Nothing
				IL_4AF:
				num2 = 61
				Me.a += 1
				IL_4C0:
				num2 = 62
				If Me.a <> 1 Then
					GoTo IL_538
				End If
				IL_4CC:
				num2 = 63
				If Not O_O0OO.OOo_o.0o. Then
					GoTo IL_9C0
				End If
				IL_4D9:
				num2 = 64
				Dim a_ As String = "SystemIdle_" + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				IL_4F8:
				num2 = 65
				If O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, Nothing, False, "", False) Then
					GoTo IL_9C0
				End If
				IL_514:
				num2 = 66
				O_O0OO.OOo_o.0o. = False
				IL_51D:
				num2 = 67
				MessageBox.Show("菜单的SystemIdle事件执行过程中发生错误，将暂停执行该事件，请及时修改事件代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				GoTo IL_9C0
				IL_538:
				num2 = 69
				If Me.a <> 2 Then
					GoTo IL_574
				End If
				IL_544:
				num2 = 70
				If Not Me.o_o0.o_. Then
					GoTo IL_9C0
				End If
				IL_552:
				num2 = 71
				Me.o_o0.o_. = False
				IL_55C:
				num2 = 72
				OO_00oOO.Functions.O__00.__0_O.(False, "")
				GoTo IL_9C0
				IL_574:
				num2 = 74
				If Me.a <> 3 Then
					GoTo IL_6AF
				End If
				IL_583:
				num2 = 75
				Dim enumerator4 As IEnumerator(Of Foxtable.Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator4.MoveNext()
					Dim table As Foxtable.Table = enumerator4.Current
					IL_5A0:
					num2 = 76
					If table.TableType Is Nothing AndAlso Not table.IsRelation AndAlso table.foxGrid.FindForm() Is Nothing Then
						IL_5CC:
						num2 = 78
						If Me.OO_O_0Oo.___o.().TabPages(table.Name) IsNot Nothing Then
							IL_5EB:
							num2 = 79
							Dim num3 As Integer = 0
							IL_5F1:
							num2 = 80
							Dim enumerator5 As IEnumerator = CType(Me.OO_O_0Oo.___o.().TabPages(table.Name), Oo0__Oo).O_000__.o.().TabPages(0).Controls.GetEnumerator()
							While enumerator5.MoveNext()
								Dim obj As Object = enumerator5.Current
								Dim control2 As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
								IL_63C:
								num2 = 81
								If TypeOf control2 Is FormPanel Then
									IL_648:
									num2 = 82
									num3 = 1
									Exit While
								End If
								IL_650:
								num2 = 84
							End While
							IL_65C:
							num2 = 85
							If TypeOf enumerator5 Is IDisposable Then
								TryCast(enumerator5, IDisposable).Dispose()
							End If
							IL_674:
							num2 = 86
							If num3 = 0 Then
								IL_67B:
								num2 = 87
								oOO0oo_o0.o.O0o000_.(table.foxGrid)
							End If
						End If
					End If
					IL_68A:
					num2 = 88
				End While
				IL_699:
				num2 = 89
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
					GoTo IL_9C0
				End If
				GoTo IL_9C0
				IL_6AF:
				num2 = 91
				If Me.a <> 4 Then
					GoTo IL_7B0
				End If
				IL_6BE:
				num2 = 92
				If Not Me.oO__O_oo_0O0.o. Then
					GoTo IL_71E
				End If
				IL_6C9:
				num2 = 93
				Me.oO__O_oo_0O0.o. = False
				IL_6D3:
				num2 = 94
				Dim path As String = OO_00oOO.ProjectPath + "Bin\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Project.dll"
				IL_6F6:
				num2 = 95
				Dim rawAssembly As Byte() = File.ReadAllBytes(path)
				IL_702:
				num2 = 96
				O_O0OO.oo0_o_.o. = Assembly.Load(rawAssembly)
				IL_711:
				num2 = 97
				O_O0OO.O0_00o.o0__o..O_o0__O.o.()
				IL_71E:
				num2 = 98
				If Not OO_00oOO.Forms.OoO___.0_o. Then
					GoTo IL_9C0
				End If
				IL_730:
				num2 = 99
				OO_00oOO.Forms.OoO___.0_o. = False
				IL_73E:
				num2 = 100
				Dim enumerator6 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator6.MoveNext()
					Dim form2 As Foxtable.WinForm.Form = enumerator6.Current
					IL_758:
					num2 = 101
					If form2.Opened Then
						IL_764:
						num2 = 102
						Dim oo_ As oo_ = New oo_()
						IL_76E:
						num2 = 103
						form2.Panel.Controls.Add(oo_)
						IL_784:
						num2 = 104
						oo_.BringToFront()
					End If
					IL_78E:
					num2 = 105
				End While
				IL_79A:
				num2 = 106
				If enumerator6 IsNot Nothing Then
					enumerator6.Dispose()
					GoTo IL_9C0
				End If
				GoTo IL_9C0
				IL_7B0:
				num2 = 108
				If Me.a <> 5 Then
					GoTo IL_81F
				End If
				IL_7BC:
				num2 = 109
				If Not O_O0OO.O_OO.OO. Then
					GoTo IL_9C0
				End If
				IL_7C9:
				num2 = 110
				If O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SystemIdle", Nothing, False, "", False) Then
					GoTo IL_804
				End If
				IL_7E5:
				num2 = 111
				O_O0OO.O_OO.OO. = False
				IL_7EE:
				num2 = 112
				MessageBox.Show("项目的SystemIdle事件执行过程中发生错误，将暂停执行该事件，请及时修改事件代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				IL_804:
				num2 = 113
				If DataTableProperty.Connected Then
					GoTo IL_9C0
				End If
				IL_811:
				num2 = 114
				O_O0OO.oo0_o_.o. = Nothing
				GoTo IL_B21
				IL_81F:
				num2 = 117
				If Me.a <> 6 Then
					GoTo IL_87E
				End If
				IL_82B:
				num2 = 118
				Dim enumerator7 As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator7.MoveNext()
					Dim dataTable2 As DataTable = enumerator7.Current
					IL_845:
					num2 = 119
					If dataTable2.oOOO.0. Then
						IL_851:
						num2 = 120
						dataTable2.o0.0_0OO0o_0o.(False)
					End If
					IL_85C:
					num2 = 121
				End While
				IL_868:
				num2 = 122
				If enumerator7 IsNot Nothing Then
					enumerator7.Dispose()
					GoTo IL_9C0
				End If
				GoTo IL_9C0
				IL_87E:
				num2 = 124
				If Me.a <> 7 Then
					GoTo IL_9C0
				End If
				IL_88D:
				num2 = 125
				Me.b += 1
				IL_89E:
				num2 = 126
				If Me.b <> 500 Then
					GoTo IL_96D
				End If
				IL_8B1:
				num2 = 127
				Me.b = 0
				IL_8BB:
				num2 = 128
				If O_O0OO.a() Then
					GoTo IL_96D
				End If
				IL_8CB:
				num2 = 129
				Dim enumerator8 As IEnumerator(Of Foxtable.WinForm.Form) = OO_00oOO.Forms.GetEnumerator()
				While enumerator8.MoveNext()
					Dim form3 As Foxtable.WinForm.Form = enumerator8.Current
					IL_8E8:
					num2 = 130
					If form3.Opened Then
						IL_8F7:
						num2 = 131
						Dim enumerator9 As IEnumerator(Of Foxtable.WinForm.Control) = form3.Controls.GetEnumerator()
						While enumerator9.MoveNext()
							Dim control3 As Foxtable.WinForm.Control = enumerator9.Current
							IL_916:
							num2 = 132
							control3.BaseControl.Tag = "Idle"
							IL_92D:
							num2 = 133
						End While
						IL_93C:
						num2 = 134
						If enumerator9 IsNot Nothing Then
							enumerator9.Dispose()
						End If
					End If
					IL_94D:
					num2 = 135
				End While
				IL_95C:
				num2 = 136
				If enumerator8 IsNot Nothing Then
					enumerator8.Dispose()
				End If
				IL_96D:
				num2 = 137
				Me.a = 0
				IL_97A:
				num2 = 138
				If(DateTime.Now - Me.o_O_0Oo0.0O0O.).TotalMinutes <= 5.0 Then
					GoTo IL_9C0
				End If
				IL_9A4:
				num2 = 139
				Me.o_O_0Oo0.0O0O. = DateTime.Now
				IL_9B5:
				num2 = 140
				O_O0OO.o00.0.()
				IL_9C0:
				num2 = 141
				If Me.c < 0 Then
					GoTo IL_A13
				End If
				IL_9CF:
				num2 = 142
				Me.c += 1
				IL_9E3:
				num2 = 143
				If Me.c <> 1000 Then
					GoTo IL_A13
				End If
				IL_9F6:
				num2 = 144
				Me.c = -1
				IL_A03:
				num2 = 145
				O_O0OO.O0_00o.o0__o..O__O0OO_0._O.()
				IL_A13:
				num2 = 146
				If Not(TypeOf MyBase.ActiveControl Is C1DockingTabPage) Then
					GoTo IL_A97
				End If
				IL_A26:
				num2 = 147
				Dim c1DockingTabPage As C1DockingTabPage = CType(MyBase.ActiveControl, C1DockingTabPage)
				IL_A39:
				num2 = 148
				If c1DockingTabPage.Controls.Count <= 0 OrElse Not c1DockingTabPage.Controls(0).CanFocus Then
					GoTo IL_A94
				End If
				IL_A62:
				num2 = 149
				If TypeOf c1DockingTabPage.Controls(0)Is o_O0_0O0 Then
					GoTo IL_A94
				End If
				IL_A7C:
				num2 = 150
				c1DockingTabPage.Controls(0).[Select]()
				IL_A94:
				c1DockingTabPage = Nothing
				IL_A97:
				num2 = 152
				If Not(TypeOf MyBase.ActiveControl Is C1DockingTab) Then
					GoTo IL_AFB
				End If
				IL_AAA:
				num2 = 153
				Dim c1DockingTab As C1DockingTab = CType(MyBase.ActiveControl, C1DockingTab)
				IL_ABD:
				num2 = 154
				If c1DockingTab.SelectedTab Is Nothing Then
					GoTo IL_AF8
				End If
				IL_ACC:
				num2 = 155
				If c1DockingTab.SelectedTab.Controls.Count <= 0 Then
					GoTo IL_AF8
				End If
				IL_AE6:
				num2 = 156
				c1DockingTab.SelectedTab.[Select]()
				IL_AF8:
				c1DockingTab = Nothing
				IL_AFB:
				num2 = 158
				If System.Windows.Forms.Control.ModifierKeys <> Keys.None Then
					GoTo IL_B21
				End If
				IL_B08:
				num2 = 159
				If Not O_O0OO.O0OO_.0. Then
					GoTo IL_B21
				End If
				IL_B15:
				num2 = 160
				O_O0OO.O0OO_.0. = False
				IL_B21:
				GoTo IL_DF7
				IL_B26:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_DB8:
				GoTo IL_DEC
				IL_DBA:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_DCA:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_DBA
			End Try
			IL_DEC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_DF7:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600350D RID: 13581 RVA: 0x00165B10 File Offset: 0x00163D10
		Private Sub <<EMPTY_NAME>>()
			If OO_00oOO.MainTable IsNot Nothing Then
				Dim a_ As String = "MainTableChanged_" + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, Nothing, False, Me.o._oOO0., False)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "MainTableChanged", Nothing, False, "项目", False)
			End If
		End Sub

		' Token: 0x0600350E RID: 13582 RVA: 0x00165B6C File Offset: 0x00163D6C
		Private Sub <<EMPTY_NAME>>()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim a_ As String = "CurrentTableChanged_" + Conversions.ToString(Me.O.OOO0_OOo.().Tag)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, Nothing, False, Me.o._oOO0., False)
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "CurrentTableChanged", Nothing, False, "项目", False)
			End If
		End Sub

		' Token: 0x0600350F RID: 13583 RVA: 0x00165BC8 File Offset: 0x00163DC8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As C1TopicBarClickEventArgs)
			If A_1.Link.Tag IsNot Nothing Then
				Dim left As String = A_1.Link.Tag.ToString()
				If Operators.CompareString(left, "Home", True) = 0 Then
					New Process() With { .File = "http://www.foxtable.com" }.Start()
					Return
				End If
				If Operators.CompareString(left, "BBS", True) = 0 Then
					New Process() With { .File = "http://www.foxtable.com/bbs/" }.Start()
					Return
				End If
				If Operators.CompareString(left, "Feedback", True) = 0 Then
					Process.Start("mailto:foxtable@qq.com")
					Return
				End If
				If Operators.CompareString(left, "Order", True) = 0 Then
					New Process() With { .File = "http://www.foxtable.com/contact.html" }.Start()
					Return
				End If
				If Operators.CompareString(left, "New", True) = 0 Then
					Project.Create()
					Return
				End If
				If Operators.CompareString(left, "Open", True) = 0 Then
					Project.Open()
					Return
				End If
				If Operators.CompareString(left, "Help", True) = 0 Then
					OO_00oOO.ShowHelpWindow()
					Return
				End If
				If Operators.CompareString(left, "RecenFile", True) = 0 Then
					If OO_00oOO.FileSys.FileExists(A_1.Link.ToolTipText) Then
						A_1.Link.TopicBar.Enabled = False
						Project.Open(A_1.Link.ToolTipText, New String(-1) {})
						Return
					End If
					MessageBox.Show("文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				ElseIf Operators.CompareString(left, "Demo", True) = 0 Then
					Dim text As String = O_O0OO.o.00O_O.() + "CaseStudy\基本功能演示" + ooO0__OO.oo.Ooo_00.()
					If OO_00oOO.FileSys.FileExists(text) Then
						A_1.Link.TopicBar.Enabled = False
						Project.Open(text, New String(-1) {})
						Return
					End If
				ElseIf Operators.CompareString(left, "presentation", True) = 0 Then
					Dim text2 As String = O_O0OO.o.00O_O.() + "CaseStudy\基本功能介绍" + ooO0__OO.oo.Ooo_00.()
					If OO_00oOO.FileSys.FileExists(text2) Then
						A_1.Link.TopicBar.Enabled = False
						Project.Open(text2, New String(-1) {})
					End If
				End If
			End If
		End Sub

		' Token: 0x06003510 RID: 13584 RVA: 0x00165DB8 File Offset: 0x00163FB8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TabPageEventArgs)
			Try
				A_1.TabPage.Controls.Clear()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06003511 RID: 13585 RVA: 0x00165DF8 File Offset: 0x00163FF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TabPageCancelEventArgs)
			Dim tabPage As C1DockingTabPage = A_1.TabPage
			If tabPage IsNot Nothing Then
				Dim control As System.Windows.Forms.Control = ooO.o.O_0000_O.(tabPage.Controls)
				If control IsNot Nothing AndAlso control.DataBindings.Count > 0 Then
					control.DataBindings(0).WriteValue()
				End If
			End If
			If tabPage.Controls.Count = 1 Then
				Dim control2 As System.Windows.Forms.Control = tabPage.Controls(0)
				If TypeOf control2 Is FormPanel Then
					Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(control2.Name)
					Dim formEventArgs As FormEventArgs = New FormEventArgs(OO_00oOO.Forms(control2.Name))
					Dim a_ As String = "BeforeClose_" + Conversions.ToString(form.O_o_.0o0__o0O.("Key"))
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(control2.Name).O_0.O00o_00_O., a_, New Object() { formEventArgs }, False, form.Name, False)
					If form.O_0.O00o_00_O. Then
						A_1.Cancel = formEventArgs.Cancel
					End If
					If Not A_1.Cancel Then
						form.oOO0OO0O.o0oO.()
						form.OoOO_._0.()
					End If
				End If
			End If
		End Sub

		' Token: 0x06003512 RID: 13586 RVA: 0x00165F0C File Offset: 0x0016410C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Not OO_00oOO.SystemReady Then
					GoTo IL_AE
				End If
				IL_0C:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_13:
				num = 4
				If Me.d = 1 Then
					GoTo IL_9D
				End If
				IL_1E:
				num = 6
				If Me.d <> 2 Then
					GoTo IL_82
				End If
				IL_29:
				num = 7
				Dim num3 As Integer = Foxtable.My.b.O0o0oO00_.O.().Count
				IL_36:
				num = 8
				num3 = 92
				IL_3B:
				num = 9
				If num3 <= 60 Then
					GoTo IL_4C
				End If
				IL_43:
				num = 10
				O_O0OO.O_O.OOO_o.(True)
				IL_4C:
				num = 11
				If Not(num3 >= 90 And Not Me.Oo.oOo_o0Oo0.()) Then
					GoTo IL_9D
				End If
				IL_63:
				num = 12
				If O_O0OO.O_oO_o0O.o__. Then
					GoTo IL_9D
				End If
				IL_6D:
				num = 13
				Main.OO_O.o..O.OOO0_OOo.().Enabled = False
				GoTo IL_9D
				IL_82:
				num = 15
				If Me.d <> 4 Then
					GoTo IL_9D
				End If
				IL_8E:
				num = 16
				Me.O0o__0_OO.o.().Enabled = False
				IL_9D:
				num = 17
				Me.d += 1
				IL_AE:
				GoTo IL_148
				IL_B3:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_109:
				GoTo IL_13D
				IL_10B:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_11B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10B
			End Try
			IL_13D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_148:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003513 RID: 13587 RVA: 0x00166088 File Offset: 0x00164288
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not SystemInformation.TerminalServerSession Then
					GoTo IL_22
				End If
				IL_10:
				num2 = 3
				Me.o0O.OO. = True
				IL_19:
				num2 = 4
				result = True
				GoTo IL_12D
				IL_22:
				num2 = 5
				Dim text As String = o_o_O0OO_0__.O0_O_o.o_.()
				IL_2B:
				num2 = 6
				Me.o0O.OO. = True
				IL_34:
				num2 = 7
				If Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_4E
				End If
				IL_45:
				num2 = 8
				result = False
				GoTo IL_12D
				IL_4E:
				num2 = 9
				Dim text2 As String = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(4, 4)
				IL_5F:
				num2 = 10
				Dim s As String = text.Substring(4, 4)
				IL_6D:
				num2 = 11
				Dim text3 As String = ""
				IL_77:
				num2 = 12
				text2 = Foxtable.WinForm.Form.O_.O__Oo.("EUNumber(" + text2 + ")").ToString()
				IL_97:
				num2 = 13
				text2 = O00.EncryptText(text2, "fox", "table")
				IL_AD:
				num2 = 14
				text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text2)
				IL_BE:
				num2 = 15
				text2 = o_o_O0OO_0__.o000oOoo.0.(text2)
				IL_CA:
				num2 = 16
				Dim num3 As Integer = 0
				Do
					IL_D0:
					num2 = 17
					text3 += Conversions.ToString(CInt(((text2(num3) + ChrW(1)) Mod vbTab + ChrW(1))))
					IL_F1:
					num2 = 18
					num3 += 1
				Loop While num3 <= 3
				IL_FF:
				num2 = 19
				Dim num4 As Integer
				Integer.TryParse(text3, num4)
				IL_10C:
				num2 = 20
				Dim num5 As Integer
				Integer.TryParse(s, num5)
				IL_119:
				num2 = 21
				Me.o0O.OO. = True
				IL_123:
				num2 = 22
				result = (num4 = num5)
				IL_12D:
				GoTo IL_1DB
				IL_132:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_19C:
				GoTo IL_1D0
				IL_19E:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1AE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_19E
			End Try
			IL_1D0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1DB:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003514 RID: 13588 RVA: 0x00166298 File Offset: 0x00164498
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TabPageCancelEventArgs)
			A_1.Cancel = True
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCloseTable", Nothing, False, "项目", False)
		End Sub

		' Token: 0x06003515 RID: 13589 RVA: 0x001662BC File Offset: 0x001644BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.Tables IsNot Nothing Then
				Try
					For Each table As Foxtable.Table In OO_00oOO.Tables
						If table.Grid.FindForm() IsNot Nothing AndAlso table.Grid.RowSel >= table.Grid.Rows.Fixed AndAlso (table.Grid.RowSel < table.Grid.TopRow OrElse table.Grid.RowSel > table.Grid.BottomRow) Then
							table.Grid.TopRow = table.Grid.RowSel
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Foxtable.Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06003516 RID: 13590 RVA: 0x0016637C File Offset: 0x0016457C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.o._0_o. AndAlso OO_00oOO.SystemReady Then
				Me.o._0_o. = True
				Me.o00o_OO_o_._o.().Enabled = False
				Me.Oo__.ooOo00_Oo.()
				o0___oO.o0O0o0_o0._0_o.()
				Me.o._0_o. = False
				Me.o00o_OO_o_._o.().Enabled = True
			End If
		End Sub

		' Token: 0x06003517 RID: 13591 RVA: 0x001663CC File Offset: 0x001645CC
		Private Sub <<EMPTY_NAME>>()
			Dim requestEventArgs As RequestEventArgs = Nothing
			Dim num As Integer = 0
			Dim o0oo.Oo. As Object = OO_00oOO.HttpServer.o0oo.Oo.
			SyncLock o0oo.Oo.
				While OO_00oOO.HttpServer.o0oo.Oo..Count > 0 AndAlso OO_00oOO.HttpServer.o.oOOoOOO..Count < 10
					requestEventArgs = OO_00oOO.HttpServer.o0oo.Oo..Dequeue()
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeHttpRequest", New Object() { requestEventArgs }, True, "项目", False)
					If requestEventArgs.Cancel OrElse requestEventArgs.oo0o.oo_oOoOo0. Then
						OO_00oOO.HttpServer.oo._o_oo_..Enqueue(requestEventArgs)
						num += 1
						If num >= 5 Then
							Exit While
						End If
					Else
						OO_00oOO.HttpServer.o.oOOoOOO..Add(requestEventArgs)
						AddressOf requestEventArgs.Ooo_oO0.O0..Start()
					End If
				End While
				requestEventArgs = Nothing
				If OO_00oOO.HttpServer.oo._o_oo_..Count > 0 Then
					requestEventArgs = OO_00oOO.HttpServer.oo._o_oo_..Dequeue()
				End If
			End SyncLock
			If Me.o_0.0oo00O0__. = 0 Then
				If o0OO__.OO0oO.o.() Then
					Me.o_0.0oo00O0__. = 1
				Else
					Me.o_0.0oo00O0__. = 2
				End If
			End If
			If requestEventArgs Is Nothing Then
				If O_O0OO.OoO__.0oO0oo.().Count > 0 AndAlso Me.o_0.0oo00O0__. = 2 Then
					O_O0OO.OoO__.0oO0oo.().Clear()
					Return
				End If
			Else
				If Me.o_0.0oo00O0__. = 1 AndAlso Not requestEventArgs.Cancel AndAlso Not requestEventArgs.oo0o.oo_oOoOo0. Then
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "HttpRequest", New Object() { requestEventArgs }, True, "项目", False)
				End If
				If Not requestEventArgs.AsyncExecute Then
					requestEventArgs.o0__O0.o_0..Clear()
					requestEventArgs.oo_OO_0._O0O..Clear()
					Try
						For Each text As String In requestEventArgs.oo_OO_0._O0O..Keys
						Next
					Finally
						Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					requestEventArgs.oo_OO_0._O0O..Clear()
					Try
						requestEventArgs.Request.InputStream.Close()
						If Not requestEventArgs.oo0o.oo_oOoOo0. Then
							If Not requestEventArgs.o._oOOO00_o_0O. Then
								requestEventArgs.StatusCode = 404
								requestEventArgs.StatusDescription = "foxtable web server has started(error 404)"
								New oOo0_o0Oo_00("foxtable web server has started(error 404).", requestEventArgs.Response, "utf-8").Oo000.o00.(Nothing)
							Else
								requestEventArgs.Response.OutputStream.Close()
								requestEventArgs.Response.Close()
								requestEventArgs.Response.Abort()
							End If
						End If
					Catch ex As Exception
					End Try
				End If
			End If
		End Sub

		' Token: 0x06003518 RID: 13592 RVA: 0x0016666C File Offset: 0x0016486C
		Public Sub <<EMPTY_NAME>>(A_0 As String, ParamArray A_1 As Object())
			' The following expression was wrapped in a checked-statement
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed Then
				For i As Integer = 0 To A_1.Length - 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_1(i))
					If objectValue IsNot Nothing Then
						If TypeOf objectValue Is C1FlexGrid Then
							Dim c1FlexGrid As C1FlexGrid = CType(objectValue, C1FlexGrid)
							Dim font As Font = c1FlexGrid.Font
							Me.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), A_0)
							c1FlexGrid.Font = font
						ElseIf C1ThemeController.IsObjectThemeable(RuntimeHelpers.GetObjectValue(objectValue)) Then
							Me.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), A_0)
							If TypeOf objectValue Is C1DockingTab Then
								CType(objectValue, C1DockingTab).TabSizeMode = 1
							End If
						End If
					End If
				Next
			End If
		End Sub

		' Token: 0x06003519 RID: 13593 RVA: 0x0016670A File Offset: 0x0016490A
		Friend Sub <<EMPTY_NAME>>(ParamArray A_0 As Object())
			Me.Oo.oOo_o0Oo0.("(default)", A_0)
		End Sub

		' Token: 0x0600351A RID: 13594 RVA: 0x00166718 File Offset: 0x00164918
		Friend Overloads Sub <<EMPTY_NAME>>(ParamArray A_0 As Object())
			' The following expression was wrapped in a checked-statement
			If Not MyBase.Disposing AndAlso Not MyBase.IsDisposed Then
				For i As Integer = 0 To A_0.Length - 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_0(i))
					If C1ThemeController.IsObjectThemeable(RuntimeHelpers.GetObjectValue(objectValue)) AndAlso Not(TypeOf objectValue Is O00o) Then
						Me.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), Nothing)
					End If
				Next
			End If
		End Sub

		' Token: 0x0600351B RID: 13595 RVA: 0x00166775 File Offset: 0x00164975
		Friend Function <<EMPTY_NAME>>(A_0 As Object) As String
			Return Me.O.OOO0_OOo.().GetTheme(RuntimeHelpers.GetObjectValue(A_0))
		End Function

		' Token: 0x0600351C RID: 13596 RVA: 0x00166788 File Offset: 0x00164988
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.O.OOO0_OOo.().Theme
		End Function

		' Token: 0x0600351D RID: 13597 RVA: 0x00166798 File Offset: 0x00164998
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Operators.CompareString(A_0, "(default)", True) <> 0 Then
					GoTo IL_19
				End If
				IL_10:
				num = 2
				A_0 = O_O0OO.o_.oO_O0.
				IL_19:
				num = 3
				If Operators.CompareString(Me.O.OOO0_OOo.().Theme, A_0, True) = 0 Then
					GoTo IL_44
				End If
				IL_2F:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_36:
				num = 5
				Me.O.OOO0_OOo.().Theme = A_0
				IL_44:
				GoTo IL_AB
				IL_46:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_6C:
				GoTo IL_A0
				IL_6E:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_7E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6E
			End Try
			IL_A0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600351E RID: 13598 RVA: 0x00166868 File Offset: 0x00164A68
		Friend Function <<EMPTY_NAME>>() As String
			Dim o_.00. As String
			If Operators.CompareString(Me.o_oO.0., "(default)", True) = 0 Then
				o_.00. = O_O0OO.O_.00.
			Else
				o_.00. = Me.o_oO.0.
			End If
			Return o_.00.
		End Function

		' Token: 0x0600351F RID: 13599 RVA: 0x00166898 File Offset: 0x00164A98
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o_oO.0. = A_0
			If Operators.CompareString(A_0, "(default)", True) = 0 Then
				A_0 = O_O0OO.O_.00.
			End If
			If Operators.CompareString(Me.o0_o_o_0.0O.(Me.O.OOO0_OOo.()), A_0, True) <> 0 Then
				Dim themeByName As C1Theme = C1ThemeController.GetThemeByName(A_0, False)
				If Operators.CompareString(A_0, "", True) > 0 AndAlso Operators.CompareString(A_0, "Office2013Green", True) <> 0 AndAlso Not A_0.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase) Then
					themeByName.Children("C1Ribbon").Children("Groups").Children("Font").AssignFrom(Me.oO_0_.oO.)
				End If
				Dim left As String = A_0
				If Operators.CompareString(left, "Windows8Red", True) = 0 OrElse Operators.CompareString(left, "Windows8Green", True) = 0 OrElse Operators.CompareString(left, "Windows8Gray", True) = 0 OrElse Operators.CompareString(left, "Windows8Brown", True) = 0 OrElse Operators.CompareString(left, "Windows8Blue", True) = 0 OrElse Operators.CompareString(left, "Office2016White", True) = 0 OrElse Operators.CompareString(left, "Office2013Red", True) = 0 OrElse Operators.CompareString(left, "Office2013Green", True) = 0 OrElse Operators.CompareString(left, "Office2013LightGray", True) = 0 OrElse Operators.CompareString(left, "Office2013Gray", True) = 0 OrElse Operators.CompareString(left, "Office2013White", True) = 0 OrElse Operators.CompareString(left, "Office2013DarkGray", True) = 0 OrElse Operators.CompareString(left, "Office2016DarkGray", True) = 0 OrElse Operators.CompareString(left, "Office2016Colorful", True) = 0 OrElse Operators.CompareString(left, "MacBlue", True) = 0 OrElse Operators.CompareString(left, "MacSilver", True) = 0 OrElse Operators.CompareString(left, "MaterialDark", True) = 0 OrElse Operators.CompareString(left, "Office2010Barbie", True) = 0 OrElse Operators.CompareString(left, "VS2013Dark", True) = 0 OrElse Operators.CompareString(left, "Office2010Red", True) = 0 OrElse Operators.CompareString(left, "Office2010Green", True) = 0 Then
					Dim themeItem As ThemeItem = themeByName.Children("C1Ribbon").Children("AppButton").Children("Default").Children("Background")
					Dim themeItem2 As ThemeItem = themeByName.Children("C1Ribbon").Children("AppButton").Children("Default").Children("TextColor")
					Dim themeItem3 As ThemeItem = themeByName.Children("C1Command").Children("C1DockingTab").Children("Tabs").Children("Selected")
					themeItem3.Children("Background").AssignFrom(themeItem)
					themeItem3.Children("BorderColor").AssignFrom(themeItem)
					themeItem3.Children("BorderColor2").AssignFrom(themeItem)
					themeItem3.Children("ForeColor").AssignFrom(themeItem2)
					themeItem = themeByName.Children("C1Ribbon").Children("AppButton").Children("Hot").Children("Background")
					themeItem2 = themeByName.Children("C1Ribbon").Children("AppButton").Children("Hot").Children("TextColor")
					Dim themeItem4 As ThemeItem = themeByName.Children("C1Command").Children("C1DockingTab").Children("Tabs").Children("Hot")
					themeItem4.Children("Background").AssignFrom(themeItem)
					themeItem4.Children("BorderColor").AssignFrom(themeItem)
					themeItem4.Children("BorderColor2").AssignFrom(themeItem)
					themeItem4.Children("ForeColor").AssignFrom(themeItem2)
					Dim themeItem5 As ThemeItem = themeByName.Children("C1Command").Children("C1DockingTab").Children("Tabs")
					themeItem5.Children("SelectedHot").AssignFrom(themeItem5.Children("Hot"))
					themeItem5.Children("Pressed").AssignFrom(themeItem5.Children("Selected"))
				End If
				For Each control As System.Windows.Forms.Control In New System.Windows.Forms.Control() { Me, Me.O.OOO0_OOo.(), Me.O.OOO0_OOo.(), Me.OO_O_0Oo.___o.(), Me.O0o__0_OO.o.(), Me.o__0_._oOooO_o.(), Me.O0o__0_OO.o.(), Me.Oo.O000_oO__o.() }
					If control IsNot Nothing Then
						Me.o0oO_O.0Oo_00.(New Object() { control })
						themeByName.ApplyThemeToObject(control)
						If Operators.CompareString(A_0, "System", True) = 0 AndAlso TypeOf control Is C1DockingTab Then
							CType(control, C1DockingTab).BorderStyle = BorderStyle.Fixed3D
						End If
						If control Is Me.OO_O_0Oo.___o.() Then
							Try
								For Each obj As Object In Me.OO_O_0Oo.___o.().TabPages
									Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
									Me.o0oO_O.0Oo_00.(New Object() { oo0__Oo.O_000__.o.() })
									themeByName.ApplyThemeToObject(oo0__Oo.O_000__.o.())
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
					End If
				Next
				If A_0.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase) Then
					Me.OO_O_0Oo.___o.().TabAreaSpacing = 0
				Else
					Me.OO_O_0Oo.___o.().TabAreaSpacing = 2
				End If
				Me.OO_O_0Oo.___o.().TabSizeMode = 1
			End If
		End Sub

		' Token: 0x06003520 RID: 13600 RVA: 0x00166EA0 File Offset: 0x001650A0
		Public Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, Optional A_1 As String = "(default)")
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is C1FlexGrid Then
						Me.Oo.oOo_o0Oo0.(O_O0OO.O0_00o.o0__o..GridThemeName, New Object() { control })
					Else
						If TypeOf control Is PropertyGrid OrElse TypeOf control Is System.Windows.Forms.Label Then
							Continue For
						End If
						If Not(TypeOf control Is System.Windows.Forms.GroupBox) AndAlso Not(TypeOf control Is System.Windows.Forms.SplitContainer) AndAlso Not(TypeOf control Is System.Windows.Forms.Panel) AndAlso Not(TypeOf control Is SplitterPanel) AndAlso Not(TypeOf control Is oOOoo_0_0o_) Then
							Me.Oo.oOo_o0Oo0.(A_1, New Object() { control })
						End If
					End If
					If control.Controls.Count > 0 Then
						Me.OOoo___.0.(control.Controls, A_1)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003521 RID: 13601 RVA: 0x00166F80 File Offset: 0x00165180
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is O_oOooO_O Then
						Dim o_oOooO_O As O_oOooO_O = CType(control, O_oOooO_O)
						If o_oOooO_O.o.0O_O0o_..TableType IsNot Nothing OrElse o_oOooO_O.o.0O_O0o_..IsCopy Then
							Me.o0oO_O.0Oo_00.(New Object() { control })
						End If
					Else
						If C1ThemeController.IsObjectThemeable(control) Then
							Me.o0oO_O.0Oo_00.(New Object() { control })
						End If
						If control.Controls.Count > 0 Then
							Me.o0oO_O.0Oo_00.(control.Controls)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x04001589 RID: 5513
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400158A RID: 5514
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Ribbon

		' Token: 0x0400158B RID: 5515
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonApplicationMenu

		' Token: 0x0400158C RID: 5516
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonConfigToolBar

		' Token: 0x0400158D RID: 5517
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonGroup

		' Token: 0x0400158E RID: 5518
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1StatusBar

		' Token: 0x0400158F RID: 5519
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO___OO0O_0

		' Token: 0x04001590 RID: 5520
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CommandDock

		' Token: 0x04001591 RID: 5521
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oo00o_

		' Token: 0x04001592 RID: 5522
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04001593 RID: 5523
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o0ooo_0_00oO

		' Token: 0x04001594 RID: 5524
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CommandHolder

		' Token: 0x04001595 RID: 5525
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolTip

		' Token: 0x04001596 RID: 5526
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x04001597 RID: 5527
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonBottomToolBar

		' Token: 0x04001598 RID: 5528
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonTopToolBar

		' Token: 0x04001599 RID: 5529
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x0400159A RID: 5530
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonQat

		' Token: 0x0400159B RID: 5531
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonTab

		' Token: 0x0400159C RID: 5532
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x0400159D RID: 5533
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ThemeController

		' Token: 0x0400159E RID: 5534
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonLabel

		' Token: 0x0400159F RID: 5535
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonProgressBar

		' Token: 0x040015A0 RID: 5536
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonLabel

		' Token: 0x040015A1 RID: 5537
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RibbonLabel

		' Token: 0x040015A2 RID: 5538
		Friend <<EMPTY_NAME>> As System.Windows.Forms.Control

		' Token: 0x040015A3 RID: 5539
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040015A4 RID: 5540
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x040015A5 RID: 5541
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040015A6 RID: 5542
		Friend <<EMPTY_NAME>> As C1CommandDock

		' Token: 0x040015A7 RID: 5543
		Friend <<EMPTY_NAME>> As C1CommandDock

		' Token: 0x040015A8 RID: 5544
		Friend <<EMPTY_NAME>> As C1CommandDock

		' Token: 0x040015A9 RID: 5545
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040015AA RID: 5546
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040015AB RID: 5547
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x040015AC RID: 5548
		Friend <<EMPTY_NAME>> As DateTime

		' Token: 0x040015AD RID: 5549
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040015AE RID: 5550
		Private <<EMPTY_NAME>> As Long

		' Token: 0x040015AF RID: 5551
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B0 RID: 5552
		Friend <<EMPTY_NAME>> As ToolTip

		' Token: 0x040015B1 RID: 5553
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FileSystemWatcher

		' Token: 0x040015B2 RID: 5554
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B3 RID: 5555
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B4 RID: 5556
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B5 RID: 5557
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B6 RID: 5558
		Friend <<EMPTY_NAME>> As oooO0o000O

		' Token: 0x040015B7 RID: 5559
		Private <<EMPTY_NAME>> As ThemeItem

		' Token: 0x040015B8 RID: 5560
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015B9 RID: 5561
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040015BA RID: 5562
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x040015BB RID: 5563
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040015BC RID: 5564
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015BD RID: 5565
		Private <<EMPTY_NAME>> As String

		' Token: 0x040015BE RID: 5566
		Private <<EMPTY_NAME>> As String

		' Token: 0x040015BF RID: 5567
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040015C0 RID: 5568
		Private <<EMPTY_NAME>> As String

		' Token: 0x040015C1 RID: 5569
		Private a As Integer

		' Token: 0x040015C2 RID: 5570
		Private b As Integer

		' Token: 0x040015C3 RID: 5571
		Private c As Integer

		' Token: 0x040015C4 RID: 5572
		Private a As StaticLocalInitFlag

		' Token: 0x040015C5 RID: 5573
		Private d As Integer

		' Token: 0x040015C6 RID: 5574
		Private a As Boolean

		' Token: 0x040015C7 RID: 5575
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
