namespace D4L.TakashoFes.Struct;

public sealed class EpisodeEntityStatusProto : IMessage<EpisodeEntityStatusProto>, IMessage, IEquatable<EpisodeEntityStatusProto>, IDeepCloneable<EpisodeEntityStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EpisodeEntityStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<EpisodeEntityStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int readCount_; //Field offset: 0x28
	private uint unlockStatus_; //Field offset: 0x2C
	private bool isNew_; //Field offset: 0x30

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
	public bool IsNew
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
	public static MessageParser<EpisodeEntityStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int ReadCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public uint UnlockStatus
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static EpisodeEntityStatusProto() { }

	[DebuggerNonUserCode]
	public EpisodeEntityStatusProto() { }

	[DebuggerNonUserCode]
	public EpisodeEntityStatusProto(EpisodeEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EpisodeEntityStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EpisodeEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public bool get_IsNew() { }

	public long get_LastUpdate() { }

	public static MessageParser<EpisodeEntityStatusProto> get_Parser() { }

	public int get_ReadCount() { }

	public uint get_UnlockStatus() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EpisodeEntityStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_IsNew(bool value) { }

	public void set_LastUpdate(long value) { }

	public void set_ReadCount(int value) { }

	public void set_UnlockStatus(uint value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

