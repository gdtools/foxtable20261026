Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports ADODB
Imports ADOX

Namespace Foxtable
	' Token: 0x02000235 RID: 565
	<oO0oooo("2122")>
	Public Class ADOXBuilder
		' Token: 0x06001A63 RID: 6755 RVA: 0x000A9E5C File Offset: 0x000A805C
		Public Sub New(A_0 As String)
			Me.o0.0_O0000_O. = New ConnectionClass()
			Me.o0.0_O0000_O. = ""
			Me.o0.0_O0000_O..ConnectionString = OO_00oOO.Connections(A_0).ConnectionString
			Me.o0.0_O0000_O. = (Me.o0.0_O0000_O..Provider.IndexOf("SQLOLEDB", StringComparison.CurrentCultureIgnoreCase) >= 0 Or Me.o0.0_O0000_O..Provider.IndexOf("SQLNCLI", StringComparison.CurrentCultureIgnoreCase) >= 0)
			Me.o.oo. = A_0
		End Sub

		' Token: 0x06001A64 RID: 6756 RVA: 0x000A9EE8 File Offset: 0x000A80E8
		Public Sub New()
			Me.o0.0_O0000_O. = New ConnectionClass()
			Me.o0.0_O0000_O. = ""
			Me.o0.0_O0000_O..ConnectionString = O_O0OO.OoO.0OO__0ooo.().ConnectionString
			Me.o0.0_O0000_O. = "~TMPCLP"
			Me.o.oo. = True
		End Sub

		' Token: 0x06001A65 RID: 6757 RVA: 0x000A9F38 File Offset: 0x000A8138
		Public Sub Open()
			Me.o0.0_O0000_O. = New CatalogClass()
			Me.o0.0_O0000_O..Open("", "", "", -1)
			Me.o0.0_O0000_O..ActiveConnection = Me.o0.0_O0000_O.
		End Sub

		' Token: 0x06001A66 RID: 6758 RVA: 0x000A9F71 File Offset: 0x000A8171
		Public Sub Close()
			Me.o0.0_O0000_O..Close()
			Me.o0.0_O0000_O. = Nothing
		End Sub

		' Token: 0x06001A67 RID: 6759 RVA: 0x000A9F88 File Offset: 0x000A8188
		Public Function NewTable(Name As String) As ADOXTable
			Dim result As ADOXTable
			If Not o_O_o_oOoo__.O_o_._o0.(Name) Then
				result = Nothing
			Else
				result = New ADOXTable(New TableClass() With { .Name = Me.o0.0_O0000_O. + Name, .ParentCatalog = Me.o0.0_O0000_O. }, Me.o0.0_O0000_O., Me.o.oo., Me.o.oo.)
			End If
			Return result
		End Function

		' Token: 0x06001A68 RID: 6760 RVA: 0x000A9FE0 File Offset: 0x000A81E0
		Public Sub AddTable(ADOXTable As ADOXTable, Optional AddLockColumn As Boolean = False, Optional AddSortColumn As Boolean = False)
			Dim oooO__O_0o_.o_. As Table = ADOXTable.oooO__O_0o_.o_.
			If AddLockColumn Or Me.o.oo. Then
				oooO__O_0o_.o_..Columns.Append("_Locked", 11, 0)
				If Me.o0.0_O0000_O. Then
					oooO__O_0o_.o_..Columns("_Locked").Attributes = 2
				End If
			End If
			If AddSortColumn Or Me.o.oo. Then
				oooO__O_0o_.o_..Columns.Append("_SortKey", 131, 0)
				Dim column As Column = oooO__O_0o_.o_..Columns("_SortKey")
				column.Precision = 28
				column.NumericScale = 14
				column.Attributes = 2
			End If
			oooO__O_0o_.o_..Columns.Append("_Identify", 3, 0)
			If Not Me.o.oo. Then
				oooO__O_0o_.o_..Columns("_Identify").Properties("AutoIncrement").Value = True
			End If
			Dim index As Index = New IndexClass()
			index.Name = oooO__O_0o_.o_..Name + "_PrimaryKey"
			index.Columns.Append("_Identify", 202, 0)
			index.PrimaryKey = True
			index.Unique = True
			oooO__O_0o_.o_..Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
			Me.o0.0_O0000_O..Tables.Append(ADOXTable.oooO__O_0o_.o_.)
		End Sub

		' Token: 0x06001A69 RID: 6761 RVA: 0x000AA129 File Offset: 0x000A8329
		Public Sub DeleteTable(Name As String)
			Me.o0.0_O0000_O..Tables.Delete(Me.o0.0_O0000_O. + Name)
		End Sub

		' Token: 0x170005E3 RID: 1507
		' (get) Token: 0x06001A6A RID: 6762 RVA: 0x000AA147 File Offset: 0x000A8347
		Public ReadOnly Property Tables(Name As String) As ADOXTable
			Get
				Return New ADOXTable(Me.o0.0_O0000_O..Tables(Me.o0.0_O0000_O. + Name), Me.o0.0_O0000_O., Me.o.oo., Me.o.oo.)
			End Get
		End Property

		' Token: 0x04000B12 RID: 2834
		Private <<EMPTY_NAME>> As Catalog

		' Token: 0x04000B13 RID: 2835
		Private <<EMPTY_NAME>> As Connection

		' Token: 0x04000B14 RID: 2836
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B15 RID: 2837
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000B16 RID: 2838
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000B17 RID: 2839
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
