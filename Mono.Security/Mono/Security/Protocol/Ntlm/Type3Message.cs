namespace Mono.Security.Protocol.Ntlm;

public class Type3Message : MessageBase
{
	private NtlmAuthLevel _level; //Field offset: 0x10
	private Byte[] _challenge; //Field offset: 0x14
	private string _host; //Field offset: 0x18
	private string _domain; //Field offset: 0x1C
	private string _username; //Field offset: 0x20
	private string _password; //Field offset: 0x24
	private Type2Message _type2; //Field offset: 0x28
	private Byte[] _lm; //Field offset: 0x2C
	private Byte[] _nt; //Field offset: 0x30

	public string Domain
	{
		 set { } //Length: 104
	}

	public string Password
	{
		 set { } //Length: 27
	}

	public string Username
	{
		 set { } //Length: 27
	}

	public Type3Message(Type2Message type2) { }

	protected virtual void Decode(Byte[] message) { }

	private string DecodeString(Byte[] buffer, int offset, int len) { }

	private Byte[] EncodeString(string text) { }

	protected virtual void Finalize() { }

	public virtual Byte[] GetBytes() { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_Username(string value) { }

}

