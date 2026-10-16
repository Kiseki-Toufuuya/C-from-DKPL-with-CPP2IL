namespace XeSys.Gfx;

public class MaterialTextureSheetAnimation : MonoBehaviour
{
	public int sheetColumn; //Field offset: 0x10
	public int sheetRow; //Field offset: 0x14
	public float changeTime; //Field offset: 0x18
	public int startIndex; //Field offset: 0x1C
	public int slices; //Field offset: 0x20
	public bool random; //Field offset: 0x24
	public bool reverse; //Field offset: 0x25
	public bool enableScale; //Field offset: 0x26
	public bool enableLoop; //Field offset: 0x27
	public int startSliceOffset; //Field offset: 0x28
	[CompilerGenerated]
	private int <currentIndex>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <currentTime>k__BackingField; //Field offset: 0x30
	private int mEndIndex; //Field offset: 0x34
	[CompilerGenerated]
	private Material <material>k__BackingField; //Field offset: 0x38
	private Action mUpdateIndex; //Field offset: 0x3C

	public private int currentIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private float currentTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public override float deltaTime
	{
		 get { } //Length: 11
	}

	public private Material material
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	protected float sliceHeight
	{
		 get { } //Length: 36
	}

	protected float sliceWidth
	{
		 get { } //Length: 36
	}

	public MaterialTextureSheetAnimation() { }

	private void Awake() { }

	[CompilerGenerated]
	public int get_currentIndex() { }

	[CompilerGenerated]
	public float get_currentTime() { }

	public override float get_deltaTime() { }

	[CompilerGenerated]
	public Material get_material() { }

	protected float get_sliceHeight() { }

	protected float get_sliceWidth() { }

	private void OnEnable() { }

	[CompilerGenerated]
	private void set_currentIndex(int value) { }

	[CompilerGenerated]
	private void set_currentTime(float value) { }

	[CompilerGenerated]
	private void set_material(Material value) { }

	protected override void SetOffset() { }

	public void Setup(int column_, int row_, int slices_, float changeTime_, int startindex_ = 0) { }

	protected override void Update() { }

	private void UpdateIndex_Add() { }

	private void UpdateIndex_Sub() { }

}

