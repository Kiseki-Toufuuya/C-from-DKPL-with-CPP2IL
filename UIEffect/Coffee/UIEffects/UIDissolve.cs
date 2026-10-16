namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIDissolve", 3)]
public class UIDissolve : BaseMaterialEffect, IMaterialModifier
{
	private const uint k_ShaderId = 0; //Field offset: 0x0
	private static readonly ParameterTexture s_ParamTex; //Field offset: 0x0
	private static readonly int k_TransitionTexId; //Field offset: 0x4
	private static Texture _defaultTransitionTexture; //Field offset: 0x8
	private bool _lastKeepAspectRatio; //Field offset: 0x38
	private EffectArea _lastEffectArea; //Field offset: 0x3C
	[FormerlySerializedAs("m_Location")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Current location[0-1] for dissolve effect. 0 is not dissolved, 1 is completely dissolved.")]
	private float m_EffectFactor; //Field offset: 0x40
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Edge width.")]
	private float m_Width; //Field offset: 0x44
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Edge softness.")]
	private float m_Softness; //Field offset: 0x48
	[ColorUsage(False)]
	[SerializeField]
	[Tooltip("Edge color.")]
	private Color m_Color; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Edge color effect mode.")]
	private ColorMode m_ColorMode; //Field offset: 0x5C
	[FormerlySerializedAs("m_NoiseTexture")]
	[SerializeField]
	[Tooltip("Noise texture for dissolving (single channel texture).")]
	private Texture m_TransitionTexture; //Field offset: 0x60
	[Header("Advanced Option")]
	[SerializeField]
	[Tooltip("The area for effect.")]
	protected EffectArea m_EffectArea; //Field offset: 0x64
	[SerializeField]
	[Tooltip("Keep effect aspect ratio.")]
	private bool m_KeepAspectRatio; //Field offset: 0x68
	[Header("Effect Player")]
	[SerializeField]
	private EffectPlayer m_Player; //Field offset: 0x6C
	[FormerlySerializedAs("m_ReverseAnimation")]
	[SerializeField]
	[Tooltip("Reverse the dissolve effect.")]
	private bool m_Reverse; //Field offset: 0x70

	public Color color
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public ColorMode colorMode
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	private static Texture defaultTransitionTexture
	{
		private get { } //Length: 237
	}

	public EffectArea effectArea
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public float effectFactor
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public EffectPlayer effectPlayer
	{
		 get { } //Length: 94
	}

	public bool keepAspectRatio
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	public virtual ParameterTexture paramTex
	{
		 get { } //Length: 60
	}

	public float softness
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public Texture transitionTexture
	{
		 get { } //Length: 355
		 set { } //Length: 109
	}

	public float width
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	private static UIDissolve() { }

	public UIDissolve() { }

	[CompilerGenerated]
	private void <OnEnable>b__54_0(float f) { }

	public Color get_color() { }

	public ColorMode get_colorMode() { }

	private static Texture get_defaultTransitionTexture() { }

	public EffectArea get_effectArea() { }

	public float get_effectFactor() { }

	public EffectPlayer get_effectPlayer() { }

	public bool get_keepAspectRatio() { }

	public virtual ParameterTexture get_paramTex() { }

	public float get_softness() { }

	public Texture get_transitionTexture() { }

	public float get_width() { }

	public virtual Hash128 GetMaterialHash(Material material) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void Play(bool reset = true) { }

	public void set_color(Color value) { }

	public void set_colorMode(ColorMode value) { }

	public void set_effectArea(EffectArea value) { }

	public void set_effectFactor(float value) { }

	public void set_keepAspectRatio(bool value) { }

	public void set_softness(float value) { }

	public void set_transitionTexture(Texture value) { }

	public void set_width(float value) { }

	protected virtual void SetEffectParamsDirty() { }

	protected virtual void SetVerticesDirty() { }

	public void Stop(bool reset = true) { }

}

