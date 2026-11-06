Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Web
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1Input
Imports C1.Win.C1Themes
Imports Foxtable.My
Imports Foxtable.RibbonMenu
Imports JRO
Imports Microsoft.International.Converters.PinYinConverter
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports MSScriptControl

Namespace Foxtable
	' Token: 0x020004CE RID: 1230
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module OO_00oOO
		' Token: 0x06004F0E RID: 20238
		Private Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef A_0 As Integer, A_1 As Integer) As Boolean

		' Token: 0x06004F0F RID: 20239
		Private Declare Function EnumWindows Lib "user32" (A_0 As OO_00oOO.o_O_0ooO, A_1 As Integer) As Integer

		' Token: 0x06004F10 RID: 20240
		Friend Declare Function SendMessage Lib "user32.dll" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer, A_3 As Integer) As IntPtr

		' Token: 0x14000011 RID: 17
		' (add) Token: 0x06004F11 RID: 20241 RVA: 0x0020D7F0 File Offset: 0x0020B9F0
		' (remove) Token: 0x06004F12 RID: 20242 RVA: 0x0020D824 File Offset: 0x0020BA24
		Friend Custom Event CurrentTableChanged As OO_00oOO.oo_00_O0_0O
			<CompilerGenerated()>
			AddHandler
				Dim oo_00_O0_0O As OO_00oOO.oo_00_O0_0O = OO_00oOO.O0o_00Oo0.o_o.
				Dim oo_00_O0_0O2 As OO_00oOO.oo_00_O0_0O
				Do
					oo_00_O0_0O2 = oo_00_O0_0O
					Dim value2 As OO_00oOO.oo_00_O0_0O = CType([Delegate].Combine(oo_00_O0_0O2, value), OO_00oOO.oo_00_O0_0O)
					oo_00_O0_0O = Interlocked.CompareExchange(Of OO_00oOO.oo_00_O0_0O)(OO_00oOO.O0o_00Oo0.o_o., value2, oo_00_O0_0O2)
				Loop While oo_00_O0_0O IsNot oo_00_O0_0O2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oo_00_O0_0O As OO_00oOO.oo_00_O0_0O = OO_00oOO.O0o_00Oo0.o_o.
				Dim oo_00_O0_0O2 As OO_00oOO.oo_00_O0_0O
				Do
					oo_00_O0_0O2 = oo_00_O0_0O
					Dim value2 As OO_00oOO.oo_00_O0_0O = CType([Delegate].Remove(oo_00_O0_0O2, value), OO_00oOO.oo_00_O0_0O)
					oo_00_O0_0O = Interlocked.CompareExchange(Of OO_00oOO.oo_00_O0_0O)(OO_00oOO.O0o_00Oo0.o_o., value2, oo_00_O0_0O2)
				Loop While oo_00_O0_0O IsNot oo_00_O0_0O2
			End RemoveHandler
		End Event

		' Token: 0x14000012 RID: 18
		' (add) Token: 0x06004F13 RID: 20243 RVA: 0x0020D858 File Offset: 0x0020BA58
		' (remove) Token: 0x06004F14 RID: 20244 RVA: 0x0020D88C File Offset: 0x0020BA8C
		Friend Custom Event MainTableChanged As OO_00oOO.oo0O0__O__oO
			<CompilerGenerated()>
			AddHandler
				Dim oo0O0__O__oO As OO_00oOO.oo0O0__O__oO = OO_00oOO.O0o_00Oo0.o_o.
				Dim oo0O0__O__oO2 As OO_00oOO.oo0O0__O__oO
				Do
					oo0O0__O__oO2 = oo0O0__O__oO
					Dim value2 As OO_00oOO.oo0O0__O__oO = CType([Delegate].Combine(oo0O0__O__oO2, value), OO_00oOO.oo0O0__O__oO)
					oo0O0__O__oO = Interlocked.CompareExchange(Of OO_00oOO.oo0O0__O__oO)(OO_00oOO.O0o_00Oo0.o_o., value2, oo0O0__O__oO2)
				Loop While oo0O0__O__oO IsNot oo0O0__O__oO2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oo0O0__O__oO As OO_00oOO.oo0O0__O__oO = OO_00oOO.O0o_00Oo0.o_o.
				Dim oo0O0__O__oO2 As OO_00oOO.oo0O0__O__oO
				Do
					oo0O0__O__oO2 = oo0O0__O__oO
					Dim value2 As OO_00oOO.oo0O0__O__oO = CType([Delegate].Remove(oo0O0__O__oO2, value), OO_00oOO.oo0O0__O__oO)
					oo0O0__O__oO = Interlocked.CompareExchange(Of OO_00oOO.oo0O0__O__oO)(OO_00oOO.O0o_00Oo0.o_o., value2, oo0O0__O__oO2)
				Loop While oo0O0__O__oO IsNot oo0O0__O__oO2
			End RemoveHandler
		End Event

		' Token: 0x170011AC RID: 4524
		' (get) Token: 0x06004F15 RID: 20245 RVA: 0x0020D8BF File Offset: 0x0020BABF
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property MRP As MRPTableCols
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011AD RID: 4525
		' (get) Token: 0x06004F16 RID: 20246 RVA: 0x0020D8C6 File Offset: 0x0020BAC6
		<oO0oooo("3388")>
		Public ReadOnly Property MRPCols As MRPTableCols
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x06004F17 RID: 20247
		Private Declare Function GetHardDiskId Lib "Foxtable.IO.dll" (A_0 As StringBuilder, A_1 As Integer) As Boolean

		' Token: 0x170011AE RID: 4526
		' (get) Token: 0x06004F18 RID: 20248 RVA: 0x0020D8CD File Offset: 0x0020BACD
		' (set) Token: 0x06004F19 RID: 20249 RVA: 0x0020D8D4 File Offset: 0x0020BAD4
		<oO0oooo("0365")>
		Public Property DataTables As DataTableCollection
			Get
				Return OO_00oOO.OO._ooO.
			End Get
			Friend Set(value As DataTableCollection)
				OO_00oOO.OO._ooO. = value
			End Set
		End Property

		' Token: 0x170011AF RID: 4527
		' (get) Token: 0x06004F1A RID: 20250 RVA: 0x0020D8DC File Offset: 0x0020BADC
		<oO0oooo("2495")>
		Public ReadOnly Property OpenFileArgs As List(Of Object)
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011B0 RID: 4528
		' (get) Token: 0x06004F1B RID: 20251 RVA: 0x0020D8E3 File Offset: 0x0020BAE3
		' (set) Token: 0x06004F1C RID: 20252 RVA: 0x0020D8EA File Offset: 0x0020BAEA
		<oO0oooo("0437")>
		Public Property Tables As TableCollection
			Get
				Return OO_00oOO.O0o_00Oo0.o_o.
			End Get
			Friend Set(value As TableCollection)
				OO_00oOO.O0o_00Oo0.o_o. = value
			End Set
		End Property

		' Token: 0x170011B1 RID: 4529
		' (get) Token: 0x06004F1D RID: 20253 RVA: 0x0020D8F2 File Offset: 0x0020BAF2
		<oO0oooo("0703")>
		Public ReadOnly Property Forms As FormCollection
			Get
				Return OO_00oOO.OO._ooO.
			End Get
		End Property

		' Token: 0x170011B2 RID: 4530
		' (get) Token: 0x06004F1E RID: 20254 RVA: 0x0020D8F9 File Offset: 0x0020BAF9
		Public ReadOnly Property Reports As ReportCollection
			Get
				Return OO_00oOO.o0O._o__O0.
			End Get
		End Property

		' Token: 0x170011B3 RID: 4531
		' (get) Token: 0x06004F1F RID: 20255 RVA: 0x0020D900 File Offset: 0x0020BB00
		<oO0oooo("1486")>
		Public ReadOnly Property Functions As UserFunctions
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011B4 RID: 4532
		' (get) Token: 0x06004F20 RID: 20256 RVA: 0x0020D907 File Offset: 0x0020BB07
		Public ReadOnly Property HardWareInfo As HardWare
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011B5 RID: 4533
		' (get) Token: 0x06004F21 RID: 20257 RVA: 0x0020D90E File Offset: 0x0020BB0E
		' (set) Token: 0x06004F22 RID: 20258 RVA: 0x0020D918 File Offset: 0x0020BB18
		Public Property ProjectFile As String
			Get
				Return OO_00oOO.oO_Oo._o0o.
			End Get
			Friend Set(value As String)
				OO_00oOO.oO_Oo._o0o. = value
				OO_00oOO.OOo._O___. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.oO_Oo._o0o.) + "\"
				OO_00oOO.O0.0oo0_. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.oO_Oo._o0o.) + "\Attachments\"
				If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) <> 0 Then
					Dim num As Integer = Main.OO_O.o..O0o__0_OO.o.().TabPages.Count - 1
					For i As Integer = 0 To num
						If Main.OO_O.o..O0o__0_OO.o.().TabPages(i).Controls.Count = 1 AndAlso Main.OO_O.o..O0o__0_OO.o.().TabPages(i).Controls(0) Is Main.OO_O.o..O.OOO0_OOo.() Then
							Main.OO_O.o..O0o__0_OO.o.().Close(Main.OO_O.o..O0o__0_OO.o.().TabPages(i))
							Exit For
						End If
					Next
					If Main.OO_O.o..O.OOO0_OOo.() IsNot Nothing Then
						Main.OO_O.o..O0.0000oO.(Nothing)
					End If
				End If
			End Set
		End Property

		' Token: 0x170011B6 RID: 4534
		' (get) Token: 0x06004F23 RID: 20259 RVA: 0x0020DA34 File Offset: 0x0020BC34
		<oO0oooo("1439")>
		Public ReadOnly Property ApplicationPath As String
			Get
				Return c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\"
			End Get
		End Property

		' Token: 0x170011B7 RID: 4535
		' (get) Token: 0x06004F24 RID: 20260 RVA: 0x0020DA54 File Offset: 0x0020BC54
		<oO0oooo("1439")>
		Public ReadOnly Property ProjectPath As String
			Get
				Return OO_00oOO.OOo._O___.
			End Get
		End Property

		' Token: 0x170011B8 RID: 4536
		' (get) Token: 0x06004F25 RID: 20261 RVA: 0x0020DA5B File Offset: 0x0020BC5B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property AttachPath As String
			Get
				Return OO_00oOO.O0.0oo0_.
			End Get
		End Property

		' Token: 0x170011B9 RID: 4537
		' (get) Token: 0x06004F26 RID: 20262 RVA: 0x0020DA64 File Offset: 0x0020BC64
		' (set) Token: 0x06004F27 RID: 20263 RVA: 0x0020DAB5 File Offset: 0x0020BCB5
		<oO0oooo("0436")>
		Public Property CurrentTable As Table
			Get
				Dim result As Table
				If OO_00oOO.oOO.0_. IsNot Nothing AndAlso OO_00oOO.oOO.0_..Grid IsNot Nothing AndAlso Not OO_00oOO.oOO.0_..Grid.IsDisposed AndAlso Not OO_00oOO.oOO.0_..Grid.Disposing Then
					result = OO_00oOO.oOO.0_.
				Else
					result = OO_00oOO.MainTable
				End If
				Return result
			End Get
			Friend Set(value As Table)
				If value Is Nothing Then
					OO_00oOO.oOO.0_. = Nothing
					Return
				End If
				If value.foxGrid.CanFocus OrElse Not OO_00oOO.CurrentTable.foxGrid.CanFocus Then
					OO_00oOO.oOO.0_. = value
				End If
			End Set
		End Property

		' Token: 0x170011BA RID: 4538
		' (get) Token: 0x06004F28 RID: 20264 RVA: 0x0020DAE5 File Offset: 0x0020BCE5
		' (set) Token: 0x06004F29 RID: 20265 RVA: 0x0020DAEC File Offset: 0x0020BCEC
		<oO0oooo("0436")>
		Public Property MainTable As Table
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
			Set(value As Table)
				If(value Is Nothing OrElse Not value.IsRelation) AndAlso value IsNot Nothing AndAlso (OO_00oOO.O_0.oooO__O. IsNot value OrElse OO_00oOO.O_0.oooO__O. Is Nothing) Then
					If value Is Nothing Then
						OO_00oOO.O_0.oooO__O. = Nothing
						Return
					End If
					If value.TableType Is Nothing AndAlso Not value.IsCopy Then
						Try
							For Each obj As Object In Main.OO_O.o..OO_O_0Oo.___o.().TabPages
								Dim oo0__Oo As Oo0__Oo = CType(obj, Oo0__Oo)
								If oo0__Oo.O_000__.o.() Is value Then
									If Not oo0__Oo.TabVisible Then
										oo0__Oo.TabVisible = True
									End If
									If Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab Is oo0__Oo Then
										OO_00oOO.O_0.oooO__O. = value
										OO_00oOO.oOO.0_. = value
										Exit For
									End If
									Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab = oo0__Oo
									If Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab IsNot oo0__Oo Then
										Exit For
									End If
									OO_00oOO.O_0.oooO__O. = value
									OO_00oOO.oOO.0_. = value
									If value.foxGrid.FindForm() Is Main.OO_O.o. Then
										Main.OO_O.o..ActiveControl = value.foxGrid
										Exit For
									End If
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
				End If
			End Set
		End Property

		' Token: 0x06004F2A RID: 20266 RVA: 0x0020DC24 File Offset: 0x0020BE24
		Public Sub RaiseSystemEvent(Table As Table, ParamArray EventType As SystemEventTypeEnum())
			If OO_00oOO.SystemReady Then
				Dim num As Integer = EventType.Length - 1
				For i As Integer = 0 To num
					Dim systemEventTypeEnum As SystemEventTypeEnum = EventType(i)
					If systemEventTypeEnum <= 8 Then
						Select Case systemEventTypeEnum
							Case 0
								Dim o0o_00Oo0.o_o. As OO_00oOO.oo0O0__O__oO = OO_00oOO.O0o_00Oo0.o_o.
								If o0o_00Oo0.o_o. IsNot Nothing Then
									o0o_00Oo0.o_o.()
								End If
							Case 1
								Dim o0o_00Oo0.o_o.2 As OO_00oOO.oo_00_O0_0O = OO_00oOO.O0o_00Oo0.o_o.
								If o0o_00Oo0.o_o.2 IsNot Nothing Then
									o0o_00Oo0.o_o.2()
								End If
							Case 2, 3
							Case 4
								If Table IsNot Nothing Then
									Table.View.o_._0O0o_OoO.()
								End If
							Case Else
								If systemEventTypeEnum = 8 Then
									If Table IsNot Nothing Then
										Table.View.Oo._Oo0OO.()
									End If
								End If
						End Select
					ElseIf systemEventTypeEnum <> 16 Then
						If systemEventTypeEnum = 32 Then
							If Table IsNot Nothing Then
								Table.foxGrid.o0O.o__O0Oo0.()
							End If
						End If
					ElseIf Table IsNot Nothing Then
						Table.foxGrid.OooooOO.0_.()
					End If
				Next
			End If
		End Sub

		' Token: 0x170011BB RID: 4539
		' (get) Token: 0x06004F2B RID: 20267 RVA: 0x0020DCEA File Offset: 0x0020BEEA
		<oO0oooo("1942")>
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return OO_00oOO.o0O._o__O0.
			End Get
		End Property

		' Token: 0x170011BC RID: 4540
		' (get) Token: 0x06004F2C RID: 20268 RVA: 0x0020DCF1 File Offset: 0x0020BEF1
		<oO0oooo("1944")>
		Public ReadOnly Property Connections As ConnectionCollection
			Get
				Return OO_00oOO.OO._ooO.
			End Get
		End Property

		' Token: 0x170011BD RID: 4541
		' (get) Token: 0x06004F2D RID: 20269 RVA: 0x0020DCF8 File Offset: 0x0020BEF8
		<oO0oooo("1963")>
		Public ReadOnly Property FileWatcher As FileSystemWatcher
			Get
				Return OO_00oOO.OO._ooO.
			End Get
		End Property

		' Token: 0x170011BE RID: 4542
		' (get) Token: 0x06004F2E RID: 20270 RVA: 0x0020DCFF File Offset: 0x0020BEFF
		<oO0oooo("1968")>
		Public ReadOnly Property Ports As MyPortCollections
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011BF RID: 4543
		' (get) Token: 0x06004F2F RID: 20271 RVA: 0x0020DD06 File Offset: 0x0020BF06
		<oO0oooo("1324")>
		Public ReadOnly Property ContextMenus As ContextMenuCollection
			Get
				If OO_00oOO.OO._ooO. Is Nothing Then
					OO_00oOO.OO._ooO. = New ContextMenuCollection(O_O0OO.o.00O_O.())
				End If
				Return OO_00oOO.OO._ooO.
			End Get
		End Property

		' Token: 0x170011C0 RID: 4544
		' (get) Token: 0x06004F30 RID: 20272 RVA: 0x0020DD23 File Offset: 0x0020BF23
		<oO0oooo("2483")>
		Public ReadOnly Property RibbonTabs As RibbonTabCollection
			Get
				If OO_00oOO.o0O._o__O0. Is Nothing Then
					OO_00oOO.o0O._o__O0. = New RibbonTabCollection(Main.OO_O.o..O.OOO0_OOo.().Tabs)
				End If
				Return OO_00oOO.o0O._o__O0.
			End Get
		End Property

		' Token: 0x170011C1 RID: 4545
		' (get) Token: 0x06004F31 RID: 20273 RVA: 0x0020DD4A File Offset: 0x0020BF4A
		<oO0oooo("3088")>
		Public ReadOnly Property RibbonTabGroups As RibbonTabGroupCollection
			Get
				If OO_00oOO.o0O._o__O0. Is Nothing Then
					OO_00oOO.o0O._o__O0. = New RibbonTabGroupCollection(Main.OO_O.o..O.OOO0_OOo.().ContextualTabGroups)
				End If
				Return OO_00oOO.o0O._o__O0.
			End Get
		End Property

		' Token: 0x170011C2 RID: 4546
		' (get) Token: 0x06004F32 RID: 20274 RVA: 0x0020DD71 File Offset: 0x0020BF71
		<oO0oooo("1091")>
		Public ReadOnly Property ApplicationMenu As ApplicationMenu
			Get
				Return New ApplicationMenu(Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu)
			End Get
		End Property

		' Token: 0x170011C3 RID: 4547
		' (get) Token: 0x06004F33 RID: 20275 RVA: 0x0020DD87 File Offset: 0x0020BF87
		<oO0oooo("1094")>
		Public ReadOnly Property QAT As Qat
			Get
				Return New Qat(Main.OO_O.o..O.OOO0_OOo.().Qat)
			End Get
		End Property

		' Token: 0x170011C4 RID: 4548
		' (get) Token: 0x06004F34 RID: 20276 RVA: 0x0020DD9D File Offset: 0x0020BF9D
		<oO0oooo("1097")>
		Public ReadOnly Property ConfigBar As ConfigBar
			Get
				Return New ConfigBar(Main.OO_O.o..O.OOO0_OOo.().ConfigToolBar)
			End Get
		End Property

		' Token: 0x170011C5 RID: 4549
		' (get) Token: 0x06004F35 RID: 20277 RVA: 0x0020DDB3 File Offset: 0x0020BFB3
		<oO0oooo("3086")>
		Public ReadOnly Property TopToolBar As TopToolBar
			Get
				Return New TopToolBar(Main.OO_O.o..O.OOO0_OOo.().TopToolBar)
			End Get
		End Property

		' Token: 0x170011C6 RID: 4550
		' (get) Token: 0x06004F36 RID: 20278 RVA: 0x0020DDC9 File Offset: 0x0020BFC9
		<oO0oooo("3087")>
		Public ReadOnly Property BottomToolBar As BottomToolBar
			Get
				Return New BottomToolBar(Main.OO_O.o..O.OOO0_OOo.().BottomToolBar)
			End Get
		End Property

		' Token: 0x170011C7 RID: 4551
		' (get) Token: 0x06004F37 RID: 20279 RVA: 0x0020DDDF File Offset: 0x0020BFDF
		' (set) Token: 0x06004F38 RID: 20280 RVA: 0x0020DDE6 File Offset: 0x0020BFE6
		<oO0oooo("0609")>
		Public Property User As UserInfo
			Get
				Return OO_00oOO.O0o_00Oo0.o_o.
			End Get
			Friend Set(value As UserInfo)
				If Not OO_00oOO.isUserColdeRunning() Then
					OO_00oOO.O0o_00Oo0.o_o. = value
				End If
			End Set
		End Property

		' Token: 0x170011C8 RID: 4552
		' (get) Token: 0x06004F39 RID: 20281 RVA: 0x0020DDF5 File Offset: 0x0020BFF5
		<oO0oooo("0356")>
		Public ReadOnly Property ModifierKey As Keys
			Get
				Return Control.ModifierKeys
			End Get
		End Property

		' Token: 0x170011C9 RID: 4553
		' (get) Token: 0x06004F3A RID: 20282 RVA: 0x0020DDFC File Offset: 0x0020BFFC
		<oO0oooo("0355")>
		Public ReadOnly Property MouseButton As MouseButtons
			Get
				Return Control.MouseButtons
			End Get
		End Property

		' Token: 0x170011CA RID: 4554
		' (get) Token: 0x06004F3B RID: 20283 RVA: 0x0020DE03 File Offset: 0x0020C003
		<oO0oooo("0658")>
		Public ReadOnly Property MyTimers As TimerCollection
			Get
				Return OO_00oOO.O0o_00Oo0.o_o.
			End Get
		End Property

		' Token: 0x170011CB RID: 4555
		' (get) Token: 0x06004F3C RID: 20284 RVA: 0x0020DE0A File Offset: 0x0020C00A
		<oO0oooo("0325")>
		Public ReadOnly Property Vars As VarsCollection
			Get
				Return OO_00oOO.O0o_00Oo0.o_o.
			End Get
		End Property

		' Token: 0x06004F3D RID: 20285 RVA: 0x0020DE14 File Offset: 0x0020C014
		Public Function GetImage(ImageFile As String) As Image
			Dim image As Image = Nothing
			Dim result As Image
			If Operators.CompareString(ImageFile, "", True) = 0 Then
				result = Nothing
			Else
				ImageFile = ImageFile.ToLower()
				Try
					If String.IsNullOrEmpty(Path.GetPathRoot(ImageFile)) Then
						If OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + ImageFile) Then
							ImageFile = O_O0OO.OOo_o.0o. + ImageFile
						Else
							ImageFile = ooO.OoO0o_o___.O.(ImageFile)
							If Not File.Exists(ImageFile) Then
								ImageFile = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\images\" + c.OOOOO.o.().FileSystem.GetName(ImageFile)
							End If
						End If
					End If
					If Not File.Exists(ImageFile) Then
						Return Nothing
					End If
					If Operators.CompareString(Path.GetExtension(ImageFile).ToUpper(), ".ICO", True) = 0 Then
						Dim buffer As Byte() = OO_00oOO.FileSys.ReadAllBytes(ImageFile)
						image = New Icon(New MemoryStream(buffer)).ToBitmap()
					Else
						Dim buffer2 As Byte() = OO_00oOO.FileSys.ReadAllBytes(ImageFile)
						image = Image.FromStream(New MemoryStream(buffer2))
					End If
				Catch ex As Exception
				End Try
				result = image
			End If
			Return result
		End Function

		' Token: 0x170011CC RID: 4556
		' (get) Token: 0x06004F3E RID: 20286 RVA: 0x0020DF34 File Offset: 0x0020C134
		Public ReadOnly Property BindTables(A_0 As String) As DataView
			Get
				Return OO_00oOO.Tables(A_0).View.o_o.O0ooOo.()
			End Get
		End Property

		' Token: 0x170011CD RID: 4557
		' (get) Token: 0x06004F3F RID: 20287 RVA: 0x0020DF4B File Offset: 0x0020C14B
		<oO0oooo("0330")>
		Public ReadOnly Property Audio As Audio
			Get
				Return c.OOOOO.o.().Audio
			End Get
		End Property

		' Token: 0x170011CE RID: 4558
		' (get) Token: 0x06004F40 RID: 20288 RVA: 0x0020DF57 File Offset: 0x0020C157
		<oO0oooo("0331")>
		Public ReadOnly Property FileSys As FileSystemProxy
			Get
				Return c.OOOOO.o.().FileSystem
			End Get
		End Property

		' Token: 0x06004F41 RID: 20289 RVA: 0x0020DF64 File Offset: 0x0020C164
		<oO0oooo("0675")>
		Public Function InTax(x As Double) As Double
			Dim array As Double() = New Double() { 80000.0, 55000.0, 35000.0, 25000.0, 12000.0, 3000.0, 0.0 }
			Dim array2 As Double() = New Double() { 0.45, 0.35, 0.3, 0.25, 0.2, 0.1, 0.03 }
			Dim num As Integer = array.Length - 1
			Dim num3 As Double
			For i As Integer = 0 To num
				Dim num2 As Double = x - array(i)
				If num2 > 0.0 Then
					num3 += num2 * array2(i)
					x -= num2
				End If
				If x < 0.0 Then
					Exit For
				End If
			Next
			Return Math.Round(num3, 2, MidpointRounding.AwayFromZero)
		End Function

		' Token: 0x170011CF RID: 4559
		' (get) Token: 0x06004F42 RID: 20290 RVA: 0x0020DFE4 File Offset: 0x0020C1E4
		Private ReadOnly Property IIFCode As String
			Get
				If Operators.CompareString(OO_00oOO.O__0o0.o., "", True) = 0 Then
					OO_00oOO.O__0o0.o. = "Function IIF(expression, true_value, false_value)" & vbCrLf
					OO_00oOO.O__0o0.o. += "IIF = false_value" & vbCrLf
					OO_00oOO.O__0o0.o. += "If expression Then IIF = true_value" & vbCrLf
					OO_00oOO.O__0o0.o. += "End Function"
				End If
				Return OO_00oOO.O__0o0.o.
			End Get
		End Property

		' Token: 0x06004F43 RID: 20291 RVA: 0x0020E050 File Offset: 0x0020C250
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim text As String = "<>()+-*/,&\=[]"
			Dim text2 As String = "＜＞（）＋－＊／，＆\＝［］"
			Dim num As Integer = text.Length - 1
			For i As Integer = 0 To num
				A_0 = A_0.Replace(text2(i), text(i))
			Next
			Return A_0
		End Function

		' Token: 0x06004F44 RID: 20292 RVA: 0x0020E098 File Offset: 0x0020C298
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As DataRow, A_2 As Boolean, A_3 As Boolean, A_4 As Boolean) As Object
			If OO_00oOO.a Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.a, New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.a, flag)
				If OO_00oOO.a.State = 0S Then
					OO_00oOO.a.State = 2S
					OO_00oOO.a = Nothing
				ElseIf OO_00oOO.a.State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.a.State = 1S
				If flag Then
					Monitor.[Exit](OO_00oOO.a)
				End If
			End Try
			A_0 = OO_00oOO.o___O.0oOoO_.(A_0)
			If OO_00oOO.a Is Nothing Then
				OO_00oOO.a = New ScriptControlClass()
				OO_00oOO.a.Language = "VBScript"
				OO_00oOO.a = New Dictionary(Of String, String)()
			End If
			OO_00oOO.a.Reset()
			OO_00oOO.a.Clear()
			OO_00oOO.a.AddCode(String.Concat(New String() { OO_00oOO.IIFCode, vbCrLf, SysInfo.ChineseScript, vbCrLf, SysInfo.FormatCode }))
			Dim dataRow As DataRow
			Dim dataTable As DataTable
			If A_1 IsNot Nothing Then
				dataRow = A_1.BaseRow
				dataTable = dataRow.Table
			Else
				dataRow = Nothing
				dataTable = Nothing
			End If
			Dim num As Integer
			For i As Integer = A_0.IndexOf("[")To 0
				num = A_0.IndexOf("]", i + 1)
				Dim text As String = A_0.Substring(i + 1, num - i - 1)
				If A_1 IsNot Nothing AndAlso dataTable.Columns.Contains(text) AndAlso Not OO_00oOO.a.ContainsValue(text) Then
					OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), text)
					If Not dataRow.IsNull(text) Then
						If dataTable.Columns(text).DataType Is GetType(String) Then
							OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = """, dataRow(text).ToString().Replace(vbCrLf, "").Replace("""", """"""), """" }))
						ElseIf dataTable.Columns(text).DataType Is GetType(DateTime) Then
							OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = #", dataRow(text).ToString(), "#" }))
						Else
							OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow(text).ToString())
						End If
					End If
				ElseIf text.StartsWith("@") Then
					If text.IndexOf(",") < 0 Then
						Continue For
					End If
					text = text.Substring(1)
					Dim array As String() = text.Split(New Char() { ","c })
					Dim text2 As String = array(0).Trim()
					Dim text3 As String = array(1).Trim()
					Dim num2 As Integer = -1
					Dim dataRow2 As DataRow = Nothing
					If array.Length = 3 AndAlso Not Integer.TryParse(array(2), num2) Then
						num2 = -1
					End If
					If OO_00oOO.Tables.get_Contains(text2) AndAlso OO_00oOO.Tables(text2).Cols.Contains(text3) Then
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), "@" + text)
						If num2 = -1 Then
							If OO_00oOO.Tables(text2).Current IsNot Nothing Then
								dataRow2 = OO_00oOO.Tables(text2).Current.BaseDataRow
							End If
						Else
							If array(2).StartsWith("+") Then
								num2 = OO_00oOO.Tables(text2).Position + num2
							End If
							If num2 >= 0 AndAlso num2 < OO_00oOO.Tables(text2).Rows.Count Then
								dataRow2 = OO_00oOO.Tables(text2).Rows(num2).BaseDataRow
							End If
						End If
						If dataRow2 IsNot Nothing AndAlso Not dataRow2.IsNull(text3) Then
							If dataRow2.Table.Columns(text3).DataType Is GetType(String) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = """, dataRow2(text3).ToString(), """" }))
							ElseIf dataRow2.Table.Columns(text3).DataType Is GetType(DateTime) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = #", dataRow2(text3).ToString(), "#" }))
							Else
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow2(text3).ToString())
							End If
						End If
					End If
				ElseIf text.StartsWith("!") Then
					text = text.Substring(1)
					If OO_00oOO.Vars.VariableTable.Columns.Contains(text) Then
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), "!" + text)
						If OO_00oOO.Vars(text) IsNot Nothing Then
							If OO_00oOO.Vars.VariableTable.Columns(text).DataType Is GetType(String) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = """, OO_00oOO.Vars(text).ToString(), """" }))
							ElseIf OO_00oOO.Vars.VariableTable.Columns(text).DataType Is GetType(DateTime) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = #", OO_00oOO.Vars(text).ToString(), "#" }))
							Else
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + OO_00oOO.Vars(text).ToString())
							End If
						End If
					End If
				ElseIf A_1 IsNot Nothing AndAlso text.IndexOf(",") > 0 Then
					Dim array2 As String() = text.Split(New Char() { ","c })
					Dim text4 As String = array2(1).Trim()
					Dim array3 As String() = array2(0).Split(New Char() { "."c })
					Dim dataRow3 As DataRow = dataRow
					Dim num3 As Integer = array3.Length - 1
					Dim flag2 As Boolean
					For j As Integer = 0 To num3
						Dim right As String = array3(j).Trim()
						flag2 = False
						Try
							For Each obj As Object In O_O0OO.OOOo.oo_OOOO_0.().Relations
								Dim dataRelation As DataRelation = CType(obj, DataRelation)
								If Operators.CompareString(dataRelation.ParentTable.TableName, right, True) = 0 AndAlso Operators.CompareString(dataRelation.ChildTable.TableName, dataRow3.Table.TableName, True) = 0 Then
									flag2 = True
									dataRow3 = dataRow3.GetParentRow(dataRelation.RelationName)
									If dataRow3 Is Nothing Then
										Exit For
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If Not flag2 Then
							Exit For
						End If
					Next
					If flag2 AndAlso dataRow3 IsNot Nothing AndAlso dataRow3 IsNot dataRow AndAlso dataRow3.Table.Columns.Contains(text4) Then
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), text)
						If Not dataRow3.IsNull(text4) Then
							If dataRow3.Table.Columns(text4).DataType Is GetType(String) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = """, dataRow3(text4).ToString(), """" }))
							ElseIf dataTable.Columns(text4).DataType Is GetType(DateTime) Then
								OO_00oOO.a.ExecuteStatement(String.Concat(New String() { "a", Conversions.ToString(OO_00oOO.a.Count - 1), " = #", dataRow3(text4).ToString(), "#" }))
							Else
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow3(text4).ToString())
							End If
						End If
					End If
				End If
			Next
			Try
				For Each text5 As String In OO_00oOO.a.Keys
					A_0 = A_0.Replace("[" + OO_00oOO.a(text5) + "]", text5)
				Next
			Finally
				Dim enumerator2 As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator2, IDisposable).Dispose()
			End Try
			Dim result As Object
			Try
				Dim objectValue As Object
				If A_2 Then
					A_0 = "Function Eval() " & vbCrLf + A_0 + vbCrLf & "End  Function"
					OO_00oOO.a.AddCode(A_0)
					Dim scriptControl As IScriptControl = OO_00oOO.a
					Dim text6 As String = "Eval"
					Dim array4 As Object() = New Object(-1) {}
					objectValue = RuntimeHelpers.GetObjectValue(scriptControl.Run(text6, array4))
				Else
					objectValue = RuntimeHelpers.GetObjectValue(OO_00oOO.a.Eval(A_0))
				End If
				If A_3 Then
					result = True
				Else
					result = objectValue
				End If
			Catch a_ As Exception
				If A_3 Then
					result = False
				Else
					If Not A_4 Then
						ooO.oOo0Oo.o.(a_, "Eval函数计算错误，表达式为：" + A_0)
					End If
					result = Nothing
				End If
			End Try
			Return result
		End Function

		' Token: 0x06004F45 RID: 20293 RVA: 0x0020EBC4 File Offset: 0x0020CDC4
		<oO0oooo("1277")>
		Public Function Eval(Expr As String, Row As Row) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, False, False, False)
		End Function

		' Token: 0x06004F46 RID: 20294 RVA: 0x0020EBD5 File Offset: 0x0020CDD5
		<oO0oooo("1277")>
		Public Function Eval(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, DataRow, False, False, False)
		End Function

		' Token: 0x06004F47 RID: 20295 RVA: 0x0020EBE1 File Offset: 0x0020CDE1
		<oO0oooo("1277")>
		Public Function Eval(Expr As String) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Nothing, False, False, False)
		End Function

		' Token: 0x06004F48 RID: 20296 RVA: 0x0020EBED File Offset: 0x0020CDED
		<oO0oooo("1277")>
		Public Function Eval2(Expr As String, Row As Row) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, False, False, True)
		End Function

		' Token: 0x06004F49 RID: 20297 RVA: 0x0020EBFE File Offset: 0x0020CDFE
		<oO0oooo("1277")>
		Public Function Eval2(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, DataRow, False, False, True)
		End Function

		' Token: 0x06004F4A RID: 20298 RVA: 0x0020EC0A File Offset: 0x0020CE0A
		<oO0oooo("1277")>
		Public Function Eval2(Expr As String) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Nothing, False, False, True)
		End Function

		' Token: 0x06004F4B RID: 20299 RVA: 0x0020EC16 File Offset: 0x0020CE16
		<oO0oooo("1277")>
		Public Function TryEval(Expr As String, Row As Row) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, False, True, False)
		End Function

		' Token: 0x06004F4C RID: 20300 RVA: 0x0020EC27 File Offset: 0x0020CE27
		<oO0oooo("1277")>
		Public Function TryEval(Expr As String, DataRow As DataRow) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, DataRow, False, True, False)
		End Function

		' Token: 0x06004F4D RID: 20301 RVA: 0x0020EC33 File Offset: 0x0020CE33
		<oO0oooo("1277")>
		Public Function TryEval(Expr As String) As Object
			Return OO_00oOO.oo0oOO.o.(Expr, Nothing, False, True, False)
		End Function

		' Token: 0x170011D0 RID: 4560
		' (get) Token: 0x06004F4E RID: 20302 RVA: 0x0020EC40 File Offset: 0x0020CE40
		' (set) Token: 0x06004F4F RID: 20303 RVA: 0x0020EC4E File Offset: 0x0020CE4E
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property VisualStyle As VisualStyleEnum
			Get
				Dim result As VisualStyleEnum
				Return result
			End Get
			Set(value As VisualStyleEnum)
			End Set
		End Property

		' Token: 0x06004F50 RID: 20304 RVA: 0x0020EC50 File Offset: 0x0020CE50
		<oO0oooo("2293")>
		Public Sub ShowHelpWindow()
			If OO_00oOO.OO_.000_0_O_O. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.OO_.000_0_O_O., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.OO_.000_0_O_O., flag)
				If OO_00oOO.OO_.000_0_O_O..State = 0S Then
					OO_00oOO.OO_.000_0_O_O..State = 2S
					OO_00oOO.O.OoO__0O_oO. = ""
				ElseIf OO_00oOO.OO_.000_0_O_O..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.OO_.000_0_O_O..State = 1S
				If flag Then
					Monitor.[Exit](OO_00oOO.OO_.000_0_O_O.)
				End If
			End Try
			If OO_00oOO.oOO0o_Oo00.O. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.oOO0o_Oo00.O., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag2 As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.oOO0o_Oo00.O., flag2)
				If OO_00oOO.oOO0o_Oo00.O..State = 0S Then
					OO_00oOO.oOO0o_Oo00.O..State = 2S
					OO_00oOO.ooo.__O0O0O0O. = ""
				ElseIf OO_00oOO.oOO0o_Oo00.O..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.oOO0o_Oo00.O..State = 1S
				If flag2 Then
					Monitor.[Exit](OO_00oOO.oOO0o_Oo00.O.)
				End If
			End Try
			If OO_00oOO.O_0__O.o_ooo. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.O_0__O.o_ooo., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag3 As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.O_0__O.o_ooo., flag3)
				If OO_00oOO.O_0__O.o_ooo..State = 0S Then
					OO_00oOO.O_0__O.o_ooo..State = 2S
					OO_00oOO.O0o_.ooo000o0O. = New Process()
				ElseIf OO_00oOO.O_0__O.o_ooo..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.O_0__O.o_ooo..State = 1S
				If flag3 Then
					Monitor.[Exit](OO_00oOO.O_0__O.o_ooo.)
				End If
			End Try
			If OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm") Then
				OO_00oOO.O.OoO__0O_oO. = OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm"
			Else
				If Not OO_00oOO.FileSys.FileExists(Main.OO_O.o.) Then
					Return
				End If
				OO_00oOO.O.OoO__0O_oO. = Main.OO_O.o.
			End If
			If Operators.CompareString(OO_00oOO.O.OoO__0O_oO., OO_00oOO.ooo.__O0O0O0O., True) = 0 AndAlso Operators.CompareString(OO_00oOO.O.OoO__0O_oO., "", True) > 0 AndAlso Not OO_00oOO.O0o_.ooo000o0O..HasExited Then
				ooO.SetForegroundWindow(OO_00oOO.O0o_.ooo000o0O..MainWindowHandle)
				Return
			End If
			OO_00oOO.O0o_.ooo000o0O..File = OO_00oOO.O.OoO__0O_oO.
			OO_00oOO.O0o_.ooo000o0O..Start()
			OO_00oOO.ooo.__O0O0O0O. = OO_00oOO.O.OoO__0O_oO.
		End Sub

		' Token: 0x06004F51 RID: 20305 RVA: 0x0020EEB0 File Offset: 0x0020D0B0
		<oO0oooo("2293")>
		Public Sub ShowHelpWindow(Topic As String)
			If OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm") Then
				Help.ShowHelp(Nothing, OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm", Topic)
				Return
			End If
			If OO_00oOO.FileSys.FileExists(Main.OO_O.o.) Then
				Help.ShowHelp(Nothing, Main.OO_O.o., Topic)
			End If
		End Sub

		' Token: 0x06004F52 RID: 20306 RVA: 0x0020EF20 File Offset: 0x0020D120
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ShowHelpWindow2()
			If OO_00oOO.o_.o_O. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.o_.o_O., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.o_.o_O., flag)
				If OO_00oOO.o_.o_O..State = 0S Then
					OO_00oOO.o_.o_O..State = 2S
					OO_00oOO.oO.o_0_o00O_O0. = ""
				ElseIf OO_00oOO.o_.o_O..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.o_.o_O..State = 1S
				If flag Then
					Monitor.[Exit](OO_00oOO.o_.o_O.)
				End If
			End Try
			If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "foxmobile.chm") Then
				If Operators.CompareString(OO_00oOO.oO.o_0_o00O_O0., "", True) = 0 Then
					OO_00oOO.oO.o_0_o00O_O0. = O_O0OO.o.00O_O.() + "foxmobile.chm"
					OO_00oOO.oOO.0_. = New Process()
				ElseIf OO_00oOO.oOO.0_. IsNot Nothing AndAlso Not OO_00oOO.oOO.0_..HasExited Then
					ooO.SetForegroundWindow(OO_00oOO.oOO.0_..MainWindowHandle)
					Return
				End If
				OO_00oOO.oOO.0_..File = OO_00oOO.oO.o_0_o00O_O0.
				OO_00oOO.oOO.0_..Start()
			End If
		End Sub

		' Token: 0x06004F53 RID: 20307 RVA: 0x0020F040 File Offset: 0x0020D240
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ExecuteCode(Code As String, ReturnValue As Boolean) As Object
			Dim stringBuilder As StringBuilder = New StringBuilder()
			If Operators.CompareString(Code, "", True) > 0 Then
				Code = Code.Trim(New Char() { " "c, vbLf, vbCr, vbTab, "　"c })
			End If
			If ReturnValue Then
				stringBuilder.Append("Public Function Test() As Object")
			ElseIf Code.StartsWith("'''async", StringComparison.OrdinalIgnoreCase) Then
				stringBuilder.Append("Public Async Sub Test()")
			Else
				stringBuilder.Append("Public Sub Test()")
			End If
			stringBuilder.Append(vbCrLf)
			stringBuilder.Append(Code)
			stringBuilder.Append(vbCrLf)
			If ReturnValue Then
				stringBuilder.Append("End Function")
			Else
				stringBuilder.Append("End Sub")
			End If
			Dim assembly As Assembly = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), "", O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), False, "", True)
			If assembly IsNot Nothing Then
				Dim method As MethodInfo = assembly.[GetType]("UserCode").GetMethod("Test")
				Try
					If ReturnValue Then
						Return method.Invoke(Nothing, Nothing)
					End If
					method.Invoke(Nothing, Nothing)
				Catch ex As Exception
					MessageBox.Show("代码执行出错，错误信息：" & vbCrLf & vbCrLf + ex.InnerException.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
			Return Nothing
		End Function

		' Token: 0x06004F54 RID: 20308 RVA: 0x0020F198 File Offset: 0x0020D398
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub AddConnection(ConnName As String, ConnString As String)
			OO_00oOO.Connections.Add(ConnName, ConnString)
		End Sub

		' Token: 0x06004F55 RID: 20309 RVA: 0x0020F1A6 File Offset: 0x0020D3A6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub DeleteConnection(ConnName As String)
			OO_00oOO.Connections.Delete(ConnName)
		End Sub

		' Token: 0x06004F56 RID: 20310 RVA: 0x0020F1B3 File Offset: 0x0020D3B3
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ContainsConnection(Connname As String) As Boolean
			Return OO_00oOO.Connections.Contains(Connname)
		End Function

		' Token: 0x06004F57 RID: 20311 RVA: 0x0020F1C0 File Offset: 0x0020D3C0
		Public Function ApplicationVertion() As String
			Dim version As Version = c.Oo.__O0.().Info.Version
			Return String.Concat(New String() { Conversions.ToString(version.Major), "-", Conversions.ToString(version.Minor), "-", Conversions.ToString(version.Build) })
		End Function

		' Token: 0x170011D1 RID: 4561
		' (get) Token: 0x06004F58 RID: 20312 RVA: 0x0020F222 File Offset: 0x0020D422
		' (set) Token: 0x06004F59 RID: 20313 RVA: 0x0020F22E File Offset: 0x0020D42E
		Public Property ApplicationTitle As String
			Get
				Return Main.OO_O.o..Text
			End Get
			Set(value As String)
				Main.OO_O.o..Text = value
			End Set
		End Property

		' Token: 0x06004F5A RID: 20314 RVA: 0x0020F23B File Offset: 0x0020D43B
		Public Function PublishDate() As DateTime
			Return O_O0OO.O0_00o.o0__o..PublishDate
		End Function

		' Token: 0x170011D2 RID: 4562
		' (get) Token: 0x06004F5B RID: 20315 RVA: 0x0020F247 File Offset: 0x0020D447
		' (set) Token: 0x06004F5C RID: 20316 RVA: 0x0020F253 File Offset: 0x0020D453
		Public Property UpdatePath As String
			Get
				Return O_O0OO.O0_00o.o0__o..UpdatePath
			End Get
			Set(value As String)
				O_O0OO.O0_00o.o0__o..UpdatePath = value
			End Set
		End Property

		' Token: 0x170011D3 RID: 4563
		' (get) Token: 0x06004F5D RID: 20317 RVA: 0x0020F260 File Offset: 0x0020D460
		' (set) Token: 0x06004F5E RID: 20318 RVA: 0x0020F26C File Offset: 0x0020D46C
		Public Property RemoteUpdate As Boolean
			Get
				Return O_O0OO.O0_00o.o0__o..RemoteUpdate
			End Get
			Set(value As Boolean)
				O_O0OO.O0_00o.o0__o..RemoteUpdate = value
			End Set
		End Property

		' Token: 0x170011D4 RID: 4564
		' (get) Token: 0x06004F5F RID: 20319 RVA: 0x0020F279 File Offset: 0x0020D479
		<oO0oooo("1545")>
		Public ReadOnly Property ComputerId As String
			Get
				Return o_o_O0OO_0__.oo00_.0oO_.()
			End Get
		End Property

		' Token: 0x170011D5 RID: 4565
		' (get) Token: 0x06004F60 RID: 20320 RVA: 0x0020F280 File Offset: 0x0020D480
		<oO0oooo("1601")>
		Public ReadOnly Property InstalledPrinters As List(Of String)
			Get
				Dim list As List(Of String) = New List(Of String)()
				Try
					For Each value As Object In PrinterSettings.InstalledPrinters
						Dim item As String = Conversions.ToString(value)
						list.Add(item)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Return list
			End Get
		End Property

		' Token: 0x170011D6 RID: 4566
		' (get) Token: 0x06004F61 RID: 20321 RVA: 0x0020F2E4 File Offset: 0x0020D4E4
		Public ReadOnly Property DefaultPrinter As String
			Get
				Return New PrinterSettings().PrinterName
			End Get
		End Property

		' Token: 0x170011D7 RID: 4567
		' (get) Token: 0x06004F62 RID: 20322 RVA: 0x0020F2F0 File Offset: 0x0020D4F0
		Public ReadOnly Property GetPaperSources(A_0 As String) As List(Of String)
			Get
				Dim printerSettings As PrinterSettings = New PrinterSettings()
				printerSettings.PrinterName = A_0
				Dim list As List(Of String) = New List(Of String)()
				Dim num As Integer = printerSettings.PaperSources.Count - 1
				For i As Integer = 0 To num
					list.Add(printerSettings.PaperSources(i).SourceName)
				Next
				Return list
			End Get
		End Property

		' Token: 0x06004F63 RID: 20323 RVA: 0x0020F342 File Offset: 0x0020D542
		Public Sub CloseSplashForm()
			Main.OO_O.o. = 4
		End Sub

		' Token: 0x170011D8 RID: 4568
		' (get) Token: 0x06004F64 RID: 20324 RVA: 0x0020F34A File Offset: 0x0020D54A
		' (set) Token: 0x06004F65 RID: 20325 RVA: 0x0020F351 File Offset: 0x0020D551
		Public Property MarkModifedCell As Boolean
			Get
				Return OO_00oOO.OO.O_O0.
			End Get
			Set(value As Boolean)
				OO_00oOO.OO.O_O0. = value
			End Set
		End Property

		' Token: 0x06004F66 RID: 20326 RVA: 0x0020F35C File Offset: 0x0020D55C
		Public Function EditConnectionString(Optional ConnectionString As String = "") As String
			Dim visible As Boolean = Main.ProcessForm.Visible
			Dim o_u3002_u3000_u As O\u3002\u3000\u3000 = New O\u3002\u3000\u3000()
			o_u3002_u3000_u.OO._000_O0o_.().Text = ConnectionString
			o_u3002_u3000_u.OO._000_O0o_.().Text = "请输入链接字符串:"
			o_u3002_u3000_u.OO._000_O0o_.().Height = o_u3002_u3000_u.OO._000_O0o_.().Height + 30
			o_u3002_u3000_u.OO_._o_o0_00.().Text = ""
			Main.ProcessForm.Hide()
			Main.OO_O.o. = 4
			If o_u3002_u3000_u.ShowDialog() = DialogResult.OK Then
				ConnectionString = o_u3002_u3000_u.OO._000_O0o_.().Text
			End If
			Return ConnectionString
		End Function

		' Token: 0x06004F67 RID: 20327 RVA: 0x0020F3E6 File Offset: 0x0020D5E6
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetTableNamesFromConnection(ConnectionName As String) As List(Of String)
			Return CType(OO_00oOO.Connections(ConnectionName).GetTableNames(), List(Of String))
		End Function

		' Token: 0x06004F68 RID: 20328 RVA: 0x0020F3FD File Offset: 0x0020D5FD
		Public Function Round2(value As Double, decimals As Integer) As Double
			Return OO_00oOO.O_Oo000.o.(New Decimal(value), decimals)
		End Function

		' Token: 0x06004F69 RID: 20329 RVA: 0x0020F40B File Offset: 0x0020D60B
		Private Function <<EMPTY_NAME>>(A_0 As Decimal, A_1 As Integer) As Double
			Return Convert.ToDouble(Math.Round(A_0, A_1, MidpointRounding.AwayFromZero))
		End Function

		' Token: 0x06004F6A RID: 20330 RVA: 0x0020F41A File Offset: 0x0020D61A
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ActiveFoxtable()
			o_o_O0OO_0__.O0_O_o.o_.()
		End Sub

		' Token: 0x06004F6B RID: 20331 RVA: 0x0020F424 File Offset: 0x0020D624
		Public Function HardDiskId() As String
			Dim stringBuilder As StringBuilder = New StringBuilder(0, 500)
			Dim result As String
			Try
				If OO_00oOO.GetHardDiskId(stringBuilder, 0) Then
					result = stringBuilder.ToString().Trim()
				ElseIf OO_00oOO.GetHardDiskId(stringBuilder, 1) Then
					result = stringBuilder.ToString().Trim()
				ElseIf OO_00oOO.GetHardDiskId(stringBuilder, 2) Then
					result = stringBuilder.ToString().Trim()
				ElseIf OO_00oOO.GetHardDiskId(stringBuilder, 3) Then
					result = stringBuilder.ToString().Trim()
				Else
					result = "-1"
				End If
			Catch ex As Exception
				Throw ex
			End Try
			Return result
		End Function

		' Token: 0x06004F6C RID: 20332 RVA: 0x0020F4BC File Offset: 0x0020D6BC
		Public Function IssueName() As String
			Return "运行环境"
		End Function

		' Token: 0x06004F6D RID: 20333 RVA: 0x0020F4D0 File Offset: 0x0020D6D0
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub ExportStructure()
		End Sub

		' Token: 0x06004F6E RID: 20334 RVA: 0x0020F4D2 File Offset: 0x0020D6D2
		Friend Sub <<EMPTY_NAME>>(Optional A_0 As OO_00oOO.OoOO = OO_00oOO.OoOO.O_Oo_0.0., Optional A_1 As String = "")
		End Sub

		' Token: 0x06004F6F RID: 20335 RVA: 0x0020F4D4 File Offset: 0x0020D6D4
		Private Sub <<EMPTY_NAME>>(A_0 As StringBuilder, A_1 As DataRow, A_2 As DataTable, A_3 As String)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = vbCrLf & vbCrLf
				IL_0F:
				num2 = 3
				Dim text2 As String = vbCrLf
				IL_18:
				num2 = 4
				Dim text3 As String = ""
				IL_21:
				num2 = 5
				Dim a_ As String = ""
				IL_2A:
				num2 = 6
				If A_1.IsNull("Code") Then
					GoTo IL_BC
				End If
				IL_3C:
				num2 = 7
				text3 = Conversions.ToString(A_1("Code"))
				IL_50:
				num2 = 8
				a_ = ooO0__OO.O_Oo00oO.Ooo.()
				IL_59:
				num2 = 9
				If Not text3.StartsWith("{") OrElse Not text3.EndsWith("}") Then
					GoTo IL_A9
				End If
				IL_78:
				num2 = 10
				text3 = text3.TrimStart(New Char() { "{"c }).TrimEnd(New Char() { "}"c })
				IL_9F:
				num2 = 11
				a_ = Oo00.ooO.ooo.()
				IL_A9:
				num2 = 12
				text3 = O00.oO_.0o_oo_0O_.(text3, ooO0__OO.O_Oo00oO.Ooo.(), a_)
				IL_BC:
				num2 = 13
				If Operators.CompareString(text3, "", True) = 0 Then
					GoTo IL_2E5
				End If
				IL_D1:
				num2 = 15
				Dim array As String() = text3.Split(New Char() { vbVerticalTab })
				IL_E8:
				num2 = 16
				Dim num3 As Integer = array.Length - 2
				For i As Integer = 0 To num3 Step 2
					IL_F8:
					num2 = 17
					If Operators.CompareString(array(i + 1).Trim(New Char() { vbLf, vbCr, " "c }), "", True) <> 0 Then
						IL_125:
						num2 = 19
						Dim dataRow As DataRow = A_2.NewRow()
						IL_130:
						num2 = 20
						dataRow("Name") = array(i)
						IL_144:
						num2 = 21
						dataRow("Code") = array(i + 1)
						IL_15A:
						num2 = 22
						A_2.Rows.Add(dataRow)
					End If
					IL_16A:
					num2 = 23
				Next
				IL_17C:
				num2 = 24
				If A_2.Rows.Count <= 0 Then
					GoTo IL_238
				End If
				IL_190:
				num2 = 25
				If Conversions.ToInteger(A_1("type")) = 229 OrElse Conversions.ToInteger(A_1("type")) = 233 Then
					GoTo IL_238
				End If
				IL_1C4:
				num2 = 27
				Dim str As String = String.Concat(New String() { "控件名称[", A_1("Name").ToString(), "], 控件类型[", CType(Conversions.ToInteger(A_1("type")), ControlTypeEnum).ToString(), "]" })
				IL_221:
				num2 = 28
				A_0.Append("## " + str + text)
				IL_238:
				num2 = 29
				For Each dataRow2 As DataRow In A_2.[Select]("", "Name")
					IL_259:
					num2 = 30
					A_0.Append("#### [" + dataRow2("Name").ToString() + "]事件:" + text)
					IL_284:
					num2 = 31
					A_0.Append("```vbnet " + text2 + dataRow2("Code").ToString() + text2)
					IL_2AD:
					num2 = 32
					A_0.Append("```" + text2)
					IL_2C3:
					num2 = 33
				Next
				IL_2D7:
				num2 = 34
				A_2.Rows.Clear()
				IL_2E5:
				num2 = 35
				Dim childRows As DataRow() = A_1.GetChildRows("Component", DataRowVersion.Current)
				IL_2FA:
				num2 = 36
				For Each a_2 As DataRow In childRows
					IL_30D:
					num2 = 37
					OO_00oOO.oo0oOO.o.(A_0, a_2, A_2, A_3)
					IL_31A:
					num2 = 38
				Next
				IL_32B:
				GoTo IL_419
				IL_330:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_3DA:
				GoTo IL_40E
				IL_3DC:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3EC:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3DC
			End Try
			IL_40E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_419:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x170011D9 RID: 4569
		' (get) Token: 0x06004F70 RID: 20336 RVA: 0x0020F920 File Offset: 0x0020DB20
		<oO0oooo("2051")>
		Public ReadOnly Property Registry As RegistryProxy
			Get
				Return c.OOOOO.o.().Registry
			End Get
		End Property

		' Token: 0x06004F71 RID: 20337 RVA: 0x0020F92C File Offset: 0x0020DB2C
		<oO0oooo("2435")>
		Public Function InputPassword(ByRef passWord As String, Text As String, Description As String) As Boolean
			Dim o_u30000_u As o\u30000\u3002 = New o\u30000\u3002()
			Dim c1TextBox As C1TextBox = New C1TextBox()
			c1TextBox.Width = 399
			c1TextBox.Location = New Point(12, 77)
			c1TextBox.PasswordChar = "*"c
			o_u30000_u.Controls.Add(c1TextBox)
			o_u30000_u.Text = Text
			o_u30000_u.oo0OO.0O0_0.().Text = Description
			c1TextBox.Value = passWord
			c1TextBox.[Select]()
			Main.OO_O.o..OOoo___.0.(o_u30000_u.Controls, "(default)")
			Dim result As Boolean
			If o_u30000_u.ShowDialog() = DialogResult.OK Then
				If c1TextBox.Value Is DBNull.Value Then
					passWord = Nothing
				Else
					passWord = c1TextBox.Text
				End If
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls)
				result = True
			Else
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls)
				result = False
			End If
			Return result
		End Function

		' Token: 0x06004F72 RID: 20338 RVA: 0x0020F9F3 File Offset: 0x0020DBF3
		<oO0oooo("2063")>
		Public Function InputValue(ByRef Value As Object, Text As String, Description As String) As Boolean
			Return OO_00oOO.OOOoo_._o.(Value, Text, Description, False, "", False)
		End Function

		' Token: 0x06004F73 RID: 20339 RVA: 0x0020FA04 File Offset: 0x0020DC04
		<oO0oooo("2063")>
		Public Function InputValue(ByRef Value As Object, Text As String, Description As String, MultiLine As Boolean) As Boolean
			Return OO_00oOO.OOOoo_._o.(Value, Text, Description, MultiLine, "", False)
		End Function

		' Token: 0x06004F74 RID: 20340 RVA: 0x0020FA15 File Offset: 0x0020DC15
		<oO0oooo("2063")>
		Public Function InputValue(ByRef Value As Object, Text As String, Description As String, Items As String) As Boolean
			Return OO_00oOO.OOOoo_._o.(Value, Text, Description, False, Items, False)
		End Function

		' Token: 0x06004F75 RID: 20341 RVA: 0x0020FA22 File Offset: 0x0020DC22
		<oO0oooo("2063")>
		Public Function InputValue(ByRef Value As Object, Text As String, Description As String, Items As String, MultiSelect As Boolean) As Boolean
			Return OO_00oOO.OOOoo_._o.(Value, Text, Description, False, Items, MultiSelect)
		End Function

		' Token: 0x06004F76 RID: 20342 RVA: 0x0020FA30 File Offset: 0x0020DC30
		<EditorBrowsable(EditorBrowsableState.Never)>
		<oO0oooo("2063")>
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Object, A_1 As String, A_2 As String, A_3 As Boolean, A_4 As String, A_5 As Boolean) As Boolean
			Dim o_u30000_u As o\u30000\u3002 = New o\u30000\u3002()
			Dim c1TextBox As C1TextBox
			If A_0 Is Nothing Then
				c1TextBox = New C1TextBox()
			Else
				Dim name As String = A_0.[GetType]().Name
				If Operators.CompareString(name, "DateTime", True) = 0 Then
					c1TextBox = New O0OO_oo0o()
				ElseIf Operators.CompareString(name, "Byte", True) = 0 OrElse Operators.CompareString(name, "Int16", True) = 0 OrElse Operators.CompareString(name, "Int32", True) = 0 OrElse Operators.CompareString(name, "Int64", True) = 0 OrElse Operators.CompareString(name, "Single", True) = 0 OrElse Operators.CompareString(name, "Double", True) = 0 OrElse Operators.CompareString(name, "Decimal", True) = 0 Then
					c1TextBox = New C1NumericEdit()
				ElseIf Operators.CompareString(A_4, "", True) > 0 Then
					If Not A_5 Then
						Dim c1ComboBox As C1ComboBox = New C1ComboBox()
						For Each text As String In A_4.Split(New Char() { "|"c })
							c1ComboBox.Items.Add(text)
						Next
						c1TextBox = c1ComboBox
					Else
						Dim o0oo000oO0oo_ As O0oo000oO0oo_ = New O0oo000oO0oo_()
						o0oo000oO0oo_.Height += 3
						For Each item As String In A_4.Split(New Char() { "|"c })
							o0oo000oO0oo_.o_0Oo.o_.().Add(item)
						Next
						c1TextBox = o0oo000oO0oo_
					End If
				Else
					c1TextBox = New C1TextBox()
				End If
			End If
			If A_3 AndAlso Operators.CompareString(c1TextBox.[GetType]().Name, "C1TextBox", True) = 0 Then
				c1TextBox.Multiline = True
				o_u30000_u.Height = o_u30000_u.Height + 60 - c1TextBox.Height
				c1TextBox.Height = 60
				o_u30000_u.AcceptButton = Nothing
			End If
			c1TextBox.Width = 399
			c1TextBox.Location = New Point(12, 77)
			o_u30000_u.Controls.Add(c1TextBox)
			Main.OO_O.o..OOoo___.0.(o_u30000_u.Controls, "(default)")
			o_u30000_u.Text = A_1
			o_u30000_u.oo0OO.0O0_0.().Text = A_2
			c1TextBox.Value = RuntimeHelpers.GetObjectValue(A_0)
			c1TextBox.[Select]()
			Dim result As Boolean
			If o_u30000_u.ShowDialog() = DialogResult.OK Then
				If c1TextBox.Value Is DBNull.Value Then
					A_0 = Nothing
				Else
					A_0 = RuntimeHelpers.GetObjectValue(c1TextBox.Value)
				End If
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls)
				result = True
			Else
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls)
				result = False
			End If
			Return result
		End Function

		' Token: 0x06004F77 RID: 20343 RVA: 0x0020FC9C File Offset: 0x0020DE9C
		Private Function <<EMPTY_NAME>>(ByRef A_0 As Object, A_1 As String, A_2 As String, A_3 As Boolean, A_4 As String) As Boolean
			Return 100 - DateTime.Now.Second > 60
		End Function

		' Token: 0x06004F78 RID: 20344 RVA: 0x0020FCC0 File Offset: 0x0020DEC0
		<oO0oooo("2126")>
		Public Function FileIsOpened(FName As String) As Boolean
			If OO_00oOO.FileSys.FileExists(FName) Then
				Try
					Dim fileStream As FileStream = New FileStream(FName, FileMode.Open, FileAccess.Read, FileShare.None)
					fileStream.Close()
					fileStream.Dispose()
				Catch ex As Exception
					Return True
				End Try
			End If
			Return False
		End Function

		' Token: 0x170011DA RID: 4570
		' (get) Token: 0x06004F79 RID: 20345 RVA: 0x0020FD14 File Offset: 0x0020DF14
		Public ReadOnly Property BaseMainForm As Form
			Get
				Return Main.OO_O.o.
			End Get
		End Property

		' Token: 0x170011DB RID: 4571
		' (get) Token: 0x06004F7A RID: 20346 RVA: 0x0020FD1B File Offset: 0x0020DF1B
		' (set) Token: 0x06004F7B RID: 20347 RVA: 0x0020FD2C File Offset: 0x0020DF2C
		<oO0oooo("2306")>
		Public Property TableCaptionVisible As Boolean
			Get
				Return Main.OO_O.o..OO_O_0Oo.___o.().ShowTabs
			End Get
			Set(value As Boolean)
				Main.OO_O.o..OO_O_0Oo.___o.().ShowTabs = value
			End Set
		End Property

		' Token: 0x170011DC RID: 4572
		' (get) Token: 0x06004F7C RID: 20348 RVA: 0x0020FD3E File Offset: 0x0020DF3E
		' (set) Token: 0x06004F7D RID: 20349 RVA: 0x0020FD4F File Offset: 0x0020DF4F
		<oO0oooo("2765")>
		Public Property ShowCloseButton As Boolean
			Get
				Return Main.OO_O.o..OO_O_0Oo.___o.().CanCloseTabs
			End Get
			Set(value As Boolean)
				Main.OO_O.o..OO_O_0Oo.___o.().CanCloseTabs = value
			End Set
		End Property

		' Token: 0x170011DD RID: 4573
		' (get) Token: 0x06004F7E RID: 20350 RVA: 0x0020FD64 File Offset: 0x0020DF64
		<oO0oooo("0665")>
		Public ReadOnly Property LastInputTickCount As Long
			Get
				Dim o0O_ As ooO.o0O_
				o0O_.oo.00O0__o. = Strings.Len(o0O_)
				Dim result As Long
				If ooO.GetLastInputInfo(o0O_) <> 0 Then
					result = CLng((Environment.TickCount - o0O_.O.0_O0O.))
				End If
				Return result
			End Get
		End Property

		' Token: 0x06004F7F RID: 20351 RVA: 0x0020FD9C File Offset: 0x0020DF9C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub CreateBlankAccessFile()
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.Filter = "Access(*.mdb)|*.MDB"
			If saveFileDialog.ShowDialog() <> DialogResult.Cancel Then
				If c.OOOOO.o.().FileSystem.FileExists(saveFileDialog.FileName) Then
					c.OOOOO.o.().FileSystem.DeleteFile(saveFileDialog.FileName)
				End If
				Dim catalogClass As CatalogClass = New CatalogClass()
				catalogClass.Create(Oo00.o00.0OO.(saveFileDialog.FileName))
				CType(catalogClass.ActiveConnection, Connection).Close()
			End If
		End Sub

		' Token: 0x170011DE RID: 4574
		' (get) Token: 0x06004F80 RID: 20352 RVA: 0x0020FE15 File Offset: 0x0020E015
		<oO0oooo("0609")>
		Public ReadOnly Property Users As UserInfos
			Get
				If OO_00oOO.a Is Nothing Then
					OO_00oOO.a = New UserInfos()
				End If
				Return OO_00oOO.a
			End Get
		End Property

		' Token: 0x170011DF RID: 4575
		' (get) Token: 0x06004F81 RID: 20353 RVA: 0x0020FE2D File Offset: 0x0020E02D
		Public ReadOnly Property FoxSMS As FoxSMSControl
			Get
				If OO_00oOO.OO._ooO. Is Nothing Then
					OO_00oOO.OO._ooO. = New FoxSMSControl()
				End If
				Return OO_00oOO.OO._ooO.
			End Get
		End Property

		' Token: 0x06004F82 RID: 20354 RVA: 0x0020FE48 File Offset: 0x0020E048
		<oO0oooo("1272")>
		Public Function CompactAccessFile(FileName As String, Optional PassWord As String = "", Optional backup As Boolean = True) As Boolean
			Dim jetEngine As JetEngine = New JetEngineClass()
			Dim tempFileName As String = c.OOOOO.o.().FileSystem.GetTempFileName()
			Dim extension As String = Path.GetExtension(FileName)
			If backup Then
				c.OOOOO.o.().FileSystem.CopyFile(FileName, FileName + ".bak", True)
			End If
			Dim text As String
			If Operators.CompareString(extension, ".accdb", True) = 0 Then
				text = "Microsoft.ACE.OLEDB.12.0"
			Else
				text = "Microsoft.Jet.OLEDB.4.0"
			End If
			Dim text2 As String = String.Concat(New String() { "Provider=", text, ";Data Source=", FileName, ";Jet OLEDB:Database Password=", PassWord })
			Dim oleDbConnectionStringBuilder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
			oleDbConnectionStringBuilder.Provider = text
			oleDbConnectionStringBuilder.DataSource = tempFileName
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Database Password", PassWord)
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Engine Type", 5)
			Dim connectionString As String = oleDbConnectionStringBuilder.ConnectionString
			Try
				c.OOOOO.o.().FileSystem.DeleteFile(tempFileName)
				jetEngine.CompactDatabase(text2, connectionString)
				If c.OOOOO.o.().FileSystem.FileExists(FileName) Then
					c.OOOOO.o.().FileSystem.DeleteFile(FileName)
				End If
				c.OOOOO.o.().FileSystem.MoveFile(tempFileName, FileName)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Return False
			Finally
				If c.OOOOO.o.().FileSystem.FileExists(tempFileName) Then
					c.OOOOO.o.().FileSystem.DeleteFile(tempFileName)
				End If
			End Try
			Return True
		End Function

		' Token: 0x06004F83 RID: 20355 RVA: 0x0020FFC4 File Offset: 0x0020E1C4
		<oO0oooo("0686")>
		Public Function CompactToAccess(FileName As String, Password As String) As Boolean
			Dim jetEngine As JetEngine = New JetEngineClass()
			Dim oleDbConnectionStringBuilder As OleDbConnectionStringBuilder = New OleDbConnectionStringBuilder()
			Dim tempFileName As String = c.OOOOO.o.().FileSystem.GetTempFileName()
			If Not c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)) Then
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName))
			End If
			Dim text As String = O_O0OO.OoO.0OO__0ooo.().ConnectionString
			oleDbConnectionStringBuilder.DataSource = tempFileName
			oleDbConnectionStringBuilder.Provider = "Microsoft.Jet.OLEDB.4.0"
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Engine Type", 5)
			If Operators.CompareString(Password, "", True) > 0 Then
				oleDbConnectionStringBuilder.Add("Jet OLEDB:Database Password", Password)
			End If
			Dim connectionString As String = oleDbConnectionStringBuilder.ConnectionString
			Try
				If c.OOOOO.o.().FileSystem.FileExists(tempFileName) Then
					c.OOOOO.o.().FileSystem.DeleteFile(tempFileName)
				End If
				jetEngine.CompactDatabase(text, connectionString)
				Dim connection As Connection = New ConnectionClass()
				Dim catalog As Catalog = New CatalogClass()
				connection.ConnectionString = oleDbConnectionStringBuilder.ConnectionString
				connection.Open("", "", "", -1)
				catalog.ActiveConnection = connection
				For i As Integer = catalog.Tables.Count - 1 To 0 Step -1
					If catalog.Tables(i).Name.StartsWith("~TMPCLP") AndAlso o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(catalog.Tables(i).Name) Then
						catalog.Tables.Delete(catalog.Tables(i).Name)
					End If
				Next
				Try
					For Each obj As Object In catalog.Tables
						Dim table As Table = CType(obj, Table)
						If table.Name.StartsWith("~TMPCLP") Then
							table.Name = table.Name.Substring(7)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				connection.Close()
				text = connectionString
				oleDbConnectionStringBuilder.DataSource = FileName
				connectionString = oleDbConnectionStringBuilder.ConnectionString
				If c.OOOOO.o.().FileSystem.FileExists(FileName) Then
					c.OOOOO.o.().FileSystem.DeleteFile(FileName)
				End If
				jetEngine.CompactDatabase(text, connectionString)
				c.OOOOO.o.().FileSystem.DeleteFile(tempFileName)
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				Return False
			End Try
			Return True
		End Function

		' Token: 0x06004F84 RID: 20356 RVA: 0x00210288 File Offset: 0x0020E488
		<oO0oooo("2709")>
		Public Function TryConnectHost(address As String) As Boolean
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				If OO_00oOO.InternetGetConnectedState(num, 0) Then
					If Dns.GetHostAddresses(address)(0).ToString().Length <= 6 Then
						result = False
					Else
						result = True
					End If
				Else
					result = False
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		' Token: 0x06004F85 RID: 20357 RVA: 0x002102E4 File Offset: 0x0020E4E4
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function FindAppWindow(Caption As String) As Integer
			OO_00oOO.O_Oo_0.0. = IntPtr.Zero
			OO_00oOO.O_Oo_0.0. = Caption.ToLower()
			OO_00oOO.EnumWindows(AddressOf OO_00oOO.Oo.0Oo00OO0., 0)
			Return CInt(OO_00oOO.O_Oo_0.0.)
		End Function

		' Token: 0x06004F86 RID: 20358 RVA: 0x00210318 File Offset: 0x0020E518
		Friend Function <<EMPTY_NAME>>(A_0 As IntPtr, A_1 As Integer) As Boolean
			Dim stringBuilder As StringBuilder = New StringBuilder(512)
			OoO0o.GetWindowText(A_0, stringBuilder, stringBuilder.Capacity)
			Dim result As Boolean
			If LikeOperator.LikeString(stringBuilder.ToString().ToLower(), "*" + OO_00oOO.O_Oo_0.0. + "*", CompareMethod.Text) Then
				OO_00oOO.O_Oo_0.0. = A_0
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004F87 RID: 20359 RVA: 0x00210372 File Offset: 0x0020E572
		<oO0oooo("2713")>
		Public Function ShowAppWindow(Caption As String, State As Integer) As Boolean
			OO_00oOO.O_Oo_0.0. = IntPtr.Zero
			OO_00oOO.O_Oo_0.0. = Caption.ToLower()
			OO_00oOO.O0o_00Oo0.o_o. = State
			OO_00oOO.EnumWindows(AddressOf OO_00oOO.OOOoo_._o., 0)
			Return OO_00oOO.O_Oo_0.0. <> IntPtr.Zero
		End Function

		' Token: 0x06004F88 RID: 20360 RVA: 0x002103B4 File Offset: 0x0020E5B4
		Friend Function <<EMPTY_NAME>>(A_0 As IntPtr, A_1 As Integer) As Boolean
			Dim stringBuilder As StringBuilder = New StringBuilder(512)
			OoO0o.GetWindowText(A_0, stringBuilder, stringBuilder.Capacity)
			Dim result As Boolean
			If LikeOperator.LikeString(stringBuilder.ToString().ToLower(), "*" + OO_00oOO.O_Oo_0.0. + "*", CompareMethod.Text) Then
				Select Case OO_00oOO.O0o_00Oo0.o_o.
					Case 1
						OoO0o.ShowWindow(A_0, 1)
					Case 2
						OoO0o.ShowWindow(A_0, 3)
					Case 3
						OoO0o.ShowWindow(A_0, 6)
					Case 4
						OoO0o.ShowWindow(A_0, 0)
					Case 5
						OO_00oOO.SendMessage(A_0, 16, 0, 0)
				End Select
				If OO_00oOO.O0o_00Oo0.o_o. <> 5 Then
					ooO.SetForegroundWindow(A_0)
					OO_00oOO.O_Oo_0.0. = A_0
				End If
				result = False
			Else
				result = True
			End If
			Return result
		End Function

		' Token: 0x06004F89 RID: 20361 RVA: 0x00210474 File Offset: 0x0020E674
		Public Sub LockBaseMainForm()
			ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle)
		End Sub

		' Token: 0x06004F8A RID: 20362 RVA: 0x00210486 File Offset: 0x0020E686
		Public Sub UnlockBaseMainForm()
			ShareLibriay.LockWindowUpdate(IntPtr.Zero)
		End Sub

		' Token: 0x170011E0 RID: 4576
		' (get) Token: 0x06004F8B RID: 20363 RVA: 0x00210493 File Offset: 0x0020E693
		' (set) Token: 0x06004F8C RID: 20364 RVA: 0x0021049A File Offset: 0x0020E69A
		<oO0oooo("1466")>
		Public Property SystemMenu As Boolean
			Get
				Return OO_00oOO.O0_.oO0__O.
			End Get
			Friend Set(value As Boolean)
				OO_00oOO.O0_.oO0__O. = value
			End Set
		End Property

		' Token: 0x06004F8D RID: 20365 RVA: 0x002104A4 File Offset: 0x0020E6A4
		<oO0oooo("2919")>
		Public Function CExp(expr As String, ParamArray values As String()) As String
			Dim num As Integer = values.Length - 1
			For i As Integer = 0 To num
				expr = expr.Replace("{" + Conversions.ToString(i) + "}", values(i))
			Next
			Return expr
		End Function

		' Token: 0x170011E1 RID: 4577
		' (get) Token: 0x06004F8E RID: 20366 RVA: 0x002104E4 File Offset: 0x0020E6E4
		' (set) Token: 0x06004F8F RID: 20367 RVA: 0x00210503 File Offset: 0x0020E703
		<oO0oooo("2218")>
		Public Property SystemReady As Boolean
			Get
				Return Not O_O0OO.o0OoO00OO.00O. AndAlso OO_00oOO.O0o_00Oo0.o_o.
			End Get
			Set(value As Boolean)
				OO_00oOO.O0o_00Oo0.o_o. = value
			End Set
		End Property

		' Token: 0x170011E2 RID: 4578
		' (get) Token: 0x06004F90 RID: 20368 RVA: 0x0021050B File Offset: 0x0020E70B
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property IMServers As IMServerCollections
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011E3 RID: 4579
		' (get) Token: 0x06004F91 RID: 20369 RVA: 0x00210512 File Offset: 0x0020E712
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property IMClients As IMClientCollections
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011E4 RID: 4580
		' (get) Token: 0x06004F92 RID: 20370 RVA: 0x00210519 File Offset: 0x0020E719
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property QQServers As IMServerCollections
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011E5 RID: 4581
		' (get) Token: 0x06004F93 RID: 20371 RVA: 0x00210520 File Offset: 0x0020E720
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public ReadOnly Property QQClients As IMClientCollections
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
		End Property

		' Token: 0x170011E6 RID: 4582
		' (get) Token: 0x06004F94 RID: 20372 RVA: 0x00210527 File Offset: 0x0020E727
		Public ReadOnly Property UDPClients As oO_OO_o0_
			Get
				Return OO_00oOO.O0o_00Oo0.o_o.
			End Get
		End Property

		' Token: 0x170011E7 RID: 4583
		' (get) Token: 0x06004F95 RID: 20373 RVA: 0x00210530 File Offset: 0x0020E730
		<oO0oooo("A2979")>
		Public ReadOnly Property QQServer As IMServer
			Get
				Dim result As IMServer
				If OO_00oOO.IMServers.Count = 0 Then
					Dim text As String = "QQServer"
					OO_00oOO.IMServers.Add(text)
					result = OO_00oOO.IMServers(text)
				Else
					Try
						Dim enumerator As Dictionary(Of String, IMServer).KeyCollection.Enumerator = OO_00oOO.IMServers.Keys.GetEnumerator()
						If enumerator.MoveNext() Then
							Dim key As String = enumerator.Current
							Return OO_00oOO.IMServers(key)
						End If
					Finally
						Dim enumerator As Dictionary(Of String, IMServer).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x170011E8 RID: 4584
		' (get) Token: 0x06004F96 RID: 20374 RVA: 0x002105C0 File Offset: 0x0020E7C0
		<oO0oooo("A2987")>
		Public ReadOnly Property QQClient As IMClient
			Get
				Dim result As IMClient
				If OO_00oOO.IMClients.Count = 0 Then
					Dim text As String = OoOo0O.OO_o.0o_O.(5)
					OO_00oOO.IMClients.Add(text)
					result = OO_00oOO.IMClients(text)
				Else
					Try
						Dim enumerator As Dictionary(Of String, IMClient).KeyCollection.Enumerator = OO_00oOO.IMClients.Keys.GetEnumerator()
						If enumerator.MoveNext() Then
							Dim key As String = enumerator.Current
							Return OO_00oOO.IMClients(key)
						End If
					Finally
						Dim enumerator As Dictionary(Of String, IMClient).KeyCollection.Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					result = Nothing
				End If
				Return result
			End Get
		End Property

		' Token: 0x06004F97 RID: 20375 RVA: 0x00210650 File Offset: 0x0020E850
		<oO0oooo("1270")>
		Public Function GetPinYin(hzStr As String, Optional mode As Integer = 0) As String
			Dim text As String = ""
			For Each c As Char In hzStr
				If ChineseChar.IsValidChar(c) Then
					Dim chineseChar As ChineseChar = New ChineseChar(c)
					Dim index As Integer = 0
					If c <= "家"c Then
						If c = "地"c OrElse c = "塔"c OrElse c = "家"c Then
							GoTo IL_69
						End If
					ElseIf c <> "广"c Then
						If c = "洋"c Then
							GoTo IL_69
						End If
						If c = "选"c Then
							index = 3
						End If
					Else
						index = 2
					End If
					IL_76:
					If mode = 0 Then
						text = text + " " + chineseChar.Pinyins(index).Substring(0, chineseChar.Pinyins(index).Length - 1)
						GoTo IL_FB
					End If
					If mode = 1 Then
						text += chineseChar.Pinyins(index).Substring(0, 1)
						GoTo IL_FB
					End If
					text = text + " " + chineseChar.Pinyins(index)
					GoTo IL_FB
					IL_69:
					index = 1
					GoTo IL_76
				End If
				text += Conversions.ToString(c)
				IL_FB:
			Next
			Return text.Trim().ToLower()
		End Function

		' Token: 0x170011E9 RID: 4585
		' (get) Token: 0x06004F98 RID: 20376 RVA: 0x00210773 File Offset: 0x0020E973
		' (set) Token: 0x06004F99 RID: 20377 RVA: 0x0021077A File Offset: 0x0020E97A
		<oO0oooo("A0143")>
		Public Property HttpServer As HttpListenter
			Get
				Return OO_00oOO.O_0.oooO__O.
			End Get
			Friend Set(value As HttpListenter)
				OO_00oOO.O_0.oooO__O. = value
			End Set
		End Property

		' Token: 0x06004F9A RID: 20378 RVA: 0x00210782 File Offset: 0x0020E982
		<oO0oooo("3043")>
		Public Sub PopMessage(Message As String, Optional Caption As String = "提示", Optional Icon As PopiconEnum = 0, Optional Duration As Integer = -1)
			If O_O0OO.o.0__0_O_. Is Nothing Then
				O_O0OO.o.0__0_O_. = New O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002()
				O_O0OO.o.0__0_O_..Owner = OO_00oOO.BaseMainForm
			End If
			If Icon < 0 OrElse Icon > 4 Then
				Icon = 0
			End If
			O_O0OO.o.0__0_O_..o.oOoO__o.(Message, Caption, Icon, Duration)
		End Sub

		' Token: 0x06004F9B RID: 20379 RVA: 0x002107BD File Offset: 0x0020E9BD
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function ParseJSON(json As String) As Object
			Return Nothing
		End Function

		' Token: 0x06004F9C RID: 20380 RVA: 0x002107C0 File Offset: 0x0020E9C0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return HttpUtility.UrlEncode(A_0)
		End Function

		' Token: 0x06004F9D RID: 20381 RVA: 0x002107C8 File Offset: 0x0020E9C8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return HttpUtility.UrlDecode(A_0)
		End Function

		' Token: 0x06004F9E RID: 20382 RVA: 0x002107D0 File Offset: 0x0020E9D0
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return HttpUtility.HtmlEncode(A_0)
		End Function

		' Token: 0x06004F9F RID: 20383 RVA: 0x002107D8 File Offset: 0x0020E9D8
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Return HttpUtility.HtmlDecode(A_0)
		End Function

		' Token: 0x170011EA RID: 4586
		' (get) Token: 0x06004FA0 RID: 20384 RVA: 0x002107E0 File Offset: 0x0020E9E0
		Public ReadOnly Property DongleID As String
			Get
				Dim str As String = Nothing
				Dim str2 As String = Nothing
				o0OO__.oOO.o_.(str, str2)
				Return Strings.Format(Conversions.ToLong(str + str2), "0000-0000-0000-0000")
			End Get
		End Property

		' Token: 0x170011EB RID: 4587
		' (get) Token: 0x06004FA1 RID: 20385 RVA: 0x00210815 File Offset: 0x0020EA15
		Public ReadOnly Property ProjectID As String
			Get
				Return O_O0OO.O_O._Oo.()
			End Get
		End Property

		' Token: 0x06004FA2 RID: 20386 RVA: 0x0021081C File Offset: 0x0020EA1C
		Public Sub Sleep(msec As Integer)
			Thread.Sleep(msec)
		End Sub

		' Token: 0x170011EC RID: 4588
		' (get) Token: 0x06004FA3 RID: 20387 RVA: 0x00210824 File Offset: 0x0020EA24
		Friend ReadOnly Property HttpUpdatePath As String
			Get
				Return "http://www.foxtable.com/update/newversion.txt"
			End Get
		End Property

		' Token: 0x06004FA4 RID: 20388 RVA: 0x0021082C File Offset: 0x0020EA2C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function OSVersion() As Integer
			If OO_00oOO.O.OoO__0O_oO. Is Nothing Then
				Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.O.OoO__0O_oO., New StaticLocalInitFlag(), Nothing)
			End If
			Dim flag As Boolean = False
			Try
				Monitor.Enter(OO_00oOO.O.OoO__0O_oO., flag)
				If OO_00oOO.O.OoO__0O_oO..State = 0S Then
					OO_00oOO.O.OoO__0O_oO..State = 2S
					OO_00oOO.OO_.000_0_O_O. = -1
				ElseIf OO_00oOO.O.OoO__0O_oO..State = 2S Then
					Throw New IncompleteInitialization()
				End If
			Finally
				OO_00oOO.O.OoO__0O_oO..State = 1S
				If flag Then
					Monitor.[Exit](OO_00oOO.O.OoO__0O_oO.)
				End If
			End Try
			If OO_00oOO.OO_.000_0_O_O. = -1 Then
				OO_00oOO.OO_.000_0_O_O. = Environment.OSVersion.Version.Major
			End If
			Return OO_00oOO.OO_.000_0_O_O.
		End Function

		' Token: 0x170011ED RID: 4589
		' (get) Token: 0x06004FA5 RID: 20389 RVA: 0x002108E0 File Offset: 0x0020EAE0
		' (set) Token: 0x06004FA6 RID: 20390 RVA: 0x002108EC File Offset: 0x0020EAEC
		<oO0oooo("3305")>
		Public Property ControlTheme As String
			Get
				Return Main.OO_O.o..O.OOO0_OOo.()
			End Get
			Set(value As String)
				Main.OO_O.o..O0.0000oO.(value)
			End Set
		End Property

		' Token: 0x170011EE RID: 4590
		' (get) Token: 0x06004FA7 RID: 20391 RVA: 0x002108F9 File Offset: 0x0020EAF9
		' (set) Token: 0x06004FA8 RID: 20392 RVA: 0x00210905 File Offset: 0x0020EB05
		<oO0oooo("3305")>
		Public Property RibbonTheme As String
			Get
				Return Main.OO_O.o..o00o_OO_o_._o.()
			End Get
			Set(value As String)
				Main.OO_O.o..OoO_oo00o0.Oo.(value)
			End Set
		End Property

		' Token: 0x170011EF RID: 4591
		' (get) Token: 0x06004FA9 RID: 20393 RVA: 0x00210912 File Offset: 0x0020EB12
		' (set) Token: 0x06004FAA RID: 20394 RVA: 0x00210920 File Offset: 0x0020EB20
		<oO0oooo("3305")>
		Public Property GridTheme As String
			Get
				Return O_O0OO.O0_00o.o0__o..GridTheme
			End Get
			Set(value As String)
				O_O0OO.O0_00o.o0__o..GridTheme = value
				Try
					For Each dataTable As DataTable In OO_00oOO.DataTables
						dataTable.oOoOO0_o.O0_0.()
					Next
				Finally
					Dim enumerator As IEnumerator(Of DataTable)
					If enumerator IsNot Nothing Then
						enumerator.Dispose()
					End If
				End Try
			End Set
		End Property

		' Token: 0x170011F0 RID: 4592
		' (get) Token: 0x06004FAB RID: 20395 RVA: 0x00210974 File Offset: 0x0020EB74
		Public ReadOnly Property Themes As List(Of String)
			Get
				If OO_00oOO.oo0._0oO_O_0. Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(OO_00oOO.oo0._0oO_O_0., New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(OO_00oOO.oo0._0oO_O_0., flag)
					If OO_00oOO.oo0._0oO_O_0..State = 0S Then
						OO_00oOO.oo0._0oO_O_0..State = 2S
						OO_00oOO.o_oo.0o. = Nothing
					ElseIf OO_00oOO.oo0._0oO_O_0..State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					OO_00oOO.oo0._0oO_O_0..State = 1S
					If flag Then
						Monitor.[Exit](OO_00oOO.oo0._0oO_O_0.)
					End If
				End Try
				If OO_00oOO.o_oo.0o. Is Nothing Then
					OO_00oOO.o_oo.0o. = New List(Of String)(C1ThemeController.GetThemes())
					OO_00oOO.o_oo.0o..Remove("Foxtable经典蓝")
					OO_00oOO.o_oo.0o..Remove("Foxtable经典银")
					OO_00oOO.o_oo.0o..Remove("Foxtable经典黑")
					OO_00oOO.o_oo.0o..Add("Foxtable经典蓝")
					OO_00oOO.o_oo.0o..Add("Foxtable经典银")
					OO_00oOO.o_oo.0o..Add("Foxtable经典黑")
				End If
				Return OO_00oOO.o_oo.0o.
			End Get
		End Property

		' Token: 0x06004FAC RID: 20396 RVA: 0x00210A7C File Offset: 0x0020EC7C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function isUserColdeRunning() As Boolean
			Dim stackTrace As StackTrace = New StackTrace(True)
			Dim num As Integer = stackTrace.FrameCount - 1
			For i As Integer = 0 To num
				Dim name As String = stackTrace.GetFrame(i).GetMethod().[Module].Name
				If name.StartsWith("<") AndAlso name.EndsWith(">") Then
					Return True
				End If
			Next
			Return False
		End Function

		' Token: 0x040020F4 RID: 8436
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020F5 RID: 8437
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x040020F6 RID: 8438
		Private <<EMPTY_NAME>> As IntPtr = IntPtr.Zero

		' Token: 0x040020F7 RID: 8439
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x040020F8 RID: 8440
		Private <<EMPTY_NAME>> As List(Of Object) = New List(Of Object)()

		' Token: 0x040020F9 RID: 8441
		Private <<EMPTY_NAME>> As DataTableCollection

		' Token: 0x040020FA RID: 8442
		Private <<EMPTY_NAME>> As TableCollection

		' Token: 0x040020FB RID: 8443
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020FC RID: 8444
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020FD RID: 8445
		Private <<EMPTY_NAME>> As String

		' Token: 0x040020FE RID: 8446
		Friend <<EMPTY_NAME>> As UserInfo

		' Token: 0x040020FF RID: 8447
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04002100 RID: 8448
		Friend <<EMPTY_NAME>> As Table

		' Token: 0x04002101 RID: 8449
		Private <<EMPTY_NAME>> As DataRelationCollection = New DataRelationCollection()

		' Token: 0x04002102 RID: 8450
		Private <<EMPTY_NAME>> As ConnectionCollection = New ConnectionCollection()

		' Token: 0x04002103 RID: 8451
		Private <<EMPTY_NAME>> As UserFunctions = New UserFunctions()

		' Token: 0x04002104 RID: 8452
		Private <<EMPTY_NAME>> As RibbonTabCollection

		' Token: 0x04002105 RID: 8453
		Private <<EMPTY_NAME>> As RibbonTabGroupCollection

		' Token: 0x04002106 RID: 8454
		Private <<EMPTY_NAME>> As ContextMenuCollection

		' Token: 0x04002107 RID: 8455
		Private <<EMPTY_NAME>> As Foxtable.RibbonMenu.StatusBar

		' Token: 0x04002108 RID: 8456
		Private <<EMPTY_NAME>> As VarsCollection = New VarsCollection()

		' Token: 0x04002109 RID: 8457
		Private <<EMPTY_NAME>> As TimerCollection = New TimerCollection()

		' Token: 0x0400210A RID: 8458
		Private <<EMPTY_NAME>> As FormCollection = New FormCollection()

		' Token: 0x0400210B RID: 8459
		Private <<EMPTY_NAME>> As ReportCollection = New ReportCollection()

		' Token: 0x0400210C RID: 8460
		Private <<EMPTY_NAME>> As HardWare = New HardWare()

		' Token: 0x0400210D RID: 8461
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400210E RID: 8462
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x0400210F RID: 8463
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04002110 RID: 8464
		Private <<EMPTY_NAME>> As FileSystemWatcher = New FileSystemWatcher()

		' Token: 0x04002111 RID: 8465
		Private <<EMPTY_NAME>> As MyPortCollections = New MyPortCollections()

		' Token: 0x04002112 RID: 8466
		Friend <<EMPTY_NAME>> As FoxSMSControl

		' Token: 0x04002113 RID: 8467
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO_00oOO.oo_00_O0_0O

		' Token: 0x04002114 RID: 8468
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OO_00oOO.oo0O0__O__oO

		' Token: 0x04002115 RID: 8469
		Private <<EMPTY_NAME>> As IMServerCollections = New IMServerCollections()

		' Token: 0x04002116 RID: 8470
		Private <<EMPTY_NAME>> As IMClientCollections = New IMClientCollections()

		' Token: 0x04002117 RID: 8471
		Private <<EMPTY_NAME>> As oO_OO_o0_ = New oO_OO_o0_()

		' Token: 0x04002118 RID: 8472
		Private <<EMPTY_NAME>> As IMServer

		' Token: 0x04002119 RID: 8473
		Private <<EMPTY_NAME>> As IMClient

		' Token: 0x0400211A RID: 8474
		Private <<EMPTY_NAME>> As HttpListenter = New HttpListenter()

		' Token: 0x0400211B RID: 8475
		Private <<EMPTY_NAME>> As MRPTableCols = New MRPTableCols()

		' Token: 0x0400211C RID: 8476
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400211D RID: 8477
		Private a As ScriptControl

		' Token: 0x0400211E RID: 8478
		Private a As StaticLocalInitFlag

		' Token: 0x0400211F RID: 8479
		Private a As Dictionary(Of String, String)

		' Token: 0x04002120 RID: 8480
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002121 RID: 8481
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x04002122 RID: 8482
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002123 RID: 8483
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x04002124 RID: 8484
		Private <<EMPTY_NAME>> As Process

		' Token: 0x04002125 RID: 8485
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x04002126 RID: 8486
		Private <<EMPTY_NAME>> As String

		' Token: 0x04002127 RID: 8487
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x04002128 RID: 8488
		Private <<EMPTY_NAME>> As Process

		' Token: 0x04002129 RID: 8489
		Private a As UserInfos

		' Token: 0x0400212A RID: 8490
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0400212B RID: 8491
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x0400212C RID: 8492
		Private <<EMPTY_NAME>> As List(Of String)

		' Token: 0x0400212D RID: 8493
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x020004CF RID: 1231
		' (Invoke) Token: 0x06004FB0 RID: 20400
		Private Delegate Function o_O_0ooO(A_0 As IntPtr, A_1 As Integer) As Boolean

		' Token: 0x020004D0 RID: 1232
		' (Invoke) Token: 0x06004FB4 RID: 20404
		Friend Delegate Sub oo_00_O0_0O()

		' Token: 0x020004D1 RID: 1233
		' (Invoke) Token: 0x06004FB8 RID: 20408
		Friend Delegate Sub oo0O0__O__oO()

		' Token: 0x020004D2 RID: 1234
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Enum OoOO
			' Token: 0x0400212F RID: 8495
			<<EMPTY_NAME>>
			' Token: 0x04002130 RID: 8496
			<<EMPTY_NAME>>
			' Token: 0x04002131 RID: 8497
			<<EMPTY_NAME>>
			' Token: 0x04002132 RID: 8498
			<<EMPTY_NAME>>
			' Token: 0x04002133 RID: 8499
			<<EMPTY_NAME>>
			' Token: 0x04002134 RID: 8500
			<<EMPTY_NAME>>
			' Token: 0x04002135 RID: 8501
			<<EMPTY_NAME>>
			' Token: 0x04002136 RID: 8502
			<<EMPTY_NAME>>
		End Enum
	End Module
End Namespace
