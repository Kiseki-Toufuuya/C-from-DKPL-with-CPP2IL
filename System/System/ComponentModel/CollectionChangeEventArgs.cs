namespace System.ComponentModel;

public class CollectionChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; //Field offset: 0xC

	public override CollectionChangeAction Action
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override object Element
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public CollectionChangeEventArgs(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	public override CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	public override object get_Element() { }

}

