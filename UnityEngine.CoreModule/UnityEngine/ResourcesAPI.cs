namespace UnityEngine;

public class ResourcesAPI
{
	private static ResourcesAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ResourcesAPI <overrideAPI>k__BackingField; //Field offset: 0x4

	internal static ResourcesAPI ActiveAPI
	{
		internal get { } //Length: 148
	}

	public static ResourcesAPI overrideAPI
	{
		[CompilerGenerated]
		 get { } //Length: 61
	}

	private static ResourcesAPI() { }

	protected private ResourcesAPI() { }

	protected private override Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	protected private override Shader FindShaderByName(string name) { }

	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	public static ResourcesAPI get_overrideAPI() { }

	protected private override object Load(string path, Type systemTypeInstance) { }

	protected private override void UnloadAsset(object assetToUnload) { }

}

