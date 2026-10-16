namespace Mono.Net.Security;

internal class AsyncProtocolResult
{
	[CompilerGenerated]
	private readonly int <UserResult>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; //Field offset: 0xC

	public ExceptionDispatchInfo Error
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int UserResult
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public AsyncProtocolResult(int result) { }

	public AsyncProtocolResult(ExceptionDispatchInfo error) { }

	[CompilerGenerated]
	public ExceptionDispatchInfo get_Error() { }

	[CompilerGenerated]
	public int get_UserResult() { }

}

