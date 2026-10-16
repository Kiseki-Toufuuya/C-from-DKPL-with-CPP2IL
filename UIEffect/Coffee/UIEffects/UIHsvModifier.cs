namespace Coffee.UIEffects;

[AddComponentMenu("UI/UIEffects/UIHsvModifier", 4)]
public class UIHsvModifier : BaseMaterialEffect
{
	private const uint k_ShaderId = 48; //Field offset: 0x0
	private static readonly ParameterTexture s_ParamTex; //Field offset: 0x0
	[ColorUsage(False)]
	[Header("Target")]
	[SerializeField]
	[Tooltip("Target color to affect hsv shift.")]
	private Color m_TargetColor; //Field offset: 0x38
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Color range to affect hsv shift [0 ~ 1].")]
	private float m_Range; //Field offset: 0x48
	[Header("Adjustment")]
	[Range(-0.5, 0.5)]
	[SerializeField]
	[Tooltip("Hue shift [-0.5 ~ 0.5].")]
	private float m_Hue; //Field offset: 0x4C
	[Range(-0.5, 0.5)]
	[SerializeField]
	[Tooltip("Saturation shift [-0.5 ~ 0.5].")]
	private float m_Saturation; //Field offset: 0x50
	[Range(-0.5, 0.5)]
	[SerializeField]
	[Tooltip("Value shift [-0.5 ~ 0.5].")]
	private float m_Value; //Field offset: 0x54

	public float hue
	{
		 get { } //Length: 11
		 set { } //Length: 188
	}

	public virtual ParameterTexture paramTex
	{
		 get { } //Length: 60
	}

	public float range
	{
		 get { } //Length: 11
		 set { } //Length: 183
	}

	public float saturation
	{
		 get { } //Length: 11
		 set { } //Length: 188
	}

	public Color targetColor
	{
		 get { } //Length: 18
		 set { } //Length: 122
	}

	public float value
	{
		 get { } //Length: 11
		 set { } //Length: 188
	}

	private static UIHsvModifier() { }

	public UIHsvModifier() { }

	public float get_hue() { }

	public virtual ParameterTexture get_paramTex() { }

	public float get_range() { }

	public float get_saturation() { }

	public Color get_targetColor() { }

	public float get_value() { }

	public virtual Hash128 GetMaterialHash(Material material) { }

	public virtual void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	public virtual void ModifyMesh(VertexHelper vh, Graphic graphic) { }

	public void set_hue(float value) { }

	public void set_range(float value) { }

	public void set_saturation(float value) { }

	public void set_targetColor(Color value) { }

	public void set_value(float value) { }

	protected virtual void SetEffectParamsDirty() { }

}

