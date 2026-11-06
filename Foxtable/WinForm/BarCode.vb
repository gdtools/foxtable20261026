Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable.WinForm
	' Token: 0x020004FE RID: 1278
	<ComVisible(True)>
	Public Class BarCode
		Inherits Control
		Implements OoO_

		' Token: 0x0600524A RID: 21066 RVA: 0x0021BCB3 File Offset: 0x00219EB3
		Friend Sub New(A_0 As OOo00o_0o0_)
			MyBase.New(A_0, ControlTypeEnum.BarCode)
			Me.oo._00. = A_0
		End Sub

		' Token: 0x17001302 RID: 4866
		' (get) Token: 0x0600524B RID: 21067 RVA: 0x0021BCC5 File Offset: 0x00219EC5
		Public ReadOnly Property Image As Image
			Get
				Return Image.FromStream(New MemoryStream(Me.oo._00..GetBarcodeImage(ImageFormat.Emf)))
			End Get
		End Property

		' Token: 0x17001303 RID: 4867
		' (get) Token: 0x0600524C RID: 21068 RVA: 0x0021BCE1 File Offset: 0x00219EE1
		' (set) Token: 0x0600524D RID: 21069 RVA: 0x0021BCEE File Offset: 0x00219EEE
		Public Property QuietZoneWidth As Double
			Get
				Return Me.oo._00..QuietZoneWidth
			End Get
			Set(value As Double)
				Me.oo._00..QuietZoneWidth = value
			End Set
		End Property

		' Token: 0x17001304 RID: 4868
		' (get) Token: 0x0600524E RID: 21070 RVA: 0x0021BCFC File Offset: 0x00219EFC
		' (set) Token: 0x0600524F RID: 21071 RVA: 0x0021BDF0 File Offset: 0x00219FF0
		Public Overrides Property BindingField As String
			Get
				If Me.oo._00..DataBindings.Count > 0 Then
					Try
						For Each obj As Object In Me.oo._00..DataBindings
							Dim binding As Binding = CType(obj, Binding)
							If Operators.CompareString(binding.PropertyName, "Code", True) = 0 Then
								If TypeOf binding.DataSource Is O_0 Then
									Return CType(binding.DataSource, O_0).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField
								End If
								If binding.DataSource Is OO_00oOO.Vars.VariableTable Then
									Return "全局变量." + binding.BindingMemberInfo.BindingField
								End If
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Return Nothing
			End Get
			Set(value As String)
				Try
					For Each obj As Object In Me.oo._00..DataBindings
						Dim binding As Binding = CType(obj, Binding)
						If Operators.CompareString(binding.PropertyName, "Code", True) = 0 Then
							Me.oo._00..DataBindings.Remove(binding)
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Operators.CompareString(value, "", True) > 0 Then
					If MyBase.Form.Pane.FindForm() Is Nothing Then
						MyBase.Form.o_0.o0..Add(Me, value)
						Return
					End If
					If value.StartsWith("全局变量.") Then
						Dim text As String = value.Substring(value.IndexOf("."c) + 1)
						If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
							Me.oo._00..DataBindings.Add("Code", OO_00oOO.Vars.VariableTable, text).DataSourceUpdateMode = DataSourceUpdateMode.Never
							Return
						End If
					Else
						Dim binding2 As Binding = Oo00.OO.0O0o.("Code", value)
						binding2.DataSourceUpdateMode = DataSourceUpdateMode.Never
						If binding2 IsNot Nothing Then
							Me.oo._00..DataBindings.Add(binding2)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001305 RID: 4869
		' (get) Token: 0x06005250 RID: 21072 RVA: 0x0021BF2C File Offset: 0x0021A12C
		' (set) Token: 0x06005251 RID: 21073 RVA: 0x0021C020 File Offset: 0x0021A220
		Public Property BindingText As String
			Get
				If Me.oo._00..DataBindings.Count > 0 Then
					Try
						For Each obj As Object In Me.oo._00..DataBindings
							Dim binding As Binding = CType(obj, Binding)
							If Operators.CompareString(binding.PropertyName, "Text", True) = 0 Then
								If TypeOf binding.DataSource Is O_0 Then
									Return CType(binding.DataSource, O_0).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField
								End If
								If binding.DataSource Is OO_00oOO.Vars.VariableTable Then
									Return "全局变量." + binding.BindingMemberInfo.BindingField
								End If
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Return Nothing
			End Get
			Set(value As String)
				Try
					For Each obj As Object In Me.oo._00..DataBindings
						Dim binding As Binding = CType(obj, Binding)
						If Operators.CompareString(binding.PropertyName, "Text", True) = 0 Then
							Me.oo._00..DataBindings.Remove(binding)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Operators.CompareString(value, "", True) > 0 Then
					If value.StartsWith("全局变量.") Then
						Dim text As String = value.Substring(value.IndexOf("."c) + 1)
						If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
							Me.oo._00..DataBindings.Add("Text", OO_00oOO.Vars.VariableTable, text)
							Return
						End If
					Else
						Dim binding2 As Binding = Oo00.OO.0O0o.("Text", value)
						If binding2 IsNot Nothing Then
							Me.oo._00..DataBindings.Add(binding2)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001306 RID: 4870
		' (get) Token: 0x06005252 RID: 21074 RVA: 0x0021C124 File Offset: 0x0021A324
		' (set) Token: 0x06005253 RID: 21075 RVA: 0x0021C218 File Offset: 0x0021A418
		Public Property BindingHumanReadableText As String
			Get
				If Me.oo._00..DataBindings.Count > 0 Then
					Try
						For Each obj As Object In Me.oo._00..DataBindings
							Dim binding As Binding = CType(obj, Binding)
							If Operators.CompareString(binding.PropertyName, "HumanReadableText", True) = 0 Then
								If TypeOf binding.DataSource Is O_0 Then
									Return CType(binding.DataSource, O_0).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField
								End If
								If binding.DataSource Is OO_00oOO.Vars.VariableTable Then
									Return "全局变量." + binding.BindingMemberInfo.BindingField
								End If
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Return Nothing
			End Get
			Set(value As String)
				Try
					For Each obj As Object In Me.oo._00..DataBindings
						Dim binding As Binding = CType(obj, Binding)
						If Operators.CompareString(binding.PropertyName, "HumanReadableText", True) = 0 Then
							Me.oo._00..DataBindings.Remove(binding)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Operators.CompareString(value, "", True) > 0 Then
					If value.StartsWith("全局变量.") Then
						Dim text As String = value.Substring(value.IndexOf("."c) + 1)
						If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
							Me.oo._00..DataBindings.Add("HumanReadableText", OO_00oOO.Vars.VariableTable, text)
							Return
						End If
					Else
						Dim binding2 As Binding = Oo00.OO.0O0o.("HumanReadableText", value)
						If binding2 IsNot Nothing Then
							Me.oo._00..DataBindings.Add(binding2)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x17001307 RID: 4871
		' (get) Token: 0x06005254 RID: 21076 RVA: 0x0021C31C File Offset: 0x0021A51C
		' (set) Token: 0x06005255 RID: 21077 RVA: 0x0021C329 File Offset: 0x0021A529
		Public Overridable Property Code As String
			Get
				Return Me.oo._00..Code
			End Get
			Set(value As String)
				Me.oo._00..Code = value
			End Set
		End Property

		' Token: 0x17001308 RID: 4872
		' (get) Token: 0x06005256 RID: 21078 RVA: 0x0021C337 File Offset: 0x0021A537
		' (set) Token: 0x06005257 RID: 21079 RVA: 0x0021C344 File Offset: 0x0021A544
		Public Property Symbology As Symbology
			Get
				Return Me.oo._00..Symbology
			End Get
			Set(value As Symbology)
				Me.oo._00..Symbology = value
			End Set
		End Property

		' Token: 0x17001309 RID: 4873
		' (get) Token: 0x06005258 RID: 21080 RVA: 0x0021C352 File Offset: 0x0021A552
		' (set) Token: 0x06005259 RID: 21081 RVA: 0x0021C35F File Offset: 0x0021A55F
		Public Property BarWidth As Double
			Get
				Return Me.oo._00..BarWidth
			End Get
			Set(value As Double)
				Me.oo._00..BarWidth = value
			End Set
		End Property

		' Token: 0x1700130A RID: 4874
		' (get) Token: 0x0600525A RID: 21082 RVA: 0x0021C36D File Offset: 0x0021A56D
		' (set) Token: 0x0600525B RID: 21083 RVA: 0x0021C37A File Offset: 0x0021A57A
		Public Property BarHeight As Double
			Get
				Return Me.oo._00..BarHeight
			End Get
			Set(value As Double)
				Me.oo._00..BarHeight = value
			End Set
		End Property

		' Token: 0x1700130B RID: 4875
		' (get) Token: 0x0600525C RID: 21084 RVA: 0x0021C388 File Offset: 0x0021A588
		' (set) Token: 0x0600525D RID: 21085 RVA: 0x0021C395 File Offset: 0x0021A595
		Public Property BarRatio As Double
			Get
				Return Me.oo._00..BarRatio
			End Get
			Set(value As Double)
				Me.oo._00..BarRatio = value
			End Set
		End Property

		' Token: 0x1700130C RID: 4876
		' (get) Token: 0x0600525E RID: 21086 RVA: 0x0021C3A3 File Offset: 0x0021A5A3
		' (set) Token: 0x0600525F RID: 21087 RVA: 0x0021C3B0 File Offset: 0x0021A5B0
		Public Property Rotate As Rotate
			Get
				Return Me.oo._00..Rotate
			End Get
			Set(value As Rotate)
				Me.oo._00..Rotate = value
			End Set
		End Property

		' Token: 0x1700130D RID: 4877
		' (get) Token: 0x06005260 RID: 21088 RVA: 0x0021C3BE File Offset: 0x0021A5BE
		' (set) Token: 0x06005261 RID: 21089 RVA: 0x0021C3CB File Offset: 0x0021A5CB
		Public Property AddCheckSum As Boolean
			Get
				Return Me.oo._00..AddChecksum
			End Get
			Set(value As Boolean)
				Me.oo._00..AddChecksum = value
			End Set
		End Property

		' Token: 0x1700130E RID: 4878
		' (get) Token: 0x06005262 RID: 21090 RVA: 0x0021C3D9 File Offset: 0x0021A5D9
		' (set) Token: 0x06005263 RID: 21091 RVA: 0x0021C3E6 File Offset: 0x0021A5E6
		Public Property BearBarStyle As BearerBarStyle
			Get
				Return Me.oo._00..BearerBarStyle
			End Get
			Set(value As BearerBarStyle)
				Me.oo._00..BearerBarStyle = value
			End Set
		End Property

		' Token: 0x1700130F RID: 4879
		' (get) Token: 0x06005264 RID: 21092 RVA: 0x0021C3F4 File Offset: 0x0021A5F4
		' (set) Token: 0x06005265 RID: 21093 RVA: 0x0021C401 File Offset: 0x0021A601
		Public Property BearerBarWidth As Double
			Get
				Return Me.oo._00..BearerBarWidth
			End Get
			Set(value As Double)
				Me.oo._00..BearerBarWidth = value
			End Set
		End Property

		' Token: 0x17001310 RID: 4880
		' (get) Token: 0x06005266 RID: 21094 RVA: 0x0021C40F File Offset: 0x0021A60F
		' (set) Token: 0x06005267 RID: 21095 RVA: 0x0021C41C File Offset: 0x0021A61C
		Public Property DisplayCode As Boolean
			Get
				Return Me.oo._00..DisplayCode
			End Get
			Set(value As Boolean)
				Me.oo._00..DisplayCode = value
			End Set
		End Property

		' Token: 0x17001311 RID: 4881
		' (get) Token: 0x06005268 RID: 21096 RVA: 0x0021C42A File Offset: 0x0021A62A
		' (set) Token: 0x06005269 RID: 21097 RVA: 0x0021C437 File Offset: 0x0021A637
		Public Property DisplayChecksum As Boolean
			Get
				Return Me.oo._00..DisplayChecksum
			End Get
			Set(value As Boolean)
				Me.oo._00..DisplayChecksum = value
			End Set
		End Property

		' Token: 0x17001312 RID: 4882
		' (get) Token: 0x0600526A RID: 21098 RVA: 0x0021C445 File Offset: 0x0021A645
		' (set) Token: 0x0600526B RID: 21099 RVA: 0x0021C452 File Offset: 0x0021A652
		Public Overridable Property HumanReadableText As String
			Get
				Return Me.oo._00..HumanReadableText
			End Get
			Set(value As String)
				Me.oo._00..HumanReadableText = value
			End Set
		End Property

		' Token: 0x17001313 RID: 4883
		' (get) Token: 0x0600526C RID: 21100 RVA: 0x0021C460 File Offset: 0x0021A660
		' (set) Token: 0x0600526D RID: 21101 RVA: 0x0021C46D File Offset: 0x0021A66D
		Public Property DisplayStartStopChar As Boolean
			Get
				Return Me.oo._00..DisplayStartStopChar
			End Get
			Set(value As Boolean)
				Me.oo._00..DisplayStartStopChar = value
			End Set
		End Property

		' Token: 0x17001314 RID: 4884
		' (get) Token: 0x0600526E RID: 21102 RVA: 0x0021C47B File Offset: 0x0021A67B
		' (set) Token: 0x0600526F RID: 21103 RVA: 0x0021C488 File Offset: 0x0021A688
		Public Property CodeAlignment As Alignment
			Get
				Return Me.oo._00..CodeAlignment
			End Get
			Set(value As Alignment)
				Me.oo._00..CodeAlignment = value
			End Set
		End Property

		' Token: 0x17001315 RID: 4885
		' (get) Token: 0x06005270 RID: 21104 RVA: 0x0021C496 File Offset: 0x0021A696
		' (set) Token: 0x06005271 RID: 21105 RVA: 0x0021C4A3 File Offset: 0x0021A6A3
		Public Overridable Property Text As String
			Get
				Return Me.oo._00..Text
			End Get
			Set(value As String)
				Me.oo._00..Text = value
			End Set
		End Property

		' Token: 0x17001316 RID: 4886
		' (get) Token: 0x06005272 RID: 21106 RVA: 0x0021C4B1 File Offset: 0x0021A6B1
		' (set) Token: 0x06005273 RID: 21107 RVA: 0x0021C4BE File Offset: 0x0021A6BE
		Public Property TextAlignment As Alignment
			Get
				Return Me.oo._00..TextAlignment
			End Get
			Set(value As Alignment)
				Me.oo._00..TextAlignment = value
			End Set
		End Property

		' Token: 0x17001317 RID: 4887
		' (get) Token: 0x06005274 RID: 21108 RVA: 0x0021C4CC File Offset: 0x0021A6CC
		' (set) Token: 0x06005275 RID: 21109 RVA: 0x0021C4D9 File Offset: 0x0021A6D9
		Public Property TopMargin As Double
			Get
				Return Me.oo._00..TopMargin
			End Get
			Set(value As Double)
				Me.oo._00..TopMargin = value
			End Set
		End Property

		' Token: 0x17001318 RID: 4888
		' (get) Token: 0x06005276 RID: 21110 RVA: 0x0021C4E7 File Offset: 0x0021A6E7
		' (set) Token: 0x06005277 RID: 21111 RVA: 0x0021C4F4 File Offset: 0x0021A6F4
		Public Property BottomMargin As Double
			Get
				Return Me.oo._00..BottomMargin
			End Get
			Set(value As Double)
				Me.oo._00..BottomMargin = value
			End Set
		End Property

		' Token: 0x17001319 RID: 4889
		' (get) Token: 0x06005278 RID: 21112 RVA: 0x0021C502 File Offset: 0x0021A702
		' (set) Token: 0x06005279 RID: 21113 RVA: 0x0021C50F File Offset: 0x0021A70F
		Public Property TextFont As Font
			Get
				Return Me.oo._00..TextFont
			End Get
			Set(value As Font)
				Me.oo._00..TextFont = CType(value.Clone(), Font)
			End Set
		End Property

		' Token: 0x1700131A RID: 4890
		' (get) Token: 0x0600527A RID: 21114 RVA: 0x0021C527 File Offset: 0x0021A727
		' (set) Token: 0x0600527B RID: 21115 RVA: 0x0021C534 File Offset: 0x0021A734
		Public Property TextForeColor As Color
			Get
				Return Me.oo._00..TextForeColor
			End Get
			Set(value As Color)
				Me.oo._00..TextForeColor = value
			End Set
		End Property

		' Token: 0x1700131B RID: 4891
		' (get) Token: 0x0600527C RID: 21116 RVA: 0x0021C542 File Offset: 0x0021A742
		' (set) Token: 0x0600527D RID: 21117 RVA: 0x0021C54F File Offset: 0x0021A74F
		Public Property AztecCodeFormat As AztecCodeFormat
			Get
				Return Me.oo._00..AztecCodeFormat
			End Get
			Set(value As AztecCodeFormat)
				Me.oo._00..AztecCodeFormat = value
			End Set
		End Property

		' Token: 0x1700131C RID: 4892
		' (get) Token: 0x0600527E RID: 21118 RVA: 0x0021C55D File Offset: 0x0021A75D
		' (set) Token: 0x0600527F RID: 21119 RVA: 0x0021C56A File Offset: 0x0021A76A
		Public Property AztecCodeModuleSize As Double
			Get
				Return Me.oo._00..AztecCodeModuleSize
			End Get
			Set(value As Double)
				Me.oo._00..AztecCodeModuleSize = value
			End Set
		End Property

		' Token: 0x1700131D RID: 4893
		' (get) Token: 0x06005280 RID: 21120 RVA: 0x0021C578 File Offset: 0x0021A778
		' (set) Token: 0x06005281 RID: 21121 RVA: 0x0021C585 File Offset: 0x0021A785
		Public Property AztecCodeErrorCorrection As Integer
			Get
				Return Me.oo._00..AztecCodeErrorCorrection
			End Get
			Set(value As Integer)
				Me.oo._00..AztecCodeErrorCorrection = value
			End Set
		End Property

		' Token: 0x1700131E RID: 4894
		' (get) Token: 0x06005282 RID: 21122 RVA: 0x0021C593 File Offset: 0x0021A793
		' (set) Token: 0x06005283 RID: 21123 RVA: 0x0021C5A0 File Offset: 0x0021A7A0
		Public Property AztecCodeRune As Integer
			Get
				Return Me.oo._00..AztecCodeRune
			End Get
			Set(value As Integer)
				Me.oo._00..AztecCodeRune = value
			End Set
		End Property

		' Token: 0x1700131F RID: 4895
		' (get) Token: 0x06005284 RID: 21124 RVA: 0x0021C5AE File Offset: 0x0021A7AE
		' (set) Token: 0x06005285 RID: 21125 RVA: 0x0021C5BB File Offset: 0x0021A7BB
		Public Property CodabarStartChar As CodabarStartStopChar
			Get
				Return Me.oo._00..CodabarStartChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.oo._00..CodabarStartChar = value
			End Set
		End Property

		' Token: 0x17001320 RID: 4896
		' (get) Token: 0x06005286 RID: 21126 RVA: 0x0021C5C9 File Offset: 0x0021A7C9
		' (set) Token: 0x06005287 RID: 21127 RVA: 0x0021C5D6 File Offset: 0x0021A7D6
		Public Property CodabarStopChar As CodabarStartStopChar
			Get
				Return Me.oo._00..CodabarStopChar
			End Get
			Set(value As CodabarStartStopChar)
				Me.oo._00..CodabarStopChar = value
			End Set
		End Property

		' Token: 0x17001321 RID: 4897
		' (get) Token: 0x06005288 RID: 21128 RVA: 0x0021C5E4 File Offset: 0x0021A7E4
		' (set) Token: 0x06005289 RID: 21129 RVA: 0x0021C5F1 File Offset: 0x0021A7F1
		Public Property Code128CharSet As Code128
			Get
				Return Me.oo._00..Code128CharSet
			End Get
			Set(value As Code128)
				Me.oo._00..Code128CharSet = value
			End Set
		End Property

		' Token: 0x17001322 RID: 4898
		' (get) Token: 0x0600528A RID: 21130 RVA: 0x0021C5FF File Offset: 0x0021A7FF
		' (set) Token: 0x0600528B RID: 21131 RVA: 0x0021C60C File Offset: 0x0021A80C
		Public Property Code16kMode As Code16k
			Get
				Return Me.oo._00..Code16kMode
			End Get
			Set(value As Code16k)
				Me.oo._00..Code16kMode = value
			End Set
		End Property

		' Token: 0x17001323 RID: 4899
		' (get) Token: 0x0600528C RID: 21132 RVA: 0x0021C61A File Offset: 0x0021A81A
		' (set) Token: 0x0600528D RID: 21133 RVA: 0x0021C627 File Offset: 0x0021A827
		Public Property DataMatrixEncoding As DataMatrixEncoding
			Get
				Return Me.oo._00..DataMatrixEncoding
			End Get
			Set(value As DataMatrixEncoding)
				Me.oo._00..DataMatrixEncoding = value
			End Set
		End Property

		' Token: 0x17001324 RID: 4900
		' (get) Token: 0x0600528E RID: 21134 RVA: 0x0021C635 File Offset: 0x0021A835
		' (set) Token: 0x0600528F RID: 21135 RVA: 0x0021C642 File Offset: 0x0021A842
		Public Property DataMatrixFormat As DataMatrixFormat
			Get
				Return Me.oo._00..DataMatrixFormat
			End Get
			Set(value As DataMatrixFormat)
				Me.oo._00..DataMatrixFormat = value
			End Set
		End Property

		' Token: 0x17001325 RID: 4901
		' (get) Token: 0x06005290 RID: 21136 RVA: 0x0021C650 File Offset: 0x0021A850
		' (set) Token: 0x06005291 RID: 21137 RVA: 0x0021C65D File Offset: 0x0021A85D
		Public Property DataMatrixModuleSize As Double
			Get
				Return Me.oo._00..DataMatrixModuleSize
			End Get
			Set(value As Double)
				Me.oo._00..DataMatrixModuleSize = value
			End Set
		End Property

		' Token: 0x17001326 RID: 4902
		' (get) Token: 0x06005292 RID: 21138 RVA: 0x0021C66B File Offset: 0x0021A86B
		' (set) Token: 0x06005293 RID: 21139 RVA: 0x0021C678 File Offset: 0x0021A878
		Public Property DataMatrixProcessTilde As Boolean
			Get
				Return Me.oo._00..DataMatrixProcessTilde
			End Get
			Set(value As Boolean)
				Me.oo._00..DataMatrixProcessTilde = value
			End Set
		End Property

		' Token: 0x17001327 RID: 4903
		' (get) Token: 0x06005294 RID: 21140 RVA: 0x0021C686 File Offset: 0x0021A886
		' (set) Token: 0x06005295 RID: 21141 RVA: 0x0021C693 File Offset: 0x0021A893
		Public Property EanUpcSupplement As Supplement
			Get
				Return Me.oo._00..EanUpcSupplement
			End Get
			Set(value As Supplement)
				Me.oo._00..EanUpcSupplement = value
			End Set
		End Property

		' Token: 0x17001328 RID: 4904
		' (get) Token: 0x06005296 RID: 21142 RVA: 0x0021C6A1 File Offset: 0x0021A8A1
		' (set) Token: 0x06005297 RID: 21143 RVA: 0x0021C6AE File Offset: 0x0021A8AE
		Public Property EanUpcSupplementCode As String
			Get
				Return Me.oo._00..EanUpcSupplementCode
			End Get
			Set(value As String)
				Me.oo._00..EanUpcSupplementCode = value
			End Set
		End Property

		' Token: 0x17001329 RID: 4905
		' (get) Token: 0x06005298 RID: 21144 RVA: 0x0021C6BC File Offset: 0x0021A8BC
		' (set) Token: 0x06005299 RID: 21145 RVA: 0x0021C6C9 File Offset: 0x0021A8C9
		Public Property EanUpcSupplementSeparation As Double
			Get
				Return Me.oo._00..EanUpcSupplementSeparation
			End Get
			Set(value As Double)
				Me.oo._00..EanUpcSupplementSeparation = value
			End Set
		End Property

		' Token: 0x1700132A RID: 4906
		' (get) Token: 0x0600529A RID: 21146 RVA: 0x0021C6D7 File Offset: 0x0021A8D7
		' (set) Token: 0x0600529B RID: 21147 RVA: 0x0021C6E4 File Offset: 0x0021A8E4
		Public Property EanUpcSupplementTopMargin As Double
			Get
				Return Me.oo._00..EanUpcSupplementTopMargin
			End Get
			Set(value As Double)
				Me.oo._00..EanUpcSupplementTopMargin = value
			End Set
		End Property

		' Token: 0x1700132B RID: 4907
		' (get) Token: 0x0600529C RID: 21148 RVA: 0x0021C6F2 File Offset: 0x0021A8F2
		' (set) Token: 0x0600529D RID: 21149 RVA: 0x0021C6FF File Offset: 0x0021A8FF
		Public Property GuardBar As Boolean
			Get
				Return Me.oo._00..GuardBar
			End Get
			Set(value As Boolean)
				Me.oo._00..GuardBar = value
			End Set
		End Property

		' Token: 0x1700132C RID: 4908
		' (get) Token: 0x0600529E RID: 21150 RVA: 0x0021C70D File Offset: 0x0021A90D
		' (set) Token: 0x0600529F RID: 21151 RVA: 0x0021C71A File Offset: 0x0021A91A
		Public Property GuardBarHeight As Double
			Get
				Return Me.oo._00..GuardBarHeight
			End Get
			Set(value As Double)
				Me.oo._00..GuardBarHeight = value
			End Set
		End Property

		' Token: 0x1700132D RID: 4909
		' (get) Token: 0x060052A0 RID: 21152 RVA: 0x0021C728 File Offset: 0x0021A928
		' (set) Token: 0x060052A1 RID: 21153 RVA: 0x0021C735 File Offset: 0x0021A935
		Public Property UpcESystem As UpcE
			Get
				Return Me.oo._00..UpcESystem
			End Get
			Set(value As UpcE)
				Me.oo._00..UpcESystem = value
			End Set
		End Property

		' Token: 0x1700132E RID: 4910
		' (get) Token: 0x060052A2 RID: 21154 RVA: 0x0021C743 File Offset: 0x0021A943
		' (set) Token: 0x060052A3 RID: 21155 RVA: 0x0021C750 File Offset: 0x0021A950
		Public Property SegmentsPerRow As Integer
			Get
				Return Me.oo._00..SegmentsPerRow
			End Get
			Set(value As Integer)
				Me.oo._00..SegmentsPerRow = value
			End Set
		End Property

		' Token: 0x1700132F RID: 4911
		' (get) Token: 0x060052A4 RID: 21156 RVA: 0x0021C75E File Offset: 0x0021A95E
		' (set) Token: 0x060052A5 RID: 21157 RVA: 0x0021C76B File Offset: 0x0021A96B
		Public Property HibcFormatHumanReadableText As Boolean
			Get
				Return Me.oo._00..HibcFormatHumanReadableText
			End Get
			Set(value As Boolean)
				Me.oo._00..HibcFormatHumanReadableText = value
			End Set
		End Property

		' Token: 0x17001330 RID: 4912
		' (get) Token: 0x060052A6 RID: 21158 RVA: 0x0021C779 File Offset: 0x0021A979
		' (set) Token: 0x060052A7 RID: 21159 RVA: 0x0021C786 File Offset: 0x0021A986
		Public Property Isbt128DataStructure As Isbt128DataStructure
			Get
				Return Me.oo._00..Isbt128DataStructure
			End Get
			Set(value As Isbt128DataStructure)
				Me.oo._00..Isbt128DataStructure = value
			End Set
		End Property

		' Token: 0x17001331 RID: 4913
		' (get) Token: 0x060052A8 RID: 21160 RVA: 0x0021C794 File Offset: 0x0021A994
		' (set) Token: 0x060052A9 RID: 21161 RVA: 0x0021C7A1 File Offset: 0x0021A9A1
		Public Property MaxiCodeMode As MaxiCodeModes
			Get
				Return Me.oo._00..MaxiCodeMode
			End Get
			Set(value As MaxiCodeModes)
				Me.oo._00..MaxiCodeMode = value
			End Set
		End Property

		' Token: 0x17001332 RID: 4914
		' (get) Token: 0x060052AA RID: 21162 RVA: 0x0021C7AF File Offset: 0x0021A9AF
		' (set) Token: 0x060052AB RID: 21163 RVA: 0x0021C7BC File Offset: 0x0021A9BC
		Public Property MaxiCodeProcessTilde As Boolean
			Get
				Return Me.oo._00..MaxiCodeProcessTilde
			End Get
			Set(value As Boolean)
				Me.oo._00..MaxiCodeProcessTilde = value
			End Set
		End Property

		' Token: 0x17001333 RID: 4915
		' (get) Token: 0x060052AC RID: 21164 RVA: 0x0021C7CA File Offset: 0x0021A9CA
		' (set) Token: 0x060052AD RID: 21165 RVA: 0x0021C7D7 File Offset: 0x0021A9D7
		Public Property MaxiCodeSymbolCount As Integer
			Get
				Return Me.oo._00..MaxiCodeSymbolCount
			End Get
			Set(value As Integer)
				Me.oo._00..MaxiCodeSymbolCount = value
			End Set
		End Property

		' Token: 0x17001334 RID: 4916
		' (get) Token: 0x060052AE RID: 21166 RVA: 0x0021C7E5 File Offset: 0x0021A9E5
		' (set) Token: 0x060052AF RID: 21167 RVA: 0x0021C7F2 File Offset: 0x0021A9F2
		Public Property MaxiCodeSymbolIndex As Integer
			Get
				Return Me.oo._00..MaxiCodeSymbolIndex
			End Get
			Set(value As Integer)
				Me.oo._00..MaxiCodeSymbolIndex = value
			End Set
		End Property

		' Token: 0x17001335 RID: 4917
		' (get) Token: 0x060052B0 RID: 21168 RVA: 0x0021C800 File Offset: 0x0021AA00
		' (set) Token: 0x060052B1 RID: 21169 RVA: 0x0021C80D File Offset: 0x0021AA0D
		Public Property ms As MsiChecksum
			Get
				Return Me.oo._00..MsiChecksum
			End Get
			Set(value As MsiChecksum)
				Me.oo._00..MsiChecksum = value
			End Set
		End Property

		' Token: 0x17001336 RID: 4918
		' (get) Token: 0x060052B2 RID: 21170 RVA: 0x0021C81B File Offset: 0x0021AA1B
		' (set) Token: 0x060052B3 RID: 21171 RVA: 0x0021C828 File Offset: 0x0021AA28
		Public Property MicroPdf417Version As MicroPdf417Version
			Get
				Return Me.oo._00..MicroPdf417Version
			End Get
			Set(value As MicroPdf417Version)
				Me.oo._00..MicroPdf417Version = value
			End Set
		End Property

		' Token: 0x17001337 RID: 4919
		' (get) Token: 0x060052B4 RID: 21172 RVA: 0x0021C836 File Offset: 0x0021AA36
		' (set) Token: 0x060052B5 RID: 21173 RVA: 0x0021C843 File Offset: 0x0021AA43
		Public Property Pdf417AspectRatio As Double
			Get
				Return Me.oo._00..Pdf417AspectRatio
			End Get
			Set(value As Double)
				Me.oo._00..Pdf417AspectRatio = value
			End Set
		End Property

		' Token: 0x17001338 RID: 4920
		' (get) Token: 0x060052B6 RID: 21174 RVA: 0x0021C851 File Offset: 0x0021AA51
		' (set) Token: 0x060052B7 RID: 21175 RVA: 0x0021C85E File Offset: 0x0021AA5E
		Public Property Pdf417Columns As Integer
			Get
				Return Me.oo._00..Pdf417Columns
			End Get
			Set(value As Integer)
				Me.oo._00..Pdf417Columns = value
			End Set
		End Property

		' Token: 0x17001339 RID: 4921
		' (get) Token: 0x060052B8 RID: 21176 RVA: 0x0021C86C File Offset: 0x0021AA6C
		' (set) Token: 0x060052B9 RID: 21177 RVA: 0x0021C879 File Offset: 0x0021AA79
		Public Property Pdf417CompactionType As Pdf417CompactionType
			Get
				Return Me.oo._00..Pdf417CompactionType
			End Get
			Set(value As Pdf417CompactionType)
				Me.oo._00..Pdf417CompactionType = value
			End Set
		End Property

		' Token: 0x1700133A RID: 4922
		' (get) Token: 0x060052BA RID: 21178 RVA: 0x0021C887 File Offset: 0x0021AA87
		' (set) Token: 0x060052BB RID: 21179 RVA: 0x0021C894 File Offset: 0x0021AA94
		Public Property Pdf417ErrorCorrectionLevel As Pdf417ErrorCorrection
			Get
				Return Me.oo._00..Pdf417ErrorCorrectionLevel
			End Get
			Set(value As Pdf417ErrorCorrection)
				Me.oo._00..Pdf417ErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x1700133B RID: 4923
		' (get) Token: 0x060052BC RID: 21180 RVA: 0x0021C8A2 File Offset: 0x0021AAA2
		' (set) Token: 0x060052BD RID: 21181 RVA: 0x0021C8AF File Offset: 0x0021AAAF
		Public Property Pdf417FileId As String
			Get
				Return Me.oo._00..Pdf417FileId
			End Get
			Set(value As String)
				Me.oo._00..Pdf417FileId = value
			End Set
		End Property

		' Token: 0x1700133C RID: 4924
		' (get) Token: 0x060052BE RID: 21182 RVA: 0x0021C8BD File Offset: 0x0021AABD
		' (set) Token: 0x060052BF RID: 21183 RVA: 0x0021C8CA File Offset: 0x0021AACA
		Public Property Pdf417Rows As Integer
			Get
				Return Me.oo._00..Pdf417Rows
			End Get
			Set(value As Integer)
				Me.oo._00..Pdf417Rows = value
			End Set
		End Property

		' Token: 0x1700133D RID: 4925
		' (get) Token: 0x060052C0 RID: 21184 RVA: 0x0021C8D8 File Offset: 0x0021AAD8
		' (set) Token: 0x060052C1 RID: 21185 RVA: 0x0021C8E5 File Offset: 0x0021AAE5
		Public Property Pdf417SegmentCount As Integer
			Get
				Return Me.oo._00..Pdf417SegmentCount
			End Get
			Set(value As Integer)
				Me.oo._00..Pdf417SegmentCount = value
			End Set
		End Property

		' Token: 0x1700133E RID: 4926
		' (get) Token: 0x060052C2 RID: 21186 RVA: 0x0021C8F3 File Offset: 0x0021AAF3
		' (set) Token: 0x060052C3 RID: 21187 RVA: 0x0021C900 File Offset: 0x0021AB00
		Public Property Pdf417SegmentIndex As Integer
			Get
				Return Me.oo._00..Pdf417SegmentIndex
			End Get
			Set(value As Integer)
				Me.oo._00..Pdf417SegmentIndex = value
			End Set
		End Property

		' Token: 0x1700133F RID: 4927
		' (get) Token: 0x060052C4 RID: 21188 RVA: 0x0021C90E File Offset: 0x0021AB0E
		' (set) Token: 0x060052C5 RID: 21189 RVA: 0x0021C91B File Offset: 0x0021AB1B
		Public Property Pdf417Truncated As Boolean
			Get
				Return Me.oo._00..Pdf417Truncated
			End Get
			Set(value As Boolean)
				Me.oo._00..Pdf417Truncated = value
			End Set
		End Property

		' Token: 0x17001340 RID: 4928
		' (get) Token: 0x060052C6 RID: 21190 RVA: 0x0021C929 File Offset: 0x0021AB29
		' (set) Token: 0x060052C7 RID: 21191 RVA: 0x0021C936 File Offset: 0x0021AB36
		Public Property PharmacodeBarsSpacing As Double
			Get
				Return Me.oo._00..PharmacodeBarsSpacing
			End Get
			Set(value As Double)
				Me.oo._00..PharmacodeBarsSpacing = value
			End Set
		End Property

		' Token: 0x17001341 RID: 4929
		' (get) Token: 0x060052C8 RID: 21192 RVA: 0x0021C944 File Offset: 0x0021AB44
		' (set) Token: 0x060052C9 RID: 21193 RVA: 0x0021C951 File Offset: 0x0021AB51
		Public Property PharmacodeThickBarWidth As Double
			Get
				Return Me.oo._00..PharmacodeThickBarWidth
			End Get
			Set(value As Double)
				Me.oo._00..PharmacodeThickBarWidth = value
			End Set
		End Property

		' Token: 0x17001342 RID: 4930
		' (get) Token: 0x060052CA RID: 21194 RVA: 0x0021C95F File Offset: 0x0021AB5F
		' (set) Token: 0x060052CB RID: 21195 RVA: 0x0021C96C File Offset: 0x0021AB6C
		Public Property PharmacodeThinBarWidth As Double
			Get
				Return Me.oo._00..PharmacodeThinBarWidth
			End Get
			Set(value As Double)
				Me.oo._00..PharmacodeThinBarWidth = value
			End Set
		End Property

		' Token: 0x17001343 RID: 4931
		' (get) Token: 0x060052CC RID: 21196 RVA: 0x0021C97A File Offset: 0x0021AB7A
		' (set) Token: 0x060052CD RID: 21197 RVA: 0x0021C987 File Offset: 0x0021AB87
		Public Property PlanetHeightShortBar As Double
			Get
				Return Me.oo._00..PlanetHeightShortBar
			End Get
			Set(value As Double)
				Me.oo._00..PlanetHeightShortBar = value
			End Set
		End Property

		' Token: 0x17001344 RID: 4932
		' (get) Token: 0x060052CE RID: 21198 RVA: 0x0021C995 File Offset: 0x0021AB95
		' (set) Token: 0x060052CF RID: 21199 RVA: 0x0021C9A2 File Offset: 0x0021ABA2
		Public Property PlanetHeightTallBar As Double
			Get
				Return Me.oo._00..PlanetHeightTallBar
			End Get
			Set(value As Double)
				Me.oo._00..PlanetHeightTallBar = value
			End Set
		End Property

		' Token: 0x17001345 RID: 4933
		' (get) Token: 0x060052D0 RID: 21200 RVA: 0x0021C9B0 File Offset: 0x0021ABB0
		' (set) Token: 0x060052D1 RID: 21201 RVA: 0x0021C9BD File Offset: 0x0021ABBD
		Public Property Postal4StateAddStartStopChar As Boolean
			Get
				Return Me.oo._00..Postal4StateAddStartStopChar
			End Get
			Set(value As Boolean)
				Me.oo._00..Postal4StateAddStartStopChar = value
			End Set
		End Property

		' Token: 0x17001346 RID: 4934
		' (get) Token: 0x060052D2 RID: 21202 RVA: 0x0021C9CB File Offset: 0x0021ABCB
		' (set) Token: 0x060052D3 RID: 21203 RVA: 0x0021C9D8 File Offset: 0x0021ABD8
		Public Property Postal4StateBarsSpacing As Double
			Get
				Return Me.oo._00..Postal4StateBarsSpacing
			End Get
			Set(value As Double)
				Me.oo._00..Postal4StateBarsSpacing = value
			End Set
		End Property

		' Token: 0x17001347 RID: 4935
		' (get) Token: 0x060052D4 RID: 21204 RVA: 0x0021C9E6 File Offset: 0x0021ABE6
		' (set) Token: 0x060052D5 RID: 21205 RVA: 0x0021C9F3 File Offset: 0x0021ABF3
		Public Property Postal4StateTrackerBarHeight As Double
			Get
				Return Me.oo._00..Postal4StateTrackerBarHeight
			End Get
			Set(value As Double)
				Me.oo._00..Postal4StateTrackerBarHeight = value
			End Set
		End Property

		' Token: 0x17001348 RID: 4936
		' (get) Token: 0x060052D6 RID: 21206 RVA: 0x0021CA01 File Offset: 0x0021AC01
		' (set) Token: 0x060052D7 RID: 21207 RVA: 0x0021CA0E File Offset: 0x0021AC0E
		Public Property Postal4StateTrackerBarWidth As Double
			Get
				Return Me.oo._00..Postal4StateTrackerBarWidth
			End Get
			Set(value As Double)
				Me.oo._00..Postal4StateTrackerBarWidth = value
			End Set
		End Property

		' Token: 0x17001349 RID: 4937
		' (get) Token: 0x060052D8 RID: 21208 RVA: 0x0021CA1C File Offset: 0x0021AC1C
		' (set) Token: 0x060052D9 RID: 21209 RVA: 0x0021CA29 File Offset: 0x0021AC29
		Public Property PostnetHeightShortBar As Double
			Get
				Return Me.oo._00..PostnetHeightShortBar
			End Get
			Set(value As Double)
				Me.oo._00..PostnetHeightShortBar = value
			End Set
		End Property

		' Token: 0x1700134A RID: 4938
		' (get) Token: 0x060052DA RID: 21210 RVA: 0x0021CA37 File Offset: 0x0021AC37
		' (set) Token: 0x060052DB RID: 21211 RVA: 0x0021CA44 File Offset: 0x0021AC44
		Public Property PostnetHeightTallBar As Double
			Get
				Return Me.oo._00..PostnetHeightTallBar
			End Get
			Set(value As Double)
				Me.oo._00..PostnetHeightTallBar = value
			End Set
		End Property

		' Token: 0x1700134B RID: 4939
		' (get) Token: 0x060052DC RID: 21212 RVA: 0x0021CA52 File Offset: 0x0021AC52
		' (set) Token: 0x060052DD RID: 21213 RVA: 0x0021CA5F File Offset: 0x0021AC5F
		Public Property MicroQRCodeVersion As MicroQRCodeVersion
			Get
				Return Me.oo._00..MicroQRCodeVersion
			End Get
			Set(value As MicroQRCodeVersion)
				Me.oo._00..MicroQRCodeVersion = value
			End Set
		End Property

		' Token: 0x1700134C RID: 4940
		' (get) Token: 0x060052DE RID: 21214 RVA: 0x0021CA6D File Offset: 0x0021AC6D
		' (set) Token: 0x060052DF RID: 21215 RVA: 0x0021CA7A File Offset: 0x0021AC7A
		Public Property QRCodeEncoding As QRCodeEncoding
			Get
				Return Me.oo._00..QRCodeEncoding
			End Get
			Set(value As QRCodeEncoding)
				Me.oo._00..QRCodeEncoding = value
			End Set
		End Property

		' Token: 0x1700134D RID: 4941
		' (get) Token: 0x060052E0 RID: 21216 RVA: 0x0021CA88 File Offset: 0x0021AC88
		' (set) Token: 0x060052E1 RID: 21217 RVA: 0x0021CA95 File Offset: 0x0021AC95
		Public Property QRCodeVersion As QRCodeVersion
			Get
				Return Me.oo._00..QRCodeVersion
			End Get
			Set(value As QRCodeVersion)
				Me.oo._00..QRCodeVersion = value
			End Set
		End Property

		' Token: 0x1700134E RID: 4942
		' (get) Token: 0x060052E2 RID: 21218 RVA: 0x0021CAA3 File Offset: 0x0021ACA3
		' (set) Token: 0x060052E3 RID: 21219 RVA: 0x0021CAB0 File Offset: 0x0021ACB0
		Public Property QRCodeErrorCorrectionLevel As QRCodeErrorCorrectionLevel
			Get
				Return Me.oo._00..QRCodeErrorCorrectionLevel
			End Get
			Set(value As QRCodeErrorCorrectionLevel)
				Me.oo._00..QRCodeErrorCorrectionLevel = value
			End Set
		End Property

		' Token: 0x1700134F RID: 4943
		' (get) Token: 0x060052E4 RID: 21220 RVA: 0x0021CABE File Offset: 0x0021ACBE
		' (set) Token: 0x060052E5 RID: 21221 RVA: 0x0021CACB File Offset: 0x0021ACCB
		Public Property QRCodeByteEncodingName As String
			Get
				Return Me.oo._00..QRCodeByteEncodingName
			End Get
			Set(value As String)
				Me.oo._00..QRCodeByteEncodingName = value
			End Set
		End Property

		' Token: 0x17001350 RID: 4944
		' (get) Token: 0x060052E6 RID: 21222 RVA: 0x0021CAD9 File Offset: 0x0021ACD9
		' (set) Token: 0x060052E7 RID: 21223 RVA: 0x0021CAE6 File Offset: 0x0021ACE6
		Public Property QRCodeModuleSize As Double
			Get
				Return Me.oo._00..QRCodeModuleSize
			End Get
			Set(value As Double)
				Me.oo._00..QRCodeModuleSize = value
			End Set
		End Property

		' Token: 0x17001351 RID: 4945
		' (get) Token: 0x060052E8 RID: 21224 RVA: 0x0021CAF4 File Offset: 0x0021ACF4
		' (set) Token: 0x060052E9 RID: 21225 RVA: 0x0021CB01 File Offset: 0x0021AD01
		Public Property TelepenEncoding As TelepenEncoding
			Get
				Return Me.oo._00..TelepenEncoding
			End Get
			Set(value As TelepenEncoding)
				Me.oo._00..TelepenEncoding = value
			End Set
		End Property

		' Token: 0x17001352 RID: 4946
		' (get) Token: 0x060052EA RID: 21226 RVA: 0x0021CB0F File Offset: 0x0021AD0F
		' (set) Token: 0x060052EB RID: 21227 RVA: 0x0021CB1C File Offset: 0x0021AD1C
		Public Property UspsFimPattern As FIM
			Get
				Return Me.oo._00..UspsFimPattern
			End Get
			Set(value As FIM)
				Me.oo._00..UspsFimPattern = value
			End Set
		End Property

		' Token: 0x17001353 RID: 4947
		' (get) Token: 0x060052EC RID: 21228 RVA: 0x0021CB2A File Offset: 0x0021AD2A
		' (set) Token: 0x060052ED RID: 21229 RVA: 0x0021CB37 File Offset: 0x0021AD37
		Public Property UspsHorizontalBarsCount As Integer
			Get
				Return Me.oo._00..UspsHorizontalBarsCount
			End Get
			Set(value As Integer)
				Me.oo._00..UspsHorizontalBarsCount = value
			End Set
		End Property

		' Token: 0x060052EE RID: 21230 RVA: 0x0021CB45 File Offset: 0x0021AD45
		Public Sub SaveImage(FileName As String)
			Me.SaveImage(FileName, 300F)
		End Sub

		' Token: 0x060052EF RID: 21231 RVA: 0x0021CB54 File Offset: 0x0021AD54
		Public Sub SaveImage(FileName As String, dpi As Single)
			Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(FileName)
			If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
				OO_00oOO.FileSys.CreateDirectory(parentPath)
			End If
			Me.oo._00..Save(FileName, O_O0OO.OoO_00._.(FileName), dpi)
		End Sub

		' Token: 0x060052F0 RID: 21232 RVA: 0x0021CB98 File Offset: 0x0021AD98
		Public Function GetImage() As Image
			Return Me.oo._00..GetBarcodeImage(300F)
		End Function

		' Token: 0x060052F1 RID: 21233 RVA: 0x0021CBAA File Offset: 0x0021ADAA
		Public Function GetImage(dpi As Integer) As Image
			Return Me.oo._00..GetBarcodeImage(CSng(dpi))
		End Function

		' Token: 0x060052F2 RID: 21234 RVA: 0x0021CBB9 File Offset: 0x0021ADB9
		Public Sub CopyImage()
			Clipboard.SetImage(Me.oo._00..GetBarcodeImage(300F))
		End Sub

		' Token: 0x060052F3 RID: 21235 RVA: 0x0021CBD0 File Offset: 0x0021ADD0
		Public Sub CopyImage(dpi As Integer)
			Clipboard.SetImage(Me.oo._00..GetBarcodeImage(CSng(dpi)))
		End Sub

		' Token: 0x060052F4 RID: 21236 RVA: 0x0021CBE4 File Offset: 0x0021ADE4
		Public Sub DrawOnCanvas(graphic As Graphics)
			Me.oo._00..DrawOnCanvas(graphic)
		End Sub

		' Token: 0x060052F5 RID: 21237 RVA: 0x0021CBF2 File Offset: 0x0021ADF2
		Public Sub DrawOnCanvas(graphic As Graphics, x As Single, y As Single)
			Me.oo._00..DrawOnCanvas(graphic, New PointF(x, y))
		End Sub

		' Token: 0x060052F6 RID: 21238 RVA: 0x0021CC07 File Offset: 0x0021AE07
		Public Sub DrawOnCanvas(graphic As Graphics, x As Single, y As Single, Scale As Single)
			Me.oo._00..DrawOnCanvas(graphic, New PointF(x, y), Scale)
		End Sub

		' Token: 0x060052F7 RID: 21239 RVA: 0x0021CC1E File Offset: 0x0021AE1E
		Public Sub SetindField(Field As String) Implements Foxtable.OoO_.O_o.o__.
			Me.BindingField = Field
		End Sub

		' Token: 0x040021BD RID: 8637
		Private <<EMPTY_NAME>> As OOo00o_0o0_
	End Class
End Namespace
