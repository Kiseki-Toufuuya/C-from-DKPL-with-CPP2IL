namespace UnityEngine.UI;

[AddComponentMenu("UI/Rect Mask 2D", 14)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
{
	private readonly RectangularVertexClipper m_VertexClipper; //Field offset: 0x10
	private RectTransform m_RectTransform; //Field offset: 0x14
	private HashSet<MaskableGraphic> m_MaskableTargets; //Field offset: 0x18
	private HashSet<IClippable> m_ClipTargets; //Field offset: 0x1C
	private bool m_ShouldRecalculateClipRects; //Field offset: 0x20
	private List<RectMask2D> m_Clippers; //Field offset: 0x24
	private Rect m_LastClipRectCanvasSpace; //Field offset: 0x28
	private bool m_ForceClip; //Field offset: 0x38
	[SerializeField]
	private Vector4 m_Padding; //Field offset: 0x3C
	[SerializeField]
	private Vector2Int m_Softness; //Field offset: 0x4C
	private Canvas m_Canvas; //Field offset: 0x54
	private Vector3[] m_Corners; //Field offset: 0x58

	internal Canvas Canvas
	{
		internal get { } //Length: 308
	}

	public Rect canvasRect
	{
		 get { } //Length: 134
	}

	public Vector4 padding
	{
		 get { } //Length: 18
		 set { } //Length: 27
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 80
	}

	private Rect rootCanvasRect
	{
		private get { } //Length: 424
	}

	public Vector2Int softness
	{
		 get { } //Length: 14
		 set { } //Length: 45
	}

	protected RectMask2D() { }

	public void AddClippable(IClippable clippable) { }

	internal Canvas get_Canvas() { }

	public Rect get_canvasRect() { }

	public Vector4 get_padding() { }

	public RectTransform get_rectTransform() { }

	private Rect get_rootCanvasRect() { }

	public Vector2Int get_softness() { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	protected virtual void OnCanvasHierarchyChanged() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnTransformParentChanged() { }

	public override void PerformClipping() { }

	public void RemoveClippable(IClippable clippable) { }

	public void set_padding(Vector4 value) { }

	public void set_softness(Vector2Int value) { }

	public override void UpdateClipSoftness() { }

}

