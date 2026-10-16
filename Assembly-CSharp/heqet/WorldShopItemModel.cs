namespace Heqet;

public class WorldShopItemModel : EntityBase<WorldShopItemModel, Int32>
{
	internal enum ItemType
	{
		Card = 0,
		Emblem = 1,
		Heroine = 2,
	}

	public int ID; //Field offset: 0xC
	public int OpenConditionsID; //Field offset: 0x10
	public bool InFixedSlot; //Field offset: 0x14
	public ItemType ItemTypeID; //Field offset: 0x18
	public int ItemID; //Field offset: 0x1C
	public int Weight; //Field offset: 0x20
	public int Price; //Field offset: 0x24

	public WorldShopItemModel() { }

}

