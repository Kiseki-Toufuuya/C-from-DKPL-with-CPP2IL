namespace System.Runtime.Serialization;

[DefaultMember("Item")]
internal class DataContractSet
{
	private Dictionary<XmlQualifiedName, DataContract> contracts; //Field offset: 0x8
	private Dictionary<DataContract, Object> processedContracts; //Field offset: 0xC
	private IDataContractSurrogate dataContractSurrogate; //Field offset: 0x10
	private Hashtable surrogateDataTable; //Field offset: 0x14
	private Dictionary<XmlQualifiedName, DataContract> knownTypesForObject; //Field offset: 0x18
	private ICollection<Type> referencedTypes; //Field offset: 0x1C
	private ICollection<Type> referencedCollectionTypes; //Field offset: 0x20
	private Dictionary<XmlQualifiedName, Object> referencedTypesDictionary; //Field offset: 0x24
	private Dictionary<XmlQualifiedName, Object> referencedCollectionTypesDictionary; //Field offset: 0x28

	private Dictionary<XmlQualifiedName, DataContract> Contracts
	{
		private get { } //Length: 101
	}

	public IDataContractSurrogate DataContractSurrogate
	{
		 get { } //Length: 11
	}

	public DataContract Item
	{
		 get { } //Length: 168
	}

	internal Dictionary<XmlQualifiedName, DataContract> KnownTypesForObject
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	private Dictionary<DataContract, Object> ProcessedContracts
	{
		private get { } //Length: 101
	}

	private Hashtable SurrogateDataTable
	{
		private get { } //Length: 87
	}

	internal DataContractSet(IDataContractSurrogate dataContractSurrogate) { }

	internal DataContractSet(IDataContractSurrogate dataContractSurrogate, ICollection<Type> referencedTypes, ICollection<Type> referencedCollectionTypes) { }

	internal DataContractSet(DataContractSet dataContractSet) { }

	private void Add(DataContract dataContract) { }

	internal void Add(Type type) { }

	public void Add(XmlQualifiedName name, DataContract dataContract) { }

	private void AddClassDataContract(ClassDataContract classDataContract) { }

	private void AddCollectionDataContract(CollectionDataContract collectionDataContract) { }

	private void AddKnownDataContracts(Dictionary<XmlQualifiedName, DataContract> knownDataContracts) { }

	private void AddReferencedType(Dictionary<XmlQualifiedName, Object> referencedTypes, Type type) { }

	private void AddXmlDataContract(XmlDataContract xmlDataContract) { }

	internal static void EnsureTypeNotGeneric(Type type) { }

	private Dictionary<XmlQualifiedName, DataContract> get_Contracts() { }

	public IDataContractSurrogate get_DataContractSurrogate() { }

	public DataContract get_Item(XmlQualifiedName key) { }

	internal Dictionary<XmlQualifiedName, DataContract> get_KnownTypesForObject() { }

	private Dictionary<DataContract, Object> get_ProcessedContracts() { }

	private Hashtable get_SurrogateDataTable() { }

	internal DataContract GetDataContract(Type clrType) { }

	public IEnumerator<KeyValuePair`2<XmlQualifiedName, DataContract>> GetEnumerator() { }

	internal DataContract GetItemTypeDataContract(CollectionDataContract collectionContract) { }

	internal DataContract GetMemberTypeDataContract(DataMember dataMember) { }

	private Dictionary<XmlQualifiedName, Object> GetReferencedCollectionTypes() { }

	private Dictionary<XmlQualifiedName, Object> GetReferencedTypes() { }

	internal XmlQualifiedName GetStableName(Type clrType) { }

	internal object GetSurrogateData(object key) { }

	internal void InternalAdd(XmlQualifiedName name, DataContract dataContract) { }

	internal bool IsContractProcessed(DataContract dataContract) { }

	private static bool IsTypeReferenceable(Type type) { }

	public bool Remove(XmlQualifiedName key) { }

	internal void set_KnownTypesForObject(Dictionary<XmlQualifiedName, DataContract> value) { }

	internal void SetContractProcessed(DataContract dataContract) { }

	internal void SetSurrogateData(object key, object surrogateData) { }

	internal bool TryGetReferencedCollectionType(XmlQualifiedName stableName, DataContract dataContract, out Type type) { }

	private bool TryGetReferencedType(XmlQualifiedName stableName, DataContract dataContract, bool useReferencedCollectionTypes, out Type type) { }

	internal bool TryGetReferencedType(XmlQualifiedName stableName, DataContract dataContract, out Type type) { }

}

