namespace Live2D.Cubism.Framework.Physics;

public class CubismPhysicsRig
{
	[SerializeField]
	public CubismPhysicsSubRig[] SubRigs; //Field offset: 0x8
	[SerializeField]
	public Vector2 Gravity; //Field offset: 0xC
	[SerializeField]
	public Vector2 Wind; //Field offset: 0x14
	[SerializeField]
	public float Fps; //Field offset: 0x1C
	private float _currentRemainTime; //Field offset: 0x20
	private Single[] _parametersCache; //Field offset: 0x24
	private Single[] _parametersInputCache; //Field offset: 0x28
	[CompilerGenerated]
	private CubismPhysicsController <Controller>k__BackingField; //Field offset: 0x2C

	public CubismPhysicsController Controller
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Single[] ParametersCache
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CubismPhysicsRig() { }

	public void Evaluate(float deltaTime) { }

	[CompilerGenerated]
	public CubismPhysicsController get_Controller() { }

	public Single[] get_ParametersCache() { }

	public CubismPhysicsSubRig GetSubRig(string name) { }

	public void Initialize() { }

	[CompilerGenerated]
	public void set_Controller(CubismPhysicsController value) { }

	public void set_ParametersCache(Single[] value) { }

	public void Stabilization() { }

}

