Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200004B RID: 75
	Friend Class ooO0o0_oO0_0
		Inherits UITypeEditor

		' Token: 0x060002C1 RID: 705 RVA: 0x000069C4 File Offset: 0x00004BC4
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002C2 RID: 706 RVA: 0x000069EC File Offset: 0x00004BEC
		Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
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
				If context IsNot Nothing AndAlso context.Instance IsNot Nothing AndAlso provider IsNot Nothing Then
					GoTo IL_20
				End If
				IL_17:
				num2 = 3
				result = value
				GoTo IL_E9
				IL_20:
				num2 = 4
				Me.oo.O0o0o. = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_3D:
				num2 = 5
				If Me.oo.O0o0o. IsNot Nothing Then
					GoTo IL_50
				End If
				IL_47:
				num2 = 6
				result = value
				GoTo IL_E9
				IL_50:
				num2 = 8
				Me.oo.O0o0o. = New O\u3002\u3002o()
				IL_5D:
				num2 = 9
				If value Is Nothing Then
					GoTo IL_77
				End If
				IL_63:
				num2 = 10
				Me.oo.O0o0o..Value = Conversions.ToString(value)
				IL_77:
				num2 = 11
				If Me.oo.O0o0o..ShowDialog(Me.oo.O0o0o.) <> DialogResult.OK Then
					GoTo IL_C7
				End If
				IL_8E:
				num2 = 12
				If Operators.CompareString(Me.oo.O0o0o..oo0.O_o.().Text, "", True) <= 0 Then
					GoTo IL_C0
				End If
				IL_AF:
				num2 = 13
				result = Me.oo.O0o0o..Value
				GoTo IL_D1
				IL_C0:
				num2 = 15
				result = Nothing
				GoTo IL_D1
				IL_C7:
				num2 = 17
				result = RuntimeHelpers.GetObjectValue(value)
				IL_D1:
				num2 = 18
				Me.oo.O0o0o..Dispose()
				IL_DF:
				num2 = 19
				Me.oo.O0o0o. = Nothing
				IL_E9:
				GoTo IL_18B
				IL_EE:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_14C:
				GoTo IL_180
				IL_14E:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_15E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_14E
			End Try
			IL_180:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_18B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0400006F RID: 111
		Private <<EMPTY_NAME>> As IWindowsFormsEditorService

		' Token: 0x04000070 RID: 112
		Private <<EMPTY_NAME>> As O\u3002\u3002o
	End Class
End Namespace
