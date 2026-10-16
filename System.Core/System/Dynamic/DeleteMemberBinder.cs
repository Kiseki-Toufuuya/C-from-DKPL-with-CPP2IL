namespace System.Dynamic;

public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x10

	public bool IgnoreCase
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_IgnoreCase() { }

	[CompilerGenerated]
	public string get_Name() { }

}

