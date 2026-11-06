Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Net
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001DF RID: 479
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("A0143")>
	Public Class HttpListenter
		' Token: 0x06001712 RID: 5906 RVA: 0x0009456C File Offset: 0x0009276C
		Public Sub New()
			Me.o0oo.Oo. = New Queue(Of RequestEventArgs)()
			Me.oo._o_oo_. = New Queue(Of RequestEventArgs)()
			Me.o.oOOoOOO. = New List(Of RequestEventArgs)()
			Me.o.oOOoOOO. = New List(Of String)()
			Me.oo._o_oo_. = New List(Of String)()
			Me.o.oOOoOOO. = New HashSet(Of String)()
			Me.o.oOOoOOO. = New List(Of O_O_O0_O)()
			Me.o0oo.Oo. = New HttpListener()
			Me.oo._o_oo_..AddRange(".jpg,.gif,.png,.bmp,.wmf,.js,.css,.html,.htm,.zip,.rar,.txt,.json,.svg,.ttf,.woff,.woff2,.eot,.ico,.map,.doc,.docx,.xls,.xlsx".Split(New Char() { ","c }))
		End Sub

		' Token: 0x06001713 RID: 5907 RVA: 0x000945F8 File Offset: 0x000927F8
		Public Sub Start()
			If Not Me.o0oo.Oo..IsListening Then
				Dim obj As Object = Me.o0oo.Oo.
				SyncLock obj
					Me.o0oo.Oo..Clear()
				End SyncLock
				Me.o.oOOoOOO. = False
				Try
					Me.o0oo.Oo..Prefixes.Clear()
					Try
						For Each uriPrefix As String In Me.Prefixes
							Me.o0oo.Oo..Prefixes.Add(uriPrefix)
						Next
					Finally
						Dim enumerator As HashSet(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.o0oo.Oo..Start()
					Me.o0oo.Oo..BeginGetContext(AddressOf Me.o.oOOoOOO., Me.o0oo.Oo.)
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
					Me.o0oo.Oo. = New HttpListener()
				End Try
			End If
		End Sub

		' Token: 0x06001714 RID: 5908 RVA: 0x00094710 File Offset: 0x00092910
		Public Sub Close()
			Dim obj As Object = Me.o0oo.Oo.
			SyncLock obj
				Me.o0oo.Oo..Clear()
			End SyncLock
			Me.o.oOOoOOO..Clear()
			Me.UserProcessHosts.Clear()
			Me.o.oOOoOOO. = True
			Me.Prefixes.Clear()
			Me.o0oo.Oo..Close()
			OO_00oOO.HttpServer = New HttpListenter()
		End Sub

		' Token: 0x170004F0 RID: 1264
		' (get) Token: 0x06001715 RID: 5909 RVA: 0x00094794 File Offset: 0x00092994
		Public ReadOnly Property IsRunning As Boolean
			Get
				Return Me.o0oo.Oo..IsListening
			End Get
		End Property

		' Token: 0x170004F1 RID: 1265
		' (get) Token: 0x06001716 RID: 5910 RVA: 0x000947A1 File Offset: 0x000929A1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property IsSupported As Boolean
			Get
				Return HttpListener.IsSupported
			End Get
		End Property

		' Token: 0x170004F2 RID: 1266
		' (get) Token: 0x06001717 RID: 5911 RVA: 0x000947A8 File Offset: 0x000929A8
		<oO0oooo("A0005")>
		Public ReadOnly Property Prefixes As HashSet(Of String)
			Get
				Return Me.o.oOOoOOO.
			End Get
		End Property

		' Token: 0x170004F3 RID: 1267
		' (get) Token: 0x06001718 RID: 5912 RVA: 0x000947B0 File Offset: 0x000929B0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property UserProcessHosts As List(Of String)
			Get
				Return Me.o.oOOoOOO.
			End Get
		End Property

		' Token: 0x06001719 RID: 5913 RVA: 0x000947B8 File Offset: 0x000929B8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetDefaultEncoding(host As String, path As String, Encoding As String)
			If Operators.CompareString(path, "", True) = 0 Then
				path = "*"
			End If
			Dim o_O_O0_O As O_O_O0_O = New O_O_O0_O()
			o_O_O0_O.O0oO.o_OOoO_. = host
			o_O_O0_O.O.__0O. = path
			o_O_O0_O.oO._0O_. = Encoding
			Me.o.oOOoOOO..Add(o_O_O0_O)
		End Sub

		' Token: 0x0600171A RID: 5914 RVA: 0x00094801 File Offset: 0x00092A01
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetDefaultEncoding(host As String, Encoding As String)
			Me.SetDefaultEncoding(host, "*", Encoding)
		End Sub

		' Token: 0x170004F4 RID: 1268
		' (get) Token: 0x0600171B RID: 5915 RVA: 0x00094810 File Offset: 0x00092A10
		' (set) Token: 0x0600171C RID: 5916 RVA: 0x00094818 File Offset: 0x00092A18
		<oO0oooo("A0276")>
		Public Property WebPath As String
			Get
				Return Me.o.oOOoOOO.
			End Get
			Set(value As String)
				Me.o.oOOoOOO. = value
			End Set
		End Property

		' Token: 0x170004F5 RID: 1269
		' (get) Token: 0x0600171D RID: 5917 RVA: 0x00094821 File Offset: 0x00092A21
		<oO0oooo("A0276")>
		Public ReadOnly Property Extensions As List(Of String)
			Get
				Return Me.oo._o_oo_.
			End Get
		End Property

		' Token: 0x0600171E RID: 5918 RVA: 0x0009482C File Offset: 0x00092A2C
		Private Sub <<EMPTY_NAME>>(A_0 As IAsyncResult)
			If Not Me.o.oOOoOOO. AndAlso Me.Prefixes.Count <> 0 AndAlso Me.o0oo.Oo..IsListening AndAlso Me.o0oo.Oo..IsListening Then
				Me.o0oo.Oo..BeginGetContext(AddressOf Me.o.oOOoOOO., Me.o0oo.Oo.)
				Dim httpListenerContext As HttpListenerContext = Me.o0oo.Oo..EndGetContext(A_0)
				Dim request As HttpListenerRequest = httpListenerContext.Request
				Dim response As HttpListenerResponse = httpListenerContext.Response
				Dim obj As Object = Me.o0oo.Oo.
				SyncLock obj
					If Operators.CompareString(httpListenerContext.Request.RawUrl, "", True) <= 0 OrElse Operators.CompareString(httpListenerContext.Request.RawUrl, "/favicon.ico", True) <> 0 Then
						Me.o0oo.Oo..Enqueue(New RequestEventArgs(httpListenerContext, Me.WebPath, Me.Extensions))
					End If
				End SyncLock
			End If
		End Sub

		' Token: 0x0600171F RID: 5919 RVA: 0x0009492C File Offset: 0x00092B2C
		Private Function <<EMPTY_NAME>>(A_0 As HttpListenerRequest) As String
			Return New StringBuilder().ToString()
		End Function

		' Token: 0x0400093F RID: 2367
		Private <<EMPTY_NAME>> As HttpListener

		' Token: 0x04000940 RID: 2368
		Friend <<EMPTY_NAME>> As Queue(Of RequestEventArgs)

		' Token: 0x04000941 RID: 2369
		Friend <<EMPTY_NAME>> As Queue(Of RequestEventArgs)

		' Token: 0x04000942 RID: 2370
		Friend <<EMPTY_NAME>> As List(Of RequestEventArgs)

		' Token: 0x04000943 RID: 2371
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000944 RID: 2372
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000945 RID: 2373
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000946 RID: 2374
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000947 RID: 2375
		Private <<EMPTY_NAME>> As HashSet(Of String)

		' Token: 0x04000948 RID: 2376
		Friend <<EMPTY_NAME>> As List(Of O_O_O0_O)
	End Class
End Namespace
