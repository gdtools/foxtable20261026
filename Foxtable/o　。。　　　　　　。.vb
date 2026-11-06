Imports System
Imports System.Collections
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
	' Token: 0x02000335 RID: 821
	<DesignerGenerated()>
	Friend Partial Class o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002
		Inherits Form

		' Token: 0x0600311C RID: 12572 RVA: 0x0013EB00 File Offset: 0x0013CD00
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.O0.__O0O. IsNot Nothing Then
					Me.O0.__O0O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600311D RID: 12573 RVA: 0x0013EB40 File Offset: 0x0013CD40
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O_o_00.00O0.(New C1FlexGrid())
			Me.O_o_00.00O0.(New C1ComboBox())
			Me.O0.00_0_.(New C1Button())
			Me.o_oO.oo0OoO_O.(New C1Button())
			Me.O0.00_0_.(New OpenFileDialog())
			Me.O_._OoOOOo__o_.(New RadioButton())
			Me.O_o_00.00O0.(New RadioButton())
			Me.OO._OOO.(New RadioButton())
			Me.OoO_.O.().BeginInit()
			MyBase.SuspendLayout()
			Me.OoO_.O.().AllowEditing = False
			Me.OoO_.O.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.OoO_.O.().Location = New Point(12, 48)
			Me.OoO_.O.().Name = "Grid"
			Me.OoO_.O.().Rows.Count = 1
			Me.OoO_.O.().Rows.DefaultSize = 20
			Me.OoO_.O.().SelectionMode = 5
			Me.OoO_.O.().Size = New Size(646, 345)
			Me.OoO_.O.().TabIndex = 1
			Me.O0.00_0_.().DropDownStyle = 1
			Me.O0.00_0_.().Location = New Point(12, 12)
			Me.O0.00_0_.().Name = "lstTables"
			Me.O0.00_0_.().Size = New Size(374, 20)
			Me.O0.00_0_.().TabIndex = 0
			Me.o_Oo_o.OoO_o.().DialogResult = DialogResult.Cancel
			Me.o_Oo_o.OoO_o.().Location = New Point(333, 442)
			Me.o_Oo_o.OoO_o.().Name = "Button3"
			Me.o_Oo_o.OoO_o.().Size = New Size(75, 23)
			Me.o_Oo_o.OoO_o.().TabIndex = 6
			Me.o_Oo_o.OoO_o.().Text = "取消"
			Me.o_Oo_o.OoO_o.().UseVisualStyleBackColor = True
			Me.OoO_.O.().Location = New Point(252, 442)
			Me.OoO_.O.().Name = "Button2"
			Me.OoO_.O.().Size = New Size(75, 23)
			Me.OoO_.O.().TabIndex = 5
			Me.OoO_.O.().Text = "确定"
			Me.OoO_.O.().UseVisualStyleBackColor = True
			Me.OoO_.O.().Filter = "XML文件(*.xml)|*.xml"
			Me.o_oO.oo0OoO_O.().AutoSize = True
			Me.o_oO.oo0OoO_O.().Location = New Point(272, 408)
			Me.o_oO.oo0OoO_O.().Name = "IgnorePrimaryKey"
			Me.o_oO.oo0OoO_O.().Size = New Size(203, 16)
			Me.o_oO.oo0OoO_O.().TabIndex = 4
			Me.o_oO.oo0OoO_O.().Text = "合并过程不比较主键(无条件合并)"
			Me.o_oO.oo0OoO_O.().UseVisualStyleBackColor = True
			Me.OO0O.o_oOO.().AutoSize = True
			Me.OO0O.o_oOO.().Checked = True
			Me.OO0O.o_oOO.().Location = New Point(142, 408)
			Me.OO0O.o_oOO.().Name = "SkipExistRow"
			Me.OO0O.o_oOO.().Size = New Size(107, 16)
			Me.OO0O.o_oOO.().TabIndex = 3
			Me.OO0O.o_oOO.().TabStop = True
			Me.OO0O.o_oOO.().Text = "跳过同主键记录"
			Me.OO0O.o_oOO.().UseVisualStyleBackColor = True
			Me.O0.00_0_.().AutoSize = True
			Me.O0.00_0_.().Location = New Point(12, 408)
			Me.O0.00_0_.().Name = "UpdateExistRow"
			Me.O0.00_0_.().Size = New Size(107, 16)
			Me.O0.00_0_.().TabIndex = 2
			Me.O0.00_0_.().Text = "更新同主键记录"
			Me.O0.00_0_.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(673, 477)
			MyBase.Controls.Add(Me.o_oO.oo0OoO_O.())
			MyBase.Controls.Add(Me.OO0O.o_oOO.())
			MyBase.Controls.Add(Me.O0.00_0_.())
			MyBase.Controls.Add(Me.OoO_.O.())
			MyBase.Controls.Add(Me.O0.00_0_.())
			MyBase.Controls.Add(Me.o_Oo_o.OoO_o.())
			MyBase.Controls.Add(Me.OoO_.O.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o....O0."
			MyBase.ShowIcon = False
			Me.Text = "合并"
			Me.OoO_.O.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600311E RID: 12574 RVA: 0x0013EFDF File Offset: 0x0013D1DF
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.O_o_00.00O0.
		End Function

		' Token: 0x0600311F RID: 12575 RVA: 0x0013EFE7 File Offset: 0x0013D1E7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.O_o_00.00O0. = A_0
		End Sub

		' Token: 0x06003120 RID: 12576 RVA: 0x0013EFF0 File Offset: 0x0013D1F0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.O0.__O0O.
		End Function

		' Token: 0x06003121 RID: 12577 RVA: 0x0013EFF8 File Offset: 0x0013D1F8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o_oO.oo0OoO_O.
			Dim o0.__O0O. As C1ComboBox = Me.O0.__O0O.
			If o0.__O0O. IsNot Nothing Then
				o0.__O0O..SelectedIndexChanged -= eventHandler
			End If
			Me.O0.__O0O. = A_0
			o0.__O0O. = Me.O0.__O0O.
			If o0.__O0O. IsNot Nothing Then
				o0.__O0O..SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x06003122 RID: 12578 RVA: 0x0013F03B File Offset: 0x0013D23B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_o_00.00O0.
		End Function

		' Token: 0x06003123 RID: 12579 RVA: 0x0013F043 File Offset: 0x0013D243
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O_o_00.00O0. = A_0
		End Sub

		' Token: 0x06003124 RID: 12580 RVA: 0x0013F04C File Offset: 0x0013D24C
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O_._OoOOOo__o_.
		End Function

		' Token: 0x06003125 RID: 12581 RVA: 0x0013F054 File Offset: 0x0013D254
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.OoO_.O.
			Dim o_._OoOOOo__o_. As C1Button = Me.O_._OoOOOo__o_.
			If o_._OoOOOo__o_. IsNot Nothing Then
				RemoveHandler o_._OoOOOo__o_..Click, value
			End If
			Me.O_._OoOOOo__o_. = A_0
			o_._OoOOOo__o_. = Me.O_._OoOOOo__o_.
			If o_._OoOOOo__o_. IsNot Nothing Then
				AddHandler o_._OoOOOo__o_..Click, value
			End If
		End Sub

		' Token: 0x06003126 RID: 12582 RVA: 0x0013F097 File Offset: 0x0013D297
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As OpenFileDialog
			Return Me.O_o_00.00O0.
		End Function

		' Token: 0x06003127 RID: 12583 RVA: 0x0013F09F File Offset: 0x0013D29F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As OpenFileDialog)
			Me.O_o_00.00O0. = A_0
		End Sub

		' Token: 0x06003128 RID: 12584 RVA: 0x0013F0A8 File Offset: 0x0013D2A8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O_o_00.00O0.
		End Function

		' Token: 0x06003129 RID: 12585 RVA: 0x0013F0B0 File Offset: 0x0013D2B0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O_o_00.00O0. = A_0
		End Sub

		' Token: 0x0600312A RID: 12586 RVA: 0x0013F0B9 File Offset: 0x0013D2B9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0O.O.
		End Function

		' Token: 0x0600312B RID: 12587 RVA: 0x0013F0C1 File Offset: 0x0013D2C1
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0O.O. = A_0
		End Sub

		' Token: 0x0600312C RID: 12588 RVA: 0x0013F0CA File Offset: 0x0013D2CA
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.O0__oo__0_O.0_.
		End Function

		' Token: 0x0600312D RID: 12589 RVA: 0x0013F0D2 File Offset: 0x0013D2D2
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.O0__oo__0_O.0_. = A_0
		End Sub

		' Token: 0x0600312E RID: 12590 RVA: 0x0013F0DB File Offset: 0x0013D2DB
		Public Sub New()
			AddHandler MyBase.FormClosed, AddressOf Me.OoO_.O.
			Me.O0.00_0_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x0600312F RID: 12591 RVA: 0x0013F110 File Offset: 0x0013D310
		Friend Function <<EMPTY_NAME>>() As Boolean
			Me.O0.__O0O. = New DataSet()
			Me.O0.__O0O..ReadXml(Me.O0.__O0O.)
			Dim result As Boolean
			If Me.O0.__O0O..Tables.Count > 0 Then
				Me.O0.00_0_.().Items.Add("请选择要合并的表...")
				Try
					For Each obj As Object In Me.O0.__O0O..Tables
						Dim dataTable As DataTable = CType(obj, DataTable)
						Me.O0.00_0_.().Items.Add(dataTable.TableName)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If Me.O0.00_0_.().Items.Count = 2 Then
					Me.O0.00_0_.().SelectedIndex = 1
				Else
					Me.O0.00_0_.().SelectedIndex = 0
				End If
				result = True
			End If
			Return result
		End Function

		' Token: 0x06003130 RID: 12592 RVA: 0x0013F1FC File Offset: 0x0013D3FC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.OoO_.O.().AutoResize = True
			If Me.O0.00_0_.().SelectedIndex = 0 Then
				Me.OoO_.O.().DataSource = Nothing
				Return
			End If
			Me.OoO_.O.().DataSource = Me.O0.__O0O..Tables(Me.O0.00_0_.().SelectedItem.ToString())
			For i As Integer = Me.OoO_.O.().Cols.Count - 1 To 1 Step -1
				If o_O_o_oOoo__.oO.O_..Contains(Me.OoO_.O.().Cols(i).Name) Then
					Me.OoO_.O.().Cols.Remove(i)
				End If
			Next
		End Sub

		' Token: 0x06003131 RID: 12593 RVA: 0x0013F2AC File Offset: 0x0013D4AC
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0.00_0_.().SelectedIndex >= 1 Then
				Try
					Dim a_ As TableMergeTypeEnum
					If Me.O0.00_0_.().Checked Then
						a_ = 0
					ElseIf Me.o_oO.oo0OoO_O.().Checked Then
						a_ = 2
					Else
						a_ = 0
					End If
					Me.Cursor = Cursors.WaitCursor
					If Oo00.o00O0O_.O.(Me.OoO_.O.(), Me.O0.00_0_.().SelectedItem.ToString(), a_) Then
						MyBase.DialogResult = DialogResult.OK
					End If
				Catch a_2 As Exception
					ooO.oOo0Oo.o.(a_2, "")
					Me.Cursor = Cursors.[Default]
				End Try
			End If
		End Sub

		' Token: 0x06003132 RID: 12594 RVA: 0x0013F354 File Offset: 0x0013D554
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040013B4 RID: 5044
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040013B5 RID: 5045
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040013B6 RID: 5046
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x040013B7 RID: 5047
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013B8 RID: 5048
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040013B9 RID: 5049
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As OpenFileDialog

		' Token: 0x040013BA RID: 5050
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013BB RID: 5051
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013BC RID: 5052
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x040013BD RID: 5053
		Friend <<EMPTY_NAME>> As String

		' Token: 0x040013BE RID: 5054
		Friend <<EMPTY_NAME>> As DataSet
	End Class
End Namespace
