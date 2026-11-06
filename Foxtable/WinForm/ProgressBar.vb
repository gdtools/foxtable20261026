Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200051E RID: 1310
	<ComVisible(True)>
	<oO0oooo("0793")>
	Public Class ProgressBar
		Inherits Control
		Implements OoO_

		' Token: 0x06005608 RID: 22024 RVA: 0x002220F4 File Offset: 0x002202F4
		Friend Sub New(A_0 As o_O_O0O__)
			MyBase.New(A_0, ControlTypeEnum.ProgressBar)
			Me.Oooo.Oo_0O. = A_0
		End Sub

		' Token: 0x170014C2 RID: 5314
		' (get) Token: 0x06005609 RID: 22025 RVA: 0x00222106 File Offset: 0x00220306
		' (set) Token: 0x0600560A RID: 22026 RVA: 0x00222110 File Offset: 0x00220310
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.Oooo.Oo_0O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.BaseControl.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.ProgressBar, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.Oooo.Oo_0O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
								Me.Oooo.Oo_0O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170014C3 RID: 5315
		' (get) Token: 0x0600560B RID: 22027 RVA: 0x002221E8 File Offset: 0x002203E8
		' (set) Token: 0x0600560C RID: 22028 RVA: 0x002221F5 File Offset: 0x002203F5
		Public Property Value As Object
			Get
				Return Me.Oooo.Oo_0O..Value
			End Get
			Set(value As Object)
				Me.Oooo.Oo_0O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170014C4 RID: 5316
		' (get) Token: 0x0600560D RID: 22029 RVA: 0x00222208 File Offset: 0x00220408
		' (set) Token: 0x0600560E RID: 22030 RVA: 0x00222215 File Offset: 0x00220415
		Public Property Maximum As Integer
			Get
				Return Me.Oooo.Oo_0O..Maximum
			End Get
			Set(value As Integer)
				Me.Oooo.Oo_0O..Maximum = value
			End Set
		End Property

		' Token: 0x170014C5 RID: 5317
		' (get) Token: 0x0600560F RID: 22031 RVA: 0x00222223 File Offset: 0x00220423
		' (set) Token: 0x06005610 RID: 22032 RVA: 0x00222230 File Offset: 0x00220430
		Public Property Minimum As Integer
			Get
				Return Me.Oooo.Oo_0O..Minimum
			End Get
			Set(value As Integer)
			End Set
		End Property

		' Token: 0x170014C6 RID: 5318
		' (get) Token: 0x06005611 RID: 22033 RVA: 0x00222232 File Offset: 0x00220432
		' (set) Token: 0x06005612 RID: 22034 RVA: 0x0022223F File Offset: 0x0022043F
		Public Property Style As ProgressBarStyle
			Get
				Return Me.Oooo.Oo_0O..Style
			End Get
			Set(value As ProgressBarStyle)
				Me.Oooo.Oo_0O..Style = value
			End Set
		End Property

		' Token: 0x06005613 RID: 22035 RVA: 0x0022224D File Offset: 0x0022044D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x04002223 RID: 8739
		Private <<EMPTY_NAME>> As o_O_O0O__
	End Class
End Namespace
