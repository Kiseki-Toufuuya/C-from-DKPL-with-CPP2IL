namespace Heqet;

public class ExScoreModel : EntityBase<ExScoreModel, Int32>
{
	public int ID; //Field offset: 0xC
	public float JudgeTiming; //Field offset: 0x10
	public Int32[] ExScores; //Field offset: 0x14

	public ExScoreModel() { }

}

