Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000460 RID: 1120
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Partial Class O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002
		Inherits Form

		' Token: 0x06004AD8 RID: 19160 RVA: 0x001F83B4 File Offset: 0x001F65B4
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_.Oo0oo. IsNot Nothing Then
					Me.o_.Oo0oo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06004AD9 RID: 19161 RVA: 0x001F83F4 File Offset: 0x001F65F4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_.Oo0oo. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002))
			Me.o_0_O_Oo_.o0.(New C1Button())
			Me.OoO_0.o0.(New C1ComboBox())
			Me.OoO_0.o0.(New ListBox())
			Me.OoO_0.o0.(New C1CheckBox())
			Me.O_OO0._o0oo0.(New Timer(Me.o_.Oo0oo.))
			Me.O_OO0._o0oo0.(New C1NumericEdit())
			Me.O.__oO.(New C1Button())
			Me.O0oO_oO._oOo.(New C1CheckBox())
			Me.OOO.0O0_oo.(New Label())
			Me.OoO_0.o0.(New Label())
			Me.O0oO_oO._oOo.(New Label())
			Me.O_0._0o__o_OO.(New C1Button())
			Me.o.oOo_.(New C1Button())
			Me.O_00._OO__OOo.(New C1Button())
			Me.o_Oo00_O_.oo.(New C1Button())
			Me.oo._O00__0__O0.(New C1Button())
			Me.o._o_ooo_O0.(New C1Button())
			Me.OO_.0oOo.(New C1Button())
			Me.OOO.0O0_oo.(New C1Button())
			Me.oO0_.O_o_00Oo0.(New C1Button())
			Me.OO_OO0O0.Oo00.(New C1Button())
			Me.oooO0O_0.o_o.(New C1Button())
			Me.OOo0_0o.o.().BeginInit()
			Me.OO_.0o.().BeginInit()
			Me.oooO._.().BeginInit()
			Me.OO_.0o.().BeginInit()
			Me.Oooo.0.().BeginInit()
			Me.OOO_.0o0oo_.().BeginInit()
			Me.O.__o_o0_.().BeginInit()
			Me.o.___0_0000.().BeginInit()
			Me.o_00_Oo_.00_0_.().BeginInit()
			Me.O_O_oO00.0o.().BeginInit()
			Me.o0__0O.00O.().BeginInit()
			Me.ooO0._0O0_.().BeginInit()
			Me.o_O0_O_o0O0O.O.().BeginInit()
			Me.oOoO.O0.().BeginInit()
			Me.Oo.oo0_0.().BeginInit()
			Me.o_o0_0.oO__oo.().BeginInit()
			Me.o0__.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.OOo0_0o.o.().Anchor = AnchorStyles.Bottom
			Me.OOo0_0o.o.().Location = New Point(171, 502)
			Me.OOo0_0o.o.().Name = "btnPreview"
			Me.OOo0_0o.o.().Size = New Size(115, 23)
			Me.OOo0_0o.o.().TabIndex = 0
			Me.OOo0_0o.o.().Text = "预览报表"
			Me.OOo0_0o.o.().UseVisualStyleBackColor = True
			Me.OO_.0o.().AllowSpinLoop = False
			Me.OO_.0o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OO_.0o.().Cursor = Cursors.Arrow
			Me.OO_.0o.().DropDownStyle = 1
			Me.OO_.0o.().GapHeight = 0
			Me.OO_.0o.().ImagePadding = New Padding(0)
			Me.OO_.0o.().ItemsDisplayMember = ""
			Me.OO_.0o.().ItemsValueMember = ""
			Me.OO_.0o.().Location = New Point(11, 9)
			Me.OO_.0o.().Name = "cmbTables"
			Me.OO_.0o.().Size = New Size(272, 19)
			Me.OO_.0o.().TabIndex = 1
			Me.OO_.0o.().Tag = Nothing
			Me.OO_.0o.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.OO_.0o.().FormattingEnabled = True
			Me.OO_.0o.().IntegralHeight = False
			Me.OO_.0o.().ItemHeight = 12
			Me.OO_.0o.().Location = New Point(11, 32)
			Me.OO_.0o.().Name = "lstCols"
			Me.OO_.0o.().Size = New Size(272, 304)
			Me.OO_.0o.().TabIndex = 2
			Me.oooO._.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.oooO._.().AutoSize = True
			Me.oooO._.().BorderStyle = BorderStyle.None
			Me.oooO._.().Location = New Point(11, 368)
			Me.oooO._.().Name = "CheckBox1"
			Me.oooO._.().Size = New Size(60, 16)
			Me.oooO._.().TabIndex = 3
			Me.oooO._.().Text = "方括号"
			Me.oooO._.().UseVisualStyleBackColor = True
			Me.oooO._.().Value = Nothing
			Me.OO_.0o.().Interval = 500
			Me.OO_.0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OO_.0o.().ImagePadding = New Padding(0)
			Me.OO_.0o.().Location = New Point(112, 390)
			Me.OO_.0o.().Name = "NumericUpDown1"
			Me.OO_.0o.().Size = New Size(65, 19)
			Me.OO_.0o.().TabIndex = 5
			Me.OO_.0o.().Tag = Nothing
			Dim c1TextBox As C1TextBox = Me.OO_.0o.()
			Dim array As Integer() = New Integer(3) {}
			array(0) = 1
			c1TextBox.Value = New Decimal(array)
			Me.OO_.0o.().VisibleButtons = 1
			Me.Oooo.0.().AllowDrop = True
			Me.Oooo.0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.Oooo.0.().Location = New Point(185, 338)
			Me.Oooo.0.().Name = "btnInsertTable"
			Me.Oooo.0.().Size = New Size(98, 23)
			Me.Oooo.0.().TabIndex = 4
			Me.Oooo.0.().Text = "插入关联子表"
			Me.Oooo.0.().UseVisualStyleBackColor = True
			Me.OOO_.0o0oo_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OOO_.0o0oo_.().AutoSize = True
			Me.OOO_.0o0oo_.().BorderStyle = BorderStyle.None
			Me.OOO_.0o0oo_.().Location = New Point(11, 342)
			Me.OOO_.0o0oo_.().Name = "CheckBox2"
			Me.OOO_.0o0oo_.().Size = New Size(60, 16)
			Me.OOO_.0o0oo_.().TabIndex = 2
			Me.OOO_.0o0oo_.().Text = "带标签"
			Me.OOO_.0o0oo_.().UseVisualStyleBackColor = True
			Me.OOO_.0o0oo_.().Value = Nothing
			Me.OO_.0o.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.OO_.0o.().AutoSize = True
			Me.OO_.0o.().Location = New Point(11, 438)
			Me.OO_.0o.().Name = "Label1"
			Me.OO_.0o.().Size = New Size(197, 12)
			Me.OO_.0o.().TabIndex = 9
			Me.OO_.0o.().Text = "提示2： 按Ctrl双击，插入统计标记"
			Me.Oo0.Oo0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo0.Oo0.().AutoSize = True
			Me.Oo0.Oo0.().Location = New Point(11, 416)
			Me.Oo0.Oo0.().Name = "Label2"
			Me.Oo0.Oo0.().Size = New Size(203, 12)
			Me.Oo0.Oo0.().TabIndex = 8
			Me.Oo0.Oo0.().Text = "提示1： 按Shift双击，插入图片标记"
			Me.O_Oo0o0.0O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.O_Oo0o0.0O.().AutoSize = True
			Me.O_Oo0o0.0O.().Location = New Point(11, 394)
			Me.O_Oo0o0.0O.().Name = "Label3"
			Me.O_Oo0o0.0O.().Size = New Size(95, 12)
			Me.O_Oo0o0.0O.().TabIndex = 7
			Me.O_Oo0o0.0O.().Text = "关联子表行位置:"
			Me.O.__o_o0_.().Anchor = AnchorStyles.Bottom
			Me.O.__o_o0_.().Location = New Point(6, 462)
			Me.O.__o_o0_.().Name = "btnsym1"
			Me.O.__o_o0_.().Size = New Size(27, 23)
			Me.O.__o_o0_.().TabIndex = 6
			Me.O.__o_o0_.().Text = """"""
			Me.O.__o_o0_.().UseVisualStyleBackColor = True
			Me.o.___0_0000.().Anchor = AnchorStyles.Bottom
			Me.o.___0_0000.().Location = New Point(34, 462)
			Me.o.___0_0000.().Name = "btnsym2"
			Me.o.___0_0000.().Size = New Size(27, 23)
			Me.o.___0_0000.().TabIndex = 7
			Me.o.___0_0000.().Text = "<>"
			Me.o.___0_0000.().UseVisualStyleBackColor = True
			Me.o_00_Oo_.00_0_.().Anchor = AnchorStyles.Bottom
			Me.o_00_Oo_.00_0_.().Location = New Point(90, 462)
			Me.o_00_Oo_.00_0_.().Name = "btnsym5"
			Me.o_00_Oo_.00_0_.().Size = New Size(27, 23)
			Me.o_00_Oo_.00_0_.().TabIndex = 9
			Me.o_00_Oo_.00_0_.().Text = "+"
			Me.o_00_Oo_.00_0_.().UseVisualStyleBackColor = True
			Me.O_O_oO00.0o.().Anchor = AnchorStyles.Bottom
			Me.O_O_oO00.0o.().Location = New Point(118, 462)
			Me.O_O_oO00.0o.().Name = "btnsym4"
			Me.O_O_oO00.0o.().Size = New Size(27, 23)
			Me.O_O_oO00.0o.().TabIndex = 10
			Me.O_O_oO00.0o.().Text = "-"
			Me.O_O_oO00.0o.().UseVisualStyleBackColor = True
			Me.o0__0O.00O.().Anchor = AnchorStyles.Bottom
			Me.o0__0O.00O.().Location = New Point(146, 462)
			Me.o0__0O.00O.().Name = "btnsym6"
			Me.o0__0O.00O.().Size = New Size(27, 23)
			Me.o0__0O.00O.().TabIndex = 11
			Me.o0__0O.00O.().Text = "*"
			Me.o0__0O.00O.().UseVisualStyleBackColor = True
			Me.ooO0._0O0_.().Anchor = AnchorStyles.Bottom
			Me.ooO0._0O0_.().Location = New Point(174, 462)
			Me.ooO0._0O0_.().Name = "btnsym7"
			Me.ooO0._0O0_.().Size = New Size(27, 23)
			Me.ooO0._0O0_.().TabIndex = 12
			Me.ooO0._0O0_.().Text = "/"
			Me.ooO0._0O0_.().UseVisualStyleBackColor = True
			Me.o_O0_O_o0O0O.O.().Anchor = AnchorStyles.Bottom
			Me.o_O0_O_o0O0O.O.().Location = New Point(62, 462)
			Me.o_O0_O_o0O0O.O.().Name = "btnsym3"
			Me.o_O0_O_o0O0O.O.().Size = New Size(27, 23)
			Me.o_O0_O_o0O0O.O.().TabIndex = 8
			Me.o_O0_O_o0O0O.O.().Text = "[]"
			Me.o_O0_O_o0O0O.O.().UseVisualStyleBackColor = True
			Me.oOoO.O0.().Anchor = AnchorStyles.Bottom
			Me.oOoO.O0.().Location = New Point(202, 462)
			Me.oOoO.O0.().Name = "btnsym8"
			Me.oOoO.O0.().Size = New Size(27, 23)
			Me.oOoO.O0.().TabIndex = 13
			Me.oOoO.O0.().Text = "="
			Me.oOoO.O0.().UseVisualStyleBackColor = True
			Me.Oo.oo0_0.().Anchor = AnchorStyles.Bottom
			Me.Oo.oo0_0.().Location = New Point(230, 462)
			Me.Oo.oo0_0.().Name = "btnsym9"
			Me.Oo.oo0_0.().Size = New Size(27, 23)
			Me.Oo.oo0_0.().TabIndex = 15
			Me.Oo.oo0_0.().Text = ","
			Me.Oo.oo0_0.().UseVisualStyleBackColor = True
			Me.o_o0_0.oO__oo.().Anchor = AnchorStyles.Bottom
			Me.o_o0_0.oO__oo.().Location = New Point(258, 462)
			Me.o_o0_0.oO__oo.().Name = "btnsym10"
			Me.o_o0_0.oO__oo.().Size = New Size(27, 23)
			Me.o_o0_0.oO__oo.().TabIndex = 16
			Me.o_o0_0.oO__oo.().Text = "\"
			Me.o_o0_0.oO__oo.().UseVisualStyleBackColor = True
			Me.o0__.O.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.o0__.O.().Location = New Point(8, 502)
			Me.o0__.O.().Name = "Button1"
			Me.o0__.O.().Size = New Size(60, 23)
			Me.o0__.O.().TabIndex = 17
			Me.o0__.O.().Text = "转半角"
			Me.o0__.O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(294, 528)
			MyBase.Controls.Add(Me.o0__.O.())
			MyBase.Controls.Add(Me.o_o0_0.oO__oo.())
			MyBase.Controls.Add(Me.Oo.oo0_0.())
			MyBase.Controls.Add(Me.oOoO.O0.())
			MyBase.Controls.Add(Me.o_O0_O_o0O0O.O.())
			MyBase.Controls.Add(Me.ooO0._0O0_.())
			MyBase.Controls.Add(Me.o0__0O.00O.())
			MyBase.Controls.Add(Me.O_O_oO00.0o.())
			MyBase.Controls.Add(Me.o_00_Oo_.00_0_.())
			MyBase.Controls.Add(Me.o.___0_0000.())
			MyBase.Controls.Add(Me.O.__o_o0_.())
			MyBase.Controls.Add(Me.O_Oo0o0.0O.())
			MyBase.Controls.Add(Me.Oo0.Oo0.())
			MyBase.Controls.Add(Me.OO_.0o.())
			MyBase.Controls.Add(Me.OOO_.0o0oo_.())
			MyBase.Controls.Add(Me.Oooo.0.())
			MyBase.Controls.Add(Me.OO_.0o.())
			MyBase.Controls.Add(Me.oooO._.())
			MyBase.Controls.Add(Me.OO_.0o.())
			MyBase.Controls.Add(Me.OO_.0o.())
			MyBase.Controls.Add(Me.OOo0_0o.o.())
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.oO.0.OO."
			MyBase.ShowInTaskbar = False
			Me.Text = "Word报表模版辅助设计器"
			Me.OOo0_0o.o.().EndInit()
			Me.OO_.0o.().EndInit()
			Me.oooO._.().EndInit()
			Me.OO_.0o.().EndInit()
			Me.Oooo.0.().EndInit()
			Me.OOO_.0o0oo_.().EndInit()
			Me.O.__o_o0_.().EndInit()
			Me.o.___0_0000.().EndInit()
			Me.o_00_Oo_.00_0_.().EndInit()
			Me.O_O_oO00.0o.().EndInit()
			Me.o0__0O.00O.().EndInit()
			Me.ooO0._0O0_.().EndInit()
			Me.o_O0_O_o0O0O.O.().EndInit()
			Me.oOoO.O0.().EndInit()
			Me.Oo.oo0_0.().EndInit()
			Me.o_o0_0.oO__oo.().EndInit()
			Me.o0__.O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06004ADA RID: 19162 RVA: 0x001F92A5 File Offset: 0x001F74A5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_OO0._o0oo0.
		End Function

		' Token: 0x06004ADB RID: 19163 RVA: 0x001F92B0 File Offset: 0x001F74B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.OOoO0oO.
			Dim o_OO0._o0oo0. As C1Button = Me.O_OO0._o0oo0.
			If o_OO0._o0oo0. IsNot Nothing Then
				RemoveHandler o_OO0._o0oo0..Click, value
			End If
			Me.O_OO0._o0oo0. = A_0
			o_OO0._o0oo0. = Me.O_OO0._o0oo0.
			If o_OO0._o0oo0. IsNot Nothing Then
				AddHandler o_OO0._o0oo0..Click, value
			End If
		End Sub

		' Token: 0x06004ADC RID: 19164 RVA: 0x001F92F3 File Offset: 0x001F74F3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_.Oo0oo.
		End Function

		' Token: 0x06004ADD RID: 19165 RVA: 0x001F92FC File Offset: 0x001F74FC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O.O_o0.
			Dim c1ComboBox As C1ComboBox = Me.o_.Oo0oo.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o_.Oo0oo. = A_0
			c1ComboBox = Me.o_.Oo0oo.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06004ADE RID: 19166 RVA: 0x001F933F File Offset: 0x001F753F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o_.Oo0oo.
		End Function

		' Token: 0x06004ADF RID: 19167 RVA: 0x001F9348 File Offset: 0x001F7548
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Dim value As MouseEventHandler = AddressOf Me.OO_.0o.
			Dim listBox As ListBox = Me.o_.Oo0oo.
			If listBox IsNot Nothing Then
				RemoveHandler listBox.MouseDoubleClick, value
			End If
			Me.o_.Oo0oo. = A_0
			listBox = Me.o_.Oo0oo.
			If listBox IsNot Nothing Then
				AddHandler listBox.MouseDoubleClick, value
			End If
		End Sub

		' Token: 0x06004AE0 RID: 19168 RVA: 0x001F938B File Offset: 0x001F758B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_oo.o0____.
		End Function

		' Token: 0x06004AE1 RID: 19169 RVA: 0x001F9393 File Offset: 0x001F7593
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O_oo.o0____. = A_0
		End Sub

		' Token: 0x06004AE2 RID: 19170 RVA: 0x001F939C File Offset: 0x001F759C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.o_.Oo0oo.
		End Function

		' Token: 0x06004AE3 RID: 19171 RVA: 0x001F93A4 File Offset: 0x001F75A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.o_ooOoOO_.ooO0.
			Dim timer As Timer = Me.o_.Oo0oo.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.o_.Oo0oo. = A_0
			timer = Me.o_.Oo0oo.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x06004AE4 RID: 19172 RVA: 0x001F93E7 File Offset: 0x001F75E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.o_.Oo0oo.
		End Function

		' Token: 0x06004AE5 RID: 19173 RVA: 0x001F93EF File Offset: 0x001F75EF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.o_.Oo0oo. = A_0
		End Sub

		' Token: 0x06004AE6 RID: 19174 RVA: 0x001F93F8 File Offset: 0x001F75F8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO_O_.oO0_O.
		End Function

		' Token: 0x06004AE7 RID: 19175 RVA: 0x001F9400 File Offset: 0x001F7600
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O00O0o0o._0o.
			Dim oo_O_.oO0_O. As C1Button = Me.OO_O_.oO0_O.
			If oo_O_.oO0_O. IsNot Nothing Then
				RemoveHandler oo_O_.oO0_O..Click, value
			End If
			Me.OO_O_.oO0_O. = A_0
			oo_O_.oO0_O. = Me.OO_O_.oO0_O.
			If oo_O_.oO0_O. IsNot Nothing Then
				AddHandler oo_O_.oO0_O..Click, value
			End If
		End Sub

		' Token: 0x06004AE8 RID: 19176 RVA: 0x001F9443 File Offset: 0x001F7643
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_0o_0._o.
		End Function

		' Token: 0x06004AE9 RID: 19177 RVA: 0x001F944B File Offset: 0x001F764B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O_0o_0._o. = A_0
		End Sub

		' Token: 0x06004AEA RID: 19178 RVA: 0x001F9454 File Offset: 0x001F7654
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_.Oo0oo.
		End Function

		' Token: 0x06004AEB RID: 19179 RVA: 0x001F945C File Offset: 0x001F765C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_.Oo0oo. = A_0
		End Sub

		' Token: 0x06004AEC RID: 19180 RVA: 0x001F9465 File Offset: 0x001F7665
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o._o_0o0.
		End Function

		' Token: 0x06004AED RID: 19181 RVA: 0x001F946D File Offset: 0x001F766D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o._o_0o0. = A_0
		End Sub

		' Token: 0x06004AEE RID: 19182 RVA: 0x001F9476 File Offset: 0x001F7676
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO0_._00.
		End Function

		' Token: 0x06004AEF RID: 19183 RVA: 0x001F947E File Offset: 0x001F767E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO0_._00. = A_0
		End Sub

		' Token: 0x06004AF0 RID: 19184 RVA: 0x001F9487 File Offset: 0x001F7687
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_0OO.o_o.
		End Function

		' Token: 0x06004AF1 RID: 19185 RVA: 0x001F9490 File Offset: 0x001F7690
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim o0_0OO.o_o. As C1Button = Me.O0_0OO.o_o.
			If o0_0OO.o_o. IsNot Nothing Then
				RemoveHandler o0_0OO.o_o..Click, value
			End If
			Me.O0_0OO.o_o. = A_0
			o0_0OO.o_o. = Me.O0_0OO.o_o.
			If o0_0OO.o_o. IsNot Nothing Then
				AddHandler o0_0OO.o_o..Click, value
			End If
		End Sub

		' Token: 0x06004AF2 RID: 19186 RVA: 0x001F94D3 File Offset: 0x001F76D3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOoO.0O0o_0OOO.
		End Function

		' Token: 0x06004AF3 RID: 19187 RVA: 0x001F94DC File Offset: 0x001F76DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim c1Button As C1Button = Me.oOoO.0O0o_0OOO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOoO.0O0o_0OOO. = A_0
			c1Button = Me.oOoO.0O0o_0OOO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004AF4 RID: 19188 RVA: 0x001F951F File Offset: 0x001F771F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O__.o0oooO0.
		End Function

		' Token: 0x06004AF5 RID: 19189 RVA: 0x001F9528 File Offset: 0x001F7728
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim o__.o0oooO0. As C1Button = Me.O__.o0oooO0.
			If o__.o0oooO0. IsNot Nothing Then
				RemoveHandler o__.o0oooO0..Click, value
			End If
			Me.O__.o0oooO0. = A_0
			o__.o0oooO0. = Me.O__.o0oooO0.
			If o__.o0oooO0. IsNot Nothing Then
				AddHandler o__.o0oooO0..Click, value
			End If
		End Sub

		' Token: 0x06004AF6 RID: 19190 RVA: 0x001F956B File Offset: 0x001F776B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_.OoO0_o.
		End Function

		' Token: 0x06004AF7 RID: 19191 RVA: 0x001F9574 File Offset: 0x001F7774
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim c1Button As C1Button = Me.oo_.OoO0_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_.OoO0_o. = A_0
			c1Button = Me.oo_.OoO0_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004AF8 RID: 19192 RVA: 0x001F95B7 File Offset: 0x001F77B7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_0oo.OO.
		End Function

		' Token: 0x06004AF9 RID: 19193 RVA: 0x001F95C0 File Offset: 0x001F77C0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim o0_0oo.OO. As C1Button = Me.O0_0oo.OO.
			If o0_0oo.OO. IsNot Nothing Then
				RemoveHandler o0_0oo.OO..Click, value
			End If
			Me.O0_0oo.OO. = A_0
			o0_0oo.OO. = Me.O0_0oo.OO.
			If o0_0oo.OO. IsNot Nothing Then
				AddHandler o0_0oo.OO..Click, value
			End If
		End Sub

		' Token: 0x06004AFA RID: 19194 RVA: 0x001F9603 File Offset: 0x001F7803
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0.o_o_0o.
		End Function

		' Token: 0x06004AFB RID: 19195 RVA: 0x001F960C File Offset: 0x001F780C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim oo0.o_o_0o. As C1Button = Me.Oo0.o_o_0o.
			If oo0.o_o_0o. IsNot Nothing Then
				RemoveHandler oo0.o_o_0o..Click, value
			End If
			Me.Oo0.o_o_0o. = A_0
			oo0.o_o_0o. = Me.Oo0.o_o_0o.
			If oo0.o_o_0o. IsNot Nothing Then
				AddHandler oo0.o_o_0o..Click, value
			End If
		End Sub

		' Token: 0x06004AFC RID: 19196 RVA: 0x001F964F File Offset: 0x001F784F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.0_ooO.
		End Function

		' Token: 0x06004AFD RID: 19197 RVA: 0x001F9658 File Offset: 0x001F7858
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim c1Button As C1Button = Me.o.0_ooO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.0_ooO. = A_0
			c1Button = Me.o.0_ooO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004AFE RID: 19198 RVA: 0x001F969B File Offset: 0x001F789B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O_.O000__o.
		End Function

		' Token: 0x06004AFF RID: 19199 RVA: 0x001F96A4 File Offset: 0x001F78A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim c1Button As C1Button = Me.o0O_.O000__o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O_.O000__o. = A_0
			c1Button = Me.o0O_.O000__o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004B00 RID: 19200 RVA: 0x001F96E7 File Offset: 0x001F78E7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_0O.___Oo00_O.
		End Function

		' Token: 0x06004B01 RID: 19201 RVA: 0x001F96F0 File Offset: 0x001F78F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim c1Button As C1Button = Me.o_0O.___Oo00_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_0O.___Oo00_O. = A_0
			c1Button = Me.o_0O.___Oo00_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06004B02 RID: 19202 RVA: 0x001F9733 File Offset: 0x001F7933
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0.o0Oo0o0O.
		End Function

		' Token: 0x06004B03 RID: 19203 RVA: 0x001F973C File Offset: 0x001F793C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0oOO_0_.___0.
			Dim o0.o0Oo0o0O. As C1Button = Me.O0.o0Oo0o0O.
			If o0.o0Oo0o0O. IsNot Nothing Then
				RemoveHandler o0.o0Oo0o0O..Click, value
			End If
			Me.O0.o0Oo0o0O. = A_0
			o0.o0Oo0o0O. = Me.O0.o0Oo0o0O.
			If o0.o0Oo0o0O. IsNot Nothing Then
				AddHandler o0.o0Oo0o0O..Click, value
			End If
		End Sub

		' Token: 0x06004B04 RID: 19204 RVA: 0x001F977F File Offset: 0x001F797F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O._oOO_.
		End Function

		' Token: 0x06004B05 RID: 19205 RVA: 0x001F9788 File Offset: 0x001F7988
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0.OO_o__00o0_.
			Dim o0O._oOO_. As C1Button = Me.O0O._oOO_.
			If o0O._oOO_. IsNot Nothing Then
				RemoveHandler o0O._oOO_..Click, value
			End If
			Me.O0O._oOO_. = A_0
			o0O._oOO_. = Me.O0O._oOO_.
			If o0O._oOO_. IsNot Nothing Then
				AddHandler o0O._oOO_..Click, value
			End If
		End Sub

		' Token: 0x06004B06 RID: 19206 RVA: 0x001F97CB File Offset: 0x001F79CB
		<CompilerGenerated()>
		Private Shared Overloads Function <<EMPTY_NAME>>() As Application
			Return O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.
		End Function

		' Token: 0x06004B07 RID: 19207 RVA: 0x001F97D4 File Offset: 0x001F79D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Shared Sub <<EMPTY_NAME>>(A_0 As Application)
			Dim applicationEvents4_QuitEventHandler As ApplicationEvents4_QuitEventHandler = New ApplicationEvents4_QuitEventHandler(Nothing, CType(ldftn(AddressOf o0.OO_o__00o0_.), UIntPtr))
			Dim o_OO0._o0oo0. As Application = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.
			If o_OO0._o0oo0. IsNot Nothing Then
				o_OO0._o0oo0..Quit -= applicationEvents4_QuitEventHandler
			End If
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0. = A_0
			o_OO0._o0oo0. = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O_OO0._o0oo0.
			If o_OO0._o0oo0. IsNot Nothing Then
				o_OO0._o0oo0..Quit += applicationEvents4_QuitEventHandler
			End If
		End Sub

		' Token: 0x06004B08 RID: 19208
		Private Declare Ansi Function SetForegroundWindow Lib "user32" (A_0 As Integer) As Integer

		' Token: 0x06004B09 RID: 19209
		Private Declare Ansi Function SetActiveWindow Lib "user32" (A_0 As Integer) As Integer

		' Token: 0x06004B0A RID: 19210 RVA: 0x001F9814 File Offset: 0x001F7A14
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Try
				If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() IsNot Nothing AndAlso (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible OrElse Not O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible) Then
					Try
						For Each obj As Object In O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
							CType(obj, Document).Save()
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Dim objectValue As Object
					Dim objectValue2 As Object
					Dim objectValue3 As Object
					If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 0 Then
						Dim documents As Documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
						documents.Close(objectValue, objectValue2, objectValue3)
					End If
					Dim application As _Application = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.()
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
					application.Quit(objectValue3, objectValue2, objectValue)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06004B0B RID: 19211 RVA: 0x001F9930 File Offset: 0x001F7B30
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim objectValue As Object
			Dim objectValue2 As Object
			Dim objectValue3 As Object
			Try
				If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() IsNot Nothing AndAlso (O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible OrElse Not O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible) Then
					Try
						For Each obj As Object In O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
							CType(obj, Document).Saved = True
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 0 Then
						Dim documents As Documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
						documents.Close(objectValue, objectValue2, objectValue3)
					End If
					Dim application As _Application = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.()
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
					application.Quit(objectValue3, objectValue2, objectValue)
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(Nothing)
					GC.Collect()
					GC.Collect()
					GC.Collect()
					GC.Collect()
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Me.oo.oOOO0. = OO_00oOO.MainTable
			MyBase.TopMost = True
			MyBase.Location = New Point(CInt((SysInfo.ScreenWidth - CLng(MyBase.Width) - 30L)), 60)
			Me.OO_.0o.().Items.Add(OO_00oOO.MainTable.Name)
			Me.OO_.0o.().SelectedIndex = 0
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(New ApplicationClass())
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().WindowState = 1
			Dim documents2 As Documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue15 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			documents2.Open(Me.o_.Oo0oo., objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14, objectValue15)
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible = True
			Application.DoEvents()
			Try
				For Each obj2 As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
					Dim dataRelation As DataRelation = CType(obj2, DataRelation)
					If Operators.CompareString(dataRelation.ParentTable.TableName, OO_00oOO.MainTable.Name, True) = 0 Then
						If Not Me.OO_.0o.().Items.Contains(dataRelation.ChildTable.TableName) Then
							Me.OO_.0o.().Items.Add(dataRelation.ChildTable.TableName)
							Me.o_.Oo0oo..Add(dataRelation.ChildTable.TableName)
						End If
					ElseIf Operators.CompareString(dataRelation.ChildTable.TableName, OO_00oOO.MainTable.Name, True) = 0 AndAlso Not Me.OO_.0o.().Items.Contains(dataRelation.ParentTable.TableName) Then
						Me.OO_.0o.().Items.Add(dataRelation.ParentTable.TableName)
						Me.oOOo000o_._O__..Add(dataRelation.ParentTable.TableName)
					End If
				Next
			Finally
				Dim enumerator2 As IEnumerator
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
			End Try
			If Me.OO_.0o.().SelectedIndex = -1 Then
				Me.OO_.0o.().SelectedIndex = 0
			End If
			If Me.o_.Oo0oo..Count = 0 Then
				Me.Oooo.0.().Enabled = False
			End If
			Me.OO_O_.oO0_O.()
			Me.OO_.0o.().Enabled = True
		End Sub

		' Token: 0x06004B0C RID: 19212 RVA: 0x001F9D84 File Offset: 0x001F7F84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				If Not O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Visible Then
					MyBase.Close()
					Me.OO_.0o.().Enabled = False
				End If
			Catch ex As Exception
				MyBase.Close()
				Me.OO_.0o.().Enabled = False
			End Try
		End Sub

		' Token: 0x06004B0D RID: 19213 RVA: 0x001F9DE4 File Offset: 0x001F7FE4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = OO_00oOO.ProjectPath + "Reports\"
			If Not OO_00oOO.FileSys.DirectoryExists(text) Then
				OO_00oOO.FileSys.CreateDirectory(text)
			End If
			Dim text2 As String = text + OO_00oOO.FileSys.GetName(Me.o_.Oo0oo..ToString())
			Dim obj2 As Object
			If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents.Count > 1 Then
				Try
					For Each obj As Object In O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
						Dim document As Document = CType(obj, Document)
						If Operators.CompareString(document.FullName, text2, True) = 0 Then
							Dim document2 As _Document = document
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
							obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
							document2.Close(objectValue, objectValue2, obj2)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			If OO_00oOO.FileSys.FileExists(text2) AndAlso OO_00oOO.FileIsOpened(text2) Then
				MessageBox.Show("目标报表文件已经被其它进程打开，生成的报表将存为一个临时文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				text2 = Path.GetTempFileName()
			End If
			Me.OOo0_0o.o.().Enabled = False
			Dim documents As Documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
			obj2 = 1
			documents(obj2).Save()
			Dim wordReport As WordReport = New WordReport(OO_00oOO.MainTable, RuntimeHelpers.GetObjectValue(Me.o_.Oo0oo.), text2)
			wordReport.Build()
			wordReport.Quit()
			Dim obj3 As Object = text2
			If O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.() IsNot Nothing Then
				Dim documents2 As Documents = O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Documents
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				documents2.Open(obj3, obj2, objectValue2, objectValue, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14)
				Me.OOo0_0o.o.().Enabled = True
				Return
			End If
			MyBase.Close()
		End Sub

		' Token: 0x06004B0E RID: 19214 RVA: 0x001FA054 File Offset: 0x001F8254
		Public Sub New(A_0 As String)
			AddHandler MyBase.FormClosing, AddressOf Me.O.__o_o0_.
			AddHandler MyBase.Load, AddressOf Me.OOo0_0o.o.
			AddHandler MyBase.FormClosed, AddressOf Me.O.__o_o0_.
			Me.o_.Oo0oo. = New List(Of String)()
			Me.oOOo000o_._O__. = New List(Of String)()
			Me.O_Oo0o0.0O.()
			Me.o_.Oo0oo. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "Office2016White")
			Main.OO_O.o..Oo.oOo_o0Oo0.("MacBlue", New Object() { Me.OOo0_0o.o.() })
		End Sub

		' Token: 0x06004B0F RID: 19215 RVA: 0x001FA0F4 File Offset: 0x001F82F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO_.0o.().Items.Clear()
			Try
				For Each dataCol As DataCol In OO_00oOO.DataTables(Me.OO_.0o.().SelectedItem.ToString()).DataCols
					Me.OO_.0o.().Items.Add(dataCol.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.OO_.0o.().SelectedIndex = 0
			If Operators.CompareString(Me.OO_.0o.().Text, Me.oo.oOOO0..Name, True) = 0 Then
				Me.OO_.0o.().Items.Add("<Index>")
			End If
		End Sub

		' Token: 0x06004B10 RID: 19216 RVA: 0x001FA1BC File Offset: 0x001F83BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Me.OO_.0o.().SelectedItem IsNot Nothing Then
				Dim text As String = ""
				If Me.OOO_.0o0oo_.().Checked Then
					text = Me.OO_.0o.().SelectedItem.ToString() + ": "
				End If
				If Operators.CompareString(Me.OO_.0o.().Text, Me.oo.oOOO0..Name, True) = 0 Then
					If Control.ModifierKeys = Keys.Control Then
						MessageBox.Show("只有子表才能插入统计标记!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					ElseIf Control.ModifierKeys = Keys.Shift Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = "[&" + Me.OO_.0o.().SelectedItem.ToString() + ",48,48]"
					ElseIf Not Me.oooO._.().Checked Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = Me.OO_.0o.().SelectedItem.ToString()
					Else
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = text + "[" + Me.OO_.0o.().SelectedItem.ToString() + "]"
					End If
				ElseIf Me.o_.Oo0oo..Contains(Me.OO_.0o.().Text) Then
					If Control.ModifierKeys = Keys.Control Then
						If OO_00oOO.Tables(Me.OO_.0o.().Text).Cols(Me.OO_.0o.().SelectedItem.ToString()).IsNumeric() Then
							O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { "[%", Me.OO_.0o.().Text, ",Sum(", Me.OO_.0o.().SelectedItem.ToString(), ")]" })
						Else
							O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { "[%", Me.OO_.0o.().Text, ",Count(", Me.OO_.0o.().SelectedItem.ToString(), ")]" })
						End If
					ElseIf Control.ModifierKeys = Keys.Shift Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { text, "[@&", Me.OO_.0o.().Text, ",", Me.OO_.0o.().SelectedItem.ToString(), ",", Conversions.ToString(Conversions.ToInteger(Me.OO_.0o.().Value)), ",48,48]" })
					ElseIf Not Me.oooO._.().Checked Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = Me.OO_.0o.().SelectedItem.ToString()
					Else
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { text, "[@", Me.OO_.0o.().Text, ",", Me.OO_.0o.().SelectedItem.ToString(), ",", Conversions.ToString(Conversions.ToInteger(Me.OO_.0o.().Value)), "]" })
					End If
				ElseIf Me.oOOo000o_._O__..Contains(Me.OO_.0o.().Text) Then
					If Control.ModifierKeys = Keys.Control Then
						MessageBox.Show("只有子表才能插入统计标记!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					ElseIf Control.ModifierKeys = Keys.Shift Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { text, "[@&", Me.OO_.0o.().Text, ",", Me.OO_.0o.().SelectedItem.ToString(), ",48,48]" })
					ElseIf Not Me.oooO._.().Checked Then
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = Me.OO_.0o.().SelectedItem.ToString()
					Else
						O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = String.Concat(New String() { text, "[@", Me.OO_.0o.().Text, ",", Me.OO_.0o.().SelectedItem.ToString(), "]" })
					End If
				End If
				Me.OO_O_.oO0_O.()
			End If
		End Sub

		' Token: 0x06004B11 RID: 19217 RVA: 0x001FA668 File Offset: 0x001F8868
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer = OO_00oOO.FindAppWindow(OO_00oOO.FileSys.GetName(Me.o_.Oo0oo..ToString()))
			If num > 0 Then
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.SetForegroundWindow(num)
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.SetActiveWindow(num)
			End If
		End Sub

		' Token: 0x06004B12 RID: 19218 RVA: 0x001FA6A2 File Offset: 0x001F88A2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3002\u3000(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.(), Me.oo.oOOO0.).ShowDialog()
		End Sub

		' Token: 0x06004B13 RID: 19219 RVA: 0x001FA6BA File Offset: 0x001F88BA
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = CType(A_0, Button).Text
		End Sub

		' Token: 0x06004B14 RID: 19220 RVA: 0x001FA6D6 File Offset: 0x001F88D6
		Private Shared Sub <<EMPTY_NAME>>()
			O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.OO_.0o.(Nothing)
		End Sub

		' Token: 0x06004B15 RID: 19221 RVA: 0x001FA6E0 File Offset: 0x001F88E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text, "", True) > 0 Then
				O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text = Strings.StrConv(O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002.O.__o_o0_.().Selection.Text, VbStrConv.Narrow, 0)
			End If
		End Sub

		' Token: 0x06004B16 RID: 19222 RVA: 0x001FA72F File Offset: 0x001F892F
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001EB6 RID: 7862
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001EB7 RID: 7863
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EB8 RID: 7864
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001EB9 RID: 7865
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x04001EBA RID: 7866
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001EBB RID: 7867
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04001EBC RID: 7868
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04001EBD RID: 7869
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EBE RID: 7870
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001EBF RID: 7871
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EC0 RID: 7872
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EC1 RID: 7873
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001EC2 RID: 7874
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC3 RID: 7875
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC4 RID: 7876
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC5 RID: 7877
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC6 RID: 7878
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC7 RID: 7879
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC8 RID: 7880
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001EC9 RID: 7881
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001ECA RID: 7882
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001ECB RID: 7883
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001ECC RID: 7884
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001ECD RID: 7885
		<CompilerGenerated()>
		Private Shared <<EMPTY_NAME>> As Application

		' Token: 0x04001ECE RID: 7886
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04001ECF RID: 7887
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001ED0 RID: 7888
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001ED1 RID: 7889
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
