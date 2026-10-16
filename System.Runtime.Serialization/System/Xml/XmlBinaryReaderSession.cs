namespace System.Xml;

public class XmlBinaryReaderSession : IXmlDictionary
{
	private const int MaxArrayEntries = 2048; //Field offset: 0x0
	private XmlDictionaryString[] strings; //Field offset: 0x8
	private Dictionary<Int32, XmlDictionaryString> stringDict; //Field offset: 0xC

	public XmlBinaryReaderSession() { }

	public XmlDictionaryString Add(int id, string value) { }

	public void Clear() { }

	public override bool TryLookup(int key, out XmlDictionaryString result) { }

	public override bool TryLookup(string value, out XmlDictionaryString result) { }

	public override bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result) { }

}

