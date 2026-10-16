namespace System.Data;

internal sealed class OperatorInfo
{
	internal Nodes _type; //Field offset: 0x8
	internal int _op; //Field offset: 0xC
	internal int _priority; //Field offset: 0x10

	internal OperatorInfo(Nodes type, int op, int pri) { }

}

