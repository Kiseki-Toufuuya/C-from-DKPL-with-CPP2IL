namespace XeApp.Game;

public class GameEventScriptBase
{
	private enum MODE
	{
		INIT = 0,
		UPDATE = 1,
		IDLE = 2,
	}

	private MODE m_Mode; //Field offset: 0x8
	private GameEventScriptPlay m_Play; //Field offset: 0xC

	public GameEventScriptPlay ScriptPlay
	{
		 get { } //Length: 11
	}

	public GameEventScriptBase() { }

	public GameEventScriptPlay get_ScriptPlay() { }

	public List<GameEventScriptLogInfo> GetLogList() { }

	public bool IsEnd() { }

	private bool IsInit() { }

	private bool MainUpdate() { }

	public GameEventScriptBase Setup() { }

	public void UpDate() { }

}

