Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200033E RID: 830
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x060031D5 RID: 12757 RVA: 0x00143C20 File Offset: 0x00141E20
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_ooo_0.0o_. IsNot Nothing Then
					Me.O_ooo_0.0o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060031D6 RID: 12758 RVA: 0x00143C60 File Offset: 0x00141E60
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0oOo0OoO0.0oO.(New C1FlexGrid())
			Me.oo0.o_OooOoOO_.(New C1Button())
			Me.o0O00o0O.0o0.(New C1Button())
			Me.Oo_0oO_OOO.00.(New C1Button())
			Me.o0oOo0OoO0.0oO.(New C1Button())
			Me.o0oOo0OoO0.0oO.(New Label())
			Me.o0oOo0OoO0.0oO.(New C1CheckBox())
			Me.o.0_0o0__.().BeginInit()
			MyBase.SuspendLayout()
			Me.o.0_0o0__.().AllowDragging = 0
			Me.o.0_0o0__.().AllowSorting = 0
			Me.o.0_0o0__.().ColumnInfo = "3,0,0,40,0,0,Columns:0{Width:92;Caption:""名称"";}" & vbTab & "1{Width:94;Caption:""类型"";Style:""DataType:System.Int32;TextAlign:RightCenter;"";}" & vbTab & "2{Caption:""候选值"";}" & vbTab
			Me.o.0_0o0__.().ExtendLastCol = True
			Me.o.0_0o0__.().Location = New Point(12, 12)
			Me.o.0_0o0__.().Name = "C1FlexGrid1"
			Me.o.0_0o0__.().Rows.Count = 1
			Me.o.0_0o0__.().Rows.DefaultSize = 22
			Me.o.0_0o0__.().Size = New Size(485, 222)
			Me.o.0_0o0__.().TabIndex = 0
			Me.O_Oo__0oO_.0.().Location = New Point(340, 298)
			Me.O_Oo__0oO_.0.().Name = "btnOk"
			Me.O_Oo__0oO_.0.().Size = New Size(75, 23)
			Me.O_Oo__0oO_.0.().TabIndex = 1
			Me.O_Oo__0oO_.0.().Text = "确定"
			Me.O_Oo__0oO_.0.().UseVisualStyleBackColor = True
			Me.OO0_O._.().CausesValidation = False
			Me.OO0_O._.().Location = New Point(421, 298)
			Me.OO0_O._.().Name = "btnCancel"
			Me.OO0_O._.().Size = New Size(75, 23)
			Me.OO0_O._.().TabIndex = 2
			Me.OO0_O._.().Text = "取消"
			Me.OO0_O._.().UseVisualStyleBackColor = True
			Me.o.0_0o0__.().Location = New Point(12, 298)
			Me.o.0_0o0__.().Name = "btnAdd"
			Me.o.0_0o0__.().Size = New Size(75, 23)
			Me.o.0_0o0__.().TabIndex = 3
			Me.o.0_0o0__.().Text = "增加"
			Me.o.0_0o0__.().UseVisualStyleBackColor = True
			Me.oO0Oo_.0000.().Location = New Point(93, 298)
			Me.oO0Oo_.0000.().Name = "btnDel"
			Me.oO0Oo_.0000.().Size = New Size(75, 23)
			Me.oO0Oo_.0000.().TabIndex = 4
			Me.oO0Oo_.0000.().Text = "删除"
			Me.oO0Oo_.0000.().UseVisualStyleBackColor = True
			Me.o.0_0o0__.().AutoSize = True
			Me.o.0_0o0__.().Location = New Point(12, 246)
			Me.o.0_0o0__.().Name = "Label1"
			Me.o.0_0o0__.().Size = New Size(341, 12)
			Me.o.0_0o0__.().TabIndex = 5
			Me.o.0_0o0__.().Text = "提示：候选值之间用符号""|""隔开，例如：华东|华北|华南|西北"
			Me.o.0_0o0__.().AutoSize = True
			Me.o.0_0o0__.().Checked = True
			Me.o.0_0o0__.().CheckState = CheckState.Checked
			Me.o.0_0o0__.().Location = New Point(12, 269)
			Me.o.0_0o0__.().Name = "CheckBox1"
			Me.o.0_0o0__.().Size = New Size(96, 16)
			Me.o.0_0o0__.().TabIndex = 6
			Me.o.0_0o0__.().Text = "记忆密码属性"
			Me.o.0_0o0__.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(509, 333)
			MyBase.Controls.Add(Me.o.0_0o0__.())
			MyBase.Controls.Add(Me.o.0_0o0__.())
			MyBase.Controls.Add(Me.oO0Oo_.0000.())
			MyBase.Controls.Add(Me.o.0_0o0__.())
			MyBase.Controls.Add(Me.OO0_O._.())
			MyBase.Controls.Add(Me.O_Oo__0oO_.0.())
			MyBase.Controls.Add(Me.o.0_0o0__.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.oOO..."
			MyBase.ShowIcon = False
			Me.Text = "扩展用户属性设置"
			Me.o.0_0o0__.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060031D7 RID: 12759 RVA: 0x001440E9 File Offset: 0x001422E9
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_ooo_0.0o_.
		End Function

		' Token: 0x060031D8 RID: 12760 RVA: 0x001440F4 File Offset: 0x001422F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim validateEditEventHandler As ValidateEditEventHandler = AddressOf Me.OO._O_00O.
			Dim o_ooo_0.0o_. As C1FlexGrid = Me.O_ooo_0.0o_.
			If o_ooo_0.0o_. IsNot Nothing Then
				o_ooo_0.0o_..ValidateEdit -= validateEditEventHandler
			End If
			Me.O_ooo_0.0o_. = A_0
			o_ooo_0.0o_. = Me.O_ooo_0.0o_.
			If o_ooo_0.0o_. IsNot Nothing Then
				o_ooo_0.0o_..ValidateEdit += validateEditEventHandler
			End If
		End Sub

		' Token: 0x060031D9 RID: 12761 RVA: 0x00144137 File Offset: 0x00142337
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_ooo_0.0o_.
		End Function

		' Token: 0x060031DA RID: 12762 RVA: 0x00144140 File Offset: 0x00142340
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO._O_00O.
			Dim o_ooo_0.0o_. As C1Button = Me.O_ooo_0.0o_.
			If o_ooo_0.0o_. IsNot Nothing Then
				RemoveHandler o_ooo_0.0o_..Click, value
			End If
			Me.O_ooo_0.0o_. = A_0
			o_ooo_0.0o_. = Me.O_ooo_0.0o_.
			If o_ooo_0.0o_. IsNot Nothing Then
				AddHandler o_ooo_0.0o_..Click, value
			End If
		End Sub

		' Token: 0x060031DB RID: 12763 RVA: 0x00144183 File Offset: 0x00142383
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_0oO_OOO.00.
		End Function

		' Token: 0x060031DC RID: 12764 RVA: 0x0014418C File Offset: 0x0014238C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOO_._.
			Dim oo_0oO_OOO.00. As C1Button = Me.Oo_0oO_OOO.00.
			If oo_0oO_OOO.00. IsNot Nothing Then
				RemoveHandler oo_0oO_OOO.00..Click, value
			End If
			Me.Oo_0oO_OOO.00. = A_0
			oo_0oO_OOO.00. = Me.Oo_0oO_OOO.00.
			If oo_0oO_OOO.00. IsNot Nothing Then
				AddHandler oo_0oO_OOO.00..Click, value
			End If
		End Sub

		' Token: 0x060031DD RID: 12765 RVA: 0x001441CF File Offset: 0x001423CF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0O00o0O.0o0.
		End Function

		' Token: 0x060031DE RID: 12766 RVA: 0x001441D8 File Offset: 0x001423D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOO.__oO_OO.
			Dim c1Button As C1Button = Me.o0O00o0O.0o0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0O00o0O.0o0. = A_0
			c1Button = Me.o0O00o0O.0o0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060031DF RID: 12767 RVA: 0x0014421B File Offset: 0x0014241B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO.__O.
		End Function

		' Token: 0x060031E0 RID: 12768 RVA: 0x00144224 File Offset: 0x00142424
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoOO.o00_000o.
			Dim c1Button As C1Button = Me.oO.__O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO.__O. = A_0
			c1Button = Me.oO.__O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060031E1 RID: 12769 RVA: 0x00144267 File Offset: 0x00142467
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.O_ooo_0.0o_.
		End Function

		' Token: 0x060031E2 RID: 12770 RVA: 0x0014426F File Offset: 0x0014246F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_ooo_0.0o_. = A_0
		End Sub

		' Token: 0x060031E3 RID: 12771 RVA: 0x00144278 File Offset: 0x00142478
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O_ooo_0.0o_.
		End Function

		' Token: 0x060031E4 RID: 12772 RVA: 0x00144280 File Offset: 0x00142480
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O_ooo_0.0o_. = A_0
		End Sub

		' Token: 0x060031E5 RID: 12773 RVA: 0x0014428C File Offset: 0x0014248C
		Public Sub New(A_0 As DataTable)
			AddHandler MyBase.Load, AddressOf Me.OO0_O._.
			AddHandler MyBase.FormClosed, AddressOf Me.o.0_0o0__.
			Me.o0oOo0OoO0.0oO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o.0_0o0__.().Styles.SelectedColumnHeader.Clear()
			Me.o.0_0o0__.().Styles.Alternate.Clear()
			Me.o.0_0o0__.().Styles.Focus.Clear()
			Me.o.0_0o0__.().Styles.Focus.MergeWith(Me.o.0_0o0__.().Styles.Normal)
			Me.o.0_0o0__.().FocusRect = 3
			Me.O_ooo_0.0o_. = A_0
		End Sub

		' Token: 0x060031E6 RID: 12774 RVA: 0x00144358 File Offset: 0x00142558
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.o.0_0o0__.()
			c1FlexGrid.Rows.Count = c1FlexGrid.Rows.Count + 1
			c1FlexGrid.Row = c1FlexGrid.Rows.Count - 1
			c1FlexGrid(c1FlexGrid.Row, 1) = 0
			c1FlexGrid.Focus()
		End Sub

		' Token: 0x060031E7 RID: 12775 RVA: 0x001443B3 File Offset: 0x001425B3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0o0__.().Row > 0 Then
				Me.o.0_0o0__.().Rows.Remove(Me.o.0_0o0__.().Row)
			End If
			Me.o.0_0o0__.().Focus()
		End Sub

		' Token: 0x060031E8 RID: 12776 RVA: 0x001443EC File Offset: 0x001425EC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim dataRow As DataRow = Nothing
			Try
				For Each obj As Object In Me.O_ooo_0.0o_..Rows
					Dim dataRow2 As DataRow = CType(obj, DataRow)
					If Conversions.ToInteger(dataRow2("Type")) = 7 Then
						dataRow = dataRow2
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If dataRow IsNot Nothing Then
				Dim text As String = dataRow("Config").ToString()
				If text.StartsWith("{") And text.EndsWith("}") Then
					Me.o.0_0o0__.().Checked = False
					text = text.Trim(New Char() { "{"c, "}"c })
				End If
				For Each text2 As String In text.Split(New Char() { vbCr })
					Me.o.0_0o0__.().AddItem(text2)
				Next
			End If
			Me.o.0_0o0__.().Col = 0
			Dim listDictionary As ListDictionary = New ListDictionary()
			listDictionary.Add(0, "字符型")
			listDictionary.Add(1, "数值型")
			listDictionary.Add(2, "日期型")
			listDictionary.Add(3, "逻辑型")
			listDictionary.Add(4, "密码型")
			Me.o.0_0o0__.().Cols(1).DataMap = listDictionary
			Me.o.0_0o0__.().Styles.Fixed.TextAlign = 4
		End Sub

		' Token: 0x060031E9 RID: 12777 RVA: 0x00144588 File Offset: 0x00142788
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0_0o0__.().Editor IsNot Nothing Then
				Me.o.0_0o0__.().FinishEditing(True)
			End If
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x060031EA RID: 12778 RVA: 0x001445AC File Offset: 0x001427AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataRow As DataRow = Nothing
				IL_0B:
				num2 = 3
				Dim enumerator As IEnumerator = Me.O_ooo_0.0o_..Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow2 As DataRow = CType(obj, DataRow)
					IL_2F:
					num2 = 4
					If Conversions.ToInteger(dataRow2("Type")) = 7 Then
						IL_45:
						num2 = 5
						dataRow = dataRow2
						Exit While
					End If
					IL_4C:
					num2 = 7
				End While
				IL_57:
				num2 = 8
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_6E:
				num2 = 9
				Me.o.0_0o0__.().BeginUpdate()
				IL_7C:
				num2 = 10
				If dataRow IsNot Nothing Then
					GoTo IL_CC
				End If
				IL_82:
				num2 = 11
				dataRow = Me.O_ooo_0.0o_..NewRow()
				IL_91:
				num2 = 12
				dataRow("Name") = "AttatchInfo"
				IL_A4:
				num2 = 13
				dataRow("Type") = 7
				IL_B8:
				num2 = 14
				Me.O_ooo_0.0o_..Rows.Add(dataRow)
				IL_CC:
				num2 = 15
				If Me.o.0_0o0__.().Rows.Count <> 1 Then
					GoTo IL_FA
				End If
				IL_E2:
				num2 = 16
				dataRow("Config") = ""
				GoTo IL_29A
				IL_FA:
				num2 = 18
				Dim text As String = ""
				IL_104:
				num2 = 19
				Dim num3 As Integer = Me.o.0_0o0__.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_123:
					num2 = 20
					If Me.o.0_0o0__.().Rows(i)(0) Is Nothing OrElse Operators.CompareString(Me.o.0_0o0__.().Rows(i)(0).ToString(), "", True) = 0 Then
						IL_16A:
						num2 = 21
						MessageBox.Show("请输入信息名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						IL_180:
						num2 = 22
						Me.o.0_0o0__.().EndUpdate()
						GoTo IL_2B3
					End If
					IL_193:
					num2 = 25
					If Operators.CompareString(text, "", True) > 0 Then
						IL_1A6:
						num2 = 26
						text += vbCr
					End If
					IL_1B7:
					num2 = 27
					Dim text2 As String = ""
					IL_1C1:
					num2 = 28
					Dim num4 As Integer = Me.o.0_0o0__.().Cols.Count - 1
					For j As Integer = 0 To num4
						IL_1DD:
						num2 = 29
						If Operators.CompareString(text2, "", True) > 0 Then
							IL_1F0:
							num2 = 30
							text2 += vbTab
						End If
						IL_201:
						num2 = 31
						If Me.o.0_0o0__.().GetData(i, j) IsNot Nothing Then
							IL_215:
							num2 = 32
							text2 += Me.o.0_0o0__.().GetData(i, j).ToString()
						End If
						IL_235:
						num2 = 33
					Next
					IL_244:
					num2 = 34
					text += text2
					IL_252:
					num2 = 35
				Next
				IL_264:
				num2 = 36
				If Me.o.0_0o0__.().Checked Then
					GoTo IL_28A
				End If
				IL_274:
				num2 = 37
				text = "{" + text + "}"
				IL_28A:
				num2 = 38
				dataRow("Config") = text
				IL_29A:
				num2 = 39
				Oo00.o0_o._O_.(Me.O_ooo_0.0o_., True)
				IL_2A9:
				num2 = 40
				MyBase.DialogResult = DialogResult.OK
				IL_2B3:
				GoTo IL_3A9
				IL_2B8:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_36A:
				GoTo IL_39E
				IL_36C:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_37C:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_36C
			End Try
			IL_39E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3A9:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060031EB RID: 12779 RVA: 0x00144988 File Offset: 0x00142B88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ValidateEditEventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.o.0_0o0__.()
			If A_1.Col = 0 AndAlso Operators.CompareString(c1FlexGrid.Editor.Text, "", True) > 0 Then
				Dim num As Integer = c1FlexGrid.Rows.Count - 1
				For i As Integer = 0 To num
					If i <> A_1.Row AndAlso c1FlexGrid.GetData(i, 0) IsNot Nothing AndAlso Operators.CompareString(c1FlexGrid.GetData(i, 0).ToString(), c1FlexGrid.Editor.Text, True) = 0 Then
						MessageBox.Show("存在同名项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						A_1.Cancel = True
					End If
				Next
			End If
		End Sub

		' Token: 0x060031EC RID: 12780 RVA: 0x00144A29 File Offset: 0x00142C29
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x0400140B RID: 5131
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x0400140C RID: 5132
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x0400140D RID: 5133
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400140E RID: 5134
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400140F RID: 5135
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001410 RID: 5136
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001411 RID: 5137
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001412 RID: 5138
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001413 RID: 5139
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
