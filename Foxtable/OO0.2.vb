Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200039C RID: 924
	Friend Class OO0
		Inherits PictureBox

		' Token: 0x06003ACC RID: 15052 RVA: 0x0019713C File Offset: 0x0019533C
		Friend Sub New()
			MyBase.Size = New Size(9, 9)
			MyBase.Image = OO_00oOO.GetImage("Drag.ico")
			MyBase.SizeMode = PictureBoxSizeMode.Normal
			MyBase.BorderStyle = BorderStyle.None
			MyBase.TabStop = False
			MyBase.Visible = False
			Me.Cursor = Cursors.SizeAll
		End Sub

		' Token: 0x06003ACD RID: 15053 RVA: 0x00197198 File Offset: 0x00195398
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As EventArgs)
			MyBase.Location = New Point(0, 0)
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Left)
			AddHandler CType(MyBase.Parent, ControlHolder).SelectedChanged, AddressOf Me.O0Oo0_0_.o.
			AddHandler CType(MyBase.Parent, ControlHolder).LockedChanged, AddressOf Me.oOOo__O0O0.0O.
			Dim [object] As ControlHolder = CType(MyBase.Parent, ControlHolder)
			AddHandler MyBase.MouseDown, AddressOf [object].o0_.0O_O0O.
			AddHandler MyBase.MouseMove, AddressOf [object].oOO.O.
			AddHandler MyBase.MouseUp, AddressOf [object].O000_oo.o_.
			MyBase.BringToFront()
		End Sub

		' Token: 0x06003ACE RID: 15054 RVA: 0x0019723C File Offset: 0x0019543C
		Public Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			MyBase.Visible = (controlHolder.Selected And Not controlHolder.Locked And controlHolder.Dock = DockStyle.None)
			MyBase.BringToFront()
		End Sub

		' Token: 0x06003ACF RID: 15055 RVA: 0x00197280 File Offset: 0x00195480
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			MyBase.Visible = (controlHolder.Selected And Not controlHolder.Locked And controlHolder.Dock = DockStyle.None)
		End Sub

		' Token: 0x0400183C RID: 6204
		Private <<EMPTY_NAME>> As Point
	End Class
End Namespace
