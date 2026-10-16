namespace XeApp.Game;

public class GameParamManager
{
	public static GameParamManager instance; //Field offset: 0x0
	public GameParamMaster GameParamMasterData; //Field offset: 0x8
	public DialogParam DialogParamData; //Field offset: 0xC
	public LayoutBundleNameListParam BundleList; //Field offset: 0x10

	public GameParamManager() { }

	public void Create() { }

}

