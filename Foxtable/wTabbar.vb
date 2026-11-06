Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200021E RID: 542
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0081")>
	Public Class wTabbar
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001936 RID: 6454 RVA: 0x000A383D File Offset: 0x000A1A3D
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Integer)
			MyBase.New(A_0, A_1)
			Me.o0O.00_o_0_o0. = New List(Of wTabButton)()
			Me.o0OO0.oo0OO. = New List(Of wPage)()
			Me.o0OO0.oo0OO. = A_2
		End Sub

		' Token: 0x06001937 RID: 6455 RVA: 0x000A3864 File Offset: 0x000A1A64
		Public Function AddPage(id As String, text As String, Optional image As String = "") As wPage
			Dim item As wTabButton = New wTabButton(MyBase.ID, id + "_btn", text, id, image, "")
			Me.o0O.00_o_0_o0..Add(item)
			Dim wPage As wPage = New wPage(MyBase.ID, id, Me.o0OO0.oo0OO..Count = 0)
			Me.o0OO0.oo0OO..Add(wPage)
			Return wPage
		End Function

		' Token: 0x06001938 RID: 6456 RVA: 0x000A38C4 File Offset: 0x000A1AC4
		Public Function AddButton(id As String, text As String, Optional image As String = "", Optional href As String = "") As wTabButton
			Dim wTabButton As wTabButton = New wTabButton(MyBase.ID, id, text, "", image, href)
			Me.o0O.00_o_0_o0..Add(wTabButton)
			Return wTabButton
		End Function

		' Token: 0x06001939 RID: 6457 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			A_0.Append(String.Concat(New String() { "<div  id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			A_0.Append(" class='weui_tab")
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				A_0.Append(" " + MyBase.[Class])
			End If
			A_0.Append("'")
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				A_0.Append(" " + MyBase.Attribute)
			End If
			A_0.Append(">")
			If Me.o0OO0.oo0OO. = 0 Then
				A_0.AppendLine("<div class='weui_tab_bd' id='" + MyBase.ID + "_pages'>")
				Try
					For Each wPage As wPage In Me.o0OO0.oo0OO.
						wPage.o__o.OOoO_.(A_0, A_1)
					Next
				Finally
					Dim enumerator As List(Of wPage).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</div>")
				A_0.AppendLine(" <div class='weui_tabbar'>")
			Else
				A_0.AppendLine("<div class='weui_navbar'>")
			End If
			Dim flag As Boolean = True
			Try
				For Each wTabButton As wTabButton In Me.o0O.00_o_0_o0.
					If flag Then
						wTabButton.o0OO0.oo0OO. = True
						flag = False
					End If
					wTabButton.o0OO0.oo0OO.(A_0, A_1)
				Next
			Finally
				Dim enumerator2 As List(Of wTabButton).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			If Me.o0OO0.oo0OO. = 1 Then
				A_0.AppendLine("<div class='weui_tab_bd' id='" + MyBase.ID + "_pages'>")
				Try
					For Each wPage2 As wPage In Me.o0OO0.oo0OO.
						wPage2.o__o.OOoO_.(A_0, A_1)
					Next
				Finally
					Dim enumerator3 As List(Of wPage).Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				A_0.AppendLine("</div>")
			End If
			A_0.AppendLine("</div>")
		End Sub

		' Token: 0x04000A9C RID: 2716
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000A9D RID: 2717
		Private <<EMPTY_NAME>> As List(Of wTabButton)

		' Token: 0x04000A9E RID: 2718
		Private <<EMPTY_NAME>> As List(Of wPage)
	End Class
End Namespace
