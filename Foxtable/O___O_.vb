Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x02000424 RID: 1060
	Friend Class O___O_
		Implements O_o_0o

		' Token: 0x06004607 RID: 17927 RVA: 0x001C4F6A File Offset: 0x001C316A
		Friend Sub New(A_0 As String)
			Me.Oo._o. = A_0
			Me.Oo._o. = New List(Of O___O_.O0O0)()
		End Sub

		' Token: 0x06004608 RID: 17928 RVA: 0x001C4F84 File Offset: 0x001C3184
		Friend Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim [property] As PropertyInfo = A_0.[GetType]().GetProperty(Me.Oo._o.)
			If [property] IsNot Nothing Then
				Me.Oo._o..Add(New O___O_.O0O0(RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue([property].GetValue(RuntimeHelpers.GetObjectValue(A_0), Nothing))))
			End If
		End Sub

		' Token: 0x06004609 RID: 17929 RVA: 0x001C4FD0 File Offset: 0x001C31D0
		Friend Overridable Sub <<EMPTY_NAME>>() Implements Foxtable.O_o_0o.O_OO0.O.
			Try
				For Each o0O As O___O_.O0O0 In Me.Oo._o.
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(o0O.o_oO.O000_oOo.())
					objectValue.[GetType]().GetProperty(Me.Oo._o.).SetValue(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(o0O.Value), Nothing)
					CType(objectValue, PropertyBase).Holder.Selected = True
				Next
			Finally
				Dim enumerator As List(Of O___O_.O0O0).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x0600460A RID: 17930 RVA: 0x001C5064 File Offset: 0x001C3264
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.Oo._o..Count
		End Function

		' Token: 0x04001C8D RID: 7309
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001C8E RID: 7310
		Private <<EMPTY_NAME>> As List(Of O___O_.O0O0)

		' Token: 0x02000425 RID: 1061
		Private Class O0O0
			' Token: 0x0600460B RID: 17931 RVA: 0x001C5071 File Offset: 0x001C3271
			Friend Sub New(A_0 As Object, A_1 As Object)
				Me.Oo._o. = RuntimeHelpers.GetObjectValue(A_0)
				Me.o_oO.O000_oOo. = RuntimeHelpers.GetObjectValue(A_1)
			End Sub

			' Token: 0x0600460C RID: 17932 RVA: 0x001C5091 File Offset: 0x001C3291
			Friend Function <<EMPTY_NAME>>() As Object
				Return Me.Oo._o.
			End Function

			' Token: 0x17001040 RID: 4160
			' (get) Token: 0x0600460D RID: 17933 RVA: 0x001C5099 File Offset: 0x001C3299
			Friend ReadOnly Property Value As Object
				Get
					Return Me.o_oO.O000_oOo.
				End Get
			End Property

			' Token: 0x04001C8F RID: 7311
			Private <<EMPTY_NAME>> As Object

			' Token: 0x04001C90 RID: 7312
			Private <<EMPTY_NAME>> As Object
		End Class
	End Class
End Namespace
