Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005F RID: 95
	Friend Class oo__O__O_OoO
		Inherits StringConverter

		' Token: 0x0600030E RID: 782 RVA: 0x00008C6B File Offset: 0x00006E6B
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x0600030F RID: 783 RVA: 0x00008C6E File Offset: 0x00006E6E
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000310 RID: 784 RVA: 0x00008C74 File Offset: 0x00006E74
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ooo00oO) Then
				If TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is FormMenuProperty Then
					list.Add("(none)")
				ElseIf TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is FormProperty Then
					list.Add("(none)")
				End If
				list.Add("(default)")
			End If
			list.AddRange(OO_00oOO.Themes)
			Return New TypeConverter.StandardValuesCollection(list)
		End Function

		' Token: 0x06000311 RID: 785 RVA: 0x00008D00 File Offset: 0x00006F00
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

		' Token: 0x06000312 RID: 786 RVA: 0x00008D5C File Offset: 0x00006F5C
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
