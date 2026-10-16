namespace System.Runtime.Serialization;

internal sealed class SpecialTypeDataContract : DataContract
{
	private class SpecialTypeDataContractCriticalHelper : DataContractCriticalHelper
	{

		internal SpecialTypeDataContractCriticalHelper(Type type) { }

		internal SpecialTypeDataContractCriticalHelper(Type type, XmlDictionaryString name, XmlDictionaryString ns) { }

	}

	private SpecialTypeDataContractCriticalHelper helper; //Field offset: 0x14

	internal virtual bool IsBuiltInDataContract
	{
		internal get { } //Length: 3
	}

	public SpecialTypeDataContract(Type type) { }

	public SpecialTypeDataContract(Type type, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal virtual bool get_IsBuiltInDataContract() { }

}

