namespace System.Xml.Serialization;

public abstract class XmlMapping
{
	private ObjectMap map; //Field offset: 0x8
	private ArrayList relatedMaps; //Field offset: 0xC
	private SerializationFormat format; //Field offset: 0x10
	private SerializationSource source; //Field offset: 0x14
	internal string _elementName; //Field offset: 0x18
	internal string _namespace; //Field offset: 0x1C
	private string key; //Field offset: 0x20

	public string ElementName
	{
		 get { } //Length: 11
	}

	internal SerializationFormat Format
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	internal ObjectMap ObjectMap
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ArrayList RelatedMaps
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal SerializationSource Source
	{
		internal get { } //Length: 11
	}

	internal XmlMapping(string elementName, string ns) { }

	public string get_ElementName() { }

	internal SerializationFormat get_Format() { }

	public string get_Namespace() { }

	internal ObjectMap get_ObjectMap() { }

	internal ArrayList get_RelatedMaps() { }

	internal SerializationSource get_Source() { }

	internal void set_Format(SerializationFormat value) { }

	internal void set_ObjectMap(ObjectMap value) { }

	internal void set_RelatedMaps(ArrayList value) { }

	public void SetKey(string key) { }

}

