namespace Heqet.Title;

public class ResetDataDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, BaseEventData> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <LayoutInit>b__17_0(int _id, BaseEventData _data) { }

	}

	private enum eImageId
	{
		DeleteProgress = 0,
		Max = 1,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
		WAIT = 3,
		CLEAR = 4,
	}

	private const int RUN_TIME = 5; //Field offset: 0x0
	public Action<Int32> buttonOnClick; //Field offset: 0x114
	private readonly string CHECK_PANEL; //Field offset: 0x118
	private readonly String[] BUTTON_DATA_LIST; //Field offset: 0x11C
	private String[] m_ImageList; //Field offset: 0x120
	private ResetDataLayer m_Layer; //Field offset: 0x124
	private SelectableEx m_ClearBtn; //Field offset: 0x128
	private SelectableEx m_StopBtn; //Field offset: 0x12C
	private eUIState m_State; //Field offset: 0x130
	private GameObject m_CheckPanel; //Field offset: 0x134
	private float m_TimeCount; //Field offset: 0x138
	private AtlasImage m_ProgressImage; //Field offset: 0x13C

	public ResetDataDisp() { }

	private void CallbackButton(int button_id) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void LateUpdate() { }

	private void LayoutInit() { }

	private void SelectBackButton() { }

	public void SelectStopButton() { }

	private void SetButtonNavigation(bool enable) { }

	public void SetCheckPanelEnable(bool enable) { }

	public virtual void SetHide(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

