namespace TMPro;

public class FastAction
{
	private LinkedList<Action> delegates; //Field offset: 0x8
	private Dictionary<Action, LinkedListNode`1<Action>> lookup; //Field offset: 0xC

	public FastAction() { }

	public void Add(Action rhs) { }

	public void Call() { }

	public void Remove(Action rhs) { }

}

