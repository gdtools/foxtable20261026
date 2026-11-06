Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Timers
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200029E RID: 670
	<oO0oooo("1963")>
	<ComVisible(True)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class FileSystemWatcher
		' Token: 0x1700082C RID: 2092
		' (get) Token: 0x060022AB RID: 8875 RVA: 0x000EE8B2 File Offset: 0x000ECAB2
		' (set) Token: 0x060022AC RID: 8876 RVA: 0x000EE8BC File Offset: 0x000ECABC
		Private Overridable Property fw As FileSystemWatcher
			<CompilerGenerated()>
			Get
				Return Me.oooOO.OO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FileSystemWatcher)
				Dim value2 As FileSystemEventHandler = AddressOf Me.oO.O_O0.
				Dim value3 As FileSystemEventHandler = AddressOf Me.oO.o0_O_.
				Dim value4 As FileSystemEventHandler = AddressOf Me.oooOO.OO.
				Dim fileSystemWatcher As FileSystemWatcher = Me.oooOO.OO.
				If fileSystemWatcher IsNot Nothing Then
					RemoveHandler fileSystemWatcher.Changed, value2
					RemoveHandler fileSystemWatcher.Created, value3
					RemoveHandler fileSystemWatcher.Deleted, value4
				End If
				Me.oooOO.OO. = value
				fileSystemWatcher = Me.oooOO.OO.
				If fileSystemWatcher IsNot Nothing Then
					AddHandler fileSystemWatcher.Changed, value2
					AddHandler fileSystemWatcher.Created, value3
					AddHandler fileSystemWatcher.Deleted, value4
				End If
			End Set
		End Property

		' Token: 0x1700082D RID: 2093
		' (get) Token: 0x060022AD RID: 8877 RVA: 0x000EE935 File Offset: 0x000ECB35
		' (set) Token: 0x060022AE RID: 8878 RVA: 0x000EE940 File Offset: 0x000ECB40
		Private Overridable Property Timer1 As Timer
			<CompilerGenerated()>
			Get
				Return Me.oooOO.OO.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As ElapsedEventHandler = AddressOf Me.oooOO.OO.
				Dim timer As Timer = Me.oooOO.OO.
				If timer IsNot Nothing Then
					RemoveHandler timer.Elapsed, value2
				End If
				Me.oooOO.OO. = value
				timer = Me.oooOO.OO.
				If timer IsNot Nothing Then
					AddHandler timer.Elapsed, value2
				End If
			End Set
		End Property

		' Token: 0x060022AF RID: 8879 RVA: 0x000EE984 File Offset: 0x000ECB84
		Public Sub New()
			Me.fw = New FileSystemWatcher()
			Me.oooOO.OO. = New Dictionary(Of String, FileSystemEventArgs)()
			Me.Timer1 = New Timer()
			Me.fw.NotifyFilter = (NotifyFilters.FileName Or NotifyFilters.LastWrite Or NotifyFilters.CreationTime)
			Me.fw.IncludeSubdirectories = True
			Me.fw.EnableRaisingEvents = False
			Me.Timer1.Interval = 1000.0
			Me.Timer1.Enabled = False
		End Sub

		' Token: 0x1700082E RID: 2094
		' (get) Token: 0x060022B0 RID: 8880 RVA: 0x000EE9FD File Offset: 0x000ECBFD
		' (set) Token: 0x060022B1 RID: 8881 RVA: 0x000EEA0A File Offset: 0x000ECC0A
		Public Property Enabled As Boolean
			Get
				Return Me.fw.EnableRaisingEvents
			End Get
			Set(value As Boolean)
				If Operators.CompareString(Me.fw.Path, "", True) = 0 Then
					value = False
				End If
				Me.fw.EnableRaisingEvents = value
			End Set
		End Property

		' Token: 0x1700082F RID: 2095
		' (get) Token: 0x060022B2 RID: 8882 RVA: 0x000EEA33 File Offset: 0x000ECC33
		' (set) Token: 0x060022B3 RID: 8883 RVA: 0x000EEA40 File Offset: 0x000ECC40
		Public Property Path As String
			Get
				Return Me.fw.Path
			End Get
			Set(value As String)
				If Operators.CompareString(value, "", True) > 0 AndAlso System.IO.Path.GetFullPath(value).EndsWith(":\") Then
					value = ""
				End If
				If Operators.CompareString(value, "", True) > 0 AndAlso (OO_00oOO.FileSys.FileExists(value) OrElse OO_00oOO.FileSys.DirectoryExists(value)) Then
					Me.fw.Path = value
				End If
			End Set
		End Property

		' Token: 0x17000830 RID: 2096
		' (get) Token: 0x060022B4 RID: 8884 RVA: 0x000EEAAA File Offset: 0x000ECCAA
		' (set) Token: 0x060022B5 RID: 8885 RVA: 0x000EEAB7 File Offset: 0x000ECCB7
		Public Property Filter As String
			Get
				Return Me.fw.Filter
			End Get
			Set(value As String)
				Me.fw.Filter = value
			End Set
		End Property

		' Token: 0x17000831 RID: 2097
		' (get) Token: 0x060022B6 RID: 8886 RVA: 0x000EEAC5 File Offset: 0x000ECCC5
		' (set) Token: 0x060022B7 RID: 8887 RVA: 0x000EEAD2 File Offset: 0x000ECCD2
		Public Property Delay As Double
			Get
				Return Me.Timer1.Interval
			End Get
			Set(value As Double)
				Me.Timer1.Interval = Math.Max(100.0, value)
			End Set
		End Property

		' Token: 0x060022B8 RID: 8888 RVA: 0x000EEAF0 File Offset: 0x000ECCF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FileSystemEventArgs)
			If Me.oooOO.OO..ContainsKey(A_1.FullPath) Then
				If Me.oooOO.OO.(A_1.FullPath).ChangeType = WatcherChangeTypes.Created Then
					Return
				End If
				Me.oooOO.OO..Remove(A_1.FullPath)
			End If
			Me.oooOO.OO..Add(A_1.FullPath, A_1)
			If Not Me.Timer1.Enabled Then
				Me.Timer1.Enabled = True
			End If
		End Sub

		' Token: 0x060022B9 RID: 8889 RVA: 0x000EEB68 File Offset: 0x000ECD68
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FileSystemEventArgs)
			If Me.oooOO.OO..ContainsKey(A_1.FullPath) Then
				Me.oooOO.OO..Remove(A_1.FullPath)
			End If
			Me.oooOO.OO..Add(A_1.FullPath, A_1)
			If Not Me.Timer1.Enabled Then
				Me.Timer1.Enabled = True
			End If
		End Sub

		' Token: 0x060022BA RID: 8890 RVA: 0x000EEBC8 File Offset: 0x000ECDC8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FileSystemEventArgs)
			If Me.oooOO.OO..ContainsKey(A_1.FullPath) Then
				Me.oooOO.OO..Remove(A_1.FullPath)
			End If
			Me.oooOO.OO..Add(A_1.FullPath, A_1)
			If Not Me.Timer1.Enabled Then
				Me.Timer1.Enabled = True
			End If
		End Sub

		' Token: 0x060022BB RID: 8891 RVA: 0x000EEC28 File Offset: 0x000ECE28
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Sub initialize()
			Me.Timer1.SynchronizingObject = Main.OO_O.o.
			Dim o0_00o.o0__o. As ProjectProperty = O_O0OO.O0_00o.o0__o.
			Me.Enabled = False
			Me.Delay = CDbl(o0_00o.o0__o..FWDelay)
			If Operators.CompareString(o0_00o.o0__o..FWPath, "", True) > 0 AndAlso (OO_00oOO.FileSys.FileExists(o0_00o.o0__o..FWPath) OrElse OO_00oOO.FileSys.DirectoryExists(o0_00o.o0__o..FWPath)) Then
				Me.Path = o0_00o.o0__o..FWPath
				Me.Enabled = o0_00o.o0__o..FWEnabled
			End If
			Me.Filter = o0_00o.o0__o..FWFilter
		End Sub

		' Token: 0x060022BC RID: 8892 RVA: 0x000EECC0 File Offset: 0x000ECEC0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ElapsedEventArgs)
			Me.Timer1.Enabled = False
			Dim text As String = ""
			Try
				Dim enumerator As Dictionary(Of String, FileSystemEventArgs).KeyCollection.Enumerator = Me.oooOO.OO..Keys.GetEnumerator()
				If enumerator.MoveNext() Then
					text = enumerator.Current
				End If
			Finally
				Dim enumerator As Dictionary(Of String, FileSystemEventArgs).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			If Operators.CompareString(text, "", True) > 0 Then
				Dim fileSystemEventArgs As FileSystemEventArgs = Me.oooOO.OO.(text)
				Dim fileWatchEventArgs As FileWatchEventArgs = New FileWatchEventArgs(fileSystemEventArgs)
				Select Case fileSystemEventArgs.ChangeType
					Case WatcherChangeTypes.Created
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileCreated", New Object() { fileWatchEventArgs }, False, "文件监视器", False)
					Case WatcherChangeTypes.Deleted
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileDeleted", New Object() { fileWatchEventArgs }, False, "文件监视器", False)
					Case WatcherChangeTypes.Changed
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "FileChanged", New Object() { fileWatchEventArgs }, False, "文件监视器", False)
				End Select
				Me.oooOO.OO..Remove(text)
				Me.Timer1.Enabled = (Me.oooOO.OO..Count > 0)
			End If
		End Sub

		' Token: 0x04000E46 RID: 3654
		<CompilerGenerated()>
		<AccessedThroughProperty("fw")>
		Private <<EMPTY_NAME>> As FileSystemWatcher

		' Token: 0x04000E47 RID: 3655
		Private <<EMPTY_NAME>> As Dictionary(Of String, FileSystemEventArgs)

		' Token: 0x04000E48 RID: 3656
		<AccessedThroughProperty("Timer1")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer
	End Class
End Namespace
