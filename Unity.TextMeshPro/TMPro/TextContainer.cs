namespace TMPro;

[RequireComponent(typeof(RectTransform))]
public class TextContainer : UIBehaviour
{
	private static Vector2 k_defaultSize; //Field offset: 0x0
	private bool m_hasChanged; //Field offset: 0x10
	[SerializeField]
	private Vector2 m_pivot; //Field offset: 0x14
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; //Field offset: 0x1C
	[SerializeField]
	private Rect m_rect; //Field offset: 0x20
	private bool m_isDefaultWidth; //Field offset: 0x30
	private bool m_isDefaultHeight; //Field offset: 0x31
	private bool m_isAutoFitting; //Field offset: 0x32
	private Vector3[] m_corners; //Field offset: 0x34
	private Vector3[] m_worldCorners; //Field offset: 0x38
	[SerializeField]
	private Vector4 m_margins; //Field offset: 0x3C
	private RectTransform m_rectTransform; //Field offset: 0x4C
	private TextMeshPro m_textMeshPro; //Field offset: 0x50

	public TextContainerAnchors anchorPosition
	{
		 get { } //Length: 11
		 set { } //Length: 260
	}

	public Vector3[] corners
	{
		 get { } //Length: 11
	}

	public bool hasChanged
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float height
	{
		 get { } //Length: 11
		 set { } //Length: 80
	}

	public bool isAutoFitting
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool isDefaultHeight
	{
		 get { } //Length: 11
	}

	public bool isDefaultWidth
	{
		 get { } //Length: 11
	}

	public Vector4 margins
	{
		 get { } //Length: 18
		 set { } //Length: 117
	}

	public Vector2 pivot
	{
		 get { } //Length: 39
		 set { } //Length: 121
	}

	public Rect rect
	{
		 get { } //Length: 18
		 set { } //Length: 99
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 122
	}

	public Vector2 size
	{
		 get { } //Length: 39
		 set { } //Length: 125
	}

	public TextMeshPro textMeshPro
	{
		 get { } //Length: 122
	}

	public float width
	{
		 get { } //Length: 11
		 set { } //Length: 80
	}

	public Vector3[] worldCorners
	{
		 get { } //Length: 11
	}

	private static TextContainer() { }

	public TextContainer() { }

	protected virtual void Awake() { }

	public TextContainerAnchors get_anchorPosition() { }

	public Vector3[] get_corners() { }

	public bool get_hasChanged() { }

	public float get_height() { }

	public bool get_isAutoFitting() { }

	public bool get_isDefaultHeight() { }

	public bool get_isDefaultWidth() { }

	public Vector4 get_margins() { }

	public Vector2 get_pivot() { }

	public Rect get_rect() { }

	public RectTransform get_rectTransform() { }

	public Vector2 get_size() { }

	public TextMeshPro get_textMeshPro() { }

	public float get_width() { }

	public Vector3[] get_worldCorners() { }

	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	private void OnContainerChanged() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public void set_anchorPosition(TextContainerAnchors value) { }

	public void set_hasChanged(bool value) { }

	public void set_height(float value) { }

	public void set_isAutoFitting(bool value) { }

	public void set_margins(Vector4 value) { }

	public void set_pivot(Vector2 value) { }

	public void set_rect(Rect value) { }

	public void set_size(Vector2 value) { }

	public void set_width(float value) { }

	private void SetRect(Vector2 size) { }

	private void UpdateCorners() { }

}

