namespace System.Runtime.Remoting;

[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x10

	public Type ObjectType
	{
		 get { } //Length: 11
	}

	public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }

	public Type get_ObjectType() { }

	public virtual string ToString() { }

}

