Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200036F RID: 879
	<DesignerGenerated()>
	Friend Partial Class gg
		Inherits Form

		' Token: 0x06003784 RID: 14212 RVA: 0x00179CEC File Offset: 0x00177EEC
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.ooO0o.0o_. IsNot Nothing Then
					Me.ooO0o.0o_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003785 RID: 14213 RVA: 0x00179D2C File Offset: 0x00177F2C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(gg))
			Me.O_O.0Ooo_.(New C1FlexGrid())
			Me.O_O.0Ooo_.(New C1Button())
			Me.ooO0o.0OO0oO_O.(New C1Button())
			Me.o_ooo0O.OO.(New C1Button())
			Me.O_O.0Ooo_.().BeginInit()
			MyBase.SuspendLayout()
			Me.O_O.0Ooo_.().AllowDelete = True
			Me.O_O.0Ooo_.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo")
			Me.O_O.0Ooo_.().ExtendLastCol = True
			Me.O_O.0Ooo_.().Location = New Point(13, 12)
			Me.O_O.0Ooo_.().Name = "C1FlexGrid1"
			Me.O_O.0Ooo_.().Rows.Count = 1
			Me.O_O.0Ooo_.().Rows.DefaultSize = 20
			Me.O_O.0Ooo_.().Size = New Size(380, 215)
			Me.O_O.0Ooo_.().TabIndex = 0
			Me.O_O.0Ooo_.().DialogResult = DialogResult.OK
			Me.O_O.0Ooo_.().Location = New Point(237, 242)
			Me.O_O.0Ooo_.().Name = "btnOK"
			Me.O_O.0Ooo_.().Size = New Size(75, 23)
			Me.O_O.0Ooo_.().TabIndex = 1
			Me.O_O.0Ooo_.().Text = "确定"
			Me.O_O.0Ooo_.().UseVisualStyleBackColor = True
			Me.ooO0o.0OO0oO_O.().DialogResult = DialogResult.Cancel
			Me.ooO0o.0OO0oO_O.().Location = New Point(318, 242)
			Me.ooO0o.0OO0oO_O.().Name = "btnCancel"
			Me.ooO0o.0OO0oO_O.().Size = New Size(75, 23)
			Me.ooO0o.0OO0oO_O.().TabIndex = 2
			Me.ooO0o.0OO0oO_O.().Text = "取消"
			Me.ooO0o.0OO0oO_O.().UseVisualStyleBackColor = True
			Me.o_ooo0O.OO.().Location = New Point(13, 242)
			Me.o_ooo0O.OO.().Name = "btnDel"
			Me.o_ooo0O.OO.().Size = New Size(75, 23)
			Me.o_ooo0O.OO.().TabIndex = 4
			Me.o_ooo0O.OO.().Text = "删除"
			Me.o_ooo0O.OO.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(404, 277)
			MyBase.Controls.Add(Me.o_ooo0O.OO.())
			MyBase.Controls.Add(Me.ooO0o.0OO0oO_O.())
			MyBase.Controls.Add(Me.O_O.0Ooo_.())
			MyBase.Controls.Add(Me.O_O.0Ooo_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "oOO0.0.."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "全局变量"
			Me.O_O.0Ooo_.().EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003786 RID: 14214 RVA: 0x0017A02F File Offset: 0x0017822F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.ooO0o.0o_.
		End Function

		' Token: 0x06003787 RID: 14215 RVA: 0x0017A037 File Offset: 0x00178237
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.ooO0o.0o_. = A_0
		End Sub

		' Token: 0x06003788 RID: 14216 RVA: 0x0017A040 File Offset: 0x00178240
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO0o.0o_.
		End Function

		' Token: 0x06003789 RID: 14217 RVA: 0x0017A048 File Offset: 0x00178248
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_0_.oO_OoO.
			Dim c1Button As C1Button = Me.ooO0o.0o_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO0o.0o_. = A_0
			c1Button = Me.ooO0o.0o_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600378A RID: 14218 RVA: 0x0017A08B File Offset: 0x0017828B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_ooo0O.OO.
		End Function

		' Token: 0x0600378B RID: 14219 RVA: 0x0017A093 File Offset: 0x00178293
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_ooo0O.OO. = A_0
		End Sub

		' Token: 0x0600378C RID: 14220 RVA: 0x0017A09C File Offset: 0x0017829C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.OoOO.O_o_.
		End Function

		' Token: 0x0600378D RID: 14221 RVA: 0x0017A0A4 File Offset: 0x001782A4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0o_o.o0.
			Dim ooOO.O_o_. As C1Button = Me.OoOO.O_o_.
			If ooOO.O_o_. IsNot Nothing Then
				RemoveHandler ooOO.O_o_..Click, value
			End If
			Me.OoOO.O_o_. = A_0
			ooOO.O_o_. = Me.OoOO.O_o_.
			If ooOO.O_o_. IsNot Nothing Then
				AddHandler ooOO.O_o_..Click, value
			End If
		End Sub

		' Token: 0x0600378E RID: 14222 RVA: 0x0017A0E8 File Offset: 0x001782E8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.o._OoOO_0.
			AddHandler MyBase.FormClosed, AddressOf Me.O0o_o.o0.
			Me.O_O.0Ooo_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Dim c1FlexGrid As C1FlexGrid = Me.O_O.0Ooo_.()
			c1FlexGrid.Styles.SelectedColumnHeader.Clear()
			c1FlexGrid.Styles.Alternate.Clear()
			c1FlexGrid.Styles.Focus.Clear()
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
			c1FlexGrid.FocusRect = 3
			c1FlexGrid.AllowSorting = 0
		End Sub

		' Token: 0x0600378F RID: 14223 RVA: 0x0017A19C File Offset: 0x0017839C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Me.ooO0o.0o_. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { "Variables", o0_O.O0oO__._0OO00o. })
				IL_45:
				num2 = 3
				If Me.ooO0o.0o_. IsNot Nothing Then
					GoTo IL_C6
				End If
				IL_4F:
				num2 = 4
				Me.ooO0o.0o_. = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
				IL_70:
				num2 = 5
				Me.ooO0o.0o_.("Name") = "Variables"
				IL_87:
				num2 = 6
				Me.ooO0o.0o_.("Type") = o0_O.O0oO__._0OO00o.
				IL_A0:
				num2 = 7
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(Me.ooO0o.0o_.)
				IL_C6:
				num2 = 8
				If Me.ooO0o.0o_..IsNull("Config") Then
					GoTo IL_147
				End If
				IL_DA:
				num2 = 9
				Dim array As String() = Conversions.ToString(Me.ooO0o.0o_.("Config")).Split(New Char() { vbCr, vbLf }, StringSplitOptions.RemoveEmptyEntries)
				IL_109:
				num2 = 10
				For Each str As String In array
					IL_11B:
					num2 = 11
					Me.O_O.0Ooo_.().AddItem(vbTab + str)
					IL_136:
					num2 = 12
				Next
				IL_147:
				num2 = 13
				Me.O_O.0Ooo_.().AllowAddNew = True
				IL_156:
				GoTo IL_1E0
				IL_15B:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1A1:
				GoTo IL_1D5
				IL_1A3:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1B3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1A3
			End Try
			IL_1D5:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1E0:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003790 RID: 14224 RVA: 0x0017A3B0 File Offset: 0x001785B0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim c1FlexGrid As C1FlexGrid = Me.O_O.0Ooo_.()
			If c1FlexGrid.Rows.Count > 2 Then
				Me.ooO0o.0o_.("Config") = c1FlexGrid.GetCellRange(1, 1, c1FlexGrid.Rows.Count - 2, 3).Clip
			Else
				Me.ooO0o.0o_.("Config") = ""
			End If
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
			OO_00oOO.Vars.Clear()
			ooO.O._oO_0O__o__o.()
		End Sub

		' Token: 0x06003791 RID: 14225 RVA: 0x0017A444 File Offset: 0x00178644
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O_O.0Ooo_.().Row >= 1 AndAlso Me.O_O.0Ooo_.().Row < Me.O_O.0Ooo_.().Rows.Count - 1 Then
				Me.O_O.0Ooo_.().Rows.Remove(Me.O_O.0Ooo_.().Row)
			End If
			Me.O_O.0Ooo_.().Focus()
		End Sub

		' Token: 0x06003792 RID: 14226 RVA: 0x0017A4A6 File Offset: 0x001786A6
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040016E1 RID: 5857
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040016E2 RID: 5858
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040016E3 RID: 5859
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016E4 RID: 5860
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016E5 RID: 5861
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040016E6 RID: 5862
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
