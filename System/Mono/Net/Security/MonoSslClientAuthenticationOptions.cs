namespace Mono.Net.Security;

internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; //Field offset: 0xC

	public virtual bool AllowRenegotiation
	{
		 get { } //Length: 23
	}

	public virtual X509RevocationMode CertificateRevocationCheckMode
	{
		 set { } //Length: 34
	}

	public virtual bool ClientCertificateRequired
	{
		 get { } //Length: 47
	}

	public virtual X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 23
		 set { } //Length: 39
	}

	public virtual SslProtocols EnabledSslProtocols
	{
		 get { } //Length: 23
		 set { } //Length: 26
	}

	public virtual EncryptionPolicy EncryptionPolicy
	{
		 set { } //Length: 34
	}

	public SslClientAuthenticationOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual X509Certificate ServerCertificate
	{
		 get { } //Length: 47
	}

	public virtual bool ServerMode
	{
		 get { } //Length: 3
	}

	public virtual string TargetHost
	{
		 get { } //Length: 23
		 set { } //Length: 39
	}

	public MonoSslClientAuthenticationOptions() { }

	public virtual bool get_AllowRenegotiation() { }

	public virtual bool get_ClientCertificateRequired() { }

	public virtual X509CertificateCollection get_ClientCertificates() { }

	public virtual SslProtocols get_EnabledSslProtocols() { }

	[CompilerGenerated]
	public SslClientAuthenticationOptions get_Options() { }

	public virtual X509Certificate get_ServerCertificate() { }

	public virtual bool get_ServerMode() { }

	public virtual string get_TargetHost() { }

	public virtual void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	public virtual void set_ClientCertificates(X509CertificateCollection value) { }

	public virtual void set_EnabledSslProtocols(SslProtocols value) { }

	public virtual void set_EncryptionPolicy(EncryptionPolicy value) { }

	public virtual void set_TargetHost(string value) { }

}

