Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000489 RID: 1161
	<OoO0___o("RibbbonSubtotalModeList")>
	Friend Class RibbonSubtotalModeList
		Inherits RibbonItem

		' Token: 0x06004D1B RID: 19739 RVA: 0x00201641 File Offset: 0x001FF841
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700116B RID: 4459
		' (get) Token: 0x06004D1C RID: 19740 RVA: 0x00201652 File Offset: 0x001FF852
		' (set) Token: 0x06004D1D RID: 19741 RVA: 0x0020166D File Offset: 0x001FF86D
		<Category("属性")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		Public Property Text As String
			Get
				If Me.O._oo0__0o. Is Nothing Then
					Me.O._oo0__0o. = ""
				End If
				Return Me.O._oo0__0o.
			End Get
			Set(value As String)
				Me.O._oo0__0o. = value
			End Set
		End Property

		' Token: 0x04001FA8 RID: 8104
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
