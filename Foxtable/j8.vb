Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000355 RID: 853
	<EditorBrowsable(EditorBrowsableState.Never)>
	<DesignerGenerated()>
	Friend Partial Class j8
		Inherits Form

		' Token: 0x0600342D RID: 13357 RVA: 0x001584A8 File Offset: 0x001566A8
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Try
				If A_0 AndAlso Me.OO_OO0O.o. IsNot Nothing Then
					Me.OO_OO0O.o..Dispose()
				End If
			Finally
				MyBase.Dispose(A_0)
			End Try
		End Sub

		' Token: 0x0600342E RID: 13358 RVA: 0x001584E8 File Offset: 0x001566E8
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Me.OO_OO0O.o. = New Container()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(j8))
			Me.O._O_0.(New C1FlexGrid())
			Me.O._O_0.(New ContextMenuStrip(Me.OO_OO0O.o.))
			Me.OOO_O._.(New ToolStripMenuItem())
			Me.O0O0.o0ooO.(New ToolStripMenuItem())
			Me.OOOo_0o.o__.(New ToolStripMenuItem())
			Me.O._o0_.(New ToolStripMenuItem())
			Me.O0o.O0.(New Label())
			Me.O0_0o_0.O_o00O.(New Label())
			Me.OOOo_0o.o__.(New Label())
			Me.O.00o__oo.(New C1TextBox())
			Me.O0_O0.oO00_oo0.(New C1Button())
			Me.O_O00o.o.(New Label())
			Me.Oo.o_0ooOO0_.(New C1TextBox())
			Me.OO_000_.oO.(New Label())
			Me.OOOo_0o.o__.(New C1TextBox())
			Me.o0o_O.O_OOOO.(New C1Button())
			Me.O000.oO.(New C1Button())
			Me.o.O_o__o.(New C1Button())
			Me.O0_.oOo0_.(New C1Button())
			Me.O0_0o_0.O_o00O.(New C1FlexGrid())
			Me.o0O.0o00.(New C1Button())
			Me.OOO_O._.(New C1CheckBox())
			Me.oO00Oo0_.O.(New C1CheckBox())
			Me.O000.oO.(New C1CheckBox())
			Me.O0_.oOo0_.(New C1CheckBox())
			Me.O_OoO0o.O.(New C1CheckBox())
			Me.O._O_0.(New GroupBox())
			Me.O._O_0.(New C1CheckBox())
			Me.o0o_O.O_OOOO.(New C1CheckBox())
			Me.O._o0_.(New Label())
			Me.O._O_0.(New NumericUpDown())
			Me.Oo0o_.oo00O0.().BeginInit()
			Me.O_Oo.OOO00o_O.().SuspendLayout()
			Me.O_0._O0o0.().BeginInit()
			Me.O.O0O0oOOoO0O.().SuspendLayout()
			CType(Me.O_Oo.OOO00o_O.(), ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Oo0o_.oo00O0.().AllowDelete = True
			Me.Oo0o_.oo00O0.().AllowDragging = 0
			Me.Oo0o_.oo00O0.().BorderStyle = 4
			Me.Oo0o_.oo00O0.().ColumnInfo = componentResourceManager.GetString("GroupGrid.ColumnInfo")
			Me.Oo0o_.oo00O0.().ContextMenuStrip = Me.O_Oo.OOO00o_O.()
			Me.Oo0o_.oo00O0.().ExtendLastCol = True
			Me.Oo0o_.oo00O0.().HighLight = 2
			Me.Oo0o_.oo00O0.().Location = New Point(15, 73)
			Me.Oo0o_.oo00O0.().Name = "GroupGrid"
			Me.Oo0o_.oo00O0.().Rows.Count = 1
			Me.Oo0o_.oo00O0.().Rows.DefaultSize = 21
			Me.Oo0o_.oo00O0.().SelectionMode = 3
			Me.Oo0o_.oo00O0.().ShowThemedHeaders = 1
			Me.Oo0o_.oo00O0.().Size = New Size(558, 92)
			Me.Oo0o_.oo00O0.().TabIndex = 2
			Me.O_Oo.OOO00o_O.().Items.AddRange(New ToolStripItem() { Me.OO_oO_0o0.__.(), Me.OooooO_.O0.(), Me.O.00O0oo0o_o_o.(), Me.O.O0O0oOOoO0O.() })
			Me.O_Oo.OOO00o_O.().Name = "ContextMenuStrip1"
			Me.O_Oo.OOO00o_O.().Size = New Size(101, 92)
			Me.OO_oO_0o0.__.().Name = "InsertMenuItem"
			Me.OO_oO_0o0.__.().Size = New Size(100, 22)
			Me.OO_oO_0o0.__.().Text = "插入"
			Me.OooooO_.O0.().Name = "DeleteMenuItem"
			Me.OooooO_.O0.().Size = New Size(100, 22)
			Me.OooooO_.O0.().Text = "删除"
			Me.O.00O0oo0o_o_o.().Name = "MoveUpMenuItem"
			Me.O.00O0oo0o_o_o.().Size = New Size(100, 22)
			Me.O.00O0oo0o_o_o.().Text = "上移"
			Me.O.O0O0oOOoO0O.().Name = "MoveDownMenuItem"
			Me.O.O0O0oOOoO0O.().Size = New Size(100, 22)
			Me.O.O0O0oOOoO0O.().Text = "下移"
			Me.Oo0o_.oo00O0.().AutoSize = True
			Me.Oo0o_.oo00O0.().Location = New Point(15, 53)
			Me.Oo0o_.oo00O0.().Name = "Label1"
			Me.Oo0o_.oo00O0.().Size = New Size(71, 12)
			Me.Oo0o_.oo00O0.().TabIndex = 1
			Me.Oo0o_.oo00O0.().Text = "选择分组列:"
			Me.O0OOO__oO_O.00.().AutoSize = True
			Me.O0OOO__oO_O.00.().Location = New Point(13, 172)
			Me.O0OOO__oO_O.00.().Name = "Label2"
			Me.O0OOO__oO_O.00.().Size = New Size(71, 12)
			Me.O0OOO__oO_O.00.().TabIndex = 3
			Me.O0OOO__oO_O.00.().Text = "选择统计列:"
			Me.OOO0o.O.().AutoSize = True
			Me.OOO0o.O.().Location = New Point(15, 381)
			Me.OOO0o.O.().Name = "Label3"
			Me.OOO0o.O.().Size = New Size(35, 12)
			Me.OOO0o.O.().TabIndex = 4
			Me.OOO0o.O.().Text = "条件:"
			Me.O_0._O0o0.().Location = New Point(15, 401)
			Me.O_0._O0o0.().Name = "txtFilter"
			Me.O_0._O0o0.().Size = New Size(521, 21)
			Me.O_0._O0o0.().TabIndex = 5
			Me.oo.0O.().Location = New Point(537, 400)
			Me.oo.0O.().Name = "btnEditExpression"
			Me.oo.0O.().Size = New Size(36, 23)
			Me.oo.0O.().TabIndex = 6
			Me.oo.0O.().Text = "..."
			Me.oo.0O.().UseVisualStyleBackColor = True
			Me.O.O0O0oOOoO0O.().AutoSize = True
			Me.O.O0O0oOOoO0O.().Location = New Point(15, 18)
			Me.O.O0O0oOOoO0O.().Name = "Label4"
			Me.O.O0O0oOOoO0O.().Size = New Size(35, 12)
			Me.O.O0O0oOOoO0O.().TabIndex = 7
			Me.O.O0O0oOOoO0O.().Text = "表名:"
			Me.o.0O_O0_0OO.().Location = New Point(57, 14)
			Me.o.0O_O0_0OO.().Name = "txtName"
			Me.o.0O_O0_0OO.().Size = New Size(100, 21)
			Me.o.0O_O0_0OO.().TabIndex = 0
			Me.O_oO__Oo_0.00.().AutoSize = True
			Me.O_oO__Oo_0.00.().Location = New Point(186, 18)
			Me.O_oO__Oo_0.00.().Name = "Label5"
			Me.O_oO__Oo_0.00.().Size = New Size(35, 12)
			Me.O_oO__Oo_0.00.().TabIndex = 9
			Me.O_oO__Oo_0.00.().Text = "标题:"
			Me.O.00O0oo0o_o_o.().Location = New Point(227, 14)
			Me.O.00O0oo0o_o_o.().Name = "txtCaption"
			Me.O.00O0oo0o_o_o.().Size = New Size(346, 21)
			Me.O.00O0oo0o_o_o.().TabIndex = 1
			Me.O.O_0o0oo_o0.().Location = New Point(176, 443)
			Me.O.O_0o0oo_o0.().Name = "btnViewCode"
			Me.O.O_0o0oo_o0.().Size = New Size(75, 23)
			Me.O.O_0o0oo_o0.().TabIndex = 7
			Me.O.O_0o0oo_o0.().Text = "查看代码"
			Me.O.O_0o0oo_o0.().UseVisualStyleBackColor = True
			Me.o_o_O.OO_o0o0.().Location = New Point(418, 443)
			Me.o_o_O.OO_o0o0.().Name = "btnOk"
			Me.o_o_O.OO_o0o0.().Size = New Size(75, 23)
			Me.o_o_O.OO_o0o0.().TabIndex = 10
			Me.o_o_O.OO_o0o0.().Text = "确定"
			Me.o_o_O.OO_o0o0.().UseVisualStyleBackColor = True
			Me.O0__.00_oo0O0_.().CausesValidation = False
			Me.O0__.00_oo0O0_.().DialogResult = DialogResult.Cancel
			Me.O0__.00_oo0O0_.().Location = New Point(499, 443)
			Me.O0__.00_oo0O0_.().Name = "btnCancel"
			Me.O0__.00_oo0O0_.().Size = New Size(75, 23)
			Me.O0__.00_oo0O0_.().TabIndex = 11
			Me.O0__.00_oo0O0_.().Text = "取消"
			Me.O0__.00_oo0O0_.().UseVisualStyleBackColor = True
			Me.o.0_O_0O_Oo.().Location = New Point(95, 443)
			Me.o.0_O_0O_Oo.().Name = "btnList"
			Me.o.0_O_0O_Oo.().Size = New Size(75, 23)
			Me.o.0_O_0O_Oo.().TabIndex = 9
			Me.o.0_O_0O_Oo.().Text = "设置管理"
			Me.o.0_O_0O_Oo.().UseVisualStyleBackColor = True
			Me.O_0._O0o0.().AllowDelete = True
			Me.O_0._O0o0.().AllowDragging = 0
			Me.O_0._O0o0.().BorderStyle = 4
			Me.O_0._O0o0.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo")
			Me.O_0._O0o0.().ContextMenuStrip = Me.O_Oo.OOO00o_O.()
			Me.O_0._O0o0.().ExtendLastCol = True
			Me.O_0._O0o0.().HighLight = 2
			Me.O_0._O0o0.().Location = New Point(13, 192)
			Me.O_0._O0o0.().Name = "TotalGrid"
			Me.O_0._O0o0.().Rows.Count = 1
			Me.O_0._O0o0.().Rows.DefaultSize = 21
			Me.O_0._O0o0.().SelectionMode = 3
			Me.O_0._O0o0.().ShowThemedHeaders = 1
			Me.O_0._O0o0.().Size = New Size(558, 92)
			Me.O_0._O0o0.().TabIndex = 3
			Me.OoOo0.oo.().Location = New Point(14, 443)
			Me.OoOo0.oo.().Name = "btnSave"
			Me.OoOo0.oo.().Size = New Size(75, 23)
			Me.OoOo0.oo.().TabIndex = 8
			Me.OoOo0.oo.().Text = "保存设置"
			Me.OoOo0.oo.().UseVisualStyleBackColor = True
			Me.o00_.oo0O_.().AutoSize = True
			Me.o00_.oo0O_.().Location = New Point(220, 47)
			Me.o00_.oo0O_.().Name = "chkVerticalTotal"
			Me.o00_.oo0O_.().Size = New Size(120, 16)
			Me.o00_.oo0O_.().TabIndex = 0
			Me.o00_.oo0O_.().Text = "垂直方向自动汇总"
			Me.o00_.oo0O_.().UseVisualStyleBackColor = True
			Me.Oo__.O0_o0OOoO.().AutoSize = True
			Me.Oo__.O0_o0OOoO.().Location = New Point(15, 47)
			Me.Oo__.O0_o0OOoO.().Name = "chkGroupProportion"
			Me.Oo__.O0_o0OOoO.().Size = New Size(84, 16)
			Me.Oo__.O0_o0OOoO.().TabIndex = 1
			Me.Oo__.O0_o0OOoO.().Text = "生成分占比"
			Me.Oo__.O0_o0OOoO.().UseVisualStyleBackColor = True
			Me.o0o_0o00.0o.().AutoSize = True
			Me.o0o_0o00.0o.().Location = New Point(15, 22)
			Me.o0o_0o00.0o.().Name = "ChkGrandProportion"
			Me.o0o_0o00.0o.().Size = New Size(84, 16)
			Me.o0o_0o00.0o.().TabIndex = 2
			Me.o0o_0o00.0o.().Text = "生成总占比"
			Me.o0o_0o00.0o.().UseVisualStyleBackColor = True
			Me.o_O._.().AutoSize = True
			Me.o_O._.().Location = New Point(125, 22)
			Me.o_O._.().Name = "chkCircleGrowth"
			Me.o_O._.().Size = New Size(72, 16)
			Me.o_O._.().TabIndex = 3
			Me.o_O._.().Text = "生成环比"
			Me.o_O._.().UseVisualStyleBackColor = True
			Me.OooooO_.O0.().AutoSize = True
			Me.OooooO_.O0.().Location = New Point(125, 47)
			Me.OooooO_.O0.().Name = "chkSamePeriodGrowth"
			Me.OooooO_.O0.().Size = New Size(72, 16)
			Me.OooooO_.O0.().TabIndex = 4
			Me.OooooO_.O0.().Text = "生成同比"
			Me.OooooO_.O0.().UseVisualStyleBackColor = True
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.O_Oo.OOO00o_O.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.o._ooO.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.OO_oO_0o0.__.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.O_Oo.OOO00o_O.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.o00_.oo0O_.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.OooooO_.O0.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.Oo__.O0_o0OOoO.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.o_O._.())
			Me.O.O0O0oOOoO0O.().Controls.Add(Me.o0o_0o00.0o.())
			Me.O.O0O0oOOoO0O.().Location = New Point(14, 290)
			Me.O.O0O0oOOoO0O.().Name = "GroupBox1"
			Me.O.O0O0oOOoO0O.().Size = New Size(556, 74)
			Me.O.O0O0oOOoO0O.().TabIndex = 4
			Me.O.O0O0oOOoO0O.().TabStop = False
			Me.O.O0O0oOOoO0O.().Text = "统计选项"
			Me.O_Oo.OOO00o_O.().AutoSize = True
			Me.O_Oo.OOO00o_O.().Location = New Point(220, 22)
			Me.O_Oo.OOO00o_O.().Name = "chkSubtotal"
			Me.O_Oo.OOO00o_O.().Size = New Size(120, 16)
			Me.O_Oo.OOO00o_O.().TabIndex = 8
			Me.O_Oo.OOO00o_O.().Text = "自动生成汇总模式"
			Me.O_Oo.OOO00o_O.().UseVisualStyleBackColor = True
			Me.o._ooO.().AutoSize = True
			Me.o._ooO.().Location = New Point(414, 20)
			Me.o._ooO.().Name = "chkFromServer"
			Me.o._ooO.().Size = New Size(120, 16)
			Me.o._ooO.().TabIndex = 7
			Me.o._ooO.().Text = "直接统计后台数据"
			Me.o._ooO.().UseVisualStyleBackColor = True
			Me.OO_oO_0o0.__.().AutoSize = True
			Me.OO_oO_0o0.__.().Location = New Point(400, 49)
			Me.OO_oO_0o0.__.().Name = "Label6"
			Me.OO_oO_0o0.__.().Size = New Size(59, 12)
			Me.OO_oO_0o0.__.().TabIndex = 6
			Me.OO_oO_0o0.__.().Text = "小数位数:"
			Me.O_Oo.OOO00o_O.().Location = New Point(471, 45)
			Me.O_Oo.OOO00o_O.().Name = "Decimals"
			Me.O_Oo.OOO00o_O.().Size = New Size(63, 21)
			Me.O_Oo.OOO00o_O.().TabIndex = 5
			Dim numericUpDown As NumericUpDown = Me.O_Oo.OOO00o_O.()
			Dim array As Integer() = New Integer(3) {}
			array(0) = 4
			numericUpDown.Value = New Decimal(array)
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(588, 476)
			MyBase.Controls.Add(Me.O.O0O0oOOoO0O.())
			MyBase.Controls.Add(Me.O_0._O0o0.())
			MyBase.Controls.Add(Me.OoOo0.oo.())
			MyBase.Controls.Add(Me.O.00O0oo0o_o_o.())
			MyBase.Controls.Add(Me.O0__.00_oo0O0_.())
			MyBase.Controls.Add(Me.o_o_O.OO_o0o0.())
			MyBase.Controls.Add(Me.O_oO__Oo_0.00.())
			MyBase.Controls.Add(Me.o.0_O_0O_Oo.())
			MyBase.Controls.Add(Me.o.0O_O0_0OO.())
			MyBase.Controls.Add(Me.O.O0O0oOOoO0O.())
			MyBase.Controls.Add(Me.O.O_0o0oo_o0.())
			MyBase.Controls.Add(Me.oo.0O.())
			MyBase.Controls.Add(Me.O_0._O0o0.())
			MyBase.Controls.Add(Me.OOO0o.O.())
			MyBase.Controls.Add(Me.Oo0o_.oo00O0.())
			MyBase.Controls.Add(Me.O0OOO__oO_O.00.())
			MyBase.Controls.Add(Me.Oo0o_.oo00O0.())
			MyBase.FormBorderStyle = FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "ooO.o00."
			MyBase.ShowIcon = False
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "分组统计"
			Me.Oo0o_.oo00O0.().EndInit()
			Me.O_Oo.OOO00o_O.().ResumeLayout(False)
			Me.O_0._O0o0.().EndInit()
			Me.O.O0O0oOOoO0O.().ResumeLayout(False)
			Me.O.O0O0oOOoO0O.().PerformLayout()
			CType(Me.O_Oo.OOO00o_O.(), ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0600342F RID: 13359 RVA: 0x001595AE File Offset: 0x001577AE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo.O_000O.
		End Function

		' Token: 0x06003430 RID: 13360 RVA: 0x001595B8 File Offset: 0x001577B8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.oO_0ooOoo0o.__.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.o.0O_O0_0OO.
			Dim oo.O_000O. As C1FlexGrid = Me.Oo.O_000O.
			If oo.O_000O. IsNot Nothing Then
				oo.O_000O..AfterEdit -= rowColEventHandler
				oo.O_000O..BeforeEdit -= rowColEventHandler2
			End If
			Me.Oo.O_000O. = A_0
			oo.O_000O. = Me.Oo.O_000O.
			If oo.O_000O. IsNot Nothing Then
				oo.O_000O..AfterEdit += rowColEventHandler
				oo.O_000O..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x06003431 RID: 13361 RVA: 0x00159616 File Offset: 0x00157816
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo.O_000O.
		End Function

		' Token: 0x06003432 RID: 13362 RVA: 0x0015961E File Offset: 0x0015781E
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo.O_000O. = A_0
		End Sub

		' Token: 0x06003433 RID: 13363 RVA: 0x00159627 File Offset: 0x00157827
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Oo0_.o.
		End Function

		' Token: 0x06003434 RID: 13364 RVA: 0x0015962F File Offset: 0x0015782F
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Oo0_.o. = A_0
		End Sub

		' Token: 0x06003435 RID: 13365 RVA: 0x00159638 File Offset: 0x00157838
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.OO.0oooO00Oo.
		End Function

		' Token: 0x06003436 RID: 13366 RVA: 0x00159640 File Offset: 0x00157840
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.OO.0oooO00Oo. = A_0
		End Sub

		' Token: 0x06003437 RID: 13367 RVA: 0x00159649 File Offset: 0x00157849
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.OO_OO0O.o.
		End Function

		' Token: 0x06003438 RID: 13368 RVA: 0x00159651 File Offset: 0x00157851
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.OO_OO0O.o. = A_0
		End Sub

		' Token: 0x06003439 RID: 13369 RVA: 0x0015965A File Offset: 0x0015785A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O.00o__oo.
		End Function

		' Token: 0x0600343A RID: 13370 RVA: 0x00159664 File Offset: 0x00157864
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o00_o0o.oOOo.
			Dim o.00o__oo. As C1Button = Me.O.00o__oo.
			If o.00o__oo. IsNot Nothing Then
				RemoveHandler o.00o__oo..Click, value
			End If
			Me.O.00o__oo. = A_0
			o.00o__oo. = Me.O.00o__oo.
			If o.00o__oo. IsNot Nothing Then
				AddHandler o.00o__oo..Click, value
			End If
		End Sub

		' Token: 0x0600343B RID: 13371 RVA: 0x001596A7 File Offset: 0x001578A7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.Ooo0o0o0_o.0.
		End Function

		' Token: 0x0600343C RID: 13372 RVA: 0x001596AF File Offset: 0x001578AF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.Ooo0o0o0_o.0. = A_0
		End Sub

		' Token: 0x0600343D RID: 13373 RVA: 0x001596B8 File Offset: 0x001578B8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.Oo._Oo0_OOO_.
		End Function

		' Token: 0x0600343E RID: 13374 RVA: 0x001596C0 File Offset: 0x001578C0
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Dim value As CancelEventHandler = AddressOf Me.O.00o__oo.
			Dim oo._Oo0_OOO_. As C1TextBox = Me.Oo._Oo0_OOO_.
			If oo._Oo0_OOO_. IsNot Nothing Then
				RemoveHandler oo._Oo0_OOO_..Validating, value
			End If
			Me.Oo._Oo0_OOO_. = A_0
			oo._Oo0_OOO_. = Me.Oo._Oo0_OOO_.
			If oo._Oo0_OOO_. IsNot Nothing Then
				AddHandler oo._Oo0_OOO_..Validating, value
			End If
		End Sub

		' Token: 0x0600343F RID: 13375 RVA: 0x00159703 File Offset: 0x00157903
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O0.o_.
		End Function

		' Token: 0x06003440 RID: 13376 RVA: 0x0015970B File Offset: 0x0015790B
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O0.o_. = A_0
		End Sub

		' Token: 0x06003441 RID: 13377 RVA: 0x00159714 File Offset: 0x00157914
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1TextBox
			Return Me.o_.0__oo_O.
		End Function

		' Token: 0x06003442 RID: 13378 RVA: 0x0015971C File Offset: 0x0015791C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1TextBox)
			Me.o_.0__oo_O. = A_0
		End Sub

		' Token: 0x06003443 RID: 13379 RVA: 0x00159725 File Offset: 0x00157925
		<CompilerGenerated()>
		Friend Overridable Overloads Function <<EMPTY_NAME>>() As C1Button
			Return Me.O._oo.
		End Function

		' Token: 0x06003444 RID: 13380 RVA: 0x00159730 File Offset: 0x00157930
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.o___OoO.o.
			Dim o._oo. As C1Button = Me.O._oo.
			If o._oo. IsNot Nothing Then
				RemoveHandler o._oo..Click, value
			End If
			Me.O._oo. = A_0
			o._oo. = Me.O._oo.
			If o._oo. IsNot Nothing Then
				AddHandler o._oo..Click, value
			End If
		End Sub

		' Token: 0x06003445 RID: 13381 RVA: 0x00159773 File Offset: 0x00157973
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo_O0Oo.o.
		End Function

		' Token: 0x06003446 RID: 13382 RVA: 0x0015977C File Offset: 0x0015797C
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O.o___O00.
			Dim oo_O0Oo.o. As C1Button = Me.Oo_O0Oo.o.
			If oo_O0Oo.o. IsNot Nothing Then
				RemoveHandler oo_O0Oo.o..Click, value
			End If
			Me.Oo_O0Oo.o. = A_0
			oo_O0Oo.o. = Me.Oo_O0Oo.o.
			If oo_O0Oo.o. IsNot Nothing Then
				AddHandler oo_O0Oo.o..Click, value
			End If
		End Sub

		' Token: 0x06003447 RID: 13383 RVA: 0x001597BF File Offset: 0x001579BF
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.O0_._.
		End Function

		' Token: 0x06003448 RID: 13384 RVA: 0x001597C7 File Offset: 0x001579C7
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Me.O0_._. = A_0
		End Sub

		' Token: 0x06003449 RID: 13385 RVA: 0x001597D0 File Offset: 0x001579D0
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.o_O__Oo0._0.
		End Function

		' Token: 0x0600344A RID: 13386 RVA: 0x001597D8 File Offset: 0x001579D8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.oOOOo._O0O.
			Dim c1Button As C1Button = Me.o_O__Oo0._0.
			If c1Button IsNot Nothing Then
				RemoveHandler c1Button.Click, value
			End If
			Me.o_O__Oo0._0. = A_0
			c1Button = Me.o_O__Oo0._0.
			If c1Button IsNot Nothing Then
				AddHandler c1Button.Click, value
			End If
		End Sub

		' Token: 0x0600344B RID: 13387 RVA: 0x0015981B File Offset: 0x00157A1B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1FlexGrid
			Return Me.Oo._Oo0_OOO_.
		End Function

		' Token: 0x0600344C RID: 13388 RVA: 0x00159824 File Offset: 0x00157A24
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1FlexGrid)
			Dim rowColEventHandler As RowColEventHandler = AddressOf Me.Oo.o_0ooOO0_.
			Dim rowColEventHandler2 As RowColEventHandler = AddressOf Me.O.00o__oo.
			Dim oo._Oo0_OOO_. As C1FlexGrid = Me.Oo._Oo0_OOO_.
			If oo._Oo0_OOO_. IsNot Nothing Then
				oo._Oo0_OOO_..AfterEdit -= rowColEventHandler
				oo._Oo0_OOO_..BeforeEdit -= rowColEventHandler2
			End If
			Me.Oo._Oo0_OOO_. = A_0
			oo._Oo0_OOO_. = Me.Oo._Oo0_OOO_.
			If oo._Oo0_OOO_. IsNot Nothing Then
				oo._Oo0_OOO_..AfterEdit += rowColEventHandler
				oo._Oo0_OOO_..BeforeEdit += rowColEventHandler2
			End If
		End Sub

		' Token: 0x0600344D RID: 13389 RVA: 0x00159882 File Offset: 0x00157A82
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ContextMenuStrip
			Return Me.Oooo.Oo_oo0.
		End Function

		' Token: 0x0600344E RID: 13390 RVA: 0x0015988A File Offset: 0x00157A8A
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ContextMenuStrip)
			Me.Oooo.Oo_oo0. = A_0
		End Sub

		' Token: 0x0600344F RID: 13391 RVA: 0x00159894 File Offset: 0x00157A94
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.Oo.O_000O.
		End Function

		' Token: 0x06003450 RID: 13392 RVA: 0x001598A8 File Offset: 0x00157AA8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o0OoO_0O_.Ooo.
				Dim oo.O_000O. As ToolStripMenuItem = Me.Oo.O_000O.
				Dim num As Integer = 2
				While True
					Select Case num
						Case 0
							Return
						Case 1
							GoTo IL_62
						Case 2
							If True Then
							End If
							If oo.O_000O. IsNot Nothing Then
								num = 4
								Continue For
							End If
							GoTo IL_62
						Case 3
							AddHandler oo.O_000O..Click, value
							num = 0
							Continue For
						Case 4
							RemoveHandler oo.O_000O..Click, value
							num = 1
							Continue For
						Case 5
							If oo.O_000O. IsNot Nothing Then
								num = 3
								Continue For
							End If
							Return
					End Select
					Exit For
					IL_62:
					Me.Oo.O_000O. = A_0
					oo.O_000O. = Me.Oo.O_000O.
					num = 5
				End While
			End While
		End Sub

		' Token: 0x06003451 RID: 13393 RVA: 0x00159954 File Offset: 0x00157B54
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.Oo._Oo0_OOO_.
		End Function

		' Token: 0x06003452 RID: 13394 RVA: 0x00159968 File Offset: 0x00157B68
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.O____0.o0_.
				Dim oo._Oo0_OOO_. As ToolStripMenuItem = Me.Oo._Oo0_OOO_.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							AddHandler oo._Oo0_OOO_..Click, value
							num = 3
							Continue For
						Case 1
							RemoveHandler oo._Oo0_OOO_..Click, value
							num = 2
							Continue For
						Case 2
							GoTo IL_62
						Case 3
							Return
						Case 4
							If oo._Oo0_OOO_. IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
						Case 5
							If oo._Oo0_OOO_. IsNot Nothing Then
								If True Then
								End If
								num = 1
								Continue For
							End If
							GoTo IL_62
					End Select
					Exit For
					IL_62:
					Me.Oo._Oo0_OOO_. = A_0
					oo._Oo0_OOO_. = Me.Oo._Oo0_OOO_.
					num = 4
				End While
			End While
		End Sub

		' Token: 0x06003453 RID: 13395 RVA: 0x00159A14 File Offset: 0x00157C14
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.o_.0__oo_O.
		End Function

		' Token: 0x06003454 RID: 13396 RVA: 0x00159A28 File Offset: 0x00157C28
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.o__.ooOOoO00.
				Dim toolStripMenuItem As ToolStripMenuItem = Me.o_.0__oo_O.
				Dim num As Integer = 5
				While True
					Select Case num
						Case 0
							If True Then
							End If
							RemoveHandler toolStripMenuItem.Click, value
							num = 4
							Continue For
						Case 1
							If toolStripMenuItem IsNot Nothing Then
								num = 2
								Continue For
							End If
							Return
						Case 2
							AddHandler toolStripMenuItem.Click, value
							num = 3
							Continue For
						Case 3
							Return
						Case 4
							GoTo IL_5A
						Case 5
							If toolStripMenuItem IsNot Nothing Then
								num = 0
								Continue For
							End If
							GoTo IL_5A
					End Select
					Exit For
					IL_5A:
					Me.o_.0__oo_O. = A_0
					toolStripMenuItem = Me.o_.0__oo_O.
					num = 1
				End While
			End While
		End Sub

		' Token: 0x06003455 RID: 13397 RVA: 0x00159ACE File Offset: 0x00157CCE
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1Button
			Return Me.Oo._Oooo.
		End Function

		' Token: 0x06003456 RID: 13398 RVA: 0x00159AD8 File Offset: 0x00157CD8
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1Button)
			Dim value As EventHandler = AddressOf Me.O0.O__o__00_O.
			Dim oo._Oooo. As C1Button = Me.Oo._Oooo.
			If oo._Oooo. IsNot Nothing Then
				RemoveHandler oo._Oooo..Click, value
			End If
			Me.Oo._Oooo. = A_0
			oo._Oooo. = Me.Oo._Oooo.
			If oo._Oooo. IsNot Nothing Then
				AddHandler oo._Oooo..Click, value
			End If
		End Sub

		' Token: 0x06003457 RID: 13399 RVA: 0x00159B1C File Offset: 0x00157D1C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As ToolStripMenuItem
			Return Me.Ooo0o0o0_o.0.
		End Function

		' Token: 0x06003458 RID: 13400 RVA: 0x00159B30 File Offset: 0x00157D30
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As ToolStripMenuItem)
			While True
				Dim value As EventHandler = AddressOf Me.oO_0ooOoo0o.__.
				Dim ooo0o0o0_o.0. As ToolStripMenuItem = Me.Ooo0o0o0_o.0.
				Dim num As Integer = 1
				While True
					Select Case num
						Case 0
							AddHandler ooo0o0o0_o.0..Click, value
							num = 4
							Continue For
						Case 1
							If ooo0o0o0_o.0. IsNot Nothing Then
								num = 2
								Continue For
							End If
							GoTo IL_5A
						Case 2
							If True Then
							End If
							RemoveHandler ooo0o0o0_o.0..Click, value
							num = 3
							Continue For
						Case 3
							GoTo IL_5A
						Case 4
							Return
						Case 5
							If ooo0o0o0_o.0. IsNot Nothing Then
								num = 0
								Continue For
							End If
							Return
					End Select
					Exit For
					IL_5A:
					Me.Ooo0o0o0_o.0. = A_0
					ooo0o0o0_o.0. = Me.Ooo0o0o0_o.0.
					num = 5
				End While
			End While
		End Sub

		' Token: 0x06003459 RID: 13401 RVA: 0x00159BD6 File Offset: 0x00157DD6
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oooo.Oo_oo0.
		End Function

		' Token: 0x0600345A RID: 13402 RVA: 0x00159BDE File Offset: 0x00157DDE
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Oooo.Oo_oo0. = A_0
		End Sub

		' Token: 0x0600345B RID: 13403 RVA: 0x00159BE7 File Offset: 0x00157DE7
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O._oo.
		End Function

		' Token: 0x0600345C RID: 13404 RVA: 0x00159BEF File Offset: 0x00157DEF
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O._oo. = A_0
		End Sub

		' Token: 0x0600345D RID: 13405 RVA: 0x00159BF8 File Offset: 0x00157DF8
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o.Oo_o_O.
		End Function

		' Token: 0x0600345E RID: 13406 RVA: 0x00159C00 File Offset: 0x00157E00
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o.Oo_o_O. = A_0
		End Sub

		' Token: 0x0600345F RID: 13407 RVA: 0x00159C09 File Offset: 0x00157E09
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.o_oOOo._0oO.
		End Function

		' Token: 0x06003460 RID: 13408 RVA: 0x00159C11 File Offset: 0x00157E11
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.o_oOOo._0oO. = A_0
		End Sub

		' Token: 0x06003461 RID: 13409 RVA: 0x00159C1A File Offset: 0x00157E1A
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.O0oo00_0._.
		End Function

		' Token: 0x06003462 RID: 13410 RVA: 0x00159C22 File Offset: 0x00157E22
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.O0oo00_0._. = A_0
		End Sub

		' Token: 0x06003463 RID: 13411 RVA: 0x00159C2B File Offset: 0x00157E2B
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As GroupBox
			Return Me.Oo.O_000O.
		End Function

		' Token: 0x06003464 RID: 13412 RVA: 0x00159C33 File Offset: 0x00157E33
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As GroupBox)
			Me.Oo.O_000O. = A_0
		End Sub

		' Token: 0x06003465 RID: 13413 RVA: 0x00159C3C File Offset: 0x00157E3C
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As Label
			Return Me.O_o_0._.
		End Function

		' Token: 0x06003466 RID: 13414 RVA: 0x00159C44 File Offset: 0x00157E44
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As Label)
			Me.O_o_0._. = A_0
		End Sub

		' Token: 0x06003467 RID: 13415 RVA: 0x00159C4D File Offset: 0x00157E4D
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As NumericUpDown
			Return Me.Oo.O_000O.
		End Function

		' Token: 0x06003468 RID: 13416 RVA: 0x00159C55 File Offset: 0x00157E55
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As NumericUpDown)
			Me.Oo.O_000O. = A_0
		End Sub

		' Token: 0x06003469 RID: 13417 RVA: 0x00159C5E File Offset: 0x00157E5E
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oo._Oooo.
		End Function

		' Token: 0x0600346A RID: 13418 RVA: 0x00159C68 File Offset: 0x00157E68
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Dim value As EventHandler = AddressOf Me.o0O__o.oO_.
			Dim oo._Oooo. As C1CheckBox = Me.Oo._Oooo.
			If oo._Oooo. IsNot Nothing Then
				RemoveHandler oo._Oooo..CheckedChanged, value
			End If
			Me.Oo._Oooo. = A_0
			oo._Oooo. = Me.Oo._Oooo.
			If oo._Oooo. IsNot Nothing Then
				AddHandler oo._Oooo..CheckedChanged, value
			End If
		End Sub

		' Token: 0x0600346B RID: 13419 RVA: 0x00159CAB File Offset: 0x00157EAB
		<CompilerGenerated()>
		Friend Overridable Function <<EMPTY_NAME>>() As C1CheckBox
			Return Me.Oo.000O000OO.
		End Function

		' Token: 0x0600346C RID: 13420 RVA: 0x00159CB3 File Offset: 0x00157EB3
		<CompilerGenerated()>
		<MethodImpl(MethodImplOptions.Synchronized)>
		Friend Overridable Sub <<EMPTY_NAME>>(A_0 As C1CheckBox)
			Me.Oo.000O000OO. = A_0
		End Sub

		' Token: 0x0600346D RID: 13421 RVA: 0x00159CBC File Offset: 0x00157EBC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Operators.CompareString(Me.Oo0o_.oo00O0.().Cols(A_1.Col).Name, "Name", True) <> 0 Then
					GoTo IL_14B
				End If
				IL_34:
				num2 = 3
				If Me.Oo0o_.oo00O0.().GetData(A_1.Row, "Name") Is Nothing Then
					GoTo IL_1E1
				End If
				IL_51:
				num2 = 5
				Dim text As String = Me.Oo0o_.oo00O0.().GetData(A_1.Row, "Name").ToString()
				IL_6F:
				num2 = 6
				If Operators.CompareString(text, "", True) = 0 Then
					GoTo IL_1E1
				End If
				IL_82:
				num2 = 8
				If Me.OO_OO0O.o..DataTable.DataCols(text).IsDate Then
					GoTo IL_DA
				End If
				IL_A1:
				num2 = 9
				Me.Oo0o_.oo00O0.()(A_1.Row, "DateGroup") = Nothing
				IL_BB:
				num2 = 10
				Me.Oo0o_.oo00O0.()(A_1.Row, "NewName") = Nothing
				GoTo IL_1E1
				IL_DA:
				num2 = 12
				If Me.Oo0o_.oo00O0.()(A_1.Row, "DateGroup") IsNot Nothing Then
					GoTo IL_1E1
				End If
				IL_F8:
				num2 = 13
				Me.Oo0o_.oo00O0.()(A_1.Row, "DateGroup") = 3
				IL_117:
				num2 = 14
				Me.Oo0o_.oo00O0.()(A_1.Row, "NewName") = Me.Oo0o_.oo00O0.().GetDataDisplay(A_1.Row, "DateGroup")
				GoTo IL_1E1
				IL_14B:
				num2 = 16
				If Operators.CompareString(Me.Oo0o_.oo00O0.().Cols(A_1.Col).Name, "DateGroup", True) <> 0 Then
					GoTo IL_1E1
				End If
				IL_176:
				num2 = 17
				If Conversions.ToInteger(Me.Oo0o_.oo00O0.()(A_1.Row, "DateGroup")) <> 0 Then
					GoTo IL_1B2
				End If
				IL_196:
				num2 = 18
				Me.Oo0o_.oo00O0.()(A_1.Row, "NewName") = Nothing
				GoTo IL_1E1
				IL_1B2:
				num2 = 20
				Me.Oo0o_.oo00O0.()(A_1.Row, "NewName") = Me.Oo0o_.oo00O0.().GetDataDisplay(A_1.Row, "DateGroup")
				IL_1E1:
				GoTo IL_287
				IL_1E6:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_248:
				GoTo IL_27C
				IL_24A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_25A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_24A
			End Try
			IL_27C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_287:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600346E RID: 13422 RVA: 0x00159F74 File Offset: 0x00158174
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso Operators.CompareString(Me.Oo0o_.oo00O0.().Cols(A_1.Col).Name, "DateGroup", True) = 0 Then
				If Me.Oo0o_.oo00O0.().GetData(A_1.Row, "Name") Is Nothing Then
					A_1.Cancel = True
					Return
				End If
				Dim text As String = Me.Oo0o_.oo00O0.().GetData(A_1.Row, "Name").ToString()
				If Operators.CompareString(text, "", True) = 0 OrElse Not Me.OO_OO0O.o..DataTable.DataCols(text).IsDate Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x0600346F RID: 13423 RVA: 0x0015A024 File Offset: 0x00158224
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If Operators.CompareString(Me.O_0._O0o0.().Cols(A_1.Col).Name, "Name", True) = 0 AndAlso Me.O_0._O0o0.().GetData(A_1.Row, "Name") IsNot Nothing Then
				Dim text As String = Me.O_0._O0o0.().GetData(A_1.Row, "Name").ToString()
				If Operators.CompareString(text, "", True) <> 0 Then
					If Not Me.OO_OO0O.o..DataTable.DataCols(text).IsNumeric Then
						Me.O_0._O0o0.()(A_1.Row, "Aggregate") = 4
						Return
					End If
					If Me.O_0._O0o0.()(A_1.Row, "Aggregate") Is Nothing Then
						Me.O_0._O0o0.()(A_1.Row, "Aggregate") = 2
					End If
				End If
			End If
		End Sub

		' Token: 0x06003470 RID: 13424 RVA: 0x0015A110 File Offset: 0x00158310
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As RowColEventArgs)
			If A_1.Row > 0 AndAlso Operators.CompareString(Me.O_0._O0o0.().Cols(A_1.Col).Name, "Aggregate", True) = 0 Then
				If Me.O_0._O0o0.().GetData(A_1.Row, "Name") Is Nothing Then
					A_1.Cancel = True
					Return
				End If
				Dim text As String = Me.O_0._O0o0.().GetData(A_1.Row, "Name").ToString()
				If Operators.CompareString(text, "", True) = 0 OrElse Not Me.OO_OO0O.o..DataTable.DataCols(text).IsNumeric Then
					A_1.Cancel = True
				End If
			End If
		End Sub

		' Token: 0x06003471 RID: 13425 RVA: 0x0015A1C0 File Offset: 0x001583C0
		Private Function <<EMPTY_NAME>>() As GroupTableBuilder
			Dim num As Integer
			Dim result As GroupTableBuilder
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim text As String = Oo00.OoO_.__o.(Me.OO_OO0O.o., Me.o._ooO.().Checked)
				IL_21:
				num2 = 3
				If Operators.CompareString(Me.o.0O_O0_0OO.().Text.Trim(), "", True) <> 0 Then
					GoTo IL_5E
				End If
				IL_40:
				num2 = 4
				MessageBox.Show("请输入表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				IL_55:
				num2 = 5
				result = Nothing
				GoTo IL_5DC
				IL_5E:
				num2 = 6
				Dim index As Integer = Me.O_0._O0o0.().Cols("upto").Index
				IL_7C:
				num2 = 7
				If Operators.CompareString(Me.O_0._O0o0.().Text.Trim(), "", True) <= 0 Then
					GoTo IL_E5
				End If
				IL_9C:
				num2 = 8
				If Operators.CompareString(text, "", True) <> 0 Then
					GoTo IL_C4
				End If
				IL_AD:
				num2 = 9
				text = Me.O_0._O0o0.().Text.Trim()
				GoTo IL_E5
				IL_C4:
				num2 = 11
				text = text + " And " + Me.O_0._O0o0.().Text.Trim()
				IL_E5:
				num2 = 12
				Dim groupTableBuilder As GroupTableBuilder = New GroupTableBuilder(Me.o.0O_O0_0OO.().Text, Me.OO_OO0O.o..DataTable, text)
				IL_107:
				num2 = 13
				groupTableBuilder.Caption = Me.O.00O0oo0o_o_o.().Text
				IL_11C:
				num2 = 14
				Dim fixed As Integer = Me.Oo0o_.oo00O0.().Rows.Fixed
				Dim num3 As Integer = Me.Oo0o_.oo00O0.().Rows.Count - 2
				For i As Integer = fixed To num3
					IL_14A:
					num2 = 15
					If Operators.CompareString(Me.Oo0o_.oo00O0.().GetDataDisplay(i, "Name"), "", True) > 0 Then
						IL_170:
						num2 = 16
						Dim groupOn As GroupOn = New GroupOn()
						IL_17A:
						num2 = 17
						groupOn.Name = Me.Oo0o_.oo00O0.()(i, "Name").ToString()
						IL_19B:
						num2 = 18
						If Me.Oo0o_.oo00O0.()(i, "DateGroup") IsNot Nothing Then
							IL_1B2:
							num2 = 19
							groupOn.DateGroup = Conversions.ToInteger(Me.Oo0o_.oo00O0.()(i, "DateGroup"))
						End If
						IL_1D3:
						num2 = 20
						If Me.Oo0o_.oo00O0.()(i, "NewName") IsNot Nothing Then
							IL_1EA:
							num2 = 21
							groupOn.NewName = Me.Oo0o_.oo00O0.()(i, "NewName").ToString()
						End If
						IL_20B:
						num2 = 22
						If Me.Oo0o_.oo00O0.()(i, "NewCaption") IsNot Nothing Then
							IL_222:
							num2 = 23
							groupOn.NewCaption = Me.Oo0o_.oo00O0.()(i, "NewCaption").ToString()
						End If
						IL_243:
						num2 = 24
						groupTableBuilder.Groups.Add(groupOn)
					End If
					IL_254:
					num2 = 25
				Next
				IL_266:
				num2 = 26
				Dim fixed2 As Integer = Me.O_0._O0o0.().Rows.Fixed
				Dim num4 As Integer = Me.O_0._O0o0.().Rows.Count - 2
				For j As Integer = fixed2 To num4
					IL_294:
					num2 = 27
					If Operators.CompareString(Me.O_0._O0o0.().GetDataDisplay(j, "Name"), "", True) > 0 Then
						IL_2BA:
						num2 = 28
						Dim totalOn As TotalOn = New TotalOn()
						IL_2C4:
						num2 = 29
						totalOn.Name = Me.O_0._O0o0.()(j, "Name").ToString()
						IL_2E5:
						num2 = 30
						If Me.O_0._O0o0.()(j, "Aggregate") IsNot Nothing Then
							IL_2FC:
							num2 = 31
							totalOn.Aggregate = Conversions.ToInteger(Me.O_0._O0o0.()(j, "Aggregate"))
						End If
						IL_31D:
						num2 = 32
						If Me.O_0._O0o0.()(j, "NewName") IsNot Nothing Then
							IL_334:
							num2 = 33
							totalOn.NewName = Me.O_0._O0o0.()(j, "NewName").ToString()
						End If
						IL_355:
						num2 = 34
						If Me.O_0._O0o0.()(j, "NewCaption") IsNot Nothing Then
							IL_36C:
							num2 = 35
							totalOn.NewCaption = Me.O_0._O0o0.()(j, "NewCaption").ToString()
						End If
						IL_38D:
						num2 = 36
						If Me.O_0._O0o0.().GetCellCheck(j, index) = 1 Then
							IL_3A2:
							num2 = 37
							totalOn.upto = True
						End If
						IL_3AD:
						num2 = 38
						groupTableBuilder.Totals.Add(totalOn)
					End If
					IL_3BE:
					num2 = 39
				Next
				IL_3D0:
				num2 = 40
				groupTableBuilder.VerticalTotal = Me.o00_.oo0O_.().Checked
				IL_3E5:
				num2 = 41
				groupTableBuilder.GrandProportion = Me.o0o_0o00.0o.().Checked
				IL_3FA:
				num2 = 42
				groupTableBuilder.GroupProportion = Me.Oo__.O0_o0OOoO.().Checked
				IL_40F:
				num2 = 43
				groupTableBuilder.CircleGrowth = Me.o_O._.().Checked
				IL_424:
				num2 = 44
				groupTableBuilder.SamePeriodGrowth = Me.OooooO_.O0.().Checked
				IL_439:
				num2 = 45
				groupTableBuilder.Decimals = Convert.ToInt32(Me.O_Oo.OOO00o_O.().Value)
				IL_453:
				num2 = 46
				groupTableBuilder.FromServer = Me.o._ooO.().Checked
				IL_468:
				num2 = 47
				If Me.OO_OO0O.o..O.OoOo_. Is Nothing OrElse Me.OO_OO0O.o..O.OoOo_..FindForm() IsNot Main.OO_O.o. OrElse Operators.CompareString(Me.OO_OO0O.o..DataTable.LoadTop, "", True) <= 0 OrElse Not Me.OO_OO0O.o..AllowBackEndFilter Then
					GoTo IL_5A7
				End If
				IL_4C6:
				num2 = 48
				groupTableBuilder.FromServer = True
				IL_4D1:
				num2 = 49
				If Not Me.o._ooO.().Checked Then
					GoTo IL_4EE
				End If
				IL_4E1:
				num2 = 50
				groupTableBuilder.FromAll = True
				GoTo IL_508
				IL_4EE:
				num2 = 52
				groupTableBuilder.Filter = Me.OO_OO0O.o..DataTable.LoadFilter
				IL_508:
				num2 = 53
				If Operators.CompareString(Me.O_0._O0o0.().Text.Trim(), "", True) <= 0 Then
					GoTo IL_5A7
				End If
				IL_529:
				num2 = 54
				If Operators.CompareString(groupTableBuilder.Filter, "", True) <= 0 Then
					GoTo IL_58D
				End If
				IL_541:
				num2 = 55
				groupTableBuilder.Filter = String.Concat(New String() { "(", groupTableBuilder.Filter, ") And (", Me.O_0._O0o0.().Text.Trim(), ")" })
				GoTo IL_5A7
				IL_58D:
				num2 = 57
				groupTableBuilder.Filter = Me.O_0._O0o0.().Text.Trim()
				IL_5A7:
				num2 = 58
				groupTableBuilder.ExtendFilter = Me.O_0._O0o0.().Text.Trim()
				IL_5C1:
				num2 = 59
				groupTableBuilder.Subtotal = Me.O_Oo.OOO00o_O.().Checked
				IL_5D6:
				num2 = 60
				result = groupTableBuilder
				IL_5DC:
				GoTo IL_722
				IL_5E1:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_6E3:
				GoTo IL_717
				IL_6E5:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6F5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6E5
			End Try
			IL_717:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_722:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003472 RID: 13426 RVA: 0x0015A914 File Offset: 0x00158B14
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim groupTableBuilder As GroupTableBuilder = Me.oO0Ooo.00O_.()
			If groupTableBuilder IsNot Nothing AndAlso groupTableBuilder.Groups.Count > 0 AndAlso groupTableBuilder.Totals.Count > 0 Then
				groupTableBuilder.Build()
				groupTableBuilder.FromServer = Me.o._ooO.().Checked
				Me.OO_OO0O.o..O_0._O_0OO000O. = groupTableBuilder
				If OO_00oOO.Tables.get_Contains(groupTableBuilder.TableName) Then
					OO_00oOO.MainTable = OO_00oOO.Tables(groupTableBuilder.TableName)
				End If
				MyBase.DialogResult = DialogResult.OK
				Me.OO_OO0O.o..NeedSaveSetting = True
				Me.OO_OO0O.o..oo0OO0Ooo._.(True)
			End If
		End Sub

		' Token: 0x06003473 RID: 13427 RVA: 0x0015A9B4 File Offset: 0x00158BB4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim topRow As Integer = c1FlexGrid.Selection.TopRow
				Dim bottomRow As Integer = c1FlexGrid.Selection.BottomRow
				Dim num As Integer = topRow
				While num <= bottomRow AndAlso num <> c1FlexGrid.Rows.Count - 1
					c1FlexGrid.Rows.Remove(num)
					num += 1
				End While
			End If
		End Sub

		' Token: 0x06003474 RID: 13428 RVA: 0x0015AA20 File Offset: 0x00158C20
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row > c1FlexGrid.Rows.Fixed Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row - 1)
				End If
			End If
		End Sub

		' Token: 0x06003475 RID: 13429 RVA: 0x0015AA78 File Offset: 0x00158C78
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				If c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2 Then
					c1FlexGrid.Rows(c1FlexGrid.Row).Move(c1FlexGrid.Row + 1)
				End If
			End If
		End Sub

		' Token: 0x06003476 RID: 13430 RVA: 0x0015AAD1 File Offset: 0x00158CD1
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As CancelEventArgs)
			If Operators.CompareString(Me.o.0O_O0_0OO.().Text, "", True) > 0 AndAlso Not o_O_o_oOoo__.O_o_._o0.(Me.o.0O_O0_0OO.().Text) Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06003477 RID: 13431 RVA: 0x0015AB08 File Offset: 0x00158D08
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim groupTableBuilder As GroupTableBuilder = Me.oO0Ooo.00O_.()
			If groupTableBuilder IsNot Nothing AndAlso groupTableBuilder.Groups.Count > 0 AndAlso groupTableBuilder.Totals.Count > 0 Then
				Dim a_ As GroupTableProperty = New GroupTableProperty(groupTableBuilder)
				New O\u3002_\u3002\u3000\u3002(Me.OO_OO0O.o., o_O_o_oOoo__.OOOO_OO._oo.(a_, False, vbVerticalTab, False), 1).ShowDialog()
			End If
		End Sub

		' Token: 0x06003478 RID: 13432 RVA: 0x0015AB5E File Offset: 0x00158D5E
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			New o\u3000\u3000\u3002\u3002\u3002\u3002o(Me.OO_OO0O.o., 1).ShowDialog()
		End Sub

		' Token: 0x06003479 RID: 13433 RVA: 0x0015AB72 File Offset: 0x00158D72
		Public Sub New(A_0 As Boolean)
			Me.New(A_0, OO_00oOO.CurrentTable)
		End Sub

		' Token: 0x0600347A RID: 13434 RVA: 0x0015AB80 File Offset: 0x00158D80
		Public Sub New(A_0 As Boolean, A_1 As Table)
			AddHandler MyBase.Activated, AddressOf Me.OoOo0.oo.
			AddHandler MyBase.Load, AddressOf Me.O.O_0o0oo_o0.
			AddHandler MyBase.FormClosed, AddressOf Me.O.O_0o0oo_o0.
			Dim num2 As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_3C:
				Dim num As Integer = 1
				Me.O_0._O0o0.()
				IL_44:
				num = 2
				Main.OO_O.o..OOoo___.0.(MyBase.Controls, "(default)")
				IL_5B:
				num = 3
				Dim array As C1FlexGrid() = New C1FlexGrid() { Me.Oo0o_.oo00O0.(), Me.O_0._O0o0.() }
				IL_76:
				num = 4
				For Each c1FlexGrid As C1FlexGrid In array
					IL_87:
					num = 5
					c1FlexGrid.Styles.SelectedColumnHeader.Clear()
					IL_9A:
					num = 6
					c1FlexGrid.Styles.Alternate.Clear()
					IL_AD:
					num = 7
					c1FlexGrid.Styles.Focus.Clear()
					IL_C0:
					num = 8
					c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal)
					IL_DF:
					num = 9
					c1FlexGrid.FocusRect = 3
					IL_EA:
					num = 10
					c1FlexGrid.AllowSorting = 0
					IL_F5:
					num = 11
				Next
				IL_109:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_110:
				num = 13
				Me.OO_OO0O.o. = A_1
				IL_11A:
				num = 14
				Dim listDictionary As ListDictionary = New ListDictionary()
				IL_124:
				num = 15
				Dim listDictionary2 As ListDictionary = New ListDictionary()
				IL_12E:
				num = 16
				Dim dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()
				IL_138:
				num = 17
				Dim enumerator As IEnumerator(Of Col) = A_1.Cols.GetEnumerator()
				While enumerator.MoveNext()
					Dim col As Col = enumerator.Current
					IL_153:
					num = 18
					dictionary.Add(col.Name, col.Caption)
					IL_16B:
					num = 19
				End While
				IL_177:
				num = 20
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_185:
				num = 21
				Me.Oo0o_.oo00O0.().Cols("Name").DataMap = dictionary
				IL_1A4:
				num = 22
				Me.O_0._O0o0.().Cols("Name").DataMap = dictionary
				IL_1C3:
				num = 23
				listDictionary.Add(2, "累计值")
				IL_1D8:
				num = 24
				listDictionary.Add(6, "平均值")
				IL_1ED:
				num = 25
				listDictionary.Add(4, "记录数")
				IL_202:
				num = 26
				listDictionary.Add(7, "最大值")
				IL_217:
				num = 27
				listDictionary.Add(8, "最小值")
				IL_22C:
				num = 28
				Me.O_0._O0o0.().Cols("Aggregate").DataMap = listDictionary
				IL_24B:
				num = 29
				listDictionary2.Add(3, "月")
				IL_260:
				num = 30
				listDictionary2.Add(2, "季")
				IL_275:
				num = 31
				listDictionary2.Add(1, "年")
				IL_28A:
				num = 32
				listDictionary2.Add(4, "周")
				IL_29F:
				num = 33
				listDictionary2.Add(5, "日")
				IL_2B4:
				num = 34
				listDictionary2.Add(6, "时")
				IL_2C9:
				num = 35
				listDictionary2.Add(7, "分")
				IL_2DE:
				num = 36
				listDictionary2.Add(8, "秒")
				IL_2F3:
				num = 37
				listDictionary2.Add(10, "周日")
				IL_309:
				num = 38
				listDictionary2.Add(9, "年日")
				IL_31F:
				num = 39
				listDictionary2.Add(0, "无")
				IL_334:
				num = 40
				Me.Oo0o_.oo00O0.().Cols("DateGroup").DataMap = listDictionary2
				Dim flag As Boolean
				Dim num3 As Integer
				Do
					IL_353:
					num = 42
					flag = False
					IL_359:
					num = 43
					num3 += 1
					IL_362:
					num = 44
					Dim right As String = "统计表" + Conversions.ToString(num3)
					IL_378:
					num = 45
					Dim enumerator2 As IEnumerator(Of DataTable) = OO_00oOO.DataTables.GetEnumerator()
					While enumerator2.MoveNext()
						Dim dataTable As DataTable = enumerator2.Current
						IL_392:
						num = 46
						If Operators.CompareString(dataTable.Name, right, True) = 0 Then
							IL_3A6:
							num = 47
							flag = True
							Exit While
						End If
						IL_3AE:
						num = 49
					End While
					IL_3BA:
					num = 50
					If enumerator2 IsNot Nothing Then
						enumerator2.Dispose()
					End If
					IL_3C8:
					num = 51
				Loop While flag
				IL_3CF:
				num = 52
				Me.o.0O_O0_0OO.().Value = "统计表" + Conversions.ToString(num3)
				IL_3EE:
				num = 53
				If A_0 OrElse A_1.O_0._O_0OO000O. Is Nothing Then
					GoTo IL_8F2
				End If
				IL_402:
				num = 54
				Dim groupTableBuilder As GroupTableBuilder = A_1.O_0._O_0OO000O.
				IL_40D:
				num = 55
				Me.o.0O_O0_0OO.().Value = groupTableBuilder.TableName
				IL_422:
				num = 56
				Me.O.00O0oo0o_o_o.().Value = groupTableBuilder.Caption
				IL_437:
				num = 57
				Me.O_0._O0o0.().Value = groupTableBuilder.ExtendFilter
				IL_44C:
				num = 58
				Me.o00_.oo0O_.().Checked = A_1.O_0._O_0OO000O..VerticalTotal
				IL_465:
				num = 59
				Me.O_Oo.OOO00o_O.().Checked = A_1.O_0._O_0OO000O..Subtotal
				IL_47E:
				num = 60
				Me.o0o_0o00.0o.().Checked = A_1.O_0._O_0OO000O..GrandProportion
				IL_497:
				num = 61
				Me.Oo__.O0_o0OOoO.().Checked = A_1.O_0._O_0OO000O..GroupProportion
				IL_4B0:
				num = 62
				Me.OooooO_.O0.().Checked = A_1.O_0._O_0OO000O..SamePeriodGrowth
				IL_4C9:
				num = 63
				Me.o_O._.().Checked = A_1.O_0._O_0OO000O..CircleGrowth
				IL_4E2:
				num = 64
				Me.O_Oo.OOO00o_O.().Value = New Decimal(A_1.O_0._O_0OO000O..Decimals)
				IL_500:
				num = 65
				Me.o._ooO.().Checked = A_1.O_0._O_0OO000O..FromServer
				IL_519:
				num = 66
				Dim enumerator3 As IEnumerator(Of GroupOn) = groupTableBuilder.Groups.GetEnumerator()
				While enumerator3.MoveNext()
					Dim groupOn As GroupOn = enumerator3.Current
					IL_538:
					num = 67
					If A_1.DataTable.DataCols.Contains(groupOn.Name) Then
						IL_557:
						num = 69
						Me.Oo0o_.oo00O0.().AddItem(String.Concat(New String() { groupOn.Name + vbTab, vbTab, groupOn.NewName, vbTab, groupOn.NewCaption }))
						IL_5A9:
						num = 70
						If A_1.DataTable.DataCols(groupOn.Name).IsDate Then
							IL_5CA:
							num = 71
							Me.Oo0o_.oo00O0.()(Me.Oo0o_.oo00O0.().Rows.Count - 1, "DateGroup") = groupOn.DateGroup
						Else
							IL_5FD:
							num = 73
							Me.Oo0o_.oo00O0.()(Me.Oo0o_.oo00O0.().Rows.Count - 1, "DateGroup") = Nothing
						End If
						IL_623:
						num = 74
						If Operators.CompareString(groupOn.Name, groupOn.NewName, True) <> 0 Then
							IL_63C:
							num = 75
							Me.Oo0o_.oo00O0.()(Me.Oo0o_.oo00O0.().Rows.Count - 1, "NewName") = groupOn.NewName
						Else
							IL_66A:
							num = 77
							Me.Oo0o_.oo00O0.()(Me.Oo0o_.oo00O0.().Rows.Count - 1, "NewName") = Nothing
						End If
						IL_690:
						num = 78
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_6A8:
							num = 79
							Me.Oo0o_.oo00O0.()(Me.Oo0o_.oo00O0.().Rows.Count - 1, "NewCaption") = groupOn.NewCaption
						End If
					End If
					IL_6D4:
					num = 80
				End While
				IL_6E3:
				num = 81
				If enumerator3 IsNot Nothing Then
					enumerator3.Dispose()
				End If
				IL_6F1:
				num = 82
				Dim enumerator4 As IEnumerator(Of TotalOn) = groupTableBuilder.Totals.GetEnumerator()
				While enumerator4.MoveNext()
					Dim totalOn As TotalOn = enumerator4.Current
					IL_710:
					num = 83
					If Operators.CompareString(totalOn.NewName, totalOn.Name + "_" + Oo00.OoO_.__o.(totalOn.Aggregate), True) = 0 Then
						IL_73F:
						num = 84
						totalOn.NewName = ""
					End If
					IL_74E:
					num = 85
					If A_1.DataTable.DataCols.Contains(totalOn.Name) Then
						IL_76D:
						num = 86
						Me.O_0._O0o0.().AddItem(String.Concat(New String() { totalOn.Name + vbTab, vbTab, totalOn.NewName, vbTab, totalOn.NewCaption }))
						IL_7BF:
						num = 87
						Me.O_0._O0o0.()(Me.O_0._O0o0.().Rows.Count - 1, "Aggregate") = totalOn.Aggregate
						IL_7F0:
						num = 88
						If Operators.CompareString(totalOn.Name, totalOn.NewName, True) <> 0 Then
							IL_809:
							num = 89
							Me.O_0._O0o0.()(Me.O_0._O0o0.().Rows.Count - 1, "NewName") = totalOn.NewName
						Else
							IL_837:
							num = 91
							Me.O_0._O0o0.()(Me.O_0._O0o0.().Rows.Count - 1, "NewName") = Nothing
						End If
						IL_85D:
						num = 92
						If Operators.CompareString(totalOn.NewCaption, "", True) > 0 Then
							IL_875:
							num = 93
							Me.O_0._O0o0.()(Me.O_0._O0o0.().Rows.Count - 1, "NewCaption") = totalOn.NewCaption
						End If
						IL_8A1:
						num = 94
						Me.O_0._O0o0.()(Me.O_0._O0o0.().Rows.Count - 1, "upto") = totalOn.upto
					End If
					IL_8D2:
					num = 95
				End While
				IL_8E1:
				num = 96
				If enumerator4 IsNot Nothing Then
					enumerator4.Dispose()
				End If
				IL_8EF:
				groupTableBuilder = Nothing
				IL_8F2:
				num = 98
				Me.Oo0o_.oo00O0.().AllowAddNew = True
				IL_901:
				num = 99
				Me.O_0._O0o0.().AllowAddNew = True
				IL_910:
				num = 100
				Me.O.O_0o0oo_o0.().Visible = (OO_00oOO.User.Type = 0)
				IL_92B:
				num = 101
				Me.o._ooO.().Enabled = A_1.AllowBackgroundStatistics
				IL_93F:
				num = 102
				Me.O.O_0o0oo_o0.().Visible = False
				IL_94E:
				GoTo IL_B3C
				IL_953:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_AFD:
				GoTo IL_B31
				IL_AFF:
				num5 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_B0F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_AFF
			End Try
			IL_B31:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B3C:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600347B RID: 13435 RVA: 0x0015B6F0 File Offset: 0x001598F0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Me.O_0._O0o0.().Value = Me.OO_OO0O.o..DataTable.OOoo__00O_.o_O.(Me.O_0._O0o0.().Text, True)
		End Sub

		' Token: 0x0600347C RID: 13436 RVA: 0x0015B71C File Offset: 0x0015991C
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
				Dim groupTableBuilder As GroupTableBuilder = Me.oO0Ooo.00O_.()
				IL_10:
				num2 = 3
				If groupTableBuilder Is Nothing Then
					GoTo IL_8EB
				End If
				IL_18:
				num2 = 5
				Dim stringBuilder As StringBuilder = New StringBuilder()
				IL_21:
				num2 = 6
				stringBuilder.Append(String.Concat(New String() { "Dim g As New GroupTableBuilder(""", groupTableBuilder.TableName, """, DataTables(""", groupTableBuilder.SourceDataTable.Name, """))" }))
				IL_65:
				num2 = 7
				stringBuilder.Append(vbCrLf)
				IL_74:
				num2 = 8
				If Operators.CompareString(groupTableBuilder.Caption, "", True) <= 0 Then
					GoTo IL_BA
				End If
				IL_8A:
				num2 = 9
				stringBuilder.Append("g.Caption = """ + groupTableBuilder.Caption + """")
				IL_AA:
				num2 = 10
				stringBuilder.Append(vbCrLf)
				IL_BA:
				num2 = 11
				Dim enumerator As IEnumerator(Of GroupOn) = groupTableBuilder.Groups.GetEnumerator()
				While enumerator.MoveNext()
					Dim groupOn As GroupOn = enumerator.Current
					IL_D8:
					num2 = 12
					Dim text As String = ""
					IL_E2:
					num2 = 13
					If Operators.CompareString(groupOn.NewName, groupOn.Name, True) <> 0 Then
						IL_FB:
						num2 = 14
						text = groupOn.NewName
					End If
					IL_107:
					num2 = 15
					If Me.OO_OO0O.o..DataTable.DataCols(groupOn.Name).IsDate AndAlso groupOn.DateGroup <> 3 Then
						IL_13D:
						num2 = 16
						Dim text2 As String = "DateGroupEnum." + [Enum].GetName(GetType(DateGroupEnum), groupOn.DateGroup)
						IL_167:
						num2 = 17
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_17F:
							num2 = 18
							stringBuilder.Append(String.Concat(New String() { "g.Groups.AddDef(""", groupOn.Name, """, ", text2, ", """, text, """, """, groupOn.NewCaption, """)" }))
						Else
							IL_1E1:
							num2 = 20
							If Operators.CompareString(text, "", True) > 0 Then
								IL_1F4:
								num2 = 21
								stringBuilder.Append(String.Concat(New String() { "g.Groups.AddDef(""", groupOn.Name, """, ", text2, ", """, text, """)" }))
							Else
								IL_243:
								num2 = 23
								stringBuilder.Append(String.Concat(New String() { "g.Groups.AddDef(""", groupOn.Name, """, ", text2, ")" }))
							End If
						End If
					Else
						IL_285:
						num2 = 25
						If Operators.CompareString(groupOn.NewCaption, "", True) > 0 Then
							IL_29D:
							num2 = 26
							stringBuilder.Append(String.Concat(New String() { "g.Groups.AddDef(""", groupOn.Name, """, """, text, """, """, groupOn.NewCaption, """)" }))
						Else
							IL_2EE:
							num2 = 28
							If Operators.CompareString(text, "", True) > 0 Then
								IL_301:
								num2 = 29
								stringBuilder.Append(String.Concat(New String() { "g.Groups.AddDef(""", groupOn.Name, """, """, text, """)" }))
							Else
								IL_340:
								num2 = 31
								stringBuilder.Append("g.Groups.AddDef(""" + groupOn.Name + """)")
							End If
						End If
					End If
					IL_361:
					num2 = 32
					stringBuilder.Append(vbCrLf)
					IL_371:
					num2 = 33
				End While
				IL_380:
				num2 = 34
				If enumerator IsNot Nothing Then
					enumerator.Dispose()
				End If
				IL_38E:
				num2 = 35
				Dim enumerator2 As IEnumerator(Of TotalOn) = groupTableBuilder.Totals.GetEnumerator()
				While enumerator2.MoveNext()
					Dim totalOn As TotalOn = enumerator2.Current
					IL_3AC:
					num2 = 36
					Dim text3 As String = ""
					IL_3B6:
					num2 = 37
					If Operators.CompareString(totalOn.NewName, totalOn.Name, True) <> 0 Then
						IL_3CF:
						num2 = 38
						text3 = totalOn.NewName
					End If
					IL_3DB:
					num2 = 39
					If totalOn.Aggregate = 2 Then
						IL_3EB:
						num2 = 40
						If Operators.CompareString(totalOn.NewCaption, "", True) > 0 Then
							IL_403:
							num2 = 41
							stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", totalOn.Name, """, """, text3, """, """, totalOn.NewCaption, """" }))
						Else
							IL_457:
							num2 = 43
							If Operators.CompareString(text3, "", True) > 0 Then
								IL_46A:
								num2 = 44
								stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", totalOn.Name, """, """, text3, """" }))
							Else
								IL_4AC:
								num2 = 46
								stringBuilder.Append("g.Totals.AddDef(""" + totalOn.Name + """")
							End If
						End If
					Else
						IL_4D2:
						num2 = 48
						Dim text4 As String = "AggregateEnum." + [Enum].GetName(GetType(AggregateEnum), totalOn.Aggregate)
						IL_4FC:
						num2 = 49
						If Operators.CompareString(totalOn.NewCaption, "", True) > 0 Then
							IL_514:
							num2 = 50
							stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", totalOn.Name, """, ", text4, ", """, text3, """, """, totalOn.NewCaption, """" }))
						Else
							IL_576:
							num2 = 52
							If Operators.CompareString(text3, "", True) > 0 Then
								IL_589:
								num2 = 53
								stringBuilder.Append(String.Concat(New String() { "g.Totals.AddDef(""", totalOn.Name, """, ", text4, ", """, text3, """" }))
							Else
								IL_5D5:
								num2 = 55
								stringBuilder.Append("g.Totals.AddDef(""" + totalOn.Name + """, " + text4)
							End If
						End If
					End If
					IL_5F8:
					num2 = 56
					If totalOn.upto Then
						IL_604:
						num2 = 57
						stringBuilder.Append(",True")
					End If
					IL_614:
					num2 = 58
					stringBuilder = stringBuilder.Append(")")
					IL_625:
					num2 = 59
					stringBuilder.Append(vbCrLf)
					IL_635:
					num2 = 60
				End While
				IL_644:
				num2 = 61
				If enumerator2 IsNot Nothing Then
					enumerator2.Dispose()
				End If
				IL_652:
				num2 = 62
				If Not Me.o00_.oo0O_.().Checked Then
					GoTo IL_682
				End If
				IL_662:
				num2 = 63
				stringBuilder.Append("g.VerticalTotal = True")
				IL_672:
				num2 = 64
				stringBuilder.Append(vbCrLf)
				IL_682:
				num2 = 65
				If Not Me.O_Oo.OOO00o_O.().Checked Then
					GoTo IL_6B2
				End If
				IL_692:
				num2 = 66
				stringBuilder.Append("g.SubTotal = True")
				IL_6A2:
				num2 = 67
				stringBuilder.Append(vbCrLf)
				IL_6B2:
				num2 = 68
				If Not Me.Oo__.O0_o0OOoO.().Checked Then
					GoTo IL_6E2
				End If
				IL_6C2:
				num2 = 69
				stringBuilder.Append("g.GroupProportion = True")
				IL_6D2:
				num2 = 70
				stringBuilder.Append(vbCrLf)
				IL_6E2:
				num2 = 71
				If Not Me.o0o_0o00.0o.().Checked Then
					GoTo IL_712
				End If
				IL_6F2:
				num2 = 72
				stringBuilder.Append("g.GrandProportion = True")
				IL_702:
				num2 = 73
				stringBuilder.Append(vbCrLf)
				IL_712:
				num2 = 74
				If Not Me.OooooO_.O0.().Checked Then
					GoTo IL_742
				End If
				IL_722:
				num2 = 75
				stringBuilder.Append("g.SamePeriodGrowth = True")
				IL_732:
				num2 = 76
				stringBuilder.Append(vbCrLf)
				IL_742:
				num2 = 77
				If Not Me.o_O._.().Checked Then
					GoTo IL_772
				End If
				IL_752:
				num2 = 78
				stringBuilder.Append("g.CircleGrowth = True")
				IL_762:
				num2 = 79
				stringBuilder.Append(vbCrLf)
				IL_772:
				num2 = 80
				If Decimal.Compare(Me.O_Oo.OOO00o_O.().Value, 4D) = 0 Then
					GoTo IL_7C8
				End If
				IL_78E:
				num2 = 81
				stringBuilder.Append("g.Decimals = " + Conversions.ToString(Convert.ToInt32(Me.O_Oo.OOO00o_O.().Value)))
				IL_7B8:
				num2 = 82
				stringBuilder.Append(vbCrLf)
				IL_7C8:
				num2 = 83
				If Not Me.o._ooO.().Checked Then
					GoTo IL_81F
				End If
				IL_7D8:
				num2 = 84
				If Not Me.OO_OO0O.o..DataTable.frd_IsInnerTable AndAlso Not Me.OO_OO0O.o..DataTable.frd_IsOuterTable Then
					GoTo IL_81F
				End If
				IL_7FF:
				num2 = 85
				stringBuilder.Append("g.FromServer = True")
				IL_80F:
				num2 = 86
				stringBuilder.Append(vbCrLf)
				IL_81F:
				num2 = 87
				If Operators.CompareString(Me.O_0._O0o0.().Text, "", True) <= 0 Then
					GoTo IL_870
				End If
				IL_83B:
				num2 = 88
				stringBuilder.Append("g.Filter = """ + Me.O_0._O0o0.().Text + """")
				IL_860:
				num2 = 89
				stringBuilder.Append(vbCrLf)
				IL_870:
				num2 = 90
				stringBuilder.Append("g.Build()")
				IL_880:
				num2 = 91
				stringBuilder.Append(vbCrLf)
				IL_890:
				num2 = 92
				stringBuilder.Append("MainTable = Tables(""" + groupTableBuilder.TableName + """)")
				IL_8B0:
				num2 = 93
				Dim o_u3000_u3000_u3002_u3002O As o\u3000\u3000\u3002\u3002O = New o\u3000\u3000\u3002\u3002O()
				IL_8BA:
				num2 = 94
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString()
				IL_8D0:
				num2 = 95
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0
				IL_8E0:
				num2 = 96
				o_u3000_u3000_u3002_u3002O.ShowDialog()
				IL_8EB:
				GoTo IL_AC1
				IL_8F0:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_A82:
				GoTo IL_AB6
				IL_A84:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_A94:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A84
			End Try
			IL_AB6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_AC1:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x0600347D RID: 13437 RVA: 0x0015C210 File Offset: 0x0015A410
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If TypeOf MyBase.ActiveControl Is C1FlexGrid Then
				Dim c1FlexGrid As C1FlexGrid = CType(MyBase.ActiveControl, C1FlexGrid)
				Dim num As Integer = Math.Max(c1FlexGrid.Row, c1FlexGrid.Rows.Fixed)
				c1FlexGrid.Rows.Insert(num)
				c1FlexGrid.Row = num
			End If
		End Sub

		' Token: 0x0600347E RID: 13438 RVA: 0x0015C264 File Offset: 0x0015A464
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.o._ooO.().Checked Then
				Me.oo.0O.().Enabled = False
				If Not Me.OO_OO0O.o..DataTable.frd_IsInnerTable Then
					Me.OO_OO0O.o..DataTable.frd_IsOuterTable
					Return
				End If
			Else
				If Me.OO_OO0O.o..O.OoOo_. IsNot Nothing AndAlso Me.OO_OO0O.o..O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(Me.OO_OO0O.o..DataTable.LoadTop, "", True) > 0 AndAlso Me.OO_OO0O.o..AllowBackEndFilter Then
					Me.oo.0O.().Enabled = False
					Return
				End If
				Me.oo.0O.().Enabled = True
			End If
		End Sub

		' Token: 0x0600347F RID: 13439 RVA: 0x0015C316 File Offset: 0x0015A516
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.a = 0 Then
				Me.a = 1
				Me.OO_OO0O.o..Oo0Oo___.o0o.()
			End If
		End Sub

		' Token: 0x06003480 RID: 13440 RVA: 0x0015C334 File Offset: 0x0015A534
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.OO_OO0O.o..Rows.Count < 2 Then
				Me.o._ooO.().Checked = True
			End If
			If Me.OO_OO0O.o..O.OoOo_. IsNot Nothing AndAlso Me.OO_OO0O.o..O.OoOo_..FindForm() Is Main.OO_O.o. AndAlso Operators.CompareString(Me.OO_OO0O.o..DataTable.LoadTop, "", True) > 0 AndAlso Me.OO_OO0O.o..AllowBackEndFilter Then
				Me.oo.0O.().Enabled = False
			End If
		End Sub

		' Token: 0x06003481 RID: 13441 RVA: 0x0015C3BB File Offset: 0x0015A5BB
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosedEventArgs)
			Main.OO_O.o..o0oO_O.0Oo_00.(MyBase.Controls)
		End Sub

		' Token: 0x04001546 RID: 5446
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001547 RID: 5447
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001548 RID: 5448
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001549 RID: 5449
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400154A RID: 5450
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400154B RID: 5451
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400154C RID: 5452
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400154D RID: 5453
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x0400154E RID: 5454
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x0400154F RID: 5455
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001550 RID: 5456
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1TextBox

		' Token: 0x04001551 RID: 5457
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001552 RID: 5458
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001553 RID: 5459
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001554 RID: 5460
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x04001555 RID: 5461
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1FlexGrid

		' Token: 0x04001556 RID: 5462
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ContextMenuStrip

		' Token: 0x04001557 RID: 5463
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04001558 RID: 5464
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x04001559 RID: 5465
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400155A RID: 5466
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1Button

		' Token: 0x0400155B RID: 5467
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As ToolStripMenuItem

		' Token: 0x0400155C RID: 5468
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400155D RID: 5469
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400155E RID: 5470
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x0400155F RID: 5471
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001560 RID: 5472
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001561 RID: 5473
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As GroupBox

		' Token: 0x04001562 RID: 5474
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As Label

		' Token: 0x04001563 RID: 5475
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As NumericUpDown

		' Token: 0x04001564 RID: 5476
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001565 RID: 5477
		<CompilerGenerated()>
		Private <<EMPTY_NAME>> As C1CheckBox

		' Token: 0x04001566 RID: 5478
		Private <<EMPTY_NAME>> As Table

		' Token: 0x04001567 RID: 5479
		Private a As Integer
	End Class
End Namespace
