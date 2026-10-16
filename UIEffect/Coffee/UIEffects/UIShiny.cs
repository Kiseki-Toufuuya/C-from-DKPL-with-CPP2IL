namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIShiny", 2)]
public class UIShiny : BaseMaterialEffect
{
	private const uint k_ShaderId = 8; //Field offset: 0x0
	private static readonly ParameterTexture s_ParamTex; //Field offset: 0x0
	private float _lastRotation; //Field offset: 0x38
	private EffectArea _lastEffectArea; //Field offset: 0x3C
	[FormerlySerializedAs("m_Location")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Location for shiny effect.")]
	private float m_EffectFactor; //Field offset: 0x40
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Width for shiny effect.")]
	private float m_Width; //Field offset: 0x44
	[Range(-180, 180)]
	[SerializeField]
	[Tooltip("Rotation for shiny effect.")]
	private float m_Rotation; //Field offset: 0x48
	[Range(0.01, 1)]
	[SerializeField]
	[Tooltip("Softness for shiny effect.")]
	private float m_Softness; //Field offset: 0x4C
	[FormerlySerializedAs("m_Alpha")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Brightness for shiny effect.")]
	private float m_Brightness; //Field offset: 0x50
	[FormerlySerializedAs("m_Highlight")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Gloss factor for shiny effect.")]
	private float m_Gloss; //Field offset: 0x54
	[Header("Advanced Option")]
	[SerializeField]
	[Tooltip("The area for effect.")]
	protected EffectArea m_EffectArea; //Field offset: 0x58
	[SerializeField]
	private EffectPlayer m_Player; //Field offset: 0x5C

	public float brightness
	{
		 get { } //Length: 11
		 set { } //Length: 183
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

	public float gloss
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public virtual ParameterTexture paramTex
	{
		 get { } //Length: 60
	}

	public float rotation
	{
		 get { } //Length: 11
		 set { } //Length: 152
	}

	public float softness
	{
		 get { } //Length: 11
		 set { } //Length: 188
	}

	public float width
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	private static UIShiny() { }

	public UIShiny() { }

	[CompilerGenerated]
	private void <OnEnable>b__37_0(float f) { }

	public float get_brightness() { }

	public EffectArea get_effectArea() { }

	public float get_effectFactor() { }

	public EffectPlayer get_effectPlayer() { }

	public float get_gloss() { }

	public virtual ParameterTexture get_paramTex() { }

	public float get_rotation() { }

	public float get_softness() { }

	public float get_width() { }

	public virtual Hash128 GetMaterialHash(Material material) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void Play(bool reset = true) { }

	public void set_brightness(float value) { }

	public void set_effectArea(EffectArea value) { }

	public void set_effectFactor(float value) { }

	public void set_gloss(float value) { }

	public void set_rotation(float value) { }

	public void set_softness(float value) { }

	public void set_width(float value) { }

	protected virtual void SetEffectParamsDirty() { }

	protected virtual void SetVerticesDirty() { }

	public void Stop(bool reset = true) { }

}

