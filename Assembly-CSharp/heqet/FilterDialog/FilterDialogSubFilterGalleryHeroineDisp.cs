namespace Heqet.FilterDialog;

public class FilterDialogSubFilterGalleryHeroineDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		SERIES_ALL = 0,
		SERIES_001 = 1,
		SERIES_002 = 2,
		SERIES_003 = 3,
		SERIES_004 = 4,
		SERIES_005 = 5,
		SERIES_006 = 6,
		SERIES_007 = 7,
		SERIES_008 = 8,
		SERIES_009 = 9,
		SERIES_010 = 10,
		SERIES_011 = 11,
		SERIES_012 = 12,
		SERIES_013 = 13,
		SERIES_014 = 14,
		SERIES_015 = 15,
		SERIES_016 = 16,
		SERIES_017 = 17,
		SERIES_018 = 18,
		SERIES_019 = 19,
		SERIES_020 = 20,
		SERIES_021 = 21,
		SERIES_022 = 22,
		SERIES_023 = 23,
		SERIES_024 = 24,
		SERIES_025 = 25,
		SERIES_026 = 26,
		SERIES_027 = 27,
		SERIES_028 = 28,
		SERIES_029 = 29,
		SERIES_030 = 30,
		SERIES_031 = 31,
		SERIES_032 = 32,
		SERIES_033 = 33,
		MAX = 34,
	}

	private enum eCommonLayerId
	{
		SERIES_ALL = 0,
		SERIES_001 = 1,
		SERIES_002 = 2,
		SERIES_003 = 3,
		SERIES_004 = 4,
		SERIES_005 = 5,
		SERIES_006 = 6,
		SERIES_007 = 7,
		SERIES_008 = 8,
		SERIES_009 = 9,
		SERIES_010 = 10,
		SERIES_011 = 11,
		SERIES_012 = 12,
		SERIES_013 = 13,
		SERIES_014 = 14,
		SERIES_015 = 15,
		SERIES_016 = 16,
		SERIES_017 = 17,
		SERIES_018 = 18,
		SERIES_019 = 19,
		SERIES_020 = 20,
		SERIES_021 = 21,
		SERIES_022 = 22,
		SERIES_023 = 23,
		SERIES_024 = 24,
		SERIES_025 = 25,
		SERIES_026 = 26,
		SERIES_027 = 27,
		SERIES_028 = 28,
		SERIES_029 = 29,
		SERIES_030 = 30,
		SERIES_031 = 31,
		SERIES_032 = 32,
		SERIES_033 = 33,
		TEXT_INPUT = 34,
		MAX = 35,
	}

	private enum eTextLayerId
	{
		LABEL_FREE_KEYWORD = 0,
		ABEL_FREE_KEYWORD_PLACEHOLDER = 1,
		LABEL_SERIES = 2,
		SERIES_ALL = 3,
		SERIES_001 = 4,
		SERIES_002 = 5,
		SERIES_003 = 6,
		SERIES_004 = 7,
		SERIES_005 = 8,
		SERIES_006 = 9,
		SERIES_007 = 10,
		SERIES_008 = 11,
		SERIES_009 = 12,
		SERIES_010 = 13,
		SERIES_011 = 14,
		SERIES_012 = 15,
		SERIES_013 = 16,
		SERIES_014 = 17,
		SERIES_015 = 18,
		SERIES_016 = 19,
		SERIES_017 = 20,
		SERIES_018 = 21,
		SERIES_019 = 22,
		SERIES_020 = 23,
		SERIES_021 = 24,
		SERIES_022 = 25,
		SERIES_023 = 26,
		SERIES_024 = 27,
		SERIES_025 = 28,
		SERIES_026 = 29,
		SERIES_027 = 30,
		SERIES_028 = 31,
		SERIES_029 = 32,
		SERIES_030 = 33,
		SERIES_031 = 34,
		SERIES_032 = 35,
		SERIES_033 = 36,
		MAX = 37,
	}

	private enum FilterGroup
	{
		SERIES = 0,
		ALL = 1,
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

	private static FilterDialogSubFilterGalleryHeroineDisp() { }

	public FilterDialogSubFilterGalleryHeroineDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__17_0(BaseEventData _data) { }

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

