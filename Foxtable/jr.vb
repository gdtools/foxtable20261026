Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002A2 RID: 674
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class jr
		Inherits Form

		' Token: 0x060023A5 RID: 9125 RVA: 0x000F6848 File Offset: 0x000F4A48
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o_O0.oOOo_00oO. IsNot Nothing Then
					Me.o_O0.oOOo_00oO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060023A6 RID: 9126 RVA: 0x000F6888 File Offset: 0x000F4A88
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(jr))
			Me.Ooo_o_OO.O0_O.(New Label())
			Me.Ooo_o_OO.O0_O.(New C1TextBox())
			Me.oO0__.ooo.(New C1Button())
			Me.Ooo_o_OO.O0_O.(New C1Button())
			Me.Ooo_o_OO.O0_O.(New C1FlexGrid())
			Me.Ooo_o_OO.O0_O.(New C1CheckBox())
			Me.ooooO_.OoO_0O.().BeginInit()
			Me.ooooO_.OoO_0O.().BeginInit()
			Me.oO0___0o0O.0.().BeginInit()
			Me.ooooO_.OoO_0O.().BeginInit()
			Me.ooooO_.OoO_0O.().BeginInit()
			MyBase.SuspendLayout()
			Me.ooooO_.OoO_0O.().AutoSize = True
			Me.ooooO_.OoO_0O.().Location = New Point(12, 14)
			Me.ooooO_.OoO_0O.().Name = "Label1"
			Me.ooooO_.OoO_0O.().Size = New Size(155, 12)
			Me.ooooO_.OoO_0O.().TabIndex = 15
			Me.ooooO_.OoO_0O.().Text = "请选择用于生成筛选树的列:"
			Me.ooooO_.OoO_0O.().Location = New Point(12, 35)
			Me.ooooO_.OoO_0O.().Name = "TextBox1"
			Me.ooooO_.OoO_0O.().[ReadOnly] = True
			Me.ooooO_.OoO_0O.().Size = New Size(494, 19)
			Me.ooooO_.OoO_0O.().TabIndex = 14
			Me.ooooO_.OoO_0O.().Tag = Nothing
			Me.ooooO_.OoO_0O.().Location = New Point(263, 408)
			Me.ooooO_.OoO_0O.().Name = "Button2"
			Me.ooooO_.OoO_0O.().Size = New Size(75, 23)
			Me.ooooO_.OoO_0O.().TabIndex = 13
			Me.ooooO_.OoO_0O.().Text = "取消"
			Me.ooooO_.OoO_0O.().UseVisualStyleBackColor = True
			Me.oO0___0o0O.0.().Location = New Point(182, 408)
			Me.oO0___0o0O.0.().Name = "Button1"
			Me.oO0___0o0O.0.().Size = New Size(75, 23)
			Me.oO0___0o0O.0.().TabIndex = 12
			Me.oO0___0o0O.0.().Text = "确定"
			Me.oO0___0o0O.0.().UseVisualStyleBackColor = True
			Me.ooooO_.OoO_0O.().AllowSorting = 0
			Me.ooooO_.OoO_0O.().BorderStyle = 1
			Me.ooooO_.OoO_0O.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.ooooO_.OoO_0O.().ExtendLastCol = True
			Me.ooooO_.OoO_0O.().FocusRect = 0
			Me.ooooO_.OoO_0O.().Font = New Font("宋体", 9F)
			Me.ooooO_.OoO_0O.().Location = New Point(12, 75)
			Me.ooooO_.OoO_0O.().Name = "C1FlexGrid1"
			Me.ooooO_.OoO_0O.().Rows.Count = 1
			Me.ooooO_.OoO_0O.().Rows.DefaultSize = 21
			Me.ooooO_.OoO_0O.().SelectionMode = 3
			Me.ooooO_.OoO_0O.().Size = New Size(494, 290)
			Me.ooooO_.OoO_0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.ooooO_.OoO_0O.().TabIndex = 11
			Me.ooooO_.OoO_0O.().AutoSize = True
			Me.ooooO_.OoO_0O.().BorderStyle = BorderStyle.None
			Me.ooooO_.OoO_0O.().Location = New Point(12, 372)
			Me.ooooO_.OoO_0O.().Name = "CheckBox1"
			Me.ooooO_.OoO_0O.().Size = New Size(108, 16)
			Me.ooooO_.OoO_0O.().TabIndex = 16
			Me.ooooO_.OoO_0O.().Text = "自动显示筛选树"
			Me.ooooO_.OoO_0O.().UseVisualStyleBackColor = True
			Me.ooooO_.OoO_0O.().Value = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(520, 443)
			MyBase.Controls.Add(Me.ooooO_.OoO_0O.())
			MyBase.Controls.Add(Me.ooooO_.OoO_0O.())
			MyBase.Controls.Add(Me.ooooO_.OoO_0O.())
			MyBase.Controls.Add(Me.ooooO_.OoO_0O.())
			MyBase.Controls.Add(Me.oO0___0o0O.0.())
			MyBase.Controls.Add(Me.ooooO_.OoO_0O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o..ooO..o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "筛选树"
			Me.ooooO_.OoO_0O.().EndInit()
			Me.ooooO_.OoO_0O.().EndInit()
			Me.oO0___0o0O.0.().EndInit()
			Me.ooooO_.OoO_0O.().EndInit()
			Me.ooooO_.OoO_0O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060023A7 RID: 9127 RVA: 0x000F6D42 File Offset: 0x000F4F42
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o_O0.oOOo_00oO.
		End Function

		' Token: 0x060023A8 RID: 9128 RVA: 0x000F6D4A File Offset: 0x000F4F4A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_O0.oOOo_00oO. = A_0
		End Sub

		' Token: 0x060023A9 RID: 9129 RVA: 0x000F6D53 File Offset: 0x000F4F53
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_O0.oOOo_00oO.
		End Function

		' Token: 0x060023AA RID: 9130 RVA: 0x000F6D5B File Offset: 0x000F4F5B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_O0.oOOo_00oO. = A_0
		End Sub

		' Token: 0x060023AB RID: 9131 RVA: 0x000F6D64 File Offset: 0x000F4F64
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.Ooo_o_OO.O0_O.
		End Function

		' Token: 0x060023AC RID: 9132 RVA: 0x000F6D6C File Offset: 0x000F4F6C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_00_O.0o__.
			Dim ooo_o_OO.O0_O. As C1Button = Me.Ooo_o_OO.O0_O.
			If ooo_o_OO.O0_O. IsNot Nothing Then
				RemoveHandler ooo_o_OO.O0_O..Click, value
			End If
			Me.Ooo_o_OO.O0_O. = A_0
			ooo_o_OO.O0_O. = Me.Ooo_o_OO.O0_O.
			If ooo_o_OO.O0_O. IsNot Nothing Then
				AddHandler ooo_o_OO.O0_O..Click, value
			End If
		End Sub

		' Token: 0x060023AD RID: 9133 RVA: 0x000F6DAF File Offset: 0x000F4FAF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0__.ooo.
		End Function

		' Token: 0x060023AE RID: 9134 RVA: 0x000F6DB8 File Offset: 0x000F4FB8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OO_OoOOo0oOo.O.
			Dim c1Button As C1Button = Me.oO0__.ooo.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0__.ooo. = A_0
			c1Button = Me.oO0__.ooo.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060023AF RID: 9135 RVA: 0x000F6DFB File Offset: 0x000F4FFB
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Ooo_o_OO.O0_O.
		End Function

		' Token: 0x060023B0 RID: 9136 RVA: 0x000F6E04 File Offset: 0x000F5004
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.OO_OoOOo0oOo.O.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.oO.0_0.
			Dim ooo_o_OO.O0_O. As C1FlexGrid = Me.Ooo_o_OO.O0_O.
			If ooo_o_OO.O0_O. IsNot Nothing Then
				ooo_o_OO.O0_O..AfterEdit -= rowColEventHandler
				ooo_o_OO.O0_O..BeforeEdit -= rowColEventHandler2
			End If
			Me.Ooo_o_OO.O0_O. = A_0
			ooo_o_OO.O0_O. = Me.Ooo_o_OO.O0_O.
			If ooo_o_OO.O0_O. IsNot Nothing Then
				ooo_o_OO.O0_O..AfterEdit += rowColEventHandler
				ooo_o_OO.O0_O..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x060023B1 RID: 9137 RVA: 0x000F6E62 File Offset: 0x000F5062
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Ooo_o_OO.O0_O.
		End Function

		' Token: 0x060023B2 RID: 9138 RVA: 0x000F6E6A File Offset: 0x000F506A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Ooo_o_OO.O0_O. = A_0
		End Sub

		' Token: 0x060023B3 RID: 9139 RVA: 0x000F6E74 File Offset: 0x000F5074
		Public Sub New(A_0 As Table)
			AddHandler MyBase.FormClosed, AddressOf Me.ooooO_.OoO_0O.
			AddHandler MyBase.Activated, AddressOf Me.ooooO_.OoO_0O.
			Me.o_O0.oOOo_00oO. = New Dictionary(Of String, String)()
			Dim num2 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_35:
				Dim num As Integer = 1
				Me.ooooO_.OoO_0O.()
				IL_3D:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_54:
				num = 3
				Dim c1FlexGrid As C1FlexGrid = Me.ooooO_.OoO_0O.()
				IL_5D:
				num = 4
				c1FlexGrid.Styles.SelectedColumnHeader.Clear()
				IL_6F:
				num = 5
				c1FlexGrid.Styles.Alternate.Clear()
				IL_81:
				num = 6
				c1FlexGrid.FocusRect = 0
				IL_8A:
				num = 7
				c1FlexGrid.AllowSorting = 0
				IL_93:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_9A:
				num = 9
				Me.o_O0.oOOo_00oO. = A_0
				IL_A4:
				num = 10
				Dim array As String() = New String(-1) {}
				IL_AF:
				num = 11
				If Operators.CompareString(A_0.O00.o_0OO__., "", True) <= 0 Then
					GoTo IL_E1
				End If
				IL_C6:
				num = 12
				array = A_0.O00.o_0OO__..Split(New Char() { "|"c })
				IL_E1:
				num = 13
				Dim text As String = ""
				IL_EB:
				num = 14
				Dim enumerator As IEnumerator(Of Col) = A_0.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_109:
					num = 15
					If Not Me.o_O0.oOOo_00oO..ContainsKey(col.Caption) Then
						IL_120:
						num = 16
						Me.o_O0.oOOo_00oO..Add(col.Caption, col.Name)
						IL_13C:
						num = 17
						Me.ooooO_.OoO_0O.().AddItem(col.Caption)
					Else
						IL_154:
						num = 19
						If Not Me.o_O0.oOOo_00oO..ContainsKey(col.Name) Then
							IL_16B:
							num = 20
							Me.o_O0.oOOo_00oO..Add(col.Name, col.Name)
							IL_187:
							num = 21
							Me.ooooO_.OoO_0O.().AddItem(col.Name)
						End If
					End If
					IL_19D:
					num = 22
					Dim num3 As Integer = Me.ooooO_.OoO_0O.().Rows.Count - 1
					IL_1B4:
					num = 23
					Me.ooooO_.OoO_0O.().SetCellCheck(num3, 0, 2)
					IL_1C6:
					num = 24
					Dim num4 As Integer = array.Length - 1
					For i As Integer = 0 To num4
						IL_1D9:
						num = 25
						If Operators.CompareString(array(i), col.Name, True) = 0 OrElse array(i).StartsWith(col.Name + " ", StringComparison.CurrentCultureIgnoreCase) Then
							IL_211:
							num = 26
							Me.ooooO_.OoO_0O.().SetCellCheck(num3, 0, 1)
							IL_223:
							num = 27
							If col.IsDate() Then
								IL_232:
								num = 28
								If array(i).EndsWith("Y", StringComparison.CurrentCultureIgnoreCase) Then
									IL_247:
									num = 29
									Me.ooooO_.OoO_0O.()(num3, 1) = True
								End If
								IL_25E:
								num = 30
								If array(i).EndsWith("YQ", StringComparison.CurrentCultureIgnoreCase) Then
									IL_273:
									num = 31
									Me.ooooO_.OoO_0O.()(num3, 2) = True
								End If
								IL_28A:
								num = 32
								If array(i).EndsWith("YM", StringComparison.CurrentCultureIgnoreCase) Then
									IL_29F:
									num = 33
									Me.ooooO_.OoO_0O.()(num3, 3) = True
								End If
								IL_2B6:
								num = 34
								If array(i).EndsWith("YW", StringComparison.CurrentCultureIgnoreCase) Then
									IL_2CB:
									num = 35
									Me.ooooO_.OoO_0O.()(num3, 4) = True
								End If
								IL_2E2:
								num = 36
								If array(i).EndsWith("YMD", StringComparison.CurrentCultureIgnoreCase) Then
									IL_2F7:
									num = 37
									Me.ooooO_.OoO_0O.()(num3, 5) = True
								End If
							End If
						End If
						IL_30E:
						num = 38
					Next
					IL_320:
					num = 39
				End While
				IL_32F:
				num = 40
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_33D:
				num = 41
				For Each text2 As String In array
					IL_353:
					num = 42
					Dim array3 As String() = text2.Split(New Char() { " "c })
					IL_36A:
					num = 43
					If A_0.Cols.Contains(array3(0)) Then
						IL_381:
						num = 44
						Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator = Me.o_O0.oOOo_00oO..Keys.GetEnumerator()
						While enumerator2.MoveNext()
							Dim text3 As String = enumerator2.Current
							IL_3A1:
							num = 45
							If Operators.CompareString(Me.o_O0.oOOo_00oO.(text3), array3(0), True) = 0 Then
								IL_3BD:
								num = 46
								text += text3
								Exit While
							End If
							IL_3CD:
							num = 48
						End While
						IL_3D9:
						num = 49
						CType(enumerator2, IDisposable).Dispose()
						IL_3E9:
						num = 50
						If array3.Length = 2 Then
							IL_3F3:
							num = 51
							text = text + " " + array3(1)
						End If
						IL_408:
						num = 52
						text += "|"
					End If
					IL_419:
					num = 53
				Next
				IL_42D:
				num = 54
				Me.ooooO_.OoO_0O.().Value = text.Trim(New Char() { "|"c })
				IL_44D:
				num = 55
				Me.ooooO_.OoO_0O.().Checked = Me.o_O0.oOOo_00oO..o0o0oOOo0__.o.
				IL_466:
				GoTo IL_598
				IL_46B:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_559:
				GoTo IL_58D
				IL_55B:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_56B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_55B
			End Try
			IL_58D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_598:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023B4 RID: 9140 RVA: 0x000F7440 File Offset: 0x000F5640
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim num As Integer
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.Col <> 0 Then
					GoTo IL_F3
				End If
				IL_14:
				num2 = 3
				Dim a_ As String = Me.o_O0.oOOo_00oO.(Me.ooooO_.OoO_0O.().Rows(A_1.Row)(0).ToString())
				IL_44:
				num2 = 4
				If Not Me.o_O0.oOOo_00oO..Cols(a_).IsDate() Then
					GoTo IL_F3
				End If
				IL_62:
				num2 = 5
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) <> 2 Then
					GoTo IL_A3
				End If
				IL_79:
				num2 = 6
				Dim num3 As Integer = 1
				Do
					IL_7E:
					num2 = 7
					Me.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, num3, 2)
					IL_94:
					num2 = 8
					num3 += 1
				Loop While num3 <= 5
				GoTo IL_F3
				IL_A3:
				num2 = 10
				Dim num4 As Integer = 1
				Dim flag As Boolean
				Do
					IL_A9:
					num2 = 11
					If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, num4) = 1 Then
						IL_C2:
						num2 = 12
						flag = True
					End If
					IL_C8:
					num2 = 13
					num4 += 1
				Loop While num4 <= 5
				IL_D6:
				num2 = 14
				If flag Then
					GoTo IL_F3
				End If
				IL_DD:
				num2 = 15
				Me.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, 3, 1)
				IL_F3:
				num2 = 16
				If A_1.Col < 1 OrElse A_1.Col > 5 Then
					GoTo IL_15D
				End If
				IL_108:
				num2 = 17
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, A_1.Col) <> 1 Then
					GoTo IL_15D
				End If
				IL_125:
				num2 = 18
				Dim num5 As Integer = 1
				Do
					IL_12B:
					num2 = 19
					If A_1.Col <> num5 Then
						IL_138:
						num2 = 20
						Me.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, num5, 2)
					End If
					IL_14F:
					num2 = 21
					num5 += 1
				Loop While num5 <= 5
				IL_15D:
				num2 = 22
				Dim text As String = Me.ooooO_.OoO_0O.().Rows(A_1.Row)(0).ToString()
				IL_182:
				num2 = 23
				Dim list As List(Of String) = New List(Of String)()
				IL_18C:
				num2 = 24
				Dim item As String = text
				IL_192:
				num2 = 25
				If Operators.CompareString(Me.ooooO_.OoO_0O.().Text, "", True) <= 0 Then
					GoTo IL_1D3
				End If
				IL_1AE:
				num2 = 26
				list.AddRange(Me.ooooO_.OoO_0O.().Text.Split(New Char() { "|"c }))
				IL_1D3:
				num2 = 27
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 1) <> 1 Then
					GoTo IL_200
				End If
				IL_1EB:
				num2 = 28
				item = text + " Y"
				GoTo IL_2A6
				IL_200:
				num2 = 30
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 2) <> 1 Then
					GoTo IL_22A
				End If
				IL_218:
				num2 = 31
				item = text + " YQ"
				GoTo IL_2A6
				IL_22A:
				num2 = 33
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 3) <> 1 Then
					GoTo IL_254
				End If
				IL_242:
				num2 = 34
				item = text + " YM"
				GoTo IL_2A6
				IL_254:
				num2 = 36
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 4) <> 1 Then
					GoTo IL_27E
				End If
				IL_26C:
				num2 = 37
				item = text + " YW"
				GoTo IL_2A6
				IL_27E:
				num2 = 39
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 5) <> 1 Then
					GoTo IL_2A6
				End If
				IL_296:
				num2 = 40
				item = text + " YMD"
				IL_2A6:
				num2 = 41
				If A_1.Col <> 0 Then
					GoTo IL_345
				End If
				IL_2B4:
				num2 = 42
				Dim enumerator As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim text2 As String = enumerator.Current
					IL_2CB:
					num2 = 43
					If Operators.CompareString(text2, text, True) = 0 OrElse text2.StartsWith(text + " ", StringComparison.CurrentCultureIgnoreCase) Then
						IL_2EE:
						num2 = 44
						list.Remove(text2)
						Exit While
					End If
					IL_2FD:
					num2 = 46
				End While
				IL_309:
				num2 = 47
				CType(enumerator, IDisposable).Dispose()
				IL_319:
				num2 = 48
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) <> 1 Then
					GoTo IL_3CB
				End If
				IL_334:
				num2 = 49
				list.Add(item)
				GoTo IL_3CB
				IL_345:
				num2 = 51
				If Me.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) <> 1 Then
					GoTo IL_3CB
				End If
				IL_35D:
				num2 = 52
				Dim num6 As Integer = list.Count - 1
				For i As Integer = 0 To num6
					IL_370:
					num2 = 53
					If Operators.CompareString(list(i), text, True) = 0 OrElse list(i).StartsWith(text + " ") Then
						IL_3A0:
						num2 = 54
						list.RemoveAt(i)
						IL_3AC:
						num2 = 55
						list.Insert(i, item)
						Exit For
					End If
					IL_3BC:
					num2 = 57
				Next
				IL_3CB:
				num2 = 58
				Me.ooooO_.OoO_0O.().Value = String.Join("|", list.ToArray())
				IL_3EA:
				GoTo IL_528
				IL_3EF:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_4E9:
				GoTo IL_51D
				IL_4EB:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4FB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4EB
			End Try
			IL_51D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_528:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023B5 RID: 9141 RVA: 0x000F799C File Offset: 0x000F5B9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col > 0 Then
				Dim a_ As String = Me.o_O0.oOOo_00oO.(Me.ooooO_.OoO_0O.().Rows(A_1.Row)(0).ToString())
				A_1.Cancel = Not Me.o_O0.oOOo_00oO..Cols(a_).IsDate()
			End If
		End Sub

		' Token: 0x060023B6 RID: 9142 RVA: 0x000F79FE File Offset: 0x000F5BFE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060023B7 RID: 9143 RVA: 0x000F7A08 File Offset: 0x000F5C08
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.ooooO_.OoO_0O.().Text.Trim(), "", True) <> 0 Then
					GoTo IL_4A
				End If
				IL_26:
				num2 = 3
				Me.o_O0.oOOo_00oO..O00.o_0OO__. = ""
				IL_38:
				num2 = 4
				Me.o_O0.oOOo_00oO..CloseFilterTree()
				GoTo IL_1BD
				IL_4A:
				num2 = 6
				Dim array As String() = Me.ooooO_.OoO_0O.().Text.Trim().Split(New Char() { "|"c })
				IL_6D:
				num2 = 7
				Dim list As List(Of String) = New List(Of String)()
				IL_76:
				num2 = 8
				For Each text As String In array
					IL_8A:
					num2 = 9
					If Not Me.o_O0.oOOo_00oO..ContainsKey(text) Then
						IL_9C:
						num2 = 10
						Dim array3 As String() = text.Split(New Char() { " "c })
						IL_B3:
						num2 = 11
						text = Me.o_O0.oOOo_00oO.(array3(0))
						IL_C7:
						num2 = 12
						If array3.Length = 2 Then
							IL_D1:
							num2 = 13
							text = text + " " + array3(1)
						End If
						IL_E6:
						num2 = 14
						list.Add(text)
					Else
						IL_F4:
						num2 = 16
						list.Add(Me.o_O0.oOOo_00oO.(text))
					End If
					IL_10B:
					num2 = 17
				Next
				IL_11F:
				num2 = 18
				If list.Count <> 0 Then
					GoTo IL_140
				End If
				IL_12B:
				num2 = 19
				Me.o_O0.oOOo_00oO..O00.o_0OO__. = ""
				GoTo IL_15F
				IL_140:
				num2 = 21
				Me.o_O0.oOOo_00oO..O00.o_0OO__. = String.Join("|", list.ToArray())
				IL_15F:
				num2 = 22
				If Operators.CompareString(Me.o_O0.oOOo_00oO..O00.o_0OO__., "", True) <> 0 Then
					GoTo IL_18A
				End If
				IL_17A:
				num2 = 23
				Me.o_O0.oOOo_00oO..CloseFilterTree()
				GoTo IL_1BD
				IL_18A:
				num2 = 25
				Me.o_O0.oOOo_00oO..OpenFilterTree(Me.o_O0.oOOo_00oO..O00.o_0OO__., 0)
				IL_1A4:
				num2 = 26
				Me.o_O0.oOOo_00oO..o0o0oOOo0__.o. = Me.ooooO_.OoO_0O.().Checked
				IL_1BD:
				num2 = 27
				MyBase.Close()
				IL_1C6:
				num2 = 28
				Application.DoEvents()
				IL_1CE:
				num2 = 29
				Me.o_O0.oOOo_00oO..NeedSaveSetting = True
				IL_1DD:
				num2 = 30
				Me.o_O0.oOOo_00oO..oo0OO0Ooo._.(True)
				IL_1EC:
				num2 = 31
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				IL_209:
				GoTo IL_2DB
				IL_20E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_29C:
				GoTo IL_2D0
				IL_29E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2AE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_29E
			End Try
			IL_2D0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2DB:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023B8 RID: 9144 RVA: 0x000F7D14 File Offset: 0x000F5F14
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x060023B9 RID: 9145 RVA: 0x000F7D28 File Offset: 0x000F5F28
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.ooooO_.OoO_0O.()
			If c1FlexGrid.BottomRow < c1FlexGrid.Rows.Count - 1 Then
				c1FlexGrid.Cols(0).Width = c1FlexGrid.Cols(0).Width - SystemInformation.VerticalScrollBarWidth
			End If
		End Sub

		' Token: 0x04000EBC RID: 3772
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000EBD RID: 3773
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000EBE RID: 3774
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000EBF RID: 3775
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EC0 RID: 3776
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EC1 RID: 3777
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000EC2 RID: 3778
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000EC3 RID: 3779
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000EC4 RID: 3780
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
