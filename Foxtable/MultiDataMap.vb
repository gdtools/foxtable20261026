Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.InteropServices
Imports C1.Win.C1FlexGrid

Namespace Foxtable
	' Token: 0x02000312 RID: 786
	<oO0oooo("0581")>
	<ComVisible(True)>
	Public Class MultiDataMap
		' Token: 0x06002ACF RID: 10959 RVA: 0x0012CF8C File Offset: 0x0012B18C
		Public Sub New()
			Me.Oo.__O0. = New List(Of String)()
		End Sub

		' Token: 0x06002AD0 RID: 10960 RVA: 0x0012CF9F File Offset: 0x0012B19F
		Public Sub Add(Item As String)
			Me.Oo.__O0..Add(Item)
		End Sub

		' Token: 0x17000A17 RID: 2583
		' (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0012CFAD File Offset: 0x0012B1AD
		' (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0012CFB5 File Offset: 0x0012B1B5
		Public Property DisplayCol As Integer
			Get
				Return Me.Oo.__O0.
			End Get
			Set(value As Integer)
				Me.Oo.__O0. = value
			End Set
		End Property

		' Token: 0x17000A18 RID: 2584
		' (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0012CFBE File Offset: 0x0012B1BE
		' (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0012CFC6 File Offset: 0x0012B1C6
		Public Property ValueCol As Integer
			Get
				Return Me.O_.0_ooO_oo.
			End Get
			Set(value As Integer)
				Me.O_.0_ooO_oo. = value
			End Set
		End Property

		' Token: 0x06002AD5 RID: 10965 RVA: 0x0012CFD0 File Offset: 0x0012B1D0
		Public Function CreateDataMap() As IDictionary
			Dim result As IDictionary
			If Me.Oo.__O0..Count = 0 Then
				result = Nothing
			Else
				Dim dataTable As DataTable = New DataTable()
				Dim num As Integer = Me.Oo.__O0.(0).Split(New Char() { "|"c }).Length - 1
				For i As Integer = 0 To num
					dataTable.Columns.Add("C" + i.ToString(), GetType(String))
				Next
				Try
					For Each text As String In Me.Oo.__O0.
						Dim array As String() = text.Split(New Char() { "|"c })
						Dim dataRow As DataRow = dataTable.NewRow()
						Dim num2 As Integer = Math.Min(dataTable.Columns.Count - 1, array.Length - 1)
						For j As Integer = 0 To num2
							dataRow(j) = array(j)
						Next
						dataTable.Rows.Add(dataRow)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				result = New MultiColumnDictionary(dataTable, "C" + Me.ValueCol.ToString(), Nothing, Me.DisplayCol)
			End If
			Return result
		End Function

		' Token: 0x04001164 RID: 4452
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001165 RID: 4453
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001166 RID: 4454
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
