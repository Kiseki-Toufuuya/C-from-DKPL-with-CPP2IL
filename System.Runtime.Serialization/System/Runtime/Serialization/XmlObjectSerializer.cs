namespace System.Runtime.Serialization;

public abstract class XmlObjectSerializer
{
	private static IFormatterConverter formatterConverter; //Field offset: 0x0

	internal static IFormatterConverter FormatterConverter
	{
		internal get { } //Length: 115
	}

	internal override Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 3
	}

	protected XmlObjectSerializer() { }

	internal bool CheckIfNeedsContractNsAtRoot(XmlDictionaryString name, XmlDictionaryString ns, DataContract contract) { }

	internal static void CheckNull(object obj, string name) { }

	internal static SerializationException CreateSerializationException(string errorMessage, Exception innerException) { }

	internal static SerializationException CreateSerializationException(string errorMessage) { }

	internal static Exception CreateSerializationExceptionWithReaderDetails(string errorMessage, XmlReaderDelegator reader) { }

	internal static IFormatterConverter get_FormatterConverter() { }

	internal override Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	internal override Type GetDeserializeType() { }

	internal override Type GetSerializeType(object graph) { }

	private static string GetTypeInfo(Type type) { }

	private static string GetTypeInfoError(string errorMessage, Type type, Exception innerException) { }

	internal override bool InternalIsStartObject(XmlReaderDelegator reader) { }

	internal override object InternalReadObject(XmlReaderDelegator reader, bool verifyObjectName) { }

	internal override object InternalReadObject(XmlReaderDelegator reader, bool verifyObjectName, DataContractResolver dataContractResolver) { }

	internal override void InternalWriteEndObject(XmlWriterDelegator writer) { }

	internal override void InternalWriteObject(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver) { }

	internal override void InternalWriteObject(XmlWriterDelegator writer, object graph) { }

	internal override void InternalWriteObjectContent(XmlWriterDelegator writer, object graph) { }

	internal override void InternalWriteStartObject(XmlWriterDelegator writer, object graph) { }

	internal static bool IsContractDeclared(DataContract contract, DataContract declaredContract) { }

	internal bool IsRootElement(XmlReaderDelegator reader, DataContract contract, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal bool IsRootXmlAny(XmlDictionaryString rootName, DataContract contract) { }

	internal bool IsStartElement(XmlReaderDelegator reader) { }

	public override bool IsStartObject(XmlReader reader) { }

	public abstract bool IsStartObject(XmlDictionaryReader reader) { }

	internal bool IsStartObjectHandleExceptions(XmlReaderDelegator reader) { }

	public abstract object ReadObject(XmlDictionaryReader reader, bool verifyObjectName) { }

	public override object ReadObject(XmlReader reader) { }

	public override object ReadObject(XmlDictionaryReader reader) { }

	public override object ReadObject(Stream stream) { }

	public override object ReadObject(XmlReader reader, bool verifyObjectName) { }

	internal object ReadObjectHandleExceptions(XmlReaderDelegator reader, bool verifyObjectName) { }

	internal object ReadObjectHandleExceptions(XmlReaderDelegator reader, bool verifyObjectName, DataContractResolver dataContractResolver) { }

	internal static string TryAddLineInfo(XmlReaderDelegator reader, string errorMessage) { }

	public abstract void WriteEndObject(XmlDictionaryWriter writer) { }

	public override void WriteEndObject(XmlWriter writer) { }

	internal void WriteEndObjectHandleExceptions(XmlWriterDelegator writer) { }

	internal static void WriteNull(XmlWriterDelegator writer) { }

	public override void WriteObject(Stream stream, object graph) { }

	public override void WriteObject(XmlDictionaryWriter writer, object graph) { }

	public override void WriteObject(XmlWriter writer, object graph) { }

	public abstract void WriteObjectContent(XmlDictionaryWriter writer, object graph) { }

	public override void WriteObjectContent(XmlWriter writer, object graph) { }

	internal void WriteObjectContentHandleExceptions(XmlWriterDelegator writer, object graph) { }

	internal void WriteObjectHandleExceptions(XmlWriterDelegator writer, object graph) { }

	internal void WriteObjectHandleExceptions(XmlWriterDelegator writer, object graph, DataContractResolver dataContractResolver) { }

	internal void WriteRootElement(XmlWriterDelegator writer, DataContract contract, XmlDictionaryString name, XmlDictionaryString ns, bool needsContractNsAtRoot) { }

	public override void WriteStartObject(XmlWriter writer, object graph) { }

	public abstract void WriteStartObject(XmlDictionaryWriter writer, object graph) { }

	internal void WriteStartObjectHandleExceptions(XmlWriterDelegator writer, object graph) { }

}

