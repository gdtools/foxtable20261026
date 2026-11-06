Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000080 RID: 128
	Friend Class Oo0__Oo
		Inherits C1DockingTabPage

		' Token: 0x06000493 RID: 1171 RVA: 0x0001AEB1 File Offset: 0x000190B1
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Table
			Return Me.OO0_0oOo.o.
		End Function

		' Token: 0x06000494 RID: 1172 RVA: 0x0001AEBC File Offset: 0x000190BC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Table)
			Dim a_ As Table.oO00_O_O = AddressOf Me.O_000__.o.
			Dim oo0_0oOo.o. As Table = Me.OO0_0oOo.o.
			If oo0_0oOo.o. IsNot Nothing Then
				RemoveHandler oo0_0oOo.o..NameChanged, a_
			End If
			Me.OO0_0oOo.o. = A_0
			oo0_0oOo.o. = Me.OO0_0oOo.o.
			If oo0_0oOo.o. IsNot Nothing Then
				AddHandler oo0_0oOo.o..NameChanged, a_
			End If
		End Sub

		' Token: 0x06000495 RID: 1173 RVA: 0x0001AEFF File Offset: 0x000190FF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As OO___OO0O_0
			Return Me.OO0_0oOo.o.
		End Function

		' Token: 0x06000496 RID: 1174 RVA: 0x0001AF07 File Offset: 0x00019107
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OO___OO0O_0)
			Me.OO0_0oOo.o. = A_0
		End Sub

		' Token: 0x06000497 RID: 1175 RVA: 0x0001AF10 File Offset: 0x00019110
		Friend Sub New(A_0 As Table)
			AddHandler MyBase.GotFocus, AddressOf Me.o.0O_O0o_.
			Me.O_000__.o.(New OO___OO0O_0())
			Me.O_000__.o.(A_0)
			MyBase.Name = A_0.Name
			Me.OO0O_o0o.0oOoo.()
			Me.O_000__.o.().BorderStyle = BorderStyle.None
			Me.O_000__.o.().TabsCanFocus = False
			Me.O_000__.o.().Alignment = TabAlignment.Bottom
			Me.O_000__.o.().CanCloseTabs = False
			Me.O_000__.o.().SelectedTabBold = True
			Me.O_000__.o.().Dock = DockStyle.Fill
			Me.O_000__.o.().TabLook = 3
			Me.O_000__.o.().TabPages.Add(New O0o0(A_0))
			Me.O_000__.o.().TabPages(0).Text = "主窗口"
			Me.O_000__.o.().ShowSingleTab = False
			Me.O_000__.o.().TabsCanFocus = False
			MyBase.Controls.Add(Me.O_000__.o.())
			If O_O0OO.O0_00o.o0__o..ShowTableIcon Then
				MyBase.Image = A_0._frdIcon
			End If
		End Sub

		' Token: 0x06000498 RID: 1176 RVA: 0x0001B020 File Offset: 0x00019220
		Private Sub <<EMPTY_NAME>>()
			MyBase.Name = Me.O_000__.o.().Name
			If Operators.CompareString(OO_00oOO.DataTables(Me.O_000__.o.().Name).Caption, "", True) > 0 Then
				Me.Text = OO_00oOO.DataTables(Me.O_000__.o.().Name).Caption
				Return
			End If
			Me.Text = Me.O_000__.o.().Name
		End Sub

		' Token: 0x06000499 RID: 1177 RVA: 0x0001B098 File Offset: 0x00019298
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.OO0_0oOo.o. IsNot Nothing
		End Function

		' Token: 0x0600049A RID: 1178 RVA: 0x0001B0A3 File Offset: 0x000192A3
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.oo.O00_. IsNot Nothing
		End Function

		' Token: 0x0600049B RID: 1179 RVA: 0x0001B0AE File Offset: 0x000192AE
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O__O.o_oOO. IsNot Nothing
		End Function

		' Token: 0x0600049C RID: 1180 RVA: 0x0001B0B9 File Offset: 0x000192B9
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.o_o.oOOoo0oo. IsNot Nothing
		End Function

		' Token: 0x0600049D RID: 1181 RVA: 0x0001B0C4 File Offset: 0x000192C4
		Friend Function <<EMPTY_NAME>>() As o_O0_0O0
			If Me.OO0_0oOo.o. Is Nothing Then
				Me.OO0_0oOo.o. = New o_O0_0O0(DockStyle.Left)
				Me.OO0_0oOo.o..OoOoo_O0o0.0O_.(Me.O_000__.o.().DataTable.frd_LeftDockSize)
				Me.O_000__.o.().TabPages(0).Controls.Add(Me.OO0_0oOo.o.)
				Me.OO0_0oOo.o..SendToBack()
			ElseIf Me.OO0_0oOo.o..FindForm() Is Nothing Then
				Me.O_000__.o.().TabPages(0).Controls.Add(Me.OO0_0oOo.o.)
			End If
			Return Me.OO0_0oOo.o.
		End Function

		' Token: 0x0600049E RID: 1182 RVA: 0x0001B164 File Offset: 0x00019364
		Friend Function <<EMPTY_NAME>>() As o_O0_0O0
			If Me.oo.O00_. Is Nothing Then
				Me.oo.O00_. = New o_O0_0O0(DockStyle.Right)
				Me.oo.O00_..OoOoo_O0o0.0O_.(Me.O_000__.o.().DataTable.frd_RightDockSize)
				Me.O_000__.o.().TabPages(0).Controls.Add(Me.oo.O00_.)
				Me.oo.O00_..SendToBack()
			End If
			Return Me.oo.O00_.
		End Function

		' Token: 0x0600049F RID: 1183 RVA: 0x0001B1D4 File Offset: 0x000193D4
		Friend Function <<EMPTY_NAME>>() As o_O0_0O0
			If Me.O__O.o_oOO. Is Nothing Then
				Me.O__O.o_oOO. = New o_O0_0O0(DockStyle.Bottom)
				Me.O__O.o_oOO..OoOoo_O0o0.0O_.(Me.O_000__.o.().DataTable.frd_BottomDockSize)
				Me.O_000__.o.().TabPages(0).Controls.Add(Me.O__O.o_oOO.)
				Me.O__O.o_oOO..SendToBack()
			End If
			Return Me.O__O.o_oOO.
		End Function

		' Token: 0x060004A0 RID: 1184 RVA: 0x0001B244 File Offset: 0x00019444
		Friend Function <<EMPTY_NAME>>() As o_O0_0O0
			If Me.o_o.oOOoo0oo. Is Nothing Then
				Me.o_o.oOOoo0oo. = New o_O0_0O0(DockStyle.Top)
				Me.o_o.oOOoo0oo..OoOoo_O0o0.0O_.(Me.O_000__.o.().DataTable.frd_TopDockSize)
				Me.O_000__.o.().TabPages(0).Controls.Add(Me.o_o.oOOoo0oo.)
				Me.o_o.oOOoo0oo..SendToBack()
			End If
			Return Me.o_o.oOOoo0oo.
		End Function

		' Token: 0x060004A1 RID: 1185 RVA: 0x0001B2B4 File Offset: 0x000194B4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_000__.o.().FindForm() IsNot Nothing AndAlso Me.O_000__.o.().SelectedTab IsNot Nothing AndAlso Me.O_000__.o.().SelectedTab.Controls.Count > 0 AndAlso TypeOf Me.O_000__.o.().SelectedTab.Controls(0)Is FormPanel Then
				Dim form As Foxtable.WinForm.Form = OO_00oOO.Forms(Me.O_000__.o.().SelectedTab.Controls(0).Name)
				If form.OOOo._. IsNot Nothing Then
					Try
						For Each control As Foxtable.WinForm.Control In form.Controls
							If Operators.CompareString(control.Name, form.OOOo._., True) = 0 Then
								control.[Select]()
								If control.BaseControl.CanFocus Then
									control.BaseControl.Focus()
									Exit For
								End If
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator(Of Foxtable.WinForm.Control)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				End If
			End If
		End Sub

		' Token: 0x060004A2 RID: 1186 RVA: 0x0001B3B8 File Offset: 0x000195B8
		Private Sub <<EMPTY_NAME>>()
			Me.OO0O_o0o.0oOoo.()
		End Sub

		' Token: 0x040000F5 RID: 245
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040000F6 RID: 246
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO___OO0O_0

		' Token: 0x040000F7 RID: 247
		Private <<EMPTY_NAME>> As o_O0_0O0

		' Token: 0x040000F8 RID: 248
		Private <<EMPTY_NAME>> As o_O0_0O0

		' Token: 0x040000F9 RID: 249
		Private <<EMPTY_NAME>> As o_O0_0O0

		' Token: 0x040000FA RID: 250
		Private <<EMPTY_NAME>> As o_O0_0O0
	End Class
End Namespace
