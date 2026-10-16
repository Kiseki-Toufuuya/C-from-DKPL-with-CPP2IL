namespace System.Runtime.Serialization;

[AttributeUsage(3, Inherited = False, AllowMultiple = True)]
public sealed class ContractNamespaceAttribute : Attribute
{
	private string clrNamespace; //Field offset: 0x8
	private string contractNamespace; //Field offset: 0xC

	public string ClrNamespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string ContractNamespace
	{
		 get { } //Length: 11
	}

	public ContractNamespaceAttribute(string contractNamespace) { }

	public string get_ClrNamespace() { }

	public string get_ContractNamespace() { }

	public void set_ClrNamespace(string value) { }

}

