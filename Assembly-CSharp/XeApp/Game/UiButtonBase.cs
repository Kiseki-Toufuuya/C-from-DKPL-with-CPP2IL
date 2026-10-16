namespace XeApp.Game;

public class UiButtonBase : LayoutUGUIScriptBase
{
	[SerializeField]
	private EventTrigger m_EventTrigger; //Field offset: 0x10
	private Action<UiButtonBase> m_FuncInitLayout; //Field offset: 0x14
	private Action<UiButtonBase> m_FuncUpdate; //Field offset: 0x18
	private Action<UiButtonBase> m_FuncDown; //Field offset: 0x1C
	private Action<UiButtonBase> m_FuncOnClick; //Field offset: 0x20
	private Action<UiButtonBase> m_FuncExit; //Field offset: 0x24
	private LayoutUGUIButton m_UguiButton; //Field offset: 0x28
	private string m_Name; //Field offset: 0x2C
	private bool m_InitFg; //Field offset: 0x30
	private bool m_DragKeepFg; //Field offset: 0x31
	private bool m_Enable; //Field offset: 0x32

	public bool DragKeepFlag
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private EventTrigger EventTrigger
	{
		private get { } //Length: 142
	}

	public Action<UiButtonBase> FuncDown
	{
		 set { } //Length: 27
	}

	public Action<UiButtonBase> FuncExit
	{
		 set { } //Length: 27
	}

	public Action<UiButtonBase> FuncInitLayout
	{
		 set { } //Length: 27
	}

	public Action<UiButtonBase> FuncOnClick
	{
		 set { } //Length: 27
	}

	public Action<UiButtonBase> FuncUpdate
	{
		 set { } //Length: 27
	}

	public UiButtonBase() { }

	public bool ChkInitLayout() { }

	public bool get_DragKeepFlag() { }

	private EventTrigger get_EventTrigger() { }

	public bool GetEnable() { }

	public virtual bool InitializeFromLayout(Layout layout, TexUVListManager[] uvlist) { }

	public void PointerClick() { }

	public void PointerDown() { }

	public void PointerExit() { }

	public void set_DragKeepFlag(bool value) { }

	public void set_FuncDown(Action<UiButtonBase> value) { }

	public void set_FuncExit(Action<UiButtonBase> value) { }

	public void set_FuncInitLayout(Action<UiButtonBase> value) { }

	public void set_FuncOnClick(Action<UiButtonBase> value) { }

	public void set_FuncUpdate(Action<UiButtonBase> value) { }

	public void SetEnable(bool is_touch, bool enable) { }

	private void Udpate() { }

}

