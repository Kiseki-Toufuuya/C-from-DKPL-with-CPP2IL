namespace D4L.TakashoFes.Storage;

public sealed class CharacterStatusProto : IMessage<CharacterStatusProto>, IMessage, IEquatable<CharacterStatusProto>, IDeepCloneable<CharacterStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CharacterStatusProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<CharacterStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int exp_; //Field offset: 0x28
	private int manzokuPt_; //Field offset: 0x2C
	private int exchangeCount_; //Field offset: 0x30
	private int skinID_; //Field offset: 0x34

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
	public int ExchangeCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Exp
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int ManzokuPt
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<CharacterStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SkinID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static CharacterStatusProto() { }

	[DebuggerNonUserCode]
	public CharacterStatusProto() { }

	[DebuggerNonUserCode]
	public CharacterStatusProto(CharacterStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CharacterStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CharacterStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_ExchangeCount() { }

	public int get_Exp() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_ManzokuPt() { }

	public static MessageParser<CharacterStatusProto> get_Parser() { }

	public int get_SkinID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CharacterStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ExchangeCount(int value) { }

	public void set_Exp(int value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_ManzokuPt(int value) { }

	public void set_SkinID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

