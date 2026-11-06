Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200004F RID: 79
	Friend Class O00_
		Inherits UITypeEditor

		' Token: 0x060002CF RID: 719 RVA: 0x00007020 File Offset: 0x00005220
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002D0 RID: 720 RVA: 0x00007048 File Offset: 0x00005248
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
				Dim a_ As String = ""
				IL_10:
				num2 = 3
				If context IsNot Nothing AndAlso context.Instance IsNot Nothing AndAlso provider IsNot Nothing Then
					GoTo IL_29
				End If
				IL_20:
				num2 = 4
				result = value
				GoTo IL_291
				IL_29:
				num2 = 5
				Me.wfes = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				IL_46:
				num2 = 6
				If Me.wfes IsNot Nothing Then
					GoTo IL_59
				End If
				IL_50:
				num2 = 7
				result = value
				GoTo IL_291
				IL_59:
				num2 = 8
				Dim text As String = ""
				IL_62:
				num2 = 9
				If Not(TypeOf context.Instance Is o_0oooo_OO) Then
					GoTo IL_233
				End If
				IL_75:
				num2 = 10
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is DataColumnProperty) Then
					GoTo IL_187
				End If
				IL_92:
				num2 = 11
				Dim name As String = context.PropertyDescriptor.Name
				IL_A2:
				num2 = 13
				If Operators.CompareString(name, "TreeBuildCols", True) <> 0 Then
					GoTo IL_EE
				End If
				IL_B4:
				num2 = 14
				Dim dataColumnProperty As DataColumnProperty = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty)
				IL_CE:
				num2 = 15
				text = dataColumnProperty.TreeDataTable
				IL_DA:
				num2 = 16
				a_ = dataColumnProperty.TreeBuildCols
				IL_E6:
				dataColumnProperty = Nothing
				GoTo IL_233
				IL_EE:
				num2 = 19
				If Operators.CompareString(name, "TreeSourceCols", True) <> 0 Then
					GoTo IL_13A
				End If
				IL_100:
				num2 = 20
				Dim dataColumnProperty2 As DataColumnProperty = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty)
				IL_11A:
				num2 = 21
				text = dataColumnProperty2.TreeDataTable
				IL_126:
				num2 = 22
				a_ = dataColumnProperty2.TreeSourceCols
				IL_132:
				dataColumnProperty2 = Nothing
				GoTo IL_233
				IL_13A:
				num2 = 25
				If Operators.CompareString(name, "TreeReceiveCols", True) <> 0 Then
					GoTo IL_233
				End If
				IL_14F:
				num2 = 26
				text = OO_00oOO.CurrentTable.DataTable.Name
				IL_163:
				num2 = 27
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty).TreeReceiveCols
				GoTo IL_233
				IL_187:
				num2 = 29
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is RecordGridProperty) Then
					GoTo IL_233
				End If
				IL_1A4:
				num2 = 30
				If Operators.CompareString(context.PropertyDescriptor.Name, "Columns", True) <> 0 Then
					GoTo IL_233
				End If
				IL_1BF:
				num2 = 31
				Dim recordGridProperty As RecordGridProperty = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), RecordGridProperty)
				IL_1D9:
				num2 = 32
				If Operators.CompareString(recordGridProperty.TableName, "", True) <= 0 OrElse Not OO_00oOO.Tables.get_Contains(recordGridProperty.TableName) Then
					GoTo IL_230
				End If
				IL_204:
				num2 = 33
				text = OO_00oOO.Tables(recordGridProperty.TableName).DataTable.Name
				IL_224:
				num2 = 34
				a_ = recordGridProperty.Columns
				IL_230:
				recordGridProperty = Nothing
				IL_233:
				num2 = 36
				If Operators.CompareString(text, "", True) <> 0 AndAlso OO_00oOO.DataTables.Contains(text) Then
					GoTo IL_25A
				End If
				IL_253:
				num2 = 37
				result = value
				GoTo IL_291
				IL_25A:
				num2 = 39
				Dim o_u3000O_u3002_u3000_u3002_u3000_u3000_u As O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000 = New O\u3000O\u3002\u3000\u3002\u3000\u3000\u3000(OO_00oOO.Tables(text), a_)
				IL_272:
				num2 = 40
				If o_u3000O_u3002_u3000_u3002_u3000_u3000_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_28C
				End If
				IL_27F:
				num2 = 41
				result = o_u3000O_u3002_u3000_u3002_u3000_u3000_u.O0_00O_o.__o.
				GoTo IL_291
				IL_28C:
				num2 = 42
				result = value
				IL_291:
				GoTo IL_38F
				IL_296:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_350:
				GoTo IL_384
				IL_352:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_362:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_352
			End Try
			IL_384:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_38F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000071 RID: 113
		Private wfes As IWindowsFormsEditorService
	End Class
End Namespace
