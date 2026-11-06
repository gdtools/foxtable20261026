Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1Ribbon
Imports Foxtable.My
Imports Foxtable.My.Resources
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32

Namespace Foxtable
	' Token: 0x0200043C RID: 1084
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public NotInheritable Module Main
		' Token: 0x06004789 RID: 18313 RVA: 0x001D89A4 File Offset: 0x001D6BA4
		' Note: this type is marked as 'beforefieldinit'.
		Shared Sub New()
			Dim a_ As Integer = 4
			Foxtable.Main.OO_O.o. = 0
			Foxtable.Main.OO_O.o. = New o\u3000\u3002\u3002\u3002\u3002()
			Foxtable.Main.oo0.o0_o. = 85
			Foxtable.Main.O__Ooo_00O.ooO. = 90
			Foxtable.Main.oo0.o0_o. = O00OOOo_O0_O.b("秊펗ꦝ좟ﲣ삥쒧캩풫鮭얱�즷躹請�钿곁鋃꿇迉鿋ꋍꧏ꫑뷓﷕뛗釙韛귝꿟뫡쿣闥ꋧ틩꣫胭苯등菳軵韷駹ꓻ뗽叿企七清䐇伉䀋ℍ猏䬑ℓ焕渗砙⼛琝砟䨡䰣䔥儧䬩攫ᜭ࠯昱嬳5笷䴹夻䐽∿ᑁC⭅祇≉罋⽍ᩏ絑Փ㵕汗ⱙཛ㡝ş᭡㙣╥ཧ幩填⭭䍯㍱έյ፷㱹᭻䍽뵿", a_)
		End Sub

		' Token: 0x0600478A RID: 18314
		Private Declare Ansi Function SetValue Lib "Foxtable.IO.dll" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef A_0 As String) As Integer

		' Token: 0x17001042 RID: 4162
		' (get) Token: 0x0600478B RID: 18315 RVA: 0x001D89EB File Offset: 0x001D6BEB
		Friend ReadOnly Property ProcessForm As o\u3000\u3002\u3002\u3002\u3002
			Get
				If Foxtable.Main.OO_O.o. Is Nothing OrElse Foxtable.Main.OO_O.o..IsDisposed Then
					Foxtable.Main.OO_O.o. = New o\u3000\u3002\u3002\u3002\u3002()
				End If
				Return Foxtable.Main.OO_O.o.
			End Get
		End Property

		' Token: 0x0600478C RID: 18316 RVA: 0x001D8A10 File Offset: 0x001D6C10
		Private Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 9
			MessageBox.Show(O00OOOo_O0_O.b("믱ꏿῬ뎜톞薤�쪪사쪮우�잴�馸覺鎼达覲ɋ覉씷⮯ᢠ겥͝饜ﮱ튢咄턣⡕ꚳ䒜햶짦꟨껪맬쿮런臲铴髶鳸賺鋼跾樀⌂㜄⤆㤈⬊希弎⌐ᄢ", a_), O00OOOo_O0_O.b("踃瘓", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Dim text As String = O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("캠슢솤즦첨���莰鶲�쎶풸", a_)
			If OO_00oOO.FileSys.FileExists(text) Then
				New Process() With { .File = text }.Start()
			End If
		End Sub

		' Token: 0x0600478D RID: 18317 RVA: 0x001D8A84 File Offset: 0x001D6C84
		<STAThread()>
		Public Sub Main()
			Dim a_ As Integer = 1
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				Dim num2 As Integer = 2
				If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("뮔", a_)) OrElse OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("ﲎ놞얠쾢즤", a_)) Then
					GoTo IL_45B
				End If
				IL_60:
				num2 = 4
				If OO_00oOO.FileSys.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("펎힐ﲒ連爵�䷔", a_)) Then
					GoTo IL_AC
				End If
				IL_87:
				num2 = 5
				OO_00oOO.FileSys.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("펎힐ﲒ連爵�䷔", a_))
				IL_AC:
				num2 = 6
				OoO0o.LoadRuntime()
				IL_B4:
				num2 = 7
				Dim a_2 As String = ""
				IL_BC:
				num2 = 8
				If Operators.CompareString(OO_00oOO.IssueName(), "", True) <> 0 Then
					GoTo IL_E7
				End If
				IL_D0:
				num2 = 9
				Throw New Exception(O00OOOo_O0_O.b("阛縛ꊒꖔꞖ", a_))
				IL_E7:
				num2 = 10
				If Not o_O_o_oOoo__.OOOO_OO._oo.() Then
					GoTo IL_FE
				End If
				IL_F1:
				num2 = 11
				Foxtable.Main.oOOoo_.0__.()
				GoTo IL_45B
				IL_FE:
				num2 = 13
				If c.Oo.__O0.().CommandLineArgs.Count <= 0 OrElse Not c.OOOOO.o.().FileSystem.FileExists(c.Oo.__O0.().CommandLineArgs(0)) Then
					GoTo IL_14D
				End If
				IL_134:
				num2 = 14
				a_2 = c.Oo.__O0.().CommandLineArgs(0).Trim()
				IL_14D:
				num2 = 15
				Application.CurrentCulture = New CultureInfo(O00OOOo_O0_O.b("戀뺒횔�", a_))
				IL_168:
				num2 = 16
				Foxtable.Main.OO_O.o. = Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length - 3) + O00OOOo_O0_O.b("戀ﺒ", a_)
				IL_19A:
				num2 = 17
				ServicePointManager.ServerCertificateValidationCallback = AddressOf Foxtable.Main.oO0.o0_o0o.
				IL_1AE:
				num2 = 18
				AddHandler SystemEvents.PowerModeChanged, AddressOf O_O0OO.Oo0.OoOo.
				IL_1C2:
				num2 = 19
				Application.EnableVisualStyles()
				IL_1CA:
				num2 = 20
				Dim thread As Thread = AddressOf Foxtable.Main.o_0.O0oO_O0_.
				IL_1E0:
				num2 = 21
				thread.Start()
				IL_1EA:
				num2 = 22
				Application.DoEvents()
				IL_1F2:
				num2 = 23
				Dim text As String = Foxtable.My.Resources.a.o0oO_0.O_oOO_.()
				Foxtable.Main.SetValue(text)
				IL_204:
				num2 = 24
				AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Foxtable.Main.o_0Oo0__.oooO0.
				IL_21D:
				num2 = 25
				Foxtable.Main.o_0Oo0__.oooO0.(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ즔", a_))
				IL_23D:
				num2 = 26
				If Not OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ", a_)) Then
					GoTo IL_315
				End If
				IL_267:
				num2 = 27
				If OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("펎펐朗ﮔ쮖쾘ﺚ좠첢쮤覦�펪�", a_)) Then
					GoTo IL_2B6
				End If
				IL_28E:
				num2 = 28
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ", a_), DeleteDirectoryOption.DeleteAllContents)
				GoTo IL_315
				IL_2B6:
				num2 = 30
				Dim right As String = OO_00oOO.FileSys.ReadAllText(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("펎펐朗ﮔ쮖쾘ﺚ좠첢쮤覦�펪�", a_))
				IL_2DD:
				num2 = 31
				If Operators.CompareString(OO_00oOO.ApplicationVertion(), right, True) = 0 Then
					GoTo IL_315
				End If
				IL_2EF:
				num2 = 32
				OO_00oOO.FileSys.DeleteDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ", a_), DeleteDirectoryOption.DeleteAllContents)
				IL_315:
				num2 = 33
				If OO_00oOO.FileSys.DirectoryExists(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ", a_)) Then
					GoTo IL_38C
				End If
				IL_33C:
				num2 = 34
				OO_00oOO.FileSys.CreateDirectory(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("춎ﶒ", a_))
				IL_361:
				num2 = 35
				OO_00oOO.FileSys.WriteAllText(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("펎펐朗ﮔ쮖쾘ﺚ좠첢쮤覦�펪�", a_), OO_00oOO.ApplicationVertion(), False)
				IL_38C:
				num2 = 36
				Dim dateTimeFormatInfo As DateTimeFormatInfo = Application.CurrentCulture.DateTimeFormat
				IL_39B:
				num2 = 37
				dateTimeFormatInfo.DateSeparator = O00OOOo_O0_O.b("ꊎ", a_)
				IL_3B3:
				num2 = 38
				dateTimeFormatInfo.TimeSeparator = O00OOOo_O0_O.b("떎", a_)
				IL_3CB:
				num2 = 39
				dateTimeFormatInfo.ShortDatePattern = O00OOOo_O0_O.b("몖풘횚난ﮞ얠", a_)
				IL_3E3:
				num2 = 40
				dateTimeFormatInfo.LongDatePattern = O00OOOo_O0_O.b("몖풘횚난ﮞ얠", a_)
				IL_3FB:
				num2 = 41
				dateTimeFormatInfo.ShortTimePattern = O00OOOo_O0_O.b("잎ꮐﺒ", a_)
				IL_413:
				num2 = 42
				dateTimeFormatInfo.LongTimePattern = O00OOOo_O0_O.b("잎�ꦒ殺ꎘ", a_)
				IL_42B:
				dateTimeFormatInfo = Nothing
				IL_42E:
				num2 = 44
				Foxtable.Main.OO_O.o. = Thread.CurrentThread.ManagedThreadId
				IL_440:
				num2 = 45
				Foxtable.Main.Oo00OoO0_.o_oo.(a_2)
				IL_449:
				num2 = 46
				Foxtable.Main.OO_O.o. = 3
				IL_452:
				num2 = 47
				OO_00oOO.SystemReady = True
				IL_45B:
				GoTo IL_56D
				IL_460:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_52E:
				GoTo IL_562
				IL_530:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_540:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_530
			End Try
			IL_562:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_56D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600478E RID: 18318 RVA: 0x001D9024 File Offset: 0x001D7224
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Dim a_ As Integer = 4
			Control.CheckForIllegalCrossThreadCalls = False
			Foxtable.Main.o_O.O0O0_o0_.()
			Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("슑킡쮣첥춧즩�񻺱톳", a_))
			If dataRow IsNot Nothing AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("톑ﮓﺗﮛ", a_)) Then
				A_0 = OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("秊ﾙﾛﲟ", a_) + dataRow(O00OOOo_O0_O.b("톑ﮓﺗﮛ", a_)).ToString()
				If OO_00oOO.FileSys.FileExists(A_0) Then
					Foxtable.Main.OO_O.o. = New jk()
					Dim thread As Thread = AddressOf Foxtable.Main.OO.oo_0o0O.
					thread.Start()
					If Operators.CompareString(A_0, "", True) = 0 Then
						A_0 = Foxtable.Main.o_0Oo0__.oooO0.()
						O_O0OO.o0OoO00OO.00O. = A_0
					End If
					If Project.Open(A_0, New String(-1) {}) Then
						Foxtable.Main.OO_O.o. = 4
						If thread.ThreadState <> System.Threading.ThreadState.Stopped Then
							thread.Abort()
						End If
						If Foxtable.Main.OO_O.o..IsDisposed Then
							If(c.Oo.__O0.().CommandLineArgs.Count <> 1 OrElse Operators.CompareString(c.Oo.__O0.().CommandLineArgs(0), O00OOOo_O0_O.b("ﮓ", a_), True) <> 0) AndAlso OO_00oOO.FileSys.FileExists(OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("톑ﮓﲙ얟財솣�춧", a_)) AndAlso c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("聯鍊솝춡�殮쮩�욭", a_)) Then
								New Process() With { .StartInfo = { .FileName = OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("톑ﮓﲙ얟財솣�춧", a_), .Arguments = Process.GetCurrentProcess().ProcessName } }.Start()
								Process.GetCurrentProcess().Kill()
								Return
							End If
						Else
							Dim oo_oo0_0oo As OO_oo0_0oo00 = New OO_oo0_0oo00()
							Foxtable.Main.o__O0O.0_. = oo_oo0_0oo.o00O.o0oo.()
							If(Foxtable.Main.o__O0O.0_. > Foxtable.Main.oo0.o0_o. OrElse o0OO__.O_0_O0_OO.0Ooo.()) AndAlso Not oo_oo0_0oo.o00O.o0oo.() Then
								ooO.oo__.O000_o_O.()
							End If
							Try
								For Each path As String In OO_00oOO.FileSys.GetFiles(OO_00oOO.ApplicationPath, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, New String() { O00OOOo_O0_O.b("ﮓﮙﺛ얟財躣", a_) })
									If(File.GetAttributes(path) And FileAttributes.Hidden) = FileAttributes.Hidden Then
										File.SetAttributes(path, FileAttributes.Normal)
									End If
								Next
							Finally
								Dim enumerator As IEnumerator(Of String)
								If enumerator IsNot Nothing Then
									enumerator.Dispose()
								End If
							End Try
							Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { O00OOOo_O0_O.b("펑ﶗﺛ�솣풥�쎩쎫삭", a_), o0_O.o_.oOOO0_0_o0. })
							If dataRow2 Is Nothing OrElse Operators.CompareString(dataRow2(O00OOOo_O0_O.b("톑ﮓﺗﮛ", a_)).ToString(), OO_00oOO.ApplicationVertion(), True) <> 0 Then
								MessageBox.Show(O00OOOo_O0_O.b("童�듰ᛍ韡ᇃ軆ꧭꛫ尦ꭖ", a_), O00OOOo_O0_O.b("䋲껪", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Return
							End If
							AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Foxtable.Main.oO0.o0_o0o.
							AddHandler NetworkChange.NetworkAddressChanged, AddressOf Foxtable.Main.oO0.o0_o0o.
							Application.Run(Foxtable.Main.OO_O.o.)
							If OO_00oOO.OO._ooO. IsNot Nothing Then
								OO_00oOO.OO._ooO..CloseCom()
							End If
							RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf Foxtable.Main.oO0.o0_o0o.
							RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf Foxtable.Main.oO0.o0_o0o.
							Foxtable.Main.Oo00OoO0_.o_oo.()
							If Operators.CompareString(O_O0OO.o0OoO00OO.00O., "", True) > 0 AndAlso c.OOOOO.o.().FileSystem.FileExists(O_O0OO.o0OoO00OO.00O.) Then
								Try
									c.OOOOO.o.().FileSystem.DeleteDirectory(c.OOOOO.o.().FileSystem.GetParentPath(O_O0OO.o0OoO00OO.00O.), DeleteDirectoryOption.DeleteAllContents)
								Catch ex As Exception
								End Try
							End If
							OO_00oOO.Ports.Clear()
							OO_00oOO.FileWatcher.Enabled = False
							If Foxtable.Main.OO_O.o. Then
								Process.Start(Application.ExecutablePath)
								Return
							End If
							If(c.Oo.__O0.().CommandLineArgs.Count <> 1 OrElse Operators.CompareString(c.Oo.__O0.().CommandLineArgs(0), O00OOOo_O0_O.b("ﮓ", a_), True) <> 0) AndAlso OO_00oOO.FileSys.FileExists(OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("톑ﮓﲙ얟財솣�춧", a_)) AndAlso c.OOOOO.o.().FileSystem.DirectoryExists(OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("聯鍊솝춡�殮쮩�욭", a_)) Then
								New Process() With { .StartInfo = { .FileName = OO_00oOO.ApplicationPath + O00OOOo_O0_O.b("톑ﮓﲙ얟財솣�춧", a_), .Arguments = Process.GetCurrentProcess().ProcessName } }.Start()
								Process.GetCurrentProcess().Kill()
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600478F RID: 18319 RVA: 0x001D951C File Offset: 0x001D771C
		Private Function <<EMPTY_NAME>>() As String
			Dim a_ As Integer = 4
			Dim text As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + O00OOOo_O0_O.b("캑튓秊ﶛﲝ첟잡ﮣ춧잩�솭슯펱욳쾵", a_) + ShareLibriay.GetRandString(6) + O00OOOo_O0_O.b("캑", a_)
			Dim text2 As String = text + ShareLibriay.GetRandString(6) + ooO0__OO.oo.Ooo_00.()
			Dim text3 As String = O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("킑ﶓ쒗�풟쎡욣쪥춧蒩슭톯��", a_) + ooO0__OO.oo.Ooo_00.()
			c.OOOOO.o.().FileSystem.CreateDirectory(text)
			If Not OO_00oOO.FileSys.DirectoryExists(OO_00oOO.FileSys.GetParentPath(text3)) Then
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.FileSys.GetParentPath(text3))
			End If
			Dim text4 As String = O00OOOo_O0_O.b("鋟ᣝ鿛䏁໗鷓쯎￯", a_)
			If Not OO_00oOO.FileSys.FileExists(text3) Then
				If Not o0OoOOoOOo0.O_0_Oo_00.O.(text3) Then
					Return ""
				End If
				Dim a_2 As OleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(text3))
				Dim o_oo As o_oo0 = New o_oo0(a_2, False, True)
				Dim num As Integer = 0
				Do
					If Not o_oo.o0_oo0._.().oooO__O_0o_.o_.(O00OOOo_O0_O.b("神", a_) + Conversions.ToString(Strings.Chr(65 + num))) Then
						o_oo.o0_oo0._.().O_.0_O__OOoOo.(O00OOOo_O0_O.b("神", a_) + Conversions.ToString(Strings.Chr(65 + num)))
					End If
					Dim o_0O_ As O_0O_ = o_oo.o0_oo0._.().O.0_O.(O00OOOo_O0_O.b("神", a_) + Conversions.ToString(Strings.Chr(65 + num)))
					Dim num2 As Integer = 0
					Do
						o_0O_.o_O00_.00_.().O_o0.Oo00o0.(O00OOOo_O0_O.b("뻪", a_) + Conversions.ToString(text4(num2)) + O00OOOo_O0_O.b("藃", a_), ColumnDataTypeEnum.[String], Integer.MinValue)
						num2 += 1
					Loop While num2 <= 9
					num += 1
				Loop While num <= 2
				o_oo.o0_oo0._.(False, False)
			End If
			OO_00oOO.FileSys.CopyFile(text3, text2)
			Return text2
		End Function

		' Token: 0x06004790 RID: 18320 RVA: 0x001D972C File Offset: 0x001D792C
		Private Sub <<EMPTY_NAME>>()
			Dim codeDomProvider As CodeDomProvider = New VBCodeProvider()
			Dim options As CompilerParameters = New CompilerParameters()
			codeDomProvider.CompileAssemblyFromSource(options, New String() { "" })
		End Sub

		' Token: 0x06004791 RID: 18321 RVA: 0x001D975C File Offset: 0x001D795C
		<MethodImpl(MethodImplOptions.NoInlining)>
		Private Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 17
			If Foxtable.Main.O00._O__0. <> 1 Then
				Foxtable.Main.O00._O__0. = 1
				Dim text As String = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + O00OOOo_O0_O.b("쎞첢쮤솦삨첪莬쮮킰잲", a_)
				If Not c.OOOOO.o.().FileSystem.FileExists(text) Then
					Foxtable.Main.OO_O.o. = 3
					MessageBox.Show(O00OOOo_O0_O.b("툏쿟Ⓡ只쒦욨얪쮬욮횰鶲톴횶춸뛴韩촿햠쁄㖛ڶ恂ꭘ퀯", a_), O00OOOo_O0_O.b("俽鯙", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
					ProjectData.EndApp()
				End If
				Dim selectConnection As OleDbConnection = New OleDbConnection(Oo00.o_._0OOo.(text))
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(O00OOOo_O0_O.b("첞쒠쾢삤쒦�讪螬辮솲��馸쎼賀鏂蛄识駈裊ꋌꇎ럐뫒닔論", a_), selectConnection)
				oleDbDataAdapter.FillSchema(O_O0OO.O0_00o.o0__o., SchemaType.Source)
				oleDbDataAdapter.Fill(O_O0OO.O0_00o.o0__o.)
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter)
				O_O0OO.O0_00o.o0__o..ExtendedProperties.Add(O00OOOo_O0_O.b("�삠힢쒤춨쪪��풰솲", a_), oleDbDataAdapter)
				Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("춞쒠삢삤즦�쒬쎮풰삲", a_))
				If dataRow IsNot Nothing Then
					If dataRow.IsNull(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_)) Then
						Return
					End If
					For Each item As String In Conversions.ToString(dataRow(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_))).Split(New Char() { vbTab }, StringSplitOptions.RemoveEmptyEntries)
						O_O0OO.o0OoO00OO.00O..Add(item)
					Next
				End If
				If O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("�캠�톤욦쮨잪좬", a_)) Is Nothing Then
					Foxtable.Main.OO_O.o. = 3
					MessageBox.Show(O00OOOo_O0_O.b("翻쯛⃃忦꩕", a_), O00OOOo_O0_O.b("俽鯙", a_), MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
				Dim right As String = O00OOOo_O0_O.b("궞趠", a_) + OO_00oOO.ApplicationVertion()
				dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("�캠첢스쮦첨", a_))
				If Operators.CompareString(dataRow(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_)).ToString(), right, True) <> 0 Then
					Foxtable.Main.OO_O.o. = 4
					MessageBox.Show(O00OOOo_O0_O.b("翻쯛⃃忦꩕", a_), O00OOOo_O0_O.b("俽鯙", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					ProjectData.EndApp()
				End If
				dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("쮞즠욢좤슦��욮��운", a_))
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_)) Then
					Dim array2 As String() = dataRow(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_)).ToString().Split(New Char() { vbVerticalTab })
					If array2.Length >= 5 Then
						O_O0OO.O_.00. = array2(0)
						O_O0OO.Oo._00O0_oO. = array2(1)
						O_O0OO.o_.oO_O0. = array2(2)
						O_O0OO.oo_oo_o._. = array2(3)
						If Not Integer.TryParse(array2(4), O_O0OO.oO_00Ooo___0._.) Then
							O_O0OO.oO_00Ooo___0._. = 9
						End If
					End If
					If array2.Length >= 8 Then
						Dim colorConverter As ColorConverter = New ColorConverter()
						O_O0OO.o0O._O00o. = Conversions.ToBoolean(array2(5))
						Dim obj As Object = colorConverter.ConvertFrom(array2(6))
						O_O0OO.O0_00o.o0__o. = If((obj IsNot Nothing), CType(obj, Color), Nothing)
						Dim obj2 As Object = colorConverter.ConvertFrom(array2(7))
						O_O0OO.oo0_o_.o. = If((obj2 IsNot Nothing), CType(obj2, Color), Nothing)
					End If
				End If
			End If
		End Sub

		' Token: 0x06004792 RID: 18322 RVA: 0x001D9ABC File Offset: 0x001D7CBC
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim a_ As Integer = 13
			Dim catalogClass As CatalogClass = New CatalogClass()
			catalogClass.Create(Oo00.o00.0OO.(A_0))
			Dim table As Table = New TableClass()
			Dim index As Index = New IndexClass()
			table.Name = O00OOOo_O0_O.b("즜튞쒪쎬즮�풲", a_)
			table.Columns.Append(O00OOOo_O0_O.b("햚ﲜ쒠", a_), 202, 64)
			table.Columns.Append(O00OOOo_O0_O.b("�잠쪢스", a_), 203, 0)
			table.Columns(O00OOOo_O0_O.b("�잠쪢스", a_)).Attributes = 2
			index.Name = O00OOOo_O0_O.b("쮚철슢힤�캪풬", a_)
			index.Columns.Append(O00OOOo_O0_O.b("햚ﲜ쒠", a_), 202, 0)
			index.PrimaryKey = True
			index.Unique = True
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
			catalogClass.Tables.Append(table)
			CType(catalogClass.ActiveConnection, Connection).Close()
		End Sub

		' Token: 0x06004793 RID: 18323 RVA: 0x001D9BD4 File Offset: 0x001D7DD4
		Friend Sub <<EMPTY_NAME>>()
			If Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., True) <> 0 Then
				If O_O0OO.o0OoO00OO.00O..Contains(OO_00oOO.ProjectFile) Then
					O_O0OO.o0OoO00OO.00O..Remove(OO_00oOO.ProjectFile)
				End If
				O_O0OO.o0OoO00OO.00O..Insert(0, OO_00oOO.ProjectFile)
			End If
		End Sub

		' Token: 0x06004794 RID: 18324 RVA: 0x001D9C24 File Offset: 0x001D7E24
		Private Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 17
			Dim text As String = ""
			Dim dataRow As DataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("춞쒠삢삤즦�쒬쎮풰삲", a_))
			If dataRow Is Nothing Then
				dataRow = O_O0OO.O0_00o.o0__o..NewRow()
				dataRow(O00OOOo_O0_O.b("톞삠캢삤", a_)) = O00OOOo_O0_O.b("춞쒠삢삤즦�쒬쎮풰삲", a_)
				O_O0OO.O0_00o.o0__o..Rows.Add(dataRow)
			End If
			Try
				For Each str As String In O_O0OO.o0OoO00OO.00O.
					If Operators.CompareString(text, "", True) > 0 Then
						text += O00OOOo_O0_O.b("隞", a_)
					End If
					text += str
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			dataRow(O00OOOo_O0_O.b("�캠춢쎤캦캨", a_)) = text
			Oo00.o0_o._O_.(O_O0OO.O0_00o.o0__o., True)
		End Sub

		' Token: 0x06004795 RID: 18325 RVA: 0x001D9D2C File Offset: 0x001D7F2C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As Integer = 1
			Dim ribbonButton As RibbonButton = CType(CType(A_0, RibbonListItem).Items(0), RibbonButton)
			If c.OOOOO.o.().FileSystem.FileExists(ribbonButton.ToolTip) Then
				Project.Open(ribbonButton.ToolTip, New String(-1) {})
			Else
				MessageBox.Show(O00OOOo_O0_O.b("࣫柞黜췏뿁顧", a_), O00OOOo_O0_O.b("忭ꯩ", a_), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				O_O0OO.o0OoO00OO.00O..Remove(ribbonButton.ToolTip)
				Foxtable.Main.O0O_.00_O0Oo_.()
			End If
		End Sub

		' Token: 0x06004796 RID: 18326 RVA: 0x001D9DC3 File Offset: 0x001D7FC3
		Private Sub <<EMPTY_NAME>>()
			New o\u30000\u3000\u3000\u3002O().ShowDialog()
			Do
				Thread.Sleep(500)
			Loop While Not OO_00oOO.SystemReady
		End Sub

		' Token: 0x06004797 RID: 18327 RVA: 0x001D9DE4 File Offset: 0x001D7FE4
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim a_ As Integer = 15
			If OO_00oOO.FileSys.DirectoryExists(A_0) Then
				If Not OO_00oOO.FileSys.FileExists(A_0 + O00OOOo_O0_O.b("쮜爵펠킢첤좦잨薪�힮얰", a_)) Then
					OO_00oOO.FileSys.DeleteDirectory(A_0, DeleteDirectoryOption.DeleteAllContents)
				Else
					Dim right As String = OO_00oOO.FileSys.ReadAllText(A_0 + O00OOOo_O0_O.b("쮜爵펠킢첤좦잨薪�힮얰", a_))
					If Operators.CompareString(OO_00oOO.ApplicationVertion(), right, True) <> 0 Then
						OO_00oOO.FileSys.DeleteDirectory(A_0, DeleteDirectoryOption.DeleteAllContents)
					End If
				End If
			End If
			If Not OO_00oOO.FileSys.DirectoryExists(A_0) Then
				OO_00oOO.FileSys.CreateDirectory(A_0)
				OO_00oOO.FileSys.WriteAllText(A_0 + O00OOOo_O0_O.b("쮜爵펠킢첤좦잨薪�힮얰", a_), OO_00oOO.ApplicationVertion(), False)
			End If
		End Sub

		' Token: 0x06004798 RID: 18328 RVA: 0x001D9EAC File Offset: 0x001D80AC
		Private Function <<EMPTY_NAME>>(A_0 As Object, A_1 As ResolveEventArgs) As Assembly
			Dim a_ As Integer = 4
			If O_O0OO.OoO.0OO__0ooo.() IsNot Nothing AndAlso Operators.CompareString(O_O0OO.O_O._Oo.(), "", True) > 0 AndAlso A_1.Name.StartsWith(o0OoOOoOOo0.oo00o.0OoO.("") + O00OOOo_O0_O.b("벑쒓流ﶝ貟", a_), StringComparison.CurrentCultureIgnoreCase) Then
				Dim text As String = OO_00oOO.ProjectPath + O00OOOo_O0_O.b("캑횓ﾕ욙", a_) + o0OoOOoOOo0.oo00o.0OoO.("") + O00OOOo_O0_O.b("벑쒓流ﶝ躟욡좣쪥", a_)
				If OO_00oOO.FileSys.FileExists(text) Then
					Return Assembly.Load(File.ReadAllBytes(text))
				End If
			ElseIf Operators.CompareString(o0OoOOoOOo0.o___O0.O00., "", True) > 0 AndAlso A_1.Name.StartsWith(o0OoOOoOOo0.oo00o.0OoO.(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("벑쒓流ﶝ貟", a_), StringComparison.CurrentCultureIgnoreCase) Then
				Dim text2 As String = OO_00oOO.FileSys.GetParentPath(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("캑횓ﾕ욙", a_) + o0OoOOoOOo0.oo00o.0OoO.(o0OoOOoOOo0.O.0_0ooo0O.) + O00OOOo_O0_O.b("벑쒓流ﶝ躟욡좣쪥", a_)
				If OO_00oOO.FileSys.FileExists(text2) Then
					Return Assembly.Load(File.ReadAllBytes(text2))
				End If
			End If
			If o0OoOOoOOo0.o00__oo.O0Oo0o. Is Nothing Then
				o0OoOOoOOo0.o00__oo.O0Oo0o. = RuntimeHelpers.GetObjectValue(A_0)
			End If
			Return Nothing
		End Function

		' Token: 0x06004799 RID: 18329 RVA: 0x001DA008 File Offset: 0x001D8208
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NetworkAvailabilityEventArgs)
			If OO_00oOO.SystemReady AndAlso Foxtable.Main.OO_O.o. IsNot Nothing AndAlso Not Foxtable.Main.OO_O.o..IsDisposed Then
				Foxtable.Main.OO_O.o..Invoke(AddressOf Foxtable.Main.o_0Oo0__.oooO0., New Object() { A_1.IsAvailable })
			End If
		End Sub

		' Token: 0x0600479A RID: 18330 RVA: 0x001DA05A File Offset: 0x001D825A
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If OO_00oOO.SystemReady AndAlso OO_00oOO.BaseMainForm IsNot Nothing AndAlso OO_00oOO.BaseMainForm.IsHandleCreated Then
				Foxtable.Main.OO_O.o..Invoke(AddressOf Foxtable.Main.o_0Oo0__.oooO0.)
			End If
		End Sub

		' Token: 0x0600479B RID: 18331 RVA: 0x001DA090 File Offset: 0x001D8290
		Private Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Dim a_ As Integer = 3
			Try
				For Each imclient As IMClient In OO_00oOO.IMClients.Values
					If Not imclient.O0_OOo.O. AndAlso imclient.Ready Then
						Dim control As Control = New oO\u3000\u3002\u3002\u3000O\u3000(imclient, imclient.ooOo.oO0.)
						imclient.[Stop]()
						control.Show()
					End If
				Next
			Finally
				Dim enumerator As Dictionary(Of String, IMClient).ValueCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Dim networkAvailabilityEventArgs As NetworkAvailabilityEventArgs = New NetworkAvailabilityEventArgs(A_0)
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., O00OOOo_O0_O.b("��힠슢첤쮦좨즪쒬쎮�잲체톸�펼�꓀Ꟃ", a_), New Object() { networkAvailabilityEventArgs }, False, O00OOOo_O0_O.b("緤", a_), False)
		End Sub

		' Token: 0x0600479C RID: 18332 RVA: 0x001DA14C File Offset: 0x001D834C
		Private Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 7
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., O00OOOo_O0_O.b("�쪠솤쎦�캪���풴񽪸��", a_), Nothing, False, O00OOOo_O0_O.b("秠", a_), False)
		End Sub

		' Token: 0x0600479D RID: 18333 RVA: 0x001DA18C File Offset: 0x001D838C
		Friend Function <<EMPTY_NAME>>(A_0 As Object, A_1 As X509Certificate, A_2 As X509Chain, A_3 As SslPolicyErrors) As Boolean
			Return True
		End Function

		' Token: 0x04001D3E RID: 7486
		Friend <<EMPTY_NAME>> As jk

		' Token: 0x04001D3F RID: 7487
		Friend <<EMPTY_NAME>> As String

		' Token: 0x04001D40 RID: 7488
		Friend <<EMPTY_NAME>> As SplashFormStateEnum

		' Token: 0x04001D41 RID: 7489
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04001D42 RID: 7490
		Friend <<EMPTY_NAME>> As Integer

		' Token: 0x04001D43 RID: 7491
		Private <<EMPTY_NAME>> As o\u3000\u3002\u3002\u3002\u3002

		' Token: 0x04001D44 RID: 7492
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001D45 RID: 7493
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001D46 RID: 7494
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001D47 RID: 7495
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001D48 RID: 7496
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x0200043D RID: 1085
		' (Invoke) Token: 0x060047A1 RID: 18337
		Public Delegate Sub O0OoooO0Oo_O_(A_0 As Boolean)

		' Token: 0x0200043E RID: 1086
		' (Invoke) Token: 0x060047A5 RID: 18341
		Public Delegate Sub O0_00__()
	End Module
End Namespace
