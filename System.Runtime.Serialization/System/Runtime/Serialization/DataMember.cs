namespace System.Runtime.Serialization;

internal class DataMember
{
	private class CriticalHelper
	{
		private DataContract memberTypeContract; //Field offset: 0x8
		private string name; //Field offset: 0xC
		private int order; //Field offset: 0x10
		private bool isRequired; //Field offset: 0x14
		private bool emitDefaultValue; //Field offset: 0x15
		private bool isNullable; //Field offset: 0x16
		private bool isGetOnlyCollection; //Field offset: 0x17
		private MemberInfo memberInfo; //Field offset: 0x18
		private bool hasConflictingNameAndType; //Field offset: 0x1C
		private DataMember conflictingMember; //Field offset: 0x20

		internal DataMember ConflictingMember
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal bool EmitDefaultValue
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool HasConflictingNameAndType
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsGetOnlyCollection
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsNullable
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal bool IsRequired
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal MemberInfo MemberInfo
		{
			internal get { } //Length: 11
		}

		internal Type MemberType
		{
			internal get { } //Length: 237
		}

		internal DataContract MemberTypeContract
		{
			internal get { } //Length: 200
			internal set { } //Length: 27
		}

		internal string Name
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal int Order
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal CriticalHelper() { }

		internal CriticalHelper(MemberInfo memberInfo) { }

		internal CriticalHelper(string name) { }

		internal CriticalHelper(DataContract memberTypeContract, string name, bool isNullable, bool isRequired, bool emitDefaultValue, int order) { }

		internal DataMember get_ConflictingMember() { }

		internal bool get_EmitDefaultValue() { }

		internal bool get_HasConflictingNameAndType() { }

		internal bool get_IsGetOnlyCollection() { }

		internal bool get_IsNullable() { }

		internal bool get_IsRequired() { }

		internal MemberInfo get_MemberInfo() { }

		internal Type get_MemberType() { }

		internal DataContract get_MemberTypeContract() { }

		internal string get_Name() { }

		internal int get_Order() { }

		internal void set_ConflictingMember(DataMember value) { }

		internal void set_EmitDefaultValue(bool value) { }

		internal void set_HasConflictingNameAndType(bool value) { }

		internal void set_IsGetOnlyCollection(bool value) { }

		internal void set_IsNullable(bool value) { }

		internal void set_IsRequired(bool value) { }

		internal void set_MemberTypeContract(DataContract value) { }

		internal void set_Name(string value) { }

		internal void set_Order(int value) { }

	}

	private CriticalHelper helper; //Field offset: 0x8

	internal DataMember ConflictingMember
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal bool EmitDefaultValue
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool HasConflictingNameAndType
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsGetOnlyCollection
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsNullable
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal bool IsRequired
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal MemberInfo MemberInfo
	{
		internal get { } //Length: 23
	}

	internal Type MemberType
	{
		internal get { } //Length: 34
	}

	internal DataContract MemberTypeContract
	{
		internal get { } //Length: 219
		internal set { } //Length: 39
	}

	internal string Name
	{
		internal get { } //Length: 23
		internal set { } //Length: 39
	}

	internal int Order
	{
		internal get { } //Length: 23
		internal set { } //Length: 26
	}

	internal DataMember() { }

	internal DataMember(MemberInfo memberInfo) { }

	internal DataMember(string name) { }

	internal DataMember(DataContract memberTypeContract, string name, bool isNullable, bool isRequired, bool emitDefaultValue, int order) { }

	internal DataMember BindGenericParameters(DataContract[] paramContracts, Dictionary<DataContract, DataContract> boundContracts) { }

	internal bool Equals(object other, Dictionary<DataContractPairKey, Object> checkedContracts) { }

	internal DataMember get_ConflictingMember() { }

	internal bool get_EmitDefaultValue() { }

	internal bool get_HasConflictingNameAndType() { }

	internal bool get_IsGetOnlyCollection() { }

	internal bool get_IsNullable() { }

	internal bool get_IsRequired() { }

	internal MemberInfo get_MemberInfo() { }

	internal Type get_MemberType() { }

	internal DataContract get_MemberTypeContract() { }

	internal string get_Name() { }

	internal int get_Order() { }

	public virtual int GetHashCode() { }

	internal void set_ConflictingMember(DataMember value) { }

	internal void set_EmitDefaultValue(bool value) { }

	internal void set_HasConflictingNameAndType(bool value) { }

	internal void set_IsGetOnlyCollection(bool value) { }

	internal void set_IsNullable(bool value) { }

	internal void set_IsRequired(bool value) { }

	internal void set_MemberTypeContract(DataContract value) { }

	internal void set_Name(string value) { }

	internal void set_Order(int value) { }

}

