namespace Google.Protobuf;

public sealed class UnknownFieldSet
{
	private readonly IDictionary<Int32, UnknownField> fields; //Field offset: 0x8
	private int lastFieldNumber; //Field offset: 0xC
	private UnknownField lastField; //Field offset: 0x10

	internal UnknownFieldSet() { }

	internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field) { }

	public int CalculateSize() { }

	public static UnknownFieldSet Clone(UnknownFieldSet other) { }

	public virtual bool Equals(object other) { }

	public virtual int GetHashCode() { }

	private UnknownField GetOrAddField(int number) { }

	internal bool HasField(int field) { }

	private UnknownFieldSet MergeField(int number, UnknownField field) { }

	private bool MergeFieldFrom(CodedInputStream input) { }

	public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input) { }

	private UnknownFieldSet MergeFrom(UnknownFieldSet other) { }

	public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other) { }

	public void WriteTo(CodedOutputStream output) { }

}

