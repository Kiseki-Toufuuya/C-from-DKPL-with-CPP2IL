namespace System.Runtime.Serialization;

internal class ObjectDataContract : PrimitiveDataContract
{

	internal virtual bool CanContainReferences
	{
		internal get { } //Length: 3
	}

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

	internal ObjectDataContract() { }

	internal virtual bool get_CanContainReferences() { }

	internal virtual bool get_IsPrimitive() { }

	internal virtual string get_ReadMethodName() { }

	internal virtual string get_WriteMethodName() { }

	public virtual object ReadXmlValue(XmlReaderDelegator reader, XmlObjectSerializerReadContext context) { }

	public virtual void WriteXmlValue(XmlWriterDelegator writer, object obj, XmlObjectSerializerWriteContext context) { }

}

