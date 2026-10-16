namespace XeSys.Gfx;

public abstract class UGUIScrollSupportBase : MonoBehaviour
{
	[SerializeField]
	protected ScrollRect m_scrollRect; //Field offset: 0x10
	protected Vector2 m_range; //Field offset: 0x14
	protected Vector2 m_contentSize; //Field offset: 0x1C

	public float ContentHeight
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public Vector2 ContentSize
	{
		 get { } //Length: 39
		 set { } //Length: 31
	}

	public float ContentWidth
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public float HorizontalNormalizedPosition
	{
		 get { } //Length: 34
		 set { } //Length: 42
	}

	public Vector2 RangeSize
	{
		 get { } //Length: 39
	}

	public RectTransform ScrollContent
	{
		 get { } //Length: 23
	}

	public ScrollRect ScrollRect
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float VerticalNormalizedPosition
	{
		 get { } //Length: 34
		 set { } //Length: 42
	}

	protected UGUIScrollSupportBase() { }

	public abstract void AddView(GameObject obj, float offsetX, float offsetY) { }

	public void AddViewH(GameObject obj, float sizeX, float sizeY) { }

	public void AddViewV(GameObject obj, float sizeX, float sizeY) { }

	public void BeginAddView() { }

	public void EndAddView() { }

	public float get_ContentHeight() { }

	public Vector2 get_ContentSize() { }

	public float get_ContentWidth() { }

	public float get_HorizontalNormalizedPosition() { }

	public Vector2 get_RangeSize() { }

	public RectTransform get_ScrollContent() { }

	public ScrollRect get_ScrollRect() { }

	public float get_VerticalNormalizedPosition() { }

	public Transform GetChild(int index) { }

	public int GetChildCount() { }

	public void Initialize() { }

	public void RemoveAllView(bool isDestroy) { }

	public void RemoveAllView() { }

	public void RemoveView(int childIndex) { }

	public abstract void RemoveView(int childIndex, bool isDestroy) { }

	public void set_ContentHeight(float value) { }

	public void set_ContentSize(Vector2 value) { }

	public void set_ContentWidth(float value) { }

	public void set_HorizontalNormalizedPosition(float value) { }

	public void set_ScrollRect(ScrollRect value) { }

	public void set_VerticalNormalizedPosition(float value) { }

	protected void UpdateContent() { }

}

