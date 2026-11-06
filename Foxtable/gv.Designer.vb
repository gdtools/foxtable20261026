Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000196 RID: 406
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Class gv
		Inherits DropDownForm

		' Token: 0x06001358 RID: 4952 RVA: 0x0007D358 File Offset: 0x0007B558
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0.OO_o__00o0_. IsNot Nothing Then
					Me.o0.OO_o__00o0_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001359 RID: 4953 RVA: 0x0007D398 File Offset: 0x0007B598
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o0.OO_o__00o0_. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(gv))
			Me.o0.OO_o__00o0_.(New System.Windows.Forms.TreeView())
			Me.Oo_O.O000_oo0.(New ImageList(Me.o0.OO_o__00o0_.))
			MyBase.SuspendLayout()
			Me.Oo_O.O000_oo0.().Dock = DockStyle.Fill
			Me.Oo_O.O000_oo0.().ImageIndex = 0
			Me.Oo_O.O000_oo0.().ImageList = Me.Oo_O.O000_oo0.()
			Me.Oo_O.O000_oo0.().Location = New Point(0, 0)
			Me.Oo_O.O000_oo0.().Margin = New Padding(4, 4, 4, 4)
			Me.Oo_O.O000_oo0.().Name = "TreeView1"
			Me.Oo_O.O000_oo0.().SelectedImageIndex = 0
			Me.Oo_O.O000_oo0.().Size = New Size(285, 598)
			Me.Oo_O.O000_oo0.().TabIndex = 0
			Me.Oo_O.O000_oo0.().ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), ImageListStreamer)
			Me.Oo_O.O000_oo0.().TransparentColor = Color.Transparent
			Me.Oo_O.O000_oo0.().Images.SetKeyName(0, "Form")
			Me.Oo_O.O000_oo0.().Images.SetKeyName(1, "Folder")
			MyBase.AutoScaleDimensions = New SizeF(8F, 15F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(285, 598)
			MyBase.Controls.Add(Me.Oo_O.O000_oo0.())
			MyBase.Margin = New Padding(4, 4, 4, 4)
			MyBase.Name = "o.oO...O"
			Me.Text = "frmWinFormSelector"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0600135A RID: 4954 RVA: 0x0007D538 File Offset: 0x0007B738
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As System.Windows.Forms.TreeView
			Return Me.o0.OO_o__00o0_.
		End Function

		' Token: 0x0600135B RID: 4955 RVA: 0x0007D540 File Offset: 0x0007B740
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView)
			Me.o0.OO_o__00o0_. = A_0
		End Sub

		' Token: 0x0600135C RID: 4956 RVA: 0x0007D549 File Offset: 0x0007B749
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ImageList
			Return Me.o0.OO_o__00o0_.
		End Function

		' Token: 0x0600135D RID: 4957 RVA: 0x0007D551 File Offset: 0x0007B751
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As ImageList)
			Me.o0.OO_o__00o0_. = A_0
		End Sub

		' Token: 0x0600135E RID: 4958 RVA: 0x0007D55C File Offset: 0x0007B75C
		Public Sub New(A_0 As String)
			Me.Oo_O.O000_oo0.()
			Dim text As String = String.Concat(New String() { "([Type] = ", Conversions.ToString(229), "Or [Type] = ", Conversions.ToString(233), "Or [Type] = ", Conversions.ToString(35), ") And pth > ''" })
			Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me.Oo_O.O000_oo0.())
			treeView.CreateDataTree(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()), "pth", "\", text, "", "", "")
			Try
				For Each treeNode As Foxtable.WinForm.TreeNode In treeView.AllNodes
					treeNode.BaseNode.Tag = Nothing
				Next
			Finally
				Dim enumerator As List(Of Foxtable.WinForm.TreeNode).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim list As List(Of O_o__00Ooo) = New List(Of O_o__00Ooo)()
			Me.Oo_O.O000_oo0.(Me.Oo_O.O000_oo0.().Nodes, list)
			Try
				For Each o_o__00Ooo As O_o__00Ooo In list
					o_o__00Ooo.ImageIndex = 1
					o_o__00Ooo.SelectedImageIndex = 1
				Next
			Finally
				Dim enumerator2 As List(Of O_o__00Ooo).Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			text = "[Type] = " + Conversions.ToString(229) + "Or [Type] = " + Conversions.ToString(233)
			For Each dataRow As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()).[Select](text, "srt", DataViewRowState.CurrentRows)
				Dim o_o__00Ooo2 As O_o__00Ooo = New O_o__00Ooo()
				o_o__00Ooo2.Name = dataRow("Name").ToString()
				o_o__00Ooo2.Text = dataRow("Name").ToString()
				o_o__00Ooo2.Tag = dataRow
				Try
					For Each treeNode2 As System.Windows.Forms.TreeNode In list
						If Operators.CompareString(treeNode2.FullPath, dataRow("pth").ToString(), True) = 0 Then
							treeNode2.Nodes.Add(o_o__00Ooo2)
						End If
					Next
				Finally
					Dim enumerator3 As List(Of O_o__00Ooo).Enumerator
					CType(enumerator3, IDisposable).Dispose()
				End Try
				If o_o__00Ooo2.Parent Is Nothing Then
					Me.Oo_O.O000_oo0.().Nodes.Add(o_o__00Ooo2)
				End If
				o_o__00Ooo2.ImageIndex = 0
				o_o__00Ooo2.SelectedImageIndex = 0
			Next
			If Operators.CompareString(A_0, "", True) > 0 Then
				list.Clear()
				Me.Oo_O.O000_oo0.(Me.Oo_O.O000_oo0.().Nodes, list)
				Try
					For Each treeNode3 As System.Windows.Forms.TreeNode In list
						If Operators.CompareString(treeNode3.Text, A_0, True) = 0 AndAlso treeNode3.ImageIndex = 0 Then
							Me.Oo_O.O000_oo0.().SelectedNode = treeNode3
							Exit For
						End If
					Next
				Finally
					Dim enumerator4 As List(Of O_o__00Ooo).Enumerator
					CType(enumerator4, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x0600135F RID: 4959 RVA: 0x0007D86C File Offset: 0x0007BA6C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, A_1 As List(Of O_o__00Ooo))
			Try
				For Each obj As Object In A_0
					Dim o_o__00Ooo As O_o__00Ooo = CType(obj, O_o__00Ooo)
					A_1.Add(o_o__00Ooo)
					If o_o__00Ooo.Nodes.Count > 0 Then
						Me.Oo_O.O000_oo0.(o_o__00Ooo.Nodes, A_1)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x040007A0 RID: 1952
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040007A1 RID: 1953
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.TreeView

		' Token: 0x040007A2 RID: 1954
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ImageList
	End Class
End Namespace
