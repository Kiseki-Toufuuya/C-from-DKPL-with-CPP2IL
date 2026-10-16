namespace System.Net.Security;

public abstract class AuthenticatedStream : Stream
{
	private Stream _InnerStream; //Field offset: 0x14
	private bool _LeaveStreamOpen; //Field offset: 0x18

	protected Stream InnerStream
	{
		 get { } //Length: 11
	}

	public abstract bool IsAuthenticated
	{
		 get { } //Length: 0
	}

	protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen) { }

	protected virtual void Dispose(bool disposing) { }

	protected Stream get_InnerStream() { }

	public abstract bool get_IsAuthenticated() { }

}

