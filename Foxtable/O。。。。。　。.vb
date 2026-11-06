Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Foxtable.My.Resources
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000356 RID: 854
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3002\u3002\u3002\u3000\u3002
		Inherits Form

		' Token: 0x06003482 RID: 13442 RVA: 0x0015C3D0 File Offset: 0x0015A5D0
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo_.o. IsNot Nothing Then
					Me.Oo_.o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003483 RID: 13443 RVA: 0x0015C410 File Offset: 0x0015A610
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o_o0.000O00o0.(New Label())
			Me.o__O__ooO._o.(New C1TextBox())
			Me.o__ooOO0O__0.O.(New Label())
			Me.o__O__ooO._o.(New C1ComboBox())
			Me.o__O__ooO._o.(New C1Button())
			Me.o__ooOO0O__0.O.(New C1Button())
			Me.o__O__ooO._o.(New Label())
			Me.o__O__ooO._o.(New C1FlexGrid())
			Me.O.O0OOoOO.().BeginInit()
			MyBase.SuspendLayout()
			Me.o__o.O.().AutoSize = True
			Me.o__o.O.().BackColor = Color.Transparent
			Me.o__o.O.().Location = New Point(13, 11)
			Me.o__o.O.().Name = "Label1"
			Me.o__o.O.().Size = New Size(47, 12)
			Me.o__o.O.().TabIndex = 0
			Me.o__o.O.().Text = "用户名:"
			Me.O.O0OOoOO.().Location = New Point(13, 76)
			Me.O.O0OOoOO.().Name = "txtPassWord"
			Me.O.O0OOoOO.().PasswordChar = "*"c
			Me.O.O0OOoOO.().Size = New Size(241, 21)
			Me.O.O0OOoOO.().TabIndex = 1
			Me.OO.OOoo_o.().AutoSize = True
			Me.OO.OOoo_o.().BackColor = Color.Transparent
			Me.OO.OOoo_o.().Location = New Point(13, 57)
			Me.OO.OOoo_o.().Name = "Label2"
			Me.OO.OOoo_o.().Size = New Size(35, 12)
			Me.OO.OOoo_o.().TabIndex = 2
			Me.OO.OOoo_o.().Text = "密码:"
			Me.O.O0OOoOO.().AutoCompleteMode = AutoCompleteMode.SuggestAppend
			Me.O.O0OOoOO.().AutoCompleteSource = AutoCompleteSource.ListItems
			Me.O.O0OOoOO.().Location = New Point(13, 30)
			Me.O.O0OOoOO.().Name = "lstUsers"
			Me.O.O0OOoOO.().Size = New Size(241, 20)
			Me.O.O0OOoOO.().TabIndex = 0
			Me.O.O0OOoOO.().ImageAlign = ContentAlignment.MiddleLeft
			Me.O.O0OOoOO.().Location = New Point(56, 231)
			Me.O.O0OOoOO.().Name = "btnOK"
			Me.O.O0OOoOO.().Size = New Size(75, 23)
			Me.O.O0OOoOO.().TabIndex = 3
			Me.O.O0OOoOO.().Text = "确定"
			Me.O.O0OOoOO.().UseVisualStyleBackColor = True
			Me.o__o.O.().DialogResult = DialogResult.Cancel
			Me.o__o.O.().ImageAlign = ContentAlignment.MiddleLeft
			Me.o__o.O.().Location = New Point(137, 231)
			Me.o__o.O.().Name = "btnCancel"
			Me.o__o.O.().Size = New Size(75, 23)
			Me.o__o.O.().TabIndex = 4
			Me.o__o.O.().Text = "取消"
			Me.o__o.O.().UseVisualStyleBackColor = True
			Me.O.O0OOoOO.().AutoSize = True
			Me.O.O0OOoOO.().BackColor = Color.Transparent
			Me.O.O0OOoOO.().Location = New Point(13, 104)
			Me.O.O0OOoOO.().Name = "logtip"
			Me.O.O0OOoOO.().Size = New Size(0, 12)
			Me.O.O0OOoOO.().TabIndex = 2
			Me.O.O0OOoOO.().AllowSorting = 0
			Me.O.O0OOoOO.().BorderStyle = 4
			Me.O.O0OOoOO.().ColumnInfo = "2,0,0,40,0,0,Columns:0{Width:75;Caption:""属性"";Style:""TextAlign:LeftCenter;"";StyleFixed:""TextAlign:CenterCenter;"";}" & vbTab & "1{Caption:""值"";Style:""TextAlign:LeftCenter;"";StyleFixed:""TextAlign:CenterCenter;"";}" & vbTab
			Me.O.O0OOoOO.().ExtendLastCol = True
			Me.O.O0OOoOO.().Location = New Point(15, 130)
			Me.O.O0OOoOO.().Name = "C1FlexGrid1"
			Me.O.O0OOoOO.().Rows.Count = 1
			Me.O.O0OOoOO.().Rows.DefaultSize = 20
			Me.O.O0OOoOO.().Size = New Size(240, 93)
			Me.O.O0OOoOO.().TabIndex = 5
			Me.O.O0OOoOO.().VisualStyle = 1
			MyBase.AcceptButton = Me.O.O0OOoOO.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.o__o.O.()
			MyBase.ClientSize = New Size(269, 262)
			MyBase.Controls.Add(Me.O.O0OOoOO.())
			MyBase.Controls.Add(Me.O.O0OOoOO.())
			MyBase.Controls.Add(Me.o__o.O.())
			MyBase.Controls.Add(Me.O.O0OOoOO.())
			MyBase.Controls.Add(Me.O.O0OOoOO.())
			MyBase.Controls.Add(Me.OO.OOoo_o.())
			MyBase.Controls.Add(Me.O.O0OOoOO.())
			MyBase.Controls.Add(Me.o__o.O.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oO......"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "用户登录"
			MyBase.TopMost = True
			Me.O.O0OOoOO.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003484 RID: 13444 RVA: 0x0015C941 File Offset: 0x0015AB41
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo_.o.
		End Function

		' Token: 0x06003485 RID: 13445 RVA: 0x0015C949 File Offset: 0x0015AB49
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo_.o. = A_0
		End Sub

		' Token: 0x06003486 RID: 13446 RVA: 0x0015C952 File Offset: 0x0015AB52
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo_.o.
		End Function

		' Token: 0x06003487 RID: 13447 RVA: 0x0015C95A File Offset: 0x0015AB5A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.Oo_.o. = A_0
		End Sub

		' Token: 0x06003488 RID: 13448 RVA: 0x0015C963 File Offset: 0x0015AB63
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o.0___0_00oo0.
		End Function

		' Token: 0x06003489 RID: 13449 RVA: 0x0015C96B File Offset: 0x0015AB6B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o.0___0_00oo0. = A_0
		End Sub

		' Token: 0x0600348A RID: 13450 RVA: 0x0015C974 File Offset: 0x0015AB74
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.Oo_.o.
		End Function

		' Token: 0x0600348B RID: 13451 RVA: 0x0015C97C File Offset: 0x0015AB7C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.Oo_.o. = A_0
		End Sub

		' Token: 0x0600348C RID: 13452 RVA: 0x0015C985 File Offset: 0x0015AB85
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_.o.
		End Function

		' Token: 0x0600348D RID: 13453 RVA: 0x0015C990 File Offset: 0x0015AB90
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_0_0__.o_.
			Dim oo_.o. As C1Button = Me.Oo_.o.
			If oo_.o. IsNot Nothing Then
				RemoveHandler oo_.o..Click, value
			End If
			Me.Oo_.o. = A_0
			oo_.o. = Me.Oo_.o.
			If oo_.o. IsNot Nothing Then
				AddHandler oo_.o..Click, value
			End If
		End Sub

		' Token: 0x0600348E RID: 13454 RVA: 0x0015C9D3 File Offset: 0x0015ABD3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o__ooOO0O__0.O.
		End Function

		' Token: 0x0600348F RID: 13455 RVA: 0x0015C9DB File Offset: 0x0015ABDB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o__ooOO0O__0.O. = A_0
		End Sub

		' Token: 0x06003490 RID: 13456 RVA: 0x0015C9E4 File Offset: 0x0015ABE4
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o_OO0O.0.
		End Function

		' Token: 0x06003491 RID: 13457 RVA: 0x0015C9EC File Offset: 0x0015ABEC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o_OO0O.0. = A_0
		End Sub

		' Token: 0x06003492 RID: 13458 RVA: 0x0015C9F5 File Offset: 0x0015ABF5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo_.o.
		End Function

		' Token: 0x06003493 RID: 13459 RVA: 0x0015CA00 File Offset: 0x0015AC00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.o_._o_0o0.
			Dim rangeEventHandler As RangeEventHandler = AddressOf Me.o_0_0__.o_.
			Dim ownerDrawCellEventHandler As OwnerDrawCellEventHandler = AddressOf Me.o_0_0__.o_.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.o_0_0__.o_.
			Dim oo_.o. As C1FlexGrid = Me.Oo_.o.
			If oo_.o. IsNot Nothing Then
				oo_.o..AfterEdit -= rowColEventHandler
				oo_.o..AfterSelChange -= rangeEventHandler
				oo_.o..OwnerDrawCell -= ownerDrawCellEventHandler
				oo_.o..SetupEditor -= rowColEventHandler2
			End If
			Me.Oo_.o. = A_0
			oo_.o. = Me.Oo_.o.
			If oo_.o. IsNot Nothing Then
				oo_.o..AfterEdit += rowColEventHandler
				oo_.o..AfterSelChange += rangeEventHandler
				oo_.o..OwnerDrawCell += ownerDrawCellEventHandler
				oo_.o..SetupEditor += rowColEventHandler2
			End If
		End Sub

		' Token: 0x06003494 RID: 13460 RVA: 0x0015CAA0 File Offset: 0x0015ACA0
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				MyBase.Icon = a.OO.oO__O00.()
				IL_14:
				num2 = 3
				If Not Me.O.O_0O0oO_. Then
					GoTo IL_5A
				End If
				IL_1E:
				num2 = 4
				Me.O.O0OOoOO.().ItemsDataSource = New DataView(Me.OooO.00o., "[Type] <= " + Conversions.ToString(4) + " And [Name] Is Not Null And [Type] Is Not Null And [Type] <> " + Conversions.ToString(0), "[Type]", DataViewRowState.CurrentRows)
				GoTo IL_8E
				IL_5A:
				num2 = 6
				Me.O.O0OOoOO.().ItemsDataSource = New DataView(Me.OooO.00o., "[Type] <= " + Conversions.ToString(4) + " And [Name] Is Not Null And [Type] Is Not Null", "[Type]", DataViewRowState.CurrentRows)
				IL_8E:
				num2 = 7
				Me.O.O0OOoOO.().ItemsDisplayMember = "Name"
				IL_A0:
				num2 = 8
				Me.O.O0OOoOO.().ItemsValueMember = "Name"
				IL_B2:
				num2 = 9
				Me.OooO.00o..DefaultView.Sort = "[Type]"
				IL_CA:
				num2 = 10
				Me.OooO.00o. = Main.OO_O.o.
				IL_D8:
				num2 = 11
				Main.OO_O.o. = 4
				IL_E1:
				num2 = 12
				Dim dataRow As DataRow = Me.o.0___0_00oo0..Rows.Find(New Object() { "LastLogonUser", o0_O.ooO__0.oO_0_. })
				IL_10D:
				num2 = 13
				If dataRow Is Nothing Then
					GoTo IL_131
				End If
				IL_113:
				num2 = 14
				Me.O.O0OOoOO.().Value = dataRow("Config").ToString()
				IL_131:
				num2 = 15
				If Not OO_00oOO.FileSys.FileExists(Me.OooO.00o. + "\logform.txt") Then
					GoTo IL_80D
				End If
				IL_153:
				num2 = 16
				Dim text As String = OO_00oOO.FileSys.ReadAllText(Me.OooO.00o. + "\logform.txt", Encoding.[Default])
				IL_177:
				num2 = 17
				Dim array As String() = text.Replace(vbCr, "").Split(New Char() { vbLf })
				IL_19D:
				num2 = 18
				For Each text2 As String In array
					IL_1B3:
					num2 = 19
					Dim array3 As String() = text2.Split(New Char() { "@"c })
					IL_1CA:
					num2 = 20
					If array3.Length > 1 Then
						IL_1D7:
						num2 = 21
						Dim left As String = array3(0)
						IL_1E0:
						num2 = 23
						If Operators.CompareString(left, "form", True) = 0 Then
							IL_1F2:
							num2 = 24
							If array3.Length = 3 Then
								IL_1FF:
								num2 = 25
								Dim width As Integer
								Dim height As Integer
								If Integer.TryParse(array3(1), width) AndAlso Integer.TryParse(array3(2), height) Then
									IL_222:
									num2 = 26
									MyBase.Size = New Size(width, height)
								End If
							End If
						Else
							IL_239:
							num2 = 28
							If Operators.CompareString(left, "Label1", True) = 0 Then
								IL_24B:
								num2 = 29
								If array3.Length = 4 Then
									IL_258:
									num2 = 30
									Dim x As Integer
									Dim y As Integer
									If Integer.TryParse(array3(2), x) AndAlso Integer.TryParse(array3(3), y) Then
										IL_27B:
										num2 = 31
										Me.o__o.O.().Location = New Point(x, y)
										IL_292:
										num2 = 32
										Me.o__o.O.().Text = array3(1)
									End If
								End If
							Else
								IL_2A9:
								num2 = 34
								If Operators.CompareString(left, "Label2", True) = 0 Then
									IL_2BB:
									num2 = 35
									If array3.Length = 4 Then
										IL_2C8:
										num2 = 36
										Dim x2 As Integer
										Dim y2 As Integer
										If Integer.TryParse(array3(2), x2) AndAlso Integer.TryParse(array3(3), y2) Then
											IL_2EB:
											num2 = 37
											Me.OO.OOoo_o.().Location = New Point(x2, y2)
											IL_302:
											num2 = 38
											Me.OO.OOoo_o.().Text = array3(1)
										End If
									End If
								Else
									IL_319:
									num2 = 40
									If Operators.CompareString(left, "Label3", True) = 0 Then
										IL_32E:
										num2 = 41
										If array3.Length = 4 Then
											IL_33B:
											num2 = 42
											Dim x3 As Integer
											Dim y3 As Integer
											If Integer.TryParse(array3(2), x3) AndAlso Integer.TryParse(array3(3), y3) Then
												IL_35E:
												num2 = 43
												Me.O.O0OOoOO.().Location = New Point(x3, y3)
												IL_375:
												num2 = 44
												If Operators.CompareString(array3(1), "", True) > 0 Then
													IL_38D:
													num2 = 45
													Me.O.O0OOoOO.().Text = array3(1)
													IL_39F:
													num2 = 46
													Me.O.O0OOoOO.().Tag = "has"
												End If
											End If
										End If
									Else
										IL_3B7:
										num2 = 48
										If Operators.CompareString(left, "TextBox1", True) = 0 Then
											IL_3C9:
											num2 = 49
											If array3.Length = 4 Then
												IL_3D6:
												num2 = 50
												Dim x4 As Integer
												Dim y4 As Integer
												Dim width2 As Integer
												If Integer.TryParse(array3(1), x4) AndAlso Integer.TryParse(array3(2), y4) AndAlso Integer.TryParse(array3(3), width2) Then
													IL_409:
													num2 = 51
													Me.O.O0OOoOO.().Location = New Point(x4, y4)
													IL_420:
													num2 = 52
													Me.O.O0OOoOO.().Width = width2
												End If
											End If
										Else
											IL_435:
											num2 = 54
											If Operators.CompareString(left, "TextBox2", True) = 0 Then
												IL_447:
												num2 = 55
												If array3.Length = 4 Then
													IL_454:
													num2 = 56
													Dim x5 As Integer
													Dim y5 As Integer
													Dim width3 As Integer
													If Integer.TryParse(array3(1), x5) AndAlso Integer.TryParse(array3(2), y5) AndAlso Integer.TryParse(array3(3), width3) Then
														IL_487:
														num2 = 57
														Me.O.O0OOoOO.().Location = New Point(x5, y5)
														IL_49E:
														num2 = 58
														Me.O.O0OOoOO.().Width = width3
													End If
												End If
											Else
												IL_4B3:
												num2 = 60
												If Operators.CompareString(left, "button1", True) = 0 Then
													IL_4C5:
													num2 = 61
													If array3.Length = 6 Then
														IL_4D2:
														num2 = 62
														Dim x6 As Integer
														Dim y6 As Integer
														Dim width4 As Integer
														Dim height2 As Integer
														If Integer.TryParse(array3(2), x6) AndAlso Integer.TryParse(array3(3), y6) AndAlso Integer.TryParse(array3(4), width4) AndAlso Integer.TryParse(array3(5), height2) Then
															IL_515:
															num2 = 63
															Me.O.O0OOoOO.().SetBounds(x6, y6, width4, height2)
															IL_52B:
															num2 = 64
															Me.O.O0OOoOO.().Text = array3(1)
														End If
													End If
												Else
													IL_542:
													num2 = 66
													If Operators.CompareString(left, "button2", True) = 0 Then
														IL_554:
														num2 = 67
														If array3.Length = 6 Then
															IL_561:
															num2 = 68
															Dim x7 As Integer
															Dim y7 As Integer
															Dim width5 As Integer
															Dim height3 As Integer
															If Integer.TryParse(array3(2), x7) AndAlso Integer.TryParse(array3(3), y7) AndAlso Integer.TryParse(array3(4), width5) AndAlso Integer.TryParse(array3(5), height3) Then
																IL_5A4:
																num2 = 69
																Me.o__o.O.().SetBounds(x7, y7, width5, height3)
																IL_5BA:
																num2 = 70
																Me.o__o.O.().Text = array3(1)
															End If
														End If
													Else
														IL_5D1:
														num2 = 72
														If Operators.CompareString(left, "FormBorder", True) = 0 Then
															IL_5E3:
															num2 = 73
															If array3.Length = 2 AndAlso Operators.CompareString(array3(1), "False", True) = 0 Then
																IL_604:
																num2 = 74
																MyBase.FormBorderStyle = FormBorderStyle.None
															End If
														Else
															IL_613:
															num2 = 76
															If Operators.CompareString(left, "grid", True) = 0 Then
																IL_625:
																num2 = 77
																If array3.Length = 5 Then
																	IL_632:
																	num2 = 78
																	Dim x8 As Integer
																	Dim y8 As Integer
																	Dim width6 As Integer
																	Dim height4 As Integer
																	If Integer.TryParse(array3(1), x8) AndAlso Integer.TryParse(array3(2), y8) AndAlso Integer.TryParse(array3(3), width6) AndAlso Integer.TryParse(array3(4), height4) Then
																		IL_675:
																		num2 = 79
																		Me.O.O0OOoOO.().SetBounds(x8, y8, width6, height4)
																	End If
																End If
															Else
																IL_690:
																num2 = 81
																If Operators.CompareString(left, "image1", True) = 0 OrElse Operators.CompareString(left, "image2", True) = 0 OrElse Operators.CompareString(left, "image3", True) = 0 Then
																	IL_6C3:
																	num2 = 82
																	If array3.Length = 2 AndAlso Operators.CompareString(array3(1), "", True) > 0 Then
																		IL_6E5:
																		num2 = 83
																		Dim text3 As String = Me.OooO.00o. + "\" + array3(1)
																		IL_6FE:
																		num2 = 84
																		If OO_00oOO.FileSys.FileExists(text3) Then
																			IL_712:
																			num2 = 85
																			Dim image As Image = OO_00oOO.GetImage(text3)
																			IL_71E:
																			num2 = 86
																			If image IsNot Nothing Then
																				IL_728:
																				num2 = 87
																				Dim left2 As String = array3(0)
																				IL_731:
																				num2 = 89
																				If Operators.CompareString(left2, "image1", True) = 0 Then
																					IL_743:
																					num2 = 90
																					Me.O.O0OOoOO.().Image = image
																					IL_753:
																					num2 = 91
																					If Operators.CompareString(Me.O.O0OOoOO.().Text, "", True) = 0 Then
																						IL_771:
																						num2 = 92
																						Me.O.O0OOoOO.().ImageAlign = ContentAlignment.MiddleCenter
																					End If
																				Else
																					IL_783:
																					num2 = 94
																					If Operators.CompareString(left2, "image2", True) = 0 Then
																						IL_795:
																						num2 = 95
																						Me.o__o.O.().Image = image
																						IL_7A5:
																						num2 = 96
																						If Operators.CompareString(Me.o__o.O.().Text, "", True) = 0 Then
																							IL_7C0:
																							num2 = 97
																							Me.o__o.O.().ImageAlign = ContentAlignment.MiddleCenter
																						End If
																					Else
																						IL_7D2:
																						num2 = 99
																						If Operators.CompareString(left2, "image3", True) = 0 Then
																							IL_7E4:
																							num2 = 100
																							Me.BackgroundImage = image
																							IL_7EF:
																							num2 = 101
																							Me.BackgroundImageLayout = ImageLayout.None
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
					IL_7F9:
					num2 = 102
				Next
				IL_80D:
				num2 = 103
				MyBase.CenterToScreen()
				IL_816:
				GoTo IL_A08
				IL_81B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_9C9:
				GoTo IL_9FD
				IL_9CB:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_9DB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9CB
			End Try
			IL_9FD:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A08:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003495 RID: 13461 RVA: 0x0015D4DC File Offset: 0x0015B6DC
		Public Sub New(A_0 As DataTable, A_1 As DataTable, A_2 As String, A_3 As Boolean)
			AddHandler MyBase.FormClosed, AddressOf Me.o_0_0__.o_.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.OO.OOoo_o.()
				IL_20:
				num = 2
				If OO_00oOO.ProjectFile IsNot Nothing Then
					GoTo IL_42
				End If
				IL_29:
				num = 3
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, O_O0OO.o_.oO_O0.)
				GoTo IL_59
				IL_42:
				num = 5
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_59:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_60:
				num = 7
				Me.OooO.00o. = A_0
				IL_69:
				num = 8
				Me.o.0___0_00oo0. = A_1
				IL_72:
				num = 9
				Me.OooO.00o. = A_2
				IL_7C:
				num = 10
				Me.O.O_0O0oO_. = A_3
				IL_87:
				num = 11
				A_0.DefaultView.RowFilter = ""
				IL_9A:
				num = 12
				Me.O.O0OOoOO.().TrimEnd = False
				IL_A9:
				num = 13
				Me.O.O0OOoOO.().TrimStart = False
				IL_B8:
				num = 14
				Me.O.O0OOoOO.().Cols(0).AllowEditing = False
				IL_D2:
				num = 15
				Me.O.O0OOoOO.().SelectionMode = 3
				IL_E1:
				num = 16
				Me.O.O0OOoOO.().HighLight = 2
				IL_F0:
				num = 17
				Me.O.O0OOoOO.().DrawMode = 1
				IL_FF:
				num = 18
				Dim dataRow As DataRow = Nothing
				IL_104:
				num = 19
				Dim enumerator As IEnumerator = A_0.Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow2 As DataRow = CType(obj, DataRow)
					IL_124:
					num = 20
					If Not dataRow2.IsNull("Type") AndAlso Conversions.ToInteger(dataRow2("Type")) = 7 Then
						IL_149:
						num = 21
						dataRow = dataRow2
						Exit While
					End If
					IL_151:
					num = 23
				End While
				IL_15D:
				num = 24
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_175:
				num = 25
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") AndAlso Operators.CompareString(dataRow("Config").ToString(), "", True) <> 0 Then
					GoTo IL_24D
				End If
				IL_1A8:
				num = 26
				Me.O.O0OOoOO.().Visible = False
				IL_1B7:
				num = 27
				Me.O.O0OOoOO.().Location = New Point(Me.O.O0OOoOO.().Location.X, Me.O.O0OOoOO.().Location.Y)
				IL_1F2:
				num = 28
				Me.o__o.O.().Location = New Point(Me.o__o.O.().Location.X, Me.O.O0OOoOO.().Location.Y)
				IL_22D:
				num = 29
				MyBase.Height -= Me.O.O0OOoOO.().Height
				GoTo IL_641
				IL_24D:
				num = 31
				If dataRow Is Nothing AndAlso dataRow.IsNull("Config") AndAlso Operators.CompareString(dataRow("Config").ToString(), "", True) <= 0 Then
					GoTo IL_641
				End If
				IL_281:
				num = 32
				Dim text As String = dataRow("Config").ToString()
				IL_296:
				num = 33
				Dim flag As Boolean = True
				IL_29C:
				num = 34
				If Not(text.StartsWith("{") And text.EndsWith("}")) Then
					GoTo IL_2DC
				End If
				IL_2BA:
				num = 35
				flag = False
				IL_2C0:
				num = 36
				text = text.Trim(New Char() { "{"c, "}"c })
				IL_2DC:
				num = 37
				Me.OooO.00o. = text.Split(New Char() { vbCr })
				IL_2F7:
				num = 38
				For Each text2 As String In Me.OooO.00o.
					IL_311:
					num = 39
					Dim array As String() = text2.Split(New Char() { vbTab })
					IL_328:
					num = 40
					If Operators.CompareString(array(0), "", True) <> 0 Then
						IL_33F:
						num = 42
						Dim c1FlexGrid As C1FlexGrid = Me.O.O0OOoOO.()
						IL_34A:
						num = 43
						c1FlexGrid.Rows.Count = c1FlexGrid.Rows.Count + 1
						IL_367:
						num = 44
						c1FlexGrid(c1FlexGrid.Rows.Count - 1, 0) = array(0)
						IL_384:
						num = 45
						Dim cellRange As CellRange = Me.O.O0OOoOO.().GetCellRange(c1FlexGrid.Rows.Count - 1, 1)
						IL_3A3:
						num = 46
						If Operators.CompareString(array(2), "", True) > 0 Then
							IL_3B8:
							num = 47
							cellRange.StyleNew.ComboList = array(2)
						End If
						IL_3CB:
						num = 48
						If Operators.CompareString(array(1), "0", True) = 0 Then
							IL_3DF:
							num = 49
							cellRange.StyleNew.DataType = GetType(String)
							IL_3F8:
							num = 50
							If array.Length = 4 Then
								IL_405:
								num = 51
								c1FlexGrid(c1FlexGrid.Rows.Count - 1, 1) = array(3)
							End If
						Else
							IL_427:
							num = 53
							If Operators.CompareString(array(1), "1", True) = 0 Then
								IL_43B:
								num = 54
								cellRange.StyleNew.DataType = GetType(Double)
								IL_454:
								num = 55
								If array.Length = 4 Then
									IL_461:
									num = 56
									Dim num3 As Double
									If Double.TryParse(array(3), num3) Then
										IL_474:
										num = 57
										c1FlexGrid(c1FlexGrid.Rows.Count - 1, 1) = num3
									End If
								End If
							Else
								IL_499:
								num = 59
								If Operators.CompareString(array(1), "2", True) = 0 Then
									IL_4B0:
									num = 60
									cellRange.StyleNew.DataType = GetType(DateTime)
									IL_4C9:
									num = 61
									cellRange.StyleNew.Format = "yyyy-MM-dd"
									IL_4DD:
									num = 62
									cellRange.StyleNew.Editor = O_O0OO.o0_OO.000.()
									IL_4F1:
									num = 63
									If array.Length = 4 Then
										IL_4FE:
										num = 64
										Dim dateTime As DateTime
										If DateTime.TryParse(array(3), dateTime) Then
											IL_511:
											num = 65
											c1FlexGrid(c1FlexGrid.Rows.Count - 1, 1) = dateTime
										End If
									End If
								Else
									IL_536:
									num = 67
									If Operators.CompareString(array(1), "3", True) = 0 Then
										IL_54A:
										num = 68
										cellRange.StyleNew.DataType = GetType(Boolean)
										IL_563:
										num = 69
										If array.Length = 4 Then
											IL_570:
											num = 70
											Dim flag2 As Boolean
											If Boolean.TryParse(array(3), flag2) Then
												IL_583:
												num = 71
												c1FlexGrid(c1FlexGrid.Rows.Count - 1, 1) = flag2
											End If
										End If
									Else
										IL_5A8:
										num = 73
										If Operators.CompareString(array(1), "4", True) = 0 Then
											IL_5BC:
											num = 74
											cellRange.StyleNew.DataType = GetType(String)
											IL_5D5:
											num = 75
											c1FlexGrid.Rows(c1FlexGrid.Rows.Count - 1).UserData = "pwd"
											IL_5FC:
											num = 76
											If flag Then
												IL_603:
												num = 77
												If array.Length = 4 Then
													IL_60D:
													num = 78
													c1FlexGrid(c1FlexGrid.Rows.Count - 1, 1) = array(3)
												End If
											End If
										End If
									End If
								End If
							End If
						End If
						IL_62A:
						c1FlexGrid = Nothing
					End If
					IL_62D:
					num = 80
				Next
				IL_641:
				num = 81
				Me.o__o.O.()
				IL_64A:
				GoTo IL_7E4
				IL_64F:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_7A5:
				GoTo IL_7D9
				IL_7A7:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_7B7:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_7A7
			End Try
			IL_7D9:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7E4:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003496 RID: 13462 RVA: 0x0015DCF4 File Offset: 0x0015BEF4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim array As DataRow() = Me.OooO.00o..[Select]("[Name] = '" + Me.O.O0OOoOO.().Text + "'")
				IL_2F:
				num2 = 3
				If array.Length <> 0 Then
					GoTo IL_5F
				End If
				IL_36:
				num2 = 4
				MessageBox.Show(O00.DecryptText("6++xAA66aLSS/2MaXdl/ajlP96cX+UbwP9X5hk+Opk8=", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_512
				IL_5F:
				num2 = 6
				Dim dataRow As DataRow = array(0)
				IL_66:
				num2 = 7
				Dim userProperty As UserProperty = New UserProperty()
				IL_6F:
				num2 = 8
				Dim text As String = O_O0OO.o0_OO.000.(Me.o.0___0_00oo0..DataSet)
				IL_83:
				num2 = 9
				o_O_o_oOoo__.OOOO_OO._oo.(userProperty, Conversions.ToString(dataRow("Config")), vbVerticalTab)
				IL_A0:
				num2 = 10
				If Operators.CompareString(userProperty.PassWord, O00.MD5Encrypt(O00.ooo000o_0.00o0.(Me.O.O0OOoOO.().Text, text.Substring(0, 8), text.Substring(text.Length - 8))), True) <> 0 AndAlso (userProperty.Type = 1 OrElse userProperty.Type Is Nothing OrElse Operators.CompareString(userProperty.PassWord, O00.MD5Encrypt(Me.O.O0OOoOO.().Text), True) <> 0) Then
					GoTo IL_4ED
				End If
				IL_11B:
				num2 = 11
				Me.OooO.00o. = New UserInfo()
				IL_129:
				num2 = 12
				Me.OooO.00o..Name = Conversions.ToString(dataRow("Name"))
				IL_148:
				num2 = 13
				Me.OooO.00o..Group = userProperty.Group
				IL_15D:
				num2 = 14
				Me.OooO.00o..Roles = userProperty.Role
				IL_172:
				num2 = 15
				Me.OooO.00o..Tag = userProperty.Tag
				IL_187:
				num2 = 16
				Me.OooO.00o..Password = userProperty.PassWord
				IL_19C:
				num2 = 17
				If Operators.CompareString(Me.OooO.00o..Tag, "", True) <= 0 Then
					GoTo IL_26D
				End If
				IL_1BB:
				num2 = 18
				Dim array2 As String() = Me.OooO.00o..Tag.Split(New Char() { "|"c })
				IL_1DB:
				num2 = 19
				For Each text2 As String In array2
					IL_1EE:
					num2 = 20
					If text2.StartsWith("**") Then
						IL_1FF:
						num2 = 21
						text2 = text2.Trim(New Char() { "*"c })
						IL_216:
						num2 = 22
						If Not UKey.Start() OrElse Operators.CompareString(text2, UKey.UID, True) <> 0 Then
							IL_22F:
							num2 = 23
							MessageBox.Show(O00.DecryptText("ldiL5ZtPgp1Ocj6c/7/37b1s//rHYAK/7zh1Ma1hHts=", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							GoTo IL_512
						End If
					End If
					IL_259:
					num2 = 25
				Next
				IL_26D:
				num2 = 26
				If userProperty.Type = 3 Then
					GoTo IL_291
				End If
				IL_27A:
				num2 = 27
				Me.OooO.00o..Type = userProperty.Type
				GoTo IL_2B0
				IL_291:
				num2 = 29
				Me.OooO.00o..Type = Conversions.ToInteger(dataRow("Type"))
				IL_2B0:
				num2 = 30
				If Me.OooO.00o..Type Is Nothing AndAlso Me.O.O_0O0oO_. Then
					GoTo IL_512
				End If
				IL_2CB:
				num2 = 32
				If Me.OooO.00o..Type <> 1 AndAlso Me.OooO.00o..Type IsNot Nothing Then
					GoTo IL_3A2
				End If
				IL_2EC:
				num2 = 33
				If Me.OooO.00o..Type <> 1 Then
					GoTo IL_305
				End If
				IL_2FD:
				num2 = 34
				Dim o0_O As o0_O = o0_O.o_.OOO.
				GoTo IL_30B
				IL_305:
				num2 = 36
				o0_O = o0_O.ooO.Oo_0O0.
				IL_30B:
				num2 = 37
				Dim dataTable As DataTable = Me.o.0___0_00oo0.
				IL_316:
				num2 = 38
				Dim dataRow2 As DataRow = dataTable.Rows.Find(New Object() { "Config", o0_O })
				IL_33F:
				num2 = 39
				If dataRow2 Is Nothing Then
					GoTo IL_39F
				End If
				IL_346:
				num2 = 40
				If Operators.CompareString(Conversions.ToString(dataRow2("Config")), O00.MD5Encrypt(userProperty.PassWord).Substring(0, 8), True) = 0 Then
					GoTo IL_39F
				End If
				IL_375:
				num2 = 41
				MessageBox.Show(O00.DecryptText("h6WeLTVRHfSD/3gFdjBy9A==", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				GoTo IL_512
				IL_39F:
				dataTable = Nothing
				IL_3A2:
				num2 = 44
				If Me.OooO.00o..Type <> 4 Then
					GoTo IL_3D1
				End If
				IL_3B3:
				num2 = 45
				Me.OooO.00o..Type = 2
				IL_3C2:
				num2 = 46
				Me.OooO.00o..[Default] = True
				IL_3D1:
				num2 = 47
				Dim dataRow3 As DataRow = Me.o.0___0_00oo0..Rows.Find(New Object() { "LastLogonUser", o0_O.ooO__0.oO_0_. })
				IL_3FE:
				num2 = 48
				If dataRow3 IsNot Nothing Then
					GoTo IL_454
				End If
				IL_405:
				num2 = 49
				dataRow3 = Me.o.0___0_00oo0..NewRow()
				IL_415:
				num2 = 50
				dataRow3("Name") = "LastLogonUser"
				IL_429:
				num2 = 51
				dataRow3("Type") = o0_O.ooO__0.oO_0_.
				IL_43F:
				num2 = 52
				Me.o.0___0_00oo0..Rows.Add(dataRow3)
				IL_454:
				num2 = 53
				If Operators.CompareString(dataRow3("Config").ToString(), Me.OooO.00o..Name, True) = 0 Then
					GoTo IL_495
				End If
				IL_47B:
				num2 = 54
				dataRow3("Config") = Me.OooO.00o..Name
				IL_495:
				num2 = 55
				Me.o__O__ooO._o.()
				IL_49E:
				num2 = 56
				MyBase.DialogResult = DialogResult.OK
				IL_4A8:
				num2 = 57
				If Me.OooO.00o. IsNot Nothing OrElse Me.o0O.OO00OOOO_0. Then
					GoTo IL_512
				End If
				IL_4BB:
				num2 = 58
				Main.ProcessForm.Show()
				IL_4C8:
				num2 = 59
				Main.ProcessForm.Activate()
				IL_4D5:
				num2 = 60
				Main.ProcessForm.Focus()
				IL_4E3:
				num2 = 61
				Application.DoEvents()
				GoTo IL_512
				IL_4ED:
				num2 = 63
				MessageBox.Show(O00.DecryptText("orJKZaEkG7xneDQ8hKZC2w==", "datatable", "datarow"), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				IL_512:
				GoTo IL_664
				IL_517:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_625:
				GoTo IL_659
				IL_627:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_637:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_627
			End Try
			IL_659:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_664:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003497 RID: 13463 RVA: 0x0015E38C File Offset: 0x0015C58C
		Private Sub <<EMPTY_NAME>>()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.OooO.00o..ExtendedValues.Clear()
				IL_19:
				num2 = 3
				If Not Me.O.O0OOoOO.().Visible Then
					GoTo IL_247
				End If
				IL_2B:
				num2 = 5
				Dim num3 As Integer = Me.O.O0OOoOO.().Rows.Count - Me.O.O0OOoOO.().Rows.Fixed - 1
				For i As Integer = 0 To num3
					IL_5A:
					num2 = 6
					Dim c1FlexGrid As C1FlexGrid = Me.O.O0OOoOO.()
					IL_64:
					num2 = 7
					Me.OooO.00o..ExtendedValues.Add(c1FlexGrid.GetData(i + 1, 0).ToString(), RuntimeHelpers.GetObjectValue(c1FlexGrid.GetData(i + 1, 1)))
					IL_98:
					num2 = 8
					If c1FlexGrid.GetData(i + 1, 1) IsNot Nothing Then
						IL_AB:
						num2 = 9
						Dim array As String() = Me.OooO.00o.(i).Split(New Char() { vbTab })
						IL_C9:
						num2 = 10
						If array.Length = 4 Then
							IL_D3:
							num2 = 11
							array(3) = c1FlexGrid.GetData(i + 1, 1).ToString()
							IL_EB:
							num2 = 12
							Me.OooO.00o.(i) = String.Join(vbTab, array)
						Else
							IL_105:
							num2 = 14
							Me.OooO.00o.(i) = Me.OooO.00o.(i) + vbTab + c1FlexGrid.GetData(i + 1, 1).ToString()
						End If
					End If
					IL_135:
					c1FlexGrid = Nothing
					IL_138:
					num2 = 16
				Next
				IL_14A:
				num2 = 17
				Dim dataRow As DataRow = Nothing
				IL_14F:
				num2 = 18
				Dim enumerator As IEnumerator = Me.OooO.00o..Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow2 As DataRow = CType(obj, DataRow)
					IL_174:
					num2 = 19
					If Conversions.ToInteger(dataRow2("Type")) = 7 Then
						IL_18B:
						num2 = 20
						dataRow = dataRow2
						Exit While
					End If
					IL_193:
					num2 = 22
				End While
				IL_19F:
				num2 = 23
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_1B7:
				num2 = 24
				Dim text As String = dataRow("Config").ToString()
				IL_1CC:
				num2 = 25
				If Not text.StartsWith("{") OrElse Not text.EndsWith("}") Then
					GoTo IL_21A
				End If
				IL_1EB:
				num2 = 26
				dataRow("Config") = "{" + String.Join(vbCr, Me.OooO.00o.) + "}"
				GoTo IL_238
				IL_21A:
				num2 = 28
				dataRow("Config") = String.Join(vbCr, Me.OooO.00o.)
				IL_238:
				num2 = 29
				Oo00.o0_o._O_.(Me.OooO.00o., True)
				IL_247:
				GoTo IL_311
				IL_24C:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_2D2:
				GoTo IL_306
				IL_2D4:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2E4:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_2D4
			End Try
			IL_306:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_311:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003498 RID: 13464 RVA: 0x0015E6D0 File Offset: 0x0015C8D0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Me.Oo_.o. = True
		End Sub

		' Token: 0x06003499 RID: 13465 RVA: 0x0015E6DC File Offset: 0x0015C8DC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RangeEventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.O.O0OOoOO.()
			If c1FlexGrid.Col = 0 Then
				c1FlexGrid.Col = 1
			End If
		End Sub

		' Token: 0x0600349A RID: 13466 RVA: 0x0015E704 File Offset: 0x0015C904
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As OwnerDrawCellEventArgs)
			If Me.O.O0OOoOO.().Rows(A_1.Row).UserData IsNot Nothing AndAlso A_1.Col = 1 AndAlso Operators.CompareString(A_1.Text, "", True) > 0 Then
				A_1.Text = New String("*"c, A_1.Text.Length)
			End If
		End Sub

		' Token: 0x0600349B RID: 13467 RVA: 0x0015E768 File Offset: 0x0015C968
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.O.O0OOoOO.()
			If TypeOf c1FlexGrid.Editor Is TextBox Then
				If c1FlexGrid.Rows(A_1.Row).UserData IsNot Nothing Then
					CType(c1FlexGrid.Editor, TextBox).PasswordChar = "*"c
				Else
					CType(c1FlexGrid.Editor, TextBox).PasswordChar = vbNullChar
				End If
			End If
		End Sub

		' Token: 0x0600349C RID: 13468 RVA: 0x0015E7C8 File Offset: 0x0015C9C8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001568 RID: 5480
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001569 RID: 5481
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400156A RID: 5482
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400156B RID: 5483
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400156C RID: 5484
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400156D RID: 5485
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400156E RID: 5486
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400156F RID: 5487
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001570 RID: 5488
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001571 RID: 5489
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001572 RID: 5490
		Private <<EMPTY_NAME>> As DataTable

		' Token: 0x04001573 RID: 5491
		Private <<EMPTY_NAME>> As SplashFormStateEnum

		' Token: 0x04001574 RID: 5492
		Friend <<EMPTY_NAME>> As UserInfo

		' Token: 0x04001575 RID: 5493
		Private <<EMPTY_NAME>> As String()

		' Token: 0x04001576 RID: 5494
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001577 RID: 5495
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001578 RID: 5496
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001579 RID: 5497
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
