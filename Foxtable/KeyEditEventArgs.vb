Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm

Namespace Foxtable
	' Token: 0x020002F3 RID: 755
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class KeyEditEventArgs
		Inherits KeyEventArgs

		' Token: 0x060027A8 RID: 10152 RVA: 0x0010B684 File Offset: 0x00109884
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As Keys, A_4 As System.Windows.Forms.Control, A_5 As RecordGrid)
			MyBase.New(A_3)
			Me.Oo0O0OO_0_.00. = A_0
			Me.Oo0O0OO_0_.00. = A_1
			Me.Oo0O0OO_0_.00. = A_2
			If A_4 IsNot Nothing Then
				Me.Oo0O0OO_0_.00. = CType(A_4, System.Windows.Forms.TextBox)
			End If
			Me.Oo0O0OO_0_.00. = A_5
		End Sub

		' Token: 0x17000912 RID: 2322
		' (get) Token: 0x060027A9 RID: 10153 RVA: 0x0010B6C2 File Offset: 0x001098C2
		Public ReadOnly Property Table As Table
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x17000913 RID: 2323
		' (get) Token: 0x060027AA RID: 10154 RVA: 0x0010B6CA File Offset: 0x001098CA
		Public ReadOnly Property Row As Row
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x17000914 RID: 2324
		' (get) Token: 0x060027AB RID: 10155 RVA: 0x0010B6D2 File Offset: 0x001098D2
		Public ReadOnly Property Col As Col
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x17000915 RID: 2325
		' (get) Token: 0x060027AC RID: 10156 RVA: 0x0010B6DA File Offset: 0x001098DA
		' (set) Token: 0x060027AD RID: 10157 RVA: 0x0010B6E2 File Offset: 0x001098E2
		Public Property Cancel As Boolean
			Get
				Return MyBase.Handled
			End Get
			Set(value As Boolean)
				MyBase.Handled = value
				MyBase.SuppressKeyPress = value
			End Set
		End Property

		' Token: 0x17000916 RID: 2326
		' (get) Token: 0x060027AE RID: 10158 RVA: 0x0010B6F4 File Offset: 0x001098F4
		' (set) Token: 0x060027AF RID: 10159 RVA: 0x0010B71E File Offset: 0x0010991E
		Public Property SelectedText As String
			Get
				Dim result As String
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					result = Me.Oo0O0OO_0_.00..SelectedText
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					Me.Oo0O0OO_0_.00..SelectedText = value
				End If
			End Set
		End Property

		' Token: 0x17000917 RID: 2327
		' (get) Token: 0x060027B0 RID: 10160 RVA: 0x0010B734 File Offset: 0x00109934
		' (set) Token: 0x060027B1 RID: 10161 RVA: 0x0010B756 File Offset: 0x00109956
		Public Property SelectionLength As Integer
			Get
				Dim selectionLength As Integer
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					selectionLength = Me.Oo0O0OO_0_.00..SelectionLength
				End If
				Return selectionLength
			End Get
			Set(value As Integer)
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					Me.Oo0O0OO_0_.00..SelectionLength = value
				End If
			End Set
		End Property

		' Token: 0x17000918 RID: 2328
		' (get) Token: 0x060027B2 RID: 10162 RVA: 0x0010B76C File Offset: 0x0010996C
		' (set) Token: 0x060027B3 RID: 10163 RVA: 0x0010B78E File Offset: 0x0010998E
		Public Property SelectionStart As Integer
			Get
				Dim selectionStart As Integer
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					selectionStart = Me.Oo0O0OO_0_.00..SelectionStart
				End If
				Return selectionStart
			End Get
			Set(value As Integer)
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					Me.Oo0O0OO_0_.00..SelectionStart = value
				End If
			End Set
		End Property

		' Token: 0x17000919 RID: 2329
		' (get) Token: 0x060027B4 RID: 10164 RVA: 0x0010B7A4 File Offset: 0x001099A4
		' (set) Token: 0x060027B5 RID: 10165 RVA: 0x0010B7CE File Offset: 0x001099CE
		Public Property Text As String
			Get
				Dim result As String
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					result = Me.Oo0O0OO_0_.00..Text
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If Me.Oo0O0OO_0_.00. IsNot Nothing Then
					Me.Oo0O0OO_0_.00..Text = value
				End If
			End Set
		End Property

		' Token: 0x1700091A RID: 2330
		' (get) Token: 0x060027B6 RID: 10166 RVA: 0x0010B7E4 File Offset: 0x001099E4
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x1700091B RID: 2331
		' (get) Token: 0x060027B7 RID: 10167 RVA: 0x0010B7EC File Offset: 0x001099EC
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001073 RID: 4211
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001074 RID: 4212
		Private <<EMPTY_NAME>> As Row

		' Token: 0x04001075 RID: 4213
		Private <<EMPTY_NAME>> As Col

		' Token: 0x04001076 RID: 4214
		Private <<EMPTY_NAME>> As System.Windows.Forms.TextBox

		' Token: 0x04001077 RID: 4215
		Private <<EMPTY_NAME>> As RecordGrid
	End Class
End Namespace
