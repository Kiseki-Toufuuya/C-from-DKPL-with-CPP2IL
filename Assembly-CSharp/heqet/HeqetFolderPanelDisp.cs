namespace Heqet;

public class HeqetFolderPanelDisp : HeqetSelectPanelDispBase
{
	private enum eCommonLayerId
	{
		ROOT = 0,
		ROOT_LOCK = 1,
		ROOT_NEW = 2,
		ROOT_DLC = 3,
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
	}

	private enum eTxtLayerId
	{
		TEXT_TITLE = 0,
	}

	private String[] m_CommonLayerList; //Field offset: 0x114
	private String[] m_TxtLayerList; //Field offset: 0x118
	private String[] m_ImgLayerList; //Field offset: 0x11C
	private readonly string ClearIconPath; //Field offset: 0x120
	private List<AtlasImage> m_ClearImgs; //Field offset: 0x124
	private readonly string BlankClearIconPath; //Field offset: 0x128
	private List<AtlasImage> m_BlankClearImgs; //Field offset: 0x12C
	private int id; //Field offset: 0x130

	public int ID
	{
		 get { } //Length: 14
	}

	public virtual RectTransform PanelRoot
	{
		 get { } //Length: 79
	}

	public HeqetFolderPanelDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent) { }

	private void DispUpdate() { }

	private void EnableViewMusicClearIcon(bool _enable, MusicDifficulty _difficulty) { }

	public int get_ID() { }

	public virtual RectTransform get_PanelRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void SetMusicClearIcon(int _flg, MusicDifficulty _difficulty) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateFolder(HeqetMusicFolderModel _model, Int32[2] _flags, bool _lock, Int32[] _viewIcon, LaneMode _laneMode) { }

}

