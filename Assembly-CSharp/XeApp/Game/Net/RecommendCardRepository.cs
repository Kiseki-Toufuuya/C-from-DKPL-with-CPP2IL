namespace XeApp.Game.Net;

public class RecommendCardRepository : IRepository<RecommendCardModel, Int32>
{
	private RecommendCardScriptableObject m_scriptableObject; //Field offset: 0x8

	public RecommendCardRepository(RecommendCardScriptableObject scriptableObject) { }

	public override RecommendCardModel Get(int id) { }

	public IList<RecommendCardModel> GetAll(bool test = false) { }

	public int GetCount() { }

	public override IList<RecommendCardModel> GetList(IEnumerable<Int32> ids) { }

	private RecommendCardModel GetModelById(int id) { }

	public int TotalCount() { }

}

