namespace System.Xml;

internal class XmlUTF8TextWriter : XmlBaseWriter, IXmlTextWriterInitializer
{
	private XmlUTF8NodeWriter writer; //Field offset: 0x58

	public virtual bool CanFragment
	{
		 get { } //Length: 27
	}

	internal virtual bool FastAsync
	{
		internal get { } //Length: 3
	}

	public XmlUTF8TextWriter() { }

	protected virtual XmlSigningNodeWriter CreateSigningNodeWriter() { }

	public virtual bool get_CanFragment() { }

	internal virtual bool get_FastAsync() { }

	public override void SetOutput(Stream stream, Encoding encoding, bool ownsStream) { }

}

