Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing.Design
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B8 RID: 1208
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class RibbonItemCollectionEditor
		Inherits UITypeEditor

		' Token: 0x06004E5F RID: 20063 RVA: 0x00208070 File Offset: 0x00206270
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x06004E60 RID: 20064 RVA: 0x00208098 File Offset: 0x00206298
		Public Overrides Function EditValue(context As ITypeDescriptorContext, provider As IServiceProvider, value As Object) As Object
			Dim result As Object
			If context Is Nothing OrElse context.Instance Is Nothing OrElse provider Is Nothing Then
				result = value
			Else
				Me.oo_00OOO_o.0O. = CType(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
				Dim form As Form = Form.ActiveForm
				If form IsNot Nothing AndAlso Not(TypeOf form Is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000) AndAlso Not(TypeOf form Is o_\u3002\u3002\u3000\u3000\u3002) Then
					form = Nothing
				End If
				If Me.oo_00OOO_o.0O. Is Nothing Then
					result = value
				Else
					If TypeOf context.Instance Is ContextMenuCollection Then
						Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(Nothing, RibbonPaneEnum.Right, form)
						Me.oo_00OOO_o.0O..Text = Me.oo_00OOO_o.0O..Text + " - 快捷菜单"
					ElseIf TypeOf context.Instance Is RibbonTabCollection Then
						Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(Nothing, RibbonPaneEnum.Left, form)
						Me.oo_00OOO_o.0O..Text = Me.oo_00OOO_o.0O..Text + " - 功能区"
					ElseIf TypeOf context.Instance Is RibbonTopTabCollection Then
						Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(Nothing, RibbonPaneEnum.Bottom, form)
						Me.oo_00OOO_o.0O..Text = Me.oo_00OOO_o.0O..Text + " - 功能区组"
					Else
						Dim dataRow As DataRow = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), RibbonBase).DataRow
						Dim ribbonItemTypeEnum As RibbonItemTypeEnum = CType(Conversions.ToInteger(dataRow("Type")), RibbonItemTypeEnum)
						If ribbonItemTypeEnum <= RibbonItemTypeEnum.ComboBox Then
							If ribbonItemTypeEnum <> RibbonItemTypeEnum.ApplicationMenu Then
								If ribbonItemTypeEnum <> RibbonItemTypeEnum.ComboBox Then
									GoTo IL_27D
								End If
							Else
								Dim name As String = context.PropertyDescriptor.Name
								If Operators.CompareString(name, "Items", True) = 0 Then
									Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form)
									GoTo IL_28B
								End If
								If Operators.CompareString(name, "RightPaneItems", True) = 0 Then
									Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form)
									GoTo IL_28B
								End If
								If Operators.CompareString(name, "BottomPaneItems", True) = 0 Then
									Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Bottom, form)
									GoTo IL_28B
								End If
								GoTo IL_28B
							End If
						ElseIf ribbonItemTypeEnum <> RibbonItemTypeEnum.FontComboBox Then
							If ribbonItemTypeEnum <> RibbonItemTypeEnum.Gallery Then
								GoTo IL_27D
							End If
							Dim name2 As String = context.PropertyDescriptor.Name
							If Operators.CompareString(name2, "Items", True) = 0 Then
								Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form)
								GoTo IL_28B
							End If
							If Operators.CompareString(name2, "MenuItems", True) = 0 Then
								Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form)
								GoTo IL_28B
							End If
							GoTo IL_28B
						End If
						Dim name3 As String = context.PropertyDescriptor.Name
						If Operators.CompareString(name3, "Items", True) = 0 Then
							Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form)
							GoTo IL_28B
						End If
						If Operators.CompareString(name3, "MenuItems", True) = 0 Then
							Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Right, form)
							GoTo IL_28B
						End If
						GoTo IL_28B
						IL_27D:
						Me.oo_00OOO_o.0O. = New o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(dataRow, RibbonPaneEnum.Left, form)
						IL_28B:
						Me.oo_00OOO_o.0O..Text = String.Concat(New String() { Me.oo_00OOO_o.0O..Text, " - ", CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), RibbonBase).Name, " - ", context.PropertyDescriptor.DisplayName })
					End If
					If form IsNot Nothing Then
						If TypeOf form Is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 Then
							CType(form, o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000).ooO.Oo_. = Me.oo_00OOO_o.0O.
						ElseIf TypeOf form Is o_\u3002\u3002\u3000\u3000\u3002 Then
							CType(form, o_\u3002\u3002\u3000\u3000\u3002).oOoo_0O.oo00oO. = Me.oo_00OOO_o.0O.
						End If
					End If
					Me.oo_00OOO_o.0O..Owner = Main.OO_O.o.
					Me.oo_00OOO_o.0O..ShowDialog()
					result = RuntimeHelpers.GetObjectValue(value)
					If Me.oo_00OOO_o.0O. IsNot Nothing AndAlso Not Me.oo_00OOO_o.0O..oO.o00o00Oo_O. Then
						Me.oo_00OOO_o.0O..Dispose()
						Me.oo_00OOO_o.0O. = Nothing
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0400206F RID: 8303
		Private <<EMPTY_NAME>> As IWindowsFormsEditorService

		' Token: 0x04002070 RID: 8304
		Private <<EMPTY_NAME>> As o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000
	End Class
End Namespace
