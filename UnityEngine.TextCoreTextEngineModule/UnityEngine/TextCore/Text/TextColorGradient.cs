namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextColorGradient : ScriptableObject
{
	private const ColorGradientMode k_DefaultColorMode = 3; //Field offset: 0x0
	private static readonly Color k_DefaultColor; //Field offset: 0x0
	public ColorGradientMode colorMode; //Field offset: 0xC
	public Color topLeft; //Field offset: 0x10
	public Color topRight; //Field offset: 0x20
	public Color bottomLeft; //Field offset: 0x30
	public Color bottomRight; //Field offset: 0x40

	private static TextColorGradient() { }

	public TextColorGradient() { }

	public TextColorGradient(Color color) { }

	public TextColorGradient(Color color0, Color color1, Color color2, Color color3) { }

}

