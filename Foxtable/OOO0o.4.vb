Imports System
Imports System.Collections.Generic
Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000317 RID: 791
	Friend Class OOO0o
		' Token: 0x06002B03 RID: 11011 RVA: 0x0012D495 File Offset: 0x0012B695
		Friend Sub New(A_0 As Table)
			Me.OOooOOo_.0_0_o. = New Dictionary(Of String, ColumnLayoutSetting)()
			Me.O__OOo_.0O. = A_0
		End Sub

		' Token: 0x06002B04 RID: 11012 RVA: 0x0012D4B0 File Offset: 0x0012B6B0
		Friend Sub <<EMPTY_NAME>>()
			Me.OOooOOo_.0_0_o. = Me.O__OOo_.0O..foxGrid.Row
			Me.oOoOO_._0. = Me.O__OOo_.0O..foxGrid.RowSel
			Me.oo.0OoO. = Me.O__OOo_.0O..foxGrid.Col
			Me.oo.0_oOO0_O_. = Me.O__OOo_.0O..foxGrid.ColSel
			If Me.O__OOo_.0O..foxGrid.Cols.Contains("_Locked") Then
				Me.O__OOo_.0O..oO_o_0o._0oooo.(True)
			End If
			Me.OOooOOo_.0_0_o..Clear()
			Dim fixed As Integer = Me.O__OOo_.0O..foxGrid.Cols.Fixed
			Dim num As Integer = Me.O__OOo_.0O..foxGrid.Cols.Count - 1
			For i As Integer = fixed To num
				Dim column As Column = Me.O__OOo_.0O..foxGrid.Cols(i)
				If Operators.CompareString(column.Name, "", True) <> 0 AndAlso Me.O__OOo_.0O..View.o_o.O0ooOo.().Columns.Contains(column.Name) AndAlso Not Me.OOooOOo_.0_0_o..ContainsKey(column.Name) Then
					Me.OOooOOo_.0_0_o..Add(column.Name, New ColumnLayoutSetting(column.Name, column.Width, Me.O__OOo_.0O..View.o_o.O0ooOo.().Columns(column.Name).[ReadOnly], column.Visible))
				End If
			Next
		End Sub

		' Token: 0x06002B05 RID: 11013 RVA: 0x0012D638 File Offset: 0x0012B838
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			If Me.OOooOOo_.0_0_o..ContainsKey(A_0) Then
				Dim columnLayoutSetting As ColumnLayoutSetting = Me.OOooOOo_.0_0_o.(A_0)
				columnLayoutSetting.Name = A_1
				Me.OOooOOo_.0_0_o..Remove(A_0)
				Me.OOooOOo_.0_0_o..Add(A_1, columnLayoutSetting)
			End If
		End Sub

		' Token: 0x06002B06 RID: 11014 RVA: 0x0012D684 File Offset: 0x0012B884
		Friend Sub <<EMPTY_NAME>>()
			Me.O__OOo_.0O..ClearEditInfos()
			If Me.OOooOOo_.0_0_o..Count <> 0 Then
				Dim num As Integer = Me.O__OOo_.0O..foxGrid.Cols.Fixed
				Try
					For Each columnLayoutSetting As ColumnLayoutSetting In Me.OOooOOo_.0_0_o..Values
						If columnLayoutSetting IsNot Nothing AndAlso Me.O__OOo_.0O..foxGrid.Cols.Contains(columnLayoutSetting.Name) Then
							Me.O__OOo_.0O..foxGrid.Cols(columnLayoutSetting.Name).Move(num)
							Me.O__OOo_.0O..foxGrid.Cols(columnLayoutSetting.Name).Width = columnLayoutSetting.Width
							Me.O__OOo_.0O..foxGrid.Cols(columnLayoutSetting.Name).Visible = columnLayoutSetting.Visible
							num += 1
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, ColumnLayoutSetting).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Dim o_oOooO_O As O_oOooO_O = Me.O__OOo_.0O..foxGrid
				Me.oo.0_oOO0_O_. = Math.Min(o_oOooO_O.Cols.Count - 1, Me.oo.0_oOO0_O_.)
				Me.oo.0OoO. = Math.Min(o_oOooO_O.Cols.Count - 1, Me.oo.0OoO.)
				Me.oOoOO_._0. = Math.Min(o_oOooO_O.Rows.Count - 1, Me.oOoOO_._0.)
				Me.OOooOOo_.0_0_o. = Math.Min(o_oOooO_O.Rows.Count - 1, Me.OOooOOo_.0_0_o.)
				Me.O__OOo_.0O..foxGrid.[Select](Me.OOooOOo_.0_0_o., Me.oo.0OoO., Me.oOoOO_._0., Me.oo.0_oOO0_O_.)
			End If
		End Sub

		' Token: 0x04001172 RID: 4466
		Private <<EMPTY_NAME>> As Dictionary(Of String, ColumnLayoutSetting)

		' Token: 0x04001173 RID: 4467
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001174 RID: 4468
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001175 RID: 4469
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001176 RID: 4470
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001177 RID: 4471
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
