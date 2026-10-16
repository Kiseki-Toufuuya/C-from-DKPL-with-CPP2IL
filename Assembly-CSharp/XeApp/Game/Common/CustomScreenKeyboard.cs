namespace XeApp.Game.Common;

public class CustomScreenKeyboard : LayerBase
{
	private enum eState
	{
		INIT = 0,
		IDLE = 1,
		EXIT = 2,
	}

	private TouchScreenKeyboard m_SystemKeybord; //Field offset: 0x58
	private Action<String> m_ResultCallBack; //Field offset: 0x5C
	private string m_strInitInputBox; //Field offset: 0x60
	private eState m_eState; //Field offset: 0x64
	private string m_strReleaseInput; //Field offset: 0x68
	private TouchScreenKeyboardType m_InputType; //Field offset: 0x6C
	private int m_DebugCount; //Field offset: 0x70

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 6
	}

	public CustomScreenKeyboard() { }

	private TouchScreenKeyboard CreateKeyBoard() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	protected virtual void InitAll() { }

	public void InitKeyboard(Action<String> result_callback, string init_str = null, TouchScreenKeyboardType init_mode = 0) { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

