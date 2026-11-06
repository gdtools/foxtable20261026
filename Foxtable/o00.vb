Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005E RID: 94
	Friend Class o00
		Inherits StringConverter

		' Token: 0x06000308 RID: 776 RVA: 0x00008B68 File Offset: 0x00006D68
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000309 RID: 777 RVA: 0x00008B6B File Offset: 0x00006D6B
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x0600030A RID: 778 RVA: 0x00008B70 File Offset: 0x00006D70
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.AddRange(OO_00oOO.Themes)
			list.Insert(0, "(default)")
			list.Insert(0, "(none)")
			Return New TypeConverter.StandardValuesCollection(list)
		End Function

		' Token: 0x0600030B RID: 779 RVA: 0x00008BAC File Offset: 0x00006DAC
		Public Overridable Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object) As Object
			Dim result As Object
			If A_2 IsNot Nothing AndAlso Operators.CompareString(A_2.ToString(), "默认", True) = 0 Then
				result = "(default)"
			ElseIf A_2 IsNot Nothing AndAlso Operators.CompareString(A_2.ToString(), "无", True) = 0 Then
				result = "(none)"
			Else
				result = MyBase.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2))
			End If
			Return result
		End Function

		' Token: 0x0600030C RID: 780 RVA: 0x00008C08 File Offset: 0x00006E08
		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
			Dim result As Object
			If value IsNot Nothing AndAlso Operators.CompareString(value.ToString(), "(default)", True) = 0 Then
				result = "默认"
			ElseIf value IsNot Nothing AndAlso Operators.CompareString(value.ToString(), "(none)", True) = 0 Then
				result = "无"
			Else
				result = MyBase.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType)
			End If
			Return result
		End Function
	End Class
End Namespace
