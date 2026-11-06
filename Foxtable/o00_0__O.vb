Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000091 RID: 145
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class o00_0__O
		' Token: 0x06000565 RID: 1381 RVA: 0x0001D258 File Offset: 0x0001B458
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As DataTable
			Return Me.oOO.0_O0.
		End Function

		' Token: 0x06000566 RID: 1382 RVA: 0x0001D260 File Offset: 0x0001B460
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As DataTable)
			Me.oOO.0_O0. = A_0
		End Sub

		' Token: 0x06000567 RID: 1383 RVA: 0x0001D269 File Offset: 0x0001B469
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As String
			Return Me.oOO.0_O0.
		End Function

		' Token: 0x06000568 RID: 1384 RVA: 0x0001D271 File Offset: 0x0001B471
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oOO.0_O0. = A_0
		End Sub

		' Token: 0x06000569 RID: 1385 RVA: 0x0001D27A File Offset: 0x0001B47A
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O0oo_.0_o0o0oO.
		End Function

		' Token: 0x0600056A RID: 1386 RVA: 0x0001D282 File Offset: 0x0001B482
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0oo_.0_o0o0oO. = A_0
		End Sub

		' Token: 0x0600056B RID: 1387 RVA: 0x0001D28B File Offset: 0x0001B48B
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As String
			Return Me.o_Ooo0.o_oO.
		End Function

		' Token: 0x0600056C RID: 1388 RVA: 0x0001D293 File Offset: 0x0001B493
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o_Ooo0.o_oO. = A_0
		End Sub

		' Token: 0x0600056D RID: 1389 RVA: 0x0001D29C File Offset: 0x0001B49C
		<CompilerGenerated()>
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.oOO.0_O0.
		End Function

		' Token: 0x0600056E RID: 1390 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.oOO.0_O0. = A_0
		End Sub

		' Token: 0x0600056F RID: 1391 RVA: 0x0001D2AD File Offset: 0x0001B4AD
		Public Function <<EMPTY_NAME>>() As DataView
			If Me.oOO.0_O0. Is Nothing Then
				Me.oOO.0_O0. = New DataView(Me.oo__.0O00.().BaseTable, "", Me.oooO00__.o0.(), DataViewRowState.CurrentRows)
			End If
			Return Me.oOO.0_O0.
		End Function

		' Token: 0x06000570 RID: 1392 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		Friend Sub New(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String)
			Me.oo__.0O00.(False)
			Me.oo__.0O00.(A_0)
			Me.oo__.0O00.(A_1)
			Me.o_Ooo0.o_oO.(A_2)
			Me.o.oOo_Oo0O.(A_3)
		End Sub

		' Token: 0x06000571 RID: 1393 RVA: 0x0001D30C File Offset: 0x0001B50C
		Public Function <<EMPTY_NAME>>() As String
			Dim result As String
			If Operators.CompareString(Me.o.oOo_Oo0O.(), "", True) > 0 Then
				result = Me.o.oOo_Oo0O.()
			Else
				If Not Me.oo__.0O00.() Then
					Throw New Exception("未指定扩展列名称！")
				End If
				result = Me.oooO00.o00O.()
			End If
			Return result
		End Function

		' Token: 0x04000138 RID: 312
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04000139 RID: 313
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400013A RID: 314
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400013B RID: 315
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400013C RID: 316
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400013D RID: 317
		Private <<EMPTY_NAME>> As DataView
	End Class
End Namespace
