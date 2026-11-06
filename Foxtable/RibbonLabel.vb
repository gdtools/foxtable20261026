Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000484 RID: 1156
	<oO0oooo("1116")>
	<OoO0___o("RibbonLabel")>
	Friend Class RibbonLabel
		Inherits RibbonItem

		' Token: 0x06004D03 RID: 19715 RVA: 0x00201527 File Offset: 0x001FF727
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001161 RID: 4449
		' (get) Token: 0x06004D04 RID: 19716 RVA: 0x00201538 File Offset: 0x001FF738
		' (set) Token: 0x06004D05 RID: 19717 RVA: 0x00201553 File Offset: 0x001FF753
		<Category("属性")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		Public Property Text As String
			Get
				If Me.oo_00OOO_o.0O. Is Nothing Then
					Me.oo_00OOO_o.0O. = ""
				End If
				Return Me.oo_00OOO_o.0O.
			End Get
			Set(value As String)
				Me.oo_00OOO_o.0O. = value
			End Set
		End Property

		' Token: 0x17001162 RID: 4450
		' (get) Token: 0x06004D06 RID: 19718 RVA: 0x0020155C File Offset: 0x001FF75C
		' (set) Token: 0x06004D07 RID: 19719 RVA: 0x0020155F File Offset: 0x001FF75F
		<Browsable(False)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x04001FA3 RID: 8099
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
