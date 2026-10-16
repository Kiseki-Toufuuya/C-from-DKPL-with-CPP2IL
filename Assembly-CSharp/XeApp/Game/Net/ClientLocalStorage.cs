namespace XeApp.Game.Net;

public class ClientLocalStorage
{
	[CompilerGenerated]
	private struct <LoadAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public ClientLocalStorage <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public ClientLocalStorage <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static ClientLocalStorage instance; //Field offset: 0x0
	public string SavePath; //Field offset: 0x8
	public InMemoryStorage InMemoryStorage; //Field offset: 0xC

	public static ClientLocalStorage Instance
	{
		 get { } //Length: 204
	}

	public ClientLocalStorage() { }

	[CompilerGenerated]
	private void <LoadAsync>b__7_0() { }

	[CompilerGenerated]
	private void <SaveAsync>b__9_0() { }

	public static ClientLocalStorage get_Instance() { }

	public void Load() { }

	[AsyncStateMachine(typeof(<LoadAsync>d__7))]
	public Task LoadAsync() { }

	public void Save() { }

	[AsyncStateMachine(typeof(<SaveAsync>d__9))]
	public Task SaveAsync() { }

}

