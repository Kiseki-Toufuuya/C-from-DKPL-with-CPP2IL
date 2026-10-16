namespace Live2D.Cubism.Core;

public sealed class CubismMoc : ScriptableObject
{
	[HideInInspector]
	[SerializeField]
	private Byte[] _bytes; //Field offset: 0xC
	[CompilerGenerated]
	private CubismUnmanagedMoc <UnmanagedMoc>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ReferenceCount>k__BackingField; //Field offset: 0x14

	private Byte[] Bytes
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	public bool IsRevived
	{
		 get { } //Length: 15
	}

	public static uint LatestVersion
	{
		 get { } //Length: 11
	}

	private int ReferenceCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private CubismUnmanagedMoc UnmanagedMoc
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public uint Version
	{
		 get { } //Length: 23
	}

	public CubismMoc() { }

	public CubismUnmanagedMoc AcquireUnmanagedMoc() { }

	public static CubismMoc CreateFrom(Byte[] moc3, bool shouldCheckMocConsistency = true) { }

	private Byte[] get_Bytes() { }

	public bool get_IsRevived() { }

	public static uint get_LatestVersion() { }

	[CompilerGenerated]
	private int get_ReferenceCount() { }

	[CompilerGenerated]
	private CubismUnmanagedMoc get_UnmanagedMoc() { }

	public uint get_Version() { }

	public static bool HasMocConsistency(Byte[] moc3) { }

	public void ReleaseUnmanagedMoc() { }

	public static void ResetUnmanagedMoc(CubismMoc moc) { }

	private void Revive() { }

	private void set_Bytes(Byte[] value) { }

	[CompilerGenerated]
	private void set_ReferenceCount(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedMoc(CubismUnmanagedMoc value) { }

}

