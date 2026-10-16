namespace XeApp.Game.Net;

public class GVC
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<PropertyViolationEvent> <>9__1_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <iwcXcmwRKvgX4Ws4RPFKUfrp>b__1_0(PropertyViolationEvent arg) { }

	}

	[CompilerGenerated]
	private struct <Check>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		private TaskAwaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <eQVHCkh6caQJvbmthEPYvnyS>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static bool occured; //Field offset: 0x0

	public GVC() { }

	[AsyncStateMachine(typeof(<Check>d__2))]
	public static Task Check() { }

	[AsyncStateMachine(typeof(<eQVHCkh6caQJvbmthEPYvnyS>d__3))]
	private static Task eQVHCkh6caQJvbmthEPYvnyS(StackTrace stackTrace) { }

	[RuntimeInitializeOnLoadMethod]
	public static void iwcXcmwRKvgX4Ws4RPFKUfrp() { }

}

