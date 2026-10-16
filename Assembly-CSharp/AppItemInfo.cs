//Type is in global namespace

public class AppItemInfo
{
	public string Prefix; //Field offset: 0x8
	public GuardInt Value; //Field offset: 0xC
	public GuardInt Count; //Field offset: 0x14
	public GuardLong EventRankNo; //Field offset: 0x20
	public bool IsEventEmblemDirect; //Field offset: 0x30

	public AppItemInfo() { }

}

