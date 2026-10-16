namespace XeApp.Game.Net;

public class HeqetHeroineRepository : IRepository<HeqetHeroineModel, Int32>
{
	private HeqetHeroineScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetHeroineRepository(HeqetHeroineScriptableObject scriptableObject) { }

	public override HeqetHeroineModel Get(int id) { }

	public List<HeqetHeroineModel> GetAll(bool test = false) { }

	public override IList<HeqetHeroineModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetHeroineModel GetModelById(int id) { }

	public IList<HeqetHeroineModel> GetSeriesBoss(IEnumerable<Int32> seriesIds) { }

	public int TotalCount() { }

}

