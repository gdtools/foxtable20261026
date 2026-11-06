Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000528 RID: 1320
	<ComVisible(True)>
	<oO0oooo("1480")>
	Public Class WebBrowser
		Inherits Control

		' Token: 0x06005718 RID: 22296 RVA: 0x0022465C File Offset: 0x0022285C
		Public Sub New(A_0 As OOO0_)
			MyBase.New(A_0, ControlTypeEnum.WebBrowser)
			Me.oO._o_00_O. = A_0
		End Sub

		' Token: 0x06005719 RID: 22297 RVA: 0x0022466E File Offset: 0x0022286E
		Public Sub GoBack()
			Me.oO._o_00_O..GoBack()
		End Sub

		' Token: 0x0600571A RID: 22298 RVA: 0x0022467C File Offset: 0x0022287C
		Public Sub GoForward()
			Me.oO._o_00_O..GoForward()
		End Sub

		' Token: 0x0600571B RID: 22299 RVA: 0x0022468A File Offset: 0x0022288A
		Public Sub GoHome()
			Me.oO._o_00_O..GoHome()
		End Sub

		' Token: 0x17001534 RID: 5428
		' (get) Token: 0x0600571C RID: 22300 RVA: 0x00224698 File Offset: 0x00222898
		' (set) Token: 0x0600571D RID: 22301 RVA: 0x002246CC File Offset: 0x002228CC
		Public Property Address As String
			Get
				Dim result As String
				If Me.oO._o_00_O..Url IsNot Nothing Then
					result = Me.oO._o_00_O..Url.AbsoluteUri
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 Then
					Try
						Me.oO._o_00_O..Url = New Uri(value)
						Return
					Catch ex As Exception
						MessageBox.Show(ex.Message)
						Return
					End Try
				End If
				Me.oO._o_00_O..Url = Nothing
			End Set
		End Property

		' Token: 0x0600571E RID: 22302 RVA: 0x00224734 File Offset: 0x00222934
		Public Sub Print()
			Me.oO._o_00_O..ShowPrintDialog()
		End Sub

		' Token: 0x0600571F RID: 22303 RVA: 0x00224741 File Offset: 0x00222941
		Public Sub Preview()
			Me.oO._o_00_O..ShowPrintPreviewDialog()
		End Sub

		' Token: 0x06005720 RID: 22304 RVA: 0x0022474E File Offset: 0x0022294E
		Public Sub ShowSaveAsDialog()
			Me.oO._o_00_O..ShowSaveAsDialog()
		End Sub

		' Token: 0x17001535 RID: 5429
		' (get) Token: 0x06005721 RID: 22305 RVA: 0x0022475B File Offset: 0x0022295B
		' (set) Token: 0x06005722 RID: 22306 RVA: 0x00224768 File Offset: 0x00222968
		Public Property OfficeToolBar As Boolean
			Get
				Return Me.oO._o_00_O..Ooo__.ooO_0.()
			End Get
			Set(value As Boolean)
				Me.oO._o_00_O..OOOo_._oO0_O.(value)
			End Set
		End Property

		' Token: 0x06005723 RID: 22307 RVA: 0x00224776 File Offset: 0x00222976
		Public Sub SaveOffice()
			Me.oO._o_00_O..Ooo0.oO0_o.()
		End Sub

		' Token: 0x06005724 RID: 22308 RVA: 0x00224783 File Offset: 0x00222983
		Public Sub PrintOffice()
			Me.oO._o_00_O..OOoo.OOo0000_.()
		End Sub

		' Token: 0x04002238 RID: 8760
		Private <<EMPTY_NAME>> As OOO0_
	End Class
End Namespace
