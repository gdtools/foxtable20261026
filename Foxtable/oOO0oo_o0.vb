Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports C1.Win.FlexViewer
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003EB RID: 1003
	Friend Class oOO0oo_o0
		' Token: 0x06003F04 RID: 16132 RVA: 0x001B2B40 File Offset: 0x001B0D40
		Public Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection) As Boolean
			Dim result As Boolean
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Activated Then
							controlHolder.Activated = False
							result = True
							Exit For
						End If
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							If oOO0oo_o0.o_0O.O.(controlHolder.ChildControl.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							If oOO0oo_o0.o_0O.O.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
							If oOO0oo_o0.o_0O.O.(CType(controlHolder.ChildControl, C1DockingTab).SelectedTab.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
							If oOO0oo_o0.o_0O.O.(CType(controlHolder.ChildControl, C1NavBar).SelectedPanel.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
							Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
							If oOO0oo_o0.o_0O.O.(o0000O.oo0oO_O.oooO0O.().Controls) Then
								result = True
								Exit For
							End If
							If oOO0oo_o0.o_0O.O.(o0000O.o.Oo0oo000O.().Controls) Then
								result = True
								Exit For
							End If
						End If
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

		' Token: 0x06003F05 RID: 16133 RVA: 0x001B2CE8 File Offset: 0x001B0EE8
		Public Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection) As Boolean
			Dim result As Boolean
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Selected Then
							controlHolder.Activated = True
							result = True
							Exit For
						End If
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							If oOO0oo_o0.O.ooooo.(controlHolder.ChildControl.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							If oOO0oo_o0.O.ooooo.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
							If oOO0oo_o0.O.ooooo.(CType(controlHolder.ChildControl, C1DockingTab).SelectedTab.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
							If oOO0oo_o0.O.ooooo.(CType(controlHolder.ChildControl, C1NavBar).SelectedPanel.Controls) Then
								result = True
								Exit For
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
							Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
							If oOO0oo_o0.O.ooooo.(o0000O.oo0oO_O.oooO0O.().Controls) Then
								result = True
								Exit For
							End If
							If oOO0oo_o0.O.ooooo.(o0000O.o.Oo0oo000O.().Controls) Then
								result = True
								Exit For
							End If
						End If
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

		' Token: 0x06003F06 RID: 16134 RVA: 0x001B2E90 File Offset: 0x001B1090
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Selected Then
							controlHolder.Selected = False
						End If
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.o0.Oo__.(controlHolder.ChildControl.Controls)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.o0.Oo__.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls)
						ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
							oOO0oo_o0.o0.Oo__.(CType(controlHolder.ChildControl, C1DockingTab).SelectedTab.Controls)
						ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
							oOO0oo_o0.o0.Oo__.(CType(controlHolder.ChildControl, C1NavBar).SelectedPanel.Controls)
						ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
							Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
							oOO0oo_o0.o0.Oo__.(o0000O.oo0oO_O.oooO0O.().Controls)
							oOO0oo_o0.o0.Oo__.(o0000O.o.Oo0oo000O.().Controls)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F07 RID: 16135 RVA: 0x001B3004 File Offset: 0x001B1204
		Public Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection) As ControlHolder
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Activated Then
							Return CType(control, ControlHolder)
						End If
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							Dim controlHolder2 As ControlHolder = oOO0oo_o0.o.O0o000_.(controlHolder.ChildControl.Controls)
							If controlHolder2 IsNot Nothing Then
								Return controlHolder2
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							Dim controlHolder3 As ControlHolder = oOO0oo_o0.o.O0o000_.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls)
							If controlHolder3 IsNot Nothing Then
								Return controlHolder3
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
							Dim controlHolder4 As ControlHolder = oOO0oo_o0.o.O0o000_.(CType(controlHolder.ChildControl, C1DockingTab).SelectedTab.Controls)
							If controlHolder4 IsNot Nothing Then
								Return controlHolder4
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
							Dim controlHolder5 As ControlHolder = oOO0oo_o0.o.O0o000_.(CType(controlHolder.ChildControl, C1NavBar).SelectedPanel.Controls)
							If controlHolder5 IsNot Nothing Then
								Return controlHolder5
							End If
						ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
							Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
							Dim controlHolder6 As ControlHolder = oOO0oo_o0.o.O0o000_.(o0000O.oo0oO_O.oooO0O.().Controls)
							If controlHolder6 IsNot Nothing Then
								Return controlHolder6
							End If
							controlHolder6 = oOO0oo_o0.o.O0o000_.(o0000O.o.Oo0oo000O.().Controls)
							If controlHolder6 IsNot Nothing Then
								Return controlHolder6
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return Nothing
		End Function

		' Token: 0x06003F08 RID: 16136 RVA: 0x001B31CC File Offset: 0x001B13CC
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.O_.0oo_O. IsNot Nothing Then
							controlHolder.O_.0oo_O..Visible = False
							If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.PictureBox Or controlHolder.ControlType = ControlTypeEnum.Map Then
								CType(controlHolder.ChildControl, O0_0_0_0_).OOO_0_oo0.Oo0_.()
							Else
								If controlHolder.ControlType = ControlTypeEnum.TabControl Then
									Try
										For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
											CType(CType(obj2, O_O_), O0_0_0_0_).OOO_0_oo0.Oo0_.()
										Next
										Continue For
									Finally
										Dim enumerator2 As IEnumerator
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
								End If
								If controlHolder.ControlType = ControlTypeEnum.NavBar Then
									Try
										For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
											CType(CType(obj3, oO_0), O0_0_0_0_).OOO_0_oo0.Oo0_.()
										Next
										Continue For
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
								End If
								If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
									Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
									o0000O.oo0oO_O.oooO0O.().o__O0_.o_.()
									o0000O.o.Oo0oo000O.().o__O0_.o_.()
								End If
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F09 RID: 16137 RVA: 0x001B33A0 File Offset: 0x001B15A0
		Public Shared Sub <<EMPTY_NAME>>(A_0 As O0_0_0_0_, A_1 As System.Windows.Forms.Control.ControlCollection)
			A_0.OOO_0_oo0.Oo0_.(-1)
			A_0.O0.o0O_o00_O.(0)
			Try
				For Each obj As Object In A_1
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						A_0.OOO_0_oo0.Oo0_.(A_0.OOO_0_oo0.Oo0_.() + 1)
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.O_.0oo_O. IsNot Nothing Then
							controlHolder.O_.0oo_O..Visible = True
							If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.PictureBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
								CType(controlHolder.ChildControl, O0_0_0_0_).O0.o0O_o00_O.()
							Else
								If controlHolder.ControlType = ControlTypeEnum.TabControl Then
									Try
										For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
											CType(CType(obj2, O_O_), O0_0_0_0_).O0.o0O_o00_O.()
										Next
										Continue For
									Finally
										Dim enumerator2 As IEnumerator
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
								End If
								If controlHolder.ControlType = ControlTypeEnum.NavBar Then
									Try
										For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
											CType(CType(obj3, oO_0), O0_0_0_0_).O0.o0O_o00_O.()
										Next
										Continue For
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
								End If
								If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
									Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
									o0000O.oo0oO_O.oooO0O.().oo0oo__0o.O.()
									o0000O.o.Oo0oo000O.().oo0oo__0o.O.()
								End If
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F0A RID: 16138 RVA: 0x001B359C File Offset: 0x001B179C
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As Font)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.O00OO_O_oO_.o.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1)
						Else
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Try
									For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj2, O_O_).Controls, A_1)
									Next
									GoTo IL_183
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Try
									For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj3, oO_0).Controls, A_1)
									Next
									GoTo IL_183
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1)
							End If
						End If
						IL_183:
						If controlHolder.Selected Then
							controlHolder.ChildControl.Font = CType(A_1.Clone(), Font)
							controlHolder = Nothing
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F0B RID: 16139 RVA: 0x001B37BC File Offset: 0x001B19BC
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As Integer, A_2 As O_0Oo0o_0)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.O.ooooo.(controlHolder.ChildControl.Controls, A_1, A_2)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.O.ooooo.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1, A_2)
						Else
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Try
									For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
										oOO0oo_o0.O.ooooo.(CType(obj2, O_O_).Controls, A_1, A_2)
									Next
									GoTo IL_189
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Try
									For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
										oOO0oo_o0.O.ooooo.(CType(obj3, oO_0).Controls, A_1, A_2)
									Next
									GoTo IL_189
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								oOO0oo_o0.O.ooooo.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2)
								oOO0oo_o0.O.ooooo.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2)
							End If
						End If
						IL_189:
						If controlHolder.Selected Then
							Select Case A_2
								Case O_0Oo0o_0.O0o.0O.
									controlHolder.Left = A_1
								Case O_0Oo0o_0.O0_O.O.
									controlHolder.Left = A_1 - control.Width
								Case O_0Oo0o_0.oO0_o.0.
									controlHolder.Top = A_1
								Case O_0Oo0o_0.O._oo0o_.
									controlHolder.Top = A_1 - control.Height
							End Select
							controlHolder = Nothing
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F0C RID: 16140 RVA: 0x001B3A18 File Offset: 0x001B1C18
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As Size, A_2 As oO_)
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.O00OO_O_oO_.o.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1, A_2)
						Else
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Try
									For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj2, O_O_).Controls, A_1, A_2)
									Next
									GoTo IL_189
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Try
									For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj3, oO_0).Controls, A_1, A_2)
									Next
									GoTo IL_189
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2)
							End If
						End If
						IL_189:
						If controlHolder.Selected Then
							Select Case A_2
								Case oO_.O_o_.oo.
									If Not controlHolder.IsFixedHeight Then
										controlHolder.Height = A_1.Height
									End If
									If Not controlHolder.IsFixedWidth Then
										controlHolder.Width = A_1.Width
									End If
								Case oO_.o_.00o_o000o_0.
									If Not controlHolder.IsFixedHeight Then
										controlHolder.Height = A_1.Height
									End If
								Case oO_.O_oo0O_O._.
									If Not controlHolder.IsFixedWidth Then
										controlHolder.Width = A_1.Width
									End If
							End Select
							controlHolder = Nothing
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F0D RID: 16141 RVA: 0x001B3C98 File Offset: 0x001B1E98
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As OoO_OO0o_0o)
			Dim num As Integer = 0
			Dim num2 As Integer = Integer.MaxValue
			Dim num3 As Integer = Integer.MinValue
			Dim num4 As Integer = 0
			Dim i As Integer = 0
			Try
				For Each obj As Object In A_0
					Dim control As System.Windows.Forms.Control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder AndAlso TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.O00OO_O_oO_.o.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1)
						Else
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Try
									For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj2, O_O_).Controls, A_1)
									Next
									GoTo IL_1B7
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Try
									For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj3, oO_0).Controls, A_1)
									Next
									GoTo IL_1B7
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1)
							End If
						End If
						IL_1B7:
						If controlHolder.Selected Then
							num4 += 1
							If A_1 = OoO_OO0o_0o.O_o_.oo. Then
								num += control.Width
								num2 = Math.Min(num2, control.Left)
								num3 = Math.Max(num3, control.Left + control.Width)
							Else
								num += control.Height
								num2 = Math.Min(num2, control.Top)
								num3 = Math.Max(num3, control.Top + control.Height)
							End If
							controlHolder = Nothing
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If num4 >= 2 Then
				Dim num5 As Integer = CInt(Math.Round(CDbl((num3 - num2 - num)) / CDbl((num4 - 1))))
				Dim array As ControlHolder() = New ControlHolder(num4 - 1 + 1 - 1) {}
				Dim array2 As Integer() = New Integer(num4 - 1 + 1 - 1) {}
				Try
					For Each obj4 As Object In A_0
						Dim control As System.Windows.Forms.Control = CType(obj4, System.Windows.Forms.Control)
						If TypeOf control Is ControlHolder AndAlso TypeOf control Is ControlHolder AndAlso CType(control, ControlHolder).Selected Then
							array(i) = CType(control, ControlHolder)
							If A_1 = OoO_OO0o_0o.O_o_.oo. Then
								array2(i) = control.Left
							Else
								array2(i) = control.Top
							End If
							i += 1
						End If
					Next
				Finally
					Dim enumerator4 As IEnumerator
					If TypeOf enumerator4 Is IDisposable Then
						TryCast(enumerator4, IDisposable).Dispose()
					End If
				End Try
				Array.Sort(Of Integer, ControlHolder)(array2, array)
				Dim num6 As Integer = num4 - 1
				i = 0
				While i <= num6
					If A_1 = OoO_OO0o_0o.O_o_.oo. Then
						array(i).Left = num2
						num2 = num2 + array(i).Width + num5
					Else
						array(i).Top = num2
						num2 = num2 + array(i).Height + num5
					End If
					i += 1
				End While
			End If
		End Sub

		' Token: 0x06003F0E RID: 16142 RVA: 0x001B4064 File Offset: 0x001B2264
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As Integer, A_2 As Integer, A_3 As String)
			Dim control As System.Windows.Forms.Control = Nothing
			Try
				For Each obj As Object In A_0
					control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Selected And controlHolder.Dock = DockStyle.None And (Operators.CompareString(controlHolder.DynamicKey, A_3, True) = 0 Or Operators.CompareString(A_3, "", True) = 0) Then
							controlHolder.SetBounds(controlHolder.Left + A_1, controlHolder.Top + A_2, controlHolder.Width, controlHolder.Height)
							controlHolder.ChildControl.Refresh()
						End If
						If Not controlHolder.Selected Then
							If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
								oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2, A_3)
							ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
								oOO0oo_o0.O00OO_O_oO_.o.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1, A_2, A_3)
							ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Dim c1DockingTab As C1DockingTab = CType(controlHolder.ChildControl, C1DockingTab)
								Try
									For Each obj2 As Object In c1DockingTab.TabPages
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj2, O_O_).Controls, A_1, A_2, A_3)
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Dim c1NavBar As C1NavBar = CType(controlHolder.ChildControl, C1NavBar)
								Try
									For Each obj3 As Object In c1NavBar.Panels
										oOO0oo_o0.O00OO_O_oO_.o.(CType(obj3, oO_0).Controls, A_1, A_2, A_3)
									Next
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2, A_3)
								oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2, A_3)
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If control IsNot Nothing Then
				CType(control.FindForm().MdiParent, o\u3000\u3002).OO_._oOo. = True
			End If
		End Sub

		' Token: 0x06003F0F RID: 16143 RVA: 0x001B430C File Offset: 0x001B250C
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As O0OO000oo0O, A_2 As Integer, A_3 As Integer)
			Dim control As System.Windows.Forms.Control = Nothing
			Try
				For Each obj As Object In A_0
					control = CType(obj, System.Windows.Forms.Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							oOO0oo_o0.O00OO_O_oO_.o.(controlHolder.ChildControl.Controls, A_1, A_2, A_3)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							oOO0oo_o0.O00OO_O_oO_.o.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1, A_2, A_3)
						ElseIf controlHolder.ControlType = ControlTypeEnum.TabControl Then
							Dim c1DockingTab As C1DockingTab = CType(controlHolder.ChildControl, C1DockingTab)
							Try
								For Each obj2 As Object In c1DockingTab.TabPages
									oOO0oo_o0.O00OO_O_oO_.o.(CType(obj2, O_O_).Controls, A_1, A_2, A_3)
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						ElseIf controlHolder.ControlType = ControlTypeEnum.NavBar Then
							Dim c1NavBar As C1NavBar = CType(controlHolder.ChildControl, C1NavBar)
							Try
								For Each obj3 As Object In c1NavBar.Panels
									oOO0oo_o0.O00OO_O_oO_.o.(CType(obj3, oO_0).Controls, A_1, A_2, A_3)
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
						ElseIf controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
							Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
							oOO0oo_o0.O00OO_O_oO_.o.(o0000O.oo0oO_O.oooO0O.().Controls, A_1, A_2, A_3)
							oOO0oo_o0.O00OO_O_oO_.o.(o0000O.o.Oo0oo000O.().Controls, A_1, A_2, A_3)
						End If
						If controlHolder.Selected Then
							Select Case A_1
								Case O0OO000oo0O.OOOOo._.
									If controlHolder.Width - A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Right) Then
										controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height)
									End If
								Case O0OO000oo0O.ooo_O0o._.
									If controlHolder.Height - A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Bottom) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3)
									End If
								Case O0OO000oo0O.o.00o000O00o__.
									If controlHolder.Width + A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Left) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height)
									End If
								Case O0OO000oo0O.o_.0_0O.
									If controlHolder.Height + A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Top) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3)
									End If
								Case O0OO000oo0O.o_oO._0O.
									If controlHolder.Width - A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Right) Then
										controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height)
									End If
									If controlHolder.Height - A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Bottom) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3)
									End If
								Case O0OO000oo0O.o0_OoOo.OO.
									If controlHolder.Width + A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Left) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height)
									End If
									If controlHolder.Height - A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Bottom) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top + A_3, controlHolder.Width, controlHolder.Height - A_3)
									End If
								Case O0OO000oo0O.Oo0ooo.OO.
									If controlHolder.Width - A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Right) Then
										controlHolder.SetBounds(controlHolder.Left + A_2, controlHolder.Top, controlHolder.Width - A_2, controlHolder.Height)
									End If
									If controlHolder.Height + A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Top) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3)
									End If
								Case O0OO000oo0O.OO_._O.
									If controlHolder.Width + A_2 > 14 And Not controlHolder.IsFixedWidth And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Left) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width + A_2, controlHolder.Height)
									End If
									If controlHolder.Height + A_3 > 14 And Not controlHolder.IsFixedHeight And (controlHolder.Dock = DockStyle.None Or controlHolder.Dock = DockStyle.Top) Then
										controlHolder.SetBounds(controlHolder.Left, controlHolder.Top, controlHolder.Width, controlHolder.Height + A_3)
									End If
							End Select
							controlHolder.ChildControl.Refresh()
							controlHolder = Nothing
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If control IsNot Nothing Then
				CType(control.FindForm().MdiParent, o\u3000\u3002).OO_._oOo. = True
			End If
		End Sub

		' Token: 0x06003F10 RID: 16144 RVA: 0x001B4960 File Offset: 0x001B2B60
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView)
			A_0.ImageList = O_O0OO.OoO.0OO__0ooo.()
			Dim treeNode As System.Windows.Forms.TreeNode
			Try
				For Each table As Table In OO_00oOO.Tables
					If table.Name.StartsWith(OO_00oOO.MainTable.Name) Then
						treeNode = A_0.Nodes.Add(table.Name, table.Name)
						treeNode.ImageKey = "Table"
						treeNode.SelectedImageKey = treeNode.ImageKey
						Try
							For Each col As Col In table.Cols
								Dim treeNode2 As System.Windows.Forms.TreeNode = treeNode.Nodes.Add(col.Name, col.Name)
								treeNode2.ImageKey = "Column"
								treeNode2.SelectedImageKey = treeNode2.ImageKey
								treeNode2.Tag = col.DataCol
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Col)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of Table)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Try
				For Each table2 As Table In OO_00oOO.Tables
					If Not table2.Name.StartsWith(OO_00oOO.MainTable.Name) Then
						treeNode = A_0.Nodes.Add(table2.Name, table2.Name)
						treeNode.ImageKey = "Table"
						treeNode.SelectedImageKey = treeNode.ImageKey
						Try
							For Each col2 As Col In table2.Cols
								Dim treeNode3 As System.Windows.Forms.TreeNode = treeNode.Nodes.Add(col2.Name, col2.Name)
								treeNode3.ImageKey = "Column"
								treeNode3.SelectedImageKey = treeNode3.ImageKey
								treeNode3.Tag = col2.DataCol
							Next
						Finally
							Dim enumerator4 As IEnumerator(Of Col)
							If enumerator4 IsNot Nothing Then
								enumerator4.Dispose()
							End If
						End Try
					End If
				Next
			Finally
				Dim enumerator3 As IEnumerator(Of Table)
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
			End Try
			Dim o_u3002_u3002_u3000_u3000_u As o\u3002\u3002\u3000\u3000\u3002 = Nothing
			Try
				For Each obj As Object In Application.OpenForms
					Dim form As System.Windows.Forms.Form = CType(obj, System.Windows.Forms.Form)
					If TypeOf form Is o\u3002\u3002\u3000\u3000\u3002 Then
						o_u3002_u3002_u3000_u3000_u = CType(form, o\u3002\u3002\u3000\u3000\u3002)
						Exit For
					End If
				Next
			Finally
				Dim enumerator5 As IEnumerator
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
			End Try
			If o_u3002_u3002_u3000_u3000_u IsNot Nothing Then
				Try
					For Each propertyBase As PropertyBase In o_u3002_u3002_u3000_u3000_u.O0o._0..Values
						If TypeOf propertyBase Is TableGridProperty Then
							Dim tableGridProperty As TableGridProperty = CType(propertyBase, TableGridProperty)
							If tableGridProperty.TableType IsNot Nothing OrElse Not tableGridProperty.IsCopy Then
								GoTo IL_38A
							End If
							Dim relationTable As String = tableGridProperty.RelationTable
							If Operators.CompareString(relationTable, "", True) > 0 AndAlso OO_00oOO.Tables.get_Contains(relationTable) AndAlso Not OO_00oOO.Tables(relationTable).IsRelation Then
								Dim text As String = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.("Name").ToString() + "_" + tableGridProperty.Name
								treeNode = A_0.Nodes.Add(text, text)
								treeNode.ImageKey = "Table"
								treeNode.SelectedImageKey = treeNode.ImageKey
								Try
									For Each col3 As Col In OO_00oOO.Tables(relationTable).Cols
										Dim treeNode4 As System.Windows.Forms.TreeNode = treeNode.Nodes.Add(col3.Name, col3.Name)
										treeNode4.ImageKey = "Column"
										treeNode4.SelectedImageKey = treeNode4.ImageKey
										treeNode4.Tag = col3.DataCol
									Next
									Continue For
								Finally
									Dim enumerator7 As IEnumerator(Of Col)
									If enumerator7 IsNot Nothing Then
										enumerator7.Dispose()
									End If
								End Try
								GoTo IL_38A
							End If
							Continue For
							IL_38A:
							If tableGridProperty.TableType = 2 OrElse tableGridProperty.TableType = 1 Then
								Dim sqlcommand As SQLCommand = New SQLCommand()
								sqlcommand.CommandText = tableGridProperty.SelectString
								sqlcommand.ConnectionName = tableGridProperty.Connection
								Try
									Dim dataTable As DataTable = sqlcommand.OO__00.__.()
									Dim text2 As String = o_u3002_u3002_u3000_u3000_u.o_0O.OO0_0_.("Name").ToString() + "_" + tableGridProperty.Name
									treeNode = A_0.Nodes.Add(text2, text2)
									treeNode.ImageKey = "Table"
									treeNode.SelectedImageKey = treeNode.ImageKey
									Try
										For Each dataCol As DataCol In dataTable.DataCols
											Dim treeNode5 As System.Windows.Forms.TreeNode = treeNode.Nodes.Add(dataCol.Name, dataCol.Name)
											treeNode5.ImageKey = "Column"
											treeNode5.SelectedImageKey = treeNode5.ImageKey
											treeNode5.Tag = dataCol
										Next
									Finally
										Dim enumerator8 As IEnumerator(Of DataCol)
										If enumerator8 IsNot Nothing Then
											enumerator8.Dispose()
										End If
									End Try
								Catch ex As Exception
								End Try
							End If
						End If
					Next
				Finally
					Dim enumerator6 As Dictionary(Of String, PropertyBase).ValueCollection.Enumerator
					CType(enumerator6, IDisposable).Dispose()
				End Try
			End If
			treeNode = New System.Windows.Forms.TreeNode()
			treeNode.Text = "全局变量"
			treeNode.Name = treeNode.Text
			treeNode.ImageKey = "Va"
			treeNode.SelectedImageKey = "Va"
			Try
				For Each obj2 As Object In OO_00oOO.Vars.VariableTable.Columns
					Dim dataColumn As DataColumn = CType(obj2, DataColumn)
					If Not dataColumn.ColumnName.ToLower().StartsWith("sys") Then
						Dim treeNode6 As System.Windows.Forms.TreeNode = treeNode.Nodes.Add(dataColumn.ColumnName, dataColumn.ColumnName)
						treeNode6.ImageKey = "Var"
						treeNode6.SelectedImageKey = "Var"
					End If
				Next
			Finally
				Dim enumerator9 As IEnumerator
				If TypeOf enumerator9 Is IDisposable Then
					TryCast(enumerator9, IDisposable).Dispose()
				End If
			End Try
			If treeNode.GetNodeCount(False) > 0 Then
				A_0.Nodes.Add(treeNode)
			End If
		End Sub

		' Token: 0x06003F11 RID: 16145 RVA: 0x001B4FEC File Offset: 0x001B31EC
		Public Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView, A_1 As TreeNodeCollection, A_2 As String) As Boolean
			Dim result As Boolean
			If A_0.Nodes Is A_1 AndAlso (Operators.CompareString(A_0.ImageKey, A_2, True) = 0 OrElse Operators.CompareString(A_0.SelectedImageKey, A_2, True) = 0) Then
				result = True
			Else
				Try
					For Each obj As Object In A_1
						Dim treeNode As System.Windows.Forms.TreeNode = CType(obj, System.Windows.Forms.TreeNode)
						If Operators.CompareString(treeNode.ImageKey, A_2, True) = 0 OrElse Operators.CompareString(treeNode.SelectedImageKey, A_2, True) = 0 Then
							Return True
						End If
						If treeNode.GetNodeCount(False) > 0 AndAlso oOO0oo_o0.o.O0o000_.(A_0, treeNode.Nodes, A_2) Then
							Return True
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				result = False
			End If
			Return result
		End Function

		' Token: 0x06003F12 RID: 16146 RVA: 0x001B50AC File Offset: 0x001B32AC
		Public Shared Sub <<EMPTY_NAME>>(A_0 As C1TopicBar, A_1 As String)
			Dim imageList As ImageList = New ImageList()
			A_0.Pages.Clear()
			A_0.ImageList = imageList
			If Operators.CompareString(A_1, "", True) <> 0 Then
				For Each text As String In A_1.Split(New Char() { vbFormFeed })
					If Operators.CompareString(text, "Page", True) = 0 Then
						Dim flag As Boolean = True
					Else
						Dim flag As Boolean
						If flag Then
							Dim c1TopicPage As C1TopicPage = New C1TopicPage()
							Dim a_ As Object = New TopicPage(c1TopicPage)
							A_0.Pages.Add(c1TopicPage)
							o_O_o_oOoo__.OOOO_OO._oo.(a_, text, vbTab)
						Else
							Dim c1TopicLink As C1TopicLink = New C1TopicLink()
							Dim a_2 As Object = New TopicLink(c1TopicLink)
							A_0.Pages(A_0.Pages.Count - 1).Links.Add(c1TopicLink)
							o_O_o_oOoo__.OOOO_OO._oo.(a_2, text, vbTab)
						End If
						flag = False
					End If
				Next
			End If
		End Sub

		' Token: 0x06003F13 RID: 16147 RVA: 0x001B5188 File Offset: 0x001B3388
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As O_oOooO_O)
			If Not A_0.o.0O_O0o_..IsRelation Then
				Try
					For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
						Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
						If Operators.CompareString(oo0__Oo.Name, A_0.o.0O_O0o_..Name, True) = 0 Then
							Dim num As Integer = oo0__Oo.O_000__.o.().TabPages.Count - 1
							For i As Integer = 0 To num
								If TypeOf oo0__Oo.O_000__.o.().TabPages(i)Is O0o0 Then
									A_0.Dock = DockStyle.Fill
									Dim c1DockingTabPage As C1DockingTabPage = oo0__Oo.O_000__.o.().TabPages(i)
									For j As Integer = c1DockingTabPage.Controls.Count - 1 To 0 Step -1
										If Not(TypeOf c1DockingTabPage.Controls(j)Is o_O0_0O0) Then
											c1DockingTabPage.Controls.Remove(c1DockingTabPage.Controls(j))
										End If
									Next
									c1DockingTabPage.Controls.Add(A_0)
									A_0.o.0O_O0o_..O.__O0o0.(True, False)
									A_0.BringToFront()
								End If
							Next
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06003F14 RID: 16148 RVA: 0x001B52F8 File Offset: 0x001B34F8
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection, A_1 As System.Windows.Forms.Control)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj6 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim flag As Boolean = False
				IL_0B:
				num2 = 3
				If TypeOf A_1 Is C1FlexGrid Then
					GoTo IL_29
				End If
				IL_15:
				num2 = 4
				If A_1.DataBindings.Count <= 0 Then
					GoTo IL_29
				End If
				IL_25:
				num2 = 5
				flag = True
				IL_29:
				num2 = 6
				If Not(TypeOf A_1 Is O_oOooO_O) Then
					GoTo IL_4E3
				End If
				IL_36:
				num2 = 7
				Dim o_oOooO_O As O_oOooO_O = CType(A_1, O_oOooO_O)
				IL_40:
				num2 = 8
				o_oOooO_O.o.0O_O0o_..HideToolTip()
				IL_4E:
				num2 = 9
				If o_oOooO_O.o.0O_O0o_. IsNot OO_00oOO.CurrentTable Then
					GoTo IL_83
				End If
				IL_5F:
				num2 = 10
				OO_00oOO.CurrentTable = OO_00oOO.MainTable
				IL_6C:
				num2 = 11
				OO_00oOO.RaiseSystemEvent(OO_00oOO.MainTable, New SystemEventTypeEnum() { 1 })
				IL_83:
				num2 = 12
				If oOO0oo_o0.O._0O0__o. IsNot Nothing Then
					GoTo IL_C9
				End If
				IL_8D:
				num2 = 13
				oOO0oo_o0.ooo_o__OO_.o. = Conversions.ToBoolean(oOO0oo_o0.ooo_o__OO_.o..Invoke(Nothing, New Object(-1) {}))
				IL_AB:
				num2 = 14
				If Not oOO0oo_o0.ooo_o__OO_.o. Then
					GoTo IL_C0
				End If
				IL_B5:
				num2 = 15
				oOO0oo_o0.O._0O0__o. = 1
				GoTo IL_C9
				IL_C0:
				num2 = 17
				oOO0oo_o0.O._0O0__o. = 2
				IL_C9:
				num2 = 18
				If oOO0oo_o0.O._0O0__o. <> 1 Then
					GoTo IL_4DB
				End If
				IL_D7:
				num2 = 19
				Dim enumerator As IEnumerator = o_oOooO_O.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim column As Column = CType(obj, Column)
					IL_FB:
					num2 = 20
					If column.Editor IsNot Nothing AndAlso TypeOf column.Editor Is OooO00O Then
						IL_11B:
						num2 = 21
						Dim oooO00O As OooO00O = CType(column.Editor, OooO00O)
						IL_12C:
						num2 = 22
						If oooO00O.DropDownForm IsNot Nothing AndAlso oooO00O.DropDownForm.Controls.Count > 0 Then
							IL_14C:
							num2 = 23
							oooO00O.DropDownForm.Controls.Clear()
						End If
						IL_160:
						num2 = 24
						column.Editor = Nothing
						IL_16B:
						num2 = 25
						If o_oOooO_O.o.0O_O0o_..TableType Is Nothing AndAlso Not o_oOooO_O.o.0O_O0o_..IsCopy Then
							IL_18A:
							num2 = 26
							o_oOooO_O.o.0O_O0o_..Cols(column.Name).DropForm = o_oOooO_O.o.0O_O0o_..Cols(column.Name).DropForm
						End If
					End If
					IL_1C7:
					num2 = 27
				End While
				IL_1D6:
				num2 = 28
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_1EE:
				num2 = 29
				If o_oOooO_O.o.0O_O0o_..TableType Is Nothing Then
					GoTo IL_399
				End If
				IL_202:
				num2 = 30
				Dim a_ As Boolean = OO_00oOO.SystemReady
				IL_20C:
				num2 = 31
				OO_00oOO.SystemReady = False
				IL_215:
				num2 = 32
				Dim text As String = o_oOooO_O.o.0O_O0o_..Name
				IL_226:
				num2 = 33
				Dim dataTable As DataTable = OO_00oOO.DataTables(text).BaseTable
				IL_23C:
				num2 = 34
				Dim enumerator2 As IEnumerator(Of Relation) = OO_00oOO.Relations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim relation As Relation = enumerator2.Current
					IL_256:
					num2 = 35
					If relation.ParentTable.BaseTable Is dataTable OrElse relation.ChildTable.BaseTable Is dataTable Then
						IL_279:
						num2 = 36
						OO_00oOO.Relations.Delete(relation.Name)
					End If
					IL_28D:
					num2 = 37
				End While
				IL_299:
				num2 = 38
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_2A7:
				num2 = 39
				o_O_o_oOoo__.oo.O0o0o.(o_oOooO_O.o.0O_O0o_.)
				IL_2B6:
				num2 = 40
				OO_00oOO.Tables.OO._O_o__.(text)
				IL_2C5:
				num2 = 41
				O_O0OO.o__.O.().Remove(text)
				IL_2D5:
				num2 = 42
				OO_00oOO.DataTables.OoO_00.O.(text)
				IL_2E4:
				num2 = 43
				If Not O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(text) Then
					GoTo IL_30E
				End If
				IL_2FA:
				num2 = 44
				O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(text)
				IL_30E:
				num2 = 45
				o_oOooO_O.SetDataBinding(Nothing, Nothing)
				IL_31A:
				num2 = 46
				o_oOooO_O.o.0O_O0o_..View.Dispose()
				IL_32E:
				num2 = 47
				o_oOooO_O.o.0O_O0o_..foxGrid = Nothing
				IL_33E:
				num2 = 48
				o_oOooO_O.o.0O_O0o_. = Nothing
				IL_349:
				num2 = 49
				o_oOooO_O.o.o0OO00oO_0.()
				IL_353:
				num2 = 50
				o_oOooO_O.Controls.Clear()
				IL_362:
				num2 = 51
				dataTable.Rows.Clear()
				IL_371:
				num2 = 52
				dataTable.Reset()
				IL_37B:
				num2 = 53
				dataTable.Dispose()
				IL_385:
				num2 = 54
				flag = True
				IL_38A:
				num2 = 55
				OO_00oOO.SystemReady = a_
				GoTo IL_4BA
				IL_399:
				num2 = 57
				If Not o_oOooO_O.o.0O_O0o_..View.O0O.o__0.() Then
					GoTo IL_4B0
				End If
				IL_3B2:
				num2 = 58
				Dim a_2 As Boolean = OO_00oOO.SystemReady
				IL_3BC:
				num2 = 59
				OO_00oOO.SystemReady = False
				IL_3C5:
				num2 = 60
				Dim fixed As Integer = o_oOooO_O.Cols.Fixed
				Dim num3 As Integer = o_oOooO_O.Cols.Count - 1
				For i As Integer = fixed To num3
					IL_3E8:
					num2 = 61
					o_oOooO_O.Cols(i).Editor = Nothing
					IL_3FF:
					num2 = 62
				Next
				IL_40E:
				num2 = 63
				OO_00oOO.Tables.OO._O_o__.(o_oOooO_O.o.0O_O0o_..View.Oo._Oo0OO.())
				IL_42C:
				num2 = 64
				O_O0OO.o__.O.().Remove(o_oOooO_O.o.0O_O0o_..View.Oo._Oo0OO.())
				IL_44B:
				num2 = 65
				o_oOooO_O.SetDataBinding(Nothing, Nothing)
				IL_457:
				num2 = 66
				o_oOooO_O.o.0O_O0o_..View.Dispose()
				IL_46B:
				num2 = 67
				o_oOooO_O.o.0O_O0o_..foxGrid = Nothing
				IL_47B:
				num2 = 68
				o_oOooO_O.o.0O_O0o_. = Nothing
				IL_486:
				num2 = 69
				o_oOooO_O.o.o0OO00oO_0.()
				IL_490:
				num2 = 70
				o_oOooO_O.Controls.Clear()
				IL_49F:
				num2 = 71
				flag = True
				IL_4A4:
				num2 = 72
				OO_00oOO.SystemReady = a_2
				GoTo IL_4BA
				IL_4B0:
				num2 = 74
				A_1.Visible = True
				IL_4BA:
				num2 = 75
				If o_oOooO_O.Controls.Count <= 0 Then
					GoTo IL_4DB
				End If
				IL_4CC:
				num2 = 76
				o_oOooO_O.Controls.Clear()
				IL_4DB:
				o_oOooO_O = Nothing
				GoTo IL_C7B
				IL_4E3:
				num2 = 79
				If Not(TypeOf A_1 Is WebViewer) Then
					GoTo IL_564
				End If
				IL_4EE:
				num2 = 80
				CType(A_1, WebViewer).NavigateToString("")
				IL_501:
				num2 = 81
				CType(A_1, WebViewer).[Stop]()
				IL_50F:
				num2 = 82
				If CType(A_1, WebViewer).CoreWebView2 Is Nothing Then
					GoTo IL_532
				End If
				IL_51F:
				num2 = 83
				CType(A_1, WebViewer).CoreWebView2.[Stop]()
				IL_532:
				num2 = 84
				If A_1.Parent Is Nothing Then
					GoTo IL_551
				End If
				IL_53D:
				num2 = 85
				A_1.Parent.Controls.Remove(A_1)
				IL_551:
				num2 = 86
				CType(A_1, WebViewer).Dispose()
				GoTo IL_C7B
				IL_564:
				num2 = 88
				If Not(TypeOf A_1 Is OooOo0___oO) Then
					GoTo IL_64E
				End If
				IL_572:
				num2 = 89
				Dim oooOo0___oO As OooOo0___oO = CType(A_1, OooOo0___oO)
				IL_57D:
				num2 = 90
				Dim num4 As Integer = oooOo0___oO.Rows.Count - 1
				For j As Integer = 0 To num4
					IL_598:
					num2 = 91
					Dim editor As System.Windows.Forms.Control = oooOo0___oO.GetCellRange(j, 1).StyleNew.Editor
					IL_5B5:
					num2 = 92
					If editor IsNot Nothing AndAlso TypeOf editor Is OooO00O Then
						IL_5C5:
						num2 = 93
						Dim oooO00O2 As OooO00O = CType(editor, OooO00O)
						IL_5D1:
						num2 = 94
						If oooO00O2.DropDownForm IsNot Nothing AndAlso oooO00O2.DropDownForm.Controls.Count > 0 Then
							IL_5F1:
							num2 = 95
							oooO00O2.DropDownForm.Controls.Clear()
						End If
						IL_605:
						num2 = 96
						oooOo0___oO.GetCellRange(j, 1).StyleNew.Editor = Nothing
					End If
					IL_621:
					num2 = 97
				Next
				IL_633:
				num2 = 98
				oooOo0___oO.OO_.O_O0O.(Nothing)
				IL_63E:
				num2 = 99
				oooOo0___oO.OO_.O_O0O.(Nothing)
				GoTo IL_C7B
				IL_64E:
				num2 = 101
				If Not(TypeOf A_1 Is FileManager) Then
					GoTo IL_68A
				End If
				IL_659:
				num2 = 102
				If Not CType(A_1, FileManager).o0o___Oo0o_0.0. Then
					GoTo IL_C7B
				End If
				IL_66C:
				num2 = 103
				CType(A_1, FileManager).[ReadOnly] = 0
				IL_67B:
				num2 = 104
				A_1.Visible = True
				GoTo IL_C7B
				IL_68A:
				num2 = 106
				If Not(TypeOf A_1 Is PictureViewer) Then
					GoTo IL_6D9
				End If
				IL_695:
				num2 = 107
				If Not CType(A_1, PictureViewer).oO0O.o_O_0OO0. Then
					GoTo IL_C7B
				End If
				IL_6A8:
				num2 = 108
				CType(A_1, PictureViewer).[ReadOnly] = 0
				IL_6B7:
				num2 = 109
				CType(A_1, PictureViewer).ImageFiles = ""
				IL_6CA:
				num2 = 110
				A_1.Visible = True
				GoTo IL_C7B
				IL_6D9:
				num2 = 112
				If Not(TypeOf A_1 Is O__o) Then
					GoTo IL_715
				End If
				IL_6E4:
				num2 = 113
				If Not CType(A_1, O__o).o__0_o0.OOO_. Then
					GoTo IL_C7B
				End If
				IL_6F7:
				num2 = 114
				CType(A_1, O__o).O0oO_OOOOo0o.o.(0)
				IL_706:
				num2 = 115
				A_1.Visible = True
				GoTo IL_C7B
				IL_715:
				num2 = 117
				If Not(TypeOf A_1 Is System.Windows.Forms.WebBrowser) Then
					GoTo IL_72E
				End If
				IL_720:
				num2 = 118
				A_1.Dispose()
				GoTo IL_C7B
				IL_72E:
				num2 = 120
				If Not(TypeOf A_1 Is C1TopicBar) Then
					GoTo IL_81F
				End If
				IL_73C:
				num2 = 121
				Dim c1TopicBar As C1TopicBar = CType(A_1, C1TopicBar)
				IL_747:
				num2 = 122
				If c1TopicBar.ImageList Is Nothing Then
					GoTo IL_776
				End If
				IL_753:
				num2 = 123
				c1TopicBar.ImageList.Images.Clear()
				IL_767:
				num2 = 124
				c1TopicBar.ImageList.Dispose()
				IL_776:
				num2 = 125
				Dim enumerator3 As IEnumerator = c1TopicBar.Pages.GetEnumerator()
				While enumerator3.MoveNext()
					Dim obj2 As Object = enumerator3.Current
					Dim c1TopicPage As C1TopicPage = CType(obj2, C1TopicPage)
					IL_797:
					num2 = 126
					If c1TopicPage.ImageList IsNot Nothing Then
						IL_7A3:
						num2 = 127
						c1TopicPage.ImageList.Images.Clear()
						IL_7B7:
						num2 = 128
						c1TopicPage.ImageList.Dispose()
					End If
					IL_7C9:
					num2 = 129
					c1TopicPage.Links.Clear()
					IL_7DB:
					num2 = 130
				End While
				IL_7EA:
				num2 = 131
				If TypeOf enumerator3 Is IDisposable Then
					TryCast(enumerator3, IDisposable).Dispose()
				End If
				IL_805:
				num2 = 132
				c1TopicBar.Pages.Clear()
				IL_817:
				c1TopicBar = Nothing
				GoTo IL_C7B
				IL_81F:
				num2 = 135
				If Not(TypeOf A_1 Is System.Windows.Forms.TreeView) Then
					GoTo IL_88D
				End If
				IL_82D:
				num2 = 136
				Dim treeView As System.Windows.Forms.TreeView = CType(A_1, System.Windows.Forms.TreeView)
				IL_83B:
				num2 = 137
				If treeView.ImageList Is Nothing Then
					GoTo IL_873
				End If
				IL_84A:
				num2 = 138
				treeView.ImageList.Images.Clear()
				IL_861:
				num2 = 139
				treeView.ImageList.Dispose()
				IL_873:
				num2 = 140
				treeView.Nodes.Clear()
				IL_885:
				treeView = Nothing
				GoTo IL_C7B
				IL_88D:
				num2 = 143
				If Not(TypeOf A_1 Is o_0) Then
					GoTo IL_8BB
				End If
				IL_89B:
				num2 = 144
				CType(A_1, o_0).OOOO_.o.().Nodes.Clear()
				GoTo IL_C7B
				IL_8BB:
				num2 = 146
				If Not(TypeOf A_1 Is C1FlexViewer) Then
					GoTo IL_912
				End If
				IL_8C9:
				num2 = 147
				Dim c1FlexViewer As C1FlexViewer = CType(A_1, C1FlexViewer)
				IL_8D7:
				num2 = 148
				If c1FlexViewer.DocumentSource Is Nothing Then
					GoTo IL_C7B
				End If
				IL_8E9:
				num2 = 149
				c1FlexViewer.DocumentSource.ClearContent()
				IL_8FB:
				num2 = 150
				c1FlexViewer.DocumentSource.Dispose()
				GoTo IL_C7B
				IL_912:
				num2 = 152
				If Not(TypeOf A_1 Is o_OO_oOOO0o) Then
					GoTo IL_976
				End If
				IL_920:
				num2 = 153
				Dim o_OO_oOOO0o As o_OO_oOOO0o = CType(A_1, o_OO_oOOO0o)
				IL_92E:
				num2 = 154
				o_OO_oOOO0o.Items.Clear()
				IL_940:
				num2 = 155
				o_OO_oOOO0o.LargeImageList.Images.Clear()
				IL_957:
				num2 = 156
				o_OO_oOOO0o.SmallImageList.Images.Clear()
				IL_96E:
				o_OO_oOOO0o = Nothing
				GoTo IL_C7B
				IL_976:
				num2 = 159
				If Not(TypeOf A_1 Is OooO00O) Then
					GoTo IL_9D4
				End If
				IL_984:
				num2 = 160
				Dim oooO00O3 As OooO00O = CType(A_1, OooO00O)
				IL_992:
				num2 = 161
				If oooO00O3.DropDownForm Is Nothing OrElse oooO00O3.DropDownForm.Controls.Count <= 0 Then
					GoTo IL_9CC
				End If
				IL_9B5:
				num2 = 162
				oooO00O3.DropDownForm.Controls.Clear()
				IL_9CC:
				oooO00O3 = Nothing
				GoTo IL_C7B
				IL_9D4:
				num2 = 165
				If Not(TypeOf A_1 Is GeoMap) Then
					GoTo IL_A18
				End If
				IL_9E2:
				num2 = 166
				Dim geoMap As GeoMap = CType(A_1, GeoMap)
				IL_9F0:
				num2 = 167
				geoMap.O.oO_O_..Clear()
				IL_A02:
				num2 = 168
				geoMap.O.oO_O_. = Nothing
				IL_A10:
				geoMap = Nothing
				GoTo IL_C7B
				IL_A18:
				num2 = 171
				oOO0oo_o0.O0o.O.(A_1)
				IL_A24:
				num2 = 172
				If Not(TypeOf A_1 Is C1NavBar) Then
					GoTo IL_AA8
				End If
				IL_A32:
				num2 = 173
				Dim c1NavBar As C1NavBar = CType(A_1, C1NavBar)
				IL_A40:
				num2 = 174
				Dim enumerator4 As IEnumerator = c1NavBar.Panels.GetEnumerator()
				While enumerator4.MoveNext()
					Dim obj3 As Object = enumerator4.Current
					Dim c1NavBarPanel As C1NavBarPanel = CType(obj3, C1NavBarPanel)
					IL_A64:
					num2 = 175
					oOO0oo_o0.O00OO_O_oO_.o.(c1NavBarPanel.Controls)
					IL_A76:
					num2 = 176
				End While
				IL_A85:
				num2 = 177
				If TypeOf enumerator4 Is IDisposable Then
					TryCast(enumerator4, IDisposable).Dispose()
				End If
				IL_AA0:
				c1NavBar = Nothing
				GoTo IL_C7B
				IL_AA8:
				num2 = 180
				If Not(TypeOf A_1 Is C1NavBar) Then
					GoTo IL_B2C
				End If
				IL_AB6:
				num2 = 181
				Dim c1DockingTab As C1DockingTab = CType(A_1, C1DockingTab)
				IL_AC4:
				num2 = 182
				Dim enumerator5 As IEnumerator = c1DockingTab.TabPages.GetEnumerator()
				While enumerator5.MoveNext()
					Dim obj4 As Object = enumerator5.Current
					Dim c1DockingTabPage As C1DockingTabPage = CType(obj4, C1DockingTabPage)
					IL_AE8:
					num2 = 183
					oOO0oo_o0.O00OO_O_oO_.o.(c1DockingTabPage.Controls)
					IL_AFA:
					num2 = 184
				End While
				IL_B09:
				num2 = 185
				If TypeOf enumerator5 Is IDisposable Then
					TryCast(enumerator5, IDisposable).Dispose()
				End If
				IL_B24:
				c1DockingTab = Nothing
				GoTo IL_C7B
				IL_B2C:
				num2 = 188
				If Not(TypeOf A_1 Is System.Windows.Forms.SplitContainer) Then
					GoTo IL_B7E
				End If
				IL_B3A:
				num2 = 189
				Dim splitContainer As System.Windows.Forms.SplitContainer = CType(A_1, System.Windows.Forms.SplitContainer)
				IL_B48:
				num2 = 190
				oOO0oo_o0.O00OO_O_oO_.o.(splitContainer.Panel1.Controls)
				IL_B5F:
				num2 = 191
				oOO0oo_o0.O00OO_O_oO_.o.(splitContainer.Panel2.Controls)
				IL_B76:
				splitContainer = Nothing
				GoTo IL_C7B
				IL_B7E:
				num2 = 194
				If Not(TypeOf A_1 Is C1DockingTab) Then
					GoTo IL_C6A
				End If
				IL_B8F:
				num2 = 195
				Dim c1DockingTab2 As C1DockingTab = CType(A_1, C1DockingTab)
				IL_B9D:
				num2 = 196
				Dim enumerator6 As IEnumerator = c1DockingTab2.TabPages.GetEnumerator()
				While enumerator6.MoveNext()
					Dim obj5 As Object = enumerator6.Current
					Dim c1DockingTabPage2 As C1DockingTabPage = CType(obj5, C1DockingTabPage)
					IL_BC1:
					num2 = 197
					oOO0oo_o0.O00OO_O_oO_.o.(c1DockingTabPage2.Controls)
					IL_BD3:
					num2 = 198
				End While
				IL_BE2:
				num2 = 199
				If TypeOf enumerator6 Is IDisposable Then
					TryCast(enumerator6, IDisposable).Dispose()
				End If
				IL_BFD:
				num2 = 200
				For k As Integer = c1DockingTab2.TabPages.Count - 1 To 0
					IL_C15:
					num2 = 201
					Dim c1DockingTabPage3 As C1DockingTabPage = c1DockingTab2.TabPages(k)
					IL_C2B:
					num2 = 202
					c1DockingTab2.TabPages.RemoveAt(k)
					IL_C3F:
					num2 = 203
					c1DockingTabPage3.Dispose()
					IL_C4C:
					num2 = 204
				Next
				IL_C5D:
				c1DockingTab2 = Nothing
				IL_C60:
				num2 = 206
				flag = True
				GoTo IL_C7B
				IL_C6A:
				num2 = 208
				oOO0oo_o0.O00OO_O_oO_.o.(A_1.Controls)
				IL_C7B:
				num2 = 209
				A_1.DataBindings.Clear()
				IL_C8C:
				num2 = 210
				If TypeOf A_1 Is O_oOooO_O Then
					GoTo IL_CA7
				End If
				IL_C9A:
				num2 = 212
				A_1.CausesValidation = False
				IL_CA7:
				num2 = 213
				A_0.Remove(A_1)
				IL_CB4:
				num2 = 214
				If Not flag Then
					GoTo IL_D3A
				End If
				IL_CBD:
				num2 = 215
				If Not(TypeOf A_1 Is O_oOooO_O) Then
					GoTo IL_D2E
				End If
				IL_CCB:
				num2 = 216
				Dim o_oOooO_O2 As O_oOooO_O = CType(A_1, O_oOooO_O)
				IL_CD9:
				num2 = 217
				Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { A_1 })
				IL_CF3:
				num2 = 218
				o_oOooO_O2.Styles.Clear()
				IL_D05:
				num2 = 219
				o_oOooO_O2.Rows.Count = 0
				IL_D18:
				num2 = 220
				o_oOooO_O2.Cols.Count = 0
				IL_D2B:
				o_oOooO_O2 = Nothing
				IL_D2E:
				num2 = 222
				A_1.Dispose()
				IL_D3A:
				GoTo IL_1108
				IL_D3F:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_10C9:
				GoTo IL_10FD
				IL_10CB:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_10DB:
			Catch obj7 When endfilter(TypeOf obj6 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj7, Exception)
				GoTo IL_10CB
			End Try
			IL_10FD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1108:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003F15 RID: 16149 RVA: 0x001B6434 File Offset: 0x001B4634
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control.ControlCollection)
			For i As Integer = A_0.Count - 1 To 0 Step -1
				Dim a_ As System.Windows.Forms.Control = A_0(i)
				oOO0oo_o0.O00OO_O_oO_.o.(A_0, a_)
			Next
		End Sub

		' Token: 0x06003F16 RID: 16150 RVA: 0x001B6464 File Offset: 0x001B4664
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			If TypeOf A_0 Is O0oo000oO0oo_ Then
				Dim o0oo000oO0oo_ As O0oo000oO0oo_ = CType(A_0, O0oo000oO0oo_)
				If o0oo000oO0oo_.O_.0.() IsNot Nothing Then
					Dim marshalByValueComponent As MarshalByValueComponent = CType(o0oo000oO0oo_.O_.0.(), DataView)
					o0oo000oO0oo_.OoO.0oo_Oo_.(Nothing)
					marshalByValueComponent.Dispose()
				End If
			ElseIf TypeOf A_0 Is OoOO0Oo_oo0oO Then
				Dim ooOO0Oo_oo0oO As OoOO0Oo_oo0oO = CType(A_0, OoOO0Oo_oo0oO)
				If ooOO0Oo_oo0oO.OO0._0O.() IsNot Nothing Then
					Dim marshalByValueComponent2 As MarshalByValueComponent = CType(ooOO0Oo_oo0oO.OO0._0O.(), DataView)
					ooOO0Oo_oo0oO.o_O0.OO0o0O0o.(Nothing)
					marshalByValueComponent2.Dispose()
				End If
			ElseIf TypeOf A_0 Is CustomCheckedListBox Then
				Dim customCheckedListBox As CustomCheckedListBox = CType(A_0, CustomCheckedListBox)
				If customCheckedListBox.DataSource IsNot Nothing Then
					Dim marshalByValueComponent3 As MarshalByValueComponent = CType(customCheckedListBox.DataSource, DataView)
					customCheckedListBox.DataSource = Nothing
					marshalByValueComponent3.Dispose()
				End If
			ElseIf TypeOf A_0 Is CustomListBox Then
				Dim customListBox As CustomListBox = CType(A_0, CustomListBox)
				If customListBox.DataSource IsNot Nothing Then
					Dim marshalByValueComponent4 As MarshalByValueComponent = CType(customListBox.DataSource, DataView)
					customListBox.DataSource = Nothing
					marshalByValueComponent4.Dispose()
				End If
			End If
			If oOO0oo_o0.ooo_o__OO_.o. Is Nothing Then
				oOO0oo_o0.ooo_o__OO_.o. = 1
				Dim o0_00o.o0__o. As ProjectProperty = O_O0OO.O0_00o.o0__o.
				If Operators.CompareString(Conversions.ToString(GetType(ProjectProperty).GetProperty(o0OoOOoOOo0.o0_.O_. + "Name", BindingFlags.Instance Or BindingFlags.[Public]).GetValue(O_O0OO.O0_00o.o0__o., Nothing)), O_O0OO.Oo_o000oO.oO., True) <> 0 Then
					Dim oleDbCommand As OleDbCommand = New OleDbCommand("Update [" + ooO0__OO.o0O._ooo_O_.() + "] Set [Name] =  [Name] + '" & vbLf & "'", O_O0OO.OoO.0OO__0ooo.())
					O_O0OO.OoO.0OO__0ooo.().Open()
					oleDbCommand.ExecuteNonQuery()
					O_O0OO.OoO.0OO__0ooo.().Close()
				End If
			End If
		End Sub

		' Token: 0x06003F17 RID: 16151 RVA: 0x001B65C7 File Offset: 0x001B47C7
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			A_0 = A_0.Parent
			While A_0 IsNot Nothing
				If TypeOf A_0 Is FormPanel Then
					CType(A_0, FormPanel).PrintPropExtender1.Refresh()
					Return
				End If
				A_0 = A_0.Parent
			End While
		End Sub

		' Token: 0x06003F18 RID: 16152 RVA: 0x001B65F8 File Offset: 0x001B47F8
		Public Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			If A_0.DataBindings.Count > 0 Then
				If TypeOf A_0 Is C1TextBox AndAlso CType(A_0, C1TextBox).UpdateValueWithCurrentText() Then
					A_0.DataBindings(0).WriteValue()
				End If
				If A_0.DataBindings(0).BindingManagerBase.Count > 0 Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(A_0.DataBindings(0).BindingManagerBase.Current)
					If objectValue IsNot Nothing Then
						CType(objectValue, DataRowView).Row.EndEdit()
					End If
				End If
			End If
		End Sub

		' Token: 0x06003F19 RID: 16153 RVA: 0x001B6684 File Offset: 0x001B4884
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, ByRef A_1 As String)
			Try
				For Each obj As Object In A_0
					Dim treeNode As System.Windows.Forms.TreeNode = CType(obj, System.Windows.Forms.TreeNode)
					Dim a_ As CustomTreeNodeProperty = New CustomTreeNodeProperty(CType(treeNode, O_o__00Ooo))
					If Operators.CompareString(A_1, "", True) <> 0 Then
						A_1 += vbFormFeed
					End If
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbTab, False).Replace(vbFormFeed, "")
					If treeNode.Nodes.Count > 0 Then
						A_1 += vbFormFeed & "Inner"
						oOO0oo_o0.O__o0o0O0O_.0.(treeNode.Nodes, A_1)
						A_1 += vbFormFeed & "Outer"
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F1A RID: 16154 RVA: 0x001B675C File Offset: 0x001B495C
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As TreeNodeCollection, ByRef A_1 As String)
			Try
				For Each obj As Object In A_0
					Dim treeNode As System.Windows.Forms.TreeNode = CType(obj, System.Windows.Forms.TreeNode)
					Dim a_ As SimpleNodeProperty = New SimpleNodeProperty(CType(treeNode, O_o__00Ooo))
					If Operators.CompareString(A_1, "", True) <> 0 Then
						A_1 += vbFormFeed
					End If
					A_1 += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbTab, False).Replace(vbFormFeed, "")
					If treeNode.Nodes.Count > 0 Then
						A_1 += vbFormFeed & "Inner"
						oOO0oo_o0.o.O0o000_.(treeNode.Nodes, A_1)
						A_1 += vbFormFeed & "Outer"
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F1B RID: 16155 RVA: 0x001B6834 File Offset: 0x001B4A34
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.TreeView, A_1 As DataTable, A_2 As String, A_3 As String, A_4 As String, A_5 As String, Optional A_6 As Boolean = True)
			A_0.Nodes.Clear()
			Dim text As String = ""
			If A_4 Is Nothing Then
				A_4 = ""
			End If
			Dim array As String() = A_4.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
			Dim array2 As String() = A_5.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
			For Each text2 As String In array
				If Not A_1.Columns.Contains(text2) Then
					MessageBox.Show("无效列名：" + text2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
			Next
			For Each text3 As String In array2
				If Not A_1.Columns.Contains(text3) Then
					MessageBox.Show("无效列名：" + text3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				If Operators.CompareString(text, "", True) > 0 Then
					text += ","
				End If
				text += text3
			Next
			Operators.CompareString(A_2, "", True)
			If Operators.CompareString(A_3, "", True) > 0 Then
				text = A_3
			End If
			Dim dataView As DataView = New DataView(A_1, "", "", DataViewRowState.CurrentRows)
			Try
				dataView.RowFilter = A_2
				dataView.Sort = text
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			Dim nodes As TreeNodeCollection = A_0.Nodes
			If dataView.Count <> 0 Then
				A_0.BeginUpdate()
				Dim num As Integer = dataView.Count - 1
				For k As Integer = 0 To num
					nodes = A_0.Nodes
					Dim flag As Boolean = False
					Dim num2 As Integer = array2.Length - 1
					Dim num3 As Integer = 0
					While num3 <= num2 AndAlso Operators.CompareString(dataView(k).Row(array2(num3)).ToString(), "", True) <> 0 AndAlso (num3 <= 0 OrElse Operators.CompareString(dataView(k).Row(array2(num3 - 1)).ToString(), "", True) <> 0)
						Dim text4 As String
						If A_1.Columns(array2(num3)).DataType Is GetType(DateTime) Then
							Dim dateTime As DateTime = Conversions.ToDate(dataView(k)(array2(num3)))
							If DateTime.Compare(dateTime, dateTime.[Date]) = 0 Then
								text4 = Strings.Format(dateTime, "yyyy-MM-dd")
							ElseIf dateTime.Second = 0 Then
								text4 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm")
							Else
								text4 = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss")
							End If
						Else
							text4 = dataView(k)(array2(num3)).ToString()
							If Operators.CompareString(text4, "", True) > 0 Then
								text4 = text4.Trim()
							End If
						End If
						If Operators.CompareString(text4, "", True) <> 0 Then
							If Not flag AndAlso k > 0 AndAlso String.Compare(dataView(k)(array2(num3)).ToString(), dataView(k - 1)(array2(num3)).ToString(), True) = 0 AndAlso (num3 = 0 OrElse String.Compare(dataView(k)(array2(num3 - 1)).ToString(), dataView(k - 1)(array2(num3 - 1)).ToString(), True) = 0) Then
								If num3 < array2.Length - 1 Then
									nodes = nodes(text4).Nodes
								End If
							ElseIf nodes.ContainsKey(text4) Then
								Dim o_o__00Ooo As O_o__00Ooo = CType(nodes(text4), O_o__00Ooo)
								nodes = o_o__00Ooo.Nodes
							Else
								flag = True
								Dim o_o__00Ooo As O_o__00Ooo = New O_o__00Ooo()
								o_o__00Ooo.Text = text4
								o_o__00Ooo.Name = o_o__00Ooo.Text
								nodes.Add(o_o__00Ooo)
								nodes = o_o__00Ooo.Nodes
								If A_6 Then
									If array.Length > 0 Then
										If num3 = array2.Length - 1 Then
											Dim text5 As String = ""
											For Each [property] As String In array
												text5 = text5 + vbTab + dataView(k)([property]).ToString()
											Next
											o_o__00Ooo.Tag = text5.Trim(New Char() { vbTab })
										End If
									Else
										o_o__00Ooo.Tag = dataView(k).Row
									End If
								End If
							End If
						End If
						num3 += 1
					End While
				Next
				A_0.EndUpdate()
			End If
		End Sub

		' Token: 0x06003F1C RID: 16156 RVA: 0x001B6CCC File Offset: 0x001B4ECC
		Public Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control) As ChildrenCollection
			Dim control As System.Windows.Forms.Control = A_0
			Dim childrenCollection As ChildrenCollection = New ChildrenCollection()
			While Not(TypeOf A_0 Is FormPanel)
				A_0 = A_0.Parent
			End While
			Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(A_0.Name)
			Try
				For Each obj As Object In control.Controls
					Dim control2 As Foxtable.WinForm.Control = ooO_0O.o_O0.O_.(CType(obj, System.Windows.Forms.Control))
					If control2 IsNot Nothing Then
						childrenCollection.Add(control2)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return childrenCollection
		End Function

		' Token: 0x06003F1D RID: 16157 RVA: 0x001B6D5C File Offset: 0x001B4F5C
		Friend Shared Function <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control, A_1 As String) As Boolean
			Dim assembly As Assembly = Nothing
			Dim parent As System.Windows.Forms.Control = A_0.Parent
			While parent IsNot Nothing
				If TypeOf parent Is FormPanel Then
					assembly = OO_00oOO.Forms(parent.Name).O_0.O00o_00_O.
					Exit While
				End If
				parent = parent.Parent
			End While
			Dim result As Boolean
			If assembly Is Nothing Then
				result = False
			Else
				A_1 = o0OoOOoOOo0.OO0._Oo0o.(A_1)
				result = (assembly.[GetType]("UserCode").GetMethod(A_1) IsNot Nothing)
			End If
			Return result
		End Function

		' Token: 0x06003F1E RID: 16158 RVA: 0x001B6DC4 File Offset: 0x001B4FC4
		Friend Shared Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Control)
			Dim parent As System.Windows.Forms.Control = A_0.Parent
			While parent IsNot Nothing
				If TypeOf parent Is FormPanel Then
					Dim [error] As String = CType(parent, FormPanel).ErrorProvider1.GetError(A_0)
					If [error] IsNot Nothing Then
						Dim formPanel As FormPanel = CType(parent, FormPanel)
						formPanel.ooOo.o_. = A_0
						formPanel.ooOo.o_. = [error]
						Return
					End If
				Else
					parent = parent.Parent
				End If
			End While
		End Sub

		' Token: 0x04001A0F RID: 6671
		Private Shared <<EMPTY_NAME>> As BooleanEnum = 0

		' Token: 0x04001A10 RID: 6672
		Private Shared <<EMPTY_NAME>> As BooleanEnum = 0

		' Token: 0x04001A11 RID: 6673
		Private Shared <<EMPTY_NAME>> As Type = GetType(FTPClient)

		' Token: 0x04001A12 RID: 6674
		Private Shared <<EMPTY_NAME>> As MethodInfo = oOO0oo_o0.ooo_o__OO_.o..GetMethod("Ping")

		' Token: 0x04001A13 RID: 6675
		Private Shared <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
