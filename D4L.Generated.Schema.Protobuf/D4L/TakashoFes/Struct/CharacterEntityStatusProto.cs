namespace D4L.TakashoFes.Struct;

public sealed class CharacterEntityStatusProto : IMessage<CharacterEntityStatusProto>, IMessage, IEquatable<CharacterEntityStatusProto>, IDeepCloneable<CharacterEntityStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CharacterEntityStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<CharacterEntityStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int exp_; //Field offset: 0x28
	private int manzokuPt_; //Field offset: 0x2C
	private int exchangeCount_; //Field offset: 0x30

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
	public static MessageParser<CharacterEntityStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static CharacterEntityStatusProto() { }

	[DebuggerNonUserCode]
	public CharacterEntityStatusProto() { }

	[DebuggerNonUserCode]
	public CharacterEntityStatusProto(CharacterEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CharacterEntityStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CharacterEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_ExchangeCount() { }

	public int get_Exp() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_ManzokuPt() { }

	public static MessageParser<CharacterEntityStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CharacterEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ExchangeCount(int value) { }

	public void set_Exp(int value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_ManzokuPt(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

