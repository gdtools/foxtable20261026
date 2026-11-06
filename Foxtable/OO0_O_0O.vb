Imports System
Imports System.Runtime.CompilerServices
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000085 RID: 133
	Friend Class OO0_O_0O
		Inherits C1DockingTabPage

		' Token: 0x060004CF RID: 1231 RVA: 0x0001B974 File Offset: 0x00019B74
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Table
			Return Me.O_.o_O0O_o__.
		End Function

		' Token: 0x060004D0 RID: 1232 RVA: 0x0001B97C File Offset: 0x00019B7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Table)
			Dim a_ As Table.oO00_O_O = AddressOf Me.O_.o_O0O_o__.
			Dim o_.o_O0O_o__. As Table = Me.O_.o_O0O_o__.
			If o_.o_O0O_o__. IsNot Nothing Then
				RemoveHandler o_.o_O0O_o__..NameChanged, a_
			End If
			Me.O_.o_O0O_o__. = A_0
			o_.o_O0O_o__. = Me.O_.o_O0O_o__.
			If o_.o_O0O_o__. IsNot Nothing Then
				AddHandler o_.o_O0O_o__..NameChanged, a_
			End If
		End Sub

		' Token: 0x060004D1 RID: 1233 RVA: 0x0001B9BF File Offset: 0x00019BBF
		Public Sub New(A_0 As Table)
			AddHandler MyBase.GotFocus, AddressOf Me.O_.o_O0O_o__.
			MyBase.Controls.Add(A_0.foxGrid)
			Me.O_.o_O0O_o__.(A_0)
			Me.O.O0o.()
		End Sub

		' Token: 0x060004D2 RID: 1234 RVA: 0x0001B9F7 File Offset: 0x00019BF7
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_.o_O0O_o__.().foxGrid.Focus()
		End Sub

		' Token: 0x060004D3 RID: 1235 RVA: 0x0001BA0C File Offset: 0x00019C0C
		Private Sub <<EMPTY_NAME>>()
			MyBase.Name = Me.O_.o_O0O_o__.().Name
			If Operators.CompareString(OO_00oOO.DataTables(Me.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName).Caption, "", True) > 0 Then
				Me.Text = OO_00oOO.DataTables(Me.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName).Caption
			Else
				Me.Text = Me.O_.o_O0O_o__.().View.o_o.O0ooOo.().TableName
			End If
			Dim text As String = Me.Text
			Dim o_ As O_0 = Me.O_.o_O0O_o__.().View.O0O_0_0__.0O.()
			While o_ IsNot Nothing
				If Operators.CompareString(OO_00oOO.DataTables(o_.o_o.O0ooOo.().TableName).Caption, "", True) > 0 Then
					text = OO_00oOO.DataTables(o_.o_o.O0ooOo.().TableName).Caption + "." + text
				Else
					text = o_.o_o.O0ooOo.().TableName + "." + text
				End If
				o_ = o_.O0O_0_0__.0O.()
			End While
			MyBase.CaptionText = text
		End Sub

		' Token: 0x060004D4 RID: 1236 RVA: 0x0001BB35 File Offset: 0x00019D35
		Private Sub <<EMPTY_NAME>>()
			Me.O.O0o.()
		End Sub

		' Token: 0x04000102 RID: 258
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Table
	End Class
End Namespace
