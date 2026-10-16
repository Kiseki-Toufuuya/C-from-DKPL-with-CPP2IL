namespace XeApp.Game;

public class UguiButtonManager
{
	internal class ButtonArg
	{
		public Action<Int32> m_CallbackDown; //Field offset: 0x8
		public Action<Int32> m_CallbackUp; //Field offset: 0xC
		public Action<Int32> m_CallbackEnd; //Field offset: 0x10
		public Func<Int32, Boolean> m_CallbackEnable; //Field offset: 0x14
		public Func<Int32, Boolean> m_CallbackNext; //Field offset: 0x18
		public float m_WaitTime; //Field offset: 0x1C
		public int m_ThroughId; //Field offset: 0x20
		public int m_NameId; //Field offset: 0x24
		public bool m_EnableFg; //Field offset: 0x28
		public ALL_SE m_BtnDownSeId; //Field offset: 0x2C
		public ALL_SE m_BtnUpSeId; //Field offset: 0x30
		public ALL_SE m_BackupBtnDownSeId; //Field offset: 0x34
		public ALL_SE m_BackupBtnUpSeId; //Field offset: 0x38

		public ButtonArg(int through_id, int name_id, Action<Int32> cb_down, Action<Int32> cb_up, Func<Int32, Boolean> cb_enable, Func<Int32, Boolean> cb_next, Action<Int32> cb_end, float wait_time) { }

		public void HideBtnSe() { }

		public void ResetBtnSe() { }

		public void SetBtnDownSe(ALL_SE seId = -1) { }

		public void SetBtnSe(ALL_SE downSeId = -1, ALL_SE upSeId = -1) { }

		public void SetBtnUpSe(ALL_SE seId = -1) { }

		public void SetParam(int through_id, int name_id, Action<Int32> cb_down, Action<Int32> cb_up, Func<Int32, Boolean> cb_enable, Func<Int32, Boolean> cb_next, Action<Int32> cb_end, float wait_time) { }

	}

	private class LongTapArg
	{
		public Action<Int32, Single, Boolean> m_CallbackUpdate; //Field offset: 0x8
		public Action<Int32, Single, Boolean> m_CallbackUp; //Field offset: 0xC
		public Action<Int32, Single> m_CallbackComp; //Field offset: 0x10
		public float m_LongTapTime; //Field offset: 0x14
		public float m_SecTapStart; //Field offset: 0x18
		public float m_SecTapComp; //Field offset: 0x1C
		public int m_ThroughId; //Field offset: 0x20
		public int m_NameId; //Field offset: 0x24
		public bool m_LongTapCompFg; //Field offset: 0x28
		public ALL_SE m_BtnLongSeCueId; //Field offset: 0x2C

		public LongTapArg(int through_id, int name_id, float sec, Action<Int32, Single, Boolean> cb_update, Action<Int32, Single, Boolean> cb_up, Action<Int32, Single> cb_comp) { }

		public void SetBtnSe(ALL_SE seId = 100061) { }

		public void SetParam(int through_id, int name_id, float sec, Action<Int32, Single, Boolean> cb_update, Action<Int32, Single, Boolean> cb_up, Action<Int32, Single> cb_comp) { }

	}

	public const float BUTTON_WAIT_TIME = 0.5; //Field offset: 0x0
	private static UguiButtonManager m_Instance; //Field offset: 0x0
	private Dictionary<UIWrapperButton, ButtonArg> m_CallbackList; //Field offset: 0x8
	private Dictionary<UIWrapperButton, LongTapArg> m_LongTapList; //Field offset: 0xC
	private Func<Int32, Boolean> m_CallbackNext; //Field offset: 0x10
	private List<Int32> m_ThroughIdList; //Field offset: 0x14
	private UIWrapperButton m_ActButton; //Field offset: 0x18
	private UIWrapperButton m_ActLongTapAct; //Field offset: 0x1C
	private float m_WaitTime; //Field offset: 0x20
	private float m_PrevVokeTime; //Field offset: 0x24
	private int m_ThroughId; //Field offset: 0x28
	private bool m_DeactiveAllFg; //Field offset: 0x2C
	private bool m_ThroughIdLoop; //Field offset: 0x2D
	private Action m_onActButton; //Field offset: 0x30

	public UIWrapperButton ActButton
	{
		 get { } //Length: 11
	}

	public Dictionary<UIWrapperButton, ButtonArg> CallbackList
	{
		 get { } //Length: 11
	}

	public static UguiButtonManager Instance
	{
		 get { } //Length: 40
	}

	public Action OnActButton
	{
		 set { } //Length: 27
	}

	public UguiButtonManager() { }

	[CompilerGenerated]
	private bool <Create>b__24_0() { }

	public int AddCallback(UIWrapperButton button, int name_id, Action<Int32> cb_down, Action<Int32> cb_up = null, Func<Int32, Boolean> cb_enable = null, Func<Int32, Boolean> cb_next = null, Action<Int32> cb_end = null, float next_rag = -1) { }

	public void AddCallbackLongTap(int through_id, int name_id, float sec, Action<Int32, Single, Boolean> cb_update, Action<Int32, Single, Boolean> cb_up = null, Action<Int32, Single> cb_comp = null) { }

	private void ButtonDownCallback(TouchInfo info, int through_id) { }

	private void ButtonEndCallback(int through_id) { }

	private void ButtonExitCallback(int through_id) { }

	private void ButtonUpCallback(int through_id) { }

	public void CallbackButtonUp(int through_id) { }

	public bool ChkButtonAllActive() { }

	private bool ChkLongTapStart(int through_id) { }

	private void ChkLongTapUp(int through_id) { }

	public void Create() { }

	public void DeleteCallback(int through_id) { }

	public void DeleteCallbackLongTap(int through_id) { }

	public UIWrapperButton get_ActButton() { }

	public Dictionary<UIWrapperButton, ButtonArg> get_CallbackList() { }

	public static UguiButtonManager get_Instance() { }

	public bool GetButtonDeactiveAll() { }

	public bool GetButtonEnable(int through_id) { }

	public void PlayButtonUp(int through_id) { }

	public void ResetActLongTapAct() { }

	public void set_OnActButton(Action value) { }

	public void SetButtonDeactiveAll(bool deactive) { }

	public void SetButtonDownSe(UIWrapperButton button, ALL_SE downSeId = 100061) { }

	public void SetButtonDownUpSe(UIWrapperButton button, ALL_SE downSeId = 100061, ALL_SE upSeId = 100061) { }

	public void SetButtonEnable(int through_id, bool enable) { }

	public void SetButtonLongSe(UIWrapperButton button, ALL_SE seId = 100061) { }

	public void SetButtonSeEnable(int through_id, bool enable) { }

	public void SetButtonUpSe(UIWrapperButton button, ALL_SE upSeId = 100061) { }

	public void Update() { }

	private void UpdateLongTap() { }

}

