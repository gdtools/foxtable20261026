Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000039 RID: 57
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module O00OOOo_O0_O
		' Token: 0x060001E3 RID: 483 RVA: 0x000051A1 File Offset: 0x000033A1
		Friend Function <<EMPTY_NAME>>(A_0 As PropertyInfo) As Boolean
			Return Attribute.IsDefined(A_0, GetType(O0O0oOO00_0OO))
		End Function

		' Token: 0x060001E4 RID: 484 RVA: 0x000051B3 File Offset: 0x000033B3
		Friend Function <<EMPTY_NAME>>(A_0 As PropertyDescriptor) As Boolean
			Return A_0.Attributes(GetType(O0O0oOO00_0OO)) IsNot Nothing
		End Function

		' Token: 0x060001E5 RID: 485 RVA: 0x000051CD File Offset: 0x000033CD
		Friend Function <<EMPTY_NAME>>(A_0 As PropertyDescriptor) As Boolean
			Return A_0.Attributes(GetType(o__o)) IsNot Nothing
		End Function

		' Token: 0x060001E6 RID: 486 RVA: 0x000051E7 File Offset: 0x000033E7
		Friend Function <<EMPTY_NAME>>(A_0 As PropertyInfo) As Boolean
			Return Attribute.IsDefined(A_0, GetType(oO0oo))
		End Function

		' Token: 0x060001E7 RID: 487 RVA: 0x000051F9 File Offset: 0x000033F9
		Friend Function <<EMPTY_NAME>>(A_0 As PropertyInfo) As Boolean
			Return Attribute.IsDefined(A_0, GetType(OooO0))
		End Function

		' Token: 0x060001E8 RID: 488 RVA: 0x0000520C File Offset: 0x0000340C
		Friend Function b(A_0 As String, A_1 As Integer) As String
			Dim array As Char() = A_0.ToCharArray()
			Dim num As Integer = 1681255565 + A_1
			Dim num2 As Integer = 0
			Dim obj As Object = num2
			Dim obj2 As Object = num2
			If num2 < 1 Then
				GoTo IL_47
			End If
			IL_14:
			Dim obj3 As Object = obj2
			Dim num3 As Integer = obj3
			Dim array2 As Char() = array
			Dim num4 As Integer = num3
			Dim c As Char = array(num3)
			Dim num5 As Integer = CInt((c And "ÿ"c))
			Dim num6 As Integer = num
			num = num6 + 1
			Dim b As Byte = CByte((num5 Xor num6))
			Dim num7 As Integer = CInt((c >> 8))
			Dim num8 As Integer = num
			num = num8 + 1
			Dim b2 As Byte = CByte((num7 Xor num8))
			Dim b3 As Byte = b2
			b2 = b
			b = b3
			array2(num4) = CUShort((CInt(b2) << 8 Or CInt(b)))
			obj = obj3 + 1
			IL_47:
			Dim obj4 As Object = obj
			obj2 = obj4
			If obj4 >= array.Length Then
				Return String.Intern(New String(array))
			End If
			GoTo IL_14
		End Function
	End Module
End Namespace
