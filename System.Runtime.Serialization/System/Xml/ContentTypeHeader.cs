namespace System.Xml;

internal class ContentTypeHeader : MimeHeader
{
	public static readonly ContentTypeHeader Default; //Field offset: 0x0
	private string mediaType; //Field offset: 0x10
	private string subType; //Field offset: 0x14
	private Dictionary<String, String> parameters; //Field offset: 0x18

	public string MediaSubtype
	{
		 get { } //Length: 36
	}

	public string MediaType
	{
		 get { } //Length: 36
	}

	public Dictionary<String, String> Parameters
	{
		 get { } //Length: 124
	}

	private static ContentTypeHeader() { }

	public ContentTypeHeader(string value) { }

	public string get_MediaSubtype() { }

	public string get_MediaType() { }

	public Dictionary<String, String> get_Parameters() { }

	private void ParseValue() { }

}

