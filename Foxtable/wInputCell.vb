Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200021A RID: 538
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0051")>
	Public Class wInputCell
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x0600190F RID: 6415 RVA: 0x000A2D04 File Offset: 0x000A0F04
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Integer)
			MyBase.New(A_0, A_1)
			Me.OoOO0._00O0__o. = New List(Of wElement)(2) {}
			Me.OoOO0._00O0__o. = 1
			Me.OO_.oO_OO0. = A_2
			Me.OoOO0._00O0__o.(0) = New List(Of wElement)()
			Me.OoOO0._00O0__o.(1) = New List(Of wElement)()
			Me.OoOO0._00O0__o.(2) = New List(Of wElement)()
			If Me.OO_.oO_OO0. = 2 Then
				Me.AddImage(A_1 + "_wicon", "weui_icon_warn", 2)
			End If
		End Sub

		' Token: 0x06001910 RID: 6416 RVA: 0x000A2D7C File Offset: 0x000A0F7C
		Public Function AddInput(id As String, type As String, position As Integer) As wInput
			Dim result As wInput
			If position >= 0 AndAlso position <= 2 Then
				Dim wInput As wInput = New wInput(MyBase.ID, id, "", type)
				Me.OoOO0._00O0__o.(position).Add(wInput)
				result = wInput
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001911 RID: 6417 RVA: 0x000A2DBC File Offset: 0x000A0FBC
		Public Function AddSelect(id As String, options As String, position As Integer) As wSelect
			Dim result As wSelect
			If position >= 0 AndAlso position <= 2 Then
				Dim wSelect As wSelect = New wSelect(MyBase.ID, id, "", options)
				Me.OoOO0._00O0__o.(position).Add(wSelect)
				Me.OoOO0._00O0__o. = True
				If position = 0 Then
					Me.OO_.oO_OO0. = True
				End If
				result = wSelect
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001912 RID: 6418 RVA: 0x000A2E0C File Offset: 0x000A100C
		Public Function AddLabel(id As String, text As String, position As Integer) As wLabel
			Dim result As wLabel
			If position >= 0 AndAlso position <= 2 Then
				Dim wLabel As wLabel = New wLabel(MyBase.ID, id, text)
				Me.OoOO0._00O0__o.(position).Add(wLabel)
				result = wLabel
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001913 RID: 6419 RVA: 0x000A2E44 File Offset: 0x000A1044
		Public Function AddImage(id As String, image As String, position As Integer) As wImage
			Dim result As wImage
			If position >= 0 AndAlso position <= 2 Then
				Dim wImage As wImage = New wImage(MyBase.ID, id, image)
				Me.OoOO0._00O0__o.(position).Add(wImage)
				result = wImage
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001914 RID: 6420 RVA: 0x000A2E7C File Offset: 0x000A107C
		Public Function AddVcodeButton(id As String, text As String, position As Integer) As wVcodeButton
			Dim result As wVcodeButton
			If position >= 0 AndAlso position <= 2 Then
				Dim wVcodeButton As wVcodeButton = New wVcodeButton(MyBase.ID, id, text)
				Me.OoOO0._00O0__o.(position).Add(wVcodeButton)
				result = wVcodeButton
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06001915 RID: 6421 RVA: 0x000A2EB4 File Offset: 0x000A10B4
		Private Function <<EMPTY_NAME>>() As String
			Dim text As String = "weui_cell"
			If Me.OoOO0._00O0__o. Then
				text += " weui_cell_select"
			End If
			If Me.OO_.oO_OO0. Then
				text += " weui_select_before"
			Else
				text += " weui_select_after"
			End If
			Dim num As Integer = 0
			Dim flag As Boolean
			Do
				Try
					For Each wElement As wElement In Me.OoOO0._00O0__o.(num)
						If TypeOf wElement Is wImage AndAlso Not CType(wElement, wImage).Image.StartsWith("weui_icon") Then
							flag = True
						End If
						If TypeOf wElement Is wVcodeButton Then
							flag = True
						End If
					Next
				Finally
					Dim enumerator As List(Of wElement).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				num += 1
			Loop While num <= 2
			If Me.OO_.oO_OO0. = 1 OrElse Me.OO_.oO_OO0. = 2 Then
				text += " weui_cell_warn"
			End If
			If flag Then
				text += " weui_vcode"
			End If
			Return text
		End Function

		' Token: 0x06001916 RID: 6422 RVA: 0x000A2FA8 File Offset: 0x000A11A8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BuildHtml(sb As StringBuilder, wui As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			sb.Append("<div class='" + Me.OoOO0._00O0__o.())
			If Operators.CompareString(MyBase.[Class], "", True) > 0 Then
				sb.Append(" " + MyBase.[Class])
			End If
			sb.Append("'")
			sb.Append(String.Concat(New String() { " id='", MyBase.ID, "' name='", MyBase.ID, "'" }))
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				sb.Append(" " + MyBase.Attribute)
			End If
			sb.AppendLine(">")
			Dim array As String() = New String() { "weui_cell_hd", "weui_cell_bd", "weui_cell_ft" }
			Dim num As Integer = 0
			Do
				If Me.OoOO0._00O0__o.(num).Count > 0 Then
					sb.Append("<div class='" + array(num))
					If Me.OoOO0._00O0__o. = num Then
						sb.AppendLine(" weui_cell_primary'>")
					Else
						sb.AppendLine("'>")
					End If
					Try
						For Each wElement As wElement In Me.OoOO0._00O0__o.(num)
							If TypeOf wElement Is wInput Then
								CType(wElement, wInput).O_ooo.0.(sb, wui)
							ElseIf TypeOf wElement Is wSelect Then
								CType(wElement, wSelect).OOOO0._0O.(sb, wui)
							Else
								CType(wElement, o_oOOOoo_O_O).OOO.__O_oO_.(sb, wui)
							End If
						Next
					Finally
						Dim enumerator As List(Of wElement).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					sb.AppendLine("</div>")
				End If
				num += 1
			Loop While num <= 2
			sb.AppendLine("</div>")
		End Sub

		' Token: 0x04000A8B RID: 2699
		Private <<EMPTY_NAME>> As List(Of wElement)()

		' Token: 0x04000A8C RID: 2700
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000A8D RID: 2701
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A8E RID: 2702
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000A8F RID: 2703
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
