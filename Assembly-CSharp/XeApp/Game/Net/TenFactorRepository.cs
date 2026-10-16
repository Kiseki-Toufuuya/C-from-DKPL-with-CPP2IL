namespace XeApp.Game.Net;

public class TenFactorRepository : IRepository<TenFactorModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private TenFactorScriptableObject m_scriptableObject; //Field offset: 0xC

	public TenFactorRepository(TenFactorScriptableObject scriptableObject) { }

	public override TenFactorModel Get(int id) { }

	public override IList<TenFactorModel> GetList(IEnumerable<Int32> ids) { }

	private TenFactorModel GetModelById(int id) { }

	public float GetTenFactor(int ten) { }

}

