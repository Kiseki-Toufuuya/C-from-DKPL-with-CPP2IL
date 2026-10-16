namespace System.Dynamic;

public abstract class GetMemberBinder : DynamicMetaObjectBinder
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

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 43
	}

	protected GetMemberBinder(string name, bool ignoreCase) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_IgnoreCase() { }

	internal virtual bool get_IsStandardBinder() { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual Type get_ReturnType() { }

}

