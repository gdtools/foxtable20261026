Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200013C RID: 316
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class oOO
		Inherits C1ColorPicker
		Implements O000O

		' Token: 0x06000F3A RID: 3898 RVA: 0x00068148 File Offset: 0x00066348
		Friend Sub New()
			MyBase.ColorChanged += AddressOf Me.o0.o_0.
			AddHandler MyBase.Enter, AddressOf Me.o__0._Ooo00.
			AddHandler MyBase.GotFocus, AddressOf Me.o00.Oo0.
			AddHandler MyBase.TextChanged, AddressOf Me.O_o0oo._oO0.
			Me.o.Oo. = 0
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.AutoSize = False
			MyBase.VerticalAlign = 1
			MyBase.Padding = New Padding(1, 2, 1, 1)
			MyBase.Color = Color.Empty
		End Sub

		' Token: 0x06000F3B RID: 3899 RVA: 0x0006820C File Offset: 0x0006640C
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.o.Oo.
		End Function

		' Token: 0x06000F3C RID: 3900 RVA: 0x00068214 File Offset: 0x00066414
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.o.Oo. = A_0
			ooO_0O.o_O0.O_.(Me, Me.o.Oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F3D RID: 3901 RVA: 0x00068235 File Offset: 0x00066435
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.o.Oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F3E RID: 3902 RVA: 0x0006824F File Offset: 0x0006644F
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Value = MyBase.Color
		End Sub

		' Token: 0x06000F3F RID: 3903 RVA: 0x00068262 File Offset: 0x00066462
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.o.Oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06000F40 RID: 3904 RVA: 0x0006827C File Offset: 0x0006647C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.o.Oo.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x170002B2 RID: 690
		' (get) Token: 0x06000F41 RID: 3905 RVA: 0x00068298 File Offset: 0x00066498
		' (set) Token: 0x06000F42 RID: 3906 RVA: 0x000682B8 File Offset: 0x000664B8
		Public Property Value2 As Object
			Get
				Return MyBase.Color.ToArgb()
			End Get
			Set(value As Object)
				If value Is DBNull.Value OrElse value Is Nothing Then
					MyBase.Color = Color.Empty
					Return
				End If
				Dim argb As Integer
				If Integer.TryParse(value.ToString(), argb) Then
					If MyBase.Color <> Color.FromArgb(argb) Then
						MyBase.Color = Color.FromArgb(argb)
						Return
					End If
				ElseIf MyBase.Color <> Color.Empty Then
					MyBase.Color = Color.Empty
				End If
			End Set
		End Property

		' Token: 0x06000F43 RID: 3907 RVA: 0x00068328 File Offset: 0x00066528
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Operators.CompareString(Me.Text, "", True) = 0 Then
				MyBase.Value = Color.Transparent
			End If
		End Sub

		' Token: 0x06000F44 RID: 3908 RVA: 0x0006834D File Offset: 0x0006654D
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.o.Oo.
		End Function

		' Token: 0x06000F45 RID: 3909 RVA: 0x00068355 File Offset: 0x00066555
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.o.Oo. = A_0
		End Sub

		' Token: 0x040005DD RID: 1501
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x040005DE RID: 1502
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
