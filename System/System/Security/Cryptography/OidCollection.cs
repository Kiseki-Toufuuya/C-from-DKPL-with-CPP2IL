namespace System.Security.Cryptography;

[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable
{
	private readonly List<Oid> _list; //Field offset: 0x8

	public override int Count
	{
		 get { } //Length: 52
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public Oid Item
	{
		 get { } //Length: 67
	}

	public override object SyncRoot
	{
		 get { } //Length: 8
	}

	public OidCollection() { }

	public int Add(Oid oid) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public Oid get_Item(int index) { }

	public override object get_SyncRoot() { }

	public OidEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

