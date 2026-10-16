namespace D4L.TakashoFes.Storage;

public sealed class UnlockStatusProto : IMessage<UnlockStatusProto>, IMessage, IEquatable<UnlockStatusProto>, IDeepCloneable<UnlockStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UnlockStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<UnlockStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int category_; //Field offset: 0x18
	private int unlockID_; //Field offset: 0x1C
	private long createDate_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private bool isNew_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public int Category
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long CreateDate
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
	public static MessageParser<UnlockStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int UnlockID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static UnlockStatusProto() { }

	[DebuggerNonUserCode]
	public UnlockStatusProto() { }

	[DebuggerNonUserCode]
	public UnlockStatusProto(UnlockStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override UnlockStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(UnlockStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Category() { }

	public long get_CreateDate() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public bool get_IsNew() { }

	public long get_LastUpdate() { }

	public static MessageParser<UnlockStatusProto> get_Parser() { }

	public int get_UnlockID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(UnlockStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Category(int value) { }

	public void set_CreateDate(long value) { }

	public void set_ID(long value) { }

	public void set_IsNew(bool value) { }

	public void set_LastUpdate(long value) { }

	public void set_UnlockID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

