namespace Cysharp.Threading.Tasks;

[Extension]
public static class EnumeratorAsyncExtensions
{
	private sealed class EnumeratorPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<EnumeratorPromise>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <.cctor>b__4_0() { }

		}

		[CompilerGenerated]
		private sealed class <ConsumeEnumerator>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private object <>2__current; //Field offset: 0xC
			public IEnumerator enumerator; //Field offset: 0x10
			private CustomYieldInstruction <cyi>5__2; //Field offset: 0x14
			private IEnumerator <innerCoroutine>5__3; //Field offset: 0x18

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			[DebuggerHidden]
			public <ConsumeEnumerator>d__19(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class <UnwrapWaitAsyncOperation>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private object <>2__current; //Field offset: 0xC
			public AsyncOperation asyncOperation; //Field offset: 0x10

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			[DebuggerHidden]
			public <UnwrapWaitAsyncOperation>d__22(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[CompilerGenerated]
		private sealed class <UnwrapWaitForSeconds>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private object <>2__current; //Field offset: 0xC
			public WaitForSeconds waitForSeconds; //Field offset: 0x10
			private float <second>5__2; //Field offset: 0x14
			private float <elapsed>5__3; //Field offset: 0x18

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			[DebuggerHidden]
			public <UnwrapWaitForSeconds>d__21(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private static TaskPool<EnumeratorPromise> pool; //Field offset: 0x0
		private static readonly FieldInfo waitForSeconds_Seconds; //Field offset: 0xC
		private EnumeratorPromise nextNode; //Field offset: 0x8
		private IEnumerator innerEnumerator; //Field offset: 0xC
		private CancellationToken cancellationToken; //Field offset: 0x10
		private int initialFrame; //Field offset: 0x14
		private bool loopRunning; //Field offset: 0x18
		private bool calledGetResult; //Field offset: 0x19
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x1C

		public override EnumeratorPromise NextNode
		{
			 get { } //Length: 11
		}

		private static EnumeratorPromise() { }

		private EnumeratorPromise() { }

		[IteratorStateMachine(typeof(<ConsumeEnumerator>d__19))]
		private static IEnumerator ConsumeEnumerator(IEnumerator enumerator) { }

		public static IUniTaskSource Create(IEnumerator innerEnumerator, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		public override EnumeratorPromise get_NextNode() { }

		public override void GetResult(short token) { }

		public override UniTaskStatus GetStatus(short token) { }

		public override bool MoveNext() { }

		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		private bool TryReturn() { }

		public override UniTaskStatus UnsafeGetStatus() { }

		[IteratorStateMachine(typeof(<UnwrapWaitAsyncOperation>d__22))]
		private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation) { }

		[IteratorStateMachine(typeof(<UnwrapWaitForSeconds>d__21))]
		private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds) { }

	}


	[Extension]
	public static Awaiter GetAwaiter(T enumerator) { }

}

