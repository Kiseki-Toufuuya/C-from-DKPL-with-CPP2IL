namespace XeSys.Gfx;

public class LayoutUGUIInfiniteScroll : UIBehaviour
{
	internal enum Direction
	{
		Vertical = 0,
		Horizontal = 1,
	}

	internal interface IItem
	{

		public void OnUpdateItem(int index) { }

	}

	[SerializeField]
	private UGUIScrollSupportBase m_support; //Field offset: 0x10
	[SerializeField]
	private GameObject m_itemBase; //Field offset: 0x14
	[SerializeField]
	private int m_instantateItemCount; //Field offset: 0x18
	[SerializeField]
	public Direction direction; //Field offset: 0x1C
	[SerializeField]
	private float m_areaMargin; //Field offset: 0x20
	[CompilerGenerated]
	private int <MaxItemCount>k__BackingField; //Field offset: 0x24
	private LinkedList<RectTransform> m_itemList; //Field offset: 0x28
	private Vector2 m_itemBasePos; //Field offset: 0x2C
	private Vector2 m_posWork; //Field offset: 0x34
	protected float m_diffPreFramePosition; //Field offset: 0x3C
	protected int m_currentItemNo; //Field offset: 0x40
	private bool m_isLimited; //Field offset: 0x44
	private Vector2 m_itemSize; //Field offset: 0x48
	private bool m_IsVariableItemSize; //Field offset: 0x50
	private List<Single> m_VariableItemWidthList; //Field offset: 0x54
	private List<Single> m_VariableItemHeightList; //Field offset: 0x58

	public float AreaMargin
	{
		 set { } //Length: 18
	}

	public int InstantateItemCount
	{
		 set { } //Length: 14
	}

	public bool IsVariableItemSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public GameObject ItemBase
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public LinkedList<RectTransform> ItemList
	{
		 get { } //Length: 11
	}

	public Vector2 ItemSize
	{
		 get { } //Length: 39
		 set { } //Length: 20
	}

	public int MaxItemCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public float NormalizedPosition
	{
		 get { } //Length: 80
	}

	public UGUIScrollSupportBase Support
	{
		 set { } //Length: 27
	}

	public LayoutUGUIInfiniteScroll() { }

	public void AddItemHeight(float h) { }

	public void AddItemWidth(float w) { }

	public void CalcResizeItemScrollPosition(int index, float before, float after) { }

	public void ClearItemHeight() { }

	public void ClearItemWidth() { }

	public bool get_IsVariableItemSize() { }

	public GameObject get_ItemBase() { }

	public LinkedList<RectTransform> get_ItemList() { }

	public Vector2 get_ItemSize() { }

	[CompilerGenerated]
	public int get_MaxItemCount() { }

	public float get_NormalizedPosition() { }

	public int GetLastItemIndex() { }

	public float GetVariableItemPos(int index) { }

	public float GetVariableItemPosX(int index) { }

	public float GetVariableItemPosY(int index) { }

	public float GetVariableItemSize(int index) { }

	public void Instantiate() { }

	public void RearrangeItem() { }

	public void Restart(float normalizedPos) { }

	public void set_AreaMargin(float value) { }

	public void set_InstantateItemCount(int value) { }

	public void set_IsVariableItemSize(bool value) { }

	public void set_ItemBase(GameObject value) { }

	public void set_ItemSize(Vector2 value) { }

	[CompilerGenerated]
	public void set_MaxItemCount(int value) { }

	public void set_Support(UGUIScrollSupportBase value) { }

	public void SetItemHeight(int index, float h) { }

	public void SetItemWidth(int index, float w) { }

	private void Update() { }

	private void UpdateItem(int index, float size, RectTransform item) { }

}

