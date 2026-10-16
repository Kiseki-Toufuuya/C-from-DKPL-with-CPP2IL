namespace System.IO.Enumeration;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct FileSystemEntry
{
	internal FILE_FULL_DIR_INFORMATION* _info; //Field offset: 0x0
	[CompilerGenerated]
	private ReadOnlySpan<Char> <Directory>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private ReadOnlySpan<Char> <RootDirectory>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private ReadOnlySpan<Char> <OriginalRootDirectory>k__BackingField; //Field offset: 0x14

	public FileAttributes Attributes
	{
		 get { } //Length: 22
	}

	public private ReadOnlySpan<Char> Directory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public ReadOnlySpan<Char> FileName
	{
		 get { } //Length: 20
	}

	public bool IsDirectory
	{
		 get { } //Length: 26
	}

	public private ReadOnlySpan<Char> OriginalRootDirectory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private ReadOnlySpan<Char> RootDirectory
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public FileAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_Directory() { }

	public ReadOnlySpan<Char> get_FileName() { }

	public bool get_IsDirectory() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_OriginalRootDirectory() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ReadOnlySpan<Char> get_RootDirectory() { }

	internal static void Initialize(ref FileSystemEntry entry, FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<Char> directory, ReadOnlySpan<Char> rootDirectory, ReadOnlySpan<Char> originalRootDirectory) { }

	[CompilerGenerated]
	private void set_Directory(ReadOnlySpan<Char> value) { }

	[CompilerGenerated]
	private void set_OriginalRootDirectory(ReadOnlySpan<Char> value) { }

	[CompilerGenerated]
	private void set_RootDirectory(ReadOnlySpan<Char> value) { }

	public FileSystemInfo ToFileSystemInfo() { }

	public string ToSpecifiedFullPath() { }

}

