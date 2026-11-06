Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003CB RID: 971
	Friend Class OoOO0Oo_oo0oO
		Inherits C1DropDownControl
		Implements O000O

		' Token: 0x06003DFC RID: 15868 RVA: 0x001AE033 File Offset: 0x001AC233
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.ListBox
			Return Me.O.__.
		End Function

		' Token: 0x06003DFD RID: 15869 RVA: 0x001AE03C File Offset: 0x001AC23C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.ListBox)
			Dim value As EventHandler = AddressOf Me.O_O_OoOoOo.o0_.
			Dim value2 As ListControlConvertEventHandler = AddressOf Me.O_oOO_._o.
			Dim o.__. As System.Windows.Forms.ListBox = Me.O.__.
			If o.__. IsNot Nothing Then
				RemoveHandler o.__..SelectedIndexChanged, value
				RemoveHandler o.__..Format, value2
			End If
			Me.O.__. = A_0
			o.__. = Me.O.__.
			If o.__. IsNot Nothing Then
				AddHandler o.__..SelectedIndexChanged, value
				AddHandler o.__..Format, value2
			End If
		End Sub

		' Token: 0x06003DFE RID: 15870 RVA: 0x001AE09C File Offset: 0x001AC29C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OoOO0Oo_oo0oO.o0__0)
			Dim o0__ As OoOO0Oo_oo0oO.o0__0 = Me.O_o_.O.
			Dim o0__2 As OoOO0Oo_oo0oO.o0__0
			Do
				o0__2 = o0__
				Dim value As OoOO0Oo_oo0oO.o0__0 = CType([Delegate].Combine(o0__2, A_0), OoOO0Oo_oo0oO.o0__0)
				o0__ = Interlocked.CompareExchange(Of OoOO0Oo_oo0oO.o0__0)(Me.O_o_.O., value, o0__2)
			Loop While o0__ IsNot o0__2
		End Sub

		' Token: 0x06003DFF RID: 15871 RVA: 0x001AE0D4 File Offset: 0x001AC2D4
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OoOO0Oo_oo0oO.o0__0)
			Dim o0__ As OoOO0Oo_oo0oO.o0__0 = Me.O_o_.O.
			Dim o0__2 As OoOO0Oo_oo0oO.o0__0
			Do
				o0__2 = o0__
				Dim value As OoOO0Oo_oo0oO.o0__0 = CType([Delegate].Remove(o0__2, A_0), OoOO0Oo_oo0oO.o0__0)
				o0__ = Interlocked.CompareExchange(Of OoOO0Oo_oo0oO.o0__0)(Me.O_o_.O., value, o0__2)
			Loop While o0__ IsNot o0__2
		End Sub

		' Token: 0x06003E00 RID: 15872 RVA: 0x001AE10C File Offset: 0x001AC30C
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OoOO0Oo_oo0oO.oo0O00O)
			Dim oo0O00O As OoOO0Oo_oo0oO.oo0O00O = Me.O.oO.
			Dim oo0O00O2 As OoOO0Oo_oo0oO.oo0O00O
			Do
				oo0O00O2 = oo0O00O
				Dim value As OoOO0Oo_oo0oO.oo0O00O = CType([Delegate].Combine(oo0O00O2, A_0), OoOO0Oo_oo0oO.oo0O00O)
				oo0O00O = Interlocked.CompareExchange(Of OoOO0Oo_oo0oO.oo0O00O)(Me.O.oO., value, oo0O00O2)
			Loop While oo0O00O IsNot oo0O00O2
		End Sub

		' Token: 0x06003E01 RID: 15873 RVA: 0x001AE144 File Offset: 0x001AC344
		<CompilerGenerated()>
		Public Sub <<EMPTY_NAME>>(A_0 As OoOO0Oo_oo0oO.oo0O00O)
			Dim oo0O00O As OoOO0Oo_oo0oO.oo0O00O = Me.O.oO.
			Dim oo0O00O2 As OoOO0Oo_oo0oO.oo0O00O
			Do
				oo0O00O2 = oo0O00O
				Dim value As OoOO0Oo_oo0oO.oo0O00O = CType([Delegate].Remove(oo0O00O2, A_0), OoOO0Oo_oo0oO.oo0O00O)
				oo0O00O = Interlocked.CompareExchange(Of OoOO0Oo_oo0oO.oo0O00O)(Me.O.oO., value, oo0O00O2)
			Loop While oo0O00O IsNot oo0O00O2
		End Sub

		' Token: 0x06003E02 RID: 15874 RVA: 0x001AE17C File Offset: 0x001AC37C
		Friend Sub New()
			MyBase.DropDownClosed += AddressOf Me.O_oOO_._o.
			MyBase.DropDownOpened += AddressOf Me.o.0_o0OO.
			AddHandler MyBase.Enter, AddressOf Me.O0o00oo.O0_.
			AddHandler MyBase.FontChanged, AddressOf Me.O00o.o.
			AddHandler MyBase.GotFocus, AddressOf Me.oo0_._O0_0.
			AddHandler MyBase.KeyDown, AddressOf Me.O_oOO_._o.
			AddHandler MyBase.KeyPress, AddressOf Me.O_oOO_._o.
			AddHandler MyBase.Validated, AddressOf Me.O_o0o0_Oo.0.
			Me.O.oO. = 0
			Me.O.__. = True
			Me.O0_0oo.___o. = 11
			Me.oo__Oo_.oO. = -1
			Me.ShowUpDownButtons = False
			Me.O.oO. = New O\u30000\u3002\u3002O()
			Me.o__0_OooO0._.(Me.O.oO..OOOO.0.())
			Me.DropDownForm = Me.O.oO.
			Me.O__oo_OO.O_.().Font = Me.Font
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

		' Token: 0x06003E03 RID: 15875 RVA: 0x001AE307 File Offset: 0x001AC507
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(ByRef A_0 As Message)
			If A_0.Msg <> 770 OrElse Me.oo0.ooo.() Then
				MyBase.WndProc(A_0)
			End If
		End Sub

		' Token: 0x06003E04 RID: 15876 RVA: 0x001AE328 File Offset: 0x001AC528
		Shared Sub New()
			Dim num As Integer
			Dim num11 As Integer
			Dim obj As Object
			Try
				IL_2E:
				ProjectData.ClearProjectError()
				num = 1
				IL_35:
				Dim num2 As Integer = 2
				Dim num3 As Integer = 512
				IL_3D:
				num2 = 3
				Dim num4 As Integer = 8
				IL_42:
				num2 = 4
				Dim text As String = ""
				IL_4B:
				num2 = 5
				Dim num5 As Integer = num3
				IL_50:
				num2 = 6
				Dim num6 As Integer = 1
				While True
					IL_A6:
					num2 = 8
					If num5 = 0 Then
						Exit For
					End If
					IL_57:
					num2 = 9
					Dim num7 As Integer = CInt(Math.Round(CDbl(num5) Mod Math.Pow(CDbl(num4), CDbl(num6))))
					IL_71:
					num2 = 10
					text = Conversions.ToString(CDbl(num7) / Math.Pow(CDbl(num4), CDbl((num6 - 1)))) + text
					IL_93:
					num2 = 11
					num5 -= num7
					IL_9D:
					num2 = 12
					num6 += 1
				End While
				IL_AC:
				num2 = 14
				num5 = 0
				IL_B2:
				num2 = 15
				For Each [string] As Char In text
					IL_C9:
					num2 = 16
					num5 += Strings.Asc([string])
					IL_D8:
					num2 = 17
				Next
				IL_EC:
				num2 = 18
				Dim num8 As Double = 1024.0
				IL_FA:
				num2 = 19
				Dim num9 As Double = 500.0
				IL_108:
				num2 = 20
				Dim text3 As String = Conversions.ToString(Math.Floor(num8 / num9)) + "."
				While True
					IL_157:
					num2 = 22
					If text3.Length >= 100 Then
						Exit For
					End If
					IL_128:
					num2 = 23
					num8 = num8 Mod num9 * 10.0
					IL_13C:
					num2 = 24
					text3 += Conversions.ToString(Math.Floor(num8 / num9))
				End While
				IL_165:
				num2 = 26
				num5 = 0
				IL_16B:
				num2 = 27
				For Each string2 As Char In text3
					IL_182:
					num2 = 28
					num5 += Strings.Asc(string2)
					IL_191:
					num2 = 29
				Next
				IL_1A5:
				num2 = 30
				If O_O0OO.OoO.0OO__0ooo.().Relations.Count = 0 Then
					GoTo IL_315
				End If
				IL_1BC:
				num2 = 32
				If Operators.CompareString(OoOO0Oo_oo0oO.ooO.OooOOOO., OO_00oOO.ProjectFile, True) = 0 Then
					GoTo IL_315
				End If
				IL_1D4:
				num2 = 34
				OoOO0Oo_oo0oO.ooO.OooOOOO. = OO_00oOO.ProjectFile
				IL_1E1:
				num2 = 35
				OoOO0Oo_oo0oO.O.o0oO. = OoOO0Oo_oo0oO.O0O_o._oO0___. + "ProjectIdentify" + OoOO0Oo_oo0oO.O.OoO0Oo_.
				IL_1FD:
				num2 = 36
				OoOO0Oo_oo0oO.O_o_.O. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { OoOO0Oo_oo0oO.O.o0oO., OoOO0Oo_oo0oO.O.o0oO. })
				IL_239:
				num2 = 37
				If OoOO0Oo_oo0oO.O_o_.O. Is Nothing OrElse OoOO0Oo_oo0oO.O_o_.O..IsNull("Config") Then
					GoTo IL_315
				End If
				IL_25A:
				num2 = 38
				Dim text5 As String = O00.oO_.0o_oo_0O_.(OoOO0Oo_oo0oO.O_o_.O.("Config").ToString(), o_o_O0OO_0__.o000oOoo.0.(O_O0OO.O_O._Oo.()), O00.MD5Encrypt(O_O0OO.O_O._Oo.()))
				IL_28C:
				num2 = 39
				OoOO0Oo_oo0oO.o_0.__. = text5.Substring(0, text5.IndexOf("|"))
				IL_2A8:
				num2 = 40
				OoOO0Oo_oo0oO.Oo00.O_O0OO___. = text5.Substring(text5.IndexOf("|") + 1)
				IL_2C5:
				num2 = 41
				If Operators.CompareString(o0OoOOoOOo0.O_0_Oo_00.O.(OoOO0Oo_oo0oO.Oo00.O_O0OO___..Substring(0, OoOO0Oo_oo0oO.O.OoO0Oo_. * 4), o0OoOOoOOo0.o_OOo_0.0O.(OoOO0Oo_oo0oO.o_0.__.)), OoOO0Oo_oo0oO.Oo00.O_O0OO___..Substring(OoOO0Oo_oo0oO.O.OoO0Oo_. * 4, 4), True) = 0 Then
					GoTo IL_315
				End If
				IL_303:
				num2 = 42
				O_O0OO.OoO.0OO__0ooo.().Relations.Clear()
				IL_315:
				GoTo IL_413
				IL_31A:
				Dim num10 As Integer = num11 + 1
				num11 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num10)
				IL_3D4:
				GoTo IL_408
				IL_3D6:
				num11 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3E6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num11 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3D6
			End Try
			IL_408:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_413:
			If num11 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003E05 RID: 15877 RVA: 0x001AE76C File Offset: 0x001AC96C
		Public Function <<EMPTY_NAME>>() As BooleanEnum
			Return Me.O.oO.
		End Function

		' Token: 0x06003E06 RID: 15878 RVA: 0x001AE774 File Offset: 0x001AC974
		Public Sub <<EMPTY_NAME>>(A_0 As BooleanEnum)
			Me.O.oO. = A_0
			ooO_0O.o_O0.O_.(Me, Me.O__oo_OO.O_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E07 RID: 15879 RVA: 0x001AE795 File Offset: 0x001AC995
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O.__.
		End Function

		' Token: 0x06003E08 RID: 15880 RVA: 0x001AE79D File Offset: 0x001AC99D
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O.__. = A_0
		End Sub

		' Token: 0x06003E09 RID: 15881 RVA: 0x001AE7A6 File Offset: 0x001AC9A6
		Public Function <<EMPTY_NAME>>() As System.Windows.Forms.ListBox.ObjectCollection
			Return Me.O__oo_OO.O_.().Items
		End Function

		' Token: 0x06003E0A RID: 15882 RVA: 0x001AE7B3 File Offset: 0x001AC9B3
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O__oo_OO.O_.().DisplayMember
		End Function

		' Token: 0x06003E0B RID: 15883 RVA: 0x001AE7C0 File Offset: 0x001AC9C0
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O__oo_OO.O_.().DisplayMember = A_0
		End Sub

		' Token: 0x06003E0C RID: 15884 RVA: 0x001AE7CE File Offset: 0x001AC9CE
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O__oo_OO.O_.().ValueMember
		End Function

		' Token: 0x06003E0D RID: 15885 RVA: 0x001AE7DB File Offset: 0x001AC9DB
		Public Overloads Sub <<EMPTY_NAME>>(A_0 As String)
			Me.O__oo_OO.O_.().ValueMember = A_0
		End Sub

		' Token: 0x06003E0E RID: 15886 RVA: 0x001AE7E9 File Offset: 0x001AC9E9
		Public Function <<EMPTY_NAME>>() As Object
			Return Me.O__oo_OO.O_.().DataSource
		End Function

		' Token: 0x06003E0F RID: 15887 RVA: 0x001AE7F8 File Offset: 0x001AC9F8
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim a_ As String = Me.O_o0o0_Oo.0.()
			Me.O__oo_OO.O_.().DataSource = RuntimeHelpers.GetObjectValue(A_0)
			Me.o_O0.OO0o0O0o.(a_)
		End Sub

		' Token: 0x06003E10 RID: 15888 RVA: 0x001AE824 File Offset: 0x001ACA24
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O__oo_OO.O_.().MultiColumn
		End Function

		' Token: 0x06003E11 RID: 15889 RVA: 0x001AE831 File Offset: 0x001ACA31
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O__oo_OO.O_.().MultiColumn = A_0
		End Sub

		' Token: 0x06003E12 RID: 15890 RVA: 0x001AE83F File Offset: 0x001ACA3F
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O__oo_OO.O_.().ColumnWidth
		End Function

		' Token: 0x06003E13 RID: 15891 RVA: 0x001AE84C File Offset: 0x001ACA4C
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O__oo_OO.O_.().ColumnWidth = A_0
		End Sub

		' Token: 0x06003E14 RID: 15892 RVA: 0x001AE85A File Offset: 0x001ACA5A
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O.__.
		End Function

		' Token: 0x06003E15 RID: 15893 RVA: 0x001AE862 File Offset: 0x001ACA62
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O.__. = A_0
		End Sub

		' Token: 0x06003E16 RID: 15894 RVA: 0x001AE86B File Offset: 0x001ACA6B
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.ooo_.000.
		End Function

		' Token: 0x06003E17 RID: 15895 RVA: 0x001AE873 File Offset: 0x001ACA73
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.ooo_.000. = A_0
		End Sub

		' Token: 0x06003E18 RID: 15896 RVA: 0x001AE87C File Offset: 0x001ACA7C
		Public Function <<EMPTY_NAME>>() As Integer
			Return Me.O0_0oo.___o.
		End Function

		' Token: 0x06003E19 RID: 15897 RVA: 0x001AE884 File Offset: 0x001ACA84
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O0_0oo.___o. = A_0
		End Sub

		' Token: 0x06003E1A RID: 15898 RVA: 0x001AE890 File Offset: 0x001ACA90
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DropDownClosedEventArgs)
			If Me.DropDownForm IsNot Me.O.oO. Then
				Me.DropDownForm = Me.O.oO.
			End If
			If Me.OO0._0O.() IsNot Nothing And Me.Oo00.O_O0OO___. Then
				Me.Oo00.O_O0OO___. = False
				CType(Me.OO0._0O.(), DataView).RowFilter = Me.O.oO.
			End If
			If Me.oo__Oo_.oO. <> Me.O__oo_OO.O_.().SelectedIndex AndAlso MyBase.UpdateValueWithCurrentText() AndAlso MyBase.DataBindings.Count > 0 Then
				MyBase.DataBindings(0).WriteValue()
			End If
		End Sub

		' Token: 0x06003E1B RID: 15899 RVA: 0x001AE920 File Offset: 0x001ACB20
		Friend Sub <<EMPTY_NAME>>()
			If Me.DropDownForm Is Me.O.oO. Then
				Me.oo__Oo_.oO. = True
				If Me.Value Is Nothing Then
					Me.O__oo_OO.O_.().SelectedIndex = -1
				ElseIf Me.O__oo_OO.O_.().DataSource Is Nothing Then
					Me.O__oo_OO.O_.().SelectedIndex = Me.O__oo_OO.O_.().FindStringExact(Me.Value.ToString())
				Else
					Me.O__oo_OO.O_.().SelectedIndex = CType(Me.O__oo_OO.O_.().DataSource, DataView).Find(RuntimeHelpers.GetObjectValue(Me.Value))
				End If
				Me.oo__Oo_.oO. = False
				If Me.O.oOo.() > 0 Then
					Me.O.oO..Width = Math.Max(60, Me.O.oOo.())
				Else
					Me.O.oO..Width = Math.Max(60, MyBase.Width)
				End If
				Dim num As Integer = Math.Min(Me.o0Oo_.o_.(), Math.Max(1, Me.O__oo_OO.O_.().Items.Count))
				If Me.O_o0o0_Oo.0.() > 0 Then
					num = Math.Min(num, CInt(Convert.ToInt16(Math.Floor(CDbl((Me.O_o0o0_Oo.0.() - 4)) / CDbl(Me.O__oo_OO.O_.().ItemHeight)))))
				End If
				num = Math.Max(1, Math.Min(num, Me.O__oo_OO.O_.().Items.Count))
				Me.O.oO..OOOO.0.().Height = Me.O.oO..OOOO.0.().ItemHeight * num + 4
				Me.O.oO..Height = Me.O.oO..OOOO.0.().Height
				Me.oo__Oo_.oO. = Me.O__oo_OO.O_.().SelectedIndex
			End If
		End Sub

		' Token: 0x06003E1C RID: 15900 RVA: 0x001AEAB7 File Offset: 0x001ACCB7
		Friend Function <<EMPTY_NAME>>() As Integer
			Return Me.O.oO..O0o0o.o.()
		End Function

		' Token: 0x06003E1D RID: 15901 RVA: 0x001AEAC4 File Offset: 0x001ACCC4
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O.oO..OOOO.0.(A_0)
		End Sub

		' Token: 0x06003E1E RID: 15902 RVA: 0x001AEAD4 File Offset: 0x001ACCD4
		Public Function <<EMPTY_NAME>>() As Integer
			Dim result As Integer
			If MyBase.DroppedDown OrElse Me.O.oO..Visible Then
				result = Me.O__oo_OO.O_.().SelectedIndex
			ElseIf Me.Value Is Nothing Then
				result = -1
			ElseIf Me.OO0._0O.() Is Nothing Then
				result = Me.O_o0o0_Oo.0.().IndexOf(RuntimeHelpers.GetObjectValue(Me.Value))
			Else
				result = CType(Me.OO0._0O.(), DataView).Find(RuntimeHelpers.GetObjectValue(Me.Value))
			End If
			Return result
		End Function

		' Token: 0x06003E1F RID: 15903 RVA: 0x001AEB50 File Offset: 0x001ACD50
		Public Sub <<EMPTY_NAME>>(A_0 As Integer)
			If MyBase.DroppedDown Then
				Me.O__oo_OO.O_.().SelectedIndex = A_0
				Return
			End If
			If A_0 = -1 Then
				Me.Value = Nothing
				Return
			End If
			If Me.O__oo_OO.O_.().DataSource Is Nothing Then
				Me.Value = RuntimeHelpers.GetObjectValue(Me.O__oo_OO.O_.().Items(A_0))
				Return
			End If
			Me.Value = RuntimeHelpers.GetObjectValue(CType(Me.OO0._0O.(), DataView)(A_0)(Me.Ooo_O__.0o.()))
		End Sub

		' Token: 0x06003E20 RID: 15904 RVA: 0x001AEBD0 File Offset: 0x001ACDD0
		Public Function <<EMPTY_NAME>>() As Object
			Dim result As Object
			If MyBase.DroppedDown OrElse Me.O.oO..Visible Then
				If Me.O__oo_OO.O_.().SelectedIndex = -1 Then
					result = Nothing
				ElseIf Me.OO0._0O.() Is Nothing Then
					result = Me.O__oo_OO.O_.().SelectedItem
				Else
					result = New DataRow(CType(Me.O__oo_OO.O_.().SelectedItem, DataRowView).Row)
				End If
			ElseIf Me.Value Is Nothing Then
				result = Nothing
			ElseIf Me.OO0._0O.() Is Nothing Then
				If Me.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(Me.Value)) Then
					result = Me.Value
				Else
					result = Nothing
				End If
			Else
				Dim num As Integer = CType(Me.OO0._0O.(), DataView).Find(RuntimeHelpers.GetObjectValue(Me.Value))
				If num >= 0 Then
					result = New DataRow(CType(Me.OO0._0O.(), DataView)(num).Row)
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		' Token: 0x06003E21 RID: 15905 RVA: 0x001AECB8 File Offset: 0x001ACEB8
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			If MyBase.DroppedDown Then
				If A_0 Is Nothing Then
					Me.O__oo_OO.O_.().SelectedIndex = -1
					Return
				End If
				If Me.OO0._0O.() IsNot Nothing Then
					Dim dataRow As DataRow = CType(A_0, DataRow)
					Dim num As Integer = CType(Me.OO0._0O.(), DataView).Find(RuntimeHelpers.GetObjectValue(dataRow(Me.Ooo_O__.0o.())))
					If num >= 0 Then
						Me.O_.oOO00.(num)
					End If
					Return
				End If
				If Me.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(A_0)) Then
					Me.O__oo_OO.O_.().SelectedIndex = Me.O_o0o0_Oo.0.().IndexOf(RuntimeHelpers.GetObjectValue(A_0))
					Return
				End If
			Else
				If A_0 Is Nothing Then
					Me.Value = Nothing
					Return
				End If
				If Me.OO0._0O.() Is Nothing Then
					If Me.O_o0o0_Oo.0.().Contains(RuntimeHelpers.GetObjectValue(A_0)) Then
						Me.Value = RuntimeHelpers.GetObjectValue(A_0)
						Return
					End If
				Else
					Dim dataRow2 As DataRow = CType(A_0, DataRow)
					If CType(Me.OO0._0O.(), DataView).Find(RuntimeHelpers.GetObjectValue(dataRow2(Me.Ooo_O__.0o.()))) >= 0 Then
						Me.Value = RuntimeHelpers.GetObjectValue(dataRow2(Me.Ooo_O__.0o.()))
					End If
				End If
			End If
		End Sub

		' Token: 0x06003E22 RID: 15906 RVA: 0x001AEDCC File Offset: 0x001ACFCC
		Public Function <<EMPTY_NAME>>() As Object
			Dim result As Object
			If Me.OO0._0O.() Is Nothing Then
				result = Me.Ooo_O__.0o.()
			Else
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.Ooo_O__.0o.())
				If objectValue Is Nothing Then
					result = Nothing
				Else
					result = CType(objectValue, DataRow)(Me.Ooo_O__.0o.())
				End If
			End If
			Return result
		End Function

		' Token: 0x06003E23 RID: 15907 RVA: 0x001AEE10 File Offset: 0x001AD010
		Public Sub <<EMPTY_NAME>>(A_0 As Object)
			If A_0 IsNot Nothing AndAlso Me.OO0._0O.() IsNot Nothing Then
				Dim num As Integer = CType(Me.OO0._0O.(), DataView).Find(RuntimeHelpers.GetObjectValue(A_0))
				If num >= 0 Then
					A_0 = New DataRow(CType(Me.OO0._0O.(), DataView)(num).Row)
				Else
					A_0 = Nothing
				End If
			End If
			Me.o.OOoOo_00O.(RuntimeHelpers.GetObjectValue(A_0))
		End Sub

		' Token: 0x06003E24 RID: 15908 RVA: 0x001AEE73 File Offset: 0x001AD073
		Public Function <<EMPTY_NAME>>() As Boolean
			Return Me.O__oo_OO.O_.().FormattingEnabled
		End Function

		' Token: 0x06003E25 RID: 15909 RVA: 0x001AEE80 File Offset: 0x001AD080
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.O__oo_OO.O_.().FormattingEnabled = A_0
		End Sub

		' Token: 0x06003E26 RID: 15910 RVA: 0x001AEE8E File Offset: 0x001AD08E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O0_0oo.___o.()
			If Me.DropDownForm IsNot Nothing Then
				Me.DropDownForm.Owner = Nothing
			End If
		End Sub

		' Token: 0x06003E27 RID: 15911 RVA: 0x001AEEAC File Offset: 0x001AD0AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO_0O.o_O0.O_.(Me, Me.O__oo_OO.O_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			If MyBase.[ReadOnly] Then
				If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 AndAlso Me.DataType Is GetType(DateTime) Then
					MyBase.DisplayFormat.FormatType = 2
					Return
				End If
				MyBase.DisplayFormat.FormatType = 0
				Return
			Else
				If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 AndAlso Me.DataType Is GetType(DateTime) Then
					MyBase.EditFormat.FormatType = 2
					MyBase.EditFormat.CustomFormat = MyBase.DisplayFormat.CustomFormat
					Return
				End If
				MyBase.EditFormat.FormatType = 0
				MyBase.EditFormat.CustomFormat = ""
				Return
			End If
		End Sub

		' Token: 0x06003E28 RID: 15912 RVA: 0x001AEF88 File Offset: 0x001AD188
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O__oo_OO.O_.().Font = Me.Font
		End Sub

		' Token: 0x06003E29 RID: 15913 RVA: 0x001AEF9C File Offset: 0x001AD19C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If MyBase.DataBindings.Count > 0 AndAlso MyBase.DataBindings(0).BindingManagerBase.Count = 0 Then
				MyBase.[ReadOnly] = True
				Return
			End If
			ooO_0O.o_O0.O_.(Me, Me.O__oo_OO.O_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
			Me.O0_0oo.___o.()
			If Me.o_0.__. Then
				Me.oOOO_.o.()
			End If
		End Sub

		' Token: 0x06003E2A RID: 15914 RVA: 0x001AF004 File Offset: 0x001AD204
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If A_1.KeyCode = Keys.Space AndAlso (Operators.CompareString(Me.Text, "", True) = 0 OrElse Not Me.oo0.ooo.()) AndAlso Not MyBase.DroppedDown Then
				A_1.Handled = True
				A_1.SuppressKeyPress = True
				Me.OpenDropDown()
				Me.O.oO..Focus()
				SendKeys.Send("{DOWN}")
				If Me.O.oO..OOOO.0.().Items.Count > 0 Then
					Me.O.oO..OOOO.0.().SelectedIndex = 0
					Return
				End If
			Else
				If Not Me.oo0.ooo.() AndAlso A_1.KeyCode = Keys.Delete Then
					A_1.Handled = True
					A_1.SuppressKeyPress = True
					Return
				End If
				If A_1.Control AndAlso A_1.KeyCode = Keys.[Return] Then
					A_1.Handled = True
					A_1.SuppressKeyPress = True
					Me.SelectedText = ""
					If Operators.CompareString(Me.Text, "", True) = 0 Then
						Me.OpenDropDown()
						Return
					End If
					If A_1.Shift Then
						Me.oOOO_.o.()
					End If
					If Me.OO0._0O.() IsNot Nothing Then
						Dim dataView As DataView = CType(Me.OO0._0O.(), DataView)
						Me.Oo00.O_O0OO___. = True
						Me.O.oO. = dataView.RowFilter
						If Operators.CompareString(Me.O.oO., "", True) > 0 Then
							dataView.RowFilter = String.Concat(New String() { Me.O.oO., " And [", Me.Ooo_O__.0o.(), "] Like '*", Me.Text, "*'" })
						Else
							dataView.RowFilter = String.Concat(New String() { "[", Me.Ooo_O__.0o.(), "] Like '*", Me.Text, "*'" })
						End If
						If dataView.Count = 0 Then
							Me.Oo00.O_O0OO___. = False
							dataView.RowFilter = Me.O.oO.
							Me.O.oO. = ""
						End If
						Me.OpenDropDown()
						If Me.DropDownForm IsNot Nothing Then
							Dim o_u30000_u3002_u3002O As O\u30000\u3002\u3002O = CType(Me.DropDownForm, O\u30000\u3002\u3002O)
							o_u30000_u3002_u3002O.OOOO.0.().[Select]()
							If o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex < 0 AndAlso o_u30000_u3002_u3002O.OOOO.0.().Items.Count > 0 Then
								o_u30000_u3002_u3002O.OOOO.0.().SelectedIndex = 0
							End If
							Return
						End If
					ElseIf Me.O_o0o0_Oo.0.() IsNot Nothing Then
						Dim list As List(Of String) = New List(Of String)()
						Try
							For Each value As Object In Me.O_o0o0_Oo.0.()
								Dim text As String = Conversions.ToString(value)
								If text.IndexOf(Me.Text, StringComparison.CurrentCultureIgnoreCase) >= 0 Then
									list.Add(text)
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If list.Count > 1 OrElse (list.Count = 1 AndAlso Operators.CompareString(Me.Text, list(0), True) <> 0) Then
							Dim o_u30000_u3002_u3002O2 As O\u30000\u3002\u3002O = New O\u30000\u3002\u3002O()
							o_u30000_u3002_u3002O2.OOOO.0.().Items.AddRange(list.ToArray())
							o_u30000_u3002_u3002O2.OOOO.0.().Font = Me.Font
							Me.O.oO..OOOO.0.().SelectedIndex = 0
							If Me.O.oOo.() > 0 Then
								o_u30000_u3002_u3002O2.Width = Math.Max(60, Me.O.oOo.())
							Else
								o_u30000_u3002_u3002O2.Width = Math.Max(60, MyBase.Width)
							End If
							o_u30000_u3002_u3002O2.OOOO.0.().Height = Math.Min(Me.o0Oo_.o_.(), list.Count) * Me.O.oO..OOOO.0.().ItemHeight + 4
							o_u30000_u3002_u3002O2.Height = o_u30000_u3002_u3002O2.OOOO.0.().Height
							Me.DropDownForm = o_u30000_u3002_u3002O2
						End If
						Me.OpenDropDown()
						If Me.DropDownForm IsNot Nothing Then
							Dim o_u30000_u3002_u3002O3 As O\u30000\u3002\u3002O = CType(Me.DropDownForm, O\u30000\u3002\u3002O)
							o_u30000_u3002_u3002O3.OOOO.0.().[Select]()
							If o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex < 0 AndAlso o_u30000_u3002_u3002O3.OOOO.0.().Items.Count > 0 Then
								o_u30000_u3002_u3002O3.OOOO.0.().SelectedIndex = 0
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06003E2B RID: 15915 RVA: 0x001AF408 File Offset: 0x001AD608
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyPressEventArgs)
			If Not Me.oo0.ooo.() Then
				A_1.Handled = True
				A_1.KeyChar = vbNullChar
				Return
			End If
			If Me.o_0.__. Then
				Me.oOOO_.o.()
			End If
		End Sub

		' Token: 0x17000D8D RID: 3469
		' (get) Token: 0x06003E2C RID: 15916 RVA: 0x001AF430 File Offset: 0x001AD630
		' (set) Token: 0x06003E2D RID: 15917 RVA: 0x001AF456 File Offset: 0x001AD656
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

		' Token: 0x06003E2E RID: 15918 RVA: 0x001AF464 File Offset: 0x001AD664
		Private Sub <<EMPTY_NAME>>()
			If MyBase.AutoCompleteMode <> AutoCompleteMode.None Then
				Dim list As List(Of String) = New List(Of String)()
				MyBase.AutoCompleteCustomSource.Clear()
				If Me.OO0._0O.() IsNot Nothing Then
					Dim dataView As DataView = CType(Me.OO0._0O.(), DataView)
					Dim num As Integer = dataView.Count - 1
					For i As Integer = 0 To num
						If Not dataView(i).Row.IsNull(Me.Ooo_O__.0o.()) Then
							list.Add(dataView(i)(Me.Ooo_O__.0o.()).ToString())
						End If
					Next
				Else
					Try
						For Each value As Object In Me.O_o0o0_Oo.0.()
							Dim item As String = Conversions.ToString(value)
							list.Add(item)
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				MyBase.AutoCompleteCustomSource.AddRange(list.ToArray())
				Me.o_0.__. = False
			End If
		End Sub

		' Token: 0x06003E2F RID: 15919 RVA: 0x001AF560 File Offset: 0x001AD760
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Not Me.oo__Oo_.oO. Then
				Dim o_o_.O. As OoOO0Oo_oo0oO.o0__0 = Me.O_o_.O.
				If o_o_.O. IsNot Nothing Then
					o_o_.O.(Me, A_1)
				End If
			End If
		End Sub

		' Token: 0x06003E30 RID: 15920 RVA: 0x001AF588 File Offset: 0x001AD788
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ListControlConvertEventArgs)
			Dim o.oO. As OoOO0Oo_oo0oO.oo0O00O = Me.O.oO.
			If o.oO. IsNot Nothing Then
				o.oO.(Me, A_1)
			End If
		End Sub

		' Token: 0x06003E31 RID: 15921 RVA: 0x001AF5A7 File Offset: 0x001AD7A7
		Public Sub <<EMPTY_NAME>>() Implements Foxtable.O000O.SetReadOnlyProperty
			ooO_0O.o_O0.O_.(Me, Me.O__oo_OO.O_.())
			MyBase.[ReadOnly] = MyBase.[ReadOnly]
		End Sub

		' Token: 0x06003E32 RID: 15922 RVA: 0x001AF5C4 File Offset: 0x001AD7C4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As String = "DataFormat_" + Conversions.ToString(MyBase.Tag)
			If oOO0oo_o0.o.O0o000_.(Me, a_) Then
				MyBase.DisplayFormat.FormatType = 1
				Return
			End If
			If Operators.CompareString(MyBase.DisplayFormat.CustomFormat, "", True) > 0 Then
				MyBase.DisplayFormat.FormatType = 2
				Return
			End If
			MyBase.DisplayFormat.FormatType = 0
		End Sub

		' Token: 0x17000D8E RID: 3470
		' (get) Token: 0x06003E33 RID: 15923 RVA: 0x001AF62F File Offset: 0x001AD82F
		' (set) Token: 0x06003E34 RID: 15924 RVA: 0x001AF637 File Offset: 0x001AD837
		Public Property Value2 As Object
			Get
				Return Me.Value
			End Get
			Set(value As Object)
				Me.Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x06003E35 RID: 15925 RVA: 0x001AF645 File Offset: 0x001AD845
		Public Function <<EMPTY_NAME>>() As Boolean Implements Foxtable.O000O.OoO.Oo0O0o.
			Return Me.o00_.o_Oo_.
		End Function

		' Token: 0x06003E36 RID: 15926 RVA: 0x001AF64D File Offset: 0x001AD84D
		Public Sub <<EMPTY_NAME>>(A_0 As Boolean) Implements Foxtable.O000O.OoO.Oo0O0o.
			Me.o00_.o_Oo_. = A_0
		End Sub

		' Token: 0x0400192F RID: 6447
		Private <<EMPTY_NAME>> As BooleanEnum

		' Token: 0x04001930 RID: 6448
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001931 RID: 6449
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001932 RID: 6450
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001933 RID: 6451
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001934 RID: 6452
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001935 RID: 6453
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.ListBox

		' Token: 0x04001936 RID: 6454
		Private <<EMPTY_NAME>> As O\u30000\u3002\u3002O

		' Token: 0x04001937 RID: 6455
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001938 RID: 6456
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001939 RID: 6457
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OoOO0Oo_oo0oO.o0__0

		' Token: 0x0400193A RID: 6458
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OoOO0Oo_oo0oO.oo0O00O

		' Token: 0x0400193B RID: 6459
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400193C RID: 6460
		Private Shared <<EMPTY_NAME>> As String = ""

		' Token: 0x0400193D RID: 6461
		Private Shared <<EMPTY_NAME>> As String = ""

		' Token: 0x0400193E RID: 6462
		Private Shared <<EMPTY_NAME>> As DataRow

		' Token: 0x0400193F RID: 6463
		Private Shared <<EMPTY_NAME>> As String = "("

		' Token: 0x04001940 RID: 6464
		Private Shared <<EMPTY_NAME>> As String = ")"

		' Token: 0x04001941 RID: 6465
		Private Shared <<EMPTY_NAME>> As String

		' Token: 0x04001942 RID: 6466
		Private Shared <<EMPTY_NAME>> As Integer = 7

		' Token: 0x04001943 RID: 6467
		Private Shared <<EMPTY_NAME>> As String

		' Token: 0x04001944 RID: 6468
		Friend <<EMPTY_NAME>> As Foxtable.WinForm.Form

		' Token: 0x04001945 RID: 6469
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001946 RID: 6470
		Private Const <<EMPTY_NAME>> As Integer = 770

		' Token: 0x04001947 RID: 6471
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x020003CC RID: 972
		' (Invoke) Token: 0x06003E3A RID: 15930
		Public Delegate Sub o0__0(A_0 As Object, A_1 As EventArgs)

		' Token: 0x020003CD RID: 973
		' (Invoke) Token: 0x06003E3E RID: 15934
		Public Delegate Sub oo0O00O(A_0 As Object, A_1 As ListControlConvertEventArgs)
	End Class
End Namespace
