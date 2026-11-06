Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002A3 RID: 675
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class ky
		Inherits Form

		' Token: 0x060023BA RID: 9146 RVA: 0x000F7D7C File Offset: 0x000F5F7C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0_00000.oO0. IsNot Nothing Then
					Me.O0_00000.oO0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060023BB RID: 9147 RVA: 0x000F7DBC File Offset: 0x000F5FBC
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(ky))
			Me.OO._0O0Oo00.(New C1FlexGrid())
			Me.oO.__O0_o__oO.(New C1Button())
			Me.o___.0.(New C1Button())
			Me.ooo.O__.(New Label())
			Me.OO._0O0Oo00.(New C1TextBox())
			Me.OO._0O0Oo00.(New Label())
			Me.OO._0O0Oo00.(New C1NumericEdit())
			Me.OO._0O0Oo00.(New C1CheckBox())
			Me.ooO.00oO_0_o0O.(New C1CheckBox())
			Me.ooO.00oO_0_o0O.(New Label())
			Me.OO._0O0Oo00.(New ComboBox())
			Me.o0_o0_OOO.O.().BeginInit()
			Me.o_.O0__O.().BeginInit()
			Me.o0_o0_OOO.O.().BeginInit()
			Me.oO.__O0_o__oO.().BeginInit()
			Me.oO.__O0_o__oO.().BeginInit()
			Me.o_.O0__O.().BeginInit()
			Me.oO.__O0_o__oO.().BeginInit()
			MyBase.SuspendLayout()
			Me.o0_o0_OOO.O.().AllowSorting = 0
			Me.o0_o0_OOO.O.().BorderStyle = 1
			Me.o0_o0_OOO.O.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.o0_o0_OOO.O.().ExtendLastCol = True
			Me.o0_o0_OOO.O.().FocusRect = 0
			Me.o0_o0_OOO.O.().Font = New Font("宋体", 9F)
			Me.o0_o0_OOO.O.().Location = New Point(12, 73)
			Me.o0_o0_OOO.O.().Name = "C1FlexGrid1"
			Me.o0_o0_OOO.O.().Rows.Count = 1
			Me.o0_o0_OOO.O.().Rows.DefaultSize = 21
			Me.o0_o0_OOO.O.().SelectionMode = 3
			Me.o0_o0_OOO.O.().Size = New Size(494, 290)
			Me.o0_o0_OOO.O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.o0_o0_OOO.O.().TabIndex = 1
			Me.o_.O0__O.().Location = New Point(181, 447)
			Me.o_.O0__O.().Name = "Button1"
			Me.o_.O0__O.().Size = New Size(75, 23)
			Me.o_.O0__O.().TabIndex = 2
			Me.o_.O0__O.().Text = "确定"
			Me.o_.O0__O.().UseVisualStyleBackColor = True
			Me.o0_o0_OOO.O.().Location = New Point(262, 447)
			Me.o0_o0_OOO.O.().Name = "Button2"
			Me.o0_o0_OOO.O.().Size = New Size(75, 23)
			Me.o0_o0_OOO.O.().TabIndex = 3
			Me.o0_o0_OOO.O.().Text = "取消"
			Me.o0_o0_OOO.O.().UseVisualStyleBackColor = True
			Me.oO.__O0_o__oO.().AutoSize = True
			Me.oO.__O0_o__oO.().Location = New Point(12, 12)
			Me.oO.__O0_o__oO.().Name = "Label1"
			Me.oO.__O0_o__oO.().Size = New Size(155, 12)
			Me.oO.__O0_o__oO.().TabIndex = 8
			Me.oO.__O0_o__oO.().Text = "请选择用于生成加载树的列:"
			Me.oO.__O0_o__oO.().Location = New Point(12, 33)
			Me.oO.__O0_o__oO.().Name = "TextBox1"
			Me.oO.__O0_o__oO.().[ReadOnly] = True
			Me.oO.__O0_o__oO.().Size = New Size(494, 19)
			Me.oO.__O0_o__oO.().TabIndex = 7
			Me.oO.__O0_o__oO.().Tag = Nothing
			Me.o___.0.().AutoSize = True
			Me.o___.0.().Location = New Point(12, 378)
			Me.o___.0.().Name = "Label2"
			Me.o___.0.().Size = New Size(83, 12)
			Me.o___.0.().TabIndex = 9
			Me.o___.0.().Text = "每页加载行数:"
			Me.oO.__O0_o__oO.().ImagePadding = New Padding(0)
			Me.oO.__O0_o__oO.().Location = New Point(101, 376)
			Me.oO.__O0_o__oO.().Name = "NumericUpDown1"
			Me.oO.__O0_o__oO.().Size = New Size(84, 19)
			Me.oO.__O0_o__oO.().TabIndex = 10
			Me.oO.__O0_o__oO.().Tag = Nothing
			Dim c1TextBox As C1TextBox = Me.oO.__O0_o__oO.()
			Dim array As Integer() = New Integer(3) {}
			array(0) = 10000
			c1TextBox.Value = New Decimal(array)
			Me.oO.__O0_o__oO.().VisibleButtons = 1
			Me.o_.O0__O.().AutoSize = True
			Me.o_.O0__O.().BorderStyle = BorderStyle.None
			Me.o_.O0__O.().Location = New Point(384, 408)
			Me.o_.O0__O.().Name = "chkAutoOpen"
			Me.o_.O0__O.().Size = New Size(108, 16)
			Me.o_.O0__O.().TabIndex = 11
			Me.o_.O0__O.().Text = "自动显示加载树"
			Me.o_.O0__O.().UseVisualStyleBackColor = True
			Me.o_.O0__O.().Value = Nothing
			Me.oO.__O0_o__oO.().AutoSize = True
			Me.oO.__O0_o__oO.().BorderStyle = BorderStyle.None
			Me.oO.__O0_o__oO.().Location = New Point(384, 377)
			Me.oO.__O0_o__oO.().Name = "LoadReverse"
			Me.oO.__O0_o__oO.().Size = New Size(72, 16)
			Me.oO.__O0_o__oO.().TabIndex = 12
			Me.oO.__O0_o__oO.().Text = "降序加载"
			Me.oO.__O0_o__oO.().UseVisualStyleBackColor = True
			Me.oO.__O0_o__oO.().Value = Nothing
			Me.O._o0O0oO_000o.().AutoSize = True
			Me.O._o0O0oO_000o.().Location = New Point(12, 410)
			Me.O._o0O0oO_000o.().Name = "Label3"
			Me.O._o0O0oO_000o.().Size = New Size(83, 12)
			Me.O._o0O0oO_000o.().TabIndex = 13
			Me.O._o0O0oO_000o.().Text = "分页加载依据:"
			Me.oO.__O0_o__oO.().DropDownStyle = ComboBoxStyle.DropDownList
			Me.oO.__O0_o__oO.().FormattingEnabled = True
			Me.oO.__O0_o__oO.().Location = New Point(101, 407)
			Me.oO.__O0_o__oO.().Name = "cmbPageOver"
			Me.oO.__O0_o__oO.().Size = New Size(196, 20)
			Me.oO.__O0_o__oO.().TabIndex = 14
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(518, 484)
			MyBase.Controls.Add(Me.oO.__O0_o__oO.())
			MyBase.Controls.Add(Me.O._o0O0oO_000o.())
			MyBase.Controls.Add(Me.oO.__O0_o__oO.())
			MyBase.Controls.Add(Me.o_.O0__O.())
			MyBase.Controls.Add(Me.oO.__O0_o__oO.())
			MyBase.Controls.Add(Me.o___.0.())
			MyBase.Controls.Add(Me.oO.__O0_o__oO.())
			MyBase.Controls.Add(Me.oO.__O0_o__oO.())
			MyBase.Controls.Add(Me.o0_o0_OOO.O.())
			MyBase.Controls.Add(Me.o_.O0__O.())
			MyBase.Controls.Add(Me.o0_o0_OOO.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO.....00"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "加载树"
			Me.o0_o0_OOO.O.().EndInit()
			Me.o_.O0__O.().EndInit()
			Me.o0_o0_OOO.O.().EndInit()
			Me.oO.__O0_o__oO.().EndInit()
			Me.oO.__O0_o__oO.().EndInit()
			Me.o_.O0__O.().EndInit()
			Me.oO.__O0_o__oO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x060023BC RID: 9148 RVA: 0x000F8576 File Offset: 0x000F6776
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023BD RID: 9149 RVA: 0x000F8580 File Offset: 0x000F6780
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o_.O0__O.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.o0_o0_OOO.O.
			Dim oo0oo_O0o_.oo. As C1FlexGrid = Me.Oo0oo_O0o_.oo.
			If oo0oo_O0o_.oo. IsNot Nothing Then
				oo0oo_O0o_.oo..AfterEdit -= rowColEventHandler
				oo0oo_O0o_.oo..BeforeEdit -= rowColEventHandler2
			End If
			Me.Oo0oo_O0o_.oo. = A_0
			oo0oo_O0o_.oo. = Me.Oo0oo_O0o_.oo.
			If oo0oo_O0o_.oo. IsNot Nothing Then
				oo0oo_O0o_.oo..AfterEdit += rowColEventHandler
				oo0oo_O0o_.oo..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x060023BE RID: 9150 RVA: 0x000F85DE File Offset: 0x000F67DE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OO._0O0Oo00.
		End Function

		' Token: 0x060023BF RID: 9151 RVA: 0x000F85E8 File Offset: 0x000F67E8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOO000o._00.
			Dim oo._0O0Oo00. As C1Button = Me.OO._0O0Oo00.
			If oo._0O0Oo00. IsNot Nothing Then
				RemoveHandler oo._0O0Oo00..Click, value
			End If
			Me.OO._0O0Oo00. = A_0
			oo._0O0Oo00. = Me.OO._0O0Oo00.
			If oo._0O0Oo00. IsNot Nothing Then
				AddHandler oo._0O0Oo00..Click, value
			End If
		End Sub

		' Token: 0x060023C0 RID: 9152 RVA: 0x000F862B File Offset: 0x000F682B
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OOoO0O_oO.
		End Function

		' Token: 0x060023C1 RID: 9153 RVA: 0x000F8634 File Offset: 0x000F6834
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OOO.0o_oo_00_.
			Dim o.OOoO0O_oO. As C1Button = Me.O.OOoO0O_oO.
			If o.OOoO0O_oO. IsNot Nothing Then
				RemoveHandler o.OOoO0O_oO..Click, value
			End If
			Me.O.OOoO0O_oO. = A_0
			o.OOoO0O_oO. = Me.O.OOoO0O_oO.
			If o.OOoO0O_oO. IsNot Nothing Then
				AddHandler o.OOoO0O_oO..Click, value
			End If
		End Sub

		' Token: 0x060023C2 RID: 9154 RVA: 0x000F8677 File Offset: 0x000F6877
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023C3 RID: 9155 RVA: 0x000F867F File Offset: 0x000F687F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo0oo_O0o_.oo. = A_0
		End Sub

		' Token: 0x060023C4 RID: 9156 RVA: 0x000F8688 File Offset: 0x000F6888
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023C5 RID: 9157 RVA: 0x000F8690 File Offset: 0x000F6890
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Oo0oo_O0o_.oo. = A_0
		End Sub

		' Token: 0x060023C6 RID: 9158 RVA: 0x000F8699 File Offset: 0x000F6899
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.OOoO0O_oO.
		End Function

		' Token: 0x060023C7 RID: 9159 RVA: 0x000F86A1 File Offset: 0x000F68A1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.OOoO0O_oO. = A_0
		End Sub

		' Token: 0x060023C8 RID: 9160 RVA: 0x000F86AA File Offset: 0x000F68AA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1NumericEdit
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023C9 RID: 9161 RVA: 0x000F86B2 File Offset: 0x000F68B2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1NumericEdit)
			Me.Oo0oo_O0o_.oo. = A_0
		End Sub

		' Token: 0x060023CA RID: 9162 RVA: 0x000F86BB File Offset: 0x000F68BB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023CB RID: 9163 RVA: 0x000F86C3 File Offset: 0x000F68C3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Oo0oo_O0o_.oo. = A_0
		End Sub

		' Token: 0x060023CC RID: 9164 RVA: 0x000F86CC File Offset: 0x000F68CC
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O.OOoO0O_oO.
		End Function

		' Token: 0x060023CD RID: 9165 RVA: 0x000F86D4 File Offset: 0x000F68D4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O.OOoO0O_oO. = A_0
		End Sub

		' Token: 0x060023CE RID: 9166 RVA: 0x000F86DD File Offset: 0x000F68DD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOOo0O.0_00.
		End Function

		' Token: 0x060023CF RID: 9167 RVA: 0x000F86E5 File Offset: 0x000F68E5
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOOo0O.0_00. = A_0
		End Sub

		' Token: 0x060023D0 RID: 9168 RVA: 0x000F86EE File Offset: 0x000F68EE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ComboBox
			Return Me.Oo0oo_O0o_.oo.
		End Function

		' Token: 0x060023D1 RID: 9169 RVA: 0x000F86F6 File Offset: 0x000F68F6
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ComboBox)
			Me.Oo0oo_O0o_.oo. = A_0
		End Sub

		' Token: 0x060023D2 RID: 9170 RVA: 0x000F8700 File Offset: 0x000F6900
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.o_.O0__O.
			AddHandler MyBase.FormClosed, AddressOf Me.o0_o0_OOO.O.
			AddHandler MyBase.Activated, AddressOf Me.o0_o0_OOO.O.
			Me.O0_00000.oO0. = New Dictionary(Of String, String)()
			Dim num2 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_47:
				Dim num As Integer = 1
				Me.oO.__O0_o__oO.()
				IL_4F:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_66:
				num = 3
				Dim c1FlexGrid As C1FlexGrid = Me.o0_o0_OOO.O.()
				IL_6F:
				num = 4
				c1FlexGrid.Styles.SelectedColumnHeader.Clear()
				IL_81:
				num = 5
				c1FlexGrid.Styles.Alternate.Clear()
				IL_93:
				num = 6
				c1FlexGrid.FocusRect = 0
				IL_9C:
				num = 7
				c1FlexGrid.AllowSorting = 0
				IL_A5:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_AC:
				num = 9
				Me.O0_00000.oO0. = A_0
				IL_B6:
				num = 10
				Dim array As String() = New String(-1) {}
				IL_C1:
				num = 11
				If Operators.CompareString(A_0.o.Ooo__., "", True) <= 0 Then
					GoTo IL_F3
				End If
				IL_D8:
				num = 12
				array = A_0.o.Ooo__..Split(New Char() { "|"c })
				IL_F3:
				num = 13
				Dim text As String = ""
				IL_FD:
				num = 14
				Dim enumerator As IEnumerator(Of Col) = A_0.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_11B:
					num = 15
					If Not col.DataCol.IsTemporary Then
						IL_12F:
						num = 17
						If Not Me.O0_00000.oO0..ContainsKey(col.Caption) Then
							IL_146:
							num = 18
							Me.O0_00000.oO0..Add(col.Caption, col.Name)
							IL_162:
							num = 19
							Me.o0_o0_OOO.O.().AddItem(col.Caption)
						Else
							IL_17A:
							num = 21
							If Not Me.O0_00000.oO0..ContainsKey(col.Name) Then
								IL_191:
								num = 22
								Me.O0_00000.oO0..Add(col.Name, col.Name)
								IL_1AD:
								num = 23
								Me.o0_o0_OOO.O.().AddItem(col.Name)
							End If
						End If
						IL_1C3:
						num = 24
						Dim num3 As Integer = Me.o0_o0_OOO.O.().Rows.Count - 1
						IL_1DA:
						num = 25
						Me.o0_o0_OOO.O.().SetCellCheck(num3, 0, 2)
						IL_1EC:
						num = 26
						Dim num4 As Integer = array.Length - 1
						For i As Integer = 0 To num4
							IL_1FF:
							num = 27
							If Operators.CompareString(array(i), col.Name, True) = 0 OrElse array(i).StartsWith(col.Name + " ", StringComparison.CurrentCultureIgnoreCase) Then
								IL_237:
								num = 28
								Me.o0_o0_OOO.O.().SetCellCheck(num3, 0, 1)
								IL_249:
								num = 29
								If col.IsDate() Then
									IL_258:
									num = 30
									If array(i).EndsWith("Y", StringComparison.CurrentCultureIgnoreCase) Then
										IL_26D:
										num = 31
										Me.o0_o0_OOO.O.()(num3, 1) = True
									End If
									IL_284:
									num = 32
									If array(i).EndsWith("YQ", StringComparison.CurrentCultureIgnoreCase) Then
										IL_299:
										num = 33
										Me.o0_o0_OOO.O.()(num3, 2) = True
									End If
									IL_2B0:
									num = 34
									If array(i).EndsWith("YM", StringComparison.CurrentCultureIgnoreCase) Then
										IL_2C5:
										num = 35
										Me.o0_o0_OOO.O.()(num3, 3) = True
									End If
									IL_2DC:
									num = 36
									If array(i).EndsWith("YW", StringComparison.CurrentCultureIgnoreCase) Then
										IL_2F1:
										num = 37
										Me.o0_o0_OOO.O.()(num3, 4) = True
									End If
									IL_308:
									num = 38
									If array(i).EndsWith("YMD", StringComparison.CurrentCultureIgnoreCase) Then
										IL_31D:
										num = 39
										Me.o0_o0_OOO.O.()(num3, 5) = True
									End If
								End If
							End If
							IL_334:
							num = 40
						Next
					End If
					IL_346:
					num = 41
				End While
				IL_355:
				num = 42
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_363:
				num = 43
				For Each text2 As String In array
					IL_379:
					num = 44
					Dim array3 As String() = text2.Split(New Char() { " "c })
					IL_390:
					num = 45
					If A_0.Cols.Contains(array3(0)) Then
						IL_3A7:
						num = 46
						If Not A_0.Cols(array3(0)).DataCol.IsTemporary Then
							IL_3C8:
							num = 48
							Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator = Me.O0_00000.oO0..Keys.GetEnumerator()
							While enumerator2.MoveNext()
								Dim text3 As String = enumerator2.Current
								IL_3E8:
								num = 49
								If Operators.CompareString(Me.O0_00000.oO0.(text3), array3(0), True) = 0 Then
									IL_404:
									num = 50
									text += text3
									Exit While
								End If
								IL_414:
								num = 52
							End While
							IL_420:
							num = 53
							CType(enumerator2, IDisposable).Dispose()
							IL_430:
							num = 54
							If array3.Length = 2 Then
								IL_43A:
								num = 55
								text = text + " " + array3(1)
							End If
							IL_44F:
							num = 56
							text += "|"
						End If
					End If
					IL_460:
					num = 57
				Next
				IL_474:
				num = 58
				Me.oO.__O0_o__oO.().Value = text.Trim(New Char() { "|"c })
				IL_494:
				num = 59
				Me.oO.__O0_o__oO.().Value = Me.O0_00000.oO0..o.0__o0.
				IL_4B2:
				num = 60
				Me.o_.O0__O.().Checked = Me.O0_00000.oO0..oo.o_ooO.
				IL_4CB:
				num = 61
				Me.oO.__O0_o__oO.().Checked = Me.O0_00000.oO0..o00Oo.O0O.
				IL_4E4:
				GoTo IL_62E
				IL_4E9:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_5EF:
				GoTo IL_623
				IL_5F1:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_601:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5F1
			End Try
			IL_623:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_62E:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023D3 RID: 9171 RVA: 0x000F8D60 File Offset: 0x000F6F60
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
				Dim a_ As String = Me.O0_00000.oO0.(Me.o0_o0_OOO.O.().Rows(A_1.Row)(0).ToString())
				IL_44:
				num2 = 4
				If Not Me.O0_00000.oO0..Cols(a_).IsDate() Then
					GoTo IL_F3
				End If
				IL_62:
				num2 = 5
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) <> 2 Then
					GoTo IL_A3
				End If
				IL_79:
				num2 = 6
				Dim num3 As Integer = 1
				Do
					IL_7E:
					num2 = 7
					Me.o0_o0_OOO.O.().SetCellCheck(A_1.Row, num3, 2)
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
					If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, num4) = 1 Then
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
				Me.o0_o0_OOO.O.().SetCellCheck(A_1.Row, 3, 1)
				IL_F3:
				num2 = 16
				If A_1.Col < 1 OrElse A_1.Col > 5 Then
					GoTo IL_15D
				End If
				IL_108:
				num2 = 17
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, A_1.Col) <> 1 Then
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
						Me.o0_o0_OOO.O.().SetCellCheck(A_1.Row, num5, 2)
					End If
					IL_14F:
					num2 = 21
					num5 += 1
				Loop While num5 <= 5
				IL_15D:
				num2 = 22
				Dim text As String = Me.o0_o0_OOO.O.().Rows(A_1.Row)(0).ToString()
				IL_182:
				num2 = 23
				Dim list As List(Of String) = New List(Of String)()
				IL_18C:
				num2 = 24
				Dim item As String = text
				IL_192:
				num2 = 25
				If Operators.CompareString(Me.oO.__O0_o__oO.().Text, "", True) <= 0 Then
					GoTo IL_1D3
				End If
				IL_1AE:
				num2 = 26
				list.AddRange(Me.oO.__O0_o__oO.().Text.Split(New Char() { "|"c }))
				IL_1D3:
				num2 = 27
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 1) <> 1 Then
					GoTo IL_200
				End If
				IL_1EB:
				num2 = 28
				item = text + " Y"
				GoTo IL_2A6
				IL_200:
				num2 = 30
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 2) <> 1 Then
					GoTo IL_22A
				End If
				IL_218:
				num2 = 31
				item = text + " YQ"
				GoTo IL_2A6
				IL_22A:
				num2 = 33
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 3) <> 1 Then
					GoTo IL_254
				End If
				IL_242:
				num2 = 34
				item = text + " YM"
				GoTo IL_2A6
				IL_254:
				num2 = 36
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 4) <> 1 Then
					GoTo IL_27E
				End If
				IL_26C:
				num2 = 37
				item = text + " YW"
				GoTo IL_2A6
				IL_27E:
				num2 = 39
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 5) <> 1 Then
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
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) <> 1 Then
					GoTo IL_3CB
				End If
				IL_334:
				num2 = 49
				list.Add(item)
				GoTo IL_3CB
				IL_345:
				num2 = 51
				If Me.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) <> 1 Then
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
				Me.oO.__O0_o__oO.().Value = String.Join("|", list.ToArray())
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

		' Token: 0x060023D4 RID: 9172 RVA: 0x000F92BC File Offset: 0x000F74BC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Col > 0 Then
				Dim a_ As String = Me.O0_00000.oO0.(Me.o0_o0_OOO.O.().Rows(A_1.Row)(0).ToString())
				A_1.Cancel = Not Me.O0_00000.oO0..Cols(a_).IsDate()
			End If
		End Sub

		' Token: 0x060023D5 RID: 9173 RVA: 0x000F931E File Offset: 0x000F751E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060023D6 RID: 9174 RVA: 0x000F9328 File Offset: 0x000F7528
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
				If Operators.CompareString(Me.oO.__O0_o__oO.().Text.Trim(), "", True) <> 0 Then
					GoTo IL_4A
				End If
				IL_26:
				num2 = 3
				Me.O0_00000.oO0..o.Ooo__. = ""
				IL_38:
				num2 = 4
				Me.O0_00000.oO0..CloseLoadTree()
				GoTo IL_239
				IL_4A:
				num2 = 6
				Dim array As String() = Me.oO.__O0_o__oO.().Text.Trim().Split(New Char() { "|"c })
				IL_6D:
				num2 = 7
				Dim list As List(Of String) = New List(Of String)()
				IL_76:
				num2 = 8
				For Each text As String In array
					IL_8A:
					num2 = 9
					If Me.O0_00000.oO0..ContainsKey(text) Then
						IL_9C:
						num2 = 10
						list.Add(Me.O0_00000.oO0.(text))
					Else
						IL_B5:
						num2 = 12
						Dim array3 As String() = text.Split(New Char() { " "c })
						IL_CC:
						num2 = 13
						text = Me.O0_00000.oO0.(array3(0))
						IL_E0:
						num2 = 14
						If array3.Length = 2 Then
							IL_EA:
							num2 = 15
							text = text + " " + array3(1)
						End If
						IL_FF:
						num2 = 16
						list.Add(text)
					End If
					IL_10B:
					num2 = 17
				Next
				IL_11F:
				num2 = 18
				Me.O0_00000.oO0..o.0__o0. = Conversions.ToInteger(Me.oO.__O0_o__oO.().Value)
				IL_13D:
				num2 = 19
				If list.Count <> 0 Then
					GoTo IL_15E
				End If
				IL_149:
				num2 = 20
				Me.O0_00000.oO0..o.Ooo__. = ""
				GoTo IL_17D
				IL_15E:
				num2 = 22
				Me.O0_00000.oO0..o.Ooo__. = String.Join("|", list.ToArray())
				IL_17D:
				num2 = 23
				If Me.oO.__O0_o__oO.().SelectedIndex <> 0 Then
					GoTo IL_1A2
				End If
				IL_18D:
				num2 = 24
				Me.O0_00000.oO0..O0__O_.O. = ""
				GoTo IL_1BB
				IL_1A2:
				num2 = 26
				Me.O0_00000.oO0..O0__O_.O. = Me.oO.__O0_o__oO.().Text
				IL_1BB:
				num2 = 27
				Me.O0_00000.oO0..o00Oo.O0O. = Me.oO.__O0_o__oO.().Checked
				IL_1D4:
				num2 = 28
				If Operators.CompareString(Me.O0_00000.oO0..o.Ooo__., "", True) <> 0 Then
					GoTo IL_1FF
				End If
				IL_1EF:
				num2 = 29
				Me.O0_00000.oO0..CloseLoadTree()
				GoTo IL_239
				IL_1FF:
				num2 = 31
				Me.O0_00000.oO0..OpenLoadTree(Me.O0_00000.oO0..o.Ooo__., 0, 0, False, "-")
				IL_220:
				num2 = 32
				Me.O0_00000.oO0..oo.o_ooO. = Me.o_.O0__O.().Checked
				IL_239:
				num2 = 33
				MyBase.Close()
				IL_242:
				num2 = 34
				Application.DoEvents()
				IL_24A:
				num2 = 35
				Me.O0_00000.oO0..NeedSaveSetting = True
				IL_259:
				num2 = 36
				Me.O0_00000.oO0..oo0OO0Ooo._.(True)
				IL_268:
				num2 = 37
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()), True)
				IL_285:
				GoTo IL_36F
				IL_28A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_330:
				GoTo IL_364
				IL_332:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_342:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_332
			End Try
			IL_364:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_36F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023D7 RID: 9175 RVA: 0x000F96C8 File Offset: 0x000F78C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim oleDbConnection As OleDbConnection = Me.O0_00000.oO0..DataTable.frd_Connection
				IL_1A:
				num2 = 3
				Dim dataTable As DataTable = New DataTable()
				IL_23:
				num2 = 4
				If Operators.CompareString(Me.O0_00000.oO0..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_5E
				End If
				IL_43:
				num2 = 5
				Dim str As String = Oo00.o_0o0O.0_O.(Me.O0_00000.oO0..DataTable.HttpSelect)
				GoTo IL_77
				IL_5E:
				num2 = 7
				str = Oo00.o_0o0O.0_O.(Me.O0_00000.oO0..DataTable.frd_SelectCommandString)
				IL_77:
				num2 = 8
				Dim text As String = If(("Select * from " + str), "")
				IL_90:
				num2 = 9
				text = Oo00.o0_o._O_.(oleDbConnection, text, False)
				IL_9E:
				num2 = 10
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, oleDbConnection)
				IL_AB:
				num2 = 11
				If Operators.CompareString(Me.O0_00000.oO0..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_129
				End If
				IL_CC:
				num2 = 12
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.O0_00000.oO0..DataTable.ConnectionName).oO0_0.o.()
				IL_F0:
				num2 = 13
				httpClient.[Select] = text
				IL_FC:
				num2 = 14
				Dim dictionary As Dictionary(Of String, String) = httpClient.FormData
				Dim key As String = "Action"
				Dim num3 As Integer = 12
				dictionary(key) = num3.ToString()
				IL_11B:
				num2 = 15
				dataTable = httpClient.GetBaseDataTable()
				GoTo IL_137
				IL_129:
				num2 = 17
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_137:
				num2 = 18
				Me.oO.__O0_o__oO.().Items.Add("默认")
				IL_150:
				num2 = 19
				Me.oO.__O0_o__oO.().SelectedIndex = 0
				IL_15F:
				num2 = 20
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
					GoTo IL_1E3
				End If
				IL_16A:
				num2 = 21
				oleDbDataAdapter.Fill(dataTable)
				IL_177:
				num2 = 22
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_198:
					num2 = 23
					Me.oO.__O0_o__oO.().Items.Add(dataRow("COLUMN_NAME").ToString())
					IL_1BD:
					num2 = 24
				End While
				IL_1C9:
				num2 = 25
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_243
				End If
				GoTo IL_243
				IL_1E3:
				num2 = 27
				Dim enumerator2 As IEnumerator = dataTable.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataColumn As DataColumn = CType(obj2, DataColumn)
					IL_204:
					num2 = 28
					Me.oO.__O0_o__oO.().Items.Add(dataColumn.ColumnName)
					IL_21F:
					num2 = 29
				End While
				IL_22B:
				num2 = 30
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_243:
				num2 = 31
				If Operators.CompareString(Me.O0_00000.oO0..O0__O_.O., "", True) <= 0 Then
					GoTo IL_2C9
				End If
				IL_25F:
				num2 = 32
				num3 = Me.oO.__O0_o__oO.().Items.Count - 1
				For i As Integer = 1 To num3
					IL_27B:
					num2 = 33
					If Operators.CompareString(Me.oO.__O0_o__oO.().Items(i).ToString(), Me.O0_00000.oO0..O0__O_.O., True) = 0 Then
						IL_2A8:
						num2 = 34
						Me.oO.__O0_o__oO.().SelectedIndex = i
						Exit For
					End If
					IL_2BA:
					num2 = 36
				Next
				IL_2C9:
				GoTo IL_3AF
				IL_2CE:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_370:
				GoTo IL_3A4
				IL_372:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_382:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_372
			End Try
			IL_3A4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3AF:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060023D8 RID: 9176 RVA: 0x000F9AA8 File Offset: 0x000F7CA8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x060023D9 RID: 9177 RVA: 0x000F9ABC File Offset: 0x000F7CBC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.o0_o0_OOO.O.()
			If c1FlexGrid.BottomRow < c1FlexGrid.Rows.Count - 1 Then
				c1FlexGrid.Cols(0).Width = c1FlexGrid.Cols(0).Width - SystemInformation.VerticalScrollBarWidth
			End If
		End Sub

		' Token: 0x04000EC5 RID: 3781
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000EC6 RID: 3782
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04000EC7 RID: 3783
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EC8 RID: 3784
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000EC9 RID: 3785
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000ECA RID: 3786
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04000ECB RID: 3787
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000ECC RID: 3788
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1NumericEdit

		' Token: 0x04000ECD RID: 3789
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000ECE RID: 3790
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000ECF RID: 3791
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000ED0 RID: 3792
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ComboBox

		' Token: 0x04000ED1 RID: 3793
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04000ED2 RID: 3794
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
