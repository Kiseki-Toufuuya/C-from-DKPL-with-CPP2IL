namespace System.Reflection.Emit;

public sealed class LocalBuilder : LocalVariableInfo
{
	private string name; //Field offset: 0x10
	internal ILGenerator ilgen; //Field offset: 0x14
	private int startOffset; //Field offset: 0x18
	private int endOffset; //Field offset: 0x1C

}

