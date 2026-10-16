namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonDictionaryContract : JsonContainerContract
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func<String, String> <DictionaryKeyResolver>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; //Field offset: 0x78
	private readonly Type _genericCollectionDefinitionType; //Field offset: 0x7C
	private Type _genericWrapperType; //Field offset: 0x80
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _genericWrapperCreator; //Field offset: 0x84
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Func<Object> _genericTemporaryDictionaryCreator; //Field offset: 0x88
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; //Field offset: 0x8C
	private readonly ConstructorInfo _parameterizedConstructor; //Field offset: 0x90
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x94
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x98
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; //Field offset: 0x9C

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func<String, String> DictionaryKeyResolver
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Type DictionaryKeyType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Type DictionaryValueType
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

	internal JsonContract KeyContract
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor<Object> OverrideCreator
	{
		 get { } //Length: 14
		 set { } //Length: 33
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
	public JsonDictionaryContract(Type underlyingType) { }

	[NullableContext(1)]
	internal IDictionary CreateTemporaryDictionary() { }

	[NullableContext(1)]
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[CompilerGenerated]
	public Func<String, String> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	public bool get_HasParameterizedCreator() { }

	internal bool get_HasParameterizedCreatorInternal() { }

	[CompilerGenerated]
	internal JsonContract get_KeyContract() { }

	public ObjectConstructor<Object> get_OverrideCreator() { }

	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CompilerGenerated]
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	public void set_DictionaryKeyResolver(Func<String, String> value) { }

	[CompilerGenerated]
	public void set_HasParameterizedCreator(bool value) { }

	[CompilerGenerated]
	internal void set_KeyContract(JsonContract value) { }

	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

}

