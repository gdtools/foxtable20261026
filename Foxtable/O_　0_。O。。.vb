Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000380 RID: 896
	<DesignerGenerated()>
	Friend Partial Class O_\u30000_\u3002O\u3002\u3002\u3000\u3000
		Inherits Form

		' Token: 0x06003973 RID: 14707 RVA: 0x0018D55A File Offset: 0x0018B75A
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.OOo0_0o00_0.O. IsNot Nothing Then
				Me.OOo0_0o00_0.O..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003974 RID: 14708 RVA: 0x0018D57C File Offset: 0x0018B77C
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O_00.0.(New C1FlexGrid())
			Me.O_00.0.(New C1Button())
			Me.OOo0_0o00_0.O.(New oO_oO000oo())
			Me.OOo0_0o00_0.O.(New SplitContainer())
			Me.O_00.0.().BeginInit()
			Me.O_00.0.().BeginInit()
			CType(Me.O_00.0.(), ISupportInitialize).BeginInit()
			Me.O_00.0.().Panel1.SuspendLayout()
			Me.O_00.0.().Panel2.SuspendLayout()
			Me.O_00.0.().SuspendLayout()
			MyBase.SuspendLayout()
			Me.O_00.0.().ColumnInfo = "10,1,0,0,0,0,Columns:"
			Me.O_00.0.().Dock = DockStyle.Fill
			Me.O_00.0.().Location = New Point(0, 0)
			Me.O_00.0.().Name = "C1FlexGrid1"
			Me.O_00.0.().Rows.DefaultSize = 19
			Me.O_00.0.().Size = New Size(712, 373)
			Me.O_00.0.().TabIndex = 0
			Me.O_00.0.().Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
			Me.O_00.0.().Location = New Point(639, 552)
			Me.O_00.0.().Name = "btnRefresh"
			Me.O_00.0.().Size = New Size(75, 23)
			Me.O_00.0.().TabIndex = 2
			Me.O_00.0.().Text = "刷新"
			Me.O_00.0.().UseVisualStyleBackColor = True
			Me.O_00.0.().AllowDrop = True
			Me.O_00.0.().Dock = DockStyle.Fill
			Me.O_00.0.().Location = New Point(0, 0)
			Me.O_00.0.().Name = "TextBox1"
			Me.O_00.0.().Size = New Size(712, 147)
			Me.O_00.0.().TabIndex = 3
			Me.O_00.0.().Anchor = (AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right)
			Me.O_00.0.().FixedPanel = FixedPanel.Panel2
			Me.O_00.0.().Location = New Point(7, 12)
			Me.O_00.0.().Name = "SplitContainer1"
			Me.O_00.0.().Orientation = Orientation.Horizontal
			Me.O_00.0.().Panel1.Controls.Add(Me.O_00.0.())
			Me.O_00.0.().Panel2.Controls.Add(Me.O_00.0.())
			Me.O_00.0.().Size = New Size(712, 524)
			Me.O_00.0.().SplitterDistance = 373
			Me.O_00.0.().TabIndex = 4
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(726, 587)
			MyBase.Controls.Add(Me.O_00.0.())
			MyBase.Controls.Add(Me.O_00.0.())
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "frmOuterTablePreview"
			MyBase.ShowIcon = False
			Me.Text = "预览"
			Me.O_00.0.().EndInit()
			Me.O_00.0.().EndInit()
			Me.O_00.0.().Panel1.ResumeLayout(False)
			Me.O_00.0.().Panel2.ResumeLayout(False)
			CType(Me.O_00.0.(), ISupportInitialize).EndInit()
			Me.O_00.0.().ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003975 RID: 14709 RVA: 0x0018D8D8 File Offset: 0x0018BAD8
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.OOo0_0o00_0.O.
		End Function

		' Token: 0x06003976 RID: 14710 RVA: 0x0018D8E0 File Offset: 0x0018BAE0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.OOo0_0o00_0.O. = A_0
		End Sub

		' Token: 0x06003977 RID: 14711 RVA: 0x0018D8E9 File Offset: 0x0018BAE9
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.OOo0_0o00_0.O.
		End Function

		' Token: 0x06003978 RID: 14712 RVA: 0x0018D8F4 File Offset: 0x0018BAF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O._O_O.
			Dim ooo0_0o00_0.O. As C1Button = Me.OOo0_0o00_0.O.
			If ooo0_0o00_0.O. IsNot Nothing Then
				RemoveHandler ooo0_0o00_0.O..Click, value
			End If
			Me.OOo0_0o00_0.O. = A_0
			ooo0_0o00_0.O. = Me.OOo0_0o00_0.O.
			If ooo0_0o00_0.O. IsNot Nothing Then
				AddHandler ooo0_0o00_0.O..Click, value
			End If
		End Sub

		' Token: 0x06003979 RID: 14713 RVA: 0x0018D937 File Offset: 0x0018BB37
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As oO_oO000oo
			Return Me.OOo0_0o00_0.O.
		End Function

		' Token: 0x0600397A RID: 14714 RVA: 0x0018D93F File Offset: 0x0018BB3F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As oO_oO000oo)
			Me.OOo0_0o00_0.O. = A_0
		End Sub

		' Token: 0x0600397B RID: 14715 RVA: 0x0018D948 File Offset: 0x0018BB48
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As SplitContainer
			Return Me.OOo0_0o00_0.O.
		End Function

		' Token: 0x0600397C RID: 14716 RVA: 0x0018D950 File Offset: 0x0018BB50
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As SplitContainer)
			Me.OOo0_0o00_0.O. = A_0
		End Sub

		' Token: 0x0600397D RID: 14717 RVA: 0x0018D95C File Offset: 0x0018BB5C
		Public Sub New(A_0 As OleDbConnection, A_1 As String, Optional A_2 As O0O = Nothing)
			AddHandler MyBase.FormClosed, AddressOf Me.O_00.0.
			Me.o.o_0oo_o_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.OOo0_0o00_0.O. = A_0
			Me.OOo0_0o00_0.O. = A_2
			Me.O_00.0.().Text = A_1
			Me.O_00.0.()
		End Sub

		' Token: 0x0600397E RID: 14718 RVA: 0x0018D9BC File Offset: 0x0018BBBC
		Private Overloads Sub <<EMPTY_NAME>>()
			Dim dataTable As DataTable = New DataTable()
			Try
				If Me.OOo0_0o00_0.O. IsNot Nothing Then
					Dim selectCommandText As String = Oo00.o0_o._O_.(Me.OOo0_0o00_0.O., Me.O_00.0.().Text, False)
					New OleDbDataAdapter(selectCommandText, Me.OOo0_0o00_0.O.).Fill(dataTable)
					Try
						For Each obj As Object In dataTable.Columns
							Dim dataColumn As DataColumn = CType(obj, DataColumn)
							If dataColumn.ColumnName.StartsWith("~TMPCLP") Then
								dataColumn.Caption = dataColumn.ColumnName.Substring(7)
							End If
						Next
						GoTo IL_100
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				Dim httpClient As HttpClient = Me.OOo0_0o00_0.O..oO0_0.o.()
				httpClient.FormData("Action") = 2.ToString()
				httpClient.[Select] = Oo00.o0_o._O_.(Me.OOo0_0o00_0.O..OO.OoO0., Me.O_00.0.().Text, False)
				httpClient.FormData("IgnoreSchema") = "True"
				dataTable = httpClient.GetBaseDataTable()
				httpClient.Reset()
				IL_100:
				Dim c1FlexGrid As C1FlexGrid = Me.O_00.0.()
				c1FlexGrid.AutoResize = True
				c1FlexGrid.DataSource = dataTable
				Dim num As Integer = c1FlexGrid.Cols.Count - 1
				For i As Integer = 0 To num
					If c1FlexGrid.Cols(i).DataType Is GetType(Double) OrElse c1FlexGrid.Cols(i).DataType Is GetType(Decimal) OrElse c1FlexGrid.Cols(i).DataType Is GetType(Decimal) Then
						c1FlexGrid.Cols(i).Format = "#0.####"
					End If
				Next
			Catch a_ As Exception
				ooO.oOo0Oo.o.(a_, "")
				If Me.OOo0_0o00_0.O..State <> ConnectionState.Closed Then
					Me.OOo0_0o00_0.O..Close()
				End If
			End Try
		End Sub

		' Token: 0x0600397F RID: 14719 RVA: 0x0018DBE8 File Offset: 0x0018BDE8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_00.0.()
		End Sub

		' Token: 0x06003980 RID: 14720 RVA: 0x0018DBF0 File Offset: 0x0018BDF0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040017C7 RID: 6087
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017C8 RID: 6088
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x040017C9 RID: 6089
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017CA RID: 6090
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As oO_oO000oo

		' Token: 0x040017CB RID: 6091
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As SplitContainer

		' Token: 0x040017CC RID: 6092
		Private <<EMPTY_NAME>> As OleDbConnection

		' Token: 0x040017CD RID: 6093
		Private <<EMPTY_NAME>> As O0O
	End Class
End Namespace
