namespace Heqet.Title;

public class CreditUIDisp : DispBase
{
	internal enum eButtonId
	{
		BACK = 0,
		NUM = 1,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
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
	private CreditUILayer m_Layer; //Field offset: 0x118
	private SelectableEx m_BackBtn; //Field offset: 0x11C
	private eUIState m_State; //Field offset: 0x120

	private static CreditUIDisp() { }

	public CreditUIDisp() { }

	[CompilerGenerated]
	private void <LayoutInit>b__11_0(int v) { }

	public virtual void Create(LayerBase parent_layer) { }

	public CreditDialog GetCreditDialogComponent() { }

	private GameObject GetFirstSelectButtonObject() { }

	public GameObject GetScrollRoot() { }

	public bool IsAnimation() { }

	protected virtual void LateUpdate() { }

	private void LayoutInit() { }

	public virtual void SetHide(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

