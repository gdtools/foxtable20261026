Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000052 RID: 82
	Friend Class O__000__Oo0
		Inherits StringConverter

		' Token: 0x060002DA RID: 730 RVA: 0x00007514 File Offset: 0x00005714
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002DB RID: 731 RVA: 0x00007517 File Offset: 0x00005717
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002DC RID: 732 RVA: 0x0000751C File Offset: 0x0000571C
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.Add("")
			Try
				For Each form As Form In OO_00oOO.Forms
					If Conversions.ToInteger(form.O_o_.0o0__o0O.("Type")) = 233 Then
						list.Add(form.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Form)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
