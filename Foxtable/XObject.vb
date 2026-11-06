Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x0200022C RID: 556
	<oO0oooo("A0171")>
	Public Class XObject
		Inherits JObject

		' Token: 0x060019EE RID: 6638 RVA: 0x000A7360 File Offset: 0x000A5560
		Public Sub New()
		End Sub

		' Token: 0x060019EF RID: 6639 RVA: 0x000A7368 File Offset: 0x000A5568
		Private Sub New(A_0 As String)
			Dim xmlDocument As XmlDocument = New XmlDocument()
			xmlDocument.LoadXml(A_0)
			Dim jobject As JObject = JObject.Parse(JsonConvert.SerializeXmlNode(xmlDocument.DocumentElement, 0, True))
			Try
				For Each jtoken As JToken In jobject.Children()
					Dim type As JTokenType = jtoken.Type
					If type - 1 <= 1 OrElse type = 4 Then
						Me.Ooo_O__.0.(jtoken)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of JToken)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			MyBase.Merge(jobject)
		End Sub

		' Token: 0x060019F0 RID: 6640 RVA: 0x000A73F8 File Offset: 0x000A55F8
		Private Sub <<EMPTY_NAME>>(A_0 As JToken)
			If TypeOf A_0 Is JArray OrElse TypeOf A_0 Is JObject Then
				Try
					For Each a_ As JToken In A_0.Children()
						Me.Ooo_O__.0.(a_)
					Next
					Return
				Finally
					Dim enumerator As IEnumerator(Of JToken)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			If TypeOf A_0 Is JProperty Then
				Dim jproperty As JProperty = CType(A_0, JProperty)
				If jproperty.Value.Type = 1 AndAlso jproperty.Value("#cdata-section") IsNot Nothing Then
					jproperty.Parent(jproperty.Name) = jproperty.Value("#cdata-section").ToString()
					Return
				End If
				If jproperty.Value.Type = 2 OrElse jproperty.Value.Type = 1 Then
					Try
						For Each a_2 As JToken In jproperty.Value.Children()
							Me.Ooo_O__.0.(a_2)
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of JToken)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				End If
			End If
		End Sub

		' Token: 0x060019F1 RID: 6641 RVA: 0x000A7524 File Offset: 0x000A5724
		<oO0oooo("A0173")>
		Public Function AddCData(Key As String, Value As String) As JToken
			Dim jobject As JObject = New JObject()
			jobject("#cdata-section") = Value
			Me(Key) = jobject
			Return jobject
		End Function

		' Token: 0x060019F2 RID: 6642 RVA: 0x000A7551 File Offset: 0x000A5751
		<oO0oooo("A0172")>
		Public Function ToXML() As String
			Dim jobject As JObject = New JObject()
			jobject("xml") = Me
			Return JsonConvert.DeserializeXmlNode(jobject.ToString()).InnerXml
		End Function

		' Token: 0x060019F3 RID: 6643 RVA: 0x000A7573 File Offset: 0x000A5773
		<oO0oooo("A0171")>
		Public Shared Function Parse(XML As String) As XObject
			Return New XObject(XML)
		End Function

		' Token: 0x170005CB RID: 1483
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Default Property Item(key As String) As JToken
			Get
				Dim jtoken As JToken = MyBase(key)
				Dim result As JToken
				If TypeOf jtoken Is JObject AndAlso jtoken("#cdata-section") IsNot Nothing Then
					result = jtoken("#cdata-section")
				Else
					result = jtoken
				End If
				Return result
			End Get
			Set(value As JToken)
				Dim jtoken As JToken = MyBase(key)
				If Not(TypeOf jtoken Is JObject) Then
					MyBase(key) = value
					Return
				End If
				If jtoken("#cdata-section") IsNot Nothing Then
					jtoken("#cdata-section") = value
					Return
				End If
				MyBase(key) = value
			End Set
		End Property
	End Class
End Namespace
