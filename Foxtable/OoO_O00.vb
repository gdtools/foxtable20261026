Imports System
Imports System.Drawing

Namespace Foxtable
	' Token: 0x020002FC RID: 764
	Friend Class OoO_O00
		' Token: 0x060027F7 RID: 10231 RVA: 0x0010BBA8 File Offset: 0x00109DA8
		Public Sub New(A_0 As Table)
			Me.O._00000. = A_0
			Me.O._00000. = A_0.View.oo_0._o.()
			Me.O._00000. = A_0.Position
			Me.O._00000. = A_0.foxGrid.ScrollPosition
			A_0.StopRedraw()
			A_0.View.O00o0.0_0O_.(False)
			A_0.View.Oo_oooOo._o0.("False")
		End Sub

		' Token: 0x060027F8 RID: 10232 RVA: 0x0010BC14 File Offset: 0x00109E14
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As Table = Nothing)
			Me.O._00000..View.Oo_oooOo._o0.(Me.O._00000.)
			Me.O._00000..View.O00o0.0_0O_.(True)
			If Me.O._00000..ooO__oo0O.0.(False) - 1 < Me.O._00000. AndAlso Me.O._00000..Position = Me.O._00000..ooO__oo0O.0.(False) - 1 Then
				Me.O._00000..View.o_._0O0o_OoO.()
				Me.O._00000..View.Oo._Oo0OO.()
			End If
			Me.O._00000..Position = Me.O._00000.
			Me.O._00000..foxGrid.ScrollPosition = Me.O._00000.
			If Me.O._00000. IsNot A_0 Then
				Me.O._00000..ResumeRedraw()
			End If
		End Sub

		' Token: 0x04001097 RID: 4247
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001098 RID: 4248
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001099 RID: 4249
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400109A RID: 4250
		Private <<EMPTY_NAME>> As Point
	End Class
End Namespace
