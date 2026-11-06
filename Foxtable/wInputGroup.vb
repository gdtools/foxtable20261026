Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000210 RID: 528
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0045")>
	Public Class wInputGroup
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x060018D8 RID: 6360 RVA: 0x000A151D File Offset: 0x0009F71D
		Public Sub New(A_0 As String, A_1 As String)
			MyBase.New(A_0, A_1)
			Me.OoOO0._00O0__o. = New List(Of wElement)()
		End Sub

		' Token: 0x060018D9 RID: 6361 RVA: 0x000A1532 File Offset: 0x0009F732
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			MyBase.New(A_0, A_1)
			Me.OoOO0._00O0__o. = New List(Of wElement)()
			Me.O.__00oOO_o0O0. = A_2
		End Sub

		' Token: 0x1700057F RID: 1407
		' (get) Token: 0x060018DA RID: 6362 RVA: 0x000A154E File Offset: 0x0009F74E
		Private ReadOnly Property BaseClass As String
			Get
				Return "weui_cells weui_cells_form"
			End Get
		End Property

		' Token: 0x060018DB RID: 6363 RVA: 0x000A1558 File Offset: 0x0009F758
		<oO0oooo("A0045")>
		Public Function AddInput(id As String, label As String, type As String) As wInput
			Dim wInput As wInput = New wInput(MyBase.ID, id, label, type)
			Me.OoOO0._00O0__o..Add(wInput)
			Return wInput
		End Function

		' Token: 0x060018DC RID: 6364 RVA: 0x000A1584 File Offset: 0x0009F784
		<oO0oooo("A0048")>
		Public Function AddSelect(id As String, label As String, options As String) As wSelect
			Dim wSelect As wSelect = New wSelect(MyBase.ID, id, label, options)
			Me.OoOO0._00O0__o..Add(wSelect)
			Return wSelect
		End Function

		' Token: 0x060018DD RID: 6365 RVA: 0x000A15B0 File Offset: 0x0009F7B0
		<oO0oooo("A0049")>
		Public Function AddSwitch(id As String, label As String, Optional checked As Boolean = False) As wSwitch
			Dim wSwitch As wSwitch = New wSwitch(MyBase.ID, id, label, checked)
			Me.OoOO0._00O0__o..Add(wSwitch)
			Return wSwitch
		End Function

		' Token: 0x060018DE RID: 6366 RVA: 0x000A15DC File Offset: 0x0009F7DC
		<oO0oooo("A0050")>
		Public Function AddTextArea(id As String, Optional rows As Integer = 3) As wTextArea
			Dim wTextArea As wTextArea = New wTextArea(MyBase.ID, id, rows)
			Me.OoOO0._00O0__o..Add(wTextArea)
			Return wTextArea
		End Function

		' Token: 0x060018DF RID: 6367 RVA: 0x000A1604 File Offset: 0x0009F804
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function AddDataList(id As String, Options As String) As wDataList
			Dim wDataList As wDataList = New wDataList(MyBase.ID, id, Options)
			Me.OoOO0._00O0__o..Add(wDataList)
			Return wDataList
		End Function

		' Token: 0x060018E0 RID: 6368 RVA: 0x000A162C File Offset: 0x0009F82C
		<oO0oooo("A0054")>
		Public Function AddUploader(id As String, text As String, Optional multiple As Boolean = False) As wUploader
			Dim wUploader As wUploader = New wUploader(MyBase.ID, id, text, multiple, "")
			Me.OoOO0._00O0__o..Add(wUploader)
			Return wUploader
		End Function

		' Token: 0x060018E1 RID: 6369 RVA: 0x000A165C File Offset: 0x0009F85C
		<oO0oooo("A0051")>
		Public Function AddInputCell(ID As String, Optional Warn As Integer = 0) As wInputCell
			Dim wInputCell As wInputCell = New wInputCell(MyBase.ID, ID, Warn)
			Me.OoOO0._00O0__o..Add(wInputCell)
			Return wInputCell
		End Function

		' Token: 0x060018E2 RID: 6370 RVA: 0x000A1684 File Offset: 0x0009F884
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddHidenValue(id As String, Value As String)
			Me.AddHiddenValue(id, Value)
		End Sub

		' Token: 0x060018E3 RID: 6371 RVA: 0x000A1690 File Offset: 0x0009F890
		<oO0oooo("A0127")>
		Public Sub AddHiddenValue(id As String, value As String)
			Dim a_ As String = String.Concat(New String() { "<input name='", id, "' id='", id, "' value='", value, "' hidden>" })
			Dim item As wRawHtml = New wRawHtml(MyBase.ID, id, a_)
			Me.OoOO0._00O0__o..Add(item)
		End Sub

		' Token: 0x060018E4 RID: 6372 RVA: 0x000A16F0 File Offset: 0x0009F8F0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			If Operators.CompareString(Me.O.__00oOO_o0O0., "", True) > 0 Then
				A_0.AppendLine("<div class='fox_group'>")
				New wGroupTitle(MyBase.ID, "", Me.O.__00oOO_o0O0.).OooO_o0o0O.0_.(A_0, A_1)
			End If
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<div class='" + Me.BaseClass + "'"
			Else
				text = String.Concat(New String() { "<div class='", Me.BaseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " id='", MyBase.ID, "' name='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text += ">"
			A_0.AppendLine(text)
			Try
				For Each wElement As wElement In Me.OoOO0._00O0__o.
					If Operators.CompareString(wElement.PID, MyBase.ID, True) = 0 Then
						CType(wElement, o_oOOOoo_O_O).OOO.__O_oO_.(A_0, A_1)
					End If
				Next
			Finally
				Dim enumerator As List(Of wElement).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</div>")
			If Operators.CompareString(Me.O.__00oOO_o0O0., "", True) > 0 Then
				A_0.AppendLine("</div>")
			End If
		End Sub

		' Token: 0x04000A6D RID: 2669
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000A6E RID: 2670
		Private <<EMPTY_NAME>> As List(Of wElement)
	End Class
End Namespace
