Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable
	' Token: 0x02000311 RID: 785
	<oO0oooo("0583")>
	<ComVisible(True)>
	Public Class ImageMap
		Inherits Dictionary(Of String, String)

		' Token: 0x06002ACC RID: 10956 RVA: 0x0012CE9F File Offset: 0x0012B09F
		Public Sub Add(Value As String, ImageFile As String)
			MyBase.Add(Value, ImageFile)
		End Sub

		' Token: 0x17000A16 RID: 2582
		' (get) Token: 0x06002ACD RID: 10957 RVA: 0x0012CEAC File Offset: 0x0012B0AC
		Friend ReadOnly Property ImageKeys As String
			Get
				Dim text As String = ""
				Try
					For Each str As String In MyBase.Keys
						If Operators.CompareString(text, "", True) > 0 Then
							text += "|"
						End If
						text += str
					Next
				Finally
					Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Return text
			End Get
		End Property

		' Token: 0x06002ACE RID: 10958 RVA: 0x0012CF24 File Offset: 0x0012B124
		<EditorBrowsable(EditorBrowsableState.Never)>
		Public Function <<EMPTY_NAME>>() As IDictionary
			Dim dictionary As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()
			Try
				For Each key As String In MyBase.Keys
					dictionary.Add(key, OO_00oOO.GetImage(MyBase(key)))
				Next
			Finally
				Dim enumerator As Dictionary(Of String, String).KeyCollection.Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
			Return dictionary
		End Function
	End Class
End Namespace
