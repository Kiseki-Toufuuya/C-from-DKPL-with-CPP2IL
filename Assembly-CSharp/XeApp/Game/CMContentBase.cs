namespace XeApp.Game;

public class CMContentBase
{
	[CompilerGenerated]
	private Button <TitleButton>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <TitleName>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <SceneName>k__BackingField; //Field offset: 0x10
	protected OnActiveContentCallback onActiveContentCB; //Field offset: 0x14
	protected OnDeactiveContentCallback onDeactiveContentCB; //Field offset: 0x18

	public string SceneName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Button TitleButton
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string TitleName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public CMContentBase(string titleName, string sceneName, OnActiveContentCallback onActiveContentCallback, OnDeactiveContentCallback onDeactiveContentCallback = null) { }

	[CompilerGenerated]
	public string get_SceneName() { }

	[CompilerGenerated]
	public Button get_TitleButton() { }

	[CompilerGenerated]
	public string get_TitleName() { }

	public override void OnActiveContent(CMContentList contentList) { }

	public override void OnDeactiveContent() { }

	public override void OnUpdateContent() { }

	[CompilerGenerated]
	protected void set_SceneName(string value) { }

	[CompilerGenerated]
	public void set_TitleButton(Button value) { }

	[CompilerGenerated]
	protected void set_TitleName(string value) { }

}

