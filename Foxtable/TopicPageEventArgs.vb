Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002A7 RID: 679
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TopicPageEventArgs
		Inherits ControlEventArgs

		' Token: 0x060023E6 RID: 9190 RVA: 0x000F9BF1 File Offset: 0x000F7DF1
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As C1TopicBarPageEventArgs)
			MyBase.New(A_0, A_1)
			Me.O__.o__. = New TopicPage(A_2.Page)
		End Sub

		' Token: 0x17000839 RID: 2105
		' (get) Token: 0x060023E7 RID: 9191 RVA: 0x000F9C0C File Offset: 0x000F7E0C
		Public ReadOnly Property Page As TopicPage
			Get
				Return Me.O__.o__.
			End Get
		End Property

		' Token: 0x04000EDA RID: 3802
		Private <<EMPTY_NAME>> As TopicPage
	End Class
End Namespace
