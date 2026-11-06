Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000431 RID: 1073
	<EditorBrowsable(EditorBrowsableState.Never)>
	<oO0oooo("1544")>
	Public NotInheritable Module ProjectConfig
		' Token: 0x060046C4 RID: 18116 RVA: 0x001CDE6F File Offset: 0x001CC06F
		Public Sub SaveConfigValue(Name As String, Value As Object)
			ConfigFunctions.SaveValue(Name, RuntimeHelpers.GetObjectValue(Value), O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), O_O0OO.O_O._Oo.())
		End Sub

		' Token: 0x060046C5 RID: 18117 RVA: 0x001CDE96 File Offset: 0x001CC096
		Public Function GetConfigValue(Name As String, DefaultValue As Object) As Object
			Return ConfigFunctions.GetValue(Name, RuntimeHelpers.GetObjectValue(DefaultValue), O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), O_O0OO.O_O._Oo.())
		End Function

		' Token: 0x060046C6 RID: 18118 RVA: 0x001CDEBD File Offset: 0x001CC0BD
		Public Sub RemoveConfigItem(Name As String)
			ConfigFunctions.RemoveItem(Name, O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), O_O0OO.O_O._Oo.())
		End Sub

		' Token: 0x060046C7 RID: 18119 RVA: 0x001CDEDE File Offset: 0x001CC0DE
		Public Sub ClearConfigItem()
			ConfigFunctions.ClearItmes(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()))
		End Sub

		' Token: 0x060046C8 RID: 18120 RVA: 0x001CDEF9 File Offset: 0x001CC0F9
		Public Sub SaveAllConfigItem()
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
		End Sub
	End Module
End Namespace
