Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000049 RID: 73
	Friend Class o0O
		Inherits EnumConverter

		' Token: 0x060002BA RID: 698 RVA: 0x000063F9 File Offset: 0x000045F9
		Public Sub New()
			MyBase.New(GetType(BooleanEnum))
		End Sub

		' Token: 0x060002BB RID: 699 RVA: 0x0000640C File Offset: 0x0000460C
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object) As Object
			Dim result As Object
			If Operators.CompareString(A_2.ToString(), "默认", True) = 0 Then
				result = 0
			Else
				result = MyBase.ConvertFrom(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2))
			End If
			Return result
		End Function

		' Token: 0x060002BC RID: 700 RVA: 0x00006448 File Offset: 0x00004648
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As CultureInfo, A_2 As Object, A_3 As Type) As Object
			Dim result As Object
			If Conversions.ToInteger(A_2) = 0 Then
				result = "默认"
			Else
				result = MyBase.ConvertTo(A_0, A_1, RuntimeHelpers.GetObjectValue(A_2), A_3)
			End If
			Return result
		End Function
	End Class
End Namespace
