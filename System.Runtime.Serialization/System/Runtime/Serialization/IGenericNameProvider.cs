namespace System.Runtime.Serialization;

internal interface IGenericNameProvider
{

	public bool ParametersFromBuiltInNamespaces
	{
		 get { } //Length: 0
	}

	public bool get_ParametersFromBuiltInNamespaces() { }

	public string GetGenericTypeName() { }

	public string GetNamespaces() { }

	public IList<Int32> GetNestedParameterCounts() { }

	public int GetParameterCount() { }

	public string GetParameterName(int paramIndex) { }

}

