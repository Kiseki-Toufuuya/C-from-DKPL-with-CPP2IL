namespace Heqet;

public class WorldTreasureBoxModel : EntityBase<WorldTreasureBoxModel, Int32>
{
	internal enum ItemType
	{
		Card = 0,
		Emblem = 1,
		Heroine = 2,
	}

	public int ID; //Field offset: 0xC
	public int StageID; //Field offset: 0x10
	public ItemType ItemTypeID; //Field offset: 0x14
	public int ItemID; //Field offset: 0x18

	public WorldTreasureBoxModel() { }

}

