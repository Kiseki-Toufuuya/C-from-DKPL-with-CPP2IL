namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/MusicScoreCountRepository")]
public class MusicScoreCountScriptableObject : ScriptableObject, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		[SerializeField]
		private DifficultyData[] difficulties; //Field offset: 0xC
		[SerializeField]
		private SerializableDictionary<Int32, DifficultyData> danmakuDifficulties; //Field offset: 0x10

		public SerializableDictionary<Int32, DifficultyData> DanmakuDifficulties
		{
			 get { } //Length: 11
		}

		public Data() { }

		public SerializableDictionary<Int32, DifficultyData> get_DanmakuDifficulties() { }

		public int GetDanmakuMusicScoreCount(int difficulty) { }

		public int GetKaguraMusicScoreCount(int difficulty, LaneMode laneMode) { }

	}

	internal class DifficultyData
	{
		public int Lane6_MusicScoreCount; //Field offset: 0x8
		public int Lane4_MusicScoreCount; //Field offset: 0xC
		public int Danmaku_MusicScoreCount; //Field offset: 0x10

		public DifficultyData() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public MusicScoreCountScriptableObject() { }

	public override void FromJson(string json) { }

	public Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override string ToJson() { }

}

