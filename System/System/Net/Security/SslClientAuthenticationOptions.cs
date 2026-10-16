namespace System.Net.Security;

public class SslClientAuthenticationOptions
{
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x8
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0xC
	private SslProtocols _enabledSslProtocols; //Field offset: 0x10
	private bool _allowRenegotiation; //Field offset: 0x14
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x1C

	public bool AllowRenegotiation
	{
		 get { } //Length: 11
	}

	public X509RevocationMode CertificateRevocationCheckMode
	{
		 set { } //Length: 129
	}

	public X509CertificateCollection ClientCertificates
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SslProtocols EnabledSslProtocols
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public EncryptionPolicy EncryptionPolicy
	{
		 set { } //Length: 129
	}

	public string TargetHost
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SslClientAuthenticationOptions() { }

	public bool get_AllowRenegotiation() { }

	[CompilerGenerated]
	public X509CertificateCollection get_ClientCertificates() { }

	public SslProtocols get_EnabledSslProtocols() { }

	[CompilerGenerated]
	public string get_TargetHost() { }

	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[CompilerGenerated]
	public void set_ClientCertificates(X509CertificateCollection value) { }

	public void set_EnabledSslProtocols(SslProtocols value) { }

	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[CompilerGenerated]
	public void set_TargetHost(string value) { }

}

