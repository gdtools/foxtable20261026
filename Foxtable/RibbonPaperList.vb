Imports System
Imports System.ComponentModel
Imports System.Data

Namespace Foxtable
	' Token: 0x02000486 RID: 1158
	<OoO0___o("RibbonPaperList")>
	Friend Class RibbonPaperList
		Inherits RibbonItem

		' Token: 0x06004D0D RID: 19725 RVA: 0x002015AE File Offset: 0x001FF7AE
		Public Sub New(A_0 As DataRow)
			MyBase.New(A_0)
			o_O_o_oOoo__.OOOO_OO._oo.(Me, A_0, False)
		End Sub

		' Token: 0x17001165 RID: 4453
		' (get) Token: 0x06004D0E RID: 19726 RVA: 0x002015BF File Offset: 0x001FF7BF
		' (set) Token: 0x06004D0F RID: 19727 RVA: 0x002015DA File Offset: 0x001FF7DA
		<O_Oo00Oo000O0(1.1)>
		<Category("属性")>
		<DisplayName("标题")>
		Public Property Text As String
			Get
				If Me.o0_.OO. Is Nothing Then
					Me.o0_.OO. = ""
				End If
				Return Me.o0_.OO.
			End Get
			Set(value As String)
				Me.o0_.OO. = value
			End Set
		End Property

		' Token: 0x04001FA6 RID: 8102
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
