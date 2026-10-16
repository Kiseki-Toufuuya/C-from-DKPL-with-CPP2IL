namespace XeApp.Game;

public class ButtonManager
{
	internal class ButtonArg
	{
		public Action ClickCallBack; //Field offset: 0x8
		public Func<Boolean> IsEnable; //Field offset: 0xC
		public Func<Boolean> IsEndAction; //Field offset: 0x10
		public Action<String> m_CallbackDown; //Field offset: 0x14
		public Action<String> m_CallbackUp; //Field offset: 0x18
		public Func<String, Boolean> m_CallbackEnable; //Field offset: 0x1C
		public Func<String, Boolean> m_CallbackNext; //Field offset: 0x20
		public string m_Tag; //Field offset: 0x24
		public float m_WaitTime; //Field offset: 0x28

		public ButtonArg(Action callback, Func<Boolean> act_chk, Func<Boolean> end_chk, float wait_time) { }

		public ButtonArg(string tag, Action<String> cb_down, Action<String> cb_up, Func<String, Boolean> cb_enable, Func<String, Boolean> cb_next, float wait_time) { }

	}

	private class LongTapArg
	{
		public Action<String, Single, Boolean> m_CallbackUpdate; //Field offset: 0x8
		public Action<String, Single, Boolean> m_CallbackUp; //Field offset: 0xC
		public Action<String, Single> m_CallbackComp; //Field offset: 0x10
		public string m_Tag; //Field offset: 0x14
		public float m_LongTapTime; //Field offset: 0x18
		public float m_SecTapStart; //Field offset: 0x1C
		public float m_SecTapComp; //Field offset: 0x20
		public bool m_LongTapCompFg; //Field offset: 0x24

		public LongTapArg(string tag, float sec, Action<String, Single, Boolean> cb_update, Action<String, Single, Boolean> cb_up, Action<String, Single> cb_comp) { }

	}

	public const float BUTTON_WAIT_TIME = 0.3; //Field offset: 0x0
	private static ButtonManager m_Instance; //Field offset: 0x0
	private Dictionary<UiButtonBase, ButtonArg> m_CallbackList; //Field offset: 0x8
	private Dictionary<UiButtonBase, LongTapArg> m_LongTapList; //Field offset: 0xC
	private Func<String, Boolean> m_CallbackNext; //Field offset: 0x10
	private UiButtonBase m_ActButton; //Field offset: 0x14
	private UiButtonBase m_ActLongTapAct; //Field offset: 0x18
	private float m_WaitTime; //Field offset: 0x1C
	private float m_PrevVokeTime; //Field offset: 0x20
	private bool m_DeactiveAllFg; //Field offset: 0x24
	private Func<Boolean> m_EndChkTask; //Field offset: 0x28

	public UiButtonBase ActButton
	{
		 get { } //Length: 11
	}

	public static ButtonManager Instance
	{
		 get { } //Length: 40
	}

	public ButtonManager() { }

	public void AddCallback(UiButtonBase button, Action click, Func<Boolean> act_check = null, Func<Boolean> end_check = null) { }

	public void AddCallback(UiButtonBase button, string tag, Action<String> cb_down, Action<String> cb_up = null, Func<String, Boolean> cb_enable = null, Func<String, Boolean> cb_next = null, float next_rag = -1) { }

	public void AddCallbackLongTap(UiButtonBase button, string tag, float sec, Action<String, Single, Boolean> cb_update, Action<String, Single, Boolean> cb_up = null, Action<String, Single> cb_comp = null) { }

	private void ButtonDownCallback(UiButtonBase button) { }

	private void ButtonExitCallback(UiButtonBase button) { }

	private void ButtonUpCallback(UiButtonBase button) { }

	public bool ChkButtonAllActive() { }

	private void ChkLongTapStart(UiButtonBase button) { }

	private void ChkLongTapUp(UiButtonBase button) { }

	public void Create() { }

	public void DeleteCallback(UiButtonBase button) { }

	public UiButtonBase get_ActButton() { }

	public static ButtonManager get_Instance() { }

	public bool GetButtonDeactiveAll() { }

	public void SetButtonDeactiveAll(bool deactive) { }

	public void Update() { }

	private void UpdateLongTap() { }

}

