namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeroineDanmakuParamRepository")]
[MovedFrom(False, null, null, "HeroineDanmakuParamRepository")]
public class HeroineDanmakuParamScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public eShotType MainShot; //Field offset: 0xC
		public float MainShotDamageFactor; //Field offset: 0x10
		public eShotType ExtraShot; //Field offset: 0x14
		public float ExtraShotDamageFactor; //Field offset: 0x18
		public int PlayerLife; //Field offset: 0x1C
		public int PlayerStock; //Field offset: 0x20
		public int PlayerPower; //Field offset: 0x24
		public int BombStock; //Field offset: 0x28
		public int BombPower; //Field offset: 0x2C
		public int HeroineSkillID; //Field offset: 0x30
		public float MoveSpeed; //Field offset: 0x34
		public float DeadbombTime; //Field offset: 0x38

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public HeroineDanmakuParamScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

