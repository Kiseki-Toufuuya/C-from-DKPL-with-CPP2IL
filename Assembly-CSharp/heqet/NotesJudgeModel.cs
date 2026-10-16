namespace Heqet;

public class NotesJudgeModel : EntityBase<NotesJudgeModel, Int32>
{
	public int ID; //Field offset: 0xC
	public string Name; //Field offset: 0x10
	public Single[] JudgeTimings; //Field offset: 0x14
	public float ScoreFactor; //Field offset: 0x18

	public NotesJudgeModel() { }

}

