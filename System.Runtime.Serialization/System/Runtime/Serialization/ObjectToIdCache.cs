namespace System.Runtime.Serialization;

internal class ObjectToIdCache
{
	internal static readonly Int32[] primes; //Field offset: 0x0
	internal int m_currentCount; //Field offset: 0x8
	internal Int32[] m_ids; //Field offset: 0xC
	internal Object[] m_objs; //Field offset: 0x10
	private Boolean[] m_isWrapped; //Field offset: 0x14

	private static ObjectToIdCache() { }

	public ObjectToIdCache() { }

	private int ComputeStartPosition(object o) { }

	private int FindElement(object obj, out bool isEmpty, out bool isWrapped) { }

	public int GetId(object obj, ref bool newId) { }

	private static int GetPrime(int min) { }

	private static bool IsPrime(int candidate) { }

	public int ReassignId(int oldObjId, object oldObj, object newObj) { }

	private void Rehash() { }

	private void RemoveAt(int position) { }

}

