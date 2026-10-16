namespace XeApp.Game.Net;

public static class StorageCacheClear
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string targetDirectory; //Field offset: 0x8
		public Func<String, Boolean> onExcludeFilter; //Field offset: 0xC
		public Action<Int32> onFinish; //Field offset: 0x10
		public SendOrPostCallback <>9__1; //Field offset: 0x14

		public <>c__DisplayClass11_0() { }

		internal void <BrokenStart>b__0() { }

		internal void <BrokenStart>b__1(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string targetDirectory; //Field offset: 0x8
		public Func<String, Boolean> onExcludeFilter; //Field offset: 0xC
		public Action<Int32> onFinish; //Field offset: 0x10
		public SendOrPostCallback <>9__1; //Field offset: 0x14

		public <>c__DisplayClass2_0() { }

		internal void <Start>b__0() { }

		internal void <Start>b__1(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DateTime ct; //Field offset: 0x8
		public int days; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <ClearOldFile>b__0(string filePath) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public DateTime ct; //Field offset: 0x8
		public int days; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <ClearOldFileV2>b__0(string filePath) { }

	}

	[CompilerGenerated]
	private struct <BrokenStart>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string targetDirectory; //Field offset: 0x10
		public Func<String, Boolean> onExcludeFilter; //Field offset: 0x14
		public Action<Int32> onFinish; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClearOldFile>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int days; //Field offset: 0x10
		public string targetDirectory; //Field offset: 0x14
		public Action<Int32> onFinish; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string targetDirectory; //Field offset: 0x10
		public Func<String, Boolean> onExcludeFilter; //Field offset: 0x14
		public Action<Int32> onFinish; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static int clearCount; //Field offset: 0x0
	private static bool processing; //Field offset: 0x4

	private static void BrakeDirectory(string dir, Func<String, Boolean> onExcludeFilter) { }

	private static int BrakeDirectorySub(string dir, Func<String, Boolean> onExcludeFilter) { }

	[AsyncStateMachine(typeof(<BrokenStart>d__11))]
	public static Task BrokenStart(string targetDirectory, Func<String, Boolean> onExcludeFilter, Action<Int32> onFinish) { }

	[AsyncStateMachine(typeof(<ClearOldFile>d__3))]
	public static Task ClearOldFile(string targetDirectory, int days, Action<Int32> onFinish) { }

	public static void ClearOldFileV2(string targetDirectory, int days) { }

	private static void DeleteDirectoryWapper(string path) { }

	private static void DeleteWrapper(string path) { }

	private static void RemoveDirectory(string dir, Func<String, Boolean> onExcludeFilter) { }

	private static int RemoveDirectorySub(string dir, Func<String, Boolean> onExcludeFilter) { }

	[AsyncStateMachine(typeof(<Start>d__2))]
	public static Task Start(string targetDirectory, Func<String, Boolean> onExcludeFilter, Action<Int32> onFinish) { }

}

