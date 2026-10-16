namespace XeApp.Game.Net;

public class AchievementRepository : IRepository<AchievementModel, Int32>
{
	private AchievementScriptableObject m_scriptableObject; //Field offset: 0x8

	public AchievementRepository(AchievementScriptableObject scriptableObject) { }

	public override AchievementModel Get(int id) { }

	public IList<AchievementModel> GetAll(bool test = false) { }

	public int GetCount() { }

	public override IList<AchievementModel> GetList(IEnumerable<Int32> ids) { }

	private AchievementModel GetModelById(int id) { }

	public int TotalCount() { }

}

