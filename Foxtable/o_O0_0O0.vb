Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200007C RID: 124
	Friend Class o_O0_0O0
		Inherits C1CommandDock

		' Token: 0x0600041A RID: 1050 RVA: 0x0000EAF3 File Offset: 0x0000CCF3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Timer
			Return Me.oO.O_0_.
		End Function

		' Token: 0x0600041B RID: 1051 RVA: 0x0000EAFC File Offset: 0x0000CCFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Timer)
			Dim value As EventHandler = AddressOf Me.OoOoo_O0o0.0O_.
			Dim timer As Timer = Me.oO.O_0_.
			If timer IsNot Nothing Then
				RemoveHandler timer.Tick, value
			End If
			Me.oO.O_0_. = A_0
			timer = Me.oO.O_0_.
			If timer IsNot Nothing Then
				AddHandler timer.Tick, value
			End If
		End Sub

		' Token: 0x0600041C RID: 1052 RVA: 0x0000EB40 File Offset: 0x0000CD40
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is OO___OO0O_0 Then
						CType(control, C1DockingTab).AutoHiding = A_0
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600041D RID: 1053 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		Friend Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			MyBase.SuspendLayout()
			Dim control As System.Windows.Forms.Control = A_0
			Do
				control = control.Parent
				If control Is Nothing Then
					GoTo IL_32
				End If
			Loop While Not(TypeOf control Is C1DockingTabPage)
			Dim c1DockingTabPage As C1DockingTabPage = CType(control, C1DockingTabPage)
			CType(c1DockingTabPage.Parent, OO___OO0O_0).Close(c1DockingTabPage)
			IL_32:
			If A_0.Parent IsNot Nothing AndAlso control.Parent Is Nothing Then
				A_0.Parent.Controls.Remove(A_0)
			End If
			MyBase.ResumeLayout()
		End Sub

		' Token: 0x0600041E RID: 1054 RVA: 0x0000EC14 File Offset: 0x0000CE14
		Friend Function <<EMPTY_NAME>>() As Integer
			Dim dock As DockStyle = Me.Dock
			Dim num As Integer
			If dock - DockStyle.Top > 1 Then
				If dock - DockStyle.Left <= 1 Then
					num = MyBase.Size.Width
				End If
			Else
				num = MyBase.Size.Height
			End If
			If num >= 60 Then
				Me.oO.O_0_. = num
			End If
			Return Me.oO.O_0_.
		End Function

		' Token: 0x0600041F RID: 1055 RVA: 0x0000EC66 File Offset: 0x0000CE66
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.oO.O_0_. = A_0
		End Sub

		' Token: 0x06000420 RID: 1056 RVA: 0x0000EC70 File Offset: 0x0000CE70
		Friend Function <<EMPTY_NAME>>() As String
			Dim oo___OO0O_ As OO___OO0O_0 = Nothing
			Dim text As String = ""
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is OO___OO0O_0 AndAlso Operators.CompareString(control.Tag.ToString(), "Shared", True) = 0 Then
						oo___OO0O_ = CType(control, OO___OO0O_0)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If oo___OO0O_ IsNot Nothing Then
				Try
					For Each obj2 As Object In oo___OO0O_.TabPages
						Dim c1DockingTabPage As C1DockingTabPage = CType(obj2, C1DockingTabPage)
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbTab
						End If
						text += c1DockingTabPage.Text
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
			End If
			Return text
		End Function

		' Token: 0x06000421 RID: 1057 RVA: 0x0000ED70 File Offset: 0x0000CF70
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.oO.O_0_. = A_0
		End Sub

		' Token: 0x06000422 RID: 1058 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		Friend Sub <<EMPTY_NAME>>()
			Dim oo___OO0O_ As OO___OO0O_0 = Nothing
			If Operators.CompareString(Me.oO.O_0_., "", True) <> 0 Then
				Dim list As List(Of String) = New List(Of String)()
				list.AddRange(Me.oO.O_0_..Split(New Char() { vbTab }))
				Try
					For Each obj As Object In MyBase.Controls
						Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
						If TypeOf control Is OO___OO0O_0 AndAlso Operators.CompareString(control.Tag.ToString(), "Shared", True) = 0 Then
							oo___OO0O_ = CType(control, OO___OO0O_0)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If oo___OO0O_ IsNot Nothing Then
					Dim list2 As List(Of C1DockingTabPage) = New List(Of C1DockingTabPage)()
					Try
						For Each right As String In list
							Try
								For Each obj2 As Object In oo___OO0O_.TabPages
									Dim c1DockingTabPage As C1DockingTabPage = CType(obj2, C1DockingTabPage)
									If Operators.CompareString(c1DockingTabPage.Text, right, True) = 0 AndAlso Not list2.Contains(c1DockingTabPage) Then
										list2.Add(c1DockingTabPage)
									End If
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
						Next
					Finally
						Dim enumerator2 As List(Of String).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					If list2.Count > 0 Then
						Dim num As Integer = 0
						Try
							For Each c1DockingTabPage2 As C1DockingTabPage In list2
								oo___OO0O_.TabPages.Insert(num, c1DockingTabPage2)
								num += 1
							Next
						Finally
							Dim enumerator4 As List(Of C1DockingTabPage).Enumerator
							CType(enumerator4, IDisposable).Dispose()
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x06000423 RID: 1059 RVA: 0x0000EF44 File Offset: 0x0000D144
		Friend Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control, A_1 As String, A_2 As Boolean, A_3 As Image, Optional A_4 As DataCol = Nothing, Optional A_5 As Boolean = True) As C1DockingTabPage
			Me.OoOoo_O0o0.0O_.()
			A_0.Dock = DockStyle.Fill
			MyBase.SuspendLayout()
			Dim c1DockingTabPage As C1DockingTabPage = New C1DockingTabPage()
			If A_2 Then
				Dim oo___OO0O_ As OO___OO0O_0 = Me.OO_o0_oO.0.()
				oo___OO0O_.Tag = "tile"
				oo___OO0O_.Visible = False
				c1DockingTabPage.Text = A_1
				c1DockingTabPage.CaptionText = A_1
				c1DockingTabPage.TabVisible = A_5
				MyBase.Controls.Add(oo___OO0O_)
				oo___OO0O_.TabPages.Add(c1DockingTabPage)
				c1DockingTabPage.Controls.Add(A_0)
				oo___OO0O_.o0.oOO_O.(c1DockingTabPage)
				oo___OO0O_.Visible = A_5
				If TypeOf A_0 Is FormPanel Then
					oo___OO0O_.AutoHiding = OO_00oOO.Forms(A_0.Name).AutoHide
					OO_00oOO.Forms(A_0.Name).O_0.O00o_00_O. = oo___OO0O_
				ElseIf A_4 IsNot Nothing Then
					oo___OO0O_.AutoHiding = A_4.AutoHide
				End If
			Else
				Dim oo___OO0O_2 As OO___OO0O_0 = Nothing
				Try
					For Each obj As Object In MyBase.Controls
						Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
						If TypeOf control Is OO___OO0O_0 AndAlso Operators.CompareString(control.Tag.ToString(), "Shared", True) = 0 Then
							oo___OO0O_2 = CType(control, OO___OO0O_0)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If oo___OO0O_2 Is Nothing Then
					oo___OO0O_2 = Me.OO_o0_oO.0.()
					oo___OO0O_2.Tag = "Shared"
					oo___OO0O_2.Visible = False
					MyBase.Controls.Add(oo___OO0O_2)
				End If
				c1DockingTabPage.Text = A_1
				c1DockingTabPage.CaptionText = A_1
				c1DockingTabPage.TabVisible = A_5
				If O_O0OO.O0_00o.o0__o..ShowTableIcon Then
					c1DockingTabPage.Image = A_3
				End If
				oo___OO0O_2.TabPages.Add(c1DockingTabPage)
				c1DockingTabPage.Controls.Add(A_0)
				oo___OO0O_2.o0.oOO_O.(c1DockingTabPage)
				oo___OO0O_2.Visible = A_5
				If TypeOf A_0 Is FormPanel Then
					oo___OO0O_2.AutoHiding = OO_00oOO.Forms(A_0.Name).AutoHide
					OO_00oOO.Forms(A_0.Name).O_0.O00o_00_O. = oo___OO0O_2
				ElseIf A_4 IsNot Nothing Then
					oo___OO0O_2.AutoHiding = A_4.AutoHide
				End If
			End If
			MyBase.ResumeLayout()
			Return c1DockingTabPage
		End Function

		' Token: 0x06000424 RID: 1060 RVA: 0x0000F170 File Offset: 0x0000D370
		Friend Sub <<EMPTY_NAME>>(A_0 As Table, A_1 As Boolean)
			Me.OoOoo_O0o0.0O_.()
			A_0.foxGrid.Dock = DockStyle.Fill
			If A_1 Then
				Dim oo___OO0O_ As OO___OO0O_0 = Me.OO_o0_oO.0.()
				Dim oo0_O_0O As OO0_O_0O = New OO0_O_0O(A_0)
				oo0_O_0O.TabVisible = False
				oo___OO0O_.TabPages.Add(oo0_O_0O)
				oo___OO0O_.Tag = "tile"
				MyBase.Controls.Add(oo___OO0O_)
				A_0.oO_o_0o._0oooo.(True)
				oo___OO0O_.AutoHiding = A_0._frdAutoHide
				oo___OO0O_.ShowCaption = A_0._frdShowCaption
				oo___OO0O_.CanCloseTabs = A_0._frdAllowClose
				oo0_O_0O.TabVisible = True
				Return
			End If
			Dim oo___OO0O_2 As OO___OO0O_0 = Nothing
			Dim oo0_O_0O2 As OO0_O_0O = New OO0_O_0O(A_0)
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is OO___OO0O_0 AndAlso Operators.CompareString(control.Tag.ToString(), "Shared", True) = 0 Then
						oo___OO0O_2 = CType(control, OO___OO0O_0)
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If oo___OO0O_2 Is Nothing Then
				oo___OO0O_2 = Me.OO_o0_oO.0.()
				oo___OO0O_2.Tag = "Shared"
				MyBase.Controls.Add(oo___OO0O_2)
			End If
			If O_O0OO.O0_00o.o0__o..ShowTableIcon Then
				oo0_O_0O2.Image = A_0._frdIcon
			End If
			oo0_O_0O2.TabVisible = False
			oo___OO0O_2.TabPages.Add(oo0_O_0O2)
			A_0.oO_o_0o._0oooo.(True)
			oo___OO0O_2.AutoHiding = A_0._frdAutoHide
			oo___OO0O_2.ShowCaption = A_0._frdShowCaption
			oo___OO0O_2.CanCloseTabs = A_0._frdAllowClose
			oo0_O_0O2.TabVisible = True
		End Sub

		' Token: 0x06000425 RID: 1061 RVA: 0x0000F300 File Offset: 0x0000D500
		Friend Sub New(A_0 As DockStyle)
			AddHandler MyBase.ControlAdded, AddressOf Me.OO_o0_oO.0.
			Me.OoOoo_O0o0.0O_.(New Timer())
			Me.Dock = A_0
			MyBase.AllowFloat = False
			MyBase.AutoDockLeft = False
			MyBase.AutoDockRight = False
			MyBase.AutoDockTop = False
			MyBase.AutoDockBottom = False
			Me.OoOoo_O0o0.0O_.().Interval = 10
			Me.OoOoo_O0o0.0O_.().Enabled = False
		End Sub

		' Token: 0x06000426 RID: 1062 RVA: 0x0000F374 File Offset: 0x0000D574
		Private Function <<EMPTY_NAME>>() As OO___OO0O_0
			Dim oo___OO0O_ As OO___OO0O_0 = New OO___OO0O_0()
			oo___OO0O_.Alignment = TabAlignment.Bottom
			If Me.Dock = DockStyle.Left Or Me.Dock = DockStyle.Right Then
				oo___OO0O_.AlignTabs = StringAlignment.Near
			Else
				oo___OO0O_.AlignTabs = StringAlignment.Far
			End If
			oo___OO0O_.BorderStyle = BorderStyle.None
			oo___OO0O_.CanCloseTabs = True
			oo___OO0O_.CanAutoHide = True
			oo___OO0O_.ShowCaption = True
			oo___OO0O_.TabSizeMode = 2
			oo___OO0O_.CanMoveTabs = True
			oo___OO0O_.ShowSingleTab = False
			oo___OO0O_.TabsSpacing = 0
			oo___OO0O_.Indent = 0
			oo___OO0O_.ShowTabList = False
			oo___OO0O_.MultiLine = True
			AddHandler oo___OO0O_.GotFocus, AddressOf Me.OoOo.O__0.
			oo___OO0O_.TabPageClosed += AddressOf Me.oO.O_0_.
			oo___OO0O_.TabPageClosing += AddressOf Me.oO.O_0_.
			oo___OO0O_.Tag = ""
			Me.OoOoo_O0o0.0O_.(oo___OO0O_)
			Return oo___OO0O_
		End Function

		' Token: 0x06000427 RID: 1063 RVA: 0x0000F44C File Offset: 0x0000D64C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo___OO0O_ As OO___OO0O_0 = CType(A_0, OO___OO0O_0)
			If oo___OO0O_.SelectedTab IsNot Nothing Then
				oo___OO0O_.SelectedTab.Focus()
			End If
		End Sub

		' Token: 0x06000428 RID: 1064 RVA: 0x0000F478 File Offset: 0x0000D678
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TabPageEventArgs)
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim oo___OO0O_ As OO___OO0O_0 = CType(A_0, OO___OO0O_0)
				IL_09:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_10:
				num = 3
				A_1.TabPage.Controls.Clear()
				IL_22:
				num = 4
				A_1.TabPage.Dispose()
				IL_2F:
				num = 5
				If oo___OO0O_.TabPages.Count <> 0 Then
					GoTo IL_4C
				End If
				IL_3E:
				num = 6
				Me.OoOoo_O0o0.0O_.().Enabled = True
				IL_4C:
				GoTo IL_B7
				IL_4E:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_78:
				GoTo IL_AC
				IL_7A:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_8A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7A
			End Try
			IL_AC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B7:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06000429 RID: 1065 RVA: 0x0000F554 File Offset: 0x0000D754
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TabPageCancelEventArgs)
			Dim tabPage As C1DockingTabPage = A_1.TabPage
			If CType(A_0, C1DockingTab).TabPages.Count = 1 Then
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						dataTable.frd_RightDockSize = dataTable.frd_RightDockSize
						dataTable.frd_LeftDockSize = dataTable.frd_LeftDockSize
						dataTable.frd_BottomDockSize = dataTable.frd_BottomDockSize
						dataTable.frd_TopDockSize = dataTable.frd_TopDockSize
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End If
			If tabPage IsNot Nothing Then
				Dim control As System.Windows.Forms.Control = ooO.o.O_0000_O.(tabPage.Controls)
				If control IsNot Nothing AndAlso control.DataBindings.Count > 0 Then
					control.DataBindings(0).WriteValue()
				End If
				If tabPage.Controls.Count = 1 Then
					control = tabPage.Controls(0)
					If TypeOf control Is FormPanel Then
						Try
							For Each dataTable2 As DataTable In OO_00oOO.DataTables
								If dataTable2.Name.ToLower().StartsWith(control.Name.ToLower() + "_") AndAlso dataTable2.o00o.00oO___0. Then
									MessageBox.Show("正在加载数据的过程中，暂不能关闭窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									A_1.Cancel = True
									Return
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of DataTable)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(control.Name)
						Dim formEventArgs As FormEventArgs = New FormEventArgs(OO_00oOO.Forms(control.Name))
						Dim a_ As String = "BeforeClose_" + Conversions.ToString(form.O_o_.0o0__o0O.("Key"))
						O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms(control.Name).O_0.O00o_00_O., a_, New Object() { formEventArgs }, False, form.Name, False)
						If form.O_0.O00o_00_O. Then
							A_1.Cancel = formEventArgs.Cancel
						End If
						If Not A_1.Cancel Then
							form.oOO0OO0O.o0oO.()
							form.OoOO_._0.()
						End If
						Return
					End If
					If TypeOf control Is OooOo0___oO Then
						Dim oooOo0___oO As OooOo0___oO = CType(control, OooOo0___oO)
						If oooOo0___oO.Editor IsNot Nothing AndAlso Not oooOo0___oO.FinishEditing() Then
							oooOo0___oO.FinishEditing(True)
						End If
						oooOo0___oO.O_._0o00_.()
						Return
					End If
					If TypeOf control Is PictureViewer Then
						CType(control, PictureViewer).ImageFiles = ""
						Return
					End If
					If TypeOf control Is o_o0ooOooO Then
						CType(control, o_o0ooOooO).Nodes.Clear()
						control.Dispose()
						Return
					End If
					If TypeOf control Is oo__ Then
						CType(control, oo__).Nodes.Clear()
						control.Dispose()
						Return
					End If
					If TypeOf control Is oO_oo0Oo Then
						CType(control, oO_oo0Oo).Nodes.Clear()
						control.Dispose()
						Return
					End If
					If TypeOf control Is o_0 Then
						CType(control, o_0).OOOO_.o.().Nodes.Clear()
						control.Controls.Clear()
						control.Dispose()
					End If
				End If
			End If
		End Sub

		' Token: 0x0600042A RID: 1066 RVA: 0x0000F84C File Offset: 0x0000DA4C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.FindForm() IsNot Nothing Then
				Me.OoOoo_O0o0.0O_.()
			End If
			Me.OoOoo_O0o0.0O_.().Enabled = False
		End Sub

		' Token: 0x0600042B RID: 1067 RVA: 0x0000F868 File Offset: 0x0000DA68
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator = MyBase.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					IL_27:
					num2 = 3
					If TypeOf control Is C1DockingTab Then
						IL_32:
						num2 = 4
						Dim c1DockingTab As C1DockingTab = CType(control, C1DockingTab)
						IL_3D:
						num2 = 5
						If c1DockingTab.TabPages.Count = 0 Then
							IL_4D:
							num2 = 6
							RemoveHandler c1DockingTab.GotFocus, AddressOf Me.OoOo.O__0.
							IL_62:
							num2 = 7
							c1DockingTab.TabPageClosed -= AddressOf Me.oO.O_0_.
							IL_77:
							num2 = 8
							c1DockingTab.TabPageClosing -= AddressOf Me.oO.O_0_.
							IL_8C:
							num2 = 9
							MyBase.Controls.Remove(control)
							IL_9C:
							num2 = 10
							control.Dispose()
						End If
						IL_A6:
						c1DockingTab = Nothing
					End If
					IL_A9:
					num2 = 12
				End While
				IL_B7:
				num2 = 13
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_CD:
				GoTo IL_157
				IL_D2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_118:
				GoTo IL_14C
				IL_11A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_12A:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_11A
			End Try
			IL_14C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_157:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600042C RID: 1068 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		Private Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			If Me.oO.O_0_. <> 0 Then
				Dim dock As DockStyle = Me.Dock
				If dock - DockStyle.Top > 1 Then
					If dock - DockStyle.Left <= 1 Then
						A_0.Width = Math.Max(60, Math.Min(Me.oO.O_0_., Main.OO_O.o..OO_O_0Oo.___o.().Width - 300))
						Return
					End If
				Else
					A_0.Height = Math.Max(60, Math.Min(Me.oO.O_0_., Main.OO_O.o..OO_O_0Oo.___o.().Height - 200))
				End If
			End If
		End Sub

		' Token: 0x0600042D RID: 1069 RVA: 0x0000FA74 File Offset: 0x0000DC74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ControlEventArgs)
			For i As Integer = MyBase.Controls.Count - 1 To 0 Step -1
				If Me.Dock = DockStyle.Right Or Me.Dock = DockStyle.Left Then
					CType(MyBase.Controls(i), C1DockingTab).Height = MyBase.ClientRectangle.Height / MyBase.Controls.Count
				Else
					CType(MyBase.Controls(i), C1DockingTab).Width = MyBase.ClientRectangle.Width / MyBase.Controls.Count
				End If
			Next
		End Sub

		' Token: 0x040000DC RID: 220
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000DD RID: 221
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000DE RID: 222
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000DF RID: 223
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer
	End Class
End Namespace
