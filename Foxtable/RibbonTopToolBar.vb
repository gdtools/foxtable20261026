Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000490 RID: 1168
	Friend Class RibbonTopToolBar
		Inherits RibbonItemContainer

		' Token: 0x1700117F RID: 4479
		' (get) Token: 0x06004D4A RID: 19786 RVA: 0x00201841 File Offset: 0x001FFA41
		<Browsable(False)>
		Public ReadOnly Property Name As String
			Get
				Return "上工具栏"
			End Get
		End Property

		' Token: 0x06004D4B RID: 19787 RVA: 0x00201848 File Offset: 0x001FFA48
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			MyBase.Name = "上工具栏"
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub
	End Class
End Namespace
