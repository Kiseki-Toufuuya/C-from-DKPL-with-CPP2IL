namespace System.Runtime.Serialization;

internal class HybridObjectCache
{
	private Dictionary<String, Object> objectDictionary; //Field offset: 0x8
	private Dictionary<String, Object> referencedObjectDictionary; //Field offset: 0xC

	internal HybridObjectCache() { }

	internal void Add(string id, object obj) { }

	internal object GetObject(string id) { }

	internal bool IsObjectReferenced(string id) { }

	internal void Remove(string id) { }

}

