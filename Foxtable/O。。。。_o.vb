Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports C1.Win.C1Input
Imports Foxtable.Syscmd
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000258 RID: 600
	<DesignerGenerated()>
	Friend Partial Class O\u3002\u3002\u3002\u3002_o\u3000
		Inherits Form

		' Token: 0x06001C04 RID: 7172 RVA: 0x000B0E94 File Offset: 0x000AF094
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.o0_o0.o_0_. IsNot Nothing Then
					Me.o0_o0.o_0_..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06001C05 RID: 7173 RVA: 0x000B0ED4 File Offset: 0x000AF0D4
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o0_o0.o_0_.(New Label())
			Me.o.__o.(New RadioButton())
			Me.o0_o0.o_0_.(New RadioButton())
			Me.oOO._o00o00__.(New C1Button())
			Me.o.__o.(New C1Button())
			MyBase.SuspendLayout()
			Me.oOO._o00o00__.().AutoSize = True
			Me.oOO._o00o00__.().Location = New Point(12, 29)
			Me.oOO._o00o00__.().Name = "Label1"
			Me.oOO._o00o00__.().Size = New Size(0, 12)
			Me.oOO._o00o00__.().TabIndex = 0
			Me.oOO._o00o00__.().AutoSize = True
			Me.oOO._o00o00__.().Checked = True
			Me.oOO._o00o00__.().Location = New Point(38, 66)
			Me.oOO._o00o00__.().Name = "rdoNo"
			Me.oOO._o00o00__.().Size = New Size(131, 16)
			Me.oOO._o00o00__.().TabIndex = 1
			Me.oOO._o00o00__.().TabStop = True
			Me.oOO._o00o00__.().Text = "否，我要考虑一下！"
			Me.oOO._o00o00__.().UseVisualStyleBackColor = True
			Me.O.ooOOO_0O.().AutoSize = True
			Me.O.ooOOO_0O.().Location = New Point(38, 88)
			Me.O.ooOOO_0O.().Name = "rdoYes"
			Me.O.ooOOO_0O.().Size = New Size(131, 16)
			Me.O.ooOOO_0O.().TabIndex = 2
			Me.O.ooOOO_0O.().Text = "是，我确定要转换！"
			Me.O.ooOOO_0O.().UseVisualStyleBackColor = True
			Me.O.ooOOO_0O.().Location = New Point(63, 138)
			Me.O.ooOOO_0O.().Name = "Button1"
			Me.O.ooOOO_0O.().Size = New Size(75, 23)
			Me.O.ooOOO_0O.().TabIndex = 3
			Me.O.ooOOO_0O.().Text = "确定"
			Me.O.ooOOO_0O.().UseVisualStyleBackColor = True
			Me.oOO._o00o00__.().Location = New Point(146, 138)
			Me.oOO._o00o00__.().Name = "Button2"
			Me.oOO._o00o00__.().Size = New Size(75, 23)
			Me.oOO._o00o00__.().TabIndex = 4
			Me.oOO._o00o00__.().Text = "取消"
			Me.oOO._o00o00__.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(284, 182)
			MyBase.Controls.Add(Me.oOO._o00o00__.())
			MyBase.Controls.Add(Me.O.ooOOO_0O.())
			MyBase.Controls.Add(Me.O.ooOOO_0O.())
			MyBase.Controls.Add(Me.oOO._o00o00__.())
			MyBase.Controls.Add(Me.oOO._o00o00__.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o.0.O0"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "转换列"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06001C06 RID: 7174 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As Label
			Return Me.o0_o0.o_0_.
		End Function

		' Token: 0x06001C07 RID: 7175 RVA: 0x000B1200 File Offset: 0x000AF400
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0_o0.o_0_. = A_0
		End Sub

		' Token: 0x06001C08 RID: 7176 RVA: 0x000B1209 File Offset: 0x000AF409
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o0_o0.o_0_.
		End Function

		' Token: 0x06001C09 RID: 7177 RVA: 0x000B1211 File Offset: 0x000AF411
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o0_o0.o_0_. = A_0
		End Sub

		' Token: 0x06001C0A RID: 7178 RVA: 0x000B121A File Offset: 0x000AF41A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As RadioButton
			Return Me.o.__o.
		End Function

		' Token: 0x06001C0B RID: 7179 RVA: 0x000B1222 File Offset: 0x000AF422
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As RadioButton)
			Me.o.__o. = A_0
		End Sub

		' Token: 0x06001C0C RID: 7180 RVA: 0x000B122B File Offset: 0x000AF42B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_o0.o_0_.
		End Function

		' Token: 0x06001C0D RID: 7181 RVA: 0x000B1234 File Offset: 0x000AF434
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00O__.oO.
			Dim c1Button As C1Button = Me.o0_o0.o_0_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_o0.o_0_. = A_0
			c1Button = Me.o0_o0.o_0_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001C0E RID: 7182 RVA: 0x000B1277 File Offset: 0x000AF477
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.__o.
		End Function

		' Token: 0x06001C0F RID: 7183 RVA: 0x000B1280 File Offset: 0x000AF480
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0_.0O_OOOo.
			Dim c1Button As C1Button = Me.o.__o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o.__o. = A_0
			c1Button = Me.o.__o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06001C10 RID: 7184 RVA: 0x000B12C3 File Offset: 0x000AF4C3
		Public Sub New()
			AddHandler MyBase.AutoSizeChanged, AddressOf Me.oOO._o00o00__.
			Me.oOO._o00o00__.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06001C11 RID: 7185 RVA: 0x000B12F8 File Offset: 0x000AF4F8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001C12 RID: 7186 RVA: 0x000B1300 File Offset: 0x000AF500
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
				If Not Me.oOO._o00o00__.().Checked Then
					GoTo IL_23
				End If
				IL_16:
				num2 = 3
				MyBase.Close()
				GoTo IL_41B
				IL_23:
				num2 = 5
				If Not Me.O.0o_0_. Then
					GoTo IL_22A
				End If
				IL_30:
				num2 = 6
				Dim columnDataTypeEnum As ColumnDataTypeEnum = Oo00.oO.OO.(Me.O.0o_0_..BaseColumn.DataType, Me.O.0o_0_.)
				IL_4E:
				num2 = 7
				Dim oleDbCommand As OleDbCommand = New OleDbCommand()
				IL_57:
				num2 = 8
				oleDbCommand.Connection = Me.O.0o_0_..DataTable.frd_Connection
				IL_70:
				num2 = 9
				oleDbCommand.CommandText = String.Concat(New String() { "Alter Table [", Me.O.0o_0_..DataTable.o._OOO0oOo0__..Trim(New Char() { "["c, "]"c }), "] Drop COLUMN [", Me.O.0o_0_..Name, "]" })
				IL_D3:
				num2 = 10
				oleDbCommand.Connection.Open()
				IL_E2:
				num2 = 11
				oleDbCommand.ExecuteNonQuery()
				IL_ED:
				num2 = 12
				oleDbCommand.Connection.Close()
				IL_FC:
				num2 = 13
				Me.O.0o_0_..IsTemporary = True
				IL_10B:
				num2 = 14
				Dim dataTable As DataTable = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.())
				IL_124:
				num2 = 15
				Dim dataRow As DataRow = dataTable.NewRow()
				IL_130:
				num2 = 16
				dataRow("Table") = Me.O.0o_0_..DataTable.Name
				IL_14F:
				num2 = 17
				dataRow("Column") = Me.O.0o_0_..Name
				IL_169:
				num2 = 18
				dataRow("DataType") = columnDataTypeEnum
				IL_17E:
				num2 = 19
				dataRow("MaxLength") = Me.O.0o_0_..MaxLength
				IL_19D:
				num2 = 20
				dataRow("Expression") = ""
				IL_1B1:
				num2 = 21
				dataTable.Rows.Add(dataRow)
				IL_1C2:
				dataTable = Nothing
				IL_1C5:
				num2 = 23
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
				IL_1E2:
				num2 = 24
				MyBase.Close()
				IL_1EB:
				num2 = 25
				MessageBox.Show("[" + Me.O.0o_0_..Name + "]已经成功转为表达式列，需要重新打开项目才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_216:
				num2 = 26
				Project.Open(OO_00oOO.ProjectFile, New String(-1) {})
				IL_22A:
				num2 = 27
				If Not Me.O_0oo.O0. Then
					GoTo IL_41B
				End If
				IL_238:
				num2 = 28
				Dim adoxbuilder As ADOXBuilder = Nothing
				IL_23E:
				num2 = 29
				Dim name As String = ""
				IL_248:
				num2 = 30
				If Not Me.O.0o_0_..DataTable.frd_IsInnerTable Then
					GoTo IL_27E
				End If
				IL_25D:
				num2 = 31
				adoxbuilder = New ADOXBuilder()
				IL_267:
				num2 = 32
				name = Me.O.0o_0_..DataTable.Name
				GoTo IL_2FB
				IL_27E:
				num2 = 34
				Dim enumerator As Dictionary(Of String, OleDbConnection).KeyCollection.Enumerator = O_O0OO.O._o_.().Keys.GetEnumerator()
				While enumerator.MoveNext()
					Dim text As String = enumerator.Current
					IL_29D:
					num2 = 35
					If O_O0OO.O._o_.()(text) Is Me.O.0o_0_..DataTable.frd_Connection Then
						IL_2BE:
						num2 = 36
						adoxbuilder = New ADOXBuilder(text)
						IL_2CA:
						num2 = 37
						name = Me.O.0o_0_..DataTable.o._OOO0oOo0__.
					End If
					IL_2DF:
					num2 = 38
				End While
				IL_2EB:
				num2 = 39
				CType(enumerator, IDisposable).Dispose()
				IL_2FB:
				num2 = 40
				If adoxbuilder Is Nothing Then
					GoTo IL_41B
				End If
				IL_305:
				num2 = 42
				Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()).Rows.Find(New Object() { Me.O.0o_0_..DataTable.Name, Me.O.0o_0_..Name })
				IL_34F:
				num2 = 43
				If dataRow2 Is Nothing Then
					GoTo IL_37D
				End If
				IL_356:
				num2 = 44
				dataRow2.Delete()
				IL_360:
				num2 = 45
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.o0o.o.()), True)
				IL_37D:
				num2 = 46
				adoxbuilder.Open()
				IL_387:
				num2 = 47
				adoxbuilder.get_Tables(name).AddColumn(Me.O.0o_0_..Name, Oo00.oO.OO.(Me.O.0o_0_..BaseColumn.DataType, Me.O.0o_0_.), Me.O.0o_0_..MaxLength)
				IL_3C9:
				num2 = 48
				adoxbuilder.Close()
				IL_3D3:
				num2 = 49
				MyBase.Close()
				IL_3DC:
				num2 = 50
				MessageBox.Show("[" + Me.O.0o_0_..Name + "]已经成功转为数据列，需要重新打开项目才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_407:
				num2 = 51
				Project.Open(OO_00oOO.ProjectFile, New String(-1) {})
				IL_41B:
				GoTo IL_53D
				IL_420:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_4FE:
				GoTo IL_532
				IL_500:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_510:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_500
			End Try
			IL_532:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_53D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06001C13 RID: 7187 RVA: 0x000B1870 File Offset: 0x000AFA70
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04000BE8 RID: 3048
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04000BE9 RID: 3049
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04000BEA RID: 3050
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000BEB RID: 3051
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As RadioButton

		' Token: 0x04000BEC RID: 3052
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000BED RID: 3053
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04000BEE RID: 3054
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000BEF RID: 3055
		Friend <<EMPTY_NAME>> As Boolean

		' Token: 0x04000BF0 RID: 3056
		Friend <<EMPTY_NAME>> As DataCol
	End Class
End Namespace
