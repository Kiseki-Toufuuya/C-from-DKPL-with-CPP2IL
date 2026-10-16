namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UITransitionEffect", 5)]
public class UITransitionEffect : BaseMaterialEffect
{
	internal enum EffectMode
	{
		Fade = 1,
		Cutoff = 2,
		Dissolve = 3,
	}

	private const uint k_ShaderId = 40; //Field offset: 0x0
	private static readonly int k_TransitionTexId; //Field offset: 0x0
	private static readonly ParameterTexture s_ParamTex; //Field offset: 0x4
	private static Texture _defaultTransitionTexture; //Field offset: 0x8
	private bool _lastKeepAspectRatio; //Field offset: 0x38
	[SerializeField]
	[Tooltip("Effect mode.")]
	private EffectMode m_EffectMode; //Field offset: 0x3C
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Effect factor between 0(hidden) and 1(shown).")]
	private float m_EffectFactor; //Field offset: 0x40
	[SerializeField]
	[Tooltip("Transition texture (single channel texture).")]
	private Texture m_TransitionTexture; //Field offset: 0x44
	[Header("Advanced Option")]
	[SerializeField]
	[Tooltip("The area for effect.")]
	private EffectArea m_EffectArea; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Keep effect aspect ratio.")]
	private bool m_KeepAspectRatio; //Field offset: 0x4C
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Dissolve edge width.")]
	private float m_DissolveWidth; //Field offset: 0x50
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Dissolve edge softness.")]
	private float m_DissolveSoftness; //Field offset: 0x54
	[ColorUsage(False)]
	[SerializeField]
	[Tooltip("Dissolve edge color.")]
	private Color m_DissolveColor; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Disable the graphic's raycast target on hidden.")]
	private bool m_PassRayOnHidden; //Field offset: 0x68
	[Header("Effect Player")]
	[SerializeField]
	private EffectPlayer m_Player; //Field offset: 0x6C

	private static Texture defaultTransitionTexture
	{
		private get { } //Length: 237
	}

	public Color dissolveColor
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public float dissolveSoftness
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public float dissolveWidth
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public float effectFactor
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public EffectMode effectMode
	{
		 get { } //Length: 11
		 set { } //Length: 30
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
		 get { } //Length: 61
	}

	public bool passRayOnHidden
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Texture transitionTexture
	{
		 get { } //Length: 355
		 set { } //Length: 109
	}

	private static UITransitionEffect() { }

	public UITransitionEffect() { }

	[CompilerGenerated]
	private void <Hide>b__47_0(float f) { }

	[CompilerGenerated]
	private void <Show>b__46_0(float f) { }

	private static Texture get_defaultTransitionTexture() { }

	public Color get_dissolveColor() { }

	public float get_dissolveSoftness() { }

	public float get_dissolveWidth() { }

	public float get_effectFactor() { }

	public EffectMode get_effectMode() { }

	public EffectPlayer get_effectPlayer() { }

	public bool get_keepAspectRatio() { }

	public virtual ParameterTexture get_paramTex() { }

	public bool get_passRayOnHidden() { }

	public Texture get_transitionTexture() { }

	public virtual Hash128 GetMaterialHash(Material material) { }

	public void Hide(bool reset = true) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void set_dissolveColor(Color value) { }

	public void set_dissolveSoftness(float value) { }

	public void set_dissolveWidth(float value) { }

	public void set_effectFactor(float value) { }

	public void set_effectMode(EffectMode value) { }

	public void set_keepAspectRatio(bool value) { }

	public void set_passRayOnHidden(bool value) { }

	public void set_transitionTexture(Texture value) { }

	protected virtual void SetEffectParamsDirty() { }

	protected virtual void SetVerticesDirty() { }

	public void Show(bool reset = true) { }

}

