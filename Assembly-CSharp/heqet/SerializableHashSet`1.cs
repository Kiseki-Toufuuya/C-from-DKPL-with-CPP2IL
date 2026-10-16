namespace Heqet;

public class SerializableHashSet : HashSet<TKey>, ISerializationCallbackReceiver
{
	[SerializeField]
	private TKey[] _keys; //Field offset: 0x0

	public SerializableHashSet`1() { }

	public SerializableHashSet`1(ISet<TKey> set) { }

	public void MoveFrom(ref List<TKey>& keys) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

