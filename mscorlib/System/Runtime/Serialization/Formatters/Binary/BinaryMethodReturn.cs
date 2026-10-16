namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodReturn
{
	private static object instanceOfVoid; //Field offset: 0x0
	private object returnValue; //Field offset: 0x8
	private Object[] args; //Field offset: 0xC
	private object callContext; //Field offset: 0x10
	private Type[] argTypes; //Field offset: 0x14
	private bool bArgsPrimitive; //Field offset: 0x18
	private MessageEnum messageEnum; //Field offset: 0x1C
	private Type returnType; //Field offset: 0x20

	private static BinaryMethodReturn() { }

	internal BinaryMethodReturn() { }

	public void Dump() { }

	public override void Write(__BinaryWriter sout) { }

}

