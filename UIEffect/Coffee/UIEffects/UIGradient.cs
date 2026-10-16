namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIGradient", 101)]
[DisallowMultipleComponent]
public class UIGradient : BaseMeshEffect
{
	internal enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Angle = 2,
		Diagonal = 3,
	}

	internal enum GradientStyle
	{
		Rect = 0,
		Fit = 1,
		Split = 2,
	}

	private static readonly Vector2[] s_SplitedCharacterPosition; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Gradient Direction.")]
	private Direction m_Direction; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Color1: Top or Left.")]
	private Color m_Color1; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Color2: Bottom or Right.")]
	private Color m_Color2; //Field offset: 0x34
	[SerializeField]
	[Tooltip("Color3: For diagonal.")]
	private Color m_Color3; //Field offset: 0x44
	[SerializeField]
	[Tooltip("Color4: For diagonal.")]
	private Color m_Color4; //Field offset: 0x54
	[Range(-180, 180)]
	[SerializeField]
	[Tooltip("Gradient rotation.")]
	private float m_Rotation; //Field offset: 0x64
	[Range(-1, 1)]
	[SerializeField]
	[Tooltip("Gradient offset for Horizontal, Vertical or Angle.")]
	private float m_Offset1; //Field offset: 0x68
	[Range(-1, 1)]
	[SerializeField]
	[Tooltip("Gradient offset for Diagonal.")]
	private float m_Offset2; //Field offset: 0x6C
	[SerializeField]
	[Tooltip("Gradient style for Text.")]
	private GradientStyle m_GradientStyle; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Color space to correct color.")]
	private ColorSpace m_ColorSpace; //Field offset: 0x74
	[SerializeField]
	[Tooltip("Ignore aspect ratio.")]
	private bool m_IgnoreAspectRatio; //Field offset: 0x78

	public Color color1
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public Color color2
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public Color color3
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public Color color4
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public ColorSpace colorSpace
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public Direction direction
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public GradientStyle gradientStyle
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public bool ignoreAspectRatio
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public float offset
	{
		 get { } //Length: 11
		 set { } //Length: 152
	}

	public Vector2 offset2
	{
		 get { } //Length: 39
		 set { } //Length: 288
	}

	public float rotation
	{
		 get { } //Length: 35
		 set { } //Length: 152
	}

	private static UIGradient() { }

	public UIGradient() { }

	public Color get_color1() { }

	public Color get_color2() { }

	public Color get_color3() { }

	public Color get_color4() { }

	public ColorSpace get_colorSpace() { }

	public Direction get_direction() { }

	public GradientStyle get_gradientStyle() { }

	public bool get_ignoreAspectRatio() { }

	public float get_offset() { }

	public Vector2 get_offset2() { }

	public float get_rotation() { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	public void set_color1(Color value) { }

	public void set_color2(Color value) { }

	public void set_color3(Color value) { }

	public void set_color4(Color value) { }

	public void set_colorSpace(ColorSpace value) { }

	public void set_direction(Direction value) { }

	public void set_gradientStyle(GradientStyle value) { }

	public void set_ignoreAspectRatio(bool value) { }

	public void set_offset(float value) { }

	public void set_offset2(Vector2 value) { }

	public void set_rotation(float value) { }

}

