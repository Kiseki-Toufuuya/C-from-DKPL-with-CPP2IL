namespace Heqet.DlcList;

public class DlcListItemDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		Body = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		SelectFrame = 0,
		IconNew = 1,
		IconLock = 2,
		LockBg = 3,
		Max = 4,
	}

	private enum eImageId
	{
		DlcThumb = 0,
		Max = 1,
	}

	private enum eTextId
	{
		Max = 0,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_ButtonDataList; //Field offset: 0x130
	private String[] m_TextList; //Field offset: 0x134
	private String[] m_ImageList; //Field offset: 0x138
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x13C
	public Func<Int32, Boolean> IsSelectItem; //Field offset: 0x140
	public Func<Int32, Int32> GetDlcId; //Field offset: 0x144
	private int m_list_index; //Field offset: 0x148
	private RawImageEx m_DlcImage; //Field offset: 0x14C
	private FolderJacketAssetBunleLoader m_FolderJacketLoader; //Field offset: 0x150

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static DlcListItemDisp() { }

	public DlcListItemDisp() { }

	[CompilerGenerated]
	private void <SetDlcImage>b__24_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableObject() { }

	protected virtual void InitUguiOther() { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public virtual void SetData(int list_index, bool active) { }

	private void SetDlcImage(DlcListModel model) { }

	public void VisibleSelectFrame(bool isVisible) { }

}

