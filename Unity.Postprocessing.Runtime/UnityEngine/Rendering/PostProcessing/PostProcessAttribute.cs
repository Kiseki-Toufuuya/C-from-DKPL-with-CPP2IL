namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
public sealed class PostProcessAttribute : Attribute
{
	public readonly Type renderer; //Field offset: 0x8
	public readonly PostProcessEvent eventType; //Field offset: 0xC
	public readonly string menuItem; //Field offset: 0x10
	public readonly bool allowInSceneView; //Field offset: 0x14
	internal readonly bool builtinEffect; //Field offset: 0x15

	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true) { }

	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true) { }

}

