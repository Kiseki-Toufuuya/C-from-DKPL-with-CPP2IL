namespace System.Xml;

internal class ByteStack
{
	private Byte[] stack; //Field offset: 0x8
	private int growthRate; //Field offset: 0xC
	private int top; //Field offset: 0x10
	private int size; //Field offset: 0x14

	public ByteStack(int growthRate) { }

	public byte Pop() { }

	public void Push(byte data) { }

}

