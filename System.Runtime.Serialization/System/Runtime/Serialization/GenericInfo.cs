namespace System.Runtime.Serialization;

internal class GenericInfo : IGenericNameProvider
{
	private string genericTypeName; //Field offset: 0x8
	private XmlQualifiedName stableName; //Field offset: 0xC
	private List<GenericInfo> paramGenericInfos; //Field offset: 0x10
	private List<Int32> nestedParamCounts; //Field offset: 0x14

	internal IList<GenericInfo> Parameters
	{
		internal get { } //Length: 11
	}

	public override bool ParametersFromBuiltInNamespaces
	{
		 get { } //Length: 145
	}

	internal XmlQualifiedName StableName
	{
		internal get { } //Length: 11
	}

	internal GenericInfo(XmlQualifiedName stableName, string genericTypeName) { }

	internal void Add(GenericInfo actualParamInfo) { }

	internal void AddToLevel(int level, int count) { }

	internal IList<GenericInfo> get_Parameters() { }

	public override bool get_ParametersFromBuiltInNamespaces() { }

	internal XmlQualifiedName get_StableName() { }

	internal XmlQualifiedName GetExpandedStableName() { }

	public override string GetGenericTypeName() { }

	public override string GetNamespaces() { }

	public override IList<Int32> GetNestedParameterCounts() { }

	public override int GetParameterCount() { }

	public override string GetParameterName(int paramIndex) { }

	internal string GetStableNamespace() { }

}

