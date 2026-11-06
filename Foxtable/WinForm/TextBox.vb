Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000524 RID: 1316
	<ComVisible(True)>
	Public Class TextBox
		Inherits Control
		Implements OoO_

		' Token: 0x06005699 RID: 22169 RVA: 0x00222E9E File Offset: 0x0022109E
		Friend Sub New(A_0 As O0O_O0)
			MyBase.New(A_0, ControlTypeEnum.TextBox)
			Me.OooO.OO0O_. = A_0
		End Sub

		' Token: 0x17001508 RID: 5384
		' (get) Token: 0x0600569A RID: 22170 RVA: 0x00222EAF File Offset: 0x002210AF
		' (set) Token: 0x0600569B RID: 22171 RVA: 0x00222EBC File Offset: 0x002210BC
		<oO0oooo("0750")>
		Public Property Text As String
			Get
				Return Me.OooO.OO0O_..Text
			End Get
			Set(value As String)
				Me.OooO.OO0O_..Value = value
			End Set
		End Property

		' Token: 0x17001509 RID: 5385
		' (get) Token: 0x0600569C RID: 22172 RVA: 0x00222ECC File Offset: 0x002210CC
		' (set) Token: 0x0600569D RID: 22173 RVA: 0x00222F07 File Offset: 0x00221107
		<oO0oooo("0751")>
		Public Property Value As Object
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.OooO.OO0O_..Value)
				Dim result As Object
				If objectValue IsNot Nothing AndAlso Operators.CompareString(objectValue.ToString(), "", True) = 0 Then
					result = Nothing
				Else
					result = objectValue
				End If
				Return result
			End Get
			Set(value As Object)
				Me.OooO.OO0O_..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x1700150A RID: 5386
		' (get) Token: 0x0600569E RID: 22174 RVA: 0x00222F1A File Offset: 0x0022111A
		' (set) Token: 0x0600569F RID: 22175 RVA: 0x00222F27 File Offset: 0x00221127
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.OooO.OO0O_..O0oO_OOOOo0o.o.()
			End Get
			Set(value As BooleanEnum)
				Me.OooO.OO0O_..O0oO_OOOOo0o.o.(value)
			End Set
		End Property

		' Token: 0x1700150B RID: 5387
		' (get) Token: 0x060056A0 RID: 22176 RVA: 0x00222F35 File Offset: 0x00221135
		' (set) Token: 0x060056A1 RID: 22177 RVA: 0x00222F40 File Offset: 0x00221140
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.OooO.OO0O_..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.TextBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.OooO.OO0O_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Me.OooO.OO0O_..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.OooO.OO0O_..DataBindings.Add(binding)
								If Me.OooO.OO0O_..DataBindings.Count > 0 Then
									Dim num As Integer = value.LastIndexOf("."c)
									Dim a_ As String = value.Substring(0, num)
									Dim name As String = value.Substring(num + 1)
									If Me.OooO.OO0O_..DataType IsNot OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType Then
										Me.OooO.OO0O_..DataType = OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType
										MyBase.ReadValue()
									End If
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700150C RID: 5388
		' (get) Token: 0x060056A2 RID: 22178 RVA: 0x002230E8 File Offset: 0x002212E8
		' (set) Token: 0x060056A3 RID: 22179 RVA: 0x002230F6 File Offset: 0x002212F6
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x1700150D RID: 5389
		' (get) Token: 0x060056A4 RID: 22180 RVA: 0x002230F8 File Offset: 0x002212F8
		' (set) Token: 0x060056A5 RID: 22181 RVA: 0x00223105 File Offset: 0x00221305
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.OooO.OO0O_..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.OooO.OO0O_..TextAlign = value
			End Set
		End Property

		' Token: 0x1700150E RID: 5390
		' (get) Token: 0x060056A6 RID: 22182 RVA: 0x00223113 File Offset: 0x00221313
		' (set) Token: 0x060056A7 RID: 22183 RVA: 0x00223120 File Offset: 0x00221320
		Public Property VeticalAlign As VerticalAlignEnum
			Get
				Return Me.OooO.OO0O_..VerticalAlign
			End Get
			Set(value As VerticalAlignEnum)
				Me.OooO.OO0O_..VerticalAlign = value
			End Set
		End Property

		' Token: 0x1700150F RID: 5391
		' (get) Token: 0x060056A8 RID: 22184 RVA: 0x0022312E File Offset: 0x0022132E
		' (set) Token: 0x060056A9 RID: 22185 RVA: 0x0022313C File Offset: 0x0022133C
		<oO0oooo("1862")>
		Public Property MultiLine As Boolean
			Get
				Return Me.OooO.OO0O_..Multiline
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..Multiline = value
				If value Then
					Me.OooO.OO0O_..VerticalAlign = 0
				Else
					Me.OooO.OO0O_..VerticalAlign = 0
				End If
				Me.OooO.OO0O_..AcceptsReturn = value
				Me.OooO.OO0O_..TrimEnd = False
			End Set
		End Property

		' Token: 0x17001510 RID: 5392
		' (get) Token: 0x060056AA RID: 22186 RVA: 0x0022318A File Offset: 0x0022138A
		' (set) Token: 0x060056AB RID: 22187 RVA: 0x00223197 File Offset: 0x00221397
		Public Property WordWrap As Boolean
			Get
				Return Me.OooO.OO0O_..WordWrap
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..WordWrap = value
			End Set
		End Property

		' Token: 0x17001511 RID: 5393
		' (get) Token: 0x060056AC RID: 22188 RVA: 0x002231A5 File Offset: 0x002213A5
		' (set) Token: 0x060056AD RID: 22189 RVA: 0x002231B2 File Offset: 0x002213B2
		Public Property ScrollBars As ScrollBars
			Get
				Return Me.OooO.OO0O_..ScrollBars
			End Get
			Set(value As ScrollBars)
				Me.OooO.OO0O_..ScrollBars = value
			End Set
		End Property

		' Token: 0x17001512 RID: 5394
		' (get) Token: 0x060056AE RID: 22190 RVA: 0x002231C0 File Offset: 0x002213C0
		' (set) Token: 0x060056AF RID: 22191 RVA: 0x002231CD File Offset: 0x002213CD
		<oO0oooo("3098")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.OooO.OO0O_..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.OooO.OO0O_..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001513 RID: 5395
		' (get) Token: 0x060056B0 RID: 22192 RVA: 0x002231DB File Offset: 0x002213DB
		' (set) Token: 0x060056B1 RID: 22193 RVA: 0x002231E8 File Offset: 0x002213E8
		<oO0oooo("3097")>
		Public Property BorderColor As Color
			Get
				Return Me.OooO.OO0O_..BorderColor
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..BorderColor = value
			End Set
		End Property

		' Token: 0x17001514 RID: 5396
		' (get) Token: 0x060056B2 RID: 22194 RVA: 0x002231F6 File Offset: 0x002213F6
		' (set) Token: 0x060056B3 RID: 22195 RVA: 0x00223203 File Offset: 0x00221403
		Public Property CharacterCasing As CharacterCasing
			Get
				Return Me.OooO.OO0O_..CharacterCasing
			End Get
			Set(value As CharacterCasing)
				Me.OooO.OO0O_..CharacterCasing = value
			End Set
		End Property

		' Token: 0x17001515 RID: 5397
		' (get) Token: 0x060056B4 RID: 22196 RVA: 0x00223211 File Offset: 0x00221411
		' (set) Token: 0x060056B5 RID: 22197 RVA: 0x0022321E File Offset: 0x0022141E
		Public Property MaxLength As Integer
			Get
				Return Me.OooO.OO0O_..MaxLength
			End Get
			Set(value As Integer)
				Me.OooO.OO0O_..MaxLength = value
			End Set
		End Property

		' Token: 0x17001516 RID: 5398
		' (get) Token: 0x060056B6 RID: 22198 RVA: 0x0022322C File Offset: 0x0022142C
		' (set) Token: 0x060056B7 RID: 22199 RVA: 0x00223239 File Offset: 0x00221439
		<oO0oooo("1865")>
		Public Property PasswordChar As Char
			Get
				Return Me.OooO.OO0O_..PasswordChar
			End Get
			Set(value As Char)
				Me.OooO.OO0O_..PasswordChar = value
			End Set
		End Property

		' Token: 0x17001517 RID: 5399
		' (get) Token: 0x060056B8 RID: 22200 RVA: 0x00223247 File Offset: 0x00221447
		' (set) Token: 0x060056B9 RID: 22201 RVA: 0x00223254 File Offset: 0x00221454
		<oO0oooo("1866")>
		Public Property EditMask As String
			Get
				Return Me.OooO.OO0O_..EditMask
			End Get
			Set(value As String)
				Me.OooO.OO0O_..EditMask = value
			End Set
		End Property

		' Token: 0x17001518 RID: 5400
		' (get) Token: 0x060056BA RID: 22202 RVA: 0x00223262 File Offset: 0x00221462
		' (set) Token: 0x060056BB RID: 22203 RVA: 0x00223274 File Offset: 0x00221474
		<oO0oooo("1867")>
		Public Property FormatString As String
			Get
				Return Me.OooO.OO0O_..DisplayFormat.CustomFormat
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) = 0 Then
					value = Me.OooO.OO0O_.
				End If
				Me.OooO.OO0O_..DisplayFormat.CustomFormat = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.OooO.OO0O_..DisplayFormat.FormatType = 2
					Return
				End If
				Me.OooO.OO0O_..DisplayFormat.FormatType = 0
			End Set
		End Property

		' Token: 0x17001519 RID: 5401
		' (get) Token: 0x060056BC RID: 22204 RVA: 0x002232DA File Offset: 0x002214DA
		' (set) Token: 0x060056BD RID: 22205 RVA: 0x002232E7 File Offset: 0x002214E7
		Public Property TrimStart As Boolean
			Get
				Return Me.OooO.OO0O_..TrimStart
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..TrimStart = value
			End Set
		End Property

		' Token: 0x1700151A RID: 5402
		' (get) Token: 0x060056BE RID: 22206 RVA: 0x002232F5 File Offset: 0x002214F5
		' (set) Token: 0x060056BF RID: 22207 RVA: 0x00223302 File Offset: 0x00221502
		Public Property TrimEnd As Boolean
			Get
				Return Me.OooO.OO0O_..TrimStart
			End Get
			Set(value As Boolean)
				Me.OooO.OO0O_..TrimEnd = value
			End Set
		End Property

		' Token: 0x1700151B RID: 5403
		' (get) Token: 0x060056C0 RID: 22208 RVA: 0x00223310 File Offset: 0x00221510
		' (set) Token: 0x060056C1 RID: 22209 RVA: 0x0022331D File Offset: 0x0022151D
		<oO0oooo("0720")>
		Public Overrides Property BackColor As Color
			Get
				Return Me.OooO.OO0O_..BackColor
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..BackColor = value
			End Set
		End Property

		' Token: 0x1700151C RID: 5404
		' (get) Token: 0x060056C2 RID: 22210 RVA: 0x0022332B File Offset: 0x0022152B
		' (set) Token: 0x060056C3 RID: 22211 RVA: 0x00223338 File Offset: 0x00221538
		<oO0oooo("0721")>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.OooO.OO0O_..ForeColor
			End Get
			Set(value As Color)
				Me.OooO.OO0O_..ForeColor = value
				Me.OooO.OO0O_..NegativeForeColor = value
			End Set
		End Property

		' Token: 0x1700151D RID: 5405
		' (get) Token: 0x060056C4 RID: 22212 RVA: 0x00223352 File Offset: 0x00221552
		' (set) Token: 0x060056C5 RID: 22213 RVA: 0x0022335F File Offset: 0x0022155F
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.OooO.OO0O_..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.OooO.OO0O_..InitialSelection = value
			End Set
		End Property

		' Token: 0x1700151E RID: 5406
		' (get) Token: 0x060056C6 RID: 22214 RVA: 0x0022336D File Offset: 0x0022156D
		' (set) Token: 0x060056C7 RID: 22215 RVA: 0x0022337A File Offset: 0x0022157A
		<oO0oooo("0740")>
		Public Property SelectedText As String
			Get
				Return Me.OooO.OO0O_..SelectedText
			End Get
			Set(value As String)
				Me.OooO.OO0O_..SelectedText = value
			End Set
		End Property

		' Token: 0x1700151F RID: 5407
		' (get) Token: 0x060056C8 RID: 22216 RVA: 0x00223388 File Offset: 0x00221588
		' (set) Token: 0x060056C9 RID: 22217 RVA: 0x00223395 File Offset: 0x00221595
		Public Property SelectionStart As Integer
			Get
				Return Me.OooO.OO0O_..SelectionStart
			End Get
			Set(value As Integer)
				Me.OooO.OO0O_..SelectionStart = value
			End Set
		End Property

		' Token: 0x17001520 RID: 5408
		' (get) Token: 0x060056CA RID: 22218 RVA: 0x002233A3 File Offset: 0x002215A3
		' (set) Token: 0x060056CB RID: 22219 RVA: 0x002233B0 File Offset: 0x002215B0
		Public Property SelectionLength As Integer
			Get
				Return Me.OooO.OO0O_..SelectionLength
			End Get
			Set(value As Integer)
				Me.OooO.OO0O_..SelectionLength = value
			End Set
		End Property

		' Token: 0x17001521 RID: 5409
		' (get) Token: 0x060056CC RID: 22220 RVA: 0x002233BE File Offset: 0x002215BE
		<oO0oooo("0760")>
		Public ReadOnly Property Lines As String()
			Get
				Return Me.OooO.OO0O_..Lines
			End Get
		End Property

		' Token: 0x060056CD RID: 22221 RVA: 0x002233CB File Offset: 0x002215CB
		Public Sub SelectAll()
			Me.OooO.OO0O_..SelectAll()
		End Sub

		' Token: 0x060056CE RID: 22222 RVA: 0x002233D8 File Offset: 0x002215D8
		Public Sub Copy()
			Me.OooO.OO0O_..Copy()
		End Sub

		' Token: 0x060056CF RID: 22223 RVA: 0x002233E5 File Offset: 0x002215E5
		Public Sub Cut()
			Me.OooO.OO0O_..Cut()
			Me.OooO.OO0O_..UpdateValueWithCurrentText()
		End Sub

		' Token: 0x060056D0 RID: 22224 RVA: 0x002233FE File Offset: 0x002215FE
		Public Sub Paste()
			Me.OooO.OO0O_..Paste()
			Me.OooO.OO0O_..UpdateValueWithCurrentText()
		End Sub

		' Token: 0x060056D1 RID: 22225 RVA: 0x00223417 File Offset: 0x00221617
		Public Sub Undo()
			Me.OooO.OO0O_..Undo()
			Me.OooO.OO0O_..UpdateValueWithCurrentText()
		End Sub

		' Token: 0x060056D2 RID: 22226 RVA: 0x00223430 File Offset: 0x00221630
		Public Sub ResetText()
			Me.OooO.OO0O_..ResetText()
		End Sub

		' Token: 0x060056D3 RID: 22227 RVA: 0x0022343D File Offset: 0x0022163D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x060056D4 RID: 22228 RVA: 0x00223446 File Offset: 0x00221646
		Public Sub AppendText(text As String)
			Me.OooO.OO0O_..AppendText(text)
		End Sub

		' Token: 0x0400222E RID: 8750
		Private <<EMPTY_NAME>> As O0O_O0

		' Token: 0x0400222F RID: 8751
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
