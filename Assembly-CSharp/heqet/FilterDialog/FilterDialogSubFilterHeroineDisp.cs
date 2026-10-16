namespace Heqet.FilterDialog;

public class FilterDialogSubFilterHeroineDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		MAIN_SHOT_ALL = 0,
		MAIN_SHOT_NORMAL = 1,
		MAIN_SHOT_PENETRATION = 2,
		MAIN_SHOT_OTHER = 3,
		EXTRA_SHOT_ALL = 4,
		EXTRA_SHOT_NORMAL = 5,
		EXTRA_SHOT_PENETRATION = 6,
		EXTRA_SHOT_OTHER = 7,
		MAX = 8,
	}

	private enum eTextLayerId
	{
		LABEL_FREE_KEYWORD = 0,
		LAVEL_FREE_KEYWORD_PLACEHOLDER = 1,
		LABEL_MAIN_SHOT = 2,
		LABEL_EXTRA_SHOT = 3,
		MAIN_SHOT_ALL = 4,
		MAIN_SHOT_NORMAL = 5,
		MAIN_SHOT_PENETRATION = 6,
		MAIN_SHOT_OTHER = 7,
		EXTRA_SHOT_ALL = 8,
		EXTRA_SHOT_NORMAL = 9,
		EXTRA_SHOT_PENETRATION = 10,
		EXTRA_SHOT_OTHER = 11,
		TEXT_INPUT = 12,
		MAX = 13,
	}

	private enum FilterGroup
	{
		MAIN_SHOT = 0,
		EXTRA_SHOT = 1,
		ALL = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_TextLayerIdList; //Field offset: 0x134
	private String[] m_ButtonDataList; //Field offset: 0x138
	private ulong m_Filter; //Field offset: 0x140
	private TMP_InputField m_InputField; //Field offset: 0x148
	private Dictionary<Int32, FilterWork> m_FilterWorks; //Field offset: 0x14C
	private Dictionary<Int32, Int32> m_ConvertFilterId; //Field offset: 0x150
	private Dictionary<Int32, Int32> m_ConvertButtonId; //Field offset: 0x154
	private Dictionary<Int32, Int32> m_ConvertFilterGroup; //Field offset: 0x158

	private static FilterDialogSubFilterHeroineDisp() { }

	public FilterDialogSubFilterHeroineDisp() { }

	private void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	public virtual void CompResourceLoad() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void DispUpdate() { }

	private void FilterRegister(FilterGroup _group, eButtonId _buttonId, Filter _filterId, bool isAll = false) { }

	private ulong GetFilterAll() { }

	public virtual Vector2 GetPanelSize() { }

	public virtual object GetResultData(eResultType btn_res) { }

	private void Init() { }

	protected virtual void InitUguiOther() { }

	private bool IsAllCheckOn() { }

	private bool IsCheckButton(int btnId) { }

	public virtual bool IsSelectFilter() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(eButtonId btnId) { }

	private void ResultInputField(string _str) { }

	public virtual void SelectResetButton() { }

	private void SetButtonCheck(int btnId, bool isCheckOn) { }

	public virtual void SetInitialSelectButton() { }

	private void SetLocalizeText() { }

	protected virtual void UpdateDispMain() { }

}

