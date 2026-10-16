namespace D4L.TakashoFes.Storage;

public sealed class MySpotStatusProto : IMessage<MySpotStatusProto>, IMessage, IEquatable<MySpotStatusProto>, IDeepCloneable<MySpotStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MySpotStatusProto <.cctor>b__65_0() { }

	}

	private static readonly MessageParser<MySpotStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_spotCharacterIDs_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string presetName_; //Field offset: 0x18
	private int stageID_; //Field offset: 0x1C
	private int themeID_; //Field offset: 0x20
	private readonly RepeatedField<Int32> spotCharacterIDs_; //Field offset: 0x24
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30
	private ByteString thumbnailData_; //Field offset: 0x38
	private int musicID_; //Field offset: 0x3C

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
	public int MusicID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<MySpotStatusProto> Parser
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

	[DebuggerNonUserCode]
	public ByteString ThumbnailData
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static MySpotStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotStatusProto(MySpotStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MySpotStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MySpotStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_MusicID() { }

	public static MessageParser<MySpotStatusProto> get_Parser() { }

	public string get_PresetName() { }

	public RepeatedField<Int32> get_SpotCharacterIDs() { }

	public int get_StageID() { }

	public int get_ThemeID() { }

	public ByteString get_ThumbnailData() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MySpotStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_MusicID(int value) { }

	public void set_PresetName(string value) { }

	public void set_StageID(int value) { }

	public void set_ThemeID(int value) { }

	public void set_ThumbnailData(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

