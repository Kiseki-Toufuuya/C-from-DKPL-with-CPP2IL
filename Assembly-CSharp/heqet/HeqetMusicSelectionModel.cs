namespace Heqet;

public class HeqetMusicSelectionModel : EntityBase<HeqetMusicSelectionModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Title; //Field offset: 0x10
	public Int64[] MusicIdArray; //Field offset: 0x14
	public int SortNo; //Field offset: 0x18
	public int JacketId; //Field offset: 0x1C
	public int BackGroundId; //Field offset: 0x20
	public int BGMovieId; //Field offset: 0x24
	public Int32[] MusicDifficultyLevelArray; //Field offset: 0x28
	public int AcquirableMoney; //Field offset: 0x2C
	public int NewRelease; //Field offset: 0x30

	public HeqetMusicSelectionModel() { }

	public bool IsEnableDifficulty(int difficulty) { }

}

