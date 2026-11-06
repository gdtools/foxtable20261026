Imports System

Namespace Foxtable
	' Token: 0x020000E7 RID: 231
	Public Class cssClassList
		' Token: 0x06000CC9 RID: 3273 RVA: 0x0005CAD7 File Offset: 0x0005ACD7
		Public Sub New(A_0 As HElement)
			Me.o__.OOO_0Oo. = A_0
		End Sub

		' Token: 0x06000CCA RID: 3274 RVA: 0x0005CAE8 File Offset: 0x0005ACE8
		Public Sub add(ParamArray classNames As String())
			Dim text As String = ""
			For Each arg As String In classNames
				text += String.Format("'{0}',", arg)
			Next
			text = text.Trim(New Char() { ","c })
			Dim text2 As String
			If Me.o__.OOO_0Oo..o___0o.00o0oO. Then
				text2 = String.Format("var elements = {0};", Me.o__.OOO_0Oo..o___0o.00o0oO.)
				text2 += vbCrLf & "for (var el of elements) {"
				text2 = text2 + vbCrLf + String.Format("el.classList.add({0});", text)
				text2 += vbCrLf & "}"
			Else
				text2 = String.Format("{0}.classList.add({1})", Me.o__.OOO_0Oo..o___0o.00o0oO., text)
			End If
			Me.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text2)
		End Sub

		' Token: 0x06000CCB RID: 3275 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		Public Sub remove(ParamArray classNames As String())
			Dim text As String = ""
			For Each arg As String In classNames
				text += String.Format("'{0}',", arg)
			Next
			text = text.Trim(New Char() { ","c })
			Dim text2 As String
			If Me.o__.OOO_0Oo..o___0o.00o0oO. Then
				text2 = String.Format("var elements = {0};", Me.o__.OOO_0Oo..o___0o.00o0oO.)
				text2 += vbCrLf & "for (var el of elements) {"
				text2 = text2 + vbCrLf + String.Format("el.classList.remove({0});", text)
				text2 += vbCrLf & "}"
			Else
				text2 = String.Format("{0}.classList.remove({1})", Me.o__.OOO_0Oo..o___0o.00o0oO., text)
			End If
			Me.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text2)
		End Sub

		' Token: 0x06000CCC RID: 3276 RVA: 0x0005CC80 File Offset: 0x0005AE80
		Public Function contains(className As String) As Object
			Dim text As String
			If Me.o__.OOO_0Oo..o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o__.OOO_0Oo..o___0o.00o0oO.)
				text += vbCrLf & "for (var el of elements) {"
				text = text + vbCrLf + String.Format("return el.classList.contains('{0}');", className)
				text += vbCrLf & "}"
			Else
				text = String.Format("{0}.classList.contains('{1}')", Me.o__.OOO_0Oo..o___0o.00o0oO., className)
			End If
			Return Me.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CCD RID: 3277 RVA: 0x0005CD0C File Offset: 0x0005AF0C
		Public Function toggle(className As String) As Object
			Dim text As String
			If Me.o__.OOO_0Oo..o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o__.OOO_0Oo..o___0o.00o0oO.)
				text += vbCrLf & "for (var el of elements) {"
				text = text + vbCrLf + String.Format("el.classList.toggle('{0}');", className)
				text += vbCrLf & "}"
			Else
				text = String.Format("{0}.classList.toggle('{1}')", Me.o__.OOO_0Oo..o___0o.00o0oO., className)
			End If
			Return Me.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x1700021D RID: 541
		' (get) Token: 0x06000CCE RID: 3278 RVA: 0x0005CD98 File Offset: 0x0005AF98
		Public ReadOnly Property length As Object
			Get
				Dim text As String
				If Me.o__.OOO_0Oo..o___0o.00o0oO. Then
					text = String.Format("var elements = {0};", Me.o__.OOO_0Oo..o___0o.00o0oO.)
					text += vbCrLf & "for (var el of elements) {"
					text += vbCrLf & "return el.classList.length;"
					text += vbCrLf & "}"
				Else
					text = String.Format("{0}.classList.length)", Me.o__.OOO_0Oo..o___0o.00o0oO.)
				End If
				Return Me.o__.OOO_0Oo..o___0o.00o0oO..ExecuteScriptAsync(text)
			End Get
		End Property

		' Token: 0x040004E8 RID: 1256
		Friend <<EMPTY_NAME>> As HElement
	End Class
End Namespace
