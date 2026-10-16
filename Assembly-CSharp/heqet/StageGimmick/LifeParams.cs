namespace Heqet.StageGimmick;

public class LifeParams
{
	public int StartupAddMaxLife; //Field offset: 0x8
	public int StartupOverrideLife; //Field offset: 0xC
	public int StartupAddLifeStock; //Field offset: 0x10
	public float AddLifeAtGreatJudgeOrHigher; //Field offset: 0x14
	public float AddLifeAtKillingNormalEnemy; //Field offset: 0x18
	public float AddLifeAtKillingBoss; //Field offset: 0x1C
	public float AddLifeAtBomb; //Field offset: 0x20
	public float FactorLifeAtRevive; //Field offset: 0x24

	public bool IsNoLifeRecovery
	{
		 get { } //Length: 107
		 set { } //Length: 114
	}

	public LifeParams() { }

	public void Clear() { }

	public bool get_IsNoLifeRecovery() { }

	public void set_IsNoLifeRecovery(bool value) { }

}

