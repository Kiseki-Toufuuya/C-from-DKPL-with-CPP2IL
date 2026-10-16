namespace System.Xml;

public class XmlBinaryWriterSession
{
	[DefaultMember("Item")]
	private class IntArray
	{
		private Int32[] array; //Field offset: 0x8

		public int Item
		{
			 get { } //Length: 42
			 set { } //Length: 188
		}

		public IntArray(int size) { }

		public int get_Item(int index) { }

		public void set_Item(int index, int value) { }

	}

	private class PriorityDictionary
	{
		private struct Entry
		{
			public K Key; //Field offset: 0x0
			public V Value; //Field offset: 0x0
			public int Time; //Field offset: 0x0

		}

		private Dictionary<K, V> dictionary; //Field offset: 0x0
		private Entry<K, V>[] list; //Field offset: 0x0
		private int listCount; //Field offset: 0x0
		private int now; //Field offset: 0x0

		private int Now
		{
			private get { } //Length: 94
		}

		public PriorityDictionary`2() { }

		public void Add(K key, V value) { }

		public void Clear() { }

		private void DecreaseAll() { }

		private int get_Now() { }

		public bool TryGetValue(K key, out V value) { }

	}

	private PriorityDictionary<String, Int32> strings; //Field offset: 0x8
	private PriorityDictionary<IXmlDictionary, IntArray> maps; //Field offset: 0xC
	private int nextKey; //Field offset: 0x10

	public XmlBinaryWriterSession() { }

	private int Add(string s) { }

	private IntArray AddKeys(IXmlDictionary dictionary, int minCount) { }

	public void Reset() { }

	public override bool TryAdd(XmlDictionaryString value, out int key) { }

	internal bool TryLookup(XmlDictionaryString s, out int key) { }

}

