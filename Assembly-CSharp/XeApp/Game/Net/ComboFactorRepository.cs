namespace XeApp.Game.Net;

public class ComboFactorRepository : IRepository<ComboFactorModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private ComboFactorScriptableObject m_scriptableObject; //Field offset: 0xC

	public ComboFactorRepository(ComboFactorScriptableObject scriptableObject) { }

	public override ComboFactorModel Get(int id) { }

	public float GetComboFactor(int combo) { }

	public override IList<ComboFactorModel> GetList(IEnumerable<Int32> ids) { }

	private ComboFactorModel GetModelById(int id) { }

}

