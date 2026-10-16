namespace Heqet.FilterDialog;

public class FilterDialogSubFilterStageSelectDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		UNLOCK_ALL = 0,
		UNLOCK = 1,
		UNLOCK_NONE = 2,
		FAVORITE_ALL = 3,
		FAVORITE_ONLY = 4,
		STAGE_TYPE_ALL = 5,
		STAGE_TYPE_NOMAL = 6,
		STAGE_TYPE_MEDLAY = 7,
		STAGE_RANK_ALL = 8,
		STAGE_RANK_SS = 9,
		STAGE_RANK_S = 10,
		STAGE_RANK_A = 11,
		STAGE_RANK_B = 12,
		STAGE_RANK_C = 13,
		STAGE_RANK_D = 14,
		STAGE_CLEAR_ALL = 15,
		STAGE_CLEAR = 16,
		STAGE_CLEAR_NONE = 17,
		STAGE_FRAME_PERFECT_ALL = 18,
		STAGE_FRAME_PERFECT = 19,
		STAGE_FRAME_PERFECT_NONE = 20,
		STAGE_BRILLIANT_ALL = 21,
		STAGE_BRILLIANT = 22,
		STAGE_BRILLIANT_NONE = 23,
		STAGE_FULLCOMBO_ALL = 24,
		STAGE_FULLCOMBO = 25,
		STAGE_FULLCOMBO_NONE = 26,
		FILTER_SERIES_ALL = 27,
		FILTER_SERIES_1 = 28,
		FILTER_SERIES_2 = 29,
		FILTER_SERIES_3 = 30,
		FILTER_SERIES_4 = 31,
		FILTER_SERIES_5 = 32,
		FILTER_SERIES_6 = 33,
		FILTER_SERIES_7 = 34,
		FILTER_SERIES_8 = 35,
		FILTER_SERIES_9 = 36,
		FILTER_SERIES_10 = 37,
		FILTER_SERIES_11 = 38,
		FILTER_SERIES_12 = 39,
		FILTER_SERIES_13 = 40,
		FILTER_SERIES_14 = 41,
		FILTER_SERIES_15 = 42,
		FILTER_SERIES_16 = 43,
		FILTER_SERIES_17 = 44,
		FILTER_SERIES_18 = 45,
		FILTER_SERIES_19 = 46,
		FILTER_SERIES_20 = 47,
		FILTER_SERIES_21 = 48,
		FILTER_SERIES_22 = 49,
		FILTER_SERIES_23 = 50,
		FILTER_SERIES_24 = 51,
		FILTER_SERIES_25 = 52,
		FILTER_SERIES_26 = 53,
		FILTER_SERIES_27 = 54,
		FILTER_SERIES_28 = 55,
		FILTER_SERIES_29 = 56,
		FILTER_SERIES_30 = 57,
		FILTER_SERIES_31 = 58,
		FILTER_SERIES_32 = 59,
		FILTER_SERIES_33 = 60,
	}

	private enum eTxtLayerId
	{
		LABEL_1 = 0,
		LABEL_2 = 1,
		LABEL_3 = 2,
		LABEL_4 = 3,
		LABEL_5 = 4,
		LABEL_6 = 5,
		LABEL_7 = 6,
		LABEL_8 = 7,
		LABEL_9 = 8,
		UNLOCK_ALL = 9,
		UNLOCK = 10,
		UNLOCK_NONE = 11,
		FAVORITE_ALL = 12,
		FAVORITE_ONLY = 13,
		STAGE_TYPE_ALL = 14,
		STAGE_TYPE_NOMAL = 15,
		STAGE_TYPE_MEDLAY = 16,
		STAGE_RANK_ALL = 17,
		STAGE_RANK_SS = 18,
		STAGE_RANK_S = 19,
		STAGE_RANK_A = 20,
		STAGE_RANK_B = 21,
		STAGE_RANK_C = 22,
		STAGE_RANK_D = 23,
		STAGE_CLEAR_ALL = 24,
		STAGE_CLEAR = 25,
		STAGE_CLEAR_NONE = 26,
		STAGE_FRAME_PERFECT_ALL = 27,
		STAGE_FRAME_PERFECT = 28,
		STAGE_FRAME_PERFECT_NONE = 29,
		STAGE_BRILLIANT_ALL = 30,
		STAGE_BRILLIANT = 31,
		STAGE_BRILLIANT_NONE = 32,
		STAGE_FULLCOMBO_ALL = 33,
		STAGE_FULLCOMBO = 34,
		STAGE_FULLCOMBO_NONE = 35,
		FILTER_SERIES_ALL = 36,
		FILTER_SERIES_1 = 37,
		FILTER_SERIES_2 = 38,
		FILTER_SERIES_3 = 39,
		FILTER_SERIES_4 = 40,
		FILTER_SERIES_5 = 41,
		FILTER_SERIES_6 = 42,
		FILTER_SERIES_7 = 43,
		FILTER_SERIES_8 = 44,
		FILTER_SERIES_9 = 45,
		FILTER_SERIES_10 = 46,
		FILTER_SERIES_11 = 47,
		FILTER_SERIES_12 = 48,
		FILTER_SERIES_13 = 49,
		FILTER_SERIES_14 = 50,
		FILTER_SERIES_15 = 51,
		FILTER_SERIES_16 = 52,
		FILTER_SERIES_17 = 53,
		FILTER_SERIES_18 = 54,
		FILTER_SERIES_19 = 55,
		FILTER_SERIES_20 = 56,
		FILTER_SERIES_21 = 57,
		FILTER_SERIES_22 = 58,
		FILTER_SERIES_23 = 59,
		FILTER_SERIES_24 = 60,
		FILTER_SERIES_25 = 61,
		FILTER_SERIES_26 = 62,
		FILTER_SERIES_27 = 63,
		FILTER_SERIES_28 = 64,
		FILTER_SERIES_29 = 65,
		FILTER_SERIES_30 = 66,
		FILTER_SERIES_31 = 67,
		FILTER_SERIES_32 = 68,
		FILTER_SERIES_33 = 69,
		TEXT_INPUT_LABEL = 70,
		TEXT_INPUT_PLACEHOLDER = 71,
		TEXT_INPUT = 72,
	}

	private enum FilterGroup
	{
		UNLOCK = 0,
		FAVORITE = 1,
		STAGE_TYPE = 2,
		STAGE_RANK = 3,
		STAGE_CLEAR = 4,
		STAGE_FRAME_PERFECT = 5,
		STAGE_BRILLIANT = 6,
		STAGE_FULLCOMBO = 7,
		SERIES = 8,
		ALL = 9,
	}

	private String[] m_TxtLayerIdList; //Field offset: 0x134
	private readonly String[] m_ButtonDataList; //Field offset: 0x138
	private readonly String[] m_LayerIdList; //Field offset: 0x13C
	private ulong m_Filter; //Field offset: 0x140
	private ulong m_FilterBuf; //Field offset: 0x148
	private TMP_InputField m_InputField; //Field offset: 0x150
	private GameObject m_InputFieldObject; //Field offset: 0x154
	private Dictionary<Int32, FilterWork> m_FilterWorks; //Field offset: 0x158
	private Dictionary<Int32, Int32> m_ConvertFilterId; //Field offset: 0x15C
	private Dictionary<Int32, Int32> m_ConvertButtonId; //Field offset: 0x160

	public FilterDialogSubFilterStageSelectDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_0(BaseEventData _data) { }

	private void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	private bool CheckFilter(int _filterId) { }

	public virtual void CompResourceLoad() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void DispUpdate() { }

	private void FilterRegister(FilterGroup _group, eButtonId _buttonId, Filter _filterId, bool isAll = false) { }

	private ulong GetFilterAll() { }

	public virtual Vector2 GetPanelSize() { }

	public virtual object GetResultData(eResultType btn_res) { }

	private void Init(ulong _filter, string _search) { }

	protected virtual void InitUguiOther() { }

	private bool IsAllCheckOn() { }

	private bool IsCheckButton(int btnId) { }

	public virtual bool IsInputingKeyword() { }

	public virtual bool IsSelectFilter() { }

	protected virtual void LateUpdate() { }

	private void OnClickButton(eButtonId btnId) { }

	public virtual void SelectResetButton() { }

	private void SetButtonCheck(int btnId, bool isCheckOn) { }

	public virtual void SetInitialSelectButton() { }

	private void SetupText() { }

}

