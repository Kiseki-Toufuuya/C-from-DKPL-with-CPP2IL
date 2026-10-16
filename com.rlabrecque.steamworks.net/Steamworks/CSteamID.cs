namespace Steamworks;

public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
{
	public static readonly CSteamID Nil; //Field offset: 0x0
	public static readonly CSteamID OutofDateGS; //Field offset: 0x8
	public static readonly CSteamID LanModeGS; //Field offset: 0x10
	public static readonly CSteamID NotInitYetGS; //Field offset: 0x18
	public static readonly CSteamID NonSteamGS; //Field offset: 0x20
	public ulong m_SteamID; //Field offset: 0x0

	private static CSteamID() { }

	public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	public CSteamID(ulong ulSteamID) { }

	public override int CompareTo(CSteamID other) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(CSteamID other) { }

	public virtual int GetHashCode() { }

	public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) { }

	public static bool op_Equality(CSteamID x, CSteamID y) { }

	public static CSteamID op_Explicit(ulong value) { }

	public void SetAccountID(AccountID_t other) { }

	public void SetAccountInstance(uint other) { }

	public void SetEAccountType(EAccountType other) { }

	public void SetEUniverse(EUniverse other) { }

	public virtual string ToString() { }

}

