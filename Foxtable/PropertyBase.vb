Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020002AF RID: 687
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class PropertyBase
		' Token: 0x06002472 RID: 9330 RVA: 0x000FA98D File Offset: 0x000F8B8D
		Friend Sub New(A_0 As ControlHolder)
			Me.o_0_.Oo. = A_0
		End Sub

		' Token: 0x17000875 RID: 2165
		' (get) Token: 0x06002473 RID: 9331 RVA: 0x000FA99C File Offset: 0x000F8B9C
		Friend ReadOnly Property Type As ControlTypeEnum
			Get
				Return Me.o_0_.Oo..ControlType
			End Get
		End Property

		' Token: 0x17000876 RID: 2166
		' (get) Token: 0x06002474 RID: 9332 RVA: 0x000FA9A9 File Offset: 0x000F8BA9
		' (set) Token: 0x06002475 RID: 9333 RVA: 0x000FA9B8 File Offset: 0x000F8BB8
		<MergableProperty(False)>
		<DisplayName("名称")>
		<Category("基本")>
		<O_Oo00Oo000O0(1.0)>
		Public Overridable Property Name As String
			Get
				Return Me.o_0_.Oo..Name
			End Get
			Set(value As String)
				If Operators.CompareString(value, Me.Name, True) <> 0 Then
					If Me.o_0_.Oo..FindForm() IsNot Nothing AndAlso Operators.CompareString(Me.o_0_.Oo..Name, "copyingtemp", True) <> 0 AndAlso CType(Me.o_0_.Oo..FindForm(), o\u3002\u3002\u3000\u3000\u3002).OO__oo0.0O___.(Me.o_0_.Oo..FindForm().Controls, value) Then
						MessageBox.Show("无效属性值，同名的对象已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Return
					End If
					Me.o_0_.Oo..Name = value
					Me.o_0_.Oo..DataRow("Name") = value
				End If
			End Set
		End Property

		' Token: 0x17000877 RID: 2167
		' (get) Token: 0x06002476 RID: 9334 RVA: 0x000FAA5A File Offset: 0x000F8C5A
		<Browsable(False)>
		Friend ReadOnly Property Holder As ControlHolder
			Get
				Return Me.o_0_.Oo.
			End Get
		End Property

		' Token: 0x17000878 RID: 2168
		' (get) Token: 0x06002477 RID: 9335 RVA: 0x000FAA62 File Offset: 0x000F8C62
		' (set) Token: 0x06002478 RID: 9336 RVA: 0x000FAA6F File Offset: 0x000F8C6F
		<Browsable(False)>
		<OooO0(True)>
		Public Property Size As Size
			Get
				Return Me.o_0_.Oo..Size
			End Get
			Set(value As Size)
				Me.o_0_.Oo..Size = value
			End Set
		End Property

		' Token: 0x17000879 RID: 2169
		' (get) Token: 0x06002479 RID: 9337 RVA: 0x000FAA7D File Offset: 0x000F8C7D
		' (set) Token: 0x0600247A RID: 9338 RVA: 0x000FAA8A File Offset: 0x000F8C8A
		<OooO0(True)>
		<Browsable(False)>
		Public Property Location As Point
			Get
				Return Me.o_0_.Oo..Location
			End Get
			Set(value As Point)
				Me.o_0_.Oo..Location = value
			End Set
		End Property

		' Token: 0x04000EFD RID: 3837
		Friend <<EMPTY_NAME>> As ControlHolder
	End Class
End Namespace
