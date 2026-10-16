namespace Cinemachine;

[DocumentationSorting(Level::Undoc (0))]
public static class RuntimeUtility
{
	private static RaycastHit[] s_HitBuffer; //Field offset: 0x0
	private static Int32[] s_PenetrationIndexBuffer; //Field offset: 0x4
	private static SphereCollider s_ScratchCollider; //Field offset: 0x8
	private static GameObject s_ScratchColliderGameObject; //Field offset: 0xC

	private static RuntimeUtility() { }

	public static void DestroyObject(object obj) { }

	internal static void DestroyScratchCollider() { }

	internal static SphereCollider GetScratchCollider() { }

	public static bool IsPrefab(GameObject gameObject) { }

	public static AnimationCurve NormalizeCurve(AnimationCurve curve, bool normalizeX, bool normalizeY) { }

	public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

}

