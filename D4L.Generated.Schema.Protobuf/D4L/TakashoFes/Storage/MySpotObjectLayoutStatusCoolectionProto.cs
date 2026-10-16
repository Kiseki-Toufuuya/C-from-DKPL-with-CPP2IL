namespace D4L.TakashoFes.Storage;

public sealed class MySpotObjectLayoutStatusCoolectionProto : IMessage<MySpotObjectLayoutStatusCoolectionProto>, IMessage, IEquatable<MySpotObjectLayoutStatusCoolectionProto>, IDeepCloneable<MySpotObjectLayoutStatusCoolectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MySpotObjectLayoutStatusCoolectionProto <.cctor>b__60_0() { }

	}

	private static readonly MessageParser<MySpotObjectLayoutStatusCoolectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_spotCharacterIDs_codec; //Field offset: 0x4
	private static readonly FieldCodec<MySpotObjectLayoutStatusProto> _repeated_mySpotObjectLayoutStatuses_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string presetName_; //Field offset: 0x18
	private int stageID_; //Field offset: 0x1C
	private int themeID_; //Field offset: 0x20
	private readonly RepeatedField<Int32> spotCharacterIDs_; //Field offset: 0x24
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30
	private readonly RepeatedField<MySpotObjectLayoutStatusProto> mySpotObjectLayoutStatuses_; //Field offset: 0x38

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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public RepeatedField<MySpotObjectLayoutStatusProto> MySpotObjectLayoutStatuses
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<MySpotObjectLayoutStatusCoolectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PresetName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> SpotCharacterIDs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int StageID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ThemeID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static MySpotObjectLayoutStatusCoolectionProto() { }

	[DebuggerNonUserCode]
	public MySpotObjectLayoutStatusCoolectionProto() { }

	[DebuggerNonUserCode]
	public MySpotObjectLayoutStatusCoolectionProto(MySpotObjectLayoutStatusCoolectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MySpotObjectLayoutStatusCoolectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MySpotObjectLayoutStatusCoolectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public RepeatedField<MySpotObjectLayoutStatusProto> get_MySpotObjectLayoutStatuses() { }

	public static MessageParser<MySpotObjectLayoutStatusCoolectionProto> get_Parser() { }

	public string get_PresetName() { }

	public RepeatedField<Int32> get_SpotCharacterIDs() { }

	public int get_StageID() { }

	public int get_ThemeID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MySpotObjectLayoutStatusCoolectionProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_PresetName(string value) { }

	public void set_StageID(int value) { }

	public void set_ThemeID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

