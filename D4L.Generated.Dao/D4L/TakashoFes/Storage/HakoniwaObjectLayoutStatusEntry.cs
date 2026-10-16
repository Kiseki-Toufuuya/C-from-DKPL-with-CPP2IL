namespace D4L.TakashoFes.Storage;

public sealed class HakoniwaObjectLayoutStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override HakoniwaObjectLayoutStatusEntry Parse(Byte[] source) { }

		public HakoniwaObjectLayoutStatusEntry Parse(HakoniwaObjectLayoutStatusProto source) { }

		public override Byte[] ToBytes(HakoniwaObjectLayoutStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <ItemID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <PrefabName>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <PlacementPointName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <PlacementIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <ParentObjectIndex>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <PosX>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <PosY>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <PosZ>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <Step>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <Flip>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private long <BuildTime>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <PosterCardID>k__BackingField; //Field offset: 0x40

	public long BuildTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int Flip
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ItemID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ParentObjectIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int PlacementIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string PlacementPointName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int PosterCardID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public float PosX
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public float PosY
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public float PosZ
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public string PrefabName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int Step
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public HakoniwaObjectLayoutStatusEntry() { }

	[Preserve]
	public override HakoniwaObjectLayoutStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_BuildTime() { }

	[CompilerGenerated]
	public int get_Flip() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public int get_ItemID() { }

	[CompilerGenerated]
	public int get_ParentObjectIndex() { }

	[CompilerGenerated]
	public int get_PlacementIndex() { }

	[CompilerGenerated]
	public string get_PlacementPointName() { }

	[CompilerGenerated]
	public int get_PosterCardID() { }

	[CompilerGenerated]
	public float get_PosX() { }

	[CompilerGenerated]
	public float get_PosY() { }

	[CompilerGenerated]
	public float get_PosZ() { }

	[CompilerGenerated]
	public string get_PrefabName() { }

	[CompilerGenerated]
	public int get_Step() { }

	[CompilerGenerated]
	public void set_BuildTime(long value) { }

	[CompilerGenerated]
	public void set_Flip(int value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_ItemID(int value) { }

	[CompilerGenerated]
	public void set_ParentObjectIndex(int value) { }

	[CompilerGenerated]
	public void set_PlacementIndex(int value) { }

	[CompilerGenerated]
	public void set_PlacementPointName(string value) { }

	[CompilerGenerated]
	public void set_PosterCardID(int value) { }

	[CompilerGenerated]
	public void set_PosX(float value) { }

	[CompilerGenerated]
	public void set_PosY(float value) { }

	[CompilerGenerated]
	public void set_PosZ(float value) { }

	[CompilerGenerated]
	public void set_PrefabName(string value) { }

	[CompilerGenerated]
	public void set_Step(int value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

