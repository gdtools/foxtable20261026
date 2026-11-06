Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000053 RID: 83
	Friend Class O0O00
		Inherits UITypeEditor

		' Token: 0x060002DE RID: 734 RVA: 0x000075A8 File Offset: 0x000057A8
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x060002DF RID: 735 RVA: 0x000075D0 File Offset: 0x000057D0
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
				GoTo IL_27D
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
				GoTo IL_27D
				IL_59:
				num2 = 8
				Dim text As String = ""
				IL_62:
				num2 = 9
				If Not(TypeOf context.Instance Is o_0oooo_OO) Then
					GoTo IL_23E
				End If
				IL_75:
				num2 = 10
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ComboboxProperty) Then
					GoTo IL_D2
				End If
				IL_8F:
				num2 = 11
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ComboboxProperty).DataSource
				IL_AE:
				num2 = 12
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ComboboxProperty).DataFilter
				GoTo IL_23E
				IL_D2:
				num2 = 14
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is CheckedComboBoxProperty) Then
					GoTo IL_12F
				End If
				IL_EC:
				num2 = 15
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedComboBoxProperty).DataSource
				IL_10B:
				num2 = 16
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedComboBoxProperty).DataFilter
				GoTo IL_23E
				IL_12F:
				num2 = 18
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ListBoxProperty) Then
					GoTo IL_18C
				End If
				IL_149:
				num2 = 19
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ListBoxProperty).DataSource
				IL_168:
				num2 = 20
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ListBoxProperty).DataFilter
				GoTo IL_23E
				IL_18C:
				num2 = 22
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is CheckedListBoxProperty) Then
					GoTo IL_1E6
				End If
				IL_1A6:
				num2 = 23
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedListBoxProperty).DataSource
				IL_1C5:
				num2 = 24
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedListBoxProperty).DataFilter
				GoTo IL_23E
				IL_1E6:
				num2 = 26
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is DataColumnProperty) Then
					GoTo IL_23E
				End If
				IL_200:
				num2 = 27
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty).DataSource
				IL_21F:
				num2 = 28
				a_ = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty).DataFilter
				IL_23E:
				num2 = 29
				If Operators.CompareString(text, "", True) <> 0 AndAlso OO_00oOO.DataTables.Contains(text) Then
					GoTo IL_265
				End If
				IL_25E:
				num2 = 30
				result = value
				GoTo IL_27D
				IL_265:
				num2 = 31
				result = OO_00oOO.DataTables(text).OOoo__00O_.o_O.(a_, True)
				IL_27D:
				GoTo IL_34F
				IL_282:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_310:
				GoTo IL_344
				IL_312:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_322:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_312
			End Try
			IL_344:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_34F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x04000072 RID: 114
		Private wfes As IWindowsFormsEditorService
	End Class
End Namespace
