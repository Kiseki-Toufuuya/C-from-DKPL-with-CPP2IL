namespace System.ComponentModel;

[DefaultMember("Item")]
public sealed class EventHandlerList
{
	private sealed class ListEntry
	{
		internal ListEntry _next; //Field offset: 0x8
		internal object _key; //Field offset: 0xC
		internal Delegate _handler; //Field offset: 0x10

	}

	private ListEntry _head; //Field offset: 0x8
	private Component _parent; //Field offset: 0xC

	public Delegate Item
	{
		 get { } //Length: 63
	}

	private ListEntry Find(object key) { }

	public Delegate get_Item(object key) { }

}

