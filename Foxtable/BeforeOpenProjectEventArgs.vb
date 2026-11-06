Imports System
Imports System.ComponentModel

Namespace Foxtable
	' Token: 0x020002E8 RID: 744
	<oO0oooo("1615")>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class BeforeOpenProjectEventArgs
		Inherits CancelEventArgs

		' Token: 0x06002754 RID: 10068 RVA: 0x0010ADC2 File Offset: 0x00108FC2
		Public Sub New(A_0 As String)
			Me.O.O00. = A_0
		End Sub

		' Token: 0x170008D9 RID: 2265
		' (get) Token: 0x06002755 RID: 10069 RVA: 0x0010ADD1 File Offset: 0x00108FD1
		Public ReadOnly Property File As String
			Get
				Return Me.O.O00.
			End Get
		End Property

		' Token: 0x170008DA RID: 2266
		' (set) Token: 0x06002756 RID: 10070 RVA: 0x0010ADD9 File Offset: 0x00108FD9
		Public WriteOnly Property HideSplashForm As Boolean
			Set(value As Boolean)
				If value Then
					OO_00oOO.CloseSplashForm()
				End If
			End Set
		End Property

		' Token: 0x04001049 RID: 4169
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
