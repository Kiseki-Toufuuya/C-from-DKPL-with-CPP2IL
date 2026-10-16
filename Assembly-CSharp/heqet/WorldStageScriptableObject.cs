namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/WorldStageRepository")]
[MovedFrom(False, null, null, "WorldStageRepository")]
public class WorldStageScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int DlcID; //Field offset: 0xC
		public int SpotID; //Field offset: 0x10
		public int SortNo; //Field offset: 0x14
		public string Name; //Field offset: 0x18
		public string NameYomi; //Field offset: 0x1C
		public int OpenConditionsID; //Field offset: 0x20
		public bool IsHidden; //Field offset: 0x24
		public StageType StageTypeID; //Field offset: 0x28
		public Attribute AttributeID; //Field offset: 0x2C
		public RythmGameType RythmGameTypeID; //Field offset: 0x30
		public int StageLevel; //Field offset: 0x34
		public int BackgroundID; //Field offset: 0x38
		public int MusicDataFileID; //Field offset: 0x3C
		public int BossID; //Field offset: 0x40
		public int BossDefeatBonus; //Field offset: 0x44
		public Int32[] StageRewardArrayID; //Field offset: 0x48
		public int RenaissanceValue; //Field offset: 0x4C
		public int DisplayOrder; //Field offset: 0x50
		public int AcquirableMoney; //Field offset: 0x54
		public int AcquirableExp; //Field offset: 0x58
		public Int32[] ClearConditionsTypeIDArray; //Field offset: 0x5C
		public Int32[] StageGimmickTypeiDArray; //Field offset: 0x60
		public int ArrivalEpisodeID; //Field offset: 0x64
		public Int32[] MusicDifficultyIDArray; //Field offset: 0x68
		public int HelpGroupID; //Field offset: 0x6C
		public int FailedHelpGroupID; //Field offset: 0x70
		public int RecommendCardID; //Field offset: 0x74

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public WorldStageScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

