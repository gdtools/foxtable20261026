Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200004A RID: 74
	Friend Class o_oo0_0_Oo0O_
		Inherits UITypeEditor

		' Token: 0x060002BE RID: 702 RVA: 0x00006480 File Offset: 0x00004680
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002BF RID: 703 RVA: 0x000064A8 File Offset: 0x000046A8
		Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
			Dim num As Integer
			Dim objectValue As Object
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If context Is Nothing OrElse context.Instance Is Nothing OrElse provider Is Nothing Then
					GoTo IL_1B5
				End If
				IL_20:
				num2 = 4
				Dim text As String = Application.ProductVersion.Replace(".", "")
				IL_38:
				num2 = 5
				Dim value2 As Char = "0"c
				IL_3E:
				num2 = 6
				Dim array As Char() = New Char(0) {}
				IL_48:
				num2 = 7
				Dim text2 As String = ""
				IL_51:
				num2 = 8
				array(0) = "."c
				IL_59:
				num2 = 9
				Dim array2 As String() = Nothing
				IL_5F:
				num2 = 10
				array2 = text.Split(New Char() { array(0) })
				IL_78:
				num2 = 11
				Dim num3 As Integer
				If Not(array2(0).Length > 0 And num3 >= 0) Then
					GoTo IL_F2
				End If
				IL_92:
				num2 = 12
				array2(0) = o_O_o_oOoo__.OOOO_OO._oo.(array2(0))
				IL_A2:
				num2 = 13
				If array2(0).Length <= num3 Then
					GoTo IL_CC
				End If
				IL_B2:
				num2 = 14
				text2 = Conversions.ToString(array2(0)(num3))
				GoTo IL_15D
				IL_CC:
				num2 = 16
				If array2(0).Length <> num3 Then
					GoTo IL_EA
				End If
				IL_DC:
				num2 = 17
				text2 = Conversions.ToString(value2)
				GoTo IL_15D
				IL_EA:
				num2 = 19
				text2 = Nothing
				GoTo IL_15D
				IL_F2:
				num2 = 21
				If Not(array2.Length > 1 And num3 < 0) Then
					GoTo IL_143
				End If
				IL_104:
				num2 = 22
				If array2(1).Length < Math.Abs(num3) Then
					GoTo IL_137
				End If
				IL_119:
				num2 = 23
				text2 = Conversions.ToString(array2(1)(Math.Abs(num3) - 1))
				GoTo IL_15D
				IL_137:
				num2 = 25
				text2 = "0"
				GoTo IL_15D
				IL_143:
				num2 = 27
				If num3 >= 0 Then
					GoTo IL_157
				End If
				IL_14B:
				num2 = 28
				text2 = "0"
				GoTo IL_15D
				IL_157:
				num2 = 30
				text2 = Nothing
				IL_15D:
				num2 = 31
				num3 = 0
				IL_163:
				num2 = 32
				If Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_1B5
				End If
				IL_176:
				num2 = 33
				Dim text3 As String = text2
				For i As Integer = 0 To text3.Length - 1
					Dim [string] As String = Conversions.ToString(text3(i))
					IL_192:
					num2 = 34
					num3 += Strings.Asc([string])
					IL_1A1:
					num2 = 35
				Next
				IL_1B5:
				num2 = 36
				objectValue = RuntimeHelpers.GetObjectValue(value)
				IL_1BF:
				num2 = 37
				If context Is Nothing OrElse context.Instance Is Nothing OrElse provider Is Nothing Then
					GoTo IL_373
				End If
				IL_1D9:
				num2 = 39
				Dim text4 As String = Application.ProductVersion.Replace(".", "")
				IL_1F2:
				num2 = 40
				Dim value3 As Char = "0"c
				IL_1F9:
				num2 = 41
				Dim array3 As Char() = New Char(0) {}
				IL_204:
				num2 = 42
				Dim text5 As String = ""
				IL_20E:
				num2 = 43
				array3(0) = "."c
				IL_217:
				num2 = 44
				Dim array4 As String() = Nothing
				IL_21D:
				num2 = 45
				array4 = text4.Split(New Char() { array3(0) })
				IL_236:
				num2 = 46
				Dim num4 As Integer
				If Not(array4(0).Length > 0 And num4 >= 0) Then
					GoTo IL_2B0
				End If
				IL_250:
				num2 = 47
				array4(0) = o_O_o_oOoo__.OOOO_OO._oo.(array4(0))
				IL_260:
				num2 = 48
				If array4(0).Length <= num4 Then
					GoTo IL_28A
				End If
				IL_270:
				num2 = 49
				text5 = Conversions.ToString(array4(0)(num4))
				GoTo IL_31B
				IL_28A:
				num2 = 51
				If array4(0).Length <> num4 Then
					GoTo IL_2A8
				End If
				IL_29A:
				num2 = 52
				text5 = Conversions.ToString(value3)
				GoTo IL_31B
				IL_2A8:
				num2 = 54
				text5 = Nothing
				GoTo IL_31B
				IL_2B0:
				num2 = 56
				If Not(array4.Length > 1 And num4 < 0) Then
					GoTo IL_301
				End If
				IL_2C2:
				num2 = 57
				If array4(1).Length < Math.Abs(num4) Then
					GoTo IL_2F5
				End If
				IL_2D7:
				num2 = 58
				text5 = Conversions.ToString(array4(1)(Math.Abs(num4) - 1))
				GoTo IL_31B
				IL_2F5:
				num2 = 60
				text5 = "0"
				GoTo IL_31B
				IL_301:
				num2 = 62
				If num4 >= 0 Then
					GoTo IL_315
				End If
				IL_309:
				num2 = 63
				text5 = "0"
				GoTo IL_31B
				IL_315:
				num2 = 65
				text5 = Nothing
				IL_31B:
				num2 = 66
				num4 = 0
				IL_321:
				num2 = 67
				If Operators.CompareString(text5, "", True) <= 0 Then
					GoTo IL_373
				End If
				IL_334:
				num2 = 68
				Dim text6 As String = text5
				For j As Integer = 0 To text6.Length - 1
					Dim string2 As String = Conversions.ToString(text6(j))
					IL_350:
					num2 = 69
					num4 += Strings.Asc(string2)
					IL_35F:
					num2 = 70
				Next
				IL_373:
				GoTo IL_4E1
				IL_378:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_4A2:
				GoTo IL_4D6
				IL_4A4:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4B4:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4A4
			End Try
			IL_4D6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_4E1:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return objectValue
		End Function

		' Token: 0x0400006D RID: 109
		Private <<EMPTY_NAME>> As IWindowsFormsEditorService

		' Token: 0x0400006E RID: 110
		Private <<EMPTY_NAME>> As O\u3000\u3002\u3000\u3000
	End Class
End Namespace
