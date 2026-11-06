Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000477 RID: 1143
	<OoO0___o("RibbonCrossTableList")>
	Friend Class RibbonCrossTableList
		Inherits RibbonItem

		' Token: 0x06004C57 RID: 19543 RVA: 0x00200D9C File Offset: 0x001FEF9C
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001111 RID: 4369
		' (get) Token: 0x06004C58 RID: 19544 RVA: 0x00200DAD File Offset: 0x001FEFAD
		' (set) Token: 0x06004C59 RID: 19545 RVA: 0x00200DC8 File Offset: 0x001FEFC8
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.O_o._0oo0o0_0. Is Nothing Then
					Me.O_o._0oo0o0_0. = ""
				End If
				Return Me.O_o._0oo0o0_0.
			End Get
			Set(value As String)
				Me.O_o._0oo0o0_0. = value
			End Set
		End Property

		' Token: 0x04001F5D RID: 8029
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
