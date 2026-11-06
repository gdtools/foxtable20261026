Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000055 RID: 85
	Friend Class ooo
		Inherits UITypeEditor

		' Token: 0x060002E4 RID: 740 RVA: 0x00007AFC File Offset: 0x00005CFC
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002E5 RID: 741 RVA: 0x00007B24 File Offset: 0x00005D24
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
				GoTo IL_D5
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
				GoTo IL_D5
				IL_50:
				num2 = 7
				Me.dlg = New OpenFileDialog()
				IL_5D:
				num2 = 8
				Me.dlg.Filter = O_O0OO.o__._oo0O.()
				IL_6F:
				num2 = 9
				Me.dlg.FilterIndex = 0
				IL_7E:
				num2 = 10
				If Me.dlg.ShowDialog() <> DialogResult.OK Then
					GoTo IL_CB
				End If
				IL_8F:
				num2 = 11
				Dim text As String = ooO.oo__.O000_o_O.(Me.dlg.FileName)
				IL_A4:
				num2 = 12
				If Operators.CompareString(text, "", True) <= 0 Then
					GoTo IL_BF
				End If
				IL_B7:
				num2 = 13
				result = text
				GoTo IL_D5
				IL_BF:
				num2 = 15
				result = RuntimeHelpers.GetObjectValue(value)
				GoTo IL_D5
				IL_CB:
				num2 = 17
				result = RuntimeHelpers.GetObjectValue(value)
				IL_D5:
				GoTo IL_16F
				IL_DA:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_130:
				GoTo IL_164
				IL_132:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_142:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_132
			End Try
			IL_164:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_16F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060002E6 RID: 742 RVA: 0x00007CC8 File Offset: 0x00005EC8
		Public Overrides Function GetPaintValueSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002E7 RID: 743 RVA: 0x00007CCC File Offset: 0x00005ECC
		Public Overrides Sub PaintValue(e As PaintValueEventArgs)
			Dim text As String = Conversions.ToString(e.Value)
			If Operators.CompareString(text, "", True) > 0 Then
				Dim image As Image = OO_00oOO.GetImage(text)
				If image IsNot Nothing Then
					e.Graphics.DrawImage(image, e.Bounds)
				End If
			End If
		End Sub

		' Token: 0x04000075 RID: 117
		Private wfes As IWindowsFormsEditorService

		' Token: 0x04000076 RID: 118
		Private dlg As OpenFileDialog
	End Class
End Namespace
