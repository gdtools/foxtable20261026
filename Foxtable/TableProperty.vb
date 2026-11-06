Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000329 RID: 809
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class TableProperty
		' Token: 0x06002F72 RID: 12146 RVA: 0x00134A80 File Offset: 0x00132C80
		Public Sub New(A_0 As Table)
			Me.OO0._O_Oo0__. = ""
			Me.o__O.o_oOO00. = ""
			Me.O_oooo.oo0. = ""
			Me.OOoO0.ooooOOO0. = ""
			Me.O.ooo_00O. = 20
			Me.O.O0Oo_0O. = ""
			Me.Oo.oO_Oo. = ""
			Me.O._o0O_0. = A_0
		End Sub

		' Token: 0x17000C3C RID: 3132
		' (get) Token: 0x06002F73 RID: 12147 RVA: 0x00134AE4 File Offset: 0x00132CE4
		' (set) Token: 0x06002F74 RID: 12148 RVA: 0x00134AF1 File Offset: 0x00132CF1
		<DefaultValue("宋体,9")>
		Public Property Font As Font
			Get
				Return Me.O._o0O_0..Font
			End Get
			Set(value As Font)
				Me.O.ooo_00O. = value
			End Set
		End Property

		' Token: 0x17000C3D RID: 3133
		' (get) Token: 0x06002F75 RID: 12149 RVA: 0x00134AFA File Offset: 0x00132CFA
		' (set) Token: 0x06002F76 RID: 12150 RVA: 0x00134B07 File Offset: 0x00132D07
		Public Property Listmode As Boolean
			Get
				Return Me.O._o0O_0..ListMode
			End Get
			Set(value As Boolean)
				Me.O._o0O_0. = value
			End Set
		End Property

		' Token: 0x17000C3E RID: 3134
		' (get) Token: 0x06002F77 RID: 12151 RVA: 0x00134B10 File Offset: 0x00132D10
		' (set) Token: 0x06002F78 RID: 12152 RVA: 0x00134B99 File Offset: 0x00132D99
		Public Property ColumnString As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.O._o0O_0..foxGrid.Cols.Fixed
				Dim num As Integer = Me.O._o0O_0..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					text += Me.O._o0O_0..foxGrid.Cols(i).Name
				Next
				Return text
			End Get
			Set(value As String)
				Me.OO0._O_Oo0__. = value
			End Set
		End Property

		' Token: 0x17000C3F RID: 3135
		' (get) Token: 0x06002F79 RID: 12153 RVA: 0x00134BA2 File Offset: 0x00132DA2
		' (set) Token: 0x06002F7A RID: 12154 RVA: 0x00134BAF File Offset: 0x00132DAF
		Public Property GrandTotalCols As String
			Get
				Return Me.O._o0O_0..ooo_O0oOo.0O.
			End Get
			Set(value As String)
				Me.O._o0O_0..ooo_O0oOo.0O. = value
			End Set
		End Property

		' Token: 0x17000C40 RID: 3136
		' (get) Token: 0x06002F7B RID: 12155 RVA: 0x00134BC0 File Offset: 0x00132DC0
		' (set) Token: 0x06002F7C RID: 12156 RVA: 0x00134C4E File Offset: 0x00132E4E
		Public Property ColumnWidth As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.O._o0O_0..foxGrid.Cols.Fixed
				Dim num As Integer = Me.O._o0O_0..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					text += Conversions.ToString(Me.O._o0O_0..foxGrid.Cols(i).Width)
				Next
				Return text
			End Get
			Set(value As String)
				Me.o__O.o_oOO00. = value
			End Set
		End Property

		' Token: 0x17000C41 RID: 3137
		' (get) Token: 0x06002F7D RID: 12157 RVA: 0x00134C58 File Offset: 0x00132E58
		' (set) Token: 0x06002F7E RID: 12158 RVA: 0x00134CF8 File Offset: 0x00132EF8
		Public Property ColumnVisible As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.O._o0O_0..foxGrid.Cols.Fixed
				Dim num As Integer = Me.O._o0O_0..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					If Me.O._o0O_0..foxGrid.Cols(i).Visible Then
						text += Conversions.ToString(1)
					Else
						text += Conversions.ToString(0)
					End If
				Next
				Return text
			End Get
			Set(value As String)
				Me.O_oooo.oo0. = value
			End Set
		End Property

		' Token: 0x17000C42 RID: 3138
		' (get) Token: 0x06002F7F RID: 12159 RVA: 0x00134D04 File Offset: 0x00132F04
		' (set) Token: 0x06002F80 RID: 12160 RVA: 0x00134D7E File Offset: 0x00132F7E
		Public Property FixedRowHeight As String
			Get
				Dim text As String = ""
				Dim num As Integer = Me.O._o0O_0..foxGrid.Rows.Fixed - 1
				For i As Integer = 0 To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					text += Conversions.ToString(Me.O._o0O_0..foxGrid.Rows(i).HeightDisplay)
				Next
				Return text
			End Get
			Set(value As String)
				Me.OOoO0.ooooOOO0. = value
			End Set
		End Property

		' Token: 0x17000C43 RID: 3139
		' (get) Token: 0x06002F81 RID: 12161 RVA: 0x00134D87 File Offset: 0x00132F87
		' (set) Token: 0x06002F82 RID: 12162 RVA: 0x00134D9E File Offset: 0x00132F9E
		<DefaultValue(0)>
		Public Property FrozenCols As Integer
			Get
				Return Me.O._o0O_0..foxGrid.Cols.Frozen
			End Get
			Set(value As Integer)
				Me.O._o0O_0..foxGrid.Cols.Frozen = value
			End Set
		End Property

		' Token: 0x17000C44 RID: 3140
		' (get) Token: 0x06002F83 RID: 12163 RVA: 0x00134DB6 File Offset: 0x00132FB6
		' (set) Token: 0x06002F84 RID: 12164 RVA: 0x00134DCD File Offset: 0x00132FCD
		Public Property DefaultRowHeight As Integer
			Get
				Return Me.O._o0O_0..foxGrid.Rows.DefaultSize
			End Get
			Set(value As Integer)
				Me.O.ooo_00O. = value
			End Set
		End Property

		' Token: 0x17000C45 RID: 3141
		' (get) Token: 0x06002F85 RID: 12165 RVA: 0x00134DD8 File Offset: 0x00132FD8
		' (set) Token: 0x06002F86 RID: 12166 RVA: 0x00134E0C File Offset: 0x0013300C
		<DefaultValue("")>
		Public Property CrossTableName As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					result = Me.O._o0O_0..O_0._O_0OO000O..TableName
				End If
				Return result
			End Get
			Set(value As String)
				Me.o0OoO_0_.0. = value
			End Set
		End Property

		' Token: 0x17000C46 RID: 3142
		' (get) Token: 0x06002F87 RID: 12167 RVA: 0x00134E18 File Offset: 0x00133018
		' (set) Token: 0x06002F88 RID: 12168 RVA: 0x00134E4C File Offset: 0x0013304C
		<DefaultValue("")>
		Public Property CrossTableCaption As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					result = Me.O._o0O_0..O_0._O_0OO000O..Caption
				End If
				Return result
			End Get
			Set(value As String)
				Me.OO_o0o0.0_0. = value
			End Set
		End Property

		' Token: 0x17000C47 RID: 3143
		' (get) Token: 0x06002F89 RID: 12169 RVA: 0x00134E58 File Offset: 0x00133058
		' (set) Token: 0x06002F8A RID: 12170 RVA: 0x00134EF4 File Offset: 0x001330F4
		<DefaultValue("")>
		Public Property CrossTableHGroups As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					Dim text As String = ""
					Try
						For Each a_ As GroupOn In Me.O._o0O_0..O_0._O_0OO000O..HGroups
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbCr
							End If
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
						Next
					Finally
						Dim enumerator As IEnumerator(Of GroupOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text
				End If
				Return result
			End Get
			Set(value As String)
				Me.OoO0o.O. = value
			End Set
		End Property

		' Token: 0x17000C48 RID: 3144
		' (get) Token: 0x06002F8B RID: 12171 RVA: 0x00134F00 File Offset: 0x00133100
		' (set) Token: 0x06002F8C RID: 12172 RVA: 0x00134F9C File Offset: 0x0013319C
		<DefaultValue("")>
		Public Property CrossTableVGroups As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					Dim text As String = ""
					Try
						For Each a_ As CrossGroupOn In Me.O._o0O_0..O_0._O_0OO000O..VGroups
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbCr
							End If
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
						Next
					Finally
						Dim enumerator As IEnumerator(Of CrossGroupOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text
				End If
				Return result
			End Get
			Set(value As String)
				Me.oOo___0.0_. = value
			End Set
		End Property

		' Token: 0x17000C49 RID: 3145
		' (get) Token: 0x06002F8D RID: 12173 RVA: 0x00134FA8 File Offset: 0x001331A8
		' (set) Token: 0x06002F8E RID: 12174 RVA: 0x00135044 File Offset: 0x00133244
		<DefaultValue("")>
		Public Property CrossTableTotals As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					Dim text As String = ""
					Try
						For Each a_ As CrossTotalOn In Me.O._o0O_0..O_0._O_0OO000O..Totals
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbCr
							End If
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
						Next
					Finally
						Dim enumerator As IEnumerator(Of CrossTotalOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text
				End If
				Return result
			End Get
			Set(value As String)
				Me.o0O0_o0_.OO. = value
			End Set
		End Property

		' Token: 0x17000C4A RID: 3146
		' (get) Token: 0x06002F8F RID: 12175 RVA: 0x00135050 File Offset: 0x00133250
		' (set) Token: 0x06002F90 RID: 12176 RVA: 0x00135084 File Offset: 0x00133284
		<DefaultValue("")>
		Public Property GroupTableName As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					result = Me.O._o0O_0..O_0._O_0OO000O..TableName
				End If
				Return result
			End Get
			Set(value As String)
				Me.oo__.0o0_0_. = value
			End Set
		End Property

		' Token: 0x17000C4B RID: 3147
		' (get) Token: 0x06002F91 RID: 12177 RVA: 0x00135090 File Offset: 0x00133290
		' (set) Token: 0x06002F92 RID: 12178 RVA: 0x001350C4 File Offset: 0x001332C4
		<DefaultValue("")>
		Public Property GroupTableCaption As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					result = Me.O._o0O_0..O_0._O_0OO000O..Caption
				End If
				Return result
			End Get
			Set(value As String)
				Me.oOo__oOo.OOO__. = value
			End Set
		End Property

		' Token: 0x17000C4C RID: 3148
		' (get) Token: 0x06002F93 RID: 12179 RVA: 0x001350D0 File Offset: 0x001332D0
		' (set) Token: 0x06002F94 RID: 12180 RVA: 0x0013516C File Offset: 0x0013336C
		<DefaultValue("")>
		Public Property GroupTableGroups As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					Dim text As String = ""
					Try
						For Each a_ As GroupOn In Me.O._o0O_0..O_0._O_0OO000O..Groups
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbCr
							End If
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
						Next
					Finally
						Dim enumerator As IEnumerator(Of GroupOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text
				End If
				Return result
			End Get
			Set(value As String)
				Me.oo__0_.o. = value
			End Set
		End Property

		' Token: 0x17000C4D RID: 3149
		' (get) Token: 0x06002F95 RID: 12181 RVA: 0x00135178 File Offset: 0x00133378
		' (set) Token: 0x06002F96 RID: 12182 RVA: 0x00135214 File Offset: 0x00133414
		<DefaultValue("")>
		Public Property GroupTableTotals As String
			Get
				Dim result As String
				If Me.O._o0O_0..O_0._O_0OO000O. Is Nothing Then
					result = ""
				Else
					Dim text As String = ""
					Try
						For Each a_ As TotalOn In Me.O._o0O_0..O_0._O_0OO000O..Totals
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbCr
							End If
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
						Next
					Finally
						Dim enumerator As IEnumerator(Of TotalOn)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
					result = text
				End If
				Return result
			End Get
			Set(value As String)
				Me.O_.0__o00oO. = value
			End Set
		End Property

		' Token: 0x17000C4E RID: 3150
		' (get) Token: 0x06002F97 RID: 12183 RVA: 0x00135220 File Offset: 0x00133420
		' (set) Token: 0x06002F98 RID: 12184 RVA: 0x001352A0 File Offset: 0x001334A0
		<DefaultValue("")>
		Public Property SubtotalGroups As String
			Get
				Dim text As String = ""
				Try
					For Each a_ As SubtotalGroup In Me.O._o0O_0..SubtotalGroups
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbLf, False)
					Next
				Finally
					Dim enumerator As IEnumerator(Of SubtotalGroup)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text
			End Get
			Set(value As String)
				Me.O.O0Oo_0O. = value
			End Set
		End Property

		' Token: 0x17000C4F RID: 3151
		' (get) Token: 0x06002F99 RID: 12185 RVA: 0x001352A9 File Offset: 0x001334A9
		' (set) Token: 0x06002F9A RID: 12186 RVA: 0x001352B6 File Offset: 0x001334B6
		<DefaultValue(False)>
		Public Property GroupAboveData As Boolean
			Get
				Return Me.O._o0O_0..GroupAboveData
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..GroupAboveData = value
			End Set
		End Property

		' Token: 0x17000C50 RID: 3152
		' (get) Token: 0x06002F9B RID: 12187 RVA: 0x001352C4 File Offset: 0x001334C4
		' (set) Token: 0x06002F9C RID: 12188 RVA: 0x001352D1 File Offset: 0x001334D1
		<DefaultValue(False)>
		Public Property TreeVisible As Boolean
			Get
				Return Me.O._o0O_0..TreeVisible
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..TreeVisible = value
			End Set
		End Property

		' Token: 0x17000C51 RID: 3153
		' (get) Token: 0x06002F9D RID: 12189 RVA: 0x001352DF File Offset: 0x001334DF
		' (set) Token: 0x06002F9E RID: 12190 RVA: 0x001352EC File Offset: 0x001334EC
		<DefaultValue(True)>
		Public Property SpillNode As Boolean
			Get
				Return Me.O._o0O_0..SpillNode
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..SpillNode = value
			End Set
		End Property

		' Token: 0x17000C52 RID: 3154
		' (get) Token: 0x06002F9F RID: 12191 RVA: 0x001352FC File Offset: 0x001334FC
		' (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00135378 File Offset: 0x00133578
		<DefaultValue("")>
		Public Property MergeCols As String
			Get
				Dim text As String = ""
				Try
					For Each str As String In Me.O._o0O_0..MergeCols
						If Operators.CompareString(text, "", True) > 0 Then
							text += ","
						End If
						text += str
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return text
			End Get
			Set(value As String)
				If Not String.IsNullOrEmpty(value) AndAlso Operators.CompareString(value, "", True) <> 0 Then
					Dim array As String() = value.Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries)
					If array.Length <> 0 Then
						Me.O._o0O_0..MergeCols.Clear()
						For Each item As String In array
							Me.O._o0O_0..MergeCols.Add(item)
						Next
					End If
				End If
			End Set
		End Property

		' Token: 0x17000C53 RID: 3155
		' (get) Token: 0x06002FA1 RID: 12193 RVA: 0x001353E8 File Offset: 0x001335E8
		' (set) Token: 0x06002FA2 RID: 12194 RVA: 0x001353F5 File Offset: 0x001335F5
		<DefaultValue("")>
		Public Property MergeSort As String
			Get
				Return Me.O._o0O_0..MergeSort
			End Get
			Set(value As String)
				Me.O._o0O_0..MergeSort = value
			End Set
		End Property

		' Token: 0x17000C54 RID: 3156
		' (get) Token: 0x06002FA3 RID: 12195 RVA: 0x00135403 File Offset: 0x00133603
		' (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00135410 File Offset: 0x00133610
		<DefaultValue(0)>
		Public Property MergeMode As MergeModeEnum
			Get
				Return Me.O._o0O_0..MergeMode
			End Get
			Set(value As MergeModeEnum)
				Me.O._o0O_0..MergeMode = value
			End Set
		End Property

		' Token: 0x17000C55 RID: 3157
		' (get) Token: 0x06002FA5 RID: 12197 RVA: 0x00135420 File Offset: 0x00133620
		' (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00135480 File Offset: 0x00133680
		<DefaultValue("")>
		Public Property PrintInfo As String
			Get
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						Return ""
					End If
				Catch ex As Exception
					Return ""
				End Try
				Return o_O_o_oOoo__.OOOO_OO._oo.(Me.O._o0O_0..PrintInfo, False, vbLf, False)
			End Get
			Set(value As String)
				Me.Oo.oO_Oo. = value
			End Set
		End Property

		' Token: 0x06002FA7 RID: 12199 RVA: 0x0013548C File Offset: 0x0013368C
		Friend Sub Restore()
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.OO0._O_Oo0__., "", True) <= 0 OrElse Operators.CompareString(Me.o__O.o_oOO00., "", True) <= 0 Then
					GoTo IL_535
				End If
				IL_37:
				num2 = 3
				Dim array As String() = Me.OO0._O_Oo0__..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				IL_51:
				num2 = 4
				Dim array2 As String() = Me.o__O.o_oOO00..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				IL_6C:
				num2 = 5
				Dim array3 As String() = Me.O_oooo.oo0..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				IL_87:
				num2 = 6
				Dim array4 As String() = Me.O.O0Oo_0O..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_A2:
				num2 = 7
				Dim num3 As Integer = Me.O._o0O_0..foxGrid.Cols.Fixed
				IL_BB:
				num2 = 8
				Dim num4 As Integer = array.Length - 1
				For i As Integer = 0 To num4
					IL_CC:
					num2 = 9
					If Me.O._o0O_0..foxGrid.Cols.Contains(array(i)) Then
						IL_ED:
						num2 = 10
						Me.O._o0O_0..foxGrid.Cols(array(i)).Width = Convert.ToInt32(array2(i))
						IL_118:
						num2 = 11
						Me.O._o0O_0..foxGrid.Cols(array(i)).Move(num3)
						IL_13B:
						num2 = 12
						If Convert.ToInt32(array3(i)) = 1 Then
							IL_14B:
							num2 = 13
							Me.O._o0O_0..foxGrid.Cols(array(i)).Visible = True
						Else
							IL_16F:
							num2 = 15
							Me.O._o0O_0..foxGrid.Cols(array(i)).Visible = False
						End If
						IL_191:
						num2 = 16
						num3 += 1
					End If
					IL_19A:
					num2 = 17
				Next
				IL_1AC:
				num2 = 18
				Me.O._o0O_0..SubtotalGroups.Clear()
				IL_1BF:
				num2 = 19
				For Each a_ As String In array4
					IL_1D2:
					num2 = 20
					Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
					IL_1DC:
					num2 = 21
					o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, vbLf)
					IL_1EA:
					num2 = 22
					Me.O._o0O_0..SubtotalGroups.Add(subtotalGroup)
					IL_1FF:
					num2 = 23
				Next
				IL_210:
				num2 = 24
				If Operators.CompareString(Me.oo__0_.o., "", True) <= 0 OrElse Operators.CompareString(Me.O_.0__o00oO., "", True) <= 0 Then
					GoTo IL_362
				End If
				IL_241:
				num2 = 25
				Dim groupTableBuilder As GroupTableBuilder = New GroupTableBuilder()
				IL_24B:
				num2 = 26
				groupTableBuilder.TableName = Me.oo__.0o0_0_.
				IL_25B:
				num2 = 27
				groupTableBuilder.Caption = Me.oOo__oOo.OOO__.
				IL_26B:
				num2 = 28
				groupTableBuilder.SourceDataTable = Me.O._o0O_0..DataTable
				IL_280:
				num2 = 29
				Dim array6 As String() = Me.oo__0_.o..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_29C:
				num2 = 30
				Dim array7 As String() = Me.O_.0__o00oO..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_2B8:
				num2 = 31
				For Each a_2 As String In array6
					IL_2CB:
					num2 = 32
					Dim groupOn As GroupOn = New GroupOn()
					IL_2D5:
					num2 = 33
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn, a_2, vbLf)
					IL_2E3:
					num2 = 34
					groupTableBuilder.Groups.Add(groupOn)
					IL_2F4:
					num2 = 35
				Next
				IL_305:
				num2 = 36
				For Each a_3 As String In array7
					IL_318:
					num2 = 37
					Dim totalOn As TotalOn = New TotalOn()
					IL_322:
					num2 = 38
					o_O_o_oOoo__.OOOO_OO._oo.(totalOn, a_3, vbLf)
					IL_330:
					num2 = 39
					groupTableBuilder.Totals.Add(totalOn)
					IL_341:
					num2 = 40
				Next
				IL_352:
				num2 = 41
				Me.O._o0O_0..O_0._O_0OO000O. = groupTableBuilder
				IL_362:
				num2 = 42
				If Operators.CompareString(Me.OoO0o.O., "", True) <= 0 OrElse Operators.CompareString(Me.oOo___0.0_., "", True) <= 0 OrElse Operators.CompareString(Me.o0O0_o0_.OO., "", True) <= 0 Then
					GoTo IL_535
				End If
				IL_3AA:
				num2 = 43
				Dim crossTableBuilder As CrossTableBuilder = New CrossTableBuilder()
				IL_3B4:
				num2 = 44
				crossTableBuilder.TableName = Me.o0OoO_0_.0.
				IL_3C4:
				num2 = 45
				crossTableBuilder.Caption = Me.OO_o0o0.0_0.
				IL_3D4:
				num2 = 46
				crossTableBuilder.SourceDataTable = Me.O._o0O_0..DataTable
				IL_3E9:
				num2 = 47
				Dim array10 As String() = Me.OoO0o.O..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_405:
				num2 = 48
				Dim array11 As String() = Me.oOo___0.0_..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_421:
				num2 = 49
				Dim array12 As String() = Me.o0O0_o0_.OO..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				IL_43D:
				num2 = 50
				For Each a_4 As String In array10
					IL_450:
					num2 = 51
					Dim groupOn2 As GroupOn = New GroupOn()
					IL_45A:
					num2 = 52
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn2, a_4, vbLf)
					IL_468:
					num2 = 53
					crossTableBuilder.HGroups.Add(groupOn2)
					IL_479:
					num2 = 54
				Next
				IL_48A:
				num2 = 55
				For Each a_5 As String In array11
					IL_49D:
					num2 = 56
					Dim crossGroupOn As CrossGroupOn = New CrossGroupOn()
					IL_4A7:
					num2 = 57
					o_O_o_oOoo__.OOOO_OO._oo.(crossGroupOn, a_5, vbLf)
					IL_4B5:
					num2 = 58
					crossTableBuilder.VGroups.Add(crossGroupOn)
					IL_4C6:
					num2 = 59
				Next
				IL_4D7:
				num2 = 60
				For Each a_6 As String In array12
					IL_4EA:
					num2 = 61
					Dim crossTotalOn As CrossTotalOn = New CrossTotalOn(False)
					IL_4F5:
					num2 = 62
					o_O_o_oOoo__.OOOO_OO._oo.(crossTotalOn, a_6, vbLf)
					IL_503:
					num2 = 63
					crossTableBuilder.Totals.Add(crossTotalOn)
					IL_514:
					num2 = 64
				Next
				IL_525:
				num2 = 65
				Me.O._o0O_0..O_0._O_0OO000O. = crossTableBuilder
				IL_535:
				num2 = 66
				Me.O._o0O_0..o.OOoo_o. = Me.Oo.oO_Oo.
				IL_549:
				num2 = 67
				If Me.O.ooo_00O. Is Nothing Then
					GoTo IL_56D
				End If
				IL_554:
				num2 = 68
				Me.O._o0O_0..foxGrid.Font = Me.O.ooo_00O.
				IL_56D:
				num2 = 69
				Me.O._o0O_0..ListMode = Me.O._o0O_0.
				IL_581:
				num2 = 70
				Me.O._o0O_0..foxGrid.Rows.DefaultSize = Me.O.ooo_00O.
				IL_59F:
				num2 = 71
				If Operators.CompareString(Me.OO0._O_Oo0__., "", True) <= 0 OrElse Operators.CompareString(Me.o__O.o_oOO00., "", True) <= 0 Then
					GoTo IL_657
				End If
				IL_5D0:
				num2 = 72
				Dim array16 As String() = Me.OOoO0.ooooOOO0..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				IL_5EC:
				num2 = 73
				Dim num6 As Integer = Math.Min(array16.Length - 1, Me.O._o0O_0..foxGrid.Rows.Fixed - 1)
				For num7 As Integer = 0 To num6
					IL_618:
					num2 = 74
					Dim height As Integer = Integer.Parse(array16(num7))
					IL_627:
					num2 = 75
					Me.O._o0O_0..foxGrid.Rows(num7).Height = height
					IL_648:
					num2 = 76
				Next
				IL_657:
				GoTo IL_7DD
				IL_65C:
				Dim num8 As Integer = num9 + 1
				num9 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8)
				IL_79E:
				GoTo IL_7D2
				IL_7A0:
				num9 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_7B0:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_7A0
			End Try
			IL_7D2:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7DD:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x17000C56 RID: 3158
		' (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00135C9C File Offset: 0x00133E9C
		' (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00135CA9 File Offset: 0x00133EA9
		<DefaultValue(1)>
		Public Property DockArea As DockAreaEnum
			Get
				Return Me.O._o0O_0.._frdDockArea
			End Get
			Set(value As DockAreaEnum)
				Me.O._o0O_0.._frdDockArea = value
			End Set
		End Property

		' Token: 0x17000C57 RID: 3159
		' (get) Token: 0x06002FAA RID: 12202 RVA: 0x00135CB7 File Offset: 0x00133EB7
		' (set) Token: 0x06002FAB RID: 12203 RVA: 0x00135CC4 File Offset: 0x00133EC4
		<DefaultValue(False)>
		Public Property DockTitle As Boolean
			Get
				Return Me.O._o0O_0.._frdDockTitle
			End Get
			Set(value As Boolean)
				Me.O._o0O_0.._frdDockTitle = value
			End Set
		End Property

		' Token: 0x17000C58 RID: 3160
		' (get) Token: 0x06002FAC RID: 12204 RVA: 0x00135CD2 File Offset: 0x00133ED2
		' (set) Token: 0x06002FAD RID: 12205 RVA: 0x00135CDF File Offset: 0x00133EDF
		<DefaultValue(True)>
		Public Property AutoOpen As Boolean
			Get
				Return Me.O._o0O_0.._frdAutoOpen
			End Get
			Set(value As Boolean)
				Me.O._o0O_0.._frdAutoOpen = value
			End Set
		End Property

		' Token: 0x17000C59 RID: 3161
		' (get) Token: 0x06002FAE RID: 12206 RVA: 0x00135CED File Offset: 0x00133EED
		' (set) Token: 0x06002FAF RID: 12207 RVA: 0x00135CFA File Offset: 0x00133EFA
		<DefaultValue(False)>
		Public Property AutoHide As Boolean
			Get
				Return Me.O._o0O_0.._frdAutoHide
			End Get
			Set(value As Boolean)
				Me.O._o0O_0.._frdAutoHide = value
			End Set
		End Property

		' Token: 0x17000C5A RID: 3162
		' (get) Token: 0x06002FB0 RID: 12208 RVA: 0x00135D08 File Offset: 0x00133F08
		' (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00135D15 File Offset: 0x00133F15
		<DefaultValue(True)>
		Public Property AllowClose As Boolean
			Get
				Return Me.O._o0O_0.._frdAllowClose
			End Get
			Set(value As Boolean)
				Me.O._o0O_0.._frdAllowClose = value
			End Set
		End Property

		' Token: 0x17000C5B RID: 3163
		' (get) Token: 0x06002FB2 RID: 12210 RVA: 0x00135D23 File Offset: 0x00133F23
		' (set) Token: 0x06002FB3 RID: 12211 RVA: 0x00135D30 File Offset: 0x00133F30
		<DefaultValue(True)>
		Public Property ShowCaption As Boolean
			Get
				Return Me.O._o0O_0.._frdShowCaption
			End Get
			Set(value As Boolean)
				Me.O._o0O_0.._frdShowCaption = value
			End Set
		End Property

		' Token: 0x17000C5C RID: 3164
		' (get) Token: 0x06002FB4 RID: 12212 RVA: 0x00135D3E File Offset: 0x00133F3E
		' (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00135D4B File Offset: 0x00133F4B
		<DefaultValue("")>
		Public Property FilterTreeColumns As String
			Get
				Return Me.O._o0O_0..O00.o_0OO__.
			End Get
			Set(value As String)
				Me.O._o0O_0..O00.o_0OO__. = value
			End Set
		End Property

		' Token: 0x17000C5D RID: 3165
		' (get) Token: 0x06002FB6 RID: 12214 RVA: 0x00135D59 File Offset: 0x00133F59
		' (set) Token: 0x06002FB7 RID: 12215 RVA: 0x00135D66 File Offset: 0x00133F66
		<DefaultValue(0)>
		Public Property InlineTreeType As O0_0_0O0___O
			Get
				Return Me.O._o0O_0..o00oOO00_.ooOo.
			End Get
			Set(value As O0_0_0O0___O)
				Me.O._o0O_0..o00oOO00_.ooOo. = value
			End Set
		End Property

		' Token: 0x17000C5E RID: 3166
		' (get) Token: 0x06002FB8 RID: 12216 RVA: 0x00135D74 File Offset: 0x00133F74
		' (set) Token: 0x06002FB9 RID: 12217 RVA: 0x00135D81 File Offset: 0x00133F81
		<DefaultValue("")>
		Public Property FilterParentCol As String
			Get
				Return Me.O._o0O_0..oo.0___0O00.
			End Get
			Set(value As String)
				Me.O._o0O_0..oo.0___0O00. = value
			End Set
		End Property

		' Token: 0x17000C5F RID: 3167
		' (get) Token: 0x06002FBA RID: 12218 RVA: 0x00135D8F File Offset: 0x00133F8F
		' (set) Token: 0x06002FBB RID: 12219 RVA: 0x00135D9C File Offset: 0x00133F9C
		<DefaultValue(0)>
		Public Property AutoFold As Integer
			Get
				Return Me.O._o0O_0..o.0o00ooo_.
			End Get
			Set(value As Integer)
				Me.O._o0O_0..o.0o00ooo_. = value
			End Set
		End Property

		' Token: 0x17000C60 RID: 3168
		' (get) Token: 0x06002FBC RID: 12220 RVA: 0x00135DAA File Offset: 0x00133FAA
		' (set) Token: 0x06002FBD RID: 12221 RVA: 0x00135DB7 File Offset: 0x00133FB7
		<DefaultValue(False)>
		Public Property ShowGridTree As Boolean
			Get
				Return Me.O._o0O_0..O0oO0_._0.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O0oO0_._0. = value
			End Set
		End Property

		' Token: 0x17000C61 RID: 3169
		' (get) Token: 0x06002FBE RID: 12222 RVA: 0x00135DC5 File Offset: 0x00133FC5
		' (set) Token: 0x06002FBF RID: 12223 RVA: 0x00135DD2 File Offset: 0x00133FD2
		<DefaultValue("")>
		Public Property FilterValueCol As String
			Get
				Return Me.O._o0O_0..Oo_0o_O0._.
			End Get
			Set(value As String)
				Me.O._o0O_0..Oo_0o_O0._. = value
			End Set
		End Property

		' Token: 0x17000C62 RID: 3170
		' (get) Token: 0x06002FC0 RID: 12224 RVA: 0x00135DE0 File Offset: 0x00133FE0
		' (set) Token: 0x06002FC1 RID: 12225 RVA: 0x00135DED File Offset: 0x00133FED
		<DefaultValue("")>
		Public Property FilterSortCol As String
			Get
				Return Me.O._o0O_0..ooo._Ooo.
			End Get
			Set(value As String)
				Me.O._o0O_0..ooo._Ooo. = value
			End Set
		End Property

		' Token: 0x17000C63 RID: 3171
		' (get) Token: 0x06002FC2 RID: 12226 RVA: 0x00135DFB File Offset: 0x00133FFB
		' (set) Token: 0x06002FC3 RID: 12227 RVA: 0x00135E08 File Offset: 0x00134008
		<DefaultValue("")>
		Public Property FilterChildCol As String
			Get
				Return Me.O._o0O_0..oOo0.____.
			End Get
			Set(value As String)
				Me.O._o0O_0..oOo0.____. = value
			End Set
		End Property

		' Token: 0x17000C64 RID: 3172
		' (get) Token: 0x06002FC4 RID: 12228 RVA: 0x00135E16 File Offset: 0x00134016
		' (set) Token: 0x06002FC5 RID: 12229 RVA: 0x00135E23 File Offset: 0x00134023
		<DefaultValue("")>
		Public Property FilterCaptionCol As String
			Get
				Return Me.O._o0O_0..ooO0o.o_O.
			End Get
			Set(value As String)
				Me.O._o0O_0..ooO0o.o_O. = value
			End Set
		End Property

		' Token: 0x17000C65 RID: 3173
		' (get) Token: 0x06002FC6 RID: 12230 RVA: 0x00135E31 File Offset: 0x00134031
		' (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00135E3E File Offset: 0x0013403E
		<DefaultValue(False)>
		Public Property FilterTreeSortDesc As Boolean
			Get
				Return Me.O._o0O_0..O0_.__o00_.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O0_.__o00_. = value
			End Set
		End Property

		' Token: 0x17000C66 RID: 3174
		' (get) Token: 0x06002FC8 RID: 12232 RVA: 0x00135E4C File Offset: 0x0013404C
		' (set) Token: 0x06002FC9 RID: 12233 RVA: 0x00135E59 File Offset: 0x00134059
		<DefaultValue(False)>
		Public Property IncludeSubProduct As Boolean
			Get
				Return Me.O._o0O_0..oo_o_.oOO.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..oo_o_.oOO. = value
			End Set
		End Property

		' Token: 0x17000C67 RID: 3175
		' (get) Token: 0x06002FCA RID: 12234 RVA: 0x00135E67 File Offset: 0x00134067
		' (set) Token: 0x06002FCB RID: 12235 RVA: 0x00135E74 File Offset: 0x00134074
		<DefaultValue(False)>
		Public Property InlineTreeAutoSum As Boolean
			Get
				Return Me.O._o0O_0..O.O000.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O.O000. = value
			End Set
		End Property

		' Token: 0x17000C68 RID: 3176
		' (get) Token: 0x06002FCC RID: 12236 RVA: 0x00135E82 File Offset: 0x00134082
		' (set) Token: 0x06002FCD RID: 12237 RVA: 0x00135E8F File Offset: 0x0013408F
		<DefaultValue(False)>
		Public Property InlineTreeMergeSubtotal As Boolean
			Get
				Return Me.O._o0O_0..ooo_Ooo0.__.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..ooo_Ooo0.__. = value
			End Set
		End Property

		' Token: 0x17000C69 RID: 3177
		' (get) Token: 0x06002FCE RID: 12238 RVA: 0x00135E9D File Offset: 0x0013409D
		' (set) Token: 0x06002FCF RID: 12239 RVA: 0x00135EAA File Offset: 0x001340AA
		<DefaultValue("")>
		Public Property FilterTreePathCol As String
			Get
				Return Me.O._o0O_0..o_O_0._O_.
			End Get
			Set(value As String)
				Me.O._o0O_0..o_O_0._O_. = value
			End Set
		End Property

		' Token: 0x17000C6A RID: 3178
		' (get) Token: 0x06002FD0 RID: 12240 RVA: 0x00135EB8 File Offset: 0x001340B8
		' (set) Token: 0x06002FD1 RID: 12241 RVA: 0x00135ECA File Offset: 0x001340CA
		<DefaultValue("")>
		Public Property FilterTreeSeparator As String
			Get
				Return Conversions.ToString(Me.O._o0O_0..o00oOO00_.ooOo.)
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 Then
					Me.O._o0O_0..o00oOO00_.ooOo. = value(0)
					Return
				End If
				Me.O._o0O_0..o00oOO00_.ooOo. = vbNullChar
			End Set
		End Property

		' Token: 0x17000C6B RID: 3179
		' (get) Token: 0x06002FD2 RID: 12242 RVA: 0x00135EFA File Offset: 0x001340FA
		' (set) Token: 0x06002FD3 RID: 12243 RVA: 0x00135F07 File Offset: 0x00134107
		<DefaultValue("")>
		Public Property FilterTreeLengths As String
			Get
				Return Me.O._o0O_0..oo.o0o0O_o_.
			End Get
			Set(value As String)
				Me.O._o0O_0..oo.o0o0O_o_. = value
			End Set
		End Property

		' Token: 0x17000C6C RID: 3180
		' (get) Token: 0x06002FD4 RID: 12244 RVA: 0x00135F15 File Offset: 0x00134115
		' (set) Token: 0x06002FD5 RID: 12245 RVA: 0x00135F22 File Offset: 0x00134122
		<DefaultValue("")>
		Public Property loadTreeColumns As String
			Get
				Return Me.O._o0O_0..o.Ooo__.
			End Get
			Set(value As String)
				Me.O._o0O_0..o.Ooo__. = value
			End Set
		End Property

		' Token: 0x17000C6D RID: 3181
		' (get) Token: 0x06002FD6 RID: 12246 RVA: 0x00135F30 File Offset: 0x00134130
		' (set) Token: 0x06002FD7 RID: 12247 RVA: 0x00135F3D File Offset: 0x0013413D
		<DefaultValue(10000)>
		Public Property LoadTreePageRows As Integer
			Get
				Return Me.O._o0O_0..o.0__o0.
			End Get
			Set(value As Integer)
				Me.O._o0O_0..o.0__o0. = value
			End Set
		End Property

		' Token: 0x17000C6E RID: 3182
		' (get) Token: 0x06002FD8 RID: 12248 RVA: 0x00135F4B File Offset: 0x0013414B
		' (set) Token: 0x06002FD9 RID: 12249 RVA: 0x00135F58 File Offset: 0x00134158
		<DefaultValue("")>
		Public Property LoadTreePageOver As String
			Get
				Return Me.O._o0O_0..O0__O_.O.
			End Get
			Set(value As String)
				Me.O._o0O_0..O0__O_.O. = value
			End Set
		End Property

		' Token: 0x17000C6F RID: 3183
		' (get) Token: 0x06002FDA RID: 12250 RVA: 0x00135F66 File Offset: 0x00134166
		' (set) Token: 0x06002FDB RID: 12251 RVA: 0x00135F73 File Offset: 0x00134173
		<DefaultValue(False)>
		Public Property AutoOpenLoadTree As Boolean
			Get
				Return Me.O._o0O_0..oo.o_ooO.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..oo.o_ooO. = value
			End Set
		End Property

		' Token: 0x17000C70 RID: 3184
		' (get) Token: 0x06002FDC RID: 12252 RVA: 0x00135F81 File Offset: 0x00134181
		' (set) Token: 0x06002FDD RID: 12253 RVA: 0x00135F8E File Offset: 0x0013418E
		<DefaultValue(True)>
		Public Property TreeUnique As Boolean
			Get
				Return Me.O._o0O_0..OOoOO.OO0.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..OOoOO.OO0. = value
			End Set
		End Property

		' Token: 0x17000C71 RID: 3185
		' (get) Token: 0x06002FDE RID: 12254 RVA: 0x00135F9C File Offset: 0x0013419C
		' (set) Token: 0x06002FDF RID: 12255 RVA: 0x00135FA9 File Offset: 0x001341A9
		<DefaultValue(False)>
		Public Property AutoOpenFilterTree As Boolean
			Get
				Return Me.O._o0O_0..o0o0oOOo0__.o.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..o0o0oOOo0__.o. = value
			End Set
		End Property

		' Token: 0x17000C72 RID: 3186
		' (get) Token: 0x06002FE0 RID: 12256 RVA: 0x00135FB7 File Offset: 0x001341B7
		' (set) Token: 0x06002FE1 RID: 12257 RVA: 0x00135FC4 File Offset: 0x001341C4
		<DefaultValue(False)>
		Public Property LoadReverse As Boolean
			Get
				Return Me.O._o0O_0..o00Oo.O0O.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..o00Oo.O0O. = value
			End Set
		End Property

		' Token: 0x17000C73 RID: 3187
		' (get) Token: 0x06002FE2 RID: 12258 RVA: 0x00135FD2 File Offset: 0x001341D2
		' (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00135FDF File Offset: 0x001341DF
		<DefaultValue(False)>
		Public Property AutoGrandTotal As Boolean
			Get
				Return Me.O._o0O_0..Oo.Oo0OoOOoo_.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..Oo.Oo0OoOOoo_. = value
			End Set
		End Property

		' Token: 0x17000C74 RID: 3188
		' (get) Token: 0x06002FE4 RID: 12260 RVA: 0x00135FED File Offset: 0x001341ED
		' (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00135FFA File Offset: 0x001341FA
		<DefaultValue("")>
		Public Property GridTreeParentCol As String
			Get
				Return Me.O._o0O_0..oooo00O.o__0O.
			End Get
			Set(value As String)
				Me.O._o0O_0..oooo00O.o__0O. = value
			End Set
		End Property

		' Token: 0x17000C75 RID: 3189
		' (get) Token: 0x06002FE6 RID: 12262 RVA: 0x00136008 File Offset: 0x00134208
		' (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00136015 File Offset: 0x00134215
		<DefaultValue("")>
		Public Property GridTreeChildCol As String
			Get
				Return Me.O._o0O_0..O___o0.Oo.
			End Get
			Set(value As String)
				Me.O._o0O_0..O___o0.Oo. = value
			End Set
		End Property

		' Token: 0x17000C76 RID: 3190
		' (get) Token: 0x06002FE8 RID: 12264 RVA: 0x00136023 File Offset: 0x00134223
		' (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00136030 File Offset: 0x00134230
		<DefaultValue("")>
		Public Property GridTreeSortCol As String
			Get
				Return Me.O._o0O_0..O0_O.0oOO0Oo0.
			End Get
			Set(value As String)
				Me.O._o0O_0..O0_O.0oOO0Oo0. = value
			End Set
		End Property

		' Token: 0x17000C77 RID: 3191
		' (get) Token: 0x06002FEA RID: 12266 RVA: 0x0013603E File Offset: 0x0013423E
		' (set) Token: 0x06002FEB RID: 12267 RVA: 0x0013604B File Offset: 0x0013424B
		<DefaultValue(False)>
		Public Property GridTreeSortDesc As Boolean
			Get
				Return Me.O._o0O_0..oO_.ooo0o.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..oO_.ooo0o. = value
			End Set
		End Property

		' Token: 0x17000C78 RID: 3192
		' (get) Token: 0x06002FEC RID: 12268 RVA: 0x00136059 File Offset: 0x00134259
		' (set) Token: 0x06002FED RID: 12269 RVA: 0x00136066 File Offset: 0x00134266
		<DefaultValue(False)>
		Public Property GridTreeUseStyle As Boolean
			Get
				Return Me.O._o0O_0..oO._o.
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..oO._o. = value
			End Set
		End Property

		' Token: 0x17000C79 RID: 3193
		' (get) Token: 0x06002FEE RID: 12270 RVA: 0x00136074 File Offset: 0x00134274
		' (set) Token: 0x06002FEF RID: 12271 RVA: 0x00136081 File Offset: 0x00134281
		<DefaultValue("")>
		Public Property GridTreePathCol As String
			Get
				Return Me.O._o0O_0..O_.oOoOO0o.
			End Get
			Set(value As String)
				Me.O._o0O_0..O_.oOoOO0o. = value
			End Set
		End Property

		' Token: 0x17000C7A RID: 3194
		' (get) Token: 0x06002FF0 RID: 12272 RVA: 0x0013608F File Offset: 0x0013428F
		' (set) Token: 0x06002FF1 RID: 12273 RVA: 0x0013609C File Offset: 0x0013429C
		<DefaultValue("")>
		Public Property GridTreeCaptionCol As String
			Get
				Return Me.O._o0O_0..O000__.o_ooo_O.
			End Get
			Set(value As String)
				Me.O._o0O_0..O000__.o_ooo_O. = value
			End Set
		End Property

		' Token: 0x17000C7B RID: 3195
		' (get) Token: 0x06002FF2 RID: 12274 RVA: 0x001360AA File Offset: 0x001342AA
		' (set) Token: 0x06002FF3 RID: 12275 RVA: 0x001360B7 File Offset: 0x001342B7
		<DefaultValue("")>
		Public Property GridTreeSeprtor As String
			Get
				Return Me.O._o0O_0..oO0.00.
			End Get
			Set(value As String)
				Me.O._o0O_0..oO0.00. = value
			End Set
		End Property

		' Token: 0x17000C7C RID: 3196
		' (get) Token: 0x06002FF4 RID: 12276 RVA: 0x001360C5 File Offset: 0x001342C5
		' (set) Token: 0x06002FF5 RID: 12277 RVA: 0x001360D2 File Offset: 0x001342D2
		<DefaultValue("")>
		Public Property GridTreeLengths As String
			Get
				Return Me.O._o0O_0..O_OO.oO0_.
			End Get
			Set(value As String)
				Me.O._o0O_0..O_OO.oO0_. = value
			End Set
		End Property

		' Token: 0x17000C7D RID: 3197
		' (get) Token: 0x06002FF6 RID: 12278 RVA: 0x001360E0 File Offset: 0x001342E0
		' (set) Token: 0x06002FF7 RID: 12279 RVA: 0x001360ED File Offset: 0x001342ED
		<DefaultValue("")>
		Public Property GridTreeGroups As String
			Get
				Return Me.O._o0O_0..o_oO__O.0_.
			End Get
			Set(value As String)
				Me.O._o0O_0..o_oO__O.0_. = value
			End Set
		End Property

		' Token: 0x17000C7E RID: 3198
		' (get) Token: 0x06002FF8 RID: 12280 RVA: 0x001360FB File Offset: 0x001342FB
		' (set) Token: 0x06002FF9 RID: 12281 RVA: 0x00136108 File Offset: 0x00134308
		<DefaultValue("")>
		Public Property GridValueGroups As String
			Get
				Return Me.O._o0O_0..oOoo____oo.O0.
			End Get
			Set(value As String)
				Me.O._o0O_0..oOoo____oo.O0. = value
			End Set
		End Property

		' Token: 0x17000C7F RID: 3199
		' (get) Token: 0x06002FFA RID: 12282 RVA: 0x00136116 File Offset: 0x00134316
		' (set) Token: 0x06002FFB RID: 12283 RVA: 0x00136123 File Offset: 0x00134323
		<DefaultValue(0)>
		Public Property GridTreeExpandLevel As Integer
			Get
				Return Me.O._o0O_0..o__.O0o.
			End Get
			Set(value As Integer)
				Me.O._o0O_0..o__.O0o. = value
			End Set
		End Property

		' Token: 0x17000C80 RID: 3200
		' (get) Token: 0x06002FFC RID: 12284 RVA: 0x00136131 File Offset: 0x00134331
		' (set) Token: 0x06002FFD RID: 12285 RVA: 0x00136143 File Offset: 0x00134343
		<DefaultValue(False)>
		Public Property InlineIncludeParentKey As Boolean
			Get
				Return Me.O._o0O_0..O_O0._..IncludeParentCol
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O_O0._..IncludeParentCol = value
			End Set
		End Property

		' Token: 0x17000C81 RID: 3201
		' (get) Token: 0x06002FFE RID: 12286 RVA: 0x00136158 File Offset: 0x00134358
		' (set) Token: 0x06002FFF RID: 12287 RVA: 0x001361A8 File Offset: 0x001343A8
		<DefaultValue(False)>
		Public Property InlineShowGridTree As Boolean
			Get
				Dim result As Boolean
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					result = Me.O._o0O_0..O_O0._..GridTree
				Else
					result = Me.O._o0O_0..O_O0._..GridTree
				End If
				Return result
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O_O0._..GridTree = value
				Me.O._o0O_0..O_O0._..GridTree = value
			End Set
		End Property

		' Token: 0x17000C82 RID: 3202
		' (get) Token: 0x06003000 RID: 12288 RVA: 0x001361CC File Offset: 0x001343CC
		' (set) Token: 0x06003001 RID: 12289 RVA: 0x0013621C File Offset: 0x0013441C
		<DefaultValue(False)>
		Public Property InlineOnlyGroupRows As Boolean
			Get
				Dim result As Boolean
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					result = Me.O._o0O_0..O_O0._..OnlyGroupRows
				Else
					result = Me.O._o0O_0..O_O0._..OnlyGroupRows
				End If
				Return result
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O_O0._..OnlyGroupRows = value
				Me.O._o0O_0..O_O0._..OnlyGroupRows = value
			End Set
		End Property

		' Token: 0x17000C83 RID: 3203
		' (get) Token: 0x06003002 RID: 12290 RVA: 0x00136240 File Offset: 0x00134440
		' (set) Token: 0x06003003 RID: 12291 RVA: 0x00136290 File Offset: 0x00134490
		<DefaultValue(False)>
		Public Property ShowTreeInParentCol As Boolean
			Get
				Dim result As Boolean
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					result = Me.O._o0O_0..O_O0._..ShowTreeInParentCol
				Else
					result = Me.O._o0O_0..O_O0._..ShowTreeInPathCol
				End If
				Return result
			End Get
			Set(value As Boolean)
				Me.O._o0O_0..O_O0._..ShowTreeInParentCol = value
				Me.O._o0O_0..O_O0._..ShowTreeInPathCol = value
			End Set
		End Property

		' Token: 0x17000C84 RID: 3204
		' (get) Token: 0x06003004 RID: 12292 RVA: 0x001362B4 File Offset: 0x001344B4
		' (set) Token: 0x06003005 RID: 12293 RVA: 0x00136360 File Offset: 0x00134560
		<DefaultValue("")>
		Public Property InlineGroupAdditions As String
			Get
				Dim text As String = ""
				Try
					For Each o00_0__O As o00_0__O In Me.O._o0O_0..O_O0._..Additions
						text = String.Join(",", New String() { o00_0__O.oo__.0O00.().Name, o00_0__O.oooO00__.o0.(), o00_0__O.oooO00.o00O.(), o00_0__O.o.oOo_Oo0O.() }) + vbTab
					Next
				Finally
					Dim enumerator As IEnumerator(Of o00_0__O)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text.Trim(New Char() { vbTab })
			End Get
			Set(value As String)
				Me.O._o0O_0..O_O0._..Additions.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { vbTab })
					For i As Integer = 0 To array.Length - 1
						Dim array2 As String() = array(i).Split(New Char() { ","c })
						If array2.Length = 4 AndAlso OO_00oOO.DataTables.Contains(array2(0)) Then
							Dim dataTable As DataTable = OO_00oOO.DataTables(array2(0))
							If dataTable.BaseTable.Columns.Contains(array2(1)) AndAlso dataTable.BaseTable.Columns.Contains(array2(2)) Then
								Me.O._o0O_0..O_O0._..Additions.Add(dataTable, array2(1), array2(2), array2(3))
							End If
						End If
					Next
				End If
			End Set
		End Property

		' Token: 0x17000C85 RID: 3205
		' (get) Token: 0x06003006 RID: 12294 RVA: 0x0013643C File Offset: 0x0013463C
		' (set) Token: 0x06003007 RID: 12295 RVA: 0x001364E8 File Offset: 0x001346E8
		<DefaultValue("")>
		Public Property LayersGroupAdditions As String
			Get
				Dim text As String = ""
				Try
					For Each o00_0__O As o00_0__O In Me.O._o0O_0..O_O0._..Additions
						text = String.Join(",", New String() { o00_0__O.oo__.0O00.().Name, o00_0__O.oooO00__.o0.(), o00_0__O.oooO00.o00O.(), o00_0__O.o.oOo_Oo0O.() }) + vbTab
					Next
				Finally
					Dim enumerator As IEnumerator(Of o00_0__O)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
				Return text.Trim(New Char() { vbTab })
			End Get
			Set(value As String)
				Me.O._o0O_0..O_O0._..Additions.Clear()
				If Operators.CompareString(value, "", True) > 0 Then
					Dim array As String() = value.Split(New Char() { vbTab })
					For i As Integer = 0 To array.Length - 1
						Dim array2 As String() = array(i).Split(New Char() { ","c })
						If array2.Length = 4 AndAlso OO_00oOO.DataTables.Contains(array2(0)) Then
							Dim dataTable As DataTable = OO_00oOO.DataTables(array2(0))
							If dataTable.BaseTable.Columns.Contains(array2(1)) AndAlso dataTable.BaseTable.Columns.Contains(array2(2)) Then
								Me.O._o0O_0..O_O0._..Additions.Add(dataTable, array2(1), array2(2), array2(3))
							End If
						End If
					Next
				End If
			End Set
		End Property

		' Token: 0x17000C86 RID: 3206
		' (get) Token: 0x06003008 RID: 12296 RVA: 0x001365C4 File Offset: 0x001347C4
		' (set) Token: 0x06003009 RID: 12297 RVA: 0x00136614 File Offset: 0x00134814
		<DefaultValue(0)>
		Public Property InlineExpandLevel As Integer
			Get
				Dim result As Integer
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					result = Me.O._o0O_0..O_O0._..ExpandTo
				Else
					result = Me.O._o0O_0..O_O0._..ExpandTo
				End If
				Return result
			End Get
			Set(value As Integer)
				Me.O._o0O_0..O_O0._..ExpandTo = value
				Me.O._o0O_0..O_O0._..ExpandTo = value
			End Set
		End Property

		' Token: 0x17000C87 RID: 3207
		' (get) Token: 0x0600300A RID: 12298 RVA: 0x00136638 File Offset: 0x00134838
		' (set) Token: 0x0600300B RID: 12299 RVA: 0x00136688 File Offset: 0x00134888
		<DefaultValue(0)>
		Public Property InlinePreserveTolevel As Integer
			Get
				Dim result As Integer
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					result = Me.O._o0O_0..O_O0._..PreserveTo
				Else
					result = Me.O._o0O_0..O_O0._..PreserveTo
				End If
				Return result
			End Get
			Set(value As Integer)
				Me.O._o0O_0..O_O0._..PreserveTo = value
				Me.O._o0O_0..O_O0._..PreserveTo = value
			End Set
		End Property

		' Token: 0x17000C88 RID: 3208
		' (get) Token: 0x0600300C RID: 12300 RVA: 0x001366AC File Offset: 0x001348AC
		' (set) Token: 0x0600300D RID: 12301 RVA: 0x001366BE File Offset: 0x001348BE
		<DefaultValue("")>
		Public Property InlineTableName As String
			Get
				Return Me.O._o0O_0..O_O0._..TableName
			End Get
			Set(value As String)
				Me.O._o0O_0..O_O0._..TableName = value
			End Set
		End Property

		' Token: 0x17000C89 RID: 3209
		' (get) Token: 0x0600300E RID: 12302 RVA: 0x001366D1 File Offset: 0x001348D1
		' (set) Token: 0x0600300F RID: 12303 RVA: 0x001366E3 File Offset: 0x001348E3
		<DefaultValue("")>
		Public Property LayersTableName As String
			Get
				Return Me.O._o0O_0..O_O0._..TableName
			End Get
			Set(value As String)
				Me.O._o0O_0..O_O0._..TableName = value
			End Set
		End Property

		' Token: 0x17000C8A RID: 3210
		' (get) Token: 0x06003010 RID: 12304 RVA: 0x001366F8 File Offset: 0x001348F8
		' (set) Token: 0x06003011 RID: 12305 RVA: 0x001367FC File Offset: 0x001349FC
		<DefaultValue("")>
		Public Property InlieGroupTotals As String
			Get
				Dim list As List(Of o0o_)
				If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
					list = Me.O._o0O_0..O_O0._..Totals
				Else
					list = Me.O._o0O_0..O_O0._..Totals
				End If
				Dim text As String = ""
				Try
					For Each o0o_ As o0o_ In list
						If Operators.CompareString(text, "", True) > 0 Then
							text += vbCr
						End If
						text = String.Concat(New String() { text, o0o_.o0oO._o_.(), vbTab, o0o_.Oo0oO0oOO_.0_o.(), vbTab, Conversions.ToString(CInt(o0o_.O0OO_0.O.())), vbTab, Conversions.ToString(CInt(o0o_.o0oO._o_.())) })
					Next
				Finally
					Dim enumerator As List(Of o0o_).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return text
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Dim array As String() = value.Split(New Char() { vbCr })
					IL_1B:
					num2 = 3
					For Each text As String In array
						IL_2F:
						num2 = 4
						Dim array3 As String() = text.Split(New Char() { vbTab })
						IL_45:
						num2 = 5
						If Operators.CompareString(Me.O._o0O_0..O_O0._..TableName, "", True) > 0 Then
							IL_65:
							num2 = 6
							Me.O._o0O_0..O_O0._..AddTotal(array3(0), array3(1), CType(Conversions.ToInteger(array3(2)), AggregateRange), CType(Conversions.ToInteger(array3(3)), AggregateType))
						Else
							IL_93:
							num2 = 8
							Me.O._o0O_0..O_O0._..AddTotal(array3(0), array3(1), CType(Conversions.ToInteger(array3(2)), AggregateRange), CType(Conversions.ToInteger(array3(3)), AggregateType))
						End If
						IL_BF:
						num2 = 9
					Next
					IL_D3:
					GoTo IL_14A
					IL_D5:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_10B:
					GoTo IL_13F
					IL_10D:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_11D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_10D
				End Try
				IL_13F:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_14A:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		' Token: 0x17000C8B RID: 3211
		' (get) Token: 0x06003012 RID: 12306 RVA: 0x00136978 File Offset: 0x00134B78
		' (set) Token: 0x06003013 RID: 12307 RVA: 0x00136985 File Offset: 0x00134B85
		<DefaultValue("")>
		Public Property LoopParentCol As String
			Get
				Return Me.O._o0O_0..O0.00__.
			End Get
			Set(value As String)
				Me.O._o0O_0..O0.00__. = value
			End Set
		End Property

		' Token: 0x17000C8C RID: 3212
		' (get) Token: 0x06003014 RID: 12308 RVA: 0x00136993 File Offset: 0x00134B93
		' (set) Token: 0x06003015 RID: 12309 RVA: 0x001369A0 File Offset: 0x00134BA0
		<DefaultValue("")>
		Public Property LoopChildCol As String
			Get
				Return Me.O._o0O_0..o.o0o_0.
			End Get
			Set(value As String)
				Me.O._o0O_0..o.o0o_0. = value
			End Set
		End Property

		' Token: 0x17000C8D RID: 3213
		' (get) Token: 0x06003016 RID: 12310 RVA: 0x001369B0 File Offset: 0x00134BB0
		' (set) Token: 0x06003017 RID: 12311 RVA: 0x001369EC File Offset: 0x00134BEC
		<DefaultValue("")>
		Public Property DuplicateColNames As String
			Get
				Dim result As String
				If Me.O._o0O_0..o.OO0O0O. IsNot Nothing Then
					result = String.Join(",", Me.O._o0O_0..o.OO0O0O.)
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 Then
					Dim list As List(Of String) = New List(Of String)()
					list.AddRange(value.Split(New Char() { ","c }))
					Me.O._o0O_0..o.OO0O0O. = list
				End If
			End Set
		End Property

		' Token: 0x04001330 RID: 4912
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001331 RID: 4913
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001332 RID: 4914
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001333 RID: 4915
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001334 RID: 4916
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001335 RID: 4917
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001336 RID: 4918
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001337 RID: 4919
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001338 RID: 4920
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001339 RID: 4921
		Private <<EMPTY_NAME>> As Font

		' Token: 0x0400133A RID: 4922
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400133B RID: 4923
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400133C RID: 4924
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400133D RID: 4925
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400133E RID: 4926
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400133F RID: 4927
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001340 RID: 4928
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001341 RID: 4929
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001342 RID: 4930
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
