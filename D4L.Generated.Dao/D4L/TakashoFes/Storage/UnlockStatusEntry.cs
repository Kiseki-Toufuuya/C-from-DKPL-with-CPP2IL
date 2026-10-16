namespace D4L.TakashoFes.Storage;

public sealed class UnlockStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override UnlockStatusEntry Parse(Byte[] source) { }

		public UnlockStatusEntry Parse(UnlockStatusProto source) { }

		public override Byte[] ToBytes(UnlockStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Category>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <UnlockID>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private long <CreateDate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardBool <IsNew>k__BackingField; //Field offset: 0x30

	public int Category
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long CreateDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardBool IsNew
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

	public GuardInt UnlockID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public UnlockStatusEntry() { }

	[Preserve]
	public override UnlockStatusEntry Clone() { }

	[CompilerGenerated]
	public int get_Category() { }

	[CompilerGenerated]
	public long get_CreateDate() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardBool get_IsNew() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public GuardInt get_UnlockID() { }

	[CompilerGenerated]
	public void set_Category(int value) { }

	[CompilerGenerated]
	public void set_CreateDate(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsNew(GuardBool value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_UnlockID(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

