namespace System.Runtime.Remoting;

[ComVisible(True)]
public class TypeEntry
{
	private string assembly_name; //Field offset: 0x8
	private string type_name; //Field offset: 0xC

	public string AssemblyName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string TypeName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected TypeEntry() { }

	public string get_AssemblyName() { }

	public string get_TypeName() { }

	public void set_AssemblyName(string value) { }

	public void set_TypeName(string value) { }

}

