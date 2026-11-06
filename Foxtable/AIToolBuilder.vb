Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020001D8 RID: 472
	Public Class AIToolBuilder
		Inherits Dictionary(Of String, AITool)

		' Token: 0x060016EC RID: 5868 RVA: 0x00093DA0 File Offset: 0x00091FA0
		Public Function AddFunction(name As String, description As String) As AITool
			Dim aitool As AITool = New AITool() With { .Name = name, .Description = description }
			MyBase(name) = aitool
			Return aitool
		End Function

		' Token: 0x060016ED RID: 5869 RVA: 0x00093DCC File Offset: 0x00091FCC
		Public Function Build(Optional Indented As Boolean = True) As String
			Dim jarray As JArray = New JArray()
			Try
				For Each key As String In MyBase.Keys
					Dim aitool As AITool = MyBase(key)
					Dim jobject As JObject = New JObject()
					jobject("type") = "function"
					Dim jobject2 As JObject = New JObject()
					jobject2("name") = aitool.Name
					jobject2("description") = aitool.Description
					Dim jobject3 As JObject = New JObject()
					jobject3("type") = "object"
					Dim jobject4 As JObject = New JObject()
					Dim list As List(Of String) = New List(Of String)()
					Try
						For Each aiparameter As AIParameter In aitool.Parameters
							Dim text As String = aiparameter.Name
							Dim jobject5 As JObject = New JObject()
							jobject5("type") = aiparameter.Type
							If Not String.IsNullOrEmpty(aiparameter.Description) Then
								jobject5("description") = aiparameter.Description
							End If
							If Operators.CompareString(aiparameter.Type, "array", True) = 0 Then
								Dim jobject6 As JObject = New JObject()
								jobject6("type") = aiparameter.ArrayItemType
								jobject5("items") = jobject6
							End If
							If aiparameter.EnumValues IsNot Nothing Then
								Dim jarray2 As JArray = New JArray()
								Dim text2 As String = aiparameter.Type
								If Operators.CompareString(aiparameter.Type, "array", True) = 0 Then
									text2 = aiparameter.ArrayItemType
								End If
								Try
									For Each obj As Object In aiparameter.EnumValues
										Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
										If objectValue IsNot Nothing Then
											Dim left As String = text2
											If Operators.CompareString(left, "string", True) = 0 Then
												jarray2.Add(objectValue.ToString())
											ElseIf Operators.CompareString(left, "number", True) = 0 Then
												Dim num As Double
												If Double.TryParse(objectValue.ToString(), num) Then
													jarray2.Add(num)
												End If
											ElseIf Operators.CompareString(left, "integer", True) = 0 Then
												Dim num2 As Integer
												If Integer.TryParse(objectValue.ToString(), num2) Then
													jarray2.Add(num2)
												End If
											ElseIf Operators.CompareString(left, "boolean", True) = 0 Then
												Dim flag As Boolean
												If Boolean.TryParse(objectValue.ToString(), flag) Then
													jarray2.Add(flag)
												End If
											Else
												jarray2.Add(RuntimeHelpers.GetObjectValue(objectValue))
											End If
										End If
									Next
								Finally
									Dim enumerator3 As IEnumerator(Of Object)
									If enumerator3 IsNot Nothing Then
										enumerator3.Dispose()
									End If
								End Try
								If jarray2.Count > 0 Then
									If Operators.CompareString(aiparameter.Type, "array", True) = 0 Then
										jobject5("items")("enum") = jarray2
									Else
										jobject5("enum") = jarray2
									End If
								End If
							End If
							jobject4(text) = jobject5
							If aiparameter.IsRequired Then
								list.Add(text)
							End If
						Next
					Finally
						Dim enumerator2 As List(Of AIParameter).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					jobject3("properties") = jobject4
					If list.Count > 0 Then
						Dim jarray3 As JArray = New JArray()
						Try
							For Each text3 As String In list
								jarray3.Add(text3)
							Next
						Finally
							Dim enumerator4 As List(Of String).Enumerator
							CType(enumerator4, IDisposable).Dispose()
						End Try
						jobject3("required") = jarray3
					Else
						jobject3("required") = New JArray()
					End If
					jobject2("parameters") = jobject3
					jobject("function") = jobject2
					jarray.Add(jobject)
				Next
			Finally
				Dim enumerator As Dictionary(Of String, AITool).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim result As String
			If Indented Then
				result = JsonConvert.SerializeObject(jarray, 1)
			Else
				result = JsonConvert.SerializeObject(jarray, 0)
			End If
			Return result
		End Function
	End Class
End Namespace
