Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000048 RID: 72
	Friend Class oo0000o0oo
		Inherits UITypeEditor

		' Token: 0x060002B2 RID: 690 RVA: 0x00005EB1 File Offset: 0x000040B1
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As TreeView
			Return Me.O0._O.
		End Function

		' Token: 0x060002B3 RID: 691 RVA: 0x00005EBC File Offset: 0x000040BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As TreeView)
			Dim value As MouseEventHandler = AddressOf Me.O_O_.0oooo_oo.
			Dim value2 As TreeViewEventHandler = AddressOf Me.O_O_.0oooo_oo.
			Dim value3 As TreeNodeMouseClickEventHandler = AddressOf Me.O_O_.0oooo_oo.
			Dim o0._O. As TreeView = Me.O0._O.
			If o0._O. IsNot Nothing Then
				RemoveHandler o0._O..MouseDown, value
				RemoveHandler o0._O..AfterSelect, value2
				RemoveHandler o0._O..NodeMouseClick, value3
			End If
			Me.O0._O. = A_0
			o0._O. = Me.O0._O.
			If o0._O. IsNot Nothing Then
				AddHandler o0._O..MouseDown, value
				AddHandler o0._O..AfterSelect, value2
				AddHandler o0._O..NodeMouseClick, value3
			End If
		End Sub

		' Token: 0x060002B4 RID: 692 RVA: 0x00005F38 File Offset: 0x00004138
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.DropDown
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002B5 RID: 693 RVA: 0x00005F60 File Offset: 0x00004160
		Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
			Dim num As Integer
			Dim result As Object
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If context IsNot Nothing AndAlso context.Instance IsNot Nothing AndAlso provider IsNot Nothing Then
					GoTo IL_20
				End If
				IL_17:
				num2 = 3
				result = value
				GoTo IL_277
				IL_20:
				num2 = 4
				Me.O0._O. = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_3D:
				num2 = 5
				If Me.O0._O. IsNot Nothing Then
					GoTo IL_50
				End If
				IL_47:
				num2 = 6
				result = value
				GoTo IL_277
				IL_50:
				num2 = 7
				Me.O_O_.0oooo_oo.(New TreeView())
				IL_5D:
				num2 = 8
				Me.O_O_.0oooo_oo.().Size = New Size(200, 200)
				IL_79:
				num2 = 9
				Me.O_O_.0oooo_oo.().PathSeparator = "."
				IL_8C:
				num2 = 10
				Me.O_O_.0oooo_oo.().Nodes.Add("(无)")
				IL_A5:
				num2 = 11
				oOO0oo_o0.o.O0o000_.(Me.O_O_.0oooo_oo.())
				IL_B3:
				num2 = 12
				If Operators.CompareString(Conversions.ToString(value), "", True) <= 0 Then
					GoTo IL_E7
				End If
				IL_CA:
				num2 = 13
				Me.O_O_.0oooo_oo.(Me.O_O_.0oooo_oo.().Nodes, Conversions.ToString(value))
				GoTo IL_117
				IL_E7:
				num2 = 15
				If Operators.CompareString(oo0000o0oo.O0._O., "", True) <= 0 Then
					GoTo IL_117
				End If
				IL_FD:
				num2 = 16
				Me.O_O_.0oooo_oo.(Me.O_O_.0oooo_oo.().Nodes, oo0000o0oo.O0._O.)
				IL_117:
				num2 = 17
				Me.O0._O. = False
				IL_121:
				num2 = 18
				Me.oO_.0Oo. = False
				IL_12B:
				num2 = 19
				Me.O0._O..DropDownControl(Me.O_O_.0oooo_oo.())
				IL_13F:
				num2 = 20
				If Me.O_O_.0oooo_oo.().SelectedNode IsNot Me.O_O_.0oooo_oo.().Nodes(0) Then
					GoTo IL_16E
				End If
				IL_160:
				num2 = 21
				result = ""
				GoTo IL_277
				IL_16E:
				num2 = 23
				If Me.O_O_.0oooo_oo.().SelectedNode Is Nothing OrElse Not Me.oO_.0Oo. Then
					GoTo IL_25A
				End If
				IL_18C:
				num2 = 24
				If Not(TypeOf context.Instance Is o_0oooo_OO) Then
					GoTo IL_22C
				End If
				IL_19F:
				num2 = 25
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is PropertyBase) Then
					GoTo IL_22C
				End If
				IL_1B9:
				num2 = 26
				Dim a_ As ControlTypeEnum = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), PropertyBase).Type
				IL_1D8:
				num2 = 27
				If Me.O_O_.0oooo_oo.().SelectedNode.Tag Is Nothing Then
					GoTo IL_22C
				End If
				IL_1ED:
				num2 = 28
				Dim a_2 As DataCol = CType(Me.O_O_.0oooo_oo.().SelectedNode.Tag, DataCol)
				IL_207:
				num2 = 29
				If ooO_0O.o_O0.O_.(a_, Me.O_O_.0oooo_oo.().SelectedNode.FullPath, a_2) Then
					GoTo IL_22C
				End If
				IL_225:
				num2 = 30
				result = value
				GoTo IL_277
				IL_22C:
				num2 = 31
				oo0000o0oo.O0._O. = Me.O_O_.0oooo_oo.().SelectedNode.FullPath
				IL_244:
				num2 = 32
				result = Me.O_O_.0oooo_oo.().SelectedNode.FullPath
				GoTo IL_277
				IL_25A:
				num2 = 33
				Me.O_O_.0oooo_oo.().Dispose()
				IL_268:
				num2 = 34
				Me.O_O_.0oooo_oo.(Nothing)
				IL_272:
				num2 = 35
				result = value
				IL_277:
				GoTo IL_359
				IL_27C:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_31A:
				GoTo IL_34E
				IL_31C:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_32C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_31C
			End Try
			IL_34E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_359:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060002B6 RID: 694 RVA: 0x000062EC File Offset: 0x000044EC
		Private Function <<EMPTY_NAME>>(A_0 As TreeNodeCollection, A_1 As String) As Boolean
			Dim result As Boolean
			Try
				For Each obj As Object In A_0
					Dim treeNode As TreeNode = CType(obj, TreeNode)
					If Operators.CompareString(treeNode.FullPath, A_1, True) = 0 Then
						Me.O_O_.0oooo_oo.().SelectedNode = treeNode
						result = True
						Exit For
					End If
					If Me.O_O_.0oooo_oo.(treeNode.Nodes, A_1) Then
						result = True
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return result
		End Function

		' Token: 0x060002B7 RID: 695 RVA: 0x00006370 File Offset: 0x00004570
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Me.O0._O. = True
		End Sub

		' Token: 0x060002B8 RID: 696 RVA: 0x0000637C File Offset: 0x0000457C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			If(Me.O0._O. IsNot Nothing And Me.O0._O.) AndAlso Me.O_O_.0oooo_oo.().SelectedNode IsNot Nothing AndAlso Me.O_O_.0oooo_oo.().SelectedNode.GetNodeCount(True) <= 0 Then
				Me.oO_.0Oo. = True
				Me.O0._O..CloseDropDown()
			End If
		End Sub

		' Token: 0x060002B9 RID: 697 RVA: 0x000063CE File Offset: 0x000045CE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeNodeMouseClickEventArgs)
			If A_1.Node.Nodes.Count = 0 Then
				Me.O_O_.0oooo_oo.(RuntimeHelpers.GetObjectValue(A_0), New TreeViewEventArgs(A_1.Node))
			End If
		End Sub

		' Token: 0x04000068 RID: 104
		Private <<EMPTY_NAME>> As IWindowsFormsEditorService

		' Token: 0x04000069 RID: 105
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TreeView

		' Token: 0x0400006A RID: 106
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400006B RID: 107
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400006C RID: 108
		Private Shared <<EMPTY_NAME>> As String
	End Class
End Namespace
