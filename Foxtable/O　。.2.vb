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
	' Token: 0x020000C8 RID: 200
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class O\u3000\u3002\u3000
		Inherits Form

		' Token: 0x060008EF RID: 2287 RVA: 0x0003E0EC File Offset: 0x0003C2EC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo._O__OO_0O. IsNot Nothing Then
					Me.Oo._O__OO_0O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060008F0 RID: 2288 RVA: 0x0003E12C File Offset: 0x0003C32C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o000.O0.(New C1Button())
			Me.OoOo_0O._O00.(New C1Button())
			Me.OoOo_0O._O00.(New Label())
			Me.o000.O0.(New Label())
			Me.OoOo_0O._O00.(New C1ComboBox())
			Me.o000.O0.(New C1ComboBox())
			Me.O0oOOo_o_O.O_O.().BeginInit()
			Me.O.00OO00_oo.().BeginInit()
			Me.O.00OO00_oo.().BeginInit()
			Me.O0oOOo_o_O.O_O.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0oOOo_o_O.O_O.().DialogResult = DialogResult.Cancel
			Me.O0oOOo_o_O.O_O.().ImageAlign = ContentAlignment.MiddleLeft
			Me.O0oOOo_o_O.O_O.().Location = New Point(178, 110)
			Me.O0oOOo_o_O.O_O.().Name = "btnCancel"
			Me.O0oOOo_o_O.O_O.().Size = New Size(75, 23)
			Me.O0oOOo_o_O.O_O.().TabIndex = 31
			Me.O0oOOo_o_O.O_O.().Text = "取消"
			Me.O0oOOo_o_O.O_O.().UseVisualStyleBackColor = True
			Me.O.00OO00_oo.().ImageAlign = ContentAlignment.MiddleLeft
			Me.O.00OO00_oo.().Location = New Point(82, 110)
			Me.O.00OO00_oo.().Name = "btnOK"
			Me.O.00OO00_oo.().Size = New Size(75, 23)
			Me.O.00OO00_oo.().TabIndex = 28
			Me.O.00OO00_oo.().Text = "筛选"
			Me.O.00OO00_oo.().UseVisualStyleBackColor = True
			Me.o000.O0.().AutoSize = True
			Me.o000.O0.().Location = New Point(32, 61)
			Me.o000.O0.().Margin = New Padding(2, 0, 2, 0)
			Me.o000.O0.().Name = "Label2"
			Me.o000.O0.().Size = New Size(35, 12)
			Me.o000.O0.().TabIndex = 29
			Me.o000.O0.().Text = "下级:"
			Me.OoOo_0O._O00.().AutoSize = True
			Me.OoOo_0O._O00.().Location = New Point(32, 24)
			Me.OoOo_0O._O00.().Margin = New Padding(2, 0, 2, 0)
			Me.OoOo_0O._O00.().Name = "Label1"
			Me.OoOo_0O._O00.().Size = New Size(35, 12)
			Me.OoOo_0O._O00.().TabIndex = 27
			Me.OoOo_0O._O00.().Text = "上级:"
			Me.O.00OO00_oo.().AllowSpinLoop = False
			Me.O.00OO00_oo.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O.00OO00_oo.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O.00OO00_oo.().Cursor = Cursors.Arrow
			Me.O.00OO00_oo.().DropDownStyle = 1
			Me.O.00OO00_oo.().GapHeight = 0
			Me.O.00OO00_oo.().ImagePadding = New Padding(0)
			Me.O.00OO00_oo.().ItemsDisplayMember = ""
			Me.O.00OO00_oo.().ItemsValueMember = ""
			Me.O.00OO00_oo.().Location = New Point(72, 58)
			Me.O.00OO00_oo.().Name = "cmbChildCol"
			Me.O.00OO00_oo.().Size = New Size(241, 19)
			Me.O.00OO00_oo.().TabIndex = 24
			Me.O.00OO00_oo.().Tag = Nothing
			Me.O0oOOo_o_O.O_O.().AllowSpinLoop = False
			Me.O0oOOo_o_O.O_O.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O0oOOo_o_O.O_O.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O0oOOo_o_O.O_O.().Cursor = Cursors.Arrow
			Me.O0oOOo_o_O.O_O.().DropDownStyle = 1
			Me.O0oOOo_o_O.O_O.().GapHeight = 0
			Me.O0oOOo_o_O.O_O.().ImagePadding = New Padding(0)
			Me.O0oOOo_o_O.O_O.().ItemsDisplayMember = ""
			Me.O0oOOo_o_O.O_O.().ItemsValueMember = ""
			Me.O0oOOo_o_O.O_O.().Location = New Point(72, 21)
			Me.O0oOOo_o_O.O_O.().Name = "cmbParentCol"
			Me.O0oOOo_o_O.O_O.().Size = New Size(241, 19)
			Me.O0oOOo_o_O.O_O.().TabIndex = 23
			Me.O0oOOo_o_O.O_O.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(334, 155)
			MyBase.Controls.Add(Me.O0oOOo_o_O.O_O.())
			MyBase.Controls.Add(Me.O.00OO00_oo.())
			MyBase.Controls.Add(Me.o000.O0.())
			MyBase.Controls.Add(Me.OoOo_0O._O00.())
			MyBase.Controls.Add(Me.O.00OO00_oo.())
			MyBase.Controls.Add(Me.O0oOOo_o_O.O_O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o0.00...o"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "循环引用筛选"
			Me.O0oOOo_o_O.O_O.().EndInit()
			Me.O.00OO00_oo.().EndInit()
			Me.O.00OO00_oo.().EndInit()
			Me.O0oOOo_o_O.O_O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060008F1 RID: 2289 RVA: 0x0003E62E File Offset: 0x0003C82E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo._O__OO_0O.
		End Function

		' Token: 0x060008F2 RID: 2290 RVA: 0x0003E636 File Offset: 0x0003C836
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo._O__OO_0O. = A_0
		End Sub

		' Token: 0x060008F3 RID: 2291 RVA: 0x0003E63F File Offset: 0x0003C83F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_Oo0._oOoo0.
		End Function

		' Token: 0x060008F4 RID: 2292 RVA: 0x0003E648 File Offset: 0x0003C848
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.00OO00_oo.
			Dim c1Button As C1Button = Me.o_Oo0._oOoo0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_Oo0._oOoo0. = A_0
			c1Button = Me.o_Oo0._oOoo0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060008F5 RID: 2293 RVA: 0x0003E68B File Offset: 0x0003C88B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo._O__OO_0O.
		End Function

		' Token: 0x060008F6 RID: 2294 RVA: 0x0003E693 File Offset: 0x0003C893
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo._O__OO_0O. = A_0
		End Sub

		' Token: 0x060008F7 RID: 2295 RVA: 0x0003E69C File Offset: 0x0003C89C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_Oo0._oOoo0.
		End Function

		' Token: 0x060008F8 RID: 2296 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_Oo0._oOoo0. = A_0
		End Sub

		' Token: 0x060008F9 RID: 2297 RVA: 0x0003E6AD File Offset: 0x0003C8AD
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo._O__OO_0O.
		End Function

		' Token: 0x060008FA RID: 2298 RVA: 0x0003E6B5 File Offset: 0x0003C8B5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.Oo._O__OO_0O. = A_0
		End Sub

		' Token: 0x060008FB RID: 2299 RVA: 0x0003E6BE File Offset: 0x0003C8BE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_Oo0._oOoo0.
		End Function

		' Token: 0x060008FC RID: 2300 RVA: 0x0003E6C6 File Offset: 0x0003C8C6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_Oo0._oOoo0. = A_0
		End Sub

		' Token: 0x060008FD RID: 2301 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.O0oOOo_o_O.O_O.
			AddHandler MyBase.FormClosed, AddressOf Me.O.00OO00_oo.
			Me.Oo._O__OO_0O. = New Dictionary(Of String, String)()
			Me.OoOo_0O._O00.()
			Me.Oo._O__OO_0O. = A_0
		End Sub

		' Token: 0x060008FE RID: 2302 RVA: 0x0003E720 File Offset: 0x0003C920
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim array As C1ComboBox() = New C1ComboBox() { Me.O0oOOo_o_O.O_O.(), Me.O.00OO00_oo.() }
			Try
				For Each dataCol As DataCol In Me.Oo._O__OO_0O..DataTable.DataCols
					Dim text As String = dataCol.Name
					If Operators.CompareString(dataCol.Caption, "", True) > 0 AndAlso Not Me.Oo._O__OO_0O..ContainsKey(dataCol.Caption) Then
						Me.Oo._O__OO_0O..Add(dataCol.Caption, dataCol.Name)
						text = dataCol.Caption
					End If
					Dim array2 As C1ComboBox() = array
					For i As Integer = 0 To array2.Length - 1
						array2(i).Items.Add(text)
					Next
					If Operators.CompareString(text, Me.Oo._O__OO_0O..O0.00__., True) = 0 Then
						Me.O0oOOo_o_O.O_O.().SelectedIndex = Me.O0oOOo_o_O.O_O.().Items.Count - 1
					End If
					If Operators.CompareString(text, Me.Oo._O__OO_0O..o.o0o_0., True) = 0 Then
						Me.O.00OO00_oo.().SelectedIndex = Me.O.00OO00_oo.().Items.Count - 1
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060008FF RID: 2303 RVA: 0x0003E888 File Offset: 0x0003CA88
		Private Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim result As String
			If Me.Oo._O__OO_0O..ContainsKey(A_0) Then
				result = Me.Oo._O__OO_0O.(A_0)
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06000900 RID: 2304 RVA: 0x0003E8B8 File Offset: 0x0003CAB8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0oOOo_o_O.O_O.().SelectedItem IsNot Nothing AndAlso Me.O.00OO00_oo.().SelectedItem IsNot Nothing Then
				Me.Oo._O__OO_0O..O0.00__. = Me.O0oOOo_o_O.O_O.().SelectedItem.ToString()
				Me.Oo._O__OO_0O..o.o0o_0. = Me.O.00OO00_oo.().SelectedItem.ToString()
				Me.Oo._O__OO_0O..NeedSaveSetting = True
				Me.Oo._O__OO_0O..LoopFilter(Me.O0oOOo_o_O.O_O.().SelectedItem.ToString(), Me.O.00OO00_oo.().SelectedItem.ToString())
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x06000901 RID: 2305 RVA: 0x0003E956 File Offset: 0x0003CB56
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000322 RID: 802
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000323 RID: 803
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000324 RID: 804
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000325 RID: 805
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000326 RID: 806
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000327 RID: 807
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000328 RID: 808
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04000329 RID: 809
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400032A RID: 810
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
