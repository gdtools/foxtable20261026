Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200006A RID: 106
	Friend Class o0o
		Inherits StringConverter

		' Token: 0x06000394 RID: 916 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000395 RID: 917 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000396 RID: 918 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._o.())
			If dataTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows)
					list.Add(dataRow("Name").ToString())
				Next
			End If
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
