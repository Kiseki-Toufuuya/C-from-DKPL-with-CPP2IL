namespace D4L.TakashoFes.Storage;

public sealed class AdMobMovieStatusProto : IMessage<AdMobMovieStatusProto>, IMessage, IEquatable<AdMobMovieStatusProto>, IDeepCloneable<AdMobMovieStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal AdMobMovieStatusProto <.cctor>b__75_0() { }

	}

	private static readonly MessageParser<AdMobMovieStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long expeditionLastShowDate_; //Field offset: 0x18
	private long expeditionTodayShowCount_; //Field offset: 0x20
	private long expeditionTotalShowCount_; //Field offset: 0x28
	private long homeLastShowDate_; //Field offset: 0x30
	private long homeTodayShowCount_; //Field offset: 0x38
	private long homeShowCount_; //Field offset: 0x40
	private long homeTotalShowCount_; //Field offset: 0x48
	private long specialChanceEndAt_; //Field offset: 0x50
	private int specialChanceStep_; //Field offset: 0x58
	private int specialChanceEnable_; //Field offset: 0x5C

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public long ExpeditionLastShowDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ExpeditionTodayShowCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ExpeditionTotalShowCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long HomeLastShowDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long HomeShowCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long HomeTodayShowCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long HomeTotalShowCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<AdMobMovieStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SpecialChanceEnable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long SpecialChanceEndAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int SpecialChanceStep
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static AdMobMovieStatusProto() { }

	[DebuggerNonUserCode]
	public AdMobMovieStatusProto() { }

	[DebuggerNonUserCode]
	public AdMobMovieStatusProto(AdMobMovieStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override AdMobMovieStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(AdMobMovieStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ExpeditionLastShowDate() { }

	public long get_ExpeditionTodayShowCount() { }

	public long get_ExpeditionTotalShowCount() { }

	public long get_HomeLastShowDate() { }

	public long get_HomeShowCount() { }

	public long get_HomeTodayShowCount() { }

	public long get_HomeTotalShowCount() { }

	public long get_ID() { }

	public static MessageParser<AdMobMovieStatusProto> get_Parser() { }

	public int get_SpecialChanceEnable() { }

	public long get_SpecialChanceEndAt() { }

	public int get_SpecialChanceStep() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(AdMobMovieStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ExpeditionLastShowDate(long value) { }

	public void set_ExpeditionTodayShowCount(long value) { }

	public void set_ExpeditionTotalShowCount(long value) { }

	public void set_HomeLastShowDate(long value) { }

	public void set_HomeShowCount(long value) { }

	public void set_HomeTodayShowCount(long value) { }

	public void set_HomeTotalShowCount(long value) { }

	public void set_ID(long value) { }

	public void set_SpecialChanceEnable(int value) { }

	public void set_SpecialChanceEndAt(long value) { }

	public void set_SpecialChanceStep(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

