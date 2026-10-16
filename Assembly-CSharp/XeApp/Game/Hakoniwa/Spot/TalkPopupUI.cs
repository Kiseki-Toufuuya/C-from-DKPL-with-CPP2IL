namespace XeApp.Game.Hakoniwa.Spot;

public class TalkPopupUI : UIDispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public string assetName; //Field offset: 0x8

		public <>c__DisplayClass67_0() { }

		internal void <LoadAssetBundle>b__0(AssetBundleLoadAssetOperation operation) { }

	}

	private enum DESIGN_TYPE
	{
		LEFT_POPUP_01 = 0,
		LEFT_POPUP_02 = 1,
		LEFT_POPUP_03 = 2,
		RIGHT_POPUP_01 = 3,
		RIGHT_POPUP_02 = 4,
		RIGHT_POPUP_03 = 5,
		DESIGN_MAX = 6,
	}

	internal enum POPUP_TYPE
	{
		TALK_10_TYPE = 0,
		THINK_10_TYPE = 1,
		TALK_13_TYPE = 2,
		THINK_13_TYPE = 3,
	}

	internal enum TALK_TYPE
	{
		CONTACT_TYPE = 0,
		PREVIEW_TYPE = 1,
		TWEET_TYPE = 2,
		MULTI_TWEET_TYPE = 3,
	}

	internal class TalkPopupData
	{
		public TALK_TYPE talkType; //Field offset: 0x8
		public POPUP_TYPE popupType; //Field offset: 0xC
		public bool isLeft; //Field offset: 0x10
		public List<String> talkList; //Field offset: 0x14
		public float dispSpeed; //Field offset: 0x18
		public float dispTime; //Field offset: 0x1C
		public bool isEpisode; //Field offset: 0x20
		public bool isEpisodeRead; //Field offset: 0x21
		public int stampId; //Field offset: 0x24
		public bool isRepairIcon; //Field offset: 0x28

		public TalkPopupData() { }

	}

	private const int LINE_CODE_MAX = 2; //Field offset: 0x0
	private static int m_LoadBundleCount; //Field offset: 0x0
	private static String[] assetNameList; //Field offset: 0x4
	private static Dictionary<String, Sprite> m_SpriteAssetDic; //Field offset: 0x8
	private HakoniwaSpotRootLayer m_parentLayer; //Field offset: 0x134
	private Canvas canvas; //Field offset: 0x138
	private RectTransform uiRect; //Field offset: 0x13C
	private RectTransform canvasRect; //Field offset: 0x140
	private TalkPopupData popupData; //Field offset: 0x144
	private List<Image> popupObjectList; //Field offset: 0x148
	private List<GameObject> talkTextObjectList; //Field offset: 0x14C
	private List<TextMeshProUGUI> talkTextComponentList; //Field offset: 0x150
	private List<GameObject> contactIconObjectList; //Field offset: 0x154
	private List<AtlasImage> episodeIconObjectList; //Field offset: 0x158
	private List<GameObject> repairIconObjectList; //Field offset: 0x15C
	private List<Image> episodeUnreadFrameObjectList; //Field offset: 0x160
	private AtlasImage[] atlasImages; //Field offset: 0x164
	private TextMeshProUGUI[] textMeshProUGUIs; //Field offset: 0x168
	private RawImage clubStampImage; //Field offset: 0x16C
	private DESIGN_TYPE designType; //Field offset: 0x170
	private TALK_TYPE talkType; //Field offset: 0x174
	private UnityAction onClickAction; //Field offset: 0x178
	private int talkIndex; //Field offset: 0x17C
	private float talkTimer; //Field offset: 0x180
	private bool isTalkFinish; //Field offset: 0x184
	private float depth; //Field offset: 0x188
	private bool isSe; //Field offset: 0x18C
	private eCanvas canvasSetting; //Field offset: 0x190
	private float m_seWaitTime; //Field offset: 0x194

	protected virtual string AnimatorObjectName
	{
		 get { } //Length: 35
	}

	public eCanvas CanvasSetting
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public string CurrentTalk
	{
		 get { } //Length: 80
	}

	public float Depth
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	private bool Is13Popup
	{
		private get { } //Length: 40
	}

	public bool IsSe
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsTalkFinish
	{
		 get { } //Length: 14
	}

	public UnityAction OnClick
	{
		 set { } //Length: 33
	}

	public Vector2 Position
	{
		 set { } //Length: 375
	}

	public float Scale
	{
		 set { } //Length: 168
	}

	public Vector2 ScreenPosition
	{
		 set { } //Length: 187
	}

	protected virtual string StateNameClose
	{
		 get { } //Length: 35
	}

	protected virtual string StateNameOpen
	{
		 get { } //Length: 35
	}

	public int TalkIndex
	{
		 get { } //Length: 14
	}

	private int TextObjectIndex
	{
		private get { } //Length: 83
	}

	private static TalkPopupUI() { }

	public TalkPopupUI() { }

	[CompilerGenerated]
	private void <InitializePopup>b__72_0(Sprite img) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__71_0(BaseEventData data) { }

	public void ClearPopup() { }

	private void ContactTalkUpdate() { }

	public virtual void Create(LayerBase parent_layer) { }

	private int CurrentTextCount(string currentTalkStr) { }

	protected virtual string get_AnimatorObjectName() { }

	public eCanvas get_CanvasSetting() { }

	public string get_CurrentTalk() { }

	public float get_Depth() { }

	private bool get_Is13Popup() { }

	public bool get_IsSe() { }

	public bool get_IsTalkFinish() { }

	protected virtual string get_StateNameClose() { }

	protected virtual string get_StateNameOpen() { }

	public int get_TalkIndex() { }

	private int get_TextObjectIndex() { }

	public void InitializePopup(TalkPopupData data) { }

	protected virtual void InitUguiOther() { }

	public static bool IsLoaded() { }

	public static void LoadAssetBundle() { }

	private void MultiTweetTalkUpdate() { }

	public virtual void Open(bool force = false, float normalizeTime = 0) { }

	private void PreviewTalkUpdate() { }

	public void set_CanvasSetting(eCanvas value) { }

	public void set_Depth(float value) { }

	public void set_IsSe(bool value) { }

	public void set_OnClick(UnityAction value) { }

	public void set_Position(Vector2 value) { }

	public void set_Scale(float value) { }

	public void set_ScreenPosition(Vector2 value) { }

	public void SkipTalk() { }

	public static void TryInstall() { }

	private void TweetTalkUpdate() { }

	public static void UnloadAssetBundle() { }

	protected virtual void UpdateDispMain() { }

}

