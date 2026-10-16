namespace D4L.TakashoFes.Struct;

public class MusicLevelRecord
{
	public long ID; //Field offset: 0x8
	public GuardLong PlayCount; //Field offset: 0x10
	public GuardLong ClearCount; //Field offset: 0x20
	public GuardLong MaxScore; //Field offset: 0x30
	public GuardLong MaxCombo; //Field offset: 0x40
	public GuardLong ClearTime; //Field offset: 0x50
	public GuardInt BossGauge; //Field offset: 0x60
	public GuardBool IsSpellBreak; //Field offset: 0x68
	public GuardInt BossDamage; //Field offset: 0x70
	public GuardInt MaxBrilliant; //Field offset: 0x78
	public GuardBool IsNoDamageClear; //Field offset: 0x80
	public GuardBool IsFullCombo; //Field offset: 0x88
	public GuardBool IsAllBrilliant; //Field offset: 0x90

	public MusicLevelRecord() { }

	public static MusicLevelRecord Parse(MusicLevelRecordProto source) { }

	public MusicLevelRecordProto ToProtobuf() { }

}

