Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x0200046C RID: 1132
	Friend Class RibbonBottomToolBar
		Inherits RibbonItemContainer

		' Token: 0x170010E3 RID: 4323
		' (get) Token: 0x06004BF2 RID: 19442 RVA: 0x0020096E File Offset: 0x001FEB6E
		<Browsable(False)>
		Public ReadOnly Property Name As String
			Get
				Return "下工具栏"
			End Get
		End Property

		' Token: 0x06004BF3 RID: 19443 RVA: 0x00200975 File Offset: 0x001FEB75
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			MyBase.Name = "下工具栏"
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub
	End Class
End Namespace
