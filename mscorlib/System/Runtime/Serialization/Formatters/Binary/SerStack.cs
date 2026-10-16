namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerStack
{
	internal Object[] objects; //Field offset: 0x8
	internal string stackId; //Field offset: 0xC
	internal int top; //Field offset: 0x10

	internal SerStack(string stackId) { }

	internal void IncreaseCapacity() { }

	internal bool IsEmpty() { }

	internal object Peek() { }

	internal object PeekPeek() { }

	internal object Pop() { }

	internal void Push(object obj) { }

}

