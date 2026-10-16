namespace System.Runtime.Serialization;

internal interface IDataNode
{

	public string ClrAssemblyName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string ClrTypeName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string DataContractName
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string DataContractNamespace
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Type DataType
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsFinalValue
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool PreservesReferences
	{
		 get { } //Length: 0
	}

	public object Value
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Clear() { }

	public string get_ClrAssemblyName() { }

	public string get_ClrTypeName() { }

	public string get_DataContractName() { }

	public string get_DataContractNamespace() { }

	public Type get_DataType() { }

	public string get_Id() { }

	public bool get_IsFinalValue() { }

	public bool get_PreservesReferences() { }

	public object get_Value() { }

	public void GetData(ElementData element) { }

	public void set_ClrAssemblyName(string value) { }

	public void set_ClrTypeName(string value) { }

	public void set_DataContractName(string value) { }

	public void set_DataContractNamespace(string value) { }

	public void set_Id(string value) { }

	public void set_IsFinalValue(bool value) { }

	public void set_Value(object value) { }

}

