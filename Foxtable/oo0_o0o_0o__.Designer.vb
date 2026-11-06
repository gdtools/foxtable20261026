Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000270 RID: 624
	<DesignerGenerated()>
	Friend Class oo0_o0o_0o__
		Inherits UserControl

		' Token: 0x06001DF7 RID: 7671 RVA: 0x000BF14F File Offset: 0x000BD34F
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.O_oo.0oOO. IsNot Nothing Then
				Me.O_oo.0oOO..Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06001DF8 RID: 7672 RVA: 0x000BF170 File Offset: 0x000BD370
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O_oo.0oOO. = New Container()
			Me.O0OOo.o.(New ContextMenuStrip(Me.O_oo.0oOO.))
			Me.o_.oO0.(New ToolStripMenuItem())
			Me.o0_O.OOoOoo_.(New ToolStripMenuItem())
			Me.o0.Oo_oo0Oo0O.(New ToolStripMenuItem())
			Me.o0.Oo_oo0Oo0O.(New SplitContainer())
			Me.O0OOo.o.(New Label())
			Me.O0OOo.o.(New o_0OOo0o_0O_())
			Me.o00o._.().SuspendLayout()
			Me.o00o._.().Panel1.SuspendLayout()
			Me.o00o._.().Panel2.SuspendLayout()
			Me.o00o._.().SuspendLayout()
			CType(Me.o00o._.(), ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.o00o._.().Items.AddRange(New ToolStripItem() { Me.Ooo_ooo.0.(), Me.o.o0__.(), Me.o00o._.() })
			Me.o00o._.().Name = "ContextMenuStrip1"
			Me.o00o._.().Size = New Size(101, 70)
			Me.Ooo_ooo.0.().Name = "DeleteMenuItem"
			Me.Ooo_ooo.0.().Size = New Size(100, 22)
			Me.Ooo_ooo.0.().Text = "删除"
			Me.o.o0__.().Name = "MoveUpMenuItem"
			Me.o.o0__.().Size = New Size(100, 22)
			Me.o.o0__.().Text = "上移"
			Me.o00o._.().Name = "MoveDownMenuItem"
			Me.o00o._.().Size = New Size(100, 22)
			Me.o00o._.().Text = "下移"
			Me.o00o._.().Dock = DockStyle.Fill
			Me.o00o._.().FixedPanel = FixedPanel.Panel2
			Me.o00o._.().Location = New Point(0, 0)
			Me.o00o._.().Name = "SplitContainer1"
			Me.o00o._.().Orientation = Orientation.Horizontal
			Me.o00o._.().Panel1.Controls.Add(Me.o00o._.())
			Me.o00o._.().Panel2.Controls.Add(Me.o00o._.())
			Me.o00o._.().Size = New Size(523, 333)
			Me.o00o._.().SplitterDistance = 267
			Me.o00o._.().TabIndex = 7
			Me.o00o._.().BorderStyle = BorderStyle.Fixed3D
			Me.o00o._.().Dock = DockStyle.Fill
			Me.o00o._.().Location = New Point(0, 0)
			Me.o00o._.().Name = "Description"
			Me.o00o._.().Size = New Size(523, 62)
			Me.o00o._.().TabIndex = 0
			Me.o00o._.().Text = "提示:表设计器只能增加数据列，表达式列请执行""列""菜单下的""增加列→表达式列""命令来增加。列标题是列名更具描述性的表述，通常无需设置。"
			Me.o00o._.().AllowAddNew = True
			Me.o00o._.().AllowDelete = True
			Me.o00o._.().AllowSorting = 0
			Me.o00o._.().BorderStyle = 3
			Me.o00o._.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.o00o._.().ContextMenuStrip = Me.o00o._.()
			Me.o00o._.().Dock = DockStyle.Fill
			Me.o00o._.().ExtendLastCol = True
			Me.o00o._.().Location = New Point(0, 0)
			Me.o00o._.().Name = "C1FlexGrid1"
			Me.o00o._.().Rows.DefaultSize = 21
			Me.o00o._.().SelectionMode = 7
			Me.o00o._.().Size = New Size(523, 267)
			Me.o00o._.().TabIndex = 6
			Me.o00o._.().VisualStyle = 6
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.Controls.Add(Me.o00o._.())
			MyBase.Name = "OO.....o"
			MyBase.Size = New Size(523, 333)
			Me.o00o._.().ResumeLayout(False)
			Me.o00o._.().Panel1.ResumeLayout(False)
			Me.o00o._.().Panel2.ResumeLayout(False)
			Me.o00o._.().ResumeLayout(False)
			CType(Me.o00o._.(), ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001DF9 RID: 7673 RVA: 0x000BF5A6 File Offset: 0x000BD7A6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As o_0OOo0o_0O_
			Return Me.o0.Oo_oo0Oo0O.
		End Function

		' Token: 0x06001DFA RID: 7674 RVA: 0x000BF5B0 File Offset: 0x000BD7B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As o_0OOo0o_0O_)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.O0o.OOoo.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.oo.Oo_Oo.
			Dim rowColEventHandler3 As RowColEventHandler = AddressOf Me.oo_._oO.
			Dim rangeEventHandler As RangeEventHandler = AddressOf Me.ooo.O00_0__0.
			Dim rowColEventHandler4 As RowColEventHandler = AddressOf Me.oo0_oo_0_00.oO.
			Dim value As MouseEventHandler = AddressOf Me.ooo.O00_0__0.
			Dim rowColEventHandler5 As RowColEventHandler = AddressOf Me.ooo.O00_0__0.
			Dim validateEditEventHandler As ValidateEditEventHandler = AddressOf Me.ooo.O00_0__0.
			Dim value2 As PreviewKeyDownEventHandler = AddressOf Me.ooo.O00_0__0.
			Dim o_0OOo0o_0O_ As o_0OOo0o_0O_ = Me.o0.Oo_oo0Oo0O.
			If o_0OOo0o_0O_ IsNot Nothing Then
				o_0OOo0o_0O_.AfterAddRow -= rowColEventHandler
				o_0OOo0o_0O_.AfterDeleteRow -= rowColEventHandler2
				o_0OOo0o_0O_.AfterEdit -= rowColEventHandler3
				o_0OOo0o_0O_.AfterRowColChange -= rangeEventHandler
				o_0OOo0o_0O_.BeforeEdit -= rowColEventHandler4
				RemoveHandler o_0OOo0o_0O_.MouseUp, value
				o_0OOo0o_0O_.SetupEditor -= rowColEventHandler5
				o_0OOo0o_0O_.ValidateEdit -= validateEditEventHandler
				RemoveHandler o_0OOo0o_0O_.PreviewKeyDown, value2
			End If
			Me.o0.Oo_oo0Oo0O. = A_0
			o_0OOo0o_0O_ = Me.o0.Oo_oo0Oo0O.
			If o_0OOo0o_0O_ IsNot Nothing Then
				o_0OOo0o_0O_.AfterAddRow += rowColEventHandler
				o_0OOo0o_0O_.AfterDeleteRow += rowColEventHandler2
				o_0OOo0o_0O_.AfterEdit += rowColEventHandler3
				o_0OOo0o_0O_.AfterRowColChange += rangeEventHandler
				o_0OOo0o_0O_.BeforeEdit += rowColEventHandler4
				AddHandler o_0OOo0o_0O_.MouseUp, value
				o_0OOo0o_0O_.SetupEditor += rowColEventHandler5
				o_0OOo0o_0O_.ValidateEdit += validateEditEventHandler
				AddHandler o_0OOo0o_0O_.PreviewKeyDown, value2
			End If
		End Sub

		' Token: 0x06001DFB RID: 7675 RVA: 0x000BF6F0 File Offset: 0x000BD8F0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.O_oo.0oOO.
		End Function

		' Token: 0x06001DFC RID: 7676 RVA: 0x000BF6F8 File Offset: 0x000BD8F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.O_oo.0oOO. = A_0
		End Sub

		' Token: 0x06001DFD RID: 7677 RVA: 0x000BF701 File Offset: 0x000BD901
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0.Oo_oo0Oo0O.
		End Function

		' Token: 0x06001DFE RID: 7678 RVA: 0x000BF709 File Offset: 0x000BD909
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0.Oo_oo0Oo0O. = A_0
		End Sub

		' Token: 0x06001DFF RID: 7679 RVA: 0x000BF712 File Offset: 0x000BD912
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.o0.Oo_oo0Oo0O.
		End Function

		' Token: 0x06001E00 RID: 7680 RVA: 0x000BF71A File Offset: 0x000BD91A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.o0.Oo_oo0Oo0O. = A_0
		End Sub

		' Token: 0x06001E01 RID: 7681 RVA: 0x000BF724 File Offset: 0x000BD924
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o0.Oo_oo0Oo0O.
		End Function

		' Token: 0x06001E02 RID: 7682 RVA: 0x000BF738 File Offset: 0x000BD938
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o.o0__.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o0.Oo_oo0Oo0O.
				Dim num As Integer = 3
				While True
					Select Case num
						Case 0
							AddHandler toolStripMenuItem.Click, value
							num = 2
							Continue For
						Case 1
							RemoveHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 2
							Return
						Case 3
							If True Then
							End If
							If toolStripMenuItem IsNot Nothing Then
								num = 1
								Continue For
							End If
							GoTo IL_62
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
					Me.o0.Oo_oo0Oo0O. = A_0
					toolStripMenuItem = Me.o0.Oo_oo0Oo0O.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x06001E03 RID: 7683 RVA: 0x000BF7E4 File Offset: 0x000BD9E4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.oo__O.0_00.
		End Function

		' Token: 0x06001E04 RID: 7684 RVA: 0x000BF7F8 File Offset: 0x000BD9F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O_._O0Oo_o.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.oo__O.0_00.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							AddHandler toolStripMenuItem.Click, value
							num = 1
							Continue For
						Case 1
							Return
						Case 2
							RemoveHandler toolStripMenuItem.Click, value
							num = 4
							Continue For
						Case 3
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 4
							GoTo IL_62
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								If True Then
								End If
								num = 2
								Continue For
							End If
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.oo__O.0_00. = A_0
					toolStripMenuItem = Me.oo__O.0_00.
					num = 3
				End While
			End While
		End Sub

		' Token: 0x06001E05 RID: 7685 RVA: 0x000BF8A4 File Offset: 0x000BDAA4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o0_O.OOoOoo_.
		End Function

		' Token: 0x06001E06 RID: 7686 RVA: 0x000BF8B8 File Offset: 0x000BDAB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.OoO_Oo._o.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o0_O.OOoOoo_.
				Dim num As Integer = 0
				While True
					Select Case num
						Case 0
							If toolStripMenuItem IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_5A
						Case 1
							AddHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 2
							If toolStripMenuItem IsNot Nothing Then
								num = 1
								Continue For
							End If
							Return
						Case 3
							Return
						Case 4
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 5
							Continue For
						Case 5
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.o0_O.OOoOoo_. = A_0
					toolStripMenuItem = Me.o0_O.OOoOoo_.
					num = 2
				End While
			End While
		End Sub

		' Token: 0x06001E07 RID: 7687 RVA: 0x000BF960 File Offset: 0x000BDB60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.o00o._.().Rows(A_1.Row)("类型") = ColumnDataTypeEnum.[String]
			Me.o00o._.().Rows(A_1.Row)("长度") = 16
			Me.O0OOo.o.()
		End Sub

		' Token: 0x06001E08 RID: 7688 RVA: 0x000BF9C4 File Offset: 0x000BDBC4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.O0OOo.o.()
		End Sub

		' Token: 0x06001E09 RID: 7689 RVA: 0x000BF9CC File Offset: 0x000BDBCC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Try
				Me.O_oo.0oOO..DefaultView(Me.o00o._.().Rows(A_1.Row).DataIndex).EndEdit()
				If Operators.CompareString(Me.o00o._.().Cols(A_1.Col).Name, "类型", True) = 0 Then
					If Conversions.ToInteger(Me.o00o._.()(A_1.Row, "类型")) = 202 Then
						Me.o00o._.()(A_1.Row, "长度") = 16
					Else
						Me.o00o._.()(A_1.Row, "长度") = DBNull.Value
					End If
					Me.O0OOo.o.()
				End If
				If A_1.Row = Me.o00o._.().Rows.Count - 2 Then
					Me.o00o._.().TopRow = Me.o00o._.().Rows.Count - 1
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End Try
		End Sub

		' Token: 0x06001E0A RID: 7690 RVA: 0x000BFB00 File Offset: 0x000BDD00
		Private Sub <<EMPTY_NAME>>()
			If Me.o00o._.().Row >= 1 Then
				Dim o_0OOo0o_0O_ As o_0OOo0o_0O_ = Me.o00o._.()
				If o_0OOo0o_0O_(o_0OOo0o_0O_.Row, "类型") Is DBNull.Value Then
					Me.o00o._.().Text = ""
				Else
					Me.o00o._.().Text = ooO.oO0__o.0o__.(CType(Conversions.ToInteger(o_0OOo0o_0O_(o_0OOo0o_0O_.Row, "类型")), ColumnDataTypeEnum))
				End If
			End If
		End Sub

		' Token: 0x06001E0B RID: 7691 RVA: 0x000BFB74 File Offset: 0x000BDD74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			If A_1.NewRange.r1 <> A_1.OldRange.r1 Then
				Me.O0OOo.o.()
			End If
			If Operators.CompareString(Me.o00o._.().Cols(Me.o00o._.().Col).Name, "长度", True) = 0 Then
				Me.o00o._.().ImeMode = ImeMode.Close
			Else
				Me.o00o._.().ImeMode = ImeMode.NoControl
			End If
			If Operators.CompareString(Me.o00o._.().Cols(Me.o00o._.().Col).Name, "列名", True) = 0 AndAlso Me.o00o._.().Row > 0 Then
				Dim mouseButtons As MouseButtons = Control.MouseButtons
			End If
		End Sub

		' Token: 0x06001E0C RID: 7692 RVA: 0x000BFC2E File Offset: 0x000BDE2E
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.o0.Oo_oo0Oo0O.
			Me.O_oo.0oOO. = New DataTable()
			Me.o.o0__.()
			Me.o00o._.().Rows.DefaultSize = 21
		End Sub

		' Token: 0x06001E0D RID: 7693 RVA: 0x000BFC6C File Offset: 0x000BDE6C
		Friend Sub <<EMPTY_NAME>>()
			Me.O_oo.0oOO..Columns.Add("ID", GetType(Integer))
			Me.O_oo.0oOO..Columns.Add("列名", GetType(String))
			Me.O_oo.0oOO..Columns.Add("类型", GetType(ColumnDataTypeEnum))
			Me.O_oo.0oOO..Columns.Add("长度", GetType(Byte))
			Me.O_oo.0oOO..Columns.Add("标题", GetType(String))
			Me.O_oo.0oOO..Columns("列名").MaxLength = 64
			Me.O_oo.0oOO..Columns("列名").Unique = True
			Me.O_oo.0oOO..Columns("ID").AutoIncrement = True
			Me.O_oo.0oOO..DefaultView.Sort = "ID"
			Me.o00o._.().DataSource = Me.O_oo.0oOO.
			Me.o00o._.().Cols.Remove("ID")
			Me.O_oo.0oOO. = CType(Me.BindingContext(Me.O_oo.0oOO.), CurrencyManager)
			Me.O_0Oo_._00oo0.()
			Me.o00o._.().Cols("列名").Width = 120
			Me.o00o._.().Cols("类型").Width = 80
			Me.o00o._.().Cols("长度").Width = 40
			Me.o00o._.().Cols("标题").Width = 10
			Me.o00o._.().ExtendLastCol = True
		End Sub

		' Token: 0x06001E0E RID: 7694 RVA: 0x000BFE48 File Offset: 0x000BE048
		Friend Sub <<EMPTY_NAME>>()
			Dim listDictionary As ListDictionary = New ListDictionary()
			listDictionary.Add(ColumnDataTypeEnum.[String], "字符")
			listDictionary.Add(ColumnDataTypeEnum.DateTime, "日期时间")
			listDictionary.Add(ColumnDataTypeEnum.[Boolean], "逻辑")
			listDictionary.Add(ColumnDataTypeEnum.[Integer], "整数")
			If Not Me.O_oo.0oOO. Then
				listDictionary.Add(ColumnDataTypeEnum.[Long], "长整数")
			End If
			listDictionary.Add(ColumnDataTypeEnum.[Short], "短整数")
			listDictionary.Add(ColumnDataTypeEnum.[Byte], "微整数")
			listDictionary.Add(ColumnDataTypeEnum.[Double], "双精度小数")
			listDictionary.Add(ColumnDataTypeEnum.[Single], "单精度小数")
			listDictionary.Add(ColumnDataTypeEnum.[Decimal], "高精度小数")
			listDictionary.Add(ColumnDataTypeEnum.Text, "备注")
			Me.o00o._.().Cols("类型").DataMap = listDictionary
		End Sub

		' Token: 0x06001E0F RID: 7695 RVA: 0x000BFF48 File Offset: 0x000BE148
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row <> 0 AndAlso Operators.CompareString(Me.o00o._.().Cols(A_1.Col).Name, "长度", True) = 0 AndAlso Conversions.ToInteger(Me.o00o._.()(A_1.Row, "类型")) <> 202 Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06001E10 RID: 7696 RVA: 0x000BFFB0 File Offset: 0x000BE1B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Operators.CompareString(Me.o00o._.().Cols(Me.o00o._.().Col).Name, "列名", True) = 0 AndAlso Me.o00o._.().Selection.IsSingleCell AndAlso Me.o00o._.().Row > 0 Then
				Dim mouseButtons As MouseButtons = Control.MouseButtons
			End If
		End Sub

		' Token: 0x06001E11 RID: 7697 RVA: 0x000C0013 File Offset: 0x000BE213
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If TypeOf Me.o00o._.().Editor Is ComboBox Then
				CType(Me.o00o._.().Editor, ComboBox).MaxDropDownItems = 20
			End If
		End Sub

		' Token: 0x06001E12 RID: 7698 RVA: 0x000C0040 File Offset: 0x000BE240
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			If Operators.CompareString(Me.o00o._.().Cols(A_1.Col).Name, "列名", True) = 0 AndAlso Not o_O_o_oOoo__.O_o_._o0.(Me.o00o._.().Editor.Text, "列名", 64, False) Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06001E13 RID: 7699 RVA: 0x000C009B File Offset: 0x000BE29B
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_._O0Oo_o.()
		End Sub

		' Token: 0x06001E14 RID: 7700 RVA: 0x000C00A4 File Offset: 0x000BE2A4
		Friend Sub <<EMPTY_NAME>>()
			If Me.O_oo.0oOO..Position < Me.O_oo.0oOO..Count - 1 Then
				Dim position As Integer = Me.O_oo.0oOO..Position
				Dim row As DataRow = Me.O_oo.0oOO..DefaultView(Me.O_oo.0oOO..Position).Row
				Dim row2 As DataRow = Me.O_oo.0oOO..DefaultView(Me.O_oo.0oOO..Position + 1).Row
				Dim num As Integer = Conversions.ToInteger(row("ID"))
				row("ID") = RuntimeHelpers.GetObjectValue(row2("ID"))
				row2("ID") = num
				Me.O_oo.0oOO..Position = position + 1
			End If
			Me.o00o._.().Focus()
		End Sub

		' Token: 0x06001E15 RID: 7701 RVA: 0x000C0173 File Offset: 0x000BE373
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OoO_Oo._o.()
		End Sub

		' Token: 0x06001E16 RID: 7702 RVA: 0x000C017C File Offset: 0x000BE37C
		Friend Sub <<EMPTY_NAME>>()
			If Me.O_oo.0oOO..Position > 0 Then
				Dim position As Integer = Me.O_oo.0oOO..Position
				Dim row As DataRow = Me.O_oo.0oOO..DefaultView(Me.O_oo.0oOO..Position).Row
				Dim row2 As DataRow = Me.O_oo.0oOO..DefaultView(Me.O_oo.0oOO..Position - 1).Row
				Dim num As Integer = Conversions.ToInteger(row("ID"))
				row("ID") = RuntimeHelpers.GetObjectValue(row2("ID"))
				row2("ID") = num
				Me.O_oo.0oOO..Position = position - 1
			End If
			Me.o00o._.().Focus()
		End Sub

		' Token: 0x06001E17 RID: 7703 RVA: 0x000C023F File Offset: 0x000BE43F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0o.OOoo.()
		End Sub

		' Token: 0x06001E18 RID: 7704 RVA: 0x000C0248 File Offset: 0x000BE448
		Friend Sub <<EMPTY_NAME>>()
			Dim list As List(Of DataRow) = New List(Of DataRow)()
			If Me.o00o._.().Selection.TopRow >= Me.o00o._.().Rows.Fixed Then
				Dim topRow As Integer = Me.o00o._.().Selection.TopRow
				Dim bottomRow As Integer = Me.o00o._.().Selection.BottomRow
				Dim num As Integer = topRow
				While num <= bottomRow AndAlso num <> Me.o00o._.().Rows.Count - 1
					list.Add(Me.O_oo.0oOO..DefaultView(num - 1).Row)
					num += 1
				End While
				Try
					For Each dataRow As DataRow In list
						dataRow.Delete()
					Next
				Finally
					Dim enumerator As List(Of DataRow).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.o00o._.().Focus()
			End If
		End Sub

		' Token: 0x06001E19 RID: 7705 RVA: 0x000C0334 File Offset: 0x000BE534
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If(Me.o00o._.().Row >= Me.o00o._.().Rows.Fixed And Me.o00o._.().Col >= Me.o00o._.().Cols.Fixed) AndAlso Me.o00o._.().Editor Is Nothing AndAlso A_1.KeyCode = Keys.ProcessKey AndAlso (Me.o00o._.().Col = 1 OrElse Me.o00o._.().Col = 4) Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o00o._.().GetData(Me.o00o._.().Row, Me.o00o._.().Col))
				Dim text As String = ""
				If objectValue IsNot Nothing Then
					text = objectValue.ToString()
				End If
				Me.o00o._.().StartEditing()
				Application.DoEvents()
				If Operators.CompareString(Me.o00o._.().Editor.Text, text, True) <> 0 Then
					text = Me.o00o._.().Editor.Text
					Me.o00o._.().Editor.Text = ""
					SendKeys.Send(text)
				End If
			End If
		End Sub

		' Token: 0x06001E1A RID: 7706 RVA: 0x000C0454 File Offset: 0x000BE654
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.o00o._.()
			c1FlexGrid.Styles.SelectedColumnHeader.Clear()
			c1FlexGrid.Styles.Alternate.Clear()
			c1FlexGrid.Styles.Focus.Clear()
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
			c1FlexGrid.FocusRect = 3
			c1FlexGrid.AllowSorting = 0
			Me.o00o._.().BackColor = Color.White
			Me.o00o._.().Padding = New Padding(3, 4, 3, 0)
		End Sub

		' Token: 0x04000C94 RID: 3220
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C95 RID: 3221
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o_0OOo0o_0O_

		' Token: 0x04000C96 RID: 3222
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x04000C97 RID: 3223
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000C98 RID: 3224
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04000C99 RID: 3225
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000C9A RID: 3226
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000C9B RID: 3227
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04000C9C RID: 3228
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000C9D RID: 3229
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C9E RID: 3230
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000C9F RID: 3231
		Private <<EMPTY_NAME>> As CurrencyManager
	End Class
End Namespace
