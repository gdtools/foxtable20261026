Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000057 RID: 87
	Friend Class ooo_0O0
		Inherits StringConverter

		' Token: 0x060002EC RID: 748 RVA: 0x00007FB0 File Offset: 0x000061B0
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002ED RID: 749 RVA: 0x00007FB3 File Offset: 0x000061B3
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002EE RID: 750 RVA: 0x00007FB8 File Offset: 0x000061B8
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Try
				For Each table As Table In OO_00oOO.Tables
					list.Add(table.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			list.Sort()
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
