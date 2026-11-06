Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x0200048C RID: 1164
	<OoO0___o("RibbonTableViewList")>
	Friend Class RibbonTableViewList
		Inherits RibbonItem

		' Token: 0x06004D3A RID: 19770 RVA: 0x0020177D File Offset: 0x001FF97D
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001179 RID: 4473
		' (get) Token: 0x06004D3B RID: 19771 RVA: 0x0020178E File Offset: 0x001FF98E
		' (set) Token: 0x06004D3C RID: 19772 RVA: 0x002017A9 File Offset: 0x001FF9A9
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("标题")>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.O0oo0.o. Is Nothing Then
					Me.O0oo0.o. = ""
				End If
				Return Me.O0oo0.o.
			End Get
			Set(value As String)
				Me.O0oo0.o. = value
			End Set
		End Property

		' Token: 0x04001FB4 RID: 8116
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
