Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text

Namespace Foxtable
	' Token: 0x0200003E RID: 62
	Friend Class o___o_O__
		Inherits StringConverter

		' Token: 0x06000296 RID: 662 RVA: 0x00005BE5 File Offset: 0x00003DE5
		Public Overrides Function GetStandardValuesSupported(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000297 RID: 663 RVA: 0x00005BE8 File Offset: 0x00003DE8
		Public Overrides Function GetStandardValuesExclusive(context As ITypeDescriptorContext) As Boolean
			Return True
		End Function

		' Token: 0x06000298 RID: 664 RVA: 0x00005BEC File Offset: 0x00003DEC
		Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
			Dim list As List(Of String) = New List(Of String)()
			For Each encodingInfo As EncodingInfo In Encoding.GetEncodings()
				list.Add(encodingInfo.Name)
			Next
			list.Sort()
			Return New TypeConverter.StandardValuesCollection(list)
		End Function
	End Class
End Namespace
