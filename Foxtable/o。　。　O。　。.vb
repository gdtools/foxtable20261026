Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020000C6 RID: 198
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000
		Inherits Form

		' Token: 0x06000888 RID: 2184 RVA: 0x0003AD34 File Offset: 0x00038F34
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O00_.__0OO. IsNot Nothing Then
					Me.O00_.__0OO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000889 RID: 2185 RVA: 0x0003AD74 File Offset: 0x00038F74
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_O.O_oOo_.(New C1FlexGrid())
			Me.O_.oo0o.(New C1ComboBox())
			Me.o_O.O_oOo_.(New C1ComboBox())
			Me.O_.oo0o.(New Label())
			Me.oO.O_o__O0O.(New Label())
			Me.O_.oo0o.(New C1FlexGrid())
			Me.o__0oo._0o.(New Label())
			Me.O00O0O.Oo__oOO.(New Label())
			Me.O0O.0oo00__o0O.(New Label())
			Me.oo.o_O00.(New Label())
			Me.o_O.O_oOo_.(New C1Button())
			Me.O_.oo0o.(New C1Button())
			Me.O_.oo0o.(New C1CheckBox())
			Me.o_O.O_oOo_.(New C1CheckBox())
			Me.oOoOoO_OO.0o.().BeginInit()
			Me.o00.oo__O_o.().BeginInit()
			Me.o0_00.0O0oO.().BeginInit()
			Me.o00.oo__O_o.().BeginInit()
			Me.o00.oo__O_o.().BeginInit()
			Me.o0_00.0O0oO.().BeginInit()
			Me.o0_00.0O0oO.().BeginInit()
			Me.o00.oo__O_o.().BeginInit()
			MyBase.SuspendLayout()
			Me.oOoOoO_OO.0o.().AllowAddNew = True
			Me.oOoOoO_OO.0o.().AllowDelete = True
			Me.oOoOoO_OO.0o.().AutoClipboard = True
			Me.oOoOoO_OO.0o.().BorderStyle = 3
			Me.oOoOoO_OO.0o.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}" & vbTab
			Me.oOoOoO_OO.0o.().ExtendLastCol = True
			Me.oOoOoO_OO.0o.().HighLight = 2
			Me.oOoOoO_OO.0o.().Location = New Point(22, 88)
			Me.oOoOoO_OO.0o.().Name = "grdRelationCols"
			Me.oOoOoO_OO.0o.().Rows.Count = 0
			Me.oOoOoO_OO.0o.().Rows.DefaultSize = 21
			Me.oOoOoO_OO.0o.().Rows.Fixed = 0
			Me.oOoOoO_OO.0o.().Size = New Size(526, 65)
			Me.oOoOoO_OO.0o.().TabIndex = 2
			Me.o00.oo__O_o.().AllowSpinLoop = False
			Me.o00.oo__O_o.().Cursor = Cursors.Arrow
			Me.o00.oo__O_o.().DropDownStyle = 1
			Me.o00.oo__O_o.().GapHeight = 0
			Me.o00.oo__O_o.().ImagePadding = New Padding(0)
			Me.o00.oo__O_o.().ItemsDisplayMember = ""
			Me.o00.oo__O_o.().ItemsValueMember = ""
			Me.o00.oo__O_o.().Location = New Point(285, 39)
			Me.o00.oo__O_o.().Name = "cmbDestinationTable"
			Me.o00.oo__O_o.().Size = New Size(263, 19)
			Me.o00.oo__O_o.().TabIndex = 1
			Me.o00.oo__O_o.().Tag = Nothing
			Me.o0_00.0O0oO.().AllowSpinLoop = False
			Me.o0_00.0O0oO.().Cursor = Cursors.Arrow
			Me.o0_00.0O0oO.().DropDownStyle = 1
			Me.o0_00.0O0oO.().GapHeight = 0
			Me.o0_00.0O0oO.().ImagePadding = New Padding(0)
			Me.o0_00.0O0oO.().ItemsDisplayMember = ""
			Me.o0_00.0O0oO.().ItemsValueMember = ""
			Me.o0_00.0O0oO.().Location = New Point(22, 39)
			Me.o0_00.0O0oO.().Name = "cmbSourceTable"
			Me.o0_00.0O0oO.().Size = New Size(263, 19)
			Me.o0_00.0O0oO.().TabIndex = 0
			Me.o0_00.0O0oO.().Tag = Nothing
			Me.o0_ooooO._O.().AutoSize = True
			Me.o0_ooooO._O.().Location = New Point(283, 18)
			Me.o0_ooooO._O.().Name = "Label2"
			Me.o0_ooooO._O.().Size = New Size(47, 12)
			Me.o0_ooooO._O.().TabIndex = 6
			Me.o0_ooooO._O.().Tag = "子表"
			Me.o0_ooooO._O.().Text = "目标表:"
			Me.Oo.o_.().AutoSize = True
			Me.Oo.o_.().Location = New Point(22, 18)
			Me.Oo.o_.().Name = "Label1"
			Me.Oo.o_.().Size = New Size(47, 12)
			Me.Oo.o_.().TabIndex = 4
			Me.Oo.o_.().Text = "来源表:"
			Me.o00.oo__O_o.().AllowAddNew = True
			Me.o00.oo__O_o.().AllowDelete = True
			Me.o00.oo__O_o.().AutoClipboard = True
			Me.o00.oo__O_o.().BorderStyle = 3
			Me.o00.oo__O_o.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}" & vbTab
			Me.o00.oo__O_o.().ExtendLastCol = True
			Me.o00.oo__O_o.().HighLight = 2
			Me.o00.oo__O_o.().Location = New Point(22, 183)
			Me.o00.oo__O_o.().Name = "grdDataCols"
			Me.o00.oo__O_o.().Rows.Count = 0
			Me.o00.oo__O_o.().Rows.DefaultSize = 21
			Me.o00.oo__O_o.().Rows.Fixed = 0
			Me.o00.oo__O_o.().Size = New Size(526, 149)
			Me.o00.oo__O_o.().TabIndex = 3
			Me.oo.O_o_oO.().AutoSize = True
			Me.oo.O_o_oO.().Location = New Point(283, 69)
			Me.oo.O_o_oO.().Name = "lblre2"
			Me.oo.O_o_oO.().Size = New Size(47, 12)
			Me.oo.O_o_oO.().TabIndex = 10
			Me.oo.O_o_oO.().Tag = "子表"
			Me.oo.O_o_oO.().Text = "关联列:"
			Me.O.oo_000_.().AutoSize = True
			Me.O.oo_000_.().Location = New Point(22, 69)
			Me.O.oo_000_.().Name = "lbre1"
			Me.O.oo_000_.().Size = New Size(47, 12)
			Me.O.oo_000_.().TabIndex = 9
			Me.O.oo_000_.().Text = "关联列:"
			Me.oOoOoO_OO.0o.().AutoSize = True
			Me.oOoOoO_OO.0o.().Location = New Point(283, 164)
			Me.oOoOoO_OO.0o.().Name = "Label5"
			Me.oOoOoO_OO.0o.().Size = New Size(47, 12)
			Me.oOoOoO_OO.0o.().TabIndex = 12
			Me.oOoOoO_OO.0o.().Tag = "子表"
			Me.oOoOoO_OO.0o.().Text = "目标列:"
			Me.o.o_o__.().AutoSize = True
			Me.o.o_o__.().Location = New Point(22, 164)
			Me.o.o_o__.().Name = "Label6"
			Me.o.o_o__.().Size = New Size(47, 12)
			Me.o.o_o__.().TabIndex = 11
			Me.o.o_o__.().Text = "来源列:"
			Me.o00.oo__O_o.().Location = New Point(204, 382)
			Me.o00.oo__O_o.().Name = "btnOK"
			Me.o00.oo__O_o.().Size = New Size(75, 23)
			Me.o00.oo__O_o.().TabIndex = 6
			Me.o00.oo__O_o.().Text = "确定"
			Me.o00.oo__O_o.().UseVisualStyleBackColor = True
			Me.o0_00.0O0oO.().DialogResult = DialogResult.Cancel
			Me.o0_00.0O0oO.().Location = New Point(291, 382)
			Me.o0_00.0O0oO.().Name = "btnCancel"
			Me.o0_00.0O0oO.().Size = New Size(75, 23)
			Me.o0_00.0O0oO.().TabIndex = 7
			Me.o0_00.0O0oO.().Text = "取消"
			Me.o0_00.0O0oO.().UseVisualStyleBackColor = True
			Me.o0_00.0O0oO.().BorderStyle = BorderStyle.None
			Me.o0_00.0O0oO.().Checked = True
			Me.o0_00.0O0oO.().CheckState = CheckState.Checked
			Me.o0_00.0O0oO.().Location = New Point(164, 338)
			Me.o0_00.0O0oO.().Name = "chkAutoAddNew"
			Me.o0_00.0O0oO.().Size = New Size(115, 24)
			Me.o0_00.0O0oO.().TabIndex = 5
			Me.o0_00.0O0oO.().Text = "自动追加新行"
			Me.o0_00.0O0oO.().UseVisualStyleBackColor = True
			Me.o0_00.0O0oO.().Value = True
			Me.o00.oo__O_o.().BorderStyle = BorderStyle.None
			Me.o00.oo__O_o.().Checked = True
			Me.o00.oo__O_o.().CheckState = CheckState.Checked
			Me.o00.oo__O_o.().Location = New Point(24, 338)
			Me.o00.oo__O_o.().Name = "chkAutoUpdate"
			Me.o00.oo__O_o.().Size = New Size(117, 24)
			Me.o00.oo__O_o.().TabIndex = 4
			Me.o00.oo__O_o.().Text = "自动更新数据"
			Me.o00.oo__O_o.().UseVisualStyleBackColor = True
			Me.o00.oo__O_o.().Value = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(571, 421)
			MyBase.Controls.Add(Me.o00.oo__O_o.())
			MyBase.Controls.Add(Me.o0_00.0O0oO.())
			MyBase.Controls.Add(Me.o0_00.0O0oO.())
			MyBase.Controls.Add(Me.o00.oo__O_o.())
			MyBase.Controls.Add(Me.oOoOoO_OO.0o.())
			MyBase.Controls.Add(Me.o.o_o__.())
			MyBase.Controls.Add(Me.oo.O_o_oO.())
			MyBase.Controls.Add(Me.O.oo_000_.())
			MyBase.Controls.Add(Me.o00.oo__O_o.())
			MyBase.Controls.Add(Me.oOoOoO_OO.0o.())
			MyBase.Controls.Add(Me.o00.oo__O_o.())
			MyBase.Controls.Add(Me.o0_00.0O0oO.())
			MyBase.Controls.Add(Me.o0_ooooO._O.())
			MyBase.Controls.Add(Me.Oo.o_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o_0.0...o"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "批量更新数据"
			Me.oOoOoO_OO.0o.().EndInit()
			Me.o00.oo__O_o.().EndInit()
			Me.o0_00.0O0oO.().EndInit()
			Me.o00.oo__O_o.().EndInit()
			Me.o00.oo__O_o.().EndInit()
			Me.o0_00.0O0oO.().EndInit()
			Me.o0_00.0O0oO.().EndInit()
			Me.o00.oo__O_o.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600088A RID: 2186 RVA: 0x0003B7EA File Offset: 0x000399EA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O00_.__0OO.
		End Function

		' Token: 0x0600088B RID: 2187 RVA: 0x0003B7F4 File Offset: 0x000399F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.Oo.o_.
			Dim o00_.__0OO. As C1FlexGrid = Me.O00_.__0OO.
			If o00_.__0OO. IsNot Nothing Then
				o00_.__0OO..AfterEdit -= rowColEventHandler
			End If
			Me.O00_.__0OO. = A_0
			o00_.__0OO. = Me.O00_.__0OO.
			If o00_.__0OO. IsNot Nothing Then
				o00_.__0OO..AfterEdit += rowColEventHandler
			End If
		End Sub

		' Token: 0x0600088C RID: 2188 RVA: 0x0003B837 File Offset: 0x00039A37
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oo.o_O00.
		End Function

		' Token: 0x0600088D RID: 2189 RVA: 0x0003B840 File Offset: 0x00039A40
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0_Oo_._.
			Dim c1ComboBox As C1ComboBox = Me.oo.o_O00.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.oo.o_O00. = A_0
			c1ComboBox = Me.oo.o_O00.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600088E RID: 2190 RVA: 0x0003B883 File Offset: 0x00039A83
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o.o_o_0000_.
		End Function

		' Token: 0x0600088F RID: 2191 RVA: 0x0003B88C File Offset: 0x00039A8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O0o.0.
			Dim c1ComboBox As C1ComboBox = Me.o.o_o_0000_.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o.o_o_0000_. = A_0
			c1ComboBox = Me.o.o_o_0000_.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06000890 RID: 2192 RVA: 0x0003B8CF File Offset: 0x00039ACF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O00_.__0OO.
		End Function

		' Token: 0x06000891 RID: 2193 RVA: 0x0003B8D7 File Offset: 0x00039AD7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O00_.__0OO. = A_0
		End Sub

		' Token: 0x06000892 RID: 2194 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OOo_.o.
		End Function

		' Token: 0x06000893 RID: 2195 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OOo_.o. = A_0
		End Sub

		' Token: 0x06000894 RID: 2196 RVA: 0x0003B8F1 File Offset: 0x00039AF1
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.OOo_.o.
		End Function

		' Token: 0x06000895 RID: 2197 RVA: 0x0003B8FC File Offset: 0x00039AFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.Oo.o_.
			Dim ooo_.o. As C1FlexGrid = Me.OOo_.o.
			If ooo_.o. IsNot Nothing Then
				ooo_.o..AfterEdit -= rowColEventHandler
			End If
			Me.OOo_.o. = A_0
			ooo_.o. = Me.OOo_.o.
			If ooo_.o. IsNot Nothing Then
				ooo_.o..AfterEdit += rowColEventHandler
			End If
		End Sub

		' Token: 0x06000896 RID: 2198 RVA: 0x0003B93F File Offset: 0x00039B3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.oO0O__o_0o0.
		End Function

		' Token: 0x06000897 RID: 2199 RVA: 0x0003B947 File Offset: 0x00039B47
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.oO0O__o_0o0. = A_0
		End Sub

		' Token: 0x06000898 RID: 2200 RVA: 0x0003B950 File Offset: 0x00039B50
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O00oo0_0oo.0O.
		End Function

		' Token: 0x06000899 RID: 2201 RVA: 0x0003B958 File Offset: 0x00039B58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O00oo0_0oo.0O. = A_0
		End Sub

		' Token: 0x0600089A RID: 2202 RVA: 0x0003B961 File Offset: 0x00039B61
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.0_o.
		End Function

		' Token: 0x0600089B RID: 2203 RVA: 0x0003B969 File Offset: 0x00039B69
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.0_o. = A_0
		End Sub

		' Token: 0x0600089C RID: 2204 RVA: 0x0003B972 File Offset: 0x00039B72
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o00O0.Ooo0O0.
		End Function

		' Token: 0x0600089D RID: 2205 RVA: 0x0003B97A File Offset: 0x00039B7A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o00O0.Ooo0O0. = A_0
		End Sub

		' Token: 0x0600089E RID: 2206 RVA: 0x0003B983 File Offset: 0x00039B83
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oo.o_O00.
		End Function

		' Token: 0x0600089F RID: 2207 RVA: 0x0003B98C File Offset: 0x00039B8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_.oo_.
			Dim c1Button As C1Button = Me.oo.o_O00.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oo.o_O00. = A_0
			c1Button = Me.oo.o_O00.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060008A0 RID: 2208 RVA: 0x0003B9CF File Offset: 0x00039BCF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.o_o_0000_.
		End Function

		' Token: 0x060008A1 RID: 2209 RVA: 0x0003B9D7 File Offset: 0x00039BD7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o.o_o_0000_. = A_0
		End Sub

		' Token: 0x060008A2 RID: 2210 RVA: 0x0003B9E0 File Offset: 0x00039BE0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oo.o_O00.
		End Function

		' Token: 0x060008A3 RID: 2211 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oo.o_O00. = A_0
		End Sub

		' Token: 0x060008A4 RID: 2212 RVA: 0x0003B9F1 File Offset: 0x00039BF1
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o.o_o_0000_.
		End Function

		' Token: 0x060008A5 RID: 2213 RVA: 0x0003B9F9 File Offset: 0x00039BF9
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o.o_o_0000_. = A_0
		End Sub

		' Token: 0x060008A6 RID: 2214 RVA: 0x0003BA04 File Offset: 0x00039C04
		Public Sub New(Optional A_0 As Boolean = False)
			AddHandler MyBase.Load, AddressOf Me.oO.o0o__.
			AddHandler MyBase.FormClosed, AddressOf Me.o00.oo__O_o.
			Me.Oo.o_.()
			Me.O00_.__0OO. = A_0
			If A_0 Then
				Dim array As Control() = New Control() { Me.O.oo_000_.(), Me.oo.O_o_oO.(), Me.oOoOoO_OO.0o.() }
				For i As Integer = 0 To array.Length - 1
					array(i).Visible = False
				Next
				Try
					For Each obj As Object In MyBase.Controls
						Dim control As Control = CType(obj, Control)
						If control.Top > Me.oOoOoO_OO.0o.().Top Then
							If TypeOf control Is C1Button Then
								control.Top -= 110
							Else
								control.Top -= 95
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				MyBase.Height -= 110
				Me.o0_00.0O0oO.().Visible = False
				Me.o00.oo__O_o.().Visible = False
				Me.Text = "批量复制数据"
			End If
		End Sub

		' Token: 0x060008A7 RID: 2215 RVA: 0x0003BB40 File Offset: 0x00039D40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					If Not dataTable.frd_IsTemporary Then
						Me.o0_00.0O0oO.().Items.Add(dataTable.Name)
						Me.o00.oo__O_o.().Items.Add(dataTable.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060008A8 RID: 2216 RVA: 0x0003BBD0 File Offset: 0x00039DD0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0_00.0O0oO.().SelectedItem IsNot Nothing Then
				Dim a_ As String = Conversions.ToString(Me.o0_00.0O0oO.().SelectedItem)
				Me.oOoOoO_OO.0o.().Cols(0).ComboList = Me.Oo.o_.(OO_00oOO.DataTables(a_))
				Me.o00.oo__O_o.().Cols(0).ComboList = Me.oOoOoO_OO.0o.().Cols(0).ComboList
				For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.oOoOoO_OO.0o.(), Me.o00.oo__O_o.() }
					Dim num As Integer = c1FlexGrid.Rows.Count - 1
					For j As Integer = 0 To num
						If Operators.CompareString(Conversions.ToString(c1FlexGrid(j, 0)), "", True) > 0 AndAlso Not OO_00oOO.DataTables(Conversions.ToString(Me.o0_00.0O0oO.().SelectedItem)).DataCols.Contains(Conversions.ToString(c1FlexGrid(j, 0))) Then
							c1FlexGrid(j, 0) = ""
						End If
					Next
				Next
			End If
		End Sub

		' Token: 0x060008A9 RID: 2217 RVA: 0x0003BD00 File Offset: 0x00039F00
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o00.oo__O_o.().SelectedItem IsNot Nothing Then
				Me.oOoOoO_OO.0o.().Cols(1).ComboList = Me.Oo.o_.(OO_00oOO.DataTables(Conversions.ToString(Me.o00.oo__O_o.().SelectedItem)))
				Me.o00.oo__O_o.().Cols(1).ComboList = Me.oOoOoO_OO.0o.().Cols(1).ComboList
				For Each c1FlexGrid As C1FlexGrid In New C1FlexGrid() { Me.oOoOoO_OO.0o.(), Me.o00.oo__O_o.() }
					Dim num As Integer = c1FlexGrid.Rows.Count - 1
					For j As Integer = 0 To num
						If Operators.CompareString(Conversions.ToString(c1FlexGrid(j, 1)), "", True) > 0 AndAlso Not OO_00oOO.DataTables(Conversions.ToString(Me.o00.oo__O_o.().SelectedItem)).DataCols.Contains(Conversions.ToString(c1FlexGrid(j, 1))) Then
							c1FlexGrid(j, 1) = ""
						End If
					Next
				Next
			End If
		End Sub

		' Token: 0x060008AA RID: 2218 RVA: 0x0003BE2C File Offset: 0x0003A02C
		Private Function <<EMPTY_NAME>>(A_0 As DataTable) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Try
				For Each dataCol As DataCol In A_0.DataCols
					If Not dataCol.IsTemporary Then
						If stringBuilder.Length > 0 Then
							stringBuilder.Append("|")
						End If
						stringBuilder.Append(dataCol.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060008AB RID: 2219 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0_00.0O0oO.().SelectedItem IsNot Nothing AndAlso Me.o00.oo__O_o.().SelectedItem IsNot Nothing Then
				Dim a_ As String = Me.o0_00.0O0oO.().SelectedItem.ToString()
				Dim a_2 As String = Me.o00.oo__O_o.().SelectedItem.ToString()
				Dim list As List(Of String) = New List(Of String)()
				Dim list2 As List(Of String) = New List(Of String)()
				Dim list3 As List(Of String) = New List(Of String)()
				Dim list4 As List(Of String) = New List(Of String)()
				Dim num As Integer = Me.oOoOoO_OO.0o.().Rows.Count - 2
				For i As Integer = 0 To num
					If Me.oOoOoO_OO.0o.().GetData(i, 0) IsNot Nothing AndAlso Me.oOoOoO_OO.0o.().GetData(i, 1) IsNot Nothing Then
						list.Add(Me.oOoOoO_OO.0o.().GetData(i, 0).ToString())
						list2.Add(Me.oOoOoO_OO.0o.().GetData(i, 1).ToString())
					End If
				Next
				Dim num2 As Integer = Me.o00.oo__O_o.().Rows.Count - 2
				For j As Integer = 0 To num2
					If Me.o00.oo__O_o.().GetData(j, 0) IsNot Nothing AndAlso Me.o00.oo__O_o.().GetData(j, 1) IsNot Nothing Then
						Dim item As String = Me.o00.oo__O_o.().GetData(j, 0).ToString()
						Dim item2 As String = Me.o00.oo__O_o.().GetData(j, 1).ToString()
						If Not list.Contains(item) AndAlso Not list2.Contains(item2) Then
							list3.Add(item)
							list4.Add(item2)
						End If
					End If
				Next
				If(list.Count <> 0 OrElse Me.O00_.__0OO.) AndAlso list3.Count <> 0 Then
					If Me.O00_.__0OO. Then
						Dim dataView As DataView = New DataView(OO_00oOO.DataTables(a_).BaseTable, OO_00oOO.Tables(a_).Filter, "", DataViewRowState.CurrentRows)
						Dim dataTable As DataTable = OO_00oOO.DataTables(a_2).BaseTable
						Dim num3 As Integer = dataView.Count - 1
						For k As Integer = 0 To num3
							Dim dataRow As DataRow = dataTable.NewRow()
							Dim num4 As Integer = list4.Count - 1
							For l As Integer = 0 To num4
								dataRow(list4(l)) = RuntimeHelpers.GetObjectValue(dataView(k)(list3(l)))
							Next
							dataTable.Rows.Add(dataRow)
						Next
					Else
						Dim dataView2 As DataView = New DataView(OO_00oOO.DataTables(a_).BaseTable, OO_00oOO.Tables(a_).Filter, String.Join(",", list), DataViewRowState.CurrentRows)
						Dim dataView3 As DataView = New DataView(OO_00oOO.DataTables(a_2).BaseTable, "", String.Join(",", list2), DataViewRowState.CurrentRows)
						Dim array As Object() = New Object(list.Count - 1 + 1 - 1) {}
						Dim array2 As Object() = New Object(list.Count - 1 + 1 - 1) {}
						Dim num5 As Integer = dataView2.Count - 1
						Dim m As Integer = 0
						While m <= num5
							Dim num6 As Integer = array.Length - 1
							For n As Integer = 0 To num6
								array(n) = RuntimeHelpers.GetObjectValue(dataView2(m)(list(n)))
							Next
							If m <= 0 Then
								GoTo IL_366
							End If
							Dim flag As Boolean = True
							Dim num7 As Integer = array.Length - 1
							For num8 As Integer = 0 To num7
								If Operators.CompareString(array(num8).ToString(), array2(num8).ToString(), True) <> 0 Then
									flag = False
									Exit For
								End If
							Next
							If Not flag Then
								GoTo IL_366
							End If
							IL_46D:
							m += 1
							Continue While
							IL_366:
							Dim array3 As DataRowView() = dataView3.FindRows(array)
							If Not Me.o00.oo__O_o.().Checked AndAlso array3.Length > 0 Then
								array3 = New DataRowView(-1) {}
							ElseIf array3.Length = 0 AndAlso Me.o0_00.0O0oO.().Checked Then
								Dim dataRowView As DataRowView = dataView3.AddNew()
								Dim num9 As Integer = list2.Count - 1
								For num10 As Integer = 0 To num9
									dataRowView(list2(num10)) = RuntimeHelpers.GetObjectValue(array(num10))
								Next
								dataRowView.EndEdit()
								array3 = New DataRowView() { dataRowView }
							End If
							For Each dataRowView2 As DataRowView In array3
								Dim num12 As Integer = list4.Count - 1
								For num13 As Integer = 0 To num12
									dataRowView2(list4(num13)) = RuntimeHelpers.GetObjectValue(dataView2(m)(list3(num13)))
								Next
								dataRowView2.EndEdit()
							Next
							Array.Copy(array, array2, array.Length)
							GoTo IL_46D
						End While
					End If
					MyBase.DialogResult = DialogResult.OK
				End If
			End If
		End Sub

		' Token: 0x060008AC RID: 2220 RVA: 0x0003C338 File Offset: 0x0003A538
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Me.o0_00.0O0oO.().SelectedItem IsNot Nothing AndAlso Me.o00.oo__O_o.().SelectedItem IsNot Nothing Then
				Me.o0_00.0O0oO.().SelectedItem.ToString()
				Dim a_ As String = Me.o00.oo__O_o.().SelectedItem.ToString()
				If A_1.Col = 0 Then
					Dim c1FlexGrid As C1FlexGrid = CType(A_0, C1FlexGrid)
					Dim text As String = c1FlexGrid.GetData(A_1.Row, 0).ToString()
					If OO_00oOO.DataTables(a_).BaseTable.Columns.Contains(text) Then
						c1FlexGrid(A_1.Row, 1) = text
					End If
				End If
			End If
		End Sub

		' Token: 0x060008AD RID: 2221 RVA: 0x0003C3CE File Offset: 0x0003A5CE
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040002F4 RID: 756
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040002F5 RID: 757
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040002F6 RID: 758
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040002F7 RID: 759
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040002F8 RID: 760
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002F9 RID: 761
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002FA RID: 762
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040002FB RID: 763
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002FC RID: 764
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002FD RID: 765
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002FE RID: 766
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040002FF RID: 767
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000300 RID: 768
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000301 RID: 769
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000302 RID: 770
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04000303 RID: 771
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
