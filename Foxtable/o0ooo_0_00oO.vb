Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000083 RID: 131
	Friend Class o0ooo_0_00oO
		Inherits C1TopicBar

		' Token: 0x060004A6 RID: 1190 RVA: 0x0001B48D File Offset: 0x0001968D
		Public Sub New()
			AddHandler MyBase.ParentChanged, AddressOf Me.OO0_0oOo.o.
			MyBase.VisualStyle = 0
		End Sub

		' Token: 0x060004A7 RID: 1191 RVA: 0x0001B4AE File Offset: 0x000196AE
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.FindForm() IsNot Nothing Then
				Main.OO_O.o..o.O000oo.(New Object() { Me })
			End If
		End Sub

		' Token: 0x060004A8 RID: 1192 RVA: 0x0001B4CC File Offset: 0x000196CC
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As PaintEventArgs)
			If MyBase.LinkStyle.NormalPage.PressedLink.ForeColor <> MyBase.LinkStyle.NormalPage.NormalLink.ForeColor Then
				MyBase.LinkStyle.NormalPage.PressedLink.ForeColor = MyBase.LinkStyle.NormalPage.NormalLink.ForeColor
			End If
			MyBase.OnPaint(A_0)
		End Sub
	End Class
End Namespace
