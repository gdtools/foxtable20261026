Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x0200039F RID: 927
	Friend Class Oo0oo_O_O00__
		Inherits Label

		' Token: 0x06003B0A RID: 15114 RVA: 0x001981E0 File Offset: 0x001963E0
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As Oo0oo_O_O00__.OOo0)
			Dim ooo As Oo0oo_O_O00__.OOo0 = Me.OOOOo._.
			Dim ooo2 As Oo0oo_O_O00__.OOo0
			Do
				ooo2 = ooo
				Dim value As Oo0oo_O_O00__.OOo0 = CType([Delegate].Combine(ooo2, A_0), Oo0oo_O_O00__.OOo0)
				ooo = Interlocked.CompareExchange(Of Oo0oo_O_O00__.OOo0)(Me.OOOOo._., value, ooo2)
			Loop While ooo IsNot ooo2
		End Sub

		' Token: 0x06003B0B RID: 15115 RVA: 0x00198218 File Offset: 0x00196418
		<CompilerGenerated()>
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Oo0oo_O_O00__.OOo0)
			Dim ooo As Oo0oo_O_O00__.OOo0 = Me.OOOOo._.
			Dim ooo2 As Oo0oo_O_O00__.OOo0
			Do
				ooo2 = ooo
				Dim value As Oo0oo_O_O00__.OOo0 = CType([Delegate].Remove(ooo2, A_0), Oo0oo_O_O00__.OOo0)
				ooo = Interlocked.CompareExchange(Of Oo0oo_O_O00__.OOo0)(Me.OOOOo._., value, ooo2)
			Loop While ooo IsNot ooo2
		End Sub

		' Token: 0x06003B0C RID: 15116 RVA: 0x00198250 File Offset: 0x00196450
		Friend Sub New(A_0 As O0OO000oo0O)
			Me.Text = ""
			Me.BackColor = SystemColors.ControlLightLight
			Me.BorderStyle = BorderStyle.FixedSingle
			MyBase.FlatStyle = FlatStyle.Flat
			MyBase.Size = New Size(6, 6)
			Me.Oo000Oo.Oo__O.(A_0)
			MyBase.TabStop = False
			MyBase.Visible = False
			Me.OO.O0_O.(AddressOf oOO0oo_o0.O00OO_O_oO_.o.)
		End Sub

		' Token: 0x06003B0D RID: 15117 RVA: 0x001982BB File Offset: 0x001964BB
		Private Overloads Function <<EMPTY_NAME>>() As O0OO000oo0O
			Return Me.Oo000Oo.Oo__O.
		End Function

		' Token: 0x06003B0E RID: 15118 RVA: 0x001982C3 File Offset: 0x001964C3
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As O0OO000oo0O)
			Me.Oo000Oo.Oo__O. = A_0
		End Sub

		' Token: 0x06003B0F RID: 15119 RVA: 0x001982CC File Offset: 0x001964CC
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As EventArgs)
			Select Case Me.Oo000Oo.Oo__O.()
				Case O0OO000oo0O.OOOOo._.
					Me.Cursor = Cursors.SizeWE
					MyBase.Location = New Point(0, Convert.ToInt32(CDbl((MyBase.Parent.Height - MyBase.Height)) / 2.0))
					Me.Anchor = AnchorStyles.Left
				Case O0OO000oo0O.ooo_O0o._.
					Me.Cursor = Cursors.SizeNS
					MyBase.Location = New Point(Convert.ToInt32(CDbl((MyBase.Parent.Width - MyBase.Width)) / 2.0), 0)
					Me.Anchor = AnchorStyles.Top
				Case O0OO000oo0O.o.00o000O00o__.
					Me.Cursor = Cursors.SizeWE
					MyBase.Location = New Point(MyBase.Parent.Width - MyBase.Width, Convert.ToInt32(CDbl((MyBase.Parent.Height - MyBase.Height)) / 2.0))
					Me.Anchor = AnchorStyles.Right
				Case O0OO000oo0O.o_.0_0O.
					Me.Cursor = Cursors.SizeNS
					MyBase.Location = New Point(Convert.ToInt32(CDbl((MyBase.Parent.Width - MyBase.Width)) / 2.0), MyBase.Parent.Height - MyBase.Height)
					Me.Anchor = AnchorStyles.Bottom
				Case O0OO000oo0O.o_oO._0O.
					Me.Cursor = Cursors.SizeNWSE
					MyBase.Location = New Point(0, 0)
					Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Left)
				Case O0OO000oo0O.o0_OoOo.OO.
					Me.Cursor = Cursors.SizeNESW
					MyBase.Location = New Point(MyBase.Parent.Width - MyBase.Width, 0)
					Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
				Case O0OO000oo0O.Oo0ooo.OO.
					Me.Cursor = Cursors.SizeNESW
					MyBase.Location = New Point(0, MyBase.Parent.Height - MyBase.Height)
					Me.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
				Case O0OO000oo0O.OO_._O.
					Me.Cursor = Cursors.SizeNWSE
					MyBase.Location = New Point(MyBase.Parent.Width - MyBase.Width, MyBase.Parent.Height - MyBase.Height)
					Me.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			End Select
			AddHandler CType(MyBase.Parent, ControlHolder).ActivatedChanged, AddressOf Me.o0_Oo__O.OO0.
			AddHandler CType(MyBase.Parent, ControlHolder).SelectedChanged, AddressOf Me.o_Oo_.0o_oO_oO.
			AddHandler CType(MyBase.Parent, ControlHolder).LockedChanged, AddressOf Me.Oo000Oo.Oo__O.
			AddHandler CType(MyBase.Parent, ControlHolder).DockStyleChanged, AddressOf Me.OoO0.O.
			MyBase.OnParentChanged(A_0)
			MyBase.BringToFront()
		End Sub

		' Token: 0x06003B10 RID: 15120 RVA: 0x0019858C File Offset: 0x0019678C
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			Me.OOOOo._. = MyBase.Parent.Size
			If e.Button = MouseButtons.Left And Me.o0O_.00.() Then
				Me.OOOOo._. = True
				Me.OOOOo._. = New Point(e.X, e.Y)
				CType(MyBase.Parent, ControlHolder).Activated = True
				Me.OOOOo._. = CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).OO__oo0.0O___.("Size")
				Return
			End If
			Me.OOOOo._. = False
			Me.OOOOo._. = Nothing
		End Sub

		' Token: 0x06003B11 RID: 15121 RVA: 0x0019861C File Offset: 0x0019681C
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			If Me.OOOOo._. And e.Button = MouseButtons.Left Then
				Me.oOOo_o._0o0. = New Point(e.X, e.Y)
				Dim ooooo._. As Oo0oo_O_O00__.OOo0 = Me.OOOOo._.
				If ooooo._. IsNot Nothing Then
					ooooo._.(MyBase.FindForm().Controls, Me.Oo000Oo.Oo__O.(), Me.oOOo_o._0o0..X - Me.OOOOo._..X, Me.oOOo_o._0o0..Y - Me.OOOOo._..Y)
				End If
				Me.oOOo_o._0o0. = Me.OOOOo._.
				CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.().Refresh()
				If CType(MyBase.Parent, ControlHolder).ParentHolder IsNot Nothing AndAlso CType(MyBase.Parent, ControlHolder).ParentHolder.ControlType = ControlTypeEnum.PictureBox Then
					CType(CType(MyBase.Parent, ControlHolder).ParentHolder.ChildControl, CustomPictureBox).PictureBox1.Refresh()
					Return
				End If
			Else
				Me.OOOOo._. = False
			End If
		End Sub

		' Token: 0x06003B12 RID: 15122 RVA: 0x00198728 File Offset: 0x00196928
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			Me.OOOOo._. = False
			If Me.OOOOo._. <> MyBase.Parent.Size AndAlso Me.OOOOo._. IsNot Nothing Then
				CType(MyBase.FindForm(), o\u3002\u3002\u3000\u3000\u3002).o_0O.OO0_0_..Add(Me.OOOOo._.)
				Me.OOOOo._. = Nothing
			End If
		End Sub

		' Token: 0x06003B13 RID: 15123 RVA: 0x0019877E File Offset: 0x0019697E
		Public Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			If CType(MyBase.Parent, ControlHolder).Activated Then
				Me.BackColor = SystemColors.Highlight
				Return
			End If
			Me.BackColor = SystemColors.ControlLightLight
		End Sub

		' Token: 0x06003B14 RID: 15124 RVA: 0x001987AC File Offset: 0x001969AC
		Public Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			MyBase.Visible = (controlHolder.Selected And Not controlHolder.Locked And Me.o0_Oo__O.OO0.())
		End Sub

		' Token: 0x06003B15 RID: 15125 RVA: 0x001987E4 File Offset: 0x001969E4
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			MyBase.Visible = (controlHolder.Selected And Not controlHolder.Locked And Me.o0_Oo__O.OO0.())
		End Sub

		' Token: 0x06003B16 RID: 15126 RVA: 0x0019881C File Offset: 0x00196A1C
		Public Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			MyBase.Visible = (controlHolder.Selected And Not controlHolder.Locked And Me.o0_Oo__O.OO0.())
		End Sub

		' Token: 0x06003B17 RID: 15127 RVA: 0x00198854 File Offset: 0x00196A54
		Public Function <<EMPTY_NAME>>() As Boolean
			Dim dock As DockStyle = CType(MyBase.Parent, ControlHolder).Dock
			Dim result As Boolean
			If dock = DockStyle.None Then
				result = True
			ElseIf dock = DockStyle.Fill Then
				result = False
			ElseIf dock = DockStyle.Left Then
				result = (Me.Oo000Oo.Oo__O.() = O0OO000oo0O.o.00o000O00o__.)
			ElseIf dock = DockStyle.Right Then
				result = (Me.Oo000Oo.Oo__O.() = O0OO000oo0O.OOOOo._.)
			ElseIf dock = DockStyle.Top Then
				result = (Me.Oo000Oo.Oo__O.() = O0OO000oo0O.o_.0_0O.)
			ElseIf dock = DockStyle.Bottom Then
				result = (Me.Oo000Oo.Oo__O.() = O0OO000oo0O.ooo_O0o._.)
			End If
			Return result
		End Function

		' Token: 0x06003B18 RID: 15128 RVA: 0x001988C0 File Offset: 0x00196AC0
		Private Function <<EMPTY_NAME>>() As Boolean
			MyBase.BringToFront()
			Dim controlHolder As ControlHolder = CType(MyBase.Parent, ControlHolder)
			Dim flag As Boolean = controlHolder.IsFixedWidth
			Dim flag2 As Boolean = controlHolder.IsFixedHeight
			Return Not(flag And Me.Oo000Oo.Oo__O.() <> O0OO000oo0O.ooo_O0o._. And Me.Oo000Oo.Oo__O.() <> O0OO000oo0O.o_.0_0O.) AndAlso Not(flag2 And Me.Oo000Oo.Oo__O.() > O0OO000oo0O.OOOOo._. And Me.Oo000Oo.Oo__O.() <> O0OO000oo0O.o.00o000O00o__.)
		End Function

		' Token: 0x04001853 RID: 6227
		Private <<EMPTY_NAME>> As Point

		' Token: 0x04001854 RID: 6228
		Private <<EMPTY_NAME>> As Point

		' Token: 0x04001855 RID: 6229
		Private <<EMPTY_NAME>> As O0OO000oo0O

		' Token: 0x04001856 RID: 6230
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Oo0oo_O_O00__.OOo0

		' Token: 0x04001857 RID: 6231
		Private <<EMPTY_NAME>> As O___O_

		' Token: 0x04001858 RID: 6232
		Private <<EMPTY_NAME>> As Size

		' Token: 0x04001859 RID: 6233
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x020003A0 RID: 928
		' (Invoke) Token: 0x06003B1C RID: 15132
		Public Delegate Sub OOo0(A_0 As Control.ControlCollection, A_1 As O0OO000oo0O, A_2 As Integer, A_3 As Integer)
	End Class
End Namespace
