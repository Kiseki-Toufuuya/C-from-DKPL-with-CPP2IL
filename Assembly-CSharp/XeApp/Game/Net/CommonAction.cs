namespace XeApp.Game.Net;

public class CommonAction
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<UIResult> <>9__24_0; //Field offset: 0x4
		public static Action<UIResult> <>9__24_1; //Field offset: 0x8
		public static Action<UIResult> <>9__24_2; //Field offset: 0xC
		public static Action<UIResult> <>9__24_3; //Field offset: 0x10
		public static Action<UIResult> <>9__24_4; //Field offset: 0x14

		private static <>c() { }

		public <>c() { }

		internal void <Call>b__24_0(UIResult a) { }

		internal void <Call>b__24_1(UIResult a) { }

		internal void <Call>b__24_2(UIResult a) { }

		internal void <Call>b__24_3(UIResult a) { }

		internal void <Call>b__24_4(UIResult a) { }

	}

	[CompilerGenerated]
	private struct <Call>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CommonAction <>4__this; //Field offset: 0x10
		public Func<Task> sendAsyncGetOrThrow; //Field offset: 0x14
		private int <retryCount>5__2; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C
		private AppCustomErrorInfo <customError>5__3; //Field offset: 0x20
		private TaskAwaiter<UIResult> <>u__2; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private int <RetryMaxCount>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <RetryInterval>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <LocationID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <ActionName>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Func<Exception, Boolean> <CustomErrorFilter>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <SecurityPriority>k__BackingField; //Field offset: 0x1C

	public string ActionName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Func<Exception, Boolean> CustomErrorFilter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int LocationID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
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

	public CommonAction() { }

	[AsyncStateMachine(typeof(<Call>d__24))]
	public Task Call(Func<Task> sendAsyncGetOrThrow) { }

	[CompilerGenerated]
	public string get_ActionName() { }

	[CompilerGenerated]
	public Func<Exception, Boolean> get_CustomErrorFilter() { }

	[CompilerGenerated]
	public int get_LocationID() { }

	[CompilerGenerated]
	public int get_RetryInterval() { }

	[CompilerGenerated]
	public int get_RetryMaxCount() { }

	[CompilerGenerated]
	public int get_SecurityPriority() { }

	[CompilerGenerated]
	public void set_ActionName(string value) { }

	[CompilerGenerated]
	public void set_CustomErrorFilter(Func<Exception, Boolean> value) { }

	[CompilerGenerated]
	public void set_LocationID(int value) { }

	[CompilerGenerated]
	public void set_RetryInterval(int value) { }

	[CompilerGenerated]
	public void set_RetryMaxCount(int value) { }

	[CompilerGenerated]
	public void set_SecurityPriority(int value) { }

}

