namespace Mono.Security.Protocol.Ntlm;

public abstract class MessageBase
{
	private static Byte[] header; //Field offset: 0x0
	private int _type; //Field offset: 0x8
	private NtlmFlags _flags; //Field offset: 0xC

	public NtlmFlags Flags
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int Type
	{
		 get { } //Length: 11
	}

	private static MessageBase() { }

	protected MessageBase(int messageType) { }

	protected bool CheckHeader(Byte[] message) { }

	protected override void Decode(Byte[] message) { }

	public NtlmFlags get_Flags() { }

	public int get_Type() { }

	public abstract Byte[] GetBytes() { }

	protected Byte[] PrepareMessage(int messageSize) { }

	public void set_Flags(NtlmFlags value) { }

}

