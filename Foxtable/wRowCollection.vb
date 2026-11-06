Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000221 RID: 545
	Public Class wRowCollection
		Implements IEnumerable(Of wTableRow)

		' Token: 0x06001961 RID: 6497 RVA: 0x000A4A65 File Offset: 0x000A2C65
		Public Sub New()
			Me.OOOO0._0O. = New List(Of wTableRow)()
		End Sub

		' Token: 0x06001962 RID: 6498 RVA: 0x000A4A78 File Offset: 0x000A2C78
		<oO0oooo("A0063")>
		Public Function AddRow(ParamArray values As String()) As wTableRow
			Dim wTableRow As wTableRow = New wTableRow()
			wTableRow.AddCells(values)
			Me.OOOO0._0O..Add(wTableRow)
			Return wTableRow
		End Function

		' Token: 0x06001963 RID: 6499 RVA: 0x000A4A9F File Offset: 0x000A2C9F
		<oO0oooo("A0063")>
		Public Function AddRow(values As List(Of String)) As wTableRow
			Return Me.AddRow(values.ToArray())
		End Function

		' Token: 0x06001964 RID: 6500 RVA: 0x000A4AAD File Offset: 0x000A2CAD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function <<EMPTY_NAME>>() As IEnumerator(Of wTableRow) Implements System.Collections.Generic.IEnumerable(Of Foxtable.wTableRow).GetEnumerator
			Return CType(Me.OOOO0._0O..GetEnumerator(), IEnumerator(Of wTableRow))
		End Function

		' Token: 0x06001965 RID: 6501 RVA: 0x000A4AC4 File Offset: 0x000A2CC4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Function <<EMPTY_NAME>>() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return CType(Me.OOOO0._0O..GetEnumerator(), IEnumerator)
		End Function

		' Token: 0x170005A3 RID: 1443
		' (get) Token: 0x06001966 RID: 6502 RVA: 0x000A4ADB File Offset: 0x000A2CDB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Count As Integer
			Get
				Return Me.OOOO0._0O..Count
			End Get
		End Property

		' Token: 0x170005A4 RID: 1444
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(A_0 As Integer) As wTableRow
			Get
				Return Me.OOOO0._0O.(A_0)
			End Get
			Set(value As wTableRow)
				Me.OOOO0._0O.(A_0) = value
			End Set
		End Property

		' Token: 0x04000AB1 RID: 2737
		Private <<EMPTY_NAME>> As List(Of wTableRow)
	End Class
End Namespace
