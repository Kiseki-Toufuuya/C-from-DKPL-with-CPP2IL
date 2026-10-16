namespace System.Xml.Schema;

internal class AxisStack
{
	private ArrayList _stack; //Field offset: 0x8
	private ForwardAxis _subtree; //Field offset: 0xC
	private ActiveAxis _parent; //Field offset: 0x10

	internal int Length
	{
		internal get { } //Length: 40
	}

	internal ForwardAxis Subtree
	{
		internal get { } //Length: 11
	}

	public AxisStack(ForwardAxis faxis, ActiveAxis parent) { }

	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	internal int get_Length() { }

	internal ForwardAxis get_Subtree() { }

	internal bool MoveToAttribute(string name, string URN, int depth) { }

	internal bool MoveToChild(string name, string URN, int depth) { }

	internal void MoveToParent(string name, string URN, int depth) { }

	internal void Pop() { }

	internal void Push(int depth) { }

}

