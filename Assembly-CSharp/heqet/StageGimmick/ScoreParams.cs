namespace Heqet.StageGimmick;

public class ScoreParams
{
	public float PreScoreValue; //Field offset: 0x8
	public int ComboCountThresholdForValue; //Field offset: 0xC
	public float ValueAtComboCount; //Field offset: 0x10
	public float FactorAtUseBomb; //Field offset: 0x14
	public float FactorAtPlayerDamage; //Field offset: 0x18
	public float FactorAtMissJudge; //Field offset: 0x1C
	public float BasePoint; //Field offset: 0x20
	public float MusicLevelValue; //Field offset: 0x24
	public float AttributeAdvantageValue; //Field offset: 0x28

	public ScoreParams() { }

	public void Clear() { }

}

