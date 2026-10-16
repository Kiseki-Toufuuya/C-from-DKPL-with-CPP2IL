namespace D4L.TakashoFes.Storage;

public sealed class PremiumCardStatusProto : IMessage<PremiumCardStatusProto>, IMessage, IEquatable<PremiumCardStatusProto>, IDeepCloneable<PremiumCardStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PremiumCardStatusProto <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<PremiumCardStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int isUnlock_; //Field offset: 0x28
	private int usePremiumImage_; //Field offset: 0x2C

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
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int IsUnlock
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
	public static MessageParser<PremiumCardStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int UsePremiumImage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static PremiumCardStatusProto() { }

	[DebuggerNonUserCode]
	public PremiumCardStatusProto() { }

	[DebuggerNonUserCode]
	public PremiumCardStatusProto(PremiumCardStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PremiumCardStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PremiumCardStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public int get_IsUnlock() { }

	public long get_LastUpdate() { }

	public static MessageParser<PremiumCardStatusProto> get_Parser() { }

	public int get_UsePremiumImage() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PremiumCardStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_IsUnlock(int value) { }

	public void set_LastUpdate(long value) { }

	public void set_UsePremiumImage(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

