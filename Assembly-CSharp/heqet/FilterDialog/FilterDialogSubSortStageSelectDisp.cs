namespace Heqet.FilterDialog;

public class FilterDialogSubSortStageSelectDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		SORT_NO = 0,
		SORT_NAME = 1,
		SORT_CIRCLE = 2,
		SORT_JUDGMENT = 3,
		SORT_LEVEL = 4,
		SORT_RANK = 5,
		SORT_HIGHSCORE = 6,
		SORT_TOTALNOTES = 7,
		SORT_PLAYCOUNT = 8,
		SORT_SERIES = 9,
		ORDER_ASC = 10,
		ORDER_DESC = 11,
	}

	private enum eTextId
	{
		LABEL_1 = 0,
		LABEL_2 = 1,
		SORT_NO = 2,
		SORT_NAME = 3,
		SORT_CIRCLE = 4,
		SORT_JUDGMENT = 5,
		SORT_LEVEL = 6,
		SORT_RANK = 7,
		SORT_HIGHSCORE = 8,
		SORT_TOTALNOTES = 9,
		SORT_PLAYCOUNT = 10,
		SORT_SERIES = 11,
		ORDER_ASC = 12,
		ORDER_DESC = 13,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private readonly string CHECK_OFF; //Field offset: 0x134
	private readonly string CHECK_ON; //Field offset: 0x138
	private String[] m_TextIdList; //Field offset: 0x13C
	private String[] m_ButtonDataList; //Field offset: 0x140
	private AtlasImage[] m_BtnImage; //Field offset: 0x144
	private int m_Sort; //Field offset: 0x148
	private int m_Order; //Field offset: 0x14C

	private static FilterDialogSubSortStageSelectDisp() { }

	public FilterDialogSubSortStageSelectDisp() { }

	private void CallbackButton(int btnId) { }

	private void CallbackInitLayout() { }

	public virtual void CompResourceLoad() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void DispUpdate() { }

	public virtual Vector2 GetPanelSize() { }

	public virtual object GetResultData(eResultType btn_res) { }

	private eButtonId GetSelectButtonBySortId(Sort _id) { }

	private int GetSelectOrder(eButtonId _id) { }

	private Sort GetSelectSortByButtonId(eButtonId _id) { }

	protected virtual void InitUguiOther() { }

	private bool IsCheckButton(int btnId) { }

	protected virtual void LateUpdate() { }

	public virtual void SelectResetButton() { }

	private void SetButtonCheck(int btnId, bool isCheckOn) { }

	private void SetButtonOnOrderGroup(int btnId) { }

	private void SetButtonOnSortGroup(int btnId) { }

	public virtual void SetInitialSelectButton() { }

	private void SetupText() { }

	protected virtual void UpdateDispMain() { }

}

