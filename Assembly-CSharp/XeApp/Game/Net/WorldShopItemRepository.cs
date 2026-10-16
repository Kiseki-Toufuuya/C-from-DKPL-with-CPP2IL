namespace XeApp.Game.Net;

public class WorldShopItemRepository : IRepository<WorldShopItemModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldShopItemScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldShopItemRepository(WorldShopItemScriptableObject scriptableObject) { }

	public override WorldShopItemModel Get(int id) { }

	public override IList<WorldShopItemModel> GetList(IEnumerable<Int32> ids) { }

	private WorldShopItemModel GetModelById(int id) { }

	public IList<WorldShopItemModel> GetOpenItems() { }

}

