Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003A2 RID: 930
	<DesignerGenerated()>
	Friend Class oOOO0oo0_oO_o
		Inherits UserControl

		' Token: 0x06003B21 RID: 15137 RVA: 0x00198A5C File Offset: 0x00196C5C
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.o.Ooo_0__0Oo. IsNot Nothing Then
					Me.o.Ooo_0__0Oo..Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06003B22 RID: 15138 RVA: 0x00198A9C File Offset: 0x00196C9C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			MyBase.SuspendLayout()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Transparent
			MyBase.Name = "O.o..o.."
			MyBase.Size = New Size(9, 9)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003B23 RID: 15139 RVA: 0x00198AF8 File Offset: 0x00196CF8
		Public Sub New()
			AddHandler MyBase.Click, AddressOf Me.O00___._OO_.
			AddHandler MyBase.ParentChanged, AddressOf Me.o.Ooo_0__0Oo.
			Me.o.Ooo_0__0Oo.()
			Me.BackgroundImage = OO_00oOO.GetImage("Operator.ico")
			Me.BackgroundImageLayout = ImageLayout.Center
		End Sub

		' Token: 0x06003B24 RID: 15140 RVA: 0x00198B4C File Offset: 0x00196D4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			oOO0oo_o0.o0.Oo__.(MyBase.FindForm().Controls)
			CType(MyBase.Parent, ControlHolder).Selected = True
			Dim obj As Object = RuntimeHelpers.GetObjectValue(CType(MyBase.FindForm().MdiParent, o\u3000\u3002).O0.0O00_O.().SelectedObject)
			If TypeOf obj Is o_0oooo_OO Then
				obj = CType(obj, o_0oooo_OO)
				Dim o_0oooo_OO As o_0oooo_OO = CType(obj, o_0oooo_OO)
				If TypeOf o_0oooo_OO.Oo._o.()Is TopicBarProperty Then
					Dim o_u3002_u3002_u As O\u3002\u3002\u3000 = New O\u3002\u3002\u3000()
					o_u3002_u3002_u.OoO_0_0._00_0.(CType(o_0oooo_OO.Oo._o.(), TopicBarProperty).Setting)
					If o_u3002_u3002_u.ShowDialog() = DialogResult.OK Then
						CType(o_0oooo_OO.Oo._o.(), TopicBarProperty).Setting = o_u3002_u3002_u.OO_o.O_0.()
						CType(MyBase.FindForm().MdiParent, o\u3000\u3002).OO_._oOo. = True
					End If
				End If
			End If
		End Sub

		' Token: 0x06003B25 RID: 15141 RVA: 0x00198C10 File Offset: 0x00196E10
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Location = New Point(MyBase.Parent.Width - MyBase.Width - 4, MyBase.Parent.Height - MyBase.Height - 4)
			Me.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.BackColor = CType(MyBase.Parent, ControlHolder).ChildControl.BackColor
			MyBase.BringToFront()
		End Sub

		' Token: 0x0400185A RID: 6234
		Private <<EMPTY_NAME>> As IContainer
	End Class
End Namespace
