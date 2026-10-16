namespace XeSys.Gfx;

public class MaterialTextureScroller : MonoBehaviour
{
	internal class ScrollInfo
	{
		public Vector2 speed; //Field offset: 0x8

		public ScrollInfo() { }

	}

	public ScrollInfo scroll; //Field offset: 0x10
	[CompilerGenerated]
	private Material <material>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Vector2 <offset>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isPaused>k__BackingField; //Field offset: 0x20

	public override float deltaTime
	{
		 get { } //Length: 11
	}

	public override bool isPaused
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Material material
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Vector2 offset
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MaterialTextureScroller() { }

	public override float get_deltaTime() { }

	[CompilerGenerated]
	public override bool get_isPaused() { }

	[CompilerGenerated]
	public Material get_material() { }

	[CompilerGenerated]
	public Vector2 get_offset() { }

	[CompilerGenerated]
	public override void set_isPaused(bool value) { }

	[CompilerGenerated]
	public void set_material(Material value) { }

	[CompilerGenerated]
	protected void set_offset(Vector2 value) { }

	public void SetSpeed(float x, float y) { }

	public void SetSpeed(Vector2 speed) { }

	protected override void Start() { }

	protected override void Update() { }

}

