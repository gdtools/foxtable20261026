Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports C1.Win.C1Command
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003ED RID: 1005
	<DesignerGenerated()>
	Friend Partial Class o\u3002\u3002\u3000\u3000\u3002
		Inherits Form
		Implements O0_0_0_0_

		' Token: 0x06003F42 RID: 16194 RVA: 0x001B7B13 File Offset: 0x001B5D13
		<DebuggerNonUserCode()>
		Protected Overridable Overloads Sub <<EMPTY_NAME>>(A_0 As Boolean)
			If A_0 AndAlso Me.OO_O0_oO0__._. IsNot Nothing Then
				Me.OO_O0_oO0__._..Dispose()
			End If
			MyBase.Dispose(A_0)
		End Sub

		' Token: 0x06003F43 RID: 16195 RVA: 0x001B7B34 File Offset: 0x001B5D34
		<DebuggerStepThrough()>
		Private Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 7
			MyBase.SuspendLayout()
			Me.AllowDrop = True
			MyBase.AutoScaleDimensions = New SizeF(6F, 12F)
			MyBase.AutoScaleMode = AutoScaleMode.Font
			MyBase.ClientSize = New Size(503, 407)
			MyBase.KeyPreview = True
			MyBase.Location = New Point(20, 20)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = O00OOOo_O0_O.b("杖�래풚뎜꾞辠ﲢ认", a_)
			MyBase.ShowIcon = False
			MyBase.StartPosition = FormStartPosition.Manual
			Me.Text = O00OOOo_O0_O.b("ˮ瓅", a_)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x06003F44 RID: 16196
		Private Declare Function GetPixel Lib "gdi32.dll" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer) As Integer

		' Token: 0x06003F45 RID: 16197
		Private Declare Function SetPixel Lib "gdi32.dll" (A_0 As IntPtr, A_1 As Integer, A_2 As Integer, A_3 As Integer) As Integer

		' Token: 0x06003F46 RID: 16198 RVA: 0x001B7BEC File Offset: 0x001B5DEC
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If A_0 IsNot Me OrElse Control.ModifierKeys = Keys.Control Then
					GoTo IL_3E
				End If
				IL_19:
				num2 = 3
				oOO0oo_o0.o0.Oo__.(MyBase.Controls)
				IL_26:
				num2 = 4
				CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.().SelectedIndex = 0
				IL_3E:
				num2 = 5
				If A_1.Button <> MouseButtons.Left Then
					GoTo IL_8F
				End If
				IL_4D:
				num2 = 6
				Me.O0o._0. = True
				IL_56:
				num2 = 7
				Me.o_0O.OO0_0_. = New Rectangle(A_1.X, A_1.Y, 0, 0)
				IL_71:
				num2 = 8
				Me.o_0O.OO0_0_. = New Point(A_1.X, A_1.Y)
				GoTo IL_11B
				IL_8F:
				num2 = 10
				Me.O0o._0. = False
				IL_99:
				num2 = 11
				If Me.o_0O.OO0_0_..IsEmpty Then
					GoTo IL_11B
				End If
				IL_A9:
				num2 = 12
				Dim graphics As Graphics = CType(A_0, Control).CreateGraphics()
				IL_B8:
				num2 = 13
				Dim pen As Pen = New Pen(CType(A_0, Control).BackColor)
				IL_CD:
				num2 = 14
				If CType(A_0, Control).BackgroundImage IsNot Nothing Then
					GoTo IL_F0
				End If
				IL_DD:
				num2 = 15
				graphics.DrawRectangle(pen, Me.o_0O.OO0_0_.)
				GoTo IL_FA
				IL_F0:
				num2 = 17
				Me.oooo_._O.(graphics)
				IL_FA:
				num2 = 18
				pen.Dispose()
				IL_104:
				num2 = 19
				graphics.Dispose()
				IL_10D:
				num2 = 20
				Me.o_0O.OO0_0_. = Rectangle.Empty
				IL_11B:
				GoTo IL_1C1
				IL_120:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_182:
				GoTo IL_1B6
				IL_184:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_194:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_184
			End Try
			IL_1B6:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1C1:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003F47 RID: 16199 RVA: 0x001B7DE0 File Offset: 0x001B5FE0
		Private Sub <<EMPTY_NAME>>(A_0 As Graphics)
			Dim hdc As IntPtr = A_0.GetHdc()
			Try
				For Each o_O As o\u3002\u3002\u3000\u3000\u3002.o_O In Me.o_0O.OO0_0_.
					o\u3002\u3002\u3000\u3000\u3002.SetPixel(hdc, o_O.O.00OO00_oo., o_O.O0oOOo_o_O.O_O., o_O.o.oo_OOO.)
				Next
			Finally
				Dim enumerator As List(Of o\u3002\u3002\u3000\u3000\u3002.o_O).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Me.o_0O.OO0_0_..Clear()
			A_0.ReleaseHdc()
		End Sub

		' Token: 0x06003F48 RID: 16200 RVA: 0x001B7E60 File Offset: 0x001B6060
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
		End Sub

		' Token: 0x06003F49 RID: 16201 RVA: 0x001B7E62 File Offset: 0x001B6062
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
		End Sub

		' Token: 0x06003F4A RID: 16202 RVA: 0x001B7E64 File Offset: 0x001B6064
		Private Sub <<EMPTY_NAME>>(A_0 As Object)
			Try
				For Each obj As Object In CType(A_0, Control).Controls
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is ControlHolder AndAlso control.Bounds.IntersectsWith(Me.ooOOOO.0o.) Then
						CType(control, ControlHolder).Selected = True
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F4B RID: 16203 RVA: 0x001B7EE8 File Offset: 0x001B60E8
		Friend Function <<EMPTY_NAME>>(A_0 As Control.ControlCollection, A_1 As String) As Boolean
			Dim num As Integer
			Dim result As Boolean
			Dim num4 As Integer
			Dim obj4 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim enumerator As IEnumerator = A_0.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim control As Control = CType(obj, Control)
					IL_24:
					num2 = 3
					If TypeOf control Is ControlHolder Then
						IL_32:
						num2 = 4
						If Operators.CompareString(control.Name, A_1, True) = 0 Then
							IL_44:
							num2 = 5
							result = True
						Else
							IL_4D:
							num2 = 7
							If CType(control, ControlHolder).ControlType = ControlTypeEnum.GroupBox Or CType(control, ControlHolder).ControlType = ControlTypeEnum.Panel Or CType(control, ControlHolder).ControlType = ControlTypeEnum.Gauges Or CType(control, ControlHolder).ControlType = ControlTypeEnum.Map Then
								IL_94:
								num2 = 8
								If Not Me.OO__oo0.0O___.(CType(control, ControlHolder).ChildControl.Controls, A_1) Then
									GoTo IL_280
								End If
								IL_B3:
								num2 = 9
								result = True
							Else
								IL_BD:
								num2 = 11
								If CType(control, ControlHolder).ControlType = ControlTypeEnum.PictureBox Then
									IL_D0:
									num2 = 12
									If Not Me.OO__oo0.0O___.(CType(CType(control, ControlHolder).ChildControl, CustomPictureBox).PictureBox1.Controls, A_1) Then
										GoTo IL_280
									End If
									IL_FA:
									num2 = 13
									result = True
								Else
									IL_104:
									num2 = 15
									If CType(control, ControlHolder).ControlType = ControlTypeEnum.TabControl Then
										IL_117:
										num2 = 16
										Dim enumerator2 As IEnumerator = CType(CType(control, ControlHolder).ChildControl, C1DockingTab).TabPages.GetEnumerator()
										While enumerator2.MoveNext()
											Dim obj2 As Object = enumerator2.Current
											Dim o_O_ As O_O_ = CType(obj2, O_O_)
											IL_147:
											num2 = 17
											If Me.OO__oo0.0O___.(o_O_.Controls, A_1) Then
												IL_15A:
												num2 = 18
												result = True
												GoTo IL_2AC
											End If
											IL_164:
											num2 = 19
										End While
										IL_170:
										num2 = 20
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
											GoTo IL_280
										End If
										GoTo IL_280
									Else
										IL_190:
										num2 = 22
										If CType(control, ControlHolder).ControlType = ControlTypeEnum.NavBar Then
											IL_1A3:
											num2 = 23
											Dim enumerator3 As IEnumerator = CType(CType(control, ControlHolder).ChildControl, C1NavBar).Panels.GetEnumerator()
											While enumerator3.MoveNext()
												Dim obj3 As Object = enumerator3.Current
												Dim oO_ As oO_0 = CType(obj3, oO_0)
												IL_1D3:
												num2 = 24
												If Me.OO__oo0.0O___.(oO_.Controls, A_1) Then
													IL_1E6:
													num2 = 25
													result = True
													GoTo IL_2AC
												End If
												IL_1F0:
												num2 = 26
											End While
											IL_1FC:
											num2 = 27
											If TypeOf enumerator3 Is IDisposable Then
												TryCast(enumerator3, IDisposable).Dispose()
												GoTo IL_280
											End If
											GoTo IL_280
										Else
											IL_216:
											num2 = 29
											If CType(control, ControlHolder).ControlType <> ControlTypeEnum.SplitContainer Then
												GoTo IL_280
											End If
											IL_229:
											num2 = 30
											Dim o0000O As o0000O = CType(CType(control, ControlHolder).ChildControl, o0000O)
											IL_23F:
											num2 = 31
											If Me.OO__oo0.0O___.(o0000O.oo0oO_O.oooO0O.().Controls, A_1) Then
												IL_257:
												num2 = 32
												result = True
											Else
												IL_25E:
												num2 = 33
												If Not Me.OO__oo0.0O___.(o0000O.o.Oo0oo000O.().Controls, A_1) Then
													IL_27D:
													o0000O = Nothing
													GoTo IL_280
												End If
												IL_276:
												num2 = 34
												result = True
											End If
										End If
									End If
								End If
							End If
						End If
						IL_2AC:
						GoTo IL_39A
					End If
					IL_280:
					num2 = 36
				End While
				IL_28F:
				num2 = 37
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				IL_2A7:
				num2 = 38
				result = False
				GoTo IL_2AC
				IL_2B1:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_35B:
				GoTo IL_38F
				IL_35D:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_36D:
			Catch obj5 When endfilter(TypeOf obj4 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj5, Exception)
				GoTo IL_35D
			End Try
			IL_38F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_39A:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		' Token: 0x06003F4C RID: 16204 RVA: 0x001B82B4 File Offset: 0x001B64B4
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ControlEventArgs)
		End Sub

		' Token: 0x06003F4D RID: 16205 RVA: 0x001B82B6 File Offset: 0x001B64B6
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As FormClosingEventArgs)
			If A_1.CloseReason = CloseReason.UserClosing Then
				A_1.Cancel = True
			End If
		End Sub

		' Token: 0x06003F4E RID: 16206 RVA: 0x001B82C8 File Offset: 0x001B64C8
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
		End Sub

		' Token: 0x06003F4F RID: 16207 RVA: 0x001B82CA File Offset: 0x001B64CA
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
		End Sub

		' Token: 0x06003F50 RID: 16208 RVA: 0x001B82CC File Offset: 0x001B64CC
		Friend Sub New(A_0 As DataRow)
			Dim a_ As Integer = 14
			MyBase..ctor()
			AddHandler MyBase.ControlAdded, AddressOf Me.o_.000OOOoo.
			AddHandler MyBase.FormClosing, AddressOf Me.o_.000OOOoo.
			AddHandler MyBase.KeyDown, AddressOf Me.o_.000OOOoo.
			AddHandler MyBase.Load, AddressOf Me.o__.0__.
			AddHandler MyBase.ResizeBegin, AddressOf Me.o.Ooo0__0.
			AddHandler MyBase.ResizeEnd, AddressOf Me.OO__oo0.0O___.
			Me.o_0O.OO0_0_. = New List(Of o\u3002\u3002\u3000\u3000\u3002.o_O)()
			Me.O0o._0. = New List(Of ControlHolder)()
			Me.o_0O.OO0_0_. = New Dictionary(Of String, Object)()
			Me.ooOOOO.0o. = New Dictionary(Of String, Object)()
			Me.O0o._0. = New Dictionary(Of String, PropertyBase)()
			Me.o_0O.OO0_0_. = New FormProperty(Me)
			Me.o_0O.OO0_0_. = New List(Of O_o_0o)()
			Me.oOO_0._000. = New List(Of ControlHolder)()
			Me.O0o._0. = O00OOOo_O0_O.b("꺛꺝", a_)
			Me.O__.o. = O00OOOo_O0_O.b("ꢛ", a_)
			Me.OO__oo0.0O___.()
			Me.o_0O.OO0_0_. = A_0
			o_O_o_oOoo__.OOOO_OO._oo.(Me.o_0O.OO0_0_., Me.o_0O.OO0_0_., False)
		End Sub

		' Token: 0x06003F51 RID: 16209 RVA: 0x001B83F4 File Offset: 0x001B65F4
		Friend Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Return Me.O0o._0.
		End Function

		' Token: 0x06003F52 RID: 16210 RVA: 0x001B83FC File Offset: 0x001B65FC
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			Me.O0o._0. = A_0
		End Sub

		' Token: 0x06003F53 RID: 16211 RVA: 0x001B8405 File Offset: 0x001B6605
		Friend Function <<EMPTY_NAME>>() As Integer Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Return Me.ooOOOO.0o.
		End Function

		' Token: 0x06003F54 RID: 16212 RVA: 0x001B840D File Offset: 0x001B660D
		Friend Sub <<EMPTY_NAME>>(A_0 As Integer) Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			Me.ooOOOO.0o. = A_0
		End Sub

		' Token: 0x06003F55 RID: 16213 RVA: 0x001B8416 File Offset: 0x001B6616
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.O0.o0O_o00_O.
			oOO0oo_o0.O00OO_O_oO_.o.(Me, MyBase.Controls)
		End Sub

		' Token: 0x06003F56 RID: 16214 RVA: 0x001B8424 File Offset: 0x001B6624
		Friend Sub <<EMPTY_NAME>>() Implements Foxtable.O0_0_0_0_.OOO_0_oo0.Oo0_.
			oOO0oo_o0.O._0O0__o.(MyBase.Controls)
		End Sub

		' Token: 0x06003F57 RID: 16215 RVA: 0x001B8431 File Offset: 0x001B6631
		Friend Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragEventArgs)
		End Sub

		' Token: 0x06003F58 RID: 16216 RVA: 0x001B8433 File Offset: 0x001B6633
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragEventArgs)
			If A_1.Data.GetDataPresent(GetType(TreeNode)) Then
				A_1.Effect = DragDropEffects.All
				Return
			End If
			A_1.Effect = DragDropEffects.None
		End Sub

		' Token: 0x06003F59 RID: 16217 RVA: 0x001B845F File Offset: 0x001B665F
		Private Sub <<EMPTY_NAME>>(A_0 As DataRow, A_1 As Control)
		End Sub

		' Token: 0x06003F5A RID: 16218 RVA: 0x001B8461 File Offset: 0x001B6661
		Friend Function <<EMPTY_NAME>>(A_0 As ControlTypeEnum, A_1 As Control, A_2 As Point, Optional A_3 As Boolean = True, Optional A_4 As DataRow = Nothing, Optional A_5 As Boolean = True) As PropertyBase
			Return Nothing
		End Function

		' Token: 0x06003F5B RID: 16219 RVA: 0x001B8464 File Offset: 0x001B6664
		Friend Function <<EMPTY_NAME>>(A_0 As String) As String
			Dim controlHolder As ControlHolder = Nothing
			Dim num As Integer
			While True
				num = 1
				Do
					Try
						Dim enumerator As List(Of ControlHolder).Enumerator = Me.O0o._0..GetEnumerator()
						While enumerator.MoveNext()
							controlHolder = enumerator.Current
							If Operators.CompareString(controlHolder.Name, A_0 + Conversions.ToString(num), True) = 0 Then
								Exit While
							End If
						End While
					Finally
						Dim enumerator As List(Of ControlHolder).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					If controlHolder Is Nothing OrElse Operators.CompareString(controlHolder.Name, A_0 + Conversions.ToString(num), True) <> 0 Then
						GoTo IL_6D
					End If
					num += 1
				Loop While num <= 2147483647
			End While
			IL_6D:
			Return A_0 + Conversions.ToString(num)
		End Function

		' Token: 0x06003F5C RID: 16220 RVA: 0x001B8514 File Offset: 0x001B6714
		Friend Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				Dim propertyGrid As PropertyGrid = CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.()
				IL_1A:
				num2 = 3
				Dim arrayList As ArrayList = New ArrayList()
				IL_23:
				num2 = 4
				arrayList.AddRange(propertyGrid.SelectedObjects)
				IL_32:
				num2 = 5
				If Not A_0.Selected Then
					GoTo IL_E4
				End If
				IL_3F:
				num2 = 6
				If arrayList.Contains(RuntimeHelpers.GetObjectValue(Me.o_0O.OO0_0_.(A_0.Key))) Then
					GoTo IL_126
				End If
				IL_63:
				num2 = 7
				arrayList.Add(RuntimeHelpers.GetObjectValue(Me.o_0O.OO0_0_.(A_0.Key)))
				IL_83:
				num2 = 8
				Dim enumerator As IEnumerator = arrayList.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim o_0oooo_OO As o_0oooo_OO = CType(obj, o_0oooo_OO)
					IL_9E:
					num2 = 9
					If o_0oooo_OO.Oo._o.() Is Me.o_0O.OO0_0_. Then
						IL_B0:
						num2 = 10
						arrayList.Remove(o_0oooo_OO)
						Exit While
					End If
					IL_BE:
					num2 = 12
				End While
				IL_CA:
				num2 = 13
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
					GoTo IL_126
				End If
				GoTo IL_126
				IL_E4:
				num2 = 15
				If Not arrayList.Contains(RuntimeHelpers.GetObjectValue(Me.o_0O.OO0_0_.(A_0.Key))) Then
					GoTo IL_126
				End If
				IL_106:
				num2 = 16
				arrayList.Remove(RuntimeHelpers.GetObjectValue(Me.o_0O.OO0_0_.(A_0.Key)))
				IL_126:
				num2 = 17
				If arrayList.Count <= 0 Then
					GoTo IL_145
				End If
				IL_133:
				num2 = 18
				propertyGrid.SelectedObjects = arrayList.ToArray()
				GoTo IL_14F
				IL_145:
				num2 = 20
				propertyGrid.SelectedObject = Nothing
				IL_14F:
				GoTo IL_1F5
				IL_154:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_1B6:
				GoTo IL_1EA
				IL_1B8:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1C8:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_1B8
			End Try
			IL_1EA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1F5:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003F5D RID: 16221 RVA: 0x001B873C File Offset: 0x001B693C
		Friend Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 2
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_09:
				ProjectData.ClearProjectError()
				num = 1
				IL_10:
				Dim num2 As Integer = 2
				Dim comboBox As ComboBox = New ComboBox()
				IL_18:
				num2 = 3
				Dim enumerator As List(Of ControlHolder).Enumerator = Me.O0o._0..GetEnumerator()
				While enumerator.MoveNext()
					Dim item As ControlHolder = enumerator.Current
					IL_32:
					num2 = 4
					comboBox.Items.Add(item)
					IL_42:
					num2 = 5
				End While
				IL_4D:
				num2 = 6
				CType(enumerator, IDisposable).Dispose()
				IL_5C:
				num2 = 7
				comboBox.DisplayMember = O00OOOo_O0_O.b("풏ﮑﮙ킝솟쾡솣", a_)
				IL_72:
				num2 = 8
				comboBox.Sorted = True
				IL_7B:
				num2 = 9
				Dim comboBox2 As ComboBox = CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.()
				IL_90:
				num2 = 10
				comboBox2.Items.Clear()
				IL_9F:
				num2 = 11
				comboBox2.Items.Add(Me)
				IL_B0:
				num2 = 12
				Dim num3 As Integer = comboBox.Items.Count - 1
				For i As Integer = 0 To num3
					IL_C7:
					num2 = 13
					comboBox2.Items.Add(RuntimeHelpers.GetObjectValue(comboBox.Items(i)))
					IL_E9:
					num2 = 14
				Next
				IL_F8:
				num2 = 15
				comboBox2.DisplayMember = O00OOOo_O0_O.b("풏ﮑﮙ킝솟쾡솣", a_)
				IL_110:
				comboBox2 = Nothing
				IL_113:
				GoTo IL_1A9
				IL_118:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_16A:
				GoTo IL_19E
				IL_16C:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_17C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_16C
			End Try
			IL_19E:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1A9:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003F5E RID: 16222 RVA: 0x001B8918 File Offset: 0x001B6B18
		Friend Sub <<EMPTY_NAME>>(A_0 As ControlHolder)
			CType(MyBase.MdiParent, o\u3000\u3002).O.oOO_.().Text = ""
			Dim comboBox As ComboBox = CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.()
			If A_0.Activated Then
				If comboBox.Items.Contains(A_0) Then
					comboBox.SelectedItem = A_0
				End If
				CType(MyBase.MdiParent, o\u3000\u3002).o_.OO000o___oo.().SelectedObject = RuntimeHelpers.GetObjectValue(Me.ooOOOO.0o.(A_0.Key))
			Else
				comboBox.SelectedItem = Nothing
				CType(MyBase.MdiParent, o\u3000\u3002).o_.OO000o___oo.().SelectedObject = Nothing
			End If
		End Sub

		' Token: 0x17000DB9 RID: 3513
		' (get) Token: 0x06003F5F RID: 16223 RVA: 0x001B89BC File Offset: 0x001B6BBC
		Public ReadOnly Property DisplayName As String
			Get
				Dim a_ As Integer = 0
				Return Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("삍ﾑ", a_)).ToString() + O00OOOo_O0_O.b("ꚍߵ燂붓", a_)
			End Get
		End Property

		' Token: 0x06003F60 RID: 16224 RVA: 0x001B8A03 File Offset: 0x001B6C03
		Friend Sub <<EMPTY_NAME>>()
		End Sub

		' Token: 0x06003F61 RID: 16225 RVA: 0x001B8A05 File Offset: 0x001B6C05
		Friend Sub <<EMPTY_NAME>>()
		End Sub

		' Token: 0x06003F62 RID: 16226 RVA: 0x001B8A08 File Offset: 0x001B6C08
		Friend Sub <<EMPTY_NAME>>()
			Dim a_ As Integer = 3
			MyBase.AutoScrollPosition = New Point(0, 0)
			Dim text As String = o_O_o_oOoo__.OOOO_OO._oo.(Me.o_0O.OO0_0_., True, vbVerticalTab, False)
			Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("손杖ﲘ", a_)) = o_O_o_oOoo__.OOOO_OO._oo.(Me.o_0O.OO0_0_., False, vbVerticalTab, False)
			If Operators.CompareString(text, "", True) > 0 Then
				Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("튐ﲒ", a_)) = O00.ooo000o_0.00o0.(text, ooO0__OO.O_Oo00oO.Ooo.(), ooO0__OO.O_Oo00oO.Ooo.())
			Else
				Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("튐ﲒ", a_)) = Nothing
			End If
			Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("얐ﮖﲘ", a_)) = Me.o_0O.OO0_0_..TablName
			Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("킐횘", a_)) = Me.o_0O.OO0_0_..AutoOpen
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is ControlHolder Then
						CType(control, ControlHolder).oO_O.0O__o.()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Dim array As DataRow() = Me.o_0O.OO0_0_..Table.[Select](O00OOOo_O0_O.b("햐璉ﺚ붜ꊞ膠힤튦첨", a_), "", DataViewRowState.CurrentRows)
			For i As Integer = array.Length - 1 To 0 Step -1
				Dim dataRow As DataRow = array(i)
				If dataRow.RowState <> DataRowState.Deleted AndAlso dataRow.RowState <> DataRowState.Detached AndAlso dataRow(O00OOOo_O0_O.b("햐璉ﺚ", a_)) IsNot DBNull.Value AndAlso Conversions.ToBoolean(dataRow(O00OOOo_O0_O.b("햐璉ﺚ", a_))) Then
					dataRow.Delete()
				End If
			Next
			Dim dataRow2 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("�", a_)).ToString(), o0_O.o_.0oO_0o000. })
			If dataRow2 IsNot Nothing Then
				dataRow2(O00OOOo_O0_O.b("튐ﲒﮔﲚ", a_)) = ""
				Oo00.O0Oo_O.0O_0O.(dataRow2)
			End If
			Dim oo_._oOo. As String = CType(MyBase.MdiParent, o\u3000\u3002).OO_._oOo.
			Dim dataRow3 As DataRow = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Find(New Object() { Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("�", a_)).ToString(), o0_O.oo0_.O0Oo_o. })
			If dataRow3 Is Nothing Then
				If Operators.CompareString(oo_._oOo., "", True) > 0 Then
					dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).NewRow()
					dataRow3(O00OOOo_O0_O.b("�", a_)) = Me.o_0O.OO0_0_.(O00OOOo_O0_O.b("�", a_)).ToString()
					dataRow3(O00OOOo_O0_O.b("얐", a_)) = o0_O.oo0_.O0Oo_o.
					dataRow3(O00OOOo_O0_O.b("튐ﲒﮔﲚ", a_)) = oo_._oOo.
					O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()).Rows.Add(dataRow3)
				End If
			Else
				dataRow3(O00OOOo_O0_O.b("튐ﲒﮔﲚ", a_)) = oo_._oOo.
			End If
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables(ooO0__OO.OOo0._00O_o00.()), True)
		End Sub

		' Token: 0x06003F63 RID: 16227 RVA: 0x001B8DBC File Offset: 0x001B6FBC
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Dim o___O_ As O___O_ = New O___O_(A_0)
			Me.oooo_._O.(MyBase.Controls, o___O_)
			If o___O_.Oo._o.() > 0 Then
				Me.o_0O.OO0_0_..Add(o___O_)
			End If
		End Sub

		' Token: 0x06003F64 RID: 16228 RVA: 0x001B8DF4 File Offset: 0x001B6FF4
		Friend Sub <<EMPTY_NAME>>(A_0 As Control.ControlCollection, A_1 As O___O_)
			Try
				For Each obj As Object In A_0
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is ControlHolder Then
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						If controlHolder.Selected Then
							A_1.o_0_.Oo.(Me.O0o._0.(controlHolder.Key))
						End If
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							Me.oooo_._O.(controlHolder.ChildControl.Controls, A_1)
						ElseIf controlHolder.ControlType = ControlTypeEnum.PictureBox Then
							Me.oooo_._O.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls, A_1)
						Else
							If controlHolder.ControlType = ControlTypeEnum.TabControl Then
								Try
									For Each obj2 As Object In CType(controlHolder.ChildControl, C1DockingTab).TabPages
										Dim o_O_ As O_O_ = CType(obj2, O_O_)
										Me.oooo_._O.(o_O_.Controls, A_1)
									Next
									Continue For
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.NavBar Then
								Try
									For Each obj3 As Object In CType(controlHolder.ChildControl, C1NavBar).Panels
										Dim oO_ As oO_0 = CType(obj3, oO_0)
										Me.oooo_._O.(oO_.Controls, A_1)
									Next
									Continue For
								Finally
									Dim enumerator3 As IEnumerator
									If TypeOf enumerator3 Is IDisposable Then
										TryCast(enumerator3, IDisposable).Dispose()
									End If
								End Try
							End If
							If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
								Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
								Me.oooo_._O.(o0000O.oo0oO_O.oooO0O.().Controls, A_1)
								Me.oooo_._O.(o0000O.o.Oo0oo000O.().Controls, A_1)
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06003F65 RID: 16229 RVA: 0x001B902C File Offset: 0x001B722C
		Friend Function <<EMPTY_NAME>>(A_0 As String) As O___O_
			Dim o___O_ As O___O_ = New O___O_(A_0)
			Me.oooo_._O.(MyBase.Controls, o___O_)
			Dim result As O___O_
			If o___O_.Oo._o.() > 0 Then
				result = o___O_
			Else
				result = Nothing
			End If
			Return result
		End Function

		' Token: 0x06003F66 RID: 16230 RVA: 0x001B9060 File Offset: 0x001B7260
		Friend Sub <<EMPTY_NAME>>()
			If Me.o_0O.OO0_0_..Count > 0 Then
				If Not(TypeOf Me.o_0O.OO0_0_.(Me.o_0O.OO0_0_..Count - 1)Is oO0_) Then
					oOO0oo_o0.o0.Oo__.(MyBase.Controls)
				End If
				Me.o_0O.OO0_0_.(Me.o_0O.OO0_0_..Count - 1).O_OO0.O.()
				Me.o_0O.OO0_0_..RemoveAt(Me.o_0O.OO0_0_..Count - 1)
			End If
		End Sub

		' Token: 0x06003F67 RID: 16231 RVA: 0x001B90DC File Offset: 0x001B72DC
		Friend Sub <<EMPTY_NAME>>()
			Dim ooo_0o As ooo_0o = New ooo_0o()
			Me.o_.000OOOoo.(MyBase.Controls, ooo_0o, False)
			If ooo_0o.ooO_O.O_O.() > 0 Then
				Me.o_0O.OO0_0_..Add(ooo_0o)
				Me.OOOoO.Oo_O0o_0.()
			End If
			CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.().SelectedIndex = 0
		End Sub

		' Token: 0x06003F68 RID: 16232 RVA: 0x001B912F File Offset: 0x001B732F
		Friend Overloads Sub <<EMPTY_NAME>>(A_0 As Control.ControlCollection, ByRef A_1 As ooo_0o, A_2 As Boolean)
		End Sub

		' Token: 0x06003F69 RID: 16233 RVA: 0x001B9134 File Offset: 0x001B7334
		Private Overloads Sub <<EMPTY_NAME>>(A_0 As Control.ControlCollection)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				For i As Integer = A_0.Count - 1 To 0 Step -1
					IL_18:
					num2 = 3
					Dim control As Control = A_0(i)
					IL_23:
					num2 = 4
					If TypeOf control Is ControlHolder Then
						IL_30:
						num2 = 5
						Dim controlHolder As ControlHolder = CType(control, ControlHolder)
						IL_3A:
						num2 = 6
						If controlHolder.ControlType = ControlTypeEnum.Panel Or controlHolder.ControlType = ControlTypeEnum.GroupBox Or controlHolder.ControlType = ControlTypeEnum.Gauges Or controlHolder.ControlType = ControlTypeEnum.Map Then
							IL_6D:
							num2 = 7
							Me.o_.000OOOoo.(controlHolder.ChildControl.Controls)
						Else
							IL_86:
							num2 = 9
							If controlHolder.ControlType = ControlTypeEnum.PictureBox Then
								IL_94:
								num2 = 10
								Me.o_.000OOOoo.(CType(controlHolder.ChildControl, CustomPictureBox).PictureBox1.Controls)
							Else
								IL_B8:
								num2 = 12
								If controlHolder.ControlType = ControlTypeEnum.TabControl Then
									IL_C6:
									num2 = 13
									Dim enumerator As IEnumerator = CType(controlHolder.ChildControl, C1DockingTab).TabPages.GetEnumerator()
									While enumerator.MoveNext()
										Dim obj As Object = enumerator.Current
										Dim o_O_ As O_O_ = CType(obj, O_O_)
										IL_F1:
										num2 = 14
										Me.o_.000OOOoo.(o_O_.Controls)
										IL_101:
										num2 = 15
									End While
									IL_10D:
									num2 = 16
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								Else
									IL_12D:
									num2 = 18
									If controlHolder.ControlType = ControlTypeEnum.NavBar Then
										IL_13B:
										num2 = 19
										Dim enumerator2 As IEnumerator = CType(controlHolder.ChildControl, C1NavBar).Panels.GetEnumerator()
										While enumerator2.MoveNext()
											Dim obj2 As Object = enumerator2.Current
											Dim oO_ As oO_0 = CType(obj2, oO_0)
											IL_166:
											num2 = 20
											Me.o_.000OOOoo.(oO_.Controls)
											IL_176:
											num2 = 21
										End While
										IL_182:
										num2 = 22
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									Else
										IL_19C:
										num2 = 24
										If controlHolder.ControlType = ControlTypeEnum.SplitContainer Then
											IL_1AA:
											num2 = 25
											Dim o0000O As o0000O = CType(controlHolder.ChildControl, o0000O)
											IL_1BB:
											num2 = 26
											Me.o_.000OOOoo.(o0000O.oo0oO_O.oooO0O.().Controls)
											IL_1D0:
											num2 = 27
											Me.o_.000OOOoo.(o0000O.o.Oo0oo000O.().Controls)
											IL_1E5:
											o0000O = Nothing
										End If
									End If
								End If
							End If
						End If
						IL_1E8:
						num2 = 29
						If controlHolder.Selected Then
							IL_1F4:
							num2 = 30
							controlHolder.Selected = False
						End If
						IL_1FF:
						num2 = 31
						If controlHolder.DataRow.RowState <> DataRowState.Deleted Then
							IL_211:
							num2 = 32
							controlHolder.DataRow.Delete()
						End If
						IL_220:
						num2 = 33
						Me.O0o._0..Remove(CType(control, ControlHolder))
						IL_235:
						num2 = 34
						Me.O0o._0..Remove(controlHolder.Key)
						IL_24B:
						num2 = 35
						Me.o_0O.OO0_0_..Remove(controlHolder.Key)
						IL_261:
						num2 = 36
						Me.ooOOOO.0o..Remove(controlHolder.Key)
						IL_277:
						num2 = 37
						A_0.Remove(control)
						IL_281:
						controlHolder = Nothing
					End If
					IL_284:
					num2 = 39
				Next
				IL_295:
				GoTo IL_387
				IL_29A:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_348:
				GoTo IL_37C
				IL_34A:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_35A:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_34A
			End Try
			IL_37C:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_387:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x06003F6A RID: 16234 RVA: 0x001B94EC File Offset: 0x001B76EC
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			Dim a_ As Integer = 3
			Me.O0o._0. = New O0oOO_(O00OOOo_O0_O.b("슐朗", a_), Me.o_0O.OO0_0_.)
		End Sub

		' Token: 0x06003F6B RID: 16235 RVA: 0x001B9521 File Offset: 0x001B7721
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.O0o._0. IsNot Nothing Then
				Me.o_0O.OO0_0_..Add(Me.O0o._0.)
				Me.O0o._0. = Nothing
				CType(MyBase.MdiParent, o\u3000\u3002).O0.0O00_O.().Refresh()
			End If
		End Sub

		' Token: 0x04001A25 RID: 6693
		Private <<EMPTY_NAME>> As IContainer

		' Token: 0x04001A26 RID: 6694
		Friend <<EMPTY_NAME>> As DataRow

		' Token: 0x04001A27 RID: 6695
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x04001A28 RID: 6696
		Private <<EMPTY_NAME>> As Point

		' Token: 0x04001A29 RID: 6697
		Private <<EMPTY_NAME>> As Rectangle

		' Token: 0x04001A2A RID: 6698
		Private <<EMPTY_NAME>> As List(Of o\u3002\u3002\u3000\u3000\u3002.o_O)

		' Token: 0x04001A2B RID: 6699
		Private <<EMPTY_NAME>> As Rectangle

		' Token: 0x04001A2C RID: 6700
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001A2D RID: 6701
		Private <<EMPTY_NAME>> As Integer

		' Token: 0x04001A2E RID: 6702
		Friend <<EMPTY_NAME>> As List(Of ControlHolder)

		' Token: 0x04001A2F RID: 6703
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Object)

		' Token: 0x04001A30 RID: 6704
		Friend <<EMPTY_NAME>> As Dictionary(Of String, Object)

		' Token: 0x04001A31 RID: 6705
		Friend <<EMPTY_NAME>> As Dictionary(Of String, PropertyBase)

		' Token: 0x04001A32 RID: 6706
		Friend <<EMPTY_NAME>> As FormProperty

		' Token: 0x04001A33 RID: 6707
		Friend <<EMPTY_NAME>> As List(Of O_o_0o)

		' Token: 0x04001A34 RID: 6708
		Friend <<EMPTY_NAME>> As List(Of ControlHolder)

		' Token: 0x04001A35 RID: 6709
		Private <<EMPTY_NAME>> As O0oOO_

		' Token: 0x04001A36 RID: 6710
		Private <<EMPTY_NAME>> As String

		' Token: 0x04001A37 RID: 6711
		Private <<EMPTY_NAME>> As String

		' Token: 0x020003EE RID: 1006
		Private Structure o_O
			' Token: 0x06003F6C RID: 16236 RVA: 0x001B9558 File Offset: 0x001B7758
			Friend Sub New(A_0 As Integer, A_1 As Integer, A_2 As Integer)
				Me = Nothing
				Me.O.00OO00_oo. = A_0
				Me.O0oOOo_o_O.O_O. = A_1
				Me.o.oo_OOO. = A_2
			End Sub

			' Token: 0x04001A38 RID: 6712
			Friend <<EMPTY_NAME>> As Integer

			' Token: 0x04001A39 RID: 6713
			Friend <<EMPTY_NAME>> As Integer

			' Token: 0x04001A3A RID: 6714
			Friend <<EMPTY_NAME>> As Integer
		End Structure
	End Class
End Namespace
