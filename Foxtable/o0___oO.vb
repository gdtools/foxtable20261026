Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001C5 RID: 453
	Friend NotInheritable Module o0___oO
		' Token: 0x06001504 RID: 5380 RVA: 0x00082E84 File Offset: 0x00081084
		Friend Sub <<EMPTY_NAME>>()
			Try
				Dim flag As Boolean = False
				Dim list As List(Of IMClient) = New List(Of IMClient)()
				Dim list2 As List(Of UDPClient) = New List(Of UDPClient)()
				If OO_00oOO.IMServers.Count > 0 Then
					Try
						For Each imserver As IMServer In OO_00oOO.IMServers.Values
							If Not imserver.o0oo__0Oo_.o00. Then
								If imserver.ooO_.O0_..Count > 0 Then
									flag = True
									o0___oO.O.oOo0O0O.(imserver)
								End If
								Dim list3 As List(Of String) = New List(Of String)()
								Dim ooO_.O0_. As Object = imserver.ooO_.O0_.
								SyncLock ooO_.O0_.
									Try
										For Each o_0__O_o_O As O_0__O_o_O In imserver.ooO_.O0_..Values
											If o_0__O_o_O.o_0.Oo_0O0_.() Then
												list3.Add(o_0__O_o_O.O_OO.o0o_o0.())
											End If
										Next
									Finally
										Dim enumerator2 As Dictionary(Of String, O_0__O_o_O).ValueCollection.Enumerator
										CType(enumerator2, IDisposable).Dispose()
									End Try
								End SyncLock
								Try
									For Each key As String In list3
										Dim o_0__O_o_O2 As O_0__O_o_O = imserver.ooO_.O0_.(key)
										If o_0__O_o_O2.o_0.Oo_0O0_.() = SendTypeEnum.AutoFile Then
											Dim afterSendFileEventArgs As AfterSendFileEventArgs = New AfterSendFileEventArgs(o_0__O_o_O2.O._O___O., o_0__O_o_O2.OOOo._0., o_0__O_o_O2.oo0_.O00.())
											O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterSendFile", New Object() { afterSendFileEventArgs }, True, "项目", False)
										End If
									Next
								Finally
									Dim enumerator3 As List(Of String).Enumerator
									CType(enumerator3, IDisposable).Dispose()
								End Try
								Dim ooO_.O0_.2 As Object = imserver.ooO_.O0_.
								SyncLock ooO_.O0_.2
									Try
										For Each key2 As String In list3
											imserver.ooO_.O0_..Remove(key2)
										Next
									Finally
										Dim enumerator4 As List(Of String).Enumerator
										CType(enumerator4, IDisposable).Dispose()
									End Try
								End SyncLock
								list3.Clear()
								Dim ooO_.O0_.3 As Object = imserver.ooO_.O0_.
								SyncLock ooO_.O0_.3
									Try
										For Each ooOoO As ooOoO In imserver.ooO_.O0_..Values
											If ooOoO.OO.000O.() Then
												list3.Add(ooOoO.o0OO._0.())
											End If
										Next
									Finally
										Dim enumerator5 As Dictionary(Of String, ooOoO).ValueCollection.Enumerator
										CType(enumerator5, IDisposable).Dispose()
									End Try
								End SyncLock
								Try
									For Each key3 As String In list3
										Dim ooOoO2 As ooOoO = imserver.ooO_.O0_.(key3)
										If ooOoO2.OO.000O.() = SendTypeEnum.AutoFile Then
											Dim afterReceiveFileEventArgs As AfterReceiveFileEventArgs = New AfterReceiveFileEventArgs(ooOoO2.OO.000O.(), ooOoO2.o_Oo_o._Oo_o_., ooOoO2.O_OOOooo_0.O.())
											O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_AfterReveiveFile", New Object() { afterReceiveFileEventArgs }, True, "项目", False)
										End If
									Next
								Finally
									Dim enumerator6 As List(Of String).Enumerator
									CType(enumerator6, IDisposable).Dispose()
								End Try
								Dim ooO_.O0_.4 As Object = imserver.ooO_.O0_.
								SyncLock ooO_.O0_.4
									Try
										For Each key4 As String In list3
											imserver.ooO_.O0_..Remove(key4)
										Next
									Finally
										Dim enumerator7 As List(Of String).Enumerator
										CType(enumerator7, IDisposable).Dispose()
									End Try
								End SyncLock
								list3.Clear()
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, IMServer).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
				End If
				If OO_00oOO.IMClients.Count > 0 Then
					Try
						For Each imclient As IMClient In OO_00oOO.IMClients.Values
							If Not imclient.O0_OOo.O. Then
								If imclient.ooOo.oO0..Count > 0 Then
									flag = True
									list.Add(imclient)
								End If
								Dim list4 As List(Of String) = New List(Of String)()
								If imclient.oo.___oo__0_O..Count > 0 Then
									Try
										For Each text As String In imclient.oo.___oo__0_O..Keys
											If(imclient.oo.___oo__0_O.(text) - DateTime.Now).TotalSeconds > 30.0 Then
												list4.Add(text)
											End If
										Next
									Finally
										Dim enumerator9 As Dictionary(Of String, DateTime).KeyCollection.Enumerator
										CType(enumerator9, IDisposable).Dispose()
									End Try
								End If
								Try
									For Each key5 As String In list4
										imclient.oo.___oo__0_O..Remove(key5)
									Next
								Finally
									Dim enumerator10 As List(Of String).Enumerator
									CType(enumerator10, IDisposable).Dispose()
								End Try
								list4.Clear()
								Dim ooOooo.oO. As Object = imclient.ooOooo.oO.
								SyncLock ooOooo.oO.
									Try
										For Each o_0__O_o_O3 As O_0__O_o_O In imclient.ooOooo.oO..Values
											If o_0__O_o_O3.o_0.Oo_0O0_.() Then
												list4.Add(o_0__O_o_O3.O_OO.o0o_o0.())
												If o_0__O_o_O3.O00o___0OoO.0. IsNot Nothing AndAlso o_0__O_o_O3.O00o___0OoO.0..FindForm() IsNot Nothing Then
													CType(o_0__O_o_O3.O00o___0OoO.0..FindForm(), o\u3000\u3002\u3000\u3002\u3000).oOOOO.O.(o_0__O_o_O3.O00o___0OoO.0.)
													o_0__O_o_O3.O00o___0OoO.0. = Nothing
												End If
												If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.AutoFile Then
													Dim a_ As String = ""
													If o_0__O_o_O3.o_0.Oo_0O0_.() IsNot Nothing Then
														a_ = o_0__O_o_O3.o_0.Oo_0O0_.().Name
													End If
													Dim afterSendFileEventArgs2 As AfterSendFileEventArgs = New AfterSendFileEventArgs(a_, o_0__O_o_O3.OOOo._0., o_0__O_o_O3.oo0_.O00.())
													afterSendFileEventArgs2.ServerFileName = o_0__O_o_O3.o_OoO._.()
													O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterSendFile", New Object() { afterSendFileEventArgs2 }, True, "项目", False)
												End If
												If(o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile OrElse (o_0__O_o_O3.o_0.Oo_0O0_.() IsNot Nothing AndAlso o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat)) AndAlso OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
													OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
												End If
												If o_0__O_o_O3.oo0_.O00.() Then
													If Operators.CompareString(o_0__O_o_O3.o_OoO._.(), "", True) > 0 Then
														If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.Capture OrElse o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile OrElse (o_0__O_o_O3.o_0.Oo_0O0_.() IsNot Nothing AndAlso o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat) Then
															Dim text2 As String = ""
															If TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is ooo0 Then
																If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.Capture Then
																	text2 = ChrW(2) & "=?" + o_0__O_o_O3.o_OoO._.() + "?="
																ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
																	text2 = String.Concat(New String() { ChrW(2) & "<?", o_0__O_o_O3.o_OoO._.(), vbTab, o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), "?>" })
																End If
																imclient.o00O0._0O.(CType(o_0__O_o_O3.o_0.Oo_0O0_.(), ooo0).Oo_0__o.o.(), text2, False)
															ElseIf TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is O_0OOOoO Then
																If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.Capture Then
																	text2 = ChrW(2) & "=?" + o_0__O_o_O3.o_OoO._.() + "?="
																ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
																	text2 = String.Concat(New String() { ChrW(2) & "<?", o_0__O_o_O3.o_OoO._.(), vbTab, o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), "?>" })
																End If
																imclient.o00O0._0O.(CType(o_0__O_o_O3.o_0.Oo_0O0_.(), O_0OOOoO).O_O0_o._O0o0O.(), text2, False)
															ElseIf o_0__O_o_O3.o_0.Oo_0O0_.().FromWeChat Then
																If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.Capture Then
																	text2 = "={" & ChrW(2) & "=?" + o_0__O_o_O3.o_OoO._.() + "?=}="
																ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
																	text2 = "={" & ChrW(2) & "<?" + o_0__O_o_O3.o_OoO._.() + "?>}="
																Else
																	text2 = ChrW(2) & "<?" + o_0__O_o_O3.o_OoO._.() + "?>"
																End If
																imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, True, False)
															Else
																If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.Capture Then
																	text2 = "={" & ChrW(2) & "=?" + o_0__O_o_O3.o_OoO._.() + "?=}="
																ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
																	text2 = String.Concat(New String() { "={" & ChrW(2) & "<?", o_0__O_o_O3.o_OoO._.(), vbTab, o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), "?>}=" })
																End If
																If o_0__O_o_O3.o_0.Oo_0O0_.().OnLine Then
																	imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, True, False)
																End If
																imclient.Send(o_0__O_o_O3.o_0.Oo_0O0_.().Name, text2, True, True)
															End If
															If o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
																If TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is ooo0 OrElse TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is O_0OOOoO Then
																	Dim a_2 As String = String.Concat(New String() { ChrW(2) & "[我方成功上传文件""", OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.), """(", o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), ")]" & ChrW(2) })
																	imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_2, 2, 1, imclient.UserName)
																	If TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is ooo0 Then
																		imclient.O.00O0_O_o_oO.(CType(o_0__O_o_O3.o_0.Oo_0O0_.(), ooo0).Oo_0__o.o.(), text2, 2, 1, imclient.UserName)
																	ElseIf TypeOf o_0__O_o_O3.o_0.Oo_0O0_.()Is O_0OOOoO Then
																		imclient.O.00O0_O_o_oO.(CType(o_0__O_o_O3.o_0.Oo_0O0_.(), O_0OOOoO).O_O0_o._O0o0O.(), text2, 2, 1, imclient.UserName)
																	End If
																Else
																	Dim a_3 As String = String.Concat(New String() { ChrW(2) & "[我方成功离线发送文件""", OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.), """(", o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), ")]" & ChrW(2) })
																	imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_3, 2, 1, Nothing)
																End If
															End If
														End If
													ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile Then
														Dim a_4 As String = String.Concat(New String() { ChrW(2) & "[我方成功发送文件""", OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.), """(", o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), ")]" & ChrW(2) })
														imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_4, 2, 1, Nothing)
													End If
												ElseIf o_0__O_o_O3.o_0.Oo_0O0_.() = SendTypeEnum.ManualFile AndAlso o_0__O_o_O3.O._O___O. Then
													Dim a_5 As String = String.Concat(New String() { ChrW(2) & "{因网络问题，文件发送失败""", OO_00oOO.FileSys.GetName(o_0__O_o_O3.OOOo._0.), """(", o0___oO.o0__.0.(o_0__O_o_O3.Oo.Oo0.), ")}" & ChrW(2) })
													imclient.O.00O0_O_o_oO.(o0___oO.o0__.0.(o_0__O_o_O3.o_0.Oo_0O0_.()), a_5, 2, 1, Nothing)
												End If
											End If
										Next
									Finally
										Dim enumerator11 As Dictionary(Of String, O_0__O_o_O).ValueCollection.Enumerator
										CType(enumerator11, IDisposable).Dispose()
									End Try
								End SyncLock
								Try
									For Each key6 As String In list4
										imclient.ooOooo.oO..Remove(key6)
									Next
								Finally
									Dim enumerator12 As List(Of String).Enumerator
									CType(enumerator12, IDisposable).Dispose()
								End Try
								list4.Clear()
								Dim ooOooo.oO.2 As Object = imclient.ooOooo.oO.
								SyncLock ooOooo.oO.2
									Try
										For Each ooOoO3 As ooOoO In imclient.ooOooo.oO..Values
											If ooOoO3.OO.000O.() Then
												list4.Add(ooOoO3.o0OO._0.())
												If ooOoO3.O0__00OoOo_O.o. IsNot Nothing AndAlso ooOoO3.O0__00OoOo_O.o..FindForm() IsNot Nothing Then
													CType(ooOoO3.O0__00OoOo_O.o..FindForm(), o\u3000\u3002\u3000\u3002\u3000).oOOOO.O.(ooOoO3.O0__00OoOo_O.o.)
													ooOoO3.O0__00OoOo_O.o. = Nothing
												End If
												If ooOoO3.OO.000O.() = SendTypeEnum.AutoFile Then
													Dim afterReceiveFileEventArgs2 As AfterReceiveFileEventArgs = New AfterReceiveFileEventArgs(ooOoO3.OO.000O.(), ooOoO3.o_Oo_o._Oo_o_., ooOoO3.O_OOOooo_0.O.())
													O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_AfterReveiveFile", New Object() { afterReceiveFileEventArgs2 }, True, "项目", False)
												End If
												If(ooOoO3.OO.000O.() = SendTypeEnum.ManualFile OrElse ooOoO3.OO.000O.() = SendTypeEnum.Capture) AndAlso OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
													OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
												End If
												If ooOoO3.OO.000O.() = SendTypeEnum.Capture Then
													Dim text3 As String
													Dim text4 As String
													If ooOoO3.O_OOOooo_0.O.() Then
														text3 = ooOoO3.o_Oo_o._Oo_o_.
														text4 = ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\").Length)
														text4 = ChrW(2) & "=(" + text4 + ")="
													Else
														text3 = "fail.png"
														text4 = ChrW(2) & "=(fail.png)="
													End If
													If ooOoO3.OO.000O.() Is Nothing Then
														imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text4, 1, 0, Nothing)
													Else
														If ooOoO3.OO.000O.().RowState = DataRowState.Detached Then
															New OleDbCommand("Update  [Messages]  set [Content] = '" + text4 + "' Where [_Identify] = " + ooOoO3.OO.000O.()("_Identify").ToString(), imclient.oOO0O.O0O0.).ExecuteNonQuery()
														Else
															ooOoO3.OO.000O.().RowError = Nothing
															ooOoO3.OO.000O.()("Content") = text4
															imclient.oOOOo0.oo0OoO0..Update(New DataRow() { ooOoO3.OO.000O.() })
														End If
														If imclient.ooOooo.oO. IsNot Nothing AndAlso imclient.ooOooo.oO..Oo0_O0o.o_. Then
															For Each oo0O As Oo0O In New Oo0O() { imclient.ooOooo.oO..O_0oOOO_.OO.(), imclient.ooOooo.oO..Oo.Oo00__oooo.() }
																If oo0O.Tag IsNot Nothing Then
																	Dim dictionary As Dictionary(Of Integer, Integer) = CType(oo0O.Tag, Dictionary(Of Integer, Integer))
																	Dim key7 As Integer = Conversions.ToInteger(ooOoO3.OO.000O.()("_Identify"))
																	If dictionary.ContainsKey(key7) Then
																		Dim num As Integer = dictionary(key7)
																		dictionary.Remove(key7)
																		oo0O(num, 1) = Nothing
																		oo0O.SetCellImage(num, 1, OO_00oOO.GetImage(text3))
																		oo0O.AutoSizeRow(num)
																		oo0O.O000.o..Add(num, text3)
																	End If
																End If
															Next
														End If
													End If
												Else
													If ooOoO3.OO.000O.() IsNot Nothing Then
														Dim item As Integer = Conversions.ToInteger(ooOoO3.OO.000O.()("_Identify"))
														Dim oOO0_O.O__0_0. As Object = imclient.oOO0_O.O__0_0.
														SyncLock oOO0_O.O__0_0.
															If imclient.oOO0_O.O__0_0..Contains(item) Then
																imclient.oOO0_O.O__0_0..Remove(item)
															End If
														End SyncLock
													End If
													If ooOoO3.OO.000O.() = SendTypeEnum.ManualFile Then
														If Not ooOoO3.O_OOOooo_0.O.() Then
															If ooOoO3.Oo0___._oooo_O. Then
																If ooOoO3.OO.000O.() Is Nothing Then
																	Dim text5 As String = String.Concat(New String() { ChrW(2) & "{因网络问题，文件接收失败""", OO_00oOO.FileSys.GetName(ooOoO3.o_Oo_o._Oo_o_.), """(", o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.), ")}" & ChrW(2) })
																	imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text5, 2, 1, Nothing)
																Else
																	Dim text5 As String = ooOoO3.OO.000O.()("Content").ToString()
																	text5 = text5.Substring(3, text5.Length - 5)
																	Dim array2 As String() = text5.Split(New Char() { vbTab })
																	text5 = String.Concat(New String() { ChrW(2) & "<?", array2(0), vbTab, array2(1), vbTab, Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss"), "?>" })
																	ooOoO3.OO.000O.()("Content") = text5
																	imclient.oOOOo0.oo0OoO0..Update(New DataRow() { ooOoO3.OO.000O.() })
																End If
															End If
														ElseIf ooOoO3.OO.000O.() Is Nothing Then
															Dim text6 As String = ChrW(2) & "[我方成功接收文件]" & ChrW(2)
															imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text6, 2, 1, Nothing)
															text6 = ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\").Length) + vbTab + o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.)
															text6 = ChrW(2) & "<" + text6 + ">" & ChrW(2)
															imclient.O.00O0_O_o_oO.(ooOoO3.OO.000O.(), text6, 2, 0, Nothing)
														Else
															Dim text7 As String = String.Concat(New String() { ooOoO3.o_Oo_o._Oo_o_..Substring((OO_00oOO.ProjectPath + "QQClient\ReceivedFiles\").Length), vbTab, o0___oO.o0__.0.(ooOoO3.oOoo_oo0o_._0.), vbTab, Strings.Format(DateTime.Now, "MM/dd/yyyy HH:mm:ss") })
															text7 = ChrW(2) & "|" + text7 + "|" & ChrW(2)
															ooOoO3.OO.000O.()("Content") = text7
															imclient.oOOOo0.oo0OoO0..Update(New DataRow() { ooOoO3.OO.000O.() })
														End If
													End If
													If ooOoO3.OO.000O.() IsNot Nothing AndAlso imclient.ooOooo.oO. IsNot Nothing AndAlso imclient.ooOooo.oO..Oo0_O0o.o_. Then
														For Each oo0O2 As Oo0O In New Oo0O() { imclient.ooOooo.oO..O_0oOOO_.OO.(), imclient.ooOooo.oO..Oo.Oo00__oooo.() }
															Try
																For Each num2 As Integer In oo0O2.oOO00oo.O..Keys
																	If Conversions.ToInteger(oo0O2.oOO00oo.O.(num2)("_Identify")) = Conversions.ToInteger(ooOoO3.OO.000O.()("_Identify")) Then
																		If oo0O2.oOO00oo.O.(num2) IsNot ooOoO3.OO.000O.() Then
																			oo0O2.oOO00oo.O.(num2)("Content") = RuntimeHelpers.GetObjectValue(ooOoO3.OO.000O.()("Content"))
																		End If
																		Dim text8 As String = ooOoO3.OO.000O.()("Content").ToString()
																		If ooOoO3.O_OOOooo_0.O.() Then
																			text8 = text8.Substring(2, text8.Length - 4)
																		Else
																			text8 = text8.Substring(3, text8.Length - 5)
																		End If
																		Dim array4 As String() = text8.Split(New Char() { vbTab })
																		text8 = array4(0) + vbCrLf + OO_00oOO.FileSys.GetName(array4(1))
																		If array4.Length = 3 Then
																			If ooOoO3.O_OOOooo_0.O.() Then
																				text8 = text8 + vbCrLf + Strings.Format(Conversions.ToDate(array4(2)), "yyyy年MM月dd日 HH:mm:ss") + "下载成功!"
																			Else
																				text8 = text8 + vbCrLf + Strings.Format(Conversions.ToDate(array4(2)), "yyyy年MM月dd日 HH:mm:ss") + "下载失败!"
																			End If
																		End If
																		oo0O2(num2, 1) = text8
																		oo0O2.AutoSizeRow(num2)
																		If ooOoO3.O_OOOooo_0.O.() Then
																			If Not oo0O2.O000.o..ContainsKey(num2) Then
																				oo0O2.O000.o..Add(num2, ooOoO3.OO.000O.())
																			End If
																			If oo0O2.oOO00oo.O..ContainsKey(num2) Then
																				oo0O2.oOO00oo.O..Remove(num2)
																			End If
																		End If
																		If Not imclient.ooOooo.oO..o_oO__.0.().Visible OrElse imclient.ooOooo.oO..o_oO__.0.().Parent IsNot oo0O2 OrElse Conversions.ToInteger(imclient.ooOooo.oO..o_oO__.0.().Tag) <> num2 Then
																			Exit For
																		End If
																		If ooOoO3.O_OOOooo_0.O.() Then
																			imclient.ooOooo.oO..o_oO__.0.().Visible = False
																			Dim x As Integer = oo0O2.Width - imclient.ooOooo.oO..o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
																			Dim y As Integer = oo0O2.Rows(num2).Bottom - imclient.ooOooo.oO..o.0_o0_00.().Height + oo0O2.ScrollPosition.Y
																			imclient.ooOooo.oO..o.0_o0_00.().Visible = True
																			imclient.ooOooo.oO..o.0_o0_00.().Location = New Point(x, y)
																			imclient.ooOooo.oO..o.0_o0_00.().Tag = num2
																			imclient.ooOooo.oO..o.0_o0_00.().Anchor = AnchorStyles.Right
																			oo0O2.Controls.Add(imclient.ooOooo.oO..o.0_o0_00.())
																			Exit For
																		End If
																		imclient.ooOooo.oO..O_o._o0___.().Text = "下载"
																		Dim x2 As Integer = oo0O2.Width - imclient.ooOooo.oO..o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible = ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0))
																		Dim y2 As Integer = oo0O2.Rows(num2).Bottom - imclient.ooOooo.oO..o_oO__.0.().Height + oo0O2.ScrollPosition.Y
																		imclient.ooOooo.oO..o_oO__.0.().Location = New Point(x2, y2)
																		Exit For
																	End If
																Next
															Finally
																Dim enumerator14 As Dictionary(Of Integer, DataRow).KeyCollection.Enumerator
																CType(enumerator14, IDisposable).Dispose()
															End Try
														Next
													End If
												End If
											End If
										Next
									Finally
										Dim enumerator13 As Dictionary(Of String, ooOoO).ValueCollection.Enumerator
										CType(enumerator13, IDisposable).Dispose()
									End Try
									Try
										For Each key8 As String In list4
											imclient.ooOooo.oO..Remove(key8)
										Next
									Finally
										Dim enumerator15 As List(Of String).Enumerator
										CType(enumerator15, IDisposable).Dispose()
									End Try
									list4.Clear()
								End SyncLock
							End If
						Next
					Finally
						Dim enumerator8 As Dictionary(Of String, IMClient).ValueCollection.Enumerator
						CType(enumerator8, IDisposable).Dispose()
					End Try
				End If
				If OO_00oOO.UDPClients.Count > 0 Then
					Try
						For Each udpclient As UDPClient In OO_00oOO.UDPClients.Values
							If Not udpclient.O00ooo._. AndAlso udpclient.O00ooo._..Count > 0 Then
								flag = True
								list2.Add(udpclient)
							End If
						Next
					Finally
						Dim enumerator16 As Dictionary(Of String, UDPClient).ValueCollection.Enumerator
						CType(enumerator16, IDisposable).Dispose()
					End Try
				End If
				Try
					For Each a_6 As IMClient In list
						o0___oO.O.oOo0O0O.(a_6)
					Next
				Finally
					Dim enumerator17 As List(Of IMClient).Enumerator
					CType(enumerator17, IDisposable).Dispose()
				End Try
				Try
					For Each a_7 As UDPClient In list2
						o0___oO.O.oOo0O0O.(a_7)
					Next
				Finally
					Dim enumerator18 As List(Of UDPClient).Enumerator
					CType(enumerator18, IDisposable).Dispose()
				End Try
				If Not flag Then
					o0___oO.O.oOo0O0O.()
				End If
			Catch a_8 As Exception
				ooO.oOo0Oo.o.(a_8, "")
			End Try
		End Sub

		' Token: 0x06001505 RID: 5381 RVA: 0x0008480C File Offset: 0x00082A0C
		Private Sub <<EMPTY_NAME>>()
			If OO_00oOO.IMServers.Count > 0 Then
				Dim list As List(Of IMUser) = New List(Of IMUser)()
				Try
					For Each imserver As IMServer In OO_00oOO.IMServers.Values
						If Not imserver.o0oo__0Oo_.o00. AndAlso imserver.MonitorHeartbeat Then
							Try
								For Each imuser As IMUser In imserver.Users
									If(DateTime.Now - imuser.LastHeartbeatTime).TotalSeconds > CDbl(imserver.HeartbeatTimeout) Then
										list.Add(imuser)
										Dim server_UserLogoutEventArgs As Server_UserLogoutEventArgs = New Server_UserLogoutEventArgs(imuser.Name, imserver, 3)
										O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", New Object() { server_UserLogoutEventArgs }, True, "项目", False)
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator(Of IMUser)
								If enumerator2 IsNot Nothing Then
									enumerator2.Dispose()
								End If
							End Try
							Try
								For Each a_ As IMUser In list
									imserver.Users.o_.oOoo_0.(a_)
								Next
							Finally
								Dim enumerator3 As List(Of IMUser).Enumerator
								CType(enumerator3, IDisposable).Dispose()
							End Try
							Try
								For Each imuser2 As IMUser In list
									Dim s As String = "!3" & vbVerticalTab + imuser2.Name + vbVerticalTab + imuser2.OO__o_.O0_0O_0.
									Dim bytes As Byte() = Encoding.Unicode.GetBytes(s)
									Try
										For Each name As String In imuser2.Buddies
											If imserver.Users.Contains(name) AndAlso imserver.Users(name).Buddies.Contains(imuser2.Name) Then
												imserver.ooO_.O0_..Send(bytes, bytes.Length, imserver.Users(name).WanIP)
											End If
										Next
									Finally
										Dim enumerator5 As List(Of String).Enumerator
										CType(enumerator5, IDisposable).Dispose()
									End Try
								Next
							Finally
								Dim enumerator4 As List(Of IMUser).Enumerator
								CType(enumerator4, IDisposable).Dispose()
							End Try
						End If
					Next
				Finally
					Dim enumerator As Dictionary(Of String, IMServer).ValueCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
			End If
			If OO_00oOO.IMClients.Count > 0 Then
				Dim list2 As List(Of IMClient) = New List(Of IMClient)()
				Try
					For Each imclient As IMClient In OO_00oOO.IMClients.Values
						If Not imclient.O0_OOo.O. AndAlso imclient.Ready AndAlso imclient.Heartbeat Then
							If Not imclient.o_oo0.O0Oo__oO. AndAlso (DateTime.Now - imclient.O00._Oo.).TotalSeconds > 2.0 Then
								Dim a_2 As String = "=@" & vbVerticalTab + imclient.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
								imclient.O.00O0_O_o_oO.(imclient.ooOo.oO0., a_2)
								imclient.o_oo0.O0Oo__oO. = True
							End If
							If(DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > CDbl(imclient.HeartbeatTimeout) Then
								Dim client_LogoutEventArgs As Client_LogoutEventArgs = New Client_LogoutEventArgs(imclient, 3)
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", New Object() { client_LogoutEventArgs }, True, "项目", False)
								list2.Add(imclient)
							ElseIf(DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > CDbl((imclient.HeartbeatInterval + 5)) Then
								If Not imclient.Oo0__0.ooO0__o. Then
									imclient.Oo0__0.ooO0__o. = True
									Dim s2 As String = "#" & vbVerticalTab + SysInfo.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
									Dim bytes2 As Byte() = Encoding.Unicode.GetBytes(s2)
									imclient.ooOo.oO0..Send(bytes2, bytes2.Length, imclient.ooOo.oO0.)
								End If
							ElseIf(DateTime.Now - imclient.LastReceiveHeartbeatTime).TotalSeconds > CDbl((imclient.HeartbeatInterval + 10)) AndAlso Not imclient.O0O.Oo_. Then
								imclient.O0O.Oo_. = True
								Dim s3 As String = "#" & vbVerticalTab + SysInfo.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
								Dim bytes3 As Byte() = Encoding.Unicode.GetBytes(s3)
								imclient.ooOo.oO0..Send(bytes3, bytes3.Length, imclient.ooOo.oO0.)
							End If
							Try
								For Each key As Integer In imclient.ooOo.oO0..Keys
									If(DateTime.Now - imclient.ooOo.oO0.(key).ooO.o_Oo.).TotalSeconds > 5.0 Then
										Dim o0o As O0o000 = imclient.ooOo.oO0.(key)
										imclient.O.00O0_O_o_oO.(o0o.Oo0O0.o..Name, ChrW(2) & "/" + o0o.ooO.o_Oo. + "\" & ChrW(2), 1, 1, Nothing)
										imclient.ooOo.oO0..Remove(key)
										If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
											OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
											Exit For
										End If
										Exit For
									End If
								Next
							Finally
								Dim enumerator7 As Dictionary(Of Integer, O0o000).KeyCollection.Enumerator
								CType(enumerator7, IDisposable).Dispose()
							End Try
							Try
								For Each imbuddy As IMBuddy In imclient.Buddies
									If imbuddy.OnLine Then
										If(DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > CDbl(imclient.HeartbeatTimeout) Then
											imbuddy.oOo.o0__0Oo0oO. = 0
											imbuddy.O00OO.o_. = 0
										ElseIf(DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > CDbl((imclient.HeartbeatTimeout + 5)) Then
											If Not imbuddy.O00OO.o_. Then
												imbuddy.O00OO.o_. = True
												Dim s4 As String = "#1" & vbVerticalTab + SysInfo.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
												Dim bytes4 As Byte() = Encoding.Unicode.GetBytes(s4)
												imclient.ooOo.oO0..Send(bytes4, bytes4.Length, imbuddy.WanIP)
											End If
										ElseIf(DateTime.Now - imbuddy.LastReceiveHeartbeatTime).TotalSeconds > CDbl((imclient.HeartbeatTimeout + 10)) AndAlso Not imbuddy.oO0.OooOOO00. Then
											imbuddy.oO0.OooOOO00. = True
											Dim s5 As String = "#1" & vbVerticalTab + SysInfo.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
											Dim bytes5 As Byte() = Encoding.Unicode.GetBytes(s5)
											imclient.ooOo.oO0..Send(bytes5, bytes5.Length, imbuddy.WanIP)
										End If
										If Not imbuddy.oo.0o_0O0_0. AndAlso (DateTime.Now - imbuddy.O00OO.o_.).TotalSeconds > 10.0 Then
											imbuddy.oo.0o_0O0_0. = True
											Dim s6 As String = "#1" & vbVerticalTab + SysInfo.UserName + vbVerticalTab + imclient.o_oo0Oooo.OOO_.
											Dim bytes6 As Byte() = Encoding.Unicode.GetBytes(s6)
											imclient.ooOo.oO0..Send(bytes6, bytes6.Length, imbuddy.WanIP)
										End If
									End If
								Next
							Finally
								Dim enumerator8 As IEnumerator(Of IMBuddy)
								If enumerator8 IsNot Nothing Then
									enumerator8.Dispose()
								End If
							End Try
						End If
					Next
				Finally
					Dim enumerator6 As Dictionary(Of String, IMClient).ValueCollection.Enumerator
					CType(enumerator6, IDisposable).Dispose()
				End Try
				Try
					For Each imclient2 As IMClient In list2
						Dim oO_u3000_u3002_u3002_u3000O_u As oO\u3000\u3002\u3002\u3000O\u3000 = New oO\u3000\u3002\u3002\u3000O\u3000(imclient2, imclient2.ooOo.oO0.)
						oO_u3000_u3002_u3002_u3000O_u.O_.0OOOOO0o0.().Text = "因为心跳超时,OpenQQ失去连接。"
						imclient2.dispose()
						oO_u3000_u3002_u3002_u3000O_u.Show()
					Next
				Finally
					Dim enumerator9 As List(Of IMClient).Enumerator
					CType(enumerator9, IDisposable).Dispose()
				End Try
			End If
		End Sub

		' Token: 0x06001506 RID: 5382 RVA: 0x0008507C File Offset: 0x0008327C
		Private Sub <<EMPTY_NAME>>(A_0 As IMServer)
			Dim oO__oO_0_O As oO__oO_0_O = Nothing
			Dim ooO_.O0_. As Object = A_0.ooO_.O0_.
			SyncLock ooO_.O0_.
				If A_0.ooO_.O0_..Count > 0 Then
					oO__oO_0_O = A_0.ooO_.O0_..Dequeue()
				End If
			End SyncLock
			If oO__oO_0_O IsNot Nothing Then
				Dim array As String() = oO__oO_0_O.Oo0oo._.().Split(New Char() { vbVerticalTab })
				If array.Length = 5 AndAlso (Operators.CompareString(array(0), "@", True) = 0 OrElse Operators.CompareString(array(0), "@1", True) = 0) Then
					Dim flag2 As Boolean
					If Not o0OO__.OO0oO.o.() AndAlso A_0.Users.Count >= 20 Then
						A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), O00.DecryptText(o0___oO.o_o.__OO00O., "my", "fox"))
						flag2 = True
					End If
					If A_0.Users.Count >= 30000 Then
						A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), O00.DecryptText("wrHFS8arXitNj8TCWH3qKdqJLP7LcUd5czaICHqnVRs5a3tbOpT8fw==", "fox", "table"))
						flag2 = True
					End If
					Dim server_UserLoggingEventArgs As Server_UserLoggingEventArgs = New Server_UserLoggingEventArgs(array(1), array(2), A_0, oO__oO_0_O, array)
					If Not flag2 Then
						If Operators.CompareString(array(0), "@1", True) = 0 Then
							server_UserLoggingEventArgs.BuildIn = True
						End If
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogging", New Object() { server_UserLoggingEventArgs }, True, "项目", False)
					End If
					If Not server_UserLoggingEventArgs.AsyncExecute Then
						o0___oO.O.oOo0O0O.(A_0, server_UserLoggingEventArgs, oO__oO_0_O, array)
					End If
				Else
					If array.Length = 3 AndAlso Operators.CompareString(array(0), "+@", True) = 0 Then
						If Not A_0.Users.Contains(array(1)) OrElse Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) <> 0 Then
							GoTo IL_A0E
						End If
						Dim server_UserEventArgs As Server_UserEventArgs = New Server_UserEventArgs(array(1), A_0)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogged", New Object() { server_UserEventArgs }, True, "项目", False)
						Dim imuser As IMUser = A_0.Users(array(1))
						Try
							For Each text As String In A_0.Users(array(1)).Buddies
								If A_0.Users.Contains(text) AndAlso A_0.Users(text).Buddies.Contains(array(1)) Then
									A_0.oOOOo._.(text, String.Concat(New String() { "@" & vbVerticalTab, array(1), vbVerticalTab, A_0.Users(text).OO__o_.O0_0O_0., vbVerticalTab, imuser.WanIP.ToString(), vbVerticalTab, imuser.OO__o_.O0_0O_0., vbVerticalTab, imuser.LanIPAddress }))
								End If
							Next
							GoTo IL_A0E
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
					End If
					If array.Length = 3 AndAlso Operators.CompareString(array(0), "-@", True) = 0 Then
						If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) = 0 Then
							A_0.Users.o_.oOoo_0.(array(1))
						End If
					Else
						If array.Length = 3 AndAlso Operators.CompareString(array(0), "=@", True) = 0 Then
							Dim imuser2 As IMUser = A_0.Users(array(1))
							Try
								For Each text2 As String In A_0.Users(array(1)).Buddies
									If A_0.Users.Contains(text2) AndAlso A_0.Users(text2).Buddies.Contains(array(1)) Then
										A_0.oOOOo._.(text2, String.Concat(New String() { "@" & vbVerticalTab, array(1), vbVerticalTab, A_0.Users(text2).OO__o_.O0_0O_0., vbVerticalTab, imuser2.WanIP.ToString(), vbVerticalTab, imuser2.OO__o_.O0_0O_0., vbVerticalTab, imuser2.LanIPAddress }))
									End If
								Next
								GoTo IL_A0E
							Finally
								Dim enumerator2 As List(Of String).Enumerator
								CType(enumerator2, IDisposable).Dispose()
							End Try
						End If
						If array.Length = 3 AndAlso Operators.CompareString(array(0), "!1", True) = 0 Then
							If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) = 0 Then
								Try
									For Each text3 As String In A_0.Users(array(1)).Buddies
										If A_0.Users.Contains(text3) AndAlso A_0.Users(text3).Buddies.Contains(array(1)) Then
											A_0.oOOOo._.(text3, oO__oO_0_O.Oo0oo._.())
										End If
									Next
								Finally
									Dim enumerator3 As List(Of String).Enumerator
									CType(enumerator3, IDisposable).Dispose()
								End Try
								A_0.Users.o_.oOoo_0.(array(1))
								Dim server_UserLogoutEventArgs As Server_UserLogoutEventArgs = New Server_UserLogoutEventArgs(array(1), A_0, 1)
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", New Object() { server_UserLogoutEventArgs }, True, "项目", False)
							End If
						ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "^", True) = 0 Then
							If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) = 0 Then
								Dim [object] As o0___oO.oooO0 = New o0___oO.oooO0(array, A_0, oO__oO_0_O)
								AddressOf [object].o_o.__OO00O..Start()
							End If
						ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "+$", True) = 0 Then
							If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) = 0 Then
								Dim object2 As o0___oO.o_O__o_o_o = New o0___oO.o_O__o_o_o(A_0, array(1), oO__oO_0_O.Oo0oo._.())
								AddressOf object2.o_o.__OO00O..Start()
							End If
						Else
							If array.Length = 2 AndAlso Operators.CompareString(array(0), "%5", True) = 0 Then
								Dim ooO_.O0_.2 As Object = A_0.ooO_.O0_.
								SyncLock ooO_.O0_.2
									Try
										For Each o_0__O_o_O As O_0__O_o_O In A_0.ooO_.O0_..Values
											If Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), array(1), True) = 0 Then
												o_0__O_o_O.O0.0O0o_O. = True
												Exit For
											End If
										Next
									Finally
										Dim enumerator4 As Dictionary(Of String, O_0__O_o_O).ValueCollection.Enumerator
										CType(enumerator4, IDisposable).Dispose()
									End Try
								End SyncLock
								Dim ooO_.O0_.3 As Object = A_0.ooO_.O0_.
								SyncLock ooO_.O0_.3
									Try
										For Each ooOoO As ooOoO In A_0.ooO_.O0_..Values
											If Operators.CompareString(ooOoO.o0OO._0.(), array(1), True) = 0 Then
												ooOoO.ooo0_.o__. = True
												Exit For
											End If
										Next
										GoTo IL_A0E
									Finally
										Dim enumerator5 As Dictionary(Of String, ooOoO).ValueCollection.Enumerator
										CType(enumerator5, IDisposable).Dispose()
									End Try
								End SyncLock
							End If
							If array.Length = 5 AndAlso Operators.CompareString(array(0), ".", True) = 0 Then
								If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(2), True) = 0 Then
									Dim server_ChangeUserPasswordEventArgs As Server_ChangeUserPasswordEventArgs = New Server_ChangeUserPasswordEventArgs(array(1), A_0, array(3), array(4), oO__oO_0_O)
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserChangePassword", New Object() { server_ChangeUserPasswordEventArgs }, True, "项目", False)
									If Operators.CompareString(server_ChangeUserPasswordEventArgs.ReturnMessage, "", True) > 0 Then
										A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), server_ChangeUserPasswordEventArgs.ReturnMessage)
									End If
								End If
							ElseIf array.Length = 4 AndAlso Operators.CompareString(array(0), "$", True) = 0 Then
								If A_0.Users.Contains(array(1)) AndAlso Operators.CompareString(A_0.Users(array(1)).OO__o_.O0_0O_0., array(3), True) = 0 Then
									Dim server_MessageEventargs As Server_MessageEventargs = New Server_MessageEventargs(A_0, array(1), array(2), oO__oO_0_O, array)
									O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_ReceivedMessage", New Object() { server_MessageEventargs }, True, "项目", False)
									If Not server_MessageEventargs.AsyncExecute AndAlso Operators.CompareString(server_MessageEventargs.ReturnValue, "", True) > 0 Then
										Dim a_ As String = "$" & vbVerticalTab & vbVerticalTab + server_MessageEventargs.ReturnValue + vbVerticalTab + array(3)
										A_0.O0o_.Oo0oo.(oO__oO_0_O.Oo0oo._.(), a_)
									End If
								End If
							ElseIf array.Length = 5 AndAlso Operators.CompareString(array(0), "=$", True) = 0 AndAlso A_0.Users.Contains(array(2)) AndAlso Operators.CompareString(A_0.Users(array(2)).OO__o_.O0_0O_0., array(4), True) = 0 Then
								array(1).Trim(New Char() { """"c })
								Dim a_2 As Boolean
								If array(3).StartsWith("={") AndAlso array(3).EndsWith("}=") Then
									a_2 = True
									array(3) = array(3).Substring(2, array(3).Length - 4)
								End If
								Dim a_3 As Integer
								If array(3).StartsWith(ChrW(2) & "=?") AndAlso array(3).EndsWith("?=") Then
									a_3 = 1
									array(3) = array(3).Substring(3, array(3).Length - 5)
								ElseIf array(3).StartsWith(ChrW(2) & "<?") AndAlso array(3).EndsWith("?>") Then
									a_3 = 2
									array(3) = array(3).Substring(3, array(3).Length - 5)
								End If
								Dim weChatMessageReceived As WeChatMessageReceived = New WeChatMessageReceived(A_0, array(2), array(1), array(3), a_3, a_2)
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_WeMessageReceived", New Object() { weChatMessageReceived }, True, "项目", False)
							End If
						End If
					End If
				End If
				IL_A0E:
				If A_0.ooO_.O0_..Count > 0 Then
					o0___oO.O.oOo0O0O.(A_0)
				End If
			End If
		End Sub

		' Token: 0x06001507 RID: 5383 RVA: 0x00085B10 File Offset: 0x00083D10
		Friend Sub <<EMPTY_NAME>>(A_0 As IMServer, A_1 As Server_UserLoggingEventArgs, A_2 As oO__oO_0_O, A_3 As String())
			If A_1.Success Then
				If A_1.Buddies.Count > 500 Then
					A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), O00.DecryptText("sIAeellQZKFEKq5D6slLtIZlvAuH2x6+wZg3O0lan8E=", "fox", "table"))
					Return
				End If
				If A_0.Users.Contains(A_3(1)) Then
					A_0.oOOOo._.(A_3(1), "&2" & vbVerticalTab + A_3(1) + vbVerticalTab + A_0.Users(A_3(1)).OO__o_.O0_0O_0.)
					Dim server_UserLogoutEventArgs As Server_UserLogoutEventArgs = New Server_UserLogoutEventArgs(A_3(1), A_0, 4)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Server_UserLogout", New Object() { server_UserLogoutEventArgs }, True, "项目", False)
					A_0.Users.o_.oOoo_0.(A_3(1))
				End If
				A_0.Users.OO__o_.O0_0O_0.(New IMUser(A_3(1), A_2.Oo0oo._.()))
				A_0.Users(A_3(1)).OO__o_.O0_0O_0. = A_3(3)
				A_0.Users(A_3(1)).Buddies.AddRange(A_1.Buddies)
				If Operators.CompareString(A_3(4), "None", True) <> 0 Then
					A_0.Users(A_3(1)).LanIP = o0___oO.o0__.0.(A_3(4))
				End If
				A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), String.Concat(New String() { A_3(1), vbVerticalTab, A_1.Message, vbVerticalTab, Interaction.IIf(A_0.MonitorHeartbeat, 1, 0).ToString(), vbVerticalTab, Conversions.ToString(A_0.HeartbeatInterval), vbVerticalTab, Conversions.ToString(A_0.HeartbeatTimeout), vbVerticalTab, A_2.Oo0oo._.().ToString(), vbVerticalTab, Conversions.ToString(A_1.Buddies.Count) }))
				Return
			Else
				If Operators.CompareString(A_1.Message, "", True) > 0 Then
					A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), A_1.Message)
					Return
				End If
				A_0.O0o_.Oo0oo.(A_2.Oo0oo._.(), "未知错误")
				Return
			End If
		End Sub

		' Token: 0x06001508 RID: 5384 RVA: 0x00085D3C File Offset: 0x00083F3C
		Private Sub <<EMPTY_NAME>>(A_0 As IMClient)
			Dim oO__oO_0_O As oO__oO_0_O = Nothing
			Dim ooOo.oO0. As Object = A_0.ooOo.oO0.
			SyncLock ooOo.oO0.
				If A_0.ooOo.oO0..Count > 0 Then
					oO__oO_0_O = A_0.ooOo.oO0..Dequeue()
				End If
			End SyncLock
			If oO__oO_0_O IsNot Nothing Then
				Dim array As String() = oO__oO_0_O.Oo0oo._.().Split(New Char() { vbVerticalTab })
				If array.Length = 6 AndAlso Operators.CompareString(array(0), "@", True) = 0 AndAlso Operators.CompareString(array(2), A_0.o_oo0Oooo.OOO_., True) = 0 Then
					If A_0.Buddies.Contains(array(1)) AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(4), True) <> 0 AndAlso Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), True) = 0 Then
						If A_0.Buddies(array(1)).OnLine Then
							Dim client_BuddyLogoutEventArgs As Client_BuddyLogoutEventArgs = New Client_BuddyLogoutEventArgs(array(1), A_0, 4)
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", New Object() { client_BuddyLogoutEventArgs }, True, "项目", False)
							A_0.oOO0O.O0O0.(A_0.Buddies(array(1)))
						End If
						Dim imbuddy As IMBuddy = A_0.Buddies(array(1))
						imbuddy.WanIP = o0___oO.o0__.0.(array(3))
						imbuddy.RandKey = array(4)
						imbuddy.oOo.o0__0Oo0oO. = 0
						imbuddy.O00OO.o_. = 0
						imbuddy.LastReceiveHeartbeatTime = DateTime.Now
						imbuddy.Ready = True
						imbuddy.O00OO.o_. = False
						imbuddy.oO0.OooOOO00. = False
						imbuddy.oo.0o_0O0_0. = False
						imbuddy.O00OO.o_. = DateTime.Now
						If Operators.CompareString(array(5), "None", True) <> 0 Then
							imbuddy.LanIP = o0___oO.o0__.0.(array(5))
							Dim text As String = imbuddy.WanIP.ToString()
							Dim text2 As String = A_0.WanIP.ToString()
							text = text.Substring(0, text.IndexOf(":"))
							text2 = text2.Substring(0, text2.IndexOf(":"))
							If Operators.CompareString(text, text2, True) = 0 Then
								A_0.O.00O0_O_o_oO.(imbuddy.LanIP, "#1" & vbVerticalTab + A_0.UserName + vbVerticalTab + A_0.o_oo0Oooo.OOO_.)
							End If
						Else
							imbuddy.LanIP = Nothing
						End If
						If A_0.ooOooo.oO. IsNot Nothing AndAlso A_0.ooOooo.oO..Oo0_O0o.o_. Then
							Dim imbuddy2 As IMBuddy = A_0.Buddies(array(1))
							Try
								For Each obj As Object In A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages
									Dim c1TopicPage As C1TopicPage = CType(obj, C1TopicPage)
									Dim c1TopicLink As C1TopicLink = c1TopicPage.FindLinkByTag(imbuddy2)
									If c1TopicLink IsNot Nothing Then
										If c1TopicLink.TopicPage.Index = 0 Then
											c1TopicLink.ImageIndex = 0
										Else
											c1TopicLink.ImageIndex = 11
										End If
										Dim num As Integer = 0
										Dim num2 As Integer = c1TopicPage.Links.Count - 1
										For i As Integer = 0 To num2
											Dim objectValue As Object = RuntimeHelpers.GetObjectValue(c1TopicPage.Links(i).Tag)
											If i <> c1TopicLink.Index AndAlso (TypeOf objectValue Is ooo0 OrElse TypeOf objectValue Is O_0OOOoO OrElse CType(objectValue, IMBuddy).OnLine) Then
												num += 1
											End If
										Next
										num = Math.Min(num, c1TopicPage.Links.Count - 1)
										If num <> c1TopicLink.Index Then
											c1TopicPage.Links.Remove(c1TopicLink)
											c1TopicPage.Links.Insert(num, c1TopicLink)
										End If
									End If
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							If A_0.ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso A_0.ooOooo.oO..o.0_0_Ooo..Tag Is imbuddy2 Then
								A_0.ooOooo.oO..oOoO.O_o__.("对方已经上线!")
							End If
						End If
						A_0.O.00O0_O_o_oO.(array(1), "#" & vbVerticalTab + A_0.UserName + vbVerticalTab + A_0.o_oo0Oooo.OOO_.)
						Dim client_BuddyLoginEventArgs As Client_BuddyLoginEventArgs = New Client_BuddyLoginEventArgs(array(1), A_0)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogin", New Object() { client_BuddyLoginEventArgs }, True, "项目", False)
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "!1", True) = 0 Then
					If A_0.Buddies.Contains(array(1)) AndAlso A_0.Buddies(array(1)).OnLine AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(2), True) = 0 Then
						A_0.oOO0O.O0O0.(A_0.Buddies(array(1)))
						Dim client_BuddyLogoutEventArgs2 As Client_BuddyLogoutEventArgs = New Client_BuddyLogoutEventArgs(array(1), A_0, 1)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", New Object() { client_BuddyLogoutEventArgs2 }, True, "项目", False)
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "!2", True) = 0 Then
					If A_0.Buddies.Contains(array(1)) AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(2), True) = 0 Then
						A_0.oOO0O.O0O0.(A_0.Buddies(array(1)))
						Dim client_BuddyLogoutEventArgs3 As Client_BuddyLogoutEventArgs = New Client_BuddyLogoutEventArgs(array(1), A_0, 2)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", New Object() { client_BuddyLogoutEventArgs3 }, True, "项目", False)
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "!3", True) = 0 Then
					If A_0.Buddies.Contains(array(1)) AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(2), True) = 0 Then
						A_0.oOO0O.O0O0.(A_0.Buddies(array(1)))
						Dim client_BuddyLogoutEventArgs4 As Client_BuddyLogoutEventArgs = New Client_BuddyLogoutEventArgs(array(1), A_0, 3)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_BuddyLogout", New Object() { client_BuddyLogoutEventArgs4 }, True, "项目", False)
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "&1", True) = 0 Then
					If Operators.CompareString(A_0.UserName, array(1), True) = 0 AndAlso Operators.CompareString(A_0.o_oo0Oooo.OOO_., array(2), True) = 0 Then
						Dim client_LogoutEventArgs As Client_LogoutEventArgs = New Client_LogoutEventArgs(A_0, 2)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", New Object() { client_LogoutEventArgs }, True, "项目", False)
						A_0.dispose()
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "&2", True) = 0 Then
					If Operators.CompareString(A_0.UserName, array(1), True) = 0 AndAlso Operators.CompareString(A_0.o_oo0Oooo.OOO_., array(2), True) = 0 Then
						Dim client_LogoutEventArgs2 As Client_LogoutEventArgs = New Client_LogoutEventArgs(A_0, 4)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", New Object() { client_LogoutEventArgs2 }, True, "项目", False)
						A_0.dispose()
					End If
				ElseIf array.Length = 3 AndAlso Operators.CompareString(array(0), "&3", True) = 0 Then
					If Operators.CompareString(A_0.UserName, array(1), True) = 0 AndAlso Operators.CompareString(A_0.o_oo0Oooo.OOO_., array(2), True) = 0 Then
						Dim client_LogoutEventArgs3 As Client_LogoutEventArgs = New Client_LogoutEventArgs(A_0, 5)
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Disconnected", New Object() { client_LogoutEventArgs3 }, True, "项目", False)
						Dim oO_u3000_u3002_u3002_u3000O_u As oO\u3000\u3002\u3002\u3000O\u3000 = New oO\u3000\u3002\u3002\u3000O\u3000(A_0, A_0.ooOo.oO0.)
						oO_u3000_u3002_u3002_u3000O_u.O_.0OOOOO0o0.().Text = "服务端QQServer关闭,OpenQQ失去连接。"
						A_0.dispose()
						oO_u3000_u3002_u3002_u3000O_u.Show()
					End If
				ElseIf array.Length = 7 AndAlso Operators.CompareString(array(0), "*", True) = 0 Then
					If A_0.Buddies.Contains(array(1)) Then
						o0___oO.o0__.0.(A_0, array(2), array(4), array(1), array(3), array(5), Conversions.ToDate(array(6)))
					End If
				ElseIf array.Length = 5 AndAlso Operators.CompareString(array(0), "*1", True) = 0 Then
					If A_0.oo.___oo__0_O..ContainsKey(array(3)) OrElse A_0.oo.___oo__0_O..ContainsKey(array(3)) Then
						Dim a_ As Integer = 0
						Dim ooOooo.oO. As f4 = A_0.ooOooo.oO.
						If ooOooo.oO. IsNot Nothing AndAlso ooOooo.oO..Visible AndAlso ooOooo.oO..o.0_0_Ooo. IsNot Nothing Then
							If TypeOf ooOooo.oO..o.0_0_Ooo..Tag Is ooo0 Then
								If Operators.CompareString(CType(ooOooo.oO..o.0_0_Ooo..Tag, ooo0).Oo_0__o.o.(), array(3), True) = 0 Then
									a_ = 1
								End If
							ElseIf TypeOf ooOooo.oO..o.0_0_Ooo..Tag Is O_0OOOoO AndAlso Operators.CompareString(CType(ooOooo.oO..o.0_0_Ooo..Tag, O_0OOOoO).O_O0_o._O0o0O.(), array(3), True) = 0 Then
								a_ = 1
							End If
						End If
						Dim text3 As String = array(4)
						If text3.StartsWith("{!}") Then
							text3 = text3.Substring(3)
							OO_00oOO.PopMessage(text3, array(1), 0, -1)
						End If
						A_0.O.00O0_O_o_oO.(array(3), text3, 1, a_, array(1))
					End If
				ElseIf array.Length = 4 AndAlso Operators.CompareString(array(0), "*2", True) = 0 Then
					If A_0.oo.___oo__0_O..ContainsKey(array(3)) AndAlso Operators.CompareString(A_0.oo.___oo__0_O.(array(3)).o0O0OOo._ooO_O.().RandKey, array(2), True) = 0 Then
						o0___oO.O.oOo0O0O.(A_0, array(3))
					End If
				ElseIf array.Length = 6 AndAlso Operators.CompareString(array(0), "*3", True) = 0 Then
					If A_0.oo.___oo__0_O..ContainsKey(array(3)) AndAlso Operators.CompareString(A_0.oo.___oo__0_O.(array(3)).o0O0OOo._ooO_O.().RandKey, array(2), True) = 0 Then
						If Operators.CompareString(array(4), "", True) > 0 Then
							Dim a_2 As String = ChrW(2) & "(有新用户加入会议:" & vbCrLf + array(4) + ")" & ChrW(2)
							A_0.O.00O0_O_o_oO.(array(3), a_2, 2, 1, array(1))
						End If
						If Operators.CompareString(array(5), "", True) > 0 Then
							Dim a_2 As String = ChrW(2) & "(有用户被请出会议:" & vbCrLf + array(5) + ")" & ChrW(2)
							A_0.O.00O0_O_o_oO.(array(3), a_2, 2, 1, array(1))
						End If
					End If
				ElseIf array.Length = 6 AndAlso Operators.CompareString(array(0), "%5", True) = 0 Then
					If A_0.Buddies.Contains(array(1)) AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(2), True) = 0 Then
						Dim oo0O__ As Oo0O__ = New Oo0O__(A_0, A_0.Buddies(array(1)), array(4), array(3))
						oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(array(4))
						oo0O__.Oo0O_.o.().Text = array(5)
						If A_0.ooOooo.oO. Is Nothing Then
							A_0.ooOooo.oO. = New o\u3000\u3002\u3000\u3002\u3000(A_0)
							A_0.ooOooo.oO..Owner = OO_00oOO.BaseMainForm
						End If
						A_0.ooOooo.oO..O_0O_o.0.(oo0O__)
						A_0.ooOooo.oO..Show()
						Dim a_3 As String = String.Concat(New String() { ChrW(2) & "(对方请求发送文件""", array(4), """(", array(5), "))" & ChrW(2) })
						A_0.O.00O0_O_o_oO.(array(1), a_3, 2, 1, Nothing)
						If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
							OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
						End If
					End If
				Else
					If array.Length = 2 AndAlso Operators.CompareString(array(0), "%5", True) = 0 Then
						If A_0.ooOooo.oO. Is Nothing OrElse A_0.ooOooo.oO..IsDisposed Then
							GoTo IL_15F9
						End If
						Try
							For Each obj2 As Object In A_0.ooOooo.oO..Controls
								Dim control As Control = CType(obj2, Control)
								If TypeOf control Is oO0 AndAlso Operators.CompareString(CType(control, oO0).o0O.Oo., array(1), True) = 0 Then
									A_0.ooOooo.oO..oOOOO.O.(control)
									Dim ooOooo.oO.2 As Object = A_0.ooOooo.oO.
									Dim flag3 As Boolean
									SyncLock ooOooo.oO.2
										Try
											For Each o_0__O_o_O As O_0__O_o_O In A_0.ooOooo.oO..Values
												If Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), array(1), True) = 0 Then
													o_0__O_o_O.O0.0O0o_O. = True
													flag3 = True
													Exit For
												End If
											Next
										Finally
											Dim enumerator3 As Dictionary(Of String, O_0__O_o_O).ValueCollection.Enumerator
											CType(enumerator3, IDisposable).Dispose()
										End Try
									End SyncLock
									Dim name As String = OO_00oOO.FileSys.GetName(CType(control, oO0).O_oo__._O.)
									Dim a_4 As String = String.Concat(New String() { ChrW(2) & "{对方", Interaction.IIf(Not flag3, "拒绝", "取消").ToString(), "接收文件""", OO_00oOO.FileSys.GetName(name), """}" & ChrW(2) })
									A_0.O.00O0_O_o_oO.(CType(control, oO0).O_oo__._O..Name, a_4, 2, 1, Nothing)
									If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "msg.wav") Then
										OO_00oOO.Audio.Play(O_O0OO.o.00O_O.() + "msg.wav", AudioPlayMode.Background)
									End If
								End If
								If TypeOf control Is Oo0O__ AndAlso Operators.CompareString(CType(control, Oo0O__).O_OO.o0o_o0., array(1), True) = 0 Then
									A_0.ooOooo.oO..oOOOO.O.(control)
									Dim ooOooo.oO.3 As Object = A_0.ooOooo.oO.
									SyncLock ooOooo.oO.3
										Try
											For Each ooOoO As ooOoO In A_0.ooOooo.oO..Values
												If Operators.CompareString(ooOoO.o0OO._0.(), array(1), True) = 0 Then
													ooOoO.ooo0_.o__. = True
													Exit For
												End If
											Next
										Finally
											Dim enumerator4 As Dictionary(Of String, ooOoO).ValueCollection.Enumerator
											CType(enumerator4, IDisposable).Dispose()
										End Try
									End SyncLock
									Dim name2 As String = OO_00oOO.FileSys.GetName(CType(control, Oo0O__).o_0.Oo_0O0_.)
									Dim a_5 As String = ChrW(2) & "{对方取消发送文件""" + OO_00oOO.FileSys.GetName(name2) + """}" & ChrW(2)
									A_0.O.00O0_O_o_oO.(CType(control, Oo0O__).o_0.Oo_0O0_..Name, a_5, 2, 1, Nothing)
								End If
							Next
							GoTo IL_15F9
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
					If array.Length = 2 AndAlso Operators.CompareString(array(0), "%6", True) = 0 Then
						If A_0.ooOooo.oO. Is Nothing OrElse A_0.ooOooo.oO..IsDisposed Then
							GoTo IL_15F9
						End If
						Try
							For Each obj3 As Object In A_0.ooOooo.oO..Controls
								Dim control2 As Control = CType(obj3, Control)
								If TypeOf control2 Is oO0 Then
									Dim oO As oO0 = CType(control2, oO0)
									If Operators.CompareString(oO.o0O.Oo., array(1), True) = 0 AndAlso Not oO.O_oo__._O. Then
										oO.O_oo__._O. = True
										oO.o.oo00_.().Visible = False
										oO.o.oo00_.()
										Dim a_6 As String = ChrW(2) & "(我方开始发送文件""" + OO_00oOO.FileSys.GetName(oO.O_oo__._O.) + """)" & ChrW(2)
										A_0.O.00O0_O_o_oO.(oO.O_oo__._O..Name, a_6, 2, 1, Nothing)
									End If
								End If
							Next
							GoTo IL_15F9
						Finally
							Dim enumerator5 As IEnumerator
							If TypeOf enumerator5 Is IDisposable Then
								TryCast(enumerator5, IDisposable).Dispose()
							End If
						End Try
					End If
					If array.Length = 2 AndAlso Operators.CompareString(array(0), "%7", True) = 0 Then
						If A_0.ooOooo.oO. Is Nothing OrElse A_0.ooOooo.oO..IsDisposed Then
							GoTo IL_15F9
						End If
						Try
							For Each obj4 As Object In A_0.ooOooo.oO..Controls
								Dim control3 As Control = CType(obj4, Control)
								If TypeOf control3 Is Oo0O__ AndAlso Operators.CompareString(CType(control3, Oo0O__).O_OO.o0o_o0., array(1), True) = 0 Then
									A_0.ooOooo.oO..oOOOO.O.(control3)
									Dim ooOooo.oO.4 As Object = A_0.ooOooo.oO.
									SyncLock ooOooo.oO.4
										Try
											For Each ooOoO2 As ooOoO In A_0.ooOooo.oO..Values
												If Operators.CompareString(ooOoO2.o0OO._0.(), array(1), True) = 0 Then
													ooOoO2.ooo0_.o__. = True
													Exit For
												End If
											Next
										Finally
											Dim enumerator7 As Dictionary(Of String, ooOoO).ValueCollection.Enumerator
											CType(enumerator7, IDisposable).Dispose()
										End Try
									End SyncLock
									Dim name3 As String = OO_00oOO.FileSys.GetName(CType(control3, Oo0O__).o_0.Oo_0O0_.)
									Dim a_7 As String = ChrW(2) & "(对方选择离线发送文件""" + OO_00oOO.FileSys.GetName(name3) + """)" & ChrW(2)
									A_0.O.00O0_O_o_oO.(CType(control3, Oo0O__).o_0.Oo_0O0_..Name, a_7, 2, 1, Nothing)
								End If
							Next
							GoTo IL_15F9
						Finally
							Dim enumerator6 As IEnumerator
							If TypeOf enumerator6 Is IDisposable Then
								TryCast(enumerator6, IDisposable).Dispose()
							End If
						End Try
					End If
					If array.Length = 3 AndAlso Operators.CompareString(array(0), "=$", True) = 0 Then
						If Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), True) = 0 Then
							Dim text4 As String = array(2)
							If text4.StartsWith("={") AndAlso text4.EndsWith("}=") Then
								text4 = text4.Substring(2, text4.Length - 4)
								Dim array2 As String() = array(1).Split(New Char() { vbTab })
								If A_0.Buddies.Contains(array2(0)) Then
									A_0.O.00O0_O_o_oO.(array2(0), text4, 1, 0, Nothing)
								ElseIf array2.Length = 2 Then
									A_0.AddWeChatUser(array2(0), array2(1))
									A_0.O.00O0_O_o_oO.(array2(0), text4, 1, 0, Nothing)
								End If
							Else
								Dim a_8 As Integer
								If text4.StartsWith(ChrW(2) & "=?") AndAlso text4.EndsWith("?=") Then
									a_8 = 1
								ElseIf text4.StartsWith(ChrW(2) & "<?") AndAlso text4.EndsWith("?>") Then
									a_8 = 2
								End If
								Dim weMessageReceived As weMessageReceived = New weMessageReceived(A_0, array(1), a_8, array(2))
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_WeMessageReceived", New Object() { weMessageReceived }, True, "项目", False)
							End If
						End If
					ElseIf array.Length = 4 AndAlso Operators.CompareString(array(0), "$", True) = 0 AndAlso ((Operators.CompareString(array(1), "", True) = 0 AndAlso Operators.CompareString(A_0.o_oo0Oooo.OOO_., array(3), True) = 0) OrElse (Operators.CompareString(array(1), "[System]", True) = 0 AndAlso Operators.CompareString(oO__oO_0_O.Oo0oo._.().ToString(), A_0.ooOo.oO0..ToString(), True) = 0) OrElse (A_0.Buddies.Contains(array(1)) AndAlso Operators.CompareString(A_0.Buddies(array(1)).RandKey, array(3), True) = 0)) Then
						If Operators.CompareString(array(1), "", True) > 0 AndAlso array(2).StartsWith(ChrW(3)) AndAlso array(2).EndsWith(ChrW(3)) Then
							Dim text5 As String = array(2)
							text5 = text5.Substring(1, text5.Length - 2)
							Dim key As Integer
							If Integer.TryParse(text5, key) AndAlso A_0.ooOo.oO0..ContainsKey(key) Then
								A_0.ooOo.oO0..Remove(key)
							End If
						ElseIf array(2).StartsWith("={") AndAlso array(2).EndsWith("}=") Then
							Dim a_9 As Integer = 0
							If A_0.ooOooo.oO. IsNot Nothing Then
								Dim ooOooo.oO.5 As f4 = A_0.ooOooo.oO.
								If ooOooo.oO.5.o.0_0_Ooo. IsNot Nothing AndAlso TypeOf ooOooo.oO.5.o.0_0_Ooo..Tag Is IMBuddy AndAlso Operators.CompareString(CType(ooOooo.oO.5.o.0_0_Ooo..Tag, IMBuddy).Name, array(1), True) = 0 Then
									a_9 = 1
								End If
							End If
							Dim text6 As String = array(2).Substring(2, array(2).Length - 4)
							If Operators.CompareString(array(1), "", True) > 0 AndAlso text6.IndexOf(ChrW(4)) > 0 Then
								Dim array3 As String() = text6.Split(New Char() { ChrW(4) })
								text6 = array3(0)
								Dim num3 As Integer
								If Integer.TryParse(array3(1), num3) Then
									Dim msg As String = ChrW(3) + num3.ToString() + ChrW(3)
									A_0.Send(array(1), msg, True, False)
								End If
							End If
							If Operators.CompareString(text6, "", True) > 0 AndAlso ((text6.StartsWith(ChrW(2) & "<?") AndAlso text6.EndsWith("?>")) OrElse (text6.StartsWith(ChrW(2) & "=?") AndAlso text6.EndsWith("?="))) Then
								If Not A_0.oo.___oo__0_O..ContainsKey(text6.ToLower()) OrElse (A_0.oo.___oo__0_O.(text6.ToLower()) - DateTime.Now).TotalSeconds > 10.0 Then
									A_0.O.00O0_O_o_oO.(array(1), text6, 1, a_9, Nothing)
									A_0.oo.___oo__0_O..Add(text6.ToLower(), DateTime.Now)
								End If
							ElseIf Operators.CompareString(text6, "", True) > 0 AndAlso text6.StartsWith(ChrW(2) & ChrW(2) & "<?") AndAlso text6.EndsWith("?>") Then
								text6 = text6.Substring(1)
								A_0.O.00O0_O_o_oO.(array(1), text6, 1, a_9, Nothing)
							ElseIf Operators.CompareString(text6, "", True) > 0 AndAlso text6.StartsWith(ChrW(2) & ChrW(2) & "=?") AndAlso text6.EndsWith("?=") Then
								text6 = text6.Substring(1)
								A_0.O.00O0_O_o_oO.(array(1), text6, 1, a_9, Nothing)
							Else
								If text6.StartsWith("{!}") Then
									text6 = text6.Substring(3)
									Dim text7 As String = array(1)
									If Operators.CompareString(text7, "[System]", True) = 0 Then
										text7 = "系统通知"
									End If
									OO_00oOO.PopMessage(text6, text7, 0, -1)
								End If
								A_0.O.00O0_O_o_oO.(array(1), text6, 1, a_9, Nothing)
							End If
						Else
							Dim client_MessageEventargs As Client_MessageEventargs = New Client_MessageEventargs(A_0, array(1), array(2))
							client_MessageEventargs.SendTime = DateTime.Now
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_ReceivedMessage", New Object() { client_MessageEventargs }, True, "项目", False)
						End If
					End If
				End If
				IL_15F9:
				If A_0.ooOo.oO0..Count > 0 Then
					o0___oO.O.oOo0O0O.(A_0)
				End If
			End If
		End Sub

		' Token: 0x06001509 RID: 5385 RVA: 0x00087464 File Offset: 0x00085664
		Private Sub <<EMPTY_NAME>>(A_0 As IMClient, A_1 As String, A_2 As String, A_3 As String, A_4 As String, A_5 As String, A_6 As DateTime)
			Try
				Dim o_0OOOoO As O_0OOOoO = New O_0OOOoO(A_1, A_2, A_0.Buddies(A_3), A_4, A_5)
				o_0OOOoO.O0O0o_.00O.(A_6)
				A_0.oo.___oo__0_O..Add(A_2, o_0OOOoO)
				If A_0.ooOooo.oO. IsNot Nothing AndAlso A_0.ooOooo.oO..Oo0_O0o.o_. Then
					Dim c1TopicLink As C1TopicLink = New C1TopicLink()
					c1TopicLink.Text = A_1
					c1TopicLink.Tag = o_0OOOoO
					c1TopicLink.ImageIndex = 9
					A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).Links.Add(c1TopicLink)
					If Not A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).PageVisible Then
						A_0.ooOooo.oO..Oo.Oo00__oooo.().Pages(0).PageVisible = True
					End If
					A_0.ooOooo.oO..o0__.O_Ooo_.(o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.O_O0_o._O0o0O.(), A_3, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.(), 0)
				End If
				Dim dataRow As DataRow = A_0.oo00000_0o0.oO..NewRow()
				dataRow("MeetingKey") = A_2
				dataRow("Hostess") = A_3
				dataRow("MeetingName") = A_1
				dataRow("DateTime") = A_6
				dataRow("Description") = A_4
				dataRow("Members") = A_5
				dataRow("Finish") = False
				A_0.oo00000_0o0.oO..Rows.Add(dataRow)
				A_0.oo00000_0o0.oO..Update(New DataRow() { dataRow })
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
			End Try
		End Sub

		' Token: 0x0600150A RID: 5386 RVA: 0x00087628 File Offset: 0x00085828
		Private Sub <<EMPTY_NAME>>(A_0 As IMClient, A_1 As String)
			Dim o_0OOOoO As O_0OOOoO = A_0.oo.___oo__0_O.(A_1)
			A_0.oo.___oo__0_O..Remove(A_1)
			Dim array As DataRow() = A_0.oo00000_0o0.oO..[Select]("[MeetingKey] = '" + o_0OOOoO.O_O0_o._O0o0O.() + "'", "")
			For i As Integer = 0 To array.Length - 1
				array(i)("Finish") = True
			Next
			New OleDbCommand("Update Meetings Set [Finish] = True Where [MeetingKey] = '" + o_0OOOoO.O_O0_o._O0o0O.() + "'", A_0.oOO0O.O0O0.).ExecuteNonQuery()
			If A_0.ooOooo.oO. IsNot Nothing AndAlso A_0.ooOooo.oO..Oo0_O0o.o_. Then
				Dim ooOooo.oO. As f4 = A_0.ooOooo.oO.
				If ooOooo.oO..o.0_0_Ooo. IsNot Nothing AndAlso ooOooo.oO..o.0_0_Ooo..Tag Is o_0OOOoO Then
					ooOooo.oO..O_0oOOO_.OO.().Rows.Count = 0
					ooOooo.oO..Oo.Oo00__oooo.().Rows.Count = 0
				End If
				Dim c1TopicLink As C1TopicLink = ooOooo.oO..Oo.Oo00__oooo.().Pages(0).FindLinkByTag(o_0OOOoO)
				If c1TopicLink IsNot Nothing Then
					ooOooo.oO..Oo.Oo00__oooo.().Pages(0).Links.Remove(c1TopicLink)
					If ooOooo.oO..Oo.Oo00__oooo.().Pages(0).Links.Count = 0 Then
						ooOooo.oO..Oo.Oo00__oooo.().Pages(0).PageVisible = False
					End If
				End If
				If ooOooo.oO..O_0oOOO_.OO.().Pages.Count > 0 Then
					Dim num As Integer = ooOooo.oO..O_0oOOO_.OO.().Pages.Count - 1
					For j As Integer = 0 To num
						Dim c1TopicPage As C1TopicPage = ooOooo.oO..O_0oOOO_.OO.().Pages(j)
						Try
							For Each obj As Object In c1TopicPage.Links
								Dim c1TopicLink2 As C1TopicLink = CType(obj, C1TopicLink)
								If Operators.CompareString(CType(c1TopicLink2.Tag, o0o0_oo00Oo).OO.O_o__.(), A_1, True) = 0 Then
									CType(c1TopicLink2.Tag, o0o0_oo00Oo).o.oo_o0O.(True)
									c1TopicLink2.ImageIndex = 13
									If ooOooo.oO..o.0_0_Ooo. Is Nothing OrElse ooOooo.oO..o.0_0_Ooo. = c1TopicLink2 Then
										ooOooo.oO..oOO._O.().Enabled = False
										ooOooo.oO..oOo00_.0Oo.().Enabled = False
										ooOooo.oO..Oo_oo._O_.().Enabled = False
										ooOooo.oO..OO0_O0.o.().Enabled = False
										ooOooo.oO..O._o_O0O.().Enabled = False
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Next
				End If
			End If
		End Sub

		' Token: 0x0600150B RID: 5387 RVA: 0x000878B4 File Offset: 0x00085AB4
		Private Sub <<EMPTY_NAME>>(A_0 As UDPClient)
			Dim o00ooo._. As Object = A_0.O00ooo._.
			SyncLock o00ooo._.
				If A_0.O00ooo._..Count > 0 Then
					Dim oo00_ As UDPClient.OO00_ = A_0.O00ooo._..Dequeue()
					Dim udpclient_MessageReceived As UDPClient_MessageReceived = New UDPClient_MessageReceived(A_0, oo00_)
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "UDPClient_ReceivedMessage", New Object() { udpclient_MessageReceived }, True, "项目", False)
					If Operators.CompareString(udpclient_MessageReceived.ReturnValue, "", True) > 0 Then
						Dim bytes As Byte() = A_0.O00ooo._..GetBytes(udpclient_MessageReceived.ReturnValue)
						A_0.O00ooo._..Send(bytes, bytes.Length, oo00_.O00ooo._.())
					ElseIf udpclient_MessageReceived.ReturnBytes IsNot Nothing Then
						A_0.O00ooo._..Send(udpclient_MessageReceived.ReturnBytes, udpclient_MessageReceived.ReturnBytes.Length, oo00_.O00ooo._.())
					End If
				End If
			End SyncLock
			If A_0.O00ooo._..Count > 0 Then
				o0___oO.O.oOo0O0O.(A_0)
			End If
		End Sub

		' Token: 0x0600150C RID: 5388 RVA: 0x000879B4 File Offset: 0x00085BB4
		Friend Function <<EMPTY_NAME>>(A_0 As String) As IPEndPoint
			Dim array As String() = A_0.Split(New Char() { ":"c })
			Return New IPEndPoint(IPAddress.Parse(array(0)), Conversions.ToInteger(array(1)))
		End Function

		' Token: 0x0600150D RID: 5389 RVA: 0x000879E8 File Offset: 0x00085BE8
		Friend Sub <<EMPTY_NAME>>(A_0 As UdpClient)
			A_0.Client.IOControl(-1744830452, New Byte() { Convert.ToByte(False) }, Nothing)
		End Sub

		' Token: 0x0600150E RID: 5390 RVA: 0x00087A0C File Offset: 0x00085C0C
		Friend Function <<EMPTY_NAME>>() As String
			For Each ipaddress As IPAddress In Dns.GetHostEntry(Dns.GetHostName()).AddressList
				If ipaddress.AddressFamily = AddressFamily.InterNetwork AndAlso ipaddress.ToString().StartsWith("192.168.") Then
					Return ipaddress.ToString()
				End If
			Next
			Return ""
		End Function

		' Token: 0x0600150F RID: 5391 RVA: 0x00087A66 File Offset: 0x00085C66
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return A_0.Replace(vbVerticalTab, "").Replace(vbFormFeed, "").Trim()
		End Function

		' Token: 0x06001510 RID: 5392 RVA: 0x00087A8C File Offset: 0x00085C8C
		Friend Function <<EMPTY_NAME>>(A_0 As IMBuddy) As String
			Dim result As String
			If TypeOf A_0 Is ooo0 Then
				result = CType(A_0, ooo0).Oo_0__o.o.()
			ElseIf TypeOf A_0 Is O_0OOOoO Then
				result = CType(A_0, O_0OOOoO).O_O0_o._O0o0O.()
			Else
				result = A_0.Name
			End If
			Return result
		End Function

		' Token: 0x06001511 RID: 5393 RVA: 0x00087AD0 File Offset: 0x00085CD0
		Friend Function <<EMPTY_NAME>>(A_0 As Long) As String
			Dim num As Double = CDbl((A_0 / 1024L))
			Dim result As String
			If num < 1000.0 Then
				result = num.ToString() + "K"
			Else
				result = Strings.Format(CDbl(A_0) / 1024.0 / 1024.0, "0.00") + "M"
			End If
			Return result
		End Function

		' Token: 0x06001512 RID: 5394 RVA: 0x00087B38 File Offset: 0x00085D38
		Friend Function <<EMPTY_NAME>>(A_0 As IMServer) As UdpClient
			Dim obj As Object = o0___oO.o_o.__OO00O.
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			Dim result As UdpClient
			SyncLock obj
				Dim num As Integer = A_0.oo._0oo_00O.
				Dim num2 As Integer = A_0.OOOOoo_0o.Oo.
				If num = -1 AndAlso num2 = -1 Then
					result = o0___oO.o0__.0.(A_0, 0)
				Else
					If num = -1 Then
						num = 1024
					End If
					If num2 = -1 Then
						num2 = 65535
					End If
					Dim ipglobalProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()
					Dim activeTcpListeners As IPEndPoint() = ipglobalProperties.GetActiveTcpListeners()
					Dim activeUdpListeners As IPEndPoint() = ipglobalProperties.GetActiveUdpListeners()
					Dim activeTcpConnections As TcpConnectionInformation() = ipglobalProperties.GetActiveTcpConnections()
					Dim list As List(Of Integer) = New List(Of Integer)()
					For Each ipendPoint As IPEndPoint In activeTcpListeners
						list.Add(ipendPoint.Port)
					Next
					For Each ipendPoint2 As IPEndPoint In activeUdpListeners
						list.Add(ipendPoint2.Port)
					Next
					For Each tcpConnectionInformation As TcpConnectionInformation In activeTcpConnections
						list.Add(tcpConnectionInformation.LocalEndPoint.Port)
					Next
					Dim num3 As Integer = num
					Dim num4 As Integer = num2
					For l As Integer = num3 To num4
						If Not list.Contains(l) Then
							Dim udpClient As UdpClient = o0___oO.o0__.0.(A_0, l)
							If udpClient IsNot Nothing Then
								Return udpClient
							End If
						End If
					Next
					ooO.oOo0Oo.o.(New Exception("指定的端口范围已全部占用，无法接入新的请求！"), "")
					result = Nothing
				End If
			End SyncLock
			Return result
		End Function

		' Token: 0x06001513 RID: 5395 RVA: 0x00087CB4 File Offset: 0x00085EB4
		Friend Function <<EMPTY_NAME>>(A_0 As IMServer, A_1 As Integer) As UdpClient
			If o0___oO.a Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(o0___oO.a, New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(o0___oO.a, flag)
				If o0___oO.a.State = 0S Then
					o0___oO.a.State = 2S
					o0___oO.a = New StringBuilder()
				ElseIf o0___oO.a.State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				o0___oO.a.State = 1S
				If flag Then
					Monitor.[Exit](o0___oO.a)
				End If
			End Try
			Dim result As UdpClient
			Try
				Dim localEP As IPEndPoint
				If Operators.CompareString(A_0.ServerIP, "", True) = 0 Then
					localEP = New IPEndPoint(IPAddress.Any, A_1)
				Else
					localEP = New IPEndPoint(IPAddress.Parse(A_0.ServerIP), A_1)
				End If
				o0___oO.a.Append(Conversions.ToString(A_1) + ",")
				result = New UdpClient(localEP)
			Catch ex As Exception
				o0___oO.a.Append("error,")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x0400086C RID: 2156
		Friend <<EMPTY_NAME>> As String = "Yn9laz04yt+eA5JRIe5b+JeWX8onK2CJCAx9aF/UPeMoJCo+89kYkL9BsDTL8cWgpohfMeOYzG0="

		' Token: 0x0400086D RID: 2157
		Private <<EMPTY_NAME>> As Object = RuntimeHelpers.GetObjectValue(New Object())

		' Token: 0x0400086E RID: 2158
		Private a As StringBuilder

		' Token: 0x0400086F RID: 2159
		Private a As StaticLocalInitFlag

		' Token: 0x020001C6 RID: 454
		Friend Class oooO0
			' Token: 0x06001514 RID: 5396 RVA: 0x00087DD0 File Offset: 0x00085FD0
			Friend Sub New(A_0 As String(), A_1 As IMServer, A_2 As oO__oO_0_O)
				Me.o_o.__OO00O. = A_0
				Me.o_o.__OO00O. = A_1
				Me.o_o.__OO00O. = A_2
			End Sub

			' Token: 0x06001515 RID: 5397 RVA: 0x00087DF0 File Offset: 0x00085FF0
			Friend Sub <<EMPTY_NAME>>()
				Dim text As String = ""
				Me.o_o.__OO00O..ooO_.O0_..AcquireReaderLock(-1)
				Try
					Try
						For Each text2 As String In Me.o_o.__OO00O..Users(Me.o_o.__OO00O.(1)).Buddies
							If Operators.CompareString(text, "", True) > 0 Then
								text += vbVerticalTab
							End If
							Dim imuser As IMUser = Nothing
							Dim users As Object = Me.o_o.__OO00O..Users
							SyncLock users
								If Me.o_o.__OO00O..Users.Contains(text2) Then
									imuser = Me.o_o.__OO00O..Users(text2)
								End If
							End SyncLock
							If imuser Is Nothing Then
								text = text + "^" & vbTab + text2
							Else
								text = String.Concat(New String() { text, "^" & vbTab, text2, vbTab, imuser.WanIP.ToString(), vbTab, imuser.OO__o_.O0_0O_0., vbTab, imuser.LanIPAddress })
								If text.Length > 500 Then
									Me.o_o.__OO00O..O0o_.Oo0oo.(Me.o_o.__OO00O..Oo0oo._.(), text)
									text = ""
									Thread.Sleep(1)
								End If
							End If
						Next
					Finally
						Dim enumerator As List(Of String).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					If Operators.CompareString(text, "", True) > 0 Then
						Me.o_o.__OO00O..O0o_.Oo0oo.(Me.o_o.__OO00O..Oo0oo._.(), text)
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					Me.o_o.__OO00O..ooO_.O0_..ReleaseReaderLock()
				End Try
			End Sub

			' Token: 0x04000870 RID: 2160
			Private <<EMPTY_NAME>> As String()

			' Token: 0x04000871 RID: 2161
			Private <<EMPTY_NAME>> As IMServer

			' Token: 0x04000872 RID: 2162
			Private <<EMPTY_NAME>> As oO__oO_0_O
		End Class

		' Token: 0x020001C7 RID: 455
		Friend Class o_O__o_o_o
			' Token: 0x06001516 RID: 5398 RVA: 0x0008801C File Offset: 0x0008621C
			Friend Sub New(A_0 As IMServer, A_1 As String, A_2 As IPEndPoint)
				Me.o_o.__OO00O. = A_0
				Me.o_o.__OO00O. = A_1
				Me.o_o.__OO00O. = A_2
			End Sub

			' Token: 0x06001517 RID: 5399 RVA: 0x0008803C File Offset: 0x0008623C
			Friend Sub <<EMPTY_NAME>>()
				Me.o_o.__OO00O..ooO_.O0_..AcquireReaderLock(-1)
				Try
					Dim stringBuilder As StringBuilder = New StringBuilder()
					Dim value As Char = vbVerticalTab
					Try
						For Each o0o0_oo00Oo As o0o0_oo00Oo In Me.o_o.__OO00O..MeetingInfos.Values
							If o0o0_oo00Oo.o.oo_o0O.().Contains(Me.o_o.__OO00O.) Then
								If stringBuilder.Length > 0 Then
									stringBuilder.Append(vbFormFeed)
								End If
								stringBuilder.Append(String.Concat(New String() { "*", Conversions.ToString(value), o0o0_oo00Oo.O_oO._O.(), Conversions.ToString(value), o0o0_oo00Oo.oOO_00_0.o.(), Conversions.ToString(value), o0o0_oo00Oo.OO0_o.Oo0O.(), Conversions.ToString(value), o0o0_oo00Oo.OO.O_o__.(), Conversions.ToString(value), o0o0_oo00Oo.o_0o.oo_o_.(), Conversions.ToString(value), Strings.Format(o0o0_oo00Oo.o.oo_o0O.(), "MM/dd/yyyy HH:mm:ss") }))
							End If
						Next
					Finally
						Dim enumerator As Dictionary(Of String, o0o0_oo00Oo).ValueCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Dim dataTable As DataTable = New DataTable()
					Me.o_o.__OO00O..O0O_.O..SelectCommand.CommandText = "Select * From [Messages] Where [Receiver] = '" + Me.o_o.__OO00O. + "'"
					Me.o_o.__OO00O..O0O_.O..Fill(dataTable)
					For Each dataRow As DataRow In dataTable.[Select]("", "[Time]")
						If stringBuilder.Length > 0 Then
							stringBuilder.Append(vbFormFeed)
						End If
						stringBuilder.Append(dataRow("Content").ToString() + vbVerticalTab + Strings.Format(Conversions.ToDate(dataRow("Time")), "MM/dd/yyyy HH:mm:ss"))
					Next
					If stringBuilder.Length > 0 Then
						If New o0O0OOoOO(Me.o_o.__OO00O., Me.o_o.__OO00O., stringBuilder.ToString()).ooo_OoooOOO.0.() Then
							New OleDbCommand("Delete From [Messages] Where [Receiver] = '" + Me.o_o.__OO00O. + "'", Me.o_o.__OO00O..O0O_.O.).ExecuteNonQuery()
						End If
					Else
						Me.o_o.__OO00O..O0o_.Oo0oo.(Me.o_o.__OO00O., "None")
					End If
				Catch a_ As Exception
					ooO.oOo0Oo.o.(a_, "")
				Finally
					Me.o_o.__OO00O..ooO_.O0_..ReleaseReaderLock()
				End Try
			End Sub

			' Token: 0x04000873 RID: 2163
			Private <<EMPTY_NAME>> As IMServer

			' Token: 0x04000874 RID: 2164
			Private <<EMPTY_NAME>> As String

			' Token: 0x04000875 RID: 2165
			Private <<EMPTY_NAME>> As IPEndPoint
		End Class
	End Module
End Namespace
