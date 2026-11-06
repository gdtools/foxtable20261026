Imports System
Imports System.Collections.Generic
Imports System.Dynamic
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports Microsoft.VisualBasic.CompilerServices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Foxtable
	' Token: 0x020001E0 RID: 480
	Public Class LLMCaller
		' Token: 0x06001720 RID: 5920 RVA: 0x00094938 File Offset: 0x00092B38
		Public Sub New()
			Me.KeepToolCallsInHistory = New Boolean?(True)
			Me.MaxToolSteps = 10
			Me.PrefixKey = "prefix"
		End Sub

		' Token: 0x06001721 RID: 5921 RVA: 0x0009495F File Offset: 0x00092B5F
		Public Sub New(A_0 As String)
			Me.KeepToolCallsInHistory = New Boolean?(True)
			Me.MaxToolSteps = 10
			Me.PrefixKey = "prefix"
			Me.BaseUrl = A_0
		End Sub

		' Token: 0x06001722 RID: 5922 RVA: 0x0009498D File Offset: 0x00092B8D
		Public Sub New(A_0 As String, A_1 As String)
			Me.KeepToolCallsInHistory = New Boolean?(True)
			Me.MaxToolSteps = 10
			Me.PrefixKey = "prefix"
			Me.BaseUrl = A_0
			Me.model = A_1
		End Sub

		' Token: 0x06001723 RID: 5923 RVA: 0x000949C2 File Offset: 0x00092BC2
		Public Sub New(A_0 As String, A_1 As String, A_2 As String)
			Me.KeepToolCallsInHistory = New Boolean?(True)
			Me.MaxToolSteps = 10
			Me.PrefixKey = "prefix"
			Me.BaseUrl = A_0
			Me.model = A_1
			Me.ApiKey = A_2
		End Sub

		' Token: 0x170004F6 RID: 1270
		' (get) Token: 0x06001724 RID: 5924 RVA: 0x000949FE File Offset: 0x00092BFE
		' (set) Token: 0x06001725 RID: 5925 RVA: 0x00094A06 File Offset: 0x00092C06
		Public Property BaseUrl As String

		' Token: 0x170004F7 RID: 1271
		' (get) Token: 0x06001726 RID: 5926 RVA: 0x00094A0F File Offset: 0x00092C0F
		' (set) Token: 0x06001727 RID: 5927 RVA: 0x00094A17 File Offset: 0x00092C17
		Public Property ApiKey As String
			Get
				Return Me.o.0o_.
			End Get
			Set(value As String)
				If Not String.IsNullOrEmpty(value) AndAlso Not value.StartsWith("Bearer ") Then
					value = "Bearer " + value
				End If
				Me.o.0o_. = value
			End Set
		End Property

		' Token: 0x170004F8 RID: 1272
		' (get) Token: 0x06001728 RID: 5928 RVA: 0x00094A42 File Offset: 0x00092C42
		' (set) Token: 0x06001729 RID: 5929 RVA: 0x00094A4A File Offset: 0x00092C4A
		Public Property Messages As JArray

		' Token: 0x170004F9 RID: 1273
		' (get) Token: 0x0600172A RID: 5930 RVA: 0x00094A53 File Offset: 0x00092C53
		' (set) Token: 0x0600172B RID: 5931 RVA: 0x00094A5B File Offset: 0x00092C5B
		Public Property UserMessage As Object
			<CompilerGenerated()>
			Get
				Return Me.a
			End Get
			<CompilerGenerated()>
			Set(value As Object)
				Me.a = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170004FA RID: 1274
		' (get) Token: 0x0600172C RID: 5932 RVA: 0x00094A69 File Offset: 0x00092C69
		' (set) Token: 0x0600172D RID: 5933 RVA: 0x00094A71 File Offset: 0x00092C71
		Public Property SystemPrompt As String

		' Token: 0x170004FB RID: 1275
		' (get) Token: 0x0600172E RID: 5934 RVA: 0x00094A7A File Offset: 0x00092C7A
		' (set) Token: 0x0600172F RID: 5935 RVA: 0x00094A82 File Offset: 0x00092C82
		Public Property KeepReasoningInHistory As Boolean?

		' Token: 0x170004FC RID: 1276
		' (get) Token: 0x06001730 RID: 5936 RVA: 0x00094A8B File Offset: 0x00092C8B
		' (set) Token: 0x06001731 RID: 5937 RVA: 0x00094A93 File Offset: 0x00092C93
		Public Property KeepToolCallsInHistory As Boolean?

		' Token: 0x170004FD RID: 1277
		' (get) Token: 0x06001732 RID: 5938 RVA: 0x00094A9C File Offset: 0x00092C9C
		Private ReadOnly Property Tools As AIToolBuilder
			Get
				If Me.a Is Nothing Then
					Me.a = New AIToolBuilder()
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x06001733 RID: 5939 RVA: 0x00094AB7 File Offset: 0x00092CB7
		Public Function AddTool(name As String, description As String) As AITool
			Return Me.Tools.AddFunction(name, description)
		End Function

		' Token: 0x170004FE RID: 1278
		' (get) Token: 0x06001734 RID: 5940 RVA: 0x00094AC6 File Offset: 0x00092CC6
		' (set) Token: 0x06001735 RID: 5941 RVA: 0x00094ACE File Offset: 0x00092CCE
		Public Property ToolExecutor As Func(Of String, JObject, String)

		' Token: 0x170004FF RID: 1279
		' (get) Token: 0x06001736 RID: 5942 RVA: 0x00094AD7 File Offset: 0x00092CD7
		' (set) Token: 0x06001737 RID: 5943 RVA: 0x00094ADF File Offset: 0x00092CDF
		Public Property SSEStreamHandler As Action(Of String, String)

		' Token: 0x17000500 RID: 1280
		' (get) Token: 0x06001738 RID: 5944 RVA: 0x00094AE8 File Offset: 0x00092CE8
		' (set) Token: 0x06001739 RID: 5945 RVA: 0x00094AF0 File Offset: 0x00092CF0
		Public Property MaxToolSteps As Integer

		' Token: 0x17000501 RID: 1281
		' (get) Token: 0x0600173A RID: 5946 RVA: 0x00094AF9 File Offset: 0x00092CF9
		Public ReadOnly Property Headers As JObject
			Get
				If Me.a Is Nothing Then
					Me.a = New JObject()
				End If
				Return Me.a
			End Get
		End Property

		' Token: 0x17000502 RID: 1282
		' (get) Token: 0x0600173B RID: 5947 RVA: 0x00094B14 File Offset: 0x00092D14
		' (set) Token: 0x0600173C RID: 5948 RVA: 0x00094B1C File Offset: 0x00092D1C
		Public Property model As String

		' Token: 0x17000503 RID: 1283
		' (get) Token: 0x0600173D RID: 5949 RVA: 0x00094B25 File Offset: 0x00092D25
		' (set) Token: 0x0600173E RID: 5950 RVA: 0x00094B2D File Offset: 0x00092D2D
		Public Property stream As Boolean

		' Token: 0x17000504 RID: 1284
		' (get) Token: 0x0600173F RID: 5951 RVA: 0x00094B36 File Offset: 0x00092D36
		' (set) Token: 0x06001740 RID: 5952 RVA: 0x00094B3E File Offset: 0x00092D3E
		Public Property temperature As Double?

		' Token: 0x17000505 RID: 1285
		' (get) Token: 0x06001741 RID: 5953 RVA: 0x00094B47 File Offset: 0x00092D47
		' (set) Token: 0x06001742 RID: 5954 RVA: 0x00094B4F File Offset: 0x00092D4F
		Public Property top_p As Double?

		' Token: 0x17000506 RID: 1286
		' (get) Token: 0x06001743 RID: 5955 RVA: 0x00094B58 File Offset: 0x00092D58
		' (set) Token: 0x06001744 RID: 5956 RVA: 0x00094B60 File Offset: 0x00092D60
		Public Property max_completion_tokens As Integer?

		' Token: 0x17000507 RID: 1287
		' (get) Token: 0x06001745 RID: 5957 RVA: 0x00094B69 File Offset: 0x00092D69
		' (set) Token: 0x06001746 RID: 5958 RVA: 0x00094B71 File Offset: 0x00092D71
		Public Property max_tokens As Integer?

		' Token: 0x17000508 RID: 1288
		' (get) Token: 0x06001747 RID: 5959 RVA: 0x00094B7A File Offset: 0x00092D7A
		' (set) Token: 0x06001748 RID: 5960 RVA: 0x00094B82 File Offset: 0x00092D82
		Public Property n As Integer?

		' Token: 0x17000509 RID: 1289
		' (get) Token: 0x06001749 RID: 5961 RVA: 0x00094B8B File Offset: 0x00092D8B
		' (set) Token: 0x0600174A RID: 5962 RVA: 0x00094B93 File Offset: 0x00092D93
		Public Property seed As Integer?

		' Token: 0x1700050A RID: 1290
		' (get) Token: 0x0600174B RID: 5963 RVA: 0x00094B9C File Offset: 0x00092D9C
		' (set) Token: 0x0600174C RID: 5964 RVA: 0x00094BA4 File Offset: 0x00092DA4
		Public Property [stop] As JArray

		' Token: 0x1700050B RID: 1291
		' (get) Token: 0x0600174D RID: 5965 RVA: 0x00094BAD File Offset: 0x00092DAD
		' (set) Token: 0x0600174E RID: 5966 RVA: 0x00094BB5 File Offset: 0x00092DB5
		Public Property presence_penalty As Double?

		' Token: 0x1700050C RID: 1292
		' (get) Token: 0x0600174F RID: 5967 RVA: 0x00094BBE File Offset: 0x00092DBE
		' (set) Token: 0x06001750 RID: 5968 RVA: 0x00094BC6 File Offset: 0x00092DC6
		Public Property frequency_penalty As Double?

		' Token: 0x1700050D RID: 1293
		' (get) Token: 0x06001751 RID: 5969 RVA: 0x00094BCF File Offset: 0x00092DCF
		' (set) Token: 0x06001752 RID: 5970 RVA: 0x00094BD7 File Offset: 0x00092DD7
		Public Property logprobs As Boolean?

		' Token: 0x1700050E RID: 1294
		' (get) Token: 0x06001753 RID: 5971 RVA: 0x00094BE0 File Offset: 0x00092DE0
		' (set) Token: 0x06001754 RID: 5972 RVA: 0x00094BE8 File Offset: 0x00092DE8
		Public Property top_logprobs As Integer?

		' Token: 0x1700050F RID: 1295
		' (get) Token: 0x06001755 RID: 5973 RVA: 0x00094BF1 File Offset: 0x00092DF1
		' (set) Token: 0x06001756 RID: 5974 RVA: 0x00094BF9 File Offset: 0x00092DF9
		Public Property logit_bias As JObject

		' Token: 0x17000510 RID: 1296
		' (get) Token: 0x06001757 RID: 5975 RVA: 0x00094C02 File Offset: 0x00092E02
		' (set) Token: 0x06001758 RID: 5976 RVA: 0x00094C0A File Offset: 0x00092E0A
		Public Property user As String

		' Token: 0x17000511 RID: 1297
		' (get) Token: 0x06001759 RID: 5977 RVA: 0x00094C13 File Offset: 0x00092E13
		' (set) Token: 0x0600175A RID: 5978 RVA: 0x00094C1B File Offset: 0x00092E1B
		Public Property tool_choice As String

		' Token: 0x17000512 RID: 1298
		' (get) Token: 0x0600175B RID: 5979 RVA: 0x00094C24 File Offset: 0x00092E24
		' (set) Token: 0x0600175C RID: 5980 RVA: 0x00094C2C File Offset: 0x00092E2C
		Public Property parallel_tool_calls As Boolean?

		' Token: 0x17000513 RID: 1299
		' (get) Token: 0x0600175D RID: 5981 RVA: 0x00094C35 File Offset: 0x00092E35
		' (set) Token: 0x0600175E RID: 5982 RVA: 0x00094C3D File Offset: 0x00092E3D
		Public Property response_format As Object
			<CompilerGenerated()>
			Get
				Return Me.o_Ooo._OO0.
			End Get
			<CompilerGenerated()>
			Set(value As Object)
				Me.o_Ooo._OO0. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17000514 RID: 1300
		' (get) Token: 0x0600175F RID: 5983 RVA: 0x00094C4B File Offset: 0x00092E4B
		' (set) Token: 0x06001760 RID: 5984 RVA: 0x00094C53 File Offset: 0x00092E53
		Public Property stream_options As JObject

		' Token: 0x17000515 RID: 1301
		' (get) Token: 0x06001761 RID: 5985 RVA: 0x00094C5C File Offset: 0x00092E5C
		' (set) Token: 0x06001762 RID: 5986 RVA: 0x00094C64 File Offset: 0x00092E64
		Public Property service_tier As String

		' Token: 0x17000516 RID: 1302
		' (get) Token: 0x06001763 RID: 5987 RVA: 0x00094C6D File Offset: 0x00092E6D
		' (set) Token: 0x06001764 RID: 5988 RVA: 0x00094C75 File Offset: 0x00092E75
		Public Property store As Boolean?

		' Token: 0x17000517 RID: 1303
		' (get) Token: 0x06001765 RID: 5989 RVA: 0x00094C7E File Offset: 0x00092E7E
		' (set) Token: 0x06001766 RID: 5990 RVA: 0x00094C86 File Offset: 0x00092E86
		Public Property metadata As JObject

		' Token: 0x17000518 RID: 1304
		' (get) Token: 0x06001767 RID: 5991 RVA: 0x00094C8F File Offset: 0x00092E8F
		' (set) Token: 0x06001768 RID: 5992 RVA: 0x00094C97 File Offset: 0x00092E97
		Public Property verbosity As String

		' Token: 0x17000519 RID: 1305
		' (get) Token: 0x06001769 RID: 5993 RVA: 0x00094CA0 File Offset: 0x00092EA0
		' (set) Token: 0x0600176A RID: 5994 RVA: 0x00094CA8 File Offset: 0x00092EA8
		Public Property reasoning_effort As String

		' Token: 0x1700051A RID: 1306
		' (get) Token: 0x0600176B RID: 5995 RVA: 0x00094CB1 File Offset: 0x00092EB1
		Public ReadOnly Property extra_body As Object
			Get
				If Me.OO_o0_0_0_O._. Is Nothing Then
					Me.OO_o0_0_0_O._. = New ExpandoObject()
				End If
				Return Me.OO_o0_0_0_O._.
			End Get
		End Property

		' Token: 0x1700051B RID: 1307
		' (get) Token: 0x0600176C RID: 5996 RVA: 0x00094CCC File Offset: 0x00092ECC
		Public ReadOnly Property Result As String
			Get
				Return Me.O0O_.OoOo.
			End Get
		End Property

		' Token: 0x1700051C RID: 1308
		' (get) Token: 0x0600176D RID: 5997 RVA: 0x00094CD4 File Offset: 0x00092ED4
		Public ReadOnly Property Think As String
			Get
				Return Me.a
			End Get
		End Property

		' Token: 0x1700051D RID: 1309
		' (get) Token: 0x0600176E RID: 5998 RVA: 0x00094CDC File Offset: 0x00092EDC
		Public ReadOnly Property [Error] As String
			Get
				Return Me.O0o_.0.
			End Get
		End Property

		' Token: 0x1700051E RID: 1310
		' (get) Token: 0x0600176F RID: 5999 RVA: 0x00094CE4 File Offset: 0x00092EE4
		Public ReadOnly Property ResultJObject As JObject
			Get
				Return Me.O0oo.OO00Oo_Oo.
			End Get
		End Property

		' Token: 0x06001770 RID: 6000 RVA: 0x00094CEC File Offset: 0x00092EEC
		Private Function <<EMPTY_NAME>>(A_0 As Boolean) As String
			Me.O0oo.OO00Oo_Oo. = Nothing
			Me.O0o_.0. = Nothing
			Me.O0O_.OoOo. = Nothing
			Me.a = Nothing
			Dim result As String
			If String.IsNullOrEmpty(Me.BaseUrl) Then
				result = "BaseUrl 未设置"
			Else
				String.IsNullOrEmpty(Me.ApiKey)
				If Me.a IsNot Nothing AndAlso Me.Tools.Count > 0 AndAlso Me.ToolExecutor Is Nothing Then
					result = "Tools 非空但 ToolExecutor 未设置"
				Else
					If A_0 Then
						If(Me.stream AndAlso Me.SSEStreamHandler Is Nothing) OrElse (Not Me.stream AndAlso Me.SSEStreamHandler IsNot Nothing) Then
							Return "stream 和 SSEStreamHandler 需要同时设置才能使用流"
						End If
					ElseIf Me.SSEStreamHandler IsNot Nothing OrElse Me.stream Then
						Return "同步方法不支持流模式"
					End If
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x06001771 RID: 6001 RVA: 0x00094DA4 File Offset: 0x00092FA4
		Private Function <<EMPTY_NAME>>(A_0 As Boolean, A_1 As Boolean) As <TupleElementNames(New String() { "bodyJo", "workingMsgs", "hc" })> ValueTuple(Of JObject, JArray, HttpClient)
			Dim jarray As JArray
			If A_1 Then
				If Me.Messages.Count = 0 AndAlso Not String.IsNullOrEmpty(Me.SystemPrompt) Then
					Dim jobject As JObject = New JObject()
					jobject("role") = "system"
					jobject("content") = Me.SystemPrompt
					Me.Messages.Add(jobject)
				End If
				If Me.UserMessage IsNot Nothing Then
					Dim jobject2 As JObject = New JObject()
					jobject2("role") = "user"
					If TypeOf Me.UserMessage Is String Then
						jobject2("content") = Conversions.ToString(Me.UserMessage)
					ElseIf TypeOf Me.UserMessage Is JArray Then
						jobject2("content") = CType(Me.UserMessage, JArray)
					End If
					Me.Messages.Add(jobject2)
				End If
				jarray = CType(Me.Messages.DeepClone(), JArray)
			Else
				jarray = New JArray()
				If Not String.IsNullOrEmpty(Me.SystemPrompt) Then
					Dim jobject3 As JObject = New JObject()
					jobject3("role") = "system"
					jobject3("content") = Me.SystemPrompt
					jarray.Add(jobject3)
				End If
				If Me.UserMessage IsNot Nothing Then
					Dim jobject4 As JObject = New JObject()
					jobject4("role") = "user"
					If TypeOf Me.UserMessage Is String Then
						jobject4("content") = Conversions.ToString(Me.UserMessage)
					ElseIf TypeOf Me.UserMessage Is JArray Then
						jobject4("content") = CType(Me.UserMessage, JArray)
					End If
					jarray.Add(jobject4)
				End If
			End If
			If Not String.IsNullOrEmpty(Me.PrefixContent) AndAlso Not String.IsNullOrWhiteSpace(Me.PrefixContent) Then
				Dim jarray2 As JArray = jarray
				Dim jobject5 As JObject = New JObject()
				jobject5.Add("role", "assistant")
				jobject5.Add("content", Me.PrefixContent)
				jobject5.Add(Me.PrefixKey, True)
				jarray2.Add(jobject5)
			End If
			Dim jobject6 As JObject = New JObject()
			jobject6("model") = Me.model
			If Me.a IsNot Nothing AndAlso Me.Tools.Count > 0 Then
				Dim text As String = Me.Tools.Build(True)
				jobject6("tools") = CType(JsonConvert.DeserializeObject(text), JArray)
			End If
			If A_0 Then
				jobject6("stream") = A_0
			End If
			If Me.temperature IsNot Nothing Then
				jobject6("temperature") = Me.temperature.Value
			End If
			If Me.top_p IsNot Nothing Then
				jobject6("top_p") = Me.top_p.Value
			End If
			If Me.max_completion_tokens IsNot Nothing Then
				jobject6("max_completion_tokens") = Me.max_completion_tokens.Value
			End If
			If Me.max_tokens IsNot Nothing Then
				jobject6("max_tokens") = Me.max_tokens.Value
			End If
			If Me.n IsNot Nothing Then
				jobject6("n") = Me.n.Value
			End If
			If Me.seed IsNot Nothing Then
				jobject6("seed") = Me.seed.Value
			End If
			If Me.[stop] IsNot Nothing AndAlso Me.[stop].Count > 0 Then
				jobject6("stop") = Me.[stop]
			End If
			If Me.presence_penalty IsNot Nothing Then
				jobject6("presence_penalty") = Me.presence_penalty.Value
			End If
			If Me.frequency_penalty IsNot Nothing Then
				jobject6("frequency_penalty") = Me.frequency_penalty.Value
			End If
			If Me.logprobs IsNot Nothing Then
				jobject6("logprobs") = Me.logprobs.Value
			End If
			If Me.top_logprobs IsNot Nothing Then
				jobject6("top_logprobs") = Me.top_logprobs.Value
			End If
			If Me.logit_bias IsNot Nothing AndAlso Me.logit_bias.Count > 0 Then
				jobject6("logit_bias") = Me.logit_bias
			End If
			If Not String.IsNullOrEmpty(Me.user) Then
				jobject6("user") = Me.user
			End If
			If Not String.IsNullOrEmpty(Me.tool_choice) Then
				jobject6("tool_choice") = Me.tool_choice
			End If
			If Me.parallel_tool_calls IsNot Nothing Then
				jobject6("parallel_tool_calls") = Me.parallel_tool_calls.Value
			End If
			If Me.response_format IsNot Nothing Then
				If TypeOf Me.response_format Is String Then
					Dim jobject7 As JObject = jobject6
					Dim text2 As String = "response_format"
					Dim jobject8 As JObject = New JObject()
					jobject8.Add("type", Me.response_format.ToString())
					jobject7(text2) = jobject8
				ElseIf TypeOf Me.response_format Is JToken Then
					jobject6("response_format") = CType(Me.response_format, JToken)
				End If
			End If
			If Me.stream_options IsNot Nothing AndAlso Me.stream_options.Count > 0 Then
				jobject6("stream_options") = Me.stream_options
			End If
			If Not String.IsNullOrEmpty(Me.service_tier) Then
				jobject6("service_tier") = Me.service_tier
			End If
			If Me.store IsNot Nothing Then
				jobject6("store") = Me.store.Value
			End If
			If Me.metadata IsNot Nothing AndAlso Me.metadata.Count > 0 Then
				jobject6("metadata") = Me.metadata
			End If
			If Not String.IsNullOrEmpty(Me.verbosity) Then
				jobject6("verbosity") = Me.verbosity
			End If
			If Not String.IsNullOrEmpty(Me.reasoning_effort) Then
				jobject6("reasoning_effort") = Me.reasoning_effort
			End If
			If Me.OO_o0_0_0_O._. IsNot Nothing AndAlso CType(CType(Me.OO_o0_0_0_O._., ExpandoObject), ICollection(Of KeyValuePair(Of String, Object))).Count > 0 Then
				Dim jobject9 As JObject = JObject.Parse(JsonConvert.SerializeObject(RuntimeHelpers.GetObjectValue(Me.OO_o0_0_0_O._.)))
				Try
					For Each jproperty As JProperty In jobject9.Properties()
						jobject6(jproperty.Name) = jproperty.Value
					Next
				Finally
					Dim enumerator As IEnumerator(Of JProperty)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			jobject6("messages") = jarray
			Dim httpClient As HttpClient = New HttpClient(Me.BaseUrl)
			httpClient.SkipError = True
			httpClient.ContentType = "application/json"
			If Not String.IsNullOrEmpty(Me.ApiKey) Then
				httpClient.Headers.Add("Authorization", Me.ApiKey)
			End If
			If Me.a IsNot Nothing Then
				Try
					For Each jproperty2 As JProperty In Me.a.Properties()
						httpClient.Headers.Add(jproperty2.Name, jproperty2.Value.ToString())
					Next
				Finally
					Dim enumerator2 As IEnumerator(Of JProperty)
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
				End Try
			End If
			httpClient.Content = jobject6.ToString()
			Return New ValueTuple(Of JObject, JArray, HttpClient)(jobject6, jarray, httpClient)
		End Function

		' Token: 0x06001772 RID: 6002 RVA: 0x0009557C File Offset: 0x0009377C
		Public Function GetResultAsync() As Task(Of Boolean)
			Dim a As LLMCaller.a = Nothing
			a.a = Me
			a.a = -1
			a.a = AsyncTaskMethodBuilder(Of Boolean).Create()
			a.a.Start(Of LLMCaller.a)(a)
			Return a.a.Task
		End Function

		' Token: 0x06001773 RID: 6003 RVA: 0x000955C8 File Offset: 0x000937C8
		Private Function <<EMPTY_NAME>>(A_0 As JObject, A_1 As JObject, A_2 As Boolean, A_3 As JArray, A_4 As HttpClient) As HttpClient
			Dim jobject As JObject = CType(A_1("choices")(0)("message"), JObject)
			If A_2 Then
				If jobject.ContainsKey("tool_calls") AndAlso CType(jobject("tool_calls"), JArray).Count > 0 Then
					If Me.KeepToolCallsInHistory IsNot Nothing Then
						Dim flag As Boolean? = Me.KeepToolCallsInHistory
						If If((flag IsNot Nothing), New Boolean?(flag.GetValueOrDefault()), Nothing).GetValueOrDefault() Then
							Dim jobject2 As JObject = New JObject()
							jobject2("role") = "assistant"
							If jobject.ContainsKey("content") Then
								jobject2("content") = jobject("content")
							End If
							Dim flag2 As Boolean?
							Dim obj As Object
							If Me.KeepReasoningInHistory IsNot Nothing Then
								flag2 = Me.KeepReasoningInHistory
								obj = If((flag2 IsNot Nothing), New Boolean?(flag2.GetValueOrDefault()), Nothing)
							Else
								obj = New Boolean?(True)
							End If
							Dim obj2 As Object = obj
							flag = obj2
							flag2 = obj2
							If If((flag2 IsNot Nothing AndAlso Not flag.GetValueOrDefault()), New Boolean?(False), (flag And jobject.ContainsKey("reasoning_content"))).GetValueOrDefault() Then
								jobject2("reasoning_content") = jobject("reasoning_content")
							End If
							Dim flag3 As Boolean? = Me.KeepToolCallsInHistory
							flag = flag3
							flag2 = flag3
							If If((flag2 IsNot Nothing AndAlso Not flag.GetValueOrDefault()), New Boolean?(False), (flag And jobject.ContainsKey("tool_calls"))).GetValueOrDefault() Then
								jobject2("tool_calls") = jobject("tool_calls")
							End If
							Me.Messages.Add(jobject2)
						End If
					End If
				Else
					Dim jobject3 As JObject = New JObject()
					jobject3("role") = "assistant"
					If jobject.ContainsKey("content") Then
						jobject3("content") = jobject("content")
					End If
					If jobject.ContainsKey("reasoning_content") Then
						If Me.a IsNot Nothing AndAlso Me.Tools.Count > 0 AndAlso Me.ToolExecutor IsNot Nothing Then
							If Me.KeepReasoningInHistory IsNot Nothing Then
								Dim flag As Boolean? = Me.KeepReasoningInHistory
								If Not If((flag IsNot Nothing), New Boolean?(flag.GetValueOrDefault()), Nothing).GetValueOrDefault() Then
									GoTo IL_2F0
								End If
							End If
							jobject3("reasoning_content") = jobject("reasoning_content")
						Else
							Dim flag As Boolean? = Me.KeepReasoningInHistory
							If If((flag IsNot Nothing), New Boolean?(flag.GetValueOrDefault()), Nothing).GetValueOrDefault() Then
								jobject3("reasoning_content") = jobject("reasoning_content")
							End If
						End If
					End If
					IL_2F0:
					Me.Messages.Add(jobject3)
				End If
			End If
			Dim result As HttpClient
			If Not jobject.ContainsKey("tool_calls") OrElse CType(jobject("tool_calls"), JArray).Count = 0 Then
				result = Nothing
			Else
				A_3.Add(jobject)
				Try
					For Each jtoken As JToken In jobject("tool_calls")
						Dim jobject4 As JObject = CType(jtoken, JObject)
						Dim text As String = jobject4("function")("name").ToString()
						Dim text2 As String = jobject4("id").ToString()
						Dim text3 As String = jobject4("function")("arguments").ToString()
						Dim text4 As String = ""
						Try
							Dim arg As JObject = JObject.Parse(text3)
							text4 = Me.ToolExecutor(text, arg)
						Catch ex As Exception
							text4 = String.Format("工具(Name:{0})执行异常：", text) + ex.Message
						End Try
						Dim jobject5 As JObject = New JObject()
						jobject5("role") = "tool"
						jobject5("tool_call_id") = text2
						jobject5("content") = text4
						A_3.Add(jobject5)
						Dim flag4 As Boolean? = Me.KeepToolCallsInHistory
						Dim flag As Boolean? = flag4
						Dim flag2 As Boolean? = flag4
						If If((flag2 IsNot Nothing AndAlso Not flag.GetValueOrDefault()), New Boolean?(False), (flag AndAlso A_2)).GetValueOrDefault() Then
							Me.Messages.Add(jobject5)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of JToken)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				A_4 = A_4.Clone()
				A_0("messages") = A_3
				A_4.Content = A_0.ToString()
				result = A_4
			End If
			Return result
		End Function

		' Token: 0x06001774 RID: 6004 RVA: 0x00095AC4 File Offset: 0x00093CC4
		Public Function GetResult() As Boolean
			Dim jobject As JObject = New JObject()
			Dim text As String = Me.OO0.0OoO0.(False)
			Dim result As Boolean
			If Not String.IsNullOrEmpty(text) Then
				Me.O0o_.0. = text
				result = False
			Else
				Dim flag As Boolean = Me.Messages IsNot Nothing
				Dim valueTuple As ValueTuple(Of JObject, JArray, HttpClient) = Me.O._OOOO0_.(False, flag)
				Dim item As JObject = valueTuple.Item1
				Dim item2 As JArray = valueTuple.Item2
				Dim httpClient As HttpClient = valueTuple.Item3
				Dim num As Integer = 0
				Try
					While True
						Dim data As String = httpClient.GetData()
						If httpClient.StatusCode <> 200 Then
							Exit For
						End If
						jobject = CType(JsonConvert.DeserializeObject(data), JObject)
						Dim httpClient2 As HttpClient = Me.o_oO.oO00.(item, jobject, flag, item2, httpClient)
						If httpClient2 Is Nothing Then
							GoTo IL_E2
						End If
						num += 1
						If num > Me.MaxToolSteps Then
							GoTo Block_6
						End If
						httpClient = httpClient2
					End While
					Me.O0o_.0. = "请求失败，状态码：" + Conversions.ToString(httpClient.StatusCode) + "，状态描述：" + httpClient.StatusDescription
					Return False
					Block_6:
					Me.O0o_.0. = "工具调用超过允许的最大步数"
					Return False
					IL_E2:
				Catch ex As Exception
					Me.O0o_.0. = "请求发生异常：" + ex.Message
					Return False
				End Try
				Me.O0oo.OO00Oo_Oo. = jobject
				Me.O0O_.OoOo. = jobject("choices")(0)("message")("content").ToString()
				If jobject("choices")(0)("message")("reasoning_content") IsNot Nothing Then
					Me.a = jobject("choices")(0)("message")("reasoning_content").ToString()
				End If
				result = True
			End If
			Return result
		End Function

		' Token: 0x06001775 RID: 6005 RVA: 0x00095C90 File Offset: 0x00093E90
		Public Function GetRequestBody() As String
			New JObject()
			Dim text As String = Me.OO0.0OoO0.(True)
			Dim result As String
			If Not String.IsNullOrEmpty(text) Then
				result = text
			Else
				Dim a_ As Boolean
				If Me.SSEStreamHandler IsNot Nothing AndAlso Me.stream Then
					a_ = True
				End If
				Dim a_2 As Boolean = Me.Messages IsNot Nothing
				Dim jarray As JArray = Nothing
				If Me.Messages IsNot Nothing Then
					jarray = CType(Me.Messages.DeepClone(), JArray)
				End If
				Dim valueTuple As ValueTuple(Of JObject, JArray, HttpClient) = Me.O._OOOO0_.(a_, a_2)
				If jarray IsNot Nothing AndAlso Me.Messages IsNot Nothing Then
					Me.Messages.Clear()
					Try
						For Each jtoken As JToken In jarray
							Me.Messages.Add(jtoken)
						Next
					Finally
						Dim enumerator As IEnumerator(Of JToken)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
				result = valueTuple.Item3.Content
			End If
			Return result
		End Function

		' Token: 0x06001776 RID: 6006 RVA: 0x00095D6C File Offset: 0x00093F6C
		Public Sub Cancel()
			If Me.ooO0oo.oO_. IsNot Nothing Then
				Me.ooO0oo.oO_..Cancel()
				Me.ooO0oo.oO_. = Nothing
			End If
		End Sub

		' Token: 0x06001777 RID: 6007 RVA: 0x00095D88 File Offset: 0x00093F88
		Public Sub TrimMessages(n As Integer)
			If Me.Messages IsNot Nothing Then
				Dim jarray As JArray = New JArray()
				Dim num As Integer = 0
				For i As Integer = Me.Messages.Count - 1 To 0 Step -1
					Dim jtoken As JToken = Me.Messages(i)
					Dim left As String = (If(jtoken("role"), "")).ToString()
					Dim flag As Boolean
					If num < n OrElse (Operators.CompareString(left, "system", True) = 0 AndAlso Not flag) Then
						jarray.Insert(0, jtoken)
						If Operators.CompareString(left, "system", True) = 0 Then
							flag = True
						End If
					End If
					If Operators.CompareString(left, "user", True) = 0 Then
						num += 1
					End If
					If num >= n AndAlso flag Then
						Exit For
					End If
				Next
				Me.Messages.Clear()
				Try
					For Each jtoken2 As JToken In jarray
						Me.Messages.Add(jtoken2)
					Next
				Finally
					Dim enumerator As IEnumerator(Of JToken)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06001778 RID: 6008 RVA: 0x00095E90 File Offset: 0x00094090
		Public Function EstimateTokenCount(text As String, Optional cnWeight As Double = 0.6, Optional enWeight As Double = 0.3) As Integer
			Dim result As Integer
			If String.IsNullOrEmpty(text) Then
				result = 0
			Else
				Dim num As Double = 0.0
				For Each a_ As Char In text
					If Me.a(a_) Then
						num += cnWeight
					ElseIf Char.IsLetterOrDigit(a_) Then
						num += enWeight
					ElseIf Char.IsWhiteSpace(a_) Then
						num += enWeight * 0.33
					Else
						num += enWeight
					End If
				Next
				result = CInt(Math.Ceiling(num))
			End If
			Return result
		End Function

		' Token: 0x06001779 RID: 6009 RVA: 0x00095F14 File Offset: 0x00094114
		Private Function a(A_0 As Char) As Boolean
			Return(A_0 >= "一"c AndAlso A_0 <= "鿿"c) OrElse (A_0 >= "㐀"c AndAlso A_0 <= "䶿"c) OrElse (CInt(A_0) >= 131072 AndAlso CInt(A_0) <= 173791) OrElse (A_0 >= "豈"c AndAlso A_0 <= "﫿"c) OrElse (A_0 >= "　"c AndAlso A_0 <= "〿"c) OrElse (A_0 >= "＀"c AndAlso A_0 <= "￯"c) OrElse (A_0 >= " "c AndAlso A_0 <= "⁯"c)
		End Function

		' Token: 0x1700051F RID: 1311
		' (get) Token: 0x0600177A RID: 6010 RVA: 0x00095F9A File Offset: 0x0009419A
		' (set) Token: 0x0600177B RID: 6011 RVA: 0x00095FA2 File Offset: 0x000941A2
		Public Property PrefixKey As String

		' Token: 0x17000520 RID: 1312
		' (get) Token: 0x0600177C RID: 6012 RVA: 0x00095FAB File Offset: 0x000941AB
		' (set) Token: 0x0600177D RID: 6013 RVA: 0x00095FB3 File Offset: 0x000941B3
		Public Property PrefixContent As String

		' Token: 0x04000949 RID: 2377
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400094A RID: 2378
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400094B RID: 2379
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As JArray

		' Token: 0x0400094C RID: 2380
		<CompilerGenerated()>
		Private a As Object

		' Token: 0x0400094D RID: 2381
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400094E RID: 2382
		<CompilerGenerated()>
		Private a As Boolean?

		' Token: 0x0400094F RID: 2383
		<CompilerGenerated()>
		Private b As Boolean?

		' Token: 0x04000950 RID: 2384
		Private a As AIToolBuilder

		' Token: 0x04000951 RID: 2385
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Func(Of String, JObject, String)

		' Token: 0x04000952 RID: 2386
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Action(Of String, String)

		' Token: 0x04000953 RID: 2387
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000954 RID: 2388
		Private a As JObject

		' Token: 0x04000955 RID: 2389
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000956 RID: 2390
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000957 RID: 2391
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Double?

		' Token: 0x04000958 RID: 2392
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Double?

		' Token: 0x04000959 RID: 2393
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer?

		' Token: 0x0400095A RID: 2394
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer?

		' Token: 0x0400095B RID: 2395
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer?

		' Token: 0x0400095C RID: 2396
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer?

		' Token: 0x0400095D RID: 2397
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As JArray

		' Token: 0x0400095E RID: 2398
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Double?

		' Token: 0x0400095F RID: 2399
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Double?

		' Token: 0x04000960 RID: 2400
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean?

		' Token: 0x04000961 RID: 2401
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Integer?

		' Token: 0x04000962 RID: 2402
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As JObject

		' Token: 0x04000963 RID: 2403
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000964 RID: 2404
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000965 RID: 2405
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean?

		' Token: 0x04000966 RID: 2406
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object

		' Token: 0x04000967 RID: 2407
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As JObject

		' Token: 0x04000968 RID: 2408
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000969 RID: 2409
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Boolean?

		' Token: 0x0400096A RID: 2410
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As JObject

		' Token: 0x0400096B RID: 2411
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400096C RID: 2412
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400096D RID: 2413
		Private <<EMPTY_NAME>> As Object

		' Token: 0x0400096E RID: 2414
		Private <<EMPTY_NAME>> As CancellationTokenSource

		' Token: 0x0400096F RID: 2415
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000970 RID: 2416
		Private a As String

		' Token: 0x04000971 RID: 2417
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000972 RID: 2418
		Private <<EMPTY_NAME>> As JObject

		' Token: 0x04000973 RID: 2419
		<CompilerGenerated()>
		Private b As String

		' Token: 0x04000974 RID: 2420
		<CompilerGenerated()>
		Private c As String
	End Class
End Namespace
