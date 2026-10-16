namespace System.Xml;

internal class MimeHeader
{
	private string name; //Field offset: 0x8
	private string value; //Field offset: 0xC

	public string Name
	{
		 get { } //Length: 11
	}

	public string Value
	{
		 get { } //Length: 11
	}

	public MimeHeader(string name, string value) { }

	public string get_Name() { }

	public string get_Value() { }

}

