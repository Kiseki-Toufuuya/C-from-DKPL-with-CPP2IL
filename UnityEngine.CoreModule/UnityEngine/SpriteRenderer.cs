namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; //Field offset: 0xC

	public Color color
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public Sprite sprite
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public SpriteRenderer() { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public Sprite get_sprite() { }

	private static IntPtr get_sprite_Injected(IntPtr _unity_self) { }

	[RequiredByNativeCode]
	private void InvokeSpriteChanged() { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_sprite(Sprite value) { }

	private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value) { }

}

