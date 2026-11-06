Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Syscmd
	' Token: 0x02000529 RID: 1321
	<oO0oooo("3720")>
	Public NotInheritable Module GridTree
		' Token: 0x06005725 RID: 22309 RVA: 0x00224790 File Offset: 0x00222990
		Public Sub AddChild()
			If Row.OO.OO_0o.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					table.O_.OOoO_Oo.()
				End If
			End If
		End Sub

		' Token: 0x06005726 RID: 22310 RVA: 0x002247B4 File Offset: 0x002229B4
		Public Sub AddSlibing()
			If Row.OO.OO_0o.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					If table.foxGrid.OO.o_o00o.() Then
						table.O_.o__ooo.(False)
						Return
					End If
					table.O____o.0.()
				End If
			End If
		End Sub

		' Token: 0x06005727 RID: 22311 RVA: 0x002247F0 File Offset: 0x002229F0
		Public Sub InsertSlibing()
			If Row.OO.OO_0o.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					If table.foxGrid.OO.o_o00o.() Then
						table.O_.o__ooo.(True)
						Return
					End If
					table.Oo0_0o.0.()
				End If
			End If
		End Sub

		' Token: 0x06005728 RID: 22312 RVA: 0x0022482C File Offset: 0x00222A2C
		Public Sub Clone()
			If Row.OO.OO_0o.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					If table.foxGrid.OO.o_o00o.() Then
						table.O0o._o00.()
						Return
					End If
					table.oo_Oo.oO_0oO.()
				End If
			End If
		End Sub

		' Token: 0x06005729 RID: 22313 RVA: 0x00224864 File Offset: 0x00222A64
		Public Sub MoveUp()
			If GridTree.O0O0o.Oo0OO_oO.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					If table.GridTreeVisible Then
						table.oo._O_.()
						Return
					End If
					If table.foxGrid.OO.o_o00o.() Then
						table.ooo_oo__O_o.O.()
					End If
				End If
			End If
		End Sub

		' Token: 0x0600572A RID: 22314 RVA: 0x002248A4 File Offset: 0x00222AA4
		Public Sub MoveDown()
			If GridTree.O0O0o.Oo0OO_oO.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					If table.GridTreeVisible Then
						table.O0_0o_o.O0.()
						Return
					End If
					If table.foxGrid.OO.o_o00o.() Then
						table.o00_0oO0_._.()
					End If
				End If
			End If
		End Sub

		' Token: 0x0600572B RID: 22315 RVA: 0x002248E4 File Offset: 0x00222AE4
		Public Sub MoveLeft()
			If GridTree.O0O0o.Oo0OO_oO.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					table.o_Ooo.O00o_.()
				End If
			End If
		End Sub

		' Token: 0x0600572C RID: 22316 RVA: 0x00224908 File Offset: 0x00222B08
		Public Sub MoveRight()
			If GridTree.O0O0o.Oo0OO_oO.() Then
				Dim table As Table = OO_00oOO.CurrentTable
				If table IsNot Nothing Then
					table.oOoo_Oo.o00.()
				End If
			End If
		End Sub

		' Token: 0x0600572D RID: 22317 RVA: 0x0022492C File Offset: 0x00222B2C
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return OO_00oOO.CurrentTable.AllowEdit
		End Function
	End Module
End Namespace
