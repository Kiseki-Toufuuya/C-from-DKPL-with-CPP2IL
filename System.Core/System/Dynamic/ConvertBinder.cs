namespace System.Dynamic;

public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0xC

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public Type get_Type() { }

}

