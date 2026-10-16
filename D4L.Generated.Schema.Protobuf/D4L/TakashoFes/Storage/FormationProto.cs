namespace D4L.TakashoFes.Storage;

public sealed class FormationProto : IMessage<FormationProto>, IMessage, IEquatable<FormationProto>, IDeepCloneable<FormationProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FormationProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<FormationProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int64> _repeated_heroineIDArray_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int64> _repeated_cardIDArray_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int64> heroineIDArray_; //Field offset: 0x18
	private readonly RepeatedField<Int64> cardIDArray_; //Field offset: 0x1C
	private string name_; //Field offset: 0x20
	private int useType_; //Field offset: 0x24
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public RepeatedField<Int64> CardIDArray
	{
		 get { } //Length: 11
	}

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
	public RepeatedField<Int64> HeroineIDArray
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<FormationProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int UseType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static FormationProto() { }

	[DebuggerNonUserCode]
	public FormationProto() { }

	[DebuggerNonUserCode]
	public FormationProto(FormationProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FormationProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FormationProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<Int64> get_CardIDArray() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Int64> get_HeroineIDArray() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public string get_Name() { }

	public static MessageParser<FormationProto> get_Parser() { }

	public int get_UseType() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FormationProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_Name(string value) { }

	public void set_UseType(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

