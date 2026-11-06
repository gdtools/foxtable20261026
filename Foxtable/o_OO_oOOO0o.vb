Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Foxtable.WinForm
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020001A0 RID: 416
	Friend Class o_OO_oOOO0o
		Inherits System.Windows.Forms.ListView

		' Token: 0x060013A7 RID: 5031 RVA: 0x0007F174 File Offset: 0x0007D374
		Friend Sub New()
			AddHandler MyBase.DragDrop, AddressOf Me.Oo__o0OOOO_.__.
			AddHandler MyBase.DragEnter, AddressOf Me.o.0o0___.
			AddHandler MyBase.DragLeave, AddressOf Me.O_O.0Oo_o.
			AddHandler MyBase.DragOver, AddressOf Me.O_O.0Oo_o.
			AddHandler MyBase.DrawItem, AddressOf Me.O_O.0Oo_o.
			AddHandler MyBase.ItemDrag, AddressOf Me.O_O.0Oo_o.
			AddHandler MyBase.KeyDown, AddressOf Me.O_O.0Oo_o.
			AddHandler MyBase.MouseClick, AddressOf Me.O_O.0Oo_o.
			Me.DoubleBuffered = True
			MyBase.LargeImageList = New ImageList()
			MyBase.SmallImageList = New ImageList()
			MyBase.LargeImageList.ColorDepth = ColorDepth.Depth32Bit
			MyBase.SmallImageList.ColorDepth = ColorDepth.Depth32Bit
			MyBase.FullRowSelect = True
			MyBase.UseCompatibleStateImageBehavior = False
			MyBase.ShowItemToolTips = True
			MyBase.LargeImageList.ImageSize = New Size(48, 48)
			MyBase.SmallImageList.ImageSize = New Size(16, 16)
			MyBase.View = View.LargeIcon
			MyBase.HideSelection = False
			MyBase.InsertionMark.Color = Color.Green
			Me.set_AllowDrop(False)
			MyBase.OwnerDraw = False
		End Sub

		' Token: 0x060013A8 RID: 5032 RVA: 0x0007F2B8 File Offset: 0x0007D4B8
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.get_AllowDrop() Then
					GoTo IL_33E
				End If
				IL_14:
				num2 = 4
				Dim num3 As Integer = MyBase.InsertionMark.Index
				IL_22:
				num2 = 5
				Dim listViewItem As ListViewItem = CType(A_1.Data.GetData(GetType(ListViewItem)), ListViewItem)
				IL_40:
				num2 = 6
				If listViewItem Is Nothing Then
					GoTo IL_33E
				End If
				IL_49:
				num2 = 8
				If listViewItem.ListView IsNot Me Then
					GoTo IL_97
				End If
				IL_55:
				num2 = 9
				If MyBase.Items(MyBase.Items.Count - 1) IsNot listViewItem Then
					GoTo IL_8D
				End If
				IL_74:
				num2 = 10
				If num3 >= listViewItem.Index Then
					GoTo IL_33E
				End If
				If num3 < 0 Then
					GoTo IL_33E
				End If
				GoTo IL_97
				IL_8D:
				num2 = 13
				If num3 < 0 Then
					GoTo IL_33E
				End If
				IL_97:
				num2 = 15
				If num3 <> -1 OrElse MyBase.Items.Count <= 0 Then
					GoTo IL_FF
				End If
				IL_AC:
				num2 = 16
				Dim p As Point = System.Windows.Forms.Control.MousePosition
				IL_B6:
				num2 = 17
				p = MyBase.PointToClient(p)
				IL_C3:
				num2 = 18
				Dim itemAt As ListViewItem = MyBase.GetItemAt(p.X, p.Y)
				IL_DC:
				num2 = 19
				If itemAt Is Nothing Then
					GoTo IL_F0
				End If
				IL_E3:
				num2 = 20
				num3 = itemAt.Index
				GoTo IL_FF
				IL_F0:
				num2 = 22
				num3 = MyBase.Items.Count
				IL_FF:
				num2 = 23
				If num3 <> -1 OrElse MyBase.Items.Count <> 0 Then
					GoTo IL_125
				End If
				IL_113:
				num2 = 24
				If listViewItem.ListView Is Me Then
					GoTo IL_125
				End If
				IL_120:
				num2 = 25
				num3 = 0
				IL_125:
				num2 = 26
				If num3 = -1 Then
					GoTo IL_33E
				End If
				IL_12F:
				num2 = 28
				If Not MyBase.InsertionMark.AppearsAfterItem OrElse MyBase.Items.Count <= 0 Then
					GoTo IL_154
				End If
				IL_14D:
				num2 = 29
				num3 += 1
				IL_154:
				num2 = 30
				If listViewItem.Index >= num3 Then
					GoTo IL_168
				End If
				IL_161:
				num2 = 31
				num3 -= 1
				IL_168:
				num2 = 32
				Dim flag As Boolean = listViewItem.ListView Is Me
				IL_177:
				num2 = 33
				Dim form As Foxtable.WinForm.Form = Me.o0__o.O0.()
				IL_182:
				num2 = 34
				Dim listView As Foxtable.WinForm.ListView = New Foxtable.WinForm.ListView(Me)
				IL_18D:
				num2 = 35
				Dim a_ As Foxtable.WinForm.ListView = New Foxtable.WinForm.ListView(CType(listViewItem.ListView, o_OO_oOOO0o))
				IL_1A3:
				num2 = 36
				Dim dropListViewRowEventArgs As DropListViewRowEventArgs = New DropListViewRowEventArgs(Me, form, listViewItem.Index, num3, a_)
				IL_1BA:
				num2 = 37
				Dim a_2 As String = "BeforeDropRow_" + Conversions.ToString(MyBase.Tag)
				IL_1D4:
				num2 = 38
				O_O0OO.OoO_o.oO0o0O.(Me.o0__o.O0.().O_0.O00o_00_O., a_2, New Object() { dropListViewRowEventArgs }, False, "窗口," + form.Name + "," + listView.Name, False)
				IL_214:
				num2 = 39
				If Not dropListViewRowEventArgs.Cancel Then
					GoTo IL_234
				End If
				IL_220:
				num2 = 40
				MyBase.InsertionMark.Index = -1
				GoTo IL_33E
				IL_234:
				num2 = 42
				ShareLibriay.LockWindowUpdate(MyBase.Handle)
				IL_243:
				num2 = 43
				If Not flag Then
					GoTo IL_26B
				End If
				IL_24A:
				num2 = 44
				listViewItem.Remove()
				IL_254:
				num2 = 45
				MyBase.Items.Insert(num3, listViewItem)
				GoTo IL_2F7
				IL_26B:
				num2 = 47
				If Not dropListViewRowEventArgs.Delete Then
					GoTo IL_281
				End If
				IL_277:
				num2 = 48
				listViewItem.Remove()
				IL_281:
				num2 = 49
				If Not dropListViewRowEventArgs.Add Then
					GoTo IL_2F7
				End If
				IL_28D:
				num2 = 50
				If Not dropListViewRowEventArgs.Delete Then
					GoTo IL_2A2
				End If
				IL_299:
				num2 = 51
				Dim listViewItem2 As ListViewItem = listViewItem
				GoTo IL_2DA
				IL_2A2:
				num2 = 53
				listViewItem2 = CType(listViewItem.Clone(), ListViewItem)
				IL_2B3:
				num2 = 54
				listViewItem2.Name = listViewItem.Name
				IL_2C4:
				num2 = 55
				listViewItem2.Tag = RuntimeHelpers.GetObjectValue(listViewItem.Tag)
				IL_2DA:
				num2 = 56
				MyBase.Items.Insert(num3, listViewItem2)
				IL_2EC:
				num2 = 57
				listViewItem2.Selected = False
				IL_2F7:
				num2 = 58
				MyBase.InsertionMark.Index = -1
				IL_306:
				num2 = 59
				MyBase.Items(num3).Selected = True
				IL_31B:
				num2 = 60
				MyBase.Items(num3).Focused = True
				IL_330:
				num2 = 61
				ShareLibriay.LockWindowUpdate(IntPtr.Zero)
				IL_33E:
				GoTo IL_488
				IL_343:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_449:
				GoTo IL_47D
				IL_44B:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_45B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_44B
			End Try
			IL_47D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_488:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060013A9 RID: 5033 RVA: 0x0007F774 File Offset: 0x0007D974
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragEventArgs)
			If Me.get_AllowDrop() Then
				If CType(A_1.Data.GetData(GetType(ListViewItem)), ListViewItem) Is Nothing Then
					A_1.Effect = DragDropEffects.None
					Return
				End If
				A_1.Effect = A_1.AllowedEffect
			End If
		End Sub

		' Token: 0x060013AA RID: 5034 RVA: 0x0007F7AE File Offset: 0x0007D9AE
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As EventArgs)
			If Me.get_AllowDrop() Then
				MyBase.InsertionMark.Index = -1
			End If
		End Sub

		' Token: 0x060013AB RID: 5035 RVA: 0x0007F7C4 File Offset: 0x0007D9C4
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DragEventArgs)
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.get_AllowDrop() Then
					GoTo IL_D2
				End If
				IL_14:
				num2 = 4
				Dim listViewItem As ListViewItem = CType(A_1.Data.GetData(GetType(ListViewItem)), ListViewItem)
				IL_31:
				num2 = 5
				If listViewItem Is Nothing Then
					GoTo IL_D2
				End If
				IL_39:
				num2 = 7
				Dim pt As Point = MyBase.PointToClient(New Point(A_1.X, A_1.Y))
				IL_54:
				num2 = 8
				Dim num3 As Integer = MyBase.InsertionMark.NearestIndex(pt)
				IL_65:
				num2 = 9
				If num3 <= -1 Then
					GoTo IL_C2
				End If
				IL_6D:
				num2 = 10
				Dim itemRect As Rectangle = MyBase.GetItemRect(num3)
				IL_7A:
				num2 = 11
				If CDbl(pt.X) <= CDbl(itemRect.Left) + CDbl(itemRect.Width) / 2.0 Then
					GoTo IL_B3
				End If
				IL_A2:
				num2 = 12
				MyBase.InsertionMark.AppearsAfterItem = True
				GoTo IL_C2
				IL_B3:
				num2 = 14
				MyBase.InsertionMark.AppearsAfterItem = False
				IL_C2:
				num2 = 15
				MyBase.InsertionMark.Index = num3
				IL_D2:
				GoTo IL_164
				IL_D7:
				Dim num4 As Integer = num5 + 1
				num5 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4)
				IL_125:
				GoTo IL_159
				IL_127:
				num5 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_137:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_127
			End Try
			IL_159:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_164:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060013AC RID: 5036 RVA: 0x0007F95C File Offset: 0x0007DB5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As DrawListViewItemEventArgs)
			If A_1.Item.Focused Then
				A_1.DrawFocusRectangle()
			End If
		End Sub

		' Token: 0x060013AD RID: 5037 RVA: 0x0007F974 File Offset: 0x0007DB74
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As ItemDragEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not Me.O_O.0Oo_o.() Then
					GoTo IL_C9
				End If
				IL_14:
				num2 = 4
				Dim form As Foxtable.WinForm.Form = Me.o0__o.O0.()
				IL_1D:
				num2 = 5
				Dim listView As Foxtable.WinForm.ListView = New Foxtable.WinForm.ListView(Me)
				IL_27:
				num2 = 6
				Dim listViewItem As ListViewItem = CType(A_1.Item, ListViewItem)
				IL_36:
				num2 = 7
				Dim listViewRowEventArgs As ListViewRowEventArgs = New ListViewRowEventArgs(Me, form, New ListViewRow(listViewItem), listViewItem.Index)
				IL_4F:
				num2 = 8
				Dim a_ As String = "BeforeDragRow_" + Conversions.ToString(MyBase.Tag)
				IL_68:
				num2 = 9
				O_O0OO.OoO_o.oO0o0O.(Me.o0__o.O0.().O_0.O00o_00_O., a_, New Object() { listViewRowEventArgs }, False, "窗口," + form.Name + "," + listView.Name, False)
				IL_A7:
				num2 = 10
				If listViewRowEventArgs.Cancel Then
					GoTo IL_C9
				End If
				IL_B3:
				num2 = 11
				MyBase.DoDragDrop(RuntimeHelpers.GetObjectValue(A_1.Item), DragDropEffects.Move)
				IL_C9:
				GoTo IL_148
				IL_CB:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_109:
				GoTo IL_13D
				IL_10B:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_11B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10B
			End Try
			IL_13D:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_148:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060013AE RID: 5038 RVA: 0x0007FAF0 File Offset: 0x0007DCF0
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As KeyEventArgs)
			If MyBase.VirtualMode AndAlso MyBase.CheckBoxes AndAlso MyBase.SelectedIndices.Count > 0 Then
				Dim listViewItem As ListViewItem = MyBase.Items(MyBase.SelectedIndices(0))
				listViewItem.Checked = Not listViewItem.Checked
				MyBase.Invalidate(listViewItem.SubItems(0).Bounds)
			End If
		End Sub

		' Token: 0x060013AF RID: 5039 RVA: 0x0007FB5C File Offset: 0x0007DD5C
		Private Sub <<EMPTY_NAME>>(A_0 As Object, A_1 As MouseEventArgs)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Not MyBase.VirtualMode OrElse Not MyBase.CheckBoxes Then
					GoTo IL_7F
				End If
				IL_19:
				num2 = 3
				Dim itemAt As ListViewItem = MyBase.GetItemAt(A_1.X, A_1.Y)
				IL_2E:
				num2 = 4
				If itemAt Is Nothing Then
					GoTo IL_7F
				End If
				IL_33:
				num2 = 5
				If A_1.X >= itemAt.Bounds.Left + 16 Then
					GoTo IL_7F
				End If
				IL_4F:
				num2 = 6
				Dim checked As Boolean = itemAt.Checked
				IL_59:
				num2 = 7
				itemAt.Checked = Not checked
				IL_66:
				num2 = 8
				MyBase.Invalidate(itemAt.SubItems(0).Bounds)
				IL_7F:
				GoTo IL_F2
				IL_81:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_B3:
				GoTo IL_E7
				IL_B5:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_C5:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B5
			End Try
			IL_E7:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F2:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		' Token: 0x060013B0 RID: 5040 RVA: 0x0007FC74 File Offset: 0x0007DE74
		Friend Function <<EMPTY_NAME>>() As String
			Return Me.o0__o.O0.
		End Function

		' Token: 0x060013B1 RID: 5041 RVA: 0x0007FC7C File Offset: 0x0007DE7C
		Friend Sub <<EMPTY_NAME>>(A_0 As String)
			Me.o0__o.O0. = A_0
		End Sub

		' Token: 0x060013B2 RID: 5042 RVA: 0x0007FC85 File Offset: 0x0007DE85
		Friend Function <<EMPTY_NAME>>() As Boolean
			Return Me.o0__o.O0.
		End Function

		' Token: 0x060013B3 RID: 5043 RVA: 0x0007FC8D File Offset: 0x0007DE8D
		Friend Sub <<EMPTY_NAME>>(A_0 As Boolean)
			Me.o0__o.O0. = A_0
		End Sub

		' Token: 0x060013B4 RID: 5044 RVA: 0x0007FC96 File Offset: 0x0007DE96
		Public Overrides Function get_AllowDrop() As Boolean
			Return MyBase.AllowDrop
		End Function

		' Token: 0x060013B5 RID: 5045 RVA: 0x0007FC9E File Offset: 0x0007DE9E
		Public Overrides Sub set_AllowDrop(value As Boolean)
			MyBase.AllowDrop = value
			If value Then
				MyBase.ListViewItemSorter = New o_OO_oOOO0o.oOoo0_0oO0O()
				Return
			End If
			MyBase.ListViewItemSorter = Nothing
		End Sub

		' Token: 0x060013B6 RID: 5046 RVA: 0x0007FCC0 File Offset: 0x0007DEC0
		Private Function <<EMPTY_NAME>>() As Foxtable.WinForm.Form
			Dim parent As System.Windows.Forms.Control = MyBase.Parent
			While Not(TypeOf parent Is FormPanel)
				parent = parent.Parent
				If parent Is Nothing Then
					Return Nothing
				End If
			End While
			Return OO_00oOO.Forms(parent.Name)
		End Function

		' Token: 0x040007C0 RID: 1984
		Friend <<EMPTY_NAME>> As Dictionary(Of Integer, ListViewRow)

		' Token: 0x040007C1 RID: 1985
		Private <<EMPTY_NAME>> As String

		' Token: 0x040007C2 RID: 1986
		Private <<EMPTY_NAME>> As Boolean

		' Token: 0x020001A1 RID: 417
		Private Class oOoo0_0oO0O
			Implements IComparer

			' Token: 0x060013B8 RID: 5048 RVA: 0x0007FD04 File Offset: 0x0007DF04
			Public Function <<EMPTY_NAME>>(A_0 As Object, A_1 As Object) As Integer Implements System.Collections.IComparer.Compare
				Return CType(A_0, ListViewItem).Index - CType(A_1, ListViewItem).Index
			End Function
		End Class
	End Class
End Namespace
