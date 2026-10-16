namespace Heqet.DlcList;

public class DlcMusicltemDisp : UiScrollListPanelBase
{
	private enum eButtonId
	{
		Body = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		SelectFrame = 0,
		Max = 1,
	}

	private enum eTextId
	{
		MusicName = 0,
		Max = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_ButtonDataList; //Field offset: 0x130
	private String[] m_TextList; //Field offset: 0x134
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x138
	public Func<Int32, HeqetMusicModel> GetMusicModel; //Field offset: 0x13C
	public Func<Int32, Boolean> IsSelectItem; //Field offset: 0x140
	private int m_list_index; //Field offset: 0x144

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static DlcMusicltemDisp() { }

	public DlcMusicltemDisp() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public virtual Vector2 GetPanelSize() { }

	public GameObject GetSelectableObject() { }

	protected virtual void InitUguiOther() { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public virtual void SetData(int list_index, bool active) { }

	public void VisibleSelectFrame(bool isVisible) { }

}

