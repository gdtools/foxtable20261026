Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200032A RID: 810
	Friend Class TableViewProperty
		' Token: 0x06003018 RID: 12312 RVA: 0x00136A34 File Offset: 0x00134C34
		Public Sub New(A_0 As Table)
			Me.O._o0O_0. = ""
			Me.o_o_.oo_0O. = ""
			Me.o._O0o_00. = ""
			Me.O_.Oo_o0OOOOO. = ""
			Me.Oo0.___ooOo_o. = ""
			Me.oo.O_oO_O. = ""
			Me.o.00_o_oOoOOoO. = ""
			Me.Ooo_O0.0. = ""
			Me.Oo_._O0oOOOo. = A_0
		End Sub

		' Token: 0x17000C8E RID: 3214
		' (get) Token: 0x06003019 RID: 12313 RVA: 0x00136AA6 File Offset: 0x00134CA6
		' (set) Token: 0x0600301A RID: 12314 RVA: 0x00136AAE File Offset: 0x00134CAE
		Public Property ViewSetting As TableViewSettingEnum
			Get
				Return Me.Oo_._O0oOOOo.
			End Get
			Set(value As TableViewSettingEnum)
				Me.Oo_._O0oOOOo. = value
			End Set
		End Property

		' Token: 0x17000C8F RID: 3215
		' (get) Token: 0x0600301B RID: 12315 RVA: 0x00136AB8 File Offset: 0x00134CB8
		' (set) Token: 0x0600301C RID: 12316 RVA: 0x00136AEA File Offset: 0x00134CEA
		Public Property Sort As String
			Get
				Dim result As String
				If(Me.ViewSetting And 1) = 1 Then
					result = Me.Oo_._O0oOOOo..View.oO_O.o_OOO.()
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.o.00_o_oOoOOoO. = value
			End Set
		End Property

		' Token: 0x17000C90 RID: 3216
		' (get) Token: 0x0600301D RID: 12317 RVA: 0x00136AF4 File Offset: 0x00134CF4
		' (set) Token: 0x0600301E RID: 12318 RVA: 0x00136B26 File Offset: 0x00134D26
		Public Property Filter As String
			Get
				Dim result As String
				If(Me.ViewSetting And 2) = 2 Then
					result = Me.Oo_._O0oOOOo..View.get_Filter()
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.Ooo_O0.0. = value
			End Set
		End Property

		' Token: 0x17000C91 RID: 3217
		' (get) Token: 0x0600301F RID: 12319 RVA: 0x00136B30 File Offset: 0x00134D30
		' (set) Token: 0x06003020 RID: 12320 RVA: 0x00136BC9 File Offset: 0x00134DC9
		Public Property RowHeight As String
			Get
				Dim result As String
				If(Me.ViewSetting And 256) = 256 Then
					Dim text As String = Me.Oo_._O0oOOOo..foxGrid.Rows.DefaultSize.ToString()
					Dim num As Integer = Me.Oo_._O0oOOOo..foxGrid.Rows.Fixed - 1
					For i As Integer = 0 To num
						text = text + vbTab + Conversions.ToString(Me.Oo_._O0oOOOo..foxGrid.Rows(i).Height)
					Next
					result = text
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.O_.Oo_o0OOOOO. = value
			End Set
		End Property

		' Token: 0x17000C92 RID: 3218
		' (get) Token: 0x06003021 RID: 12321 RVA: 0x00136BD4 File Offset: 0x00134DD4
		' (set) Token: 0x06003022 RID: 12322 RVA: 0x00136C5D File Offset: 0x00134E5D
		Public Property ColumnString As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Fixed
				Dim num As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					text += Me.Oo_._O0oOOOo..foxGrid.Cols(i).Name
				Next
				Return text
			End Get
			Set(value As String)
				Me.O._o0O_0. = value
			End Set
		End Property

		' Token: 0x17000C93 RID: 3219
		' (get) Token: 0x06003023 RID: 12323 RVA: 0x00136C68 File Offset: 0x00134E68
		' (set) Token: 0x06003024 RID: 12324 RVA: 0x00136CF6 File Offset: 0x00134EF6
		Public Property ColumnWidth As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Fixed
				Dim num As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					text += Conversions.ToString(Me.Oo_._O0oOOOo..foxGrid.Cols(i).Width)
				Next
				Return text
			End Get
			Set(value As String)
				Me.o_o_.oo_0O. = value
			End Set
		End Property

		' Token: 0x17000C94 RID: 3220
		' (get) Token: 0x06003025 RID: 12325 RVA: 0x00136D00 File Offset: 0x00134F00
		' (set) Token: 0x06003026 RID: 12326 RVA: 0x00136DA0 File Offset: 0x00134FA0
		Public Property ColumnVisible As String
			Get
				Dim text As String = ""
				Dim fixed As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Fixed
				Dim num As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Count - 1
				For i As Integer = fixed To num
					If Operators.CompareString(text, "", True) > 0 Then
						text += vbTab
					End If
					If Me.Oo_._O0oOOOo..foxGrid.Cols(i).Visible Then
						text += Conversions.ToString(1)
					Else
						text += Conversions.ToString(0)
					End If
				Next
				Return text
			End Get
			Set(value As String)
				Me.o._O0o_00. = value
			End Set
		End Property

		' Token: 0x17000C95 RID: 3221
		' (get) Token: 0x06003027 RID: 12327 RVA: 0x00136DAC File Offset: 0x00134FAC
		' (set) Token: 0x06003028 RID: 12328 RVA: 0x00136E40 File Offset: 0x00135040
		Public Property Groups As String
			Get
				Dim result As String
				If(Me.ViewSetting And 8) = 8 Then
					Dim text As String = ""
					Try
						For Each a_ As SubtotalGroup In Me.Oo_._O0oOOOo..SubtotalGroups
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
					result = text
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.Oo0.___ooOo_o. = value
			End Set
		End Property

		' Token: 0x17000C96 RID: 3222
		' (get) Token: 0x06003029 RID: 12329 RVA: 0x00136E49 File Offset: 0x00135049
		' (set) Token: 0x0600302A RID: 12330 RVA: 0x00136E56 File Offset: 0x00135056
		Public Property GroupAboveData As Boolean
			Get
				Return Me.Oo_._O0oOOOo..GroupAboveData
			End Get
			Set(value As Boolean)
				Me.o0._0o_. = value
			End Set
		End Property

		' Token: 0x17000C97 RID: 3223
		' (get) Token: 0x0600302B RID: 12331 RVA: 0x00136E5F File Offset: 0x0013505F
		' (set) Token: 0x0600302C RID: 12332 RVA: 0x00136E6C File Offset: 0x0013506C
		Public Property TreeVisible As Boolean
			Get
				Return Me.Oo_._O0oOOOo..TreeVisible
			End Get
			Set(value As Boolean)
				Me.o_o0o._O. = value
			End Set
		End Property

		' Token: 0x17000C98 RID: 3224
		' (get) Token: 0x0600302D RID: 12333 RVA: 0x00136E75 File Offset: 0x00135075
		' (set) Token: 0x0600302E RID: 12334 RVA: 0x00136E82 File Offset: 0x00135082
		Public Property Subtotal As Boolean
			Get
				Return Me.Oo_._O0oOOOo..IsSubtotal
			End Get
			Set(value As Boolean)
				Me.o0o_oo00_0_0.O. = value
			End Set
		End Property

		' Token: 0x17000C99 RID: 3225
		' (get) Token: 0x0600302F RID: 12335 RVA: 0x00136E8C File Offset: 0x0013508C
		' (set) Token: 0x06003030 RID: 12336 RVA: 0x00136F1C File Offset: 0x0013511C
		Public Property MergeCols As String
			Get
				Dim result As String
				If(Me.ViewSetting And 4) = 4 Then
					Dim text As String = ""
					Try
						For Each str As String In Me.Oo_._O0oOOOo..MergeCols
							If Operators.CompareString(text, "", True) > 0 Then
								text += ","
							End If
							text += str
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = text
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.O00o_.__O. = value
			End Set
		End Property

		' Token: 0x17000C9A RID: 3226
		' (get) Token: 0x06003031 RID: 12337 RVA: 0x00136F28 File Offset: 0x00135128
		' (set) Token: 0x06003032 RID: 12338 RVA: 0x00136F55 File Offset: 0x00135155
		Public Property MergeSort As String
			Get
				Dim result As String
				If(Me.ViewSetting And 4) = 4 Then
					result = Me.Oo_._O0oOOOo..MergeSort
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.o_.0o0oOo_. = value
			End Set
		End Property

		' Token: 0x17000C9B RID: 3227
		' (get) Token: 0x06003033 RID: 12339 RVA: 0x00136F5E File Offset: 0x0013515E
		' (set) Token: 0x06003034 RID: 12340 RVA: 0x00136F6B File Offset: 0x0013516B
		Public Property MergeMode As MergeModeEnum
			Get
				Return Me.Oo_._O0oOOOo..MergeMode
			End Get
			Set(value As MergeModeEnum)
				Me.o0._0o_. = value
			End Set
		End Property

		' Token: 0x17000C9C RID: 3228
		' (get) Token: 0x06003035 RID: 12341 RVA: 0x00136F74 File Offset: 0x00135174
		' (set) Token: 0x06003036 RID: 12342 RVA: 0x00136F81 File Offset: 0x00135181
		Public Property AllowMerge As Boolean
			Get
				Return Me.Oo_._O0oOOOo..AllowMerge
			End Get
			Set(value As Boolean)
				Me.oOO.o00OOO_o. = value
			End Set
		End Property

		' Token: 0x17000C9D RID: 3229
		' (get) Token: 0x06003037 RID: 12343 RVA: 0x00136F8C File Offset: 0x0013518C
		' (set) Token: 0x06003038 RID: 12344 RVA: 0x00137000 File Offset: 0x00135200
		Public Property PrintInfo As String
			Get
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						Return ""
					End If
				Catch ex As Exception
					Return ""
				End Try
				Dim result As String
				If(Me.ViewSetting And 16) = 16 Then
					result = o_O_o_oOoo__.OOOO_OO._oo.(Me.Oo_._O0oOOOo..PrintInfo, False, vbLf, False)
				Else
					result = ""
				End If
				Return result
			End Get
			Set(value As String)
				Me.oo.O_oO_O. = value
			End Set
		End Property

		' Token: 0x06003039 RID: 12345 RVA: 0x0013700C File Offset: 0x0013520C
		Friend Sub Restore()
			If Operators.CompareString(Me.O._o0O_0., "", True) > 0 AndAlso Operators.CompareString(Me.o_o_.oo_0O., "", True) > 0 AndAlso Operators.CompareString(Me.o._O0o_00., "", True) > 0 Then
				Dim array As String() = Me.O._o0O_0..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				Dim array2 As String() = Me.o_o_.oo_0O..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				Dim array3 As String() = Me.o._O0o_00..Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
				Dim num As Integer = Me.Oo_._O0oOOOo..foxGrid.Cols.Fixed
				Dim num2 As Integer = array.Length - 1
				For i As Integer = 0 To num2
					If Me.Oo_._O0oOOOo..foxGrid.Cols.Contains(array(i)) Then
						If(Me.ViewSetting And 64) = 64 Then
							Me.Oo_._O0oOOOo..foxGrid.Cols(array(i)).Width = Convert.ToInt32(array2(i))
						End If
						If(Me.ViewSetting And 32) = 32 Then
							Me.Oo_._O0oOOOo..foxGrid.Cols(array(i)).Move(num)
						End If
						If(Me.ViewSetting And 128) = 128 Then
							If Convert.ToInt32(array3(i)) = 1 Then
								Me.Oo_._O0oOOOo..foxGrid.Cols(array(i)).Visible = True
							Else
								Me.Oo_._O0oOOOo..foxGrid.Cols(array(i)).Visible = False
							End If
						End If
						num += 1
					End If
				Next
			End If
			If(Me.ViewSetting And 256) = 256 AndAlso Operators.CompareString(Me.O_.Oo_o0OOOOO., "", True) > 0 Then
				Dim array4 As String() = Me.O_.Oo_o0OOOOO..Split(New Char() { vbTab })
				Me.Oo_._O0oOOOo..foxGrid.Rows.DefaultSize = Convert.ToInt32(array4(0))
				Dim num3 As Integer = Math.Min(array4.Length - 1, Me.Oo_._O0oOOOo..foxGrid.Rows.Fixed)
				For j As Integer = 1 To num3
					Me.Oo_._O0oOOOo..foxGrid.Rows(j - 1).Height = Convert.ToInt32(array4(j))
				Next
			End If
			If(Me.ViewSetting And 1) = 1 Then
				Me.Oo_._O0oOOOo..Sort = Me.o.00_o_oOoOOoO.
			End If
			If(Me.ViewSetting And 2) = 2 Then
				Me.Oo_._O0oOOOo..Filter = Me.Ooo_O0.0.
			End If
			If(Me.ViewSetting And 4) = 4 AndAlso Operators.CompareString(Me.O00o_.__O., "", True) > 0 Then
				Dim array5 As String() = Me.O00o_.__O..Split(New Char() { ","c }, StringSplitOptions.RemoveEmptyEntries)
				Me.Oo_._O0oOOOo..MergeCols.Clear()
				For Each item As String In array5
					Me.Oo_._O0oOOOo..MergeCols.Add(item)
				Next
				Me.Oo_._O0oOOOo..MergeMode = Me.o0._0o_.
				Me.Oo_._O0oOOOo..MergeSort = Me.o_.0o0oOo_.
				Me.Oo_._O0oOOOo..AllowMerge = Me.oOO.o00OOO_o.
			End If
			If(Me.ViewSetting And 8) = 8 Then
				Dim array7 As String() = Me.Oo0.___ooOo_o..Split(New Char() { vbCr }, StringSplitOptions.RemoveEmptyEntries)
				Me.Oo_._O0oOOOo..SubtotalGroups.Clear()
				Me.Oo_._O0oOOOo..GroupAboveData = Me.o0._0o_.
				Me.Oo_._O0oOOOo..TreeVisible = Me.o_o0o._O.
				For Each a_ As String In array7
					Dim subtotalGroup As SubtotalGroup = New SubtotalGroup()
					o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, vbLf)
					Me.Oo_._O0oOOOo..SubtotalGroups.Add(subtotalGroup)
				Next
				If Me.Oo_._O0oOOOo..SubtotalGroups.Count > 0 Or Me.o0o_oo00_0_0.O. Then
					Me.Oo_._O0oOOOo..Subtotal(False)
				ElseIf Me.Oo_._O0oOOOo..IsSubtotal Then
					Me.Oo_._O0oOOOo..ClearSubtotal()
				End If
			End If
			If(Me.ViewSetting And 16) = 16 AndAlso Operators.CompareString(Me.oo.O_oO_O., "", True) > 0 Then
				Me.Oo_._O0oOOOo..PrintInfo = New PrintInfo(Me.Oo_._O0oOOOo.)
				o_O_o_oOoo__.OOOO_OO._oo.(Me.Oo_._O0oOOOo..PrintInfo, Me.oo.O_oO_O., vbLf)
				If OO_00oOO.CurrentTable Is Me.Oo_._O0oOOOo. Then
					OO_00oOO.Vars("SysUpdatePrintInfo") = True
				End If
			End If
		End Sub

		' Token: 0x04001343 RID: 4931
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001344 RID: 4932
		Private <<EMPTY_NAME>> As TableViewSettingEnum

		' Token: 0x04001345 RID: 4933
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001346 RID: 4934
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001347 RID: 4935
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001348 RID: 4936
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001349 RID: 4937
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400134A RID: 4938
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400134B RID: 4939
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400134C RID: 4940
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400134D RID: 4941
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400134E RID: 4942
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400134F RID: 4943
		Private <<EMPTY_NAME>> As MergeModeEnum

		' Token: 0x04001350 RID: 4944
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001351 RID: 4945
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001352 RID: 4946
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001353 RID: 4947
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
