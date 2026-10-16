namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonArrayContract : JsonContainerContract
{
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; //Field offset: 0x70
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0x74
	private Type _genericWrapperType; //Field offset: 0x78
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0x7C
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func<Object> _genericTemporaryCollectionCreator; //Field offset: 0x80
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0x85
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; //Field offset: 0x86
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0x88
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x8C
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x90
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x94

	internal bool CanDeserialize
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public Type CollectionItemType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool HasParameterizedCreator
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	internal bool HasParameterizedCreatorInternal
	{
		internal get { } //Length: 100
	}

	internal bool IsArray
	{
		[CompilerGenerated]
		internal get { } //Length: 14
	}

	public bool IsMultidimensionalArray
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor<Object> OverrideCreator
	{
		 get { } //Length: 14
		 set { } //Length: 42
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		internal get { } //Length: 195
	}

	internal bool ShouldCreateWrapper
	{
		[CompilerGenerated]
		internal get { } //Length: 14
	}

	[NullableContext(1)]
	public JsonArrayContract(Type underlyingType) { }

	[NullableContext(1)]
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	internal IWrappedCollection CreateWrapper(object list) { }

	[CompilerGenerated]
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	public bool get_HasParameterizedCreator() { }

	internal bool get_HasParameterizedCreatorInternal() { }

	[CompilerGenerated]
	internal bool get_IsArray() { }

	[CompilerGenerated]
	public bool get_IsMultidimensionalArray() { }

	public ObjectConstructor<Object> get_OverrideCreator() { }

	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CompilerGenerated]
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	private void set_CanDeserialize(bool value) { }

	[CompilerGenerated]
	public void set_HasParameterizedCreator(bool value) { }

	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	[NullableContext(1)]
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

}

