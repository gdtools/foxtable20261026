Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000C0 RID: 192
	Friend Class oooO0o000O
		' Token: 0x0600084F RID: 2127 RVA: 0x000392DE File Offset: 0x000374DE
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As DataSet
			Return Me.oo___O0.O.
		End Function

		' Token: 0x06000850 RID: 2128 RVA: 0x000392E6 File Offset: 0x000374E6
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As DataSet)
			Me.oo___O0.O. = A_0
		End Sub

		' Token: 0x06000851 RID: 2129 RVA: 0x000392EF File Offset: 0x000374EF
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As DataSet
			Return Me.Ooo.0O.
		End Function

		' Token: 0x06000852 RID: 2130 RVA: 0x000392F7 File Offset: 0x000374F7
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As DataSet)
			Me.Ooo.0O. = A_0
		End Sub

		' Token: 0x06000853 RID: 2131 RVA: 0x00039300 File Offset: 0x00037500
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As TableCollection
			Return Me.oo___O0.O.
		End Function

		' Token: 0x06000854 RID: 2132 RVA: 0x00039308 File Offset: 0x00037508
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As TableCollection)
			Me.oo___O0.O. = A_0
		End Sub

		' Token: 0x06000855 RID: 2133 RVA: 0x00039311 File Offset: 0x00037511
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As DataTableCollection
			Return Me.oo___O0.O.
		End Function

		' Token: 0x06000856 RID: 2134 RVA: 0x00039319 File Offset: 0x00037519
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTableCollection)
			Me.oo___O0.O. = A_0
		End Sub

		' Token: 0x06000857 RID: 2135 RVA: 0x00039322 File Offset: 0x00037522
		<CompilerGenerated()>
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, O_0)
			Return Me.oo___O0.O.
		End Function

		' Token: 0x06000858 RID: 2136 RVA: 0x0003932A File Offset: 0x0003752A
		<CompilerGenerated()>
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0))
			Me.oo___O0.O. = A_0
		End Sub

		' Token: 0x06000859 RID: 2137 RVA: 0x00039333 File Offset: 0x00037533
		Friend Sub <<EMPTY_NAME>>()
			Me.oo___O0.O.(O_O0OO.OoO.0OO__0ooo.())
			Me.o.o_0O00o0_.(O_O0OO.OOOo.oo_OOOO_0.())
			Me.oo___O0.O.(OO_00oOO.Tables)
			Me.O0oo_0_.__0__.(OO_00oOO.DataTables)
			Me.oo___O0.O.(O_O0OO.o__.O.())
		End Sub

		' Token: 0x0600085A RID: 2138 RVA: 0x0003936C File Offset: 0x0003756C
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim array As DataSet() = New DataSet() { Me.o.o_0O00o0_.(), Me.O0oo_0_.__0__.() }
				IL_22:
				num2 = 3
				For Each dataSet As DataSet In array
					IL_33:
					num2 = 4
					If dataSet IsNot Nothing Then
						IL_39:
						num2 = 6
						If dataSet IsNot O_O0OO.OoO.0OO__0ooo.() Then
							IL_44:
							num2 = 8
							dataSet.Reset()
							IL_4D:
							num2 = 9
							dataSet.Dispose()
						End If
					End If
					IL_57:
					num2 = 10
				Next
				IL_68:
				num2 = 11
				Me.oo___O0.O.(Nothing)
				IL_72:
				num2 = 12
				Me.o.o_0O00o0_.(Nothing)
				IL_7C:
				num2 = 13
				If Me.O0oo_0_.__0__.() Is Nothing Then
					GoTo IL_14C
				End If
				IL_8A:
				num2 = 14
				Dim enumerator As IEnumerator(Of DataTable) = Me.O0oo_0_.__0__.().GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_A5:
					num2 = 15
					If dataTable.o_oO0O_.O0. IsNot Nothing Then
						IL_B1:
						num2 = 16
						dataTable.o_oO0O_.O0.._Rows = Nothing
						IL_C1:
						num2 = 17
						dataTable.o_oO0O_.O0. = Nothing
						IL_CC:
						num2 = 18
						dataTable.o.O0O_0__OOo_..O_0__o.o_0o..Clear()
						IL_E0:
						num2 = 19
						dataTable.o.O0O_0__OOo_..O_0__o.o_0o. = Nothing
						IL_F0:
						num2 = 20
						dataTable.o.O0O_0__OOo_. = Nothing
						IL_FB:
						num2 = 21
						dataTable._DataTable = Nothing
					End If
					IL_106:
					num2 = 22
				End While
				IL_112:
				num2 = 23
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_120:
				num2 = 24
				Me.O0oo_0_.__0__.().OO0o00.0O_0o..Clear()
				IL_133:
				num2 = 25
				Me.O0oo_0_.__0__.().OO0o00.0O_0o. = Nothing
				IL_142:
				num2 = 26
				Me.O0oo_0_.__0__.(Nothing)
				IL_14C:
				num2 = 27
				If Me.O0oo_0_.__0__.() Is Nothing Then
					GoTo IL_1A1
				End If
				IL_157:
				num2 = 28
				Dim enumerator2 As IEnumerator(Of Table) = Me.O0oo_0_.__0__.().GetEnumerator()
				While enumerator2.MoveNext()
					Dim table As Table = enumerator2.Current
					IL_172:
					num2 = 29
					table.o.0ooOO_0__. = Nothing
					IL_17D:
					num2 = 30
				End While
				IL_189:
				num2 = 31
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_197:
				num2 = 32
				Me.oo___O0.O.(Nothing)
				IL_1A1:
				num2 = 33
				If Me.O0oo_0_.__0__.() Is Nothing Then
					GoTo IL_1C4
				End If
				IL_1AC:
				num2 = 34
				Me.O0oo_0_.__0__.().Clear()
				IL_1BA:
				num2 = 35
				Me.oo___O0.O.(Nothing)
				IL_1C4:
				GoTo IL_2A6
				IL_1C9:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_267:
				GoTo IL_29B
				IL_269:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_279:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_269
			End Try
			IL_29B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2A6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x040002D6 RID: 726
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x040002D7 RID: 727
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x040002D8 RID: 728
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TableCollection

		' Token: 0x040002D9 RID: 729
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DataTableCollection

		' Token: 0x040002DA RID: 730
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Dictionary(Of String, O_0)
	End Class
End Namespace
