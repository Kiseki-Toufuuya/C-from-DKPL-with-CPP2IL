namespace Heqet;

public class SerializableDictionary : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	[SerializeField]
	private TKey[] _keys; //Field offset: 0x0
	[SerializeField]
	private TValue[] _values; //Field offset: 0x0

	public SerializableDictionary`2() { }

	public SerializableDictionary`2(IDictionary<TKey, TValue> dictionary) { }

	public void CopyTo(out List<TKey>& keys, out List<TValue>& values) { }

	public void MoveFrom(ref List<TKey>& keys, ref List<TValue>& values) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

