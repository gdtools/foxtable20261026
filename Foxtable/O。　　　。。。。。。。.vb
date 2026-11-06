Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200036A RID: 874
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3002
		Inherits Form

		' Token: 0x060036ED RID: 14061 RVA: 0x00174D94 File Offset: 0x00172F94
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.O_0_0. IsNot Nothing Then
					Me.o.O_0_0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060036EE RID: 14062 RVA: 0x00174DD4 File Offset: 0x00172FD4
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.oo00O.oO.(New Label())
			Me.OOoO0.OO0ooo00.(New C1Button())
			Me.oo0.0O0O_Oo.(New C1Button())
			Me.O_.Ooo0_OOo.(New Label())
			Me.O_.Ooo0_OOo.(New CheckedListBox())
			Me.o.o_O00.(New C1Button())
			Me.o_oO00.0_o0o.(New C1Button())
			Me.OOo0O.o_o_0.(New C1Button())
			Me.OO_0OO0O_0._.(New C1Button())
			MyBase.SuspendLayout()
			Me.o.o_O00.().AutoSize = True
			Me.o.o_O00.().Location = New Point(11, 11)
			Me.o.o_O00.().Name = "Label1"
			Me.o.o_O00.().Size = New Size(23, 12)
			Me.o.o_O00.().TabIndex = 1
			Me.o.o_O00.().Text = "列:"
			Me.OO0_O.00O.().Location = New Point(296, 299)
			Me.OO0_O.00O.().Name = "Button1"
			Me.OO0_O.00O.().Size = New Size(75, 23)
			Me.OO0_O.00O.().TabIndex = 5
			Me.OO0_O.00O.().Text = "确定"
			Me.OO0_O.00O.().UseVisualStyleBackColor = True
			Me.O_.0oO0.().Location = New Point(296, 328)
			Me.O_.0oO0.().Name = "Button2"
			Me.O_.0oO0.().Size = New Size(75, 23)
			Me.O_.0oO0.().TabIndex = 6
			Me.O_.0oO0.().Text = "取消"
			Me.O_.0oO0.().UseVisualStyleBackColor = True
			Me.OOo0O.o_o_0.().AutoSize = True
			Me.OOo0O.o_o_0.().Location = New Point(11, 362)
			Me.OOo0O.o_o_0.().Name = "Label2"
			Me.OOo0O.o_o_0.().Size = New Size(143, 12)
			Me.OOo0O.o_o_0.().TabIndex = 4
			Me.OOo0O.o_o_0.().Text = "提示:未选中的列将被隐藏"
			Me.o.o_O00.().FormattingEnabled = True
			Me.o.o_O00.().Location = New Point(13, 28)
			Me.o.o_O00.().Name = "CheckedListBox1"
			Me.o.o_O00.().Size = New Size(266, 324)
			Me.o.o_O00.().TabIndex = 0
			Me.O.0o0__.().Location = New Point(296, 86)
			Me.O.0o0__.().Name = "Button3"
			Me.O.0o0__.().Size = New Size(75, 23)
			Me.O.0o0__.().TabIndex = 3
			Me.O.0o0__.().Text = "全选"
			Me.O.0o0__.().UseVisualStyleBackColor = True
			Me.oO0000._.().Location = New Point(296, 115)
			Me.oO0000._.().Name = "Button4"
			Me.oO0000._.().Size = New Size(75, 23)
			Me.oO0000._.().TabIndex = 4
			Me.oO0000._.().Text = "反选"
			Me.oO0000._.().UseVisualStyleBackColor = True
			Me.oO0oo_O.O0O_O_.().Location = New Point(296, 28)
			Me.oO0oo_O.O0O_O_.().Name = "btnMoveup"
			Me.oO0oo_O.O0O_O_.().Size = New Size(75, 23)
			Me.oO0oo_O.O0O_O_.().TabIndex = 1
			Me.oO0oo_O.O0O_O_.().Text = "上移"
			Me.oO0oo_O.O0O_O_.().UseVisualStyleBackColor = True
			Me.O.O00__0.().Location = New Point(296, 57)
			Me.O.O00__0.().Name = "btnMoveDown"
			Me.O.O00__0.().Size = New Size(75, 23)
			Me.O.O00__0.().TabIndex = 2
			Me.O.O00__0.().Text = "下移"
			Me.O.O00__0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(383, 385)
			MyBase.Controls.Add(Me.O.O00__0.())
			MyBase.Controls.Add(Me.oO0oo_O.O0O_O_.())
			MyBase.Controls.Add(Me.oO0000._.())
			MyBase.Controls.Add(Me.O.0o0__.())
			MyBase.Controls.Add(Me.o.o_O00.())
			MyBase.Controls.Add(Me.OOo0O.o_o_0.())
			MyBase.Controls.Add(Me.O_.0oO0.())
			MyBase.Controls.Add(Me.OO0_O.00O.())
			MyBase.Controls.Add(Me.o.o_O00.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO..Oo.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "取消隐藏列"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060036EF RID: 14063 RVA: 0x001752D5 File Offset: 0x001734D5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.O_0_0.
		End Function

		' Token: 0x060036F0 RID: 14064 RVA: 0x001752DD File Offset: 0x001734DD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.O_0_0. = A_0
		End Sub

		' Token: 0x060036F1 RID: 14065 RVA: 0x001752E6 File Offset: 0x001734E6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.Ooo0_OOo.
		End Function

		' Token: 0x060036F2 RID: 14066 RVA: 0x001752F0 File Offset: 0x001734F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoO_.Oo.
			Dim o_.Ooo0_OOo. As C1Button = Me.O_.Ooo0_OOo.
			If o_.Ooo0_OOo. IsNot Nothing Then
				RemoveHandler o_.Ooo0_OOo..Click, value
			End If
			Me.O_.Ooo0_OOo. = A_0
			o_.Ooo0_OOo. = Me.O_.Ooo0_OOo.
			If o_.Ooo0_OOo. IsNot Nothing Then
				AddHandler o_.Ooo0_OOo..Click, value
			End If
		End Sub

		' Token: 0x060036F3 RID: 14067 RVA: 0x00175333 File Offset: 0x00173533
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo00O.oO.
		End Function

		' Token: 0x060036F4 RID: 14068 RVA: 0x0017533C File Offset: 0x0017353C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_oO_.__O000o.
			Dim c1Button As C1Button = Me.oo00O.oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo00O.oO. = A_0
			c1Button = Me.oo00O.oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060036F5 RID: 14069 RVA: 0x0017537F File Offset: 0x0017357F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_.OO_.
		End Function

		' Token: 0x060036F6 RID: 14070 RVA: 0x00175387 File Offset: 0x00173587
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_.OO_. = A_0
		End Sub

		' Token: 0x060036F7 RID: 14071 RVA: 0x00175390 File Offset: 0x00173590
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.O_.Ooo0_OOo.
		End Function

		' Token: 0x060036F8 RID: 14072 RVA: 0x00175398 File Offset: 0x00173598
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As MouseEventHandler = AddressOf Me.ooO00.0o0.
			Dim value2 As EventHandler = AddressOf Me.O_.0oO0.
			Dim o_.Ooo0_OOo. As CheckedListBox = Me.O_.Ooo0_OOo.
			If o_.Ooo0_OOo. IsNot Nothing Then
				RemoveHandler o_.Ooo0_OOo..MouseDown, value
				RemoveHandler o_.Ooo0_OOo..SelectedIndexChanged, value2
			End If
			Me.O_.Ooo0_OOo. = A_0
			o_.Ooo0_OOo. = Me.O_.Ooo0_OOo.
			If o_.Ooo0_OOo. IsNot Nothing Then
				AddHandler o_.Ooo0_OOo..MouseDown, value
				AddHandler o_.Ooo0_OOo..SelectedIndexChanged, value2
			End If
		End Sub

		' Token: 0x060036F9 RID: 14073 RVA: 0x001753F6 File Offset: 0x001735F6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_O0O__o._.
		End Function

		' Token: 0x060036FA RID: 14074 RVA: 0x00175400 File Offset: 0x00173600
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooooo_.o.
			Dim o0_O0O__o._. As C1Button = Me.O0_O0O__o._.
			If o0_O0O__o._. IsNot Nothing Then
				RemoveHandler o0_O0O__o._..Click, value
			End If
			Me.O0_O0O__o._. = A_0
			o0_O0O__o._. = Me.O0_O0O__o._.
			If o0_O0O__o._. IsNot Nothing Then
				AddHandler o0_O0O__o._..Click, value
			End If
		End Sub

		' Token: 0x060036FB RID: 14075 RVA: 0x00175443 File Offset: 0x00173643
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oOo.oO0OOO.
		End Function

		' Token: 0x060036FC RID: 14076 RVA: 0x0017544C File Offset: 0x0017364C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.Oooo_oO.0OOOO.
			Dim c1Button As C1Button = Me.oOo.oO0OOO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oOo.oO0OOO. = A_0
			c1Button = Me.oOo.oO0OOO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060036FD RID: 14077 RVA: 0x0017548F File Offset: 0x0017368F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.000_.
		End Function

		' Token: 0x060036FE RID: 14078 RVA: 0x00175498 File Offset: 0x00173698
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O000._O_o_0Oo.
			Dim o.000_. As C1Button = Me.O.000_.
			If o.000_. IsNot Nothing Then
				RemoveHandler o.000_..Click, value
			End If
			Me.O.000_. = A_0
			o.000_. = Me.O.000_.
			If o.000_. IsNot Nothing Then
				AddHandler o.000_..Click, value
			End If
		End Sub

		' Token: 0x060036FF RID: 14079 RVA: 0x001754DB File Offset: 0x001736DB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_O_oo.0Oo_o.
		End Function

		' Token: 0x06003700 RID: 14080 RVA: 0x001754E4 File Offset: 0x001736E4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_._O_o.
			Dim o_O_oo.0Oo_o. As C1Button = Me.O_O_oo.0Oo_o.
			If o_O_oo.0Oo_o. IsNot Nothing Then
				RemoveHandler o_O_oo.0Oo_o..Click, value
			End If
			Me.O_O_oo.0Oo_o. = A_0
			o_O_oo.0Oo_o. = Me.O_O_oo.0Oo_o.
			If o_O_oo.0Oo_o. IsNot Nothing Then
				AddHandler o_O_oo.0Oo_o..Click, value
			End If
		End Sub

		' Token: 0x06003701 RID: 14081 RVA: 0x00175528 File Offset: 0x00173728
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.o.o_O00.().Items.Count - 1
			For i As Integer = 0 To num
				Me.o.o_O00.().SetItemChecked(i, True)
			Next
		End Sub

		' Token: 0x06003702 RID: 14082 RVA: 0x00175564 File Offset: 0x00173764
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.o.o_O00.().Items.Count - 1
			For i As Integer = 0 To num
				Me.o.o_O00.().SetItemChecked(i, Not Me.o.o_O00.().GetItemChecked(i))
			Next
		End Sub

		' Token: 0x06003703 RID: 14083 RVA: 0x001755AB File Offset: 0x001737AB
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06003704 RID: 14084 RVA: 0x001755B4 File Offset: 0x001737B4
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.O.O00__0.
			AddHandler MyBase.FormClosed, AddressOf Me.O_.0oO0.
			Me.o.o_O00.()
			Me.o.O_0_0. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003705 RID: 14085 RVA: 0x00175610 File Offset: 0x00173810
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim fixed As Integer = Me.o.O_0_0..foxGrid.Cols.Fixed
			Dim num As Integer = Me.o.O_0_0..foxGrid.Cols.Count - 1
			For i As Integer = fixed To num
				If Not o_O_o_oOoo__.oO.O_..Contains(Me.o.O_0_0..foxGrid.Cols(i).Name) Then
					Me.o.o_O00.().Items.Add(Me.o.O_0_0..foxGrid.Cols(i).Name)
					Me.o.o_O00.().SetItemChecked(Me.o.o_O00.().Items.Count - 1, Me.o.O_0_0..foxGrid.Cols(i).Visible)
				End If
			Next
		End Sub

		' Token: 0x06003706 RID: 14086 RVA: 0x001756E8 File Offset: 0x001738E8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.O_0_0..O_o0OOo_.o0..O__00.__0_O.(New ooO0O__o_o_O_(Me.o.O_0_0.))
			Me.o.O_0_0..NeedSaveSetting = True
			Dim num As Integer = Me.o.o_O00.().Items.Count - 1
			For i As Integer = 0 To num
				Dim text As String = Me.o.o_O00.().Items(i).ToString()
				If Me.o.O_0_0..foxGrid.Cols(text).Index <> i + 1 Then
					Me.o.O_0_0..foxGrid.Cols(text).Move(i + 1)
				End If
				Me.o.O_0_0..foxGrid.Cols(text).Visible = Me.o.o_O00.().GetItemChecked(i)
			Next
			MyBase.Close()
		End Sub

		' Token: 0x06003707 RID: 14087 RVA: 0x001757C4 File Offset: 0x001739C4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.o_O00.().SelectedIndex > 0 Then
				Dim itemChecked As Boolean = Me.o.o_O00.().GetItemChecked(Me.o.o_O00.().SelectedIndex)
				Dim item As String = Me.o.o_O00.().SelectedItem.ToString()
				Dim num As Integer = Me.o.o_O00.().SelectedIndex
				Me.o.o_O00.().Items.RemoveAt(num)
				num -= 1
				Me.o.o_O00.().Items.Insert(num, item)
				Me.o.o_O00.().SetItemChecked(num, itemChecked)
				Me.o.o_O00.().SelectedIndex = num
			End If
		End Sub

		' Token: 0x06003708 RID: 14088 RVA: 0x00175854 File Offset: 0x00173A54
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.o_O00.().SelectedIndex < Me.o.o_O00.().Items.Count - 1 Then
				Dim itemChecked As Boolean = Me.o.o_O00.().GetItemChecked(Me.o.o_O00.().SelectedIndex)
				Dim item As String = Me.o.o_O00.().SelectedItem.ToString()
				Dim num As Integer = Me.o.o_O00.().SelectedIndex
				Me.o.o_O00.().Items.RemoveAt(num)
				num += 1
				Me.o.o_O00.().Items.Insert(num, item)
				Me.o.o_O00.().SetItemChecked(num, itemChecked)
				Me.o.o_O00.().SelectedIndex = num
			End If
		End Sub

		' Token: 0x06003709 RID: 14089 RVA: 0x001758F4 File Offset: 0x00173AF4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			If A_1.Button = MouseButtons.Left AndAlso Me.o.o_O00.().SelectedIndex >= 0 AndAlso Me.o.o_O00.().SelectedIndex <> Me.o.O_0_0. Then
				Me.o.O_0_0. = Me.o.o_O00.().SelectedIndex
				Dim pt As Point = Me.o.o_O00.().PointToClient(Control.MousePosition)
				Dim itemRectangle As Rectangle = Me.o.o_O00.().GetItemRectangle(Me.o.o_O00.().SelectedIndex)
				If itemRectangle.Contains(pt) AndAlso pt.X < itemRectangle.X + 16 Then
					Me.o.o_O00.().SetItemChecked(Me.o.o_O00.().SelectedIndex, Not Me.o.o_O00.().GetItemChecked(Me.o.o_O00.().SelectedIndex))
				End If
			End If
		End Sub

		' Token: 0x0600370A RID: 14090 RVA: 0x001759BD File Offset: 0x00173BBD
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.O_0_0. = Me.o.o_O00.().SelectedIndex
		End Sub

		' Token: 0x0600370B RID: 14091 RVA: 0x001759D0 File Offset: 0x00173BD0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400169D RID: 5789
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400169E RID: 5790
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400169F RID: 5791
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A0 RID: 5792
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A1 RID: 5793
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040016A2 RID: 5794
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x040016A3 RID: 5795
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A4 RID: 5796
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A5 RID: 5797
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A6 RID: 5798
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016A7 RID: 5799
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040016A8 RID: 5800
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
