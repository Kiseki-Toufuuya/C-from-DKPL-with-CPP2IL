namespace UnityEngine.Localization.Tables;

public struct TableEntryReference : ISerializationCallbackReceiver, IEquatable<TableEntryReference>
{
	internal enum Type
	{
		Empty = 0,
		Name = 1,
		Id = 2,
	}

	[SerializeField]
	private long m_KeyId; //Field offset: 0x0
	[SerializeField]
	private string m_Key; //Field offset: 0x8
	private bool m_Valid; //Field offset: 0xC
	[CompilerGenerated]
	private Type <ReferenceType>k__BackingField; //Field offset: 0x10

	public private string Key
	{
		 get { } //Length: 11
		private set { } //Length: 27
	}

	public private long KeyId
	{
		 get { } //Length: 13
		private set { } //Length: 19
	}

	public private Type ReferenceType
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public override bool Equals(TableEntryReference other) { }

	public virtual bool Equals(object obj) { }

	public string get_Key() { }

	public long get_KeyId() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Type get_ReferenceType() { }

	public virtual int GetHashCode() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public static TableEntryReference op_Implicit(long keyId) { }

	public static string op_Implicit(TableEntryReference tableEntryReference) { }

	public static TableEntryReference op_Implicit(string key) { }

	public static long op_Implicit(TableEntryReference tableEntryReference) { }

	public string ResolveKeyName(SharedTableData sharedData) { }

	private void set_Key(string value) { }

	private void set_KeyId(long value) { }

	[CompilerGenerated]
	private void set_ReferenceType(Type value) { }

	public virtual string ToString() { }

	public string ToString(TableReference tableReference) { }

	internal void Validate() { }

}

