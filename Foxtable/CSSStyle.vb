Imports System
Imports System.ComponentModel
Imports System.Dynamic
Imports System.Runtime.CompilerServices
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json

Namespace Foxtable
	' Token: 0x020000E8 RID: 232
	Public Class CSSStyle
		Inherits DynamicObject

		' Token: 0x1700021E RID: 542
		' (get) Token: 0x06000CCF RID: 3279 RVA: 0x0005CE15 File Offset: 0x0005B015
		' (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0005CE1D File Offset: 0x0005B01D
		Friend Property Element As HElement

		' Token: 0x06000CD1 RID: 3281 RVA: 0x0005CE26 File Offset: 0x0005B026
		Public Sub New(A_0 As HElement)
			Me.Element = A_0
		End Sub

		' Token: 0x06000CD2 RID: 3282 RVA: 0x0005CE38 File Offset: 0x0005B038
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overrides Function TryGetMember(binder As GetMemberBinder, ByRef result As Object) As Boolean
			Dim o___0o.00o0oO. As WebViewer = Me.Element.o___0o.00o0oO.
			Dim text As String
			If Me.Element.o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.Element.o___0o.00o0oO.)
				text = text + vbCrLf + String.Format(" elements[0]?.style.{0};", binder.Name)
			Else
				text = String.Format("{0}.style.{1}", Me.Element.o___0o.00o0oO., binder.Name)
			End If
			result = o___0o.00o0oO..ExecuteScriptAsync(text)
			Return True
		End Function

		' Token: 0x06000CD3 RID: 3283 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overrides Function TrySetMember(binder As SetMemberBinder, value As Object) As Boolean
			Dim o___0o.00o0oO. As WebView2 = Me.Element.o___0o.00o0oO.
			Dim text As String
			If value Is Nothing Then
				text = "null"
			ElseIf TypeOf value Is String Then
				text = JsonConvert.ToString(value.ToString())
			ElseIf TypeOf value Is Boolean Then
				text = value.ToString().ToLower()
			Else
				text = value.ToString()
			End If
			Dim text2 As String
			If Me.Element.o___0o.00o0oO. Then
				text2 = String.Format("var elements = {0};", Me.Element.o___0o.00o0oO.)
				text2 += vbCrLf & "for (var el of elements) {"
				text2 = text2 + vbCrLf + String.Format("el.style.{0} = {1};", binder.Name, text)
				text2 += vbCrLf & "}"
			Else
				text2 = String.Format("{0}.style.{1} = {2}", Me.Element.o___0o.00o0oO., binder.Name, text)
			End If
			o___0o.00o0oO..ExecuteScriptAsync(text2)
			Return True
		End Function

		' Token: 0x040004E9 RID: 1257
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As HElement
	End Class
End Namespace
