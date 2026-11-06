Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Neodynamic.WinControls.BarcodeProfessional

Namespace Foxtable
	' Token: 0x0200003B RID: 59
	Friend Class OoOO___oo
		Inherits StringConverter

		' Token: 0x0600028D RID: 653 RVA: 0x00005B66 File Offset: 0x00003D66
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x0600028E RID: 654 RVA: 0x00005B69 File Offset: 0x00003D69
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x0600028F RID: 655 RVA: 0x00005B6C File Offset: 0x00003D6C
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			list.AddRange([Enum].GetNames(GetType(Symbology)))
			list.Sort()
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
