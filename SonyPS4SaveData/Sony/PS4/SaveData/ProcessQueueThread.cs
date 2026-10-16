namespace Sony.PS4.SaveData;

internal static class ProcessQueueThread
{
	private static bool stopThread; //Field offset: 0x0
	private static Semaphore workLoad; //Field offset: 0x4
	private static object syncQueue; //Field offset: 0x8
	private static int nextRequestId; //Field offset: 0xC
	private static ManualResetEvent syncTaskCompleted; //Field offset: 0x10
	private static List<PendingRequest> completedSyncRequests; //Field offset: 0x14
	private static object completedLock; //Field offset: 0x18
	private static Queue<PendingRequest> pendingQueue; //Field offset: 0x1C
	private static List<PendingRequest> pollingList; //Field offset: 0x20

	private static ProcessQueueThread() { }

	internal static PendingRequest AddEvent(RequestBase request, ResponseBase response) { }

	private static bool RemoveCompletedSyncRequest(PendingRequest pe) { }

	internal static int WaitIfSyncRequest(PendingRequest pendingEvent) { }

}

