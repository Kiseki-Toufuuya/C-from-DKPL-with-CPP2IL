namespace Heqet.StageGimmick;

public class BossAndEnemiesParams
{
	public float FactorAtMaxBossLife; //Field offset: 0x8
	public bool IsProtectingTheBossLife; //Field offset: 0xC
	public float AddBossLifeAtMissJudge; //Field offset: 0x10
	public float BossDefeatBonus; //Field offset: 0x14
	public float FactorAtNormalEnemyLife; //Field offset: 0x18

	public BossAndEnemiesParams() { }

	public void Clear() { }

}

