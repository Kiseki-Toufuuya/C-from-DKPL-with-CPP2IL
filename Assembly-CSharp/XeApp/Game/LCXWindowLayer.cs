namespace XeApp.Game;

public class LCXWindowLayer : UiScrollListLayerBase
{
	internal enum eButtonType
	{
		ScreenButton = 0,
		Window_Button1 = 1,
		Window_Button2 = 2,
		Window_Button3 = 3,
		Window_Button4 = 4,
		Window_Button5 = 5,
		None = 6,
	}

	internal enum eWindowType
	{
		None = 0,
		WhatsSignIn = 1,
		WhatsRegist = 2,
		WhatsAddAccount = 3,
		GuestModeAttention = 4,
		GuestModeAttention_Continue = 5,
		InputIDPassward = 6,
		RegistIDPassward = 7,
		GameDataAttention = 8,
		GameDataInvalid = 9,
		GameDataDelete = 10,
		InputIDPasswardError = 11,
		RegistSuccess = 12,
		InputIDPasswardExpired = 13,
		InputIDPasswardPlayerNotFound = 14,
		EosNoRefund = 15,
		EosRefund = 16,
	}

	internal class LayerArgument
	{
		public eWindowType windowType; //Field offset: 0x8
		public string title; //Field offset: 0xC
		public String[] param; //Field offset: 0x10
		public bool disableScreenButton; //Field offset: 0x14
		public Action<OutputParam> callback; //Field offset: 0x18
		public eButtonType[] notCloseButton; //Field offset: 0x1C
		public Action<OutputParam> notCloseCallback; //Field offset: 0x20

		public LayerArgument() { }

	}

	internal class OutputParam
	{
		public eButtonType buttonType; //Field offset: 0x8
		public String[] inputText; //Field offset: 0xC

		public OutputParam() { }

	}

	private LayerArgument m_LayerArg; //Field offset: 0x7C

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 47
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 47
	}

	public LayerArgument LayerArg
	{
		 set { } //Length: 27
	}

	public LCXWindowLayer() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void set_LayerArg(LayerArgument value) { }

	protected virtual void Update(bool is_active) { }

}

