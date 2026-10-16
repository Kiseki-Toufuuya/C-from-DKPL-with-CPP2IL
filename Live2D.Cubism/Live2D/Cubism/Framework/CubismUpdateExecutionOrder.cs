namespace Live2D.Cubism.Framework;

public static class CubismUpdateExecutionOrder
{
	public static readonly int CubismRepeatController; //Field offset: 0x0
	public static readonly int CubismFadeController; //Field offset: 0x4
	public static readonly int CubismParameterStoreSaveParameters; //Field offset: 0x8
	public static readonly int CubismPoseController; //Field offset: 0xC
	public static readonly int CubismExpressionController; //Field offset: 0x10
	public static readonly int CubismEyeBlinkController; //Field offset: 0x14
	public static readonly int CubismMouthController; //Field offset: 0x18
	public static readonly int CubismHarmonicMotionController; //Field offset: 0x1C
	public static readonly int CubismLookController; //Field offset: 0x20
	public static readonly int CubismPhysicsController; //Field offset: 0x24
	public static readonly int CubismRenderController; //Field offset: 0x28
	public static readonly int CubismMaskController; //Field offset: 0x2C
	public static readonly int CubismParametersInspector; //Field offset: 0x30
	public static readonly int CubismPartsInspector; //Field offset: 0x34

	private static CubismUpdateExecutionOrder() { }

	private static int CompareByExecutionOrder(ICubismUpdatable a, ICubismUpdatable b) { }

	public static void SortByExecutionOrder(List<ICubismUpdatable> updatables) { }

}

