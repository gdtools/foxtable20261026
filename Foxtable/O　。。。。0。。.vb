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
	' Token: 0x02000385 RID: 901
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3002\u3002\u3002\u30020\u3002\u3002
		Inherits Form

		' Token: 0x060039E4 RID: 14820 RVA: 0x00190AB9 File Offset: 0x0018ECB9
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.o.0_OoooOo0O. IsNot Nothing Then
				Me.o.0_OoooOo0O..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x060039E5 RID: 14821 RVA: 0x00190AD8 File Offset: 0x0018ECD8
		<DebuggerStepThrough()>
		Private Overloads Sub <<EMPTY_NAME>>()
			Me.o.0_OoooOo0O.(New ListBox())
			Me.o.0_OoooOo0O.(New C1Button())
			Me.o_Oo0.0o.(New C1Button())
			MyBase.SuspendLayout()
			Me.o0.Oo__0Ooo0__.().FormattingEnabled = True
			Me.o0.Oo__0Ooo0__.().ItemHeight = 12
			Me.o0.Oo__0Ooo0__.().Location = New Point(12, 15)
			Me.o0.Oo__0Ooo0__.().Name = "lstTables"
			Me.o0.Oo__0Ooo0__.().Size = New Size(227, 256)
			Me.o0.Oo__0Ooo0__.().TabIndex = 0
			Me.OooO.0O_O000.().DialogResult = DialogResult.OK
			Me.OooO.0O_O000.().Location = New Point(249, 15)
			Me.OooO.0O_O000.().Name = "Button1"
			Me.OooO.0O_O000.().Size = New Size(75, 23)
			Me.OooO.0O_O000.().TabIndex = 1
			Me.OooO.0O_O000.().Text = "确定"
			Me.OooO.0O_O000.().UseVisualStyleBackColor = True
			Me.o0.Oo__0Ooo0__.().DialogResult = DialogResult.Cancel
			Me.o0.Oo__0Ooo0__.().Location = New Point(249, 44)
			Me.o0.Oo__0Ooo0__.().Name = "Button2"
			Me.o0.Oo__0Ooo0__.().Size = New Size(75, 23)
			Me.o0.Oo__0Ooo0__.().TabIndex = 2
			Me.o0.Oo__0Ooo0__.().Text = "取消"
			Me.o0.Oo__0Ooo0__.().UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(334, 283)
			MyBase.Controls.Add(Me.o0.Oo__0Ooo0__.())
			MyBase.Controls.Add(Me.OooO.0O_O000.())
			MyBase.Controls.Add(Me.o0.Oo__0Ooo0__.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o....."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "选择表"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x060039E6 RID: 14822 RVA: 0x00190CF8 File Offset: 0x0018EEF8
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As ListBox
			Return Me.o.0_OoooOo0O.
		End Function

		' Token: 0x060039E7 RID: 14823 RVA: 0x00190D00 File Offset: 0x0018EF00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ListBox)
			Me.o.0_OoooOo0O. = A_0
		End Sub

		' Token: 0x060039E8 RID: 14824 RVA: 0x00190D09 File Offset: 0x0018EF09
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o.0_OoooOo0O.
		End Function

		' Token: 0x060039E9 RID: 14825 RVA: 0x00190D11 File Offset: 0x0018EF11
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o.0_OoooOo0O. = A_0
		End Sub

		' Token: 0x060039EA RID: 14826 RVA: 0x00190D1A File Offset: 0x0018EF1A
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_Oo0.0o.
		End Function

		' Token: 0x060039EB RID: 14827 RVA: 0x00190D22 File Offset: 0x0018EF22
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.o_Oo0.0o. = A_0
		End Sub

		' Token: 0x060039EC RID: 14828 RVA: 0x00190D2C File Offset: 0x0018EF2C
		Public Sub New(A_0 As DataTable, A_1 As C1FlexGrid)
			AddHandler MyBase.FormClosed, AddressOf Me.o0.Oo__0Ooo0__.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj3 As Object
			Try
				IL_18:
				Dim num As Integer = 1
				Me.o0.Oo__0Ooo0__.()
				IL_20:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_37:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_3E:
				num = 4
				If A_0 IsNot Nothing Then
					GoTo IL_A5
				End If
				IL_43:
				num = 5
				Dim enumerator As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataTable As DataTable = CType(obj, DataTable)
					IL_64:
					num = 6
					Me.o0.Oo__0Ooo0__.().Items.Add(dataTable.TableName)
					IL_7E:
					num = 7
				End While
				IL_88:
				num = 8
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_18A
				End If
				GoTo IL_18A
				IL_A5:
				num = 10
				Dim enumerator2 As IEnumerator = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator()
				While enumerator2.MoveNext()
					Dim obj2 As Object = enumerator2.Current
					Dim dataRelation As DataRelation = CType(obj2, DataRelation)
					IL_CC:
					num = 11
					If dataRelation.ChildTable Is A_0 Then
						IL_DC:
						num = 12
						Dim num3 As Integer = A_1.Rows.Fixed
						Do
							IL_EC:
							num = 14
							If A_1.Rows(num3).IsNode Then
								IL_103:
								num = 15
								If Operators.CompareString(Conversions.ToString(A_1(num3, 0)), dataRelation.ParentTable.TableName, True) = 0 Then
									GoTo IL_163
								End If
							End If
							IL_128:
							num = 17
							num3 += 1
							IL_131:
							num = 18
						Loop While num3 < A_1.Rows.Count
						IL_143:
						num = 19
						Me.o0.Oo__0Ooo0__.().Items.Add(dataRelation.ParentTable.TableName)
					End If
					IL_163:
					num = 20
				End While
				IL_172:
				num = 21
				If TypeOf enumerator2 Is IDisposable Then
					TryCast(enumerator2, IDisposable).Dispose()
				End If
				IL_18A:
				num = 22
				If Me.o0.Oo__0Ooo0__.().Items.Count <= 0 Then
					GoTo IL_1AF
				End If
				IL_1A0:
				num = 23
				Me.o0.Oo__0Ooo0__.().SelectedIndex = 0
				IL_1AF:
				GoTo IL_261
				IL_1B4:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_222:
				GoTo IL_256
				IL_224:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_234:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_224
			End Try
			IL_256:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_261:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060039ED RID: 14829 RVA: 0x00190FC0 File Offset: 0x0018F1C0
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x040017F7 RID: 6135
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x040017F8 RID: 6136
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ListBox

		' Token: 0x040017F9 RID: 6137
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x040017FA RID: 6138
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button
	End Class
End Namespace
