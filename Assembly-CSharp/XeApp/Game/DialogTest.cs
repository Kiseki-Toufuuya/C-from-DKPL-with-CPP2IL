namespace XeApp.Game;

public class DialogTest : MonoBehaviour
{
	private class DialogInfo
	{
		public string name; //Field offset: 0x8
		public string desc; //Field offset: 0xC
		public Action action; //Field offset: 0x10

		public DialogInfo(string n, string d, Action a) { }

	}

	private enum STEP
	{
		WAIT = 0,
		DIALOG_UPDATE = 1,
	}

	public Font font; //Field offset: 0x10
	public int x; //Field offset: 0x14
	public int y; //Field offset: 0x18
	public int buttonWidth; //Field offset: 0x1C
	public int buttonHeight; //Field offset: 0x20
	private STEP step; //Field offset: 0x24
	private List<DialogInfo> dialogInfoList; //Field offset: 0x28
	private Vector2 scrollPosition; //Field offset: 0x2C

	public DialogTest() { }

	[CompilerGenerated]
	private void <EpisodeRelease>b__10_0(ButtonType btn) { }

	public void EpisodeRelease() { }

	public void ItemUse() { }

	public void OnGUI() { }

	public void Start() { }

	public void Update() { }

}

