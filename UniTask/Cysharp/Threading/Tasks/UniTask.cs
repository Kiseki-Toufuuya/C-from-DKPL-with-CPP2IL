namespace Cysharp.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder))]
[IsReadOnly]
public struct UniTask
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UniTask <.cctor>b__176_0() { }

	}

	[IsReadOnly]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly UniTask task; //Field offset: 0x0

		public bool IsCompleted
		{
			[DebuggerHidden]
			 get { } //Length: 131
		}

		[DebuggerHidden]
		public Awaiter(in UniTask task) { }

		[DebuggerHidden]
		public bool get_IsCompleted() { }

		[DebuggerHidden]
		public void GetResult() { }

		[DebuggerHidden]
		public override void OnCompleted(Action continuation) { }

		[DebuggerHidden]
		public void SourceOnCompleted(Action<Object> continuation, object state) { }

		[DebuggerHidden]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	private sealed class CanceledResultSource : IUniTaskSource
	{
		private readonly CancellationToken cancellationToken; //Field offset: 0x8

		public CanceledResultSource(CancellationToken cancellationToken) { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class DelayFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayFramePromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<DelayFramePromise> pool; //Field offset: 0x0
		private DelayFramePromise nextNode; //Field offset: 0x8
		private int initialFrame; //Field offset: 0xC
		private int delayFrameCount; //Field offset: 0x10
		private CancellationToken cancellationToken; //Field offset: 0x14
		private int currentFrameCount; //Field offset: 0x18
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x1C

		public override DelayFramePromise NextNode
		{
			 get { } //Length: 11
		}

		private static DelayFramePromise() { }

		private DelayFramePromise() { }

		public static IUniTaskSource Create(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override DelayFramePromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class DelayIgnoreTimeScalePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayIgnoreTimeScalePromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<DelayIgnoreTimeScalePromise> pool; //Field offset: 0x0
		private DelayIgnoreTimeScalePromise nextNode; //Field offset: 0x8
		private float delayFrameTimeSpan; //Field offset: 0xC
		private float elapsed; //Field offset: 0x10
		private int initialFrame; //Field offset: 0x14
		private CancellationToken cancellationToken; //Field offset: 0x18
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x1C

		public override DelayIgnoreTimeScalePromise NextNode
		{
			 get { } //Length: 11
		}

		private static DelayIgnoreTimeScalePromise() { }

		private DelayIgnoreTimeScalePromise() { }

		public static IUniTaskSource Create(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override DelayIgnoreTimeScalePromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class DelayPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayPromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<DelayPromise> pool; //Field offset: 0x0
		private DelayPromise nextNode; //Field offset: 0x8
		private int initialFrame; //Field offset: 0xC
		private float delayTimeSpan; //Field offset: 0x10
		private float elapsed; //Field offset: 0x14
		private CancellationToken cancellationToken; //Field offset: 0x18
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x1C

		public override DelayPromise NextNode
		{
			 get { } //Length: 11
		}

		private static DelayPromise() { }

		private DelayPromise() { }

		public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override DelayPromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class DelayRealtimePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayRealtimePromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<DelayRealtimePromise> pool; //Field offset: 0x0
		private DelayRealtimePromise nextNode; //Field offset: 0x8
		private long delayTimeSpanTicks; //Field offset: 0x10
		private ValueStopwatch stopwatch; //Field offset: 0x18
		private CancellationToken cancellationToken; //Field offset: 0x20
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x24

		public override DelayRealtimePromise NextNode
		{
			 get { } //Length: 11
		}

		private static DelayRealtimePromise() { }

		private DelayRealtimePromise() { }

		public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override DelayRealtimePromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class ExceptionResultSource : IUniTaskSource
	{
		private readonly ExceptionDispatchInfo exception; //Field offset: 0x8
		private bool calledGet; //Field offset: 0xC

		public ExceptionResultSource(Exception exception) { }

		protected virtual void Finalize() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class NextFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<NextFramePromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<NextFramePromise> pool; //Field offset: 0x0
		private NextFramePromise nextNode; //Field offset: 0x8
		private int frameCount; //Field offset: 0xC
		private CancellationToken cancellationToken; //Field offset: 0x10
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x14

		public override NextFramePromise NextNode
		{
			 get { } //Length: 11
		}

		private static NextFramePromise() { }

		private NextFramePromise() { }

		public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override NextFramePromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class WaitUntilPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilPromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<WaitUntilPromise> pool; //Field offset: 0x0
		private WaitUntilPromise nextNode; //Field offset: 0x8
		private Func<Boolean> predicate; //Field offset: 0xC
		private CancellationToken cancellationToken; //Field offset: 0x10
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x14

		public override WaitUntilPromise NextNode
		{
			 get { } //Length: 11
		}

		private static WaitUntilPromise() { }

		private WaitUntilPromise() { }

		public static IUniTaskSource Create(Func<Boolean> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override WaitUntilPromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class WaitWhilePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitWhilePromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<WaitWhilePromise> pool; //Field offset: 0x0
		private WaitWhilePromise nextNode; //Field offset: 0x8
		private Func<Boolean> predicate; //Field offset: 0xC
		private CancellationToken cancellationToken; //Field offset: 0x10
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x14

		public override WaitWhilePromise NextNode
		{
			 get { } //Length: 11
		}

		private static WaitWhilePromise() { }

		private WaitWhilePromise() { }

		public static IUniTaskSource Create(Func<Boolean> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override WaitWhilePromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class WhenAllPromise : IUniTaskSource
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<Object> <>9__3_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			internal void <.ctor>b__3_0(object state) { }

		}

		private int completeCount; //Field offset: 0x8
		private int tasksLength; //Field offset: 0xC
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x10

		public WhenAllPromise(UniTask[] tasks, int tasksLength) { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private static void TryInvokeContinuation(WhenAllPromise self, in Awaiter awaiter) { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private sealed class YieldPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<YieldPromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		private static TaskPool<YieldPromise> pool; //Field offset: 0x0
		private YieldPromise nextNode; //Field offset: 0x8
		private CancellationToken cancellationToken; //Field offset: 0xC
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x10

		public override YieldPromise NextNode
		{
			 get { } //Length: 11
		}

		private static YieldPromise() { }

		private YieldPromise() { }

		public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override YieldPromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

	}

	private static readonly UniTask CanceledUniTask; //Field offset: 0x0
	public static readonly UniTask CompletedTask; //Field offset: 0x8
	private readonly IUniTaskSource source; //Field offset: 0x0
	private readonly short token; //Field offset: 0x4

	public UniTaskStatus Status
	{
		[DebuggerHidden]
		 get { } //Length: 72
	}

	private static UniTask() { }

	[DebuggerHidden]
	public UniTask(IUniTaskSource source, short token) { }

	public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	public static UniTask DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	public static UniTask FromCanceled(CancellationToken cancellationToken = null) { }

	public static UniTask FromException(Exception ex) { }

	[DebuggerHidden]
	public UniTaskStatus get_Status() { }

	[DebuggerHidden]
	public Awaiter GetAwaiter() { }

	public static UniTask NextFrame() { }

	public static UniTask NextFrame(CancellationToken cancellationToken) { }

	public virtual string ToString() { }

	public static void Void(Func<UniTaskVoid> asyncAction) { }

	public static UniTask WaitUntil(Func<Boolean> predicate, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	public static UniTask WaitWhile(Func<Boolean> predicate, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	public static UniTask WhenAll(UniTask[] tasks) { }

	public static UniTask Yield(CancellationToken cancellationToken) { }

	public static YieldAwaitable Yield() { }

}

