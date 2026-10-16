namespace XeSys.Gfx;

public class TexOffsetAnimation
{
	[SerializeField]
	private int width; //Field offset: 0x8
	[SerializeField]
	private int height; //Field offset: 0xC
	[SerializeField]
	private int count; //Field offset: 0x10
	[SerializeField]
	private float changeTime; //Field offset: 0x14
	private Material mMaterial; //Field offset: 0x18
	private float mTime; //Field offset: 0x1C
	private int mPattern; //Field offset: 0x20
	private Vector2 mOffset; //Field offset: 0x24
	private Vector2 mStep; //Field offset: 0x2C

	public int pattern
	{
		 get { } //Length: 11
	}

	public TexOffsetAnimation() { }

	public int get_pattern() { }

	public void Start(Material mat) { }

	public void Update(float timeDelta) { }

}

