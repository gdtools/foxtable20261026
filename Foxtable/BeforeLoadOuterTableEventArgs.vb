Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020002E7 RID: 743
	<oO0oooo("0670")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeLoadOuterTableEventArgs
		' Token: 0x170008D3 RID: 2259
		' (get) Token: 0x0600274A RID: 10058 RVA: 0x0010AD58 File Offset: 0x00108F58
		Public ReadOnly Property User As UserInfo
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
		End Property

		' Token: 0x0600274B RID: 10059 RVA: 0x0010AD60 File Offset: 0x00108F60
		Public Sub New(A_0 As String, A_1 As String, A_2 As UserInfo)
			Me.o.__0. = A_0
			Me.o0__0_0O0.oO0. = A_1
			Me.o0__0_0O0.oO0. = A_2
		End Sub

		' Token: 0x170008D4 RID: 2260
		' (get) Token: 0x0600274C RID: 10060 RVA: 0x0010AD7D File Offset: 0x00108F7D
		' (set) Token: 0x0600274D RID: 10061 RVA: 0x0010AD85 File Offset: 0x00108F85
		Public Property SelectString As String
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
			Set(value As String)
				Me.o0__0_0O0.oO0. = value
			End Set
		End Property

		' Token: 0x170008D5 RID: 2261
		' (get) Token: 0x0600274E RID: 10062 RVA: 0x0010AD8E File Offset: 0x00108F8E
		Public ReadOnly Property DataTableName As String
			Get
				Return Me.o.__0.
			End Get
		End Property

		' Token: 0x170008D6 RID: 2262
		' (get) Token: 0x0600274F RID: 10063 RVA: 0x0010AD96 File Offset: 0x00108F96
		' (set) Token: 0x06002750 RID: 10064 RVA: 0x0010AD9E File Offset: 0x00108F9E
		Public Property Cancel As Boolean
			Get
				Return Me.o0__0_0O0.oO0.
			End Get
			Set(value As Boolean)
				Me.o0__0_0O0.oO0. = value
			End Set
		End Property

		' Token: 0x170008D7 RID: 2263
		' (get) Token: 0x06002751 RID: 10065 RVA: 0x0010ADA7 File Offset: 0x00108FA7
		' (set) Token: 0x06002752 RID: 10066 RVA: 0x0010ADAF File Offset: 0x00108FAF
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property DataServer As Boolean
			Get
				Return Me.o.__0.
			End Get
			Set(value As Boolean)
				Me.o.__0. = value
			End Set
		End Property

		' Token: 0x170008D8 RID: 2264
		' (set) Token: 0x06002753 RID: 10067 RVA: 0x0010ADB8 File Offset: 0x00108FB8
		Public WriteOnly Property HideSplashForm As Boolean
			Set(value As Boolean)
				If value Then
					OO_00oOO.CloseSplashForm()
				End If
			End Set
		End Property

		' Token: 0x04001044 RID: 4164
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001045 RID: 4165
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001046 RID: 4166
		Private <<EMPTY_NAME>> As UserInfo

		' Token: 0x04001047 RID: 4167
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001048 RID: 4168
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
