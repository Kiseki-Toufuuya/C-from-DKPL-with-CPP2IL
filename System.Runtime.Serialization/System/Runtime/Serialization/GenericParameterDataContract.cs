namespace System.Runtime.Serialization;

internal sealed class GenericParameterDataContract : DataContract
{
	private class GenericParameterDataContractCriticalHelper : DataContractCriticalHelper
	{
		private int parameterPosition; //Field offset: 0x30

		internal int ParameterPosition
		{
			internal get { } //Length: 11
		}

		internal GenericParameterDataContractCriticalHelper(Type type) { }

		internal int get_ParameterPosition() { }

	}

	private GenericParameterDataContractCriticalHelper helper; //Field offset: 0x14

	internal virtual bool IsBuiltInDataContract
	{
		internal get { } //Length: 3
	}

	internal int ParameterPosition
	{
		internal get { } //Length: 23
	}

	internal GenericParameterDataContract(Type type) { }

	internal virtual DataContract BindGenericParameters(DataContract[] paramContracts, Dictionary<DataContract, DataContract> boundContracts) { }

	internal virtual bool get_IsBuiltInDataContract() { }

	internal int get_ParameterPosition() { }

}

