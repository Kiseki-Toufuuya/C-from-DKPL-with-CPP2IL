namespace D4L.TakashoFes.Struct;

public sealed class MySpotObjectLayoutStatusProto : IMessage<MySpotObjectLayoutStatusProto>, IMessage, IEquatable<MySpotObjectLayoutStatusProto>, IDeepCloneable<MySpotObjectLayoutStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MySpotObjectLayoutStatusProto <.cctor>b__85_0() { }

	}

	private static readonly MessageParser<MySpotObjectLayoutStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int itemID_; //Field offset: 0x18
	private string prefabName_; //Field offset: 0x1C
	private string placementPointName_; //Field offset: 0x20
	private int placementIndex_; //Field offset: 0x24
	private int parentObjectIndex_; //Field offset: 0x28
	private float posX_; //Field offset: 0x2C
	private float posY_; //Field offset: 0x30
	private float posZ_; //Field offset: 0x34
	private int step_; //Field offset: 0x38
	private int flip_; //Field offset: 0x3C
	private long buildTime_; //Field offset: 0x40
	private int posterCardID_; //Field offset: 0x48

	[DebuggerNonUserCode]
	public long BuildTime
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
	public int Flip
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int ItemID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int ParentObjectIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<MySpotObjectLayoutStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int PlacementIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string PlacementPointName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int PosterCardID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public float PosX
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public float PosY
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public float PosZ
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public string PrefabName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int Step
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static MySpotObjectLayoutStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotObjectLayoutStatusProto() { }

	[DebuggerNonUserCode]
	public MySpotObjectLayoutStatusProto(MySpotObjectLayoutStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MySpotObjectLayoutStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MySpotObjectLayoutStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_BuildTime() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Flip() { }

	public long get_ID() { }

	public int get_ItemID() { }

	public int get_ParentObjectIndex() { }

	public static MessageParser<MySpotObjectLayoutStatusProto> get_Parser() { }

	public int get_PlacementIndex() { }

	public string get_PlacementPointName() { }

	public int get_PosterCardID() { }

	public float get_PosX() { }

	public float get_PosY() { }

	public float get_PosZ() { }

	public string get_PrefabName() { }

	public int get_Step() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MySpotObjectLayoutStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BuildTime(long value) { }

	public void set_Flip(int value) { }

	public void set_ID(long value) { }

	public void set_ItemID(int value) { }

	public void set_ParentObjectIndex(int value) { }

	public void set_PlacementIndex(int value) { }

	public void set_PlacementPointName(string value) { }

	public void set_PosterCardID(int value) { }

	public void set_PosX(float value) { }

	public void set_PosY(float value) { }

	public void set_PosZ(float value) { }

	public void set_PrefabName(string value) { }

	public void set_Step(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

