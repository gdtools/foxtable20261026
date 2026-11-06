Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003D9 RID: 985
	<DesignerGenerated()>
	Friend Class O\u30000\u3002\u3002O
		Inherits DropDownForm

		' Token: 0x06003EC5 RID: 16069 RVA: 0x001B1E38 File Offset: 0x001B0038
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Oo.o_oOo0_o.
			AddHandler MyBase.Load, AddressOf Me.oo.00O0_.
			Me.o_0_0__.o_. = New StringFormat()
			Me.OOOO.0. = 6
			Me.OOOO.0.()
		End Sub

		' Token: 0x06003EC6 RID: 16070 RVA: 0x001B1E88 File Offset: 0x001B0088
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_0_0__.o_. IsNot Nothing Then
					Me.o_0_0__.o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003EC7 RID: 16071 RVA: 0x001B1EC8 File Offset: 0x001B00C8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OOOO.0.(New System.Windows.Forms.ListBox())
			MyBase.SuspendLayout()
			Me.OOOO.0.().Dock = DockStyle.Top
			Me.OOOO.0.().DrawMode = DrawMode.OwnerDrawFixed
			Me.OOOO.0.().FormattingEnabled = True
			Me.OOOO.0.().IntegralHeight = False
			Me.OOOO.0.().ItemHeight = 18
			Me.OOOO.0.().Location = New Point(0, 0)
			Me.OOOO.0.().Name = "ListBox"
			Me.OOOO.0.().Size = New Size(148, 220)
			Me.OOOO.0.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.None
			MyBase.ClientSize = New Size(148, 220)
			MyBase.Controls.Add(Me.OOOO.0.())
			MyBase.Name = "o....o.O"
			Me.Text = "frmListBox"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003EC8 RID: 16072 RVA: 0x001B1FD1 File Offset: 0x001B01D1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.ListBox
			Return Me.o_0_0__.o_.
		End Function

		' Token: 0x06003EC9 RID: 16073 RVA: 0x001B1FDC File Offset: 0x001B01DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.ListBox)
			Dim value As EventHandler = AddressOf Me.O_.oOO_0_.
			Dim value2 As KeyEventHandler = AddressOf Me.OOOO.0.
			Dim value3 As DrawItemEventHandler = AddressOf Me.OOOO.0.
			Dim value4 As EventHandler = AddressOf Me.OOOO.0.
			Dim listBox As System.Windows.Forms.ListBox = Me.o_0_0__.o_.
			If listBox IsNot Nothing Then
				RemoveHandler listBox.Click, value
				RemoveHandler listBox.KeyDown, value2
				RemoveHandler listBox.DrawItem, value3
				RemoveHandler listBox.FontChanged, value4
			End If
			Me.o_0_0__.o_. = A_0
			listBox = Me.o_0_0__.o_.
			If listBox IsNot Nothing Then
				AddHandler listBox.Click, value
				AddHandler listBox.KeyDown, value2
				AddHandler listBox.DrawItem, value3
				AddHandler listBox.FontChanged, value4
			End If
		End Sub

		' Token: 0x06003ECA RID: 16074 RVA: 0x001B207C File Offset: 0x001B027C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OOOO.0.().SelectedIndex >= 0 Then
				MyBase.OwnerControl.Value = RuntimeHelpers.GetObjectValue(Me.Value)
			End If
			MyBase.CloseDropDown()
		End Sub

		' Token: 0x06003ECB RID: 16075 RVA: 0x001B20A8 File Offset: 0x001B02A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.[Return] OrElse A_1.KeyCode = Keys.Space Then
				If Me.OOOO.0.().SelectedIndex >= 0 Then
					MyBase.OwnerControl.Value = RuntimeHelpers.GetObjectValue(Me.Value)
				End If
				A_1.SuppressKeyPress = True
				A_1.Handled = True
				MyBase.CloseDropDown()
			End If
		End Sub

		' Token: 0x17000DA5 RID: 3493
		' (get) Token: 0x06003ECC RID: 16076 RVA: 0x001B2104 File Offset: 0x001B0304
		Private ReadOnly Property Value As Object
			Get
				Dim result As Object
				If Me.OOOO.0.().DataSource Is Nothing Then
					result = Me.OOOO.0.().SelectedItem
				Else
					result = Me.OOOO.0.().SelectedValue
				End If
				Return result
			End Get
		End Property

		' Token: 0x06003ECD RID: 16077 RVA: 0x001B2139 File Offset: 0x001B0339
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOOO.0.().Focus()
		End Sub

		' Token: 0x06003ECE RID: 16078 RVA: 0x001B2147 File Offset: 0x001B0347
		Friend Overloads Function <<EMPTY_NAME>>() As Integer
			Return Me.OOOO.0.
		End Function

		' Token: 0x06003ECF RID: 16079 RVA: 0x001B214F File Offset: 0x001B034F
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OOOO.0. = A_0
			Me.OOOO.0.().ItemHeight = CInt(Math.Ceiling(CDbl((Me.OOOO.0.().Font.Size / 9F * 12F)))) + A_0
		End Sub

		' Token: 0x06003ED0 RID: 16080 RVA: 0x001B2188 File Offset: 0x001B0388
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawItemEventArgs)
			If A_1.Index >= 0 Then
				A_1.DrawBackground()
				A_1.DrawFocusRectangle()
				Dim text As String = ""
				If Me.OOOO.0.().DataSource IsNot Nothing Then
					If TypeOf MyBase.OwnerControl Is OoOO0Oo_oo0oO Then
						Dim o.oO. As Foxtable.WinForm.Form = CType(MyBase.OwnerControl, OoOO0Oo_oo0oO).O.oO.
						Dim ownerControl As System.Windows.Forms.Control = MyBase.OwnerControl
						Dim listItemFormatEventArgs As ListItemFormatEventArgs = New ListItemFormatEventArgs(ownerControl, o.oO., CType(Me.OOOO.0.().Items(A_1.Index), DataRowView))
						Dim a_ As String = "ListItemFormat_" + Conversions.ToString(ownerControl.Tag)
						O_O0OO.OoO_o.oO0o0O.(o.oO..O_0.O00o_00_O., a_, New Object() { listItemFormatEventArgs }, False, o.oO..mmname + "," + ownerControl.Name, False)
						If Operators.CompareString(listItemFormatEventArgs.Text, "", True) > 0 Then
							text = listItemFormatEventArgs.Text
						End If
					End If
					If Operators.CompareString(text, "", True) = 0 Then
						Dim dataRowView As DataRowView = CType(Me.OOOO.0.().Items(A_1.Index), DataRowView)
						If Operators.CompareString(Me.OOOO.0.().DisplayMember, "", True) > 0 Then
							text = dataRowView(Me.OOOO.0.().DisplayMember).ToString()
						Else
							text = dataRowView.ToString()
						End If
					End If
				Else
					text = Me.OOOO.0.().Items(A_1.Index).ToString()
				End If
				A_1.Graphics.DrawString(text, A_1.Font, New SolidBrush(A_1.ForeColor), A_1.Bounds, Me.o_0_0__.o_.)
			End If
		End Sub

		' Token: 0x06003ED1 RID: 16081 RVA: 0x001B2324 File Offset: 0x001B0524
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o_0_0__.o_..LineAlignment = StringAlignment.Center
			Me.o_0_0__.o_..Alignment = StringAlignment.Near
			Me.o_0_0__.o_..FormatFlags = (Me.o_0_0__.o_..FormatFlags Or StringFormatFlags.NoWrap)
		End Sub

		' Token: 0x06003ED2 RID: 16082 RVA: 0x001B235A File Offset: 0x001B055A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OOOO.0.().ItemHeight = CInt(Math.Ceiling(CDbl((Me.OOOO.0.().Font.Size / 9F * 12F)))) + Me.O0o0o.o.()
		End Sub

		' Token: 0x04001979 RID: 6521
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400197A RID: 6522
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListBox

		' Token: 0x0400197B RID: 6523
		Private <<EMPTY_NAME>> As StringFormat

		' Token: 0x0400197C RID: 6524
		Friend <<EMPTY_NAME>> As Integer
	End Class
End Namespace
