namespace UnityEngine.Localization.Tables;

public struct TableReference : ISerializationCallbackReceiver, IEquatable<TableReference>
{
	internal enum Type
	{
		Empty = 0,
		Guid = 1,
		Name = 2,
	}

	private static readonly Dictionary<Guid, String> s_GuidToStringCache; //Field offset: 0x0
	private const string k_GuidTag = "GUID:"; //Field offset: 0x0
	private static readonly Dictionary<String, Guid> s_StringToGuidCache; //Field offset: 0x4
	[FormerlySerializedAs("m_TableName")]
	[SerializeField]
	private string m_TableCollectionName; //Field offset: 0x0
	private bool m_Valid; //Field offset: 0x4
	[CompilerGenerated]
	private Type <ReferenceType>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Guid <TableCollectionNameGuid>k__BackingField; //Field offset: 0xC

	public private Type ReferenceType
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal SharedTableData SharedTableData
	{
		internal get { } //Length: 1272
	}

	public private string TableCollectionName
	{
		 get { } //Length: 113
		private set { } //Length: 23
	}

	public private Guid TableCollectionNameGuid
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 16
	}

	private static TableReference() { }

	public override bool Equals(TableReference other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Type get_ReferenceType() { }

	internal SharedTableData get_SharedTableData() { }

	public string get_TableCollectionName() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Guid get_TableCollectionNameGuid() { }

	public virtual int GetHashCode() { }

	internal string GetSerializedString() { }

	internal static Guid GuidFromString(string value) { }

	internal static bool IsGuid(string value) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public static string op_Implicit(TableReference tableReference) { }

	public static Guid op_Implicit(TableReference tableReference) { }

	public static TableReference op_Implicit(string tableCollectionName) { }

	public static TableReference op_Implicit(Guid tableCollectionNameGuid) { }

	[CompilerGenerated]
	private void set_ReferenceType(Type value) { }

	private void set_TableCollectionName(string value) { }

	[CompilerGenerated]
	private void set_TableCollectionNameGuid(Guid value) { }

	internal static string StringFromGuid(Guid value) { }

	internal static TableReference TableReferenceFromString(string value) { }

	public virtual string ToString() { }

	internal void Validate() { }

}

