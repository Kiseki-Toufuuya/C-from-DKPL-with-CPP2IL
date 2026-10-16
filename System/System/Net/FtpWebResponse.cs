namespace System.Net;

public class FtpWebResponse : WebResponse, IDisposable
{
	public sealed class EmptyStream : MemoryStream
	{

		internal EmptyStream() { }

	}

	internal Stream _responseStream; //Field offset: 0x10
	private long _contentLength; //Field offset: 0x18
	private Uri _responseUri; //Field offset: 0x20
	private FtpStatusCode _statusCode; //Field offset: 0x24
	private string _statusLine; //Field offset: 0x28
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x2C
	private DateTime _lastModified; //Field offset: 0x30
	private string _bannerMessage; //Field offset: 0x38
	private string _welcomeMessage; //Field offset: 0x3C
	private string _exitMessage; //Field offset: 0x40

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 284
	}

	public virtual Uri ResponseUri
	{
		 get { } //Length: 11
	}

	public FtpStatusCode StatusCode
	{
		 get { } //Length: 11
	}

	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	public virtual void Close() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual Uri get_ResponseUri() { }

	public FtpStatusCode get_StatusCode() { }

	public virtual Stream GetResponseStream() { }

	internal void SetResponseStream(Stream stream) { }

	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

}

