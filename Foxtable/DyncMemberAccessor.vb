Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

Namespace Foxtable
	' Token: 0x020001D6 RID: 470
	<ComVisible(True)>
	Public Class DyncMemberAccessor
		' Token: 0x060016E2 RID: 5858 RVA: 0x00093B61 File Offset: 0x00091D61
		Public Sub New(A_0 As Type)
			Me.o.0_OoO_. = A_0
		End Sub

		' Token: 0x170004E2 RID: 1250
		Public ReadOnly Default Property Item(A_0 As String) As Object
			Get
				Dim result As Object
				If Me.o.0_OoO_..IsEnum Then
					result = [Enum].Parse(Me.o.0_OoO_., A_0, True)
				Else
					Dim [property] As PropertyInfo = Me.o.0_OoO_..GetProperty(A_0, BindingFlags.IgnoreCase Or BindingFlags.[Static] Or BindingFlags.[Public])
					If [property] IsNot Nothing Then
						result = [property].GetValue(Nothing)
					Else
						Dim field As FieldInfo = Me.o.0_OoO_..GetField(A_0, BindingFlags.IgnoreCase Or BindingFlags.[Static] Or BindingFlags.[Public])
						If field IsNot Nothing Then
							result = field.GetValue(Nothing)
						Else
							result = Nothing
						End If
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x0400091B RID: 2331
		Private <<EMPTY_NAME>> As Type

		' Token: 0x0400091C RID: 2332
		Private Const <<EMPTY_NAME>> As BindingFlags = BindingFlags.IgnoreCase Or BindingFlags.[Static] Or BindingFlags.[Public]
	End Class
End Namespace
