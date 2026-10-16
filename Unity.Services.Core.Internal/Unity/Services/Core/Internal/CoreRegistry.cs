namespace Unity.Services.Core.Internal;

public sealed class CoreRegistry
{
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; //Field offset: 0x1C

	[NotNull]
	internal IComponentRegistry ComponentRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public internal static CoreRegistry Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		internal set { } //Length: 64
	}

	internal InitializationOptions Options
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	[NotNull]
	internal IPackageRegistry PackageRegistry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	[NotNull]
	private IServiceRegistry ServiceRegistry
	{
		[CompilerGenerated]
		private set { } //Length: 27
	}

	internal ServicesType Type
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal CoreRegistry(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId = null) { }

	[CompilerGenerated]
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	internal ServicesType get_Type() { }

	public TComponent GetServiceComponent() { }

	internal void LockComponentRegistration() { }

	public CoreRegistration RegisterPackage(TPackage package) { }

	public void RegisterServiceComponent(TComponent component) { }

	[CompilerGenerated]
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	private void set_ServiceRegistry(IServiceRegistry value) { }

	[CompilerGenerated]
	private void set_Type(ServicesType value) { }

}

