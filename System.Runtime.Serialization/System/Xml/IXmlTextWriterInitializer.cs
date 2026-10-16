namespace System.Xml;

public interface IXmlTextWriterInitializer
{

	public void SetOutput(Stream stream, Encoding encoding, bool ownsStream) { }

}

