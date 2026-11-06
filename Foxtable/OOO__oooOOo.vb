Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.OleDb

Namespace Foxtable
	' Token: 0x0200004C RID: 76
	Friend Class OOO__oooOOo
		Inherits StringConverter

		' Token: 0x060002C4 RID: 708 RVA: 0x00006BB4 File Offset: 0x00004DB4
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002C5 RID: 709 RVA: 0x00006BB7 File Offset: 0x00004DB7
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002C6 RID: 710 RVA: 0x00006BBC File Offset: 0x00004DBC
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Try
				For Each item As String In O_O0OO.O._o_.().Keys
					list.Add(item)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Try
				For Each item2 As String In O_O0OO.OoO__.0oO0oo.().Keys
					list.Add(item2)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, O0O).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
