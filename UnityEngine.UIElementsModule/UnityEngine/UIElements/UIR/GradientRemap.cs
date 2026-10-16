namespace UnityEngine.UIElements.UIR;

internal class GradientRemap : LinkedPoolItem<GradientRemap>
{
	public int origIndex; //Field offset: 0xC
	public int destIndex; //Field offset: 0x10
	public RectInt location; //Field offset: 0x14
	public GradientRemap next; //Field offset: 0x24
	public TextureId atlas; //Field offset: 0x28

	public GradientRemap() { }

	public void Reset() { }

}

