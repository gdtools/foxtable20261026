Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004ED RID: 1261
	<oO0oooo("3105")>
	<ComVisible(True)>
	Public Class ColorPicker
		Inherits Control
		Implements OoO_

		' Token: 0x060050E0 RID: 20704 RVA: 0x00219117 File Offset: 0x00217317
		Public Sub New(A_0 As oOO)
			MyBase.New(A_0, ControlTypeEnum.ColorPicker)
			Me.o_Oo._O_00000_. = A_0
		End Sub

		' Token: 0x1700125C RID: 4700
		' (get) Token: 0x060050E1 RID: 20705 RVA: 0x00219129 File Offset: 0x00217329
		' (set) Token: 0x060050E2 RID: 20706 RVA: 0x00219136 File Offset: 0x00217336
		Public Property Color As Color
			Get
				Return Me.o_Oo._O_00000_..Color
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..Color = value
			End Set
		End Property

		' Token: 0x1700125D RID: 4701
		' (get) Token: 0x060050E3 RID: 20707 RVA: 0x00219144 File Offset: 0x00217344
		Public ReadOnly Property Text As String
			Get
				Return Me.o_Oo._O_00000_..Text
			End Get
		End Property

		' Token: 0x1700125E RID: 4702
		' (get) Token: 0x060050E4 RID: 20708 RVA: 0x00219151 File Offset: 0x00217351
		' (set) Token: 0x060050E5 RID: 20709 RVA: 0x0021915E File Offset: 0x0021735E
		Public Property Value As Color
			Get
				Return Me.o_Oo._O_00000_..Color
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..Color = value
			End Set
		End Property

		' Token: 0x1700125F RID: 4703
		' (get) Token: 0x060050E6 RID: 20710 RVA: 0x0021916C File Offset: 0x0021736C
		' (set) Token: 0x060050E7 RID: 20711 RVA: 0x00219179 File Offset: 0x00217379
		Public Overridable Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o_Oo._O_00000_..o.Oo.()
			End Get
			Set(value As BooleanEnum)
				Me.o_Oo._O_00000_..o.Oo.(value)
			End Set
		End Property

		' Token: 0x17001260 RID: 4704
		' (get) Token: 0x060050E8 RID: 20712 RVA: 0x00219187 File Offset: 0x00217387
		' (set) Token: 0x060050E9 RID: 20713 RVA: 0x00219190 File Offset: 0x00217390
		<oO0oooo("1860")>
		Public Overridable Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o_Oo._O_00000_..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.ColorPicker, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o_Oo._O_00000_..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							If binding IsNot Nothing Then
								Me.o_Oo._O_00000_..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001261 RID: 4705
		' (get) Token: 0x060050EA RID: 20714 RVA: 0x00219268 File Offset: 0x00217468
		' (set) Token: 0x060050EB RID: 20715 RVA: 0x00219276 File Offset: 0x00217476
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x17001262 RID: 4706
		' (get) Token: 0x060050EC RID: 20716 RVA: 0x00219278 File Offset: 0x00217478
		' (set) Token: 0x060050ED RID: 20717 RVA: 0x00219285 File Offset: 0x00217485
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o_Oo._O_00000_..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o_Oo._O_00000_..BorderStyle = value
			End Set
		End Property

		' Token: 0x17001263 RID: 4707
		' (get) Token: 0x060050EE RID: 20718 RVA: 0x00219293 File Offset: 0x00217493
		' (set) Token: 0x060050EF RID: 20719 RVA: 0x002192A0 File Offset: 0x002174A0
		Public Property BorderColor As Color
			Get
				Return Me.o_Oo._O_00000_..BorderColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..BorderColor = value
			End Set
		End Property

		' Token: 0x17001264 RID: 4708
		' (get) Token: 0x060050F0 RID: 20720 RVA: 0x002192AE File Offset: 0x002174AE
		' (set) Token: 0x060050F1 RID: 20721 RVA: 0x002192BB File Offset: 0x002174BB
		Public Overridable Property BackColor As Color
			Get
				Return Me.o_Oo._O_00000_..BackColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..BackColor = value
			End Set
		End Property

		' Token: 0x17001265 RID: 4709
		' (get) Token: 0x060050F2 RID: 20722 RVA: 0x002192C9 File Offset: 0x002174C9
		' (set) Token: 0x060050F3 RID: 20723 RVA: 0x002192D6 File Offset: 0x002174D6
		Public Overridable Property ForeColor As Color
			Get
				Return Me.o_Oo._O_00000_..ForeColor
			End Get
			Set(value As Color)
				Me.o_Oo._O_00000_..ForeColor = value
			End Set
		End Property

		' Token: 0x060050F4 RID: 20724 RVA: 0x002192E4 File Offset: 0x002174E4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021AA RID: 8618
		Private <<EMPTY_NAME>> As oOO
	End Class
End Namespace
