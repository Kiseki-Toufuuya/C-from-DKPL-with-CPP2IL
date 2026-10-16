namespace XeApp.Game.Net;

public class ODMGenericRequest
{
	[CompilerGenerated]
	private struct <RequestAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Response> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestWithAuthorizeAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Response> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class Response
	{
		public Dictionary<String, Dictionary`2<String, GuardString>> KeyValues; //Field offset: 0x8
		public long lastGetTime; //Field offset: 0x10

		public Response() { }

	}


	public ODMGenericRequest() { }

	[AsyncStateMachine(typeof(<RequestAsync>d__1))]
	public Task<Response> RequestAsync(String[] keys, Func<Exception, Boolean> ErrorFilter) { }

	[AsyncStateMachine(typeof(<RequestWithAuthorizeAsync>d__2))]
	public Task<Response> RequestWithAuthorizeAsync(String[] keys, Func<Exception, Boolean> ErrorFilter) { }

}

