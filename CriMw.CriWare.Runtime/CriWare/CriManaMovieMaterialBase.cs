namespace CriWare;

public abstract class CriManaMovieMaterialBase : CriMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RestartPlayerRoutine>d__60 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CriManaMovieMaterialBase <>4__this; //Field offset: 0x10

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
		public <RestartPlayerRoutine>d__60(int <>1__state) { }

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

	internal enum MaxFrameDrop
	{
		Disabled = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
	}

	internal sealed class OnApplicationPauseCallback : MulticastDelegate
	{

		public OnApplicationPauseCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CriManaMovieMaterialBase manaMovieMaterial, bool appPause, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CriManaMovieMaterialBase manaMovieMaterial, bool appPause) { }

	}

	internal enum RenderMode
	{
		Always = 0,
		OnVisibility = 1,
		Never = 2,
	}

	public bool playOnStart; //Field offset: 0x20
	public bool restartOnEnable; //Field offset: 0x21
	[CompilerGenerated]
	private bool <isMaterialAvailable>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	private Player <player>k__BackingField; //Field offset: 0x24
	public RenderMode renderMode; //Field offset: 0x28
	public OnApplicationPauseCallback onApplicationPauseCallback; //Field offset: 0x2C
	private TimerType _timerType; //Field offset: 0x30
	[SerializeField]
	private Material _material; //Field offset: 0x34
	[SerializeField]
	private MaxFrameDrop _maxFrameDrop; //Field offset: 0x38
	private bool materialOwn; //Field offset: 0x3C
	protected bool isMonoBehaviourStartCalled; //Field offset: 0x3D
	private bool wasDisabled; //Field offset: 0x3E
	private bool wasPausedOnDisable; //Field offset: 0x3F
	private bool previousOnApplicationPauseStatus; //Field offset: 0x40
	private WaitForEndOfFrame frameEnd; //Field offset: 0x44
	private bool unpauseOnApplicationUnpause; //Field offset: 0x48
	[CompilerGenerated]
	private bool <HaveRendererOwner>k__BackingField; //Field offset: 0x49
	private CriManaMoviePlayerHolder playerHolder; //Field offset: 0x4C

	protected abstract uint FilePathLength
	{
		 get { } //Length: 0
	}

	protected private bool HaveRendererOwner
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	protected abstract bool initializeWithAdvancedAudio
	{
		 get { } //Length: 0
	}

	protected abstract bool initializeWithAmbisonics
	{
		 get { } //Length: 0
	}

	public private bool isMaterialAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public Material material
	{
		 get { } //Length: 11
		 set { } //Length: 111
	}

	public MaxFrameDrop maxFrameDrop
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public private Player player
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public TimerType timerType
	{
		 get { } //Length: 11
		 set { } //Length: 34
	}

	protected CriManaMovieMaterialBase() { }

	protected override void Awake() { }

	private void CreateMaterial() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	private void DestroyOwnMaterial() { }

	protected abstract uint get_FilePathLength() { }

	[CompilerGenerated]
	protected bool get_HaveRendererOwner() { }

	protected abstract bool get_initializeWithAdvancedAudio() { }

	protected abstract bool get_initializeWithAmbisonics() { }

	[CompilerGenerated]
	public bool get_isMaterialAvailable() { }

	public Material get_material() { }

	public MaxFrameDrop get_maxFrameDrop() { }

	[CompilerGenerated]
	public Player get_player() { }

	public TimerType get_timerType() { }

	private void OnApplicationPause(bool appPause) { }

	protected override void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected override void OnMaterialAvailableChanged() { }

	protected override void OnMaterialUpdated() { }

	protected override void OnWillRenderObject() { }

	public void Pause(bool sw) { }

	public void Play() { }

	public void PlayerManualFinalize() { }

	public void PlayerManualInitialize() { }

	public void PlayerManualSetup() { }

	public void PlayerManualUpdate() { }

	private void ProcessApplicationPause(bool appPause) { }

	public override void RenderMovie() { }

	public override void RenderTargetManualFinalize() { }

	public override bool RenderTargetManualSetup() { }

	[IteratorStateMachine(typeof(<RestartPlayerRoutine>d__60))]
	private IEnumerator RestartPlayerRoutine() { }

	[CompilerGenerated]
	private void set_HaveRendererOwner(bool value) { }

	[CompilerGenerated]
	private void set_isMaterialAvailable(bool value) { }

	public void set_material(Material value) { }

	public void set_maxFrameDrop(MaxFrameDrop value) { }

	[CompilerGenerated]
	private void set_player(Player value) { }

	public void set_timerType(TimerType value) { }

	protected abstract void SetDataToPlayer() { }

	protected override void Start() { }

	public void Stop() { }

}

