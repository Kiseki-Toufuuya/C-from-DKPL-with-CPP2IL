namespace UnityEngine.UI;

[AddComponentMenu("UI/Mask", 13)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
{
	private RectTransform m_RectTransform; //Field offset: 0x10
	[SerializeField]
	private bool m_ShowMaskGraphic; //Field offset: 0x14
	private Graphic m_Graphic; //Field offset: 0x18
	private Material m_MaskMaterial; //Field offset: 0x1C
	private Material m_UnmaskMaterial; //Field offset: 0x20

	public Graphic graphic
	{
		 get { } //Length: 80
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 80
	}

	public bool showMaskGraphic
	{
		 get { } //Length: 11
		 set { } //Length: 201
	}

	protected Mask() { }

	public Graphic get_graphic() { }

	public RectTransform get_rectTransform() { }

	public bool get_showMaskGraphic() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public override bool MaskEnabled() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[Obsolete("Not used anymore.")]
	public override void OnSiblingGraphicEnabledDisabled() { }

	public void set_showMaskGraphic(bool value) { }

}

