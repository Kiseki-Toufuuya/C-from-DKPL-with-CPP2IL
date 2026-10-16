namespace System.Reflection;

[ComVisible(True)]
public class LocalVariableInfo
{
	internal Type type; //Field offset: 0x8
	internal bool is_pinned; //Field offset: 0xC
	internal ushort position; //Field offset: 0xE

	protected LocalVariableInfo() { }

	public virtual string ToString() { }

}

