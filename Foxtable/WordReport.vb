Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000463 RID: 1123
	<oO0oooo("2890")>
	Public Class WordReport
		' Token: 0x1700109B RID: 4251
		' (get) Token: 0x06004B41 RID: 19265 RVA: 0x001FB4CF File Offset: 0x001F96CF
		' (set) Token: 0x06004B42 RID: 19266 RVA: 0x001FB4D8 File Offset: 0x001F96D8
		Private Shared Property app As Application
			<CompilerGenerated()>
			Get
				Return WordReport.O000.OO0__OoO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Application)
				Dim applicationEvents4_QuitEventHandler As ApplicationEvents4_QuitEventHandler = New ApplicationEvents4_QuitEventHandler(Nothing, CType(ldftn(AddressOf oO.0O.), UIntPtr))
				Dim o000.OO0__OoO. As Application = WordReport.O000.OO0__OoO.
				If o000.OO0__OoO. IsNot Nothing Then
					o000.OO0__OoO..Quit -= applicationEvents4_QuitEventHandler
				End If
				WordReport.O000.OO0__OoO. = value
				o000.OO0__OoO. = WordReport.O000.OO0__OoO.
				If o000.OO0__OoO. IsNot Nothing Then
					o000.OO0__OoO..Quit += applicationEvents4_QuitEventHandler
				End If
			End Set
		End Property

		' Token: 0x06004B43 RID: 19267
		Private Declare Ansi Function SetForegroundWindow Lib "user32" (A_0 As Integer) As Integer

		' Token: 0x06004B44 RID: 19268
		Private Declare Ansi Function SetActiveWindow Lib "user32" (A_0 As Integer) As Integer

		' Token: 0x06004B45 RID: 19269 RVA: 0x001FB518 File Offset: 0x001F9718
		Public Sub New(A_0 As Table, A_1 As Object, A_2 As Object)
			Me.O_.ooO_0_OOo. = New List(Of String)()
			Me.oO.0O_00ooO_O. = 0
			Me.O000.OO0__OoO. = New Dictionary(Of String, DataRow())()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, DataRow)()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, String)()
			Me.OOO_Oo0o_.0_. = New Dictionary(Of String, String)()
			Me.o__o.OOoO_. = New tempDataTableCollection()
			Me.O000.OO0__OoO. = New List(Of O_0OO)()
			Me.O000.OO0__OoO. = New List(Of o0__oo0OOo)()
			Me.O000.OO0__OoO.(A_0, RuntimeHelpers.GetObjectValue(A_1), RuntimeHelpers.GetObjectValue(A_2))
		End Sub

		' Token: 0x06004B46 RID: 19270 RVA: 0x001FB5A0 File Offset: 0x001F97A0
		Public Sub New(A_0 As String, A_1 As Object, A_2 As Object)
			Me.O_.ooO_0_OOo. = New List(Of String)()
			Me.oO.0O_00ooO_O. = 0
			Me.O000.OO0__OoO. = New Dictionary(Of String, DataRow())()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, DataRow)()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, String)()
			Me.OOO_Oo0o_.0_. = New Dictionary(Of String, String)()
			Me.o__o.OOoO_. = New tempDataTableCollection()
			Me.O000.OO0__OoO. = New List(Of O_0OO)()
			Me.O000.OO0__OoO. = New List(Of o0__oo0OOo)()
			Me.O000.OO0__OoO.(OO_00oOO.Tables(A_0), RuntimeHelpers.GetObjectValue(A_1), RuntimeHelpers.GetObjectValue(A_2))
		End Sub

		' Token: 0x06004B47 RID: 19271 RVA: 0x001FB630 File Offset: 0x001F9830
		Public Sub New(A_0 As Object, A_1 As Object)
			Me.O_.ooO_0_OOo. = New List(Of String)()
			Me.oO.0O_00ooO_O. = 0
			Me.O000.OO0__OoO. = New Dictionary(Of String, DataRow())()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, DataRow)()
			Me.O_.ooO_0_OOo. = New Dictionary(Of String, String)()
			Me.OOO_Oo0o_.0_. = New Dictionary(Of String, String)()
			Me.o__o.OOoO_. = New tempDataTableCollection()
			Me.O000.OO0__OoO. = New List(Of O_0OO)()
			Me.O000.OO0__OoO. = New List(Of o0__oo0OOo)()
			Me.O000.OO0__OoO.(Nothing, RuntimeHelpers.GetObjectValue(A_0), RuntimeHelpers.GetObjectValue(A_1))
		End Sub

		' Token: 0x06004B48 RID: 19272 RVA: 0x001FB6B8 File Offset: 0x001F98B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As Object, A_2 As Object)
			Dim objectValue As Object
			Dim objectValue2 As Object
			Dim objectValue3 As Object
			Try
				If WordReport.app IsNot Nothing AndAlso (WordReport.app.Visible OrElse Not WordReport.app.Visible) Then
					Try
						For Each obj As Object In WordReport.app.Documents
							CType(obj, Document).Saved = True
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If WordReport.app.Documents.Count > 0 Then
						Dim documents As Documents = WordReport.app.Documents
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
						objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
						documents.Close(objectValue, objectValue2, objectValue3)
					End If
					Dim application As _Application = WordReport.app
					objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
					application.Quit(objectValue3, objectValue2, objectValue)
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					WordReport.app = Nothing
					GC.Collect()
					GC.Collect()
					GC.Collect()
					GC.Collect()
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			If OO_00oOO.FileIsOpened(A_2.ToString()) Then
				MessageBox.Show("目标报表文件已经被其它进程打开，生成的报表将存为一个临时文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				A_2 = Path.GetTempFileName()
			End If
			WordReport.app = New ApplicationClass()
			OO_00oOO.FileSys.CopyFile(A_1.ToString(), A_2.ToString(), True)
			Dim documents2 As Documents = WordReport.app.Documents
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue15 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Me.O_.ooO_0_OOo. = documents2.Open(A_2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14, objectValue15)
			Me.O_.ooO_0_OOo. = A_0
			If A_0 IsNot Nothing Then
				Me.O_.ooO_0_OOo. = Me.O_.ooO_0_OOo..DataTable.Name
			End If
			Me.OOo_oooOo_.0Oo. = 0
		End Sub

		' Token: 0x06004B49 RID: 19273 RVA: 0x001FB974 File Offset: 0x001F9B74
		Public Sub Replace(findText As String, repaceText As String)
			If Operators.CompareString(repaceText, "", True) > 0 AndAlso repaceText.Length > 200 Then
				Me.ReplaceText(findText, repaceText)
				Return
			End If
			Try
				WordReport.app.Selection.Start = Me.o_oooOOOO.0.
				WordReport.app.Selection.[End] = Me.o_oooOOOO.0.
				Dim find As Find = WordReport.app.Selection.Find
				find.ClearFormatting()
				find.MatchCase = False
				find.Text = findText
				find.Forward = True
				find.MatchWildcards = False
				find.Replacement.ClearFormatting()
				find.Replacement.Text = repaceText
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim obj As Object = 2
				Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				find.Execute(objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, obj, objectValue11, objectValue12, objectValue13, objectValue14)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06004B4A RID: 19274 RVA: 0x001FBB24 File Offset: 0x001F9D24
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ReplaceText(Mark As String, value As String)
			Dim obj As Object = 0
			Dim selection As Selection = WordReport.app.Selection
			Dim obj2 As Object = 6
			selection.HomeKey(obj2, obj)
			Dim obj3 As Object = Mark
			If value.IndexOf(Mark) >= 0 Then
				value = value.Replace(Mark, Mark.Trim(New Char() { "["c }).Trim(New Char() { "]"c }))
			End If
			Dim find As Find = WordReport.app.Selection.Find
			find.ClearFormatting()
			find.MatchCase = False
			find.Forward = True
			Dim selection2 As Selection = WordReport.app.Selection
			obj2 = 6
			selection2.HomeKey(obj2, obj)
			While True
				Dim find2 As Find = find
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				If Not find2.Execute(obj3, obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13) Then
					Exit For
				End If
				WordReport.app.Selection.Text = value
				Dim selection3 As Selection = WordReport.app.Selection
				obj2 = 6
				selection3.HomeKey(obj2, obj)
			End While
		End Sub

		' Token: 0x06004B4B RID: 19275 RVA: 0x001FBCC7 File Offset: 0x001F9EC7
		Public Sub ReplaceOne(findText As String, repaceText As String)
			Me.O_.ooO_0_OOo..Add(findText, repaceText)
		End Sub

		' Token: 0x06004B4C RID: 19276 RVA: 0x001FBCD8 File Offset: 0x001F9ED8
		Public Sub ReplaceWithImage(findText As Object, ImageFile As String, Width As Integer, Height As Integer)
			Try
				WordReport.app.Selection.Start = Me.o_oooOOOO.0.
				WordReport.app.Selection.[End] = Me.o_oooOOOO.0.
				Dim find As Find = WordReport.app.Selection.Find
				find.ClearFormatting()
				find.MatchCase = False
				find.MatchWildcards = False
				find.Forward = True
				While True
					Dim find2 As Find = find
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim obj As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim obj2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find2.Execute(findText, objectValue, obj, obj2, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12) Then
						Exit For
					End If
					ImageFile = ooO.OoO0o_o___.O.(ImageFile)
					If OO_00oOO.FileSys.FileExists(ImageFile) Then
						If Operators.CompareString(Path.GetExtension(ImageFile), ".ico", True) = 0 Then
							Dim image As Image = OO_00oOO.GetImage(ImageFile)
							If image Is Nothing Then
								Exit For
							End If
							ImageFile += ".png"
							image.Save(ImageFile, ImageFormat.Png)
						End If
						Dim inlineShapes As InlineShapes = WordReport.app.Selection.InlineShapes
						Dim text As String = ImageFile
						obj2 = False
						obj = True
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
						Dim inlineShape As InlineShape = inlineShapes.AddPicture(text, obj2, obj, objectValue)
						If Width = -1 AndAlso Height > 0 Then
							Dim image2 As Image = OO_00oOO.GetImage(ImageFile)
							Width = CInt(Math.Round(CDbl((Height * image2.Size.Width)) / CDbl(image2.Size.Height)))
						ElseIf Height = -1 AndAlso Width > 0 Then
							Dim image3 As Image = OO_00oOO.GetImage(ImageFile)
							Height = CInt(Math.Round(CDbl((Width * image3.Size.Height)) / CDbl(image3.Size.Width)))
						End If
						inlineShape.Width = CSng(Width)
						inlineShape.Height = CSng(Height)
					End If
				End While
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x06004B4D RID: 19277 RVA: 0x001FBF60 File Offset: 0x001FA160
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If WordReport.app.StartupPath.IndexOf("wps", StringComparison.OrdinalIgnoreCase) <= 0 Then
					GoTo IL_3B
				End If
				IL_21:
				num2 = 3
				MessageBox.Show("Word报表和WPS不兼容，请参考帮助文档进行设置!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_D10
				IL_3B:
				num2 = 5
				Me.O_.ooO_0_OOo..Clear()
				IL_48:
				num2 = 6
				Dim obj As Object = 0
				IL_51:
				num2 = 7
				Dim selection As Selection = WordReport.app.Selection
				Dim obj2 As Object = 6
				selection.HomeKey(obj2, obj)
				IL_6F:
				num2 = 8
				Dim find As Find = WordReport.app.Selection.Find
				IL_82:
				num2 = 9
				find.ClearFormatting()
				IL_8C:
				num2 = 10
				find.MatchCase = False
				IL_97:
				num2 = 11
				find.Forward = True
				IL_A2:
				num2 = 12
				find.MatchWildcards = True
				Dim obj3 As Object
				While True
					IL_125:
					num2 = 14
					Dim find2 As Find = find
					obj2 = "\^60[!> 　]*[!< 　]\^62"
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find2.Execute(obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, obj3) Then
						Exit For
					End If
					IL_AF:
					num2 = 15
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_CE:
						num2 = 16
						Dim text As String = WordReport.app.Selection.Text
						IL_E2:
						num2 = 17
						text = text.Substring(text.IndexOf("<"))
						IL_FA:
						num2 = 18
						text = text.Substring(0, text.LastIndexOf(">") + 1)
						IL_115:
						num2 = 19
						Me.O_.ooO_0_OOo..Add(text)
					End If
				End While
				IL_201:
				num2 = 21
				Dim selection2 As Selection = WordReport.app.Selection
				obj3 = 6
				selection2.HomeKey(obj3, obj)
				While True
					IL_25E:
					num2 = 23
					Dim find3 As Find = find
					obj3 = "\[<*>\]"
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find3.Execute(obj3, objectValue13, objectValue12, objectValue11, objectValue10, objectValue9, objectValue8, objectValue7, objectValue6, objectValue5, objectValue4, objectValue3, objectValue2, objectValue, obj2) Then
						Exit For
					End If
					IL_222:
					num2 = 24
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_241:
						num2 = 25
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_33A:
				num2 = 27
				Dim selection3 As Selection = WordReport.app.Selection
				obj2 = 6
				selection3.HomeKey(obj2, obj)
				While True
					IL_397:
					num2 = 29
					Dim find4 As Find = find
					obj2 = "\[\^38<*\,*\,*>\]"
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find4.Execute(obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, obj3) Then
						Exit For
					End If
					IL_35B:
					num2 = 30
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_37A:
						num2 = 31
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_473:
				num2 = 33
				Dim selection4 As Selection = WordReport.app.Selection
				obj3 = 6
				selection4.HomeKey(obj3, obj)
				While True
					IL_4D0:
					num2 = 35
					Dim find5 As Find = find
					obj3 = "\[\^38\^38<*\,*\,*>\]"
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find5.Execute(obj3, objectValue13, objectValue12, objectValue11, objectValue10, objectValue9, objectValue8, objectValue7, objectValue6, objectValue5, objectValue4, objectValue3, objectValue2, objectValue, obj2) Then
						Exit For
					End If
					IL_494:
					num2 = 36
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_4B3:
						num2 = 37
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_5AC:
				num2 = 39
				Dim selection5 As Selection = WordReport.app.Selection
				obj2 = 6
				selection5.HomeKey(obj2, obj)
				While True
					IL_609:
					num2 = 41
					Dim find6 As Find = find
					obj2 = "\[\^64<*\,*\,*>\]"
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find6.Execute(obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, obj3) Then
						Exit For
					End If
					IL_5CD:
					num2 = 42
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_5EC:
						num2 = 43
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_6E5:
				num2 = 45
				Dim selection6 As Selection = WordReport.app.Selection
				obj3 = 6
				selection6.HomeKey(obj3, obj)
				While True
					IL_742:
					num2 = 47
					Dim find7 As Find = find
					obj3 = "\[\^64<*\,*>\]"
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find7.Execute(obj3, objectValue13, objectValue12, objectValue11, objectValue10, objectValue9, objectValue8, objectValue7, objectValue6, objectValue5, objectValue4, objectValue3, objectValue2, objectValue, obj2) Then
						Exit For
					End If
					IL_706:
					num2 = 48
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_725:
						num2 = 49
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_81E:
				num2 = 51
				Dim selection7 As Selection = WordReport.app.Selection
				obj2 = 6
				selection7.HomeKey(obj2, obj)
				While True
					IL_87B:
					num2 = 53
					Dim find8 As Find = find
					obj2 = "\[\^64^38<*\,*\,*\,*\,*>\]"
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find8.Execute(obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, obj3) Then
						Exit For
					End If
					IL_83F:
					num2 = 54
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_85E:
						num2 = 55
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_957:
				num2 = 57
				Dim selection8 As Selection = WordReport.app.Selection
				obj3 = 6
				selection8.HomeKey(obj3, obj)
				While True
					IL_9B4:
					num2 = 59
					Dim find9 As Find = find
					obj3 = "\[\^64^38<*\,*\,*\,*>\]"
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find9.Execute(obj3, objectValue13, objectValue12, objectValue11, objectValue10, objectValue9, objectValue8, objectValue7, objectValue6, objectValue5, objectValue4, objectValue3, objectValue2, objectValue, obj2) Then
						Exit For
					End If
					IL_978:
					num2 = 60
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_997:
						num2 = 61
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_A90:
				num2 = 63
				Dim selection9 As Selection = WordReport.app.Selection
				obj2 = 6
				selection9.HomeKey(obj2, obj)
				While True
					IL_AED:
					num2 = 65
					Dim find10 As Find = find
					obj2 = "\[\^37<*\,*\^40*\^41\]"
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj3 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find10.Execute(obj2, objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, obj3) Then
						Exit For
					End If
					IL_AB1:
					num2 = 66
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_AD0:
						num2 = 67
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_BC9:
				num2 = 69
				find.MatchWildcards = False
				IL_BD4:
				num2 = 70
				Dim selection10 As Selection = WordReport.app.Selection
				obj3 = 6
				selection10.HomeKey(obj3, obj)
				While True
					IL_C31:
					num2 = 72
					Dim find11 As Find = find
					obj3 = "<Index>"
					Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
					obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
					If Not find11.Execute(obj3, objectValue13, objectValue12, objectValue11, objectValue10, objectValue9, objectValue8, objectValue7, objectValue6, objectValue5, objectValue4, objectValue3, objectValue2, objectValue, obj2) Then
						Exit For
					End If
					IL_BF5:
					num2 = 73
					If Not Me.O_.ooO_0_OOo..Contains(WordReport.app.Selection.Text) Then
						IL_C14:
						num2 = 74
						Me.O_.ooO_0_OOo..Add(WordReport.app.Selection.Text)
					End If
				End While
				IL_D0D:
				find = Nothing
				IL_D10:
				GoTo IL_E96
				IL_D15:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_E57:
				GoTo IL_E8B
				IL_E59:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_E69:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_E59
			End Try
			IL_E8B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E96:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004B4E RID: 19278 RVA: 0x001FCE28 File Offset: 0x001FB028
		Public Sub Build()
			If Me.O_.ooO_0_OOo. Then
				Me.O.0o0O__o.()
				Me.O_.ooO_0_OOo. = False
			End If
			If Me.O_.ooO_0_OOo. IsNot Nothing AndAlso Me.O_.ooO_0_OOo..Tables.Count > 0 Then
				Try
					For Each obj As Object In Me.O_.ooO_0_OOo..Tables(0).Rows
						Dim a_ As DataRow = CType(obj, DataRow)
						Me.BuildOne(New DataRow(a_))
					Next
					Return
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.OOo_oooOo_.0Oo. = 0
			Dim num As Integer = Me.O_.ooO_0_OOo..TopPosition
			Dim num2 As Integer = Me.O_.ooO_0_OOo..BottomPosition
			For i As Integer = num To num2
				Dim dataRow As DataRow = Me.O_.ooO_0_OOo..Rows(i).DataRow
				Me.BuildOne(dataRow)
			Next
		End Sub

		' Token: 0x06004B4F RID: 19279 RVA: 0x001FCF14 File Offset: 0x001FB114
		Public Sub BuildOne(r As Row)
			Me.BuildOne(r.DataRow)
		End Sub

		' Token: 0x06004B50 RID: 19280 RVA: 0x001FCF24 File Offset: 0x001FB124
		Public Sub BuildOne(dr As DataRow)
			Dim num As Integer
			Dim num9 As Integer
			Dim obj6 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.O000.OO0__OoO..Clear()
				IL_14:
				num2 = 3
				Me.O_.ooO_0_OOo..Clear()
				IL_21:
				num2 = 4
				Me.OOo_oooOo_.0Oo. += 1
				IL_31:
				num2 = 5
				If Me.O000.OO0__OoO. <= 0 Then
					GoTo IL_FB
				End If
				IL_3F:
				num2 = 6
				Dim obj As Object = 0
				IL_48:
				num2 = 7
				Dim selection As Selection = WordReport.app.Selection
				Dim obj2 As Object = 6
				selection.EndKey(obj2, obj)
				IL_66:
				num2 = 8
				Me.o_oooOOOO.0. = Me.O_.ooO_0_OOo..Characters.Count
				IL_7E:
				num2 = 9
				If Me.O000.OO0__OoO. <> 1 Then
					GoTo IL_9C
				End If
				IL_8A:
				num2 = 10
				WordReport.app.Selection.TypeParagraph()
				IL_9C:
				num2 = 11
				If Me.RecordsOnEachPage <= 0 OrElse Me.O000.OO0__OoO. Mod Me.RecordsOnEachPage <> 0 Then
					GoTo IL_D5
				End If
				IL_B7:
				num2 = 12
				Dim selection2 As Selection = WordReport.app.Selection
				obj2 = 7
				selection2.InsertBreak(obj2)
				GoTo IL_E7
				IL_D5:
				num2 = 14
				WordReport.app.Selection.TypeParagraph()
				IL_E7:
				num2 = 15
				WordReport.app.Selection.Paste()
				GoTo IL_144
				IL_FB:
				num2 = 17
				Me.o_O0._000.()
				IL_104:
				num2 = 18
				Dim o_.ooO_0_OOo. As _Document = Me.O_.ooO_0_OOo.
				obj2 = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
				Dim range As Range = o_.ooO_0_OOo..Range(obj2, objectValue)
				IL_130:
				num2 = 19
				range.[Select]()
				IL_13A:
				num2 = 20
				range.Copy()
				IL_144:
				num2 = 21
				Me.O000.OO0__OoO. += 1
				IL_155:
				num2 = 22
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Me.O_.ooO_0_OOo..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_175:
					num2 = 23
					Me.Replace(text, Me.O_.ooO_0_OOo.(text))
					IL_18D:
					num2 = 24
				End While
				IL_199:
				num2 = 25
				CType(enumerator, IDisposable).Dispose()
				IL_1A9:
				num2 = 26
				Dim enumerator2 As List(Of String).Enumerator = Me.O_.ooO_0_OOo..GetEnumerator()
				While enumerator2.MoveNext()
					Dim text2 As String = enumerator2.Current
					IL_1C7:
					num2 = 27
					Dim text3 As String = text2.Trim()
					IL_1D3:
					num2 = 28
					If text3.StartsWith("[") AndAlso text3.EndsWith("]") Then
						IL_1F8:
						num2 = 29
						text3 = text3.Trim().Trim(New Char() { "["c }).Trim(New Char() { "]"c })
						IL_224:
						num2 = 30
						If text3.StartsWith("&") Then
							IL_238:
							num2 = 31
							Dim flag As Boolean = False
							IL_23E:
							num2 = 32
							text3 = text3.Substring(1)
							IL_24B:
							num2 = 33
							If text3.StartsWith("&") Then
								IL_25C:
								num2 = 34
								flag = True
								IL_262:
								num2 = 35
								text3 = text3.Substring(1)
							End If
							IL_26F:
							num2 = 36
							Dim array As String() = text3.Split(New Char() { ","c })
							IL_286:
							num2 = 37
							If array.Length = 3 AndAlso Versioned.IsNumeric(array(1)) AndAlso Versioned.IsNumeric(array(2)) Then
								IL_2AF:
								num2 = 38
								If flag Then
									IL_2B6:
									num2 = 39
									Me.ReplaceWithImage(text2, array(0), Conversions.ToInteger(array(1)), Conversions.ToInteger(array(2)))
								Else
									IL_2DC:
									num2 = 41
									Dim num3 As Integer = 0
									IL_2E2:
									num2 = 42
									If array(0).IndexOf("&") > 0 Then
										IL_2F6:
										num2 = 43
										Integer.TryParse(array(0).Substring(array(0).IndexOf("&") + 1), num3)
										IL_31A:
										num2 = 44
										array(0) = array(0).Substring(0, array(0).IndexOf("&"))
									End If
									IL_339:
									num2 = 45
									Dim array2 As String() = dr(array(0)).ToString().ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
									IL_368:
									num2 = 46
									If array2.Length > num3 Then
										IL_373:
										num2 = 47
										Dim remoteImageFile As String = Ooo_O.GetRemoteImageFile(array2(num3), dr.DataTable.DataCols(array(0)))
										IL_396:
										num2 = 48
										Me.ReplaceWithImage(text2, remoteImageFile, Conversions.ToInteger(array(1)), Conversions.ToInteger(array(2)))
									Else
										IL_3BA:
										num2 = 50
										Me.Replace(text2, "")
									End If
								End If
							End If
						Else
							IL_3CF:
							num2 = 52
							If text3.StartsWith("@") Then
								IL_3E3:
								num2 = 53
								text3 = text3.Substring(1)
								IL_3F0:
								num2 = 54
								Dim array3 As String() = text3.Split(New Char() { ","c })
								IL_407:
								num2 = 55
								If(array3.Length = 3 AndAlso Versioned.IsNumeric(array3(2))) OrElse (array3.Length = 5 AndAlso Versioned.IsNumeric(array3(2)) AndAlso Versioned.IsNumeric(array3(3)) AndAlso Versioned.IsNumeric(array3(4))) Then
									IL_450:
									num2 = 56
									array3(0) = array3(0).Trim()
									IL_460:
									num2 = 57
									array3(1) = array3(1).Trim()
									IL_470:
									num2 = 58
									Dim flag2 As Boolean = array3(0).StartsWith("&")
									IL_483:
									num2 = 59
									If flag2 Then
										IL_48A:
										num2 = 60
										array3(0) = array3(0).Substring(1)
									End If
									IL_49B:
									num2 = 61
									If Not Me.O000.OO0__OoO..ContainsKey(array3(0)) Then
										IL_4B2:
										num2 = 62
										Dim enumerator3 As IEnumerator = dr.BaseRow.Table.DataSet.Relations.GetEnumerator()
										While enumerator3.MoveNext()
											Dim obj3 As Object = enumerator3.Current
											Dim dataRelation As DataRelation = CType(obj3, DataRelation)
											IL_4E1:
											num2 = 63
											If Operators.CompareString(dataRelation.ParentTable.TableName, Me.O_.ooO_0_OOo., True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, array3(0), True) = 0 Then
												IL_516:
												num2 = 64
												Me.O000.OO0__OoO..Add(array3(0), dr.BaseRow.GetChildRows(dataRelation))
											End If
											IL_535:
											num2 = 65
										End While
										IL_541:
										num2 = 66
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End If
									IL_559:
									num2 = 67
									Dim num4 As Integer = 0
									IL_55F:
									num2 = 68
									If array3(1).IndexOf("&") > 0 Then
										IL_573:
										num2 = 69
										Integer.TryParse(array3(1).Substring(array3(1).IndexOf("&") + 1), num4)
										IL_597:
										num2 = 70
										array3(1) = array3(1).Substring(0, array3(1).IndexOf("&"))
									End If
									IL_5B6:
									num2 = 71
									If Me.O000.OO0__OoO..ContainsKey(array3(0)) AndAlso ((OO_00oOO.DataTables.Contains(array3(0)) AndAlso OO_00oOO.DataTables(array3(0)).DataCols.Contains(array3(1))) OrElse (Me.O_.ooO_0_OOo. IsNot Nothing AndAlso Me.O_.ooO_0_OOo..Tables.Contains(array3(0)) AndAlso Me.O_.ooO_0_OOo..Tables(array3(0)).Columns.Contains(array3(1)))) Then
										IL_646:
										num2 = 72
										Dim flag3 As Boolean
										If OO_00oOO.DataTables.Contains(array3(0)) AndAlso OO_00oOO.DataTables(array3(0)).DataCols.Contains(array3(1)) Then
											IL_677:
											num2 = 73
											flag3 = False
										Else
											IL_67F:
											num2 = 75
											flag3 = True
										End If
										IL_685:
										num2 = 76
										If Me.O000.OO0__OoO.(array3(0)).Length < Conversions.ToInteger(array3(2)) Then
											IL_6A4:
											num2 = 77
											Me.Replace(text2, "")
										Else
											IL_6B9:
											num2 = 79
											If Me.O000.OO0__OoO.(array3(0))(Conversions.ToInteger(array3(2)) - 1).IsNull(array3(1)) Then
												IL_6E2:
												num2 = 80
												Me.Replace(text2, "")
											Else
												IL_6F7:
												num2 = 82
												If array3.Length = 3 Then
													IL_704:
													num2 = 83
													If Conversions.ToInteger(array3(2)) <= Me.O000.OO0__OoO.(array3(0)).Length Then
														IL_726:
														num2 = 84
														If Not flag3 AndAlso OO_00oOO.DataTables(array3(0)).DataCols(array3(1)).ExtendType = 8 Then
															IL_754:
															num2 = 85
															Dim a_ As Double = Conversion.Val(Me.O000.OO0__OoO.(array3(0))(Conversions.ToInteger(array3(2)) - 1)(array3(1)).ToString())
															IL_787:
															num2 = 86
															Dim repaceText As String = ""
															IL_791:
															num2 = 87
															O_O0OO.o.00O_O.(a_, repaceText)
															IL_79E:
															num2 = 88
															Me.Replace(text2, repaceText)
														Else
															IL_7B0:
															num2 = 90
															Me.Replace(text2, Me.O000.OO0__OoO.(array3(0))(Conversions.ToInteger(array3(2)) - 1)(array3(1)).ToString())
														End If
													Else
														IL_7E9:
														num2 = 92
														Me.Replace(text2, "")
													End If
												Else
													IL_7FE:
													num2 = 94
													If flag2 AndAlso array3.Length = 5 Then
														IL_812:
														num2 = 95
														If Conversions.ToInteger(array3(2)) <= Me.O000.OO0__OoO.(array3(0)).Length Then
															IL_834:
															num2 = 96
															Dim array4 As String() = Me.O000.OO0__OoO.(array3(0))(Conversions.ToInteger(array3(2)) - 1)(array3(1)).ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
															IL_878:
															num2 = 97
															If array4.Length > num4 Then
																IL_883:
																num2 = 98
																Dim imageFile As String
																If Not flag3 Then
																	IL_88A:
																	num2 = 99
																	imageFile = Ooo_O.GetRemoteImageFile(array4(num4), OO_00oOO.DataTables(array3(0)).DataCols(array3(1)))
																Else
																	IL_8B7:
																	num2 = 101
																	imageFile = array4(num4)
																End If
																IL_8C1:
																num2 = 102
																Me.ReplaceWithImage(text2, imageFile, Conversions.ToInteger(array3(3)), Conversions.ToInteger(array3(4)))
															Else
																IL_8E5:
																num2 = 104
																Me.Replace(text2, "")
															End If
														Else
															IL_8FA:
															num2 = 106
															Me.Replace(text2, "")
														End If
													End If
												End If
											End If
										End If
									End If
								Else
									IL_90F:
									num2 = 108
									If array3.Length = 2 OrElse (array3.Length = 4 AndAlso Versioned.IsNumeric(array3(2)) AndAlso Versioned.IsNumeric(array3(3))) Then
										IL_93F:
										num2 = 109
										array3(0) = array3(0).Trim()
										IL_94F:
										num2 = 110
										array3(1) = array3(1).Trim()
										IL_95F:
										num2 = 111
										Dim flag4 As Boolean = array3(0).StartsWith("&")
										IL_972:
										num2 = 112
										If flag4 Then
											IL_979:
											num2 = 113
											array3(0) = array3(0).Substring(1)
										End If
										IL_98A:
										num2 = 114
										If Not Me.O_.ooO_0_OOo..ContainsKey(array3(0)) Then
											IL_9A1:
											num2 = 115
											Dim enumerator4 As IEnumerator = dr.BaseRow.Table.DataSet.Relations.GetEnumerator()
											While enumerator4.MoveNext()
												Dim obj4 As Object = enumerator4.Current
												Dim dataRelation2 As DataRelation = CType(obj4, DataRelation)
												IL_9D0:
												num2 = 116
												If Operators.CompareString(dataRelation2.ParentTable.TableName, array3(0), True) = 0 AndAlso Operators.CompareString(dataRelation2.ChildTable.TableName, Me.O_.ooO_0_OOo., True) = 0 Then
													IL_A05:
													num2 = 117
													Me.O_.ooO_0_OOo..Add(array3(0), dr.BaseRow.GetParentRow(dataRelation2))
												End If
												IL_A24:
												num2 = 118
											End While
											IL_A30:
											num2 = 119
											If TypeOf enumerator4 Is IDisposable Then
												TryCast(enumerator4, IDisposable).Dispose()
											End If
										End If
										IL_A48:
										num2 = 120
										Dim num5 As Integer = 0
										IL_A4E:
										num2 = 121
										If array3(1).IndexOf("&") > 0 Then
											IL_A62:
											num2 = 122
											Integer.TryParse(array3(1).Substring(array3(1).IndexOf("&") + 1), num5)
											IL_A86:
											num2 = 123
											array3(1) = array3(1).Substring(0, array3(1).IndexOf("&"))
										End If
										IL_AA5:
										num2 = 124
										If Me.O_.ooO_0_OOo..ContainsKey(array3(0)) AndAlso ((OO_00oOO.DataTables.Contains(array3(0)) AndAlso OO_00oOO.DataTables(array3(0)).DataCols.Contains(array3(1))) OrElse (Me.O_.ooO_0_OOo. IsNot Nothing AndAlso Me.O_.ooO_0_OOo..Tables.Contains(array3(0)) AndAlso Me.O_.ooO_0_OOo..Tables(array3(0)).Columns.Contains(array3(1)))) Then
											IL_B35:
											num2 = 125
											Dim flag5 As Boolean
											If OO_00oOO.DataTables.Contains(array3(0)) AndAlso OO_00oOO.DataTables(array3(0)).DataCols.Contains(array3(1)) Then
												IL_B66:
												num2 = 126
												flag5 = False
											Else
												IL_B6E:
												num2 = 128
												flag5 = True
											End If
											IL_B77:
											num2 = 129
											Dim dataRow As DataRow = Me.O_.ooO_0_OOo.(array3(0))
											IL_B8E:
											num2 = 130
											If dataRow IsNot Nothing Then
												IL_B9B:
												num2 = 131
												If dataRow.IsNull(array3(1)) Then
													IL_BAE:
													num2 = 132
													Me.Replace(text2, "")
												Else
													IL_BC6:
													num2 = 134
													If array3.Length = 2 Then
														IL_BD6:
														num2 = 135
														If Not flag5 AndAlso OO_00oOO.DataTables(array3(0)).DataCols(array3(1)).ExtendType = 8 Then
															IL_C04:
															num2 = 136
															Dim a_2 As Double = Conversion.Val(dataRow(array3(1)).ToString())
															IL_C21:
															num2 = 137
															Dim repaceText2 As String = ""
															IL_C2E:
															num2 = 138
															O_O0OO.o.00O_O.(a_2, repaceText2)
															IL_C3E:
															num2 = 139
															Me.Replace(text2, repaceText2)
														Else
															IL_C53:
															num2 = 141
															Me.Replace(text2, dataRow(array3(1)).ToString())
														End If
													Else
														IL_C76:
														num2 = 143
														If flag4 AndAlso array3.Length = 4 Then
															IL_C8D:
															num2 = 144
															Dim array5 As String() = dataRow(array3(1)).ToString().ToString().Split(New Char() { vbLf, vbCr }, StringSplitOptions.RemoveEmptyEntries)
															IL_CC0:
															num2 = 145
															If array5.Length > num5 Then
																IL_CCE:
																num2 = 146
																Dim imageFile2 As String
																If Not flag5 Then
																	IL_CD8:
																	num2 = 147
																	Ooo_O.GetRemoteImageFile(array5(num5), OO_00oOO.DataTables(array3(0)).DataCols(array3(1)))
																Else
																	IL_D07:
																	num2 = 149
																	imageFile2 = array5(num5)
																End If
																IL_D14:
																num2 = 150
																Me.ReplaceWithImage(text2, imageFile2, Conversions.ToInteger(array3(2)), Conversions.ToInteger(array3(3)))
															Else
																IL_D3B:
																num2 = 152
																Me.Replace(text2, "")
															End If
														End If
													End If
												End If
											Else
												IL_D53:
												num2 = 154
												Me.Replace(text2, "")
											End If
										End If
									End If
								End If
							Else
								IL_D6B:
								num2 = 156
								If text3.StartsWith("%") Then
									IL_D82:
									num2 = 157
									text3 = text3.Substring(1)
									IL_D92:
									num2 = 158
									Dim array6 As String() = text3.Split(New Char() { ","c })
									IL_DAC:
									num2 = 159
									If array6.Length = 2 Then
										IL_DBC:
										num2 = 160
										array6(0) = array6(0).Trim()
										IL_DCF:
										num2 = 161
										array6(1) = array6(1).Trim()
										IL_DE2:
										num2 = 162
										Dim enumerator5 As IEnumerator = dr.BaseRow.Table.DataSet.Relations.GetEnumerator()
										While enumerator5.MoveNext()
											Dim obj5 As Object = enumerator5.Current
											Dim dataRelation3 As DataRelation = CType(obj5, DataRelation)
											IL_E17:
											num2 = 163
											If Operators.CompareString(dataRelation3.ParentTable.TableName, Me.O_.ooO_0_OOo., True) = 0 AndAlso Operators.CompareString(dataRelation3.ChildTable.TableName, array6(0), True) = 0 Then
												IL_E55:
												num2 = 164
												Dim filter As String = Oo00.oo0o.O0O_0__.(dr.BaseRow, array6(0))
												IL_E6C:
												num2 = 165
												If array6(1).StartsWith(":") Then
													IL_E82:
													num2 = 166
													array6(1) = array6(1).Substring(1)
													IL_E96:
													num2 = 167
													Dim a_3 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRelation3.ChildTable.Compute(array6(1), filter)))
													IL_EBA:
													num2 = 168
													Dim repaceText3 As String = ""
													IL_EC7:
													num2 = 169
													O_O0OO.o.00O_O.(a_3, repaceText3)
													IL_ED7:
													num2 = 170
													Me.Replace(text2, repaceText3)
												Else
													IL_EE9:
													num2 = 172
													Me.Replace(text2, dataRelation3.ChildTable.Compute(array6(1), filter).ToString())
												End If
											End If
											IL_F0E:
											num2 = 173
										End While
										IL_F20:
										num2 = 174
										If TypeOf enumerator5 Is IDisposable Then
											TryCast(enumerator5, IDisposable).Dispose()
										End If
									End If
								Else
									IL_F43:
									num2 = 176
									If dr.DataTable.DataCols.Contains(text3) Then
										IL_F60:
										num2 = 177
										If dr.DataTable.DataCols(text3).IsDate Then
											IL_F82:
											num2 = 178
											If dr.get_IsNull(text3) Then
												IL_F92:
												num2 = 179
												text3 = ""
											Else
												IL_FA4:
												num2 = 181
												Dim dateTime As DateTime = Conversions.ToDate(dr(text3))
												IL_FB9:
												num2 = 182
												If DateTime.Compare(dateTime.[Date], dateTime) = 0 Then
													IL_FCF:
													num2 = 183
													text3 = Strings.Format(dateTime, "yyyy-MM-dd")
												Else
													IL_FED:
													num2 = 185
													text3 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss")
												End If
											End If
										Else
											IL_100B:
											num2 = 187
											If dr.DataTable.DataCols(text3).ExtendType = 8 Then
												IL_102B:
												num2 = 188
												If dr.get_IsNull(text3) Then
													IL_103B:
													num2 = 189
													text3 = ""
												Else
													IL_104A:
													num2 = 191
													Dim a_4 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dr(text3)))
													IL_1064:
													num2 = 192
													O_O0OO.o.00O_O.(a_4, text3)
												End If
											Else
												IL_1076:
												num2 = 194
												If dr.get_IsNull(text3) Then
													IL_1086:
													num2 = 195
													text3 = ""
												Else
													IL_1095:
													num2 = 197
													text3 = dr(text3).ToString()
												End If
											End If
										End If
										IL_10AA:
										num2 = 198
										Me.Replace(text2, text3)
									End If
								End If
							End If
						End If
					Else
						IL_10BF:
						num2 = 200
						If text3.StartsWith("<") AndAlso text3.EndsWith(">") Then
							IL_10E7:
							num2 = 201
							If Operators.CompareString(text3, "<index>", True) <> 0 Then
								IL_1114:
								num2 = 204
								text3 = text3.Trim().Trim(New Char() { "<"c }).Trim(New Char() { ">"c })
								IL_1143:
								num2 = 205
								Dim flag6 As Boolean = False
								IL_114C:
								num2 = 206
								Dim num6 As Integer = text3.IndexOf("[")
								While True
									IL_12B6:
									num2 = 208
									If num6 < 0 Then
										Exit For
									End If
									IL_1165:
									num2 = 209
									Dim num7 As Integer = text3.IndexOf("]", num6)
									IL_117B:
									num2 = 210
									If num7 <= 0 Then
										Exit For
									End If
									IL_1189:
									num2 = 211
									Dim text4 As String = text3.Substring(num6, num7 - num6 + 1)
									IL_11A1:
									num2 = 212
									Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Me.O.0o0O__o.(text4, dr))
									IL_11B7:
									num2 = 213
									If Not(TypeOf objectValue2 Is String) OrElse Operators.CompareString(objectValue2.ToString(), text4, True) <> 0 Then
										IL_11DA:
										num2 = 215
										If TypeOf objectValue2 Is String AndAlso Operators.CompareString(objectValue2.ToString(), "Error$$bnf", True) = 0 Then
											GoTo IL_11FD
										End If
										IL_120B:
										num2 = 219
										If TypeOf objectValue2 Is String Then
											IL_121A:
											num2 = 220
											text3 = text3.Replace(text4, """" + objectValue2.ToString() + """")
										Else
											IL_1243:
											num2 = 222
											If TypeOf objectValue2 Is DateTime Then
												IL_1252:
												num2 = 223
												text3 = text3.Replace(text4, "#" + objectValue2.ToString() + "#")
											Else
												IL_127B:
												num2 = 225
												text3 = text3.Replace(text4, objectValue2.ToString())
											End If
										End If
									End If
									IL_1293:
									num2 = 226
									num6 = text3.IndexOf("[", num6 + objectValue2.ToString().Length)
								End While
								IL_12C4:
								num2 = 230
								If flag6 Then
									IL_12CE:
									num2 = 231
									text3 = ""
									GoTo IL_1329
								End If
								IL_12DD:
								num2 = 233
								Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(OO_00oOO.Eval2(text3.Replace("\>", ">").Replace("\<", "<"), dr))
								IL_1310:
								num2 = 234
								If objectValue3 IsNot Nothing Then
									IL_131A:
									num2 = 235
									text3 = objectValue3.ToString()
									GoTo IL_1329
								End If
								GoTo IL_1329
								IL_11FD:
								num2 = 216
								flag6 = True
								GoTo IL_12C4
							End If
							IL_10FC:
							num2 = 202
							text3 = Me.OOo_oooOo_.0Oo..ToString()
							IL_1329:
							num2 = 236
							Me.Replace(text2, text3)
						End If
					End If
					IL_1339:
					num2 = 237
				End While
				IL_134B:
				num2 = 238
				CType(enumerator2, IDisposable).Dispose()
				IL_135E:
				num2 = 239
				Me.O_.ooO_0_OOo..Clear()
				IL_136F:
				GoTo IL_1781
				IL_1374:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_1742:
				GoTo IL_1776
				IL_1744:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1754:
			Catch obj7 When endfilter(TypeOf obj6 Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj7, Exception)
				GoTo IL_1744
			End Try
			IL_1776:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1781:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004B51 RID: 19281 RVA: 0x001FE6D8 File Offset: 0x001FC8D8
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataRow) As Object
			Dim num As Integer
			Dim result As Object
			Dim num6 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = A_0.Trim()
				IL_11:
				num2 = 3
				text = text.Trim().Trim(New Char() { "["c }).Trim(New Char() { "]"c })
				IL_3C:
				num2 = 4
				If Not text.StartsWith("@") Then
					GoTo IL_4F9
				End If
				IL_4F:
				num2 = 5
				text = text.Substring(1)
				IL_5B:
				num2 = 6
				Dim array As String() = text.Split(New Char() { ","c })
				IL_71:
				num2 = 7
				If array.Length <> 3 OrElse Not Versioned.IsNumeric(array(2)) Then
					GoTo IL_2F3
				End If
				IL_8B:
				num2 = 8
				array(0) = array(0).Trim()
				IL_9A:
				num2 = 9
				array(1) = array(1).Trim()
				IL_AA:
				num2 = 10
				Dim flag As Boolean = array(0).StartsWith("&")
				IL_BD:
				num2 = 11
				If Not flag Then
					GoTo IL_D5
				End If
				IL_C4:
				num2 = 12
				array(0) = array(0).Substring(1)
				IL_D5:
				num2 = 13
				If Me.O000.OO0__OoO..ContainsKey(array(0)) Then
					GoTo IL_193
				End If
				IL_EC:
				num2 = 14
				Dim enumerator As IEnumerator = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					IL_11B:
					num2 = 15
					If Operators.CompareString(dataRelation.ParentTable.TableName, Me.O_.ooO_0_OOo., True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, array(0), True) = 0 Then
						IL_150:
						num2 = 16
						Me.O000.OO0__OoO..Add(array(0), A_1.BaseRow.GetChildRows(dataRelation))
					End If
					IL_16F:
					num2 = 17
				End While
				IL_17B:
				num2 = 18
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_193:
				num2 = 19
				Dim num3 As Integer = 0
				IL_199:
				num2 = 20
				If array(1).IndexOf("&") <= 0 Then
					GoTo IL_1F0
				End If
				IL_1AD:
				num2 = 21
				Integer.TryParse(array(1).Substring(array(1).IndexOf("&") + 1), num3)
				IL_1D1:
				num2 = 22
				array(1) = array(1).Substring(0, array(1).IndexOf("&"))
				IL_1F0:
				num2 = 23
				If Not Me.O000.OO0__OoO..ContainsKey(array(0)) OrElse Not OO_00oOO.DataTables(array(0)).DataCols.Contains(array(1)) Then
					GoTo IL_61D
				End If
				IL_228:
				num2 = 24
				If Me.O000.OO0__OoO.(array(0)).Length >= Conversions.ToInteger(array(2)) Then
					GoTo IL_255
				End If
				IL_247:
				num2 = 25
				result = "Error$$bnf"
				GoTo IL_622
				IL_255:
				num2 = 27
				If Not Me.O000.OO0__OoO.(array(0))(Conversions.ToInteger(array(2)) - 1).IsNull(array(1)) Then
					GoTo IL_28C
				End If
				IL_27E:
				num2 = 28
				result = "Error$$bnf"
				GoTo IL_622
				IL_28C:
				num2 = 30
				If array.Length <> 3 Then
					GoTo IL_61D
				End If
				IL_299:
				num2 = 31
				If Conversions.ToInteger(array(2)) > Me.O000.OO0__OoO.(array(0)).Length Then
					GoTo IL_2E5
				End If
				IL_2B8:
				num2 = 32
				result = Me.O000.OO0__OoO.(array(0))(Conversions.ToInteger(array(2)) - 1)(array(1))
				GoTo IL_622
				IL_2E5:
				num2 = 34
				result = "Error$$bnf"
				GoTo IL_622
				IL_2F3:
				num2 = 36
				If array.Length <> 2 Then
					GoTo IL_61D
				End If
				IL_300:
				num2 = 37
				array(0) = array(0).Trim()
				IL_310:
				num2 = 38
				array(1) = array(1).Trim()
				IL_320:
				num2 = 39
				Dim flag2 As Boolean = array(0).StartsWith("&")
				IL_333:
				num2 = 40
				If Not flag2 Then
					GoTo IL_34B
				End If
				IL_33A:
				num2 = 41
				array(0) = array(0).Substring(1)
				IL_34B:
				num2 = 42
				If Me.O_.ooO_0_OOo..ContainsKey(array(0)) Then
					GoTo IL_409
				End If
				IL_362:
				num2 = 43
				Dim enumerator2 As IEnumerator = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRelation2 As DataRelation = CType(obj2, DataRelation)
					IL_391:
					num2 = 44
					If Operators.CompareString(dataRelation2.ParentTable.TableName, array(0), True) = 0 AndAlso Operators.CompareString(dataRelation2.ChildTable.TableName, Me.O_.ooO_0_OOo., True) = 0 Then
						IL_3C6:
						num2 = 45
						Me.O_.ooO_0_OOo..Add(array(0), A_1.BaseRow.GetParentRow(dataRelation2))
					End If
					IL_3E5:
					num2 = 46
				End While
				IL_3F1:
				num2 = 47
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_409:
				num2 = 48
				Dim num4 As Integer = 0
				IL_40F:
				num2 = 49
				If array(1).IndexOf("&") <= 0 Then
					GoTo IL_466
				End If
				IL_423:
				num2 = 50
				Integer.TryParse(array(1).Substring(array(1).IndexOf("&") + 1), num4)
				IL_447:
				num2 = 51
				array(1) = array(1).Substring(0, array(1).IndexOf("&"))
				IL_466:
				num2 = 52
				If Not Me.O_.ooO_0_OOo..ContainsKey(array(0)) OrElse Not OO_00oOO.DataTables(array(0)).DataCols.Contains(array(1)) Then
					GoTo IL_61D
				End If
				IL_49E:
				num2 = 53
				Dim dataRow As DataRow = Me.O_.ooO_0_OOo.(array(0))
				IL_4B2:
				num2 = 54
				If dataRow Is Nothing Then
					GoTo IL_4EB
				End If
				IL_4B9:
				num2 = 55
				If Not dataRow.IsNull(array(1)) Then
					GoTo IL_4D7
				End If
				IL_4C9:
				num2 = 56
				result = "Error$$bnf"
				GoTo IL_622
				IL_4D7:
				num2 = 58
				result = dataRow(array(1))
				GoTo IL_622
				IL_4EB:
				num2 = 60
				result = "Error$$bnf"
				GoTo IL_622
				IL_4F9:
				num2 = 62
				If Not text.StartsWith("%") Then
					GoTo IL_61D
				End If
				IL_50D:
				num2 = 63
				text = text.Substring(1)
				IL_51A:
				num2 = 64
				Dim array2 As String() = text.Split(New Char() { ","c })
				IL_531:
				num2 = 65
				If array2.Length <> 2 Then
					GoTo IL_612
				End If
				IL_53E:
				num2 = 66
				array2(0) = array2(0).Trim()
				IL_54E:
				num2 = 67
				array2(1) = array2(1).Trim()
				IL_55E:
				num2 = 68
				Dim enumerator3 As IEnumerator = A_1.BaseRow.Table.DataSet.Relations.GetEnumerator()
				While enumerator3.MoveNext()
					Dim obj3 As Object = enumerator3.Current
					Dim dataRelation3 As DataRelation = CType(obj3, DataRelation)
					IL_58D:
					num2 = 69
					If Operators.CompareString(dataRelation3.ParentTable.TableName, Me.O_.ooO_0_OOo., True) = 0 AndAlso Operators.CompareString(dataRelation3.ChildTable.TableName, array2(0), True) = 0 Then
						IL_5C2:
						num2 = 70
						Dim filter As String = Oo00.oo0o.O0O_0__.(A_1.BaseRow, array2(0))
						IL_5D6:
						num2 = 71
						result = dataRelation3.ChildTable.Compute(array2(1), filter)
						GoTo IL_622
					End If
					IL_5EE:
					num2 = 72
				End While
				IL_5FA:
				num2 = 73
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
				IL_612:
				num2 = 74
				result = "Error$$bnf"
				GoTo IL_622
				IL_61D:
				num2 = 75
				result = A_0
				IL_622:
				GoTo IL_7A4
				IL_627:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_765:
				GoTo IL_799
				IL_767:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_777:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_767
			End Try
			IL_799:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7A4:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06004B52 RID: 19282 RVA: 0x001FEEB0 File Offset: 0x001FD0B0
		Public Sub Quit()
			Me.O_.ooO_0_OOo..Save()
			Dim documents As Documents = WordReport.app.Documents
			Dim obj As Object = 1
			Dim document As _Document = documents(obj)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			document.Close(objectValue, objectValue2, objectValue3)
			Dim application As _Application = WordReport.app
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			application.Quit(objectValue3, objectValue2, objectValue)
			Me.O_.ooO_0_OOo. = Nothing
			WordReport.app = Nothing
			GC.Collect()
			GC.Collect()
			GC.Collect()
			GC.Collect()
		End Sub

		' Token: 0x06004B53 RID: 19283 RVA: 0x001FEF60 File Offset: 0x001FD160
		Public Sub QuitWithoutSave()
			Dim documents As Documents = WordReport.app.Documents
			Dim obj As Object = 1
			Dim document As _Document = documents(obj)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			document.Close(objectValue, objectValue2, objectValue3)
			Dim application As _Application = WordReport.app
			objectValue3 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value)
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value)
			application.Quit(objectValue3, objectValue2, objectValue)
			Me.O_.ooO_0_OOo. = Nothing
			WordReport.app = Nothing
			GC.Collect()
			GC.Collect()
			GC.Collect()
			GC.Collect()
		End Sub

		' Token: 0x06004B54 RID: 19284 RVA: 0x001FF004 File Offset: 0x001FD204
		Public Sub Show()
			Dim obj As Object = 0
			Dim selection As Selection = WordReport.app.Selection
			Dim obj2 As Object = 6
			selection.HomeKey(obj2, obj)
			Me.O_.ooO_0_OOo..Save()
			WordReport.app.Visible = True
			Dim num As Integer = OO_00oOO.FindAppWindow(OO_00oOO.FileSys.GetName(Me.O_.ooO_0_OOo..FullName))
			If num > 0 Then
				WordReport.SetForegroundWindow(num)
				WordReport.SetActiveWindow(num)
			End If
		End Sub

		' Token: 0x1700109C RID: 4252
		' (get) Token: 0x06004B55 RID: 19285 RVA: 0x001FF076 File Offset: 0x001FD276
		' (set) Token: 0x06004B56 RID: 19286 RVA: 0x001FF07E File Offset: 0x001FD27E
		Public Property RecordsOnEachPage As Integer
			Get
				Return Me.oO.0O_00ooO_O.
			End Get
			Set(value As Integer)
				Me.oO.0O_00ooO_O. = value
			End Set
		End Property

		' Token: 0x06004B57 RID: 19287 RVA: 0x001FF087 File Offset: 0x001FD287
		Private Shared Sub <<EMPTY_NAME>>()
			WordReport.app = Nothing
		End Sub

		' Token: 0x06004B58 RID: 19288 RVA: 0x001FF090 File Offset: 0x001FD290
		Public Sub SaveToPDF(fileName As String)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(fileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Dim o_.ooO_0_OOo. As _Document = Me.O_.ooO_0_OOo.
			Dim wdExportFormat As WdExportFormat = 17
			Dim flag As Boolean = False
			Dim wdExportOptimizeFor As WdExportOptimizeFor = 0
			Dim wdExportRange As WdExportRange = 0
			Dim num As Integer = 1
			Dim num2 As Integer = 1
			Dim wdExportItem As WdExportItem = 0
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = True
			Dim wdExportCreateBookmarks As WdExportCreateBookmarks = 0
			Dim flag4 As Boolean = True
			Dim flag5 As Boolean = True
			Dim flag6 As Boolean = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			o_.ooO_0_OOo..ExportAsFixedFormat(fileName, wdExportFormat, flag, wdExportOptimizeFor, wdExportRange, num, num2, wdExportItem, flag2, flag3, wdExportCreateBookmarks, flag4, flag5, flag6, objectValue)
		End Sub

		' Token: 0x06004B59 RID: 19289 RVA: 0x001FF0EC File Offset: 0x001FD2EC
		Public Sub SaveToHTML(fileName As String)
			Dim obj As Object = fileName
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(fileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Dim o_.ooO_0_OOo. As _Document = Me.O_.ooO_0_OOo.
			Dim obj2 As Object = 8
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim obj3 As Object = False
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			o_.ooO_0_OOo..SaveAs2(obj, obj2, objectValue, objectValue2, obj3, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14)
		End Sub

		' Token: 0x06004B5A RID: 19290 RVA: 0x001FF204 File Offset: 0x001FD404
		Public Sub SaveToMHT(fileName As String)
			Dim obj As Object = fileName
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(fileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Dim o_.ooO_0_OOo. As _Document = Me.O_.ooO_0_OOo.
			Dim obj2 As Object = 9
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim obj3 As Object = False
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			o_.ooO_0_OOo..SaveAs2(obj, obj2, objectValue, objectValue2, obj3, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14)
		End Sub

		' Token: 0x06004B5B RID: 19291 RVA: 0x001FF31C File Offset: 0x001FD51C
		Public Sub Print()
			Dim o_.ooO_0_OOo. As _Document = Me.O_.ooO_0_OOo.
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue5 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue6 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue7 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue8 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue9 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue10 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue11 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue12 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue13 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue14 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue15 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue16 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue17 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			Dim objectValue18 As Object = RuntimeHelpers.GetObjectValue(Missing.Value)
			o_.ooO_0_OOo..PrintOut(objectValue, objectValue2, objectValue3, objectValue4, objectValue5, objectValue6, objectValue7, objectValue8, objectValue9, objectValue10, objectValue11, objectValue12, objectValue13, objectValue14, objectValue15, objectValue16, objectValue17, objectValue18)
		End Sub

		' Token: 0x06004B5C RID: 19292 RVA: 0x001FF42C File Offset: 0x001FD62C
		Public Sub Preview()
			Me.O_.ooO_0_OOo..PrintPreview()
		End Sub

		' Token: 0x06004B5D RID: 19293 RVA: 0x001FF43C File Offset: 0x001FD63C
		<oO0oooo("3310")>
		Public Sub AddDataTable(TableName As String, ConnectionName As String, SelectString As String)
			Me.O_.ooO_0_OOo. = True
			Dim o0__oo0OOo As o0__oo0OOo = New o0__oo0OOo()
			o0__oo0OOo.O_0O00O0_.oOo. = ConnectionName
			o0__oo0OOo.O_oo._o. = TableName
			o0__oo0OOo.Oo.__0o0_. = SelectString
			Me.O000.OO0__OoO..Add(o0__oo0OOo)
		End Sub

		' Token: 0x06004B5E RID: 19294 RVA: 0x001FF478 File Offset: 0x001FD678
		<oO0oooo("3310")>
		Public Sub AddDataTable(TableName As String, DataTable As DataTable)
			If DataTable.BaseTable.DataSet Is Nothing Then
				Me.O_.ooO_0_OOo. = True
				Dim o0__oo0OOo As o0__oo0OOo = New o0__oo0OOo()
				o0__oo0OOo.O_oo._o. = TableName
				o0__oo0OOo.oo0_O0_000o.0o. = DataTable
				Me.O000.OO0__OoO..Add(o0__oo0OOo)
				Return
			End If
			OO_00oOO.PopMessage("添加表失败，此表已属于某DataSet", "提示", 0, -1)
		End Sub

		' Token: 0x06004B5F RID: 19295 RVA: 0x001FF4CB File Offset: 0x001FD6CB
		<oO0oooo("3310")>
		Public Sub AddRelation(ParentTable As String, ParentColumn As String, ChildTable As String, ChildColumn As String)
			Me.AddRelation(ParentTable, New String() { ParentColumn }, ChildTable, New String() { ChildColumn })
		End Sub

		' Token: 0x06004B60 RID: 19296 RVA: 0x001FF4EC File Offset: 0x001FD6EC
		<oO0oooo("3310")>
		Public Sub AddRelation(ParentTable As String, ParentColumns As String(), ChildTable As String, ChildColumns As String())
			Me.O_.ooO_0_OOo. = True
			Dim o_0OO As O_0OO = New O_0OO()
			o_0OO.O_oo._o. = ParentTable
			o_0OO.O_oo._o. = ParentColumns
			o_0OO.O000000o0.oO0o. = ChildTable
			o_0OO.O000000o0.oO0o. = ChildColumns
			Me.O000.OO0__OoO..Add(o_0OO)
		End Sub

		' Token: 0x06004B61 RID: 19297 RVA: 0x001FF530 File Offset: 0x001FD730
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				For Each o_0OO As O_0OO In Me.O000.OO0__OoO.
					If Operators.CompareString(o_0OO.O_oo._o., A_0, True) = 0 AndAlso Operators.CompareString(o_0OO.O000000o0.oO0o., A_1, True) = 0 Then
						Return True
					End If
				Next
			Finally
				Dim enumerator As List(Of O_0OO).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return False
		End Function

		' Token: 0x06004B62 RID: 19298 RVA: 0x001FF5A4 File Offset: 0x001FD7A4
		Private Sub <<EMPTY_NAME>>()
			If Me.O_.ooO_0_OOo. Then
				Me.O_.ooO_0_OOo. = False
				Try
					For Each o0__oo0OOo As o0__oo0OOo In Me.O000.OO0__OoO.
						If Me.O_.ooO_0_OOo. Is Nothing Then
							Me.O_.ooO_0_OOo. = New DataSet()
							Me.O_.ooO_0_OOo..EnforceConstraints = False
						End If
						If Operators.CompareString(o0__oo0OOo.Oo.__0o0_., "", True) > 0 Then
							Dim dataTable As DataTable = New SQLCommand(o0__oo0OOo.Oo.__0o0_., o0__oo0OOo.O_0O00O0_.oOo.).ExecuteReader(False)
							dataTable.BaseTable.TableName = o0__oo0OOo.O_oo._o.
							Me.O_.ooO_0_OOo..Tables.Add(dataTable.BaseTable)
							Me.o__o.OOoO_..add(o0__oo0OOo.O_oo._o., dataTable)
						ElseIf o0__oo0OOo.oo0_O0_000o.0o. IsNot Nothing Then
							Me.O_.ooO_0_OOo..Tables.Add(o0__oo0OOo.oo0_O0_000o.0o..BaseTable)
							o0__oo0OOo.oo0_O0_000o.0o..BaseTable.TableName = o0__oo0OOo.O_oo._o.
							Me.o__o.OOoO_..add(o0__oo0OOo.O_oo._o., o0__oo0OOo.oo0_O0_000o.0o.)
						End If
					Next
				Finally
					Dim enumerator As List(Of o0__oo0OOo).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				If Me.O000.OO0__OoO..Count > 0 Then
					Try
						For Each o_0OO As O_0OO In Me.O000.OO0__OoO.
							If Not Me.O_.ooO_0_OOo..Tables.Contains(o_0OO.O_oo._o..ToLower()) OrElse Not Me.O_.ooO_0_OOo..Tables.Contains(o_0OO.O000000o0.oO0o.) OrElse o_0OO.O_oo._o..Length <> o_0OO.O000000o0.oO0o..Length OrElse o_0OO.O_oo._o..Length = 0 Then
								OO_00oOO.PopMessage("创建关联失败!", "提示", 0, -1)
								Me.O_.ooO_0_OOo..Reset()
								Return
							End If
							Dim list As List(Of DataColumn) = New List(Of DataColumn)()
							Dim list2 As List(Of DataColumn) = New List(Of DataColumn)()
							Dim num As Integer = o_0OO.O_oo._o..Length - 1
							For i As Integer = 0 To num
								If Me.O_.ooO_0_OOo..Tables(o_0OO.O_oo._o.).Columns(o_0OO.O_oo._o.(i)).DataType IsNot Me.O_.ooO_0_OOo..Tables(o_0OO.O000000o0.oO0o.).Columns(o_0OO.O000000o0.oO0o.(i)).DataType Then
									OO_00oOO.PopMessage("关联列数据类型不匹配!", "提示", 0, -1)
									Me.O_.ooO_0_OOo..Reset()
									Return
								End If
								list.Add(Me.O_.ooO_0_OOo..Tables(o_0OO.O_oo._o.).Columns(o_0OO.O_oo._o.(i)))
								list2.Add(Me.O_.ooO_0_OOo..Tables(o_0OO.O000000o0.oO0o.).Columns(o_0OO.O000000o0.oO0o.(i)))
							Next
							Dim dataRelation As DataRelation = New DataRelation(o_0OO.O000000o0.oO0o., list.ToArray(), list2.ToArray())
							dataRelation.RelationName = OoOo0O.OO_o.0o_O.(10)
							Me.O_.ooO_0_OOo..Relations.Add(dataRelation)
						Next
					Finally
						Dim enumerator2 As List(Of O_0OO).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
				End If
				Try
					For Each dataTable2 As DataTable In Me.o__o.OOoO_.._List.Values
						If OO_00oOO.DataTables.Contains(dataTable2.BaseTable.TableName) Then
							Dim dataTable3 As DataTable = OO_00oOO.DataTables(dataTable2.BaseTable.TableName)
							Try
								For Each dataCol As DataCol In dataTable2.DataCols
									If dataTable3.DataCols.Contains(dataCol.Name) Then
										dataCol.ExtendType = dataTable3.DataCols(dataCol.Name).ExtendType
										dataCol.Remote = dataTable3.DataCols(dataCol.Name).Remote
										If dataCol.Remote And dataTable3.DataCols(dataCol.Name).FTPClient IsNot Nothing Then
											dataCol.FTPClient = dataTable3.DataCols(dataCol.Name).FTPClient.O_O_0_O0.oOO.()
										End If
									End If
								Next
							Finally
								Dim enumerator4 As IEnumerator(Of DataCol)
								If enumerator4 IsNot Nothing Then
									enumerator4.Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator3 As Dictionary(Of String, DataTable).ValueCollection.Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				Me.O_.ooO_0_OOo. = Me.O_.ooO_0_OOo..Tables(0).TableName
			End If
		End Sub

		' Token: 0x04001EDE RID: 7902
		<CompilerGenerated()>
		<AccessedThroughProperty("app")>
		Private Shared <<EMPTY_NAME>> As Application

		' Token: 0x04001EDF RID: 7903
		Private <<EMPTY_NAME>> As Document

		' Token: 0x04001EE0 RID: 7904
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04001EE1 RID: 7905
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001EE2 RID: 7906
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001EE3 RID: 7907
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001EE4 RID: 7908
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001EE5 RID: 7909
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001EE6 RID: 7910
		Private <<EMPTY_NAME>> As Dictionary(Of String, DataRow())

		' Token: 0x04001EE7 RID: 7911
		Private <<EMPTY_NAME>> As Dictionary(Of String, DataRow)

		' Token: 0x04001EE8 RID: 7912
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04001EE9 RID: 7913
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04001EEA RID: 7914
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001EEB RID: 7915
		Friend <<EMPTY_NAME>> As DataSet

		' Token: 0x04001EEC RID: 7916
		Private <<EMPTY_NAME>> As tempDataTableCollection

		' Token: 0x04001EED RID: 7917
		Private <<EMPTY_NAME>> As List(Of O_0OO)

		' Token: 0x04001EEE RID: 7918
		Private <<EMPTY_NAME>> As List(Of o0__oo0OOo)

		' Token: 0x04001EEF RID: 7919
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
