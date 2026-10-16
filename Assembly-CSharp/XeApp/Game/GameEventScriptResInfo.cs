namespace XeApp.Game;

public struct GameEventScriptResInfo
{
	private string m_Path; //Field offset: 0x0
	private int m_Num; //Field offset: 0x4
	private bool m_Loop; //Field offset: 0x8

	public bool Loop
	{
		 get { } //Length: 11
	}

	public int Num
	{
		 get { } //Length: 11
	}

	public string Path
	{
		 get { } //Length: 10
	}

	public GameEventScriptResInfo(string path, int num) { }

	public GameEventScriptResInfo(string path, int num, bool roop) { }

	public bool get_Loop() { }

	public int get_Num() { }

	public string get_Path() { }

}

