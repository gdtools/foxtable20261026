Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000143 RID: 323
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Public Class oOo0o0__0
		Inherits DropDownForm

		' Token: 0x06000F5A RID: 3930 RVA: 0x000687BF File Offset: 0x000669BF
		Public Sub New()
			Me.o.O_OO.()
		End Sub

		' Token: 0x06000F5B RID: 3931 RVA: 0x000687D0 File Offset: 0x000669D0
		<DebuggerNonUserCode()>
		Protected Overrides Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o.O_OO. IsNot Nothing Then
					Me.o.O_OO..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06000F5C RID: 3932 RVA: 0x00068810 File Offset: 0x00066A10
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o.O_OO.(New DateEditMonthCalendar())
			MyBase.SuspendLayout()
			Me.o.O_OO.().ClearText = "清空（&C）"
			Me.o.O_OO.().Font = New Font("Tahoma", 8F)
			Me.o.O_OO.().RightToLeft = RightToLeft.Inherit
			Me.o.O_OO.().ShowClearButton = False
			Me.o.O_OO.().ShowTodayCircle = False
			Me.o.O_OO.().TodayText = "今日（&T）"
			Me.o.O_OO.().VisualStyleBaseStyle = 5
			MyBase.AutoScaleDimensions = New SizeF(9F, 18F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(296, 292)
			MyBase.Controls.Add(Me.o.O_OO.())
			MyBase.Name = "oI1I_.O."
			Me.Text = "DropCalendar"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06000F5D RID: 3933 RVA: 0x000688F7 File Offset: 0x00066AF7
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As DateEditMonthCalendar
			Return Me.o.O_OO.
		End Function

		' Token: 0x06000F5E RID: 3934 RVA: 0x00068900 File Offset: 0x00066B00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As DateEditMonthCalendar)
			Dim nullableDateTimeEventHandler As NullableDateTimeEventHandler = AddressOf Me.ooo_OOO.O0O.
			Dim dateEditMonthCalendar As DateEditMonthCalendar = Me.o.O_OO.
			If dateEditMonthCalendar IsNot Nothing Then
				dateEditMonthCalendar.DateValueSelected -= nullableDateTimeEventHandler
			End If
			Me.o.O_OO. = A_0
			dateEditMonthCalendar = Me.o.O_OO.
			If dateEditMonthCalendar IsNot Nothing Then
				dateEditMonthCalendar.DateValueSelected += nullableDateTimeEventHandler
			End If
		End Sub

		' Token: 0x06000F5F RID: 3935 RVA: 0x00068943 File Offset: 0x00066B43
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As NullableDateTimeEventArgs)
			MyBase.OwnerControl.Value = A_1.[Date]
			MyBase.OwnerControl.CloseDropDown()
		End Sub

		' Token: 0x040005E1 RID: 1505
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040005E2 RID: 1506
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As DateEditMonthCalendar
	End Class
End Namespace
