Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000483 RID: 1155
	<OoO0___o("RibbonGroupTableList")>
	Friend Class RibbonGroupTableList
		Inherits RibbonItem

		' Token: 0x06004D00 RID: 19712 RVA: 0x002014F2 File Offset: 0x001FF6F2
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001160 RID: 4448
		' (get) Token: 0x06004D01 RID: 19713 RVA: 0x00201503 File Offset: 0x001FF703
		' (set) Token: 0x06004D02 RID: 19714 RVA: 0x0020151E File Offset: 0x001FF71E
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.O0o._0o_O. Is Nothing Then
					Me.O0o._0o_O. = ""
				End If
				Return Me.O0o._0o_O.
			End Get
			Set(value As String)
				Me.O0o._0o_O. = value
			End Set
		End Property

		' Token: 0x04001FA2 RID: 8098
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
