Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x020003A1 RID: 929
	Friend Class o0O__ooOO00
		Inherits Label

		' Token: 0x06003B1D RID: 15133 RVA: 0x00198930 File Offset: 0x00196B30
		Public Sub New()
			AddHandler MyBase.Click, AddressOf Me.OO_._0_oO__0.
			AddHandler MyBase.ParentChanged, AddressOf Me.o.O_oO.
			Me.BackColor = Color.Blue
			Me.ForeColor = Color.White
			Me.TextAlign = ContentAlignment.MiddleCenter
			MyBase.Size = New Size(20, 16)
			MyBase.Location = New Point(0, 0)
			MyBase.Visible = False
		End Sub

		' Token: 0x06003B1E RID: 15134 RVA: 0x001989A8 File Offset: 0x00196BA8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim o0_0_0_0_ As O0_0_0_0_
			If TypeOf MyBase.Parent.Parent Is PictureBox Then
				o0_0_0_0_ = CType(MyBase.Parent.Parent.Parent, O0_0_0_0_)
			Else
				o0_0_0_0_ = CType(MyBase.Parent.Parent, O0_0_0_0_)
			End If
			MyBase.Parent.TabIndex = o0_0_0_0_.O0.o0O_o00_O.()
			o0_0_0_0_.O0.o0O_o00_O.(o0_0_0_0_.O0.o0O_o00_O.() + 1)
			If o0_0_0_0_.O0.o0O_o00_O.() > o0_0_0_0_.OOO_0_oo0.Oo0_.() Then
				o0_0_0_0_.O0.o0O_o00_O.(0)
			End If
		End Sub

		' Token: 0x06003B1F RID: 15135 RVA: 0x00198A24 File Offset: 0x00196C24
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Text = Convert.ToString(MyBase.Parent.TabIndex)
			MyBase.BringToFront()
		End Sub

		' Token: 0x06003B20 RID: 15136 RVA: 0x00198A42 File Offset: 0x00196C42
		Public Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Text = Convert.ToString(MyBase.Parent.TabIndex)
		End Sub
	End Class
End Namespace
