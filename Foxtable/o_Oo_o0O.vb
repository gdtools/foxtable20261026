Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports C1.Win.C1Ribbon
Imports Foxtable.My
Imports Foxtable.My.Resources
Imports Foxtable.RibbonMenu
Imports Foxtable.Syscmd
Imports Foxtable.WinForm
Imports Foxtable.Word
Imports Foxtable.XLS
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020004B7 RID: 1207
	Friend Class o_Oo_o0O
		' Token: 0x06004E29 RID: 20009 RVA: 0x00204A7C File Offset: 0x00202C7C
		Public Sub New()
			Me.O_o._0oo0o0_0. = "Connected"
			Me.o.o_0o_O0O_. = ""
		End Sub

		' Token: 0x06004E2A RID: 20010 RVA: 0x00204A9C File Offset: 0x00202C9C
		Friend Sub <<EMPTY_NAME>>(A_0 As C1Ribbon, A_1 As Dictionary(Of String, o__o_OO_o_), A_2 As C1CommandHolder, A_3 As Ribbon)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim dataTable As DataTable = A_3.DataTable
				IL_11:
				num2 = 3
				Dim list As List(Of RibbonTab) = New List(Of RibbonTab)()
				IL_1A:
				num2 = 4
				Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_23:
				num2 = 5
				Dim list2 As List(Of RibbonContextualTabGroup) = New List(Of RibbonContextualTabGroup)()
				IL_2C:
				num2 = 6
				Me.O_o._0oo0o0_0. = A_2
				IL_35:
				num2 = 7
				A_2.Commands.Clear()
				IL_42:
				num2 = 8
				If Operators.CompareString(A_3.Text, "", True) <> 0 Then
					GoTo IL_67
				End If
				IL_58:
				num2 = 9
				A_3.Text = "Foxtable"
				IL_67:
				num2 = 10
				If Not A_3.ShowFileName Then
					GoTo IL_DC
				End If
				IL_73:
				num2 = 11
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) <> 0 Then
					GoTo IL_A8
				End If
				IL_88:
				num2 = 12
				Main.OO_O.o..Text = A_3.Text + " - 新项目"
				GoTo IL_F0
				IL_A8:
				num2 = 14
				Main.OO_O.o..Text = A_3.Text + " - " + Foxtable.My.c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile)
				GoTo IL_F0
				IL_DC:
				num2 = 16
				Main.OO_O.o..Text = A_3.Text
				IL_F0:
				num2 = 17
				O_O0OO.o_Oo0_oOo.0. = A_3.ShowFileName
				IL_FF:
				num2 = 18
				A_0.Text = A_3.Text
				IL_10F:
				num2 = 19
				A_0.AllowMinimize = A_3.AllowMinimize
				IL_11F:
				num2 = 20
				A_0.Minimized = A_3.Minimized
				IL_12F:
				num2 = 21
				A_0.HideTabHeaderRow = A_3.HideTabHederRow
				IL_13F:
				num2 = 22
				If Operators.CompareString(A_3.Image, "", True) <= 0 Then
					GoTo IL_171
				End If
				IL_157:
				num2 = 23
				A_0.ApplicationMenu.SmallImage = OO_00oOO.GetImage(A_3.Image)
				IL_171:
				num2 = 24
				If A_0.ApplicationMenu.SmallImage IsNot Nothing Then
					GoTo IL_199
				End If
				IL_181:
				num2 = 25
				A_0.ApplicationMenu.SmallImage = Foxtable.My.Resources.a.oo.O00O.().ToBitmap()
				IL_199:
				num2 = 26
				A_0.Qat.Items.Clear()
				IL_1AC:
				num2 = 27
				A_0.ConfigToolBar.Items.Clear()
				IL_1BF:
				num2 = 28
				A_0.TopToolBar.Items.Clear()
				IL_1D2:
				num2 = 29
				A_0.BottomToolBar.Items.Clear()
				IL_1E5:
				num2 = 30
				A_0.ApplicationMenu.LeftPaneItems.Clear()
				IL_1F8:
				num2 = 31
				A_0.ApplicationMenu.RightPaneItems.Clear()
				IL_20B:
				num2 = 32
				A_0.ApplicationMenu.BottomPaneItems.Clear()
				IL_21E:
				num2 = 33
				A_0.ApplicationMenu.Text = "文件"
				IL_231:
				num2 = 34
				Dim array As DataRow() = dataTable.[Select]("[Type] = " + Conversions.ToString(0))
				IL_24C:
				num2 = 35
				If array.Length = 0 Then
					GoTo IL_CD9
				End If
				IL_258:
				num2 = 38
				A_0.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_274:
				num2 = 39
				A_0.Qat.BelowRibbon = A_3.O0o.O00..BelowRibbon
				IL_28E:
				num2 = 40
				A_0.Qat.Visible = A_3.O0o.O00..Visible
				IL_2A8:
				num2 = 41
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(2))
				IL_2C3:
				num2 = 42
				If array.Length <= 0 Then
					GoTo IL_307
				End If
				IL_2CD:
				num2 = 43
				Me.o0O0.Oo0_OOO0.(A_0.Qat.Items, array(0), RibbonPaneEnum.Left)
				IL_2E6:
				num2 = 44
				A_0.Qat.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_307:
				num2 = 45
				A_0.ConfigToolBar.Visible = A_3.O0o.O00..Visible
				IL_321:
				num2 = 46
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(3))
				IL_33C:
				num2 = 47
				If array.Length <= 0 Then
					GoTo IL_380
				End If
				IL_346:
				num2 = 48
				Me.o0O0.Oo0_OOO0.(A_0.ConfigToolBar.Items, array(0), RibbonPaneEnum.Left)
				IL_35F:
				num2 = 49
				A_0.ConfigToolBar.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_380:
				num2 = 50
				A_0.BottomToolBar.Visible = A_3.O0o.O00..Visible
				IL_39A:
				num2 = 51
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(36))
				IL_3B6:
				num2 = 52
				If array.Length <= 0 Then
					GoTo IL_3FA
				End If
				IL_3C0:
				num2 = 53
				Me.o0O0.Oo0_OOO0.(A_0.BottomToolBar.Items, array(0), RibbonPaneEnum.Left)
				IL_3D9:
				num2 = 54
				A_0.BottomToolBar.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_3FA:
				num2 = 55
				A_0.TopToolBar.Visible = A_3.oo00OO_0.0o000..Visible
				IL_414:
				num2 = 56
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(35))
				IL_430:
				num2 = 57
				If array.Length <= 0 Then
					GoTo IL_474
				End If
				IL_43A:
				num2 = 58
				Me.o0O0.Oo0_OOO0.(A_0.TopToolBar.Items, array(0), RibbonPaneEnum.Left)
				IL_453:
				num2 = 59
				A_0.TopToolBar.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_474:
				num2 = 60
				Dim array2 As RibbonItemCollection() = New RibbonItemCollection() { A_0.ConfigToolBar.Items, A_0.TopToolBar.Items, A_0.BottomToolBar.Items }
				IL_4A9:
				num2 = 61
				For Each a_ As RibbonItemCollection In array2
					IL_4BC:
					num2 = 62
					Me.OO.0OO0oo0O_O.(a_)
					IL_4C7:
					num2 = 63
				Next
				IL_4D8:
				num2 = 64
				A_0.ApplicationMenu.DropDownWidth = A_3.O0o.O00..DropdownWidth
				IL_4F2:
				num2 = 65
				A_0.ApplicationMenu.Visible = A_3.O0o.O00..Visible
				IL_50C:
				num2 = 66
				A_0.ApplicationMenu.Text = A_3.O0o.O00..Text
				IL_526:
				num2 = 67
				array = dataTable.[Select]("[Type] = " + Conversions.ToString(1))
				IL_541:
				num2 = 68
				If array.Length <= 0 Then
					GoTo IL_5B7
				End If
				IL_54B:
				num2 = 69
				Me.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.LeftPaneItems, array(0), RibbonPaneEnum.Left)
				IL_564:
				num2 = 70
				Me.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.RightPaneItems, array(0), RibbonPaneEnum.Right)
				IL_57D:
				num2 = 71
				Me.o0O0.Oo0_OOO0.(A_0.ApplicationMenu.BottomPaneItems, array(0), RibbonPaneEnum.Bottom)
				IL_596:
				num2 = 72
				A_0.ApplicationMenu.Tag = RuntimeHelpers.GetObjectValue(array(0)("Key"))
				IL_5B7:
				num2 = 73
				O_O0OO.o0OoO00OO.00O. = A_3.O0o.O00..RecentFiles
				IL_5CB:
				ProjectData.ClearProjectError()
				num = 0
				IL_5D2:
				num2 = 75
				Dim type As Type = Assembly.GetExecutingAssembly().[GetType](o0OoOOoOOo0.O_00o0.O0OO_0.(0) + "." + o0OoOOoOOo0.O_00o0.O0OO_0.(1))
				IL_5F9:
				num2 = 76
				Dim method As MethodInfo = type.GetMethod(o0OoOOoOOo0.O_00o0.O0OO_0.(2), BindingFlags.[Static] Or BindingFlags.NonPublic)
				IL_60E:
				num2 = 77
				Me.o.o_0o_O0O_. = method.Name
				IL_61E:
				num2 = 78
				For Each dataRow As DataRow In dataTable.[Select]("[Type] = " + Conversions.ToString(5), "Index", DataViewRowState.CurrentRows)
					IL_64F:
					num2 = 79
					Dim ribbonTab As RibbonTab = New RibbonTab()
					IL_659:
					num2 = 80
					Dim ribbonTab2 As RibbonTab = New RibbonTab(dataRow)
					IL_665:
					num2 = 81
					ribbonTab.ID = ribbonTab2.Name
					IL_676:
					num2 = 82
					ribbonTab.Text = ribbonTab2.Text
					IL_687:
					num2 = 83
					ribbonTab.ToolTip = ribbonTab2.ToolTip
					IL_698:
					num2 = 84
					ribbonTab.Enabled = ribbonTab2.Enabled
					IL_6A9:
					num2 = 85
					ribbonTab.Visible = ribbonTab2.Visible
					IL_6BA:
					num2 = 86
					ribbonTab.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					IL_6D5:
					num2 = 87
					If Operators.CompareString(ribbonTab2.TopTab, "", True) > 0 Then
						IL_6ED:
						num2 = 88
						dictionary.Add(ribbonTab.ID, ribbonTab2.TopTab)
					End If
					IL_705:
					num2 = 89
					If Operators.CompareString(ribbonTab2.Image, "", True) > 0 Then
						IL_71D:
						num2 = 90
						ribbonTab.Image = OO_00oOO.GetImage(ribbonTab2.Image)
					End If
					IL_733:
					num2 = 91
					For Each dataRow2 As DataRow In dataTable.[Select]("[ParentKey] = '" + dataRow("Key").ToString() + "'", "Index")
						IL_772:
						num2 = 92
						If Conversions.ToInteger(dataRow2("Type")) = 7 Then
							IL_78C:
							num2 = 93
							Dim ribbonGroup As RibbonGroup = New RibbonGroup()
							IL_796:
							num2 = 94
							Dim ribbonGroup2 As RibbonGroup = New RibbonGroup(dataRow2)
							IL_7A2:
							num2 = 95
							ribbonGroup.ID = ribbonGroup2.Name
							IL_7B3:
							num2 = 96
							ribbonGroup.Text = ribbonGroup2.Text
							IL_7C4:
							num2 = 97
							ribbonGroup.ToolTip = ribbonGroup2.ToolTip
							IL_7D5:
							num2 = 98
							ribbonGroup.Enabled = ribbonGroup2.Enabled
							IL_7E6:
							num2 = 99
							ribbonGroup.Visible = ribbonGroup2.Visible
							IL_7F7:
							num2 = 100
							ribbonGroup.HasLauncherButton = ribbonGroup2.HasLauncherButton
							IL_808:
							num2 = 101
							ribbonGroup.Tag = RuntimeHelpers.GetObjectValue(dataRow2("Key"))
							IL_823:
							num2 = 102
							If Operators.CompareString(ribbonGroup2.Image, "", True) > 0 Then
								IL_83B:
								num2 = 103
								ribbonGroup.Image = OO_00oOO.GetImage(ribbonGroup2.Image)
							End If
							IL_851:
							num2 = 104
							ribbonTab.Groups.Add(ribbonGroup)
							IL_863:
							num2 = 105
							Me.o0O0.Oo0_OOO0.(ribbonGroup.Items, dataRow2, RibbonPaneEnum.Left)
						End If
						IL_876:
						num2 = 106
					Next
					IL_88A:
					num2 = 107
					list.Add(ribbonTab)
					IL_896:
					num2 = 108
				Next
				IL_8AA:
				num2 = 109
				For Each dataRow As DataRow In dataTable.[Select]("[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows)
					IL_8DC:
					num2 = 110
					Dim ribbonContextualTabGroup As RibbonContextualTabGroup = New RibbonContextualTabGroup()
					IL_8E6:
					num2 = 111
					Dim ribbonTopTab As RibbonTopTab = New RibbonTopTab(dataRow)
					IL_8F2:
					num2 = 112
					ribbonContextualTabGroup.Color = ribbonTopTab.Color
					IL_903:
					num2 = 113
					ribbonContextualTabGroup.ForeColor = ribbonTopTab.ForeColor
					IL_914:
					num2 = 114
					ribbonContextualTabGroup.Name = ribbonTopTab.Name
					IL_925:
					num2 = 115
					ribbonContextualTabGroup.Text = ribbonTopTab.Text
					IL_936:
					num2 = 116
					ribbonContextualTabGroup.ToolTip = ribbonTopTab.ToolTip
					IL_947:
					num2 = 117
					ribbonContextualTabGroup.Clickable = ribbonTopTab.Clickable
					IL_958:
					num2 = 118
					ribbonContextualTabGroup.Visible = ribbonTopTab.Visible
					IL_969:
					num2 = 119
					list2.Add(ribbonContextualTabGroup)
					IL_975:
					num2 = 120
				Next
				IL_989:
				num2 = 121
				A_0.ContextualTabGroups.Clear()
				IL_997:
				num2 = 122
				A_0.Tabs.Clear()
				IL_9A5:
				num2 = 123
				Dim enumerator As List(Of RibbonContextualTabGroup).Enumerator = list2.GetEnumerator()
				While enumerator.MoveNext()
					Dim ribbonContextualTabGroup2 As RibbonContextualTabGroup = enumerator.Current
					IL_9BC:
					num2 = 124
					A_0.ContextualTabGroups.Add(ribbonContextualTabGroup2)
					IL_9CD:
					num2 = 125
				End While
				IL_9D9:
				num2 = 126
				CType(enumerator, IDisposable).Dispose()
				IL_9E9:
				num2 = 127
				Dim enumerator2 As List(Of RibbonTab).Enumerator = list.GetEnumerator()
				While enumerator2.MoveNext()
					Dim ribbonTab3 As RibbonTab = enumerator2.Current
					IL_A03:
					num2 = 128
					If dictionary.ContainsKey(ribbonTab3.ID) AndAlso A_0.ContextualTabGroups.Contains(dictionary(ribbonTab3.ID)) Then
						IL_A34:
						num2 = 129
						A_0.ContextualTabGroups(dictionary(ribbonTab3.ID)).Tabs.Add(ribbonTab3)
					Else
						IL_A62:
						num2 = 131
						A_0.Tabs.Add(ribbonTab3)
					End If
					IL_A76:
					num2 = 132
				End While
				IL_A88:
				num2 = 133
				CType(enumerator2, IDisposable).Dispose()
				IL_A9B:
				num2 = 134
				A_0.SelectedTab = Nothing
				IL_AA8:
				num2 = 135
				A_1.Clear()
				IL_AB4:
				num2 = 136
				For Each dataRow As DataRow In dataTable.[Select]("[Type] = " + Conversions.ToString(128), "Index", DataViewRowState.CurrentRows)
					IL_AEC:
					num2 = 137
					Dim o__o_OO_o_ As o__o_OO_o_ = New o__o_OO_o_()
					IL_AF9:
					num2 = 138
					Dim contextMenu As Foxtable.ContextMenu = New Foxtable.ContextMenu(dataRow)
					IL_B08:
					num2 = 139
					o__o_OO_o_.Name = contextMenu.Name
					IL_B1C:
					num2 = 140
					o__o_OO_o_.UserData = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					IL_B3A:
					num2 = 141
					Me.Oo.oO_ooo_o0.(o__o_OO_o_.CommandLinks, dataRow)
					IL_B4F:
					num2 = 142
					A_1.Add(contextMenu.Name, o__o_OO_o_)
					IL_B64:
					num2 = 143
					If A_0.FindForm() Is OO_00oOO.BaseMainForm Then
						IL_B77:
						num2 = 144
						o__o_OO_o_.Popup += AddressOf Me.o0O0.o.
						IL_B90:
						num2 = 145
						o__o_OO_o_.Closed += AddressOf Me.o.0oO0ooO__ooo.
					End If
					IL_BA9:
					num2 = 146
				Next
				IL_BC0:
				num2 = 147
				If dataTable.DataSet IsNot Nothing Then
					GoTo IL_CD9
				End If
				IL_BD1:
				num2 = 148
				If O_O0OO.o.0__0_O_. IsNot Nothing Then
					GoTo IL_C8B
				End If
				IL_BE1:
				num2 = 149
				O_O0OO.o.0__0_O_. = New RibbonButton()
				IL_BF1:
				num2 = 150
				O_O0OO.o.0__0_O_..SmallImage = Foxtable.My.Resources.a.OOo_0_0oo._0o_.().ToBitmap()
				IL_C0B:
				num2 = 151
				O_O0OO.o.0__0_O_..ToolTip = "Power by Foxtable"
				IL_C20:
				num2 = 152
				O_O0OO.o.0__0_O_..Name = "FoxHomeButton"
				IL_C35:
				num2 = 153
				O_O0OO.o.0__0_O_..Click += AddressOf Me.OO_00O00.OO.
				IL_C51:
				num2 = 154
				If dataTable.DataSet IsNot Nothing Then
					GoTo IL_C76
				End If
				IL_C5F:
				num2 = 155
				O_O0OO.o.0__0_O_..Tag = "System"
				GoTo IL_C8B
				IL_C76:
				num2 = 157
				O_O0OO.o.0__0_O_..Tag = "User"
				IL_C8B:
				num2 = 158
				A_0.ConfigToolBar.Items.Add(O_O0OO.o.0__0_O_.)
				IL_CD9:
				GoTo IL_FB7
				IL_CA9:
				num2 = 160
				If Information.Err().Number = 0 Then
					GoTo IL_CD9
				End If
				IL_CBB:
				num2 = 161
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_CD9
				IL_CDE:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_F78:
				GoTo IL_FAC
				IL_F7A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F8A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F7A
			End Try
			IL_FAC:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_FB7:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06004E2B RID: 20011 RVA: 0x00205A84 File Offset: 0x00203C84
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonItemCollection)
			Try
				For Each obj As Object In A_0
					Dim ribbonItem As RibbonItem = CType(obj, RibbonItem)
					If TypeOf ribbonItem Is RibbonButton Then
						Dim ribbonButton As RibbonButton = CType(ribbonItem, RibbonButton)
						If Operators.CompareString(ribbonButton.Text, "", True) > 0 Then
							ribbonButton.Text = ribbonButton.Text.Trim()
						End If
					End If
					If TypeOf ribbonItem Is RibbonSplitButton Then
						Dim ribbonSplitButton As RibbonSplitButton = CType(ribbonItem, RibbonSplitButton)
						If Operators.CompareString(ribbonSplitButton.Text, "", True) > 0 Then
							ribbonSplitButton.Text = ribbonSplitButton.Text.Trim()
						End If
					End If
					If TypeOf ribbonItem Is RibbonMenu Then
						Dim ribbonMenu As RibbonMenu = CType(ribbonItem, RibbonMenu)
						If Operators.CompareString(ribbonMenu.Text, "", True) > 0 Then
							ribbonMenu.Text = ribbonMenu.Text.Trim()
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

		' Token: 0x06004E2C RID: 20012 RVA: 0x00205B84 File Offset: 0x00203D84
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim str As String
			If Operators.CompareString(CType(A_0, RibbonButton).Tag.ToString(), "User", True) = 0 Then
				str = "本软件基于Foxtable设计，"
			Else
				str = "感谢您使用Foxtable，"
			End If
			If MessageBox.Show(str + "是否访问Foxtable主页？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.No Then
				ooO.O_o__O__OO.0o.()
			End If
		End Sub

		' Token: 0x06004E2D RID: 20013 RVA: 0x00205BDC File Offset: 0x00203DDC
		Private Sub <<EMPTY_NAME>>(A_0 As C1CommandLinks, A_1 As DataRow)
			A_0.Clear()
			For Each dataRow As DataRow In A_1.Table.[Select]("[ParentKey] = '" + A_1("Key").ToString() + "'", "Index")
				Dim ribbonItemTypeEnum As RibbonItemTypeEnum = CType(Conversions.ToInteger(dataRow("Type")), RibbonItemTypeEnum)
				Dim c1Command As C1Command
				If ribbonItemTypeEnum = RibbonItemTypeEnum.ContextCommand Then
					c1Command = Me.O_o._0oo0o0_0..CreateCommand()
				Else
					If ribbonItemTypeEnum <> RibbonItemTypeEnum.ContextCommandMenu Then
						Exit For
					End If
					c1Command = Me.O_o._0oo0o0_0..CreateCommand(GetType(C1CommandMenu))
				End If
				Dim contextCommand As ContextCommand = New ContextCommand(dataRow)
				Dim c1CommandLink As C1CommandLink = New C1CommandLink(c1Command)
				c1Command.Name = contextCommand.Name
				c1Command.Text = contextCommand.Text
				c1Command.Visible = contextCommand.Visible
				c1Command.Enabled = contextCommand.Enabled
				c1Command.Checked = contextCommand.Checked
				c1Command.CheckAutoToggle = contextCommand.CheckAutoToggle
				If contextCommand.Delimiter Then
					c1CommandLink.Delimiter = True
				End If
				c1Command.UserData = RuntimeHelpers.GetObjectValue(dataRow("Key"))
				If Operators.CompareString(contextCommand.Image, "", True) > 0 Then
					c1Command.Image = OO_00oOO.GetImage(contextCommand.Image)
				End If
				A_0.Add(c1CommandLink)
				If Me.O_o._0oo0o0_0. = Main.OO_O.o..O.OOO0_OOo.() Then
					c1Command.Click += AddressOf Me.o._o0ooOOO.
				End If
				If ribbonItemTypeEnum = RibbonItemTypeEnum.ContextCommandMenu Then
					Dim c1CommandMenu As C1CommandMenu = CType(c1Command, C1CommandMenu)
					Me.Oo.oO_ooo_o0.(c1CommandMenu.CommandLinks, dataRow)
					If Me.O_o._0oo0o0_0. = Main.OO_O.o..O.OOO0_OOo.() Then
						c1CommandMenu.Popup += AddressOf Me.OoO._o0oo0o0.
						c1CommandMenu.Closed += AddressOf Me.O.o0_O_O.
					End If
				End If
			Next
		End Sub

		' Token: 0x06004E2E RID: 20014 RVA: 0x00205DBC File Offset: 0x00203FBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ClickEventArgs)
			Dim c1Command As C1Command = CType(A_0, C1Command)
			Dim contextCommandEventArgs As ContextCommandEventArgs = New ContextCommandEventArgs(New ContextCommand(A_1.CallerLink))
			Dim a_ As String = "Click_" + Conversions.ToString(c1Command.UserData)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { contextCommandEventArgs }, False, "快捷菜单," + c1Command.Name, False)
		End Sub

		' Token: 0x06004E2F RID: 20015 RVA: 0x00205E20 File Offset: 0x00204020
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1ContextMenu As C1ContextMenu = CType(A_0, C1ContextMenu)
			Dim contextMenuEventArgs As ContextMenuEventArgs = New ContextMenuEventArgs(New Foxtable.RibbonMenu.ContextMenu(c1ContextMenu))
			Dim a_ As String = "Popup_" + Conversions.ToString(c1ContextMenu.UserData)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { contextMenuEventArgs }, False, "快捷菜单," + c1ContextMenu.Name, False)
		End Sub

		' Token: 0x06004E30 RID: 20016 RVA: 0x00205E80 File Offset: 0x00204080
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1ContextMenu As C1ContextMenu = CType(A_0, C1ContextMenu)
			Dim contextMenuEventArgs As ContextMenuEventArgs = New ContextMenuEventArgs(New Foxtable.RibbonMenu.ContextMenu(c1ContextMenu))
			Dim a_ As String = "Closed_" + Conversions.ToString(c1ContextMenu.UserData)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { contextMenuEventArgs }, False, "快捷菜单," + c1ContextMenu.Name, False)
		End Sub

		' Token: 0x06004E31 RID: 20017 RVA: 0x00205EE0 File Offset: 0x002040E0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1CommandMenu As C1CommandMenu = CType(A_0, C1CommandMenu)
			Dim contextCommandMenuEventArgs As ContextCommandMenuEventArgs = New ContextCommandMenuEventArgs(New ContextCommandMenu(c1CommandMenu))
			Dim a_ As String = "Popup_" + Conversions.ToString(c1CommandMenu.UserData)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { contextCommandMenuEventArgs }, False, "快捷菜单," + c1CommandMenu.Name, False)
		End Sub

		' Token: 0x06004E32 RID: 20018 RVA: 0x00205F40 File Offset: 0x00204140
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1CommandMenu As C1CommandMenu = CType(A_0, C1CommandMenu)
			Dim contextCommandMenuEventArgs As ContextCommandMenuEventArgs = New ContextCommandMenuEventArgs(New ContextCommandMenu(c1CommandMenu))
			Dim a_ As String = "Closed_" + Conversions.ToString(c1CommandMenu.UserData)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, New Object() { contextCommandMenuEventArgs }, False, "快捷菜单," + c1CommandMenu.Name, False)
		End Sub

		' Token: 0x06004E33 RID: 20019 RVA: 0x00205FA0 File Offset: 0x002041A0
		Private Function <<EMPTY_NAME>>() As RibbonButton
			Dim ribbonButton As RibbonButton = New RibbonButton()
			ribbonButton.Text = "Foxtable"
			ribbonButton.Name = "Foxtable"
			ribbonButton.ToolTip = "Foxtable官方论坛"
			ribbonButton.SmallImage = OO_00oOO.GetImage("Home16.Ico")
			ribbonButton.Click += AddressOf Me.O.OO_0.
			Return ribbonButton
		End Function

		' Token: 0x06004E34 RID: 20020 RVA: 0x00205FF5 File Offset: 0x002041F5
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			ooO.O_o__O__OO.0o.()
		End Sub

		' Token: 0x06004E35 RID: 20021 RVA: 0x00205FFC File Offset: 0x002041FC
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonItemCollectionBase, A_1 As DataRow, Optional A_2 As RibbonPaneEnum = RibbonPaneEnum.Left)
			A_0.Clear()
			For Each dataRow As DataRow In A_1.Table.[Select]("[ParentKey] = '" + A_1("Key").ToString() + "' And Pane = " + Conversions.ToString(CInt(A_2)), "Index")
				Dim ribbonItemTypeEnum As RibbonItemTypeEnum = CType(Conversions.ToInteger(dataRow("Type")), RibbonItemTypeEnum)
				Dim ribbonItem As RibbonItem = Nothing
				Select Case ribbonItemTypeEnum
					Case RibbonItemTypeEnum.PaperList, RibbonItemTypeEnum.WindowList, RibbonItemTypeEnum.TableViewList, RibbonItemTypeEnum.GroupTableList, RibbonItemTypeEnum.CrossTableList, RibbonItemTypeEnum.SubtotalModeList, RibbonItemTypeEnum.ExcelReportList, RibbonItemTypeEnum.CodeReportList, RibbonItemTypeEnum.WordReportList
						Dim ribbonMenu As RibbonMenu = New RibbonMenu()
						Dim ribbonMenuButton As RibbonMenuButton = New RibbonMenuButton(dataRow)
						Me.o0O0.Oo0_OOO0.(ribbonMenuButton, ribbonMenu)
						If ribbonMenu.LargeImage IsNot Nothing AndAlso Operators.CompareString(ribbonMenuButton.Text, "", True) > 0 AndAlso ribbonMenuButton.Text.IndexOf(" "c) < 0 Then
							ribbonMenu.Text = ribbonMenuButton.Text + " "
						Else
							ribbonMenu.Text = ribbonMenuButton.Text
						End If
						ribbonItem = ribbonMenu
						Me.o0O0.Oo0_OOO0.(ribbonMenu.Items, dataRow, RibbonPaneEnum.Left)
						ribbonMenu.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
						If ribbonItemTypeEnum = RibbonItemTypeEnum.WindowList Then
							ribbonMenu.MouseEnter += AddressOf Me.oo000_oo0o0._.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.PaperList Then
							Dim printerSettings As PrinterSettings = New PrinterSettings()
							Try
								For Each obj As Object In printerSettings.PaperSizes
									Dim paperSize As PaperSize = CType(obj, PaperSize)
									Dim ribbonToggleButton As RibbonToggleButton = New RibbonToggleButton()
									ribbonToggleButton.Text = paperSize.PaperName
									ribbonToggleButton.Tag = paperSize.RawKind
									ribbonToggleButton.Click += AddressOf Me.O_0O0._0_O0.
									ribbonMenu.Items.Add(ribbonToggleButton)
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							Dim ribbonToggleButton2 As RibbonToggleButton = New RibbonToggleButton()
							ribbonToggleButton2.Text = "自定义"
							ribbonToggleButton2.Tag = 0
							ribbonToggleButton2.Click += AddressOf Me.o_O_.o__0Ooo_.
							ribbonMenu.Items.Add(ribbonToggleButton2)
							ribbonMenu.DropDown += AddressOf Me.o0_Oo.00o00_.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.TableViewList Then
							ribbonMenu.MouseEnter += AddressOf Me.OO_.0__o.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.GroupTableList Then
							ribbonMenu.MouseEnter += AddressOf Me.O.oO_0o0.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.CrossTableList Then
							ribbonMenu.MouseEnter += AddressOf Me.o0.0_0OO_Oo__.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.SubtotalModeList Then
							ribbonMenu.MouseEnter += AddressOf Me.o__O.OoO.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.ExcelReportList Then
							ribbonMenu.MouseEnter += AddressOf Me.OO.oOo0_0O.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.WordReportList Then
							ribbonMenu.MouseEnter += AddressOf Me.OOOOoO.0_0_.
						ElseIf ribbonItemTypeEnum = RibbonItemTypeEnum.CodeReportList Then
							ribbonMenu.MouseEnter += AddressOf Me.ooO00O0_0.OO_.
						End If
					Case RibbonItemTypeEnum.ToggleGroup
						Dim ribbonToggleGroup As RibbonToggleGroup = New RibbonToggleGroup()
						Dim a_ As RibbonToggleGroup = New RibbonToggleGroup(dataRow)
						Me.o0O0.Oo0_OOO0.(a_, ribbonToggleGroup)
						ribbonItem = ribbonToggleGroup
						Me.o0O0.Oo0_OOO0.(ribbonToggleGroup.Items, dataRow, RibbonPaneEnum.Left)
						ribbonToggleGroup.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.ToolBar
						Dim ribbonToolBar As RibbonToolBar = New RibbonToolBar()
						Dim a_2 As RibbonToolBar = New RibbonToolBar(dataRow)
						Me.o0O0.Oo0_OOO0.(a_2, ribbonToolBar)
						ribbonItem = ribbonToolBar
						Me.o0O0.Oo0_OOO0.(ribbonToolBar.Items, dataRow, RibbonPaneEnum.Left)
						ribbonToolBar.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.Button
						Dim ribbonButton As RibbonButton = New RibbonButton()
						Dim a_3 As RibbonButton = New RibbonButton(dataRow)
						Me.Oo.oO_ooo_o0.(a_3, ribbonButton)
						ribbonItem = ribbonButton
						ribbonButton.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.CheckBox
						Dim ribbonCheckBox As RibbonCheckBox = New RibbonCheckBox()
						Dim a_4 As RibbonCheckBox = New RibbonCheckBox(dataRow)
						Me.o0O0.Oo0_OOO0.(a_4, ribbonCheckBox)
						ribbonItem = ribbonCheckBox
						ribbonCheckBox.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.ColorPicker
						Dim ribbonColorPicker As RibbonColorPicker = New RibbonColorPicker()
						Dim a_5 As RibbonColorPicker = New RibbonColorPicker(dataRow)
						Me.o0O0.Oo0_OOO0.(a_5, ribbonColorPicker)
						ribbonItem = ribbonColorPicker
						A_0.Add(ribbonColorPicker)
						ribbonColorPicker.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.ComboBox
						Dim ribbonComboBox As RibbonComboBox = New RibbonComboBox()
						Dim a_6 As RibbonComboBox = New RibbonComboBox(dataRow)
						Me.o0O0.Oo0_OOO0.(a_6, ribbonComboBox)
						ribbonItem = ribbonComboBox
						Me.o0O0.Oo0_OOO0.(ribbonComboBox.Items, dataRow, RibbonPaneEnum.Left)
						Me.o0O0.Oo0_OOO0.(ribbonComboBox.MenuItems, dataRow, RibbonPaneEnum.Right)
						ribbonComboBox.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.TextBox
						Dim ribbonTextBox As RibbonTextBox = New RibbonTextBox()
						Dim a_7 As RibbonTextBox = New RibbonTextBox(dataRow)
						Me.OO__o0O0.0.(a_7, ribbonTextBox)
						ribbonItem = ribbonTextBox
						ribbonTextBox.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.FontComboBox
						Dim ribbonFontComboBox As RibbonFontComboBox = New RibbonFontComboBox()
						Dim a_8 As RibbonFontComboBox = New RibbonFontComboBox(dataRow)
						Me.o0O0.Oo0_OOO0.(a_8, ribbonFontComboBox)
						ribbonItem = ribbonFontComboBox
						Me.o0O0.Oo0_OOO0.(ribbonFontComboBox.MenuItems, dataRow, RibbonPaneEnum.Right)
						ribbonFontComboBox.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.Label
						Dim ribbonLabel As RibbonLabel = New RibbonLabel()
						Dim a_9 As RibbonLabel = New RibbonLabel(dataRow)
						Me.OO__o0O0.0.(a_9, ribbonLabel)
						ribbonItem = ribbonLabel
						ribbonLabel.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.MenuButton
						Dim ribbonMenu2 As RibbonMenu = New RibbonMenu()
						Dim a_10 As RibbonMenuButton = New RibbonMenuButton(dataRow)
						Me.OO__o0O0.0.(a_10, ribbonMenu2)
						ribbonItem = ribbonMenu2
						Me.o0O0.Oo0_OOO0.(ribbonMenu2.Items, dataRow, RibbonPaneEnum.Left)
						ribbonMenu2.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.Separator
						Dim ribbonSeparator As RibbonSeparator = New RibbonSeparator()
						Dim a_11 As RibbonSeparator = New RibbonSeparator(dataRow)
						Me.o0O0.Oo0_OOO0.(a_11, ribbonSeparator)
						ribbonItem = ribbonSeparator
						ribbonSeparator.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.SplitButton
						Dim ribbonSplitButton As RibbonSplitButton = New RibbonSplitButton()
						Dim a_12 As RibbonSplitButton = New RibbonSplitButton(dataRow)
						Me.OO__o0O0.0.(a_12, ribbonSplitButton)
						ribbonItem = ribbonSplitButton
						Me.o0O0.Oo0_OOO0.(ribbonSplitButton.Items, dataRow, RibbonPaneEnum.Left)
						ribbonSplitButton.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.ToggleButton
						Dim ribbonToggleButton3 As RibbonToggleButton = New RibbonToggleButton()
						Dim a_13 As RibbonToggleButton = New RibbonToggleButton(dataRow)
						Me.OO__o0O0.0.(a_13, ribbonToggleButton3)
						ribbonItem = ribbonToggleButton3
						ribbonToggleButton3.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.DatePicker
						Dim ribbonDatePicker As RibbonDatePicker = New RibbonDatePicker()
						Dim a_14 As RibbonDatePicker = New RibbonDatePicker(dataRow)
						Me.o0O0.Oo0_OOO0.(a_14, ribbonDatePicker)
						ribbonItem = ribbonDatePicker
						ribbonDatePicker.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.NumericBox
						Dim ribbonNumericBox As RibbonNumericBox = New RibbonNumericBox()
						Dim a_15 As RibbonNumericBox = New RibbonNumericBox(dataRow)
						Me.OO__o0O0.0.(a_15, ribbonNumericBox)
						ribbonItem = ribbonNumericBox
						ribbonNumericBox.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.ProgressBar
						Dim ribbonProgressBar As RibbonProgressBar = New RibbonProgressBar()
						Dim a_16 As RibbonProgressBar = New RibbonProgressBar(dataRow)
						Me.OO__o0O0.0.(a_16, ribbonProgressBar)
						ribbonItem = ribbonProgressBar
						ribbonProgressBar.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.Gallery
						Dim o_o_Oo0__o_ As o_o_Oo0__o_0 = New o_o_Oo0__o_0()
						Dim a_17 As RibbonGallery = New RibbonGallery(dataRow)
						Me.o0O0.Oo0_OOO0.(a_17, o_o_Oo0__o_)
						ribbonItem = o_o_Oo0__o_
						A_0.Add(o_o_Oo0__o_)
						Me.o0O0.Oo0_OOO0.(o_o_Oo0__o_.MenuItems, dataRow, RibbonPaneEnum.Left)
						Me.o0O0.Oo0_OOO0.(o_o_Oo0__o_.Items, dataRow, RibbonPaneEnum.Right)
						If Not o_o_Oo0__o_.oOoO0ooo_0O._.() Then
							Try
								For Each obj2 As Object In o_o_Oo0__o_.Items
									CType(obj2, RibbonGalleryItem).VerticalLayout = False
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						End If
						o_o_Oo0__o_.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.GalleryItem
						Dim ribbonGalleryItem As RibbonGalleryItem = New RibbonGalleryItem()
						Dim a_18 As RibbonGalleryItem = New RibbonGalleryItem(dataRow)
						Me.o0O0.Oo0_OOO0.(a_18, ribbonGalleryItem)
						ribbonItem = ribbonGalleryItem
						A_0.Add(ribbonGalleryItem)
						ribbonGalleryItem.Tag = RuntimeHelpers.GetObjectValue(dataRow("key"))
					Case RibbonItemTypeEnum.TimePicker
						Dim ribbonTimePicker As RibbonTimePicker = New RibbonTimePicker()
						Dim a_19 As RibbonTimePicker = New RibbonTimePicker(dataRow)
						Me.OO__o0O0.0.(a_19, ribbonTimePicker)
						ribbonItem = ribbonTimePicker
						ribbonTimePicker.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
					Case RibbonItemTypeEnum.TrackBar
						Dim ribbonTrackBar As RibbonTrackBar = New RibbonTrackBar()
						Dim a_20 As RibbonTrackBar = New RibbonTrackBar(dataRow)
						Me.OO__o0O0.0.(a_20, ribbonTrackBar)
						ribbonItem = ribbonTrackBar
						ribbonTrackBar.Tag = RuntimeHelpers.GetObjectValue(dataRow("Key"))
				End Select
				If ribbonItem IsNot Nothing Then
					If TypeOf A_0 Is RibbonGalleryItemCollection Then
						A_0.Add(ribbonItem)
					ElseIf A_2 = RibbonPaneEnum.Right Then
						Dim ribbonListItem As RibbonListItem = New RibbonListItem()
						ribbonListItem.Items.Add(ribbonItem)
						A_0.Add(ribbonListItem)
					Else
						A_0.Add(ribbonItem)
					End If
				End If
			Next
		End Sub

		' Token: 0x06004E36 RID: 20022 RVA: 0x00206920 File Offset: 0x00204B20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						Return
					End If
				Catch ex As Exception
					Return
				End Try
				Dim rawKind As Integer = OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind
				Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
				Try
					For Each obj As Object In ribbonMenu.Items
						Dim ribbonToggleButton As RibbonToggleButton = CType(obj, RibbonToggleButton)
						If Conversions.ToInteger(ribbonToggleButton.Tag) = rawKind Then
							ribbonToggleButton.Pressed = True
						Else
							ribbonToggleButton.Pressed = False
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

		' Token: 0x06004E37 RID: 20023 RVA: 0x002069F0 File Offset: 0x00204BF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Dim ribbonToggleButton As RibbonToggleButton = CType(A_0, RibbonToggleButton)
				Dim printerSettings As PrinterSettings = New PrinterSettings()
				Try
					For Each obj As Object In printerSettings.PaperSizes
						Dim paperSize As PaperSize = CType(obj, PaperSize)
						If Operators.CompareString(paperSize.PaperName, ribbonToggleButton.Text, True) = 0 Then
							OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind = paperSize.RawKind
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

		' Token: 0x06004E38 RID: 20024 RVA: 0x00206A8C File Offset: 0x00204C8C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.CurrentTable IsNot Nothing Then
				Try
					If PrinterSettings.InstalledPrinters.Count = 0 Then
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Return
					End If
				Catch ex As Exception
					Return
				End Try
				OO_00oOO.CurrentTable.PrintInfo.PaperSize.RawKind = 0
			End If
		End Sub

		' Token: 0x06004E39 RID: 20025 RVA: 0x00206AF8 File Offset: 0x00204CF8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(0))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.o_O_oO_o.0O__.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E3A RID: 20026 RVA: 0x00206BB4 File Offset: 0x00204DB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = CType(A_0, RibbonButton).Text
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { OO_00oOO.CurrentTable.DataTable.Name, text, 0 })
			If dataRow IsNot Nothing Then
				Try
					OO_00oOO.LockBaseMainForm()
					OO_00oOO.CurrentTable.StopRedraw()
					Dim tableViewProperty As TableViewProperty = New TableViewProperty(OO_00oOO.CurrentTable)
					o_O_o_oOoo__.OOOO_OO._oo.(tableViewProperty, Conversions.ToString(dataRow("Property")), vbVerticalTab)
					tableViewProperty.Restore()
				Catch ex As Exception
				Finally
					OO_00oOO.CurrentTable.ResumeRedraw()
					OO_00oOO.UnlockBaseMainForm()
				End Try
			End If
		End Sub

		' Token: 0x06004E3B RID: 20027 RVA: 0x00206C88 File Offset: 0x00204E88
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(1))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.o00___.0_.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E3C RID: 20028 RVA: 0x00206D44 File Offset: 0x00204F44
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = CType(A_0, RibbonButton).Text
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { OO_00oOO.CurrentTable.DataTable.Name, text, 1 })
			If dataRow IsNot Nothing Then
				Dim groupTableBuilder As GroupTableBuilder = New GroupTableBuilder()
				Dim groupTableProperty As GroupTableProperty = New GroupTableProperty(groupTableBuilder)
				o_O_o_oOoo__.OOOO_OO._oo.(groupTableProperty, Conversions.ToString(dataRow("Property")), vbVerticalTab)
				groupTableProperty.Restore()
				groupTableBuilder.SourceDataTable = OO_00oOO.CurrentTable.DataTable
				OO_00oOO.CurrentTable.O_0._O_0OO000O. = groupTableBuilder
				Foxtable.Syscmd.Table.RebuildGroupTable()
			End If
		End Sub

		' Token: 0x06004E3D RID: 20029 RVA: 0x00206DF0 File Offset: 0x00204FF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(2))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.oo._oO0_o.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E3E RID: 20030 RVA: 0x00206EAC File Offset: 0x002050AC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = CType(A_0, RibbonButton).Text
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { OO_00oOO.CurrentTable.DataTable.Name, text, 2 })
			If dataRow IsNot Nothing Then
				Dim crossTableBuilder As CrossTableBuilder = New CrossTableBuilder()
				Dim crossTableProperty As CrossTableProperty = New CrossTableProperty(crossTableBuilder)
				o_O_o_oOoo__.OOOO_OO._oo.(crossTableProperty, Conversions.ToString(dataRow("Property")), vbVerticalTab)
				crossTableProperty.o___0o.0OOOooO.()
				crossTableBuilder.SourceDataTable = OO_00oOO.CurrentTable.DataTable
				OO_00oOO.CurrentTable.O_0._O_0OO000O. = crossTableBuilder
				Foxtable.Syscmd.Table.RebuildCrossTable()
			End If
		End Sub

		' Token: 0x06004E3F RID: 20031 RVA: 0x00206F58 File Offset: 0x00205158
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(3))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.oo0o00O__.0o0.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E40 RID: 20032 RVA: 0x00207014 File Offset: 0x00205214
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim text As String = CType(A_0, RibbonButton).Text
			Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.()).Rows.Find(New Object() { OO_00oOO.CurrentTable.DataTable.Name, text, 3 })
			If dataRow IsNot Nothing Then
				OO_00oOO.CurrentTable.ClearEditInfos()
				Dim subtotalModeProperty As SubtotalModeProperty = New SubtotalModeProperty(OO_00oOO.CurrentTable.SubtotalGroups, False, True, True)
				o_O_o_oOoo__.OOOO_OO._oo.(subtotalModeProperty, Conversions.ToString(dataRow("Property")), vbVerticalTab)
				subtotalModeProperty.Restore()
				If OO_00oOO.CurrentTable.IsSubtotal Then
					OO_00oOO.CurrentTable.ClearSubtotal()
				End If
				OO_00oOO.CurrentTable.GroupAboveData = subtotalModeProperty.GroupAboveData
				OO_00oOO.CurrentTable.TreeVisible = subtotalModeProperty.TreeVisible
				OO_00oOO.CurrentTable.SpillNode = subtotalModeProperty.SpillNode
				OO_00oOO.CurrentTable.Subtotal(False)
			End If
		End Sub

		' Token: 0x06004E41 RID: 20033 RVA: 0x00207104 File Offset: 0x00205304
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(5))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.o_o__OOo.O.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E42 RID: 20034 RVA: 0x002071C0 File Offset: 0x002053C0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(9))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.oo0_O0_.o0Oo.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E43 RID: 20035 RVA: 0x0020727C File Offset: 0x0020547C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
			Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.Oo0o0.oo_0.())
			ribbonMenu.Items.Clear()
			If OO_00oOO.CurrentTable IsNot Nothing Then
				For Each dataRow As DataRow In dataTable.[Select]("[Table] = '" + OO_00oOO.CurrentTable.DataTable.Name + "' And [Type] = " + Conversions.ToString(6))
					Dim ribbonButton As RibbonButton = New RibbonButton()
					ribbonButton.Text = dataRow("Name").ToString()
					ribbonButton.Click += AddressOf Me.o00.__0O_o_O.
					ribbonMenu.Items.Add(ribbonButton)
				Next
			End If
		End Sub

		' Token: 0x06004E44 RID: 20036 RVA: 0x00207338 File Offset: 0x00205538
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.CurrentTable.Current IsNot Nothing Then
				Dim ribbonButton As RibbonButton = CType(A_0, RibbonButton)
				XLSFunctions.Reports(ribbonButton.Text).Build()
			End If
		End Sub

		' Token: 0x06004E45 RID: 20037 RVA: 0x00207370 File Offset: 0x00205570
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.CurrentTable.Current IsNot Nothing Then
				Dim ribbonButton As RibbonButton = CType(A_0, RibbonButton)
				WordFunctions.Reports(ribbonButton.Text).Build()
			End If
		End Sub

		' Token: 0x06004E46 RID: 20038 RVA: 0x002073A8 File Offset: 0x002055A8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim ribbonButton As RibbonButton = CType(A_0, RibbonButton)
			OO_00oOO.Reports(ribbonButton.Text).Execute()
		End Sub

		' Token: 0x06004E47 RID: 20039 RVA: 0x002073D4 File Offset: 0x002055D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.MainTable IsNot Nothing Then
				Dim ribbonButton As RibbonButton = CType(A_0, RibbonButton)
				Dim left As String = ribbonButton.Tag.ToString()
				If Operators.CompareString(left, "Column", True) = 0 Then
					If OO_00oOO.CurrentTable.Cols.Contains(ribbonButton.Text) Then
						OO_00oOO.CurrentTable.Cols(ribbonButton.Text).OpenWindow(0)
						Dim o_o_O.0000_O. As System.Windows.Forms.Control = OO_00oOO.CurrentTable.Cols(ribbonButton.Text).o_o_O.0000_O.
						If o_o_O.0000_O. IsNot Nothing Then
							ooO.OO_oOO0O.O00.(o_o_O.0000_O.)
						End If
					End If
				ElseIf Operators.CompareString(left, "Relation", True) = 0 Then
					If OO_00oOO.Tables.get_Contains(ribbonButton.Text) Then
						Dim table As Foxtable.Table = OO_00oOO.Tables(ribbonButton.Text)
						If table.foxGrid.FindForm() Is Nothing Then
							Dim o_O0_0O As o_O0_0O0
							Select Case table._frdDockArea
								Case 0
									o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(OO_00oOO.MainTable.Name), Oo0__Oo).o__0_.o0OoOOO.()
									GoTo IL_1A8
								Case 2
									o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(OO_00oOO.MainTable.Name), Oo0__Oo).O__O.o_oOO.()
									GoTo IL_1A8
								Case 3
									o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(OO_00oOO.MainTable.Name), Oo0__Oo).O_000__.o.()
									GoTo IL_1A8
							End Select
							o_O0_0O = CType(Main.OO_O.o..OO_O_0Oo.___o.().TabPages(OO_00oOO.MainTable.Name), Oo0__Oo).O._o_00__.()
							IL_1A8:
							o_O0_0O.OO_o0_oO.0.(table, table._frdDockTitle)
							ooO.OO_oOO0O.O00.(table.foxGrid)
						End If
					End If
				ElseIf Operators.CompareString(left, "Form", True) = 0 Then
					OO_00oOO.Forms(ribbonButton.Text).Show(Integer.MaxValue, Integer.MaxValue)
				End If
			End If
		End Sub

		' Token: 0x06004E48 RID: 20040 RVA: 0x002075D4 File Offset: 0x002057D4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.SystemReady Then
				Dim ribbonMenu As RibbonMenu = CType(A_0, RibbonMenu)
				Dim ribbonMenu2 As RibbonMenu = New RibbonMenu()
				Dim ribbonMenu3 As RibbonMenu = New RibbonMenu()
				Dim ribbonMenu4 As RibbonMenu = New RibbonMenu()
				Dim maxDropDownItems As Integer = CInt(Math.Floor(CDbl(SysInfo.ScreenHeight) / 768.0 * 22.0))
				ribbonMenu2.MaxDropDownItems = maxDropDownItems
				ribbonMenu3.MaxDropDownItems = maxDropDownItems
				ribbonMenu4.MaxDropDownItems = maxDropDownItems
				If Not ribbonMenu.DroppedDown Then
					ribbonMenu.Items.Clear()
					If OO_00oOO.MainTable IsNot Nothing Then
						ribbonMenu4.Text = "工作窗口"
						ribbonMenu2.Text = "关联表"
						ribbonMenu3.Text = "列窗口"
						Try
							For Each table As Foxtable.Table In OO_00oOO.Tables
								If table.Name.StartsWith(OO_00oOO.MainTable.Name + ".") AndAlso Operators.CompareString(table.Name, OO_00oOO.MainTable.Name, True) <> 0 Then
									Dim ribbonToggleButton As RibbonToggleButton = New RibbonToggleButton()
									ribbonToggleButton.Text = table.Name
									ribbonToggleButton.Tag = "Relation"
									If table.foxGrid.FindForm() IsNot Nothing Then
										ribbonToggleButton.Pressed = True
									End If
									ribbonToggleButton.Click += AddressOf Me.o_O.0_oO0o0o.
									ribbonMenu2.Items.Add(ribbonToggleButton)
								End If
							Next
						Finally
							Dim enumerator As IEnumerator(Of Foxtable.Table)
							If enumerator IsNot Nothing Then
								enumerator.Dispose()
							End If
						End Try
						Try
							For Each col As Col In OO_00oOO.CurrentTable.Cols
								If col.oo_0_oO._.() Then
									Dim ribbonToggleButton2 As RibbonToggleButton = New RibbonToggleButton()
									ribbonToggleButton2.Text = col.Name
									ribbonToggleButton2.Tag = "Column"
									If col.o_o_O.0000_O. IsNot Nothing AndAlso col.o_o_O.0000_O..FindForm() IsNot Nothing Then
										ribbonToggleButton2.Pressed = True
									End If
									ribbonToggleButton2.Click += AddressOf Me.o_O.0_oO0o0o.
									ribbonMenu3.Items.Add(ribbonToggleButton2)
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator(Of Col)
							If enumerator2 IsNot Nothing Then
								enumerator2.Dispose()
							End If
						End Try
						Try
							For Each form As Foxtable.WinForm.Form In OO_00oOO.Forms
								If Conversions.ToInteger(form.O_o_.0o0__o0O.("Type")) <> 233 AndAlso (Operators.CompareString(form.TableName, OO_00oOO.MainTable.Name, True) = 0 OrElse Operators.CompareString(form.TableName, "", True) = 0) Then
									Dim ribbonToggleButton3 As RibbonToggleButton = New RibbonToggleButton()
									ribbonToggleButton3.Text = form.Name
									ribbonToggleButton3.Tag = "Form"
									If form.Opened Then
										ribbonToggleButton3.Pressed = True
									End If
									ribbonToggleButton3.Click += AddressOf Me.o_O.0_oO0o0o.
									ribbonMenu4.Items.Add(ribbonToggleButton3)
								End If
							Next
						Finally
							Dim enumerator3 As IEnumerator(Of Foxtable.WinForm.Form)
							If enumerator3 IsNot Nothing Then
								enumerator3.Dispose()
							End If
						End Try
						ribbonMenu.Items.Add(ribbonMenu2)
						ribbonMenu.Items.Add(ribbonMenu3)
						ribbonMenu.Items.Add(ribbonMenu4)
						ribbonMenu.Items.Add(New RibbonSeparator())
						Dim ribbonButton As RibbonButton = New RibbonButton()
						ribbonButton.SmallImage = ribbonMenu.Ribbon.ApplicationMenu.LargeImage
						ribbonButton.Text = "显示主表"
						ribbonButton.Click += AddressOf Me.OO.0OO0oo0O_O.
						ribbonMenu.Items.Add(ribbonButton)
					End If
				End If
			End If
		End Sub

		' Token: 0x06004E49 RID: 20041 RVA: 0x00207964 File Offset: 0x00205B64
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			OO_00oOO.MainTable.Show()
		End Sub

		' Token: 0x06004E4A RID: 20042 RVA: 0x00207970 File Offset: 0x00205B70
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonItem, A_1 As RibbonItem)
			A_1.ID = A_0.Name
			A_1.Enabled = A_0.Enabled
			A_1.Visible = A_0.Visible
			A_1.ToolTip = A_0.ToolTip
			If A_0.ForeColor <> Color.Transparent Then
				A_1.ForeColorInner = A_0.ForeColor
				A_1.ForeColorOuter = A_0.ForeColor
			End If
			If Not A_0.AutoHideText Then
				A_1.SupportedGroupSizing = 1
			End If
			If Operators.CompareString(A_0.LargeImage, "", True) > 0 Then
				A_1.LargeImage = OO_00oOO.GetImage(A_0.LargeImage)
			End If
			If Operators.CompareString(A_0.SmallImage, "", True) > 0 Then
				A_1.SmallImage = OO_00oOO.GetImage(A_0.SmallImage)
			End If
			If A_0.TextImageRelation = TextImageRelationEnum.Automatic Then
				A_1.TextImageRelation = 0
				Return
			End If
			If A_0.TextImageRelation = TextImageRelationEnum.ImageAboveText Then
				A_1.TextImageRelation = 1
				Return
			End If
			A_1.TextImageRelation = 2
		End Sub

		' Token: 0x06004E4B RID: 20043 RVA: 0x00207A58 File Offset: 0x00205C58
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonButton, A_1 As RibbonButton)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			If A_1.LargeImage IsNot Nothing AndAlso Operators.CompareString(A_0.Text, "", True) > 0 AndAlso A_0.Text.IndexOf(" "c) < 0 Then
				A_1.Text = A_0.Text + " "
			Else
				A_1.Text = A_0.Text
			End If
			If Operators.CompareString(A_1.ToolTip, "", True) = 0 Then
				A_1.ToolTip = A_1.Text
			End If
			If A_0.ShortcutKeys <> Keys.None Then
				A_1.ShortcutKeys = A_0.ShortcutKeys
			End If
		End Sub

		' Token: 0x06004E4C RID: 20044 RVA: 0x00207AF0 File Offset: 0x00205CF0
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonSplitButton, A_1 As RibbonSplitButton)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			If A_1.LargeImage IsNot Nothing AndAlso Operators.CompareString(A_0.Text, "", True) > 0 AndAlso A_0.Text.IndexOf(" "c) < 0 Then
				A_1.Text = A_0.Text + " "
			Else
				A_1.Text = A_0.Text
			End If
			If Operators.CompareString(A_1.ToolTip, "", True) = 0 Then
				A_1.ToolTip = A_1.Text
			End If
		End Sub

		' Token: 0x06004E4D RID: 20045 RVA: 0x00207B74 File Offset: 0x00205D74
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonMenuButton, A_1 As RibbonMenu)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			If A_1.LargeImage IsNot Nothing AndAlso Operators.CompareString(A_0.Text, "", True) > 0 AndAlso A_0.Text.IndexOf(" "c) < 0 Then
				A_1.Text = A_0.Text + " "
			Else
				A_1.Text = A_0.Text
			End If
			A_1.ArrowVisible = A_0.ArrowVisible
			If Operators.CompareString(A_1.ToolTip, "", True) = 0 Then
				A_1.ToolTip = A_1.Text
			End If
		End Sub

		' Token: 0x06004E4E RID: 20046 RVA: 0x00207C04 File Offset: 0x00205E04
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonGallery, A_1 As o_o_Oo0__o_0)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Text = A_0.Text
			A_1.Expanded = A_0.Expand
			A_1.VisibleItems = A_0.VisibleItems
			A_1.oOoO0ooo_0O._.(A_0.CommandMode)
			A_1.o.o_.(A_0.VerticalLayout)
			A_1.ItemSize = New Size(A_0.ItemWidth, A_0.ItemHeight)
		End Sub

		' Token: 0x06004E4F RID: 20047 RVA: 0x00207C6C File Offset: 0x00205E6C
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonGalleryItem, A_1 As RibbonGalleryItem)
			A_1.ID = A_0.Name
			A_1.Enabled = A_0.Enabled
			A_1.Visible = A_0.Visible
			A_1.ToolTip = A_0.ToolTip
			A_1.Text = A_0.Text
			If Operators.CompareString(A_0.Image, "", True) > 0 Then
				A_1.LargeImage = OO_00oOO.GetImage(A_0.Image)
			End If
		End Sub

		' Token: 0x06004E50 RID: 20048 RVA: 0x00207CDA File Offset: 0x00205EDA
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonLabel, A_1 As RibbonLabel)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Text = A_0.Text
		End Sub

		' Token: 0x06004E51 RID: 20049 RVA: 0x00207CF0 File Offset: 0x00205EF0
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonCheckBox, A_1 As RibbonCheckBox)
			Me.Oo.oO_ooo_o0.(A_0, A_1)
			A_1.Checked = A_0.Checked
		End Sub

		' Token: 0x06004E52 RID: 20050 RVA: 0x00207D06 File Offset: 0x00205F06
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonToggleButton, A_1 As RibbonToggleButton)
			Me.Oo.oO_ooo_o0.(A_0, A_1)
			A_1.Pressed = A_0.Pressed
			A_1.ToggleGroupName = A_0.GroupName
			A_1.CanDepress = (Operators.CompareString(A_1.ToggleGroupName, "", True) = 0)
		End Sub

		' Token: 0x06004E53 RID: 20051 RVA: 0x00207D42 File Offset: 0x00205F42
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonTextBox, A_1 As RibbonTextBox)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Label = A_0.Label
			A_1.MaxLength = A_0.MaxLength
			A_1.Text = A_0.Text
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1)
		End Sub

		' Token: 0x06004E54 RID: 20052 RVA: 0x00207D82 File Offset: 0x00205F82
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonDatePicker, A_1 As RibbonDatePicker)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.StandardFormat = 4
			A_1.Format = "yyyy-MM-dd"
			A_1.Label = A_0.Label
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1)
		End Sub

		' Token: 0x06004E55 RID: 20053 RVA: 0x00207DBC File Offset: 0x00205FBC
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonTimePicker, A_1 As RibbonTimePicker)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			If A_0.LongTimeFormat Then
				A_1.StandardFormat = 1
			Else
				A_1.StandardFormat = 0
			End If
			A_1.Label = A_0.Label
			A_1.TextAreaWidth = A_0.TextAreaWidth
			A_1.Value = A_0.Value
		End Sub

		' Token: 0x06004E56 RID: 20054 RVA: 0x00207E10 File Offset: 0x00206010
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonTrackBar, A_1 As RibbonTrackBar)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Minimum = A_0.Minimum
			A_1.Maximum = A_0.Maximum
			A_1.Value = A_0.Value
			A_1.TickFrequency = A_0.TickFrequency
			A_1.StepFrequency = A_0.StepFrequency
			A_1.Width = A_0.Width
		End Sub

		' Token: 0x06004E57 RID: 20055 RVA: 0x00207E70 File Offset: 0x00206070
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonNumericBox, A_1 As RibbonNumericBox)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Label = A_0.Label
			A_1.Increment = A_0.Increment
			A_1.Maximum = A_0.Maximum
			A_1.Minimum = A_0.Minimum
			If Operators.CompareString(A_0.Value, "", True) > 0 Then
				Dim num As Decimal
				Decimal.TryParse(A_0.Value, num)
				num = Math.Max(num, A_0.Minimum)
				num = Math.Min(num, A_0.Maximum)
				A_1.Value = num
			End If
			A_1.TextAreaWidth = Math.Max(A_0.TextAreaWidth, 1)
		End Sub

		' Token: 0x06004E58 RID: 20056 RVA: 0x00207F0C File Offset: 0x0020610C
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonProgressBar, A_1 As RibbonProgressBar)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Value = A_0.Value
			A_1.Maximum = A_0.Maximum
			A_1.Minimum = A_0.Minimum
			A_1.Width = A_0.Width
			A_1.Height = A_0.Height
			A_1.Width = Math.Max(A_0.Width, 1)
		End Sub

		' Token: 0x06004E59 RID: 20057 RVA: 0x00207F70 File Offset: 0x00206170
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonComboBox, A_1 As RibbonComboBox)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Label = A_0.Label
			A_1.MaxDropDownItems = A_0.MaxDropDownItems
			A_1.MaxLength = A_0.MaxLength
			A_1.Text = A_0.Text
			A_1.TextAreaWidth = A_0.TextAreaWidth
		End Sub

		' Token: 0x06004E5A RID: 20058 RVA: 0x00207FC1 File Offset: 0x002061C1
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonFontComboBox, A_1 As RibbonComboBox)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.Label = A_0.Label
			A_1.MaxDropDownItems = A_0.MaxDropDownItems
			A_1.Text = A_0.Text
			A_1.TextAreaWidth = A_0.TextAreaWidth
		End Sub

		' Token: 0x06004E5B RID: 20059 RVA: 0x00207FFB File Offset: 0x002061FB
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonColorPicker, A_1 As RibbonColorPicker)
			A_1.Text = A_0.Text
			A_1.Color = A_0.Color
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
		End Sub

		' Token: 0x06004E5C RID: 20060 RVA: 0x0020801D File Offset: 0x0020621D
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonItemContainer, A_1 As RibbonItemContainer)
			A_1.ID = A_0.Name
			A_1.Enabled = A_0.Enabled
			A_1.Visible = A_0.Visible
			A_1.ToolTip = A_0.ToolTip
		End Sub

		' Token: 0x06004E5D RID: 20061 RVA: 0x0020804F File Offset: 0x0020624F
		Private Sub <<EMPTY_NAME>>(A_0 As RibbonToggleGroup, A_1 As RibbonToggleGroup)
			Me.o0O0.Oo0_OOO0.(A_0, A_1)
			A_1.AllowAllButtonsUp = A_0.AllowAllButtonsUp
		End Sub

		' Token: 0x0400206C RID: 8300
		Private <<EMPTY_NAME>> As C1CommandHolder

		' Token: 0x0400206D RID: 8301
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400206E RID: 8302
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
