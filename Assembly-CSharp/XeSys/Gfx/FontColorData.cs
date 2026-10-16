namespace XeSys.Gfx;

public class FontColorData
{
	internal enum TextType
	{
		Text = 0,
		BetterOutline = 1,
		Bevel = 2,
		DepthEffect = 3,
		GradientColor = 4,
		SoftShadow = 5,
		ToJOutline = 6,
		ToJShadow = 7,
		num = 8,
	}

	private static Dictionary<Type, TextType> TypeToTextTypeDic; //Field offset: 0x0
	[SerializeField]
	public TextType textType; //Field offset: 0x8
	[SerializeField]
	public Color[] FontColors; //Field offset: 0xC

	private static FontColorData() { }

	public FontColorData() { }

	public static TextType GetTextTypeByComponent(Component component) { }

}

