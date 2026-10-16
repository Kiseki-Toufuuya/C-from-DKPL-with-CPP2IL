namespace XeApp.Game.Net;

public class HeroineDanmakuParamRepository : IRepository<HeroineDanmakuParamModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private HeroineDanmakuParamScriptableObject m_scriptableObject; //Field offset: 0xC

	public HeroineDanmakuParamRepository(HeroineDanmakuParamScriptableObject scriptableObject) { }

	public override HeroineDanmakuParamModel Get(int id) { }

	public override IList<HeroineDanmakuParamModel> GetList(IEnumerable<Int32> ids) { }

	private HeroineDanmakuParamModel GetModelById(int id) { }

}

