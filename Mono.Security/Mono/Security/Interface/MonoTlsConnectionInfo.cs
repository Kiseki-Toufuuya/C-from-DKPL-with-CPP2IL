namespace Mono.Security.Interface;

public class MonoTlsConnectionInfo
{
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; //Field offset: 0x10

	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public string PeerDomainName
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public TlsProtocols ProtocolVersion
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public MonoTlsConnectionInfo() { }

	[CompilerGenerated]
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	public void set_PeerDomainName(string value) { }

	[CompilerGenerated]
	public void set_ProtocolVersion(TlsProtocols value) { }

	public virtual string ToString() { }

}

