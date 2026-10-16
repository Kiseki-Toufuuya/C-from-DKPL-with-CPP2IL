namespace Heqet.Danmaku;

public class TimelineManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass44_0() { }

		internal bool <LoadAsyncDummyStage>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass45_0() { }

		internal bool <LoadAsssetAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_1
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass45_1() { }

		internal bool <LoadAsssetAsync>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_2
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass45_2() { }

		internal bool <LoadAsssetAsync>b__3() { }

	}

	[CompilerGenerated]
	private struct <LoadAsssetAsync>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public TimelineManager <>4__this; //Field offset: 0x8
		private <>c__DisplayClass45_2 <>8__1; //Field offset: 0xC
		private WorldStageModel <worldStageModel>5__2; //Field offset: 0x10
		private string <fileName>5__3; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsyncDummyStage>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public TimelineManager <>4__this; //Field offset: 0xC
		private <>c__DisplayClass44_0 <>8__1; //Field offset: 0x10
		private string <fileName>5__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class EffectInfo
	{
		public int id; //Field offset: 0x8
		public Vector3 position; //Field offset: 0xC
		public float scale; //Field offset: 0x18
		public GameObject parent; //Field offset: 0x1C
		public bool isWorldPosition; //Field offset: 0x20
		public bool IsEnemyBulletEraserProcessing; //Field offset: 0x21

		public EffectInfo() { }

	}

	public const float GeneralFallingLimitZ = -5; //Field offset: 0x0
	[CompilerGenerated]
	private static TimelineManager <Instance>k__BackingField; //Field offset: 0x0
	private DanmakuScene danmakuScene; //Field offset: 0x10
	private NotesManager notesManager; //Field offset: 0x14
	private PlayableDirector rootPlayableDirector; //Field offset: 0x18
	private StageController stageController; //Field offset: 0x1C
	[SerializeField]
	private GameObject timelineRootObject; //Field offset: 0x20
	[SerializeField]
	private GameObject dynamicObject; //Field offset: 0x24
	[SerializeField]
	private PlayerController playerController; //Field offset: 0x28
	[SerializeField]
	private DanmakuBGCamera bgCamera; //Field offset: 0x2C
	[CompilerGenerated]
	private EnemyManager <EnemyManager>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private BulletManager <BulletManager>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private Vector3 <BossDefeatedPosition>k__BackingField; //Field offset: 0x38
	private bool isDone; //Field offset: 0x44
	private bool isPlay; //Field offset: 0x45
	private bool isPause; //Field offset: 0x46
	private List<String> assetBundleNames; //Field offset: 0x48
	private List<EffectInfo> managedEffectInfoList; //Field offset: 0x4C

	public DanmakuBGCamera BGCamera
	{
		 get { } //Length: 11
	}

	public private Vector3 BossDefeatedPosition
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public private BulletManager BulletManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public GameObject DynamicObject
	{
		 get { } //Length: 11
	}

	public private EnemyManager EnemyManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private static TimelineManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public bool IsInitialized
	{
		 get { } //Length: 11
	}

	public PlayerController PlayerController
	{
		 get { } //Length: 11
	}

	public PlayableDirector RootPlayableDirector
	{
		 get { } //Length: 11
	}

	public StageController StageController
	{
		 get { } //Length: 11
	}

	public GameObject TimelineRootObject
	{
		 get { } //Length: 11
	}

	public TimelineManager() { }

	[CompilerGenerated]
	private bool <LoadAsssetAsync>b__45_0() { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public DanmakuBGCamera get_BGCamera() { }

	[CompilerGenerated]
	public Vector3 get_BossDefeatedPosition() { }

	[CompilerGenerated]
	public BulletManager get_BulletManager() { }

	public GameObject get_DynamicObject() { }

	[CompilerGenerated]
	public EnemyManager get_EnemyManager() { }

	[CompilerGenerated]
	public static TimelineManager get_Instance() { }

	public bool get_IsInitialized() { }

	public PlayerController get_PlayerController() { }

	public PlayableDirector get_RootPlayableDirector() { }

	public StageController get_StageController() { }

	public GameObject get_TimelineRootObject() { }

	private double GetElapsedTime() { }

	public void Initialize() { }

	public bool IsDone() { }

	[AsyncStateMachine(typeof(<LoadAsssetAsync>d__45))]
	private UniTaskVoid LoadAsssetAsync() { }

	[AsyncStateMachine(typeof(<LoadAsyncDummyStage>d__44))]
	private UniTask LoadAsyncDummyStage() { }

	public void OnPlayTimeline() { }

	public void Pause(bool enable) { }

	public void Play(float time = 0) { }

	public void PlayEffectManaged(int effectId, Vector3 position, float scale = 1, GameObject parent = null, bool isWorldPosition = false) { }

	public EffectObjectBase PlayEffectRaw(int effectId, Vector3 position, float scale = 1, bool play = true, GameObject parent = null, bool isWorldPosition = false) { }

	public void PlaySe(ALL_SE allSeID) { }

	[CompilerGenerated]
	private void set_BossDefeatedPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_BulletManager(BulletManager value) { }

	[CompilerGenerated]
	private void set_EnemyManager(EnemyManager value) { }

	[CompilerGenerated]
	private static void set_Instance(TimelineManager value) { }

	public void Stop() { }

	public void Terminate() { }

}

