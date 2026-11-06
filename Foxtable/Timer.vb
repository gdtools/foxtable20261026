Imports System
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Foxtable
	' Token: 0x02000318 RID: 792
	<oO0oooo("0658")>
	<ComVisible(True)>
	Public Class Timer
		' Token: 0x06002B07 RID: 11015 RVA: 0x0012D850 File Offset: 0x0012BA50
		Public Sub New()
			Me._timer = New Timer()
		End Sub

		' Token: 0x17000A2A RID: 2602
		' (get) Token: 0x06002B08 RID: 11016 RVA: 0x0012D863 File Offset: 0x0012BA63
		' (set) Token: 0x06002B09 RID: 11017 RVA: 0x0012D86C File Offset: 0x0012BA6C
		Private Overridable Property _timer As Timer
			<CompilerGenerated()>
			Get
				Return Me.o.0O__o.
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Mytimer_Tick
				Dim timer As Timer = Me.o.0O__o.
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, value2
				End If
				Me.o.0O__o. = value
				timer = Me.o.0O__o.
				If timer IsNot Nothing Then
					AddHandler timer.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000A2B RID: 2603
		' (get) Token: 0x06002B0A RID: 11018 RVA: 0x0012D8AF File Offset: 0x0012BAAF
		' (set) Token: 0x06002B0B RID: 11019 RVA: 0x0012D8B7 File Offset: 0x0012BAB7
		Public Property Tag As Object
			<CompilerGenerated()>
			Get
				Return Me.O_o.Oo_o__.
			End Get
			<CompilerGenerated()>
			Set(value As Object)
				Me.O_o.Oo_o__. = RuntimeHelpers.GetObjectValue(value)
			End Set
		End Property

		' Token: 0x17000A2C RID: 2604
		' (get) Token: 0x06002B0C RID: 11020 RVA: 0x0012D8C5 File Offset: 0x0012BAC5
		' (set) Token: 0x06002B0D RID: 11021 RVA: 0x0012D8D2 File Offset: 0x0012BAD2
		Public Property Enabled As Boolean
			Get
				Return Me._timer.Enabled
			End Get
			Set(value As Boolean)
				Me._timer.Enabled = value
			End Set
		End Property

		' Token: 0x17000A2D RID: 2605
		' (get) Token: 0x06002B0E RID: 11022 RVA: 0x0012D8E0 File Offset: 0x0012BAE0
		' (set) Token: 0x06002B0F RID: 11023 RVA: 0x0012D8ED File Offset: 0x0012BAED
		Public Property Interval As Integer
			Get
				Return Me._timer.Interval
			End Get
			Set(value As Integer)
				Me._timer.Interval = value
			End Set
		End Property

		' Token: 0x17000A2E RID: 2606
		' (get) Token: 0x06002B10 RID: 11024 RVA: 0x0012D8FB File Offset: 0x0012BAFB
		' (set) Token: 0x06002B11 RID: 11025 RVA: 0x0012D903 File Offset: 0x0012BB03
		Friend Property CanPause As Boolean
			Get
				Return Me.o.0O__o.
			End Get
			Set(value As Boolean)
				Me.o.0O__o. = True
			End Set
		End Property

		' Token: 0x17000A2F RID: 2607
		' (get) Token: 0x06002B12 RID: 11026 RVA: 0x0012D90C File Offset: 0x0012BB0C
		' (set) Token: 0x06002B13 RID: 11027 RVA: 0x0012D914 File Offset: 0x0012BB14
		Public Property Name As String
			Get
				Return Me.o.0O__o.
			End Get
			Friend Set(value As String)
				Me.o.0O__o. = value
			End Set
		End Property

		' Token: 0x06002B14 RID: 11028 RVA: 0x0012D91D File Offset: 0x0012BB1D
		Public Sub Dispose()
			Me._timer.Dispose()
		End Sub

		' Token: 0x06002B15 RID: 11029 RVA: 0x0012D92C File Offset: 0x0012BB2C
		Private Sub Mytimer_Tick(sender As Object, e As EventArgs)
			If Not OO_00oOO.MyTimers.Pause Then
				Dim oo0_o_.o. As Assembly = O_O0OO.oo0_o_.o.
				If OO_00oOO.SystemReady AndAlso oo0_o_.o. IsNot Nothing Then
					Dim method As MethodInfo = oo0_o_.o..[GetType]("UserCode").GetMethod(Me.Tag.ToString())
					Try
						If method IsNot Nothing Then
							method.Invoke(Nothing, Nothing)
						End If
					Catch innerException As Exception
						If innerException.InnerException IsNot Nothing Then
							innerException = innerException.InnerException
						End If
						Me.Enabled = False
						ooO.oOo0Oo.o.(innerException, "计划" + Me.Name)
					End Try
				End If
			End If
		End Sub

		' Token: 0x04001178 RID: 4472
		<AccessedThroughProperty("_timer")>
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Timer

		' Token: 0x04001179 RID: 4473
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x0400117A RID: 4474
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400117B RID: 4475
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Object
	End Class
End Namespace
