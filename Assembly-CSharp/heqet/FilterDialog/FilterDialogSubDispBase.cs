namespace Heqet.FilterDialog;

public abstract class FilterDialogSubDispBase : UiScrollListPanelBase
{
	[CompilerGenerated]
	private Action<GameObject> <OnSelectedCallback>k__BackingField; //Field offset: 0x130

	public Action<GameObject> OnSelectedCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	protected FilterDialogSubDispBase() { }

	[CompilerGenerated]
	public Action<GameObject> get_OnSelectedCallback() { }

	public abstract object GetResultData(eResultType btn_res) { }

	public override bool IsInputingKeyword() { }

	public override bool IsSelectFilter() { }

	protected override void OnSelectButton(int button_id, BaseEventData _data) { }

	public override void SelectResetButton() { }

	[CompilerGenerated]
	public void set_OnSelectedCallback(Action<GameObject> value) { }

	protected override void SetFilterButtonSe(int btn_id) { }

	public override void SetFilterFlag(ulong filter) { }

	public override void SetInitialSelectButton() { }

	public override void SetSortType(int sort, int order) { }

	protected virtual void UpdateDispMain() { }

}

