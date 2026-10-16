namespace Heqet.StageGimmick;

public class GiveDamageParams
{
	public float PreFactor; //Field offset: 0x8
	public float FactorAtPlayerLifeMax; //Field offset: 0xC
	public int ComboCountThresholdForFactor; //Field offset: 0x10
	public float FactorAtComboCount; //Field offset: 0x14
	public int PLevelThresholdForFactor; //Field offset: 0x18
	public float FactorAtPLevel; //Field offset: 0x1C
	public float MainHeroineShotFactor; //Field offset: 0x20
	public float OptionShotFactor; //Field offset: 0x24
	public float BombStrength; //Field offset: 0x28
	private Single[] PlayerBulletTypeDamageFactors; //Field offset: 0x2C

	public GiveDamageParams() { }

	public void Clear() { }

	public float GetPlayerBulletTypeDamageFactor(PlayerBulletType type) { }

	public void SetPlayerBulletTypeDamageFactor(PlayerBulletType type, float value) { }

}

