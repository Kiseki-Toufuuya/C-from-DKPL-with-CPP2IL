namespace XeApp.Game;

public class AdvCardMessageLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<DispBase> <>9__53_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__53_0(DispBase disp) { }

	}

	internal enum eStartMesState
	{
		NONE = 0,
		MESSAGE = 1,
		NEWPAGE = 2,
	}

	internal class OneLineData
	{
		public string Text; //Field offset: 0x8
		public float Speed; //Field offset: 0xC
		public int Length; //Field offset: 0x10
		public int NowId; //Field offset: 0x14
		public float Count; //Field offset: 0x18
		public bool isDispAll; //Field offset: 0x1C
		public List<TagPosData> TagposList; //Field offset: 0x20
		public bool isDispMessage; //Field offset: 0x24
		public bool isAnimStart; //Field offset: 0x25
		public eALIGN_TAG eAlignTag; //Field offset: 0x28

		public OneLineData() { }

		public string GetNowText(int now_id = -1) { }

		private string GetText(int start_id, int end_id) { }

		public void Release() { }

		public void SearchMessage() { }

		public void SetAllDisp() { }

		public int TagSkipCheck(int now_id = -1) { }

		public bool UpdateCount() { }

	}

	internal class OnePageData
	{
		public List<OneLineData> backupLineList; //Field offset: 0x8

		public OnePageData() { }

		public void AddNewLine(string text, float speed, bool is_space, bool is_all, eALIGN_TAG align) { }

		private float ApplySettingSpeed(float fSpeed) { }

		public void Release() { }

		public static void SearchTag(ref List<TagPosData>& pos_data, string text) { }

	}

	internal class TagPosData
	{
		internal enum eALIGN_TAG
		{
			LEFT = 0,
			CENTER = 1,
			RIGHT = 2,
		}

		public int start_id; //Field offset: 0x8
		public int end_id; //Field offset: 0xC

		public TagPosData() { }

	}

	public const string strPatternStyleTag = "(?<=\<style\=p)(.*)(?=\>)"; //Field offset: 0x0
	public const int RUBYTAG_SIZE = 50; //Field offset: 0x0
	public const float RUBYTAG_VOFFSET = 0.9; //Field offset: 0x0
	public const string strStyleToRubyTagClose = "</size></voffset><space={0}em>"; //Field offset: 0x0
	public const string strStyleToRubyTagStart = "<space=-{0}em><voffset={1}em><size={2}%>"; //Field offset: 0x0
	public const string strSizeSpaceTagStart = "<cspace={0}em>"; //Field offset: 0x0
	public const float MSPACETAG_SCALE = 0.95; //Field offset: 0x0
	public const string strMessageSpaceTagClose = "</mspace>"; //Field offset: 0x0
	public const string strMessageSpaceTagStart = "<mspace={0}em>"; //Field offset: 0x0
	public const string strSizeSpaceTagClose = "</cspace>"; //Field offset: 0x0
	public const string strPatternStartColorTag = "(?<=\<color\=)(.*)(\>)"; //Field offset: 0x0
	public const string strPatternAllTag = "\<[a-zA-Z\d\x22\x27\%\=\.\/\-\+\#]*\>"; //Field offset: 0x0
	public const string strPatternCloseRubyTag = "(?<=\<space\=)(.*)(?=em\>)"; //Field offset: 0x0
	public const string strCloseColorTag = "</color>"; //Field offset: 0x0
	public const string strPatternStartRubyTag = "(?<=\<space\=\-)(.*)(?=em\>)"; //Field offset: 0x0
	public const string strCloseSizeTag = "</size>"; //Field offset: 0x0
	public const string strPatternSizeTag = "(?<=\<size\=)(.*)(?=em\>)"; //Field offset: 0x0
	public const string strCloseStyleTag = "</style>"; //Field offset: 0x0
	private readonly int PAGE_LINE_MAX; //Field offset: 0x7C
	private readonly int TEXT_SPEED_DEFAULT; //Field offset: 0x80
	private AdvCardMessageDisp m_MesBaseDisp; //Field offset: 0x84
	private AdvCardMessagePanelDisp m_TempText; //Field offset: 0x88
	private List<OnePageData> m_BackupPageList; //Field offset: 0x8C
	private int now_page; //Field offset: 0x90
	private int read_page; //Field offset: 0x94
	private eALIGN_TAG read_align; //Field offset: 0x98
	private AdvCardMessageOutlineLayer m_outlineLayer; //Field offset: 0x9C

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public int NowPage
	{
		 get { } //Length: 14
	}

	public AdvCardMessageLayer() { }

	private eStartMesState AddMessage(string text, int speed) { }

	public bool ChangeNextPage() { }

	public void ChangePrevPage() { }

	public static bool CheckAlignCenterTag(string text) { }

	public static bool CheckAlignLeftTag(string text) { }

	public static bool CheckAlignRightTag(string text) { }

	public static bool CheckNewPageTag(string text) { }

	public bool CheckSpaceLine(string text) { }

	public bool CheckTextFinish() { }

	public static void ConvertTextAlignTag(ref string text, eALIGN_TAG align) { }

	public static bool ConvertTextRubyTag(ref string text, bool is_book = false) { }

	protected void CreateListView() { }

	private void CreateNewPage() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	private void FocusLastPage() { }

	public void FocusLastPageRequest() { }

	private void FocusNewPage() { }

	public void FocusNewPageRequest() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_NowPage() { }

	public virtual object GetDispData(int index) { }

	public int GetNowPageNum() { }

	public OneLineData GetOneLineText(int page, int index) { }

	public Vector2 GetTextSize(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void NowMessageEndRequest() { }

	public virtual void OverDeleteLayer() { }

	private void RefreshText() { }

	protected virtual bool ReleaseLayer() { }

	public void SetDataCallback(int index, bool active) { }

	private void SetPage(int page) { }

	public eStartMesState StartMessageRequest(string str, int speed = -1) { }

	protected virtual void Update(bool is_active) { }

}

