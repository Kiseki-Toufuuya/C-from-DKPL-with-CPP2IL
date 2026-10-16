namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonContainerAttribute : Attribute
{
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; //Field offset: 0x10
	internal Nullable<Boolean> _isReference; //Field offset: 0x14
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x16
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x18
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x20
	private Type _namingStrategyType; //Field offset: 0x28
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Object[] _namingStrategyParameters; //Field offset: 0x2C

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Object[] ItemConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Type ItemConverterType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal NamingStrategy NamingStrategyInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Object[] NamingStrategyParameters
	{
		 get { } //Length: 11
	}

	public Type NamingStrategyType
	{
		 get { } //Length: 11
	}

	[CompilerGenerated]
	public Object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	internal NamingStrategy get_NamingStrategyInstance() { }

	public Object[] get_NamingStrategyParameters() { }

	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

}

