Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020002E5 RID: 741
	<oO0oooo("0682")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeConnectOuterDataSourceEventArgs
		' Token: 0x06002735 RID: 10037 RVA: 0x0010ABCE File Offset: 0x00108DCE
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As UserInfo)
			Me.oO.O0O00oo_. = A_0
			Me.o0.OO0OOOO000_. = A_3
			Me.oo00.0oOoO0o. = A_1
			Me.O_0O_._o. = A_2
		End Sub

		' Token: 0x170008C6 RID: 2246
		' (get) Token: 0x06002736 RID: 10038 RVA: 0x0010ABF3 File Offset: 0x00108DF3
		' (set) Token: 0x06002737 RID: 10039 RVA: 0x0010ABFB File Offset: 0x00108DFB
		Public Property ConnectionString As String
			Get
				Return Me.oo00.0oOoO0o.
			End Get
			Set(value As String)
				Me.oo00.0oOoO0o. = value
			End Set
		End Property

		' Token: 0x170008C7 RID: 2247
		' (get) Token: 0x06002738 RID: 10040 RVA: 0x0010AC04 File Offset: 0x00108E04
		Public ReadOnly Property Name As String
			Get
				Return Me.oO.O0O00oo_.
			End Get
		End Property

		' Token: 0x170008C8 RID: 2248
		' (get) Token: 0x06002739 RID: 10041 RVA: 0x0010AC0C File Offset: 0x00108E0C
		Public ReadOnly Property User As UserInfo
			Get
				Return Me.o0.OO0OOOO000_.
			End Get
		End Property

		' Token: 0x170008C9 RID: 2249
		' (get) Token: 0x0600273A RID: 10042 RVA: 0x0010AC14 File Offset: 0x00108E14
		Public ReadOnly Property ProjectFile As String
			Get
				Return Me.O_0O_._o.
			End Get
		End Property

		' Token: 0x170008CA RID: 2250
		' (get) Token: 0x0600273B RID: 10043 RVA: 0x0010AC1C File Offset: 0x00108E1C
		Public ReadOnly Property ProjectPath As String
			Get
				Return OO_00oOO.FileSys.GetParentPath(Me.O_0O_._o.) + "\"
			End Get
		End Property

		' Token: 0x170008CB RID: 2251
		' (set) Token: 0x0600273C RID: 10044 RVA: 0x0010AC38 File Offset: 0x00108E38
		Public WriteOnly Property HideSplashForm As Boolean
			Set(value As Boolean)
				If value Then
					OO_00oOO.CloseSplashForm()
				End If
			End Set
		End Property

		' Token: 0x0600273D RID: 10045 RVA: 0x0010AC44 File Offset: 0x00108E44
		Public Sub EditConnectionString()
			Dim visible As Boolean = Main.ProcessForm.Visible
			Dim o_u3002_u3000_u As O\u3002\u3000\u3000 = New O\u3002\u3000\u3000()
			o_u3002_u3000_u.OO._000_O0o_.().Text = Me.ConnectionString
			Main.ProcessForm.Hide()
			Main.OO_O.o. = 4
			If o_u3002_u3000_u.ShowDialog() = DialogResult.OK Then
				Me.ConnectionString = o_u3002_u3000_u.OO._000_O0o_.().Text
			End If
			Main.ProcessForm.Show()
		End Sub

		' Token: 0x0400103A RID: 4154
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400103B RID: 4155
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400103C RID: 4156
		Private <<EMPTY_NAME>> As UserInfo

		' Token: 0x0400103D RID: 4157
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
