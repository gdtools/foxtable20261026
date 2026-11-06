Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002C8 RID: 712
	<oO0oooo("1410")>
	<ComVisible(True)>
	Public Class FTPClient
		' Token: 0x14000002 RID: 2
		' (add) Token: 0x060025FD RID: 9725 RVA: 0x001027E4 File Offset: 0x001009E4
		' (remove) Token: 0x060025FE RID: 9726 RVA: 0x0010281C File Offset: 0x00100A1C
		Friend Custom Event DownloadProgressChanged As FTPClient.o0O_O00o_0_o
			<CompilerGenerated()>
			AddHandler
				Dim o0O_O00o_0_o As FTPClient.o0O_O00o_0_o = Me.Ooo_Oo_O0.00O.
				Dim o0O_O00o_0_o2 As FTPClient.o0O_O00o_0_o
				Do
					o0O_O00o_0_o2 = o0O_O00o_0_o
					Dim value2 As FTPClient.o0O_O00o_0_o = CType([Delegate].Combine(o0O_O00o_0_o2, value), FTPClient.o0O_O00o_0_o)
					o0O_O00o_0_o = Interlocked.CompareExchange(Of FTPClient.o0O_O00o_0_o)(Me.Ooo_Oo_O0.00O., value2, o0O_O00o_0_o2)
				Loop While o0O_O00o_0_o IsNot o0O_O00o_0_o2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim o0O_O00o_0_o As FTPClient.o0O_O00o_0_o = Me.Ooo_Oo_O0.00O.
				Dim o0O_O00o_0_o2 As FTPClient.o0O_O00o_0_o
				Do
					o0O_O00o_0_o2 = o0O_O00o_0_o
					Dim value2 As FTPClient.o0O_O00o_0_o = CType([Delegate].Remove(o0O_O00o_0_o2, value), FTPClient.o0O_O00o_0_o)
					o0O_O00o_0_o = Interlocked.CompareExchange(Of FTPClient.o0O_O00o_0_o)(Me.Ooo_Oo_O0.00O., value2, o0O_O00o_0_o2)
				Loop While o0O_O00o_0_o IsNot o0O_O00o_0_o2
			End RemoveHandler
		End Event

		' Token: 0x14000003 RID: 3
		' (add) Token: 0x060025FF RID: 9727 RVA: 0x00102854 File Offset: 0x00100A54
		' (remove) Token: 0x06002600 RID: 9728 RVA: 0x0010288C File Offset: 0x00100A8C
		Friend Custom Event DownloadCompleted As FTPClient.oO_o_0OOo__0
			<CompilerGenerated()>
			AddHandler
				Dim oO_o_0OOo__ As FTPClient.oO_o_0OOo__0 = Me.Ooo_Oo_O0.00O.
				Dim oO_o_0OOo__2 As FTPClient.oO_o_0OOo__0
				Do
					oO_o_0OOo__2 = oO_o_0OOo__
					Dim value2 As FTPClient.oO_o_0OOo__0 = CType([Delegate].Combine(oO_o_0OOo__2, value), FTPClient.oO_o_0OOo__0)
					oO_o_0OOo__ = Interlocked.CompareExchange(Of FTPClient.oO_o_0OOo__0)(Me.Ooo_Oo_O0.00O., value2, oO_o_0OOo__2)
				Loop While oO_o_0OOo__ IsNot oO_o_0OOo__2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oO_o_0OOo__ As FTPClient.oO_o_0OOo__0 = Me.Ooo_Oo_O0.00O.
				Dim oO_o_0OOo__2 As FTPClient.oO_o_0OOo__0
				Do
					oO_o_0OOo__2 = oO_o_0OOo__
					Dim value2 As FTPClient.oO_o_0OOo__0 = CType([Delegate].Remove(oO_o_0OOo__2, value), FTPClient.oO_o_0OOo__0)
					oO_o_0OOo__ = Interlocked.CompareExchange(Of FTPClient.oO_o_0OOo__0)(Me.Ooo_Oo_O0.00O., value2, oO_o_0OOo__2)
				Loop While oO_o_0OOo__ IsNot oO_o_0OOo__2
			End RemoveHandler
		End Event

		' Token: 0x14000004 RID: 4
		' (add) Token: 0x06002601 RID: 9729 RVA: 0x001028C4 File Offset: 0x00100AC4
		' (remove) Token: 0x06002602 RID: 9730 RVA: 0x001028FC File Offset: 0x00100AFC
		Friend Custom Event DownloadError As FTPClient.O__0O000__Oo
			<CompilerGenerated()>
			AddHandler
				Dim o__0O000__Oo As FTPClient.O__0O000__Oo = Me.Ooo_Oo_O0.00O.
				Dim o__0O000__Oo2 As FTPClient.O__0O000__Oo
				Do
					o__0O000__Oo2 = o__0O000__Oo
					Dim value2 As FTPClient.O__0O000__Oo = CType([Delegate].Combine(o__0O000__Oo2, value), FTPClient.O__0O000__Oo)
					o__0O000__Oo = Interlocked.CompareExchange(Of FTPClient.O__0O000__Oo)(Me.Ooo_Oo_O0.00O., value2, o__0O000__Oo2)
				Loop While o__0O000__Oo IsNot o__0O000__Oo2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim o__0O000__Oo As FTPClient.O__0O000__Oo = Me.Ooo_Oo_O0.00O.
				Dim o__0O000__Oo2 As FTPClient.O__0O000__Oo
				Do
					o__0O000__Oo2 = o__0O000__Oo
					Dim value2 As FTPClient.O__0O000__Oo = CType([Delegate].Remove(o__0O000__Oo2, value), FTPClient.O__0O000__Oo)
					o__0O000__Oo = Interlocked.CompareExchange(Of FTPClient.O__0O000__Oo)(Me.Ooo_Oo_O0.00O., value2, o__0O000__Oo2)
				Loop While o__0O000__Oo IsNot o__0O000__Oo2
			End RemoveHandler
		End Event

		' Token: 0x14000005 RID: 5
		' (add) Token: 0x06002603 RID: 9731 RVA: 0x00102934 File Offset: 0x00100B34
		' (remove) Token: 0x06002604 RID: 9732 RVA: 0x0010296C File Offset: 0x00100B6C
		Friend Custom Event UploadProgressChanged As FTPClient.o0_O_0_0
			<CompilerGenerated()>
			AddHandler
				Dim o0_O_0_ As FTPClient.o0_O_0_0 = Me.O0OO._0OO.
				Dim o0_O_0_2 As FTPClient.o0_O_0_0
				Do
					o0_O_0_2 = o0_O_0_
					Dim value2 As FTPClient.o0_O_0_0 = CType([Delegate].Combine(o0_O_0_2, value), FTPClient.o0_O_0_0)
					o0_O_0_ = Interlocked.CompareExchange(Of FTPClient.o0_O_0_0)(Me.O0OO._0OO., value2, o0_O_0_2)
				Loop While o0_O_0_ IsNot o0_O_0_2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim o0_O_0_ As FTPClient.o0_O_0_0 = Me.O0OO._0OO.
				Dim o0_O_0_2 As FTPClient.o0_O_0_0
				Do
					o0_O_0_2 = o0_O_0_
					Dim value2 As FTPClient.o0_O_0_0 = CType([Delegate].Remove(o0_O_0_2, value), FTPClient.o0_O_0_0)
					o0_O_0_ = Interlocked.CompareExchange(Of FTPClient.o0_O_0_0)(Me.O0OO._0OO., value2, o0_O_0_2)
				Loop While o0_O_0_ IsNot o0_O_0_2
			End RemoveHandler
		End Event

		' Token: 0x14000006 RID: 6
		' (add) Token: 0x06002605 RID: 9733 RVA: 0x001029A4 File Offset: 0x00100BA4
		' (remove) Token: 0x06002606 RID: 9734 RVA: 0x001029DC File Offset: 0x00100BDC
		Friend Custom Event UploadCompleted As FTPClient.oO___
			<CompilerGenerated()>
			AddHandler
				Dim oO___ As FTPClient.oO___ = Me.O0OO._0OO.
				Dim oO___2 As FTPClient.oO___
				Do
					oO___2 = oO___
					Dim value2 As FTPClient.oO___ = CType([Delegate].Combine(oO___2, value), FTPClient.oO___)
					oO___ = Interlocked.CompareExchange(Of FTPClient.oO___)(Me.O0OO._0OO., value2, oO___2)
				Loop While oO___ IsNot oO___2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oO___ As FTPClient.oO___ = Me.O0OO._0OO.
				Dim oO___2 As FTPClient.oO___
				Do
					oO___2 = oO___
					Dim value2 As FTPClient.oO___ = CType([Delegate].Remove(oO___2, value), FTPClient.oO___)
					oO___ = Interlocked.CompareExchange(Of FTPClient.oO___)(Me.O0OO._0OO., value2, oO___2)
				Loop While oO___ IsNot oO___2
			End RemoveHandler
		End Event

		' Token: 0x14000007 RID: 7
		' (add) Token: 0x06002607 RID: 9735 RVA: 0x00102A14 File Offset: 0x00100C14
		' (remove) Token: 0x06002608 RID: 9736 RVA: 0x00102A4C File Offset: 0x00100C4C
		Friend Custom Event UploadError As FTPClient.ooo__O
			<CompilerGenerated()>
			AddHandler
				Dim ooo__O As FTPClient.ooo__O = Me.O0OO._0OO.
				Dim ooo__O2 As FTPClient.ooo__O
				Do
					ooo__O2 = ooo__O
					Dim value2 As FTPClient.ooo__O = CType([Delegate].Combine(ooo__O2, value), FTPClient.ooo__O)
					ooo__O = Interlocked.CompareExchange(Of FTPClient.ooo__O)(Me.O0OO._0OO., value2, ooo__O2)
				Loop While ooo__O IsNot ooo__O2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim ooo__O As FTPClient.ooo__O = Me.O0OO._0OO.
				Dim ooo__O2 As FTPClient.ooo__O
				Do
					ooo__O2 = ooo__O
					Dim value2 As FTPClient.ooo__O = CType([Delegate].Remove(ooo__O2, value), FTPClient.ooo__O)
					ooo__O = Interlocked.CompareExchange(Of FTPClient.ooo__O)(Me.O0OO._0OO., value2, ooo__O2)
				Loop While ooo__O IsNot ooo__O2
			End RemoveHandler
		End Event

		' Token: 0x14000008 RID: 8
		' (add) Token: 0x06002609 RID: 9737 RVA: 0x00102A84 File Offset: 0x00100C84
		' (remove) Token: 0x0600260A RID: 9738 RVA: 0x00102ABC File Offset: 0x00100CBC
		Friend Custom Event ServerConnected As FTPClient.OooO_O0O_0_O
			<CompilerGenerated()>
			AddHandler
				Dim oooO_O0O_0_O As FTPClient.OooO_O0O_0_O = Me.o_O.o_Oo0O_o0O.
				Dim oooO_O0O_0_O2 As FTPClient.OooO_O0O_0_O
				Do
					oooO_O0O_0_O2 = oooO_O0O_0_O
					Dim value2 As FTPClient.OooO_O0O_0_O = CType([Delegate].Combine(oooO_O0O_0_O2, value), FTPClient.OooO_O0O_0_O)
					oooO_O0O_0_O = Interlocked.CompareExchange(Of FTPClient.OooO_O0O_0_O)(Me.o_O.o_Oo0O_o0O., value2, oooO_O0O_0_O2)
				Loop While oooO_O0O_0_O IsNot oooO_O0O_0_O2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oooO_O0O_0_O As FTPClient.OooO_O0O_0_O = Me.o_O.o_Oo0O_o0O.
				Dim oooO_O0O_0_O2 As FTPClient.OooO_O0O_0_O
				Do
					oooO_O0O_0_O2 = oooO_O0O_0_O
					Dim value2 As FTPClient.OooO_O0O_0_O = CType([Delegate].Remove(oooO_O0O_0_O2, value), FTPClient.OooO_O0O_0_O)
					oooO_O0O_0_O = Interlocked.CompareExchange(Of FTPClient.OooO_O0O_0_O)(Me.o_O.o_Oo0O_o0O., value2, oooO_O0O_0_O2)
				Loop While oooO_O0O_0_O IsNot oooO_O0O_0_O2
			End RemoveHandler
		End Event

		' Token: 0x14000009 RID: 9
		' (add) Token: 0x0600260B RID: 9739 RVA: 0x00102AF4 File Offset: 0x00100CF4
		' (remove) Token: 0x0600260C RID: 9740 RVA: 0x00102B2C File Offset: 0x00100D2C
		Friend Custom Event ShowMessage As FTPClient.OOOOO00OoOOo
			<CompilerGenerated()>
			AddHandler
				Dim ooooo00OoOOo As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				Dim ooooo00OoOOo2 As FTPClient.OOOOO00OoOOo
				Do
					ooooo00OoOOo2 = ooooo00OoOOo
					Dim value2 As FTPClient.OOOOO00OoOOo = CType([Delegate].Combine(ooooo00OoOOo2, value), FTPClient.OOOOO00OoOOo)
					ooooo00OoOOo = Interlocked.CompareExchange(Of FTPClient.OOOOO00OoOOo)(Me.O0OO._0OO., value2, ooooo00OoOOo2)
				Loop While ooooo00OoOOo IsNot ooooo00OoOOo2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim ooooo00OoOOo As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				Dim ooooo00OoOOo2 As FTPClient.OOOOO00OoOOo
				Do
					ooooo00OoOOo2 = ooooo00OoOOo
					Dim value2 As FTPClient.OOOOO00OoOOo = CType([Delegate].Remove(ooooo00OoOOo2, value), FTPClient.OOOOO00OoOOo)
					ooooo00OoOOo = Interlocked.CompareExchange(Of FTPClient.OOOOO00OoOOo)(Me.O0OO._0OO., value2, ooooo00OoOOo2)
				Loop While ooooo00OoOOo IsNot ooooo00OoOOo2
			End RemoveHandler
		End Event

		' Token: 0x1400000A RID: 10
		' (add) Token: 0x0600260D RID: 9741 RVA: 0x00102B64 File Offset: 0x00100D64
		' (remove) Token: 0x0600260E RID: 9742 RVA: 0x00102B9C File Offset: 0x00100D9C
		Friend Custom Event ShowError As FTPClient.OoO_00_o
			<CompilerGenerated()>
			AddHandler
				Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
				Dim ooO_00_o2 As FTPClient.OoO_00_o
				Do
					ooO_00_o2 = ooO_00_o
					Dim value2 As FTPClient.OoO_00_o = CType([Delegate].Combine(ooO_00_o2, value), FTPClient.OoO_00_o)
					ooO_00_o = Interlocked.CompareExchange(Of FTPClient.OoO_00_o)(Me.o_O.o_Oo0O_o0O., value2, ooO_00_o2)
				Loop While ooO_00_o IsNot ooO_00_o2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
				Dim ooO_00_o2 As FTPClient.OoO_00_o
				Do
					ooO_00_o2 = ooO_00_o
					Dim value2 As FTPClient.OoO_00_o = CType([Delegate].Remove(ooO_00_o2, value), FTPClient.OoO_00_o)
					ooO_00_o = Interlocked.CompareExchange(Of FTPClient.OoO_00_o)(Me.o_O.o_Oo0O_o0O., value2, ooO_00_o2)
				Loop While ooO_00_o IsNot ooO_00_o2
			End RemoveHandler
		End Event

		' Token: 0x1400000B RID: 11
		' (add) Token: 0x0600260F RID: 9743 RVA: 0x00102BD4 File Offset: 0x00100DD4
		' (remove) Token: 0x06002610 RID: 9744 RVA: 0x00102C0C File Offset: 0x00100E0C
		Friend Custom Event FileCompared As FTPClient.Oo__
			<CompilerGenerated()>
			AddHandler
				Dim oo__ As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
				Dim oo__2 As FTPClient.Oo__
				Do
					oo__2 = oo__
					Dim value2 As FTPClient.Oo__ = CType([Delegate].Combine(oo__2, value), FTPClient.Oo__)
					oo__ = Interlocked.CompareExchange(Of FTPClient.Oo__)(Me.o_O.o_Oo0O_o0O., value2, oo__2)
				Loop While oo__ IsNot oo__2
			End AddHandler
			<CompilerGenerated()>
			RemoveHandler
				Dim oo__ As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
				Dim oo__2 As FTPClient.Oo__
				Do
					oo__2 = oo__
					Dim value2 As FTPClient.Oo__ = CType([Delegate].Remove(oo__2, value), FTPClient.Oo__)
					oo__ = Interlocked.CompareExchange(Of FTPClient.Oo__)(Me.o_O.o_Oo0O_o0O., value2, oo__2)
				Loop While oo__ IsNot oo__2
			End RemoveHandler
		End Event

		' Token: 0x17000894 RID: 2196
		' (get) Token: 0x06002611 RID: 9745 RVA: 0x00102C41 File Offset: 0x00100E41
		' (set) Token: 0x06002612 RID: 9746 RVA: 0x00102C4C File Offset: 0x00100E4C
		Private Overridable Property Timer As System.Timers.Timer
			<CompilerGenerated()>
			Get
				Return Me.O_O.O0oO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Timers.Timer)
				Dim value2 As ElapsedEventHandler = AddressOf Me.o0O_0_.00_oooo.
				Dim o_O.O0oO. As System.Timers.Timer = Me.O_O.O0oO.
				If o_O.O0oO. IsNot Nothing Then
					RemoveHandler o_O.O0oO..Elapsed, value2
				End If
				Me.O_O.O0oO. = value
				o_O.O0oO. = Me.O_O.O0oO.
				If o_O.O0oO. IsNot Nothing Then
					AddHandler o_O.O0oO..Elapsed, value2
				End If
			End Set
		End Property

		' Token: 0x17000895 RID: 2197
		' (get) Token: 0x06002613 RID: 9747 RVA: 0x00102C8F File Offset: 0x00100E8F
		' (set) Token: 0x06002614 RID: 9748 RVA: 0x00102C98 File Offset: 0x00100E98
		Private Overridable Property MainForm As Form
			<CompilerGenerated()>
			Get
				Return Me.o_O_.00_00.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Form)
				Dim value2 As FormClosedEventHandler = AddressOf Me.oo0000O.Oo0OO.
				Dim form As Form = Me.o_O_.00_00.
				If form IsNot Nothing Then
					RemoveHandler form.FormClosed, value2
				End If
				Me.o_O_.00_00. = value
				form = Me.o_O_.00_00.
				If form IsNot Nothing Then
					AddHandler form.FormClosed, value2
				End If
			End Set
		End Property

		' Token: 0x06002615 RID: 9749 RVA: 0x00102CDC File Offset: 0x00100EDC
		Public Sub New()
			Me.Ooo_Oo_O0.00O. = 512
			Me.OO0O00_0_._0. = 51200
			Me.o__0.0. = 21
			Me.o.oo000oOoo. = 0
			Me.oOo0_Oo.O_. = 0
			Me.oOo.O00O__oO_. = False
			Me.OOO00.ooo0. = False
			Me.Ooo_Oo_O0.00O. = New Byte(Me.Ooo_Oo_O0.00O. + 1 - 1) {}
			Me.OO0O00_0_._0. = New Byte(Me.OO0O00_0_._0. + 1 - 1) {}
			Me.Ooo_Oo_O0.00O. = Nothing
			Me.oO0_O._. = 20
			Me.o0O0.oo0O0. = True
			Me.ooo_.O0___oO00. = True
			Me.o_.O0. = True
			Me.oOO0oOOO.0_o0o. = True
			Me.o_.0OOOo_O00o. = True
			Me.o_00_o.OoO. = True
			Me.Timer = New System.Timers.Timer()
			Me.O_OO.OOO_OOO. = True
			Me.Ooo_Oo_O0.00O. = New Dictionary(Of String, List(Of String))()
			Me.Ooo_Oo_O0.00O. = New List(Of String)()
			Me.O0.o0. = False
			Me.Timer.Interval = 1000.0
			Me.Timer.Enabled = False
			Me.MainForm = OO_00oOO.BaseMainForm
			Me.o_O_.00_00. = Encoding.GetEncoding("gb2312")
		End Sub

		' Token: 0x06002616 RID: 9750 RVA: 0x00102DF2 File Offset: 0x00100FF2
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, Optional A_3 As Encoding = Nothing)
			Me.New()
			Me.O_O.O0oO. = A_0
			Me.o__0.0. = A_1
			Me.Oo_.00. = A_2
			If A_3 Is Nothing Then
				Me.o_O_.00_00. = Encoding.GetEncoding("gb2312")
				Return
			End If
			Me.o_O_.00_00. = A_3
		End Sub

		' Token: 0x06002617 RID: 9751 RVA: 0x00102E2C File Offset: 0x0010102C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub New(A_0 As String, A_1 As String, A_2 As String, A_3 As Integer, A_4 As Integer, Optional A_5 As Encoding = Nothing)
			Me.New()
			Me.O_O.O0oO. = A_0
			Me.o__0.0. = A_1
			Me.Oo_.00. = A_2
			Me.oO0_O._. = A_3
			Me.o__0.0. = A_4
			If A_5 Is Nothing Then
				Me.o_O_.00_00. = Encoding.GetEncoding("gb2312")
				Return
			End If
			Me.o_O_.00_00. = A_5
		End Sub

		' Token: 0x17000896 RID: 2198
		' (get) Token: 0x06002618 RID: 9752 RVA: 0x00102E81 File Offset: 0x00101081
		' (set) Token: 0x06002619 RID: 9753 RVA: 0x00102E8C File Offset: 0x0010108C
		Public Property Connected As Boolean
			Get
				Return Me.oOo.O00O__oO_.
			End Get
			Friend Set(value As Boolean)
				SyncLock Me
					If Me.oOo.O00O__oO_. <> value Then
						Me.oOo.O00O__oO_. = value
						Me.Timer.Enabled = value
						If Not value AndAlso Me.AsyncState <> Oo_0.OOoo0_OO__._o. AndAlso Me.Ooo_Oo_O0.00O. IsNot Nothing AndAlso Me.Ooo_Oo_O0.00O..IsAlive Then
							Me.Ooo_Oo_O0.00O..Abort()
						End If
					End If
				End SyncLock
			End Set
		End Property

		' Token: 0x17000897 RID: 2199
		' (get) Token: 0x0600261A RID: 9754 RVA: 0x00102F08 File Offset: 0x00101108
		' (set) Token: 0x0600261B RID: 9755 RVA: 0x00102F36 File Offset: 0x00101136
		Friend Property AsyncState As Oo_0
			Get
				Dim result As Oo_0
				If Me.Ooo_Oo_O0.00O. IsNot Nothing AndAlso Me.Ooo_Oo_O0.00O..IsAlive Then
					result = Oo_0.Oo_o_o.__oo.
				Else
					result = Me.oOo.O00O__oO_.
				End If
				Return result
			End Get
			Set(value As Oo_0)
				Me.oOo.O00O__oO_. = value
			End Set
		End Property

		' Token: 0x17000898 RID: 2200
		' (get) Token: 0x0600261C RID: 9756 RVA: 0x00102F3F File Offset: 0x0010113F
		' (set) Token: 0x0600261D RID: 9757 RVA: 0x00102F47 File Offset: 0x00101147
		Public Property Port As Integer
			Get
				Return Me.o__0.0.
			End Get
			Set(value As Integer)
				Me.o__0.0. = value
			End Set
		End Property

		' Token: 0x17000899 RID: 2201
		' (get) Token: 0x0600261E RID: 9758 RVA: 0x00102F50 File Offset: 0x00101150
		' (set) Token: 0x0600261F RID: 9759 RVA: 0x00102F58 File Offset: 0x00101158
		Public Property Timeout As Integer
			Get
				Return Me.oO0_O._.
			End Get
			Set(value As Integer)
				Me.oO0_O._. = value
			End Set
		End Property

		' Token: 0x1700089A RID: 2202
		' (get) Token: 0x06002620 RID: 9760 RVA: 0x00102F61 File Offset: 0x00101161
		' (set) Token: 0x06002621 RID: 9761 RVA: 0x00102F69 File Offset: 0x00101169
		Public Property Host As String
			Get
				Return Me.O_O.O0oO.
			End Get
			Set(value As String)
				Me.O_O.O0oO. = value
			End Set
		End Property

		' Token: 0x1700089B RID: 2203
		' (get) Token: 0x06002622 RID: 9762 RVA: 0x00102F72 File Offset: 0x00101172
		' (set) Token: 0x06002623 RID: 9763 RVA: 0x00102F7A File Offset: 0x0010117A
		Public Property Account As String
			Get
				Return Me.o__0.0.
			End Get
			Set(value As String)
				Me.o__0.0. = value
			End Set
		End Property

		' Token: 0x1700089C RID: 2204
		' (get) Token: 0x06002624 RID: 9764 RVA: 0x00102F83 File Offset: 0x00101183
		' (set) Token: 0x06002625 RID: 9765 RVA: 0x00102F8B File Offset: 0x0010118B
		Public Property Password As String
			Get
				Return Me.Oo_.00.
			End Get
			Set(value As String)
				Me.Oo_.00. = value
			End Set
		End Property

		' Token: 0x1700089D RID: 2205
		' (get) Token: 0x06002626 RID: 9766 RVA: 0x00102F94 File Offset: 0x00101194
		' (set) Token: 0x06002627 RID: 9767 RVA: 0x00102F9C File Offset: 0x0010119C
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BinaryMode As Boolean
			Get
				Return Me.OOO00.ooo0.
			End Get
			Set(value As Boolean)
				If Me.OOO00.ooo0. <> value Then
					If value Then
						Me.o0O_0_.00_oooo.("TYPE I")
					Else
						Me.o0O_0_.00_oooo.("TYPE A")
					End If
					If Me.oOo0_Oo.O_. <> 200 Then
						Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o IsNot Nothing Then
							ooO_00_o("二进制模式设置失败", Me.o.0OoOooo__.)
						End If
					End If
				End If
			End Set
		End Property

		' Token: 0x1700089E RID: 2206
		' (get) Token: 0x06002628 RID: 9768 RVA: 0x00102FF5 File Offset: 0x001011F5
		' (set) Token: 0x06002629 RID: 9769 RVA: 0x00103004 File Offset: 0x00101204
		Public Property UTF8 As Boolean
			Get
				Return Me.o_O_.00_00. Is Encoding.UTF8
			End Get
			Set(value As Boolean)
				If value Then
					Me.o_O_.00_00. = Encoding.UTF8
					Return
				End If
				Me.o_O_.00_00. = Encoding.GetEncoding("gb2312")
			End Set
		End Property

		' Token: 0x1700089F RID: 2207
		' (get) Token: 0x0600262A RID: 9770 RVA: 0x00103025 File Offset: 0x00101225
		' (set) Token: 0x0600262B RID: 9771 RVA: 0x0010302D File Offset: 0x0010122D
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property BufferSize As Integer
			Get
				Return Me.Ooo_Oo_O0.00O.
			End Get
			Set(value As Integer)
				If value < 512 Then
					value = 512
				End If
				Me.Ooo_Oo_O0.00O. = value
				Me.Ooo_Oo_O0.00O. = New Byte(Me.Ooo_Oo_O0.00O. + 1 - 1) {}
			End Set
		End Property

		' Token: 0x170008A0 RID: 2208
		' (get) Token: 0x0600262C RID: 9772 RVA: 0x00103058 File Offset: 0x00101258
		' (set) Token: 0x0600262D RID: 9773 RVA: 0x00103060 File Offset: 0x00101260
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property UploadBufferSize As Integer
			Get
				Return Me.OO0O00_0_._0.
			End Get
			Set(value As Integer)
				If value < 512 Then
					value = 512
				End If
				Me.OO0O00_0_._0. = value
				Me.OO0O00_0_._0. = New Byte(Me.OO0O00_0_._0. + 1 - 1) {}
			End Set
		End Property

		' Token: 0x170008A1 RID: 2209
		' (get) Token: 0x0600262E RID: 9774 RVA: 0x0010308B File Offset: 0x0010128B
		' (set) Token: 0x0600262F RID: 9775 RVA: 0x00103093 File Offset: 0x00101293
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property ShowUI As Boolean
			Get
				Return Me.Oo_.00.
			End Get
			Set(value As Boolean)
				Me.Oo_.00. = value
			End Set
		End Property

		' Token: 0x170008A2 RID: 2210
		' (get) Token: 0x06002630 RID: 9776 RVA: 0x0010309C File Offset: 0x0010129C
		' (set) Token: 0x06002631 RID: 9777 RVA: 0x001030A4 File Offset: 0x001012A4
		Public Property RootDir As String
			Get
				Return Me.O_O._oO_O_0oOo.
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 Then
					value = "/" + value.Trim(New Char() { "/"c }).Trim(New Char() { "\"c }) + "/"
					value = value.Replace("\", "/")
				End If
				Me.O_O._oO_O_0oOo. = value
				If Me.Connected Then
					Me.ChangeDir(value)
				End If
			End Set
		End Property

		' Token: 0x170008A3 RID: 2211
		' (get) Token: 0x06002632 RID: 9778 RVA: 0x0010311A File Offset: 0x0010131A
		' (set) Token: 0x06002633 RID: 9779 RVA: 0x00103122 File Offset: 0x00101322
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Property LocalDir As String
			Get
				Return Me.o_00_o.OoO.
			End Get
			Set(value As String)
				Me.o_00_o.OoO. = value
			End Set
		End Property

		' Token: 0x170008A4 RID: 2212
		' (get) Token: 0x06002634 RID: 9780 RVA: 0x0010312B File Offset: 0x0010132B
		' (set) Token: 0x06002635 RID: 9781 RVA: 0x00103133 File Offset: 0x00101333
		Public Property UploadEnabled As Boolean
			Get
				Return Me.o0O0.oo0O0.
			End Get
			Set(value As Boolean)
				Me.o0O0.oo0O0. = value
			End Set
		End Property

		' Token: 0x170008A5 RID: 2213
		' (get) Token: 0x06002636 RID: 9782 RVA: 0x0010313C File Offset: 0x0010133C
		' (set) Token: 0x06002637 RID: 9783 RVA: 0x00103144 File Offset: 0x00101344
		Public Property DownloadEnabled As Boolean
			Get
				Return Me.ooo_.O0___oO00.
			End Get
			Set(value As Boolean)
				Me.ooo_.O0___oO00. = value
			End Set
		End Property

		' Token: 0x170008A6 RID: 2214
		' (get) Token: 0x06002638 RID: 9784 RVA: 0x0010314D File Offset: 0x0010134D
		' (set) Token: 0x06002639 RID: 9785 RVA: 0x00103155 File Offset: 0x00101355
		Public Property RenameEnabled As Boolean
			Get
				Return Me.o_.O0.
			End Get
			Set(value As Boolean)
				Me.o_.O0. = value
			End Set
		End Property

		' Token: 0x170008A7 RID: 2215
		' (get) Token: 0x0600263A RID: 9786 RVA: 0x0010315E File Offset: 0x0010135E
		' (set) Token: 0x0600263B RID: 9787 RVA: 0x00103166 File Offset: 0x00101366
		Public Property DeleteEnabled As Boolean
			Get
				Return Me.oOO0oOOO.0_o0o.
			End Get
			Set(value As Boolean)
				Me.oOO0oOOO.0_o0o. = value
			End Set
		End Property

		' Token: 0x170008A8 RID: 2216
		' (get) Token: 0x0600263C RID: 9788 RVA: 0x0010316F File Offset: 0x0010136F
		' (set) Token: 0x0600263D RID: 9789 RVA: 0x00103177 File Offset: 0x00101377
		Public Property MakerDirEnabled As Boolean
			Get
				Return Me.o_.0OOOo_O00o.
			End Get
			Set(value As Boolean)
				Me.o_.0OOOo_O00o. = value
			End Set
		End Property

		' Token: 0x170008A9 RID: 2217
		' (get) Token: 0x0600263E RID: 9790 RVA: 0x00103180 File Offset: 0x00101380
		' (set) Token: 0x0600263F RID: 9791 RVA: 0x00103188 File Offset: 0x00101388
		Public Property OpenFileEnabled As Boolean
			Get
				Return Me.o_00_o.OoO.
			End Get
			Set(value As Boolean)
				Me.o_00_o.OoO. = value
			End Set
		End Property

		' Token: 0x06002640 RID: 9792 RVA: 0x00103194 File Offset: 0x00101394
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub OpenManager(ParamArray args As Object())
			Dim k As k2
			If args.Length = 0 Then
				k = New k2(Me, Me.RootDir)
			Else
				If args.Length <> 1 Then
					Return
				End If
				k = New k2(Me, Conversions.ToString(args(0)))
			End If
			k.Owner = OO_00oOO.BaseMainForm
			k.Show()
		End Sub

		' Token: 0x06002641 RID: 9793 RVA: 0x001031DB File Offset: 0x001013DB
		Public Sub OpenManager()
			New k2(Me, Me.RootDir).ShowDialog()
		End Sub

		' Token: 0x06002642 RID: 9794 RVA: 0x001031EF File Offset: 0x001013EF
		Public Sub OpenManager(Curdir As String)
			New k2(Me, Curdir).ShowDialog()
		End Sub

		' Token: 0x06002643 RID: 9795 RVA: 0x00103200 File Offset: 0x00101400
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function <<EMPTY_NAME>>(ParamArray A_0 As String()) As Object
			Dim list As List(Of String) = New List(Of String)()
			If A_0.Length = 0 Then
				list = Me.SelectFile()
			ElseIf A_0.Length = 1 Then
				list = Me.SelectFile(A_0(0))
			End If
			Dim result As Object
			If ooO.o.O_0000_O.() Then
				result = list.ToArray()
			Else
				result = list
			End If
			Return result
		End Function

		' Token: 0x06002644 RID: 9796 RVA: 0x00103244 File Offset: 0x00101444
		Public Function SelectFile() As List(Of String)
			Dim lz As lz = New lz(Me, "")
			Dim result As List(Of String)
			If lz.ShowDialog() = DialogResult.OK Then
				result = lz.OOOOo.o000.
			Else
				result = New List(Of String)()
			End If
			Return result
		End Function

		' Token: 0x06002645 RID: 9797 RVA: 0x00103278 File Offset: 0x00101478
		Public Function SelectFile(Curdir As String) As List(Of String)
			Dim lz As lz = New lz(Me, Curdir)
			Dim result As List(Of String)
			If lz.ShowDialog() = DialogResult.OK Then
				result = lz.OOOOo.o000.
			Else
				result = New List(Of String)()
			End If
			Return result
		End Function

		' Token: 0x06002646 RID: 9798 RVA: 0x001032A8 File Offset: 0x001014A8
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function <<EMPTY_NAME>>(ParamArray A_0 As String()) As String
			Dim result As String
			If A_0.Length = 0 Then
				result = Me.SelectFolder()
			ElseIf A_0.Length = 1 Then
				result = Me.SelectFolder(A_0(0))
			End If
			Return result
		End Function

		' Token: 0x06002647 RID: 9799 RVA: 0x001032D4 File Offset: 0x001014D4
		Public Function SelectFolder() As String
			Dim d As d0 = New d0(Me, "")
			Dim result As String
			If d.ShowDialog() = DialogResult.OK Then
				result = d.O0OO.o00O00o.
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06002648 RID: 9800 RVA: 0x00103308 File Offset: 0x00101508
		Public Function SelectFolder(Curdir As String) As String
			Dim d As d0 = New d0(Me, Curdir)
			Dim result As String
			If d.ShowDialog() = DialogResult.OK Then
				result = d.O0OO.o00O00o.
			Else
				result = ""
			End If
			Return result
		End Function

		' Token: 0x06002649 RID: 9801 RVA: 0x00103338 File Offset: 0x00101538
		Public Function Connect() As Boolean
			Dim result As Boolean
			If Me.Connected Then
				result = True
			Else
				Dim now As DateTime = DateTime.Now
				If Me.O_OO.OOO_OOO. Then
					Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO. IsNot Nothing Then
						o0OO._0OO.("正在连接服务器")
					End If
				End If
				Try
					Me.Ooo_Oo_O0.00O. = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
					Me.o_O.o_Oo0O_o0O. = Dns.GetHostAddresses(Me.O_O.O0oO.)(0)
					Me.o_O.o_Oo0O_o0O. = New IPEndPoint(Me.o_O.o_Oo0O_o0O., Me.o__0.0.)
					Me.Ooo_Oo_O0.00O..Connect(Me.o_O.o_Oo0O_o0O.)
					Me.Ooo_Oo_O0.00O..Blocking = True
					Me.Ooo_Oo_O0.00O..SendTimeout = 100000
					Me.Ooo_Oo_O0.00O..ReceiveTimeout = 10000
				Catch ex As Exception
					If Me.Ooo_Oo_O0.00O. IsNot Nothing AndAlso Me.Ooo_Oo_O0.00O..Connected Then
						Me.Ooo_Oo_O0.00O..Close()
					End If
					If Me.O_OO.OOO_OOO. Then
						Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o IsNot Nothing Then
							ooO_00_o("连接服务器失败", "")
						End If
					End If
					Return False
				End Try
				Me.Oo__O0._ooo0_o.()
				If Me.oOo0_Oo.O_. <> 220 Then
					Me.Close()
					If Me.O_OO.OOO_OOO. Then
						Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o2 IsNot Nothing Then
							ooO_00_o2("连接服务器失败", Me.o.0OoOooo__.)
						End If
					End If
					result = False
				Else
					If Me.O_OO.OOO_OOO. Then
						Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
						If o0OO._0OO.2 IsNot Nothing Then
							o0OO._0OO.2("传递用户名:" + Me.Account)
						End If
					End If
					Me.o0O_0_.00_oooo.("USER " + Me.o__0.0.)
					If Me.oOo0_Oo.O_. <> 331 AndAlso Me.oOo0_Oo.O_. <> 230 Then
						Me.O_O0Ooo_00.o.()
						If Me.O_OO.OOO_OOO. Then
							Dim ooO_00_o3 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
							If ooO_00_o3 IsNot Nothing Then
								ooO_00_o3("用户名无效", Me.o.0OoOooo__.)
							End If
						End If
						result = False
					Else
						If Me.O_OO.OOO_OOO. Then
							Dim o0OO._0OO.3 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
							If o0OO._0OO.3 IsNot Nothing Then
								o0OO._0OO.3("传递用户密码:******")
							End If
						End If
						If Me.oOo0_Oo.O_. <> 230 Then
							Me.o0O_0_.00_oooo.("PASS " + Me.Oo_.00., True)
							If Me.oOo0_Oo.O_. <> 230 AndAlso Me.oOo0_Oo.O_. <> 202 Then
								Me.O_O0Ooo_00.o.()
								If Me.O_OO.OOO_OOO. Then
									Dim ooO_00_o4 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
									If ooO_00_o4 IsNot Nothing Then
										ooO_00_o4("用户密码错误", Me.o.0OoOooo__.)
									End If
								End If
								Return False
							End If
						End If
						Me.o0O_0_.00_oooo.("TYPE I")
						If Me.oOo0_Oo.O_. <> 200 Then
							Dim ooO_00_o5 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
							If ooO_00_o5 IsNot Nothing Then
								ooO_00_o5("设置二进制传输模式失败", Me.o.0OoOooo__.)
							End If
							result = False
						Else
							Dim o0OO._0OO.4 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
							If o0OO._0OO.4 IsNot Nothing Then
								o0OO._0OO.4("设置二进制传输模式成功")
							End If
							Me.OOO00.ooo0. = True
							Me.Connected = True
							If Operators.CompareString(Me.RootDir, "", True) > 0 Then
								Me.ChangeDir(Me.RootDir)
							End If
							If Me.O_OO.OOO_OOO. Then
								Dim o0OO._0OO.5 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
								If o0OO._0OO.5 IsNot Nothing Then
									o0OO._0OO.5("服务器连接成功,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now))
								End If
							End If
							Dim oooO_O0O_0_O As FTPClient.OooO_O0O_0_O = Me.o_O.o_Oo0O_o0O.
							If oooO_O0O_0_O IsNot Nothing Then
								oooO_O0O_0_O()
							End If
							result = True
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0600264A RID: 9802 RVA: 0x0010368C File Offset: 0x0010188C
		Public Sub Close()
			Me.Connected = False
			If Me.O_OO.OOO_OOO. Then
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在断开服务器")
				End If
			End If
			If Me.Ooo_Oo_O0.00O. IsNot Nothing Then
				Me.o0O_0_.00_oooo.("QUIT")
			End If
			Me.O_O0Ooo_00.o.()
		End Sub

		' Token: 0x0600264B RID: 9803 RVA: 0x001036D8 File Offset: 0x001018D8
		Public Function GetFileList(Optional path As String = "*.*") As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim result As List(Of String)
			If Not Me.Connect() Then
				result = list
			Else
				Dim now As DateTime = DateTime.Now
				Dim array As Byte() = Nothing
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在列表文件")
				End If
				Dim socket As Socket = Me.O_O_0_O0.oOO.()
				Me.o0O_0_.00_oooo.("NLST " + path)
				If Me.oOo0_Oo.O_. <> 150 AndAlso Me.oOo0_Oo.O_. <> 125 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("列表文件失败", Me.o.0OoOooo__.)
					End If
					result = list
				Else
					Me.OOOoO___.O0ooo. = ""
					Dim t As DateTime = DateTime.Now.AddSeconds(CDbl(Me.oO0_O._.))
					While DateTime.Compare(t, DateTime.Now) > 0
						Dim num As Integer = socket.Receive(Me.Ooo_Oo_O0.00O., Me.Ooo_Oo_O0.00O..Length, SocketFlags.None)
						If num > 0 Then
							If array Is Nothing Then
								array = New Byte(num - 1 + 1 - 1) {}
								Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, 0, num)
							Else
								Dim destinationIndex As Integer = array.Length
								array = CType(Utils.CopyArray(array, New Byte(array.Length - 1 + num + 1 - 1) {}), Byte())
								Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, destinationIndex, num)
							End If
						End If
						If num <= 0 Then
							Exit While
						End If
					End While
					If array IsNot Nothing Then
						Me.OOOoO___.O0ooo. = Me.o_O_.00_00..GetString(array)
					End If
					Dim collection As String() = Me.OOOoO___.O0ooo..Replace(vbCr, "").Split(New Char() { vbLf }, StringSplitOptions.RemoveEmptyEntries)
					socket.Close()
					Me.Oo__O0._ooo0_o.()
					If Me.oOo0_Oo.O_. <> 226 OrElse Operators.CompareString(Me.OOOoO___.O0ooo., "", True) = 0 Then
						collection = New String(-1) {}
					End If
					Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.2 IsNot Nothing Then
						o0OO._0OO.2("列表文件完成,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now) + "...")
					End If
					list.AddRange(collection)
					For i As Integer = list.Count - 1 To 0 Step -1
						If list(i).IndexOf(".") < 0 Then
							list.RemoveAt(i)
						End If
					Next
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x0600264C RID: 9804 RVA: 0x001038FC File Offset: 0x00101AFC
		Public Function GetDirList(Optional path As String = "") As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim list2 As List(Of String) = New List(Of String)()
			list = Me.GetDetailList(path)
			Try
				For Each text As String In list
					If text.EndsWith("*D") Then
						text = text.Substring(0, text.IndexOf("*"))
						list2.Add(text)
					End If
				Next
			Finally
				Dim enumerator As List(Of String).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return list2
		End Function

		' Token: 0x0600264D RID: 9805 RVA: 0x00103980 File Offset: 0x00101B80
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetDirectoryList(Optional pth As String = "") As List(Of String)
			Return Me.GetDirList(pth)
		End Function

		' Token: 0x0600264E RID: 9806 RVA: 0x0010398C File Offset: 0x00101B8C
		Public Function GetDetailList(Optional path As String = "") As List(Of String)
			Dim list As List(Of String) = New List(Of String)()
			Dim result As List(Of String)
			If Not Me.Connect() Then
				result = list
			Else
				Dim now As DateTime = DateTime.Now
				Dim array As Byte() = Nothing
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在列表")
				End If
				Dim socket As Socket = Me.O_O_0_O0.oOO.()
				If Operators.CompareString(path, "", True) = 0 Then
					Me.o0O_0_.00_oooo.("LIST")
				Else
					Me.o0O_0_.00_oooo.("LIST " + path)
				End If
				If Me.oOo0_Oo.O_. <> 150 AndAlso Me.oOo0_Oo.O_. <> 125 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("列表失败", Me.o.0OoOooo__.)
					End If
					result = list
				Else
					Me.OOOoO___.O0ooo. = ""
					Dim t As DateTime = DateTime.Now.AddSeconds(CDbl(Me.oO0_O._.))
					While DateTime.Compare(t, DateTime.Now) > 0
						Dim num As Integer = socket.Receive(Me.Ooo_Oo_O0.00O., Me.Ooo_Oo_O0.00O..Length, SocketFlags.None)
						If num > 0 Then
							If array Is Nothing Then
								array = New Byte(num - 1 + 1 - 1) {}
								Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, 0, num)
							Else
								Dim destinationIndex As Integer = array.Length
								array = CType(Utils.CopyArray(array, New Byte(array.Length - 1 + num + 1 - 1) {}), Byte())
								Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, destinationIndex, num)
							End If
						End If
						If num <= 0 Then
							Exit While
						End If
					End While
					If array IsNot Nothing Then
						Me.OOOoO___.O0ooo. = Me.o_O_.00_00..GetString(array)
					End If
					Dim array2 As String() = Me.OOOoO___.O0ooo..Split(New Char() { vbLf })
					socket.Close()
					Me.Oo__O0._ooo0_o.()
					If Me.oOo0_Oo.O_. <> 226 Then
						array2 = New String(-1) {}
					End If
					Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.2 IsNot Nothing Then
						o0OO._0OO.2("列表结束,用时:" + O_O0OO.OoO_00._.(DateTime.Now - now) + "...")
					End If
					For Each text As String In array2
						text = text.Trim(New Char() { vbLf, vbCr })
						If text.Length >= 5 Then
							Dim array4 As String() = text.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries)
							If Versioned.IsNumeric(text.Substring(0, 2)) Then
								If array4.Length >= 4 Then
									Dim c As Char = array4(0).Substring(2, 1)(0)
									Dim array5 As String() = array4(0).Split(New Char() { c })
									Dim num2 As Integer = Conversions.ToInteger(array5(2))
									If num2 <= 29 Then
										num2 += 2000
									ElseIf num2 < 100 Then
										num2 += 1900
									End If
									array4(0) = String.Concat(New String() { array5(0), "/", array5(1), "/", Conversions.ToString(num2) })
									Dim value As DateTime
									DateTime.TryParse(array4(0) + " " + array4(1), value)
									If array4.Length > 4 Then
										Dim num3 As Integer = text.LastIndexOf(array4(2)) + array4(2).Length
										array4(3) = text.Substring(num3 + 1).Trim()
									End If
									list.Add(String.Concat(New String() { array4(3), "*", Conversions.ToString(value), "*", Interaction.IIf(Operators.CompareString(array4(2), "<DIR>", True) = 0, "D", array4(2)).ToString() }))
								End If
							ElseIf array4.Length >= 8 Then
								array4(8) = array4(8).Trim(New Char() { vbCr })
								If Operators.CompareString(array4(8), ".", True) <> 0 AndAlso Operators.CompareString(array4(8), "..", True) <> 0 Then
									If array4.Length > 9 Then
										Dim num4 As Integer = text.LastIndexOf(array4(7)) + array4(7).Length
										array4(8) = text.Substring(num4 + 1).Trim()
									End If
									Dim text2 As String = ""
									Dim dateTime As DateTime
									If Not Versioned.IsNumeric(array4(7)) Then
										text2 = " " + array4(7)
										array4(7) = DateTime.Today.Year.ToString()
										DateTime.TryParse(String.Concat(New String() { array4(5), ",", array4(6), ",", array4(7), text2 }), dateTime)
										If DateTime.Compare(dateTime, DateTime.Now) > 0 Then
											dateTime = dateTime.AddYears(-1)
										End If
									Else
										DateTime.TryParse(String.Concat(New String() { array4(5), ",", array4(6), ",", array4(7), text2 }), dateTime)
									End If
									list.Add(String.Concat(New String() { array4(8), "*", Conversions.ToString(dateTime), "*", Interaction.IIf(Operators.CompareString(array4(0).Substring(0, 1), "D", True) = 0, "D", array4(4)).ToString() }))
								End If
							End If
						End If
					Next
					If Me.Ooo_Oo_O0.00O..ContainsKey(Me.CurrentDir) Then
						Me.Ooo_Oo_O0.00O..Remove(Me.CurrentDir)
					End If
					Me.Ooo_Oo_O0.00O..Add(Me.CurrentDir, list)
					result = list
				End If
			End If
			Return result
		End Function

		' Token: 0x0600264F RID: 9807 RVA: 0x00103F0C File Offset: 0x0010210C
		Public Function GetFileSize(fileName As String) As Long
			Dim result As Long
			If Not Me.Connect() Then
				result = 0L
			Else
				Me.o0O_0_.00_oooo.("SIZE " + fileName)
				Dim num As Long = 0L
				If Me.oOo0_Oo.O_. = 213 Then
					num = Long.Parse(Me.o.0OoOooo__..Split(New Char() { " "c })(1))
				Else
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("获取文件大小失败", Me.o.0OoOooo__.)
					End If
				End If
				result = num
			End If
			Return result
		End Function

		' Token: 0x06002650 RID: 9808 RVA: 0x00103F88 File Offset: 0x00102188
		Public Function GetFileTime(fileName As String) As DateTime
			Dim result As DateTime
			If Not Me.Connect() Then
				result = Nothing
			Else
				Me.o0O_0_.00_oooo.("MDTM " + fileName)
				If Me.oOo0_Oo.O_. <> 213 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("获取文件时间失败", Me.o.0OoOooo__.)
					End If
					result = Nothing
				Else
					Dim text As String = Me.o.0OoOooo__.
					If text.IndexOf(" ") > 0 Then
						text = text.Substring(text.IndexOf(" ") + 1)
					End If
					If text.IndexOf(".") > 0 Then
						text.Substring(0, text.IndexOf("."))
					End If
					text = text.Trim(New Char() { vbCr, vbLf })
					If text.Length >= 14 Then
						text = String.Concat(New String() { text.Substring(4, 2), "/", text.Substring(6, 2), "/", text.Substring(0, 4), " ", text.Substring(8, 2), ":", text.Substring(10, 2), ":", text.Substring(12, 2) })
					End If
					Dim dateTime As DateTime
					DateTime.TryParse(text, dateTime)
					dateTime = dateTime.AddHours(CDbl(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours))
					result = dateTime
				End If
			End If
			Return result
		End Function

		' Token: 0x06002651 RID: 9809 RVA: 0x00104103 File Offset: 0x00102303
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function GetFileDate(fileName As String) As DateTime
			Return Me.GetFileTime(fileName)
		End Function

		' Token: 0x06002652 RID: 9810 RVA: 0x0010410C File Offset: 0x0010230C
		Friend Sub <<EMPTY_NAME>>()
			If Me.AsyncState = Oo_0.Oo_o_o.__oo. Then
				Me.AsyncState = Oo_0.oO00o0._OoO00o.
			End If
		End Sub

		' Token: 0x06002653 RID: 9811 RVA: 0x00104120 File Offset: 0x00102320
		Public Function Download(ParamArray args As Object()) As Boolean
			Dim result As Boolean
			If args.Length = 2 Then
				result = Me.Download(Conversions.ToString(args(0)), Conversions.ToString(args(1)), False)
			Else
				result = (args.Length = 3 AndAlso Me.Download(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2))))
			End If
			Return result
		End Function

		' Token: 0x06002654 RID: 9812 RVA: 0x00104178 File Offset: 0x00102378
		Public Function Download(remFileName As String, locFileName As String, Optional ShowUI As Boolean = False) As Boolean
			Dim result As Boolean
			If O_O0OO.oO_00Ooo___0._..Contains(remFileName.ToLower()) Then
				MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				result = False
			Else
				Dim parentPath As String = OO_00oOO.FileSys.GetParentPath(locFileName)
				If Not OO_00oOO.FileSys.DirectoryExists(parentPath) Then
					OO_00oOO.FileSys.CreateDirectory(parentPath)
				End If
				If Not ShowUI Then
					result = Me.oo0000O.Oo0OO.(remFileName, locFileName, False)
				Else
					result = (New O\u3000O\u3000(Me, remFileName, locFileName).ShowDialog() = DialogResult.OK)
				End If
			End If
			Return result
		End Function

		' Token: 0x06002655 RID: 9813 RVA: 0x001041F8 File Offset: 0x001023F8
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			Dim parameter As FTPClient.oO__oo_00O0o_ = New FTPClient.oO__oo_00O0o_(A_0, A_1, A_2)
			Me.Ooo_Oo_O0.00O. = AddressOf Me.O_O0Ooo_00.o.
			Me.Ooo_Oo_O0.00O..Start(parameter)
		End Sub

		' Token: 0x06002656 RID: 9814 RVA: 0x00104234 File Offset: 0x00102434
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim oO__oo_00O0o_ As FTPClient.oO__oo_00O0o_ = CType(A_0, FTPClient.oO__oo_00O0o_)
			Me.oo0000O.Oo0OO.(oO__oo_00O0o_.oo_o0.ooo_oO., oO__oo_00O0o_.OO0O00_0_._0., oO__oo_00O0o_.oo_o0.ooo_oO.)
		End Sub

		' Token: 0x06002657 RID: 9815 RVA: 0x00104264 File Offset: 0x00102464
		Private Sub UpLoadAsync1(p As Object)
			Dim o_o_oo As FTPClient.o_o_oo0 = CType(p, FTPClient.o_o_oo0)
			Me.OOO00.ooo0.(o_o_oo.oo_o0.ooo_oO., o_o_oo.oO.o___., o_o_oo.oo_o0.ooo_oO.)
		End Sub

		' Token: 0x06002658 RID: 9816 RVA: 0x00104294 File Offset: 0x00102494
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean)
			Dim parameter As FTPClient.o_o_oo0 = New FTPClient.o_o_oo0(A_0, A_1, A_2)
			Me.Ooo_Oo_O0.00O. = AddressOf Me.UpLoadAsync1
			Me.Ooo_Oo_O0.00O..Start(parameter)
		End Sub

		' Token: 0x06002659 RID: 9817 RVA: 0x001042D0 File Offset: 0x001024D0
		Private Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean) As Boolean
			Dim flag As Boolean
			If Not Me.Connect() Then
				flag = False
			Else
				Me.AsyncState = Oo_0.Oo_o_o.__oo.
				Dim fileStream As FileStream = Nothing
				Dim socket As Socket = Nothing
				Dim text As String = A_1 + ".fxdlif"
				Dim a_ As Boolean = False
				Try
					If Not A_2 AndAlso OO_00oOO.FileSys.FileExists(text) Then
						If Me.Ooo_Oo_O0.00O..Contains(A_0.ToLower()) Then
							A_2 = True
						Else
							OO_00oOO.FileSys.DeleteFile(text)
						End If
					End If
					Dim now As DateTime = DateTime.Now
					Dim fileSize As Long = Me.GetFileSize(A_0)
					Dim num As Long = 0L
					Dim flag2 As Boolean = False
					If fileSize = 0L Then
						Me.GetFileSize(A_0)
						If fileSize = 0L Then
							Using File.Create(A_1)
							End Using
							Dim ooo_Oo_O0.00O. As FTPClient.oO_o_0OOo__0 = Me.Ooo_Oo_O0.00O.
							If ooo_Oo_O0.00O. IsNot Nothing Then
								ooo_Oo_O0.00O.(A_0)
							End If
							Return True
						End If
					End If
					Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO. IsNot Nothing Then
						o0OO._0OO.("正在下载文件[" + OO_00oOO.FileSys.GetName(A_0) + "]...")
					End If
					Me.BinaryMode = True
					If Not File.Exists(text) Then
						fileStream = File.Create(text)
					Else
						Dim fileInfo As FileInfo = New FileInfo(text)
						If fileInfo.Length > fileSize AndAlso A_2 Then
							OO_00oOO.FileSys.DeleteFile(text)
							fileStream = File.Create(text)
						Else
							If fileInfo.Length = fileSize AndAlso A_2 Then
								If OO_00oOO.FileSys.FileExists(A_1) Then
									OO_00oOO.FileSys.DeleteFile(A_1)
								End If
								OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(A_1))
								Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
								If o0OO._0OO.2 IsNot Nothing Then
									o0OO._0OO.2("[" + OO_00oOO.FileSys.GetName(A_0) + "]下载完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now))
								End If
								Dim ooo_Oo_O0.00O.2 As FTPClient.oO_o_0OOo__0 = Me.Ooo_Oo_O0.00O.
								If ooo_Oo_O0.00O.2 IsNot Nothing Then
									ooo_Oo_O0.00O.2(A_0)
								End If
								Return True
							End If
							fileStream = New FileStream(text, FileMode.Open)
						End If
					End If
					socket = Me.O_O_0_O0.oOO.()
					socket.ReceiveTimeout = 15000
					socket.SendTimeout = 15000
					socket.Blocking = True
					Dim num2 As Long = 0L
					If A_2 Then
						num2 = fileStream.Length
						If num2 > 0L Then
							Me.o0O_0_.00_oooo.("REST " + Conversions.ToString(num2))
							If Me.oOo0_Oo.O_. <> 350 Then
								num2 = 0L
							Else
								fileStream.Seek(num2, SeekOrigin.Begin)
							End If
						End If
					End If
					Me.o0O_0_.00_oooo.("RETR " + A_0)
					If Me.oOo0_Oo.O_. <> 150 AndAlso Me.oOo0_Oo.O_. <> 125 Then
						Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o IsNot Nothing Then
							ooO_00_o("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败", Me.o.0OoOooo__.)
						End If
						If Me.oOo0_Oo.O_. = 550 Then
							Me.GetFileList("*.xxx")
						End If
						flag = False
					Else
						If Not Me.Ooo_Oo_O0.00O..Contains(A_0.ToLower()) Then
							Me.Ooo_Oo_O0.00O..Add(A_0.ToLower())
						End If
						While True
							Me.o.oo000oOoo. = socket.Receive(Me.Ooo_Oo_O0.00O., Me.Ooo_Oo_O0.00O..Length, SocketFlags.None)
							fileStream.Write(Me.Ooo_Oo_O0.00O., 0, Me.o.oo000oOoo.)
							Me.o_O.o_Oo0O_o0O. = DateTime.Now
							a_ = True
							If Me.o.oo000oOoo. <= 0 Then
								Exit For
							End If
							num += CLng(Me.o.oo000oOoo.)
							Dim now2 As DateTime
							If(DateTime.Now - now2).TotalSeconds >= 0.5 Then
								Dim ooo_Oo_O0.00O.3 As FTPClient.o0O_O00o_0_o = Me.Ooo_Oo_O0.00O.
								If ooo_Oo_O0.00O.3 IsNot Nothing Then
									ooo_Oo_O0.00O.3(A_0, fileSize, num2, num, DateTime.Now - now)
								End If
								now2 = DateTime.Now
							End If
							If Me.oOo.O00O__oO_. = Oo_0.oO00o0._OoO00o. Then
								GoTo IL_38A
							End If
						End While
						flag2 = True
						a_ = False
						IL_38A:
						fileStream.Close()
						If socket.Connected Then
							socket.Close()
						End If
						If Not flag2 Then
							Me.Oo__O0._ooo0_o.()
							Dim o0OO._0OO.3 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
							If o0OO._0OO.3 IsNot Nothing Then
								o0OO._0OO.3("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败，用户取消...")
							End If
							flag = False
						Else
							Me.Oo__O0._ooo0_o.()
							If Me.oOo0_Oo.O_. <> 226 AndAlso Me.oOo0_Oo.O_. <> 250 Then
								Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
								If ooO_00_o2 IsNot Nothing Then
									ooO_00_o2("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]下载失败", Me.o.0OoOooo__.)
								End If
								flag = False
							Else
								flag = True
								If Me.Ooo_Oo_O0.00O..Contains(A_0.ToLower()) Then
									Me.Ooo_Oo_O0.00O..Remove(A_0.ToLower())
								End If
								Dim o0OO._0OO.4 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
								If o0OO._0OO.4 IsNot Nothing Then
									o0OO._0OO.4("[" + OO_00oOO.FileSys.GetName(A_0) + "]下载完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now))
								End If
								If OO_00oOO.FileSys.FileExists(A_1) Then
									OO_00oOO.FileSys.DeleteFile(A_1)
								End If
								OO_00oOO.FileSys.RenameFile(text, OO_00oOO.FileSys.GetName(A_1))
								Dim ooo_Oo_O0.00O.4 As FTPClient.oO_o_0OOo__0 = Me.Ooo_Oo_O0.00O.
								If ooo_Oo_O0.00O.4 IsNot Nothing Then
									ooo_Oo_O0.00O.4(A_0)
								End If
								If A_1.StartsWith(OO_00oOO.ProjectPath + "RemoteFiles\", StringComparison.InvariantCulture) Then
									Me.o0O_0_.00_oooo.("MDTM " + A_0)
									If Me.oOo0_Oo.O_. = 213 Then
										Dim text2 As String = Me.o.0OoOooo__.
										If text2.IndexOf(" ") > 0 Then
											text2 = text2.Substring(text2.IndexOf(" ") + 1)
											text2 = text2.Trim(New Char() { vbCr, vbLf })
											Dim fileInfo2 As FileInfo = New FileInfo(A_1)
											Oo00.o0_o._O_.(A_0, text2, fileSize.ToString(), fileInfo2.LastWriteTime.Ticks.ToString())
										End If
									End If
								End If
							End If
						End If
					End If
				Catch ex As Exception
					If TypeOf ex Is SocketException OrElse TypeOf ex Is ThreadAbortException Then
						If socket IsNot Nothing AndAlso socket.Connected Then
							socket.Close()
						End If
						If Not Me.Ooo_Oo_O0.00O..Contains(A_0.ToLower()) Then
							Me.Ooo_Oo_O0.00O..Add(A_0.ToLower())
						End If
					Else
						Me.Connected = False
					End If
					Dim o0OO._0OO.5 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.5 IsNot Nothing Then
						o0OO._0OO.5(ex.Message)
					End If
					flag = False
				Finally
					If fileStream IsNot Nothing Then
						fileStream.Close()
					End If
					Me.AsyncState = Oo_0.OOoo0_OO__._o.
					If Not flag Then
						Dim ooo_Oo_O0.00O.5 As FTPClient.O__0O000__Oo = Me.Ooo_Oo_O0.00O.
						If ooo_Oo_O0.00O.5 IsNot Nothing Then
							ooo_Oo_O0.00O.5(A_0, a_)
						End If
					End If
				End Try
			End If
			Return flag
		End Function

		' Token: 0x0600265A RID: 9818 RVA: 0x00104964 File Offset: 0x00102B64
		Friend Sub <<EMPTY_NAME>>(A_0 As String, A_1 As String)
			Dim parameter As FTPClient.Oo___Ooo_ = New FTPClient.Oo___Ooo_(A_0, A_1)
			Me.Ooo_Oo_O0.00O. = AddressOf Me.O_O_0_O0.oOO.
			Me.Ooo_Oo_O0.00O..Start(parameter)
		End Sub

		' Token: 0x0600265B RID: 9819 RVA: 0x0010499C File Offset: 0x00102B9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Dim oo___Ooo_ As FTPClient.Oo___Ooo_ = CType(A_0, FTPClient.Oo___Ooo_)
			Me.O_O_0_O0.oOO.(oo___Ooo_.O0OO._0OO., oo___Ooo_.OO0O00_0_._0.)
		End Sub

		' Token: 0x0600265C RID: 9820 RVA: 0x001049C8 File Offset: 0x00102BC8
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String) As Boolean
			Try
				Me.AsyncState = Oo_0.Oo_o_o.__oo.
				If Me.oOo.O00O__oO_. Is Nothing Then
					Interlocked.CompareExchange(Of StaticLocalInitFlag)(Me.oOo.O00O__oO_., New StaticLocalInitFlag(), Nothing)
				End If
				Dim flag As Boolean = False
				Try
					Monitor.Enter(Me.oOo.O00O__oO_., flag)
					If Me.oOo.O00O__oO_..State = 0S Then
						Me.oOo.O00O__oO_..State = 2S
						Me.oOo.O00O__oO_. = Nothing
					ElseIf Me.oOo.O00O__oO_..State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.oOo.O00O__oO_..State = 1S
					If flag Then
						Monitor.[Exit](Me.oOo.O00O__oO_.)
					End If
				End Try
				Dim dataTable As DataTable = New DataTable()
				Dim fileInfo As FileInfo = New FileInfo(A_1)
				If Operators.CompareString(Me.O00.O_oo., OO_00oOO.ProjectFile, True) <> 0 OrElse Me.oOo.O00O__oO_. Is Nothing Then
					Me.O00.O_oo. = OO_00oOO.ProjectFile
					Dim text As String = OO_00oOO.ProjectPath + "RemoteFiles\_foxdownloadinfo.mdb"
					If Not OO_00oOO.FileSys.FileExists(text) Then
						Dim oo__ As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
						If oo__ IsNot Nothing Then
							oo__(A_0, A_1, False)
						End If
						Return False
					End If
					Me.oOo.O00O__oO_. = New OleDbConnection(Oo00.o_._0OOo.(text))
					Me.oOo.O00O__oO_. = New OleDbDataAdapter("", Me.oOo.O00O__oO_.)
				End If
				Me.oOo.O00O__oO_..SelectCommand.CommandText = "Select * From [Files] Where [remfile] = '" + A_0 + "'"
				Me.oOo.O00O__oO_..Fill(dataTable)
				If dataTable.Rows.Count = 0 Then
					Dim oo__2 As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
					If oo__2 IsNot Nothing Then
						oo__2(A_0, A_1, False)
					End If
					Return False
				End If
				Dim dataRow As DataRow = dataTable.Rows(0)
				Dim text2 As String = ""
				Dim right As String = Me.GetFileSize(A_0).ToString()
				Me.o0O_0_.00_oooo.("MDTM " + A_0)
				If Me.oOo0_Oo.O_. = 213 Then
					text2 = Me.o.0OoOooo__.
					If text2.IndexOf(" ") > 0 Then
						text2 = text2.Substring(text2.IndexOf(" ") + 1)
						text2 = text2.Trim(New Char() { vbCr, vbLf })
					End If
				End If
				If Operators.CompareString(dataRow("remtime").ToString(), text2, True) = 0 AndAlso Operators.CompareString(dataRow("remsize").ToString(), right, True) = 0 AndAlso Operators.CompareString(fileInfo.Length.ToString(), right, True) = 0 AndAlso Operators.CompareString(dataRow("loctime").ToString(), fileInfo.LastWriteTime.Ticks.ToString(), True) = 0 Then
					Dim oo__3 As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
					If oo__3 IsNot Nothing Then
						oo__3(A_0, A_1, True)
					End If
					Return True
				End If
			Catch ex As Exception
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.(ex.Message)
				End If
			Finally
				Me.AsyncState = Oo_0.OOoo0_OO__._o.
			End Try
			Dim oo__4 As FTPClient.Oo__ = Me.o_O.o_Oo0O_o0O.
			If oo__4 IsNot Nothing Then
				oo__4(A_0, A_1, False)
			End If
			Return False
		End Function

		' Token: 0x0600265D RID: 9821 RVA: 0x00104D04 File Offset: 0x00102F04
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Upload(ParamArray args As Object()) As Boolean
			Dim result As Boolean
			If args.Length = 1 Then
				result = Me.Upload(Conversions.ToString(args(0)))
			ElseIf args.Length = 2 Then
				result = Me.Upload(Conversions.ToString(args(0)), Conversions.ToString(args(1)), False)
			Else
				result = (args.Length = 3 AndAlso Me.Upload(Conversions.ToString(args(0)), Conversions.ToString(args(1)), Conversions.ToBoolean(args(2))))
			End If
			Return result
		End Function

		' Token: 0x0600265E RID: 9822 RVA: 0x00104D72 File Offset: 0x00102F72
		Public Function Upload(locfileName As String) As Boolean
			Return Me.oOo.O00O__oO_.(locfileName, False)
		End Function

		' Token: 0x0600265F RID: 9823 RVA: 0x00104D7C File Offset: 0x00102F7C
		Public Function Upload(locfileName As String, remFileName As String, Optional ShowUI As Boolean = False) As Boolean
			Dim result As Boolean
			If Not ShowUI Then
				result = Me.OOO00.ooo0.(locfileName, remFileName, False)
			Else
				result = (New o\u3002\u3000\u3002\u3002\u3000(Me, locfileName, remFileName).ShowDialog() = DialogResult.OK)
			End If
			Return result
		End Function

		' Token: 0x06002660 RID: 9824 RVA: 0x00104DB0 File Offset: 0x00102FB0
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean) As Boolean
			Dim a_ As String = Me.CurrentDir.TrimEnd(New Char() { "/"c }) + "/" + OO_00oOO.FileSys.GetName(A_0)
			Return Me.OOO00.ooo0.(A_0, a_, A_1)
		End Function

		' Token: 0x06002661 RID: 9825 RVA: 0x00104DF4 File Offset: 0x00102FF4
		Friend Function <<EMPTY_NAME>>(A_0 As String, A_1 As String, A_2 As Boolean) As Boolean
			Dim flag As Boolean
			If Not Me.Connect() Then
				flag = False
			ElseIf OO_00oOO.FileIsOpened(A_0) Then
				MessageBox.Show("文件已经被打开，无法上传！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				flag = False
			Else
				Me.AsyncState = Oo_0.Oo_o_o.__oo.
				Dim fileStream As FileStream = New FileStream(A_0, FileMode.Open, FileAccess.Read)
				Dim socket As Socket = Nothing
				Try
					Dim num As Long = 0L
					Dim num2 As Long = 0L
					If A_2 Then
						Try
							Me.BinaryMode = True
							If Me.FileExists(A_1) Then
								num = Me.GetFileSize(A_1)
							End If
						Catch ex As Exception
							num = 0L
						End Try
					End If
					If A_2 AndAlso fileStream.Length < num Then
						num = 0L
					ElseIf A_2 AndAlso fileStream.Length = num Then
						fileStream.Close()
						Return False
					End If
					Dim now As DateTime = DateTime.Now
					Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO. IsNot Nothing Then
						o0OO._0OO.("正在上传文件[" + OO_00oOO.FileSys.GetName(A_0) + "]")
					End If
					socket = Me.O_O_0_O0.oOO.()
					socket.ReceiveTimeout = 15000
					socket.SendTimeout = 15000
					socket.Blocking = True
					If num > 0L Then
						Me.o0O_0_.00_oooo.("REST " + Conversions.ToString(num))
						If Me.oOo0_Oo.O_. <> 350 Then
							num = 0L
						End If
					End If
					Me.o0O_0_.00_oooo.("STOR " + A_1)
					If Me.oOo0_Oo.O_. <> 125 AndAlso Me.oOo0_Oo.O_. <> 150 Then
						Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o IsNot Nothing Then
							ooO_00_o("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败", Me.o.0OoOooo__.)
						End If
						If Me.oOo0_Oo.O_. = 550 Then
							Me.GetFileList("*.xxx")
						End If
						flag = False
					Else
						If num <> 0L Then
							fileStream.Seek(num, SeekOrigin.Begin)
						End If
						Me.o.oo000oOoo. = fileStream.Read(Me.OO0O00_0_._0., 0, Me.OO0O00_0_._0..Length)
						While Me.o.oo000oOoo. > 0
							socket.Send(Me.OO0O00_0_._0., Me.o.oo000oOoo., SocketFlags.None)
							Me.o.oo000oOoo. = fileStream.Read(Me.OO0O00_0_._0., 0, Me.OO0O00_0_._0..Length)
							Me.o_O.o_Oo0O_o0O. = DateTime.Now
							If Me.oOo.O00O__oO_. = Oo_0.oO00o0._OoO00o. Then
								Exit While
							End If
							num2 += CLng(Me.o.oo000oOoo.)
							Dim now2 As DateTime
							If(DateTime.Now - now2).TotalSeconds >= 0.5 Then
								Dim o0OO._0OO.2 As FTPClient.o0_O_0_0 = Me.O0OO._0OO.
								If o0OO._0OO.2 IsNot Nothing Then
									o0OO._0OO.2(A_0, fileStream.Length, num, num2, DateTime.Now - now)
								End If
								now2 = DateTime.Now
							End If
						End While
						fileStream.Close()
						If socket.Connected Then
							socket.Close()
						End If
						If Me.AsyncState = Oo_0.oO00o0._OoO00o. Then
							Me.Oo__O0._ooo0_o.()
							Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
							If ooO_00_o2 IsNot Nothing Then
								ooO_00_o2("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败，用户取消...", Me.o.0OoOooo__.)
							End If
							flag = False
						Else
							Me.Oo__O0._ooo0_o.()
							If Me.oOo0_Oo.O_. <> 226 AndAlso Me.oOo0_Oo.O_. <> 250 Then
								Dim ooO_00_o3 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
								If ooO_00_o3 IsNot Nothing Then
									ooO_00_o3("文件[" + OO_00oOO.FileSys.GetName(A_0) + "]上传失败", Me.o.0OoOooo__.)
								End If
								flag = False
							Else
								Dim o0OO._0OO.3 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
								If o0OO._0OO.3 IsNot Nothing Then
									o0OO._0OO.3(OO_00oOO.FileSys.GetName(A_0) + " 上传完成，用时" + O_O0OO.OoO_00._.(DateTime.Now - now))
								End If
								Dim o0OO._0OO.4 As FTPClient.oO___ = Me.O0OO._0OO.
								If o0OO._0OO.4 IsNot Nothing Then
									o0OO._0OO.4(A_0, A_1)
								End If
								flag = True
							End If
						End If
					End If
				Catch ex2 As Exception
					If(TypeOf ex2 Is SocketException OrElse TypeOf ex2 Is ThreadAbortException) AndAlso socket IsNot Nothing AndAlso socket.Connected Then
						socket.Close()
					End If
					Dim o0OO._0OO.5 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.5 IsNot Nothing Then
						o0OO._0OO.5(ex2.Message)
					End If
					flag = False
				Finally
					If fileStream IsNot Nothing Then
						fileStream.Close()
					End If
					If Not flag Then
						Dim o0OO._0OO.6 As FTPClient.ooo__O = Me.O0OO._0OO.
						If o0OO._0OO.6 IsNot Nothing Then
							o0OO._0OO.6(A_0)
						End If
					End If
					Me.AsyncState = Oo_0.OOoo0_OO__._o.
				End Try
			End If
			Return flag
		End Function

		' Token: 0x06002662 RID: 9826 RVA: 0x00105248 File Offset: 0x00103448
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub UploadDirectory(ParamArray args As Object())
			If args.Length = 2 Then
				Me.UploadDirectory(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)))
				Return
			End If
			If args.Length = 3 Then
				Me.UploadDirectory(Conversions.ToString(args(0)), Conversions.ToBoolean(args(1)), Conversions.ToString(args(2)))
			End If
		End Sub

		' Token: 0x06002663 RID: 9827 RVA: 0x00105296 File Offset: 0x00103496
		Public Sub UploadDirectory(path As String, recurse As Boolean)
			Me.UploadDirectory(path, recurse, "*.*")
		End Sub

		' Token: 0x06002664 RID: 9828 RVA: 0x001052A8 File Offset: 0x001034A8
		Public Sub UploadDirectory(path As String, recurse As Boolean, mask As String)
			Dim array As String() = path.Replace("/", "\").Split(New Char() { "\"c })
			Dim dirName As String = array(array.Length - 1)
			If Not Me.DirExists(dirName) Then
				Me.MakeDir(dirName)
			End If
			Me.ChangeDir(dirName)
			For Each a_ As String In Directory.GetFiles(path, mask)
				Me.oOo.O00O__oO_.(a_, True)
			Next
			If recurse Then
				For Each path2 As String In Directory.GetDirectories(path)
					Me.UploadDirectory(path2, recurse, mask)
				Next
			End If
			Me.ChangeDir("..")
		End Sub

		' Token: 0x06002665 RID: 9829 RVA: 0x00105351 File Offset: 0x00103551
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function Delete(fileName As String) As Boolean
			Return Me.DeleteFile(fileName)
		End Function

		' Token: 0x06002666 RID: 9830 RVA: 0x0010535C File Offset: 0x0010355C
		Public Function DeleteFile(fileName As String) As Boolean
			Dim result As Boolean
			If Not Me.Connect() Then
				result = False
			Else
				Dim now As DateTime = DateTime.Now
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在删除文件[" + fileName + "]")
				End If
				Me.o0O_0_.00_oooo.("DELE " + fileName)
				If Me.oOo0_Oo.O_. <> 250 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("删除文件失败", Me.o.0OoOooo__.)
					End If
					result = False
				Else
					Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.2 IsNot Nothing Then
						o0OO._0OO.2("成功删除文件[" + fileName + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now))
					End If
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x06002667 RID: 9831 RVA: 0x00105414 File Offset: 0x00103614
		Public Function Rename(oldFileName As String, newFileName As String) As Boolean
			Dim result As Boolean
			If Not Me.Connect() Then
				result = False
			Else
				Dim now As DateTime = DateTime.Now
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在重命名[" + oldFileName + "]")
				End If
				Me.o0O_0_.00_oooo.("RNFR " + oldFileName)
				If Me.oOo0_Oo.O_. <> 350 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("重命名[" + oldFileName + "]失败", Me.o.0OoOooo__.)
					End If
					result = False
				Else
					Me.o0O_0_.00_oooo.("RNTO " + newFileName)
					If Me.oOo0_Oo.O_. <> 250 Then
						Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o2 IsNot Nothing Then
							ooO_00_o2("重命名[" + oldFileName + "]失败", Me.o.0OoOooo__.)
						End If
						result = False
					Else
						Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
						If o0OO._0OO.2 IsNot Nothing Then
							o0OO._0OO.2(String.Concat(New String() { "[", oldFileName, "]已经重命名至[", newFileName, "] ,用时:", O_O0OO.OoO_00._.(DateTime.Now - now) }))
						End If
						result = True
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x06002668 RID: 9832 RVA: 0x00105540 File Offset: 0x00103740
		Public Function FileExists(FileName As String) As Boolean
			Return Me.GetFileList(FileName).Count > 0
		End Function

		' Token: 0x06002669 RID: 9833 RVA: 0x00105564 File Offset: 0x00103764
		Public Function DirExists(dirName As String) As Boolean
			Dim currentDir As String = Me.CurrentDir
			Dim result As Boolean
			If Operators.CompareString(currentDir, dirName, True) = 0 Then
				result = True
			Else
				Me.ChangeDir(dirName)
				If Operators.CompareString(Me.CurrentDir, currentDir, True) <> 0 Then
					Me.ChangeDir(currentDir)
					result = True
				Else
					result = False
				End If
			End If
			Return result
		End Function

		' Token: 0x0600266A RID: 9834 RVA: 0x001055AC File Offset: 0x001037AC
		Public Function MakeDir(dirName As String) As Boolean
			Dim result As Boolean
			If Not Me.Connect() Then
				result = False
			Else
				Dim now As DateTime = DateTime.Now
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在创建目录[" + dirName + "]")
				End If
				Me.o0O_0_.00_oooo.("MKD " + dirName)
				If Me.oOo0_Oo.O_. <> 250 AndAlso Me.oOo0_Oo.O_. <> 257 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("创建目录[" + dirName + "]失败", Me.o.0OoOooo__.)
					End If
					result = False
				Else
					Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.2 IsNot Nothing Then
						o0OO._0OO.2("成功创建目录[" + dirName + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now))
					End If
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x0600266B RID: 9835 RVA: 0x0010567C File Offset: 0x0010387C
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Not Me.Connect() Then
				result = False
			Else
				Dim now As DateTime = DateTime.Now
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在删除目录[" + A_0 + "]")
				End If
				Me.o0O_0_.00_oooo.("RMD " + A_0)
				If Me.oOo0_Oo.O_. <> 250 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("[" + A_0 + "]删除失败", Me.o.0OoOooo__.)
					End If
					result = False
				Else
					Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
					If o0OO._0OO.2 IsNot Nothing Then
						o0OO._0OO.2("成功删除目录[" + A_0 + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now))
					End If
					result = True
				End If
			End If
			Return result
		End Function

		' Token: 0x170008AA RID: 2218
		' (get) Token: 0x0600266C RID: 9836 RVA: 0x0010573C File Offset: 0x0010393C
		' (set) Token: 0x0600266D RID: 9837 RVA: 0x00105744 File Offset: 0x00103944
		Public Property FTPName As String
			Get
				Return Me.o_._ooo_OO.
			End Get
			Set(value As String)
				Me.o_._ooo_OO. = value
			End Set
		End Property

		' Token: 0x0600266E RID: 9838 RVA: 0x00105750 File Offset: 0x00103950
		Private Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			Dim result As Boolean
			If Not Me.Connect() Then
				result = False
			Else
				Me.ChangeDir(A_0)
				Dim detailList As List(Of String) = Me.GetDetailList("")
				Try
					For Each text As String In detailList
						If text.EndsWith("*D") Then
							If Not Me.ooO000Oo.oO.(text.Substring(0, text.IndexOf("*"))) Then
								Exit For
							End If
						ElseIf Not Me.DeleteFile(text.Substring(0, text.IndexOf("*"))) Then
							Exit For
						End If
					Next
				Finally
					Dim enumerator As List(Of String).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.ChangeDir("..")
				result = Me.Oooo0_.0O_0.(A_0)
			End If
			Return result
		End Function

		' Token: 0x0600266F RID: 9839 RVA: 0x00105814 File Offset: 0x00103A14
		Public Function DeleteDir(dirName As String, Optional anyway As Boolean = False) As Boolean
			Dim result As Boolean
			If Not Me.DirExists(dirName) Then
				result = False
			ElseIf anyway Then
				result = Me.ooO000Oo.oO.(dirName)
			Else
				result = Me.Oooo0_.0O_0.(dirName)
			End If
			Return result
		End Function

		' Token: 0x06002670 RID: 9840 RVA: 0x00105844 File Offset: 0x00103A44
		Public Sub ChangeDir(dirName As String)
			If Operators.CompareString(dirName, Nothing, True) <> 0 AndAlso Not dirName.Equals(".") AndAlso dirName.Length <> 0 AndAlso Me.Connect() Then
				Dim now As DateTime = DateTime.Now
				Dim o0OO._0OO. As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
				If o0OO._0OO. IsNot Nothing Then
					o0OO._0OO.("正在进入目录[" + dirName + "]")
				End If
				Me.o0O_0_.00_oooo.("CWD " + dirName)
				If Me.oOo0_Oo.O_. <> 250 Then
					Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o IsNot Nothing Then
						ooO_00_o("[" + dirName + "]进入失败", Me.o.0OoOooo__.)
						Return
					End If
				Else
					Me.o0O_0_.00_oooo.("PWD")
					If Me.oOo0_Oo.O_. <> 257 Then
						Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o2 IsNot Nothing Then
							ooO_00_o2("[" + dirName + "]进入失败", Me.o.0OoOooo__.)
							Return
						End If
					Else
						Me.OOO00.ooo0. = Me.OOOoO___.O0ooo..Split(New Char() { """"c })(1)
						Dim o0OO._0OO.2 As FTPClient.OOOOO00OoOOo = Me.O0OO._0OO.
						If o0OO._0OO.2 IsNot Nothing Then
							o0OO._0OO.2("已经进入目录[" + Me.OOO00.ooo0. + "],用时:" + O_O0OO.OoO_00._.(DateTime.Now - now))
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x170008AB RID: 2219
		' (get) Token: 0x06002671 RID: 9841 RVA: 0x00105988 File Offset: 0x00103B88
		Public ReadOnly Property CurrentDir As String
			Get
				If Operators.CompareString(Me.OOO00.ooo0., "", True) = 0 Then
					If Not Me.Connect() Then
						Return ""
					End If
					Me.o0O_0_.00_oooo.("PWD")
					If Me.oOo0_Oo.O_. <> 257 Then
						Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o IsNot Nothing Then
							ooO_00_o("获取当前目录失败！", Me.o.0OoOooo__.)
						End If
						Return "/"
					End If
					Me.OOO00.ooo0. = Me.OOOoO___.O0ooo..Split(New Char() { """"c })(1)
				End If
				Return Me.OOO00.ooo0.
			End Get
		End Property

		' Token: 0x06002672 RID: 9842 RVA: 0x00105A1C File Offset: 0x00103C1C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As Boolean
			If A_0.Split(New Char() { "/"c }, StringSplitOptions.RemoveEmptyEntries).Length > 0 Then
				A_0 = A_0.Substring(0, A_0.LastIndexOf("/") + 1)
				If Operators.CompareString(Me.RootDir, "", True) > 0 AndAlso A_0.Length < Me.RootDir.Length AndAlso Me.RootDir.StartsWith(A_0) Then
					Return False
				End If
			End If
			Return True
		End Function

		' Token: 0x06002673 RID: 9843 RVA: 0x00105A94 File Offset: 0x00103C94
		Private Sub <<EMPTY_NAME>>()
			Me.OOOoO___.O0ooo. = ""
			Me.o.0OoOooo__. = Me.oo0000O.Oo0OO.()
			If Me.o.0OoOooo__..Length > 3 Then
				Me.oOo0_Oo.O_. = Integer.Parse(Me.o.0OoOooo__..Substring(0, 3))
				Return
			End If
			Me.o.0OoOooo__. = Nothing
		End Sub

		' Token: 0x06002674 RID: 9844 RVA: 0x00105AE8 File Offset: 0x00103CE8
		Private Function <<EMPTY_NAME>>() As String
			Dim result As String
			Try
				Dim array As Byte() = Nothing
				Do
					Me.o.oo000oOoo. = Me.Ooo_Oo_O0.00O..Receive(Me.Ooo_Oo_O0.00O., Me.Ooo_Oo_O0.00O..Length, SocketFlags.None)
					If Me.o.oo000oOoo. > 0 Then
						If array Is Nothing Then
							array = New Byte(Me.o.oo000oOoo. - 1 + 1 - 1) {}
							Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, 0, Me.o.oo000oOoo.)
						Else
							Dim destinationIndex As Integer = array.Length
							array = CType(Utils.CopyArray(array, New Byte(array.Length - 1 + Me.o.oo000oOoo. + 1 - 1) {}), Byte())
							Array.Copy(Me.Ooo_Oo_O0.00O., 0, array, destinationIndex, Me.o.oo000oOoo.)
						End If
					End If
				Loop While Me.o.oo000oOoo. >= Me.Ooo_Oo_O0.00O..Length
				If array IsNot Nothing Then
					Me.OOOoO___.O0ooo. = Me.o_O_.00_00..GetString(array)
				End If
				Dim array2 As String() = Me.OOOoO___.O0ooo..Split(New Char() { vbLf })
				If Me.OOOoO___.O0ooo..Length > 2 Then
					Me.OOOoO___.O0ooo. = array2(array2.Length - 2)
				Else
					Me.OOOoO___.O0ooo. = array2(0)
				End If
				Dim num As Integer
				If Me.OOOoO___.O0ooo..Length > 4 AndAlso Not Me.OOOoO___.O0ooo..Substring(3, 1).Equals(" ") Then
					result = Me.oo0000O.Oo0OO.()
				ElseIf Me.OOOoO___.O0ooo..Length > 4 AndAlso Not Integer.TryParse(Me.OOOoO___.O0ooo..Substring(0, 3), num) Then
					result = Me.oo0000O.Oo0OO.()
				Else
					result = Me.OOOoO___.O0ooo.
				End If
			Catch ex As Exception
				Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
				If ooO_00_o IsNot Nothing Then
					ooO_00_o("FTP错误", ex.ToString())
				End If
				Me.Connected = False
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x06002675 RID: 9845 RVA: 0x00105CA8 File Offset: 0x00103EA8
		Private Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0O_0_.00_oooo.(A_0, False)
		End Sub

		' Token: 0x06002676 RID: 9846 RVA: 0x00105CB4 File Offset: 0x00103EB4
		Private Sub <<EMPTY_NAME>>(A_0 As String, A_1 As Boolean)
			Try
				Dim bytes As Byte() = Me.o_O_.00_00..GetBytes((A_0 + vbCrLf).ToCharArray())
				Me.Ooo_Oo_O0.00O..Send(bytes, bytes.Length, SocketFlags.None)
				If A_1 Then
					Thread.Sleep(100)
				End If
				Me.Oo__O0._ooo0_o.()
				Me.o_O.o_Oo0O_o0O. = DateTime.Now
			Catch ex As Exception
				Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
				If ooO_00_o IsNot Nothing Then
					ooO_00_o("FTP错误", ex.ToString())
				End If
				Me.Connected = False
			End Try
		End Sub

		' Token: 0x06002677 RID: 9847 RVA: 0x00105D4C File Offset: 0x00103F4C
		Private Function <<EMPTY_NAME>>() As Socket
			Me.o0O_0_.00_oooo.("PASV")
			Dim result As Socket
			If Me.oOo0_Oo.O_. <> 227 Then
				Dim ooO_00_o As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
				If ooO_00_o IsNot Nothing Then
					ooO_00_o("进入PASV模式失败", Me.o.0OoOooo__.)
				End If
				result = Nothing
			Else
				Dim num As Integer = Me.o.0OoOooo__..IndexOf("("c)
				Dim num2 As Integer = Me.o.0OoOooo__..IndexOf(")"c)
				Dim text As String = Me.o.0OoOooo__..Substring(num + 1, num2 - num - 1)
				Dim array As Integer() = New Integer(6) {}
				Dim length As Integer = text.Length
				Dim num3 As Integer = 0
				Dim text2 As String = ""
				Dim num4 As Integer = 0
				While num4 < length AndAlso num3 <= 6
					Dim c As Char = Char.Parse(text.Substring(num4, 1))
					If Char.IsDigit(c) Then
						text2 += Conversions.ToString(c)
					ElseIf c <> ","c Then
						Dim ooO_00_o2 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
						If ooO_00_o2 IsNot Nothing Then
							ooO_00_o2("PASV 格式不正确", Me.o.0OoOooo__.)
						End If
						Return Nothing
					End If
					If c = ","c OrElse num4 + 1 = length Then
						Try
							array(num3) = Integer.Parse(text2)
							num3 += 1
							text2 = ""
						Catch ex As Exception
							Dim ooO_00_o3 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
							If ooO_00_o3 IsNot Nothing Then
								ooO_00_o3("PASV 格式不正确(不支持吗?)", Me.o.0OoOooo__.)
							End If
							Return Nothing
						End Try
					End If
					num4 += 1
				End While
				String.Concat(New String() { Conversions.ToString(array(0)), ".", Conversions.ToString(array(1)), ".", Conversions.ToString(array(2)), ".", Conversions.ToString(array(3)) })
				Dim port As Integer = (array(4) << 8) + array(5)
				Dim socket As Socket = Nothing
				Try
					socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
					Dim remoteEP As IPEndPoint = New IPEndPoint(Me.o_O.o_Oo0O_o0O., port)
					socket.Connect(remoteEP)
				Catch ex2 As Exception
					If socket Is Nothing AndAlso socket.Connected Then
						socket.Close()
					End If
					Dim ooO_00_o4 As FTPClient.OoO_00_o = Me.o_O.o_Oo0O_o0O.
					If ooO_00_o4 IsNot Nothing Then
						ooO_00_o4("不能连接到服务器", ex2.Message)
					End If
					Return Nothing
				End Try
				result = socket
			End If
			Return result
		End Function

		' Token: 0x06002678 RID: 9848 RVA: 0x00105FA0 File Offset: 0x001041A0
		Private Sub <<EMPTY_NAME>>()
			If Me.Ooo_Oo_O0.00O. IsNot Nothing Then
				Me.Ooo_Oo_O0.00O..Close()
				Me.Ooo_Oo_O0.00O. = Nothing
			End If
		End Sub

		' Token: 0x06002679 RID: 9849 RVA: 0x00105FBC File Offset: 0x001041BC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ElapsedEventArgs)
			If Me.Connected AndAlso Me.AsyncState = Oo_0.OOoo0_OO__._o. AndAlso (DateTime.Now - Me.o_O.o_Oo0O_o0O.).TotalSeconds > 30.0 Then
				Me.o_O.o_Oo0O_o0O. = DateTime.Now
				AddressOf Me.oo0000O.Oo0OO..Start()
			End If
		End Sub

		' Token: 0x0600267A RID: 9850 RVA: 0x00106020 File Offset: 0x00104220
		Private Sub <<EMPTY_NAME>>()
			Try
				Me.o0O_0_.00_oooo.("PWD")
				If Me.oOo0_Oo.O_. <> 257 Then
					Me.Connected = False
				Else
					Me.OOO00.ooo0. = Me.OOOoO___.O0ooo..Split(New Char() { """"c })(1)
				End If
			Catch ex As Exception
				Me.Connected = False
			End Try
		End Sub

		' Token: 0x0600267B RID: 9851 RVA: 0x00106094 File Offset: 0x00104294
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Me.O0.o0. = True
			Me.Connected = False
		End Sub

		' Token: 0x0600267C RID: 9852 RVA: 0x001060A4 File Offset: 0x001042A4
		Public Shared Function Ping() As Boolean
			Dim a As FTPClient.a = New FTPClient.a()
			Return a.b() AndAlso a.a() AndAlso a.c()
		End Function

		' Token: 0x0600267D RID: 9853 RVA: 0x001060D0 File Offset: 0x001042D0
		Friend Function <<EMPTY_NAME>>() As FTPClient
			Return New FTPClient() With { .Host = Me.Host, .Account = Me.Account, .Password = Me.Password, .Port = Me.Port, .UTF8 = Me.UTF8, .RootDir = Me.RootDir, .UploadEnabled = Me.UploadEnabled, .DownloadEnabled = Me.DownloadEnabled, .RenameEnabled = Me.RenameEnabled, .DeleteEnabled = Me.DeleteEnabled, .MakerDirEnabled = Me.MakerDirEnabled, .OpenFileEnabled = Me.OpenFileEnabled, .FTPName = Me.FTPName }
		End Function

		' Token: 0x04000FAD RID: 4013
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FAE RID: 4014
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FAF RID: 4015
		Private <<EMPTY_NAME>> As Encoding

		' Token: 0x04000FB0 RID: 4016
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB1 RID: 4017
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB2 RID: 4018
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB3 RID: 4019
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB4 RID: 4020
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB5 RID: 4021
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB6 RID: 4022
		Private <<EMPTY_NAME>> As IPAddress

		' Token: 0x04000FB7 RID: 4023
		Private <<EMPTY_NAME>> As IPEndPoint

		' Token: 0x04000FB8 RID: 4024
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FB9 RID: 4025
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FBA RID: 4026
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FBB RID: 4027
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FBC RID: 4028
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FBD RID: 4029
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FBE RID: 4030
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FBF RID: 4031
		Private <<EMPTY_NAME>> As Byte()

		' Token: 0x04000FC0 RID: 4032
		Private <<EMPTY_NAME>> As Byte()

		' Token: 0x04000FC1 RID: 4033
		Private <<EMPTY_NAME>> As Socket

		' Token: 0x04000FC2 RID: 4034
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04000FC3 RID: 4035
		Private <<EMPTY_NAME>> As Oo_0

		' Token: 0x04000FC4 RID: 4036
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FC5 RID: 4037
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FC6 RID: 4038
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FC7 RID: 4039
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FC8 RID: 4040
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FC9 RID: 4041
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FCA RID: 4042
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FCB RID: 4043
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FCC RID: 4044
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FCD RID: 4045
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FCE RID: 4046
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.o0O_O00o_0_o

		' Token: 0x04000FCF RID: 4047
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.oO_o_0OOo__0

		' Token: 0x04000FD0 RID: 4048
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.O__0O000__Oo

		' Token: 0x04000FD1 RID: 4049
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.o0_O_0_0

		' Token: 0x04000FD2 RID: 4050
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.oO___

		' Token: 0x04000FD3 RID: 4051
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.ooo__O

		' Token: 0x04000FD4 RID: 4052
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.OooO_O0O_0_O

		' Token: 0x04000FD5 RID: 4053
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.OOOOO00OoOOo

		' Token: 0x04000FD6 RID: 4054
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.OoO_00_o

		' Token: 0x04000FD7 RID: 4055
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As FTPClient.Oo__

		' Token: 0x04000FD8 RID: 4056
		<AccessedThroughProperty("Timer")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As System.Timers.Timer

		' Token: 0x04000FD9 RID: 4057
		Private <<EMPTY_NAME>> As DateTime

		' Token: 0x04000FDA RID: 4058
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FDB RID: 4059
		Friend <<EMPTY_NAME>> As Dictionary(Of String, List(Of String))

		' Token: 0x04000FDC RID: 4060
		Private <<EMPTY_NAME>> As Thread

		' Token: 0x04000FDD RID: 4061
		Friend <<EMPTY_NAME>> As List(Of String)

		' Token: 0x04000FDE RID: 4062
		<AccessedThroughProperty("MainForm")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Form

		' Token: 0x04000FDF RID: 4063
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000FE0 RID: 4064
		Private <<EMPTY_NAME>> As String

		' Token: 0x04000FE1 RID: 4065
		Private <<EMPTY_NAME>> As OleDbDataAdapter

		' Token: 0x04000FE2 RID: 4066
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x04000FE3 RID: 4067
		Private <<EMPTY_NAME>> As StaticLocalInitFlag

		' Token: 0x020002C9 RID: 713
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Class OOO_o00_OO_
			Inherits Exception

			' Token: 0x0600267E RID: 9854 RVA: 0x0010617E File Offset: 0x0010437E
			Public Sub New(A_0 As String)
				MyBase.New(A_0)
			End Sub

			' Token: 0x0600267F RID: 9855 RVA: 0x00106187 File Offset: 0x00104387
			Public Sub New(A_0 As String, A_1 As Exception)
				MyBase.New(A_0, A_1)
			End Sub
		End Class

		' Token: 0x020002CA RID: 714
		' (Invoke) Token: 0x06002683 RID: 9859
		Friend Delegate Sub o0O_O00o_0_o(A_0 As String, A_1 As Long, A_2 As Long, A_3 As Long, A_4 As TimeSpan)

		' Token: 0x020002CB RID: 715
		' (Invoke) Token: 0x06002687 RID: 9863
		Friend Delegate Sub oO_o_0OOo__0(A_0 As String)

		' Token: 0x020002CC RID: 716
		' (Invoke) Token: 0x0600268B RID: 9867
		Friend Delegate Sub O__0O000__Oo(A_0 As String, A_1 As Boolean)

		' Token: 0x020002CD RID: 717
		' (Invoke) Token: 0x0600268F RID: 9871
		Friend Delegate Sub o0_O_0_0(A_0 As String, A_1 As Long, A_2 As Long, A_3 As Long, A_4 As TimeSpan)

		' Token: 0x020002CE RID: 718
		' (Invoke) Token: 0x06002693 RID: 9875
		Friend Delegate Sub oO___(A_0 As String, A_1 As String)

		' Token: 0x020002CF RID: 719
		' (Invoke) Token: 0x06002697 RID: 9879
		Friend Delegate Sub ooo__O(A_0 As String)

		' Token: 0x020002D0 RID: 720
		' (Invoke) Token: 0x0600269B RID: 9883
		Friend Delegate Sub OooO_O0O_0_O()

		' Token: 0x020002D1 RID: 721
		' (Invoke) Token: 0x0600269F RID: 9887
		Friend Delegate Sub OOOOO00OoOOo(A_0 As String)

		' Token: 0x020002D2 RID: 722
		' (Invoke) Token: 0x060026A3 RID: 9891
		Friend Delegate Sub OoO_00_o(A_0 As String, A_1 As String)

		' Token: 0x020002D3 RID: 723
		' (Invoke) Token: 0x060026A7 RID: 9895
		Friend Delegate Sub Oo__(A_0 As String, A_1 As String, A_2 As Boolean)

		' Token: 0x020002D4 RID: 724
		Private Class oO__oo_00O0o_
			' Token: 0x060026A8 RID: 9896 RVA: 0x00106191 File Offset: 0x00104391
			Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
				Me.oo_o0.ooo_oO. = A_0
				Me.OO0O00_0_._0. = A_1
				Me.oo_o0.ooo_oO. = A_2
			End Sub

			' Token: 0x04000FE4 RID: 4068
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04000FE5 RID: 4069
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04000FE6 RID: 4070
			Friend <<EMPTY_NAME>> As Boolean
		End Class

		' Token: 0x020002D5 RID: 725
		Private Class o_o_oo0
			' Token: 0x060026A9 RID: 9897 RVA: 0x001061AE File Offset: 0x001043AE
			Friend Sub New(A_0 As String, A_1 As String, A_2 As Boolean)
				Me.oo_o0.ooo_oO. = A_0
				Me.oO.o___. = A_1
				Me.oo_o0.ooo_oO. = A_2
			End Sub

			' Token: 0x04000FE7 RID: 4071
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04000FE8 RID: 4072
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04000FE9 RID: 4073
			Friend <<EMPTY_NAME>> As Boolean
		End Class

		' Token: 0x020002D6 RID: 726
		Private Class Oo___Ooo_
			' Token: 0x060026AA RID: 9898 RVA: 0x001061CB File Offset: 0x001043CB
			Friend Sub New(A_0 As String, A_1 As String)
				Me.O0OO._0OO. = A_0
				Me.OO0O00_0_._0. = A_1
			End Sub

			' Token: 0x04000FEA RID: 4074
			Friend <<EMPTY_NAME>> As String

			' Token: 0x04000FEB RID: 4075
			Friend <<EMPTY_NAME>> As String
		End Class

		' Token: 0x020002D7 RID: 727
		Private Class a
			' Token: 0x060026AB RID: 9899 RVA: 0x001061E4 File Offset: 0x001043E4
			Friend Sub New()
				Me.a = 4
				Me.c = 100
				Me.d = 41917
				Me.e = 9900
				Me.e = "Project"
				Me.f = "Identify"
				Me.g = ""
				Me.h = O_O0OO.O_O._Oo.()
				Me.i = "EUNumber"
				Me.k = "fox"
				Me.l = "table"
				Me.m = "eKaQbTBxmrBHzMuF2nlPkw"
				Me.n = "=="
				Me.a()
				Me.e += Me.c
			End Sub

			' Token: 0x060026AC RID: 9900 RVA: 0x00106298 File Offset: 0x00104498
			Friend Function b() As Boolean
				Dim num As Integer
				Dim result As Boolean
				Dim num4 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					If Operators.CompareString(Me.a, "", True) <> 0 AndAlso Operators.CompareString(Me.b, "", True) <> 0 Then
						GoTo IL_38
					End If
					IL_2F:
					num2 = 3
					result = False
					GoTo IL_BE
					IL_38:
					num2 = 4
					Me.c = Me.b.Substring(0, Me.a)
					IL_52:
					num2 = 5
					Me.d = Me.a.Substring(0, Me.a)
					IL_6C:
					num2 = 6
					Integer.TryParse(Me.c, Me.b)
					IL_80:
					num2 = 7
					Integer.TryParse(Me.d, Me.f)
					IL_94:
					num2 = 8
					result = (Me.f = (Me.b + Me.d * Me.a * 4 + 1) Mod Me.e)
					IL_BE:
					GoTo IL_131
					IL_C0:
					Dim num3 As Integer = num4 + 1
					num4 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
					IL_F2:
					GoTo IL_126
					IL_F4:
					num4 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_104:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_F4
				End Try
				IL_126:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_131:
				If num4 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x060026AD RID: 9901 RVA: 0x001063FC File Offset: 0x001045FC
			Friend Function a() As Boolean
				Dim num As Integer
				Dim result As Boolean
				Dim num5 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Me.g = ""
					IL_14:
					num2 = 3
					If Operators.CompareString(Me.a, "", True) <> 0 AndAlso Operators.CompareString(Me.b, "", True) <> 0 Then
						GoTo IL_45
					End If
					IL_3C:
					num2 = 4
					result = False
					GoTo IL_FE
					IL_45:
					num2 = 5
					Me.d = Me.a.Substring(Me.a, Me.a)
					IL_64:
					num2 = 6
					Me.c = O_O0OO.O0_00o.o0__o..hidprop2
					IL_76:
					num2 = 7
					Dim num3 As Integer = Me.a - 1
					For i As Integer = 0 To num3
						IL_87:
						num2 = 8
						Me.g += Conversions.ToString(CInt(((Me.c(i) + ChrW(1)) Mod vbTab + ChrW(1))))
						IL_B3:
						num2 = 9
					Next
					IL_C2:
					num2 = 10
					Integer.TryParse(Me.g, Me.b)
					IL_D7:
					num2 = 11
					Integer.TryParse(Me.d, Me.f)
					IL_EC:
					num2 = 12
					result = (Me.b = Me.f)
					IL_FE:
					GoTo IL_184
					IL_103:
					Dim num4 As Integer = num5 + 1
					num5 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
					IL_145:
					GoTo IL_179
					IL_147:
					num5 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_157:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_147
				End Try
				IL_179:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_184:
				If num5 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x060026AE RID: 9902 RVA: 0x001065B4 File Offset: 0x001047B4
			Friend Function c() As Boolean
				Dim num As Integer
				Dim result As Boolean
				Dim num5 As Integer
				Dim obj As Object
				Try
					IL_00:
					ProjectData.ClearProjectError()
					num = 1
					IL_07:
					Dim num2 As Integer = 2
					Me.g = ""
					IL_14:
					num2 = 3
					If Operators.CompareString(Me.a, "", True) <> 0 AndAlso Operators.CompareString(Me.b, "", True) <> 0 Then
						GoTo IL_45
					End If
					IL_3C:
					num2 = 4
					result = False
					GoTo IL_181
					IL_45:
					num2 = 5
					Me.d = Me.a.Substring(Me.a * 2, Me.a)
					IL_66:
					num2 = 6
					Me.j = Me.a
					IL_74:
					num2 = 7
					Integer.TryParse(Me.c, Me.g)
					IL_88:
					num2 = 8
					Me.c = O_O0OO.O0_00o.o0__o..hidprop3
					IL_9A:
					num2 = 9
					Dim num3 As Integer = 0
					Do
						IL_A0:
						num2 = 10
						Me.g += Conversions.ToString(CInt(((Me.c(num3) - ChrW(1)) Mod vbTab + ChrW(1))))
						IL_CD:
						num2 = 11
						num3 += 1
					Loop While num3 <= 3
					IL_DB:
					num2 = 12
					Integer.TryParse(Me.g, Me.g)
					IL_F0:
					num2 = 13
					Integer.TryParse(Me.d, Me.f)
					IL_105:
					num2 = 14
					If Operators.CompareString(O00.MD5Encrypt((Me.g + Me.f).ToString()), Me.m + Me.n, True) <> 0 AndAlso Operators.CompareString(O00.MD5Encrypt(Math.Abs(Me.g - Me.f).ToString()), Me.m + Me.n, True) <> 0 Then
						GoTo IL_17C
					End If
					IL_175:
					num2 = 15
					result = True
					GoTo IL_181
					IL_17C:
					num2 = 17
					result = False
					IL_181:
					GoTo IL_21B
					IL_186:
					Dim num4 As Integer = num5 + 1
					num5 = 0
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
					IL_1DC:
					GoTo IL_210
					IL_1DE:
					num5 = num2
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_1EE:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_1DE
				End Try
				IL_210:
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_21B:
				If num5 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Function

			' Token: 0x060026AF RID: 9903 RVA: 0x00106804 File Offset: 0x00104A04
			Private Sub a()
				Dim dataRow As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0O.0o0.()).Rows.Find(New Object() { "(" + Me.e + Me.f + ")", "(" + Me.e + Me.f + ")" })
				If dataRow IsNot Nothing AndAlso Not dataRow.IsNull("Config") Then
					Dim array As String() = O00.oO_.0o_oo_0O_.(dataRow("Config").ToString(), o_o_O0OO_0__.o000oOoo.0.(Me.h), O00.MD5Encrypt(Me.h)).Split(New Char() { "|"c })
					Me.b = array(0)
					Me.a = array(1)
				End If
			End Sub

			' Token: 0x04000FEC RID: 4076
			Private a As String

			' Token: 0x04000FED RID: 4077
			Private b As String

			' Token: 0x04000FEE RID: 4078
			Private a As Integer

			' Token: 0x04000FEF RID: 4079
			Private c As String

			' Token: 0x04000FF0 RID: 4080
			Private d As String

			' Token: 0x04000FF1 RID: 4081
			Private b As Integer

			' Token: 0x04000FF2 RID: 4082
			Private c As Integer

			' Token: 0x04000FF3 RID: 4083
			Private d As Integer

			' Token: 0x04000FF4 RID: 4084
			Private e As Integer

			' Token: 0x04000FF5 RID: 4085
			Private f As Integer

			' Token: 0x04000FF6 RID: 4086
			Private e As String

			' Token: 0x04000FF7 RID: 4087
			Private f As String

			' Token: 0x04000FF8 RID: 4088
			Private g As String

			' Token: 0x04000FF9 RID: 4089
			Private h As String

			' Token: 0x04000FFA RID: 4090
			Private i As String

			' Token: 0x04000FFB RID: 4091
			Private g As Integer

			' Token: 0x04000FFC RID: 4092
			Private j As String

			' Token: 0x04000FFD RID: 4093
			Private k As String

			' Token: 0x04000FFE RID: 4094
			Private l As String

			' Token: 0x04000FFF RID: 4095
			Private m As String

			' Token: 0x04001000 RID: 4096
			Private n As String
		End Class
	End Class
End Namespace
