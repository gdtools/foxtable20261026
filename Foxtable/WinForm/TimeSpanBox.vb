Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x020004FC RID: 1276
	<ComVisible(True)>
	Public Class TimeSpanBox
		Inherits Control
		Implements OoO_

		' Token: 0x0600520F RID: 21007 RVA: 0x0021B753 File Offset: 0x00219953
		Friend Sub New(A_0 As o__0OoO_)
			MyBase.New(A_0, ControlTypeEnum.TimeSpanBox)
			Me.o.OOoo. = A_0
		End Sub

		' Token: 0x170012E9 RID: 4841
		' (get) Token: 0x06005210 RID: 21008 RVA: 0x0021B765 File Offset: 0x00219965
		' (set) Token: 0x06005211 RID: 21009 RVA: 0x0021B772 File Offset: 0x00219972
		<oO0oooo("0750")>
		Public Property Text As String
			Get
				Return Me.o.OOoo..Text
			End Get
			Set(value As String)
				Me.o.OOoo..Value = value
			End Set
		End Property

		' Token: 0x170012EA RID: 4842
		' (get) Token: 0x06005212 RID: 21010 RVA: 0x0021B780 File Offset: 0x00219980
		' (set) Token: 0x06005213 RID: 21011 RVA: 0x0021B7BB File Offset: 0x002199BB
		Public Property Value As Object
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o.OOoo..Value)
				Dim result As Object
				If objectValue IsNot Nothing AndAlso Operators.CompareString(objectValue.ToString(), "", True) = 0 Then
					result = Nothing
				Else
					result = objectValue
				End If
				Return result
			End Get
			Set(value As Object)
				Me.o.OOoo..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170012EB RID: 4843
		' (get) Token: 0x06005214 RID: 21012 RVA: 0x0021B7CE File Offset: 0x002199CE
		' (set) Token: 0x06005215 RID: 21013 RVA: 0x0021B7DB File Offset: 0x002199DB
		<oO0oooo("0749")>
		Public Overrides Property [ReadOnly] As BooleanEnum
			Get
				Return Me.o.OOoo..O_o.0.()
			End Get
			Set(value As BooleanEnum)
				Me.o.OOoo..O_o.0.(value)
			End Set
		End Property

		' Token: 0x170012EC RID: 4844
		' (get) Token: 0x06005216 RID: 21014 RVA: 0x0021B7E9 File Offset: 0x002199E9
		' (set) Token: 0x06005217 RID: 21015 RVA: 0x0021B7F4 File Offset: 0x002199F4
		<oO0oooo("1860")>
		Public Overrides Property BindingField As String
			Get
				Return MyBase.BindingField
			End Get
			Set(value As String)
				Me.o.OOoo..DataBindings.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If ooO_0O.o_O0.O_.(ControlTypeEnum.TimeSpanBox, value, Nothing) Then
						If value.StartsWith("全局变量.") Then
							Dim text As String = value.Substring(value.IndexOf("."c) + 1)
							If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
								Me.o.OOoo..DataBindings.Add("Value2", OO_00oOO.Vars.VariableTable, text)
								Me.o.OOoo..DataType = OO_00oOO.Vars.VariableTable.Columns(text).DataType
								Return
							End If
						Else
							Dim binding As Binding = Oo00.OO.0O0o.("Value2", value)
							binding.DataSourceUpdateMode = DataSourceUpdateMode.Never
							If binding IsNot Nothing Then
								Me.o.OOoo..DataBindings.Add(binding)
								If Me.o.OOoo..DataBindings.Count > 0 Then
									Dim num As Integer = value.LastIndexOf("."c)
									Dim a_ As String = value.Substring(0, num)
									Dim name As String = value.Substring(num + 1)
									Me.o.OOoo..DataType = OO_00oOO.Tables(a_).DataTable.BaseTable.Columns(name).DataType
								End If
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x170012ED RID: 4845
		' (get) Token: 0x06005218 RID: 21016 RVA: 0x0021B95D File Offset: 0x00219B5D
		' (set) Token: 0x06005219 RID: 21017 RVA: 0x0021B96A File Offset: 0x00219B6A
		<oO0oooo("1861")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me.o.OOoo..TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me.o.OOoo..TextAlign = value
			End Set
		End Property

		' Token: 0x170012EE RID: 4846
		' (get) Token: 0x0600521A RID: 21018 RVA: 0x0021B978 File Offset: 0x00219B78
		' (set) Token: 0x0600521B RID: 21019 RVA: 0x0021B985 File Offset: 0x00219B85
		Public Property BorderStyle As BorderStyle
			Get
				Return Me.o.OOoo..BorderStyle
			End Get
			Set(value As BorderStyle)
				Me.o.OOoo..BorderStyle = value
			End Set
		End Property

		' Token: 0x170012EF RID: 4847
		' (get) Token: 0x0600521C RID: 21020 RVA: 0x0021B993 File Offset: 0x00219B93
		' (set) Token: 0x0600521D RID: 21021 RVA: 0x0021B9A0 File Offset: 0x00219BA0
		Public Property BorderColor As Color
			Get
				Return Me.o.OOoo..BorderColor
			End Get
			Set(value As Color)
				Me.o.OOoo..BorderColor = value
			End Set
		End Property

		' Token: 0x170012F0 RID: 4848
		' (get) Token: 0x0600521E RID: 21022 RVA: 0x0021B9AE File Offset: 0x00219BAE
		' (set) Token: 0x0600521F RID: 21023 RVA: 0x0021B9BB File Offset: 0x00219BBB
		<oO0oooo("1866")>
		Public Property EditMask As String
			Get
				Return Me.o.OOoo..EditMask
			End Get
			Set(value As String)
				Me.o.OOoo..EditMask = value
			End Set
		End Property

		' Token: 0x170012F1 RID: 4849
		' (get) Token: 0x06005220 RID: 21024 RVA: 0x0021B9C9 File Offset: 0x00219BC9
		' (set) Token: 0x06005221 RID: 21025 RVA: 0x0021B9D6 File Offset: 0x00219BD6
		<oO0oooo("0720")>
		Public Overrides Property BackColor As Color
			Get
				Return Me.o.OOoo..BackColor
			End Get
			Set(value As Color)
				Me.o.OOoo..BackColor = value
			End Set
		End Property

		' Token: 0x170012F2 RID: 4850
		' (get) Token: 0x06005222 RID: 21026 RVA: 0x0021B9E4 File Offset: 0x00219BE4
		' (set) Token: 0x06005223 RID: 21027 RVA: 0x0021B9F1 File Offset: 0x00219BF1
		<oO0oooo("0721")>
		Public Overrides Property ForeColor As Color
			Get
				Return Me.o.OOoo..ForeColor
			End Get
			Set(value As Color)
				Me.o.OOoo..ForeColor = value
			End Set
		End Property

		' Token: 0x170012F3 RID: 4851
		' (get) Token: 0x06005224 RID: 21028 RVA: 0x0021B9FF File Offset: 0x00219BFF
		' (set) Token: 0x06005225 RID: 21029 RVA: 0x0021BA0C File Offset: 0x00219C0C
		Public Property InitialSelection As InitialSelectionEnum
			Get
				Return Me.o.OOoo..InitialSelection
			End Get
			Set(value As InitialSelectionEnum)
				Me.o.OOoo..InitialSelection = value
			End Set
		End Property

		' Token: 0x170012F4 RID: 4852
		' (get) Token: 0x06005226 RID: 21030 RVA: 0x0021BA1C File Offset: 0x00219C1C
		' (set) Token: 0x06005227 RID: 21031 RVA: 0x0021BA2A File Offset: 0x00219C2A
		Public Property VisualStyle As VisualStyle
			Get
				Dim result As VisualStyle
				Return result
			End Get
			Set(value As VisualStyle)
			End Set
		End Property

		' Token: 0x170012F5 RID: 4853
		' (get) Token: 0x06005228 RID: 21032 RVA: 0x0021BA2C File Offset: 0x00219C2C
		' (set) Token: 0x06005229 RID: 21033 RVA: 0x0021BA39 File Offset: 0x00219C39
		<oO0oooo("0740")>
		Public Property SelectedText As String
			Get
				Return Me.o.OOoo..SelectedText
			End Get
			Set(value As String)
				Me.o.OOoo..SelectedText = value
			End Set
		End Property

		' Token: 0x170012F6 RID: 4854
		' (get) Token: 0x0600522A RID: 21034 RVA: 0x0021BA47 File Offset: 0x00219C47
		' (set) Token: 0x0600522B RID: 21035 RVA: 0x0021BA54 File Offset: 0x00219C54
		Public Property SelectionStart As Integer
			Get
				Return Me.o.OOoo..SelectionStart
			End Get
			Set(value As Integer)
				Me.o.OOoo..SelectionStart = value
			End Set
		End Property

		' Token: 0x170012F7 RID: 4855
		' (get) Token: 0x0600522C RID: 21036 RVA: 0x0021BA62 File Offset: 0x00219C62
		' (set) Token: 0x0600522D RID: 21037 RVA: 0x0021BA6F File Offset: 0x00219C6F
		Public Property SelectionLength As Integer
			Get
				Return Me.o.OOoo..SelectionLength
			End Get
			Set(value As Integer)
				Me.o.OOoo..SelectionLength = value
			End Set
		End Property

		' Token: 0x170012F8 RID: 4856
		' (get) Token: 0x0600522E RID: 21038 RVA: 0x0021BA7D File Offset: 0x00219C7D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property Lines As String()
			Get
				Return Me.o.OOoo..Lines
			End Get
		End Property

		' Token: 0x0600522F RID: 21039 RVA: 0x0021BA8A File Offset: 0x00219C8A
		Public Sub SelectAll()
			Me.o.OOoo..SelectAll()
		End Sub

		' Token: 0x06005230 RID: 21040 RVA: 0x0021BA97 File Offset: 0x00219C97
		Public Sub Copy()
			Me.o.OOoo..Copy()
		End Sub

		' Token: 0x06005231 RID: 21041 RVA: 0x0021BAA4 File Offset: 0x00219CA4
		Public Sub Cut()
			Me.o.OOoo..Cut()
		End Sub

		' Token: 0x06005232 RID: 21042 RVA: 0x0021BAB1 File Offset: 0x00219CB1
		Public Sub Paste()
			Me.o.OOoo..Paste()
		End Sub

		' Token: 0x06005233 RID: 21043 RVA: 0x0021BABE File Offset: 0x00219CBE
		Public Sub Undo()
			Me.o.OOoo..Undo()
		End Sub

		' Token: 0x06005234 RID: 21044 RVA: 0x0021BACB File Offset: 0x00219CCB
		Public Sub ResetText()
			Me.o.OOoo..ResetText()
		End Sub

		' Token: 0x06005235 RID: 21045 RVA: 0x0021BAD8 File Offset: 0x00219CD8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021BA RID: 8634
		Private <<EMPTY_NAME>> As o__0OoO_

		' Token: 0x040021BB RID: 8635
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
