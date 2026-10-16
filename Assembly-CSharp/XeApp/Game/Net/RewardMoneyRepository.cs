namespace XeApp.Game.Net;

public class RewardMoneyRepository : IRepository<RewardMoneyModel, Int32>
{
	private RewardMoneyScriptableObject m_scriptableObject; //Field offset: 0x8

	public RewardMoneyRepository(RewardMoneyScriptableObject scriptableObject) { }

	public override RewardMoneyModel Get(int id) { }

	public override IList<RewardMoneyModel> GetList(IEnumerable<Int32> ids) { }

	private RewardMoneyModel GetModelById(int id) { }

}

