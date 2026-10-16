namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract
{
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Func<String, String> <ExtensionDataNameResolver>k__BackingField; //Field offset: 0x94
	internal bool ExtensionDataIsJToken; //Field offset: 0x98
	private Nullable<Boolean> _hasRequiredOrDefaultValueProperties; //Field offset: 0x99
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x9C
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0xA0
	private JsonPropertyCollection _creatorParameters; //Field offset: 0xA4
	private Type _extensionDataValueType; //Field offset: 0xA8

	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters
	{
		[NullableContext(1)]
		 get { } //Length: 105
	}

	public ExtensionDataGetter ExtensionDataGetter
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	public Func<String, String> ExtensionDataNameResolver
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public ExtensionDataSetter ExtensionDataSetter
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Type ExtensionDataValueType
	{
		 set { } //Length: 203
	}

	internal bool HasRequiredOrDefaultValueProperties
	{
		internal get { } //Length: 672
	}

	public Nullable<NullValueHandling> ItemNullValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Nullable<Required> ItemRequired
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MemberSerialization MemberSerialization
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Nullable<MissingMemberHandling> MissingMemberHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
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
		internal get { } //Length: 14
		internal set { } //Length: 33
	}

	[Nullable(1)]
	public JsonPropertyCollection Properties
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 14
	}

	[NullableContext(1)]
	public JsonObjectContract(Type underlyingType) { }

	[NullableContext(1)]
	public JsonPropertyCollection get_CreatorParameters() { }

	[CompilerGenerated]
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	public Func<String, String> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[CompilerGenerated]
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	public ObjectConstructor<Object> get_OverrideCreator() { }

	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	internal object GetUninitializedObject() { }

	[CompilerGenerated]
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	[CompilerGenerated]
	public void set_ExtensionDataNameResolver(Func<String, String> value) { }

	[CompilerGenerated]
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	internal void set_ParameterizedCreator(ObjectConstructor<Object> value) { }

}

