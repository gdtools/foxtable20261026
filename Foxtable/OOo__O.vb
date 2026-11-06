Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000054 RID: 84
	Friend Class OOo__O
		Inherits UITypeEditor

		' Token: 0x060002E1 RID: 737 RVA: 0x0000795C File Offset: 0x00005B5C
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002E2 RID: 738 RVA: 0x00007984 File Offset: 0x00005B84
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
				GoTo IL_B3
				IL_20:
				num2 = 4
				Me.wfes = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_3D:
				num2 = 5
				If Me.wfes IsNot Nothing Then
					GoTo IL_4D
				End If
				IL_47:
				num2 = 6
				result = value
				GoTo IL_B3
				IL_4D:
				num2 = 7
				Me.dlg = New FolderBrowserDialog()
				IL_5A:
				num2 = 8
				If value Is Nothing OrElse Operators.CompareString(value.ToString(), "", True) <= 0 Then
					GoTo IL_87
				End If
				IL_73:
				num2 = 9
				Me.dlg.SelectedPath = value.ToString()
				IL_87:
				num2 = 10
				If Me.dlg.ShowDialog() <> DialogResult.OK Then
					GoTo IL_A9
				End If
				IL_98:
				num2 = 11
				result = Me.dlg.SelectedPath
				GoTo IL_B3
				IL_A9:
				num2 = 13
				result = RuntimeHelpers.GetObjectValue(value)
				IL_B3:
				GoTo IL_13D
				IL_B8:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_FE:
				GoTo IL_132
				IL_100:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_110:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_100
			End Try
			IL_132:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_13D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000073 RID: 115
		Private wfes As IWindowsFormsEditorService

		' Token: 0x04000074 RID: 116
		Private dlg As FolderBrowserDialog
	End Class
End Namespace
