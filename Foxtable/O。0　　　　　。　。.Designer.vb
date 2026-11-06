Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000265 RID: 613
	<DesignerGenerated()>
	Friend Class O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002
		Inherits DropDownForm

		' Token: 0x06001D16 RID: 7446 RVA: 0x000B840C File Offset: 0x000B660C
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OooOoOo_.o. IsNot Nothing Then
					Me.OooOoOo_.o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001D17 RID: 7447 RVA: 0x000B844C File Offset: 0x000B664C
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.OooOoOo_.o.(New System.Windows.Forms.TreeView())
			MyBase.SuspendLayout()
			Me.o.00_O_.().Dock = DockStyle.Fill
			Me.o.00_O_.().Location = New Point(0, 0)
			Me.o.00_O_.().Name = "TreeView1"
			Me.o.00_O_.().Size = New Size(244, 327)
			Me.o.00_O_.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.BorderStyle = BorderStyle.None
			MyBase.ClientSize = New Size(244, 327)
			MyBase.Controls.Add(Me.o.00_O_.())
			MyBase.Name = "frmDropTree"
			Me.Text = "DropTree"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001D18 RID: 7448 RVA: 0x000B8524 File Offset: 0x000B6724
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As System.Windows.Forms.TreeView
			Return Me.OooOoOo_.o.
		End Function

		' Token: 0x06001D19 RID: 7449 RVA: 0x000B852C File Offset: 0x000B672C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.OooOoOo_.o.
			Dim oooOoOo_.o. As System.Windows.Forms.TreeView = Me.OooOoOo_.o.
			If oooOoOo_.o. IsNot Nothing Then
				RemoveHandler oooOoOo_.o..AfterSelect, value
			End If
			Me.OooOoOo_.o. = A_0
			oooOoOo_.o. = Me.OooOoOo_.o.
			If oooOoOo_.o. IsNot Nothing Then
				AddHandler oooOoOo_.o..AfterSelect, value
			End If
		End Sub

		' Token: 0x06001D1A RID: 7450 RVA: 0x000B8570 File Offset: 0x000B6770
		Friend Sub New(A_0 As String, A_1 As String, Optional A_2 As Boolean = True)
			MyBase.PostChanges += AddressOf Me.o.00_O_.
			Me.OooOoOo_.o. = "\"c
			Me.O0ooOO_o0.00. = "|"c
			Me.o.00_O_.()
			Me.OooOoOo_.o. = A_1.Split(New Char() { "|"c })
			Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me.o.00_O_.())
			If A_2 Then
				treeView.Load(A_0)
				Return
			End If
			treeView.LoadFromString(A_0)
		End Sub

		' Token: 0x06001D1B RID: 7451 RVA: 0x000B85E0 File Offset: 0x000B67E0
		Friend Sub New(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String, A_4 As Char, A_5 As String, A_6 As String)
			MyBase.PostChanges += AddressOf Me.o.00_O_.
			Me.OooOoOo_.o. = "\"c
			Me.O0ooOO_o0.00. = "|"c
			Me.o.00_O_.()
			Me.o_Oo.O0o__o0O. = A_0
			Me.o_Oo.O0o__o0O. = A_1
			Me.oooo.00oO0OoOO. = A_2
			Me.OooOoOo_.o. = A_3.Split(New Char() { "|"c })
			Me.OooOoOo_.o. = A_4
			Me.o0_0o__o._. = A_5
			Me.O0_O_OO_0._o. = A_6
			Me.o_0.o0O.()
		End Sub

		' Token: 0x06001D1C RID: 7452 RVA: 0x000B8668 File Offset: 0x000B6868
		Friend Sub <<EMPTY_NAME>>()
			If Me.o_Oo.O0o__o0O. IsNot Nothing Then
				If Me.o_Oo.O0o__o0O..StartsWith("{") AndAlso Me.o_Oo.O0o__o0O..EndsWith("}") Then
					New Foxtable.WinForm.TreeView(Me.o.00_O_.()).CreateDataTree(Me.o_Oo.O0o__o0O..BaseTable, Me.o_Oo.O0o__o0O..Trim(New Char() { "{"c, "}"c }), Conversions.ToString(Me.OooOoOo_.o.), Me.o0_0o__o._., Me.O0_O_OO_0._o., "", Me.oooo.00oO0OoOO.)
					Return
				End If
				oOO0oo_o0.O.ooooo.(Me.o.00_O_.(), Me.o_Oo.O0o__o0O..BaseTable, Me.o0_0o__o._., Me.O0_O_OO_0._o., Me.oooo.00oO0OoOO., Me.o_Oo.O0o__o0O., True)
			End If
		End Sub

		' Token: 0x06001D1D RID: 7453 RVA: 0x000B872C File Offset: 0x000B692C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OooOoOo_.o. IsNot Nothing AndAlso MyBase.DialogResult = DialogResult.OK AndAlso Me.o.00_O_.().SelectedNode IsNot Nothing Then
				Dim a_ As String = "ValidateEdit"
				Dim table As Table = Me.OooOoOo_.o..Table
				Dim list As List(Of String) = New List(Of String)()
				Dim array As String()
				If Operators.CompareString(Me.oooo.00oO0OoOO., "", True) > 0 Then
					Dim selectedNode As System.Windows.Forms.TreeNode = Me.o.00_O_.().SelectedNode
					If selectedNode.Tag Is Nothing Then
						Return
					End If
					array = selectedNode.Tag.ToString().Split(New Char() { vbTab })
				Else
					array = Me.o.00_O_.().SelectedNode.FullPath.Split(New Char() { "\"c })
				End If
				If Me.OooOoOo_.o. Then
					For Each text As String In array
						If text.IndexOf(Me.O0ooOO_o0.00.) >= 0 Then
							list.AddRange(text.Split(New Char() { Me.O0ooOO_o0.00. }))
						Else
							list.Add(text)
						End If
					Next
				Else
					list.AddRange(array)
				End If
				Dim num As Integer = Me.OooOoOo_.o..Length
				Dim num2 As Integer = num - 1
				For j As Integer = 0 To num2
					Dim text2 As String = Me.OooOoOo_.o.(j)
					If Operators.CompareString(text2, "", True) <> 0 AndAlso Me.OooOoOo_.o..Table.DataTable.DataCols.Contains(text2) Then
						Dim a_2 As String
						If list.Count > j Then
							a_2 = list(j)
						Else
							a_2 = ""
						End If
						Dim validateEditEventArgs As ValidateEditEventArgs = New ValidateEditEventArgs(table, Me.OooOoOo_.o., table.Cols(text2), a_2, Nothing)
						O_O0OO.OoO_o.oO0o0O.(table.DataTable.o_0_00_.oo0O0., a_, New Object() { validateEditEventArgs }, False, table.DataTable.Name, False)
						If Not validateEditEventArgs.Cancel AndAlso table.foxGrid.FindForm() IsNot Nothing AndAlso table.DataTable.GlobalHandler.ValidateEdit Then
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, New Object() { validateEditEventArgs }, False, "全局表事件", False)
						End If
						If validateEditEventArgs.Cancel Then
							Return
						End If
						CType(MyBase.OwnerControl.Parent, C1FlexGrid).FinishEditing(True)
					End If
				Next
				Dim num3 As Integer = num - 1
				For k As Integer = 0 To num3
					Dim text3 As String = Me.OooOoOo_.o.(k)
					If Operators.CompareString(text3, "", True) <> 0 AndAlso Me.OooOoOo_.o..Table.DataTable.DataCols.Contains(text3) Then
						Try
							If list.Count > k Then
								Me.OooOoOo_.o.(text3) = list(k)
							Else
								Me.OooOoOo_.o.(text3) = Nothing
							End If
						Catch a_3 As Exception
							ooO.oOo0Oo.o.(a_3, "")
						End Try
						Dim rowColEventArgs As RowColEventArgs = New RowColEventArgs(table, Me.OooOoOo_.o., table.Cols(text3), Nothing)
						Dim o0O00o_.0Oo. As MethodInfo = table.DataTable.O0O00o_.0Oo.
						If o0O00o_.0Oo. IsNot Nothing Then
							Try
								o0O00o_.0Oo..Invoke(Nothing, New Object() { rowColEventArgs })
							Catch a_4 As Exception
								ooO.oOo0Oo.o.(a_4, "表，" + table.DataTable.Name + "，AfterEdit")
							End Try
						End If
					End If
				Next
			End If
		End Sub

		' Token: 0x06001D1E RID: 7454 RVA: 0x000B8AB4 File Offset: 0x000B6CB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If Me.o.00_O_.().SelectedNode IsNot Nothing AndAlso Me.O0ooOO_o0.00. Then
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x04000C33 RID: 3123
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C34 RID: 3124
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.TreeView

		' Token: 0x04000C35 RID: 3125
		Friend <<EMPTY_NAME>> As String()

		' Token: 0x04000C36 RID: 3126
		Friend <<EMPTY_NAME>> As Char

		' Token: 0x04000C37 RID: 3127
		Friend <<EMPTY_NAME>> As Char

		' Token: 0x04000C38 RID: 3128
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000C39 RID: 3129
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x04000C3A RID: 3130
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000C3B RID: 3131
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000C3C RID: 3132
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000C3D RID: 3133
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04000C3E RID: 3134
		Friend <<EMPTY_NAME>> As Row

		' Token: 0x04000C3F RID: 3135
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
