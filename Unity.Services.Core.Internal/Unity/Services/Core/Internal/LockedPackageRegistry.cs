namespace Unity.Services.Core.Internal;

internal class LockedPackageRegistry : IPackageRegistry
{
	[CompilerGenerated]
	private readonly IPackageRegistry <Registry>k__BackingField; //Field offset: 0x8

	[NotNull]
	internal IPackageRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public override DependencyTree Tree
	{
		 get { } //Length: 66
	}

	public LockedPackageRegistry(IPackageRegistry registryToLock) { }

	[CompilerGenerated]
	internal IPackageRegistry get_Registry() { }

	public override DependencyTree get_Tree() { }

	public override void RegisterDependency(int packageTypeHash) { }

	public override void RegisterOptionalDependency(int packageTypeHash) { }

	public override CoreRegistration RegisterPackage(TPackage package) { }

	public override void RegisterProvision(int packageTypeHash) { }

}

