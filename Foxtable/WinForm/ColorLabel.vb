Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x02000507 RID: 1287
	<ComVisible(True)>
	Public Class ColorLabel
		Inherits Control
		Implements OoO_

		' Token: 0x0600543E RID: 21566 RVA: 0x0021EADD File Offset: 0x0021CCDD
		Friend Sub New(A_0 As CustomColorLabel)
			MyBase.New(A_0, ControlTypeEnum.ColorLabel)
			Me.O00O.0OOO00. = A_0
		End Sub

		' Token: 0x170013F1 RID: 5105
		' (get) Token: 0x0600543F RID: 21567 RVA: 0x0021EAEF File Offset: 0x0021CCEF
		' (set) Token: 0x06005440 RID: 21568 RVA: 0x0021EAF8 File Offset: 0x0021CCF8
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.O00O.0OOO00..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.ColorLabel, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.O00O.0OOO00..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.O00O.0OOO00..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170013F2 RID: 5106
		' (get) Token: 0x06005441 RID: 21569 RVA: 0x0021EBCE File Offset: 0x0021CDCE
		' (set) Token: 0x06005442 RID: 21570 RVA: 0x0021EBDB File Offset: 0x0021CDDB
		<oO0oooo("0789")>
		Public Property Value As Object
			Get
				Return Me.O00O.0OOO00..Value
			End Get
			Set(value As Object)
				Me.O00O.0OOO00..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170013F3 RID: 5107
		' (get) Token: 0x06005443 RID: 21571 RVA: 0x0021EBEE File Offset: 0x0021CDEE
		' (set) Token: 0x06005444 RID: 21572 RVA: 0x0021EBFB File Offset: 0x0021CDFB
		<oO0oooo("0790")>
		Public Property Color As Color
			Get
				Return Me.O00O.0OOO00..BackColor
			End Get
			Set(value As Color)
				Me.O00O.0OOO00..BackColor = value
			End Set
		End Property

		' Token: 0x170013F4 RID: 5108
		' (get) Token: 0x06005445 RID: 21573 RVA: 0x0021EC09 File Offset: 0x0021CE09
		' (set) Token: 0x06005446 RID: 21574 RVA: 0x0021EC16 File Offset: 0x0021CE16
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O00O.0OOO00..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O00O.0OOO00..BorderStyle = value
			End Set
		End Property

		' Token: 0x170013F5 RID: 5109
		' (get) Token: 0x06005447 RID: 21575 RVA: 0x0021EC24 File Offset: 0x0021CE24
		' (set) Token: 0x06005448 RID: 21576 RVA: 0x0021EC31 File Offset: 0x0021CE31
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property TextAlign As ContentAlignment
			Get
				Return Me.O00O.0OOO00..TextAlign
			End Get
			Set(value As ContentAlignment)
				Me.O00O.0OOO00..TextAlign = value
			End Set
		End Property

		' Token: 0x170013F6 RID: 5110
		' (get) Token: 0x06005449 RID: 21577 RVA: 0x0021EC3F File Offset: 0x0021CE3F
		' (set) Token: 0x0600544A RID: 21578 RVA: 0x0021EC4C File Offset: 0x0021CE4C
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O00O.0OOO00..[ReadOnly]
			End Get
			Set(value As BooleanEnum)
				Me.O00O.0OOO00..[ReadOnly] = value
			End Set
		End Property

		' Token: 0x0600544B RID: 21579 RVA: 0x0021EC5A File Offset: 0x0021CE5A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021CD RID: 8653
		Private <<EMPTY_NAME>> As CustomColorLabel
	End Class
End Namespace
