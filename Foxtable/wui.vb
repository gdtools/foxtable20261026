Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000229 RID: 553
	<oO0oooo("A0146")>
	Public Class wui
		' Token: 0x060019A8 RID: 6568 RVA: 0x000A5D88 File Offset: 0x000A3F88
		Public Sub New()
			Me.O.oO_oO. = "utf-8"
			Me.o0_._00. = New Dictionary(Of String, wElement)()
			Me.O.oO_oO. = New Dictionary(Of String, wElement)()
			Me.O.0_00o0_o. = "/weui"
			Me.o0_._00. = New List(Of String)()
			Me.O.oO_oO. = New List(Of String)()
			Me.O.0_00o0_o. = New List(Of String)()
			Me.o0.0O_o0_oOoo. = New List(Of String)()
		End Sub

		' Token: 0x170005BC RID: 1468
		' (get) Token: 0x060019A9 RID: 6569 RVA: 0x000A5DF3 File Offset: 0x000A3FF3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Scripts As List(Of String)
			Get
				Return Me.O.0_00o0_o.
			End Get
		End Property

		' Token: 0x170005BD RID: 1469
		' (get) Token: 0x060019AA RID: 6570 RVA: 0x000A5DFB File Offset: 0x000A3FFB
		' (set) Token: 0x060019AB RID: 6571 RVA: 0x000A5E03 File Offset: 0x000A4003
		Public Property Title As String
			Get
				Return Me.o0_._00.
			End Get
			Set(value As String)
				Me.o0_._00. = value
			End Set
		End Property

		' Token: 0x170005BE RID: 1470
		' (get) Token: 0x060019AC RID: 6572 RVA: 0x000A5E0C File Offset: 0x000A400C
		' (set) Token: 0x060019AD RID: 6573 RVA: 0x000A5E14 File Offset: 0x000A4014
		Public Property WeUIPath As String
			Get
				Return Me.O.0_00o0_o.
			End Get
			Set(value As String)
				Me.O.0_00o0_o. = value
			End Set
		End Property

		' Token: 0x170005BF RID: 1471
		' (get) Token: 0x060019AE RID: 6574 RVA: 0x000A5E1D File Offset: 0x000A401D
		' (set) Token: 0x060019AF RID: 6575 RVA: 0x000A5E25 File Offset: 0x000A4025
		Public Property Charset As String
			Get
				Return Me.O.oO_oO.
			End Get
			Set(value As String)
				Me.O.oO_oO. = value
			End Set
		End Property

		' Token: 0x060019B0 RID: 6576 RVA: 0x000A5E30 File Offset: 0x000A4030
		<oO0oooo("A007")>
		Public Function AddForm(pid As String, id As String, Action As String) As wForm
			If Operators.CompareString(pid, "", True) > 0 Then
				pid = pid.ToLower().Trim()
			End If
			id = id.ToLower().Trim()
			Dim wForm As wForm = New wForm(pid, id, Action)
			Me.o0_._00..Add(id, wForm)
			Return wForm
		End Function

		' Token: 0x060019B1 RID: 6577 RVA: 0x000A5E80 File Offset: 0x000A4080
		<oO0oooo("A007")>
		Public Function AddForm(ParentID As String, id As String, Action As String, Method As String) As wForm
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			id = id.ToLower().Trim()
			Dim wForm As wForm = New wForm(ParentID, id, Action, Method)
			Me.o0_._00..Add(id, wForm)
			Return wForm
		End Function

		' Token: 0x060019B2 RID: 6578 RVA: 0x000A5ED0 File Offset: 0x000A40D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function AddSubTitle(pid As String, ID As String, Text As String) As wGroupTitle
			If Operators.CompareString(pid, "", True) > 0 Then
				pid = pid.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wGroupTitle As wGroupTitle = New wGroupTitle(pid, ID, Text)
			Me.o0_._00..Add(ID, wGroupTitle)
			Return wGroupTitle
		End Function

		' Token: 0x060019B3 RID: 6579 RVA: 0x000A5F20 File Offset: 0x000A4120
		<oO0oooo("A0052")>
		Public Function AddRadioGroup(ParentID As String, ID As String, Optional Text As String = "") As wRadioGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wRadioGroup As wRadioGroup = New wRadioGroup(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wRadioGroup)
			Return wRadioGroup
		End Function

		' Token: 0x060019B4 RID: 6580 RVA: 0x000A5F70 File Offset: 0x000A4170
		<oO0oooo("A0053")>
		Public Function AddCheckGroup(ParentID As String, ID As String, Optional Text As String = "") As wCheckGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wCheckGroup As wCheckGroup = New wCheckGroup(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wCheckGroup)
			Return wCheckGroup
		End Function

		' Token: 0x060019B5 RID: 6581 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		<oO0oooo("A0045")>
		Public Function AddInputGroup(ParentID As String, ID As String, Optional Text As String = "") As wInputGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wInputGroup As wInputGroup = New wInputGroup(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wInputGroup)
			Return wInputGroup
		End Function

		' Token: 0x060019B6 RID: 6582 RVA: 0x000A6010 File Offset: 0x000A4210
		<oO0oooo("A0008")>
		Public Function AddButtonGroup(ParentID As String, ID As String, Optional Vertical As Boolean = False) As wButtonGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wButtonGroup As wButtonGroup = New wButtonGroup(ParentID, ID, Vertical)
			Me.o0_._00..Add(ID, wButtonGroup)
			Return wButtonGroup
		End Function

		' Token: 0x060019B7 RID: 6583 RVA: 0x000A6060 File Offset: 0x000A4260
		<oO0oooo("A0077")>
		Public Function AddGrid(ParentID As String, ID As String) As wGrid
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wGrid As wGrid = New wGrid(ParentID, ID)
			Me.o0_._00..Add(ID, wGrid)
			Return wGrid
		End Function

		' Token: 0x060019B8 RID: 6584 RVA: 0x000A60AC File Offset: 0x000A42AC
		<oO0oooo("A0075")>
		Public Function AddPageTitle(ParentID As String, ID As String, Title As String, Optional SubTitle As String = "") As wPageTitle
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wPageTitle As wPageTitle = New wPageTitle(ParentID, ID, Title, SubTitle)
			Me.o0_._00..Add(ID, wPageTitle)
			Return wPageTitle
		End Function

		' Token: 0x060019B9 RID: 6585 RVA: 0x000A60FC File Offset: 0x000A42FC
		<oO0oooo("A0086")>
		Public Function AddPageFooter(ParentID As String, ID As String, FootText As String, Optional Position As Integer = 1) As wPageFooter
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wPageFooter As wPageFooter = New wPageFooter(ParentID, ID, FootText, Position)
			Me.o0_._00..Add(ID, wPageFooter)
			Return wPageFooter
		End Function

		' Token: 0x060019BA RID: 6586 RVA: 0x000A614C File Offset: 0x000A434C
		<oO0oooo("A0076")>
		Public Function AddListGroup(ParentID As String, ID As String, Text As String) As wListGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wListGroup As wListGroup = New wListGroup(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wListGroup)
			Return wListGroup
		End Function

		' Token: 0x060019BB RID: 6587 RVA: 0x000A619C File Offset: 0x000A439C
		<oO0oooo("A0078")>
		Public Function AddPanelGroup(ParentID As String, ID As String, Text As String) As wPanelGroup
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wPanelGroup As wPanelGroup = New wPanelGroup(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wPanelGroup)
			Return wPanelGroup
		End Function

		' Token: 0x060019BC RID: 6588 RVA: 0x000A61EC File Offset: 0x000A43EC
		<oO0oooo("A0079")>
		Public Function AddArticle(ParentID As String, ID As String) As wArticle
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wArticle As wArticle = New wArticle(ParentID, ID, Me.o0_._00.)
			Me.o0_._00..Add(ID, wArticle)
			Return wArticle
		End Function

		' Token: 0x060019BD RID: 6589 RVA: 0x000A6240 File Offset: 0x000A4440
		<oO0oooo("A0058")>
		Public Function AddMsgPage(ParentID As String, ID As String, Title As String, Description As String) As wMsgPage
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wMsgPage As wMsgPage = New wMsgPage(ParentID, ID, Title, Description)
			Me.o0_._00..Add(ID, wMsgPage)
			Return wMsgPage
		End Function

		' Token: 0x060019BE RID: 6590 RVA: 0x000A6290 File Offset: 0x000A4490
		<oO0oooo("A0082")>
		Public Function AddToast(ParentID As String, ID As String, Text As String, Type As Integer) As wToast
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wToast As wToast = New wToast(ParentID, ID, Text, Type)
			Me.o0_._00..Add(ID, wToast)
			Return wToast
		End Function

		' Token: 0x060019BF RID: 6591 RVA: 0x000A62E0 File Offset: 0x000A44E0
		<oO0oooo("A0080")>
		Public Function AddDialog(ParentID As String, ID As String, title As String, content As String) As wDialog
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wDialog As wDialog = New wDialog(ParentID, ID, title, content)
			Me.o0_._00..Add(ID, wDialog)
			Return wDialog
		End Function

		' Token: 0x060019C0 RID: 6592 RVA: 0x000A6330 File Offset: 0x000A4530
		<oO0oooo("A0084")>
		Public Function AddActionSheet(ParentID As String, ID As String) As wActionSheet
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wActionSheet As wActionSheet = New wActionSheet(ParentID, ID)
			Me.o0_._00..Add(ID, wActionSheet)
			Return wActionSheet
		End Function

		' Token: 0x060019C1 RID: 6593 RVA: 0x000A637C File Offset: 0x000A457C
		<oO0oooo("A0109")>
		Public Function AddPage(ParentID As String, ID As String, Optional Visible As Boolean = True) As wPage
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wPage As wPage = New wPage(ParentID, ID, Visible)
			Me.o0_._00..Add(ID, wPage)
			Return wPage
		End Function

		' Token: 0x060019C2 RID: 6594 RVA: 0x000A63CC File Offset: 0x000A45CC
		<oO0oooo("A0081")>
		Public Function AddTabBar(ParentID As String, ID As String, Position As Integer) As wTabbar
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wTabbar As wTabbar = New wTabbar(ParentID, ID, Position)
			Me.o0_._00..Add(ID, wTabbar)
			Return wTabbar
		End Function

		' Token: 0x060019C3 RID: 6595 RVA: 0x000A641C File Offset: 0x000A461C
		<oO0oooo("A0083")>
		Public Function AddToptips(ParentID As String, ID As String, Text As String) As wToptips
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wToptips As wToptips = New wToptips(ParentID, ID, Text)
			Me.o0_._00..Add(ID, wToptips)
			Return wToptips
		End Function

		' Token: 0x060019C4 RID: 6596 RVA: 0x000A646C File Offset: 0x000A466C
		<oO0oooo("A0063")>
		Public Function AddTable(ParentID As String, ID As String) As wTable
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wTable As wTable = New wTable(ParentID, ID)
			Me.o0_._00..Add(ID, wTable)
			Return wTable
		End Function

		' Token: 0x060019C5 RID: 6597 RVA: 0x000A64B8 File Offset: 0x000A46B8
		<oO0oooo("A0085")>
		Public Function AddPreview(ParentID As String, ID As String, HeadText As String, HeadValue As String) As wPreview
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wPreview As wPreview = New wPreview(ParentID, ID, HeadText, HeadValue)
			Me.o0_._00..Add(ID, wPreview)
			Return wPreview
		End Function

		' Token: 0x060019C6 RID: 6598 RVA: 0x000A6508 File Offset: 0x000A4708
		<oO0oooo("A0087")>
		Public Function AddGallery(ParentID As String, ID As String, Optional Visible As Boolean = True, Optional AutoHide As Boolean = False) As wGallery
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wGallery As wGallery = New wGallery(ParentID, ID, Visible, AutoHide)
			Me.o0_._00..Add(ID, wGallery)
			Return wGallery
		End Function

		' Token: 0x060019C7 RID: 6599 RVA: 0x000A6558 File Offset: 0x000A4758
		<oO0oooo("A0098")>
		Public Function AddProgress(ParentID As String, ID As String, Optional Visible As Boolean = True, Optional Value As Integer = 0) As wProgress
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			ID = ID.ToLower().Trim()
			Dim wProgress As wProgress = New wProgress(ParentID, ID, Visible, Value)
			Me.o0_._00..Add(ID, wProgress)
			Return wProgress
		End Function

		' Token: 0x060019C8 RID: 6600 RVA: 0x000A65A8 File Offset: 0x000A47A8
		<oO0oooo("A0042")>
		Public Sub AppendCookie(name As String, value As String, Optional expires As Integer = -1)
			If Operators.CompareString(value, "", True) = 0 Then
				Me.DeleteCookie(name)
				Return
			End If
			value = OO_00oOO.o_.0_OoOo0_0.(value)
			If value.IndexOf("'") >= 0 Then
				value = value.Replace("'", "%27")
			End If
			name = OO_00oOO.o_.0_OoOo0_0.(name)
			Dim item As String
			If expires = -1 Then
				item = String.Concat(New String() { "document.cookie='", name, "=", value, ";path =/';" })
			Else
				Dim value2 As Long = CLng(expires) * 60L * 1000L
				item = String.Concat(New String() { "document.cookie='", name, "=", value, ";path=/;expires=' + new Date(Date.now() + ", Conversions.ToString(value2), ").toGMTString();" })
			End If
			Me.o0.0O_o0_oOoo..Add(item)
		End Sub

		' Token: 0x060019C9 RID: 6601 RVA: 0x000A668A File Offset: 0x000A488A
		<oO0oooo("A0042")>
		Public Sub DeleteCookie(Name As String)
			Name = OO_00oOO.o_.0_OoOo0_0.(Name)
			Me.o0.0O_o0_oOoo..Add("document.cookie='" + Name + "= ;path=/;expires=' + new Date().toGMTString();")
		End Sub

		' Token: 0x060019CA RID: 6602 RVA: 0x000A66AF File Offset: 0x000A48AF
		<oO0oooo("A0042")>
		Public Sub ClearCookie()
			Me.o0.0O_o0_oOoo..Add("clearCookie()")
		End Sub

		' Token: 0x060019CB RID: 6603 RVA: 0x000A66C1 File Offset: 0x000A48C1
		<oO0oooo("A0061")>
		Public Sub AppendHTML(HTML As String, Optional Head As Boolean = False)
			If Head Then
				Me.o0_._00..Add(HTML)
				Return
			End If
			Me.O.oO_oO..Add(HTML)
		End Sub

		' Token: 0x060019CC RID: 6604 RVA: 0x000A66E0 File Offset: 0x000A48E0
		<oO0oooo("A0097")>
		Public Sub InsertHTML(HTML As String)
			Dim text As String = OoOo0O.OO_o.0o_O.(6)
			While Me.o0_._00..ContainsKey(text)
				text = OoOo0O.OO_o.0o_O.(6)
			End While
			Dim value As wRawHtml = New wRawHtml("", text, HTML)
			Me.o0_._00..Add(text, value)
		End Sub

		' Token: 0x060019CD RID: 6605 RVA: 0x000A6728 File Offset: 0x000A4928
		<oO0oooo("A0097")>
		Public Sub InsertHTML(ParentID As String, HTML As String)
			If Operators.CompareString(ParentID, "", True) > 0 Then
				ParentID = ParentID.ToLower().Trim()
			End If
			Dim text As String = OoOo0O.OO_o.0o_O.(6)
			While Me.o0_._00..ContainsKey(text)
				text = OoOo0O.OO_o.0o_O.(6)
			End While
			Dim value As wRawHtml = New wRawHtml(ParentID, text, HTML)
			Me.o0_._00..Add(text, value)
		End Sub

		' Token: 0x060019CE RID: 6606 RVA: 0x000A6788 File Offset: 0x000A4988
		Public Function Build() As String
			Me.O.oO_oO..Clear()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			stringBuilder.AppendLine("<!DOCTYPE html>")
			stringBuilder.AppendLine("<html lang='zh-cmn-Hans'>")
			stringBuilder.AppendLine("<head>")
			stringBuilder.AppendLine("<meta charset='" + Me.Charset + "'>")
			stringBuilder.AppendLine("<meta name='viewport' content='width=device-width,initial-scale=1,user-scalable=0'>")
			stringBuilder.AppendLine("<link rel='stylesheet' href='" + Me.WeUIPath + "/weui.min.css'/>")
			stringBuilder.AppendLine("<link rel='stylesheet' href='" + Me.WeUIPath + "/weui.me.css'/>")
			stringBuilder.AppendLine("<link rel='icon' href='data: ;base64,='>")
			stringBuilder.AppendLine("<title>" + Me.o0_._00. + "</title>")
			stringBuilder.AppendLine("<script src='" + Me.WeUIPath + "/weui.me.js'></script>")
			If Me.o0.0O_o0_oOoo..Count > 0 Then
				stringBuilder.AppendLine("<script>")
				Try
					For Each value As String In Me.o0.0O_o0_oOoo.
						stringBuilder.AppendLine(value)
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				stringBuilder.AppendLine("</script>")
			End If
			Try
				For Each value2 As String In Me.o0_._00.
					stringBuilder.AppendLine(value2)
				Next
			Finally
				Dim enumerator2 As List(Of String).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			stringBuilder.AppendLine("</head>")
			stringBuilder.AppendLine("<body ontouchstart='' onload='onload()'>")
			Try
				For Each key As String In Me.o0_._00..Keys
					If Operators.CompareString(Me.o0_._00.(key).PID, "", True) = 0 Then
						CType(Me.o0_._00.(key), o_oOOOoo_O_O).OOO.__O_oO_.(stringBuilder, Me)
					End If
				Next
			Finally
				Dim enumerator3 As Dictionary(Of String, wElement).KeyCollection.Enumerator
				CType(enumerator3, IDisposable).Dispose()
			End Try
			Try
				For Each key2 As String In Me.O.oO_oO..Keys
					If Operators.CompareString(Me.O.oO_oO.(key2).PID, "", True) = 0 Then
						CType(Me.O.oO_oO.(key2), o_oOOOoo_O_O).OOO.__O_oO_.(stringBuilder, Me)
					End If
				Next
			Finally
				Dim enumerator4 As Dictionary(Of String, wElement).KeyCollection.Enumerator
				CType(enumerator4, IDisposable).Dispose()
			End Try
			Try
				For Each value3 As String In Me.O.oO_oO.
					stringBuilder.AppendLine(value3)
				Next
			Finally
				Dim enumerator5 As List(Of String).Enumerator
				CType(enumerator5, IDisposable).Dispose()
			End Try
			If Me.O.0_00o0_o..Count > 0 Then
				stringBuilder.AppendLine("<script>")
				Try
					For Each value4 As String In Me.Scripts
						stringBuilder.AppendLine(value4)
					Next
				Finally
					Dim enumerator6 As List(Of String).Enumerator
					CType(enumerator6, IDisposable).Dispose()
				End Try
				stringBuilder.AppendLine("</script>")
			End If
			stringBuilder.AppendLine("</body>")
			stringBuilder.AppendLine("</html>")
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060019CF RID: 6607 RVA: 0x000A6B00 File Offset: 0x000A4D00
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildHtml(ele As o_oOOOoo_O_O) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			ele.OOO.__O_oO_.(stringBuilder, Me)
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060019D0 RID: 6608 RVA: 0x000A6B24 File Offset: 0x000A4D24
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function BuildHtml(ID As String) As String
			Try
				For Each text As String In Me.o0_._00..Keys
					If Operators.CompareString(text, ID, True) = 0 AndAlso TypeOf Me.o0_._00.(text)Is o_oOOOoo_O_O Then
						Return Me.BuildHtml(CType(Me.o0_._00.(text), o_oOOOoo_O_O))
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, wElement).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return ""
		End Function

		' Token: 0x060019D1 RID: 6609 RVA: 0x000A6BB4 File Offset: 0x000A4DB4
		Public Sub Save(FileName As String)
			Dim text As String = Me.Build()
			OO_00oOO.FileSys.WriteAllText(FileName, text, False, Encoding.GetEncoding(Me.Charset))
		End Sub

		' Token: 0x060019D2 RID: 6610 RVA: 0x000A6BE0 File Offset: 0x000A4DE0
		<oO0oooo("A0137")>
		Public Shared Function ImageToBase64(img As Image) As String
			Dim memoryStream As MemoryStream = New MemoryStream()
			img.Save(memoryStream, ImageFormat.Png)
			Return "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray())
		End Function

		' Token: 0x04000ACF RID: 2767
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AD0 RID: 2768
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AD1 RID: 2769
		Friend <<EMPTY_NAME>> As Dictionary(Of String, wElement)

		' Token: 0x04000AD2 RID: 2770
		Friend <<EMPTY_NAME>> As Dictionary(Of String, wElement)

		' Token: 0x04000AD3 RID: 2771
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000AD4 RID: 2772
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000AD5 RID: 2773
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000AD6 RID: 2774
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000AD7 RID: 2775
		Private <<EMPTY_NAME>> As List(Of String)
	End Class
End Namespace
