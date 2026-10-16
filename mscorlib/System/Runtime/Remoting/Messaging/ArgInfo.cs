namespace System.Runtime.Remoting.Messaging;

internal class ArgInfo
{
	private Int32[] _paramMap; //Field offset: 0x8
	private int _inoutArgCount; //Field offset: 0xC
	private MethodBase _method; //Field offset: 0x10

	public ArgInfo(MethodBase method, ArgInfoType type) { }

	public Object[] GetInOutArgs(Object[] args) { }

}

