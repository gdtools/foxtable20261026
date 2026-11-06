Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200025B RID: 603
	<DesignerGenerated()>
	Friend Class O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000
		Inherits DropDownForm

		' Token: 0x06001C49 RID: 7241 RVA: 0x000B2C14 File Offset: 0x000B0E14
		Public Sub New()
			Me.o_O0_O.O_OOO.()
		End Sub

		' Token: 0x06001C4A RID: 7242 RVA: 0x000B2C24 File Offset: 0x000B0E24
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oo_.000o. IsNot Nothing Then
					Me.oo_.000o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001C4B RID: 7243 RVA: 0x000B2C64 File Offset: 0x000B0E64
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.oo_.000o.(New TreeView())
			MyBase.SuspendLayout()
			Me.o_O0_O.O_OOO.().CheckBoxes = True
			Me.o_O0_O.O_OOO.().Dock = DockStyle.Fill
			Me.o_O0_O.O_OOO.().ItemHeight = 16
			Me.o_O0_O.O_OOO.().Location = New Point(0, 0)
			Me.o_O0_O.O_OOO.().Name = "tre"
			Me.o_O0_O.O_OOO.().Size = New Size(262, 339)
			Me.o_O0_O.O_OOO.().TabIndex = 0
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(262, 339)
			MyBase.Controls.Add(Me.o_O0_O.O_OOO.())
			MyBase.Name = "O.O...0."
			Me.Text = "frmJoinColumnSelecter"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06001C4C RID: 7244 RVA: 0x000B2D4E File Offset: 0x000B0F4E
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As TreeView
			Return Me.oo_.000o.
		End Function

		' Token: 0x06001C4D RID: 7245 RVA: 0x000B2D58 File Offset: 0x000B0F58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As TreeViewEventHandler = AddressOf Me.oo_.000o.
			Dim treeView As TreeView = Me.oo_.000o.
			If treeView IsNot Nothing Then
				RemoveHandler treeView.AfterCheck, value
			End If
			Me.oo_.000o. = A_0
			treeView = Me.oo_.000o.
			If treeView IsNot Nothing Then
				AddHandler treeView.AfterCheck, value
			End If
		End Sub

		' Token: 0x06001C4E RID: 7246 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.oo_.000o. Then
					GoTo IL_385
				End If
				IL_14:
				num2 = 4
				If A_1.Action <> TreeViewAction.ByMouse AndAlso A_1.Action <> TreeViewAction.ByKeyboard Then
					GoTo IL_9E
				End If
				IL_28:
				num2 = 5
				If A_1.Node.Level <> 0 Then
					GoTo IL_8A
				End If
				IL_37:
				num2 = 6
				Dim enumerator As IEnumerator = A_1.Node.Nodes.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					IL_5B:
					num2 = 7
					treeNode.Checked = False
					IL_65:
					num2 = 8
				End While
				IL_70:
				num2 = 9
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_9E
				End If
				GoTo IL_9E
				IL_8A:
				num2 = 11
				A_1.Node.Parent.Checked = False
				IL_9E:
				num2 = 12
				Dim list As List(Of String) = New List(Of String)()
				IL_A8:
				num2 = 13
				If Operators.CompareString(MyBase.OwnerControl.Text, "", True) <= 0 Then
					GoTo IL_EA
				End If
				IL_C4:
				num2 = 14
				list.AddRange(MyBase.OwnerControl.Text.Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries))
				IL_EA:
				num2 = 15
				If A_1.Node.Level <> 0 Then
					GoTo IL_11D
				End If
				IL_FA:
				num2 = 16
				Dim text As String = Oo00.o.oo_0.(A_1.Node.Name) + ".*"
				GoTo IL_1E1
				IL_11D:
				num2 = 18
				Dim text2 As String = A_1.Node.Name
				IL_12D:
				num2 = 19
				Dim flag As Boolean = False
				IL_133:
				num2 = 20
				For Each c As Char In text2
					IL_14A:
					num2 = 21
					If Not Char.IsLetterOrDigit(c) Then
						IL_156:
						num2 = 22
						flag = True
						Exit For
					End If
					IL_15E:
					num2 = 24
				Next
				IL_172:
				num2 = 25
				If Not text2.StartsWith("_") AndAlso Not flag Then
					GoTo IL_19D
				End If
				IL_187:
				num2 = 26
				text2 = "[" + text2 + "]"
				IL_19D:
				num2 = 27
				If Me.o_O0_O.O_OOO.(A_1.Node.Name) <= 1 Then
					GoTo IL_1DB
				End If
				IL_1B4:
				num2 = 28
				text = Oo00.o.oo_0.(A_1.Node.Parent.Name) + "." + text2
				GoTo IL_1E1
				IL_1DB:
				num2 = 30
				text = text2
				IL_1E1:
				num2 = 31
				If Not list.Contains(text) AndAlso Not list.Contains(text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })) Then
					GoTo IL_2A5
				End If
				IL_21B:
				num2 = 32
				If A_1.Node.Checked Then
					GoTo IL_319
				End If
				IL_22E:
				num2 = 33
				If Not list.Contains(text) Then
					GoTo IL_247
				End If
				IL_23B:
				num2 = 34
				list.Remove(text)
				IL_247:
				num2 = 35
				If Not list.Contains(text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })) Then
					GoTo IL_319
				End If
				IL_277:
				num2 = 36
				list.Remove(text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c }))
				GoTo IL_319
				IL_2A5:
				num2 = 38
				If Not A_1.Node.Checked Then
					GoTo IL_2C2
				End If
				IL_2B5:
				num2 = 39
				list.Add(text)
				GoTo IL_319
				IL_2C2:
				num2 = 41
				text = A_1.Node.Name
				IL_2D1:
				num2 = 42
				If Not list.Contains(text) Then
					GoTo IL_2EC
				End If
				IL_2DE:
				num2 = 43
				list.Remove(text)
				GoTo IL_319
				IL_2EC:
				num2 = 45
				text = "[" + text + "]"
				IL_300:
				num2 = 46
				If Not list.Contains(text) Then
					GoTo IL_319
				End If
				IL_30D:
				num2 = 47
				list.Remove(text)
				IL_319:
				num2 = 48
				text = ""
				IL_322:
				num2 = 49
				Dim enumerator2 As List(Of String).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim str As String = enumerator2.Current
					IL_339:
					num2 = 50
					text = text + "," + str
					IL_34A:
					num2 = 51
				End While
				IL_356:
				num2 = 52
				CType(enumerator2, IDisposable).Dispose()
				IL_366:
				num2 = 53
				MyBase.OwnerControl.Value = text.Trim(New Char() { ","c })
				IL_385:
				GoTo IL_4AF
				IL_38A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_470:
				GoTo IL_4A4
				IL_472:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_482:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_472
			End Try
			IL_4A4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4AF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C4F RID: 7247 RVA: 0x000B327C File Offset: 0x000B147C
		Private Overloads Function <<EMPTY_NAME>>(A_0 As String) As Integer
			Dim num As Integer
			Try
				For Each obj As Object In Me.o_O0_O.O_OOO.().Nodes
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					Try
						Dim enumerator2 As IEnumerator = treeNode.Nodes.GetEnumerator()
						While enumerator2.MoveNext()
							If Operators.CompareString(CType(enumerator2.Current, TreeNode).Name, A_0, True) = 0 Then
								num += 1
								Exit While
							End If
						End While
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return num
		End Function

		' Token: 0x04000C04 RID: 3076
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000C05 RID: 3077
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x04000C06 RID: 3078
		Friend <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
