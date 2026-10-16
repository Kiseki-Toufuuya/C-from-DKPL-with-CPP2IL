namespace Unity.Services.Core.Internal;

public sealed class CorePackageRegistry
{
	[CompilerGenerated]
	private static CorePackageRegistry <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IPackageRegistry <Registry>k__BackingField; //Field offset: 0x8

	public internal static CorePackageRegistry Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		internal set { } //Length: 64
	}

	internal IPackageRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	internal CorePackageRegistry() { }

	[CompilerGenerated]
	public static CorePackageRegistry get_Instance() { }

	[CompilerGenerated]
	internal IPackageRegistry get_Registry() { }

	internal void Lock() { }

	public CoreRegistration Register(TPackage package) { }

	[CompilerGenerated]
	internal static void set_Instance(CorePackageRegistry value) { }

	[CompilerGenerated]
	internal void set_Registry(IPackageRegistry value) { }

}

