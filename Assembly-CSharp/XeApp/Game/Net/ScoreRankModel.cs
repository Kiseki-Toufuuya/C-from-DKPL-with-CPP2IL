namespace XeApp.Game.Net;

public class ScoreRankModel : EntityBase<ScoreRankModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int StoryBorder; //Field offset: 0x10
	public int FreeBorder; //Field offset: 0x14

	public ScoreRankModel() { }

}

