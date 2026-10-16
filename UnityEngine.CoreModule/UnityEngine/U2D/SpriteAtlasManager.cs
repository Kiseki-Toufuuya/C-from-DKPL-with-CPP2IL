namespace UnityEngine.U2D;

[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType::Dot (0))]
public class SpriteAtlasManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String, Action`1<SpriteAtlas>> atlasRequested; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<SpriteAtlas> atlasRegistered; //Field offset: 0x4

	public static event Action<SpriteAtlas> atlasRegistered
	{
		[CompilerGenerated]
		 add { } //Length: 156
		[CompilerGenerated]
		 remove { } //Length: 156
	}

	public static event Action<String, Action`1<SpriteAtlas>> atlasRequested
	{
		[CompilerGenerated]
		 add { } //Length: 144
		[CompilerGenerated]
		 remove { } //Length: 144
	}

	[CompilerGenerated]
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	public static void add_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[RequiredByNativeCode]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	internal static void Register(SpriteAtlas spriteAtlas) { }

	private static void Register_Injected(IntPtr spriteAtlas) { }

	[CompilerGenerated]
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	public static void remove_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[RequiredByNativeCode]
	private static bool RequestAtlas(string tag) { }

}

