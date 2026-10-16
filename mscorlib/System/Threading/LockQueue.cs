namespace System.Threading;

internal class LockQueue
{
	private ReaderWriterLock rwlock; //Field offset: 0x8
	private int lockCount; //Field offset: 0xC

	public bool IsEmpty
	{
		 get { } //Length: 314
	}

	public LockQueue(ReaderWriterLock rwlock) { }

	public bool get_IsEmpty() { }

	public void Pulse() { }

	public bool Wait(int timeout) { }

}

