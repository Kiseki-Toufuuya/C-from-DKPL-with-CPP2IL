namespace System.Runtime.Serialization;

[AttributeUsage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute
{
	private string name; //Field offset: 0x8
	private string ns; //Field offset: 0xC
	private bool isNameSetExplicitly; //Field offset: 0x10
	private bool isNamespaceSetExplicitly; //Field offset: 0x11
	private bool isReference; //Field offset: 0x12
	private bool isReferenceSetExplicitly; //Field offset: 0x13

	public bool IsNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsNamespaceSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsReference
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public bool IsReferenceSetExplicitly
	{
		 get { } //Length: 11
	}

	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public DataContractAttribute() { }

	public bool get_IsNameSetExplicitly() { }

	public bool get_IsNamespaceSetExplicitly() { }

	public bool get_IsReference() { }

	public bool get_IsReferenceSetExplicitly() { }

	public string get_Name() { }

	public string get_Namespace() { }

	public void set_IsReference(bool value) { }

	public void set_Name(string value) { }

	public void set_Namespace(string value) { }

}

