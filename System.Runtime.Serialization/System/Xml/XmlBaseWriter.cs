namespace System.Xml;

internal abstract class XmlBaseWriter : XmlDictionaryWriter, IFragmentCapableXmlDictionaryWriter
{
	private enum DocumentState
	{
		None = 0,
		Document = 1,
		Epilog = 2,
		End = 3,
	}

	private class Element
	{
		private string prefix; //Field offset: 0x8
		private string localName; //Field offset: 0xC
		private int prefixId; //Field offset: 0x10

		public string LocalName
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string Prefix
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public int PrefixId
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public Element() { }

		public void Clear() { }

		public string get_LocalName() { }

		public string get_Prefix() { }

		public int get_PrefixId() { }

		public void set_LocalName(string value) { }

		public void set_Prefix(string value) { }

		public void set_PrefixId(int value) { }

	}

	private class NamespaceManager
	{
		private class Namespace
		{
			private string prefix; //Field offset: 0x8
			private string ns; //Field offset: 0xC
			private XmlDictionaryString xNs; //Field offset: 0x10
			private int depth; //Field offset: 0x14
			private char prefixChar; //Field offset: 0x18

			public int Depth
			{
				 get { } //Length: 11
				 set { } //Length: 14
			}

			public string Prefix
			{
				 get { } //Length: 11
				 set { } //Length: 68
			}

			public char PrefixChar
			{
				 get { } //Length: 12
			}

			public string Uri
			{
				 get { } //Length: 11
				 set { } //Length: 27
			}

			public XmlDictionaryString UriDictionaryString
			{
				 get { } //Length: 11
				 set { } //Length: 27
			}

			public Namespace() { }

			public void Clear() { }

			public int get_Depth() { }

			public string get_Prefix() { }

			public char get_PrefixChar() { }

			public string get_Uri() { }

			public XmlDictionaryString get_UriDictionaryString() { }

			public void set_Depth(int value) { }

			public void set_Prefix(string value) { }

			public void set_Uri(string value) { }

			public void set_UriDictionaryString(XmlDictionaryString value) { }

		}

		private class XmlAttribute
		{
			private XmlSpace space; //Field offset: 0x8
			private string lang; //Field offset: 0xC
			private int depth; //Field offset: 0x10

			public int Depth
			{
				 get { } //Length: 11
				 set { } //Length: 14
			}

			public string XmlLang
			{
				 get { } //Length: 11
				 set { } //Length: 27
			}

			public XmlSpace XmlSpace
			{
				 get { } //Length: 11
				 set { } //Length: 14
			}

			public XmlAttribute() { }

			public void Clear() { }

			public int get_Depth() { }

			public string get_XmlLang() { }

			public XmlSpace get_XmlSpace() { }

			public void set_Depth(int value) { }

			public void set_XmlLang(string value) { }

			public void set_XmlSpace(XmlSpace value) { }

		}

		private Namespace[] namespaces; //Field offset: 0x8
		private Namespace lastNameSpace; //Field offset: 0xC
		private int nsCount; //Field offset: 0x10
		private int depth; //Field offset: 0x14
		private XmlAttribute[] attributes; //Field offset: 0x18
		private int attributeCount; //Field offset: 0x1C
		private XmlSpace space; //Field offset: 0x20
		private string lang; //Field offset: 0x24
		private int namespaceBoundary; //Field offset: 0x28
		private int nsTop; //Field offset: 0x2C
		private Namespace defaultNamespace; //Field offset: 0x30

		public int NamespaceBoundary
		{
			 get { } //Length: 11
			 set { } //Length: 99
		}

		public string XmlLang
		{
			 get { } //Length: 11
		}

		public XmlSpace XmlSpace
		{
			 get { } //Length: 11
		}

		public NamespaceManager() { }

		private void AddAttribute() { }

		public void AddLangAttribute(string lang) { }

		public void AddNamespace(string prefix, string uri, XmlDictionaryString uriDictionaryString) { }

		public string AddNamespace(string uri, XmlDictionaryString uriDictionaryString) { }

		public void AddNamespaceIfNotDeclared(string prefix, string uri, XmlDictionaryString uriDictionaryString) { }

		public void AddSpaceAttribute(XmlSpace space) { }

		public void Clear() { }

		public void Close() { }

		public void DeclareNamespaces(XmlNodeWriter writer) { }

		public void EnterScope() { }

		public void ExitScope() { }

		public int get_NamespaceBoundary() { }

		public string get_XmlLang() { }

		public XmlSpace get_XmlSpace() { }

		public string LookupAttributePrefix(string ns) { }

		public string LookupNamespace(string prefix) { }

		public string LookupPrefix(string ns) { }

		public void set_NamespaceBoundary(int value) { }

		public void Sign(XmlCanonicalWriter signingWriter) { }

	}

	private class WriteBase64AsyncResult : AsyncResult
	{
		private static AsyncCompletion onComplete; //Field offset: 0x0
		private XmlBaseWriter writer; //Field offset: 0x38
		private Byte[] buffer; //Field offset: 0x3C
		private int offset; //Field offset: 0x40
		private int count; //Field offset: 0x44
		private int actualByteCount; //Field offset: 0x48
		private int totalByteCount; //Field offset: 0x4C

		private static WriteBase64AsyncResult() { }

		public WriteBase64AsyncResult(Byte[] buffer, int offset, int count, XmlBaseWriter writer, AsyncCallback callback, object state) { }

		public static void End(IAsyncResult result) { }

		private bool HandleWriteBase64Text(IAsyncResult result) { }

		private static bool OnComplete(IAsyncResult result) { }

	}

	private class XmlBaseWriterNodeWriterAsyncHelper
	{
		private static AsyncEventArgsCallback onWriteComplete; //Field offset: 0x0
		private XmlBaseWriter writer; //Field offset: 0x8
		private Byte[] buffer; //Field offset: 0xC
		private int offset; //Field offset: 0x10
		private int count; //Field offset: 0x14
		private int actualByteCount; //Field offset: 0x18
		private int totalByteCount; //Field offset: 0x1C
		private AsyncEventArgs<XmlNodeWriterWriteBase64TextArgs> nodeWriterAsyncState; //Field offset: 0x20
		private XmlNodeWriterWriteBase64TextArgs nodeWriterArgs; //Field offset: 0x24
		private AsyncEventArgs<XmlWriteBase64AsyncArguments> inputState; //Field offset: 0x28

		public XmlBaseWriterNodeWriterAsyncHelper(XmlBaseWriter writer) { }

		private void Clear() { }

		private bool HandleWriteBase64Text(bool isAsyncCallback) { }

		private static void OnWriteComplete(IAsyncEventArgs asyncEventArgs) { }

		public void SetArguments(AsyncEventArgs<XmlWriteBase64AsyncArguments> inputState) { }

		public AsyncCompletionResult StartAsync() { }

	}

	private static BinHexEncoding binhexEncoding; //Field offset: 0x0
	private const string xmlNamespace = "http://www.w3.org/XML/1998/namespace"; //Field offset: 0x0
	private const string xmlnsNamespace = "http://www.w3.org/2000/xmlns/"; //Field offset: 0x0
	private static String[] prefixes; //Field offset: 0x4
	private XmlNodeWriter writer; //Field offset: 0xC
	private NamespaceManager nsMgr; //Field offset: 0x10
	private Element[] elements; //Field offset: 0x14
	private int depth; //Field offset: 0x18
	private string attributeLocalName; //Field offset: 0x1C
	private string attributeValue; //Field offset: 0x20
	private bool isXmlAttribute; //Field offset: 0x24
	private bool isXmlnsAttribute; //Field offset: 0x25
	private WriteState writeState; //Field offset: 0x28
	private DocumentState documentState; //Field offset: 0x2C
	private Byte[] trailBytes; //Field offset: 0x30
	private int trailByteCount; //Field offset: 0x34
	private XmlStreamNodeWriter nodeWriter; //Field offset: 0x38
	private XmlSigningNodeWriter signingWriter; //Field offset: 0x3C
	private XmlUTF8NodeWriter textFragmentWriter; //Field offset: 0x40
	private XmlNodeWriter oldWriter; //Field offset: 0x44
	private Stream oldStream; //Field offset: 0x48
	private int oldNamespaceBoundary; //Field offset: 0x4C
	private bool inList; //Field offset: 0x50
	private XmlBaseWriterNodeWriterAsyncHelper nodeWriterAsyncHelper; //Field offset: 0x54

	private static BinHexEncoding BinHexEncoding
	{
		private get { } //Length: 185
	}

	public virtual bool CanCanonicalize
	{
		 get { } //Length: 3
	}

	public override bool CanFragment
	{
		 get { } //Length: 3
	}

	protected bool IsClosed
	{
		 get { } //Length: 15
	}

	protected int NamespaceBoundary
	{
		 get { } //Length: 23
		 set { } //Length: 106
	}

	protected bool Signing
	{
		 get { } //Length: 17
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 11
	}

	public virtual string XmlLang
	{
		 get { } //Length: 23
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 23
	}

	private static XmlBaseWriter() { }

	protected XmlBaseWriter() { }

	private void AutoComplete(WriteState writeState) { }

	internal virtual IAsyncResult BeginWriteBase64(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual void Close() { }

	protected abstract XmlSigningNodeWriter CreateSigningNodeWriter() { }

	protected void EndArray() { }

	public virtual void EndCanonicalization() { }

	protected void EndComment() { }

	protected void EndContent() { }

	public override void EndFragment() { }

	private void EndStartElement() { }

	internal virtual void EndWriteBase64(IAsyncResult result) { }

	private void EnsureBufferBounds(Byte[] buffer, int offset, int count) { }

	private Element EnterScope() { }

	private void ExitScope() { }

	private void FinishDocument() { }

	public virtual void Flush() { }

	private void FlushBase64() { }

	protected void FlushElement() { }

	private void FlushTrailBytes() { }

	private string GeneratePrefix(string ns, XmlDictionaryString xNs) { }

	private static BinHexEncoding get_BinHexEncoding() { }

	public virtual bool get_CanCanonicalize() { }

	public override bool get_CanFragment() { }

	protected bool get_IsClosed() { }

	protected int get_NamespaceBoundary() { }

	protected bool get_Signing() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	private string GetQualifiedNamePrefix(string namespaceUri, XmlDictionaryString xNs) { }

	private bool IsWhitespace(char ch) { }

	internal string LookupNamespace(string prefix) { }

	public virtual string LookupPrefix(string ns) { }

	protected void set_NamespaceBoundary(int value) { }

	protected void SetOutput(XmlStreamNodeWriter writer) { }

	protected void SignScope(XmlCanonicalWriter signingWriter) { }

	protected void StartArray(int count) { }

	private void StartAttribute(ref string prefix, string localName, string ns, XmlDictionaryString xNs) { }

	public virtual void StartCanonicalization(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	protected void StartComment() { }

	protected void StartContent(Char[] chars, int offset, int count) { }

	protected void StartContent(string s) { }

	protected void StartContent(char ch) { }

	protected void StartContent() { }

	private void StartElement(ref string prefix, string localName, string ns, XmlDictionaryString xNs) { }

	public override void StartFragment(Stream stream, bool generateSelfContainedTextFragment) { }

	protected void ThrowClosed() { }

	private void VerifyWhitespace(string s) { }

	private void VerifyWhitespace(Char[] chars, int offset, int count) { }

	private void VerifyWhitespace(char ch) { }

	private void WriteAttributeText(string value) { }

	public virtual void WriteBase64(Byte[] buffer, int offset, int count) { }

	internal virtual AsyncCompletionResult WriteBase64Async(AsyncEventArgs<XmlWriteBase64AsyncArguments> state) { }

	public virtual void WriteBinHex(Byte[] buffer, int offset, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] chars, int offset, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	public override void WriteFragment(Byte[] buffer, int offset, int count) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteName(string name) { }

	public virtual void WriteNmToken(string name) { }

	protected void WritePrimitiveValue(object value) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual void WriteQualifiedName(string localName, string namespaceUri) { }

	public virtual void WriteRaw(Char[] chars, int offset, int count) { }

	public virtual void WriteRaw(string value) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string namespaceUri) { }

	public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual void WriteStartElement(string prefix, string localName, string namespaceUri) { }

	public virtual void WriteString(XmlDictionaryString value) { }

	public virtual void WriteString(string value) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	private void WriteValue(Array array) { }

	private void WriteValue(Object[] array) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(UniqueId value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(XmlDictionaryString value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(object value) { }

	private void WriteValue(ulong value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteWhitespace(string whitespace) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

}

