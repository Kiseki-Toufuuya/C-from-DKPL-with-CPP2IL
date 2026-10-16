namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/NotesSkinRepository")]
[MovedFrom(False, null, null, "NotesSkinRepository")]
public class NotesSkinScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int Enable; //Field offset: 0xC
		public int DataVersion; //Field offset: 0x10
		public int UseFlag; //Field offset: 0x14
		public int NotesGroupID; //Field offset: 0x18
		public int TapEffectGroupID; //Field offset: 0x1C
		public int LeneEffectGroupID; //Field offset: 0x20

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public NotesSkinScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

