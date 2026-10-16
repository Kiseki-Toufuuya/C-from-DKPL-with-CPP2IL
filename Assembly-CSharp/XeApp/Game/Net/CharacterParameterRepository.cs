namespace XeApp.Game.Net;

public class CharacterParameterRepository : IRepository<CharacterParameterModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8

	public CharacterParameterRepository(DefaultMasterDataContext context) { }

	public override CharacterParameterModel Get(int id) { }

	public List<CharacterParameterModel> GetAll(bool test = false) { }

	public override IList<CharacterParameterModel> GetList(IEnumerable<Int32> ids) { }

	private CharacterParameterModel GetModelById(int id) { }

}

