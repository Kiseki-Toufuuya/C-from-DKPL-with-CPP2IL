namespace Live2D.Cubism.Framework.Physics;

public struct CubismPhysicsInput
{
	internal sealed class NormalizedParameterValueGetter : MulticastDelegate
	{

		public NormalizedParameterValueGetter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Vector2 targetTranslation, ref float targetAngle, CubismParameter parameter, ref float parameterValue, CubismPhysicsNormalization normalization, float weight, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Vector2 targetTranslation, ref float targetAngle, ref float parameterValue, IAsyncResult result) { }

		public override void Invoke(ref Vector2 targetTranslation, ref float targetAngle, CubismParameter parameter, ref float parameterValue, CubismPhysicsNormalization normalization, float weight) { }

	}

	[SerializeField]
	public string SourceId; //Field offset: 0x0
	[SerializeField]
	public Vector2 ScaleOfTranslation; //Field offset: 0x4
	[SerializeField]
	public float AngleScale; //Field offset: 0xC
	[SerializeField]
	public float Weight; //Field offset: 0x10
	[SerializeField]
	public CubismPhysicsSourceComponent SourceComponent; //Field offset: 0x14
	[SerializeField]
	public bool IsInverted; //Field offset: 0x18
	public CubismParameter Source; //Field offset: 0x1C
	public int SourceIndex; //Field offset: 0x20
	public NormalizedParameterValueGetter GetNormalizedParameterValue; //Field offset: 0x24

	private void GetInputAngleFromNormalizedParameterValue(ref Vector2 targetTranslation, ref float targetAngle, CubismParameter parameter, ref float parameterValue, CubismPhysicsNormalization normalization, float weight) { }

	private void GetInputTranslationXFromNormalizedParameterValue(ref Vector2 targetTranslation, ref float targetAngle, CubismParameter parameter, ref float parameterValue, CubismPhysicsNormalization normalization, float weight) { }

	private void GetInputTranslationYFromNormalizedParameterValue(ref Vector2 targetTranslation, ref float targetAngle, CubismParameter parameter, ref float parameterValue, CubismPhysicsNormalization normalization, float weight) { }

	public void InitializeGetter() { }

}

