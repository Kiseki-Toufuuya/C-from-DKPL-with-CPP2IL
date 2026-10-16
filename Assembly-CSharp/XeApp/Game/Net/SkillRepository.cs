namespace XeApp.Game.Net;

public class SkillRepository : IRepository<SkillModel, Int32>
{
	private SkillScriptableObject m_scriptableObject; //Field offset: 0x8

	public SkillRepository(SkillScriptableObject scriptableObject) { }

	public override SkillModel Get(int id) { }

	public override IList<SkillModel> GetList(IEnumerable<Int32> ids) { }

	private SkillModel GetModelById(int id) { }

}

