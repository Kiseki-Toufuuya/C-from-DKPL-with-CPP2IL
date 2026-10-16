namespace System.Runtime.Serialization;

internal class GenericNameProvider : IGenericNameProvider
{
	private string genericTypeName; //Field offset: 0x8
	private Object[] genericParams; //Field offset: 0xC
	private IList<Int32> nestedParamCounts; //Field offset: 0x10

	public override bool ParametersFromBuiltInNamespaces
	{
		 get { } //Length: 84
	}

	internal GenericNameProvider(Type type) { }

	internal GenericNameProvider(string genericTypeName, Object[] genericParams) { }

	public override bool get_ParametersFromBuiltInNamespaces() { }

	public override string GetGenericTypeName() { }

	public override string GetNamespaces() { }

	public override IList<Int32> GetNestedParameterCounts() { }

	public override int GetParameterCount() { }

	public override string GetParameterName(int paramIndex) { }

	private XmlQualifiedName GetStableName(int i) { }

}

