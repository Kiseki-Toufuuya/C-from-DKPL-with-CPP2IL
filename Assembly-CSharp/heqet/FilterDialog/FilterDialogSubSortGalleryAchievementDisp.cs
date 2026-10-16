namespace Heqet.FilterDialog;

public class FilterDialogSubSortGalleryAchievementDisp : FilterDialogSubDispBase
{
	private enum eButtonId
	{
		SORT_NO = 0,
		ORDER_ASC = 1,
		ORDER_DESC = 2,
		MAX = 3,
	}

	private enum eCommonLayerId
	{
		SORT_NO = 0,
		ORDER_ASC = 1,
		ORDER_DESC = 2,
		MAX = 3,
	}

	private enum eTextLayerId
	{
		LABEL_1 = 0,
		LABEL_2 = 1,
		SORT_NO = 2,
		ORDER_ASC = 3,
		ORDER_DESC = 4,
		MAX = 5,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private String[] m_TextLayerIdList; //Field offset: 0x134
	private String[] m_ButtonDataList; //Field offset: 0x138
	private eButtonId m_SelectSortBtnId; //Field offset: 0x13C
	private eButtonId m_SelectOrderBtnId; //Field offset: 0x140
	private int m_SortID; //Field offset: 0x144
	private Order m_OrderID; //Field offset: 0x148

	private static FilterDialogSubSortGalleryAchievementDisp() { }

	public FilterDialogSubSortGalleryAchievementDisp() { }

	private void CallbackButton(int btnId) { }

	private void CallbackInitLayout() { }

	public virtual void CompResourceLoad() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void DispUpdate() { }

	public virtual Vector2 GetPanelSize() { }

	public virtual object GetResultData(eResultType btn_res) { }

	private Order GetSelectOrder() { }

	protected virtual void InitUguiOther() { }

	private bool IsCheckButton(int btnId) { }

	protected virtual void LateUpdate() { }

	public virtual void SelectResetButton() { }

	private void SetButtonCheck(int btnId, bool isCheckOn) { }

	private void SetButtonOnOrderGroup(int btnId) { }

	private void SetButtonOnSortGroup(int btnId) { }

	public virtual void SetInitialSelectButton() { }

	private void SetLocalizeText() { }

	protected virtual void UpdateDispMain() { }

}

