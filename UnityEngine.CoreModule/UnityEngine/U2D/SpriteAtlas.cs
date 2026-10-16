namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : object
{

	public int spriteCount
	{
		 get { } //Length: 98
	}

	public SpriteAtlas() { }

	public bool CanBindTo(Sprite sprite) { }

	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

	public int get_spriteCount() { }

	private static int get_spriteCount_Injected(IntPtr _unity_self) { }

	public Sprite GetSprite(string name) { }

	private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public int GetSprites(Sprite[] sprites) { }

	private int GetSpritesScripting(Sprite[] sprites) { }

	private static int GetSpritesScripting_Injected(IntPtr _unity_self, Sprite[] sprites) { }

}

