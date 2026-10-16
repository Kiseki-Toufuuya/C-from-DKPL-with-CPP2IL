namespace System.Runtime.Serialization;

internal sealed class SurrogateDataContract : DataContract
{
	private class SurrogateDataContractCriticalHelper : DataContractCriticalHelper
	{
		private ISerializationSurrogate serializationSurrogate; //Field offset: 0x30

		internal ISerializationSurrogate SerializationSurrogate
		{
			internal get { } //Length: 11
		}

		internal SurrogateDataContractCriticalHelper(Type type, ISerializationSurrogate serializationSurrogate) { }

		internal ISerializationSurrogate get_SerializationSurrogate() { }

	}

	private SurrogateDataContractCriticalHelper helper; //Field offset: 0x14

	internal ISerializationSurrogate SerializationSurrogate
	{
		internal get { } //Length: 23
	}

	internal SurrogateDataContract(Type type, ISerializationSurrogate serializationSurrogate) { }

	internal ISerializationSurrogate get_SerializationSurrogate() { }

	internal static object GetRealObject(IObjectReference obj, StreamingContext context) { }

	private object GetUninitializedObject(Type objType) { }

	public virtual object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	private void SerializationSurrogateGetObjectData(object obj, SerializationInfo serInfo, StreamingContext context) { }

	private object SerializationSurrogateSetObjectData(object obj, SerializationInfo serInfo, StreamingContext context) { }

	public virtual void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}

