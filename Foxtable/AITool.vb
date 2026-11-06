Imports System
Imports System.Collections.Generic
Imports System.Runtime.CompilerServices

Namespace Foxtable
	' Token: 0x020001D9 RID: 473
	Public Class AITool
		' Token: 0x060016EE RID: 5870 RVA: 0x00094224 File Offset: 0x00092424
		Public Sub New()
			Me.Parameters = New List(Of AIParameter)()
		End Sub

		' Token: 0x170004E3 RID: 1251
		' (get) Token: 0x060016EF RID: 5871 RVA: 0x00094237 File Offset: 0x00092437
		' (set) Token: 0x060016F0 RID: 5872 RVA: 0x0009423F File Offset: 0x0009243F
		Public Property Name As String

		' Token: 0x170004E4 RID: 1252
		' (get) Token: 0x060016F1 RID: 5873 RVA: 0x00094248 File Offset: 0x00092448
		' (set) Token: 0x060016F2 RID: 5874 RVA: 0x00094250 File Offset: 0x00092450
		Public Property Description As String

		' Token: 0x170004E5 RID: 1253
		' (get) Token: 0x060016F3 RID: 5875 RVA: 0x00094259 File Offset: 0x00092459
		' (set) Token: 0x060016F4 RID: 5876 RVA: 0x00094261 File Offset: 0x00092461
		Public Property Parameters As List(Of AIParameter)

		' Token: 0x060016F5 RID: 5877 RVA: 0x0009426C File Offset: 0x0009246C
		Public Function AddParameter(name As String, type As String, description As String, Optional isRequired As Boolean = False, Optional arrayItemType As String = "string", Optional enumValues As IEnumerable(Of Object) = Nothing) As AIParameter
			Dim aiparameter As AIParameter = New AIParameter() With { .Name = name, .Type = type, .Description = description, .IsRequired = isRequired, .ArrayItemType = arrayItemType, .EnumValues = enumValues }
			Me.Parameters.Add(aiparameter)
			Return aiparameter
		End Function

		' Token: 0x0400091E RID: 2334
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400091F RID: 2335
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000920 RID: 2336
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As List(Of AIParameter)
	End Class
End Namespace
