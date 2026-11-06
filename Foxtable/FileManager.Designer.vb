Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000266 RID: 614
	<DesignerGenerated()>
	Friend Class FileManager
		Inherits UserControl

		' Token: 0x06001D1F RID: 7455 RVA: 0x000B8AD2 File Offset: 0x000B6CD2
		Public Sub New()
			AddHandler MyBase.ParentChanged, AddressOf Me.ooo_oOOO0.0_.
			Me.o0o___Oo0o_0.0. = True
			Me.OO_00O.ooO0O_. = True
			Me.O.___0_o_0o0_O. = True
			Me.o.0OO00oo0.()
		End Sub

		' Token: 0x06001D20 RID: 7456 RVA: 0x000B8B08 File Offset: 0x000B6D08
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.o0o___Oo0o_0.0. IsNot Nothing Then
					Me.o0o___Oo0o_0.0..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06001D21 RID: 7457 RVA: 0x000B8B48 File Offset: 0x000B6D48
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.ListBox1 = New ListBox()
			Me.Clear = New Label()
			Me.Open = New Label()
			Me.Add = New Label()
			Me.Delete = New Label()
			Me.SplitContainer1 = New SplitContainer()
			Me.FlowLayoutPanel1 = New FlowLayoutPanel()
			Me.Folder = New Label()
			Me.Manager = New Label()
			Me.SaveAs = New Label()
			Me.Connect = New Label()
			Me.FullView = New Label()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.ListBox1.Dock = DockStyle.Fill
			Me.ListBox1.FormattingEnabled = True
			Me.ListBox1.IntegralHeight = False
			Me.ListBox1.ItemHeight = 12
			Me.ListBox1.Location = New Point(0, 0)
			Me.ListBox1.Name = "ListBox1"
			Me.ListBox1.Size = New Size(367, 331)
			Me.ListBox1.TabIndex = 0
			Me.Clear.AutoSize = True
			Me.Clear.Cursor = Cursors.Hand
			Me.Clear.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Clear.ForeColor = Color.Blue
			Me.Clear.Location = New Point(120, 2)
			Me.Clear.Margin = New Padding(0, 0, 1, 0)
			Me.Clear.Name = "Clear"
			Me.Clear.Size = New Size(29, 12)
			Me.Clear.TabIndex = 6
			Me.Clear.Text = "清除"
			Me.Open.AutoSize = True
			Me.Open.Cursor = Cursors.Hand
			Me.Open.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Open.ForeColor = Color.Blue
			Me.Open.Location = New Point(60, 2)
			Me.Open.Margin = New Padding(0, 0, 1, 0)
			Me.Open.Name = "Open"
			Me.Open.Size = New Size(29, 12)
			Me.Open.TabIndex = 4
			Me.Open.Text = "打开"
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
			Me.Delete.Location = New Point(90, 2)
			Me.Delete.Margin = New Padding(0, 0, 1, 0)
			Me.Delete.Name = "Delete"
			Me.Delete.Size = New Size(29, 12)
			Me.Delete.TabIndex = 0
			Me.Delete.Text = "删除"
			Me.SplitContainer1.Dock = DockStyle.Fill
			Me.SplitContainer1.FixedPanel = FixedPanel.Panel2
			Me.SplitContainer1.IsSplitterFixed = True
			Me.SplitContainer1.Location = New Point(0, 0)
			Me.SplitContainer1.Name = "SplitContainer1"
			Me.SplitContainer1.Orientation = Orientation.Horizontal
			Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
			Me.SplitContainer1.Panel1MinSize = 15
			Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
			Me.SplitContainer1.Panel2MinSize = 16
			Me.SplitContainer1.Size = New Size(367, 353)
			Me.SplitContainer1.SplitterDistance = 331
			Me.SplitContainer1.TabIndex = 3
			Me.FlowLayoutPanel1.Controls.Add(Me.Add)
			Me.FlowLayoutPanel1.Controls.Add(Me.Folder)
			Me.FlowLayoutPanel1.Controls.Add(Me.Open)
			Me.FlowLayoutPanel1.Controls.Add(Me.Delete)
			Me.FlowLayoutPanel1.Controls.Add(Me.Clear)
			Me.FlowLayoutPanel1.Controls.Add(Me.Manager)
			Me.FlowLayoutPanel1.Controls.Add(Me.SaveAs)
			Me.FlowLayoutPanel1.Controls.Add(Me.Connect)
			Me.FlowLayoutPanel1.Controls.Add(Me.FullView)
			Me.FlowLayoutPanel1.Dock = DockStyle.Fill
			Me.FlowLayoutPanel1.Location = New Point(0, 0)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Padding = New Padding(0, 2, 0, 0)
			Me.FlowLayoutPanel1.Size = New Size(367, 18)
			Me.FlowLayoutPanel1.TabIndex = 9
			Me.Folder.AutoSize = True
			Me.Folder.Cursor = Cursors.Hand
			Me.Folder.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Folder.ForeColor = Color.Blue
			Me.Folder.Location = New Point(30, 2)
			Me.Folder.Margin = New Padding(0, 0, 1, 0)
			Me.Folder.Name = "Folder"
			Me.Folder.Size = New Size(29, 12)
			Me.Folder.TabIndex = 10
			Me.Folder.Text = "目录"
			Me.Manager.AutoSize = True
			Me.Manager.Cursor = Cursors.Hand
			Me.Manager.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Manager.ForeColor = Color.Blue
			Me.Manager.Location = New Point(150, 2)
			Me.Manager.Margin = New Padding(0, 0, 1, 0)
			Me.Manager.Name = "Manager"
			Me.Manager.Size = New Size(29, 12)
			Me.Manager.TabIndex = 7
			Me.Manager.Text = "管理"
			Me.Manager.Visible = False
			Me.SaveAs.AutoSize = True
			Me.SaveAs.Cursor = Cursors.Hand
			Me.SaveAs.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.SaveAs.ForeColor = Color.Blue
			Me.SaveAs.Location = New Point(180, 2)
			Me.SaveAs.Margin = New Padding(0, 0, 1, 0)
			Me.SaveAs.Name = "SaveAs"
			Me.SaveAs.Size = New Size(29, 12)
			Me.SaveAs.TabIndex = 9
			Me.SaveAs.Text = "另存"
			Me.Connect.AutoSize = True
			Me.Connect.Cursor = Cursors.Hand
			Me.Connect.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.Connect.ForeColor = Color.Blue
			Me.Connect.Location = New Point(210, 2)
			Me.Connect.Margin = New Padding(0, 0, 1, 0)
			Me.Connect.Name = "Connect"
			Me.Connect.Size = New Size(29, 12)
			Me.Connect.TabIndex = 11
			Me.Connect.Text = "重连"
			Me.FullView.AutoSize = True
			Me.FullView.Cursor = Cursors.Hand
			Me.FullView.Font = New Font("宋体", 9F, FontStyle.Underline, GraphicsUnit.Point, 134)
			Me.FullView.ForeColor = Color.Blue
			Me.FullView.Location = New Point(240, 2)
			Me.FullView.Margin = New Padding(0, 0, 1, 0)
			Me.FullView.Name = "FullView"
			Me.FullView.Size = New Size(29, 12)
			Me.FullView.TabIndex = 12
			Me.FullView.Text = "看图"
			Me.FullView.Visible = False
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Controls.Add(Me.SplitContainer1)
			MyBase.Name = "o..O.00."
			MyBase.Size = New Size(367, 353)
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			Me.SplitContainer1.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			Me.FlowLayoutPanel1.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x17000682 RID: 1666
		' (get) Token: 0x06001D22 RID: 7458 RVA: 0x000B95A6 File Offset: 0x000B77A6
		' (set) Token: 0x06001D23 RID: 7459 RVA: 0x000B95B0 File Offset: 0x000B77B0
		Friend Overridable Property ListBox1 As ListBox
			<CompilerGenerated()>
			Get
				Return Me.o0o___Oo0o_0.0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.o_oo0_._O.
				Dim listBox As ListBox = Me.o0o___Oo0o_0.0.
				If listBox IsNot Nothing Then
					RemoveHandler listBox.DoubleClick, value2
				End If
				Me.o0o___Oo0o_0.0. = value
				listBox = Me.o0o___Oo0o_0.0.
				If listBox IsNot Nothing Then
					AddHandler listBox.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000683 RID: 1667
		' (get) Token: 0x06001D24 RID: 7460 RVA: 0x000B95F3 File Offset: 0x000B77F3
		' (set) Token: 0x06001D25 RID: 7461 RVA: 0x000B95FC File Offset: 0x000B77FC
		Friend Overridable Property Clear As Label
			<CompilerGenerated()>
			Get
				Return Me.OoO._o_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.O0O._o000_.
				Dim ooO._o_. As Label = Me.OoO._o_.
				If ooO._o_. IsNot Nothing Then
					RemoveHandler ooO._o_..Click, value2
				End If
				Me.OoO._o_. = value
				ooO._o_. = Me.OoO._o_.
				If ooO._o_. IsNot Nothing Then
					AddHandler ooO._o_..Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000684 RID: 1668
		' (get) Token: 0x06001D26 RID: 7462 RVA: 0x000B963F File Offset: 0x000B783F
		' (set) Token: 0x06001D27 RID: 7463 RVA: 0x000B9648 File Offset: 0x000B7848
		Friend Overridable Property Open As Label
			<CompilerGenerated()>
			Get
				Return Me.OoO.o.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.OoOo_0ooO.O_0.
				Dim ooO.o. As Label = Me.OoO.o.
				If ooO.o. IsNot Nothing Then
					RemoveHandler ooO.o..Click, value2
				End If
				Me.OoO.o. = value
				ooO.o. = Me.OoO.o.
				If ooO.o. IsNot Nothing Then
					AddHandler ooO.o..Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000685 RID: 1669
		' (get) Token: 0x06001D28 RID: 7464 RVA: 0x000B968B File Offset: 0x000B788B
		' (set) Token: 0x06001D29 RID: 7465 RVA: 0x000B9694 File Offset: 0x000B7894
		Friend Overridable Property Add As Label
			<CompilerGenerated()>
			Get
				Return Me.O.___0_o_0o0_O.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o0O__0o.o_o.
				Dim o.___0_o_0o0_O. As Label = Me.O.___0_o_0o0_O.
				If o.___0_o_0o0_O. IsNot Nothing Then
					RemoveHandler o.___0_o_0o0_O..Click, value2
				End If
				Me.O.___0_o_0o0_O. = value
				o.___0_o_0o0_O. = Me.O.___0_o_0o0_O.
				If o.___0_o_0o0_O. IsNot Nothing Then
					AddHandler o.___0_o_0o0_O..Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000686 RID: 1670
		' (get) Token: 0x06001D2A RID: 7466 RVA: 0x000B96D7 File Offset: 0x000B78D7
		' (set) Token: 0x06001D2B RID: 7467 RVA: 0x000B96E0 File Offset: 0x000B78E0
		Friend Overridable Property Delete As Label
			<CompilerGenerated()>
			Get
				Return Me.OoO.Ooo___.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o_00.oO0.
				Dim ooO.Ooo___. As Label = Me.OoO.Ooo___.
				If ooO.Ooo___. IsNot Nothing Then
					RemoveHandler ooO.Ooo___..Click, value2
				End If
				Me.OoO.Ooo___. = value
				ooO.Ooo___. = Me.OoO.Ooo___.
				If ooO.Ooo___. IsNot Nothing Then
					AddHandler ooO.Ooo___..Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000687 RID: 1671
		' (get) Token: 0x06001D2C RID: 7468 RVA: 0x000B9723 File Offset: 0x000B7923
		' (set) Token: 0x06001D2D RID: 7469 RVA: 0x000B972B File Offset: 0x000B792B
		Friend Overridable Property SplitContainer1 As SplitContainer

		' Token: 0x17000688 RID: 1672
		' (get) Token: 0x06001D2E RID: 7470 RVA: 0x000B9734 File Offset: 0x000B7934
		' (set) Token: 0x06001D2F RID: 7471 RVA: 0x000B973C File Offset: 0x000B793C
		Friend Overridable Property Manager As Label
			<CompilerGenerated()>
			Get
				Return Me.oO.O0.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o_._oOo0OOo.
				Dim label As Label = Me.oO.O0.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.oO.O0. = value
				label = Me.oO.O0.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000689 RID: 1673
		' (get) Token: 0x06001D30 RID: 7472 RVA: 0x000B977F File Offset: 0x000B797F
		' (set) Token: 0x06001D31 RID: 7473 RVA: 0x000B9787 File Offset: 0x000B7987
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700068A RID: 1674
		' (get) Token: 0x06001D32 RID: 7474 RVA: 0x000B9790 File Offset: 0x000B7990
		' (set) Token: 0x06001D33 RID: 7475 RVA: 0x000B9798 File Offset: 0x000B7998
		Friend Overridable Property SaveAs As Label
			<CompilerGenerated()>
			Get
				Return Me.o_O.o_Oo_oO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.oo._00o_0_O__.
				Dim label As Label = Me.o_O.o_Oo_oO.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.o_O.o_Oo_oO. = value
				label = Me.o_O.o_Oo_oO.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700068B RID: 1675
		' (get) Token: 0x06001D34 RID: 7476 RVA: 0x000B97DB File Offset: 0x000B79DB
		' (set) Token: 0x06001D35 RID: 7477 RVA: 0x000B97E4 File Offset: 0x000B79E4
		Friend Overridable Property Folder As Label
			<CompilerGenerated()>
			Get
				Return Me.Oo._O_0o.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Oo_oo0o0_0.o_O.
				Dim oo._O_0o. As Label = Me.Oo._O_0o.
				If oo._O_0o. IsNot Nothing Then
					RemoveHandler oo._O_0o..Click, value2
				End If
				Me.Oo._O_0o. = value
				oo._O_0o. = Me.Oo._O_0o.
				If oo._O_0o. IsNot Nothing Then
					AddHandler oo._O_0o..Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700068C RID: 1676
		' (get) Token: 0x06001D36 RID: 7478 RVA: 0x000B9827 File Offset: 0x000B7A27
		' (set) Token: 0x06001D37 RID: 7479 RVA: 0x000B9830 File Offset: 0x000B7A30
		Friend Overridable Property Connect As Label
			<CompilerGenerated()>
			Get
				Return Me.O0_._ooo.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.OOOOOO.0O0.
				Dim o0_._ooo. As Label = Me.O0_._ooo.
				If o0_._ooo. IsNot Nothing Then
					RemoveHandler o0_._ooo..Click, value2
				End If
				Me.O0_._ooo. = value
				o0_._ooo. = Me.O0_._ooo.
				If o0_._ooo. IsNot Nothing Then
					AddHandler o0_._ooo..Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700068D RID: 1677
		' (get) Token: 0x06001D38 RID: 7480 RVA: 0x000B9873 File Offset: 0x000B7A73
		' (set) Token: 0x06001D39 RID: 7481 RVA: 0x000B987C File Offset: 0x000B7A7C
		Friend Overridable Property FullView As Label
			<CompilerGenerated()>
			Get
				Return Me.o.0o_OoO_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.o0O0o_O.O0.
				Dim label As Label = Me.o.0o_OoO_.
				If label IsNot Nothing Then
					RemoveHandler label.Click, value2
				End If
				Me.o.0o_OoO_. = value
				label = Me.o.0o_OoO_.
				If label IsNot Nothing Then
					AddHandler label.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700068E RID: 1678
		' (get) Token: 0x06001D3A RID: 7482 RVA: 0x000B98BF File Offset: 0x000B7ABF
		' (set) Token: 0x06001D3B RID: 7483 RVA: 0x000B98C8 File Offset: 0x000B7AC8
		Private Overridable Property bdm As Binding
			<CompilerGenerated()>
			Get
				Return Me.OoO._o_.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Binding)
				Dim value2 As ConvertEventHandler = AddressOf Me.O0oO_0._o_.
				Dim ooO._o_. As Binding = Me.OoO._o_.
				If ooO._o_. IsNot Nothing Then
					RemoveHandler ooO._o_..Parse, value2
				End If
				Me.OoO._o_. = value
				ooO._o_. = Me.OoO._o_.
				If ooO._o_. IsNot Nothing Then
					AddHandler ooO._o_..Parse, value2
				End If
			End Set
		End Property

		' Token: 0x1700068F RID: 1679
		' (get) Token: 0x06001D3C RID: 7484 RVA: 0x000B990B File Offset: 0x000B7B0B
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

		' Token: 0x17000690 RID: 1680
		' (get) Token: 0x06001D3D RID: 7485 RVA: 0x000B993C File Offset: 0x000B7B3C
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

		' Token: 0x17000691 RID: 1681
		' (get) Token: 0x06001D3E RID: 7486 RVA: 0x000B996E File Offset: 0x000B7B6E
		' (set) Token: 0x06001D3F RID: 7487 RVA: 0x000B9976 File Offset: 0x000B7B76
		Public Property AutoUpdate As Boolean
			Get
				Return Me.OO_00O.ooO0O_.
			End Get
			Set(value As Boolean)
				Me.OO_00O.ooO0O_. = value
			End Set
		End Property

		' Token: 0x17000692 RID: 1682
		' (get) Token: 0x06001D40 RID: 7488 RVA: 0x000B997F File Offset: 0x000B7B7F
		' (set) Token: 0x06001D41 RID: 7489 RVA: 0x000B9987 File Offset: 0x000B7B87
		Public Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o0o___Oo0o_0.0.
			End Get
			Set(value As BooleanEnum)
				Me.o0o___Oo0o_0.0. = value
			End Set
		End Property

		' Token: 0x17000693 RID: 1683
		' (get) Token: 0x06001D42 RID: 7490 RVA: 0x000B9990 File Offset: 0x000B7B90
		' (set) Token: 0x06001D43 RID: 7491 RVA: 0x000B9998 File Offset: 0x000B7B98
		Friend Property FTPclient As FTPClient
			Get
				Return Me.o0o___Oo0o_0.0.
			End Get
			Set(value As FTPClient)
				Me.o0o___Oo0o_0.0. = value
				Me.Manager.Visible = (value IsNot Nothing)
			End Set
		End Property

		' Token: 0x17000694 RID: 1684
		' (get) Token: 0x06001D44 RID: 7492 RVA: 0x000B99B0 File Offset: 0x000B7BB0
		' (set) Token: 0x06001D45 RID: 7493 RVA: 0x000B99B8 File Offset: 0x000B7BB8
		Public Property DoubleClickOpen As Boolean
			Get
				Return Me.O.___0_o_0o0_O.
			End Get
			Set(value As Boolean)
				Me.O.___0_o_0o0_O. = value
			End Set
		End Property

		' Token: 0x17000695 RID: 1685
		' (get) Token: 0x06001D46 RID: 7494 RVA: 0x000B99C1 File Offset: 0x000B7BC1
		' (set) Token: 0x06001D47 RID: 7495 RVA: 0x000B99CC File Offset: 0x000B7BCC
		Public Property FileString As String
			Get
				Return Me.OoO._o_.
			End Get
			Set(value As String)
				If Operators.CompareString(Me.OoO._o_., value, True) <> 0 Then
					Me.OoO._o_. = value
					Dim list As List(Of String) = New List(Of String)()
					Me.ListBox1.Items.Clear()
					If Operators.CompareString(value, "", True) > 0 Then
						list.AddRange(value.Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries))
					End If
					Me.ListBox1.Items.AddRange(list.ToArray())
					If Me.ListBox1.Items.Count > 0 Then
						Me.ListBox1.SelectedIndex = 0
					End If
				End If
			End Set
		End Property

		' Token: 0x06001D48 RID: 7496 RVA: 0x000B9A68 File Offset: 0x000B7C68
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0oO_0._o_.() Then
				Try
					For Each a_ As String In Oo00.O____0O._0.(Me.Table.Current.DataRow, Me.DataColumn, Me.FTPclient, "")
						If Not Me.O0oO_0._o_.(a_) Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x06001D49 RID: 7497 RVA: 0x000B9AE8 File Offset: 0x000B7CE8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Operators.CompareString(A_0, "", True) > 0 Then
				Dim ooO._o_. As String = Me.OoO._o_.
				If Operators.CompareString(Me.OoO._o_., "", True) > 0 Then
					Me.OoO._o_. += vbCrLf
				End If
				Me.OoO._o_. += A_0
				Dim maxLength As Integer = Me.DataColumn.BaseColumn.MaxLength
				If Me.OoO._o_..Length > maxLength AndAlso maxLength > -1 Then
					Me.OoO._o_. = ooO._o_.
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = False
				Else
					Me.ListBox1.Items.Add(A_0)
					Me.bd.WriteValue()
					Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x06001D4A RID: 7498 RVA: 0x000B9BC8 File Offset: 0x000B7DC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0oO_0._o_.() Then
				Dim text As String = Oo00.O____0O._0.(Me.Table.Current.DataRow, Me.DataColumn, Me.FTPclient, "")
				If Operators.CompareString(text, "", True) > 0 Then
					Me.O0oO_0._o_.(text)
				End If
			End If
		End Sub

		' Token: 0x06001D4B RID: 7499 RVA: 0x000B9C1C File Offset: 0x000B7E1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0oO_0._o_.() AndAlso Me.ListBox1.SelectedIndex >= 0 Then
				Dim a_ As String = Me.ListBox1.SelectedItem.ToString()
				Me.o0O0o_O.O0.(a_)
			End If
		End Sub

		' Token: 0x06001D4C RID: 7500 RVA: 0x000B9C58 File Offset: 0x000B7E58
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim num As Integer = -1
			Dim num2 As Integer = Me.ListBox1.Items.Count - 1
			For i As Integer = 0 To num2
				If Operators.CompareString(Me.ListBox1.Items(i).ToString(), A_0, True) = 0 Then
					num = i
					Exit For
				End If
			Next
			If num <> -1 Then
				If Not A_0.StartsWith("[") OrElse Not A_0.EndsWith("]") Then
					Dim dataRow As DataRow = Me.Table.Current.DataRow
					Dim a_ As DataCol = Me.DataColumn
					If Not Oo00.OO.0O0o.(dataRow, a_, A_0) Then
						Return
					End If
				End If
				Me.ListBox1.Items.RemoveAt(num)
				Dim text As String = ""
				Dim num3 As Integer = Me.ListBox1.Items.Count - 1
				For j As Integer = 0 To num3
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbCrLf
					End If
					text += Me.ListBox1.Items(j).ToString()
				Next
				Me.OoO._o_. = text
				Me.bd.WriteValue()
				If num <= Me.ListBox1.Items.Count - 1 Then
					Me.ListBox1.SelectedIndex = num
					Return
				End If
				If Me.ListBox1.Items.Count > 0 Then
					Me.ListBox1.SelectedIndex = Me.ListBox1.Items.Count - 1
				End If
			End If
		End Sub

		' Token: 0x06001D4D RID: 7501 RVA: 0x000B9DC8 File Offset: 0x000B7FC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0oO_0._o_.() Then
				Dim dataRow As DataRow = Me.Table.Current.DataRow
				Dim a_ As DataCol = Me.DataColumn
				While Me.ListBox1.Items.Count > 0
					Dim a_2 As String = Me.ListBox1.Items(0).ToString()
					If Not Oo00.OO.0O0o.(dataRow, a_, a_2) Then
						Exit While
					End If
					Me.ListBox1.Items.RemoveAt(0)
				End While
				If Me.ListBox1.Items.Count = 0 Then
					Me.OoO._o_. = ""
				Else
					Dim text As String = ""
					Dim num As Integer = Me.ListBox1.Items.Count - 1
					For i As Integer = 0 To num
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCrLf
						End If
						text += Me.ListBox1.Items(i).ToString()
					Next
					Me.OoO._o_. = text
				End If
				Me.bd.WriteValue()
			End If
		End Sub

		' Token: 0x06001D4E RID: 7502 RVA: 0x000B9ED4 File Offset: 0x000B80D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Open.Enabled AndAlso Me.ListBox1.SelectedIndex >= 0 Then
				Dim dataRow As DataRow = Me.Table.Current.DataRow
				Dim a_ As DataCol = Me.DataColumn
				Dim text As String = Me.ListBox1.SelectedItem.ToString()
				If Me.FTPclient IsNot Nothing Then
					Dim ftpdownloadEventArgs As FTPDownloadEventArgs = New FTPDownloadEventArgs(text, DateTime.MinValue, Me.FTPclient.FTPName)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", New Object() { ftpdownloadEventArgs }, True, "FTP", False)
					If ftpdownloadEventArgs.Cancel OrElse ftpdownloadEventArgs.CancelAll Then
						Return
					End If
				End If
				Dim flag As Boolean = Oo00.o00O0O_.O.(dataRow, a_, Me.FTPclient, text, Me.AutoUpdate)
				If Me.FTPclient IsNot Nothing AndAlso flag Then
					Dim ftpdownloadEventArgs2 As FTPDownloadEventArgs = New FTPDownloadEventArgs(text, DateTime.MinValue, Me.FTPclient.FTPName)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDownload", New Object() { ftpdownloadEventArgs2 }, True, "FTP", False)
				End If
			End If
		End Sub

		' Token: 0x06001D4F RID: 7503 RVA: 0x000B9FD9 File Offset: 0x000B81D9
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.Open.Enabled AndAlso Me.DoubleClickOpen Then
				Me.OoOo_0ooO.O_0.(Me.Open, New EventArgs())
			End If
		End Sub

		' Token: 0x17000696 RID: 1686
		' (get) Token: 0x06001D50 RID: 7504 RVA: 0x000BA004 File Offset: 0x000B8204
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

		' Token: 0x17000697 RID: 1687
		' (get) Token: 0x06001D51 RID: 7505 RVA: 0x000BA06C File Offset: 0x000B826C
		Friend ReadOnly Property DataColumn As DataCol
			Get
				Dim dataTable As DataTable = CType(Me.bd.DataSource, O_0).o_o.O0ooOo.()
				Return OO_00oOO.DataTables(dataTable.TableName).DataCols(Me.bd.BindingMemberInfo.BindingField)
			End Get
		End Property

		' Token: 0x06001D52 RID: 7506 RVA: 0x000BA0BC File Offset: 0x000B82BC
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

		' Token: 0x06001D53 RID: 7507 RVA: 0x000BA1D4 File Offset: 0x000B83D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ConvertEventArgs)
			Dim dataRowView As DataRowView = CType(Me.bd.BindingManagerBase.Current, DataRowView)
			Dim bindingField As String = Me.bd.BindingMemberInfo.BindingField
			If Operators.CompareString(A_1.Value.ToString(), dataRowView(bindingField).ToString(), True) <> 0 Then
				Me.Table.O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.Table, dataRowView.Row, bindingField))
			End If
		End Sub

		' Token: 0x06001D54 RID: 7508 RVA: 0x000BA24C File Offset: 0x000B844C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a Is Nothing Then
				Me.a = Me.FTPclient.O_O_0_O0.oOO.()
				Me.a.Ooo_Oo_O0.00O. = Me.FTPclient.Ooo_Oo_O0.00O.
			End If
			Me.a.OpenManager()
			Me.FTPclient.Ooo_Oo_O0.00O. = Me.a.Ooo_Oo_O0.00O.
		End Sub

		' Token: 0x06001D55 RID: 7509 RVA: 0x000BA2AC File Offset: 0x000B84AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.ListBox1.SelectedIndex >= 0 Then
				Dim dataRow As DataRow = Me.Table.Current.DataRow
				Dim a_ As DataCol = Me.DataColumn
				Dim text As String = Me.ListBox1.SelectedItem.ToString()
				If Not text.StartsWith("[") OrElse Not text.EndsWith("]") Then
					Oo00.o0_o._O_.(dataRow, a_, Me.FTPclient, text, Me.AutoUpdate)
				End If
			End If
		End Sub

		' Token: 0x06001D56 RID: 7510 RVA: 0x000BA320 File Offset: 0x000B8520
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.FTPclient.Connected = False
			Me.FTPclient.Connect()
			If Me.FTPclient.Connected Then
				MessageBox.Show("已经重新连接FTP服务器!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			MessageBox.Show("重新连接FTP服务器失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
		End Sub

		' Token: 0x06001D57 RID: 7511 RVA: 0x000BA37C File Offset: 0x000B857C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.FTPclient Is Nothing Then
				Me.Connect.Visible = False
			End If
			If MyBase.Parent Is Nothing AndAlso Me.FTPclient IsNot Nothing Then
				If Me.FTPclient.Connected Then
					Me.FTPclient.Close()
				End If
				Me.FTPclient = Nothing
			End If
		End Sub

		' Token: 0x06001D58 RID: 7512 RVA: 0x000BA3CC File Offset: 0x000B85CC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count <> 0 Then
				Dim o_u3000__u3000_u3002_u3002_u3002_u3000_u As O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 = New O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000()
				Dim pictureViewer As PictureViewer = o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.()
				pictureViewer.FTPclient = Me.FTPclient
				pictureViewer.Add.Enabled = Me.Add.Enabled
				pictureViewer.Delete.Enabled = Me.Delete.Enabled
				pictureViewer.Clear.Enabled = Me.Clear.Enabled
				pictureViewer.Open.Enabled = Me.Open.Enabled
				pictureViewer.Manager.Enabled = Me.Manager.Enabled
				pictureViewer.lblConnect.Enabled = Me.Connect.Enabled
				pictureViewer.Add.Visible = Me.Add.Visible
				pictureViewer.Delete.Visible = Me.Delete.Visible
				pictureViewer.Clear.Visible = Me.Clear.Visible
				pictureViewer.Open.Visible = Me.Open.Visible
				pictureViewer.Manager.Visible = Me.Manager.Visible
				pictureViewer.lblConnect.Visible = Me.Connect.Visible
				MyBase.DataBindings(0).WriteValue()
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.().DataBindings.Add("ImageFiles", RuntimeHelpers.GetObjectValue(MyBase.DataBindings(0).DataSource), MyBase.DataBindings(0).BindingMemberInfo.BindingMember)
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.ShowDialog()
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.Dispose()
				MyBase.DataBindings(0).ReadValue()
			End If
		End Sub

		' Token: 0x04000C40 RID: 3136
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C41 RID: 3137
		<CompilerGenerated()>
		<AccessedThroughProperty("ListBox1")>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04000C42 RID: 3138
		<CompilerGenerated()>
		<AccessedThroughProperty("Clear")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C43 RID: 3139
		<AccessedThroughProperty("Open")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C44 RID: 3140
		<AccessedThroughProperty("Add")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C45 RID: 3141
		<CompilerGenerated()>
		<AccessedThroughProperty("Delete")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C46 RID: 3142
		<CompilerGenerated()>
		<AccessedThroughProperty("SplitContainer1")>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04000C47 RID: 3143
		<CompilerGenerated()>
		<AccessedThroughProperty("Manager")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C48 RID: 3144
		<AccessedThroughProperty("FlowLayoutPanel1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FlowLayoutPanel

		' Token: 0x04000C49 RID: 3145
		<AccessedThroughProperty("SaveAs")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C4A RID: 3146
		<AccessedThroughProperty("Folder")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C4B RID: 3147
		<AccessedThroughProperty("Connect")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C4C RID: 3148
		<CompilerGenerated()>
		<AccessedThroughProperty("FullView")>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C4D RID: 3149
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C4E RID: 3150
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04000C4F RID: 3151
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000C50 RID: 3152
		Private <<EMPTY_NAME>> As FTPClient

		' Token: 0x04000C51 RID: 3153
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C52 RID: 3154
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C53 RID: 3155
		<CompilerGenerated()>
		<AccessedThroughProperty("bdm")>
		Private <<EMPTY_NAME>> As Binding

		' Token: 0x04000C54 RID: 3156
		Private a As FTPClient
	End Class
End Namespace
