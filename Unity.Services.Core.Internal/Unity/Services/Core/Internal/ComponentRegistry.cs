namespace Unity.Services.Core.Internal;

internal class ComponentRegistry : IComponentRegistry
{
	[CompilerGenerated]
	private readonly Dictionary<Int32, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; //Field offset: 0x8

	[NotNull]
	internal Dictionary<Int32, IServiceComponent> ComponentTypeHashToInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public ComponentRegistry() { }

	[CompilerGenerated]
	internal Dictionary<Int32, IServiceComponent> get_ComponentTypeHashToInstance() { }

	public override TComponent GetServiceComponent() { }

	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	public override void RegisterServiceComponent(TComponent component) { }

	public override void ResetProvidedComponents(IDictionary<Int32, IServiceComponent> componentTypeHashToInstance) { }

}

