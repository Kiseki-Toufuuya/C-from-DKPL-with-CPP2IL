namespace Heqet.Title;

public class KaguraLayoutSelectDisp : DispBase
{
	private struct ButtonData
	{
		public GameObject obj; //Field offset: 0x0
		public GameObject selectFrame; //Field offset: 0x4

	}

	internal enum eButtonId
	{
		NORMAL = 0,
		TOUCH = 1,
		SCREEN = 2,
		NUM = 3,
	}

	private enum eCommonLayerId
	{
		Max = 0,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
	}

	private static readonly String[] m_ButtonIdList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	public Action<Int32> buttonOnClick; //Field offset: 0x114
	private eUIState m_State; //Field offset: 0x118
	private ButtonData m_normalButton; //Field offset: 0x11C
	private ButtonData m_touchButton; //Field offset: 0x124

	private static KaguraLayoutSelectDisp() { }

	public KaguraLayoutSelectDisp() { }

	[CompilerGenerated]
	private void <LayoutInit>b__11_0(int v) { }

	public void CallbackDeselectButton(int button_id, BaseEventData baseData) { }

	public void CallbackSelectButton(int button_id, BaseEventData baseData) { }

	public virtual void Create(LayerBase parent_layer) { }

	private GameObject GetFirstSelectButtonObject() { }

	public bool IsAnimation() { }

	protected virtual void LateUpdate() { }

	private void LayoutInit() { }

	private void SelectButton(int button_id, bool isSelect) { }

	public virtual void SetHide(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

