namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeqetMusic")]
[MovedFrom(False, null, null, "HeqetMusicRepository")]
public class HeqetMusicScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int DlcID; //Field offset: 0xC
		public string Title; //Field offset: 0x10
		public int WavID; //Field offset: 0x14
		public int ScoreBaseID; //Field offset: 0x18
		public int NotShowBossSpellName; //Field offset: 0x1C
		public int CoverID; //Field offset: 0x20
		public int BackgroundID; //Field offset: 0x24
		public int MusicDateFileID; //Field offset: 0x28
		public int CharaType; //Field offset: 0x2C
		public int BossID; //Field offset: 0x30
		public int BossID2; //Field offset: 0x34
		public int BossID3; //Field offset: 0x38
		public int BossHp; //Field offset: 0x3C
		public int MusicStartTime; //Field offset: 0x40
		public int SpellCardID; //Field offset: 0x44
		public int SpellCard2ID; //Field offset: 0x48
		public int SpellCard3ID; //Field offset: 0x4C
		public string IllustratorName; //Field offset: 0x50
		public int CreaterNo; //Field offset: 0x54
		public string Circle; //Field offset: 0x58
		public string CircleYomi; //Field offset: 0x5C
		public string TitleYomi; //Field offset: 0x60
		public string Vocal; //Field offset: 0x64
		public string Part1; //Field offset: 0x68
		public string Part2; //Field offset: 0x6C
		public string Part3; //Field offset: 0x70
		public string Part4; //Field offset: 0x74
		public string Part5; //Field offset: 0x78
		public string Part6; //Field offset: 0x7C
		public string Part7; //Field offset: 0x80
		public string Part8; //Field offset: 0x84
		public string Part9; //Field offset: 0x88
		public string Part10; //Field offset: 0x8C
		public string Part11; //Field offset: 0x90
		public string DispBPM; //Field offset: 0x94
		public float BaseBPM; //Field offset: 0x98
		public int CircleDispType; //Field offset: 0x9C
		public int CategoryBitFlags; //Field offset: 0xA0
		public Int32[] OriginalSongsSeriesArray; //Field offset: 0xA4

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public HeqetMusicScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

