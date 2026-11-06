# foxtable — Foxtable VB.NET Source
version: 2026.10.26.1   (Assembly 2026.10.26.01)

> **Foxtable** is a low-code Windows desktop development platform built with VB.NET on .NET Framework 4.7.2. This repository contains the original VB.NET source code.

## Overview

Foxtable enables rapid development of database-driven applications through a visual design surface, an in-memory tabular data engine with SQL-like query capabilities, a full-featured report generation suite, and a component library spanning both desktop WinForms and mobile web interfaces.

**Stats**: 1,554 files · 1,352 VB source files · 200 Designer files · 197 resource files

## What's New in 2026.10.26.1

- **LLMCaller** — a built-in, OpenAI-compatible LLM client. Foxtable scripts can now call chat-completion APIs directly, with multi-round **tool calling** (auto loop up to `MaxToolSteps`), **SSE streaming**, **reasoning-model** support (`reasoning_content` / `reasoning_effort`), full parameter surface (`temperature` … `verbosity`), message-history management and token estimation. See [LLM Client](#llm-client--llmcaller) below.
- **Actipro SyntaxEditor removed** — the SyntaxEditor-based code editor and its 5 ActiproSoftware DLL references were dropped from this build (~18 source files). Everything introduced in 2026.8.3.1 (AI Tools, WebViewer, JS bridge, mobile HTML/CSS layer) is retained.

---

## Architecture

Foxtable is organized into six core subsystems:

```
┌─────────────────────────────────────────────────────────┐
│                    Application Layer                      │
│  Main.vb  ·  ProjectProperty  ·  Process  ·  FormProperty │
├─────────────────────────────────────────────────────────┤
│                 UI Framework Layer                       │
│  WinForm/  (60+ desktop controls)                       │
│  RibbonMenu/  (ribbon UI framework)                      │
│  w*  (40+ mobile web components)                        │
├──────────────────────┬──────────────────────────────────┤
│   Data Layer         │       Report Engine              │
│  Table, DataTable,    │  Word/  ·  XLS/  ·  PrintDoc    │
│  DataCol, Connection  │  PDFCreator  ·  Report          │
├──────────────────────┼──────────────────────────────────┤
│  Visualization       │       Communication              │
│  Chart, Gantt, Map,   │  FTP/HTTP, IM, SMS, Email,      │
│  Gauge, BarCode       │  WeChat, UDP                    │
└──────────────────────┴──────────────────────────────────┘
```

---

## Core Subsystems

### Data Engine

The foundation of Foxtable — a full in-memory relational data engine with no external database dependency.

| Class | Role |
|-------|------|
| `Table` | Core data container; exposes SQL-like `Select`, `Filter`, `Sort`, `Group` |
| `DataTable` | In-memory table with `Compute`, expression columns, relations |
| `DataCol` / `DataRow` | Column and row abstractions with type validation |
| `Connection` | ADOX/ADODB connection management for Access, SQL Server, etc. |
| `QueryBuilder` | Visual query construction; supports joins, grouping, subtotals |
| `SQLCommand` | Direct SQL execution with parameterized queries |
| `BomTable` / `PriceTable` / `StockTable` / `YieldTable` | Domain-specific table templates |
| `Merger` | Table merge / union operations |

**Table Builders** — specialized query builders that generate structured results:

| Builder | Purpose |
|---------|---------|
| `GroupTableBuilder` / `SQLGroupTableBuilder` | Group rows with auto subtotals |
| `CrossTableBuilder` / `SQlCrossTableBuilder` | Pivot / cross-tabulation |
| `JoinTableBuilder` / `SQLJoinTableBuilder` | Multi-table inner/outer joins |
| `InlineGroupTableBuilder` / `InlineMRPBuilder` | Inline tree + MRP planning |
| `LayersMRPBuilder` / `LayersGroupTableBuilder` | Multi-level hierarchical tables |
| `OuterTableBuilder` | External/outer data source joins |

### UI Framework

Foxtable provides two UI layers: **Desktop (WinForms)** and **Mobile Web**.

#### Desktop Controls — `WinForm/`

60+ WinForm control wrappers that wrap C1 components with Foxtable's property system:

```
Layout      → Form, Panel, SplitContainer, TabControl, TabPage, NavBar, NavPage
             TopicBar, TopicPage, Strip, StripItem
Data        → Table, RecordGrid, ListView, TreeView, FilterTree, LoadTree
             LayersTree, InlineTree
Charts      → Chart (with ChartAxis, ChartSeries, ChartDataArray)
Gantt       → GanttView (with task bars, day painting, tooltips)
Visuals     → Gauges, Map, PictureBox, PictureViewer, WebBrowser
             BarCode, Painter, PDFViewer
Input       → TextBox, Button, CheckBox, ComboBox, ListBox, DateTimePicker
             NumericComboBox, DropDownBox, ColorPicker, FontPicker, TrackBar
Navigation  → ListViewColumn, ListViewRow, TreeNode, TreeNodes
             TopicLink, RecordGrid, ProgressBar, GroupBox
```

#### Ribbon UI — `RibbonMenu/`

A complete ribbon framework mirroring the Microsoft Office ribbon paradigm:

- **Tabs & Groups**: `RibbonTab`, `RibbonTopTab`, `RibbonGroup`, `RibbonMenuButton`
- **Items**: `RibbonButton`, `RibbonToggleButton`, `RibbonSplitButton`, `RibbonCheckBox`, `RibbonComboBox`, `RibbonTextBox`, `RibbonNumericBox`, `RibbonDatePicker`, `RibbonTimePicker`, `RibbonColorPicker`, `RibbonFontComboBox`, `RibbonGallery`, `RibbonProgressBar`
- **Accessories**: `StatusBar`, `RibbonQat` (Quick Access Toolbar), `RibbonSeparator`
- **Lists**: `RibbonTableViewList`, `RibbonWordReportList`, `RibbonExcelReportList`, `RibbonCodeReportList`, `RibbonCrossTableList`, `RibbonPaperList`, `RibbonWindowList`

#### Mobile Web UI — `w*` components

40+ components for mobile-first web application interfaces, all defined in `wui.vb`:

| Category | Components |
|----------|------------|
| **Layout** | `wPage`, `wPanel`, `wPanelGroup`, `wTable`, `wTableRow` |
| **Input** | `wInput`, `wTextArea`, `wSelect`, `wSwitch`, `wUploader`, `wVcodeButton` |
| **Display** | `wLabel`, `wImage`, `wGallery`, `wArticle`, `wProgress`, `wRawHtml` |
| **Navigation** | `wTabbar`, `wTabButton`, `wActionSheet`, `wActionMenu`, `wDialog` |
| **Feedback** | `wToast`, `wToptips`, `wMsgPage`, `wPreview` |
| **Selection** | `wCheck`, `wCheckGroup`, `wRadioGroup`, `wRadion`, `wButtonGroup` |
| **Data** | `wGrid`, `wGridCell`, `wDataList`, `wListGroup`, `wListIem`, `wRowCollection` |
| **Form** | `wForm`, `wInputGroup`, `wInputCell`, `wGroupTitle` |
| **WeChat** | `WeChatMessageReceived`, `WXBizCrypt`, `weMessageReceived` |

### Report Engine

| Module | Description |
|--------|-------------|
| `Word/Report`, `WordCreator`, `WordReport` | Word document report generation via Office Interop |
| `XLS/Report`, `XLS/Book`, `XLS/Sheet`, `XLS/Cell` | Excel spreadsheet creation with full formatting |
| `XLS/Style`, `XLS/AlignHorzEnum`, `XLS/LineStyleEnum` | Rich cell styling |
| `PDFCreator`, `PDFSource`, `PDFViewerProperty` | PDF generation and embedded viewing |
| `PrintDoc`, `PrintInfo`, `PrintPageProperty` | Direct print pipeline |

### Visualization

| Module | Description |
|--------|-------------|
| `ChartBuilder` | 2D charts (bar, line, pie) with histograms (`ChartHistogram`) |
| `GanttView` | Project Gantt with task bars, day painting, tooltips |
| `GaugesProperty` | Analog gauge controls with pointer drag events |
| `BarCodeBuilder` | 1D/2D barcode generation via BarcodeProfessional |
| `GeoMap` | Geographic map component with `GetMapTileEventArgs` |
| `ImageMap` | Static image overlay with hotspots |
| `CustomMarkShape`, `MarkImageShape`, `MarkTextShape` | Custom map overlay shapes |
| `VirtualLayer`, `VirtualTileSource` | Custom map tile layers (via `CustomTileSource`) |

### Communication

| Module | Description |
|--------|-------------|
| `FTPClient` | Full FTP with event-driven callbacks |
| `HttpClient`, `HttpListenter` | HTTP client and built-in HTTP listener/server |
| `IMServer`, `IMClient` | Peer-to-peer IM with buddy and user management |
| `MobileSMS`, `FoxSMSControl` | SMS via COM modem (JinDI) |
| `MobileEmail` | Email sending |
| `MobileURL`, `MobileCard`, `MobileText` | Mobile deep-link and card generation |
| `WeChatMessageReceived`, `WXBizCrypt` | WeChat Official Account message handling |
| `weMessageReceived` | WeChat Enterprise (WeCom) message handling |
| `WXBizMsgCrypt` | WeChat message encryption (native DLL) |
| `UDPClient` | UDP socket networking |
| `UDPClient_MessageReceived` | UDP receive event handler |

### Integration & Extensibility

| Module | Description |
|--------|-------------|
| `TSF.dll` | Text Services Framework for advanced input method support |
| `PY.vb` | Python script execution |
| `FoxFinger.vb` | DPFP biometric fingerprint SDK integration |
| `Camera.vb` | Hardware camera capture |
| `UKey.vb` | USB hardware key / dongle support |
| `MSScriptControl` | VBScript/JScript scripting |
| `ChinesFunctions` | Chinese character conversion utilities |

### Event System

160+ event argument classes following the `*EventArgs` naming convention. Key event categories:

- **Data**: `DataRowEventArgs`, `DataColEventArgs`, `CellClickEventArgs`, `DrawCellEventArgs`, `SortEventArgs`, `FilterEventArgs`
- **UI**: `ControlMouseEventArgs`, `ControlKeyEventArgs`, `BeforeShowContextMenuEventArgs`
- **Communication**: `Client_MessageEventargs`, `Server_MessageEventargs`, `FTPBeforeListDetailsEventArgs`
- **Reporting**: `PageHeaderEventArgs`, `PageFooterEventArgs`, `FormattingEventArgs`, `ChartMouseEventArgs`

### AI Tools

Built-in support for exposing Foxtable functionality to Large Language Models through the OpenAI-style **function-calling** schema. `AIToolBuilder` collects `AITool` definitions (each with a `Name`, `Description` and a list of `AIParameter`s) and serializes them to a `{"type":"function", ...}` JSON `tools` array via `Build()`.

| Class | Role |
|-------|------|
| `AITool` | A callable tool: `Name`, `Description`, `Parameters` (`List(Of AIParameter)`); `AddParameter(name, type, description, isRequired, arrayItemType, enumValues)` |
| `AIParameter` | One parameter: `Name`, `Type`, `Description`, `IsRequired`, `ArrayItemType`, `EnumValues` |
| `AIToolBuilder` | `Dictionary(Of String, AITool)`; `AddFunction(name, description)` → `AITool`; `Build()` → JSON tools array |

### LLM Client — `LLMCaller`

New in 2026.10.26.1 — a first-class client for **OpenAI-compatible chat-completion APIs**, built on Foxtable's own `HttpClient` stack. `LLMCaller` handles the full request/response cycle, including the multi-round **tool-call loop** and **SSE streaming**.

| Capability | Details |
|-----------|---------|
| Endpoint & auth | `BaseUrl`, `ApiKey` (auto-prefixes `Bearer `), `model`, custom `Headers` |
| Conversation | `Messages` (`JArray`), `SystemPrompt`, `UserMessage` (`String` or `JArray`), `PrefixContent` / `PrefixKey` assistant-prefix injection, `TrimMessages(n)` |
| History control | `KeepReasoningInHistory`, `KeepToolCallsInHistory` (default `True`) |
| Tool calling | `AddTool(name, description)` (backed by `AIToolBuilder`), `ToolExecutor` callback `Func(Of String, JObject, String)`, automatic tool-call loop up to `MaxToolSteps` (default 10), `tool_choice`, `parallel_tool_calls` |
| Streaming | `stream` + `SSEStreamHandler` (`Action(Of String, String)`), `GetResultAsync()`, `Cancel()` |
| Reasoning models | `Think` (`reasoning_content`), `reasoning_effort` |
| Parameters | `temperature`, `top_p`, `max_tokens`, `max_completion_tokens`, `n`, `seed`, `stop`, `presence_penalty`, `frequency_penalty`, `logprobs`, `top_logprobs`, `logit_bias`, `user`, `response_format`, `stream_options`, `service_tier`, `store`, `metadata`, `verbosity`, `extra_body` (`ExpandoObject`) |
| Results | `Result`, `ResultJObject`, `Error`, `GetRequestBody()` (debug) |
| Token estimation | `EstimateTokenCount(text, cnWeight:=0.6, enWeight:=0.3)` |

Usage sketch:

```vb
Dim llm As New Foxtable.LLMCaller("https://api.openai.com/v1", "gpt-4o", "sk-...")
llm.SystemPrompt = "You are a Foxtable assistant."
llm.UserMessage = "列出所有表"

Dim tool = llm.AddTool("list_tables", "列出项目中的所有表")
tool.AddParameter("pattern", "string", "表名过滤模式", False)

llm.ToolExecutor = Function(name As String, args As Newtonsoft.Json.Linq.JObject) As String
                       Return "Table1,Table2,..."   ' 执行工具并返回结果给模型
                   End Function

If llm.GetResult() Then
    MessageBox.Show(llm.Result)
Else
    MessageBox.Show(llm.Error)
End If
```

### WebView2 Embedded Browser

The legacy IE-based `WebBrowser` control is superseded by **`WebViewer`**, a wrapper around `Microsoft.Web.WebView2.WinForms.WebView2` — the modern Chromium engine. DevTools, Save-As, context menus and accelerator keys are enabled by default, and downloads are managed internally.

| Class | Role |
|-------|------|
| `WebViewer` / `WebViewerProperty` | Chromium embedded browser control + design properties |
| `WebMessageReceivedEventArgs` | Host ↔ page `postMessage` bridge |
| `WebResourceRequestedEventArgs` | Intercept / rewrite outgoing resource requests |
| `WebResourceResponseReceivedEventArgs` | Inspect completed responses |
| `NavigationStartingEventArgs` / `NavigationCompletedEventArgs` | Navigation lifecycle hooks |
| `NewWindowRequestedEventArgs` | Popup / new-window handling |
| `DOMContentLoadedEventArgs` | Page DOM-ready notification |

### JavaScript Bridge

`*Js` helper classes expose native Foxtable capabilities to JavaScript running inside `WebViewer`, so web UIs can drive the desktop runtime:

| Class | Bridge |
|-------|--------|
| `AudioJs` | Play / control audio from script |
| `ClipBoardJs` | Read / write the system clipboard |
| `MessageBoxForJs` | Show native message boxes |
| `SendkeysJs` | Dispatch keystrokes |
| `ColorDialogJs` · `FontDialogJs` · `FolderBrowserDialogForjs` · `OpenFileDialogForjs` · `SaveFileDialogForjs` | Native picker dialogs |
| `DataMapJs` | Map data between page and host |
| `PYJS` | Execute Python from script |
| `RibbonMenuJs` | Drive the ribbon from script |

> The mobile-web layer also gains CSS/HTML element abstractions — `CSSStyle` / `cssClassList` (style & class management), `HElement` / `wElement` (HTML element model) and `HStorage` (web storage).

---

## Technology Stack

- **Language**: VB.NET
- **Framework**: .NET Framework 4.7.2
- **Platform**: x86 / Windows
- **IDE**: Visual Studio 2017 (v15.0)

### Dependencies

| Library | Version | Purpose |
|---------|---------|---------|
| ComponentOne Studio for WinForms | v4 | FlexGrid, Ribbon, Chart, Gauge, GanttView, Schedule, Report, Excel, Word, PDF, Zip, Map, Sparkline, Sizer |
| Neodynamic BarcodeProfessional | — | 1D/2D barcode generation |
| Newtonsoft.Json | — | JSON serialization (also used by `LLMCaller`) |
| Microsoft.Web.WebView2 | — | Chromium-based embedded browser (`WebViewer` control) |
| DPFP SDK | — | Fingerprint biometrics |
| TSF (Text Services Framework) | — | Advanced input method support |
| WXBizMsgCrypt | — | WeChat message encryption |
| Foxtable.Lib | — | Native helper library |
| Office 2007 Renderer | — | Office 2007 visual style rendering |
| ADOX / ADODB | — | Database connectivity |

---

## Project Structure

```
foxtable20261026/
├── Foxtable.sln                       # Visual Studio 2017 solution
└── Foxtable/
    ├── Foxtable.vbproj                # Project file
    ├── LLMCaller.vb                   # OpenAI-compatible LLM client (new in 2026.10.26.1)
    ├── Main.vb                         # Application entry point
    ├── *.vb                            # Core source (~1,352 files)
    ├── C1/                             # ComponentOne embedded resources
    │   └── Win/C1GanttView/4.resx
    ├── My/                             # Application resources
    │   ├── Resources/                  # String tables, icons
    │   ├── a.vb / b.vb / c.vb / d.vb   # My.* namespace extensions
    │   └── MySettings.*                # Settings
    ├── My Project/
    │   └── AssemblyInfo.vb             # Assembly metadata
    ├── RibbonMenu/                     # Ribbon UI framework (40+ files)
    ├── Syscmd/                         # System command handlers
    │   ├── Column · Edit · Filter · GridTree · Project
    │   ├── Row · Sort · Table
    ├── WinForm/                        # Desktop control wrappers (60+ files)
    ├── Word/                           # Word report engine (4 files)
    ├── XLS/                            # Excel report engine (16 files)
    └── app.manifest                    # UAC and DPI settings
```

---

## Version History

| Version | Assembly | Framework | Highlights |
|---------|----------|-----------|------------|
| 2025.12.18.1 | 2025.12.18.01 | .NET 4.0 | Earlier snapshot (kept in the `Foxtable20251218/` folder of the 2026.8.3.1 repo) |
| 2026.8.3.1 | 2026.08.03.01 | .NET 4.7.2 | AI Tools (`AITool` schema), WebView2 `WebViewer`, `*Js` bridge, mobile HTML/CSS layer |
| **2026.10.26.1** | **2026.10.26.01** | .NET 4.7.2 | **`LLMCaller` LLM client** (tool calling + SSE streaming); Actipro SyntaxEditor removed |

To diff against the previous release, clone [gdtools/foxtable-20260803](https://github.com/gdtools/foxtable-20260803) and run a folder-diff tool or:

```
git diff --no-index foxtable-20260803/Foxtable foxtable20261026/Foxtable
```

Note: this build is obfuscated (Dotfuscator), so most type names appear as `O0oO*`-style identifiers; the meaningfully named classes listed above are the stable public surface.

---

## Requirements

- Windows 7 or later
- .NET Framework 4.7.2
- Microsoft Edge WebView2 Runtime (required by the `WebViewer` control)
- Visual Studio 2017 or later (for development)
- ComponentOne Studio for WinForms v4 (referenced DLLs)

## License

Proprietary. All rights reserved.

## Related Repositories

| Repo | Description |
|------|-------------|
| [gdtools/foxtable-20260803](https://github.com/gdtools/foxtable-20260803) | Previous source snapshot (2026.8.3.1, also contains the 2025.12.18.1 tree) |
| [gdtools/foxtable_pro](https://github.com/gdtools/foxtable_pro) | Foxtable Pro — enhancement plugin system with Git version control and VS code generation |
| [gdtools/foxtable_docs_20260812](https://github.com/gdtools/foxtable_docs_20260812) | Foxtable development documentation and specifications |
| [gdtools/foxai20260803](https://github.com/gdtools/foxai20260803) | Foxtable development documentation |
