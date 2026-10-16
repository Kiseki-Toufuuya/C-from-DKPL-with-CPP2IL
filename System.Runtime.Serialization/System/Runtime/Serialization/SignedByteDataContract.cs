namespace System.Runtime.Serialization;

internal class SignedByteDataContract : PrimitiveDataContract
{

	internal virtual string ReadMethodName
	{
		internal get { } //Length: 35
	}

	internal virtual string WriteMethodName
	{
		internal get { } //Length: 35
	}

	internal SignedByteDataContract() { }

	internal virtual string get_ReadMethodName() { }

	internal virtual string get_WriteMethodName() { }

	public virtual object ReadXmlValue(XmlReaderDelegator reader, XmlObjectSerializerReadContext context) { }

	public virtual void WriteXmlValue(XmlWriterDelegator writer, object obj, XmlObjectSerializerWriteContext context) { }

}

