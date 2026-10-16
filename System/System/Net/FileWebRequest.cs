namespace System.Net;

public class FileWebRequest : WebRequest, ISerializable
{
	private static WaitCallback s_GetRequestStreamCallback; //Field offset: 0x0
	private static WaitCallback s_GetResponseCallback; //Field offset: 0x4
	private string m_connectionGroupName; //Field offset: 0x20
	private long m_contentLength; //Field offset: 0x28
	private ICredentials m_credentials; //Field offset: 0x30
	private FileAccess m_fileAccess; //Field offset: 0x34
	private WebHeaderCollection m_headers; //Field offset: 0x38
	private string m_method; //Field offset: 0x3C
	private IWebProxy m_proxy; //Field offset: 0x40
	private ManualResetEvent m_readerEvent; //Field offset: 0x44
	private bool m_readPending; //Field offset: 0x48
	private WebResponse m_response; //Field offset: 0x4C
	private Stream m_stream; //Field offset: 0x50
	private bool m_syncHint; //Field offset: 0x54
	private int m_timeout; //Field offset: 0x58
	private Uri m_uri; //Field offset: 0x5C
	private bool m_writePending; //Field offset: 0x60
	private bool m_writing; //Field offset: 0x61
	private LazyAsyncResult m_WriteAResult; //Field offset: 0x64
	private LazyAsyncResult m_ReadAResult; //Field offset: 0x68
	private int m_Aborted; //Field offset: 0x6C

	internal bool Aborted
	{
		internal get { } //Length: 15
	}

	public virtual long ContentLength
	{
		 get { } //Length: 14
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 11
	}

	public virtual string Method
	{
		 get { } //Length: 11
		 set { } //Length: 182
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 11
	}

	public virtual int Timeout
	{
		 get { } //Length: 11
	}

	public virtual bool UseDefaultCredentials
	{
		 get { } //Length: 30
	}

	private static FileWebRequest() { }

	internal FileWebRequest(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void Abort() { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal bool get_Aborted() { }

	public virtual long get_ContentLength() { }

	public virtual ICredentials get_Credentials() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual string get_Method() { }

	public virtual IWebProxy get_Proxy() { }

	public virtual Uri get_RequestUri() { }

	public virtual int get_Timeout() { }

	public virtual bool get_UseDefaultCredentials() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private static void GetRequestStreamCallback(object state) { }

	public virtual WebResponse GetResponse() { }

	private static void GetResponseCallback(object state) { }

	public virtual void set_Credentials(ICredentials value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void UnblockReader() { }

}

