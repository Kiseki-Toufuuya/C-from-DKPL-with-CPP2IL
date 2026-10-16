namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodCall
{
	private string methodName; //Field offset: 0x8
	private string typeName; //Field offset: 0xC
	private Object[] args; //Field offset: 0x10
	private object callContext; //Field offset: 0x14
	private Type[] argTypes; //Field offset: 0x18
	private bool bArgsPrimitive; //Field offset: 0x1C
	private MessageEnum messageEnum; //Field offset: 0x20

	public BinaryMethodCall() { }

	internal void Dump() { }

	internal void Write(__BinaryWriter sout) { }

}

