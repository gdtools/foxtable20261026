Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000488 RID: 1160
	<oO0oooo("1120")>
	<OoO0___o("RibbonSeparator")>
	Friend Class RibbonSeparator
		Inherits RibbonItem

		' Token: 0x06004D14 RID: 19732 RVA: 0x00201621 File Offset: 0x001FF821
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001168 RID: 4456
		' (get) Token: 0x06004D15 RID: 19733 RVA: 0x00201632 File Offset: 0x001FF832
		' (set) Token: 0x06004D16 RID: 19734 RVA: 0x00201635 File Offset: 0x001FF835
		<Browsable(False)>
		<OooO0(True)>
		Public Property LargeImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17001169 RID: 4457
		' (get) Token: 0x06004D17 RID: 19735 RVA: 0x00201637 File Offset: 0x001FF837
		' (set) Token: 0x06004D18 RID: 19736 RVA: 0x0020163A File Offset: 0x001FF83A
		<Browsable(False)>
		<OooO0(True)>
		Public Property SmallImage As String
			Get
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700116A RID: 4458
		' (get) Token: 0x06004D19 RID: 19737 RVA: 0x0020163C File Offset: 0x001FF83C
		' (set) Token: 0x06004D1A RID: 19738 RVA: 0x0020163F File Offset: 0x001FF83F
		<Browsable(False)>
		<OooO0(True)>
		Public Property TextImageRelation As TextImageRelationEnum
			Get
				Return TextImageRelationEnum.Automatic
			End Get
			Set(value As TextImageRelationEnum)
			End Set
		End Property
	End Class
End Namespace
