Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000476 RID: 1142
	<oO0oooo("1098")>
	Friend Class RibbonConfigToolBar
		Inherits RibbonItemContainer

		' Token: 0x17001110 RID: 4368
		' (get) Token: 0x06004C55 RID: 19541 RVA: 0x00200D79 File Offset: 0x001FEF79
		<Browsable(False)>
		Public ReadOnly Property Name As String
			Get
				Return "配置栏"
			End Get
		End Property

		' Token: 0x06004C56 RID: 19542 RVA: 0x00200D80 File Offset: 0x001FEF80
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			MyBase.Name = "配置栏"
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub
	End Class
End Namespace
