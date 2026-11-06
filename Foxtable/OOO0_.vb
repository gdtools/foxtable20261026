Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200019A RID: 410
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class OOO0_
		Inherits WebBrowser

		' Token: 0x0600137F RID: 4991 RVA: 0x0007ECA6 File Offset: 0x0007CEA6
		Public Sub New()
			AddHandler MyBase.DocumentCompleted, AddressOf Me.Ooo__.ooO_0.
		End Sub

		' Token: 0x06001380 RID: 4992 RVA: 0x0007ECC0 File Offset: 0x0007CEC0
		Private Sub <<EMPTY_NAME>>()
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MyBase.ActiveXInstance)
			Dim value As Object = Missing.Value
			Dim args As Object() = New Object() { 24, 2, RuntimeHelpers.GetObjectValue(value), RuntimeHelpers.GetObjectValue(value) }
			objectValue.[GetType]().InvokeMember("ExecWB", BindingFlags.InvokeMethod, Nothing, RuntimeHelpers.GetObjectValue(objectValue), args)
			Me.OOoo.OOo0000_. = Not Me.OOoo.OOo0000_.
		End Sub

		' Token: 0x06001381 RID: 4993 RVA: 0x0007ED38 File Offset: 0x0007CF38
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.OOOo_._oO0_O.
		End Function

		' Token: 0x06001382 RID: 4994 RVA: 0x0007ED40 File Offset: 0x0007CF40
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.OOOo_._oO0_O. = A_0
			If Me.O_000o_O0.00o.() AndAlso (Me.OOOo_._oO0_O. Xor Me.OOoo.OOo0000_.) Then
				Me.OOOo_._oO0_O.()
			End If
		End Sub

		' Token: 0x06001383 RID: 4995 RVA: 0x0007ED68 File Offset: 0x0007CF68
		Public Sub <<EMPTY_NAME>>()
			If Me.O_000o_O0.00o.() Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MyBase.ActiveXInstance)
				Dim value As Object = Missing.Value
				Dim args As Object() = New Object() { 3, 2, RuntimeHelpers.GetObjectValue(value), RuntimeHelpers.GetObjectValue(value) }
				objectValue.[GetType]().InvokeMember("ExecWB", BindingFlags.InvokeMethod, Nothing, RuntimeHelpers.GetObjectValue(objectValue), args)
			End If
		End Sub

		' Token: 0x06001384 RID: 4996 RVA: 0x0007EDD8 File Offset: 0x0007CFD8
		Public Sub <<EMPTY_NAME>>()
			If Me.O_000o_O0.00o.() Then
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(MyBase.ActiveXInstance)
				Dim value As Object = Missing.Value
				Dim args As Object() = New Object() { 6, 6, RuntimeHelpers.GetObjectValue(value), RuntimeHelpers.GetObjectValue(value) }
				objectValue.[GetType]().InvokeMember("ExecWB", BindingFlags.InvokeMethod, Nothing, RuntimeHelpers.GetObjectValue(objectValue), args)
			End If
		End Sub

		' Token: 0x06001385 RID: 4997 RVA: 0x0007EE48 File Offset: 0x0007D048
		Friend Function <<EMPTY_NAME>>() As Workbook
			If Me.O_000o_O0.00o.() Then
				Dim text As String = MyBase.DocumentTitle.ToLower()
				If text.EndsWith(".xls") OrElse text.EndsWith(".xlsx") Then
					Return CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(MyBase.ActiveXInstance), Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Workbook)
				End If
				If text.EndsWith(".doc") OrElse text.EndsWith(".docx") Then
					Return CType(CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(MyBase.ActiveXInstance), Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Document), Workbook)
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x06001386 RID: 4998 RVA: 0x0007EEF6 File Offset: 0x0007D0F6
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As WebBrowserDocumentCompletedEventArgs)
			If Me.O_000o_O0.00o.() AndAlso (Me.OOOo_._oO0_O. Xor Me.OOoo.OOo0000_.) Then
				Me.OOOo_._oO0_O.()
			End If
		End Sub

		' Token: 0x06001387 RID: 4999 RVA: 0x0007EF18 File Offset: 0x0007D118
		Friend Function <<EMPTY_NAME>>() As Boolean
			If Operators.CompareString(MyBase.DocumentTitle, "", True) > 0 Then
				Dim text As String = MyBase.DocumentTitle.ToLower()
				If text.EndsWith(".xls") OrElse text.EndsWith(".xlsx") OrElse text.EndsWith(".doc") OrElse text.EndsWith(".docx") Then
					Return True
				End If
			End If
			Return False
		End Function

		' Token: 0x040007AF RID: 1967
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040007B0 RID: 1968
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
