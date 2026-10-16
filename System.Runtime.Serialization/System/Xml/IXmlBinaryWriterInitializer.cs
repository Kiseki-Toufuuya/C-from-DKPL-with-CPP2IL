namespace System.Xml;

public interface IXmlBinaryWriterInitializer
{

	public void SetOutput(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream) { }

}

