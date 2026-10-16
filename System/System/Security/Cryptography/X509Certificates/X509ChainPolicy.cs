namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainPolicy
{
	private OidCollection apps; //Field offset: 0x8
	private OidCollection cert; //Field offset: 0xC
	private X509CertificateCollection store; //Field offset: 0x10
	private X509Certificate2Collection store2; //Field offset: 0x14
	private X509RevocationFlag rflag; //Field offset: 0x18
	private X509RevocationMode mode; //Field offset: 0x1C
	private TimeSpan timeout; //Field offset: 0x20
	private X509VerificationFlags vflags; //Field offset: 0x28
	private DateTime vtime; //Field offset: 0x30

	public internal X509Certificate2Collection ExtraStore
	{
		 get { } //Length: 805
		internal set { } //Length: 27
	}

	public X509RevocationFlag RevocationFlag
	{
		 get { } //Length: 11
	}

	public X509RevocationMode RevocationMode
	{
		 get { } //Length: 11
		 set { } //Length: 84
	}

	public X509VerificationFlags VerificationFlags
	{
		 get { } //Length: 11
		 set { } //Length: 93
	}

	public DateTime VerificationTime
	{
		 get { } //Length: 14
	}

	public X509ChainPolicy() { }

	public X509Certificate2Collection get_ExtraStore() { }

	public X509RevocationFlag get_RevocationFlag() { }

	public X509RevocationMode get_RevocationMode() { }

	public X509VerificationFlags get_VerificationFlags() { }

	public DateTime get_VerificationTime() { }

	public void Reset() { }

	internal void set_ExtraStore(X509Certificate2Collection value) { }

	public void set_RevocationMode(X509RevocationMode value) { }

	public void set_VerificationFlags(X509VerificationFlags value) { }

}

