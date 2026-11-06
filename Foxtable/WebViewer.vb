Imports System
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Dynamic
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Linq
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json

Namespace Foxtable
	' Token: 0x02000129 RID: 297
	Public Class WebViewer
		Inherits WebView2

		' Token: 0x06000E61 RID: 3681 RVA: 0x000616C4 File Offset: 0x0005F8C4
		Public Sub New()
			MyBase.NavigationCompleted += AddressOf Me.oO.oO_.
			Me.AreDevToolsEnabled = True
			Me.AreSaveAsEnabled = True
			Me.AreDefaultContextMenusEnabled = True
			Me.AreBrowserAcceleratorKeysEnabled = True
			Me.oo_.0oOOOoooo. = New ConcurrentDictionary(Of CoreWebView2DownloadOperation, TaskCompletionSource(Of Integer))()
			Me.oo_.0oOOOoooo. = New ConcurrentDictionary(Of CoreWebView2DownloadOperation, EventHandler(Of Object))()
			Me.OoO.oOOoo. = New ConcurrentDictionary(Of CoreWebView2DownloadOperation, EventHandler(Of Object))()
		End Sub

		' Token: 0x1700028C RID: 652
		' (get) Token: 0x06000E62 RID: 3682 RVA: 0x00061726 File Offset: 0x0005F926
		' (set) Token: 0x06000E63 RID: 3683 RVA: 0x0006172E File Offset: 0x0005F92E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AreDevToolsEnabled As Boolean

		' Token: 0x1700028D RID: 653
		' (get) Token: 0x06000E64 RID: 3684 RVA: 0x00061737 File Offset: 0x0005F937
		' (set) Token: 0x06000E65 RID: 3685 RVA: 0x0006173F File Offset: 0x0005F93F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AreSaveAsEnabled As Boolean

		' Token: 0x1700028E RID: 654
		' (get) Token: 0x06000E66 RID: 3686 RVA: 0x00061748 File Offset: 0x0005F948
		' (set) Token: 0x06000E67 RID: 3687 RVA: 0x00061750 File Offset: 0x0005F950
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AreDefaultContextMenusEnabled As Boolean

		' Token: 0x1700028F RID: 655
		' (get) Token: 0x06000E68 RID: 3688 RVA: 0x00061759 File Offset: 0x0005F959
		' (set) Token: 0x06000E69 RID: 3689 RVA: 0x00061761 File Offset: 0x0005F961
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AreBrowserAcceleratorKeysEnabled As Boolean

		' Token: 0x06000E6A RID: 3690 RVA: 0x0006176C File Offset: 0x0005F96C
		Public Function ValidUrl(url As String) As String
			Dim result As String
			If String.IsNullOrWhiteSpace(url) Then
				result = ""
			Else
				url = url.Trim()
				Dim uri As Uri = Nothing
				If Uri.TryCreate(url, UriKind.Absolute, uri) Then
					result = url
				Else
					If Not url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) AndAlso Not url.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
						url = "http://" + url
						If Uri.TryCreate(url, UriKind.Absolute, uri) Then
							Return url
						End If
					End If
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x06000E6B RID: 3691 RVA: 0x000617E1 File Offset: 0x0005F9E1
		Public Function getElementById(id As String) As Object
			Return New HElement(Me, String.Format("document.getElementById(""{0}"")", id))
		End Function

		' Token: 0x06000E6C RID: 3692 RVA: 0x000617F4 File Offset: 0x0005F9F4
		Public Function getElementsByName(name As String) As Object
			Return New HElement(Me, String.Format("document.getElementsByName(""{0}"")", name), True)
		End Function

		' Token: 0x06000E6D RID: 3693 RVA: 0x00061808 File Offset: 0x0005FA08
		Public Function getElementsByTagName(tagName As String) As Object
			Return New HElement(Me, String.Format("document.getElementsByTagName(""{0}"")", tagName), True)
		End Function

		' Token: 0x06000E6E RID: 3694 RVA: 0x0006181C File Offset: 0x0005FA1C
		Public Function getElementsByClassName(className As String) As Object
			Return New HElement(Me, String.Format("document.getElementsByClassName(""{0}"")", className), True)
		End Function

		' Token: 0x06000E6F RID: 3695 RVA: 0x00061830 File Offset: 0x0005FA30
		Public Function querySelector(cssSelector As String) As Object
			Return New HElement(Me, String.Format("document.querySelector(""{0}"")", cssSelector))
		End Function

		' Token: 0x06000E70 RID: 3696 RVA: 0x00061843 File Offset: 0x0005FA43
		Public Function querySelectorAll(cssSelector As String) As Object
			Return New HElement(Me, String.Format("document.querySelectorAll(""{0}"")", cssSelector), True)
		End Function

		' Token: 0x06000E71 RID: 3697 RVA: 0x00061858 File Offset: 0x0005FA58
		Public Function xpathQuery(xpath As Object) As Object
			Dim text As String = New XCData(vbLf & "function xpathQuery(xpath) {" & vbLf & "    try {" & vbLf & "        if (typeof xpath !== 'string' || !xpath.trim()) {" & vbLf & "            return null;" & vbLf & "        }" & vbLf & "        const expr = xpath.trim();" & vbLf & "        const evaluator = document.evaluate(" & vbLf & "            expr," & vbLf & "            document," & vbLf & "            null," & vbLf & "            XPathResult.FIRST_ORDERED_NODE_TYPE," & vbLf & "            null" & vbLf & "        );" & vbLf & "        const node = evaluator.singleNodeValue;" & vbLf & "        return (node && node.nodeType === Node.ELEMENT_NODE) ? node : null;" & vbLf & "    } catch (err) {" & vbLf & "        console.error('[XPath Error]', err.message, '\nExpression:', xpath);" & vbLf & "        return null;" & vbLf & "    }" & vbLf & "}" & vbLf).Value
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(" + text + ")(""", xpath), """)"))
			Return New HElement(Me, text)
		End Function

		' Token: 0x06000E72 RID: 3698 RVA: 0x000618A4 File Offset: 0x0005FAA4
		Public Function xpathQueryAll(xpath As Object) As Object
			Dim text As String = New XCData(vbLf & "function xpathQueryAll(xpath) {" & vbLf & "    try {" & vbLf & "        if (typeof xpath !== 'string' || !xpath.trim()) {" & vbLf & "            return [];" & vbLf & "        }" & vbLf & "        const expr = xpath.trim();" & vbLf & "        const results = [];" & vbLf & "        const evaluator = document.evaluate(" & vbLf & "            expr," & vbLf & "            document," & vbLf & "            null," & vbLf & "            XPathResult.ORDERED_NODE_ITERATOR_TYPE," & vbLf & "            null" & vbLf & "        );" & vbLf & "        let node;" & vbLf & "        while ((node = evaluator.iterateNext())) {" & vbLf & "            if (node.nodeType === Node.ELEMENT_NODE) {" & vbLf & "                results.push(node);" & vbLf & "            }" & vbLf & "        }" & vbLf & "        return results;" & vbLf & "    } catch (err) {" & vbLf & "        console.error('[XPath Error]', err.message, '\nExpression:', xpath);" & vbLf & "        return [];" & vbLf & "    }" & vbLf & "}" & vbLf).Value
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("(" + text + ")(""", xpath), """)"))
			Return New HElement(Me, text, True)
		End Function

		' Token: 0x17000290 RID: 656
		' (get) Token: 0x06000E73 RID: 3699 RVA: 0x000618EF File Offset: 0x0005FAEF
		Public ReadOnly Property activeElement As Object
			Get
				Return New HElement(Me, "document.activeElement")
			End Get
		End Property

		' Token: 0x17000291 RID: 657
		' (get) Token: 0x06000E74 RID: 3700 RVA: 0x000618FC File Offset: 0x0005FAFC
		Public ReadOnly Property body As Object
			Get
				Return New HElement(Me, "document.body")
			End Get
		End Property

		' Token: 0x17000292 RID: 658
		' (get) Token: 0x06000E75 RID: 3701 RVA: 0x00061909 File Offset: 0x0005FB09
		Public ReadOnly Property head As Object
			Get
				Return New HElement(Me, "document.head")
			End Get
		End Property

		' Token: 0x17000293 RID: 659
		' (get) Token: 0x06000E76 RID: 3702 RVA: 0x00061916 File Offset: 0x0005FB16
		Public ReadOnly Property documentElement As Object
			Get
				Return New HElement(Me, "document.documentElement")
			End Get
		End Property

		' Token: 0x17000294 RID: 660
		' (get) Token: 0x06000E77 RID: 3703 RVA: 0x00061923 File Offset: 0x0005FB23
		Public ReadOnly Property window As Object
			Get
				Return New HElement(Me, "window")
			End Get
		End Property

		' Token: 0x17000295 RID: 661
		' (get) Token: 0x06000E78 RID: 3704 RVA: 0x00061930 File Offset: 0x0005FB30
		Public ReadOnly Property document As Object
			Get
				Return New HElement(Me, "document")
			End Get
		End Property

		' Token: 0x17000296 RID: 662
		' (get) Token: 0x06000E79 RID: 3705 RVA: 0x0006193D File Offset: 0x0005FB3D
		Public ReadOnly Property navigator As Object
			Get
				Return New HElement(Me, "navigator")
			End Get
		End Property

		' Token: 0x17000297 RID: 663
		' (get) Token: 0x06000E7A RID: 3706 RVA: 0x0006194A File Offset: 0x0005FB4A
		Public ReadOnly Property localStorage As Object
			Get
				Return New HStorage(Me, "window.localStorage")
			End Get
		End Property

		' Token: 0x17000298 RID: 664
		' (get) Token: 0x06000E7B RID: 3707 RVA: 0x00061957 File Offset: 0x0005FB57
		Public ReadOnly Property sessionStorage As Object
			Get
				Return New HStorage(Me, "window.sessionStorage")
			End Get
		End Property

		' Token: 0x06000E7C RID: 3708 RVA: 0x00061964 File Offset: 0x0005FB64
		Public Function GetElementInfoFromPoint(x As Integer, y As Integer) As Task(Of ExpandoObject)
			Dim oooo0O__0o_o As WebViewer.OOoo0O__0o_o = Nothing
			oooo0O__0o_o.O__O0.o0O0. = Me
			oooo0O__0o_o.OO__.oO0_OoO_. = x
			oooo0O__0o_o.o_.O_OOo___O_0. = y
			oooo0O__0o_o.O__O0.o0O0. = -1
			oooo0O__0o_o.O__O0.o0O0. = AsyncTaskMethodBuilder(Of ExpandoObject).Create()
			oooo0O__0o_o.O__O0.o0O0..Start(Of WebViewer.OOoo0O__0o_o)(oooo0O__0o_o)
			Return oooo0O__0o_o.O__O0.o0O0..Task
		End Function

		' Token: 0x06000E7D RID: 3709 RVA: 0x000619C0 File Offset: 0x0005FBC0
		Public Function GetValueByID(id As String) As Task(Of Object)
			Dim ooO00OO0oOo As WebViewer.OoO00OO0oOo0 = Nothing
			ooO00OO0oOo.OOO_._O__0OO. = Me
			ooO00OO0oOo.OOO_._O__0OO. = id
			ooO00OO0oOo.OOO_._O__0OO. = -1
			ooO00OO0oOo.OOO_._O__0OO. = AsyncTaskMethodBuilder(Of Object).Create()
			ooO00OO0oOo.OOO_._O__0OO..Start(Of WebViewer.OoO00OO0oOo0)(ooO00OO0oOo)
			Return ooO00OO0oOo.OOO_._O__0OO..Task
		End Function

		' Token: 0x06000E7E RID: 3710 RVA: 0x00061A13 File Offset: 0x0005FC13
		Public Function SetValueByID(id As String, value As Object) As Task
			Return Me.SetValuesByID(New String() { id }, New Object() { value })
		End Function

		' Token: 0x06000E7F RID: 3711 RVA: 0x00061A30 File Offset: 0x0005FC30
		Public Function GetValuesByID(ids As IEnumerable(Of String)) As Task(Of ExpandoObject)
			Dim ooOO0_oo__OO As WebViewer.ooOO0_oo__OO = Nothing
			ooOO0_oo__OO.oO._o0O_0OOo0o. = Me
			ooOO0_oo__OO.oO._o0O_0OOo0o. = ids
			ooOO0_oo__OO.oO._o0O_0OOo0o. = -1
			ooOO0_oo__OO.OOO_._O__0OO. = AsyncTaskMethodBuilder(Of ExpandoObject).Create()
			ooOO0_oo__OO.OOO_._O__0OO..Start(Of WebViewer.ooOO0_oo__OO)(ooOO0_oo__OO)
			Return ooOO0_oo__OO.OOO_._O__0OO..Task
		End Function

		' Token: 0x06000E80 RID: 3712 RVA: 0x00061A84 File Offset: 0x0005FC84
		Public Function SetValuesByID(ids As IEnumerable(Of String), values As IEnumerable(Of Object)) As Task
			Dim list As List(Of String) = ids.ToList()
			Dim list2 As List(Of Object) = values.ToList()
			If list.Count <> list2.Count Then
				Throw New ArgumentException(String.Format("ID 数量（{0}）与 Value 数量（{1}）不匹配！", list.Count, list2.Count))
			End If
			Dim result As Task
			If list.Count = 0 Then
				result = Task.CompletedTask
			Else
				Dim stringBuilder As StringBuilder = New StringBuilder()
				stringBuilder.AppendLine("(function() {")
				stringBuilder.AppendLine("  function setElementValue(id, value) {")
				stringBuilder.AppendLine("    var elem = document.getElementById(id);")
				stringBuilder.AppendLine("    if (elem && 'value' in elem) {")
				stringBuilder.AppendLine("      elem.value = value ?? ''; // Value 为 Null 时设为空字符串")
				stringBuilder.AppendLine("    }")
				stringBuilder.AppendLine("  }")
				Dim num As Integer = list.Count - 1
				For i As Integer = 0 To num
					Dim text As String = list(i)
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(list2(i))
					Dim arg As String = text.Replace("'", "\'")
					Dim arg2 As String = JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(objectValue))
					stringBuilder.AppendLine(String.Format("  setElementValue('{0}', {1});", arg, arg2))
				Next
				stringBuilder.AppendLine("})();")
				result = MyBase.ExecuteScriptAsync(stringBuilder.ToString())
			End If
			Return result
		End Function

		' Token: 0x06000E81 RID: 3713 RVA: 0x00061BC0 File Offset: 0x0005FDC0
		Public Function CreateWebResourceRequest(uri As String, Optional Method As String = "GET", Optional postData As Stream = Nothing) As CoreWebView2WebResourceRequest
			If MyBase.CoreWebView2 Is Nothing Then
				Throw New InvalidOperationException("WebViewer未初始化!")
			End If
			Return MyBase.CoreWebView2.Environment.CreateWebResourceRequest(uri, Method, postData, Nothing)
		End Function

		' Token: 0x06000E82 RID: 3714 RVA: 0x00061BE9 File Offset: 0x0005FDE9
		Public Sub NavigateWithWebResourceRequest(Request As CoreWebView2WebResourceRequest)
			If MyBase.CoreWebView2 Is Nothing Then
				Throw New InvalidOperationException("WebViewer未初始化!")
			End If
			MyBase.CoreWebView2.NavigateWithWebResourceRequest(Request)
		End Sub

		' Token: 0x06000E83 RID: 3715 RVA: 0x00061C0C File Offset: 0x0005FE0C
		Public Function NavigateWithWebResourceRequestAsync(request As CoreWebView2WebResourceRequest, Optional timeoutSeconds As Integer = 30) As Task(Of Integer)
			Dim oooo_0_O_0_ As WebViewer.OOOo_0_O_0_0 = Nothing
			oooo_0_O_0_.oo_oO_0o.oo00. = Me
			oooo_0_O_0_.oo_oO_0o.oo00. = request
			oooo_0_O_0_.OOO.O00_00_o_0. = timeoutSeconds
			oooo_0_O_0_.oo_oO_0o.oo00. = -1
			oooo_0_O_0_.oO._o0O_0OOo0o. = AsyncTaskMethodBuilder(Of Integer).Create()
			oooo_0_O_0_.oO._o0O_0OOo0o..Start(Of WebViewer.OOOo_0_O_0_0)(oooo_0_O_0_)
			Return oooo_0_O_0_.oO._o0O_0OOo0o..Task
		End Function

		' Token: 0x06000E84 RID: 3716 RVA: 0x00061C67 File Offset: 0x0005FE67
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2NavigationCompletedEventArgs)
			If Me.oo_.0oOOOoooo. IsNot Nothing AndAlso Not Me.oo_.0oOOOoooo..Task.IsCompleted Then
				If A_1.IsSuccess Then
					Me.oo_.0oOOOoooo..TrySetResult(0)
					Return
				End If
				Me.oo_.0oOOOoooo..TrySetResult(-1)
			End If
		End Sub

		' Token: 0x06000E85 RID: 3717 RVA: 0x00061CA8 File Offset: 0x0005FEA8
		Public Function NavigationTaskAsync(Optional timeoutSeconds As Integer = 30) As Task(Of Integer)
			Dim oO__ As WebViewer.oO__ = Nothing
			oO__.Ooo.0O__00O. = Me
			oO__.o__00o.0_oO_o_. = timeoutSeconds
			oO__.Ooo.0O__00O. = -1
			oO__.Ooo.0O__00O. = AsyncTaskMethodBuilder(Of Integer).Create()
			oO__.Ooo.0O__00O..Start(Of WebViewer.oO__)(oO__)
			Return oO__.Ooo.0O__00O..Task
		End Function

		' Token: 0x17000299 RID: 665
		' (get) Token: 0x06000E86 RID: 3718 RVA: 0x00061CFB File Offset: 0x0005FEFB
		' (set) Token: 0x06000E87 RID: 3719 RVA: 0x00061D0D File Offset: 0x0005FF0D
		Public Property DefaultDownloadFolderPath As String
			Get
				Return MyBase.CoreWebView2.Profile.DefaultDownloadFolderPath
			End Get
			Set(value As String)
				MyBase.CoreWebView2.Profile.DefaultDownloadFolderPath = value
			End Set
		End Property

		' Token: 0x06000E88 RID: 3720 RVA: 0x00061D20 File Offset: 0x0005FF20
		Public Sub OpenDefaultDownloadDialog()
			MyBase.CoreWebView2.OpenDefaultDownloadDialog()
		End Sub

		' Token: 0x06000E89 RID: 3721 RVA: 0x00061D2D File Offset: 0x0005FF2D
		Public Sub CloseDefaultDownloadDialog()
			MyBase.CoreWebView2.CloseDefaultDownloadDialog()
		End Sub

		' Token: 0x1700029A RID: 666
		' (get) Token: 0x06000E8A RID: 3722 RVA: 0x00061D3A File Offset: 0x0005FF3A
		Public ReadOnly Property IsDefaultDownloadDialogOpen As Object
			Get
				Return MyBase.CoreWebView2.IsDefaultDownloadDialogOpen
			End Get
		End Property

		' Token: 0x06000E8B RID: 3723 RVA: 0x00061D4C File Offset: 0x0005FF4C
		Public Sub DownLoadFile(url As String, fileName As String)
			If Path.IsPathRooted(fileName) Then
				Me.DefaultDownloadFolderPath = OO_00oOO.FileSys.GetParentPath(fileName)
			End If
			fileName = OO_00oOO.FileSys.GetName(fileName)
			Dim text As String = New XCData(vbLf & "(function(downloadUrl, fileName) {" & vbLf & "    var a = document.createElement('a');" & vbLf & "    a.style.display = 'none';" & vbLf & "    a.href = downloadUrl;" & vbLf & "    a.download = fileName;" & vbLf & "    document.body.appendChild(a);" & vbLf & "    a.click();" & vbLf & "    document.body.removeChild(a);" & vbLf & "})").Value
			text = String.Concat(New String() { text, "(""", url, """,""", fileName.Replace("\", "\\"), """)" })
			MyBase.ExecuteScriptAsync(text)
		End Sub

		' Token: 0x06000E8C RID: 3724 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		Public Function DownloadTaskAsync(Optional timeoutSeconds As Integer = 30) As Task(Of CoreWebView2DownloadOperation)
			Dim oO__O00O As WebViewer.oO__O00O = Nothing
			oO__O00O.O00O.o_. = Me
			oO__O00O.O0oOo00O0o_.O. = timeoutSeconds
			oO__O00O.Ooo.0O__00O. = -1
			oO__O00O.Ooo.0O__00O. = AsyncTaskMethodBuilder(Of CoreWebView2DownloadOperation).Create()
			oO__O00O.Ooo.0O__00O..Start(Of WebViewer.oO__O00O)(oO__O00O)
			Return oO__O00O.Ooo.0O__00O..Task
		End Function

		' Token: 0x06000E8D RID: 3725 RVA: 0x00061E2C File Offset: 0x0006002C
		Friend Sub <<EMPTY_NAME>>()
			MyBase.[Stop]()
			For Each coreWebView2DownloadOperation As CoreWebView2DownloadOperation In Me.oo_.0oOOOoooo..Keys.ToArray()
				Dim eventHandler As EventHandler(Of Object) = Nothing
				If Me.oo_.0oOOOoooo..TryGetValue(coreWebView2DownloadOperation, eventHandler) Then
					coreWebView2DownloadOperation.StateChanged -= eventHandler
				End If
			Next
			For Each coreWebView2DownloadOperation2 As CoreWebView2DownloadOperation In Me.OoO.oOOoo..Keys.ToArray()
				Dim eventHandler2 As EventHandler(Of Object) = Nothing
				If Me.OoO.oOOoo..TryGetValue(coreWebView2DownloadOperation2, eventHandler2) Then
					coreWebView2DownloadOperation2.BytesReceivedChanged -= eventHandler2
				End If
			Next
			For Each coreWebView2DownloadOperation3 As CoreWebView2DownloadOperation In Me.oo_.0oOOOoooo..Keys.ToArray()
				If coreWebView2DownloadOperation3.State Is Nothing Then
					coreWebView2DownloadOperation3.Cancel()
				End If
			Next
			Me.oo_.0oOOOoooo..Clear()
			Me.OoO.oOOoo..Clear()
			Me.oo_.0oOOOoooo..Clear()
		End Sub

		' Token: 0x04000594 RID: 1428
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000595 RID: 1429
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000596 RID: 1430
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000597 RID: 1431
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000598 RID: 1432
		Private <<EMPTY_NAME>> As TaskCompletionSource(Of Integer)

		' Token: 0x04000599 RID: 1433
		Friend <<EMPTY_NAME>> As ConcurrentDictionary(Of CoreWebView2DownloadOperation, TaskCompletionSource(Of Integer))

		' Token: 0x0400059A RID: 1434
		Friend <<EMPTY_NAME>> As TaskCompletionSource(Of CoreWebView2DownloadOperation)

		' Token: 0x0400059B RID: 1435
		Friend <<EMPTY_NAME>> As ConcurrentDictionary(Of CoreWebView2DownloadOperation, EventHandler(Of Object))

		' Token: 0x0400059C RID: 1436
		Friend <<EMPTY_NAME>> As ConcurrentDictionary(Of CoreWebView2DownloadOperation, EventHandler(Of Object))

		' Token: 0x0200012D RID: 301
		<CompilerGenerated()>
		Friend NotInheritable Class OOO_
			' Token: 0x06000E95 RID: 3733 RVA: 0x000623F6 File Offset: 0x000605F6
			Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CoreWebView2NavigationCompletedEventArgs)
				If A_1.IsSuccess Then
					Me.oo_.0oOOOoooo..TrySetResult(0)
					Return
				End If
				Me.oo_.0oOOOoooo..TrySetResult(-1)
			End Sub

			' Token: 0x040005B0 RID: 1456
			Public <<EMPTY_NAME>> As TaskCompletionSource(Of Integer)
		End Class
	End Class
End Namespace
