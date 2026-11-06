Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000375 RID: 885
	<DesignerGenerated()>
	Friend Partial Class O\u3000\u3000
		Inherits Form

		' Token: 0x06003815 RID: 14357 RVA: 0x0017EEE6 File Offset: 0x0017D0E6
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.OO0oo0.O_OoOo_. IsNot Nothing Then
				Me.OO0oo0.O_OoOo_..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003816 RID: 14358 RVA: 0x0017EF08 File Offset: 0x0017D108
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.O00_000OO.oo_o.(New Label())
			Me.ooOo0_o0._O.(New Label())
			Me.O00_000OO.oo_o.(New C1ComboBox())
			Me.ooOo0_o0._O.(New C1ComboBox())
			Me.ooOo0_o0._O.(New C1FlexGrid())
			Me.ooOo0_o0._O.(New C1CheckBox())
			Me.oo_Oo.0.(New C1Button())
			Me.ooOo0_o0._O.(New C1Button())
			Me.oo_Oo.0.(New C1CheckBox())
			Me.o0._o.(New Label())
			Me.oo_Oo.0.(New C1ComboBox())
			Me.o.0O_0.().BeginInit()
			Me.o_OO_._.().BeginInit()
			Me.o.0O_0.().BeginInit()
			Me.o.0O_0.().BeginInit()
			Me.ooOOo._.().BeginInit()
			Me.O0.OOo.().BeginInit()
			Me.O0.OOo.().BeginInit()
			Me.Oo_O_.O_.().BeginInit()
			MyBase.SuspendLayout()
			Me.o.0O_0.().AutoSize = True
			Me.o.0O_0.().Location = New Point(10, 13)
			Me.o.0O_0.().Name = "Label1"
			Me.o.0O_0.().Size = New Size(77, 12)
			Me.o.0O_0.().TabIndex = 0
			Me.o.0O_0.().Text = "父表/关联列:"
			Me.o_OO_._.().AutoSize = True
			Me.o_OO_._.().Location = New Point(273, 13)
			Me.o_OO_._.().Name = "Label2"
			Me.o_OO_._.().Size = New Size(77, 12)
			Me.o_OO_._.().TabIndex = 1
			Me.o_OO_._.().Tag = "子表"
			Me.o_OO_._.().Text = "子表/关联列:"
			Me.o.0O_0.().AllowSpinLoop = False
			Me.o.0O_0.().Cursor = Cursors.Arrow
			Me.o.0O_0.().DropDownStyle = 1
			Me.o.0O_0.().GapHeight = 0
			Me.o.0O_0.().ImagePadding = New Padding(0)
			Me.o.0O_0.().ItemsDisplayMember = ""
			Me.o.0O_0.().ItemsValueMember = ""
			Me.o.0O_0.().Location = New Point(12, 28)
			Me.o.0O_0.().Name = "cmbParentTable"
			Me.o.0O_0.().Size = New Size(263, 19)
			Me.o.0O_0.().TabIndex = 0
			Me.o.0O_0.().Tag = Nothing
			Me.o_OO_._.().AllowSpinLoop = False
			Me.o_OO_._.().Cursor = Cursors.Arrow
			Me.o_OO_._.().DropDownStyle = 1
			Me.o_OO_._.().GapHeight = 0
			Me.o_OO_._.().ImagePadding = New Padding(0)
			Me.o_OO_._.().ItemsDisplayMember = ""
			Me.o_OO_._.().ItemsValueMember = ""
			Me.o_OO_._.().Location = New Point(275, 28)
			Me.o_OO_._.().Name = "cmbChildTable"
			Me.o_OO_._.().Size = New Size(263, 19)
			Me.o_OO_._.().TabIndex = 1
			Me.o_OO_._.().Tag = Nothing
			Me.o.0O_0.().AutoClipboard = True
			Me.o.0O_0.().BorderStyle = 3
			Me.o.0O_0.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}" & vbTab
			Me.o.0O_0.().ExtendLastCol = True
			Me.o.0O_0.().HighLight = 2
			Me.o.0O_0.().Location = New Point(12, 55)
			Me.o.0O_0.().Name = "grdCols"
			Me.o.0O_0.().Rows.Count = 7
			Me.o.0O_0.().Rows.DefaultSize = 21
			Me.o.0O_0.().Rows.Fixed = 0
			Me.o.0O_0.().Size = New Size(526, 153)
			Me.o.0O_0.().TabIndex = 2
			Me.o.0O_0.().AutoSize = True
			Me.o.0O_0.().BorderStyle = BorderStyle.None
			Me.o.0O_0.().Location = New Point(12, 221)
			Me.o.0O_0.().Name = "CascateUpdate"
			Me.o.0O_0.().Size = New Size(132, 16)
			Me.o.0O_0.().TabIndex = 6
			Me.o.0O_0.().Text = "同步更新关联列内容"
			Me.o.0O_0.().UseVisualStyleBackColor = True
			Me.o.0O_0.().Value = Nothing
			Me.ooOOo._.().Location = New Point(197, 275)
			Me.ooOOo._.().Name = "btnAccept"
			Me.ooOOo._.().Size = New Size(75, 23)
			Me.ooOOo._.().TabIndex = 3
			Me.ooOOo._.().Text = "确定"
			Me.ooOOo._.().UseVisualStyleBackColor = True
			Me.O0.OOo.().DialogResult = DialogResult.Cancel
			Me.O0.OOo.().Location = New Point(278, 275)
			Me.O0.OOo.().Name = "btnCancel"
			Me.O0.OOo.().Size = New Size(75, 23)
			Me.O0.OOo.().TabIndex = 4
			Me.O0.OOo.().Text = "取消"
			Me.O0.OOo.().UseVisualStyleBackColor = True
			Me.O0.OOo.().AutoSize = True
			Me.O0.OOo.().BorderStyle = BorderStyle.None
			Me.O0.OOo.().Location = New Point(12, 243)
			Me.O0.OOo.().Name = "CascateDelete"
			Me.O0.OOo.().Size = New Size(108, 16)
			Me.O0.OOo.().TabIndex = 7
			Me.O0.OOo.().Text = "同步删除关联行"
			Me.O0.OOo.().UseVisualStyleBackColor = True
			Me.O0.OOo.().Value = Nothing
			Me.Oo_O_.O_.().AutoSize = True
			Me.Oo_O_.O_.().Location = New Point(340, 223)
			Me.Oo_O_.O_.().Name = "Label3"
			Me.Oo_O_.O_.().Size = New Size(71, 12)
			Me.Oo_O_.O_.().TabIndex = 8
			Me.Oo_O_.O_.().Text = "生成关联表:"
			Me.Oo_O_.O_.().AllowSpinLoop = False
			Me.Oo_O_.O_.().Cursor = Cursors.Arrow
			Me.Oo_O_.O_.().DropDownStyle = 1
			Me.Oo_O_.O_.().GapHeight = 0
			Me.Oo_O_.O_.().ImagePadding = New Padding(0)
			Me.Oo_O_.O_.().Items.Add("单向")
			Me.Oo_O_.O_.().Items.Add("双向")
			Me.Oo_O_.O_.().Items.Add("无")
			Me.Oo_O_.O_.().ItemsDisplayMember = ""
			Me.Oo_O_.O_.().ItemsValueMember = ""
			Me.Oo_O_.O_.().Location = New Point(417, 220)
			Me.Oo_O_.O_.().Name = "cmRelationTable"
			Me.Oo_O_.O_.().Size = New Size(121, 19)
			Me.Oo_O_.O_.().TabIndex = 9
			Me.Oo_O_.O_.().Tag = Nothing
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(550, 307)
			MyBase.Controls.Add(Me.Oo_O_.O_.())
			MyBase.Controls.Add(Me.Oo_O_.O_.())
			MyBase.Controls.Add(Me.O0.OOo.())
			MyBase.Controls.Add(Me.O0.OOo.())
			MyBase.Controls.Add(Me.ooOOo._.())
			MyBase.Controls.Add(Me.o.0O_0.())
			MyBase.Controls.Add(Me.o.0O_0.())
			MyBase.Controls.Add(Me.o_OO_._.())
			MyBase.Controls.Add(Me.o.0O_0.())
			MyBase.Controls.Add(Me.o_OO_._.())
			MyBase.Controls.Add(Me.o.0O_0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "o.o.O0.OO."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			Me.Text = "编辑关联"
			Me.o.0O_0.().EndInit()
			Me.o_OO_._.().EndInit()
			Me.o.0O_0.().EndInit()
			Me.o.0O_0.().EndInit()
			Me.ooOOo._.().EndInit()
			Me.O0.OOo.().EndInit()
			Me.O0.OOo.().EndInit()
			Me.Oo_O_.O_.().EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x06003817 RID: 14359 RVA: 0x0017F7C7 File Offset: 0x0017D9C7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oO0.O_o.
		End Function

		' Token: 0x06003818 RID: 14360 RVA: 0x0017F7CF File Offset: 0x0017D9CF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oO0.O_o. = A_0
		End Sub

		' Token: 0x06003819 RID: 14361 RVA: 0x0017F7D8 File Offset: 0x0017D9D8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O.o0O_O0o0_O.
		End Function

		' Token: 0x0600381A RID: 14362 RVA: 0x0017F7E0 File Offset: 0x0017D9E0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O.o0O_O0o0_O. = A_0
		End Sub

		' Token: 0x0600381B RID: 14363 RVA: 0x0017F7E9 File Offset: 0x0017D9E9
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.oO0.O_o.
		End Function

		' Token: 0x0600381C RID: 14364 RVA: 0x0017F7F4 File Offset: 0x0017D9F4
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.OOoOOOOoo0_._0.
			Dim c1ComboBox As C1ComboBox = Me.oO0.O_o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.oO0.O_o. = A_0
			c1ComboBox = Me.oO0.O_o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600381D RID: 14365 RVA: 0x0017F837 File Offset: 0x0017DA37
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o0._o.
		End Function

		' Token: 0x0600381E RID: 14366 RVA: 0x0017F840 File Offset: 0x0017DA40
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Dim eventHandler As EventHandler = AddressOf Me.o__Oo0o.0O_oO_.
			Dim c1ComboBox As C1ComboBox = Me.o0._o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged -= eventHandler
			End If
			Me.o0._o. = A_0
			c1ComboBox = Me.o0._o.
			If c1ComboBox IsNot Nothing Then
				c1ComboBox.SelectedIndexChanged += eventHandler
			End If
		End Sub

		' Token: 0x0600381F RID: 14367 RVA: 0x0017F883 File Offset: 0x0017DA83
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.oO0.O_o.
		End Function

		' Token: 0x06003820 RID: 14368 RVA: 0x0017F88B File Offset: 0x0017DA8B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Me.oO0.O_o. = A_0
		End Sub

		' Token: 0x06003821 RID: 14369 RVA: 0x0017F894 File Offset: 0x0017DA94
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.oO0.O_o.
		End Function

		' Token: 0x06003822 RID: 14370 RVA: 0x0017F89C File Offset: 0x0017DA9C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.oO0.O_o. = A_0
		End Sub

		' Token: 0x06003823 RID: 14371 RVA: 0x0017F8A5 File Offset: 0x0017DAA5
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.oO0.O_o.
		End Function

		' Token: 0x06003824 RID: 14372 RVA: 0x0017F8B0 File Offset: 0x0017DAB0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.OOo.
			Dim c1Button As C1Button = Me.oO0.O_o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.oO0.O_o. = A_0
			c1Button = Me.oO0.O_o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003825 RID: 14373 RVA: 0x0017F8F3 File Offset: 0x0017DAF3
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o0._o.
		End Function

		' Token: 0x06003826 RID: 14374 RVA: 0x0017F8FC File Offset: 0x0017DAFC
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.ooOOo._.
			Dim c1Button As C1Button = Me.o0._o.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o0._o. = A_0
			c1Button = Me.o0._o.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x06003827 RID: 14375 RVA: 0x0017F93F File Offset: 0x0017DB3F
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o0._o.
		End Function

		' Token: 0x06003828 RID: 14376 RVA: 0x0017F947 File Offset: 0x0017DB47
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o0._o. = A_0
		End Sub

		' Token: 0x06003829 RID: 14377 RVA: 0x0017F950 File Offset: 0x0017DB50
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.oo0.oO_OOoo.
		End Function

		' Token: 0x0600382A RID: 14378 RVA: 0x0017F958 File Offset: 0x0017DB58
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.oo0.oO_OOoo. = A_0
		End Sub

		' Token: 0x0600382B RID: 14379 RVA: 0x0017F961 File Offset: 0x0017DB61
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1ComboBox
			Return Me.o_oOo._o_00.
		End Function

		' Token: 0x0600382C RID: 14380 RVA: 0x0017F969 File Offset: 0x0017DB69
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1ComboBox)
			Me.o_oOo._o_00. = A_0
		End Sub

		' Token: 0x0600382D RID: 14381 RVA: 0x0017F974 File Offset: 0x0017DB74
		Public Sub New(A_0 As DataRow)
			AddHandler MyBase.Load, AddressOf Me.OOOo_._oO_0.
			AddHandler MyBase.FormClosed, AddressOf Me.ooOOo._.
			Me.o.0O_0.()
			Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
			Me.OO0oo0.O_OoOo_. = A_0
			If A_0.RowState <> DataRowState.Detached Then
				Me.Text = Me.Text + " - " + Conversions.ToString(A_0("Name"))
				Return
			End If
			Me.Text += " - 新建"
		End Sub

		' Token: 0x0600382E RID: 14382 RVA: 0x0017FA14 File Offset: 0x0017DC14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
				While enumerator.MoveNext()
					Dim dataTable As DataTable = enumerator.Current
					IL_1E:
					num2 = 3
					If Not dataTable.frd_IsTemporary Then
						IL_29:
						num2 = 4
						Me.o.0O_0.().Items.Add(dataTable.Name)
						IL_43:
						num2 = 5
						Me.o_OO_._.().Items.Add(dataTable.Name)
					End If
					IL_5D:
					num2 = 6
				End While
				IL_67:
				num2 = 7
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_72:
				num2 = 8
				If Me.OO0oo0.O_OoOo_..IsNull("ParentTable") Then
					GoTo IL_A9
				End If
				IL_86:
				num2 = 9
				Me.o.0O_0.().SelectedItem = Conversions.ToString(Me.OO0oo0.O_OoOo_.("ParentTable"))
				IL_A9:
				num2 = 10
				If Me.OO0oo0.O_OoOo_..IsNull("ChildTable") Then
					GoTo IL_E1
				End If
				IL_BE:
				num2 = 11
				Me.o_OO_._.().SelectedItem = Conversions.ToString(Me.OO0oo0.O_OoOo_.("ChildTable"))
				IL_E1:
				num2 = 12
				If Me.OO0oo0.O_OoOo_..IsNull("ParentCols") Then
					GoTo IL_196
				End If
				IL_F9:
				num2 = 13
				Dim array As String() = Conversions.ToString(Me.OO0oo0.O_OoOo_.("ParentCols")).Split(vbTab.ToCharArray())
				IL_122:
				num2 = 14
				Dim array2 As String() = Conversions.ToString(Me.OO0oo0.O_OoOo_.("ChildCols")).Split(vbTab.ToCharArray())
				IL_14B:
				num2 = 15
				Dim num3 As Integer = array.Length - 1
				For i As Integer = 0 To num3
					IL_15B:
					num2 = 16
					Me.o.0O_0.()(i, 0) = array(i)
					IL_171:
					num2 = 17
					Me.o.0O_0.()(i, 1) = array2(i)
					IL_187:
					num2 = 18
				Next
				IL_196:
				num2 = 19
				If Me.OO0oo0.O_OoOo_..IsNull("Property") Then
					GoTo IL_223
				End If
				IL_1AB:
				num2 = 20
				Dim fxDataRelationProperty As fxDataRelationProperty = New fxDataRelationProperty()
				IL_1B5:
				num2 = 21
				o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, Conversions.ToString(Me.OO0oo0.O_OoOo_.("Property")), vbVerticalTab)
				IL_1D6:
				num2 = 22
				If Not fxDataRelationProperty.CascadeUpdate Then
					GoTo IL_1F1
				End If
				IL_1E2:
				num2 = 23
				Me.o.0O_0.().Checked = True
				IL_1F1:
				num2 = 24
				If Not fxDataRelationProperty.CascadeDelete Then
					GoTo IL_20C
				End If
				IL_1FD:
				num2 = 25
				Me.O0.OOo.().Checked = True
				IL_20C:
				num2 = 26
				Me.Oo_O_.O_.().SelectedIndex = fxDataRelationProperty.RelationTable
				GoTo IL_232
				IL_223:
				num2 = 28
				Me.Oo_O_.O_.().SelectedIndex = 0
				IL_232:
				GoTo IL_2F8
				IL_237:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_2B9:
				GoTo IL_2ED
				IL_2BB:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_2CB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2BB
			End Try
			IL_2ED:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2F8:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600382F RID: 14383 RVA: 0x0017FD40 File Offset: 0x0017DF40
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o.0O_0.().SelectedItem IsNot Nothing Then
				Dim a_ As String = Conversions.ToString(Me.o.0O_0.().SelectedItem)
				Me.o.0O_0.().Cols(0).ComboList = Me.o.0O_0.(OO_00oOO.DataTables(a_))
				If OO_00oOO.DataTables(a_).BaseTable.PrimaryKey.Length > 0 AndAlso Operators.CompareString(OO_00oOO.DataTables(a_).BaseTable.PrimaryKey(0).ColumnName, "_Identify", True) = 0 Then
					Me.o.0O_0.().Cols(0).ComboList = Me.o.0O_0.(OO_00oOO.DataTables(a_)) + "|_Identify"
				Else
					Me.o.0O_0.().Cols(0).ComboList = Me.o.0O_0.(OO_00oOO.DataTables(a_))
				End If
				Dim num As Integer = Me.o.0O_0.().Rows.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(i, 0)), "", True) > 0 AndAlso Not OO_00oOO.DataTables(Conversions.ToString(Me.o.0O_0.().SelectedItem)).DataCols.Contains(Conversions.ToString(Me.o.0O_0.()(i, 0))) Then
						Me.o.0O_0.()(i, 0) = ""
					End If
				Next
			End If
		End Sub

		' Token: 0x06003830 RID: 14384 RVA: 0x0017FEBC File Offset: 0x0017E0BC
		Private Function <<EMPTY_NAME>>(A_0 As DataTable) As String
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Try
				For Each dataCol As DataCol In A_0.DataCols
					If Not dataCol.IsTemporary Then
						If stringBuilder.Length > 0 Then
							stringBuilder.Append("|")
						End If
						stringBuilder.Append(dataCol.Name)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator(Of DataCol)
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
			End Try
			Return stringBuilder.ToString()
		End Function

		' Token: 0x06003831 RID: 14385 RVA: 0x0017FF38 File Offset: 0x0017E138
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o_OO_._.().SelectedItem IsNot Nothing Then
				Me.o.0O_0.().Cols(1).ComboList = Me.o.0O_0.(OO_00oOO.DataTables(Conversions.ToString(Me.o_OO_._.().SelectedItem)))
				Dim num As Integer = Me.o.0O_0.().Rows.Count - 1
				For i As Integer = 0 To num
					If Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(i, 1)), "", True) > 0 AndAlso Not OO_00oOO.DataTables(Conversions.ToString(Me.o_OO_._.().SelectedItem)).DataCols.Contains(Conversions.ToString(Me.o.0O_0.()(i, 1))) Then
						Me.o.0O_0.()(i, 1) = ""
					End If
				Next
			End If
		End Sub

		' Token: 0x06003832 RID: 14386 RVA: 0x00180014 File Offset: 0x0017E214
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not(Me.o.0O_0.().SelectedItem Is Nothing Or Me.o_OO_._.().SelectedItem Is Nothing) Then
					GoTo IL_42
				End If
				IL_28:
				num2 = 3
				MessageBox.Show("没有选择关联表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_56C
				IL_42:
				num2 = 5
				Dim dataTable As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(Conversions.ToString(Me.o.0O_0.().SelectedItem))
				IL_65:
				num2 = 6
				Dim dataTable2 As DataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables(Conversions.ToString(Me.o_OO_._.().SelectedItem))
				IL_88:
				num2 = 7
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_91:
				num2 = 8
				Dim stringBuilder2 As StringBuilder = New StringBuilder()
				IL_9A:
				num2 = 9
				Dim fxDataRelationProperty As fxDataRelationProperty = New fxDataRelationProperty()
				IL_A4:
				num2 = 10
				If Not Oo00.O____0O._0.(dataTable.TableName, dataTable2.TableName, Me.OO0oo0.O_OoOo_.) Then
					GoTo IL_DD
				End If
				IL_C2:
				num2 = 11
				MessageBox.Show("指定的表之间已经存在关联，必须先删除之，才能重新定义关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_56C
				IL_DD:
				num2 = 13
				If Not Me.o.0O_0.().Checked Then
					GoTo IL_F8
				End If
				IL_ED:
				num2 = 14
				fxDataRelationProperty.CascadeUpdate = True
				IL_F8:
				num2 = 15
				If Not Me.O0.OOo.().Checked Then
					GoTo IL_113
				End If
				IL_108:
				num2 = 16
				fxDataRelationProperty.CascadeDelete = True
				IL_113:
				num2 = 17
				Select Case Me.Oo_O_.O_.().SelectedIndex
					Case 0
						IL_138:
						num2 = 19
						fxDataRelationProperty.RelationTable = 0
					Case 1
						IL_145:
						num2 = 21
						fxDataRelationProperty.RelationTable = 1
					Case 2
						IL_152:
						num2 = 23
						fxDataRelationProperty.RelationTable = 2
				End Select
				IL_15D:
				num2 = 25
				Dim num3 As Integer = Me.o.0O_0.().Rows.Count - 1
				Dim num4 As Integer
				For i As Integer = 0 To num3
					IL_179:
					num2 = 26
					If Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(i, 0)), "", True) > 0 OrElse Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(i, 1)), "", True) > 0 Then
						IL_1BE:
						num2 = 27
						num4 = i
					End If
					IL_1C4:
					num2 = 28
				Next
				IL_1D3:
				num2 = 29
				Dim num5 As Integer = num4
				For j As Integer = 0 To num5
					IL_1DE:
					num2 = 30
					If Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(j, 0)), "", True) = 0 OrElse Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(j, 1)), "", True) = 0 Then
						IL_221:
						num2 = 31
						MessageBox.Show("第" + Conversions.ToString(j) + "行没有选择关联列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						GoTo IL_56C
					End If
					IL_24D:
					num2 = 33
				Next
				IL_25C:
				num2 = 34
				Dim num6 As Integer = num4
				For k As Integer = 0 To num6
					IL_26A:
					num2 = 35
					If dataTable.Columns(Conversions.ToString(Me.o.0O_0.()(k, 0))).DataType IsNot dataTable2.Columns(Conversions.ToString(Me.o.0O_0.()(k, 1))).DataType Then
						IL_2B7:
						num2 = 36
						MessageBox.Show("第" + Conversions.ToString(k) + "行关联列的类型不匹配！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						GoTo IL_56C
					End If
					IL_2E3:
					num2 = 38
				Next
				IL_2F5:
				num2 = 39
				If dataTable IsNot dataTable2 Then
					GoTo IL_35D
				End If
				IL_2FE:
				num2 = 40
				IL_304:
				num2 = 41
				Dim num7 As Integer = num4
				For l As Integer = 0 To num7
					IL_30F:
					num2 = 42
					If Operators.CompareString(Conversions.ToString(Me.o.0O_0.()(l, 0)), Conversions.ToString(Me.o.0O_0.()(l, 1)), True) <> 0 Then
						IL_340:
						num2 = 43
						Exit For
					End If
					IL_348:
					num2 = 45
				Next
				IL_357:
				num2 = 46
				IL_35D:
				num2 = 47
				If Not Oo00.oO.OO.(dataTable.TableName, dataTable2.TableName) Then
					GoTo IL_390
				End If
				IL_375:
				num2 = 48
				MessageBox.Show("表间关系存在死循环!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				GoTo IL_56C
				IL_390:
				num2 = 50
				If Me.OO0oo0.O_OoOo_..RowState <> DataRowState.Detached Then
					GoTo IL_43C
				End If
				IL_3A4:
				num2 = 51
				Dim o_u3000_u As o\u3000\u3000 = New o\u3000\u3000("新建关联", "请输入关联名称:", "")
				IL_3BD:
				num2 = 52
				o_u3000_u.Oo.__0o_0_Oo.(AddressOf Oo00.O0o._.)
				IL_3D3:
				num2 = 53
				If o_u3000_u.ShowDialog() <> DialogResult.OK Then
					GoTo IL_56C
				End If
				IL_3E3:
				num2 = 54
				If Not Oo00.o0.__oO0_.(o_u3000_u.Value, dataTable, dataTable2) Then
					GoTo IL_56C
				End If
				IL_3FB:
				num2 = 56
				Me.OO0oo0.O_OoOo_.("Name") = o_u3000_u.Value
				IL_415:
				num2 = 57
				O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()).Rows.Add(Me.OO0oo0.O_OoOo_.)
				IL_43C:
				num2 = 60
				Dim num8 As Integer = num4
				For m As Integer = 0 To num8
					IL_447:
					num2 = 61
					If stringBuilder.Length > 0 Then
						IL_454:
						num2 = 62
						stringBuilder.Append(vbTab)
						IL_464:
						num2 = 63
						stringBuilder2.Append(vbTab)
					End If
					IL_474:
					num2 = 64
					stringBuilder.Append(Conversions.ToString(Me.o.0O_0.()(m, 0)))
					IL_492:
					num2 = 65
					stringBuilder2.Append(Conversions.ToString(Me.o.0O_0.()(m, 1)))
					IL_4B0:
					num2 = 66
				Next
				IL_4BF:
				num2 = 67
				Me.OO0oo0.O_OoOo_.("ParentTable") = dataTable.TableName
				IL_4D9:
				num2 = 68
				Me.OO0oo0.O_OoOo_.("ChildTable") = dataTable2.TableName
				IL_4F3:
				num2 = 69
				Me.OO0oo0.O_OoOo_.("ParentCols") = stringBuilder.ToString()
				IL_50D:
				num2 = 70
				Me.OO0oo0.O_OoOo_.("ChildCols") = stringBuilder2.ToString()
				IL_527:
				num2 = 71
				Me.OO0oo0.O_OoOo_.("Property") = o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, False, vbVerticalTab, False)
				IL_545:
				num2 = 72
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.O0.ooO0O.()), True)
				IL_562:
				num2 = 73
				MyBase.DialogResult = DialogResult.OK
				IL_56C:
				GoTo IL_6E6
				IL_571:
				Dim num9 As Integer = num10 + 1
				num10 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9)
				IL_6A7:
				GoTo IL_6DB
				IL_6A9:
				num10 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6B9:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6A9
			End Try
			IL_6DB:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6E6:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003833 RID: 14387 RVA: 0x0018072C File Offset: 0x0017E92C
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO0oo0.O_OoOo_..RowState <> DataRowState.Detached Then
				Me.OO0oo0.O_OoOo_..RejectChanges()
			End If
			MyBase.DialogResult = DialogResult.Cancel
		End Sub

		' Token: 0x06003834 RID: 14388 RVA: 0x0018074E File Offset: 0x0017E94E
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001723 RID: 5923
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001724 RID: 5924
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001725 RID: 5925
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001726 RID: 5926
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001727 RID: 5927
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x04001728 RID: 5928
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001729 RID: 5929
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400172A RID: 5930
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400172B RID: 5931
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400172C RID: 5932
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400172D RID: 5933
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400172E RID: 5934
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1ComboBox

		' Token: 0x0400172F RID: 5935
		Private <<EMPTY_NAME>> As DataRow
	End Class
End Namespace
