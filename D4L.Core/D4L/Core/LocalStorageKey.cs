namespace D4L.Core;

[IsReadOnly]
public struct LocalStorageKey
{
	public static readonly char delimiter; //Field offset: 0x0
	public static readonly string delimiterString; //Field offset: 0x4
	public static readonly string NullVariant; //Field offset: 0x8
	[CompilerGenerated]
	private readonly string <Basename>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Variant>k__BackingField; //Field offset: 0x4

	public string Basename
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	public string Variant
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private static LocalStorageKey() { }

	public LocalStorageKey(string basename) { }

	public LocalStorageKey(string basename, string variant) { }

	[CompilerGenerated]
	public string get_Basename() { }

	[CompilerGenerated]
	public string get_Variant() { }

	public virtual string ToString() { }

	public LocalStorageKey VariantFor(string variant) { }

}

