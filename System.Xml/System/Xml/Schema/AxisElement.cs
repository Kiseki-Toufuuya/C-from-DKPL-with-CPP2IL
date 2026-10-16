namespace System.Xml.Schema;

internal class AxisElement
{
	internal DoubleLinkAxis curNode; //Field offset: 0x8
	internal int rootDepth; //Field offset: 0xC
	internal int curDepth; //Field offset: 0x10
	internal bool isMatch; //Field offset: 0x14

	internal DoubleLinkAxis CurNode
	{
		internal get { } //Length: 11
	}

	internal AxisElement(DoubleLinkAxis node, int depth) { }

	internal DoubleLinkAxis get_CurNode() { }

	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

	internal void MoveToParent(int depth, ForwardAxis parent) { }

	internal void SetDepth(int depth) { }

}

