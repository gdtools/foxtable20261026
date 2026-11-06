Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001A2 RID: 418
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class ListViewColumnCollections
		Implements IEnumerable(Of ListViewColumn)

		' Token: 0x060013B9 RID: 5049 RVA: 0x0007FD1D File Offset: 0x0007DF1D
		Friend Sub New(A_0 As o_OO_oOOO0o, A_1 As System.Windows.Forms.ListView.ColumnHeaderCollection)
			Me.oo.oO_. = A_0
			Me.oo.oO_. = A_1
		End Sub

		' Token: 0x17000404 RID: 1028
		' (get) Token: 0x060013BA RID: 5050 RVA: 0x0007FD33 File Offset: 0x0007DF33
		Public ReadOnly Property Count As Integer
			Get
				Return Me.oo.oO_..Count
			End Get
		End Property

		' Token: 0x17000405 RID: 1029
		' (get) Token: 0x060013BB RID: 5051 RVA: 0x0007FD40 File Offset: 0x0007DF40
		Public ReadOnly Property Contains(key As String) As Boolean
			Get
				Return Me.oo.oO_..ContainsKey(key)
			End Get
		End Property

		' Token: 0x17000406 RID: 1030
		Public ReadOnly Default Property Item(Index As Integer) As ListViewColumn
			Get
				Return New ListViewColumn(Me.oo.oO_.(Index))
			End Get
		End Property

		' Token: 0x17000407 RID: 1031
		Public ReadOnly Default Property Item(Key As String) As ListViewColumn
			Get
				Dim result As ListViewColumn
				If Operators.CompareString(Key, Me.oo.oO_..O_O.0Oo_o.(), True) = 0 Then
					result = New ListViewColumn(Me.oo.oO_..Columns(0))
				Else
					result = New ListViewColumn(Me.oo.oO_.(Key))
				End If
				Return result
			End Get
		End Property

		' Token: 0x060013BE RID: 5054 RVA: 0x0007FDB1 File Offset: 0x0007DFB1
		Public Sub Clear()
			Me.oo.oO_..Items.Clear()
			Me.oo.oO_..Clear()
		End Sub

		' Token: 0x060013BF RID: 5055 RVA: 0x0007FDD0 File Offset: 0x0007DFD0
		Public Function Add() As ListViewColumn
			Dim result As ListViewColumn
			If Not Me.oo.oO_.() Then
				result = Nothing
			Else
				Dim columnHeader As ColumnHeader = New ColumnHeader()
				Me.oo.oO_..Add(columnHeader)
				result = New ListViewColumn(columnHeader)
			End If
			Return result
		End Function

		' Token: 0x060013C0 RID: 5056 RVA: 0x0007FE04 File Offset: 0x0007E004
		Public Sub Delete(Key As String)
			If Me.oo.oO_.() Then
				If Operators.CompareString(Key, Me.oo.oO_..O_O.0Oo_o.(), True) = 0 Then
					Me.oo.oO_..RemoveAt(0)
					If Me.oo.oO_..Count > 0 Then
						Me.oo.oO_..o0__o.O0.(Me.oo.oO_..Columns(0).Name)
						Return
					End If
				Else
					Me.oo.oO_..RemoveByKey(Key)
				End If
			End If
		End Sub

		' Token: 0x060013C1 RID: 5057 RVA: 0x0007FE75 File Offset: 0x0007E075
		Public Sub Delete(Index As Integer)
			Me.oo.oO_..RemoveAt(Index)
		End Sub

		' Token: 0x060013C2 RID: 5058 RVA: 0x0007FE83 File Offset: 0x0007E083
		Public Sub Delete(item As ListViewColumn)
			If Me.oo.oO_.() Then
				Me.oo.oO_..Remove(item.BaseColumn)
			End If
		End Sub

		' Token: 0x060013C3 RID: 5059 RVA: 0x0007FE9E File Offset: 0x0007E09E
		Public Function GetEnumerator() As IEnumerator(Of ListViewColumn) Implements System.Collections.Generic.IEnumerable(Of Foxtable.WinForm.ListViewColumn).GetEnumerator
			Return New O0o(Me.oo.oO_.)
		End Function

		' Token: 0x060013C4 RID: 5060 RVA: 0x0007FEAB File Offset: 0x0007E0AB
		Public Function GetEnumerator1() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return New O0o(Me.oo.oO_.)
		End Function

		' Token: 0x060013C5 RID: 5061 RVA: 0x0007FEB8 File Offset: 0x0007E0B8
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			If Me.oo.oO_..Items.Count > 0 Then
				MessageBox.Show("在已经有行的情况下，不能再增加或删除列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x040007C3 RID: 1987
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListView.ColumnHeaderCollection

		' Token: 0x040007C4 RID: 1988
		Private <<EMPTY_NAME>> As o_OO_oOOO0o
	End Class
End Namespace
