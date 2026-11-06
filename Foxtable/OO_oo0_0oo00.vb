Imports System
Imports System.Runtime.CompilerServices
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200043B RID: 1083
	Friend Class OO_oo0_0oo00
		' Token: 0x0600477F RID: 18303 RVA: 0x001D86B0 File Offset: 0x001D68B0
		Public Sub New()
			Me.o00O.o0oo. = 1
			Me.oo._Oo0. = o_o_O0OO_0__.Oo.O_Oo00O.()
			Me.oo.o0oOoooo. = o_o_O0OO_0__.ooO_OO.oOoo.()
			Me.oo0_._O. = o_o_O0OO_0__.oOo.Ooo.()
		End Sub

		' Token: 0x06004780 RID: 18304 RVA: 0x001D86E0 File Offset: 0x001D68E0
		Private Function <<EMPTY_NAME>>() As DateTime
			Return Me.O.O_.
		End Function

		' Token: 0x06004781 RID: 18305 RVA: 0x001D86E8 File Offset: 0x001D68E8
		Private Sub <<EMPTY_NAME>>(A_0 As DateTime)
			Me.O.O_. = A_0
		End Sub

		' Token: 0x06004782 RID: 18306 RVA: 0x001D86F1 File Offset: 0x001D68F1
		Private Function <<EMPTY_NAME>>() As Integer
			Return Me.O.O_.
		End Function

		' Token: 0x06004783 RID: 18307 RVA: 0x001D86F9 File Offset: 0x001D68F9
		Private Sub <<EMPTY_NAME>>(A_0 As Integer)
			Me.O.O_. = A_0
		End Sub

		' Token: 0x06004784 RID: 18308 RVA: 0x001D8704 File Offset: 0x001D6904
		Private Sub <<EMPTY_NAME>>()
			If DateTime.Compare(DateTime.Today, Me.Oo_.___0.()) <> 0 Then
				Me.O.O_.(Me.Oo_.___0.() + Me.o00O.o0oo.)
				c.OOOOO.o.().Registry.SetValue(Me.oo0_._O., Me.oo._Oo0., O00.ooo000o_0.00o0.(DateTime.Today.ToString(), "me", "this"))
				c.OOOOO.o.().Registry.SetValue(Me.oo0_._O., Me.oo.o0oOoooo., O00.ooo000o_0.00o0.(Me.Oo_.___0.().ToString(), "me", "this"))
			End If
		End Sub

		' Token: 0x06004785 RID: 18309 RVA: 0x001D87A8 File Offset: 0x001D69A8
		Private Sub <<EMPTY_NAME>>()
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(Me.oo0_._O., Me.oo._Oo0., ""))
			If objectValue IsNot Nothing Then
				Dim s As String = O00.oO_.0o_oo_0O_.(objectValue.ToString(), "me", "this").ToString()
				Dim a_ As DateTime = Me.Oo_.___0.()
				DateTime.TryParse(s, a_)
				Me.O.O_.(a_)
			End If
			objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(Me.oo0_._O., Me.oo.o0oOoooo., 1))
			If objectValue IsNot Nothing Then
				Dim s2 As String = O00.oO_.0o_oo_0O_.(objectValue.ToString(), "me", "this").ToString()
				Dim a_2 As Integer = Me.Oo_.___0.()
				Integer.TryParse(s2, a_2)
				Me.O.O_.(a_2)
			End If
		End Sub

		' Token: 0x06004786 RID: 18310 RVA: 0x001D8868 File Offset: 0x001D6A68
		Friend Function <<EMPTY_NAME>>() As Integer
			Me.O.O_.()
			Me.o00O.o0oo.()
			If Me.Oo_.___0.() > 60 Then
				O_O0OO.O_O.OOO_o.(True)
			End If
			Return Me.Oo_.___0.()
		End Function

		' Token: 0x06004787 RID: 18311 RVA: 0x001D888C File Offset: 0x001D6A8C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.O.O_.()
		End Function

		' Token: 0x06004788 RID: 18312 RVA: 0x001D8894 File Offset: 0x001D6A94
		Private Function <<EMPTY_NAME>>() As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = o_o_O0OO_0__.O0_O_o.o_.()
				IL_10:
				num2 = 3
				If Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_27
				End If
				IL_21:
				num2 = 4
				result = False
				GoTo IL_72
				IL_27:
				num2 = 5
				Dim s As String = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4)
				IL_37:
				num2 = 6
				Dim s2 As String = text.Substring(0, 4)
				IL_44:
				num2 = 7
				Dim num3 As Integer
				Integer.TryParse(s, num3)
				IL_50:
				num2 = 8
				Dim num4 As Integer
				Integer.TryParse(s2, num4)
				IL_5C:
				num2 = 9
				result = (num4 = (num3 + 670673) Mod 10000)
				IL_72:
				GoTo IL_E9
				IL_74:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_AA:
				GoTo IL_DE
				IL_AC:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_BC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_AC
			End Try
			IL_DE:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E9:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04001D38 RID: 7480
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04001D39 RID: 7481
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001D3A RID: 7482
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001D3B RID: 7483
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D3C RID: 7484
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D3D RID: 7485
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
