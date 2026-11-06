Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200031B RID: 795
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	<oO0oooo("0985")>
	Public Class UserFunctions
		' Token: 0x06002B26 RID: 11046 RVA: 0x0012DACD File Offset: 0x0012BCCD
		Public Sub New()
			Me.O._O_O_. = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
			Me.O__.00_00_o0_. = New Dictionary(Of String, String)()
			Me.O_.o__0O0_0oo. = RuntimeHelpers.GetObjectValue(New Object())
			Me.ThrowException = False
		End Sub

		' Token: 0x17000A35 RID: 2613
		' (get) Token: 0x06002B27 RID: 11047 RVA: 0x0012DB07 File Offset: 0x0012BD07
		' (set) Token: 0x06002B28 RID: 11048 RVA: 0x0012DB0F File Offset: 0x0012BD0F
		Public Property ThrowException As Boolean

		' Token: 0x06002B29 RID: 11049 RVA: 0x0012DB18 File Offset: 0x0012BD18
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Add(Name As String, Code As String)
			If o_O_o_oOoo__.O_o_._o0.(Name, "函数名称", 32, False) Then
				If Me.O._O_O_..ContainsKey(Name) Then
					Me.O._O_O_..Remove(Name)
				End If
				Me.O._O_O_..Add(Name, Code)
			End If
		End Sub

		' Token: 0x06002B2A RID: 11050 RVA: 0x0012DB52 File Offset: 0x0012BD52
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Clear()
			Me.O._O_O_..Clear()
		End Sub

		' Token: 0x06002B2B RID: 11051 RVA: 0x0012DB5F File Offset: 0x0012BD5F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Remove(Name As String)
			Me.O._O_O_..Remove(Name)
		End Sub

		' Token: 0x06002B2C RID: 11052 RVA: 0x0012DB6E File Offset: 0x0012BD6E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub Complie()
			Me.O__.00_00_o0_.()
		End Sub

		' Token: 0x06002B2D RID: 11053 RVA: 0x0012DB78 File Offset: 0x0012BD78
		Friend Sub <<EMPTY_NAME>>()
			Dim text As String = OO_00oOO.ProjectPath + "Bin\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Function.dll"
			If OO_00oOO.FileSys.FileExists(text) Then
				Dim rawAssembly As Byte() = File.ReadAllBytes(text)
				Me.O._O_O_. = Assembly.Load(rawAssembly)
			End If
		End Sub

		' Token: 0x06002B2E RID: 11054 RVA: 0x0012DBC4 File Offset: 0x0012BDC4
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean, Optional A_1 As String = "")
			Dim num As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.O__.00_00_o0_..Clear()
				IL_14:
				num2 = 3
				If Operators.CompareString(A_1, "", True) <> 0 Then
					GoTo IL_47
				End If
				IL_24:
				num2 = 4
				Dim text As String = OO_00oOO.ProjectPath + "Bin\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Function.dll"
				GoTo IL_4B
				IL_47:
				num2 = 6
				text = A_1
				IL_4B:
				num2 = 7
				If Not OO_00oOO.FileSys.FileExists(text) OrElse A_0 Then
					GoTo IL_7C
				End If
				IL_5D:
				num2 = 8
				Dim rawAssembly As Byte() = File.ReadAllBytes(text)
				IL_67:
				num2 = 9
				Me.O._O_O_. = Assembly.Load(rawAssembly)
				GoTo IL_648
				IL_7C:
				num2 = 11
				If Not OO_00oOO.FileSys.FileExists(text) OrElse A_0 Then
					GoTo IL_AF
				End If
				IL_8F:
				num2 = 12
				Dim rawAssembly2 As Byte() = File.ReadAllBytes(text)
				IL_9A:
				num2 = 13
				Me.O._O_O_. = Assembly.Load(rawAssembly2)
				GoTo IL_648
				IL_AF:
				num2 = 15
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o.00_0o0__OoO.())
				IL_C8:
				num2 = 16
				O_O0OO.O_O._Oo.()
				IL_D1:
				num2 = 17
				Me.O._O_O_. = Nothing
				IL_DB:
				num2 = 18
				Dim dataView As DataView = New DataView(dataTable, "[Type] = " + Conversions.ToString(9), "", DataViewRowState.CurrentRows)
				IL_FF:
				num2 = 19
				If dataView.Count = 0 Then
					GoTo IL_648
				End If
				IL_10E:
				num2 = 21
				o0_.o0o___.Ooo__Oo. = True
				IL_117:
				num2 = 22
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_121:
				num2 = 23
				If O_O0OO.O0_00o.o0__o..EncriptUserFunction OrElse dataView.Count <= 0 Then
					GoTo IL_1ED
				End If
				IL_140:
				num2 = 24
				O_O0OO.O0_00o.o0__o..EncriptUserFunction = True
				IL_14E:
				num2 = 25
				Dim enumerator As IEnumerator = dataView.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRowView As DataRowView = CType(obj, DataRowView)
					IL_16A:
					num2 = 26
					If Not dataRowView.Row.IsNull("Config") Then
						IL_180:
						num2 = 27
						dataRowView("Config") = O00.ooo000o_0.00o0.(dataRowView("Config").ToString(), "UserFunction", O_O0OO.O_O._Oo.())
					End If
					IL_1AF:
					num2 = 28
				End While
				IL_1BB:
				num2 = 29
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_1D3:
				num2 = 30
				O_O0OO.O0_00o.o0__o..O_O_.o.(False, False)
				IL_1E2:
				num2 = 31
				Oo00.o0_o._O_.(dataTable, True)
				IL_1ED:
				num2 = 32
				Dim text2 As String = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5)
				IL_20F:
				num2 = 33
				Dim text3 As String = O_O0OO.O_O._Oo.()
				IL_219:
				num2 = 34
				Dim text4 As String = text3.Substring(text3.Length - 5, 5)
				IL_22F:
				num2 = 35
				text4 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text4).Substring(0, 5)
				IL_247:
				num2 = 36
				Dim enumerator2 As IEnumerator = dataView.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRowView2 As DataRowView = CType(obj2, DataRowView)
					IL_266:
					num2 = 37
					Dim text5 As String = dataRowView2("Name").ToString()
					IL_27C:
					num2 = 38
					If text5.StartsWith("![") AndAlso text5.EndsWith("]!") Then
						IL_29B:
						num2 = 39
						text5 = text5.Trim(New Char() { "!"c }).TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
					Else
						IL_2D4:
						num2 = 41
						text5 = o0OoOOoOOo0.OO0._Oo0o.(text5)
					End If
					IL_2E0:
					num2 = 42
					If Not dataRowView2.Row.IsNull("Config") Then
						IL_2F9:
						num2 = 43
						Dim text6 As String = dataRowView2("Config").ToString()
						IL_30F:
						num2 = 44
						Dim text7 As String = text3
						IL_316:
						num2 = 45
						Dim text8 As String = ""
						IL_320:
						num2 = 46
						If text6.StartsWith("![") AndAlso text6.EndsWith("]!") Then
							IL_33F:
							num2 = 47
							text7 = text4
							IL_346:
							num2 = 48
							text6 = text6.Trim(New Char() { "!"c }).TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
							IL_37D:
							num2 = 49
							text8 = O00.oO_.0o_oo_0O_.(text6, text7, "UserFunction")
						Else
							IL_395:
							num2 = 51
							If text6.StartsWith("[") AndAlso text6.EndsWith("]") Then
								IL_3B4:
								num2 = 52
								text7 = text2
								IL_3BB:
								num2 = 53
								text6 = text6.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
							Else
								IL_3E4:
								num2 = 55
								If text6.StartsWith("{") AndAlso text6.EndsWith("}") Then
									IL_403:
									num2 = 56
									text7 = text3.Substring(0, 5)
									IL_411:
									num2 = 57
									text6 = text6.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
								End If
							End If
							IL_438:
							num2 = 58
							text8 = O00.oO_.0o_oo_0O_.(text6, "UserFunction", text7)
						End If
						IL_44B:
						num2 = 59
						If Operators.CompareString(text8, "", True) > 0 Then
							IL_45E:
							num2 = 60
							text8 = text8.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
						End If
						IL_47B:
						num2 = 61
						If text8.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase) Then
							IL_48D:
							num2 = 62
							stringBuilder.Append("Public Async Function " + text5 + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)")
						Else
							IL_4AB:
							num2 = 64
							stringBuilder.Append("Public Function " + text5 + "(ByVal Args() As Object) As Object")
						End If
						IL_4C7:
						num2 = 65
						stringBuilder.Append(vbCrLf)
						IL_4D7:
						num2 = 66
						stringBuilder.Append(text8)
						IL_4E4:
						num2 = 67
						stringBuilder.Append(vbCrLf)
						IL_4F4:
						num2 = 68
						stringBuilder.Append("End Function")
						IL_504:
						num2 = 69
						stringBuilder.Append(vbCrLf)
						IL_514:
						num2 = 70
						stringBuilder.AppendLine("Public Async Function ____" + text5 + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)")
						IL_530:
						num2 = 71
						stringBuilder.AppendLine("Return Await Threading.Tasks.Task.Run(Async Function() ")
						IL_540:
						num2 = 72
						If text8.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase) Then
							IL_552:
							num2 = 73
							stringBuilder.AppendLine("Return Await " + text5 + "(Args)")
						Else
							IL_570:
							num2 = 75
							stringBuilder.AppendLine("Return  " + text5 + "(Args)")
						End If
						IL_58C:
						num2 = 76
						stringBuilder.AppendLine("End Function)")
						IL_59C:
						num2 = 77
						stringBuilder.AppendLine("End Function")
						IL_5AC:
						num2 = 78
						stringBuilder.Append(vbCrLf)
					End If
					IL_5BC:
					num2 = 79
				End While
				IL_5CB:
				num2 = 80
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_5E3:
				num2 = 81
				Dim left As String = stringBuilder.ToString()
				IL_5EF:
				num2 = 82
				If Operators.CompareString(left, "", True) <= 0 Then
					GoTo IL_635
				End If
				IL_602:
				num2 = 83
				Me.O._O_O_. = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), text, O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
				GoTo IL_63F
				IL_635:
				num2 = 85
				Me.O._O_O_. = Nothing
				IL_63F:
				num2 = 86
				o0_.o0o___.Ooo__Oo. = False
				IL_648:
				GoTo IL_7F6
				IL_64D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_7B7:
				GoTo IL_7EB
				IL_7B9:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7C9:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_7B9
			End Try
			IL_7EB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7F6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002B2F RID: 11055 RVA: 0x0012E3EC File Offset: 0x0012C5EC
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.O__.00_00_o0_..Clear()
				IL_14:
				num2 = 3
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_1C:
				num2 = 4
				Me.oo0.OO_0oO0OoO. = Nothing
				IL_25:
				num2 = 5
				If Me.O._O_O_..Count = 0 Then
					GoTo IL_22C
				End If
				IL_37:
				num2 = 7
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator = Me.O._O_O_..Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_59:
					num2 = 8
					Dim str As String = o0OoOOoOOo0.OO0._Oo0o.(text)
					IL_64:
					num2 = 9
					Dim text2 As String = Me.O._O_O_.(text)
					IL_76:
					num2 = 10
					If Operators.CompareString(text2, "", True) > 0 Then
						IL_89:
						num2 = 11
						text2 = text2.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
					End If
					IL_A6:
					num2 = 12
					If text2.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase) Then
						IL_B8:
						num2 = 13
						stringBuilder.Append("Public Async Function " + str + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)")
					Else
						IL_D5:
						num2 = 15
						stringBuilder.Append("Public Function " + str + "(ByVal Args() As Object) As Object")
					End If
					IL_F0:
					num2 = 16
					stringBuilder.Append(vbCrLf)
					IL_FF:
					num2 = 17
					stringBuilder.Append(text2)
					IL_10B:
					num2 = 18
					stringBuilder.Append(vbCrLf)
					IL_11A:
					num2 = 19
					stringBuilder.Append("End Function")
					IL_129:
					num2 = 20
					stringBuilder.Append(vbCrLf)
					IL_138:
					num2 = 21
					stringBuilder.AppendLine("Public Async Function ____" + str + "(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)")
					IL_153:
					num2 = 22
					stringBuilder.AppendLine("Return Await Threading.Tasks.Task.Run(Async Function() ")
					IL_162:
					num2 = 23
					If text2.StartsWith("'''Async", StringComparison.OrdinalIgnoreCase) Then
						IL_174:
						num2 = 24
						stringBuilder.AppendLine("Return Await " + str + "(Args)")
					Else
						IL_191:
						num2 = 26
						stringBuilder.AppendLine("Return  " + str + "(Args)")
					End If
					IL_1AC:
					num2 = 27
					stringBuilder.AppendLine("End Function)")
					IL_1BB:
					num2 = 28
					stringBuilder.AppendLine("End Function")
					IL_1CA:
					num2 = 29
					stringBuilder.Append(vbCrLf)
					IL_1D9:
					num2 = 30
				End While
				IL_1E8:
				num2 = 31
				CType(enumerator, IDisposable).Dispose()
				IL_1F8:
				num2 = 32
				Me.oo0.OO_0oO0OoO. = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
				IL_22C:
				GoTo IL_302
				IL_231:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2C3:
				GoTo IL_2F7
				IL_2C5:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2D5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2C5
			End Try
			IL_2F7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_302:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06002B30 RID: 11056 RVA: 0x0012E720 File Offset: 0x0012C920
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Execute(ParamArray Args As Object()) As Object
			Dim result As Object
			If Args.Length = 0 Then
				result = Nothing
			Else
				Dim name As String = Conversions.ToString(Args(0))
				If Args.Length = 1 Then
					result = Me.Execute(name, New Object(-1) {})
				Else
					Dim array As Object() = New Object(Args.Length - 2 + 1 - 1) {}
					Dim num As Integer = Args.Length - 1
					For i As Integer = 1 To num
						array(i - 1) = RuntimeHelpers.GetObjectValue(Args(i))
					Next
					result = Me.Execute(name, array)
				End If
			End If
			Return result
		End Function

		' Token: 0x06002B31 RID: 11057 RVA: 0x0012E794 File Offset: 0x0012C994
		Public Function Execute(Name As String, ParamArray Args As Object()) As Object
			Dim name As String = Me.O._O_O_.(Name)
			Dim methodInfo As MethodInfo = Nothing
			If Me.O._O_O_. IsNot Nothing Then
				methodInfo = Me.O._O_O_..[GetType]("UserCode").GetMethod(name)
			End If
			If methodInfo Is Nothing Then
				If Me.oo0.OO_0oO0OoO. IsNot Nothing Then
					methodInfo = Me.oo0.OO_0oO0OoO..[GetType]("UserCode").GetMethod(name)
				End If
				If methodInfo Is Nothing Then
					MessageBox.Show("找不到自定义函数""" + Name + """！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return Nothing
				End If
			End If
			Try
				Return methodInfo.Invoke(Nothing, New Object() { Args })
			Catch ex As Exception
				If Me.ThrowException Then
					If ex.InnerException IsNot Nothing Then
						Throw ex.InnerException
					End If
					Throw ex
				Else
					ooO.oOo0Oo.o.(ex, "自定义函数," + Name)
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x06002B32 RID: 11058 RVA: 0x0012E874 File Offset: 0x0012CA74
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ExecuteAsync(ParamArray Args As Object()) As Object
			Dim result As Object
			If Args.Length = 0 Then
				result = Nothing
			Else
				Dim a_ As String = Conversions.ToString(Args(0))
				If Args.Length = 1 Then
					result = Me.O._O_O_.(a_, New Object(-1) {})
				Else
					Dim array As Object() = New Object(Args.Length - 2 + 1 - 1) {}
					Dim num As Integer = Args.Length - 1
					For i As Integer = 1 To num
						array(i - 1) = RuntimeHelpers.GetObjectValue(Args(i))
					Next
					result = Me.O._O_O_.(a_, array)
				End If
			End If
			Return result
		End Function

		' Token: 0x06002B33 RID: 11059 RVA: 0x0012E8E8 File Offset: 0x0012CAE8
		Private Function <<EMPTY_NAME>>(A_0 As String, ParamArray A_1 As Object()) As Task(Of Object)
			Dim o0OO0_oOoo As UserFunctions.o0OO0_oOoo = Nothing
			o0OO0_oOoo.o0.O_o_. = Me
			o0OO0_oOoo.o0.O_o_. = A_0
			o0OO0_oOoo.o0.O_o_. = A_1
			o0OO0_oOoo.o0.O_o_. = -1
			o0OO0_oOoo.O_.o__0O0_0oo. = AsyncTaskMethodBuilder(Of Object).Create()
			o0OO0_oOoo.O_.o__0O0_0oo..Start(Of UserFunctions.o0OO0_oOoo)(o0OO0_oOoo)
			Return o0OO0_oOoo.O_.o__0O0_0oo..Task
		End Function

		' Token: 0x06002B34 RID: 11060 RVA: 0x0012E944 File Offset: 0x0012CB44
		Public Function Contains(Name As String) As Boolean
			Dim name As String = Me.O._O_O_.(Name)
			Dim methodInfo As MethodInfo = Nothing
			If Me.O._O_O_. IsNot Nothing Then
				methodInfo = Me.O._O_O_..[GetType]("UserCode").GetMethod(name)
			End If
			If methodInfo Is Nothing AndAlso Me.oo0.OO_0oO0OoO. IsNot Nothing Then
				methodInfo = Me.oo0.OO_0oO0OoO..[GetType]("UserCode").GetMethod(name)
			End If
			Return methodInfo IsNot Nothing
		End Function

		' Token: 0x06002B35 RID: 11061 RVA: 0x0012E9A0 File Offset: 0x0012CBA0
		<oO0oooo("A3273")>
		Public Function AsyncExecute(Name As String, ParamArray Args As Object()) As Boolean
			Return ThreadPool.QueueUserWorkItem(AddressOf New UserFunctions.O0__(Name, Args).O_.o__0O0_0oo., Nothing)
		End Function

		' Token: 0x06002B36 RID: 11062 RVA: 0x0012E9BC File Offset: 0x0012CBBC
		<oO0oooo("A3273")>
		Public Function SyncExecute(Name As String, ParamArray Args As Object()) As Object
			Dim result As Object
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				Dim method As O0__00O__O0O = AddressOf Me.Execute
				result = OO_00oOO.BaseMainForm.Invoke(method, New Object() { Name, Args })
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06002B37 RID: 11063 RVA: 0x0012EA08 File Offset: 0x0012CC08
		<oO0oooo("A3273")>
		Public Sub BeginSyncExecute(Name As String, ParamArray Args As Object())
			If OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				Dim method As O0__00O__O0O = AddressOf Me.Execute
				OO_00oOO.BaseMainForm.BeginInvoke(method, New Object() { Name, Args })
			End If
		End Sub

		' Token: 0x06002B38 RID: 11064 RVA: 0x0012EA50 File Offset: 0x0012CC50
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim o_.o__0O0_0oo. As Object = Me.O_.o__0O0_0oo.
			ObjectFlowControl.CheckForSyncLockOnValueType(o_.o__0O0_0oo.)
			Dim text As String
			SyncLock o_.o__0O0_0oo.
				If Me.O__.00_00_o0_..ContainsKey(A_0) Then
					text = Me.O__.00_00_o0_.(A_0)
				Else
					text = o0OoOOoOOo0.OO0._Oo0o.(A_0)
					Me.O__.00_00_o0_..Add(A_0, text)
				End If
			End SyncLock
			Return text
		End Function

		' Token: 0x0400117E RID: 4478
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x0400117F RID: 4479
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04001180 RID: 4480
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04001181 RID: 4481
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)

		' Token: 0x04001182 RID: 4482
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04001183 RID: 4483
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0200031C RID: 796
		Friend Class O0__
			' Token: 0x06002B39 RID: 11065 RVA: 0x0012EAC4 File Offset: 0x0012CCC4
			Friend Sub New(A_0 As String, ParamArray A_1 As Object())
				Me.O_.o__0O0_0oo. = A_0
				Me.O_.o__0O0_0oo. = A_1
			End Sub

			' Token: 0x06002B3A RID: 11066 RVA: 0x0012EADA File Offset: 0x0012CCDA
			Friend Sub <<EMPTY_NAME>>()
				OO_00oOO.Functions.Execute(Me.O_.o__0O0_0oo., Me.O_.o__0O0_0oo.)
			End Sub

			' Token: 0x06002B3B RID: 11067 RVA: 0x0012EAF3 File Offset: 0x0012CCF3
			Friend Sub <<EMPTY_NAME>>(A_0 As Object)
				OO_00oOO.Functions.Execute(Me.O_.o__0O0_0oo., Me.O_.o__0O0_0oo.)
			End Sub

			' Token: 0x04001184 RID: 4484
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04001185 RID: 4485
			Friend <<EMPTY_NAME>> As Object()
		End Class
	End Class
End Namespace
