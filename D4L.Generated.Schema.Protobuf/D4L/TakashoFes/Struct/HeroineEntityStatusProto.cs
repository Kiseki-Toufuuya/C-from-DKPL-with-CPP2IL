namespace D4L.TakashoFes.Struct;

public sealed class HeroineEntityStatusProto : IMessage<HeroineEntityStatusProto>, IMessage, IEquatable<HeroineEntityStatusProto>, IDeepCloneable<HeroineEntityStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal HeroineEntityStatusProto <.cctor>b__65_0() { }

	}

	private static readonly MessageParser<HeroineEntityStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int heroineID_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private int individualDiffID_; //Field offset: 0x30
	private int specialSkillID_; //Field offset: 0x34
	private int favorite_; //Field offset: 0x38
	private int exp_; //Field offset: 0x3C
	private int new_; //Field offset: 0x40

	[DebuggerNonUserCode]
	public long CreatedAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public int Exp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Favorite
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int HeroineID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int IndividualDiffID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<HeroineEntityStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SpecialSkillID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static HeroineEntityStatusProto() { }

	[DebuggerNonUserCode]
	public HeroineEntityStatusProto() { }

	[DebuggerNonUserCode]
	public HeroineEntityStatusProto(HeroineEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override HeroineEntityStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(HeroineEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Exp() { }

	public int get_Favorite() { }

	public int get_HeroineID() { }

	public long get_ID() { }

	public int get_IndividualDiffID() { }

	public long get_LastUpdate() { }

	public int get_New() { }

	public static MessageParser<HeroineEntityStatusProto> get_Parser() { }

	public int get_SpecialSkillID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(HeroineEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_Exp(int value) { }

	public void set_Favorite(int value) { }

	public void set_HeroineID(int value) { }

	public void set_ID(long value) { }

	public void set_IndividualDiffID(int value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	public void set_SpecialSkillID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

