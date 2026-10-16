namespace Heqet;

public class WorldBoosterModel : EntityBase<WorldBoosterModel, Int32>
{
	internal enum CategoryType
	{
		Common = 0,
		Kagura = 1,
		Danmaku = 2,
	}

	public int ID; //Field offset: 0xC
	public int ImageID; //Field offset: 0x10
	public int ItemGimmickID; //Field offset: 0x14
	public int Price; //Field offset: 0x18
	public CategoryType CategoryTypeID; //Field offset: 0x1C

	public WorldBoosterModel() { }

}

