namespace System.Xml;

internal abstract class XmlNodeWriter
{
	private class WriteBase64TextAsyncResult : ScheduleActionItemAsyncResult
	{
		private Byte[] trailBuffer; //Field offset: 0x38
		private int trailCount; //Field offset: 0x3C
		private Byte[] buffer; //Field offset: 0x40
		private int offset; //Field offset: 0x44
		private int count; //Field offset: 0x48
		private XmlNodeWriter nodeWriter; //Field offset: 0x4C

		public WriteBase64TextAsyncResult(Byte[] trailBuffer, int trailCount, Byte[] buffer, int offset, int count, XmlNodeWriter nodeWriter, AsyncCallback callback, object state) { }

		protected virtual void OnDoWork() { }

	}

	private class XmlNullNodeWriter : XmlNodeWriter
	{

		public XmlNullNodeWriter() { }

		public virtual void Close() { }

		public virtual void Flush() { }

		public virtual void WriteBase64Text(Byte[] trailBuffer, int trailCount, Byte[] buffer, int offset, int count) { }

		public virtual void WriteBoolText(bool value) { }

		public virtual void WriteCData(string text) { }

		public virtual void WriteCharEntity(int ch) { }

		public virtual void WriteComment(string text) { }

		public virtual void WriteDateTimeText(DateTime value) { }

		public virtual void WriteDecimalText(decimal value) { }

		public virtual void WriteDeclaration() { }

		public virtual void WriteDoubleText(double value) { }

		public virtual void WriteEndAttribute() { }

		public virtual void WriteEndElement(string prefix, string localName) { }

		public virtual void WriteEndElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

		public virtual void WriteEndListText() { }

		public virtual void WriteEndStartElement(bool isEmpty) { }

		public virtual void WriteEscapedText(Byte[] buffer, int offset, int count) { }

		public virtual void WriteEscapedText(XmlDictionaryString value) { }

		public virtual void WriteEscapedText(Char[] chars, int offset, int count) { }

		public virtual void WriteEscapedText(string value) { }

		public virtual void WriteFloatText(float value) { }

		public virtual void WriteGuidText(Guid value) { }

		public virtual void WriteInt32Text(int value) { }

		public virtual void WriteInt64Text(long value) { }

		public virtual void WriteListSeparator() { }

		public virtual void WriteQualifiedName(string prefix, XmlDictionaryString localName) { }

		public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName) { }

		public virtual void WriteStartAttribute(string prefix, string localName) { }

		public virtual void WriteStartAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

		public virtual void WriteStartElement(string prefix, XmlDictionaryString localName) { }

		public virtual void WriteStartElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

		public virtual void WriteStartElement(string prefix, string localName) { }

		public virtual void WriteStartListText() { }

		public virtual void WriteText(Char[] chars, int offset, int count) { }

		public virtual void WriteText(XmlDictionaryString value) { }

		public virtual void WriteText(Byte[] buffer, int offset, int count) { }

		public virtual void WriteText(string value) { }

		public virtual void WriteTimeSpanText(TimeSpan value) { }

		public virtual void WriteUInt64Text(ulong value) { }

		public virtual void WriteUniqueIdText(UniqueId value) { }

		public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

		public virtual void WriteXmlnsAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] nsBuffer, int nsOffset, int nsLength) { }

		public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

	}

	private static XmlNodeWriter nullNodeWriter; //Field offset: 0x0

	public static XmlNodeWriter Null
	{
		 get { } //Length: 115
	}

	protected XmlNodeWriter() { }

	public override IAsyncResult BeginWriteBase64Text(Byte[] trailBuffer, int trailCount, Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public abstract void Close() { }

	public override void EndWriteBase64Text(IAsyncResult result) { }

	public abstract void Flush() { }

	public static XmlNodeWriter get_Null() { }

	public abstract void WriteBase64Text(Byte[] trailBuffer, int trailCount, Byte[] buffer, int offset, int count) { }

	internal override AsyncCompletionResult WriteBase64TextAsync(AsyncEventArgs<XmlNodeWriterWriteBase64TextArgs> state) { }

	public abstract void WriteBoolText(bool value) { }

	public abstract void WriteCData(string text) { }

	public abstract void WriteCharEntity(int ch) { }

	public abstract void WriteComment(string text) { }

	public abstract void WriteDateTimeText(DateTime value) { }

	public abstract void WriteDecimalText(decimal value) { }

	public abstract void WriteDeclaration() { }

	public abstract void WriteDoubleText(double value) { }

	public abstract void WriteEndAttribute() { }

	public abstract void WriteEndElement(string prefix, string localName) { }

	public override void WriteEndElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public abstract void WriteEndListText() { }

	public abstract void WriteEndStartElement(bool isEmpty) { }

	public abstract void WriteEscapedText(Char[] chars, int offset, int count) { }

	public abstract void WriteEscapedText(XmlDictionaryString value) { }

	public abstract void WriteEscapedText(Byte[] buffer, int offset, int count) { }

	public abstract void WriteEscapedText(string value) { }

	public abstract void WriteFloatText(float value) { }

	public abstract void WriteGuidText(Guid value) { }

	public abstract void WriteInt32Text(int value) { }

	public abstract void WriteInt64Text(long value) { }

	public abstract void WriteListSeparator() { }

	public abstract void WriteQualifiedName(string prefix, XmlDictionaryString localName) { }

	public abstract void WriteStartAttribute(string prefix, string localName) { }

	public override void WriteStartAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public abstract void WriteStartAttribute(string prefix, XmlDictionaryString localName) { }

	public abstract void WriteStartElement(string prefix, XmlDictionaryString localName) { }

	public override void WriteStartElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public abstract void WriteStartElement(string prefix, string localName) { }

	public abstract void WriteStartListText() { }

	public abstract void WriteText(Byte[] buffer, int offset, int count) { }

	public abstract void WriteText(Char[] chars, int offset, int count) { }

	public abstract void WriteText(XmlDictionaryString value) { }

	public abstract void WriteText(string value) { }

	public abstract void WriteTimeSpanText(TimeSpan value) { }

	public abstract void WriteUInt64Text(ulong value) { }

	public abstract void WriteUniqueIdText(UniqueId value) { }

	public abstract void WriteXmlnsAttribute(string prefix, string ns) { }

	public abstract void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	public override void WriteXmlnsAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] nsBuffer, int nsOffset, int nsLength) { }

}

