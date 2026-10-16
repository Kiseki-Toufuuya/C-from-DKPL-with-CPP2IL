namespace System.Runtime.Serialization;

internal class QNameDataContract : PrimitiveDataContract
{

	internal virtual bool IsPrimitive
	{
		internal get { } //Length: 3
	}

	internal virtual string ReadMethodName
	{
		internal get { } //Length: 35
	}

	internal virtual string WriteMethodName
	{
		internal get { } //Length: 35
	}

	internal QNameDataContract() { }

	internal virtual bool get_IsPrimitive() { }

	internal virtual string get_ReadMethodName() { }

	internal virtual string get_WriteMethodName() { }

	public virtual object ReadXmlValue(XmlReaderDelegator reader, XmlObjectSerializerReadContext context) { }

	internal virtual void WriteRootElement(XmlWriterDelegator writer, XmlDictionaryString name, XmlDictionaryString ns) { }

	public virtual void WriteXmlValue(XmlWriterDelegator writer, object obj, XmlObjectSerializerWriteContext context) { }

}

