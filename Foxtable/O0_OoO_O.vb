Imports System
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200005C RID: 92
	Friend Class O0_OoO_O
		Inherits UITypeEditor

		' Token: 0x06000302 RID: 770 RVA: 0x000085FC File Offset: 0x000067FC
		Public Overrides Function GetEditStyle(context As ITypeDescriptorContext) As UITypeEditorEditStyle
			Dim result As UITypeEditorEditStyle
			If context IsNot Nothing AndAlso context.Instance IsNot Nothing Then
				result = UITypeEditorEditStyle.Modal
			Else
				result = MyBase.GetEditStyle(context)
			End If
			Return result
		End Function

		' Token: 0x06000303 RID: 771 RVA: 0x00008624 File Offset: 0x00006824
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
				GoTo IL_218
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
				GoTo IL_218
				IL_59:
				num2 = 8
				Dim text As String = ""
				IL_62:
				num2 = 9
				Dim dataTable As DataTable = Nothing
				IL_68:
				num2 = 10
				If Not(TypeOf context.Instance Is o_0oooo_OO) Then
					GoTo IL_191
				End If
				IL_7B:
				num2 = 11
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is TableGridProperty) Then
					GoTo IL_191
				End If
				IL_98:
				num2 = 12
				If Operators.CompareString(context.PropertyDescriptor.Name, "ColumnList", True) <> 0 Then
					GoTo IL_191
				End If
				IL_B6:
				num2 = 13
				Dim tableGridProperty As TableGridProperty = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), TableGridProperty)
				IL_D0:
				num2 = 14
				If tableGridProperty.TableType IsNot Nothing OrElse Operators.CompareString(tableGridProperty.RelationTable, "", True) <= 0 OrElse Not OO_00oOO.Tables.get_Contains(tableGridProperty.RelationTable) Then
					GoTo IL_11E
				End If
				IL_104:
				num2 = 15
				text = tableGridProperty.RelationTable
				IL_110:
				num2 = 16
				a_ = tableGridProperty.ColumnList
				GoTo IL_18E
				IL_11E:
				num2 = 18
				If(tableGridProperty.TableType <> 2 AndAlso tableGridProperty.TableType <> 1) OrElse Operators.CompareString(tableGridProperty.SelectString, "", True) <= 0 Then
					GoTo IL_18E
				End If
				IL_14A:
				num2 = 19
				Dim sqlcommand As SQLCommand = New SQLCommand()
				IL_154:
				num2 = 20
				sqlcommand.CommandText = tableGridProperty.SelectString
				IL_165:
				num2 = 21
				sqlcommand.ConnectionName = tableGridProperty.Connection
				IL_176:
				num2 = 22
				dataTable = sqlcommand.OO__00.__.()
				IL_182:
				num2 = 23
				a_ = tableGridProperty.ColumnList
				IL_18E:
				tableGridProperty = Nothing
				IL_191:
				num2 = 25
				If Operators.CompareString(text, "", True) <= 0 OrElse Not OO_00oOO.Tables.get_Contains(text) Then
					GoTo IL_1E4
				End If
				IL_1B2:
				num2 = 26
				Dim o_u3002__u3000_u3000_u As o\u3002_\u3000\u3000\u3000 = New o\u3002_\u3000\u3000\u3000(OO_00oOO.Tables(text), a_)
				IL_1CA:
				num2 = 27
				If o_u3002__u3000_u3000_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_213
				End If
				IL_1D7:
				num2 = 28
				result = o_u3002__u3000_u3000_u.O.0oo0O0_o.
				GoTo IL_218
				IL_1E4:
				num2 = 30
				If dataTable Is Nothing Then
					GoTo IL_213
				End If
				IL_1EB:
				num2 = 31
				Dim o_u3002__u3000_u3000_u2 As o\u3002_\u3000\u3000\u3000 = New o\u3002_\u3000\u3000\u3000(dataTable, a_)
				IL_1F9:
				num2 = 32
				If o_u3002__u3000_u3000_u2.ShowDialog() <> DialogResult.OK Then
					GoTo IL_213
				End If
				IL_206:
				num2 = 33
				result = o_u3002__u3000_u3000_u2.O.0oo0O0_o.
				GoTo IL_218
				IL_213:
				num2 = 34
				result = value
				IL_218:
				GoTo IL_2F6
				IL_21D:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_2B7:
				GoTo IL_2EB
				IL_2B9:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2C9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2B9
			End Try
			IL_2EB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2F6:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x0400007D RID: 125
		Private wfes As IWindowsFormsEditorService
	End Class
End Namespace
