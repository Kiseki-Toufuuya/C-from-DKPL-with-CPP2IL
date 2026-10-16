namespace System.Runtime.Serialization;

internal sealed class MemberHolder
{
	internal readonly Type _memberType; //Field offset: 0x8
	internal readonly StreamingContext _context; //Field offset: 0xC

	internal MemberHolder(Type type, StreamingContext ctx) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

