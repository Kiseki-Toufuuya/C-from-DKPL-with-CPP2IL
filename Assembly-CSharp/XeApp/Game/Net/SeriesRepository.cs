namespace XeApp.Game.Net;

public class SeriesRepository : IRepository<SeriesModel, Int32>
{
	private SeriesScriptableObject m_scriptableObject; //Field offset: 0x8

	public SeriesRepository(SeriesScriptableObject scriptableObject) { }

	public override SeriesModel Get(int id) { }

	public int GetCollaboSeriesId() { }

	private SeriesModel GetLastModel() { }

	public override IList<SeriesModel> GetList(IEnumerable<Int32> ids) { }

	private SeriesModel GetModelById(int id) { }

}

