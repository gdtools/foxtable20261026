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
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000384 RID: 900
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3002\u3000\u3002\u3002\u30020
		Inherits Form

		' Token: 0x060039D6 RID: 14806 RVA: 0x0019010D File Offset: 0x0018E30D
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.o0.Oo__0Ooo0__. IsNot Nothing Then
				Me.o0.Oo__0Ooo0__..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060039D7 RID: 14807 RVA: 0x0019012C File Offset: 0x0018E32C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O0Oo.O.(New C1FlexGrid())
			Me.O0Oo.O.(New C1Button())
			Me.O.o_0_OO00o0O.(New C1Button())
			Me.o_O._0.(New C1Button())
			Me.O0Oo.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.O0Oo.O.().ColumnInfo = "2,1,0,20,0,0,Columns:"
			Me.O0Oo.O.().ExtendLastCol = True
			Me.O0Oo.O.().Location = New Point(12, 12)
			Me.O0Oo.O.().Name = "C1FlexGrid1"
			Me.O0Oo.O.().Rows.Count = 1
			Me.O0Oo.O.().Rows.DefaultSize = 19
			Me.O0Oo.O.().Rows.Fixed = 0
			Me.O0Oo.O.().Size = New Size(260, 342)
			Me.O0Oo.O.().TabIndex = 0
			Me.O0Oo.O.().SelectionMode = 3
			Me.O0Oo.O.().FocusRect = 0
			Me.oo.ooOOoo.().DialogResult = DialogResult.OK
			Me.oo.ooOOoo.().Location = New Point(278, 301)
			Me.oo.ooOOoo.().Name = "btnOK"
			Me.oo.ooOOoo.().Size = New Size(75, 23)
			Me.oo.ooOOoo.().TabIndex = 2
			Me.oo.ooOOoo.().Text = "确定"
			Me.oo.ooOOoo.().UseVisualStyleBackColor = True
			Me.Oo_O.OO.().DialogResult = DialogResult.Cancel
			Me.Oo_O.OO.().Location = New Point(278, 331)
			Me.Oo_O.OO.().Name = "btnCancel"
			Me.Oo_O.OO.().Size = New Size(75, 23)
			Me.Oo_O.OO.().TabIndex = 3
			Me.Oo_O.OO.().Text = "取消"
			Me.Oo_O.OO.().UseVisualStyleBackColor = True
			Me.o_0.0oO0_0O.().Location = New Point(278, 12)
			Me.o_0.0oO0_0O.().Name = "Button1"
			Me.o_0.0oO0_0O.().Size = New Size(75, 23)
			Me.o_0.0oO0_0O.().TabIndex = 1
			Me.o_0.0oO0_0O.().Text = "全选"
			Me.o_0.0oO0_0O.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(363, 367)
			MyBase.Controls.Add(Me.o_0.0oO0_0O.())
			MyBase.Controls.Add(Me.Oo_O.OO.())
			MyBase.Controls.Add(Me.oo.ooOOoo.())
			MyBase.Controls.Add(Me.O0Oo.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O0..o..."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择列"
			Me.O0Oo.O.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060039D8 RID: 14808 RVA: 0x00190436 File Offset: 0x0018E636
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.o0.Oo__0Ooo0__.
		End Function

		' Token: 0x060039D9 RID: 14809 RVA: 0x0019043E File Offset: 0x0018E63E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.o0.Oo__0Ooo0__. = A_0
		End Sub

		' Token: 0x060039DA RID: 14810 RVA: 0x00190447 File Offset: 0x0018E647
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0Oo.O.
		End Function

		' Token: 0x060039DB RID: 14811 RVA: 0x0019044F File Offset: 0x0018E64F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0Oo.O. = A_0
		End Sub

		' Token: 0x060039DC RID: 14812 RVA: 0x00190458 File Offset: 0x0018E658
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.o_0_OO00o0O.
		End Function

		' Token: 0x060039DD RID: 14813 RVA: 0x00190460 File Offset: 0x0018E660
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O.o_0_OO00o0O. = A_0
		End Sub

		' Token: 0x060039DE RID: 14814 RVA: 0x00190469 File Offset: 0x0018E669
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_O._0.
		End Function

		' Token: 0x060039DF RID: 14815 RVA: 0x00190474 File Offset: 0x0018E674
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oo.ooOOoo.
			Dim c1Button As C1Button = Me.o_O._0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_O._0. = A_0
			c1Button = Me.o_O._0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x060039E0 RID: 14816 RVA: 0x001904B8 File Offset: 0x0018E6B8
		Public Sub New(A_0 As OleDbConnection, A_1 As O0O, A_2 As String, A_3 As String)
			AddHandler MyBase.FormClosed, AddressOf Me.oo.ooOOoo.
			Me.o0.Oo__0Ooo0__. = a.Oooo_Oo_0__.0.().ToBitmap()
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj3 As Object
			Try
				IL_28:
				Dim num As Integer = 1
				Me.O0Oo.O.()
				IL_30:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_47:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_4E:
				num = 4
				If(A_0 Is Nothing OrElse Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0)) AndAlso (A_1 Is Nothing OrElse A_1.OO.OoO0. <> DataServerTypeEnum.Oracle) Then
					GoTo IL_B8
				End If
				IL_67:
				num = 5
				Dim array As String() = A_2.Split(New Char() { """"c, "."c }, StringSplitOptions.RemoveEmptyEntries)
				IL_82:
				num = 6
				Dim text As String = String.Concat(New String() { "select column_name from all_tab_columns Where  table_name = '", array(1), "' And owner = '", array(0), "'" })
				GoTo IL_107
				IL_B8:
				num = 8
				If A_2.IndexOf("].[") <= 0 OrElse Not A_2.StartsWith("[") OrElse Not A_2.EndsWith("]") Then
					GoTo IL_F3
				End If
				IL_E2:
				num = 9
				text = "Select * from " + A_2
				GoTo IL_107
				IL_F3:
				num = 11
				text = "Select * from [" + A_2 + "]"
				IL_107:
				num = 12
				Dim arrayList As ArrayList = New ArrayList()
				IL_111:
				num = 13
				Dim arrayList2 As ArrayList = New ArrayList()
				IL_11B:
				num = 14
				Dim array2 As String() = A_3.Split(New Char() { ","c })
				IL_132:
				num = 15
				For Each value As String In array2
					IL_145:
					num = 16
					arrayList.Add(value)
					IL_152:
					num = 17
				Next
				IL_163:
				num = 18
				Me.O0Oo.O.().Rows.Count = 0
				IL_177:
				num = 19
				Dim dataTable As DataTable = New DataTable()
				IL_181:
				num = 20
				If A_0 Is Nothing Then
					GoTo IL_1BB
				End If
				IL_187:
				num = 21
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, A_0)
				IL_193:
				num = 22
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				IL_1A1:
				num = 23
				If Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0) Then
					GoTo IL_1C8
				End If
				IL_1AC:
				num = 24
				oleDbDataAdapter.Fill(dataTable)
				GoTo IL_1C8
				IL_1BB:
				num = 26
				dataTable = A_1.O_0_O_0_o_.0.(text, True)
				IL_1C8:
				num = 27
				If dataTable.Rows.Count <> 0 Then
					GoTo IL_219
				End If
				IL_1D9:
				num = 28
				For Each dataColumn As DataColumn In dataTable.PrimaryKey
					IL_1F1:
					num = 29
					arrayList2.Add(dataColumn.ColumnName.ToLower())
					IL_208:
					num = 30
				Next
				IL_219:
				num = 31
				If A_0 Is Nothing OrElse Not o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0) Then
					GoTo IL_29E
				End If
				IL_227:
				num = 32
				Dim enumerator As IEnumerator = dataTable.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					IL_248:
					num = 33
					Me.O0Oo.O.().AddItem(vbTab + dataRow("COLUMN_NAME").ToString())
					IL_272:
					num = 34
				End While
				IL_27E:
				num = 35
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_344
				End If
				GoTo IL_344
				IL_29E:
				num = 37
				Dim c1FlexGrid As C1FlexGrid = Me.O0Oo.O.()
				IL_2A9:
				num = 38
				Dim enumerator2 As IEnumerator = dataTable.Columns.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataColumn2 As DataColumn = CType(obj2, DataColumn)
					IL_2CA:
					num = 39
					c1FlexGrid.AddItem(vbTab + dataColumn2.ColumnName)
					IL_2E6:
					num = 40
					If arrayList2.Contains(dataColumn2.ColumnName.ToLower()) Then
						IL_2FE:
						num = 41
						c1FlexGrid.SetCellImage(c1FlexGrid.Rows.Count - 1, 0, Me.o0.Oo__0Ooo0__.)
					End If
					IL_31D:
					num = 42
				End While
				IL_329:
				num = 43
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_341:
				c1FlexGrid = Nothing
				IL_344:
				num = 45
				Dim c1FlexGrid2 As C1FlexGrid = Me.O0Oo.O.()
				IL_34F:
				num = 46
				Dim num3 As Integer = c1FlexGrid2.Rows.Count - 1
				For k As Integer = 0 To num3
					IL_367:
					num = 47
					Dim str As String = c1FlexGrid2.Rows(k)(1).ToString()
					IL_385:
					num = 48
					If arrayList.Contains("[" + str + "]") Then
						IL_3A2:
						num = 49
						c1FlexGrid2.SetCellCheck(k, 1, 1)
					Else
						IL_3B2:
						num = 51
						c1FlexGrid2.SetCellCheck(k, 1, 2)
					End If
					IL_3C0:
					num = 52
				Next
				IL_3CF:
				c1FlexGrid2 = Nothing
				IL_3D2:
				GoTo IL_4FC
				IL_3D7:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_4BD:
				GoTo IL_4F1
				IL_4BF:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_4CF:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_4BF
			End Try
			IL_4F1:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4FC:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060039E1 RID: 14817 RVA: 0x001909E8 File Offset: 0x0018EBE8
		Friend Function <<EMPTY_NAME>>() As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim c1FlexGrid As C1FlexGrid = Me.O0Oo.O.()
			Dim num As Integer = c1FlexGrid.Rows.Count - 1
			For i As Integer = 0 To num
				If c1FlexGrid.GetCellCheck(i, 1) = 1 Then
					If stringBuilder.Length > 0 Then
						stringBuilder.Append(",")
					End If
					stringBuilder.Append("[" + c1FlexGrid(i, 1).ToString() + "]")
				End If
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060039E2 RID: 14818 RVA: 0x00190A68 File Offset: 0x0018EC68
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New StringBuilder()
			Dim c1FlexGrid As C1FlexGrid = Me.O0Oo.O.()
			Dim num As Integer = c1FlexGrid.Rows.Count - 1
			For i As Integer = 0 To num
				c1FlexGrid.SetCellCheck(i, 1, 1)
			Next
		End Sub

		' Token: 0x060039E3 RID: 14819 RVA: 0x00190AA7 File Offset: 0x0018ECA7
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040017F0 RID: 6128
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017F1 RID: 6129
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040017F2 RID: 6130
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017F3 RID: 6131
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017F4 RID: 6132
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017F5 RID: 6133
		Private <<EMPTY_NAME>> As String

		' Token: 0x040017F6 RID: 6134
		Private <<EMPTY_NAME>> As Image
	End Class
End Namespace
