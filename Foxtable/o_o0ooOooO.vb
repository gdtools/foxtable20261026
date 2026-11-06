Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Foxtable.My.Resources
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200029D RID: 669
	Friend Class o_o0ooOooO
		Inherits System.Windows.Forms.TreeView

		' Token: 0x060022A3 RID: 8867 RVA: 0x000ECC82 File Offset: 0x000EAE82
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As System.Windows.Forms.Button
			Return Me.O0o.0oo0_.
		End Function

		' Token: 0x060022A4 RID: 8868 RVA: 0x000ECC8C File Offset: 0x000EAE8C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As System.Windows.Forms.Button)
			Dim value As EventHandler = AddressOf Me.O0o.0oo0_.
			Dim o0o.0oo0_. As System.Windows.Forms.Button = Me.O0o.0oo0_.
			If o0o.0oo0_. IsNot Nothing Then
				RemoveHandler o0o.0oo0_..Click, value
			End If
			Me.O0o.0oo0_. = A_0
			o0o.0oo0_. = Me.O0o.0oo0_.
			If o0o.0oo0_. IsNot Nothing Then
				AddHandler o0o.0oo0_..Click, value
			End If
		End Sub

		' Token: 0x060022A5 RID: 8869 RVA: 0x000ECCD0 File Offset: 0x000EAED0
		Friend Sub New()
			AddHandler MyBase.AfterSelect, AddressOf Me.O0o.0oo0_.
			AddHandler MyBase.ParentChanged, AddressOf Me.oO._O_00__ooo.
			Me.O0o.0oo0_. = New List(Of String)()
			Me.OOO_.00. = New List(Of System.Windows.Forms.TreeNode)()
		End Sub

		' Token: 0x060022A6 RID: 8870 RVA: 0x000ECD20 File Offset: 0x000EAF20
		Friend Sub New(A_0 As Table, A_1 As String)
			AddHandler MyBase.AfterSelect, AddressOf Me.O0o.0oo0_.
			AddHandler MyBase.ParentChanged, AddressOf Me.oO._O_00__ooo.
			Me.O0o.0oo0_. = New List(Of String)()
			Me.OOO_.00. = New List(Of System.Windows.Forms.TreeNode)()
			Me.OOO_.00. = A_0
			Me.O0o.0oo0_.(A_1)
		End Sub

		' Token: 0x060022A7 RID: 8871 RVA: 0x000ECD7C File Offset: 0x000EAF7C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As TreeViewEventArgs)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If System.Windows.Forms.Control.ModifierKeys = Keys.Control AndAlso A_1.Node IsNot MyBase.Nodes(0) Then
					GoTo IL_87
				End If
				IL_29:
				num2 = 3
				Dim enumerator As List(Of System.Windows.Forms.TreeNode).Enumerator = Me.OOO_.00..GetEnumerator()
				While enumerator.MoveNext()
					Dim treeNode As System.Windows.Forms.TreeNode = enumerator.Current
					IL_42:
					num2 = 4
					treeNode.BackColor = Me.BackColor
					IL_51:
					num2 = 5
					treeNode.ForeColor = Me.ForeColor
					IL_60:
					num2 = 6
				End While
				IL_6B:
				num2 = 7
				CType(enumerator, IDisposable).Dispose()
				IL_7A:
				num2 = 8
				Me.OOO_.00..Clear()
				IL_87:
				num2 = 9
				If A_1.Node IsNot MyBase.Nodes(0) Then
					GoTo IL_B6
				End If
				IL_9E:
				num2 = 10
				Me.OOO_.00..Filter = ""
				GoTo IL_891
				IL_B6:
				num2 = 12
				A_1.Node.BackColor = Color.Blue
				IL_C9:
				num2 = 13
				A_1.Node.ForeColor = Color.White
				IL_DC:
				num2 = 14
				Me.OOO_.00..Add(A_1.Node)
				IL_F0:
				num2 = 15
				Dim text As String = ""
				IL_FA:
				num2 = 16
				Dim enumerator2 As List(Of System.Windows.Forms.TreeNode).Enumerator = Me.OOO_.00..GetEnumerator()
				While enumerator2.MoveNext()
					Dim treeNode2 As System.Windows.Forms.TreeNode = enumerator2.Current
					IL_118:
					num2 = 17
					Dim text2 As String = ""
					IL_122:
					num2 = 18
					Dim level As Integer = treeNode2.Level
					IL_12E:
					num2 = 19
					If Me.OOO_.00. Then
						IL_13C:
						num2 = 20
						Dim array As System.Windows.Forms.TreeNode() = New System.Windows.Forms.TreeNode(level + 1 - 1) {}
						IL_14A:
						num2 = 21
						For i As Integer = level To 0 Step -1
							IL_153:
							num2 = 22
							array(i) = treeNode2
							IL_15D:
							num2 = 23
							treeNode2 = treeNode2.Parent
							IL_169:
							num2 = 24
						Next
						IL_177:
						num2 = 25
						For j As Integer = level To 0 Step -1
							IL_183:
							num2 = 26
							If j < level Then
								IL_18C:
								num2 = 27
								text2 += " And "
							End If
							IL_19D:
							num2 = 28
							Dim text3 As String = Me.O0o.0oo0_.(j)
							IL_1AF:
							num2 = 29
							If text3.EndsWith("_D_") Then
								IL_1C3:
								num2 = 30
								text3 = text3.Substring(0, text3.Length - 3)
								IL_1D9:
								num2 = 31
								Dim day As Integer = Conversions.ToInteger(array(j).Text)
								IL_1ED:
								num2 = 32
								Dim month As Integer = Conversions.ToInteger(array(j - 1).Text)
								IL_203:
								num2 = 33
								Dim year As Integer = Conversions.ToInteger(array(j - 2).Text)
								IL_219:
								num2 = 34
								Dim value As DateTime = New DateTime(year, month, day)
								IL_229:
								num2 = 35
								text2 = String.Concat(New String() { text2, "[", text3, "] >= #", Conversions.ToString(value), "# And [", text3, "] < #", Conversions.ToString(value.AddDays(1.0)), "#" })
								IL_294:
								num2 = 36
								j -= 2
							Else
								IL_2A2:
								num2 = 38
								If text3.EndsWith("_W_") Then
									IL_2B6:
									num2 = 39
									text3 = text3.Substring(0, text3.Length - 3)
									IL_2CC:
									num2 = 40
									Dim num3 As Integer = Conversions.ToInteger(array(j).Text)
									IL_2E0:
									num2 = 41
									Dim year2 As Integer = Conversions.ToInteger(array(j - 1).Text)
									IL_2F6:
									num2 = 42
									Dim dateTime As DateTime = New DateTime(year2, 1, 1)
									IL_304:
									num2 = 43
									Dim dateTime2 As DateTime = dateTime.AddDays(CDbl((-CDbl(dateTime.DayOfWeek)))).AddDays(CDbl(((num3 - 1) * 7)))
									IL_329:
									num2 = 44
									Dim dateTime3 As DateTime = dateTime2.AddDays(6.0)
									IL_33E:
									num2 = 45
									If DateTime.Compare(dateTime2, dateTime) < 0 Then
										IL_34D:
										num2 = 46
										dateTime2 = dateTime
									End If
									IL_354:
									num2 = 47
									text2 = String.Concat(New String() { text2, "[", text3, "] >= #", Conversions.ToString(dateTime2), "# And [", text3, "] < #", Conversions.ToString(dateTime3.AddDays(1.0)), "#" })
									IL_3BF:
									num2 = 48
									j -= 1
								Else
									IL_3CD:
									num2 = 50
									If text3.EndsWith("_M_") Then
										IL_3E1:
										num2 = 51
										text3 = text3.Substring(0, text3.Length - 3)
										IL_3F7:
										num2 = 52
										Dim month2 As Integer = Conversions.ToInteger(array(j).Text)
										IL_40B:
										num2 = 53
										Dim year3 As Integer = Conversions.ToInteger(array(j - 1).Text)
										IL_421:
										num2 = 54
										Dim value2 As DateTime = New DateTime(year3, month2, 1)
										IL_430:
										num2 = 55
										Dim dateTime4 As DateTime = New DateTime(year3, month2, DateTime.DaysInMonth(year3, month2))
										IL_447:
										num2 = 56
										text2 = String.Concat(New String() { text2, "[", text3, "] >= #", Conversions.ToString(value2), "# And [", text3, "] < #", Conversions.ToString(dateTime4.AddDays(1.0)), "#" })
										IL_4B2:
										num2 = 57
										j -= 1
									Else
										IL_4C0:
										num2 = 59
										If text3.EndsWith("_Q_") Then
											IL_4D4:
											num2 = 60
											text3 = text3.Substring(0, text3.Length - 3)
											IL_4EA:
											num2 = 61
											Dim num4 As Integer = Conversions.ToInteger(array(j).Text)
											IL_4FE:
											num2 = 62
											Dim year4 As Integer = Conversions.ToInteger(array(j - 1).Text)
											IL_514:
											num2 = 63
											Dim value3 As DateTime = New DateTime(year4, (num4 - 1) * 3 + 1, 1)
											IL_529:
											num2 = 64
											Dim dateTime5 As DateTime = New DateTime(year4, (num4 - 1) * 3 + 3, DateTime.DaysInMonth(year4, (num4 - 1) * 3 + 3))
											IL_54C:
											num2 = 65
											text2 = String.Concat(New String() { text2, "[", text3, "] >= #", Conversions.ToString(value3), "# And [", text3, "] < #", Conversions.ToString(dateTime5.AddDays(1.0)), "#" })
											IL_5B7:
											num2 = 66
											j -= 1
										Else
											IL_5C5:
											num2 = 68
											If text3.EndsWith("_Y_") Then
												IL_5D9:
												num2 = 69
												text3 = text3.Substring(0, text3.Length - 3)
												IL_5EF:
												num2 = 70
												Dim year5 As Integer = Conversions.ToInteger(array(j).Text)
												IL_603:
												num2 = 71
												Dim value4 As DateTime = New DateTime(year5, 1, 1)
												IL_611:
												num2 = 72
												Dim dateTime6 As DateTime = New DateTime(year5, 12, 31)
												IL_621:
												num2 = 73
												text2 = String.Concat(New String() { text2, "[", text3, "] >= #", Conversions.ToString(value4), "# And [", text3, "] < #", Conversions.ToString(dateTime6.AddDays(1.0)), "#" })
											Else
												IL_691:
												num2 = 75
												text2 = text2 + "[" + text3 + "] = "
												IL_6A9:
												num2 = 76
												Dim text4 As String = ""
												IL_6B3:
												num2 = 77
												If Me.OOO_.00..Cols(text3).IsString() Then
													IL_6CF:
													num2 = 78
													text4 = "'"
												Else
													IL_6DB:
													num2 = 80
													If Me.OOO_.00..Cols(text3).IsDate() Then
														IL_6F7:
														num2 = 81
														text4 = "#"
													End If
												End If
												IL_701:
												num2 = 82
												text2 = text2 + text4 + array(j).Text + text4
											End If
										End If
									End If
								End If
							End If
							IL_71B:
							num2 = 83
						Next
					Else
						IL_731:
						num2 = 85
						For k As Integer = level To 0 Step -1
							IL_73D:
							num2 = 86
							If k < level Then
								IL_746:
								num2 = 87
								text2 += " And "
							End If
							IL_757:
							num2 = 88
							text2 = text2 + "[" + Me.OOO_.00.(k) + "] = "
							IL_776:
							num2 = 89
							Dim text5 As String = ""
							IL_780:
							num2 = 90
							If Me.OOO_.00..Cols(Me.OOO_.00.(k)).IsString() Then
								IL_7A3:
								num2 = 91
								text5 = "'"
							Else
								IL_7AF:
								num2 = 93
								If Me.OOO_.00..Cols(Me.OOO_.00.(k)).IsDate() Then
									IL_7D2:
									num2 = 94
									text5 = "#"
								End If
							End If
							IL_7DC:
							num2 = 95
							text2 = text2 + text5 + treeNode2.Text.Replace("'", "''") + text5
							IL_802:
							num2 = 96
							treeNode2 = treeNode2.Parent
							IL_80E:
							num2 = 97
						Next
					End If
					IL_81F:
					num2 = 98
					If Operators.CompareString(text, "", True) > 0 Then
						IL_832:
						num2 = 99
						text = text + " or (" + text2 + ")"
					Else
						IL_84C:
						num2 = 101
						text = "(" + text2 + ")"
					End If
					IL_862:
					num2 = 102
				End While
				IL_871:
				num2 = 103
				CType(enumerator2, IDisposable).Dispose()
				IL_881:
				num2 = 104
				Me.OOO_.00..Filter = text
				IL_891:
				GoTo IL_A87
				IL_896:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_A48:
				GoTo IL_A7C
				IL_A4A:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_A5A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A4A
			End Try
			IL_A7C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A87:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060022A8 RID: 8872 RVA: 0x000ED834 File Offset: 0x000EBA34
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.OOO_.00..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_40
				End If
				IL_27:
				num2 = 3
				Dim flag As Boolean = Me.OOO_.00..DataTable.DataServerType = DataServerTypeEnum.Oracle
				GoTo IL_59
				IL_40:
				num2 = 5
				flag = o_O_o_oOoo__.OO0O_0.0O0o0_o.(Me.OOO_.00..DataTable.frd_Connection)
				IL_59:
				num2 = 6
				If Operators.CompareString(Me.OOO_.00..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_92
				End If
				IL_79:
				num2 = 7
				Dim flag2 As Boolean = Me.OOO_.00..DataTable.DataServerType = DataServerTypeEnum.SqlServer
				GoTo IL_AC
				IL_92:
				num2 = 9
				flag2 = o_O_o_oOoo__.OOOO_OO._oo.(Me.OOO_.00..DataTable.frd_Connection)
				IL_AC:
				num2 = 10
				Me.OOO_.00. = A_0.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_C7:
				num2 = 11
				Me.OOO_.00. = False
				IL_D1:
				num2 = 12
				Me.O0o.0oo0_..Clear()
				IL_DF:
				num2 = 13
				Dim dictionary As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()
				IL_E9:
				num2 = 14
				For Each text As String In Me.OOO_.00.
					IL_103:
					num2 = 15
					If text.EndsWith(" Y", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(" YM", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(" YMD", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(" YQ", StringComparison.CurrentCultureIgnoreCase) OrElse text.EndsWith(" YW", StringComparison.CurrentCultureIgnoreCase) Then
						IL_151:
						num2 = 16
						Me.OOO_.00. = True
					End If
					IL_15B:
					num2 = 17
					Dim array As String() = text.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
					IL_173:
					num2 = 18
					If Not Me.OOO_.00..DataTable.DataCols.Contains(array(0)) Then
						IL_1D6:
						num2 = 23
						MessageBox.Show("生成目录树失败，无效列名：" + array(0), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						IL_1F5:
						num2 = 24
						result = False
						IL_C25:
						GoTo IL_F0B
					End If
					IL_191:
					num2 = 19
					Dim num3 As Integer
					If Me.OOO_.00..DataTable.DataCols(array(0)).IsDate AndAlso array.Length = 1 Then
						IL_1BB:
						num2 = 20
						dictionary.Add(num3, array(0))
					End If
					IL_1CB:
					num2 = 21
					num3 += 1
					IL_1FF:
					num2 = 25
				Next
				IL_213:
				num2 = 26
				If Not Me.OOO_.00. Then
					GoTo IL_A0E
				End If
				IL_221:
				num2 = 27
				Dim dataTable As DataTable = New DataTable()
				IL_22B:
				num2 = 28
				Dim list As List(Of String) = New List(Of String)()
				IL_235:
				num2 = 29
				Dim array2 As String() = A_0.Split(New Char() { "|"c }, StringSplitOptions.RemoveEmptyEntries)
				IL_24C:
				num2 = 30
				Dim text2 As String = "SELECT DISTINCT "
				IL_256:
				num2 = 31
				For Each text3 As String In array2
					IL_26C:
					num2 = 32
					Dim array4 As String() = text3.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
					IL_284:
					num2 = 33
					If Not Me.OOO_.00..DataTable.DataCols.Contains(array4(0)) Then
						IL_2A2:
						num2 = 34
						MessageBox.Show("打开筛选树失败，找不到列""" + array4(0) + """!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
						IL_2C6:
						num2 = 35
						result = False
						GoTo IL_C25
					End If
					IL_2D0:
					num2 = 36
					Dim text4 As String = array4(0)
					IL_2D9:
					num2 = 37
					If Operators.CompareString(text4, "", True) = 0 Then
						IL_2EB:
						num2 = 38
						MessageBox.Show("生成目录树失败，无效列名：" + array4(0), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						IL_30A:
						num2 = 39
						result = False
						GoTo IL_C25
					End If
					IL_314:
					num2 = 40
					If Me.OOO_.00..Cols(array4(0)).IsDate() Then
						IL_335:
						num2 = 41
						If array4.Length = 1 Then
							IL_33F:
							num2 = 42
							list.Add(text4)
							IL_34B:
							num2 = 43
							Me.O0o.0oo0_..Add(array4(0))
						Else
							IL_362:
							num2 = 45
							text4 = Oo00.OoOo_oo_.o_o.(array4(0), Me.OOO_.00.)
							IL_376:
							num2 = 46
							If flag Then
								IL_37D:
								num2 = 47
								list.Add("TO_CHAR(" + text4 + ",'YYYY')")
							Else
								IL_39A:
								num2 = 49
								If flag2 Then
									IL_3A1:
									num2 = 50
									list.Add("DatePart(yyyy," + text4 + ")")
								Else
									IL_3BE:
									num2 = 52
									list.Add("DatePart('yyyy'," + text4 + ")")
								End If
							End If
							IL_3D9:
							num2 = 53
							Me.O0o.0oo0_..Add(array4(0) + "_Y_")
							IL_3F5:
							num2 = 54
							If Operators.CompareString(array4(1), "YM", True) = 0 OrElse Operators.CompareString(array4(1), "YMD", True) = 0 Then
								IL_41A:
								num2 = 55
								If flag Then
									IL_421:
									num2 = 56
									list.Add("TO_CHAR(" + text4 + ",'MM')")
								Else
									IL_43E:
									num2 = 58
									If flag2 Then
										IL_445:
										num2 = 59
										list.Add("DatePart(m," + text4 + ")")
									Else
										IL_462:
										num2 = 61
										list.Add("DatePart('m'," + text4 + ")")
									End If
								End If
								IL_47D:
								num2 = 62
								Me.O0o.0oo0_..Add(array4(0) + "_M_")
							End If
							IL_499:
							num2 = 63
							If Operators.CompareString(array4(1), "YQ", True) = 0 Then
								IL_4AD:
								num2 = 64
								If flag Then
									IL_4B4:
									num2 = 65
									list.Add("TO_CHAR(" + text4 + ",'Q')")
								Else
									IL_4D1:
									num2 = 67
									If flag2 Then
										IL_4D8:
										num2 = 68
										list.Add("DatePart(q," + text4 + ")")
									Else
										IL_4F5:
										num2 = 70
										list.Add("DatePart('q'," + text4 + ")")
									End If
								End If
								IL_510:
								num2 = 71
								Me.O0o.0oo0_..Add(array4(0) + "_Q_")
							End If
							IL_52C:
							num2 = 72
							If Operators.CompareString(array4(1), "YW", True) = 0 Then
								IL_540:
								num2 = 73
								If flag Then
									IL_547:
									num2 = 74
									list.Add("TO_CHAR(" + text4 + ",'WW')")
								Else
									IL_564:
									num2 = 76
									If flag2 Then
										IL_56B:
										num2 = 77
										list.Add("DatePart(ww," + text4 + ")")
									Else
										IL_588:
										num2 = 79
										list.Add("DatePart('ww'," + text4 + ")")
									End If
								End If
								IL_5A3:
								num2 = 80
								Me.O0o.0oo0_..Add(array4(0) + "_W_")
							End If
							IL_5BF:
							num2 = 81
							If Operators.CompareString(array4(1), "YMD", True) = 0 Then
								IL_5D6:
								num2 = 82
								If flag Then
									IL_5DD:
									num2 = 83
									list.Add("TO_CHAR(" + text4 + ",'DD')")
								Else
									IL_5FA:
									num2 = 85
									If flag2 Then
										IL_601:
										num2 = 86
										list.Add("DatePart(d," + text4 + ")")
									Else
										IL_61E:
										num2 = 88
										list.Add("DatePart('d'," + text4 + ")")
									End If
								End If
								IL_639:
								num2 = 89
								Me.O0o.0oo0_..Add(array4(0) + "_D_")
							End If
						End If
					Else
						IL_657:
						num2 = 91
						list.Add(text4)
						IL_663:
						num2 = 92
						Me.O0o.0oo0_..Add(array4(0))
					End If
					IL_675:
					num2 = 93
				Next
				IL_689:
				num2 = 94
				Dim num4 As Integer = list.Count - 1
				For k As Integer = 0 To num4
					IL_69C:
					num2 = 95
					text2 += list(k)
					IL_6B1:
					num2 = 96
					If k < list.Count - 1 Then
						IL_6C1:
						num2 = 97
						text2 += ","
					End If
					IL_6D2:
					num2 = 98
				Next
				IL_6E1:
				num2 = 99
				If Operators.CompareString(Me.OOO_.00..DataTable.o._OOO0oOo0__., "", True) <= 0 Then
					GoTo IL_76C
				End If
				IL_702:
				num2 = 100
				If Not flag Then
					GoTo IL_72F
				End If
				IL_709:
				num2 = 101
				text2 = text2 + " From " + Me.OOO_.00..DataTable.o._OOO0oOo0__.
				GoTo IL_7DB
				IL_72F:
				num2 = 103
				text2 = text2 + " From [" + Me.OOO_.00..DataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }) + "]"
				GoTo IL_7DB
				IL_76C:
				num2 = 105
				If Operators.CompareString(Me.OOO_.00..DataTable.DataServer, "", True) <= 0 Then
					GoTo IL_7B5
				End If
				IL_78D:
				num2 = 106
				text2 = text2 + " From (" + Me.OOO_.00..DataTable.HttpSelect + ") As fox_Temp"
				GoTo IL_7DB
				IL_7B5:
				num2 = 108
				text2 = text2 + " From (" + Me.OOO_.00..DataTable.frd_SelectCommandString + ") As fox_Temp"
				IL_7DB:
				num2 = 109
				If Operators.CompareString(Me.OOO_.00..DataTable.LoadFilter, "", True) <= 0 Then
					GoTo IL_81D
				End If
				IL_7FC:
				num2 = 110
				text2 = text2 + " where " + Me.OOO_.00..DataTable.LoadFilter
				IL_81D:
				num2 = 111
				If Operators.CompareString(Me.OOO_.00..DataTable.DataServer, "", True) <> 0 Then
					GoTo IL_868
				End If
				IL_83D:
				num2 = 112
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text2, Me.OOO_.00..DataTable.frd_Connection)
				IL_859:
				num2 = 113
				oleDbDataAdapter.Fill(dataTable)
				GoTo IL_8DB
				IL_868:
				num2 = 115
				Dim httpClient As HttpClient = O_O0OO.OoO__.0oO0oo.()(Me.OOO_.00..DataTable.ConnectionName).oO0_0.o.()
				IL_88C:
				num2 = 116
				Dim dictionary2 As Dictionary(Of String, String) = httpClient.FormData
				Dim key As String = "Action"
				Dim num5 As Integer = 2
				dictionary2(key) = num5.ToString()
				IL_8AA:
				num2 = 117
				httpClient.FormData.Add("IgnoreSchema", "True")
				IL_8C3:
				num2 = 118
				httpClient.[Select] = text2
				IL_8CF:
				num2 = 119
				dataTable = httpClient.GetBaseDataTable()
				IL_8DB:
				num2 = 120
				If dataTable IsNot Nothing AndAlso dataTable.Columns.Count <> 0 Then
					GoTo IL_946
				End If
				IL_8F0:
				num2 = 121
				If Information.Err().Number = 0 Then
					GoTo IL_926
				End If
				IL_8FF:
				num2 = 122
				MessageBox.Show("打开筛选树失败，错误信息 :" & vbCrLf + Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				GoTo IL_93C
				IL_926:
				num2 = 124
				MessageBox.Show("无法获取生成筛选树所需数据,打开删选树失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_93C:
				num2 = 125
				result = False
				GoTo IL_C25
				IL_946:
				num2 = 126
				array2 = New String(dataTable.Columns.Count - 1 + 1 - 1) {}
				IL_960:
				num2 = 127
				num5 = dataTable.Columns.Count - 1
				For l As Integer = 0 To num5
					IL_978:
					num2 = 128
					dataTable.Columns(l).ColumnName = "A" + Conversions.ToString(l)
					IL_9A2:
					num2 = 129
					array2(l) = "A" + Conversions.ToString(l)
					IL_9BE:
					num2 = 130
				Next
				IL_9D0:
				num2 = 131
				oOO0oo_o0.O.ooooo.(Me, dataTable, "", "", "", String.Join("|", array2), False)
				IL_9FA:
				num2 = 132
				dataTable.Rows.Clear()
				GoTo IL_A4A
				IL_A0E:
				num2 = 134
				oOO0oo_o0.O.ooooo.(Me, Me.OOO_.00..DataTable.BaseTable, "", "", "", String.Join("|", Me.OOO_.00.), False)
				IL_A4A:
				num2 = 135
				If Not Me.O_.o__. Then
					GoTo IL_A70
				End If
				IL_A58:
				num2 = 136
				MyBase.Nodes.Insert(0, "显示所有行")
				IL_A70:
				num2 = 137
				If dictionary.Count <= 0 Then
					GoTo IL_C1D
				End If
				IL_A83:
				num2 = 138
				Dim treeView As Foxtable.WinForm.TreeView = New Foxtable.WinForm.TreeView(Me)
				IL_A91:
				num2 = 139
				Dim enumerator As Dictionary(Of Integer, String).KeyCollection.Enumerator = dictionary.Keys.GetEnumerator()
				Dim style As String
				While enumerator.MoveNext()
					Dim num3 As Integer = enumerator.Current
					IL_AB3:
					num2 = 140
					Dim a_ As String = dictionary(num3)
					IL_AC4:
					num2 = 141
					style = "yyyy-MM-dd"
					IL_AD1:
					num2 = 142
					Select Case Me.OOO_.00..Cols(a_).DataCol.DateTimeFormat
						Case 0
							IL_B12:
							num2 = 144
							style = "yyyy-MM-dd"
						Case 1
							IL_B3F:
							num2 = 150
							style = "HH:mm"
						Case 3
							IL_B21:
							num2 = 146
							style = "yyyy-MM-dd HH:mm"
						Case 4
							IL_B30:
							num2 = 148
							style = "yyyy-MM-dd HH:mm:ss"
					End Select
					IL_B5B:
					num2 = 154
					treeView.StopRedraw()
					IL_B68:
					num2 = 155
					Dim enumerator2 As List(Of Foxtable.WinForm.TreeNode).Enumerator = treeView.AllNodes.GetEnumerator()
					While enumerator2.MoveNext()
						Dim treeNode As Foxtable.WinForm.TreeNode = enumerator2.Current
						IL_B87:
						num2 = 156
						If treeNode.Level = num3 Then
							IL_B98:
							num2 = 157
							Dim dateTime As DateTime
							If DateTime.TryParse(treeNode.Text, dateTime) Then
								IL_BAE:
								num2 = 158
								treeNode.Text = Strings.Format(dateTime, style)
							End If
						End If
						IL_BC9:
						num2 = 159
					End While
					IL_BD8:
					num2 = 160
					CType(enumerator2, IDisposable).Dispose()
					IL_BEB:
					num2 = 161
					treeView.ResumeRedraw()
					IL_BF8:
					num2 = 162
				End While
				IL_C0A:
				num2 = 163
				CType(enumerator, IDisposable).Dispose()
				IL_C1D:
				num2 = 164
				result = True
				GoTo IL_C25
				IL_B4E:
				num2 = 152
				style = "HH:mm:ss"
				GoTo IL_B5B
				IL_C2A:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_ECC:
				GoTo IL_F00
				IL_ECE:
				num7 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_EDE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_ECE
			End Try
			IL_F00:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F0B:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060022A9 RID: 8873 RVA: 0x000EE774 File Offset: 0x000EC974
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0o.0oo0_.() Is Nothing Then
				Me.O0o.0oo0_.(New System.Windows.Forms.Button())
				Me.O0o.0oo0_.().FlatStyle = FlatStyle.Flat
				Me.O0o.0oo0_.().FlatAppearance.BorderSize = 0
				Me.O0o.0oo0_.().Text = ""
				Me.O0o.0oo0_.().Size = New Size(18, 18)
				Me.O0o.0oo0_.().Location = New Point(MyBase.Width - 30, MyBase.Height - 30)
				Me.O0o.0oo0_.().Image = a.Oo.OOO_o.().ToBitmap()
				Me.O0o.0oo0_.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
				MyBase.Controls.Add(Me.O0o.0oo0_.())
				Main.OO_O.o..O0o__0_OO.o.().SetToolTip(Me.O0o.0oo0_.(), "刷新目录树")
				If Me.O_.o__. Then
					Me.O0o.0oo0_.().Visible = False
				End If
			End If
		End Sub

		' Token: 0x060022AA RID: 8874 RVA: 0x000EE85C File Offset: 0x000ECA5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.SuspendLayout()
			If Not Me.O_.o__. Then
				Me.OOO_.00..OpenFilterTree()
			ElseIf Operators.CompareString(Me.OOO_.00., "", True) > 0 Then
				Me.O0o.0oo0_.(Me.OOO_.00.)
			End If
			MyBase.ResumeLayout()
			MyBase.Focus()
		End Sub

		' Token: 0x04000E3E RID: 3646
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04000E3F RID: 3647
		Private <<EMPTY_NAME>> As String()

		' Token: 0x04000E40 RID: 3648
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000E41 RID: 3649
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E42 RID: 3650
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Windows.Forms.Button

		' Token: 0x04000E43 RID: 3651
		Private <<EMPTY_NAME>> As List(Of System.Windows.Forms.TreeNode)

		' Token: 0x04000E44 RID: 3652
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000E45 RID: 3653
		Friend <<EMPTY_NAME>> As String
	End Class
End Namespace
