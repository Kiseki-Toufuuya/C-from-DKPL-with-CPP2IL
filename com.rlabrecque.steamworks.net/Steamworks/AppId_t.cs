namespace Steamworks;

public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
{
	public static readonly AppId_t Invalid; //Field offset: 0x0
	public uint m_AppId; //Field offset: 0x0

	private static AppId_t() { }

	public AppId_t(uint value) { }

	public override int CompareTo(AppId_t other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(AppId_t other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AppId_t x, AppId_t y) { }

	public static AppId_t op_Explicit(uint value) { }

	public virtual string ToString() { }

}

