Imports System
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x0200007D RID: 125
	Friend Class OO___OO0O_0
		Inherits C1DockingTab

		' Token: 0x0600042E RID: 1070 RVA: 0x0000FB10 File Offset: 0x0000DD10
		Public Sub New()
			AddHandler MyBase.ControlRemoved, AddressOf Me.oO.O_0_.
			MyBase.SelectedIndexChanging += AddressOf Me.oO.O_0_.
			AddHandler MyBase.ParentChanged, AddressOf Me.oO.O_0_.
			MyBase.VisualStyle = 0
		End Sub

		' Token: 0x0600042F RID: 1071 RVA: 0x0000FB60 File Offset: 0x0000DD60
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ControlEventArgs)
			If Not Main.OO_O.o..o__OO_.Ooo0_. AndAlso MyBase.FindForm() IsNot Nothing AndAlso MyBase.SelectedTab IsNot Nothing Then
				Me.o0.oOO_O.(MyBase.SelectedTab)
			End If
		End Sub

		' Token: 0x06000430 RID: 1072 RVA: 0x0000FB8A File Offset: 0x0000DD8A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As SelectedIndexChangingEventArgs)
			If MyBase.FindForm() IsNot Nothing AndAlso A_1.NewIndex >= 0 Then
				Me.o0.oOO_O.(MyBase.TabPages(A_1.NewIndex))
			End If
		End Sub

		' Token: 0x06000431 RID: 1073 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		Friend Sub <<EMPTY_NAME>>(A_0 As C1DockingTabPage)
			If A_0.Controls.Count = 1 Then
				If TypeOf A_0.Controls(0)Is FormPanel Then
					Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(A_0.Controls(0).Name)
					If form.FormStyle = FormStyleEnum.停靠 OrElse form.FormStyle = FormStyleEnum.共有 Then
						MyBase.ShowCaption = form.ShowDockCaption
						MyBase.CanCloseTabs = form.ShowCloseButton
					End If
					Return
				End If
				If TypeOf A_0.Controls(0)Is FileManager Then
					MyBase.ShowCaption = CType(A_0.Controls(0), FileManager).DataColumn.ShowCaption
					MyBase.CanCloseTabs = CType(A_0.Controls(0), FileManager).DataColumn.AllowClose
					Return
				End If
				If TypeOf A_0.Controls(0)Is PictureViewer Then
					MyBase.ShowCaption = CType(A_0.Controls(0), PictureViewer).DataColumn.ShowCaption
					MyBase.CanCloseTabs = CType(A_0.Controls(0), PictureViewer).DataColumn.AllowClose
					Return
				End If
				If TypeOf A_0.Controls(0)Is O__o Then
					MyBase.ShowCaption = CType(A_0.Controls(0), O__o).o__0_o0.OOO_.().ShowCaption
					MyBase.CanCloseTabs = CType(A_0.Controls(0), O__o).o__0_o0.OOO_.().AllowClose
				End If
			End If
		End Sub

		' Token: 0x06000432 RID: 1074 RVA: 0x0000FD2F File Offset: 0x0000DF2F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Main.OO_O.o. IsNot Nothing AndAlso MyBase.FindForm() IsNot Nothing Then
				Main.OO_O.o..o.O000oo.(New Object() { Me })
			End If
		End Sub
	End Class
End Namespace
