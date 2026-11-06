Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005D RID: 93
	Friend Class O0_00_oo0oO_
		Inherits UITypeEditor

		' Token: 0x06000305 RID: 773 RVA: 0x00008954 File Offset: 0x00006B54
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x06000306 RID: 774 RVA: 0x0000897C File Offset: 0x00006B7C
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
				GoTo IL_10C
				IL_20:
				num2 = 4
				Me.wfes = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_3D:
				num2 = 5
				If Me.wfes IsNot Nothing Then
					GoTo IL_50
				End If
				IL_47:
				num2 = 6
				result = value
				GoTo IL_10C
				IL_50:
				num2 = 8
				Me.frmEditor = New O_\u3000()
				IL_5D:
				num2 = 9
				Me.frmEditor.Text = context.PropertyDescriptor.DisplayName
				IL_76:
				num2 = 10
				If value Is Nothing Then
					GoTo IL_95
				End If
				IL_7C:
				num2 = 11
				Me.frmEditor.O_0._o_O0o.().Value = Conversions.ToString(value)
				IL_95:
				num2 = 12
				If Me.wfes.ShowDialog(Me.frmEditor) <> DialogResult.OK Then
					GoTo IL_EA
				End If
				IL_AC:
				num2 = 13
				If Operators.CompareString(Me.frmEditor.O_0._o_O0o.().Text, "", True) <= 0 Then
					GoTo IL_E3
				End If
				IL_CD:
				num2 = 14
				result = Me.frmEditor.O_0._o_O0o.().Text
				GoTo IL_F4
				IL_E3:
				num2 = 16
				result = Nothing
				GoTo IL_F4
				IL_EA:
				num2 = 18
				result = RuntimeHelpers.GetObjectValue(value)
				IL_F4:
				num2 = 19
				Me.frmEditor.Dispose()
				IL_102:
				num2 = 20
				Me.frmEditor = Nothing
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

		' Token: 0x0400007E RID: 126
		Private wfes As IWindowsFormsEditorService

		' Token: 0x0400007F RID: 127
		Private frmEditor As O_\u3000
	End Class
End Namespace
