Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000090 RID: 144
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class fxDataSource2
		' Token: 0x0600055C RID: 1372 RVA: 0x0001D16B File Offset: 0x0001B36B
		Public Sub New(A_0 As fxDataSource)
			Me.Oo.0_O00_. = A_0
		End Sub

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x0600055D RID: 1373 RVA: 0x0001D17A File Offset: 0x0001B37A
		Friend ReadOnly Property DataSource As fxDataSource
			Get
				Return Me.Oo.0_O00_.
			End Get
		End Property

		' Token: 0x0600055E RID: 1374 RVA: 0x0001D184 File Offset: 0x0001B384
		Public Sub Combine(ParamArray args As Object())
			If TypeOf args(0)Is String Then
				Me.Combine(Conversions.ToString(args(0)), CType(args(1), fxDataSource2), Conversions.ToString(args(2)))
				Return
			End If
			If TypeOf args(0)Is String() Then
				Dim leftCol As String() = ooO.oO0__o.0o__.(CType(args(0), Object()))
				Dim rightCol As String() = ooO.oO0__o.0o__.(CType(args(2), Object()))
				Me.Combine(leftCol, CType(args(1), fxDataSource2), rightCol)
			End If
		End Sub

		' Token: 0x0600055F RID: 1375 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		Public Sub Combine(LeftCol As String, RightTable As fxDataSource2, RightCol As String)
			Oo00.oO.OO.(Me.Oo.0_O00_., LeftCol, RightTable.DataSource, RightCol)
		End Sub

		' Token: 0x06000560 RID: 1376 RVA: 0x0001D205 File Offset: 0x0001B405
		Public Sub Combine(LeftCol As String(), RightTable As fxDataSource2, RightCol As String())
			Oo00.oO.OO.(Me.Oo.0_O00_., LeftCol, RightTable.DataSource, RightCol)
		End Sub

		' Token: 0x06000561 RID: 1377 RVA: 0x0001D21A File Offset: 0x0001B41A
		Public Sub Union(DataTable2 As fxDataSource2)
			Me.Oo.0_O00_..Merge(DataTable2.DataSource, False, MissingSchemaAction.Ignore)
		End Sub

		' Token: 0x06000562 RID: 1378 RVA: 0x0001D22F File Offset: 0x0001B42F
		Public Function ConvetToDataTable() As DataTable
			Return Me.Oo.0_O00_..ConvetToDataTable()
		End Function

		' Token: 0x06000563 RID: 1379 RVA: 0x0001D23C File Offset: 0x0001B43C
		Public Sub Show(TableName As String, Optional TableCaption As String = "")
			Me.Oo.0_O00_..Show(TableName, TableCaption)
		End Sub

		' Token: 0x06000564 RID: 1380 RVA: 0x0001D24B File Offset: 0x0001B44B
		Public Function ToDataTable() As DataTable
			Return Me.Oo.0_O00_..ToDataTable()
		End Function

		' Token: 0x04000137 RID: 311
		Private <<EMPTY_NAME>> As fxDataSource
	End Class
End Namespace
