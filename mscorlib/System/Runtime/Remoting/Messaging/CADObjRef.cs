namespace System.Runtime.Remoting.Messaging;

internal class CADObjRef
{
	internal ObjRef objref; //Field offset: 0x8
	internal int SourceDomain; //Field offset: 0xC
	internal Byte[] TypeInfo; //Field offset: 0x10

	public CADObjRef(ObjRef o, int sourceDomain) { }

}

