Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000349 RID: 841
	<DesignerGenerated()>
	Friend Partial Class ef
		Inherits Form

		' Token: 0x06003339 RID: 13113 RVA: 0x0014F638 File Offset: 0x0014D838
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OO.____oo. IsNot Nothing Then
					Me.OO.____oo..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600333A RID: 13114 RVA: 0x0014F678 File Offset: 0x0014D878
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(ef))
			Me.O_O.__OO____o.(New C1FlexGrid())
			Me.O_O.__OO____o.(New C1Button())
			Me.o_0.0.(New C1Button())
			Me.O.0oooO.(New C1Button())
			Me.O____O._0oo_.(New C1Button())
			Me.o.0OOO.(New C1Button())
			Me.O_O.__OO____o.(New ListBox())
			Me.O.O0_O.(New C1Button())
			Me.O.O00O0oOo_.().BeginInit()
			MyBase.SuspendLayout()
			Me.O.O00O0oOo_.().AllowDragging = 0
			Me.O.O00O0oOo_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O.O00O0oOo_.().AutoClipboard = True
			Me.O.O00O0oOo_.().BorderStyle = 4
			Me.O.O00O0oOo_.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.O.O00O0oOo_.().ExtendLastCol = True
			Me.O.O00O0oOo_.().Font = New Font("宋体", 9F)
			Me.O.O00O0oOo_.().Location = New Point(18, 18)
			Me.O.O00O0oOo_.().Margin = New Padding(4, 4, 4, 4)
			Me.O.O00O0oOo_.().Name = "C1FlexGrid1"
			Me.O.O00O0oOo_.().Rows.Count = 1
			Me.O.O00O0oOo_.().Rows.DefaultSize = 21
			Me.O.O00O0oOo_.().SelectionMode = 1
			Me.O.O00O0oOo_.().Size = New Size(731, 311)
			Me.O.O00O0oOo_.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.O.O00O0oOo_.().TabIndex = 0
			Me.O.O00O0oOo_.().VisualStyle = 1
			Me.OO0.o0o.().Location = New Point(836, 339)
			Me.OO0.o0o.().Margin = New Padding(4, 4, 4, 4)
			Me.OO0.o0o.().Name = "btnOK"
			Me.OO0.o0o.().Size = New Size(112, 34)
			Me.OO0.o0o.().TabIndex = 3
			Me.OO0.o0o.().Text = "筛选"
			Me.OO0.o0o.().UseVisualStyleBackColor = True
			Me.o_0o.0oO0OO_.().Location = New Point(18, 339)
			Me.o_0o.0oO0OO_.().Margin = New Padding(4, 4, 4, 4)
			Me.o_0o.0oO0OO_.().Name = "btnDelete"
			Me.o_0o.0oO0OO_.().Size = New Size(112, 34)
			Me.o_0o.0oO0OO_.().TabIndex = 1
			Me.o_0o.0oO0OO_.().Text = "删除条件"
			Me.o_0o.0oO0OO_.().UseVisualStyleBackColor = True
			Me.oOoo0__o00o.o.().Location = New Point(140, 339)
			Me.oOoo0__o00o.o.().Margin = New Padding(4, 4, 4, 4)
			Me.oOoo0__o00o.o.().Name = "btnClear"
			Me.oOoo0__o00o.o.().Size = New Size(112, 34)
			Me.oOoo0__o00o.o.().TabIndex = 2
			Me.oOoo0__o00o.o.().Text = "清除条件"
			Me.oOoo0__o00o.o.().UseVisualStyleBackColor = True
			Me.o0.0_oo_Oo0O.().Location = New Point(261, 339)
			Me.o0.0_oo_Oo0O.().Margin = New Padding(4, 4, 4, 4)
			Me.o0.0_oo_Oo0O.().Name = "btnSave"
			Me.o0.0_oo_Oo0O.().Size = New Size(112, 34)
			Me.o0.0_oo_Oo0O.().TabIndex = 11
			Me.o0.0_oo_Oo0O.().Text = "保存设置"
			Me.o0.0_oo_Oo0O.().UseVisualStyleBackColor = True
			Me.O._O0OO00_O.().Location = New Point(382, 339)
			Me.O._O0OO00_O.().Margin = New Padding(4, 4, 4, 4)
			Me.O._O0OO00_O.().Name = "btnList"
			Me.O._O0OO00_O.().Size = New Size(112, 34)
			Me.O._O0OO00_O.().TabIndex = 12
			Me.O._O0OO00_O.().Text = "设置管理"
			Me.O._O0OO00_O.().UseVisualStyleBackColor = True
			Me.O.O00O0oOo_.().Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.O.O00O0oOo_.().FormattingEnabled = True
			Me.O.O00O0oOo_.().IntegralHeight = False
			Me.O.O00O0oOo_.().ItemHeight = 18
			Me.O.O00O0oOo_.().Location = New Point(759, 18)
			Me.O.O00O0oOo_.().Margin = New Padding(4, 4, 4, 4)
			Me.O.O00O0oOo_.().Name = "ListBox1"
			Me.O.O00O0oOo_.().Size = New Size(187, 310)
			Me.O.O00O0oOo_.().TabIndex = 13
			Me.OO._O.().Location = New Point(714, 339)
			Me.OO._O.().Margin = New Padding(4, 4, 4, 4)
			Me.OO._O.().Name = "Button1"
			Me.OO._O.().Size = New Size(112, 34)
			Me.OO._O.().TabIndex = 14
			Me.OO._O.().Text = "撤销筛选"
			Me.OO._O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(966, 388)
			MyBase.Controls.Add(Me.OO._O.())
			MyBase.Controls.Add(Me.O.O00O0oOo_.())
			MyBase.Controls.Add(Me.o0.0_oo_Oo0O.())
			MyBase.Controls.Add(Me.O._O0OO00_O.())
			MyBase.Controls.Add(Me.oOoo0__o00o.o.())
			MyBase.Controls.Add(Me.o_0o.0oO0OO_.())
			MyBase.Controls.Add(Me.OO0.o0o.())
			MyBase.Controls.Add(Me.O.O00O0oOo_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Oo._.1_0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "高级筛选"
			Me.O.O00O0oOo_.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600333B RID: 13115 RVA: 0x0014FCA4 File Offset: 0x0014DEA4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.OO.____oo.
		End Function

		' Token: 0x0600333C RID: 13116 RVA: 0x0014FCAC File Offset: 0x0014DEAC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.O_O0_.0O.
			Dim eventHandler As EventHandler = AddressOf Me.O00O0.oo_0.
			Dim validateEditEventHandler As ValidateEditEventHandler = AddressOf Me.OO0.o0o.
			Dim oo.____oo. As C1FlexGrid = Me.OO.____oo.
			If oo.____oo. IsNot Nothing Then
				oo.____oo..AfterAddRow -= rowColEventHandler
				oo.____oo..EnterCell -= eventHandler
				oo.____oo..ValidateEdit -= validateEditEventHandler
			End If
			Me.OO.____oo. = A_0
			oo.____oo. = Me.OO.____oo.
			If oo.____oo. IsNot Nothing Then
				oo.____oo..AfterAddRow += rowColEventHandler
				oo.____oo..EnterCell += eventHandler
				oo.____oo..ValidateEdit += validateEditEventHandler
			End If
		End Sub

		' Token: 0x0600333D RID: 13117 RVA: 0x0014FD25 File Offset: 0x0014DF25
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O.__OO____o.
		End Function

		' Token: 0x0600333E RID: 13118 RVA: 0x0014FD30 File Offset: 0x0014DF30
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.o_o000Oo.
			Dim o_O.__OO____o. As C1Button = Me.O_O.__OO____o.
			If o_O.__OO____o. IsNot Nothing Then
				RemoveHandler o_O.__OO____o..Click, value
			End If
			Me.O_O.__OO____o. = A_0
			o_O.__OO____o. = Me.O_O.__OO____o.
			If o_O.__OO____o. IsNot Nothing Then
				AddHandler o_O.__OO____o..Click, value
			End If
		End Sub

		' Token: 0x0600333F RID: 13119 RVA: 0x0014FD73 File Offset: 0x0014DF73
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.O0_O.
		End Function

		' Token: 0x06003340 RID: 13120 RVA: 0x0014FD7C File Offset: 0x0014DF7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_0.oOO_O__oO0.
			Dim o.O0_O. As C1Button = Me.O.O0_O.
			If o.O0_O. IsNot Nothing Then
				RemoveHandler o.O0_O..Click, value
			End If
			Me.O.O0_O. = A_0
			o.O0_O. = Me.O.O0_O.
			If o.O0_O. IsNot Nothing Then
				AddHandler o.O0_O..Click, value
			End If
		End Sub

		' Token: 0x06003341 RID: 13121 RVA: 0x0014FDBF File Offset: 0x0014DFBF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.0OOO.
		End Function

		' Token: 0x06003342 RID: 13122 RVA: 0x0014FDC8 File Offset: 0x0014DFC8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOOo.o.
			Dim c1Button As C1Button = Me.o.0OOO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.0OOO. = A_0
			c1Button = Me.o.0OOO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003343 RID: 13123 RVA: 0x0014FE0B File Offset: 0x0014E00B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_0._o0oO.
		End Function

		' Token: 0x06003344 RID: 13124 RVA: 0x0014FE14 File Offset: 0x0014E014
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo00OO_00o.o0_.
			Dim o0_0._o0oO. As C1Button = Me.O0_0._o0oO.
			If o0_0._o0oO. IsNot Nothing Then
				RemoveHandler o0_0._o0oO..Click, value
			End If
			Me.O0_0._o0oO. = A_0
			o0_0._o0oO. = Me.O0_0._o0oO.
			If o0_0._o0oO. IsNot Nothing Then
				AddHandler o0_0._o0oO..Click, value
			End If
		End Sub

		' Token: 0x06003345 RID: 13125 RVA: 0x0014FE57 File Offset: 0x0014E057
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo_o_.0.
		End Function

		' Token: 0x06003346 RID: 13126 RVA: 0x0014FE60 File Offset: 0x0014E060
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_.o0.
			Dim ooo_o_.0. As C1Button = Me.Ooo_o_.0.
			If ooo_o_.0. IsNot Nothing Then
				RemoveHandler ooo_o_.0..Click, value
			End If
			Me.Ooo_o_.0. = A_0
			ooo_o_.0. = Me.Ooo_o_.0.
			If ooo_o_.0. IsNot Nothing Then
				AddHandler ooo_o_.0..Click, value
			End If
		End Sub

		' Token: 0x06003347 RID: 13127 RVA: 0x0014FEA3 File Offset: 0x0014E0A3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.OO.____oo.
		End Function

		' Token: 0x06003348 RID: 13128 RVA: 0x0014FEAC File Offset: 0x0014E0AC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Dim value As MouseEventHandler = AddressOf Me.O.O00O0oOo_.
			Dim oo.____oo. As ListBox = Me.OO.____oo.
			If oo.____oo. IsNot Nothing Then
				RemoveHandler oo.____oo..MouseDoubleClick, value
			End If
			Me.OO.____oo. = A_0
			oo.____oo. = Me.OO.____oo.
			If oo.____oo. IsNot Nothing Then
				AddHandler oo.____oo..MouseDoubleClick, value
			End If
		End Sub

		' Token: 0x06003349 RID: 13129 RVA: 0x0014FEEF File Offset: 0x0014E0EF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_._oo_.
		End Function

		' Token: 0x0600334A RID: 13130 RVA: 0x0014FEF8 File Offset: 0x0014E0F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O0_.0O.
			Dim c1Button As C1Button = Me.o0_._oo_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_._oo_. = A_0
			c1Button = Me.o0_._oo_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600334B RID: 13131 RVA: 0x0014FF3C File Offset: 0x0014E13C
		Public Sub New(A_0 As Table)
			AddHandler MyBase.FormClosing, AddressOf Me.OO0.o0o.
			AddHandler MyBase.Load, AddressOf Me.oO_0_o_.00O.
			AddHandler MyBase.FormClosed, AddressOf Me.OO0.o0o.
			Me.OO.____oo. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			Me.O.O00O0oOo_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim c1FlexGrid As C1FlexGrid = Me.O.O00O0oOo_.()
			c1FlexGrid.Styles.SelectedColumnHeader.Clear()
			c1FlexGrid.Styles.Alternate.Clear()
			c1FlexGrid.Styles.Focus.Clear()
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
			c1FlexGrid.FocusRect = 3
			c1FlexGrid.AllowSorting = 0
			Me.OO.____oo. = A_0
			Me.OO.____oo. = New DataView(Me.OO.____oo., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(7), "", DataViewRowState.CurrentRows)
			Me.OO.____oo. = CType(Me.BindingContext(Me.OO.____oo.), CurrencyManager)
			Me.O.O00O0oOo_.().DataSource = Me.OO.____oo.
			Me.O.O00O0oOo_.().DisplayMember = "Name"
			Me.O.O00O0oOo_.().Rows.DefaultSize = 22
			Me.O.O00O0oOo_.().Styles.Fixed.TextAlign = 4
		End Sub

		' Token: 0x0600334C RID: 13132 RVA: 0x001500BE File Offset: 0x0014E2BE
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			Me.OO.____oo..o.OO0O0O. = Me.o00o_.0.()
		End Sub

		' Token: 0x0600334D RID: 13133 RVA: 0x001500D4 File Offset: 0x0014E2D4
		Private Function <<EMPTY_NAME>>() As String
			Dim text As String = ""
			Dim fixed As Integer = Me.O.O00O0oOo_.().Rows.Fixed
			Dim num As Integer = Me.O.O00O0oOo_.().Rows.Count - 2
			For i As Integer = fixed To num
				If Operators.CompareString(text, "", True) > 0 Then
					text += Me.O.O00O0oOo_.().ClipSeparators.Substring(1)
				End If
				Dim fixed2 As Integer = Me.O.O00O0oOo_.().Cols.Fixed
				Dim num2 As Integer = Me.O.O00O0oOo_.().Cols.Count - 1
				For j As Integer = fixed2 To num2
					If j > Me.O.O00O0oOo_.().Cols.Fixed Then
						text += Me.O.O00O0oOo_.().ClipSeparators.Substring(0, 1)
					End If
					If Me.O.O00O0oOo_.().GetData(i, j) Is Nothing Then
						text = (If(text, ""))
					Else
						text += Me.O.O00O0oOo_.().GetData(i, j).ToString()
					End If
				Next
			Next
			Return text
		End Function

		' Token: 0x0600334E RID: 13134 RVA: 0x001501DC File Offset: 0x0014E3DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.O00O0oOo_.().Rows.Count > 2 Then
				Me.OO.____oo..o.OO0O0O. = Me.o00o_.0.()
			End If
			Me.O.O00O0oOo_.().Rows.Count = Me.O.O00O0oOo_.().Rows.Fixed
			Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
			Try
				For Each col As Col In Me.OO.____oo..Cols
					Dim text As String = col.Caption
					If dictionary.ContainsKey(text) OrElse Me.OO.____oo..Cols.Contains(text) Then
						text = col.Name
					End If
					dictionary.Add(col.Name, text)
				Next
			Finally
				Dim enumerator As IEnumerator(Of Col)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Me.O.O00O0oOo_.().Cols(1).DataMap = dictionary
			If Operators.CompareString(Me.OO.____oo..o.OO0O0O., "", True) > 0 Then
				Me.O.O00O0oOo_.(Me.OO.____oo..o.OO0O0O.)
			End If
			Me.O.O00O0oOo_.().AllowAddNew = True
		End Sub

		' Token: 0x0600334F RID: 13135 RVA: 0x001502F8 File Offset: 0x0014E4F8
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O.O00O0oOo_.().AllowAddNew = False
			Me.O.O00O0oOo_.().Rows.Count = Me.O.O00O0oOo_.().Rows.Fixed
			For Each text As String In A_0.Split(Me.O.O00O0oOo_.().ClipSeparators.Substring(1).ToCharArray())
				Me.O.O00O0oOo_.().AddItem(text)
			Next
			Dim num As Integer = Me.O.O00O0oOo_.().Rows.Count - 1
			Dim fixed As Integer = Me.O.O00O0oOo_.().Rows.Fixed
			For j As Integer = num To fixed Step -1
				If Not Me.OO.____oo..foxGrid.Cols.Contains(Me.O.O00O0oOo_.()(j, 1).ToString()) Then
					Me.O.O00O0oOo_.().RemoveItem(j)
				End If
			Next
			Me.O.O00O0oOo_.().AllowAddNew = True
		End Sub

		' Token: 0x06003350 RID: 13136 RVA: 0x001503E2 File Offset: 0x0014E5E2
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.O.O00O0oOo_.()(A_1.Row, 0) = "And"
			Me.O.O00O0oOo_.()(A_1.Row, 2) = "等于"
		End Sub

		' Token: 0x06003351 RID: 13137 RVA: 0x00150414 File Offset: 0x0014E614
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O.O00O0oOo_.().Rows.Count > 2 AndAlso Me.O.O00O0oOo_.().Row >= Me.O.O00O0oOo_.().Rows.Fixed Then
				Me.O.O00O0oOo_.().Rows.Remove(Me.O.O00O0oOo_.().Row)
			End If
		End Sub

		' Token: 0x06003352 RID: 13138 RVA: 0x00150470 File Offset: 0x0014E670
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.O.O00O0oOo_.()
			If Operators.CompareString(text, "", True) > 0 Then
				Filter.O0O0o.Oo0OO_oO.(Me.OO.____oo., text, False)
				Main.OO_O.o..Refresh()
			End If
		End Sub

		' Token: 0x06003353 RID: 13139 RVA: 0x001504AC File Offset: 0x0014E6AC
		Private Function <<EMPTY_NAME>>() As String
			Dim num As Integer
			Dim result As String
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = Me.O.O00O0oOo_.().Rows.Fixed
				IL_1B:
				num2 = 3
				Dim text As String = ""
				IL_24:
				num2 = 4
				Dim flag As Boolean = Oo00.O____0O._0.(Me.OO.____oo.)
				While True
					IL_61B:
					num2 = 6
					If num3 > Me.O.O00O0oOo_.().Rows.Count - 1 Then
						GoTo IL_636
					End If
					IL_38:
					num2 = 7
					Dim fixed As Integer = Me.O.O00O0oOo_.().Cols.Fixed
					Dim num4 As Integer = Me.O.O00O0oOo_.().Cols.Count - 2
					For i As Integer = fixed To num4
						IL_62:
						num2 = 8
						If Me.O.O00O0oOo_.()(num3, i) Is Nothing Then
							IL_75:
							num2 = 9
							num3 += 1
							GoTo IL_61B
						End If
						IL_83:
						num2 = 11
					Next
					IL_92:
					num2 = 12
					If num3 > Me.O.O00O0oOo_.().Rows.Fixed Then
						IL_A9:
						num2 = 13
						text = text + " " + Me.O.O00O0oOo_.()(num3, 0).ToString() + " "
					End If
					IL_D2:
					num2 = 14
					Dim text2 As String = Me.O.O00O0oOo_.()(num3, 1).ToString()
					IL_EA:
					num2 = 15
					Dim str As String
					If flag Then
						IL_F1:
						num2 = 16
						str = Oo00.OoOo_oo_.o_o.(text2, Me.OO.____oo.)
					Else
						IL_105:
						num2 = 18
						str = "[" + text2 + "]"
					End If
					IL_11B:
					num2 = 19
					text += str
					IL_129:
					num2 = 20
					If Operators.CompareString(Me.O.O00O0oOo_.().GetDataDisplay(num3, 3), "", True) = 0 Then
						IL_147:
						num2 = 21
						If Operators.CompareString(Me.O.O00O0oOo_.()(num3, 2).ToString(), "等于", True) = 0 Then
							IL_16A:
							num2 = 22
							text += " Is Null"
						Else
							IL_180:
							num2 = 24
							If Operators.CompareString(Me.O.O00O0oOo_.()(num3, 2).ToString(), "不等于", True) = 0 Then
								IL_1A6:
								num2 = 25
								text += " Is Not Null"
							End If
						End If
					Else
						IL_1BC:
						num2 = 27
						If Me.O.O00O0oOo_.()(num3, 2).ToString().EndsWith("类似") Then
							IL_1E1:
							num2 = 28
							Dim text3 As String = Me.O.O00O0oOo_.()(num3, 3).ToString()
							IL_1F9:
							num2 = 29
							If Operators.CompareString(text3, "", True) > 0 Then
								IL_20C:
								num2 = 30
								Dim text4 As String = OoOo0O.OO_o.0o_O.(5)
								IL_217:
								num2 = 31
								text3 = text3.Replace("[*]", text4)
								IL_22A:
								num2 = 32
								text3 = text3.Replace("*", "%")
								IL_240:
								num2 = 33
								text3 = text3.Replace(text4, "[*]")
							End If
							IL_253:
							num2 = 34
							If Operators.CompareString(Me.O.O00O0oOo_.()(num3, 2).ToString(), "类似", True) = 0 Then
								IL_276:
								num2 = 35
								text = text + " Like '" + text3 + "'"
							Else
								IL_293:
								num2 = 37
								text = text + " Not Like '" + text3 + "'"
							End If
						Else
							IL_2B0:
							num2 = 39
							If Operators.CompareString(Me.O.O00O0oOo_.()(num3, 2).ToString(), "包含", True) = 0 Then
								IL_2D3:
								num2 = 40
								text = text + " Like '%" + Me.O.O00O0oOo_.()(num3, 3).ToString() + "%'"
							Else
								IL_301:
								num2 = 42
								If Operators.CompareString(Me.O.O00O0oOo_.()(num3, 2).ToString(), "不包含", True) = 0 Then
									IL_324:
									num2 = 43
									text = text + " Not Like '%" + Me.O.O00O0oOo_.()(num3, 3).ToString() + "%'"
								Else
									IL_352:
									num2 = 45
									Dim left As String = Me.O.O00O0oOo_.()(num3, 2).ToString()
									IL_36A:
									num2 = 47
									If Operators.CompareString(left, "等于", True) = 0 Then
										IL_37C:
										num2 = 48
										text += " = "
									Else
										IL_392:
										num2 = 50
										If Operators.CompareString(left, "不等于", True) = 0 Then
											IL_3A4:
											num2 = 51
											text += " <> "
										Else
											IL_3BA:
											num2 = 53
											If Operators.CompareString(left, "大于", True) = 0 Then
												IL_3CC:
												num2 = 54
												text += " > "
											Else
												IL_3DF:
												num2 = 56
												If Operators.CompareString(left, "不大于", True) = 0 Then
													IL_3F1:
													num2 = 57
													text += " <= "
												Else
													IL_404:
													num2 = 59
													If Operators.CompareString(left, "小于", True) = 0 Then
														IL_416:
														num2 = 60
														text += " < "
													Else
														IL_429:
														num2 = 62
														If Operators.CompareString(left, "不小于", True) = 0 Then
															IL_43B:
															num2 = 63
															text += " >= "
														End If
													End If
												End If
											End If
										End If
									End If
									IL_44C:
									num2 = 64
									Dim dataCol As DataCol = OO_00oOO.DataTables(Me.OO.____oo..View.o_o.O0ooOo.().TableName).DataCols(text2)
									IL_47C:
									num2 = 65
									If dataCol.IsString Then
										IL_488:
										num2 = 66
										text = text + "'" + Me.O.O00O0oOo_.()(num3, 3).ToString() + "'"
									Else
										IL_4B6:
										num2 = 68
										If dataCol.IsNumeric OrElse dataCol.IsBoolean Then
											IL_4CB:
											num2 = 69
											text += Me.O.O00O0oOo_.()(num3, 3).ToString()
										Else
											IL_4EF:
											num2 = 71
											If dataCol.IsDate Then
												IL_4FE:
												num2 = 72
												Dim dateTime As DateTime
												If Not DateTime.TryParse(Me.O.O00O0oOo_.()(num3, 3).ToString(), dateTime) Then
													Exit For
												End If
												IL_541:
												num2 = 75
												Dim str2 As String = Strings.Format(dateTime, "MM/dd/yyyy HH:mm:ss")
												IL_557:
												num2 = 76
												If flag Then
													IL_561:
													num2 = 77
													If Me.OO.____oo..DataTable.SourceType = 1 Then
														IL_577:
														num2 = 78
														str2 = "#" + str2 + "#"
													Else
														IL_58F:
														num2 = 80
														If Me.OO.____oo..DataTable.SourceType = 2 Then
															IL_5A5:
															num2 = 81
															str2 = "'" + str2 + "'"
														Else
															IL_5BD:
															num2 = 83
															If Me.OO.____oo..DataTable.SourceType = 3 Then
																IL_5D3:
																num2 = 84
																str2 = "TO_DATE('" + str2 + "', 'MM/DD/YYYY HH24:MI:SS')"
															End If
														End If
													End If
												Else
													IL_5EB:
													num2 = 86
													str2 = "#" + str2 + "#"
												End If
												IL_601:
												num2 = 87
												text += str2
											End If
										End If
									End If
									IL_60F:
									dataCol = Nothing
								End If
							End If
						End If
					End If
					IL_612:
					num2 = 89
					num3 += 1
				End While
				IL_51D:
				num2 = 73
				MessageBox.Show("无效日期值!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_533:
				num2 = 74
				result = ""
				GoTo IL_63C
				IL_636:
				num2 = 91
				result = text
				IL_63C:
				GoTo IL_7FE
				IL_641:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_7BF:
				GoTo IL_7F3
				IL_7C1:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7D1:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7C1
			End Try
			IL_7F3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7FE:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003354 RID: 13140 RVA: 0x00150CDC File Offset: 0x0014EEDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.O00O0oOo_.().Rows.Count = Me.O.O00O0oOo_.().Rows.Fixed + 1
		End Sub

		' Token: 0x06003355 RID: 13141 RVA: 0x00150D00 File Offset: 0x0014EF00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1FlexGrid As C1FlexGrid = Me.O.O00O0oOo_.()
				IL_10:
				num2 = 3
				If c1FlexGrid.Col <> 3 OrElse c1FlexGrid.Row < c1FlexGrid.Rows.Fixed Then
					GoTo IL_35F
				End If
				IL_34:
				num2 = 4
				Dim text As String = ""
				IL_3D:
				num2 = 5
				If c1FlexGrid.GetData(c1FlexGrid.Row, 1) Is Nothing Then
					GoTo IL_64
				End If
				IL_4E:
				num2 = 6
				text = c1FlexGrid.GetData(c1FlexGrid.Row, 1).ToString()
				IL_64:
				num2 = 7
				If Operators.CompareString(text, "", True) = 0 OrElse Not Me.OO.____oo..Cols.Contains(text) Then
					GoTo IL_35F
				End If
				IL_8F:
				num2 = 9
				Dim cellStyle As CellStyle = c1FlexGrid.GetCellRange(c1FlexGrid.Row, 3).StyleNew
				IL_AA:
				num2 = 10
				Dim col As Col = Me.OO.____oo..Cols(text)
				IL_C1:
				num2 = 11
				Dim dataColumn As DataColumn = Me.OO.____oo..DataTable.BaseTable.Columns(text)
				IL_E2:
				num2 = 12
				cellStyle.ComboList = ""
				IL_F1:
				num2 = 13
				cellStyle.EditMask = Me.OO.____oo..foxGrid.Cols(text).EditMask
				IL_117:
				num2 = 14
				cellStyle.Format = Me.OO.____oo..foxGrid.Cols(text).Format
				IL_13D:
				num2 = 15
				If Operators.CompareString(col.ComboList, "", True) <= 0 Then
					GoTo IL_197
				End If
				IL_155:
				num2 = 16
				If Not col.AllowDirectType Then
					GoTo IL_181
				End If
				IL_161:
				num2 = 17
				cellStyle.ComboList = "|" + col.ComboList
				GoTo IL_35C
				IL_181:
				num2 = 19
				cellStyle.ComboList = col.ComboList
				GoTo IL_35C
				IL_197:
				num2 = 21
				If dataColumn.DataType IsNot GetType(String) OrElse dataColumn.MaxLength <= 0 OrElse dataColumn.MaxLength >= 64 Then
					GoTo IL_35C
				End If
				IL_1CB:
				num2 = 22
				Dim flag As Boolean = Oo00.O____0O._0.(Me.OO.____oo.)
				IL_1DB:
				num2 = 23
				If Not flag Then
					GoTo IL_32C
				End If
				IL_1E5:
				num2 = 24
				Dim str As String = Oo00.oo_0__0.o.(Me.OO.____oo..DataTable._Adapter.SelectCommand.CommandText)
				IL_209:
				num2 = 25
				text = Oo00.OoOo_oo_.o_o.(text, Me.OO.____oo.)
				IL_21B:
				num2 = 26
				Dim text2 As String = "Select distinct top 100 " + text + " from " + str
				IL_233:
				num2 = 27
				If Operators.CompareString(Me.OO.____oo..DataTable.OOOOO._., "", True) <= 0 Then
					GoTo IL_275
				End If
				IL_254:
				num2 = 28
				text2 = text2 + " where " + Me.OO.____oo..DataTable.OOOOO._.
				IL_275:
				num2 = 29
				Dim dataTable As DataTable = New DataTable()
				IL_27F:
				num2 = 30
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text2, Me.OO.____oo..DataTable.frd_Connection)
				IL_29B:
				num2 = 31
				oleDbDataAdapter.Fill(dataTable)
				IL_2A8:
				num2 = 32
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_2B2:
				num2 = 33
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_2D3:
					num2 = 34
					stringBuilder.Append("|" + dataRow(0).ToString())
					IL_2F5:
					num2 = 35
				End While
				IL_301:
				num2 = 36
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_319:
				num2 = 37
				cellStyle.ComboList = stringBuilder.ToString()
				GoTo IL_35C
				IL_32C:
				num2 = 39
				cellStyle.ComboList = "|" + Me.OO.____oo..DataTable.GetComboListString(text, "", "")
				IL_35C:
				cellStyle = Nothing
				IL_35F:
				GoTo IL_455
				IL_364:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_416:
				GoTo IL_44A
				IL_418:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_428:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_418
			End Try
			IL_44A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_455:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003356 RID: 13142 RVA: 0x00151188 File Offset: 0x0014F388
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			If A_1.Col = 3 AndAlso Me.O.O00O0oOo_.().Editor IsNot Nothing Then
				Dim text As String = Me.O.O00O0oOo_.().Editor.Text
				text = text.Trim(New Char() { vbLf, vbCr })
				Me.O.O00O0oOo_.().Editor.Text = text
			End If
		End Sub

		' Token: 0x06003357 RID: 13143 RVA: 0x001511E4 File Offset: 0x0014F3E4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3000\u3000\u3002\u3002\u3002\u3002o(Me.OO.____oo., 7).ShowDialog()
		End Sub

		' Token: 0x06003358 RID: 13144 RVA: 0x001511F8 File Offset: 0x0014F3F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = Me.o00o_.0.()
			If Operators.CompareString(text, "", True) > 0 Then
				New O\u3002_\u3002\u3000\u3002(Me.OO.____oo., text, 7).ShowDialog()
			End If
		End Sub

		' Token: 0x06003359 RID: 13145 RVA: 0x0015122E File Offset: 0x0014F42E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Oo00.O____0O._0.(Me.OO.____oo.) Then
				Me.OO.____oo..DataTable.o0o_ooOOo0.OO.()
				Return
			End If
			Me.OO.____oo..Filter = ""
			Me.OO.____oo..Grid.Refresh()
		End Sub

		' Token: 0x0600335A RID: 13146 RVA: 0x00151270 File Offset: 0x0014F470
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If Me.OO.____oo..Position >= 0 Then
				Dim text As String = CType(Me.OO.____oo..Current, DataRowView)("Property").ToString()
				If Operators.CompareString(text, "", True) > 0 Then
					Me.O.O00O0oOo_.(text)
				End If
			End If
		End Sub

		' Token: 0x0600335B RID: 13147 RVA: 0x001512C1 File Offset: 0x0014F4C1
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014B6 RID: 5302
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014B7 RID: 5303
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040014B8 RID: 5304
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014B9 RID: 5305
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014BA RID: 5306
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014BB RID: 5307
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014BC RID: 5308
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014BD RID: 5309
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x040014BE RID: 5310
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014BF RID: 5311
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x040014C0 RID: 5312
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x040014C1 RID: 5313
		Private <<EMPTY_NAME>> As CurrencyManager

		' Token: 0x040014C2 RID: 5314
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
