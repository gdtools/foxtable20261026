Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000480 RID: 1152
	<OoO0___o("RibbonExcelReportList")>
	Friend Class RibbonExcelReportList
		Inherits RibbonItem

		' Token: 0x06004CDE RID: 19678 RVA: 0x0020137C File Offset: 0x001FF57C
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001150 RID: 4432
		' (get) Token: 0x06004CDF RID: 19679 RVA: 0x0020138D File Offset: 0x001FF58D
		' (set) Token: 0x06004CE0 RID: 19680 RVA: 0x002013A8 File Offset: 0x001FF5A8
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		Public Property Text As String
			Get
				If Me.OO_._O0. Is Nothing Then
					Me.OO_._O0. = ""
				End If
				Return Me.OO_._O0.
			End Get
			Set(value As String)
				Me.OO_._O0. = value
			End Set
		End Property

		' Token: 0x04001F94 RID: 8084
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
