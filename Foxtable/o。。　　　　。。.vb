Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.XLS
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200044C RID: 1100
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000
		Inherits Form

		' Token: 0x06004883 RID: 18563 RVA: 0x001E995C File Offset: 0x001E7B5C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo._0. IsNot Nothing Then
					Me.oo._0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004884 RID: 18564 RVA: 0x001E999C File Offset: 0x001E7B9C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo._0. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000))
			Me.o_o00OO_.oo.(New C1Button())
			Me.oO0_O0OO_.o.(New C1ComboBox())
			Me.o_O__00o_0O.oo.(New ListBox())
			Me.oO0_O0OO_.o.(New ListBox())
			Me.oO0_O0OO_.o.(New C1CheckBox())
			Me.o0_.Oo.(New Timer(Me.oo._0.))
			Me.o_.oOoO0Ooooo0.(New C1Button())
			Me.OoOoo_0.0_o.(New C1Button())
			Me.OoO0o.0O0__.(New C1Button())
			Me.o_O__00o_0O.oo.(New C1Button())
			Me.oO0_O0OO_.o.(New C1Button())
			Me.OO.000oo_O00o.(New C1Button())
			Me.oOo0O0O.oO.(New C1Button())
			Me.O_00OO0._o.(New C1Button())
			Me.oO_o.00O.(New C1Button())
			Me.OOO__.oo0ooO_.(New C1Button())
			Me.O0o_ooO.__.(New C1Button())
			Me.O.0_OO0ooo0O0.().BeginInit()
			Me.O_Ooo_0Oo.00Oo.().BeginInit()
			Me.O_Ooo_0Oo.00Oo.().BeginInit()
			Me.o_o_.OOO0_Oo0.().BeginInit()
			Me.O0O0.0.().BeginInit()
			Me.O_Oo00._.().BeginInit()
			Me.o_o.O00OO0O0_.().BeginInit()
			Me.OoO__O_0_._.().BeginInit()
			Me.oO0oO0_0_O.oo.().BeginInit()
			Me.oo0__0.00.().BeginInit()
			Me.o0_o0oO.__.().BeginInit()
			Me.oOOoOO.O00OO_0.().BeginInit()
			Me.o_0.00o.().BeginInit()
			Me.o0.oO0O_OO.().BeginInit()
			MyBase.SuspendLayout()
			Me.O.0_OO0ooo0O0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O.0_OO0ooo0O0.().Location = New Point(176, 492)
			Me.O.0_OO0ooo0O0.().Name = "Button3"
			Me.O.0_OO0ooo0O0.().Size = New Size(98, 23)
			Me.O.0_OO0ooo0O0.().TabIndex = 4
			Me.O.0_OO0ooo0O0.().Text = "预览报表"
			Me.O.0_OO0ooo0O0.().UseVisualStyleBackColor = True
			Me.O_Ooo_0Oo.00Oo.().AllowSpinLoop = False
			Me.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_Ooo_0Oo.00Oo.().Cursor = Cursors.Arrow
			Me.O_Ooo_0Oo.00Oo.().DropDownStyle = 1
			Me.O_Ooo_0Oo.00Oo.().GapHeight = 0
			Me.O_Ooo_0Oo.00Oo.().ImagePadding = New Padding(0)
			Me.O_Ooo_0Oo.00Oo.().ItemsDisplayMember = ""
			Me.O_Ooo_0Oo.00Oo.().ItemsValueMember = ""
			Me.O_Ooo_0Oo.00Oo.().Location = New Point(7, 6)
			Me.O_Ooo_0Oo.00Oo.().Name = "cmbTables"
			Me.O_Ooo_0Oo.00Oo.().Size = New Size(267, 19)
			Me.O_Ooo_0Oo.00Oo.().TabIndex = 5
			Me.O_Ooo_0Oo.00Oo.().Tag = Nothing
			Me.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_Ooo_0Oo.00Oo.().FormattingEnabled = True
			Me.O_Ooo_0Oo.00Oo.().IntegralHeight = False
			Me.O_Ooo_0Oo.00Oo.().ItemHeight = 12
			Me.O_Ooo_0Oo.00Oo.().Location = New Point(7, 29)
			Me.O_Ooo_0Oo.00Oo.().Name = "lstCols"
			Me.O_Ooo_0Oo.00Oo.().Size = New Size(267, 217)
			Me.O_Ooo_0Oo.00Oo.().TabIndex = 6
			Me.oO.O_0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO.O_0.().FormattingEnabled = True
			Me.oO.O_0.().IntegralHeight = False
			Me.oO.O_0.().ItemHeight = 12
			Me.oO.O_0.().Items.AddRange(New Object() { "<表名>", "<ALL>", "<End>", "<Index>", "<GroupHeader>", "<GroupFooter>", "<HeaderRow>", "<FooterRow>", "[%Sum(列名)] - 分页或分组统计", "[%表名,Sum(列名)] - 统计关联表", "[#表名,Sum(列名)] - 统计已打印行", "[$表名,Sum(列名)] - 直接统计", "[&列名,X,Y,Width,Height] - 图片列", "[&&图片文件, X, Y, Width, Height]" })
			Me.oO.O_0.().Location = New Point(7, 276)
			Me.oO.O_0.().Name = "ListBox2"
			Me.oO.O_0.().Size = New Size(267, 176)
			Me.oO.O_0.().TabIndex = 7
			Me.O_Ooo_0Oo.00Oo.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_Ooo_0Oo.00Oo.().AutoSize = True
			Me.O_Ooo_0Oo.00Oo.().BorderStyle = BorderStyle.None
			Me.O_Ooo_0Oo.00Oo.().Location = New Point(7, 252)
			Me.O_Ooo_0Oo.00Oo.().Name = "CheckBox1"
			Me.O_Ooo_0Oo.00Oo.().Size = New Size(60, 16)
			Me.O_Ooo_0Oo.00Oo.().TabIndex = 8
			Me.O_Ooo_0Oo.00Oo.().Text = "方括号"
			Me.O_Ooo_0Oo.00Oo.().UseVisualStyleBackColor = True
			Me.O_Ooo_0Oo.00Oo.().Value = Nothing
			Me.o_o_.OOO0_Oo0.().Anchor = AnchorStyles.Bottom
			Me.o_o_.OOO0_Oo0.().Location = New Point(220, 458)
			Me.o_o_.OOO0_Oo0.().Name = "btnsym9"
			Me.o_o_.OOO0_Oo0.().Size = New Size(25, 23)
			Me.o_o_.OOO0_Oo0.().TabIndex = 24
			Me.o_o_.OOO0_Oo0.().Text = ","
			Me.o_o_.OOO0_Oo0.().UseVisualStyleBackColor = True
			Me.O0O0.0.().Anchor = AnchorStyles.Bottom
			Me.O0O0.0.().Location = New Point(193, 458)
			Me.O0O0.0.().Name = "btnsym8"
			Me.O0O0.0.().Size = New Size(25, 23)
			Me.O0O0.0.().TabIndex = 23
			Me.O0O0.0.().Text = "="
			Me.O0O0.0.().UseVisualStyleBackColor = True
			Me.O_Oo00._.().Anchor = AnchorStyles.Bottom
			Me.O_Oo00._.().Location = New Point(60, 458)
			Me.O_Oo00._.().Name = "btnsym3"
			Me.O_Oo00._.().Size = New Size(25, 23)
			Me.O_Oo00._.().TabIndex = 18
			Me.O_Oo00._.().Text = "[]"
			Me.O_Oo00._.().UseVisualStyleBackColor = True
			Me.o_o.O00OO0O0_.().Anchor = AnchorStyles.Bottom
			Me.o_o.O00OO0O0_.().Location = New Point(167, 458)
			Me.o_o.O00OO0O0_.().Name = "btnsym7"
			Me.o_o.O00OO0O0_.().Size = New Size(25, 23)
			Me.o_o.O00OO0O0_.().TabIndex = 22
			Me.o_o.O00OO0O0_.().Text = "/"
			Me.o_o.O00OO0O0_.().UseVisualStyleBackColor = True
			Me.OoO__O_0_._.().Anchor = AnchorStyles.Bottom
			Me.OoO__O_0_._.().Location = New Point(140, 458)
			Me.OoO__O_0_._.().Name = "btnsym6"
			Me.OoO__O_0_._.().Size = New Size(25, 23)
			Me.OoO__O_0_._.().TabIndex = 21
			Me.OoO__O_0_._.().Text = "*"
			Me.OoO__O_0_._.().UseVisualStyleBackColor = True
			Me.oO0oO0_0_O.oo.().Anchor = AnchorStyles.Bottom
			Me.oO0oO0_0_O.oo.().Location = New Point(113, 458)
			Me.oO0oO0_0_O.oo.().Name = "btnsym4"
			Me.oO0oO0_0_O.oo.().Size = New Size(25, 23)
			Me.oO0oO0_0_O.oo.().TabIndex = 20
			Me.oO0oO0_0_O.oo.().Text = "-"
			Me.oO0oO0_0_O.oo.().UseVisualStyleBackColor = True
			Me.oo0__0.00.().Anchor = AnchorStyles.Bottom
			Me.oo0__0.00.().Location = New Point(87, 458)
			Me.oo0__0.00.().Name = "btnsym5"
			Me.oo0__0.00.().Size = New Size(25, 23)
			Me.oo0__0.00.().TabIndex = 19
			Me.oo0__0.00.().Text = "+"
			Me.oo0__0.00.().UseVisualStyleBackColor = True
			Me.o0_o0oO.__.().Anchor = AnchorStyles.Bottom
			Me.o0_o0oO.__.().Location = New Point(33, 458)
			Me.o0_o0oO.__.().Name = "btnsym2"
			Me.o0_o0oO.__.().Size = New Size(25, 23)
			Me.o0_o0oO.__.().TabIndex = 17
			Me.o0_o0oO.__.().Text = "<>"
			Me.o0_o0oO.__.().UseVisualStyleBackColor = True
			Me.oOOoOO.O00OO_0.().Anchor = AnchorStyles.Bottom
			Me.oOOoOO.O00OO_0.().Location = New Point(7, 458)
			Me.oOOoOO.O00OO_0.().Name = "btnsym1"
			Me.oOOoOO.O00OO_0.().Size = New Size(25, 23)
			Me.oOOoOO.O00OO_0.().TabIndex = 16
			Me.oOOoOO.O00OO_0.().Text = """"""
			Me.oOOoOO.O00OO_0.().UseVisualStyleBackColor = True
			Me.o_0.00o.().Anchor = AnchorStyles.Bottom
			Me.o_0.00o.().Location = New Point(247, 458)
			Me.o_0.00o.().Name = "btnsym10"
			Me.o_0.00o.().Size = New Size(25, 23)
			Me.o_0.00o.().TabIndex = 25
			Me.o_0.00o.().Text = "&&"
			Me.o_0.00o.().UseVisualStyleBackColor = True
			Me.o0.oO0O_OO.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o0.oO0O_OO.().Location = New Point(7, 492)
			Me.o0.oO0O_OO.().Name = "Button1"
			Me.o0.oO0O_OO.().Size = New Size(57, 23)
			Me.o0.oO0O_OO.().TabIndex = 26
			Me.o0.oO0O_OO.().Text = "转半角"
			Me.o0.oO0O_OO.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(280, 517)
			MyBase.Controls.Add(Me.o0.oO0O_OO.())
			MyBase.Controls.Add(Me.o_0.00o.())
			MyBase.Controls.Add(Me.o_o_.OOO0_Oo0.())
			MyBase.Controls.Add(Me.O0O0.0.())
			MyBase.Controls.Add(Me.O_Oo00._.())
			MyBase.Controls.Add(Me.o_o.O00OO0O0_.())
			MyBase.Controls.Add(Me.OoO__O_0_._.())
			MyBase.Controls.Add(Me.oO0oO0_0_O.oo.())
			MyBase.Controls.Add(Me.oo0__0.00.())
			MyBase.Controls.Add(Me.o0_o0oO.__.())
			MyBase.Controls.Add(Me.oOOoOO.O00OO_0.())
			MyBase.Controls.Add(Me.O_Ooo_0Oo.00Oo.())
			MyBase.Controls.Add(Me.oO.O_0.())
			MyBase.Controls.Add(Me.O_Ooo_0Oo.00Oo.())
			MyBase.Controls.Add(Me.O_Ooo_0Oo.00Oo.())
			MyBase.Controls.Add(Me.O.0_OO0ooo0O0.())
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o00.OO."
			MyBase.ShowInTaskbar = False
			Me.Text = "Excel报表模版辅助设计器"
			Me.O.0_OO0ooo0O0.().EndInit()
			Me.O_Ooo_0Oo.00Oo.().EndInit()
			Me.O_Ooo_0Oo.00Oo.().EndInit()
			Me.o_o_.OOO0_Oo0.().EndInit()
			Me.O0O0.0.().EndInit()
			Me.O_Oo00._.().EndInit()
			Me.o_o.O00OO0O0_.().EndInit()
			Me.OoO__O_0_._.().EndInit()
			Me.oO0oO0_0_O.oo.().EndInit()
			Me.oo0__0.00.().EndInit()
			Me.o0_o0oO.__.().EndInit()
			Me.oOOoOO.O00OO_0.().EndInit()
			Me.o_0.00o.().EndInit()
			Me.o0.oO0O_OO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06004885 RID: 18565 RVA: 0x001EA578 File Offset: 0x001E8778
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O0_0_o.O_O.
		End Function

		' Token: 0x06004886 RID: 18566 RVA: 0x001EA580 File Offset: 0x001E8780
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.0O0__00O.
			Dim c1Button As C1Button = Me.o0O0_0_o.O_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O0_0_o.O_O. = A_0
			c1Button = Me.o0O0_0_o.O_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004887 RID: 18567 RVA: 0x001EA5C3 File Offset: 0x001E87C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0O0_0_o.O_O.
		End Function

		' Token: 0x06004888 RID: 18568 RVA: 0x001EA5CC File Offset: 0x001E87CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.oO___0.Oo.
			Dim c1ComboBox As C1ComboBox = Me.o0O0_0_o.O_O.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o0O0_0_o.O_O. = A_0
			c1ComboBox = Me.o0O0_0_o.O_O.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06004889 RID: 18569 RVA: 0x001EA60F File Offset: 0x001E880F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o0O0_0_o.O_O.
		End Function

		' Token: 0x0600488A RID: 18570 RVA: 0x001EA618 File Offset: 0x001E8818
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Dim value As MouseEventHandler = AddressOf Me.O_0_O00OO_.00.
			Dim listBox As ListBox = Me.o0O0_0_o.O_O.
			If listBox IsNot Nothing Then
				RemoveHandler listBox.MouseDoubleClick, value
			End If
			Me.o0O0_0_o.O_O. = A_0
			listBox = Me.o0O0_0_o.O_O.
			If listBox IsNot Nothing Then
				AddHandler listBox.MouseDoubleClick, value
			End If
		End Sub

		' Token: 0x0600488B RID: 18571 RVA: 0x001EA65B File Offset: 0x001E885B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.Oo_oo._.
		End Function

		' Token: 0x0600488C RID: 18572 RVA: 0x001EA664 File Offset: 0x001E8864
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Dim value As MouseEventHandler = AddressOf Me.O._o00.
			Dim oo_oo._. As ListBox = Me.Oo_oo._.
			If oo_oo._. IsNot Nothing Then
				RemoveHandler oo_oo._..MouseDoubleClick, value
			End If
			Me.Oo_oo._. = A_0
			oo_oo._. = Me.Oo_oo._.
			If oo_oo._. IsNot Nothing Then
				AddHandler oo_oo._..MouseDoubleClick, value
			End If
		End Sub

		' Token: 0x0600488D RID: 18573 RVA: 0x001EA6A7 File Offset: 0x001E88A7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0O0_0_o.O_O.
		End Function

		' Token: 0x0600488E RID: 18574 RVA: 0x001EA6AF File Offset: 0x001E88AF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0O0_0_o.O_O. = A_0
		End Sub

		' Token: 0x0600488F RID: 18575 RVA: 0x001EA6B8 File Offset: 0x001E88B8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.o0O0_0_o.O_O.
		End Function

		' Token: 0x06004890 RID: 18576 RVA: 0x001EA6C0 File Offset: 0x001E88C0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.Oo.o0O.
			Dim timer As Timer = Me.o0O0_0_o.O_O.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.o0O0_0_o.O_O. = A_0
			timer = Me.o0O0_0_o.O_O.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x06004891 RID: 18577 RVA: 0x001EA703 File Offset: 0x001E8903
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_oo._.
		End Function

		' Token: 0x06004892 RID: 18578 RVA: 0x001EA70C File Offset: 0x001E890C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim oo_oo._. As C1Button = Me.Oo_oo._.
			If oo_oo._. IsNot Nothing Then
				RemoveHandler oo_oo._..Click, value
			End If
			Me.Oo_oo._. = A_0
			oo_oo._. = Me.Oo_oo._.
			If oo_oo._. IsNot Nothing Then
				AddHandler oo_oo._..Click, value
			End If
		End Sub

		' Token: 0x06004893 RID: 18579 RVA: 0x001EA74F File Offset: 0x001E894F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.o___O.
		End Function

		' Token: 0x06004894 RID: 18580 RVA: 0x001EA758 File Offset: 0x001E8958
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim o.o___O. As C1Button = Me.O.o___O.
			If o.o___O. IsNot Nothing Then
				RemoveHandler o.o___O..Click, value
			End If
			Me.O.o___O. = A_0
			o.o___O. = Me.O.o___O.
			If o.o___O. IsNot Nothing Then
				AddHandler o.o___O..Click, value
			End If
		End Sub

		' Token: 0x06004895 RID: 18581 RVA: 0x001EA79B File Offset: 0x001E899B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.00_O0o__O_.
		End Function

		' Token: 0x06004896 RID: 18582 RVA: 0x001EA7A4 File Offset: 0x001E89A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim o.00_O0o__O_. As C1Button = Me.O.00_O0o__O_.
			If o.00_O0o__O_. IsNot Nothing Then
				RemoveHandler o.00_O0o__O_..Click, value
			End If
			Me.O.00_O0o__O_. = A_0
			o.00_O0o__O_. = Me.O.00_O0o__O_.
			If o.00_O0o__O_. IsNot Nothing Then
				AddHandler o.00_O0o__O_..Click, value
			End If
		End Sub

		' Token: 0x06004897 RID: 18583 RVA: 0x001EA7E7 File Offset: 0x001E89E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo.o0O.
		End Function

		' Token: 0x06004898 RID: 18584 RVA: 0x001EA7F0 File Offset: 0x001E89F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim oo.o0O. As C1Button = Me.Oo.o0O.
			If oo.o0O. IsNot Nothing Then
				RemoveHandler oo.o0O..Click, value
			End If
			Me.Oo.o0O. = A_0
			oo.o0O. = Me.Oo.o0O.
			If oo.o0O. IsNot Nothing Then
				AddHandler oo.o0O..Click, value
			End If
		End Sub

		' Token: 0x06004899 RID: 18585 RVA: 0x001EA833 File Offset: 0x001E8A33
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.O0o_.
		End Function

		' Token: 0x0600489A RID: 18586 RVA: 0x001EA83C File Offset: 0x001E8A3C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim o.O0o_. As C1Button = Me.O.O0o_.
			If o.O0o_. IsNot Nothing Then
				RemoveHandler o.O0o_..Click, value
			End If
			Me.O.O0o_. = A_0
			o.O0o_. = Me.O.O0o_.
			If o.O0o_. IsNot Nothing Then
				AddHandler o.O0o_..Click, value
			End If
		End Sub

		' Token: 0x0600489B RID: 18587 RVA: 0x001EA87F File Offset: 0x001E8A7F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.OO0oOOOoo_.
		End Function

		' Token: 0x0600489C RID: 18588 RVA: 0x001EA888 File Offset: 0x001E8A88
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim o_.OO0oOOOoo_. As C1Button = Me.O_.OO0oOOOoo_.
			If o_.OO0oOOOoo_. IsNot Nothing Then
				RemoveHandler o_.OO0oOOOoo_..Click, value
			End If
			Me.O_.OO0oOOOoo_. = A_0
			o_.OO0oOOOoo_. = Me.O_.OO0oOOOoo_.
			If o_.OO0oOOOoo_. IsNot Nothing Then
				AddHandler o_.OO0oOOOoo_..Click, value
			End If
		End Sub

		' Token: 0x0600489D RID: 18589 RVA: 0x001EA8CB File Offset: 0x001E8ACB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOo_O_0o.O0_O0.
		End Function

		' Token: 0x0600489E RID: 18590 RVA: 0x001EA8D4 File Offset: 0x001E8AD4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim c1Button As C1Button = Me.oOo_O_0o.O0_O0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOo_O_0o.O0_O0. = A_0
			c1Button = Me.oOo_O_0o.O0_O0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600489F RID: 18591 RVA: 0x001EA917 File Offset: 0x001E8B17
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.__O0O00_.
		End Function

		' Token: 0x060048A0 RID: 18592 RVA: 0x001EA920 File Offset: 0x001E8B20
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim oo_.__O0O00_. As C1Button = Me.Oo_.__O0O00_.
			If oo_.__O0O00_. IsNot Nothing Then
				RemoveHandler oo_.__O0O00_..Click, value
			End If
			Me.Oo_.__O0O00_. = A_0
			oo_.__O0O00_. = Me.Oo_.__O0O00_.
			If oo_.__O0O00_. IsNot Nothing Then
				AddHandler oo_.__O0O00_..Click, value
			End If
		End Sub

		' Token: 0x060048A1 RID: 18593 RVA: 0x001EA963 File Offset: 0x001E8B63
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_o0._o.
		End Function

		' Token: 0x060048A2 RID: 18594 RVA: 0x001EA96C File Offset: 0x001E8B6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim c1Button As C1Button = Me.o_o0._o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_o0._o. = A_0
			c1Button = Me.o_o0._o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060048A3 RID: 18595 RVA: 0x001EA9AF File Offset: 0x001E8BAF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o__OOO_0_0.o_o.
		End Function

		' Token: 0x060048A4 RID: 18596 RVA: 0x001EA9B8 File Offset: 0x001E8BB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOooOO0O0.O.
			Dim c1Button As C1Button = Me.o__OOO_0_0.o_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o__OOO_0_0.o_o. = A_0
			c1Button = Me.o__OOO_0_0.o_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060048A5 RID: 18597 RVA: 0x001EA9FB File Offset: 0x001E8BFB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_Oo.0Oo0.
		End Function

		' Token: 0x060048A6 RID: 18598 RVA: 0x001EAA04 File Offset: 0x001E8C04
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.oo__0O.
			Dim o_Oo.0Oo0. As C1Button = Me.O_Oo.0Oo0.
			If o_Oo.0Oo0. IsNot Nothing Then
				RemoveHandler o_Oo.0Oo0..Click, value
			End If
			Me.O_Oo.0Oo0. = A_0
			o_Oo.0Oo0. = Me.O_Oo.0Oo0.
			If o_Oo.0Oo0. IsNot Nothing Then
				AddHandler o_Oo.0Oo0..Click, value
			End If
		End Sub

		' Token: 0x060048A7 RID: 18599
		Private Declare Ansi Function SetForegroundWindow Lib "user32" (A_0 As Integer) As Integer

		' Token: 0x060048A8 RID: 18600 RVA: 0x001EAA48 File Offset: 0x001E8C48
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Try
				If Me.o0O0_0_o.O_O. IsNot Nothing AndAlso (Me.o0O0_0_o.O_O..Visible OrElse Not Me.o0O0_0_o.O_O..Visible) Then
					Try
						For Each obj As Object In Me.o0O0_0_o.O_O..Workbooks
							CType(obj, Workbook).Save()
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If Me.o0O0_0_o.O_O..Workbooks.Count > 0 Then
						Me.o0O0_0_o.O_O..Workbooks.Close()
					End If
					Me.o0O0_0_o.O_O..Quit()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060048A9 RID: 18601 RVA: 0x001EAB18 File Offset: 0x001E8D18
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.TopMost = True
			MyBase.Location = New Point(CInt((SysInfo.ScreenWidth - CLng(MyBase.Width) - 30L)), 60)
			Me.o0O0_0_o.O_O. = New ApplicationClass()
			Me.o0O0_0_o.O_O..WindowState = -4137
			Me.o0O0_0_o.O_O..Visible = True
			Me.o0O0_0_o.O_O..Workbooks.Open(Me.oo0O.Oo_0., RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					Me.O_Ooo_0Oo.00Oo.().Items.Add(dataTable.Name)
					If Operators.CompareString(dataTable.Name, OO_00oOO.MainTable.DataTable.Name, True) = 0 Then
						Me.O_Ooo_0Oo.00Oo.().SelectedIndex = Me.O_Ooo_0Oo.00Oo.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			If Me.O_Ooo_0Oo.00Oo.().SelectedIndex = -1 Then
				Me.O_Ooo_0Oo.00Oo.().SelectedIndex = 0
			End If
			Me.O._o00.().Enabled = True
		End Sub

		' Token: 0x060048AA RID: 18602 RVA: 0x001EACD8 File Offset: 0x001E8ED8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				If Not Me.o0O0_0_o.O_O..Visible Then
					MyBase.Close()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060048AB RID: 18603 RVA: 0x001EAD18 File Offset: 0x001E8F18
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = OO_00oOO.ProjectPath + "Reports\"
			If Not OO_00oOO.FileSys.DirectoryExists(text) Then
				OO_00oOO.FileSys.CreateDirectory(text)
			End If
			Dim text2 As String = text + "_" + OO_00oOO.FileSys.GetName(Me.oo0O.Oo_0.)
			If Me.o0O0_0_o.O_O..Workbooks.Count > 1 Then
				Try
					For Each obj As Object In Me.o0O0_0_o.O_O..Workbooks
						Dim workbook As Workbook = CType(obj, Workbook)
						If Operators.CompareString(workbook.FullName, text2, True) = 0 Then
							workbook.Close(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.O.0_OO0ooo0O0.().Enabled = False
			Me.o0O0_0_o.O_O..Workbooks.get__Default(1).Save()
			Dim book As Book = New Book(Me.o0O0_0_o.O_O..Workbooks.get__Default(1).FullName)
			book.Build(New Integer(-1) {})
			book.Save(text2)
			Me.o0O0_0_o.O_O..Workbooks.Open(text2, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value))
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Me.O.0_OO0ooo0O0.().Enabled = True
		End Sub

		' Token: 0x060048AC RID: 18604 RVA: 0x001EAF18 File Offset: 0x001E9118
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosing, AddressOf Me.oOOoOO.O00OO_0.
			AddHandler MyBase.Load, AddressOf Me.oO_OOOO.0OO_.
			AddHandler MyBase.FormClosed, AddressOf Me.oOOoOO.O00OO_0.
			Me.oo._0. = Path.GetTempFileName()
			Me.O._o00.()
			Me.oo0O.Oo_0. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "Office2016White")
			Main.OO_O.o..Oo.oOo_o0Oo0.("MacBlue", New Object() { Me.O.0_OO0ooo0O0.() })
		End Sub

		' Token: 0x060048AD RID: 18605 RVA: 0x001EAFAC File Offset: 0x001E91AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_Ooo_0Oo.00Oo.().Items.Clear()
			Try
				For Each dataCol As DataCol In OO_00oOO.DataTables(Me.O_Ooo_0Oo.00Oo.().SelectedItem.ToString()).DataCols
					Me.O_Ooo_0Oo.00Oo.().Items.Add(dataCol.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.O_Ooo_0Oo.00Oo.().SelectedIndex = 0
		End Sub

		' Token: 0x060048AE RID: 18606 RVA: 0x001EB040 File Offset: 0x001E9240
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Me.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value)
			If Me.O_Ooo_0Oo.00Oo.().SelectedItem IsNot Nothing AndAlso Me.o0O0_0_o.O_O..ActiveCell IsNot Nothing Then
				If Not Me.O_Ooo_0Oo.00Oo.().Checked Then
					Me.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), Me.O_Ooo_0Oo.00Oo.().SelectedItem.ToString())
					Return
				End If
				Me.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), "[" + Me.O_Ooo_0Oo.00Oo.().SelectedItem.ToString() + "]")
			End If
		End Sub

		' Token: 0x060048AF RID: 18607 RVA: 0x001EB100 File Offset: 0x001E9300
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Me.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value)
			If Me.oO.O_0.().SelectedItem IsNot Nothing Then
				Dim text As String = Me.oO.O_0.().SelectedItem.ToString()
				Dim text2 As String = Me.O_Ooo_0Oo.00Oo.().Text
				Dim text3 As String = ""
				If text.IndexOf("-") > 0 Then
					text = text.Substring(0, text.IndexOf("-") - 2) + "]"
				End If
				If Me.O_Ooo_0Oo.00Oo.().SelectedIndex > -1 Then
					text3 = Me.O_Ooo_0Oo.00Oo.().SelectedItem.ToString()
				End If
				text = text.Replace("表名", text2)
				If Operators.CompareString(text3, "", True) > 0 Then
					text = text.Replace("列名", text3)
				End If
				If Me.o0O0_0_o.O_O..ActiveCell IsNot Nothing Then
					Me.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), text)
				End If
			End If
		End Sub

		' Token: 0x060048B0 RID: 18608 RVA: 0x001EB204 File Offset: 0x001E9404
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Me.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value)
			If Me.o0O0_0_o.O_O..ActiveCell IsNot Nothing Then
				Me.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), CType(A_0, Button).Text)
			End If
		End Sub

		' Token: 0x060048B1 RID: 18609 RVA: 0x001EB26C File Offset: 0x001E946C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000.SetForegroundWindow(Me.o0O0_0_o.O_O..Hwnd)
			Me.o0O0_0_o.O_O..SendKeys("{ESC}", Missing.Value)
			If Me.o0O0_0_o.O_O..ActiveCell IsNot Nothing AndAlso Operators.CompareString(Me.o0O0_0_o.O_O..ActiveCell.Text.ToString(), "", True) > 0 Then
				Me.o0O0_0_o.O_O..ActiveCell.set_Value(RuntimeHelpers.GetObjectValue(Missing.Value), Strings.StrConv(Me.o0O0_0_o.O_O..ActiveCell.Text.ToString(), VbStrConv.Narrow, 0))
			End If
		End Sub

		' Token: 0x060048B2 RID: 18610 RVA: 0x001EB305 File Offset: 0x001E9505
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001D9A RID: 7578
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001D9B RID: 7579
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001D9C RID: 7580
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001D9D RID: 7581
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001D9E RID: 7582
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001D9F RID: 7583
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001DA0 RID: 7584
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04001DA1 RID: 7585
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA2 RID: 7586
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA3 RID: 7587
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA4 RID: 7588
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA5 RID: 7589
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA6 RID: 7590
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA7 RID: 7591
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA8 RID: 7592
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DA9 RID: 7593
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DAA RID: 7594
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DAB RID: 7595
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001DAC RID: 7596
		Private <<EMPTY_NAME>> As Application

		' Token: 0x04001DAD RID: 7597
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001DAE RID: 7598
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
