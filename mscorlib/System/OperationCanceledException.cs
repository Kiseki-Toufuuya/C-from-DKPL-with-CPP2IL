namespace System;

public class OperationCanceledException : SystemException
{
	private CancellationToken _cancellationToken; //Field offset: 0x48

	public private CancellationToken CancellationToken
	{
		 get { } //Length: 11
		private set { } //Length: 28
	}

	public OperationCanceledException() { }

	public OperationCanceledException(string message) { }

	public OperationCanceledException(CancellationToken token) { }

	public OperationCanceledException(string message, CancellationToken token) { }

	protected OperationCanceledException(SerializationInfo info, StreamingContext context) { }

	public CancellationToken get_CancellationToken() { }

	private void set_CancellationToken(CancellationToken value) { }

}

