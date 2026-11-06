Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200008B RID: 139
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BomTable
		' Token: 0x1700013A RID: 314
		' (get) Token: 0x06000514 RID: 1300 RVA: 0x0001CDB3 File Offset: 0x0001AFB3
		' (set) Token: 0x06000515 RID: 1301 RVA: 0x0001CDBB File Offset: 0x0001AFBB
		Public Property DataTable As DataTable

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x06000516 RID: 1302 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		' (set) Token: 0x06000517 RID: 1303 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		Public Property ParentCol As String

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x06000518 RID: 1304 RVA: 0x0001CDD5 File Offset: 0x0001AFD5
		' (set) Token: 0x06000519 RID: 1305 RVA: 0x0001CDDD File Offset: 0x0001AFDD
		Public Property PathCol As String

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x0600051A RID: 1306 RVA: 0x0001CDE6 File Offset: 0x0001AFE6
		' (set) Token: 0x0600051B RID: 1307 RVA: 0x0001CDF3 File Offset: 0x0001AFF3
		Public Property Separator As String
			Get
				Return Conversions.ToString(Me.Separator2)
			End Get
			Set(value As String)
				If value.Length > 0 Then
					Me.Separator2 = value(0)
				End If
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x0600051C RID: 1308 RVA: 0x0001CE0B File Offset: 0x0001B00B
		' (set) Token: 0x0600051D RID: 1309 RVA: 0x0001CE13 File Offset: 0x0001B013
		Friend Property Separator2 As Char

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x0600051E RID: 1310 RVA: 0x0001CE1C File Offset: 0x0001B01C
		' (set) Token: 0x0600051F RID: 1311 RVA: 0x0001CE70 File Offset: 0x0001B070
		Public Property Lengths As Object()
			Get
				Dim list As List(Of Object) = New List(Of Object)()
				If Me.lengths2 IsNot Nothing AndAlso Me.lengths2.Length > 0 Then
					For Each num As Integer In Me.lengths2
						list.Add(num)
					Next
				End If
				Return list.ToArray()
			End Get
			Set(value As Object())
				Dim list As List(Of Integer) = New List(Of Integer)()
				For i As Integer = 0 To value.Length - 1
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(value(i))
					If TypeOf objectValue Is Integer Then
						list.Add(Conversions.ToInteger(objectValue))
					End If
				Next
				Me.lengths2 = list.ToArray()
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x06000520 RID: 1312 RVA: 0x0001CEBC File Offset: 0x0001B0BC
		' (set) Token: 0x06000521 RID: 1313 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		Friend Property lengths2 As Integer()

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x06000522 RID: 1314 RVA: 0x0001CECD File Offset: 0x0001B0CD
		' (set) Token: 0x06000523 RID: 1315 RVA: 0x0001CED5 File Offset: 0x0001B0D5
		Public Property MaterialCol As String

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x06000524 RID: 1316 RVA: 0x0001CEDE File Offset: 0x0001B0DE
		' (set) Token: 0x06000525 RID: 1317 RVA: 0x0001CEE6 File Offset: 0x0001B0E6
		Public Property QuantityCol As String

		' Token: 0x04000117 RID: 279
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000118 RID: 280
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000119 RID: 281
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400011A RID: 282
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Char

		' Token: 0x0400011B RID: 283
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer()

		' Token: 0x0400011C RID: 284
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400011D RID: 285
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
