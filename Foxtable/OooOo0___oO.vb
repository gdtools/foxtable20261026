Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000234 RID: 564
	Friend Class OooOo0___oO
		Inherits C1FlexGrid

		' Token: 0x06001A41 RID: 6721 RVA: 0x000A80B1 File Offset: 0x000A62B1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As DataTable
			Return Me.OO_.O_O0O.
		End Function

		' Token: 0x06001A42 RID: 6722 RVA: 0x000A80BC File Offset: 0x000A62BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Dim value As DataColumnChangeEventHandler = AddressOf Me.O_._0o00_.
			Dim value2 As DataRowChangeEventHandler = AddressOf Me.O_._0o00_.
			Dim oo_.O_O0O. As DataTable = Me.OO_.O_O0O.
			If oo_.O_O0O. IsNot Nothing Then
				RemoveHandler oo_.O_O0O..ColumnChanged, value
				RemoveHandler oo_.O_O0O..RowChanged, value2
			End If
			Me.OO_.O_O0O. = A_0
			oo_.O_O0O. = Me.OO_.O_O0O.
			If oo_.O_O0O. IsNot Nothing Then
				AddHandler oo_.O_O0O..ColumnChanged, value
				AddHandler oo_.O_O0O..RowChanged, value2
			End If
		End Sub

		' Token: 0x06001A43 RID: 6723 RVA: 0x000A811A File Offset: 0x000A631A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As O_0
			Return Me.OO_.O_O0O.
		End Function

		' Token: 0x06001A44 RID: 6724 RVA: 0x000A8124 File Offset: 0x000A6324
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As O_0)
			Dim value As EventHandler = AddressOf Me.O_0._o0_.
			Dim oo_.O_O0O. As O_0 = Me.OO_.O_O0O.
			If oo_.O_O0O. IsNot Nothing Then
				RemoveHandler oo_.O_O0O..CurrentChanged, value
			End If
			Me.OO_.O_O0O. = A_0
			oo_.O_O0O. = Me.OO_.O_O0O.
			If oo_.O_O0O. IsNot Nothing Then
				AddHandler oo_.O_O0O..CurrentChanged, value
			End If
		End Sub

		' Token: 0x06001A45 RID: 6725 RVA: 0x000A8168 File Offset: 0x000A6368
		Public Sub New()
			MyBase.AfterEdit += AddressOf Me.o__00__0._OO00.
			MyBase.BeforeEdit += AddressOf Me.oo_0OoO._.
			MyBase.CellButtonClick += AddressOf Me.o_0O.OO__0.
			MyBase.ChangeEdit += AddressOf Me.OOo_._0.
			AddHandler MyBase.KeyDown, AddressOf Me.OOo_._0.
			MyBase.KeyDownEdit += AddressOf Me.O_0o.0OOo.
			MyBase.KeyPressEdit += AddressOf Me.OOo_._0.
			MyBase.KeyUpEdit += AddressOf Me.OOo_._0.
			MyBase.OwnerDrawCell += AddressOf Me.OOo_._0.
			MyBase.SetupEditor += AddressOf Me.O_0o.0OOo.
			MyBase.StartEdit += AddressOf Me.OOo_._0.
			MyBase.ValidateEdit += AddressOf Me.OO_.O_O0O.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.OOo_._0.
			Me.OO_.O_O0O. = New List(Of String)()
		End Sub

		' Token: 0x06001A46 RID: 6726 RVA: 0x000A8270 File Offset: 0x000A6470
		Public Sub New(A_0 As Table, A_1 As String, A_2 As Boolean, Optional A_3 As Boolean = False)
			MyBase.AfterEdit += AddressOf Me.o__00__0._OO00.
			MyBase.BeforeEdit += AddressOf Me.oo_0OoO._.
			MyBase.CellButtonClick += AddressOf Me.o_0O.OO__0.
			MyBase.ChangeEdit += AddressOf Me.OOo_._0.
			AddHandler MyBase.KeyDown, AddressOf Me.OOo_._0.
			MyBase.KeyDownEdit += AddressOf Me.O_0o.0OOo.
			MyBase.KeyPressEdit += AddressOf Me.OOo_._0.
			MyBase.KeyUpEdit += AddressOf Me.OOo_._0.
			MyBase.OwnerDrawCell += AddressOf Me.OOo_._0.
			MyBase.SetupEditor += AddressOf Me.O_0o.0OOo.
			MyBase.StartEdit += AddressOf Me.OOo_._0.
			MyBase.ValidateEdit += AddressOf Me.OO_.O_O0O.
			AddHandler MyBase.PreviewKeyDown, AddressOf Me.OOo_._0.
			Me.OO_.O_O0O. = New List(Of String)()
			Me.O.OOoo_o0. = A_0
			If Operators.CompareString(A_1, "", True) > 0 Then
				Me.OO_.O_O0O..AddRange(A_1.Split(New Char() { ","c }))
			End If
			Me.O.OOoo_o0. = A_2
			Me.oOo.__00o. = A_3
			Me.Ooo_oO._0O.()
		End Sub

		' Token: 0x06001A47 RID: 6727 RVA: 0x000A83C0 File Offset: 0x000A65C0
		Friend Sub <<EMPTY_NAME>>()
			If Me.O.OOoo_o0. Is Nothing Then
				MyBase.VisualStyle = 0
				Main.OO_O.o..o.O000oo.(New Object() { Me })
				MyBase.Enabled = False
				Me.OO_.O_O0O.(Nothing)
				Me.OO_.O_O0O.(Nothing)
				Return
			End If
			MyBase.Enabled = True
			Me.OO_.O_O0O.(Me.O.OOoo_o0..View)
			Me.OO_.O_O0O.(Me.O.OOoo_o0..DataTable.BaseTable)
			MyBase.VisualStyle = 0
			Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(Me.O.OOoo_o0..Grid), New Object() { Me })
			If Me.oOo.__00o. Then
				Me.Font = Me.O.OOoo_o0..Grid.Font
			End If
			MyBase.Styles.Alternate.Clear()
			If Me.oOo.__00o. Then
				Me.Font = Me.O.OOoo_o0..Grid.Font
			End If
			MyBase.Cols.Count = 2
			MyBase.Cols.Fixed = 1
			MyBase.Rows.Fixed = 0
			MyBase.Rows.Count = 0
			MyBase.ExtendLastCol = True
			Dim list As List(Of String) = New List(Of String)()
			If Me.OO_.O_O0O..Count > 0 Then
				list.AddRange(Me.OO_.O_O0O.)
			Else
				Try
					For Each col As Col In Me.O.OOoo_o0..Cols
						list.Add(col.Name)
					Next
				Finally
					Dim enumerator As IEnumerator(Of Col)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			Try
				For Each a_ As String In list
					Dim col2 As Col = Me.O.OOoo_o0..Cols(a_)
					If Me.OO_.O_O0O..Count = 0 OrElse (Me.OO_.O_O0O..Contains(col2.Name) AndAlso Me.O.OOoo_o0.) OrElse (Not Me.OO_.O_O0O..Contains(col2.Name) AndAlso Not Me.O.OOoo_o0.) Then
						MyBase.AddItem(col2.ShortCaption)
						MyBase.Rows(MyBase.Rows.Count - 1).UserData = col2.Name
						If Me.OO_.O_O0O..Count = 0 Then
							MyBase.Rows(MyBase.Rows.Count - 1).Visible = col2.ShowInRecordGrid
						End If
						MyBase.Rows(MyBase.Rows.Count - 1).Height = MyBase.Rows.DefaultSize * col2.RecordRowHeight
						Dim styleNew As CellStyle = MyBase.GetCellRange(MyBase.Rows.Count - 1, 1).StyleNew
						styleNew.DataType = Me.O.OOoo_o0..DataTable.BaseTable.Columns(col2.Name).DataType
						Dim column As Column = Me.O.OOoo_o0..foxGrid.Cols(col2.Name)
						styleNew.DataMap = column.DataMap
						styleNew.EditMask = column.EditMask
						styleNew.Editor = column.Editor
						styleNew.Format = column.Format
						styleNew.ImageMap = column.ImageMap
						If styleNew.DataType Is GetType(String) Then
							styleNew.WordWrap = True
						End If
						MyBase.Rows(MyBase.Rows.Count - 1).ImageAndText = column.ImageAndText
					End If
				Next
			Finally
				Dim enumerator2 As List(Of String).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			MyBase.SelectionMode = 1
			MyBase.FocusRect = 3
			MyBase.AllowResizing = 6
			MyBase.Cols(1).TextAlign = 1
			MyBase.AutoClipboard = True
			Me.AutoSizeCol(0, 10)
			MyBase.KeyActionEnter = 1
			MyBase.KeyActionTab = 1
			Me.CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap()
			MyBase.DrawMode = 1
			MyBase.Cols(0).Style = MyBase.Styles.Fixed
			Me.Oo0o__.OO0o__O.()
		End Sub

		' Token: 0x06001A48 RID: 6728 RVA: 0x000A880C File Offset: 0x000A6A0C
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer = MyBase.Rows.Count - 1
			For i As Integer = 0 To num
				Dim a_ As String = MyBase.Rows(i).UserData.ToString()
				MyBase.Rows(i).Visible = Me.O.OOoo_o0..Cols(a_).ShowInRecordGrid
				MyBase.Rows(1).Height = MyBase.Rows.DefaultSize * Me.O.OOoo_o0..Cols(a_).RecordRowHeight
				MyBase(i, 0) = Me.O.OOoo_o0..Cols(a_).ShortCaption
			Next
		End Sub

		' Token: 0x06001A49 RID: 6729 RVA: 0x000A88C8 File Offset: 0x000A6AC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Me.O.OOoo_o0..Current(MyBase.Rows(A_1.Row).UserData.ToString()) = RuntimeHelpers.GetObjectValue(Me.GetData(A_1.Row, A_1.Col))
				Me.O.OOoo_o0..foxGrid.O.O0_0.(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, New RecordGrid(Me))
			End If
		End Sub

		' Token: 0x06001A4A RID: 6730 RVA: 0x000A8980 File Offset: 0x000A6B80
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing AndAlso A_1.Col > 0 Then
				If Me.O.OOoo_o0..Current Is Nothing OrElse Me.O.OOoo_o0..Position < 0 OrElse Operators.CompareString(Me.O.OOoo_o0..Cols(MyBase.Rows(A_1.Row).UserData.ToString()).DataCol.BaseColumn.Expression, "", True) > 0 Then
					A_1.Cancel = True
					Return
				End If
				Dim cellRange As CellRange = MyBase.GetCellRange(A_1.Row, A_1.Col)
				Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index)
				Me.O.OOoo_o0..foxGrid.O.O0_0.(Me, rowColEventArgs, New RecordGrid(Me))
				A_1.Cancel = rowColEventArgs.Cancel
				Me.O.OOoo_o0..foxGrid.o_O.Oo. = Not A_1.Cancel
				Dim column As Column = Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString())
				cellRange.StyleNew.Editor = column.Editor
				cellRange.StyleNew.ComboList = column.ComboList
				cellRange.StyleNew.DataMap = column.DataMap
				cellRange.StyleNew.ImageMap = column.ImageMap
			End If
		End Sub

		' Token: 0x06001A4B RID: 6731 RVA: 0x000A8B25 File Offset: 0x000A6D25
		Friend Sub <<EMPTY_NAME>>()
			Me.OO_.O_O0O.(Nothing)
			Me.OO_.O_O0O.(Nothing)
		End Sub

		' Token: 0x06001A4C RID: 6732 RVA: 0x000A8B35 File Offset: 0x000A6D35
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Oo0o__.OO0o__O.()
		End Sub

		' Token: 0x06001A4D RID: 6733 RVA: 0x000A8B40 File Offset: 0x000A6D40
		Friend Sub <<EMPTY_NAME>>()
			Dim dataRowView As DataRowView = Me.O.OOoo_o0..View.o_o.O0ooOo.()
			If dataRowView Is Nothing Then
				Dim num As Integer = MyBase.Rows.Count - 1
				For i As Integer = 0 To num
					Me.SetData(i, 1, Nothing, False)
				Next
			Else
				Dim num2 As Integer = MyBase.Rows.Count - 1
				For j As Integer = 0 To num2
					Me.SetData(j, 1, RuntimeHelpers.GetObjectValue(dataRowView(MyBase.Rows(j).UserData.ToString())), False)
				Next
			End If
			MyBase.Invalidate()
		End Sub

		' Token: 0x06001A4E RID: 6734 RVA: 0x000A8BDC File Offset: 0x000A6DDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataColumnChangeEventArgs)
			If Me.O.OOoo_o0..Current IsNot Nothing AndAlso A_1.Row Is Me.O.OOoo_o0..Current.DataRow.BaseRow Then
				Dim num As Integer = MyBase.Rows.Count - 1
				For i As Integer = 0 To num
					Dim text As String = MyBase.Rows(i).UserData.ToString()
					If Operators.CompareString(text, A_1.Column.ColumnName, True) = 0 Then
						If A_1.ProposedValue Is DBNull.Value Then
							Me.SetData(i, 1, Nothing)
						Else
							Me.SetData(i, 1, RuntimeHelpers.GetObjectValue(A_1.ProposedValue))
						End If
					ElseIf Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(Me.oO000o.oO_oO.().Columns(text).Expression, "", True) > 0 Then
						Me.SetData(i, 1, RuntimeHelpers.GetObjectValue(A_1.Row(text)))
					End If
				Next
			End If
		End Sub

		' Token: 0x06001A4F RID: 6735 RVA: 0x000A8CE0 File Offset: 0x000A6EE0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Me.O.OOoo_o0..Cols(MyBase.Rows(A_1.Row).UserData.ToString())
				Me.O.OOoo_o0..foxGrid.o_.OO.(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, New RecordGrid(Me))
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06001A50 RID: 6736 RVA: 0x000A8D88 File Offset: 0x000A6F88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim col As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(MyBase.Row).UserData.ToString())
			Dim dataCol As DataCol = Me.O.OOoo_o0..DataTable.DataCols(col.Name)
			Dim dataRow As DataRow = Me.O.OOoo_o0..Current.DataRow
			If MyBase(MyBase.Row, MyBase.Col) IsNot Nothing AndAlso MyBase(MyBase.Row, MyBase.Col) IsNot DBNull.Value Then
				Dim a_ As String = MyBase(MyBase.Row, MyBase.Col).ToString()
				Oo00.o00O0O_.O.(dataRow, dataCol, dataCol.FTPClient, a_, dataCol.AutoUpdate)
			End If
		End Sub

		' Token: 0x06001A51 RID: 6737 RVA: 0x000A8E4C File Offset: 0x000A704C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim col As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(MyBase.Row).UserData.ToString())
			Dim dataCol As DataCol = Me.O.OOoo_o0..DataTable.DataCols(col.Name)
			Dim dataRow As DataRow = Me.O.OOoo_o0..Current.DataRow
			If MyBase(MyBase.Row, MyBase.Col) IsNot Nothing AndAlso MyBase(MyBase.Row, MyBase.Col) IsNot DBNull.Value Then
				Dim text As String = MyBase(MyBase.Row, MyBase.Col).ToString()
				If Not text.StartsWith("[") OrElse Not text.EndsWith("]") Then
					Oo00.o0_o._O_.(dataRow, dataCol, dataCol.FTPClient, text, dataCol.AutoUpdate)
				End If
			End If
		End Sub

		' Token: 0x06001A52 RID: 6738 RVA: 0x000A8F28 File Offset: 0x000A7128
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim col As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(MyBase.Row).UserData.ToString())
			Dim dataCol As DataCol = Me.O.OOoo_o0..DataTable.DataCols(col.Name)
			Dim dataRow As DataRow = Me.O.OOoo_o0..Current.DataRow
			Dim list As List(Of String) = New List(Of String)()
			list = Oo00.O____0O._0.(dataRow, dataCol, dataCol.FTPClient, "")
			If list IsNot Nothing AndAlso list.Count > 0 Then
				Dim text As String = list(0)
				Dim maxLength As Integer = dataCol.MaxLength
				If maxLength < text.Length AndAlso maxLength > 0 Then
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.O.OOoo_o0., Me.O.OOoo_o0..View.o_o.O0ooOo.().Row, dataCol.Name))
				MyBase(MyBase.Row, MyBase.Col) = text
				Me.o__00__0._OO00.(Me, New RowColEventArgs(MyBase.Row, MyBase.Col))
			End If
		End Sub

		' Token: 0x06001A53 RID: 6739 RVA: 0x000A904C File Offset: 0x000A724C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim col As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(MyBase.Row).UserData.ToString())
			Dim dataCol As DataCol = Me.O.OOoo_o0..DataTable.DataCols(col.Name)
			Dim text As String = Oo00.O____0O._0.(Me.O.OOoo_o0..Current.DataRow, dataCol, dataCol.FTPClient, "")
			If Operators.CompareString(text, "", True) > 0 Then
				Dim maxLength As Integer = dataCol.MaxLength
				If maxLength < text.Length AndAlso maxLength > 0 Then
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行""更改列""命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.O.OOoo_o0., Me.O.OOoo_o0..View.o_o.O0ooOo.().Row, dataCol.Name))
				MyBase(MyBase.Row, MyBase.Col) = text
				Me.o__00__0._OO00.(Me, New RowColEventArgs(MyBase.Row, MyBase.Col))
			End If
		End Sub

		' Token: 0x06001A54 RID: 6740 RVA: 0x000A9160 File Offset: 0x000A7360
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim col As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(MyBase.Row).UserData.ToString())
			Me.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.O.OOoo_o0., Me.O.OOoo_o0..Current.DataRow.BaseRow, col.Name))
			Dim dataDisplay As String = Me.GetDataDisplay(MyBase.Row, MyBase.Col)
			If Operators.CompareString(dataDisplay, "", True) > 0 Then
				Dim a_ As DataCol = Me.O.OOoo_o0..DataTable.DataCols(col.Name)
				If Not Oo00.OO.0O0o.(Me.O.OOoo_o0..Current.DataRow, a_, dataDisplay) Then
					Return
				End If
			End If
			MyBase(MyBase.Row, MyBase.Col) = DBNull.Value
			Me.o__00__0._OO00.(Me, New RowColEventArgs(MyBase.Row, MyBase.Col))
		End Sub

		' Token: 0x06001A55 RID: 6741 RVA: 0x000A9258 File Offset: 0x000A7458
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Me.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), MyBase.Rows(MyBase.Row).UserData.ToString(), New RecordGrid(Me))
			End If
		End Sub

		' Token: 0x06001A56 RID: 6742 RVA: 0x000A92A4 File Offset: 0x000A74A4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing AndAlso MyBase.Col = 1 AndAlso MyBase.Row >= 0 AndAlso Me.O.OOoo_o0..Current IsNot Nothing Then
				Dim a_ As DataRow = Me.O.OOoo_o0..Current.BaseDataRow
				Dim a_2 As String = MyBase.Rows(MyBase.Row).UserData.ToString()
				If(A_1.Control AndAlso A_1.KeyCode = Keys.X) OrElse (A_1.Shift AndAlso A_1.KeyCode = Keys.Delete) OrElse A_1.KeyCode = Keys.Delete Then
					Me.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.O.OOoo_o0., a_, a_2))
					Return
				End If
				If(A_1.Control AndAlso A_1.KeyCode = Keys.V) OrElse (A_1.Shift AndAlso A_1.KeyCode = Keys.Insert) Then
					Me.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(Me.O.OOoo_o0., a_, a_2))
				End If
			End If
		End Sub

		' Token: 0x06001A57 RID: 6743 RVA: 0x000A93A0 File Offset: 0x000A75A0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Dim a_ As KeyEditEventArgs = New KeyEditEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, New KeyEventArgs(A_1.KeyData))
				Me.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), a_, MyBase.Rows(A_1.Row).UserData.ToString(), MyBase.Editor, New RecordGrid(Me), False)
				A_1.Handled = A_1.Handled
			End If
		End Sub

		' Token: 0x06001A58 RID: 6744 RVA: 0x000A945C File Offset: 0x000A765C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEditEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Dim keyPressEditEventArgs As KeyPressEditEventArgs = New KeyPressEditEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, A_1.KeyChar)
				Me.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), keyPressEditEventArgs, MyBase.Editor, New RecordGrid(Me))
				A_1.Handled = keyPressEditEventArgs.Handled
			End If
		End Sub

		' Token: 0x06001A59 RID: 6745 RVA: 0x000A94F4 File Offset: 0x000A76F4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEditEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Dim a_ As KeyEditEventArgs = New KeyEditEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, New KeyEventArgs(A_1.KeyData))
				Me.O.OOoo_o0..foxGrid.O._o0O0o0o0.(RuntimeHelpers.GetObjectValue(A_0), a_, MyBase.Rows(A_1.Row).UserData.ToString(), MyBase.Editor, New RecordGrid(Me))
				A_1.Handled = A_1.Handled
			End If
		End Sub

		' Token: 0x06001A5A RID: 6746 RVA: 0x000A95AC File Offset: 0x000A77AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing AndAlso A_1.Col = 1 Then
				Dim a_ As String = MyBase.Rows(A_1.Row).UserData.ToString()
				If Me.O.OOoo_o0..Cols(a_).DataCol.ExtendColumnType = 5 Then
					Dim bounds As Rectangle = A_1.Bounds
					If Me.Selection.Contains(A_1.Row, A_1.Col) Then
						bounds = New Rectangle(bounds.X + 1, bounds.Y + 1, bounds.Width - 4, bounds.Height - 4)
						A_1.Graphics.DrawRectangle(Pens.Gray, bounds)
						bounds = New Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 3, bounds.Height - 3)
					Else
						bounds = New Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 5, bounds.Height - 5)
					End If
					If MyBase(A_1.Row, A_1.Col) IsNot Nothing AndAlso MyBase(A_1.Row, A_1.Col) IsNot DBNull.Value Then
						A_1.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(Conversions.ToInteger(MyBase(A_1.Row, A_1.Col)))), bounds)
					End If
					A_1.DrawCell(2)
					A_1.Handled = True
				ElseIf Me.O.OOoo_o0..Cols(a_).DataCol.ExtendColumnType = 8 AndAlso MyBase(A_1.Row, A_1.Col) IsNot Nothing AndAlso MyBase(A_1.Row, A_1.Col) IsNot DBNull.Value Then
					Dim a_2 As Double = Conversions.ToDouble(MyBase(A_1.Row, A_1.Col))
					Dim text As String = ""
					If O_O0OO.o.00O_O.(a_2, text) Then
						A_1.Text = text
					End If
				End If
				If Not A_1.Handled Then
					Dim methodInfo As MethodInfo = Me.O.OOoo_o0..DataTable.OO00.oO_.
					If methodInfo Is Nothing AndAlso Me.O.OOoo_o0..DataTable.GlobalHandler.DrawCell AndAlso O_O0OO.O0_00o.o0__o..oO0o_.__O0. IsNot Nothing Then
						methodInfo = O_O0OO.O0_00o.o0__o..oO0o_.__O0.
					End If
					If methodInfo IsNot Nothing AndAlso Me.O.OOoo_o0..Current IsNot Nothing Then
						Dim a_3 As Col = Me.O.OOoo_o0..Cols(MyBase.Rows(A_1.Row).UserData.ToString())
						Dim drawCellEventArgs As DrawCellEventArgs = New DrawCellEventArgs(Me.O.OOoo_o0., Me.O.OOoo_o0..Current, a_3, A_1, Me, False)
						Try
							methodInfo.Invoke(Nothing, New Object() { drawCellEventArgs })
							If Not A_1.Handled AndAlso Operators.CompareString(drawCellEventArgs.Style, "", True) > 0 Then
								Dim text2 As String = "User" + drawCellEventArgs.Style
								If Me.O.OOoo_o0..Grid.Styles.Contains(text2) AndAlso Not MyBase.Styles.Contains(text2) Then
									MyBase.Styles.Add(text2, Me.O.OOoo_o0..Grid.Styles(text2))
								End If
								If MyBase.Styles.Contains(text2) Then
									A_1.Style = MyBase.Styles(text2)
								End If
							End If
						Catch a_4 As Exception
							If methodInfo Is O_O0OO.O0_00o.o0__o..oO0o_.__O0. Then
								O_O0OO.O0_00o.o0__o..oO0o_.__O0. = Nothing
								ooO.oOo0Oo.o.(a_4, "全局表事件,DrawCell")
							Else
								Me.O.OOoo_o0..DataTable.OO00.oO_. = Nothing
								ooO.oOo0Oo.o.(a_4, "表，" + Me.O.OOoo_o0..DataTable.Name + "，DrawCell")
							End If
							MessageBox.Show("DrawCell事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x06001A5B RID: 6747 RVA: 0x000A99A8 File Offset: 0x000A7BA8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Dim a_ As RowColEventArgs = New RowColEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index)
				Me.O.OOoo_o0..foxGrid.OO0o_o_OO.O_O.(Me, a_, New RecordGrid(Me))
			End If
		End Sub

		' Token: 0x06001A5C RID: 6748 RVA: 0x000A9A20 File Offset: 0x000A7C20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				If Me.O.OOoo_o0..foxGrid.O_._. Is Nothing Then
					Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index)
					Me.O.OOoo_o0..foxGrid.OOOo_oO_O.O.(Me, rowColEventArgs, New RecordGrid(Me))
					A_1.Cancel = rowColEventArgs.Cancel
					Return
				End If
				If Me.O.OOoo_o0..foxGrid.O_._. = 2 Then
					A_1.Cancel = True
				End If
				Me.O.OOoo_o0..foxGrid.O_._. = 0
			End If
		End Sub

		' Token: 0x06001A5D RID: 6749 RVA: 0x000A9AE8 File Offset: 0x000A7CE8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			If Me.oO000o.oO_oO.() IsNot Nothing Then
				Dim validateEditEventArgs As ValidateEditEventArgs = New ValidateEditEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(A_1.Row).UserData.ToString()).Index, A_1.Checkbox)
				Me.O.OOoo_o0..foxGrid.O_._.(Me, validateEditEventArgs, New RecordGrid(Me))
				A_1.Cancel = validateEditEventArgs.Cancel
				If Not A_1.Cancel Then
					Me.O.Ooo_o0.()
				End If
			End If
		End Sub

		' Token: 0x06001A5E RID: 6750 RVA: 0x000A9B84 File Offset: 0x000A7D84
		Friend Sub <<EMPTY_NAME>>()
			Dim editor As System.Windows.Forms.Control = MyBase.GetCellRange(MyBase.Row, MyBase.Col).StyleNew.Editor
			If MyBase.Editor IsNot Nothing AndAlso TypeOf MyBase.Editor Is C1DropDownControl AndAlso MyBase.Editor Is MyBase.Editor Then
				CType(MyBase.Editor, C1DropDownControl).OpenDropDown()
			End If
		End Sub

		' Token: 0x06001A5F RID: 6751 RVA: 0x000A9BE4 File Offset: 0x000A7DE4
		Friend Sub <<EMPTY_NAME>>()
			Dim editor As System.Windows.Forms.Control = MyBase.GetCellRange(MyBase.Row, MyBase.Col).StyleNew.Editor
			If MyBase.Editor IsNot Nothing AndAlso TypeOf MyBase.Editor Is C1DropDownControl AndAlso MyBase.Editor Is MyBase.Editor Then
				CType(MyBase.Editor, C1DropDownControl).CloseDropDown()
			End If
		End Sub

		' Token: 0x06001A60 RID: 6752 RVA: 0x000A9C44 File Offset: 0x000A7E44
		Public Function <<EMPTY_NAME>>() As Boolean
			Dim editor As System.Windows.Forms.Control = MyBase.GetCellRange(MyBase.Row, MyBase.Col).StyleNew.Editor
			Dim droppedDown As Boolean
			If MyBase.Editor IsNot Nothing AndAlso TypeOf MyBase.Editor Is C1DropDownControl AndAlso MyBase.Editor Is MyBase.Editor Then
				droppedDown = CType(MyBase.Editor, C1DropDownControl).DroppedDown
			End If
			Return droppedDown
		End Function

		' Token: 0x06001A61 RID: 6753 RVA: 0x000A9CA6 File Offset: 0x000A7EA6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DataRowChangeEventArgs)
			If A_1.Action = DataRowAction.Rollback Then
				Me.Oo0o__.OO0o__O.()
			End If
		End Sub

		' Token: 0x06001A62 RID: 6754 RVA: 0x000A9CB8 File Offset: 0x000A7EB8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PreviewKeyDownEventArgs)
			If((Me.O.OOoo_o0..foxGrid.o_O.Oo. AndAlso OO_00oOO.OSVersion() = 10 AndAlso MyBase.Row >= MyBase.Rows.Fixed) And MyBase.Col >= MyBase.Cols.Fixed) AndAlso MyBase.Editor Is Nothing AndAlso A_1.KeyCode = Keys.ProcessKey AndAlso MyBase.GetCellRange(MyBase.Row, 1).StyleNew.DataType Is GetType(String) Then
				Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(Me.O.OOoo_o0..foxGrid.Row, Me.O.OOoo_o0..foxGrid.Cols(MyBase.Rows(MyBase.Row).UserData.ToString()).Index)
				Me.O.OOoo_o0..foxGrid.OOOo_oO_O.O.(Me, rowColEventArgs, New RecordGrid(Me))
				If rowColEventArgs.Cancel Then
					Me.O.OOoo_o0..foxGrid.O_._. = 2
				Else
					Me.O.OOoo_o0..foxGrid.O_._. = 1
				End If
				If Not rowColEventArgs.Cancel Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.GetData(MyBase.Row, MyBase.Col))
					Dim text As String = ""
					If objectValue IsNot Nothing Then
						text = objectValue.ToString()
					End If
					MyBase.StartEditing()
					Application.DoEvents()
					If Operators.CompareString(MyBase.Editor.Text, text, True) <> 0 Then
						text = MyBase.Editor.Text
						MyBase.Editor.Text = ""
						SendKeys.Send(text)
					End If
				End If
			End If
		End Sub

		' Token: 0x04000B0C RID: 2828
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04000B0D RID: 2829
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000B0E RID: 2830
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000B0F RID: 2831
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O_0

		' Token: 0x04000B10 RID: 2832
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B11 RID: 2833
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
