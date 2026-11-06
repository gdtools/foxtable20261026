Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000351 RID: 849
	<DesignerGenerated()>
	Friend Partial Class oo\u3000\u30000\u3002\u3000o\u3002
		Inherits Form

		' Token: 0x060033DF RID: 13279 RVA: 0x00155420 File Offset: 0x00153620
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O._oOo_O0O0O_. IsNot Nothing Then
					Me.O._oOo_O0O0O_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060033E0 RID: 13280 RVA: 0x00155460 File Offset: 0x00153660
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.Oo__.o_o___0.(New C1Button())
			Me.O.0___oO.(New C1Button())
			Me.Oo__.o_o___0.(New CheckedListBox())
			Me.Oo__.o_o___0.(New C1CheckBox())
			MyBase.SuspendLayout()
			Me.oO.OOo0_Ooo_0.().Anchor = AnchorStyles.Bottom
			Me.oO.OOo0_Ooo_0.().DialogResult = DialogResult.OK
			Me.oO.OOo0_Ooo_0.().Location = New Point(50, 312)
			Me.oO.OOo0_Ooo_0.().Name = "Button1"
			Me.oO.OOo0_Ooo_0.().Size = New Size(75, 23)
			Me.oO.OOo0_Ooo_0.().TabIndex = 1
			Me.oO.OOo0_Ooo_0.().Text = "确定"
			Me.oO.OOo0_Ooo_0.().UseVisualStyleBackColor = True
			Me.Oo__.o_o___0.().Anchor = AnchorStyles.Bottom
			Me.Oo__.o_o___0.().DialogResult = DialogResult.Cancel
			Me.Oo__.o_o___0.().Location = New Point(131, 312)
			Me.Oo__.o_o___0.().Name = "Button2"
			Me.Oo__.o_o___0.().Size = New Size(75, 23)
			Me.Oo__.o_o___0.().TabIndex = 2
			Me.Oo__.o_o___0.().Text = "取消"
			Me.Oo__.o_o___0.().UseVisualStyleBackColor = True
			Me.Oo__.o_o___0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.Oo__.o_o___0.().CheckOnClick = True
			Me.Oo__.o_o___0.().FormattingEnabled = True
			Me.Oo__.o_o___0.().Location = New Point(12, 13)
			Me.Oo__.o_o___0.().Name = "CheckedListBox1"
			Me.Oo__.o_o___0.().Size = New Size(233, 260)
			Me.Oo__.o_o___0.().TabIndex = 0
			Me.Oo__.o_o___0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Left)
			Me.Oo__.o_o___0.().AutoSize = True
			Me.Oo__.o_o___0.().Location = New Point(13, 280)
			Me.Oo__.o_o___0.().Name = "CheckBox1"
			Me.Oo__.o_o___0.().Size = New Size(84, 16)
			Me.Oo__.o_o___0.().TabIndex = 3
			Me.Oo__.o_o___0.().Text = "排除所选值"
			Me.Oo__.o_o___0.().UseVisualStyleBackColor = True
			MyBase.AcceptButton = Me.oO.OOo0_Ooo_0.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.Oo__.o_o___0.()
			MyBase.ClientSize = New Size(257, 349)
			MyBase.Controls.Add(Me.Oo__.o_o___0.())
			MyBase.Controls.Add(Me.Oo__.o_o___0.())
			MyBase.Controls.Add(Me.Oo__.o_o___0.())
			MyBase.Controls.Add(Me.oO.OOo0_Ooo_0.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO....O."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择值"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060033E1 RID: 13281 RVA: 0x00155755 File Offset: 0x00153955
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo__.o_o___0.
		End Function

		' Token: 0x060033E2 RID: 13282 RVA: 0x00155760 File Offset: 0x00153960
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0._0O0O.
			Dim oo__.o_o___0. As C1Button = Me.Oo__.o_o___0.
			If oo__.o_o___0. IsNot Nothing Then
				RemoveHandler oo__.o_o___0..Click, value
			End If
			Me.Oo__.o_o___0. = A_0
			oo__.o_o___0. = Me.Oo__.o_o___0.
			If oo__.o_o___0. IsNot Nothing Then
				AddHandler oo__.o_o___0..Click, value
			End If
		End Sub

		' Token: 0x060033E3 RID: 13283 RVA: 0x001557A3 File Offset: 0x001539A3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.0___oO.
		End Function

		' Token: 0x060033E4 RID: 13284 RVA: 0x001557AB File Offset: 0x001539AB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O.0___oO. = A_0
		End Sub

		' Token: 0x060033E5 RID: 13285 RVA: 0x001557B4 File Offset: 0x001539B4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.O._oOo_O0O0O_.
		End Function

		' Token: 0x060033E6 RID: 13286 RVA: 0x001557BC File Offset: 0x001539BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.O0._0O0O.
			Dim o._oOo_O0O0O_. As CheckedListBox = Me.O._oOo_O0O0O_.
			If o._oOo_O0O0O_. IsNot Nothing Then
				RemoveHandler o._oOo_O0O0O_..ItemCheck, value
			End If
			Me.O._oOo_O0O0O_. = A_0
			o._oOo_O0O0O_. = Me.O._oOo_O0O0O_.
			If o._oOo_O0O0O_. IsNot Nothing Then
				AddHandler o._oOo_O0O0O_..ItemCheck, value
			End If
		End Sub

		' Token: 0x060033E7 RID: 13287 RVA: 0x001557FF File Offset: 0x001539FF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O._oOo_O0O0O_.
		End Function

		' Token: 0x060033E8 RID: 13288 RVA: 0x00155807 File Offset: 0x00153A07
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O._oOo_O0O0O_. = A_0
		End Sub

		' Token: 0x060033E9 RID: 13289 RVA: 0x00155810 File Offset: 0x00153A10
		Public Sub New(A_0 As Table, A_1 As Col)
			AddHandler MyBase.FormClosed, AddressOf Me.O0._0O0O.
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Dim flag As Boolean = Oo00.O____0O._0.(A_0)
				IL_21:
				num = 2
				Me.Oo__.o_o___0.()
				IL_29:
				num = 3
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_40:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_47:
				num = 5
				Me.O._oOo_O0O0O_. = A_0
				IL_50:
				num = 6
				Me.O._oOo_O0O0O_. = A_1
				IL_59:
				num = 7
				Me.Oo__.o_o___0.().Items.Add("全选", False)
				IL_72:
				num = 8
				Me.Oo__.o_o___0.().Items.Add("空白", False)
				IL_8B:
				num = 9
				Dim name As String = A_1.Name
				IL_96:
				num = 10
				If flag Then
					GoTo IL_F4
				End If
				IL_9C:
				num = 11
				Dim dataView As DataView = New DataView(O_O0OO.OOOo.oo_OOOO_0.().Tables(A_0.DataTable.Name), A_0.View.get_Filter(), A_1.Name, DataViewRowState.CurrentRows)
				IL_D3:
				num = 12
				Dim dataTable As DataTable = dataView.ToTable(True, New String() { A_1.Name })
				GoTo IL_19B
				IL_F4:
				num = 14
				Dim str As String = Oo00.oo_0__0.o.(A_0.DataTable._Adapter.SelectCommand.CommandText)
				IL_113:
				num = 15
				Dim text As String = "Select Distinct [" + name + "] From " + str
				IL_12B:
				num = 16
				If Operators.CompareString(A_0.DataTable.OOOOO._., "", True) <= 0 Then
					GoTo IL_163
				End If
				IL_147:
				num = 17
				text = text + " Where " + A_0.DataTable.OOOOO._.
				IL_163:
				num = 18
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, A_0.DataTable._Adapter.SelectCommand.Connection)
				IL_184:
				num = 19
				dataTable = New DataTable()
				IL_18E:
				num = 20
				oleDbDataAdapter.Fill(dataTable)
				IL_19B:
				num = 21
				If Not A_1.IsDate() Then
					GoTo IL_251
				End If
				IL_1A9:
				num = 22
				Dim format As String = A_0.foxGrid.Cols(name).Format
				IL_1C5:
				num = 23
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_1E6:
					num = 24
					If Not dataRow.IsNull(name) Then
						IL_1F4:
						num = 25
						Me.Oo__.o_o___0.().Items.Add(Strings.Format(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataRow(name))), format), False)
					End If
					IL_228:
					num = 26
				End While
				IL_234:
				num = 27
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_2C7
				End If
				GoTo IL_2C7
				IL_251:
				num = 29
				Dim enumerator2 As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRow2 As DataRow = CType(obj2, DataRow)
					IL_272:
					num = 30
					If Not dataRow2.IsNull(name) Then
						IL_280:
						num = 31
						Me.Oo__.o_o___0.().Items.Add(dataRow2(name).ToString(), False)
					End If
					IL_2A3:
					num = 32
				End While
				IL_2AF:
				num = 33
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_2C7:
				num = 34
				Me.Text = Me.Text + " - " + A_1.Caption
				IL_2E6:
				GoTo IL_3C4
				IL_2EB:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_385:
				GoTo IL_3B9
				IL_387:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_397:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_387
			End Try
			IL_3B9:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3C4:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060033EA RID: 13290 RVA: 0x00155C08 File Offset: 0x00153E08
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			If A_1.Index = 0 Then
				Dim value As Boolean
				If A_1.NewValue = CheckState.Checked Then
					value = True
				End If
				Dim num As Integer = Me.Oo__.o_o___0.().Items.Count - 1
				For i As Integer = 1 To num
					Me.Oo__.o_o___0.().SetItemChecked(i, value)
				Next
			End If
		End Sub

		' Token: 0x060033EB RID: 13291 RVA: 0x00155C54 File Offset: 0x00153E54
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = Me.Oo__.o_o___0.().Items.Count - 1
				Dim num4 As Integer
				For i As Integer = 1 To num3
					IL_22:
					num2 = 3
					If Me.Oo__.o_o___0.().GetItemChecked(i) Then
						IL_33:
						num2 = 4
						num4 += 1
					End If
					IL_39:
					num2 = 5
				Next
				IL_47:
				num2 = 6
				If num4 = 0 OrElse num4 = Me.Oo__.o_o___0.().Items.Count - 1 Then
					GoTo IL_30E
				End If
				IL_67:
				num2 = 8
				If Not Me.Oo__.o_o___0.().GetItemChecked(1) Then
					GoTo IL_7E
				End If
				IL_77:
				num2 = 9
				num4 -= 1
				IL_7E:
				num2 = 10
				Dim value As String = ""
				IL_88:
				num2 = 11
				Dim text As String = ""
				IL_92:
				num2 = 12
				Dim flag As Boolean = Oo00.O____0O._0.(Me.O._oOo_O0O0O_.)
				IL_A2:
				num2 = 13
				If Not flag Then
					GoTo IL_C6
				End If
				IL_A9:
				num2 = 14
				Dim text2 As String = Oo00.OoOo_oo_.o_o.(Me.O._oOo_O0O0O_..Name, Me.O._oOo_O0O0O_.)
				GoTo IL_E5
				IL_C6:
				num2 = 16
				text2 = "[" + Me.O._oOo_O0O0O_..Name + "]"
				IL_E5:
				num2 = 17
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_EF:
				num2 = 18
				If Not Me.O._oOo_O0O0O_..IsDate() Then
					GoTo IL_10B
				End If
				IL_FF:
				num2 = 19
				value = "#"
				GoTo IL_125
				IL_10B:
				num2 = 21
				If Not Me.O._oOo_O0O0O_..IsString() Then
					GoTo IL_125
				End If
				IL_11B:
				num2 = 22
				value = "'"
				IL_125:
				num2 = 23
				Dim num5 As Integer = Me.Oo__.o_o___0.().Items.Count - 1
				For j As Integer = 2 To num5
					IL_141:
					num2 = 24
					If Me.Oo__.o_o___0.().GetItemChecked(j) Then
						IL_153:
						num2 = 25
						If stringBuilder.Length > 0 Then
							IL_160:
							num2 = 26
							stringBuilder.Append(",")
						End If
						IL_170:
						num2 = 27
						stringBuilder.Append(value)
						IL_17D:
						num2 = 28
						stringBuilder.Append(Me.Oo__.o_o___0.().Items(j).ToString())
						IL_19F:
						num2 = 29
						stringBuilder.Append(value)
					End If
					IL_1AC:
					num2 = 30
				Next
				IL_1BB:
				num2 = 31
				If Not Me.Oo__.o_o___0.().Checked Then
					GoTo IL_280
				End If
				IL_1CE:
				num2 = 32
				If Operators.CompareString(stringBuilder.ToString(), "", True) <= 0 Then
					GoTo IL_203
				End If
				IL_1E6:
				num2 = 33
				text = text2 + " Not In (" + stringBuilder.ToString() + ")"
				IL_203:
				num2 = 34
				If Not Me.Oo__.o_o___0.().GetItemChecked(1) Then
					GoTo IL_250
				End If
				IL_214:
				num2 = 35
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_238
				End If
				IL_227:
				num2 = 36
				text += " And "
				IL_238:
				num2 = 37
				text = text + text2 + " Is Not Null"
				GoTo IL_2FD
				IL_250:
				num2 = 39
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_2FD
				End If
				IL_266:
				num2 = 40
				text = text + " Or " + text2 + " Is Null"
				GoTo IL_2FD
				IL_280:
				num2 = 42
				If Operators.CompareString(stringBuilder.ToString(), "", True) <= 0 Then
					GoTo IL_2B5
				End If
				IL_298:
				num2 = 43
				text = text2 + " In (" + stringBuilder.ToString() + ")"
				IL_2B5:
				num2 = 44
				If Not Me.Oo__.o_o___0.().GetItemChecked(1) Then
					GoTo IL_2FD
				End If
				IL_2C6:
				num2 = 45
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_2EA
				End If
				IL_2D9:
				num2 = 46
				text += " Or "
				IL_2EA:
				num2 = 47
				text = text + text2 + " Is Null"
				IL_2FD:
				num2 = 48
				Filter.O0O0o.Oo0OO_oO.(Me.O._oOo_O0O0O_., text, True)
				IL_30E:
				GoTo IL_424
				IL_313:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_3E5:
				GoTo IL_419
				IL_3E7:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3F7:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3E7
			End Try
			IL_419:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_424:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060033EC RID: 13292 RVA: 0x001560AC File Offset: 0x001542AC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001515 RID: 5397
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001516 RID: 5398
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001517 RID: 5399
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001518 RID: 5400
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001519 RID: 5401
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400151A RID: 5402
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400151B RID: 5403
		Private <<EMPTY_NAME>> As Col
	End Class
End Namespace
