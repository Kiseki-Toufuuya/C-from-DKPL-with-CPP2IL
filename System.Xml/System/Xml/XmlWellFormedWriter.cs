namespace System.Xml;

internal class XmlWellFormedWriter : XmlWriter
{
	[CompilerGenerated]
	private struct <_AdvanceStateAsync_ContinueWhenFinish>d__159 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		public State newState; //Field offset: 0x18
		public Token token; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_AdvanceStateAsync_ReturnWhenFinish>d__157 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		public State newState; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_SequenceRun>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public Func<Task> nextTaskFun; //Field offset: 0x14
		public XmlWellFormedWriter <>4__this; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_TryReturnTask>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartElementContentAsync_WithNS>d__161 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlWellFormedWriter <>4__this; //Field offset: 0x10
		private int <start>5__2; //Field offset: 0x14
		private int <i>5__3; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteBase64Async_NoAdvanceState>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		public Byte[] buffer; //Field offset: 0x18
		public int index; //Field offset: 0x1C
		public int count; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteCharEntityAsync>d__141 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public char ch; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteCharsAsync>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Char[] buffer; //Field offset: 0x10
		public int index; //Field offset: 0x14
		public int count; //Field offset: 0x18
		public XmlWellFormedWriter <>4__this; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteEndAttributeAsync_SepcialAtt>d__136 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlWellFormedWriter <>4__this; //Field offset: 0x10
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteEntityRefAsync>d__140 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string name; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawAsync>d__148 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Char[] buffer; //Field offset: 0x10
		public int index; //Field offset: 0x14
		public int count; //Field offset: 0x18
		public XmlWellFormedWriter <>4__this; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawAsync>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string data; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStartAttributeAsync_NoAdvanceState>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		public string prefix; //Field offset: 0x18
		public string localName; //Field offset: 0x1C
		public string namespaceName; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStartDocumentImplAsync>d__155 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlWellFormedWriter <>4__this; //Field offset: 0x10
		public XmlStandalone standalone; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStringAsync_NoAdvanceState>d__146 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		public string text; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteSurrogateCharEntityAsync>d__142 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public char highChar; //Field offset: 0x10
		public char lowChar; //Field offset: 0x12
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteWhitespaceAsync>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string ws; //Field offset: 0x10
		public XmlWellFormedWriter <>4__this; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class AttributeValueCache
	{
		[CompilerGenerated]
		private struct <ReplayAsync>d__24 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
			public AttributeValueCache <>4__this; //Field offset: 0x10
			public XmlWriter writer; //Field offset: 0x14
			private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18
			private int <i>5__2; //Field offset: 0x20

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private class BufferChunk
		{
			internal Char[] buffer; //Field offset: 0x8
			internal int index; //Field offset: 0xC
			internal int count; //Field offset: 0x10

			internal BufferChunk(Char[] buffer, int index, int count) { }

		}

		private class Item
		{
			internal ItemType type; //Field offset: 0x8
			internal object data; //Field offset: 0xC

			internal Item() { }

			internal void Set(ItemType type, object data) { }

		}

		private enum ItemType
		{
			EntityRef = 0,
			CharEntity = 1,
			SurrogateCharEntity = 2,
			Whitespace = 3,
			String = 4,
			StringChars = 5,
			Raw = 6,
			RawChars = 7,
			ValueString = 8,
		}

		private StringBuilder stringValue; //Field offset: 0x8
		private string singleStringValue; //Field offset: 0xC
		private Item[] items; //Field offset: 0x10
		private int firstItem; //Field offset: 0x14
		private int lastItem; //Field offset: 0x18

		internal string StringValue
		{
			internal get { } //Length: 51
		}

		public AttributeValueCache() { }

		private void AddItem(ItemType type, object data) { }

		internal void Clear() { }

		internal string get_StringValue() { }

		internal void Replay(XmlWriter writer) { }

		[AsyncStateMachine(typeof(<ReplayAsync>d__24))]
		internal Task ReplayAsync(XmlWriter writer) { }

		private void StartComplexValue() { }

		internal void Trim() { }

		internal void WriteCharEntity(char ch) { }

		internal void WriteChars(Char[] buffer, int index, int count) { }

		internal void WriteEntityRef(string name) { }

		internal void WriteRaw(Char[] buffer, int index, int count) { }

		internal void WriteRaw(string data) { }

		internal void WriteString(string text) { }

		internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

		internal void WriteValue(string value) { }

		internal void WriteWhitespace(string ws) { }

	}

	private struct AttrName
	{
		internal string prefix; //Field offset: 0x0
		internal string namespaceUri; //Field offset: 0x4
		internal string localName; //Field offset: 0x8
		internal int prev; //Field offset: 0xC

		internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

		internal void Set(string prefix, string localName, string namespaceUri) { }

	}

	private struct ElementScope
	{
		internal int prevNSTop; //Field offset: 0x0
		internal string prefix; //Field offset: 0x4
		internal string localName; //Field offset: 0x8
		internal string namespaceUri; //Field offset: 0xC
		internal XmlSpace xmlSpace; //Field offset: 0x10
		internal string xmlLang; //Field offset: 0x14

		internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

		internal void WriteEndElement(XmlRawWriter rawWriter) { }

		internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

	}

	private struct Namespace
	{
		[CompilerGenerated]
		private struct <WriteDeclAsync>d__6 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
			public XmlRawWriter rawWriter; //Field offset: 0x10
			public Namespace <>4__this; //Field offset: 0x14
			public XmlWriter writer; //Field offset: 0x24
			private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		internal string prefix; //Field offset: 0x0
		internal string namespaceUri; //Field offset: 0x4
		internal NamespaceKind kind; //Field offset: 0x8
		internal int prevNsIndex; //Field offset: 0xC

		internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

		internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

		[AsyncStateMachine(typeof(<WriteDeclAsync>d__6))]
		internal Task WriteDeclAsync(XmlWriter writer, XmlRawWriter rawWriter) { }

	}

	private enum NamespaceKind
	{
		Written = 0,
		NeedToWrite = 1,
		Implied = 2,
		Special = 3,
	}

	private class NamespaceResolverProxy : IXmlNamespaceResolver
	{
		private XmlWellFormedWriter wfWriter; //Field offset: 0x8

		internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter) { }

		private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

		private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

		private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	}

	private enum SpecialAttribute
	{
		No = 0,
		DefaultXmlns = 1,
		PrefixedXmlns = 2,
		XmlSpace = 3,
		XmlLang = 4,
	}

	private enum State
	{
		Start = 0,
		TopLevel = 1,
		Document = 2,
		Element = 3,
		Content = 4,
		B64Content = 5,
		B64Attribute = 6,
		AfterRootEle = 7,
		Attribute = 8,
		SpecialAttr = 9,
		EndDocument = 10,
		RootLevelAttr = 11,
		RootLevelSpecAttr = 12,
		RootLevelB64Attr = 13,
		AfterRootLevelAttr = 14,
		Closed = 15,
		Error = 16,
		StartContent = 101,
		StartContentEle = 102,
		StartContentB64 = 103,
		StartDoc = 104,
		StartDocEle = 106,
		EndAttrSEle = 107,
		EndAttrEEle = 108,
		EndAttrSCont = 109,
		EndAttrSAttr = 111,
		PostB64Cont = 112,
		PostB64Attr = 113,
		PostB64RootAttr = 114,
		StartFragEle = 115,
		StartFragCont = 116,
		StartFragB64 = 117,
		StartRootLevelAttr = 118,
	}

	private enum Token
	{
		StartDocument = 0,
		EndDocument = 1,
		PI = 2,
		Comment = 3,
		Dtd = 4,
		StartElement = 5,
		EndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Text = 9,
		CData = 10,
		AtomicValue = 11,
		Base64 = 12,
		RawData = 13,
		Whitespace = 14,
	}

	internal static readonly String[] stateName; //Field offset: 0x0
	internal static readonly String[] tokenName; //Field offset: 0x4
	private static WriteState[] state2WriteState; //Field offset: 0x8
	private static readonly State[] StateTableDocument; //Field offset: 0xC
	private static readonly State[] StateTableAuto; //Field offset: 0x10
	private XmlWriter writer; //Field offset: 0xC
	private XmlRawWriter rawWriter; //Field offset: 0x10
	private IXmlNamespaceResolver predefinedNamespaces; //Field offset: 0x14
	private Namespace[] nsStack; //Field offset: 0x18
	private int nsTop; //Field offset: 0x1C
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x20
	private bool useNsHashtable; //Field offset: 0x24
	private ElementScope[] elemScopeStack; //Field offset: 0x28
	private int elemTop; //Field offset: 0x2C
	private AttrName[] attrStack; //Field offset: 0x30
	private int attrCount; //Field offset: 0x34
	private Dictionary<String, Int32> attrHashTable; //Field offset: 0x38
	private SpecialAttribute specAttr; //Field offset: 0x3C
	private AttributeValueCache attrValueCache; //Field offset: 0x40
	private string curDeclPrefix; //Field offset: 0x44
	private State[] stateTable; //Field offset: 0x48
	private State currentState; //Field offset: 0x4C
	private bool checkCharacters; //Field offset: 0x50
	private bool omitDuplNamespaces; //Field offset: 0x51
	private bool writeEndDocumentOnClose; //Field offset: 0x52
	private ConformanceLevel conformanceLevel; //Field offset: 0x54
	private bool dtdWritten; //Field offset: 0x58
	private bool xmlDeclFollows; //Field offset: 0x59
	private XmlCharType xmlCharType; //Field offset: 0x5C
	private SecureStringHasher hasher; //Field offset: 0x60

	private bool InBase64
	{
		private get { } //Length: 31
	}

	private bool IsClosedOrErrorState
	{
		private get { } //Length: 15
	}

	internal XmlRawWriter RawWriter
	{
		internal get { } //Length: 11
	}

	private bool SaveAttrValue
	{
		private get { } //Length: 15
	}

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 114
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 110
	}

	public virtual string XmlLang
	{
		 get { } //Length: 86
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 82
	}

	[AsyncStateMachine(typeof(<_AdvanceStateAsync_ContinueWhenFinish>d__159))]
	private Task _AdvanceStateAsync_ContinueWhenFinish(Task task, State newState, Token token) { }

	[AsyncStateMachine(typeof(<_AdvanceStateAsync_ReturnWhenFinish>d__157))]
	private Task _AdvanceStateAsync_ReturnWhenFinish(Task task, State newState) { }

	[AsyncStateMachine(typeof(<_SequenceRun>d__120))]
	private Task _SequenceRun(Task task, Func<Task> nextTaskFun) { }

	[AsyncStateMachine(typeof(<_TryReturnTask>d__118))]
	private Task _TryReturnTask(Task task) { }

	private static XmlWellFormedWriter() { }

	internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings) { }

	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	private void AddToAttrHashTable(int attributeIndex) { }

	private void AddToNamespaceHashtable(int namespaceIndex) { }

	private void AdvanceState(Token token) { }

	private Task AdvanceStateAsync(Token token) { }

	private Task AdvanceStateAsync_ContinueWhenFinish(Task task, State newState, Token token) { }

	private Task AdvanceStateAsync_ReturnWhenFinish(Task task, State newState) { }

	private void CheckNCName(string ncname) { }

	public virtual void Close() { }

	private static XmlException DupAttrException(string prefix, string localName) { }

	public virtual void Flush() { }

	private string GeneratePrefix() { }

	private bool get_InBase64() { }

	private bool get_IsClosedOrErrorState() { }

	internal XmlRawWriter get_RawWriter() { }

	private bool get_SaveAttrValue() { }

	public virtual XmlWriterSettings get_Settings() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	private static string GetStateName(State state) { }

	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	private string LookupLocalNamespace(string prefix) { }

	internal string LookupNamespace(string prefix) { }

	private int LookupNamespaceIndex(string prefix) { }

	public virtual string LookupPrefix(string ns) { }

	private void PopNamespaces(int indexFrom, int indexTo) { }

	private bool PushNamespaceExplicit(string prefix, string ns) { }

	private void PushNamespaceImplicit(string prefix, string ns) { }

	private Task SequenceRun(Task task, Func<Task> nextTaskFun) { }

	private void SetSpecialAttribute(SpecialAttribute special) { }

	private void StartElementContent() { }

	private Task StartElementContentAsync() { }

	[AsyncStateMachine(typeof(<StartElementContentAsync_WithNS>d__161))]
	private Task StartElementContentAsync_WithNS() { }

	private void StartFragment() { }

	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	private Task TryReturnTask(Task task) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteBase64Async_NoAdvanceState>d__151))]
	private Task WriteBase64Async_NoAdvanceState(Task task, Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	[AsyncStateMachine(typeof(<WriteCharEntityAsync>d__141))]
	public virtual Task WriteCharEntityAsync(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteCharsAsync>d__147))]
	public virtual Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	protected private virtual Task WriteEndAttributeAsync() { }

	private Task WriteEndAttributeAsync_NoAdvance() { }

	[AsyncStateMachine(typeof(<WriteEndAttributeAsync_SepcialAtt>d__136))]
	private Task WriteEndAttributeAsync_SepcialAtt() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	[AsyncStateMachine(typeof(<WriteEntityRefAsync>d__140))]
	public virtual Task WriteEntityRefAsync(string name) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(string localName, string ns) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteRawAsync>d__149))]
	public virtual Task WriteRawAsync(string data) { }

	[AsyncStateMachine(typeof(<WriteRawAsync>d__148))]
	public virtual Task WriteRawAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	protected private virtual Task WriteStartAttributeAsync(string prefix, string localName, string namespaceName) { }

	private Task WriteStartAttributeAsync_NoAdvanceState(string prefix, string localName, string namespaceName) { }

	[AsyncStateMachine(typeof(<WriteStartAttributeAsync_NoAdvanceState>d__133))]
	private Task WriteStartAttributeAsync_NoAdvanceState(Task task, string prefix, string localName, string namespaceName) { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartDocument() { }

	public virtual Task WriteStartDocumentAsync() { }

	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	[AsyncStateMachine(typeof(<WriteStartDocumentImplAsync>d__155))]
	private Task WriteStartDocumentImplAsync(XmlStandalone standalone) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual Task WriteStringAsync(string text) { }

	private Task WriteStringAsync_NoAdvanceState(string text) { }

	[AsyncStateMachine(typeof(<WriteStringAsync_NoAdvanceState>d__146))]
	private Task WriteStringAsync_NoAdvanceState(Task task, string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[AsyncStateMachine(typeof(<WriteSurrogateCharEntityAsync>d__142))]
	public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteWhitespace(string ws) { }

	[AsyncStateMachine(typeof(<WriteWhitespaceAsync>d__143))]
	public virtual Task WriteWhitespaceAsync(string ws) { }

}

