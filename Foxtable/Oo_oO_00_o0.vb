Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000058 RID: 88
	Friend Class Oo_oO_00_o0
		Inherits StringConverter

		' Token: 0x060002F0 RID: 752 RVA: 0x00008030 File Offset: 0x00006230
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002F1 RID: 753 RVA: 0x00008033 File Offset: 0x00006233
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002F2 RID: 754 RVA: 0x00008038 File Offset: 0x00006238
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ooo00oO) Then
				list.Add("")
			End If
			For Each fontFamily As FontFamily In FontFamily.Families
				list.Add(fontFamily.Name)
			Next
			Return New TypeConverter.StandardValuesCollection(list)
		End Function

		' Token: 0x060002F3 RID: 755 RVA: 0x00008098 File Offset: 0x00006298
		Public Overridable Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object) As Object
			Dim result As Object
			If A_2 Is Nothing OrElse Operators.CompareString(A_2.ToString(), "默认", True) = 0 Then
				result = ""
			Else
				result = MyBase.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2))
			End If
			Return result
		End Function

		' Token: 0x060002F4 RID: 756 RVA: 0x000080D4 File Offset: 0x000062D4
		Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
			Dim result As Object
			If value Is Nothing OrElse Operators.CompareString(value.ToString(), "", True) = 0 Then
				result = "默认"
			Else
				result = MyBase.ConvertTo(context, culture, RuntimeHelpers.GetObjectValue(value), destinationType)
			End If
			Return result
		End Function
	End Class
End Namespace
