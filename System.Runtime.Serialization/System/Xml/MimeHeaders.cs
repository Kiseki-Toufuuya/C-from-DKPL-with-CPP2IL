namespace System.Xml;

internal class MimeHeaders
{
	private static class Constants
	{
		public const string ContentTransferEncoding = "content-transfer-encoding"; //Field offset: 0x0
		public const string ContentID = "content-id"; //Field offset: 0x0
		public const string ContentType = "content-type"; //Field offset: 0x0
		public const string MimeVersion = "mime-version"; //Field offset: 0x0

	}

	private Dictionary<String, MimeHeader> headers; //Field offset: 0x8

	public ContentIDHeader ContentID
	{
		 get { } //Length: 187
	}

	public ContentTransferEncodingHeader ContentTransferEncoding
	{
		 get { } //Length: 187
	}

	public ContentTypeHeader ContentType
	{
		 get { } //Length: 187
	}

	public MimeVersionHeader MimeVersion
	{
		 get { } //Length: 187
	}

	public MimeHeaders() { }

	public void Add(string name, string value, ref int remaining) { }

	public void Add(MimeHeader header) { }

	public ContentIDHeader get_ContentID() { }

	public ContentTransferEncodingHeader get_ContentTransferEncoding() { }

	public ContentTypeHeader get_ContentType() { }

	public MimeVersionHeader get_MimeVersion() { }

	public void Release(ref int remaining) { }

}

