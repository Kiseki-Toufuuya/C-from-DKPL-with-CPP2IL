namespace System.Xml;

public abstract class XmlDictionaryWriter : XmlWriter
{
	private class WriteBase64AsyncResult : ScheduleActionItemAsyncResult
	{
		private Byte[] buffer; //Field offset: 0x38
		private int index; //Field offset: 0x3C
		private int count; //Field offset: 0x40
		private XmlDictionaryWriter writer; //Field offset: 0x44

		public WriteBase64AsyncResult(Byte[] buffer, int index, int count, XmlDictionaryWriter writer, AsyncCallback callback, object state) { }

		protected virtual void OnDoWork() { }

	}

	private class WriteValueAsyncResult : AsyncResult
	{
		private enum Operation
		{
			Read = 0,
			Write = 1,
		}

		private static Func<IAsyncResult, WriteValueAsyncResult, Boolean> handleWriteBlock; //Field offset: 0x0
		private static Func<IAsyncResult, WriteValueAsyncResult, Boolean> handleWriteBlockAsync; //Field offset: 0x4
		private static AsyncCallback onContinueWork; //Field offset: 0x8
		private int blockSize; //Field offset: 0x38
		private Byte[] block; //Field offset: 0x3C
		private int bytesRead; //Field offset: 0x40
		private Stream stream; //Field offset: 0x44
		private Operation operation; //Field offset: 0x48
		private IStreamProvider streamProvider; //Field offset: 0x4C
		private XmlDictionaryWriter writer; //Field offset: 0x50
		private Func<IAsyncResult, WriteValueAsyncResult, Boolean> writeBlockHandler; //Field offset: 0x54

		private static WriteValueAsyncResult() { }

		public WriteValueAsyncResult(XmlDictionaryWriter writer, IStreamProvider value, AsyncCallback callback, object state) { }

		private void AdjustBlockSize() { }

		private void CompleteAndReleaseStream(bool completedSynchronously, Exception completionException) { }

		private bool ContinueWork(IAsyncResult result) { }

		public static void End(IAsyncResult result) { }

		private bool HandleReadBlock(IAsyncResult result) { }

		private static bool HandleWriteBlock(IAsyncResult result, WriteValueAsyncResult thisPtr) { }

		private static bool HandleWriteBlockAsync(IAsyncResult result, WriteValueAsyncResult thisPtr) { }

		private static void OnContinueWork(IAsyncResult result) { }

	}

	private class WriteValueFastAsyncResult : AsyncResult
	{
		private enum Operation
		{
			Read = 0,
			Write = 1,
			Complete = 2,
		}

		private static AsyncCallback onReadComplete; //Field offset: 0x0
		private static AsyncEventArgsCallback onWriteComplete; //Field offset: 0x4
		private bool completed; //Field offset: 0x38
		private int blockSize; //Field offset: 0x3C
		private Byte[] block; //Field offset: 0x40
		private int bytesRead; //Field offset: 0x44
		private Stream stream; //Field offset: 0x48
		private Operation nextOperation; //Field offset: 0x4C
		private IStreamProvider streamProvider; //Field offset: 0x50
		private XmlDictionaryWriter writer; //Field offset: 0x54
		private AsyncEventArgs<XmlWriteBase64AsyncArguments> writerAsyncState; //Field offset: 0x58
		private XmlWriteBase64AsyncArguments writerAsyncArgs; //Field offset: 0x5C

		private static WriteValueFastAsyncResult() { }

		public WriteValueFastAsyncResult(XmlDictionaryWriter writer, IStreamProvider value, AsyncCallback callback, object state) { }

		private void CompleteAndReleaseStream(bool completedSynchronously, Exception completionException = null) { }

		private void ContinueWork(bool completedSynchronously, Exception completionException = null) { }

		internal static void End(IAsyncResult result) { }

		private void HandleReadComplete(IAsyncResult result) { }

		private void HandleWriteComplete() { }

		private static void OnReadComplete(IAsyncResult result) { }

		private static void OnWriteComplete(IAsyncEventArgs asyncState) { }

		private AsyncCompletionResult ReadAsync() { }

		private AsyncCompletionResult WriteAsync() { }

	}

	private class XmlWrappedWriter : XmlDictionaryWriter
	{
		private XmlWriter writer; //Field offset: 0xC
		private int depth; //Field offset: 0x10
		private int prefix; //Field offset: 0x14

		public virtual WriteState WriteState
		{
			 get { } //Length: 40
		}

		public virtual string XmlLang
		{
			 get { } //Length: 40
		}

		public virtual XmlSpace XmlSpace
		{
			 get { } //Length: 40
		}

		public XmlWrappedWriter(XmlWriter writer) { }

		public virtual void Close() { }

		public virtual void Flush() { }

		public virtual WriteState get_WriteState() { }

		public virtual string get_XmlLang() { }

		public virtual XmlSpace get_XmlSpace() { }

		public virtual string LookupPrefix(string namespaceUri) { }

		public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

		public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

		public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

		public virtual void WriteCData(string text) { }

		public virtual void WriteCharEntity(char ch) { }

		public virtual void WriteChars(Char[] buffer, int index, int count) { }

		public virtual void WriteComment(string text) { }

		public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

		public virtual void WriteEndAttribute() { }

		public virtual void WriteEndDocument() { }

		public virtual void WriteEndElement() { }

		public virtual void WriteEntityRef(string name) { }

		public virtual void WriteFullEndElement() { }

		public virtual void WriteName(string name) { }

		public virtual void WriteNmToken(string name) { }

		public virtual void WriteNode(XmlReader reader, bool defattr) { }

		public virtual void WriteProcessingInstruction(string name, string text) { }

		public virtual void WriteQualifiedName(string localName, string namespaceUri) { }

		public virtual void WriteRaw(Char[] buffer, int index, int count) { }

		public virtual void WriteRaw(string data) { }

		public virtual void WriteStartAttribute(string prefix, string localName, string namespaceUri) { }

		public virtual void WriteStartDocument(bool standalone) { }

		public virtual void WriteStartDocument() { }

		public virtual void WriteStartElement(string prefix, string localName, string namespaceUri) { }

		public virtual void WriteString(string text) { }

		public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

		public virtual void WriteValue(string value) { }

		public virtual void WriteValue(bool value) { }

		public virtual void WriteValue(DateTime value) { }

		public virtual void WriteValue(double value) { }

		public virtual void WriteValue(int value) { }

		public virtual void WriteValue(long value) { }

		public virtual void WriteValue(object value) { }

		public virtual void WriteWhitespace(string whitespace) { }

		public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }

	}


	public override bool CanCanonicalize
	{
		 get { } //Length: 3
	}

	internal override bool FastAsync
	{
		internal get { } //Length: 3
	}

	protected XmlDictionaryWriter() { }

	internal override IAsyncResult BeginWriteBase64(Byte[] buffer, int index, int count, AsyncCallback callback, object state) { }

	internal override IAsyncResult BeginWriteValue(IStreamProvider value, AsyncCallback callback, object state) { }

	private void CheckArray(Array array, int offset, int count) { }

	public static XmlDictionaryWriter CreateBinaryWriter(Stream stream) { }

	public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary) { }

	public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session) { }

	public static XmlDictionaryWriter CreateBinaryWriter(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream) { }

	public static XmlDictionaryWriter CreateDictionaryWriter(XmlWriter writer) { }

	public static XmlDictionaryWriter CreateMtomWriter(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo) { }

	public static XmlDictionaryWriter CreateMtomWriter(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { }

	public static XmlDictionaryWriter CreateTextWriter(Stream stream) { }

	public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding) { }

	public static XmlDictionaryWriter CreateTextWriter(Stream stream, Encoding encoding, bool ownsStream) { }

	public override void EndCanonicalization() { }

	internal override void EndWriteBase64(IAsyncResult result) { }

	internal override void EndWriteValue(IAsyncResult result) { }

	public override bool get_CanCanonicalize() { }

	internal override bool get_FastAsync() { }

	public override void StartCanonicalization(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Single[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	public override void WriteArray(string prefix, string localName, string namespaceUri, Double[] array, int offset, int count) { }

	public override void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	private void WriteArrayNode(XmlDictionaryReader reader, Type type) { }

	private void WriteArrayNode(XmlDictionaryReader reader, string prefix, string localName, string namespaceUri, Type type) { }

	private void WriteArrayNode(XmlDictionaryReader reader, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Type type) { }

	public void WriteAttributeString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value) { }

	public void WriteAttributeString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value) { }

	internal override AsyncCompletionResult WriteBase64Async(AsyncEventArgs<XmlWriteBase64AsyncArguments> state) { }

	public virtual Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	private void WriteElementNode(XmlDictionaryReader reader, bool defattr) { }

	public void WriteElementString(XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value) { }

	public void WriteElementString(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, string value) { }

	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	public override void WriteNode(XmlDictionaryReader reader, bool defattr) { }

	public override void WriteQualifiedName(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public void WriteStartAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public void WriteStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override void WriteString(XmlDictionaryString value) { }

	protected override void WriteTextNode(XmlDictionaryReader reader, bool isAttribute) { }

	public override void WriteValue(IStreamProvider value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(XmlDictionaryString value) { }

	public override void WriteValue(UniqueId value) { }

	public override Task WriteValueAsync(IStreamProvider value) { }

	public override void WriteXmlAttribute(XmlDictionaryString localName, XmlDictionaryString value) { }

	public override void WriteXmlAttribute(string localName, string value) { }

	public override void WriteXmlnsAttribute(string prefix, XmlDictionaryString namespaceUri) { }

	public override void WriteXmlnsAttribute(string prefix, string namespaceUri) { }

}

