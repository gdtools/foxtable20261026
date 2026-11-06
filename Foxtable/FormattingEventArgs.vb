Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200014A RID: 330
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FormattingEventArgs
		Inherits ControlEventArgs

		' Token: 0x06000F79 RID: 3961 RVA: 0x00068C48 File Offset: 0x00066E48
		Public Sub New(A_0 As System.Windows.Forms.Control, A_1 As Foxtable.WinForm.Form, A_2 As FormatEventArgs)
			MyBase.New(A_0, A_1)
			Me.O0o.O_O0. = A_2
			If A_2.Value IsNot Nothing Then
				If Operators.CompareString(A_2.FormatInfo.CustomFormat, "", True) > 0 Then
					A_2.Text = Strings.Format(RuntimeHelpers.GetObjectValue(A_2.Value), A_2.FormatInfo.CustomFormat)
					Return
				End If
				A_2.Text = A_2.Value.ToString()
			End If
		End Sub

		' Token: 0x170002C4 RID: 708
		' (get) Token: 0x06000F7A RID: 3962 RVA: 0x00068CB8 File Offset: 0x00066EB8
		' (set) Token: 0x06000F7B RID: 3963 RVA: 0x00068CC5 File Offset: 0x00066EC5
		Public Property Text As String
			Get
				Return Me.O0o.O_O0..Text
			End Get
			Set(value As String)
				Me.O0o.O_O0..Text = value
			End Set
		End Property

		' Token: 0x170002C5 RID: 709
		' (get) Token: 0x06000F7C RID: 3964 RVA: 0x00068CD4 File Offset: 0x00066ED4
		' (set) Token: 0x06000F7D RID: 3965 RVA: 0x00068D04 File Offset: 0x00066F04
		Public Property Value As Object
			Get
				Dim result As Object
				If Me.O0o.O_O0..Value Is DBNull.Value Then
					result = Nothing
				Else
					result = Me.O0o.O_O0..Value
				End If
				Return result
			End Get
			Set(value As Object)
				Me.O0o.O_O0..Text = value.ToString()
			End Set
		End Property

		' Token: 0x040005F1 RID: 1521
		Private <<EMPTY_NAME>> As FormatEventArgs
	End Class
End Namespace
