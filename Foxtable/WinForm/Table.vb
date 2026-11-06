Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000523 RID: 1315
	<ComVisible(True)>
	Public Class Table
		Inherits Control

		' Token: 0x06005677 RID: 22135 RVA: 0x00222AB0 File Offset: 0x00220CB0
		Friend Sub New(A_0 As O_oOooO_O)
			MyBase.New(A_0, ControlTypeEnum.Table)
			Me.OooO.OO0O_. = True
			Me.OoOO_.OOo0o_. = True
			Me.OooO.OO0O_. = A_0
			If Environment.OSVersion.Version.Major >= 6 Then
				Me.OooO.OO0O_..BorderStyle = 3
			End If
		End Sub

		' Token: 0x170014F7 RID: 5367
		' (get) Token: 0x06005678 RID: 22136 RVA: 0x00222AFC File Offset: 0x00220CFC
		' (set) Token: 0x06005679 RID: 22137 RVA: 0x00222B14 File Offset: 0x00220D14
		<oO0oooo("1604")>
		Public Property MinRows As Integer
			Get
				Return Me.o.__O0O..PrintSettings.GetMinRows(Me.OooO.OO0O_.)
			End Get
			Set(value As Integer)
				Me.o.__O0O..PrintSettings.SetMinRows(Me.OooO.OO0O_., value)
			End Set
		End Property

		' Token: 0x170014F8 RID: 5368
		' (get) Token: 0x0600567A RID: 22138 RVA: 0x00222B2D File Offset: 0x00220D2D
		' (set) Token: 0x0600567B RID: 22139 RVA: 0x00222B45 File Offset: 0x00220D45
		<oO0oooo("1604")>
		Public Property MaxRows As Integer
			Get
				Return Me.o.__O0O..PrintSettings.GetMaxRows(Me.OooO.OO0O_.)
			End Get
			Set(value As Integer)
				Me.o.__O0O..PrintSettings.SetMaxRows(Me.OooO.OO0O_., value)
			End Set
		End Property

		' Token: 0x170014F9 RID: 5369
		' (get) Token: 0x0600567C RID: 22140 RVA: 0x00222B5E File Offset: 0x00220D5E
		' (set) Token: 0x0600567D RID: 22141 RVA: 0x00222B76 File Offset: 0x00220D76
		Public Property PrintRowNumber As Boolean
			Get
				Return Me.o.__O0O..PrintSettings.GetPrintRowNumber(Me.OooO.OO0O_.)
			End Get
			Set(value As Boolean)
				Me.o.__O0O..PrintSettings.SetPrintRowNumber(Me.OooO.OO0O_., value)
			End Set
		End Property

		' Token: 0x170014FA RID: 5370
		' (get) Token: 0x0600567E RID: 22142 RVA: 0x00222B8F File Offset: 0x00220D8F
		' (set) Token: 0x0600567F RID: 22143 RVA: 0x00222BA1 File Offset: 0x00220DA1
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ListMode As Boolean
			Get
				Return Me.OooO.OO0O_..o.0O_O0o_..ListMode
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..o.0O_O0o_..ListMode = value
			End Set
		End Property

		' Token: 0x170014FB RID: 5371
		' (get) Token: 0x06005680 RID: 22144 RVA: 0x00222BB4 File Offset: 0x00220DB4
		' (set) Token: 0x06005681 RID: 22145 RVA: 0x00222BC6 File Offset: 0x00220DC6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ShowCheckBox As Boolean
			Get
				Return Me.OooO.OO0O_..o.0O_O0o_..ShowCheckBox
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..o.0O_O0o_..ShowCheckBox = value
			End Set
		End Property

		' Token: 0x170014FC RID: 5372
		' (get) Token: 0x06005682 RID: 22146 RVA: 0x00222BD9 File Offset: 0x00220DD9
		' (set) Token: 0x06005683 RID: 22147 RVA: 0x00222BEB File Offset: 0x00220DEB
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AllowClickSort As Boolean
			Get
				Return Me.OooO.OO0O_..o.0O_O0o_..AllowClickSort
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..o.0O_O0o_..AllowClickSort = value
			End Set
		End Property

		' Token: 0x170014FD RID: 5373
		' (get) Token: 0x06005684 RID: 22148 RVA: 0x00222C00 File Offset: 0x00220E00
		' (set) Token: 0x06005685 RID: 22149 RVA: 0x00222C10 File Offset: 0x00220E10
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property GridLineDirection As GridLineDirectionEnum
			Get
				Dim result As GridLineDirectionEnum
				Return result
			End Get
			Set(value As GridLineDirectionEnum)
				Select Case value
					Case 0
						Me.OooO.OO0O_..Styles.Normal.Border.Direction = 0
						Return
					Case 1
						Me.OooO.OO0O_..Styles.Normal.Border.Direction = 1
						Return
					Case 2
						Me.OooO.OO0O_..Styles.Normal.Border.Direction = 2
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x170014FE RID: 5374
		' (get) Token: 0x06005686 RID: 22150 RVA: 0x00222C85 File Offset: 0x00220E85
		' (set) Token: 0x06005687 RID: 22151 RVA: 0x00222C97 File Offset: 0x00220E97
		Public Property Theme As String
			Get
				Return Main.OO_O.o..o0_o_o_0.0O.(Me.OooO.OO0O_.)
			End Get
			Set(value As String)
				If Operators.CompareString(Main.OO_O.o..o0_o_o_0.0O.(Me.OooO.OO0O_.), value, True) <> 0 Then
					Me.Table.Theme = value
					If Me.OooO.OO0O_..FindForm() Is Nothing Then
						Me.Table.O0o_OOO.__O.()
					End If
				End If
			End Set
		End Property

		' Token: 0x170014FF RID: 5375
		' (get) Token: 0x06005688 RID: 22152 RVA: 0x00222CD6 File Offset: 0x00220ED6
		' (set) Token: 0x06005689 RID: 22153 RVA: 0x00222CF4 File Offset: 0x00220EF4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property GridColor As Color
			Get
				Return Me.OooO.OO0O_..Styles.Normal.Border.Color
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..Styles.Normal.Border.Color = value
				If Me.OooO.OO0O_..Styles.Contains("CurrentRow") Then
					Me.OooO.OO0O_..Styles("CurrentRow").Border.Color = value
				End If
			End Set
		End Property

		' Token: 0x17001500 RID: 5376
		' (get) Token: 0x0600568A RID: 22154 RVA: 0x00222D53 File Offset: 0x00220F53
		' (set) Token: 0x0600568B RID: 22155 RVA: 0x00222D6F File Offset: 0x00220F6F
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BorderWidth As Integer
			Get
				Return Me.OooO.OO0O_..Styles.Normal.Border.Width
			End Get
			Set(value As Integer)
				Me.OooO.OO0O_..Styles.Normal.Border.Width = value
				Me.OooO.OO0O_..Styles.EmptyArea.Border.Width = value
			End Set
		End Property

		' Token: 0x17001501 RID: 5377
		' (get) Token: 0x0600568C RID: 22156 RVA: 0x00222DA7 File Offset: 0x00220FA7
		' (set) Token: 0x0600568D RID: 22157 RVA: 0x00222DBF File Offset: 0x00220FBF
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property RowHeaderVisible As Boolean
			Get
				Return Me.OooO.OO0O_..Cols(0).Visible
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..Cols(0).Visible = value
			End Set
		End Property

		' Token: 0x17001502 RID: 5378
		' (get) Token: 0x0600568E RID: 22158 RVA: 0x00222DD8 File Offset: 0x00220FD8
		' (set) Token: 0x0600568F RID: 22159 RVA: 0x00222DF4 File Offset: 0x00220FF4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property CurrentRowBackColor As Color
			Get
				Return Me.OooO.OO0O_..Styles("CurrentRow").BackColor
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..Styles("CurrentRow").BackColor = value
			End Set
		End Property

		' Token: 0x17001503 RID: 5379
		' (get) Token: 0x06005690 RID: 22160 RVA: 0x00222E11 File Offset: 0x00221011
		' (set) Token: 0x06005691 RID: 22161 RVA: 0x00222E2D File Offset: 0x0022102D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property CurrentRowForeColor As Color
			Get
				Return Me.OooO.OO0O_..Styles("CurrentRow").ForeColor
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..Styles("CurrentRow").ForeColor = value
			End Set
		End Property

		' Token: 0x17001504 RID: 5380
		' (get) Token: 0x06005692 RID: 22162 RVA: 0x00222E4A File Offset: 0x0022104A
		' (set) Token: 0x06005693 RID: 22163 RVA: 0x00222E52 File Offset: 0x00221052
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ColumnList As String
			Get
				Return Me.OooO.OO0O_.
			End Get
			Set(value As String)
				Me.OooO.OO0O_. = value
			End Set
		End Property

		' Token: 0x17001505 RID: 5381
		' (get) Token: 0x06005694 RID: 22164 RVA: 0x00222E5B File Offset: 0x0022105B
		' (set) Token: 0x06005695 RID: 22165 RVA: 0x00222E63 File Offset: 0x00221063
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property FocusRect As Boolean
			Get
				Return Me.OooO.OO0O_.
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_. = value
			End Set
		End Property

		' Token: 0x17001506 RID: 5382
		' (get) Token: 0x06005696 RID: 22166 RVA: 0x00222E6C File Offset: 0x0022106C
		' (set) Token: 0x06005697 RID: 22167 RVA: 0x00222E74 File Offset: 0x00221074
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property AllowEdit As Boolean
			Get
				Return Me.OoOO_.OOo0o_.
			End Get
			Set(value As Boolean)
				Me.OoOO_.OOo0o_. = value
			End Set
		End Property

		' Token: 0x17001507 RID: 5383
		' (get) Token: 0x06005698 RID: 22168 RVA: 0x00222E7D File Offset: 0x0022107D
		Public ReadOnly Property Table As Table
			Get
				Return OO_00oOO.Tables(CType(Me.OooO.OO0O_..DataSource, O_0).Oo._Oo0OO.())
			End Get
		End Property

		' Token: 0x0400222A RID: 8746
		Private <<EMPTY_NAME>> As O_oOooO_O

		' Token: 0x0400222B RID: 8747
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400222C RID: 8748
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400222D RID: 8749
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
