Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200006D RID: 109
	Friend Class O0_0_0_Oo_o
		Inherits C1DropDownControl

		' Token: 0x060003BF RID: 959 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ListBox
			Return Me.o_.0.
		End Function

		' Token: 0x060003C0 RID: 960 RVA: 0x0000CA00 File Offset: 0x0000AC00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o_.0. = A_0
		End Sub

		' Token: 0x060003C1 RID: 961 RVA: 0x0000CA09 File Offset: 0x0000AC09
		<CompilerGenerated()>
		Private Overridable Function <<EMPTY_NAME>>() As O\u30000\u3002\u3002O
			Return Me.o_.0.
		End Function

		' Token: 0x060003C2 RID: 962 RVA: 0x0000CA14 File Offset: 0x0000AC14
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Overridable Sub <<EMPTY_NAME>>(A_0 As O\u30000\u3002\u3002O)
			Dim value As EventHandler = AddressOf Me.oo_00.____.
			Dim o_u30000_u3002_u3002O As O\u30000\u3002\u3002O = Me.o_.0.
			If o_u30000_u3002_u3002O IsNot Nothing Then
				RemoveHandler o_u30000_u3002_u3002O.Disposed, value
			End If
			Me.o_.0. = A_0
			o_u30000_u3002_u3002O = Me.o_.0.
			If o_u30000_u3002_u3002O IsNot Nothing Then
				AddHandler o_u30000_u3002_u3002O.Disposed, value
			End If
		End Sub

		' Token: 0x060003C3 RID: 963 RVA: 0x0000CA58 File Offset: 0x0000AC58
		Public Sub New()
			MyBase.DropDownClosed += AddressOf Me.oo_00.____.
			MyBase.DropDownOpened += AddressOf Me.oO._.
			AddHandler MyBase.FontChanged, AddressOf Me.O.o_.
			AddHandler MyBase.GotFocus, AddressOf Me.O0.0oOO00O.
			AddHandler MyBase.KeyDown, AddressOf Me.o_o.O_0OOO.
			AddHandler MyBase.KeyPress, AddressOf Me.oo_00.____.
			Me.o_.0. = True
			Me.o0_O0Oo_o.0Oo. = -1
			Me.ShowUpDownButtons = False
			Me.O.O_oo_OO_O.(New O\u30000\u3002\u3002O())
			Me.O.00o0o_.(Me.OO.0oo.().OOOO.0.())
			Me.DropDownForm = Me.OO.0oo.()
			MyBase.VisualStyle = 1
			MyBase.EmptyAsNull = True
			MyBase.MaskInfo.ShowLiterals = 3
			MyBase.MaskInfo.AutoTabWhenFilled = True
			MyBase.MaskInfo.EmptyAsNull = True
			MyBase.ErrorInfo.ShowErrorMessage = False
			Me.OO.0oo.().Font = Me.Font
		End Sub

		' Token: 0x060003C4 RID: 964 RVA: 0x0000CB63 File Offset: 0x0000AD63
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If A_0.Msg <> 770 OrElse Me.oO.oO__o00.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x060003C5 RID: 965 RVA: 0x0000CB81 File Offset: 0x0000AD81
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.o_.0.
		End Function

		' Token: 0x060003C6 RID: 966 RVA: 0x0000CB89 File Offset: 0x0000AD89
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o_.0. = A_0
		End Sub

		' Token: 0x060003C7 RID: 967 RVA: 0x0000CB92 File Offset: 0x0000AD92
		Public Function <<EMPTY_NAME>>() As ListBox.ObjectCollection
			Return Me.OO.0oo.().Items
		End Function

		' Token: 0x060003C8 RID: 968 RVA: 0x0000CB9F File Offset: 0x0000AD9F
		Public Function <<EMPTY_NAME>>() As String
			Return Me.OO.0oo.().DisplayMember
		End Function

		' Token: 0x060003C9 RID: 969 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO.0oo.().DisplayMember = A_0
		End Sub

		' Token: 0x060003CA RID: 970 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		Public Function <<EMPTY_NAME>>() As String
			Return Me.OO.0oo.().ValueMember
		End Function

		' Token: 0x060003CB RID: 971 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.OO.0oo.().ValueMember = A_0
		End Sub

		' Token: 0x060003CC RID: 972 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.OO.0oo.().DataSource
		End Function

		' Token: 0x060003CD RID: 973 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim a_ As String = Me.oo_00.____.()
			Me.OO.0oo.().DataSource = RuntimeHelpers.GetObjectValue(A_0)
			Me.oO_0.__oO0_000.(a_)
		End Sub

		' Token: 0x060003CE RID: 974 RVA: 0x0000CC10 File Offset: 0x0000AE10
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.OO.0oo.().MultiColumn
		End Function

		' Token: 0x060003CF RID: 975 RVA: 0x0000CC1D File Offset: 0x0000AE1D
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.OO.0oo.().MultiColumn = A_0
		End Sub

		' Token: 0x060003D0 RID: 976 RVA: 0x0000CC2B File Offset: 0x0000AE2B
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.OO.0oo.().ColumnWidth
		End Function

		' Token: 0x060003D1 RID: 977 RVA: 0x0000CC38 File Offset: 0x0000AE38
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OO.0oo.().ColumnWidth = A_0
		End Sub

		' Token: 0x060003D2 RID: 978 RVA: 0x0000CC46 File Offset: 0x0000AE46
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.o_.0.
		End Function

		' Token: 0x060003D3 RID: 979 RVA: 0x0000CC4E File Offset: 0x0000AE4E
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.o_.0. = A_0
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x0000CC57 File Offset: 0x0000AE57
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O0__.o_.
		End Function

		' Token: 0x060003D5 RID: 981 RVA: 0x0000CC5F File Offset: 0x0000AE5F
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O0__.o_. = A_0
		End Sub

		' Token: 0x060003D6 RID: 982 RVA: 0x0000CC68 File Offset: 0x0000AE68
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.oO0o__O.oO.
		End Function

		' Token: 0x060003D7 RID: 983 RVA: 0x0000CC70 File Offset: 0x0000AE70
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.oO0o__O.oO. = A_0
		End Sub

		' Token: 0x060003D8 RID: 984 RVA: 0x0000CC79 File Offset: 0x0000AE79
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.OO.0oo.().O0o0o.o.()
		End Function

		' Token: 0x060003D9 RID: 985 RVA: 0x0000CC86 File Offset: 0x0000AE86
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OO.0oo.().OOOO.0.(A_0)
		End Sub

		' Token: 0x060003DA RID: 986 RVA: 0x0000CC94 File Offset: 0x0000AE94
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			If Me.DropDownForm IsNot Me.OO.0oo.() Then
				Me.DropDownForm = Me.OO.0oo.()
			End If
			If Me.O___0oO__.0oO.() IsNot Nothing And Me.O0__.o_. Then
				Me.O0__.o_. = False
				CType(Me.O___0oO__.0oO.(), DataView).RowFilter = Me.o_.0.
			End If
			If Me.o0_O0Oo_o.0Oo. <> Me.OO.0oo.().SelectedIndex AndAlso MyBase.UpdateValueWithCurrentText() AndAlso MyBase.DataBindings.Count > 0 Then
				MyBase.DataBindings(0).WriteValue()
			End If
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x0000CD24 File Offset: 0x0000AF24
		Friend Overloads Sub <<EMPTY_NAME>>()
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				If Me.DropDownForm IsNot Me.OO.0oo.() Then
					GoTo IL_1A7
				End If
				IL_13:
				num = 3
				If Me.Value IsNot Nothing Then
					GoTo IL_30
				End If
				IL_1D:
				num = 4
				Me.OO.0oo.().SelectedIndex = -1
				GoTo IL_BB
				IL_30:
				num = 6
				If Me.OO.0oo.().DataSource IsNot Nothing Then
					GoTo IL_64
				End If
				IL_3F:
				num = 7
				Me.OO.0oo.().SelectedIndex = Me.OO.0oo.().FindStringExact(Me.Value.ToString())
				GoTo IL_BB
				IL_64:
				num = 9
				Dim dataView As DataView = CType(Me.OO.0oo.().DataSource, DataView)
				IL_79:
				num = 10
				If Operators.CompareString(dataView.Sort, Me.oO_0.__oO0_000.(), True) <> 0 Then
					GoTo IL_B8
				End If
				IL_91:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_98:
				num = 12
				Me.OO.0oo.().SelectedIndex = dataView.Find(RuntimeHelpers.GetObjectValue(Me.Value))
				IL_B8:
				dataView = Nothing
				IL_BB:
				num = 14
				If Me.O00___.0oO00.() <= 0 Then
					GoTo IL_E4
				End If
				IL_C7:
				num = 15
				Me.OO.0oo.().Width = Math.Max(60, Me.O00___.0oO00.())
				GoTo IL_FF
				IL_E4:
				num = 17
				Me.OO.0oo.().Width = Math.Max(60, MyBase.Width)
				IL_FF:
				num = 18
				Dim num3 As Integer = Math.Max(Me.Oo._.(), CInt(Convert.ToInt16(Math.Floor(CDbl((Me.oo_00.____.() - 4)) / CDbl(Me.OO.0oo.().ItemHeight)))))
				IL_12E:
				num = 19
				num3 = Math.Min(num3, Math.Max(1, Me.OO.0oo.().Items.Count))
				IL_14E:
				num = 20
				Me.OO.0oo.().OOOO.0.().Height = Me.OO.0oo.().OOOO.0.().ItemHeight * num3 + 4
				IL_175:
				num = 21
				Me.OO.0oo.().Height = Me.OO.0oo.().OOOO.0.().Height
				IL_193:
				num = 22
				Me.o0_O0Oo_o.0Oo. = Me.OO.0oo.().SelectedIndex
				IL_1A7:
				GoTo IL_255
				IL_1AC:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_216:
				GoTo IL_24A
				IL_218:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_228:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_218
			End Try
			IL_24A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_255:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.OO.0oo.().SelectedIndex
		End Function

		' Token: 0x060003DD RID: 989 RVA: 0x0000CFB9 File Offset: 0x0000B1B9
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.OO.0oo.().SelectedIndex = A_0
		End Sub

		' Token: 0x060003DE RID: 990 RVA: 0x0000CFC7 File Offset: 0x0000B1C7
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.OO.0oo.().SelectedItem
		End Function

		' Token: 0x060003DF RID: 991 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Me.OO.0oo.().SelectedItem = RuntimeHelpers.GetObjectValue(A_0)
		End Sub

		' Token: 0x060003E0 RID: 992 RVA: 0x0000CFE7 File Offset: 0x0000B1E7
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.OO.0oo.().SelectedValue
		End Function

		' Token: 0x060003E1 RID: 993 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As Object)
			Me.OO.0oo.().SelectedValue = RuntimeHelpers.GetObjectValue(A_0)
		End Sub

		' Token: 0x060003E2 RID: 994 RVA: 0x0000D007 File Offset: 0x0000B207
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.OO.0oo.().FormattingEnabled
		End Function

		' Token: 0x060003E3 RID: 995 RVA: 0x0000D014 File Offset: 0x0000B214
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.OO.0oo.().FormattingEnabled = A_0
		End Sub

		' Token: 0x060003E4 RID: 996 RVA: 0x0000D022 File Offset: 0x0000B222
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.00o0o_.()
			Me.OO.0oo.().Owner = Nothing
		End Sub

		' Token: 0x060003E5 RID: 997 RVA: 0x0000D036 File Offset: 0x0000B236
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OO.0oo.().Font = Me.Font
		End Sub

		' Token: 0x060003E6 RID: 998 RVA: 0x0000D049 File Offset: 0x0000B249
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O.00o0o_.()
		End Sub

		' Token: 0x060003E7 RID: 999 RVA: 0x0000D054 File Offset: 0x0000B254
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_1.KeyCode <> Keys.Down Then
					GoTo IL_4D
				End If
				IL_13:
				num2 = 3
				If Not(TypeOf MyBase.Parent Is O_oOooO_O) Then
					GoTo IL_5A2
				End If
				IL_25:
				num2 = 4
				If Not CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					GoTo IL_5A2
				End If
				IL_3C:
				num2 = 5
				SendKeys.Send("{DOWN}")
				GoTo IL_5A2
				IL_4D:
				num2 = 7
				If A_1.KeyCode <> Keys.Up Then
					GoTo IL_95
				End If
				IL_59:
				num2 = 8
				If Not(TypeOf MyBase.Parent Is O_oOooO_O) Then
					GoTo IL_5A2
				End If
				IL_6B:
				num2 = 9
				If Not CType(MyBase.Parent, O_oOooO_O).FinishEditing() Then
					GoTo IL_5A2
				End If
				IL_83:
				num2 = 10
				SendKeys.Send("{UP}")
				GoTo IL_5A2
				IL_95:
				num2 = 12
				If A_1.KeyCode <> Keys.Space OrElse (Operators.CompareString(Me.Text, "", True) <> 0 AndAlso Me.oO.oO__o00.()) OrElse MyBase.DroppedDown Then
					GoTo IL_138
				End If
				IL_C8:
				num2 = 13
				A_1.Handled = True
				IL_D2:
				num2 = 14
				A_1.SuppressKeyPress = True
				IL_DC:
				num2 = 15
				Me.OpenDropDown()
				IL_E5:
				num2 = 16
				Me.OO.0oo.().Focus()
				IL_F4:
				num2 = 17
				SendKeys.Send("{DOWN}")
				IL_101:
				num2 = 18
				If Me.OO.0oo.().OOOO.0.().Items.Count <= 0 Then
					GoTo IL_5A2
				End If
				IL_11F:
				num2 = 19
				Me.OO.0oo.().OOOO.0.().SelectedIndex = 0
				GoTo IL_5A2
				IL_138:
				num2 = 21
				If Me.oO.oO__o00.() Then
					GoTo IL_16C
				End If
				IL_143:
				num2 = 22
				If A_1.KeyCode <> Keys.Delete Then
					GoTo IL_5A2
				End If
				IL_153:
				num2 = 23
				A_1.Handled = True
				IL_15D:
				num2 = 24
				A_1.SuppressKeyPress = True
				GoTo IL_5A2
				IL_16C:
				num2 = 26
				If Not A_1.Control OrElse A_1.KeyCode <> Keys.[Return] Then
					GoTo IL_5A2
				End If
				IL_187:
				num2 = 27
				A_1.Handled = True
				IL_191:
				num2 = 28
				A_1.SuppressKeyPress = True
				IL_19B:
				num2 = 29
				Me.SelectedText = ""
				IL_1A9:
				num2 = 30
				If Not(TypeOf MyBase.Parent Is O_oOooO_O) Then
					GoTo IL_218
				End If
				IL_1B9:
				num2 = 31
				Dim o_oOooO_O As O_oOooO_O = CType(MyBase.Parent, O_oOooO_O)
				IL_1C8:
				num2 = 32
				If Not A_1.Shift Then
					GoTo IL_201
				End If
				IL_1D3:
				num2 = 33
				o_oOooO_O.o.0O_O0o_..Cols(o_oOooO_O.Cols(o_oOooO_O.Col).Name).ResetAutoCompleteSource()
				IL_201:
				num2 = 34
				If o_oOooO_O.Editor IsNot Nothing Then
					GoTo IL_216
				End If
				IL_20C:
				num2 = 35
				o_oOooO_O.StartEditing()
				IL_216:
				o_oOooO_O = Nothing
				IL_218:
				num2 = 37
				If Operators.CompareString(Me.Text, "", True) <> 0 Then
					GoTo IL_23C
				End If
				IL_22E:
				num2 = 38
				Me.OpenDropDown()
				GoTo IL_5A2
				IL_23C:
				num2 = 40
				If Me.O___0oO__.0oO.() Is Nothing Then
					GoTo IL_3BC
				End If
				IL_24A:
				num2 = 41
				Dim dataView As DataView = CType(Me.O___0oO__.0oO.(), DataView)
				IL_25A:
				num2 = 42
				Me.O0__.o_. = True
				IL_264:
				num2 = 43
				Me.o_.0. = dataView.RowFilter
				IL_274:
				num2 = 44
				If Operators.CompareString(Me.o_.0., "", True) <= 0 Then
					GoTo IL_2D5
				End If
				IL_28B:
				num2 = 45
				dataView.RowFilter = String.Concat(New String() { Me.o_.0., " And [", Me.oO_0.__oO0_000.(), "] Like '*", Me.Text, "*'" })
				GoTo IL_314
				IL_2D5:
				num2 = 47
				dataView.RowFilter = String.Concat(New String() { "[", Me.oO_0.__oO0_000.(), "] Like '*", Me.Text, "*'" })
				IL_314:
				num2 = 48
				If dataView.Count <> 0 Then
					GoTo IL_348
				End If
				IL_320:
				num2 = 49
				Me.O0__.o_. = False
				IL_32A:
				num2 = 50
				dataView.RowFilter = Me.o_.0.
				IL_33A:
				num2 = 51
				Me.o_.0. = ""
				IL_348:
				num2 = 52
				Me.OpenDropDown()
				IL_351:
				num2 = 53
				If Me.DropDownForm Is Nothing Then
					GoTo IL_5A2
				End If
				IL_35F:
				num2 = 54
				Dim o_u30000_u3002_u3002O As O\u30000\u3002\u3002O = CType(Me.DropDownForm, O\u30000\u3002\u3002O)
				IL_36F:
				num2 = 55
				o_u30000_u3002_u3002O.OOOO.0.().[Select]()
				IL_37E:
				num2 = 56
				If o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex >= 0 OrElse o_u30000_u3002_u3002O.OOOO.0.().Items.Count <= 0 Then
					GoTo IL_3B4
				End If
				IL_3A4:
				num2 = 57
				o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex = 0
				IL_3B4:
				o_u30000_u3002_u3002O = Nothing
				GoTo IL_5A2
				IL_3BC:
				num2 = 60
				If Me.OO.0oo.() Is Nothing Then
					GoTo IL_5A2
				End If
				IL_3CA:
				num2 = 61
				Dim list As List(Of String) = New List(Of String)()
				IL_3D4:
				num2 = 62
				Dim enumerator As IEnumerator = Me.OO.0oo.().GetEnumerator()
				While enumerator.MoveNext()
					Dim value As Object = enumerator.Current
					Dim text As String = Conversions.ToString(value)
					IL_3F4:
					num2 = 63
					If text.IndexOf(Me.Text) >= 0 Then
						IL_407:
						num2 = 64
						list.Add(text)
					End If
					IL_413:
					num2 = 65
				End While
				IL_41F:
				num2 = 66
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_437:
				num2 = 67
				If list.Count <= 1 AndAlso (list.Count <> 1 OrElse Operators.CompareString(Me.Text, list(0), True) = 0) Then
					GoTo IL_536
				End If
				IL_46A:
				num2 = 68
				Dim o_u30000_u3002_u3002O2 As O\u30000\u3002\u3002O = New O\u30000\u3002\u3002O()
				IL_474:
				num2 = 69
				o_u30000_u3002_u3002O2.OOOO.0.().Items.AddRange(list.ToArray())
				IL_48F:
				num2 = 70
				o_u30000_u3002_u3002O2.OOOO.0.().Font = Me.OO.0oo.().Font
				IL_4A9:
				num2 = 71
				If Me.O00___.0oO00.() <= 0 Then
					GoTo IL_4CE
				End If
				IL_4B5:
				num2 = 72
				o_u30000_u3002_u3002O2.Width = Math.Max(60, Me.O00___.0oO00.())
				GoTo IL_4E5
				IL_4CE:
				num2 = 74
				o_u30000_u3002_u3002O2.Width = Math.Max(60, MyBase.Width)
				IL_4E5:
				num2 = 75
				o_u30000_u3002_u3002O2.OOOO.0.().Height = Math.Min(list.Count, Me.Oo._.()) * o_u30000_u3002_u3002O2.OOOO.0.().ItemHeight + 4
				IL_515:
				num2 = 76
				o_u30000_u3002_u3002O2.Height = o_u30000_u3002_u3002O2.OOOO.0.().Height
				IL_52B:
				num2 = 77
				Me.DropDownForm = o_u30000_u3002_u3002O2
				IL_536:
				num2 = 78
				Me.OpenDropDown()
				IL_53F:
				num2 = 79
				If Me.DropDownForm Is Nothing Then
					GoTo IL_5A2
				End If
				IL_54A:
				num2 = 80
				Dim o_u30000_u3002_u3002O3 As O\u30000\u3002\u3002O = CType(Me.DropDownForm, O\u30000\u3002\u3002O)
				IL_55A:
				num2 = 81
				o_u30000_u3002_u3002O3.OOOO.0.().[Select]()
				IL_569:
				num2 = 82
				If o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex >= 0 OrElse o_u30000_u3002_u3002O3.OOOO.0.().Items.Count <= 0 Then
					GoTo IL_59F
				End If
				IL_58F:
				num2 = 83
				o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex = 0
				IL_59F:
				o_u30000_u3002_u3002O3 = Nothing
				IL_5A2:
				GoTo IL_748
				IL_5A7:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_709:
				GoTo IL_73D
				IL_70B:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_71B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_70B
			End Try
			IL_73D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_748:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060003E8 RID: 1000 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.oO.oO__o00.() Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
			End If
		End Sub

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		' (set) Token: 0x060003EA RID: 1002 RVA: 0x0000D80E File Offset: 0x0000BA0E
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

		' Token: 0x060003EB RID: 1003 RVA: 0x0000D81C File Offset: 0x0000BA1C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Main.OO_O.o..Disposing AndAlso Not Main.OO_O.o..IsDisposed AndAlso Not Main.OO_O.o..o_O.o__. Then
				Dim right As String = ""
				Dim flag As Boolean
				Try
					For Each table As Table In OO_00oOO.Tables
						If Operators.CompareString(table.Name, table.DataTable.Name, True) = 0 Then
							Try
								For Each obj As Object In table.Grid.Cols
									Dim column As Column = CType(obj, Column)
									If column.Editor Is Me AndAlso table.DataTable.DataCols(column.Name).oO0._00o_0. Is Me Then
										flag = True
										right = table.DataTable.Name
										table.DataTable.DataCols(column.Name).oO0._00o_0. = Nothing
										Exit For
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator As IEnumerator(Of Table)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				If flag Then
					Try
						For Each table2 As Table In OO_00oOO.Tables
							If Operators.CompareString(table2.DataTable.Name, right, True) = 0 Then
								Try
									For Each obj2 As Object In table2.Grid.Cols
										Dim column2 As Column = CType(obj2, Column)
										If column2.Editor Is Me Then
											column2.Editor = Nothing
											table2.Cols(column2.Name).o0.O.()
										End If
									Next
								Finally
									Dim enumerator4 As IEnumerator
									If TypeOf enumerator4 Is IDisposable Then
										TryCast(enumerator4, IDisposable).Dispose()
									End If
								End Try
							End If
						Next
						Return
					Finally
						Dim enumerator3 As IEnumerator(Of Table)
						If enumerator3 IsNot Nothing Then
							enumerator3.Dispose()
						End If
					End Try
				End If
				Try
					For Each table3 As Table In OO_00oOO.Tables
						Try
							For Each obj3 As Object In table3.Grid.Cols
								Dim column3 As Column = CType(obj3, Column)
								If column3.Editor Is Me Then
									column3.Editor = Nothing
									Dim col As Col = table3.Cols(column3.Name)
									If Operators.CompareString(col.o_0.oo., "", True) > 0 Then
										col.ComboList = col.o_0.oo.
									ElseIf Operators.CompareString(col.DataSource, "", True) > 0 Then
										col.DataSource = col.DataSource
									End If
								End If
							Next
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator5 As IEnumerator(Of Table)
					If enumerator5 IsNot Nothing Then
						enumerator5.Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x040000CE RID: 206
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000CF RID: 207
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000D0 RID: 208
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000D1 RID: 209
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000D2 RID: 210
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040000D3 RID: 211
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x040000D4 RID: 212
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As O\u30000\u3002\u3002O

		' Token: 0x040000D5 RID: 213
		Private <<EMPTY_NAME>> As String

		' Token: 0x040000D6 RID: 214
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040000D7 RID: 215
		Private Const <<EMPTY_NAME>> As Integer = 770
	End Class
End Namespace
