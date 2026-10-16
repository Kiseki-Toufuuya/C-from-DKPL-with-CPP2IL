namespace Sony.PS4.SaveData;

internal static class DispatchQueueThread
{
	private static Thread thread; //Field offset: 0x0
	private static bool stopThread; //Field offset: 0x4
	private static Semaphore workLoad; //Field offset: 0x8
	private static object syncQueue; //Field offset: 0xC
	private static Queue<SaveDataCallbackEvent> pendingQueue; //Field offset: 0x10

	private static DispatchQueueThread() { }

	internal static bool IsSameThread() { }

	internal static void ThrowExceptionIfSameThread(bool asyncRequest) { }

}

