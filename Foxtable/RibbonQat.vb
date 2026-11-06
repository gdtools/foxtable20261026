Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000487 RID: 1159
	<oO0oooo("1095")>
	Friend Class RibbonQat
		Inherits RibbonItemContainer

		' Token: 0x06004D10 RID: 19728 RVA: 0x002015E3 File Offset: 0x001FF7E3
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			MyBase.Name = "快速访问栏"
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001166 RID: 4454
		' (get) Token: 0x06004D11 RID: 19729 RVA: 0x00201600 File Offset: 0x001FF800
		<Browsable(False)>
		Public ReadOnly Property Name As String
			Get
				Return Nothing
			End Get
		End Property

		' Token: 0x17001167 RID: 4455
		' (get) Token: 0x06004D12 RID: 19730 RVA: 0x00201610 File Offset: 0x001FF810
		' (set) Token: 0x06004D13 RID: 19731 RVA: 0x00201618 File Offset: 0x001FF818
		<Description("快速访问菜单是否位于Ribbon的下方。")>
		<O_Oo00Oo000O0(100.0)>
		<Category("属性")>
		<DisplayName("处于下端")>
		Public Property BelowRibbon As Boolean
			Get
				Return Me.O._oo0__0o.
			End Get
			Set(value As Boolean)
				Me.O._oo0__0o. = value
			End Set
		End Property

		' Token: 0x04001FA7 RID: 8103
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
