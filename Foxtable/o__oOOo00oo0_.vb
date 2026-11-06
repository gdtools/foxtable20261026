Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200004D RID: 77
	Friend Class o__oOOo00oo0_
		Inherits ColorConverter

		' Token: 0x060002C8 RID: 712 RVA: 0x00006C7C File Offset: 0x00004E7C
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object, A_3 As Type) As Object
			Dim result As Object
			If CType(A_2, Color) = Color.Transparent OrElse CType(A_2, Color) = Color.Empty Then
				result = "默认"
			Else
				result = MyBase.ConvertTo(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3)
			End If
			Return result
		End Function

		' Token: 0x060002C9 RID: 713 RVA: 0x00006CC8 File Offset: 0x00004EC8
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object) As Object
			Dim result As Object
			If Operators.CompareString(A_2.ToString(), "默认", True) = 0 Then
				result = Color.Transparent
			Else
				result = MyBase.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2))
			End If
			Return result
		End Function
	End Class
End Namespace
