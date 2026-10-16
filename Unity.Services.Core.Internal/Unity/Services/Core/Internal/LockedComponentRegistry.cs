namespace Unity.Services.Core.Internal;

internal class LockedComponentRegistry : IComponentRegistry
{
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; //Field offset: 0x8

	[NotNull]
	internal IComponentRegistry Registry
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public LockedComponentRegistry(IComponentRegistry registryToLock) { }

	[CompilerGenerated]
	internal IComponentRegistry get_Registry() { }

	public override TComponent GetServiceComponent() { }

	public override void RegisterServiceComponent(TComponent component) { }

	public override void ResetProvidedComponents(IDictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

}

