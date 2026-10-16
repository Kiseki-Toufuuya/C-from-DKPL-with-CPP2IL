namespace Cinemachine;

[DocumentationSorting(Level::Undoc (0))]
public sealed class DocumentationSortingAttribute : Attribute
{
	internal enum Level
	{
		Undoc = 0,
		API = 1,
		UserRef = 2,
	}

	[CompilerGenerated]
	private Level <Category>k__BackingField; //Field offset: 0x8

	public private Level Category
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public DocumentationSortingAttribute(Level category) { }

	[CompilerGenerated]
	public Level get_Category() { }

	[CompilerGenerated]
	private void set_Category(Level value) { }

}

