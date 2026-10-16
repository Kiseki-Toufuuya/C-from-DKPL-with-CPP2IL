namespace Heqet.FilterDialog;

public class FilterDialogSubFilterGalleryMitamaDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		ATTRIBUTE_ALL = 0,
		ATTRIBUTE_EM = 1,
		ATTRIBUTE_RO = 2,
		ATTRIBUTE_CO = 3,
		SKILL_T_ALL = 4,
		SKILL_T_BARRAGE = 5,
		SKILL_T_SUPPORT = 6,
		SKILL_T_SCORE = 7,
		SKILL_T_OTHER = 8,
		MAX = 9,
	}

	private enum eCommonLayerId
	{
		CHECK_ATTRIBUTE_ALL = 0,
		CHECK_ATTRIBUTE_EM = 1,
		CHECK_ATTRIBUTE_RO = 2,
		CHECK_ATTRIBUTE_CO = 3,
		CHECK_SKILL_T_ALL = 4,
		CHECK_SKILL_T_BARRAGE = 5,
		CHECK_SKILL_T_SUPPORT = 6,
		CHECK_SKILL_T_SCORE = 7,
		CHECK_SKILL_T_OTHER = 8,
		TEXT_INPUT = 9,
		MAX = 10,
	}

	private enum eTextLayerId
	{
		LABEL_FREE_KEYWORD = 0,
		ABEL_FREE_KEYWORD_PLACEHOLDER = 1,
		LABEL_ATTRIBUTE = 2,
		LABEL_SKILL_TYPE = 3,
		ATTRIBUTE_ALL = 4,
		ATTRIBUTE_EM = 5,
		ATTRIBUTE_RO = 6,
		ATTRIBUTE_CO = 7,
		SKILL_T_ALL = 8,
		SKILL_T_BARRAGE = 9,
		SKILL_T_SUPPORT = 10,
		SKILL_T_SCORE = 11,
		SKILL_T_OTHER = 12,
		MAX = 13,
	}

	private enum FilterGroup
	{
		ATTRIBUTE = 0,
		SKILL_TYPE = 1,
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

	private static FilterDialogSubFilterGalleryMitamaDisp() { }

	public FilterDialogSubFilterGalleryMitamaDisp() { }

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

	public virtual bool IsInputingKeyword() { }

	public virtual bool IsSelectFilter() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(eButtonId btnId) { }

	private void ResultInputField(string _str) { }

	public virtual void SelectResetButton() { }

	private void SetButtonCheck(int btnId, bool isCheckOn) { }

	public virtual void SetInitialSelectButton() { }

	private void SetLocalizeText() { }

}

