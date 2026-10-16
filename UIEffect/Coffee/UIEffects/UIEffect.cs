namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIEffect", 1)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(Graphic))]
public class UIEffect : BaseMaterialEffect, IMaterialModifier
{
	private enum BlurEx
	{
		None = 0,
		Ex = 1,
	}

	private const uint k_ShaderId = 16; //Field offset: 0x0
	private static readonly ParameterTexture s_ParamTex; //Field offset: 0x0
	[FormerlySerializedAs("m_ToneLevel")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Effect factor between 0(no effect) and 1(complete effect).")]
	private float m_EffectFactor; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Color effect factor between 0(no effect) and 1(complete effect).")]
	private float m_ColorFactor; //Field offset: 0x3C
	[FormerlySerializedAs("m_Blur")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How far is the blurring from the graphic.")]
	private float m_BlurFactor; //Field offset: 0x40
	[FormerlySerializedAs("m_ToneMode")]
	[SerializeField]
	[Tooltip("Effect mode")]
	private EffectMode m_EffectMode; //Field offset: 0x44
	[SerializeField]
	[Tooltip("Color effect mode")]
	private ColorMode m_ColorMode; //Field offset: 0x48
	[SerializeField]
	[Tooltip("Blur effect mode")]
	private BlurMode m_BlurMode; //Field offset: 0x4C
	[SerializeField]
	[Tooltip("Advanced blurring remove common artifacts in the blur effect for uGUI.")]
	private bool m_AdvancedBlur; //Field offset: 0x50

	public bool advancedBlur
	{
		 get { } //Length: 11
		 set { } //Length: 49
	}

	public float blurFactor
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public BlurMode blurMode
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	public float colorFactor
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public ColorMode colorMode
	{
		 get { } //Length: 11
		 set { } //Length: 30
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

	public virtual ParameterTexture paramTex
	{
		 get { } //Length: 60
	}

	public AdditionalCanvasShaderChannels uvMaskChannel
	{
		 get { } //Length: 47
	}

	private static UIEffect() { }

	public UIEffect() { }

	public bool get_advancedBlur() { }

	public float get_blurFactor() { }

	public BlurMode get_blurMode() { }

	public float get_colorFactor() { }

	public ColorMode get_colorMode() { }

	public float get_effectFactor() { }

	public EffectMode get_effectMode() { }

	public virtual ParameterTexture get_paramTex() { }

	public AdditionalCanvasShaderChannels get_uvMaskChannel() { }

	private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global) { }

	public virtual Hash128 GetMaterialHash(Material material) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	public void set_advancedBlur(bool value) { }

	public void set_blurFactor(float value) { }

	public void set_blurMode(BlurMode value) { }

	public void set_colorFactor(float value) { }

	public void set_colorMode(ColorMode value) { }

	public void set_effectFactor(float value) { }

	public void set_effectMode(EffectMode value) { }

	protected virtual void SetEffectParamsDirty() { }

}

