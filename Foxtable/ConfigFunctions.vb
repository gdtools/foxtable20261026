Imports System
Imports System.ComponentModel
Imports System.Data
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000434 RID: 1076
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module ConfigFunctions
		' Token: 0x06004724 RID: 18212 RVA: 0x001D6478 File Offset: 0x001D4678
		Public Sub SaveValue(Name As String, Value As Object, dt As DataTable, ProjectIdentify As String)
			If Value Is Nothing Then
				Value = ""
			End If
			Dim dataRow As DataRow = dt.Rows.Find(New Object() { O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)), o0_O.o0OOOo0_Oo.__0. })
			If dataRow Is Nothing Then
				dataRow = dt.NewRow()
				dataRow("Name") = O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6))
				dataRow("Type") = o0_O.o0OOOo0_Oo.__0.
				dt.Rows.Add(dataRow)
			End If
			dataRow("Config") = O00.EncryptText(Value.ToString(), Name, ProjectIdentify.Substring(6))
			Oo00.O0Oo_O.0O_0O.(dataRow)
		End Sub

		' Token: 0x06004725 RID: 18213 RVA: 0x001D652C File Offset: 0x001D472C
		Public Function GetValue(Name As String, DefaultValue As Object, dt As DataTable, ProjectIdentify As String) As Object
			Dim dataRow As DataRow = dt.Rows.Find(New Object() { O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)), o0_O.o0OOOo0_Oo.__0. })
			Dim result As Object
			If dataRow Is Nothing OrElse dataRow.IsNull("Config") Then
				result = DefaultValue
			Else
				result = O00.DecryptText(dataRow("Config").ToString(), Name, ProjectIdentify.Substring(6))
			End If
			Return result
		End Function

		' Token: 0x06004726 RID: 18214 RVA: 0x001D65A0 File Offset: 0x001D47A0
		Public Sub RemoveItem(Name As String, dt As DataTable, ProjectIdentify As String)
			Dim dataRow As DataRow = dt.Rows.Find(New Object() { O00.EncryptText(Name, "Config", ProjectIdentify.Substring(6)), o0_O.o0OOOo0_Oo.__0. })
			If dataRow IsNot Nothing Then
				dataRow.Delete()
				Oo00.O0Oo_O.0O_0O.(dataRow)
			End If
		End Sub

		' Token: 0x06004727 RID: 18215 RVA: 0x001D65F0 File Offset: 0x001D47F0
		Public Sub ClearItmes(dt As DataTable)
			For Each dataRow As DataRow In dt.[Select]("[Type] = " + Conversions.ToString(16), "", DataViewRowState.CurrentRows)
				dataRow.Delete()
				Oo00.O0Oo_O.0O_0O.(dataRow)
			Next
		End Sub
	End Module
End Namespace
