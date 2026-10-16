namespace System.Xml;

public interface IXmlDictionary
{

	public bool TryLookup(string value, out XmlDictionaryString result) { }

	public bool TryLookup(int key, out XmlDictionaryString result) { }

	public bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result) { }

}

