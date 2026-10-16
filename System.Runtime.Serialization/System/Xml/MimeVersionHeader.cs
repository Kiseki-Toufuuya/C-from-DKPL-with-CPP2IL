namespace System.Xml;

internal class MimeVersionHeader : MimeHeader
{
	public static readonly MimeVersionHeader Default; //Field offset: 0x0
	private string version; //Field offset: 0x10

	public string Version
	{
		 get { } //Length: 36
	}

	private static MimeVersionHeader() { }

	public MimeVersionHeader(string value) { }

	public string get_Version() { }

	private void ParseValue() { }

}

