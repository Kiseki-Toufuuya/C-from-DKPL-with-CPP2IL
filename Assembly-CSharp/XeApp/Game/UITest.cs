namespace XeApp.Game;

public class UITest : MainSceneBase
{
	private enum STEP
	{
		WAIT = 0,
		UI_UPDATE = 1,
	}

	internal class TalkPopupData
	{
		public TALK_TYPE type; //Field offset: 0x8
		[Multiline(3)]
		public List<String> talkList; //Field offset: 0xC
		public bool isLeft; //Field offset: 0x10
		public float dispSpeed; //Field offset: 0x14
		public float dispTime; //Field offset: 0x18

		public TalkPopupData() { }

	}

	private class UIInfo
	{
		public string name; //Field offset: 0x8
		public string desc; //Field offset: 0xC
		public Action action; //Field offset: 0x10

		public UIInfo(string n, string d, Action a) { }

	}

	public Font font; //Field offset: 0x14
	public int x; //Field offset: 0x18
	public int y; //Field offset: 0x1C
	public int buttonWidth; //Field offset: 0x20
	public int buttonHeight; //Field offset: 0x24
	public TalkPopupData talkPopupData; //Field offset: 0x28
	private STEP step; //Field offset: 0x2C
	private List<UIInfo> uiInfoList; //Field offset: 0x30
	private Vector2 scrollPosition; //Field offset: 0x34
	private TalkPopupUI talkPopupUI; //Field offset: 0x3C
	private UITestRootLayer m_rootLayer; //Field offset: 0x40

	public UITest() { }

	protected virtual void DoAwake() { }

	public void OnDestroy() { }

	public void OnGUI() { }

	public void OnTapBack() { }

	public void Start() { }

	public void TalkPopupButton() { }

	public void Update() { }

}

