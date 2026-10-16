namespace Cysharp.Threading.Tasks;

[IsReadOnly]
public struct YieldAwaitable
{
	[IsReadOnly]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly PlayerLoopTiming timing; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 3
		}

		public Awaiter(PlayerLoopTiming timing) { }

		public bool get_IsCompleted() { }

		public void GetResult() { }

		public override void OnCompleted(Action continuation) { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly PlayerLoopTiming timing; //Field offset: 0x0

	public YieldAwaitable(PlayerLoopTiming timing) { }

	public Awaiter GetAwaiter() { }

}

