Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000050 RID: 80
	Friend Class OoO_O0_OO0
		Inherits StringConverter

		' Token: 0x060002D2 RID: 722 RVA: 0x00007414 File Offset: 0x00005614
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002D3 RID: 723 RVA: 0x00007417 File Offset: 0x00005617
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002D4 RID: 724 RVA: 0x0000741C File Offset: 0x0000561C
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Try
				For Each table As Table In OO_00oOO.Tables
					If Not table.IsRelation Then
						list.Add(table.Name)
					End If
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
