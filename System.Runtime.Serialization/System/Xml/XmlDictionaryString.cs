namespace System.Xml;

public class XmlDictionaryString
{
	private class EmptyStringDictionary : IXmlDictionary
	{
		private XmlDictionaryString empty; //Field offset: 0x8

		public XmlDictionaryString EmptyString
		{
			 get { } //Length: 11
		}

		public EmptyStringDictionary() { }

		public XmlDictionaryString get_EmptyString() { }

		public override bool TryLookup(string value, out XmlDictionaryString result) { }

		public override bool TryLookup(int key, out XmlDictionaryString result) { }

		public override bool TryLookup(XmlDictionaryString value, out XmlDictionaryString result) { }

	}

	internal const int MinKey = 0; //Field offset: 0x0
	internal const int MaxKey = 536870911; //Field offset: 0x0
	private static EmptyStringDictionary emptyStringDictionary; //Field offset: 0x0
	private IXmlDictionary dictionary; //Field offset: 0x8
	private string value; //Field offset: 0xC
	private int key; //Field offset: 0x10
	private Byte[] buffer; //Field offset: 0x14

	public IXmlDictionary Dictionary
	{
		 get { } //Length: 11
	}

	public static XmlDictionaryString Empty
	{
		 get { } //Length: 72
	}

	public int Key
	{
		 get { } //Length: 11
	}

	public string Value
	{
		 get { } //Length: 11
	}

	private static XmlDictionaryString() { }

	public XmlDictionaryString(IXmlDictionary dictionary, string value, int key) { }

	public IXmlDictionary get_Dictionary() { }

	public static XmlDictionaryString get_Empty() { }

	public int get_Key() { }

	public string get_Value() { }

	internal static string GetString(XmlDictionaryString s) { }

	public virtual string ToString() { }

	internal Byte[] ToUTF8() { }

}

