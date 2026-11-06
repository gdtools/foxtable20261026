Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x020003FF RID: 1023
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Class CustomTreeNodeProperty
		' Token: 0x0600427A RID: 17018 RVA: 0x001C1054 File Offset: 0x001BF254
		Friend Sub New(A_0 As O_o__00Ooo)
			Me.o0Ooo_O0oo.O__. = A_0
		End Sub

		' Token: 0x17000E93 RID: 3731
		' (get) Token: 0x0600427B RID: 17019 RVA: 0x001C1063 File Offset: 0x001BF263
		' (set) Token: 0x0600427C RID: 17020 RVA: 0x001C1070 File Offset: 0x001BF270
		<DefaultValue("")>
		Public Property Name As String
			Get
				Return Me.o0Ooo_O0oo.O__..Name
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..Name = value
			End Set
		End Property

		' Token: 0x17000E94 RID: 3732
		' (get) Token: 0x0600427D RID: 17021 RVA: 0x001C1080 File Offset: 0x001BF280
		' (set) Token: 0x0600427E RID: 17022 RVA: 0x001C10A6 File Offset: 0x001BF2A6
		<DefaultValue("")>
		Public Property Text As String
			Get
				Dim result As String
				If Me.o0Ooo_O0oo.O__. Is Nothing Then
					result = Nothing
				Else
					result = Me.o0Ooo_O0oo.O__..Text
				End If
				Return result
			End Get
			Set(value As String)
				If Me.o0Ooo_O0oo.O__. IsNot Nothing Then
					Me.o0Ooo_O0oo.O__..Text = value
				End If
			End Set
		End Property

		' Token: 0x17000E95 RID: 3733
		' (get) Token: 0x0600427F RID: 17023 RVA: 0x001C10BC File Offset: 0x001BF2BC
		' (set) Token: 0x06004280 RID: 17024 RVA: 0x001C10C9 File Offset: 0x001BF2C9
		<DefaultValue("")>
		Public Property Tooltip As String
			Get
				Return Me.o0Ooo_O0oo.O__..ToolTipText
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..ToolTipText = value
			End Set
		End Property

		' Token: 0x17000E96 RID: 3734
		' (get) Token: 0x06004281 RID: 17025 RVA: 0x001C10D7 File Offset: 0x001BF2D7
		' (set) Token: 0x06004282 RID: 17026 RVA: 0x001C10E4 File Offset: 0x001BF2E4
		Public Property ImageFile As String
			Get
				Return Me.o0Ooo_O0oo.O__..ImageFile
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..ImageFile = value
			End Set
		End Property

		' Token: 0x17000E97 RID: 3735
		' (get) Token: 0x06004283 RID: 17027 RVA: 0x001C10F2 File Offset: 0x001BF2F2
		' (set) Token: 0x06004284 RID: 17028 RVA: 0x001C10FF File Offset: 0x001BF2FF
		Public Property NodeSelectedImageFile As String
			Get
				Return Me.o0Ooo_O0oo.O__..o0Ooo_O0oo.O__.()
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..O.OOO_.(value)
			End Set
		End Property

		' Token: 0x17000E98 RID: 3736
		' (get) Token: 0x06004285 RID: 17029 RVA: 0x001C110D File Offset: 0x001BF30D
		' (set) Token: 0x06004286 RID: 17030 RVA: 0x001C111A File Offset: 0x001BF31A
		Public Property Backcolor As Color
			Get
				Return Me.o0Ooo_O0oo.O__..BackColor
			End Get
			Set(value As Color)
				If Operators.CompareString(value.Name, "0", True) <> 0 Then
					Me.o0Ooo_O0oo.O__..BackColor = value
				End If
			End Set
		End Property

		' Token: 0x17000E99 RID: 3737
		' (get) Token: 0x06004287 RID: 17031 RVA: 0x001C113C File Offset: 0x001BF33C
		' (set) Token: 0x06004288 RID: 17032 RVA: 0x001C1149 File Offset: 0x001BF349
		Public Property ForeColor As Color
			Get
				Return Me.o0Ooo_O0oo.O__..ForeColor
			End Get
			Set(value As Color)
				If Operators.CompareString(value.Name, "0", True) <> 0 Then
					Me.o0Ooo_O0oo.O__..ForeColor = value
				End If
			End Set
		End Property

		' Token: 0x17000E9A RID: 3738
		' (get) Token: 0x06004289 RID: 17033 RVA: 0x001C116C File Offset: 0x001BF36C
		' (set) Token: 0x0600428A RID: 17034 RVA: 0x001C11A0 File Offset: 0x001BF3A0
		<DefaultValue("")>
		Public Property Tag As String
			Get
				Dim result As String
				If Me.o0Ooo_O0oo.O__..Tag Is Nothing Then
					result = ""
				Else
					result = Me.o0Ooo_O0oo.O__..Tag.ToString()
				End If
				Return result
			End Get
			Set(value As String)
				Me.o0Ooo_O0oo.O__..Tag = value
			End Set
		End Property

		' Token: 0x17000E9B RID: 3739
		' (get) Token: 0x0600428B RID: 17035 RVA: 0x001C11AE File Offset: 0x001BF3AE
		' (set) Token: 0x0600428C RID: 17036 RVA: 0x001C11BB File Offset: 0x001BF3BB
		<DefaultValue(False)>
		Public Property Checked As Boolean
			Get
				Return Me.o0Ooo_O0oo.O__..Checked
			End Get
			Set(value As Boolean)
				Me.o0Ooo_O0oo.O__..Checked = value
			End Set
		End Property

		' Token: 0x04001B3A RID: 6970
		Friend <<EMPTY_NAME>> As O_o__00Ooo
	End Class
End Namespace
