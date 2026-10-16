namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings
{
	internal static readonly StreamingContext DefaultContext; //Field offset: 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; //Field offset: 0x8
	internal Nullable<Formatting> _formatting; //Field offset: 0x8
	internal Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x10
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x18
	internal Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x20
	internal Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x28
	internal Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0x30
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0x38
	internal CultureInfo _culture; //Field offset: 0x40
	internal Nullable<Boolean> _checkAdditionalContent; //Field offset: 0x44
	internal Nullable<Int32> _maxDepth; //Field offset: 0x48
	internal bool _maxDepthSet; //Field offset: 0x50
	internal string _dateFormatString; //Field offset: 0x54
	internal bool _dateFormatStringSet; //Field offset: 0x58
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; //Field offset: 0x5C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x64
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; //Field offset: 0x6C
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x74
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x7C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x84
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x8C
	internal Nullable<StreamingContext> _context; //Field offset: 0x94
	internal Nullable<ConstructorHandling> _constructorHandling; //Field offset: 0xA0
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0xA8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; //Field offset: 0xB0
	[CompilerGenerated]
	[Nullable(1)]
	private IList<JsonConverter> <Converters>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; //Field offset: 0xD0

	public ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 43
	}

	public StreamingContext Context
	{
		 get { } //Length: 129
	}

	public IContractResolver ContractResolver
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[Nullable(1)]
	public IList<JsonConverter> Converters
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 14
	}

	public DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 40
	}

	public IEqualityComparer EqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public EventHandler<ErrorEventArgs> Error
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 43
	}

	public MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 43
	}

	public NullValueHandling NullValueHandling
	{
		 get { } //Length: 40
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 43
	}

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 40
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 43
	}

	public Func<IReferenceResolver> ReferenceResolverProvider
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public ISerializationBinder SerializationBinder
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public ITraceWriter TraceWriter
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 40
	}

	public TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 43
	}

	private static JsonSerializerSettings() { }

	public ConstructorHandling get_ConstructorHandling() { }

	public StreamingContext get_Context() { }

	[CompilerGenerated]
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public IList<JsonConverter> get_Converters() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	public EventHandler<ErrorEventArgs> get_Error() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	public ITraceWriter get_TraceWriter() { }

	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

}

