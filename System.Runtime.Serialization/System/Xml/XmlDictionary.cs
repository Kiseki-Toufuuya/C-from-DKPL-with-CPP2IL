namespace System.Xml;

public class XmlDictionary : IXmlDictionary
{
	private class EmptyDictionary : IXmlDictionary
	{

		public EmptyDictionary() { }

		public override bool TryLookup(string value, out XmlDictionaryString result) { }

		public override bool TryLookup(int key, out XmlDictionaryString result) { }

		public override bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result) { }

	}

	private static IXmlDictionary empty; //Field offset: 0x0
	private Dictionary<String, XmlDictionaryString> lookup; //Field offset: 0x8
	private XmlDictionaryString[] strings; //Field offset: 0xC
	private int nextId; //Field offset: 0x10

	public static IXmlDictionary Empty
	{
		 get { } //Length: 115
	}

	public XmlDictionary() { }

	public XmlDictionary(int capacity) { }

	public override XmlDictionaryString Add(string value) { }

	public static IXmlDictionary get_Empty() { }

	public override bool TryLookup(string value, out XmlDictionaryString result) { }

	public override bool TryLookup(int key, out XmlDictionaryString result) { }

	public override bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result) { }

}

