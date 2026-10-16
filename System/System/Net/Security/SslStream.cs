namespace System.Net.Security;

public class SslStream : AuthenticatedStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public LocalCertificateSelectionCallback callback; //Field offset: 0x8
		public SslStream <>4__this; //Field offset: 0xC

		public <>c__DisplayClass21_0() { }

		internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}

	private MobileTlsProvider provider; //Field offset: 0x1C
	private MonoTlsSettings settings; //Field offset: 0x20
	private RemoteCertificateValidationCallback validationCallback; //Field offset: 0x24
	private LocalCertificateSelectionCallback selectionCallback; //Field offset: 0x28
	private MobileAuthenticatedStream impl; //Field offset: 0x2C
	private bool explicitSettings; //Field offset: 0x30

	public virtual bool CanRead
	{
		 get { } //Length: 41
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 40
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 41
	}

	internal MobileAuthenticatedStream Impl
	{
		internal get { } //Length: 82
	}

	internal string InternalTargetHost
	{
		internal get { } //Length: 85
	}

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 102
	}

	public virtual long Length
	{
		 get { } //Length: 102
	}

	public override X509Certificate LocalCertificate
	{
		 get { } //Length: 92
	}

	public virtual long Position
	{
		 get { } //Length: 102
		 set { } //Length: 72
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 102
		 set { } //Length: 105
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 102
		 set { } //Length: 105
	}

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	public override void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	private void CheckDisposed() { }

	protected virtual void Dispose(bool disposing) { }

	public override void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	internal MobileAuthenticatedStream get_Impl() { }

	internal string get_InternalTargetHost() { }

	public virtual bool get_IsAuthenticated() { }

	public virtual long get_Length() { }

	public override X509Certificate get_LocalCertificate() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	private static MobileTlsProvider GetProvider() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

