namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/DlcListRepository")]
[MovedFrom(False, null, null, "DlcListRepository")]
public class DlcListScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string DeveloperText; //Field offset: 0xC
		public int SteamDevAppID; //Field offset: 0x10
		public int SteamAppID; //Field offset: 0x14
		public int SwitchAocIndex; //Field offset: 0x18
		public string PS4EntitlementLabel; //Field offset: 0x1C
		public string PS4ProductLabel; //Field offset: 0x20
		public string Title; //Field offset: 0x24
		public int MusicFolderID; //Field offset: 0x28
		public int NewRelease; //Field offset: 0x2C
		public string SteamURL; //Field offset: 0x30

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public DlcListScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

