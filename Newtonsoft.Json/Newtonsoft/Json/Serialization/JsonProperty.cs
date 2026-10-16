namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonProperty
{
	internal Nullable<Required> _required; //Field offset: 0x8
	internal bool _hasExplicitDefaultValue; //Field offset: 0x10
	private object _defaultValue; //Field offset: 0x14
	private bool _hasGeneratedDefaultValue; //Field offset: 0x18
	private string _propertyName; //Field offset: 0x1C
	internal bool _skipPropertyNameEscape; //Field offset: 0x20
	private Type _propertyType; //Field offset: 0x24
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private Nullable<Int32> <Order>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Readable>k__BackingField; //Field offset: 0x49
	[CompilerGenerated]
	private bool <Writable>k__BackingField; //Field offset: 0x4A
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; //Field offset: 0x4B
	[CompilerGenerated]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <ShouldSerialize>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <ShouldDeserialize>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private Predicate<Object> <GetIsSpecified>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	private Action<Object, Object> <SetIsSpecified>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Nullable<Boolean> <ItemIsReference>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; //Field offset: 0x98

	public IAttributeProvider AttributeProvider
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public JsonConverter Converter
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Type DeclaringType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public object DefaultValue
	{
		 get { } //Length: 21
		 set { } //Length: 31
	}

	public Nullable<DefaultValueHandling> DefaultValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> GetIsSpecified
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public bool HasMemberAttribute
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool Ignored
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Nullable<Boolean> IsReference
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public JsonConverter ItemConverter
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public Nullable<Boolean> ItemIsReference
	{
		[CompilerGenerated]
		 get { } //Length: 15
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Nullable<TypeNameHandling> ItemTypeNameHandling
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public Nullable<NullValueHandling> NullValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Nullable<ObjectCreationHandling> ObjectCreationHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Nullable<Int32> Order
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	internal JsonContract PropertyContract
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public string PropertyName
	{
		 get { } //Length: 11
		 set { } //Length: 110
	}

	public Type PropertyType
	{
		 get { } //Length: 11
		 set { } //Length: 76
	}

	public bool Readable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Required Required
	{
		 get { } //Length: 40
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 2})]
	public Action<Object, Object> SetIsSpecified
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> ShouldDeserialize
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Predicate<Object> ShouldSerialize
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Nullable<TypeNameHandling> TypeNameHandling
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public string UnderlyingName
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public IValueProvider ValueProvider
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool Writable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public JsonProperty() { }

	[CompilerGenerated]
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	public Type get_DeclaringType() { }

	public object get_DefaultValue() { }

	[CompilerGenerated]
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	public Predicate<Object> get_GetIsSpecified() { }

	[CompilerGenerated]
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	public bool get_Ignored() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_IsReference() { }

	[CompilerGenerated]
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_ItemIsReference() { }

	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	public Nullable<Int32> get_Order() { }

	[CompilerGenerated]
	internal JsonContract get_PropertyContract() { }

	public string get_PropertyName() { }

	public Type get_PropertyType() { }

	[CompilerGenerated]
	public bool get_Readable() { }

	[CompilerGenerated]
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	public Required get_Required() { }

	[CompilerGenerated]
	public Action<Object, Object> get_SetIsSpecified() { }

	[CompilerGenerated]
	public Predicate<Object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	public Predicate<Object> get_ShouldSerialize() { }

	[CompilerGenerated]
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	public bool get_Writable() { }

	internal object GetResolvedDefaultValue() { }

	[CompilerGenerated]
	public void set_AttributeProvider(IAttributeProvider value) { }

	[CompilerGenerated]
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_DeclaringType(Type value) { }

	public void set_DefaultValue(object value) { }

	[CompilerGenerated]
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	public void set_GetIsSpecified(Predicate<Object> value) { }

	[CompilerGenerated]
	public void set_HasMemberAttribute(bool value) { }

	[CompilerGenerated]
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	public void set_IsReference(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_ItemIsReference(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	public void set_Order(Nullable<Int32> value) { }

	[CompilerGenerated]
	internal void set_PropertyContract(JsonContract value) { }

	public void set_PropertyName(string value) { }

	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	public void set_SetIsSpecified(Action<Object, Object> value) { }

	[CompilerGenerated]
	public void set_ShouldSerialize(Predicate<Object> value) { }

	[CompilerGenerated]
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	public void set_Writable(bool value) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	[NullableContext(1)]
	internal void WritePropertyName(JsonWriter writer) { }

}

