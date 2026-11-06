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
	' Token: 0x02000065 RID: 101
	<DesignerGenerated()>
	Friend Partial Class o\u3002_\u3000\u3000\u3000
		Inherits Form

		' Token: 0x06000365 RID: 869 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OoOO._. IsNot Nothing Then
					Me.OoOO._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000366 RID: 870 RVA: 0x0000AB08 File Offset: 0x00008D08
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O._o00o_0oO_O.(New C1Button())
			Me.O.0oo0O0_o.(New C1Button())
			Me.O.0oo0O0_o.(New CheckedListBox())
			Me.O.0oo0O0_o.(New C1TextBox())
			Me.oO000O_Ooo.oo0.().BeginInit()
			Me.O_Ooo0o0._o_.().BeginInit()
			Me.oO000O_Ooo.oo0.().BeginInit()
			MyBase.SuspendLayout()
			Me.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.oO000O_Ooo.oo0.().Location = New Point(421, 414)
			Me.oO000O_Ooo.oo0.().Name = "Button2"
			Me.oO000O_Ooo.oo0.().Size = New Size(75, 23)
			Me.oO000O_Ooo.oo0.().TabIndex = 2
			Me.oO000O_Ooo.oo0.().Text = "取消"
			Me.oO000O_Ooo.oo0.().UseVisualStyleBackColor = True
			Me.O_Ooo0o0._o_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O_Ooo0o0._o_.().Location = New Point(340, 414)
			Me.O_Ooo0o0._o_.().Name = "Button1"
			Me.O_Ooo0o0._o_.().Size = New Size(75, 23)
			Me.O_Ooo0o0._o_.().TabIndex = 1
			Me.O_Ooo0o0._o_.().Text = "确定"
			Me.O_Ooo0o0._o_.().UseVisualStyleBackColor = True
			Me.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO000O_Ooo.oo0.().CheckOnClick = True
			Me.oO000O_Ooo.oo0.().FormattingEnabled = True
			Me.oO000O_Ooo.oo0.().IntegralHeight = False
			Me.oO000O_Ooo.oo0.().Location = New Point(14, 102)
			Me.oO000O_Ooo.oo0.().Name = "CheckedListBox1"
			Me.oO000O_Ooo.oo0.().Size = New Size(482, 300)
			Me.oO000O_Ooo.oo0.().TabIndex = 0
			Me.oO000O_Ooo.oo0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.oO000O_Ooo.oo0.().Location = New Point(14, 14)
			Me.oO000O_Ooo.oo0.().Multiline = True
			Me.oO000O_Ooo.oo0.().Name = "TextBox1"
			Me.oO000O_Ooo.oo0.().ScrollBars = ScrollBars.Vertical
			Me.oO000O_Ooo.oo0.().Size = New Size(482, 74)
			Me.oO000O_Ooo.oo0.().TabIndex = 3
			Me.oO000O_Ooo.oo0.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(508, 449)
			MyBase.Controls.Add(Me.oO000O_Ooo.oo0.())
			MyBase.Controls.Add(Me.O_Ooo0o0._o_.())
			MyBase.Controls.Add(Me.oO000O_Ooo.oo0.())
			MyBase.Controls.Add(Me.oO000O_Ooo.oo0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "frmTableColumnSlector"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择列"
			Me.oO000O_Ooo.oo0.().EndInit()
			Me.O_Ooo0o0._o_.().EndInit()
			Me.oO000O_Ooo.oo0.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000367 RID: 871 RVA: 0x0000AE17 File Offset: 0x00009017
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.0oo0O0_o.
		End Function

		' Token: 0x06000368 RID: 872 RVA: 0x0000AE20 File Offset: 0x00009020
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_Ooo0o0._o_.
			Dim o.0oo0O0_o. As C1Button = Me.O.0oo0O0_o.
			If o.0oo0O0_o. IsNot Nothing Then
				RemoveHandler o.0oo0O0_o..Click, value
			End If
			Me.O.0oo0O0_o. = A_0
			o.0oo0O0_o. = Me.O.0oo0O0_o.
			If o.0oo0O0_o. IsNot Nothing Then
				AddHandler o.0oo0O0_o..Click, value
			End If
		End Sub

		' Token: 0x06000369 RID: 873 RVA: 0x0000AE63 File Offset: 0x00009063
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._o00o_0oO_O.
		End Function

		' Token: 0x0600036A RID: 874 RVA: 0x0000AE6C File Offset: 0x0000906C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oO000O_Ooo.oo0.
			Dim o._o00o_0oO_O. As C1Button = Me.O._o00o_0oO_O.
			If o._o00o_0oO_O. IsNot Nothing Then
				RemoveHandler o._o00o_0oO_O..Click, value
			End If
			Me.O._o00o_0oO_O. = A_0
			o._o00o_0oO_O. = Me.O._o00o_0oO_O.
			If o._o00o_0oO_O. IsNot Nothing Then
				AddHandler o._o00o_0oO_O..Click, value
			End If
		End Sub

		' Token: 0x0600036B RID: 875 RVA: 0x0000AEAF File Offset: 0x000090AF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.O.0oo0O0_o.
		End Function

		' Token: 0x0600036C RID: 876 RVA: 0x0000AEB8 File Offset: 0x000090B8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.oO000O_Ooo.oo0.
			Dim o.0oo0O0_o. As CheckedListBox = Me.O.0oo0O0_o.
			If o.0oo0O0_o. IsNot Nothing Then
				RemoveHandler o.0oo0O0_o..ItemCheck, value
			End If
			Me.O.0oo0O0_o. = A_0
			o.0oo0O0_o. = Me.O.0oo0O0_o.
			If o.0oo0O0_o. IsNot Nothing Then
				AddHandler o.0oo0O0_o..ItemCheck, value
			End If
		End Sub

		' Token: 0x0600036D RID: 877 RVA: 0x0000AEFB File Offset: 0x000090FB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.O.0oo0O0_o.
		End Function

		' Token: 0x0600036E RID: 878 RVA: 0x0000AF03 File Offset: 0x00009103
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.O.0oo0O0_o. = A_0
		End Sub

		' Token: 0x0600036F RID: 879 RVA: 0x0000AF0C File Offset: 0x0000910C
		Public Sub New(A_0 As Table, A_1 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oO000O_Ooo.oo0.
			Dim num2 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.O.0oo0O0_o.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_3E:
				num = 4
				Me.OoOO._. = A_0
				IL_47:
				num = 5
				Dim enumerator As IEnumerator(Of Col) = A_0.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_5F:
					num = 6
					Me.oO000O_Ooo.oo0.().Items.Add(col.Name)
					IL_79:
					num = 7
				End While
				IL_83:
				num = 8
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_8E:
				num = 9
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_1F4
				End If
				IL_A3:
				num = 10
				Dim array As String() = A_1.Split(New Char() { "|"c })
				IL_B9:
				num = 11
				Dim text As String = ""
				IL_C3:
				num = 12
				Dim num3 As Integer = array.Length - 2
				For i As Integer = 0 To num3 Step 2
					IL_D6:
					num = 13
					Dim text2 As String = array(i)
					IL_E0:
					num = 14
					If A_0.Cols.Contains(text2) Then
						IL_F5:
						num = 15
						Dim width As Integer
						If Not Integer.TryParse(array(i + 1), width) Then
							IL_108:
							num = 16
							width = A_0.Cols(text2).Width
						End If
						IL_11F:
						num = 17
						text = String.Concat(New String() { text, text2, "|", Conversions.ToString(width), "|" })
						IL_153:
						num = 18
						Dim num4 As Integer = Me.oO000O_Ooo.oo0.().Items.Count - 1
						For j As Integer = 0 To num4
							IL_16F:
							num = 19
							If Operators.CompareString(Me.oO000O_Ooo.oo0.().Items(j).ToString(), text2, True) = 0 Then
								IL_193:
								num = 20
								Me.oO000O_Ooo.oo0.().SetItemChecked(j, True)
							End If
							IL_1A4:
							num = 21
						Next
					End If
					IL_1B3:
					num = 22
				Next
				IL_1C5:
				num = 23
				Me.O.0oo0O0_o. = text.Trim(New Char() { "|"c })
				IL_1E0:
				num = 24
				Me.oO000O_Ooo.oo0.().Value = Me.O.0oo0O0_o.
				IL_1F4:
				num = 25
				Me.OoOO._. = True
				IL_1FE:
				GoTo IL_2B8
				IL_203:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_279:
				GoTo IL_2AD
				IL_27B:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_28B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27B
			End Try
			IL_2AD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2B8:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000370 RID: 880 RVA: 0x0000B1F8 File Offset: 0x000093F8
		Public Sub New(A_0 As DataTable, A_1 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oO000O_Ooo.oo0.
			Dim num2 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.O.0oo0O0_o.()
				IL_20:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_27:
				num = 3
				Me.OoOO._. = A_0
				IL_30:
				num = 4
				Dim enumerator As IEnumerator(Of DataCol) = A_0.DataCols.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataCol As DataCol = enumerator.Current
					IL_48:
					num = 5
					Me.oO000O_Ooo.oo0.().Items.Add(dataCol.Name)
					IL_62:
					num = 6
				End While
				IL_6C:
				num = 7
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_77:
				num = 8
				If Operators.CompareString(A_1, "", True) <= 0 Then
					GoTo IL_1CB
				End If
				IL_8B:
				num = 9
				Dim array As String() = A_1.Split(New Char() { "|"c })
				IL_A1:
				num = 10
				Dim text As String = ""
				IL_AB:
				num = 11
				Dim num3 As Integer = array.Length - 2
				For i As Integer = 0 To num3 Step 2
					IL_BE:
					num = 12
					Dim text2 As String = array(i)
					IL_C8:
					num = 13
					If A_0.DataCols.Contains(text2) Then
						IL_DD:
						num = 14
						Dim value As Integer
						If Not Integer.TryParse(array(i + 1), value) Then
							IL_F0:
							num = 15
							value = -1
						End If
						IL_F6:
						num = 16
						text = String.Concat(New String() { text, text2, "|", Conversions.ToString(value), "|" })
						IL_12A:
						num = 17
						Dim num4 As Integer = Me.oO000O_Ooo.oo0.().Items.Count - 1
						For j As Integer = 0 To num4
							IL_146:
							num = 18
							If Operators.CompareString(Me.oO000O_Ooo.oo0.().Items(j).ToString(), text2, True) = 0 Then
								IL_16A:
								num = 19
								Me.oO000O_Ooo.oo0.().SetItemChecked(j, True)
							End If
							IL_17B:
							num = 20
						Next
					End If
					IL_18A:
					num = 21
				Next
				IL_19C:
				num = 22
				Me.O.0oo0O0_o. = text.Trim(New Char() { "|"c })
				IL_1B7:
				num = 23
				Me.oO000O_Ooo.oo0.().Value = Me.O.0oo0O0_o.
				IL_1CB:
				num = 24
				Me.OoOO._. = True
				IL_1D5:
				GoTo IL_28B
				IL_1DA:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_24C:
				GoTo IL_280
				IL_24E:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_25E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_24E
			End Try
			IL_280:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_28B:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000371 RID: 881 RVA: 0x0000B4B4 File Offset: 0x000096B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06000372 RID: 882 RVA: 0x0000B4BD File Offset: 0x000096BD
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.0oo0O0_o. = Me.oO000O_Ooo.oo0.().Text
			MyBase.DialogResult = DialogResult.OK
		End Sub

		' Token: 0x06000373 RID: 883 RVA: 0x0000B4D8 File Offset: 0x000096D8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.OoOO._. Then
					GoTo IL_147
				End If
				IL_14:
				num2 = 4
				Dim list As List(Of String) = New List(Of String)()
				IL_1C:
				num2 = 5
				If Operators.CompareString(Me.oO000O_Ooo.oo0.().Text, "", True) <= 0 Then
					GoTo IL_5A
				End If
				IL_37:
				num2 = 6
				list.AddRange(Me.oO000O_Ooo.oo0.().Text.Split(New Char() { "|"c }))
				IL_5A:
				num2 = 7
				Dim text As String = Me.oO000O_Ooo.oo0.().Items(A_1.Index).ToString()
				IL_79:
				num2 = 8
				If A_1.NewValue <> CheckState.Checked Then
					GoTo IL_EA
				End If
				IL_84:
				num2 = 9
				If list.Contains(text) Then
					GoTo IL_129
				End If
				IL_94:
				num2 = 10
				list.Add(text)
				IL_9F:
				num2 = 11
				If Me.OoOO._. Is Nothing Then
					GoTo IL_DA
				End If
				IL_AA:
				num2 = 12
				list.Add(Me.OoOO._..Grid.Cols(text).WidthDisplay.ToString())
				GoTo IL_129
				IL_DA:
				num2 = 14
				list.Add("-1")
				GoTo IL_129
				IL_EA:
				num2 = 16
				If Not list.Contains(text) Then
					GoTo IL_129
				End If
				IL_F7:
				num2 = 17
				Dim num3 As Integer = list.IndexOf(text)
				IL_104:
				num2 = 18
				If num3 >= list.Count - 1 Then
					GoTo IL_129
				End If
				IL_113:
				num2 = 19
				list.RemoveAt(num3)
				IL_11E:
				num2 = 20
				list.RemoveAt(num3)
				IL_129:
				num2 = 21
				Me.oO000O_Ooo.oo0.().Value = String.Join("|", list.ToArray())
				IL_147:
				GoTo IL_1F1
				IL_14C:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_1B2:
				GoTo IL_1E6
				IL_1B4:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1C4:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1B4
			End Try
			IL_1E6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F1:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000374 RID: 884 RVA: 0x0000B6FC File Offset: 0x000098FC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040000A2 RID: 162
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040000A3 RID: 163
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000A4 RID: 164
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040000A5 RID: 165
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x040000A6 RID: 166
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x040000A7 RID: 167
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040000A8 RID: 168
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x040000A9 RID: 169
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040000AA RID: 170
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
