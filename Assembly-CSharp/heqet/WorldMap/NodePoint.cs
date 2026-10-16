namespace Heqet.WorldMap;

public abstract class NodePoint : MonoBehaviour
{
	private enum Direction
	{
		North = 0,
		South = 1,
		West = 2,
		East = 3,
		Num = 4,
	}

	[SerializeField]
	private NodePoint[] linkNorth; //Field offset: 0x10
	[SerializeField]
	private NodePoint[] linkSouth; //Field offset: 0x14
	[SerializeField]
	private NodePoint[] linkWest; //Field offset: 0x18
	[SerializeField]
	private NodePoint[] linkEast; //Field offset: 0x1C
	[SerializeField]
	private GameObject arrawRoot; //Field offset: 0x20
	[SerializeField]
	private SpriteRenderer[] arrawIcons; //Field offset: 0x24
	private Transform[] arrawIconsTransform; //Field offset: 0x28
	private Vector3[] startPos; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <isDisable>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <isHide>k__BackingField; //Field offset: 0x31

	public NodePoint East
	{
		 get { } //Length: 22
	}

	public bool isDisable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool isHide
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public NodePoint North
	{
		 get { } //Length: 22
	}

	public NodePoint South
	{
		 get { } //Length: 22
	}

	public NodePoint West
	{
		 get { } //Length: 22
	}

	protected NodePoint() { }

	private NodePoint EnableNode(NodePoint[] nodeList) { }

	public NodePoint get_East() { }

	[CompilerGenerated]
	public bool get_isDisable() { }

	[CompilerGenerated]
	public bool get_isHide() { }

	public NodePoint get_North() { }

	public NodePoint get_South() { }

	public NodePoint get_West() { }

	[CompilerGenerated]
	protected void set_isDisable(bool value) { }

	[CompilerGenerated]
	protected void set_isHide(bool value) { }

	private void Start() { }

	private void UpdateArraw(SpriteRenderer arrawIcon, NodePoint[] points) { }

	public void UpdateArrawAnimation(float arrawFactor) { }

	public void UpdateArrawas(bool isVisible) { }

	public abstract void UpdateFrame() { }

	public abstract void VisibleCursor(bool isVisible) { }

}

