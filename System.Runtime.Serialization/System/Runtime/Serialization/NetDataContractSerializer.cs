namespace System.Runtime.Serialization;

public sealed class NetDataContractSerializer : XmlObjectSerializer, IFormatter
{
	private static Hashtable typeNameCache; //Field offset: 0x0
	private static Nullable<Boolean> unsafeTypeForwardingEnabled; //Field offset: 0x4
	private XmlDictionaryString rootName; //Field offset: 0x8
	private XmlDictionaryString rootNamespace; //Field offset: 0xC
	private StreamingContext context; //Field offset: 0x10
	private SerializationBinder binder; //Field offset: 0x18
	private ISurrogateSelector surrogateSelector; //Field offset: 0x1C
	private int maxItemsInObjectGraph; //Field offset: 0x20
	private bool ignoreExtensionDataObject; //Field offset: 0x24
	private FormatterAssemblyStyle assemblyFormat; //Field offset: 0x28
	private DataContract cachedDataContract; //Field offset: 0x2C

	public FormatterAssemblyStyle AssemblyFormat
	{
		 get { } //Length: 11
		 set { } //Length: 188
	}

	public override SerializationBinder Binder
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override StreamingContext Context
	{
		 get { } //Length: 14
		 set { } //Length: 34
	}

	public bool IgnoreExtensionDataObject
	{
		 get { } //Length: 11
	}

	public int MaxItemsInObjectGraph
	{
		 get { } //Length: 11
	}

	public override ISurrogateSelector SurrogateSelector
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	internal static bool UnsafeTypeForwardingEnabled
	{
		internal get { } //Length: 214
	}

	private static NetDataContractSerializer() { }

	public NetDataContractSerializer(XmlDictionaryString rootName, XmlDictionaryString rootNamespace, StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector) { }

	public NetDataContractSerializer(XmlDictionaryString rootName, XmlDictionaryString rootNamespace) { }

	public NetDataContractSerializer(string rootName, string rootNamespace, StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector) { }

	public NetDataContractSerializer() { }

	public NetDataContractSerializer(StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector) { }

	public NetDataContractSerializer(string rootName, string rootNamespace) { }

	public NetDataContractSerializer(StreamingContext context) { }

	public override object Deserialize(Stream stream) { }

	public FormatterAssemblyStyle get_AssemblyFormat() { }

	public override SerializationBinder get_Binder() { }

	public override StreamingContext get_Context() { }

	public bool get_IgnoreExtensionDataObject() { }

	public int get_MaxItemsInObjectGraph() { }

	public override ISurrogateSelector get_SurrogateSelector() { }

	internal static bool get_UnsafeTypeForwardingEnabled() { }

	internal DataContract GetDataContract(object obj, ref Hashtable surrogateDataContracts) { }

	internal DataContract GetDataContract(Type type, ref Hashtable surrogateDataContracts) { }

	internal DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type, ref Hashtable surrogateDataContracts) { }

	internal static DataContract GetDataContractFromSurrogateSelector(ISurrogateSelector surrogateSelector, StreamingContext context, RuntimeTypeHandle typeHandle, Type type, ref Hashtable surrogateDataContracts) { }

	private static ISerializationSurrogate GetSurrogate(Type type, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	internal static TypeInformation GetTypeInformation(Type type) { }

	private void Initialize(XmlDictionaryString rootName, XmlDictionaryString rootNamespace, StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector) { }

	private void Initialize(StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, FormatterAssemblyStyle assemblyFormat, ISurrogateSelector surrogateSelector) { }

	internal virtual bool InternalIsStartObject(XmlReaderDelegator reader) { }

	internal virtual object InternalReadObject(XmlReaderDelegator xmlReader, bool verifyObjectName) { }

	internal virtual void InternalWriteEndObject(XmlWriterDelegator writer) { }

	internal virtual void InternalWriteObject(XmlWriterDelegator writer, object graph) { }

	private void InternalWriteObjectContent(XmlWriterDelegator writer, object graph, DataContract contract, Hashtable surrogateDataContracts) { }

	internal virtual void InternalWriteObjectContent(XmlWriterDelegator writer, object graph) { }

	private void InternalWriteStartObject(XmlWriterDelegator writer, object graph, DataContract contract) { }

	internal virtual void InternalWriteStartObject(XmlWriterDelegator writer, object graph) { }

	private static bool IsAssemblyNameForwardingSafe(string originalAssemblyName, string newAssemblyName) { }

	private static bool IsPublicKeyTokenForwardingSafe(Byte[] sourceToken, Byte[] destinationToken) { }

	public virtual bool IsStartObject(XmlDictionaryReader reader) { }

	public virtual bool IsStartObject(XmlReader reader) { }

	public virtual object ReadObject(XmlReader reader, bool verifyObjectName) { }

	public virtual object ReadObject(XmlReader reader) { }

	public virtual object ReadObject(XmlDictionaryReader reader, bool verifyObjectName) { }

	public override void Serialize(Stream stream, object graph) { }

	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	public override void set_Binder(SerializationBinder value) { }

	public override void set_Context(StreamingContext value) { }

	public override void set_SurrogateSelector(ISurrogateSelector value) { }

	private static void WriteClrTypeInfo(XmlWriterDelegator writer, string clrTypeName, string clrAssemblyName) { }

	internal static void WriteClrTypeInfo(XmlWriterDelegator writer, Type dataContractType, SerializationBinder binder, SerializationInfo serInfo) { }

	internal static void WriteClrTypeInfo(XmlWriterDelegator writer, Type dataContractType, SerializationBinder binder, string defaultClrTypeName, string defaultClrAssemblyName) { }

	internal static void WriteClrTypeInfo(XmlWriterDelegator writer, DataContract dataContract, SerializationBinder binder) { }

	public virtual void WriteEndObject(XmlDictionaryWriter writer) { }

	public virtual void WriteEndObject(XmlWriter writer) { }

	public virtual void WriteObject(XmlWriter writer, object graph) { }

	public virtual void WriteObjectContent(XmlDictionaryWriter writer, object graph) { }

	public virtual void WriteObjectContent(XmlWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlWriter writer, object graph) { }

	public virtual void WriteStartObject(XmlDictionaryWriter writer, object graph) { }

}

