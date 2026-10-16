namespace Heqet.StageGimmick;

public class SGParams
{
	public OtherParams Other; //Field offset: 0x8
	public GiveDamageParams GiveDamage; //Field offset: 0xC
	public TakeDamageParams TakeDamage; //Field offset: 0x10
	public ScoreParams Score; //Field offset: 0x14
	public PLevelParams PLevel; //Field offset: 0x18
	public PsychicForceParams PsychicForce; //Field offset: 0x1C
	public LifeParams Life; //Field offset: 0x20
	public NotesJudgeParams NotesJudge; //Field offset: 0x24
	public UniqueConditionParams UniqueCondition; //Field offset: 0x28
	public BossAndEnemiesParams BossAndEnemies; //Field offset: 0x2C

	public SGParams() { }

	public void Clear() { }

}

