namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class Graphic : UIBehaviour, ICanvasElement
{
	protected static Material s_DefaultUI; //Field offset: 0x0
	protected static Texture2D s_WhiteTexture; //Field offset: 0x4
	protected static Mesh s_Mesh; //Field offset: 0x8
	private static readonly VertexHelper s_VertexHelper; //Field offset: 0xC
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	protected Material m_Material; //Field offset: 0x10
	[SerializeField]
	private Color m_Color; //Field offset: 0x14
	protected bool m_SkipLayoutUpdate; //Field offset: 0x24
	protected bool m_SkipMaterialUpdate; //Field offset: 0x25
	[SerializeField]
	private bool m_RaycastTarget; //Field offset: 0x26
	private bool m_RaycastTargetCache; //Field offset: 0x27
	[SerializeField]
	private Vector4 m_RaycastPadding; //Field offset: 0x28
	private RectTransform m_RectTransform; //Field offset: 0x38
	private CanvasRenderer m_CanvasRenderer; //Field offset: 0x3C
	private Canvas m_Canvas; //Field offset: 0x40
	private bool m_VertsDirty; //Field offset: 0x44
	private bool m_MaterialDirty; //Field offset: 0x45
	protected UnityAction m_OnDirtyLayoutCallback; //Field offset: 0x48
	protected UnityAction m_OnDirtyVertsCallback; //Field offset: 0x4C
	protected UnityAction m_OnDirtyMaterialCallback; //Field offset: 0x50
	protected Mesh m_CachedMesh; //Field offset: 0x54
	protected Vector2[] m_CachedUvs; //Field offset: 0x58
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; //Field offset: 0x5C
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; //Field offset: 0x60

	public Canvas canvas
	{
		 get { } //Length: 95
	}

	public CanvasRenderer canvasRenderer
	{
		 get { } //Length: 140
	}

	public override Color color
	{
		 get { } //Length: 18
		 set { } //Length: 60
	}

	public static Material defaultGraphicMaterial
	{
		 get { } //Length: 198
	}

	public override Material defaultMaterial
	{
		 get { } //Length: 247
	}

	public int depth
	{
		 get { } //Length: 41
	}

	public override Texture mainTexture
	{
		 get { } //Length: 61
	}

	public override Material material
	{
		 get { } //Length: 108
		 set { } //Length: 118
	}

	public override Material materialForRendering
	{
		 get { } //Length: 384
	}

	public Vector4 raycastPadding
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public override bool raycastTarget
	{
		 get { } //Length: 11
		 set { } //Length: 185
	}

	public override RectTransform rectTransform
	{
		 get { } //Length: 76
	}

	protected bool useLegacyMeshGeneration
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	protected static Mesh workerMesh
	{
		 get { } //Length: 274
	}

	private static Graphic() { }

	protected Graphic() { }

	private void CacheCanvas() { }

	private static Color CreateColorFromAlpha(float alpha) { }

	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	private void DoLegacyMeshGeneration() { }

	private void DoMeshGeneration() { }

	public Canvas get_canvas() { }

	public CanvasRenderer get_canvasRenderer() { }

	public override Color get_color() { }

	public static Material get_defaultGraphicMaterial() { }

	public override Material get_defaultMaterial() { }

	public int get_depth() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override Material get_materialForRendering() { }

	public Vector4 get_raycastPadding() { }

	public override bool get_raycastTarget() { }

	public override RectTransform get_rectTransform() { }

	[CompilerGenerated]
	protected bool get_useLegacyMeshGeneration() { }

	protected static Mesh get_workerMesh() { }

	public Rect GetPixelAdjustedRect() { }

	public override void GraphicUpdateComplete() { }

	public override void LayoutComplete() { }

	protected virtual void OnBeforeTransformParentChanged() { }

	protected virtual void OnCanvasHierarchyChanged() { }

	public override void OnCullingChanged() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	protected override void OnFillVBO(List<UIVertex> vbo) { }

	protected override void OnPopulateMesh(VertexHelper vh) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	protected override void OnPopulateMesh(Mesh m) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected virtual void OnTransformParentChanged() { }

	public Vector2 PixelAdjustPoint(Vector2 point) { }

	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	protected bool Raycast(Vector2 sp, Camera eventCamera, bool ignoreMasks) { }

	public override void Rebuild(CanvasUpdate update) { }

	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	public override void set_color(Color value) { }

	public override void set_material(Material value) { }

	public void set_raycastPadding(Vector4 value) { }

	public override void set_raycastTarget(bool value) { }

	[CompilerGenerated]
	protected void set_useLegacyMeshGeneration(bool value) { }

	public override void SetAllDirty() { }

	public override void SetLayoutDirty() { }

	public override void SetMaterialDirty() { }

	public override void SetNativeSize() { }

	public void SetRaycastDirty() { }

	public override void SetVerticesDirty() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	protected override void UpdateGeometry() { }

	protected override void UpdateMaterial() { }

}

