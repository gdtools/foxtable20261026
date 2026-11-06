Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200033C RID: 828
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x060031AB RID: 12715 RVA: 0x00142C14 File Offset: 0x00140E14
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OO.O0O__0oOO0o. IsNot Nothing Then
					Me.OO.O0O__0oOO0o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060031AC RID: 12716 RVA: 0x00142C54 File Offset: 0x00140E54
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o.OOoO_Ooo.(New C1Button())
			Me.O_0___O00.00.(New C1Button())
			Me.OO.O0O__0oOO0o.(New C1TextBox())
			Me.oOOo.O_0.(New Label())
			Me.o.OOoO_Ooo.(New Label())
			Me.oOOo.O_0.(New C1Button())
			Me.O0_00O_o.__o.().BeginInit()
			Me.oOOo.O_0.().BeginInit()
			Me.o.OOoO_Ooo.().BeginInit()
			Me.Oo_0_0.oo.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0_00O_o.__o.().DialogResult = DialogResult.OK
			Me.O0_00O_o.__o.().Location = New Point(273, 24)
			Me.O0_00O_o.__o.().Margin = New Padding(4, 4, 4, 4)
			Me.O0_00O_o.__o.().Name = "btnOK"
			Me.O0_00O_o.__o.().Size = New Size(112, 34)
			Me.O0_00O_o.__o.().TabIndex = 5
			Me.O0_00O_o.__o.().Text = "确定"
			Me.O0_00O_o.__o.().UseVisualStyleBackColor = True
			Me.oOOo.O_0.().DialogResult = DialogResult.Cancel
			Me.oOOo.O_0.().Location = New Point(273, 63)
			Me.oOOo.O_0.().Margin = New Padding(4, 4, 4, 4)
			Me.oOOo.O_0.().Name = "Button2"
			Me.oOOo.O_0.().Size = New Size(112, 34)
			Me.oOOo.O_0.().TabIndex = 6
			Me.oOOo.O_0.().Text = "取消"
			Me.oOOo.O_0.().UseVisualStyleBackColor = True
			Me.o.OOoO_Ooo.().DataType = GetType(Integer)
			Me.o.OOoO_Ooo.().Location = New Point(28, 72)
			Me.o.OOoO_Ooo.().Margin = New Padding(4, 4, 4, 4)
			Me.o.OOoO_Ooo.().Name = "txtColWidth"
			Me.o.OOoO_Ooo.().Size = New Size(150, 26)
			Me.o.OOoO_Ooo.().TabIndex = 2
			Me.o.OOoO_Ooo.().Tag = Nothing
			Me.o.OOoO_Ooo.().AutoSize = True
			Me.o.OOoO_Ooo.().Location = New Point(26, 32)
			Me.o.OOoO_Ooo.().Margin = New Padding(4, 0, 4, 0)
			Me.o.OOoO_Ooo.().Name = "Label1"
			Me.o.OOoO_Ooo.().Size = New Size(53, 18)
			Me.o.OOoO_Ooo.().TabIndex = 7
			Me.o.OOoO_Ooo.().Text = "列宽:"
			Me.oOOo.O_0.().AutoSize = True
			Me.oOOo.O_0.().Location = New Point(188, 76)
			Me.oOOo.O_0.().Margin = New Padding(4, 0, 4, 0)
			Me.oOOo.O_0.().Name = "Label2"
			Me.oOOo.O_0.().Size = New Size(62, 18)
			Me.oOOo.O_0.().TabIndex = 8
			Me.oOOo.O_0.().Text = "(像素)"
			Me.Oo_0_0.oo.().DialogResult = DialogResult.OK
			Me.Oo_0_0.oo.().Location = New Point(273, 102)
			Me.Oo_0_0.oo.().Margin = New Padding(4, 4, 4, 4)
			Me.Oo_0_0.oo.().Name = "Button1"
			Me.Oo_0_0.oo.().Size = New Size(112, 34)
			Me.Oo_0_0.oo.().TabIndex = 9
			Me.Oo_0_0.oo.().Text = "最佳列宽"
			Me.Oo_0_0.oo.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(412, 159)
			MyBase.Controls.Add(Me.Oo_0_0.oo.())
			MyBase.Controls.Add(Me.oOOo.O_0.())
			MyBase.Controls.Add(Me.o.OOoO_Ooo.())
			MyBase.Controls.Add(Me.o.OOoO_Ooo.())
			MyBase.Controls.Add(Me.oOOo.O_0.())
			MyBase.Controls.Add(Me.O0_00O_o.__o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oI0.0.l."
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "列宽"
			Me.O0_00O_o.__o.().EndInit()
			Me.oOOo.O_0.().EndInit()
			Me.o.OOoO_Ooo.().EndInit()
			Me.Oo_0_0.oo.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060031AD RID: 12717 RVA: 0x001430DE File Offset: 0x001412DE
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO.O0O__0oOO0o.
		End Function

		' Token: 0x060031AE RID: 12718 RVA: 0x001430E8 File Offset: 0x001412E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO.oooOOo.
			Dim oo.O0O__0oOO0o. As C1Button = Me.OO.O0O__0oOO0o.
			If oo.O0O__0oOO0o. IsNot Nothing Then
				RemoveHandler oo.O0O__0oOO0o..Click, value
			End If
			Me.OO.O0O__0oOO0o. = A_0
			oo.O0O__0oOO0o. = Me.OO.O0O__0oOO0o.
			If oo.O0O__0oOO0o. IsNot Nothing Then
				AddHandler oo.O0O__0oOO0o..Click, value
			End If
		End Sub

		' Token: 0x060031AF RID: 12719 RVA: 0x0014312B File Offset: 0x0014132B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO_.oOO.
		End Function

		' Token: 0x060031B0 RID: 12720 RVA: 0x00143133 File Offset: 0x00141333
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.oO_.oOO. = A_0
		End Sub

		' Token: 0x060031B1 RID: 12721 RVA: 0x0014313C File Offset: 0x0014133C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO.O0O__0oOO0o.
		End Function

		' Token: 0x060031B2 RID: 12722 RVA: 0x00143144 File Offset: 0x00141344
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OO.O0O__0oOO0o. = A_0
		End Sub

		' Token: 0x060031B3 RID: 12723 RVA: 0x0014314D File Offset: 0x0014134D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO.O0O__0oOO0o.
		End Function

		' Token: 0x060031B4 RID: 12724 RVA: 0x00143155 File Offset: 0x00141355
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO.O0O__0oOO0o. = A_0
		End Sub

		' Token: 0x060031B5 RID: 12725 RVA: 0x0014315E File Offset: 0x0014135E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO_.oOO.
		End Function

		' Token: 0x060031B6 RID: 12726 RVA: 0x00143166 File Offset: 0x00141366
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO_.oOO. = A_0
		End Sub

		' Token: 0x060031B7 RID: 12727 RVA: 0x0014316F File Offset: 0x0014136F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo_.0ooO.
		End Function

		' Token: 0x060031B8 RID: 12728 RVA: 0x00143178 File Offset: 0x00141378
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_00O_o.__o.
			Dim c1Button As C1Button = Me.oo_.0ooO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo_.0ooO. = A_0
			c1Button = Me.oo_.0ooO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060031B9 RID: 12729 RVA: 0x001431BC File Offset: 0x001413BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.o.OOoO_Ooo.().Value = Me.OO.O0O__0oOO0o..Cols(Me.OO.O0O__0oOO0o..Col).WidthDisplay.ToString()
		End Sub

		' Token: 0x060031BA RID: 12730 RVA: 0x001431FC File Offset: 0x001413FC
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.Oo_0_0.oo.
			AddHandler MyBase.FormClosed, AddressOf Me.O0_00O_o.__o.
			Me.o.OOoO_Ooo.()
			Me.OO.O0O__0oOO0o. = A_0.foxGrid
			Me.OO.O0O__0oOO0o. = A_0
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060031BB RID: 12731 RVA: 0x00143264 File Offset: 0x00141464
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim leftCol As Integer = Me.OO.O0O__0oOO0o..Selection.LeftCol
			Dim rightCol As Integer = Me.OO.O0O__0oOO0o..Selection.RightCol
			Me.OO.O0O__0oOO0o..O_o0OOo_.o0..O__00.__0_O.(New OoO_oO(Me.OO.O0O__0oOO0o.))
			Dim num As Integer = CInt(Math.Round(Conversion.Val(Me.o.OOoO_Ooo.().Text)))
			If num > 0 Then
				Dim num2 As Integer = leftCol
				Dim num3 As Integer = rightCol
				For i As Integer = num2 To num3
					If Me.OO.O0O__0oOO0o..Cols(i).Visible Then
						Me.OO.O0O__0oOO0o..Cols(i).Width = num
					End If
				Next
			End If
			Me.OO.O0O__0oOO0o..NeedSaveSetting = True
		End Sub

		' Token: 0x060031BC RID: 12732 RVA: 0x00143320 File Offset: 0x00141520
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim leftCol As Integer = Me.OO.O0O__0oOO0o..Selection.LeftCol
			Dim rightCol As Integer = Me.OO.O0O__0oOO0o..Selection.RightCol
			Me.OO.O0O__0oOO0o..O_o0OOo_.o0..O__00.__0_O.(New OoO_oO(Me.OO.O0O__0oOO0o.))
			Dim num As Integer = rightCol
			For i As Integer = leftCol To num
				If Me.OO.O0O__0oOO0o..Cols(i).Visible Then
					Me.OO.O0O__0oOO0o..AutoSizeCol(i, 2)
				End If
			Next
			Me.OO.O0O__0oOO0o..NeedSaveSetting = True
		End Sub

		' Token: 0x060031BD RID: 12733 RVA: 0x001433AD File Offset: 0x001415AD
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013F7 RID: 5111
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013F8 RID: 5112
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013F9 RID: 5113
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013FA RID: 5114
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040013FB RID: 5115
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013FC RID: 5116
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040013FD RID: 5117
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013FE RID: 5118
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040013FF RID: 5119
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
