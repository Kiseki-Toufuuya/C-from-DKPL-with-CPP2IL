namespace XeApp.Game.Net;

public class HeqetCardRepository : IRepository<HeqetCardModel, Int32>
{
	private HeqetCardScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetCardRepository(HeqetCardScriptableObject scriptableObject) { }

	public override HeqetCardModel Get(int id) { }

	public IList<HeqetCardModel> GetAll(bool test = false) { }

	public override IList<HeqetCardModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetCardModel GetModelById(int id) { }

	public int TotalCount() { }

}

