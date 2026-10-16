namespace Heqet.Title;

public class DlcListDialogDisp : DispBase
{
	internal enum eButtonId
	{
		BACK = 0,
		GO_TO_STORE = 1,
		SCREEN = 2,
		NUM = 3,
	}

	private enum eCommonLayerId
	{
		Max = 0,
	}

	private enum eTextId
	{
		Body = 0,
		Max = 1,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
	}

	private static readonly String[] m_ButtonIdList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	public Action<Int32> backOnClick; //Field offset: 0x114
	private String[] m_TextList; //Field offset: 0x118
	private SelectableEx m_BackBtn; //Field offset: 0x11C
	private eUIState m_State; //Field offset: 0x120

	private static DlcListDialogDisp() { }

	public DlcListDialogDisp() { }

	[CompilerGenerated]
	private void <LayoutInit>b__12_0(int v) { }

	public virtual void Create(LayerBase parent_layer) { }

	public CreditDialog GetCreditDialogComponent() { }

	private GameObject GetFirstSelectButtonObject() { }

	public GameObject GetGotoStoreButtonObject() { }

	public bool IsAnimation() { }

	protected virtual void LateUpdate() { }

	private void LayoutInit() { }

	public virtual void SetHide(bool enable) { }

	public void SetupDisp() { }

	protected virtual void UpdateDispMain() { }

}

