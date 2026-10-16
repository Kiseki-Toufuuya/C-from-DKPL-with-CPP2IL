namespace XeApp.Game;

public class GameManger
{
	private class sBackTask
	{
		public Func<Boolean> m_Action; //Field offset: 0x8
		public int m_Id; //Field offset: 0xC
		public UIWrapperButton m_GuiButton; //Field offset: 0x10

		public sBackTask(Func<Boolean> action, UIWrapperButton btn, int id) { }

	}

	public const float ANDROID_BACK_WAIT_TIME = 0.6; //Field offset: 0x0
	public static GameManger Instance; //Field offset: 0x0
	private List<sBackTask> m_AndroidBackTaskList; //Field offset: 0x8
	private sBackTask m_HeaderBackTask; //Field offset: 0xC
	private bool m_IsInvokeTask; //Field offset: 0x10
	private bool m_DisableBackKey; //Field offset: 0x11
	private float m_AndroidBackWaitTime; //Field offset: 0x14

	internal float AndroidBackWaitTime
	{
		internal get { } //Length: 11
		internal set { } //Length: 18
	}

	public GameManger() { }

	public void AddAndroidBackTask(UIWrapperButton btn, Func<Boolean> action = null, int id = -1) { }

	public bool ChkAndroidBackKey() { }

	public void ClearAndroidBackTask() { }

	private bool ConfirmCallbackEnable(sBackTask sBackTask) { }

	public void Create() { }

	public void DisableBackKey(bool flg) { }

	internal float get_AndroidBackWaitTime() { }

	internal bool IsAnimationHeader() { }

	public void PopAndroidBackTask(int id = -1) { }

	internal void set_AndroidBackWaitTime(float value) { }

	public void SetHeaderAndroidBackTask(UIWrapperButton btn, Func<Boolean> action = null, int id = -1) { }

	public void Update() { }

	public void VokeAndroidBackTask(int id = -1) { }

}

