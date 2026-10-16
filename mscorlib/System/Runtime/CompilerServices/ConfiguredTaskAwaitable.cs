namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		internal readonly Task m_task; //Field offset: 0x0
		internal readonly bool m_continueOnCapturedContext; //Field offset: 0x4

		public bool IsCompleted
		{
			 get { } //Length: 5588
		}

		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext) { }

		public bool get_IsCompleted() { }

		[StackTraceHidden]
		public void GetResult() { }

		public override void OnCompleted(Action continuation) { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter; //Field offset: 0x0

	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext) { }

	public ConfiguredTaskAwaiter GetAwaiter() { }

}

