Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000493 RID: 1171
	<OoO0___o("RibbonWordReportList")>
	Friend Class RibbonWordReportList
		Inherits RibbonItem

		' Token: 0x06004D66 RID: 19814 RVA: 0x00201989 File Offset: 0x001FFB89
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700118C RID: 4492
		' (get) Token: 0x06004D67 RID: 19815 RVA: 0x0020199A File Offset: 0x001FFB9A
		' (set) Token: 0x06004D68 RID: 19816 RVA: 0x002019B5 File Offset: 0x001FFBB5
		<Category("属性")>
		<O_Oo00Oo000O0(1.1)>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				If Me.O0.o0__OOo00O. Is Nothing Then
					Me.O0.o0__OOo00O. = ""
				End If
				Return Me.O0.o0__OOo00O.
			End Get
			Set(value As String)
				Me.O0.o0__OOo00O. = value
			End Set
		End Property

		' Token: 0x04001FC3 RID: 8131
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
