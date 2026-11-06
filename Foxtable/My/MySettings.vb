Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Foxtable.My
	' Token: 0x02000542 RID: 1346
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")>
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x17001538 RID: 5432
		' (get) Token: 0x06005924 RID: 22820 RVA: 0x00230BD3 File Offset: 0x0022EDD3
		' (set) Token: 0x06005925 RID: 22821 RVA: 0x00230BE5 File Offset: 0x0022EDE5
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		Public Property LastDate As DateTime
			Get
				Return Conversions.ToDate(Me("LastDate"))
			End Get
			Set(value As DateTime)
				Me("LastDate") = value
			End Set
		End Property

		' Token: 0x17001539 RID: 5433
		' (get) Token: 0x06005926 RID: 22822 RVA: 0x00230BF8 File Offset: 0x0022EDF8
		' (set) Token: 0x06005927 RID: 22823 RVA: 0x00230C0A File Offset: 0x0022EE0A
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		Public Property Count As Integer
			Get
				Return Conversions.ToInteger(Me("Count"))
			End Get
			Set(value As Integer)
				Me("Count") = value
			End Set
		End Property

		' Token: 0x1700153A RID: 5434
		' (get) Token: 0x06005928 RID: 22824 RVA: 0x00230C1D File Offset: 0x0022EE1D
		' (set) Token: 0x06005929 RID: 22825 RVA: 0x00230C2F File Offset: 0x0022EE2F
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		Public Property LoadDate As DateTime
			Get
				Return Conversions.ToDate(Me("LoadDate"))
			End Get
			Set(value As DateTime)
				Me("LoadDate") = value
			End Set
		End Property

		' Token: 0x1700153B RID: 5435
		' (get) Token: 0x0600592A RID: 22826 RVA: 0x00230C42 File Offset: 0x0022EE42
		' (set) Token: 0x0600592B RID: 22827 RVA: 0x00230C54 File Offset: 0x0022EE54
		<DebuggerNonUserCode()>
		<UserScopedSetting()>
		Public Property LoadCount As Integer
			Get
				Return Conversions.ToInteger(Me("LoadCount"))
			End Get
			Set(value As Integer)
				Me("LoadCount") = value
			End Set
		End Property
	End Class
End Namespace
