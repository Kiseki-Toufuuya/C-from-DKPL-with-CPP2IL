namespace System.Xml;

public interface IXmlMtomWriterInitializer
{

	public void SetOutput(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { }

}

