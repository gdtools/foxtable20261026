Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports Foxtable.My
Imports Foxtable.Word
Imports Foxtable.XLS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000442 RID: 1090
	Friend NotInheritable Module o0OoOOoOOo0
		' Token: 0x060047CC RID: 18380 RVA: 0x001DE898 File Offset: 0x001DCA98
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Dim a_ As Integer = 14
			o0OoOOoOOo0.o0.ooO_o__O0OO. = ""
			o0OoOOoOOo0.o0_.O_. = O00OOOo_O0_O.b("�킟캡춣얥즧�얫솭�", a_)
			o0OoOOoOOo0.o.00O_0o_. = ""
			o0OoOOoOOo0.Oo0.OooO00. = O00OOOo_O0_O.b("캛튝��춣ﾧﶩ隭ﲯ膱삵袻ﲽ늿迁釃诅诇ﻉ볋諍꫏꣑軓韕诗菙蓛꿝駟胡뻣諥髧駩헫역蟯쿱", a_)
			o0OoOOoOOo0.O0.00o00__. = ""
		End Sub

		' Token: 0x060047CD RID: 18381 RVA: 0x001DE8F4 File Offset: 0x001DCAF4
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 1
			If Operators.CompareString(o0OoOOoOOo0.o.00O_0o_., "", True) = 0 Then
				o0OoOOoOOo0.o.00O_0o_. = O00OOOo_O0_O.b("ﾐꊒ殺滛쪚쾜힞잠쎤쾪ﺬ�튰얶蚺肼", a_)
			End If
			Return o0OoOOoOOo0.o.00O_0o_.
		End Function

		' Token: 0x060047CE RID: 18382 RVA: 0x001DE934 File Offset: 0x001DCB34
		Private Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 10
			Return O00OOOo_O0_O.b("流�힛캝송햣캩솫슱슳肷�횽럁臅胇ꋉꃋ꣍ￏ鏑ꇕ闙뗛돝ꋟ냡跣若믧ꛩ駫�蟯엱룳駵췷菹ꓻꧽ㗿䌁㤃㬅", a_)
		End Function

		' Token: 0x060047CF RID: 18383 RVA: 0x001DE958 File Offset: 0x001DCB58
		Private Sub <<EMPTY_NAME>>(A_0 As OleDbConnection, A_1 As DataSet, A_2 As DataTableCollection, A_3 As UserInfo, A_4 As Assembly, A_5 As DataSet)
			Dim a_ As Integer = 1
			A_0.Open()
			Dim array As DataRow() = A_0.GetSchema(O00OOOo_O0_O.b("�璉", a_)).[Select](O00OOOo_O0_O.b("풎얐튒힔󵢘쒚즜욞骦躨ﾪﶰ銴鞶", a_))
			For i As Integer = 0 To array.Length - 1
				Dim text As String = Conversions.ToString(array(i)(O00OOOo_O0_O.b("�킐톒�튖욘햚�튞", a_)))
				If Not o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) Then
					o0OoOOoOOo0.OO0._Oo0o.(A_0, A_2, A_1, text, False, A_3, A_4, A_5, True)
				End If
			Next
			A_0.Close()
		End Sub

		' Token: 0x060047D0 RID: 18384 RVA: 0x001DE9EC File Offset: 0x001DCBEC
		Friend Sub <<EMPTY_NAME>>(A_0 As OleDbConnection, A_1 As DataTableCollection, A_2 As DataSet, A_3 As String, A_4 As Boolean, A_5 As UserInfo, A_6 As Assembly, A_7 As DataSet, Optional A_8 As Boolean = True)
			Dim a_ As Integer = 8
			Dim beforeLoadInnerTableEventArgs As BeforeLoadInnerTableEventArgs = New BeforeLoadInnerTableEventArgs(A_3, O00OOOo_O0_O.b("뚕늗몙", a_), "", A_5)
			O_O0OO.OoO_o.oO0o0O.(A_6, O00OOOo_O0_O.b("풕ﶗﲙ얟쮣장첧슫삭햯삱ힵ�횹�", a_), New Object() { beforeLoadInnerTableEventArgs }, True, O00OOOo_O0_O.b("盡", a_), True)
			If Not beforeLoadInnerTableEventArgs.Cancel OrElse Not A_8 Then
				Dim text As String
				If Operators.CompareString(beforeLoadInnerTableEventArgs.SelectString, "", True) > 0 Then
					text = beforeLoadInnerTableEventArgs.SelectString
				Else
					If Operators.CompareString(beforeLoadInnerTableEventArgs.Fields.Trim(), O00OOOo_O0_O.b("뚕늗몙", a_), True) <> 0 Then
						beforeLoadInnerTableEventArgs.Fields = ShareLibriay.ReplaceIgnoreCase(beforeLoadInnerTableEventArgs.Fields, O00OOOo_O0_O.b("즕톗ﺙ鍊풟쮡슣�", a_), "")
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("축얗", a_), "")
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("몕뒗", a_), O00OOOo_O0_O.b("몕", a_))
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Replace(O00OOOo_O0_O.b("몕뒗", a_), O00OOOo_O0_O.b("몕", a_))
						beforeLoadInnerTableEventArgs.Fields = beforeLoadInnerTableEventArgs.Fields.Trim(New Char() { ","c })
						beforeLoadInnerTableEventArgs.Fields = O00OOOo_O0_O.b("축잗펙ﮝ캟횡춣삥톧肫", a_) + beforeLoadInnerTableEventArgs.Fields
					End If
					text = String.Concat(New String() { O00OOOo_O0_O.b("얕ﶗ鍊ﶝ풟芡", a_), beforeLoadInnerTableEventArgs.Fields, O00OOOo_O0_O.b("뚕�肟說", a_), A_3, O00OOOo_O0_O.b("쮕", a_) })
					If Operators.CompareString(beforeLoadInnerTableEventArgs.Filter, "", True) > 0 Then
						text = text + O00OOOo_O0_O.b("뚕쾗鍊얟芡", a_) + beforeLoadInnerTableEventArgs.Filter
					End If
				End If
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(text, A_0)
				Dim dataTable As DataTable = New DataTable()
				If A_3.StartsWith(O00OOOo_O0_O.b("첗힙첛�", a_)) Then
					dataTable.TableName = A_3.Substring(7)
				Else
					dataTable.TableName = A_3
				End If
				If Not dataTable.TableName.StartsWith(O00OOOo_O0_O.b("쎛", a_), StringComparison.CurrentCultureIgnoreCase) AndAlso Not dataTable.TableName.StartsWith(O00OOOo_O0_O.b("즕", a_)) AndAlso Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", True) > 0 Then
					Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace(O00OOOo_O0_O.b("ꢗ", a_), dataTable.TableName))
					Application.DoEvents()
				End If
				oleDbDataAdapter.FillLoadOption = LoadOption.PreserveChanges
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
				oleDbDataAdapter.Fill(dataTable)
				dataTable.Columns(O00OOOo_O0_O.b("즕톗ﺙ鍊풟쮡슣�", a_)).AutoIncrement = True
				dataTable.Columns(O00OOOo_O0_O.b("즕톗ﺙ鍊풟쮡슣�", a_)).AutoIncrementStep = 1L
				dataTable.Columns(O00OOOo_O0_O.b("즕톗ﺙ鍊풟쮡슣�", a_)).AutoIncrementSeed = 1L
				If dataTable.Rows.Count > 0 AndAlso dataTable.Rows.Count > 0 Then
					dataTable.Columns(O00OOOo_O0_O.b("즕톗ﺙ鍊풟쮡슣�", a_)).AutoIncrementSeed = CLng((Conversions.ToInteger(dataTable.Compute(O00OOOo_O0_O.b("�聯뒛얝ﾟ삣쎥욧�얫좭즯鶳", a_), "")) + 1))
				End If
				A_2.Tables.Add(dataTable)
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
				A_1.OO0o00.0O_0o.(New DataTable(dataTable, oleDbDataAdapter, A_0, A_3, A_7))
				If A_4 Then
					New O_0(O_O0OO.o__.O.(), dataTable)
				End If
			End If
		End Sub

		' Token: 0x060047D1 RID: 18385 RVA: 0x001DEDB0 File Offset: 0x001DCFB0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim a_ As Integer = 19
			Dim flag As Boolean
			Do
				flag = False
				Try
					For Each obj As Object In Application.OpenForms
						Dim form As Form = CType(obj, Form)
						If TypeOf form Is ef Then
							flag = True
							form.Close()
							Exit For
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Loop While flag
			Application.DoEvents()
			Dim oleDbConnection As OleDbConnection = New OleDbConnection()
			Dim dataSet As DataSet = New DataSet()
			Dim dataSet2 As DataSet = New DataSet()
			Dim a_2 As Dictionary(Of String, O_0) = New Dictionary(Of String, O_0)()
			Dim dataTableCollection As DataTableCollection = New DataTableCollection()
			Dim dictionary As Dictionary(Of String, OleDbConnection) = New Dictionary(Of String, OleDbConnection)(StringComparer.OrdinalIgnoreCase)
			Dim dictionary2 As Dictionary(Of String, O0O) = New Dictionary(Of String, O0O)(StringComparer.OrdinalIgnoreCase)
			Dim dictionary3 As Dictionary(Of String, O_0oOo_OO) = New Dictionary(Of String, O_0oOo_OO)(StringComparer.OrdinalIgnoreCase)
			Dim projectProperty As ProjectProperty = New ProjectProperty()
			Dim assembly As Assembly = Nothing
			Dim userInfo As UserInfo = Nothing
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			OO_00oOO.FileSys.GetParentPath(A_0)
			Main.o_0Oo0__.oooO0.(OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ﶠ첤즦", a_))
			Dim result As Boolean
			If Not A_0.EndsWith(O00OOOo_O0_O.b("辠쪤�펪", a_), StringComparison.CurrentCultureIgnoreCase) Then
				MessageBox.Show(O00OOOo_O0_O.b("곮帢跁磻ꣴ⧚혶忆㓗䏺뙉", a_), O00OOOo_O0_O.b("燃駛", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Try
					oleDbConnection.ConnectionString = Oo00.o_._0OOo.(A_0)
					oleDbConnection.Open()
					Dim num As Double
					Dim num2 As Double
					Try
						For Each text As String In o_O_o_oOoo__.Oo_0.OOo0oO0.
							If Operators.CompareString(text, ooO0__OO.O00.O__o.(), True) <> 0 Then
								Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(O00OOOo_O0_O.b("욢즤슦쪨�趬薮醰잴�풸鮺", a_) + text + O00OOOo_O0_O.b("ﲠ", a_), oleDbConnection)
								Dim dataTable As DataTable = New DataTable()
								dataTable.TableName = text
								dataTable.ExtendedProperties.Add(O00OOOo_O0_O.b("슢톤욦쾪첬�얰횲잴", a_), oleDbDataAdapter)
								dataSet2.Tables.Add(dataTable)
								oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
								oleDbDataAdapter.Fill(dataTable)
								o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
								If Operators.CompareString(text, ooO0__OO.o.00_0o0__OoO.(), True) = 0 Then
									dataTable.Columns(O00OOOo_O0_O.b("좠잢", a_)).AutoIncrement = True
									dataTable.Columns(O00OOOo_O0_O.b("좠잢", a_)).AutoIncrementStep = 1L
									If dataTable.Rows.Count > 0 Then
										dataTable.Columns(O00OOOo_O0_O.b("좠잢", a_)).AutoIncrementSeed = Conversions.ToLong(dataTable.Compute(O00OOOo_O0_O.b("슢�辦삨쾪蒬", a_), "")) + 1L
									End If
								End If
								If Operators.CompareString(text, ooO0__OO.OOo0._00O_o00.(), True) = 0 Then
									If Operators.CompareString(O_O0OO.o0OoO00OO.00O., A_0, True) = 0 OrElse o0OoOOoOOo0.O_00o0.O0OO_0. Then
										o0OoOOoOOo0.O0OoO_0o.O.(dataSet2)
										o0OoOOoOOo0.O_00o0.O0OO_0. = False
									End If
									Dim dataRow As DataRow
									If Control.ModifierKeys <> Keys.Control Then
										dataRow = dataTable.Rows.Find(New Object() { O00OOOo_O0_O.b("킢삤햦", a_), o0_O.o.0_O_O. })
										If dataRow IsNot Nothing AndAlso Operators.CompareString(dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)).ToString(), O00OOOo_O0_O.b("邠", a_), True) = 0 Then
											flag2 = True
										End If
									End If
									dataRow = dataTable.Rows.Find(New Object() { O00OOOo_O0_O.b("쪢즤슦ﾨ캪��𼂲�", a_), o0_O.o.O_O_OOo. })
									If dataRow IsNot Nothing Then
										num = Conversions.ToDouble(dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
										If Conversions.ToDouble(dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_))) > 80.0 Then
											MessageBox.Show(o0OoOOoOOo0.oo00o.0OoO.(), O00OOOo_O0_O.b("燃駛", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
											Return False
										End If
									End If
									If dataRow IsNot Nothing Then
										num2 = Conversions.ToDouble(dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
										If num2 < 55.0 Then
											OO_00oOO.FileSys.CopyFile(A_0, A_0 + O00OOOo_O0_O.b("辠첢즤쎦", a_), True)
											o0OoOOoOOo0.O_0_Oo_00.O.(A_0)
											dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = 80.0
											Oo00.O0Oo_O.0O_0O.(dataRow)
											oleDbConnection.Close()
											oleDbConnection.Open()
										End If
									End If
									If dataRow IsNot Nothing AndAlso num2 < 6.0 Then
										Dim oleDbCommand As OleDbCommand = New OleDbCommand()
										oleDbCommand.Connection = oleDbConnection
										oleDbCommand.CommandText = O00OOOo_O0_O.b("쾢톤슦�讪怜캮펰�킴鞶", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("ﲠ莢쎦춨讪삮�욲��馸춼쮾꧀黂鏆곈돊만", a_)
										oleDbCommand.ExecuteNonQuery()
										oleDbCommand.CommandText = O00OOOo_O0_O.b("펢솤욦�캪趬", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("ﲠ莢슦�讪�얰�鞶蒸鮺ꃀꇂ꧄ꋆ铈", a_)
										oleDbCommand.ExecuteNonQuery()
										oleDbCommand.CommandText = O00OOOo_O0_O.b("쾢톤슦�讪怜캮펰�킴鞶", a_) + ooO0__OO.oo._O.() + O00OOOo_O0_O.b("ﲠ莢쎦춨讪삮�욲��馸캼춾뗀黂軆蟈鿊裌裎铐臒", a_)
										oleDbCommand.ExecuteNonQuery()
										dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = 80.0
										Oo00.O0Oo_O.0O_0O.(dataRow)
									End If
									o0OoOOoOOo0.oOOo_O._o0. = False
									If dataRow IsNot Nothing AndAlso num2 < 13.0 Then
										o0OoOOoOOo0.oOOo_O._o0. = True
										dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = 80.0
										Oo00.O0Oo_O.0O_0O.(dataRow)
									End If
									Dim text2 As String = OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ﶠ첤즦", a_) + o0OoOOoOOo0.oo00o.0OoO.(A_0) + O00OOOo_O0_O.b("辠키얦얨슪캬膮햰��", a_)
									dataRow = dataTable.Rows.Find(New Object() { O00OOOo_O0_O.b("톢쪤춦첨좪�ﾮ쎰�어튶쮸쾺쒼", a_), o0_O.O_o000_O.0. })
									If(dataRow Is Nothing AndAlso Operators.CompareString(A_0, O_O0OO.o0OoO00OO.00O., True) <> 0) And Not o0OoOOoOOo0.oO.0_0oOOo. Then
										Return False
									End If
									If dataRow IsNot Nothing AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) Then
										Dim text3 As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
										If Not text3.StartsWith(O00OOOo_O0_O.b("�", a_)) Then
											num = 9.0
										End If
										text3 = O_O0OO.OoO_00._.(text3, dataSet2)
										o_O_o_oOoo__.OOOO_OO._oo.(projectProperty, text3, vbVerticalTab)
										If O_O0OO.o00.0.(projectProperty) Then
											flag2 = False
										End If
										If projectProperty.ProtectBins Then
											Dim a_3 As String = OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ﶠ첤즦", a_)
											If Not o0OoOOoOOo0.a(dataTable, a_3) Then
												Main.OO_O.o. = 3
												MessageBox.Show(o0OoOOoOOo0.a(), O00OOOo_O0_O.b("燃駛", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
												Return False
											End If
										End If
										o0OoOOoOOo0.o0.ooO_o__O0OO. = projectProperty.LoadMessage
										If Not OO_00oOO.FileSys.FileExists(text2) OrElse Operators.CompareString(projectProperty.AsmAPICrcString, O00.CRCCheckFile(text2), True) <> 0 OrElse num2 < 33.0 Then
											Dim a_4 As String = o0_.o_000Oo0O_.00o.(dataTable, "")
											If OO_00oOO.FileSys.FileExists(text2) Then
												OO_00oOO.FileSys.DeleteFile(text2)
											End If
											o0_.Oo_0.OOo0oO0.(a_4, text2, dataTable, True, "", True)
											projectProperty.AsmAPICrcString = O00.CRCCheckFile(text2)
											projectProperty.o0Oo.Oo_0oO0o. = True
										End If
										Dim text4 As String = OO_00oOO.FileSys.GetParentPath(A_0) + O00OOOo_O0_O.b("ﶠ첤즦", a_) + o0OoOOoOOo0.oo00o.0OoO.(A_0) + O00OOOo_O0_O.b("辠힤좦쎨캪캬�龰ힲ��", a_)
										If OO_00oOO.FileSys.FileExists(text4) Then
											assembly = Assembly.Load(File.ReadAllBytes(text4))
										End If
										o0OoOOoOOo0.O.0_0ooo0O. = A_0
										o0OoOOoOOo0.o___O0.O00. = O_O0OO.o0_OO.000.(dataSet2)
										Dim beforeOpenProjectEventArgs As BeforeOpenProjectEventArgs = New BeforeOpenProjectEventArgs(A_0)
										If Not O_O0OO.o00.0.(projectProperty) Then
											O_O0OO.OoO_o.oO0o0O.(assembly, O00OOOo_O0_O.b("욢쎤좦�캪�풰�얶횸톺𿂾뗀", a_), New Object() { beforeOpenProjectEventArgs }, True, O00OOOo_O0_O.b("�䷔", a_), True)
										End If
										If beforeOpenProjectEventArgs.Cancel Then
											o0OoOOoOOo0.O.0_0ooo0O. = ""
											o0OoOOoOOo0.o___O0.O00. = ""
											Return False
										End If
										OO_00oOO.MyTimers.Clear()
										For Each dataRow2 As DataRow In dataTable.[Select](O00OOOo_O0_O.b("猪�힦첨趬銮醰", a_) + Conversions.ToString(3))
											Dim timerProperty As TimerProperty = New TimerProperty()
											Dim timer As Timer = New Timer()
											If Not dataRow2.IsNull(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) Then
												o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow2(O00OOOo_O0_O.b("첢쮤솦삨첪", a_))), O00OOOo_O0_O.b("쪢좤슦�", a_), O_O0OO.o0_OO.000.(dataSet2)), vbVerticalTab)
											End If
											timer.Name = Conversions.ToString(dataRow2(O00OOOo_O0_O.b("슢좤슦", a_)))
											Dim a_5 As String = O00OOOo_O0_O.b("쪢좤슦�", a_) + timer.Name
											timer.Tag = a_5
											timer.Interval = timerProperty.Interval
											timer.Enabled = timerProperty.Enabled
											timer.CanPause = timerProperty.CanPause
											OO_00oOO.MyTimers.Add(Conversions.ToString(dataRow2(O00OOOo_O0_O.b("슢좤슦", a_))), timer)
										Next
										O_O0OO.O_OO.OO. = True
									End If
								End If
								If Operators.CompareString(text, ooO0__OO.o.00_0o0__OoO.(), True) = 0 AndAlso num2 < 55.0 Then
									Dim dataTable2 As DataTable = dataSet2.Tables(ooO0__OO.o.00_0o0__OoO.())
									Dim hashSet As HashSet(Of String) = New HashSet(Of String)()
									Dim num3 As Integer = 0
									For Each dataRow3 As DataRow In dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()).[Select](O00OOOo_O0_O.b("猪�힦첨趬銮醰", a_) + Conversions.ToString(9), "", DataViewRowState.CurrentRows)
										Dim dataRow4 As DataRow = dataTable2.NewRow()
										Dim array3 As String() = dataRow3(O00OOOo_O0_O.b("슢좤슦", a_)).ToString().Split(New Char() { vbTab })
										If array3.Length = 2 Then
											If Operators.CompareString(array3(0), "", True) > 0 Then
												dataRow4(O00OOOo_O0_O.b("슢톤쾦", a_)) = array3(0)
											End If
											dataRow4(O00OOOo_O0_O.b("슢좤슦", a_)) = array3(1)
										Else
											dataRow4(O00OOOo_O0_O.b("슢좤슦", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("슢좤슦", a_)))
										End If
										dataRow4(O00OOOo_O0_O.b("�햤슦", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("�햤슦", a_)))
										dataRow4(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = RuntimeHelpers.GetObjectValue(dataRow3(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
										dataRow4(O00OOOo_O0_O.b("튠톢톤", a_)) = num3
										num3 += 1
										dataRow3.Delete()
										dataTable2.Rows.Add(dataRow4)
										If array3.Length = 2 AndAlso Not hashSet.Contains(array3(0)) Then
											hashSet.Add(array3(0))
											dataRow4 = dataTable2.NewRow()
											dataRow4(O00OOOo_O0_O.b("슢좤슦", a_)) = array3(0)
											dataRow4(O00OOOo_O0_O.b("�햤슦", a_)) = o0_O.O.00oOo0o.
											dataRow4(O00OOOo_O0_O.b("튠톢톤", a_)) = num3
											num3 += 1
											dataTable2.Rows.Add(dataRow4)
										End If
									Next
									Oo00.o0_o._O_.(dataTable2, True)
									Oo00.o0_o._O_.(dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()), True)
								End If
								Operators.CompareString(text, ooO0__OO.O0O.0o0.(), True)
								If Operators.CompareString(text, ooO0__OO.O_O00.0_.(), True) = 0 Then
									If(dataTable.Rows.Count > 0 OrElse projectProperty.HasUsers OrElse flag2) AndAlso dataTable.Rows.Count = 0 Then
										Dim dataRow5 As DataRow = dataTable.NewRow()
										Dim userProperty As UserProperty = New UserProperty()
										userProperty.Type = 0
										userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.(ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8)))
										dataRow5(O00OOOo_O0_O.b("슢좤슦", a_)) = O00OOOo_O0_O.b("ꇿ狱ꀤ", a_)
										dataRow5(O00OOOo_O0_O.b("�햤슦", a_)) = 0
										dataRow5(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, False, vbVerticalTab, False)
										dataTable.Rows.Add(dataRow5)
										dataRow5 = dataTable.NewRow()
										userProperty.PassWord = O00.MD5Encrypt(O00.ooo000o_0.00o0.(ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8), ShareLibriay.GetRandString(8)))
										userProperty.Type = 1
										dataRow5(O00OOOo_O0_O.b("슢좤슦", a_)) = O00OOOo_O0_O.b("Ûꗖﷰ", a_)
										dataRow5(O00OOOo_O0_O.b("�햤슦", a_)) = 1
										dataRow5(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = o_O_o_oOoo__.OOOO_OO._oo.(userProperty, False, vbVerticalTab, False)
										dataTable.Rows.Add(dataRow5)
									End If
									If O_O0OO.o00.0.(projectProperty) Then
										flag2 = False
									End If
									If flag2 Then
										o0OoOOoOOo0.OOOOO.o000.(dataSet2, dictionary, dictionary2, dictionary3, assembly, A_0, userInfo, projectProperty)
									End If
									Dim dataTable3 As DataTable
									If flag2 AndAlso Not O_O0OO.o00.0.(projectProperty) Then
										Dim text5 As String = ""
										Dim text6 As String = ""
										Dim dataRow6 As DataRow = dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("킢삤햦", a_), o0_O.Oo0_.o0. })
										If dataRow6 IsNot Nothing Then
											text5 = dataRow6(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)).ToString()
										End If
										dataRow6 = dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("킢삤햦", a_), o0_O.OO_O.O0ooO0O. })
										If dataRow6 IsNot Nothing Then
											text6 = dataRow6(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)).ToString()
										End If
										If Operators.CompareString(text5, "", True) > 0 AndAlso Operators.CompareString(text6, "", True) > 0 AndAlso (dictionary.ContainsKey(text5) OrElse dictionary2.ContainsKey(text5)) Then
											dataTable3 = New DataTable()
											If dictionary.ContainsKey(text5) Then
												Dim oleDbDataAdapter2 As OleDbDataAdapter
												If o_O_o_oOoo__.OO0O_0.0O0o0_o.(dictionary(text5)) Then
													oleDbDataAdapter2 = New OleDbDataAdapter(O00OOOo_O0_O.b("욢즤슦쪨�趬薮醰잴�풸鮺", a_) + text6, dictionary(text5))
												Else
													If Not text6.StartsWith(O00OOOo_O0_O.b("猪", a_)) Then
														text6 = O00OOOo_O0_O.b("猪", a_) + text6 + O00OOOo_O0_O.b("ﲠ", a_)
													End If
													oleDbDataAdapter2 = New OleDbDataAdapter(O00OOOo_O0_O.b("욢즤슦쪨�趬薮醰잴�풸鮺", a_) + text6, dictionary(text5))
												End If
												oleDbDataAdapter2.Fill(dataTable3)
												o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter2)
												dataTable3.ExtendedProperties.Add(O00OOOo_O0_O.b("슢톤욦쾪첬�얰횲잴", a_), oleDbDataAdapter2)
											Else
												Dim o0O As O0O = dictionary2(text5)
												Dim httpClient As HttpClient = o0O.oO0_0.o.()
												httpClient.FormData(O00OOOo_O0_O.b("삢톤캦욨얪", a_)) = 1.ToString()
												If o0O.OO.OoO0. = DataServerTypeEnum.Oracle Then
													httpClient.[Select] = O00OOOo_O0_O.b("욢즤슦쪨�趬薮醰잴�풸鮺", a_) + text6
												Else
													If Not text6.StartsWith(O00OOOo_O0_O.b("猪", a_)) Then
														text6 = O00OOOo_O0_O.b("猪", a_) + text6 + O00OOOo_O0_O.b("ﲠ", a_)
													End If
													httpClient.[Select] = O00OOOo_O0_O.b("욢즤슦쪨�趬薮醰잴�풸鮺", a_) + text6
												End If
												dataTable3 = httpClient.GetBaseDataTable()
												Dim dataTable4 As DataTable = New DataTable(dataTable3, Nothing, Nothing, text6, Nothing)
												dataTable4.ConnectionName = text5
												dataTable4.DataServer = httpClient.Oo_0oO0Oo0_.O_.
												dataTable4.UpdateServer = httpClient.Oo_0oO0Oo0_.O_.
												dataTable4.UpdateColumns = CType(dataTable3.ExtendedProperties(O00OOOo_O0_O.b("펢솤욦�캪삮�욲��쪸", a_)), List(Of String))
												dataTable3.ExtendedProperties.Clear()
												dataTable3.ExtendedProperties.Add(O00OOOo_O0_O.b("욢잤�쾪첬�풰솲", a_), dataTable4)
											End If
											For Each dataRow7 As DataRow In dataTable.[Select](O00OOOo_O0_O.b("猪�힦첨趬銮醰", a_) + Conversions.ToString(0) + O00OOOo_O0_O.b("膠힤螦ﾪ풬�풰閴誶馸", a_) + Conversions.ToString(1))
												Dim dataRow8 As DataRow = dataTable3.NewRow()
												dataRow8(O00OOOo_O0_O.b("슢좤슦", a_)) = RuntimeHelpers.GetObjectValue(dataRow7(O00OOOo_O0_O.b("슢좤슦", a_)))
												dataRow8(O00OOOo_O0_O.b("�햤슦", a_)) = RuntimeHelpers.GetObjectValue(dataRow7(O00OOOo_O0_O.b("�햤슦", a_)))
												dataRow8(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = RuntimeHelpers.GetObjectValue(dataRow7(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
												dataTable3.Rows.Add(dataRow8)
											Next
											dataTable3.AcceptChanges()
										Else
											dataTable3 = dataTable
										End If
									Else
										dataTable3 = dataTable
									End If
									If dataTable3.Rows.Count > 0 Then
										If Not O_O0OO.o00.0.(projectProperty) AndAlso Not flag2 Then
											Try
												For Each obj2 As Object In dataTable3.Rows
													Dim dataRow9 As DataRow = CType(obj2, DataRow)
													If Conversions.ToInteger(dataRow9(O00OOOo_O0_O.b("�햤슦", a_))) = 4 Then
														userInfo = New UserInfo()
														userInfo.Type = 2
														userInfo.[Default] = True
														userInfo.Name = dataRow9(O00OOOo_O0_O.b("슢좤슦", a_)).ToString()
														If Not dataRow9.IsNull(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) Then
															Dim userProperty2 As UserProperty = New UserProperty()
															o_O_o_oOoo__.OOOO_OO._oo.(userProperty2, dataRow9(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)).ToString(), vbVerticalTab)
															userInfo.Group = userProperty2.Group
															userInfo.Roles = userProperty2.Role
															userInfo.Password = userProperty2.PassWord
															userInfo.Tag = userProperty2.Tag
														End If
													End If
												Next
											Finally
												Dim enumerator3 As IEnumerator
												If TypeOf enumerator3 Is IDisposable Then
													TryCast(enumerator3, IDisposable).Dispose()
												End If
											End Try
										End If
										If userInfo Is Nothing Then
											Dim o_u3002_u3002_u3002_u3002_u3002_u3000_u As O\u3002\u3002\u3002\u3002\u3002\u3000\u3002 = New O\u3002\u3002\u3002\u3002\u3002\u3000\u3002(dataTable3, dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()), OO_00oOO.FileSys.GetParentPath(A_0), projectProperty.OoOO.O0OoOoOO0.)
											If o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Tag Is Nothing Then
												o_u3002_u3002_u3002_u3002_u3002_u3000_u.O.O0OOoOO.().Text = projectProperty.LogTip
											End If
											If o_u3002_u3002_u3002_u3002_u3002_u3000_u.ShowDialog() <> DialogResult.OK Then
												o0OoOOoOOo0.O.0_0ooo0O. = ""
												o0OoOOoOOo0.o___O0.O00. = ""
												Return False
											End If
											userInfo = o_u3002_u3002_u3002_u3002_u3002_u3000_u.OooO.00o.
										End If
									Else
										userInfo = New UserInfo()
										userInfo.Type = 0
										userInfo.Name = O00OOOo_O0_O.b("ꇿ狱ꀤ", a_)
									End If
									If userInfo.Type Is Nothing AndAlso O_O0OO.o00.0.(projectProperty) Then
										assembly = o0_.Oo_0.OOo0oO0.("", "", dataSet2.Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
									End If
								End If
							End If
						Next
					Finally
						Dim enumerator2 As List(Of String).Enumerator
						CType(enumerator2, IDisposable).Dispose()
					End Try
					dataSet2.Tables(ooO0__OO.oo._O.()).Columns.Add(O00OOOo_O0_O.b("욢즤슦�캪", a_), GetType(Boolean))
					dataSet2.Relations.Add(O00OOOo_O0_O.b("횢톤슦�첬�킰�슶쮸��", a_), dataSet2.Tables(ooO0__OO.o0O._ooo_O_.()).Columns(O00OOOo_O0_O.b("슢좤슦", a_)), dataSet2.Tables(ooO0__OO.O0_.OOo0OO.()).Columns(O00OOOo_O0_O.b("슢톤욦直쒪𻆮튰횲", a_)))
					dataSet2.Relations.Add(O00OOOo_O0_O.b("쪢잤얦욨얪", a_), dataSet2.Tables(ooO0__OO.oo._o.()).Columns(O00OOOo_O0_O.b("욢�", a_)), dataSet2.Tables(ooO0__OO.oo._o.()).Columns(O00OOOo_O0_O.b("슢힤슦잨�쪮좰", a_)))
					dataSet2.Relations.Add(O00OOOo_O0_O.b("첢좤힦욨얪좬솮얰", a_), dataSet2.Tables(ooO0__OO.oo._O.()).Columns(O00OOOo_O0_O.b("욢�", a_)), dataSet2.Tables(ooO0__OO.oo._O.()).Columns(O00OOOo_O0_O.b("슢힤슦잨�쪮좰", a_)))
					oleDbConnection.Close()
					If Not flag2 Then
						o0OoOOoOOo0.OOOOO.o000.(dataSet2, dictionary, dictionary2, dictionary3, assembly, A_0, userInfo, projectProperty)
					End If
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, dataSet, dataTableCollection, userInfo, assembly, O_O0OO.OoO.0OO__0ooo.())
					o0OoOOoOOo0.OOOOO.o000.(dictionary, dictionary2, dictionary3, dataSet2, dataSet, dataTableCollection, userInfo, assembly, oleDbConnection, projectProperty)
					o0OoOOoOOo0.o00__oo.O0Oo0o.(dataSet2, dataSet, dataTableCollection)
					o0OoOOoOOo0.OO0._Oo0o.(dataSet2, dataSet)
					o0OoOOoOOo0.OOoOO_o00_.o.(dataSet2, dataTableCollection, dataSet)
					If userInfo Is Nothing OrElse userInfo.Type IsNot Nothing OrElse Not O_O0OO.o00.0.(projectProperty) Then
						o0OoOOoOOo0.OOOOO.o000.(dataSet2, dataTableCollection, dataSet)
					End If
					o0OoOOoOOo0.O_0_Oo_00.O.(a_2, dataSet)
					o0OoOOoOOo0.O.0_0ooo0O. = ""
					o0OoOOoOOo0.o___O0.O00. = ""
					Try
						Main.OO_O.o..o._oOO0..O0oo_0_.__0__.()
						If O_O0OO.O._o_.() IsNot Nothing Then
							O_O0OO.O._o_.().Clear()
						End If
						If O_O0OO.OoO__.0oO0oo.() IsNot Nothing Then
							O_O0OO.OoO__.0oO0oo.().Clear()
						End If
						OO_00oOO.User = userInfo
						O_O0OO.O_O.OOO_o.(oleDbConnection)
						O_O0OO.O_O.OOO_o.(dataSet2)
						O_O0OO.oO.__0O0oooo.(dataSet)
						O_O0OO.O_O.OOO_o.(dictionary)
						O_O0OO.O_O.OOO_o.(dictionary2)
						O_O0OO.OoO_o.oO0o0O.(dictionary3)
						O_O0OO.o.00O_O.().Clear()
						If assembly IsNot Nothing Then
							O_O0OO.oo0_o_.o. = assembly
						Else
							O_O0OO.oo0_o_.o. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
						End If
						O_O0OO.O0_00o.o0__o. = projectProperty
						O_O0OO.O0_00o.o0__o..O_o0__O.o.()
						If num2 > 0.0 AndAlso num2 < 33.0 Then
							o0_.ooO.OOO_O_OO_0.(dataSet2.Tables(ooO0__OO.O0O.0o0.()))
							flag3 = True
						End If
						If flag3 Then
							O_O0OO.O0_00o.o0__o..O_O_.o.(True, True)
						End If
						O_O0OO.OOo_o.0o. = Foxtable.My.c.OOOOO.o.().FileSystem.GetParentPath(A_0) + O00OOOo_O0_O.b("ﶠ좤욦캨캪�", a_)
						OO_00oOO.DataTables = dataTableCollection
						OO_00oOO.ProjectFile = A_0
						O_O0OO.O_O.OOO_o.(a_2)
						o0OoOOoOOo0.OO_.o0O_o.()
						OO_00oOO.Tables = New TableCollection(O_O0OO.o__.O.())
						OO_00oOO.Forms.o_.O__O00OOO.()
						XLSFunctions.Reports.o0_.O_o.()
						WordFunctions.Reports.Load()
						OO_00oOO.Reports.o.0OoO.()
						Main.OO_O.o..o._oOO0. = False
						If O_O0OO.O0_00o.o0__o..o0Oo.Oo_0oO0o. Then
							O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
						End If
						If num2 > 0.0 AndAlso num2 < 33.0 Then
							o0_.o_000Oo0O_.00o.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._O.()))
							o0_.o_000Oo0O_.00o.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.oo._o.()))
						End If
					Catch a_6 As Exception
						ooO.oOo0Oo.o.(a_6, "")
						Application.[Exit]()
					End Try
					If num > 0.0 AndAlso num < 10.0 Then
						O_O0OO.O0_00o.o0__o..O_O_.o.(False, True)
						Dim dataTable5 As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O_O00.0_.())
						Dim dataRow10 As DataRow = Nothing
						If num = 9.0 Then
							O_O0OO.O0_00o.o0__o..O_O_.o.(True, False)
						End If
						Dim dataRow11 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("킢삤햦�슬�솰삲", a_), o0_O.ooooO.oOo0O__O. })
						If dataRow11 IsNot Nothing Then
							Try
								For Each obj3 As Object In dataTable5.Rows
									Dim dataRow12 As DataRow = CType(obj3, DataRow)
									If Conversions.ToInteger(dataRow12(O00OOOo_O0_O.b("�햤슦", a_))) = 5 Then
										dataRow10 = dataRow12
										Exit For
									End If
								Next
							Finally
								Dim enumerator4 As IEnumerator
								If TypeOf enumerator4 Is IDisposable Then
									TryCast(enumerator4, IDisposable).Dispose()
								End If
							End Try
							If dataRow10 Is Nothing Then
								dataRow10 = dataTable5.NewRow()
								dataRow10(O00OOOo_O0_O.b("슢좤슦", a_)) = [Enum].GetName(GetType(UserTypeEnum), 5)
								dataRow10(O00OOOo_O0_O.b("�햤슦", a_)) = 5
								dataTable5.Rows.Add(dataRow10)
							End If
							dataRow10(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = RuntimeHelpers.GetObjectValue(dataRow11(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
							dataRow11.Delete()
							Oo00.o0_o._O_.(dataTable5, True)
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
						End If
						dataRow11 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("킢삤햦ﮨ쒪솬쪮슰", a_), o0_O.ooooO.oOo0O__O. })
						dataRow10 = Nothing
						If dataRow11 IsNot Nothing Then
							Try
								For Each obj4 As Object In dataTable5.Rows
									Dim dataRow13 As DataRow = CType(obj4, DataRow)
									If Conversions.ToInteger(dataRow13(O00OOOo_O0_O.b("�햤슦", a_))) = 6 Then
										dataRow10 = dataRow13
										Exit For
									End If
								Next
							Finally
								Dim enumerator5 As IEnumerator
								If TypeOf enumerator5 Is IDisposable Then
									TryCast(enumerator5, IDisposable).Dispose()
								End If
							End Try
							If dataRow10 Is Nothing Then
								dataRow10 = dataTable5.NewRow()
								dataRow10(O00OOOo_O0_O.b("슢좤슦", a_)) = [Enum].GetName(GetType(UserTypeEnum), 6)
								dataRow10(O00OOOo_O0_O.b("�햤슦", a_)) = 6
								dataTable5.Rows.Add(dataRow10)
							End If
							dataRow10(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = RuntimeHelpers.GetObjectValue(dataRow11(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
							dataRow11.Delete()
							Oo00.o0_o._O_.(dataTable5, True)
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
						End If
						dataRow11 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("힢톤욦�좪얬�햲�", a_), o0_O.o0OOo_O0_._O. })
						dataRow10 = Nothing
						If dataRow11 IsNot Nothing Then
							Try
								For Each obj5 As Object In dataTable5.Rows
									Dim dataRow14 As DataRow = CType(obj5, DataRow)
									If Conversions.ToInteger(dataRow14(O00OOOo_O0_O.b("�햤슦", a_))) = 7 Then
										dataRow10 = dataRow14
										Exit For
									End If
								Next
							Finally
								Dim enumerator6 As IEnumerator
								If TypeOf enumerator6 Is IDisposable Then
									TryCast(enumerator6, IDisposable).Dispose()
								End If
							End Try
							If dataRow10 Is Nothing Then
								dataRow10 = dataTable5.NewRow()
								dataRow10(O00OOOo_O0_O.b("슢좤슦", a_)) = [Enum].GetName(GetType(UserTypeEnum), 7)
								dataRow10(O00OOOo_O0_O.b("�햤슦", a_)) = 7
								dataTable5.Rows.Add(dataRow10)
							End If
							dataRow10(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)) = RuntimeHelpers.GetObjectValue(dataRow11(O00OOOo_O0_O.b("첢쮤솦삨첪", a_)))
							dataRow11.Delete()
							Oo00.o0_o._O_.(dataTable5, True)
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
						End If
					End If
					If O_O0OO.OoO.0OO__0ooo.().HasChanges() Then
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
					End If
					result = True
				Catch a_7 As Exception
					ooO.oOo0Oo.o.(a_7, "")
					result = False
				Finally
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
					End If
				End Try
			End If
			Return result
		End Function

		' Token: 0x060047D2 RID: 18386 RVA: 0x001E0BCC File Offset: 0x001DEDCC
		Private Sub <<EMPTY_NAME>>()
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					dataTable.o0O.ooO00.()
					Try
						For Each dataCol As DataCol In dataTable.DataCols
							dataCol.o_.Oo00_O_00_.()
						Next
					Finally
						Dim enumerator2 As IEnumerator(Of DataCol)
						If enumerator2 IsNot Nothing Then
							enumerator2.Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047D3 RID: 18387 RVA: 0x001E0C50 File Offset: 0x001DEE50
		Private Sub <<EMPTY_NAME>>(A_0 As DataSet, A_1 As Dictionary(Of String, OleDbConnection), A_2 As Dictionary(Of String, O0O), A_3 As Dictionary(Of String, O_0oOo_OO), A_4 As Assembly, A_5 As String, A_6 As UserInfo, A_7 As ProjectProperty)
			Try
				For Each obj As Object In A_0.Tables(ooO0__OO.o0O._ooo_O_.()).Rows
					Dim a_ As DataRow = CType(obj, DataRow)
					o0OoOOoOOo0.OOOOO.o000.(A_1, A_2, A_3, A_0, a_, A_4, A_5, A_6, A_7)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047D4 RID: 18388 RVA: 0x001E0CC8 File Offset: 0x001DEEC8
		<MethodImpl(MethodImplOptions.NoInlining)>
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, OleDbConnection), A_1 As Dictionary(Of String, O0O), A_2 As Dictionary(Of String, O_0oOo_OO), A_3 As DataSet, A_4 As DataRow, A_5 As Assembly, A_6 As String, A_7 As UserInfo, A_8 As ProjectProperty)
			Dim a_ As Integer = 8
			Dim o_0oOo_OO As O_0oOo_OO = New O_0oOo_OO()
			Dim text As String = O00.oO_.0o_oo_0O_.(Conversions.ToString(A_4(O00OOOo_O0_O.b("햕ﮝ쎟횡춣즥욧囹𺲭񻲱펳", a_))), O_O0OO.o0_OO.000.(A_3), ooO0__OO.o0O._ooo_O_.())
			Dim beforeConnectOuterDataSourceEventArgs As BeforeConnectOuterDataSourceEventArgs = New BeforeConnectOuterDataSourceEventArgs(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), text, A_6, A_7)
			O_O0OO.OoO_o.oO0o0O.(A_5, O00OOOo_O0_O.b("풕ﶗﲙ얟쮣좥욧쾩쾫�ﾯ잱삳펵쪷ﺹ�쪽ꆿ釁ꯃ독뫇꧉꧋", a_), New Object() { beforeConnectOuterDataSourceEventArgs }, True, O00OOOo_O0_O.b("盡", a_), True)
			text = beforeConnectOuterDataSourceEventArgs.ConnectionString
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			If Not text.StartsWith(O00OOOo_O0_O.b("ﺕ꒝辟趡", a_), StringComparison.OrdinalIgnoreCase) AndAlso Not text.StartsWith(O00OOOo_O0_O.b("ﺕ骟趡讣", a_), StringComparison.OrdinalIgnoreCase) Then
				oleDbConnection = New OleDbConnection(text)
			Else
				o0O = New O0O(text)
			End If
			Try
				If oleDbConnection IsNot Nothing Then
					oleDbConnection.Open()
					o_0oOo_OO.oo.00O0__o.(True)
					oleDbConnection.Close()
					A_0.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), oleDbConnection)
					A_2.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), o_0oOo_OO)
				ElseIf o0O.OO._o_OO.() Then
					A_1.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), o0O)
				End If
			Catch ex As Exception
				Main.OO_O.o. = 4
				MessageBox.Show(O00OOOo_O0_O.b("跇拉賀琋䀒׼股", a_) + Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))) + O00OOOo_O0_O.b("뒕꧎뼔遤椖姝טꃑ볋곴翾딯빎礢ېؼ퓆쳞탞㸫枢鎘憎쬶", a_), O00OOOo_O0_O.b("輀眜", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			If((oleDbConnection IsNot Nothing AndAlso Not o_0oOo_OO.oo.00O0__o.()) OrElse (o0O IsNot Nothing AndAlso Not o0O.OO.OoO0.)) AndAlso A_7 IsNot Nothing Then
				If A_7.Type Is Nothing OrElse (A_7.Type = 1 And A_8.AllowEditConnection) Then
					Dim visible As Boolean = Main.ProcessForm.Visible
					Dim o_u3002_u3000_u As O\u3002\u3000\u3000 = New O\u3002\u3000\u3000()
					o_u3002_u3000_u.OO._000_O0o_.().Visible = True
					o_u3002_u3000_u.OO._000_O0o_.().Text = text
					Main.ProcessForm.Hide()
					Main.OO_O.o. = 4
					If o_u3002_u3000_u.ShowDialog() = DialogResult.OK Then
						text = o_u3002_u3000_u.OO._000_O0o_.().Text.Trim()
						If Not text.StartsWith(O00OOOo_O0_O.b("ﺕ꒝辟趡", a_), StringComparison.OrdinalIgnoreCase) AndAlso Not text.StartsWith(O00OOOo_O0_O.b("ﺕ骟趡讣", a_), StringComparison.OrdinalIgnoreCase) Then
							If oleDbConnection Is Nothing Then
								oleDbConnection = New OleDbConnection(text)
							Else
								oleDbConnection.ConnectionString = text
							End If
							o_0oOo_OO.oo.00O0__o.(True)
							A_0.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), oleDbConnection)
							A_2.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), o_0oOo_OO)
						Else
							If o0O Is Nothing Then
								o0O = New O0O(text)
							Else
								o0O.OO._o_OO.(text)
							End If
							o0O.OO.OoO0. = True
							A_1.Add(Conversions.ToString(A_4(O00OOOo_O0_O.b("�聯鍊", a_))), o0O)
						End If
						If o_u3002_u3000_u.OO._000_O0o_.().Checked Then
							A_4(O00OOOo_O0_O.b("햕ﮝ쎟횡춣즥욧囹𺲭񻲱펳", a_)) = O00.ooo000o_0.00o0.(text, O_O0OO.o0_OO.000.(A_3), ooO0__OO.o0O._ooo_O_.())
							Oo00.O0Oo_O.0O_0O.(A_4)
						End If
					End If
					If visible Then
						Main.ProcessForm.Show()
						Return
					End If
				Else
					ProjectData.EndApp()
				End If
			End If
		End Sub

		' Token: 0x060047D5 RID: 18389 RVA: 0x001E1068 File Offset: 0x001DF268
		Private Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, OleDbConnection), A_1 As Dictionary(Of String, O0O), A_2 As Dictionary(Of String, O_0oOo_OO), A_3 As DataSet, A_4 As DataSet, A_5 As DataTableCollection, A_6 As UserInfo, A_7 As Assembly, A_8 As OleDbConnection, A_9 As ProjectProperty)
			If A_9 Is Nothing Then
				A_9 = O_O0OO.O0_00o.o0__o.
			End If
			Dim dataTable As DataTable = A_3.Tables(ooO0__OO.O0_.OOo0OO.())
			Try
				For Each obj As Object In dataTable.Rows
					o0OoOOoOOo0.OOOOO.o000.(CType(obj, DataRow), A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, False, True, A_9)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047D6 RID: 18390 RVA: 0x001E10F4 File Offset: 0x001DF2F4
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As Dictionary(Of String, OleDbConnection), A_2 As Dictionary(Of String, O0O), A_3 As Dictionary(Of String, O_0oOo_OO), A_4 As DataSet, A_5 As DataSet, A_6 As DataTableCollection, A_7 As UserInfo, A_8 As Assembly, A_9 As OleDbConnection, A_10 As Boolean, Optional A_11 As Boolean = True, Optional A_12 As ProjectProperty = Nothing)
			Dim a_ As Integer = 15
			If A_12 Is Nothing Then
				A_12 = O_O0OO.O0_00o.o0__o.
			End If
			Dim otherTableTypeEnum As OtherTableTypeEnum = Conversions.ToInteger(A_0(O00OOOo_O0_O.b("즜토욢", a_)))
			Dim oleDbConnection As OleDbConnection = Nothing
			Dim o0O As O0O = Nothing
			Dim a_2 As String = ""
			Dim a_3 As String = Conversions.ToString(A_0(O00OOOo_O0_O.b("펜ﺞ철욢", a_)))
			If A_0.IsNull(O00OOOo_O0_O.b("�ﺞ햠슢좦��캬쪮", a_)) OrElse Operators.CompareString(A_0(O00OOOo_O0_O.b("�ﺞ햠슢좦��캬쪮", a_)).ToString(), "", True) = 0 Then
				oleDbConnection = A_9
			Else
				Dim key As String = Conversions.ToString(A_0(O00OOOo_O0_O.b("�ﺞ햠슢좦��캬쪮", a_)))
				If A_3.ContainsKey(key) AndAlso A_3(key).oo.00O0__o.() Then
					oleDbConnection = A_1(key)
				Else
					If Not A_2.ContainsKey(key) OrElse Not A_2(key).OO.OoO0. Then
						Return
					End If
					o0O = A_2(key)
				End If
			End If
			Dim a_4 As DataServerTypeEnum = DataServerTypeEnum.Access
			If o0O IsNot Nothing Then
				a_4 = o0O.OO.OoO0.
			ElseIf o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection) Then
				a_4 = DataServerTypeEnum.Oracle
			ElseIf o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection) Then
				a_4 = DataServerTypeEnum.SqlServer
			End If
			Dim text As String
			If otherTableTypeEnum Is Nothing Then
				Dim outerTableSetting As OuterTableSetting = New OuterTableSetting()
				o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, Conversions.ToString(A_0(O00OOOo_O0_O.b("출캠펢삤햦�튪", a_))), vbVerticalTab)
				text = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, a_4)
				a_2 = outerTableSetting.SourceTable
			Else
				text = Conversions.ToString(A_0(O00OOOo_O0_O.b("출캠펢삤햦�튪", a_)))
				If text.StartsWith(O00OOOo_O0_O.b("", a_)) AndAlso text.EndsWith(O00OOOo_O0_O.b("", a_)) Then
					text = text.Trim(New Char() { "{"c, "}"c })
					Dim a_5 As JoinTableProperty = New JoinTableProperty()
					o_O_o_oOoo__.OOOO_OO._oo.(a_5, text, vbVerticalTab)
					text = Oo00.OO.0O0o.(a_5)
				End If
			End If
			Dim beforeLoadOuterTableEventArgs As BeforeLoadOuterTableEventArgs = New BeforeLoadOuterTableEventArgs(Conversions.ToString(A_0(O00OOOo_O0_O.b("펜ﺞ철욢", a_))), text, A_7)
			O_O0OO.OoO_o.oO0o0O.(A_8, O00OOOo_O0_O.b("�爵잠첢힤슦쒪첬쮮ﺰ욲솴튶쮸��귀ꛂ", a_), New Object() { beforeLoadOuterTableEventArgs }, True, O00OOOo_O0_O.b("燨", a_), True)
			If Not beforeLoadOuterTableEventArgs.Cancel OrElse Not A_11 Then
				text = beforeLoadOuterTableEventArgs.SelectString
				If oleDbConnection IsNot Nothing Then
					text = Oo00.o0_o._O_.(oleDbConnection, text, Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Interaction.IIf(oleDbConnection Is A_9, True, False))))
				ElseIf o0O IsNot Nothing Then
					text = Oo00.o0_o._O_.(o0O.OO.OoO0., text, Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Interaction.IIf(oleDbConnection Is A_9, True, False))))
				End If
				Dim httpClient As HttpClient = Nothing
				If o0O IsNot Nothing Then
					httpClient = o0O.oO0_0.o.()
					httpClient.[Select] = text
					If otherTableTypeEnum Is Nothing Then
						httpClient.FormData(O00OOOo_O0_O.b("�ﲞ햠쪢쪤즦", a_)) = 1.ToString()
					Else
						httpClient.FormData(O00OOOo_O0_O.b("�ﲞ햠쪢쪤즦", a_)) = 2.ToString()
					End If
				End If
				o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text, a_3, A_5, A_6, a_2, A_10, A_9, A_7, A_4, 30, A_12, A_0(O00OOOo_O0_O.b("�ﺞ햠슢좦��캬쪮", a_)).ToString(), httpClient)
			End If
		End Sub

		' Token: 0x060047D7 RID: 18391 RVA: 0x001E1444 File Offset: 0x001DF644
		Friend Sub <<EMPTY_NAME>>(A_0 As OleDbConnection, A_1 As String, A_2 As String, A_3 As DataSet, A_4 As DataTableCollection, A_5 As String, A_6 As Boolean, A_7 As OleDbConnection, A_8 As UserInfo, A_9 As DataSet, Optional A_10 As Integer = 30, Optional A_11 As ProjectProperty = Nothing, Optional A_12 As String = "", Optional A_13 As HttpClient = Nothing)
			Dim a_ As Integer = 9
			If A_11 Is Nothing Then
				A_11 = O_O0OO.O0_00o.o0__o.
			End If
			Dim dataTable As DataTable = Nothing
			Dim oleDbDataAdapter As OleDbDataAdapter = Nothing
			If Operators.CompareString(A_2, "", True) > 0 AndAlso Not A_2.StartsWith(O00OOOo_O0_O.b("슜", a_), StringComparison.CurrentCultureIgnoreCase) AndAlso Not A_2.StartsWith(O00OOOo_O0_O.b("좖", a_)) AndAlso Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", True) > 0 Then
				Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace(O00OOOo_O0_O.b("ꦘ", a_), A_2))
				Application.DoEvents()
			End If
			Try
				If A_13 Is Nothing Then
					dataTable = New DataTable()
					A_1 = Oo00.o0_o._O_.(A_0, A_1, False)
					oleDbDataAdapter = New OleDbDataAdapter(A_1, A_0)
					oleDbDataAdapter.SelectCommand.CommandTimeout = A_10
					oleDbDataAdapter.FillLoadOption = LoadOption.PreserveChanges
					dataTable.TableName = A_2
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source)
					If A_8 IsNot Nothing AndAlso A_8.Type Is Nothing AndAlso O_O0OO.o00.0.(A_11) Then
						If Operators.CompareString(A_5, "", True) = 0 Then
						End If
					Else
						oleDbDataAdapter.Fill(dataTable)
					End If
					If Operators.CompareString(A_5, "", True) > 0 Then
						o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
						If Operators.CompareString(A_5, O00OOOo_O0_O.b("ꢖ", a_), True) = 0 Then
							A_5 = oleDbDataAdapter.UpdateCommand.CommandText.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)(1).Trim(New Char() { "["c, "]"c, """"c })
						End If
					End If
				Else
					dataTable = A_13.GetBaseDataTable()
					dataTable.TableName = A_2
					If Operators.CompareString(A_5, O00OOOo_O0_O.b("ꢖ", a_), True) = 0 Then
						A_5 = Oo00.o_OoO._0_00.(A_1)
					End If
				End If
				If dataTable.PrimaryKey.Length = 0 And Operators.CompareString(A_5, "", True) > 0 Then
					Try
						For Each obj As Object In dataTable.Columns
							Dim dataColumn As DataColumn = CType(obj, DataColumn)
							If Operators.CompareString(dataColumn.ColumnName, O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_), True) = 0 Then
								dataTable.PrimaryKey = New DataColumn() { dataColumn }
								dataColumn.AutoIncrement = True
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				If dataTable.PrimaryKey.Length = 1 AndAlso dataTable.PrimaryKey(0).AutoIncrement Then
					dataTable.PrimaryKey(0).[ReadOnly] = False
				End If
				If dataTable.PrimaryKey.Length = 1 AndAlso Operators.CompareString(dataTable.PrimaryKey(0).ColumnName, O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_), True) = 0 AndAlso Not dataTable.PrimaryKey(0).AutoIncrement Then
					dataTable.Columns(O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_)).AutoIncrement = True
					dataTable.Columns(O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_)).AutoIncrementStep = 1L
					dataTable.Columns(O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_)).AutoIncrementSeed = 1L
					If dataTable.Rows.Count > 0 AndAlso dataTable.Rows.Count > 0 Then
						dataTable.Columns(O00OOOo_O0_O.b("좖킘ﾚ햠쪢쎤�", a_)).AutoIncrementSeed = CLng((Conversions.ToInteger(dataTable.Compute(O00OOOo_O0_O.b("�떜쒞ﺠ솤슦잨�쒬즮좰鲴", a_), "")) + 1))
					End If
				End If
				Try
					For Each obj2 As Object In dataTable.Columns
						Dim dataColumn2 As DataColumn = CType(obj2, DataColumn)
						If dataColumn2.ColumnName.StartsWith(O00OOOo_O0_O.b("춘횚출�", a_)) Then
							dataColumn2.Caption = dataColumn2.ColumnName.Substring(7)
						End If
					Next
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				A_3.Tables.Add(dataTable)
				A_4.OO0o00.0O_0o.(New DataTable(dataTable, oleDbDataAdapter, A_0, A_5, A_9, A_13))
				A_4(A_2).ConnectionName = A_12
				If A_13 IsNot Nothing Then
					Dim dataTable2 As DataTable = A_4(A_2)
					dataTable2.DataServer = A_13.Oo_0oO0Oo0_.O_.
					dataTable2.HttpSelect = A_1
					If Operators.CompareString(A_5, "", True) > 0 Then
						dataTable2.UpdateServer = A_13.Oo_0oO0Oo0_.O_.
						dataTable2.UpdateColumns = CType(dataTable2.BaseTable.ExtendedProperties(O00OOOo_O0_O.b("슖ﾚﲜ쒠쪤쮦�욪쎬�", a_)), List(Of String))
					Else
						dataTable2.AllowEdit = False
					End If
					Dim a_2 As String = A_1
					Dim dataTable3 As DataTable = dataTable2
					Dim dataTable4 As DataTable = dataTable3
					Dim a_3 As String = dataTable3.LoadFilter
					Dim dataTable5 As DataTable = dataTable2
					Dim dataTable6 As DataTable = dataTable5
					Dim a_4 As String = dataTable5.LoadTop
					Dim dataTable7 As DataTable = dataTable2
					Dim dataTable8 As DataTable = dataTable2
					Dim dataTable9 As DataTable = dataTable2
					Dim dataTable10 As DataTable = dataTable9
					Dim a_5 As String = dataTable9.LoadOrder
					Oo00.ooO.ooo.(a_2, a_3, a_4, dataTable7.o0_oO00.0oO_., dataTable8.O0o0__o.0000__., a_5)
					dataTable10.LoadOrder = a_5
					dataTable6.LoadTop = a_4
					dataTable4.LoadFilter = a_3
					dataTable2.ooO.oO0O0_oo. = False
				End If
				If A_6 Then
					New O_0(O_O0OO.o__.O.(), dataTable)
				End If
			Catch ex As Exception
				MessageBox.Show(O00OOOo_O0_O.b("㟄뾜", a_) + A_2 + O00OOOo_O0_O.b("떖ꣁ븗酣礕柞먷䨯䛩웈醪ꂬꖮ", a_) + ex.ToString(), O00OOOo_O0_O.b("踃瘓", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060047D8 RID: 18392 RVA: 0x001E19C8 File Offset: 0x001DFBC8
		Private Sub <<EMPTY_NAME>>(A_0 As DataSet, A_1 As DataSet, A_2 As DataTableCollection)
			Try
				For Each obj As Object In A_0.Tables(ooO0__OO.o_0_000._O.()).Rows
					o0OoOOoOOo0.OOOOO.o000.(CType(obj, DataRow), A_0, A_1, A_2, False)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047D9 RID: 18393 RVA: 0x001E1A34 File Offset: 0x001DFC34
		Friend Function <<EMPTY_NAME>>(Optional A_0 As String = "") As String
			If Operators.CompareString(A_0, "", True) = 0 Then
				A_0 = OO_00oOO.ProjectFile
			End If
			Return Path.GetFileNameWithoutExtension(A_0)
		End Function

		' Token: 0x060047DA RID: 18394 RVA: 0x001E1A54 File Offset: 0x001DFC54
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataSet, A_2 As DataSet, A_3 As DataTableCollection, A_4 As Boolean)
			Dim a_ As Integer = 0
			Dim dataTable As DataTable = New DataTable()
			dataTable.TableName = Conversions.ToString(A_0(O00OOOo_O0_O.b("삍ﾑ", a_)))
			dataTable.Columns.Add(O00OOOo_O0_O.b("톍�瀞", a_), GetType(Integer), "")
			dataTable.Columns(O00OOOo_O0_O.b("톍�瀞", a_)).AutoIncrement = True
			dataTable.Columns(O00OOOo_O0_O.b("톍�瀞", a_)).AutoIncrementStep = 1L
			dataTable.PrimaryKey = New DataColumn() { dataTable.Columns(O00OOOo_O0_O.b("톍�瀞", a_)) }
			A_2.Tables.Add(dataTable)
			Try
				For Each obj As Object In A_1.Tables(ooO0__OO.o0o.o.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Operators.CompareString(dataTable.TableName, Conversions.ToString(dataRow(O00OOOo_O0_O.b("�", a_))), True) = 0 Then
						Dim text As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("춍ﾏﺑﮕ", a_)))
						Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow(O00OOOo_O0_O.b("쪍슕鍊", a_))), ColumnDataTypeEnum)
						Dim a_2 As Integer
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("쎍ﶙ", a_)) Then
							a_2 = Conversions.ToInteger(dataRow(O00OOOo_O0_O.b("쎍ﶙ", a_)))
						Else
							a_2 = -1
						End If
						If dataTable.Columns.Contains(text) Then
							dataRow.Delete()
						Else
							o0OoOOoOOo0.O0OoO_0o.O.(dataTable, text, columnDataTypeEnum, String.Empty, a_2)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim num As Integer = 0
			Do
				Dim row As DataRow = dataTable.NewRow()
				dataTable.Rows.Add(row)
				num += 1
			Loop While num <= 9
			A_3.OO0o00.0O_0o.(New DataTable(dataTable, Nothing, Nothing, "", A_1))
			If A_4 Then
				New O_0(O_O0OO.o__.O.(), dataTable)
			End If
		End Sub

		' Token: 0x060047DB RID: 18395 RVA: 0x001E1CA8 File Offset: 0x001DFEA8
		Friend Sub <<EMPTY_NAME>>(A_0 As DataTable, A_1 As String, A_2 As ColumnDataTypeEnum, A_3 As String, A_4 As Integer)
			Dim type As Type = Oo00.OO.0O0o.(A_2)
			Try
				Dim dataColumn As DataColumn = New DataColumn(A_1, type)
				If type Is GetType(Boolean) Then
					dataColumn.DefaultValue = False
				End If
				A_0.Columns.Add(dataColumn)
				If Operators.CompareString(A_3, "", True) > 0 Then
					dataColumn.Expression = A_3
				End If
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
			If A_2 = ColumnDataTypeEnum.[String] Then
				A_0.Columns(A_1).MaxLength = A_4
			End If
		End Sub

		' Token: 0x060047DC RID: 18396 RVA: 0x001E1D48 File Offset: 0x001DFF48
		Private Sub <<EMPTY_NAME>>(A_0 As DataSet, A_1 As DataTableCollection, A_2 As DataSet)
			Dim a_ As Integer = 10
			Try
				For Each obj As Object In A_0.Tables(ooO0__OO.o0o.o.()).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					Dim text As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("첗ﮙﺛ얟", a_)))
					If A_1.Contains(text) AndAlso Not A_1(text).frd_IsTemporary Then
						Dim text2 As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("�춟첡", a_)))
						Dim columnDataTypeEnum As ColumnDataTypeEnum = CType(Conversions.ToInteger(dataRow(O00OOOo_O0_O.b("�ﮙﾝ�풣쎥", a_))), ColumnDataTypeEnum)
						Dim a_2 As Integer
						If columnDataTypeEnum = ColumnDataTypeEnum.[String] AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("햗ﮙ얟첡쎣튥삧", a_)) Then
							a_2 = Conversions.ToInteger(dataRow(O00OOOo_O0_O.b("햗ﮙ얟첡쎣튥삧", a_)))
						Else
							a_2 = -1
						End If
						If A_2.Tables(text).Columns.Contains(text2) Then
							dataRow.Delete()
						ElseIf A_2.Tables.Contains(text) Then
							o0OoOOoOOo0.O0OoO_0o.O.(A_2.Tables(text), text2, columnDataTypeEnum, String.Empty, a_2)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047DD RID: 18397 RVA: 0x001E1EC4 File Offset: 0x001E00C4
		Private Sub <<EMPTY_NAME>>(A_0 As DataSet, A_1 As DataTableCollection, A_2 As DataSet)
			Dim a_ As Integer = 6
			For Each dataRow As DataRow In A_0.Tables(ooO0__OO.o0o.o.()).[Select]("", "", DataViewRowState.CurrentRows)
				Dim text As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("삓流鍊", a_)))
				If A_1.Contains(text) Then
					Dim text2 As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("힓秊", a_)))
					Dim text3 As String = Conversions.ToString(dataRow(O00OOOo_O0_O.b("톓鍊펟쮡쮣좥", a_)))
					If Operators.CompareString(text3, "", True) = 0 Then
						text3 = String.Empty
					End If
					If A_1.Contains(text) Then
						Try
							A_1(text).BaseTable.Columns(text2).Expression = text3
						Catch a_2 As Exception
							MessageBox.Show(String.Concat(New String() { O00OOOo_O0_O.b("瓶䏹黋솙", a_), text, O00OOOo_O0_O.b("즓︝᳡솙", a_), text2, O00OOOo_O0_O.b("즓臇᳡∔釂Ḕ쳞黭鲥ꖧꂩ", a_), text3, O00OOOo_O0_O.b("馓鲕ᫎ۾ӆ젗ᰮ꯼䛀䔬翅딾䄦뱐꛿盠룻核ⷂ㣍뫩ퟭ䚷즗㚼ຖ꒱Ⲯⅆ�煁鲝⅞ᢿ㾾�즏撩銄誀鶙掰얏쪿趆麗︎羼璬ኤ貞슭ឭ佣旅쑖ى꩛഻셜ᄿ䩟ᔣ犃公橼穀캒띤⏞", a_) }), O00OOOo_O0_O.b("䓰곬", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
							ooO.oOo0Oo.o.(a_2, "")
						End Try
					End If
				End If
			Next
		End Sub

		' Token: 0x060047DE RID: 18398 RVA: 0x001E2058 File Offset: 0x001E0258
		Private Sub <<EMPTY_NAME>>(A_0 As DataSet, A_1 As DataSet)
			Try
				For Each obj As Object In A_0.Tables(ooO0__OO.O0.ooO0O.()).Rows
					o0OoOOoOOo0.OO0._Oo0o.(CType(obj, DataRow), A_1)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047DF RID: 18399 RVA: 0x001E20C4 File Offset: 0x001E02C4
		Friend Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As DataSet)
			Dim a_ As Integer = 19
			Dim text As String = ""
			Dim fxDataRelationProperty As fxDataRelationProperty = New fxDataRelationProperty()
			If A_1.Tables.Contains(Conversions.ToString(A_0(O00OOOo_O0_O.b("슢힤슦잨�怜캮펰�킴", a_)))) AndAlso A_1.Tables.Contains(Conversions.ToString(A_0(O00OOOo_O0_O.b("쮢첤쮦춨ﾪ첬춮�횲", a_)))) Then
				Try
					If A_1.Tables.Contains(Conversions.ToString(A_0(O00OOOo_O0_O.b("슢힤슦잨�怜캮펰�킴", a_)))) AndAlso A_1.Tables.Contains(Conversions.ToString(A_0(O00OOOo_O0_O.b("쮢첤쮦춨ﾪ첬춮�횲", a_)))) Then
						o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, Conversions.ToString(A_0(O00OOOo_O0_O.b("톢쪤힦첨��횮", a_))), vbVerticalTab)
						text = Conversions.ToString(A_0(O00OOOo_O0_O.b("슢좤슦", a_)))
						Dim dataTable As DataTable = A_1.Tables(Conversions.ToString(A_0(O00OOOo_O0_O.b("슢힤슦잨�怜캮펰�킴", a_))))
						Dim dataTable2 As DataTable = A_1.Tables(Conversions.ToString(A_0(O00OOOo_O0_O.b("쮢첤쮦춨ﾪ첬춮�횲", a_))))
						Dim array As String() = Conversions.ToString(A_0(O00OOOo_O0_O.b("슢힤슦잨�삮�삲", a_))).Split(O00OOOo_O0_O.b("ꢠ", a_).ToCharArray())
						Dim array2 As String() = Conversions.ToString(A_0(O00OOOo_O0_O.b("쮢첤쮦춨슬쎮슰", a_))).Split(O00OOOo_O0_O.b("ꢠ", a_).ToCharArray())
						Dim array3 As DataColumn() = New DataColumn(array.Length - 1 + 1 - 1) {}
						Dim array4 As DataColumn() = New DataColumn(array2.Length - 1 + 1 - 1) {}
						Dim num As Integer = array.Length - 1
						For i As Integer = 0 To num
							If Not dataTable.Columns.Contains(array(i)) OrElse Not dataTable2.Columns.Contains(array2(i)) Then
								MessageBox.Show(O00OOOo_O0_O.b("膠룰忺퓷ﴨ髳蠡趮", a_) + text + O00OOOo_O0_O.b("굟꓁㿿⏐�Ｊ뫾ꋠ鯥ꏖ눶䯥ဲ鷮�쀿", a_), O00OOOo_O0_O.b("燃駛", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								Return
							End If
							array3(i) = dataTable.Columns(array(i))
							array4(i) = dataTable2.Columns(array2(i))
						Next
						Dim o0Oo As O0Oo = New O0Oo(text, array3, array4, A_0)
						A_1.Relations.Add(o0Oo)
						o0Oo.o.O0_o.(fxDataRelationProperty.CascadeDelete)
						o0Oo.oo0__.0Oo0o_.(fxDataRelationProperty.CascadeUpdate)
						o0Oo.oo0__.0Oo0o_.(fxDataRelationProperty.RelationTable)
					End If
				Catch ex As Exception
					MessageBox.Show(O00OOOo_O0_O.b("膠룰忺퓷ﴨ髳蠡趮", a_) + text + O00OOOo_O0_O.b("莠꽝㫷䟰덗", a_) + ex.Message, O00OOOo_O0_O.b("燃駛", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End Try
			End If
		End Sub

		' Token: 0x060047E0 RID: 18400 RVA: 0x001E23EC File Offset: 0x001E05EC
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0), A_1 As DataSet)
			Try
				For Each obj As Object In A_1.Tables
					Dim dataTable As DataTable = CType(obj, DataTable)
					Dim a_ As O_0 = New O_0(A_0, dataTable)
					Try
						For Each obj2 As Object In A_1.Relations
							Dim o0Oo As O0Oo = CType(obj2, O0Oo)
							If o0Oo.oo0__.0Oo0o_.() <> 2 Then
								If o0Oo.ParentTable Is dataTable Then
									o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_1, o0Oo, False)
								ElseIf o0Oo.oo0__.0Oo0o_.() = 1 AndAlso o0Oo.ChildTable Is dataTable Then
									o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_1, o0Oo, False)
								End If
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047E1 RID: 18401 RVA: 0x001E24D4 File Offset: 0x001E06D4
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0), A_1 As O_0, A_2 As DataSet, A_3 As DataRelation, A_4 As Boolean)
			Dim a_ As O_0 = New O_0(A_0, A_1, A_3)
			If A_3.ParentTable IsNot A_3.ChildTable Then
				Try
					For Each obj As Object In A_2.Relations
						Dim o0Oo As O0Oo = CType(obj, O0Oo)
						If o0Oo IsNot A_3 AndAlso o0Oo.ParentTable IsNot o0Oo.ChildTable AndAlso o0Oo.oo0__.0Oo0o_.() <> 2 Then
							If o0Oo.ParentTable Is A_3.ChildTable Then
								o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_2, o0Oo, True)
							ElseIf o0Oo.ChildTable Is A_3.ChildTable AndAlso Not A_4 AndAlso o0Oo.oo0__.0Oo0o_.() = 1 Then
								o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_2, o0Oo, True)
							End If
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060047E2 RID: 18402 RVA: 0x001E25A0 File Offset: 0x001E07A0
		Friend Sub <<EMPTY_NAME>>(A_0 As Dictionary(Of String, O_0), A_1 As O_0, A_2 As DataSet, A_3 As DataRelation, A_4 As Boolean)
			Dim a_ As O_0 = New O_0(A_0, A_1, A_3)
			Try
				For Each obj As Object In A_2.Relations
					Dim o0Oo As O0Oo = CType(obj, O0Oo)
					If o0Oo IsNot A_3 AndAlso o0Oo.ParentTable IsNot o0Oo.ChildTable AndAlso o0Oo.oo0__.0Oo0o_.() <> 2 Then
						If o0Oo.ChildTable Is A_3.ParentTable AndAlso o0Oo.oo0__.0Oo0o_.() = 1 Then
							o0OoOOoOOo0.O_0_Oo_00.O.(A_0, a_, A_2, o0Oo, True)
						ElseIf o0Oo.ParentTable Is A_3.ParentTable AndAlso Not A_4 Then
							o0OoOOoOOo0.o_OOo_0.0O.(A_0, a_, A_2, o0Oo, True)
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060047E3 RID: 18403 RVA: 0x001E2658 File Offset: 0x001E0858
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Return False
		End Function

		' Token: 0x060047E4 RID: 18404 RVA: 0x001E265C File Offset: 0x001E085C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim a_ As Integer = 9
			OO_00oOO.FileSys.CopyFile(A_0, A_0 + O00OOOo_O0_O.b("릖列", a_), True)
			Dim table As Table = New TableClass()
			Dim index As Index = New IndexClass()
			Dim catalogClass As CatalogClass = New CatalogClass()
			Dim connection As Connection = New ConnectionClass()
			connection.ConnectionString = Oo00.o_._0OOo.(A_0)
			connection.Open("", "", "", -1)
			catalogClass.ActiveConnection = connection
			table = New TableClass()
			index = New IndexClass()
			table.Name = ooO0__OO.o.00_0o0__OoO.()
			table.Columns.Append(O00OOOo_O0_O.b("ﺖﶘ", a_), 3, 0)
			table.Columns.Append(O00OOOo_O0_O.b("�", a_), 202, 64)
			table.Columns.Append(O00OOOo_O0_O.b("잖", a_), 202, 64)
			table.Columns.Append(O00OOOo_O0_O.b("쎖", a_), 17, 0)
			table.Columns.Append(O00OOOo_O0_O.b("풖ﮜ욠", a_), 203, 0)
			table.Columns.Append(O00OOOo_O0_O.b("", a_), 3, 0)
			table.Columns(O00OOOo_O0_O.b("풖ﮜ욠", a_)).Attributes = 2
			table.Columns(O00OOOo_O0_O.b("", a_)).Attributes = 2
			table.Columns(O00OOOo_O0_O.b("잖", a_)).Attributes = 2
			index.Name = O00OOOo_O0_O.b("잖ﺞ펠�슦킨", a_)
			index.Columns.Append(O00OOOo_O0_O.b("ﺖﶘ", a_), 202, 0)
			index.PrimaryKey = True
			index.Unique = True
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
			catalogClass.Tables.Append(table)
			connection.Close()
		End Sub

		' Token: 0x060047E5 RID: 18405 RVA: 0x001E2860 File Offset: 0x001E0A60
		Friend Sub <<EMPTY_NAME>>(A_0 As DataSet)
			Dim a_ As Integer = 1
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_09:
				Dim num As Integer = 1
				Dim dataTable As DataTable = A_0.Tables(ooO0__OO.OOo0._00O_o00.())
				IL_1C:
				num = 2
				Dim text As String = Guid.NewGuid().ToString()
				IL_34:
				num = 3
				Dim dataRow As DataRow = dataTable.Rows.Find(New Object() { O00OOOo_O0_O.b("�ﲒﾔ滛풜ﮞ쒠춢톤캦쾨튪", a_), o0_O.O_oo00.o0. })
				IL_63:
				num = 4
				dataRow(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)) = text
				IL_7C:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_83:
				num = 6
				Dim text2 As String = ""
				IL_8C:
				num = 7
				Dim text3 As String = ""
				IL_95:
				num = 8
				o0OO__.oOO.o_.(text2, text3)
				IL_A0:
				num = 9
				dataRow = dataTable.NewRow()
				IL_AB:
				num = 10
				dataRow(O00OOOo_O0_O.b("솎ﺒ", a_)) = O00OOOo_O0_O.b("�ﲒﾔ滛풜ﮞ쒠춢톤캦쾨튪", a_)
				IL_D1:
				num = 11
				dataRow(O00OOOo_O0_O.b("�", a_)) = o0_O.oO_0o__.O0_oo.
				IL_F0:
				num = 12
				dataRow(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)) = O00.ooo000o_0.00o0.(text, text2, text3)
				IL_113:
				num = 13
				dataTable.Rows.Add(dataRow)
				IL_123:
				num = 14
				dataRow = A_0.Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_13D:
				num = 15
				dataRow(O00OOOo_O0_O.b("솎ﺒ", a_)) = O00OOOo_O0_O.b("쮎ﺐﲒﮖﲘ", a_)
				IL_163:
				num = 16
				dataRow(O00OOOo_O0_O.b("�", a_)) = o0_O.o_.oooo0.
				IL_182:
				num = 17
				dataRow(O00OOOo_O0_O.b("첎ﺐﶒﺖﺘ", a_)) = text2 + text3
				IL_1A3:
				num = 18
				dataTable.Rows.Add(dataRow)
				IL_1B3:
				num = 19
				Oo00.o0_o._O_.(dataTable, False)
				IL_1BD:
				GoTo IL_25F
				IL_1C2:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_220:
				GoTo IL_254
				IL_222:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_232:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_222
			End Try
			IL_254:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_25F:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060047E6 RID: 18406 RVA: 0x001E2AF0 File Offset: 0x001E0CF0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim num As Integer
			Dim result As String
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = O00.MD5Encrypt(A_0)
				IL_11:
				num2 = 3
				Dim text2 As String = ""
				IL_1A:
				num2 = 4
				Dim num3 As Integer = 0
				Do
					IL_1F:
					num2 = 5
					text2 += Conversions.ToString(CInt((text(num3) Mod vbTab + ChrW(1))))
					IL_3D:
					num2 = 6
					num3 += 1
				Loop While num3 <= 3
				IL_4A:
				num2 = 7
				result = text2
				IL_4F:
				GoTo IL_BE
				IL_51:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_7F:
				GoTo IL_B3
				IL_81:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_91:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_81
			End Try
			IL_B3:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_BE:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060047E7 RID: 18407 RVA: 0x001E2BD4 File Offset: 0x001E0DD4
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As String
			Dim a_ As Integer = 7
			Dim num As Integer
			Dim result As String
			Dim num8 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				ProjectData.ClearProjectError()
				num = 1
				IL_17:
				Dim num2 As Integer = 3
				Dim text As String = O00OOOo_O0_O.b("꒔Ꞗꮘ꾚", a_)
				IL_29:
				num2 = 4
				Dim text2 As String = ""
				IL_32:
				num2 = 5
				Dim text3 As String = ""
				IL_3B:
				num2 = 6
				Dim text4 As String = ""
				IL_44:
				num2 = 7
				Dim text5 As String = ""
				IL_4D:
				num2 = 8
				Dim text6 As String = ""
				IL_56:
				num2 = 9
				Dim left As String = ""
				IL_60:
				num2 = 10
				Dim text7 As String = O00OOOo_O0_O.b("슔튖�", a_)
				IL_73:
				num2 = 11
				text = text.TrimEnd(New Char() { "."c })
				IL_8A:
				num2 = 12
				If Versioned.IsNumeric(text) Then
					GoTo IL_A9
				End If
				IL_96:
				num2 = 13
				left = O00OOOo_O0_O.b("꒔", a_)
				IL_A9:
				num2 = 14
				If Conversion.Val(text) <> 0.0 Then
					GoTo IL_D1
				End If
				IL_BE:
				num2 = 15
				left = O00OOOo_O0_O.b("", a_)
				IL_D1:
				num2 = 16
				If Operators.CompareString(left, "", True) <> 0 Then
					GoTo IL_37C
				End If
				IL_E6:
				num2 = 17
				Dim num3 As Long = CLng(Math.Floor(Conversion.Val(text)))
				IL_F8:
				num2 = 18
				If text.IndexOf(O00OOOo_O0_O.b("뮔", a_)) < 0 Then
					GoTo IL_12A
				End If
				IL_113:
				num2 = 19
				text2 = text.Substring(text.IndexOf("."c) + 1)
				IL_12A:
				num2 = 20
				If num3 <= 0L Then
					GoTo IL_2B7
				End If
				IL_136:
				num2 = 21
				If num3 <> 0L Then
					GoTo IL_155
				End If
				IL_13D:
				num2 = 22
				left = O00OOOo_O0_O.b("", a_)
				GoTo IL_2B7
				IL_155:
				num2 = 24
				text = num3.ToString()
				IL_161:
				num2 = 25
				Dim num4 As Integer = 1
				Do
					IL_167:
					num2 = 26
					text3 = Strings.Right(text, 4)
					IL_174:
					num2 = 27
					num3 = Long.Parse(text3)
					IL_180:
					num2 = 28
					text3 = num3.ToString()
					IL_18C:
					num2 = 29
					If num4 = 1 Then
						IL_194:
						num2 = 30
						text6 = text3
					Else
						IL_1A0:
						num2 = 32
						If num3 > 0L Then
							IL_1A9:
							num2 = 33
							text5 = text3 + Conversions.ToString(text7(num4 - 2))
						End If
						IL_1C5:
						num2 = 34
						If Operators.CompareString(text6, "", True) > 0 Then
							IL_1D8:
							num2 = 35
							If num3 = 0L OrElse text4.Length < 4 OrElse text3.EndsWith(O00OOOo_O0_O.b("ꖔ", a_)) Then
								IL_200:
								num2 = 36
								text6 = text5 + O00OOOo_O0_O.b("", a_) + text6
							Else
								IL_21E:
								num2 = 38
								text6 = text5 + text6
							End If
						Else
							IL_22E:
							num2 = 40
							text6 = text5
						End If
					End If
					IL_235:
					num2 = 41
					text4 = text3
					IL_23C:
					num2 = 42
					If text.Length <= 4 Then
						Exit Do
					End If
					IL_249:
					num2 = 45
					text = text.Substring(0, text.Length - 4)
					IL_25F:
					num2 = 46
					num4 += 1
				Loop While num4 <= 4
				IL_270:
				num2 = 47
				text6 = text6.Replace(O00OOOo_O0_O.b("", a_), "")
				IL_28F:
				num2 = 48
				text6 = text6.Replace(O00OOOo_O0_O.b("", a_), O00OOOo_O0_O.b("", a_))
				IL_2B7:
				num2 = 49
				If Operators.CompareString(text2, "", True) <= 0 Then
					GoTo IL_375
				End If
				IL_2CD:
				num2 = 50
				If Operators.CompareString(text6, "", True) <> 0 Then
					GoTo IL_2F4
				End If
				IL_2DF:
				num2 = 51
				text6 = O00OOOo_O0_O.b("릖", a_)
				GoTo IL_30E
				IL_2F4:
				num2 = 53
				text6 += O00OOOo_O0_O.b("", a_)
				IL_30E:
				num2 = 54
				Dim num5 As Integer = text2.Length - text2.TrimStart(New Char() { "0"c }).Length
				IL_332:
				num2 = 55
				If num5 <= 0 Then
					GoTo IL_35D
				End If
				IL_33A:
				num2 = 56
				text6 += O00OOOo_O0_O.b("", a_).PadLeft(num5, "z"c)
				IL_35D:
				num2 = 57
				text6 += Conversions.ToString(Conversions.ToInteger(text2))
				IL_375:
				num2 = 58
				left = text6
				IL_37C:
				num2 = 59
				Dim text8 As String = O00.ooo000o_0.00o0.(A_0, A_1, A_1)
				IL_389:
				num2 = 60
				text8 = o_o_O0OO_0__.o000oOoo.0.(text8)
				IL_395:
				num2 = 61
				Dim text9 As String = ""
				IL_39F:
				num2 = 62
				Dim num6 As Integer = 5
				Do
					IL_3A5:
					num2 = 63
					text9 += Conversions.ToString(CInt((text8(num6) Mod vbTab + ChrW(1))))
					IL_3C4:
					num2 = 64
					num6 += 1
				Loop While num6 <= 8
				IL_3D2:
				num2 = 65
				result = text9
				IL_3D8:
				GoTo IL_532
				IL_3DD:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_4F3:
				GoTo IL_527
				IL_4F5:
				num8 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_505:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4F5
			End Try
			IL_527:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_532:
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060047E8 RID: 18408 RVA: 0x001E3138 File Offset: 0x001E1338
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim result As Boolean
			Try
				Dim count As Integer = PrinterSettings.InstalledPrinters.Count
				result = True
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		' Token: 0x060047E9 RID: 18409 RVA: 0x001E3178 File Offset: 0x001E1378
		Friend Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				GoTo IL_5E
				IL_09:
				Dim num2 As Integer = num3 + 1
				num3 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_1F:
				GoTo IL_53
				IL_21:
				Dim num4 As Integer
				num3 = num4
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_31:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_21
			End Try
			IL_53:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5E:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060047EA RID: 18410 RVA: 0x001E31FC File Offset: 0x001E13FC
		Friend Function <<EMPTY_NAME>>() As Boolean
			Dim a_ As Short = 0S
			Dim text As String = ""
			Return Oo0OO_oo.o_o0oO000.0_.(a_, text) = 0
		End Function

		' Token: 0x060047EB RID: 18411 RVA: 0x001E3220 File Offset: 0x001E1420
		Private Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(36) {}
			array(0) = 230
			array(1) = 150
			array(2) = 135
			array(3) = 228
			array(4) = 187
			array(5) = 182
			array(6) = 230
			array(7) = 160
			array(8) = 188
			array(9) = 229
			array(10) = 188
			array(11) = 143
			array(12) = 228
			array(13) = 184
			array(14) = 141
			array(15) = 231
			array(16) = 172
			array(17) = 166
			array(18) = 239
			array(19) = 188
			array(20) = 140
			array(21) = 230
			array(22) = 151
			array(23) = 160
			array(24) = 230
			array(25) = 179
			array(26) = 149
			array(27) = 230
			array(28) = 137
			array(29) = 147
			array(30) = 229
			array(31) = 188
			array(32) = 128
			array(33) = 239
			array(34) = 188
			array(35) = 129
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x060047EC RID: 18412 RVA: 0x001E337C File Offset: 0x001E157C
		Private Function <<EMPTY_NAME>>() As String
			Dim array As Byte() = New Byte(68) {}
			array(0) = 230
			array(1) = 150
			array(2) = 135
			array(3) = 228
			array(4) = 187
			array(5) = 182
			array(6) = 231
			array(7) = 137
			array(8) = 136
			array(9) = 230
			array(10) = 156
			array(11) = 172
			array(12) = 232
			array(13) = 191
			array(14) = 135
			array(15) = 233
			array(16) = 171
			array(17) = 152
			array(18) = 239
			array(19) = 188
			array(20) = 140
			array(21) = 230
			array(22) = 151
			array(23) = 160
			array(24) = 230
			array(25) = 179
			array(26) = 149
			array(27) = 230
			array(28) = 173
			array(29) = 163
			array(30) = 229
			array(31) = 184
			array(32) = 184
			array(33) = 230
			array(34) = 137
			array(35) = 147
			array(36) = 229
			array(37) = 188
			array(38) = 128
			array(39) = 239
			array(40) = 188
			array(41) = 140
			array(42) = 232
			array(43) = 175
			array(44) = 183
			array(45) = 229
			array(46) = 141
			array(47) = 135
			array(48) = 231
			array(49) = 186
			array(50) = 167
			array(51) = 230
			array(52) = 130
			array(53) = 168
			array(54) = 231
			array(55) = 154
			array(56) = 132
			array(57) = 70
			array(58) = 111
			array(59) = 120
			array(60) = 116
			array(61) = 97
			array(62) = 98
			array(63) = 108
			array(64) = 101
			array(65) = 239
			array(66) = 188
			array(67) = 129
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x060047ED RID: 18413 RVA: 0x001E35E0 File Offset: 0x001E17E0
		Friend Function <<EMPTY_NAME>>() As String
			Dim num As Integer
			Dim result As String
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim array As Byte() = New Byte(14) {}
				IL_12:
				num2 = 3
				array(0) = 69
				IL_1A:
				num2 = 4
				array(1) = 120
				IL_22:
				num2 = 5
				array(2) = 101
				IL_2A:
				num2 = 6
				array(3) = 99
				IL_32:
				num2 = 7
				array(4) = 117
				IL_3A:
				num2 = 8
				array(5) = 116
				IL_42:
				num2 = 9
				array(6) = 97
				IL_4B:
				num2 = 10
				array(7) = 98
				IL_54:
				num2 = 11
				array(8) = 108
				IL_5D:
				num2 = 12
				array(9) = 101
				IL_67:
				num2 = 13
				array(10) = 80
				IL_71:
				num2 = 14
				array(11) = 97
				IL_7B:
				num2 = 15
				array(12) = 116
				IL_85:
				num2 = 16
				array(13) = 104
				IL_8F:
				num2 = 17
				Dim [string] As String = Encoding.ASCII.GetString(array)
				IL_A0:
				num2 = 18
				result = [string].Substring(0, 14)
				IL_AE:
				GoTo IL_14C
				IL_B3:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_10D:
				GoTo IL_141
				IL_10F:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_11F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10F
			End Try
			IL_141:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_14C:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x060047EE RID: 18414 RVA: 0x001E3760 File Offset: 0x001E1960
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim a_ As Integer = 9
			Dim text As String = ""
			A_0 = O00.MD5Encrypt(A_0.ToUpper())
			For Each c As Char In A_0
				If Char.IsLetter(c) OrElse Char.IsDigit(c) Then
					text += Conversions.ToString(c)
				End If
			Next
			Return O00OOOo_O0_O.b("횖", a_) + Strings.Left(text, 16)
		End Function

		' Token: 0x060047EF RID: 18415 RVA: 0x001E37DC File Offset: 0x001E19DC
		Friend Function a(A_0 As DataTable, A_1 As String) As Boolean
			Dim a_ As Integer = 0
			Dim dataRow As DataRow = A_0.Rows.Find(New Object() { O00OOOo_O0_O.b("쪍ﲏﺑ望", a_), o0_O.o_0_00oo_o.Oo. })
			Dim result As Boolean
			If dataRow Is Nothing OrElse dataRow.IsNull(O00OOOo_O0_O.b("춍ﾏﲑﾕﾗ", a_)) Then
				result = False
			Else
				Dim array As String() = dataRow(O00OOOo_O0_O.b("춍ﾏﲑﾕﾗ", a_)).ToString().Split(New Char() { vbTab })
				Dim num As Integer = array.Length - 2
				For i As Integer = 0 To num Step 2
					Dim text As String = A_1 + O00OOOo_O0_O.b("튍", a_) + array(i)
					If Not OO_00oOO.FileSys.FileExists(text) Then
						Return False
					End If
					If Operators.CompareString(O00.CRCCheckFile(text), array(i + 1), True) <> 0 Then
						Return False
					End If
				Next
				result = True
			End If
			Return result
		End Function

		' Token: 0x060047F0 RID: 18416 RVA: 0x001E38C8 File Offset: 0x001E1AC8
		Private Function a() As String
			Dim array As Byte() = New Byte(47) {}
			array(0) = 230
			array(1) = 137
			array(2) = 190
			array(3) = 228
			array(4) = 184
			array(5) = 141
			array(6) = 229
			array(7) = 136
			array(8) = 176
			array(9) = 229
			array(10) = 191
			array(11) = 133
			array(12) = 232
			array(13) = 166
			array(14) = 129
			array(15) = 231
			array(16) = 154
			array(17) = 132
			array(18) = 68
			array(19) = 76
			array(20) = 76
			array(21) = 230
			array(22) = 150
			array(23) = 135
			array(24) = 228
			array(25) = 187
			array(26) = 182
			array(27) = 44
			array(28) = 230
			array(29) = 151
			array(30) = 160
			array(31) = 230
			array(32) = 179
			array(33) = 149
			array(34) = 230
			array(35) = 137
			array(36) = 147
			array(37) = 229
			array(38) = 188
			array(39) = 128
			array(40) = 233
			array(41) = 161
			array(42) = 185
			array(43) = 231
			array(44) = 155
			array(45) = 174
			array(46) = 33
			Return Encoding.UTF8.GetString(array)
		End Function

		' Token: 0x060047F1 RID: 18417 RVA: 0x001E3A78 File Offset: 0x001E1C78
		Friend Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 8
			Return O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("킕ﾝ슟캡솣춧��잭�햱잳", a_))(O00OOOo_O0_O.b("햕瀞잟", a_)).ToString(), O00OOOo_O0_O.b("ﾝ슟캡솣", a_), O00OOOo_O0_O.b("얕ﶗ캟얡힣", a_)).Replace(O00OOOo_O0_O.b("�鍊쎡킣장ﲧ쮩캫슭햯ﲱ햳󽖷", a_), O00OOOo_O0_O.b("뒕", a_) + ooO0__OO.O0_.OOo0OO.() + O00OOOo_O0_O.b("뒕", a_))
		End Function

		' Token: 0x060047F2 RID: 18418 RVA: 0x001E3B20 File Offset: 0x001E1D20
		Private Function <<EMPTY_NAME>>(A_0 As Object, A_1 As String) As Boolean
			Dim a_ As Integer = 12
			If A_0 Is Nothing Then
				Throw New ArgumentNullException(O00OOOo_O0_O.b("ﺛ", a_))
			End If
			If String.IsNullOrEmpty(A_1) Then
				Throw New ArgumentNullException(O00OOOo_O0_O.b("ﾙﮝ캟횡장얧쾩", a_))
			End If
			Dim type As Type = A_0.[GetType]()
			If type.GetEvent(A_1, BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic) Is Nothing Then
				Throw New Exception()
			End If
			Dim fieldInfo As FieldInfo = type.GetField(A_1, BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.NonPublic)
			If fieldInfo Is Nothing Then
				fieldInfo = type.GetField(String.Format(O00OOOo_O0_O.b("ꚙ꺝�鲡", a_), A_1), BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.NonPublic)
				If fieldInfo Is Nothing Then
					For Each fieldInfo2 As FieldInfo In type.GetFields(BindingFlags.Instance Or BindingFlags.[Static] Or BindingFlags.NonPublic)
						If fieldInfo2.Name.Contains(A_1) AndAlso fieldInfo2.FieldType.IsSubclassOf(GetType(MulticastDelegate)) Then
							fieldInfo = fieldInfo2
							Exit For
						End If
					Next
					If fieldInfo Is Nothing Then
						Throw New Exception()
					End If
				End If
			End If
			Dim [delegate] As [Delegate] = TryCast(fieldInfo.GetValue(RuntimeHelpers.GetObjectValue(A_0)), [Delegate])
			If [delegate] IsNot Nothing Then
				For Each delegate2 As [Delegate] In [delegate].GetInvocationList()
				Next
			End If
			Return [delegate] IsNot Nothing
		End Function

		' Token: 0x060047F3 RID: 18419 RVA: 0x001E3C40 File Offset: 0x001E1E40
		Friend Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 4
			If o0OoOOoOOo0.o00__oo.O0Oo0o. IsNot Nothing Then
				If o0OoOOoOOo0.O_0_Oo_00.O.(RuntimeHelpers.GetObjectValue(o0OoOOoOOo0.o00__oo.O0Oo0o.), O00.oO_.0o_oo_0O_.(o0OoOOoOOo0.Oo0.OooO00., O00OOOo_O0_O.b("슑秊ﾙﾛ", a_), O00OOOo_O0_O.b("작�瞧얟", a_))) Then
					Dim sqlcommand As SQLCommand = New SQLCommand()
					sqlcommand.CommandText = String.Concat(New String() { O00OOOo_O0_O.b("�望ﶗ뺝첡킣즥袧", a_), ooO0__OO.oo._O.(), O00OOOo_O0_O.b("쾑뒓뺕쎗풙ﶛ얟ﾡ袣ﶥﲧ펩�쮭麱ﶵ�쎹銽鮿鋁ꗃ듅귇꓉룋藍뗏ꯑ觓ￕ賙뷛닝闟蟡韣컥쿧꟩跫蟭黯등鯳蓵闷�탻", a_), Conversions.ToString(228), O00OOOo_O0_O.b("뺑뎓", a_), OoOo0O.OO_o.0o_O.(8), O00OOOo_O0_O.b("떑뢓놕", a_), OoOo0O.OO_o.0o_O.(8), O00OOOo_O0_O.b("떑붓", a_) })
					Try
						sqlcommand.ExecuteNonQuery()
					Catch ex As Exception
					End Try
				End If
				o0OoOOoOOo0.o00__oo.O0Oo0o. = Nothing
			End If
		End Sub

		' Token: 0x04001D4B RID: 7499
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D4C RID: 7500
		Friend Const <<EMPTY_NAME>> As Double = 80.0

		' Token: 0x04001D4D RID: 7501
		Friend Const <<EMPTY_NAME>> As String = "_SortKey"

		' Token: 0x04001D4E RID: 7502
		Friend Const <<EMPTY_NAME>> As String = "System_Sort_Temporary"

		' Token: 0x04001D4F RID: 7503
		Friend Const <<EMPTY_NAME>> As String = "_Identify"

		' Token: 0x04001D50 RID: 7504
		Friend Const <<EMPTY_NAME>> As String = "System_Filter_Unique"

		' Token: 0x04001D51 RID: 7505
		Friend Const <<EMPTY_NAME>> As String = "_Locked"

		' Token: 0x04001D52 RID: 7506
		Friend Const <<EMPTY_NAME>> As String = "System_Filter_Temporary"

		' Token: 0x04001D53 RID: 7507
		Friend Const <<EMPTY_NAME>> As String = "sys_Hierarchy_Level"

		' Token: 0x04001D54 RID: 7508
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D55 RID: 7509
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D56 RID: 7510
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D57 RID: 7511
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D58 RID: 7512
		Friend <<EMPTY_NAME>> As String()

		' Token: 0x04001D59 RID: 7513
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D5A RID: 7514
		Friend <<EMPTY_NAME>> As Object()

		' Token: 0x04001D5B RID: 7515
		Private <<EMPTY_NAME>> As Assembly

		' Token: 0x04001D5C RID: 7516
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D5D RID: 7517
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D5E RID: 7518
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D5F RID: 7519
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D60 RID: 7520
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D61 RID: 7521
		Friend <<EMPTY_NAME>> As Object
	End Module
End Namespace
