Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002F5 RID: 757
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class KeyPressEditEventArgs
		' Token: 0x060027BD RID: 10173 RVA: 0x0010B838 File Offset: 0x00109A38
		Public Sub New(A_0 As Table, A_1 As Row, A_2 As Col, A_3 As Char, A_4 As System.Windows.Forms.Control, A_5 As RecordGrid)
			Me.O0Ooo0o.0O. = A_0
			Me.O0Ooo0o.0O. = A_1
			Me.Oo0O0OO_0_.00. = A_2
			Me.O0Ooo0o.0O. = Conversions.ToString(A_3)
			Me.O0Ooo0o.0O. = A_5
			If A_4 IsNot Nothing Then
				Me.Oo0O0OO_0_.00. = CType(A_4, System.Windows.Forms.TextBox)
			End If
		End Sub

		' Token: 0x1700091F RID: 2335
		' (get) Token: 0x060027BE RID: 10174 RVA: 0x0010B886 File Offset: 0x00109A86
		Public ReadOnly Property Table As Table
			Get
				Return Me.O0Ooo0o.0O.
			End Get
		End Property

		' Token: 0x17000920 RID: 2336
		' (get) Token: 0x060027BF RID: 10175 RVA: 0x0010B88E File Offset: 0x00109A8E
		Public ReadOnly Property Row As Row
			Get
				Return Me.O0Ooo0o.0O.
			End Get
		End Property

		' Token: 0x17000921 RID: 2337
		' (get) Token: 0x060027C0 RID: 10176 RVA: 0x0010B896 File Offset: 0x00109A96
		Public ReadOnly Property Col As Col
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
		End Property

		' Token: 0x17000922 RID: 2338
		' (get) Token: 0x060027C1 RID: 10177 RVA: 0x0010B89E File Offset: 0x00109A9E
		' (set) Token: 0x060027C2 RID: 10178 RVA: 0x0010B8A6 File Offset: 0x00109AA6
		Public Property KeyChar As String
			Get
				Return Me.O0Ooo0o.0O.
			End Get
			Set(value As String)
				Me.O0Ooo0o.0O. = value
			End Set
		End Property

		' Token: 0x17000923 RID: 2339
		' (get) Token: 0x060027C3 RID: 10179 RVA: 0x0010B8AF File Offset: 0x00109AAF
		' (set) Token: 0x060027C4 RID: 10180 RVA: 0x0010B8B7 File Offset: 0x00109AB7
		Public Property Cancel As Boolean
			Get
				Return Me.Oo0O0OO_0_.00.
			End Get
			Set(value As Boolean)
				Me.Oo0O0OO_0_.00. = value
			End Set
		End Property

		' Token: 0x17000924 RID: 2340
		' (get) Token: 0x060027C5 RID: 10181 RVA: 0x0010B8C0 File Offset: 0x00109AC0
		' (set) Token: 0x060027C6 RID: 10182 RVA: 0x0010B8EA File Offset: 0x00109AEA
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

		' Token: 0x17000925 RID: 2341
		' (get) Token: 0x060027C7 RID: 10183 RVA: 0x0010B900 File Offset: 0x00109B00
		' (set) Token: 0x060027C8 RID: 10184 RVA: 0x0010B922 File Offset: 0x00109B22
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

		' Token: 0x17000926 RID: 2342
		' (get) Token: 0x060027C9 RID: 10185 RVA: 0x0010B938 File Offset: 0x00109B38
		' (set) Token: 0x060027CA RID: 10186 RVA: 0x0010B95A File Offset: 0x00109B5A
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

		' Token: 0x17000927 RID: 2343
		' (get) Token: 0x060027CB RID: 10187 RVA: 0x0010B970 File Offset: 0x00109B70
		' (set) Token: 0x060027CC RID: 10188 RVA: 0x0010B99A File Offset: 0x00109B9A
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

		' Token: 0x17000928 RID: 2344
		' (get) Token: 0x060027CD RID: 10189 RVA: 0x0010B9B0 File Offset: 0x00109BB0
		Public ReadOnly Property RecordGrid As RecordGrid
			Get
				Return Me.O0Ooo0o.0O.
			End Get
		End Property

		' Token: 0x17000929 RID: 2345
		' (get) Token: 0x060027CE RID: 10190 RVA: 0x0010B9B8 File Offset: 0x00109BB8
		Public ReadOnly Property Form As Foxtable.WinForm.Form
			Get
				Return Me.Table.Form
			End Get
		End Property

		' Token: 0x04001079 RID: 4217
		Private <<EMPTY_NAME>> As Table

		' Token: 0x0400107A RID: 4218
		Private <<EMPTY_NAME>> As Row

		' Token: 0x0400107B RID: 4219
		Private <<EMPTY_NAME>> As Col

		' Token: 0x0400107C RID: 4220
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400107D RID: 4221
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400107E RID: 4222
		Private <<EMPTY_NAME>> As System.Windows.Forms.TextBox

		' Token: 0x0400107F RID: 4223
		Private <<EMPTY_NAME>> As RecordGrid
	End Class
End Namespace
