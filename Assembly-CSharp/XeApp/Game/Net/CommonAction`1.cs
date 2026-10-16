namespace XeApp.Game.Net;

public class CommonAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TResult> <>9; //Field offset: 0x0
		public static Action<UIResult> <>9__17_0; //Field offset: 0x0
		public static Action<UIResult> <>9__17_1; //Field offset: 0x0
		public static Action<UIResult> <>9__17_2; //Field offset: 0x0
		public static Action<UIResult> <>9__17_3; //Field offset: 0x0
		public static Action<UIResult> <>9__17_4; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <Call>b__17_0(UIResult a) { }

		internal void <Call>b__17_1(UIResult a) { }

		internal void <Call>b__17_2(UIResult a) { }

		internal void <Call>b__17_3(UIResult a) { }

		internal void <Call>b__17_4(UIResult a) { }

	}

	[CompilerGenerated]
	private struct <Call>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TResult> <>t__builder; //Field offset: 0x0
		public CommonAction<TResult> <>4__this; //Field offset: 0x0
		public Func<Task`1<TResult>> sendAsyncGetOrThrow; //Field offset: 0x0
		private int <retryCount>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<TResult> <>u__2; //Field offset: 0x0
		private AppCustomErrorInfo <customError>5__3; //Field offset: 0x0
		private TaskAwaiter<UIResult> <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private int <RetryMaxCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <RetryInterval>k__BackingField; //Field offset: 0x0
	public int LocationID; //Field offset: 0x0
	[CompilerGenerated]
	private Func<Exception, Boolean> <CustomErrorFilter>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <SecurityPriority>k__BackingField; //Field offset: 0x0

	public Func<Exception, Boolean> CustomErrorFilter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int RetryInterval
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int RetryMaxCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int SecurityPriority
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CommonAction`1() { }

	[AsyncStateMachine(typeof(<Call>d__17))]
	public Task<TResult> Call(Func<Task`1<TResult>> sendAsyncGetOrThrow) { }

	[CompilerGenerated]
	public Func<Exception, Boolean> get_CustomErrorFilter() { }

	[CompilerGenerated]
	public int get_RetryInterval() { }

	[CompilerGenerated]
	public int get_RetryMaxCount() { }

	[CompilerGenerated]
	public int get_SecurityPriority() { }

	[CompilerGenerated]
	public void set_CustomErrorFilter(Func<Exception, Boolean> value) { }

	[CompilerGenerated]
	public void set_RetryInterval(int value) { }

	[CompilerGenerated]
	public void set_RetryMaxCount(int value) { }

	[CompilerGenerated]
	public void set_SecurityPriority(int value) { }

}

