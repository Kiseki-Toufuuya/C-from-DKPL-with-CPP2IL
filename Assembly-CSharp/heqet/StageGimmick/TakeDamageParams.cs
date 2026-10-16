namespace Heqet.StageGimmick;

public class TakeDamageParams
{
	public float PreFactor; //Field offset: 0x8
	public int PLevelThresholdForFactor; //Field offset: 0xC
	public float FactorAtPLevel; //Field offset: 0x10
	public float FactorAtBossAttack; //Field offset: 0x14
	public float FactorAtDamageFromBossContact; //Field offset: 0x18

	public TakeDamageParams() { }

	public void Clear() { }

}

