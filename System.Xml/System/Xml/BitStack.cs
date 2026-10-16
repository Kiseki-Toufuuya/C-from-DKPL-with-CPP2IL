namespace System.Xml;

internal class BitStack
{
	private UInt32[] bitStack; //Field offset: 0x8
	private int stackPos; //Field offset: 0xC
	private uint curr; //Field offset: 0x10

	public BitStack() { }

	public bool PeekBit() { }

	public bool PopBit() { }

	private void PopCurr() { }

	public void PushBit(bool bit) { }

	private void PushCurr() { }

}

