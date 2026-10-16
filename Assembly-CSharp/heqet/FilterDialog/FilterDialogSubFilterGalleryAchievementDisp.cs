namespace Heqet.FilterDialog;

public class FilterDialogSubFilterGalleryAchievementDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		ACHIEVE_ALL = 0,
		ACHIEVE_TRUE = 1,
		ACHIEVE_FALSE = 2,
		SKILL_TYPE_ALL = 3,
		SKILL_TYPE_BARRAGE = 4,
		SKILL_TYPE_SUPPORT = 5,
		SKILL_TYPE_SCORE = 6,
		SKILL_TYPE_OTHER = 7,
		MAX = 8,
	}

	private enum eCommonLayerId
	{
		CHECK_ACHIEVEMENT_ALL = 0,
		CHECK_ACHIEVEMENT_TRUE = 1,
		CHECK_ACHIEVEMENT_FALSE = 2,
		CHECK_SKILL_TYPE_ALL = 3,
		CHECK_SKILL_TYPE_BARRAGE = 4,
		CHECK_SKILL_TYPE_SUPPORT = 5,
		CHECK_SKILL_TYPE_SCORE = 6,
		CHECK_SKILL_TYPE_OTHER = 7,
		MAX = 8,
	}

	private enum eTextLayerId
	{
		LABEL_ACHIEVEMENT = 0,
		LABEL_SKILL_TYPE = 1,
		ACHIEVE_ALL = 2,
		ACHIEVE_TRUE = 3,
		ACHIEVE_FALSE = 4,
		SKILL_TYPE_ALL = 5,
		SKILL_TYPE_BARRAGE = 6,
		SKILL_TYPE_SUPPORT = 7,
		SKILL_TYPE_SCORE = 8,
		SKILL_TYPE_OTHER = 9,
		MAX = 10,
	}

	private enum FilterGroup
	{
		ACHIEVE = 0,
		SKILL = 1,
		ALL = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_TextLayerIdList; //Field offset: 0x134
	private String[] m_ButtonDataList; //Field offset: 0x138
	private ulong m_Filter; //Field offset: 0x140
	private Dictionary<Int32, FilterWork> m_FilterWorks; //Field offset: 0x148
	private Dictionary<Int32, Int32> m_ConvertFilterId; //Field offset: 0x14C
	private Dictionary<Int32, Int32> m_ConvertButtonId; //Field offset: 0x150
	private Dictionary<Int32, Int32> m_ConvertFilterGroup; //Field offset: 0x154

	private static FilterDialogSubFilterGalleryAchievementDisp() { }

	public FilterDialogSubFilterGalleryAchievementDisp() { }

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

