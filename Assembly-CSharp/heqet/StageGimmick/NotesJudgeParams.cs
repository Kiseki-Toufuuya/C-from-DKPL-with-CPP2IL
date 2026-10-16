namespace Heqet.StageGimmick;

public class NotesJudgeParams
{
	public float PreFactor; //Field offset: 0x8
	public int ComboCountThresholdForJudgeTimeLag; //Field offset: 0xC
	public float JudgeTimeLagFactorAtComboCount; //Field offset: 0x10
	public int PLevelOrOverForJudgeTimeLag; //Field offset: 0x14
	public float JudgeTimeLagFactorAtPLevelOrOver; //Field offset: 0x18
	public int PowerLevelOrLessForJudgeTimeLag; //Field offset: 0x1C
	public float JudgeTimeLagFactorAtPowerLevelOrLess; //Field offset: 0x20
	public int TenTakeCountOrOverForJudgeTimeLag; //Field offset: 0x24
	public float JudgeTimeLagFactorAtTenTakeCountOrOver; //Field offset: 0x28
	public bool IsInvalidDecreaseJudgeTimeLag; //Field offset: 0x2C

	public NotesJudgeParams() { }

	public void Clear() { }

}

