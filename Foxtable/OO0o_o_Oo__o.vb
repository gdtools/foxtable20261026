Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005A RID: 90
	Friend Class OO0o_o_Oo__o
		Inherits UITypeEditor

		' Token: 0x060002FC RID: 764 RVA: 0x000081FC File Offset: 0x000063FC
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002FD RID: 765 RVA: 0x00008224 File Offset: 0x00006424
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
				GoTo IL_F1
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
				GoTo IL_F1
				IL_50:
				num2 = 7
				Me.dlg = New SaveFileDialog()
				IL_5D:
				num2 = 8
				Me.dlg.OverwritePrompt = False
				IL_6B:
				num2 = 9
				Dim ooo0___ As Ooo0___ = CType(context.PropertyDescriptor.Attributes(GetType(Ooo0___)), Ooo0___)
				IL_8F:
				num2 = 10
				Me.dlg.Filter = ooo0___.O0oO_0._o_.()
				IL_A4:
				ooo0___ = Nothing
				IL_A7:
				num2 = 12
				Me.dlg.FilterIndex = 0
				IL_B6:
				num2 = 13
				If Me.dlg.ShowDialog() <> DialogResult.OK Then
					GoTo IL_E7
				End If
				IL_C7:
				num2 = 14
				result = c.OOOOO.o.().FileSystem.GetName(Me.dlg.FileName)
				GoTo IL_F1
				IL_E7:
				num2 = 16
				result = RuntimeHelpers.GetObjectValue(value)
				IL_F1:
				GoTo IL_187
				IL_F6:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_148:
				GoTo IL_17C
				IL_14A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_15A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_14A
			End Try
			IL_17C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_187:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000079 RID: 121
		Private wfes As IWindowsFormsEditorService

		' Token: 0x0400007A RID: 122
		Private dlg As SaveFileDialog
	End Class
End Namespace
