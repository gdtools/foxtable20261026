Imports System
Imports System.Data
Imports System.Diagnostics
Imports Foxtable.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.XLS
	' Token: 0x020004E1 RID: 1249
	Public Class Report
		' Token: 0x06005040 RID: 20544 RVA: 0x002183C8 File Offset: 0x002165C8
		Public Sub New(A_0 As DataRow)
			Me.o0_.O_o. = New ReportProperty()
			Me.o0_.O_o. = A_0
			If Not A_0.IsNull("Property") Then
				o_O_o_oOoo__.OOOO_OO._oo.(Me.o0_.O_o., Conversions.ToString(A_0("Property")), vbVerticalTab)
			End If
		End Sub

		' Token: 0x1700121C RID: 4636
		' (get) Token: 0x06005041 RID: 20545 RVA: 0x00218417 File Offset: 0x00216617
		Public ReadOnly Property Name As String
			Get
				Return Conversions.ToString(Me.o0_.O_o.("Name"))
			End Get
		End Property

		' Token: 0x1700121D RID: 4637
		' (get) Token: 0x06005042 RID: 20546 RVA: 0x0021842E File Offset: 0x0021662E
		Public ReadOnly Property TempLate As String
			Get
				Return Me.o0_.O_o..Template
			End Get
		End Property

		' Token: 0x1700121E RID: 4638
		' (get) Token: 0x06005043 RID: 20547 RVA: 0x0021843B File Offset: 0x0021663B
		Public ReadOnly Property FileName As String
			Get
				Return Me.o0_.O_o..FileName
			End Get
		End Property

		' Token: 0x1700121F RID: 4639
		' (get) Token: 0x06005044 RID: 20548 RVA: 0x00218448 File Offset: 0x00216648
		Public ReadOnly Property TableName As String
			Get
				Return Conversions.ToString(Me.o0_.O_o.("Table"))
			End Get
		End Property

		' Token: 0x06005045 RID: 20549 RVA: 0x00218460 File Offset: 0x00216660
		Public Sub Build()
			If Operators.CompareString(Me.TempLate, "", True) <> 0 AndAlso c.OOOOO.o.().FileSystem.FileExists(ooO.OoO0o_o___.O.(Me.TempLate)) Then
				Dim book As Book = New Book(ooO.OoO0o_o___.O.(Me.TempLate))
				book.MergeFree = Me.o0_.O_o..MergeFree
				If Operators.CompareString(Me.FileName, "", True) > 0 Then
					Dim fileName As String = OO_00oOO.ProjectPath + "\Reports\" + Me.FileName
					If Not c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ProjectPath + "\Reports\") Then
						c.OOOOO.o.().FileSystem.CreateDirectory(OO_00oOO.ProjectPath + "\Reports\")
					End If
					If book.Build(New Integer(-1) {}) AndAlso book.Save(fileName) Then
						New Process() With { .StartInfo = { .FileName = fileName, .WindowStyle = ProcessWindowStyle.Maximized } }.Start()
					End If
				End If
			End If
		End Sub

		' Token: 0x04002191 RID: 8593
		Private <<EMPTY_NAME>> As DataRow

		' Token: 0x04002192 RID: 8594
		Private <<EMPTY_NAME>> As ReportProperty
	End Class
End Namespace
