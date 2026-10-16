namespace UnityEngine.UI;

public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
{
	internal class CullStateChangedEvent : UnityEvent<Boolean>
	{

		public CullStateChangedEvent() { }

	}

	protected bool m_ShouldRecalculateStencil; //Field offset: 0x64
	protected Material m_MaskMaterial; //Field offset: 0x68
	private RectMask2D m_ParentMask; //Field offset: 0x6C
	[SerializeField]
	private bool m_Maskable; //Field offset: 0x70
	private bool m_IsMaskingGraphic; //Field offset: 0x71
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; //Field offset: 0x72
	[SerializeField]
	private CullStateChangedEvent m_OnCullStateChanged; //Field offset: 0x74
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; //Field offset: 0x78
	protected int m_StencilValue; //Field offset: 0x7C
	private readonly Vector3[] m_Corners; //Field offset: 0x80

	public bool isMaskingGraphic
	{
		 get { } //Length: 11
		 set { } //Length: 19
	}

	public bool maskable
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public CullStateChangedEvent onCullStateChanged
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private Rect rootCanvasRect
	{
		private get { } //Length: 596
	}

	protected MaskableGraphic() { }

	public override void Cull(Rect clipRect, bool validRect) { }

	public bool get_isMaskingGraphic() { }

	public bool get_maskable() { }

	public CullStateChangedEvent get_onCullStateChanged() { }

	private Rect get_rootCanvasRect() { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Not used anymore.", True)]
	public override void ParentMaskStateChanged() { }

	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	public override void RecalculateClipping() { }

	public override void RecalculateMasking() { }

	public void set_isMaskingGraphic(bool value) { }

	public void set_maskable(bool value) { }

	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	public override void SetClipRect(Rect clipRect, bool validRect) { }

	public override void SetClipSoftness(Vector2 clipSoftness) { }

	private override GameObject UnityEngine.UI.IClippable.get_gameObject() { }

	private void UpdateClipParent() { }

	private void UpdateCull(bool cull) { }

}

