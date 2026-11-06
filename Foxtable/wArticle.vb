Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000202 RID: 514
	<oO0oooo("A0079")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class wArticle
		Inherits wElement
		Implements o_oOOOoo_O_O

		' Token: 0x06001861 RID: 6241 RVA: 0x0009F42C File Offset: 0x0009D62C
		Friend Sub New(A_0 As String, A_1 As String, A_2 As Dictionary(Of String, wElement))
			MyBase.New(A_0, A_1)
			Me.oO.0oO0. = A_2
		End Sub

		' Token: 0x06001862 RID: 6242 RVA: 0x0009F440 File Offset: 0x0009D640
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub BeginSection()
			Dim text As String = OoOo0O.OO_o.0o_O.(6)
			While Me.oO.0oO0..ContainsKey(text)
				text = OoOo0O.OO_o.0o_O.(6)
			End While
			Dim value As wRawHtml = New wRawHtml(MyBase.ID, text, "<section>")
			Me.oO.0oO0..Add(text, value)
		End Sub

		' Token: 0x06001863 RID: 6243 RVA: 0x0009F48C File Offset: 0x0009D68C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub EndSection()
			Dim text As String = OoOo0O.OO_o.0o_O.(6)
			While Me.oO.0oO0..ContainsKey(text)
				text = OoOo0O.OO_o.0o_O.(6)
			End While
			Dim value As wRawHtml = New wRawHtml(MyBase.ID, text, "</section>")
			Me.oO.0oO0..Add(text, value)
		End Sub

		' Token: 0x06001864 RID: 6244 RVA: 0x0009F4D8 File Offset: 0x0009D6D8
		Public Sub AddTitle(level As String, Title As String, Optional Attribute As String = "")
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			Dim text As String = MyBase.ID + "_Title_" + Conversions.ToString(Me.OOOO.__O__Oo.)
			Me.OOOO.__O__Oo. += 1
			Dim value As wRawHtml = New wRawHtml(MyBase.ID, text, String.Concat(New String() { "<", level, Attribute, ">", Title, "</", level, ">" }))
			Me.oO.0oO0..Add(text, value)
		End Sub

		' Token: 0x06001865 RID: 6245 RVA: 0x0009F580 File Offset: 0x0009D780
		Public Sub AddContent(Content As String, Optional Attribute As String = "")
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			Dim text As String = MyBase.ID + "_Content_" + Conversions.ToString(Me.oO.0oO0.)
			Me.oO.0oO0. += 1
			Dim value As wRawHtml = New wRawHtml(MyBase.ID, text, String.Concat(New String() { "<p", Attribute, ">", Content, "</p>" }))
			Me.oO.0oO0..Add(text, value)
		End Sub

		' Token: 0x06001866 RID: 6246 RVA: 0x0009F618 File Offset: 0x0009D818
		Public Sub AddImage(Image As String, Optional Attribute As String = "")
			If Operators.CompareString(Attribute, "", True) > 0 Then
				Attribute = " " + Attribute
			End If
			If Me.UseGallery Then
				Dim text As String = MyBase.ID + "_gallery"
				If Me.oO.0oO0. Is Nothing Then
					Me.oO.0oO0. = New wGallery("", text, False, True)
				End If
				Me.oO.0oO0..AddImage(New String() { Image })
				Attribute = String.Concat(New String() { Attribute, " class='article_image' data-gid='", text, "' data-image='", Image, "'" })
			End If
			Dim text2 As String = OoOo0O.OO_o.0o_O.(6)
			While Me.oO.0oO0..ContainsKey(text2)
				text2 = OoOo0O.OO_o.0o_O.(6)
			End While
			Dim value As wRawHtml = New wRawHtml(MyBase.ID, text2, String.Concat(New String() { "<img  src='", Image, "'", Attribute, ">" }))
			Me.oO.0oO0..Add(text2, value)
		End Sub

		' Token: 0x17000557 RID: 1367
		' (get) Token: 0x06001867 RID: 6247 RVA: 0x0009F71E File Offset: 0x0009D91E
		' (set) Token: 0x06001868 RID: 6248 RVA: 0x0009F726 File Offset: 0x0009D926
		<oO0oooo("A0088")>
		Public Property UseGallery As Boolean
			Get
				Return Me.oO.0oO0.
			End Get
			Set(value As Boolean)
				Me.oO.0oO0. = value
			End Set
		End Property

		' Token: 0x17000558 RID: 1368
		' (get) Token: 0x06001869 RID: 6249 RVA: 0x0009F72F File Offset: 0x0009D92F
		Private ReadOnly Property baseClass As String
			Get
				Return "weui_article"
			End Get
		End Property

		' Token: 0x0600186A RID: 6250 RVA: 0x0009F738 File Offset: 0x0009D938
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As wui) Implements Foxtable.o_oOOOoo_O_O.OOO.__O_oO_.
			Dim text As String
			If Operators.CompareString(MyBase.[Class], "", True) = 0 Then
				text = "<article class='" + Me.baseClass + "'"
			Else
				text = String.Concat(New String() { "<article class='", Me.baseClass, " ", MyBase.[Class], "'" })
			End If
			text = String.Concat(New String() { text, " id='", MyBase.ID, "' name='", MyBase.ID, "'" })
			If Operators.CompareString(MyBase.Attribute, "", True) > 0 Then
				text = text + " " + MyBase.Attribute
			End If
			text += ">"
			A_0.AppendLine(text)
			Try
				For Each wElement As wElement In A_1.o0_._00..Values
					If Operators.CompareString(wElement.PID, MyBase.ID, True) = 0 Then
						CType(wElement, o_oOOOoo_O_O).OOO.__O_oO_.(A_0, A_1)
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, wElement).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			A_0.AppendLine("</article>")
			If Me.oO.0oO0. IsNot Nothing Then
				A_1.O.oO_oO..Add(MyBase.ID + "_gallery", Me.oO.0oO0.)
			End If
		End Sub

		' Token: 0x04000A36 RID: 2614
		Private <<EMPTY_NAME>> As Dictionary(Of String, wElement)

		' Token: 0x04000A37 RID: 2615
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000A38 RID: 2616
		Private <<EMPTY_NAME>> As wGallery

		' Token: 0x04000A39 RID: 2617
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000A3A RID: 2618
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
