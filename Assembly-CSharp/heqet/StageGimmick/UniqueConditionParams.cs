namespace Heqet.StageGimmick;

public class UniqueConditionParams
{
	public float OnsetTimeOfPoisoned; //Field offset: 0x8
	public float PoisonedValue; //Field offset: 0xC
	public float TimerOfPoisoned; //Field offset: 0x10
	public float OnsetTimeFactorAtPoisoned; //Field offset: 0x14
	public float ValueFactorAtPoisoned; //Field offset: 0x18
	public float GenerationFactorAtPoisoned; //Field offset: 0x1C
	public float OnsetTimeOfSandstorm; //Field offset: 0x20
	public float TimerOfSandstorm; //Field offset: 0x24
	public float OnsetTimeFactorAtSandstorm; //Field offset: 0x28
	public float OnsetTimeOfRedNight; //Field offset: 0x2C
	public float RedNightValue; //Field offset: 0x30
	public float TimerOfRedNight; //Field offset: 0x34
	public float OnsetTimeFactorAtRedNight; //Field offset: 0x38
	public float ValueFactorAtRedNight; //Field offset: 0x3C
	public int GenerationLevelAtMist; //Field offset: 0x40
	public float GenerationFactorAtMist; //Field offset: 0x44
	public float GenerationFactorAtQuake; //Field offset: 0x48

	public UniqueConditionParams() { }

	public void Clear() { }

}

