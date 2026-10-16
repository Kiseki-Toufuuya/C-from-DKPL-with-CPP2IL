namespace D4L.TakashoFes.Storage;

public sealed class TweetStatusProto : IMessage<TweetStatusProto>, IMessage, IEquatable<TweetStatusProto>, IDeepCloneable<TweetStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TweetStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<TweetStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private bool isUnlock_; //Field offset: 0x18
	private bool isRead_; //Field offset: 0x19
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private int new_; //Field offset: 0x30

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
	public bool IsRead
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public bool IsUnlock
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
	public static MessageParser<TweetStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static TweetStatusProto() { }

	[DebuggerNonUserCode]
	public TweetStatusProto() { }

	[DebuggerNonUserCode]
	public TweetStatusProto(TweetStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override TweetStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(TweetStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public bool get_IsRead() { }

	public bool get_IsUnlock() { }

	public long get_LastUpdate() { }

	public int get_New() { }

	public static MessageParser<TweetStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(TweetStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_IsRead(bool value) { }

	public void set_IsUnlock(bool value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

