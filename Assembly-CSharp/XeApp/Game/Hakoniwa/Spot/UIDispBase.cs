namespace XeApp.Game.Hakoniwa.Spot;

public abstract class UIDispBase : DispBase
{
	internal enum eDialogSe
	{
		OPEN = 0,
		CLOSE = 1,
	}

	internal enum eSeType
	{
		DEFAULT = 0,
		SYSTEM_SETTING = 1,
		RECONSTRUCT_MENU = 2,
		REWARD = 3,
		LEVELUP = 4,
		CARD_EPSODE = 5,
		UNLOCK_EPSODE = 6,
		HOME_EDIT = 7,
		NUM = 8,
	}

	private enum eStep
	{
		NONE = 0,
		OPEN = 1,
		OPENED = 2,
		CLOSE = 3,
		CLOSED = 4,
	}

	private class SePlayData
	{
		public ALL_SE m_SeId; //Field offset: 0x8

		public SePlayData(ALL_SE seId) { }

		public void SetData(ALL_SE seId) { }

	}

	private class TabData
	{
		public int m_LayerId; //Field offset: 0x8
		public GameObject m_TabBtnText; //Field offset: 0xC
		public GameObject m_TabBtnText2; //Field offset: 0x10
		public AtlasImage m_TabImage; //Field offset: 0x14

		public TabData() { }

	}

	private eStep m_step; //Field offset: 0x114
	private Animator m_animator; //Field offset: 0x118
	private bool m_bFirst; //Field offset: 0x11C
	private bool m_bFirstOpen; //Field offset: 0x11D
	private List<SePlayData> m_SeList; //Field offset: 0x120
	private eSeType m_SeType; //Field offset: 0x124
	private Dictionary<Int32, TabData> m_TabDatum; //Field offset: 0x128
	private int m_NumTabData; //Field offset: 0x12C
	private bool m_isAutoInOutSe; //Field offset: 0x130

	protected abstract string AnimatorObjectName
	{
		 get { } //Length: 0
	}

	public bool IsAutoInOutSe
	{
		 set { } //Length: 94
	}

	public bool IsClose
	{
		 get { } //Length: 31
	}

	public bool IsClosed
	{
		 get { } //Length: 18
	}

	public bool IsOpen
	{
		 get { } //Length: 31
	}

	public bool IsOpened
	{
		 get { } //Length: 18
	}

	protected abstract string StateNameClose
	{
		 get { } //Length: 0
	}

	protected abstract string StateNameOpen
	{
		 get { } //Length: 0
	}

	protected UIDispBase() { }

	protected void AddTabPanel(int buttonId, int layerNo, string assetsName = "btn_c_ui_tab_{0}") { }

	protected void ChangeTab(int currentButtonId, int nextButtonId) { }

	public override void Close(bool force = false, float normalizeTime = 0) { }

	protected void CreateTabPanel(int buttonId, int layerNo, string assetsName = "btn_c_ui_tab_{0}") { }

	public void ForceClosed() { }

	protected abstract string get_AnimatorObjectName() { }

	public bool get_IsClose() { }

	public bool get_IsClosed() { }

	public bool get_IsOpen() { }

	public bool get_IsOpened() { }

	protected abstract string get_StateNameClose() { }

	protected abstract string get_StateNameOpen() { }

	protected UIWrapperButton InitButtonObjectForAnimator(int name_id, string name_hit, string name_disp, Action<Int32> cb_down, Action<Int32> cb_up = null, Func<Int32, Boolean> cb_enable = null, Func<Int32, Boolean> cb_next = null, Action<Int32> cb_end = null, float next_rag = -1) { }

	protected virtual void InitUguiOther() { }

	public bool IsActive() { }

	protected virtual void LateUpdate() { }

	protected override void OnClosed() { }

	protected override void OnOpened() { }

	public override void Open(bool force = false, float normalizeTime = 0) { }

	public void Play(string animationName) { }

	public void PlayCommonSe(eDialogSe SeType) { }

	public void PlayDialogCloseSe() { }

	public void PlayDialogOpenSe() { }

	public void PlayOtherSe(CueSheetID cueSheetID, int seId) { }

	public void set_IsAutoInOutSe(bool value) { }

	public void SetActive(bool enable) { }

	public void SetCommonSe(eSeType SeType) { }

	public virtual void SetUguiAnimIn() { }

	public virtual void SetUguiAnimOut() { }

	protected virtual void UpdateDispMain() { }

}

