namespace XeApp.Game.Net;

public class MusicScoreModel : EntityBase<MusicScoreModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int CreaterNameID; //Field offset: 0x10
	public float MusicLevel; //Field offset: 0x14
	public int LegacyLevel; //Field offset: 0x18
	public int BarLine; //Field offset: 0x1C

	public MusicScoreModel() { }

}

