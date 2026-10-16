namespace Cysharp.Threading.Tasks.Internal;

internal sealed class PlayerLoopRunner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Exception> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__9_0(Exception ex) { }

	}

	private readonly PlayerLoopTiming timing; //Field offset: 0x8
	private readonly object runningAndQueueLock; //Field offset: 0xC
	private readonly object arrayLock; //Field offset: 0x10
	private readonly Action<Exception> unhandledExceptionCallback; //Field offset: 0x14
	private int tail; //Field offset: 0x18
	private bool running; //Field offset: 0x1C
	private IPlayerLoopItem[] loopItems; //Field offset: 0x20
	private MinimumQueue<IPlayerLoopItem> waitQueue; //Field offset: 0x24

	public PlayerLoopRunner(PlayerLoopTiming timing) { }

	public void AddAction(IPlayerLoopItem item) { }

	public void Run() { }

	[DebuggerHidden]
	private void RunCore() { }

}

