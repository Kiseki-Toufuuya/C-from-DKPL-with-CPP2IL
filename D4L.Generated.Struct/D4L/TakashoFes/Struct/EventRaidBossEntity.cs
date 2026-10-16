namespace D4L.TakashoFes.Struct;

public class EventRaidBossEntity
{
	public string RaidBossId; //Field offset: 0x8
	public long BossId; //Field offset: 0x10
	public long BossMaxHp; //Field offset: 0x18
	public long DissappearTime; //Field offset: 0x20
	public string DiscoverPlayerId; //Field offset: 0x28
	public int BossLv; //Field offset: 0x2C
	public int UserRelation; //Field offset: 0x30

	public EventRaidBossEntity() { }

	public static EventRaidBossEntity Parse(EventRaidBossEntityProto source) { }

	public EventRaidBossEntityProto ToProtobuf() { }

}

