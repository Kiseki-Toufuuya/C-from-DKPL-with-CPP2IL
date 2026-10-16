namespace Live2D.Cubism.Framework.Physics;

public class CubismPhysicsSubRig
{
	private struct SubRigPhysicsOutput
	{
		public Single[] Output; //Field offset: 0x0

	}

	[SerializeField]
	public string Name; //Field offset: 0x8
	[SerializeField]
	public CubismPhysicsInput[] Input; //Field offset: 0xC
	public CubismPhysicsInput[] OriginalInput; //Field offset: 0x10
	[SerializeField]
	public CubismPhysicsOutput[] Output; //Field offset: 0x14
	public CubismPhysicsOutput[] OriginalOutput; //Field offset: 0x18
	[SerializeField]
	public CubismPhysicsParticle[] Particles; //Field offset: 0x1C
	[SerializeField]
	public CubismPhysicsNormalization Normalization; //Field offset: 0x20
	private CubismPhysicsRig _rig; //Field offset: 0x38
	private SubRigPhysicsOutput _currentRigOutput; //Field offset: 0x3C
	private SubRigPhysicsOutput _previousRigOutput; //Field offset: 0x40

	public CubismPhysicsRig Rig
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CubismPhysicsSubRig() { }

	public void Evaluate(float deltaTime) { }

	public CubismPhysicsRig get_Rig() { }

	public void Initialize() { }

	public void Interpolate(float weight) { }

	public void set_Rig(CubismPhysicsRig value) { }

	public void Stabilization() { }

	private void UpdateOutputParameterValue(CubismParameter parameter, ref float parameterValue, float translation, CubismPhysicsOutput output) { }

	private void UpdateParticles(CubismPhysicsParticle[] strand, Vector2 totalTranslation, float totalAngle, Vector2 wind, float thresholdValue, float deltaTime) { }

	private void UpdateParticlesForStabilization(CubismPhysicsParticle[] strand, Vector2 totalTranslation, float totalAngle, Vector2 wind, float thresholdValue) { }

}

