namespace D4L.TakashoFes.Storage;

public sealed class PlayerBootStatusProto : IMessage<PlayerBootStatusProto>, IMessage, IEquatable<PlayerBootStatusProto>, IDeepCloneable<PlayerBootStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayerBootStatusProto <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<PlayerBootStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string presetName_; //Field offset: 0x18
	private int tutorialEnd_; //Field offset: 0x1C
	private int formatVersion_; //Field offset: 0x20
	private long appealAccountLinkage_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public long AppealAccountLinkage
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
	public int FormatVersion
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
	public static MessageParser<PlayerBootStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PresetName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int TutorialEnd
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PlayerBootStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerBootStatusProto() { }

	[DebuggerNonUserCode]
	public PlayerBootStatusProto(PlayerBootStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayerBootStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayerBootStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_AppealAccountLinkage() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_FormatVersion() { }

	public long get_ID() { }

	public static MessageParser<PlayerBootStatusProto> get_Parser() { }

	public string get_PresetName() { }

	public int get_TutorialEnd() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayerBootStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AppealAccountLinkage(long value) { }

	public void set_FormatVersion(int value) { }

	public void set_ID(long value) { }

	public void set_PresetName(string value) { }

	public void set_TutorialEnd(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

