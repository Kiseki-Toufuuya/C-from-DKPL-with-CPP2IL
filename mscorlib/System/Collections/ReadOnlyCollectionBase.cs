namespace System.Collections;

public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	private ArrayList _list; //Field offset: 0x8

	public override int Count
	{
		 get { } //Length: 116
	}

	protected ArrayList InnerList
	{
		 get { } //Length: 87
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 116
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 116
	}

	protected ReadOnlyCollectionBase() { }

	public override int get_Count() { }

	protected ArrayList get_InnerList() { }

	public override IEnumerator GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

}

