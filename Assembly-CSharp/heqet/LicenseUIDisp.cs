namespace Heqet;

public class LicenseUIDisp : DispBase
{
	internal enum eButtonId
	{
		BACK = 0,
	}

	private enum eTextId
	{
		TEXT_LISENCE = 0,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
		WAIT = 3,
	}

	private static readonly String[] m_ButtonIdList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	public Action<Int32> backOnClick; //Field offset: 0x114
	private GameObject SelectedBuf; //Field offset: 0x118
	private List<UIWrapperButton> Buttons; //Field offset: 0x11C
	private SelectableEx m_BackBtn; //Field offset: 0x120
	private eUIState m_State; //Field offset: 0x124
	private readonly float SCROLL_SIZE; //Field offset: 0x128
	private readonly float SCROLL_SIZE_CN; //Field offset: 0x12C

	private static LicenseUIDisp() { }

	public LicenseUIDisp() { }

	[CompilerGenerated]
	private void <LayoutInit>b__11_0(int v) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void LateUpdate() { }

	private void LayoutInit() { }

	public virtual void SetHide(bool enable) { }

	public void SetLicenseText(ref string _license) { }

	private int StrCount(string s) { }

	protected virtual void UpdateDispMain() { }

}

