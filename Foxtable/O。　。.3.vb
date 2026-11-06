Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000363 RID: 867
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3000\u3002\u3000
		Inherits Form

		' Token: 0x06003648 RID: 13896 RVA: 0x0016EFCC File Offset: 0x0016D1CC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oO.0_0. IsNot Nothing Then
					Me.oO.0_0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003649 RID: 13897 RVA: 0x0016F00C File Offset: 0x0016D20C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OooO_O0o.o.(New CheckedListBox())
			Me.O00_0.OO_oOoOo.(New C1Button())
			Me.O0.0__oO0.(New C1Button())
			Me.OooO_O0o.o.(New C1Button())
			Me.OO_.ooo_OO0.(New C1Button())
			MyBase.SuspendLayout()
			Me.OO.OO000oO.().CheckOnClick = True
			Me.OO.OO000oO.().FormattingEnabled = True
			Me.OO.OO000oO.().Location = New Point(12, 12)
			Me.OO.OO000oO.().Name = "CList"
			Me.OO.OO000oO.().Size = New Size(265, 324)
			Me.OO.OO000oO.().TabIndex = 0
			Me.Ooo0_.OO.().DialogResult = DialogResult.OK
			Me.Ooo0_.OO.().Location = New Point(292, 12)
			Me.Ooo0_.OO.().Name = "Button1"
			Me.Ooo0_.OO.().Size = New Size(75, 23)
			Me.Ooo0_.OO.().TabIndex = 1
			Me.Ooo0_.OO.().Text = "确定"
			Me.Ooo0_.OO.().UseVisualStyleBackColor = True
			Me.OO.OO000oO.().DialogResult = DialogResult.Cancel
			Me.OO.OO000oO.().Location = New Point(292, 42)
			Me.OO.OO000oO.().Name = "Button2"
			Me.OO.OO000oO.().Size = New Size(75, 23)
			Me.OO.OO000oO.().TabIndex = 2
			Me.OO.OO000oO.().Text = "取消"
			Me.OO.OO000oO.().UseVisualStyleBackColor = True
			Me.OoOo.0__O.().Location = New Point(292, 281)
			Me.OoOo.0__O.().Name = "Button3"
			Me.OoOo.0__O.().Size = New Size(75, 23)
			Me.OoOo.0__O.().TabIndex = 3
			Me.OoOo.0__O.().Text = "全选"
			Me.OoOo.0__O.().UseVisualStyleBackColor = True
			Me.O_o.0_Oo0OoO.().Location = New Point(292, 313)
			Me.O_o.0_Oo0OoO.().Name = "Button4"
			Me.O_o.0_Oo0OoO.().Size = New Size(75, 23)
			Me.O_o.0_Oo0OoO.().TabIndex = 4
			Me.O_o.0_Oo0OoO.().Text = "清除"
			Me.O_o.0_Oo0OoO.().UseVisualStyleBackColor = True
			MyBase.AcceptButton = Me.Ooo0_.OO.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.OO.OO000oO.()
			MyBase.ClientSize = New Size(380, 350)
			MyBase.Controls.Add(Me.O_o.0_Oo0OoO.())
			MyBase.Controls.Add(Me.OoOo.0__O.())
			MyBase.Controls.Add(Me.OO.OO000oO.())
			MyBase.Controls.Add(Me.Ooo0_.OO.())
			MyBase.Controls.Add(Me.OO.OO000oO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O...o000"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择统计列"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600364A RID: 13898 RVA: 0x0016F340 File Offset: 0x0016D540
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.oO.0_0.
		End Function

		' Token: 0x0600364B RID: 13899 RVA: 0x0016F348 File Offset: 0x0016D548
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ListControlConvertEventHandler = AddressOf Me.OO.OO000oO.
			Dim checkedListBox As CheckedListBox = Me.oO.0_0.
			If checkedListBox IsNot Nothing Then
				RemoveHandler checkedListBox.Format, value
			End If
			Me.oO.0_0. = A_0
			checkedListBox = Me.oO.0_0.
			If checkedListBox IsNot Nothing Then
				AddHandler checkedListBox.Format, value
			End If
		End Sub

		' Token: 0x0600364C RID: 13900 RVA: 0x0016F38B File Offset: 0x0016D58B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OooO_O0o.o.
		End Function

		' Token: 0x0600364D RID: 13901 RVA: 0x0016F394 File Offset: 0x0016D594
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOoooO.O.
			Dim oooO_O0o.o. As C1Button = Me.OooO_O0o.o.
			If oooO_O0o.o. IsNot Nothing Then
				RemoveHandler oooO_O0o.o..Click, value
			End If
			Me.OooO_O0o.o. = A_0
			oooO_O0o.o. = Me.OooO_O0o.o.
			If oooO_O0o.o. IsNot Nothing Then
				AddHandler oooO_O0o.o..Click, value
			End If
		End Sub

		' Token: 0x0600364E RID: 13902 RVA: 0x0016F3D7 File Offset: 0x0016D5D7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO_.ooo_OO0.
		End Function

		' Token: 0x0600364F RID: 13903 RVA: 0x0016F3DF File Offset: 0x0016D5DF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.OO_.ooo_OO0. = A_0
		End Sub

		' Token: 0x06003650 RID: 13904 RVA: 0x0016F3E8 File Offset: 0x0016D5E8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O00_0.OO_oOoOo.
		End Function

		' Token: 0x06003651 RID: 13905 RVA: 0x0016F3F0 File Offset: 0x0016D5F0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_Oo0.0o.
			Dim o00_0.OO_oOoOo. As C1Button = Me.O00_0.OO_oOoOo.
			If o00_0.OO_oOoOo. IsNot Nothing Then
				RemoveHandler o00_0.OO_oOoOo..Click, value
			End If
			Me.O00_0.OO_oOoOo. = A_0
			o00_0.OO_oOoOo. = Me.O00_0.OO_oOoOo.
			If o00_0.OO_oOoOo. IsNot Nothing Then
				AddHandler o00_0.OO_oOoOo..Click, value
			End If
		End Sub

		' Token: 0x06003652 RID: 13906 RVA: 0x0016F433 File Offset: 0x0016D633
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO.oO.
		End Function

		' Token: 0x06003653 RID: 13907 RVA: 0x0016F43C File Offset: 0x0016D63C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.0_OoooOo0O.
			Dim c1Button As C1Button = Me.oO.oO.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO.oO. = A_0
			c1Button = Me.oO.oO.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003654 RID: 13908 RVA: 0x0016F480 File Offset: 0x0016D680
		Public Sub New(A_0 As Table, A_1 As String, A_2 As AggregateEnum)
			AddHandler MyBase.Activated, AddressOf Me.O_._OoOo0o0oO.
			AddHandler MyBase.Load, AddressOf Me.Ooo0_.OO.
			AddHandler MyBase.FormClosed, AddressOf Me.OO.OO000oO.
			Me.OooO_O0o.o.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.oO.0_0. = A_0
			Me.oO.0_0. = A_1
			Me.oO.0_0. = A_2
		End Sub

		' Token: 0x06003655 RID: 13909 RVA: 0x0016F4F9 File Offset: 0x0016D6F9
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Me.oO.0_0..Oo0Oo___.o0o.()
			End If
		End Sub

		' Token: 0x06003656 RID: 13910 RVA: 0x0016F518 File Offset: 0x0016D718
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim collection As String() = New String(-1) {}
				IL_10:
				num2 = 3
				If Operators.CompareString(Me.oO.0_0., "", True) <= 0 Then
					GoTo IL_3F
				End If
				IL_26:
				num2 = 4
				collection = Me.oO.0_0..Split(New Char() { ","c })
				IL_3F:
				num2 = 5
				Dim list As List(Of String) = New List(Of String)()
				IL_48:
				num2 = 6
				list.AddRange(collection)
				IL_52:
				num2 = 7
				Dim fixed As Integer = Me.oO.0_0..foxGrid.Cols.Fixed
				Dim num3 As Integer = Me.oO.0_0..foxGrid.Cols.Count - 1
				Dim i As Integer = fixed
				While i <= num3
					IL_89:
					num2 = 8
					If Me.oO.0_0..foxGrid.Cols(i).DataType Is GetType(String) Then
						IL_B3:
						num2 = 9
						If Me.oO.0_0. = 4 Then
							GoTo IL_155
						End If
					Else
						IL_C7:
						num2 = 12
						If Me.oO.0_0..foxGrid.Cols(i).DataType Is GetType(Boolean) Then
							IL_F2:
							num2 = 13
							If Me.oO.0_0. = 4 OrElse Me.oO.0_0. = 2 Then
								GoTo IL_155
							End If
						Else
							IL_10C:
							num2 = 16
							If Me.oO.0_0..foxGrid.Cols(i).DataType IsNot GetType(DateTime) Then
								GoTo IL_155
							End If
							IL_137:
							num2 = 17
							If Me.oO.0_0. = 4 OrElse Me.oO.0_0. = 7 OrElse Me.oO.0_0. = 8 Then
								GoTo IL_155
							End If
						End If
					End If
					IL_1CE:
					num2 = 22
					i += 1
					Continue While
					IL_155:
					num2 = 19
					Me.OO.OO000oO.().Items.Add(Me.oO.0_0..foxGrid.Cols(i).Name)
					IL_185:
					num2 = 20
					If list.Contains(Me.oO.0_0..foxGrid.Cols(i).Name) Then
						IL_1AD:
						num2 = 21
						Me.OO.OO000oO.().SetItemChecked(Me.OO.OO000oO.().Items.Count - 1, True)
						GoTo IL_1CE
					End If
					GoTo IL_1CE
				End While
				IL_1E0:
				GoTo IL_28E
				IL_1E5:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_24F:
				GoTo IL_283
				IL_251:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_261:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_251
			End Try
			IL_283:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_28E:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003657 RID: 13911 RVA: 0x0016F7D8 File Offset: 0x0016D9D8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oO.0_0. = ""
			Dim num As Integer = Me.OO.OO000oO.().Items.Count - 1
			For i As Integer = 0 To num
				If Me.OO.OO000oO.().GetItemChecked(i) Then
					If Operators.CompareString(Me.oO.0_0., "", True) > 0 Then
						Me.oO.0_0. += ","
					End If
					Me.oO.0_0. += Me.OO.OO000oO.().Items(i).ToString()
				End If
			Next
		End Sub

		' Token: 0x06003658 RID: 13912 RVA: 0x0016F870 File Offset: 0x0016DA70
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListControlConvertEventArgs)
			If Me.oO.0_0..Cols.Contains(A_1.Value.ToString()) Then
				A_1.Value = Me.oO.0_0..Cols(A_1.Value.ToString()).Caption
			End If
		End Sub

		' Token: 0x06003659 RID: 13913 RVA: 0x0016F8C0 File Offset: 0x0016DAC0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.OO.OO000oO.().Items.Count - 1
			For i As Integer = 0 To num
				Me.OO.OO000oO.().SetItemChecked(i, True)
			Next
		End Sub

		' Token: 0x0600365A RID: 13914 RVA: 0x0016F8FC File Offset: 0x0016DAFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer = Me.OO.OO000oO.().Items.Count - 1
			For i As Integer = 0 To num
				Me.OO.OO000oO.().SetItemChecked(i, False)
			Next
		End Sub

		' Token: 0x0600365B RID: 13915 RVA: 0x0016F935 File Offset: 0x0016DB35
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001656 RID: 5718
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001657 RID: 5719
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001658 RID: 5720
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001659 RID: 5721
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400165A RID: 5722
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400165B RID: 5723
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400165C RID: 5724
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400165D RID: 5725
		Private <<EMPTY_NAME>> As AggregateEnum

		' Token: 0x0400165E RID: 5726
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400165F RID: 5727
		Private a As Integer
	End Class
End Namespace
