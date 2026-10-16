namespace D4L.TakashoFes.Storage;

public sealed class ClubSettingStatusProto : IMessage<ClubSettingStatusProto>, IMessage, IEquatable<ClubSettingStatusProto>, IDeepCloneable<ClubSettingStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ClubSettingStatusProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<ClubSettingStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_emblemID_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private bool isPostAchievementAll_; //Field offset: 0x18
	private bool isPostAchievementSSRDraw_; //Field offset: 0x19
	private bool isPostAchievementMaxStrengthen_; //Field offset: 0x1A
	private bool isPostAchievementMaxAwake_; //Field offset: 0x1B
	private bool isPostAchievementMaxLimitBreak_; //Field offset: 0x1C
	private readonly RepeatedField<Int32> emblemID_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> EmblemID
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementAll
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxAwake
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxLimitBreak
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementMaxStrengthen
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsPostAchievementSSRDraw
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<ClubSettingStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static ClubSettingStatusProto() { }

	[DebuggerNonUserCode]
	public ClubSettingStatusProto() { }

	[DebuggerNonUserCode]
	public ClubSettingStatusProto(ClubSettingStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ClubSettingStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ClubSettingStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Int32> get_EmblemID() { }

	public long get_ID() { }

	public bool get_IsPostAchievementAll() { }

	public bool get_IsPostAchievementMaxAwake() { }

	public bool get_IsPostAchievementMaxLimitBreak() { }

	public bool get_IsPostAchievementMaxStrengthen() { }

	public bool get_IsPostAchievementSSRDraw() { }

	public static MessageParser<ClubSettingStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ClubSettingStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_IsPostAchievementAll(bool value) { }

	public void set_IsPostAchievementMaxAwake(bool value) { }

	public void set_IsPostAchievementMaxLimitBreak(bool value) { }

	public void set_IsPostAchievementMaxStrengthen(bool value) { }

	public void set_IsPostAchievementSSRDraw(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

