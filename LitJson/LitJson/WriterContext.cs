namespace LitJson;

internal class WriterContext
{
	public int Count; //Field offset: 0x8
	public bool InArray; //Field offset: 0xC
	public bool InObject; //Field offset: 0xD
	public bool ExpectingValue; //Field offset: 0xE
	public int Padding; //Field offset: 0x10

	public WriterContext() { }

}

