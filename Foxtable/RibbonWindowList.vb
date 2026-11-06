Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000492 RID: 1170
	<OoO0___o("RibbonWindowList")>
	Friend Class RibbonWindowList
		Inherits RibbonItem

		' Token: 0x06004D63 RID: 19811 RVA: 0x00201954 File Offset: 0x001FFB54
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x1700118B RID: 4491
		' (get) Token: 0x06004D64 RID: 19812 RVA: 0x00201965 File Offset: 0x001FFB65
		' (set) Token: 0x06004D65 RID: 19813 RVA: 0x00201980 File Offset: 0x001FFB80
		<Category("属性")>
		<DisplayName("标题")>
		<O_Oo00Oo000O0(1.1)>
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

		' Token: 0x04001FC2 RID: 8130
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
