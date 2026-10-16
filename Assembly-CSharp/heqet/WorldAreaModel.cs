namespace Heqet;

public class WorldAreaModel : EntityBase<WorldAreaModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int SortNo; //Field offset: 0x10
	public string Name; //Field offset: 0x14
	public string NameYomi; //Field offset: 0x18
	public int OpenConditionsID; //Field offset: 0x1C

	public WorldAreaModel() { }

}

