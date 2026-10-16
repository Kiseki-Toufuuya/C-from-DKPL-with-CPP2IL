namespace XeSys.Gfx;

public class Fade : MonoBehaviour
{
	[SerializeField]
	public int renderQueue; //Field offset: 0x10
	[CompilerGenerated]
	private Color <startColor>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Color <targetColor>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private MeshRenderer <meshRenderer>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private Material <material>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private ElapsedTimer <elapsedTimer>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <isExecuting>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <fadeTime>k__BackingField; //Field offset: 0x44

	private ElapsedTimer elapsedTimer
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private float fadeTime
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private bool isExecuting
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private Material material
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private MeshRenderer meshRenderer
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private Color startColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private Color targetColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public Fade() { }

	private void Awake() { }

	public void Begin(Color targetColor, float t) { }

	public void Begin(Color startColor, Color targetColor, float t) { }

	[CompilerGenerated]
	private ElapsedTimer get_elapsedTimer() { }

	[CompilerGenerated]
	private float get_fadeTime() { }

	[CompilerGenerated]
	public bool get_isExecuting() { }

	[CompilerGenerated]
	private Material get_material() { }

	[CompilerGenerated]
	private MeshRenderer get_meshRenderer() { }

	[CompilerGenerated]
	public Color get_startColor() { }

	[CompilerGenerated]
	public Color get_targetColor() { }

	public void Reset(Color resetColor) { }

	[CompilerGenerated]
	private void set_elapsedTimer(ElapsedTimer value) { }

	[CompilerGenerated]
	private void set_fadeTime(float value) { }

	[CompilerGenerated]
	private void set_isExecuting(bool value) { }

	[CompilerGenerated]
	private void set_material(Material value) { }

	[CompilerGenerated]
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGenerated]
	private void set_startColor(Color value) { }

	[CompilerGenerated]
	private void set_targetColor(Color value) { }

	private void SetupScale() { }

	private void Update() { }

}

