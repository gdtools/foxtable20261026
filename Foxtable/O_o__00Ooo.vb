Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x0200039A RID: 922
	Friend Class O_o__00Ooo
		Inherits TreeNode

		' Token: 0x17000CD3 RID: 3283
		' (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00196CB7 File Offset: 0x00194EB7
		' (set) Token: 0x06003AC3 RID: 15043 RVA: 0x00196CC0 File Offset: 0x00194EC0
		Public Property ImageFile As String
			Get
				Return Me.o0Ooo_O0oo.O__.
			End Get
			Set(value As String)
				If Operators.CompareString(MyBase.SelectedImageKey, MyBase.ImageKey, True) = 0 AndAlso Operators.CompareString(Me.O.OOO_., "", True) = 0 Then
					MyBase.SelectedImageKey = ""
				End If
				MyBase.ImageKey = ""
				If Operators.CompareString(Me.o0Ooo_O0oo.O__., value, True) <> 0 AndAlso Operators.CompareString(Me.o0Ooo_O0oo.O__., "", True) > 0 AndAlso Not oOO0oo_o0.o.O0o000_.(MyBase.TreeView, MyBase.TreeView.Nodes, Me.o0Ooo_O0oo.O__.) Then
					MyBase.TreeView.ImageList.Images.RemoveByKey(Me.ImageFile)
				End If
				Me.o0Ooo_O0oo.O__. = value
				Me.o0Ooo_O0oo.O__.()
			End Set
		End Property

		' Token: 0x06003AC4 RID: 15044 RVA: 0x00196D73 File Offset: 0x00194F73
		Public Function <<EMPTY_NAME>>() As String
			Return Me.O.OOO_.
		End Function

		' Token: 0x06003AC5 RID: 15045 RVA: 0x00196D7C File Offset: 0x00194F7C
		Public Sub <<EMPTY_NAME>>(A_0 As String)
			If Operators.CompareString(MyBase.ImageKey, MyBase.SelectedImageKey, True) = 0 AndAlso Operators.CompareString(Me.o0Ooo_O0oo.O__., "", True) = 0 Then
				MyBase.ImageKey = ""
			End If
			MyBase.SelectedImageKey = ""
			If Operators.CompareString(Me.O.OOO_., A_0, True) <> 0 AndAlso Operators.CompareString(Me.O.OOO_., "", True) > 0 AndAlso Not oOO0oo_o0.o.O0o000_.(MyBase.TreeView, MyBase.TreeView.Nodes, Me.O.OOO_.) Then
				MyBase.TreeView.ImageList.Images.RemoveByKey(Me.o0Ooo_O0oo.O__.())
			End If
			Me.O.OOO_. = A_0
			Me.o0Ooo_O0oo.O__.()
		End Sub

		' Token: 0x06003AC6 RID: 15046 RVA: 0x00196E30 File Offset: 0x00195030
		Private Sub <<EMPTY_NAME>>()
			If Operators.CompareString(Me.ImageFile, "", True) > 0 OrElse Operators.CompareString(Me.o0Ooo_O0oo.O__.(), "", True) > 0 Then
				Dim imageList As ImageList
				If MyBase.TreeView.ImageList Is Nothing Then
					imageList = New ImageList()
					MyBase.TreeView.ImageList = imageList
				Else
					imageList = MyBase.TreeView.ImageList
				End If
				If Operators.CompareString(Me.ImageFile, "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.ImageFile) Then
					Dim image As Image = OO_00oOO.GetImage(Me.ImageFile)
					If image IsNot Nothing Then
						imageList.Images.Add(Me.ImageFile, image)
					End If
				End If
				If Operators.CompareString(Me.o0Ooo_O0oo.O__.(), "", True) > 0 AndAlso Not imageList.Images.Keys.Contains(Me.o0Ooo_O0oo.O__.()) Then
					Dim image2 As Image = OO_00oOO.GetImage(Me.o0Ooo_O0oo.O__.())
					If image2 IsNot Nothing Then
						imageList.Images.Add(Me.o0Ooo_O0oo.O__.(), image2)
					End If
				End If
				If Operators.CompareString(Me.ImageFile, "", True) > 0 Then
					MyBase.ImageKey = Me.ImageFile
				ElseIf Operators.CompareString(Me.o0Ooo_O0oo.O__.(), "", True) > 0 Then
					MyBase.ImageKey = Me.o0Ooo_O0oo.O__.()
				Else
					MyBase.ImageKey = String.Empty
				End If
				If Operators.CompareString(Me.o0Ooo_O0oo.O__.(), "", True) > 0 Then
					MyBase.SelectedImageKey = Me.o0Ooo_O0oo.O__.()
				ElseIf Operators.CompareString(Me.ImageFile, "", True) > 0 Then
					MyBase.SelectedImageKey = Me.ImageFile
				Else
					MyBase.SelectedImageKey = String.Empty
				End If
				If MyBase.TreeView.ImageList IsNot Nothing AndAlso MyBase.TreeView.ImageList.Images.Count = 0 Then
					MyBase.TreeView.ImageList = Nothing
				End If
			Else
				MyBase.ImageKey = String.Empty
				MyBase.SelectedImageKey = String.Empty
				If MyBase.TreeView.ImageList IsNot Nothing AndAlso MyBase.TreeView.ImageList.Images.Count = 0 Then
					MyBase.TreeView.ImageList = Nothing
					Return
				End If
			End If
		End Sub

		' Token: 0x04001839 RID: 6201
		Private <<EMPTY_NAME>> As String

		' Token: 0x0400183A RID: 6202
		Private <<EMPTY_NAME>> As String
	End Class
End Namespace
