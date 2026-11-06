Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Gauge
Imports C1.Win.C1Input
Imports C1.Win.C1Themes
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.WinForm
	' Token: 0x0200025E RID: 606
	<ComVisible(True)>
	Public Class Control
		' Token: 0x06001C85 RID: 7301 RVA: 0x000B650C File Offset: 0x000B470C
		Public Sub New(A_0 As Control, A_1 As ControlTypeEnum)
			Me.o.__O0O. = A_0
			Me.o.__O0O. = A_1
			Me.o.__O0O. = A_0.PointToClient(Control.MousePosition)
		End Sub

		' Token: 0x1700064F RID: 1615
		' (get) Token: 0x06001C86 RID: 7302 RVA: 0x000B6534 File Offset: 0x000B4734
		' (set) Token: 0x06001C87 RID: 7303 RVA: 0x000B65CE File Offset: 0x000B47CE
		<oO0oooo("1860")>
		Public Overridable Property BindingField As String
			Get
				If Me.o.__O0O..DataBindings.Count > 0 Then
					Dim binding As Binding = Me.o.__O0O..DataBindings(0)
					If TypeOf binding.DataSource Is O_0 Then
						Return CType(binding.DataSource, O_0).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField
					End If
					If binding.DataSource Is OO_00oOO.Vars.VariableTable Then
						Return "全局变量." + binding.BindingMemberInfo.BindingField
					End If
				End If
				Return Nothing
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000650 RID: 1616
		' (get) Token: 0x06001C88 RID: 7304 RVA: 0x000B65D0 File Offset: 0x000B47D0
		' (set) Token: 0x06001C89 RID: 7305 RVA: 0x000B65D3 File Offset: 0x000B47D3
		<oO0oooo("0749")>
		Public Overridable Property [ReadOnly] As BooleanEnum
			Get
				Return 0
			End Get
			Set(value As BooleanEnum)
			End Set
		End Property

		' Token: 0x06001C8A RID: 7306 RVA: 0x000B65D5 File Offset: 0x000B47D5
		Public Sub RefrshReadonly()
			If TypeOf Me.o.__O0O. Is O000O Then
				CType(Me.o.__O0O., O000O).SetReadOnlyProperty()
			End If
		End Sub

		' Token: 0x17000651 RID: 1617
		' (get) Token: 0x06001C8B RID: 7307 RVA: 0x000B65F4 File Offset: 0x000B47F4
		Public ReadOnly Property BaseControl As Control
			Get
				Return Me.o.__O0O.
			End Get
		End Property

		' Token: 0x17000652 RID: 1618
		' (get) Token: 0x06001C8C RID: 7308 RVA: 0x000B65FC File Offset: 0x000B47FC
		' (set) Token: 0x06001C8D RID: 7309 RVA: 0x000B6609 File Offset: 0x000B4809
		Public Overridable Property Name As String
			Get
				Return Me.o.__O0O..Name
			End Get
			Set(value As String)
				Me.o.__O0O..Name = value
			End Set
		End Property

		' Token: 0x17000653 RID: 1619
		' (get) Token: 0x06001C8E RID: 7310 RVA: 0x000B6617 File Offset: 0x000B4817
		' (set) Token: 0x06001C8F RID: 7311 RVA: 0x000B6624 File Offset: 0x000B4824
		<oO0oooo("0714")>
		Public Property Enabled As Boolean
			Get
				Return Me.o.__O0O..Enabled
			End Get
			Set(value As Boolean)
				If Me.Form Is Nothing OrElse Me.Form.O_o_.0o0__o0O. IsNot Me.o.__O0O. Then
					Me.o.__O0O..Enabled = value
				End If
			End Set
		End Property

		' Token: 0x17000654 RID: 1620
		' (get) Token: 0x06001C90 RID: 7312 RVA: 0x000B664D File Offset: 0x000B484D
		' (set) Token: 0x06001C91 RID: 7313 RVA: 0x000B665A File Offset: 0x000B485A
		<oO0oooo("0715")>
		Public Property Visible As Boolean
			Get
				Return Me.o.__O0O..Visible
			End Get
			Set(value As Boolean)
				Me.o.__O0O..Visible = value
			End Set
		End Property

		' Token: 0x17000655 RID: 1621
		' (get) Token: 0x06001C92 RID: 7314 RVA: 0x000B6668 File Offset: 0x000B4868
		' (set) Token: 0x06001C93 RID: 7315 RVA: 0x000B6675 File Offset: 0x000B4875
		Public Property Left As Integer
			Get
				Return Me.o.__O0O..Left
			End Get
			Set(value As Integer)
				Me.o.__O0O..Left = value
			End Set
		End Property

		' Token: 0x17000656 RID: 1622
		' (get) Token: 0x06001C94 RID: 7316 RVA: 0x000B6683 File Offset: 0x000B4883
		' (set) Token: 0x06001C95 RID: 7317 RVA: 0x000B6690 File Offset: 0x000B4890
		Public Property Top As Integer
			Get
				Return Me.o.__O0O..Top
			End Get
			Set(value As Integer)
				Me.o.__O0O..Top = value
			End Set
		End Property

		' Token: 0x17000657 RID: 1623
		' (get) Token: 0x06001C96 RID: 7318 RVA: 0x000B669E File Offset: 0x000B489E
		' (set) Token: 0x06001C97 RID: 7319 RVA: 0x000B66AB File Offset: 0x000B48AB
		Public Overridable Property Width As Integer
			Get
				Return Me.o.__O0O..Width
			End Get
			Set(value As Integer)
				Me.o.__O0O..Width = value
			End Set
		End Property

		' Token: 0x17000658 RID: 1624
		' (get) Token: 0x06001C98 RID: 7320 RVA: 0x000B66B9 File Offset: 0x000B48B9
		' (set) Token: 0x06001C99 RID: 7321 RVA: 0x000B66C6 File Offset: 0x000B48C6
		Public Overridable Property Height As Integer
			Get
				Return Me.o.__O0O..Height
			End Get
			Set(value As Integer)
				Me.o.__O0O..Height = value
			End Set
		End Property

		' Token: 0x17000659 RID: 1625
		' (get) Token: 0x06001C9A RID: 7322 RVA: 0x000B66D4 File Offset: 0x000B48D4
		' (set) Token: 0x06001C9B RID: 7323 RVA: 0x000B66E1 File Offset: 0x000B48E1
		<oO0oooo("0701")>
		Public Property Anchor As AnchorStyles
			Get
				Return Me.o.__O0O..Anchor
			End Get
			Set(value As AnchorStyles)
				Me.o.__O0O..Anchor = value
			End Set
		End Property

		' Token: 0x1700065A RID: 1626
		' (get) Token: 0x06001C9C RID: 7324 RVA: 0x000B66EF File Offset: 0x000B48EF
		' (set) Token: 0x06001C9D RID: 7325 RVA: 0x000B66FC File Offset: 0x000B48FC
		<oO0oooo("0702")>
		Public Property Dock As DockStyle
			Get
				Return Me.o.__O0O..Dock
			End Get
			Set(value As DockStyle)
				Me.o.__O0O..Dock = value
			End Set
		End Property

		' Token: 0x1700065B RID: 1627
		' (get) Token: 0x06001C9E RID: 7326 RVA: 0x000B670C File Offset: 0x000B490C
		' (set) Token: 0x06001C9F RID: 7327 RVA: 0x000B6748 File Offset: 0x000B4948
		<oO0oooo("0720")>
		Public Overridable Property BackColor As Color
			Get
				Dim result As Color
				If TypeOf Me.o.__O0O. Is WebViewer Then
					result = CType(Me.o.__O0O., WebViewer).DefaultBackgroundColor
				Else
					result = Me.o.__O0O..BackColor
				End If
				Return result
			End Get
			Set(value As Color)
				If TypeOf Me.o.__O0O. Is C1TextBox Then
					CType(Me.o.__O0O., C1TextBox).BackColor = value
					Return
				End If
				If TypeOf Me.o.__O0O. Is WebViewer Then
					CType(Me.o.__O0O., WebViewer).DefaultBackgroundColor = value
					Return
				End If
				Me.o.__O0O..BackColor = value
			End Set
		End Property

		' Token: 0x1700065C RID: 1628
		' (get) Token: 0x06001CA0 RID: 7328 RVA: 0x000B679F File Offset: 0x000B499F
		' (set) Token: 0x06001CA1 RID: 7329 RVA: 0x000B67AC File Offset: 0x000B49AC
		<oO0oooo("0721")>
		Public Overridable Property ForeColor As Color
			Get
				Return Me.o.__O0O..ForeColor
			End Get
			Set(value As Color)
				Me.o.__O0O..ForeColor = value
			End Set
		End Property

		' Token: 0x1700065D RID: 1629
		' (get) Token: 0x06001CA2 RID: 7330 RVA: 0x000B67BA File Offset: 0x000B49BA
		' (set) Token: 0x06001CA3 RID: 7331 RVA: 0x000B67C8 File Offset: 0x000B49C8
		<oO0oooo("0722")>
		Public Property Font As Font
			Get
				Return Me.o.__O0O..Font
			End Get
			Set(value As Font)
				Me.o.__O0O..Font = CType(value.Clone(), Font)
				If TypeOf Me.o.__O0O. Is C1TopicBar Then
					Dim c1TopicBar As C1TopicBar = CType(Me.o.__O0O., C1TopicBar)
					c1TopicBar.PageStyle.NormalPage.NormalCaption.Font = value
					c1TopicBar.PageStyle.NormalPage.MouseOverCaption.Font = value
					c1TopicBar.PageStyle.NormalPage.PressedCaption.Font = value
				End If
			End Set
		End Property

		' Token: 0x1700065E RID: 1630
		' (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000B6846 File Offset: 0x000B4A46
		' (set) Token: 0x06001CA5 RID: 7333 RVA: 0x000B6853 File Offset: 0x000B4A53
		Public Property TabIndex As Integer
			Get
				Return Me.o.__O0O..TabIndex
			End Get
			Set(value As Integer)
				Me.o.__O0O..TabIndex = value
			End Set
		End Property

		' Token: 0x1700065F RID: 1631
		' (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000B6861 File Offset: 0x000B4A61
		' (set) Token: 0x06001CA7 RID: 7335 RVA: 0x000B6871 File Offset: 0x000B4A71
		Public Property TabStop As Boolean
			Get
				Return Not Me.o.__O0O..TabStop
			End Get
			Set(value As Boolean)
				Me.o.__O0O..TabStop = Not value
			End Set
		End Property

		' Token: 0x17000660 RID: 1632
		' (get) Token: 0x06001CA8 RID: 7336 RVA: 0x000B6882 File Offset: 0x000B4A82
		' (set) Token: 0x06001CA9 RID: 7337 RVA: 0x000B688F File Offset: 0x000B4A8F
		<oO0oooo("2480")>
		Public Property CausesValidation As Boolean
			Get
				Return Me.o.__O0O..CausesValidation
			End Get
			Set(value As Boolean)
				Me.o.__O0O..CausesValidation = value
			End Set
		End Property

		' Token: 0x17000661 RID: 1633
		' (get) Token: 0x06001CAA RID: 7338 RVA: 0x000B689D File Offset: 0x000B4A9D
		' (set) Token: 0x06001CAB RID: 7339 RVA: 0x000B68A0 File Offset: 0x000B4AA0
		<oO0oooo("0723")>
		Public Property TopMost As Boolean
			Get
				Return False
			End Get
			Set(value As Boolean)
				If value Then
					Me.BackMost = False
					Me.o.__O0O..BringToFront()
				End If
			End Set
		End Property

		' Token: 0x17000662 RID: 1634
		' (get) Token: 0x06001CAC RID: 7340 RVA: 0x000B68B7 File Offset: 0x000B4AB7
		' (set) Token: 0x06001CAD RID: 7341 RVA: 0x000B68BA File Offset: 0x000B4ABA
		<oO0oooo("0724")>
		Public Property BackMost As Boolean
			Get
				Return False
			End Get
			Set(value As Boolean)
				If value Then
					Me.TopMost = False
					Me.o.__O0O..SendToBack()
				End If
			End Set
		End Property

		' Token: 0x17000663 RID: 1635
		' (get) Token: 0x06001CAE RID: 7342 RVA: 0x000B68D4 File Offset: 0x000B4AD4
		' (set) Token: 0x06001CAF RID: 7343 RVA: 0x000B6911 File Offset: 0x000B4B11
		<oO0oooo("1604")>
		Public Property Printable As Boolean
			Get
				Dim printable As Boolean
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					printable = Me.o.__O0O..PrintSettings.GetPrintable(Me.o.__O0O.)
				End If
				Return printable
			End Get
			Set(value As Boolean)
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					Me.o.__O0O..PrintSettings.SetPrintable(Me.o.__O0O., value)
				End If
			End Set
		End Property

		' Token: 0x17000664 RID: 1636
		' (get) Token: 0x06001CB0 RID: 7344 RVA: 0x000B6944 File Offset: 0x000B4B44
		' (set) Token: 0x06001CB1 RID: 7345 RVA: 0x000B6981 File Offset: 0x000B4B81
		<oO0oooo("1604")>
		Public Property NewPage As Boolean
			Get
				Dim newPage As Boolean
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					newPage = Me.o.__O0O..PrintSettings.GetNewPage(Me.o.__O0O.)
				End If
				Return newPage
			End Get
			Set(value As Boolean)
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					Me.o.__O0O..PrintSettings.SetNewPage(Me.o.__O0O., value)
				End If
			End Set
		End Property

		' Token: 0x17000665 RID: 1637
		' (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000B69B4 File Offset: 0x000B4BB4
		' (set) Token: 0x06001CB3 RID: 7347 RVA: 0x000B69F1 File Offset: 0x000B4BF1
		<oO0oooo("3102")>
		Public Property PrintBorder As Boolean
			Get
				Dim result As Boolean
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					result = Me.o.__O0O..PrintSettings.O0O.o____o00.(Me.o.__O0O.)
				End If
				Return result
			End Get
			Set(value As Boolean)
				If Me.o.__O0O..PrintSettings.CanExtend(Me.o.__O0O.) Then
					Me.o.__O0O..PrintSettings.O0O.o____o00.(Me.o.__O0O., value)
				End If
			End Set
		End Property

		' Token: 0x06001CB4 RID: 7348 RVA: 0x000B6A22 File Offset: 0x000B4C22
		Public Sub Refresh()
			Me.o.__O0O..Refresh()
		End Sub

		' Token: 0x17000666 RID: 1638
		' (get) Token: 0x06001CB5 RID: 7349 RVA: 0x000B6A2F File Offset: 0x000B4C2F
		' (set) Token: 0x06001CB6 RID: 7350 RVA: 0x000B6A3C File Offset: 0x000B4C3C
		Public Property Location As Point
			Get
				Return Me.o.__O0O..Location
			End Get
			Set(value As Point)
				Me.o.__O0O..Location = value
			End Set
		End Property

		' Token: 0x17000667 RID: 1639
		' (get) Token: 0x06001CB7 RID: 7351 RVA: 0x000B6A4A File Offset: 0x000B4C4A
		' (set) Token: 0x06001CB8 RID: 7352 RVA: 0x000B6A57 File Offset: 0x000B4C57
		Public Property Size As Size
			Get
				Return Me.o.__O0O..Size
			End Get
			Set(value As Size)
				Me.o.__O0O..Size = value
			End Set
		End Property

		' Token: 0x17000668 RID: 1640
		' (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000B6A65 File Offset: 0x000B4C65
		Public ReadOnly Property Focused As Boolean
			Get
				Return Me.o.__O0O..Focused
			End Get
		End Property

		' Token: 0x17000669 RID: 1641
		' (get) Token: 0x06001CBA RID: 7354 RVA: 0x000B6A72 File Offset: 0x000B4C72
		' (set) Token: 0x06001CBB RID: 7355 RVA: 0x000B6A7F File Offset: 0x000B4C7F
		Public Property Cursor As Cursor
			Get
				Return Me.o.__O0O..Cursor
			End Get
			Set(value As Cursor)
				If Not(TypeOf Me.o.__O0O. Is WebBrowser) Then
					Me.o.__O0O..Cursor = value
				End If
			End Set
		End Property

		' Token: 0x1700066A RID: 1642
		' (get) Token: 0x06001CBC RID: 7356 RVA: 0x000B6A9A File Offset: 0x000B4C9A
		' (set) Token: 0x06001CBD RID: 7357 RVA: 0x000B6AA7 File Offset: 0x000B4CA7
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property CursorType As CursorEnum
			Get
				Return ooO.OO_oOO0O.O00.(Me.Cursor)
			End Get
			Set(value As CursorEnum)
				Me.Cursor = ooO.OO_oOO0O.O00.(value)
			End Set
		End Property

		' Token: 0x1700066B RID: 1643
		' (get) Token: 0x06001CBE RID: 7358 RVA: 0x000B6AB8 File Offset: 0x000B4CB8
		' (set) Token: 0x06001CBF RID: 7359 RVA: 0x000B6AF8 File Offset: 0x000B4CF8
		<oO0oooo("1282")>
		Public Property ToolTip As String
			Get
				Dim toolTip As String
				If Me.o.__O0O..FindForm() IsNot Nothing Then
					toolTip = Me.Form.Pane.ToolTip1.GetToolTip(Me.o.__O0O.)
				Else
					toolTip = Me.o.__O0O.
				End If
				Return toolTip
			End Get
			Set(value As String)
				Me.o.__O0O. = value
				If Me.o.__O0O..FindForm() IsNot Nothing Then
					Me.Form.Pane.ToolTip1.SetToolTip(Me.o.__O0O., value)
				End If
			End Set
		End Property

		' Token: 0x1700066C RID: 1644
		' (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000B6B2C File Offset: 0x000B4D2C
		' (set) Token: 0x06001CC1 RID: 7361 RVA: 0x000B6B6C File Offset: 0x000B4D6C
		<oO0oooo("2676")>
		Public Property [Error] As String
			Get
				Dim [error] As String
				If Me.o.__O0O..FindForm() IsNot Nothing Then
					[error] = Me.Form.Pane.ErrorProvider1.GetError(Me.o.__O0O.)
				Else
					[error] = Me.o.__O0O.
				End If
				Return [error]
			End Get
			Set(value As String)
				Me.o.__O0O. = value
				If Me.o.__O0O..FindForm() IsNot Nothing Then
					Me.Form.Pane.ErrorProvider1.SetError(Me.o.__O0O., value)
				End If
			End Set
		End Property

		' Token: 0x06001CC2 RID: 7362 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
		<oO0oooo("2686")>
		Public Sub ShowToolTip(info As String, Optional duration As Integer = -1)
			If duration <= 0 Then
				Me.Form.Pane.ToolTip1.Show(info, Me.BaseControl, Me.BaseControl.ClientSize.Width, Me.BaseControl.ClientSize.Height)
				Return
			End If
			Me.Form.Pane.ToolTip1.Show(info, Me.BaseControl, duration)
		End Sub

		' Token: 0x06001CC3 RID: 7363 RVA: 0x000B6C14 File Offset: 0x000B4E14
		Public Sub ShowToolTip(info As String, X As Integer, Y As Integer, Optional duration As Integer = -1)
			If duration <= 0 Then
				Me.Form.Pane.ToolTip1.Show(info, Me.BaseControl, X, Y)
				Return
			End If
			Me.Form.Pane.ToolTip1.Show(info, Me.BaseControl, X, Y, duration)
		End Sub

		' Token: 0x06001CC4 RID: 7364 RVA: 0x000B6C65 File Offset: 0x000B4E65
		Public Sub ShowToolTip(info As String, location As Point, Optional duration As Integer = -1)
			Me.ShowToolTip(info, location.X, location.Y, duration)
		End Sub

		' Token: 0x06001CC5 RID: 7365 RVA: 0x000B6C7D File Offset: 0x000B4E7D
		<oO0oooo("2688")>
		Public Sub HideToolTip()
			Me.Form.Pane.ToolTip1.Hide(Me.BaseControl)
		End Sub

		' Token: 0x1700066D RID: 1645
		' (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000B6C9A File Offset: 0x000B4E9A
		Friend ReadOnly Property ToolTipText As String
			Get
				Return Me.o.__O0O.
			End Get
		End Property

		' Token: 0x06001CC7 RID: 7367 RVA: 0x000B6CA4 File Offset: 0x000B4EA4
		<oO0oooo("0729")>
		Public Sub [Select]()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.o.__O0O..[Select]()
				IL_14:
				num2 = 3
				If Not Me.o.__O0O..CanFocus Then
					GoTo IL_31
				End If
				IL_23:
				num2 = 4
				Me.o.__O0O..Focus()
				IL_31:
				GoTo IL_94
				IL_33:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_55:
				GoTo IL_89
				IL_57:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_67:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_57
			End Try
			IL_89:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_94:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001CC8 RID: 7368 RVA: 0x000B6D60 File Offset: 0x000B4F60
		<oO0oooo("0731")>
		Public Sub WriteValue()
			If Me.o.__O0O..DataBindings.Count > 0 AndAlso Me.o.__O0O..DataBindings(0).BindingManagerBase.Count > 0 Then
				Dim dataRowView As DataRowView = CType(Me.o.__O0O..DataBindings(0).BindingManagerBase.Current, DataRowView)
				If TypeOf Me.o.__O0O. Is C1TextBox Then
					Dim text As String = dataRowView(Me.o.__O0O..DataBindings(0).BindingMemberInfo.BindingField).ToString()
					Dim c1TextBox As C1TextBox = CType(Me.o.__O0O., C1TextBox)
					If Not c1TextBox.UpdateValueWithCurrentText() Then
						Return
					End If
					If c1TextBox.Value Is Nothing Then
						If Operators.CompareString(text, "", True) = 0 Then
							Return
						End If
					ElseIf Operators.CompareString(c1TextBox.Value.ToString(), text, True) = 0 Then
						Return
					End If
				End If
				Me.o.__O0O..DataBindings(0).WriteValue()
				dataRowView.EndEdit()
			End If
		End Sub

		' Token: 0x06001CC9 RID: 7369 RVA: 0x000B6E59 File Offset: 0x000B5059
		<oO0oooo("0730")>
		Public Sub ReadValue()
			If Me.o.__O0O..DataBindings.Count > 0 Then
				Me.o.__O0O..DataBindings(0).ReadValue()
			End If
		End Sub

		' Token: 0x1700066E RID: 1646
		' (get) Token: 0x06001CCA RID: 7370 RVA: 0x000B6E84 File Offset: 0x000B5084
		<oO0oooo("1523")>
		Public ReadOnly Property BindTable As Table
			Get
				If Me.o.__O0O..DataBindings.Count > 0 Then
					Dim binding As Binding = Me.o.__O0O..DataBindings(0)
					If Not(TypeOf Me.o.__O0O..DataBindings(0).DataSource Is O_0) Then
						Return Nothing
					End If
					Dim text As String = CType(Me.o.__O0O..DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
					If OO_00oOO.Tables.get_Contains(text) Then
						Return OO_00oOO.Tables(text)
					End If
				End If
				Return Nothing
			End Get
		End Property

		' Token: 0x1700066F RID: 1647
		' (get) Token: 0x06001CCB RID: 7371 RVA: 0x000B6F18 File Offset: 0x000B5118
		Public ReadOnly Property BindRow As Row
			Get
				If Me.o.__O0O..DataBindings.Count > 0 Then
					If Not(TypeOf Me.o.__O0O..DataBindings(0).DataSource Is O_0) Then
						Return Nothing
					End If
					Dim text As String = CType(Me.o.__O0O..DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
					If OO_00oOO.Tables.get_Contains(text) Then
						Return OO_00oOO.Tables(text).Current
					End If
				End If
				Return Nothing
			End Get
		End Property

		' Token: 0x17000670 RID: 1648
		' (get) Token: 0x06001CCC RID: 7372 RVA: 0x000B6FA0 File Offset: 0x000B51A0
		Public ReadOnly Property BindCol As Col
			Get
				If Me.o.__O0O..DataBindings.Count > 0 Then
					Dim bindingMemberInfo As BindingMemberInfo = Me.o.__O0O..DataBindings(0).BindingMemberInfo
					If Not(TypeOf Me.o.__O0O..DataBindings(0).DataSource Is O_0) Then
						Return Nothing
					End If
					Dim text As String = CType(Me.o.__O0O..DataBindings(0).DataSource, O_0).Oo._Oo0OO.()
					If OO_00oOO.Tables.get_Contains(text) AndAlso OO_00oOO.Tables(text).Cols.Contains(bindingMemberInfo.BindingField) Then
						Return OO_00oOO.Tables(text).Cols(bindingMemberInfo.BindingField)
					End If
					bindingMemberInfo = Nothing
				End If
				Return Nothing
			End Get
		End Property

		' Token: 0x06001CCD RID: 7373 RVA: 0x000B7071 File Offset: 0x000B5271
		<oO0oooo("0823")>
		Public Sub SetBounds(x As Integer, y As Integer, Width As Integer, Height As Integer)
			Me.o.__O0O..SetBounds(x, y, Width, Height)
		End Sub

		' Token: 0x17000671 RID: 1649
		' (get) Token: 0x06001CCE RID: 7374 RVA: 0x000B7084 File Offset: 0x000B5284
		' (set) Token: 0x06001CCF RID: 7375 RVA: 0x000B70B4 File Offset: 0x000B52B4
		<oO0oooo("1863")>
		Public Property ImeMode As BooleanEnum
			Get
				Dim imeMode As ImeMode = Me.o.__O0O..ImeMode
				Dim result As BooleanEnum
				If imeMode <> System.Windows.Forms.ImeMode.[On] Then
					If imeMode <> System.Windows.Forms.ImeMode.Close Then
						result = 0
					Else
						result = 2
					End If
				Else
					result = 1
				End If
				Return result
			End Get
			Set(value As BooleanEnum)
				Select Case value
					Case 0
						Me.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.NoControl
						Return
					Case 1
						Me.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.[On]
						Return
					Case 2
						Me.o.__O0O..ImeMode = System.Windows.Forms.ImeMode.Close
						Return
					Case Else
						Return
				End Select
			End Set
		End Property

		' Token: 0x17000672 RID: 1650
		' (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000B7100 File Offset: 0x000B5300
		Public ReadOnly Property Form As Form
			Get
				Dim result As Form
				If Me.o.__O0O. IsNot Nothing Then
					result = Me.o.__O0O.
				Else
					Dim parent As Control = Me.o.__O0O.
					While True
						parent = parent.Parent
						If TypeOf parent Is FormPanel Then
							Exit For
						End If
						If parent Is Nothing Then
							GoTo Block_4
						End If
					End While
					If OO_00oOO.Forms.Contains(parent.Name) Then
						Return OO_00oOO.Forms(parent.Name)
					End If
					Return Nothing
					Block_4:
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000673 RID: 1651
		' (get) Token: 0x06001CD1 RID: 7377 RVA: 0x000B7164 File Offset: 0x000B5364
		Public ReadOnly Property Parent As Object
			Get
				Dim result As Object
				If TypeOf Me.o.__O0O..Parent Is TabPage OrElse TypeOf Me.o.__O0O..Parent Is NavPage Then
					result = Me.o.__O0O..Parent
				ElseIf TypeOf Me.o.__O0O..Parent Is SplitterPanel Then
					result = New SplitPanel(CType(Me.o.__O0O..Parent, SplitterPanel))
				ElseIf TypeOf Me.o.__O0O..Parent Is FormPanel Then
					result = Me.Form
				ElseIf Me.o.__O0O..Parent.Parent IsNot Nothing AndAlso TypeOf Me.o.__O0O..Parent.Parent Is CustomPictureBox Then
					result = New PictureBox(CType(Me.o.__O0O..Parent.Parent, CustomPictureBox))
				ElseIf TypeOf Me.o.__O0O..Parent Is GroupBox OrElse TypeOf Me.o.__O0O..Parent Is Panel OrElse TypeOf Me.o.__O0O..Parent Is C1Gauge Then
					result = ooO_0O.o_O0.O_.(Me.o.__O0O..Parent)
				Else
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x17000674 RID: 1652
		' (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000B7284 File Offset: 0x000B5484
		' (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000B72BA File Offset: 0x000B54BA
		<oO0oooo("3116")>
		Public Property ContextStrip As Strip
			Get
				Dim result As Strip
				If Me.o.__O0O..ContextMenuStrip IsNot Nothing Then
					result = New Strip(Me.o.__O0O..ContextMenuStrip, Me.o.__O0O.)
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As Strip)
				If value Is Nothing Then
					Me.o.__O0O..ContextMenuStrip = Nothing
					Return
				End If
				If TypeOf value.BaseControl Is ContextMenuStrip Then
					Me.o.__O0O..ContextMenuStrip = CType(value.BaseControl, ContextMenuStrip)
				End If
			End Set
		End Property

		' Token: 0x06001CD4 RID: 7380 RVA: 0x000B72EF File Offset: 0x000B54EF
		<oO0oooo("3116")>
		Public Sub ShowContextStrip(x As Integer, y As Integer, Strip As Strip)
			If TypeOf Strip.BaseControl Is ContextMenuStrip Then
				CType(Strip.BaseControl, ContextMenuStrip).Show(Me.BaseControl, x, y)
			End If
		End Sub

		' Token: 0x17000675 RID: 1653
		' (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000B7318 File Offset: 0x000B5518
		Public ReadOnly Property MousePosition As Point
			Get
				Return Me.o.__O0O.
			End Get
		End Property

		' Token: 0x17000676 RID: 1654
		' (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000B7320 File Offset: 0x000B5520
		' (set) Token: 0x06001CD7 RID: 7383 RVA: 0x000B7350 File Offset: 0x000B5550
		<oO0oooo("3305")>
		Public Property Theme As String
			Get
				Dim result As String
				If C1ThemeController.IsObjectThemeable(Me.BaseControl) Then
					result = Main.OO_O.o..o0_o_o_0.0O.(Me.BaseControl)
				Else
					result = Nothing
				End If
				Return result
			End Get
			Set(value As String)
				If C1ThemeController.IsObjectThemeable(Me.BaseControl) Then
					If TypeOf Me.BaseControl Is SplitContainer Then
						Dim splitContainer As SplitContainer = CType(Me.BaseControl, SplitContainer)
						Dim flag As Boolean = splitContainer.BackColor = splitContainer.Panel1.BackColor
						Dim flag2 As Boolean = splitContainer.BackColor = splitContainer.Panel2.BackColor
						Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.BaseControl })
						If flag Then
							splitContainer.Panel1.BackColor = splitContainer.BackColor
						End If
						If flag2 Then
							splitContainer.Panel2.BackColor = splitContainer.BackColor
							Return
						End If
					Else
						Main.OO_O.o..Oo.oOo_o0Oo0.(value, New Object() { Me.BaseControl })
						If TypeOf Me.BaseControl Is C1DockingTab Then
							CType(Me.BaseControl, C1DockingTab).TabSizeMode = 1
						End If
						If TypeOf Me.BaseControl Is C1Button Then
							Dim c1Button As C1Button = CType(Me.BaseControl, C1Button)
							If Operators.CompareString(value, "(none)", True) = 0 Then
								If c1Button.FlatStyle <> FlatStyle.Flat Then
									c1Button.FlatStyle = FlatStyle.Flat
									Return
								End If
							ElseIf c1Button.FlatStyle <> FlatStyle.Standard Then
								c1Button.FlatStyle = FlatStyle.Standard
							End If
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x04000C1D RID: 3101
		Private <<EMPTY_NAME>> As Control

		' Token: 0x04000C1E RID: 3102
		Friend <<EMPTY_NAME>> As ControlTypeEnum

		' Token: 0x04000C1F RID: 3103
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000C20 RID: 3104
		Friend <<EMPTY_NAME>> As Form

		' Token: 0x04000C21 RID: 3105
		Private <<EMPTY_NAME>> As Point
	End Class
End Namespace
