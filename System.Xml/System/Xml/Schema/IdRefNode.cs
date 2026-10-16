namespace System.Xml.Schema;

internal class IdRefNode
{
	internal string Id; //Field offset: 0x8
	internal int LineNo; //Field offset: 0xC
	internal int LinePos; //Field offset: 0x10
	internal IdRefNode Next; //Field offset: 0x14

	internal IdRefNode(IdRefNode next, string id, int lineNo, int linePos) { }

}

