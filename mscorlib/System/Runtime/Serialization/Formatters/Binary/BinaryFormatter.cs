namespace System.Runtime.Serialization.Formatters.Binary;

[ComVisible(True)]
public sealed class BinaryFormatter : IFormatter
{
	private static Dictionary<Type, TypeInformation> typeNameCache; //Field offset: 0x0
	internal ISurrogateSelector m_surrogates; //Field offset: 0x8
	internal StreamingContext m_context; //Field offset: 0xC
	internal SerializationBinder m_binder; //Field offset: 0x14
	internal FormatterTypeStyle m_typeFormat; //Field offset: 0x18
	internal FormatterAssemblyStyle m_assemblyFormat; //Field offset: 0x1C
	internal TypeFilterLevel m_securityLevel; //Field offset: 0x20
	internal Object[] m_crossAppDomainArray; //Field offset: 0x24

	public FormatterAssemblyStyle AssemblyFormat
	{
		 set { } //Length: 14
	}

	public override ISurrogateSelector SurrogateSelector
	{
		 set { } //Length: 27
	}

	private static BinaryFormatter() { }

	public BinaryFormatter() { }

	public BinaryFormatter(ISurrogateSelector selector, StreamingContext context) { }

	public override object Deserialize(Stream serializationStream) { }

	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	public override object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	internal static TypeInformation GetTypeInformation(Type type) { }

	public override void Serialize(Stream serializationStream, object graph) { }

	public override void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	public override void set_SurrogateSelector(ISurrogateSelector value) { }

}

