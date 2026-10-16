namespace Heqet;

public class HeqetMusicPanelDisp : HeqetSelectPanelDispBase
{
	private enum eCommonLayerId
	{
		ROOT = 0,
		ROOT_LOCK = 1,
		ROOT_NEW = 2,
		ROOT_DLC = 3,
		ROOT_BPM = 4,
	}

	private enum eIconLayerId
	{
		CLEAR_ICON_1 = 0,
		CLEAR_ICON_2 = 1,
		CLEAR_ICON_3 = 2,
		CLEAR_ICON_4 = 3,
	}

	private enum eImgLayerId
	{
		FAVORITE = 0,
		CATEGORY_BADGE = 1,
	}

	private enum eTxtLayerId
	{
		TEXT_TITLE = 0,
		TEXT_TITLE_JP = 1,
		TEXT_SORT_INFO = 2,
	}

	[CompilerGenerated]
	private bool <IsAllDefaultUnlock>k__BackingField; //Field offset: 0x114
	private String[] m_CommonLayerList; //Field offset: 0x118
	private String[] m_TxtLayerList; //Field offset: 0x11C
	private String[] m_ImgLayerList; //Field offset: 0x120
	private readonly string ClearIconPath; //Field offset: 0x124
	private List<AtlasImage> m_ClearImgs; //Field offset: 0x128
	private CanvasGroup m_RootCanvasGroup; //Field offset: 0x12C
	[CompilerGenerated]
	private bool <IsSwapLocalization>k__BackingField; //Field offset: 0x130
	private AtlasImage m_categoryBadgeImag; //Field offset: 0x134
	private int id; //Field offset: 0x138

	public int ID
	{
		 get { } //Length: 14
	}

	public private bool IsAllDefaultUnlock
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private bool IsSwapLocalization
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 94
	}

	public virtual RectTransform PanelRoot
	{
		 get { } //Length: 79
	}

	public HeqetMusicPanelDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	public void DispUpdate(HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public void DispUpdateRandomPanel() { }

	public int get_ID() { }

	[CompilerGenerated]
	private bool get_IsAllDefaultUnlock() { }

	[CompilerGenerated]
	private bool get_IsSwapLocalization() { }

	public virtual RectTransform get_PanelRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[CompilerGenerated]
	public void set_IsAllDefaultUnlock(bool value) { }

	[CompilerGenerated]
	public void set_IsSwapLocalization(bool value) { }

	private void SetFavorite(bool _favorite) { }

	public void SetGameObjectAlpha(float value) { }

	private void SetLock(bool _enable) { }

	private void SetLockDLC(bool _enable) { }

	private void SetMusicClearIcon(int _flg, MusicDifficulty _difficulty) { }

	private void SetMusicTitle(string _title) { }

	private void SetMusicTitleJp(string _title) { }

	private void SetNew(bool _enable) { }

	private void SetSortInfo(HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private void SetViewBpm(bool _enable) { }

	private void SetViewFavorite(bool _enable) { }

	private void SetViewMusicClearIcon(bool _enable) { }

	public void UpdateCategoryBadge(int type) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateMusic(HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public void UpdateRandomPanel(int _id) { }

	public void UpdateSwapTitle(bool _enable) { }

}

