//Type is in global namespace

public class SettingPreview : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SettingPreviewNotesPrefab, Boolean> <>9__56_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <Update>b__56_0(SettingPreviewNotesPrefab item) { }

	}

	private enum ePreviewState
	{
		None = 0,
		Entry = 1,
		Init = 2,
		InitWait = 3,
		Move = 4,
		Delay = 5,
		Restart = 6,
	}

	internal struct NotesType
	{
		public string notesN1; //Field offset: 0x0
		public string notesN2; //Field offset: 0x4
		public string notesA1; //Field offset: 0x8
		public string notesA2; //Field offset: 0xC
		public string judgeNotes; //Field offset: 0x10

	}

	internal class SetupParam
	{
		public float notesSpeed; //Field offset: 0x8
		public float sudden; //Field offset: 0xC
		public float hidden; //Field offset: 0x10
		public bool isShowGuideline; //Field offset: 0x14
		public int skinType; //Field offset: 0x18
		public int laneBrightnes; //Field offset: 0x1C
		public UICustomizeData customizeData; //Field offset: 0x20

		public SetupParam() { }

	}

	private const float BaseSpeed = 1.5; //Field offset: 0x0
	[SerializeField]
	private float RESTART_DELAY; //Field offset: 0x10
	[SerializeField]
	private int NOTES_COUNT; //Field offset: 0x14
	[SerializeField]
	private float m_bpm; //Field offset: 0x18
	[SerializeField]
	private float loopDelayTime; //Field offset: 0x1C
	private float playerSettingSpeed; //Field offset: 0x20
	private bool isShowGuideline; //Field offset: 0x24
	private float guidelineWidth; //Field offset: 0x28
	private float m_BaseSpeed; //Field offset: 0x2C
	private float m_BaseDistance; //Field offset: 0x30
	[Range(0, 1)]
	private float topBlindScale; //Field offset: 0x34
	[Range(0, 1)]
	private float lowerBlindScale; //Field offset: 0x38
	[HideInInspector]
	public RawImageEx rawImageEx; //Field offset: 0x3C
	[SerializeField]
	private GameObject m_NotesPrefab; //Field offset: 0x40
	[SerializeField]
	private Transform m_TopBlindTransform; //Field offset: 0x44
	[SerializeField]
	private Transform m_LowerBlindTransform; //Field offset: 0x48
	private List<SettingPreviewNotesPrefab> m_SettingPreviewNotesList; //Field offset: 0x4C
	private List<LineRenderer> m_NotesLineRendererList; //Field offset: 0x50
	private Vector2 m_StartPosition; //Field offset: 0x54
	private Vector2 m_LinePosition; //Field offset: 0x5C
	private Vector2 m_EndPosition; //Field offset: 0x64
	private Vector2 m_BlindScaleRange; //Field offset: 0x6C
	private Vector2 m_OddNotesLineRange; //Field offset: 0x74
	private Vector2 m_EvenNotesLineRange; //Field offset: 0x7C
	private float m_RestartDelay; //Field offset: 0x84
	[SerializeField]
	private Transform m_BlindTopPos; //Field offset: 0x88
	[SerializeField]
	private Transform m_BlindBottomPos; //Field offset: 0x8C
	[SerializeField]
	private Transform m_TopTransform; //Field offset: 0x90
	[SerializeField]
	private Transform m_LineTransform; //Field offset: 0x94
	[SerializeField]
	private Transform m_BottomTransform; //Field offset: 0x98
	[SerializeField]
	private SpriteRenderer frameMain; //Field offset: 0x9C
	[SerializeField]
	private SpriteRenderer JudgeIcon; //Field offset: 0xA0
	[SerializeField]
	private Transform comboMessage; //Field offset: 0xA4
	[SerializeField]
	private Transform judgeMessage; //Field offset: 0xA8
	[SerializeField]
	private Transform fastSlowMessage; //Field offset: 0xAC
	[SerializeField]
	private UIAnchor uiAnchor; //Field offset: 0xB0
	private Transform rootJudgeMessageParent; //Field offset: 0xB4
	private Transform rootComboMessageParent; //Field offset: 0xB8
	private Transform rootfastSlowMessageParent; //Field offset: 0xBC
	private SpriteAtlas m_setting_spriteatlas; //Field offset: 0xC0
	private List<NotesType> m_NotesTypeList; //Field offset: 0xC4
	private float m_BlindImageHalfHeight; //Field offset: 0xC8
	private bool m_IsWaitResourceLoad; //Field offset: 0xCC
	private ePreviewState m_PreviewState; //Field offset: 0xD0

	public SpriteAtlas SpriteAtlas
	{
		 set { } //Length: 33
	}

	public SettingPreview() { }

	private void Awake() { }

	private void CenterLineExist(bool flg) { }

	private float ComboSpecifiedPositionY(int uiValue) { }

	private void CreateNotes() { }

	private void GuidelineSetup() { }

	private float JudgeSpecifiedPositionY(int uiValue) { }

	private void LowerBlindUpdateScale(float hidden) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ResetNotesState() { }

	public void Restart() { }

	public void set_SpriteAtlas(SpriteAtlas value) { }

	public void SetBpm(float _bpm) { }

	public void SetCenterLine(bool flg) { }

	public void SetComboMessage(int combo_message_display_type, Vector2 _pos) { }

	public void SetFastSlowMessage(int fast_slow_message_display_type) { }

	private void SetGuidelineRange(int id, float left, float right, float width) { }

	public void SetHidden(float hidden) { }

	public void SetJudgeMessage(int customize_type, Vector2 _pos) { }

	public void SetLaneBrightness(int laneBrightness) { }

	private void SetNotesPosition(float speedRate) { }

	public void SetNotesSpeed(float speed) { }

	public void SetNotesSprite(int notestype) { }

	private void SetNotesTypeList() { }

	public void SetSudden(float sudden) { }

	public void Setup(SetupParam _param) { }

	private void ShowGuideline(bool isShow) { }

	private void Start() { }

	private void TopBlindUpdateScale(float sudden) { }

	private void Update() { }

	public bool WaitResourceLoad() { }

}

