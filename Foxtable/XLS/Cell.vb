Imports System
Imports System.Runtime.CompilerServices
Imports C1.C1Excel

Namespace Foxtable.XLS
	' Token: 0x020004D9 RID: 1241
	<oO0oooo("1160")>
	Public Class Cell
		' Token: 0x06004FEA RID: 20458 RVA: 0x00217C6C File Offset: 0x00215E6C
		Friend Sub New(A_0 As XLSheet, A_1 As Integer, A_2 As Integer)
			Me.o0_.O_o. = A_0
			Me.o__0_.oO. = A_1
			Me.o0.o0O__0oo. = A_2
			Me.o0_.O_o. = A_0(A_1, A_2)
		End Sub

		' Token: 0x170011FB RID: 4603
		' (get) Token: 0x06004FEB RID: 20459 RVA: 0x00217C98 File Offset: 0x00215E98
		' (set) Token: 0x06004FEC RID: 20460 RVA: 0x00217CCC File Offset: 0x00215ECC
		Public Property Value As Object
			Get
				Dim result As Object
				If Me.o0_.O_o..Value Is DBNull.Value Then
					result = ""
				Else
					result = Me.o0_.O_o..Value
				End If
				Return result
			End Get
			Set(value As Object)
				If TypeOf value Is Picture Then
					Me.o0_.O_o..Value = CType(value, Picture).o0_.O_o.
					Return
				End If
				Me.o0_.O_o..Value = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x170011FC RID: 4604
		' (get) Token: 0x06004FED RID: 20461 RVA: 0x00217CFE File Offset: 0x00215EFE
		Public ReadOnly Property Text As String
			Get
				Return Me.o0_.O_o..Text
			End Get
		End Property

		' Token: 0x170011FD RID: 4605
		' (get) Token: 0x06004FEE RID: 20462 RVA: 0x00217D0B File Offset: 0x00215F0B
		' (set) Token: 0x06004FEF RID: 20463 RVA: 0x00217D18 File Offset: 0x00215F18
		Public Property Hyperlink As String
			Get
				Return Me.o0_.O_o..Hyperlink
			End Get
			Set(value As String)
				Me.o0_.O_o..Hyperlink = value
			End Set
		End Property

		' Token: 0x170011FE RID: 4606
		' (get) Token: 0x06004FF0 RID: 20464 RVA: 0x00217D26 File Offset: 0x00215F26
		' (set) Token: 0x06004FF1 RID: 20465 RVA: 0x00217D38 File Offset: 0x00215F38
		Public Property Style As Style
			Get
				Return New Style(Me.o0_.O_o..Style)
			End Get
			Set(value As Style)
				If value Is Nothing Then
					Me.o0_.O_o..Style = Nothing
					Return
				End If
				Me.o0_.O_o..Style = value.Ooo_O__.0.
			End Set
		End Property

		' Token: 0x06004FF2 RID: 20466 RVA: 0x00217D5B File Offset: 0x00215F5B
		Public Sub SetValue(Value As Object, Style As Style)
			Me.o0_.O_o..SetValue(RuntimeHelpers.GetObjectValue(Value), Style.Ooo_O__.0.)
		End Sub

		' Token: 0x06004FF3 RID: 20467 RVA: 0x00217D74 File Offset: 0x00215F74
		Public Function SaveImage(FileName As String) As Boolean
			Dim num As Integer = Me.o0_.O_o..Shapes.Count - 1
			For i As Integer = 0 To num
				If TypeOf Me.o0_.O_o..Shapes(i)Is XLPictureShape Then
					Dim xlpictureShape As XLPictureShape = CType(Me.o0_.O_o..Shapes(i), XLPictureShape)
					If xlpictureShape.Row = Me.o__0_.oO. AndAlso xlpictureShape.Column = Me.o0.o0O__0oo. AndAlso xlpictureShape.Image IsNot Nothing Then
						If OO_00oOO.FileSys.FileExists(FileName) Then
							OO_00oOO.FileSys.DeleteFile(FileName)
						End If
						xlpictureShape.Image.Save(FileName, O_O0OO.OoO_00._.(FileName))
						Return True
					End If
				End If
			Next
			Return False
		End Function

		' Token: 0x170011FF RID: 4607
		' (get) Token: 0x06004FF4 RID: 20468 RVA: 0x00217E2A File Offset: 0x0021602A
		' (set) Token: 0x06004FF5 RID: 20469 RVA: 0x00217E37 File Offset: 0x00216037
		Public Property Formula As String
			Get
				Return Me.o0_.O_o..Formula
			End Get
			Set(value As String)
				Me.o0_.O_o..Value = " "
				Me.o0_.O_o..Formula = value.Trim(New Char() { "="c }).Trim()
			End Set
		End Property

		' Token: 0x04002173 RID: 8563
		Private <<EMPTY_NAME>> As XLSheet

		' Token: 0x04002174 RID: 8564
		Private <<EMPTY_NAME>> As XLCell

		' Token: 0x04002175 RID: 8565
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04002176 RID: 8566
		Private <<EMPTY_NAME>> As Integer
	End Class
End Namespace
