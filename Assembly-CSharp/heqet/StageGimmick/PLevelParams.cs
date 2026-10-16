namespace Heqet.StageGimmick;

public class PLevelParams
{
	public float PLevelFactor; //Field offset: 0x8
	public float AddPLevelAtUseBomb; //Field offset: 0xC
	private Single[] CurrentPLevelFactors; //Field offset: 0x10

	public PLevelParams() { }

	public void Clear() { }

	public float GetCurrentPLevelFactor(PlayerBulletType type) { }

	public void SetCurrentPLevelFactor(PlayerBulletType type, float value) { }

}

