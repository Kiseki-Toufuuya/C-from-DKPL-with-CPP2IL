namespace Cysharp.Threading.Tasks;

public class UniTaskSynchronizationContext : SynchronizationContext
{
	[IsReadOnly]
	private struct Callback
	{
		private readonly SendOrPostCallback callback; //Field offset: 0x0
		private readonly object state; //Field offset: 0x4

		public void Invoke() { }

	}

	private static SpinLock gate; //Field offset: 0x0
	private static bool dequing; //Field offset: 0x4
	private static int actionListCount; //Field offset: 0x8
	private static Callback[] actionList; //Field offset: 0xC
	private static int waitingListCount; //Field offset: 0x10
	private static Callback[] waitingList; //Field offset: 0x14

	private static UniTaskSynchronizationContext() { }

	internal static void Run() { }

}

