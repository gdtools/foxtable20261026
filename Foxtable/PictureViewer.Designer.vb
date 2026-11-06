Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200026A RID: 618
	<DesignerGenerated()>
	Friend Class PictureViewer
		Inherits UserControl

		' Token: 0x06001D73 RID: 7539 RVA: 0x000BAAC4 File Offset: 0x000B8CC4
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.O0.OO0OO. IsNot Nothing Then
					Me.O0.OO0OO..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06001D74 RID: 7540 RVA: 0x000BAB04 File Offset: 0x000B8D04
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O0.OO0OO. = New Container()
			Me.PrevRecord = New Label()
			Me.Full = New Label()
			Me.Clear = New Label()
			Me.Open = New Label()
			Me.NextRecord = New Label()
			Me.Add = New Label()
			Me.Delete = New Label()
			Me.C1PictureBox1 = New C1PictureBox()
			Me.Panel2 = New Panel()
			Me.lblMark = New Label()
			Me.Label1 = New Label()
			Me.C1PictureBox2 = New C1PictureBox()
			Me.PictureSplitContainer = New SplitContainer()
			Me.FlowLayoutPanel1 = New FlowLayoutPanel()
			Me.SplitContainer = New SplitContainer()
			Me.FlowLayoutPanel2 = New FlowLayoutPanel()
			Me.Manager = New Label()
			Me.Stretch = New Label()
			Me.SaveAs = New Label()
			Me.lblConnect = New Label()
			Me.lblUpdate = New Label()
			Me.Timer1 = New System.Windows.Forms.Timer(Me.O0.OO0OO.)
			Me.C1PictureBox1.BeginInit()
			Me.Panel2.SuspendLayout()
			Me.C1PictureBox2.BeginInit()
			Me.PictureSplitContainer.Panel1.SuspendLayout()
			Me.PictureSplitContainer.Panel2.SuspendLayout()
			Me.PictureSplitContainer.SuspendLayout()
			Me.SplitContainer.Panel1.SuspendLayout()
			Me.SplitContainer.Panel2.SuspendLayout()
			Me.SplitContainer.SuspendLayout()
			Me.FlowLayoutPanel2.SuspendLayout()
			MyBase.SuspendLayout()
			Me.PrevRecord.AutoSize = True
			Me.PrevRecord.Cursor = Cursors.Hand
			Me.PrevRecord.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.PrevRecord.ForeColor = Color.Blue
			Me.PrevRecord.Location = New Point(165, 2)
			Me.PrevRecord.Margin = New Padding(0, 0, 1, 0)
			Me.PrevRecord.Name = "PrevRecord"
			Me.PrevRecord.Size = New Size(41, 12)
			Me.PrevRecord.TabIndex = 3
			Me.PrevRecord.Text = "上一条"
			Me.PrevRecord.Visible = False
			Me.Full.AutoSize = True
			Me.Full.Cursor = Cursors.Hand
			Me.Full.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Full.ForeColor = Color.Blue
			Me.Full.Location = New Point(237, 2)
			Me.Full.Margin = New Padding(0, 0, 1, 0)
			Me.Full.Name = "Full"
			Me.Full.Size = New Size(29, 12)
			Me.Full.TabIndex = 7
			Me.Full.Text = "全屏"
			Me.Clear.AutoSize = True
			Me.Clear.Cursor = Cursors.Hand
			Me.Clear.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Clear.ForeColor = Color.Blue
			Me.Clear.Location = New Point(93, 2)
			Me.Clear.Margin = New Padding(0, 0, 1, 0)
			Me.Clear.Name = "Clear"
			Me.Clear.Size = New Size(29, 12)
			Me.Clear.TabIndex = 6
			Me.Clear.Text = "清除"
			Me.Open.AutoSize = True
			Me.Open.Cursor = Cursors.Hand
			Me.Open.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Open.ForeColor = Color.Blue
			Me.Open.Location = New Point(30, 2)
			Me.Open.Margin = New Padding(0, 0, 1, 0)
			Me.Open.Name = "Open"
			Me.Open.Size = New Size(29, 12)
			Me.Open.TabIndex = 4
			Me.Open.Text = "打开"
			Me.NextRecord.AutoSize = True
			Me.NextRecord.Cursor = Cursors.Hand
			Me.NextRecord.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.NextRecord.ForeColor = Color.Blue
			Me.NextRecord.Location = New Point(123, 2)
			Me.NextRecord.Margin = New Padding(0, 0, 1, 0)
			Me.NextRecord.Name = "NextRecord"
			Me.NextRecord.Size = New Size(41, 12)
			Me.NextRecord.TabIndex = 2
			Me.NextRecord.Text = "下一条"
			Me.NextRecord.Visible = False
			Me.Add.AutoSize = True
			Me.Add.Cursor = Cursors.Hand
			Me.Add.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Add.ForeColor = Color.Blue
			Me.Add.Location = New Point(0, 2)
			Me.Add.Margin = New Padding(0, 0, 1, 0)
			Me.Add.Name = "Add"
			Me.Add.Size = New Size(29, 12)
			Me.Add.TabIndex = 1
			Me.Add.Text = "增加"
			Me.Delete.AutoSize = True
			Me.Delete.Cursor = Cursors.Hand
			Me.Delete.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Delete.ForeColor = Color.Blue
			Me.Delete.Location = New Point(63, 2)
			Me.Delete.Margin = New Padding(3, 0, 1, 0)
			Me.Delete.Name = "Delete"
			Me.Delete.Size = New Size(29, 12)
			Me.Delete.TabIndex = 0
			Me.Delete.Text = "删除"
			Me.C1PictureBox1.Location = New Point(166, 105)
			Me.C1PictureBox1.Name = "C1PictureBox1"
			Me.C1PictureBox1.Size = New Size(16, 16)
			Me.C1PictureBox1.TabIndex = 0
			Me.C1PictureBox1.TabStop = False
			Me.Panel2.AutoScroll = True
			Me.Panel2.AutoSize = True
			Me.Panel2.BackColor = SystemColors.ControlLightLight
			Me.Panel2.Controls.Add(Me.lblMark)
			Me.Panel2.Controls.Add(Me.Label1)
			Me.Panel2.Controls.Add(Me.C1PictureBox2)
			Me.Panel2.Controls.Add(Me.C1PictureBox1)
			Me.Panel2.Dock = DockStyle.Fill
			Me.Panel2.Location = New Point(0, 0)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Size(420, 332)
			Me.Panel2.TabIndex = 2
			Me.lblMark.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.lblMark.AutoSize = True
			Me.lblMark.BackColor = Color.Transparent
			Me.lblMark.Font = New Font("宋体", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.lblMark.ForeColor = Color.Red
			Me.lblMark.Location = New Point(403, 0)
			Me.lblMark.Name = "lblMark"
			Me.lblMark.Size = New Size(14, 9)
			Me.lblMark.TabIndex = 3
			Me.lblMark.Text = "●"
			Me.lblMark.Visible = False
			Me.Label1.AutoSize = True
			Me.Label1.Enabled = False
			Me.Label1.Location = New Point(329, 260)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Size(41, 12)
			Me.Label1.TabIndex = 2
			Me.Label1.Tag = "DCZLP7b0/P/TOXCc5S0gmTLOoYufE/B5"
			Me.Label1.Text = "label1"
			Me.Label1.Visible = False
			Me.C1PictureBox2.Anchor = AnchorStyles.None
			Me.C1PictureBox2.Location = New Point(171, 131)
			Me.C1PictureBox2.Name = "C1PictureBox2"
			Me.C1PictureBox2.Size = New Size(78, 71)
			Me.C1PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
			Me.C1PictureBox2.TabIndex = 1
			Me.C1PictureBox2.TabStop = False
			Me.PictureSplitContainer.BackColor = SystemColors.ControlDarkDark
			Me.PictureSplitContainer.Dock = DockStyle.Fill
			Me.PictureSplitContainer.FixedPanel = FixedPanel.Panel2
			Me.PictureSplitContainer.Location = New Point(0, 0)
			Me.PictureSplitContainer.Name = "PictureSplitContainer"
			Me.PictureSplitContainer.Orientation = Orientation.Horizontal
			Me.PictureSplitContainer.Panel1.Controls.Add(Me.Panel2)
			Me.PictureSplitContainer.Panel2.AutoScroll = True
			Me.PictureSplitContainer.Panel2.BackColor = SystemColors.ControlLightLight
			Me.PictureSplitContainer.Panel2.Controls.Add(Me.FlowLayoutPanel1)
			Me.PictureSplitContainer.Panel2Collapsed = True
			Me.PictureSplitContainer.Panel2MinSize = 75
			Me.PictureSplitContainer.Size = New Size(420, 332)
			Me.PictureSplitContainer.SplitterDistance = 249
			Me.PictureSplitContainer.TabIndex = 3
			Me.FlowLayoutPanel1.AutoSize = True
			Me.FlowLayoutPanel1.Location = New Point(0, 0)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Size = New Size(249, 41)
			Me.FlowLayoutPanel1.TabIndex = 0
			Me.SplitContainer.Dock = DockStyle.Fill
			Me.SplitContainer.FixedPanel = FixedPanel.Panel2
			Me.SplitContainer.Location = New Point(0, 0)
			Me.SplitContainer.Name = "SplitContainer"
			Me.SplitContainer.Orientation = Orientation.Horizontal
			Me.SplitContainer.Panel1.Controls.Add(Me.PictureSplitContainer)
			Me.SplitContainer.Panel1MinSize = 15
			Me.SplitContainer.Panel2.Controls.Add(Me.FlowLayoutPanel2)
			Me.SplitContainer.Panel2MinSize = 15
			Me.SplitContainer.Size = New Size(420, 354)
			Me.SplitContainer.SplitterDistance = 332
			Me.SplitContainer.TabIndex = 4
			Me.FlowLayoutPanel2.Controls.Add(Me.Add)
			Me.FlowLayoutPanel2.Controls.Add(Me.Open)
			Me.FlowLayoutPanel2.Controls.Add(Me.Delete)
			Me.FlowLayoutPanel2.Controls.Add(Me.Clear)
			Me.FlowLayoutPanel2.Controls.Add(Me.NextRecord)
			Me.FlowLayoutPanel2.Controls.Add(Me.PrevRecord)
			Me.FlowLayoutPanel2.Controls.Add(Me.Manager)
			Me.FlowLayoutPanel2.Controls.Add(Me.Full)
			Me.FlowLayoutPanel2.Controls.Add(Me.Stretch)
			Me.FlowLayoutPanel2.Controls.Add(Me.SaveAs)
			Me.FlowLayoutPanel2.Controls.Add(Me.lblConnect)
			Me.FlowLayoutPanel2.Controls.Add(Me.lblUpdate)
			Me.FlowLayoutPanel2.Dock = DockStyle.Fill
			Me.FlowLayoutPanel2.Location = New Point(0, 0)
			Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
			Me.FlowLayoutPanel2.Padding = New Padding(0, 2, 0, 0)
			Me.FlowLayoutPanel2.Size = New Size(420, 18)
			Me.FlowLayoutPanel2.TabIndex = 10
			Me.Manager.AutoSize = True
			Me.Manager.Cursor = Cursors.Hand
			Me.Manager.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Manager.ForeColor = Color.Blue
			Me.Manager.Location = New Point(207, 2)
			Me.Manager.Margin = New Padding(0, 0, 1, 0)
			Me.Manager.Name = "Manager"
			Me.Manager.Size = New Size(29, 12)
			Me.Manager.TabIndex = 8
			Me.Manager.Text = "管理"
			Me.Manager.Visible = False
			Me.Stretch.AutoSize = True
			Me.Stretch.Cursor = Cursors.Hand
			Me.Stretch.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Stretch.ForeColor = Color.Blue
			Me.Stretch.Location = New Point(267, 2)
			Me.Stretch.Margin = New Padding(0, 0, 1, 0)
			Me.Stretch.Name = "Stretch"
			Me.Stretch.Size = New Size(29, 12)
			Me.Stretch.TabIndex = 9
			Me.Stretch.Text = "缩放"
			Me.SaveAs.AutoSize = True
			Me.SaveAs.Cursor = Cursors.Hand
			Me.SaveAs.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.SaveAs.ForeColor = Color.Blue
			Me.SaveAs.Location = New Point(297, 2)
			Me.SaveAs.Margin = New Padding(0, 0, 1, 0)
			Me.SaveAs.Name = "SaveAs"
			Me.SaveAs.Size = New Size(29, 12)
			Me.SaveAs.TabIndex = 10
			Me.SaveAs.Text = "另存"
			Me.lblConnect.AutoSize = True
			Me.lblConnect.Cursor = Cursors.Hand
			Me.lblConnect.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.lblConnect.ForeColor = Color.Blue
			Me.lblConnect.Location = New Point(327, 2)
			Me.lblConnect.Margin = New Padding(0, 0, 1, 0)
			Me.lblConnect.Name = "lblConnect"
			Me.lblConnect.Size = New Size(29, 12)
			Me.lblConnect.TabIndex = 11
			Me.lblConnect.Text = "重连"
			Me.lblUpdate.AutoSize = True
			Me.lblUpdate.Cursor = Cursors.Hand
			Me.lblUpdate.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.lblUpdate.ForeColor = Color.Blue
			Me.lblUpdate.Location = New Point(357, 2)
			Me.lblUpdate.Margin = New Padding(0, 0, 1, 0)
			Me.lblUpdate.Name = "lblUpdate"
			Me.lblUpdate.Size = New Size(29, 12)
			Me.lblUpdate.TabIndex = 12
			Me.lblUpdate.Text = "更新"
			Me.Timer1.Enabled = True
			Me.Timer1.Interval = 1000
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.AutoScroll = True
			MyBase.Controls.Add(Me.SplitContainer)
			MyBase.Name = "Oo0.O.O."
			MyBase.Size = New Size(420, 354)
			MyBase.Tag = ""
			Me.C1PictureBox1.EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			Me.C1PictureBox2.EndInit()
			Me.PictureSplitContainer.Panel1.ResumeLayout(False)
			Me.PictureSplitContainer.Panel1.PerformLayout()
			Me.PictureSplitContainer.Panel2.ResumeLayout(False)
			Me.PictureSplitContainer.Panel2.PerformLayout()
			Me.PictureSplitContainer.ResumeLayout(False)
			Me.SplitContainer.Panel1.ResumeLayout(False)
			Me.SplitContainer.Panel2.ResumeLayout(False)
			Me.SplitContainer.ResumeLayout(False)
			Me.FlowLayoutPanel2.ResumeLayout(False)
			Me.FlowLayoutPanel2.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x1700069A RID: 1690
		' (get) Token: 0x06001D75 RID: 7541 RVA: 0x000BBCF5 File Offset: 0x000B9EF5
		' (set) Token: 0x06001D76 RID: 7542 RVA: 0x000BBCFD File Offset: 0x000B9EFD
		Friend Overridable Property Panel2 As Panel

		' Token: 0x1700069B RID: 1691
		' (get) Token: 0x06001D77 RID: 7543 RVA: 0x000BBD06 File Offset: 0x000B9F06
		' (set) Token: 0x06001D78 RID: 7544 RVA: 0x000BBD10 File Offset: 0x000B9F10
		Friend Overridable Property PrevRecord As Label
			<CompilerGenerated()>
			Get
				Return Me.O0.OO0OO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.OoOO.Ooo__.
				Dim o0.OO0OO. As Label = Me.O0.OO0OO.
				If o0.OO0OO. IsNot Nothing Then
					RemoveHandler o0.OO0OO..Click, value2
				End If
				Me.O0.OO0OO. = value
				o0.OO0OO. = Me.O0.OO0OO.
				If o0.OO0OO. IsNot Nothing Then
					AddHandler o0.OO0OO..Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069C RID: 1692
		' (get) Token: 0x06001D79 RID: 7545 RVA: 0x000BBD53 File Offset: 0x000B9F53
		' (set) Token: 0x06001D7A RID: 7546 RVA: 0x000BBD5C File Offset: 0x000B9F5C
		Friend Overridable Property NextRecord As Label
			<CompilerGenerated()>
			Get
				Return Me.o.o0o00Oo_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.oOOO0.0o_O.
				Dim label As Label = Me.o.o0o00Oo_.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.o.o0o00Oo_. = value
				label = Me.o.o0o00Oo_.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069D RID: 1693
		' (get) Token: 0x06001D7B RID: 7547 RVA: 0x000BBD9F File Offset: 0x000B9F9F
		' (set) Token: 0x06001D7C RID: 7548 RVA: 0x000BBDA8 File Offset: 0x000B9FA8
		Friend Overridable Property Add As Label
			<CompilerGenerated()>
			Get
				Return Me.oo__oOo0___O.O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.O0_oooo0OO.Oo.
				Dim label As Label = Me.oo__oOo0___O.O.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.oo__oOo0___O.O. = value
				label = Me.oo__oOo0___O.O.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069E RID: 1694
		' (get) Token: 0x06001D7D RID: 7549 RVA: 0x000BBDEB File Offset: 0x000B9FEB
		' (set) Token: 0x06001D7E RID: 7550 RVA: 0x000BBDF4 File Offset: 0x000B9FF4
		Friend Overridable Property Delete As Label
			<CompilerGenerated()>
			Get
				Return Me.O.0OoOo_OO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o0OO00oo_.o_.
				Dim o.0OoOo_OO. As Label = Me.O.0OoOo_OO.
				If o.0OoOo_OO. IsNot Nothing Then
					RemoveHandler o.0OoOo_OO..Click, value2
				End If
				Me.O.0OoOo_OO. = value
				o.0OoOo_OO. = Me.O.0OoOo_OO.
				If o.0OoOo_OO. IsNot Nothing Then
					AddHandler o.0OoOo_OO..Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700069F RID: 1695
		' (get) Token: 0x06001D7F RID: 7551 RVA: 0x000BBE37 File Offset: 0x000BA037
		' (set) Token: 0x06001D80 RID: 7552 RVA: 0x000BBE40 File Offset: 0x000BA040
		Friend Overridable Property Open As Label
			<CompilerGenerated()>
			Get
				Return Me.O_0.0oOO0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.oo0_.o___.
				Dim o_0.0oOO0. As Label = Me.O_0.0oOO0.
				If o_0.0oOO0. IsNot Nothing Then
					RemoveHandler o_0.0oOO0..Click, value2
				End If
				Me.O_0.0oOO0. = value
				o_0.0oOO0. = Me.O_0.0oOO0.
				If o_0.0oOO0. IsNot Nothing Then
					AddHandler o_0.0oOO0..Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006A0 RID: 1696
		' (get) Token: 0x06001D81 RID: 7553 RVA: 0x000BBE83 File Offset: 0x000BA083
		' (set) Token: 0x06001D82 RID: 7554 RVA: 0x000BBE8B File Offset: 0x000BA08B
		Friend Overridable Property PictureSplitContainer As SplitContainer

		' Token: 0x170006A1 RID: 1697
		' (get) Token: 0x06001D83 RID: 7555 RVA: 0x000BBE94 File Offset: 0x000BA094
		' (set) Token: 0x06001D84 RID: 7556 RVA: 0x000BBE9C File Offset: 0x000BA09C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170006A2 RID: 1698
		' (get) Token: 0x06001D85 RID: 7557 RVA: 0x000BBEA5 File Offset: 0x000BA0A5
		' (set) Token: 0x06001D86 RID: 7558 RVA: 0x000BBEB0 File Offset: 0x000BA0B0
		Friend Overridable Property C1PictureBox1 As C1PictureBox
			<CompilerGenerated()>
			Get
				Return Me.o00_.0_ooO_00.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As C1PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.O0o0o__oo._o.
				Dim value3 As MouseEventHandler = AddressOf Me.o.o0o0.
				Dim value4 As MouseEventHandler = AddressOf Me.OoOo.O00.
				Dim value5 As EventHandler = AddressOf Me.o.o0o0.
				Dim c1PictureBox As C1PictureBox = Me.o00_.0_ooO_00.
				If c1PictureBox IsNot Nothing Then
					RemoveHandler c1PictureBox.MouseDown, value2
					RemoveHandler c1PictureBox.MouseMove, value3
					RemoveHandler c1PictureBox.MouseUp, value4
					RemoveHandler c1PictureBox.DoubleClick, value5
				End If
				Me.o00_.0_ooO_00. = value
				c1PictureBox = Me.o00_.0_ooO_00.
				If c1PictureBox IsNot Nothing Then
					AddHandler c1PictureBox.MouseDown, value2
					AddHandler c1PictureBox.MouseMove, value3
					AddHandler c1PictureBox.MouseUp, value4
					AddHandler c1PictureBox.DoubleClick, value5
				End If
			End Set
		End Property

		' Token: 0x170006A3 RID: 1699
		' (get) Token: 0x06001D87 RID: 7559 RVA: 0x000BBF50 File Offset: 0x000BA150
		' (set) Token: 0x06001D88 RID: 7560 RVA: 0x000BBF58 File Offset: 0x000BA158
		Friend Overridable Property Clear As Label
			<CompilerGenerated()>
			Get
				Return Me.oOoo.0o.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Oo.00Oo_0Oo0O0.
				Dim label As Label = Me.oOoo.0o.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.oOoo.0o. = value
				label = Me.oOoo.0o.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006A4 RID: 1700
		' (get) Token: 0x06001D89 RID: 7561 RVA: 0x000BBF9B File Offset: 0x000BA19B
		' (set) Token: 0x06001D8A RID: 7562 RVA: 0x000BBFA4 File Offset: 0x000BA1A4
		Friend Overridable Property Full As Label
			<CompilerGenerated()>
			Get
				Return Me.OO.__O__00O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.O0.O__Ooo.
				Dim oo.__O__00O. As Label = Me.OO.__O__00O.
				If oo.__O__00O. IsNot Nothing Then
					RemoveHandler oo.__O__00O..Click, value2
				End If
				Me.OO.__O__00O. = value
				oo.__O__00O. = Me.OO.__O__00O.
				If oo.__O__00O. IsNot Nothing Then
					AddHandler oo.__O__00O..Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006A5 RID: 1701
		' (get) Token: 0x06001D8B RID: 7563 RVA: 0x000BBFE7 File Offset: 0x000BA1E7
		' (set) Token: 0x06001D8C RID: 7564 RVA: 0x000BBFEF File Offset: 0x000BA1EF
		Friend Overridable Property SplitContainer As SplitContainer

		' Token: 0x170006A6 RID: 1702
		' (get) Token: 0x06001D8D RID: 7565 RVA: 0x000BBFF8 File Offset: 0x000BA1F8
		' (set) Token: 0x06001D8E RID: 7566 RVA: 0x000BC000 File Offset: 0x000BA200
		Friend Overridable Property Manager As Label
			<CompilerGenerated()>
			Get
				Return Me.oO_O00.O0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Oo0._OO_O_O0.
				Dim label As Label = Me.oO_O00.O0.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.oO_O00.O0. = value
				label = Me.oO_O00.O0.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006A7 RID: 1703
		' (get) Token: 0x06001D8F RID: 7567 RVA: 0x000BC043 File Offset: 0x000BA243
		' (set) Token: 0x06001D90 RID: 7568 RVA: 0x000BC04C File Offset: 0x000BA24C
		Friend Overridable Property Stretch As Label
			<CompilerGenerated()>
			Get
				Return Me.OooO_0o._0_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o__.000___OO.
				Dim oooO_0o._0_. As Label = Me.OooO_0o._0_.
				If oooO_0o._0_. IsNot Nothing Then
					RemoveHandler oooO_0o._0_..Click, value2
				End If
				Me.OooO_0o._0_. = value
				oooO_0o._0_. = Me.OooO_0o._0_.
				If oooO_0o._0_. IsNot Nothing Then
					AddHandler oooO_0o._0_..Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006A8 RID: 1704
		' (get) Token: 0x06001D91 RID: 7569 RVA: 0x000BC08F File Offset: 0x000BA28F
		' (set) Token: 0x06001D92 RID: 7570 RVA: 0x000BC097 File Offset: 0x000BA297
		Friend Overridable Property FlowLayoutPanel2 As FlowLayoutPanel

		' Token: 0x170006A9 RID: 1705
		' (get) Token: 0x06001D93 RID: 7571 RVA: 0x000BC0A0 File Offset: 0x000BA2A0
		' (set) Token: 0x06001D94 RID: 7572 RVA: 0x000BC0A8 File Offset: 0x000BA2A8
		Friend Overridable Property SaveAs As Label
			<CompilerGenerated()>
			Get
				Return Me.oo0_.0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.ooo0O0O.O_.
				Dim label As Label = Me.oo0_.0.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.oo0_.0. = value
				label = Me.oo0_.0.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006AA RID: 1706
		' (get) Token: 0x06001D95 RID: 7573 RVA: 0x000BC0EB File Offset: 0x000BA2EB
		' (set) Token: 0x06001D96 RID: 7574 RVA: 0x000BC0F4 File Offset: 0x000BA2F4
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me.O0.OO0OO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.O.0o__0_.
				Dim o0.OO0OO. As System.Windows.Forms.Timer = Me.O0.OO0OO.
				If o0.OO0OO. IsNot Nothing Then
					RemoveHandler o0.OO0OO..Tick, value2
				End If
				Me.O0.OO0OO. = value
				o0.OO0OO. = Me.O0.OO0OO.
				If o0.OO0OO. IsNot Nothing Then
					AddHandler o0.OO0OO..Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170006AB RID: 1707
		' (get) Token: 0x06001D97 RID: 7575 RVA: 0x000BC137 File Offset: 0x000BA337
		' (set) Token: 0x06001D98 RID: 7576 RVA: 0x000BC140 File Offset: 0x000BA340
		Friend Overridable Property lblConnect As Label
			<CompilerGenerated()>
			Get
				Return Me.o_.0O0_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.O.OOOOOo.
				Dim label As Label = Me.o_.0O0_.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.o_.0O0_. = value
				label = Me.o_.0O0_.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006AC RID: 1708
		' (get) Token: 0x06001D99 RID: 7577 RVA: 0x000BC183 File Offset: 0x000BA383
		' (set) Token: 0x06001D9A RID: 7578 RVA: 0x000BC18C File Offset: 0x000BA38C
		Friend Overridable Property lblUpdate As Label
			<CompilerGenerated()>
			Get
				Return Me.OOOo._OoO_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.O_.oO.
				Dim oooo._OoO_. As Label = Me.OOOo._OoO_.
				If oooo._OoO_. IsNot Nothing Then
					RemoveHandler oooo._OoO_..Click, value2
				End If
				Me.OOOo._OoO_. = value
				oooo._OoO_. = Me.OOOo._OoO_.
				If oooo._OoO_. IsNot Nothing Then
					AddHandler oooo._OoO_..Click, value2
				End If
			End Set
		End Property

		' Token: 0x170006AD RID: 1709
		' (get) Token: 0x06001D9B RID: 7579 RVA: 0x000BC1CF File Offset: 0x000BA3CF
		' (set) Token: 0x06001D9C RID: 7580 RVA: 0x000BC1D8 File Offset: 0x000BA3D8
		Friend Overridable Property C1PictureBox2 As C1PictureBox
			<CompilerGenerated()>
			Get
				Return Me.O.oOOOO0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As C1PictureBox)
				Dim value2 As EventHandler = AddressOf Me.o.o0o0.
				Dim o.oOOOO0. As C1PictureBox = Me.O.oOOOO0.
				If o.oOOOO0. IsNot Nothing Then
					RemoveHandler o.oOOOO0..DoubleClick, value2
				End If
				Me.O.oOOOO0. = value
				o.oOOOO0. = Me.O.oOOOO0.
				If o.oOOOO0. IsNot Nothing Then
					AddHandler o.oOOOO0..DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170006AE RID: 1710
		' (get) Token: 0x06001D9D RID: 7581 RVA: 0x000BC21B File Offset: 0x000BA41B
		' (set) Token: 0x06001D9E RID: 7582 RVA: 0x000BC223 File Offset: 0x000BA423
		Friend Overridable Property Label1 As Label

		' Token: 0x170006AF RID: 1711
		' (get) Token: 0x06001D9F RID: 7583 RVA: 0x000BC22C File Offset: 0x000BA42C
		' (set) Token: 0x06001DA0 RID: 7584 RVA: 0x000BC234 File Offset: 0x000BA434
		Friend Overridable Property lblMark As Label
			<CompilerGenerated()>
			Get
				Return Me.Oo0Oo0.OO0_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.oo._O_o00oO0Oo.
				Dim oo0Oo0.OO0_. As Label = Me.Oo0Oo0.OO0_.
				If oo0Oo0.OO0_. IsNot Nothing Then
					RemoveHandler oo0Oo0.OO0_..ForeColorChanged, value2
				End If
				Me.Oo0Oo0.OO0_. = value
				oo0Oo0.OO0_. = Me.Oo0Oo0.OO0_.
				If oo0Oo0.OO0_. IsNot Nothing Then
					AddHandler oo0Oo0.OO0_..ForeColorChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170006B0 RID: 1712
		' (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000BC277 File Offset: 0x000BA477
		' (set) Token: 0x06001DA2 RID: 7586 RVA: 0x000BC280 File Offset: 0x000BA480
		Private Overridable Property _FTPClient As FTPClient
			<CompilerGenerated()>
			Get
				Return Me.O.0o0o0o_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FTPClient)
				Dim a_ As FTPClient.oO_o_0OOo__0 = AddressOf Me.OO0.___.
				Dim a_2 As FTPClient.O__0O000__Oo = AddressOf Me.oOo.o0Oo_.
				Dim a_3 As FTPClient.Oo__ = AddressOf Me.oOo.o0Oo_.
				Dim a_4 As FTPClient.OooO_O0O_0_O = AddressOf Me.oOo.o0Oo_.
				Dim o.0o0o0o_. As FTPClient = Me.O.0o0o0o_.
				If o.0o0o0o_. IsNot Nothing Then
					RemoveHandler o.0o0o0o_..DownloadCompleted, a_
					RemoveHandler o.0o0o0o_..DownloadError, a_2
					RemoveHandler o.0o0o0o_..FileCompared, a_3
					RemoveHandler o.0o0o0o_..ServerConnected, a_4
				End If
				Me.O.0o0o0o_. = value
				o.0o0o0o_. = Me.O.0o0o0o_.
				If o.0o0o0o_. IsNot Nothing Then
					AddHandler o.0o0o0o_..DownloadCompleted, a_
					AddHandler o.0o0o0o_..DownloadError, a_2
					AddHandler o.0o0o0o_..FileCompared, a_3
					AddHandler o.0o0o0o_..ServerConnected, a_4
				End If
			End Set
		End Property

		' Token: 0x170006B1 RID: 1713
		' (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000BC320 File Offset: 0x000BA520
		' (set) Token: 0x06001DA4 RID: 7588 RVA: 0x000BC328 File Offset: 0x000BA528
		Private Overridable Property bdm As Binding
			<CompilerGenerated()>
			Get
				Return Me.o00_.0_ooO_00.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Binding)
				Dim value2 As ConvertEventHandler = AddressOf Me.oOo.o0Oo_.
				Dim binding As Binding = Me.o00_.0_ooO_00.
				If binding IsNot Nothing Then
					RemoveHandler binding.Parse, value2
				End If
				Me.o00_.0_ooO_00. = value
				binding = Me.o00_.0_ooO_00.
				If binding IsNot Nothing Then
					AddHandler binding.Parse, value2
				End If
			End Set
		End Property

		' Token: 0x170006B2 RID: 1714
		' (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000BC36B File Offset: 0x000BA56B
		' (set) Token: 0x06001DA6 RID: 7590 RVA: 0x000BC374 File Offset: 0x000BA574
		Private Overridable Property Box As PictureBox
			<CompilerGenerated()>
			Get
				Return Me.o00_.0_ooO_00.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As AsyncCompletedEventHandler = AddressOf Me.O__o.0o.
				Dim pictureBox As PictureBox = Me.o00_.0_ooO_00.
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.LoadCompleted, value2
				End If
				Me.o00_.0_ooO_00. = value
				pictureBox = Me.o00_.0_ooO_00.
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.LoadCompleted, value2
				End If
			End Set
		End Property

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x06001DA7 RID: 7591 RVA: 0x000BC3B8 File Offset: 0x000BA5B8
		' (remove) Token: 0x06001DA8 RID: 7592 RVA: 0x000BC3F0 File Offset: 0x000BA5F0
		Public Custom Event SelectedItemChanged As PictureViewer.O_O0_0_Ooo
			<CompilerGenerated()>
			AddHandler
				Dim o_O0_0_Ooo As PictureViewer.O_O0_0_Ooo = Me.O.0O_o_.
				Dim o_O0_0_Ooo2 As PictureViewer.O_O0_0_Ooo
				Do
					o_O0_0_Ooo2 = o_O0_0_Ooo
					Dim value2 As PictureViewer.O_O0_0_Ooo = CType([Delegate].Combine(o_O0_0_Ooo2, value), PictureViewer.O_O0_0_Ooo)
					o_O0_0_Ooo = Interlocked.CompareExchange(Of PictureViewer.O_O0_0_Ooo)(Me.O.0O_o_., value2, o_O0_0_Ooo2)
				Loop While o_O0_0_Ooo IsNot o_O0_0_Ooo2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim o_O0_0_Ooo As PictureViewer.O_O0_0_Ooo = Me.O.0O_o_.
				Dim o_O0_0_Ooo2 As PictureViewer.O_O0_0_Ooo
				Do
					o_O0_0_Ooo2 = o_O0_0_Ooo
					Dim value2 As PictureViewer.O_O0_0_Ooo = CType([Delegate].Remove(o_O0_0_Ooo2, value), PictureViewer.O_O0_0_Ooo)
					o_O0_0_Ooo = Interlocked.CompareExchange(Of PictureViewer.O_O0_0_Ooo)(Me.O.0O_o_., value2, o_O0_0_Ooo2)
				Loop While o_O0_0_Ooo IsNot o_O0_0_Ooo2
			End RemoveHandler
		End Event

		' Token: 0x06001DA9 RID: 7593 RVA: 0x000BC428 File Offset: 0x000BA628
		Friend Sub New()
			AddHandler MyBase.ParentChanged, AddressOf Me.ooOo0o_O.O.
			Me.O0.OO0OO. = New List(Of String)()
			Me.oO0O.o_O_0OO0. = True
			Me.OOo0_00_.oOOo0. = True
			Me.o__O0oO._. = True
			Me.Box = New PictureBox()
			Me.O00_.0_ooO_o.()
			Me.SizeMode = PictureBoxSizeMode.Zoom
			Me.Label1.Tag = O00.DecryptText(Me.Label1.Tag.ToString(), "me", "me")
		End Sub

		' Token: 0x170006B3 RID: 1715
		' (get) Token: 0x06001DAA RID: 7594 RVA: 0x000BC4AF File Offset: 0x000BA6AF
		Private ReadOnly Property bd As Binding
			Get
				If MyBase.DataBindings.Count > 0 Then
					Me.bdm = MyBase.DataBindings(0)
				Else
					Me.bdm = Nothing
				End If
				Return Me.bdm
			End Get
		End Property

		' Token: 0x170006B4 RID: 1716
		' (get) Token: 0x06001DAB RID: 7595 RVA: 0x000BC4E0 File Offset: 0x000BA6E0
		' (set) Token: 0x06001DAC RID: 7596 RVA: 0x000BC4E8 File Offset: 0x000BA6E8
		Friend Property FTPclient As FTPClient
			Get
				Return Me._FTPClient
			End Get
			Set(value As FTPClient)
				If value IsNot Nothing Then
					Me._FTPClient = New FTPClient()
					Me._FTPClient.Host = value.Host
					Me._FTPClient.Account = value.Account
					Me._FTPClient.Password = value.Password
					Me._FTPClient.Port = value.Port
					Me._FTPClient.UTF8 = value.UTF8
					Me._FTPClient.RootDir = value.RootDir
				Else
					Me._FTPClient = Nothing
				End If
				If MyBase.Parent IsNot Nothing Then
					Try
						For Each obj As Object In Me.FlowLayoutPanel1.Controls
							CType(obj, PictureViewer.OOooOoooo).set_Canceled(False)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If Me._FTPClient Is Nothing Then
						Me.lblConnect.Visible = False
						Me.lblUpdate.Visible = False
					Else
						Me.lblConnect.Visible = True
						Me.lblUpdate.Visible = True
						If Not Me.AutoDownLoad Then
							Me.lblUpdate.Visible = False
						End If
					End If
				End If
				Me.Manager.Visible = (value IsNot Nothing)
			End Set
		End Property

		' Token: 0x170006B5 RID: 1717
		' (get) Token: 0x06001DAD RID: 7597 RVA: 0x000BC62C File Offset: 0x000BA82C
		Private ReadOnly Property bm As BindingManagerBase
			Get
				Dim result As BindingManagerBase
				If MyBase.DataBindings.Count > 0 Then
					result = MyBase.DataBindings(0).BindingManagerBase
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170006B6 RID: 1718
		' (get) Token: 0x06001DAE RID: 7598 RVA: 0x000BC65E File Offset: 0x000BA85E
		' (set) Token: 0x06001DAF RID: 7599 RVA: 0x000BC666 File Offset: 0x000BA866
		Friend Property AutoDownLoad As Boolean
			Get
				Return Me.OOo0_00_.oOOo0.
			End Get
			Set(value As Boolean)
				Me.OOo0_00_.oOOo0. = value
			End Set
		End Property

		' Token: 0x170006B7 RID: 1719
		' (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000BC66F File Offset: 0x000BA86F
		' (set) Token: 0x06001DB1 RID: 7601 RVA: 0x000BC677 File Offset: 0x000BA877
		Friend Property AutoUpdate As Boolean
			Get
				Return Me.o__O0oO._.
			End Get
			Set(value As Boolean)
				Me.o__O0oO._. = value
			End Set
		End Property

		' Token: 0x170006B8 RID: 1720
		' (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000BC680 File Offset: 0x000BA880
		' (set) Token: 0x06001DB3 RID: 7603 RVA: 0x000BC688 File Offset: 0x000BA888
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O0.OO0OO.
			End Get
			Set(value As BooleanEnum)
				Me.O0.OO0OO. = value
			End Set
		End Property

		' Token: 0x170006B9 RID: 1721
		' (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000BC691 File Offset: 0x000BA891
		' (set) Token: 0x06001DB5 RID: 7605 RVA: 0x000BC6A0 File Offset: 0x000BA8A0
		Public Property SizeMode As PictureBoxSizeMode
			Get
				Return Me.C1PictureBox1.SizeMode
			End Get
			Set(value As PictureBoxSizeMode)
				Me.C1PictureBox1.SizeMode = value
				Select Case value
					Case PictureBoxSizeMode.Normal, PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.CenterImage, PictureBoxSizeMode.Zoom
						Me.C1PictureBox1.Dock = DockStyle.Fill
						Return
					Case PictureBoxSizeMode.AutoSize
						Me.C1PictureBox1.Dock = DockStyle.None
						Me.o.o0o0.()
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x170006BA RID: 1722
		' (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000BC6F5 File Offset: 0x000BA8F5
		' (set) Token: 0x06001DB7 RID: 7607 RVA: 0x000BC700 File Offset: 0x000BA900
		Public Property ImageFiles As String
			Get
				Return Me.o_O0.O0O.
			End Get
			Set(value As String)
				If Me.lblMark.Parent IsNot Nothing Then
					Me.lblMark.Parent.Controls.Remove(Me.lblMark)
				End If
				If Not Me.C1PictureBox1.Visible Then
					Me.C1PictureBox1.Visible = True
				End If
				If Me.C1PictureBox2.Visible Then
					Me.C1PictureBox2.Visible = False
				End If
				If Operators.CompareString(Me.o_O0.O0O., value, True) <> 0 Then
					Me.o_O0.O0O. = value
					Me.O0.OO0OO..Clear()
					If Operators.CompareString(value, "", True) > 0 Then
						Me.O0.OO0OO..AddRange(value.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries))
					End If
					If Me.C1PictureBox1.Image IsNot Nothing Then
						Me.C1PictureBox1.Image.Dispose()
						Me.C1PictureBox1.Image = Nothing
					End If
					Me.C1PictureBox1.Tag = Nothing
					If Me.FTPclient IsNot Nothing AndAlso Me.FTPclient.AsyncState = Oo_0.Oo_o_o.__oo. Then
						Me.FTPclient.o_0_.__0OO.()
					End If
					Try
						For Each obj As Object In Me.FlowLayoutPanel1.Controls
							Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
							If ooooOoooo.get_Completed() AndAlso ooooOoooo.Image IsNot Nothing AndAlso ooooOoooo.Image IsNot O_O0OO.o0_OO.000.() AndAlso ooooOoooo.Image IsNot ooooOoooo.ErrorImage Then
								ooooOoooo.Image.Dispose()
								ooooOoooo.Image = Nothing
							End If
							ooooOoooo.Dispose()
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Me.FlowLayoutPanel1.Controls.Clear()
					If Me.FTPclient Is Nothing OrElse Me.AutoDownLoad Then
						Me.PictureSplitContainer.Panel2Collapsed = (Me.O0.OO0OO..Count <= 1)
					Else
						Me.PictureSplitContainer.Panel2Collapsed = False
					End If
					Me.O_O0.OO. = 0
					Me.O0O.o__0O. = True
					GC.Collect()
				End If
			End Set
		End Property

		' Token: 0x06001DB8 RID: 7608 RVA: 0x000BC900 File Offset: 0x000BAB00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj7 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If MyBase.FindForm() IsNot Nothing AndAlso (Me.FTPclient Is Nothing OrElse Not Me.FTPclient.O0.o0.) Then
					GoTo IL_88
				End If
				IL_26:
				num2 = 3
				RemoveHandler Application.Idle, AddressOf Me.oo_o000o_oo0.o.
				IL_39:
				num2 = 4
				RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O__o.0o.
				IL_4C:
				num2 = 5
				RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Me.oo_o___._O0.
				IL_5F:
				num2 = 6
				If Me.FTPclient Is Nothing Then
					GoTo IL_7AB
				End If
				IL_6C:
				num2 = 7
				Me.FTPclient.Connected = False
				IL_7A:
				num2 = 8
				Me.FTPclient = Nothing
				GoTo IL_7AB
				IL_88:
				num2 = 10
				Dim enumerator As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
					IL_AE:
					num2 = 11
					If ooooOoooo.Controls.Count > 0 Then
						IL_C3:
						num2 = 12
						If Me.C1PictureBox1.Tag Is ooooOoooo Then
							IL_D5:
							num2 = 13
							If ooooOoooo.Controls(0).ForeColor <> Color.Blue Then
								IL_F6:
								num2 = 14
								ooooOoooo.Controls(0).ForeColor = Color.Blue
							End If
						Else
							IL_112:
							num2 = 16
							If ooooOoooo.Controls(0).ForeColor <> SystemColors.ControlText Then
								IL_133:
								num2 = 17
								ooooOoooo.Controls(0).ForeColor = SystemColors.ControlText
							End If
						End If
					End If
					IL_14D:
					num2 = 18
				End While
				IL_15B:
				num2 = 19
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_171:
				num2 = 20
				If Not MyBase.CanFocus Then
					GoTo IL_7AB
				End If
				IL_17F:
				num2 = 22
				If Me.O_O0.OO. > Me.O0.OO0OO..Count - 1 Then
					GoTo IL_1EE
				End If
				IL_197:
				num2 = 23
				If Me.FTPclient IsNot Nothing Then
					GoTo IL_1BE
				End If
				IL_1A2:
				num2 = 24
				Me.o_.0o_0o_o.(Me.O0.OO0OO.(Me.O_O0.OO.))
				GoTo IL_1D8
				IL_1BE:
				num2 = 26
				Me.o.o0o0.(Me.O0.OO0OO.(Me.O_O0.OO.))
				IL_1D8:
				num2 = 27
				Me.O_O0.OO. += 1
				GoTo IL_7AB
				IL_1EE:
				num2 = 30
				If Me.C1PictureBox1.Tag IsNot Nothing OrElse Me.FTPclient IsNot Nothing Then
					GoTo IL_2CB
				End If
				IL_20C:
				num2 = 31
				Dim enumerator2 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				Dim num3 As Integer
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim ooooOoooo2 As PictureViewer.OOooOoooo = CType(obj2, PictureViewer.OOooOoooo)
					IL_231:
					num2 = 32
					If Not ooooOoooo2.get_Canceled() Then
						IL_23D:
						num2 = 33
						num3 = 1
						Exit While
					End If
					IL_245:
					num2 = 35
				End While
				IL_251:
				num2 = 36
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_269:
				num2 = 37
				If num3 <> 0 Then
					GoTo IL_2CB
				End If
				IL_270:
				num2 = 38
				Dim enumerator3 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				IL_2AA:
				If enumerator3.MoveNext() Then
					Dim a_ As PictureViewer.OOooOoooo = CType(enumerator3.Current, PictureViewer.OOooOoooo)
					IL_295:
					num2 = 39
					Me.O__O.o_ooo0Oo_.(a_, New EventArgs())
				End If
				IL_2B3:
				num2 = 42
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
				IL_2CB:
				num2 = 43
				If Me.o_o_O_Oo.OoOo. Then
					GoTo IL_42F
				End If
				IL_2D9:
				num2 = 44
				Dim enumerator4 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				While enumerator4.MoveNext()
					Dim obj3 As Object = enumerator4.Current
					Dim ooooOoooo3 As PictureViewer.OOooOoooo = CType(obj3, PictureViewer.OOooOoooo)
					IL_301:
					num2 = 45
					Dim text As String = ooooOoooo3.Tag.ToString()
					IL_312:
					num2 = 46
					If Me.FTPclient IsNot Nothing Then
						IL_31D:
						num2 = 47
						text = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
					End If
					IL_352:
					num2 = 48
					If ooooOoooo3.get_DownLoadState() = PictureViewer.o0o0.DownLoadByOther Then
						IL_35F:
						num2 = 49
						If OO_00oOO.FileSys.FileExists(text) Then
							IL_370:
							num2 = 50
							ooooOoooo3.set_DownLoadState(PictureViewer.o0o0.DownLoaded)
							IL_37B:
							num2 = 51
							ooooOoooo3.set_Canceled(False)
							IL_386:
							num2 = 52
							ooooOoooo3.set_Completed(False)
							IL_391:
							num2 = 53
							ooooOoooo3.set_Compared(True)
							Exit While
						End If
					End If
					IL_39E:
					num2 = 55
					If Not ooooOoooo3.get_Completed() AndAlso Not ooooOoooo3.get_Canceled() AndAlso ooooOoooo3.Tag IsNot Nothing Then
						IL_3BC:
						num2 = 56
						If OO_00oOO.FileSys.FileExists(text) Then
							IL_3CD:
							num2 = 57
							ooooOoooo3.Controls.Clear()
							IL_3DC:
							num2 = 58
							Me.o_o_O_Oo.OoOo. = True
							IL_3E6:
							num2 = 59
							Me.Box.Tag = ooooOoooo3
							IL_3F6:
							num2 = 60
							Me.Box.LoadAsync(text)
							Exit While
						End If
					End If
					IL_408:
					num2 = 62
				End While
				IL_417:
				num2 = 63
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
				IL_42F:
				num2 = 64
				If Me.o0._0OO. OrElse Not Me.AutoDownLoad OrElse Me.FTPclient Is Nothing OrElse Me.FTPclient.AsyncState <> Oo_0.OOoo0_OO__._o. OrElse Me.o.O__00. Then
					GoTo IL_7AB
				End If
				IL_46E:
				num2 = 65
				Dim num4 As Integer = 0
				IL_474:
				num2 = 66
				Dim enumerator5 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj4 As Object = enumerator5.Current
					Dim ooooOoooo4 As PictureViewer.OOooOoooo = CType(obj4, PictureViewer.OOooOoooo)
					IL_499:
					num2 = 67
					If ooooOoooo4.get_DownLoadState() = PictureViewer.o0o0.DownLoading Then
						IL_4A6:
						num2 = 68
						num4 += 1
						Exit While
					End If
					IL_4B1:
					num2 = 70
				End While
				IL_4BD:
				num2 = 71
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_4D5:
				num2 = 72
				If num4 <> 0 Then
					GoTo IL_7AB
				End If
				IL_4DF:
				num2 = 73
				Dim enumerator6 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				While enumerator6.MoveNext()
					Dim obj5 As Object = enumerator6.Current
					Dim ooooOoooo5 As PictureViewer.OOooOoooo = CType(obj5, PictureViewer.OOooOoooo)
					IL_507:
					num2 = 74
					If ooooOoooo5.get_DownLoadState() = PictureViewer.o0o0.Waiting Then
						IL_516:
						num2 = 75
						Dim text2 As String = ooooOoooo5.Tag.ToString()
						IL_527:
						num2 = 76
						Dim text3 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text2.Replace("/", "\").Trim(New Char() { "\"c })
						IL_55C:
						num2 = 77
						If O_O0OO.oO_00Ooo___0._..Contains(text2.ToLower()) Then
							IL_572:
							num2 = 78
							ooooOoooo5.set_DownLoadState(PictureViewer.o0o0.DownLoadByOther)
						Else
							IL_582:
							num2 = 80
							If Not OO_00oOO.FileSys.FileExists(text3) OrElse ooooOoooo5.get_Redownload() Then
								IL_59F:
								num2 = 81
								Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(text3)
								IL_5B0:
								num2 = 82
								If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
									IL_5C1:
									num2 = 83
									OO_00oOO.FileSys.CreateDirectory(parentPath)
								End If
								IL_5D0:
								num2 = 84
								ooooOoooo5.Controls.Clear()
								IL_5DF:
								num2 = 85
								ooooOoooo5.SizeMode = PictureBoxSizeMode.CenterImage
								IL_5EA:
								num2 = 86
								ooooOoooo5.Image = O_O0OO.o0_OO.000.()
								IL_5F9:
								num2 = 87
								ooooOoooo5.set_DownLoadState(PictureViewer.o0o0.DownLoading)
								IL_604:
								num2 = 88
								Me.o.O__00. = True
								IL_60E:
								num2 = 89
								If Me.O0.OO0OO..Count = 1 OrElse Me.C1PictureBox1.Tag Is ooooOoooo5 Then
									IL_62E:
									num2 = 90
									Me.C1PictureBox1.Visible = False
									IL_63D:
									num2 = 91
									Me.C1PictureBox2.Visible = True
									IL_64C:
									num2 = 92
									Me.C1PictureBox2.Image = O_O0OO.o0_OO.000.()
								End If
								IL_65F:
								num2 = 93
								O_O0OO.oO_00Ooo___0._..Add(text2.ToLower())
								IL_673:
								num2 = 94
								Me.O.oOOOO0. = text2.ToLower()
								IL_683:
								num2 = 95
								Me.FTPclient.O_O0Ooo_00.o.(text2, text3, False)
								Exit While
							End If
						End If
					End If
					IL_698:
					num2 = 97
				End While
				IL_6A7:
				num2 = 98
				If TypeOf enumerator6 Is IDisposable Then
					TryCast(enumerator6, IDisposable).Dispose()
				End If
				IL_6BF:
				num2 = 99
				If Me.o.O__00. OrElse Not Me.AutoUpdate Then
					GoTo IL_7AB
				End If
				IL_6D8:
				num2 = 100
				Dim enumerator7 As IEnumerator = Me.FlowLayoutPanel1.Controls.GetEnumerator()
				While enumerator7.MoveNext()
					Dim obj6 As Object = enumerator7.Current
					Dim ooooOoooo6 As PictureViewer.OOooOoooo = CType(obj6, PictureViewer.OOooOoooo)
					IL_700:
					num2 = 101
					If ooooOoooo6.get_Completed() AndAlso Not ooooOoooo6.get_Compared() Then
						IL_715:
						num2 = 102
						Dim text4 As String = ooooOoooo6.Tag.ToString()
						IL_726:
						num2 = 103
						Dim a_2 As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text4.Replace("/", "\").Trim(New Char() { "\"c })
						IL_75B:
						num2 = 104
						ooooOoooo6.set_Compared(True)
						IL_766:
						num2 = 105
						Me.o.O__00. = True
						IL_770:
						num2 = 106
						Me.FTPclient.O_O_0_O0.oOO.(text4, a_2)
						Exit While
					End If
					IL_784:
					num2 = 108
				End While
				IL_793:
				num2 = 109
				If TypeOf enumerator7 Is IDisposable Then
					TryCast(enumerator7, IDisposable).Dispose()
				End If
				IL_7AB:
				GoTo IL_9B5
				IL_2A7:
				num2 = 41
				GoTo IL_2AA
				IL_7B0:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_976:
				GoTo IL_9AA
				IL_978:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_988:
			Catch obj8 When endfilter(TypeOf obj7 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj8, Exception)
				GoTo IL_978
			End Try
			IL_9AA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_9B5:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001DB9 RID: 7609 RVA: 0x000BD2E8 File Offset: 0x000BB4E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As AsyncCompletedEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim ooooOoooo As PictureViewer.OOooOoooo = CType(Me.Box.Tag, PictureViewer.OOooOoooo)
				IL_1A:
				num2 = 3
				If ooooOoooo.FindForm() Is Nothing Then
					GoTo IL_1A9
				End If
				IL_27:
				num2 = 4
				If A_1.[Error] IsNot Nothing OrElse A_1.Cancelled Then
					GoTo IL_C6
				End If
				IL_3F:
				num2 = 5
				ooooOoooo.Controls.Clear()
				IL_4C:
				num2 = 6
				ooooOoooo.Image = Nothing
				IL_55:
				num2 = 7
				ooooOoooo.SizeMode = PictureBoxSizeMode.Zoom
				IL_5E:
				num2 = 8
				Me.OoOo.O00.(Me.Box.Image, CType(Me.Box.Tag, PictureViewer.OOooOoooo))
				IL_81:
				num2 = 9
				ooooOoooo.set_Canceled(False)
				IL_8B:
				num2 = 10
				ooooOoooo.set_Completed(True)
				IL_95:
				num2 = 11
				ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded)
				IL_9F:
				num2 = 12
				Me.Box.Image.Dispose()
				IL_B2:
				num2 = 13
				Me.Box.Image = Nothing
				GoTo IL_15C
				IL_C6:
				num2 = 15
				ooooOoooo.set_Canceled(True)
				IL_D0:
				num2 = 16
				ooooOoooo.set_Completed(False)
				IL_DA:
				num2 = 17
				If Me.FTPclient IsNot Nothing Then
					GoTo IL_F6
				End If
				IL_E5:
				num2 = 18
				ooooOoooo.Image = ooooOoooo.ErrorImage
				GoTo IL_15C
				IL_F6:
				num2 = 20
				ooooOoooo.Image = Nothing
				IL_100:
				num2 = 21
				Dim oOo_O As PictureViewer.oOo_O00 = New PictureViewer.oOo_O00(Me)
				IL_10B:
				num2 = 22
				oOo_O.Dock = DockStyle.Fill
				IL_116:
				num2 = 23
				oOo_O.AutoSize = False
				IL_121:
				num2 = 24
				oOo_O.TextAlign = ContentAlignment.MiddleCenter
				IL_12D:
				num2 = 25
				oOo_O.Text = OO_00oOO.FileSys.GetName(ooooOoooo.Tag.ToString())
				IL_14C:
				num2 = 26
				ooooOoooo.Controls.Add(oOo_O)
				IL_15C:
				num2 = 27
				If Not Me.O0O.o__0O. AndAlso Me.C1PictureBox1.Tag IsNot Me.Box.Tag Then
					GoTo IL_1FB
				End If
				IL_17F:
				num2 = 28
				Me.O__O.o_ooo0Oo_.(CType(Me.Box.Tag, PictureViewer.OOooOoooo), New EventArgs())
				IL_19D:
				num2 = 29
				Me.O0O.o__0O. = False
				GoTo IL_1FB
				IL_1A9:
				num2 = 31
				If Not((ooooOoooo.get_Completed() AndAlso ooooOoooo.Image IsNot Nothing AndAlso ooooOoooo.Image IsNot O_O0OO.o0_OO.000.()) And ooooOoooo.Image IsNot ooooOoooo.ErrorImage) Then
					GoTo IL_1FB
				End If
				IL_1E3:
				num2 = 32
				ooooOoooo.Image.Dispose()
				IL_1F1:
				num2 = 33
				ooooOoooo.Image = Nothing
				IL_1FB:
				ooooOoooo = Nothing
				IL_1FD:
				num2 = 35
				Me.o_o_O_Oo.OoOo. = False
				IL_207:
				GoTo IL_2E9
				IL_20C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2AA:
				GoTo IL_2DE
				IL_2AC:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2BC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2AC
			End Try
			IL_2DE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2E9:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001DBA RID: 7610 RVA: 0x000BD604 File Offset: 0x000BB804
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim caption As String = A_0
			If Operators.CompareString(Me.DataColumn.DefaultFolder, "", True) > 0 Then
				A_0 = Me.DataColumn.DefaultFolder.TrimEnd(New Char() { "\"c }) + "\" + A_0
			End If
			A_0 = ooO.OoO0o_o___.O.(A_0)
			Dim ooooOoooo As PictureViewer.OOooOoooo = New PictureViewer.OOooOoooo()
			ooooOoooo.Tag = A_0
			Main.OO_O.o..O0o__0_OO.o.().SetToolTip(ooooOoooo, caption)
			ooooOoooo.Size = New Size(56, 56)
			ooooOoooo.BorderStyle = BorderStyle.FixedSingle
			ooooOoooo.SizeMode = PictureBoxSizeMode.CenterImage
			AddHandler ooooOoooo.Click, AddressOf Me.O__O.o_ooo0Oo_.
			AddHandler ooooOoooo.DoubleClick, AddressOf Me.OO.O_.
			Me.FlowLayoutPanel1.Controls.Add(ooooOoooo)
			If Operators.CompareString(A_0, "", True) > 0 AndAlso c.OOOOO.o.().FileSystem.FileExists(A_0) Then
				ooooOoooo.Image = O_O0OO.o0_OO.000.()
				Return
			End If
			ooooOoooo.Image = ooooOoooo.ErrorImage
			ooooOoooo.set_Canceled(True)
		End Sub

		' Token: 0x06001DBB RID: 7611 RVA: 0x000BD70C File Offset: 0x000BB90C
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim ooooOoooo As PictureViewer.OOooOoooo = New PictureViewer.OOooOoooo()
			ooooOoooo.Tag = A_0
			Main.OO_O.o..O0o__0_OO.o.().SetToolTip(ooooOoooo, OO_00oOO.FileSys.GetName(A_0))
			ooooOoooo.Size = New Size(56, 56)
			ooooOoooo.BorderStyle = BorderStyle.FixedSingle
			ooooOoooo.SizeMode = PictureBoxSizeMode.CenterImage
			AddHandler ooooOoooo.Click, AddressOf Me.O__O.o_ooo0Oo_.
			AddHandler ooooOoooo.DoubleClick, AddressOf Me.OO.O_.
			Me.FlowLayoutPanel1.Controls.Add(ooooOoooo)
			A_0 = OO_00oOO.ProjectPath + "RemoteFiles\" + A_0.Replace("/", "\").Trim(New Char() { "\"c })
			If OO_00oOO.FileSys.FileExists(A_0) Then
				ooooOoooo.Image = O_O0OO.o0_OO.000.()
				Return
			End If
			Dim oOo_O As PictureViewer.oOo_O00 = New PictureViewer.oOo_O00(Me)
			oOo_O.Dock = DockStyle.Fill
			oOo_O.TextAlign = ContentAlignment.MiddleCenter
			oOo_O.AutoSize = False
			oOo_O.Text = OO_00oOO.FileSys.GetName(A_0)
			ooooOoooo.Controls.Add(oOo_O)
			ooooOoooo.set_Canceled(False)
		End Sub

		' Token: 0x06001DBC RID: 7612 RVA: 0x000BD820 File Offset: 0x000BBA20
		Private Sub <<EMPTY_NAME>>(A_0 As Image, A_1 As PictureViewer.OOooOoooo)
			Dim clientSize As Size = A_1.ClientSize
			A_1.Image = A_0.GetThumbnailImage(clientSize.Width, clientSize.Height, Nothing, 0)
		End Sub

		' Token: 0x06001DBD RID: 7613 RVA: 0x000BD858 File Offset: 0x000BBA58
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.C1PictureBox1.Tag = RuntimeHelpers.GetObjectValue(A_0)
			Dim ooooOoooo As PictureViewer.OOooOoooo = CType(A_0, PictureViewer.OOooOoooo)
			If Me.lblMark.Parent IsNot A_0 Then
				Me.lblMark.Top = -2
				Me.lblMark.Left = ooooOoooo.Width - Me.lblMark.Width + 2
				ooooOoooo.Controls.Add(Me.lblMark)
				Me.lblMark.Visible = True
			End If
			If Me.C1PictureBox1.Image IsNot Nothing Then
				Me.C1PictureBox1.Image.Dispose()
				Me.C1PictureBox1.Image = Nothing
			End If
			If ooooOoooo.get_Completed() Then
				Me.C1PictureBox1.Visible = True
				Me.C1PictureBox2.Visible = False
				Dim text As String = ooooOoooo.Tag.ToString()
				If Me.FTPclient IsNot Nothing Then
					text = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
				End If
				If OO_00oOO.FileSys.FileExists(text) Then
					Me.C1PictureBox1.Image = OO_00oOO.GetImage(text)
				End If
			ElseIf ooooOoooo.get_DownLoadState() = PictureViewer.o0o0.DownLoading Then
				Me.C1PictureBox1.Visible = False
				Me.C1PictureBox2.Visible = True
				Me.C1PictureBox2.Image = O_O0OO.o0_OO.000.()
			ElseIf ooooOoooo.get_Canceled() Then
				Me.C1PictureBox1.Visible = False
				Me.C1PictureBox2.Visible = True
				Me.C1PictureBox2.Image = Me.C1PictureBox2.ErrorImage
			End If
		End Sub

		' Token: 0x06001DBE RID: 7614 RVA: 0x000BD9EC File Offset: 0x000BBBEC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ooooOoooo As PictureViewer.OOooOoooo = CType(A_0, PictureViewer.OOooOoooo)
			If Me.FTPclient IsNot Nothing Then
				If ooooOoooo.get_Completed() AndAlso Control.ModifierKeys = Keys.None Then
					Me.oo0_.o___.(Me.Open, New EventArgs())
				Else
					Dim text As String = ooooOoooo.Tag.ToString()
					Dim a_ As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
					If O_O0OO.oO_00Ooo___0._..Contains(text.ToLower()) Then
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoadByOther)
						MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting)
					ooooOoooo.set_Redownload(True)
					If Not Me.AutoDownLoad Then
						Dim o_u3000O_u As O\u3000O\u3000 = New O\u3000O\u3000(Me.FTPclient, text, a_)
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoading)
						O_O0OO.oO_00Ooo___0._..Add(text.ToLower())
						If o_u3000O_u.ShowDialog() = DialogResult.OK Then
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded)
							ooooOoooo.set_Completed(False)
							ooooOoooo.set_Canceled(False)
						Else
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Canceled)
							ooooOoooo.set_Completed(False)
							ooooOoooo.set_Canceled(True)
						End If
						o_u3000O_u.Dispose()
					End If
				End If
			Else
				Me.oo0_.o___.(Me.Open, New EventArgs())
			End If
		End Sub

		' Token: 0x06001DBF RID: 7615 RVA: 0x000BDB24 File Offset: 0x000BBD24
		Private Sub <<EMPTY_NAME>>()
			If Me.C1PictureBox1.Image IsNot Nothing AndAlso Me.C1PictureBox1.Dock <> DockStyle.Fill Then
				Dim x As Integer = Math.Max(0, CInt(Math.Round(CDbl((Me.Panel2.ClientSize.Width - Me.C1PictureBox1.Size.Width)) / 2.0)))
				Dim y As Integer = Math.Max(0, CInt(Math.Round(CDbl((Me.Panel2.ClientSize.Height - Me.C1PictureBox1.Size.Height)) / 2.0)))
				Me.C1PictureBox1.Location = New Point(x, y)
			End If
		End Sub

		' Token: 0x06001DC0 RID: 7616 RVA: 0x000BDBE4 File Offset: 0x000BBDE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OoOo.O00.() Then
				Dim a_ As String
				If Operators.CompareString(Me.DataColumn.FileFilter, "", True) = 0 Then
					a_ = O_O0OO.o__._oo0O.()
				Else
					a_ = Me.DataColumn.FileFilter
				End If
				Dim list As List(Of String) = Oo00.O____0O._0.(Me.Table.Current.DataRow, Me.DataColumn, Me.FTPclient, a_)
				If list IsNot Nothing AndAlso list.Count > 0 Then
					Try
						For Each text As String In list
							If Operators.CompareString(text, "", True) > 0 AndAlso Not Me.oOo.o0Oo_.(text) Then
								Exit For
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.PictureSplitContainer.Panel2Collapsed = (Me.O0.OO0OO..Count <= 1)
				End If
			End If
		End Sub

		' Token: 0x06001DC1 RID: 7617 RVA: 0x000BDCC8 File Offset: 0x000BBEC8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim array As String() = New String() { "ico", "bmp", "gif", "jpg", "png", "tif", "wmf" }
			Dim text As String = Path.GetExtension(A_0).Substring(1)
			Dim result As Boolean
			If Array.IndexOf(Of String)(array, text.ToLower()) < 0 AndAlso MessageBox.Show("""" + OO_00oOO.FileSys.GetName(A_0) + """并非图片浏览器所支持的文件格式，是否确定要增加？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
				result = False
			Else
				Dim text2 As String = Me.o_O0.O0O.
				Dim maxLength As Integer = Me.DataColumn.BaseColumn.MaxLength
				If Operators.CompareString(Me.o_O0.O0O., "", True) > 0 Then
					Me.o_O0.O0O. += vbCrLf
				End If
				Me.o_O0.O0O. += A_0
				If Me.o_O0.O0O..Length > maxLength AndAlso maxLength > -1 Then
					Me.o_O0.O0O. = text2
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				Else
					Me.O_O0.OO. += 1
					Me.O0.OO0OO..Add(A_0)
					Me.bd.WriteValue()
					If Me.FTPclient Is Nothing Then
						Me.o_.0o_0o_o.(A_0)
					Else
						Me.o.o0o0.(A_0)
					End If
					Me.O0O.o__0O. = True
					Me.PictureSplitContainer.Panel2Collapsed = (Me.O0.OO0OO..Count <= 1)
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x170006BB RID: 1723
		' (get) Token: 0x06001DC2 RID: 7618 RVA: 0x000BDE48 File Offset: 0x000BC048
		Friend ReadOnly Property SelectedItem As String
			Get
				Dim result As String
				If Me.C1PictureBox1.Tag Is Nothing Then
					result = Nothing
				Else
					result = CType(Me.C1PictureBox1.Tag, Control).Tag.ToString()
				End If
				Return result
			End Get
		End Property

		' Token: 0x06001DC3 RID: 7619 RVA: 0x000BDE84 File Offset: 0x000BC084
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OoOo.O00.() AndAlso Me.C1PictureBox1.Tag IsNot Nothing Then
				Dim ooooOoooo As PictureViewer.OOooOoooo = CType(Me.C1PictureBox1.Tag, PictureViewer.OOooOoooo)
				Me.oO0__0O0o00._.(ooooOoooo.Tag.ToString())
			End If
		End Sub

		' Token: 0x06001DC4 RID: 7620 RVA: 0x000BDEC8 File Offset: 0x000BC0C8
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim ooooOoooo As PictureViewer.OOooOoooo = Nothing
			Try
				For Each obj As Object In Me.FlowLayoutPanel1.Controls
					Dim ooooOoooo2 As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
					If Operators.CompareString(ooooOoooo2.Tag.ToString(), A_0, True) = 0 Then
						ooooOoooo = ooooOoooo2
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If ooooOoooo IsNot Nothing Then
				Dim num As Integer = Me.FlowLayoutPanel1.Controls.IndexOf(ooooOoooo)
				Dim str As String = ""
				If num >= 0 Then
					Dim dataRow As DataRow = Me.Table.Current.DataRow
					Dim a_ As DataCol = Me.DataColumn
					If Oo00.OO.0O0o.(dataRow, a_, A_0) Then
						Me.FlowLayoutPanel1.Controls.Remove(ooooOoooo)
						Me.O0.OO0OO..Remove(Me.O0.OO0OO.(num))
						Dim num2 As Integer = Me.O0.OO0OO..Count - 1
						For i As Integer = 0 To num2
							If i > 0 Then
								str += vbCrLf
							End If
							str += Me.O0.OO0OO.(i)
						Next
						Me.o_O0.O0O. = str
						Me.bd.WriteValue()
						If Me.FlowLayoutPanel1.Controls.Count = 0 Then
							Me.C1PictureBox1.Image = Nothing
							Me.C1PictureBox1.Tag = Nothing
						Else
							If Me.FlowLayoutPanel1.Controls.Count - 1 < num Then
								num = Me.FlowLayoutPanel1.Controls.Count - 1
							End If
							ooooOoooo = CType(Me.FlowLayoutPanel1.Controls(num), PictureViewer.OOooOoooo)
							If ooooOoooo.get_Completed() Then
								Me.O__O.o_ooo0Oo_.(ooooOoooo, New EventArgs())
							End If
						End If
						Me.PictureSplitContainer.Panel2Collapsed = (Me.O0.OO0OO..Count <= 1)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001DC5 RID: 7621 RVA: 0x000BE0A8 File Offset: 0x000BC2A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OoOo.O00.() Then
				Dim dataRow As DataRow = Me.Table.Current.DataRow
				Dim a_ As DataCol = Me.DataColumn
				While Me.O0.OO0OO..Count > 0
					Dim a_2 As String = Me.O0.OO0OO.(0)
					If Not Oo00.OO.0O0o.(dataRow, a_, a_2) Then
						Exit While
					End If
					Me.O0.OO0OO..RemoveAt(0)
				End While
				If Me.O0.OO0OO..Count = 0 Then
					Me.C1PictureBox1.Image = Nothing
					Me.C1PictureBox1.Tag = Nothing
					Me.FlowLayoutPanel1.Controls.Clear()
					Me.o_O0.O0O. = ""
					Me.bd.WriteValue()
				Else
					Dim text As String = ""
					Dim num As Integer = Me.O0.OO0OO..Count - 1
					For i As Integer = 0 To num
						If i > 0 Then
							text += vbCrLf
						End If
						text += Me.O0.OO0OO.(i)
					Next
					Me.ImageFiles = text
				End If
				Me.PictureSplitContainer.Panel2Collapsed = (Me.O0.OO0OO..Count <= 1)
			End If
		End Sub

		' Token: 0x06001DC6 RID: 7622 RVA: 0x000BE1C8 File Offset: 0x000BC3C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Open.Enabled AndAlso Me.C1PictureBox1.Tag IsNot Nothing Then
				Dim dataRow As DataRow = Me.Table.Current.DataRow
				Dim a_ As DataCol = Me.DataColumn
				Dim ooooOoooo As PictureViewer.OOooOoooo = CType(Me.C1PictureBox1.Tag, PictureViewer.OOooOoooo)
				Dim a_2 As String = ooooOoooo.Tag.ToString()
				If ooooOoooo.get_Completed() OrElse Not Me.AutoDownLoad Then
					If Me.AutoDownLoad AndAlso Me.AutoUpdate Then
						Oo00.o00O0O_.O.(dataRow, a_, Me.FTPclient, a_2, False)
						Return
					End If
					Oo00.o00O0O_.O.(dataRow, a_, Me.FTPclient, a_2, Me.AutoUpdate)
					Return
				Else
					If Me.FTPclient IsNot Nothing Then
						MessageBox.Show("此文件未下载完成，无法打开！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
					MessageBox.Show("此文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x06001DC7 RID: 7623 RVA: 0x000BE2A0 File Offset: 0x000BC4A0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim bindingManagerBase As BindingManagerBase = MyBase.DataBindings(0).BindingManagerBase
			If bindingManagerBase.Position >= 1 Then
				bindingManagerBase.Position -= 1
			End If
		End Sub

		' Token: 0x06001DC8 RID: 7624 RVA: 0x000BE2D8 File Offset: 0x000BC4D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim bindingManagerBase As BindingManagerBase = MyBase.DataBindings(0).BindingManagerBase
			If bindingManagerBase.Position < bindingManagerBase.Count - 1 Then
				bindingManagerBase.Position += 1
			End If
		End Sub

		' Token: 0x06001DC9 RID: 7625 RVA: 0x000BE318 File Offset: 0x000BC518
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count <> 0 Then
				Dim o_u3000__u3000_u3002_u3002_u3002_u3000_u As O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 = New O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000()
				Dim pictureViewer As PictureViewer = o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.()
				pictureViewer.FTPclient = Me.FTPclient
				pictureViewer.Add.Enabled = Me.Add.Enabled
				pictureViewer.Delete.Enabled = Me.Delete.Enabled
				pictureViewer.Clear.Enabled = Me.Clear.Enabled
				pictureViewer.Open.Enabled = Me.Open.Enabled
				pictureViewer.SaveAs.Enabled = Me.SaveAs.Enabled
				pictureViewer.Manager.Enabled = Me.Manager.Enabled
				pictureViewer.lblConnect.Enabled = Me.lblConnect.Enabled
				pictureViewer.lblUpdate.Enabled = Me.lblUpdate.Enabled
				pictureViewer.Add.Visible = Me.Add.Visible
				pictureViewer.Delete.Visible = Me.Delete.Visible
				pictureViewer.Clear.Visible = Me.Clear.Visible
				pictureViewer.Open.Visible = Me.Open.Visible
				pictureViewer.SaveAs.Visible = Me.SaveAs.Visible
				pictureViewer.Manager.Visible = Me.Manager.Visible
				pictureViewer.lblConnect.Visible = Me.lblConnect.Visible
				pictureViewer.lblUpdate.Visible = Me.lblUpdate.Visible
				pictureViewer.AutoUpdate = Me.AutoUpdate
				pictureViewer.AutoDownLoad = False
				MyBase.DataBindings(0).WriteValue()
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.().DataBindings.Add("ImageFiles", RuntimeHelpers.GetObjectValue(MyBase.DataBindings(0).DataSource), MyBase.DataBindings(0).BindingMemberInfo.BindingMember)
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.ShowDialog()
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.Dispose()
				MyBase.DataBindings(0).ReadValue()
			End If
		End Sub

		' Token: 0x06001DCA RID: 7626 RVA: 0x000BE534 File Offset: 0x000BC734
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.Parent IsNot Nothing Then
				If Me.FTPclient Is Nothing Then
					Me.lblConnect.Visible = False
					Me.lblUpdate.Visible = False
				ElseIf Not Me.AutoDownLoad Then
					Me.lblUpdate.Visible = False
				End If
				AddHandler Application.Idle, AddressOf Me.oo_o000o_oo0.o.
				AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O__o.0o.
				AddHandler NetworkChange.NetworkAddressChanged, AddressOf Me.oo_o___._O0.
				Return
			End If
			RemoveHandler Application.Idle, AddressOf Me.oo_o000o_oo0.o.
			RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Me.O__o.0o.
			RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Me.oo_o___._O0.
			If Me.FTPclient IsNot Nothing Then
				If Me.FTPclient.Connected Then
					Me.FTPclient.Close()
				End If
				Me.FTPclient = Nothing
				If Operators.CompareString(Me.O.oOOOO0., "", True) > 0 AndAlso O_O0OO.oO_00Ooo___0._..Contains(Me.O.oOOOO0..ToLower()) Then
					O_O0OO.oO_00Ooo___0._..Remove(Me.O.oOOOO0..ToLower())
				End If
			End If
		End Sub

		' Token: 0x170006BC RID: 1724
		' (get) Token: 0x06001DCB RID: 7627 RVA: 0x000BE650 File Offset: 0x000BC850
		Friend ReadOnly Property DataColumn As DataCol
			Get
				Dim dataTable As DataTable = CType(Me.bd.DataSource, O_0).o_o.O0ooOo.()
				Return OO_00oOO.DataTables(dataTable.TableName).DataCols(Me.bd.BindingMemberInfo.BindingField)
			End Get
		End Property

		' Token: 0x06001DCC RID: 7628 RVA: 0x000BE6A0 File Offset: 0x000BC8A0
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Me.bm Is Nothing Then
				result = False
			ElseIf Me.bm.Position >= 0 Then
				Select Case Me.[ReadOnly]
					Case 0
						If Not Me.Table.AllowEdit Then
							result = False
						Else
							Dim row As DataRow = CType(Me.bm.Current, DataRowView).Row
							Dim bindingField As String = MyBase.DataBindings(0).BindingMemberInfo.BindingField
							Dim allowEdit As Boolean
							If Me.Table.Cols.Contains(bindingField) Then
								allowEdit = Me.Table.Cols(bindingField).AllowEdit
							Else
								allowEdit = Me.Table.DataTable.DataCols(bindingField).AllowEdit
							End If
							result = ((row.IsNull("_Locked") OrElse Not Conversions.ToBoolean(row("_Locked"))) AndAlso allowEdit)
						End If
					Case 1
						result = False
					Case 2
						result = True
				End Select
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x06001DCD RID: 7629 RVA: 0x000BE7B8 File Offset: 0x000BC9B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ConvertEventArgs)
			Dim dataRowView As DataRowView = CType(Me.bd.BindingManagerBase.Current, DataRowView)
			Dim bindingField As String = Me.bd.BindingMemberInfo.BindingField
			If Operators.CompareString(A_1.Value.ToString(), dataRowView(bindingField).ToString(), True) <> 0 Then
				Me.Table.O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.Table, dataRowView.Row, bindingField))
			End If
		End Sub

		' Token: 0x170006BD RID: 1725
		' (get) Token: 0x06001DCE RID: 7630 RVA: 0x000BE830 File Offset: 0x000BCA30
		Private ReadOnly Property Table As Table
			Get
				Dim result As Table
				If MyBase.DataBindings.Count > 0 Then
					If CType(Me.bd.DataSource, O_0).o_o.O0ooOo.().DataSet Is O_O0OO.OOOo.oo_OOOO_0.() Then
						result = OO_00oOO.Tables(CType(Me.bd.DataSource, O_0).Oo._Oo0OO.())
					Else
						result = Nothing
					End If
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x06001DCF RID: 7631 RVA: 0x000BE895 File Offset: 0x000BCA95
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a Is Nothing Then
				Me.a = Me.FTPclient.O_O_0_O0.oOO.()
			End If
			Me.a.OpenManager()
		End Sub

		' Token: 0x06001DD0 RID: 7632 RVA: 0x000BE8BB File Offset: 0x000BCABB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If A_1.Button = MouseButtons.Left Then
				Me.O.0O_o_. = A_1.X
				Me.O0O.o__0O. = A_1.Y
				Me.O0.OO0OO. = True
				Me.C1PictureBox1.Cursor = Cursors.Hand
			End If
		End Sub

		' Token: 0x06001DD1 RID: 7633 RVA: 0x000BE8FC File Offset: 0x000BCAFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer = Me.Panel2.HorizontalScroll.Value - (A_1.X - Me.O.0O_o_.)
			Dim num2 As Integer = Me.Panel2.VerticalScroll.Value - (A_1.Y - Me.O0O.o__0O.)
			If Me.O0.OO0OO. Then
				If Not(num >= 0 And num <= Me.Panel2.HorizontalScroll.Maximum) Then
					num = Me.Panel2.HorizontalScroll.Value
				End If
				If Not(num2 >= 0 And num2 <= Me.Panel2.VerticalScroll.Maximum) Then
					num2 = Me.Panel2.VerticalScroll.Value
				End If
				Me.Panel2.AutoScrollPosition = New Point(num, num2)
			End If
		End Sub

		' Token: 0x06001DD2 RID: 7634 RVA: 0x000BE9C3 File Offset: 0x000BCBC3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.O0.OO0OO. = False
			Me.C1PictureBox1.Cursor = Cursors.[Default]
		End Sub

		' Token: 0x06001DD3 RID: 7635 RVA: 0x000BE9DC File Offset: 0x000BCBDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.SizeMode = PictureBoxSizeMode.Zoom Then
				Me.SizeMode = PictureBoxSizeMode.AutoSize
				Return
			End If
			Me.SizeMode = PictureBoxSizeMode.Zoom
		End Sub

		' Token: 0x06001DD4 RID: 7636 RVA: 0x000BE9F8 File Offset: 0x000BCBF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.C1PictureBox1.Tag IsNot Nothing Then
				Dim text As String = CType(Me.C1PictureBox1.Tag, Control).Tag.ToString()
				If Me.FTPclient IsNot Nothing Then
					text = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
				End If
				If c.OOOOO.o.().FileSystem.FileExists(text) Then
					Try
						Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
						saveFileDialog.FileName = OO_00oOO.FileSys.GetName(text)
						saveFileDialog.Filter = Path.GetExtension(text).Trim(New Char() { "."c }) + "|*" + Path.GetExtension(text)
						If saveFileDialog.ShowDialog() = DialogResult.OK Then
							OO_00oOO.FileSys.CopyFile(text, saveFileDialog.FileName, True)
						End If
					Catch a_ As Exception
						ooO.oOo0Oo.o.(a_, "")
					End Try
				End If
			End If
		End Sub

		' Token: 0x06001DD5 RID: 7637 RVA: 0x000BEB04 File Offset: 0x000BCD04
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NetworkAvailabilityEventArgs)
			If Me.FTPclient IsNot Nothing Then
				Me.o0._0OO. = True
				Me.FTPclient.Connected = False
				Me.O.0O_o_. = DateTime.Now
			End If
		End Sub

		' Token: 0x06001DD6 RID: 7638 RVA: 0x000BEB2C File Offset: 0x000BCD2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.FTPclient IsNot Nothing Then
				Me.o0._0OO. = True
				Me.FTPclient.Connected = False
				Me.O.0O_o_. = DateTime.Now
			End If
		End Sub

		' Token: 0x06001DD7 RID: 7639 RVA: 0x000BEB54 File Offset: 0x000BCD54
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			If O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()) Then
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower())
			End If
			If Me.AutoDownLoad Then
				Me.o.O__00. = False
				Try
					For Each obj As Object In Me.FlowLayoutPanel1.Controls
						Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
						If Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, True) = 0 Then
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded)
							ooooOoooo.set_Canceled(False)
							ooooOoooo.set_Completed(False)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06001DD8 RID: 7640 RVA: 0x000BEC0C File Offset: 0x000BCE0C
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean)
			If O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()) Then
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower())
			End If
			If Me.AutoDownLoad Then
				Me.o.O__00. = False
				Try
					For Each obj As Object In Me.FlowLayoutPanel1.Controls
						Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
						If Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, True) = 0 Then
							ooooOoooo.set_Canceled(True)
							ooooOoooo.set_Completed(False)
							If A_1 Then
								ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting)
							Else
								ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Canceled)
							End If
							If MyBase.FindForm() IsNot Nothing AndAlso Not OO_00oOO.BaseMainForm.IsDisposed AndAlso Not Me.FTPclient.O0.o0. AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
								OO_00oOO.BaseMainForm.Invoke(AddressOf Me.oOo.o0Oo_., New Object() { ooooOoooo, A_0 })
								Exit For
							End If
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06001DD9 RID: 7641 RVA: 0x000BED2C File Offset: 0x000BCF2C
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			Me.o.O__00. = False
			If Not A_2 Then
				Try
					For Each obj As Object In Me.FlowLayoutPanel1.Controls
						Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
						If Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, True) = 0 Then
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting)
							ooooOoooo.set_Redownload(True)
							ooooOoooo.set_Canceled(False)
							ooooOoooo.set_Completed(True)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06001DDA RID: 7642 RVA: 0x000BEDC4 File Offset: 0x000BCFC4
		Private Sub <<EMPTY_NAME>>()
			Me.o.O__00. = False
			Me.o0._0OO. = False
		End Sub

		' Token: 0x06001DDB RID: 7643 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
		Private Sub <<EMPTY_NAME>>(A_0 As PictureViewer.OOooOoooo, A_1 As String)
			Dim oOo_O As PictureViewer.oOo_O00 = New PictureViewer.oOo_O00(Me)
			oOo_O.Dock = DockStyle.Fill
			oOo_O.TextAlign = ContentAlignment.MiddleCenter
			oOo_O.AutoSize = False
			oOo_O.Text = OO_00oOO.FileSys.GetName(A_1)
			A_0.Controls.Add(oOo_O)
			If Me.C1PictureBox2.Visible Then
				Me.C1PictureBox2.Visible = True
				Me.C1PictureBox1.Visible = False
				Me.C1PictureBox2.Image = Me.C1PictureBox2.ErrorImage
				If Me.C1PictureBox1.Tag Is Nothing Then
					Me.O__O.o_ooo0Oo_.(A_0, New EventArgs())
				End If
			End If
		End Sub

		' Token: 0x06001DDC RID: 7644 RVA: 0x000BEE70 File Offset: 0x000BD070
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.FTPclient IsNot Nothing AndAlso Not Me.FTPclient.Connected AndAlso Me.o0._0OO. AndAlso (DateTime.Now - Me.O.0O_o_.).TotalSeconds > 3.0 AndAlso NetworkInterface.GetIsNetworkAvailable() Then
				If Me.FTPclient.Connect() Then
					Me.o0._0OO. = False
					Return
				End If
				Me.O.0O_o_. = DateTime.Now.AddSeconds(8.0)
			End If
		End Sub

		' Token: 0x06001DDD RID: 7645 RVA: 0x000BEEF8 File Offset: 0x000BD0F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.FTPclient.Connected = False
			Me.FTPclient.Connect()
			If Me.FTPclient.Connected Then
				MessageBox.Show("已经重新连接FTP服务器!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			MessageBox.Show("重新连接FTP服务器失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		' Token: 0x06001DDE RID: 7646 RVA: 0x000BEF54 File Offset: 0x000BD154
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each obj As Object In Me.FlowLayoutPanel1.Controls
					Dim ooooOoooo As PictureViewer.OOooOoooo = CType(obj, PictureViewer.OOooOoooo)
					If ooooOoooo.get_DownLoadState() = PictureViewer.o0o0.Waiting OrElse ooooOoooo.get_DownLoadState() = PictureViewer.o0o0.DownLoaded Then
						Dim text As String = ooooOoooo.Tag.ToString()
						Dim file As String = OO_00oOO.ProjectPath + "RemoteFiles\" + text.Replace("/", "\").Trim(New Char() { "\"c })
						If OO_00oOO.FileSys.FileExists(file) Then
							OO_00oOO.FileSys.DeleteFile(file)
						End If
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06001DDF RID: 7647 RVA: 0x000BF01C File Offset: 0x000BD21C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.C1PictureBox1.Tag IsNot Nothing Then
				Me.OO.O_.(RuntimeHelpers.GetObjectValue(Me.C1PictureBox1.Tag), A_1)
			End If
		End Sub

		' Token: 0x06001DE0 RID: 7648 RVA: 0x000BF042 File Offset: 0x000BD242
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.lblMark.ForeColor = Color.Red
		End Sub

		' Token: 0x04000C5B RID: 3163
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C5C RID: 3164
		<AccessedThroughProperty("Panel2")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Panel

		' Token: 0x04000C5D RID: 3165
		<CompilerGenerated()>
		<AccessedThroughProperty("PrevRecord")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C5E RID: 3166
		<AccessedThroughProperty("NextRecord")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C5F RID: 3167
		<AccessedThroughProperty("Add")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C60 RID: 3168
		<CompilerGenerated()>
		<AccessedThroughProperty("Delete")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C61 RID: 3169
		<AccessedThroughProperty("Open")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C62 RID: 3170
		<AccessedThroughProperty("PictureSplitContainer")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04000C63 RID: 3171
		<AccessedThroughProperty("FlowLayoutPanel1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FlowLayoutPanel

		' Token: 0x04000C64 RID: 3172
		<AccessedThroughProperty("C1PictureBox1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PictureBox

		' Token: 0x04000C65 RID: 3173
		<AccessedThroughProperty("Clear")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C66 RID: 3174
		<CompilerGenerated()>
		<AccessedThroughProperty("Full")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C67 RID: 3175
		<AccessedThroughProperty("SplitContainer")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04000C68 RID: 3176
		<AccessedThroughProperty("Manager")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C69 RID: 3177
		<AccessedThroughProperty("Stretch")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C6A RID: 3178
		<AccessedThroughProperty("FlowLayoutPanel2")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FlowLayoutPanel

		' Token: 0x04000C6B RID: 3179
		<AccessedThroughProperty("SaveAs")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C6C RID: 3180
		<AccessedThroughProperty("Timer1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Timer

		' Token: 0x04000C6D RID: 3181
		<AccessedThroughProperty("lblConnect")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C6E RID: 3182
		<AccessedThroughProperty("lblUpdate")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C6F RID: 3183
		<AccessedThroughProperty("C1PictureBox2")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1PictureBox

		' Token: 0x04000C70 RID: 3184
		<CompilerGenerated()>
		<AccessedThroughProperty("Label1")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C71 RID: 3185
		<AccessedThroughProperty("lblMark")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C72 RID: 3186
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000C73 RID: 3187
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000C74 RID: 3188
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000C75 RID: 3189
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C76 RID: 3190
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000C77 RID: 3191
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000C78 RID: 3192
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000C79 RID: 3193
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C7A RID: 3194
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C7B RID: 3195
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000C7C RID: 3196
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C7D RID: 3197
		<CompilerGenerated()>
		<AccessedThroughProperty("_FTPClient")>
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04000C7E RID: 3198
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C7F RID: 3199
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C80 RID: 3200
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C81 RID: 3201
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000C82 RID: 3202
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C83 RID: 3203
		<CompilerGenerated()>
		<AccessedThroughProperty("bdm")>
		Private <<EMPTY_NAME>> As Binding

		' Token: 0x04000C84 RID: 3204
		<AccessedThroughProperty("Box")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PictureBox

		' Token: 0x04000C85 RID: 3205
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PictureViewer.O_O0_0_Ooo

		' Token: 0x04000C86 RID: 3206
		Private a As FTPClient

		' Token: 0x0200026B RID: 619
		' (Invoke) Token: 0x06001DE4 RID: 7652
		Public Delegate Sub O_O0_0_Ooo(A_0 As Object, A_1 As EventArgs)

		' Token: 0x0200026C RID: 620
		Friend Class OOooOoooo
			Inherits PictureBox

			' Token: 0x06001DE6 RID: 7654 RVA: 0x000BF05C File Offset: 0x000BD25C
			Friend Function get_Completed() As Boolean
				Return Me._Completed
			End Function

			' Token: 0x06001DE7 RID: 7655 RVA: 0x000BF064 File Offset: 0x000BD264
			Friend Sub set_Completed(value As Boolean)
				Me._Completed = value
			End Sub

			' Token: 0x06001DE8 RID: 7656 RVA: 0x000BF06D File Offset: 0x000BD26D
			Friend Function get_Canceled() As Boolean
				Return Me._Canceled
			End Function

			' Token: 0x06001DE9 RID: 7657 RVA: 0x000BF075 File Offset: 0x000BD275
			Friend Sub set_Canceled(value As Boolean)
				Me._Canceled = value
			End Sub

			' Token: 0x06001DEA RID: 7658 RVA: 0x000BF07E File Offset: 0x000BD27E
			Public Function get_DownLoadState() As PictureViewer.o0o0
				Return Me._DownLoadState
			End Function

			' Token: 0x06001DEB RID: 7659 RVA: 0x000BF086 File Offset: 0x000BD286
			Public Sub set_DownLoadState(value As PictureViewer.o0o0)
				Me._DownLoadState = value
				If value = PictureViewer.o0o0.DownLoading Then
					Me.set_Compared(True)
					Me.set_Redownload(False)
				End If
			End Sub

			' Token: 0x06001DEC RID: 7660 RVA: 0x000BF0A1 File Offset: 0x000BD2A1
			Public Function get_Compared() As Boolean
				Return Me._Compared
			End Function

			' Token: 0x06001DED RID: 7661 RVA: 0x000BF0A9 File Offset: 0x000BD2A9
			Public Sub set_Compared(value As Boolean)
				Me._Compared = value
			End Sub

			' Token: 0x06001DEE RID: 7662 RVA: 0x000BF0B2 File Offset: 0x000BD2B2
			Friend Function get_Redownload() As Boolean
				Return Me._Redownload
			End Function

			' Token: 0x06001DEF RID: 7663 RVA: 0x000BF0BA File Offset: 0x000BD2BA
			Friend Sub set_Redownload(value As Boolean)
				Me._Redownload = value
			End Sub

			' Token: 0x04000C87 RID: 3207
			Private _Completed As Boolean

			' Token: 0x04000C88 RID: 3208
			Private _Canceled As Boolean

			' Token: 0x04000C89 RID: 3209
			Private _Loading As Boolean

			' Token: 0x04000C8A RID: 3210
			Private _DownLoadState As PictureViewer.o0o0

			' Token: 0x04000C8B RID: 3211
			Private _Compared As Boolean

			' Token: 0x04000C8C RID: 3212
			Private _Redownload As Boolean
		End Class

		' Token: 0x0200026D RID: 621
		Friend Class oOo_O00
			Inherits Label

			' Token: 0x06001DF0 RID: 7664 RVA: 0x000BF0C4 File Offset: 0x000BD2C4
			Friend Sub New(A_0 As PictureViewer)
				AddHandler MyBase.Click, AddressOf Me.MyLabel_Click
				AddHandler MyBase.DoubleClick, AddressOf Me.MyLabel_DoubleClick
				Me.piv = A_0
				Main.OO_O.o..O0o__0_OO.o.().SetToolTip(Me, "双击下载或更新文件！")
			End Sub

			' Token: 0x06001DF1 RID: 7665 RVA: 0x000BF117 File Offset: 0x000BD317
			Private Sub MyLabel_Click(sender As Object, e As EventArgs)
				If MyBase.Parent IsNot Nothing Then
					Me.piv.O__O.o_ooo0Oo_.(MyBase.Parent, e)
				End If
			End Sub

			' Token: 0x06001DF2 RID: 7666 RVA: 0x000BF133 File Offset: 0x000BD333
			Private Sub MyLabel_DoubleClick(sender As Object, e As EventArgs)
				If MyBase.Parent IsNot Nothing Then
					Me.piv.OO.O_.(MyBase.Parent, e)
				End If
			End Sub

			' Token: 0x04000C8D RID: 3213
			Private piv As PictureViewer
		End Class

		' Token: 0x0200026E RID: 622
		Friend Enum o0o0
			' Token: 0x04000C8F RID: 3215
			Waiting
			' Token: 0x04000C90 RID: 3216
			DownLoading
			' Token: 0x04000C91 RID: 3217
			DownLoaded
			' Token: 0x04000C92 RID: 3218
			Canceled
			' Token: 0x04000C93 RID: 3219
			DownLoadByOther
		End Enum

		' Token: 0x0200026F RID: 623
		' (Invoke) Token: 0x06001DF6 RID: 7670
		Public Delegate Sub O_0000O(A_0 As PictureViewer.OOooOoooo, A_1 As String)
	End Class
End Namespace
