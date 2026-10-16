namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDestroyTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__7_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OnDestroyAsync>b__7_0(object state) { }

	}

	private class AwakeMonitor : IPlayerLoopItem
	{
		private readonly AsyncDestroyTrigger trigger; //Field offset: 0x8

		public AwakeMonitor(AsyncDestroyTrigger trigger) { }

		public override bool MoveNext() { }

	}

	private bool awakeCalled; //Field offset: 0x10
	private bool called; //Field offset: 0x11
	private CancellationTokenSource cancellationTokenSource; //Field offset: 0x14

	public CancellationToken CancellationToken
	{
		 get { } //Length: 206
	}

	public AsyncDestroyTrigger() { }

	private void Awake() { }

	public CancellationToken get_CancellationToken() { }

	private void OnDestroy() { }

	public UniTask OnDestroyAsync() { }

}

