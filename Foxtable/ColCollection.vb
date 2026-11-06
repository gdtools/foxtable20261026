Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000305 RID: 773
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0561")>
	Public Class ColCollection
		Implements IEnumerable(Of Col)

		' Token: 0x060028AB RID: 10411 RVA: 0x001113A7 File Offset: 0x0010F5A7
		Friend Sub New(A_0 As Table)
			Me._Columns = New Dictionary(Of String, Col)()
			Me.Table = A_0
		End Sub

		' Token: 0x060028AC RID: 10412 RVA: 0x001113C1 File Offset: 0x0010F5C1
		Friend Sub Reset()
			Me._Columns.Clear()
		End Sub

		' Token: 0x17000982 RID: 2434
		' (get) Token: 0x060028AD RID: 10413 RVA: 0x001113D0 File Offset: 0x0010F5D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(ColumnName As String) As Col
			Get
				Dim result As Col
				If Me._Columns.ContainsKey(ColumnName) Then
					result = Me._Columns(ColumnName)
				ElseIf Me.Table.foxGrid.Cols.Contains(ColumnName) Then
					ColumnName = Me.Table.foxGrid.Cols(ColumnName).Name
					If Me._Columns.ContainsKey(ColumnName) Then
						result = Me._Columns(ColumnName)
					Else
						Dim col As Col = New Col(Me.Table, ColumnName)
						Me._Columns.Add(ColumnName, col)
						result = col
					End If
				Else
					MessageBox.Show(Me.Table.DataTable.Name + "不存在名为 """ + ColumnName + """的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x060028AE RID: 10414 RVA: 0x001114A0 File Offset: 0x0010F6A0
		Friend Sub RenameColumn(OldName As String, NewName As String)
			If Me._Columns.ContainsKey(OldName) Then
				If Me._Columns.ContainsKey(NewName) Then
					Me._Columns.Remove(NewName)
				End If
				Dim col As Col = Me._Columns(OldName)
				Me._Columns.Remove(OldName)
				col.o_.ooOO0O.(NewName)
				Me._Columns.Add(NewName, col)
			End If
		End Sub

		' Token: 0x060028AF RID: 10415 RVA: 0x00111504 File Offset: 0x0010F704
		Public Function Contains(ColumnName As String) As Boolean
			Dim result As Boolean
			Try
				result = Me.Table.foxGrid.Cols.Contains(ColumnName)
			Catch ex As Exception
			End Try
			Return result
		End Function

		' Token: 0x17000983 RID: 2435
		' (get) Token: 0x060028B0 RID: 10416 RVA: 0x0011154C File Offset: 0x0010F74C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(Index As Integer) As Col
			Get
				Return Me.get_Item(Me.Table.foxGrid.Cols(Index + Me.Table.foxGrid.Cols.Fixed).Name)
			End Get
		End Property

		' Token: 0x17000984 RID: 2436
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Col
			Get
				Dim result As Col
				If TypeOf A_0 Is String Then
					result = Me.get_Item(A_0.ToString())
				Else
					Dim index As Integer = -1
					If Integer.TryParse(A_0.ToString(), index) Then
						result = Me.get_Item(index)
					Else
						result = Me.get_Item(A_0.ToString())
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000985 RID: 2437
		' (get) Token: 0x060028B2 RID: 10418 RVA: 0x001115D5 File Offset: 0x0010F7D5
		Public ReadOnly Property Count As Integer
			Get
				Return Me.Table.foxGrid.Cols.Count - Me.Table.foxGrid.Cols.Fixed
			End Get
		End Property

		' Token: 0x060028B3 RID: 10419 RVA: 0x00111602 File Offset: 0x0010F802
		Public Sub Remove(ColumnName As String)
			If Me.Table.foxGrid.Cols.Contains(ColumnName) Then
				Me.Table.foxGrid.Cols.Remove(ColumnName)
			End If
			Me._Columns.Remove(ColumnName)
		End Sub

		' Token: 0x060028B4 RID: 10420 RVA: 0x00111640 File Offset: 0x0010F840
		Public Sub Remove(ParamArray ColumnNames As String())
			Me.Table.foxGrid.BeginUpdate()
			For Each text As String In ColumnNames
				Me.Table.foxGrid.Cols.Remove(text)
				Me._Columns.Remove(text)
			Next
			Me.Table.foxGrid.EndUpdate()
		End Sub

		' Token: 0x060028B5 RID: 10421 RVA: 0x001116A5 File Offset: 0x0010F8A5
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Col) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Col).GetEnumerator
			Return New OOOooo_o(Me.Table)
		End Function

		' Token: 0x060028B6 RID: 10422 RVA: 0x001116B2 File Offset: 0x0010F8B2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New OOOooo_o(Me.Table)
		End Function

		' Token: 0x17000986 RID: 2438
		' (get) Token: 0x060028B7 RID: 10423 RVA: 0x001116BF File Offset: 0x0010F8BF
		' (set) Token: 0x060028B8 RID: 10424 RVA: 0x001116D6 File Offset: 0x0010F8D6
		Public Property Frozen As Integer
			Get
				Return Me.Table.foxGrid.Cols.Frozen
			End Get
			Set(value As Integer)
				Me.Table.foxGrid.Cols.Frozen = value
			End Set
		End Property

		' Token: 0x040010C5 RID: 4293
		Private _Columns As Dictionary(Of String, Col)

		' Token: 0x040010C6 RID: 4294
		Private Table As Table
	End Class
End Namespace
