Imports System
Imports System.Collections
Imports System.Collections.Generic
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
	' Token: 0x0200035D RID: 861
	<DesignerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Friend Partial Class O_\u3002\u3000\u3002\u3000
		Inherits Form

		' Token: 0x060035BF RID: 13759 RVA: 0x0016A818 File Offset: 0x00168A18
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0__0._. IsNot Nothing Then
					Me.o0__0._..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060035C0 RID: 13760 RVA: 0x0016A858 File Offset: 0x00168A58
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0__0._.(New C1FlexGrid())
			Me.o0__0._.(New C1Button())
			Me.O_OooO.0oOOO0.().BeginInit()
			MyBase.SuspendLayout()
			Me.O_OooO.0oOOO0.().AllowEditing = False
			Me.O_OooO.0oOOO0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_OooO.0oOOO0.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.O_OooO.0oOOO0.().Location = New Point(12, 16)
			Me.O_OooO.0oOOO0.().Name = "C1FlexGrid1"
			Me.O_OooO.0oOOO0.().Rows.DefaultSize = 20
			Me.O_OooO.0oOOO0.().Size = New Size(566, 340)
			Me.O_OooO.0oOOO0.().TabIndex = 0
			Me.O_OooO.0oOOO0.().VisualStyle = 2
			Me.O_OooO.0oOOO0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O_OooO.0oOOO0.().Location = New Point(460, 367)
			Me.O_OooO.0oOOO0.().Name = "Button1"
			Me.O_OooO.0oOOO0.().Size = New Size(118, 23)
			Me.O_OooO.0oOOO0.().TabIndex = 1
			Me.O_OooO.0oOOO0.().Text = "回收选定行"
			Me.O_OooO.0oOOO0.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(590, 401)
			MyBase.Controls.Add(Me.O_OooO.0oOOO0.())
			MyBase.Controls.Add(Me.O_OooO.0oOOO0.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o......0"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "回收站"
			Me.O_OooO.0oOOO0.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060035C1 RID: 13761 RVA: 0x0016AA2E File Offset: 0x00168C2E
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o0__0._.
		End Function

		' Token: 0x060035C2 RID: 13762 RVA: 0x0016AA36 File Offset: 0x00168C36
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.o0__0._. = A_0
		End Sub

		' Token: 0x060035C3 RID: 13763 RVA: 0x0016AA3F File Offset: 0x00168C3F
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0__0._.
		End Function

		' Token: 0x060035C4 RID: 13764 RVA: 0x0016AA48 File Offset: 0x00168C48
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_OooO.0oOOO0.
			Dim c1Button As C1Button = Me.o0__0._.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0__0._. = A_0
			c1Button = Me.o0__0._.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060035C5 RID: 13765 RVA: 0x0016AA8C File Offset: 0x00168C8C
		Public Sub New(A_0 As DataTable)
			AddHandler MyBase.FormClosed, AddressOf Me.O_OooO.0oOOO0.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.o0__0._.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_3E:
				num = 4
				Me.o0__0._. = New DataView(A_0.BaseTable, "", "", DataViewRowState.Deleted)
				IL_5C:
				num = 5
				Me.O_OooO.0oOOO0.().AutoResize = True
				IL_6A:
				num = 6
				Me.O_OooO.0oOOO0.().DataSource = Me.o0__0._.
				IL_7D:
				num = 7
				Me.O_OooO.0oOOO0.().AllowMergingFixed = 5
				IL_8B:
				num = 8
				Me.o0__0._. = A_0
				IL_94:
				num = 9
				Dim enumerator As List(Of String).Enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_AD:
					num = 10
					If Me.O_OooO.0oOOO0.().Cols.Contains(text) Then
						IL_C4:
						num = 11
						Me.O_OooO.0oOOO0.().Cols.Remove(text)
					End If
					IL_DA:
					num = 12
				End While
				IL_E6:
				num = 13
				CType(enumerator, IDisposable).Dispose()
				IL_F6:
				num = 14
				Dim enumerator2 As IEnumerator = Me.o0__0._..BaseTable.ChildRelations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj As Object = enumerator2.Current
					Dim dataRelation As DataRelation = CType(obj, DataRelation)
					IL_120:
					num = 15
					If Me.O_OooO.0oOOO0.().Cols.Contains(dataRelation.RelationName) Then
						IL_13C:
						num = 16
						Me.O_OooO.0oOOO0.().Cols.Remove(dataRelation.RelationName)
					End If
					IL_157:
					num = 17
				End While
				IL_163:
				num = 18
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_17B:
				num = 19
				If OO_00oOO.User.Type Is Nothing Then
					GoTo IL_201
				End If
				IL_18A:
				num = 20
				Dim num3 As Integer = Me.O_OooO.0oOOO0.().Cols.Count - 1
				Dim fixed As Integer = Me.O_OooO.0oOOO0.().Cols.Fixed
				For i As Integer = num3 To fixed Step -1
					IL_1B5:
					num = 21
					If Me.O_OooO.0oOOO0.().Cols(i).Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase) Then
						IL_1DC:
						num = 22
						Me.O_OooO.0oOOO0.().Cols.Remove(i)
					End If
					IL_1F2:
					num = 23
				Next
				IL_201:
				num = 24
				Me.O_.0o_o0o.()
				IL_20A:
				num = 25
				Me.O_OooO.0oOOO0.().Cols(0).Width = 25
				IL_225:
				GoTo IL_2DF
				IL_22A:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_2A0:
				GoTo IL_2D4
				IL_2A2:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_2B2:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_2A2
			End Try
			IL_2D4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2DF:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060035C6 RID: 13766 RVA: 0x0016AD9C File Offset: 0x00168F9C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				OO_00oOO.SystemReady = False
				IL_08:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_0F:
				num = 3
				Dim list As List(Of DataRow) = New List(Of DataRow)()
				IL_17:
				num = 4
				Dim c1FlexGrid As C1FlexGrid = Me.O_OooO.0oOOO0.()
				IL_21:
				num = 5
				If c1FlexGrid.Row < c1FlexGrid.Rows.Fixed Then
					GoTo IL_95
				End If
				IL_38:
				num = 6
				Dim topRow As Integer = c1FlexGrid.Selection.TopRow
				Dim bottomRow As Integer = c1FlexGrid.Selection.BottomRow
				For i As Integer = topRow To bottomRow
					IL_60:
					num = 7
					list.Add(Me.o0__0._.(i - c1FlexGrid.Rows.Fixed).Row)
					IL_87:
					num = 8
				Next
				IL_95:
				c1FlexGrid = Nothing
				IL_98:
				num = 10
				Dim enumerator As List(Of DataRow).Enumerator = list.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataRow As DataRow = enumerator.Current
					IL_AE:
					num = 11
					dataRow.RejectChanges()
					IL_B8:
					num = 12
				End While
				IL_C4:
				num = 13
				CType(enumerator, IDisposable).Dispose()
				IL_D4:
				num = 14
				OO_00oOO.SystemReady = True
				IL_DD:
				num = 15
				Dim enumerator2 As IEnumerator(Of Table) = OO_00oOO.Tables.GetEnumerator()
				While enumerator2.MoveNext()
					Dim table As Table = enumerator2.Current
					IL_F7:
					num = 16
					If table.View.o_o.O0ooOo.() Is Me.o0__0._..Table Then
						IL_113:
						num = 17
						table.View.o_._0O0o_OoO.()
						IL_122:
						num = 18
						table.View.Oo._Oo0OO.()
						IL_131:
						num = 19
						table.ClearEditInfos()
					End If
					IL_13B:
					num = 20
				End While
				IL_147:
				num = 21
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_155:
				GoTo IL_1FF
				IL_15A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1C0:
				GoTo IL_1F4
				IL_1C2:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_1D2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1C2
			End Try
			IL_1F4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1FF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060035C7 RID: 13767 RVA: 0x0016AFCC File Offset: 0x001691CC
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 1
				IL_0B:
				num2 = 3
				Dim c1FlexGrid As C1FlexGrid = Me.O_OooO.0oOOO0.()
				IL_15:
				num2 = 4
				Dim fixed As Integer = c1FlexGrid.Cols.Fixed
				Dim num4 As Integer = c1FlexGrid.Cols.Count - 1
				For i As Integer = fixed To num4
					IL_3A:
					num2 = 5
					Dim caption As String = Me.o0__0._..DataCols(c1FlexGrid.Cols(i).Name).Caption
					IL_66:
					num2 = 6
					If Operators.CompareString(caption, "", True) > 0 Then
						IL_78:
						num2 = 7
						c1FlexGrid.Cols(i).Caption = caption
					Else
						IL_91:
						num2 = 9
						c1FlexGrid.Cols(i).Caption = c1FlexGrid.Cols(i).Name
					End If
					IL_BA:
					num2 = 10
					c1FlexGrid.Cols(i).AllowMerging = True
					IL_D1:
					num2 = 11
					num3 = Math.Max(num3, c1FlexGrid.Cols(i).Caption.ToString().Split(New Char() { "_"c }).Length)
					IL_105:
					num2 = 12
				Next
				IL_117:
				num2 = 13
				c1FlexGrid.Rows.Fixed = num3
				IL_127:
				num2 = 14
				If num3 <= 1 Then
					GoTo IL_1F8
				End If
				IL_131:
				num2 = 15
				Dim num5 As Integer = num3 - 1
				For j As Integer = 0 To num5
					IL_13E:
					num2 = 16
					c1FlexGrid.Rows(j).AllowMerging = True
					IL_155:
					num2 = 17
				Next
				IL_164:
				num2 = 18
				Dim fixed2 As Integer = c1FlexGrid.Cols.Fixed
				Dim num6 As Integer = c1FlexGrid.Cols.Count - 1
				For k As Integer = fixed2 To num6
					IL_187:
					num2 = 19
					Dim array As String() = c1FlexGrid.Cols(k).Caption.Split(New Char() { "_"c })
					IL_1AF:
					num2 = 20
					Dim num7 As Integer = num3 - 1
					For l As Integer = 0 To num7
						IL_1BC:
						num2 = 21
						c1FlexGrid(l, k) = array(Math.Min(l, array.Length - 1))
						IL_1DA:
						num2 = 22
					Next
					IL_1E9:
					num2 = 23
				Next
				IL_1F8:
				num2 = 24
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_212:
					num2 = 25
					If dataTable Is Me.o0__0._. Then
						IL_21F:
						num2 = 26
						Dim num8 As Integer = num3 - 1
						For m As Integer = 0 To num8
							IL_22C:
							num2 = 27
							c1FlexGrid.Rows(m).Height = OO_00oOO.Tables(dataTable.Name).foxGrid.Rows(m).Height
							IL_269:
							num2 = 28
						Next
					End If
					IL_278:
					num2 = 29
				End While
				IL_284:
				num2 = 30
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_292:
				GoTo IL_360
				IL_297:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_321:
				GoTo IL_355
				IL_323:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_333:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_323
			End Try
			IL_355:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_360:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060035C8 RID: 13768 RVA: 0x0016B360 File Offset: 0x00169560
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001617 RID: 5655
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001618 RID: 5656
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001619 RID: 5657
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400161A RID: 5658
		Private <<EMPTY_NAME>> As DataView

		' Token: 0x0400161B RID: 5659
		Private <<EMPTY_NAME>> As DataTable
	End Class
End Namespace
