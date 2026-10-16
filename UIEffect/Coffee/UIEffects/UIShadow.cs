namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIShadow", 100)]
[RequireComponent(typeof(Graphic))]
public class UIShadow : BaseMeshEffect, IParameterTexture
{
	private static readonly List<UIShadow> tmpShadows; //Field offset: 0x0
	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	private static readonly List<UIVertex> s_Verts; //Field offset: 0x4
	private int _graphicVertexCount; //Field offset: 0x20
	private UIEffect _uiEffect; //Field offset: 0x24
	[FormerlySerializedAs("m_Blur")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How far is the blurring shadow from the graphic.")]
	private float m_BlurFactor; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Shadow effect style.")]
	private ShadowStyle m_Style; //Field offset: 0x2C
	[SerializeField]
	private Color m_EffectColor; //Field offset: 0x30
	[SerializeField]
	private Vector2 m_EffectDistance; //Field offset: 0x40
	[SerializeField]
	private bool m_UseGraphicAlpha; //Field offset: 0x48
	[CompilerGenerated]
	private int <parameterIndex>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private ParameterTexture <paramTex>k__BackingField; //Field offset: 0x50

	public float blurFactor
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public Color effectColor
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public Vector2 effectDistance
	{
		 get { } //Length: 39
		 set { } //Length: 143
	}

	public override int parameterIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private override ParameterTexture paramTex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public ShadowStyle style
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public bool useGraphicAlpha
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	private static UIShadow() { }

	public UIShadow() { }

	private void ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 distance, ShadowStyle style, bool alpha) { }

	private void ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool alpha) { }

	public float get_blurFactor() { }

	public Color get_effectColor() { }

	public Vector2 get_effectDistance() { }

	[CompilerGenerated]
	public override int get_parameterIndex() { }

	[CompilerGenerated]
	public override ParameterTexture get_paramTex() { }

	public ShadowStyle get_style() { }

	public bool get_useGraphicAlpha() { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_blurFactor(float value) { }

	public void set_effectColor(Color value) { }

	public void set_effectDistance(Vector2 value) { }

	[CompilerGenerated]
	public override void set_parameterIndex(int value) { }

	[CompilerGenerated]
	private void set_paramTex(ParameterTexture value) { }

	public void set_style(ShadowStyle value) { }

	public void set_useGraphicAlpha(bool value) { }

}

