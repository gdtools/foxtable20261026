Imports System
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003C5 RID: 965
	Friend Class O0oo000oO0oo_
		Inherits C1DropDownControl
		Implements O000O

		' Token: 0x06003D9B RID: 15771 RVA: 0x001ACC25 File Offset: 0x001AAE25
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As CustomCheckedListBox
			Return Me.OO.Oo0oOO.
		End Function

		' Token: 0x06003D9C RID: 15772 RVA: 0x001ACC30 File Offset: 0x001AAE30
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As CustomCheckedListBox)
			Dim value As ItemCheckEventHandler = AddressOf Me.OoO__O.__oo_o.
			Dim value2 As EventHandler = AddressOf Me.OoO__O.__oo_o.
			Dim value3 As ListControlConvertEventHandler = AddressOf Me.OoO__O.__oo_o.
			Dim oo.Oo0oOO. As CustomCheckedListBox = Me.OO.Oo0oOO.
			If oo.Oo0oOO. IsNot Nothing Then
				RemoveHandler oo.Oo0oOO..ItemCheck, value
				RemoveHandler oo.Oo0oOO..SelectedIndexChanged, value2
				RemoveHandler oo.Oo0oOO..Format, value3
			End If
			Me.OO.Oo0oOO. = A_0
			oo.Oo0oOO. = Me.OO.Oo0oOO.
			If oo.Oo0oOO. IsNot Nothing Then
				AddHandler oo.Oo0oOO..ItemCheck, value
				AddHandler oo.Oo0oOO..SelectedIndexChanged, value2
				AddHandler oo.Oo0oOO..Format, value3
			End If
		End Sub

		' Token: 0x06003D9D RID: 15773 RVA: 0x001ACCAC File Offset: 0x001AAEAC
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.o_o00)
			Dim o_o As O0oo000oO0oo_.o_o00 = Me.OO.Oo0oOO.
			Dim o_o2 As O0oo000oO0oo_.o_o00
			Do
				o_o2 = o_o
				Dim value As O0oo000oO0oo_.o_o00 = CType([Delegate].Combine(o_o2, A_0), O0oo000oO0oo_.o_o00)
				o_o = Interlocked.CompareExchange(Of O0oo000oO0oo_.o_o00)(Me.OO.Oo0oOO., value, o_o2)
			Loop While o_o IsNot o_o2
		End Sub

		' Token: 0x06003D9E RID: 15774 RVA: 0x001ACCE4 File Offset: 0x001AAEE4
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.o_o00)
			Dim o_o As O0oo000oO0oo_.o_o00 = Me.OO.Oo0oOO.
			Dim o_o2 As O0oo000oO0oo_.o_o00
			Do
				o_o2 = o_o
				Dim value As O0oo000oO0oo_.o_o00 = CType([Delegate].Remove(o_o2, A_0), O0oo000oO0oo_.o_o00)
				o_o = Interlocked.CompareExchange(Of O0oo000oO0oo_.o_o00)(Me.OO.Oo0oOO., value, o_o2)
			Loop While o_o IsNot o_o2
		End Sub

		' Token: 0x06003D9F RID: 15775 RVA: 0x001ACD1C File Offset: 0x001AAF1C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.o0_00__ooOo)
			Dim o0_00__ooOo As O0oo000oO0oo_.o0_00__ooOo = Me.OO_o_.o__.
			Dim o0_00__ooOo2 As O0oo000oO0oo_.o0_00__ooOo
			Do
				o0_00__ooOo2 = o0_00__ooOo
				Dim value As O0oo000oO0oo_.o0_00__ooOo = CType([Delegate].Combine(o0_00__ooOo2, A_0), O0oo000oO0oo_.o0_00__ooOo)
				o0_00__ooOo = Interlocked.CompareExchange(Of O0oo000oO0oo_.o0_00__ooOo)(Me.OO_o_.o__., value, o0_00__ooOo2)
			Loop While o0_00__ooOo IsNot o0_00__ooOo2
		End Sub

		' Token: 0x06003DA0 RID: 15776 RVA: 0x001ACD54 File Offset: 0x001AAF54
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.o0_00__ooOo)
			Dim o0_00__ooOo As O0oo000oO0oo_.o0_00__ooOo = Me.OO_o_.o__.
			Dim o0_00__ooOo2 As O0oo000oO0oo_.o0_00__ooOo
			Do
				o0_00__ooOo2 = o0_00__ooOo
				Dim value As O0oo000oO0oo_.o0_00__ooOo = CType([Delegate].Remove(o0_00__ooOo2, A_0), O0oo000oO0oo_.o0_00__ooOo)
				o0_00__ooOo = Interlocked.CompareExchange(Of O0oo000oO0oo_.o0_00__ooOo)(Me.OO_o_.o__., value, o0_00__ooOo2)
			Loop While o0_00__ooOo IsNot o0_00__ooOo2
		End Sub

		' Token: 0x06003DA1 RID: 15777 RVA: 0x001ACD8C File Offset: 0x001AAF8C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.oO0__)
			Dim oO0__ As O0oo000oO0oo_.oO0__ = Me.OO.Oo0oOO.
			Dim oO0__2 As O0oo000oO0oo_.oO0__
			Do
				oO0__2 = oO0__
				Dim value As O0oo000oO0oo_.oO0__ = CType([Delegate].Combine(oO0__2, A_0), O0oo000oO0oo_.oO0__)
				oO0__ = Interlocked.CompareExchange(Of O0oo000oO0oo_.oO0__)(Me.OO.Oo0oOO., value, oO0__2)
			Loop While oO0__ IsNot oO0__2
		End Sub

		' Token: 0x06003DA2 RID: 15778 RVA: 0x001ACDC4 File Offset: 0x001AAFC4
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As O0oo000oO0oo_.oO0__)
			Dim oO0__ As O0oo000oO0oo_.oO0__ = Me.OO.Oo0oOO.
			Dim oO0__2 As O0oo000oO0oo_.oO0__
			Do
				oO0__2 = oO0__
				Dim value As O0oo000oO0oo_.oO0__ = CType([Delegate].Remove(oO0__2, A_0), O0oo000oO0oo_.oO0__)
				oO0__ = Interlocked.CompareExchange(Of O0oo000oO0oo_.oO0__)(Me.OO.Oo0oOO., value, oO0__2)
			Loop While oO0__ IsNot oO0__2
		End Sub

		' Token: 0x06003DA3 RID: 15779 RVA: 0x001ACDFC File Offset: 0x001AAFFC
		Friend Sub New()
			MyBase.DropDownOpened += AddressOf Me.o0oOo_0_o_.0_O.
			AddHandler MyBase.Enter, AddressOf Me.o__0._O.
			AddHandler MyBase.FontChanged, AddressOf Me.ooO.oo_.
			AddHandler MyBase.GotFocus, AddressOf Me.O0Oo.oOOoOoO__.
			AddHandler MyBase.KeyDown, AddressOf Me.OoO__O.__oo_o.
			AddHandler MyBase.KeyPress, AddressOf Me.O0O.o.
			Me.OO.Oo0oOO. = 0
			Me.OO.Oo0oOO. = ","c
			Me.o0OO.O. = True
			Me.o_O_.0O. = 11
			Me.ShowUpDownButtons = False
			Me.DataType = GetType(String)
			Me.OO.Oo0oOO. = New O\u3002\u3000()
			Me.o0OO0._0.(Me.OO.Oo0oOO..O__0o.o0_.())
			Me.DropDownForm = Me.OO.Oo0oOO.
			Me.OO.Oo0oOO..O__0o.o0_.().Font = Me.Font
			MyBase.VisualStyle = 0
			Main.OO_O.o..o.O000oo.(New Object() { Me })
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.AutoTabWhenFilled = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			MyBase.AutoSize = False
			MyBase.VerticalAlign = 1
			MyBase.Padding = New Padding(1, 2, 1, 1)
			Me.DateTimeInput = False
			Me.NumericInput = False
			MyBase.ExitOnLeftRightKey = 3
			MyBase.ExitOnLastChar = True
		End Sub

		' Token: 0x06003DA4 RID: 15780 RVA: 0x001ACF79 File Offset: 0x001AB179
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If A_0.Msg <> 770 OrElse Me.OOo0_o.O00__.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x06003DA5 RID: 15781 RVA: 0x001ACF97 File Offset: 0x001AB197
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.OO.Oo0oOO.
		End Function

		' Token: 0x06003DA6 RID: 15782 RVA: 0x001ACF9F File Offset: 0x001AB19F
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.OO.Oo0oOO. = A_0
			ooO_0O.o_O0.O_.(Me, Me.o_0Oo.o_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003DA7 RID: 15783 RVA: 0x001ACFC0 File Offset: 0x001AB1C0
		Public Function <<EMPTY_NAME>>() As Char
			Return Me.OO.Oo0oOO.
		End Function

		' Token: 0x06003DA8 RID: 15784 RVA: 0x001ACFC8 File Offset: 0x001AB1C8
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Char)
			Me.OO.Oo0oOO. = A_0
			Me.OO.Oo0oOO..O__0o.o0_.().Separator = Conversions.ToString(A_0)
		End Sub

		' Token: 0x06003DA9 RID: 15785 RVA: 0x001ACFE7 File Offset: 0x001AB1E7
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.o0OO.O.
		End Function

		' Token: 0x06003DAA RID: 15786 RVA: 0x001ACFEF File Offset: 0x001AB1EF
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o0OO.O. = A_0
		End Sub

		' Token: 0x06003DAB RID: 15787 RVA: 0x001ACFF8 File Offset: 0x001AB1F8
		Public Function <<EMPTY_NAME>>() As CheckedListBox.ObjectCollection
			Return Me.O0O.o.().Items
		End Function

		' Token: 0x06003DAC RID: 15788 RVA: 0x001AD005 File Offset: 0x001AB205
		Public Function <<EMPTY_NAME>>() As CheckedListBox.CheckedItemCollection
			Return Me.O0O.o.().CheckedItems
		End Function

		' Token: 0x06003DAD RID: 15789 RVA: 0x001AD012 File Offset: 0x001AB212
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O0O.o.().DisplayMember
		End Function

		' Token: 0x06003DAE RID: 15790 RVA: 0x001AD01F File Offset: 0x001AB21F
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0O.o.().DisplayMember = A_0
		End Sub

		' Token: 0x06003DAF RID: 15791 RVA: 0x001AD02D File Offset: 0x001AB22D
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O0O.o.().ValueMember
		End Function

		' Token: 0x06003DB0 RID: 15792 RVA: 0x001AD03A File Offset: 0x001AB23A
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O0O.o.().ValueMember = A_0
		End Sub

		' Token: 0x06003DB1 RID: 15793 RVA: 0x001AD048 File Offset: 0x001AB248
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.O0O.o.().DataSource
		End Function

		' Token: 0x06003DB2 RID: 15794 RVA: 0x001AD058 File Offset: 0x001AB258
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim a_ As String = Me.O0O.o.()
			Me.O0O.o.().DataSource = RuntimeHelpers.GetObjectValue(A_0)
			Me.OoO.0oo_Oo_.(a_)
		End Sub

		' Token: 0x06003DB3 RID: 15795 RVA: 0x001AD084 File Offset: 0x001AB284
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O0O.o.().MultiColumn
		End Function

		' Token: 0x06003DB4 RID: 15796 RVA: 0x001AD091 File Offset: 0x001AB291
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O0O.o.().MultiColumn = A_0
		End Sub

		' Token: 0x06003DB5 RID: 15797 RVA: 0x001AD09F File Offset: 0x001AB29F
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O0O.o.().ColumnWidth
		End Function

		' Token: 0x06003DB6 RID: 15798 RVA: 0x001AD0AC File Offset: 0x001AB2AC
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O0O.o.().ColumnWidth = A_0
		End Sub

		' Token: 0x06003DB7 RID: 15799 RVA: 0x001AD0BA File Offset: 0x001AB2BA
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.OO.Oo0oOO.
		End Function

		' Token: 0x06003DB8 RID: 15800 RVA: 0x001AD0C2 File Offset: 0x001AB2C2
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OO.Oo0oOO. = A_0
		End Sub

		' Token: 0x06003DB9 RID: 15801 RVA: 0x001AD0CB File Offset: 0x001AB2CB
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O.o0O.
		End Function

		' Token: 0x06003DBA RID: 15802 RVA: 0x001AD0D3 File Offset: 0x001AB2D3
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O.o0O. = A_0
		End Sub

		' Token: 0x06003DBB RID: 15803 RVA: 0x001AD0DC File Offset: 0x001AB2DC
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.o_O_.0O.
		End Function

		' Token: 0x06003DBC RID: 15804 RVA: 0x001AD0E4 File Offset: 0x001AB2E4
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.o_O_.0O. = A_0
		End Sub

		' Token: 0x06003DBD RID: 15805 RVA: 0x001AD0ED File Offset: 0x001AB2ED
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O0O.o.().CheckOnClick
		End Function

		' Token: 0x06003DBE RID: 15806 RVA: 0x001AD0FA File Offset: 0x001AB2FA
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O0O.o.().CheckOnClick = A_0
		End Sub

		' Token: 0x06003DBF RID: 15807 RVA: 0x001AD108 File Offset: 0x001AB308
		Friend Sub <<EMPTY_NAME>>()
			If Me.o__0o0o_.OO0O_.() = 0 Then
				Me.OO.Oo0oOO..Width = Math.Max(168, MyBase.Width)
			Else
				Me.OO.Oo0oOO..Width = Math.Max(131, Me.o__0o0o_.OO0O_.())
			End If
			If Not Me.oOO0_o._0O00.() Then
				Dim num As Integer = Math.Min(Me.O_oOo.o0Oo.(), Math.Max(1, Me.O0O.o.().Items.Count))
				Me.OO.Oo0oOO..O__0o.o0_.().Height = Me.OO.Oo0oOO..O__0o.o0_.().ItemHeight * num + 4
				Me.OO.Oo0oOO..Height = Me.OO.Oo0oOO..O__0o.o0_.().Height + 32
				Return
			End If
			If Me.O0O.o.() > 0 Then
				Dim num2 As Single = CSng(Me.O0O.o.().ItemHeight)
				If num2 = 12F AndAlso Me.O0O.o.().Font.Size <> 9F Then
					num2 = Me.O0O.o.().Font.Size / 9F * 12F
				End If
				Dim num3 As Integer = CInt(Convert.ToInt16(Math.Floor(CDbl((Me.O0O.o.() - 36)) / CDbl(Me.OO.Oo0oOO..O__0o.o0_.().ItemHeight))))
				num3 = Math.Max(1, num3)
				Me.OO.Oo0oOO..O__0o.o0_.().Height = CInt(Math.Round(CDbl((num2 * CSng(num3) + 4F))))
				Me.OO.Oo0oOO..Height = Me.OO.Oo0oOO..O__0o.o0_.().Height + 32
			End If
		End Sub

		' Token: 0x06003DC0 RID: 15808 RVA: 0x001AD288 File Offset: 0x001AB488
		Public Function <<EMPTY_NAME>>() As Integer
			Dim result As Integer
			If MyBase.DroppedDown Then
				result = Me.O0O.o.().SelectedIndex
			ElseIf Me.Value Is Nothing Then
				result = -1
			ElseIf Me.O_.0.() Is Nothing Then
				result = Me.o_0Oo.o_.().IndexOf(RuntimeHelpers.GetObjectValue(Me.Value))
			Else
				result = CType(Me.O_.0.(), DataView).Find(RuntimeHelpers.GetObjectValue(Me.Value))
			End If
			Return result
		End Function

		' Token: 0x06003DC1 RID: 15809 RVA: 0x001AD2F8 File Offset: 0x001AB4F8
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			If MyBase.DroppedDown Then
				Me.O0O.o.().SelectedIndex = A_0
				Return
			End If
			If A_0 = -1 Then
				Me.Value = Nothing
				Return
			End If
			If Me.O0O.o.().DataSource Is Nothing Then
				Me.Value = RuntimeHelpers.GetObjectValue(Me.O0O.o.().Items(A_0))
				Return
			End If
			Me.Value = RuntimeHelpers.GetObjectValue(CType(Me.O_.0.(), DataView)(A_0)(Me.OOooOOO.O0.()))
		End Sub

		' Token: 0x06003DC2 RID: 15810 RVA: 0x001AD378 File Offset: 0x001AB578
		Public Function <<EMPTY_NAME>>() As Object
			Dim result As Object
			If MyBase.DroppedDown Then
				Dim selectedIndex As Integer = Me.O0O.o.().SelectedIndex
				If selectedIndex = -1 Then
					result = Nothing
				ElseIf Me.O_.0.() Is Nothing Then
					result = Me.O0O.o.().SelectedItem
				Else
					result = New DataRow(CType(Me.O_.0.(), DataView)(selectedIndex).Row)
				End If
			Else
				If Me.Value IsNot Nothing Then
					If Me.O_.0.() Is Nothing Then
						If Me.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(Me.Value)) Then
							Return Me.Value
						End If
					Else
						Dim num As Integer = CType(Me.O_.0.(), DataView).Find(RuntimeHelpers.GetObjectValue(Me.Value))
						If num >= 0 Then
							Return New DataRow(CType(Me.O_.0.(), DataView)(num).Row)
						End If
					End If
				End If
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06003DC3 RID: 15811 RVA: 0x001AD450 File Offset: 0x001AB650
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			If MyBase.DroppedDown Then
				If A_0 Is Nothing Then
					Me.o0.O_O.(-1)
					Return
				End If
				If Me.O_.0.() Is Nothing Then
					If Me.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(A_0)) Then
						Me.O0O.o.().SelectedIndex = Me.o_0Oo.o_.().IndexOf(RuntimeHelpers.GetObjectValue(A_0))
						Return
					End If
					Dim dataRow As DataRow = CType(A_0, DataRow)
					Dim num As Integer = CType(Me.O_.0.(), DataView).Find(RuntimeHelpers.GetObjectValue(dataRow(Me.OOooOOO.O0.())))
					If num >= 0 Then
						Me.o0.O_O.(num)
					End If
					Return
				End If
			Else
				If A_0 Is Nothing Then
					Me.Value = Nothing
					Return
				End If
				If Me.O_.0.() Is Nothing Then
					If Me.o_0Oo.o_.().Contains(RuntimeHelpers.GetObjectValue(A_0)) Then
						Me.Value = RuntimeHelpers.GetObjectValue(A_0)
						Return
					End If
				Else
					Dim dataRow2 As DataRow = CType(A_0, DataRow)
					If CType(Me.O_.0.(), DataView).Find(RuntimeHelpers.GetObjectValue(dataRow2(Me.OOooOOO.O0.()))) >= 0 Then
						Me.Value = RuntimeHelpers.GetObjectValue(dataRow2(Me.OOooOOO.O0.()))
					End If
				End If
			End If
		End Sub

		' Token: 0x06003DC4 RID: 15812 RVA: 0x001AD55C File Offset: 0x001AB75C
		Public Function <<EMPTY_NAME>>() As Object
			Dim result As Object
			If Me.O_.0.() Is Nothing Then
				result = Me.o0.0.()
			Else
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.o0.0.())
				If objectValue Is Nothing Then
					result = Nothing
				Else
					result = CType(objectValue, DataRow)(Me.OOooOOO.O0.())
				End If
			End If
			Return result
		End Function

		' Token: 0x06003DC5 RID: 15813 RVA: 0x001AD5A0 File Offset: 0x001AB7A0
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Object)
			If A_0 IsNot Nothing AndAlso Me.O_.0.() IsNot Nothing Then
				Dim num As Integer = CType(Me.O_.0.(), DataView).Find(RuntimeHelpers.GetObjectValue(A_0))
				If num >= 0 Then
					A_0 = New DataRow(CType(Me.O_.0.(), DataView)(num).Row)
				Else
					A_0 = Nothing
				End If
			End If
			Me.o.__.(RuntimeHelpers.GetObjectValue(A_0))
		End Sub

		' Token: 0x06003DC6 RID: 15814 RVA: 0x001AD603 File Offset: 0x001AB803
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O0O.o.().FormattingEnabled
		End Function

		' Token: 0x06003DC7 RID: 15815 RVA: 0x001AD610 File Offset: 0x001AB810
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O0O.o.().FormattingEnabled = A_0
		End Sub

		' Token: 0x06003DC8 RID: 15816 RVA: 0x001AD61E File Offset: 0x001AB81E
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Integer, A_1 As Boolean)
			Me.O0O.o.().SetItemChecked(A_0, A_1)
		End Sub

		' Token: 0x06003DC9 RID: 15817 RVA: 0x001AD62D File Offset: 0x001AB82D
		Public Function <<EMPTY_NAME>>(A_0 As Integer) As Boolean
			Return Me.O0O.o.().GetItemChecked(A_0)
		End Function

		' Token: 0x06003DCA RID: 15818 RVA: 0x001AD63C File Offset: 0x001AB83C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O000_oOo_o.ooO.()
			If Me.Value Is Nothing Then
				Me.O0O.o.().Value = ""
			Else
				Me.O0O.o.().Value = Me.Value.ToString()
			End If
			If Me.DropDownForm IsNot Nothing Then
				Me.DropDownForm.Owner = Nothing
			End If
		End Sub

		' Token: 0x06003DCB RID: 15819 RVA: 0x001AD693 File Offset: 0x001AB893
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.o_0Oo.o_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003DCC RID: 15820 RVA: 0x001AD6AD File Offset: 0x001AB8AD
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO.Oo0oOO..O__0o.o0_.().Font = Me.Font
		End Sub

		' Token: 0x06003DCD RID: 15821 RVA: 0x001AD6C8 File Offset: 0x001AB8C8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			Me.O000_oOo_o.ooO.()
			ooO_0O.o_O0.O_.(Me, Me.o_0Oo.o_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003DCE RID: 15822 RVA: 0x001AD721 File Offset: 0x001AB921
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If Not Me.OOo0_o.O00__.() AndAlso A_1.KeyCode = Keys.Delete Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06003DCF RID: 15823 RVA: 0x001AD743 File Offset: 0x001AB943
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.OOo0_o.O00__.() Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x17000D85 RID: 3461
		' (get) Token: 0x06003DD0 RID: 15824 RVA: 0x001AD75C File Offset: 0x001AB95C
		' (set) Token: 0x06003DD1 RID: 15825 RVA: 0x001AD782 File Offset: 0x001AB982
		Public Property Value As Object
			Get
				Dim result As Object
				If MyBase.Value Is DBNull.Value Then
					result = Nothing
				Else
					result = MyBase.Value
				End If
				Return result
			End Get
			Set(value As Object)
				MyBase.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003DD2 RID: 15826 RVA: 0x001AD790 File Offset: 0x001AB990
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemCheckEventArgs)
			Dim oo.Oo0oOO. As O0oo000oO0oo_.o_o00 = Me.OO.Oo0oOO.
			If oo.Oo0oOO. IsNot Nothing Then
				oo.Oo0oOO.(Me, A_1)
			End If
		End Sub

		' Token: 0x06003DD3 RID: 15827 RVA: 0x001AD7B0 File Offset: 0x001AB9B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim oo_o_.o__. As O0oo000oO0oo_.o0_00__ooOo = Me.OO_o_.o__.
			If oo_o_.o__. IsNot Nothing Then
				oo_o_.o__.(Me, A_1)
			End If
		End Sub

		' Token: 0x06003DD4 RID: 15828 RVA: 0x001AD7D0 File Offset: 0x001AB9D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListControlConvertEventArgs)
			Dim oo.Oo0oOO. As O0oo000oO0oo_.oO0__ = Me.OO.Oo0oOO.
			If oo.Oo0oOO. IsNot Nothing Then
				oo.Oo0oOO.(Me, A_1)
			End If
		End Sub

		' Token: 0x06003DD5 RID: 15829 RVA: 0x001AD7EF File Offset: 0x001AB9EF
		Public Overloads Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.o_0Oo.o_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x17000D86 RID: 3462
		' (get) Token: 0x06003DD6 RID: 15830 RVA: 0x001AD809 File Offset: 0x001ABA09
		' (set) Token: 0x06003DD7 RID: 15831 RVA: 0x001AD811 File Offset: 0x001ABA11
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003DD8 RID: 15832 RVA: 0x001AD81F File Offset: 0x001ABA1F
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.O.o0O.
		End Function

		' Token: 0x06003DD9 RID: 15833 RVA: 0x001AD827 File Offset: 0x001ABA27
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.O.o0O. = A_0
		End Sub

		' Token: 0x0400191C RID: 6428
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x0400191D RID: 6429
		Private <<EMPTY_NAME>> As Char

		' Token: 0x0400191E RID: 6430
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400191F RID: 6431
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001920 RID: 6432
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001921 RID: 6433
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001922 RID: 6434
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CustomCheckedListBox

		' Token: 0x04001923 RID: 6435
		Friend <<EMPTY_NAME>> As O\u3002\u3000

		' Token: 0x04001924 RID: 6436
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O0oo000oO0oo_.o_o00

		' Token: 0x04001925 RID: 6437
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O0oo000oO0oo_.o0_00__ooOo

		' Token: 0x04001926 RID: 6438
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O0oo000oO0oo_.oO0__

		' Token: 0x04001927 RID: 6439
		Private Const <<EMPTY_NAME>> As Integer = 770

		' Token: 0x04001928 RID: 6440
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x020003C6 RID: 966
		' (Invoke) Token: 0x06003DDD RID: 15837
		Public Delegate Sub o_o00(A_0 As Object, A_1 As ItemCheckEventArgs)

		' Token: 0x020003C7 RID: 967
		' (Invoke) Token: 0x06003DE1 RID: 15841
		Public Delegate Sub o0_00__ooOo(A_0 As Object, A_1 As EventArgs)

		' Token: 0x020003C8 RID: 968
		' (Invoke) Token: 0x06003DE5 RID: 15845
		Public Delegate Sub oO0__(A_0 As Object, A_1 As ListControlConvertEventArgs)
	End Class
End Namespace
