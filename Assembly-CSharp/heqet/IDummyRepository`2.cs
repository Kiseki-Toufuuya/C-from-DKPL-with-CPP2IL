namespace Heqet;

public interface IDummyRepository : IJsonImportExport
{

	public Entity Get(Identity id) { }

	public IList<Entity> GetList(IEnumerable<Identity> ids) { }

}

