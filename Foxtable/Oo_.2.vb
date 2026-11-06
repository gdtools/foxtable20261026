Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000142 RID: 322
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Oo_
		Inherits C1TopicBar

		' Token: 0x06000F56 RID: 3926 RVA: 0x0006868F File Offset: 0x0006688F
		Friend Sub New()
			MyBase.Padding = New Padding(6)
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
		End Sub

		' Token: 0x06000F57 RID: 3927 RVA: 0x000686BE File Offset: 0x000668BE
		Public Overrides Overloads Function <<EMPTY_NAME>>() As Font
			Return MyBase.Font
		End Function

		' Token: 0x06000F58 RID: 3928 RVA: 0x000686C8 File Offset: 0x000668C8
		Public Overrides Sub <<EMPTY_NAME>>(A_0 As Font)
			MyBase.Font = A_0
			MyBase.LinkStyle.NormalPage.DisabledLink.Font = A_0
			MyBase.LinkStyle.NormalPage.MouseOverLink.Font = New Font(CType(A_0.Clone(), Font), Me.O_o.0.().Style Or FontStyle.Underline)
			MyBase.LinkStyle.NormalPage.NormalLink.Font = A_0
			MyBase.LinkStyle.NormalPage.PressedLink.Font = A_0
		End Sub

		' Token: 0x06000F59 RID: 3929 RVA: 0x00068750 File Offset: 0x00066950
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As PaintEventArgs)
			If MyBase.LinkStyle.NormalPage.PressedLink.ForeColor <> MyBase.LinkStyle.NormalPage.NormalLink.ForeColor Then
				MyBase.LinkStyle.NormalPage.PressedLink.ForeColor = MyBase.LinkStyle.NormalPage.NormalLink.ForeColor
			End If
			MyBase.OnPaint(A_0)
		End Sub
	End Class
End Namespace
