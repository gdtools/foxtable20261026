Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004FA RID: 1274
	<ComVisible(True)>
	Public Class DropDownBox
		Inherits Control
		Implements OoO_

		' Token: 0x060051BB RID: 20923 RVA: 0x0021B057 File Offset: 0x00219257
		Friend Sub New(A_0 As OooO00O)
			MyBase.New(A_0, ControlTypeEnum.TextBox)
			Me.o.__O0O. = A_0
		End Sub

		' Token: 0x170012C5 RID: 4805
		' (get) Token: 0x060051BC RID: 20924 RVA: 0x0021B068 File Offset: 0x00219268
		' (set) Token: 0x060051BD RID: 20925 RVA: 0x0021B078 File Offset: 0x00219278
		<oO0oooo("2102")>
		Public Property DropFormName As String
			Get
				Return Me.o.__O0O..o.oooOOooo.()
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso OO_00oOO.Forms.Contains(value) AndAlso Conversions.ToInteger(OO_00oOO.Forms(value).O_o_.0o0__o0O.("Type")) <> 233 Then
					MessageBox.Show(value + """不能作为下拉窗口使用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					Return
				End If
				Me.o.__O0O..OO.o.(value)
			End Set
		End Property

		' Token: 0x170012C6 RID: 4806
		' (get) Token: 0x060051BE RID: 20926 RVA: 0x0021B0F0 File Offset: 0x002192F0
		' (set) Token: 0x060051BF RID: 20927 RVA: 0x0021B0FE File Offset: 0x002192FE
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x170012C7 RID: 4807
		' (get) Token: 0x060051C0 RID: 20928 RVA: 0x0021B100 File Offset: 0x00219300
		' (set) Token: 0x060051C1 RID: 20929 RVA: 0x0021B10D File Offset: 0x0021930D
		<oO0oooo("2103")>
		Public Property ShowDropDownButton As Boolean
			Get
				Return Me.o.__O0O..ShowDropDownButton
			End Get
			Set(value As Boolean)
				Me.o.__O0O..ShowDropDownButton = value
			End Set
		End Property

		' Token: 0x170012C8 RID: 4808
		' (get) Token: 0x060051C2 RID: 20930 RVA: 0x0021B11B File Offset: 0x0021931B
		' (set) Token: 0x060051C3 RID: 20931 RVA: 0x0021B128 File Offset: 0x00219328
		<oO0oooo("2104")>
		Public Property ShowUpDownButtons As Boolean
			Get
				Return Me.o.__O0O..ShowUpDownButtons
			End Get
			Set(value As Boolean)
				Me.o.__O0O..ShowUpDownButtons = value
			End Set
		End Property

		' Token: 0x170012C9 RID: 4809
		' (get) Token: 0x060051C4 RID: 20932 RVA: 0x0021B136 File Offset: 0x00219336
		' (set) Token: 0x060051C5 RID: 20933 RVA: 0x0021B143 File Offset: 0x00219343
		<oO0oooo("2105")>
		Public Property ShowModalButton As Boolean
			Get
				Return Me.o.__O0O..ShowModalButton
			End Get
			Set(value As Boolean)
				Me.o.__O0O..ShowModalButton = value
			End Set
		End Property

		' Token: 0x170012CA RID: 4810
		' (get) Token: 0x060051C6 RID: 20934 RVA: 0x0021B151 File Offset: 0x00219351
		' (set) Token: 0x060051C7 RID: 20935 RVA: 0x0021B15E File Offset: 0x0021935E
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o.__O0O..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o.__O0O..InitialSelection = value
			End Set
		End Property

		' Token: 0x170012CB RID: 4811
		' (get) Token: 0x060051C8 RID: 20936 RVA: 0x0021B16C File Offset: 0x0021936C
		' (set) Token: 0x060051C9 RID: 20937 RVA: 0x0021B179 File Offset: 0x00219379
		<oO0oooo("0750")>
		Public Property Text As String
			Get
				Return Me.o.__O0O..Text
			End Get
			Set(value As String)
				Me.o.__O0O..Value = value
			End Set
		End Property

		' Token: 0x170012CC RID: 4812
		' (get) Token: 0x060051CA RID: 20938 RVA: 0x0021B187 File Offset: 0x00219387
		' (set) Token: 0x060051CB RID: 20939 RVA: 0x0021B194 File Offset: 0x00219394
		<oO0oooo("0751")>
		Public Property Value As Object
			Get
				Return Me.o.__O0O..Value
			End Get
			Set(value As Object)
				Me.o.__O0O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170012CD RID: 4813
		' (get) Token: 0x060051CC RID: 20940 RVA: 0x0021B1A7 File Offset: 0x002193A7
		' (set) Token: 0x060051CD RID: 20941 RVA: 0x0021B1B4 File Offset: 0x002193B4
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.__O0O..OO.o.()
			End Get
			Set(value As BooleanEnum)
				Me.o.__O0O..OO.o.(value)
			End Set
		End Property

		' Token: 0x170012CE RID: 4814
		' (get) Token: 0x060051CE RID: 20942 RVA: 0x0021B1C2 File Offset: 0x002193C2
		' (set) Token: 0x060051CF RID: 20943 RVA: 0x0021B1CC File Offset: 0x002193CC
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o.__O0O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.DropDownBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o.__O0O..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Me.o.__O0O..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o.__O0O..DataBindings.Add(binding)
								If Me.o.__O0O..DataBindings.Count > 0 Then
									Dim num As Integer = value.LastIndexOf("."c)
									Dim a_ As String = value.Substring(0, num)
									Dim name As String = value.Substring(num + 1)
									Me.o.__O0O..DataType = OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170012CF RID: 4815
		' (get) Token: 0x060051D0 RID: 20944 RVA: 0x0021B335 File Offset: 0x00219535
		' (set) Token: 0x060051D1 RID: 20945 RVA: 0x0021B342 File Offset: 0x00219542
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o.__O0O..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o.__O0O..TextAlign = value
			End Set
		End Property

		' Token: 0x170012D0 RID: 4816
		' (get) Token: 0x060051D2 RID: 20946 RVA: 0x0021B350 File Offset: 0x00219550
		' (set) Token: 0x060051D3 RID: 20947 RVA: 0x0021B35D File Offset: 0x0021955D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property MultiLine As Boolean
			Get
				Return Me.o.__O0O..Multiline
			End Get
			Set(value As Boolean)
				Me.o.__O0O..Multiline = value
			End Set
		End Property

		' Token: 0x170012D1 RID: 4817
		' (get) Token: 0x060051D4 RID: 20948 RVA: 0x0021B36B File Offset: 0x0021956B
		' (set) Token: 0x060051D5 RID: 20949 RVA: 0x0021B378 File Offset: 0x00219578
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property WordWrap As Boolean
			Get
				Return Me.o.__O0O..WordWrap
			End Get
			Set(value As Boolean)
				Me.o.__O0O..WordWrap = value
			End Set
		End Property

		' Token: 0x170012D2 RID: 4818
		' (get) Token: 0x060051D6 RID: 20950 RVA: 0x0021B386 File Offset: 0x00219586
		' (set) Token: 0x060051D7 RID: 20951 RVA: 0x0021B393 File Offset: 0x00219593
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ScrollBars As ScrollBars
			Get
				Return Me.o.__O0O..ScrollBars
			End Get
			Set(value As ScrollBars)
				Me.o.__O0O..ScrollBars = value
			End Set
		End Property

		' Token: 0x170012D3 RID: 4819
		' (get) Token: 0x060051D8 RID: 20952 RVA: 0x0021B3A1 File Offset: 0x002195A1
		' (set) Token: 0x060051D9 RID: 20953 RVA: 0x0021B3AE File Offset: 0x002195AE
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.__O0O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.__O0O..BorderStyle = value
			End Set
		End Property

		' Token: 0x170012D4 RID: 4820
		' (get) Token: 0x060051DA RID: 20954 RVA: 0x0021B3BC File Offset: 0x002195BC
		' (set) Token: 0x060051DB RID: 20955 RVA: 0x0021B3C9 File Offset: 0x002195C9
		Public Property BorderColor As Color
			Get
				Return Me.o.__O0O..BorderColor
			End Get
			Set(value As Color)
				Me.o.__O0O..BorderColor = value
			End Set
		End Property

		' Token: 0x170012D5 RID: 4821
		' (get) Token: 0x060051DC RID: 20956 RVA: 0x0021B3D7 File Offset: 0x002195D7
		' (set) Token: 0x060051DD RID: 20957 RVA: 0x0021B3E4 File Offset: 0x002195E4
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.o.__O0O..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.o.__O0O..CharacterCasing = value
			End Set
		End Property

		' Token: 0x170012D6 RID: 4822
		' (get) Token: 0x060051DE RID: 20958 RVA: 0x0021B3F2 File Offset: 0x002195F2
		' (set) Token: 0x060051DF RID: 20959 RVA: 0x0021B3FF File Offset: 0x002195FF
		Public Property MaxLength As Integer
			Get
				Return Me.o.__O0O..MaxLength
			End Get
			Set(value As Integer)
				Me.o.__O0O..MaxLength = value
			End Set
		End Property

		' Token: 0x170012D7 RID: 4823
		' (get) Token: 0x060051E0 RID: 20960 RVA: 0x0021B40D File Offset: 0x0021960D
		' (set) Token: 0x060051E1 RID: 20961 RVA: 0x0021B41A File Offset: 0x0021961A
		<oO0oooo("1865")>
		Public Property PasswordChar As Char
			Get
				Return Me.o.__O0O..PasswordChar
			End Get
			Set(value As Char)
				Me.o.__O0O..PasswordChar = value
			End Set
		End Property

		' Token: 0x170012D8 RID: 4824
		' (get) Token: 0x060051E2 RID: 20962 RVA: 0x0021B428 File Offset: 0x00219628
		' (set) Token: 0x060051E3 RID: 20963 RVA: 0x0021B435 File Offset: 0x00219635
		<oO0oooo("1866")>
		Public Property EditMask As String
			Get
				Return Me.o.__O0O..EditMask
			End Get
			Set(value As String)
				Me.o.__O0O..EditMask = value
			End Set
		End Property

		' Token: 0x170012D9 RID: 4825
		' (get) Token: 0x060051E4 RID: 20964 RVA: 0x0021B443 File Offset: 0x00219643
		' (set) Token: 0x060051E5 RID: 20965 RVA: 0x0021B450 File Offset: 0x00219650
		<oO0oooo("1867")>
		Public Property FormatString As String
			Get
				Return Me.o.__O0O..CustomFormat
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = Me.o.__O0O.
				End If
				Me.o.__O0O..CustomFormat = value
				Me.o.__O0O..EditFormat.CustomFormat = Nothing
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o.__O0O..FormatType = 2
					Return
				End If
				Me.o.__O0O..FormatType = 0
			End Set
		End Property

		' Token: 0x170012DA RID: 4826
		' (get) Token: 0x060051E6 RID: 20966 RVA: 0x0021B4B8 File Offset: 0x002196B8
		' (set) Token: 0x060051E7 RID: 20967 RVA: 0x0021B4C5 File Offset: 0x002196C5
		Public Property TrimStart As Boolean
			Get
				Return Me.o.__O0O..TrimStart
			End Get
			Set(value As Boolean)
				Me.o.__O0O..TrimStart = value
			End Set
		End Property

		' Token: 0x170012DB RID: 4827
		' (get) Token: 0x060051E8 RID: 20968 RVA: 0x0021B4D3 File Offset: 0x002196D3
		' (set) Token: 0x060051E9 RID: 20969 RVA: 0x0021B4E0 File Offset: 0x002196E0
		Public Property TrimEnd As Boolean
			Get
				Return Me.o.__O0O..TrimStart
			End Get
			Set(value As Boolean)
				Me.o.__O0O..TrimEnd = value
			End Set
		End Property

		' Token: 0x170012DC RID: 4828
		' (get) Token: 0x060051EA RID: 20970 RVA: 0x0021B4EE File Offset: 0x002196EE
		' (set) Token: 0x060051EB RID: 20971 RVA: 0x0021B4FB File Offset: 0x002196FB
		<oO0oooo("0720")>
		Public Overrides Property BackColor As Color
			Get
				Return Me.o.__O0O..BackColor
			End Get
			Set(value As Color)
				Me.o.__O0O..BackColor = value
			End Set
		End Property

		' Token: 0x170012DD RID: 4829
		' (get) Token: 0x060051EC RID: 20972 RVA: 0x0021B509 File Offset: 0x00219709
		' (set) Token: 0x060051ED RID: 20973 RVA: 0x0021B516 File Offset: 0x00219716
		<oO0oooo("0721")>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o.__O0O..ForeColor
			End Get
			Set(value As Color)
				Me.o.__O0O..ForeColor = value
			End Set
		End Property

		' Token: 0x170012DE RID: 4830
		' (get) Token: 0x060051EE RID: 20974 RVA: 0x0021B524 File Offset: 0x00219724
		' (set) Token: 0x060051EF RID: 20975 RVA: 0x0021B531 File Offset: 0x00219731
		<oO0oooo("0740")>
		Public Property SelectedText As String
			Get
				Return Me.o.__O0O..SelectedText
			End Get
			Set(value As String)
				Me.o.__O0O..SelectedText = value
			End Set
		End Property

		' Token: 0x170012DF RID: 4831
		' (get) Token: 0x060051F0 RID: 20976 RVA: 0x0021B53F File Offset: 0x0021973F
		' (set) Token: 0x060051F1 RID: 20977 RVA: 0x0021B54C File Offset: 0x0021974C
		Public Property SelectionStart As Integer
			Get
				Return Me.o.__O0O..SelectionStart
			End Get
			Set(value As Integer)
				Me.o.__O0O..SelectionStart = value
			End Set
		End Property

		' Token: 0x170012E0 RID: 4832
		' (get) Token: 0x060051F2 RID: 20978 RVA: 0x0021B55A File Offset: 0x0021975A
		' (set) Token: 0x060051F3 RID: 20979 RVA: 0x0021B567 File Offset: 0x00219767
		Public Property SelectionLength As Integer
			Get
				Return Me.o.__O0O..SelectionLength
			End Get
			Set(value As Integer)
				Me.o.__O0O..SelectionLength = value
			End Set
		End Property

		' Token: 0x170012E1 RID: 4833
		' (get) Token: 0x060051F4 RID: 20980 RVA: 0x0021B575 File Offset: 0x00219775
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Lines As String()
			Get
				Return Me.o.__O0O..Lines
			End Get
		End Property

		' Token: 0x060051F5 RID: 20981 RVA: 0x0021B582 File Offset: 0x00219782
		Public Sub SelectAll()
			Me.o.__O0O..SelectAll()
		End Sub

		' Token: 0x060051F6 RID: 20982 RVA: 0x0021B58F File Offset: 0x0021978F
		Public Sub Copy()
			Me.o.__O0O..Copy()
		End Sub

		' Token: 0x060051F7 RID: 20983 RVA: 0x0021B59C File Offset: 0x0021979C
		Public Sub Cut()
			Me.o.__O0O..Cut()
		End Sub

		' Token: 0x060051F8 RID: 20984 RVA: 0x0021B5A9 File Offset: 0x002197A9
		Public Sub Paste()
			Me.o.__O0O..Paste()
		End Sub

		' Token: 0x060051F9 RID: 20985 RVA: 0x0021B5B6 File Offset: 0x002197B6
		Public Sub Undo()
			Me.o.__O0O..Undo()
		End Sub

		' Token: 0x060051FA RID: 20986 RVA: 0x0021B5C3 File Offset: 0x002197C3
		Public Sub ResetText()
			Me.o.__O0O..ResetText()
		End Sub

		' Token: 0x060051FB RID: 20987 RVA: 0x0021B5D0 File Offset: 0x002197D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub CloseDropdown()
			Me.o.__O0O..CloseDropDown()
		End Sub

		' Token: 0x060051FC RID: 20988 RVA: 0x0021B5DD File Offset: 0x002197DD
		Public Sub CloseDropdown(doPost As Boolean)
			Me.o.__O0O..CloseDropDown(doPost)
		End Sub

		' Token: 0x060051FD RID: 20989 RVA: 0x0021B5EB File Offset: 0x002197EB
		Public Sub OpenDropDown()
			Me.o.__O0O..OpenDropDown()
		End Sub

		' Token: 0x170012E2 RID: 4834
		' (get) Token: 0x060051FE RID: 20990 RVA: 0x0021B5F8 File Offset: 0x002197F8
		Public ReadOnly Property DroppedDown As Boolean
			Get
				Return Me.o.__O0O..DroppedDown
			End Get
		End Property

		' Token: 0x170012E3 RID: 4835
		' (get) Token: 0x060051FF RID: 20991 RVA: 0x0021B605 File Offset: 0x00219805
		' (set) Token: 0x06005200 RID: 20992 RVA: 0x0021B612 File Offset: 0x00219812
		Public Property AllowEditValue As Boolean
			Get
				Return Me.o.__O0O..O.0oo0_.()
			End Get
			Set(value As Boolean)
				Me.o.__O0O..o0O.0___0_.(value)
			End Set
		End Property

		' Token: 0x06005201 RID: 20993 RVA: 0x0021B620 File Offset: 0x00219820
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021B7 RID: 8631
		Private <<EMPTY_NAME>> As OooO00O

		' Token: 0x040021B8 RID: 8632
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
