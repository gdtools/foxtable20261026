Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005B RID: 91
	Friend Class o0O_O__o000
		Inherits UITypeEditor

		' Token: 0x060002FF RID: 767 RVA: 0x000083E8 File Offset: 0x000065E8
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If A_0 IsNot Nothing AndAlso A_0.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(A_0)
			End If
			Return result
		End Function

		' Token: 0x06000300 RID: 768 RVA: 0x00008410 File Offset: 0x00006610
		Public Overridable Overloads Function <<EMPTY_NAME>>(A_0 As ITypeDescriptorContext, A_1 As IServiceProvider, A_2 As Object) As Object
			Dim num As Integer
			Dim result As Object
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_0 IsNot Nothing AndAlso A_0.Instance IsNot Nothing AndAlso A_1 IsNot Nothing Then
					GoTo IL_20
				End If
				IL_17:
				num2 = 3
				result = A_2
				GoTo IL_10C
				IL_20:
				num2 = 4
				Me.O_o.O00Oo. = CType(A_1.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_3D:
				num2 = 5
				If Me.O_o.O00Oo. IsNot Nothing Then
					GoTo IL_50
				End If
				IL_47:
				num2 = 6
				result = A_2
				GoTo IL_10C
				IL_50:
				num2 = 8
				Me.O_o.O00Oo. = New O\u3002\u3000\u3002\u3000\u3000()
				IL_5D:
				num2 = 9
				Me.O_o.O00Oo..Text = A_0.PropertyDescriptor.DisplayName
				IL_76:
				num2 = 10
				If A_2 Is Nothing Then
					GoTo IL_95
				End If
				IL_7C:
				num2 = 11
				Me.O_o.O00Oo..Oo_.o___.().Text = Conversions.ToString(A_2)
				IL_95:
				num2 = 12
				If Me.O_o.O00Oo..ShowDialog(Me.O_o.O00Oo.) <> DialogResult.OK Then
					GoTo IL_EA
				End If
				IL_AC:
				num2 = 13
				If Operators.CompareString(Me.O_o.O00Oo..Oo_.o___.().Text, "", True) <= 0 Then
					GoTo IL_E3
				End If
				IL_CD:
				num2 = 14
				result = Me.O_o.O00Oo..Oo_.o___.().Text
				GoTo IL_F4
				IL_E3:
				num2 = 16
				result = Nothing
				GoTo IL_F4
				IL_EA:
				num2 = 18
				result = RuntimeHelpers.GetObjectValue(A_2)
				IL_F4:
				num2 = 19
				Me.O_o.O00Oo..Dispose()
				IL_102:
				num2 = 20
				Me.O_o.O00Oo. = Nothing
				IL_10C:
				GoTo IL_1B2
				IL_111:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_173:
				GoTo IL_1A7
				IL_175:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_185:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_175
			End Try
			IL_1A7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1B2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0400007B RID: 123
		Private <<EMPTY_NAME>> As IWindowsFormsEditorService

		' Token: 0x0400007C RID: 124
		Private <<EMPTY_NAME>> As O\u3002\u3000\u3002\u3000\u3000
	End Class
End Namespace
