namespace Heqet;

public class DlcListModel : EntityBase<DlcListModel, Int32>
{
	private const string DummyLabel = "dummy"; //Field offset: 0x0
	public int ID; //Field offset: 0xC
	public string DeveloperText; //Field offset: 0x10
	public int SteamDevAppID; //Field offset: 0x14
	public int SteamAppID; //Field offset: 0x18
	public int SwitchAocIndex; //Field offset: 0x1C
	public string PS4EntitlementLabel; //Field offset: 0x20
	public string PS4ProductLabel; //Field offset: 0x24
	public string Title; //Field offset: 0x28
	public int MusicFolderID; //Field offset: 0x2C
	public bool NewRelease; //Field offset: 0x30
	public string SteamURL; //Field offset: 0x34

	public DlcListModel() { }

	public bool isExistencePackage() { }

}

