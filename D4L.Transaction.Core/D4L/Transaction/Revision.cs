namespace D4L.Transaction;

[IsReadOnly]
public struct Revision
{
	[CompilerGenerated]
	private static Revision <Current>k__BackingField; //Field offset: 0x0
	private readonly string revision; //Field offset: 0x0

	public static Revision Current
	{
		[CompilerGenerated]
		 set { } //Length: 65
	}

	public Revision(string revision) { }

	public bool Equals(Revision other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public static void set_Current(Revision value) { }

	public virtual string ToString() { }

}

