namespace Cysharp.Threading.Tasks.Triggers;

public abstract class AsyncTriggerBase : MonoBehaviour
{
	private sealed class AsyncTriggerEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, ITriggerHandler<T>
	{
		private static Action<Object> cancellationCallback; //Field offset: 0x0
		private readonly AsyncTriggerBase<T> parent; //Field offset: 0x0
		private CancellationToken cancellationToken; //Field offset: 0x0
		private CancellationTokenRegistration registration; //Field offset: 0x0
		private bool isDisposed; //Field offset: 0x0
		[CompilerGenerated]
		private T <Current>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

		private T Current
		{
			[CompilerGenerated]
			private set { } //Length: 34
		}

		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 27
		}

		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
		{
			[CompilerGenerated]
			private get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 27
		}

		private static AsyncTriggerEnumerator() { }

		public AsyncTriggerEnumerator(AsyncTriggerBase<T> parent, CancellationToken cancellationToken) { }

		private static void CancellationCallback(object state) { }

		[CompilerGenerated]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

		[CompilerGenerated]
		private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

		[CompilerGenerated]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

		[CompilerGenerated]
		private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

		public override UniTask DisposeAsync() { }

		public override void OnCompleted() { }

		public override void OnNext(T value) { }

		[CompilerGenerated]
		private void set_Current(T value) { }

	}

	private class AwakeMonitor : IPlayerLoopItem
	{
		private readonly AsyncTriggerBase<T> trigger; //Field offset: 0x0

		public AwakeMonitor(AsyncTriggerBase<T> trigger) { }

		public override bool MoveNext() { }

	}

	private TriggerEvent<T> triggerEvent; //Field offset: 0x0
	protected private bool calledAwake; //Field offset: 0x0
	protected private bool calledDestroy; //Field offset: 0x0

	protected AsyncTriggerBase`1() { }

	internal void AddHandler(ITriggerHandler<T> handler) { }

	private void Awake() { }

	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

	private void OnDestroy() { }

	protected void RaiseEvent(T value) { }

	internal void RemoveHandler(ITriggerHandler<T> handler) { }

}

