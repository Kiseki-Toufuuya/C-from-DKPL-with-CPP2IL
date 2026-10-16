namespace D4L.TakashoFes.Storage;

public sealed class TutorialAdvStatusProto : IMessage<TutorialAdvStatusProto>, IMessage, IEquatable<TutorialAdvStatusProto>, IDeepCloneable<TutorialAdvStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TutorialAdvStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<TutorialAdvStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long checkTime_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public long CheckTime
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
	public static MessageParser<TutorialAdvStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static TutorialAdvStatusProto() { }

	[DebuggerNonUserCode]
	public TutorialAdvStatusProto() { }

	[DebuggerNonUserCode]
	public TutorialAdvStatusProto(TutorialAdvStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override TutorialAdvStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(TutorialAdvStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CheckTime() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<TutorialAdvStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(TutorialAdvStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CheckTime(long value) { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

