namespace System.Runtime;

[Extension]
internal static class TaskExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public TaskCompletionSource<Object> tcs; //Field offset: 0x8
		public AsyncCallback callback; //Field offset: 0xC

		public <>c__DisplayClass1_0() { }

		internal void <AsAsyncResult>b__0(Task t) { }

	}


	[Extension]
	public static IAsyncResult AsAsyncResult(Task task, AsyncCallback callback, object state) { }

}

