namespace System.Runtime.Serialization.Json;

internal class JsonDataContract
{
	public class JsonDataContractCriticalHelper
	{
		private static object cacheLock; //Field offset: 0x0
		private static object createDataContractLock; //Field offset: 0x4
		private static JsonDataContract[] dataContractCache; //Field offset: 0x8
		private static int dataContractID; //Field offset: 0xC
		private static TypeHandleRef typeHandleRef; //Field offset: 0x10
		private static Dictionary<TypeHandleRef, IntRef> typeToIDCache; //Field offset: 0x14
		private Dictionary<XmlQualifiedName, DataContract> knownDataContracts; //Field offset: 0x8
		private DataContract traditionalDataContract; //Field offset: 0xC
		private string typeName; //Field offset: 0x10

		internal Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
		{
			internal get { } //Length: 11
		}

		internal DataContract TraditionalDataContract
		{
			internal get { } //Length: 11
		}

		internal override string TypeName
		{
			internal get { } //Length: 11
		}

		private static JsonDataContractCriticalHelper() { }

		internal JsonDataContractCriticalHelper(DataContract traditionalDataContract) { }

		private void AddCollectionItemContractsToKnownDataContracts() { }

		private static JsonDataContract CreateJsonDataContract(int id, DataContract traditionalDataContract) { }

		internal Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

		internal DataContract get_TraditionalDataContract() { }

		internal override string get_TypeName() { }

		internal static int GetId(RuntimeTypeHandle typeHandle) { }

		public static JsonDataContract GetJsonDataContract(DataContract traditionalDataContract) { }

	}

	private JsonDataContractCriticalHelper helper; //Field offset: 0x8

	protected JsonDataContractCriticalHelper Helper
	{
		 get { } //Length: 11
	}

	private Dictionary<XmlQualifiedName, DataContract> KnownDataContracts
	{
		private get { } //Length: 23
	}

	protected DataContract TraditionalDataContract
	{
		 get { } //Length: 23
	}

	internal override string TypeName
	{
		internal get { } //Length: 3
	}

	protected JsonDataContract(DataContract traditionalDataContract) { }

	protected JsonDataContract(JsonDataContractCriticalHelper helper) { }

	protected JsonDataContractCriticalHelper get_Helper() { }

	private Dictionary<XmlQualifiedName, DataContract> get_KnownDataContracts() { }

	protected DataContract get_TraditionalDataContract() { }

	internal override string get_TypeName() { }

	public static JsonDataContract GetJsonDataContract(DataContract traditionalDataContract) { }

	protected static object HandleReadValue(object obj, XmlObjectSerializerReadContext context) { }

	protected void PopKnownDataContracts(XmlObjectSerializerContext context) { }

	protected void PushKnownDataContracts(XmlObjectSerializerContext context) { }

	public object ReadJsonValue(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public override object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	protected static bool TryReadNullAtTopLevel(XmlReaderDelegator reader) { }

	public void WriteJsonValue(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

	public override void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

