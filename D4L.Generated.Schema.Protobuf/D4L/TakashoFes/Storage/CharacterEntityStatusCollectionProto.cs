namespace D4L.TakashoFes.Storage;

public sealed class CharacterEntityStatusCollectionProto : IMessage<CharacterEntityStatusCollectionProto>, IMessage, IEquatable<CharacterEntityStatusCollectionProto>, IDeepCloneable<CharacterEntityStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CharacterEntityStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<CharacterEntityStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<CharacterEntityStatusProto> _repeated_characters_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<CharacterEntityStatusProto> characters_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public RepeatedField<CharacterEntityStatusProto> Characters
	{
		 get { } //Length: 11
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
	public static MessageParser<CharacterEntityStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static CharacterEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public CharacterEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public CharacterEntityStatusCollectionProto(CharacterEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CharacterEntityStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CharacterEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<CharacterEntityStatusProto> get_Characters() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<CharacterEntityStatusCollectionProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CharacterEntityStatusCollectionProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

