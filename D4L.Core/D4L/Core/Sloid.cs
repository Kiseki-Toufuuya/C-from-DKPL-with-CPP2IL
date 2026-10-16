namespace D4L.Core;

[IsReadOnly]
public struct Sloid : IEquatable<Sloid>
{
	public readonly long Id; //Field offset: 0x0

	public Sloid(long id) { }

	public override bool Equals(Sloid other) { }

	public virtual bool Equals(object obj) { }

	public static Sloid Generate(long timestampLeft, ushort roundRobin, ushort workerId, ushort sequence) { }

	public virtual int GetHashCode() { }

	public static bool IsGeneratable(long timestampLeft, ushort roundRobin, ushort workerId, ushort sequence) { }

}

