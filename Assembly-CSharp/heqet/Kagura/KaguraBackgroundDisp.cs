namespace Heqet.Kagura;

public class KaguraBackgroundDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public KaguraBackgroundDisp <>4__this; //Field offset: 0x8
		public AssetBundleLoadAssetOperation ope; //Field offset: 0xC

		public <>c__DisplayClass15_0() { }

		internal void <InitializeBackGroungImage>b__0(AssetBundleLoadAssetOperation operation) { }

		internal bool <InitializeBackGroungImage>b__1() { }

	}

	[CompilerGenerated]
	private struct <InitializeBackGroungImage>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public KaguraBackgroundDisp <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeMovie>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public KaguraBackgroundDisp <>4__this; //Field offset: 0xC
		public int movieId; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public KaguraBackgroundDisp <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum State
	{
		None = 0,
		Prepare = 1,
		Pause = 2,
		Playing = 3,
		Stop = 4,
	}

	private const string BackgroundImageObjectName = "background"; //Field offset: 0x0
	private const string MovieObjectName = "MovieController"; //Field offset: 0x0
	private const int DEFAULT_BG_ID = 1; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsDone>k__BackingField; //Field offset: 0x114
	private State state; //Field offset: 0x118
	private CriManaMovieControllerForUI movieController; //Field offset: 0x11C

	public private bool IsDone
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public bool IsEnebleMovie
	{
		 get { } //Length: 78
	}

	public KaguraBackgroundDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public bool get_IsDone() { }

	public bool get_IsEnebleMovie() { }

	[AsyncStateMachine(typeof(<InitializeBackGroungImage>d__15))]
	private UniTask InitializeBackGroungImage() { }

	[AsyncStateMachine(typeof(<InitializeMovie>d__16))]
	private UniTask InitializeMovie(int movieId) { }

	private void InitLayout() { }

	public bool IsReadyBackground() { }

	public bool IsStopped() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__14))]
	private UniTask LoadAsssetAsync() { }

	public void Pause(bool enable) { }

	[CompilerGenerated]
	private void set_IsDone(bool value) { }

	public void Stop() { }

	protected virtual void UpdateDispMain() { }

}

