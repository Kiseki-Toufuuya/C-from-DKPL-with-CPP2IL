namespace XeApp;

public class DebugSceneSelector
{
	internal enum State
	{
		Exec = 0,
		Next = 1,
		Exit = 2,
	}

	private const int EXIT_BUTTON_SPAN = 2; //Field offset: 0x0
	private const string EXIT_NAME = "Exit"; //Field offset: 0x0
	public int x; //Field offset: 0x8
	public int y; //Field offset: 0xC
	public int buttonWidth; //Field offset: 0x10
	public int buttonHeight; //Field offset: 0x14
	public List<DebugSceneInfo> sceneList; //Field offset: 0x18
	[CompilerGenerated]
	private string <selectedSceneName>k__BackingField; //Field offset: 0x1C
	private Vector2 mScrollPosition; //Field offset: 0x20

	public private string selectedSceneName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public DebugSceneSelector() { }

	[CompilerGenerated]
	public string get_selectedSceneName() { }

	public State OnGUI() { }

	[CompilerGenerated]
	private void set_selectedSceneName(string value) { }

}

