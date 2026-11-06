Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200004E RID: 78
	Friend Class oo0OOO_0__
		Inherits StringConverter

		' Token: 0x060002CB RID: 715 RVA: 0x00006D0D File Offset: 0x00004F0D
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x060002CC RID: 716 RVA: 0x00006D10 File Offset: 0x00004F10
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return False
		End Function

		' Token: 0x060002CD RID: 717 RVA: 0x00006D14 File Offset: 0x00004F14
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim num As Integer
			Dim result As TypeConverter.StandardValuesCollection
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = ""
				IL_10:
				num2 = 3
				If Not(TypeOf context.Instance Is o_0oooo_OO) Then
					GoTo IL_149
				End If
				IL_22:
				num2 = 4
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ComboboxProperty) Then
					GoTo IL_5E
				End If
				IL_3B:
				num2 = 5
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ComboboxProperty).DataSource
				GoTo IL_149
				IL_5E:
				num2 = 7
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is ListBoxProperty) Then
					GoTo IL_9A
				End If
				IL_77:
				num2 = 8
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), ListBoxProperty).DataSource
				GoTo IL_149
				IL_9A:
				num2 = 10
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is CheckedListBoxProperty) Then
					GoTo IL_D5
				End If
				IL_B4:
				num2 = 11
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedListBoxProperty).DataSource
				GoTo IL_149
				IL_D5:
				num2 = 13
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is CheckedComboBoxProperty) Then
					GoTo IL_110
				End If
				IL_EF:
				num2 = 14
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), CheckedComboBoxProperty).DataSource
				GoTo IL_149
				IL_110:
				num2 = 16
				If Not(TypeOf CType(context.Instance, o_0oooo_OO).Oo._o.()Is DataColumnProperty) Then
					GoTo IL_149
				End If
				IL_12A:
				num2 = 17
				text = CType(CType(context.Instance, o_0oooo_OO).Oo._o.(), DataColumnProperty).DataSource
				IL_149:
				num2 = 18
				If Operators.CompareString(text, "", True) <> 0 AndAlso OO_00oOO.DataTables.Contains(text) Then
					GoTo IL_173
				End If
				IL_169:
				num2 = 19
				result = Nothing
				GoTo IL_20D
				IL_173:
				num2 = 20
				Dim list As List(Of String) = New List(Of String)()
				IL_17D:
				num2 = 21
				Dim enumerator As IEnumerator(Of DataCol) = OO_00oOO.DataTables(text).DataCols.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataCol As DataCol = enumerator.Current
					IL_1A3:
					num2 = 22
					list.Add(dataCol.Name)
					IL_1B4:
					num2 = 23
				End While
				IL_1C0:
				num2 = 24
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_1CE:
				num2 = 25
				If Not OO_00oOO.DataTables(text).BaseTable.Columns.Contains("_Identify") Then
					GoTo IL_202
				End If
				IL_1F3:
				num2 = 26
				list.Add("_Identify")
				IL_202:
				num2 = 27
				result = New TypeConverter.StandardValuesCollection(list)
				IL_20D:
				GoTo IL_2CF
				IL_212:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_290:
				GoTo IL_2C4
				IL_292:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2A2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_292
			End Try
			IL_2C4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2CF:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function
	End Class
End Namespace
