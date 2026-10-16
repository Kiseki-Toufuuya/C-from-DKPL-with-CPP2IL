namespace UnityEngine.Tilemaps;

[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
public class Tile : TileBase
{
	internal enum ColliderType
	{
		None = 0,
		Sprite = 1,
		Grid = 2,
	}

	[SerializeField]
	private Sprite m_Sprite; //Field offset: 0xC
	[SerializeField]
	private Color m_Color; //Field offset: 0x10
	[SerializeField]
	private Matrix4x4 m_Transform; //Field offset: 0x20
	[SerializeField]
	private GameObject m_InstancedGameObject; //Field offset: 0x60
	[SerializeField]
	private TileFlags m_Flags; //Field offset: 0x64
	[SerializeField]
	private ColliderType m_ColliderType; //Field offset: 0x68

	public ColliderType colliderType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Color color
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public TileFlags flags
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public GameObject gameObject
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Sprite sprite
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Matrix4x4 transform
	{
		 get { } //Length: 42
		 set { } //Length: 40
	}

	public Tile() { }

	public ColliderType get_colliderType() { }

	public Color get_color() { }

	public TileFlags get_flags() { }

	public GameObject get_gameObject() { }

	public Sprite get_sprite() { }

	public Matrix4x4 get_transform() { }

	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	public void set_colliderType(ColliderType value) { }

	public void set_color(Color value) { }

	public void set_flags(TileFlags value) { }

	public void set_gameObject(GameObject value) { }

	public void set_sprite(Sprite value) { }

	public void set_transform(Matrix4x4 value) { }

}

