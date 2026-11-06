Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000364 RID: 868
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3000\u3000_\u3002
		Inherits Form

		' Token: 0x0600365C RID: 13916 RVA: 0x0016F948 File Offset: 0x0016DB48
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOO.o. IsNot Nothing Then
					Me.oOO.o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600365D RID: 13917 RVA: 0x0016F988 File Offset: 0x0016DB88
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(O\u3000\u3000\u3000\u3000_\u3002))
			Me.oo00.o0o.(New C1Button())
			Me.Ooo.OO0_.(New C1Button())
			Me.Ooo.OO0_.(New GroupBox())
			Me.o.00oO00_O_.(New RadioButton())
			Me.Ooo.OO0_.(New RadioButton())
			Me.oO0._o_o_O.(New RadioButton())
			Me.oo_O0.Oo.(New Label())
			Me.Ooo.OO0_.(New Label())
			Me.oo_O0.Oo.(New C1Button())
			Me.Ooo.OO0_.(New C1FlexGrid())
			Me.o0o0oOo_O.0oo.().SuspendLayout()
			Me.o0o0oOo_O.0oo.().BeginInit()
			MyBase.SuspendLayout()
			Me.ooOo.00o.().Location = New Point(313, 344)
			Me.ooOo.00o.().Name = "cmdAccept"
			Me.ooOo.00o.().Size = New Size(75, 23)
			Me.ooOo.00o.().TabIndex = 3
			Me.ooOo.00o.().Text = "确定"
			Me.ooOo.00o.().UseVisualStyleBackColor = True
			Me.ooOoO00.00o.().Location = New Point(394, 344)
			Me.ooOoO00.00o.().Name = "cmdCancel"
			Me.ooOoO00.00o.().Size = New Size(75, 23)
			Me.ooOoO00.00o.().TabIndex = 4
			Me.ooOoO00.00o.().Text = "取消"
			Me.ooOoO00.00o.().UseVisualStyleBackColor = True
			Me.o0o0oOo_O.0oo.().Controls.Add(Me.ooOo.00o.())
			Me.o0o0oOo_O.0oo.().Controls.Add(Me.o0o0oOo_O.0oo.())
			Me.o0o0oOo_O.0oo.().Controls.Add(Me.ooOoO00.00o.())
			Me.o0o0oOo_O.0oo.().Location = New Point(13, 241)
			Me.o0o0oOo_O.0oo.().Name = "GroupBox2"
			Me.o0o0oOo_O.0oo.().Size = New Size(456, 48)
			Me.o0o0oOo_O.0oo.().TabIndex = 1
			Me.o0o0oOo_O.0oo.().TabStop = False
			Me.o0o0oOo_O.0oo.().Text = "合并类型"
			Me.ooOo.00o.().AutoSize = True
			Me.ooOo.00o.().Location = New Point(113, 19)
			Me.ooOo.00o.().Name = "NotMerge"
			Me.ooOo.00o.().Size = New Size(59, 16)
			Me.ooOo.00o.().TabIndex = 2
			Me.ooOo.00o.().TabStop = True
			Me.ooOo.00o.().Text = "不合并"
			Me.ooOo.00o.().UseVisualStyleBackColor = True
			Me.o0o0oOo_O.0oo.().AutoSize = True
			Me.o0o0oOo_O.0oo.().Location = New Point(60, 19)
			Me.o0o0oOo_O.0oo.().Name = "Free"
			Me.o0o0oOo_O.0oo.().Size = New Size(47, 16)
			Me.o0o0oOo_O.0oo.().TabIndex = 1
			Me.o0o0oOo_O.0oo.().TabStop = True
			Me.o0o0oOo_O.0oo.().Text = "自由"
			Me.o0o0oOo_O.0oo.().UseVisualStyleBackColor = True
			Me.ooOoO00.00o.().AutoSize = True
			Me.ooOoO00.00o.().Checked = True
			Me.ooOoO00.00o.().Location = New Point(7, 19)
			Me.ooOoO00.00o.().Name = "Standard"
			Me.ooOoO00.00o.().Size = New Size(47, 16)
			Me.ooOoO00.00o.().TabIndex = 0
			Me.ooOoO00.00o.().TabStop = True
			Me.ooOoO00.00o.().Text = "标准"
			Me.ooOoO00.00o.().UseVisualStyleBackColor = True
			Me.o0o0oOo_O.0oo.().AutoSize = True
			Me.o0o0oOo_O.0oo.().Location = New Point(13, 14)
			Me.o0o0oOo_O.0oo.().Name = "Label1"
			Me.o0o0oOo_O.0oo.().Size = New Size(71, 12)
			Me.o0o0oOo_O.0oo.().TabIndex = 11
			Me.o0o0oOo_O.0oo.().Text = "选择合并列:"
			Me.ooOo.00o.().Location = New Point(13, 307)
			Me.ooOo.00o.().Name = "Label2"
			Me.ooOo.00o.().Size = New Size(486, 34)
			Me.ooOo.00o.().TabIndex = 1
			Me.ooOo.00o.().Text = "提示:对于标准合并，合并列必须从第一列开始，而且是连续的，否则达不到合并效果"
			Me.o0o0oOo_O.0oo.().Location = New Point(13, 344)
			Me.o0o0oOo_O.0oo.().Name = "btnViewCode"
			Me.o0o0oOo_O.0oo.().Size = New Size(75, 23)
			Me.o0o0oOo_O.0oo.().TabIndex = 2
			Me.o0o0oOo_O.0oo.().Text = "查看代码"
			Me.o0o0oOo_O.0oo.().UseVisualStyleBackColor = True
			Me.o0o0oOo_O.0oo.().AllowSorting = 0
			Me.o0o0oOo_O.0oo.().BorderStyle = 1
			Me.o0o0oOo_O.0oo.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:362;Caption:""名称"";}" & vbTab & "1{Width:30;Caption:""排序"";Style:""ComboList:""""升序|降序|不排序"""";"";}" & vbTab
			Me.o0o0oOo_O.0oo.().ExtendLastCol = True
			Me.o0o0oOo_O.0oo.().FocusRect = 0
			Me.o0o0oOo_O.0oo.().Location = New Point(13, 33)
			Me.o0o0oOo_O.0oo.().Name = "C1FlexGrid1"
			Me.o0o0oOo_O.0oo.().Rows.Count = 1
			Me.o0o0oOo_O.0oo.().Rows.DefaultSize = 19
			Me.o0o0oOo_O.0oo.().SelectionMode = 3
			Me.o0o0oOo_O.0oo.().Size = New Size(456, 195)
			Me.o0o0oOo_O.0oo.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.o0o0oOo_O.0oo.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(482, 386)
			MyBase.Controls.Add(Me.o0o0oOo_O.0oo.())
			MyBase.Controls.Add(Me.o0o0oOo_O.0oo.())
			MyBase.Controls.Add(Me.ooOo.00o.())
			MyBase.Controls.Add(Me.o0o0oOo_O.0oo.())
			MyBase.Controls.Add(Me.o0o0oOo_O.0oo.())
			MyBase.Controls.Add(Me.ooOoO00.00o.())
			MyBase.Controls.Add(Me.ooOo.00o.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O00....O"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "设置合并模式"
			Me.o0o0oOo_O.0oo.().ResumeLayout(False)
			Me.o0o0oOo_O.0oo.().PerformLayout()
			Me.o0o0oOo_O.0oo.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600365E RID: 13918 RVA: 0x0017001A File Offset: 0x0016E21A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_oO._0Oo.
		End Function

		' Token: 0x0600365F RID: 13919 RVA: 0x00170024 File Offset: 0x0016E224
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o.oO0_OoOooO.
			Dim o_oO._0Oo. As C1Button = Me.O_oO._0Oo.
			If o_oO._0Oo. IsNot Nothing Then
				RemoveHandler o_oO._0Oo..Click, value
			End If
			Me.O_oO._0Oo. = A_0
			o_oO._0Oo. = Me.O_oO._0Oo.
			If o_oO._0Oo. IsNot Nothing Then
				AddHandler o_oO._0Oo..Click, value
			End If
		End Sub

		' Token: 0x06003660 RID: 13920 RVA: 0x00170067 File Offset: 0x0016E267
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.00oO00_O_.
		End Function

		' Token: 0x06003661 RID: 13921 RVA: 0x00170070 File Offset: 0x0016E270
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo__._0__.
			Dim c1Button As C1Button = Me.o.00oO00_O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.00oO00_O_. = A_0
			c1Button = Me.o.00oO00_O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003662 RID: 13922 RVA: 0x001700B3 File Offset: 0x0016E2B3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.O_oO._0Oo.
		End Function

		' Token: 0x06003663 RID: 13923 RVA: 0x001700BB File Offset: 0x0016E2BB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.O_oO._0Oo. = A_0
		End Sub

		' Token: 0x06003664 RID: 13924 RVA: 0x001700C4 File Offset: 0x0016E2C4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_oO._0Oo.
		End Function

		' Token: 0x06003665 RID: 13925 RVA: 0x001700CC File Offset: 0x0016E2CC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O_oO._0Oo. = A_0
		End Sub

		' Token: 0x06003666 RID: 13926 RVA: 0x001700D5 File Offset: 0x0016E2D5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0OoO_.oo0Ooo.
		End Function

		' Token: 0x06003667 RID: 13927 RVA: 0x001700DD File Offset: 0x0016E2DD
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o0OoO_.oo0Ooo. = A_0
		End Sub

		' Token: 0x06003668 RID: 13928 RVA: 0x001700E6 File Offset: 0x0016E2E6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_oO._0Oo.
		End Function

		' Token: 0x06003669 RID: 13929 RVA: 0x001700EE File Offset: 0x0016E2EE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_oO._0Oo. = A_0
		End Sub

		' Token: 0x0600366A RID: 13930 RVA: 0x001700F7 File Offset: 0x0016E2F7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.Ooo.O_O__o0o.
		End Function

		' Token: 0x0600366B RID: 13931 RVA: 0x001700FF File Offset: 0x0016E2FF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.Ooo.O_O__o0o. = A_0
		End Sub

		' Token: 0x0600366C RID: 13932 RVA: 0x00170108 File Offset: 0x0016E308
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.00oO00_O_.
		End Function

		' Token: 0x0600366D RID: 13933 RVA: 0x00170110 File Offset: 0x0016E310
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.00oO00_O_. = A_0
		End Sub

		' Token: 0x0600366E RID: 13934 RVA: 0x00170119 File Offset: 0x0016E319
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0._o_o_O.
		End Function

		' Token: 0x0600366F RID: 13935 RVA: 0x00170124 File Offset: 0x0016E324
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_00000.oO0.
			Dim c1Button As C1Button = Me.oO0._o_o_O.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0._o_o_O. = A_0
			c1Button = Me.oO0._o_o_O.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003670 RID: 13936 RVA: 0x00170167 File Offset: 0x0016E367
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_oO._0Oo.
		End Function

		' Token: 0x06003671 RID: 13937 RVA: 0x00170170 File Offset: 0x0016E370
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rangeEventHandler As RangeEventHandler = AddressOf Me.O0_00000.oO0.
			Dim o_oO._0Oo. As C1FlexGrid = Me.O_oO._0Oo.
			If o_oO._0Oo. IsNot Nothing Then
				o_oO._0Oo..AfterRowColChange -= rangeEventHandler
			End If
			Me.O_oO._0Oo. = A_0
			o_oO._0Oo. = Me.O_oO._0Oo.
			If o_oO._0Oo. IsNot Nothing Then
				o_oO._0Oo..AfterRowColChange += rangeEventHandler
			End If
		End Sub

		' Token: 0x06003672 RID: 13938 RVA: 0x001701B4 File Offset: 0x0016E3B4
		Public Sub New(A_0 As Table)
			AddHandler MyBase.Load, AddressOf Me.oOo._0.
			AddHandler MyBase.FormClosed, AddressOf Me.O0_00000.oO0.
			Me.oOO.o. = New List(Of String)()
			Me.oOO.o. = ""
			Me.oo_O0.Oo.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.o0o0oOo_O.0oo.().Styles.SelectedColumnHeader.Clear()
			Me.oOO.o. = A_0
		End Sub

		' Token: 0x06003673 RID: 13939 RVA: 0x00170238 File Offset: 0x0016E438
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.oOO.o..ClearEditInfos()
			Me.Ooo.OO0_.()
			Me.oOO.o..MergeCols.Clear()
			Try
				For Each text As String In Me.oOO.o.
					Me.oOO.o..Cols(text).AllowMerging = True
					Me.oOO.o..MergeCols.Add(text)
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Me.oOO.o..MergeSort = Me.oOO.o.
			Me.oOO.o..MergeMode = Me.oOO.o.
			Me.oOO.o..AllowMerge = True
			MyBase.Close()
		End Sub

		' Token: 0x06003674 RID: 13940 RVA: 0x00170304 File Offset: 0x0016E504
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Me.oOO.o. Is Nothing Then
					GoTo IL_1B3
				End If
				IL_14:
				num2 = 4
				Me.oOO.o..Clear()
				IL_21:
				num2 = 5
				Me.oOO.o. = ""
				IL_2E:
				num2 = 6
				Dim num3 As Integer = Me.o0o0oOo_O.0oo.().Rows.Count - 1
				For i As Integer = 1 To num3
					IL_4C:
					num2 = 7
					Dim num4 As Integer = i - Me.oOO.o..foxGrid.Cols.Fixed + 1
					IL_69:
					num2 = 8
					Dim text As String = Conversions.ToString(Me.o0o0oOo_O.0oo.()(num4, 0))
					IL_7F:
					num2 = 9
					If Me.o0o0oOo_O.0oo.().GetCellCheck(num4, 0) = 1 Then
						IL_95:
						num2 = 10
						Me.oOO.o..Add(text)
						IL_A5:
						num2 = 11
						Dim left As String = Conversions.ToString(Me.o0o0oOo_O.0oo.()(num4, 1))
						IL_BC:
						num2 = 13
						Dim text2 As String
						If Operators.CompareString(left, "升序", True) = 0 Then
							IL_CE:
							num2 = 14
							text2 = text
						Else
							IL_D7:
							num2 = 16
							If Operators.CompareString(left, "降序", True) = 0 Then
								IL_E9:
								num2 = 17
								text2 = text + " DESC"
							Else
								IL_FC:
								num2 = 19
								text2 = ""
							End If
						End If
						IL_106:
						num2 = 20
						If Operators.CompareString(Me.oOO.o., "", True) > 0 And Operators.CompareString(text2, "", True) > 0 Then
							IL_130:
							num2 = 21
							Me.oOO.o. += ","
						End If
						IL_149:
						num2 = 22
						Me.oOO.o. += text2
					End If
					IL_15F:
					num2 = 23
				Next
				IL_171:
				num2 = 24
				If Not Me.ooOoO00.00o.().Checked Then
					GoTo IL_18D
				End If
				IL_181:
				num2 = 25
				Me.oOO.o. = 1
				GoTo IL_1B3
				IL_18D:
				num2 = 27
				If Not Me.o0o0oOo_O.0oo.().Checked Then
					GoTo IL_1A9
				End If
				IL_19D:
				num2 = 28
				Me.oOO.o. = 2
				GoTo IL_1B3
				IL_1A9:
				num2 = 30
				Me.oOO.o. = 0
				IL_1B3:
				GoTo IL_281
				IL_1B8:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_242:
				GoTo IL_276
				IL_244:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_254:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_244
			End Try
			IL_276:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_281:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003675 RID: 13941 RVA: 0x001705B8 File Offset: 0x0016E7B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_10:
				num2 = 3
				Dim enumerator As IEnumerator(Of Col) = Me.oOO.o..Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_2F:
					num2 = 4
					dictionary.Add(col.Name, col.Caption)
					IL_46:
					num2 = 5
				End While
				IL_51:
				num2 = 6
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_5E:
				num2 = 7
				Me.o0o0oOo_O.0oo.().Cols(0).DataMap = dictionary
				IL_78:
				num2 = 8
				Me.o0o0oOo_O.0oo.().Rows.Count = Me.oOO.o..foxGrid.Cols.Count - Me.oOO.o..foxGrid.Cols.Fixed + 1
				IL_B7:
				num2 = 9
				Dim fixed As Integer = Me.oOO.o..foxGrid.Cols.Fixed
				Dim num3 As Integer = Me.oOO.o..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num3
					IL_EF:
					num2 = 10
					Dim name As String = Me.oOO.o..foxGrid.Cols(i).Name
					IL_10F:
					num2 = 11
					Dim num4 As Integer = i - Me.oOO.o..foxGrid.Cols.Fixed + 1
					IL_12E:
					num2 = 12
					Me.o0o0oOo_O.0oo.()(num4, 0) = name
					IL_140:
					num2 = 13
					If Me.oOO.o..O_O__.ooOo..ContainsKey(Me.oOO.o..foxGrid.Cols(i).Name.ToLower()) AndAlso Me.oOO.o..O_O__.ooOo.(Me.oOO.o..foxGrid.Cols(i).Name.ToLower()) = ListSortDirection.Descending Then
						IL_1AA:
						num2 = 14
						Me.o0o0oOo_O.0oo.()(num4, 1) = "降序"
					Else
						IL_1C2:
						num2 = 16
						Me.o0o0oOo_O.0oo.()(num4, 1) = "升序"
					End If
					IL_1D8:
					num2 = 17
					If Me.oOO.o..foxGrid.Cols(i).AllowMerging Then
						IL_1F9:
						num2 = 18
						Me.o0o0oOo_O.0oo.().SetCellCheck(i - Me.oOO.o..foxGrid.Cols.Fixed + 1, 0, 1)
					Else
						IL_225:
						num2 = 20
						Me.o0o0oOo_O.0oo.().SetCellCheck(i - Me.oOO.o..foxGrid.Cols.Fixed + 1, 0, 2)
					End If
					IL_24F:
					num2 = 21
				Next
				IL_261:
				num2 = 22
				If Me.oOO.o..MergeMode <> 2 Then
					GoTo IL_281
				End If
				IL_272:
				num2 = 23
				Me.o0o0oOo_O.0oo.().Checked = True
				IL_281:
				num2 = 24
				Me.o0o0oOo_O.0oo.().Styles.Normal.Border.Width = 0
				IL_29F:
				num2 = 25
				Me.o0o0oOo_O.0oo.().Visible = (OO_00oOO.User.Type = 0)
				IL_2BA:
				GoTo IL_374
				IL_2BF:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_335:
				GoTo IL_369
				IL_337:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_347:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_337
			End Try
			IL_369:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_374:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003676 RID: 13942 RVA: 0x00170960 File Offset: 0x0016EB60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06003677 RID: 13943 RVA: 0x00170968 File Offset: 0x0016EB68
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_0F:
				num2 = 3
				Dim str As String = "Tables(""" + Me.oOO.o..Name + """)"
				IL_2D:
				num2 = 4
				Me.Ooo.OO0_.()
				IL_35:
				num2 = 5
				stringBuilder.Append("With " + str)
				IL_4A:
				num2 = 6
				stringBuilder.Append(vbCrLf)
				IL_58:
				num2 = 7
				stringBuilder.Append("    .MergeMode = MergeModeEnum." + [Enum].GetName(Me.oOO.o..[GetType](), Me.oOO.o.))
				IL_8B:
				num2 = 8
				stringBuilder.Append(vbCrLf)
				IL_99:
				num2 = 9
				stringBuilder.Append("    .MergeCols.Clear()")
				IL_A8:
				num2 = 10
				stringBuilder.Append(vbCrLf)
				IL_B7:
				num2 = 11
				Dim enumerator As List(Of String).Enumerator = Me.oOO.o..GetEnumerator()
				While enumerator.MoveNext()
					Dim str2 As String = enumerator.Current
					IL_D2:
					num2 = 12
					stringBuilder.Append("    .MergeCols.Add(""" + str2 + """)")
					IL_ED:
					num2 = 13
					stringBuilder.Append(vbCrLf)
					IL_FC:
					num2 = 14
				End While
				IL_108:
				num2 = 15
				CType(enumerator, IDisposable).Dispose()
				IL_118:
				num2 = 16
				stringBuilder.Append("    .MergeSort = """ + Me.oOO.o. + """")
				IL_137:
				num2 = 17
				stringBuilder.Append(vbCrLf)
				IL_146:
				num2 = 18
				stringBuilder.Append("    .AllowMerge = True")
				IL_155:
				num2 = 19
				stringBuilder.Append(vbCrLf)
				IL_164:
				num2 = 20
				stringBuilder.Append("End With")
				IL_173:
				num2 = 21
				Dim o_u3000_u3000_u3002_u3002O As o\u3000\u3000\u3002\u3002O = New o\u3000\u3000\u3002\u3002O()
				IL_17D:
				num2 = 22
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString()
				IL_192:
				num2 = 23
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0
				IL_1A2:
				num2 = 24
				o_u3000_u3000_u3002_u3002O.ShowDialog()
				IL_1AD:
				GoTo IL_263
				IL_1B2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_224:
				GoTo IL_258
				IL_226:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_236:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_226
			End Try
			IL_258:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_263:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003678 RID: 13944 RVA: 0x00170BFC File Offset: 0x0016EDFC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			Me.o0o0oOo_O.0oo.().Col = 1
		End Sub

		' Token: 0x06003679 RID: 13945 RVA: 0x00170C0A File Offset: 0x0016EE0A
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x04001660 RID: 5728
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001661 RID: 5729
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001662 RID: 5730
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001663 RID: 5731
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001664 RID: 5732
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001665 RID: 5733
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001666 RID: 5734
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001667 RID: 5735
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04001668 RID: 5736
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001669 RID: 5737
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400166A RID: 5738
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x0400166B RID: 5739
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400166C RID: 5740
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x0400166D RID: 5741
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400166E RID: 5742
		Private <<EMPTY_NAME>> As MergeModeEnum
	End Class
End Namespace
