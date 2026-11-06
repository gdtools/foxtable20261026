Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200018A RID: 394
	Friend Partial Class O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06001231 RID: 4657 RVA: 0x0006EAFD File Offset: 0x0006CCFD
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As o_0OOo0o_0O_
			Return Me.O__0O.OO0Oo.
		End Function

		' Token: 0x06001232 RID: 4658 RVA: 0x0006EB08 File Offset: 0x0006CD08
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As o_0OOo0o_0O_)
			Dim value As MouseEventHandler = AddressOf Me.O__0O.OO0Oo.
			Dim o__0O.OO0Oo. As o_0OOo0o_0O_ = Me.O__0O.OO0Oo.
			If o__0O.OO0Oo. IsNot Nothing Then
				RemoveHandler o__0O.OO0Oo..MouseClick, value
			End If
			Me.O__0O.OO0Oo. = A_0
			o__0O.OO0Oo. = Me.O__0O.OO0Oo.
			If o__0O.OO0Oo. IsNot Nothing Then
				AddHandler o__0O.OO0Oo..MouseClick, value
			End If
		End Sub

		' Token: 0x06001233 RID: 4659 RVA: 0x0006EB4C File Offset: 0x0006CD4C
		Public Sub New(A_0 As f4)
			AddHandler MyBase.Deactivate, AddressOf Me.O__0O.OO0Oo.
			Me.O__0O.OO0Oo.(New o_0OOo0o_0O_())
			Me.O_O0_.0O. = New Dictionary(Of String, String)()
			Me.O_O0_.0O. = A_0
			Me.Text = ""
			MyBase.ControlBox = False
			MyBase.Controls.Add(Me.O__0O.OO0Oo.())
			MyBase.TopMost = True
			MyBase.FormBorderStyle = FormBorderStyle.None
			MyBase.StartPosition = FormStartPosition.Manual
			MyBase.ShowInTaskbar = False
			Me.O__0O.OO0Oo.().Dock = DockStyle.Fill
			Me.O__0O.OO0Oo.().Styles.Normal.Border.Style = 0
			Me.O__0O.OO0Oo.().Styles.EmptyArea.Border.Style = 0
			Me.O__0O.OO0Oo.().Styles.EmptyArea.BackColor = Me.O__0O.OO0Oo.().Styles.Normal.BackColor
			Me.O__0O.OO0Oo.().Styles.Normal.ImageAlign = 4
			Me.O__0O.OO0Oo.().Rows.Count = 0
			Me.O__0O.OO0Oo.().Cols.Count = 9
			Me.O__0O.OO0Oo.().Rows.Fixed = 0
			Me.O__0O.OO0Oo.().Cols.Fixed = 0
			Me.O__0O.OO0Oo.().SelectionMode = 1
			Me.O__0O.OO0Oo.().HighLight = 0
			Me.O__0O.OO0Oo.().BorderStyle = 4
			Me.O__0O.OO0Oo.().AllowEditing = False
			Try
				For Each text As String In OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + "faces")
					Dim image As Image = OO_00oOO.GetImage(text)
					Dim num2 As Integer
					Dim num As Integer = num2 / 9
					Dim num3 As Integer = num2 Mod 9
					If Me.O__0O.OO0Oo.().Rows.Count < num + 1 Then
						Me.O__0O.OO0Oo.().Rows.Count = Me.O__0O.OO0Oo.().Rows.Count + 1
					End If
					Me.O__0O.OO0Oo.().SetCellImage(num, num3, image)
					Me.O_O0_.0O..Add(Conversions.ToString(num) + "," + Conversions.ToString(num3), OO_00oOO.FileSys.GetName(text))
					num2 += 1
				Next
			Finally
				Dim enumerator As IEnumerator(Of String)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Dim num4 As Integer = Me.O__0O.OO0Oo.().Cols.Count - 1
			For i As Integer = 0 To num4
				Me.O__0O.OO0Oo.().AutoSizeCol(i)
				Me.O__0O.OO0Oo.().Cols(i).ImageAndText = False
			Next
			Dim num5 As Integer = Me.O__0O.OO0Oo.().Rows.Count - 1
			For j As Integer = 0 To num5
				Me.O__0O.OO0Oo.().AutoSizeRow(j)
			Next
			MyBase.Width = Me.O__0O.OO0Oo.().Cols(Me.O__0O.OO0Oo.().Cols.Count - 1).Left + Me.O__0O.OO0Oo.().Cols(Me.O__0O.OO0Oo.().Cols.Count - 1).Width + 3
			MyBase.Height = Me.O__0O.OO0Oo.().Rows(Me.O__0O.OO0Oo.().Rows.Count - 1).Top + Me.O__0O.OO0Oo.().Rows(Me.O__0O.OO0Oo.().Rows.Count - 1).Height + 6
			Me.O__0O.OO0Oo.().ScrollBars = ScrollBars.None
		End Sub

		' Token: 0x06001234 RID: 4660 RVA: 0x0006EEDC File Offset: 0x0006D0DC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			MyBase.Hide()
			Dim key As String = Conversions.ToString(Me.O__0O.OO0Oo.().Row) + "," + Conversions.ToString(Me.O__0O.OO0Oo.().Col)
			If Me.O_O0_.0O..ContainsKey(key) Then
				Me.O_O0_.0O..oOO_._0_0o_0.(Me.O_O0_.0O.(key))
			End If
		End Sub

		' Token: 0x06001235 RID: 4661 RVA: 0x0006EF3F File Offset: 0x0006D13F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Hide()
		End Sub

		' Token: 0x0400070A RID: 1802
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As o_0OOo0o_0O_

		' Token: 0x0400070B RID: 1803
		Private <<EMPTY_NAME>> As f4

		' Token: 0x0400070C RID: 1804
		Private <<EMPTY_NAME>> As Dictionary(Of String, String)
	End Class
End Namespace
