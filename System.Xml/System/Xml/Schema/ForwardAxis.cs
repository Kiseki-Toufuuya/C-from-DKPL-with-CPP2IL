namespace System.Xml.Schema;

internal class ForwardAxis
{
	private DoubleLinkAxis _topNode; //Field offset: 0x8
	private DoubleLinkAxis _rootNode; //Field offset: 0xC
	private bool _isAttribute; //Field offset: 0x10
	private bool _isDss; //Field offset: 0x11
	private bool _isSelfAxis; //Field offset: 0x12

	internal bool IsAttribute
	{
		internal get { } //Length: 11
	}

	internal bool IsDss
	{
		internal get { } //Length: 11
	}

	internal bool IsSelfAxis
	{
		internal get { } //Length: 11
	}

	internal DoubleLinkAxis RootNode
	{
		internal get { } //Length: 11
	}

	internal DoubleLinkAxis TopNode
	{
		internal get { } //Length: 11
	}

	public ForwardAxis(DoubleLinkAxis axis, bool isdesorself) { }

	internal bool get_IsAttribute() { }

	internal bool get_IsDss() { }

	internal bool get_IsSelfAxis() { }

	internal DoubleLinkAxis get_RootNode() { }

	internal DoubleLinkAxis get_TopNode() { }

}

