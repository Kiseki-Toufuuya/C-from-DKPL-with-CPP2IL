namespace Mono.Xml;

internal class SmallXmlParserException : SystemException
{
	private int line; //Field offset: 0x48
	private int column; //Field offset: 0x4C

	public SmallXmlParserException(string msg, int line, int column) { }

}

