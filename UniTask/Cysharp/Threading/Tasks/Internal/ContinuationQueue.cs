namespace Cysharp.Threading.Tasks.Internal;

internal sealed class ContinuationQueue
{
	private readonly PlayerLoopTiming timing; //Field offset: 0x8
	private SpinLock gate; //Field offset: 0xC
	private bool dequing; //Field offset: 0x10
	private int actionListCount; //Field offset: 0x14
	private Action[] actionList; //Field offset: 0x18
	private int waitingListCount; //Field offset: 0x1C
	private Action[] waitingList; //Field offset: 0x20

	public ContinuationQueue(PlayerLoopTiming timing) { }

	public void Enqueue(Action continuation) { }

	public void Run() { }

	[DebuggerHidden]
	private void RunCore() { }

}

