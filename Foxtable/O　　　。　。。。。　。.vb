Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000367 RID: 871
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002
		Inherits Form

		' Token: 0x060036B9 RID: 14009 RVA: 0x0017373C File Offset: 0x0017193C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oO000O_Ooo.oo0. IsNot Nothing Then
					Me.oO000O_Ooo.oo0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060036BA RID: 14010 RVA: 0x0017377C File Offset: 0x0017197C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002))
			Me.O.OO__0O.(New C1FlexGrid())
			Me.O.OO__0O.(New C1Button())
			Me.O.OO__0O.().BeginInit()
			MyBase.SuspendLayout()
			Me.O.OO__0O.().AllowDragging = 0
			Me.O.OO__0O.().AllowEditing = False
			Me.O.OO__0O.().AllowResizing = 0
			Me.O.OO__0O.().ColumnInfo = "9,0,0,20,0,115,Columns:"
			Me.O.OO__0O.().FocusRect = 3
			Me.O.OO__0O.().Font = New Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.O.OO__0O.().Location = New Point(12, 10)
			Me.O.OO__0O.().Name = "C1FlexGrid1"
			Me.O.OO__0O.().Rows.Count = 9
			Me.O.OO__0O.().Rows.DefaultSize = 23
			Me.O.OO__0O.().Rows.Fixed = 0
			Me.O.OO__0O.().ScrollBars = ScrollBars.None
			Me.O.OO__0O.().Size = New Size(285, 285)
			Me.O.OO__0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo")
			Me.O.OO__0O.().TabIndex = 0
			Me.O.OO__0O.().Location = New Point(232, 301)
			Me.O.OO__0O.().Name = "btnMore"
			Me.O.OO__0O.().Size = New Size(64, 23)
			Me.O.OO__0O.().TabIndex = 3
			Me.O.OO__0O.().Text = "更多..."
			Me.O.OO__0O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(308, 332)
			MyBase.Controls.Add(Me.O.OO__0O.())
			MyBase.Controls.Add(Me.O.OO__0O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O......0"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "常用符号"
			Me.O.OO__0O.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060036BB RID: 14011 RVA: 0x001739CD File Offset: 0x00171BCD
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O.OO__0O.
		End Function

		' Token: 0x060036BC RID: 14012 RVA: 0x001739D8 File Offset: 0x00171BD8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim value As EventHandler = AddressOf Me.oo.Oo0.
			Dim o.OO__0O. As C1FlexGrid = Me.O.OO__0O.
			If o.OO__0O. IsNot Nothing Then
				RemoveHandler o.OO__0O..DoubleClick, value
			End If
			Me.O.OO__0O. = A_0
			o.OO__0O. = Me.O.OO__0O.
			If o.OO__0O. IsNot Nothing Then
				AddHandler o.OO__0O..DoubleClick, value
			End If
		End Sub

		' Token: 0x060036BD RID: 14013 RVA: 0x00173A1B File Offset: 0x00171C1B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OO__0O.
		End Function

		' Token: 0x060036BE RID: 14014 RVA: 0x00173A24 File Offset: 0x00171C24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOoO_OOo._.
			Dim o.OO__0O. As C1Button = Me.O.OO__0O.
			If o.OO__0O. IsNot Nothing Then
				RemoveHandler o.OO__0O..Click, value
			End If
			Me.O.OO__0O. = A_0
			o.OO__0O. = Me.O.OO__0O.
			If o.OO__0O. IsNot Nothing Then
				AddHandler o.OO__0O..Click, value
			End If
		End Sub

		' Token: 0x060036BF RID: 14015 RVA: 0x00173A68 File Offset: 0x00171C68
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O_oo.0o_O_o0.
			AddHandler MyBase.FormClosed, AddressOf Me.O.OO__0O.
			Me.O.OO__0O.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060036C0 RID: 14016 RVA: 0x00173ABC File Offset: 0x00171CBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim c1FlexGrid As C1FlexGrid = Me.O.OO__0O.()
				IL_11:
				num2 = 3
				c1FlexGrid.Cols.DefaultSize = CInt(Math.Round(CDbl(c1FlexGrid.ClientSize.Width) / CDbl(c1FlexGrid.Cols.Count)))
				IL_44:
				num2 = 4
				c1FlexGrid.Rows.DefaultSize = c1FlexGrid.Cols.DefaultSize
				IL_5E:
				c1FlexGrid = Nothing
				IL_61:
				num2 = 6
				Dim file As String = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\symbol.txt"
				IL_82:
				num2 = 7
				If Not c.OOOOO.o.().FileSystem.FileExists(file) Then
					GoTo IL_145
				End If
				IL_99:
				num2 = 8
				Dim text As String = c.OOOOO.o.().FileSystem.ReadAllText(file, Encoding.[Default])
				IL_B2:
				num2 = 9
				Dim c1FlexGrid2 As C1FlexGrid = Me.O.OO__0O.()
				IL_BD:
				num2 = 10
				Dim num3 As Integer = c1FlexGrid2.Rows.Count - 1
				For i As Integer = 0 To num3
					IL_D5:
					num2 = 11
					Dim num4 As Integer = c1FlexGrid2.Cols.Count - 1
					For j As Integer = 0 To num4
						IL_ED:
						num2 = 12
						Dim num5 As Integer
						c1FlexGrid2(i, j) = text(num5)
						IL_109:
						num2 = 13
						num5 += 1
						IL_112:
						num2 = 14
						If num5 > text.Length - 1 Then
							GoTo IL_15B
						End If
						IL_122:
						num2 = 16
					Next
					IL_131:
					num2 = 17
				Next
				IL_140:
				c1FlexGrid2 = Nothing
				GoTo IL_15B
				IL_145:
				num2 = 20
				MessageBox.Show("找不到文件Symbol.Txt", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_15B:
				GoTo IL_201
				IL_160:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_1C2:
				GoTo IL_1F6
				IL_1C4:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1D4:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1C4
			End Try
			IL_1F6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_201:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060036C1 RID: 14017 RVA: 0x00173CF0 File Offset: 0x00171EF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.O.OO__0O.()
			If c1FlexGrid.MouseCol >= 0 And c1FlexGrid.MouseRow >= 0 Then
				Me.O.OO__0O.(c1FlexGrid(c1FlexGrid.MouseRow, c1FlexGrid.MouseCol).ToString())
			End If
		End Sub

		' Token: 0x060036C2 RID: 14018 RVA: 0x00173D40 File Offset: 0x00171F40
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				Process.Start("charmap.exe")
			Catch ex As Exception
				MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			MyBase.Close()
		End Sub

		' Token: 0x060036C3 RID: 14019 RVA: 0x00173D94 File Offset: 0x00171F94
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = OO_00oOO.CurrentTable.foxGrid.Col
				IL_19:
				num2 = 3
				If Not(TypeOf Main.OO_O.o..ActiveControl Is OooOo0___oO) Then
					GoTo IL_9B
				End If
				IL_2C:
				num2 = 4
				Dim oooOo0___oO As OooOo0___oO = CType(Main.OO_O.o..ActiveControl, OooOo0___oO)
				IL_3F:
				num2 = 5
				Dim text As String = oooOo0___oO.Rows(oooOo0___oO.Row).UserData.ToString()
				IL_60:
				num2 = 6
				If Not OO_00oOO.CurrentTable.foxGrid.Cols.Contains(text) Then
					GoTo IL_98
				End If
				IL_7A:
				num2 = 7
				num3 = OO_00oOO.CurrentTable.foxGrid.Cols(text).Index
				IL_98:
				oooOo0___oO = Nothing
				IL_9B:
				num2 = 9
				Dim o_oOooO_O As O_oOooO_O = OO_00oOO.CurrentTable.foxGrid
				IL_AA:
				num2 = 10
				If o_oOooO_O.Row = -1 OrElse o_oOooO_O.Rows(o_oOooO_O.Row).DataIndex = -1 Then
					GoTo IL_278
				End If
				IL_D8:
				num2 = 12
				If o_oOooO_O.Cols(num3).DataType IsNot GetType(String) Then
					GoTo IL_278
				End If
				IL_FC:
				num2 = 15
				If Not o_oOooO_O.o000OOo.OO.(o_oOooO_O.Row, num3) Then
					GoTo IL_278
				End If
				IL_113:
				o_oOooO_O = Nothing
				IL_116:
				num2 = 18
				Dim row As DataRow = OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Row
				IL_12F:
				num2 = 19
				Dim dataColumn As DataColumn = OO_00oOO.CurrentTable.DataTable.DataCols(OO_00oOO.CurrentTable.foxGrid.Cols(num3).Name).BaseColumn
				IL_167:
				num2 = 20
				If row.IsNull(dataColumn) Then
					GoTo IL_197
				End If
				IL_175:
				num2 = 21
				If row(dataColumn).ToString().Length = dataColumn.MaxLength Then
					GoTo IL_278
				End If
				IL_197:
				num2 = 23
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(New o0o0o00(OO_00oOO.CurrentTable, row, dataColumn.ColumnName))
				IL_1BC:
				num2 = 24
				If Not row.IsNull(dataColumn) Then
					GoTo IL_1D9
				End If
				IL_1CA:
				num2 = 25
				row(dataColumn) = A_0
				GoTo IL_1F9
				IL_1D9:
				num2 = 27
				row(dataColumn) = row(dataColumn).ToString() + A_0
				IL_1F9:
				num2 = 28
				Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(OO_00oOO.CurrentTable, New Row(OO_00oOO.CurrentTable, OO_00oOO.CurrentTable.View.o_o.O0ooOo.()), OO_00oOO.CurrentTable.Cols(dataColumn.ColumnName), Nothing)
				IL_238:
				num2 = 29
				Dim a_ As String = "AfterEdit"
				IL_242:
				num2 = 30
				O_O0OO.OoO_o.oO0o0O.(OO_00oOO.CurrentTable.DataTable.o_0_00_.oo0O0., a_, New Object() { rowColEventArgs }, False, OO_00oOO.CurrentTable.DataTable.Name, False)
				IL_278:
				GoTo IL_346
				IL_27D:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_307:
				GoTo IL_33B
				IL_309:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_319:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_309
			End Try
			IL_33B:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_346:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060036C4 RID: 14020 RVA: 0x0017410C File Offset: 0x0017230C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001684 RID: 5764
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001685 RID: 5765
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001686 RID: 5766
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
