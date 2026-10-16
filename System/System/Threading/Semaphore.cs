namespace System.Threading;

[ComVisible(False)]
public sealed class Semaphore : WaitHandle
{

	public Semaphore(int initialCount, int maximumCount) { }

	public Semaphore(int initialCount, int maximumCount, string name) { }

	private static IntPtr CreateSemaphore_icall(int initialCount, int maximumCount, Char* name, int name_length, out int errorCode) { }

	internal static IntPtr CreateSemaphore_internal(int initialCount, int maximumCount, string name, out int errorCode) { }

	[PrePrepareMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int Release() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int Release(int releaseCount) { }

	internal static bool ReleaseSemaphore_internal(IntPtr handle, int releaseCount, out int previousCount) { }

}

