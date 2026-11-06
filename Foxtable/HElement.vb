Imports System
Imports System.ComponentModel
Imports System.Dynamic
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Xml.Linq
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json

Namespace Foxtable
	' Token: 0x020000E9 RID: 233
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class HElement
		Inherits DynamicObject

		' Token: 0x06000CD4 RID: 3284 RVA: 0x0005CF8D File Offset: 0x0005B18D
		Friend Sub New(A_0 As WebViewer, A_1 As String)
			Me.o___0o.00o0oO. = A_0
			Me.o___0o.00o0oO. = A_1
		End Sub

		' Token: 0x06000CD5 RID: 3285 RVA: 0x0005CFA3 File Offset: 0x0005B1A3
		Friend Sub New(A_0 As WebViewer, A_1 As String, A_2 As Boolean)
			Me.o___0o.00o0oO. = A_0
			Me.o___0o.00o0oO. = A_1
			Me.o___0o.00o0oO. = A_2
		End Sub

		' Token: 0x1700021F RID: 543
		' (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0005CFC0 File Offset: 0x0005B1C0
		Public ReadOnly Property style As CSSStyle
			Get
				If Me.o___0o.00o0oO. Is Nothing Then
					Me.o___0o.00o0oO. = New CSSStyle(Me)
				End If
				Return Me.o___0o.00o0oO.
			End Get
		End Property

		' Token: 0x06000CD7 RID: 3287 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim left As String = A_0.ToLower()
			Return Operators.CompareString(left, "attributes", True) = 0 OrElse Operators.CompareString(left, "childNodes", True) = 0 OrElse Operators.CompareString(left, "firstChild", True) = 0 OrElse Operators.CompareString(left, "lastChild", True) = 0 OrElse Operators.CompareString(left, "nextSibling", True) = 0 OrElse Operators.CompareString(left, "ownerDocument", True) = 0 OrElse Operators.CompareString(left, "parentNode", True) = 0 OrElse Operators.CompareString(left, "previousSibling", True) = 0 OrElse Operators.CompareString(left, "__proto__", True) = 0 OrElse Operators.CompareString(left, "constructor", True) = 0 OrElse Operators.CompareString(left, "prototype", True) = 0
		End Function

		' Token: 0x17000220 RID: 544
		' (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0005D094 File Offset: 0x0005B294
		Public ReadOnly Property localStorage As Object
			Get
				Return New HStorage(Me.o___0o.00o0oO., "localStorage")
			End Get
		End Property

		' Token: 0x17000221 RID: 545
		' (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0005D0A6 File Offset: 0x0005B2A6
		Public ReadOnly Property sessionStorage As Object
			Get
				Return New HStorage(Me.o___0o.00o0oO., "sessionStorage")
			End Get
		End Property

		' Token: 0x17000222 RID: 546
		' (get) Token: 0x06000CDA RID: 3290 RVA: 0x0005D0B8 File Offset: 0x0005B2B8
		Public ReadOnly Property length As Object
			Get
				Dim text As String = String.Format("{0}.length", Me.o___0o.00o0oO.)
				Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
			End Get
		End Property

		' Token: 0x17000223 RID: 547
		Public ReadOnly Default Property Item(A_0 As Integer) As Object
			Get
				Dim a_ As String = String.Format("{0}[{1}]", Me.o___0o.00o0oO., A_0)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000224 RID: 548
		' (get) Token: 0x06000CDC RID: 3292 RVA: 0x0005D114 File Offset: 0x0005B314
		Public ReadOnly Property caption As Object
			Get
				Dim a_ As String = String.Format("{0}.caption", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000225 RID: 549
		' (get) Token: 0x06000CDD RID: 3293 RVA: 0x0005D140 File Offset: 0x0005B340
		Public ReadOnly Property rows As Object
			Get
				Dim a_ As String = String.Format("{0}.rows", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_, True)
			End Get
		End Property

		' Token: 0x17000226 RID: 550
		' (get) Token: 0x06000CDE RID: 3294 RVA: 0x0005D16C File Offset: 0x0005B36C
		Public ReadOnly Property cells As Object
			Get
				Dim a_ As String = String.Format("{0}.cells", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_, True)
			End Get
		End Property

		' Token: 0x17000227 RID: 551
		' (get) Token: 0x06000CDF RID: 3295 RVA: 0x0005D198 File Offset: 0x0005B398
		Public ReadOnly Property tBodies As Object
			Get
				Dim a_ As String = String.Format("{0}.tBodies", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_, True)
			End Get
		End Property

		' Token: 0x17000228 RID: 552
		' (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0005D1C4 File Offset: 0x0005B3C4
		Public ReadOnly Property tHead As Object
			Get
				Dim a_ As String = String.Format("{0}.tHead", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000229 RID: 553
		' (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0005D1F0 File Offset: 0x0005B3F0
		Public ReadOnly Property dataset As Object
			Get
				Dim a_ As String = String.Format("{0}.dataset", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x1700022A RID: 554
		' (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0005D21C File Offset: 0x0005B41C
		Public ReadOnly Property validity As Object
			Get
				Dim a_ As String = String.Format("{0}.validity", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x1700022B RID: 555
		' (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0005D248 File Offset: 0x0005B448
		Public ReadOnly Property tFoot As Object
			Get
				Dim a_ As String = String.Format("{0}.tFoot", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x1700022C RID: 556
		' (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0005D274 File Offset: 0x0005B474
		Public ReadOnly Property parentElement As Object
			Get
				Dim a_ As String = String.Format("{0}.parentElement", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x1700022D RID: 557
		' (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		Public ReadOnly Property children As Object
			Get
				Dim a_ As String = String.Format("{0}.children", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_, True)
			End Get
		End Property

		' Token: 0x1700022E RID: 558
		' (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0005D2CC File Offset: 0x0005B4CC
		Public ReadOnly Property firstElementChild As Object
			Get
				Dim a_ As String = String.Format("{0}.firstElementChild", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0005D2F8 File Offset: 0x0005B4F8
		Public ReadOnly Property lastElementChild As Object
			Get
				Dim a_ As String = String.Format("{0}.lastElementChild", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000230 RID: 560
		' (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0005D324 File Offset: 0x0005B524
		Public ReadOnly Property previousElementSibling As Object
			Get
				Dim a_ As String = String.Format("{0}.previousElementSibling", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000231 RID: 561
		' (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0005D350 File Offset: 0x0005B550
		Public ReadOnly Property nextElementSibling As Object
			Get
				Dim a_ As String = String.Format("{0}.nextElementSibling", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_)
			End Get
		End Property

		' Token: 0x17000232 RID: 562
		' (get) Token: 0x06000CEA RID: 3306 RVA: 0x0005D37A File Offset: 0x0005B57A
		Public ReadOnly Property classList As cssClassList
			Get
				If Me.o___0o.00o0oO. Is Nothing Then
					Me.o___0o.00o0oO. = New cssClassList(Me)
				End If
				Return Me.o___0o.00o0oO.
			End Get
		End Property

		' Token: 0x17000233 RID: 563
		' (get) Token: 0x06000CEB RID: 3307 RVA: 0x0005D398 File Offset: 0x0005B598
		Public ReadOnly Property elements As Object
			Get
				Dim a_ As String = String.Format("{0}.elements", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., a_) With { .o0O.00_O. = True }
			End Get
		End Property

		' Token: 0x06000CEC RID: 3308 RVA: 0x0005D3CC File Offset: 0x0005B5CC
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overrides Function TryGetMember(binder As GetMemberBinder, ByRef result As Object) As Boolean
			Dim result2 As Boolean
			If Me.Ooo_.o_.(binder.Name) Then
				result2 = False
			Else
				Dim text As String
				If Me.o___0o.00o0oO. Then
					text = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
					text = text + vbCrLf + String.Format("elements[0]?.{0};", binder.Name)
				Else
					text = String.Format("{0}.{1}", Me.o___0o.00o0oO., binder.Name)
				End If
				If Me.o0O.00_O. Then
					result = New HElement(Me.o___0o.00o0oO., String.Format("{0}.{1}", Me.o___0o.00o0oO., binder.Name))
				Else
					result = Me.o___0o.00o0oO..ExecuteScriptAsync(text)
				End If
				result2 = True
			End If
			Return result2
		End Function

		' Token: 0x06000CED RID: 3309 RVA: 0x0005D47C File Offset: 0x0005B67C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Overrides Function TrySetMember(binder As SetMemberBinder, value As Object) As Boolean
			Dim result As Boolean
			If Me.Ooo_.o_.(binder.Name) Then
				result = False
			Else
				Dim text As String
				If value Is Nothing Then
					text = "null"
				ElseIf TypeOf value Is String Then
					text = JsonConvert.ToString(value.ToString())
				ElseIf TypeOf value Is Boolean Then
					text = value.ToString().ToLower()
				Else
					text = value.ToString()
				End If
				Dim text2 As String
				If Me.o___0o.00o0oO. Then
					text2 = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
					text2 += vbCrLf & "for (var el of elements) {"
					text2 = text2 + vbCrLf + String.Format("el.{0}= {1};", binder.Name, text)
					text2 += vbCrLf & "}"
				Else
					text2 = String.Format("{0}.{1} = {2}", Me.o___0o.00o0oO., binder.Name, text)
				End If
				Me.o___0o.00o0oO..ExecuteScriptAsync(text2)
				result = True
			End If
			Return result
		End Function

		' Token: 0x06000CEE RID: 3310 RVA: 0x0005D554 File Offset: 0x0005B754
		Public Function getAttribute(AttrName As String) As Object
			Dim text As String
			If Me.o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
				text = text + vbCrLf + String.Format("elements[0]?.getAttribute(""{0}"");", AttrName)
			Else
				text = String.Format("{0}.getAttribute(""{1}"")", Me.o___0o.00o0oO., AttrName)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CEF RID: 3311 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
		Public Function hasAttribute(attrName As String) As Object
			Dim text As String
			If Me.o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
				text = text + vbCrLf + String.Format("elements[0]?.hasAttribute(""{0}"");", attrName)
			Else
				text = String.Format("{0}.hasAttribute(""{1}"")", Me.o___0o.00o0oO., attrName)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF0 RID: 3312 RVA: 0x0005D614 File Offset: 0x0005B814
		Public Function setAttribute(AttrName As String, Value As String) As Object
			Dim text As String
			If Me.o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
				text += vbCrLf & "for (var el of elements) {"
				text = text + vbCrLf + String.Format("el.setAttribute(""{0}"",""{1}"");", AttrName, Value)
				text += vbCrLf & "}"
			Else
				text = String.Format("{0}.setAttribute(""{1}"",""{2}"")", Me.o___0o.00o0oO., AttrName, Value)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF1 RID: 3313 RVA: 0x0005D68C File Offset: 0x0005B88C
		Public Function removeAttribute(AttrName As String) As Object
			Dim text As String
			If Me.o___0o.00o0oO. Then
				text = String.Format("var elements = {0};", Me.o___0o.00o0oO.)
				text += vbCrLf & "for (var el of elements) {"
				text = text + vbCrLf + String.Format("el.removeAttribute(""{0}"");", AttrName)
				text += vbCrLf & "}"
			Else
				text = String.Format("{0}.removeAttribute(""{1}"")", Me.o___0o.00o0oO., AttrName)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF2 RID: 3314 RVA: 0x0005D704 File Offset: 0x0005B904
		Public Function Click() As Object
			Dim text As String = String.Format("{0}.click()", Me.o___0o.00o0oO.)
			Me.o___0o.00o0oO..ExecuteScriptAsync(text)
			Dim result As Object
			Return result
		End Function

		' Token: 0x06000CF3 RID: 3315 RVA: 0x0005D730 File Offset: 0x0005B930
		Public Function normalize() As Object
			Dim text As String = String.Format("{0}.normalize()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF4 RID: 3316 RVA: 0x0005D75C File Offset: 0x0005B95C
		Public Function focus() As Object
			Dim text As String = String.Format("{0}.focus()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF5 RID: 3317 RVA: 0x0005D788 File Offset: 0x0005B988
		Public Function hasFocus() As Object
			Dim text As String = String.Format("{0}.hasFocus()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF6 RID: 3318 RVA: 0x0005D7B4 File Offset: 0x0005B9B4
		Public Function blur() As Object
			Dim text As String = String.Format("{0}.blur()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF7 RID: 3319 RVA: 0x0005D7E0 File Offset: 0x0005B9E0
		Public Function [select]() As Object
			Dim text As String = String.Format("{0}.select()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF8 RID: 3320 RVA: 0x0005D80C File Offset: 0x0005BA0C
		Public Function prompt(ParamArray args As String()) As Object
			Dim text As String = ""
			If args.Length = 0 Then
				text = String.Format("{0}.prompt()", Me.o___0o.00o0oO.)
			ElseIf args.Length = 1 Then
				text = String.Format("{0}.prompt({1})", Me.o___0o.00o0oO., JsonConvert.ToString(args(0)))
			ElseIf args.Length = 2 Then
				text = String.Format("{0}.prompt({1},{2})", Me.o___0o.00o0oO., JsonConvert.ToString(args(0)), JsonConvert.ToString(args(1)))
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CF9 RID: 3321 RVA: 0x0005D88C File Offset: 0x0005BA8C
		Public Function print() As Object
			Dim text As String = String.Format("{0}.print()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFA RID: 3322 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		Public Function alert(message As String) As Object
			message = JsonConvert.ToString(message)
			Dim text As String = String.Format("{0}.alert({1})", Me.o___0o.00o0oO., message)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFB RID: 3323 RVA: 0x0005D8EC File Offset: 0x0005BAEC
		Public Function confirm(message As String) As Object
			message = JsonConvert.ToString(message)
			Dim text As String = String.Format("{0}.confirm({1})", Me.o___0o.00o0oO., message)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFC RID: 3324 RVA: 0x0005D920 File Offset: 0x0005BB20
		Public Function atob(str As String) As Object
			str = JsonConvert.ToString(str)
			Dim text As String = String.Format("{0}.atob({1})", Me.o___0o.00o0oO., str)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFD RID: 3325 RVA: 0x0005D954 File Offset: 0x0005BB54
		Public Function btoa(encodedStr As String) As Object
			encodedStr = JsonConvert.ToString(encodedStr)
			Dim text As String = String.Format("{0}.btoa({1})", Me.o___0o.00o0oO., encodedStr)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFE RID: 3326 RVA: 0x0005D988 File Offset: 0x0005BB88
		Public Function scrollIntoView(Optional arg As Object = Nothing) As Object
			Dim text As String
			If arg Is Nothing Then
				text = String.Format("{0}.scrollIntoView()", Me.o___0o.00o0oO.)
			ElseIf TypeOf arg Is Boolean Then
				Dim arg2 As String = "false"
				If Conversions.ToBoolean(arg) Then
					arg2 = "true"
				End If
				text = String.Format("{0}.scrollIntoView({1})", Me.o___0o.00o0oO., arg2)
			Else
				Dim arg3 As String = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(arg))
				text = String.Format("{0}.scrollIntoView({1})", Me.o___0o.00o0oO., arg3)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000CFF RID: 3327 RVA: 0x0005DA08 File Offset: 0x0005BC08
		Public Function createCaption() As Task(Of Object)
			Dim o__oOo As HElement.o__oOo00 = Nothing
			o__oOo.O00.Ooo0OO_O. = Me
			o__oOo.O00.Ooo0OO_O. = -1
			o__oOo.o___0o.00o0oO. = AsyncTaskMethodBuilder(Of Object).Create()
			o__oOo.o___0o.00o0oO..Start(Of HElement.o__oOo00)(o__oOo)
			Return o__oOo.o___0o.00o0oO..Task
		End Function

		' Token: 0x06000D00 RID: 3328 RVA: 0x0005DA54 File Offset: 0x0005BC54
		Public Function createTFoot() As Task(Of Object)
			Dim o0_O As HElement.O0_O = Nothing
			o0_O.O00.Ooo0OO_O. = Me
			o0_O.O00.Ooo0OO_O. = -1
			o0_O.O00.Ooo0OO_O. = AsyncTaskMethodBuilder(Of Object).Create()
			o0_O.O00.Ooo0OO_O..Start(Of HElement.O0_O)(o0_O)
			Return o0_O.O00.Ooo0OO_O..Task
		End Function

		' Token: 0x06000D01 RID: 3329 RVA: 0x0005DAA0 File Offset: 0x0005BCA0
		Public Function createTHead() As Task(Of Object)
			Dim o0o00_O As HElement.O0o00_O = Nothing
			o0o00_O.o_O._o0Oo000. = Me
			o0o00_O.o_O._o0Oo000. = -1
			o0o00_O.o_O._o0Oo000. = AsyncTaskMethodBuilder(Of Object).Create()
			o0o00_O.o_O._o0Oo000..Start(Of HElement.O0o00_O)(o0o00_O)
			Return o0o00_O.o_O._o0Oo000..Task
		End Function

		' Token: 0x06000D02 RID: 3330 RVA: 0x0005DAEC File Offset: 0x0005BCEC
		Public Function deleteCaption() As Object
			Dim text As String = String.Format("{0}.deleteCaption();", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D03 RID: 3331 RVA: 0x0005DB18 File Offset: 0x0005BD18
		Public Function deleteTFoot() As Object
			Dim text As String = String.Format("{0}.deleteTFoot();", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D04 RID: 3332 RVA: 0x0005DB44 File Offset: 0x0005BD44
		Public Function deleteTHead() As Object
			Dim text As String = String.Format("{0}.deleteTHead();", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D05 RID: 3333 RVA: 0x0005DB70 File Offset: 0x0005BD70
		Public Function deleteRow(index As Integer) As Object
			Dim text As String = String.Format("{0}.deleteRow({1});", Me.o___0o.00o0oO., index)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D06 RID: 3334 RVA: 0x0005DBA0 File Offset: 0x0005BDA0
		Public Function insertRow(index As Integer) As Task(Of Object)
			Dim ooO As HElement.OoO0 = Nothing
			ooO.O__0_0O_O.0. = Me
			ooO.o00O_.O. = index
			ooO.o_O._o0Oo000. = -1
			ooO.o_O._o0Oo000. = AsyncTaskMethodBuilder(Of Object).Create()
			ooO.o_O._o0Oo000..Start(Of HElement.OoO0)(ooO)
			Return ooO.o_O._o0Oo000..Task
		End Function

		' Token: 0x06000D07 RID: 3335 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
		Public Function deleteCell(index As Integer) As Object
			Dim text As String = String.Format("{0}.deleteCell({1});", Me.o___0o.00o0oO., index)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D08 RID: 3336 RVA: 0x0005DC24 File Offset: 0x0005BE24
		Public Function insertCell(index As Integer) As Task(Of Object)
			Dim o_o_ As HElement.O_o_ = Nothing
			o_o_.O__0_0O_O.0. = Me
			o_o_.o.Ooo_o. = index
			o_o_.O__0_0O_O.0. = -1
			o_o_.O__0_0O_O.0. = AsyncTaskMethodBuilder(Of Object).Create()
			o_o_.O__0_0O_O.0..Start(Of HElement.O_o_)(o_o_)
			Return o_o_.O__0_0O_O.0..Task
		End Function

		' Token: 0x06000D09 RID: 3337 RVA: 0x0005DC77 File Offset: 0x0005BE77
		Public Function getElementsByClassName(className As String) As Object
			Return New HElement(Me.o___0o.00o0oO., String.Format("{0}.getElementsByClassName(""{1}"")", Me.o___0o.00o0oO., className), True)
		End Function

		' Token: 0x06000D0A RID: 3338 RVA: 0x0005DC96 File Offset: 0x0005BE96
		Public Function getElementsByTagName(tagName As String) As Object
			Return New HElement(Me.o___0o.00o0oO., String.Format("{0}.getElementsByTagName(""{1}"")", Me.o___0o.00o0oO., tagName), True)
		End Function

		' Token: 0x06000D0B RID: 3339 RVA: 0x0005DCB5 File Offset: 0x0005BEB5
		Public Function querySelector(cssSelector As String) As Object
			Return New HElement(Me.o___0o.00o0oO., String.Format("{0}.querySelector(""{1}"")", Me.o___0o.00o0oO., cssSelector))
		End Function

		' Token: 0x06000D0C RID: 3340 RVA: 0x0005DCD3 File Offset: 0x0005BED3
		Public Function querySelectorAll(cssSelector As String) As Object
			Return New HElement(Me.o___0o.00o0oO., String.Format("{0}.querySelectorAll(""{1}"")", Me.o___0o.00o0oO., cssSelector))
		End Function

		' Token: 0x06000D0D RID: 3341 RVA: 0x0005DCF1 File Offset: 0x0005BEF1
		Public Function closest(cssSelector As String) As Object
			Return New HElement(Me.o___0o.00o0oO., String.Format("{0}.closest(""{1}"")", Me.o___0o.00o0oO., cssSelector))
		End Function

		' Token: 0x06000D0E RID: 3342 RVA: 0x0005DD10 File Offset: 0x0005BF10
		Public Function matches(selectors As String) As Object
			Dim text As String = String.Format("{0}.matches(""{1}"")", Me.o___0o.00o0oO., selectors)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D0F RID: 3343 RVA: 0x0005DD3C File Offset: 0x0005BF3C
		Public Function reset() As Object
			Dim text As String = String.Format("{0}.reset()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D10 RID: 3344 RVA: 0x0005DD68 File Offset: 0x0005BF68
		Public Function IsNull() As Task(Of Boolean)
			Dim oo_O__oOo_o0o As HElement.Oo_O__oOo_o0o = Nothing
			oo_O__oOo_o0o.oo00o.__00__Oo. = Me
			oo_O__oOo_o0o.oo00o.__00__Oo. = -1
			oo_O__oOo_o0o.oo00o.__00__Oo. = AsyncTaskMethodBuilder(Of Boolean).Create()
			oo_O__oOo_o0o.oo00o.__00__Oo..Start(Of HElement.Oo_O__oOo_o0o)(oo_O__oOo_o0o)
			Return oo_O__oOo_o0o.oo00o.__00__Oo..Task
		End Function

		' Token: 0x06000D11 RID: 3345 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
		Public Function checkValidity() As Task(Of Boolean)
			Dim oo_oO0o As HElement.OO_oO0o = Nothing
			oo_oO0o.oo00o.__00__Oo. = Me
			oo_oO0o.oo00o.__00__Oo. = -1
			oo_oO0o.oo00o.__00__Oo. = AsyncTaskMethodBuilder(Of Boolean).Create()
			oo_oO0o.oo00o.__00__Oo..Start(Of HElement.OO_oO0o)(oo_oO0o)
			Return oo_oO0o.oo00o.__00__Oo..Task
		End Function

		' Token: 0x06000D12 RID: 3346 RVA: 0x0005DE00 File Offset: 0x0005C000
		Public Function reportValidity() As Task(Of Boolean)
			Dim o00000O00oo As HElement.o00000O00oo0 = Nothing
			o00000O00oo.O0.O0o. = Me
			o00000O00oo.O0.O0o. = -1
			o00000O00oo.O0.O0o. = AsyncTaskMethodBuilder(Of Boolean).Create()
			o00000O00oo.O0.O0o..Start(Of HElement.o00000O00oo0)(o00000O00oo)
			Return o00000O00oo.O0.O0o..Task
		End Function

		' Token: 0x06000D13 RID: 3347 RVA: 0x0005DE4C File Offset: 0x0005C04C
		Public Function setCustomValidity(message As String) As Object
			Dim obj As Object = JsonConvert.ToString(message)
			Dim text As String = String.Format("{0}.setCustomValidity({1})", Me.o___0o.00o0oO., RuntimeHelpers.GetObjectValue(obj))
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D14 RID: 3348 RVA: 0x0005DE84 File Offset: 0x0005C084
		Public Function hasOwnProperty(propertyName As String) As Task(Of Boolean)
			Dim o_0__0O_O As HElement.O_0__0O_O0 = Nothing
			o_0__0O_O.ooo_0.o. = Me
			o_0__0O_O.ooo_0.o. = propertyName
			o_0__0O_O.ooo_0.o. = -1
			o_0__0O_O.O0.O0o. = AsyncTaskMethodBuilder(Of Boolean).Create()
			o_0__0O_O.O0.O0o..Start(Of HElement.O_0__0O_O0)(o_0__0O_O)
			Return o_0__0O_O.O0.O0o..Task
		End Function

		' Token: 0x06000D15 RID: 3349 RVA: 0x0005DED8 File Offset: 0x0005C0D8
		Public Function addEventListener(eventName As String, jsCodeorFunction As String) As Object
			Dim text As String
			If jsCodeorFunction.Contains("function") OrElse jsCodeorFunction.Contains("=>") OrElse jsCodeorFunction.Contains("{") OrElse jsCodeorFunction.Contains("}") Then
				Dim obj As Object = JsonConvert.ToString(jsCodeorFunction)
				text = String.Format("{0}.addEventListener(""{1}"", {2})", Me.o___0o.00o0oO., eventName, RuntimeHelpers.GetObjectValue(obj))
			Else
				text = String.Format("{0}.addEventListener(""{1}"", {2})", Me.o___0o.00o0oO., eventName, jsCodeorFunction)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D16 RID: 3350 RVA: 0x0005DF5C File Offset: 0x0005C15C
		Public Function removeEventListener(eventName As String, functionName As String) As Object
			Dim text As String = String.Format("{0}.removeEventListener(""{1}"", {2})", Me.o___0o.00o0oO., eventName, functionName)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x17000234 RID: 564
		' (get) Token: 0x06000D17 RID: 3351 RVA: 0x0005DF88 File Offset: 0x0005C188
		Public ReadOnly Property ComputedStyle As Object
			Get
				Dim value As Object = String.Format("getComputedStyle({0})", Me.o___0o.00o0oO.)
				Return New HElement(Me.o___0o.00o0oO., Conversions.ToString(value))
			End Get
		End Property

		' Token: 0x06000D18 RID: 3352 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
		Public Function getBoundingClientRect() As Object
			Dim text As String = String.Format("JSON.parse(JSON.stringify({0}.getBoundingClientRect()))", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D19 RID: 3353 RVA: 0x0005DFE4 File Offset: 0x0005C1E4
		Public Function scrollTo(x As Integer, y As Integer) As Object
			Dim text As String = String.Format("{0}.scrollTo({1},{2})", Me.o___0o.00o0oO., x, y)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D1A RID: 3354 RVA: 0x0005E01C File Offset: 0x0005C21C
		Public Function scrollBy(x As Integer, y As Integer) As Object
			Dim text As String = String.Format("{0}.scrollBy({1},{2})", Me.o___0o.00o0oO., x, y)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D1B RID: 3355 RVA: 0x0005E054 File Offset: 0x0005C254
		Public Function insertAdjacentHTML(position As String, html As String) As Object
			Dim obj As Object = JsonConvert.ToString(html)
			Dim text As String = String.Format("{0}.insertAdjacentHTML(""{1}"", {2})", Me.o___0o.00o0oO., position, RuntimeHelpers.GetObjectValue(obj))
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D1C RID: 3356 RVA: 0x0005E08C File Offset: 0x0005C28C
		Public Function insertAdjacentText(position As String, text As String) As Object
			Dim obj As Object = JsonConvert.ToString(text)
			Dim text2 As String = String.Format("{0}.insertAdjacentText(""{1}"", {2})", Me.o___0o.00o0oO., position, RuntimeHelpers.GetObjectValue(obj))
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text2)
		End Function

		' Token: 0x17000235 RID: 565
		' (get) Token: 0x06000D1D RID: 3357 RVA: 0x0005E0C4 File Offset: 0x0005C2C4
		Public ReadOnly Property files As Object
			Get
				Dim text As String = New XCData(vbLf & "JSON.parse(JSON.stringify(Array.from(").Value + Me.o___0o.00o0oO. + New XCData(".files).map(f => ({" & vbLf & "    name: f.name," & vbLf & "    size: f.size," & vbLf & "    type: f.type," & vbLf & "    lastModified: f.lastModified," & vbLf & "    lastModifiedDate: f.lastModifiedDate ? f.lastModifiedDate.toISOString() : null," & vbLf & "    webkitRelativePath: f.webkitRelativePath || null" & vbLf & "}))))" & vbLf).Value
				Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
			End Get
		End Property

		' Token: 0x06000D1E RID: 3358 RVA: 0x0005E108 File Offset: 0x0005C308
		Public Function submit() As Object
			Dim text As String = String.Format("{0}.submit()", Me.o___0o.00o0oO.)
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D1F RID: 3359 RVA: 0x0005E134 File Offset: 0x0005C334
		Public Function requestSubmit(Optional button As HElement = Nothing) As Object
			Dim text As String
			If button Is Nothing Then
				text = String.Format("{0}.requestSubmit()", Me.o___0o.00o0oO.)
			Else
				text = String.Format("{0}.requestSubmit({1})", Me.o___0o.00o0oO., button.o___0o.00o0oO.)
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D20 RID: 3360 RVA: 0x0005E17C File Offset: 0x0005C37C
		Public Function stepUp([step] As Integer) As Object
			Dim text As String = String.Format("{0}.stepUp({1})", Me.o___0o.00o0oO., [step])
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D21 RID: 3361 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		Public Function stepDown([step] As Integer) As Object
			Dim text As String = String.Format("{0}.stepDown({1})", Me.o___0o.00o0oO., [step])
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D22 RID: 3362 RVA: 0x0005E1DC File Offset: 0x0005C3DC
		Public Function setSelectionRange(start As Integer, [end] As Integer, Optional direction As String = Nothing) As Object
			Dim text As String
			If direction IsNot Nothing Then
				text = String.Format("{0}.setSelectionRange({1}, {2}, '{3}')", New Object() { Me.o___0o.00o0oO., start, [end], direction })
			Else
				text = String.Format("{0}.setSelectionRange({1}, {2})", Me.o___0o.00o0oO., start, [end])
			End If
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D23 RID: 3363 RVA: 0x0005E248 File Offset: 0x0005C448
		Public Function setRangeText(replacement As String) As Object
			Dim obj As Object = JsonConvert.ToString(replacement)
			Dim text As String = String.Format("{0}.setRangeText({1})", Me.o___0o.00o0oO., RuntimeHelpers.GetObjectValue(obj))
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D24 RID: 3364 RVA: 0x0005E280 File Offset: 0x0005C480
		Public Function setRangeText(replacement As String, start As Integer, [end] As Integer) As Object
			Dim obj As Object = JsonConvert.ToString(replacement)
			Dim text As String = String.Format("{0}.setRangeText({1}, {2}, {3})", New Object() { Me.o___0o.00o0oO., obj, start, [end] })
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x06000D25 RID: 3365 RVA: 0x0005E2D0 File Offset: 0x0005C4D0
		Public Function setRangeText(replacement As String, start As Integer, [end] As Integer, selectMode As String) As Object
			Dim obj As Object = JsonConvert.ToString(replacement)
			Dim text As String = String.Format("{0}.setRangeText({1}, {2}, {3}, '{4}')", New Object() { Me.o___0o.00o0oO., obj, start, [end], selectMode })
			Return Me.o___0o.00o0oO..ExecuteScriptAsync(text)
		End Function

		' Token: 0x040004EA RID: 1258
		Friend <<EMPTY_NAME>> As WebViewer

		' Token: 0x040004EB RID: 1259
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040004EC RID: 1260
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040004ED RID: 1261
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040004EE RID: 1262
		Private <<EMPTY_NAME>> As CSSStyle

		' Token: 0x040004EF RID: 1263
		Private <<EMPTY_NAME>> As cssClassList
	End Class
End Namespace
