Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B5 RID: 1205
	<DesignerGenerated()>
	Friend Partial Class o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000
		Inherits Form

		' Token: 0x06004DD1 RID: 19921 RVA: 0x00202874 File Offset: 0x00200A74
		<DebuggerNonUserCode()>
		Protected Overridable Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O.o0OO. IsNot Nothing Then
					Me.O.o0OO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004DD2 RID: 19922 RVA: 0x002028B4 File Offset: 0x00200AB4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O.o0OO. = New Container()
			Me.oO.o0.(New SplitContainer())
			Me.O_0__o_._oo0__.(New C1Button())
			Me.oO_oo0._.(New C1Button())
			Me.OO_O.o00.(New C1Button())
			Me.o_00O0.oo0_.(New C1Button())
			Me.Ooo0oO._00OOo.(New C1Button())
			Me.O0OOOo.__oOOO.(New C1Button())
			Me.OOoo0o.00.(New ListBox())
			Me.oO_oo0._.(New C1DockingTab())
			Me.O._0000Oo_O.(New C1DockingTabPage())
			Me.OOoo0o.00.(New PropertyGrid())
			Me.oO_oo0._.(New C1DockingTabPage())
			Me.OOoo0o.00.(New SplitContainer())
			Me.oO.o0.(New PropertyGrid())
			Me.OOoo0o.00.(New RichTextBox())
			Me.Ooo0.ooOOO0_.(New C1Button())
			Me.OOoo0o.00.(New ContextMenuStrip(Me.O.o0OO.))
			Me.O0O0_0.__0.(New C1Button())
			Me.oO0Oo.o.(New C1Button())
			Me.oO.o0.(New ContextMenuStrip(Me.O.o0OO.))
			Me.oO.0OOo.(New C1Button())
			Me.o_oo_.O.().Panel1.SuspendLayout()
			Me.o_oo_.O.().Panel2.SuspendLayout()
			Me.o_oo_.O.().SuspendLayout()
			Me.o_oo_.O.().BeginInit()
			Me.o_oo_.O.().SuspendLayout()
			Me.O.oooo0.().SuspendLayout()
			Me.o_oo_.O.().SuspendLayout()
			Me.o_00O0.oo0_.().Panel1.SuspendLayout()
			Me.o_00O0.oo0_.().Panel2.SuspendLayout()
			Me.o_00O0.oo0_.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.o_oo_.O.().Location = New Point(12, 12)
			Me.o_oo_.O.().Name = "SplitContainer1"
			Me.o_oo_.O.().Panel1.Controls.Add(Me.O00Oo.OO.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.O_o._O_OOo.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.OO_.__.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.O.O0O0oO.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.O__.__OOo.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.O00O.0_o_Oo.())
			Me.o_oo_.O.().Panel1.Controls.Add(Me.o_oo_.O.())
			Me.o_oo_.O.().Panel2.Controls.Add(Me.o_oo_.O.())
			Me.o_oo_.O.().Size = New Size(564, 351)
			Me.o_oo_.O.().SplitterDistance = 220
			Me.o_oo_.O.().TabIndex = 0
			Me.O00Oo.OO.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O00Oo.OO.().Location = New Point(171, 138)
			Me.O00Oo.OO.().Name = "btnCopy"
			Me.O00Oo.OO.().Size = New Size(44, 23)
			Me.O00Oo.OO.().TabIndex = 6
			Me.O00Oo.OO.().Text = "复制"
			Me.O00Oo.OO.().UseVisualStyleBackColor = True
			Me.O_o._O_OOo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O_o._O_OOo.().Location = New Point(171, 110)
			Me.O_o._O_OOo.().Name = "btnMove"
			Me.O_o._O_OOo.().Size = New Size(44, 23)
			Me.O_o._O_OOo.().TabIndex = 5
			Me.O_o._O_OOo.().Text = "转移"
			Me.O_o._O_OOo.().UseVisualStyleBackColor = True
			Me.OO_.__.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.OO_.__.().Location = New Point(171, 29)
			Me.OO_.__.().Name = "btnDelete"
			Me.OO_.__.().Size = New Size(44, 22)
			Me.OO_.__.().TabIndex = 4
			Me.OO_.__.().Text = "删除"
			Me.OO_.__.().UseVisualStyleBackColor = True
			Me.O.O0O0oO.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O.O0O0oO.().Location = New Point(171, 0)
			Me.O.O0O0oO.().Name = "btnAddItem"
			Me.O.O0O0oO.().Size = New Size(44, 24)
			Me.O.O0O0oO.().TabIndex = 3
			Me.O.O0O0oO.().Text = "增加"
			Me.O.O0O0oO.().UseVisualStyleBackColor = True
			Me.O__.__OOo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O__.__OOo.().Location = New Point(171, 83)
			Me.O__.__OOo.().Name = "btnMoveDown"
			Me.O__.__OOo.().Size = New Size(44, 22)
			Me.O__.__OOo.().TabIndex = 2
			Me.O__.__OOo.().UseVisualStyleBackColor = True
			Me.O00O.0_o_Oo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O00O.0_o_Oo.().Location = New Point(171, 56)
			Me.O00O.0_o_Oo.().Name = "btnMoveUp"
			Me.O00O.0_o_Oo.().Size = New Size(44, 22)
			Me.O00O.0_o_Oo.().TabIndex = 1
			Me.O00O.0_o_Oo.().UseVisualStyleBackColor = True
			Me.o_oo_.O.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.o_oo_.O.().FormattingEnabled = True
			Me.o_oo_.O.().IntegralHeight = False
			Me.o_oo_.O.().ItemHeight = 12
			Me.o_oo_.O.().Location = New Point(0, 0)
			Me.o_oo_.O.().Name = "ItemList"
			Me.o_oo_.O.().Size = New Size(169, 351)
			Me.o_oo_.O.().TabIndex = 0
			Me.o_oo_.O.().BorderStyle = BorderStyle.None
			Me.o_oo_.O.().Controls.Add(Me.O.oooo0.())
			Me.o_oo_.O.().Controls.Add(Me.o_oo_.O.())
			Me.o_oo_.O.().Dock = DockStyle.Fill
			Me.o_oo_.O.().Location = New Point(0, 0)
			Me.o_oo_.O.().Name = "C1DockingTab1"
			Me.o_oo_.O.().Size = New Size(340, 351)
			Me.o_oo_.O.().TabIndex = 0
			Me.o_oo_.O.().TabsSpacing = 0
			Me.o_oo_.O.().TabStyle = 1
			Me.o_oo_.O.().VisualStyle = 13
			Me.o_oo_.O.().VisualStyleBase = 13
			Me.O.oooo0.().Controls.Add(Me.o_oo_.O.())
			Me.O.oooo0.().Location = New Point(0, 25)
			Me.O.oooo0.().Name = "C1DockingTabPage1"
			Me.O.oooo0.().Size = New Size(340, 326)
			Me.O.oooo0.().TabIndex = 0
			Me.O.oooo0.().Text = "属性"
			Me.o_oo_.O.().Dock = DockStyle.Fill
			Me.o_oo_.O.().Location = New Point(0, 0)
			Me.o_oo_.O.().Name = "PropertyGrid1"
			Me.o_oo_.O.().Size = New Size(340, 326)
			Me.o_oo_.O.().TabIndex = 0
			Me.o_oo_.O.().ToolbarVisible = False
			Me.o_oo_.O.().Controls.Add(Me.o_00O0.oo0_.())
			Me.o_oo_.O.().Location = New Point(0, 25)
			Me.o_oo_.O.().Name = "C1DockingTabPage2"
			Me.o_oo_.O.().Size = New Size(340, 326)
			Me.o_oo_.O.().TabIndex = 1
			Me.o_oo_.O.().Text = "事件"
			Me.o_00O0.oo0_.().Dock = DockStyle.Fill
			Me.o_00O0.oo0_.().Location = New Point(0, 0)
			Me.o_00O0.oo0_.().Name = "SplitContainer2"
			Me.o_00O0.oo0_.().Orientation = Orientation.Horizontal
			Me.o_00O0.oo0_.().Panel1.Controls.Add(Me.O.oooo0.())
			Me.o_00O0.oo0_.().Panel2.Controls.Add(Me.ooO0.0o__0o.())
			Me.o_00O0.oo0_.().Size = New Size(340, 326)
			Me.o_00O0.oo0_.().SplitterDistance = 209
			Me.o_00O0.oo0_.().TabIndex = 1
			Me.O.oooo0.().Dock = DockStyle.Fill
			Me.O.oooo0.().Location = New Point(0, 0)
			Me.O.oooo0.().Name = "PropertyGrid2"
			Me.O.oooo0.().Size = New Size(340, 209)
			Me.O.oooo0.().TabIndex = 1
			Me.O.oooo0.().ToolbarVisible = False
			Me.ooO0.0o__0o.().BorderStyle = BorderStyle.FixedSingle
			Me.ooO0.0o__0o.().Dock = DockStyle.Fill
			Me.ooO0.0o__0o.().Location = New Point(0, 0)
			Me.ooO0.0o__0o.().Name = "txtCode"
			Me.ooO0.0o__0o.().[ReadOnly] = True
			Me.ooO0.0o__0o.().Size = New Size(340, 113)
			Me.ooO0.0o__0o.().TabIndex = 0
			Me.ooO0.0o__0o.().Text = ""
			Me.ooO0.0o__0o.().WordWrap = False
			Me.O_o.0o_00oO.().Location = New Point(12, 383)
			Me.O_o.0o_00oO.().Name = "btnPreview"
			Me.O_o.0o_00oO.().Size = New Size(75, 23)
			Me.O_o.0o_00oO.().TabIndex = 3
			Me.O_o.0o_00oO.().Text = "预览"
			Me.O_o.0o_00oO.().UseVisualStyleBackColor = True
			Me.o_oo_.O.().Name = "ContextMenuStrip1"
			Me.o_oo_.O.().Size = New Size(61, 4)
			Me.o._Oo_0_o___.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.o._Oo_0_o___.().Location = New Point(501, 383)
			Me.o._Oo_0_o___.().Name = "btnClose"
			Me.o._Oo_0_o___.().Size = New Size(75, 23)
			Me.o._Oo_0_o___.().TabIndex = 17
			Me.o._Oo_0_o___.().Tag = "pF5mMoKwO0QA4YUf9VDPmQ=="
			Me.o._Oo_0_o___.().Text = "取消"
			Me.o._Oo_0_o___.().UseVisualStyleBackColor = True
			Me.oo__o0o0O._Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oo__o0o0O._Oo.().Location = New Point(420, 383)
			Me.oo__o0o0O._Oo.().Name = "btnOK"
			Me.oo__o0o0O._Oo.().Size = New Size(75, 23)
			Me.oo__o0o0O._Oo.().TabIndex = 16
			Me.oo__o0o0O._Oo.().Text = "确定"
			Me.oo__o0o0O._Oo.().UseVisualStyleBackColor = True
			Me.O.oooo0.().Name = "ContextMenuStrip2"
			Me.O.oooo0.().Size = New Size(61, 4)
			Me.Oo_0.0O_oooO0o.().Location = New Point(94, 383)
			Me.Oo_0.0O_oooO0o.().Name = "btnApply"
			Me.Oo_0.0O_oooO0o.().Size = New Size(75, 23)
			Me.Oo_0.0O_oooO0o.().TabIndex = 18
			Me.Oo_0.0O_oooO0o.().Text = "应用"
			Me.Oo_0.0O_oooO0o.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(588, 418)
			MyBase.Controls.Add(Me.Oo_0.0O_oooO0o.())
			MyBase.Controls.Add(Me.o._Oo_0_o___.())
			MyBase.Controls.Add(Me.oo__o0o0O._Oo.())
			MyBase.Controls.Add(Me.o_oo_.O.())
			MyBase.Controls.Add(Me.O_o.0o_00oO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.0_O.0O.0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.Tag = "fUHg6lDLPWmmLJJ7+Cy6fsEib2L104N4STXJohiFow0SHiC7Tlg7tA=="
			Me.Text = "RibbonMenu项目设计器"
			Me.o_oo_.O.().Panel1.ResumeLayout(False)
			Me.o_oo_.O.().Panel2.ResumeLayout(False)
			Me.o_oo_.O.().ResumeLayout(False)
			Me.o_oo_.O.().EndInit()
			Me.o_oo_.O.().ResumeLayout(False)
			Me.O.oooo0.().ResumeLayout(False)
			Me.o_oo_.O.().ResumeLayout(False)
			Me.o_00O0.oo0_.().Panel1.ResumeLayout(False)
			Me.o_00O0.oo0_.().Panel2.ResumeLayout(False)
			Me.o_00O0.oo0_.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06004DD3 RID: 19923 RVA: 0x0020355D File Offset: 0x0020175D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.O.o0OO.
		End Function

		' Token: 0x06004DD4 RID: 19924 RVA: 0x00203565 File Offset: 0x00201765
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.O.o0OO. = A_0
		End Sub

		' Token: 0x06004DD5 RID: 19925 RVA: 0x0020356E File Offset: 0x0020176E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DD6 RID: 19926 RVA: 0x00203576 File Offset: 0x00201776
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DD7 RID: 19927 RVA: 0x0020357F File Offset: 0x0020177F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTab
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DD8 RID: 19928 RVA: 0x00203587 File Offset: 0x00201787
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTab)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DD9 RID: 19929 RVA: 0x00203590 File Offset: 0x00201790
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DDA RID: 19930 RVA: 0x00203598 File Offset: 0x00201798
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DDB RID: 19931 RVA: 0x002035A1 File Offset: 0x002017A1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DDC RID: 19932 RVA: 0x002035A9 File Offset: 0x002017A9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DDD RID: 19933 RVA: 0x002035B2 File Offset: 0x002017B2
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DockingTabPage
			Return Me.o_0._oo.
		End Function

		' Token: 0x06004DDE RID: 19934 RVA: 0x002035BA File Offset: 0x002017BA
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			Me.o_0._oo. = A_0
		End Sub

		' Token: 0x06004DDF RID: 19935 RVA: 0x002035C3 File Offset: 0x002017C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.oO.o00o00Oo_O.
		End Function

		' Token: 0x06004DE0 RID: 19936 RVA: 0x002035CB File Offset: 0x002017CB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.oO.o00o00Oo_O. = A_0
		End Sub

		' Token: 0x06004DE1 RID: 19937 RVA: 0x002035D4 File Offset: 0x002017D4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As PropertyGrid
			Return Me.o_0._oo.
		End Function

		' Token: 0x06004DE2 RID: 19938 RVA: 0x002035DC File Offset: 0x002017DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As PropertyGrid)
			Me.o_0._oo. = A_0
		End Sub

		' Token: 0x06004DE3 RID: 19939 RVA: 0x002035E5 File Offset: 0x002017E5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DE4 RID: 19940 RVA: 0x002035ED File Offset: 0x002017ED
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DE5 RID: 19941 RVA: 0x002035F6 File Offset: 0x002017F6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_._00_o.
		End Function

		' Token: 0x06004DE6 RID: 19942 RVA: 0x002035FE File Offset: 0x002017FE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_._00_o. = A_0
		End Sub

		' Token: 0x06004DE7 RID: 19943 RVA: 0x00203607 File Offset: 0x00201807
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__o__O_.0_0o.
		End Function

		' Token: 0x06004DE8 RID: 19944 RVA: 0x0020360F File Offset: 0x0020180F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O__o__O_.0_0o. = A_0
		End Sub

		' Token: 0x06004DE9 RID: 19945 RVA: 0x00203618 File Offset: 0x00201818
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOoOooo.__.
		End Function

		' Token: 0x06004DEA RID: 19946 RVA: 0x00203620 File Offset: 0x00201820
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OOoOooo.__. = A_0
		End Sub

		' Token: 0x06004DEB RID: 19947 RVA: 0x00203629 File Offset: 0x00201829
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0_OO0.0_O_o.
		End Function

		' Token: 0x06004DEC RID: 19948 RVA: 0x00203631 File Offset: 0x00201831
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oO0_OO0.0_O_o. = A_0
		End Sub

		' Token: 0x06004DED RID: 19949 RVA: 0x0020363A File Offset: 0x0020183A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DEE RID: 19950 RVA: 0x00203642 File Offset: 0x00201842
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DEF RID: 19951 RVA: 0x0020364B File Offset: 0x0020184B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.O__O00O00.
		End Function

		' Token: 0x06004DF0 RID: 19952 RVA: 0x00203653 File Offset: 0x00201853
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O.O__O00O00. = A_0
		End Sub

		' Token: 0x06004DF1 RID: 19953 RVA: 0x0020365C File Offset: 0x0020185C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0o0_.o__O_.
		End Function

		' Token: 0x06004DF2 RID: 19954 RVA: 0x00203664 File Offset: 0x00201864
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o0o0_.o__O_. = A_0
		End Sub

		' Token: 0x06004DF3 RID: 19955 RVA: 0x0020366D File Offset: 0x0020186D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_.0oo__oo.
		End Function

		' Token: 0x06004DF4 RID: 19956 RVA: 0x00203675 File Offset: 0x00201875
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oO_.0oo__oo. = A_0
		End Sub

		' Token: 0x06004DF5 RID: 19957 RVA: 0x0020367E File Offset: 0x0020187E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.o_0._oo.
		End Function

		' Token: 0x06004DF6 RID: 19958 RVA: 0x00203686 File Offset: 0x00201886
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.o_0._oo. = A_0
		End Sub

		' Token: 0x06004DF7 RID: 19959 RVA: 0x0020368F File Offset: 0x0020188F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooOO.oo_.
		End Function

		' Token: 0x06004DF8 RID: 19960 RVA: 0x00203697 File Offset: 0x00201897
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.ooOO.oo_. = A_0
		End Sub

		' Token: 0x06004DF9 RID: 19961 RVA: 0x002036A0 File Offset: 0x002018A0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RichTextBox
			Return Me.O.o0OO.
		End Function

		' Token: 0x06004DFA RID: 19962 RVA: 0x002036A8 File Offset: 0x002018A8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RichTextBox)
			Me.O.o0OO. = A_0
		End Sub

		' Token: 0x06004DFB RID: 19963 RVA: 0x002036B1 File Offset: 0x002018B1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.0__0_O.
		End Function

		' Token: 0x06004DFC RID: 19964 RVA: 0x002036BC File Offset: 0x002018BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oo0_O000o._0.
			Dim c1Button As C1Button = Me.o.0__0_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.0__0_O. = A_0
			c1Button = Me.o.0__0_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004DFD RID: 19965 RVA: 0x002036FF File Offset: 0x002018FF
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As CurrencyManager
			Return Me.o0.o__.
		End Function

		' Token: 0x06004DFE RID: 19966 RVA: 0x00203707 File Offset: 0x00201907
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As CurrencyManager)
			Me.o0.o__. = A_0
		End Sub

		' Token: 0x06004DFF RID: 19967 RVA: 0x00203710 File Offset: 0x00201910
		Public Sub New(A_0 As DataRow, A_1 As RibbonPaneEnum, A_2 As Form)
			Me.O.o0OO. = New DataSet()
			Me.ooO.Oo_. = RibbonPaneEnum.Left
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.O0oOO._.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				num = 3
				Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", New Object() { Me.o_oo_.O.() })
				IL_57:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_5E:
				num = 5
				Me.oO.o00o00Oo_O. = A_2
				IL_67:
				num = 6
				Me.ooO.Oo_. = A_0
				IL_70:
				num = 7
				Me.ooO.Oo_. = A_1
				IL_79:
				num = 8
				If A_0 IsNot Nothing Then
					GoTo IL_14D
				End If
				IL_81:
				num = 9
				Me.O.o0OO. = o_\u3002\u3002\u3000\u3000\u3002.oOoo_0O.oo00oO..oOoo_0O.oo00oO..DataTable.DefaultView.ToTable()
				IL_A3:
				num = 10
				If A_1 <> RibbonPaneEnum.Left Then
					GoTo IL_D6
				End If
				IL_A9:
				num = 11
				Me.O.o0OO. = New DataView(Me.O.o0OO., "[Type] = " + Conversions.ToString(5), "Index", DataViewRowState.CurrentRows)
				GoTo IL_141
				IL_D6:
				num = 13
				If A_1 <> RibbonPaneEnum.Right Then
					GoTo IL_10E
				End If
				IL_DD:
				num = 14
				Me.O.o0OO. = New DataView(Me.O.o0OO., "[Type] = " + Conversions.ToString(128), "Index", DataViewRowState.CurrentRows)
				GoTo IL_141
				IL_10E:
				num = 16
				If A_1 <> RibbonPaneEnum.Bottom Then
					GoTo IL_141
				End If
				IL_115:
				num = 17
				Me.O.o0OO. = New DataView(Me.O.o0OO., "[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows)
				IL_141:
				num = 18
				Me.ooO.Oo_. = RibbonItemTypeEnum.Ribbon
				GoTo IL_1C4
				IL_14D:
				num = 20
				Me.O.o0OO. = A_0.Table.DefaultView.ToTable()
				IL_166:
				num = 21
				Me.O.o0OO. = New DataView(Me.O.o0OO., "[ParentKey] = '" + Me.ooO.Oo_.("Key").ToString() + "' And [Pane] = " + Conversions.ToString(CInt(A_1)), "Index", DataViewRowState.CurrentRows)
				IL_1AB:
				num = 22
				Me.ooO.Oo_. = CType(Conversions.ToInteger(A_0("Type")), RibbonItemTypeEnum)
				IL_1C4:
				num = 23
				Dim thread As Thread = AddressOf o0OoOOoOOo0.o_OOo_0.0O.
				IL_1D9:
				num = 24
				thread.Start()
				IL_1E2:
				num = 25
				Me.O.o0OO..PrimaryKey = New DataColumn() { Me.O.o0OO..Columns("Key") }
				IL_20E:
				num = 26
				Me.O.o0OO..Tables.Add(Me.O.o0OO.)
				IL_227:
				num = 27
				Me.O.o0OO..Relations.Add("Ribbon", Me.O.o0OO..Columns("Key"), Me.O.o0OO..Columns("ParentKey"))
				IL_26A:
				num = 28
				Me.o_oo_.O.().DataSource = Me.O.o0OO.
				IL_27E:
				num = 29
				Me.o_oo_.O.().DisplayMember = "Name"
				IL_291:
				num = 30
				Me.OOoo0o.00.(CType(Me.BindingContext(Me.O.o0OO.), CurrencyManager))
				IL_2B0:
				num = 31
				Me.O.o0OO..AcceptChanges()
				IL_2BE:
				num = 32
				If Me.ooO.Oo_. IsNot Nothing Then
					GoTo IL_2E7
				End If
				IL_2C9:
				num = 33
				Me.O_o._O_OOo.().Visible = False
				IL_2D8:
				num = 34
				Me.O00Oo.OO.().Visible = False
				IL_2E7:
				GoTo IL_3C5
				IL_2EC:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_386:
				GoTo IL_3BA
				IL_388:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_398:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_388
			End Try
			IL_3BA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3C5:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004E00 RID: 19968 RVA: 0x00203B08 File Offset: 0x00201D08
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim form As Form = Me.oO.o00o00Oo_O.
			Me.oo__o0o0O._Oo.().PerformClick()
			If form IsNot Nothing Then
				If TypeOf form Is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 Then
					CType(form, o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000).Oo_0.0O_oooO0o.().PerformClick()
				End If
				If TypeOf form Is o_\u3002\u3002\u3000\u3000\u3002 Then
					CType(form, o_\u3002\u3002\u3000\u3000\u3002).oO.oO0oO__o.().PerformClick()
				End If
			End If
		End Sub

		' Token: 0x04002031 RID: 8241
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04002032 RID: 8242
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04002033 RID: 8243
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04002034 RID: 8244
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTab

		' Token: 0x04002035 RID: 8245
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04002036 RID: 8246
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x04002037 RID: 8247
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DockingTabPage

		' Token: 0x04002038 RID: 8248
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04002039 RID: 8249
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As PropertyGrid

		' Token: 0x0400203A RID: 8250
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400203B RID: 8251
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400203C RID: 8252
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400203D RID: 8253
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400203E RID: 8254
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400203F RID: 8255
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04002040 RID: 8256
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002041 RID: 8257
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002042 RID: 8258
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002043 RID: 8259
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04002044 RID: 8260
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002045 RID: 8261
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RichTextBox

		' Token: 0x04002046 RID: 8262
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04002047 RID: 8263
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x04002048 RID: 8264
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04002049 RID: 8265
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x0400204A RID: 8266
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x0400204B RID: 8267
		Private <<EMPTY_NAME>> As RibbonItemTypeEnum

		' Token: 0x0400204C RID: 8268
		Private <<EMPTY_NAME>> As RibbonPaneEnum

		' Token: 0x0400204D RID: 8269
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CurrencyManager

		' Token: 0x0400204E RID: 8270
		Friend <<EMPTY_NAME>> As Form

		' Token: 0x0400204F RID: 8271
		Friend <<EMPTY_NAME>> As Form

		' Token: 0x04002050 RID: 8272
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04002051 RID: 8273
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
