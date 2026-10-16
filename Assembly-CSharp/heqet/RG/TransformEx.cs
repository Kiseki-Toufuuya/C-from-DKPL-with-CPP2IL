namespace Heqet.RG;

[Extension]
public static class TransformEx
{

	[Extension]
	public static void AllChildrenDestroy(Transform self, GameObject exclude = null) { }

	[Extension]
	public static void FlipScaleX(Transform self) { }

	[Extension]
	public static void FlipScaleY(Transform self) { }

	[Extension]
	public static void FlipScaleZ(Transform self) { }

	[Extension]
	public static LocalTransform GetLocalTransform(Transform self) { }

	[Extension]
	public static void ResetLocalTransform(Transform self) { }

	[Extension]
	public static void SetLocalTransform(Transform self, LocalTransform local) { }

}

