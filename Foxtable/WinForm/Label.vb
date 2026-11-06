Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000515 RID: 1301
	<ComVisible(True)>
	Public Class Label
		Inherits Control
		Implements OoO_

		' Token: 0x06005518 RID: 21784 RVA: 0x0022076D File Offset: 0x0021E96D
		Public Sub New(A_0 As OO_0o_O_O)
			MyBase.New(A_0, ControlTypeEnum.Label)
			Me.o0_0oO.OooO. = A_0
		End Sub

		' Token: 0x1700144E RID: 5198
		' (get) Token: 0x06005519 RID: 21785 RVA: 0x0022077E File Offset: 0x0021E97E
		' (set) Token: 0x0600551A RID: 21786 RVA: 0x0022078B File Offset: 0x0021E98B
		Public Property Text As String
			Get
				Return Me.o0_0oO.OooO..Text
			End Get
			Set(value As String)
				Me.o0_0oO.OooO..Value = value
			End Set
		End Property

		' Token: 0x1700144F RID: 5199
		' (get) Token: 0x0600551B RID: 21787 RVA: 0x00220799 File Offset: 0x0021E999
		' (set) Token: 0x0600551C RID: 21788 RVA: 0x002207A4 File Offset: 0x0021E9A4
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o0_0oO.OooO..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.Label, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o0_0oO.OooO..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Me.o0_0oO.OooO..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.o0_0oO.OooO..DataBindings.Add(binding)
								If Me.o0_0oO.OooO..DataBindings.Count > 0 Then
									Dim num As Integer = value.LastIndexOf("."c)
									Dim a_ As String = value.Substring(0, num)
									Dim name As String = value.Substring(num + 1)
									Me.o0_0oO.OooO..DataType = OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001450 RID: 5200
		' (get) Token: 0x0600551D RID: 21789 RVA: 0x00220905 File Offset: 0x0021EB05
		' (set) Token: 0x0600551E RID: 21790 RVA: 0x00220914 File Offset: 0x0021EB14
		Public Property AutoSize As Boolean
			Get
				Return Me.o0_0oO.OooO..AutoSize
			End Get
			Set(value As Boolean)
				Dim width As Integer = Me.o0_0oO.OooO..Width
				Dim height As Integer = Me.o0_0oO.OooO..Height
				Me.o0_0oO.OooO..AutoSize = value
				Me.o0_0oO.OooO..Width = width
				Me.o0_0oO.OooO..Height = height
			End Set
		End Property

		' Token: 0x17001451 RID: 5201
		' (get) Token: 0x0600551F RID: 21791 RVA: 0x0022095D File Offset: 0x0021EB5D
		' (set) Token: 0x06005520 RID: 21792 RVA: 0x0022096A File Offset: 0x0021EB6A
		Public Overrides Property Width As Integer
			Get
				Return Me.o0_0oO.OooO..Width
			End Get
			Set(value As Integer)
				Me.o0_0oO.OooO..Width = value
			End Set
		End Property

		' Token: 0x17001452 RID: 5202
		' (get) Token: 0x06005521 RID: 21793 RVA: 0x00220978 File Offset: 0x0021EB78
		' (set) Token: 0x06005522 RID: 21794 RVA: 0x00220985 File Offset: 0x0021EB85
		Public Overrides Property Height As Integer
			Get
				Return Me.o0_0oO.OooO..Height
			End Get
			Set(value As Integer)
				Me.o0_0oO.OooO..Height = value
			End Set
		End Property

		' Token: 0x17001453 RID: 5203
		' (get) Token: 0x06005523 RID: 21795 RVA: 0x00220993 File Offset: 0x0021EB93
		' (set) Token: 0x06005524 RID: 21796 RVA: 0x002209A0 File Offset: 0x0021EBA0
		<oO0oooo("3096")>
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o0_0oO.OooO..BorderStyle
			End Get
			Set(value As BorderStyle)
				If Me.o0_0oO.OooO..VisualStyleBaseStyle <> 5 Then
					Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me.o0_0oO.OooO. })
					Me.o0_0oO.OooO..VisualStyleBaseStyle = 2
				End If
				Me.o0_0oO.OooO..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001454 RID: 5204
		' (get) Token: 0x06005525 RID: 21797 RVA: 0x002209EC File Offset: 0x0021EBEC
		' (set) Token: 0x06005526 RID: 21798 RVA: 0x002209FC File Offset: 0x0021EBFC
		<oO0oooo("3095")>
		Public Property BorderColor As Color
			Get
				Return Me.o0_0oO.OooO..BorderColor
			End Get
			Set(value As Color)
				If Me.o0_0oO.OooO..VisualStyleBaseStyle <> 5 Then
					Main.OO_O.o..o0oO_O.0Oo_00.(New Object() { Me.o0_0oO.OooO. })
					Me.o0_0oO.OooO..VisualStyleBaseStyle = 5
				End If
				Me.o0_0oO.OooO..BorderColor = value
			End Set
		End Property

		' Token: 0x17001455 RID: 5205
		' (get) Token: 0x06005527 RID: 21799 RVA: 0x00220A48 File Offset: 0x0021EC48
		' (set) Token: 0x06005528 RID: 21800 RVA: 0x00220A55 File Offset: 0x0021EC55
		<oO0oooo("1859")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.o0_0oO.OooO..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.o0_0oO.OooO..TextAlign = value
			End Set
		End Property

		' Token: 0x17001456 RID: 5206
		' (get) Token: 0x06005529 RID: 21801 RVA: 0x00220A63 File Offset: 0x0021EC63
		' (set) Token: 0x0600552A RID: 21802 RVA: 0x00220A70 File Offset: 0x0021EC70
		<oO0oooo("3099")>
		Public Property FormatString As String
			Get
				Return Me.o0_0oO.OooO..CustomFormat
			End Get
			Set(value As String)
				Me.o0_0oO.OooO..CustomFormat = value
				If Operators.CompareString(value, "", True) > 0 Then
					Me.o0_0oO.OooO..FormatType = 2
					Return
				End If
				Me.o0_0oO.OooO..FormatType = 0
			End Set
		End Property

		' Token: 0x0600552B RID: 21803 RVA: 0x00220AA6 File Offset: 0x0021ECA6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x04002204 RID: 8708
		Private <<EMPTY_NAME>> As OO_0o_O_O
	End Class
End Namespace
