namespace Heqet;

public class WorldSpotModel : EntityBase<WorldSpotModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int DlcID; //Field offset: 0x10
	public int AreaID; //Field offset: 0x14
	public int SortNo; //Field offset: 0x18
	public string Name; //Field offset: 0x1C
	public string NameYomi; //Field offset: 0x20
	public int OpenConditionsID; //Field offset: 0x24
	public int Thumbnail; //Field offset: 0x28
	public string FlavorText; //Field offset: 0x2C
	public int RenaissanceEffectID; //Field offset: 0x30
	public int ArrivalEpisodeID; //Field offset: 0x34
	public int OpenEffectID; //Field offset: 0x38
	public int RenaissanceConditionsID; //Field offset: 0x3C
	public int MarisaEpisodeID; //Field offset: 0x40

	public WorldSpotModel() { }

}

