namespace D4L.TakashoFes.Storage;

public sealed class SpotStatusProto : IMessage<SpotStatusProto>, IMessage, IEquatable<SpotStatusProto>, IDeepCloneable<SpotStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SpotStatusProto <.cctor>b__70_0() { }

	}

	private static readonly MessageParser<SpotStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int partyCount_; //Field offset: 0x18
	private int manzokuPt_; //Field offset: 0x1C
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private int positionX_; //Field offset: 0x30
	private int positionY_; //Field offset: 0x34
	private int constructionStatus_; //Field offset: 0x38
	private int reconstruction_; //Field offset: 0x3C
	private int new_; //Field offset: 0x40

	[DebuggerNonUserCode]
	public int ConstructionStatus
	{
		 get { } //Length: 11
		 set { } //Length: 14
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
	public int ManzokuPt
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<SpotStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public int PartyCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int PositionX
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int PositionY
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Reconstruction
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotStatusProto() { }

	[DebuggerNonUserCode]
	public SpotStatusProto() { }

	[DebuggerNonUserCode]
	public SpotStatusProto(SpotStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SpotStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SpotStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_ConstructionStatus() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_ManzokuPt() { }

	public int get_New() { }

	public static MessageParser<SpotStatusProto> get_Parser() { }

	public int get_PartyCount() { }

	public int get_PositionX() { }

	public int get_PositionY() { }

	public int get_Reconstruction() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SpotStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ConstructionStatus(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_ManzokuPt(int value) { }

	public void set_New(int value) { }

	public void set_PartyCount(int value) { }

	public void set_PositionX(int value) { }

	public void set_PositionY(int value) { }

	public void set_Reconstruction(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

