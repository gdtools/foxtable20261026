Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000059 RID: 89
	Friend Class Oo0ooO0o_
		Inherits Int32Converter

		' Token: 0x060002F6 RID: 758 RVA: 0x00008119 File Offset: 0x00006319
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002F7 RID: 759 RVA: 0x0000811C File Offset: 0x0000631C
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002F8 RID: 760 RVA: 0x00008120 File Offset: 0x00006320
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim values As Integer()
			If TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ooo00oO Then
				values = New Integer() { 8, 9, 10, 11, 12, 13 }
			Else
				values = New Integer() { 0, 8, 9, 10, 11, 12, 13 }
			End If
			Return New TypeConverter.StandardValuesCollection(values)
		End Function

		' Token: 0x060002F9 RID: 761 RVA: 0x00008170 File Offset: 0x00006370
		Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, value As Object) As Object
			Dim result As Object
			If value IsNot Nothing And Operators.CompareString(value.ToString(), "默认", True) = 0 Then
				result = 0
			Else
				result = MyBase.ConvertFrom(context, culture, RuntimeHelpers.GetObjectValue(value))
			End If
			Return result
		End Function

		' Token: 0x060002FA RID: 762 RVA: 0x000081B4 File Offset: 0x000063B4
		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
			Dim result As Object
			If value Is Nothing OrElse Operators.CompareString(value.ToString(), "0", True) = 0 Then
				result = "默认"
			Else
				result = MyBase.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType)
			End If
			Return result
		End Function
	End Class
End Namespace
