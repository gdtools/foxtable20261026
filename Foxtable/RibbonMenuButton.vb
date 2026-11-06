Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000485 RID: 1157
	<OoO0___o("RibbonMenuButton")>
	<oO0oooo("1105")>
	Friend Class RibbonMenuButton
		Inherits RibbonDropDownItem

		' Token: 0x17001163 RID: 4451
		' (get) Token: 0x06004D08 RID: 19720 RVA: 0x00201561 File Offset: 0x001FF761
		' (set) Token: 0x06004D09 RID: 19721 RVA: 0x0020157C File Offset: 0x001FF77C
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.O.oOOO. Is Nothing Then
					Me.O.oOOO. = ""
				End If
				Return Me.O.oOOO.
			End Get
			Set(value As String)
				Me.O.oOOO. = value
			End Set
		End Property

		' Token: 0x06004D0A RID: 19722 RVA: 0x00201585 File Offset: 0x001FF785
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			Me.O.oOOO. = True
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001164 RID: 4452
		' (get) Token: 0x06004D0B RID: 19723 RVA: 0x0020159D File Offset: 0x001FF79D
		' (set) Token: 0x06004D0C RID: 19724 RVA: 0x002015A5 File Offset: 0x001FF7A5
		<DisplayName("显示箭头")>
		<DefaultValue(True)>
		<O_Oo00Oo000O0(1.2)>
		<Category("属性")>
		Public Property ArrowVisible As Boolean
			Get
				Return Me.O.oOOO.
			End Get
			Set(value As Boolean)
				Me.O.oOOO. = value
			End Set
		End Property

		' Token: 0x04001FA4 RID: 8100
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001FA5 RID: 8101
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
