namespace D4L.TakashoFes.Struct;

public sealed class SpotVisitRecordProto : IMessage<SpotVisitRecordProto>, IMessage, IEquatable<SpotVisitRecordProto>, IDeepCloneable<SpotVisitRecordProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SpotVisitRecordProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<SpotVisitRecordProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_characterIDArray_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int spotID_; //Field offset: 0xC
	private readonly RepeatedField<Int32> characterIDArray_; //Field offset: 0x10
	private int contactID_; //Field offset: 0x14

	[DebuggerNonUserCode]
	public RepeatedField<Int32> CharacterIDArray
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int ContactID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<SpotVisitRecordProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SpotID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotVisitRecordProto() { }

	[DebuggerNonUserCode]
	public SpotVisitRecordProto() { }

	[DebuggerNonUserCode]
	public SpotVisitRecordProto(SpotVisitRecordProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SpotVisitRecordProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SpotVisitRecordProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<Int32> get_CharacterIDArray() { }

	public int get_ContactID() { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<SpotVisitRecordProto> get_Parser() { }

	public int get_SpotID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SpotVisitRecordProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ContactID(int value) { }

	public void set_SpotID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

