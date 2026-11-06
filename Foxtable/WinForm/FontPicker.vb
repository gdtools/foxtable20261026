Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004F2 RID: 1266
	<oO0oooo("3104")>
	<ComVisible(True)>
	Public Class FontPicker
		Inherits Control
		Implements OoO_

		' Token: 0x06005101 RID: 20737 RVA: 0x002196EA File Offset: 0x002178EA
		Public Sub New(A_0 As O00o)
			MyBase.New(A_0, ControlTypeEnum.FontPicker)
			Me.O.00oo_OO0O. = A_0
		End Sub

		' Token: 0x17001266 RID: 4710
		' (get) Token: 0x06005102 RID: 20738 RVA: 0x002196FC File Offset: 0x002178FC
		Public ReadOnly Property Text As String
			Get
				Return Me.O.00oo_OO0O..Text
			End Get
		End Property

		' Token: 0x17001267 RID: 4711
		' (get) Token: 0x06005103 RID: 20739 RVA: 0x00219709 File Offset: 0x00217909
		' (set) Token: 0x06005104 RID: 20740 RVA: 0x00219716 File Offset: 0x00217916
		Public Property Value As Object
			Get
				Return Me.O.00oo_OO0O..Value
			End Get
			Set(value As Object)
				Me.O.00oo_OO0O..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17001268 RID: 4712
		' (get) Token: 0x06005105 RID: 20741 RVA: 0x00219729 File Offset: 0x00217929
		' (set) Token: 0x06005106 RID: 20742 RVA: 0x00219736 File Offset: 0x00217936
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.O.00oo_OO0O..OoO0O0.0O_oo.()
			End Get
			Set(value As BooleanEnum)
				Me.O.00oo_OO0O..OoO0O0.0O_oo.(value)
			End Set
		End Property

		' Token: 0x17001269 RID: 4713
		' (get) Token: 0x06005107 RID: 20743 RVA: 0x00219744 File Offset: 0x00217944
		' (set) Token: 0x06005108 RID: 20744 RVA: 0x0021974C File Offset: 0x0021794C
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.O.00oo_OO0O..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.FontPicker, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.O.00oo_OO0O..DataBindings.Add("Value", OO_00oOO.Vars.VariableTable, text)
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value", value)
							If binding IsNot Nothing Then
								Me.O.00oo_OO0O..DataBindings.Add(binding)
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700126A RID: 4714
		' (get) Token: 0x06005109 RID: 20745 RVA: 0x00219824 File Offset: 0x00217A24
		' (set) Token: 0x0600510A RID: 20746 RVA: 0x00219832 File Offset: 0x00217A32
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x1700126B RID: 4715
		' (get) Token: 0x0600510B RID: 20747 RVA: 0x00219834 File Offset: 0x00217A34
		' (set) Token: 0x0600510C RID: 20748 RVA: 0x00219841 File Offset: 0x00217A41
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.O.00oo_OO0O..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.O.00oo_OO0O..BorderStyle = value
			End Set
		End Property

		' Token: 0x1700126C RID: 4716
		' (get) Token: 0x0600510D RID: 20749 RVA: 0x0021984F File Offset: 0x00217A4F
		' (set) Token: 0x0600510E RID: 20750 RVA: 0x0021985C File Offset: 0x00217A5C
		Public Property BorderColor As Color
			Get
				Return Me.O.00oo_OO0O..BorderColor
			End Get
			Set(value As Color)
				Me.O.00oo_OO0O..BorderColor = value
			End Set
		End Property

		' Token: 0x1700126D RID: 4717
		' (get) Token: 0x0600510F RID: 20751 RVA: 0x0021986A File Offset: 0x00217A6A
		' (set) Token: 0x06005110 RID: 20752 RVA: 0x00219877 File Offset: 0x00217A77
		Public Overrides Property BackColor As Color
			Get
				Return Me.O.00oo_OO0O..BackColor
			End Get
			Set(value As Color)
				Me.O.00oo_OO0O..BackColor = value
			End Set
		End Property

		' Token: 0x1700126E RID: 4718
		' (get) Token: 0x06005111 RID: 20753 RVA: 0x00219885 File Offset: 0x00217A85
		' (set) Token: 0x06005112 RID: 20754 RVA: 0x00219892 File Offset: 0x00217A92
		Public Overrides Property ForeColor As Color
			Get
				Return Me.O.00oo_OO0O..ForeColor
			End Get
			Set(value As Color)
				Me.O.00oo_OO0O..ForeColor = value
			End Set
		End Property

		' Token: 0x06005113 RID: 20755 RVA: 0x002198A0 File Offset: 0x00217AA0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021AF RID: 8623
		Private <<EMPTY_NAME>> As O00o
	End Class
End Namespace
