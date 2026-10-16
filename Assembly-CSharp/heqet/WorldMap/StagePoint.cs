namespace Heqet.WorldMap;

public class StagePoint : NodePoint
{
	[CompilerGenerated]
	private struct <PlayPutAnimation>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int delayFrame; //Field offset: 0xC
		public StagePoint <>4__this; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"delay", "se_id"})]
		private ValueTuple<Int32, Int32> <data>5__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum IconType
	{
		MainMission = 0,
		SubMission = 1,
		Episode = 2,
		Event = 3,
		Shop = 4,
		None = 5,
	}

	private interface IStageIcon
	{

		public void SetActive(bool isActive) { }

		public void SetClear(bool isClear) { }

		public void SetDisable(bool isDisable) { }

	}

	private struct MissonIcon : IStageIcon
	{
		public GameObject normal; //Field offset: 0x0
		public GameObject disable; //Field offset: 0x4
		public GameObject clear; //Field offset: 0x8

		public override void SetActive(bool isActive) { }

		public override void SetClear(bool isClear) { }

		public override void SetDisable(bool isDisable) { }

	}

	private struct OtherIcon : IStageIcon
	{
		public GameObject normal; //Field offset: 0x0
		public GameObject clear; //Field offset: 0x4

		public override void SetActive(bool isActive) { }

		public override void SetClear(bool isClear) { }

		public override void SetDisable(bool isDisable) { }

	}

	private enum StageEffect
	{
		Entry = 0,
		Put = 1,
	}

	[CompilerGenerated]
	[SerializeField]
	private int <StageDataId>k__BackingField; //Field offset: 0x34
	[SerializeField]
	private Animator animator; //Field offset: 0x38
	private IStageIcon[] stageTypeIcons; //Field offset: 0x3C
	[SerializeField]
	private MissonIcon mainMissionIcon; //Field offset: 0x40
	[SerializeField]
	private MissonIcon subMissonIcon; //Field offset: 0x4C
	[SerializeField]
	private GameObject missionTypeKaguraIcon; //Field offset: 0x58
	[SerializeField]
	private GameObject missionTypeDanmakuIcon; //Field offset: 0x5C
	[SerializeField]
	private OtherIcon episodeIcon; //Field offset: 0x60
	[SerializeField]
	private OtherIcon eventIcon; //Field offset: 0x68
	[SerializeField]
	private OtherIcon shopIcon; //Field offset: 0x70
	private SpriteRenderer[] spriteRenderers; //Field offset: 0x78
	[SerializeField]
	private GameObject iconRoot; //Field offset: 0x7C
	[Range(0, 1)]
	[SerializeField]
	public float opacity; //Field offset: 0x80
	private float lastOpacity; //Field offset: 0x84
	private int entry_effect_id; //Field offset: 0x88
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"delay", "se_id"})]
	private readonly Dictionary<Int32, ValueTuple`2<Int32, Int32>> putEffectDatas; //Field offset: 0x8C

	public int Difficulty
	{
		 get { } //Length: 133
		 set { } //Length: 136
	}

	public int LaneMode
	{
		 get { } //Length: 133
		 set { } //Length: 136
	}

	public private int StageDataId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public StagePoint() { }

	[CompilerGenerated]
	private void <PlayFadeIn>b__29_0(float value) { }

	private void Awake() { }

	public int get_Difficulty() { }

	public int get_LaneMode() { }

	[CompilerGenerated]
	public int get_StageDataId() { }

	public static bool IsStageOpen(WorldStageModel stageModel) { }

	private void OnAnimEvent(int id) { }

	public void PlayFadeIn() { }

	[AsyncStateMachine(typeof(<PlayPutAnimation>d__33))]
	public UniTask PlayPutAnimation(int delayFrame) { }

	public void set_Difficulty(int value) { }

	public void set_LaneMode(int value) { }

	[CompilerGenerated]
	private void set_StageDataId(int value) { }

	public void UpdateDisplay() { }

	public virtual void UpdateFrame() { }

	public virtual void VisibleCursor(bool isVisible) { }

}

