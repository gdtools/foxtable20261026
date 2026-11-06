Imports System
Imports System.Collections
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
	' Token: 0x02000332 RID: 818
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x060030D0 RID: 12496 RVA: 0x0013C708 File Offset: 0x0013A908
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O_o_O.0. IsNot Nothing Then
					Me.O_o_O.0..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x060030D1 RID: 12497 RVA: 0x0013C748 File Offset: 0x0013A948
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.O0O.Oo.(New OpenFileDialog())
			Me.oo__.0o0_Oo.(New C1Button())
			Me.O0O.Oo.(New C1FlexGrid())
			Me.O0O.Oo.(New C1ComboBox())
			Me.O0O.Oo.(New C1Button())
			Me.O_.0__.(New C1Button())
			Me.o0.OO_OOO0oOO.().BeginInit()
			MyBase.SuspendLayout()
			Me.o0.OO_OOO0oOO.().Filter = "XML文件(*.xml)|*.XML"
			Me.Oo._o0oo_o0_O0.().Location = New Point(21, 422)
			Me.Oo._o0oo_o0_O0.().Name = "Button1"
			Me.Oo._o0oo_o0_O0.().Size = New Size(75, 23)
			Me.Oo._o0oo_o0_O0.().TabIndex = 2
			Me.Oo._o0oo_o0_O0.().Text = "删除列"
			Me.Oo._o0oo_o0_O0.().UseVisualStyleBackColor = True
			Me.o0.OO_OOO0oOO.().AllowDragging = 0
			Me.o0.OO_OOO0oOO.().AllowEditing = False
			Me.o0.OO_OOO0oOO.().AllowSorting = 0
			Me.o0.OO_OOO0oOO.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.o0.OO_OOO0oOO.().Location = New Point(21, 57)
			Me.o0.OO_OOO0oOO.().Name = "Grid"
			Me.o0.OO_OOO0oOO.().Rows.Count = 1
			Me.o0.OO_OOO0oOO.().Rows.DefaultSize = 20
			Me.o0.OO_OOO0oOO.().SelectionMode = 6
			Me.o0.OO_OOO0oOO.().Size = New Size(646, 345)
			Me.o0.OO_OOO0oOO.().TabIndex = 1
			Me.o0.OO_OOO0oOO.().DropDownStyle = 1
			Me.o0.OO_OOO0oOO.().Location = New Point(21, 21)
			Me.o0.OO_OOO0oOO.().Name = "lstTables"
			Me.o0.OO_OOO0oOO.().Size = New Size(374, 20)
			Me.o0.OO_OOO0oOO.().TabIndex = 0
			Me.o0o_OooO0.oO.().DialogResult = DialogResult.Cancel
			Me.o0o_OooO0.oO.().Location = New Point(592, 422)
			Me.o0o_OooO0.oO.().Name = "Button3"
			Me.o0o_OooO0.oO.().Size = New Size(75, 23)
			Me.o0o_OooO0.oO.().TabIndex = 4
			Me.o0o_OooO0.oO.().Text = "取消"
			Me.o0o_OooO0.oO.().UseVisualStyleBackColor = True
			Me.o0.OO_OOO0oOO.().Location = New Point(507, 422)
			Me.o0.OO_OOO0oOO.().Name = "Button2"
			Me.o0.OO_OOO0oOO.().Size = New Size(75, 23)
			Me.o0.OO_OOO0oOO.().TabIndex = 3
			Me.o0.OO_OOO0oOO.().Text = "确定"
			Me.o0.OO_OOO0oOO.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(694, 464)
			MyBase.Controls.Add(Me.Oo._o0oo_o0_O0.())
			MyBase.Controls.Add(Me.o0.OO_OOO0oOO.())
			MyBase.Controls.Add(Me.o0.OO_OOO0oOO.())
			MyBase.Controls.Add(Me.o0o_OooO0.oO.())
			MyBase.Controls.Add(Me.o0.OO_OOO0oOO.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O....ooo"
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "导入"
			Me.o0.OO_OOO0oOO.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060030D2 RID: 12498 RVA: 0x0013CAC4 File Offset: 0x0013ACC4
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As OpenFileDialog
			Return Me.O_o_O.0.
		End Function

		' Token: 0x060030D3 RID: 12499 RVA: 0x0013CACC File Offset: 0x0013ACCC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OpenFileDialog)
			Me.O_o_O.0. = A_0
		End Sub

		' Token: 0x060030D4 RID: 12500 RVA: 0x0013CAD5 File Offset: 0x0013ACD5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0O.Oo.
		End Function

		' Token: 0x060030D5 RID: 12501 RVA: 0x0013CAE0 File Offset: 0x0013ACE0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.OOo_0oO__.
			Dim o0O.Oo. As C1Button = Me.O0O.Oo.
			If o0O.Oo. IsNot Nothing Then
				RemoveHandler o0O.Oo..Click, value
			End If
			Me.O0O.Oo. = A_0
			o0O.Oo. = Me.O0O.Oo.
			If o0O.Oo. IsNot Nothing Then
				AddHandler o0O.Oo..Click, value
			End If
		End Sub

		' Token: 0x060030D6 RID: 12502 RVA: 0x0013CB23 File Offset: 0x0013AD23
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_o_O.0.
		End Function

		' Token: 0x060030D7 RID: 12503 RVA: 0x0013CB2B File Offset: 0x0013AD2B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.O_o_O.0. = A_0
		End Sub

		' Token: 0x060030D8 RID: 12504 RVA: 0x0013CB34 File Offset: 0x0013AD34
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O_o_O.0.
		End Function

		' Token: 0x060030D9 RID: 12505 RVA: 0x0013CB3C File Offset: 0x0013AD3C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.O_.0__.
			Dim o_o_O.0. As C1ComboBox = Me.O_o_O.0.
			If o_o_O.0. IsNot Nothing Then
				o_o_O.0..SelectedIndexChanged -= eventHandler
			End If
			Me.O_o_O.0. = A_0
			o_o_O.0. = Me.O_o_O.0.
			If o_o_O.0. IsNot Nothing Then
				o_o_O.0..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x060030DA RID: 12506 RVA: 0x0013CB7F File Offset: 0x0013AD7F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o._Oo0o_.
		End Function

		' Token: 0x060030DB RID: 12507 RVA: 0x0013CB87 File Offset: 0x0013AD87
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o._Oo0o_. = A_0
		End Sub

		' Token: 0x060030DC RID: 12508 RVA: 0x0013CB90 File Offset: 0x0013AD90
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_.0__.
		End Function

		' Token: 0x060030DD RID: 12509 RVA: 0x0013CB98 File Offset: 0x0013AD98
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0.OO_OOO0oOO.
			Dim o_.0__. As C1Button = Me.O_.0__.
			If o_.0__. IsNot Nothing Then
				RemoveHandler o_.0__..Click, value
			End If
			Me.O_.0__. = A_0
			o_.0__. = Me.O_.0__.
			If o_.0__. IsNot Nothing Then
				AddHandler o_.0__..Click, value
			End If
		End Sub

		' Token: 0x060030DE RID: 12510 RVA: 0x0013CBDB File Offset: 0x0013ADDB
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.o0.OO_OOO0oOO.
			Me.o0.OO_OOO0oOO.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x060030DF RID: 12511 RVA: 0x0013CC10 File Offset: 0x0013AE10
		Friend Function <<EMPTY_NAME>>() As Boolean
			Me.O_o_O.0. = New DataSet()
			Me.O_o_O.0..ReadXml(Me.O_o_O.0.)
			Dim result As Boolean
			If Me.O_o_O.0..Tables.Count > 0 Then
				Me.o0.OO_OOO0oOO.().Items.Add("请选择要导入的表...")
				Try
					For Each obj As Object In Me.O_o_O.0..Tables
						Dim dataTable As DataTable = CType(obj, DataTable)
						Me.o0.OO_OOO0oOO.().Items.Add(dataTable.TableName)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.o0.OO_OOO0oOO.().Items.Count = 2 Then
					Me.o0.OO_OOO0oOO.().SelectedIndex = 1
				Else
					Me.o0.OO_OOO0oOO.().SelectedIndex = 0
				End If
				result = True
			End If
			Return result
		End Function

		' Token: 0x060030E0 RID: 12512 RVA: 0x0013CCFC File Offset: 0x0013AEFC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0.OO_OOO0oOO.().SelectedIndex = 0 Then
				Me.o0.OO_OOO0oOO.().DataSource = Nothing
				Return
			End If
			Me.o0.OO_OOO0oOO.().DataSource = Me.O_o_O.0..Tables(Me.o0.OO_OOO0oOO.().SelectedItem.ToString())
			For i As Integer = Me.o0.OO_OOO0oOO.().Cols.Count - 1 To 1 Step -1
				If o_O_o_oOoo__.oO.O_..Contains(Me.o0.OO_OOO0oOO.().Cols(i).Name) Then
					Me.o0.OO_OOO0oOO.().Cols.Remove(i)
				End If
			Next
			Me.o0.OO_OOO0oOO.().AutoSizeCols()
		End Sub

		' Token: 0x060030E1 RID: 12513 RVA: 0x0013CDAC File Offset: 0x0013AFAC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0.OO_OOO0oOO.().Col >= Me.o0.OO_OOO0oOO.().Cols.Fixed Then
				Dim leftCol As Integer = Me.o0.OO_OOO0oOO.().Selection.LeftCol
				Dim rightCol As Integer = Me.o0.OO_OOO0oOO.().Selection.RightCol
				Dim num As Integer = leftCol
				Dim num2 As Integer = rightCol
				For i As Integer = num To num2
					Me.o0.OO_OOO0oOO.().Cols.Remove(leftCol)
				Next
			End If
		End Sub

		' Token: 0x060030E2 RID: 12514 RVA: 0x0013CE24 File Offset: 0x0013B024
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o0.OO_OOO0oOO.().SelectedIndex >= 1 Then
				Try
					Me.Cursor = Cursors.WaitCursor
					If Oo00.O____0O._0.(Me.o0.OO_OOO0oOO.(), Me.o0.OO_OOO0oOO.().SelectedItem.ToString()) Then
						MyBase.DialogResult = DialogResult.OK
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					Me.Cursor = Cursors.[Default]
				End Try
			End If
		End Sub

		' Token: 0x060030E3 RID: 12515 RVA: 0x0013CEB4 File Offset: 0x0013B0B4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001395 RID: 5013
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001396 RID: 5014
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x04001397 RID: 5015
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001398 RID: 5016
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001399 RID: 5017
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400139A RID: 5018
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400139B RID: 5019
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400139C RID: 5020
		Friend <<EMPTY_NAME>> As String

		' Token: 0x0400139D RID: 5021
		Friend <<EMPTY_NAME>> As DataSet
	End Class
End Namespace
