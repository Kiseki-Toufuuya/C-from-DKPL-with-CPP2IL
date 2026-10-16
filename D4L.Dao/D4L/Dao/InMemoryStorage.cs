namespace D4L.Dao;

public class InMemoryStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Byte[]>, String> <>9__7_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <ToBytes>b__7_0(KeyValuePair<String, Byte[]> pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public FlatBufferBuilder builder; //Field offset: 0x8

		public <>c__DisplayClass7_0() { }

		internal Offset<SerializedStorageEntry> <ToBytes>b__1(KeyValuePair<String, Byte[]> pair) { }

	}

	private object lock; //Field offset: 0x8
	private Dictionary<String, Byte[]> store; //Field offset: 0xC

	public InMemoryStorage() { }

	public InMemoryStorage(Byte[] serializedStorageBuffer) { }

	public Byte[] ToBytes() { }

}

