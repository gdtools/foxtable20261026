Imports System
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004FD RID: 1277
	<oO0oooo("2268")>
	<ComVisible(True)>
	Public Class TrackBar
		Inherits Control
		Implements OoO_

		' Token: 0x06005236 RID: 21046 RVA: 0x0021BAE1 File Offset: 0x00219CE1
		Public Sub New(A_0 As TrackBar)
			MyBase.New(A_0, ControlTypeEnum.TrackBar)
			Me.oO_0o_.0__O. = A_0
		End Sub

		' Token: 0x170012F9 RID: 4857
		' (get) Token: 0x06005237 RID: 21047 RVA: 0x0021BAF3 File Offset: 0x00219CF3
		' (set) Token: 0x06005238 RID: 21048 RVA: 0x0021BAFC File Offset: 0x00219CFC
		<oO0oooo("1860")>
		Public Overridable Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.oO_0o_.0__O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.TrackBar, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.oO_0o_.0__O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.oO_0o_.0__O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170012FA RID: 4858
		' (get) Token: 0x06005239 RID: 21049 RVA: 0x0021BBD2 File Offset: 0x00219DD2
		' (set) Token: 0x0600523A RID: 21050 RVA: 0x0021BBDF File Offset: 0x00219DDF
		Public Property Maximum As Integer
			Get
				Return Me.oO_0o_.0__O..Maximum
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..Maximum = value
			End Set
		End Property

		' Token: 0x170012FB RID: 4859
		' (get) Token: 0x0600523B RID: 21051 RVA: 0x0021BBED File Offset: 0x00219DED
		' (set) Token: 0x0600523C RID: 21052 RVA: 0x0021BBFA File Offset: 0x00219DFA
		Public Property Minimum As Integer
			Get
				Return Me.oO_0o_.0__O..Minimum
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..Minimum = value
			End Set
		End Property

		' Token: 0x170012FC RID: 4860
		' (get) Token: 0x0600523D RID: 21053 RVA: 0x0021BC08 File Offset: 0x00219E08
		' (set) Token: 0x0600523E RID: 21054 RVA: 0x0021BC15 File Offset: 0x00219E15
		Public Property Value As Integer
			Get
				Return Me.oO_0o_.0__O..Value
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..Value = value
			End Set
		End Property

		' Token: 0x170012FD RID: 4861
		' (get) Token: 0x0600523F RID: 21055 RVA: 0x0021BC23 File Offset: 0x00219E23
		' (set) Token: 0x06005240 RID: 21056 RVA: 0x0021BC30 File Offset: 0x00219E30
		Public Property LargeChange As Integer
			Get
				Return Me.oO_0o_.0__O..LargeChange
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..LargeChange = value
			End Set
		End Property

		' Token: 0x170012FE RID: 4862
		' (get) Token: 0x06005241 RID: 21057 RVA: 0x0021BC3E File Offset: 0x00219E3E
		' (set) Token: 0x06005242 RID: 21058 RVA: 0x0021BC4B File Offset: 0x00219E4B
		Public Property SmallChange As Integer
			Get
				Return Me.oO_0o_.0__O..SmallChange
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..SmallChange = value
			End Set
		End Property

		' Token: 0x170012FF RID: 4863
		' (get) Token: 0x06005243 RID: 21059 RVA: 0x0021BC59 File Offset: 0x00219E59
		' (set) Token: 0x06005244 RID: 21060 RVA: 0x0021BC66 File Offset: 0x00219E66
		Public Property TickFrequency As Integer
			Get
				Return Me.oO_0o_.0__O..TickFrequency
			End Get
			Set(value As Integer)
				Me.oO_0o_.0__O..TickFrequency = value
			End Set
		End Property

		' Token: 0x17001300 RID: 4864
		' (get) Token: 0x06005245 RID: 21061 RVA: 0x0021BC74 File Offset: 0x00219E74
		' (set) Token: 0x06005246 RID: 21062 RVA: 0x0021BC81 File Offset: 0x00219E81
		Public Property TickStyle As TickStyle
			Get
				Return Me.oO_0o_.0__O..TickStyle
			End Get
			Set(value As TickStyle)
				Me.oO_0o_.0__O..TickStyle = value
			End Set
		End Property

		' Token: 0x17001301 RID: 4865
		' (get) Token: 0x06005247 RID: 21063 RVA: 0x0021BC8F File Offset: 0x00219E8F
		' (set) Token: 0x06005248 RID: 21064 RVA: 0x0021BC9C File Offset: 0x00219E9C
		Public Property Orientation As Orientation
			Get
				Return Me.oO_0o_.0__O..Orientation
			End Get
			Set(value As Orientation)
				Me.oO_0o_.0__O..Orientation = value
			End Set
		End Property

		' Token: 0x06005249 RID: 21065 RVA: 0x0021BCAA File Offset: 0x00219EAA
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021BC RID: 8636
		Private <<EMPTY_NAME>> As TrackBar
	End Class
End Namespace
