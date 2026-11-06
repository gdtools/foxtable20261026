Imports System
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001D7 RID: 471
	Friend Class OoOo0O
		' Token: 0x060016E5 RID: 5861 RVA: 0x00093BE0 File Offset: 0x00091DE0
		Shared Sub New()
			Dim array As Char() = "modnaR.metsyS".ToCharArray()
			Array.Reverse(array)
			OoOo0O.OO_o.0o_O. = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.[GetType](New String(array))))
		End Sub

		' Token: 0x060016E6 RID: 5862 RVA: 0x00093C18 File Offset: 0x00091E18
		Friend Shared Function <<EMPTY_NAME>>() As Integer
			Return Conversions.ToInteger(NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., Nothing, "Next", New Object(-1) {}, Nothing, Nothing, Nothing))
		End Function

		' Token: 0x060016E7 RID: 5863 RVA: 0x00093C38 File Offset: 0x00091E38
		Friend Shared Function <<EMPTY_NAME>>(A_0 As Integer, A_1 As Integer) As Integer
			Dim oo_o.0o_O. As Object = OoOo0O.OO_o.0o_O.
			Dim type As Type = Nothing
			Dim memberName As String = "Next"
			Dim array As Object() = New Object() { A_0, A_1 }
			Dim array2 As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array3 As Boolean() = New Boolean() { True, True }
			Dim array4 As Boolean() = array3
			Dim value As Object = NewLateBinding.LateGet(oo_o.0o_O., type, memberName, array, argumentNames, typeArguments, array3)
			If array4(0) Then
				A_0 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
			End If
			If array4(1) Then
				A_1 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(Integer)))
			End If
			Return Conversions.ToInteger(value)
		End Function

		' Token: 0x060016E8 RID: 5864 RVA: 0x00093CCC File Offset: 0x00091ECC
		Friend Shared Function <<EMPTY_NAME>>(A_0 As Integer) As Integer
			Dim oo_o.0o_O. As Object = OoOo0O.OO_o.0o_O.
			Dim type As Type = Nothing
			Dim memberName As String = "Next"
			Dim array As Object() = New Object() { A_0 }
			Dim array2 As Object() = array
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array3 As Boolean() = New Boolean() { True }
			Dim array4 As Boolean() = array3
			Dim value As Object = NewLateBinding.LateGet(oo_o.0o_O., type, memberName, array, argumentNames, typeArguments, array3)
			If array4(0) Then
				A_0 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
			End If
			Return Conversions.ToInteger(value)
		End Function

		' Token: 0x060016E9 RID: 5865 RVA: 0x00093D30 File Offset: 0x00091F30
		Friend Shared Function <<EMPTY_NAME>>() As Double
			Return Conversions.ToDouble(NewLateBinding.LateGet(OoOo0O.OO_o.0o_O., Nothing, "NextDouble", New Object(-1) {}, Nothing, Nothing, Nothing))
		End Function

		' Token: 0x060016EA RID: 5866 RVA: 0x00093D50 File Offset: 0x00091F50
		Friend Shared Function <<EMPTY_NAME>>(A_0 As Integer) As String
			If A_0 > 32 Then
				A_0 = 32
			End If
			If A_0 < 1 Then
				A_0 = 1
			End If
			Return Guid.NewGuid().ToString().Replace("-", "").Substring(0, A_0)
		End Function

		' Token: 0x0400091D RID: 2333
		Private Shared <<EMPTY_NAME>> As Object
	End Class
End Namespace
