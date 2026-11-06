Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports ADODB
Imports ADOX
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000387 RID: 903
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002
		Inherits Form

		' Token: 0x06003A13 RID: 14867 RVA: 0x00192424 File Offset: 0x00190624
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.oOOOO.O. IsNot Nothing Then
					Me.oOOOO.O..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x06003A14 RID: 14868 RVA: 0x00192464 File Offset: 0x00190664
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.o0_oO0o.o0O_.(New Label())
			Me.ooO000OOO.oo0o.(New TextBox())
			Me.ooO000OOO.oo0o.(New CheckedListBox())
			Me.O_o._o0_Oo_.(New C1Button())
			Me.ooO000OOO.oo0o.(New Label())
			Me.oO.0OO_oo_O_.(New C1Button())
			Me.Oo0.O__.(New C1Button())
			MyBase.SuspendLayout()
			Me.oO.0OO_oo_O_.().AutoSize = True
			Me.oO.0OO_oo_O_.().Location = New Point(14, 15)
			Me.oO.0OO_oo_O_.().Name = "Label1"
			Me.oO.0OO_oo_O_.().Size = New Size(47, 12)
			Me.oO.0OO_oo_O_.().TabIndex = 0
			Me.oO.0OO_oo_O_.().Text = "输出到:"
			Me.oO.0OO_oo_O_.().Location = New Point(14, 35)
			Me.oO.0OO_oo_O_.().Name = "TextBox1"
			Me.oO.0OO_oo_O_.().[ReadOnly] = True
			Me.oO.0OO_oo_O_.().Size = New Size(270, 21)
			Me.oO.0OO_oo_O_.().TabIndex = 1
			Me.oO.0OO_oo_O_.().FormattingEnabled = True
			Me.oO.0OO_oo_O_.().Location = New Point(14, 84)
			Me.oO.0OO_oo_O_.().Name = "CheckedListBox1"
			Me.oO.0OO_oo_O_.().Size = New Size(302, 180)
			Me.oO.0OO_oo_O_.().TabIndex = 2
			Me.O_o._o0_Oo_.().Location = New Point(284, 35)
			Me.O_o._o0_Oo_.().Name = "Button1"
			Me.O_o._o0_Oo_.().Size = New Size(32, 21)
			Me.O_o._o0_Oo_.().TabIndex = 3
			Me.O_o._o0_Oo_.().Text = "..."
			Me.O_o._o0_Oo_.().UseVisualStyleBackColor = True
			Me.Oo0.O__.().AutoSize = True
			Me.Oo0.O__.().Location = New Point(14, 64)
			Me.Oo0.O__.().Name = "Label2"
			Me.Oo0.O__.().Size = New Size(47, 12)
			Me.Oo0.O__.().TabIndex = 4
			Me.Oo0.O__.().Text = "选择表:"
			Me.o_0Oo.0o00_O.().Location = New Point(87, 280)
			Me.o_0Oo.0o00_O.().Name = "btnOK"
			Me.o_0Oo.0o00_O.().Size = New Size(75, 23)
			Me.o_0Oo.0o00_O.().TabIndex = 5
			Me.o_0Oo.0o00_O.().Text = "确定"
			Me.o_0Oo.0o00_O.().UseVisualStyleBackColor = True
			Me.Oo0.O__.().DialogResult = DialogResult.Cancel
			Me.Oo0.O__.().Location = New Point(168, 280)
			Me.Oo0.O__.().Name = "Button3"
			Me.Oo0.O__.().Size = New Size(75, 23)
			Me.Oo0.O__.().TabIndex = 6
			Me.Oo0.O__.().Text = "取消"
			Me.Oo0.O__.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(330, 314)
			MyBase.Controls.Add(Me.Oo0.O__.())
			MyBase.Controls.Add(Me.o_0Oo.0o00_O.())
			MyBase.Controls.Add(Me.Oo0.O__.())
			MyBase.Controls.Add(Me.O_o._o0_Oo_.())
			MyBase.Controls.Add(Me.oO.0OO_oo_O_.())
			MyBase.Controls.Add(Me.oO.0OO_oo_O_.())
			MyBase.Controls.Add(Me.oO.0OO_oo_O_.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "O00.0.0."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "生成Access文件"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003A15 RID: 14869 RVA: 0x0019285A File Offset: 0x00190A5A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.ooO000OOO.oo0o.
		End Function

		' Token: 0x06003A16 RID: 14870 RVA: 0x00192862 File Offset: 0x00190A62
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.ooO000OOO.oo0o. = A_0
		End Sub

		' Token: 0x06003A17 RID: 14871 RVA: 0x0019286B File Offset: 0x00190A6B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As TextBox
			Return Me.oOOOO.O.
		End Function

		' Token: 0x06003A18 RID: 14872 RVA: 0x00192873 File Offset: 0x00190A73
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As TextBox)
			Me.oOOOO.O. = A_0
		End Sub

		' Token: 0x06003A19 RID: 14873 RVA: 0x0019287C File Offset: 0x00190A7C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As CheckedListBox
			Return Me.ooO000OOO.oo0o.
		End Function

		' Token: 0x06003A1A RID: 14874 RVA: 0x00192884 File Offset: 0x00190A84
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As CheckedListBox)
			Me.ooO000OOO.oo0o. = A_0
		End Sub

		' Token: 0x06003A1B RID: 14875 RVA: 0x0019288D File Offset: 0x00190A8D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.ooO000OOO.oo0o.
		End Function

		' Token: 0x06003A1C RID: 14876 RVA: 0x00192898 File Offset: 0x00190A98
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o0000.0__O.
			Dim c1Button As C1Button = Me.ooO000OOO.oo0o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.ooO000OOO.oo0o. = A_0
			c1Button = Me.ooO000OOO.oo0o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003A1D RID: 14877 RVA: 0x001928DB File Offset: 0x00190ADB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.o0_oO0o.o0O_.
		End Function

		' Token: 0x06003A1E RID: 14878 RVA: 0x001928E3 File Offset: 0x00190AE3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.o0_oO0o.o0O_. = A_0
		End Sub

		' Token: 0x06003A1F RID: 14879 RVA: 0x001928EC File Offset: 0x00190AEC
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0_oO0o.o0O_.
		End Function

		' Token: 0x06003A20 RID: 14880 RVA: 0x001928F4 File Offset: 0x00190AF4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o_0Oo.0o00_O.
			Dim c1Button As C1Button = Me.o0_oO0o.o0O_.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0_oO0o.o0O_. = A_0
			c1Button = Me.o0_oO0o.o0O_.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003A21 RID: 14881 RVA: 0x00192937 File Offset: 0x00190B37
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_oo.__O.
		End Function

		' Token: 0x06003A22 RID: 14882 RVA: 0x0019293F File Offset: 0x00190B3F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_oo.__O. = A_0
		End Sub

		' Token: 0x06003A23 RID: 14883 RVA: 0x00192948 File Offset: 0x00190B48
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.O_O_.o__o0.
			AddHandler MyBase.FormClosed, AddressOf Me.o_0Oo.0o00_O.
			Me.oO.0OO_oo_O_.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
		End Sub

		' Token: 0x06003A24 RID: 14884 RVA: 0x0019299C File Offset: 0x00190B9C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			saveFileDialog.OverwritePrompt = False
			saveFileDialog.Filter = "Access文件(*.mdb)|*.mdb"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Me.oO.0OO_oo_O_.().Text = saveFileDialog.FileName
			End If
		End Sub

		' Token: 0x06003A25 RID: 14885 RVA: 0x001929DC File Offset: 0x00190BDC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Try
				For Each dataTable As DataTable In OO_00oOO.DataTables
					If dataTable.frd_IsInnerTable Then
						Me.oO.0OO_oo_O_.().Items.Add(dataTable.Name, True)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataTable)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003A26 RID: 14886 RVA: 0x00192A44 File Offset: 0x00190C44
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.oO.0OO_oo_O_.().Text, "", True) = 0 Then
					GoTo IL_2AA
				End If
				IL_24:
				num2 = 4
				Dim list As List(Of String) = New List(Of String)()
				IL_2C:
				num2 = 5
				Dim num3 As Integer = Me.oO.0OO_oo_O_.().Items.Count - 1
				For i As Integer = 0 To num3
					IL_47:
					num2 = 6
					If Me.oO.0OO_oo_O_.().GetItemChecked(i) Then
						IL_58:
						num2 = 7
						list.Add(Me.oO.0OO_oo_O_.().Items(i).ToString())
					End If
					IL_77:
					num2 = 8
				Next
				IL_85:
				num2 = 9
				OO_00oOO.CompactToAccess(Me.oO.0OO_oo_O_.().Text, "")
				IL_9E:
				num2 = 10
				Dim catalog As Catalog = New CatalogClass()
				IL_A8:
				num2 = 11
				Dim connection As Connection = New ConnectionClass()
				IL_B2:
				num2 = 12
				connection.ConnectionString = Oo00.o_._0OOo.(Me.oO.0OO_oo_O_.().Text)
				IL_CC:
				num2 = 13
				connection.Open("", "", "", -1)
				IL_E6:
				num2 = 14
				catalog.ActiveConnection = connection
				IL_F2:
				num2 = 15
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_10F:
					num2 = 16
					If dataTable.frd_IsInnerTable Then
						IL_11E:
						num2 = 17
						If Not list.Contains(dataTable.Name) Then
							IL_130:
							num2 = 18
							catalog.Tables.Delete(dataTable.Name)
						Else
							IL_14B:
							num2 = 20
							Dim table As Table = catalog.Tables(dataTable.Name)
							IL_163:
							num2 = 21
							table.Indexes.Delete(0)
							IL_178:
							num2 = 22
							table.Columns.Delete("_Identify")
							IL_18C:
							num2 = 23
							Dim column As Column = New ColumnClass()
							IL_196:
							num2 = 24
							column.ParentCatalog = catalog
							IL_1A2:
							num2 = 25
							column.Name = "_Identify"
							IL_1B1:
							num2 = 26
							column.Type = 3
							IL_1BC:
							num2 = 27
							column.Properties("AutoIncrement").Value = True
							IL_1DB:
							num2 = 28
							table.Columns.Append(column, 202, 0)
							IL_1F2:
							num2 = 29
							Dim index As Index = New IndexClass()
							IL_1FC:
							num2 = 30
							index.Name = "PrimaryKey"
							IL_20B:
							num2 = 31
							index.Columns.Append("_Identify", 202, 0)
							IL_225:
							num2 = 32
							index.PrimaryKey = True
							IL_230:
							num2 = 33
							index.Unique = True
							IL_23B:
							num2 = 34
							table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value))
							IL_256:
							table = Nothing
						End If
					End If
					IL_259:
					num2 = 36
				End While
				IL_268:
				num2 = 37
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_276:
				num2 = 38
				connection.Close()
				IL_280:
				num2 = 39
				catalog = Nothing
				IL_286:
				num2 = 40
				OO_00oOO.CompactAccessFile(Me.oO.0OO_oo_O_.().Text, "", False)
				IL_2A0:
				num2 = 41
				MyBase.DialogResult = DialogResult.OK
				IL_2AA:
				GoTo IL_3A4
				IL_2AF:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_365:
				GoTo IL_399
				IL_367:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_377:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_367
			End Try
			IL_399:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3A4:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003A27 RID: 14887 RVA: 0x00192E1C File Offset: 0x0019101C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001805 RID: 6149
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001806 RID: 6150
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001807 RID: 6151
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As TextBox

		' Token: 0x04001808 RID: 6152
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As CheckedListBox

		' Token: 0x04001809 RID: 6153
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400180A RID: 6154
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400180B RID: 6155
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400180C RID: 6156
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
