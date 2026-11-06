Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200034C RID: 844
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002
		Inherits Form

		' Token: 0x0600336C RID: 13164 RVA: 0x00151D3C File Offset: 0x0014FF3C
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.Oo0O.OO_. IsNot Nothing Then
					Me.Oo0O.OO_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600336D RID: 13165 RVA: 0x00151D7C File Offset: 0x0014FF7C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OoO__o_.o_O_.(New C1DateEdit())
			Me.O.OO0_.(New C1Button())
			Me.OoO__o_.o_O_.(New C1Button())
			Me.O.OO0_.(New Label())
			Me.O.OO0_.(New C1DateEdit())
			Me.OoO__o_.o_O_.(New Label())
			Me.oo_o.0000.().BeginInit()
			Me.O_O0_OO0.0__.().BeginInit()
			MyBase.SuspendLayout()
			Me.oo_o.0000.().Calendar.AnnuallyBoldedDates = New DateTime(-1) {}
			Me.oo_o.0000.().Calendar.BoldedDates = New DateTime(-1) {}
			Me.oo_o.0000.().Calendar.ClearText = "&Clear"
			Me.oo_o.0000.().Calendar.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.oo_o.0000.().Calendar.Margin = New Padding(0)
			Me.oo_o.0000.().Calendar.MonthlyBoldedDates = New DateTime(-1) {}
			Me.oo_o.0000.().Calendar.SelectedDate = New DateTime(2007, 11, 5, 0, 0, 0, 0)
			Me.oo_o.0000.().Calendar.TodayText = "&Today"
			Me.oo_o.0000.().Calendar.VisualStyle = 1
			Me.oo_o.0000.().Calendar.VisualStyleBaseStyle = 1
			Me.oo_o.0000.().DateTimeInput = False
			Me.oo_o.0000.().FormatType = 2
			Me.oo_o.0000.().Location = New Point(19, 34)
			Me.oo_o.0000.().MaskInfo.ShowLiterals = 3
			Me.oo_o.0000.().Name = "C1DateEdit1"
			Me.oo_o.0000.().Size = New Size(132, 21)
			Me.oo_o.0000.().TabIndex = 0
			Me.oo_o.0000.().Tag = Nothing
			Me.O_O0_OO0.0__.().DialogResult = DialogResult.Cancel
			Me.O_O0_OO0.0__.().Location = New Point(167, 71)
			Me.O_O0_OO0.0__.().Name = "Button2"
			Me.O_O0_OO0.0__.().Size = New Size(75, 23)
			Me.O_O0_OO0.0__.().TabIndex = 3
			Me.O_O0_OO0.0__.().Text = "取消"
			Me.O_O0_OO0.0__.().UseVisualStyleBackColor = True
			Me.oo_o.0000.().Location = New Point(86, 71)
			Me.oo_o.0000.().Name = "Button1"
			Me.oo_o.0000.().Size = New Size(75, 23)
			Me.oo_o.0000.().TabIndex = 2
			Me.oo_o.0000.().Text = "确定"
			Me.oo_o.0000.().UseVisualStyleBackColor = True
			Me.OoO__o_.o_O_.().AutoSize = True
			Me.OoO__o_.o_O_.().Location = New Point(17, 12)
			Me.OoO__o_.o_O_.().Name = "Label1"
			Me.OoO__o_.o_O_.().Size = New Size(41, 12)
			Me.OoO__o_.o_O_.().TabIndex = 13
			Me.OoO__o_.o_O_.().Text = "Label1"
			Me.O_O0_OO0.0__.().Calendar.AnnuallyBoldedDates = New DateTime(-1) {}
			Me.O_O0_OO0.0__.().Calendar.BoldedDates = New DateTime(-1) {}
			Me.O_O0_OO0.0__.().Calendar.ClearText = "&Clear"
			Me.O_O0_OO0.0__.().Calendar.Font = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134)
			Me.O_O0_OO0.0__.().Calendar.Margin = New Padding(0)
			Me.O_O0_OO0.0__.().Calendar.MonthlyBoldedDates = New DateTime(-1) {}
			Me.O_O0_OO0.0__.().Calendar.SelectedDate = New DateTime(2007, 11, 5, 0, 0, 0, 0)
			Me.O_O0_OO0.0__.().Calendar.TodayText = "&Today"
			Me.O_O0_OO0.0__.().Calendar.VisualStyle = 1
			Me.O_O0_OO0.0__.().Calendar.VisualStyleBaseStyle = 1
			Me.O_O0_OO0.0__.().DateTimeInput = False
			Me.O_O0_OO0.0__.().FormatType = 2
			Me.O_O0_OO0.0__.().Location = New Point(180, 34)
			Me.O_O0_OO0.0__.().MaskInfo.ShowLiterals = 3
			Me.O_O0_OO0.0__.().Name = "C1DateEdit2"
			Me.O_O0_OO0.0__.().Size = New Size(132, 21)
			Me.O_O0_OO0.0__.().TabIndex = 1
			Me.O_O0_OO0.0__.().Tag = Nothing
			Me.O.OO0_.().AutoSize = True
			Me.O.OO0_.().Location = New Point(157, 37)
			Me.O.OO0_.().Name = "Label2"
			Me.O.OO0_.().Size = New Size(17, 12)
			Me.O.OO0_.().TabIndex = 18
			Me.O.OO0_.().Text = "至"
			MyBase.AcceptButton = Me.oo_o.0000.()
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.CancelButton = Me.O_O0_OO0.0__.()
			MyBase.ClientSize = New Size(328, 104)
			MyBase.Controls.Add(Me.O.OO0_.())
			MyBase.Controls.Add(Me.O_O0_OO0.0__.())
			MyBase.Controls.Add(Me.oo_o.0000.())
			MyBase.Controls.Add(Me.O_O0_OO0.0__.())
			MyBase.Controls.Add(Me.oo_o.0000.())
			MyBase.Controls.Add(Me.OoO__o_.o_O_.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O.o0..0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "日期筛选"
			Me.oo_o.0000.().EndInit()
			Me.O_O0_OO0.0__.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600336E RID: 13166 RVA: 0x00152354 File Offset: 0x00150554
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1DateEdit
			Return Me.Oo0O.OO_.
		End Function

		' Token: 0x0600336F RID: 13167 RVA: 0x0015235C File Offset: 0x0015055C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DateEdit)
			Me.Oo0O.OO_. = A_0
		End Sub

		' Token: 0x06003370 RID: 13168 RVA: 0x00152365 File Offset: 0x00150565
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo0O.OO_.
		End Function

		' Token: 0x06003371 RID: 13169 RVA: 0x0015236D File Offset: 0x0015056D
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.Oo0O.OO_. = A_0
		End Sub

		' Token: 0x06003372 RID: 13170 RVA: 0x00152376 File Offset: 0x00150576
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.OO0_.
		End Function

		' Token: 0x06003373 RID: 13171 RVA: 0x00152380 File Offset: 0x00150580
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O_O0_OO0.0__.
			Dim o.OO0_. As C1Button = Me.O.OO0_.
			If o.OO0_. IsNot Nothing Then
				RemoveHandler o.OO0_..Click, value
			End If
			Me.O.OO0_. = A_0
			o.OO0_. = Me.O.OO0_.
			If o.OO0_. IsNot Nothing Then
				AddHandler o.OO0_..Click, value
			End If
		End Sub

		' Token: 0x06003374 RID: 13172 RVA: 0x001523C3 File Offset: 0x001505C3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo0O.OO_.
		End Function

		' Token: 0x06003375 RID: 13173 RVA: 0x001523CB File Offset: 0x001505CB
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo0O.OO_. = A_0
		End Sub

		' Token: 0x06003376 RID: 13174 RVA: 0x001523D4 File Offset: 0x001505D4
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1DateEdit
			Return Me.oo_o_Oo_.oo0.
		End Function

		' Token: 0x06003377 RID: 13175 RVA: 0x001523DC File Offset: 0x001505DC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1DateEdit)
			Me.oo_o_Oo_.oo0. = A_0
		End Sub

		' Token: 0x06003378 RID: 13176 RVA: 0x001523E5 File Offset: 0x001505E5
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo_o_Oo_.oo0.
		End Function

		' Token: 0x06003379 RID: 13177 RVA: 0x001523ED File Offset: 0x001505ED
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo_o_Oo_.oo0. = A_0
		End Sub

		' Token: 0x0600337A RID: 13178 RVA: 0x001523F8 File Offset: 0x001505F8
		Public Sub New(A_0 As Table, A_1 As Col, A_2 As Boolean)
			AddHandler MyBase.FormClosed, AddressOf Me.O_O0_OO0.0__.
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.OoO__o_.o_O_.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_3E:
				num = 4
				Me.Oo0O.OO_. = A_0
				IL_47:
				num = 5
				Me.Oo0O.OO_. = A_1
				IL_50:
				num = 6
				Me.Oo0O.OO_. = A_2
				IL_59:
				num = 7
				If Not A_2 Then
					GoTo IL_7D
				End If
				IL_5E:
				num = 8
				Me.OoO__o_.o_O_.().Text = A_1.Name + " 在以下范围之外:"
				GoTo IL_9B
				IL_7D:
				num = 10
				Me.OoO__o_.o_O_.().Text = A_1.Name + " 在以下范围之内:"
				IL_9B:
				num = 11
				Me.oo_o.0000.().EditMask = A_0.foxGrid.Cols(A_1.Name).EditMask
				IL_C4:
				num = 12
				Me.oo_o.0000.().CustomFormat = A_0.foxGrid.Cols(A_1.Name).Format
				IL_ED:
				num = 13
				If A_1.DataCol.DateTimeFormat Is Nothing Then
					GoTo IL_10C
				End If
				IL_FD:
				num = 14
				Me.oo_o.0000.().VisibleButtons = 0
				IL_10C:
				num = 15
				Me.O_O0_OO0.0__.().EditMask = A_0.foxGrid.Cols(A_1.Name).EditMask
				IL_135:
				num = 16
				Me.O_O0_OO0.0__.().CustomFormat = A_0.foxGrid.Cols(A_1.Name).Format
				IL_15E:
				num = 17
				If A_1.DataCol.DateTimeFormat Is Nothing Then
					GoTo IL_17D
				End If
				IL_16E:
				num = 18
				Me.O_O0_OO0.0__.().VisibleButtons = 0
				IL_17D:
				GoTo IL_21B
				IL_182:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1DC:
				GoTo IL_210
				IL_1DE:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_1EE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1DE
			End Try
			IL_210:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_21B:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600337B RID: 13179 RVA: 0x00152644 File Offset: 0x00150844
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.oo_o.0000.().Value IsNot DBNull.Value AndAlso Me.O_O0_OO0.0__.().Value IsNot DBNull.Value Then
				Dim a_ As DateTime = Conversions.ToDate(Me.oo_o.0000.().Value)
				Dim a_2 As DateTime = Conversions.ToDate(Me.O_O0_OO0.0__.().Value)
				Filter.O0O0o.Oo0OO_oO.(Me.Oo0O.OO_., Me.Oo0O.OO_..Name, a_, a_2, Me.Oo0O.OO_.)
				MyBase.DialogResult = DialogResult.OK
			End If
		End Sub

		' Token: 0x0600337C RID: 13180 RVA: 0x001526BC File Offset: 0x001508BC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040014D3 RID: 5331
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040014D4 RID: 5332
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DateEdit

		' Token: 0x040014D5 RID: 5333
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014D6 RID: 5334
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040014D7 RID: 5335
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014D8 RID: 5336
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1DateEdit

		' Token: 0x040014D9 RID: 5337
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x040014DA RID: 5338
		Private <<EMPTY_NAME>> As Table

		' Token: 0x040014DB RID: 5339
		Private <<EMPTY_NAME>> As Col

		' Token: 0x040014DC RID: 5340
		Private <<EMPTY_NAME>> As Boolean
	End Class
End Namespace
