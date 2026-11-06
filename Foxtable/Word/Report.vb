Imports System
Imports System.ComponentModel
Imports System.Data
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.Word
	' Token: 0x02000004 RID: 4
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class Report
		' Token: 0x06000009 RID: 9 RVA: 0x00002238 File Offset: 0x00000438
		Public Sub New(A_0 As DataRow)
			Me.O0oOOO._OOO. = New ReportProperty()
			Me.O0oOOO._OOO. = A_0
			If Not A_0.IsNull("Property") Then
				o_O_o_oOoo__.OOOO_OO._oo.(Me.O0oOOO._OOO., Conversions.ToString(A_0("Property")), vbVerticalTab)
			End If
		End Sub

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00002287 File Offset: 0x00000487
		Public ReadOnly Property Name As String
			Get
				Return Conversions.ToString(Me.O0oOOO._OOO.("Name"))
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000B RID: 11 RVA: 0x0000229E File Offset: 0x0000049E
		Public ReadOnly Property TempLate As String
			Get
				Return Me.O0oOOO._OOO..Template
			End Get
		End Property

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000C RID: 12 RVA: 0x000022AB File Offset: 0x000004AB
		Public ReadOnly Property FileName As String
			Get
				Return Me.O0oOOO._OOO..FileName
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000D RID: 13 RVA: 0x000022B8 File Offset: 0x000004B8
		Public ReadOnly Property TableName As String
			Get
				Return Conversions.ToString(Me.O0oOOO._OOO.("Table"))
			End Get
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000E RID: 14 RVA: 0x000022CF File Offset: 0x000004CF
		Public ReadOnly Property RecordsOnEachPage As Integer
			Get
				Return Me.O0oOOO._OOO..RecordsOnEachPage
			End Get
		End Property

		' Token: 0x0600000F RID: 15 RVA: 0x000022DC File Offset: 0x000004DC
		Public Sub Build()
			If Operators.CompareString(Me.TempLate, "", True) <> 0 AndAlso Operators.CompareString(Me.FileName, "", True) <> 0 Then
				Dim text As String = OO_00oOO.ProjectPath + "Attachments\" + Me.TempLate
				Dim a_ As String = OO_00oOO.ProjectPath + "\Reports\" + Me.FileName
				If c.OOOOO.o.().FileSystem.FileExists(text) Then
					Dim a_2 As Table
					If OO_00oOO.CurrentTable IsNot Nothing AndAlso Operators.CompareString(OO_00oOO.CurrentTable.DataTable.Name, Me.TableName, True) = 0 Then
						a_2 = OO_00oOO.CurrentTable
					Else
						a_2 = OO_00oOO.Tables(Me.TableName)
					End If
					Dim wordReport As WordReport = New WordReport(a_2, text, a_)
					wordReport.RecordsOnEachPage = Me.RecordsOnEachPage
					If Not c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "\Reports\") Then
						c.OOOOO.o.().FileSystem.CreateDirectory(OO_00oOO.ProjectPath + "\Reports\")
					End If
					wordReport.Build()
					wordReport.Show()
				End If
			End If
		End Sub

		' Token: 0x04000004 RID: 4
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04000005 RID: 5
		Private <<EMPTY_NAME>> As ReportProperty
	End Class
End Namespace
