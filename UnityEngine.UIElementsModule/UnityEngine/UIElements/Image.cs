namespace UnityEngine.UIElements;

public class Image : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Image, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	internal static readonly BindingId imageProperty; //Field offset: 0x0
	internal static readonly BindingId spriteProperty; //Field offset: 0x4C
	internal static readonly BindingId vectorImageProperty; //Field offset: 0x98
	internal static readonly BindingId sourceRectProperty; //Field offset: 0xE4
	internal static readonly BindingId uvProperty; //Field offset: 0x130
	internal static readonly BindingId scaleModeProperty; //Field offset: 0x17C
	internal static readonly BindingId tintColorProperty; //Field offset: 0x1C8
	public static readonly string ussClassName; //Field offset: 0x214
	private static CustomStyleProperty<Texture2D> s_ImageProperty; //Field offset: 0x218
	private static CustomStyleProperty<Sprite> s_SpriteProperty; //Field offset: 0x21C
	private static CustomStyleProperty<VectorImage> s_VectorImageProperty; //Field offset: 0x220
	private static CustomStyleProperty<String> s_ScaleModeProperty; //Field offset: 0x224
	private static CustomStyleProperty<Color> s_TintColorProperty; //Field offset: 0x228
	private ScaleMode m_ScaleMode; //Field offset: 0x368
	private Texture m_Image; //Field offset: 0x36C
	private Sprite m_Sprite; //Field offset: 0x370
	private VectorImage m_VectorImage; //Field offset: 0x374
	private Rect m_UV; //Field offset: 0x378
	private Color m_TintColor; //Field offset: 0x388
	internal bool m_ImageIsInline; //Field offset: 0x398
	private bool m_ScaleModeIsInline; //Field offset: 0x399
	private bool m_TintColorIsInline; //Field offset: 0x39A

	[CreateProperty]
	public Texture image
	{
		 get { } //Length: 14
		 set { } //Length: 276
	}

	[CreateProperty]
	public ScaleMode scaleMode
	{
		 get { } //Length: 14
		 set { } //Length: 54
	}

	[CreateProperty]
	public Rect sourceRect
	{
		 get { } //Length: 36
		 set { } //Length: 310
	}

	[CreateProperty]
	public Sprite sprite
	{
		 get { } //Length: 14
		 set { } //Length: 283
	}

	[CreateProperty]
	public Color tintColor
	{
		 get { } //Length: 21
		 set { } //Length: 136
	}

	[CreateProperty]
	public Rect uv
	{
		 get { } //Length: 21
		 set { } //Length: 166
	}

	[CreateProperty]
	public VectorImage vectorImage
	{
		 get { } //Length: 14
		 set { } //Length: 281
	}

	private static Image() { }

	public Image() { }

	private void CalculateUV(Rect srcRect) { }

	private void ClearProperty() { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	public Texture get_image() { }

	public ScaleMode get_scaleMode() { }

	public Rect get_sourceRect() { }

	public Sprite get_sprite() { }

	public Color get_tintColor() { }

	public Rect get_uv() { }

	public VectorImage get_vectorImage() { }

	private Rect GetSourceRect() { }

	private Vector2 GetTextureDisplaySize(Texture texture) { }

	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	public void set_image(Texture value) { }

	public void set_scaleMode(ScaleMode value) { }

	public void set_sourceRect(Rect value) { }

	public void set_sprite(Sprite value) { }

	public void set_tintColor(Color value) { }

	public void set_uv(Rect value) { }

	public void set_vectorImage(VectorImage value) { }

	private void SetProperty(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1, BindingId binding) { }

	private void SetScaleMode(ScaleMode mode) { }

	private void SetTintColor(Color color) { }

}

