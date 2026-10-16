namespace System.IO;

public class EnumerationOptions
{
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	private int <BufferSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; //Field offset: 0x1C

	public FileAttributes AttributesToSkip
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int BufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal static EnumerationOptions Compatible
	{
		[CompilerGenerated]
		internal get { } //Length: 60
	}

	private static EnumerationOptions CompatibleRecursive
	{
		[CompilerGenerated]
		private get { } //Length: 61
	}

	internal static EnumerationOptions Default
	{
		[CompilerGenerated]
		internal get { } //Length: 61
	}

	public bool IgnoreInaccessible
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public MatchCasing MatchCasing
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MatchType MatchType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool RecurseSubdirectories
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool ReturnSpecialDirectories
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private static EnumerationOptions() { }

	public EnumerationOptions() { }

	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[CompilerGenerated]
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	public int get_BufferSize() { }

	[CompilerGenerated]
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	private static EnumerationOptions get_CompatibleRecursive() { }

	[CompilerGenerated]
	internal static EnumerationOptions get_Default() { }

	[CompilerGenerated]
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	public bool get_ReturnSpecialDirectories() { }

	[CompilerGenerated]
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	public void set_RecurseSubdirectories(bool value) { }

}

