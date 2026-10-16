namespace XeApp.Game.Net;

public class ScoreRankRepository : IRepository<ScoreRankModel, Int32>
{
	private ScoreRankScriptableObject m_scriptableObject; //Field offset: 0x8

	public ScoreRankRepository(ScoreRankScriptableObject scriptableObject) { }

	public override ScoreRankModel Get(int id) { }

	public ScoreRankID GetFreeModeRankID(StageGimmickCalculator stageGimmickCalculator, int currrScore) { }

	public override IList<ScoreRankModel> GetList(IEnumerable<Int32> ids) { }

	private ScoreRankModel GetModelById(int id) { }

	public ScoreRankID GetStoryModeRankID(int score) { }

}

