namespace Heqet.RG;

public class Lane : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public AssetBundleLoadAllAssetOperationBase ope; //Field offset: 0x8

		public <>c__DisplayClass33_0() { }

		internal bool <Initialize>b__0() { }

	}

	[CompilerGenerated]
	private struct <Initialize>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Lane <>4__this; //Field offset: 0xC
		public RhythmGame rhythmGame_; //Field offset: 0x10
		public LaneController laneController; //Field offset: 0x14
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x18
		private int <groupId>5__2; //Field offset: 0x1C
		private Awaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private int laneId; //Field offset: 0x10
	[SerializeField]
	private GameObject rootObject; //Field offset: 0x14
	[SerializeField]
	private GameObject inactiveObject; //Field offset: 0x18
	[SerializeField]
	private GameObject keyAssign; //Field offset: 0x1C
	[SerializeField]
	private SpriteRenderer judgeGuideIcon_0; //Field offset: 0x20
	[SerializeField]
	private SpriteRenderer judgeGuideIcon_1; //Field offset: 0x24
	[SerializeField]
	private SpriteRenderer laneLight_0; //Field offset: 0x28
	[SerializeField]
	private SpriteRenderer laneLight_1; //Field offset: 0x2C
	public int ColorNumber; //Field offset: 0x30
	public LaneLight laneLight; //Field offset: 0x34
	public GameObject endPosition; //Field offset: 0x38
	public LaneJudge LaneJudge; //Field offset: 0x3C
	[SerializeField]
	private TapEffect tapEffect; //Field offset: 0x40
	public GameObject MeasureLine; //Field offset: 0x44
	public GameObject BeatLine; //Field offset: 0x48
	[CompilerGenerated]
	private LaneController <LaneController>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private RhythmGame <RhythmGame>k__BackingField; //Field offset: 0x50
	public int linking2; //Field offset: 0x54
	private bool isUsed; //Field offset: 0x58
	private bool initialized; //Field offset: 0x59

	public bool IsInitialized
	{
		 get { } //Length: 11
	}

	public bool IsUsed
	{
		 get { } //Length: 11
	}

	public private LaneController LaneController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public int LaneId
	{
		 get { } //Length: 11
	}

	public private RhythmGame RhythmGame
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public Lane() { }

	private void Awake() { }

	public void DoLateUpdate() { }

	public void DoUpdate() { }

	public bool get_IsInitialized() { }

	public bool get_IsUsed() { }

	[CompilerGenerated]
	public LaneController get_LaneController() { }

	public int get_LaneId() { }

	[CompilerGenerated]
	public RhythmGame get_RhythmGame() { }

	[AsyncStateMachine(typeof(<Initialize>d__33))]
	public UniTask Initialize(RhythmGame rhythmGame_, LaneController laneController) { }

	public void Pause(bool enable) { }

	public void Release() { }

	[CompilerGenerated]
	private void set_LaneController(LaneController value) { }

	[CompilerGenerated]
	private void set_RhythmGame(RhythmGame value) { }

	public void SetGameParam() { }

	public void SetUse(bool use) { }

}

