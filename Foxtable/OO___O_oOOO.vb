Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020001D3 RID: 467
	<DefaultMember("Item")>
	<ComVisible(True)>
	Public Class OO___O_oOOO
		' Token: 0x060015DC RID: 5596 RVA: 0x00091131 File Offset: 0x0008F331
		Public Sub New(A_0 As Assembly, A_1 As String)
			Me.ooO_0oo.oOo0o. = New Dictionary(Of String, Type)(StringComparer.OrdinalIgnoreCase)
			Me.ooO_0oo.oOo0o. = A_0
			Me.ooO_0oo.oOo0o. = A_1
		End Sub

		' Token: 0x060015DD RID: 5597 RVA: 0x00091158 File Offset: 0x0008F358
		Private Function <<EMPTY_NAME>>(A_0 As String) As Type
			Dim result As Type
			If Me.ooO_0oo.oOo0o..ContainsKey(A_0) Then
				result = Me.ooO_0oo.oOo0o.(A_0)
			Else
				A_0.ToLower()
				Dim type As Type = Me.ooO_0oo.oOo0o..[GetType](Me.ooO_0oo.oOo0o. + "." + A_0, False, True)
				If type IsNot Nothing Then
					Me.ooO_0oo.oOo0o..Add(A_0, type)
					result = type
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x060015DE RID: 5598 RVA: 0x000911C4 File Offset: 0x0008F3C4
		Public Function <<EMPTY_NAME>>(A_0 As String) As Object
			Dim type As Type = Me.O.0o_0_o.(A_0)
			Dim result As Object
			If type IsNot Nothing Then
				If type.IsClass OrElse (type.IsValueType AndAlso Not type.IsEnum AndAlso Not type.IsPrimitive) Then
					Try
						Return Activator.CreateInstance(type)
					Catch ex As Exception
						Return Nothing
					End Try
				End If
				result = New DyncMemberAccessor(type)
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x060015DF RID: 5599 RVA: 0x00091234 File Offset: 0x0008F434
		Public Function <<EMPTY_NAME>>() As IEnumerator
			Return Enumerable.Empty(Of Object)().GetEnumerator()
		End Function

		' Token: 0x0400090D RID: 2317
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400090E RID: 2318
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x0400090F RID: 2319
		Private <<EMPTY_NAME>> As Dictionary(Of String, Type)
	End Class
End Namespace
