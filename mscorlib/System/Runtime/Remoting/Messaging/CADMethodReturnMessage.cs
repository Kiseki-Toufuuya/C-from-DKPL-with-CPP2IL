namespace System.Runtime.Remoting.Messaging;

internal class CADMethodReturnMessage : CADMessageBase
{
	private object _returnValue; //Field offset: 0x1C
	private CADArgHolder _exception; //Field offset: 0x20
	private Type[] _sig; //Field offset: 0x24

	internal int PropertiesCount
	{
		internal get { } //Length: 11
	}

	internal CADMethodReturnMessage(IMethodReturnMessage retMsg) { }

	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	internal int get_PropertiesCount() { }

	internal Object[] GetArgs(ArrayList args) { }

	internal ArrayList GetArguments() { }

	internal Exception GetException(ArrayList args) { }

	internal object GetReturnValue(ArrayList args) { }

}

