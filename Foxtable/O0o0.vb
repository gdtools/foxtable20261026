Imports System
Imports C1.Win.C1Command

Namespace Foxtable
	' Token: 0x02000081 RID: 129
	Friend Class O0o0
		Inherits C1DockingTabPage

		' Token: 0x060004A3 RID: 1187 RVA: 0x0001B3C0 File Offset: 0x000195C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO0_0oOo.o..foxGrid IsNot Nothing AndAlso Not Me.OO0_0oOo.o..foxGrid.Disposing AndAlso Not Me.OO0_0oOo.o..foxGrid.IsDisposed AndAlso Me.OO0_0oOo.o..foxGrid.CanFocus Then
				Me.OO0_0oOo.o..foxGrid.Focus()
			End If
		End Sub

		' Token: 0x060004A4 RID: 1188 RVA: 0x0001B424 File Offset: 0x00019624
		Friend Sub New(A_0 As Table)
			AddHandler MyBase.GotFocus, AddressOf Me.OO0_0oOo.o.
			Me.OO0_0oOo.o. = A_0
			MyBase.Name = A_0.Name
			If A_0.foxGrid.Parent Is Nothing Then
				MyBase.Controls.Clear()
				MyBase.Controls.Add(A_0.foxGrid)
			End If
		End Sub

		' Token: 0x040000FB RID: 251
		Friend <<EMPTY_NAME>> As Table
	End Class
End Namespace
