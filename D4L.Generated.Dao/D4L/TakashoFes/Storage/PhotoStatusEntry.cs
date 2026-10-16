namespace D4L.TakashoFes.Storage;

public sealed class PhotoStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PhotoStatusEntry Parse(Byte[] source) { }

		public PhotoStatusEntry Parse(PhotoStatusProto source) { }

		public override Byte[] ToBytes(PhotoStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <PhotoID>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <Favorate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public bool Favorate
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

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string PhotoID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string Title
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public PhotoStatusEntry() { }

	[Preserve]
	public override PhotoStatusEntry Clone() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public bool get_Favorate() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public string get_PhotoID() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_Favorate(bool value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_PhotoID(string value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

