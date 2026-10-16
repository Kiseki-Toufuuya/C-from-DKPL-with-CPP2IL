namespace Cysharp.Threading.Tasks;

[Extension]
public static class DOTweenAsyncExtensions
{
	private enum CallbackType
	{
		Kill = 0,
		Complete = 1,
		Pause = 2,
		Play = 3,
		Rewind = 4,
		StepComplete = 5,
	}

	internal struct TweenAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Tween tween; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 22
		}

		public TweenAwaiter(Tween tween) { }

		public bool get_IsCompleted() { }

		public void GetResult() { }

		public override void OnCompleted(Action continuation) { }

		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private sealed class TweenConfiguredSource : IUniTaskSource, ITaskPoolNode<TweenConfiguredSource>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<TweenConfiguredSource> pool; //Field offset: 0x0
		private TweenConfiguredSource nextNode; //Field offset: 0x8
		private readonly TweenCallback onCompleteCallbackDelegate; //Field offset: 0xC
		private readonly TweenCallback onUpdateDelegate; //Field offset: 0x10
		private Tween tween; //Field offset: 0x14
		private TweenCancelBehaviour cancelBehaviour; //Field offset: 0x18
		private CancellationToken cancellationToken; //Field offset: 0x1C
		private CallbackType callbackType; //Field offset: 0x20
		private bool canceled; //Field offset: 0x24
		private TweenCallback originalUpdateAction; //Field offset: 0x28
		private TweenCallback originalCompleteAction; //Field offset: 0x2C
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x30

		public override TweenConfiguredSource NextNode
		{
			 get { } //Length: 11
		}

		private static TweenConfiguredSource() { }

		private TweenConfiguredSource() { }

		public static IUniTaskSource Create(Tween tween, TweenCancelBehaviour cancelBehaviour, CancellationToken cancellationToken, CallbackType callbackType, out short token) { }

		private static void DoCancelBeforeCreate(Tween tween, TweenCancelBehaviour tweenCancelBehaviour) { }

		public override TweenConfiguredSource get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		private void OnCompleteCallbackDelegate() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private void OnUpdate() { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}


	[Extension]
	public static TweenAwaiter GetAwaiter(Tween tween) { }

	[Extension]
	public static UniTask ToUniTask(Tween tween, TweenCancelBehaviour tweenCancelBehaviour = 0, CancellationToken cancellationToken = null) { }

}

