namespace System.Runtime.Serialization;

internal class XmlObjectSerializerContext
{
	private static MethodInfo incrementItemCountMethod; //Field offset: 0x0
	protected XmlObjectSerializer serializer; //Field offset: 0x8
	protected DataContract rootTypeDataContract; //Field offset: 0xC
	internal ScopedKnownTypes scopedKnownTypes; //Field offset: 0x10
	protected Dictionary<XmlQualifiedName, DataContract> serializerKnownDataContracts; //Field offset: 0x18
	private bool isSerializerKnownDataContractsSetExplicit; //Field offset: 0x1C
	protected IList<Type> serializerKnownTypeList; //Field offset: 0x20
	private bool demandedSerializationFormatterPermission; //Field offset: 0x24
	private bool demandedMemberAccessPermission; //Field offset: 0x25
	private int itemCount; //Field offset: 0x28
	private int maxItemsInObjectGraph; //Field offset: 0x2C
	private StreamingContext streamingContext; //Field offset: 0x30
	private bool ignoreExtensionDataObject; //Field offset: 0x38
	private DataContractResolver dataContractResolver; //Field offset: 0x3C
	private KnownTypeDataContractResolver knownTypeResolver; //Field offset: 0x40

	protected DataContractResolver DataContractResolver
	{
		 get { } //Length: 11
	}

	internal bool IgnoreExtensionDataObject
	{
		internal get { } //Length: 11
	}

	internal static MethodInfo IncrementItemCountMethod
	{
		internal get { } //Length: 178
	}

	internal override bool IsGetOnlyCollection
	{
		internal get { } //Length: 3
		internal set { } //Length: 3
	}

	protected KnownTypeDataContractResolver KnownTypeResolver
	{
		 get { } //Length: 88
	}

	internal override SerializationMode Mode
	{
		internal get { } //Length: 3
	}

	internal int RemainingItemCount
	{
		internal get { } //Length: 14
	}

	private Dictionary<XmlQualifiedName, DataContract> SerializerKnownDataContracts
	{
		private get { } //Length: 68
	}

	internal XmlObjectSerializerContext(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject, DataContractResolver dataContractResolver) { }

	internal XmlObjectSerializerContext(XmlObjectSerializer serializer, int maxItemsInObjectGraph, StreamingContext streamingContext, bool ignoreExtensionDataObject) { }

	internal XmlObjectSerializerContext(DataContractSerializer serializer, DataContract rootTypeDataContract, DataContractResolver dataContractResolver) { }

	internal XmlObjectSerializerContext(NetDataContractSerializer serializer) { }

	internal override void CheckIfTypeSerializable(Type memberType, bool isMemberTypeSerializable) { }

	public void DemandMemberAccessPermission() { }

	public void DemandSerializationFormatterPermission() { }

	protected DataContractResolver get_DataContractResolver() { }

	internal bool get_IgnoreExtensionDataObject() { }

	internal static MethodInfo get_IncrementItemCountMethod() { }

	internal override bool get_IsGetOnlyCollection() { }

	protected KnownTypeDataContractResolver get_KnownTypeResolver() { }

	internal override SerializationMode get_Mode() { }

	internal int get_RemainingItemCount() { }

	private Dictionary<XmlQualifiedName, DataContract> get_SerializerKnownDataContracts() { }

	internal DataContract GetDataContract(Type type) { }

	internal override DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type) { }

	internal override DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle) { }

	private DataContract GetDataContractFromSerializerKnownTypes(XmlQualifiedName qname) { }

	internal static Dictionary<XmlQualifiedName, DataContract> GetDataContractsForKnownTypes(IList<Type> knownTypeList) { }

	internal override DataContract GetDataContractSkipValidation(int typeId, RuntimeTypeHandle typeHandle, Type type) { }

	public StreamingContext GetStreamingContext() { }

	internal override Type GetSurrogatedType(Type type) { }

	public void IncrementItemCount(int count) { }

	internal bool IsKnownType(DataContract dataContract, Dictionary<XmlQualifiedName, DataContract> knownDataContracts, Type declaredType) { }

	internal bool IsKnownType(DataContract dataContract, Type declaredType) { }

	private DataContract ResolveDataContractFromDataContractResolver(XmlQualifiedName typeName, Type declaredType) { }

	protected DataContract ResolveDataContractFromKnownTypes(string typeName, string typeNs, DataContract memberTypeContract, Type declaredType) { }

	private DataContract ResolveDataContractFromKnownTypes(XmlQualifiedName typeName) { }

	protected override DataContract ResolveDataContractFromRootDataContract(XmlQualifiedName typeQName) { }

	internal Type ResolveNameFromKnownTypes(XmlQualifiedName typeName) { }

	internal override void set_IsGetOnlyCollection(bool value) { }

}

