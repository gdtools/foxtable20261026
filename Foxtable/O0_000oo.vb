Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Foxtable.Syscmd
Imports Foxtable.Word
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000056 RID: 86
	Friend Class O0_000oo
		Inherits UITypeEditor

		' Token: 0x060002E9 RID: 745 RVA: 0x00007D18 File Offset: 0x00005F18
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002EA RID: 746 RVA: 0x00007D40 File Offset: 0x00005F40
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
				GoTo IL_17B
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
				GoTo IL_17B
				IL_50:
				num2 = 7
				Me.dlg = New OpenFileDialog()
				IL_5D:
				num2 = 8
				If Not(TypeOf context.Instance Is ReportProperty) AndAlso Not(TypeOf context.Instance Is ReportProperty) Then
					GoTo IL_D7
				End If
				IL_79:
				num2 = 9
				Dim text As String = OO_00oOO.ProjectPath + "Attachments"
				IL_8D:
				num2 = 10
				If OO_00oOO.FileSys.DirectoryExists(text) Then
					GoTo IL_AD
				End If
				IL_9E:
				num2 = 11
				OO_00oOO.FileSys.CreateDirectory(text)
				IL_AD:
				num2 = 12
				Me.dlg.InitialDirectory = text
				IL_BD:
				num2 = 13
				AddHandler Me.dlg.FileOk, AddressOf Project.O0O0o.Oo0OO_oO.
				IL_D7:
				num2 = 14
				Dim ooo0___ As Ooo0___ = CType(context.PropertyDescriptor.Attributes(GetType(Ooo0___)), Ooo0___)
				IL_FB:
				num2 = 15
				Me.dlg.Filter = ooo0___.O0oO_0._o_.()
				IL_110:
				ooo0___ = Nothing
				IL_113:
				num2 = 17
				Me.dlg.FilterIndex = 0
				IL_122:
				num2 = 18
				If Me.dlg.ShowDialog() <> DialogResult.OK Then
					GoTo IL_171
				End If
				IL_133:
				num2 = 19
				Dim text2 As String = ooO.oO0__o.0o__.(Me.dlg.FileName, Nothing, Nothing)
				IL_14A:
				num2 = 20
				If Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_165
				End If
				IL_15D:
				num2 = 21
				result = text2
				GoTo IL_17B
				IL_165:
				num2 = 23
				result = RuntimeHelpers.GetObjectValue(value)
				GoTo IL_17B
				IL_171:
				num2 = 25
				result = RuntimeHelpers.GetObjectValue(value)
				IL_17B:
				GoTo IL_235
				IL_180:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1F6:
				GoTo IL_22A
				IL_1F8:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_208:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1F8
			End Try
			IL_22A:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_235:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000077 RID: 119
		Private wfes As IWindowsFormsEditorService

		' Token: 0x04000078 RID: 120
		Private dlg As OpenFileDialog
	End Class
End Namespace
