namespace System.Runtime.Serialization;

internal class DataNode : IDataNode
{
	protected Type dataType; //Field offset: 0x0
	private T value; //Field offset: 0x0
	private string dataContractName; //Field offset: 0x0
	private string dataContractNamespace; //Field offset: 0x0
	private string clrTypeName; //Field offset: 0x0
	private string clrAssemblyName; //Field offset: 0x0
	private string id; //Field offset: 0x0
	private bool isFinalValue; //Field offset: 0x0

	public override string ClrAssemblyName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string ClrTypeName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string DataContractName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override string DataContractNamespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override Type DataType
	{
		 get { } //Length: 11
	}

	public override string Id
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override bool PreservesReferences
	{
		 get { } //Length: 87
	}

	private override bool System.Runtime.Serialization.IDataNode.IsFinalValue
	{
		private get { } //Length: 11
		private set { } //Length: 14
	}

	public override object Value
	{
		 get { } //Length: 38
		 set { } //Length: 81
	}

	internal DataNode`1() { }

	internal DataNode`1(T value) { }

	internal void AddQualifiedNameAttribute(ElementData element, string elementPrefix, string elementName, string elementNs, string valueName, string valueNs) { }

	public override void Clear() { }

	public override string get_ClrAssemblyName() { }

	public override string get_ClrTypeName() { }

	public override string get_DataContractName() { }

	public override string get_DataContractNamespace() { }

	public override Type get_DataType() { }

	public override string get_Id() { }

	public override bool get_PreservesReferences() { }

	public override object get_Value() { }

	public override void GetData(ElementData element) { }

	public T GetValue() { }

	public override void set_ClrAssemblyName(string value) { }

	public override void set_ClrTypeName(string value) { }

	public override void set_DataContractName(string value) { }

	public override void set_DataContractNamespace(string value) { }

	public override void set_Id(string value) { }

	public override void set_Value(object value) { }

	private override bool System.Runtime.Serialization.IDataNode.get_IsFinalValue() { }

	private override void System.Runtime.Serialization.IDataNode.set_IsFinalValue(bool value) { }

}

