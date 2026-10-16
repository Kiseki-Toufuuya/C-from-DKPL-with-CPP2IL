namespace System.Runtime.Serialization;

internal abstract class DataContract
{
	internal class DataContractCriticalHelper
	{
		private static Dictionary<TypeHandleRef, IntRef> typeToIDCache; //Field offset: 0x0
		private static DataContract[] dataContractCache; //Field offset: 0x4
		private static int dataContractID; //Field offset: 0x8
		private static Dictionary<Type, DataContract> typeToBuiltInContract; //Field offset: 0xC
		private static Dictionary<XmlQualifiedName, DataContract> nameToBuiltInContract; //Field offset: 0x10
		private static Dictionary<String, DataContract> typeNameToBuiltInContract; //Field offset: 0x14
		private static Dictionary<String, String> namespaces; //Field offset: 0x18
		private static Dictionary<String, XmlDictionaryString> clrTypeStrings; //Field offset: 0x1C
		private static XmlDictionary clrTypeStringsDictionary; //Field offset: 0x20
		private static TypeHandleRef typeHandleRef; //Field offset: 0x24
		private static object cacheLock; //Field offset: 0x28
		private static object createDataContractLock; //Field offset: 0x2C
		private static object initBuiltInContractsLock; //Field offset: 0x30
		private static object namespacesLock; //Field offset: 0x34
		private static object clrTypeStringsLock; //Field offset: 0x38
		private readonly Type underlyingType; //Field offset: 0x8
		private Type originalUnderlyingType; //Field offset: 0xC
		private bool isReference; //Field offset: 0x10
		private bool isValueType; //Field offset: 0x11
		private XmlQualifiedName stableName; //Field offset: 0x14
		private GenericInfo genericInfo; //Field offset: 0x18
		private XmlDictionaryString name; //Field offset: 0x1C
		private XmlDictionaryString ns; //Field offset: 0x20
		private Type typeForInitialization; //Field offset: 0x24
		private MethodInfo parseMethod; //Field offset: 0x28
		private bool parseMethodSet; //Field offset: 0x2C

		internal override bool CanContainReferences
		{
			internal get { } //Length: 3
		}

		internal GenericInfo GenericInfo
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal override bool HasRoot
		{
			internal get { } //Length: 3
			internal set { } //Length: 3
		}

		internal override bool IsBuiltInDataContract
		{
			internal get { } //Length: 3
		}

		internal override bool IsISerializable
		{
			internal get { } //Length: 3
			internal set { } //Length: 59
		}

		internal override bool IsPrimitive
		{
			internal get { } //Length: 3
		}

		internal bool IsReference
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsValueType
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal override Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			internal get { } //Length: 3
			internal set { } //Length: 3
		}

		internal XmlDictionaryString Name
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		public XmlDictionaryString Namespace
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		internal Type OriginalUnderlyingType
		{
			internal get { } //Length: 258
		}

		internal MethodInfo ParseMethod
		{
			internal get { } //Length: 358
		}

		internal XmlQualifiedName StableName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal override XmlDictionaryString TopLevelElementName
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal override XmlDictionaryString TopLevelElementNamespace
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal Type TypeForInitialization
		{
			internal get { } //Length: 11
		}

		internal Type UnderlyingType
		{
			internal get { } //Length: 11
		}

		private static DataContractCriticalHelper() { }

		internal DataContractCriticalHelper(Type type) { }

		internal DataContractCriticalHelper() { }

		private static void AssignDataContractToId(DataContract dataContract, int id) { }

		private static bool ContractMatches(DataContract contract, DataContract cachedContract) { }

		private static DataContract CreateDataContract(int id, RuntimeTypeHandle typeHandle, Type type) { }

		private static DataContract CreateGetOnlyCollectionDataContract(int id, RuntimeTypeHandle typeHandle, Type type) { }

		internal override bool get_CanContainReferences() { }

		internal GenericInfo get_GenericInfo() { }

		internal override bool get_HasRoot() { }

		internal override bool get_IsBuiltInDataContract() { }

		internal override bool get_IsISerializable() { }

		internal override bool get_IsPrimitive() { }

		internal bool get_IsReference() { }

		internal bool get_IsValueType() { }

		internal override Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

		internal XmlDictionaryString get_Name() { }

		public XmlDictionaryString get_Namespace() { }

		internal Type get_OriginalUnderlyingType() { }

		internal MethodInfo get_ParseMethod() { }

		internal XmlQualifiedName get_StableName() { }

		internal override XmlDictionaryString get_TopLevelElementName() { }

		internal override XmlDictionaryString get_TopLevelElementNamespace() { }

		internal Type get_TypeForInitialization() { }

		internal Type get_UnderlyingType() { }

		public static DataContract GetBuiltInDataContract(Type type) { }

		public static DataContract GetBuiltInDataContract(string typeName) { }

		public static DataContract GetBuiltInDataContract(string name, string ns) { }

		internal static XmlDictionaryString GetClrTypeString(string key) { }

		internal static Type GetDataContractAdapterType(Type type) { }

		private static RuntimeTypeHandle GetDataContractAdapterTypeHandle(RuntimeTypeHandle typeHandle) { }

		internal static DataContract GetDataContractForInitialization(int id) { }

		internal static Type GetDataContractOriginalType(Type type) { }

		internal static DataContract GetDataContractSkipValidation(int id, RuntimeTypeHandle typeHandle, Type type) { }

		internal static DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, RuntimeTypeHandle typeHandle, Type type) { }

		internal static int GetId(RuntimeTypeHandle typeHandle) { }

		internal static int GetIdForInitialization(ClassDataContract classContract) { }

		internal static string GetNamespace(string key) { }

		private static IntRef GetNextId() { }

		internal void set_GenericInfo(GenericInfo value) { }

		internal override void set_HasRoot(bool value) { }

		internal override void set_IsISerializable(bool value) { }

		internal void set_IsReference(bool value) { }

		internal void set_IsValueType(bool value) { }

		internal override void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

		internal void set_Name(XmlDictionaryString value) { }

		public void set_Namespace(XmlDictionaryString value) { }

		internal void set_StableName(XmlQualifiedName value) { }

		internal override void set_TopLevelElementName(XmlDictionaryString value) { }

		internal override void set_TopLevelElementNamespace(XmlDictionaryString value) { }

		internal void SetDataContractName(XmlDictionaryString name, XmlDictionaryString ns) { }

		internal void SetDataContractName(XmlQualifiedName stableName) { }

		private void SetTypeForInitialization(Type classType) { }

		internal static void ThrowInvalidDataContractException(string message, Type type) { }

		internal void ThrowInvalidDataContractException(string message) { }

		public static bool TryCreateBuiltInDataContract(string name, string ns, out DataContract dataContract) { }

		public static bool TryCreateBuiltInDataContract(Type type, out DataContract dataContract) { }

		internal override void WriteRootElement(XmlWriterDelegator writer, XmlDictionaryString name, XmlDictionaryString ns) { }

	}

	private XmlDictionaryString name; //Field offset: 0x8
	private XmlDictionaryString ns; //Field offset: 0xC
	private DataContractCriticalHelper helper; //Field offset: 0x10

	internal override bool CanContainReferences
	{
		internal get { } //Length: 3
	}

	internal GenericInfo GenericInfo
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal override bool HasRoot
	{
		internal get { } //Length: 3
		internal set { } //Length: 3
	}

	protected DataContractCriticalHelper Helper
	{
		 get { } //Length: 11
	}

	internal override bool IsBuiltInDataContract
	{
		internal get { } //Length: 40
	}

	internal override bool IsISerializable
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal override bool IsPrimitive
	{
		internal get { } //Length: 3
	}

	internal bool IsReference
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsValueType
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal override Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal XmlDictionaryString Name
	{
		internal get { } //Length: 11
	}

	public override XmlDictionaryString Namespace
	{
		 get { } //Length: 11
	}

	internal Type OriginalUnderlyingType
	{
		internal get { } //Length: 274
	}

	internal MethodInfo ParseMethod
	{
		internal get { } //Length: 369
	}

	internal XmlQualifiedName StableName
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal override XmlDictionaryString TopLevelElementName
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal override XmlDictionaryString TopLevelElementNamespace
	{
		internal get { } //Length: 40
		internal set { } //Length: 43
	}

	internal Type TypeForInitialization
	{
		internal get { } //Length: 23
	}

	internal Type UnderlyingType
	{
		internal get { } //Length: 23
	}

	protected DataContract(DataContractCriticalHelper helper) { }

	internal override DataContract BindGenericParameters(DataContract[] paramContracts, Dictionary<DataContract, DataContract> boundContracts) { }

	[SecurityTreatAsSafe]
	internal static void CheckAndAdd(Type type, Dictionary<Type, Type> typesChecked, ref Dictionary<XmlQualifiedName, DataContract>& nameToDataContractTable) { }

	private static void CheckExplicitDataContractNamespaceUri(string dataContractNs, Type type) { }

	private static void CheckRootTypeInConfigIsGeneric(Type type, ref Type rootType, ref Type[] genArgs) { }

	internal static XmlQualifiedName CreateQualifiedName(string localName, string ns) { }

	internal static string EncodeLocalName(string localName) { }

	public virtual bool Equals(object other) { }

	internal override bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	private static string ExpandGenericParameters(string format, Type type) { }

	internal static string ExpandGenericParameters(string format, IGenericNameProvider genericNameProvider) { }

	internal override bool get_CanContainReferences() { }

	internal GenericInfo get_GenericInfo() { }

	internal override bool get_HasRoot() { }

	protected DataContractCriticalHelper get_Helper() { }

	internal override bool get_IsBuiltInDataContract() { }

	internal override bool get_IsISerializable() { }

	internal override bool get_IsPrimitive() { }

	internal bool get_IsReference() { }

	internal bool get_IsValueType() { }

	internal override Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	internal XmlDictionaryString get_Name() { }

	public override XmlDictionaryString get_Namespace() { }

	internal Type get_OriginalUnderlyingType() { }

	internal MethodInfo get_ParseMethod() { }

	internal XmlQualifiedName get_StableName() { }

	internal override XmlDictionaryString get_TopLevelElementName() { }

	internal override XmlDictionaryString get_TopLevelElementNamespace() { }

	internal Type get_TypeForInitialization() { }

	internal Type get_UnderlyingType() { }

	private static string GetArrayPrefix(ref Type itemType) { }

	internal XmlQualifiedName GetArrayTypeName(bool isNullable) { }

	public static DataContract GetBuiltInDataContract(Type type) { }

	public static DataContract GetBuiltInDataContract(string name, string ns) { }

	public static DataContract GetBuiltInDataContract(string typeName) { }

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	internal static void GetClrNameAndNamespace(string fullTypeName, out string localName, out string ns) { }

	internal static string GetClrTypeFullName(Type type) { }

	private static string GetClrTypeFullNameForArray(Type type) { }

	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

	internal static string GetClrTypeFullNameUsingTypeForwardedFromAttribute(Type type) { }

	internal static XmlDictionaryString GetClrTypeString(string key) { }

	internal static string GetCollectionNamespace(string elementNs) { }

	internal static XmlQualifiedName GetCollectionStableName(Type type, Type itemType, out CollectionDataContractAttribute collectionContractAttribute) { }

	private static XmlQualifiedName GetCollectionStableName(Type type, Type itemType, Dictionary<Type, Object> previousCollectionTypes, out CollectionDataContractAttribute collectionContractAttribute) { }

	internal static DataContract GetDataContract(int id, RuntimeTypeHandle typeHandle, SerializationMode mode) { }

	internal static DataContract GetDataContract(Type type) { }

	internal static DataContract GetDataContract(RuntimeTypeHandle typeHandle, Type type, SerializationMode mode) { }

	internal static DataContract GetDataContractForInitialization(int id) { }

	internal static IList<Int32> GetDataContractNameForGenericName(string typeName, StringBuilder localName) { }

	internal static string GetDataContractNamespaceFromUri(string uriString) { }

	internal static DataContract GetDataContractSkipValidation(int id, RuntimeTypeHandle typeHandle, Type type) { }

	private static XmlQualifiedName GetDCTypeStableName(Type type, DataContractAttribute dataContractAttribute) { }

	private static string GetDefaultDataContractNamespace(Type type) { }

	private static string GetDefaultStableLocalName(Type type) { }

	private static void GetDefaultStableName(CodeTypeReference typeReference, out string localName, out string ns) { }

	internal static void GetDefaultStableName(string fullTypeName, out string localName, out string ns) { }

	internal static XmlQualifiedName GetDefaultStableName(Type type) { }

	internal static string GetDefaultStableNamespace(string clrNs) { }

	internal static string GetDefaultStableNamespace(Type type) { }

	internal static DataContract GetGetOnlyCollectionDataContract(int id, RuntimeTypeHandle typeHandle, Type type, SerializationMode mode) { }

	internal static DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, RuntimeTypeHandle typeHandle, Type type) { }

	private static string GetGlobalDataContractNamespace(string clrNs, ICustomAttributeProvider customAttribuetProvider) { }

	public virtual int GetHashCode() { }

	internal static int GetId(RuntimeTypeHandle typeHandle) { }

	internal static int GetIdForInitialization(ClassDataContract classContract) { }

	internal static string GetNamespace(string key) { }

	private static string GetNamespacesDigest(string namespaces) { }

	private static XmlQualifiedName GetNonDCTypeStableName(Type type, Dictionary<Type, Object> previousCollectionTypes) { }

	private static XmlQualifiedName GetStableName(Type type, Dictionary<Type, Object> previousCollectionTypes, out bool hasDataContract) { }

	internal static XmlQualifiedName GetStableName(Type type, out bool hasDataContract) { }

	internal static XmlQualifiedName GetStableName(Type type) { }

	internal override DataContract GetValidContract() { }

	internal override DataContract GetValidContract(SerializationMode mode) { }

	internal static Dictionary<XmlQualifiedName, DataContract> ImportKnownTypeAttributes(Type type) { }

	private static void ImportKnownTypeAttributes(Type type, Dictionary<Type, Type> typesChecked, ref Dictionary<XmlQualifiedName, DataContract>& knownDataContracts) { }

	private static bool IsAlpha(char ch) { }

	private static bool IsAsciiLocalName(string localName) { }

	internal static bool IsBuiltInNamespace(string ns) { }

	private static bool IsCollectionElementTypeEqualToRootType(string collectionElementTypeName, Type rootType) { }

	private static bool IsDigit(char ch) { }

	private static bool IsElemTypeNullOrNotEqualToRootType(string elemTypeName, Type rootType) { }

	internal bool IsEqualOrChecked(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	private static bool IsOpenGenericType(Type t) { }

	internal static bool IsTypeNullable(Type type) { }

	private static bool IsTypeSerializable(Type type, Dictionary<Type, Object> previousCollectionTypes) { }

	internal static bool IsTypeSerializable(Type type) { }

	internal static bool IsTypeVisible(Type t) { }

	internal override bool IsValidContract(SerializationMode mode) { }

	internal static bool IsValidNCName(string name) { }

	private static void LoadKnownTypesFromConfig(Type type, Dictionary<Type, Type> typesChecked, ref Dictionary<XmlQualifiedName, DataContract>& knownDataContracts) { }

	public override object ReadXmlValue(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context) { }

	internal void set_GenericInfo(GenericInfo value) { }

	internal override void set_HasRoot(bool value) { }

	internal override void set_IsISerializable(bool value) { }

	internal void set_IsReference(bool value) { }

	internal void set_IsValueType(bool value) { }

	internal override void set_KnownDataContracts(Dictionary<XmlQualifiedName, DataContract> value) { }

	internal void set_StableName(XmlQualifiedName value) { }

	internal override void set_TopLevelElementName(XmlDictionaryString value) { }

	internal override void set_TopLevelElementNamespace(XmlDictionaryString value) { }

	internal void ThrowInvalidDataContractException(string message) { }

	internal static void ThrowInvalidDataContractException(string message, Type type) { }

	public static void ThrowTypeNotSerializable(Type type) { }

	private static bool TryGetBuiltInXmlAndArrayTypeStableName(Type type, Dictionary<Type, Object> previousCollectionTypes, out XmlQualifiedName stableName) { }

	internal static bool TryGetDCAttribute(Type type, out DataContractAttribute dataContractAttribute) { }

	internal static Type UnwrapNullableType(Type type) { }

	internal static Type UnwrapRedundantNullableType(Type type) { }

	private static void ValidatePreviousCollectionTypes(Type collectionType, Type itemType, Dictionary<Type, Object> previousCollectionTypes) { }

	internal override void WriteRootElement(XmlWriterDelegator writer, XmlDictionaryString name, XmlDictionaryString ns) { }

	public override void WriteXmlValue(XmlWriterDelegator xmlWriter, object obj, XmlObjectSerializerWriteContext context) { }

}

