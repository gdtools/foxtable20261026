Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200051F RID: 1311
	<ComVisible(True)>
	Public Class RadioButton
		Inherits Control
		Implements OoO_

		' Token: 0x06005614 RID: 22036 RVA: 0x00222256 File Offset: 0x00220456
		Friend Sub New(A_0 As oO00O0oO0o000)
			MyBase.New(A_0, ControlTypeEnum.RadioButton)
			Me.Oooo.Oo_0O. = A_0
		End Sub

		' Token: 0x170014C7 RID: 5319
		' (get) Token: 0x06005615 RID: 22037 RVA: 0x00222267 File Offset: 0x00220467
		' (set) Token: 0x06005616 RID: 22038 RVA: 0x00222270 File Offset: 0x00220470
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.RadioButton, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.Oooo.Oo_0O..DataBindings.Add("Checked", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Checked", value)
							If binding IsNot Nothing Then
								Me.Oooo.Oo_0O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170014C8 RID: 5320
		' (get) Token: 0x06005617 RID: 22039 RVA: 0x00222345 File Offset: 0x00220545
		' (set) Token: 0x06005618 RID: 22040 RVA: 0x00222352 File Offset: 0x00220552
		Public Property Text As String
			Get
				Return Me.Oooo.Oo_0O..Text
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..Text = value
			End Set
		End Property

		' Token: 0x170014C9 RID: 5321
		' (get) Token: 0x06005619 RID: 22041 RVA: 0x00222360 File Offset: 0x00220560
		' (set) Token: 0x0600561A RID: 22042 RVA: 0x0022236D File Offset: 0x0022056D
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.Oooo.Oo_0O..O00_o0_.O__oo.()
			End Get
			Set(value As BooleanEnum)
				Me.Oooo.Oo_0O..O00_o0_.O__oo.(value)
			End Set
		End Property

		' Token: 0x170014CA RID: 5322
		' (get) Token: 0x0600561B RID: 22043 RVA: 0x0022237B File Offset: 0x0022057B
		' (set) Token: 0x0600561C RID: 22044 RVA: 0x00222388 File Offset: 0x00220588
		<oO0oooo("1883")>
		Public Property Appearance As Appearance
			Get
				Return Me.Oooo.Oo_0O..Appearance
			End Get
			Set(value As Appearance)
				Me.Oooo.Oo_0O..Appearance = value
			End Set
		End Property

		' Token: 0x170014CB RID: 5323
		' (get) Token: 0x0600561D RID: 22045 RVA: 0x00222396 File Offset: 0x00220596
		' (set) Token: 0x0600561E RID: 22046 RVA: 0x002223A8 File Offset: 0x002205A8
		Public Property Checked As Boolean
			Get
				Return Conversions.ToBoolean(Me.Oooo.Oo_0O..Checked)
			End Get
			Set(value As Boolean)
				Me.Oooo.Oo_0O..Checked = value
			End Set
		End Property

		' Token: 0x170014CC RID: 5324
		' (get) Token: 0x0600561F RID: 22047 RVA: 0x002223BB File Offset: 0x002205BB
		' (set) Token: 0x06005620 RID: 22048 RVA: 0x002223C8 File Offset: 0x002205C8
		<oO0oooo("1884")>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.Oooo.Oo_0O..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.Oooo.Oo_0O..TextAlign = value
			End Set
		End Property

		' Token: 0x170014CD RID: 5325
		' (get) Token: 0x06005621 RID: 22049 RVA: 0x002223D6 File Offset: 0x002205D6
		' (set) Token: 0x06005622 RID: 22050 RVA: 0x002223E3 File Offset: 0x002205E3
		<oO0oooo("1885")>
		Public Property CheckAlign As ContentAlignment
			Get
				Return Me.Oooo.Oo_0O..CheckAlign
			End Get
			Set(value As ContentAlignment)
				Me.Oooo.Oo_0O..CheckAlign = value
			End Set
		End Property

		' Token: 0x170014CE RID: 5326
		' (get) Token: 0x06005623 RID: 22051 RVA: 0x002223F1 File Offset: 0x002205F1
		' (set) Token: 0x06005624 RID: 22052 RVA: 0x002223F4 File Offset: 0x002205F4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ImageFile As String
			Get
				Return Nothing
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..Image = OO_00oOO.GetImage(value)
			End Set
		End Property

		' Token: 0x170014CF RID: 5327
		' (get) Token: 0x06005625 RID: 22053 RVA: 0x00222407 File Offset: 0x00220607
		' (set) Token: 0x06005626 RID: 22054 RVA: 0x00222414 File Offset: 0x00220614
		<oO0oooo("1886")>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me.Oooo.Oo_0O..ImageAlign
			End Get
			Set(value As ContentAlignment)
				Me.Oooo.Oo_0O..ImageAlign = value
			End Set
		End Property

		' Token: 0x170014D0 RID: 5328
		' (get) Token: 0x06005627 RID: 22055 RVA: 0x00222422 File Offset: 0x00220622
		' (set) Token: 0x06005628 RID: 22056 RVA: 0x0022242F File Offset: 0x0022062F
		<oO0oooo("1887")>
		Public Property TextImageRelation As TextImageRelation
			Get
				Return Me.Oooo.Oo_0O..TextImageRelation
			End Get
			Set(value As TextImageRelation)
				Me.Oooo.Oo_0O..TextImageRelation = value
			End Set
		End Property

		' Token: 0x170014D1 RID: 5329
		' (get) Token: 0x06005629 RID: 22057 RVA: 0x0022243D File Offset: 0x0022063D
		' (set) Token: 0x0600562A RID: 22058 RVA: 0x0022244A File Offset: 0x0022064A
		<oO0oooo("0786")>
		Public Property Image As Image
			Get
				Return Me.Oooo.Oo_0O..Image
			End Get
			Set(value As Image)
				Me.Oooo.Oo_0O..Image = value
			End Set
		End Property

		' Token: 0x0600562B RID: 22059 RVA: 0x00222458 File Offset: 0x00220658
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x04002224 RID: 8740
		Private <<EMPTY_NAME>> As oO00O0oO0o000
	End Class
End Namespace
