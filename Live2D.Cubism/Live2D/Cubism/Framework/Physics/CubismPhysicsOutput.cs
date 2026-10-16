namespace Live2D.Cubism.Framework.Physics;

public struct CubismPhysicsOutput
{
	internal sealed class ScaleGetter : MulticastDelegate
	{

		public ScaleGetter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke() { }

	}

	internal sealed class ValueGetter : MulticastDelegate
	{

		public ValueGetter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 translation, CubismPhysicsParticle[] particles, int particleIndex, Vector2 gravity, AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke(Vector2 translation, CubismPhysicsParticle[] particles, int particleIndex, Vector2 gravity) { }

	}

	[SerializeField]
	public string DestinationId; //Field offset: 0x0
	[SerializeField]
	public int ParticleIndex; //Field offset: 0x4
	[SerializeField]
	public Vector2 TranslationScale; //Field offset: 0x8
	[SerializeField]
	public float AngleScale; //Field offset: 0x10
	[SerializeField]
	public float Weight; //Field offset: 0x14
	[SerializeField]
	public CubismPhysicsSourceComponent SourceComponent; //Field offset: 0x18
	[SerializeField]
	public bool IsInverted; //Field offset: 0x1C
	public float ValueBelowMinimum; //Field offset: 0x20
	public float ValueExceededMaximum; //Field offset: 0x24
	public CubismParameter Destination; //Field offset: 0x28
	public int DestinationIndex; //Field offset: 0x2C
	public ValueGetter GetValue; //Field offset: 0x30
	public ScaleGetter GetScale; //Field offset: 0x34

	private float GetOutputAngle(Vector2 translation, CubismPhysicsParticle[] particles, int particleIndex, Vector2 gravity) { }

	private float GetOutputScaleAngle() { }

	private float GetOutputScaleTranslationX() { }

	private float GetOutputScaleTranslationY() { }

	private float GetOutputTranslationX(Vector2 translation, CubismPhysicsParticle[] particles, int particleIndex, Vector2 gravity) { }

	private float GetOutputTranslationY(Vector2 translation, CubismPhysicsParticle[] particles, int particleIndex, Vector2 gravity) { }

	public void InitializeGetter() { }

}

