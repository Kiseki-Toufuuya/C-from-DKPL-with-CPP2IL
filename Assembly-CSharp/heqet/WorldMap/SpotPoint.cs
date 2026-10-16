namespace Heqet.WorldMap;

public class SpotPoint : NodePoint
{
	internal enum eSpotProgress
	{
		Renaissance = 0,
		AllStageClear = 1,
		AllRewardGet = 2,
		Max = 3,
	}

	[CompilerGenerated]
	[SerializeField]
	private int <SpotDataId>k__BackingField; //Field offset: 0x34
	[SerializeField]
	private GameObject m_StageRoot; //Field offset: 0x38
	[SerializeField]
	private CinemachineVirtualCamera m_stageCamera; //Field offset: 0x3C
	[SerializeField]
	private SpotMapChip m_spotMapChip; //Field offset: 0x40
	[SerializeField]
	private Animator m_spotCloudAnimator; //Field offset: 0x44
	public List<StagePoint> stageList; //Field offset: 0x48
	[SerializeField]
	private Sprite m_landmarkSpriteBefore; //Field offset: 0x4C
	[SerializeField]
	private Sprite m_landmarkSpriteAfter; //Field offset: 0x50
	[SerializeField]
	private GameObject m_cursor; //Field offset: 0x54
	private int m_currentIndex; //Field offset: 0x58
	[SerializeField]
	private SpriteRenderer EpisodeIcon; //Field offset: 0x5C
	private Tween tweener; //Field offset: 0x60

	public StagePoint currentStage
	{
		 get { } //Length: 67
		 set { } //Length: 228
	}

	public int currentStageIndex
	{
		 get { } //Length: 11
	}

	public Vector3 cursorPosition
	{
		 get { } //Length: 74
	}

	public Animator SpotCloudAnimator
	{
		 get { } //Length: 11
	}

	public private int SpotDataId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CinemachineVirtualCamera StageCamera
	{
		 get { } //Length: 11
	}

	public GameObject StageRoot
	{
		 get { } //Length: 11
	}

	public SpotPoint() { }

	public void ArrawAnimation(float factor) { }

	private void Awake() { }

	public void FadeMapChipAlpha(bool isSpotMode, float alpha) { }

	private int FindListIndex(StagePoint point) { }

	public StagePoint get_currentStage() { }

	public int get_currentStageIndex() { }

	public Vector3 get_cursorPosition() { }

	public Animator get_SpotCloudAnimator() { }

	[CompilerGenerated]
	public int get_SpotDataId() { }

	public CinemachineVirtualCamera get_StageCamera() { }

	public GameObject get_StageRoot() { }

	public bool GetProgress(eSpotProgress progressType) { }

	public StagePoint OffsetIndex(int offset) { }

	private void OnDestroy() { }

	private void OnValidate() { }

	public void Reconstruction(bool Reconstruction) { }

	public void set_currentStage(StagePoint value) { }

	[CompilerGenerated]
	private void set_SpotDataId(int value) { }

	public void UpdateDisplay(WorldSpotModel model, bool opened, bool isRenaissance, bool isEpisodeIcon) { }

	public virtual void UpdateFrame() { }

	[ContextMenu("UpdateStages")]
	private void UpdateStages() { }

	public virtual void VisibleCursor(bool active) { }

}

