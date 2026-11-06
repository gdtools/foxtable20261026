Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input

Namespace Foxtable
	' Token: 0x02000074 RID: 116
	<EditorBrowsable(EditorBrowsableState.Never)>
	<ComVisible(True)>
	Public Class BuildInDropTree
		Inherits C1DropDownControl

		' Token: 0x060003FB RID: 1019 RVA: 0x0000DF54 File Offset: 0x0000C154
		Public Sub New(A_0 As String, A_1 As String, Optional A_2 As Boolean = True)
			MyBase.DropDownClosed += AddressOf Me.Ooo._0oO.
			MyBase.DropDownOpened += AddressOf Me.Ooo._0oO.
			AddHandler MyBase.KeyDown, AddressOf Me.Ooo._0oO.
			AddHandler MyBase.KeyPress, AddressOf Me.Ooo._0oO.
			MyBase.BeforeDropDownOpen += AddressOf Me.Ooo._0oO.
			Me.Ooo._0oO. = True
			Me.ShowUpDownButtons = False
			Me.DataType = GetType(String)
			Me.Ooo._0oO. = New O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(A_0, A_1, A_2)
			Me.DropDownForm = Me.Ooo._0oO.
			MyBase.VisualStyle = 1
		End Sub

		' Token: 0x060003FC RID: 1020 RVA: 0x0000E000 File Offset: 0x0000C200
		Friend Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As String, A_4 As Char, A_5 As String, A_6 As String)
			Me.New(OO_00oOO.DataTables(A_0), A_1, A_2, A_3, A_4, A_5, A_6)
		End Sub

		' Token: 0x060003FD RID: 1021 RVA: 0x0000E020 File Offset: 0x0000C220
		Friend Sub New(A_0 As DataTable, A_1 As String, A_2 As String, A_3 As String, A_4 As Char, A_5 As String, A_6 As String)
			MyBase.DropDownClosed += AddressOf Me.Ooo._0oO.
			MyBase.DropDownOpened += AddressOf Me.Ooo._0oO.
			AddHandler MyBase.KeyDown, AddressOf Me.Ooo._0oO.
			AddHandler MyBase.KeyPress, AddressOf Me.Ooo._0oO.
			MyBase.BeforeDropDownOpen += AddressOf Me.Ooo._0oO.
			Me.Ooo._0oO. = True
			Me.ShowUpDownButtons = False
			Me.DataType = GetType(String)
			Me.Ooo._0oO. = New O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
			Me.DropDownForm = Me.Ooo._0oO.
			MyBase.VisualStyle = 1
		End Sub

		' Token: 0x17000126 RID: 294
		' (set) Token: 0x060003FE RID: 1022 RVA: 0x0000E0D4 File Offset: 0x0000C2D4
		Friend WriteOnly Property Row As Row
			Set(value As Row)
				Me.Ooo._0oO..OooOoOo_.o. = value
			End Set
		End Property

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x060003FF RID: 1023 RVA: 0x0000E0E2 File Offset: 0x0000C2E2
		' (set) Token: 0x06000400 RID: 1024 RVA: 0x0000E0EA File Offset: 0x0000C2EA
		Public Property AllowEditValue As Boolean
			Get
				Return Me.Ooo._0oO.
			End Get
			Set(value As Boolean)
				Me.Ooo._0oO. = value
			End Set
		End Property

		' Token: 0x06000401 RID: 1025 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			Me.Ooo._0oO..O0ooOO_o0.00. = False
		End Sub

		' Token: 0x06000402 RID: 1026 RVA: 0x0000E101 File Offset: 0x0000C301
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.Ooo._0oO..o.00_O_.().SelectedNode = Nothing
			Me.Ooo._0oO..O0ooOO_o0.00. = True
			Me.Ooo._0oO..Owner = Nothing
		End Sub

		' Token: 0x06000403 RID: 1027 RVA: 0x0000E12C File Offset: 0x0000C32C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If Not Me.AllowEditValue AndAlso A_1.KeyCode = Keys.Delete Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000404 RID: 1028 RVA: 0x0000E14E File Offset: 0x0000C34E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.AllowEditValue Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x06000405 RID: 1029 RVA: 0x0000E166 File Offset: 0x0000C366
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			Me.Ooo._0oO..o.00_O_.().Font = Me.Font
		End Sub

		' Token: 0x040000D9 RID: 217
		Friend <<EMPTY_NAME>> As O\u30020\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3002

		' Token: 0x040000DA RID: 218
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
