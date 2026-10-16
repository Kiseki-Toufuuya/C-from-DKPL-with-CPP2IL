namespace Mono.Net.Security;

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; //Field offset: 0x28

	protected int CurrentSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	protected BufferOffsetSize UserBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[CompilerGenerated]
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	protected void set_CurrentSize(int value) { }

	public virtual string ToString() { }

}

