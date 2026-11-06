Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x02000051 RID: 81
	Friend Class oO0O_O
		Inherits StringConverter

		' Token: 0x060002D6 RID: 726 RVA: 0x0000749C File Offset: 0x0000569C
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002D7 RID: 727 RVA: 0x0000749F File Offset: 0x0000569F
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002D8 RID: 728 RVA: 0x000074A4 File Offset: 0x000056A4
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Try
				For Each userInfo As UserInfo In OO_00oOO.Users
					list.Add(userInfo.Name)
				Next
			Finally
				Dim enumerator As IEnumerator(Of UserInfo)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
