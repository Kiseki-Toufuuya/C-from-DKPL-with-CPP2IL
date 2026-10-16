namespace System.Runtime.Remoting;

internal class TypeInfo : IRemotingTypeInfo
{
	private string serverType; //Field offset: 0x8
	private String[] serverHierarchy; //Field offset: 0xC
	private String[] interfacesImplemented; //Field offset: 0x10

	public override string TypeName
	{
		 get { } //Length: 11
	}

	public TypeInfo(Type type) { }

	public override bool CanCastTo(Type fromType, object o) { }

	public override string get_TypeName() { }

}

