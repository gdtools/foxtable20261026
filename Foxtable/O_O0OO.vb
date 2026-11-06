Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports Foxtable.My
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports Office2007Renderer

Namespace Foxtable
	' Token: 0x020004CC RID: 1228
	Friend NotInheritable Module O_O0OO
		' Token: 0x06004EC0 RID: 20160 RVA: 0x00209DC4 File Offset: 0x00207FC4
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 0
			If Operators.CompareString(O_O0OO.OoOO0oO00.00_o., "", True) = 0 Then
				O_O0OO.OoOO0oO00.00_o. = O00.DecryptText(O_O0OO.o0O0o.Oo_o00o., O00OOOo_O0_O.b("ﾏ", a_), O00OOOo_O0_O.b("揄", a_))
			End If
			Return O_O0OO.OoOO0oO00.00_o.
		End Function

		' Token: 0x06004EC1 RID: 20161
		Private Declare Function FindPort_2 Lib "Interop.ADOSC.dll" (A_0 As Integer, A_1 As Integer, A_2 As Integer, A_3 As StringBuilder) As Integer

		' Token: 0x06004EC2 RID: 20162
		Private Declare Function EncString Lib "Interop.ADOSC.dll" (A_0 As String, A_1 As StringBuilder, A_2 As String) As Integer

		' Token: 0x06004EC3 RID: 20163
		Private Declare Function GetID Lib "Interop.ADOSC.dll" (ByRef A_0 As Integer, ByRef A_1 As Integer, A_2 As String) As Integer

		' Token: 0x06004EC4 RID: 20164
		Private Declare Function YRead Lib "Interop.ADOSC.dll" (ByRef A_0 As Byte, A_1 As Short, A_2 As Short, A_3 As String, A_4 As String, A_5 As String) As Integer

		' Token: 0x06004EC5 RID: 20165 RVA: 0x00209E1C File Offset: 0x0020801C
		Shared Sub New()
			Dim a_ As Integer = 2
			O_O0OO.Oo0.OoOo. = New List(Of O_0)()
			O_O0OO.Oo0.OoOo. = New Dictionary(Of String, o__o_OO_o_)()
			O_O0OO.OOo_o.0o. = True
			O_O0OO.O_OO.OO. = True
			O_O0OO.O0_00o.o0__o. = New ProjectProperty()
			O_O0OO.o.0__0_O_. = Foxtable.My.Resources.a.ooO_.O0.().ToBitmap()
			O_O0OO.O_O00OOooo.O_. = Foxtable.My.Resources.a.ooO.Oo.().ToBitmap()
			O_O0OO.O0OO_.0. = False
			O_O0OO.O0_00o.o0__o. = New DataTable()
			O_O0OO.o0OoO00OO.00O. = New List(Of String)()
			O_O0OO.o_Oo0_oOo.0. = True
			O_O0OO.Oo_o000oO.oO. = O00OOOo_O0_O.b("햏ꞑ궓ꂕ�ꎙꪛꞝ骡钥颧馩颫肯花", a_)
			O_O0OO.oO_00Ooo___0._. = New List(Of String)()
			O_O0OO.o_Oo0_oOo.0. = O00OOOo_O0_O.b("�쾙ﮝ튟얣튥즧ﺩ춫청�ힱ", a_)
			O_O0OO.oO__._0_0O0o0. = O00OOOo_O0_O.b("ﶏꆓ", a_)
			O_O0OO.OO.o_. = O00OOOo_O0_O.b("�욕ꎙ쾛�讟쒡螧鮩풭�芵쮷膻莽", a_)
			O_O0OO.O00O0o_O_._O. = True
			O_O0OO.O0_00o.o0__o. = New Dictionary(Of String, Bitmap)()
			O_O0OO.O0_00o.o0__o. = Foxtable.My.Resources.a.o_OOo0O._0o.().ToBitmap()
			O_O0OO.O_oO_o0O.o__. = False
			O_O0OO.O_.00. = O00OOOo_O0_O.b("�ﾕﮗﾙ꺛꺝醟醡풥춧쾩슫", a_)
			O_O0OO.Oo._00O0_oO. = O00OOOo_O0_O.b("�ﾕﮗﾙ꺛꺝醟醡풥춧쾩슫", a_)
			O_O0OO.o_.oO_O0. = O00OOOo_O0_O.b("욏솑ꚓꚕꦗꦙ�얟잡쪣", a_)
			O_O0OO.oo_oo_o._. = O00OOOo_O0_O.b("ᯔ쇞", a_)
			O_O0OO.oO_00Ooo___0._. = 9
			O_O0OO.O0_00o.o0__o. = Color.Transparent
			O_O0OO.oo0_o_.o. = Color.Transparent
			O_O0OO.o0O._O00o. = False
			O_O0OO.o0OoO00OO.00O. = New oOo_00o0o00_0()
			O_O0OO.ooO0oO0O.o_O_. = O00OOOo_O0_O.b("ﺙ얟잡힣즥򹺩", a_)
			O_O0OO.OoO._oO0. = O00OOOo_O0_O.b("햏즙ﮝ", a_)
			O_O0OO.o0O0o.Oo_o00o. = O00OOOo_O0_O.b("쪏햑ꖓ릕첗횝辟춣좥�隭튳햵ﲹ캽趿ꗁ뗃迅采￉ꇋ觍", a_)
			O_O0OO.OoOO0oO00.00_o. = ""
			O_O0OO.oO_00Ooo___0._. = ""
			o_O_o_oOoo__.Oo_0.OOo0oO0..AddRange(New String() { ooO0__OO.OOo0._00O_o00.(), ooO0__OO.o0O._ooo_O_.(), ooO0__OO.O_O00.0_.(), ooO0__OO.O0.ooO0O.(), ooO0__OO.o0o.o.(), ooO0__OO.O0O.0o0.(), ooO0__OO.oo._o.(), ooO0__OO.O0_.OOo0OO.(), ooO0__OO.o_0_000._O.(), ooO0__OO.O00.O__o.(), ooO0__OO.Oo0o0.oo_0.(), ooO0__OO.oo._O.(), ooO0__OO.o.00_0o0__OoO.() })
			o_O_o_oOoo__.oO.O_..AddRange(New String() { O00OOOo_O0_O.b("쾏��", a_), O00OOOo_O0_O.b("쾏�ﮓﾙ", a_), O00OOOo_O0_O.b("쎏ﶗ쎛춝쾟킡킣殮ﲧ쾩솫��삱햳쒵솷", a_), O00OOOo_O0_O.b("쎏ﶗ쎛�즟캡킣쎥�쮭�슱�쒵�좹얻", a_), O00OOOo_O0_O.b("쎏ﶗ쎛�즟캡킣쎥�嶺삭�쎱솳펵", a_), O00OOOo_O0_O.b("쾏솑ﮓ톙鍊", a_), O00OOOo_O0_O.b("즕킗鍊솟킡잣캥톧쮭욯ힱ�", a_) })
			O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("첏�煉ﾗﾙ슝", a_)
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("쎏쎕ﺙﶛ얟횣쾥욧�삭횯�", a_), GetType(Boolean), True)
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("쎏쎕ﺙﶛ얟쎣솥�쾩쮫쾭쒯ힱ", a_), GetType(Boolean), False)
			OO_00oOO.Vars.o.O0o_O.(O00OOOo_O0_O.b("쎏햕ﾝ풟쮡얣쒥쒧쾩쎭햯ﾱ�튵�", a_), GetType(Boolean), False)
			o0OoOOoOOo0.O_00o0.O0OO_0. = O00.oO_.0o_oo_0O_.(SysInfo.ConnectName, O00OOOo_O0_O.b("", a_), O00OOOo_O0_O.b("歹ﶗ", a_)).Split(New Char() { "."c })
			o0OoOOoOOo0.O_00o0.O0OO_0. = New Object() { 0S, 888, Conversions.ToInteger(O00.oO_.0o_oo_0O_.(SysInfo.ConnectType, O00OOOo_O0_O.b("", a_), O00OOOo_O0_O.b("歹ﶗ", a_))), o0OoOOoOOo0.o0O.0_. }
		End Sub

		' Token: 0x06004EC6 RID: 20166 RVA: 0x0020A218 File Offset: 0x00208418
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 13
			Return OO_00oOO.ProjectPath + O00OOOo_O0_O.b("잚튠힢삤쪦", a_) + ooO0__OO.o_0O._OO__.()
		End Function

		' Token: 0x06004EC7 RID: 20167 RVA: 0x0020A24D File Offset: 0x0020844D
		Friend Function <<EMPTY_NAME>>() As O0OO_oo0o
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New O0OO_oo0o()
			ElseIf O_O0OO.o.O___o00o0O..Disposing OrElse O_O0OO.o.O___o00o0O..IsDisposed Then
				O_O0OO.o.O___o00o0O. = New O0OO_oo0o()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004EC8 RID: 20168 RVA: 0x0020A289 File Offset: 0x00208489
		Friend Sub <<EMPTY_NAME>>(A_0 As O0OO_oo0o)
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004EC9 RID: 20169 RVA: 0x0020A291 File Offset: 0x00208491
		Friend Function <<EMPTY_NAME>>() As Oooo
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New Oooo()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New Oooo()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ECA RID: 20170 RVA: 0x0020A2CD File Offset: 0x002084CD
		Friend Function <<EMPTY_NAME>>() As o__o_O_o0o0__
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New o__o_O_o0o0__()
			ElseIf O_O0OO.o.O___o00o0O..Disposing OrElse O_O0OO.o.O___o00o0O..IsDisposed Then
				O_O0OO.o.O___o00o0O. = New o__o_O_o0o0__()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004ECB RID: 20171 RVA: 0x0020A309 File Offset: 0x00208509
		Friend Sub <<EMPTY_NAME>>(A_0 As o__o_O_o0o0__)
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004ECC RID: 20172 RVA: 0x0020A311 File Offset: 0x00208511
		Friend Function <<EMPTY_NAME>>() As O0_oOoo
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New O0_oOoo()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New O0_oOoo()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ECD RID: 20173 RVA: 0x0020A34D File Offset: 0x0020854D
		Friend Function <<EMPTY_NAME>>() As OOoOO_00O00
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New OOoOO_00O00()
			ElseIf O_O0OO.o.O___o00o0O..Disposing OrElse O_O0OO.o.O___o00o0O..IsDisposed Then
				O_O0OO.o.O___o00o0O. = New OOoOO_00O00()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004ECE RID: 20174 RVA: 0x0020A389 File Offset: 0x00208589
		Friend Sub <<EMPTY_NAME>>(A_0 As OOoOO_00O00)
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004ECF RID: 20175 RVA: 0x0020A391 File Offset: 0x00208591
		Friend Function <<EMPTY_NAME>>() As Ooo0__
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New Ooo0__()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New Ooo0__()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ED0 RID: 20176 RVA: 0x0020A3CD File Offset: 0x002085CD
		Friend Function <<EMPTY_NAME>>() As OO__oo_0ooo0_
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New OO__oo_0ooo0_()
			ElseIf O_O0OO.o.O___o00o0O..Disposing OrElse O_O0OO.o.O___o00o0O..IsDisposed Then
				O_O0OO.o.O___o00o0O. = New OO__oo_0ooo0_()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004ED1 RID: 20177 RVA: 0x0020A409 File Offset: 0x00208609
		Friend Sub <<EMPTY_NAME>>(A_0 As OO__oo_0ooo0_)
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004ED2 RID: 20178 RVA: 0x0020A411 File Offset: 0x00208611
		Friend Function <<EMPTY_NAME>>() As oo0O0o___O
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New oo0O0o___O()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New oo0O0o___O()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ED3 RID: 20179 RVA: 0x0020A44D File Offset: 0x0020864D
		Friend Function <<EMPTY_NAME>>() As o0o0OO
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New o0o0OO()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New o0o0OO()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ED4 RID: 20180 RVA: 0x0020A489 File Offset: 0x00208689
		Friend Function <<EMPTY_NAME>>() As O0OooO0_0O
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New O0OooO0_0O()
			ElseIf O_O0OO.o.O___o00o0O..Disposing OrElse O_O0OO.o.O___o00o0O..IsDisposed Then
				O_O0OO.o.O___o00o0O. = New O0OooO0_0O()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004ED5 RID: 20181 RVA: 0x0020A4C5 File Offset: 0x002086C5
		Friend Function <<EMPTY_NAME>>() As O0o__o0_o0
			If O_O0OO.OoO_0.OoO. Is Nothing Then
				O_O0OO.OoO_0.OoO. = New O0o__o0_o0()
			ElseIf O_O0OO.OoO_0.OoO..Disposing OrElse O_O0OO.OoO_0.OoO..IsDisposed Then
				O_O0OO.OoO_0.OoO. = New O0o__o0_o0()
			End If
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ED6 RID: 20182 RVA: 0x0020A501 File Offset: 0x00208701
		Friend Function <<EMPTY_NAME>>() As OleDbConnection
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004ED7 RID: 20183 RVA: 0x0020A508 File Offset: 0x00208708
		Friend Sub <<EMPTY_NAME>>(A_0 As OleDbConnection)
			O_O0OO.OoO_0.OoO. = A_0
		End Sub

		' Token: 0x06004ED8 RID: 20184 RVA: 0x0020A510 File Offset: 0x00208710
		Friend Function <<EMPTY_NAME>>() As DataSet
			Return O_O0OO.Oo0.OoOo.
		End Function

		' Token: 0x06004ED9 RID: 20185 RVA: 0x0020A517 File Offset: 0x00208717
		Friend Sub <<EMPTY_NAME>>(A_0 As DataSet)
			O_O0OO.Oo0.OoOo. = A_0
		End Sub

		' Token: 0x06004EDA RID: 20186 RVA: 0x0020A51F File Offset: 0x0020871F
		Friend Function <<EMPTY_NAME>>() As DataSet
			Return O_O0OO.O__O.oo.
		End Function

		' Token: 0x06004EDB RID: 20187 RVA: 0x0020A526 File Offset: 0x00208726
		Friend Sub <<EMPTY_NAME>>(A_0 As DataSet)
			O_O0OO.O__O.oo. = A_0
		End Sub

		' Token: 0x06004EDC RID: 20188 RVA: 0x0020A52E File Offset: 0x0020872E
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, O_0)
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004EDD RID: 20189 RVA: 0x0020A535 File Offset: 0x00208735
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0))
			O_O0OO.OoO_0.OoO. = A_0
		End Sub

		' Token: 0x06004EDE RID: 20190 RVA: 0x0020A53D File Offset: 0x0020873D
		Friend Function <<EMPTY_NAME>>() As List(Of O_0)
			Return O_O0OO.Oo0.OoOo.
		End Function

		' Token: 0x06004EDF RID: 20191 RVA: 0x0020A544 File Offset: 0x00208744
		Friend Sub <<EMPTY_NAME>>(A_0 As List(Of O_0))
			O_O0OO.Oo0.OoOo. = A_0
		End Sub

		' Token: 0x06004EE0 RID: 20192 RVA: 0x0020A54C File Offset: 0x0020874C
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, OleDbConnection)
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004EE1 RID: 20193 RVA: 0x0020A553 File Offset: 0x00208753
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, OleDbConnection))
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004EE2 RID: 20194 RVA: 0x0020A55B File Offset: 0x0020875B
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, O_0oOo_OO)
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004EE3 RID: 20195 RVA: 0x0020A562 File Offset: 0x00208762
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0oOo_OO))
			O_O0OO.o.O___o00o0O. = A_0
		End Sub

		' Token: 0x06004EE4 RID: 20196 RVA: 0x0020A56A File Offset: 0x0020876A
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, O0O)
			Return O_O0OO.OoO_0.OoO.
		End Function

		' Token: 0x06004EE5 RID: 20197 RVA: 0x0020A571 File Offset: 0x00208771
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O0O))
			O_O0OO.OoO_0.OoO. = A_0
		End Sub

		' Token: 0x06004EE6 RID: 20198 RVA: 0x0020A579 File Offset: 0x00208779
		Friend Function <<EMPTY_NAME>>() As String
			Return O_O0OO.o0_OO.000.(O_O0OO.OoO.0OO__0ooo.())
		End Function

		' Token: 0x06004EE7 RID: 20199 RVA: 0x0020A588 File Offset: 0x00208788
		Friend Function <<EMPTY_NAME>>(A_0 As DataSet) As String
			Dim a_ As Integer = 15
			Dim dataRow As DataRow = A_0.Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("출캠즢삤쒦�즬쪮�잲�톶삸", a_), o0_O.O_oo00.o0. })
			Dim result As String
			If dataRow IsNot Nothing Then
				result = Conversions.ToString(dataRow(O00OOOo_O0_O.b("�쾠얢첤삦", a_)))
			Else
				result = ooO0__OO.OOo0._00O_o00.()
			End If
			Return result
		End Function

		' Token: 0x06004EE8 RID: 20200 RVA: 0x0020A5FF File Offset: 0x002087FF
		Friend Function <<EMPTY_NAME>>() As Dictionary(Of String, o__o_OO_o_)
			Return O_O0OO.Oo0.OoOo.
		End Function

		' Token: 0x06004EE9 RID: 20201 RVA: 0x0020A608 File Offset: 0x00208808
		Friend Function <<EMPTY_NAME>>() As ImageList
			Dim a_ As Integer = 15
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New ImageList()
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("톜ﺞ쎠욢즤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("톜ﺞ쎠욢즤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�춠첢힤좨즪좬쎮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�춠첢힤좨즪좬쎮龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�햠힢쪤즦", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�햠힢쪤즦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜爵�힢좦톨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜爵�힢좦톨薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜철욢힦좨얪삮즰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜철욢힦좨얪삮즰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쒠삢캤욨펪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쒠삢캤욨펪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("쾜ﺞ얠쪢쪤���삮�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쾜ﺞ얠쪢쪤���삮�鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철솢쪤욨펪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�철솢쪤욨펪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쒠삢캤슦춨슬슮펰��솸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쒠삢캤슦춨슬슮펰��솸閺풼�껀", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�캠펢좦�얪삮즰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�캠펢좦�얪삮즰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("톜튠힢좦톨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("톜튠힢좦톨薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�캠횢햤욨펪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�캠횢햤욨펪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출ﺞ쾠욢즤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출ﺞ쾠욢즤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜ﺞ쎠쪤즦��슬쎮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜ﺞ쎠쪤즦��슬쎮龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("풜삠쒢삤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("풜삠쒢삤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜쒠욢캦첨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜쒠욢캦첨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜토쪢욤좨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜토쪢욤좨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("펜ﺞ힠쒤햦", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("펜ﺞ힠쒤햦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�삠톢톤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�삠톢톤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ햠욢캦쒨캪삮�톲�횸쎺", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ햠욢캦쒨캪삮�톲�횸쎺鎼횾ꋀ곂", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ햠욢캦쒨캪ﶬ욮튰�킴얶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ햠욢캦쒨캪ﶬ욮튰�킴얶鞸튺�킾", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("펜철욢힤캦쪨슬슮펰��솸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("펜철욢힤캦쪨슬슮펰��솸閺풼�껀", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출캠쒢힤슦��캮쎰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출캠쒢힤슦��캮쎰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ펠쪤쎦첨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ펠쪤쎦첨薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쒠삢캤슦춨쒬�얰�쾶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쒠삢캤슦춨쒬�얰�쾶鞸튺�킾", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜삠삢캤좨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜삠삢캤좨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("캜춠쪢톤욨얪�캮𼆲킴얶", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜춠쪢톤욨얪�캮𼆲킴얶鞸튺�킾", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜쒠욢", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쒠욢认캦쪨쒪", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ햠슢캦򺎪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ햠슢캦򺎪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜爵�힢", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜爵�힢认캦쪨쒪", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출슠힢키햦첨ﶪ쒬쪮우횲잴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출슠힢키햦첨ﶪ쒬쪮우횲잴馶킸�튼", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�춠욢욦잨쪪쪬쪮쎰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�춠욢욦잨쪪쪬쪮쎰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("쪜爵쎠힤좦��좬�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쪜爵쎠힤좦��좬�龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("쪜爵쎠첤슦�캪�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쪜爵쎠힤좦��좬�龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출ﺞ좠춢톤슦�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출ﺞ좠춢톤슦�薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ펠쪤쎦첨", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ펠쪤쎦첨薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ춠욢쮤쎦좨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ춠욢쮤쎦좨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ풠쒢삤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ풠쒢삤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�ﺞ쾠힢톤삨캪�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�ﺞ쾠힢톤삨캪�膮�킲�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출�첤슦�캪�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출�첤슦�캪�膮�킲�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("킜ﺞ토", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ﺞ토趢첤쒦욨", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("쮜ﺞ펠", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쮜ﺞ펠趢첤쒦욨", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("ﺞ", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("ﺞ辠쪢욤좦", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬�풰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ힠욢认캦쪨쒪", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨좬쎮풰잲킴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�爵춠욢톤슦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨ﺪ쎬쮮�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("좜얠첢认캦쪨쒪", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨솬욮횰�領튶�쾺", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�좠쒢쮤욨좬즮얰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨솬욮횰���펺즼", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�좠쒢쮤욨寧쒬좮�잲鮴��풺", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨솬욮횰��즸", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�좠쒢쮤욨ﾪ슬�龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨솬욮횰��춸쾺튼튾", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�좠쒢쮤욨슬�얰��馶킸�튼", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬슮풰�펶춸펺", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ철욢캦춨�얬膮�킲�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬슮풰﮲킴��펺즼", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ철욢슦삨첪얬�龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬슮풰�춶�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ철욢캦펨캪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬슮풰﮲�얶킸솺튼톾뗀ꋂ꧄铆마꫊껌꫎", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ철욢좦�슪힬삮�잲풴�쮺��꓀계꓆ꛈ", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨첬슮풰킴얶춸튺��귀郂뗄ꛆ꫈껊", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜ﺞ철욢슦󺎪쒬첮킰�잶���醾ꣀꃂ꫄", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨좬�튲ힴﺶힸ��잾", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜ﺞ쎠쮤쎦첨펪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�철캢쒤즦춨슬�펰�킴", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�풠솢즤슦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�춠횢좤즦", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�춠횢좤즦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜ﺞ쎠쾢삤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜ﺞ쎠쾢삤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("쾜爵슠첢힤쎦�쒬쮮", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("쾜爵슠첢힤쎦ﺨ슪쎬쮮�쒲鮴��풺", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜캠쾢횤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜캠쾢좦톨薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("출캠펢삤햦�튪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("출캠펢삤햦�튪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�얠욢", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쒠춢톤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쒠쾢솤", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쒠쾢솤覦삨좪슬", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("톜쾠욢", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("톜쾠욢钤醦螨슪캬삮", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("톜튠힢캦첨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("톜튠힢캦첨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쾠힢캦쪨삪좬�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쾠힢캦쪨삪좬�龰�횴�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�춠첢힤삨좪욬쪮쎰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�춠첢힤삨좪욬쪮쎰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("캜삠힢키풦쪪�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜삠힢키풦쪪�膮�킲�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("즜캠쾢욦�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("즜캠쾢욦�薪쒬첮�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("킜ﺞ좠춢슦잨�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("킜ﺞ좠춢슦잨�莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("킜爵쾠횢펦첨욪", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("킜爵쾠횢펦첨욪莬욮튰�", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("캜춠쪢톤���삮�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜춠쪢톤���삮�鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("�쾠힢삤즦�좬솮쒰", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("�쾠힢삤즦�좬솮쒰鶲�풶횸", a_)))
				O_O0OO.o.O___o00o0O..Images.Add(O00OOOo_O0_O.b("캜爵토슢힤욦�쒪�", a_), OO_00oOO.GetImage(O00OOOo_O0_O.b("캜爵토슢힤욦�쒪�膮�킲�", a_)))
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004EEA RID: 20202 RVA: 0x0020B448 File Offset: 0x00209648
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 5
			Return O00OOOo_O0_O.b("�ﺘﺚ붜�좠쾢삤풦햨膪莬욮튰�躴鶶鞸�킼쾾變ꃆꃈ귊￐맒ꗔ냖꿞迠蓢�췦쟨鿪蓬觮쫰蓲飴釶藸닺뻼냾伀缂⼄⤆怈栊戌猎匐帒䔔欖㌘㔚缜爞儠弢戤渦漨圪ܬĮ嘰娲匴䬶猸欺砼砾㵀楂歄ⵆ㥈ⱊㅌ὎ὐᑒ⥔絖睘⭚㍜㡞ᵠ㝢ⱤⅦ⽨ᝪ䝬䅮հᩲ፴୶⹸㙺㭼;ꮀ궂", a_)
		End Function

		' Token: 0x06004EEB RID: 20203 RVA: 0x0020B46C File Offset: 0x0020966C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As ImageFormat
			Dim a_ As Integer = 4
			Dim left As String = Path.GetExtension(A_0).Trim(New Char() { "."c })
			Dim result As ImageFormat
			If Operators.CompareString(left, O00OOOo_O0_O.b("煉", a_), True) = 0 Then
				result = ImageFormat.Bmp
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("煉", a_), True) = 0 Then
				result = ImageFormat.Emf
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("ﶓ", a_), True) = 0 Then
				result = ImageFormat.Gif
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("", a_), True) = 0 Then
				result = ImageFormat.Jpeg
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("望", a_), True) = 0 Then
				result = ImageFormat.Png
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("ﶓ", a_), True) = 0 Then
				result = ImageFormat.Tiff
			ElseIf Operators.CompareString(left, O00OOOo_O0_O.b("煉", a_), True) = 0 Then
				result = ImageFormat.Wmf
			Else
				result = ImageFormat.Bmp
			End If
			Return result
		End Function

		' Token: 0x06004EEC RID: 20204 RVA: 0x0020B584 File Offset: 0x00209784
		Friend Function <<EMPTY_NAME>>(A_0 As String, ByRef A_1 As Double) As Boolean
			Dim a_ As Integer = 1
			Dim num As Long = 1L
			If A_0.StartsWith(O00OOOo_O0_O.b("ꊎ", a_)) Then
				A_0 = A_0.Substring(1)
				num = -1L
			End If
			A_0 = A_0.Replace(O00OOOo_O0_O.b("镱", a_), O00OOOo_O0_O.b("떎", a_))
			Dim num2 As Long
			If A_0.IndexOf(O00OOOo_O0_O.b("꾎", a_)) > 0 Then
				If Not Long.TryParse(A_0.Substring(A_0.IndexOf(O00OOOo_O0_O.b("꾎", a_)) + 1), num2) Then
					Return False
				End If
				A_0 = A_0.Substring(0, A_0.IndexOf(O00OOOo_O0_O.b("꾎", a_)))
			End If
			Dim array As String() = A_0.Split(New Char() { ":"c })
			Dim result As Boolean
			If array.Length > 3 Then
				result = False
			Else
				Dim num3 As Integer = array.Length - 1
				Dim num4 As Long
				Dim num5 As Long
				Dim num6 As Long
				For i As Integer = 0 To num3
					If i = 0 Then
						If Not Long.TryParse(array(i), num4) Then
							Return False
						End If
					ElseIf i = 1 Then
						If Not Long.TryParse(array(i), num5) Then
							Return False
						End If
					ElseIf i = 2 AndAlso Not Long.TryParse(array(i), num6) Then
						Return False
					End If
				Next
				A_1 = CDbl((num4 * 3600L + num5 * 60L + num6)) + CDbl(num2) / 1000.0
				A_1 *= CDbl(num)
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004EED RID: 20205 RVA: 0x0020B6F0 File Offset: 0x002098F0
		Friend Function <<EMPTY_NAME>>(A_0 As Double, ByRef A_1 As String) As Boolean
			Dim a_ As Integer = 17
			Dim str As String = ""
			If A_0 < 0.0 Then
				str = O00OOOo_O0_O.b("늞", a_)
			End If
			A_0 = Math.Abs(A_0)
			Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(A_0)
			Dim num As Integer = timeSpan.Days * 24 + timeSpan.Hours
			A_1 = Strings.Format(num, O00OOOo_O0_O.b("꾞醠", a_))
			If timeSpan.Minutes > 0 OrElse timeSpan.Seconds > 0 OrElse timeSpan.Milliseconds > 0 Then
				A_1 = A_1 + O00OOOo_O0_O.b("ꖞ", a_) + Strings.Format(timeSpan.Minutes, O00OOOo_O0_O.b("꾞醠", a_))
			End If
			If timeSpan.Seconds > 0 OrElse timeSpan.Milliseconds > 0 Then
				A_1 = A_1 + O00OOOo_O0_O.b("ꖞ", a_) + Strings.Format(timeSpan.Seconds, O00OOOo_O0_O.b("꾞醠", a_))
			End If
			If timeSpan.Milliseconds > 0 Then
				A_1 = A_1 + O00OOOo_O0_O.b("뾞", a_) + Strings.Format(timeSpan.Milliseconds, O00OOOo_O0_O.b("꾞醠鎢", a_))
			End If
			A_1 = str + A_1
			Return True
		End Function

		' Token: 0x06004EEE RID: 20206 RVA: 0x0020B84D File Offset: 0x00209A4D
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return False
		End Function

		' Token: 0x06004EEF RID: 20207 RVA: 0x0020B850 File Offset: 0x00209A50
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			OO_00oOO.OOO_.OO. = A_0
		End Sub

		' Token: 0x06004EF0 RID: 20208 RVA: 0x0020B858 File Offset: 0x00209A58
		Friend Function <<EMPTY_NAME>>() As Image
			Dim a_ As Integer = 10
			If O_O0OO.a Is Nothing AndAlso OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("ﶛ瞧즟첡쎣袥쾧쎩쪫", a_)) Then
				O_O0OO.a = OO_00oOO.GetImage(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("ﶛ瞧즟첡쎣袥쾧쎩쪫", a_))
			End If
			Return O_O0OO.a
		End Function

		' Token: 0x06004EF1 RID: 20209 RVA: 0x0020B8C0 File Offset: 0x00209AC0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim a_ As Integer = 2
			Dim result As String
			If Operators.CompareString(A_0, "", True) = 0 Then
				result = Nothing
			Else
				A_0 = A_0.ToLower()
				If Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(A_0), "", True) = 0 Then
					If OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + A_0) Then
						A_0 = O_O0OO.OOo_o.0o. + A_0
					Else
						A_0 = ooO.OoO0o_o___.O.(A_0)
					End If
				End If
				If Not File.Exists(A_0) Then
					A_0 = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("첏ﮑ煉ﾗﾙ슝", a_) + c.OOOOO.o.().FileSystem.GetName(A_0)
					If Not File.Exists(A_0) Then
						Return Nothing
					End If
				End If
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06004EF2 RID: 20210 RVA: 0x0020B990 File Offset: 0x00209B90
		Friend Function <<EMPTY_NAME>>(A_0 As TimeSpan) As String
			Dim a_ As Integer = 6
			Dim text As String = ""
			If A_0.Hours > 0 Then
				text = Conversions.ToString(A_0.Hours) + O00OOOo_O0_O.b("拶", a_)
			End If
			If A_0.Minutes > 0 Then
				text = text + Conversions.ToString(A_0.Minutes) + O00OOOo_O0_O.b("鋁", a_)
			End If
			If A_0.Seconds > 0 OrElse A_0.Milliseconds > 0 Then
				Dim num As Double
				If A_0.Seconds > 0 Then
					num = CDbl(A_0.Seconds)
				End If
				If A_0.Milliseconds > 0 Then
					num += Math.Round(CDbl(A_0.Milliseconds) / 1000.0, 3)
				End If
				text = text + Conversions.ToString(num) + O00OOOo_O0_O.b("䛪", a_)
			End If
			Return text
		End Function

		' Token: 0x06004EF3 RID: 20211 RVA: 0x0020BA6C File Offset: 0x00209C6C
		Friend Sub <<EMPTY_NAME>>(ByRef A_0 As String, ByRef A_1 As String)
			Dim a_ As Integer = 4
			Dim num As Integer
			Dim num2 As Integer
			If O_O0OO.oO.__0O0oooo.() AndAlso O_O0OO.GetID(num, num2, O_O0OO.oO0_o.o0o.) = 0 Then
				num = Math.Abs(num)
				num2 = Math.Abs(num2)
			Else
				num = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.())
				num2 = Math.Abs(OoOo0O.Oo_oOO_._Oo_o.())
			End If
			num = num Mod 99999999 + 1
			num2 = num2 Mod 99999999 + 1
			A_0 = Strings.Format(num, O00OOOo_O0_O.b("ꊑ꒓ꚕꢗꪙ겛꺝邟", a_))
			A_1 = Strings.Format(num2, O00OOOo_O0_O.b("ꊑ꒓ꚕꢗꪙ겛꺝邟", a_))
		End Sub

		' Token: 0x06004EF4 RID: 20212 RVA: 0x0020BB0C File Offset: 0x00209D0C
		Friend Function <<EMPTY_NAME>>(A_0 As Short, A_1 As Short, A_2 As Boolean) As String
			Dim a_ As Integer = 6
			Dim result As String
			If Not O_O0OO.oO.__0O0oooo.() Then
				result = ""
			Else
				Dim array As Byte() = New Byte(CInt((A_1 - 1S + 1S)) - 1) {}
				If O_O0OO.YRead(array(0), A_0, A_1, O00OOOo_O0_O.b("ꆓꎕꆗꎙ��", a_), O00OOOo_O0_O.b("튓펕��ꪛꚝ鎟醡", a_), O_O0OO.oO0_o.o0o.) = 0 Then
					If A_2 Then
						result = Encoding.Unicode.GetString(array)
					Else
						result = Encoding.ASCII.GetString(array)
					End If
				Else
					result = ""
				End If
			End If
			Return result
		End Function

		' Token: 0x06004EF5 RID: 20213 RVA: 0x0020BB94 File Offset: 0x00209D94
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			If Not O_O0OO.oO.__0O0oooo.() Then
			End If
			Dim num As Integer = Encoding.ASCII.GetBytes(A_0).Length
			If num < 8 Then
				num = 8
			End If
			Dim stringBuilder As StringBuilder = New StringBuilder("", num * 4)
			Dim result As String
			If O_O0OO.EncString(A_0, stringBuilder, O_O0OO.oO0_o.o0o.) = 0 Then
				result = stringBuilder.ToString()
			Else
				result = A_0
			End If
			Return result
		End Function

		' Token: 0x06004EF6 RID: 20214 RVA: 0x0020BBE8 File Offset: 0x00209DE8
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim stringBuilder As StringBuilder = New StringBuilder("", 260)
			Dim result As Boolean
			If O_O0OO.FindPort_2(0, 200, 1016130710, stringBuilder) = 0 Then
				O_O0OO.oO0_o.o0o. = stringBuilder.ToString()
				result = True
			Else
				result = False
			End If
			Return result
		End Function

		' Token: 0x06004EF7 RID: 20215 RVA: 0x0020BC2C File Offset: 0x00209E2C
		Friend Function <<EMPTY_NAME>>(A_0 As Assembly, A_1 As String, A_2 As Object(), Optional A_3 As Boolean = False, Optional A_4 As String = "", Optional A_5 As Boolean = False) As Boolean
			Dim a_ As Integer = 19
			Dim result As Boolean
			If Not OO_00oOO.SystemReady AndAlso Not A_3 Then
				result = True
			ElseIf A_0 Is Nothing Then
				result = True
			Else
				Dim text As String = A_1
				If A_0 Is O_O0OO.o0OoO00OO.00O. OrElse A_0 Is O_O0OO.o0o.oO0. OrElse A_5 Then
					text = o0OoOOoOOo0.OO0._Oo0o.(text)
				End If
				If O_O0OO.O00O0o_O_._O. AndAlso A_0.FullName.IndexOf(O00OOOo_O0_O.b("辠쪤햦쒨薪", a_), StringComparison.CurrentCultureIgnoreCase) > 0 Then
					text = o0OoOOoOOo0.OO0._Oo0o.(text)
				End If
				Dim method As MethodInfo = A_0.[GetType](O00OOOo_O0_O.b("킢삤햦쒪즬쪮", a_)).GetMethod(text)
				If Operators.CompareString(A_1, O00OOOo_O0_O.b("�횤펦첨욪쮮�횲", a_), True) = 0 AndAlso OoOo0O.Oo_oOO_._Oo_o.(1, 99) = OoOo0O.Oo_oOO_._Oo_o.(1, 99) AndAlso OO_00oOO.SystemReady AndAlso Not o_O_o_oOoo__.a() Then
					O_O0OO.O00O0o_O_._O. = False
					O_O0OO.o0OoO00OO.00O. = Nothing
				End If
				If Operators.CompareString(A_1, O_O0OO.ooO000O.o.(), True) = 0 AndAlso Not O_O0OO.o_0__.oOOo. Then
					O_O0OO.o_0__.oOOo. = o0OO__.OO0oO.o.()
					If Not O_O0OO.o_0__.oOOo. Then
						O_O0OO.oo0_o_.o. = Nothing
						Return False
					End If
				End If
				Try
					If method IsNot Nothing Then
						method.Invoke(Nothing, A_2)
					End If
				Catch ex As Exception
					If A_1.IndexOf(O00OOOo_O0_O.b("ﺠ", a_)) > 0 Then
						A_1 = A_1.Substring(0, A_1.IndexOf(O00OOOo_O0_O.b("ﺠ", a_)))
					End If
					If Operators.CompareString(A_4, "", True) > 0 Then
						A_1 = A_4 + O00OOOo_O0_O.b("趠", a_) + A_1
					End If
					If ex.InnerException IsNot Nothing Then
						ooO.oOo0Oo.o.(ex.InnerException, A_1)
					Else
						ooO.oOo0Oo.o.(ex.InnerException, A_1)
					End If
					Return False
				End Try
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004EF8 RID: 20216 RVA: 0x0020BDEC File Offset: 0x00209FEC
		Friend Function a() As Boolean
			Dim a_ As Integer = 15
			Dim num As Integer
			Dim result As Boolean
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				Dim num2 As Integer = 2
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { O00OOOo_O0_O.b("떜쾞펠첢쾤슦쪨�쮮풰�솴��슺钼", a_), O00OOOo_O0_O.b("떜쾞펠첢쾤슦쪨�쮮풰�솴��슺钼", a_) })
				IL_5A:
				num2 = 3
				If Not SystemInformation.TerminalServerSession Then
					GoTo IL_6C
				End If
				IL_63:
				num2 = 4
				result = True
				GoTo IL_19B
				IL_6C:
				num2 = 5
				If dataRow Is Nothing OrElse dataRow.IsNull(O00OOOo_O0_O.b("�쾠얢첤삦", a_)) Then
					GoTo IL_196
				End If
				IL_8F:
				num2 = 6
				Dim text As String = O00.oO_.0o_oo_0O_.(dataRow(O00OOOo_O0_O.b("�쾠얢첤삦", a_)).ToString(), o_o_O0OO_0__.o000oOoo.0.(O_O0OO.O_O._Oo.()), O00.MD5Encrypt(O_O0OO.O_O._Oo.()))
				IL_C6:
				num2 = 7
				Dim array As String() = text.Split(New Char() { "|"c })
				IL_DC:
				num2 = 8
				Dim a_2 As String = array(0)
				IL_E4:
				num2 = 9
				Dim str As String = array(1).Substring(0, 32)
				IL_F5:
				num2 = 10
				Dim right As String = array(1).Substring(32, 4)
				IL_106:
				num2 = 11
				Dim text2 As String = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., a_2)
				IL_117:
				num2 = 12
				text2 = O00.ooo000o_0.00o0.(text2, Strings.Left(str, 4), Strings.Right(str, 4))
				IL_133:
				num2 = 13
				text2 = Strings.Left(text2, 4)
				IL_140:
				num2 = 14
				Dim text3 As String = ""
				IL_14A:
				num2 = 15
				Dim num3 As Integer = 0
				Do
					IL_150:
					num2 = 16
					text3 += Conversions.ToString(Strings.Asc(text2(num3)) Mod 10)
					IL_172:
					num2 = 17
					num3 += 1
				Loop While num3 <= 3
				IL_180:
				num2 = 18
				If Operators.CompareString(text3, right, True) <> 0 Then
					GoTo IL_196
				End If
				IL_18F:
				num2 = 19
				result = True
				GoTo IL_19B
				IL_196:
				num2 = 20
				result = False
				IL_19B:
				GoTo IL_241
				IL_1A0:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_202:
				GoTo IL_236
				IL_204:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_214:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_204
			End Try
			IL_236:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_241:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06004EF9 RID: 20217 RVA: 0x0020C060 File Offset: 0x0020A260
		Friend Function <<EMPTY_NAME>>(A_0 As String, Optional A_1 As DataSet = Nothing) As String
			Dim a_ As Integer = 11
			Dim a_2 As String
			If A_1 Is Nothing Then
				a_2 = O_O0OO.O_O._Oo.()
				A_1 = O_O0OO.OoO.0OO__0ooo.()
			Else
				a_2 = O_O0OO.o0_OO.000.(A_1)
			End If
			Dim result As String
			If A_0.StartsWith(O00OOOo_O0_O.b("", a_)) AndAlso A_0.EndsWith(O00OOOo_O0_O.b("쒘", a_)) Then
				Dim num As Integer = A_0.LastIndexOf(O00OOOo_O0_O.b("슘", a_))
				Dim text As String = A_0.Substring(num)
				text = text.TrimStart(New Char() { "["c }).TrimEnd(New Char() { "]"c })
				A_0 = A_0.Substring(0, num)
				A_0 = A_0.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
				Dim a_3 As String = O00.ooo000o_0.00o0.(text, O00OOOo_O0_O.b("ﾘ", a_), O00OOOo_O0_O.b("ﾘ", a_)).Substring(0, 5)
				result = O00.oO_.0o_oo_0O_.(A_0, a_2, a_3)
			Else
				result = O00.oO_.0o_oo_0O_.(A_0, a_2, ooO0__OO.oO_0.o000O_.(A_1))
			End If
			Return result
		End Function

		' Token: 0x06004EFA RID: 20218 RVA: 0x0020C178 File Offset: 0x0020A378
		Friend Function <<EMPTY_NAME>>() As DataTable
			Dim a_ As Integer = 1
			Dim dataTable As DataTable = Nothing
			If O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()).Rows.Count = 0 Then
				Oo00.o_o_oo.0o.()
			End If
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("�", a_), o0_O.o.0_O_O. })
			Dim flag As Boolean
			If dataRow IsNot Nothing AndAlso Operators.CompareString(dataRow(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)).ToString(), O00OOOo_O0_O.b("뺎", a_), True) = 0 Then
				flag = True
			End If
			If flag Then
				Dim text As String = ""
				Dim text2 As String = ""
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("�", a_), o0_O.Oo0_.o0. })
				If dataRow2 IsNot Nothing Then
					text = dataRow2(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)).ToString()
				End If
				dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("�", a_), o0_O.OO_O.O0ooO0O. })
				If dataRow2 IsNot Nothing Then
					text2 = dataRow2(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)).ToString()
				End If
				If Not text2.StartsWith(O00OOOo_O0_O.b("풎", a_)) Then
					text2 = O00OOOo_O0_O.b("풎", a_) + text2 + O00OOOo_O0_O.b("튎", a_)
				End If
				If Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(text2, "", True) > 0 Then
					If O_O0OO.O._o_.().ContainsKey(text) Then
						dataTable = New DataTable()
						Dim oleDbDataAdapter As OleDbDataAdapter
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(text)) Then
							oleDbDataAdapter = New OleDbDataAdapter(O00OOOo_O0_O.b("�ﾒ뮚랜뾞톢쪤쪦覨", a_) + text2, O_O0OO.O._o_.()(text))
						Else
							oleDbDataAdapter = New OleDbDataAdapter(O00OOOo_O0_O.b("�ﾒ뮚랜뾞톢쪤쪦覨", a_) + text2, O_O0OO.O._o_.()(text))
						End If
						oleDbDataAdapter.Fill(dataTable)
						o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
						dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("쮎횖ﶘ漢쒠톢", a_), oleDbDataAdapter)
					ElseIf Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(text2, "", True) > 0 AndAlso O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
						Dim o0O As O0O = O_O0OO.OoO__.0oO0oo.()(text)
						Dim a_2 As String
						If o0O.OO.OoO0. = DataServerTypeEnum.Oracle Then
							a_2 = O00OOOo_O0_O.b("�ﾒ뮚랜뾞톢쪤쪦覨", a_) + text2
						Else
							a_2 = O00OOOo_O0_O.b("�ﾒ뮚랜뾞톢쪤쪦覨", a_) + text2
						End If
						Dim httpClient As HttpClient = o0O.oO0_0.o.()
						httpClient.FormData(O00OOOo_O0_O.b("캎ﲔ", a_)) = 1.ToString()
						httpClient.[Select] = a_2
						dataTable = httpClient.GetBaseDataTable()
						Dim dataTable2 As DataTable = New DataTable(dataTable, Nothing, Nothing, text2, Nothing)
						dataTable2.ConnectionName = text
						dataTable2.DataServer = httpClient.Oo_0oO0Oo0_.O_.
						dataTable2.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.
						dataTable2.UpdateColumns = CType(dataTable.ExtendedProperties(O00OOOo_O0_O.b("�ﲘ�풠캢쮤풦", a_)), List(Of String))
						dataTable.ExtendedProperties.Clear()
						dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("�삔ﶘ漢爵펠", a_), dataTable2)
					End If
					For Each dataRow3 As DataRow In O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.()).[Select](O00OOOo_O0_O.b("풎얐쒘뮚ꂜ뾞", a_) + Conversions.ToString(0) + O00OOOo_O0_O.b("꾎�떔첖춘爵ﲠ莢颤螦", a_) + Conversions.ToString(1))
						Dim dataRow4 As DataRow = dataTable.NewRow()
						dataRow4(O00OOOo_O0_O.b("솎ﺒ", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("솎ﺒ", a_)))
						dataRow4(O00OOOo_O0_O.b("�", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("�", a_)))
						dataRow4(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)))
						dataTable.Rows.Add(dataRow4)
					Next
					dataTable.AcceptChanges()
				Else
					dataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
				End If
			Else
				dataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
			End If
			Return dataTable
		End Function

		' Token: 0x06004EFB RID: 20219 RVA: 0x0020C678 File Offset: 0x0020A878
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As DataTable)
			Dim a_ As Integer = 8
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("쎕ﾙ", a_), o0_O.o.0_O_O. })
			If dataRow IsNot Nothing AndAlso Operators.CompareString(dataRow(O00OOOo_O0_O.b("햕瀞잟", a_)).ToString(), O00OOOo_O0_O.b("ꞕ", a_), True) = 0 Then
				Dim text As String = ""
				Dim text2 As String = ""
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("쎕ﾙ", a_), o0_O.Oo0_.o0. })
				If dataRow2 IsNot Nothing Then
					text = dataRow2(O00OOOo_O0_O.b("햕瀞잟", a_)).ToString()
					If O_O0OO.O._o_.().ContainsKey(text) Then
						dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("쎕ﾙ", a_), o0_O.OO_O.O0ooO0O. })
						If dataRow2 IsNot Nothing Then
							text2 = dataRow2(O00OOOo_O0_O.b("햕瀞잟", a_)).ToString()
						End If
					End If
				End If
				If Operators.CompareString(text, "", True) > 0 AndAlso Operators.CompareString(text2, "", True) > 0 Then
					Dim dataTable As DataTable = New DataTable()
					If O_O0OO.O._o_.().ContainsKey(text) Then
						Dim oleDbDataAdapter As OleDbDataAdapter
						If o_O_o_oOoo__.OO0O_0.0O0o0_o.(O_O0OO.O._o_.()(text)) Then
							oleDbDataAdapter = New OleDbDataAdapter(String.Concat(New String() { O00OOOo_O0_O.b("얕ﶗ鍊ﶝ풟芡躣蚥�쎫쎭邯", a_), text2, O00OOOo_O0_O.b("뚕鍊얟芡장얧쾩貫鎭邯閱", a_), A_0, O00OOOo_O0_O.b("놕", a_) }), O_O0OO.O._o_.()(text))
						Else
							oleDbDataAdapter = New OleDbDataAdapter(String.Concat(New String() { O00OOOo_O0_O.b("얕ﶗ鍊ﶝ풟芡躣蚥�쎫쎭邯", a_), text2, O00OOOo_O0_O.b("쮕뢗춙ﮝ튟잡蒣ﶥ쮩솫쮭銱観隵龷", a_), A_0, O00OOOo_O0_O.b("놕", a_) }), O_O0OO.O._o_.()(text))
						End If
						oleDbDataAdapter.Fill(dataTable)
					ElseIf O_O0OO.OoO__.0oO0oo.().ContainsKey(text) Then
						Dim o0O As O0O = O_O0OO.OoO__.0oO0oo.()(text)
						Dim a_2 As String
						If o0O.OO.OoO0. = DataServerTypeEnum.Oracle Then
							a_2 = String.Concat(New String() { O00OOOo_O0_O.b("얕ﶗ鍊ﶝ풟芡躣蚥�쎫쎭邯", a_), text2, O00OOOo_O0_O.b("뚕鍊얟芡장얧쾩貫鎭邯閱", a_), A_0, O00OOOo_O0_O.b("놕", a_) })
						Else
							a_2 = String.Concat(New String() { O00OOOo_O0_O.b("얕ﶗ鍊ﶝ풟芡躣蚥�쎫쎭邯", a_), text2, O00OOOo_O0_O.b("쮕뢗춙ﮝ튟잡蒣ﶥ쮩솫쮭銱観隵龷", a_), A_0, O00OOOo_O0_O.b("놕", a_) })
						End If
						Dim httpClient As HttpClient = o0O.oO0_0.o.()
						httpClient.[Select] = a_2
						httpClient.FormData(O00OOOo_O0_O.b("힕ﮗ캟", a_)) = 2.ToString()
						httpClient.FormData(O00OOOo_O0_O.b("�ﾗ얟잣캥춧잩춫", a_)) = O00OOOo_O0_O.b("슕鍊", a_)
						dataTable = httpClient.GetBaseDataTable()
					End If
					If dataTable.Rows.Count > 0 Then
						dataRow2 = dataTable.Rows(0)
						Dim array As DataRow() = A_1.[Select](O00OOOo_O0_O.b("축횗ﮙﮝﶟ芡馣蚥辧", a_) + A_0 + O00OOOo_O0_O.b("놕", a_))
						If array.Length = 0 Then
							A_1.ImportRow(dataRow2)
							Return
						End If
						array(0)(O00OOOo_O0_O.b("햕瀞잟", a_)) = RuntimeHelpers.GetObjectValue(dataRow2(O00OOOo_O0_O.b("햕瀞잟", a_)))
						If OO_00oOO.Users.ooo___o_0.__..ContainsKey(array(0)) Then
							OO_00oOO.Users.ooo___o_0.__..Remove(array(0))
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06004EFC RID: 20220 RVA: 0x0020CAB4 File Offset: 0x0020ACB4
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(30) {}
			array(0) = 229
			array(1) = 138
			array(2) = 160
			array(3) = 229
			array(4) = 175
			array(5) = 134
			array(6) = 231
			array(7) = 139
			array(8) = 151
			array(9) = 228
			array(10) = 191
			array(11) = 161
			array(12) = 230
			array(13) = 129
			array(14) = 175
			array(15) = 232
			array(16) = 175
			array(17) = 187
			array(18) = 229
			array(19) = 143
			array(20) = 150
			array(21) = 233
			array(22) = 148
			array(23) = 153
			array(24) = 232
			array(25) = 175
			array(26) = 175
			array(27) = 239
			array(28) = 188
			array(29) = 129
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004EFD RID: 20221 RVA: 0x0020CBDC File Offset: 0x0020ADDC
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(21) {}
			array(0) = 232
			array(1) = 175
			array(2) = 183
			array(3) = 230
			array(4) = 143
			array(5) = 146
			array(6) = 228
			array(7) = 184
			array(8) = 138
			array(9) = 229
			array(10) = 138
			array(11) = 160
			array(12) = 229
			array(13) = 175
			array(14) = 134
			array(15) = 231
			array(16) = 139
			array(17) = 151
			array(18) = 239
			array(19) = 188
			array(20) = 129
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004EFE RID: 20222 RVA: 0x0020CCB0 File Offset: 0x0020AEB0
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(36) {}
			array(0) = 229
			array(1) = 138
			array(2) = 160
			array(3) = 229
			array(4) = 175
			array(5) = 134
			array(6) = 231
			array(7) = 139
			array(8) = 151
			array(9) = 230
			array(10) = 148
			array(11) = 175
			array(12) = 230
			array(13) = 140
			array(14) = 129
			array(15) = 231
			array(16) = 154
			array(17) = 132
			array(18) = 230
			array(19) = 156
			array(20) = 128
			array(21) = 233
			array(22) = 171
			array(23) = 152
			array(24) = 231
			array(25) = 137
			array(26) = 136
			array(27) = 230
			array(28) = 156
			array(29) = 172
			array(30) = 228
			array(31) = 184
			array(32) = 186
			array(33) = 239
			array(34) = 188
			array(35) = 154
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004EFF RID: 20223 RVA: 0x0020CE0C File Offset: 0x0020B00C
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(33) {}
			array(0) = 232
			array(1) = 175
			array(2) = 183
			array(3) = 230
			array(4) = 143
			array(5) = 146
			array(6) = 229
			array(7) = 133
			array(8) = 165
			array(9) = 229
			array(10) = 188
			array(11) = 128
			array(12) = 229
			array(13) = 143
			array(14) = 145
			array(15) = 231
			array(16) = 137
			array(17) = 136
			array(18) = 231
			array(19) = 154
			array(20) = 132
			array(21) = 229
			array(22) = 138
			array(23) = 160
			array(24) = 229
			array(25) = 175
			array(26) = 134
			array(27) = 231
			array(28) = 139
			array(29) = 151
			array(30) = 239
			array(31) = 188
			array(32) = 129
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004F00 RID: 20224 RVA: 0x0020CF4C File Offset: 0x0020B14C
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(52) {}
			array(0) = 230
			array(1) = 130
			array(2) = 168
			array(3) = 230
			array(4) = 173
			array(5) = 163
			array(6) = 229
			array(7) = 156
			array(8) = 168
			array(9) = 228
			array(10) = 189
			array(11) = 191
			array(12) = 231
			array(13) = 148
			array(14) = 168
			array(15) = 231
			array(16) = 154
			array(17) = 132
			array(18) = 231
			array(19) = 137
			array(20) = 136
			array(21) = 230
			array(22) = 156
			array(23) = 172
			array(24) = 228
			array(25) = 184
			array(26) = 141
			array(27) = 232
			array(28) = 131
			array(29) = 189
			array(30) = 233
			array(31) = 133
			array(32) = 141
			array(33) = 229
			array(34) = 144
			array(35) = 136
			array(36) = 229
			array(37) = 138
			array(38) = 160
			array(39) = 229
			array(40) = 175
			array(41) = 134
			array(42) = 231
			array(43) = 139
			array(44) = 151
			array(45) = 228
			array(46) = 189
			array(47) = 191
			array(48) = 231
			array(49) = 148
			array(50) = 168
			array(51) = 33
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004F01 RID: 20225 RVA: 0x0020D134 File Offset: 0x0020B334
		Friend Function <<EMPTY_NAME>>(A_0 As ProjectProperty) As Boolean
			Return Not A_0.o0o.0oOo_0. AndAlso OO_00oOO.ModifierKey = Keys.Control
		End Function

		' Token: 0x06004F02 RID: 20226 RVA: 0x0020D15B File Offset: 0x0020B35B
		Friend Function <<EMPTY_NAME>>() As Office2007Renderer
			If O_O0OO.o.O___o00o0O. Is Nothing Then
				O_O0OO.o.O___o00o0O. = New Office2007Renderer()
			End If
			Return O_O0OO.o.O___o00o0O.
		End Function

		' Token: 0x06004F03 RID: 20227 RVA: 0x0020D174 File Offset: 0x0020B374
		Friend Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(28) {}
			array(0) = 230
			array(1) = 130
			array(2) = 168
			array(3) = 230
			array(4) = 151
			array(5) = 160
			array(6) = 230
			array(7) = 157
			array(8) = 131
			array(9) = 232
			array(10) = 191
			array(11) = 155
			array(12) = 232
			array(13) = 161
			array(14) = 140
			array(15) = 230
			array(16) = 173
			array(17) = 164
			array(18) = 233
			array(19) = 161
			array(20) = 185
			array(21) = 230
			array(22) = 147
			array(23) = 141
			array(24) = 228
			array(25) = 189
			array(26) = 156
			array(27) = 33
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x06004F04 RID: 20228 RVA: 0x0020D284 File Offset: 0x0020B484
		Friend Sub <<EMPTY_NAME>>(A_0 As C1PrintPreviewDialog)
			Dim a_ As Integer = 14
			Try
				For Each obj As Object In A_0.Controls(0).Controls
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is ToolStripPanel Then
						Try
							For Each obj2 As Object In control.Controls
								Dim control2 As Control = CType(obj2, Control)
								If TypeOf control2 Is ToolStrip Then
									Try
										For Each obj3 As Object In CType(control2, ToolStrip).Items
											Dim toolStripItem As ToolStripItem = CType(obj3, ToolStripItem)
											If Operators.CompareString(toolStripItem.Name, O00OOOo_O0_O.b("ﺛ캟춣쪥춧囹춫�햯", a_), True) = 0 OrElse Operators.CompareString(toolStripItem.Name, O00OOOo_O0_O.b("ﺛ캟횣쾥욧�", a_), True) = 0 Then
												toolStripItem.Visible = False
											End If
										Next
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
								End If
							Next
							Continue For
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
					If TypeOf control Is ToolStripContentPanel Then
						Try
							For Each obj4 As Object In control.Controls
								Dim control3 As Control = CType(obj4, Control)
								If TypeOf control3 Is C1PreviewPane Then
									control3.ContextMenuStrip = Nothing
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
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06004F05 RID: 20229 RVA: 0x0020D478 File Offset: 0x0020B678
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As PowerModeChangedEventArgs)
			Dim mode As PowerModes = A_1.Mode
			If mode <> PowerModes.[Resume] Then
				If mode = PowerModes.Suspend Then
					O_O0OO.O_oO_o0O.o__. = True
					Return
				End If
			Else
				O_O0OO.O_oO_o0O.o__. = False
			End If
		End Sub

		' Token: 0x06004F06 RID: 20230 RVA: 0x0020D4A4 File Offset: 0x0020B6A4
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 5
			If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + O00OOOo_O0_O.b("잒殺즚캠톢톤삨잪좬�", a_)) Then
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + O00OOOo_O0_O.b("잒殺즚캠톢톤삨잪좬�", a_))
			End If
			Return OO_00oOO.ProjectPath + O00OOOo_O0_O.b("잒殺즚캠톢톤삨잪좬�", a_)
		End Function

		' Token: 0x06004F07 RID: 20231 RVA: 0x0020D518 File Offset: 0x0020B718
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 17
			Return c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("쎞", a_)
		End Function

		' Token: 0x06004F08 RID: 20232 RVA: 0x0020D558 File Offset: 0x0020B758
		Public Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 9
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				Dim num2 As Integer = 2
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()) Then
					GoTo IL_F2
				End If
				IL_26:
				num2 = 3
				Dim enumerator As IEnumerator(Of String) = OO_00oOO.FileSys.GetFiles(O_O0OO.OoO__.0oO0oo.()).GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_4A:
					num2 = 4
					Dim fileInfo As FileInfo = New FileInfo(text)
					IL_55:
					num2 = 5
					If(DateTime.Now - fileInfo.CreationTime).TotalMinutes > 5.0 Then
						IL_7C:
						num2 = 6
						fileInfo.Delete()
						IL_85:
						num2 = 7
						Dim directory As String = fileInfo.DirectoryName + O00OOOo_O0_O.b("쮖", a_) + Path.GetFileNameWithoutExtension(text) + O00OOOo_O0_O.b("릖ﾘ爵튠", a_)
						IL_B8:
						num2 = 8
						If OO_00oOO.FileSys.DirectoryExists(directory) Then
							IL_C8:
							num2 = 9
							OO_00oOO.FileSys.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents)
						End If
					End If
					IL_D8:
					num2 = 10
				End While
				IL_E6:
				num2 = 11
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_F2:
				GoTo IL_171
				IL_F4:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_132:
				GoTo IL_166
				IL_134:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_144:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_134
			End Try
			IL_166:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_171:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004F09 RID: 20233 RVA: 0x0020D6FC File Offset: 0x0020B8FC
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return AppDomain.CurrentDomain.DomainManager IsNot Nothing
		End Function

		' Token: 0x040020AE RID: 8366
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020AF RID: 8367
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020B0 RID: 8368
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020B1 RID: 8369
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x040020B2 RID: 8370
		Private <<EMPTY_NAME>> As DataSet

		' Token: 0x040020B3 RID: 8371
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040020B4 RID: 8372
		Private <<EMPTY_NAME>> As Dictionary(Of String, O_0)

		' Token: 0x040020B5 RID: 8373
		Private <<EMPTY_NAME>> As List(Of O_0)

		' Token: 0x040020B6 RID: 8374
		Private <<EMPTY_NAME>> As Dictionary(Of String, OleDbConnection)

		' Token: 0x040020B7 RID: 8375
		Private <<EMPTY_NAME>> As Dictionary(Of String, O_0oOo_OO)

		' Token: 0x040020B8 RID: 8376
		Private <<EMPTY_NAME>> As Dictionary(Of String, O0O)

		' Token: 0x040020B9 RID: 8377
		Private <<EMPTY_NAME>> As Dictionary(Of String, o__o_OO_o_)

		' Token: 0x040020BA RID: 8378
		Private <<EMPTY_NAME>> As ImageList

		' Token: 0x040020BB RID: 8379
		Private <<EMPTY_NAME>> As Oooo

		' Token: 0x040020BC RID: 8380
		Private <<EMPTY_NAME>> As O0OO_oo0o

		' Token: 0x040020BD RID: 8381
		Private <<EMPTY_NAME>> As OO__oo_0ooo0_

		' Token: 0x040020BE RID: 8382
		Private <<EMPTY_NAME>> As oo0O0o___O

		' Token: 0x040020BF RID: 8383
		Private <<EMPTY_NAME>> As o0o0OO

		' Token: 0x040020C0 RID: 8384
		Private <<EMPTY_NAME>> As O0OooO0_0O

		' Token: 0x040020C1 RID: 8385
		Private <<EMPTY_NAME>> As o__o_O_o0o0__

		' Token: 0x040020C2 RID: 8386
		Private <<EMPTY_NAME>> As OOoOO_00O00

		' Token: 0x040020C3 RID: 8387
		Private <<EMPTY_NAME>> As O0o__o0_o0

		' Token: 0x040020C4 RID: 8388
		Private <<EMPTY_NAME>> As O0_oOoo

		' Token: 0x040020C5 RID: 8389
		Private <<EMPTY_NAME>> As Ooo0__

		' Token: 0x040020C6 RID: 8390
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020C7 RID: 8391
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020C8 RID: 8392
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x040020C9 RID: 8393
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020CA RID: 8394
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020CB RID: 8395
		Friend <<EMPTY_NAME>> As ProjectProperty

		' Token: 0x040020CC RID: 8396
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x040020CD RID: 8397
		Friend <<EMPTY_NAME>> As Image

		' Token: 0x040020CE RID: 8398
		Friend <<EMPTY_NAME>> As Image

		' Token: 0x040020CF RID: 8399
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020D0 RID: 8400
		Friend <<EMPTY_NAME>> As DataTable

		' Token: 0x040020D1 RID: 8401
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x040020D2 RID: 8402
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040020D3 RID: 8403
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020D4 RID: 8404
		Friend <<EMPTY_NAME>> As RibbonButton

		' Token: 0x040020D5 RID: 8405
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020D6 RID: 8406
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020D7 RID: 8407
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x040020D8 RID: 8408
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020D9 RID: 8409
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020DA RID: 8410
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020DB RID: 8411
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020DC RID: 8412
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020DD RID: 8413
		Friend <<EMPTY_NAME>> As Assembly

		' Token: 0x040020DE RID: 8414
		Friend <<EMPTY_NAME>> As O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002

		' Token: 0x040020DF RID: 8415
		Friend <<EMPTY_NAME>> As Office2007Renderer

		' Token: 0x040020E0 RID: 8416
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020E1 RID: 8417
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Bitmap)

		' Token: 0x040020E2 RID: 8418
		Friend <<EMPTY_NAME>> As Bitmap

		' Token: 0x040020E3 RID: 8419
		Friend <<EMPTY_NAME>> As O\u3002\u3000\u3002_\u3002\u3000\u3000\u3002\u3000\u3002\u3000

		' Token: 0x040020E4 RID: 8420
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020E5 RID: 8421
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020E6 RID: 8422
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020E7 RID: 8423
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020E8 RID: 8424
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020E9 RID: 8425
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x040020EA RID: 8426
		Friend <<EMPTY_NAME>> As Color

		' Token: 0x040020EB RID: 8427
		Friend <<EMPTY_NAME>> As Color

		' Token: 0x040020EC RID: 8428
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x040020ED RID: 8429
		Friend <<EMPTY_NAME>> As oOo_00o0o00_0

		' Token: 0x040020EE RID: 8430
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020EF RID: 8431
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040020F0 RID: 8432
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020F1 RID: 8433
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020F2 RID: 8434
		Private a As Image

		' Token: 0x020004CD RID: 1229
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Class DeveloperValider
			' Token: 0x170011AB RID: 4523
			' (get) Token: 0x06004F0B RID: 20235 RVA: 0x0020D724 File Offset: 0x0020B924
			' (set) Token: 0x06004F0C RID: 20236 RVA: 0x0020D72C File Offset: 0x0020B92C
			Public Property Developer As String
				Get
					Return Me.OO._0OooO00.
				End Get
				Set(value As String)
					Me.OO._0OooO00. = value
				End Set
			End Property

			' Token: 0x040020F3 RID: 8435
			Private <<EMPTY_NAME>> As String
		End Class
	End Module
End Namespace
