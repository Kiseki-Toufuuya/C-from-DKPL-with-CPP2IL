namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase
{
	[DefaultMember("Item")]
	public sealed class DataSetRelationCollection : DataRelationCollection
	{
		private readonly DataSet _dataSet; //Field offset: 0x1C
		private readonly ArrayList _relations; //Field offset: 0x20
		private DataRelation[] _delayLoadingRelations; //Field offset: 0x24

		public virtual DataRelation Item
		{
			 get { } //Length: 225
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 211
		}

		protected virtual ArrayList List
		{
			 get { } //Length: 11
		}

		internal DataSetRelationCollection(DataSet dataSet) { }

		protected virtual void AddCore(DataRelation relation) { }

		public virtual void Clear() { }

		public virtual DataRelation get_Item(int index) { }

		public virtual DataRelation get_Item(string name) { }

		protected virtual ArrayList get_List() { }

		protected virtual DataSet GetDataSet() { }

		protected virtual void RemoveCore(DataRelation relation) { }

	}

	[DefaultMember("Item")]
	public sealed class DataTableRelationCollection : DataRelationCollection
	{
		private readonly DataTable _table; //Field offset: 0x1C
		private readonly ArrayList _relations; //Field offset: 0x20
		private readonly bool _fParentCollection; //Field offset: 0x24
		[CompilerGenerated]
		private CollectionChangeEventHandler RelationPropertyChanged; //Field offset: 0x28

		internal event CollectionChangeEventHandler RelationPropertyChanged
		{
			[CompilerGenerated]
			internal add { } //Length: 116
			[CompilerGenerated]
			internal remove { } //Length: 116
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 225
		}

		public virtual DataRelation Item
		{
			 get { } //Length: 211
		}

		protected virtual ArrayList List
		{
			 get { } //Length: 11
		}

		internal DataTableRelationCollection(DataTable table, bool fParentCollection) { }

		[CompilerGenerated]
		internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		private void AddCache(DataRelation relation) { }

		protected virtual void AddCore(DataRelation relation) { }

		private void EnsureDataSet() { }

		public virtual DataRelation get_Item(int index) { }

		public virtual DataRelation get_Item(string name) { }

		protected virtual ArrayList get_List() { }

		protected virtual DataSet GetDataSet() { }

		[CompilerGenerated]
		internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

		private void RemoveCache(DataRelation relation) { }

		protected virtual void RemoveCore(DataRelation relation) { }

	}

	private static int s_objectTypeCount; //Field offset: 0x0
	private DataRelation _inTransition; //Field offset: 0x8
	private int _defaultNameIndex; //Field offset: 0xC
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x10
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x14
	private readonly int _objectID; //Field offset: 0x18

	public event CollectionChangeEventHandler CollectionChanged
	{
		 add { } //Length: 225
		 remove { } //Length: 225
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	public abstract DataRelation Item
	{
		 get { } //Length: 0
	}

	internal int ObjectID
	{
		internal get { } //Length: 11
	}

	protected DataRelationCollection() { }

	public void Add(DataRelation relation) { }

	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	protected override void AddCore(DataRelation relation) { }

	internal string AssignName() { }

	public override void Clear() { }

	public override bool Contains(string name) { }

	public abstract DataRelation get_Item(int index) { }

	public abstract DataRelation get_Item(string name) { }

	internal int get_ObjectID() { }

	protected abstract DataSet GetDataSet() { }

	internal int InternalIndexOf(string name) { }

	private string MakeName(int index) { }

	protected override void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	protected override void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void RegisterName(string name) { }

	public void Remove(DataRelation relation) { }

	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	public void RemoveAt(int index) { }

	protected override void RemoveCore(DataRelation relation) { }

	internal void UnregisterName(string name) { }

}

