Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000471 RID: 1137
	<OoO0___o("RibbonExcelReportList")>
	Friend Class RibbonCodeReportList
		Inherits RibbonItem

		' Token: 0x06004C26 RID: 19494 RVA: 0x00200B80 File Offset: 0x001FED80
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x170010FB RID: 4347
		' (get) Token: 0x06004C27 RID: 19495 RVA: 0x00200B91 File Offset: 0x001FED91
		' (set) Token: 0x06004C28 RID: 19496 RVA: 0x00200BAC File Offset: 0x001FEDAC
		<DisplayName("标题")>
		<Category("属性")>
		<O_Oo00Oo000O0(1.1)>
		Public Property Text As String
			Get
				If Me.O_o0oO.O00o. Is Nothing Then
					Me.O_o0oO.O00o. = ""
				End If
				Return Me.O_o0oO.O00o.
			End Get
			Set(value As String)
				Me.O_o0oO.O00o. = value
			End Set
		End Property

		' Token: 0x04001F4B RID: 8011
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
