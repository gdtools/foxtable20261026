Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000300 RID: 768
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("1942")>
	Public Class DataRelationCollection
		Implements IEnumerable(Of Relation)

		' Token: 0x17000950 RID: 2384
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Default Property Item(A_0 As Object) As Relation
			Get
				Dim a_ As Integer = -1
				Dim result As Relation
				If Integer.TryParse(A_0.ToString(), a_) Then
					result = Me.oo._Oo0.(a_)
				Else
					result = Me.oo._Oo0.(A_0.ToString())
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000951 RID: 2385
		' (get) Token: 0x06002832 RID: 10290 RVA: 0x0010D530 File Offset: 0x0010B730
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(A_0 As String) As Relation
			Get
				Dim result As Relation
				If Me.Contains(A_0) Then
					result = New Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations(A_0))
				Else
					MessageBox.Show("关联[" + A_0 + "]不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000952 RID: 2386
		' (get) Token: 0x06002833 RID: 10291 RVA: 0x0010D580 File Offset: 0x0010B780
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Item(A_0 As Integer) As Relation
			Get
				Dim result As Relation
				If O_O0OO.OOOo.oo_OOOO_0.().Relations.Count > A_0 And A_0 >= 0 Then
					result = New Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations(A_0))
				Else
					MessageBox.Show("关联索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x06002834 RID: 10292 RVA: 0x0010D5D7 File Offset: 0x0010B7D7
		Public Function Contains(RelationName As String) As Boolean
			Return O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(RelationName)
		End Function

		' Token: 0x17000953 RID: 2387
		' (get) Token: 0x06002835 RID: 10293 RVA: 0x0010D5E9 File Offset: 0x0010B7E9
		Public ReadOnly Property Count As Integer
			Get
				Return O_O0OO.OOOo.oo_OOOO_0.().Relations.Count
			End Get
		End Property

		' Token: 0x06002836 RID: 10294 RVA: 0x0010D5FC File Offset: 0x0010B7FC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Add(ParamArray args As Object()) As Relation
			Select Case args.Length
				Case 3
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(args(2))
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is DataCol AndAlso TypeOf objectValue3 Is DataCol Then
						Dim relationName As String = Conversions.ToString(objectValue).Trim()
						Dim parentCol As DataCol = CType(objectValue2, DataCol)
						Dim childCol As DataCol = CType(objectValue3, DataCol)
						Return Me.Add(relationName, parentCol, childCol)
					End If
					If TypeOf objectValue Is String AndAlso TypeOf objectValue2 Is Object() AndAlso TypeOf objectValue3 Is Object() Then
						Dim relationName2 As String = Conversions.ToString(objectValue).Trim()
						Dim parentCols As DataCol() = CType(objectValue2, DataCol())
						Dim childCols As DataCol() = CType(objectValue3, DataCol())
						Return Me.Add(relationName2, parentCols, childCols)
					End If
				Case 4
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(args(3))
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is DataCol AndAlso TypeOf objectValue6 Is DataCol AndAlso TypeOf objectValue7 Is Boolean Then
						Dim relationName3 As String = Conversions.ToString(objectValue4).Trim()
						Dim parentCol2 As DataCol = CType(objectValue5, DataCol)
						Dim childCol2 As DataCol = CType(objectValue6, DataCol)
						Dim visible As Boolean = Conversions.ToBoolean(objectValue7)
						Return Me.Add(relationName3, parentCol2, childCol2, visible)
					End If
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is DataCol AndAlso TypeOf objectValue6 Is DataCol AndAlso TypeOf objectValue7 Is Integer Then
						Dim relationName4 As String = Conversions.ToString(objectValue4).Trim()
						Dim parentCol3 As DataCol = CType(objectValue5, DataCol)
						Dim childCol3 As DataCol = CType(objectValue6, DataCol)
						Dim relationPath As RelationPathEnum = Conversions.ToInteger(objectValue7)
						Return Me.Add(relationName4, parentCol3, childCol3, relationPath)
					End If
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is Object() AndAlso TypeOf objectValue6 Is Object() AndAlso TypeOf objectValue7 Is Boolean Then
						Dim relationName5 As String = Conversions.ToString(objectValue4).Trim()
						Dim parentCols2 As DataCol() = CType(objectValue5, DataCol())
						Dim childCols2 As DataCol() = CType(objectValue6, DataCol())
						Dim visible2 As Boolean = Conversions.ToBoolean(objectValue7)
						Return Me.Add(relationName5, parentCols2, childCols2, visible2)
					End If
					If TypeOf objectValue4 Is String AndAlso TypeOf objectValue5 Is Object() AndAlso TypeOf objectValue6 Is Object() AndAlso TypeOf objectValue7 Is Integer Then
						Dim relationName6 As String = Conversions.ToString(objectValue4).Trim()
						Dim parentCols3 As DataCol() = CType(objectValue5, DataCol())
						Dim childCols3 As DataCol() = CType(objectValue6, DataCol())
						Dim relationPath2 As RelationPathEnum = Conversions.ToInteger(objectValue7)
						Return Me.Add(relationName6, parentCols3, childCols3, relationPath2)
					End If
				Case 5
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(args(0))
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(args(1))
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(args(2))
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(args(3))
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(args(4))
					If TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is DataCol AndAlso TypeOf objectValue10 Is DataCol AndAlso TypeOf objectValue11 Is Boolean AndAlso TypeOf objectValue12 Is Integer Then
						Dim relationName7 As String = Conversions.ToString(objectValue8).Trim()
						Dim parentCol4 As DataCol = CType(objectValue9, DataCol)
						Dim childCol4 As DataCol = CType(objectValue10, DataCol)
						Dim visible3 As Boolean = Conversions.ToBoolean(objectValue11)
						Dim relationPath3 As RelationPathEnum = Conversions.ToInteger(objectValue12)
						Return Me.Add(relationName7, parentCol4, childCol4, visible3, relationPath3)
					End If
					If TypeOf objectValue8 Is String AndAlso TypeOf objectValue9 Is Object() AndAlso TypeOf objectValue10 Is Object() AndAlso TypeOf objectValue11 Is Boolean AndAlso TypeOf objectValue12 Is Integer Then
						Dim relationName8 As String = Conversions.ToString(objectValue8).Trim()
						Dim parentCols4 As DataCol() = CType(objectValue9, DataCol())
						Dim childCols4 As DataCol() = CType(objectValue10, DataCol())
						Dim visible4 As Boolean = Conversions.ToBoolean(objectValue11)
						Dim relationPath4 As RelationPathEnum = Conversions.ToInteger(objectValue12)
						Return Me.Add(relationName8, parentCols4, childCols4, visible4, relationPath4)
					End If
			End Select
			Return Nothing
		End Function

		' Token: 0x06002837 RID: 10295 RVA: 0x0010D9B0 File Offset: 0x0010BBB0
		Public Function Add(RelationName As String, ParentCols As DataCol(), ChildCols As DataCol(), Visible As Boolean, RelationPath As RelationPathEnum) As Relation
			Dim array As DataColumn() = New DataColumn(ParentCols.Length - 1 + 1 - 1) {}
			Dim array2 As DataColumn() = New DataColumn(ChildCols.Length - 1 + 1 - 1) {}
			Dim result As Relation
			If Me.Contains(RelationName) Then
				MessageBox.Show("关联[" + RelationName + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			ElseIf ParentCols.Length <> ChildCols.Length Then
				MessageBox.Show("创建关联[" + RelationName + "[失败，父表和子表的关联列数量必须相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = Nothing
			Else
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					array(i) = ParentCols(i).BaseColumn
					array2(i) = ChildCols(i).BaseColumn
					If array(i).DataType IsNot array2(i).DataType Then
						MessageBox.Show("创建关联[" + RelationName + "[失败，父表和子表对应关联列的数据类型必须相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return Nothing
					End If
				Next
				If Oo00.O____0O._0.(array(0).Table.TableName, array2(0).Table.TableName, Nothing) Then
					MessageBox.Show("表之间已经存在关联，无法再增加新的关联" + RelationName + """！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					result = Nothing
				Else
					Dim o0Oo As O0Oo = New O0Oo(RelationName, array, array2, Nothing)
					o0Oo.oo0__.0Oo0o_.(RelationPath)
					O_O0OO.OOOo.oo_OOOO_0.().Relations.Add(o0Oo)
					Oo00.o00O0O_.O.(RelationName, Visible, True)
					result = New Relation(o0Oo)
				End If
			End If
			Return result
		End Function

		' Token: 0x06002838 RID: 10296 RVA: 0x0010DB14 File Offset: 0x0010BD14
		Public Function Add(RelationName As String, ParentCols As DataCol(), ChildCols As DataCol()) As Relation
			Return Me.Add(RelationName, ParentCols, ChildCols, True, 0)
		End Function

		' Token: 0x06002839 RID: 10297 RVA: 0x0010DB21 File Offset: 0x0010BD21
		Public Function Add(RelationName As String, ParentCols As DataCol(), ChildCols As DataCol(), Visible As Boolean) As Relation
			Return Me.Add(RelationName, ParentCols, ChildCols, Visible, 0)
		End Function

		' Token: 0x0600283A RID: 10298 RVA: 0x0010DB2F File Offset: 0x0010BD2F
		Public Function Add(RelationName As String, ParentCols As DataCol(), ChildCols As DataCol(), RelationPath As RelationPathEnum) As Relation
			Return Me.Add(RelationName, ParentCols, ChildCols, True, RelationPath)
		End Function

		' Token: 0x0600283B RID: 10299 RVA: 0x0010DB3D File Offset: 0x0010BD3D
		Public Function Add(RelationName As String, ParentCol As DataCol, ChildCol As DataCol) As Relation
			Return Me.Add(RelationName, New DataCol() { ParentCol }, New DataCol() { ChildCol }, True, 0)
		End Function

		' Token: 0x0600283C RID: 10300 RVA: 0x0010DB5C File Offset: 0x0010BD5C
		Public Function Add(RelationName As String, ParentCol As DataCol, ChildCol As DataCol, Visible As Boolean) As Relation
			Return Me.Add(RelationName, New DataCol() { ParentCol }, New DataCol() { ChildCol }, Visible, 0)
		End Function

		' Token: 0x0600283D RID: 10301 RVA: 0x0010DB7C File Offset: 0x0010BD7C
		Public Function Add(RelationName As String, ParentCol As DataCol, ChildCol As DataCol, RelationPath As RelationPathEnum) As Relation
			Return Me.Add(RelationName, New DataCol() { ParentCol }, New DataCol() { ChildCol }, True, RelationPath)
		End Function

		' Token: 0x0600283E RID: 10302 RVA: 0x0010DB9C File Offset: 0x0010BD9C
		Public Function Add(RelationName As String, ParentCol As DataCol, ChildCol As DataCol, Visible As Boolean, RelationPath As RelationPathEnum) As Relation
			Return Me.Add(RelationName, New DataCol() { ParentCol }, New DataCol() { ChildCol }, Visible, RelationPath)
		End Function

		' Token: 0x0600283F RID: 10303 RVA: 0x0010DBC0 File Offset: 0x0010BDC0
		Public Sub Delete(RelationName As String)
			If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows.Find(RelationName) IsNot Nothing Then
				MessageBox.Show("固有关联只能通过菜单命令删除，不能通过代码删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Return
			End If
			If Me.Contains(RelationName) Then
				Oo00.OO.0O0o.(RelationName)
			End If
		End Sub

		' Token: 0x06002840 RID: 10304 RVA: 0x0010DC11 File Offset: 0x0010BE11
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator() As IEnumerator(Of Relation) Implements System.Collections.Generic.IEnumerable(Of Foxtable.Relation).GetEnumerator
			Return New o0o_Oo_o()
		End Function

		' Token: 0x06002841 RID: 10305 RVA: 0x0010DC18 File Offset: 0x0010BE18
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New o0o_Oo_o()
		End Function
	End Class
End Namespace
