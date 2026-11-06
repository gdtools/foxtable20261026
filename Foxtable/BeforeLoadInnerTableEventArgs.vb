Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020002E6 RID: 742
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("0669")>
	Public Class BeforeLoadInnerTableEventArgs
		' Token: 0x0600273E RID: 10046 RVA: 0x0010ACA7 File Offset: 0x00108EA7
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As UserInfo)
			Me.o0OOo.000Oo0. = A_0
			Me.o0._. = A_1
			Me.o._Oo. = A_2
			Me.o0OOo.000Oo0. = A_3
		End Sub

		' Token: 0x170008CC RID: 2252
		' (get) Token: 0x0600273F RID: 10047 RVA: 0x0010ACCC File Offset: 0x00108ECC
		Public ReadOnly Property DataTableName As String
			Get
				Dim result As String
				If Me.o0OOo.000Oo0..StartsWith("~TMPCLP") Then
					result = Me.o0OOo.000Oo0..Substring(7)
				Else
					result = Me.o0OOo.000Oo0.
				End If
				Return result
			End Get
		End Property

		' Token: 0x170008CD RID: 2253
		' (get) Token: 0x06002740 RID: 10048 RVA: 0x0010AD02 File Offset: 0x00108F02
		' (set) Token: 0x06002741 RID: 10049 RVA: 0x0010AD0A File Offset: 0x00108F0A
		Public Property Fields As String
			Get
				Return Me.o0._.
			End Get
			Set(value As String)
				Me.o0._. = value
			End Set
		End Property

		' Token: 0x170008CE RID: 2254
		' (get) Token: 0x06002742 RID: 10050 RVA: 0x0010AD13 File Offset: 0x00108F13
		' (set) Token: 0x06002743 RID: 10051 RVA: 0x0010AD1B File Offset: 0x00108F1B
		Public Property Filter As String
			Get
				Return Me.o._Oo.
			End Get
			Set(value As String)
				Me.o._Oo. = value
			End Set
		End Property

		' Token: 0x170008CF RID: 2255
		' (get) Token: 0x06002744 RID: 10052 RVA: 0x0010AD24 File Offset: 0x00108F24
		Public ReadOnly Property User As UserInfo
			Get
				Return Me.o0OOo.000Oo0.
			End Get
		End Property

		' Token: 0x170008D0 RID: 2256
		' (get) Token: 0x06002745 RID: 10053 RVA: 0x0010AD2C File Offset: 0x00108F2C
		' (set) Token: 0x06002746 RID: 10054 RVA: 0x0010AD34 File Offset: 0x00108F34
		Public Property SelectString As String
			Get
				Return Me.o.00O_OO.
			End Get
			Set(value As String)
				Me.o.00O_OO. = value
			End Set
		End Property

		' Token: 0x170008D1 RID: 2257
		' (get) Token: 0x06002747 RID: 10055 RVA: 0x0010AD3D File Offset: 0x00108F3D
		' (set) Token: 0x06002748 RID: 10056 RVA: 0x0010AD45 File Offset: 0x00108F45
		Public Property Cancel As Boolean
			Get
				Return Me.o0OOo.000Oo0.
			End Get
			Set(value As Boolean)
				Me.o0OOo.000Oo0. = value
			End Set
		End Property

		' Token: 0x170008D2 RID: 2258
		' (set) Token: 0x06002749 RID: 10057 RVA: 0x0010AD4E File Offset: 0x00108F4E
		Public WriteOnly Property HideSplashForm As Boolean
			Set(value As Boolean)
				If value Then
					OO_00oOO.CloseSplashForm()
				End If
			End Set
		End Property

		' Token: 0x0400103E RID: 4158
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400103F RID: 4159
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001040 RID: 4160
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001041 RID: 4161
		Private <<EMPTY_NAME>> As UserInfo

		' Token: 0x04001042 RID: 4162
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001043 RID: 4163
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
