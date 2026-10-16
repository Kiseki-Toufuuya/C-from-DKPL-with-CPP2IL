namespace XeApp.Game.Net;

public class StageLevelFactorRepository : IRepository<StageLevelFactorModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private StageLevelFactorScriptableObject m_scriptableObject; //Field offset: 0xC

	public StageLevelFactorRepository(StageLevelFactorScriptableObject scriptableObject) { }

	public override StageLevelFactorModel Get(int id) { }

	public override IList<StageLevelFactorModel> GetList(IEnumerable<Int32> ids) { }

	private StageLevelFactorModel GetModelById(int id) { }

	public float GetStageLevelFactor(int stageLevel) { }

}

