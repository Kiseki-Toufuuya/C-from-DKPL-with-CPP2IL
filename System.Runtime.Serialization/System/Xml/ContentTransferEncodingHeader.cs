namespace System.Xml;

internal class ContentTransferEncodingHeader : MimeHeader
{
	public static readonly ContentTransferEncodingHeader Binary; //Field offset: 0x0
	public static readonly ContentTransferEncodingHeader EightBit; //Field offset: 0x4
	public static readonly ContentTransferEncodingHeader SevenBit; //Field offset: 0x8
	private ContentTransferEncoding contentTransferEncoding; //Field offset: 0x10
	private string contentTransferEncodingValue; //Field offset: 0x14

	public ContentTransferEncoding ContentTransferEncoding
	{
		 get { } //Length: 24
	}

	public string ContentTransferEncodingValue
	{
		 get { } //Length: 24
	}

	private static ContentTransferEncodingHeader() { }

	public ContentTransferEncodingHeader(string value) { }

	public ContentTransferEncodingHeader(ContentTransferEncoding contentTransferEncoding, string value) { }

	public ContentTransferEncoding get_ContentTransferEncoding() { }

	public string get_ContentTransferEncodingValue() { }

	private void ParseValue() { }

}

