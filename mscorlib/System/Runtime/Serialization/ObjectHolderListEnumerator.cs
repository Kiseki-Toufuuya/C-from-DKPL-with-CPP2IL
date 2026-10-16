namespace System.Runtime.Serialization;

internal class ObjectHolderListEnumerator
{
	private bool m_isFixupEnumerator; //Field offset: 0x8
	private ObjectHolderList m_list; //Field offset: 0xC
	private int m_startingVersion; //Field offset: 0x10
	private int m_currPos; //Field offset: 0x14

	internal ObjectHolder Current
	{
		internal get { } //Length: 43
	}

	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator) { }

	internal ObjectHolder get_Current() { }

	internal bool MoveNext() { }

}

