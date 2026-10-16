namespace D4L.TakashoFes.Struct;

public sealed class CardEntityStatusProto : IMessage<CardEntityStatusProto>, IMessage, IEquatable<CardEntityStatusProto>, IDeepCloneable<CardEntityStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CardEntityStatusProto <.cctor>b__75_0() { }

	}

	private static readonly MessageParser<CardEntityStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int cardID_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private int awakeLv_; //Field offset: 0x30
	private int exp_; //Field offset: 0x34
	private int danmakuExp_; //Field offset: 0x38
	private int favorite_; //Field offset: 0x3C
	private int useAwkImage_; //Field offset: 0x40
	private int new_; //Field offset: 0x44
	private int usePremiumImage_; //Field offset: 0x48

	[DebuggerNonUserCode]
	public int AwakeLv
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int CardID
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
	public int DanmakuExp
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
	public int Exp
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int Favorite
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<CardEntityStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int UseAwkImage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int UsePremiumImage
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static CardEntityStatusProto() { }

	[DebuggerNonUserCode]
	public CardEntityStatusProto() { }

	[DebuggerNonUserCode]
	public CardEntityStatusProto(CardEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CardEntityStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CardEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_AwakeLv() { }

	public int get_CardID() { }

	public long get_CreatedAt() { }

	public int get_DanmakuExp() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Exp() { }

	public int get_Favorite() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_New() { }

	public static MessageParser<CardEntityStatusProto> get_Parser() { }

	public int get_UseAwkImage() { }

	public int get_UsePremiumImage() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CardEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AwakeLv(int value) { }

	public void set_CardID(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_DanmakuExp(int value) { }

	public void set_Exp(int value) { }

	public void set_Favorite(int value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	public void set_UseAwkImage(int value) { }

	public void set_UsePremiumImage(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

